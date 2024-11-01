﻿#define Sqrt_Float_Used
#if NET7_0_OR_GREATER
#define VECTOR_HAS_METHOD
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Collections;
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl.AVector128 {

    partial class WVectorTraits128Base {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.Abs_AcceleratedTypes"/>
            public static TypeCodeFlags Abs_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Abs(Vector128<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Abs(value);
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Abs(Vector128<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Abs(value);
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Abs(Vector128<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Abs(value);
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Abs(Vector128<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Abs(value);
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Abs(Vector128<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Abs(value);
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Abs(Vector128<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Abs(value);
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Abs_Basic(Vector128<float> value) {
                Vector128<float> rt = value;
                ref float p = ref Unsafe.As<Vector128<float>, float>(ref rt);
                p = Math.Abs(p);
                Unsafe.Add(ref p, 1) = Math.Abs(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = Math.Abs(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = Math.Abs(Unsafe.Add(ref p, 3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Abs_Basic(Vector128<double> value) {
                Vector128<double> rt = value;
                ref double p = ref Unsafe.As<Vector128<double>, double>(ref rt);
                p = Math.Abs(p);
                Unsafe.Add(ref p, 1) = Math.Abs(Unsafe.Add(ref p, 1));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Abs_Basic(Vector128<sbyte> value) {
                Vector128<sbyte> rt = value;
                ref sbyte p = ref Unsafe.As<Vector128<sbyte>, sbyte>(ref rt);
                p = BitMath.Abs(p);
                Unsafe.Add(ref p, 1) = BitMath.Abs(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = BitMath.Abs(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = BitMath.Abs(Unsafe.Add(ref p, 3));
                Unsafe.Add(ref p, 4) = BitMath.Abs(Unsafe.Add(ref p, 4));
                Unsafe.Add(ref p, 5) = BitMath.Abs(Unsafe.Add(ref p, 5));
                Unsafe.Add(ref p, 6) = BitMath.Abs(Unsafe.Add(ref p, 6));
                Unsafe.Add(ref p, 7) = BitMath.Abs(Unsafe.Add(ref p, 7));
                Unsafe.Add(ref p, 8) = BitMath.Abs(Unsafe.Add(ref p, 8));
                Unsafe.Add(ref p, 9) = BitMath.Abs(Unsafe.Add(ref p, 9));
                Unsafe.Add(ref p, 10) = BitMath.Abs(Unsafe.Add(ref p, 10));
                Unsafe.Add(ref p, 11) = BitMath.Abs(Unsafe.Add(ref p, 11));
                Unsafe.Add(ref p, 12) = BitMath.Abs(Unsafe.Add(ref p, 12));
                Unsafe.Add(ref p, 13) = BitMath.Abs(Unsafe.Add(ref p, 13));
                Unsafe.Add(ref p, 14) = BitMath.Abs(Unsafe.Add(ref p, 14));
                Unsafe.Add(ref p, 15) = BitMath.Abs(Unsafe.Add(ref p, 15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Abs_Basic(Vector128<short> value) {
                Vector128<short> rt = value;
                ref short p = ref Unsafe.As<Vector128<short>, short>(ref rt);
                p = BitMath.Abs(p);
                Unsafe.Add(ref p, 1) = BitMath.Abs(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = BitMath.Abs(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = BitMath.Abs(Unsafe.Add(ref p, 3));
                Unsafe.Add(ref p, 4) = BitMath.Abs(Unsafe.Add(ref p, 4));
                Unsafe.Add(ref p, 5) = BitMath.Abs(Unsafe.Add(ref p, 5));
                Unsafe.Add(ref p, 6) = BitMath.Abs(Unsafe.Add(ref p, 6));
                Unsafe.Add(ref p, 7) = BitMath.Abs(Unsafe.Add(ref p, 7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Abs_Basic(Vector128<int> value) {
                Vector128<int> rt = value;
                ref int p = ref Unsafe.As<Vector128<int>, int>(ref rt);
                p = BitMath.Abs(p);
                Unsafe.Add(ref p, 1) = BitMath.Abs(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = BitMath.Abs(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = BitMath.Abs(Unsafe.Add(ref p, 3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Abs_Basic(Vector128<long> value) {
                Vector128<long> rt = value;
                ref long p = ref Unsafe.As<Vector128<long>, long>(ref rt);
                p = BitMath.Abs(p);
                Unsafe.Add(ref p, 1) = BitMath.Abs(Unsafe.Add(ref p, 1));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Add_AcceleratedTypes"/>
            public static TypeCodeFlags Add_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Add(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Add(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Add(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Add(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Add(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Add(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Add(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Add(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Add(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Add(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Add_Basic(Vector128<float> left, Vector128<float> right) {
                Unsafe.SkipInit(out Vector128<float> rt);
                ref float prt = ref Unsafe.As<Vector128<float>, float>(ref rt);
                ref float pleft = ref Unsafe.As<Vector128<float>, float>(ref left);
                ref float pright = ref Unsafe.As<Vector128<float>, float>(ref right);
                prt = pleft + pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) + Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) + Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) + Unsafe.Add(ref pright, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Add_Basic(Vector128<double> left, Vector128<double> right) {
                Unsafe.SkipInit(out Vector128<double> rt);
                ref double prt = ref Unsafe.As<Vector128<double>, double>(ref rt);
                ref double pleft = ref Unsafe.As<Vector128<double>, double>(ref left);
                ref double pright = ref Unsafe.As<Vector128<double>, double>(ref right);
                prt = pleft + pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) + Unsafe.Add(ref pright, 1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Add_Basic(Vector128<sbyte> left, Vector128<sbyte> right) {
                Unsafe.SkipInit(out Vector128<sbyte> rt);
                ref sbyte prt = ref Unsafe.As<Vector128<sbyte>, sbyte>(ref rt);
                ref sbyte pleft = ref Unsafe.As<Vector128<sbyte>, sbyte>(ref left);
                ref sbyte pright = ref Unsafe.As<Vector128<sbyte>, sbyte>(ref right);
                prt = (sbyte)(pleft + pright);
                Unsafe.Add(ref prt, 1) = (sbyte)(Unsafe.Add(ref pleft, 1) + Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (sbyte)(Unsafe.Add(ref pleft, 2) + Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (sbyte)(Unsafe.Add(ref pleft, 3) + Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (sbyte)(Unsafe.Add(ref pleft, 4) + Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (sbyte)(Unsafe.Add(ref pleft, 5) + Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (sbyte)(Unsafe.Add(ref pleft, 6) + Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (sbyte)(Unsafe.Add(ref pleft, 7) + Unsafe.Add(ref pright, 7));
                Unsafe.Add(ref prt, 8) = (sbyte)(Unsafe.Add(ref pleft, 8) + Unsafe.Add(ref pright, 8));
                Unsafe.Add(ref prt, 9) = (sbyte)(Unsafe.Add(ref pleft, 9) + Unsafe.Add(ref pright, 9));
                Unsafe.Add(ref prt, 10) = (sbyte)(Unsafe.Add(ref pleft, 10) + Unsafe.Add(ref pright, 10));
                Unsafe.Add(ref prt, 11) = (sbyte)(Unsafe.Add(ref pleft, 11) + Unsafe.Add(ref pright, 11));
                Unsafe.Add(ref prt, 12) = (sbyte)(Unsafe.Add(ref pleft, 12) + Unsafe.Add(ref pright, 12));
                Unsafe.Add(ref prt, 13) = (sbyte)(Unsafe.Add(ref pleft, 13) + Unsafe.Add(ref pright, 13));
                Unsafe.Add(ref prt, 14) = (sbyte)(Unsafe.Add(ref pleft, 14) + Unsafe.Add(ref pright, 14));
                Unsafe.Add(ref prt, 15) = (sbyte)(Unsafe.Add(ref pleft, 15) + Unsafe.Add(ref pright, 15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Add_Basic(Vector128<byte> left, Vector128<byte> right) {
                Unsafe.SkipInit(out Vector128<byte> rt);
                ref byte prt = ref Unsafe.As<Vector128<byte>, byte>(ref rt);
                ref byte pleft = ref Unsafe.As<Vector128<byte>, byte>(ref left);
                ref byte pright = ref Unsafe.As<Vector128<byte>, byte>(ref right);
                prt = (byte)(pleft + pright);
                Unsafe.Add(ref prt, 1) = (byte)(Unsafe.Add(ref pleft, 1) + Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (byte)(Unsafe.Add(ref pleft, 2) + Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (byte)(Unsafe.Add(ref pleft, 3) + Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (byte)(Unsafe.Add(ref pleft, 4) + Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (byte)(Unsafe.Add(ref pleft, 5) + Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (byte)(Unsafe.Add(ref pleft, 6) + Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (byte)(Unsafe.Add(ref pleft, 7) + Unsafe.Add(ref pright, 7));
                Unsafe.Add(ref prt, 8) = (byte)(Unsafe.Add(ref pleft, 8) + Unsafe.Add(ref pright, 8));
                Unsafe.Add(ref prt, 9) = (byte)(Unsafe.Add(ref pleft, 9) + Unsafe.Add(ref pright, 9));
                Unsafe.Add(ref prt, 10) = (byte)(Unsafe.Add(ref pleft, 10) + Unsafe.Add(ref pright, 10));
                Unsafe.Add(ref prt, 11) = (byte)(Unsafe.Add(ref pleft, 11) + Unsafe.Add(ref pright, 11));
                Unsafe.Add(ref prt, 12) = (byte)(Unsafe.Add(ref pleft, 12) + Unsafe.Add(ref pright, 12));
                Unsafe.Add(ref prt, 13) = (byte)(Unsafe.Add(ref pleft, 13) + Unsafe.Add(ref pright, 13));
                Unsafe.Add(ref prt, 14) = (byte)(Unsafe.Add(ref pleft, 14) + Unsafe.Add(ref pright, 14));
                Unsafe.Add(ref prt, 15) = (byte)(Unsafe.Add(ref pleft, 15) + Unsafe.Add(ref pright, 15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Add_Basic(Vector128<short> left, Vector128<short> right) {
                Unsafe.SkipInit(out Vector128<short> rt);
                ref short prt = ref Unsafe.As<Vector128<short>, short>(ref rt);
                ref short pleft = ref Unsafe.As<Vector128<short>, short>(ref left);
                ref short pright = ref Unsafe.As<Vector128<short>, short>(ref right);
                prt = (short)(pleft + pright);
                Unsafe.Add(ref prt, 1) = (short)(Unsafe.Add(ref pleft, 1) + Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (short)(Unsafe.Add(ref pleft, 2) + Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (short)(Unsafe.Add(ref pleft, 3) + Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (short)(Unsafe.Add(ref pleft, 4) + Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (short)(Unsafe.Add(ref pleft, 5) + Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (short)(Unsafe.Add(ref pleft, 6) + Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (short)(Unsafe.Add(ref pleft, 7) + Unsafe.Add(ref pright, 7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Add_Basic(Vector128<ushort> left, Vector128<ushort> right) {
                Unsafe.SkipInit(out Vector128<ushort> rt);
                ref ushort prt = ref Unsafe.As<Vector128<ushort>, ushort>(ref rt);
                ref ushort pleft = ref Unsafe.As<Vector128<ushort>, ushort>(ref left);
                ref ushort pright = ref Unsafe.As<Vector128<ushort>, ushort>(ref right);
                prt = (ushort)(pleft + pright);
                Unsafe.Add(ref prt, 1) = (ushort)(Unsafe.Add(ref pleft, 1) + Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (ushort)(Unsafe.Add(ref pleft, 2) + Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (ushort)(Unsafe.Add(ref pleft, 3) + Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (ushort)(Unsafe.Add(ref pleft, 4) + Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (ushort)(Unsafe.Add(ref pleft, 5) + Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (ushort)(Unsafe.Add(ref pleft, 6) + Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (ushort)(Unsafe.Add(ref pleft, 7) + Unsafe.Add(ref pright, 7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Add_Basic(Vector128<int> left, Vector128<int> right) {
                Unsafe.SkipInit(out Vector128<int> rt);
                ref int prt = ref Unsafe.As<Vector128<int>, int>(ref rt);
                ref int pleft = ref Unsafe.As<Vector128<int>, int>(ref left);
                ref int pright = ref Unsafe.As<Vector128<int>, int>(ref right);
                prt = pleft + pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) + Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) + Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) + Unsafe.Add(ref pright, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Add_Basic(Vector128<uint> left, Vector128<uint> right) {
                Unsafe.SkipInit(out Vector128<uint> rt);
                ref uint prt = ref Unsafe.As<Vector128<uint>, uint>(ref rt);
                ref uint pleft = ref Unsafe.As<Vector128<uint>, uint>(ref left);
                ref uint pright = ref Unsafe.As<Vector128<uint>, uint>(ref right);
                prt = pleft + pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) + Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) + Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) + Unsafe.Add(ref pright, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Add_Basic(Vector128<long> left, Vector128<long> right) {
                Unsafe.SkipInit(out Vector128<long> rt);
                ref long prt = ref Unsafe.As<Vector128<long>, long>(ref rt);
                ref long pleft = ref Unsafe.As<Vector128<long>, long>(ref left);
                ref long pright = ref Unsafe.As<Vector128<long>, long>(ref right);
                prt = pleft + pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) + Unsafe.Add(ref pright, 1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Add_Basic(Vector128<ulong> left, Vector128<ulong> right) {
                Unsafe.SkipInit(out Vector128<ulong> rt);
                ref ulong prt = ref Unsafe.As<Vector128<ulong>, ulong>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector128<ulong>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector128<ulong>, ulong>(ref right);
                prt = pleft + pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) + Unsafe.Add(ref pright, 1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.AndNot_AcceleratedTypes"/>
            public static TypeCodeFlags AndNot_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.AndNot{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> AndNot<T>(Vector128<T> left, Vector128<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.AndNot(left, right);
#else
                return AndNot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.AndNot{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> AndNot_Basic<T>(Vector128<T> left, Vector128<T> right) where T : struct {
                Unsafe.SkipInit(out Vector128<T> rt);
                ref ulong prt = ref Unsafe.As<Vector128<T>, ulong>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector128<T>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector128<T>, ulong>(ref right);
                prt = pleft & ~pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) & ~Unsafe.Add(ref pright, 1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.BitwiseAnd_AcceleratedTypes"/>
            public static TypeCodeFlags BitwiseAnd_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.BitwiseAnd{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> BitwiseAnd<T>(Vector128<T> left, Vector128<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.BitwiseAnd(left, right);
#else
                return BitwiseAnd_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.BitwiseAnd{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> BitwiseAnd_Basic<T>(Vector128<T> left, Vector128<T> right) where T : struct {
                Unsafe.SkipInit(out Vector128<T> rt);
                ref ulong prt = ref Unsafe.As<Vector128<T>, ulong>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector128<T>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector128<T>, ulong>(ref right);
                prt = pleft & pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) & Unsafe.Add(ref pright, 1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.BitwiseOr_AcceleratedTypes"/>
            public static TypeCodeFlags BitwiseOr_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.BitwiseOr{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> BitwiseOr<T>(Vector128<T> left, Vector128<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.BitwiseOr(left, right);
#else
                return BitwiseOr_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.BitwiseOr{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> BitwiseOr_Basic<T>(Vector128<T> left, Vector128<T> right) where T : struct {
                Unsafe.SkipInit(out Vector128<T> rt);
                ref ulong prt = ref Unsafe.As<Vector128<T>, ulong>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector128<T>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector128<T>, ulong>(ref right);
                prt = pleft | pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) | Unsafe.Add(ref pright, 1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect_AcceleratedTypes"/>
            public static TypeCodeFlags ConditionalSelect_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect{T}(Vector128{T}, Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> ConditionalSelect<T>(Vector128<T> condition, Vector128<T> left, Vector128<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.ConditionalSelect(condition, left, right);
#else
                return ConditionalSelect_Basic(condition, left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            ///// <inheritdoc cref="IWVectorTraits128.ConditionalSelect(Vector128{int}, Vector128{float}, Vector128{float})"/>
            //[MethodImpl(MethodImplOptions.AggressiveInlining)]
            //public static Vector128<float> ConditionalSelect(Vector128<int> condition, Vector128<float> left, Vector128<float> right) {
            //    return ConditionalSelect<float>(condition.AsSingle(), left, right);
            //}

            ///// <inheritdoc cref="IWVectorTraits128.ConditionalSelect(Vector128{long}, Vector128{double}, Vector128{double})"/>
            //[MethodImpl(MethodImplOptions.AggressiveInlining)]
            //public static Vector128<double> ConditionalSelect(Vector128<long> condition, Vector128<double> left, Vector128<double> right) {
            //    return ConditionalSelect<double>(condition.AsDouble(), left, right);
            //}

            /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect{T}(Vector128{T}, Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> ConditionalSelect_Basic<T>(Vector128<T> condition, Vector128<T> left, Vector128<T> right) where T : struct {
                Unsafe.SkipInit(out Vector128<T> rt);
                ref ulong pcondition = ref Unsafe.As<Vector128<T>, ulong>(ref condition);
                ref ulong pleft = ref Unsafe.As<Vector128<T>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector128<T>, ulong>(ref right);
                ref ulong prt = ref Unsafe.As<Vector128<T>, ulong>(ref rt);
                // result = (left & condition) | (right & ~condition);
                prt = (pleft & pcondition) | (pright & ~pcondition);
                Unsafe.Add(ref prt, 1) = (Unsafe.Add(ref pleft, 1) & Unsafe.Add(ref pcondition, 1)) | (Unsafe.Add(ref pright, 1) & ~Unsafe.Add(ref pcondition, 1));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Divide_AcceleratedTypes"/>
            public static TypeCodeFlags Divide_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        // rt |= TypeCodeFlags.Single | TypeCodeFlags.Double; // Arm 32bit no hardware accelerated.
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Divide(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Divide(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Divide(left, right);
#else
                return Divide_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Divide(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Divide(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Divide(left, right);
#else
                return Divide_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Divide(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Divide_Basic(Vector128<float> left, Vector128<float> right) {
                Unsafe.SkipInit(out Vector128<float> rt);
                ref float prt = ref Unsafe.As<Vector128<float>, float>(ref rt);
                ref float pleft = ref Unsafe.As<Vector128<float>, float>(ref left);
                ref float pright = ref Unsafe.As<Vector128<float>, float>(ref right);
                prt = pleft / pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) / Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) / Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) / Unsafe.Add(ref pright, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Divide(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Divide_Basic(Vector128<double> left, Vector128<double> right) {
                Unsafe.SkipInit(out Vector128<double> rt);
                ref double prt = ref Unsafe.As<Vector128<double>, double>(ref rt);
                ref double pleft = ref Unsafe.As<Vector128<double>, double>(ref left);
                ref double pright = ref Unsafe.As<Vector128<double>, double>(ref right);
                prt = pleft / pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) / Unsafe.Add(ref pright, 1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Dot_AcceleratedTypes"/>
            public static TypeCodeFlags Dot_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Dot(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Dot(left, right);
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Dot(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Dot(left, right);
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Dot(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Dot(left, right);
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Dot(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Dot(left, right);
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Dot(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Dot(left, right);
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Dot(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return (ushort)Vector128.Dot(left.AsInt16(), right.AsInt16());
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Dot(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Dot(left, right);
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Dot(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return (uint)Vector128.Dot(left.AsInt32(), right.AsInt32());
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Dot(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Dot(left, right);
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Dot(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Dot(left, right);
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Dot_Basic(Vector128<float> left, Vector128<float> right) {
                ref FixedArray4<float> pleft = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref left);
                ref FixedArray4<float> pright = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref right);
                float rt = pleft.I0 * pright.I0;
                rt += pleft.I1 * pright.I1;
                rt += pleft.I2 * pright.I2;
                rt += pleft.I3 * pright.I3;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Dot_Basic(Vector128<double> left, Vector128<double> right) {
                ref FixedArray2<double> pleft = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref left);
                ref FixedArray2<double> pright = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref right);
                double rt = pleft.I0 * pright.I0;
                rt += pleft.I1 * pright.I1;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Dot_Basic(Vector128<sbyte> left, Vector128<sbyte> right) {
                ref FixedArray16<sbyte> pleft = ref Unsafe.As<Vector128<sbyte>, FixedArray16<sbyte>>(ref left);
                ref FixedArray16<sbyte> pright = ref Unsafe.As<Vector128<sbyte>, FixedArray16<sbyte>>(ref right);
                int rt = pleft.I0 * pright.I0;
                rt += pleft.I1 * pright.I1;
                rt += pleft.I2 * pright.I2;
                rt += pleft.I3 * pright.I3;
                rt += pleft.I4 * pright.I4;
                rt += pleft.I5 * pright.I5;
                rt += pleft.I6 * pright.I6;
                rt += pleft.I7 * pright.I7;
                rt += pleft.I8 * pright.I8;
                rt += pleft.I9 * pright.I9;
                rt += pleft.I10 * pright.I10;
                rt += pleft.I11 * pright.I11;
                rt += pleft.I12 * pright.I12;
                rt += pleft.I13 * pright.I13;
                rt += pleft.I14 * pright.I14;
                rt += pleft.I15 * pright.I15;
                return (sbyte)rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Dot_Basic(Vector128<byte> left, Vector128<byte> right) {
                ref FixedArray16<byte> pleft = ref Unsafe.As<Vector128<byte>, FixedArray16<byte>>(ref left);
                ref FixedArray16<byte> pright = ref Unsafe.As<Vector128<byte>, FixedArray16<byte>>(ref right);
                int rt = pleft.I0 * pright.I0;
                rt += pleft.I1 * pright.I1;
                rt += pleft.I2 * pright.I2;
                rt += pleft.I3 * pright.I3;
                rt += pleft.I4 * pright.I4;
                rt += pleft.I5 * pright.I5;
                rt += pleft.I6 * pright.I6;
                rt += pleft.I7 * pright.I7;
                rt += pleft.I8 * pright.I8;
                rt += pleft.I9 * pright.I9;
                rt += pleft.I10 * pright.I10;
                rt += pleft.I11 * pright.I11;
                rt += pleft.I12 * pright.I12;
                rt += pleft.I13 * pright.I13;
                rt += pleft.I14 * pright.I14;
                rt += pleft.I15 * pright.I15;
                return (byte)rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Dot_Basic(Vector128<short> left, Vector128<short> right) {
                ref FixedArray8<short> pleft = ref Unsafe.As<Vector128<short>, FixedArray8<short>>(ref left);
                ref FixedArray8<short> pright = ref Unsafe.As<Vector128<short>, FixedArray8<short>>(ref right);
                int rt = pleft.I0 * pright.I0;
                rt += pleft.I1 * pright.I1;
                rt += pleft.I2 * pright.I2;
                rt += pleft.I3 * pright.I3;
                rt += pleft.I4 * pright.I4;
                rt += pleft.I5 * pright.I5;
                rt += pleft.I6 * pright.I6;
                rt += pleft.I7 * pright.I7;
                return (short)rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Dot_Basic(Vector128<ushort> left, Vector128<ushort> right) {
                ref FixedArray8<ushort> pleft = ref Unsafe.As<Vector128<ushort>, FixedArray8<ushort>>(ref left);
                ref FixedArray8<ushort> pright = ref Unsafe.As<Vector128<ushort>, FixedArray8<ushort>>(ref right);
                int rt = pleft.I0 * pright.I0;
                rt += pleft.I1 * pright.I1;
                rt += pleft.I2 * pright.I2;
                rt += pleft.I3 * pright.I3;
                rt += pleft.I4 * pright.I4;
                rt += pleft.I5 * pright.I5;
                rt += pleft.I6 * pright.I6;
                rt += pleft.I7 * pright.I7;
                return (ushort)rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Dot_Basic(Vector128<int> left, Vector128<int> right) {
                ref FixedArray4<int> pleft = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref left);
                ref FixedArray4<int> pright = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref right);
                int rt = pleft.I0 * pright.I0;
                rt += pleft.I1 * pright.I1;
                rt += pleft.I2 * pright.I2;
                rt += pleft.I3 * pright.I3;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Dot_Basic(Vector128<uint> left, Vector128<uint> right) {
                ref FixedArray4<uint> pleft = ref Unsafe.As<Vector128<uint>, FixedArray4<uint>>(ref left);
                ref FixedArray4<uint> pright = ref Unsafe.As<Vector128<uint>, FixedArray4<uint>>(ref right);
                uint rt = pleft.I0 * pright.I0;
                rt += pleft.I1 * pright.I1;
                rt += pleft.I2 * pright.I2;
                rt += pleft.I3 * pright.I3;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Dot_Basic(Vector128<long> left, Vector128<long> right) {
                ref FixedArray2<long> pleft = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref left);
                ref FixedArray2<long> pright = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref right);
                long rt = pleft.I0 * pright.I0;
                rt += pleft.I1 * pright.I1;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Dot_Basic(Vector128<ulong> left, Vector128<ulong> right) {
                ref FixedArray2<ulong> pleft = ref Unsafe.As<Vector128<ulong>, FixedArray2<ulong>>(ref left);
                ref FixedArray2<ulong> pright = ref Unsafe.As<Vector128<ulong>, FixedArray2<ulong>>(ref right);
                ulong rt = pleft.I0 * pright.I0;
                rt += pleft.I1 * pright.I1;
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Equals_AcceleratedTypes"/>
            public static TypeCodeFlags Equals_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Equals(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Equals(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Equals(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Equals(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Equals(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Equals(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Equals(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Equals(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Equals(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Equals(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Equals_Basic(Vector128<float> left, Vector128<float> right) {
                Unsafe.SkipInit(out Vector128<float> rt);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<float>, FixedArray4<int>>(ref rt);
                ref FixedArray4<float> pleft = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref left);
                ref FixedArray4<float> pright = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 == pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 == pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 == pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 == pright.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Equals_Basic(Vector128<double> left, Vector128<double> right) {
                Unsafe.SkipInit(out Vector128<double> rt);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<double>, FixedArray2<long>>(ref rt);
                ref FixedArray2<double> pleft = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref left);
                ref FixedArray2<double> pright = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 == pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 == pright.I1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Equals_Basic(Vector128<sbyte> left, Vector128<sbyte> right) {
                Unsafe.SkipInit(out Vector128<sbyte> rt);
                ref FixedArray16<sbyte> p = ref Unsafe.As<Vector128<sbyte>, FixedArray16<sbyte>>(ref rt);
                ref FixedArray16<sbyte> pleft = ref Unsafe.As<Vector128<sbyte>, FixedArray16<sbyte>>(ref left);
                ref FixedArray16<sbyte> pright = ref Unsafe.As<Vector128<sbyte>, FixedArray16<sbyte>>(ref right);
                p.I0 = (sbyte)BitMath.ToInt32Mask(pleft.I0 == pright.I0);
                p.I1 = (sbyte)BitMath.ToInt32Mask(pleft.I1 == pright.I1);
                p.I2 = (sbyte)BitMath.ToInt32Mask(pleft.I2 == pright.I2);
                p.I3 = (sbyte)BitMath.ToInt32Mask(pleft.I3 == pright.I3);
                p.I4 = (sbyte)BitMath.ToInt32Mask(pleft.I4 == pright.I4);
                p.I5 = (sbyte)BitMath.ToInt32Mask(pleft.I5 == pright.I5);
                p.I6 = (sbyte)BitMath.ToInt32Mask(pleft.I6 == pright.I6);
                p.I7 = (sbyte)BitMath.ToInt32Mask(pleft.I7 == pright.I7);
                p.I8 = (sbyte)BitMath.ToInt32Mask(pleft.I8 == pright.I8);
                p.I9 = (sbyte)BitMath.ToInt32Mask(pleft.I9 == pright.I9);
                p.I10 = (sbyte)BitMath.ToInt32Mask(pleft.I10 == pright.I10);
                p.I11 = (sbyte)BitMath.ToInt32Mask(pleft.I11 == pright.I11);
                p.I12 = (sbyte)BitMath.ToInt32Mask(pleft.I12 == pright.I12);
                p.I13 = (sbyte)BitMath.ToInt32Mask(pleft.I13 == pright.I13);
                p.I14 = (sbyte)BitMath.ToInt32Mask(pleft.I14 == pright.I14);
                p.I15 = (sbyte)BitMath.ToInt32Mask(pleft.I15 == pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Equals_Basic(Vector128<byte> left, Vector128<byte> right) {
                Unsafe.SkipInit(out Vector128<byte> rt);
                ref FixedArray16<sbyte> p = ref Unsafe.As<Vector128<byte>, FixedArray16<sbyte>>(ref rt);
                ref FixedArray16<byte> pleft = ref Unsafe.As<Vector128<byte>, FixedArray16<byte>>(ref left);
                ref FixedArray16<byte> pright = ref Unsafe.As<Vector128<byte>, FixedArray16<byte>>(ref right);
                p.I0 = (sbyte)BitMath.ToInt32Mask(pleft.I0 == pright.I0);
                p.I1 = (sbyte)BitMath.ToInt32Mask(pleft.I1 == pright.I1);
                p.I2 = (sbyte)BitMath.ToInt32Mask(pleft.I2 == pright.I2);
                p.I3 = (sbyte)BitMath.ToInt32Mask(pleft.I3 == pright.I3);
                p.I4 = (sbyte)BitMath.ToInt32Mask(pleft.I4 == pright.I4);
                p.I5 = (sbyte)BitMath.ToInt32Mask(pleft.I5 == pright.I5);
                p.I6 = (sbyte)BitMath.ToInt32Mask(pleft.I6 == pright.I6);
                p.I7 = (sbyte)BitMath.ToInt32Mask(pleft.I7 == pright.I7);
                p.I8 = (sbyte)BitMath.ToInt32Mask(pleft.I8 == pright.I8);
                p.I9 = (sbyte)BitMath.ToInt32Mask(pleft.I9 == pright.I9);
                p.I10 = (sbyte)BitMath.ToInt32Mask(pleft.I10 == pright.I10);
                p.I11 = (sbyte)BitMath.ToInt32Mask(pleft.I11 == pright.I11);
                p.I12 = (sbyte)BitMath.ToInt32Mask(pleft.I12 == pright.I12);
                p.I13 = (sbyte)BitMath.ToInt32Mask(pleft.I13 == pright.I13);
                p.I14 = (sbyte)BitMath.ToInt32Mask(pleft.I14 == pright.I14);
                p.I15 = (sbyte)BitMath.ToInt32Mask(pleft.I15 == pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Equals_Basic(Vector128<short> left, Vector128<short> right) {
                Unsafe.SkipInit(out Vector128<short> rt);
                ref FixedArray8<short> p = ref Unsafe.As<Vector128<short>, FixedArray8<short>>(ref rt);
                ref FixedArray8<short> pleft = ref Unsafe.As<Vector128<short>, FixedArray8<short>>(ref left);
                ref FixedArray8<short> pright = ref Unsafe.As<Vector128<short>, FixedArray8<short>>(ref right);
                p.I0 = (short)BitMath.ToInt32Mask(pleft.I0 == pright.I0);
                p.I1 = (short)BitMath.ToInt32Mask(pleft.I1 == pright.I1);
                p.I2 = (short)BitMath.ToInt32Mask(pleft.I2 == pright.I2);
                p.I3 = (short)BitMath.ToInt32Mask(pleft.I3 == pright.I3);
                p.I4 = (short)BitMath.ToInt32Mask(pleft.I4 == pright.I4);
                p.I5 = (short)BitMath.ToInt32Mask(pleft.I5 == pright.I5);
                p.I6 = (short)BitMath.ToInt32Mask(pleft.I6 == pright.I6);
                p.I7 = (short)BitMath.ToInt32Mask(pleft.I7 == pright.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Equals_Basic(Vector128<ushort> left, Vector128<ushort> right) {
                Unsafe.SkipInit(out Vector128<ushort> rt);
                ref FixedArray8<short> p = ref Unsafe.As<Vector128<ushort>, FixedArray8<short>>(ref rt);
                ref FixedArray8<ushort> pleft = ref Unsafe.As<Vector128<ushort>, FixedArray8<ushort>>(ref left);
                ref FixedArray8<ushort> pright = ref Unsafe.As<Vector128<ushort>, FixedArray8<ushort>>(ref right);
                p.I0 = (short)BitMath.ToInt32Mask(pleft.I0 == pright.I0);
                p.I1 = (short)BitMath.ToInt32Mask(pleft.I1 == pright.I1);
                p.I2 = (short)BitMath.ToInt32Mask(pleft.I2 == pright.I2);
                p.I3 = (short)BitMath.ToInt32Mask(pleft.I3 == pright.I3);
                p.I4 = (short)BitMath.ToInt32Mask(pleft.I4 == pright.I4);
                p.I5 = (short)BitMath.ToInt32Mask(pleft.I5 == pright.I5);
                p.I6 = (short)BitMath.ToInt32Mask(pleft.I6 == pright.I6);
                p.I7 = (short)BitMath.ToInt32Mask(pleft.I7 == pright.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Equals_Basic(Vector128<int> left, Vector128<int> right) {
                Unsafe.SkipInit(out Vector128<int> rt);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                ref FixedArray4<int> pleft = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref left);
                ref FixedArray4<int> pright = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 == pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 == pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 == pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 == pright.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Equals_Basic(Vector128<uint> left, Vector128<uint> right) {
                Unsafe.SkipInit(out Vector128<uint> rt);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<uint>, FixedArray4<int>>(ref rt);
                ref FixedArray4<uint> pleft = ref Unsafe.As<Vector128<uint>, FixedArray4<uint>>(ref left);
                ref FixedArray4<uint> pright = ref Unsafe.As<Vector128<uint>, FixedArray4<uint>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 == pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 == pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 == pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 == pright.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Equals_Basic(Vector128<long> left, Vector128<long> right) {
                Unsafe.SkipInit(out Vector128<long> rt);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                ref FixedArray2<long> pleft = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref left);
                ref FixedArray2<long> pright = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 == pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 == pright.I1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Equals_Basic(Vector128<ulong> left, Vector128<ulong> right) {
                Unsafe.SkipInit(out Vector128<ulong> rt);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<ulong>, FixedArray2<long>>(ref rt);
                ref FixedArray2<ulong> pleft = ref Unsafe.As<Vector128<ulong>, FixedArray2<ulong>>(ref left);
                ref FixedArray2<ulong> pright = ref Unsafe.As<Vector128<ulong>, FixedArray2<ulong>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 == pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 == pright.I1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.EqualsAll_AcceleratedTypes"/>
            public static TypeCodeFlags EqualsAll_AcceleratedTypes {
                get {
                    return Equals_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector128<float> left, Vector128<float> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector128<double> left, Vector128<double> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector128<sbyte> left, Vector128<sbyte> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector128<byte> left, Vector128<byte> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector128<short> left, Vector128<short> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector128<ushort> left, Vector128<ushort> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector128<int> left, Vector128<int> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector128<uint> left, Vector128<uint> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector128<long> left, Vector128<long> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector128<ulong> left, Vector128<ulong> right) {
                return YIsAllTrue(Equals(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.EqualsAny_AcceleratedTypes"/>
            public static TypeCodeFlags EqualsAny_AcceleratedTypes {
                get {
                    return Equals_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector128<float> left, Vector128<float> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector128<double> left, Vector128<double> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector128<sbyte> left, Vector128<sbyte> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector128<byte> left, Vector128<byte> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector128<short> left, Vector128<short> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector128<ushort> left, Vector128<ushort> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector128<int> left, Vector128<int> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector128<uint> left, Vector128<uint> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector128<long> left, Vector128<long> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector128<ulong> left, Vector128<ulong> right) {
                return YIsAnyTrue(Equals(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.GreaterThan_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThan_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> GreaterThan(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> GreaterThan(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> GreaterThan(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> GreaterThan(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> GreaterThan(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> GreaterThan(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> GreaterThan(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> GreaterThan(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> GreaterThan(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> GreaterThan(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> GreaterThan_Basic(Vector128<float> left, Vector128<float> right) {
                Unsafe.SkipInit(out Vector128<float> rt);
                ref int prt = ref Unsafe.As<Vector128<float>, int>(ref rt);
                ref float pleft = ref Unsafe.As<Vector128<float>, float>(ref left);
                ref float pright = ref Unsafe.As<Vector128<float>, float>(ref right);
                prt = BitMath.ToInt32Mask(pleft > pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) > Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) > Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) > Unsafe.Add(ref pright, 3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> GreaterThan_Basic(Vector128<double> left, Vector128<double> right) {
                Unsafe.SkipInit(out Vector128<double> rt);
                ref long prt = ref Unsafe.As<Vector128<double>, long>(ref rt);
                ref double pleft = ref Unsafe.As<Vector128<double>, double>(ref left);
                ref double pright = ref Unsafe.As<Vector128<double>, double>(ref right);
                prt = BitMath.ToInt32Mask(pleft > pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) > Unsafe.Add(ref pright, 1));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> GreaterThan_Basic(Vector128<sbyte> left, Vector128<sbyte> right) {
                Unsafe.SkipInit(out Vector128<sbyte> rt);
                ref sbyte prt = ref Unsafe.As<Vector128<sbyte>, sbyte>(ref rt);
                ref sbyte pleft = ref Unsafe.As<Vector128<sbyte>, sbyte>(ref left);
                ref sbyte pright = ref Unsafe.As<Vector128<sbyte>, sbyte>(ref right);
                prt = (sbyte)BitMath.ToInt32Mask(pleft > pright);
                Unsafe.Add(ref prt, 1) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) > Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) > Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) > Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 4) > Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 5) > Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 6) > Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 7) > Unsafe.Add(ref pright, 7));
                Unsafe.Add(ref prt, 8) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 8) > Unsafe.Add(ref pright, 8));
                Unsafe.Add(ref prt, 9) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 9) > Unsafe.Add(ref pright, 9));
                Unsafe.Add(ref prt, 10) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 10) > Unsafe.Add(ref pright, 10));
                Unsafe.Add(ref prt, 11) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 11) > Unsafe.Add(ref pright, 11));
                Unsafe.Add(ref prt, 12) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 12) > Unsafe.Add(ref pright, 12));
                Unsafe.Add(ref prt, 13) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 13) > Unsafe.Add(ref pright, 13));
                Unsafe.Add(ref prt, 14) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 14) > Unsafe.Add(ref pright, 14));
                Unsafe.Add(ref prt, 15) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 15) > Unsafe.Add(ref pright, 15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> GreaterThan_Basic(Vector128<byte> left, Vector128<byte> right) {
                Unsafe.SkipInit(out Vector128<byte> rt);
                ref sbyte prt = ref Unsafe.As<Vector128<byte>, sbyte>(ref rt);
                ref byte pleft = ref Unsafe.As<Vector128<byte>, byte>(ref left);
                ref byte pright = ref Unsafe.As<Vector128<byte>, byte>(ref right);
                prt = (sbyte)BitMath.ToInt32Mask(pleft > pright);
                Unsafe.Add(ref prt, 1) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) > Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) > Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) > Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 4) > Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 5) > Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 6) > Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 7) > Unsafe.Add(ref pright, 7));
                Unsafe.Add(ref prt, 8) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 8) > Unsafe.Add(ref pright, 8));
                Unsafe.Add(ref prt, 9) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 9) > Unsafe.Add(ref pright, 9));
                Unsafe.Add(ref prt, 10) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 10) > Unsafe.Add(ref pright, 10));
                Unsafe.Add(ref prt, 11) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 11) > Unsafe.Add(ref pright, 11));
                Unsafe.Add(ref prt, 12) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 12) > Unsafe.Add(ref pright, 12));
                Unsafe.Add(ref prt, 13) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 13) > Unsafe.Add(ref pright, 13));
                Unsafe.Add(ref prt, 14) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 14) > Unsafe.Add(ref pright, 14));
                Unsafe.Add(ref prt, 15) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 15) > Unsafe.Add(ref pright, 15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> GreaterThan_Basic(Vector128<short> left, Vector128<short> right) {
                Unsafe.SkipInit(out Vector128<short> rt);
                ref short prt = ref Unsafe.As<Vector128<short>, short>(ref rt);
                ref short pleft = ref Unsafe.As<Vector128<short>, short>(ref left);
                ref short pright = ref Unsafe.As<Vector128<short>, short>(ref right);
                prt = (short)BitMath.ToInt32Mask(pleft > pright);
                Unsafe.Add(ref prt, 1) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) > Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) > Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) > Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 4) > Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 5) > Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 6) > Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 7) > Unsafe.Add(ref pright, 7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> GreaterThan_Basic(Vector128<ushort> left, Vector128<ushort> right) {
                Unsafe.SkipInit(out Vector128<ushort> rt);
                ref short prt = ref Unsafe.As<Vector128<ushort>, short>(ref rt);
                ref ushort pleft = ref Unsafe.As<Vector128<ushort>, ushort>(ref left);
                ref ushort pright = ref Unsafe.As<Vector128<ushort>, ushort>(ref right);
                prt = (short)BitMath.ToInt32Mask(pleft > pright);
                Unsafe.Add(ref prt, 1) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) > Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) > Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) > Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 4) > Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 5) > Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 6) > Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 7) > Unsafe.Add(ref pright, 7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> GreaterThan_Basic(Vector128<int> left, Vector128<int> right) {
                Unsafe.SkipInit(out Vector128<int> rt);
                ref int prt = ref Unsafe.As<Vector128<int>, int>(ref rt);
                ref int pleft = ref Unsafe.As<Vector128<int>, int>(ref left);
                ref int pright = ref Unsafe.As<Vector128<int>, int>(ref right);
                prt = BitMath.ToInt32Mask(pleft > pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) > Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) > Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) > Unsafe.Add(ref pright, 3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> GreaterThan_Basic(Vector128<uint> left, Vector128<uint> right) {
                Unsafe.SkipInit(out Vector128<uint> rt);
                ref int prt = ref Unsafe.As<Vector128<uint>, int>(ref rt);
                ref uint pleft = ref Unsafe.As<Vector128<uint>, uint>(ref left);
                ref uint pright = ref Unsafe.As<Vector128<uint>, uint>(ref right);
                prt = BitMath.ToInt32Mask(pleft > pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) > Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) > Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) > Unsafe.Add(ref pright, 3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> GreaterThan_Basic(Vector128<long> left, Vector128<long> right) {
                Unsafe.SkipInit(out Vector128<long> rt);
                ref long prt = ref Unsafe.As<Vector128<long>, long>(ref rt);
                ref long pleft = ref Unsafe.As<Vector128<long>, long>(ref left);
                ref long pright = ref Unsafe.As<Vector128<long>, long>(ref right);
                prt = BitMath.ToInt32Mask(pleft > pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) > Unsafe.Add(ref pright, 1));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> GreaterThan_Basic(Vector128<ulong> left, Vector128<ulong> right) {
                Unsafe.SkipInit(out Vector128<ulong> rt);
                ref long prt = ref Unsafe.As<Vector128<ulong>, long>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector128<ulong>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector128<ulong>, ulong>(ref right);
                prt = BitMath.ToInt32Mask(pleft > pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) > Unsafe.Add(ref pright, 1));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanAll_AcceleratedTypes {
                get {
                    return GreaterThan_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector128<float> left, Vector128<float> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector128<double> left, Vector128<double> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector128<sbyte> left, Vector128<sbyte> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector128<byte> left, Vector128<byte> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector128<short> left, Vector128<short> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector128<ushort> left, Vector128<ushort> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector128<int> left, Vector128<int> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector128<uint> left, Vector128<uint> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector128<long> left, Vector128<long> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector128<ulong> left, Vector128<ulong> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanAny_AcceleratedTypes {
                get {
                    return GreaterThan_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector128<float> left, Vector128<float> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector128<double> left, Vector128<double> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector128<sbyte> left, Vector128<sbyte> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector128<byte> left, Vector128<byte> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector128<short> left, Vector128<short> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector128<ushort> left, Vector128<ushort> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector128<int> left, Vector128<int> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector128<uint> left, Vector128<uint> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector128<long> left, Vector128<long> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector128<ulong> left, Vector128<ulong> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanOrEqual_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> GreaterThanOrEqual(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> GreaterThanOrEqual(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> GreaterThanOrEqual(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> GreaterThanOrEqual(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> GreaterThanOrEqual(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> GreaterThanOrEqual(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> GreaterThanOrEqual(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> GreaterThanOrEqual(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> GreaterThanOrEqual(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> GreaterThanOrEqual(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> GreaterThanOrEqual_Basic(Vector128<float> left, Vector128<float> right) {
                Unsafe.SkipInit(out Vector128<float> rt);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<float>, FixedArray4<int>>(ref rt);
                ref FixedArray4<float> pleft = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref left);
                ref FixedArray4<float> pright = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 >= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 >= pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 >= pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 >= pright.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> GreaterThanOrEqual_Basic(Vector128<double> left, Vector128<double> right) {
                Unsafe.SkipInit(out Vector128<double> rt);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<double>, FixedArray2<long>>(ref rt);
                ref FixedArray2<double> pleft = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref left);
                ref FixedArray2<double> pright = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 >= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 >= pright.I1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> GreaterThanOrEqual_Basic(Vector128<sbyte> left, Vector128<sbyte> right) {
                Unsafe.SkipInit(out Vector128<sbyte> rt);
                ref FixedArray16<sbyte> p = ref Unsafe.As<Vector128<sbyte>, FixedArray16<sbyte>>(ref rt);
                ref FixedArray16<sbyte> pleft = ref Unsafe.As<Vector128<sbyte>, FixedArray16<sbyte>>(ref left);
                ref FixedArray16<sbyte> pright = ref Unsafe.As<Vector128<sbyte>, FixedArray16<sbyte>>(ref right);
                p.I0 = (sbyte)BitMath.ToInt32Mask(pleft.I0 >= pright.I0);
                p.I1 = (sbyte)BitMath.ToInt32Mask(pleft.I1 >= pright.I1);
                p.I2 = (sbyte)BitMath.ToInt32Mask(pleft.I2 >= pright.I2);
                p.I3 = (sbyte)BitMath.ToInt32Mask(pleft.I3 >= pright.I3);
                p.I4 = (sbyte)BitMath.ToInt32Mask(pleft.I4 >= pright.I4);
                p.I5 = (sbyte)BitMath.ToInt32Mask(pleft.I5 >= pright.I5);
                p.I6 = (sbyte)BitMath.ToInt32Mask(pleft.I6 >= pright.I6);
                p.I7 = (sbyte)BitMath.ToInt32Mask(pleft.I7 >= pright.I7);
                p.I8 = (sbyte)BitMath.ToInt32Mask(pleft.I8 >= pright.I8);
                p.I9 = (sbyte)BitMath.ToInt32Mask(pleft.I9 >= pright.I9);
                p.I10 = (sbyte)BitMath.ToInt32Mask(pleft.I10 >= pright.I10);
                p.I11 = (sbyte)BitMath.ToInt32Mask(pleft.I11 >= pright.I11);
                p.I12 = (sbyte)BitMath.ToInt32Mask(pleft.I12 >= pright.I12);
                p.I13 = (sbyte)BitMath.ToInt32Mask(pleft.I13 >= pright.I13);
                p.I14 = (sbyte)BitMath.ToInt32Mask(pleft.I14 >= pright.I14);
                p.I15 = (sbyte)BitMath.ToInt32Mask(pleft.I15 >= pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> GreaterThanOrEqual_Basic(Vector128<byte> left, Vector128<byte> right) {
                Unsafe.SkipInit(out Vector128<byte> rt);
                ref FixedArray16<sbyte> p = ref Unsafe.As<Vector128<byte>, FixedArray16<sbyte>>(ref rt);
                ref FixedArray16<byte> pleft = ref Unsafe.As<Vector128<byte>, FixedArray16<byte>>(ref left);
                ref FixedArray16<byte> pright = ref Unsafe.As<Vector128<byte>, FixedArray16<byte>>(ref right);
                p.I0 = (sbyte)BitMath.ToInt32Mask(pleft.I0 >= pright.I0);
                p.I1 = (sbyte)BitMath.ToInt32Mask(pleft.I1 >= pright.I1);
                p.I2 = (sbyte)BitMath.ToInt32Mask(pleft.I2 >= pright.I2);
                p.I3 = (sbyte)BitMath.ToInt32Mask(pleft.I3 >= pright.I3);
                p.I4 = (sbyte)BitMath.ToInt32Mask(pleft.I4 >= pright.I4);
                p.I5 = (sbyte)BitMath.ToInt32Mask(pleft.I5 >= pright.I5);
                p.I6 = (sbyte)BitMath.ToInt32Mask(pleft.I6 >= pright.I6);
                p.I7 = (sbyte)BitMath.ToInt32Mask(pleft.I7 >= pright.I7);
                p.I8 = (sbyte)BitMath.ToInt32Mask(pleft.I8 >= pright.I8);
                p.I9 = (sbyte)BitMath.ToInt32Mask(pleft.I9 >= pright.I9);
                p.I10 = (sbyte)BitMath.ToInt32Mask(pleft.I10 >= pright.I10);
                p.I11 = (sbyte)BitMath.ToInt32Mask(pleft.I11 >= pright.I11);
                p.I12 = (sbyte)BitMath.ToInt32Mask(pleft.I12 >= pright.I12);
                p.I13 = (sbyte)BitMath.ToInt32Mask(pleft.I13 >= pright.I13);
                p.I14 = (sbyte)BitMath.ToInt32Mask(pleft.I14 >= pright.I14);
                p.I15 = (sbyte)BitMath.ToInt32Mask(pleft.I15 >= pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> GreaterThanOrEqual_Basic(Vector128<short> left, Vector128<short> right) {
                Unsafe.SkipInit(out Vector128<short> rt);
                ref FixedArray8<short> p = ref Unsafe.As<Vector128<short>, FixedArray8<short>>(ref rt);
                ref FixedArray8<short> pleft = ref Unsafe.As<Vector128<short>, FixedArray8<short>>(ref left);
                ref FixedArray8<short> pright = ref Unsafe.As<Vector128<short>, FixedArray8<short>>(ref right);
                p.I0 = (short)BitMath.ToInt32Mask(pleft.I0 >= pright.I0);
                p.I1 = (short)BitMath.ToInt32Mask(pleft.I1 >= pright.I1);
                p.I2 = (short)BitMath.ToInt32Mask(pleft.I2 >= pright.I2);
                p.I3 = (short)BitMath.ToInt32Mask(pleft.I3 >= pright.I3);
                p.I4 = (short)BitMath.ToInt32Mask(pleft.I4 >= pright.I4);
                p.I5 = (short)BitMath.ToInt32Mask(pleft.I5 >= pright.I5);
                p.I6 = (short)BitMath.ToInt32Mask(pleft.I6 >= pright.I6);
                p.I7 = (short)BitMath.ToInt32Mask(pleft.I7 >= pright.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> GreaterThanOrEqual_Basic(Vector128<ushort> left, Vector128<ushort> right) {
                Unsafe.SkipInit(out Vector128<ushort> rt);
                ref FixedArray8<short> p = ref Unsafe.As<Vector128<ushort>, FixedArray8<short>>(ref rt);
                ref FixedArray8<ushort> pleft = ref Unsafe.As<Vector128<ushort>, FixedArray8<ushort>>(ref left);
                ref FixedArray8<ushort> pright = ref Unsafe.As<Vector128<ushort>, FixedArray8<ushort>>(ref right);
                p.I0 = (short)BitMath.ToInt32Mask(pleft.I0 >= pright.I0);
                p.I1 = (short)BitMath.ToInt32Mask(pleft.I1 >= pright.I1);
                p.I2 = (short)BitMath.ToInt32Mask(pleft.I2 >= pright.I2);
                p.I3 = (short)BitMath.ToInt32Mask(pleft.I3 >= pright.I3);
                p.I4 = (short)BitMath.ToInt32Mask(pleft.I4 >= pright.I4);
                p.I5 = (short)BitMath.ToInt32Mask(pleft.I5 >= pright.I5);
                p.I6 = (short)BitMath.ToInt32Mask(pleft.I6 >= pright.I6);
                p.I7 = (short)BitMath.ToInt32Mask(pleft.I7 >= pright.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> GreaterThanOrEqual_Basic(Vector128<int> left, Vector128<int> right) {
                Unsafe.SkipInit(out Vector128<int> rt);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                ref FixedArray4<int> pleft = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref left);
                ref FixedArray4<int> pright = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 >= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 >= pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 >= pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 >= pright.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> GreaterThanOrEqual_Basic(Vector128<uint> left, Vector128<uint> right) {
                Unsafe.SkipInit(out Vector128<uint> rt);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<uint>, FixedArray4<int>>(ref rt);
                ref FixedArray4<uint> pleft = ref Unsafe.As<Vector128<uint>, FixedArray4<uint>>(ref left);
                ref FixedArray4<uint> pright = ref Unsafe.As<Vector128<uint>, FixedArray4<uint>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 >= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 >= pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 >= pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 >= pright.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> GreaterThanOrEqual_Basic(Vector128<long> left, Vector128<long> right) {
                Unsafe.SkipInit(out Vector128<long> rt);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                ref FixedArray2<long> pleft = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref left);
                ref FixedArray2<long> pright = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 >= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 >= pright.I1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> GreaterThanOrEqual_Basic(Vector128<ulong> left, Vector128<ulong> right) {
                Unsafe.SkipInit(out Vector128<ulong> rt);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<ulong>, FixedArray2<long>>(ref rt);
                ref FixedArray2<ulong> pleft = ref Unsafe.As<Vector128<ulong>, FixedArray2<ulong>>(ref left);
                ref FixedArray2<ulong> pright = ref Unsafe.As<Vector128<ulong>, FixedArray2<ulong>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 >= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 >= pright.I1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanOrEqualAll_AcceleratedTypes {
                get {
                    return GreaterThanOrEqual_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector128<float> left, Vector128<float> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector128<double> left, Vector128<double> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector128<sbyte> left, Vector128<sbyte> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector128<byte> left, Vector128<byte> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector128<short> left, Vector128<short> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector128<ushort> left, Vector128<ushort> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector128<int> left, Vector128<int> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector128<uint> left, Vector128<uint> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector128<long> left, Vector128<long> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector128<ulong> left, Vector128<ulong> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanOrEqualAny_AcceleratedTypes {
                get {
                    return GreaterThanOrEqual_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector128<float> left, Vector128<float> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector128<double> left, Vector128<double> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector128<sbyte> left, Vector128<sbyte> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector128<byte> left, Vector128<byte> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector128<short> left, Vector128<short> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector128<ushort> left, Vector128<ushort> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector128<int> left, Vector128<int> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector128<uint> left, Vector128<uint> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector128<long> left, Vector128<long> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector128<ulong> left, Vector128<ulong> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.LessThan_AcceleratedTypes"/>
            public static TypeCodeFlags LessThan_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> LessThan(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> LessThan(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> LessThan(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> LessThan(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> LessThan(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> LessThan(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> LessThan(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> LessThan(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> LessThan(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> LessThan(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> LessThan_Basic(Vector128<float> left, Vector128<float> right) {
                Unsafe.SkipInit(out Vector128<float> rt);
                ref int prt = ref Unsafe.As<Vector128<float>, int>(ref rt);
                ref float pleft = ref Unsafe.As<Vector128<float>, float>(ref left);
                ref float pright = ref Unsafe.As<Vector128<float>, float>(ref right);
                prt = BitMath.ToInt32Mask(pleft < pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) < Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) < Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) < Unsafe.Add(ref pright, 3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> LessThan_Basic(Vector128<double> left, Vector128<double> right) {
                Unsafe.SkipInit(out Vector128<double> rt);
                ref long prt = ref Unsafe.As<Vector128<double>, long>(ref rt);
                ref double pleft = ref Unsafe.As<Vector128<double>, double>(ref left);
                ref double pright = ref Unsafe.As<Vector128<double>, double>(ref right);
                prt = BitMath.ToInt32Mask(pleft < pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) < Unsafe.Add(ref pright, 1));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> LessThan_Basic(Vector128<sbyte> left, Vector128<sbyte> right) {
                Unsafe.SkipInit(out Vector128<sbyte> rt);
                ref sbyte prt = ref Unsafe.As<Vector128<sbyte>, sbyte>(ref rt);
                ref sbyte pleft = ref Unsafe.As<Vector128<sbyte>, sbyte>(ref left);
                ref sbyte pright = ref Unsafe.As<Vector128<sbyte>, sbyte>(ref right);
                prt = (sbyte)BitMath.ToInt32Mask(pleft < pright);
                Unsafe.Add(ref prt, 1) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) < Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) < Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) < Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 4) < Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 5) < Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 6) < Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 7) < Unsafe.Add(ref pright, 7));
                Unsafe.Add(ref prt, 8) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 8) < Unsafe.Add(ref pright, 8));
                Unsafe.Add(ref prt, 9) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 9) < Unsafe.Add(ref pright, 9));
                Unsafe.Add(ref prt, 10) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 10) < Unsafe.Add(ref pright, 10));
                Unsafe.Add(ref prt, 11) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 11) < Unsafe.Add(ref pright, 11));
                Unsafe.Add(ref prt, 12) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 12) < Unsafe.Add(ref pright, 12));
                Unsafe.Add(ref prt, 13) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 13) < Unsafe.Add(ref pright, 13));
                Unsafe.Add(ref prt, 14) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 14) < Unsafe.Add(ref pright, 14));
                Unsafe.Add(ref prt, 15) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 15) < Unsafe.Add(ref pright, 15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> LessThan_Basic(Vector128<byte> left, Vector128<byte> right) {
                Unsafe.SkipInit(out Vector128<byte> rt);
                ref sbyte prt = ref Unsafe.As<Vector128<byte>, sbyte>(ref rt);
                ref byte pleft = ref Unsafe.As<Vector128<byte>, byte>(ref left);
                ref byte pright = ref Unsafe.As<Vector128<byte>, byte>(ref right);
                prt = (sbyte)BitMath.ToInt32Mask(pleft < pright);
                Unsafe.Add(ref prt, 1) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) < Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) < Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) < Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 4) < Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 5) < Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 6) < Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 7) < Unsafe.Add(ref pright, 7));
                Unsafe.Add(ref prt, 8) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 8) < Unsafe.Add(ref pright, 8));
                Unsafe.Add(ref prt, 9) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 9) < Unsafe.Add(ref pright, 9));
                Unsafe.Add(ref prt, 10) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 10) < Unsafe.Add(ref pright, 10));
                Unsafe.Add(ref prt, 11) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 11) < Unsafe.Add(ref pright, 11));
                Unsafe.Add(ref prt, 12) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 12) < Unsafe.Add(ref pright, 12));
                Unsafe.Add(ref prt, 13) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 13) < Unsafe.Add(ref pright, 13));
                Unsafe.Add(ref prt, 14) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 14) < Unsafe.Add(ref pright, 14));
                Unsafe.Add(ref prt, 15) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 15) < Unsafe.Add(ref pright, 15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> LessThan_Basic(Vector128<short> left, Vector128<short> right) {
                Unsafe.SkipInit(out Vector128<short> rt);
                ref short prt = ref Unsafe.As<Vector128<short>, short>(ref rt);
                ref short pleft = ref Unsafe.As<Vector128<short>, short>(ref left);
                ref short pright = ref Unsafe.As<Vector128<short>, short>(ref right);
                prt = (short)BitMath.ToInt32Mask(pleft < pright);
                Unsafe.Add(ref prt, 1) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) < Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) < Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) < Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 4) < Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 5) < Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 6) < Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 7) < Unsafe.Add(ref pright, 7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> LessThan_Basic(Vector128<ushort> left, Vector128<ushort> right) {
                Unsafe.SkipInit(out Vector128<ushort> rt);
                ref short prt = ref Unsafe.As<Vector128<ushort>, short>(ref rt);
                ref ushort pleft = ref Unsafe.As<Vector128<ushort>, ushort>(ref left);
                ref ushort pright = ref Unsafe.As<Vector128<ushort>, ushort>(ref right);
                prt = (short)BitMath.ToInt32Mask(pleft < pright);
                Unsafe.Add(ref prt, 1) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) < Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) < Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) < Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 4) < Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 5) < Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 6) < Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 7) < Unsafe.Add(ref pright, 7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> LessThan_Basic(Vector128<int> left, Vector128<int> right) {
                Unsafe.SkipInit(out Vector128<int> rt);
                ref int prt = ref Unsafe.As<Vector128<int>, int>(ref rt);
                ref int pleft = ref Unsafe.As<Vector128<int>, int>(ref left);
                ref int pright = ref Unsafe.As<Vector128<int>, int>(ref right);
                prt = BitMath.ToInt32Mask(pleft < pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) < Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) < Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) < Unsafe.Add(ref pright, 3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> LessThan_Basic(Vector128<uint> left, Vector128<uint> right) {
                Unsafe.SkipInit(out Vector128<uint> rt);
                ref int prt = ref Unsafe.As<Vector128<uint>, int>(ref rt);
                ref uint pleft = ref Unsafe.As<Vector128<uint>, uint>(ref left);
                ref uint pright = ref Unsafe.As<Vector128<uint>, uint>(ref right);
                prt = BitMath.ToInt32Mask(pleft < pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) < Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) < Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) < Unsafe.Add(ref pright, 3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> LessThan_Basic(Vector128<long> left, Vector128<long> right) {
                Unsafe.SkipInit(out Vector128<long> rt);
                ref long prt = ref Unsafe.As<Vector128<long>, long>(ref rt);
                ref long pleft = ref Unsafe.As<Vector128<long>, long>(ref left);
                ref long pright = ref Unsafe.As<Vector128<long>, long>(ref right);
                prt = BitMath.ToInt32Mask(pleft < pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) < Unsafe.Add(ref pright, 1));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> LessThan_Basic(Vector128<ulong> left, Vector128<ulong> right) {
                Unsafe.SkipInit(out Vector128<ulong> rt);
                ref long prt = ref Unsafe.As<Vector128<ulong>, long>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector128<ulong>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector128<ulong>, ulong>(ref right);
                prt = BitMath.ToInt32Mask(pleft < pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) < Unsafe.Add(ref pright, 1));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.LessThanAll_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanAll_AcceleratedTypes {
                get {
                    return LessThan_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector128<float> left, Vector128<float> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector128<double> left, Vector128<double> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector128<sbyte> left, Vector128<sbyte> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector128<byte> left, Vector128<byte> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector128<short> left, Vector128<short> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector128<ushort> left, Vector128<ushort> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector128<int> left, Vector128<int> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector128<uint> left, Vector128<uint> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector128<long> left, Vector128<long> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector128<ulong> left, Vector128<ulong> right) {
                return YIsAllTrue(LessThan(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.LessThanAny_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanAny_AcceleratedTypes {
                get {
                    return LessThan_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector128<float> left, Vector128<float> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector128<double> left, Vector128<double> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector128<sbyte> left, Vector128<sbyte> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector128<byte> left, Vector128<byte> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector128<short> left, Vector128<short> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector128<ushort> left, Vector128<ushort> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector128<int> left, Vector128<int> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector128<uint> left, Vector128<uint> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector128<long> left, Vector128<long> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector128<ulong> left, Vector128<ulong> right) {
                return YIsAnyTrue(LessThan(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanOrEqual_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> LessThanOrEqual(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> LessThanOrEqual(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> LessThanOrEqual(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> LessThanOrEqual(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> LessThanOrEqual(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> LessThanOrEqual(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> LessThanOrEqual(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> LessThanOrEqual(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> LessThanOrEqual(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> LessThanOrEqual(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> LessThanOrEqual_Basic(Vector128<float> left, Vector128<float> right) {
                Unsafe.SkipInit(out Vector128<float> rt);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<float>, FixedArray4<int>>(ref rt);
                ref FixedArray4<float> pleft = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref left);
                ref FixedArray4<float> pright = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 <= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 <= pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 <= pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 <= pright.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> LessThanOrEqual_Basic(Vector128<double> left, Vector128<double> right) {
                Unsafe.SkipInit(out Vector128<double> rt);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<double>, FixedArray2<long>>(ref rt);
                ref FixedArray2<double> pleft = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref left);
                ref FixedArray2<double> pright = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 <= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 <= pright.I1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> LessThanOrEqual_Basic(Vector128<sbyte> left, Vector128<sbyte> right) {
                Unsafe.SkipInit(out Vector128<sbyte> rt);
                ref FixedArray16<sbyte> p = ref Unsafe.As<Vector128<sbyte>, FixedArray16<sbyte>>(ref rt);
                ref FixedArray16<sbyte> pleft = ref Unsafe.As<Vector128<sbyte>, FixedArray16<sbyte>>(ref left);
                ref FixedArray16<sbyte> pright = ref Unsafe.As<Vector128<sbyte>, FixedArray16<sbyte>>(ref right);
                p.I0 = (sbyte)BitMath.ToInt32Mask(pleft.I0 <= pright.I0);
                p.I1 = (sbyte)BitMath.ToInt32Mask(pleft.I1 <= pright.I1);
                p.I2 = (sbyte)BitMath.ToInt32Mask(pleft.I2 <= pright.I2);
                p.I3 = (sbyte)BitMath.ToInt32Mask(pleft.I3 <= pright.I3);
                p.I4 = (sbyte)BitMath.ToInt32Mask(pleft.I4 <= pright.I4);
                p.I5 = (sbyte)BitMath.ToInt32Mask(pleft.I5 <= pright.I5);
                p.I6 = (sbyte)BitMath.ToInt32Mask(pleft.I6 <= pright.I6);
                p.I7 = (sbyte)BitMath.ToInt32Mask(pleft.I7 <= pright.I7);
                p.I8 = (sbyte)BitMath.ToInt32Mask(pleft.I8 <= pright.I8);
                p.I9 = (sbyte)BitMath.ToInt32Mask(pleft.I9 <= pright.I9);
                p.I10 = (sbyte)BitMath.ToInt32Mask(pleft.I10 <= pright.I10);
                p.I11 = (sbyte)BitMath.ToInt32Mask(pleft.I11 <= pright.I11);
                p.I12 = (sbyte)BitMath.ToInt32Mask(pleft.I12 <= pright.I12);
                p.I13 = (sbyte)BitMath.ToInt32Mask(pleft.I13 <= pright.I13);
                p.I14 = (sbyte)BitMath.ToInt32Mask(pleft.I14 <= pright.I14);
                p.I15 = (sbyte)BitMath.ToInt32Mask(pleft.I15 <= pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> LessThanOrEqual_Basic(Vector128<byte> left, Vector128<byte> right) {
                Unsafe.SkipInit(out Vector128<byte> rt);
                ref FixedArray16<sbyte> p = ref Unsafe.As<Vector128<byte>, FixedArray16<sbyte>>(ref rt);
                ref FixedArray16<byte> pleft = ref Unsafe.As<Vector128<byte>, FixedArray16<byte>>(ref left);
                ref FixedArray16<byte> pright = ref Unsafe.As<Vector128<byte>, FixedArray16<byte>>(ref right);
                p.I0 = (sbyte)BitMath.ToInt32Mask(pleft.I0 <= pright.I0);
                p.I1 = (sbyte)BitMath.ToInt32Mask(pleft.I1 <= pright.I1);
                p.I2 = (sbyte)BitMath.ToInt32Mask(pleft.I2 <= pright.I2);
                p.I3 = (sbyte)BitMath.ToInt32Mask(pleft.I3 <= pright.I3);
                p.I4 = (sbyte)BitMath.ToInt32Mask(pleft.I4 <= pright.I4);
                p.I5 = (sbyte)BitMath.ToInt32Mask(pleft.I5 <= pright.I5);
                p.I6 = (sbyte)BitMath.ToInt32Mask(pleft.I6 <= pright.I6);
                p.I7 = (sbyte)BitMath.ToInt32Mask(pleft.I7 <= pright.I7);
                p.I8 = (sbyte)BitMath.ToInt32Mask(pleft.I8 <= pright.I8);
                p.I9 = (sbyte)BitMath.ToInt32Mask(pleft.I9 <= pright.I9);
                p.I10 = (sbyte)BitMath.ToInt32Mask(pleft.I10 <= pright.I10);
                p.I11 = (sbyte)BitMath.ToInt32Mask(pleft.I11 <= pright.I11);
                p.I12 = (sbyte)BitMath.ToInt32Mask(pleft.I12 <= pright.I12);
                p.I13 = (sbyte)BitMath.ToInt32Mask(pleft.I13 <= pright.I13);
                p.I14 = (sbyte)BitMath.ToInt32Mask(pleft.I14 <= pright.I14);
                p.I15 = (sbyte)BitMath.ToInt32Mask(pleft.I15 <= pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> LessThanOrEqual_Basic(Vector128<short> left, Vector128<short> right) {
                Unsafe.SkipInit(out Vector128<short> rt);
                ref FixedArray8<short> p = ref Unsafe.As<Vector128<short>, FixedArray8<short>>(ref rt);
                ref FixedArray8<short> pleft = ref Unsafe.As<Vector128<short>, FixedArray8<short>>(ref left);
                ref FixedArray8<short> pright = ref Unsafe.As<Vector128<short>, FixedArray8<short>>(ref right);
                p.I0 = (short)BitMath.ToInt32Mask(pleft.I0 <= pright.I0);
                p.I1 = (short)BitMath.ToInt32Mask(pleft.I1 <= pright.I1);
                p.I2 = (short)BitMath.ToInt32Mask(pleft.I2 <= pright.I2);
                p.I3 = (short)BitMath.ToInt32Mask(pleft.I3 <= pright.I3);
                p.I4 = (short)BitMath.ToInt32Mask(pleft.I4 <= pright.I4);
                p.I5 = (short)BitMath.ToInt32Mask(pleft.I5 <= pright.I5);
                p.I6 = (short)BitMath.ToInt32Mask(pleft.I6 <= pright.I6);
                p.I7 = (short)BitMath.ToInt32Mask(pleft.I7 <= pright.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> LessThanOrEqual_Basic(Vector128<ushort> left, Vector128<ushort> right) {
                Unsafe.SkipInit(out Vector128<ushort> rt);
                ref FixedArray8<short> p = ref Unsafe.As<Vector128<ushort>, FixedArray8<short>>(ref rt);
                ref FixedArray8<ushort> pleft = ref Unsafe.As<Vector128<ushort>, FixedArray8<ushort>>(ref left);
                ref FixedArray8<ushort> pright = ref Unsafe.As<Vector128<ushort>, FixedArray8<ushort>>(ref right);
                p.I0 = (short)BitMath.ToInt32Mask(pleft.I0 <= pright.I0);
                p.I1 = (short)BitMath.ToInt32Mask(pleft.I1 <= pright.I1);
                p.I2 = (short)BitMath.ToInt32Mask(pleft.I2 <= pright.I2);
                p.I3 = (short)BitMath.ToInt32Mask(pleft.I3 <= pright.I3);
                p.I4 = (short)BitMath.ToInt32Mask(pleft.I4 <= pright.I4);
                p.I5 = (short)BitMath.ToInt32Mask(pleft.I5 <= pright.I5);
                p.I6 = (short)BitMath.ToInt32Mask(pleft.I6 <= pright.I6);
                p.I7 = (short)BitMath.ToInt32Mask(pleft.I7 <= pright.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> LessThanOrEqual_Basic(Vector128<int> left, Vector128<int> right) {
                Unsafe.SkipInit(out Vector128<int> rt);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                ref FixedArray4<int> pleft = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref left);
                ref FixedArray4<int> pright = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 <= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 <= pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 <= pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 <= pright.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> LessThanOrEqual_Basic(Vector128<uint> left, Vector128<uint> right) {
                Unsafe.SkipInit(out Vector128<uint> rt);
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<uint>, FixedArray4<int>>(ref rt);
                ref FixedArray4<uint> pleft = ref Unsafe.As<Vector128<uint>, FixedArray4<uint>>(ref left);
                ref FixedArray4<uint> pright = ref Unsafe.As<Vector128<uint>, FixedArray4<uint>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 <= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 <= pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 <= pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 <= pright.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> LessThanOrEqual_Basic(Vector128<long> left, Vector128<long> right) {
                Unsafe.SkipInit(out Vector128<long> rt);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                ref FixedArray2<long> pleft = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref left);
                ref FixedArray2<long> pright = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 <= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 <= pright.I1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> LessThanOrEqual_Basic(Vector128<ulong> left, Vector128<ulong> right) {
                Unsafe.SkipInit(out Vector128<ulong> rt);
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<ulong>, FixedArray2<long>>(ref rt);
                ref FixedArray2<ulong> pleft = ref Unsafe.As<Vector128<ulong>, FixedArray2<ulong>>(ref left);
                ref FixedArray2<ulong> pright = ref Unsafe.As<Vector128<ulong>, FixedArray2<ulong>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 <= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 <= pright.I1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanOrEqualAll_AcceleratedTypes {
                get {
                    return LessThanOrEqual_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector128<float> left, Vector128<float> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector128<double> left, Vector128<double> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector128<sbyte> left, Vector128<sbyte> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector128<byte> left, Vector128<byte> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector128<short> left, Vector128<short> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector128<ushort> left, Vector128<ushort> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector128<int> left, Vector128<int> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector128<uint> left, Vector128<uint> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector128<long> left, Vector128<long> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector128<ulong> left, Vector128<ulong> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanOrEqualAny_AcceleratedTypes {
                get {
                    return LessThanOrEqual_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector128<float> left, Vector128<float> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector128<double> left, Vector128<double> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector128<sbyte> left, Vector128<sbyte> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector128<byte> left, Vector128<byte> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector128<short> left, Vector128<short> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector128<ushort> left, Vector128<ushort> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector128<int> left, Vector128<int> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector128<uint> left, Vector128<uint> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector128<long> left, Vector128<long> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector128<ulong> left, Vector128<ulong> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.Max_AcceleratedTypes"/>
            public static TypeCodeFlags Max_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Max(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Max(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Max(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Max(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Max(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Max(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Max(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Max(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Max(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Max(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Max_Conditional(Vector128<float> left, Vector128<float> right) {
                Vector128<float> condition = GreaterThan(left, right);
                Vector128<float> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Max_Conditional(Vector128<double> left, Vector128<double> right) {
                Vector128<double> condition = GreaterThan(left, right);
                Vector128<double> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Max_Conditional(Vector128<sbyte> left, Vector128<sbyte> right) {
                Vector128<sbyte> condition = GreaterThan(left, right);
                Vector128<sbyte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Max_Conditional(Vector128<byte> left, Vector128<byte> right) {
                Vector128<byte> condition = GreaterThan(left, right);
                Vector128<byte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Max_Conditional(Vector128<short> left, Vector128<short> right) {
                Vector128<short> condition = GreaterThan(left, right);
                Vector128<short> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Max_Conditional(Vector128<ushort> left, Vector128<ushort> right) {
                Vector128<ushort> condition = GreaterThan(left, right);
                Vector128<ushort> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Max_Conditional(Vector128<int> left, Vector128<int> right) {
                Vector128<int> condition = GreaterThan(left, right);
                Vector128<int> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Max_Conditional(Vector128<uint> left, Vector128<uint> right) {
                Vector128<uint> condition = GreaterThan(left, right);
                Vector128<uint> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Max_Conditional(Vector128<long> left, Vector128<long> right) {
                Vector128<long> condition = GreaterThan(left, right);
                Vector128<long> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Max_Conditional(Vector128<ulong> left, Vector128<ulong> right) {
                Vector128<ulong> condition = GreaterThan(left, right);
                Vector128<ulong> rt = ConditionalSelect(condition, left, right);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Min_AcceleratedTypes"/>
            public static TypeCodeFlags Min_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Min(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Min(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Min(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Min(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Min(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Min(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Min(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Min(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Min(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Min(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Min_Conditional(Vector128<float> left, Vector128<float> right) {
                Vector128<float> condition = LessThan(left, right);
                Vector128<float> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Min_Conditional(Vector128<double> left, Vector128<double> right) {
                Vector128<double> condition = LessThan(left, right);
                Vector128<double> rt = ConditionalSelect(condition, left, right);
                return rt.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Min_Conditional(Vector128<sbyte> left, Vector128<sbyte> right) {
                Vector128<sbyte> condition = LessThan(left, right);
                Vector128<sbyte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Min_Conditional(Vector128<byte> left, Vector128<byte> right) {
                Vector128<byte> condition = LessThan(left, right);
                Vector128<byte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Min_Conditional(Vector128<short> left, Vector128<short> right) {
                Vector128<short> condition = LessThan(left, right);
                Vector128<short> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Min_Conditional(Vector128<ushort> left, Vector128<ushort> right) {
                Vector128<ushort> condition = LessThan(left, right);
                Vector128<ushort> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Min_Conditional(Vector128<int> left, Vector128<int> right) {
                Vector128<int> condition = LessThan(left, right);
                Vector128<int> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Min_Conditional(Vector128<uint> left, Vector128<uint> right) {
                Vector128<uint> condition = LessThan(left, right);
                Vector128<uint> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Min_Conditional(Vector128<long> left, Vector128<long> right) {
                Vector128<long> condition = LessThan(left, right);
                Vector128<long> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Min_Conditional(Vector128<ulong> left, Vector128<ulong> right) {
                Vector128<ulong> condition = LessThan(left, right);
                Vector128<ulong> rt = ConditionalSelect(condition, left, right);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Multiply_AcceleratedTypes"/>
            public static TypeCodeFlags Multiply_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply_FullAcceleratedTypes"/>
            public static TypeCodeFlags Multiply_FullAcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Multiply(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Multiply(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Multiply(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Multiply(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Multiply(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Multiply(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Multiply(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Multiply(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Multiply(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Multiply(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Multiply_Basic(Vector128<float> left, Vector128<float> right) {
                Unsafe.SkipInit(out Vector128<float> rt);
                ref float prt = ref Unsafe.As<Vector128<float>, float>(ref rt);
                ref float pleft = ref Unsafe.As<Vector128<float>, float>(ref left);
                ref float pright = ref Unsafe.As<Vector128<float>, float>(ref right);
                prt = pleft * pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) * Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) * Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) * Unsafe.Add(ref pright, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Multiply_Basic(Vector128<double> left, Vector128<double> right) {
                Unsafe.SkipInit(out Vector128<double> rt);
                ref double prt = ref Unsafe.As<Vector128<double>, double>(ref rt);
                ref double pleft = ref Unsafe.As<Vector128<double>, double>(ref left);
                ref double pright = ref Unsafe.As<Vector128<double>, double>(ref right);
                prt = pleft * pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) * Unsafe.Add(ref pright, 1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Multiply_Basic(Vector128<sbyte> left, Vector128<sbyte> right) {
                Unsafe.SkipInit(out Vector128<sbyte> rt);
                ref sbyte prt = ref Unsafe.As<Vector128<sbyte>, sbyte>(ref rt);
                ref sbyte pleft = ref Unsafe.As<Vector128<sbyte>, sbyte>(ref left);
                ref sbyte pright = ref Unsafe.As<Vector128<sbyte>, sbyte>(ref right);
                prt = (sbyte)(pleft * pright);
                Unsafe.Add(ref prt, 1) = (sbyte)(Unsafe.Add(ref pleft, 1) * Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (sbyte)(Unsafe.Add(ref pleft, 2) * Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (sbyte)(Unsafe.Add(ref pleft, 3) * Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (sbyte)(Unsafe.Add(ref pleft, 4) * Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (sbyte)(Unsafe.Add(ref pleft, 5) * Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (sbyte)(Unsafe.Add(ref pleft, 6) * Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (sbyte)(Unsafe.Add(ref pleft, 7) * Unsafe.Add(ref pright, 7));
                Unsafe.Add(ref prt, 8) = (sbyte)(Unsafe.Add(ref pleft, 8) * Unsafe.Add(ref pright, 8));
                Unsafe.Add(ref prt, 9) = (sbyte)(Unsafe.Add(ref pleft, 9) * Unsafe.Add(ref pright, 9));
                Unsafe.Add(ref prt, 10) = (sbyte)(Unsafe.Add(ref pleft, 10) * Unsafe.Add(ref pright, 10));
                Unsafe.Add(ref prt, 11) = (sbyte)(Unsafe.Add(ref pleft, 11) * Unsafe.Add(ref pright, 11));
                Unsafe.Add(ref prt, 12) = (sbyte)(Unsafe.Add(ref pleft, 12) * Unsafe.Add(ref pright, 12));
                Unsafe.Add(ref prt, 13) = (sbyte)(Unsafe.Add(ref pleft, 13) * Unsafe.Add(ref pright, 13));
                Unsafe.Add(ref prt, 14) = (sbyte)(Unsafe.Add(ref pleft, 14) * Unsafe.Add(ref pright, 14));
                Unsafe.Add(ref prt, 15) = (sbyte)(Unsafe.Add(ref pleft, 15) * Unsafe.Add(ref pright, 15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Multiply_Basic(Vector128<byte> left, Vector128<byte> right) {
                Unsafe.SkipInit(out Vector128<byte> rt);
                ref byte prt = ref Unsafe.As<Vector128<byte>, byte>(ref rt);
                ref byte pleft = ref Unsafe.As<Vector128<byte>, byte>(ref left);
                ref byte pright = ref Unsafe.As<Vector128<byte>, byte>(ref right);
                prt = (byte)(pleft * pright);
                Unsafe.Add(ref prt, 1) = (byte)(Unsafe.Add(ref pleft, 1) * Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (byte)(Unsafe.Add(ref pleft, 2) * Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (byte)(Unsafe.Add(ref pleft, 3) * Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (byte)(Unsafe.Add(ref pleft, 4) * Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (byte)(Unsafe.Add(ref pleft, 5) * Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (byte)(Unsafe.Add(ref pleft, 6) * Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (byte)(Unsafe.Add(ref pleft, 7) * Unsafe.Add(ref pright, 7));
                Unsafe.Add(ref prt, 8) = (byte)(Unsafe.Add(ref pleft, 8) * Unsafe.Add(ref pright, 8));
                Unsafe.Add(ref prt, 9) = (byte)(Unsafe.Add(ref pleft, 9) * Unsafe.Add(ref pright, 9));
                Unsafe.Add(ref prt, 10) = (byte)(Unsafe.Add(ref pleft, 10) * Unsafe.Add(ref pright, 10));
                Unsafe.Add(ref prt, 11) = (byte)(Unsafe.Add(ref pleft, 11) * Unsafe.Add(ref pright, 11));
                Unsafe.Add(ref prt, 12) = (byte)(Unsafe.Add(ref pleft, 12) * Unsafe.Add(ref pright, 12));
                Unsafe.Add(ref prt, 13) = (byte)(Unsafe.Add(ref pleft, 13) * Unsafe.Add(ref pright, 13));
                Unsafe.Add(ref prt, 14) = (byte)(Unsafe.Add(ref pleft, 14) * Unsafe.Add(ref pright, 14));
                Unsafe.Add(ref prt, 15) = (byte)(Unsafe.Add(ref pleft, 15) * Unsafe.Add(ref pright, 15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Multiply_Basic(Vector128<short> left, Vector128<short> right) {
                Unsafe.SkipInit(out Vector128<short> rt);
                ref short prt = ref Unsafe.As<Vector128<short>, short>(ref rt);
                ref short pleft = ref Unsafe.As<Vector128<short>, short>(ref left);
                ref short pright = ref Unsafe.As<Vector128<short>, short>(ref right);
                prt = (short)(pleft * pright);
                Unsafe.Add(ref prt, 1) = (short)(Unsafe.Add(ref pleft, 1) * Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (short)(Unsafe.Add(ref pleft, 2) * Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (short)(Unsafe.Add(ref pleft, 3) * Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (short)(Unsafe.Add(ref pleft, 4) * Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (short)(Unsafe.Add(ref pleft, 5) * Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (short)(Unsafe.Add(ref pleft, 6) * Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (short)(Unsafe.Add(ref pleft, 7) * Unsafe.Add(ref pright, 7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Multiply_Basic(Vector128<ushort> left, Vector128<ushort> right) {
                Unsafe.SkipInit(out Vector128<ushort> rt);
                ref ushort prt = ref Unsafe.As<Vector128<ushort>, ushort>(ref rt);
                ref ushort pleft = ref Unsafe.As<Vector128<ushort>, ushort>(ref left);
                ref ushort pright = ref Unsafe.As<Vector128<ushort>, ushort>(ref right);
                prt = (ushort)(pleft * pright);
                Unsafe.Add(ref prt, 1) = (ushort)(Unsafe.Add(ref pleft, 1) * Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (ushort)(Unsafe.Add(ref pleft, 2) * Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (ushort)(Unsafe.Add(ref pleft, 3) * Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (ushort)(Unsafe.Add(ref pleft, 4) * Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (ushort)(Unsafe.Add(ref pleft, 5) * Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (ushort)(Unsafe.Add(ref pleft, 6) * Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (ushort)(Unsafe.Add(ref pleft, 7) * Unsafe.Add(ref pright, 7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Multiply_Basic(Vector128<int> left, Vector128<int> right) {
                Unsafe.SkipInit(out Vector128<int> rt);
                ref int prt = ref Unsafe.As<Vector128<int>, int>(ref rt);
                ref int pleft = ref Unsafe.As<Vector128<int>, int>(ref left);
                ref int pright = ref Unsafe.As<Vector128<int>, int>(ref right);
                prt = pleft * pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) * Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) * Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) * Unsafe.Add(ref pright, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Multiply_Basic(Vector128<uint> left, Vector128<uint> right) {
                Unsafe.SkipInit(out Vector128<uint> rt);
                ref uint prt = ref Unsafe.As<Vector128<uint>, uint>(ref rt);
                ref uint pleft = ref Unsafe.As<Vector128<uint>, uint>(ref left);
                ref uint pright = ref Unsafe.As<Vector128<uint>, uint>(ref right);
                prt = pleft * pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) * Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) * Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) * Unsafe.Add(ref pright, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Multiply_Basic(Vector128<long> left, Vector128<long> right) {
                Unsafe.SkipInit(out Vector128<long> rt);
                ref long prt = ref Unsafe.As<Vector128<long>, long>(ref rt);
                ref long pleft = ref Unsafe.As<Vector128<long>, long>(ref left);
                ref long pright = ref Unsafe.As<Vector128<long>, long>(ref right);
                prt = pleft * pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) * Unsafe.Add(ref pright, 1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Multiply_Basic(Vector128<ulong> left, Vector128<ulong> right) {
                Unsafe.SkipInit(out Vector128<ulong> rt);
                ref ulong prt = ref Unsafe.As<Vector128<ulong>, ulong>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector128<ulong>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector128<ulong>, ulong>(ref right);
                prt = pleft * pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) * Unsafe.Add(ref pright, 1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Negate_AcceleratedTypes"/>
            public static TypeCodeFlags Negate_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Negate(Vector128<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Negate(value);
#else
                return Negate_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Negate(Vector128<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Negate(value);
#else
                return Negate_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Negate(Vector128<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Negate(value);
#else
                return Negate_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Negate(Vector128<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Negate(value);
#else
                return Negate_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Negate(Vector128<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Negate(value);
#else
                return Negate_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Negate(Vector128<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Negate(value);
#else
                return Negate_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Negate_Basic(Vector128<float> value) {
                Vector128<float> rt = value;
                ref float p = ref Unsafe.As<Vector128<float>, float>(ref rt);
                p = -p;
                Unsafe.Add(ref p, 1) = -Unsafe.Add(ref p, 1);
                Unsafe.Add(ref p, 2) = -Unsafe.Add(ref p, 2);
                Unsafe.Add(ref p, 3) = -Unsafe.Add(ref p, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Negate_Basic(Vector128<double> value) {
                Vector128<double> rt = value;
                ref double p = ref Unsafe.As<Vector128<double>, double>(ref rt);
                p = -p;
                Unsafe.Add(ref p, 1) = -Unsafe.Add(ref p, 1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Negate_Basic(Vector128<sbyte> value) {
                Vector128<sbyte> rt = value;
                ref sbyte p = ref Unsafe.As<Vector128<sbyte>, sbyte>(ref rt);
                p = (sbyte)-p;
                Unsafe.Add(ref p, 1) = (sbyte)-Unsafe.Add(ref p, 1);
                Unsafe.Add(ref p, 2) = (sbyte)-Unsafe.Add(ref p, 2);
                Unsafe.Add(ref p, 3) = (sbyte)-Unsafe.Add(ref p, 3);
                Unsafe.Add(ref p, 4) = (sbyte)-Unsafe.Add(ref p, 4);
                Unsafe.Add(ref p, 5) = (sbyte)-Unsafe.Add(ref p, 5);
                Unsafe.Add(ref p, 6) = (sbyte)-Unsafe.Add(ref p, 6);
                Unsafe.Add(ref p, 7) = (sbyte)-Unsafe.Add(ref p, 7);
                Unsafe.Add(ref p, 8) = (sbyte)-Unsafe.Add(ref p, 8);
                Unsafe.Add(ref p, 9) = (sbyte)-Unsafe.Add(ref p, 9);
                Unsafe.Add(ref p, 10) = (sbyte)-Unsafe.Add(ref p, 10);
                Unsafe.Add(ref p, 11) = (sbyte)-Unsafe.Add(ref p, 11);
                Unsafe.Add(ref p, 12) = (sbyte)-Unsafe.Add(ref p, 12);
                Unsafe.Add(ref p, 13) = (sbyte)-Unsafe.Add(ref p, 13);
                Unsafe.Add(ref p, 14) = (sbyte)-Unsafe.Add(ref p, 14);
                Unsafe.Add(ref p, 15) = (sbyte)-Unsafe.Add(ref p, 15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Negate_Basic(Vector128<short> value) {
                Vector128<short> rt = value;
                ref short p = ref Unsafe.As<Vector128<short>, short>(ref rt);
                p = (short)-p;
                Unsafe.Add(ref p, 1) = (short)-Unsafe.Add(ref p, 1);
                Unsafe.Add(ref p, 2) = (short)-Unsafe.Add(ref p, 2);
                Unsafe.Add(ref p, 3) = (short)-Unsafe.Add(ref p, 3);
                Unsafe.Add(ref p, 4) = (short)-Unsafe.Add(ref p, 4);
                Unsafe.Add(ref p, 5) = (short)-Unsafe.Add(ref p, 5);
                Unsafe.Add(ref p, 6) = (short)-Unsafe.Add(ref p, 6);
                Unsafe.Add(ref p, 7) = (short)-Unsafe.Add(ref p, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Negate_Basic(Vector128<int> value) {
                Vector128<int> rt = value;
                ref int p = ref Unsafe.As<Vector128<int>, int>(ref rt);
                p = -p;
                Unsafe.Add(ref p, 1) = -Unsafe.Add(ref p, 1);
                Unsafe.Add(ref p, 2) = -Unsafe.Add(ref p, 2);
                Unsafe.Add(ref p, 3) = -Unsafe.Add(ref p, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Negate_Basic(Vector128<long> value) {
                Vector128<long> rt = value;
                ref long p = ref Unsafe.As<Vector128<long>, long>(ref rt);
                p = -p;
                Unsafe.Add(ref p, 1) = -Unsafe.Add(ref p, 1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.OnesComplement_AcceleratedTypes"/>
            public static TypeCodeFlags OnesComplement_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.OnesComplement{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> OnesComplement<T>(Vector128<T> vector) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.OnesComplement(vector);
#else
                return OnesComplement_Basic(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.OnesComplement{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> OnesComplement_Basic<T>(Vector128<T> vector) where T : struct {
                Vector128<T> rt = vector;
                ref long p = ref Unsafe.As<Vector128<T>, long>(ref rt);
                p = ~p;
                Unsafe.Add(ref p, 1) = ~Unsafe.Add(ref p, 1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Sqrt_AcceleratedTypes"/>
            public static TypeCodeFlags Sqrt_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single;
#if Sqrt_Float_Used
                        rt |= TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16;
#endif
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Sqrt(Vector128<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Sqrt(value);
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Sqrt(Vector128<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Sqrt(value);
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Sqrt(Vector128<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector128.IsHardwareAccelerated) {
#if Sqrt_Float_Used
                    return Sqrt_Float(value);
#else
                    return Vector128.Sqrt(value);
#endif
                } else {
                    return Sqrt_Basic(value);
                }
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Sqrt(Vector128<byte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector128.IsHardwareAccelerated) {
#if Sqrt_Float_Used
                    return Sqrt_Float(value);
#else
                    return Vector128.Sqrt(value);
#endif
                } else {
                    return Sqrt_Basic(value);
                }
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Sqrt(Vector128<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector128.IsHardwareAccelerated) {
#if Sqrt_Float_Used
                    return Sqrt_Float(value);
#else
                    return Vector128.Sqrt(value);
#endif
                } else {
                    return Sqrt_Basic(value);
                }
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Sqrt(Vector128<ushort> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector128.IsHardwareAccelerated) {
#if Sqrt_Float_Used
                    return Sqrt_Float(value);
#else
                    return Vector128.Sqrt(value);
#endif
                } else {
                    return Sqrt_Basic(value);
                }
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Sqrt(Vector128<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector128.IsHardwareAccelerated) {
#if Sqrt_Float_Used
                    return Sqrt_Float(value);
#else
                    return Vector128.Sqrt(value);
#endif
                } else {
                    return Sqrt_Basic(value);
                }
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Sqrt(Vector128<uint> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector128.IsHardwareAccelerated) {
#if Sqrt_Float_Used
                    return Sqrt_Float(value);
#else
                    return Vector128.Sqrt(value);
#endif
                } else {
                    return Sqrt_Basic(value);
                }
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Sqrt(Vector128<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector128.IsHardwareAccelerated) {
#if Sqrt_Float_Used
                    return Sqrt_Float(value);
#else
                    return Vector128.Sqrt(value);
#endif
                } else {
                    return Sqrt_Basic(value);
                }
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Sqrt(Vector128<ulong> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector128.IsHardwareAccelerated) {
#if Sqrt_Float_Used
                    return Sqrt_Float(value);
#else
                    return Vector128.Sqrt(value);
#endif
                } else {
                    return Sqrt_Basic(value);
                }
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Sqrt_Basic(Vector128<float> value) {
                Vector128<float> rt = value;
                ref FixedArray4<float> p = ref Unsafe.As<Vector128<float>, FixedArray4<float>>(ref rt);
                p.I0 = BitMath.Sqrt(p.I0);
                p.I1 = BitMath.Sqrt(p.I1);
                p.I2 = BitMath.Sqrt(p.I2);
                p.I3 = BitMath.Sqrt(p.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Sqrt_Basic(Vector128<double> value) {
                Vector128<double> rt = value;
                ref FixedArray2<double> p = ref Unsafe.As<Vector128<double>, FixedArray2<double>>(ref rt);
                p.I0 = BitMath.Sqrt(p.I0);
                p.I1 = BitMath.Sqrt(p.I1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Sqrt_Basic(Vector128<sbyte> value) {
                Vector128<sbyte> rt = value;
                ref FixedArray16<sbyte> p = ref Unsafe.As<Vector128<sbyte>, FixedArray16<sbyte>>(ref rt);
                p.I0 = BitMath.Sqrt(p.I0);
                p.I1 = BitMath.Sqrt(p.I1);
                p.I2 = BitMath.Sqrt(p.I2);
                p.I3 = BitMath.Sqrt(p.I3);
                p.I4 = BitMath.Sqrt(p.I4);
                p.I5 = BitMath.Sqrt(p.I5);
                p.I6 = BitMath.Sqrt(p.I6);
                p.I7 = BitMath.Sqrt(p.I7);
                p.I8 = BitMath.Sqrt(p.I8);
                p.I9 = BitMath.Sqrt(p.I9);
                p.I10 = BitMath.Sqrt(p.I10);
                p.I11 = BitMath.Sqrt(p.I11);
                p.I12 = BitMath.Sqrt(p.I12);
                p.I13 = BitMath.Sqrt(p.I13);
                p.I14 = BitMath.Sqrt(p.I14);
                p.I15 = BitMath.Sqrt(p.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Sqrt_Basic(Vector128<byte> value) {
                Vector128<byte> rt = value;
                ref FixedArray16<byte> p = ref Unsafe.As<Vector128<byte>, FixedArray16<byte>>(ref rt);
                p.I0 = BitMath.Sqrt(p.I0);
                p.I1 = BitMath.Sqrt(p.I1);
                p.I2 = BitMath.Sqrt(p.I2);
                p.I3 = BitMath.Sqrt(p.I3);
                p.I4 = BitMath.Sqrt(p.I4);
                p.I5 = BitMath.Sqrt(p.I5);
                p.I6 = BitMath.Sqrt(p.I6);
                p.I7 = BitMath.Sqrt(p.I7);
                p.I8 = BitMath.Sqrt(p.I8);
                p.I9 = BitMath.Sqrt(p.I9);
                p.I10 = BitMath.Sqrt(p.I10);
                p.I11 = BitMath.Sqrt(p.I11);
                p.I12 = BitMath.Sqrt(p.I12);
                p.I13 = BitMath.Sqrt(p.I13);
                p.I14 = BitMath.Sqrt(p.I14);
                p.I15 = BitMath.Sqrt(p.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Sqrt_Basic(Vector128<short> value) {
                Vector128<short> rt = value;
                ref FixedArray8<short> p = ref Unsafe.As<Vector128<short>, FixedArray8<short>>(ref rt);
                p.I0 = BitMath.Sqrt(p.I0);
                p.I1 = BitMath.Sqrt(p.I1);
                p.I2 = BitMath.Sqrt(p.I2);
                p.I3 = BitMath.Sqrt(p.I3);
                p.I4 = BitMath.Sqrt(p.I4);
                p.I5 = BitMath.Sqrt(p.I5);
                p.I6 = BitMath.Sqrt(p.I6);
                p.I7 = BitMath.Sqrt(p.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Sqrt_Basic(Vector128<ushort> value) {
                Vector128<ushort> rt = value;
                ref FixedArray8<ushort> p = ref Unsafe.As<Vector128<ushort>, FixedArray8<ushort>>(ref rt);
                p.I0 = BitMath.Sqrt(p.I0);
                p.I1 = BitMath.Sqrt(p.I1);
                p.I2 = BitMath.Sqrt(p.I2);
                p.I3 = BitMath.Sqrt(p.I3);
                p.I4 = BitMath.Sqrt(p.I4);
                p.I5 = BitMath.Sqrt(p.I5);
                p.I6 = BitMath.Sqrt(p.I6);
                p.I7 = BitMath.Sqrt(p.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Sqrt_Basic(Vector128<int> value) {
                Vector128<int> rt = value;
                ref FixedArray4<int> p = ref Unsafe.As<Vector128<int>, FixedArray4<int>>(ref rt);
                p.I0 = BitMath.Sqrt(p.I0);
                p.I1 = BitMath.Sqrt(p.I1);
                p.I2 = BitMath.Sqrt(p.I2);
                p.I3 = BitMath.Sqrt(p.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Sqrt_Basic(Vector128<uint> value) {
                Vector128<uint> rt = value;
                ref FixedArray4<uint> p = ref Unsafe.As<Vector128<uint>, FixedArray4<uint>>(ref rt);
                p.I0 = BitMath.Sqrt(p.I0);
                p.I1 = BitMath.Sqrt(p.I1);
                p.I2 = BitMath.Sqrt(p.I2);
                p.I3 = BitMath.Sqrt(p.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Sqrt_Basic(Vector128<long> value) {
                Vector128<long> rt = value;
                ref FixedArray2<long> p = ref Unsafe.As<Vector128<long>, FixedArray2<long>>(ref rt);
                p.I0 = BitMath.Sqrt(p.I0);
                p.I1 = BitMath.Sqrt(p.I1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Sqrt_Basic(Vector128<ulong> value) {
                Vector128<ulong> rt = value;
                ref FixedArray2<ulong> p = ref Unsafe.As<Vector128<ulong>, FixedArray2<ulong>>(ref rt);
                p.I0 = BitMath.Sqrt(p.I0);
                p.I1 = BitMath.Sqrt(p.I1);
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Sqrt_Float(Vector128<sbyte> value) {
                Vector128<sbyte> mask = GreaterThan(Vector128<sbyte>.Zero, value); // 0>x = x<0.
                Vector128<sbyte> temp = Sqrt_Float(value.AsByte()).AsSByte();
                Vector128<sbyte> rt = AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Sqrt_Float(Vector128<byte> value) {
                // To float
                Widen(value, out Vector128<ushort> t0, out Vector128<ushort> t1);
                Widen(t0, out Vector128<uint> w0, out Vector128<uint> w1);
                Widen(t1, out Vector128<uint> w2, out Vector128<uint> w3);
                Vector128<float> src0 = ConvertToSingle(w0.AsInt32()); // On x86 platforms, Int32 typically has special instructions to speed up, which is faster than UInt32.
                Vector128<float> src1 = ConvertToSingle(w1.AsInt32());
                Vector128<float> src2 = ConvertToSingle(w2.AsInt32());
                Vector128<float> src3 = ConvertToSingle(w3.AsInt32());
                // Body
                Vector128<float> dst0 = Vector128.Sqrt(src0);
                Vector128<float> dst1 = Vector128.Sqrt(src1);
                Vector128<float> dst2 = Vector128.Sqrt(src2);
                Vector128<float> dst3 = Vector128.Sqrt(src3);
                // To int
                w0 = ConvertToInt32(dst0).AsUInt32();
                w1 = ConvertToInt32(dst1).AsUInt32();
                w2 = ConvertToInt32(dst2).AsUInt32();
                w3 = ConvertToInt32(dst3).AsUInt32();
                t0 = Narrow(w0, w1);
                t1 = Narrow(w2, w3);
                Vector128<byte> rt = Narrow(t0, t1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Sqrt_Float(Vector128<short> value) {
                Vector128<short> mask = GreaterThan(Vector128<short>.Zero, value); // 0>x = x<0.
                Vector128<short> temp = Sqrt_Float(value.AsUInt16()).AsInt16();
                Vector128<short> rt = AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Sqrt_Float(Vector128<ushort> value) {
                // To float
                Widen(value, out Vector128<uint> w0, out Vector128<uint> w1);
                Vector128<float> src0 = ConvertToSingle(w0.AsInt32());
                Vector128<float> src1 = ConvertToSingle(w1.AsInt32());
                // Body
                Vector128<float> dst0 = Vector128.Sqrt(src0);
                Vector128<float> dst1 = Vector128.Sqrt(src1);
                // To int
                w0 = ConvertToInt32(dst0).AsUInt32();
                w1 = ConvertToInt32(dst1).AsUInt32();
                Vector128<ushort> rt = Narrow(w0, w1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Sqrt_Float(Vector128<int> value) {
                Vector128<int> mask = GreaterThan(Vector128<int>.Zero, value); // 0>x = x<0.
                Vector128<int> temp = Sqrt_Float(value.AsUInt32()).AsInt32();
                Vector128<int> rt = AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Sqrt_Float(Vector128<uint> value) {
                // To float
                Widen(value, out Vector128<ulong> w0, out Vector128<ulong> w1);
                Vector128<double> src0 = ConvertToDouble_Range52(w0);
                Vector128<double> src1 = ConvertToDouble_Range52(w1);
                // Body
                Vector128<double> dst0 = Vector128.Sqrt(src0);
                Vector128<double> dst1 = Vector128.Sqrt(src1);
                // To int
                w0 = ConvertToUInt64_Range52(dst0);
                w1 = ConvertToUInt64_Range52(dst1);
                Vector128<uint> rt = Narrow(w0, w1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Sqrt_Float(Vector128<long> value) {
                Vector128<long> mask = GreaterThan(Vector128<long>.Zero, value); // 0>x = x<0.
                Vector128<long> temp = Sqrt_Float(value.AsUInt64()).AsInt64();
                Vector128<long> rt = AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Sqrt_Float(Vector128<ulong> value) {
                // To float
                Vector128<double> src0 = ConvertToDouble(value);
                // Body
                Vector128<double> dst0 = Vector128.Sqrt(src0);
                //Console.WriteLine(VectorTextUtil.Format("dst0:\t{0}", dst0));
                // To int
                Vector128<ulong> rt = ConvertToUInt64_Range52(dst0); // `Math.Ceiling(Math.Log2(Math.Sqrt(ulong.MaxValue))) = 32`. It less 52bit.
                //Console.WriteLine(VectorTextUtil.Format("Sqrt_Float:\t{0}", rt));
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits128.Subtract_AcceleratedTypes"/>
            public static TypeCodeFlags Subtract_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Subtract(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Subtract(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Subtract(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Subtract(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Subtract(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Subtract(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Subtract(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Subtract(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Subtract(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Subtract(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Subtract_Basic(Vector128<float> left, Vector128<float> right) {
                Unsafe.SkipInit(out Vector128<float> rt);
                ref float prt = ref Unsafe.As<Vector128<float>, float>(ref rt);
                ref float pleft = ref Unsafe.As<Vector128<float>, float>(ref left);
                ref float pright = ref Unsafe.As<Vector128<float>, float>(ref right);
                prt = pleft - pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) - Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) - Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) - Unsafe.Add(ref pright, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Subtract_Basic(Vector128<double> left, Vector128<double> right) {
                Unsafe.SkipInit(out Vector128<double> rt);
                ref double prt = ref Unsafe.As<Vector128<double>, double>(ref rt);
                ref double pleft = ref Unsafe.As<Vector128<double>, double>(ref left);
                ref double pright = ref Unsafe.As<Vector128<double>, double>(ref right);
                prt = pleft - pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) - Unsafe.Add(ref pright, 1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Subtract_Basic(Vector128<sbyte> left, Vector128<sbyte> right) {
                Unsafe.SkipInit(out Vector128<sbyte> rt);
                ref sbyte prt = ref Unsafe.As<Vector128<sbyte>, sbyte>(ref rt);
                ref sbyte pleft = ref Unsafe.As<Vector128<sbyte>, sbyte>(ref left);
                ref sbyte pright = ref Unsafe.As<Vector128<sbyte>, sbyte>(ref right);
                prt = (sbyte)(pleft - pright);
                Unsafe.Add(ref prt, 1) = (sbyte)(Unsafe.Add(ref pleft, 1) - Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (sbyte)(Unsafe.Add(ref pleft, 2) - Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (sbyte)(Unsafe.Add(ref pleft, 3) - Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (sbyte)(Unsafe.Add(ref pleft, 4) - Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (sbyte)(Unsafe.Add(ref pleft, 5) - Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (sbyte)(Unsafe.Add(ref pleft, 6) - Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (sbyte)(Unsafe.Add(ref pleft, 7) - Unsafe.Add(ref pright, 7));
                Unsafe.Add(ref prt, 8) = (sbyte)(Unsafe.Add(ref pleft, 8) - Unsafe.Add(ref pright, 8));
                Unsafe.Add(ref prt, 9) = (sbyte)(Unsafe.Add(ref pleft, 9) - Unsafe.Add(ref pright, 9));
                Unsafe.Add(ref prt, 10) = (sbyte)(Unsafe.Add(ref pleft, 10) - Unsafe.Add(ref pright, 10));
                Unsafe.Add(ref prt, 11) = (sbyte)(Unsafe.Add(ref pleft, 11) - Unsafe.Add(ref pright, 11));
                Unsafe.Add(ref prt, 12) = (sbyte)(Unsafe.Add(ref pleft, 12) - Unsafe.Add(ref pright, 12));
                Unsafe.Add(ref prt, 13) = (sbyte)(Unsafe.Add(ref pleft, 13) - Unsafe.Add(ref pright, 13));
                Unsafe.Add(ref prt, 14) = (sbyte)(Unsafe.Add(ref pleft, 14) - Unsafe.Add(ref pright, 14));
                Unsafe.Add(ref prt, 15) = (sbyte)(Unsafe.Add(ref pleft, 15) - Unsafe.Add(ref pright, 15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Subtract_Basic(Vector128<byte> left, Vector128<byte> right) {
                Unsafe.SkipInit(out Vector128<byte> rt);
                ref byte prt = ref Unsafe.As<Vector128<byte>, byte>(ref rt);
                ref byte pleft = ref Unsafe.As<Vector128<byte>, byte>(ref left);
                ref byte pright = ref Unsafe.As<Vector128<byte>, byte>(ref right);
                prt = (byte)(pleft - pright);
                Unsafe.Add(ref prt, 1) = (byte)(Unsafe.Add(ref pleft, 1) - Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (byte)(Unsafe.Add(ref pleft, 2) - Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (byte)(Unsafe.Add(ref pleft, 3) - Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (byte)(Unsafe.Add(ref pleft, 4) - Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (byte)(Unsafe.Add(ref pleft, 5) - Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (byte)(Unsafe.Add(ref pleft, 6) - Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (byte)(Unsafe.Add(ref pleft, 7) - Unsafe.Add(ref pright, 7));
                Unsafe.Add(ref prt, 8) = (byte)(Unsafe.Add(ref pleft, 8) - Unsafe.Add(ref pright, 8));
                Unsafe.Add(ref prt, 9) = (byte)(Unsafe.Add(ref pleft, 9) - Unsafe.Add(ref pright, 9));
                Unsafe.Add(ref prt, 10) = (byte)(Unsafe.Add(ref pleft, 10) - Unsafe.Add(ref pright, 10));
                Unsafe.Add(ref prt, 11) = (byte)(Unsafe.Add(ref pleft, 11) - Unsafe.Add(ref pright, 11));
                Unsafe.Add(ref prt, 12) = (byte)(Unsafe.Add(ref pleft, 12) - Unsafe.Add(ref pright, 12));
                Unsafe.Add(ref prt, 13) = (byte)(Unsafe.Add(ref pleft, 13) - Unsafe.Add(ref pright, 13));
                Unsafe.Add(ref prt, 14) = (byte)(Unsafe.Add(ref pleft, 14) - Unsafe.Add(ref pright, 14));
                Unsafe.Add(ref prt, 15) = (byte)(Unsafe.Add(ref pleft, 15) - Unsafe.Add(ref pright, 15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Subtract_Basic(Vector128<short> left, Vector128<short> right) {
                Unsafe.SkipInit(out Vector128<short> rt);
                ref short prt = ref Unsafe.As<Vector128<short>, short>(ref rt);
                ref short pleft = ref Unsafe.As<Vector128<short>, short>(ref left);
                ref short pright = ref Unsafe.As<Vector128<short>, short>(ref right);
                prt = (short)(pleft - pright);
                Unsafe.Add(ref prt, 1) = (short)(Unsafe.Add(ref pleft, 1) - Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (short)(Unsafe.Add(ref pleft, 2) - Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (short)(Unsafe.Add(ref pleft, 3) - Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (short)(Unsafe.Add(ref pleft, 4) - Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (short)(Unsafe.Add(ref pleft, 5) - Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (short)(Unsafe.Add(ref pleft, 6) - Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (short)(Unsafe.Add(ref pleft, 7) - Unsafe.Add(ref pright, 7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Subtract_Basic(Vector128<ushort> left, Vector128<ushort> right) {
                Unsafe.SkipInit(out Vector128<ushort> rt);
                ref ushort prt = ref Unsafe.As<Vector128<ushort>, ushort>(ref rt);
                ref ushort pleft = ref Unsafe.As<Vector128<ushort>, ushort>(ref left);
                ref ushort pright = ref Unsafe.As<Vector128<ushort>, ushort>(ref right);
                prt = (ushort)(pleft - pright);
                Unsafe.Add(ref prt, 1) = (ushort)(Unsafe.Add(ref pleft, 1) - Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (ushort)(Unsafe.Add(ref pleft, 2) - Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (ushort)(Unsafe.Add(ref pleft, 3) - Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (ushort)(Unsafe.Add(ref pleft, 4) - Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (ushort)(Unsafe.Add(ref pleft, 5) - Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (ushort)(Unsafe.Add(ref pleft, 6) - Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (ushort)(Unsafe.Add(ref pleft, 7) - Unsafe.Add(ref pright, 7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Subtract_Basic(Vector128<int> left, Vector128<int> right) {
                Unsafe.SkipInit(out Vector128<int> rt);
                ref int prt = ref Unsafe.As<Vector128<int>, int>(ref rt);
                ref int pleft = ref Unsafe.As<Vector128<int>, int>(ref left);
                ref int pright = ref Unsafe.As<Vector128<int>, int>(ref right);
                prt = pleft - pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) - Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) - Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) - Unsafe.Add(ref pright, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Subtract_Basic(Vector128<uint> left, Vector128<uint> right) {
                Unsafe.SkipInit(out Vector128<uint> rt);
                ref uint prt = ref Unsafe.As<Vector128<uint>, uint>(ref rt);
                ref uint pleft = ref Unsafe.As<Vector128<uint>, uint>(ref left);
                ref uint pright = ref Unsafe.As<Vector128<uint>, uint>(ref right);
                prt = pleft - pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) - Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) - Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) - Unsafe.Add(ref pright, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Subtract_Basic(Vector128<long> left, Vector128<long> right) {
                Unsafe.SkipInit(out Vector128<long> rt);
                ref long prt = ref Unsafe.As<Vector128<long>, long>(ref rt);
                ref long pleft = ref Unsafe.As<Vector128<long>, long>(ref left);
                ref long pright = ref Unsafe.As<Vector128<long>, long>(ref right);
                prt = pleft - pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) - Unsafe.Add(ref pright, 1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Subtract_Basic(Vector128<ulong> left, Vector128<ulong> right) {
                Unsafe.SkipInit(out Vector128<ulong> rt);
                ref ulong prt = ref Unsafe.As<Vector128<ulong>, ulong>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector128<ulong>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector128<ulong>, ulong>(ref right);
                prt = pleft - pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) - Unsafe.Add(ref pright, 1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Xor_AcceleratedTypes"/>
            public static TypeCodeFlags Xor_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Xor{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> Xor<T>(Vector128<T> left, Vector128<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector128.Xor(left, right);
#else
                return Xor_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits128.Xor{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> Xor_Basic<T>(Vector128<T> left, Vector128<T> right) where T : struct {
                Unsafe.SkipInit(out Vector128<T> rt);
                ref ulong prt = ref Unsafe.As<Vector128<T>, ulong>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector128<T>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector128<T>, ulong>(ref right);
                prt = pleft ^ pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) ^ Unsafe.Add(ref pright, 1);
                return rt;
            }


#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
