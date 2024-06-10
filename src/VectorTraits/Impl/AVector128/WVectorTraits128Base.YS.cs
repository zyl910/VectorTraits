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

namespace Zyl.VectorTraits.Impl.AVector128 {

    partial class WVectorTraits128Base {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG2_AcceleratedTypes {
                get {
                    return TypeCodeFlags.None;
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
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Shuffle(source, Vector128Constants.GetYShuffleG2_Byte_Indices(control));
#else
                return YShuffleG2_Basic(source, control);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Shuffle(source.AsByte(), Vector128Constants.GetYShuffleG2_UInt16_ByteIndices(control)).AsUInt16();
#else
                return YShuffleG2_Basic(source, control);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Shuffle(source.AsByte(), Vector128Constants.GetYShuffleG2_UInt32_ByteIndices(control)).AsUInt32();
#else
                return YShuffleG2_Basic(source, control);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Shuffle(source.AsByte(), Vector128Constants.GetYShuffleG2_UInt64_ByteIndices(control)).AsUInt64();
#else
                return YShuffleG2_Basic(source, control);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{float}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleG2_Basic(Vector128<float> source, ShuffleControlG2 control) {
                return YShuffleG2_Basic(source.AsUInt32(), control).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{double}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleG2_Basic(Vector128<double> source, ShuffleControlG2 control) {
                return YShuffleG2_Basic(source.AsUInt64(), control).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{sbyte}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleG2_Basic(Vector128<sbyte> source, ShuffleControlG2 control) {
                return YShuffleG2_Basic(source.AsByte(), control).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{byte}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleG2_Basic(Vector128<byte> source, ShuffleControlG2 control) {
                UnsafeUtil.SkipInit(out Vector128<byte> rt);
                ref byte q = ref Unsafe.As<Vector128<byte>, byte>(ref rt);
                ref byte p = ref Unsafe.As<Vector128<byte>, byte>(ref source);
                int ctl = (byte)control;
                for (int i = 0; i < Vector128<byte>.Count; ++i) {
                    int selectedIndex = (i & (~1)) | ((ctl >> (i & 1)) & 1);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{short}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleG2_Basic(Vector128<short> source, ShuffleControlG2 control) {
                return YShuffleG2_Basic(source.AsUInt16(), control).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{ushort}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleG2_Basic(Vector128<ushort> source, ShuffleControlG2 control) {
                UnsafeUtil.SkipInit(out Vector128<ushort> rt);
                ref ushort q = ref Unsafe.As<Vector128<ushort>, ushort>(ref rt);
                ref ushort p = ref Unsafe.As<Vector128<ushort>, ushort>(ref source);
                int ctl = (byte)control;
                for (int i = 0; i < Vector128<ushort>.Count; ++i) {
                    int selectedIndex = (i & (~1)) | ((ctl >> (i & 1)) & 1);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{int}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleG2_Basic(Vector128<int> source, ShuffleControlG2 control) {
                return YShuffleG2_Basic(source.AsUInt32(), control).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleG2_Basic(Vector128<uint> source, ShuffleControlG2 control) {
                UnsafeUtil.SkipInit(out Vector128<uint> rt);
                ref uint q = ref Unsafe.As<Vector128<uint>, uint>(ref rt);
                ref uint p = ref Unsafe.As<Vector128<uint>, uint>(ref source);
                int ctl = (byte)control;
                for (int i = 0; i < Vector128<uint>.Count; ++i) {
                    int selectedIndex = (i & (~1)) | ((ctl >> (i & 1)) & 1);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{long}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleG2_Basic(Vector128<long> source, ShuffleControlG2 control) {
                return YShuffleG2_Basic(source.AsUInt64(), control).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2(Vector128{ulong}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleG2_Basic(Vector128<ulong> source, ShuffleControlG2 control) {
                UnsafeUtil.SkipInit(out Vector128<ulong> rt);
                ref ulong q = ref Unsafe.As<Vector128<ulong>, ulong>(ref rt);
                ref ulong p = ref Unsafe.As<Vector128<ulong>, ulong>(ref source);
                int ctl = (byte)control;
                for (int i = 0; i < Vector128<ulong>.Count; ++i) {
                    int selectedIndex = (i & (~1)) | ((ctl >> (i & 1)) & 1);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                return rt;
            }

#if !REDUCE_MEMORY_USAGE
            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{float}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleG2_Const(Vector128<float> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{double}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleG2_Const(Vector128<double> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{sbyte}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleG2_Const(Vector128<sbyte> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{byte}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleG2_Const(Vector128<byte> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{short}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleG2_Const(Vector128<short> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{ushort}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleG2_Const(Vector128<ushort> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{int}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleG2_Const(Vector128<int> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{uint}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleG2_Const(Vector128<uint> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{long}, ShuffleControlG2)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleG2_Const(Vector128<long> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG2_Const(Vector128{ulong}, ShuffleControlG2)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleG2_Const(Vector128<ulong> source, [ConstantExpected] ShuffleControlG2 control) {
                return YShuffleG2(source, control);
            }
#endif // !REDUCE_MEMORY_USAGE


            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG4_AcceleratedTypes {
                get {
                    return TypeCodeFlags.None;
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
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Shuffle(source, Vector128Constants.GetYShuffleG4_Byte_Indices(control));
#else
                return YShuffleG4_Basic(source, control);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Shuffle(source.AsByte(), Vector128Constants.GetYShuffleG4_UInt16_ByteIndices(control)).AsUInt16();
#else
                return YShuffleG4_Basic(source, control);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Shuffle(source.AsByte(), Vector128Constants.GetYShuffleG4_UInt32_ByteIndices(control)).AsUInt32();
#else
                return YShuffleG4_Basic(source, control);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleG4_Basic(Vector128<float> source, ShuffleControlG4 control) {
                return YShuffleG4_Basic(source.AsUInt32(), control).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{sbyte}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleG4_Basic(Vector128<sbyte> source, ShuffleControlG4 control) {
                return YShuffleG4_Basic(source.AsByte(), control).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{byte}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleG4_Basic(Vector128<byte> source, ShuffleControlG4 control) {
                UnsafeUtil.SkipInit(out Vector128<byte> rt);
                ref byte q = ref Unsafe.As<Vector128<byte>, byte>(ref rt);
                ref byte p = ref Unsafe.As<Vector128<byte>, byte>(ref source);
                int ctl = (byte)control;
                for (int i = 0; i < Vector128<byte>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{short}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleG4_Basic(Vector128<short> source, ShuffleControlG4 control) {
                return YShuffleG4_Basic(source.AsUInt16(), control).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{ushort}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleG4_Basic(Vector128<ushort> source, ShuffleControlG4 control) {
                UnsafeUtil.SkipInit(out Vector128<ushort> rt);
                ref ushort q = ref Unsafe.As<Vector128<ushort>, ushort>(ref rt);
                ref ushort p = ref Unsafe.As<Vector128<ushort>, ushort>(ref source);
                int ctl = (byte)control;
                for (int i = 0; i < Vector128<ushort>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleG4_Basic(Vector128<int> source, ShuffleControlG4 control) {
                return YShuffleG4_Basic(source.AsUInt32(), control).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4(Vector128{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleG4_Basic(Vector128<uint> source, ShuffleControlG4 control) {
                UnsafeUtil.SkipInit(out Vector128<uint> rt);
                ref uint q = ref Unsafe.As<Vector128<uint>, uint>(ref rt);
                ref uint p = ref Unsafe.As<Vector128<uint>, uint>(ref source);
                int ctl = (byte)control;
                for (int i = 0; i < Vector128<uint>.Count; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{float}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleG4_Const(Vector128<float> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
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
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{ushort}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleG4_Const(Vector128<ushort> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{int}, ShuffleControlG4)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleG4_Const(Vector128<int> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4_Const(Vector128{uint}, ShuffleControlG4)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleG4_Const(Vector128<uint> source, [ConstantExpected] ShuffleControlG4 control) {
                return YShuffleG4(source, control);
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleG4X2_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    if ((YShuffleKernel_AcceleratedTypes & TypeCodeFlags.Byte) != TypeCodeFlags.None) {
                        rt = TypeCodeFlagsUtil.AllTypes;
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{float}, Vector128{float}, ShuffleControlG4, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleG4X2(Vector128<float> source0, Vector128<float> source1, ShuffleControlG4 control, out Vector128<float> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
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
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{byte}, Vector128{byte}, ShuffleControlG4, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleG4X2(Vector128<byte> source0, Vector128<byte> source1, ShuffleControlG4 control, out Vector128<byte> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{short}, Vector128{short}, ShuffleControlG4, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleG4X2(Vector128<short> source0, Vector128<short> source1, ShuffleControlG4 control, out Vector128<short> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{ushort}, Vector128{ushort}, ShuffleControlG4, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleG4X2(Vector128<ushort> source0, Vector128<ushort> source1, ShuffleControlG4 control, out Vector128<ushort> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{int}, Vector128{int}, ShuffleControlG4, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleG4X2(Vector128<int> source0, Vector128<int> source1, ShuffleControlG4 control, out Vector128<int> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{uint}, Vector128{uint}, ShuffleControlG4, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleG4X2(Vector128<uint> source0, Vector128<uint> source1, ShuffleControlG4 control, out Vector128<uint> result1) {
                var rt0 = YShuffleG4(source0, control);
                result1 = YShuffleG4(source1, control);
                return rt0;
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
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
                ref Vector128<byte> indices = ref Vector128Constants.GetYShuffleG4X2_UInt64_ByteIndices(control);
                var result0 = Vector128.BitwiseOr(
                    Vector128.Shuffle(source0.AsByte(), indices),
                    Vector128.Shuffle(source1.AsByte(), Unsafe.Add(ref indices, 1))
                ).AsUInt64();
                result1 = Vector128.BitwiseOr(
                    Vector128.Shuffle(source0.AsByte(), Unsafe.Add(ref indices, 2)),
                    Vector128.Shuffle(source1.AsByte(), Unsafe.Add(ref indices, 3))
                ).AsUInt64();
                return result0;
#else
                return YShuffleG4X2_Basic(source0, source1, control, out result1);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2(Vector128{ulong}, Vector128{ulong}, ShuffleControlG4, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleG4X2_Basic(Vector128<ulong> source0, Vector128<ulong> source1, ShuffleControlG4 control, out Vector128<ulong> result1) {
                //(Vector128<ulong> Result0, Vector128<ulong> Result1) rt = default;
                UnsafeUtil.SkipInit(out (Vector128<ulong> Result0, Vector128<ulong> Result1) rt);
                ValueTuple<Vector128<ulong>, Vector128<ulong>> src = (source0, source1);
                ref ulong q = ref Unsafe.As<ValueTuple<Vector128<ulong>, Vector128<ulong>>, ulong>(ref rt);
                ref ulong p = ref Unsafe.As<ValueTuple<Vector128<ulong>, Vector128<ulong>>, ulong>(ref src);
                int ctl = (byte)control;
                for (int i = 0; i < 4; ++i) {
                    int selectedIndex = (i & (~3)) | ((ctl >> ((i & 3) * 2)) & 3);
                    Unsafe.Add(ref q, i) = Unsafe.Add(ref p, selectedIndex);
                }
                result1 = rt.Result1;
                return rt.Result0;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{float}, Vector128{float}, ShuffleControlG4, out Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleG4X2_Const(Vector128<float> source0, Vector128<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<float> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
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
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{ushort}, Vector128{ushort}, ShuffleControlG4, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleG4X2_Const(Vector128<ushort> source0, Vector128<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<ushort> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{int}, Vector128{int}, ShuffleControlG4, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleG4X2_Const(Vector128<int> source0, Vector128<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<int> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleG4X2_Const(Vector128{uint}, Vector128{uint}, ShuffleControlG4, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleG4X2_Const(Vector128<uint> source0, Vector128<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector128<uint> result1) {
                return YShuffleG4X2(source0, source1, control, out result1);
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
                    return Shuffle_AcceleratedTypes;
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
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                Vector128<byte> mask = Vector128.GreaterThan(Vector128.Create((byte)Vector128<byte>.Count), indices);
                Vector128<byte> raw = Vector128.Shuffle(vector, indices);
                Vector128<byte> rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
#else
                return YShuffleInsert_Basic(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                Vector128<ushort> mask = Vector128.GreaterThan(Vector128.Create((ushort)Vector128<ushort>.Count), indices);
                Vector128<ushort> raw = Vector128.Shuffle(vector, indices);
                Vector128<ushort> rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
#else
                return YShuffleInsert_Basic(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                Vector128<uint> mask = Vector128.GreaterThan(Vector128.Create((uint)Vector128<uint>.Count), indices);
                Vector128<uint> raw = Vector128.Shuffle(vector, indices);
                Vector128<uint> rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
#else
                return YShuffleInsert_Basic(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                Vector128<ulong> mask = Vector128.GreaterThan(Vector128.Create((ulong)Vector128<ulong>.Count), indices);
                Vector128<ulong> raw = Vector128.Shuffle(vector, indices);
                Vector128<ulong> rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
#else
                return YShuffleInsert_Basic(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleInsert_Basic(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> indices) {
                UnsafeUtil.SkipInit(out Vector128<byte> rt);
                byte cnt = (byte)Vector128<byte>.Count;
                ref byte q = ref Unsafe.As<Vector128<byte>, byte>(ref rt);
                ref byte p = ref Unsafe.As<Vector128<byte>, byte>(ref vector);
                ref byte pindices = ref Unsafe.As<Vector128<byte>, byte>(ref indices);
                ref byte pback = ref Unsafe.As<Vector128<byte>, byte>(ref back);
                for (nint i = 0; i < Vector128<byte>.Count; ++i) {
                    byte selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleInsert_Basic(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> indices) {
                UnsafeUtil.SkipInit(out Vector128<ushort> rt);
                ushort cnt = (ushort)Vector128<ushort>.Count;
                ref ushort q = ref Unsafe.As<Vector128<ushort>, ushort>(ref rt);
                ref ushort p = ref Unsafe.As<Vector128<ushort>, ushort>(ref vector);
                ref ushort pindices = ref Unsafe.As<Vector128<ushort>, ushort>(ref indices);
                ref ushort pback = ref Unsafe.As<Vector128<ushort>, ushort>(ref back);
                for (nint i = 0; i < Vector128<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleInsert_Basic(Vector128<uint> back, Vector128<uint> vector, Vector128<uint> indices) {
                UnsafeUtil.SkipInit(out Vector128<uint> rt);
                uint cnt = (uint)Vector128<uint>.Count;
                ref uint q = ref Unsafe.As<Vector128<uint>, uint>(ref rt);
                ref uint p = ref Unsafe.As<Vector128<uint>, uint>(ref vector);
                ref uint pindices = ref Unsafe.As<Vector128<uint>, uint>(ref indices);
                ref uint pback = ref Unsafe.As<Vector128<uint>, uint>(ref back);
                for (nint i = 0; i < Vector128<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, (int)selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleInsert_Basic(Vector128<ulong> back, Vector128<ulong> vector, Vector128<ulong> indices) {
                UnsafeUtil.SkipInit(out Vector128<ulong> rt);
                ulong cnt = (ulong)Vector128<ulong>.Count;
                ref ulong q = ref Unsafe.As<Vector128<ulong>, ulong>(ref rt);
                ref ulong p = ref Unsafe.As<Vector128<ulong>, ulong>(ref vector);
                ref ulong pindices = ref Unsafe.As<Vector128<ulong>, ulong>(ref indices);
                ref ulong pback = ref Unsafe.As<Vector128<ulong>, ulong>(ref back);
                for (nint i = 0; i < Vector128<ulong>.Count; ++i) {
                    ulong selectedIndex = Unsafe.Add(ref pindices, i);
                    ulong selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, (int)selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                args2 = Vector128.GreaterThan(Vector128.Create((byte)Vector128<byte>.Count), indices.AsByte()).AsSByte();
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                args2 = Vector128.GreaterThan(Vector128.Create((byte)Vector128<byte>.Count), indices);
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                args2 = Vector128.GreaterThan(Vector128.Create((ushort)Vector128<ushort>.Count), indices.AsUInt16()).AsInt16();
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                args2 = Vector128.GreaterThan(Vector128.Create((ushort)Vector128<ushort>.Count), indices);
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                args2 = Vector128.GreaterThan(Vector128.Create((uint)Vector128<uint>.Count), indices.AsUInt32()).AsInt32();
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                args2 = Vector128.GreaterThan(Vector128.Create((uint)Vector128<uint>.Count), indices);
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                args2 = Vector128.GreaterThan(Vector128.Create((ulong)Vector128<ulong>.Count), indices.AsUInt64()).AsInt64();
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleInsert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2) {
                args0 = indices;
                args1 = default;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                args2 = Vector128.GreaterThan(Vector128.Create((ulong)Vector128<ulong>.Count), indices);
#else
                args2 = default;
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                _ = args1;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                var raw = Vector128.Shuffle(vector, args0);
                var rt = Vector128.ConditionalSelect(args2, raw, back);
                return rt;
#else
                _ = args2;
                return YShuffleInsert_Basic(back, vector, args0);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                _ = args1;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                var raw = Vector128.Shuffle(vector, args0);
                var rt = Vector128.ConditionalSelect(args2, raw, back);
                return rt;
#else
                _ = args2;
                return YShuffleInsert_Basic(back, vector, args0);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                _ = args1;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                var raw = Vector128.Shuffle(vector, args0);
                var rt = Vector128.ConditionalSelect(args2, raw, back);
                return rt;
#else
                _ = args2;
                return YShuffleInsert_Basic(back, vector, args0);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
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
                _ = args1;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                var raw = Vector128.Shuffle(vector, args0);
                var rt = Vector128.ConditionalSelect(args2, raw, back);
                return rt;
#else
                _ = args2;
                return YShuffleInsert_Basic(back, vector, args0);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleKernel_AcceleratedTypes {
                get {
                    return Shuffle_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleKernel(Vector128<float> vector, Vector128<int> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleKernel(Vector128<double> vector, Vector128<long> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleKernel(Vector128<sbyte> vector, Vector128<sbyte> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleKernel(Vector128<byte> vector, Vector128<byte> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleKernel(Vector128<short> vector, Vector128<short> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleKernel(Vector128<ushort> vector, Vector128<ushort> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleKernel(Vector128<int> vector, Vector128<int> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleKernel(Vector128<uint> vector, Vector128<uint> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleKernel(Vector128<long> vector, Vector128<long> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleKernel(Vector128<ulong> vector, Vector128<ulong> indices) {
                return Shuffle(vector, indices);
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1) {
                args0 = indices;
                args1 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleKernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1) {
                args0 = indices;
                args1 = default;
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{float}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleKernel_Core(Vector128<float> vector, Vector128<int> args0, Vector128<int> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{double}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleKernel_Core(Vector128<double> vector, Vector128<long> args0, Vector128<long> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleKernel_Core(Vector128<sbyte> vector, Vector128<sbyte> args0, Vector128<sbyte> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleKernel_Core(Vector128<byte> vector, Vector128<byte> args0, Vector128<byte> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleKernel_Core(Vector128<short> vector, Vector128<short> args0, Vector128<short> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleKernel_Core(Vector128<ushort> vector, Vector128<ushort> args0, Vector128<ushort> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleKernel_Core(Vector128<int> vector, Vector128<int> args0, Vector128<int> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleKernel_Core(Vector128<uint> vector, Vector128<uint> args0, Vector128<uint> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleKernel_Core(Vector128<long> vector, Vector128<long> args0, Vector128<long> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleKernel_Core(Vector128<ulong> vector, Vector128<ulong> args0, Vector128<ulong> args1) {
                _ = args1;
                return YShuffleKernel(vector, args0);
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX2_AcceleratedTypes {
                get {
                    return YShuffleX2Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX2(Vector128<float> vector0, Vector128<float> vector1, Vector128<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX2(Vector128<double> vector0, Vector128<double> vector1, Vector128<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX2(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX2(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX2(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX2(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX2(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX2(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX2(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX2(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX2_Basic(Vector128<float> vector0, Vector128<float> vector1, Vector128<int> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX2_Basic(Vector128<double> vector0, Vector128<double> vector1, Vector128<long> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX2_Basic(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX2_Basic(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX2_Basic(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX2_Basic(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX2_Basic(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX2_Basic(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX2_Basic(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX2_Basic(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> indices) {
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

#if BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX2_Bit(Vector128<float> vector0, Vector128<float> vector1, Vector128<int> indices) {
                return YShuffleX2_Bit(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX2_Bit(Vector128<double> vector0, Vector128<double> vector1, Vector128<long> indices) {
                return YShuffleX2_Bit(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX2_Bit(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> indices) {
                return YShuffleX2_Bit(vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX2_Bit(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> indices) {
                const byte total = 2 * ByteCountValue / sizeof(byte); // 2 * Vector128<byte>.Count
                Vector128<byte> mask = Vector128.GreaterThan(Vector128.Create(total), indices);
                Vector128<byte> raw = YShuffleX2Kernel_Bit(vector0, vector1, indices);
                Vector128<byte> rt = Vector128.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX2_Bit(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> indices) {
                return YShuffleX2_Bit(vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX2_Bit(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> indices) {
                const ushort total = 2 * ByteCountValue / sizeof(ushort); // 2 * Vector128<ushort>.Count
                Vector128<ushort> mask = Vector128.GreaterThan(Vector128.Create(total), indices);
                Vector128<ushort> raw = YShuffleX2Kernel_Bit(vector0, vector1, indices);
                Vector128<ushort> rt = Vector128.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX2_Bit(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> indices) {
                return YShuffleX2_Bit(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX2_Bit(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> indices) {
                const uint total = 2 * ByteCountValue / sizeof(uint); // 2 * Vector128<uint>.Count
                Vector128<uint> mask = Vector128.GreaterThan(Vector128.Create(total), indices);
                Vector128<uint> raw = YShuffleX2Kernel_Bit(vector0, vector1, indices);
                Vector128<uint> rt = Vector128.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX2_Bit(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> indices) {
                return YShuffleX2_Bit(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX2_Bit(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> indices) {
                const ulong total = 2 * ByteCountValue / sizeof(ulong); // 2 * Vector128<ulong>.Count
                Vector128<ulong> mask = Vector128.GreaterThan(Vector128.Create(total), indices);
                Vector128<ulong> raw = YShuffleX2Kernel_Bit(vector0, vector1, indices);
                Vector128<ulong> rt = Vector128.BitwiseAnd(raw, mask);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX2_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX2_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX2_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX2_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX2_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX2_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX2_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX2_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX2_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX2_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2(vector0, vector1, args0);
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX2Insert_AcceleratedTypes {
                get {
                    return YShuffleX2Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX2Insert(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX2Insert(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX2Insert(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX2Insert(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX2Insert(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX2Insert(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX2Insert(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX2Insert(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX2Insert(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX2Insert(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Insert_Bit(back, vector0, vector1, indices);
#else
                return YShuffleX2Insert_Basic(back, vector0, vector1, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX2Insert_Basic(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<int> indices) {
                return YShuffleX2Insert_Basic(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX2Insert_Basic(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<long> indices) {
                return YShuffleX2Insert_Basic(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX2Insert_Basic(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> indices) {
                return YShuffleX2Insert_Basic(back.AsByte(), vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX2Insert_Basic(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> indices) {
                const byte total = 2 * ByteCountValue / sizeof(byte); // 2 * Vector128<byte>.Count
                Span<Vector128<byte>> rt = stackalloc Vector128<byte>[1];
                Span<Vector128<byte>> temp = [vector0, vector1];
                Span<byte> p = MemoryMarshal.Cast<Vector128<byte>, byte>(temp);
                Span<byte> q = MemoryMarshal.Cast<Vector128<byte>, byte>(rt);
                ref byte pindices = ref Unsafe.As<Vector128<byte>, byte>(ref indices);
                ref byte pback = ref Unsafe.As<Vector128<byte>, byte>(ref back);
                for (int i = 0; i < Vector128<byte>.Count; ++i) {
                    byte selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX2Insert_Basic(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> indices) {
                return YShuffleX2Insert_Basic(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX2Insert_Basic(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> indices) {
                const ushort total = 2 * ByteCountValue / sizeof(ushort); // 2 * Vector128<ushort>.Count
                Span<Vector128<ushort>> rt = stackalloc Vector128<ushort>[1];
                Span<Vector128<ushort>> temp = [vector0, vector1];
                Span<ushort> p = MemoryMarshal.Cast<Vector128<ushort>, ushort>(temp);
                Span<ushort> q = MemoryMarshal.Cast<Vector128<ushort>, ushort>(rt);
                ref ushort pindices = ref Unsafe.As<Vector128<ushort>, ushort>(ref indices);
                ref ushort pback = ref Unsafe.As<Vector128<ushort>, ushort>(ref back);
                for (int i = 0; i < Vector128<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX2Insert_Basic(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> indices) {
                return YShuffleX2Insert_Basic(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX2Insert_Basic(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> indices) {
                const uint total = 2 * ByteCountValue / sizeof(uint); // 2 * Vector128<uint>.Count
                Span<Vector128<uint>> rt = stackalloc Vector128<uint>[1];
                Span<Vector128<uint>> temp = [vector0, vector1];
                Span<uint> p = MemoryMarshal.Cast<Vector128<uint>, uint>(temp);
                Span<uint> q = MemoryMarshal.Cast<Vector128<uint>, uint>(rt);
                ref uint pindices = ref Unsafe.As<Vector128<uint>, uint>(ref indices);
                ref uint pback = ref Unsafe.As<Vector128<uint>, uint>(ref back);
                for (int i = 0; i < Vector128<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[(int)selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX2Insert_Basic(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> indices) {
                return YShuffleX2Insert_Basic(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX2Insert_Basic(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> indices) {
                const ulong total = 2 * ByteCountValue / sizeof(ulong); // 2 * Vector128<ulong>.Count
                Span<Vector128<ulong>> rt = stackalloc Vector128<ulong>[1];
                Span<Vector128<ulong>> temp = [vector0, vector1];
                Span<ulong> p = MemoryMarshal.Cast<Vector128<ulong>, ulong>(temp);
                Span<ulong> q = MemoryMarshal.Cast<Vector128<ulong>, ulong>(rt);
                ref ulong pindices = ref Unsafe.As<Vector128<ulong>, ulong>(ref indices);
                ref ulong pback = ref Unsafe.As<Vector128<ulong>, ulong>(ref back);
                for (int i = 0; i < Vector128<ulong>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX2Insert_Bit(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<int> indices) {
                return YShuffleX2Insert_Bit(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX2Insert_Bit(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<long> indices) {
                return YShuffleX2Insert_Bit(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX2Insert_Bit(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> indices) {
                return YShuffleX2Insert_Bit(back.AsByte(), vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX2Insert_Bit(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> indices) {
                const byte total = 2 * ByteCountValue / sizeof(byte); // 2 * Vector128<byte>.Count
                Vector128<byte> mask = Vector128.GreaterThan(Vector128.Create(total), indices);
                Vector128<byte> raw = YShuffleX2Kernel_Bit(vector0, vector1, indices);
                Vector128<byte> rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX2Insert_Bit(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> indices) {
                return YShuffleX2Insert_Bit(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX2Insert_Bit(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> indices) {
                const ushort total = 2 * ByteCountValue / sizeof(ushort); // 2 * Vector128<ushort>.Count
                Vector128<ushort> mask = Vector128.GreaterThan(Vector128.Create(total), indices);
                Vector128<ushort> raw = YShuffleX2Kernel_Bit(vector0, vector1, indices);
                Vector128<ushort> rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX2Insert_Bit(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> indices) {
                return YShuffleX2Insert_Bit(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX2Insert_Bit(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> indices) {
                const uint total = 2 * ByteCountValue / sizeof(uint); // 2 * Vector128<uint>.Count
                Vector128<uint> mask = Vector128.GreaterThan(Vector128.Create(total), indices);
                Vector128<uint> raw = YShuffleX2Kernel_Bit(vector0, vector1, indices);
                Vector128<uint> rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX2Insert_Bit(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> indices) {
                return YShuffleX2Insert_Bit(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX2Insert_Bit(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> indices) {
                const ulong total = 2 * ByteCountValue / sizeof(ulong); // 2 * Vector128<ulong>.Count
                Vector128<ulong> mask = Vector128.GreaterThan(Vector128.Create(total), indices);
                Vector128<ulong> raw = YShuffleX2Kernel_Bit(vector0, vector1, indices);
                Vector128<ulong> rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Insert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX2Insert_Core(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX2Insert_Core(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX2Insert_Core(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX2Insert_Core(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX2Insert_Core(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX2Insert_Core(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX2Insert_Core(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX2Insert_Core(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX2Insert_Core(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Insert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX2Insert_Core(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX2Insert(back, vector0, vector1, args0);
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX2Kernel_AcceleratedTypes {
                get {
                    return Shuffle_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX2Kernel(Vector128<float> vector0, Vector128<float> vector1, Vector128<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX2Kernel(Vector128<double> vector0, Vector128<double> vector1, Vector128<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX2Kernel(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX2Kernel(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX2Kernel(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX2Kernel(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX2Kernel(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX2Kernel(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX2Kernel(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX2Kernel(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX2Kernel_Bit(vector0, vector1, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX2Kernel_Basic(vector0, vector1, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX2Kernel_Basic(Vector128<float> vector0, Vector128<float> vector1, Vector128<int> indices) {
                return YShuffleX2Kernel_Basic(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX2Kernel_Basic(Vector128<double> vector0, Vector128<double> vector1, Vector128<long> indices) {
                return YShuffleX2Kernel_Basic(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX2Kernel_Basic(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> indices) {
                return YShuffleX2Kernel_Basic(vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX2Kernel_Basic(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> indices) {
                const byte total = 2 * ByteCountValue / sizeof(byte); // 2 * Vector128<byte>.Count
                Span<Vector128<byte>> rt = stackalloc Vector128<byte>[1];
                Span<Vector128<byte>> temp = [vector0, vector1];
                Span<byte> p = MemoryMarshal.Cast<Vector128<byte>, byte>(temp);
                Span<byte> q = MemoryMarshal.Cast<Vector128<byte>, byte>(rt);
                ref byte pindices = ref Unsafe.As<Vector128<byte>, byte>(ref indices);
                for (int i = 0; i < Vector128<byte>.Count; ++i) {
                    byte selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX2Kernel_Basic(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> indices) {
                return YShuffleX2Kernel_Basic(vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX2Kernel_Basic(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> indices) {
                const ushort total = 2 * ByteCountValue / sizeof(ushort); // 2 * Vector128<ushort>.Count
                Span<Vector128<ushort>> rt = stackalloc Vector128<ushort>[1];
                Span<Vector128<ushort>> temp = [vector0, vector1];
                Span<ushort> p = MemoryMarshal.Cast<Vector128<ushort>, ushort>(temp);
                Span<ushort> q = MemoryMarshal.Cast<Vector128<ushort>, ushort>(rt);
                ref ushort pindices = ref Unsafe.As<Vector128<ushort>, ushort>(ref indices);
                for (int i = 0; i < Vector128<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX2Kernel_Basic(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> indices) {
                return YShuffleX2Kernel_Basic(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX2Kernel_Basic(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> indices) {
                const uint total = 2 * ByteCountValue / sizeof(uint); // 2 * Vector128<uint>.Count
                Span<Vector128<uint>> rt = stackalloc Vector128<uint>[1];
                Span<Vector128<uint>> temp = [vector0, vector1];
                Span<uint> p = MemoryMarshal.Cast<Vector128<uint>, uint>(temp);
                Span<uint> q = MemoryMarshal.Cast<Vector128<uint>, uint>(rt);
                ref uint pindices = ref Unsafe.As<Vector128<uint>, uint>(ref indices);
                for (int i = 0; i < Vector128<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[(int)selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX2Kernel_Basic(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> indices) {
                return YShuffleX2Kernel_Basic(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX2Kernel_Basic(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> indices) {
                const ulong total = 2 * ByteCountValue / sizeof(ulong); // 2 * Vector128<ulong>.Count
                Span<Vector128<ulong>> rt = stackalloc Vector128<ulong>[1];
                Span<Vector128<ulong>> temp = [vector0, vector1];
                Span<ulong> p = MemoryMarshal.Cast<Vector128<ulong>, ulong>(temp);
                Span<ulong> q = MemoryMarshal.Cast<Vector128<ulong>, ulong>(rt);
                ref ulong pindices = ref Unsafe.As<Vector128<ulong>, ulong>(ref indices);
                for (int i = 0; i < Vector128<ulong>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX2Kernel_Bit(Vector128<float> vector0, Vector128<float> vector1, Vector128<int> indices) {
                return YShuffleX2Kernel_Bit(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX2Kernel_Bit(Vector128<double> vector0, Vector128<double> vector1, Vector128<long> indices) {
                return YShuffleX2Kernel_Bit(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX2Kernel_Bit(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> indices) {
                return YShuffleX2Kernel_Bit(vector0.AsByte(), vector1.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX2Kernel_Bit(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> indices) {
                Vector128<byte> vCount = Vector128.Create((byte)Vector128<byte>.Count);
                Vector128<byte> indices1 = Vector128.Subtract(indices, vCount);
                Vector128<byte> rt0 = Vector128.Shuffle(vector0, indices);
                Vector128<byte> rt1 = Vector128.Shuffle(vector1, indices1);
                Vector128<byte> rt = Vector128.BitwiseOr(rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX2Kernel_Bit(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> indices) {
                return YShuffleX2Kernel_Bit(vector0.AsUInt16(), vector1.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX2Kernel_Bit(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> indices) {
                Vector128<ushort> vCount = Vector128.Create((ushort)Vector128<ushort>.Count);
                Vector128<ushort> indices1 = Vector128.Subtract(indices, vCount);
                Vector128<ushort> rt0 = Vector128.Shuffle(vector0, indices);
                Vector128<ushort> rt1 = Vector128.Shuffle(vector1, indices1);
                Vector128<ushort> rt = Vector128.BitwiseOr(rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX2Kernel_Bit(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> indices) {
                return YShuffleX2Kernel_Bit(vector0.AsUInt32(), vector1.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX2Kernel_Bit(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> indices) {
                Vector128<uint> vCount = Vector128.Create((uint)Vector128<uint>.Count);
                Vector128<uint> indices1 = Vector128.Subtract(indices, vCount);
                Vector128<uint> rt0 = Vector128.Shuffle(vector0, indices);
                Vector128<uint> rt1 = Vector128.Shuffle(vector1, indices1);
                Vector128<uint> rt = Vector128.BitwiseOr(rt0, rt1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX2Kernel_Bit(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> indices) {
                return YShuffleX2Kernel_Bit(vector0.AsUInt64(), vector1.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX2Kernel_Bit(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> indices) {
                Vector128<ulong> vCount = Vector128.Create((ulong)Vector128<ulong>.Count);
                Vector128<ulong> indices1 = Vector128.Subtract(indices, vCount);
                Vector128<ulong> rt0 = Vector128.Shuffle(vector0, indices);
                Vector128<ulong> rt1 = Vector128.Shuffle(vector1, indices1);
                Vector128<ulong> rt = Vector128.BitwiseOr(rt0, rt1);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX2Kernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX2Kernel_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX2Kernel_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX2Kernel_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX2Kernel_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX2Kernel_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX2Kernel_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX2Kernel_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX2Kernel_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX2Kernel_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX2Kernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX2Kernel_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX2Kernel(vector0, vector1, args0);
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX3_AcceleratedTypes {
                get {
                    return YShuffleX3Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX3(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX3(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX3(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX3(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX3(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX3(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX3(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX3(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX3(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX3(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX3_Basic(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX3_Basic(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX3_Basic(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX3_Basic(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX3_Basic(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX3_Basic(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX3_Basic(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX3_Basic(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX3_Basic(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX3_Basic(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> indices) {
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

#if BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX3_Bit(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> indices) {
                return YShuffleX3_Bit(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX3_Bit(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> indices) {
                return YShuffleX3_Bit(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX3_Bit(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> indices) {
                return YShuffleX3_Bit(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX3_Bit(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> indices) {
                const byte total = 3 * ByteCountValue / sizeof(byte); // 3 * Vector128<byte>.Count
                Vector128<byte> mask = Vector128.GreaterThan(Vector128.Create(total), indices);
                Vector128<byte> raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                Vector128<byte> rt = Vector128.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX3_Bit(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> indices) {
                return YShuffleX3_Bit(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX3_Bit(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> indices) {
                const ushort total = 3 * ByteCountValue / sizeof(ushort); // 3 * Vector128<ushort>.Count
                Vector128<ushort> mask = Vector128.GreaterThan(Vector128.Create(total), indices);
                Vector128<ushort> raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                Vector128<ushort> rt = Vector128.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX3_Bit(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> indices) {
                return YShuffleX3_Bit(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX3_Bit(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> indices) {
                const uint total = 3 * ByteCountValue / sizeof(uint); // 3 * Vector128<uint>.Count
                Vector128<uint> mask = Vector128.GreaterThan(Vector128.Create(total), indices);
                Vector128<uint> raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                Vector128<uint> rt = Vector128.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX3_Bit(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> indices) {
                return YShuffleX3_Bit(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX3_Bit(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> indices) {
                const ulong total = 3 * ByteCountValue / sizeof(ulong); // 3 * Vector128<ulong>.Count
                Vector128<ulong> mask = Vector128.GreaterThan(Vector128.Create(total), indices);
                Vector128<ulong> raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                Vector128<ulong> rt = Vector128.BitwiseAnd(raw, mask);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX3_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX3_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX3_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX3_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX3_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX3_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX3_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX3_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX3_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX3_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3(vector0, vector1, vector2, args0);
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX3Insert_AcceleratedTypes {
                get {
                    return YShuffleX3Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX3Insert(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX3Insert(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX3Insert(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX3Insert(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX3Insert(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX3Insert(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX3Insert(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX3Insert(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX3Insert(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX3Insert(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3Insert_Bit(back, vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Insert_Basic(back, vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX3Insert_Basic(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> indices) {
                return YShuffleX3Insert_Basic(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX3Insert_Basic(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> indices) {
                return YShuffleX3Insert_Basic(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX3Insert_Basic(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> indices) {
                return YShuffleX3Insert_Basic(back.AsByte(), vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX3Insert_Basic(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> indices) {
                const byte total = 3 * ByteCountValue / sizeof(byte); // 3 * Vector128<byte>.Count
                Span<Vector128<byte>> rt = stackalloc Vector128<byte>[1];
                Span<Vector128<byte>> temp = [vector0, vector1, vector2];
                Span<byte> p = MemoryMarshal.Cast<Vector128<byte>, byte>(temp);
                Span<byte> q = MemoryMarshal.Cast<Vector128<byte>, byte>(rt);
                ref byte pindices = ref Unsafe.As<Vector128<byte>, byte>(ref indices);
                ref byte pback = ref Unsafe.As<Vector128<byte>, byte>(ref back);
                for (int i = 0; i < Vector128<byte>.Count; ++i) {
                    byte selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX3Insert_Basic(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> indices) {
                return YShuffleX3Insert_Basic(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX3Insert_Basic(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> indices) {
                const ushort total = 3 * ByteCountValue / sizeof(ushort); // 3 * Vector128<ushort>.Count
                Span<Vector128<ushort>> rt = stackalloc Vector128<ushort>[1];
                Span<Vector128<ushort>> temp = [vector0, vector1, vector2];
                Span<ushort> p = MemoryMarshal.Cast<Vector128<ushort>, ushort>(temp);
                Span<ushort> q = MemoryMarshal.Cast<Vector128<ushort>, ushort>(rt);
                ref ushort pindices = ref Unsafe.As<Vector128<ushort>, ushort>(ref indices);
                ref ushort pback = ref Unsafe.As<Vector128<ushort>, ushort>(ref back);
                for (int i = 0; i < Vector128<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX3Insert_Basic(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> indices) {
                return YShuffleX3Insert_Basic(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX3Insert_Basic(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> indices) {
                const uint total = 3 * ByteCountValue / sizeof(uint); // 3 * Vector128<uint>.Count
                Span<Vector128<uint>> rt = stackalloc Vector128<uint>[1];
                Span<Vector128<uint>> temp = [vector0, vector1, vector2];
                Span<uint> p = MemoryMarshal.Cast<Vector128<uint>, uint>(temp);
                Span<uint> q = MemoryMarshal.Cast<Vector128<uint>, uint>(rt);
                ref uint pindices = ref Unsafe.As<Vector128<uint>, uint>(ref indices);
                ref uint pback = ref Unsafe.As<Vector128<uint>, uint>(ref back);
                for (int i = 0; i < Vector128<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[(int)selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX3Insert_Basic(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> indices) {
                return YShuffleX3Insert_Basic(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX3Insert_Basic(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> indices) {
                const ulong total = 3 * ByteCountValue / sizeof(ulong); // 3 * Vector128<ulong>.Count
                Span<Vector128<ulong>> rt = stackalloc Vector128<ulong>[1];
                Span<Vector128<ulong>> temp = [vector0, vector1, vector2];
                Span<ulong> p = MemoryMarshal.Cast<Vector128<ulong>, ulong>(temp);
                Span<ulong> q = MemoryMarshal.Cast<Vector128<ulong>, ulong>(rt);
                ref ulong pindices = ref Unsafe.As<Vector128<ulong>, ulong>(ref indices);
                ref ulong pback = ref Unsafe.As<Vector128<ulong>, ulong>(ref back);
                for (int i = 0; i < Vector128<ulong>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX3Insert_Bit(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> indices) {
                return YShuffleX3Insert_Bit(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX3Insert_Bit(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> indices) {
                return YShuffleX3Insert_Bit(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX3Insert_Bit(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> indices) {
                return YShuffleX3Insert_Bit(back.AsByte(), vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX3Insert_Bit(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> indices) {
                const byte total = 3 * ByteCountValue / sizeof(byte); // 3 * Vector128<byte>.Count
                Vector128<byte> mask = Vector128.GreaterThan(Vector128.Create(total), indices);
                Vector128<byte> raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                Vector128<byte> rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX3Insert_Bit(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> indices) {
                return YShuffleX3Insert_Bit(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX3Insert_Bit(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> indices) {
                const ushort total = 3 * ByteCountValue / sizeof(ushort); // 3 * Vector128<ushort>.Count
                Vector128<ushort> mask = Vector128.GreaterThan(Vector128.Create(total), indices);
                Vector128<ushort> raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                Vector128<ushort> rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX3Insert_Bit(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> indices) {
                return YShuffleX3Insert_Bit(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX3Insert_Bit(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> indices) {
                const uint total = 3 * ByteCountValue / sizeof(uint); // 3 * Vector128<uint>.Count
                Vector128<uint> mask = Vector128.GreaterThan(Vector128.Create(total), indices);
                Vector128<uint> raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                Vector128<uint> rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX3Insert_Bit(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> indices) {
                return YShuffleX3Insert_Bit(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX3Insert_Bit(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> indices) {
                const ulong total = 3 * ByteCountValue / sizeof(ulong); // 3 * Vector128<ulong>.Count
                Vector128<ulong> mask = Vector128.GreaterThan(Vector128.Create(total), indices);
                Vector128<ulong> raw = YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                Vector128<ulong> rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Insert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX3Insert_Core(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX3Insert_Core(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX3Insert_Core(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX3Insert_Core(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX3Insert_Core(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX3Insert_Core(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX3Insert_Core(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX3Insert_Core(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX3Insert_Core(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Insert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX3Insert_Core(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX3Insert(back, vector0, vector1, vector2, args0);
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX3Kernel_AcceleratedTypes {
                get {
                    return Shuffle_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX3Kernel(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX3Kernel(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX3Kernel(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX3Kernel(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX3Kernel(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX3Kernel(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX3Kernel(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX3Kernel(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX3Kernel(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX3Kernel(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX3Kernel_Bit(vector0, vector1, vector2, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX3Kernel_Basic(vector0, vector1, vector2, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX3Kernel_Basic(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> indices) {
                return YShuffleX3Kernel_Basic(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX3Kernel_Basic(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> indices) {
                return YShuffleX3Kernel_Basic(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX3Kernel_Basic(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> indices) {
                return YShuffleX3Kernel_Basic(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX3Kernel_Basic(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> indices) {
                const byte total = 3 * ByteCountValue / sizeof(byte); // 3 * Vector128<byte>.Count
                Span<Vector128<byte>> rt = stackalloc Vector128<byte>[1];
                Span<Vector128<byte>> temp = [vector0, vector1, vector2];
                Span<byte> p = MemoryMarshal.Cast<Vector128<byte>, byte>(temp);
                Span<byte> q = MemoryMarshal.Cast<Vector128<byte>, byte>(rt);
                ref byte pindices = ref Unsafe.As<Vector128<byte>, byte>(ref indices);
                for (int i = 0; i < Vector128<byte>.Count; ++i) {
                    byte selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX3Kernel_Basic(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> indices) {
                return YShuffleX3Kernel_Basic(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX3Kernel_Basic(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> indices) {
                const ushort total = 3 * ByteCountValue / sizeof(ushort); // 3 * Vector128<ushort>.Count
                Span<Vector128<ushort>> rt = stackalloc Vector128<ushort>[1];
                Span<Vector128<ushort>> temp = [vector0, vector1, vector2];
                Span<ushort> p = MemoryMarshal.Cast<Vector128<ushort>, ushort>(temp);
                Span<ushort> q = MemoryMarshal.Cast<Vector128<ushort>, ushort>(rt);
                ref ushort pindices = ref Unsafe.As<Vector128<ushort>, ushort>(ref indices);
                for (int i = 0; i < Vector128<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX3Kernel_Basic(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> indices) {
                return YShuffleX3Kernel_Basic(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX3Kernel_Basic(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> indices) {
                const uint total = 3 * ByteCountValue / sizeof(uint); // 3 * Vector128<uint>.Count
                Span<Vector128<uint>> rt = stackalloc Vector128<uint>[1];
                Span<Vector128<uint>> temp = [vector0, vector1, vector2];
                Span<uint> p = MemoryMarshal.Cast<Vector128<uint>, uint>(temp);
                Span<uint> q = MemoryMarshal.Cast<Vector128<uint>, uint>(rt);
                ref uint pindices = ref Unsafe.As<Vector128<uint>, uint>(ref indices);
                for (int i = 0; i < Vector128<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[(int)selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX3Kernel_Basic(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> indices) {
                return YShuffleX3Kernel_Basic(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX3Kernel_Basic(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> indices) {
                const ulong total = 3 * ByteCountValue / sizeof(ulong); // 3 * Vector128<ulong>.Count
                Span<Vector128<ulong>> rt = stackalloc Vector128<ulong>[1];
                Span<Vector128<ulong>> temp = [vector0, vector1, vector2];
                Span<ulong> p = MemoryMarshal.Cast<Vector128<ulong>, ulong>(temp);
                Span<ulong> q = MemoryMarshal.Cast<Vector128<ulong>, ulong>(rt);
                ref ulong pindices = ref Unsafe.As<Vector128<ulong>, ulong>(ref indices);
                for (int i = 0; i < Vector128<ulong>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX3Kernel_Bit(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> indices) {
                return YShuffleX3Kernel_Bit(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX3Kernel_Bit(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> indices) {
                return YShuffleX3Kernel_Bit(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX3Kernel_Bit(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> indices) {
                return YShuffleX3Kernel_Bit(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX3Kernel_Bit(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> indices) {
                Vector128<byte> vCount = Vector128.Create((byte)Vector128<byte>.Count);
                Vector128<byte> indices1 = Vector128.Subtract(indices, vCount);
                Vector128<byte> indices2 = Vector128.Subtract(indices1, vCount);
                Vector128<byte> rt0 = Vector128.Shuffle(vector0, indices);
                Vector128<byte> rt1 = Vector128.Shuffle(vector1, indices1);
                Vector128<byte> rt2 = Vector128.Shuffle(vector2, indices2);
                rt0 = Vector128.BitwiseOr(rt0, rt1);
                Vector128<byte> rt = Vector128.BitwiseOr(rt0, rt2);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX3Kernel_Bit(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> indices) {
                return YShuffleX3Kernel_Bit(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX3Kernel_Bit(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> indices) {
                Vector128<ushort> vCount = Vector128.Create((ushort)Vector128<ushort>.Count);
                Vector128<ushort> indices1 = Vector128.Subtract(indices, vCount);
                Vector128<ushort> indices2 = Vector128.Subtract(indices1, vCount);
                Vector128<ushort> rt0 = Vector128.Shuffle(vector0, indices);
                Vector128<ushort> rt1 = Vector128.Shuffle(vector1, indices1);
                Vector128<ushort> rt2 = Vector128.Shuffle(vector2, indices2);
                rt0 = Vector128.BitwiseOr(rt0, rt1);
                Vector128<ushort> rt = Vector128.BitwiseOr(rt0, rt2);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX3Kernel_Bit(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> indices) {
                return YShuffleX3Kernel_Bit(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX3Kernel_Bit(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> indices) {
                Vector128<uint> vCount = Vector128.Create((uint)Vector128<uint>.Count);
                Vector128<uint> indices1 = Vector128.Subtract(indices, vCount);
                Vector128<uint> indices2 = Vector128.Subtract(indices1, vCount);
                Vector128<uint> rt0 = Vector128.Shuffle(vector0, indices);
                Vector128<uint> rt1 = Vector128.Shuffle(vector1, indices1);
                Vector128<uint> rt2 = Vector128.Shuffle(vector2, indices2);
                rt0 = Vector128.BitwiseOr(rt0, rt1);
                Vector128<uint> rt = Vector128.BitwiseOr(rt0, rt2);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX3Kernel_Bit(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> indices) {
                return YShuffleX3Kernel_Bit(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX3Kernel_Bit(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> indices) {
                Vector128<ulong> vCount = Vector128.Create((ulong)Vector128<ulong>.Count);
                Vector128<ulong> indices1 = Vector128.Subtract(indices, vCount);
                Vector128<ulong> indices2 = Vector128.Subtract(indices1, vCount);
                Vector128<ulong> rt0 = Vector128.Shuffle(vector0, indices);
                Vector128<ulong> rt1 = Vector128.Shuffle(vector1, indices1);
                Vector128<ulong> rt2 = Vector128.Shuffle(vector2, indices2);
                rt0 = Vector128.BitwiseOr(rt0, rt1);
                Vector128<ulong> rt = Vector128.BitwiseOr(rt0, rt2);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX3Kernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX3Kernel_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX3Kernel_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX3Kernel_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX3Kernel_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX3Kernel_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX3Kernel_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX3Kernel_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX3Kernel_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX3Kernel_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX3Kernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX3Kernel_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX3Kernel(vector0, vector1, vector2, args0);
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX4_AcceleratedTypes {
                get {
                    return YShuffleX4Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX4(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX4(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX4(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX4(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX4(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX4(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX4(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX4(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX4(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX4(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX4_Basic(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX4_Basic(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX4_Basic(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX4_Basic(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX4_Basic(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX4_Basic(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX4_Basic(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX4_Basic(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX4_Basic(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX4_Basic(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> indices) {
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

#if BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX4_Bit(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> indices) {
                return YShuffleX4_Bit(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX4_Bit(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> indices) {
                return YShuffleX4_Bit(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX4_Bit(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> indices) {
                return YShuffleX4_Bit(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX4_Bit(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> indices) {
                const byte total = 4 * ByteCountValue / sizeof(byte); // 4 * Vector128<byte>.Count
                Vector128<byte> mask = Vector128.GreaterThan(Vector128.Create(total), indices);
                Vector128<byte> raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                Vector128<byte> rt = Vector128.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX4_Bit(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> indices) {
                return YShuffleX4_Bit(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX4_Bit(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> indices) {
                const ushort total = 4 * ByteCountValue / sizeof(ushort); // 4 * Vector128<ushort>.Count
                Vector128<ushort> mask = Vector128.GreaterThan(Vector128.Create(total), indices);
                Vector128<ushort> raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                Vector128<ushort> rt = Vector128.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX4_Bit(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> indices) {
                return YShuffleX4_Bit(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX4_Bit(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> indices) {
                const uint total = 4 * ByteCountValue / sizeof(uint); // 4 * Vector128<uint>.Count
                Vector128<uint> mask = Vector128.GreaterThan(Vector128.Create(total), indices);
                Vector128<uint> raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                Vector128<uint> rt = Vector128.BitwiseAnd(raw, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX4_Bit(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> indices) {
                return YShuffleX4_Bit(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX4_Bit(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> indices) {
                const ulong total = 4 * ByteCountValue / sizeof(ulong); // 4 * Vector128<ulong>.Count
                Vector128<ulong> mask = Vector128.GreaterThan(Vector128.Create(total), indices);
                Vector128<ulong> raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                Vector128<ulong> rt = Vector128.BitwiseAnd(raw, mask);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX4_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX4_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX4_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX4_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX4_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX4_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX4_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX4_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX4_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX4_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4(vector0, vector1, vector2, vector3, args0);
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX4Insert_AcceleratedTypes {
                get {
                    return YShuffleX4Kernel_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX4Insert(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX4Insert(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX4Insert(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX4Insert(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX4Insert(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX4Insert(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX4Insert(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX4Insert(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX4Insert(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX4Insert(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4Insert_Bit(back, vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Insert_Basic(back, vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX4Insert_Basic(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> indices) {
                return YShuffleX4Insert_Basic(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX4Insert_Basic(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> indices) {
                return YShuffleX4Insert_Basic(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX4Insert_Basic(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> indices) {
                return YShuffleX4Insert_Basic(back.AsByte(), vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX4Insert_Basic(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> indices) {
                const byte total = 4 * ByteCountValue / sizeof(byte); // 4 * Vector128<byte>.Count
                Span<Vector128<byte>> rt = stackalloc Vector128<byte>[1];
                Span<Vector128<byte>> temp = [vector0, vector1, vector2, vector3];
                Span<byte> p = MemoryMarshal.Cast<Vector128<byte>, byte>(temp);
                Span<byte> q = MemoryMarshal.Cast<Vector128<byte>, byte>(rt);
                ref byte pindices = ref Unsafe.As<Vector128<byte>, byte>(ref indices);
                ref byte pback = ref Unsafe.As<Vector128<byte>, byte>(ref back);
                for (int i = 0; i < Vector128<byte>.Count; ++i) {
                    byte selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX4Insert_Basic(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> indices) {
                return YShuffleX4Insert_Basic(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX4Insert_Basic(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> indices) {
                const ushort total = 4 * ByteCountValue / sizeof(ushort); // 4 * Vector128<ushort>.Count
                Span<Vector128<ushort>> rt = stackalloc Vector128<ushort>[1];
                Span<Vector128<ushort>> temp = [vector0, vector1, vector2, vector3];
                Span<ushort> p = MemoryMarshal.Cast<Vector128<ushort>, ushort>(temp);
                Span<ushort> q = MemoryMarshal.Cast<Vector128<ushort>, ushort>(rt);
                ref ushort pindices = ref Unsafe.As<Vector128<ushort>, ushort>(ref indices);
                ref ushort pback = ref Unsafe.As<Vector128<ushort>, ushort>(ref back);
                for (int i = 0; i < Vector128<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX4Insert_Basic(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> indices) {
                return YShuffleX4Insert_Basic(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX4Insert_Basic(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> indices) {
                const uint total = 4 * ByteCountValue / sizeof(uint); // 4 * Vector128<uint>.Count
                Span<Vector128<uint>> rt = stackalloc Vector128<uint>[1];
                Span<Vector128<uint>> temp = [vector0, vector1, vector2, vector3];
                Span<uint> p = MemoryMarshal.Cast<Vector128<uint>, uint>(temp);
                Span<uint> q = MemoryMarshal.Cast<Vector128<uint>, uint>(rt);
                ref uint pindices = ref Unsafe.As<Vector128<uint>, uint>(ref indices);
                ref uint pback = ref Unsafe.As<Vector128<uint>, uint>(ref back);
                for (int i = 0; i < Vector128<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < total) {
                        selectedValue = p[(int)selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX4Insert_Basic(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> indices) {
                return YShuffleX4Insert_Basic(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX4Insert_Basic(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> indices) {
                const ulong total = 4 * ByteCountValue / sizeof(ulong); // 4 * Vector128<ulong>.Count
                Span<Vector128<ulong>> rt = stackalloc Vector128<ulong>[1];
                Span<Vector128<ulong>> temp = [vector0, vector1, vector2, vector3];
                Span<ulong> p = MemoryMarshal.Cast<Vector128<ulong>, ulong>(temp);
                Span<ulong> q = MemoryMarshal.Cast<Vector128<ulong>, ulong>(rt);
                ref ulong pindices = ref Unsafe.As<Vector128<ulong>, ulong>(ref indices);
                ref ulong pback = ref Unsafe.As<Vector128<ulong>, ulong>(ref back);
                for (int i = 0; i < Vector128<ulong>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX4Insert_Bit(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> indices) {
                return YShuffleX4Insert_Bit(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX4Insert_Bit(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> indices) {
                return YShuffleX4Insert_Bit(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX4Insert_Bit(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> indices) {
                return YShuffleX4Insert_Bit(back.AsByte(), vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX4Insert_Bit(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> indices) {
                const byte total = 4 * ByteCountValue / sizeof(byte); // 4 * Vector128<byte>.Count
                Vector128<byte> mask = Vector128.GreaterThan(Vector128.Create(total), indices);
                Vector128<byte> raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                Vector128<byte> rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX4Insert_Bit(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> indices) {
                return YShuffleX4Insert_Bit(back.AsUInt16(), vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX4Insert_Bit(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> indices) {
                const ushort total = 4 * ByteCountValue / sizeof(ushort); // 4 * Vector128<ushort>.Count
                Vector128<ushort> mask = Vector128.GreaterThan(Vector128.Create(total), indices);
                Vector128<ushort> raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                Vector128<ushort> rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX4Insert_Bit(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> indices) {
                return YShuffleX4Insert_Bit(back.AsUInt32(), vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX4Insert_Bit(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> indices) {
                const uint total = 4 * ByteCountValue / sizeof(uint); // 4 * Vector128<uint>.Count
                Vector128<uint> mask = Vector128.GreaterThan(Vector128.Create(total), indices);
                Vector128<uint> raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                Vector128<uint> rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX4Insert_Bit(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> indices) {
                return YShuffleX4Insert_Bit(back.AsUInt64(), vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX4Insert_Bit(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> indices) {
                const ulong total = 4 * ByteCountValue / sizeof(ulong); // 4 * Vector128<ulong>.Count
                Vector128<ulong> mask = Vector128.GreaterThan(Vector128.Create(total), indices);
                Vector128<ulong> raw = YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                Vector128<ulong> rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3, out Vector128<sbyte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3, out Vector128<byte> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3, out Vector128<short> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3, out Vector128<ushort> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3, out Vector128<int> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3, out Vector128<uint> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3, out Vector128<long> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Insert_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3, out Vector128<ulong> args4) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
                args4 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX4Insert_Core(Vector128<float> back, Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX4Insert_Core(Vector128<double> back, Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX4Insert_Core(Vector128<sbyte> back, Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3, Vector128<sbyte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX4Insert_Core(Vector128<byte> back, Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3, Vector128<byte> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX4Insert_Core(Vector128<short> back, Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3, Vector128<short> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX4Insert_Core(Vector128<ushort> back, Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3, Vector128<ushort> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX4Insert_Core(Vector128<int> back, Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3, Vector128<int> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX4Insert_Core(Vector128<uint> back, Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3, Vector128<uint> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX4Insert_Core(Vector128<long> back, Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3, Vector128<long> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Insert_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX4Insert_Core(Vector128<ulong> back, Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3, Vector128<ulong> args4) {
                _ = args1;
                _ = args2;
                _ = args3;
                _ = args4;
                return YShuffleX4Insert(back, vector0, vector1, vector2, vector3, args0);
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleX4Kernel_AcceleratedTypes {
                get {
                    return Shuffle_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX4Kernel(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX4Kernel(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX4Kernel(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX4Kernel(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX4Kernel(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX4Kernel(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX4Kernel(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX4Kernel(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX4Kernel(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX4Kernel(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> indices) {
#if BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                if (Bcl_Shuffle_Used && Vector128.IsHardwareAccelerated) {
                    return YShuffleX4Kernel_Bit(vector0, vector1, vector2, vector3, indices);
                }
#endif // BCL_OVERRIDE_BASE_FIXED && BCL_HAS_SHUFFLE
                return YShuffleX4Kernel_Basic(vector0, vector1, vector2, vector3, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX4Kernel_Basic(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> indices) {
                return YShuffleX4Kernel_Basic(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX4Kernel_Basic(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> indices) {
                return YShuffleX4Kernel_Basic(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX4Kernel_Basic(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> indices) {
                return YShuffleX4Kernel_Basic(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX4Kernel_Basic(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> indices) {
                const byte total = 4 * ByteCountValue / sizeof(byte); // 4 * Vector128<byte>.Count
                Span<Vector128<byte>> rt = stackalloc Vector128<byte>[1];
                Span<Vector128<byte>> temp = [vector0, vector1, vector2, vector3];
                Span<byte> p = MemoryMarshal.Cast<Vector128<byte>, byte>(temp);
                Span<byte> q = MemoryMarshal.Cast<Vector128<byte>, byte>(rt);
                ref byte pindices = ref Unsafe.As<Vector128<byte>, byte>(ref indices);
                for (int i = 0; i < Vector128<byte>.Count; ++i) {
                    byte selectedIndex = Unsafe.Add(ref pindices, i);
                    byte selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX4Kernel_Basic(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> indices) {
                return YShuffleX4Kernel_Basic(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX4Kernel_Basic(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> indices) {
                const ushort total = 4 * ByteCountValue / sizeof(ushort); // 4 * Vector128<ushort>.Count
                Span<Vector128<ushort>> rt = stackalloc Vector128<ushort>[1];
                Span<Vector128<ushort>> temp = [vector0, vector1, vector2, vector3];
                Span<ushort> p = MemoryMarshal.Cast<Vector128<ushort>, ushort>(temp);
                Span<ushort> q = MemoryMarshal.Cast<Vector128<ushort>, ushort>(rt);
                ref ushort pindices = ref Unsafe.As<Vector128<ushort>, ushort>(ref indices);
                for (int i = 0; i < Vector128<ushort>.Count; ++i) {
                    ushort selectedIndex = Unsafe.Add(ref pindices, i);
                    ushort selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX4Kernel_Basic(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> indices) {
                return YShuffleX4Kernel_Basic(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX4Kernel_Basic(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> indices) {
                const uint total = 4 * ByteCountValue / sizeof(uint); // 4 * Vector128<uint>.Count
                Span<Vector128<uint>> rt = stackalloc Vector128<uint>[1];
                Span<Vector128<uint>> temp = [vector0, vector1, vector2, vector3];
                Span<uint> p = MemoryMarshal.Cast<Vector128<uint>, uint>(temp);
                Span<uint> q = MemoryMarshal.Cast<Vector128<uint>, uint>(rt);
                ref uint pindices = ref Unsafe.As<Vector128<uint>, uint>(ref indices);
                for (int i = 0; i < Vector128<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = default;
                    if (selectedIndex < total) {
                        selectedValue = p[(int)selectedIndex];
                    }
                    q[i] = selectedValue;
                }
                return rt[0];
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX4Kernel_Basic(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> indices) {
                return YShuffleX4Kernel_Basic(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX4Kernel_Basic(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> indices) {
                const ulong total = 4 * ByteCountValue / sizeof(ulong); // 4 * Vector128<ulong>.Count
                Span<Vector128<ulong>> rt = stackalloc Vector128<ulong>[1];
                Span<Vector128<ulong>> temp = [vector0, vector1, vector2, vector3];
                Span<ulong> p = MemoryMarshal.Cast<Vector128<ulong>, ulong>(temp);
                Span<ulong> q = MemoryMarshal.Cast<Vector128<ulong>, ulong>(rt);
                ref ulong pindices = ref Unsafe.As<Vector128<ulong>, ulong>(ref indices);
                for (int i = 0; i < Vector128<ulong>.Count; ++i) {
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

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX4Kernel_Bit(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> indices) {
                return YShuffleX4Kernel_Bit(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX4Kernel_Bit(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> indices) {
                return YShuffleX4Kernel_Bit(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX4Kernel_Bit(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> indices) {
                return YShuffleX4Kernel_Bit(vector0.AsByte(), vector1.AsByte(), vector2.AsByte(), vector3.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX4Kernel_Bit(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> indices) {
                Vector128<byte> vCount = Vector128.Create((byte)Vector128<byte>.Count);
                Vector128<byte> indices1 = Vector128.Subtract(indices, vCount);
                Vector128<byte> indices2 = Vector128.Subtract(indices1, vCount);
                Vector128<byte> indices3 = Vector128.Subtract(indices2, vCount);
                Vector128<byte> rt0 = Vector128.Shuffle(vector0, indices);
                Vector128<byte> rt1 = Vector128.Shuffle(vector1, indices1);
                Vector128<byte> rt2 = Vector128.Shuffle(vector2, indices2);
                Vector128<byte> rt3 = Vector128.Shuffle(vector3, indices3);
                rt0 = Vector128.BitwiseOr(rt0, rt1);
                rt2 = Vector128.BitwiseOr(rt2, rt3);
                Vector128<byte> rt = Vector128.BitwiseOr(rt0, rt2);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX4Kernel_Bit(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> indices) {
                return YShuffleX4Kernel_Bit(vector0.AsUInt16(), vector1.AsUInt16(), vector2.AsUInt16(), vector3.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX4Kernel_Bit(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> indices) {
                Vector128<ushort> vCount = Vector128.Create((ushort)Vector128<ushort>.Count);
                Vector128<ushort> indices1 = Vector128.Subtract(indices, vCount);
                Vector128<ushort> indices2 = Vector128.Subtract(indices1, vCount);
                Vector128<ushort> indices3 = Vector128.Subtract(indices2, vCount);
                Vector128<ushort> rt0 = Vector128.Shuffle(vector0, indices);
                Vector128<ushort> rt1 = Vector128.Shuffle(vector1, indices1);
                Vector128<ushort> rt2 = Vector128.Shuffle(vector2, indices2);
                Vector128<ushort> rt3 = Vector128.Shuffle(vector3, indices3);
                rt0 = Vector128.BitwiseOr(rt0, rt1);
                rt2 = Vector128.BitwiseOr(rt2, rt3);
                Vector128<ushort> rt = Vector128.BitwiseOr(rt0, rt2);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX4Kernel_Bit(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> indices) {
                return YShuffleX4Kernel_Bit(vector0.AsUInt32(), vector1.AsUInt32(), vector2.AsUInt32(), vector3.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX4Kernel_Bit(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> indices) {
                Vector128<uint> vCount = Vector128.Create((uint)Vector128<uint>.Count);
                Vector128<uint> indices1 = Vector128.Subtract(indices, vCount);
                Vector128<uint> indices2 = Vector128.Subtract(indices1, vCount);
                Vector128<uint> indices3 = Vector128.Subtract(indices2, vCount);
                Vector128<uint> rt0 = Vector128.Shuffle(vector0, indices);
                Vector128<uint> rt1 = Vector128.Shuffle(vector1, indices1);
                Vector128<uint> rt2 = Vector128.Shuffle(vector2, indices2);
                Vector128<uint> rt3 = Vector128.Shuffle(vector3, indices3);
                rt0 = Vector128.BitwiseOr(rt0, rt1);
                rt2 = Vector128.BitwiseOr(rt2, rt3);
                Vector128<uint> rt = Vector128.BitwiseOr(rt0, rt2);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX4Kernel_Bit(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> indices) {
                return YShuffleX4Kernel_Bit(vector0.AsUInt64(), vector1.AsUInt64(), vector2.AsUInt64(), vector3.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX4Kernel_Bit(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> indices) {
                Vector128<ulong> vCount = Vector128.Create((ulong)Vector128<ulong>.Count);
                Vector128<ulong> indices1 = Vector128.Subtract(indices, vCount);
                Vector128<ulong> indices2 = Vector128.Subtract(indices1, vCount);
                Vector128<ulong> indices3 = Vector128.Subtract(indices2, vCount);
                Vector128<ulong> rt0 = Vector128.Shuffle(vector0, indices);
                Vector128<ulong> rt1 = Vector128.Shuffle(vector1, indices1);
                Vector128<ulong> rt2 = Vector128.Shuffle(vector2, indices2);
                Vector128<ulong> rt3 = Vector128.Shuffle(vector3, indices3);
                rt0 = Vector128.BitwiseOr(rt0, rt1);
                rt2 = Vector128.BitwiseOr(rt2, rt3);
                Vector128<ulong> rt = Vector128.BitwiseOr(rt0, rt2);
                return rt;
            }

#endif // BCL_HAS_SHUFFLE

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte}, out Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector128<sbyte> indices, out Vector128<sbyte> args0, out Vector128<sbyte> args1, out Vector128<sbyte> args2, out Vector128<sbyte> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte}, out Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector128<byte> indices, out Vector128<byte> args0, out Vector128<byte> args1, out Vector128<byte> args2, out Vector128<byte> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short}, out Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector128<short> indices, out Vector128<short> args0, out Vector128<short> args1, out Vector128<short> args2, out Vector128<short> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort}, out Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector128<ushort> indices, out Vector128<ushort> args0, out Vector128<ushort> args1, out Vector128<ushort> args2, out Vector128<ushort> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int}, out Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector128<int> indices, out Vector128<int> args0, out Vector128<int> args1, out Vector128<int> args2, out Vector128<int> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint}, out Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector128<uint> indices, out Vector128<uint> args0, out Vector128<uint> args1, out Vector128<uint> args2, out Vector128<uint> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long}, out Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector128<long> indices, out Vector128<long> args0, out Vector128<long> args1, out Vector128<long> args2, out Vector128<long> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Args(Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong}, out Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void YShuffleX4Kernel_Args(Vector128<ulong> indices, out Vector128<ulong> args0, out Vector128<ulong> args1, out Vector128<ulong> args2, out Vector128<ulong> args3) {
                args0 = indices;
                args1 = default;
                args2 = default;
                args3 = default;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{float}, Vector128{float}, Vector128{float}, Vector128{float}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleX4Kernel_Core(Vector128<float> vector0, Vector128<float> vector1, Vector128<float> vector2, Vector128<float> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{double}, Vector128{double}, Vector128{double}, Vector128{double}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleX4Kernel_Core(Vector128<double> vector0, Vector128<double> vector1, Vector128<double> vector2, Vector128<double> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleX4Kernel_Core(Vector128<sbyte> vector0, Vector128<sbyte> vector1, Vector128<sbyte> vector2, Vector128<sbyte> vector3, Vector128<sbyte> args0, Vector128<sbyte> args1, Vector128<sbyte> args2, Vector128<sbyte> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleX4Kernel_Core(Vector128<byte> vector0, Vector128<byte> vector1, Vector128<byte> vector2, Vector128<byte> vector3, Vector128<byte> args0, Vector128<byte> args1, Vector128<byte> args2, Vector128<byte> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleX4Kernel_Core(Vector128<short> vector0, Vector128<short> vector1, Vector128<short> vector2, Vector128<short> vector3, Vector128<short> args0, Vector128<short> args1, Vector128<short> args2, Vector128<short> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleX4Kernel_Core(Vector128<ushort> vector0, Vector128<ushort> vector1, Vector128<ushort> vector2, Vector128<ushort> vector3, Vector128<ushort> args0, Vector128<ushort> args1, Vector128<ushort> args2, Vector128<ushort> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleX4Kernel_Core(Vector128<int> vector0, Vector128<int> vector1, Vector128<int> vector2, Vector128<int> vector3, Vector128<int> args0, Vector128<int> args1, Vector128<int> args2, Vector128<int> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleX4Kernel_Core(Vector128<uint> vector0, Vector128<uint> vector1, Vector128<uint> vector2, Vector128<uint> vector3, Vector128<uint> args0, Vector128<uint> args1, Vector128<uint> args2, Vector128<uint> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleX4Kernel_Core(Vector128<long> vector0, Vector128<long> vector1, Vector128<long> vector2, Vector128<long> vector3, Vector128<long> args0, Vector128<long> args1, Vector128<long> args2, Vector128<long> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleX4Kernel_Core(Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleX4Kernel_Core(Vector128<ulong> vector0, Vector128<ulong> vector1, Vector128<ulong> vector2, Vector128<ulong> vector3, Vector128<ulong> args0, Vector128<ulong> args1, Vector128<ulong> args2, Vector128<ulong> args3) {
                _ = args1;
                _ = args2;
                _ = args3;
                return YShuffleX4Kernel(vector0, vector1, vector2, vector3, args0);
            }


            /// <inheritdoc cref="IWVectorTraits128.YSign_AcceleratedTypes"/>
            public static TypeCodeFlags YSign_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YSign(Vector128<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YSign_Bit(value);
#else
                return YSign_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YSign(Vector128<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YSign_Bit(value);
#else
                return YSign_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YSign(Vector128<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YSign_Bit(value);
#else
                return YSign_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YSign(Vector128<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YSign_Bit(value);
#else
                return YSign_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YSign(Vector128<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YSign_Bit(value);
#else
                return YSign_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YSign(Vector128<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YSign_Bit(value);
#else
                return YSign_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YSign_Basic(Vector128<float> value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray4<float> pvalue = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref value);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = MathINumber.Sign(pvalue.I0);
                p.I1 = MathINumber.Sign(pvalue.I1);
                p.I2 = MathINumber.Sign(pvalue.I2);
                p.I3 = MathINumber.Sign(pvalue.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YSign_Basic(Vector128<double> value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray2<double> pvalue = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref value);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = MathINumber.Sign(pvalue.I0);
                p.I1 = MathINumber.Sign(pvalue.I1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YSign_Basic(Vector128<sbyte> value) {
                UnsafeUtil.SkipInit(out Vector128<sbyte> rt);
                ref FixedArray16<sbyte> pvalue = ref Unsafe.As<Vector128<sbyte>, FixedArray16<sbyte>>(ref value);
                ref FixedArray16<sbyte> p = ref Unsafe.As<Vector128<sbyte>, FixedArray16<sbyte>>(ref rt);
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
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YSign_Basic(Vector128<short> value) {
                UnsafeUtil.SkipInit(out Vector128<short> rt);
                ref FixedArray8<short> pvalue = ref Unsafe.As<Vector128<short>, FixedArray8<short>>(ref value);
                ref FixedArray8<short> p = ref Unsafe.As<Vector128<short>, FixedArray8<short>>(ref rt);
                p.I0 = (short)MathINumber.Sign(pvalue.I0);
                p.I1 = (short)MathINumber.Sign(pvalue.I1);
                p.I2 = (short)MathINumber.Sign(pvalue.I2);
                p.I3 = (short)MathINumber.Sign(pvalue.I3);
                p.I4 = (short)MathINumber.Sign(pvalue.I4);
                p.I5 = (short)MathINumber.Sign(pvalue.I5);
                p.I6 = (short)MathINumber.Sign(pvalue.I6);
                p.I7 = (short)MathINumber.Sign(pvalue.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YSign_Basic(Vector128<int> value) {
                UnsafeUtil.SkipInit(out Vector128<int> rt);
                ref FixedArray4<int> pvalue = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref value);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = MathINumber.Sign(pvalue.I0);
                p.I1 = MathINumber.Sign(pvalue.I1);
                p.I2 = MathINumber.Sign(pvalue.I2);
                p.I3 = MathINumber.Sign(pvalue.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YSign_Basic(Vector128<long> value) {
                UnsafeUtil.SkipInit(out Vector128<long> rt);
                ref FixedArray2<long> pvalue = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref value);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = MathINumber.Sign(pvalue.I0);
                p.I1 = MathINumber.Sign(pvalue.I1);
                return rt;
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YSign_Bit(Vector128<float> value) {
                // (x > 0) - (x < 0); //From "Hacker's Delight" 2.7, Page 19.
                // = (-to_mask(x > 0)) - (-to_mask(x < 0))
                // = to_mask(x < 0) - to_mask(x > 0).
                Vector128<float> zero = Vector128<float>.Zero;
                Vector128<int> m = Vector128.LessThan(value, zero).AsInt32();
                Vector128<int> n = Vector128.GreaterThan(value, zero).AsInt32();
                Vector128<int> rt = Vector128.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YSign_Bit(Vector128<double> value) {
                Vector128<double> zero = Vector128<double>.Zero;
                Vector128<long> m = Vector128.LessThan(value, zero).AsInt64();
                Vector128<long> n = Vector128.GreaterThan(value, zero).AsInt64();
                Vector128<long> rt = Vector128.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YSign_Bit(Vector128<sbyte> value) {
                Vector128<sbyte> zero = Vector128<sbyte>.Zero;
                Vector128<sbyte> m = Vector128.LessThan(value, zero);
                Vector128<sbyte> n = Vector128.GreaterThan(value, zero);
                Vector128<sbyte> rt = Vector128.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YSign_Bit(Vector128<short> value) {
                Vector128<short> zero = Vector128<short>.Zero;
                Vector128<short> m = Vector128.LessThan(value, zero);
                Vector128<short> n = Vector128.GreaterThan(value, zero);
                Vector128<short> rt = Vector128.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YSign_Bit(Vector128<int> value) {
                Vector128<int> zero = Vector128<int>.Zero;
                Vector128<int> m = Vector128.LessThan(value, zero);
                Vector128<int> n = Vector128.GreaterThan(value, zero);
                Vector128<int> rt = Vector128.Subtract(m, n);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSign(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YSign_Bit(Vector128<long> value) {
                Vector128<long> zero = Vector128<long>.Zero;
                Vector128<long> m = Vector128.LessThan(value, zero);
                Vector128<long> n = Vector128.GreaterThan(value, zero);
                Vector128<long> rt = Vector128.Subtract(m, n);
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.YSignFloat_AcceleratedTypes"/>
            public static TypeCodeFlags YSignFloat_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= (TypeCodeFlags.Single) & YIsNaN_AcceleratedTypes & YSign_AcceleratedTypes & ConvertToSingle_AcceleratedTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YSignFloat(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YSignFloat(Vector128<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YSignFloat_Bit(value);
#else
                return YSignFloat_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YSignFloat(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YSignFloat(Vector128<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return YSignFloat_Bit(value);
#else
                return YSignFloat_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.YSignFloat(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YSignFloat_Basic(Vector128<float> value) {
                UnsafeUtil.SkipInit(out Vector128<float> rt);
                ref FixedArray4<float> pvalue = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref value);
                ref FixedArray4<float> p = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref rt);
                p.I0 = MathINumber.SignFloat(pvalue.I0);
                p.I1 = MathINumber.SignFloat(pvalue.I1);
                p.I2 = MathINumber.SignFloat(pvalue.I2);
                p.I3 = MathINumber.SignFloat(pvalue.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSignFloat(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YSignFloat_Basic(Vector128<double> value) {
                UnsafeUtil.SkipInit(out Vector128<double> rt);
                ref FixedArray2<double> pvalue = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref value);
                ref FixedArray2<double> p = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref rt);
                p.I0 = MathINumber.SignFloat(pvalue.I0);
                p.I1 = MathINumber.SignFloat(pvalue.I1);
                return rt;
            }

#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.YSignFloat(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YSignFloat_Bit(Vector128<float> value) {
                Vector128<int> signVal = YSign(value);
                Vector128<float> nanMask = YIsNaN(value).AsSingle();
                Vector128<float> rt = ConvertToSingle(signVal);
                rt = ConditionalSelect(nanMask, value, rt);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSignFloat(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YSignFloat_Bit(Vector128<double> value) {
                return YSignFloat_Compare(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.YSignFloat(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YSignFloat_Compare(Vector128<double> value) {
                Vector128<double> negativeOne = Vector128.Create(-1.0);
                Vector128<double> zero = Vector128<double>.Zero;
                Vector128<double> one = Vector128.Create(1.0);
                Vector128<double> rt = Vector128.BitwiseAnd(Vector128.LessThan(value, zero), negativeOne);
                Vector128<double> nanMask = YIsNaN(value).AsDouble();
                rt = Vector128.BitwiseOr(rt, Vector128.BitwiseAnd(Vector128.GreaterThan(value, zero), one)); // rt = ConvertToDouble(YSign(value));
                rt = Vector128.BitwiseOr(rt, Vector128.BitwiseAnd(nanMask, value)); // ConditionalSelect(nanMask, value, rt);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YSignFloat(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YSignFloat_Convert(Vector128<double> value) {
                Vector128<long> signVal = YSign(value);
                Vector128<double> nanMask = YIsNaN(value).AsDouble();
                Vector128<double> rt = ConvertToDouble_Range52(signVal);
                rt = Vector128.BitwiseOr(rt, Vector128.BitwiseAnd(nanMask, value)); // ConditionalSelect(nanMask, value, rt);
                return rt;
            }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
