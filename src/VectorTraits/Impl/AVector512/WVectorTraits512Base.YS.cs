#if NET7_0_OR_GREATER
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
                UnsafeUtil.SkipInit(out Vector512<byte> rt);
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
                UnsafeUtil.SkipInit(out Vector512<ushort> rt);
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
                UnsafeUtil.SkipInit(out Vector512<uint> rt);
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
                UnsafeUtil.SkipInit(out Vector512<ulong> rt);
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
                UnsafeUtil.SkipInit(out Vector512<byte> rt);
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
                UnsafeUtil.SkipInit(out Vector512<ushort> rt);
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
                UnsafeUtil.SkipInit(out Vector512<uint> rt);
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
                UnsafeUtil.SkipInit(out Vector512<ulong> rt);
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
            public static Vector512<float> YShuffleG4X2(Vector512<float> source0, Vector512<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<float> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{double}, Vector512{double}, ShuffleControlG4, out Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> YShuffleG4X2(Vector512<double> source0, Vector512<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<double> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{sbyte}, Vector512{sbyte}, ShuffleControlG4, out Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> YShuffleG4X2(Vector512<sbyte> source0, Vector512<sbyte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<sbyte> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{byte}, Vector512{byte}, ShuffleControlG4, out Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> YShuffleG4X2(Vector512<byte> source0, Vector512<byte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<byte> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{short}, Vector512{short}, ShuffleControlG4, out Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> YShuffleG4X2(Vector512<short> source0, Vector512<short> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<short> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{ushort}, Vector512{ushort}, ShuffleControlG4, out Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> YShuffleG4X2(Vector512<ushort> source0, Vector512<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<ushort> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{int}, Vector512{int}, ShuffleControlG4, out Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> YShuffleG4X2(Vector512<int> source0, Vector512<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<int> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{uint}, Vector512{uint}, ShuffleControlG4, out Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> YShuffleG4X2(Vector512<uint> source0, Vector512<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<uint> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{long}, Vector512{long}, ShuffleControlG4, out Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> YShuffleG4X2(Vector512<long> source0, Vector512<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<long> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits512.YShuffleG4X2(Vector512{ulong}, Vector512{ulong}, ShuffleControlG4, out Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> YShuffleG4X2(Vector512<ulong> source0, Vector512<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector512<ulong> result1) {
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
                UnsafeUtil.SkipInit(out Vector512<byte> rt);
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
                UnsafeUtil.SkipInit(out Vector512<ushort> rt);
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
                UnsafeUtil.SkipInit(out Vector512<uint> rt);
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
                UnsafeUtil.SkipInit(out Vector512<ulong> rt);
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
                UnsafeUtil.SkipInit(out Vector512<int> rt);
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
                UnsafeUtil.SkipInit(out Vector512<long> rt);
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
                UnsafeUtil.SkipInit(out Vector512<sbyte> rt);
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
                UnsafeUtil.SkipInit(out Vector512<short> rt);
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
                UnsafeUtil.SkipInit(out Vector512<int> rt);
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
                UnsafeUtil.SkipInit(out Vector512<long> rt);
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
                UnsafeUtil.SkipInit(out Vector512<float> rt);
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
                UnsafeUtil.SkipInit(out Vector512<double> rt);
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
