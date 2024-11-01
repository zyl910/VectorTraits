#if NET7_0_OR_GREATER
#define BCL_HAS_SHUFFLE
#define VECTOR_HAS_METHOD
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Collections;
using Zyl.VectorTraits.Impl.Util;
using Zyl.VectorTraits.Numerics;

namespace Zyl.VectorTraits.Impl.AVector512 {
    partial class WVectorTraits512Base {

        partial class Statics {

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG2_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    if ((YShuffleKernel_AcceleratedTypes & TypeCodeFlags.Byte) != TypeCodeFlags.None) {
                        rt = TypeCodeFlagsUtil.AllTypes;
                    }
                    return rt;
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
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                return Vector512.Shuffle(source, Vector512Constants.YShuffleG2_Byte_Indices[(int)control]);
#else
                return YShuffleG2_Basic(source, control);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
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
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                return Vector512.Shuffle(source.AsByte(), Vector512Constants.YShuffleG2_UInt16_ByteIndices[(int)control]).AsUInt16();
#else
                return YShuffleG2_Basic(source, control);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
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
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                return Vector512.Shuffle(source.AsByte(), Vector512Constants.YShuffleG2_UInt32_ByteIndices[(int)control]).AsUInt32();
#else
                return YShuffleG2_Basic(source, control);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{long}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleG2(Vector512<long> source, ShuffleControlG2 control) {
                return YShuffleG2(source.AsUInt64(), control).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{ulong}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleG2(Vector512<ulong> source, ShuffleControlG2 control) {
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                return Vector512.Shuffle(source.AsByte(), Vector512Constants.YShuffleG2_UInt64_ByteIndices[(int)control]).AsUInt64();
#else
                return YShuffleG2_Basic(source, control);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{float}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleG2_Basic(Vector512<float> source, ShuffleControlG2 control) {
                return YShuffleG2_Basic(source.AsUInt32(), control).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{double}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleG2_Basic(Vector512<double> source, ShuffleControlG2 control) {
                return YShuffleG2_Basic(source.AsUInt64(), control).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{sbyte}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleG2_Basic(Vector512<sbyte> source, ShuffleControlG2 control) {
                return YShuffleG2_Basic(source.AsByte(), control).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{byte}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleG2_Basic(Vector512<byte> source, ShuffleControlG2 control) {
                Unsafe.SkipInit(out Vector512<byte> rt);
                ref byte q = ref Unsafe.As<Vector512<byte>, byte>(ref rt);
                ref byte p = ref Unsafe.As<Vector512<byte>, byte>(ref source);
                int ctl = (byte)control;
                for (int i = 0; i < Vector512<byte>.Count; ++i) {
                    int selectedIndex = (i & (~1)) | ((ctl >> (i & 1)) & 1);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{short}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleG2_Basic(Vector512<short> source, ShuffleControlG2 control) {
                return YShuffleG2_Basic(source.AsUInt16(), control).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{ushort}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleG2_Basic(Vector512<ushort> source, ShuffleControlG2 control) {
                Unsafe.SkipInit(out Vector512<ushort> rt);
                ref ushort q = ref Unsafe.As<Vector512<ushort>, ushort>(ref rt);
                ref ushort p = ref Unsafe.As<Vector512<ushort>, ushort>(ref source);
                int ctl = (byte)control;
                for (int i = 0; i < Vector512<ushort>.Count; ++i) {
                    int selectedIndex = (i & (~1)) | ((ctl >> (i & 1)) & 1);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{int}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleG2_Basic(Vector512<int> source, ShuffleControlG2 control) {
                return YShuffleG2_Basic(source.AsUInt32(), control).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleG2_Basic(Vector512<uint> source, ShuffleControlG2 control) {
                Unsafe.SkipInit(out Vector512<uint> rt);
                ref uint q = ref Unsafe.As<Vector512<uint>, uint>(ref rt);
                ref uint p = ref Unsafe.As<Vector512<uint>, uint>(ref source);
                int ctl = (byte)control;
                for (int i = 0; i < Vector512<uint>.Count; ++i) {
                    int selectedIndex = (i & (~1)) | ((ctl >> (i & 1)) & 1);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{long}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleG2_Basic(Vector512<long> source, ShuffleControlG2 control) {
                return YShuffleG2_Basic(source.AsUInt64(), control).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2(Vector512{ulong}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleG2_Basic(Vector512<ulong> source, ShuffleControlG2 control) {
                Unsafe.SkipInit(out Vector512<ulong> rt);
                ref ulong q = ref Unsafe.As<Vector512<ulong>, ulong>(ref rt);
                ref ulong p = ref Unsafe.As<Vector512<ulong>, ulong>(ref source);
                int ctl = (byte)control;
                for (int i = 0; i < Vector512<ulong>.Count; ++i) {
                    int selectedIndex = (i & (~1)) | ((ctl >> (i & 1)) & 1);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                return rt;
            }

#if !REDUCE_MEMORY_USAGE
            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{float}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleG2_Const(Vector512<float> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{double}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleG2_Const(Vector512<double> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
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
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{ushort}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleG2_Const(Vector512<ushort> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{int}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleG2_Const(Vector512<int> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleG2_Const(Vector512<uint> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{long}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleG2_Const(Vector512<long> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG2_Const(Vector512{ulong}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleG2_Const(Vector512<ulong> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }
#endif // !REDUCE_MEMORY_USAGE


            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG4_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    if ((YShuffleKernel_AcceleratedTypes & TypeCodeFlags.Byte) != TypeCodeFlags.None) {
                        rt = TypeCodeFlagsUtil.AllTypes;
                    }
                    return rt;
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
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                return Vector512.Shuffle(source, Vector512Constants.YShuffleG4_Byte_Indices[(int)control]);
#else
                return YShuffleG4_Basic(source, control);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
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
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                return Vector512.Shuffle(source.AsByte(), Vector512Constants.YShuffleG4_UInt16_ByteIndices[(int)control]).AsUInt16();
#else
                return YShuffleG4_Basic(source, control);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
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
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                return Vector512.Shuffle(source.AsByte(), Vector512Constants.YShuffleG4_UInt32_ByteIndices[(int)control]).AsUInt32();
#else
                return YShuffleG4_Basic(source, control);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{long}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleG4(Vector512<long> source, ShuffleControlG4 control) {
                return YShuffleG4(source.AsUInt64(), control).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{ulong}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleG4(Vector512<ulong> source, ShuffleControlG4 control) {
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                return Vector512.Shuffle(source.AsByte(), Vector512Constants.YShuffleG4_UInt64_ByteIndices[(int)control]).AsUInt64();
#else
                return YShuffleG4_Basic(source, control);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleG4_Basic(Vector512<float> source, ShuffleControlG4 control) {
                return YShuffleG4_Basic(source.AsUInt32(), control).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{double}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleG4_Basic(Vector512<double> source, ShuffleControlG4 control) {
                return YShuffleG4_Basic(source.AsUInt64(), control).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{sbyte}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleG4_Basic(Vector512<sbyte> source, ShuffleControlG4 control) {
                return YShuffleG4_Basic(source.AsByte(), control).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{byte}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleG4_Basic(Vector512<byte> source, ShuffleControlG4 control) {
                Unsafe.SkipInit(out Vector512<byte> rt);
                ref byte q = ref Unsafe.As<Vector512<byte>, byte>(ref rt);
                ref byte p = ref Unsafe.As<Vector512<byte>, byte>(ref source);
                int ctl = (byte)control;
                for (int i = 0; i < Vector512<byte>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{short}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleG4_Basic(Vector512<short> source, ShuffleControlG4 control) {
                return YShuffleG4_Basic(source.AsUInt16(), control).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{ushort}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleG4_Basic(Vector512<ushort> source, ShuffleControlG4 control) {
                Unsafe.SkipInit(out Vector512<ushort> rt);
                ref ushort q = ref Unsafe.As<Vector512<ushort>, ushort>(ref rt);
                ref ushort p = ref Unsafe.As<Vector512<ushort>, ushort>(ref source);
                int ctl = (byte)control;
                for (int i = 0; i < Vector512<ushort>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleG4_Basic(Vector512<int> source, ShuffleControlG4 control) {
                return YShuffleG4_Basic(source.AsUInt32(), control).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleG4_Basic(Vector512<uint> source, ShuffleControlG4 control) {
                Unsafe.SkipInit(out Vector512<uint> rt);
                ref uint q = ref Unsafe.As<Vector512<uint>, uint>(ref rt);
                ref uint p = ref Unsafe.As<Vector512<uint>, uint>(ref source);
                int ctl = (byte)control;
                for (int i = 0; i < Vector512<uint>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{long}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleG4_Basic(Vector512<long> source, ShuffleControlG4 control) {
                return YShuffleG4_Basic(source.AsUInt64(), control).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4(Vector512{ulong}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleG4_Basic(Vector512<ulong> source, ShuffleControlG4 control) {
                Unsafe.SkipInit(out Vector512<ulong> rt);
                ref ulong q = ref Unsafe.As<Vector512<ulong>, ulong>(ref rt);
                ref ulong p = ref Unsafe.As<Vector512<ulong>, ulong>(ref source);
                int ctl = (byte)control;
                for (int i = 0; i < Vector512<ulong>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleG4_Const(Vector512<float> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{double}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleG4_Const(Vector512<double> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
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
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{ushort}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleG4_Const(Vector512<ushort> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleG4_Const(Vector512<int> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleG4_Const(Vector512<uint> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{long}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleG4_Const(Vector512<long> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4_Const(Vector512{ulong}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleG4_Const(Vector512<ulong> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }


            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG4X2_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    if ((YShuffleKernel_AcceleratedTypes & TypeCodeFlags.Byte) != TypeCodeFlags.None) {
                        rt = TypeCodeFlagsUtil.AllTypes;
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{float}, Vector512{float}, ShuffleControlG4, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleG4X2(Vector512<float> source0, Vector512<float> source1, ShuffleControlG4 control, out Vector512<float> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{double}, Vector512{double}, ShuffleControlG4, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleG4X2(Vector512<double> source0, Vector512<double> source1, ShuffleControlG4 control, out Vector512<double> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{sbyte}, Vector512{sbyte}, ShuffleControlG4, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleG4X2(Vector512<sbyte> source0, Vector512<sbyte> source1, ShuffleControlG4 control, out Vector512<sbyte> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{byte}, Vector512{byte}, ShuffleControlG4, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleG4X2(Vector512<byte> source0, Vector512<byte> source1, ShuffleControlG4 control, out Vector512<byte> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{short}, Vector512{short}, ShuffleControlG4, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleG4X2(Vector512<short> source0, Vector512<short> source1, ShuffleControlG4 control, out Vector512<short> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{ushort}, Vector512{ushort}, ShuffleControlG4, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleG4X2(Vector512<ushort> source0, Vector512<ushort> source1, ShuffleControlG4 control, out Vector512<ushort> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{int}, Vector512{int}, ShuffleControlG4, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleG4X2(Vector512<int> source0, Vector512<int> source1, ShuffleControlG4 control, out Vector512<int> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{uint}, Vector512{uint}, ShuffleControlG4, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleG4X2(Vector512<uint> source0, Vector512<uint> source1, ShuffleControlG4 control, out Vector512<uint> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{long}, Vector512{long}, ShuffleControlG4, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleG4X2(Vector512<long> source0, Vector512<long> source1, ShuffleControlG4 control, out Vector512<long> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{ulong}, Vector512{ulong}, ShuffleControlG4, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleG4X2(Vector512<ulong> source0, Vector512<ulong> source1, ShuffleControlG4 control, out Vector512<ulong> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{float}, Vector512{float}, ShuffleControlG4, out Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleG4X2_Const(Vector512<float> source0, Vector512<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<float> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{double}, Vector512{double}, ShuffleControlG4, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleG4X2_Const(Vector512<double> source0, Vector512<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<double> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
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
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{ushort}, Vector512{ushort}, ShuffleControlG4, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleG4X2_Const(Vector512<ushort> source0, Vector512<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<ushort> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{int}, Vector512{int}, ShuffleControlG4, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleG4X2_Const(Vector512<int> source0, Vector512<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<int> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{uint}, Vector512{uint}, ShuffleControlG4, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleG4X2_Const(Vector512<uint> source0, Vector512<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<uint> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{long}, Vector512{long}, ShuffleControlG4, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleG4X2_Const(Vector512<long> source0, Vector512<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<long> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2_Const(Vector512{ulong}, Vector512{ulong}, ShuffleControlG4, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleG4X2_Const(Vector512<ulong> source0, Vector512<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<ulong> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }


            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleInsert_AcceleratedTypes {
                get {
                    return Shuffle_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleInsert(Vector512<float> back, Vector512<float> vector, Vector512<int> indices) {
                return YShuffleInsert(back.AsUInt32(), vector.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleInsert(Vector512<double> back, Vector512<double> vector, Vector512<long> indices) {
                return YShuffleInsert(back.AsUInt64(), vector.AsUInt64(), indices.AsUInt64()).AsDouble();
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
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                Vector512<byte> mask = Vector512.GreaterThan(Vector512.Create((byte)Vector512<byte>.Count), indices);
                Vector512<byte> raw = Vector512.Shuffle(vector, indices);
                Vector512<byte> rt = Vector512.ConditionalSelect(mask, raw, back);
                return rt;
#else
                return YShuffleInsert_Basic(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                Vector512<ushort> mask = Vector512.GreaterThan(Vector512.Create((ushort)Vector512<ushort>.Count), indices);
                Vector512<ushort> raw = Vector512.Shuffle(vector, indices);
                Vector512<ushort> rt = Vector512.ConditionalSelect(mask, raw, back);
                return rt;
#else
                return YShuffleInsert_Basic(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                Vector512<uint> mask = Vector512.GreaterThan(Vector512.Create((uint)Vector512<uint>.Count), indices);
                Vector512<uint> raw = Vector512.Shuffle(vector, indices);
                Vector512<uint> rt = Vector512.ConditionalSelect(mask, raw, back);
                return rt;
#else
                return YShuffleInsert_Basic(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                Vector512<ulong> mask = Vector512.GreaterThan(Vector512.Create((ulong)Vector512<ulong>.Count), indices);
                Vector512<ulong> raw = Vector512.Shuffle(vector, indices);
                Vector512<ulong> rt = Vector512.ConditionalSelect(mask, raw, back);
                return rt;
#else
                return YShuffleInsert_Basic(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleInsert_Basic(Vector512<byte> back, Vector512<byte> vector, Vector512<byte> indices) {
                Unsafe.SkipInit(out Vector512<byte> rt);
                byte cnt = (byte)Vector512<byte>.Count;
                ref byte q = ref Unsafe.As<Vector512<byte>, byte>(ref rt);
                ref byte p = ref Unsafe.As<Vector512<byte>, byte>(ref vector);
                ref byte pindices = ref Unsafe.As<Vector512<byte>, byte>(ref indices);
                ref byte pback = ref Unsafe.As<Vector512<byte>, byte>(ref back);
                for (nint i = 0; i < Vector512<byte>.Count; ++i) {
                    byte selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleInsert_Basic(Vector512<ushort> back, Vector512<ushort> vector, Vector512<ushort> indices) {
                Unsafe.SkipInit(out Vector512<ushort> rt);
                ushort cnt = (ushort)Vector512<ushort>.Count;
                ref ushort q = ref Unsafe.As<Vector512<ushort>, ushort>(ref rt);
                ref ushort p = ref Unsafe.As<Vector512<ushort>, ushort>(ref vector);
                ref ushort pindices = ref Unsafe.As<Vector512<ushort>, ushort>(ref indices);
                ref ushort pback = ref Unsafe.As<Vector512<ushort>, ushort>(ref back);
                for (nint i = 0; i < Vector512<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleInsert_Basic(Vector512<uint> back, Vector512<uint> vector, Vector512<uint> indices) {
                Unsafe.SkipInit(out Vector512<uint> rt);
                uint cnt = (uint)Vector512<uint>.Count;
                ref uint q = ref Unsafe.As<Vector512<uint>, uint>(ref rt);
                ref uint p = ref Unsafe.As<Vector512<uint>, uint>(ref vector);
                ref uint pindices = ref Unsafe.As<Vector512<uint>, uint>(ref indices);
                ref uint pback = ref Unsafe.As<Vector512<uint>, uint>(ref back);
                for (nint i = 0; i < Vector512<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, (int)selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleInsert_Basic(Vector512<ulong> back, Vector512<ulong> vector, Vector512<ulong> indices) {
                Unsafe.SkipInit(out Vector512<ulong> rt);
                ulong cnt = (ulong)Vector512<ulong>.Count;
                ref ulong q = ref Unsafe.As<Vector512<ulong>, ulong>(ref rt);
                ref ulong p = ref Unsafe.As<Vector512<ulong>, ulong>(ref vector);
                ref ulong pindices = ref Unsafe.As<Vector512<ulong>, ulong>(ref indices);
                ref ulong pback = ref Unsafe.As<Vector512<ulong>, ulong>(ref back);
                for (nint i = 0; i < Vector512<ulong>.Count; ++i) {
                    ulong selectedIndex = Unsafe.Add(ref pindices, i);
                    ulong selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, (int)selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                args2 = Vector512.GreaterThan(Vector512.Create((byte)Vector512<byte>.Count), indices.AsByte()).AsSByte();
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                args2 = Vector512.GreaterThan(Vector512.Create((byte)Vector512<byte>.Count), indices);
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                args2 = Vector512.GreaterThan(Vector512.Create((ushort)Vector512<ushort>.Count), indices.AsUInt16()).AsInt16();
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                args2 = Vector512.GreaterThan(Vector512.Create((ushort)Vector512<ushort>.Count), indices);
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                args2 = Vector512.GreaterThan(Vector512.Create((uint)Vector512<uint>.Count), indices.AsUInt32()).AsInt32();
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                args2 = Vector512.GreaterThan(Vector512.Create((uint)Vector512<uint>.Count), indices);
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                args2 = Vector512.GreaterThan(Vector512.Create((ulong)Vector512<ulong>.Count), indices.AsUInt64()).AsInt64();
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                args2 = Vector512.GreaterThan(Vector512.Create((ulong)Vector512<ulong>.Count), indices);
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }


            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleInsert_Core(Vector512<float> back, Vector512<float> vector, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2) {
                return YShuffleInsert_Core(back.AsUInt32(), vector.AsUInt32(), args0.AsUInt32(), args1.AsUInt32(), args2.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleInsert_Core(Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleInsert_Core(Vector512<double> back, Vector512<double> vector, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2) {
                return YShuffleInsert_Core(back.AsUInt64(), vector.AsUInt64(), args0.AsUInt64(), args1.AsUInt64(), args2.AsUInt64()).AsDouble();
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
                _ = args1;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                var raw = Vector512.Shuffle(vector, args0);
                var rt = Vector512.ConditionalSelect(args2, raw, back);
                return rt;
#else
                _ = args2;
                return YShuffleInsert_Basic(back, vector, args0);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                _ = args1;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                var raw = Vector512.Shuffle(vector, args0);
                var rt = Vector512.ConditionalSelect(args2, raw, back);
                return rt;
#else
                _ = args2;
                return YShuffleInsert_Basic(back, vector, args0);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                _ = args1;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                var raw = Vector512.Shuffle(vector, args0);
                var rt = Vector512.ConditionalSelect(args2, raw, back);
                return rt;
#else
                _ = args2;
                return YShuffleInsert_Basic(back, vector, args0);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                _ = args1;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                var raw = Vector512.Shuffle(vector, args0);
                var rt = Vector512.ConditionalSelect(args2, raw, back);
                return rt;
#else
                _ = args2;
                return YShuffleInsert_Basic(back, vector, args0);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }


            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleKernel_AcceleratedTypes {
                get {
                    return Shuffle_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleKernel(Vector512<float> vector, Vector512<int> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleKernel(Vector512<double> vector, Vector512<long> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleKernel(Vector512<sbyte> vector, Vector512<sbyte> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleKernel(Vector512<byte> vector, Vector512<byte> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleKernel(Vector512<short> vector, Vector512<short> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleKernel(Vector512<ushort> vector, Vector512<ushort> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleKernel(Vector512<int> vector, Vector512<int> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleKernel(Vector512<uint> vector, Vector512<uint> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleKernel(Vector512<long> vector, Vector512<long> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleKernel(Vector512<ulong> vector, Vector512<ulong> indices) {
                return Shuffle(vector, indices);
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
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{double}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleKernel_Core(Vector512<double> vector, Vector512<long> args0, Vector512<long> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleKernel_Core(Vector512<sbyte> vector, Vector512<sbyte> args0, Vector512<sbyte> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleKernel_Core(Vector512<byte> vector, Vector512<byte> args0, Vector512<byte> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleKernel_Core(Vector512<short> vector, Vector512<short> args0, Vector512<short> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleKernel_Core(Vector512<ushort> vector, Vector512<ushort> args0, Vector512<ushort> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleKernel_Core(Vector512<int> vector, Vector512<int> args0, Vector512<int> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleKernel_Core(Vector512<uint> vector, Vector512<uint> args0, Vector512<uint> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleKernel_Core(Vector512<long> vector, Vector512<long> args0, Vector512<long> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleKernel_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleKernel_Core(Vector512<ulong> vector, Vector512<ulong> args0, Vector512<ulong> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
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
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX2(Vector512<double> vector0, Vector512<double> vector1, Vector512<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX2(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX2(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX2(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX2(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX2(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX2(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX2(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX2(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX2_Basic(Vector512<float> vector0, Vector512<float> vector1, Vector512<int> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX2_Basic(Vector512<double> vector0, Vector512<double> vector1, Vector512<long> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX2_Basic(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX2_Basic(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX2_Basic(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX2_Basic(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX2_Basic(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX2_Basic(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX2_Basic(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX2_Basic(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

#if BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX2_Bit(Vector512<float> vector0, Vector512<float> vector1, Vector512<int> indices) {
                return YShuffleX2_Bit(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX2_Bit(Vector512<double> vector0, Vector512<double> vector1, Vector512<long> indices) {
                return YShuffleX2_Bit(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX2_Bit(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> indices) {
                return YShuffleX2_Bit(vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX2_Bit(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> indices) {
                const byte total = 2 * ByteCountValue / sizeof(byte); // 2 * Vector512<byte>.Count
                Vector512<byte> mask = Vector512.GreaterThan(Vector512.Create(total), indices);
                Vector512<byte> raw = YShuffleX2Kernel_Bit(vector0, vector1, indices);
                Vector512<byte> rt = Vector512.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX2_Bit(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> indices) {
                return YShuffleX2_Bit(vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX2_Bit(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> indices) {
                const ushort total = 2 * ByteCountValue / sizeof(ushort); // 2 * Vector512<ushort>.Count
                Vector512<ushort> mask = Vector512.GreaterThan(Vector512.Create(total), indices);
                Vector512<ushort> raw = YShuffleX2Kernel_Bit(vector0, vector1, indices);
                Vector512<ushort> rt = Vector512.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX2_Bit(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> indices) {
                return YShuffleX2_Bit(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX2_Bit(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> indices) {
                const uint total = 2 * ByteCountValue / sizeof(uint); // 2 * Vector512<uint>.Count
                Vector512<uint> mask = Vector512.GreaterThan(Vector512.Create(total), indices);
                Vector512<uint> raw = YShuffleX2Kernel_Bit(vector0, vector1, indices);
                Vector512<uint> rt = Vector512.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX2_Bit(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> indices) {
                return YShuffleX2_Bit(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX2_Bit(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> indices) {
                const ulong total = 2 * ByteCountValue / sizeof(ulong); // 2 * Vector512<ulong>.Count
                Vector512<ulong> mask = Vector512.GreaterThan(Vector512.Create(total), indices);
                Vector512<ulong> raw = YShuffleX2Kernel_Bit(vector0, vector1, indices);
                Vector512<ulong> rt = Vector512.BitwiseAnd(raw, mask);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3, out Vector512<sbyte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3, out Vector512<byte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3, out Vector512<short> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3, out Vector512<ushort> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3, out Vector512<int> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3, out Vector512<uint> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3, out Vector512<long> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3, out Vector512<ulong> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX2_Core(Vector512<float> vector0, Vector512<float> vector1, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX2_Core(Vector512<double> vector0, Vector512<double> vector1, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX2_Core(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX2_Core(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX2_Core(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX2_Core(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX2_Core(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX2_Core(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX2_Core(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX2_Core(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
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
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX2Insert(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX2Insert(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX2Insert(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX2Insert(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX2Insert(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX2Insert(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX2Insert(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX2Insert(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX2Insert(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
#else
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX2Insert_Basic(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<int> indices) {
                return YShuffleX2Insert_Basic(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX2Insert_Basic(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<long> indices) {
                return YShuffleX2Insert_Basic(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX2Insert_Basic(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> indices) {
                return YShuffleX2Insert_Basic(back.AsByte(), vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX2Insert_Basic(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> indices) {
                const byte total = 2 * ByteCountValue / sizeof(byte); // 2 * Vector512<byte>.Count
                Span<Vector512<byte>> rt = stackalloc Vector512<byte>[1];
                Span<Vector512<byte>> temp = [vector0, vector1];
                Span<byte> p = MemoryMarshal.Cast<Vector512<byte>, byte>(temp);
                Span<byte> q = MemoryMarshal.Cast<Vector512<byte>, byte>(rt);
                ref byte pindices = ref Unsafe.As<Vector512<byte>, byte>(ref indices);
                ref byte pback = ref Unsafe.As<Vector512<byte>, byte>(ref back);
                for (int i = 0; i < Vector512<byte>.Count; ++i) {
                    byte selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX2Insert_Basic(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> indices) {
                return YShuffleX2Insert_Basic(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX2Insert_Basic(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> indices) {
                const ushort total = 2 * ByteCountValue / sizeof(ushort); // 2 * Vector512<ushort>.Count
                Span<Vector512<ushort>> rt = stackalloc Vector512<ushort>[1];
                Span<Vector512<ushort>> temp = [vector0, vector1];
                Span<ushort> p = MemoryMarshal.Cast<Vector512<ushort>, ushort>(temp);
                Span<ushort> q = MemoryMarshal.Cast<Vector512<ushort>, ushort>(rt);
                ref ushort pindices = ref Unsafe.As<Vector512<ushort>, ushort>(ref indices);
                ref ushort pback = ref Unsafe.As<Vector512<ushort>, ushort>(ref back);
                for (int i = 0; i < Vector512<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX2Insert_Basic(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> indices) {
                return YShuffleX2Insert_Basic(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX2Insert_Basic(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> indices) {
                const uint total = 2 * ByteCountValue / sizeof(uint); // 2 * Vector512<uint>.Count
                Span<Vector512<uint>> rt = stackalloc Vector512<uint>[1];
                Span<Vector512<uint>> temp = [vector0, vector1];
                Span<uint> p = MemoryMarshal.Cast<Vector512<uint>, uint>(temp);
                Span<uint> q = MemoryMarshal.Cast<Vector512<uint>, uint>(rt);
                ref uint pindices = ref Unsafe.As<Vector512<uint>, uint>(ref indices);
                ref uint pback = ref Unsafe.As<Vector512<uint>, uint>(ref back);
                for (int i = 0; i < Vector512<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[(int)selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX2Insert_Basic(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> indices) {
                return YShuffleX2Insert_Basic(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX2Insert_Basic(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> indices) {
                const ulong total = 2 * ByteCountValue / sizeof(ulong); // 2 * Vector512<ulong>.Count
                Span<Vector512<ulong>> rt = stackalloc Vector512<ulong>[1];
                Span<Vector512<ulong>> temp = [vector0, vector1];
                Span<ulong> p = MemoryMarshal.Cast<Vector512<ulong>, ulong>(temp);
                Span<ulong> q = MemoryMarshal.Cast<Vector512<ulong>, ulong>(rt);
                ref ulong pindices = ref Unsafe.As<Vector512<ulong>, ulong>(ref indices);
                ref ulong pback = ref Unsafe.As<Vector512<ulong>, ulong>(ref back);
                for (int i = 0; i < Vector512<ulong>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX2Insert_Bit(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<int> indices) {
                return YShuffleX2Insert_Bit(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX2Insert_Bit(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<long> indices) {
                return YShuffleX2Insert_Bit(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX2Insert_Bit(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> indices) {
                return YShuffleX2Insert_Bit(back.AsByte(), vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX2Insert_Bit(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> indices) {
                const byte total = 2 * ByteCountValue / sizeof(byte); // 2 * Vector512<byte>.Count
                Vector512<byte> mask = Vector512.GreaterThan(Vector512.Create(total), indices);
                Vector512<byte> raw = YShuffleX2Kernel_Bit(vector0, vector1, indices);
                Vector512<byte> rt = Vector512.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX2Insert_Bit(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> indices) {
                return YShuffleX2Insert_Bit(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX2Insert_Bit(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> indices) {
                const ushort total = 2 * ByteCountValue / sizeof(ushort); // 2 * Vector512<ushort>.Count
                Vector512<ushort> mask = Vector512.GreaterThan(Vector512.Create(total), indices);
                Vector512<ushort> raw = YShuffleX2Kernel_Bit(vector0, vector1, indices);
                Vector512<ushort> rt = Vector512.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX2Insert_Bit(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> indices) {
                return YShuffleX2Insert_Bit(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX2Insert_Bit(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> indices) {
                const uint total = 2 * ByteCountValue / sizeof(uint); // 2 * Vector512<uint>.Count
                Vector512<uint> mask = Vector512.GreaterThan(Vector512.Create(total), indices);
                Vector512<uint> raw = YShuffleX2Kernel_Bit(vector0, vector1, indices);
                Vector512<uint> rt = Vector512.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX2Insert_Bit(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> indices) {
                return YShuffleX2Insert_Bit(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX2Insert_Bit(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> indices) {
                const ulong total = 2 * ByteCountValue / sizeof(ulong); // 2 * Vector512<ulong>.Count
                Vector512<ulong> mask = Vector512.GreaterThan(Vector512.Create(total), indices);
                Vector512<ulong> raw = YShuffleX2Kernel_Bit(vector0, vector1, indices);
                Vector512<ulong> rt = Vector512.ConditionalSelect(mask, raw, back);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3, out Vector512<sbyte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3, out Vector512<byte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3, out Vector512<short> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3, out Vector512<ushort> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3, out Vector512<int> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3, out Vector512<uint> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3, out Vector512<long> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3, out Vector512<ulong> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX2Insert_Core(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX2Insert_Core(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX2Insert_Core(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX2Insert_Core(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX2Insert_Core(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX2Insert_Core(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX2Insert_Core(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX2Insert_Core(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX2Insert_Core(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Insert_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX2Insert_Core(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }


            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX2Kernel_AcceleratedTypes {
                get {
                    return Shuffle_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX2Kernel(Vector512<float> vector0, Vector512<float> vector1, Vector512<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX2Kernel(Vector512<double> vector0, Vector512<double> vector1, Vector512<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX2Kernel(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX2Kernel(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX2Kernel(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX2Kernel(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX2Kernel(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX2Kernel(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX2Kernel(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX2Kernel(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX2Kernel_Basic(Vector512<float> vector0, Vector512<float> vector1, Vector512<int> indices) {
                return YShuffleX2Kernel_Basic(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX2Kernel_Basic(Vector512<double> vector0, Vector512<double> vector1, Vector512<long> indices) {
                return YShuffleX2Kernel_Basic(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX2Kernel_Basic(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> indices) {
                return YShuffleX2Kernel_Basic(vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX2Kernel_Basic(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> indices) {
                const byte total = 2 * ByteCountValue / sizeof(byte); // 2 * Vector512<byte>.Count
                Span<Vector512<byte>> rt = stackalloc Vector512<byte>[1];
                Span<Vector512<byte>> temp = [vector0, vector1];
                Span<byte> p = MemoryMarshal.Cast<Vector512<byte>, byte>(temp);
                Span<byte> q = MemoryMarshal.Cast<Vector512<byte>, byte>(rt);
                ref byte pindices = ref Unsafe.As<Vector512<byte>, byte>(ref indices);
                for (int i = 0; i < Vector512<byte>.Count; ++i) {
                    byte selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX2Kernel_Basic(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> indices) {
                return YShuffleX2Kernel_Basic(vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX2Kernel_Basic(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> indices) {
                const ushort total = 2 * ByteCountValue / sizeof(ushort); // 2 * Vector512<ushort>.Count
                Span<Vector512<ushort>> rt = stackalloc Vector512<ushort>[1];
                Span<Vector512<ushort>> temp = [vector0, vector1];
                Span<ushort> p = MemoryMarshal.Cast<Vector512<ushort>, ushort>(temp);
                Span<ushort> q = MemoryMarshal.Cast<Vector512<ushort>, ushort>(rt);
                ref ushort pindices = ref Unsafe.As<Vector512<ushort>, ushort>(ref indices);
                for (int i = 0; i < Vector512<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX2Kernel_Basic(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> indices) {
                return YShuffleX2Kernel_Basic(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX2Kernel_Basic(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> indices) {
                const uint total = 2 * ByteCountValue / sizeof(uint); // 2 * Vector512<uint>.Count
                Span<Vector512<uint>> rt = stackalloc Vector512<uint>[1];
                Span<Vector512<uint>> temp = [vector0, vector1];
                Span<uint> p = MemoryMarshal.Cast<Vector512<uint>, uint>(temp);
                Span<uint> q = MemoryMarshal.Cast<Vector512<uint>, uint>(rt);
                ref uint pindices = ref Unsafe.As<Vector512<uint>, uint>(ref indices);
                for (int i = 0; i < Vector512<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[(int)selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX2Kernel_Basic(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> indices) {
                return YShuffleX2Kernel_Basic(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX2Kernel_Basic(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> indices) {
                const ulong total = 2 * ByteCountValue / sizeof(ulong); // 2 * Vector512<ulong>.Count
                Span<Vector512<ulong>> rt = stackalloc Vector512<ulong>[1];
                Span<Vector512<ulong>> temp = [vector0, vector1];
                Span<ulong> p = MemoryMarshal.Cast<Vector512<ulong>, ulong>(temp);
                Span<ulong> q = MemoryMarshal.Cast<Vector512<ulong>, ulong>(rt);
                ref ulong pindices = ref Unsafe.As<Vector512<ulong>, ulong>(ref indices);
                for (int i = 0; i < Vector512<ulong>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX2Kernel_Bit(Vector512<float> vector0, Vector512<float> vector1, Vector512<int> indices) {
                return YShuffleX2Kernel_Bit(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX2Kernel_Bit(Vector512<double> vector0, Vector512<double> vector1, Vector512<long> indices) {
                return YShuffleX2Kernel_Bit(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX2Kernel_Bit(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> indices) {
                return YShuffleX2Kernel_Bit(vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX2Kernel_Bit(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> indices) {
                Vector512<byte> vCount = Vector512.Create((byte)Vector512<byte>.Count);
                Vector512<byte> indices1 = Vector512.Subtract(indices, vCount);
                Vector512<byte> rt0 = Vector512.Shuffle(vector0, indices);
                Vector512<byte> rt1 = Vector512.Shuffle(vector1, indices1);
                Vector512<byte> rt = Vector512.BitwiseOr(rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX2Kernel_Bit(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> indices) {
                return YShuffleX2Kernel_Bit(vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX2Kernel_Bit(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> indices) {
                Vector512<ushort> vCount = Vector512.Create((ushort)Vector512<ushort>.Count);
                Vector512<ushort> indices1 = Vector512.Subtract(indices, vCount);
                Vector512<ushort> rt0 = Vector512.Shuffle(vector0, indices);
                Vector512<ushort> rt1 = Vector512.Shuffle(vector1, indices1);
                Vector512<ushort> rt = Vector512.BitwiseOr(rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX2Kernel_Bit(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> indices) {
                return YShuffleX2Kernel_Bit(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX2Kernel_Bit(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> indices) {
                Vector512<uint> vCount = Vector512.Create((uint)Vector512<uint>.Count);
                Vector512<uint> indices1 = Vector512.Subtract(indices, vCount);
                Vector512<uint> rt0 = Vector512.Shuffle(vector0, indices);
                Vector512<uint> rt1 = Vector512.Shuffle(vector1, indices1);
                Vector512<uint> rt = Vector512.BitwiseOr(rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX2Kernel_Bit(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> indices) {
                return YShuffleX2Kernel_Bit(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX2Kernel_Bit(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> indices) {
                Vector512<ulong> vCount = Vector512.Create((ulong)Vector512<ulong>.Count);
                Vector512<ulong> indices1 = Vector512.Subtract(indices, vCount);
                Vector512<ulong> rt0 = Vector512.Shuffle(vector0, indices);
                Vector512<ulong> rt1 = Vector512.Shuffle(vector1, indices1);
                Vector512<ulong> rt = Vector512.BitwiseOr(rt0, rt1);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
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
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
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
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
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
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
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
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX2Kernel_Core(Vector512<double> vector0, Vector512<double> vector1, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX2Kernel_Core(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX2Kernel_Core(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX2Kernel_Core(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX2Kernel_Core(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX2Kernel_Core(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX2Kernel_Core(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX2Kernel_Core(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX2Kernel_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX2Kernel_Core(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
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
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX3(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX3(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX3(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX3(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX3(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX3(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX3(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX3(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX3(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX3_Basic(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX3_Basic(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX3_Basic(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> indices) {
                Vector512<sbyte> mask, raw, rt;
                mask = Vector512.GreaterThanOrEqual(indices, Vector512<sbyte>.Zero); // i >= 0
                raw = YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
                rt = Vector512.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX3_Basic(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX3_Basic(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX3_Basic(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX3_Basic(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX3_Basic(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX3_Basic(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX3_Basic(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

#if BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX3_Bit(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> indices) {
                return YShuffleX3_Bit(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX3_Bit(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> indices) {
                return YShuffleX3_Bit(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX3_Bit(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> indices) {
                //return YShuffleX3_Bit(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
                Vector512<sbyte> mask, raw, rt;
                mask = Vector512.GreaterThanOrEqual(indices, Vector512<sbyte>.Zero); // i >= 0
                raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                rt = Vector512.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX3_Bit(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> indices) {
                const byte total = 3 * ByteCountValue / sizeof(byte); // 3 * Vector512<byte>.Count
                Vector512<byte> mask = Vector512.GreaterThan(Vector512.Create(total), indices);
                Vector512<byte> raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                Vector512<byte> rt = Vector512.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX3_Bit(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> indices) {
                return YShuffleX3_Bit(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX3_Bit(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> indices) {
                const ushort total = 3 * ByteCountValue / sizeof(ushort); // 3 * Vector512<ushort>.Count
                Vector512<ushort> mask = Vector512.GreaterThan(Vector512.Create(total), indices);
                Vector512<ushort> raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                Vector512<ushort> rt = Vector512.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX3_Bit(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> indices) {
                return YShuffleX3_Bit(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX3_Bit(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> indices) {
                const uint total = 3 * ByteCountValue / sizeof(uint); // 3 * Vector512<uint>.Count
                Vector512<uint> mask = Vector512.GreaterThan(Vector512.Create(total), indices);
                Vector512<uint> raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                Vector512<uint> rt = Vector512.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX3_Bit(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> indices) {
                return YShuffleX3_Bit(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX3_Bit(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> indices) {
                const ulong total = 3 * ByteCountValue / sizeof(ulong); // 3 * Vector512<ulong>.Count
                Vector512<ulong> mask = Vector512.GreaterThan(Vector512.Create(total), indices);
                Vector512<ulong> raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                Vector512<ulong> rt = Vector512.BitwiseAnd(raw, mask);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3, out Vector512<sbyte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3, out Vector512<byte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3, out Vector512<short> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3, out Vector512<ushort> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3, out Vector512<int> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3, out Vector512<uint> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3, out Vector512<long> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3, out Vector512<ulong> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX3_Core(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX3_Core(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX3_Core(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX3_Core(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX3_Core(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX3_Core(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX3_Core(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX3_Core(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX3_Core(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX3_Core(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
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
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX3Insert(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX3Insert(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX3Insert(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX3Insert(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX3Insert(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX3Insert(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX3Insert(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX3Insert(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX3Insert(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX3Insert_Basic(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> indices) {
                return YShuffleX3Insert_Basic(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX3Insert_Basic(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> indices) {
                return YShuffleX3Insert_Basic(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX3Insert_Basic(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> indices) {
                Vector512<sbyte> mask, raw, rt;
                mask = Vector512.GreaterThanOrEqual(indices, Vector512<sbyte>.Zero); // i >= 0
                raw = YShuffleX3Insert_Basic(back.AsByte(), vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
                rt = Vector512.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX3Insert_Basic(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> indices) {
                const byte total = 3 * ByteCountValue / sizeof(byte); // 3 * Vector512<byte>.Count
                Span<Vector512<byte>> rt = stackalloc Vector512<byte>[1];
                Span<Vector512<byte>> temp = [vector0, vector1, vector2];
                Span<byte> p = MemoryMarshal.Cast<Vector512<byte>, byte>(temp);
                Span<byte> q = MemoryMarshal.Cast<Vector512<byte>, byte>(rt);
                ref byte pindices = ref Unsafe.As<Vector512<byte>, byte>(ref indices);
                ref byte pback = ref Unsafe.As<Vector512<byte>, byte>(ref back);
                for (int i = 0; i < Vector512<byte>.Count; ++i) {
                    byte selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX3Insert_Basic(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> indices) {
                return YShuffleX3Insert_Basic(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX3Insert_Basic(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> indices) {
                const ushort total = 3 * ByteCountValue / sizeof(ushort); // 3 * Vector512<ushort>.Count
                Span<Vector512<ushort>> rt = stackalloc Vector512<ushort>[1];
                Span<Vector512<ushort>> temp = [vector0, vector1, vector2];
                Span<ushort> p = MemoryMarshal.Cast<Vector512<ushort>, ushort>(temp);
                Span<ushort> q = MemoryMarshal.Cast<Vector512<ushort>, ushort>(rt);
                ref ushort pindices = ref Unsafe.As<Vector512<ushort>, ushort>(ref indices);
                ref ushort pback = ref Unsafe.As<Vector512<ushort>, ushort>(ref back);
                for (int i = 0; i < Vector512<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX3Insert_Basic(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> indices) {
                return YShuffleX3Insert_Basic(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX3Insert_Basic(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> indices) {
                const uint total = 3 * ByteCountValue / sizeof(uint); // 3 * Vector512<uint>.Count
                Span<Vector512<uint>> rt = stackalloc Vector512<uint>[1];
                Span<Vector512<uint>> temp = [vector0, vector1, vector2];
                Span<uint> p = MemoryMarshal.Cast<Vector512<uint>, uint>(temp);
                Span<uint> q = MemoryMarshal.Cast<Vector512<uint>, uint>(rt);
                ref uint pindices = ref Unsafe.As<Vector512<uint>, uint>(ref indices);
                ref uint pback = ref Unsafe.As<Vector512<uint>, uint>(ref back);
                for (int i = 0; i < Vector512<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[(int)selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX3Insert_Basic(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> indices) {
                return YShuffleX3Insert_Basic(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX3Insert_Basic(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> indices) {
                const ulong total = 3 * ByteCountValue / sizeof(ulong); // 3 * Vector512<ulong>.Count
                Span<Vector512<ulong>> rt = stackalloc Vector512<ulong>[1];
                Span<Vector512<ulong>> temp = [vector0, vector1, vector2];
                Span<ulong> p = MemoryMarshal.Cast<Vector512<ulong>, ulong>(temp);
                Span<ulong> q = MemoryMarshal.Cast<Vector512<ulong>, ulong>(rt);
                ref ulong pindices = ref Unsafe.As<Vector512<ulong>, ulong>(ref indices);
                ref ulong pback = ref Unsafe.As<Vector512<ulong>, ulong>(ref back);
                for (int i = 0; i < Vector512<ulong>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX3Insert_Bit(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> indices) {
                return YShuffleX3Insert_Bit(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX3Insert_Bit(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> indices) {
                return YShuffleX3Insert_Bit(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX3Insert_Bit(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> indices) {
                Vector512<sbyte> mask, raw, rt;
                mask = Vector512.GreaterThanOrEqual(indices, Vector512<sbyte>.Zero); // i >= 0
                raw = YShuffleX3Insert_Bit(back.AsByte(), vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
                rt = Vector512.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX3Insert_Bit(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> indices) {
                const byte total = 3 * ByteCountValue / sizeof(byte); // 3 * Vector512<byte>.Count
                Vector512<byte> mask = Vector512.GreaterThan(Vector512.Create(total), indices);
                Vector512<byte> raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                Vector512<byte> rt = Vector512.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX3Insert_Bit(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> indices) {
                return YShuffleX3Insert_Bit(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX3Insert_Bit(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> indices) {
                const ushort total = 3 * ByteCountValue / sizeof(ushort); // 3 * Vector512<ushort>.Count
                Vector512<ushort> mask = Vector512.GreaterThan(Vector512.Create(total), indices);
                Vector512<ushort> raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                Vector512<ushort> rt = Vector512.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX3Insert_Bit(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> indices) {
                return YShuffleX3Insert_Bit(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX3Insert_Bit(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> indices) {
                const uint total = 3 * ByteCountValue / sizeof(uint); // 3 * Vector512<uint>.Count
                Vector512<uint> mask = Vector512.GreaterThan(Vector512.Create(total), indices);
                Vector512<uint> raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                Vector512<uint> rt = Vector512.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX3Insert_Bit(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> indices) {
                return YShuffleX3Insert_Bit(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX3Insert_Bit(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> indices) {
                const ulong total = 3 * ByteCountValue / sizeof(ulong); // 3 * Vector512<ulong>.Count
                Vector512<ulong> mask = Vector512.GreaterThan(Vector512.Create(total), indices);
                Vector512<ulong> raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                Vector512<ulong> rt = Vector512.ConditionalSelect(mask, raw, back);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3, out Vector512<sbyte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3, out Vector512<byte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3, out Vector512<short> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3, out Vector512<ushort> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3, out Vector512<int> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3, out Vector512<uint> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3, out Vector512<long> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3, out Vector512<ulong> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX3Insert_Core(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX3Insert_Core(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX3Insert_Core(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX3Insert_Core(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX3Insert_Core(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX3Insert_Core(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX3Insert_Core(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX3Insert_Core(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX3Insert_Core(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Insert_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX3Insert_Core(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }


            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX3Kernel_AcceleratedTypes {
                get {
                    return Shuffle_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX3Kernel(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX3Kernel(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX3Kernel(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX3Kernel(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX3Kernel(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX3Kernel(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX3Kernel(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX3Kernel(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX3Kernel(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX3Kernel(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX3Kernel_Basic(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> indices) {
                return YShuffleX3Kernel_Basic(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX3Kernel_Basic(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> indices) {
                return YShuffleX3Kernel_Basic(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX3Kernel_Basic(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> indices) {
                return YShuffleX3Kernel_Basic(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX3Kernel_Basic(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> indices) {
                const byte total = 3 * ByteCountValue / sizeof(byte); // 3 * Vector512<byte>.Count
                Span<Vector512<byte>> rt = stackalloc Vector512<byte>[1];
                Span<Vector512<byte>> temp = [vector0, vector1, vector2];
                Span<byte> p = MemoryMarshal.Cast<Vector512<byte>, byte>(temp);
                Span<byte> q = MemoryMarshal.Cast<Vector512<byte>, byte>(rt);
                ref byte pindices = ref Unsafe.As<Vector512<byte>, byte>(ref indices);
                for (int i = 0; i < Vector512<byte>.Count; ++i) {
                    byte selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX3Kernel_Basic(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> indices) {
                return YShuffleX3Kernel_Basic(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX3Kernel_Basic(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> indices) {
                const ushort total = 3 * ByteCountValue / sizeof(ushort); // 3 * Vector512<ushort>.Count
                Span<Vector512<ushort>> rt = stackalloc Vector512<ushort>[1];
                Span<Vector512<ushort>> temp = [vector0, vector1, vector2];
                Span<ushort> p = MemoryMarshal.Cast<Vector512<ushort>, ushort>(temp);
                Span<ushort> q = MemoryMarshal.Cast<Vector512<ushort>, ushort>(rt);
                ref ushort pindices = ref Unsafe.As<Vector512<ushort>, ushort>(ref indices);
                for (int i = 0; i < Vector512<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX3Kernel_Basic(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> indices) {
                return YShuffleX3Kernel_Basic(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX3Kernel_Basic(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> indices) {
                const uint total = 3 * ByteCountValue / sizeof(uint); // 3 * Vector512<uint>.Count
                Span<Vector512<uint>> rt = stackalloc Vector512<uint>[1];
                Span<Vector512<uint>> temp = [vector0, vector1, vector2];
                Span<uint> p = MemoryMarshal.Cast<Vector512<uint>, uint>(temp);
                Span<uint> q = MemoryMarshal.Cast<Vector512<uint>, uint>(rt);
                ref uint pindices = ref Unsafe.As<Vector512<uint>, uint>(ref indices);
                for (int i = 0; i < Vector512<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[(int)selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX3Kernel_Basic(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> indices) {
                return YShuffleX3Kernel_Basic(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX3Kernel_Basic(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> indices) {
                const ulong total = 3 * ByteCountValue / sizeof(ulong); // 3 * Vector512<ulong>.Count
                Span<Vector512<ulong>> rt = stackalloc Vector512<ulong>[1];
                Span<Vector512<ulong>> temp = [vector0, vector1, vector2];
                Span<ulong> p = MemoryMarshal.Cast<Vector512<ulong>, ulong>(temp);
                Span<ulong> q = MemoryMarshal.Cast<Vector512<ulong>, ulong>(rt);
                ref ulong pindices = ref Unsafe.As<Vector512<ulong>, ulong>(ref indices);
                for (int i = 0; i < Vector512<ulong>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX3Kernel_Bit(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> indices) {
                return YShuffleX3Kernel_Bit(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX3Kernel_Bit(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> indices) {
                return YShuffleX3Kernel_Bit(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX3Kernel_Bit(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> indices) {
                return YShuffleX3Kernel_Bit(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX3Kernel_Bit(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> indices) {
                Vector512<byte> vCount = Vector512.Create((byte)Vector512<byte>.Count);
                Vector512<byte> indices1 = Vector512.Subtract(indices, vCount);
                Vector512<byte> indices2 = Vector512.Subtract(indices1, vCount);
                Vector512<byte> rt0 = Vector512.Shuffle(vector0, indices);
                Vector512<byte> rt1 = Vector512.Shuffle(vector1, indices1);
                Vector512<byte> rt2 = Vector512.Shuffle(vector2, indices2);
                rt0 = Vector512.BitwiseOr(rt0, rt1);
                Vector512<byte> rt = Vector512.BitwiseOr(rt0, rt2);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX3Kernel_Bit(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> indices) {
                return YShuffleX3Kernel_Bit(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX3Kernel_Bit(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> indices) {
                Vector512<ushort> vCount = Vector512.Create((ushort)Vector512<ushort>.Count);
                Vector512<ushort> indices1 = Vector512.Subtract(indices, vCount);
                Vector512<ushort> indices2 = Vector512.Subtract(indices1, vCount);
                Vector512<ushort> rt0 = Vector512.Shuffle(vector0, indices);
                Vector512<ushort> rt1 = Vector512.Shuffle(vector1, indices1);
                Vector512<ushort> rt2 = Vector512.Shuffle(vector2, indices2);
                rt0 = Vector512.BitwiseOr(rt0, rt1);
                Vector512<ushort> rt = Vector512.BitwiseOr(rt0, rt2);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX3Kernel_Bit(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> indices) {
                return YShuffleX3Kernel_Bit(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX3Kernel_Bit(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> indices) {
                Vector512<uint> vCount = Vector512.Create((uint)Vector512<uint>.Count);
                Vector512<uint> indices1 = Vector512.Subtract(indices, vCount);
                Vector512<uint> indices2 = Vector512.Subtract(indices1, vCount);
                Vector512<uint> rt0 = Vector512.Shuffle(vector0, indices);
                Vector512<uint> rt1 = Vector512.Shuffle(vector1, indices1);
                Vector512<uint> rt2 = Vector512.Shuffle(vector2, indices2);
                rt0 = Vector512.BitwiseOr(rt0, rt1);
                Vector512<uint> rt = Vector512.BitwiseOr(rt0, rt2);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX3Kernel_Bit(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> indices) {
                return YShuffleX3Kernel_Bit(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX3Kernel_Bit(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> indices) {
                Vector512<ulong> vCount = Vector512.Create((ulong)Vector512<ulong>.Count);
                Vector512<ulong> indices1 = Vector512.Subtract(indices, vCount);
                Vector512<ulong> indices2 = Vector512.Subtract(indices1, vCount);
                Vector512<ulong> rt0 = Vector512.Shuffle(vector0, indices);
                Vector512<ulong> rt1 = Vector512.Shuffle(vector1, indices1);
                Vector512<ulong> rt2 = Vector512.Shuffle(vector2, indices2);
                rt0 = Vector512.BitwiseOr(rt0, rt1);
                Vector512<ulong> rt = Vector512.BitwiseOr(rt0, rt2);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX3Kernel_Core(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX3Kernel_Core(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX3Kernel_Core(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX3Kernel_Core(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX3Kernel_Core(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX3Kernel_Core(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX3Kernel_Core(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX3Kernel_Core(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX3Kernel_Core(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX3Kernel_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX3Kernel_Core(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
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
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX4(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX4(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX4(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX4(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX4(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX4(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX4(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX4(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX4(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX4_Basic(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX4_Basic(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX4_Basic(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> indices) {
                Vector512<sbyte> mask, raw, rt;
                mask = Vector512.GreaterThanOrEqual(indices, Vector512<sbyte>.Zero); // i >= 0
                raw = YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices).AsSByte();
                rt = Vector512.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX4_Basic(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX4_Basic(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX4_Basic(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX4_Basic(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX4_Basic(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX4_Basic(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX4_Basic(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

#if BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX4_Bit(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> indices) {
                return YShuffleX4_Bit(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX4_Bit(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> indices) {
                return YShuffleX4_Bit(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX4_Bit(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> indices) {
                Vector512<sbyte> mask, raw, rt;
                mask = Vector512.GreaterThanOrEqual(indices, Vector512<sbyte>.Zero); // i >= 0
                raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices).AsSByte();
                rt = Vector512.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX4_Bit(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> indices) {
                //const byte total = 4 * ByteCountValue / sizeof(byte); // 4 * Vector512<byte>.Count // Number overflow
                return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX4_Bit(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> indices) {
                return YShuffleX4_Bit(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX4_Bit(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> indices) {
                const ushort total = 4 * ByteCountValue / sizeof(ushort); // 4 * Vector512<ushort>.Count
                Vector512<ushort> mask = Vector512.GreaterThan(Vector512.Create(total), indices);
                Vector512<ushort> raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                Vector512<ushort> rt = Vector512.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX4_Bit(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> indices) {
                return YShuffleX4_Bit(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX4_Bit(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> indices) {
                const uint total = 4 * ByteCountValue / sizeof(uint); // 4 * Vector512<uint>.Count
                Vector512<uint> mask = Vector512.GreaterThan(Vector512.Create(total), indices);
                Vector512<uint> raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                Vector512<uint> rt = Vector512.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX4_Bit(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> indices) {
                return YShuffleX4_Bit(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX4_Bit(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> indices) {
                const ulong total = 4 * ByteCountValue / sizeof(ulong); // 4 * Vector512<ulong>.Count
                Vector512<ulong> mask = Vector512.GreaterThan(Vector512.Create(total), indices);
                Vector512<ulong> raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                Vector512<ulong> rt = Vector512.BitwiseAnd(raw, mask);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3, out Vector512<sbyte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3, out Vector512<byte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3, out Vector512<short> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3, out Vector512<ushort> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3, out Vector512<int> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3, out Vector512<uint> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3, out Vector512<long> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3, out Vector512<ulong> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX4_Core(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX4_Core(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX4_Core(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX4_Core(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX4_Core(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX4_Core(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX4_Core(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX4_Core(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX4_Core(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX4_Core(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
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
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX4Insert(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX4Insert(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX4Insert(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX4Insert(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX4Insert(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX4Insert(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX4Insert(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX4Insert(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX4Insert(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX4Insert_Basic(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> indices) {
                return YShuffleX4Insert_Basic(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX4Insert_Basic(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> indices) {
                return YShuffleX4Insert_Basic(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX4Insert_Basic(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> indices) {
                Vector512<sbyte> mask, raw, rt;
                mask = Vector512.GreaterThanOrEqual(indices, Vector512<sbyte>.Zero); // i >= 0
                raw = YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
                rt = Vector512.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX4Insert_Basic(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> indices) {
                const ushort total = 4 * ByteCountValue / sizeof(byte); // 4 * Vector512<byte>.Count
                Span<Vector512<byte>> rt = stackalloc Vector512<byte>[1];
                Span<Vector512<byte>> temp = [vector0, vector1, vector2, vector3];
                Span<byte> p = MemoryMarshal.Cast<Vector512<byte>, byte>(temp);
                Span<byte> q = MemoryMarshal.Cast<Vector512<byte>, byte>(rt);
                ref byte pindices = ref Unsafe.As<Vector512<byte>, byte>(ref indices);
                ref byte pback = ref Unsafe.As<Vector512<byte>, byte>(ref back);
                for (int i = 0; i < Vector512<byte>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX4Insert_Basic(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> indices) {
                return YShuffleX4Insert_Basic(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX4Insert_Basic(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> indices) {
                const ushort total = 4 * ByteCountValue / sizeof(ushort); // 4 * Vector512<ushort>.Count
                Span<Vector512<ushort>> rt = stackalloc Vector512<ushort>[1];
                Span<Vector512<ushort>> temp = [vector0, vector1, vector2, vector3];
                Span<ushort> p = MemoryMarshal.Cast<Vector512<ushort>, ushort>(temp);
                Span<ushort> q = MemoryMarshal.Cast<Vector512<ushort>, ushort>(rt);
                ref ushort pindices = ref Unsafe.As<Vector512<ushort>, ushort>(ref indices);
                ref ushort pback = ref Unsafe.As<Vector512<ushort>, ushort>(ref back);
                for (int i = 0; i < Vector512<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX4Insert_Basic(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> indices) {
                return YShuffleX4Insert_Basic(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX4Insert_Basic(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> indices) {
                const uint total = 4 * ByteCountValue / sizeof(uint); // 4 * Vector512<uint>.Count
                Span<Vector512<uint>> rt = stackalloc Vector512<uint>[1];
                Span<Vector512<uint>> temp = [vector0, vector1, vector2, vector3];
                Span<uint> p = MemoryMarshal.Cast<Vector512<uint>, uint>(temp);
                Span<uint> q = MemoryMarshal.Cast<Vector512<uint>, uint>(rt);
                ref uint pindices = ref Unsafe.As<Vector512<uint>, uint>(ref indices);
                ref uint pback = ref Unsafe.As<Vector512<uint>, uint>(ref back);
                for (int i = 0; i < Vector512<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[(int)selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX4Insert_Basic(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> indices) {
                return YShuffleX4Insert_Basic(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX4Insert_Basic(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> indices) {
                const ulong total = 4 * ByteCountValue / sizeof(ulong); // 4 * Vector512<ulong>.Count
                Span<Vector512<ulong>> rt = stackalloc Vector512<ulong>[1];
                Span<Vector512<ulong>> temp = [vector0, vector1, vector2, vector3];
                Span<ulong> p = MemoryMarshal.Cast<Vector512<ulong>, ulong>(temp);
                Span<ulong> q = MemoryMarshal.Cast<Vector512<ulong>, ulong>(rt);
                ref ulong pindices = ref Unsafe.As<Vector512<ulong>, ulong>(ref indices);
                ref ulong pback = ref Unsafe.As<Vector512<ulong>, ulong>(ref back);
                for (int i = 0; i < Vector512<ulong>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX4Insert_Bit(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> indices) {
                return YShuffleX4Insert_Bit(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX4Insert_Bit(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> indices) {
                return YShuffleX4Insert_Bit(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX4Insert_Bit(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> indices) {
                Vector512<sbyte> mask, raw, rt;
                mask = Vector512.GreaterThanOrEqual(indices, Vector512<sbyte>.Zero); // i >= 0
                raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                rt = Vector512.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX4Insert_Bit(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> indices) {
                // const byte total = 4 * ByteCountValue / sizeof(byte); // 4 * Vector512<byte>.Count // 4 * Vector512<byte>.Count // Number overflow
                return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX4Insert_Bit(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> indices) {
                return YShuffleX4Insert_Bit(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX4Insert_Bit(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> indices) {
                const ushort total = 4 * ByteCountValue / sizeof(ushort); // 4 * Vector512<ushort>.Count
                Vector512<ushort> mask = Vector512.GreaterThan(Vector512.Create(total), indices);
                Vector512<ushort> raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                Vector512<ushort> rt = Vector512.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX4Insert_Bit(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> indices) {
                return YShuffleX4Insert_Bit(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX4Insert_Bit(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> indices) {
                const uint total = 4 * ByteCountValue / sizeof(uint); // 4 * Vector512<uint>.Count
                Vector512<uint> mask = Vector512.GreaterThan(Vector512.Create(total), indices);
                Vector512<uint> raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                Vector512<uint> rt = Vector512.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX4Insert_Bit(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> indices) {
                return YShuffleX4Insert_Bit(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX4Insert_Bit(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> indices) {
                const ulong total = 4 * ByteCountValue / sizeof(ulong); // 4 * Vector512<ulong>.Count
                Vector512<ulong> mask = Vector512.GreaterThan(Vector512.Create(total), indices);
                Vector512<ulong> raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                Vector512<ulong> rt = Vector512.ConditionalSelect(mask, raw, back);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3, out Vector512<sbyte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3, out Vector512<byte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3, out Vector512<short> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3, out Vector512<ushort> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3, out Vector512<int> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3, out Vector512<uint> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3, out Vector512<long> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3, out Vector512<ulong> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX4Insert_Core(Vector512<float> back, Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX4Insert_Core(Vector512<double> back, Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX4Insert_Core(Vector512<sbyte> back, Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3, Vector512<sbyte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX4Insert_Core(Vector512<byte> back, Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3, Vector512<byte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX4Insert_Core(Vector512<short> back, Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3, Vector512<short> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX4Insert_Core(Vector512<ushort> back, Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3, Vector512<ushort> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX4Insert_Core(Vector512<int> back, Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3, Vector512<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX4Insert_Core(Vector512<uint> back, Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3, Vector512<uint> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX4Insert_Core(Vector512<long> back, Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3, Vector512<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Insert_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX4Insert_Core(Vector512<ulong> back, Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3, Vector512<ulong> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }


            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX4Kernel_AcceleratedTypes {
                get {
                    return Shuffle_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX4Kernel(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX4Kernel(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX4Kernel(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX4Kernel(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX4Kernel(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX4Kernel(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX4Kernel(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX4Kernel(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX4Kernel(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX4Kernel(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector512.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX4Kernel_Basic(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> indices) {
                return YShuffleX4Kernel_Basic(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX4Kernel_Basic(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> indices) {
                return YShuffleX4Kernel_Basic(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX4Kernel_Basic(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> indices) {
                return YShuffleX4Kernel_Basic(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX4Kernel_Basic(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> indices) {
                const ushort total = 4 * ByteCountValue / sizeof(byte); // 4 * Vector512<byte>.Count
                Span<Vector512<byte>> rt = stackalloc Vector512<byte>[1];
                Span<Vector512<byte>> temp = [vector0, vector1, vector2, vector3];
                Span<byte> p = MemoryMarshal.Cast<Vector512<byte>, byte>(temp);
                Span<byte> q = MemoryMarshal.Cast<Vector512<byte>, byte>(rt);
                ref byte pindices = ref Unsafe.As<Vector512<byte>, byte>(ref indices);
                for (int i = 0; i < Vector512<byte>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX4Kernel_Basic(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> indices) {
                return YShuffleX4Kernel_Basic(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX4Kernel_Basic(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> indices) {
                const ushort total = 4 * ByteCountValue / sizeof(ushort); // 4 * Vector512<ushort>.Count
                Span<Vector512<ushort>> rt = stackalloc Vector512<ushort>[1];
                Span<Vector512<ushort>> temp = [vector0, vector1, vector2, vector3];
                Span<ushort> p = MemoryMarshal.Cast<Vector512<ushort>, ushort>(temp);
                Span<ushort> q = MemoryMarshal.Cast<Vector512<ushort>, ushort>(rt);
                ref ushort pindices = ref Unsafe.As<Vector512<ushort>, ushort>(ref indices);
                for (int i = 0; i < Vector512<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX4Kernel_Basic(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> indices) {
                return YShuffleX4Kernel_Basic(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX4Kernel_Basic(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> indices) {
                const uint total = 4 * ByteCountValue / sizeof(uint); // 4 * Vector512<uint>.Count
                Span<Vector512<uint>> rt = stackalloc Vector512<uint>[1];
                Span<Vector512<uint>> temp = [vector0, vector1, vector2, vector3];
                Span<uint> p = MemoryMarshal.Cast<Vector512<uint>, uint>(temp);
                Span<uint> q = MemoryMarshal.Cast<Vector512<uint>, uint>(rt);
                ref uint pindices = ref Unsafe.As<Vector512<uint>, uint>(ref indices);
                for (int i = 0; i < Vector512<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[(int)selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX4Kernel_Basic(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> indices) {
                return YShuffleX4Kernel_Basic(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX4Kernel_Basic(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> indices) {
                const ulong total = 4 * ByteCountValue / sizeof(ulong); // 4 * Vector512<ulong>.Count
                Span<Vector512<ulong>> rt = stackalloc Vector512<ulong>[1];
                Span<Vector512<ulong>> temp = [vector0, vector1, vector2, vector3];
                Span<ulong> p = MemoryMarshal.Cast<Vector512<ulong>, ulong>(temp);
                Span<ulong> q = MemoryMarshal.Cast<Vector512<ulong>, ulong>(rt);
                ref ulong pindices = ref Unsafe.As<Vector512<ulong>, ulong>(ref indices);
                for (int i = 0; i < Vector512<ulong>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX4Kernel_Bit(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> indices) {
                return YShuffleX4Kernel_Bit(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX4Kernel_Bit(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> indices) {
                return YShuffleX4Kernel_Bit(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX4Kernel_Bit(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> indices) {
                return YShuffleX4Kernel_Bit(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX4Kernel_Bit(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> indices) {
                Vector512<byte> vCount = Vector512.Create((byte)Vector512<byte>.Count);
                Vector512<byte> indices1 = Vector512.Subtract(indices, vCount);
                Vector512<byte> indices2 = Vector512.Subtract(indices1, vCount);
                Vector512<byte> indices3 = Vector512.Subtract(indices2, vCount);
                Vector512<byte> rt0 = Vector512.Shuffle(vector0, indices);
                Vector512<byte> rt1 = Vector512.Shuffle(vector1, indices1);
                Vector512<byte> rt2 = Vector512.Shuffle(vector2, indices2);
                Vector512<byte> rt3 = Vector512.Shuffle(vector3, indices3);
                rt0 = Vector512.BitwiseOr(rt0, rt1);
                rt2 = Vector512.BitwiseOr(rt2, rt3);
                Vector512<byte> rt = Vector512.BitwiseOr(rt0, rt2);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX4Kernel_Bit(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> indices) {
                return YShuffleX4Kernel_Bit(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX4Kernel_Bit(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> indices) {
                Vector512<ushort> vCount = Vector512.Create((ushort)Vector512<ushort>.Count);
                Vector512<ushort> indices1 = Vector512.Subtract(indices, vCount);
                Vector512<ushort> indices2 = Vector512.Subtract(indices1, vCount);
                Vector512<ushort> indices3 = Vector512.Subtract(indices2, vCount);
                Vector512<ushort> rt0 = Vector512.Shuffle(vector0, indices);
                Vector512<ushort> rt1 = Vector512.Shuffle(vector1, indices1);
                Vector512<ushort> rt2 = Vector512.Shuffle(vector2, indices2);
                Vector512<ushort> rt3 = Vector512.Shuffle(vector3, indices3);
                rt0 = Vector512.BitwiseOr(rt0, rt1);
                rt2 = Vector512.BitwiseOr(rt2, rt3);
                Vector512<ushort> rt = Vector512.BitwiseOr(rt0, rt2);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX4Kernel_Bit(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> indices) {
                return YShuffleX4Kernel_Bit(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX4Kernel_Bit(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> indices) {
                Vector512<uint> vCount = Vector512.Create((uint)Vector512<uint>.Count);
                Vector512<uint> indices1 = Vector512.Subtract(indices, vCount);
                Vector512<uint> indices2 = Vector512.Subtract(indices1, vCount);
                Vector512<uint> indices3 = Vector512.Subtract(indices2, vCount);
                Vector512<uint> rt0 = Vector512.Shuffle(vector0, indices);
                Vector512<uint> rt1 = Vector512.Shuffle(vector1, indices1);
                Vector512<uint> rt2 = Vector512.Shuffle(vector2, indices2);
                Vector512<uint> rt3 = Vector512.Shuffle(vector3, indices3);
                rt0 = Vector512.BitwiseOr(rt0, rt1);
                rt2 = Vector512.BitwiseOr(rt2, rt3);
                Vector512<uint> rt = Vector512.BitwiseOr(rt0, rt2);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX4Kernel_Bit(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> indices) {
                return YShuffleX4Kernel_Bit(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX4Kernel_Bit(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> indices) {
                Vector512<ulong> vCount = Vector512.Create((ulong)Vector512<ulong>.Count);
                Vector512<ulong> indices1 = Vector512.Subtract(indices, vCount);
                Vector512<ulong> indices2 = Vector512.Subtract(indices1, vCount);
                Vector512<ulong> indices3 = Vector512.Subtract(indices2, vCount);
                Vector512<ulong> rt0 = Vector512.Shuffle(vector0, indices);
                Vector512<ulong> rt1 = Vector512.Shuffle(vector1, indices1);
                Vector512<ulong> rt2 = Vector512.Shuffle(vector2, indices2);
                Vector512<ulong> rt3 = Vector512.Shuffle(vector3, indices3);
                rt0 = Vector512.BitwiseOr(rt0, rt1);
                rt2 = Vector512.BitwiseOr(rt2, rt3);
                Vector512<ulong> rt = Vector512.BitwiseOr(rt0, rt2);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1, out Vector512<sbyte> args2, out Vector512<sbyte> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1, out Vector512<byte> args2, out Vector512<byte> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short}, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1, out Vector512<short> args2, out Vector512<short> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1, out Vector512<ushort> args2, out Vector512<ushort> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int}, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1, out Vector512<int> args2, out Vector512<int> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1, out Vector512<uint> args2, out Vector512<uint> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long}, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1, out Vector512<long> args2, out Vector512<long> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1, out Vector512<ulong> args2, out Vector512<ulong> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{float}, Vector512{float}, Vector512{float}, Vector512{float}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YShuffleX4Kernel_Core(Vector512<float> vector0, Vector512<float> vector1, Vector512<float> vector2, Vector512<float> vector3, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{double}, Vector512{double}, Vector512{double}, Vector512{double}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleX4Kernel_Core(Vector512<double> vector0, Vector512<double> vector1, Vector512<double> vector2, Vector512<double> vector3, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleX4Kernel_Core(Vector512<sbyte> vector0, Vector512<sbyte> vector1, Vector512<sbyte> vector2, Vector512<sbyte> vector3, Vector512<sbyte> args0, Vector512<sbyte> args1, Vector512<sbyte> args2, Vector512<sbyte> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleX4Kernel_Core(Vector512<byte> vector0, Vector512<byte> vector1, Vector512<byte> vector2, Vector512<byte> vector3, Vector512<byte> args0, Vector512<byte> args1, Vector512<byte> args2, Vector512<byte> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleX4Kernel_Core(Vector512<short> vector0, Vector512<short> vector1, Vector512<short> vector2, Vector512<short> vector3, Vector512<short> args0, Vector512<short> args1, Vector512<short> args2, Vector512<short> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleX4Kernel_Core(Vector512<ushort> vector0, Vector512<ushort> vector1, Vector512<ushort> vector2, Vector512<ushort> vector3, Vector512<ushort> args0, Vector512<ushort> args1, Vector512<ushort> args2, Vector512<ushort> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleX4Kernel_Core(Vector512<int> vector0, Vector512<int> vector1, Vector512<int> vector2, Vector512<int> vector3, Vector512<int> args0, Vector512<int> args1, Vector512<int> args2, Vector512<int> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleX4Kernel_Core(Vector512<uint> vector0, Vector512<uint> vector1, Vector512<uint> vector2, Vector512<uint> vector3, Vector512<uint> args0, Vector512<uint> args1, Vector512<uint> args2, Vector512<uint> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleX4Kernel_Core(Vector512<long> vector0, Vector512<long> vector1, Vector512<long> vector2, Vector512<long> vector3, Vector512<long> args0, Vector512<long> args1, Vector512<long> args2, Vector512<long> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleX4Kernel_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleX4Kernel_Core(Vector512<ulong> vector0, Vector512<ulong> vector1, Vector512<ulong> vector2, Vector512<ulong> vector3, Vector512<ulong> args0, Vector512<ulong> args1, Vector512<ulong> args2, Vector512<ulong> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }


            /// <inheritdoc cref="IWVectorTraits512.YSign_AcceleratedTypes"/>
            public static TypeCodeFlags YSign_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YSign(Vector512<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YSign_Bit(value);
#else
                return YSign_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YSign(Vector512<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YSign_Bit(value);
#else
                return YSign_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YSign(Vector512<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YSign_Bit(value);
#else
                return YSign_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YSign(Vector512<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YSign_Bit(value);
#else
                return YSign_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YSign(Vector512<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YSign_Bit(value);
#else
                return YSign_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YSign(Vector512<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YSign_Bit(value);
#else
                return YSign_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YSign_Basic(Vector512<float> value) {
                Unsafe.SkipInit(out Vector512<int> rt);
                ref FixedArray16<float> pvalue = ref Unsafe.As<Vector512<float>, FixedArray16<float>>(ref value);
                ref FixedArray16<int> p = ref Unsafe.As<Vector512<int>, FixedArray16<int>>(ref rt);
                p.I0 = MathINumber.Sign(pvalue.I0);
                p.I1 = MathINumber.Sign(pvalue.I1);
                p.I2 = MathINumber.Sign(pvalue.I2);
                p.I3 = MathINumber.Sign(pvalue.I3);
                p.I4 = MathINumber.Sign(pvalue.I4);
                p.I5 = MathINumber.Sign(pvalue.I5);
                p.I6 = MathINumber.Sign(pvalue.I6);
                p.I7 = MathINumber.Sign(pvalue.I7);
                p.I8 = MathINumber.Sign(pvalue.I8);
                p.I9 = MathINumber.Sign(pvalue.I9);
                p.I10 = MathINumber.Sign(pvalue.I10);
                p.I11 = MathINumber.Sign(pvalue.I11);
                p.I12 = MathINumber.Sign(pvalue.I12);
                p.I13 = MathINumber.Sign(pvalue.I13);
                p.I14 = MathINumber.Sign(pvalue.I14);
                p.I15 = MathINumber.Sign(pvalue.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YSign_Basic(Vector512<double> value) {
                Unsafe.SkipInit(out Vector512<long> rt);
                ref FixedArray8<double> pvalue = ref Unsafe.As<Vector512<double>, FixedArray8<double>>(ref value);
                ref FixedArray8<long> p = ref Unsafe.As<Vector512<long>, FixedArray8<long>>(ref rt);
                p.I0 = MathINumber.Sign(pvalue.I0);
                p.I1 = MathINumber.Sign(pvalue.I1);
                p.I2 = MathINumber.Sign(pvalue.I2);
                p.I3 = MathINumber.Sign(pvalue.I3);
                p.I4 = MathINumber.Sign(pvalue.I4);
                p.I5 = MathINumber.Sign(pvalue.I5);
                p.I6 = MathINumber.Sign(pvalue.I6);
                p.I7 = MathINumber.Sign(pvalue.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YSign_Basic(Vector512<sbyte> value) {
                Unsafe.SkipInit(out Vector512<sbyte> rt);
                ref FixedArray64<sbyte> pvalue = ref Unsafe.As<Vector512<sbyte>, FixedArray64<sbyte>>(ref value);
                ref FixedArray64<sbyte> p = ref Unsafe.As<Vector512<sbyte>, FixedArray64<sbyte>>(ref rt);
                p.I0 = (sbyte)MathINumber.Sign(pvalue.I0);
                p.I1 = (sbyte)MathINumber.Sign(pvalue.I1);
                p.I2 = (sbyte)MathINumber.Sign(pvalue.I2);
                p.I3 = (sbyte)MathINumber.Sign(pvalue.I3);
                p.I4 = (sbyte)MathINumber.Sign(pvalue.I4);
                p.I5 = (sbyte)MathINumber.Sign(pvalue.I5);
                p.I6 = (sbyte)MathINumber.Sign(pvalue.I6);
                p.I7 = (sbyte)MathINumber.Sign(pvalue.I7);
                p.I8 = (sbyte)MathINumber.Sign(pvalue.I8);
                p.I9 = (sbyte)MathINumber.Sign(pvalue.I9);
                p.I10 = (sbyte)MathINumber.Sign(pvalue.I10);
                p.I11 = (sbyte)MathINumber.Sign(pvalue.I11);
                p.I12 = (sbyte)MathINumber.Sign(pvalue.I12);
                p.I13 = (sbyte)MathINumber.Sign(pvalue.I13);
                p.I14 = (sbyte)MathINumber.Sign(pvalue.I14);
                p.I15 = (sbyte)MathINumber.Sign(pvalue.I15);
                p.I16 = (sbyte)MathINumber.Sign(pvalue.I16);
                p.I17 = (sbyte)MathINumber.Sign(pvalue.I17);
                p.I18 = (sbyte)MathINumber.Sign(pvalue.I18);
                p.I19 = (sbyte)MathINumber.Sign(pvalue.I19);
                p.I20 = (sbyte)MathINumber.Sign(pvalue.I20);
                p.I21 = (sbyte)MathINumber.Sign(pvalue.I21);
                p.I22 = (sbyte)MathINumber.Sign(pvalue.I22);
                p.I23 = (sbyte)MathINumber.Sign(pvalue.I23);
                p.I24 = (sbyte)MathINumber.Sign(pvalue.I24);
                p.I25 = (sbyte)MathINumber.Sign(pvalue.I25);
                p.I26 = (sbyte)MathINumber.Sign(pvalue.I26);
                p.I27 = (sbyte)MathINumber.Sign(pvalue.I27);
                p.I28 = (sbyte)MathINumber.Sign(pvalue.I28);
                p.I29 = (sbyte)MathINumber.Sign(pvalue.I29);
                p.I30 = (sbyte)MathINumber.Sign(pvalue.I30);
                p.I31 = (sbyte)MathINumber.Sign(pvalue.I31);
                p.I32 = (sbyte)MathINumber.Sign(pvalue.I32);
                p.I33 = (sbyte)MathINumber.Sign(pvalue.I33);
                p.I34 = (sbyte)MathINumber.Sign(pvalue.I34);
                p.I35 = (sbyte)MathINumber.Sign(pvalue.I35);
                p.I36 = (sbyte)MathINumber.Sign(pvalue.I36);
                p.I37 = (sbyte)MathINumber.Sign(pvalue.I37);
                p.I38 = (sbyte)MathINumber.Sign(pvalue.I38);
                p.I39 = (sbyte)MathINumber.Sign(pvalue.I39);
                p.I40 = (sbyte)MathINumber.Sign(pvalue.I40);
                p.I41 = (sbyte)MathINumber.Sign(pvalue.I41);
                p.I42 = (sbyte)MathINumber.Sign(pvalue.I42);
                p.I43 = (sbyte)MathINumber.Sign(pvalue.I43);
                p.I44 = (sbyte)MathINumber.Sign(pvalue.I44);
                p.I45 = (sbyte)MathINumber.Sign(pvalue.I45);
                p.I46 = (sbyte)MathINumber.Sign(pvalue.I46);
                p.I47 = (sbyte)MathINumber.Sign(pvalue.I47);
                p.I48 = (sbyte)MathINumber.Sign(pvalue.I48);
                p.I49 = (sbyte)MathINumber.Sign(pvalue.I49);
                p.I50 = (sbyte)MathINumber.Sign(pvalue.I50);
                p.I51 = (sbyte)MathINumber.Sign(pvalue.I51);
                p.I52 = (sbyte)MathINumber.Sign(pvalue.I52);
                p.I53 = (sbyte)MathINumber.Sign(pvalue.I53);
                p.I54 = (sbyte)MathINumber.Sign(pvalue.I54);
                p.I55 = (sbyte)MathINumber.Sign(pvalue.I55);
                p.I56 = (sbyte)MathINumber.Sign(pvalue.I56);
                p.I57 = (sbyte)MathINumber.Sign(pvalue.I57);
                p.I58 = (sbyte)MathINumber.Sign(pvalue.I58);
                p.I59 = (sbyte)MathINumber.Sign(pvalue.I59);
                p.I60 = (sbyte)MathINumber.Sign(pvalue.I60);
                p.I61 = (sbyte)MathINumber.Sign(pvalue.I61);
                p.I62 = (sbyte)MathINumber.Sign(pvalue.I62);
                p.I63 = (sbyte)MathINumber.Sign(pvalue.I63);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YSign_Basic(Vector512<short> value) {
                Unsafe.SkipInit(out Vector512<short> rt);
                ref FixedArray32<short> pvalue = ref Unsafe.As<Vector512<short>, FixedArray32<short>>(ref value);
                ref FixedArray32<short> p = ref Unsafe.As<Vector512<short>, FixedArray32<short>>(ref rt);
                p.I0 = (short)MathINumber.Sign(pvalue.I0);
                p.I1 = (short)MathINumber.Sign(pvalue.I1);
                p.I2 = (short)MathINumber.Sign(pvalue.I2);
                p.I3 = (short)MathINumber.Sign(pvalue.I3);
                p.I4 = (short)MathINumber.Sign(pvalue.I4);
                p.I5 = (short)MathINumber.Sign(pvalue.I5);
                p.I6 = (short)MathINumber.Sign(pvalue.I6);
                p.I7 = (short)MathINumber.Sign(pvalue.I7);
                p.I8 = (short)MathINumber.Sign(pvalue.I8);
                p.I9 = (short)MathINumber.Sign(pvalue.I9);
                p.I10 = (short)MathINumber.Sign(pvalue.I10);
                p.I11 = (short)MathINumber.Sign(pvalue.I11);
                p.I12 = (short)MathINumber.Sign(pvalue.I12);
                p.I13 = (short)MathINumber.Sign(pvalue.I13);
                p.I14 = (short)MathINumber.Sign(pvalue.I14);
                p.I15 = (short)MathINumber.Sign(pvalue.I15);
                p.I16 = (short)MathINumber.Sign(pvalue.I16);
                p.I17 = (short)MathINumber.Sign(pvalue.I17);
                p.I18 = (short)MathINumber.Sign(pvalue.I18);
                p.I19 = (short)MathINumber.Sign(pvalue.I19);
                p.I20 = (short)MathINumber.Sign(pvalue.I20);
                p.I21 = (short)MathINumber.Sign(pvalue.I21);
                p.I22 = (short)MathINumber.Sign(pvalue.I22);
                p.I23 = (short)MathINumber.Sign(pvalue.I23);
                p.I24 = (short)MathINumber.Sign(pvalue.I24);
                p.I25 = (short)MathINumber.Sign(pvalue.I25);
                p.I26 = (short)MathINumber.Sign(pvalue.I26);
                p.I27 = (short)MathINumber.Sign(pvalue.I27);
                p.I28 = (short)MathINumber.Sign(pvalue.I28);
                p.I29 = (short)MathINumber.Sign(pvalue.I29);
                p.I30 = (short)MathINumber.Sign(pvalue.I30);
                p.I31 = (short)MathINumber.Sign(pvalue.I31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YSign_Basic(Vector512<int> value) {
                Unsafe.SkipInit(out Vector512<int> rt);
                ref FixedArray16<int> pvalue = ref Unsafe.As<Vector512<int>, FixedArray16<int>>(ref value);
                ref FixedArray16<int> p = ref Unsafe.As<Vector512<int>, FixedArray16<int>>(ref rt);
                p.I0 = MathINumber.Sign(pvalue.I0);
                p.I1 = MathINumber.Sign(pvalue.I1);
                p.I2 = MathINumber.Sign(pvalue.I2);
                p.I3 = MathINumber.Sign(pvalue.I3);
                p.I4 = MathINumber.Sign(pvalue.I4);
                p.I5 = MathINumber.Sign(pvalue.I5);
                p.I6 = MathINumber.Sign(pvalue.I6);
                p.I7 = MathINumber.Sign(pvalue.I7);
                p.I8 = MathINumber.Sign(pvalue.I8);
                p.I9 = MathINumber.Sign(pvalue.I9);
                p.I10 = MathINumber.Sign(pvalue.I10);
                p.I11 = MathINumber.Sign(pvalue.I11);
                p.I12 = MathINumber.Sign(pvalue.I12);
                p.I13 = MathINumber.Sign(pvalue.I13);
                p.I14 = MathINumber.Sign(pvalue.I14);
                p.I15 = MathINumber.Sign(pvalue.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YSign_Basic(Vector512<long> value) {
                Unsafe.SkipInit(out Vector512<long> rt);
                ref FixedArray8<long> pvalue = ref Unsafe.As<Vector512<long>, FixedArray8<long>>(ref value);
                ref FixedArray8<long> p = ref Unsafe.As<Vector512<long>, FixedArray8<long>>(ref rt);
                p.I0 = MathINumber.Sign(pvalue.I0);
                p.I1 = MathINumber.Sign(pvalue.I1);
                p.I2 = MathINumber.Sign(pvalue.I2);
                p.I3 = MathINumber.Sign(pvalue.I3);
                p.I4 = MathINumber.Sign(pvalue.I4);
                p.I5 = MathINumber.Sign(pvalue.I5);
                p.I6 = MathINumber.Sign(pvalue.I6);
                p.I7 = MathINumber.Sign(pvalue.I7);
                return rt;
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YSign_Bit(Vector512<float> value) {
                // (x > 0) - (x < 0); //From "Hacker's Delight" 2.7, Page 19.
                // = (-to_mask(x > 0)) - (-to_mask(x < 0))
                // = to_mask(x < 0) - to_mask(x > 0).
                Vector512<float> zero = Vector512<float>.Zero;
                Vector512<int> m = Vector512.LessThan(value, zero).AsInt32();
                Vector512<int> n = Vector512.GreaterThan(value, zero).AsInt32();
                Vector512<int> rt = Vector512.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YSign_Bit(Vector512<double> value) {
                Vector512<double> zero = Vector512<double>.Zero;
                Vector512<long> m = Vector512.LessThan(value, zero).AsInt64();
                Vector512<long> n = Vector512.GreaterThan(value, zero).AsInt64();
                Vector512<long> rt = Vector512.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YSign_Bit(Vector512<sbyte> value) {
                Vector512<sbyte> zero = Vector512<sbyte>.Zero;
                Vector512<sbyte> m = Vector512.LessThan(value, zero);
                Vector512<sbyte> n = Vector512.GreaterThan(value, zero);
                Vector512<sbyte> rt = Vector512.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YSign_Bit(Vector512<short> value) {
                Vector512<short> zero = Vector512<short>.Zero;
                Vector512<short> m = Vector512.LessThan(value, zero);
                Vector512<short> n = Vector512.GreaterThan(value, zero);
                Vector512<short> rt = Vector512.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YSign_Bit(Vector512<int> value) {
                Vector512<int> zero = Vector512<int>.Zero;
                Vector512<int> m = Vector512.LessThan(value, zero);
                Vector512<int> n = Vector512.GreaterThan(value, zero);
                Vector512<int> rt = Vector512.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YSign(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YSign_Bit(Vector512<long> value) {
                Vector512<long> zero = Vector512<long>.Zero;
                Vector512<long> m = Vector512.LessThan(value, zero);
                Vector512<long> n = Vector512.GreaterThan(value, zero);
                Vector512<long> rt = Vector512.Subtract(m, n);
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits512.YSignFloat_AcceleratedTypes"/>
            public static TypeCodeFlags YSignFloat_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= (TypeCodeFlags.Single) & YIsNaN_AcceleratedTypes & YSign_AcceleratedTypes & ConvertToSingle_AcceleratedTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.YSignFloat(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YSignFloat(Vector512<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YSignFloat_Bit(value);
#else
                return YSignFloat_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YSignFloat(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YSignFloat(Vector512<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YSignFloat_Bit(value);
#else
                return YSignFloat_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.YSignFloat(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YSignFloat_Basic(Vector512<float> value) {
                Unsafe.SkipInit(out Vector512<float> rt);
                ref FixedArray16<float> pvalue = ref Unsafe.As<Vector512<float>, FixedArray16<float>>(ref value);
                ref FixedArray16<float> p = ref Unsafe.As<Vector512<float>, FixedArray16<float>>(ref rt);
                p.I0 = MathINumber.SignFloat(pvalue.I0);
                p.I1 = MathINumber.SignFloat(pvalue.I1);
                p.I2 = MathINumber.SignFloat(pvalue.I2);
                p.I3 = MathINumber.SignFloat(pvalue.I3);
                p.I4 = MathINumber.SignFloat(pvalue.I4);
                p.I5 = MathINumber.SignFloat(pvalue.I5);
                p.I6 = MathINumber.SignFloat(pvalue.I6);
                p.I7 = MathINumber.SignFloat(pvalue.I7);
                p.I8 = MathINumber.SignFloat(pvalue.I8);
                p.I9 = MathINumber.SignFloat(pvalue.I9);
                p.I10 = MathINumber.SignFloat(pvalue.I10);
                p.I11 = MathINumber.SignFloat(pvalue.I11);
                p.I12 = MathINumber.SignFloat(pvalue.I12);
                p.I13 = MathINumber.SignFloat(pvalue.I13);
                p.I14 = MathINumber.SignFloat(pvalue.I14);
                p.I15 = MathINumber.SignFloat(pvalue.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YSignFloat(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YSignFloat_Basic(Vector512<double> value) {
                Unsafe.SkipInit(out Vector512<double> rt);
                ref FixedArray8<double> pvalue = ref Unsafe.As<Vector512<double>, FixedArray8<double>>(ref value);
                ref FixedArray8<double> p = ref Unsafe.As<Vector512<double>, FixedArray8<double>>(ref rt);
                p.I0 = MathINumber.SignFloat(pvalue.I0);
                p.I1 = MathINumber.SignFloat(pvalue.I1);
                p.I2 = MathINumber.SignFloat(pvalue.I2);
                p.I3 = MathINumber.SignFloat(pvalue.I3);
                p.I4 = MathINumber.SignFloat(pvalue.I4);
                p.I5 = MathINumber.SignFloat(pvalue.I5);
                p.I6 = MathINumber.SignFloat(pvalue.I6);
                p.I7 = MathINumber.SignFloat(pvalue.I7);
                return rt;
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits512.YSignFloat(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> YSignFloat_Bit(Vector512<float> value) {
                Vector512<int> signVal = YSign(value);
                Vector512<float> nanMask = YIsNaN(value).AsSingle();
                Vector512<float> rt = ConvertToSingle(signVal);
                rt = ConditionalSelect(nanMask, value, rt);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YSignFloat(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YSignFloat_Bit(Vector512<double> value) {
                return YSignFloat_Compare(value);
            }

            /// <inheritdoc cref="IWVectorTraits512.YSignFloat(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YSignFloat_Compare(Vector512<double> value) {
                Vector512<double> negativeOne = Vector512.Create(-1.0);
                Vector512<double> zero = Vector512<double>.Zero;
                Vector512<double> one = Vector512.Create(1.0);
                Vector512<double> rt = Vector512.BitwiseAnd(Vector512.LessThan(value, zero), negativeOne);
                Vector512<double> nanMask = YIsNaN(value).AsDouble();
                rt = Vector512.BitwiseOr(rt, Vector512.BitwiseAnd(Vector512.GreaterThan(value, zero), one)); // rt = ConvertToDouble(YSign(value));
                rt = Vector512.BitwiseOr(rt, Vector512.BitwiseAnd(nanMask, value)); // ConditionalSelect(nanMask, value, rt);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.YSignFloat(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YSignFloat_Convert(Vector512<double> value) {
                Vector512<long> signVal = YSign(value);
                Vector512<double> nanMask = YIsNaN(value).AsDouble();
                Vector512<double> rt = ConvertToDouble_Range52(signVal);
                rt = Vector512.BitwiseOr(rt, Vector512.BitwiseAnd(nanMask, value)); // ConditionalSelect(nanMask, value, rt);
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD

#endif // NET8_0_OR_GREATER
        }
    }
}
