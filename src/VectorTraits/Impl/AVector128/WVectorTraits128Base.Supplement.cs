using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl.AVector128 {

    partial class WVectorTraits128Base {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.Abs_AcceleratedTypes"/>
            public static TypeCodeFlags Abs_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Abs(Vector128<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Abs(value);
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Abs(Vector128<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Abs(value);
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Abs(Vector128<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Abs(value);
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Abs(Vector128<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Abs(value);
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Abs(Vector128<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Abs(value);
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Abs(Vector128<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Abs(value);
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
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
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Add(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Add(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Add(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Add(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Add(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Add(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Add(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Add(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Add(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Add(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Add_Basic(Vector128<float> left, Vector128<float> right) {
                UnsafeUtil.SkipInit(out Vector128<float> rt);
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
                UnsafeUtil.SkipInit(out Vector128<double> rt);
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
                UnsafeUtil.SkipInit(out Vector128<sbyte> rt);
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
                UnsafeUtil.SkipInit(out Vector128<byte> rt);
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
                UnsafeUtil.SkipInit(out Vector128<short> rt);
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
                UnsafeUtil.SkipInit(out Vector128<ushort> rt);
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
                UnsafeUtil.SkipInit(out Vector128<int> rt);
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
                UnsafeUtil.SkipInit(out Vector128<uint> rt);
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
                UnsafeUtil.SkipInit(out Vector128<long> rt);
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
                UnsafeUtil.SkipInit(out Vector128<ulong> rt);
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
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.AndNot{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> AndNot<T>(Vector128<T> left, Vector128<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.AndNot(left, right);
#else
                return AndNot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.AndNot{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> AndNot_Basic<T>(Vector128<T> left, Vector128<T> right) where T : struct {
                UnsafeUtil.SkipInit(out Vector128<T> rt);
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
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.BitwiseAnd{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> BitwiseAnd<T>(Vector128<T> left, Vector128<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.BitwiseAnd(left, right);
#else
                return BitwiseAnd_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.BitwiseAnd{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> BitwiseAnd_Basic<T>(Vector128<T> left, Vector128<T> right) where T : struct {
                UnsafeUtil.SkipInit(out Vector128<T> rt);
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
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.BitwiseOr{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> BitwiseOr<T>(Vector128<T> left, Vector128<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.BitwiseOr(left, right);
#else
                return BitwiseOr_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.BitwiseOr{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> BitwiseOr_Basic<T>(Vector128<T> left, Vector128<T> right) where T : struct {
                UnsafeUtil.SkipInit(out Vector128<T> rt);
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
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect{T}(Vector128{T}, Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> ConditionalSelect<T>(Vector128<T> condition, Vector128<T> left, Vector128<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ConditionalSelect(condition, left, right);
#else
                return ConditionalSelect_Basic(condition, left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
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
                UnsafeUtil.SkipInit(out Vector128<T> rt);
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
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        // rt |= TypeCodeFlags.Single | TypeCodeFlags.Double; // Arm 32bit no hardware accelerated.
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Divide(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Divide(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Divide(left, right);
#else
                return Divide_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Divide(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Divide(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Divide(left, right);
#else
                return Divide_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Divide(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Divide_Basic(Vector128<float> left, Vector128<float> right) {
                UnsafeUtil.SkipInit(out Vector128<float> rt);
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
                UnsafeUtil.SkipInit(out Vector128<double> rt);
                ref double prt = ref Unsafe.As<Vector128<double>, double>(ref rt);
                ref double pleft = ref Unsafe.As<Vector128<double>, double>(ref left);
                ref double pright = ref Unsafe.As<Vector128<double>, double>(ref right);
                prt = pleft / pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) / Unsafe.Add(ref pright, 1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.GreaterThan_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThan_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> GreaterThan(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> GreaterThan(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> GreaterThan(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> GreaterThan(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> GreaterThan(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> GreaterThan(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> GreaterThan(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> GreaterThan(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> GreaterThan(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> GreaterThan(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> GreaterThan_Basic(Vector128<float> left, Vector128<float> right) {
                UnsafeUtil.SkipInit(out Vector128<float> rt);
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
                UnsafeUtil.SkipInit(out Vector128<double> rt);
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
                UnsafeUtil.SkipInit(out Vector128<sbyte> rt);
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
                UnsafeUtil.SkipInit(out Vector128<byte> rt);
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
                UnsafeUtil.SkipInit(out Vector128<short> rt);
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
                UnsafeUtil.SkipInit(out Vector128<ushort> rt);
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
                UnsafeUtil.SkipInit(out Vector128<int> rt);
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
                UnsafeUtil.SkipInit(out Vector128<uint> rt);
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
                UnsafeUtil.SkipInit(out Vector128<long> rt);
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
                UnsafeUtil.SkipInit(out Vector128<ulong> rt);
                ref long prt = ref Unsafe.As<Vector128<ulong>, long>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector128<ulong>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector128<ulong>, ulong>(ref right);
                prt = BitMath.ToInt32Mask(pleft > pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) > Unsafe.Add(ref pright, 1));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.LessThan_AcceleratedTypes"/>
            public static TypeCodeFlags LessThan_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> LessThan(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> LessThan(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> LessThan(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> LessThan(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> LessThan(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> LessThan(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> LessThan(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> LessThan(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> LessThan(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> LessThan(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> LessThan_Basic(Vector128<float> left, Vector128<float> right) {
                UnsafeUtil.SkipInit(out Vector128<float> rt);
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
                UnsafeUtil.SkipInit(out Vector128<double> rt);
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
                UnsafeUtil.SkipInit(out Vector128<sbyte> rt);
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
                UnsafeUtil.SkipInit(out Vector128<byte> rt);
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
                UnsafeUtil.SkipInit(out Vector128<short> rt);
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
                UnsafeUtil.SkipInit(out Vector128<ushort> rt);
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
                UnsafeUtil.SkipInit(out Vector128<int> rt);
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
                UnsafeUtil.SkipInit(out Vector128<uint> rt);
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
                UnsafeUtil.SkipInit(out Vector128<long> rt);
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
                UnsafeUtil.SkipInit(out Vector128<ulong> rt);
                ref long prt = ref Unsafe.As<Vector128<ulong>, long>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector128<ulong>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector128<ulong>, ulong>(ref right);
                prt = BitMath.ToInt32Mask(pleft < pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) < Unsafe.Add(ref pright, 1));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Max_AcceleratedTypes"/>
            public static TypeCodeFlags Max_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Max(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Max(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Max(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Max(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Max(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Max(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Max(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Max(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Max(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Max(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
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
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Min(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Min(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Min(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Min(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Min(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Min(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Min(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Min(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Min(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Min(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
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
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply_FullAcceleratedTypes"/>
            public static TypeCodeFlags Multiply_FullAcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Multiply(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Multiply(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Multiply(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Multiply(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Multiply(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Multiply(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Multiply(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Multiply(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Multiply(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Multiply(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Multiply_Basic(Vector128<float> left, Vector128<float> right) {
                UnsafeUtil.SkipInit(out Vector128<float> rt);
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
                UnsafeUtil.SkipInit(out Vector128<double> rt);
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
                UnsafeUtil.SkipInit(out Vector128<sbyte> rt);
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
                UnsafeUtil.SkipInit(out Vector128<byte> rt);
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
                UnsafeUtil.SkipInit(out Vector128<short> rt);
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
                UnsafeUtil.SkipInit(out Vector128<ushort> rt);
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
                UnsafeUtil.SkipInit(out Vector128<int> rt);
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
                UnsafeUtil.SkipInit(out Vector128<uint> rt);
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
                UnsafeUtil.SkipInit(out Vector128<long> rt);
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
                UnsafeUtil.SkipInit(out Vector128<ulong> rt);
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
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Negate(Vector128<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Negate(value);
#else
                return Negate_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Negate(Vector128<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Negate(value);
#else
                return Negate_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Negate(Vector128<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Negate(value);
#else
                return Negate_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Negate(Vector128<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Negate(value);
#else
                return Negate_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Negate(Vector128<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Negate(value);
#else
                return Negate_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Negate(Vector128<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Negate(value);
#else
                return Negate_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
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
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.OnesComplement{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> OnesComplement<T>(Vector128<T> vector) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.OnesComplement(vector);
#else
                return OnesComplement_Basic(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
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


            /// <inheritdoc cref="IWVectorTraits128.Subtract_AcceleratedTypes"/>
            public static TypeCodeFlags Subtract_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Subtract(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Subtract(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Subtract(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Subtract(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Subtract(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Subtract(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Subtract(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Subtract(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Subtract(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Subtract(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Subtract_Basic(Vector128<float> left, Vector128<float> right) {
                UnsafeUtil.SkipInit(out Vector128<float> rt);
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
                UnsafeUtil.SkipInit(out Vector128<double> rt);
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
                UnsafeUtil.SkipInit(out Vector128<sbyte> rt);
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
                UnsafeUtil.SkipInit(out Vector128<byte> rt);
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
                UnsafeUtil.SkipInit(out Vector128<short> rt);
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
                UnsafeUtil.SkipInit(out Vector128<ushort> rt);
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
                UnsafeUtil.SkipInit(out Vector128<int> rt);
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
                UnsafeUtil.SkipInit(out Vector128<uint> rt);
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
                UnsafeUtil.SkipInit(out Vector128<long> rt);
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
                UnsafeUtil.SkipInit(out Vector128<ulong> rt);
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
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Xor{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> Xor<T>(Vector128<T> left, Vector128<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.Xor(left, right);
#else
                return Xor_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.Xor{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> Xor_Basic<T>(Vector128<T> left, Vector128<T> right) where T : struct {
                UnsafeUtil.SkipInit(out Vector128<T> rt);
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
