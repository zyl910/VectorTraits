using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl.AVector256 {
    partial class WVectorTraits256Base {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.Abs_AcceleratedTypes"/>
            public static TypeCodeFlags Abs_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Abs(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Abs(value);
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Abs(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Abs(value);
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Abs(Vector256<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Abs(value);
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Abs(Vector256<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Abs(value);
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Abs(Vector256<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Abs(value);
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Abs(Vector256<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Abs(value);
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Abs_Basic(Vector256<float> value) {
                Vector256<float> rt = value;
                ref float p = ref Unsafe.As<Vector256<float>, float>(ref rt);
                p = Math.Abs(p);
                Unsafe.Add(ref p, 1) = Math.Abs(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = Math.Abs(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = Math.Abs(Unsafe.Add(ref p, 3));
                Unsafe.Add(ref p, 4) = Math.Abs(Unsafe.Add(ref p, 4));
                Unsafe.Add(ref p, 5) = Math.Abs(Unsafe.Add(ref p, 5));
                Unsafe.Add(ref p, 6) = Math.Abs(Unsafe.Add(ref p, 6));
                Unsafe.Add(ref p, 7) = Math.Abs(Unsafe.Add(ref p, 7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Abs_Basic(Vector256<double> value) {
                Vector256<double> rt = value;
                ref double p = ref Unsafe.As<Vector256<double>, double>(ref rt);
                p = Math.Abs(p);
                Unsafe.Add(ref p, 1) = Math.Abs(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = Math.Abs(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = Math.Abs(Unsafe.Add(ref p, 3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Abs_Basic(Vector256<sbyte> value) {
                Vector256<sbyte> rt = value;
                ref sbyte p = ref Unsafe.As<Vector256<sbyte>, sbyte>(ref rt);
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
                Unsafe.Add(ref p, 16) = BitMath.Abs(Unsafe.Add(ref p, 16));
                Unsafe.Add(ref p, 17) = BitMath.Abs(Unsafe.Add(ref p, 17));
                Unsafe.Add(ref p, 18) = BitMath.Abs(Unsafe.Add(ref p, 18));
                Unsafe.Add(ref p, 19) = BitMath.Abs(Unsafe.Add(ref p, 19));
                Unsafe.Add(ref p, 20) = BitMath.Abs(Unsafe.Add(ref p, 20));
                Unsafe.Add(ref p, 21) = BitMath.Abs(Unsafe.Add(ref p, 21));
                Unsafe.Add(ref p, 22) = BitMath.Abs(Unsafe.Add(ref p, 22));
                Unsafe.Add(ref p, 23) = BitMath.Abs(Unsafe.Add(ref p, 23));
                Unsafe.Add(ref p, 24) = BitMath.Abs(Unsafe.Add(ref p, 24));
                Unsafe.Add(ref p, 25) = BitMath.Abs(Unsafe.Add(ref p, 25));
                Unsafe.Add(ref p, 26) = BitMath.Abs(Unsafe.Add(ref p, 26));
                Unsafe.Add(ref p, 27) = BitMath.Abs(Unsafe.Add(ref p, 27));
                Unsafe.Add(ref p, 28) = BitMath.Abs(Unsafe.Add(ref p, 28));
                Unsafe.Add(ref p, 29) = BitMath.Abs(Unsafe.Add(ref p, 29));
                Unsafe.Add(ref p, 30) = BitMath.Abs(Unsafe.Add(ref p, 30));
                Unsafe.Add(ref p, 31) = BitMath.Abs(Unsafe.Add(ref p, 31));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Abs_Basic(Vector256<short> value) {
                Vector256<short> rt = value;
                ref short p = ref Unsafe.As<Vector256<short>, short>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Abs_Basic(Vector256<int> value) {
                Vector256<int> rt = value;
                ref int p = ref Unsafe.As<Vector256<int>, int>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Abs_Basic(Vector256<long> value) {
                Vector256<long> rt = value;
                ref long p = ref Unsafe.As<Vector256<long>, long>(ref rt);
                p = BitMath.Abs(p);
                Unsafe.Add(ref p, 1) = BitMath.Abs(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = BitMath.Abs(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = BitMath.Abs(Unsafe.Add(ref p, 3));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Add_AcceleratedTypes"/>
            public static TypeCodeFlags Add_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Add(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Add(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Add(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Add(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Add(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Add(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Add(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Add(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Add(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Add(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Add_Basic(Vector256<float> left, Vector256<float> right) {
                UnsafeEx.SkipInit(out Vector256<float> rt);
                ref float prt = ref Unsafe.As<Vector256<float>, float>(ref rt);
                ref float pleft = ref Unsafe.As<Vector256<float>, float>(ref left);
                ref float pright = ref Unsafe.As<Vector256<float>, float>(ref right);
                prt = pleft + pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) + Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) + Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) + Unsafe.Add(ref pright, 3);
                Unsafe.Add(ref prt, 4) = Unsafe.Add(ref pleft, 4) + Unsafe.Add(ref pright, 4);
                Unsafe.Add(ref prt, 5) = Unsafe.Add(ref pleft, 5) + Unsafe.Add(ref pright, 5);
                Unsafe.Add(ref prt, 6) = Unsafe.Add(ref pleft, 6) + Unsafe.Add(ref pright, 6);
                Unsafe.Add(ref prt, 7) = Unsafe.Add(ref pleft, 7) + Unsafe.Add(ref pright, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Add_Basic(Vector256<double> left, Vector256<double> right) {
                UnsafeEx.SkipInit(out Vector256<double> rt);
                ref double prt = ref Unsafe.As<Vector256<double>, double>(ref rt);
                ref double pleft = ref Unsafe.As<Vector256<double>, double>(ref left);
                ref double pright = ref Unsafe.As<Vector256<double>, double>(ref right);
                prt = pleft + pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) + Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) + Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) + Unsafe.Add(ref pright, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Add_Basic(Vector256<sbyte> left, Vector256<sbyte> right) {
                UnsafeEx.SkipInit(out Vector256<sbyte> rt);
                ref sbyte prt = ref Unsafe.As<Vector256<sbyte>, sbyte>(ref rt);
                ref sbyte pleft = ref Unsafe.As<Vector256<sbyte>, sbyte>(ref left);
                ref sbyte pright = ref Unsafe.As<Vector256<sbyte>, sbyte>(ref right);
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
                Unsafe.Add(ref prt, 16) = (sbyte)(Unsafe.Add(ref pleft, 16) + Unsafe.Add(ref pright, 16));
                Unsafe.Add(ref prt, 17) = (sbyte)(Unsafe.Add(ref pleft, 17) + Unsafe.Add(ref pright, 17));
                Unsafe.Add(ref prt, 18) = (sbyte)(Unsafe.Add(ref pleft, 18) + Unsafe.Add(ref pright, 18));
                Unsafe.Add(ref prt, 19) = (sbyte)(Unsafe.Add(ref pleft, 19) + Unsafe.Add(ref pright, 19));
                Unsafe.Add(ref prt, 20) = (sbyte)(Unsafe.Add(ref pleft, 20) + Unsafe.Add(ref pright, 20));
                Unsafe.Add(ref prt, 21) = (sbyte)(Unsafe.Add(ref pleft, 21) + Unsafe.Add(ref pright, 21));
                Unsafe.Add(ref prt, 22) = (sbyte)(Unsafe.Add(ref pleft, 22) + Unsafe.Add(ref pright, 22));
                Unsafe.Add(ref prt, 23) = (sbyte)(Unsafe.Add(ref pleft, 23) + Unsafe.Add(ref pright, 23));
                Unsafe.Add(ref prt, 24) = (sbyte)(Unsafe.Add(ref pleft, 24) + Unsafe.Add(ref pright, 24));
                Unsafe.Add(ref prt, 25) = (sbyte)(Unsafe.Add(ref pleft, 25) + Unsafe.Add(ref pright, 25));
                Unsafe.Add(ref prt, 26) = (sbyte)(Unsafe.Add(ref pleft, 26) + Unsafe.Add(ref pright, 26));
                Unsafe.Add(ref prt, 27) = (sbyte)(Unsafe.Add(ref pleft, 27) + Unsafe.Add(ref pright, 27));
                Unsafe.Add(ref prt, 28) = (sbyte)(Unsafe.Add(ref pleft, 28) + Unsafe.Add(ref pright, 28));
                Unsafe.Add(ref prt, 29) = (sbyte)(Unsafe.Add(ref pleft, 29) + Unsafe.Add(ref pright, 29));
                Unsafe.Add(ref prt, 30) = (sbyte)(Unsafe.Add(ref pleft, 30) + Unsafe.Add(ref pright, 30));
                Unsafe.Add(ref prt, 31) = (sbyte)(Unsafe.Add(ref pleft, 31) + Unsafe.Add(ref pright, 31));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Add_Basic(Vector256<byte> left, Vector256<byte> right) {
                UnsafeEx.SkipInit(out Vector256<byte> rt);
                ref byte prt = ref Unsafe.As<Vector256<byte>, byte>(ref rt);
                ref byte pleft = ref Unsafe.As<Vector256<byte>, byte>(ref left);
                ref byte pright = ref Unsafe.As<Vector256<byte>, byte>(ref right);
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
                Unsafe.Add(ref prt, 16) = (byte)(Unsafe.Add(ref pleft, 16) + Unsafe.Add(ref pright, 16));
                Unsafe.Add(ref prt, 17) = (byte)(Unsafe.Add(ref pleft, 17) + Unsafe.Add(ref pright, 17));
                Unsafe.Add(ref prt, 18) = (byte)(Unsafe.Add(ref pleft, 18) + Unsafe.Add(ref pright, 18));
                Unsafe.Add(ref prt, 19) = (byte)(Unsafe.Add(ref pleft, 19) + Unsafe.Add(ref pright, 19));
                Unsafe.Add(ref prt, 20) = (byte)(Unsafe.Add(ref pleft, 20) + Unsafe.Add(ref pright, 20));
                Unsafe.Add(ref prt, 21) = (byte)(Unsafe.Add(ref pleft, 21) + Unsafe.Add(ref pright, 21));
                Unsafe.Add(ref prt, 22) = (byte)(Unsafe.Add(ref pleft, 22) + Unsafe.Add(ref pright, 22));
                Unsafe.Add(ref prt, 23) = (byte)(Unsafe.Add(ref pleft, 23) + Unsafe.Add(ref pright, 23));
                Unsafe.Add(ref prt, 24) = (byte)(Unsafe.Add(ref pleft, 24) + Unsafe.Add(ref pright, 24));
                Unsafe.Add(ref prt, 25) = (byte)(Unsafe.Add(ref pleft, 25) + Unsafe.Add(ref pright, 25));
                Unsafe.Add(ref prt, 26) = (byte)(Unsafe.Add(ref pleft, 26) + Unsafe.Add(ref pright, 26));
                Unsafe.Add(ref prt, 27) = (byte)(Unsafe.Add(ref pleft, 27) + Unsafe.Add(ref pright, 27));
                Unsafe.Add(ref prt, 28) = (byte)(Unsafe.Add(ref pleft, 28) + Unsafe.Add(ref pright, 28));
                Unsafe.Add(ref prt, 29) = (byte)(Unsafe.Add(ref pleft, 29) + Unsafe.Add(ref pright, 29));
                Unsafe.Add(ref prt, 30) = (byte)(Unsafe.Add(ref pleft, 30) + Unsafe.Add(ref pright, 30));
                Unsafe.Add(ref prt, 31) = (byte)(Unsafe.Add(ref pleft, 31) + Unsafe.Add(ref pright, 31));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Add_Basic(Vector256<short> left, Vector256<short> right) {
                UnsafeEx.SkipInit(out Vector256<short> rt);
                ref short prt = ref Unsafe.As<Vector256<short>, short>(ref rt);
                ref short pleft = ref Unsafe.As<Vector256<short>, short>(ref left);
                ref short pright = ref Unsafe.As<Vector256<short>, short>(ref right);
                prt = (short)(pleft + pright);
                Unsafe.Add(ref prt, 1) = (short)(Unsafe.Add(ref pleft, 1) + Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (short)(Unsafe.Add(ref pleft, 2) + Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (short)(Unsafe.Add(ref pleft, 3) + Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (short)(Unsafe.Add(ref pleft, 4) + Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (short)(Unsafe.Add(ref pleft, 5) + Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (short)(Unsafe.Add(ref pleft, 6) + Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (short)(Unsafe.Add(ref pleft, 7) + Unsafe.Add(ref pright, 7));
                Unsafe.Add(ref prt, 8) = (short)(Unsafe.Add(ref pleft, 8) + Unsafe.Add(ref pright, 8));
                Unsafe.Add(ref prt, 9) = (short)(Unsafe.Add(ref pleft, 9) + Unsafe.Add(ref pright, 9));
                Unsafe.Add(ref prt, 10) = (short)(Unsafe.Add(ref pleft, 10) + Unsafe.Add(ref pright, 10));
                Unsafe.Add(ref prt, 11) = (short)(Unsafe.Add(ref pleft, 11) + Unsafe.Add(ref pright, 11));
                Unsafe.Add(ref prt, 12) = (short)(Unsafe.Add(ref pleft, 12) + Unsafe.Add(ref pright, 12));
                Unsafe.Add(ref prt, 13) = (short)(Unsafe.Add(ref pleft, 13) + Unsafe.Add(ref pright, 13));
                Unsafe.Add(ref prt, 14) = (short)(Unsafe.Add(ref pleft, 14) + Unsafe.Add(ref pright, 14));
                Unsafe.Add(ref prt, 15) = (short)(Unsafe.Add(ref pleft, 15) + Unsafe.Add(ref pright, 15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Add_Basic(Vector256<ushort> left, Vector256<ushort> right) {
                UnsafeEx.SkipInit(out Vector256<ushort> rt);
                ref ushort prt = ref Unsafe.As<Vector256<ushort>, ushort>(ref rt);
                ref ushort pleft = ref Unsafe.As<Vector256<ushort>, ushort>(ref left);
                ref ushort pright = ref Unsafe.As<Vector256<ushort>, ushort>(ref right);
                prt = (ushort)(pleft + pright);
                Unsafe.Add(ref prt, 1) = (ushort)(Unsafe.Add(ref pleft, 1) + Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (ushort)(Unsafe.Add(ref pleft, 2) + Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (ushort)(Unsafe.Add(ref pleft, 3) + Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (ushort)(Unsafe.Add(ref pleft, 4) + Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (ushort)(Unsafe.Add(ref pleft, 5) + Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (ushort)(Unsafe.Add(ref pleft, 6) + Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (ushort)(Unsafe.Add(ref pleft, 7) + Unsafe.Add(ref pright, 7));
                Unsafe.Add(ref prt, 8) = (ushort)(Unsafe.Add(ref pleft, 8) + Unsafe.Add(ref pright, 8));
                Unsafe.Add(ref prt, 9) = (ushort)(Unsafe.Add(ref pleft, 9) + Unsafe.Add(ref pright, 9));
                Unsafe.Add(ref prt, 10) = (ushort)(Unsafe.Add(ref pleft, 10) + Unsafe.Add(ref pright, 10));
                Unsafe.Add(ref prt, 11) = (ushort)(Unsafe.Add(ref pleft, 11) + Unsafe.Add(ref pright, 11));
                Unsafe.Add(ref prt, 12) = (ushort)(Unsafe.Add(ref pleft, 12) + Unsafe.Add(ref pright, 12));
                Unsafe.Add(ref prt, 13) = (ushort)(Unsafe.Add(ref pleft, 13) + Unsafe.Add(ref pright, 13));
                Unsafe.Add(ref prt, 14) = (ushort)(Unsafe.Add(ref pleft, 14) + Unsafe.Add(ref pright, 14));
                Unsafe.Add(ref prt, 15) = (ushort)(Unsafe.Add(ref pleft, 15) + Unsafe.Add(ref pright, 15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Add_Basic(Vector256<int> left, Vector256<int> right) {
                UnsafeEx.SkipInit(out Vector256<int> rt);
                ref int prt = ref Unsafe.As<Vector256<int>, int>(ref rt);
                ref int pleft = ref Unsafe.As<Vector256<int>, int>(ref left);
                ref int pright = ref Unsafe.As<Vector256<int>, int>(ref right);
                prt = pleft + pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) + Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) + Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) + Unsafe.Add(ref pright, 3);
                Unsafe.Add(ref prt, 4) = Unsafe.Add(ref pleft, 4) + Unsafe.Add(ref pright, 4);
                Unsafe.Add(ref prt, 5) = Unsafe.Add(ref pleft, 5) + Unsafe.Add(ref pright, 5);
                Unsafe.Add(ref prt, 6) = Unsafe.Add(ref pleft, 6) + Unsafe.Add(ref pright, 6);
                Unsafe.Add(ref prt, 7) = Unsafe.Add(ref pleft, 7) + Unsafe.Add(ref pright, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Add_Basic(Vector256<uint> left, Vector256<uint> right) {
                UnsafeEx.SkipInit(out Vector256<uint> rt);
                ref uint prt = ref Unsafe.As<Vector256<uint>, uint>(ref rt);
                ref uint pleft = ref Unsafe.As<Vector256<uint>, uint>(ref left);
                ref uint pright = ref Unsafe.As<Vector256<uint>, uint>(ref right);
                prt = pleft + pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) + Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) + Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) + Unsafe.Add(ref pright, 3);
                Unsafe.Add(ref prt, 4) = Unsafe.Add(ref pleft, 4) + Unsafe.Add(ref pright, 4);
                Unsafe.Add(ref prt, 5) = Unsafe.Add(ref pleft, 5) + Unsafe.Add(ref pright, 5);
                Unsafe.Add(ref prt, 6) = Unsafe.Add(ref pleft, 6) + Unsafe.Add(ref pright, 6);
                Unsafe.Add(ref prt, 7) = Unsafe.Add(ref pleft, 7) + Unsafe.Add(ref pright, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Add_Basic(Vector256<long> left, Vector256<long> right) {
                UnsafeEx.SkipInit(out Vector256<long> rt);
                ref long prt = ref Unsafe.As<Vector256<long>, long>(ref rt);
                ref long pleft = ref Unsafe.As<Vector256<long>, long>(ref left);
                ref long pright = ref Unsafe.As<Vector256<long>, long>(ref right);
                prt = pleft + pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) + Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) + Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) + Unsafe.Add(ref pright, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Add_Basic(Vector256<ulong> left, Vector256<ulong> right) {
                UnsafeEx.SkipInit(out Vector256<ulong> rt);
                ref ulong prt = ref Unsafe.As<Vector256<ulong>, ulong>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector256<ulong>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector256<ulong>, ulong>(ref right);
                prt = pleft + pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) + Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) + Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) + Unsafe.Add(ref pright, 3);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.AndNot_AcceleratedTypes"/>
            public static TypeCodeFlags AndNot_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.AndNot{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> AndNot<T>(Vector256<T> left, Vector256<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.AndNot(left, right);
#else
                return AndNot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.AndNot{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> AndNot_Basic<T>(Vector256<T> left, Vector256<T> right) where T : struct {
                UnsafeEx.SkipInit(out Vector256<T> rt);
                ref ulong prt = ref Unsafe.As<Vector256<T>, ulong>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector256<T>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector256<T>, ulong>(ref right);
                prt = pleft & ~pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) & ~Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) & ~Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) & ~Unsafe.Add(ref pright, 3);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.BitwiseAnd_AcceleratedTypes"/>
            public static TypeCodeFlags BitwiseAnd_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.BitwiseAnd{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> BitwiseAnd<T>(Vector256<T> left, Vector256<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.BitwiseAnd(left, right);
#else
                return BitwiseAnd_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.BitwiseAnd{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> BitwiseAnd_Basic<T>(Vector256<T> left, Vector256<T> right) where T : struct {
                UnsafeEx.SkipInit(out Vector256<T> rt);
                ref ulong prt = ref Unsafe.As<Vector256<T>, ulong>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector256<T>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector256<T>, ulong>(ref right);
                prt = pleft & pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) & Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) & Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) & Unsafe.Add(ref pright, 3);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.BitwiseOr_AcceleratedTypes"/>
            public static TypeCodeFlags BitwiseOr_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.BitwiseOr{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> BitwiseOr<T>(Vector256<T> left, Vector256<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.BitwiseOr(left, right);
#else
                return BitwiseOr_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.BitwiseOr{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> BitwiseOr_Basic<T>(Vector256<T> left, Vector256<T> right) where T : struct {
                UnsafeEx.SkipInit(out Vector256<T> rt);
                ref ulong prt = ref Unsafe.As<Vector256<T>, ulong>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector256<T>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector256<T>, ulong>(ref right);
                prt = pleft | pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) | Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) | Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) | Unsafe.Add(ref pright, 3);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.ConditionalSelect_AcceleratedTypes"/>
            public static TypeCodeFlags ConditionalSelect_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ConditionalSelect{T}(Vector256{T}, Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> ConditionalSelect<T>(Vector256<T> condition, Vector256<T> left, Vector256<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ConditionalSelect(condition, left, right);
#else
                return ConditionalSelect_Basic(condition, left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            ///// <inheritdoc cref="IWVectorTraits256.ConditionalSelect(Vector256{int}, Vector256{float}, Vector256{float})"/>
            //[MethodImpl(MethodImplOptions.AggressiveInlining)]
            //public static Vector256<float> ConditionalSelect(Vector256<int> condition, Vector256<float> left, Vector256<float> right) {
            //    return ConditionalSelect<float>(condition.AsSingle(), left, right);
            //}

            ///// <inheritdoc cref="IWVectorTraits256.ConditionalSelect(Vector256{long}, Vector256{double}, Vector256{double})"/>
            //[MethodImpl(MethodImplOptions.AggressiveInlining)]
            //public static Vector256<double> ConditionalSelect(Vector256<long> condition, Vector256<double> left, Vector256<double> right) {
            //    return ConditionalSelect<double>(condition.AsDouble(), left, right);
            //}

            /// <inheritdoc cref="IWVectorTraits256.ConditionalSelect{T}(Vector256{T}, Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> ConditionalSelect_Basic<T>(Vector256<T> condition, Vector256<T> left, Vector256<T> right) where T : struct {
                UnsafeEx.SkipInit(out Vector256<T> rt);
                ref ulong pcondition = ref Unsafe.As<Vector256<T>, ulong>(ref condition);
                ref ulong pleft = ref Unsafe.As<Vector256<T>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector256<T>, ulong>(ref right);
                ref ulong prt = ref Unsafe.As<Vector256<T>, ulong>(ref rt);
                // result = (left & condition) | (right & ~condition);
                prt = (pleft & pcondition) | (pright & ~pcondition);
                Unsafe.Add(ref prt, 1) = (Unsafe.Add(ref pleft, 1) & Unsafe.Add(ref pcondition, 1)) | (Unsafe.Add(ref pright, 1) & ~Unsafe.Add(ref pcondition, 1));
                Unsafe.Add(ref prt, 2) = (Unsafe.Add(ref pleft, 2) & Unsafe.Add(ref pcondition, 2)) | (Unsafe.Add(ref pright, 2) & ~Unsafe.Add(ref pcondition, 2));
                Unsafe.Add(ref prt, 3) = (Unsafe.Add(ref pleft, 3) & Unsafe.Add(ref pcondition, 3)) | (Unsafe.Add(ref pright, 3) & ~Unsafe.Add(ref pcondition, 3));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Divide_AcceleratedTypes"/>
            public static TypeCodeFlags Divide_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Divide(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Divide(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Divide(left, right);
#else
                return Divide_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Divide(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Divide(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Divide(left, right);
#else
                return Divide_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Divide(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Divide_Basic(Vector256<float> left, Vector256<float> right) {
                UnsafeEx.SkipInit(out Vector256<float> rt);
                ref float prt = ref Unsafe.As<Vector256<float>, float>(ref rt);
                ref float pleft = ref Unsafe.As<Vector256<float>, float>(ref left);
                ref float pright = ref Unsafe.As<Vector256<float>, float>(ref right);
                prt = pleft / pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) / Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) / Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) / Unsafe.Add(ref pright, 3);
                Unsafe.Add(ref prt, 4) = Unsafe.Add(ref pleft, 4) / Unsafe.Add(ref pright, 4);
                Unsafe.Add(ref prt, 5) = Unsafe.Add(ref pleft, 5) / Unsafe.Add(ref pright, 5);
                Unsafe.Add(ref prt, 6) = Unsafe.Add(ref pleft, 6) / Unsafe.Add(ref pright, 6);
                Unsafe.Add(ref prt, 7) = Unsafe.Add(ref pleft, 7) / Unsafe.Add(ref pright, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Divide(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Divide_Basic(Vector256<double> left, Vector256<double> right) {
                UnsafeEx.SkipInit(out Vector256<double> rt);
                ref double prt = ref Unsafe.As<Vector256<double>, double>(ref rt);
                ref double pleft = ref Unsafe.As<Vector256<double>, double>(ref left);
                ref double pright = ref Unsafe.As<Vector256<double>, double>(ref right);
                prt = pleft / pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) / Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) / Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) / Unsafe.Add(ref pright, 3);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.GreaterThan_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThan_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> GreaterThan(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> GreaterThan(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> GreaterThan(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> GreaterThan(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> GreaterThan(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> GreaterThan(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> GreaterThan(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> GreaterThan(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> GreaterThan(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> GreaterThan(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> GreaterThan_Basic(Vector256<float> left, Vector256<float> right) {
                UnsafeEx.SkipInit(out Vector256<float> rt);
                ref int prt = ref Unsafe.As<Vector256<float>, int>(ref rt);
                ref float pleft = ref Unsafe.As<Vector256<float>, float>(ref left);
                ref float pright = ref Unsafe.As<Vector256<float>, float>(ref right);
                prt = BitMath.ToInt32Mask(pleft > pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) > Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) > Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) > Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 4) > Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 5) > Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 6) > Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 7) > Unsafe.Add(ref pright, 7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> GreaterThan_Basic(Vector256<double> left, Vector256<double> right) {
                UnsafeEx.SkipInit(out Vector256<double> rt);
                ref long prt = ref Unsafe.As<Vector256<double>, long>(ref rt);
                ref double pleft = ref Unsafe.As<Vector256<double>, double>(ref left);
                ref double pright = ref Unsafe.As<Vector256<double>, double>(ref right);
                prt = BitMath.ToInt32Mask(pleft > pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) > Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) > Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) > Unsafe.Add(ref pright, 3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> GreaterThan_Basic(Vector256<sbyte> left, Vector256<sbyte> right) {
                UnsafeEx.SkipInit(out Vector256<sbyte> rt);
                ref sbyte prt = ref Unsafe.As<Vector256<sbyte>, sbyte>(ref rt);
                ref sbyte pleft = ref Unsafe.As<Vector256<sbyte>, sbyte>(ref left);
                ref sbyte pright = ref Unsafe.As<Vector256<sbyte>, sbyte>(ref right);
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
                Unsafe.Add(ref prt, 16) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 16) > Unsafe.Add(ref pright, 16));
                Unsafe.Add(ref prt, 17) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 17) > Unsafe.Add(ref pright, 17));
                Unsafe.Add(ref prt, 18) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 18) > Unsafe.Add(ref pright, 18));
                Unsafe.Add(ref prt, 19) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 19) > Unsafe.Add(ref pright, 19));
                Unsafe.Add(ref prt, 20) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 20) > Unsafe.Add(ref pright, 20));
                Unsafe.Add(ref prt, 21) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 21) > Unsafe.Add(ref pright, 21));
                Unsafe.Add(ref prt, 22) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 22) > Unsafe.Add(ref pright, 22));
                Unsafe.Add(ref prt, 23) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 23) > Unsafe.Add(ref pright, 23));
                Unsafe.Add(ref prt, 24) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 24) > Unsafe.Add(ref pright, 24));
                Unsafe.Add(ref prt, 25) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 25) > Unsafe.Add(ref pright, 25));
                Unsafe.Add(ref prt, 26) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 26) > Unsafe.Add(ref pright, 26));
                Unsafe.Add(ref prt, 27) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 27) > Unsafe.Add(ref pright, 27));
                Unsafe.Add(ref prt, 28) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 28) > Unsafe.Add(ref pright, 28));
                Unsafe.Add(ref prt, 29) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 29) > Unsafe.Add(ref pright, 29));
                Unsafe.Add(ref prt, 30) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 30) > Unsafe.Add(ref pright, 30));
                Unsafe.Add(ref prt, 31) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 31) > Unsafe.Add(ref pright, 31));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> GreaterThan_Basic(Vector256<byte> left, Vector256<byte> right) {
                UnsafeEx.SkipInit(out Vector256<byte> rt);
                ref sbyte prt = ref Unsafe.As<Vector256<byte>, sbyte>(ref rt);
                ref byte pleft = ref Unsafe.As<Vector256<byte>, byte>(ref left);
                ref byte pright = ref Unsafe.As<Vector256<byte>, byte>(ref right);
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
                Unsafe.Add(ref prt, 16) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 16) > Unsafe.Add(ref pright, 16));
                Unsafe.Add(ref prt, 17) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 17) > Unsafe.Add(ref pright, 17));
                Unsafe.Add(ref prt, 18) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 18) > Unsafe.Add(ref pright, 18));
                Unsafe.Add(ref prt, 19) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 19) > Unsafe.Add(ref pright, 19));
                Unsafe.Add(ref prt, 20) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 20) > Unsafe.Add(ref pright, 20));
                Unsafe.Add(ref prt, 21) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 21) > Unsafe.Add(ref pright, 21));
                Unsafe.Add(ref prt, 22) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 22) > Unsafe.Add(ref pright, 22));
                Unsafe.Add(ref prt, 23) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 23) > Unsafe.Add(ref pright, 23));
                Unsafe.Add(ref prt, 24) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 24) > Unsafe.Add(ref pright, 24));
                Unsafe.Add(ref prt, 25) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 25) > Unsafe.Add(ref pright, 25));
                Unsafe.Add(ref prt, 26) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 26) > Unsafe.Add(ref pright, 26));
                Unsafe.Add(ref prt, 27) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 27) > Unsafe.Add(ref pright, 27));
                Unsafe.Add(ref prt, 28) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 28) > Unsafe.Add(ref pright, 28));
                Unsafe.Add(ref prt, 29) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 29) > Unsafe.Add(ref pright, 29));
                Unsafe.Add(ref prt, 30) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 30) > Unsafe.Add(ref pright, 30));
                Unsafe.Add(ref prt, 31) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 31) > Unsafe.Add(ref pright, 31));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> GreaterThan_Basic(Vector256<short> left, Vector256<short> right) {
                UnsafeEx.SkipInit(out Vector256<short> rt);
                ref short prt = ref Unsafe.As<Vector256<short>, short>(ref rt);
                ref short pleft = ref Unsafe.As<Vector256<short>, short>(ref left);
                ref short pright = ref Unsafe.As<Vector256<short>, short>(ref right);
                prt = (short)BitMath.ToInt32Mask(pleft > pright);
                Unsafe.Add(ref prt, 1) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) > Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) > Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) > Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 4) > Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 5) > Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 6) > Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 7) > Unsafe.Add(ref pright, 7));
                Unsafe.Add(ref prt, 8) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 8) > Unsafe.Add(ref pright, 8));
                Unsafe.Add(ref prt, 9) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 9) > Unsafe.Add(ref pright, 9));
                Unsafe.Add(ref prt, 10) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 10) > Unsafe.Add(ref pright, 10));
                Unsafe.Add(ref prt, 11) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 11) > Unsafe.Add(ref pright, 11));
                Unsafe.Add(ref prt, 12) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 12) > Unsafe.Add(ref pright, 12));
                Unsafe.Add(ref prt, 13) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 13) > Unsafe.Add(ref pright, 13));
                Unsafe.Add(ref prt, 14) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 14) > Unsafe.Add(ref pright, 14));
                Unsafe.Add(ref prt, 15) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 15) > Unsafe.Add(ref pright, 15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> GreaterThan_Basic(Vector256<ushort> left, Vector256<ushort> right) {
                UnsafeEx.SkipInit(out Vector256<ushort> rt);
                ref short prt = ref Unsafe.As<Vector256<ushort>, short>(ref rt);
                ref ushort pleft = ref Unsafe.As<Vector256<ushort>, ushort>(ref left);
                ref ushort pright = ref Unsafe.As<Vector256<ushort>, ushort>(ref right);
                prt = (short)BitMath.ToInt32Mask(pleft > pright);
                Unsafe.Add(ref prt, 1) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) > Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) > Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) > Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 4) > Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 5) > Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 6) > Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 7) > Unsafe.Add(ref pright, 7));
                Unsafe.Add(ref prt, 8) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 8) > Unsafe.Add(ref pright, 8));
                Unsafe.Add(ref prt, 9) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 9) > Unsafe.Add(ref pright, 9));
                Unsafe.Add(ref prt, 10) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 10) > Unsafe.Add(ref pright, 10));
                Unsafe.Add(ref prt, 11) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 11) > Unsafe.Add(ref pright, 11));
                Unsafe.Add(ref prt, 12) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 12) > Unsafe.Add(ref pright, 12));
                Unsafe.Add(ref prt, 13) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 13) > Unsafe.Add(ref pright, 13));
                Unsafe.Add(ref prt, 14) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 14) > Unsafe.Add(ref pright, 14));
                Unsafe.Add(ref prt, 15) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 15) > Unsafe.Add(ref pright, 15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> GreaterThan_Basic(Vector256<int> left, Vector256<int> right) {
                UnsafeEx.SkipInit(out Vector256<int> rt);
                ref int prt = ref Unsafe.As<Vector256<int>, int>(ref rt);
                ref int pleft = ref Unsafe.As<Vector256<int>, int>(ref left);
                ref int pright = ref Unsafe.As<Vector256<int>, int>(ref right);
                prt = BitMath.ToInt32Mask(pleft > pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) > Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) > Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) > Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 4) > Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 5) > Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 6) > Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 7) > Unsafe.Add(ref pright, 7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> GreaterThan_Basic(Vector256<uint> left, Vector256<uint> right) {
                UnsafeEx.SkipInit(out Vector256<uint> rt);
                ref int prt = ref Unsafe.As<Vector256<uint>, int>(ref rt);
                ref uint pleft = ref Unsafe.As<Vector256<uint>, uint>(ref left);
                ref uint pright = ref Unsafe.As<Vector256<uint>, uint>(ref right);
                prt = BitMath.ToInt32Mask(pleft > pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) > Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) > Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) > Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 4) > Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 5) > Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 6) > Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 7) > Unsafe.Add(ref pright, 7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> GreaterThan_Basic(Vector256<long> left, Vector256<long> right) {
                UnsafeEx.SkipInit(out Vector256<long> rt);
                ref long prt = ref Unsafe.As<Vector256<long>, long>(ref rt);
                ref long pleft = ref Unsafe.As<Vector256<long>, long>(ref left);
                ref long pright = ref Unsafe.As<Vector256<long>, long>(ref right);
                prt = BitMath.ToInt32Mask(pleft > pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) > Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) > Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) > Unsafe.Add(ref pright, 3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> GreaterThan_Basic(Vector256<ulong> left, Vector256<ulong> right) {
                UnsafeEx.SkipInit(out Vector256<ulong> rt);
                ref long prt = ref Unsafe.As<Vector256<ulong>, long>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector256<ulong>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector256<ulong>, ulong>(ref right);
                prt = BitMath.ToInt32Mask(pleft > pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) > Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) > Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) > Unsafe.Add(ref pright, 3));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.LessThan_AcceleratedTypes"/>
            public static TypeCodeFlags LessThan_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> LessThan(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> LessThan(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> LessThan(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> LessThan(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> LessThan(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> LessThan(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> LessThan(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> LessThan(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> LessThan(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> LessThan(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> LessThan_Basic(Vector256<float> left, Vector256<float> right) {
                UnsafeEx.SkipInit(out Vector256<float> rt);
                ref int prt = ref Unsafe.As<Vector256<float>, int>(ref rt);
                ref float pleft = ref Unsafe.As<Vector256<float>, float>(ref left);
                ref float pright = ref Unsafe.As<Vector256<float>, float>(ref right);
                prt = BitMath.ToInt32Mask(pleft < pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) < Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) < Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) < Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 4) < Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 5) < Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 6) < Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 7) < Unsafe.Add(ref pright, 7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> LessThan_Basic(Vector256<double> left, Vector256<double> right) {
                UnsafeEx.SkipInit(out Vector256<double> rt);
                ref long prt = ref Unsafe.As<Vector256<double>, long>(ref rt);
                ref double pleft = ref Unsafe.As<Vector256<double>, double>(ref left);
                ref double pright = ref Unsafe.As<Vector256<double>, double>(ref right);
                prt = BitMath.ToInt32Mask(pleft < pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) < Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) < Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) < Unsafe.Add(ref pright, 3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> LessThan_Basic(Vector256<sbyte> left, Vector256<sbyte> right) {
                UnsafeEx.SkipInit(out Vector256<sbyte> rt);
                ref sbyte prt = ref Unsafe.As<Vector256<sbyte>, sbyte>(ref rt);
                ref sbyte pleft = ref Unsafe.As<Vector256<sbyte>, sbyte>(ref left);
                ref sbyte pright = ref Unsafe.As<Vector256<sbyte>, sbyte>(ref right);
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
                Unsafe.Add(ref prt, 16) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 16) < Unsafe.Add(ref pright, 16));
                Unsafe.Add(ref prt, 17) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 17) < Unsafe.Add(ref pright, 17));
                Unsafe.Add(ref prt, 18) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 18) < Unsafe.Add(ref pright, 18));
                Unsafe.Add(ref prt, 19) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 19) < Unsafe.Add(ref pright, 19));
                Unsafe.Add(ref prt, 20) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 20) < Unsafe.Add(ref pright, 20));
                Unsafe.Add(ref prt, 21) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 21) < Unsafe.Add(ref pright, 21));
                Unsafe.Add(ref prt, 22) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 22) < Unsafe.Add(ref pright, 22));
                Unsafe.Add(ref prt, 23) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 23) < Unsafe.Add(ref pright, 23));
                Unsafe.Add(ref prt, 24) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 24) < Unsafe.Add(ref pright, 24));
                Unsafe.Add(ref prt, 25) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 25) < Unsafe.Add(ref pright, 25));
                Unsafe.Add(ref prt, 26) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 26) < Unsafe.Add(ref pright, 26));
                Unsafe.Add(ref prt, 27) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 27) < Unsafe.Add(ref pright, 27));
                Unsafe.Add(ref prt, 28) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 28) < Unsafe.Add(ref pright, 28));
                Unsafe.Add(ref prt, 29) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 29) < Unsafe.Add(ref pright, 29));
                Unsafe.Add(ref prt, 30) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 30) < Unsafe.Add(ref pright, 30));
                Unsafe.Add(ref prt, 31) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 31) < Unsafe.Add(ref pright, 31));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> LessThan_Basic(Vector256<byte> left, Vector256<byte> right) {
                UnsafeEx.SkipInit(out Vector256<byte> rt);
                ref sbyte prt = ref Unsafe.As<Vector256<byte>, sbyte>(ref rt);
                ref byte pleft = ref Unsafe.As<Vector256<byte>, byte>(ref left);
                ref byte pright = ref Unsafe.As<Vector256<byte>, byte>(ref right);
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
                Unsafe.Add(ref prt, 16) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 16) < Unsafe.Add(ref pright, 16));
                Unsafe.Add(ref prt, 17) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 17) < Unsafe.Add(ref pright, 17));
                Unsafe.Add(ref prt, 18) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 18) < Unsafe.Add(ref pright, 18));
                Unsafe.Add(ref prt, 19) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 19) < Unsafe.Add(ref pright, 19));
                Unsafe.Add(ref prt, 20) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 20) < Unsafe.Add(ref pright, 20));
                Unsafe.Add(ref prt, 21) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 21) < Unsafe.Add(ref pright, 21));
                Unsafe.Add(ref prt, 22) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 22) < Unsafe.Add(ref pright, 22));
                Unsafe.Add(ref prt, 23) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 23) < Unsafe.Add(ref pright, 23));
                Unsafe.Add(ref prt, 24) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 24) < Unsafe.Add(ref pright, 24));
                Unsafe.Add(ref prt, 25) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 25) < Unsafe.Add(ref pright, 25));
                Unsafe.Add(ref prt, 26) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 26) < Unsafe.Add(ref pright, 26));
                Unsafe.Add(ref prt, 27) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 27) < Unsafe.Add(ref pright, 27));
                Unsafe.Add(ref prt, 28) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 28) < Unsafe.Add(ref pright, 28));
                Unsafe.Add(ref prt, 29) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 29) < Unsafe.Add(ref pright, 29));
                Unsafe.Add(ref prt, 30) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 30) < Unsafe.Add(ref pright, 30));
                Unsafe.Add(ref prt, 31) = (sbyte)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 31) < Unsafe.Add(ref pright, 31));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> LessThan_Basic(Vector256<short> left, Vector256<short> right) {
                UnsafeEx.SkipInit(out Vector256<short> rt);
                ref short prt = ref Unsafe.As<Vector256<short>, short>(ref rt);
                ref short pleft = ref Unsafe.As<Vector256<short>, short>(ref left);
                ref short pright = ref Unsafe.As<Vector256<short>, short>(ref right);
                prt = (short)BitMath.ToInt32Mask(pleft < pright);
                Unsafe.Add(ref prt, 1) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) < Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) < Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) < Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 4) < Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 5) < Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 6) < Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 7) < Unsafe.Add(ref pright, 7));
                Unsafe.Add(ref prt, 8) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 8) < Unsafe.Add(ref pright, 8));
                Unsafe.Add(ref prt, 9) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 9) < Unsafe.Add(ref pright, 9));
                Unsafe.Add(ref prt, 10) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 10) < Unsafe.Add(ref pright, 10));
                Unsafe.Add(ref prt, 11) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 11) < Unsafe.Add(ref pright, 11));
                Unsafe.Add(ref prt, 12) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 12) < Unsafe.Add(ref pright, 12));
                Unsafe.Add(ref prt, 13) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 13) < Unsafe.Add(ref pright, 13));
                Unsafe.Add(ref prt, 14) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 14) < Unsafe.Add(ref pright, 14));
                Unsafe.Add(ref prt, 15) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 15) < Unsafe.Add(ref pright, 15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> LessThan_Basic(Vector256<ushort> left, Vector256<ushort> right) {
                UnsafeEx.SkipInit(out Vector256<ushort> rt);
                ref short prt = ref Unsafe.As<Vector256<ushort>, short>(ref rt);
                ref ushort pleft = ref Unsafe.As<Vector256<ushort>, ushort>(ref left);
                ref ushort pright = ref Unsafe.As<Vector256<ushort>, ushort>(ref right);
                prt = (short)BitMath.ToInt32Mask(pleft < pright);
                Unsafe.Add(ref prt, 1) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) < Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) < Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) < Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 4) < Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 5) < Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 6) < Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 7) < Unsafe.Add(ref pright, 7));
                Unsafe.Add(ref prt, 8) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 8) < Unsafe.Add(ref pright, 8));
                Unsafe.Add(ref prt, 9) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 9) < Unsafe.Add(ref pright, 9));
                Unsafe.Add(ref prt, 10) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 10) < Unsafe.Add(ref pright, 10));
                Unsafe.Add(ref prt, 11) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 11) < Unsafe.Add(ref pright, 11));
                Unsafe.Add(ref prt, 12) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 12) < Unsafe.Add(ref pright, 12));
                Unsafe.Add(ref prt, 13) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 13) < Unsafe.Add(ref pright, 13));
                Unsafe.Add(ref prt, 14) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 14) < Unsafe.Add(ref pright, 14));
                Unsafe.Add(ref prt, 15) = (short)BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 15) < Unsafe.Add(ref pright, 15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> LessThan_Basic(Vector256<int> left, Vector256<int> right) {
                UnsafeEx.SkipInit(out Vector256<int> rt);
                ref int prt = ref Unsafe.As<Vector256<int>, int>(ref rt);
                ref int pleft = ref Unsafe.As<Vector256<int>, int>(ref left);
                ref int pright = ref Unsafe.As<Vector256<int>, int>(ref right);
                prt = BitMath.ToInt32Mask(pleft < pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) < Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) < Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) < Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 4) < Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 5) < Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 6) < Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 7) < Unsafe.Add(ref pright, 7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> LessThan_Basic(Vector256<uint> left, Vector256<uint> right) {
                UnsafeEx.SkipInit(out Vector256<uint> rt);
                ref int prt = ref Unsafe.As<Vector256<uint>, int>(ref rt);
                ref uint pleft = ref Unsafe.As<Vector256<uint>, uint>(ref left);
                ref uint pright = ref Unsafe.As<Vector256<uint>, uint>(ref right);
                prt = BitMath.ToInt32Mask(pleft < pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) < Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) < Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) < Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 4) < Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 5) < Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 6) < Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 7) < Unsafe.Add(ref pright, 7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> LessThan_Basic(Vector256<long> left, Vector256<long> right) {
                UnsafeEx.SkipInit(out Vector256<long> rt);
                ref long prt = ref Unsafe.As<Vector256<long>, long>(ref rt);
                ref long pleft = ref Unsafe.As<Vector256<long>, long>(ref left);
                ref long pright = ref Unsafe.As<Vector256<long>, long>(ref right);
                prt = BitMath.ToInt32Mask(pleft < pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) < Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) < Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) < Unsafe.Add(ref pright, 3));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> LessThan_Basic(Vector256<ulong> left, Vector256<ulong> right) {
                UnsafeEx.SkipInit(out Vector256<ulong> rt);
                ref long prt = ref Unsafe.As<Vector256<ulong>, long>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector256<ulong>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector256<ulong>, ulong>(ref right);
                prt = BitMath.ToInt32Mask(pleft < pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) < Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) < Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) < Unsafe.Add(ref pright, 3));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Max_AcceleratedTypes"/>
            public static TypeCodeFlags Max_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Max(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Max(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Max(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Max(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Max(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Max(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Max(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Max(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Max(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Max(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<float> Max_Conditional(Vector256<float> left, Vector256<float> right) {
                Vector256<float> condition = GreaterThan(left, right);
                Vector256<float> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<double> Max_Conditional(Vector256<double> left, Vector256<double> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<long> rt);
#else
                Vector256<long> rt = default;
#endif // NET5_0_OR_GREATER
                double* pleft = (double*)&left;
                double* pright = (double*)&right;
                long* q = (long*)&rt;
                long condition0 = BitMath.ToInt32Mask(pleft[0] > pright[0]);
                long condition1 = BitMath.ToInt32Mask(pleft[1] > pright[1]);
                long condition2 = BitMath.ToInt32Mask(pleft[2] > pright[2]);
                long condition3 = BitMath.ToInt32Mask(pleft[3] > pright[3]);
                // result = (left & condition) | (right & ~condition);
                q[0] = (BitMath.DoubleToInt64Bits(pleft[0]) & condition0) | (BitMath.DoubleToInt64Bits(pright[0]) & ~condition0);
                q[1] = (BitMath.DoubleToInt64Bits(pleft[1]) & condition1) | (BitMath.DoubleToInt64Bits(pright[1]) & ~condition1);
                q[2] = (BitMath.DoubleToInt64Bits(pleft[2]) & condition2) | (BitMath.DoubleToInt64Bits(pright[2]) & ~condition2);
                q[3] = (BitMath.DoubleToInt64Bits(pleft[3]) & condition3) | (BitMath.DoubleToInt64Bits(pright[3]) & ~condition3);
                return rt.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> Max_Conditional(Vector256<sbyte> left, Vector256<sbyte> right) {
                Vector256<sbyte> condition = GreaterThan(left, right);
                Vector256<sbyte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<byte> Max_Conditional(Vector256<byte> left, Vector256<byte> right) {
                Vector256<byte> condition = GreaterThan(left, right);
                Vector256<byte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> Max_Conditional(Vector256<short> left, Vector256<short> right) {
                Vector256<short> condition = GreaterThan(left, right);
                Vector256<short> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ushort> Max_Conditional(Vector256<ushort> left, Vector256<ushort> right) {
                Vector256<ushort> condition = GreaterThan(left, right);
                Vector256<ushort> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> Max_Conditional(Vector256<int> left, Vector256<int> right) {
                Vector256<int> condition = GreaterThan(left, right);
                Vector256<int> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<uint> Max_Conditional(Vector256<uint> left, Vector256<uint> right) {
                Vector256<uint> condition = GreaterThan(left, right);
                Vector256<uint> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> Max_Conditional(Vector256<long> left, Vector256<long> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<long> rt);
#else
                Vector256<long> rt = default;
#endif // NET5_0_OR_GREATER
                long* pleft = (long*)&left;
                long* pright = (long*)&right;
                long* q = (long*)&rt;
                long condition0 = BitMath.ToInt32Mask(pleft[0] > pright[0]);
                long condition1 = BitMath.ToInt32Mask(pleft[1] > pright[1]);
                long condition2 = BitMath.ToInt32Mask(pleft[2] > pright[2]);
                long condition3 = BitMath.ToInt32Mask(pleft[3] > pright[3]);
                // result = (left & condition) | (right & ~condition);
                q[0] = ((pleft[0]) & condition0) | ((pright[0]) & ~condition0);
                q[1] = ((pleft[1]) & condition1) | ((pright[1]) & ~condition1);
                q[2] = ((pleft[2]) & condition2) | ((pright[2]) & ~condition2);
                q[3] = ((pleft[3]) & condition3) | ((pright[3]) & ~condition3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ulong> Max_Conditional(Vector256<ulong> left, Vector256<ulong> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<long> rt);
#else
                Vector256<long> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                long* q = (long*)&rt;
                long condition0 = BitMath.ToInt32Mask(pleft[0] > pright[0]);
                long condition1 = BitMath.ToInt32Mask(pleft[1] > pright[1]);
                long condition2 = BitMath.ToInt32Mask(pleft[2] > pright[2]);
                long condition3 = BitMath.ToInt32Mask(pleft[3] > pright[3]);
                // result = (left & condition) | (right & ~condition);
                q[0] = ((long)(pleft[0]) & condition0) | ((long)(pright[0]) & ~condition0);
                q[1] = ((long)(pleft[1]) & condition1) | ((long)(pright[1]) & ~condition1);
                q[2] = ((long)(pleft[2]) & condition2) | ((long)(pright[2]) & ~condition2);
                q[3] = ((long)(pleft[3]) & condition3) | ((long)(pright[3]) & ~condition3);
                return rt.AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits256.Min_AcceleratedTypes"/>
            public static TypeCodeFlags Min_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Min(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Min(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Min(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Min(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Min(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Min(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Min(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Min(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Min(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Min(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<float> Min_Conditional(Vector256<float> left, Vector256<float> right) {
                Vector256<float> condition = LessThan(left, right);
                Vector256<float> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<double> Min_Conditional(Vector256<double> left, Vector256<double> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<long> rt);
#else
                Vector256<long> rt = default;
#endif // NET5_0_OR_GREATER
                double* pleft = (double*)&left;
                double* pright = (double*)&right;
                long* q = (long*)&rt;
                long condition0 = BitMath.ToInt32Mask(pleft[0] < pright[0]);
                long condition1 = BitMath.ToInt32Mask(pleft[1] < pright[1]);
                long condition2 = BitMath.ToInt32Mask(pleft[2] < pright[2]);
                long condition3 = BitMath.ToInt32Mask(pleft[3] < pright[3]);
                // result = (left & condition) | (right & ~condition);
                q[0] = (BitMath.DoubleToInt64Bits(pleft[0]) & condition0) | (BitMath.DoubleToInt64Bits(pright[0]) & ~condition0);
                q[1] = (BitMath.DoubleToInt64Bits(pleft[1]) & condition1) | (BitMath.DoubleToInt64Bits(pright[1]) & ~condition1);
                q[2] = (BitMath.DoubleToInt64Bits(pleft[2]) & condition2) | (BitMath.DoubleToInt64Bits(pright[2]) & ~condition2);
                q[3] = (BitMath.DoubleToInt64Bits(pleft[3]) & condition3) | (BitMath.DoubleToInt64Bits(pright[3]) & ~condition3);
                return rt.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> Min_Conditional(Vector256<sbyte> left, Vector256<sbyte> right) {
                Vector256<sbyte> condition = LessThan(left, right);
                Vector256<sbyte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<byte> Min_Conditional(Vector256<byte> left, Vector256<byte> right) {
                Vector256<byte> condition = LessThan(left, right);
                Vector256<byte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> Min_Conditional(Vector256<short> left, Vector256<short> right) {
                Vector256<short> condition = LessThan(left, right);
                Vector256<short> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ushort> Min_Conditional(Vector256<ushort> left, Vector256<ushort> right) {
                Vector256<ushort> condition = LessThan(left, right);
                Vector256<ushort> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> Min_Conditional(Vector256<int> left, Vector256<int> right) {
                Vector256<int> condition = LessThan(left, right);
                Vector256<int> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<uint> Min_Conditional(Vector256<uint> left, Vector256<uint> right) {
                Vector256<uint> condition = LessThan(left, right);
                Vector256<uint> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> Min_Conditional(Vector256<long> left, Vector256<long> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<long> rt);
#else
                Vector256<long> rt = default;
#endif // NET5_0_OR_GREATER
                long* pleft = (long*)&left;
                long* pright = (long*)&right;
                long* q = (long*)&rt;
                long condition0 = BitMath.ToInt32Mask(pleft[0] < pright[0]);
                long condition1 = BitMath.ToInt32Mask(pleft[1] < pright[1]);
                long condition2 = BitMath.ToInt32Mask(pleft[2] < pright[2]);
                long condition3 = BitMath.ToInt32Mask(pleft[3] < pright[3]);
                // result = (left & condition) | (right & ~condition);
                q[0] = ((pleft[0]) & condition0) | ((pright[0]) & ~condition0);
                q[1] = ((pleft[1]) & condition1) | ((pright[1]) & ~condition1);
                q[2] = ((pleft[2]) & condition2) | ((pright[2]) & ~condition2);
                q[3] = ((pleft[3]) & condition3) | ((pright[3]) & ~condition3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ulong> Min_Conditional(Vector256<ulong> left, Vector256<ulong> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<long> rt);
#else
                Vector256<long> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                long* q = (long*)&rt;
                long condition0 = BitMath.ToInt32Mask(pleft[0] < pright[0]);
                long condition1 = BitMath.ToInt32Mask(pleft[1] < pright[1]);
                long condition2 = BitMath.ToInt32Mask(pleft[2] < pright[2]);
                long condition3 = BitMath.ToInt32Mask(pleft[3] < pright[3]);
                // result = (left & condition) | (right & ~condition);
                q[0] = ((long)(pleft[0]) & condition0) | ((long)(pright[0]) & ~condition0);
                q[1] = ((long)(pleft[1]) & condition1) | ((long)(pright[1]) & ~condition1);
                q[2] = ((long)(pleft[2]) & condition2) | ((long)(pright[2]) & ~condition2);
                q[3] = ((long)(pleft[3]) & condition3) | ((long)(pright[3]) & ~condition3);
                return rt.AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits256.Multiply_AcceleratedTypes"/>
            public static TypeCodeFlags Multiply_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply_FullAcceleratedTypes"/>
            public static TypeCodeFlags Multiply_FullAcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Multiply(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Multiply(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Multiply(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Multiply(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Multiply(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Multiply(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Multiply(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Multiply(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Multiply(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Multiply(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Multiply_Basic(Vector256<float> left, Vector256<float> right) {
                UnsafeEx.SkipInit(out Vector256<float> rt);
                ref float prt = ref Unsafe.As<Vector256<float>, float>(ref rt);
                ref float pleft = ref Unsafe.As<Vector256<float>, float>(ref left);
                ref float pright = ref Unsafe.As<Vector256<float>, float>(ref right);
                prt = pleft * pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) * Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) * Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) * Unsafe.Add(ref pright, 3);
                Unsafe.Add(ref prt, 4) = Unsafe.Add(ref pleft, 4) * Unsafe.Add(ref pright, 4);
                Unsafe.Add(ref prt, 5) = Unsafe.Add(ref pleft, 5) * Unsafe.Add(ref pright, 5);
                Unsafe.Add(ref prt, 6) = Unsafe.Add(ref pleft, 6) * Unsafe.Add(ref pright, 6);
                Unsafe.Add(ref prt, 7) = Unsafe.Add(ref pleft, 7) * Unsafe.Add(ref pright, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Multiply_Basic(Vector256<double> left, Vector256<double> right) {
                UnsafeEx.SkipInit(out Vector256<double> rt);
                ref double prt = ref Unsafe.As<Vector256<double>, double>(ref rt);
                ref double pleft = ref Unsafe.As<Vector256<double>, double>(ref left);
                ref double pright = ref Unsafe.As<Vector256<double>, double>(ref right);
                prt = pleft * pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) * Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) * Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) * Unsafe.Add(ref pright, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Multiply_Basic(Vector256<sbyte> left, Vector256<sbyte> right) {
                UnsafeEx.SkipInit(out Vector256<sbyte> rt);
                ref sbyte prt = ref Unsafe.As<Vector256<sbyte>, sbyte>(ref rt);
                ref sbyte pleft = ref Unsafe.As<Vector256<sbyte>, sbyte>(ref left);
                ref sbyte pright = ref Unsafe.As<Vector256<sbyte>, sbyte>(ref right);
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
                Unsafe.Add(ref prt, 16) = (sbyte)(Unsafe.Add(ref pleft, 16) * Unsafe.Add(ref pright, 16));
                Unsafe.Add(ref prt, 17) = (sbyte)(Unsafe.Add(ref pleft, 17) * Unsafe.Add(ref pright, 17));
                Unsafe.Add(ref prt, 18) = (sbyte)(Unsafe.Add(ref pleft, 18) * Unsafe.Add(ref pright, 18));
                Unsafe.Add(ref prt, 19) = (sbyte)(Unsafe.Add(ref pleft, 19) * Unsafe.Add(ref pright, 19));
                Unsafe.Add(ref prt, 20) = (sbyte)(Unsafe.Add(ref pleft, 20) * Unsafe.Add(ref pright, 20));
                Unsafe.Add(ref prt, 21) = (sbyte)(Unsafe.Add(ref pleft, 21) * Unsafe.Add(ref pright, 21));
                Unsafe.Add(ref prt, 22) = (sbyte)(Unsafe.Add(ref pleft, 22) * Unsafe.Add(ref pright, 22));
                Unsafe.Add(ref prt, 23) = (sbyte)(Unsafe.Add(ref pleft, 23) * Unsafe.Add(ref pright, 23));
                Unsafe.Add(ref prt, 24) = (sbyte)(Unsafe.Add(ref pleft, 24) * Unsafe.Add(ref pright, 24));
                Unsafe.Add(ref prt, 25) = (sbyte)(Unsafe.Add(ref pleft, 25) * Unsafe.Add(ref pright, 25));
                Unsafe.Add(ref prt, 26) = (sbyte)(Unsafe.Add(ref pleft, 26) * Unsafe.Add(ref pright, 26));
                Unsafe.Add(ref prt, 27) = (sbyte)(Unsafe.Add(ref pleft, 27) * Unsafe.Add(ref pright, 27));
                Unsafe.Add(ref prt, 28) = (sbyte)(Unsafe.Add(ref pleft, 28) * Unsafe.Add(ref pright, 28));
                Unsafe.Add(ref prt, 29) = (sbyte)(Unsafe.Add(ref pleft, 29) * Unsafe.Add(ref pright, 29));
                Unsafe.Add(ref prt, 30) = (sbyte)(Unsafe.Add(ref pleft, 30) * Unsafe.Add(ref pright, 30));
                Unsafe.Add(ref prt, 31) = (sbyte)(Unsafe.Add(ref pleft, 31) * Unsafe.Add(ref pright, 31));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Multiply_Basic(Vector256<byte> left, Vector256<byte> right) {
                UnsafeEx.SkipInit(out Vector256<byte> rt);
                ref byte prt = ref Unsafe.As<Vector256<byte>, byte>(ref rt);
                ref byte pleft = ref Unsafe.As<Vector256<byte>, byte>(ref left);
                ref byte pright = ref Unsafe.As<Vector256<byte>, byte>(ref right);
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
                Unsafe.Add(ref prt, 16) = (byte)(Unsafe.Add(ref pleft, 16) * Unsafe.Add(ref pright, 16));
                Unsafe.Add(ref prt, 17) = (byte)(Unsafe.Add(ref pleft, 17) * Unsafe.Add(ref pright, 17));
                Unsafe.Add(ref prt, 18) = (byte)(Unsafe.Add(ref pleft, 18) * Unsafe.Add(ref pright, 18));
                Unsafe.Add(ref prt, 19) = (byte)(Unsafe.Add(ref pleft, 19) * Unsafe.Add(ref pright, 19));
                Unsafe.Add(ref prt, 20) = (byte)(Unsafe.Add(ref pleft, 20) * Unsafe.Add(ref pright, 20));
                Unsafe.Add(ref prt, 21) = (byte)(Unsafe.Add(ref pleft, 21) * Unsafe.Add(ref pright, 21));
                Unsafe.Add(ref prt, 22) = (byte)(Unsafe.Add(ref pleft, 22) * Unsafe.Add(ref pright, 22));
                Unsafe.Add(ref prt, 23) = (byte)(Unsafe.Add(ref pleft, 23) * Unsafe.Add(ref pright, 23));
                Unsafe.Add(ref prt, 24) = (byte)(Unsafe.Add(ref pleft, 24) * Unsafe.Add(ref pright, 24));
                Unsafe.Add(ref prt, 25) = (byte)(Unsafe.Add(ref pleft, 25) * Unsafe.Add(ref pright, 25));
                Unsafe.Add(ref prt, 26) = (byte)(Unsafe.Add(ref pleft, 26) * Unsafe.Add(ref pright, 26));
                Unsafe.Add(ref prt, 27) = (byte)(Unsafe.Add(ref pleft, 27) * Unsafe.Add(ref pright, 27));
                Unsafe.Add(ref prt, 28) = (byte)(Unsafe.Add(ref pleft, 28) * Unsafe.Add(ref pright, 28));
                Unsafe.Add(ref prt, 29) = (byte)(Unsafe.Add(ref pleft, 29) * Unsafe.Add(ref pright, 29));
                Unsafe.Add(ref prt, 30) = (byte)(Unsafe.Add(ref pleft, 30) * Unsafe.Add(ref pright, 30));
                Unsafe.Add(ref prt, 31) = (byte)(Unsafe.Add(ref pleft, 31) * Unsafe.Add(ref pright, 31));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Multiply_Basic(Vector256<short> left, Vector256<short> right) {
                UnsafeEx.SkipInit(out Vector256<short> rt);
                ref short prt = ref Unsafe.As<Vector256<short>, short>(ref rt);
                ref short pleft = ref Unsafe.As<Vector256<short>, short>(ref left);
                ref short pright = ref Unsafe.As<Vector256<short>, short>(ref right);
                prt = (short)(pleft * pright);
                Unsafe.Add(ref prt, 1) = (short)(Unsafe.Add(ref pleft, 1) * Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (short)(Unsafe.Add(ref pleft, 2) * Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (short)(Unsafe.Add(ref pleft, 3) * Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (short)(Unsafe.Add(ref pleft, 4) * Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (short)(Unsafe.Add(ref pleft, 5) * Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (short)(Unsafe.Add(ref pleft, 6) * Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (short)(Unsafe.Add(ref pleft, 7) * Unsafe.Add(ref pright, 7));
                Unsafe.Add(ref prt, 8) = (short)(Unsafe.Add(ref pleft, 8) * Unsafe.Add(ref pright, 8));
                Unsafe.Add(ref prt, 9) = (short)(Unsafe.Add(ref pleft, 9) * Unsafe.Add(ref pright, 9));
                Unsafe.Add(ref prt, 10) = (short)(Unsafe.Add(ref pleft, 10) * Unsafe.Add(ref pright, 10));
                Unsafe.Add(ref prt, 11) = (short)(Unsafe.Add(ref pleft, 11) * Unsafe.Add(ref pright, 11));
                Unsafe.Add(ref prt, 12) = (short)(Unsafe.Add(ref pleft, 12) * Unsafe.Add(ref pright, 12));
                Unsafe.Add(ref prt, 13) = (short)(Unsafe.Add(ref pleft, 13) * Unsafe.Add(ref pright, 13));
                Unsafe.Add(ref prt, 14) = (short)(Unsafe.Add(ref pleft, 14) * Unsafe.Add(ref pright, 14));
                Unsafe.Add(ref prt, 15) = (short)(Unsafe.Add(ref pleft, 15) * Unsafe.Add(ref pright, 15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Multiply_Basic(Vector256<ushort> left, Vector256<ushort> right) {
                UnsafeEx.SkipInit(out Vector256<ushort> rt);
                ref ushort prt = ref Unsafe.As<Vector256<ushort>, ushort>(ref rt);
                ref ushort pleft = ref Unsafe.As<Vector256<ushort>, ushort>(ref left);
                ref ushort pright = ref Unsafe.As<Vector256<ushort>, ushort>(ref right);
                prt = (ushort)(pleft * pright);
                Unsafe.Add(ref prt, 1) = (ushort)(Unsafe.Add(ref pleft, 1) * Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (ushort)(Unsafe.Add(ref pleft, 2) * Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (ushort)(Unsafe.Add(ref pleft, 3) * Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (ushort)(Unsafe.Add(ref pleft, 4) * Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (ushort)(Unsafe.Add(ref pleft, 5) * Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (ushort)(Unsafe.Add(ref pleft, 6) * Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (ushort)(Unsafe.Add(ref pleft, 7) * Unsafe.Add(ref pright, 7));
                Unsafe.Add(ref prt, 8) = (ushort)(Unsafe.Add(ref pleft, 8) * Unsafe.Add(ref pright, 8));
                Unsafe.Add(ref prt, 9) = (ushort)(Unsafe.Add(ref pleft, 9) * Unsafe.Add(ref pright, 9));
                Unsafe.Add(ref prt, 10) = (ushort)(Unsafe.Add(ref pleft, 10) * Unsafe.Add(ref pright, 10));
                Unsafe.Add(ref prt, 11) = (ushort)(Unsafe.Add(ref pleft, 11) * Unsafe.Add(ref pright, 11));
                Unsafe.Add(ref prt, 12) = (ushort)(Unsafe.Add(ref pleft, 12) * Unsafe.Add(ref pright, 12));
                Unsafe.Add(ref prt, 13) = (ushort)(Unsafe.Add(ref pleft, 13) * Unsafe.Add(ref pright, 13));
                Unsafe.Add(ref prt, 14) = (ushort)(Unsafe.Add(ref pleft, 14) * Unsafe.Add(ref pright, 14));
                Unsafe.Add(ref prt, 15) = (ushort)(Unsafe.Add(ref pleft, 15) * Unsafe.Add(ref pright, 15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Multiply_Basic(Vector256<int> left, Vector256<int> right) {
                UnsafeEx.SkipInit(out Vector256<int> rt);
                ref int prt = ref Unsafe.As<Vector256<int>, int>(ref rt);
                ref int pleft = ref Unsafe.As<Vector256<int>, int>(ref left);
                ref int pright = ref Unsafe.As<Vector256<int>, int>(ref right);
                prt = pleft * pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) * Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) * Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) * Unsafe.Add(ref pright, 3);
                Unsafe.Add(ref prt, 4) = Unsafe.Add(ref pleft, 4) * Unsafe.Add(ref pright, 4);
                Unsafe.Add(ref prt, 5) = Unsafe.Add(ref pleft, 5) * Unsafe.Add(ref pright, 5);
                Unsafe.Add(ref prt, 6) = Unsafe.Add(ref pleft, 6) * Unsafe.Add(ref pright, 6);
                Unsafe.Add(ref prt, 7) = Unsafe.Add(ref pleft, 7) * Unsafe.Add(ref pright, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Multiply_Basic(Vector256<uint> left, Vector256<uint> right) {
                UnsafeEx.SkipInit(out Vector256<uint> rt);
                ref uint prt = ref Unsafe.As<Vector256<uint>, uint>(ref rt);
                ref uint pleft = ref Unsafe.As<Vector256<uint>, uint>(ref left);
                ref uint pright = ref Unsafe.As<Vector256<uint>, uint>(ref right);
                prt = pleft * pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) * Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) * Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) * Unsafe.Add(ref pright, 3);
                Unsafe.Add(ref prt, 4) = Unsafe.Add(ref pleft, 4) * Unsafe.Add(ref pright, 4);
                Unsafe.Add(ref prt, 5) = Unsafe.Add(ref pleft, 5) * Unsafe.Add(ref pright, 5);
                Unsafe.Add(ref prt, 6) = Unsafe.Add(ref pleft, 6) * Unsafe.Add(ref pright, 6);
                Unsafe.Add(ref prt, 7) = Unsafe.Add(ref pleft, 7) * Unsafe.Add(ref pright, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Multiply_Basic(Vector256<long> left, Vector256<long> right) {
                UnsafeEx.SkipInit(out Vector256<long> rt);
                ref long prt = ref Unsafe.As<Vector256<long>, long>(ref rt);
                ref long pleft = ref Unsafe.As<Vector256<long>, long>(ref left);
                ref long pright = ref Unsafe.As<Vector256<long>, long>(ref right);
                prt = pleft * pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) * Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) * Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) * Unsafe.Add(ref pright, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Multiply_Basic(Vector256<ulong> left, Vector256<ulong> right) {
                UnsafeEx.SkipInit(out Vector256<ulong> rt);
                ref ulong prt = ref Unsafe.As<Vector256<ulong>, ulong>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector256<ulong>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector256<ulong>, ulong>(ref right);
                prt = pleft * pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) * Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) * Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) * Unsafe.Add(ref pright, 3);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Negate_AcceleratedTypes"/>
            public static TypeCodeFlags Negate_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Negate(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Negate(value);
#else
                return Negate_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Negate(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Negate(value);
#else
                return Negate_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Negate(Vector256<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Negate(value);
#else
                return Negate_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Negate(Vector256<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Negate(value);
#else
                return Negate_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Negate(Vector256<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Negate(value);
#else
                return Negate_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Negate(Vector256<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Negate(value);
#else
                return Negate_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<float> Negate_Basic(Vector256<float> value) {
                Vector256<float> rt = value;
                float* p = (float*)&rt;
                p[0] = -p[0];
                p[1] = -p[1];
                p[2] = -p[2];
                p[3] = -p[3];
                p[4] = -p[4];
                p[5] = -p[5];
                p[6] = -p[6];
                p[7] = -p[7];
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<double> Negate_Basic(Vector256<double> value) {
                Vector256<double> rt = value;
                double* p = (double*)&rt;
                p[0] = -p[0];
                p[1] = -p[1];
                p[2] = -p[2];
                p[3] = -p[3];
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> Negate_Basic(Vector256<sbyte> value) {
                Vector256<sbyte> rt = value;
                sbyte* p = (sbyte*)&rt;
                p[0] = (sbyte)-p[0];
                p[1] = (sbyte)-p[1];
                p[2] = (sbyte)-p[2];
                p[3] = (sbyte)-p[3];
                p[4] = (sbyte)-p[4];
                p[5] = (sbyte)-p[5];
                p[6] = (sbyte)-p[6];
                p[7] = (sbyte)-p[7];
                p[8] = (sbyte)-p[8];
                p[9] = (sbyte)-p[9];
                p[10] = (sbyte)-p[10];
                p[11] = (sbyte)-p[11];
                p[12] = (sbyte)-p[12];
                p[13] = (sbyte)-p[13];
                p[14] = (sbyte)-p[14];
                p[15] = (sbyte)-p[15];
                p[16] = (sbyte)-p[16];
                p[17] = (sbyte)-p[17];
                p[18] = (sbyte)-p[18];
                p[19] = (sbyte)-p[19];
                p[20] = (sbyte)-p[20];
                p[21] = (sbyte)-p[21];
                p[22] = (sbyte)-p[22];
                p[23] = (sbyte)-p[23];
                p[24] = (sbyte)-p[24];
                p[25] = (sbyte)-p[25];
                p[26] = (sbyte)-p[26];
                p[27] = (sbyte)-p[27];
                p[28] = (sbyte)-p[28];
                p[29] = (sbyte)-p[29];
                p[30] = (sbyte)-p[30];
                p[31] = (sbyte)-p[31];
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> Negate_Basic(Vector256<short> value) {
                Vector256<short> rt = value;
                short* p = (short*)&rt;
                p[0] = (short)-p[0];
                p[1] = (short)-p[1];
                p[2] = (short)-p[2];
                p[3] = (short)-p[3];
                p[4] = (short)-p[4];
                p[5] = (short)-p[5];
                p[6] = (short)-p[6];
                p[7] = (short)-p[7];
                p[8] = (short)-p[8];
                p[9] = (short)-p[9];
                p[10] = (short)-p[10];
                p[11] = (short)-p[11];
                p[12] = (short)-p[12];
                p[13] = (short)-p[13];
                p[14] = (short)-p[14];
                p[15] = (short)-p[15];
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> Negate_Basic(Vector256<int> value) {
                Vector256<int> rt = value;
                int* p = (int*)&rt;
                p[0] = -p[0];
                p[1] = -p[1];
                p[2] = -p[2];
                p[3] = -p[3];
                p[4] = -p[4];
                p[5] = -p[5];
                p[6] = -p[6];
                p[7] = -p[7];
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> Negate_Basic(Vector256<long> value) {
                Vector256<long> rt = value;
                long* p = (long*)&rt;
                p[0] = -p[0];
                p[1] = -p[1];
                p[2] = -p[2];
                p[3] = -p[3];
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.OnesComplement_AcceleratedTypes"/>
            public static TypeCodeFlags OnesComplement_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.OnesComplement{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> OnesComplement<T>(Vector256<T> vector) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.OnesComplement(vector);
#else
                return OnesComplement_Basic(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.OnesComplement{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<T> OnesComplement_Basic<T>(Vector256<T> vector) where T : struct {
                Vector256<T> rt = vector;
                ulong* p = (ulong*)&rt;
                p[0] = ~p[0];
                p[1] = ~p[1];
                p[2] = ~p[2];
                p[3] = ~p[3];
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Subtract_AcceleratedTypes"/>
            public static TypeCodeFlags Subtract_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Subtract(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Subtract(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Subtract(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Subtract(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Subtract(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Subtract(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Subtract(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Subtract(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Subtract(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Subtract(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Subtract_Basic(Vector256<float> left, Vector256<float> right) {
                UnsafeEx.SkipInit(out Vector256<float> rt);
                ref float prt = ref Unsafe.As<Vector256<float>, float>(ref rt);
                ref float pleft = ref Unsafe.As<Vector256<float>, float>(ref left);
                ref float pright = ref Unsafe.As<Vector256<float>, float>(ref right);
                prt = pleft - pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) - Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) - Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) - Unsafe.Add(ref pright, 3);
                Unsafe.Add(ref prt, 4) = Unsafe.Add(ref pleft, 4) - Unsafe.Add(ref pright, 4);
                Unsafe.Add(ref prt, 5) = Unsafe.Add(ref pleft, 5) - Unsafe.Add(ref pright, 5);
                Unsafe.Add(ref prt, 6) = Unsafe.Add(ref pleft, 6) - Unsafe.Add(ref pright, 6);
                Unsafe.Add(ref prt, 7) = Unsafe.Add(ref pleft, 7) - Unsafe.Add(ref pright, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Subtract_Basic(Vector256<double> left, Vector256<double> right) {
                UnsafeEx.SkipInit(out Vector256<double> rt);
                ref double prt = ref Unsafe.As<Vector256<double>, double>(ref rt);
                ref double pleft = ref Unsafe.As<Vector256<double>, double>(ref left);
                ref double pright = ref Unsafe.As<Vector256<double>, double>(ref right);
                prt = pleft - pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) - Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) - Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) - Unsafe.Add(ref pright, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Subtract_Basic(Vector256<sbyte> left, Vector256<sbyte> right) {
                UnsafeEx.SkipInit(out Vector256<sbyte> rt);
                ref sbyte prt = ref Unsafe.As<Vector256<sbyte>, sbyte>(ref rt);
                ref sbyte pleft = ref Unsafe.As<Vector256<sbyte>, sbyte>(ref left);
                ref sbyte pright = ref Unsafe.As<Vector256<sbyte>, sbyte>(ref right);
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
                Unsafe.Add(ref prt, 16) = (sbyte)(Unsafe.Add(ref pleft, 16) - Unsafe.Add(ref pright, 16));
                Unsafe.Add(ref prt, 17) = (sbyte)(Unsafe.Add(ref pleft, 17) - Unsafe.Add(ref pright, 17));
                Unsafe.Add(ref prt, 18) = (sbyte)(Unsafe.Add(ref pleft, 18) - Unsafe.Add(ref pright, 18));
                Unsafe.Add(ref prt, 19) = (sbyte)(Unsafe.Add(ref pleft, 19) - Unsafe.Add(ref pright, 19));
                Unsafe.Add(ref prt, 20) = (sbyte)(Unsafe.Add(ref pleft, 20) - Unsafe.Add(ref pright, 20));
                Unsafe.Add(ref prt, 21) = (sbyte)(Unsafe.Add(ref pleft, 21) - Unsafe.Add(ref pright, 21));
                Unsafe.Add(ref prt, 22) = (sbyte)(Unsafe.Add(ref pleft, 22) - Unsafe.Add(ref pright, 22));
                Unsafe.Add(ref prt, 23) = (sbyte)(Unsafe.Add(ref pleft, 23) - Unsafe.Add(ref pright, 23));
                Unsafe.Add(ref prt, 24) = (sbyte)(Unsafe.Add(ref pleft, 24) - Unsafe.Add(ref pright, 24));
                Unsafe.Add(ref prt, 25) = (sbyte)(Unsafe.Add(ref pleft, 25) - Unsafe.Add(ref pright, 25));
                Unsafe.Add(ref prt, 26) = (sbyte)(Unsafe.Add(ref pleft, 26) - Unsafe.Add(ref pright, 26));
                Unsafe.Add(ref prt, 27) = (sbyte)(Unsafe.Add(ref pleft, 27) - Unsafe.Add(ref pright, 27));
                Unsafe.Add(ref prt, 28) = (sbyte)(Unsafe.Add(ref pleft, 28) - Unsafe.Add(ref pright, 28));
                Unsafe.Add(ref prt, 29) = (sbyte)(Unsafe.Add(ref pleft, 29) - Unsafe.Add(ref pright, 29));
                Unsafe.Add(ref prt, 30) = (sbyte)(Unsafe.Add(ref pleft, 30) - Unsafe.Add(ref pright, 30));
                Unsafe.Add(ref prt, 31) = (sbyte)(Unsafe.Add(ref pleft, 31) - Unsafe.Add(ref pright, 31));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Subtract_Basic(Vector256<byte> left, Vector256<byte> right) {
                UnsafeEx.SkipInit(out Vector256<byte> rt);
                ref byte prt = ref Unsafe.As<Vector256<byte>, byte>(ref rt);
                ref byte pleft = ref Unsafe.As<Vector256<byte>, byte>(ref left);
                ref byte pright = ref Unsafe.As<Vector256<byte>, byte>(ref right);
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
                Unsafe.Add(ref prt, 16) = (byte)(Unsafe.Add(ref pleft, 16) - Unsafe.Add(ref pright, 16));
                Unsafe.Add(ref prt, 17) = (byte)(Unsafe.Add(ref pleft, 17) - Unsafe.Add(ref pright, 17));
                Unsafe.Add(ref prt, 18) = (byte)(Unsafe.Add(ref pleft, 18) - Unsafe.Add(ref pright, 18));
                Unsafe.Add(ref prt, 19) = (byte)(Unsafe.Add(ref pleft, 19) - Unsafe.Add(ref pright, 19));
                Unsafe.Add(ref prt, 20) = (byte)(Unsafe.Add(ref pleft, 20) - Unsafe.Add(ref pright, 20));
                Unsafe.Add(ref prt, 21) = (byte)(Unsafe.Add(ref pleft, 21) - Unsafe.Add(ref pright, 21));
                Unsafe.Add(ref prt, 22) = (byte)(Unsafe.Add(ref pleft, 22) - Unsafe.Add(ref pright, 22));
                Unsafe.Add(ref prt, 23) = (byte)(Unsafe.Add(ref pleft, 23) - Unsafe.Add(ref pright, 23));
                Unsafe.Add(ref prt, 24) = (byte)(Unsafe.Add(ref pleft, 24) - Unsafe.Add(ref pright, 24));
                Unsafe.Add(ref prt, 25) = (byte)(Unsafe.Add(ref pleft, 25) - Unsafe.Add(ref pright, 25));
                Unsafe.Add(ref prt, 26) = (byte)(Unsafe.Add(ref pleft, 26) - Unsafe.Add(ref pright, 26));
                Unsafe.Add(ref prt, 27) = (byte)(Unsafe.Add(ref pleft, 27) - Unsafe.Add(ref pright, 27));
                Unsafe.Add(ref prt, 28) = (byte)(Unsafe.Add(ref pleft, 28) - Unsafe.Add(ref pright, 28));
                Unsafe.Add(ref prt, 29) = (byte)(Unsafe.Add(ref pleft, 29) - Unsafe.Add(ref pright, 29));
                Unsafe.Add(ref prt, 30) = (byte)(Unsafe.Add(ref pleft, 30) - Unsafe.Add(ref pright, 30));
                Unsafe.Add(ref prt, 31) = (byte)(Unsafe.Add(ref pleft, 31) - Unsafe.Add(ref pright, 31));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Subtract_Basic(Vector256<short> left, Vector256<short> right) {
                UnsafeEx.SkipInit(out Vector256<short> rt);
                ref short prt = ref Unsafe.As<Vector256<short>, short>(ref rt);
                ref short pleft = ref Unsafe.As<Vector256<short>, short>(ref left);
                ref short pright = ref Unsafe.As<Vector256<short>, short>(ref right);
                prt = (short)(pleft - pright);
                Unsafe.Add(ref prt, 1) = (short)(Unsafe.Add(ref pleft, 1) - Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (short)(Unsafe.Add(ref pleft, 2) - Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (short)(Unsafe.Add(ref pleft, 3) - Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (short)(Unsafe.Add(ref pleft, 4) - Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (short)(Unsafe.Add(ref pleft, 5) - Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (short)(Unsafe.Add(ref pleft, 6) - Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (short)(Unsafe.Add(ref pleft, 7) - Unsafe.Add(ref pright, 7));
                Unsafe.Add(ref prt, 8) = (short)(Unsafe.Add(ref pleft, 8) - Unsafe.Add(ref pright, 8));
                Unsafe.Add(ref prt, 9) = (short)(Unsafe.Add(ref pleft, 9) - Unsafe.Add(ref pright, 9));
                Unsafe.Add(ref prt, 10) = (short)(Unsafe.Add(ref pleft, 10) - Unsafe.Add(ref pright, 10));
                Unsafe.Add(ref prt, 11) = (short)(Unsafe.Add(ref pleft, 11) - Unsafe.Add(ref pright, 11));
                Unsafe.Add(ref prt, 12) = (short)(Unsafe.Add(ref pleft, 12) - Unsafe.Add(ref pright, 12));
                Unsafe.Add(ref prt, 13) = (short)(Unsafe.Add(ref pleft, 13) - Unsafe.Add(ref pright, 13));
                Unsafe.Add(ref prt, 14) = (short)(Unsafe.Add(ref pleft, 14) - Unsafe.Add(ref pright, 14));
                Unsafe.Add(ref prt, 15) = (short)(Unsafe.Add(ref pleft, 15) - Unsafe.Add(ref pright, 15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Subtract_Basic(Vector256<ushort> left, Vector256<ushort> right) {
                UnsafeEx.SkipInit(out Vector256<ushort> rt);
                ref ushort prt = ref Unsafe.As<Vector256<ushort>, ushort>(ref rt);
                ref ushort pleft = ref Unsafe.As<Vector256<ushort>, ushort>(ref left);
                ref ushort pright = ref Unsafe.As<Vector256<ushort>, ushort>(ref right);
                prt = (ushort)(pleft - pright);
                Unsafe.Add(ref prt, 1) = (ushort)(Unsafe.Add(ref pleft, 1) - Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = (ushort)(Unsafe.Add(ref pleft, 2) - Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = (ushort)(Unsafe.Add(ref pleft, 3) - Unsafe.Add(ref pright, 3));
                Unsafe.Add(ref prt, 4) = (ushort)(Unsafe.Add(ref pleft, 4) - Unsafe.Add(ref pright, 4));
                Unsafe.Add(ref prt, 5) = (ushort)(Unsafe.Add(ref pleft, 5) - Unsafe.Add(ref pright, 5));
                Unsafe.Add(ref prt, 6) = (ushort)(Unsafe.Add(ref pleft, 6) - Unsafe.Add(ref pright, 6));
                Unsafe.Add(ref prt, 7) = (ushort)(Unsafe.Add(ref pleft, 7) - Unsafe.Add(ref pright, 7));
                Unsafe.Add(ref prt, 8) = (ushort)(Unsafe.Add(ref pleft, 8) - Unsafe.Add(ref pright, 8));
                Unsafe.Add(ref prt, 9) = (ushort)(Unsafe.Add(ref pleft, 9) - Unsafe.Add(ref pright, 9));
                Unsafe.Add(ref prt, 10) = (ushort)(Unsafe.Add(ref pleft, 10) - Unsafe.Add(ref pright, 10));
                Unsafe.Add(ref prt, 11) = (ushort)(Unsafe.Add(ref pleft, 11) - Unsafe.Add(ref pright, 11));
                Unsafe.Add(ref prt, 12) = (ushort)(Unsafe.Add(ref pleft, 12) - Unsafe.Add(ref pright, 12));
                Unsafe.Add(ref prt, 13) = (ushort)(Unsafe.Add(ref pleft, 13) - Unsafe.Add(ref pright, 13));
                Unsafe.Add(ref prt, 14) = (ushort)(Unsafe.Add(ref pleft, 14) - Unsafe.Add(ref pright, 14));
                Unsafe.Add(ref prt, 15) = (ushort)(Unsafe.Add(ref pleft, 15) - Unsafe.Add(ref pright, 15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Subtract_Basic(Vector256<int> left, Vector256<int> right) {
                UnsafeEx.SkipInit(out Vector256<int> rt);
                ref int prt = ref Unsafe.As<Vector256<int>, int>(ref rt);
                ref int pleft = ref Unsafe.As<Vector256<int>, int>(ref left);
                ref int pright = ref Unsafe.As<Vector256<int>, int>(ref right);
                prt = pleft - pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) - Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) - Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) - Unsafe.Add(ref pright, 3);
                Unsafe.Add(ref prt, 4) = Unsafe.Add(ref pleft, 4) - Unsafe.Add(ref pright, 4);
                Unsafe.Add(ref prt, 5) = Unsafe.Add(ref pleft, 5) - Unsafe.Add(ref pright, 5);
                Unsafe.Add(ref prt, 6) = Unsafe.Add(ref pleft, 6) - Unsafe.Add(ref pright, 6);
                Unsafe.Add(ref prt, 7) = Unsafe.Add(ref pleft, 7) - Unsafe.Add(ref pright, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Subtract_Basic(Vector256<uint> left, Vector256<uint> right) {
                UnsafeEx.SkipInit(out Vector256<uint> rt);
                ref uint prt = ref Unsafe.As<Vector256<uint>, uint>(ref rt);
                ref uint pleft = ref Unsafe.As<Vector256<uint>, uint>(ref left);
                ref uint pright = ref Unsafe.As<Vector256<uint>, uint>(ref right);
                prt = pleft - pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) - Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) - Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) - Unsafe.Add(ref pright, 3);
                Unsafe.Add(ref prt, 4) = Unsafe.Add(ref pleft, 4) - Unsafe.Add(ref pright, 4);
                Unsafe.Add(ref prt, 5) = Unsafe.Add(ref pleft, 5) - Unsafe.Add(ref pright, 5);
                Unsafe.Add(ref prt, 6) = Unsafe.Add(ref pleft, 6) - Unsafe.Add(ref pright, 6);
                Unsafe.Add(ref prt, 7) = Unsafe.Add(ref pleft, 7) - Unsafe.Add(ref pright, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Subtract_Basic(Vector256<long> left, Vector256<long> right) {
                UnsafeEx.SkipInit(out Vector256<long> rt);
                ref long prt = ref Unsafe.As<Vector256<long>, long>(ref rt);
                ref long pleft = ref Unsafe.As<Vector256<long>, long>(ref left);
                ref long pright = ref Unsafe.As<Vector256<long>, long>(ref right);
                prt = pleft - pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) - Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) - Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) - Unsafe.Add(ref pright, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Subtract_Basic(Vector256<ulong> left, Vector256<ulong> right) {
                UnsafeEx.SkipInit(out Vector256<ulong> rt);
                ref ulong prt = ref Unsafe.As<Vector256<ulong>, ulong>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector256<ulong>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector256<ulong>, ulong>(ref right);
                prt = pleft - pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) - Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) - Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) - Unsafe.Add(ref pright, 3);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Xor_AcceleratedTypes"/>
            public static TypeCodeFlags Xor_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Xor{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> Xor<T>(Vector256<T> left, Vector256<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Xor(left, right);
#else
                return Xor_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Xor{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<T> Xor_Basic<T>(Vector256<T> left, Vector256<T> right) where T : struct {
                UnsafeEx.SkipInit(out Vector256<T> rt);
                ref ulong prt = ref Unsafe.As<Vector256<T>, ulong>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector256<T>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector256<T>, ulong>(ref right);
                prt = pleft ^ pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) ^ Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) ^ Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) ^ Unsafe.Add(ref pright, 3);
                return rt;
            }


#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
