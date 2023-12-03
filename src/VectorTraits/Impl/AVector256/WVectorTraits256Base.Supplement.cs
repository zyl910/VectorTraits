#define Sqrt_Float_Used

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Collections;
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
                if (Vector256.IsHardwareAccelerated) {
                    return Vector256.Abs(value);
                } else {
                    return Abs_Basic(value);
                }
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Abs(Vector256<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                if (Vector256.IsHardwareAccelerated) {
                    return Vector256.Abs(value);
                } else {
                    return Abs_Basic(value);
                }
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Abs(Vector256<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                if (Vector256.IsHardwareAccelerated) {
                    return Vector256.Abs(value);
                } else {
                    return Abs_Basic(value);
                }
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Abs(Vector256<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                if (Vector256.IsHardwareAccelerated) {
                    return Vector256.Abs(value);
                } else {
                    return Abs_Basic(value);
                }
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
                UnsafeUtil.SkipInit(out Vector256<float> rt);
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
                UnsafeUtil.SkipInit(out Vector256<double> rt);
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
                UnsafeUtil.SkipInit(out Vector256<sbyte> rt);
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
                UnsafeUtil.SkipInit(out Vector256<byte> rt);
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
                UnsafeUtil.SkipInit(out Vector256<short> rt);
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
                UnsafeUtil.SkipInit(out Vector256<ushort> rt);
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
                UnsafeUtil.SkipInit(out Vector256<int> rt);
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
                UnsafeUtil.SkipInit(out Vector256<uint> rt);
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
                UnsafeUtil.SkipInit(out Vector256<long> rt);
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
                UnsafeUtil.SkipInit(out Vector256<ulong> rt);
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
                UnsafeUtil.SkipInit(out Vector256<T> rt);
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
                UnsafeUtil.SkipInit(out Vector256<T> rt);
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
                UnsafeUtil.SkipInit(out Vector256<T> rt);
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
                UnsafeUtil.SkipInit(out Vector256<T> rt);
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
                UnsafeUtil.SkipInit(out Vector256<float> rt);
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
                UnsafeUtil.SkipInit(out Vector256<double> rt);
                ref double prt = ref Unsafe.As<Vector256<double>, double>(ref rt);
                ref double pleft = ref Unsafe.As<Vector256<double>, double>(ref left);
                ref double pright = ref Unsafe.As<Vector256<double>, double>(ref right);
                prt = pleft / pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) / Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) / Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) / Unsafe.Add(ref pright, 3);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Dot_AcceleratedTypes"/>
            public static TypeCodeFlags Dot_AcceleratedTypes {
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

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Dot(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Dot(left, right);
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Dot(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Dot(left, right);
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Dot(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Dot(left, right);
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Dot(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Dot(left, right);
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Dot(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Dot(left, right);
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Dot(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return (ushort)Vector256.Dot(left.AsInt16(), right.AsInt16());
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Dot(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Dot(left, right);
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Dot(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return (uint)Vector256.Dot(left.AsInt32(), right.AsInt32());
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Dot(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Dot(left, right);
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Dot(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Dot(left, right);
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Dot_Basic(Vector256<float> left, Vector256<float> right) {
                ref FixedArray8<float> pleft = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref left);
                ref FixedArray8<float> pright = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref right);
                float rt = pleft.I0 * pright.I0;
                rt += pleft.I1 * pright.I1;
                rt += pleft.I2 * pright.I2;
                rt += pleft.I3 * pright.I3;
                rt += pleft.I4 * pright.I4;
                rt += pleft.I5 * pright.I5;
                rt += pleft.I6 * pright.I6;
                rt += pleft.I7 * pright.I7;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Dot_Basic(Vector256<double> left, Vector256<double> right) {
                ref FixedArray4<double> pleft = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref left);
                ref FixedArray4<double> pright = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref right);
                double rt = pleft.I0 * pright.I0;
                rt += pleft.I1 * pright.I1;
                rt += pleft.I2 * pright.I2;
                rt += pleft.I3 * pright.I3;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Dot_Basic(Vector256<sbyte> left, Vector256<sbyte> right) {
                ref FixedArray32<sbyte> pleft = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref left);
                ref FixedArray32<sbyte> pright = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref right);
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
                rt += pleft.I16 * pright.I16;
                rt += pleft.I17 * pright.I17;
                rt += pleft.I18 * pright.I18;
                rt += pleft.I19 * pright.I19;
                rt += pleft.I20 * pright.I20;
                rt += pleft.I21 * pright.I21;
                rt += pleft.I22 * pright.I22;
                rt += pleft.I23 * pright.I23;
                rt += pleft.I24 * pright.I24;
                rt += pleft.I25 * pright.I25;
                rt += pleft.I26 * pright.I26;
                rt += pleft.I27 * pright.I27;
                rt += pleft.I28 * pright.I28;
                rt += pleft.I29 * pright.I29;
                rt += pleft.I30 * pright.I30;
                rt += pleft.I31 * pright.I31;
                return (sbyte)rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Dot_Basic(Vector256<byte> left, Vector256<byte> right) {
                ref FixedArray32<byte> pleft = ref Unsafe.As<Vector256<byte>, FixedArray32<byte>>(ref left);
                ref FixedArray32<byte> pright = ref Unsafe.As<Vector256<byte>, FixedArray32<byte>>(ref right);
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
                rt += pleft.I16 * pright.I16;
                rt += pleft.I17 * pright.I17;
                rt += pleft.I18 * pright.I18;
                rt += pleft.I19 * pright.I19;
                rt += pleft.I20 * pright.I20;
                rt += pleft.I21 * pright.I21;
                rt += pleft.I22 * pright.I22;
                rt += pleft.I23 * pright.I23;
                rt += pleft.I24 * pright.I24;
                rt += pleft.I25 * pright.I25;
                rt += pleft.I26 * pright.I26;
                rt += pleft.I27 * pright.I27;
                rt += pleft.I28 * pright.I28;
                rt += pleft.I29 * pright.I29;
                rt += pleft.I30 * pright.I30;
                rt += pleft.I31 * pright.I31;
                return (byte)rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Dot_Basic(Vector256<short> left, Vector256<short> right) {
                ref FixedArray16<short> pleft = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref left);
                ref FixedArray16<short> pright = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref right);
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
                return (short)rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Dot_Basic(Vector256<ushort> left, Vector256<ushort> right) {
                ref FixedArray16<ushort> pleft = ref Unsafe.As<Vector256<ushort>, FixedArray16<ushort>>(ref left);
                ref FixedArray16<ushort> pright = ref Unsafe.As<Vector256<ushort>, FixedArray16<ushort>>(ref right);
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
                return (ushort)rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Dot_Basic(Vector256<int> left, Vector256<int> right) {
                ref FixedArray8<int> pleft = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref left);
                ref FixedArray8<int> pright = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref right);
                int rt = pleft.I0 * pright.I0;
                rt += pleft.I1 * pright.I1;
                rt += pleft.I2 * pright.I2;
                rt += pleft.I3 * pright.I3;
                rt += pleft.I4 * pright.I4;
                rt += pleft.I5 * pright.I5;
                rt += pleft.I6 * pright.I6;
                rt += pleft.I7 * pright.I7;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Dot_Basic(Vector256<uint> left, Vector256<uint> right) {
                ref FixedArray8<uint> pleft = ref Unsafe.As<Vector256<uint>, FixedArray8<uint>>(ref left);
                ref FixedArray8<uint> pright = ref Unsafe.As<Vector256<uint>, FixedArray8<uint>>(ref right);
                uint rt = pleft.I0 * pright.I0;
                rt += pleft.I1 * pright.I1;
                rt += pleft.I2 * pright.I2;
                rt += pleft.I3 * pright.I3;
                rt += pleft.I4 * pright.I4;
                rt += pleft.I5 * pright.I5;
                rt += pleft.I6 * pright.I6;
                rt += pleft.I7 * pright.I7;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Dot_Basic(Vector256<long> left, Vector256<long> right) {
                ref FixedArray4<long> pleft = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref left);
                ref FixedArray4<long> pright = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref right);
                long rt = pleft.I0 * pright.I0;
                rt += pleft.I1 * pright.I1;
                rt += pleft.I2 * pright.I2;
                rt += pleft.I3 * pright.I3;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Dot(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Dot_Basic(Vector256<ulong> left, Vector256<ulong> right) {
                ref FixedArray4<ulong> pleft = ref Unsafe.As<Vector256<ulong>, FixedArray4<ulong>>(ref left);
                ref FixedArray4<ulong> pright = ref Unsafe.As<Vector256<ulong>, FixedArray4<ulong>>(ref right);
                ulong rt = pleft.I0 * pright.I0;
                rt += pleft.I1 * pright.I1;
                rt += pleft.I2 * pright.I2;
                rt += pleft.I3 * pright.I3;
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Equals_AcceleratedTypes"/>
            public static TypeCodeFlags Equals_AcceleratedTypes {
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

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Equals(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Equals(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Equals(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Equals(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Equals(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Equals(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Equals(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Equals(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Equals(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Equals(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Equals_Basic(Vector256<float> left, Vector256<float> right) {
                UnsafeUtil.SkipInit(out Vector256<float> rt);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<float>, FixedArray8<int>>(ref rt);
                ref FixedArray8<float> pleft = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref left);
                ref FixedArray8<float> pright = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 == pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 == pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 == pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 == pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 == pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 == pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 == pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 == pright.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Equals_Basic(Vector256<double> left, Vector256<double> right) {
                UnsafeUtil.SkipInit(out Vector256<double> rt);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<double>, FixedArray4<long>>(ref rt);
                ref FixedArray4<double> pleft = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref left);
                ref FixedArray4<double> pright = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 == pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 == pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 == pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 == pright.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Equals_Basic(Vector256<sbyte> left, Vector256<sbyte> right) {
                UnsafeUtil.SkipInit(out Vector256<sbyte> rt);
                ref FixedArray32<sbyte> p = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref rt);
                ref FixedArray32<sbyte> pleft = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref left);
                ref FixedArray32<sbyte> pright = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref right);
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
                p.I16 = (sbyte)BitMath.ToInt32Mask(pleft.I16 == pright.I16);
                p.I17 = (sbyte)BitMath.ToInt32Mask(pleft.I17 == pright.I17);
                p.I18 = (sbyte)BitMath.ToInt32Mask(pleft.I18 == pright.I18);
                p.I19 = (sbyte)BitMath.ToInt32Mask(pleft.I19 == pright.I19);
                p.I20 = (sbyte)BitMath.ToInt32Mask(pleft.I20 == pright.I20);
                p.I21 = (sbyte)BitMath.ToInt32Mask(pleft.I21 == pright.I21);
                p.I22 = (sbyte)BitMath.ToInt32Mask(pleft.I22 == pright.I22);
                p.I23 = (sbyte)BitMath.ToInt32Mask(pleft.I23 == pright.I23);
                p.I24 = (sbyte)BitMath.ToInt32Mask(pleft.I24 == pright.I24);
                p.I25 = (sbyte)BitMath.ToInt32Mask(pleft.I25 == pright.I25);
                p.I26 = (sbyte)BitMath.ToInt32Mask(pleft.I26 == pright.I26);
                p.I27 = (sbyte)BitMath.ToInt32Mask(pleft.I27 == pright.I27);
                p.I28 = (sbyte)BitMath.ToInt32Mask(pleft.I28 == pright.I28);
                p.I29 = (sbyte)BitMath.ToInt32Mask(pleft.I29 == pright.I29);
                p.I30 = (sbyte)BitMath.ToInt32Mask(pleft.I30 == pright.I30);
                p.I31 = (sbyte)BitMath.ToInt32Mask(pleft.I31 == pright.I31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Equals_Basic(Vector256<byte> left, Vector256<byte> right) {
                UnsafeUtil.SkipInit(out Vector256<byte> rt);
                ref FixedArray32<sbyte> p = ref Unsafe.As<Vector256<byte>, FixedArray32<sbyte>>(ref rt);
                ref FixedArray32<byte> pleft = ref Unsafe.As<Vector256<byte>, FixedArray32<byte>>(ref left);
                ref FixedArray32<byte> pright = ref Unsafe.As<Vector256<byte>, FixedArray32<byte>>(ref right);
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
                p.I16 = (sbyte)BitMath.ToInt32Mask(pleft.I16 == pright.I16);
                p.I17 = (sbyte)BitMath.ToInt32Mask(pleft.I17 == pright.I17);
                p.I18 = (sbyte)BitMath.ToInt32Mask(pleft.I18 == pright.I18);
                p.I19 = (sbyte)BitMath.ToInt32Mask(pleft.I19 == pright.I19);
                p.I20 = (sbyte)BitMath.ToInt32Mask(pleft.I20 == pright.I20);
                p.I21 = (sbyte)BitMath.ToInt32Mask(pleft.I21 == pright.I21);
                p.I22 = (sbyte)BitMath.ToInt32Mask(pleft.I22 == pright.I22);
                p.I23 = (sbyte)BitMath.ToInt32Mask(pleft.I23 == pright.I23);
                p.I24 = (sbyte)BitMath.ToInt32Mask(pleft.I24 == pright.I24);
                p.I25 = (sbyte)BitMath.ToInt32Mask(pleft.I25 == pright.I25);
                p.I26 = (sbyte)BitMath.ToInt32Mask(pleft.I26 == pright.I26);
                p.I27 = (sbyte)BitMath.ToInt32Mask(pleft.I27 == pright.I27);
                p.I28 = (sbyte)BitMath.ToInt32Mask(pleft.I28 == pright.I28);
                p.I29 = (sbyte)BitMath.ToInt32Mask(pleft.I29 == pright.I29);
                p.I30 = (sbyte)BitMath.ToInt32Mask(pleft.I30 == pright.I30);
                p.I31 = (sbyte)BitMath.ToInt32Mask(pleft.I31 == pright.I31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Equals_Basic(Vector256<short> left, Vector256<short> right) {
                UnsafeUtil.SkipInit(out Vector256<short> rt);
                ref FixedArray16<short> p = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref rt);
                ref FixedArray16<short> pleft = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref left);
                ref FixedArray16<short> pright = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref right);
                p.I0 = (short)BitMath.ToInt32Mask(pleft.I0 == pright.I0);
                p.I1 = (short)BitMath.ToInt32Mask(pleft.I1 == pright.I1);
                p.I2 = (short)BitMath.ToInt32Mask(pleft.I2 == pright.I2);
                p.I3 = (short)BitMath.ToInt32Mask(pleft.I3 == pright.I3);
                p.I4 = (short)BitMath.ToInt32Mask(pleft.I4 == pright.I4);
                p.I5 = (short)BitMath.ToInt32Mask(pleft.I5 == pright.I5);
                p.I6 = (short)BitMath.ToInt32Mask(pleft.I6 == pright.I6);
                p.I7 = (short)BitMath.ToInt32Mask(pleft.I7 == pright.I7);
                p.I8 = (short)BitMath.ToInt32Mask(pleft.I8 == pright.I8);
                p.I9 = (short)BitMath.ToInt32Mask(pleft.I9 == pright.I9);
                p.I10 = (short)BitMath.ToInt32Mask(pleft.I10 == pright.I10);
                p.I11 = (short)BitMath.ToInt32Mask(pleft.I11 == pright.I11);
                p.I12 = (short)BitMath.ToInt32Mask(pleft.I12 == pright.I12);
                p.I13 = (short)BitMath.ToInt32Mask(pleft.I13 == pright.I13);
                p.I14 = (short)BitMath.ToInt32Mask(pleft.I14 == pright.I14);
                p.I15 = (short)BitMath.ToInt32Mask(pleft.I15 == pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Equals_Basic(Vector256<ushort> left, Vector256<ushort> right) {
                UnsafeUtil.SkipInit(out Vector256<ushort> rt);
                ref FixedArray16<short> p = ref Unsafe.As<Vector256<ushort>, FixedArray16<short>>(ref rt);
                ref FixedArray16<ushort> pleft = ref Unsafe.As<Vector256<ushort>, FixedArray16<ushort>>(ref left);
                ref FixedArray16<ushort> pright = ref Unsafe.As<Vector256<ushort>, FixedArray16<ushort>>(ref right);
                p.I0 = (short)BitMath.ToInt32Mask(pleft.I0 == pright.I0);
                p.I1 = (short)BitMath.ToInt32Mask(pleft.I1 == pright.I1);
                p.I2 = (short)BitMath.ToInt32Mask(pleft.I2 == pright.I2);
                p.I3 = (short)BitMath.ToInt32Mask(pleft.I3 == pright.I3);
                p.I4 = (short)BitMath.ToInt32Mask(pleft.I4 == pright.I4);
                p.I5 = (short)BitMath.ToInt32Mask(pleft.I5 == pright.I5);
                p.I6 = (short)BitMath.ToInt32Mask(pleft.I6 == pright.I6);
                p.I7 = (short)BitMath.ToInt32Mask(pleft.I7 == pright.I7);
                p.I8 = (short)BitMath.ToInt32Mask(pleft.I8 == pright.I8);
                p.I9 = (short)BitMath.ToInt32Mask(pleft.I9 == pright.I9);
                p.I10 = (short)BitMath.ToInt32Mask(pleft.I10 == pright.I10);
                p.I11 = (short)BitMath.ToInt32Mask(pleft.I11 == pright.I11);
                p.I12 = (short)BitMath.ToInt32Mask(pleft.I12 == pright.I12);
                p.I13 = (short)BitMath.ToInt32Mask(pleft.I13 == pright.I13);
                p.I14 = (short)BitMath.ToInt32Mask(pleft.I14 == pright.I14);
                p.I15 = (short)BitMath.ToInt32Mask(pleft.I15 == pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Equals_Basic(Vector256<int> left, Vector256<int> right) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                ref FixedArray8<int> pleft = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref left);
                ref FixedArray8<int> pright = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 == pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 == pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 == pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 == pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 == pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 == pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 == pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 == pright.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Equals_Basic(Vector256<uint> left, Vector256<uint> right) {
                UnsafeUtil.SkipInit(out Vector256<uint> rt);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<uint>, FixedArray8<int>>(ref rt);
                ref FixedArray8<uint> pleft = ref Unsafe.As<Vector256<uint>, FixedArray8<uint>>(ref left);
                ref FixedArray8<uint> pright = ref Unsafe.As<Vector256<uint>, FixedArray8<uint>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 == pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 == pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 == pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 == pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 == pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 == pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 == pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 == pright.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Equals_Basic(Vector256<long> left, Vector256<long> right) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                ref FixedArray4<long> pleft = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref left);
                ref FixedArray4<long> pright = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 == pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 == pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 == pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 == pright.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Equals(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Equals_Basic(Vector256<ulong> left, Vector256<ulong> right) {
                UnsafeUtil.SkipInit(out Vector256<ulong> rt);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<ulong>, FixedArray4<long>>(ref rt);
                ref FixedArray4<ulong> pleft = ref Unsafe.As<Vector256<ulong>, FixedArray4<ulong>>(ref left);
                ref FixedArray4<ulong> pright = ref Unsafe.As<Vector256<ulong>, FixedArray4<ulong>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 == pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 == pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 == pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 == pright.I3);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.EqualsAll_AcceleratedTypes"/>
            public static TypeCodeFlags EqualsAll_AcceleratedTypes {
                get {
                    return Equals_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector256<float> left, Vector256<float> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector256<double> left, Vector256<double> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector256<sbyte> left, Vector256<sbyte> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector256<byte> left, Vector256<byte> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector256<short> left, Vector256<short> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector256<ushort> left, Vector256<ushort> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector256<int> left, Vector256<int> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector256<uint> left, Vector256<uint> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector256<long> left, Vector256<long> right) {
                return YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAll(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector256<ulong> left, Vector256<ulong> right) {
                return YIsAllTrue(Equals(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits256.EqualsAny_AcceleratedTypes"/>
            public static TypeCodeFlags EqualsAny_AcceleratedTypes {
                get {
                    return Equals_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector256<float> left, Vector256<float> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector256<double> left, Vector256<double> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector256<sbyte> left, Vector256<sbyte> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector256<byte> left, Vector256<byte> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector256<short> left, Vector256<short> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector256<ushort> left, Vector256<ushort> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector256<int> left, Vector256<int> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector256<uint> left, Vector256<uint> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector256<long> left, Vector256<long> right) {
                return YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.EqualsAny(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector256<ulong> left, Vector256<ulong> right) {
                return YIsAnyTrue(Equals(left, right));
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
                UnsafeUtil.SkipInit(out Vector256<float> rt);
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
                UnsafeUtil.SkipInit(out Vector256<double> rt);
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
                UnsafeUtil.SkipInit(out Vector256<sbyte> rt);
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
                UnsafeUtil.SkipInit(out Vector256<byte> rt);
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
                UnsafeUtil.SkipInit(out Vector256<short> rt);
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
                UnsafeUtil.SkipInit(out Vector256<ushort> rt);
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
                UnsafeUtil.SkipInit(out Vector256<int> rt);
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
                UnsafeUtil.SkipInit(out Vector256<uint> rt);
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
                UnsafeUtil.SkipInit(out Vector256<long> rt);
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
                UnsafeUtil.SkipInit(out Vector256<ulong> rt);
                ref long prt = ref Unsafe.As<Vector256<ulong>, long>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector256<ulong>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector256<ulong>, ulong>(ref right);
                prt = BitMath.ToInt32Mask(pleft > pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) > Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) > Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) > Unsafe.Add(ref pright, 3));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanAll_AcceleratedTypes {
                get {
                    return GreaterThan_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector256<float> left, Vector256<float> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector256<double> left, Vector256<double> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector256<sbyte> left, Vector256<sbyte> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector256<byte> left, Vector256<byte> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector256<short> left, Vector256<short> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector256<ushort> left, Vector256<ushort> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector256<int> left, Vector256<int> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector256<uint> left, Vector256<uint> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector256<long> left, Vector256<long> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAll(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector256<ulong> left, Vector256<ulong> right) {
                return YIsAllTrue(GreaterThan(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanAny_AcceleratedTypes {
                get {
                    return GreaterThan_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector256<float> left, Vector256<float> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector256<double> left, Vector256<double> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector256<sbyte> left, Vector256<sbyte> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector256<byte> left, Vector256<byte> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector256<short> left, Vector256<short> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector256<ushort> left, Vector256<ushort> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector256<int> left, Vector256<int> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector256<uint> left, Vector256<uint> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector256<long> left, Vector256<long> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanAny(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector256<ulong> left, Vector256<ulong> right) {
                return YIsAnyTrue(GreaterThan(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanOrEqual_AcceleratedTypes {
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

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> GreaterThanOrEqual(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> GreaterThanOrEqual(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> GreaterThanOrEqual(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> GreaterThanOrEqual(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> GreaterThanOrEqual(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> GreaterThanOrEqual(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> GreaterThanOrEqual(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> GreaterThanOrEqual(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> GreaterThanOrEqual(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> GreaterThanOrEqual(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> GreaterThanOrEqual_Basic(Vector256<float> left, Vector256<float> right) {
                UnsafeUtil.SkipInit(out Vector256<float> rt);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<float>, FixedArray8<int>>(ref rt);
                ref FixedArray8<float> pleft = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref left);
                ref FixedArray8<float> pright = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 >= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 >= pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 >= pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 >= pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 >= pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 >= pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 >= pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 >= pright.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> GreaterThanOrEqual_Basic(Vector256<double> left, Vector256<double> right) {
                UnsafeUtil.SkipInit(out Vector256<double> rt);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<double>, FixedArray4<long>>(ref rt);
                ref FixedArray4<double> pleft = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref left);
                ref FixedArray4<double> pright = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 >= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 >= pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 >= pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 >= pright.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> GreaterThanOrEqual_Basic(Vector256<sbyte> left, Vector256<sbyte> right) {
                UnsafeUtil.SkipInit(out Vector256<sbyte> rt);
                ref FixedArray32<sbyte> p = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref rt);
                ref FixedArray32<sbyte> pleft = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref left);
                ref FixedArray32<sbyte> pright = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref right);
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
                p.I16 = (sbyte)BitMath.ToInt32Mask(pleft.I16 >= pright.I16);
                p.I17 = (sbyte)BitMath.ToInt32Mask(pleft.I17 >= pright.I17);
                p.I18 = (sbyte)BitMath.ToInt32Mask(pleft.I18 >= pright.I18);
                p.I19 = (sbyte)BitMath.ToInt32Mask(pleft.I19 >= pright.I19);
                p.I20 = (sbyte)BitMath.ToInt32Mask(pleft.I20 >= pright.I20);
                p.I21 = (sbyte)BitMath.ToInt32Mask(pleft.I21 >= pright.I21);
                p.I22 = (sbyte)BitMath.ToInt32Mask(pleft.I22 >= pright.I22);
                p.I23 = (sbyte)BitMath.ToInt32Mask(pleft.I23 >= pright.I23);
                p.I24 = (sbyte)BitMath.ToInt32Mask(pleft.I24 >= pright.I24);
                p.I25 = (sbyte)BitMath.ToInt32Mask(pleft.I25 >= pright.I25);
                p.I26 = (sbyte)BitMath.ToInt32Mask(pleft.I26 >= pright.I26);
                p.I27 = (sbyte)BitMath.ToInt32Mask(pleft.I27 >= pright.I27);
                p.I28 = (sbyte)BitMath.ToInt32Mask(pleft.I28 >= pright.I28);
                p.I29 = (sbyte)BitMath.ToInt32Mask(pleft.I29 >= pright.I29);
                p.I30 = (sbyte)BitMath.ToInt32Mask(pleft.I30 >= pright.I30);
                p.I31 = (sbyte)BitMath.ToInt32Mask(pleft.I31 >= pright.I31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> GreaterThanOrEqual_Basic(Vector256<byte> left, Vector256<byte> right) {
                UnsafeUtil.SkipInit(out Vector256<byte> rt);
                ref FixedArray32<sbyte> p = ref Unsafe.As<Vector256<byte>, FixedArray32<sbyte>>(ref rt);
                ref FixedArray32<byte> pleft = ref Unsafe.As<Vector256<byte>, FixedArray32<byte>>(ref left);
                ref FixedArray32<byte> pright = ref Unsafe.As<Vector256<byte>, FixedArray32<byte>>(ref right);
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
                p.I16 = (sbyte)BitMath.ToInt32Mask(pleft.I16 >= pright.I16);
                p.I17 = (sbyte)BitMath.ToInt32Mask(pleft.I17 >= pright.I17);
                p.I18 = (sbyte)BitMath.ToInt32Mask(pleft.I18 >= pright.I18);
                p.I19 = (sbyte)BitMath.ToInt32Mask(pleft.I19 >= pright.I19);
                p.I20 = (sbyte)BitMath.ToInt32Mask(pleft.I20 >= pright.I20);
                p.I21 = (sbyte)BitMath.ToInt32Mask(pleft.I21 >= pright.I21);
                p.I22 = (sbyte)BitMath.ToInt32Mask(pleft.I22 >= pright.I22);
                p.I23 = (sbyte)BitMath.ToInt32Mask(pleft.I23 >= pright.I23);
                p.I24 = (sbyte)BitMath.ToInt32Mask(pleft.I24 >= pright.I24);
                p.I25 = (sbyte)BitMath.ToInt32Mask(pleft.I25 >= pright.I25);
                p.I26 = (sbyte)BitMath.ToInt32Mask(pleft.I26 >= pright.I26);
                p.I27 = (sbyte)BitMath.ToInt32Mask(pleft.I27 >= pright.I27);
                p.I28 = (sbyte)BitMath.ToInt32Mask(pleft.I28 >= pright.I28);
                p.I29 = (sbyte)BitMath.ToInt32Mask(pleft.I29 >= pright.I29);
                p.I30 = (sbyte)BitMath.ToInt32Mask(pleft.I30 >= pright.I30);
                p.I31 = (sbyte)BitMath.ToInt32Mask(pleft.I31 >= pright.I31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> GreaterThanOrEqual_Basic(Vector256<short> left, Vector256<short> right) {
                UnsafeUtil.SkipInit(out Vector256<short> rt);
                ref FixedArray16<short> p = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref rt);
                ref FixedArray16<short> pleft = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref left);
                ref FixedArray16<short> pright = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref right);
                p.I0 = (short)BitMath.ToInt32Mask(pleft.I0 >= pright.I0);
                p.I1 = (short)BitMath.ToInt32Mask(pleft.I1 >= pright.I1);
                p.I2 = (short)BitMath.ToInt32Mask(pleft.I2 >= pright.I2);
                p.I3 = (short)BitMath.ToInt32Mask(pleft.I3 >= pright.I3);
                p.I4 = (short)BitMath.ToInt32Mask(pleft.I4 >= pright.I4);
                p.I5 = (short)BitMath.ToInt32Mask(pleft.I5 >= pright.I5);
                p.I6 = (short)BitMath.ToInt32Mask(pleft.I6 >= pright.I6);
                p.I7 = (short)BitMath.ToInt32Mask(pleft.I7 >= pright.I7);
                p.I8 = (short)BitMath.ToInt32Mask(pleft.I8 >= pright.I8);
                p.I9 = (short)BitMath.ToInt32Mask(pleft.I9 >= pright.I9);
                p.I10 = (short)BitMath.ToInt32Mask(pleft.I10 >= pright.I10);
                p.I11 = (short)BitMath.ToInt32Mask(pleft.I11 >= pright.I11);
                p.I12 = (short)BitMath.ToInt32Mask(pleft.I12 >= pright.I12);
                p.I13 = (short)BitMath.ToInt32Mask(pleft.I13 >= pright.I13);
                p.I14 = (short)BitMath.ToInt32Mask(pleft.I14 >= pright.I14);
                p.I15 = (short)BitMath.ToInt32Mask(pleft.I15 >= pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> GreaterThanOrEqual_Basic(Vector256<ushort> left, Vector256<ushort> right) {
                UnsafeUtil.SkipInit(out Vector256<ushort> rt);
                ref FixedArray16<short> p = ref Unsafe.As<Vector256<ushort>, FixedArray16<short>>(ref rt);
                ref FixedArray16<ushort> pleft = ref Unsafe.As<Vector256<ushort>, FixedArray16<ushort>>(ref left);
                ref FixedArray16<ushort> pright = ref Unsafe.As<Vector256<ushort>, FixedArray16<ushort>>(ref right);
                p.I0 = (short)BitMath.ToInt32Mask(pleft.I0 >= pright.I0);
                p.I1 = (short)BitMath.ToInt32Mask(pleft.I1 >= pright.I1);
                p.I2 = (short)BitMath.ToInt32Mask(pleft.I2 >= pright.I2);
                p.I3 = (short)BitMath.ToInt32Mask(pleft.I3 >= pright.I3);
                p.I4 = (short)BitMath.ToInt32Mask(pleft.I4 >= pright.I4);
                p.I5 = (short)BitMath.ToInt32Mask(pleft.I5 >= pright.I5);
                p.I6 = (short)BitMath.ToInt32Mask(pleft.I6 >= pright.I6);
                p.I7 = (short)BitMath.ToInt32Mask(pleft.I7 >= pright.I7);
                p.I8 = (short)BitMath.ToInt32Mask(pleft.I8 >= pright.I8);
                p.I9 = (short)BitMath.ToInt32Mask(pleft.I9 >= pright.I9);
                p.I10 = (short)BitMath.ToInt32Mask(pleft.I10 >= pright.I10);
                p.I11 = (short)BitMath.ToInt32Mask(pleft.I11 >= pright.I11);
                p.I12 = (short)BitMath.ToInt32Mask(pleft.I12 >= pright.I12);
                p.I13 = (short)BitMath.ToInt32Mask(pleft.I13 >= pright.I13);
                p.I14 = (short)BitMath.ToInt32Mask(pleft.I14 >= pright.I14);
                p.I15 = (short)BitMath.ToInt32Mask(pleft.I15 >= pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> GreaterThanOrEqual_Basic(Vector256<int> left, Vector256<int> right) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                ref FixedArray8<int> pleft = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref left);
                ref FixedArray8<int> pright = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 >= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 >= pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 >= pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 >= pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 >= pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 >= pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 >= pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 >= pright.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> GreaterThanOrEqual_Basic(Vector256<uint> left, Vector256<uint> right) {
                UnsafeUtil.SkipInit(out Vector256<uint> rt);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<uint>, FixedArray8<int>>(ref rt);
                ref FixedArray8<uint> pleft = ref Unsafe.As<Vector256<uint>, FixedArray8<uint>>(ref left);
                ref FixedArray8<uint> pright = ref Unsafe.As<Vector256<uint>, FixedArray8<uint>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 >= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 >= pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 >= pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 >= pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 >= pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 >= pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 >= pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 >= pright.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> GreaterThanOrEqual_Basic(Vector256<long> left, Vector256<long> right) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                ref FixedArray4<long> pleft = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref left);
                ref FixedArray4<long> pright = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 >= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 >= pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 >= pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 >= pright.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqual(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> GreaterThanOrEqual_Basic(Vector256<ulong> left, Vector256<ulong> right) {
                UnsafeUtil.SkipInit(out Vector256<ulong> rt);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<ulong>, FixedArray4<long>>(ref rt);
                ref FixedArray4<ulong> pleft = ref Unsafe.As<Vector256<ulong>, FixedArray4<ulong>>(ref left);
                ref FixedArray4<ulong> pright = ref Unsafe.As<Vector256<ulong>, FixedArray4<ulong>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 >= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 >= pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 >= pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 >= pright.I3);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAll_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanOrEqualAll_AcceleratedTypes {
                get {
                    return GreaterThanOrEqual_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAll(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector256<float> left, Vector256<float> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAll(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector256<double> left, Vector256<double> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAll(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector256<sbyte> left, Vector256<sbyte> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAll(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector256<byte> left, Vector256<byte> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAll(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector256<short> left, Vector256<short> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAll(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector256<ushort> left, Vector256<ushort> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAll(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector256<int> left, Vector256<int> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAll(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector256<uint> left, Vector256<uint> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAll(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector256<long> left, Vector256<long> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAll(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector256<ulong> left, Vector256<ulong> right) {
                return YIsAllTrue(GreaterThanOrEqual(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAny_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanOrEqualAny_AcceleratedTypes {
                get {
                    return GreaterThanOrEqual_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAny(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector256<float> left, Vector256<float> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAny(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector256<double> left, Vector256<double> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAny(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector256<sbyte> left, Vector256<sbyte> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAny(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector256<byte> left, Vector256<byte> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAny(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector256<short> left, Vector256<short> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAny(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector256<ushort> left, Vector256<ushort> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAny(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector256<int> left, Vector256<int> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAny(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector256<uint> left, Vector256<uint> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAny(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector256<long> left, Vector256<long> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.GreaterThanOrEqualAny(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector256<ulong> left, Vector256<ulong> right) {
                return YIsAnyTrue(GreaterThanOrEqual(left, right));
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
                UnsafeUtil.SkipInit(out Vector256<float> rt);
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
                UnsafeUtil.SkipInit(out Vector256<double> rt);
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
                UnsafeUtil.SkipInit(out Vector256<sbyte> rt);
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
                UnsafeUtil.SkipInit(out Vector256<byte> rt);
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
                UnsafeUtil.SkipInit(out Vector256<short> rt);
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
                UnsafeUtil.SkipInit(out Vector256<ushort> rt);
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
                UnsafeUtil.SkipInit(out Vector256<int> rt);
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
                UnsafeUtil.SkipInit(out Vector256<uint> rt);
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
                UnsafeUtil.SkipInit(out Vector256<long> rt);
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
                UnsafeUtil.SkipInit(out Vector256<ulong> rt);
                ref long prt = ref Unsafe.As<Vector256<ulong>, long>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector256<ulong>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector256<ulong>, ulong>(ref right);
                prt = BitMath.ToInt32Mask(pleft < pright);
                Unsafe.Add(ref prt, 1) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 1) < Unsafe.Add(ref pright, 1));
                Unsafe.Add(ref prt, 2) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 2) < Unsafe.Add(ref pright, 2));
                Unsafe.Add(ref prt, 3) = BitMath.ToInt32Mask(Unsafe.Add(ref pleft, 3) < Unsafe.Add(ref pright, 3));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.LessThanAll_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanAll_AcceleratedTypes {
                get {
                    return LessThan_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanAll(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector256<float> left, Vector256<float> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanAll(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector256<double> left, Vector256<double> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanAll(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector256<sbyte> left, Vector256<sbyte> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanAll(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector256<byte> left, Vector256<byte> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanAll(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector256<short> left, Vector256<short> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanAll(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector256<ushort> left, Vector256<ushort> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanAll(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector256<int> left, Vector256<int> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanAll(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector256<uint> left, Vector256<uint> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanAll(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector256<long> left, Vector256<long> right) {
                return YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanAll(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector256<ulong> left, Vector256<ulong> right) {
                return YIsAllTrue(LessThan(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits256.LessThanAny_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanAny_AcceleratedTypes {
                get {
                    return LessThan_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanAny(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector256<float> left, Vector256<float> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanAny(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector256<double> left, Vector256<double> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanAny(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector256<sbyte> left, Vector256<sbyte> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanAny(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector256<byte> left, Vector256<byte> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanAny(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector256<short> left, Vector256<short> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanAny(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector256<ushort> left, Vector256<ushort> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanAny(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector256<int> left, Vector256<int> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanAny(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector256<uint> left, Vector256<uint> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanAny(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector256<long> left, Vector256<long> right) {
                return YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanAny(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector256<ulong> left, Vector256<ulong> right) {
                return YIsAnyTrue(LessThan(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqual_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanOrEqual_AcceleratedTypes {
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

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqual(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> LessThanOrEqual(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqual(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> LessThanOrEqual(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqual(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> LessThanOrEqual(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqual(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> LessThanOrEqual(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqual(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> LessThanOrEqual(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqual(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> LessThanOrEqual(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqual(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> LessThanOrEqual(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqual(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> LessThanOrEqual(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqual(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> LessThanOrEqual(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqual(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> LessThanOrEqual(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqual(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> LessThanOrEqual_Basic(Vector256<float> left, Vector256<float> right) {
                UnsafeUtil.SkipInit(out Vector256<float> rt);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<float>, FixedArray8<int>>(ref rt);
                ref FixedArray8<float> pleft = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref left);
                ref FixedArray8<float> pright = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 <= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 <= pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 <= pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 <= pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 <= pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 <= pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 <= pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 <= pright.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqual(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> LessThanOrEqual_Basic(Vector256<double> left, Vector256<double> right) {
                UnsafeUtil.SkipInit(out Vector256<double> rt);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<double>, FixedArray4<long>>(ref rt);
                ref FixedArray4<double> pleft = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref left);
                ref FixedArray4<double> pright = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 <= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 <= pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 <= pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 <= pright.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqual(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> LessThanOrEqual_Basic(Vector256<sbyte> left, Vector256<sbyte> right) {
                UnsafeUtil.SkipInit(out Vector256<sbyte> rt);
                ref FixedArray32<sbyte> p = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref rt);
                ref FixedArray32<sbyte> pleft = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref left);
                ref FixedArray32<sbyte> pright = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref right);
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
                p.I16 = (sbyte)BitMath.ToInt32Mask(pleft.I16 <= pright.I16);
                p.I17 = (sbyte)BitMath.ToInt32Mask(pleft.I17 <= pright.I17);
                p.I18 = (sbyte)BitMath.ToInt32Mask(pleft.I18 <= pright.I18);
                p.I19 = (sbyte)BitMath.ToInt32Mask(pleft.I19 <= pright.I19);
                p.I20 = (sbyte)BitMath.ToInt32Mask(pleft.I20 <= pright.I20);
                p.I21 = (sbyte)BitMath.ToInt32Mask(pleft.I21 <= pright.I21);
                p.I22 = (sbyte)BitMath.ToInt32Mask(pleft.I22 <= pright.I22);
                p.I23 = (sbyte)BitMath.ToInt32Mask(pleft.I23 <= pright.I23);
                p.I24 = (sbyte)BitMath.ToInt32Mask(pleft.I24 <= pright.I24);
                p.I25 = (sbyte)BitMath.ToInt32Mask(pleft.I25 <= pright.I25);
                p.I26 = (sbyte)BitMath.ToInt32Mask(pleft.I26 <= pright.I26);
                p.I27 = (sbyte)BitMath.ToInt32Mask(pleft.I27 <= pright.I27);
                p.I28 = (sbyte)BitMath.ToInt32Mask(pleft.I28 <= pright.I28);
                p.I29 = (sbyte)BitMath.ToInt32Mask(pleft.I29 <= pright.I29);
                p.I30 = (sbyte)BitMath.ToInt32Mask(pleft.I30 <= pright.I30);
                p.I31 = (sbyte)BitMath.ToInt32Mask(pleft.I31 <= pright.I31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqual(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> LessThanOrEqual_Basic(Vector256<byte> left, Vector256<byte> right) {
                UnsafeUtil.SkipInit(out Vector256<byte> rt);
                ref FixedArray32<sbyte> p = ref Unsafe.As<Vector256<byte>, FixedArray32<sbyte>>(ref rt);
                ref FixedArray32<byte> pleft = ref Unsafe.As<Vector256<byte>, FixedArray32<byte>>(ref left);
                ref FixedArray32<byte> pright = ref Unsafe.As<Vector256<byte>, FixedArray32<byte>>(ref right);
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
                p.I16 = (sbyte)BitMath.ToInt32Mask(pleft.I16 <= pright.I16);
                p.I17 = (sbyte)BitMath.ToInt32Mask(pleft.I17 <= pright.I17);
                p.I18 = (sbyte)BitMath.ToInt32Mask(pleft.I18 <= pright.I18);
                p.I19 = (sbyte)BitMath.ToInt32Mask(pleft.I19 <= pright.I19);
                p.I20 = (sbyte)BitMath.ToInt32Mask(pleft.I20 <= pright.I20);
                p.I21 = (sbyte)BitMath.ToInt32Mask(pleft.I21 <= pright.I21);
                p.I22 = (sbyte)BitMath.ToInt32Mask(pleft.I22 <= pright.I22);
                p.I23 = (sbyte)BitMath.ToInt32Mask(pleft.I23 <= pright.I23);
                p.I24 = (sbyte)BitMath.ToInt32Mask(pleft.I24 <= pright.I24);
                p.I25 = (sbyte)BitMath.ToInt32Mask(pleft.I25 <= pright.I25);
                p.I26 = (sbyte)BitMath.ToInt32Mask(pleft.I26 <= pright.I26);
                p.I27 = (sbyte)BitMath.ToInt32Mask(pleft.I27 <= pright.I27);
                p.I28 = (sbyte)BitMath.ToInt32Mask(pleft.I28 <= pright.I28);
                p.I29 = (sbyte)BitMath.ToInt32Mask(pleft.I29 <= pright.I29);
                p.I30 = (sbyte)BitMath.ToInt32Mask(pleft.I30 <= pright.I30);
                p.I31 = (sbyte)BitMath.ToInt32Mask(pleft.I31 <= pright.I31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqual(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> LessThanOrEqual_Basic(Vector256<short> left, Vector256<short> right) {
                UnsafeUtil.SkipInit(out Vector256<short> rt);
                ref FixedArray16<short> p = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref rt);
                ref FixedArray16<short> pleft = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref left);
                ref FixedArray16<short> pright = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref right);
                p.I0 = (short)BitMath.ToInt32Mask(pleft.I0 <= pright.I0);
                p.I1 = (short)BitMath.ToInt32Mask(pleft.I1 <= pright.I1);
                p.I2 = (short)BitMath.ToInt32Mask(pleft.I2 <= pright.I2);
                p.I3 = (short)BitMath.ToInt32Mask(pleft.I3 <= pright.I3);
                p.I4 = (short)BitMath.ToInt32Mask(pleft.I4 <= pright.I4);
                p.I5 = (short)BitMath.ToInt32Mask(pleft.I5 <= pright.I5);
                p.I6 = (short)BitMath.ToInt32Mask(pleft.I6 <= pright.I6);
                p.I7 = (short)BitMath.ToInt32Mask(pleft.I7 <= pright.I7);
                p.I8 = (short)BitMath.ToInt32Mask(pleft.I8 <= pright.I8);
                p.I9 = (short)BitMath.ToInt32Mask(pleft.I9 <= pright.I9);
                p.I10 = (short)BitMath.ToInt32Mask(pleft.I10 <= pright.I10);
                p.I11 = (short)BitMath.ToInt32Mask(pleft.I11 <= pright.I11);
                p.I12 = (short)BitMath.ToInt32Mask(pleft.I12 <= pright.I12);
                p.I13 = (short)BitMath.ToInt32Mask(pleft.I13 <= pright.I13);
                p.I14 = (short)BitMath.ToInt32Mask(pleft.I14 <= pright.I14);
                p.I15 = (short)BitMath.ToInt32Mask(pleft.I15 <= pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqual(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> LessThanOrEqual_Basic(Vector256<ushort> left, Vector256<ushort> right) {
                UnsafeUtil.SkipInit(out Vector256<ushort> rt);
                ref FixedArray16<short> p = ref Unsafe.As<Vector256<ushort>, FixedArray16<short>>(ref rt);
                ref FixedArray16<ushort> pleft = ref Unsafe.As<Vector256<ushort>, FixedArray16<ushort>>(ref left);
                ref FixedArray16<ushort> pright = ref Unsafe.As<Vector256<ushort>, FixedArray16<ushort>>(ref right);
                p.I0 = (short)BitMath.ToInt32Mask(pleft.I0 <= pright.I0);
                p.I1 = (short)BitMath.ToInt32Mask(pleft.I1 <= pright.I1);
                p.I2 = (short)BitMath.ToInt32Mask(pleft.I2 <= pright.I2);
                p.I3 = (short)BitMath.ToInt32Mask(pleft.I3 <= pright.I3);
                p.I4 = (short)BitMath.ToInt32Mask(pleft.I4 <= pright.I4);
                p.I5 = (short)BitMath.ToInt32Mask(pleft.I5 <= pright.I5);
                p.I6 = (short)BitMath.ToInt32Mask(pleft.I6 <= pright.I6);
                p.I7 = (short)BitMath.ToInt32Mask(pleft.I7 <= pright.I7);
                p.I8 = (short)BitMath.ToInt32Mask(pleft.I8 <= pright.I8);
                p.I9 = (short)BitMath.ToInt32Mask(pleft.I9 <= pright.I9);
                p.I10 = (short)BitMath.ToInt32Mask(pleft.I10 <= pright.I10);
                p.I11 = (short)BitMath.ToInt32Mask(pleft.I11 <= pright.I11);
                p.I12 = (short)BitMath.ToInt32Mask(pleft.I12 <= pright.I12);
                p.I13 = (short)BitMath.ToInt32Mask(pleft.I13 <= pright.I13);
                p.I14 = (short)BitMath.ToInt32Mask(pleft.I14 <= pright.I14);
                p.I15 = (short)BitMath.ToInt32Mask(pleft.I15 <= pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqual(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> LessThanOrEqual_Basic(Vector256<int> left, Vector256<int> right) {
                UnsafeUtil.SkipInit(out Vector256<int> rt);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
                ref FixedArray8<int> pleft = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref left);
                ref FixedArray8<int> pright = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 <= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 <= pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 <= pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 <= pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 <= pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 <= pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 <= pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 <= pright.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqual(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> LessThanOrEqual_Basic(Vector256<uint> left, Vector256<uint> right) {
                UnsafeUtil.SkipInit(out Vector256<uint> rt);
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<uint>, FixedArray8<int>>(ref rt);
                ref FixedArray8<uint> pleft = ref Unsafe.As<Vector256<uint>, FixedArray8<uint>>(ref left);
                ref FixedArray8<uint> pright = ref Unsafe.As<Vector256<uint>, FixedArray8<uint>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 <= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 <= pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 <= pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 <= pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 <= pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 <= pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 <= pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 <= pright.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqual(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> LessThanOrEqual_Basic(Vector256<long> left, Vector256<long> right) {
                UnsafeUtil.SkipInit(out Vector256<long> rt);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                ref FixedArray4<long> pleft = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref left);
                ref FixedArray4<long> pright = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 <= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 <= pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 <= pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 <= pright.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqual(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> LessThanOrEqual_Basic(Vector256<ulong> left, Vector256<ulong> right) {
                UnsafeUtil.SkipInit(out Vector256<ulong> rt);
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<ulong>, FixedArray4<long>>(ref rt);
                ref FixedArray4<ulong> pleft = ref Unsafe.As<Vector256<ulong>, FixedArray4<ulong>>(ref left);
                ref FixedArray4<ulong> pright = ref Unsafe.As<Vector256<ulong>, FixedArray4<ulong>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 <= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 <= pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 <= pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 <= pright.I3);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqualAll_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanOrEqualAll_AcceleratedTypes {
                get {
                    return LessThanOrEqual_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqualAll(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector256<float> left, Vector256<float> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqualAll(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector256<double> left, Vector256<double> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqualAll(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector256<sbyte> left, Vector256<sbyte> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqualAll(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector256<byte> left, Vector256<byte> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqualAll(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector256<short> left, Vector256<short> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqualAll(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector256<ushort> left, Vector256<ushort> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqualAll(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector256<int> left, Vector256<int> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqualAll(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector256<uint> left, Vector256<uint> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqualAll(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector256<long> left, Vector256<long> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqualAll(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector256<ulong> left, Vector256<ulong> right) {
                return YIsAllTrue(LessThanOrEqual(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqualAny_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanOrEqualAny_AcceleratedTypes {
                get {
                    return LessThanOrEqual_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqualAny(Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector256<float> left, Vector256<float> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqualAny(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector256<double> left, Vector256<double> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqualAny(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector256<sbyte> left, Vector256<sbyte> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqualAny(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector256<byte> left, Vector256<byte> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqualAny(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector256<short> left, Vector256<short> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqualAny(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector256<ushort> left, Vector256<ushort> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqualAny(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector256<int> left, Vector256<int> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqualAny(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector256<uint> left, Vector256<uint> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqualAny(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector256<long> left, Vector256<long> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits256.LessThanOrEqualAny(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector256<ulong> left, Vector256<ulong> right) {
                return YIsAnyTrue(LessThanOrEqual(left, right));
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
            public static Vector256<float> Max_Conditional(Vector256<float> left, Vector256<float> right) {
                Vector256<float> condition = GreaterThan(left, right);
                Vector256<float> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Max_Conditional(Vector256<double> left, Vector256<double> right) {
                Vector256<double> condition = GreaterThan(left, right);
                Vector256<double> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Max_Conditional(Vector256<sbyte> left, Vector256<sbyte> right) {
                Vector256<sbyte> condition = GreaterThan(left, right);
                Vector256<sbyte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Max_Conditional(Vector256<byte> left, Vector256<byte> right) {
                Vector256<byte> condition = GreaterThan(left, right);
                Vector256<byte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Max_Conditional(Vector256<short> left, Vector256<short> right) {
                Vector256<short> condition = GreaterThan(left, right);
                Vector256<short> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Max_Conditional(Vector256<ushort> left, Vector256<ushort> right) {
                Vector256<ushort> condition = GreaterThan(left, right);
                Vector256<ushort> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Max_Conditional(Vector256<int> left, Vector256<int> right) {
                Vector256<int> condition = GreaterThan(left, right);
                Vector256<int> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Max_Conditional(Vector256<uint> left, Vector256<uint> right) {
                Vector256<uint> condition = GreaterThan(left, right);
                Vector256<uint> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Max_Conditional(Vector256<long> left, Vector256<long> right) {
                Vector256<long> condition = GreaterThan(left, right);
                Vector256<long> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Max_Conditional(Vector256<ulong> left, Vector256<ulong> right) {
                Vector256<ulong> condition = GreaterThan(left, right);
                Vector256<ulong> rt = ConditionalSelect(condition, left, right);
                return rt;
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
            public static Vector256<float> Min_Conditional(Vector256<float> left, Vector256<float> right) {
                Vector256<float> condition = LessThan(left, right);
                Vector256<float> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Min_Conditional(Vector256<double> left, Vector256<double> right) {
                Vector256<double> condition = LessThan(left, right);
                Vector256<double> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Min_Conditional(Vector256<sbyte> left, Vector256<sbyte> right) {
                Vector256<sbyte> condition = LessThan(left, right);
                Vector256<sbyte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Min_Conditional(Vector256<byte> left, Vector256<byte> right) {
                Vector256<byte> condition = LessThan(left, right);
                Vector256<byte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Min_Conditional(Vector256<short> left, Vector256<short> right) {
                Vector256<short> condition = LessThan(left, right);
                Vector256<short> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Min_Conditional(Vector256<ushort> left, Vector256<ushort> right) {
                Vector256<ushort> condition = LessThan(left, right);
                Vector256<ushort> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Min_Conditional(Vector256<int> left, Vector256<int> right) {
                Vector256<int> condition = LessThan(left, right);
                Vector256<int> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Min_Conditional(Vector256<uint> left, Vector256<uint> right) {
                Vector256<uint> condition = LessThan(left, right);
                Vector256<uint> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Min_Conditional(Vector256<long> left, Vector256<long> right) {
                Vector256<long> condition = LessThan(left, right);
                Vector256<long> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Min_Conditional(Vector256<ulong> left, Vector256<ulong> right) {
                Vector256<ulong> condition = LessThan(left, right);
                Vector256<ulong> rt = ConditionalSelect(condition, left, right);
                return rt;
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
                UnsafeUtil.SkipInit(out Vector256<float> rt);
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
                UnsafeUtil.SkipInit(out Vector256<double> rt);
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
                UnsafeUtil.SkipInit(out Vector256<sbyte> rt);
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
                UnsafeUtil.SkipInit(out Vector256<byte> rt);
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
                UnsafeUtil.SkipInit(out Vector256<short> rt);
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
                UnsafeUtil.SkipInit(out Vector256<ushort> rt);
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
                UnsafeUtil.SkipInit(out Vector256<int> rt);
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
                UnsafeUtil.SkipInit(out Vector256<uint> rt);
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
                UnsafeUtil.SkipInit(out Vector256<long> rt);
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
                UnsafeUtil.SkipInit(out Vector256<ulong> rt);
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
            public static Vector256<float> Negate_Basic(Vector256<float> value) {
                Vector256<float> rt = value;
                ref float p = ref Unsafe.As<Vector256<float>, float>(ref rt);
                p = -p;
                Unsafe.Add(ref p, 1) = -Unsafe.Add(ref p, 1);
                Unsafe.Add(ref p, 2) = -Unsafe.Add(ref p, 2);
                Unsafe.Add(ref p, 3) = -Unsafe.Add(ref p, 3);
                Unsafe.Add(ref p, 4) = -Unsafe.Add(ref p, 4);
                Unsafe.Add(ref p, 5) = -Unsafe.Add(ref p, 5);
                Unsafe.Add(ref p, 6) = -Unsafe.Add(ref p, 6);
                Unsafe.Add(ref p, 7) = -Unsafe.Add(ref p, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Negate_Basic(Vector256<double> value) {
                Vector256<double> rt = value;
                ref double p = ref Unsafe.As<Vector256<double>, double>(ref rt);
                p = -p;
                Unsafe.Add(ref p, 1) = -Unsafe.Add(ref p, 1);
                Unsafe.Add(ref p, 2) = -Unsafe.Add(ref p, 2);
                Unsafe.Add(ref p, 3) = -Unsafe.Add(ref p, 3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Negate_Basic(Vector256<sbyte> value) {
                Vector256<sbyte> rt = value;
                ref sbyte p = ref Unsafe.As<Vector256<sbyte>, sbyte>(ref rt);
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
                Unsafe.Add(ref p, 16) = (sbyte)-Unsafe.Add(ref p, 16);
                Unsafe.Add(ref p, 17) = (sbyte)-Unsafe.Add(ref p, 17);
                Unsafe.Add(ref p, 18) = (sbyte)-Unsafe.Add(ref p, 18);
                Unsafe.Add(ref p, 19) = (sbyte)-Unsafe.Add(ref p, 19);
                Unsafe.Add(ref p, 20) = (sbyte)-Unsafe.Add(ref p, 20);
                Unsafe.Add(ref p, 21) = (sbyte)-Unsafe.Add(ref p, 21);
                Unsafe.Add(ref p, 22) = (sbyte)-Unsafe.Add(ref p, 22);
                Unsafe.Add(ref p, 23) = (sbyte)-Unsafe.Add(ref p, 23);
                Unsafe.Add(ref p, 24) = (sbyte)-Unsafe.Add(ref p, 24);
                Unsafe.Add(ref p, 25) = (sbyte)-Unsafe.Add(ref p, 25);
                Unsafe.Add(ref p, 26) = (sbyte)-Unsafe.Add(ref p, 26);
                Unsafe.Add(ref p, 27) = (sbyte)-Unsafe.Add(ref p, 27);
                Unsafe.Add(ref p, 28) = (sbyte)-Unsafe.Add(ref p, 28);
                Unsafe.Add(ref p, 29) = (sbyte)-Unsafe.Add(ref p, 29);
                Unsafe.Add(ref p, 30) = (sbyte)-Unsafe.Add(ref p, 30);
                Unsafe.Add(ref p, 31) = (sbyte)-Unsafe.Add(ref p, 31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Negate_Basic(Vector256<short> value) {
                Vector256<short> rt = value;
                ref short p = ref Unsafe.As<Vector256<short>, short>(ref rt);
                p = (short)-p;
                Unsafe.Add(ref p, 1) = (short)-Unsafe.Add(ref p, 1);
                Unsafe.Add(ref p, 2) = (short)-Unsafe.Add(ref p, 2);
                Unsafe.Add(ref p, 3) = (short)-Unsafe.Add(ref p, 3);
                Unsafe.Add(ref p, 4) = (short)-Unsafe.Add(ref p, 4);
                Unsafe.Add(ref p, 5) = (short)-Unsafe.Add(ref p, 5);
                Unsafe.Add(ref p, 6) = (short)-Unsafe.Add(ref p, 6);
                Unsafe.Add(ref p, 7) = (short)-Unsafe.Add(ref p, 7);
                Unsafe.Add(ref p, 8) = (short)-Unsafe.Add(ref p, 8);
                Unsafe.Add(ref p, 9) = (short)-Unsafe.Add(ref p, 9);
                Unsafe.Add(ref p, 10) = (short)-Unsafe.Add(ref p, 10);
                Unsafe.Add(ref p, 11) = (short)-Unsafe.Add(ref p, 11);
                Unsafe.Add(ref p, 12) = (short)-Unsafe.Add(ref p, 12);
                Unsafe.Add(ref p, 13) = (short)-Unsafe.Add(ref p, 13);
                Unsafe.Add(ref p, 14) = (short)-Unsafe.Add(ref p, 14);
                Unsafe.Add(ref p, 15) = (short)-Unsafe.Add(ref p, 15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Negate_Basic(Vector256<int> value) {
                Vector256<int> rt = value;
                ref int p = ref Unsafe.As<Vector256<int>, int>(ref rt);
                p = -p;
                Unsafe.Add(ref p, 1) = -Unsafe.Add(ref p, 1);
                Unsafe.Add(ref p, 2) = -Unsafe.Add(ref p, 2);
                Unsafe.Add(ref p, 3) = -Unsafe.Add(ref p, 3);
                Unsafe.Add(ref p, 4) = -Unsafe.Add(ref p, 4);
                Unsafe.Add(ref p, 5) = -Unsafe.Add(ref p, 5);
                Unsafe.Add(ref p, 6) = -Unsafe.Add(ref p, 6);
                Unsafe.Add(ref p, 7) = -Unsafe.Add(ref p, 7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Negate_Basic(Vector256<long> value) {
                Vector256<long> rt = value;
                ref long p = ref Unsafe.As<Vector256<long>, long>(ref rt);
                p = -p;
                Unsafe.Add(ref p, 1) = -Unsafe.Add(ref p, 1);
                Unsafe.Add(ref p, 2) = -Unsafe.Add(ref p, 2);
                Unsafe.Add(ref p, 3) = -Unsafe.Add(ref p, 3);
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
            public static Vector256<T> OnesComplement_Basic<T>(Vector256<T> vector) where T : struct {
                Vector256<T> rt = vector;
                ref long p = ref Unsafe.As<Vector256<T>, long>(ref rt);
                p = ~p;
                Unsafe.Add(ref p, 1) = ~Unsafe.Add(ref p, 1);
                Unsafe.Add(ref p, 2) = ~Unsafe.Add(ref p, 2);
                Unsafe.Add(ref p, 3) = ~Unsafe.Add(ref p, 3);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Sqrt_AcceleratedTypes"/>
            public static TypeCodeFlags Sqrt_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single;
#if Sqrt_Float_Used
                        rt |= TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16;
#endif
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Sqrt(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Sqrt(value);
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Sqrt(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Sqrt(value);
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Sqrt(Vector256<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                if (Vector256.IsHardwareAccelerated) {
#if Sqrt_Float_Used
                    return Sqrt_Float(value);
#else
                    return Vector256.Sqrt(value);
#endif
                } else {
                    return Sqrt_Basic(value);
                }
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Sqrt(Vector256<byte> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                if (Vector256.IsHardwareAccelerated) {
#if Sqrt_Float_Used
                    return Sqrt_Float(value);
#else
                    return Vector256.Sqrt(value);
#endif
                } else {
                    return Sqrt_Basic(value);
                }
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Sqrt(Vector256<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                if (Vector256.IsHardwareAccelerated) {
#if Sqrt_Float_Used
                    return Sqrt_Float(value);
#else
                    return Vector256.Sqrt(value);
#endif
                } else {
                    return Sqrt_Basic(value);
                }
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Sqrt(Vector256<ushort> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                if (Vector256.IsHardwareAccelerated) {
#if Sqrt_Float_Used
                    return Sqrt_Float(value);
#else
                    return Vector256.Sqrt(value);
#endif
                } else {
                    return Sqrt_Basic(value);
                }
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Sqrt(Vector256<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                if (Vector256.IsHardwareAccelerated) {
#if Sqrt_Float_Used
                    return Sqrt_Float(value);
#else
                    return Vector256.Sqrt(value);
#endif
                } else {
                    return Sqrt_Basic(value);
                }
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Sqrt(Vector256<uint> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                if (Vector256.IsHardwareAccelerated) {
#if Sqrt_Float_Used
                    return Sqrt_Float(value);
#else
                    return Vector256.Sqrt(value);
#endif
                } else {
                    return Sqrt_Basic(value);
                }
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Sqrt(Vector256<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                if (Vector256.IsHardwareAccelerated) {
#if Sqrt_Float_Used
                    return Sqrt_Float(value);
#else
                    return Vector256.Sqrt(value);
#endif
                } else {
                    return Sqrt_Basic(value);
                }
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Sqrt(Vector256<ulong> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                if (Vector256.IsHardwareAccelerated) {
#if Sqrt_Float_Used
                    return Sqrt_Float(value);
#else
                    return Vector256.Sqrt(value);
#endif
                } else {
                    return Sqrt_Basic(value);
                }
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                }

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Sqrt_Basic(Vector256<float> value) {
                Vector256<float> rt = value;
                ref FixedArray8<float> p = ref Unsafe.As<Vector256<float>, FixedArray8<float>>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Sqrt_Basic(Vector256<double> value) {
                Vector256<double> rt = value;
                ref FixedArray4<double> p = ref Unsafe.As<Vector256<double>, FixedArray4<double>>(ref rt);
                p.I0 = BitMath.Sqrt(p.I0);
                p.I1 = BitMath.Sqrt(p.I1);
                p.I2 = BitMath.Sqrt(p.I2);
                p.I3 = BitMath.Sqrt(p.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Sqrt_Basic(Vector256<sbyte> value) {
                Vector256<sbyte> rt = value;
                ref FixedArray32<sbyte> p = ref Unsafe.As<Vector256<sbyte>, FixedArray32<sbyte>>(ref rt);
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
                p.I16 = BitMath.Sqrt(p.I16);
                p.I17 = BitMath.Sqrt(p.I17);
                p.I18 = BitMath.Sqrt(p.I18);
                p.I19 = BitMath.Sqrt(p.I19);
                p.I20 = BitMath.Sqrt(p.I20);
                p.I21 = BitMath.Sqrt(p.I21);
                p.I22 = BitMath.Sqrt(p.I22);
                p.I23 = BitMath.Sqrt(p.I23);
                p.I24 = BitMath.Sqrt(p.I24);
                p.I25 = BitMath.Sqrt(p.I25);
                p.I26 = BitMath.Sqrt(p.I26);
                p.I27 = BitMath.Sqrt(p.I27);
                p.I28 = BitMath.Sqrt(p.I28);
                p.I29 = BitMath.Sqrt(p.I29);
                p.I30 = BitMath.Sqrt(p.I30);
                p.I31 = BitMath.Sqrt(p.I31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Sqrt_Basic(Vector256<byte> value) {
                Vector256<byte> rt = value;
                ref FixedArray32<byte> p = ref Unsafe.As<Vector256<byte>, FixedArray32<byte>>(ref rt);
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
                p.I16 = BitMath.Sqrt(p.I16);
                p.I17 = BitMath.Sqrt(p.I17);
                p.I18 = BitMath.Sqrt(p.I18);
                p.I19 = BitMath.Sqrt(p.I19);
                p.I20 = BitMath.Sqrt(p.I20);
                p.I21 = BitMath.Sqrt(p.I21);
                p.I22 = BitMath.Sqrt(p.I22);
                p.I23 = BitMath.Sqrt(p.I23);
                p.I24 = BitMath.Sqrt(p.I24);
                p.I25 = BitMath.Sqrt(p.I25);
                p.I26 = BitMath.Sqrt(p.I26);
                p.I27 = BitMath.Sqrt(p.I27);
                p.I28 = BitMath.Sqrt(p.I28);
                p.I29 = BitMath.Sqrt(p.I29);
                p.I30 = BitMath.Sqrt(p.I30);
                p.I31 = BitMath.Sqrt(p.I31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Sqrt_Basic(Vector256<short> value) {
                Vector256<short> rt = value;
                ref FixedArray16<short> p = ref Unsafe.As<Vector256<short>, FixedArray16<short>>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Sqrt_Basic(Vector256<ushort> value) {
                Vector256<ushort> rt = value;
                ref FixedArray16<ushort> p = ref Unsafe.As<Vector256<ushort>, FixedArray16<ushort>>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Sqrt_Basic(Vector256<int> value) {
                Vector256<int> rt = value;
                ref FixedArray8<int> p = ref Unsafe.As<Vector256<int>, FixedArray8<int>>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Sqrt_Basic(Vector256<uint> value) {
                Vector256<uint> rt = value;
                ref FixedArray8<uint> p = ref Unsafe.As<Vector256<uint>, FixedArray8<uint>>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Sqrt_Basic(Vector256<long> value) {
                Vector256<long> rt = value;
                ref FixedArray4<long> p = ref Unsafe.As<Vector256<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMath.Sqrt(p.I0);
                p.I1 = BitMath.Sqrt(p.I1);
                p.I2 = BitMath.Sqrt(p.I2);
                p.I3 = BitMath.Sqrt(p.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Sqrt_Basic(Vector256<ulong> value) {
                Vector256<ulong> rt = value;
                ref FixedArray4<ulong> p = ref Unsafe.As<Vector256<ulong>, FixedArray4<ulong>>(ref rt);
                p.I0 = BitMath.Sqrt(p.I0);
                p.I1 = BitMath.Sqrt(p.I1);
                p.I2 = BitMath.Sqrt(p.I2);
                p.I3 = BitMath.Sqrt(p.I3);
                return rt;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Sqrt_Float(Vector256<sbyte> value) {
                Vector256<sbyte> mask = GreaterThan(Vector256<sbyte>.Zero, value); // 0>x = x<0.
                Vector256<sbyte> temp = Sqrt_Float(value.AsByte()).AsSByte();
                Vector256<sbyte> rt = AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> Sqrt_Float(Vector256<byte> value) {
                // To float
                Widen(value, out Vector256<ushort> t0, out Vector256<ushort> t1);
                Widen(t0, out Vector256<uint> w0, out Vector256<uint> w1);
                Widen(t1, out Vector256<uint> w2, out Vector256<uint> w3);
                Vector256<float> src0 = ConvertToSingle(w0.AsInt32()); // On x86 platforms, Int32 typically has special instructions to speed up, which is faster than UInt32.
                Vector256<float> src1 = ConvertToSingle(w1.AsInt32());
                Vector256<float> src2 = ConvertToSingle(w2.AsInt32());
                Vector256<float> src3 = ConvertToSingle(w3.AsInt32());
                // Body
                Vector256<float> dst0 = Vector256.Sqrt(src0);
                Vector256<float> dst1 = Vector256.Sqrt(src1);
                Vector256<float> dst2 = Vector256.Sqrt(src2);
                Vector256<float> dst3 = Vector256.Sqrt(src3);
                // To int
                w0 = ConvertToInt32(dst0).AsUInt32();
                w1 = ConvertToInt32(dst1).AsUInt32();
                w2 = ConvertToInt32(dst2).AsUInt32();
                w3 = ConvertToInt32(dst3).AsUInt32();
                t0 = Narrow(w0, w1);
                t1 = Narrow(w2, w3);
                Vector256<byte> rt = Narrow(t0, t1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Sqrt_Float(Vector256<short> value) {
                Vector256<short> mask = GreaterThan(Vector256<short>.Zero, value); // 0>x = x<0.
                Vector256<short> temp = Sqrt_Float(value.AsUInt16()).AsInt16();
                Vector256<short> rt = AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> Sqrt_Float(Vector256<ushort> value) {
                // To float
                Widen(value, out Vector256<uint> w0, out Vector256<uint> w1);
                Vector256<float> src0 = ConvertToSingle(w0.AsInt32());
                Vector256<float> src1 = ConvertToSingle(w1.AsInt32());
                // Body
                Vector256<float> dst0 = Vector256.Sqrt(src0);
                Vector256<float> dst1 = Vector256.Sqrt(src1);
                // To int
                w0 = ConvertToInt32(dst0).AsUInt32();
                w1 = ConvertToInt32(dst1).AsUInt32();
                Vector256<ushort> rt = Narrow(w0, w1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Sqrt_Float(Vector256<int> value) {
                Vector256<int> mask = GreaterThan(Vector256<int>.Zero, value); // 0>x = x<0.
                Vector256<int> temp = Sqrt_Float(value.AsUInt32()).AsInt32();
                Vector256<int> rt = AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> Sqrt_Float(Vector256<uint> value) {
                // To float
                Widen(value, out Vector256<ulong> w0, out Vector256<ulong> w1);
                Vector256<double> src0 = ConvertToDouble_Range52(w0);
                Vector256<double> src1 = ConvertToDouble_Range52(w1);
                // Body
                Vector256<double> dst0 = Vector256.Sqrt(src0);
                Vector256<double> dst1 = Vector256.Sqrt(src1);
                // To int
                w0 = ConvertToUInt64_Range52(dst0);
                w1 = ConvertToUInt64_Range52(dst1);
                Vector256<uint> rt = Narrow(w0, w1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Sqrt_Float(Vector256<long> value) {
                Vector256<long> mask = GreaterThan(Vector256<long>.Zero, value); // 0>x = x<0.
                Vector256<long> temp = Sqrt_Float(value.AsUInt64()).AsInt64();
                Vector256<long> rt = AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Sqrt(Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> Sqrt_Float(Vector256<ulong> value) {
                // To float
                Vector256<double> src0 = ConvertToDouble(value);
                // Body
                Vector256<double> dst0 = Vector256.Sqrt(src0);
                // To int
                Vector256<ulong> rt = ConvertToUInt64_Range52(dst0); // `Math.Ceiling(Math.Log2(Math.Sqrt(ulong.MaxValue))) = 32`. It less 52bit.
                return rt;
            }
#endif // NET7_0_OR_GREATER


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
                UnsafeUtil.SkipInit(out Vector256<float> rt);
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
                UnsafeUtil.SkipInit(out Vector256<double> rt);
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
                UnsafeUtil.SkipInit(out Vector256<sbyte> rt);
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
                UnsafeUtil.SkipInit(out Vector256<byte> rt);
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
                UnsafeUtil.SkipInit(out Vector256<short> rt);
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
                UnsafeUtil.SkipInit(out Vector256<ushort> rt);
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
                UnsafeUtil.SkipInit(out Vector256<int> rt);
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
                UnsafeUtil.SkipInit(out Vector256<uint> rt);
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
                UnsafeUtil.SkipInit(out Vector256<long> rt);
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
                UnsafeUtil.SkipInit(out Vector256<ulong> rt);
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
                UnsafeUtil.SkipInit(out Vector256<T> rt);
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
