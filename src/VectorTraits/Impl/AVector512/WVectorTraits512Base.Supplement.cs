#define Sqrt_Float_Used
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

namespace Zyl.VectorTraits.Impl.AVector512 {
    partial class WVectorTraits512Base {

        partial class Statics {

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits512.Abs_AcceleratedTypes"/>
            public static TypeCodeFlags Abs_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Abs(Vector512<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Abs(value);
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Abs(Vector512<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Abs(value);
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Abs(Vector512<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return Vector512.Abs(value);
                } else {
                    return Abs_Basic(value);
                }
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Abs(Vector512<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return Vector512.Abs(value);
                } else {
                    return Abs_Basic(value);
                }
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Abs(Vector512<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return Vector512.Abs(value);
                } else {
                    return Abs_Basic(value);
                }
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Abs(Vector512<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
                    return Vector512.Abs(value);
                } else {
                    return Abs_Basic(value);
                }
#else
                return Abs_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Abs_Basic(Vector512<float> value) {
                Vector512<float> rt = value;
                ref float p = ref Unsafe.As<Vector512<float>, float>(ref rt);
                p = Math.Abs(p);
                Unsafe.Add(ref p, 1) = Math.Abs(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = Math.Abs(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = Math.Abs(Unsafe.Add(ref p, 3));
                Unsafe.Add(ref p, 4) = Math.Abs(Unsafe.Add(ref p, 4));
                Unsafe.Add(ref p, 5) = Math.Abs(Unsafe.Add(ref p, 5));
                Unsafe.Add(ref p, 6) = Math.Abs(Unsafe.Add(ref p, 6));
                Unsafe.Add(ref p, 7) = Math.Abs(Unsafe.Add(ref p, 7));
                Unsafe.Add(ref p, 8) = Math.Abs(Unsafe.Add(ref p, 8));
                Unsafe.Add(ref p, 9) = Math.Abs(Unsafe.Add(ref p, 9));
                Unsafe.Add(ref p, 10) = Math.Abs(Unsafe.Add(ref p, 10));
                Unsafe.Add(ref p, 11) = Math.Abs(Unsafe.Add(ref p, 11));
                Unsafe.Add(ref p, 12) = Math.Abs(Unsafe.Add(ref p, 12));
                Unsafe.Add(ref p, 13) = Math.Abs(Unsafe.Add(ref p, 13));
                Unsafe.Add(ref p, 14) = Math.Abs(Unsafe.Add(ref p, 14));
                Unsafe.Add(ref p, 15) = Math.Abs(Unsafe.Add(ref p, 15));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Abs_Basic(Vector512<double> value) {
                Vector512<double> rt = value;
                ref double p = ref Unsafe.As<Vector512<double>, double>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Abs_Basic(Vector512<sbyte> value) {
                Vector512<sbyte> rt = value;
                ref sbyte p = ref Unsafe.As<Vector512<sbyte>, sbyte>(ref rt);
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
                Unsafe.Add(ref p, 32) = BitMath.Abs(Unsafe.Add(ref p, 32));
                Unsafe.Add(ref p, 33) = BitMath.Abs(Unsafe.Add(ref p, 33));
                Unsafe.Add(ref p, 34) = BitMath.Abs(Unsafe.Add(ref p, 34));
                Unsafe.Add(ref p, 35) = BitMath.Abs(Unsafe.Add(ref p, 35));
                Unsafe.Add(ref p, 36) = BitMath.Abs(Unsafe.Add(ref p, 36));
                Unsafe.Add(ref p, 37) = BitMath.Abs(Unsafe.Add(ref p, 37));
                Unsafe.Add(ref p, 38) = BitMath.Abs(Unsafe.Add(ref p, 38));
                Unsafe.Add(ref p, 39) = BitMath.Abs(Unsafe.Add(ref p, 39));
                Unsafe.Add(ref p, 40) = BitMath.Abs(Unsafe.Add(ref p, 40));
                Unsafe.Add(ref p, 41) = BitMath.Abs(Unsafe.Add(ref p, 41));
                Unsafe.Add(ref p, 42) = BitMath.Abs(Unsafe.Add(ref p, 42));
                Unsafe.Add(ref p, 43) = BitMath.Abs(Unsafe.Add(ref p, 43));
                Unsafe.Add(ref p, 44) = BitMath.Abs(Unsafe.Add(ref p, 44));
                Unsafe.Add(ref p, 45) = BitMath.Abs(Unsafe.Add(ref p, 45));
                Unsafe.Add(ref p, 46) = BitMath.Abs(Unsafe.Add(ref p, 46));
                Unsafe.Add(ref p, 47) = BitMath.Abs(Unsafe.Add(ref p, 47));
                Unsafe.Add(ref p, 48) = BitMath.Abs(Unsafe.Add(ref p, 48));
                Unsafe.Add(ref p, 49) = BitMath.Abs(Unsafe.Add(ref p, 49));
                Unsafe.Add(ref p, 50) = BitMath.Abs(Unsafe.Add(ref p, 50));
                Unsafe.Add(ref p, 51) = BitMath.Abs(Unsafe.Add(ref p, 51));
                Unsafe.Add(ref p, 52) = BitMath.Abs(Unsafe.Add(ref p, 52));
                Unsafe.Add(ref p, 53) = BitMath.Abs(Unsafe.Add(ref p, 53));
                Unsafe.Add(ref p, 54) = BitMath.Abs(Unsafe.Add(ref p, 54));
                Unsafe.Add(ref p, 55) = BitMath.Abs(Unsafe.Add(ref p, 55));
                Unsafe.Add(ref p, 56) = BitMath.Abs(Unsafe.Add(ref p, 56));
                Unsafe.Add(ref p, 57) = BitMath.Abs(Unsafe.Add(ref p, 57));
                Unsafe.Add(ref p, 58) = BitMath.Abs(Unsafe.Add(ref p, 58));
                Unsafe.Add(ref p, 59) = BitMath.Abs(Unsafe.Add(ref p, 59));
                Unsafe.Add(ref p, 60) = BitMath.Abs(Unsafe.Add(ref p, 60));
                Unsafe.Add(ref p, 61) = BitMath.Abs(Unsafe.Add(ref p, 61));
                Unsafe.Add(ref p, 62) = BitMath.Abs(Unsafe.Add(ref p, 62));
                Unsafe.Add(ref p, 63) = BitMath.Abs(Unsafe.Add(ref p, 63));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Abs_Basic(Vector512<short> value) {
                Vector512<short> rt = value;
                ref short p = ref Unsafe.As<Vector512<short>, short>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Abs_Basic(Vector512<int> value) {
                Vector512<int> rt = value;
                ref int p = ref Unsafe.As<Vector512<int>, int>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits512.Abs(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Abs_Basic(Vector512<long> value) {
                Vector512<long> rt = value;
                ref long p = ref Unsafe.As<Vector512<long>, long>(ref rt);
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


            /// <inheritdoc cref="IWVectorTraits512.Add_AcceleratedTypes"/>
            public static TypeCodeFlags Add_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Add(Vector512<float> left, Vector512<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Add(Vector512<double> left, Vector512<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Add(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Add(Vector512<byte> left, Vector512<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Add(Vector512<short> left, Vector512<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Add(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Add(Vector512<int> left, Vector512<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Add(Vector512<uint> left, Vector512<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Add(Vector512<long> left, Vector512<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Add(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Add(left, right);
#else
                return Add_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Add_Basic(Vector512<float> left, Vector512<float> right) {
                UnsafeUtil.SkipInit(out Vector512<float> rt);
                ref float prt = ref Unsafe.As<Vector512<float>, float>(ref rt);
                ref float pleft = ref Unsafe.As<Vector512<float>, float>(ref left);
                ref float pright = ref Unsafe.As<Vector512<float>, float>(ref right);
                prt = pleft + pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) + Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) + Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) + Unsafe.Add(ref pright, 3);
                Unsafe.Add(ref prt, 4) = Unsafe.Add(ref pleft, 4) + Unsafe.Add(ref pright, 4);
                Unsafe.Add(ref prt, 5) = Unsafe.Add(ref pleft, 5) + Unsafe.Add(ref pright, 5);
                Unsafe.Add(ref prt, 6) = Unsafe.Add(ref pleft, 6) + Unsafe.Add(ref pright, 6);
                Unsafe.Add(ref prt, 7) = Unsafe.Add(ref pleft, 7) + Unsafe.Add(ref pright, 7);
                Unsafe.Add(ref prt, 8) = Unsafe.Add(ref pleft, 8) + Unsafe.Add(ref pright, 8);
                Unsafe.Add(ref prt, 9) = Unsafe.Add(ref pleft, 9) + Unsafe.Add(ref pright, 9);
                Unsafe.Add(ref prt, 10) = Unsafe.Add(ref pleft, 10) + Unsafe.Add(ref pright, 10);
                Unsafe.Add(ref prt, 11) = Unsafe.Add(ref pleft, 11) + Unsafe.Add(ref pright, 11);
                Unsafe.Add(ref prt, 12) = Unsafe.Add(ref pleft, 12) + Unsafe.Add(ref pright, 12);
                Unsafe.Add(ref prt, 13) = Unsafe.Add(ref pleft, 13) + Unsafe.Add(ref pright, 13);
                Unsafe.Add(ref prt, 14) = Unsafe.Add(ref pleft, 14) + Unsafe.Add(ref pright, 14);
                Unsafe.Add(ref prt, 15) = Unsafe.Add(ref pleft, 15) + Unsafe.Add(ref pright, 15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Add_Basic(Vector512<double> left, Vector512<double> right) {
                UnsafeUtil.SkipInit(out Vector512<double> rt);
                ref double prt = ref Unsafe.As<Vector512<double>, double>(ref rt);
                ref double pleft = ref Unsafe.As<Vector512<double>, double>(ref left);
                ref double pright = ref Unsafe.As<Vector512<double>, double>(ref right);
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

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Add_Basic(Vector512<sbyte> left, Vector512<sbyte> right) {
                UnsafeUtil.SkipInit(out Vector512<sbyte> rt);
                ref sbyte prt = ref Unsafe.As<Vector512<sbyte>, sbyte>(ref rt);
                ref sbyte pleft = ref Unsafe.As<Vector512<sbyte>, sbyte>(ref left);
                ref sbyte pright = ref Unsafe.As<Vector512<sbyte>, sbyte>(ref right);
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
                Unsafe.Add(ref prt, 32) = (sbyte)(Unsafe.Add(ref pleft, 32) + Unsafe.Add(ref pright, 32));
                Unsafe.Add(ref prt, 33) = (sbyte)(Unsafe.Add(ref pleft, 33) + Unsafe.Add(ref pright, 33));
                Unsafe.Add(ref prt, 34) = (sbyte)(Unsafe.Add(ref pleft, 34) + Unsafe.Add(ref pright, 34));
                Unsafe.Add(ref prt, 35) = (sbyte)(Unsafe.Add(ref pleft, 35) + Unsafe.Add(ref pright, 35));
                Unsafe.Add(ref prt, 36) = (sbyte)(Unsafe.Add(ref pleft, 36) + Unsafe.Add(ref pright, 36));
                Unsafe.Add(ref prt, 37) = (sbyte)(Unsafe.Add(ref pleft, 37) + Unsafe.Add(ref pright, 37));
                Unsafe.Add(ref prt, 38) = (sbyte)(Unsafe.Add(ref pleft, 38) + Unsafe.Add(ref pright, 38));
                Unsafe.Add(ref prt, 39) = (sbyte)(Unsafe.Add(ref pleft, 39) + Unsafe.Add(ref pright, 39));
                Unsafe.Add(ref prt, 40) = (sbyte)(Unsafe.Add(ref pleft, 40) + Unsafe.Add(ref pright, 40));
                Unsafe.Add(ref prt, 41) = (sbyte)(Unsafe.Add(ref pleft, 41) + Unsafe.Add(ref pright, 41));
                Unsafe.Add(ref prt, 42) = (sbyte)(Unsafe.Add(ref pleft, 42) + Unsafe.Add(ref pright, 42));
                Unsafe.Add(ref prt, 43) = (sbyte)(Unsafe.Add(ref pleft, 43) + Unsafe.Add(ref pright, 43));
                Unsafe.Add(ref prt, 44) = (sbyte)(Unsafe.Add(ref pleft, 44) + Unsafe.Add(ref pright, 44));
                Unsafe.Add(ref prt, 45) = (sbyte)(Unsafe.Add(ref pleft, 45) + Unsafe.Add(ref pright, 45));
                Unsafe.Add(ref prt, 46) = (sbyte)(Unsafe.Add(ref pleft, 46) + Unsafe.Add(ref pright, 46));
                Unsafe.Add(ref prt, 47) = (sbyte)(Unsafe.Add(ref pleft, 47) + Unsafe.Add(ref pright, 47));
                Unsafe.Add(ref prt, 48) = (sbyte)(Unsafe.Add(ref pleft, 48) + Unsafe.Add(ref pright, 48));
                Unsafe.Add(ref prt, 49) = (sbyte)(Unsafe.Add(ref pleft, 49) + Unsafe.Add(ref pright, 49));
                Unsafe.Add(ref prt, 50) = (sbyte)(Unsafe.Add(ref pleft, 50) + Unsafe.Add(ref pright, 50));
                Unsafe.Add(ref prt, 51) = (sbyte)(Unsafe.Add(ref pleft, 51) + Unsafe.Add(ref pright, 51));
                Unsafe.Add(ref prt, 52) = (sbyte)(Unsafe.Add(ref pleft, 52) + Unsafe.Add(ref pright, 52));
                Unsafe.Add(ref prt, 53) = (sbyte)(Unsafe.Add(ref pleft, 53) + Unsafe.Add(ref pright, 53));
                Unsafe.Add(ref prt, 54) = (sbyte)(Unsafe.Add(ref pleft, 54) + Unsafe.Add(ref pright, 54));
                Unsafe.Add(ref prt, 55) = (sbyte)(Unsafe.Add(ref pleft, 55) + Unsafe.Add(ref pright, 55));
                Unsafe.Add(ref prt, 56) = (sbyte)(Unsafe.Add(ref pleft, 56) + Unsafe.Add(ref pright, 56));
                Unsafe.Add(ref prt, 57) = (sbyte)(Unsafe.Add(ref pleft, 57) + Unsafe.Add(ref pright, 57));
                Unsafe.Add(ref prt, 58) = (sbyte)(Unsafe.Add(ref pleft, 58) + Unsafe.Add(ref pright, 58));
                Unsafe.Add(ref prt, 59) = (sbyte)(Unsafe.Add(ref pleft, 59) + Unsafe.Add(ref pright, 59));
                Unsafe.Add(ref prt, 60) = (sbyte)(Unsafe.Add(ref pleft, 60) + Unsafe.Add(ref pright, 60));
                Unsafe.Add(ref prt, 61) = (sbyte)(Unsafe.Add(ref pleft, 61) + Unsafe.Add(ref pright, 61));
                Unsafe.Add(ref prt, 62) = (sbyte)(Unsafe.Add(ref pleft, 62) + Unsafe.Add(ref pright, 62));
                Unsafe.Add(ref prt, 63) = (sbyte)(Unsafe.Add(ref pleft, 63) + Unsafe.Add(ref pright, 63));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Add_Basic(Vector512<byte> left, Vector512<byte> right) {
                UnsafeUtil.SkipInit(out Vector512<byte> rt);
                ref byte prt = ref Unsafe.As<Vector512<byte>, byte>(ref rt);
                ref byte pleft = ref Unsafe.As<Vector512<byte>, byte>(ref left);
                ref byte pright = ref Unsafe.As<Vector512<byte>, byte>(ref right);
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
                Unsafe.Add(ref prt, 32) = (byte)(Unsafe.Add(ref pleft, 32) + Unsafe.Add(ref pright, 32));
                Unsafe.Add(ref prt, 33) = (byte)(Unsafe.Add(ref pleft, 33) + Unsafe.Add(ref pright, 33));
                Unsafe.Add(ref prt, 34) = (byte)(Unsafe.Add(ref pleft, 34) + Unsafe.Add(ref pright, 34));
                Unsafe.Add(ref prt, 35) = (byte)(Unsafe.Add(ref pleft, 35) + Unsafe.Add(ref pright, 35));
                Unsafe.Add(ref prt, 36) = (byte)(Unsafe.Add(ref pleft, 36) + Unsafe.Add(ref pright, 36));
                Unsafe.Add(ref prt, 37) = (byte)(Unsafe.Add(ref pleft, 37) + Unsafe.Add(ref pright, 37));
                Unsafe.Add(ref prt, 38) = (byte)(Unsafe.Add(ref pleft, 38) + Unsafe.Add(ref pright, 38));
                Unsafe.Add(ref prt, 39) = (byte)(Unsafe.Add(ref pleft, 39) + Unsafe.Add(ref pright, 39));
                Unsafe.Add(ref prt, 40) = (byte)(Unsafe.Add(ref pleft, 40) + Unsafe.Add(ref pright, 40));
                Unsafe.Add(ref prt, 41) = (byte)(Unsafe.Add(ref pleft, 41) + Unsafe.Add(ref pright, 41));
                Unsafe.Add(ref prt, 42) = (byte)(Unsafe.Add(ref pleft, 42) + Unsafe.Add(ref pright, 42));
                Unsafe.Add(ref prt, 43) = (byte)(Unsafe.Add(ref pleft, 43) + Unsafe.Add(ref pright, 43));
                Unsafe.Add(ref prt, 44) = (byte)(Unsafe.Add(ref pleft, 44) + Unsafe.Add(ref pright, 44));
                Unsafe.Add(ref prt, 45) = (byte)(Unsafe.Add(ref pleft, 45) + Unsafe.Add(ref pright, 45));
                Unsafe.Add(ref prt, 46) = (byte)(Unsafe.Add(ref pleft, 46) + Unsafe.Add(ref pright, 46));
                Unsafe.Add(ref prt, 47) = (byte)(Unsafe.Add(ref pleft, 47) + Unsafe.Add(ref pright, 47));
                Unsafe.Add(ref prt, 48) = (byte)(Unsafe.Add(ref pleft, 48) + Unsafe.Add(ref pright, 48));
                Unsafe.Add(ref prt, 49) = (byte)(Unsafe.Add(ref pleft, 49) + Unsafe.Add(ref pright, 49));
                Unsafe.Add(ref prt, 50) = (byte)(Unsafe.Add(ref pleft, 50) + Unsafe.Add(ref pright, 50));
                Unsafe.Add(ref prt, 51) = (byte)(Unsafe.Add(ref pleft, 51) + Unsafe.Add(ref pright, 51));
                Unsafe.Add(ref prt, 52) = (byte)(Unsafe.Add(ref pleft, 52) + Unsafe.Add(ref pright, 52));
                Unsafe.Add(ref prt, 53) = (byte)(Unsafe.Add(ref pleft, 53) + Unsafe.Add(ref pright, 53));
                Unsafe.Add(ref prt, 54) = (byte)(Unsafe.Add(ref pleft, 54) + Unsafe.Add(ref pright, 54));
                Unsafe.Add(ref prt, 55) = (byte)(Unsafe.Add(ref pleft, 55) + Unsafe.Add(ref pright, 55));
                Unsafe.Add(ref prt, 56) = (byte)(Unsafe.Add(ref pleft, 56) + Unsafe.Add(ref pright, 56));
                Unsafe.Add(ref prt, 57) = (byte)(Unsafe.Add(ref pleft, 57) + Unsafe.Add(ref pright, 57));
                Unsafe.Add(ref prt, 58) = (byte)(Unsafe.Add(ref pleft, 58) + Unsafe.Add(ref pright, 58));
                Unsafe.Add(ref prt, 59) = (byte)(Unsafe.Add(ref pleft, 59) + Unsafe.Add(ref pright, 59));
                Unsafe.Add(ref prt, 60) = (byte)(Unsafe.Add(ref pleft, 60) + Unsafe.Add(ref pright, 60));
                Unsafe.Add(ref prt, 61) = (byte)(Unsafe.Add(ref pleft, 61) + Unsafe.Add(ref pright, 61));
                Unsafe.Add(ref prt, 62) = (byte)(Unsafe.Add(ref pleft, 62) + Unsafe.Add(ref pright, 62));
                Unsafe.Add(ref prt, 63) = (byte)(Unsafe.Add(ref pleft, 63) + Unsafe.Add(ref pright, 63));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Add_Basic(Vector512<short> left, Vector512<short> right) {
                UnsafeUtil.SkipInit(out Vector512<short> rt);
                ref short prt = ref Unsafe.As<Vector512<short>, short>(ref rt);
                ref short pleft = ref Unsafe.As<Vector512<short>, short>(ref left);
                ref short pright = ref Unsafe.As<Vector512<short>, short>(ref right);
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
                Unsafe.Add(ref prt, 16) = (short)(Unsafe.Add(ref pleft, 16) + Unsafe.Add(ref pright, 16));
                Unsafe.Add(ref prt, 17) = (short)(Unsafe.Add(ref pleft, 17) + Unsafe.Add(ref pright, 17));
                Unsafe.Add(ref prt, 18) = (short)(Unsafe.Add(ref pleft, 18) + Unsafe.Add(ref pright, 18));
                Unsafe.Add(ref prt, 19) = (short)(Unsafe.Add(ref pleft, 19) + Unsafe.Add(ref pright, 19));
                Unsafe.Add(ref prt, 20) = (short)(Unsafe.Add(ref pleft, 20) + Unsafe.Add(ref pright, 20));
                Unsafe.Add(ref prt, 21) = (short)(Unsafe.Add(ref pleft, 21) + Unsafe.Add(ref pright, 21));
                Unsafe.Add(ref prt, 22) = (short)(Unsafe.Add(ref pleft, 22) + Unsafe.Add(ref pright, 22));
                Unsafe.Add(ref prt, 23) = (short)(Unsafe.Add(ref pleft, 23) + Unsafe.Add(ref pright, 23));
                Unsafe.Add(ref prt, 24) = (short)(Unsafe.Add(ref pleft, 24) + Unsafe.Add(ref pright, 24));
                Unsafe.Add(ref prt, 25) = (short)(Unsafe.Add(ref pleft, 25) + Unsafe.Add(ref pright, 25));
                Unsafe.Add(ref prt, 26) = (short)(Unsafe.Add(ref pleft, 26) + Unsafe.Add(ref pright, 26));
                Unsafe.Add(ref prt, 27) = (short)(Unsafe.Add(ref pleft, 27) + Unsafe.Add(ref pright, 27));
                Unsafe.Add(ref prt, 28) = (short)(Unsafe.Add(ref pleft, 28) + Unsafe.Add(ref pright, 28));
                Unsafe.Add(ref prt, 29) = (short)(Unsafe.Add(ref pleft, 29) + Unsafe.Add(ref pright, 29));
                Unsafe.Add(ref prt, 30) = (short)(Unsafe.Add(ref pleft, 30) + Unsafe.Add(ref pright, 30));
                Unsafe.Add(ref prt, 31) = (short)(Unsafe.Add(ref pleft, 31) + Unsafe.Add(ref pright, 31));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Add_Basic(Vector512<ushort> left, Vector512<ushort> right) {
                UnsafeUtil.SkipInit(out Vector512<ushort> rt);
                ref ushort prt = ref Unsafe.As<Vector512<ushort>, ushort>(ref rt);
                ref ushort pleft = ref Unsafe.As<Vector512<ushort>, ushort>(ref left);
                ref ushort pright = ref Unsafe.As<Vector512<ushort>, ushort>(ref right);
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
                Unsafe.Add(ref prt, 16) = (ushort)(Unsafe.Add(ref pleft, 16) + Unsafe.Add(ref pright, 16));
                Unsafe.Add(ref prt, 17) = (ushort)(Unsafe.Add(ref pleft, 17) + Unsafe.Add(ref pright, 17));
                Unsafe.Add(ref prt, 18) = (ushort)(Unsafe.Add(ref pleft, 18) + Unsafe.Add(ref pright, 18));
                Unsafe.Add(ref prt, 19) = (ushort)(Unsafe.Add(ref pleft, 19) + Unsafe.Add(ref pright, 19));
                Unsafe.Add(ref prt, 20) = (ushort)(Unsafe.Add(ref pleft, 20) + Unsafe.Add(ref pright, 20));
                Unsafe.Add(ref prt, 21) = (ushort)(Unsafe.Add(ref pleft, 21) + Unsafe.Add(ref pright, 21));
                Unsafe.Add(ref prt, 22) = (ushort)(Unsafe.Add(ref pleft, 22) + Unsafe.Add(ref pright, 22));
                Unsafe.Add(ref prt, 23) = (ushort)(Unsafe.Add(ref pleft, 23) + Unsafe.Add(ref pright, 23));
                Unsafe.Add(ref prt, 24) = (ushort)(Unsafe.Add(ref pleft, 24) + Unsafe.Add(ref pright, 24));
                Unsafe.Add(ref prt, 25) = (ushort)(Unsafe.Add(ref pleft, 25) + Unsafe.Add(ref pright, 25));
                Unsafe.Add(ref prt, 26) = (ushort)(Unsafe.Add(ref pleft, 26) + Unsafe.Add(ref pright, 26));
                Unsafe.Add(ref prt, 27) = (ushort)(Unsafe.Add(ref pleft, 27) + Unsafe.Add(ref pright, 27));
                Unsafe.Add(ref prt, 28) = (ushort)(Unsafe.Add(ref pleft, 28) + Unsafe.Add(ref pright, 28));
                Unsafe.Add(ref prt, 29) = (ushort)(Unsafe.Add(ref pleft, 29) + Unsafe.Add(ref pright, 29));
                Unsafe.Add(ref prt, 30) = (ushort)(Unsafe.Add(ref pleft, 30) + Unsafe.Add(ref pright, 30));
                Unsafe.Add(ref prt, 31) = (ushort)(Unsafe.Add(ref pleft, 31) + Unsafe.Add(ref pright, 31));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Add_Basic(Vector512<int> left, Vector512<int> right) {
                UnsafeUtil.SkipInit(out Vector512<int> rt);
                ref int prt = ref Unsafe.As<Vector512<int>, int>(ref rt);
                ref int pleft = ref Unsafe.As<Vector512<int>, int>(ref left);
                ref int pright = ref Unsafe.As<Vector512<int>, int>(ref right);
                prt = pleft + pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) + Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) + Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) + Unsafe.Add(ref pright, 3);
                Unsafe.Add(ref prt, 4) = Unsafe.Add(ref pleft, 4) + Unsafe.Add(ref pright, 4);
                Unsafe.Add(ref prt, 5) = Unsafe.Add(ref pleft, 5) + Unsafe.Add(ref pright, 5);
                Unsafe.Add(ref prt, 6) = Unsafe.Add(ref pleft, 6) + Unsafe.Add(ref pright, 6);
                Unsafe.Add(ref prt, 7) = Unsafe.Add(ref pleft, 7) + Unsafe.Add(ref pright, 7);
                Unsafe.Add(ref prt, 8) = Unsafe.Add(ref pleft, 8) + Unsafe.Add(ref pright, 8);
                Unsafe.Add(ref prt, 9) = Unsafe.Add(ref pleft, 9) + Unsafe.Add(ref pright, 9);
                Unsafe.Add(ref prt, 10) = Unsafe.Add(ref pleft, 10) + Unsafe.Add(ref pright, 10);
                Unsafe.Add(ref prt, 11) = Unsafe.Add(ref pleft, 11) + Unsafe.Add(ref pright, 11);
                Unsafe.Add(ref prt, 12) = Unsafe.Add(ref pleft, 12) + Unsafe.Add(ref pright, 12);
                Unsafe.Add(ref prt, 13) = Unsafe.Add(ref pleft, 13) + Unsafe.Add(ref pright, 13);
                Unsafe.Add(ref prt, 14) = Unsafe.Add(ref pleft, 14) + Unsafe.Add(ref pright, 14);
                Unsafe.Add(ref prt, 15) = Unsafe.Add(ref pleft, 15) + Unsafe.Add(ref pright, 15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Add_Basic(Vector512<uint> left, Vector512<uint> right) {
                UnsafeUtil.SkipInit(out Vector512<uint> rt);
                ref uint prt = ref Unsafe.As<Vector512<uint>, uint>(ref rt);
                ref uint pleft = ref Unsafe.As<Vector512<uint>, uint>(ref left);
                ref uint pright = ref Unsafe.As<Vector512<uint>, uint>(ref right);
                prt = pleft + pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) + Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) + Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) + Unsafe.Add(ref pright, 3);
                Unsafe.Add(ref prt, 4) = Unsafe.Add(ref pleft, 4) + Unsafe.Add(ref pright, 4);
                Unsafe.Add(ref prt, 5) = Unsafe.Add(ref pleft, 5) + Unsafe.Add(ref pright, 5);
                Unsafe.Add(ref prt, 6) = Unsafe.Add(ref pleft, 6) + Unsafe.Add(ref pright, 6);
                Unsafe.Add(ref prt, 7) = Unsafe.Add(ref pleft, 7) + Unsafe.Add(ref pright, 7);
                Unsafe.Add(ref prt, 8) = Unsafe.Add(ref pleft, 8) + Unsafe.Add(ref pright, 8);
                Unsafe.Add(ref prt, 9) = Unsafe.Add(ref pleft, 9) + Unsafe.Add(ref pright, 9);
                Unsafe.Add(ref prt, 10) = Unsafe.Add(ref pleft, 10) + Unsafe.Add(ref pright, 10);
                Unsafe.Add(ref prt, 11) = Unsafe.Add(ref pleft, 11) + Unsafe.Add(ref pright, 11);
                Unsafe.Add(ref prt, 12) = Unsafe.Add(ref pleft, 12) + Unsafe.Add(ref pright, 12);
                Unsafe.Add(ref prt, 13) = Unsafe.Add(ref pleft, 13) + Unsafe.Add(ref pright, 13);
                Unsafe.Add(ref prt, 14) = Unsafe.Add(ref pleft, 14) + Unsafe.Add(ref pright, 14);
                Unsafe.Add(ref prt, 15) = Unsafe.Add(ref pleft, 15) + Unsafe.Add(ref pright, 15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Add_Basic(Vector512<long> left, Vector512<long> right) {
                UnsafeUtil.SkipInit(out Vector512<long> rt);
                ref long prt = ref Unsafe.As<Vector512<long>, long>(ref rt);
                ref long pleft = ref Unsafe.As<Vector512<long>, long>(ref left);
                ref long pright = ref Unsafe.As<Vector512<long>, long>(ref right);
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

            /// <inheritdoc cref="IWVectorTraits512.Add(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Add_Basic(Vector512<ulong> left, Vector512<ulong> right) {
                UnsafeUtil.SkipInit(out Vector512<ulong> rt);
                ref ulong prt = ref Unsafe.As<Vector512<ulong>, ulong>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector512<ulong>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector512<ulong>, ulong>(ref right);
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


            /// <inheritdoc cref="IWVectorTraits512.AndNot_AcceleratedTypes"/>
            public static TypeCodeFlags AndNot_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.AndNot{T}(Vector512{T}, Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> AndNot<T>(Vector512<T> left, Vector512<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.AndNot(left, right);
#else
                return AndNot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.AndNot{T}(Vector512{T}, Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> AndNot_Basic<T>(Vector512<T> left, Vector512<T> right) where T : struct {
                UnsafeUtil.SkipInit(out Vector512<T> rt);
                ref ulong prt = ref Unsafe.As<Vector512<T>, ulong>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector512<T>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector512<T>, ulong>(ref right);
                prt = pleft & ~pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) & ~Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) & ~Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) & ~Unsafe.Add(ref pright, 3);
                Unsafe.Add(ref prt, 4) = Unsafe.Add(ref pleft, 4) & ~Unsafe.Add(ref pright, 4);
                Unsafe.Add(ref prt, 5) = Unsafe.Add(ref pleft, 5) & ~Unsafe.Add(ref pright, 5);
                Unsafe.Add(ref prt, 6) = Unsafe.Add(ref pleft, 6) & ~Unsafe.Add(ref pright, 6);
                Unsafe.Add(ref prt, 7) = Unsafe.Add(ref pleft, 7) & ~Unsafe.Add(ref pright, 7);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.BitwiseAnd_AcceleratedTypes"/>
            public static TypeCodeFlags BitwiseAnd_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.BitwiseAnd{T}(Vector512{T}, Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> BitwiseAnd<T>(Vector512<T> left, Vector512<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.BitwiseAnd(left, right);
#else
                return BitwiseAnd_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.BitwiseAnd{T}(Vector512{T}, Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> BitwiseAnd_Basic<T>(Vector512<T> left, Vector512<T> right) where T : struct {
                UnsafeUtil.SkipInit(out Vector512<T> rt);
                ref ulong prt = ref Unsafe.As<Vector512<T>, ulong>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector512<T>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector512<T>, ulong>(ref right);
                prt = pleft & pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) & Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) & Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) & Unsafe.Add(ref pright, 3);
                Unsafe.Add(ref prt, 4) = Unsafe.Add(ref pleft, 4) & Unsafe.Add(ref pright, 4);
                Unsafe.Add(ref prt, 5) = Unsafe.Add(ref pleft, 5) & Unsafe.Add(ref pright, 5);
                Unsafe.Add(ref prt, 6) = Unsafe.Add(ref pleft, 6) & Unsafe.Add(ref pright, 6);
                Unsafe.Add(ref prt, 7) = Unsafe.Add(ref pleft, 7) & Unsafe.Add(ref pright, 7);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.BitwiseOr_AcceleratedTypes"/>
            public static TypeCodeFlags BitwiseOr_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.BitwiseOr{T}(Vector512{T}, Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> BitwiseOr<T>(Vector512<T> left, Vector512<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.BitwiseOr(left, right);
#else
                return BitwiseOr_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.BitwiseOr{T}(Vector512{T}, Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> BitwiseOr_Basic<T>(Vector512<T> left, Vector512<T> right) where T : struct {
                UnsafeUtil.SkipInit(out Vector512<T> rt);
                ref ulong prt = ref Unsafe.As<Vector512<T>, ulong>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector512<T>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector512<T>, ulong>(ref right);
                prt = pleft | pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) | Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) | Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) | Unsafe.Add(ref pright, 3);
                Unsafe.Add(ref prt, 4) = Unsafe.Add(ref pleft, 4) | Unsafe.Add(ref pright, 4);
                Unsafe.Add(ref prt, 5) = Unsafe.Add(ref pleft, 5) | Unsafe.Add(ref pright, 5);
                Unsafe.Add(ref prt, 6) = Unsafe.Add(ref pleft, 6) | Unsafe.Add(ref pright, 6);
                Unsafe.Add(ref prt, 7) = Unsafe.Add(ref pleft, 7) | Unsafe.Add(ref pright, 7);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.ConditionalSelect_AcceleratedTypes"/>
            public static TypeCodeFlags ConditionalSelect_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.ConditionalSelect{T}(Vector512{T}, Vector512{T}, Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> ConditionalSelect<T>(Vector512<T> condition, Vector512<T> left, Vector512<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.ConditionalSelect(condition, left, right);
                // .NET8 on Avx512: It has hardware-accelerated.
                //00007FFDAA4CAADB  mov         rdx,16C8005FC78h  
                //00007FFDAA4CAAE5  vmovups     zmm6,zmmword ptr [rbp-0ED68h]  
                //00007FFDAA4CAAEF  vmovups     zmm7,zmmword ptr [rbp-0EDA8h]  
                //00007FFDAA4CAAF9  vpternlogd  zmm6,zmm7,zmmword ptr [rdx],0CAh  ; 0xCA: (a&b)|(~a&c)
                //00007FFDAA4CAB00  vmovups     zmmword ptr [rbp-2630h],zmm6  
#else
                return ConditionalSelect_Basic(condition, left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            ///// <inheritdoc cref="IWVectorTraits512.ConditionalSelect(Vector512{int}, Vector512{float}, Vector512{float})"/>
            //[MethodImpl(MethodImplOptions.AggressiveInlining)]
            //public static Vector512<float> ConditionalSelect(Vector512<int> condition, Vector512<float> left, Vector512<float> right) {
            //    return ConditionalSelect<float>(condition.AsSingle(), left, right);
            //}

            ///// <inheritdoc cref="IWVectorTraits512.ConditionalSelect(Vector512{long}, Vector512{double}, Vector512{double})"/>
            //[MethodImpl(MethodImplOptions.AggressiveInlining)]
            //public static Vector512<double> ConditionalSelect(Vector512<long> condition, Vector512<double> left, Vector512<double> right) {
            //    return ConditionalSelect<double>(condition.AsDouble(), left, right);
            //}

            /// <inheritdoc cref="IWVectorTraits512.ConditionalSelect{T}(Vector512{T}, Vector512{T}, Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> ConditionalSelect_Basic<T>(Vector512<T> condition, Vector512<T> left, Vector512<T> right) where T : struct {
                UnsafeUtil.SkipInit(out Vector512<T> rt);
                ref ulong pcondition = ref Unsafe.As<Vector512<T>, ulong>(ref condition);
                ref ulong pleft = ref Unsafe.As<Vector512<T>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector512<T>, ulong>(ref right);
                ref ulong prt = ref Unsafe.As<Vector512<T>, ulong>(ref rt);
                // result = (left & condition) | (right & ~condition);
                prt = (pleft & pcondition) | (pright & ~pcondition);
                Unsafe.Add(ref prt, 1) = (Unsafe.Add(ref pleft, 1) & Unsafe.Add(ref pcondition, 1)) | (Unsafe.Add(ref pright, 1) & ~Unsafe.Add(ref pcondition, 1));
                Unsafe.Add(ref prt, 2) = (Unsafe.Add(ref pleft, 2) & Unsafe.Add(ref pcondition, 2)) | (Unsafe.Add(ref pright, 2) & ~Unsafe.Add(ref pcondition, 2));
                Unsafe.Add(ref prt, 3) = (Unsafe.Add(ref pleft, 3) & Unsafe.Add(ref pcondition, 3)) | (Unsafe.Add(ref pright, 3) & ~Unsafe.Add(ref pcondition, 3));
                Unsafe.Add(ref prt, 4) = (Unsafe.Add(ref pleft, 4) & Unsafe.Add(ref pcondition, 4)) | (Unsafe.Add(ref pright, 4) & ~Unsafe.Add(ref pcondition, 4));
                Unsafe.Add(ref prt, 5) = (Unsafe.Add(ref pleft, 5) & Unsafe.Add(ref pcondition, 5)) | (Unsafe.Add(ref pright, 5) & ~Unsafe.Add(ref pcondition, 5));
                Unsafe.Add(ref prt, 6) = (Unsafe.Add(ref pleft, 6) & Unsafe.Add(ref pcondition, 6)) | (Unsafe.Add(ref pright, 6) & ~Unsafe.Add(ref pcondition, 6));
                Unsafe.Add(ref prt, 7) = (Unsafe.Add(ref pleft, 7) & Unsafe.Add(ref pcondition, 7)) | (Unsafe.Add(ref pright, 7) & ~Unsafe.Add(ref pcondition, 7));
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.Divide_AcceleratedTypes"/>
            public static TypeCodeFlags Divide_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Divide(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Divide(Vector512<float> left, Vector512<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Divide(left, right);
#else
                return Divide_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Divide(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Divide(Vector512<double> left, Vector512<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Divide(left, right);
#else
                return Divide_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Divide(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Divide_Basic(Vector512<float> left, Vector512<float> right) {
                UnsafeUtil.SkipInit(out Vector512<float> rt);
                ref float prt = ref Unsafe.As<Vector512<float>, float>(ref rt);
                ref float pleft = ref Unsafe.As<Vector512<float>, float>(ref left);
                ref float pright = ref Unsafe.As<Vector512<float>, float>(ref right);
                prt = pleft / pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) / Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) / Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) / Unsafe.Add(ref pright, 3);
                Unsafe.Add(ref prt, 4) = Unsafe.Add(ref pleft, 4) / Unsafe.Add(ref pright, 4);
                Unsafe.Add(ref prt, 5) = Unsafe.Add(ref pleft, 5) / Unsafe.Add(ref pright, 5);
                Unsafe.Add(ref prt, 6) = Unsafe.Add(ref pleft, 6) / Unsafe.Add(ref pright, 6);
                Unsafe.Add(ref prt, 7) = Unsafe.Add(ref pleft, 7) / Unsafe.Add(ref pright, 7);
                Unsafe.Add(ref prt, 8) = Unsafe.Add(ref pleft, 8) / Unsafe.Add(ref pright, 8);
                Unsafe.Add(ref prt, 9) = Unsafe.Add(ref pleft, 9) / Unsafe.Add(ref pright, 9);
                Unsafe.Add(ref prt, 10) = Unsafe.Add(ref pleft, 10) / Unsafe.Add(ref pright, 10);
                Unsafe.Add(ref prt, 11) = Unsafe.Add(ref pleft, 11) / Unsafe.Add(ref pright, 11);
                Unsafe.Add(ref prt, 12) = Unsafe.Add(ref pleft, 12) / Unsafe.Add(ref pright, 12);
                Unsafe.Add(ref prt, 13) = Unsafe.Add(ref pleft, 13) / Unsafe.Add(ref pright, 13);
                Unsafe.Add(ref prt, 14) = Unsafe.Add(ref pleft, 14) / Unsafe.Add(ref pright, 14);
                Unsafe.Add(ref prt, 15) = Unsafe.Add(ref pleft, 15) / Unsafe.Add(ref pright, 15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Divide(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Divide_Basic(Vector512<double> left, Vector512<double> right) {
                UnsafeUtil.SkipInit(out Vector512<double> rt);
                ref double prt = ref Unsafe.As<Vector512<double>, double>(ref rt);
                ref double pleft = ref Unsafe.As<Vector512<double>, double>(ref left);
                ref double pright = ref Unsafe.As<Vector512<double>, double>(ref right);
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


            /// <inheritdoc cref="IWVectorTraits512.Dot_AcceleratedTypes"/>
            public static TypeCodeFlags Dot_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Dot(Vector512<float> left, Vector512<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Dot(left, right);
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Dot(Vector512<double> left, Vector512<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Dot(left, right);
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Dot(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Dot(left, right);
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Dot(Vector512<byte> left, Vector512<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Dot(left, right);
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Dot(Vector512<short> left, Vector512<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Dot(left, right);
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Dot(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return (ushort)Vector512.Dot(left.AsInt16(), right.AsInt16());
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Dot(Vector512<int> left, Vector512<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Dot(left, right);
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Dot(Vector512<uint> left, Vector512<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return (uint)Vector512.Dot(left.AsInt32(), right.AsInt32());
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Dot(Vector512<long> left, Vector512<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Dot(left, right);
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Dot(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Dot(left, right);
#else
                return Dot_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Dot_Basic(Vector512<float> left, Vector512<float> right) {
                ref FixedArray16<float> pleft = ref Unsafe.As<Vector512<float>, FixedArray16<float>>(ref left);
                ref FixedArray16<float> pright = ref Unsafe.As<Vector512<float>, FixedArray16<float>>(ref right);
                float rt = pleft.I0 * pright.I0;
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
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Dot_Basic(Vector512<double> left, Vector512<double> right) {
                ref FixedArray8<double> pleft = ref Unsafe.As<Vector512<double>, FixedArray8<double>>(ref left);
                ref FixedArray8<double> pright = ref Unsafe.As<Vector512<double>, FixedArray8<double>>(ref right);
                double rt = pleft.I0 * pright.I0;
                rt += pleft.I1 * pright.I1;
                rt += pleft.I2 * pright.I2;
                rt += pleft.I3 * pright.I3;
                rt += pleft.I4 * pright.I4;
                rt += pleft.I5 * pright.I5;
                rt += pleft.I6 * pright.I6;
                rt += pleft.I7 * pright.I7;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Dot_Basic(Vector512<sbyte> left, Vector512<sbyte> right) {
                ref FixedArray64<sbyte> pleft = ref Unsafe.As<Vector512<sbyte>, FixedArray64<sbyte>>(ref left);
                ref FixedArray64<sbyte> pright = ref Unsafe.As<Vector512<sbyte>, FixedArray64<sbyte>>(ref right);
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
                rt += pleft.I32 * pright.I32;
                rt += pleft.I33 * pright.I33;
                rt += pleft.I34 * pright.I34;
                rt += pleft.I35 * pright.I35;
                rt += pleft.I36 * pright.I36;
                rt += pleft.I37 * pright.I37;
                rt += pleft.I38 * pright.I38;
                rt += pleft.I39 * pright.I39;
                rt += pleft.I40 * pright.I40;
                rt += pleft.I41 * pright.I41;
                rt += pleft.I42 * pright.I42;
                rt += pleft.I43 * pright.I43;
                rt += pleft.I44 * pright.I44;
                rt += pleft.I45 * pright.I45;
                rt += pleft.I46 * pright.I46;
                rt += pleft.I47 * pright.I47;
                rt += pleft.I48 * pright.I48;
                rt += pleft.I49 * pright.I49;
                rt += pleft.I50 * pright.I50;
                rt += pleft.I51 * pright.I51;
                rt += pleft.I52 * pright.I52;
                rt += pleft.I53 * pright.I53;
                rt += pleft.I54 * pright.I54;
                rt += pleft.I55 * pright.I55;
                rt += pleft.I56 * pright.I56;
                rt += pleft.I57 * pright.I57;
                rt += pleft.I58 * pright.I58;
                rt += pleft.I59 * pright.I59;
                rt += pleft.I60 * pright.I60;
                rt += pleft.I61 * pright.I61;
                rt += pleft.I62 * pright.I62;
                rt += pleft.I63 * pright.I63;
                return (sbyte)rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Dot_Basic(Vector512<byte> left, Vector512<byte> right) {
                ref FixedArray64<byte> pleft = ref Unsafe.As<Vector512<byte>, FixedArray64<byte>>(ref left);
                ref FixedArray64<byte> pright = ref Unsafe.As<Vector512<byte>, FixedArray64<byte>>(ref right);
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
                rt += pleft.I32 * pright.I32;
                rt += pleft.I33 * pright.I33;
                rt += pleft.I34 * pright.I34;
                rt += pleft.I35 * pright.I35;
                rt += pleft.I36 * pright.I36;
                rt += pleft.I37 * pright.I37;
                rt += pleft.I38 * pright.I38;
                rt += pleft.I39 * pright.I39;
                rt += pleft.I40 * pright.I40;
                rt += pleft.I41 * pright.I41;
                rt += pleft.I42 * pright.I42;
                rt += pleft.I43 * pright.I43;
                rt += pleft.I44 * pright.I44;
                rt += pleft.I45 * pright.I45;
                rt += pleft.I46 * pright.I46;
                rt += pleft.I47 * pright.I47;
                rt += pleft.I48 * pright.I48;
                rt += pleft.I49 * pright.I49;
                rt += pleft.I50 * pright.I50;
                rt += pleft.I51 * pright.I51;
                rt += pleft.I52 * pright.I52;
                rt += pleft.I53 * pright.I53;
                rt += pleft.I54 * pright.I54;
                rt += pleft.I55 * pright.I55;
                rt += pleft.I56 * pright.I56;
                rt += pleft.I57 * pright.I57;
                rt += pleft.I58 * pright.I58;
                rt += pleft.I59 * pright.I59;
                rt += pleft.I60 * pright.I60;
                rt += pleft.I61 * pright.I61;
                rt += pleft.I62 * pright.I62;
                rt += pleft.I63 * pright.I63;
                return (byte)rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Dot_Basic(Vector512<short> left, Vector512<short> right) {
                ref FixedArray32<short> pleft = ref Unsafe.As<Vector512<short>, FixedArray32<short>>(ref left);
                ref FixedArray32<short> pright = ref Unsafe.As<Vector512<short>, FixedArray32<short>>(ref right);
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
                return (short)rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Dot_Basic(Vector512<ushort> left, Vector512<ushort> right) {
                ref FixedArray32<ushort> pleft = ref Unsafe.As<Vector512<ushort>, FixedArray32<ushort>>(ref left);
                ref FixedArray32<ushort> pright = ref Unsafe.As<Vector512<ushort>, FixedArray32<ushort>>(ref right);
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
                return (ushort)rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Dot_Basic(Vector512<int> left, Vector512<int> right) {
                ref FixedArray16<int> pleft = ref Unsafe.As<Vector512<int>, FixedArray16<int>>(ref left);
                ref FixedArray16<int> pright = ref Unsafe.As<Vector512<int>, FixedArray16<int>>(ref right);
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
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Dot_Basic(Vector512<uint> left, Vector512<uint> right) {
                ref FixedArray16<uint> pleft = ref Unsafe.As<Vector512<uint>, FixedArray16<uint>>(ref left);
                ref FixedArray16<uint> pright = ref Unsafe.As<Vector512<uint>, FixedArray16<uint>>(ref right);
                uint rt = pleft.I0 * pright.I0;
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
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Dot_Basic(Vector512<long> left, Vector512<long> right) {
                ref FixedArray8<long> pleft = ref Unsafe.As<Vector512<long>, FixedArray8<long>>(ref left);
                ref FixedArray8<long> pright = ref Unsafe.As<Vector512<long>, FixedArray8<long>>(ref right);
                long rt = pleft.I0 * pright.I0;
                rt += pleft.I1 * pright.I1;
                rt += pleft.I2 * pright.I2;
                rt += pleft.I3 * pright.I3;
                rt += pleft.I4 * pright.I4;
                rt += pleft.I5 * pright.I5;
                rt += pleft.I6 * pright.I6;
                rt += pleft.I7 * pright.I7;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Dot(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Dot_Basic(Vector512<ulong> left, Vector512<ulong> right) {
                ref FixedArray8<ulong> pleft = ref Unsafe.As<Vector512<ulong>, FixedArray8<ulong>>(ref left);
                ref FixedArray8<ulong> pright = ref Unsafe.As<Vector512<ulong>, FixedArray8<ulong>>(ref right);
                ulong rt = pleft.I0 * pright.I0;
                rt += pleft.I1 * pright.I1;
                rt += pleft.I2 * pright.I2;
                rt += pleft.I3 * pright.I3;
                rt += pleft.I4 * pright.I4;
                rt += pleft.I5 * pright.I5;
                rt += pleft.I6 * pright.I6;
                rt += pleft.I7 * pright.I7;
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.Equals_AcceleratedTypes"/>
            public static TypeCodeFlags Equals_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Equals(Vector512<float> left, Vector512<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Equals(Vector512<double> left, Vector512<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Equals(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Equals(Vector512<byte> left, Vector512<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Equals(Vector512<short> left, Vector512<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Equals(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Equals(Vector512<int> left, Vector512<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Equals(Vector512<uint> left, Vector512<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Equals(Vector512<long> left, Vector512<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Equals(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Equals(left, right);
#else
                return Equals_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Equals_Basic(Vector512<float> left, Vector512<float> right) {
                UnsafeUtil.SkipInit(out Vector512<float> rt);
                ref FixedArray16<int> p = ref Unsafe.As<Vector512<float>, FixedArray16<int>>(ref rt);
                ref FixedArray16<float> pleft = ref Unsafe.As<Vector512<float>, FixedArray16<float>>(ref left);
                ref FixedArray16<float> pright = ref Unsafe.As<Vector512<float>, FixedArray16<float>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 == pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 == pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 == pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 == pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 == pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 == pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 == pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 == pright.I7);
                p.I8 = BitMath.ToInt32Mask(pleft.I8 == pright.I8);
                p.I9 = BitMath.ToInt32Mask(pleft.I9 == pright.I9);
                p.I10 = BitMath.ToInt32Mask(pleft.I10 == pright.I10);
                p.I11 = BitMath.ToInt32Mask(pleft.I11 == pright.I11);
                p.I12 = BitMath.ToInt32Mask(pleft.I12 == pright.I12);
                p.I13 = BitMath.ToInt32Mask(pleft.I13 == pright.I13);
                p.I14 = BitMath.ToInt32Mask(pleft.I14 == pright.I14);
                p.I15 = BitMath.ToInt32Mask(pleft.I15 == pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Equals_Basic(Vector512<double> left, Vector512<double> right) {
                UnsafeUtil.SkipInit(out Vector512<double> rt);
                ref FixedArray8<long> p = ref Unsafe.As<Vector512<double>, FixedArray8<long>>(ref rt);
                ref FixedArray8<double> pleft = ref Unsafe.As<Vector512<double>, FixedArray8<double>>(ref left);
                ref FixedArray8<double> pright = ref Unsafe.As<Vector512<double>, FixedArray8<double>>(ref right);
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

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Equals_Basic(Vector512<sbyte> left, Vector512<sbyte> right) {
                UnsafeUtil.SkipInit(out Vector512<sbyte> rt);
                ref FixedArray64<sbyte> p = ref Unsafe.As<Vector512<sbyte>, FixedArray64<sbyte>>(ref rt);
                ref FixedArray64<sbyte> pleft = ref Unsafe.As<Vector512<sbyte>, FixedArray64<sbyte>>(ref left);
                ref FixedArray64<sbyte> pright = ref Unsafe.As<Vector512<sbyte>, FixedArray64<sbyte>>(ref right);
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
                p.I32 = (sbyte)BitMath.ToInt32Mask(pleft.I32 == pright.I32);
                p.I33 = (sbyte)BitMath.ToInt32Mask(pleft.I33 == pright.I33);
                p.I34 = (sbyte)BitMath.ToInt32Mask(pleft.I34 == pright.I34);
                p.I35 = (sbyte)BitMath.ToInt32Mask(pleft.I35 == pright.I35);
                p.I36 = (sbyte)BitMath.ToInt32Mask(pleft.I36 == pright.I36);
                p.I37 = (sbyte)BitMath.ToInt32Mask(pleft.I37 == pright.I37);
                p.I38 = (sbyte)BitMath.ToInt32Mask(pleft.I38 == pright.I38);
                p.I39 = (sbyte)BitMath.ToInt32Mask(pleft.I39 == pright.I39);
                p.I40 = (sbyte)BitMath.ToInt32Mask(pleft.I40 == pright.I40);
                p.I41 = (sbyte)BitMath.ToInt32Mask(pleft.I41 == pright.I41);
                p.I42 = (sbyte)BitMath.ToInt32Mask(pleft.I42 == pright.I42);
                p.I43 = (sbyte)BitMath.ToInt32Mask(pleft.I43 == pright.I43);
                p.I44 = (sbyte)BitMath.ToInt32Mask(pleft.I44 == pright.I44);
                p.I45 = (sbyte)BitMath.ToInt32Mask(pleft.I45 == pright.I45);
                p.I46 = (sbyte)BitMath.ToInt32Mask(pleft.I46 == pright.I46);
                p.I47 = (sbyte)BitMath.ToInt32Mask(pleft.I47 == pright.I47);
                p.I48 = (sbyte)BitMath.ToInt32Mask(pleft.I48 == pright.I48);
                p.I49 = (sbyte)BitMath.ToInt32Mask(pleft.I49 == pright.I49);
                p.I50 = (sbyte)BitMath.ToInt32Mask(pleft.I50 == pright.I50);
                p.I51 = (sbyte)BitMath.ToInt32Mask(pleft.I51 == pright.I51);
                p.I52 = (sbyte)BitMath.ToInt32Mask(pleft.I52 == pright.I52);
                p.I53 = (sbyte)BitMath.ToInt32Mask(pleft.I53 == pright.I53);
                p.I54 = (sbyte)BitMath.ToInt32Mask(pleft.I54 == pright.I54);
                p.I55 = (sbyte)BitMath.ToInt32Mask(pleft.I55 == pright.I55);
                p.I56 = (sbyte)BitMath.ToInt32Mask(pleft.I56 == pright.I56);
                p.I57 = (sbyte)BitMath.ToInt32Mask(pleft.I57 == pright.I57);
                p.I58 = (sbyte)BitMath.ToInt32Mask(pleft.I58 == pright.I58);
                p.I59 = (sbyte)BitMath.ToInt32Mask(pleft.I59 == pright.I59);
                p.I60 = (sbyte)BitMath.ToInt32Mask(pleft.I60 == pright.I60);
                p.I61 = (sbyte)BitMath.ToInt32Mask(pleft.I61 == pright.I61);
                p.I62 = (sbyte)BitMath.ToInt32Mask(pleft.I62 == pright.I62);
                p.I63 = (sbyte)BitMath.ToInt32Mask(pleft.I63 == pright.I63);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Equals_Basic(Vector512<byte> left, Vector512<byte> right) {
                UnsafeUtil.SkipInit(out Vector512<byte> rt);
                ref FixedArray64<sbyte> p = ref Unsafe.As<Vector512<byte>, FixedArray64<sbyte>>(ref rt);
                ref FixedArray64<byte> pleft = ref Unsafe.As<Vector512<byte>, FixedArray64<byte>>(ref left);
                ref FixedArray64<byte> pright = ref Unsafe.As<Vector512<byte>, FixedArray64<byte>>(ref right);
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
                p.I32 = (sbyte)BitMath.ToInt32Mask(pleft.I32 == pright.I32);
                p.I33 = (sbyte)BitMath.ToInt32Mask(pleft.I33 == pright.I33);
                p.I34 = (sbyte)BitMath.ToInt32Mask(pleft.I34 == pright.I34);
                p.I35 = (sbyte)BitMath.ToInt32Mask(pleft.I35 == pright.I35);
                p.I36 = (sbyte)BitMath.ToInt32Mask(pleft.I36 == pright.I36);
                p.I37 = (sbyte)BitMath.ToInt32Mask(pleft.I37 == pright.I37);
                p.I38 = (sbyte)BitMath.ToInt32Mask(pleft.I38 == pright.I38);
                p.I39 = (sbyte)BitMath.ToInt32Mask(pleft.I39 == pright.I39);
                p.I40 = (sbyte)BitMath.ToInt32Mask(pleft.I40 == pright.I40);
                p.I41 = (sbyte)BitMath.ToInt32Mask(pleft.I41 == pright.I41);
                p.I42 = (sbyte)BitMath.ToInt32Mask(pleft.I42 == pright.I42);
                p.I43 = (sbyte)BitMath.ToInt32Mask(pleft.I43 == pright.I43);
                p.I44 = (sbyte)BitMath.ToInt32Mask(pleft.I44 == pright.I44);
                p.I45 = (sbyte)BitMath.ToInt32Mask(pleft.I45 == pright.I45);
                p.I46 = (sbyte)BitMath.ToInt32Mask(pleft.I46 == pright.I46);
                p.I47 = (sbyte)BitMath.ToInt32Mask(pleft.I47 == pright.I47);
                p.I48 = (sbyte)BitMath.ToInt32Mask(pleft.I48 == pright.I48);
                p.I49 = (sbyte)BitMath.ToInt32Mask(pleft.I49 == pright.I49);
                p.I50 = (sbyte)BitMath.ToInt32Mask(pleft.I50 == pright.I50);
                p.I51 = (sbyte)BitMath.ToInt32Mask(pleft.I51 == pright.I51);
                p.I52 = (sbyte)BitMath.ToInt32Mask(pleft.I52 == pright.I52);
                p.I53 = (sbyte)BitMath.ToInt32Mask(pleft.I53 == pright.I53);
                p.I54 = (sbyte)BitMath.ToInt32Mask(pleft.I54 == pright.I54);
                p.I55 = (sbyte)BitMath.ToInt32Mask(pleft.I55 == pright.I55);
                p.I56 = (sbyte)BitMath.ToInt32Mask(pleft.I56 == pright.I56);
                p.I57 = (sbyte)BitMath.ToInt32Mask(pleft.I57 == pright.I57);
                p.I58 = (sbyte)BitMath.ToInt32Mask(pleft.I58 == pright.I58);
                p.I59 = (sbyte)BitMath.ToInt32Mask(pleft.I59 == pright.I59);
                p.I60 = (sbyte)BitMath.ToInt32Mask(pleft.I60 == pright.I60);
                p.I61 = (sbyte)BitMath.ToInt32Mask(pleft.I61 == pright.I61);
                p.I62 = (sbyte)BitMath.ToInt32Mask(pleft.I62 == pright.I62);
                p.I63 = (sbyte)BitMath.ToInt32Mask(pleft.I63 == pright.I63);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Equals_Basic(Vector512<short> left, Vector512<short> right) {
                UnsafeUtil.SkipInit(out Vector512<short> rt);
                ref FixedArray32<short> p = ref Unsafe.As<Vector512<short>, FixedArray32<short>>(ref rt);
                ref FixedArray32<short> pleft = ref Unsafe.As<Vector512<short>, FixedArray32<short>>(ref left);
                ref FixedArray32<short> pright = ref Unsafe.As<Vector512<short>, FixedArray32<short>>(ref right);
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
                p.I16 = (short)BitMath.ToInt32Mask(pleft.I16 == pright.I16);
                p.I17 = (short)BitMath.ToInt32Mask(pleft.I17 == pright.I17);
                p.I18 = (short)BitMath.ToInt32Mask(pleft.I18 == pright.I18);
                p.I19 = (short)BitMath.ToInt32Mask(pleft.I19 == pright.I19);
                p.I20 = (short)BitMath.ToInt32Mask(pleft.I20 == pright.I20);
                p.I21 = (short)BitMath.ToInt32Mask(pleft.I21 == pright.I21);
                p.I22 = (short)BitMath.ToInt32Mask(pleft.I22 == pright.I22);
                p.I23 = (short)BitMath.ToInt32Mask(pleft.I23 == pright.I23);
                p.I24 = (short)BitMath.ToInt32Mask(pleft.I24 == pright.I24);
                p.I25 = (short)BitMath.ToInt32Mask(pleft.I25 == pright.I25);
                p.I26 = (short)BitMath.ToInt32Mask(pleft.I26 == pright.I26);
                p.I27 = (short)BitMath.ToInt32Mask(pleft.I27 == pright.I27);
                p.I28 = (short)BitMath.ToInt32Mask(pleft.I28 == pright.I28);
                p.I29 = (short)BitMath.ToInt32Mask(pleft.I29 == pright.I29);
                p.I30 = (short)BitMath.ToInt32Mask(pleft.I30 == pright.I30);
                p.I31 = (short)BitMath.ToInt32Mask(pleft.I31 == pright.I31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Equals_Basic(Vector512<ushort> left, Vector512<ushort> right) {
                UnsafeUtil.SkipInit(out Vector512<ushort> rt);
                ref FixedArray32<short> p = ref Unsafe.As<Vector512<ushort>, FixedArray32<short>>(ref rt);
                ref FixedArray32<ushort> pleft = ref Unsafe.As<Vector512<ushort>, FixedArray32<ushort>>(ref left);
                ref FixedArray32<ushort> pright = ref Unsafe.As<Vector512<ushort>, FixedArray32<ushort>>(ref right);
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
                p.I16 = (short)BitMath.ToInt32Mask(pleft.I16 == pright.I16);
                p.I17 = (short)BitMath.ToInt32Mask(pleft.I17 == pright.I17);
                p.I18 = (short)BitMath.ToInt32Mask(pleft.I18 == pright.I18);
                p.I19 = (short)BitMath.ToInt32Mask(pleft.I19 == pright.I19);
                p.I20 = (short)BitMath.ToInt32Mask(pleft.I20 == pright.I20);
                p.I21 = (short)BitMath.ToInt32Mask(pleft.I21 == pright.I21);
                p.I22 = (short)BitMath.ToInt32Mask(pleft.I22 == pright.I22);
                p.I23 = (short)BitMath.ToInt32Mask(pleft.I23 == pright.I23);
                p.I24 = (short)BitMath.ToInt32Mask(pleft.I24 == pright.I24);
                p.I25 = (short)BitMath.ToInt32Mask(pleft.I25 == pright.I25);
                p.I26 = (short)BitMath.ToInt32Mask(pleft.I26 == pright.I26);
                p.I27 = (short)BitMath.ToInt32Mask(pleft.I27 == pright.I27);
                p.I28 = (short)BitMath.ToInt32Mask(pleft.I28 == pright.I28);
                p.I29 = (short)BitMath.ToInt32Mask(pleft.I29 == pright.I29);
                p.I30 = (short)BitMath.ToInt32Mask(pleft.I30 == pright.I30);
                p.I31 = (short)BitMath.ToInt32Mask(pleft.I31 == pright.I31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Equals_Basic(Vector512<int> left, Vector512<int> right) {
                UnsafeUtil.SkipInit(out Vector512<int> rt);
                ref FixedArray16<int> p = ref Unsafe.As<Vector512<int>, FixedArray16<int>>(ref rt);
                ref FixedArray16<int> pleft = ref Unsafe.As<Vector512<int>, FixedArray16<int>>(ref left);
                ref FixedArray16<int> pright = ref Unsafe.As<Vector512<int>, FixedArray16<int>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 == pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 == pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 == pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 == pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 == pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 == pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 == pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 == pright.I7);
                p.I8 = BitMath.ToInt32Mask(pleft.I8 == pright.I8);
                p.I9 = BitMath.ToInt32Mask(pleft.I9 == pright.I9);
                p.I10 = BitMath.ToInt32Mask(pleft.I10 == pright.I10);
                p.I11 = BitMath.ToInt32Mask(pleft.I11 == pright.I11);
                p.I12 = BitMath.ToInt32Mask(pleft.I12 == pright.I12);
                p.I13 = BitMath.ToInt32Mask(pleft.I13 == pright.I13);
                p.I14 = BitMath.ToInt32Mask(pleft.I14 == pright.I14);
                p.I15 = BitMath.ToInt32Mask(pleft.I15 == pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Equals_Basic(Vector512<uint> left, Vector512<uint> right) {
                UnsafeUtil.SkipInit(out Vector512<uint> rt);
                ref FixedArray16<int> p = ref Unsafe.As<Vector512<uint>, FixedArray16<int>>(ref rt);
                ref FixedArray16<uint> pleft = ref Unsafe.As<Vector512<uint>, FixedArray16<uint>>(ref left);
                ref FixedArray16<uint> pright = ref Unsafe.As<Vector512<uint>, FixedArray16<uint>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 == pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 == pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 == pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 == pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 == pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 == pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 == pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 == pright.I7);
                p.I8 = BitMath.ToInt32Mask(pleft.I8 == pright.I8);
                p.I9 = BitMath.ToInt32Mask(pleft.I9 == pright.I9);
                p.I10 = BitMath.ToInt32Mask(pleft.I10 == pright.I10);
                p.I11 = BitMath.ToInt32Mask(pleft.I11 == pright.I11);
                p.I12 = BitMath.ToInt32Mask(pleft.I12 == pright.I12);
                p.I13 = BitMath.ToInt32Mask(pleft.I13 == pright.I13);
                p.I14 = BitMath.ToInt32Mask(pleft.I14 == pright.I14);
                p.I15 = BitMath.ToInt32Mask(pleft.I15 == pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Equals_Basic(Vector512<long> left, Vector512<long> right) {
                UnsafeUtil.SkipInit(out Vector512<long> rt);
                ref FixedArray8<long> p = ref Unsafe.As<Vector512<long>, FixedArray8<long>>(ref rt);
                ref FixedArray8<long> pleft = ref Unsafe.As<Vector512<long>, FixedArray8<long>>(ref left);
                ref FixedArray8<long> pright = ref Unsafe.As<Vector512<long>, FixedArray8<long>>(ref right);
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

            /// <inheritdoc cref="IWVectorTraits512.Equals(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Equals_Basic(Vector512<ulong> left, Vector512<ulong> right) {
                UnsafeUtil.SkipInit(out Vector512<ulong> rt);
                ref FixedArray8<long> p = ref Unsafe.As<Vector512<ulong>, FixedArray8<long>>(ref rt);
                ref FixedArray8<ulong> pleft = ref Unsafe.As<Vector512<ulong>, FixedArray8<ulong>>(ref left);
                ref FixedArray8<ulong> pright = ref Unsafe.As<Vector512<ulong>, FixedArray8<ulong>>(ref right);
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


            /// <inheritdoc cref="IWVectorTraits512.EqualsAll_AcceleratedTypes"/>
            public static TypeCodeFlags EqualsAll_AcceleratedTypes {
                get {
                    return Equals_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector512<float> left, Vector512<float> right) {
                return Vector512.EqualsAll(left, right);
                // .NET8 on Avx512: It has hardware-accelerated.
                //00007FFDAB58EDB2  vmovups     zmm6,zmmword ptr [rbp-0ED68h]  
                //00007FFDAB58EDBC  vcmpps      k1,zmm6,zmmword ptr [rcx],0  
                //00007FFDAB58EDC3  kortestw    k1,k1  
                //00007FFDAB58EDC7  setb        cl  
                //00007FFDAB58EDCA  movzx       ecx,cl  
                //00007FFDAB58EDCD  mov         dword ptr [rbp-4158h],ecx  
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector512<double> left, Vector512<double> right) {
                return Vector512.EqualsAll(left, right);
                // .NET8 on Avx512: It has hardware-accelerated.
                //00007FFDAB58EECE  vmovups     zmm6,zmmword ptr [rbp-0ED68h]  
                //00007FFDAB58EED8  vcmppd      k1,zmm6,zmmword ptr [rcx],0  
                //00007FFDAB58EEDF  kortestb    k1,k1  
                //00007FFDAB58EEE3  setb        cl  
                //00007FFDAB58EEE6  movzx       ecx,cl  
                //00007FFDAB58EEE9  mov         dword ptr [rbp-4188h],ecx  
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector512<sbyte> left, Vector512<sbyte> right) {
                return Vector512.EqualsAll(left, right);
                // .NET8 on Avx512: It has hardware-accelerated.
                //00007FFDAB58EFEA  vmovups     zmm6,zmmword ptr [rbp-0ED68h]  
                //00007FFDAB58EFF4  vpcmpeqb    k1,zmm6,zmmword ptr [rcx]  
                //00007FFDAB58EFFA  kortestq    k1,k1  
                //00007FFDAB58EFFF  setb        cl  
                //00007FFDAB58F002  movzx       ecx,cl  
                //00007FFDAB58F005  mov         dword ptr [rbp-41B8h],ecx  
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector512<byte> left, Vector512<byte> right) {
                return Vector512.EqualsAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector512<short> left, Vector512<short> right) {
                return Vector512.EqualsAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector512<ushort> left, Vector512<ushort> right) {
                return Vector512.EqualsAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector512<int> left, Vector512<int> right) {
                return Vector512.EqualsAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector512<uint> left, Vector512<uint> right) {
                return Vector512.EqualsAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector512<long> left, Vector512<long> right) {
                return Vector512.EqualsAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAll(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector512<ulong> left, Vector512<ulong> right) {
                return Vector512.EqualsAll(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits512.EqualsAny_AcceleratedTypes"/>
            public static TypeCodeFlags EqualsAny_AcceleratedTypes {
                get {
                    return Equals_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector512<float> left, Vector512<float> right) {
                return Vector512.EqualsAny(left, right);
                // .NET8 on Avx512: It has hardware-accelerated.
                //00007FFDAB58F8C6  vmovups     zmm6,zmmword ptr [rbp-0ED68h]  
                //00007FFDAB58F8D0  vcmpps      k1,zmm6,zmmword ptr [rcx],0  
                //00007FFDAB58F8D7  kortestw    k1,k1  
                //00007FFDAB58F8DB  setne       cl  
                //00007FFDAB58F8DE  movzx       ecx,cl  
                //00007FFDAB58F8E1  mov         dword ptr [rbp-4338h],ecx  
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector512<double> left, Vector512<double> right) {
                return Vector512.EqualsAny(left, right);
                // .NET8 on Avx512: It has hardware-accelerated.
                //00007FFDAB58F9E2  vmovups     zmm6,zmmword ptr [rbp-0ED68h]  
                //00007FFDAB58F9EC  vcmppd      k1,zmm6,zmmword ptr [rcx],0  
                //00007FFDAB58F9F3  kortestb    k1,k1  
                //00007FFDAB58F9F7  setne       cl  
                //00007FFDAB58F9FA  movzx       ecx,cl  
                //00007FFDAB58F9FD  mov         dword ptr [rbp-4368h],ecx  
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector512<sbyte> left, Vector512<sbyte> right) {
                return Vector512.EqualsAny(left, right);
                // .NET8 on Avx512: It has hardware-accelerated.
                //00007FFDAB58FAFE  vmovups     zmm6,zmmword ptr [rbp-0ED68h]  
                //00007FFDAB58FB08  vpcmpeqb    k1,zmm6,zmmword ptr [rcx]  
                //00007FFDAB58FB0E  kortestq    k1,k1  
                //00007FFDAB58FB13  setne       cl  
                //00007FFDAB58FB16  movzx       ecx,cl  
                //00007FFDAB58FB19  mov         dword ptr [rbp-4398h],ecx  
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector512<byte> left, Vector512<byte> right) {
                return Vector512.EqualsAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector512<short> left, Vector512<short> right) {
                return Vector512.EqualsAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector512<ushort> left, Vector512<ushort> right) {
                return Vector512.EqualsAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector512<int> left, Vector512<int> right) {
                return Vector512.EqualsAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector512<uint> left, Vector512<uint> right) {
                return Vector512.EqualsAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector512<long> left, Vector512<long> right) {
                return Vector512.EqualsAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.EqualsAny(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector512<ulong> left, Vector512<ulong> right) {
                return Vector512.EqualsAny(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits512.GreaterThan_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThan_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> GreaterThan(Vector512<float> left, Vector512<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> GreaterThan(Vector512<double> left, Vector512<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> GreaterThan(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> GreaterThan(Vector512<byte> left, Vector512<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> GreaterThan(Vector512<short> left, Vector512<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> GreaterThan(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> GreaterThan(Vector512<int> left, Vector512<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> GreaterThan(Vector512<uint> left, Vector512<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> GreaterThan(Vector512<long> left, Vector512<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> GreaterThan(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.GreaterThan(left, right);
#else
                return GreaterThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> GreaterThan_Basic(Vector512<float> left, Vector512<float> right) {
                UnsafeUtil.SkipInit(out Vector512<float> rt);
                ref FixedArray16<int> p = ref Unsafe.As<Vector512<float>, FixedArray16<int>>(ref rt);
                ref FixedArray16<float> pleft = ref Unsafe.As<Vector512<float>, FixedArray16<float>>(ref left);
                ref FixedArray16<float> pright = ref Unsafe.As<Vector512<float>, FixedArray16<float>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 > pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 > pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 > pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 > pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 > pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 > pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 > pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 > pright.I7);
                p.I8 = BitMath.ToInt32Mask(pleft.I8 > pright.I8);
                p.I9 = BitMath.ToInt32Mask(pleft.I9 > pright.I9);
                p.I10 = BitMath.ToInt32Mask(pleft.I10 > pright.I10);
                p.I11 = BitMath.ToInt32Mask(pleft.I11 > pright.I11);
                p.I12 = BitMath.ToInt32Mask(pleft.I12 > pright.I12);
                p.I13 = BitMath.ToInt32Mask(pleft.I13 > pright.I13);
                p.I14 = BitMath.ToInt32Mask(pleft.I14 > pright.I14);
                p.I15 = BitMath.ToInt32Mask(pleft.I15 > pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> GreaterThan_Basic(Vector512<double> left, Vector512<double> right) {
                UnsafeUtil.SkipInit(out Vector512<double> rt);
                ref FixedArray8<long> p = ref Unsafe.As<Vector512<double>, FixedArray8<long>>(ref rt);
                ref FixedArray8<double> pleft = ref Unsafe.As<Vector512<double>, FixedArray8<double>>(ref left);
                ref FixedArray8<double> pright = ref Unsafe.As<Vector512<double>, FixedArray8<double>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 > pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 > pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 > pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 > pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 > pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 > pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 > pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 > pright.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> GreaterThan_Basic(Vector512<sbyte> left, Vector512<sbyte> right) {
                UnsafeUtil.SkipInit(out Vector512<sbyte> rt);
                ref FixedArray64<sbyte> p = ref Unsafe.As<Vector512<sbyte>, FixedArray64<sbyte>>(ref rt);
                ref FixedArray64<sbyte> pleft = ref Unsafe.As<Vector512<sbyte>, FixedArray64<sbyte>>(ref left);
                ref FixedArray64<sbyte> pright = ref Unsafe.As<Vector512<sbyte>, FixedArray64<sbyte>>(ref right);
                p.I0 = (sbyte)BitMath.ToInt32Mask(pleft.I0 > pright.I0);
                p.I1 = (sbyte)BitMath.ToInt32Mask(pleft.I1 > pright.I1);
                p.I2 = (sbyte)BitMath.ToInt32Mask(pleft.I2 > pright.I2);
                p.I3 = (sbyte)BitMath.ToInt32Mask(pleft.I3 > pright.I3);
                p.I4 = (sbyte)BitMath.ToInt32Mask(pleft.I4 > pright.I4);
                p.I5 = (sbyte)BitMath.ToInt32Mask(pleft.I5 > pright.I5);
                p.I6 = (sbyte)BitMath.ToInt32Mask(pleft.I6 > pright.I6);
                p.I7 = (sbyte)BitMath.ToInt32Mask(pleft.I7 > pright.I7);
                p.I8 = (sbyte)BitMath.ToInt32Mask(pleft.I8 > pright.I8);
                p.I9 = (sbyte)BitMath.ToInt32Mask(pleft.I9 > pright.I9);
                p.I10 = (sbyte)BitMath.ToInt32Mask(pleft.I10 > pright.I10);
                p.I11 = (sbyte)BitMath.ToInt32Mask(pleft.I11 > pright.I11);
                p.I12 = (sbyte)BitMath.ToInt32Mask(pleft.I12 > pright.I12);
                p.I13 = (sbyte)BitMath.ToInt32Mask(pleft.I13 > pright.I13);
                p.I14 = (sbyte)BitMath.ToInt32Mask(pleft.I14 > pright.I14);
                p.I15 = (sbyte)BitMath.ToInt32Mask(pleft.I15 > pright.I15);
                p.I16 = (sbyte)BitMath.ToInt32Mask(pleft.I16 > pright.I16);
                p.I17 = (sbyte)BitMath.ToInt32Mask(pleft.I17 > pright.I17);
                p.I18 = (sbyte)BitMath.ToInt32Mask(pleft.I18 > pright.I18);
                p.I19 = (sbyte)BitMath.ToInt32Mask(pleft.I19 > pright.I19);
                p.I20 = (sbyte)BitMath.ToInt32Mask(pleft.I20 > pright.I20);
                p.I21 = (sbyte)BitMath.ToInt32Mask(pleft.I21 > pright.I21);
                p.I22 = (sbyte)BitMath.ToInt32Mask(pleft.I22 > pright.I22);
                p.I23 = (sbyte)BitMath.ToInt32Mask(pleft.I23 > pright.I23);
                p.I24 = (sbyte)BitMath.ToInt32Mask(pleft.I24 > pright.I24);
                p.I25 = (sbyte)BitMath.ToInt32Mask(pleft.I25 > pright.I25);
                p.I26 = (sbyte)BitMath.ToInt32Mask(pleft.I26 > pright.I26);
                p.I27 = (sbyte)BitMath.ToInt32Mask(pleft.I27 > pright.I27);
                p.I28 = (sbyte)BitMath.ToInt32Mask(pleft.I28 > pright.I28);
                p.I29 = (sbyte)BitMath.ToInt32Mask(pleft.I29 > pright.I29);
                p.I30 = (sbyte)BitMath.ToInt32Mask(pleft.I30 > pright.I30);
                p.I31 = (sbyte)BitMath.ToInt32Mask(pleft.I31 > pright.I31);
                p.I32 = (sbyte)BitMath.ToInt32Mask(pleft.I32 > pright.I32);
                p.I33 = (sbyte)BitMath.ToInt32Mask(pleft.I33 > pright.I33);
                p.I34 = (sbyte)BitMath.ToInt32Mask(pleft.I34 > pright.I34);
                p.I35 = (sbyte)BitMath.ToInt32Mask(pleft.I35 > pright.I35);
                p.I36 = (sbyte)BitMath.ToInt32Mask(pleft.I36 > pright.I36);
                p.I37 = (sbyte)BitMath.ToInt32Mask(pleft.I37 > pright.I37);
                p.I38 = (sbyte)BitMath.ToInt32Mask(pleft.I38 > pright.I38);
                p.I39 = (sbyte)BitMath.ToInt32Mask(pleft.I39 > pright.I39);
                p.I40 = (sbyte)BitMath.ToInt32Mask(pleft.I40 > pright.I40);
                p.I41 = (sbyte)BitMath.ToInt32Mask(pleft.I41 > pright.I41);
                p.I42 = (sbyte)BitMath.ToInt32Mask(pleft.I42 > pright.I42);
                p.I43 = (sbyte)BitMath.ToInt32Mask(pleft.I43 > pright.I43);
                p.I44 = (sbyte)BitMath.ToInt32Mask(pleft.I44 > pright.I44);
                p.I45 = (sbyte)BitMath.ToInt32Mask(pleft.I45 > pright.I45);
                p.I46 = (sbyte)BitMath.ToInt32Mask(pleft.I46 > pright.I46);
                p.I47 = (sbyte)BitMath.ToInt32Mask(pleft.I47 > pright.I47);
                p.I48 = (sbyte)BitMath.ToInt32Mask(pleft.I48 > pright.I48);
                p.I49 = (sbyte)BitMath.ToInt32Mask(pleft.I49 > pright.I49);
                p.I50 = (sbyte)BitMath.ToInt32Mask(pleft.I50 > pright.I50);
                p.I51 = (sbyte)BitMath.ToInt32Mask(pleft.I51 > pright.I51);
                p.I52 = (sbyte)BitMath.ToInt32Mask(pleft.I52 > pright.I52);
                p.I53 = (sbyte)BitMath.ToInt32Mask(pleft.I53 > pright.I53);
                p.I54 = (sbyte)BitMath.ToInt32Mask(pleft.I54 > pright.I54);
                p.I55 = (sbyte)BitMath.ToInt32Mask(pleft.I55 > pright.I55);
                p.I56 = (sbyte)BitMath.ToInt32Mask(pleft.I56 > pright.I56);
                p.I57 = (sbyte)BitMath.ToInt32Mask(pleft.I57 > pright.I57);
                p.I58 = (sbyte)BitMath.ToInt32Mask(pleft.I58 > pright.I58);
                p.I59 = (sbyte)BitMath.ToInt32Mask(pleft.I59 > pright.I59);
                p.I60 = (sbyte)BitMath.ToInt32Mask(pleft.I60 > pright.I60);
                p.I61 = (sbyte)BitMath.ToInt32Mask(pleft.I61 > pright.I61);
                p.I62 = (sbyte)BitMath.ToInt32Mask(pleft.I62 > pright.I62);
                p.I63 = (sbyte)BitMath.ToInt32Mask(pleft.I63 > pright.I63);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> GreaterThan_Basic(Vector512<byte> left, Vector512<byte> right) {
                UnsafeUtil.SkipInit(out Vector512<byte> rt);
                ref FixedArray64<sbyte> p = ref Unsafe.As<Vector512<byte>, FixedArray64<sbyte>>(ref rt);
                ref FixedArray64<byte> pleft = ref Unsafe.As<Vector512<byte>, FixedArray64<byte>>(ref left);
                ref FixedArray64<byte> pright = ref Unsafe.As<Vector512<byte>, FixedArray64<byte>>(ref right);
                p.I0 = (sbyte)BitMath.ToInt32Mask(pleft.I0 > pright.I0);
                p.I1 = (sbyte)BitMath.ToInt32Mask(pleft.I1 > pright.I1);
                p.I2 = (sbyte)BitMath.ToInt32Mask(pleft.I2 > pright.I2);
                p.I3 = (sbyte)BitMath.ToInt32Mask(pleft.I3 > pright.I3);
                p.I4 = (sbyte)BitMath.ToInt32Mask(pleft.I4 > pright.I4);
                p.I5 = (sbyte)BitMath.ToInt32Mask(pleft.I5 > pright.I5);
                p.I6 = (sbyte)BitMath.ToInt32Mask(pleft.I6 > pright.I6);
                p.I7 = (sbyte)BitMath.ToInt32Mask(pleft.I7 > pright.I7);
                p.I8 = (sbyte)BitMath.ToInt32Mask(pleft.I8 > pright.I8);
                p.I9 = (sbyte)BitMath.ToInt32Mask(pleft.I9 > pright.I9);
                p.I10 = (sbyte)BitMath.ToInt32Mask(pleft.I10 > pright.I10);
                p.I11 = (sbyte)BitMath.ToInt32Mask(pleft.I11 > pright.I11);
                p.I12 = (sbyte)BitMath.ToInt32Mask(pleft.I12 > pright.I12);
                p.I13 = (sbyte)BitMath.ToInt32Mask(pleft.I13 > pright.I13);
                p.I14 = (sbyte)BitMath.ToInt32Mask(pleft.I14 > pright.I14);
                p.I15 = (sbyte)BitMath.ToInt32Mask(pleft.I15 > pright.I15);
                p.I16 = (sbyte)BitMath.ToInt32Mask(pleft.I16 > pright.I16);
                p.I17 = (sbyte)BitMath.ToInt32Mask(pleft.I17 > pright.I17);
                p.I18 = (sbyte)BitMath.ToInt32Mask(pleft.I18 > pright.I18);
                p.I19 = (sbyte)BitMath.ToInt32Mask(pleft.I19 > pright.I19);
                p.I20 = (sbyte)BitMath.ToInt32Mask(pleft.I20 > pright.I20);
                p.I21 = (sbyte)BitMath.ToInt32Mask(pleft.I21 > pright.I21);
                p.I22 = (sbyte)BitMath.ToInt32Mask(pleft.I22 > pright.I22);
                p.I23 = (sbyte)BitMath.ToInt32Mask(pleft.I23 > pright.I23);
                p.I24 = (sbyte)BitMath.ToInt32Mask(pleft.I24 > pright.I24);
                p.I25 = (sbyte)BitMath.ToInt32Mask(pleft.I25 > pright.I25);
                p.I26 = (sbyte)BitMath.ToInt32Mask(pleft.I26 > pright.I26);
                p.I27 = (sbyte)BitMath.ToInt32Mask(pleft.I27 > pright.I27);
                p.I28 = (sbyte)BitMath.ToInt32Mask(pleft.I28 > pright.I28);
                p.I29 = (sbyte)BitMath.ToInt32Mask(pleft.I29 > pright.I29);
                p.I30 = (sbyte)BitMath.ToInt32Mask(pleft.I30 > pright.I30);
                p.I31 = (sbyte)BitMath.ToInt32Mask(pleft.I31 > pright.I31);
                p.I32 = (sbyte)BitMath.ToInt32Mask(pleft.I32 > pright.I32);
                p.I33 = (sbyte)BitMath.ToInt32Mask(pleft.I33 > pright.I33);
                p.I34 = (sbyte)BitMath.ToInt32Mask(pleft.I34 > pright.I34);
                p.I35 = (sbyte)BitMath.ToInt32Mask(pleft.I35 > pright.I35);
                p.I36 = (sbyte)BitMath.ToInt32Mask(pleft.I36 > pright.I36);
                p.I37 = (sbyte)BitMath.ToInt32Mask(pleft.I37 > pright.I37);
                p.I38 = (sbyte)BitMath.ToInt32Mask(pleft.I38 > pright.I38);
                p.I39 = (sbyte)BitMath.ToInt32Mask(pleft.I39 > pright.I39);
                p.I40 = (sbyte)BitMath.ToInt32Mask(pleft.I40 > pright.I40);
                p.I41 = (sbyte)BitMath.ToInt32Mask(pleft.I41 > pright.I41);
                p.I42 = (sbyte)BitMath.ToInt32Mask(pleft.I42 > pright.I42);
                p.I43 = (sbyte)BitMath.ToInt32Mask(pleft.I43 > pright.I43);
                p.I44 = (sbyte)BitMath.ToInt32Mask(pleft.I44 > pright.I44);
                p.I45 = (sbyte)BitMath.ToInt32Mask(pleft.I45 > pright.I45);
                p.I46 = (sbyte)BitMath.ToInt32Mask(pleft.I46 > pright.I46);
                p.I47 = (sbyte)BitMath.ToInt32Mask(pleft.I47 > pright.I47);
                p.I48 = (sbyte)BitMath.ToInt32Mask(pleft.I48 > pright.I48);
                p.I49 = (sbyte)BitMath.ToInt32Mask(pleft.I49 > pright.I49);
                p.I50 = (sbyte)BitMath.ToInt32Mask(pleft.I50 > pright.I50);
                p.I51 = (sbyte)BitMath.ToInt32Mask(pleft.I51 > pright.I51);
                p.I52 = (sbyte)BitMath.ToInt32Mask(pleft.I52 > pright.I52);
                p.I53 = (sbyte)BitMath.ToInt32Mask(pleft.I53 > pright.I53);
                p.I54 = (sbyte)BitMath.ToInt32Mask(pleft.I54 > pright.I54);
                p.I55 = (sbyte)BitMath.ToInt32Mask(pleft.I55 > pright.I55);
                p.I56 = (sbyte)BitMath.ToInt32Mask(pleft.I56 > pright.I56);
                p.I57 = (sbyte)BitMath.ToInt32Mask(pleft.I57 > pright.I57);
                p.I58 = (sbyte)BitMath.ToInt32Mask(pleft.I58 > pright.I58);
                p.I59 = (sbyte)BitMath.ToInt32Mask(pleft.I59 > pright.I59);
                p.I60 = (sbyte)BitMath.ToInt32Mask(pleft.I60 > pright.I60);
                p.I61 = (sbyte)BitMath.ToInt32Mask(pleft.I61 > pright.I61);
                p.I62 = (sbyte)BitMath.ToInt32Mask(pleft.I62 > pright.I62);
                p.I63 = (sbyte)BitMath.ToInt32Mask(pleft.I63 > pright.I63);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> GreaterThan_Basic(Vector512<short> left, Vector512<short> right) {
                UnsafeUtil.SkipInit(out Vector512<short> rt);
                ref FixedArray32<short> p = ref Unsafe.As<Vector512<short>, FixedArray32<short>>(ref rt);
                ref FixedArray32<short> pleft = ref Unsafe.As<Vector512<short>, FixedArray32<short>>(ref left);
                ref FixedArray32<short> pright = ref Unsafe.As<Vector512<short>, FixedArray32<short>>(ref right);
                p.I0 = (short)BitMath.ToInt32Mask(pleft.I0 > pright.I0);
                p.I1 = (short)BitMath.ToInt32Mask(pleft.I1 > pright.I1);
                p.I2 = (short)BitMath.ToInt32Mask(pleft.I2 > pright.I2);
                p.I3 = (short)BitMath.ToInt32Mask(pleft.I3 > pright.I3);
                p.I4 = (short)BitMath.ToInt32Mask(pleft.I4 > pright.I4);
                p.I5 = (short)BitMath.ToInt32Mask(pleft.I5 > pright.I5);
                p.I6 = (short)BitMath.ToInt32Mask(pleft.I6 > pright.I6);
                p.I7 = (short)BitMath.ToInt32Mask(pleft.I7 > pright.I7);
                p.I8 = (short)BitMath.ToInt32Mask(pleft.I8 > pright.I8);
                p.I9 = (short)BitMath.ToInt32Mask(pleft.I9 > pright.I9);
                p.I10 = (short)BitMath.ToInt32Mask(pleft.I10 > pright.I10);
                p.I11 = (short)BitMath.ToInt32Mask(pleft.I11 > pright.I11);
                p.I12 = (short)BitMath.ToInt32Mask(pleft.I12 > pright.I12);
                p.I13 = (short)BitMath.ToInt32Mask(pleft.I13 > pright.I13);
                p.I14 = (short)BitMath.ToInt32Mask(pleft.I14 > pright.I14);
                p.I15 = (short)BitMath.ToInt32Mask(pleft.I15 > pright.I15);
                p.I16 = (short)BitMath.ToInt32Mask(pleft.I16 > pright.I16);
                p.I17 = (short)BitMath.ToInt32Mask(pleft.I17 > pright.I17);
                p.I18 = (short)BitMath.ToInt32Mask(pleft.I18 > pright.I18);
                p.I19 = (short)BitMath.ToInt32Mask(pleft.I19 > pright.I19);
                p.I20 = (short)BitMath.ToInt32Mask(pleft.I20 > pright.I20);
                p.I21 = (short)BitMath.ToInt32Mask(pleft.I21 > pright.I21);
                p.I22 = (short)BitMath.ToInt32Mask(pleft.I22 > pright.I22);
                p.I23 = (short)BitMath.ToInt32Mask(pleft.I23 > pright.I23);
                p.I24 = (short)BitMath.ToInt32Mask(pleft.I24 > pright.I24);
                p.I25 = (short)BitMath.ToInt32Mask(pleft.I25 > pright.I25);
                p.I26 = (short)BitMath.ToInt32Mask(pleft.I26 > pright.I26);
                p.I27 = (short)BitMath.ToInt32Mask(pleft.I27 > pright.I27);
                p.I28 = (short)BitMath.ToInt32Mask(pleft.I28 > pright.I28);
                p.I29 = (short)BitMath.ToInt32Mask(pleft.I29 > pright.I29);
                p.I30 = (short)BitMath.ToInt32Mask(pleft.I30 > pright.I30);
                p.I31 = (short)BitMath.ToInt32Mask(pleft.I31 > pright.I31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> GreaterThan_Basic(Vector512<ushort> left, Vector512<ushort> right) {
                UnsafeUtil.SkipInit(out Vector512<ushort> rt);
                ref FixedArray32<short> p = ref Unsafe.As<Vector512<ushort>, FixedArray32<short>>(ref rt);
                ref FixedArray32<ushort> pleft = ref Unsafe.As<Vector512<ushort>, FixedArray32<ushort>>(ref left);
                ref FixedArray32<ushort> pright = ref Unsafe.As<Vector512<ushort>, FixedArray32<ushort>>(ref right);
                p.I0 = (short)BitMath.ToInt32Mask(pleft.I0 > pright.I0);
                p.I1 = (short)BitMath.ToInt32Mask(pleft.I1 > pright.I1);
                p.I2 = (short)BitMath.ToInt32Mask(pleft.I2 > pright.I2);
                p.I3 = (short)BitMath.ToInt32Mask(pleft.I3 > pright.I3);
                p.I4 = (short)BitMath.ToInt32Mask(pleft.I4 > pright.I4);
                p.I5 = (short)BitMath.ToInt32Mask(pleft.I5 > pright.I5);
                p.I6 = (short)BitMath.ToInt32Mask(pleft.I6 > pright.I6);
                p.I7 = (short)BitMath.ToInt32Mask(pleft.I7 > pright.I7);
                p.I8 = (short)BitMath.ToInt32Mask(pleft.I8 > pright.I8);
                p.I9 = (short)BitMath.ToInt32Mask(pleft.I9 > pright.I9);
                p.I10 = (short)BitMath.ToInt32Mask(pleft.I10 > pright.I10);
                p.I11 = (short)BitMath.ToInt32Mask(pleft.I11 > pright.I11);
                p.I12 = (short)BitMath.ToInt32Mask(pleft.I12 > pright.I12);
                p.I13 = (short)BitMath.ToInt32Mask(pleft.I13 > pright.I13);
                p.I14 = (short)BitMath.ToInt32Mask(pleft.I14 > pright.I14);
                p.I15 = (short)BitMath.ToInt32Mask(pleft.I15 > pright.I15);
                p.I16 = (short)BitMath.ToInt32Mask(pleft.I16 > pright.I16);
                p.I17 = (short)BitMath.ToInt32Mask(pleft.I17 > pright.I17);
                p.I18 = (short)BitMath.ToInt32Mask(pleft.I18 > pright.I18);
                p.I19 = (short)BitMath.ToInt32Mask(pleft.I19 > pright.I19);
                p.I20 = (short)BitMath.ToInt32Mask(pleft.I20 > pright.I20);
                p.I21 = (short)BitMath.ToInt32Mask(pleft.I21 > pright.I21);
                p.I22 = (short)BitMath.ToInt32Mask(pleft.I22 > pright.I22);
                p.I23 = (short)BitMath.ToInt32Mask(pleft.I23 > pright.I23);
                p.I24 = (short)BitMath.ToInt32Mask(pleft.I24 > pright.I24);
                p.I25 = (short)BitMath.ToInt32Mask(pleft.I25 > pright.I25);
                p.I26 = (short)BitMath.ToInt32Mask(pleft.I26 > pright.I26);
                p.I27 = (short)BitMath.ToInt32Mask(pleft.I27 > pright.I27);
                p.I28 = (short)BitMath.ToInt32Mask(pleft.I28 > pright.I28);
                p.I29 = (short)BitMath.ToInt32Mask(pleft.I29 > pright.I29);
                p.I30 = (short)BitMath.ToInt32Mask(pleft.I30 > pright.I30);
                p.I31 = (short)BitMath.ToInt32Mask(pleft.I31 > pright.I31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> GreaterThan_Basic(Vector512<int> left, Vector512<int> right) {
                UnsafeUtil.SkipInit(out Vector512<int> rt);
                ref FixedArray16<int> p = ref Unsafe.As<Vector512<int>, FixedArray16<int>>(ref rt);
                ref FixedArray16<int> pleft = ref Unsafe.As<Vector512<int>, FixedArray16<int>>(ref left);
                ref FixedArray16<int> pright = ref Unsafe.As<Vector512<int>, FixedArray16<int>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 > pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 > pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 > pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 > pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 > pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 > pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 > pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 > pright.I7);
                p.I8 = BitMath.ToInt32Mask(pleft.I8 > pright.I8);
                p.I9 = BitMath.ToInt32Mask(pleft.I9 > pright.I9);
                p.I10 = BitMath.ToInt32Mask(pleft.I10 > pright.I10);
                p.I11 = BitMath.ToInt32Mask(pleft.I11 > pright.I11);
                p.I12 = BitMath.ToInt32Mask(pleft.I12 > pright.I12);
                p.I13 = BitMath.ToInt32Mask(pleft.I13 > pright.I13);
                p.I14 = BitMath.ToInt32Mask(pleft.I14 > pright.I14);
                p.I15 = BitMath.ToInt32Mask(pleft.I15 > pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> GreaterThan_Basic(Vector512<uint> left, Vector512<uint> right) {
                UnsafeUtil.SkipInit(out Vector512<uint> rt);
                ref FixedArray16<int> p = ref Unsafe.As<Vector512<uint>, FixedArray16<int>>(ref rt);
                ref FixedArray16<uint> pleft = ref Unsafe.As<Vector512<uint>, FixedArray16<uint>>(ref left);
                ref FixedArray16<uint> pright = ref Unsafe.As<Vector512<uint>, FixedArray16<uint>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 > pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 > pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 > pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 > pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 > pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 > pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 > pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 > pright.I7);
                p.I8 = BitMath.ToInt32Mask(pleft.I8 > pright.I8);
                p.I9 = BitMath.ToInt32Mask(pleft.I9 > pright.I9);
                p.I10 = BitMath.ToInt32Mask(pleft.I10 > pright.I10);
                p.I11 = BitMath.ToInt32Mask(pleft.I11 > pright.I11);
                p.I12 = BitMath.ToInt32Mask(pleft.I12 > pright.I12);
                p.I13 = BitMath.ToInt32Mask(pleft.I13 > pright.I13);
                p.I14 = BitMath.ToInt32Mask(pleft.I14 > pright.I14);
                p.I15 = BitMath.ToInt32Mask(pleft.I15 > pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> GreaterThan_Basic(Vector512<long> left, Vector512<long> right) {
                UnsafeUtil.SkipInit(out Vector512<long> rt);
                ref FixedArray8<long> p = ref Unsafe.As<Vector512<long>, FixedArray8<long>>(ref rt);
                ref FixedArray8<long> pleft = ref Unsafe.As<Vector512<long>, FixedArray8<long>>(ref left);
                ref FixedArray8<long> pright = ref Unsafe.As<Vector512<long>, FixedArray8<long>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 > pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 > pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 > pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 > pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 > pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 > pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 > pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 > pright.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThan(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> GreaterThan_Basic(Vector512<ulong> left, Vector512<ulong> right) {
                UnsafeUtil.SkipInit(out Vector512<ulong> rt);
                ref FixedArray8<long> p = ref Unsafe.As<Vector512<ulong>, FixedArray8<long>>(ref rt);
                ref FixedArray8<ulong> pleft = ref Unsafe.As<Vector512<ulong>, FixedArray8<ulong>>(ref left);
                ref FixedArray8<ulong> pright = ref Unsafe.As<Vector512<ulong>, FixedArray8<ulong>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 > pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 > pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 > pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 > pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 > pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 > pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 > pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 > pright.I7);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanAll_AcceleratedTypes {
                get {
                    return GreaterThan_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector512<float> left, Vector512<float> right) {
                return Vector512.GreaterThanAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector512<double> left, Vector512<double> right) {
                return Vector512.GreaterThanAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector512<sbyte> left, Vector512<sbyte> right) {
                return Vector512.GreaterThanAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector512<byte> left, Vector512<byte> right) {
                return Vector512.GreaterThanAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector512<short> left, Vector512<short> right) {
                return Vector512.GreaterThanAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector512<ushort> left, Vector512<ushort> right) {
                return Vector512.GreaterThanAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector512<int> left, Vector512<int> right) {
                return Vector512.GreaterThanAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector512<uint> left, Vector512<uint> right) {
                return Vector512.GreaterThanAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector512<long> left, Vector512<long> right) {
                return Vector512.GreaterThanAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAll(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector512<ulong> left, Vector512<ulong> right) {
                return Vector512.GreaterThanAll(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanAny_AcceleratedTypes {
                get {
                    return GreaterThan_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector512<float> left, Vector512<float> right) {
                return Vector512.GreaterThanAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector512<double> left, Vector512<double> right) {
                return Vector512.GreaterThanAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector512<sbyte> left, Vector512<sbyte> right) {
                return Vector512.GreaterThanAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector512<byte> left, Vector512<byte> right) {
                return Vector512.GreaterThanAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector512<short> left, Vector512<short> right) {
                return Vector512.GreaterThanAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector512<ushort> left, Vector512<ushort> right) {
                return Vector512.GreaterThanAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector512<int> left, Vector512<int> right) {
                return Vector512.GreaterThanAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector512<uint> left, Vector512<uint> right) {
                return Vector512.GreaterThanAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector512<long> left, Vector512<long> right) {
                return Vector512.GreaterThanAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanAny(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector512<ulong> left, Vector512<ulong> right) {
                return Vector512.GreaterThanAny(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanOrEqual_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> GreaterThanOrEqual(Vector512<float> left, Vector512<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> GreaterThanOrEqual(Vector512<double> left, Vector512<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> GreaterThanOrEqual(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> GreaterThanOrEqual(Vector512<byte> left, Vector512<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> GreaterThanOrEqual(Vector512<short> left, Vector512<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> GreaterThanOrEqual(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> GreaterThanOrEqual(Vector512<int> left, Vector512<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> GreaterThanOrEqual(Vector512<uint> left, Vector512<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> GreaterThanOrEqual(Vector512<long> left, Vector512<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> GreaterThanOrEqual(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.GreaterThanOrEqual(left, right);
#else
                return GreaterThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> GreaterThanOrEqual_Basic(Vector512<float> left, Vector512<float> right) {
                UnsafeUtil.SkipInit(out Vector512<float> rt);
                ref FixedArray16<int> p = ref Unsafe.As<Vector512<float>, FixedArray16<int>>(ref rt);
                ref FixedArray16<float> pleft = ref Unsafe.As<Vector512<float>, FixedArray16<float>>(ref left);
                ref FixedArray16<float> pright = ref Unsafe.As<Vector512<float>, FixedArray16<float>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 >= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 >= pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 >= pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 >= pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 >= pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 >= pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 >= pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 >= pright.I7);
                p.I8 = BitMath.ToInt32Mask(pleft.I8 >= pright.I8);
                p.I9 = BitMath.ToInt32Mask(pleft.I9 >= pright.I9);
                p.I10 = BitMath.ToInt32Mask(pleft.I10 >= pright.I10);
                p.I11 = BitMath.ToInt32Mask(pleft.I11 >= pright.I11);
                p.I12 = BitMath.ToInt32Mask(pleft.I12 >= pright.I12);
                p.I13 = BitMath.ToInt32Mask(pleft.I13 >= pright.I13);
                p.I14 = BitMath.ToInt32Mask(pleft.I14 >= pright.I14);
                p.I15 = BitMath.ToInt32Mask(pleft.I15 >= pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> GreaterThanOrEqual_Basic(Vector512<double> left, Vector512<double> right) {
                UnsafeUtil.SkipInit(out Vector512<double> rt);
                ref FixedArray8<long> p = ref Unsafe.As<Vector512<double>, FixedArray8<long>>(ref rt);
                ref FixedArray8<double> pleft = ref Unsafe.As<Vector512<double>, FixedArray8<double>>(ref left);
                ref FixedArray8<double> pright = ref Unsafe.As<Vector512<double>, FixedArray8<double>>(ref right);
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

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> GreaterThanOrEqual_Basic(Vector512<sbyte> left, Vector512<sbyte> right) {
                UnsafeUtil.SkipInit(out Vector512<sbyte> rt);
                ref FixedArray64<sbyte> p = ref Unsafe.As<Vector512<sbyte>, FixedArray64<sbyte>>(ref rt);
                ref FixedArray64<sbyte> pleft = ref Unsafe.As<Vector512<sbyte>, FixedArray64<sbyte>>(ref left);
                ref FixedArray64<sbyte> pright = ref Unsafe.As<Vector512<sbyte>, FixedArray64<sbyte>>(ref right);
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
                p.I32 = (sbyte)BitMath.ToInt32Mask(pleft.I32 >= pright.I32);
                p.I33 = (sbyte)BitMath.ToInt32Mask(pleft.I33 >= pright.I33);
                p.I34 = (sbyte)BitMath.ToInt32Mask(pleft.I34 >= pright.I34);
                p.I35 = (sbyte)BitMath.ToInt32Mask(pleft.I35 >= pright.I35);
                p.I36 = (sbyte)BitMath.ToInt32Mask(pleft.I36 >= pright.I36);
                p.I37 = (sbyte)BitMath.ToInt32Mask(pleft.I37 >= pright.I37);
                p.I38 = (sbyte)BitMath.ToInt32Mask(pleft.I38 >= pright.I38);
                p.I39 = (sbyte)BitMath.ToInt32Mask(pleft.I39 >= pright.I39);
                p.I40 = (sbyte)BitMath.ToInt32Mask(pleft.I40 >= pright.I40);
                p.I41 = (sbyte)BitMath.ToInt32Mask(pleft.I41 >= pright.I41);
                p.I42 = (sbyte)BitMath.ToInt32Mask(pleft.I42 >= pright.I42);
                p.I43 = (sbyte)BitMath.ToInt32Mask(pleft.I43 >= pright.I43);
                p.I44 = (sbyte)BitMath.ToInt32Mask(pleft.I44 >= pright.I44);
                p.I45 = (sbyte)BitMath.ToInt32Mask(pleft.I45 >= pright.I45);
                p.I46 = (sbyte)BitMath.ToInt32Mask(pleft.I46 >= pright.I46);
                p.I47 = (sbyte)BitMath.ToInt32Mask(pleft.I47 >= pright.I47);
                p.I48 = (sbyte)BitMath.ToInt32Mask(pleft.I48 >= pright.I48);
                p.I49 = (sbyte)BitMath.ToInt32Mask(pleft.I49 >= pright.I49);
                p.I50 = (sbyte)BitMath.ToInt32Mask(pleft.I50 >= pright.I50);
                p.I51 = (sbyte)BitMath.ToInt32Mask(pleft.I51 >= pright.I51);
                p.I52 = (sbyte)BitMath.ToInt32Mask(pleft.I52 >= pright.I52);
                p.I53 = (sbyte)BitMath.ToInt32Mask(pleft.I53 >= pright.I53);
                p.I54 = (sbyte)BitMath.ToInt32Mask(pleft.I54 >= pright.I54);
                p.I55 = (sbyte)BitMath.ToInt32Mask(pleft.I55 >= pright.I55);
                p.I56 = (sbyte)BitMath.ToInt32Mask(pleft.I56 >= pright.I56);
                p.I57 = (sbyte)BitMath.ToInt32Mask(pleft.I57 >= pright.I57);
                p.I58 = (sbyte)BitMath.ToInt32Mask(pleft.I58 >= pright.I58);
                p.I59 = (sbyte)BitMath.ToInt32Mask(pleft.I59 >= pright.I59);
                p.I60 = (sbyte)BitMath.ToInt32Mask(pleft.I60 >= pright.I60);
                p.I61 = (sbyte)BitMath.ToInt32Mask(pleft.I61 >= pright.I61);
                p.I62 = (sbyte)BitMath.ToInt32Mask(pleft.I62 >= pright.I62);
                p.I63 = (sbyte)BitMath.ToInt32Mask(pleft.I63 >= pright.I63);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> GreaterThanOrEqual_Basic(Vector512<byte> left, Vector512<byte> right) {
                UnsafeUtil.SkipInit(out Vector512<byte> rt);
                ref FixedArray64<sbyte> p = ref Unsafe.As<Vector512<byte>, FixedArray64<sbyte>>(ref rt);
                ref FixedArray64<byte> pleft = ref Unsafe.As<Vector512<byte>, FixedArray64<byte>>(ref left);
                ref FixedArray64<byte> pright = ref Unsafe.As<Vector512<byte>, FixedArray64<byte>>(ref right);
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
                p.I32 = (sbyte)BitMath.ToInt32Mask(pleft.I32 >= pright.I32);
                p.I33 = (sbyte)BitMath.ToInt32Mask(pleft.I33 >= pright.I33);
                p.I34 = (sbyte)BitMath.ToInt32Mask(pleft.I34 >= pright.I34);
                p.I35 = (sbyte)BitMath.ToInt32Mask(pleft.I35 >= pright.I35);
                p.I36 = (sbyte)BitMath.ToInt32Mask(pleft.I36 >= pright.I36);
                p.I37 = (sbyte)BitMath.ToInt32Mask(pleft.I37 >= pright.I37);
                p.I38 = (sbyte)BitMath.ToInt32Mask(pleft.I38 >= pright.I38);
                p.I39 = (sbyte)BitMath.ToInt32Mask(pleft.I39 >= pright.I39);
                p.I40 = (sbyte)BitMath.ToInt32Mask(pleft.I40 >= pright.I40);
                p.I41 = (sbyte)BitMath.ToInt32Mask(pleft.I41 >= pright.I41);
                p.I42 = (sbyte)BitMath.ToInt32Mask(pleft.I42 >= pright.I42);
                p.I43 = (sbyte)BitMath.ToInt32Mask(pleft.I43 >= pright.I43);
                p.I44 = (sbyte)BitMath.ToInt32Mask(pleft.I44 >= pright.I44);
                p.I45 = (sbyte)BitMath.ToInt32Mask(pleft.I45 >= pright.I45);
                p.I46 = (sbyte)BitMath.ToInt32Mask(pleft.I46 >= pright.I46);
                p.I47 = (sbyte)BitMath.ToInt32Mask(pleft.I47 >= pright.I47);
                p.I48 = (sbyte)BitMath.ToInt32Mask(pleft.I48 >= pright.I48);
                p.I49 = (sbyte)BitMath.ToInt32Mask(pleft.I49 >= pright.I49);
                p.I50 = (sbyte)BitMath.ToInt32Mask(pleft.I50 >= pright.I50);
                p.I51 = (sbyte)BitMath.ToInt32Mask(pleft.I51 >= pright.I51);
                p.I52 = (sbyte)BitMath.ToInt32Mask(pleft.I52 >= pright.I52);
                p.I53 = (sbyte)BitMath.ToInt32Mask(pleft.I53 >= pright.I53);
                p.I54 = (sbyte)BitMath.ToInt32Mask(pleft.I54 >= pright.I54);
                p.I55 = (sbyte)BitMath.ToInt32Mask(pleft.I55 >= pright.I55);
                p.I56 = (sbyte)BitMath.ToInt32Mask(pleft.I56 >= pright.I56);
                p.I57 = (sbyte)BitMath.ToInt32Mask(pleft.I57 >= pright.I57);
                p.I58 = (sbyte)BitMath.ToInt32Mask(pleft.I58 >= pright.I58);
                p.I59 = (sbyte)BitMath.ToInt32Mask(pleft.I59 >= pright.I59);
                p.I60 = (sbyte)BitMath.ToInt32Mask(pleft.I60 >= pright.I60);
                p.I61 = (sbyte)BitMath.ToInt32Mask(pleft.I61 >= pright.I61);
                p.I62 = (sbyte)BitMath.ToInt32Mask(pleft.I62 >= pright.I62);
                p.I63 = (sbyte)BitMath.ToInt32Mask(pleft.I63 >= pright.I63);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> GreaterThanOrEqual_Basic(Vector512<short> left, Vector512<short> right) {
                UnsafeUtil.SkipInit(out Vector512<short> rt);
                ref FixedArray32<short> p = ref Unsafe.As<Vector512<short>, FixedArray32<short>>(ref rt);
                ref FixedArray32<short> pleft = ref Unsafe.As<Vector512<short>, FixedArray32<short>>(ref left);
                ref FixedArray32<short> pright = ref Unsafe.As<Vector512<short>, FixedArray32<short>>(ref right);
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
                p.I16 = (short)BitMath.ToInt32Mask(pleft.I16 >= pright.I16);
                p.I17 = (short)BitMath.ToInt32Mask(pleft.I17 >= pright.I17);
                p.I18 = (short)BitMath.ToInt32Mask(pleft.I18 >= pright.I18);
                p.I19 = (short)BitMath.ToInt32Mask(pleft.I19 >= pright.I19);
                p.I20 = (short)BitMath.ToInt32Mask(pleft.I20 >= pright.I20);
                p.I21 = (short)BitMath.ToInt32Mask(pleft.I21 >= pright.I21);
                p.I22 = (short)BitMath.ToInt32Mask(pleft.I22 >= pright.I22);
                p.I23 = (short)BitMath.ToInt32Mask(pleft.I23 >= pright.I23);
                p.I24 = (short)BitMath.ToInt32Mask(pleft.I24 >= pright.I24);
                p.I25 = (short)BitMath.ToInt32Mask(pleft.I25 >= pright.I25);
                p.I26 = (short)BitMath.ToInt32Mask(pleft.I26 >= pright.I26);
                p.I27 = (short)BitMath.ToInt32Mask(pleft.I27 >= pright.I27);
                p.I28 = (short)BitMath.ToInt32Mask(pleft.I28 >= pright.I28);
                p.I29 = (short)BitMath.ToInt32Mask(pleft.I29 >= pright.I29);
                p.I30 = (short)BitMath.ToInt32Mask(pleft.I30 >= pright.I30);
                p.I31 = (short)BitMath.ToInt32Mask(pleft.I31 >= pright.I31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> GreaterThanOrEqual_Basic(Vector512<ushort> left, Vector512<ushort> right) {
                UnsafeUtil.SkipInit(out Vector512<ushort> rt);
                ref FixedArray32<short> p = ref Unsafe.As<Vector512<ushort>, FixedArray32<short>>(ref rt);
                ref FixedArray32<ushort> pleft = ref Unsafe.As<Vector512<ushort>, FixedArray32<ushort>>(ref left);
                ref FixedArray32<ushort> pright = ref Unsafe.As<Vector512<ushort>, FixedArray32<ushort>>(ref right);
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
                p.I16 = (short)BitMath.ToInt32Mask(pleft.I16 >= pright.I16);
                p.I17 = (short)BitMath.ToInt32Mask(pleft.I17 >= pright.I17);
                p.I18 = (short)BitMath.ToInt32Mask(pleft.I18 >= pright.I18);
                p.I19 = (short)BitMath.ToInt32Mask(pleft.I19 >= pright.I19);
                p.I20 = (short)BitMath.ToInt32Mask(pleft.I20 >= pright.I20);
                p.I21 = (short)BitMath.ToInt32Mask(pleft.I21 >= pright.I21);
                p.I22 = (short)BitMath.ToInt32Mask(pleft.I22 >= pright.I22);
                p.I23 = (short)BitMath.ToInt32Mask(pleft.I23 >= pright.I23);
                p.I24 = (short)BitMath.ToInt32Mask(pleft.I24 >= pright.I24);
                p.I25 = (short)BitMath.ToInt32Mask(pleft.I25 >= pright.I25);
                p.I26 = (short)BitMath.ToInt32Mask(pleft.I26 >= pright.I26);
                p.I27 = (short)BitMath.ToInt32Mask(pleft.I27 >= pright.I27);
                p.I28 = (short)BitMath.ToInt32Mask(pleft.I28 >= pright.I28);
                p.I29 = (short)BitMath.ToInt32Mask(pleft.I29 >= pright.I29);
                p.I30 = (short)BitMath.ToInt32Mask(pleft.I30 >= pright.I30);
                p.I31 = (short)BitMath.ToInt32Mask(pleft.I31 >= pright.I31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> GreaterThanOrEqual_Basic(Vector512<int> left, Vector512<int> right) {
                UnsafeUtil.SkipInit(out Vector512<int> rt);
                ref FixedArray16<int> p = ref Unsafe.As<Vector512<int>, FixedArray16<int>>(ref rt);
                ref FixedArray16<int> pleft = ref Unsafe.As<Vector512<int>, FixedArray16<int>>(ref left);
                ref FixedArray16<int> pright = ref Unsafe.As<Vector512<int>, FixedArray16<int>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 >= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 >= pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 >= pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 >= pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 >= pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 >= pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 >= pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 >= pright.I7);
                p.I8 = BitMath.ToInt32Mask(pleft.I8 >= pright.I8);
                p.I9 = BitMath.ToInt32Mask(pleft.I9 >= pright.I9);
                p.I10 = BitMath.ToInt32Mask(pleft.I10 >= pright.I10);
                p.I11 = BitMath.ToInt32Mask(pleft.I11 >= pright.I11);
                p.I12 = BitMath.ToInt32Mask(pleft.I12 >= pright.I12);
                p.I13 = BitMath.ToInt32Mask(pleft.I13 >= pright.I13);
                p.I14 = BitMath.ToInt32Mask(pleft.I14 >= pright.I14);
                p.I15 = BitMath.ToInt32Mask(pleft.I15 >= pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> GreaterThanOrEqual_Basic(Vector512<uint> left, Vector512<uint> right) {
                UnsafeUtil.SkipInit(out Vector512<uint> rt);
                ref FixedArray16<int> p = ref Unsafe.As<Vector512<uint>, FixedArray16<int>>(ref rt);
                ref FixedArray16<uint> pleft = ref Unsafe.As<Vector512<uint>, FixedArray16<uint>>(ref left);
                ref FixedArray16<uint> pright = ref Unsafe.As<Vector512<uint>, FixedArray16<uint>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 >= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 >= pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 >= pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 >= pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 >= pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 >= pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 >= pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 >= pright.I7);
                p.I8 = BitMath.ToInt32Mask(pleft.I8 >= pright.I8);
                p.I9 = BitMath.ToInt32Mask(pleft.I9 >= pright.I9);
                p.I10 = BitMath.ToInt32Mask(pleft.I10 >= pright.I10);
                p.I11 = BitMath.ToInt32Mask(pleft.I11 >= pright.I11);
                p.I12 = BitMath.ToInt32Mask(pleft.I12 >= pright.I12);
                p.I13 = BitMath.ToInt32Mask(pleft.I13 >= pright.I13);
                p.I14 = BitMath.ToInt32Mask(pleft.I14 >= pright.I14);
                p.I15 = BitMath.ToInt32Mask(pleft.I15 >= pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> GreaterThanOrEqual_Basic(Vector512<long> left, Vector512<long> right) {
                UnsafeUtil.SkipInit(out Vector512<long> rt);
                ref FixedArray8<long> p = ref Unsafe.As<Vector512<long>, FixedArray8<long>>(ref rt);
                ref FixedArray8<long> pleft = ref Unsafe.As<Vector512<long>, FixedArray8<long>>(ref left);
                ref FixedArray8<long> pright = ref Unsafe.As<Vector512<long>, FixedArray8<long>>(ref right);
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

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqual(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> GreaterThanOrEqual_Basic(Vector512<ulong> left, Vector512<ulong> right) {
                UnsafeUtil.SkipInit(out Vector512<ulong> rt);
                ref FixedArray8<long> p = ref Unsafe.As<Vector512<ulong>, FixedArray8<long>>(ref rt);
                ref FixedArray8<ulong> pleft = ref Unsafe.As<Vector512<ulong>, FixedArray8<ulong>>(ref left);
                ref FixedArray8<ulong> pright = ref Unsafe.As<Vector512<ulong>, FixedArray8<ulong>>(ref right);
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


            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanOrEqualAll_AcceleratedTypes {
                get {
                    return GreaterThanOrEqual_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector512<float> left, Vector512<float> right) {
                return Vector512.GreaterThanOrEqualAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector512<double> left, Vector512<double> right) {
                return Vector512.GreaterThanOrEqualAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector512<sbyte> left, Vector512<sbyte> right) {
                return Vector512.GreaterThanOrEqualAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector512<byte> left, Vector512<byte> right) {
                return Vector512.GreaterThanOrEqualAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector512<short> left, Vector512<short> right) {
                return Vector512.GreaterThanOrEqualAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector512<ushort> left, Vector512<ushort> right) {
                return Vector512.GreaterThanOrEqualAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector512<int> left, Vector512<int> right) {
                return Vector512.GreaterThanOrEqualAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector512<uint> left, Vector512<uint> right) {
                return Vector512.GreaterThanOrEqualAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector512<long> left, Vector512<long> right) {
                return Vector512.GreaterThanOrEqualAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAll(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector512<ulong> left, Vector512<ulong> right) {
                return Vector512.GreaterThanOrEqualAll(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanOrEqualAny_AcceleratedTypes {
                get {
                    return GreaterThanOrEqual_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector512<float> left, Vector512<float> right) {
                return Vector512.GreaterThanOrEqualAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector512<double> left, Vector512<double> right) {
                return Vector512.GreaterThanOrEqualAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector512<sbyte> left, Vector512<sbyte> right) {
                return Vector512.GreaterThanOrEqualAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector512<byte> left, Vector512<byte> right) {
                return Vector512.GreaterThanOrEqualAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector512<short> left, Vector512<short> right) {
                return Vector512.GreaterThanOrEqualAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector512<ushort> left, Vector512<ushort> right) {
                return Vector512.GreaterThanOrEqualAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector512<int> left, Vector512<int> right) {
                return Vector512.GreaterThanOrEqualAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector512<uint> left, Vector512<uint> right) {
                return Vector512.GreaterThanOrEqualAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector512<long> left, Vector512<long> right) {
                return Vector512.GreaterThanOrEqualAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.GreaterThanOrEqualAny(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector512<ulong> left, Vector512<ulong> right) {
                return Vector512.GreaterThanOrEqualAny(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits512.LessThan_AcceleratedTypes"/>
            public static TypeCodeFlags LessThan_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> LessThan(Vector512<float> left, Vector512<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> LessThan(Vector512<double> left, Vector512<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> LessThan(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> LessThan(Vector512<byte> left, Vector512<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> LessThan(Vector512<short> left, Vector512<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> LessThan(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> LessThan(Vector512<int> left, Vector512<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> LessThan(Vector512<uint> left, Vector512<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> LessThan(Vector512<long> left, Vector512<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> LessThan(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.LessThan(left, right);
#else
                return LessThan_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> LessThan_Basic(Vector512<float> left, Vector512<float> right) {
                UnsafeUtil.SkipInit(out Vector512<float> rt);
                ref FixedArray16<int> p = ref Unsafe.As<Vector512<float>, FixedArray16<int>>(ref rt);
                ref FixedArray16<float> pleft = ref Unsafe.As<Vector512<float>, FixedArray16<float>>(ref left);
                ref FixedArray16<float> pright = ref Unsafe.As<Vector512<float>, FixedArray16<float>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 < pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 < pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 < pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 < pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 < pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 < pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 < pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 < pright.I7);
                p.I8 = BitMath.ToInt32Mask(pleft.I8 < pright.I8);
                p.I9 = BitMath.ToInt32Mask(pleft.I9 < pright.I9);
                p.I10 = BitMath.ToInt32Mask(pleft.I10 < pright.I10);
                p.I11 = BitMath.ToInt32Mask(pleft.I11 < pright.I11);
                p.I12 = BitMath.ToInt32Mask(pleft.I12 < pright.I12);
                p.I13 = BitMath.ToInt32Mask(pleft.I13 < pright.I13);
                p.I14 = BitMath.ToInt32Mask(pleft.I14 < pright.I14);
                p.I15 = BitMath.ToInt32Mask(pleft.I15 < pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> LessThan_Basic(Vector512<double> left, Vector512<double> right) {
                UnsafeUtil.SkipInit(out Vector512<double> rt);
                ref FixedArray8<long> p = ref Unsafe.As<Vector512<double>, FixedArray8<long>>(ref rt);
                ref FixedArray8<double> pleft = ref Unsafe.As<Vector512<double>, FixedArray8<double>>(ref left);
                ref FixedArray8<double> pright = ref Unsafe.As<Vector512<double>, FixedArray8<double>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 < pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 < pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 < pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 < pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 < pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 < pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 < pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 < pright.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> LessThan_Basic(Vector512<sbyte> left, Vector512<sbyte> right) {
                UnsafeUtil.SkipInit(out Vector512<sbyte> rt);
                ref FixedArray64<sbyte> p = ref Unsafe.As<Vector512<sbyte>, FixedArray64<sbyte>>(ref rt);
                ref FixedArray64<sbyte> pleft = ref Unsafe.As<Vector512<sbyte>, FixedArray64<sbyte>>(ref left);
                ref FixedArray64<sbyte> pright = ref Unsafe.As<Vector512<sbyte>, FixedArray64<sbyte>>(ref right);
                p.I0 = (sbyte)BitMath.ToInt32Mask(pleft.I0 < pright.I0);
                p.I1 = (sbyte)BitMath.ToInt32Mask(pleft.I1 < pright.I1);
                p.I2 = (sbyte)BitMath.ToInt32Mask(pleft.I2 < pright.I2);
                p.I3 = (sbyte)BitMath.ToInt32Mask(pleft.I3 < pright.I3);
                p.I4 = (sbyte)BitMath.ToInt32Mask(pleft.I4 < pright.I4);
                p.I5 = (sbyte)BitMath.ToInt32Mask(pleft.I5 < pright.I5);
                p.I6 = (sbyte)BitMath.ToInt32Mask(pleft.I6 < pright.I6);
                p.I7 = (sbyte)BitMath.ToInt32Mask(pleft.I7 < pright.I7);
                p.I8 = (sbyte)BitMath.ToInt32Mask(pleft.I8 < pright.I8);
                p.I9 = (sbyte)BitMath.ToInt32Mask(pleft.I9 < pright.I9);
                p.I10 = (sbyte)BitMath.ToInt32Mask(pleft.I10 < pright.I10);
                p.I11 = (sbyte)BitMath.ToInt32Mask(pleft.I11 < pright.I11);
                p.I12 = (sbyte)BitMath.ToInt32Mask(pleft.I12 < pright.I12);
                p.I13 = (sbyte)BitMath.ToInt32Mask(pleft.I13 < pright.I13);
                p.I14 = (sbyte)BitMath.ToInt32Mask(pleft.I14 < pright.I14);
                p.I15 = (sbyte)BitMath.ToInt32Mask(pleft.I15 < pright.I15);
                p.I16 = (sbyte)BitMath.ToInt32Mask(pleft.I16 < pright.I16);
                p.I17 = (sbyte)BitMath.ToInt32Mask(pleft.I17 < pright.I17);
                p.I18 = (sbyte)BitMath.ToInt32Mask(pleft.I18 < pright.I18);
                p.I19 = (sbyte)BitMath.ToInt32Mask(pleft.I19 < pright.I19);
                p.I20 = (sbyte)BitMath.ToInt32Mask(pleft.I20 < pright.I20);
                p.I21 = (sbyte)BitMath.ToInt32Mask(pleft.I21 < pright.I21);
                p.I22 = (sbyte)BitMath.ToInt32Mask(pleft.I22 < pright.I22);
                p.I23 = (sbyte)BitMath.ToInt32Mask(pleft.I23 < pright.I23);
                p.I24 = (sbyte)BitMath.ToInt32Mask(pleft.I24 < pright.I24);
                p.I25 = (sbyte)BitMath.ToInt32Mask(pleft.I25 < pright.I25);
                p.I26 = (sbyte)BitMath.ToInt32Mask(pleft.I26 < pright.I26);
                p.I27 = (sbyte)BitMath.ToInt32Mask(pleft.I27 < pright.I27);
                p.I28 = (sbyte)BitMath.ToInt32Mask(pleft.I28 < pright.I28);
                p.I29 = (sbyte)BitMath.ToInt32Mask(pleft.I29 < pright.I29);
                p.I30 = (sbyte)BitMath.ToInt32Mask(pleft.I30 < pright.I30);
                p.I31 = (sbyte)BitMath.ToInt32Mask(pleft.I31 < pright.I31);
                p.I32 = (sbyte)BitMath.ToInt32Mask(pleft.I32 < pright.I32);
                p.I33 = (sbyte)BitMath.ToInt32Mask(pleft.I33 < pright.I33);
                p.I34 = (sbyte)BitMath.ToInt32Mask(pleft.I34 < pright.I34);
                p.I35 = (sbyte)BitMath.ToInt32Mask(pleft.I35 < pright.I35);
                p.I36 = (sbyte)BitMath.ToInt32Mask(pleft.I36 < pright.I36);
                p.I37 = (sbyte)BitMath.ToInt32Mask(pleft.I37 < pright.I37);
                p.I38 = (sbyte)BitMath.ToInt32Mask(pleft.I38 < pright.I38);
                p.I39 = (sbyte)BitMath.ToInt32Mask(pleft.I39 < pright.I39);
                p.I40 = (sbyte)BitMath.ToInt32Mask(pleft.I40 < pright.I40);
                p.I41 = (sbyte)BitMath.ToInt32Mask(pleft.I41 < pright.I41);
                p.I42 = (sbyte)BitMath.ToInt32Mask(pleft.I42 < pright.I42);
                p.I43 = (sbyte)BitMath.ToInt32Mask(pleft.I43 < pright.I43);
                p.I44 = (sbyte)BitMath.ToInt32Mask(pleft.I44 < pright.I44);
                p.I45 = (sbyte)BitMath.ToInt32Mask(pleft.I45 < pright.I45);
                p.I46 = (sbyte)BitMath.ToInt32Mask(pleft.I46 < pright.I46);
                p.I47 = (sbyte)BitMath.ToInt32Mask(pleft.I47 < pright.I47);
                p.I48 = (sbyte)BitMath.ToInt32Mask(pleft.I48 < pright.I48);
                p.I49 = (sbyte)BitMath.ToInt32Mask(pleft.I49 < pright.I49);
                p.I50 = (sbyte)BitMath.ToInt32Mask(pleft.I50 < pright.I50);
                p.I51 = (sbyte)BitMath.ToInt32Mask(pleft.I51 < pright.I51);
                p.I52 = (sbyte)BitMath.ToInt32Mask(pleft.I52 < pright.I52);
                p.I53 = (sbyte)BitMath.ToInt32Mask(pleft.I53 < pright.I53);
                p.I54 = (sbyte)BitMath.ToInt32Mask(pleft.I54 < pright.I54);
                p.I55 = (sbyte)BitMath.ToInt32Mask(pleft.I55 < pright.I55);
                p.I56 = (sbyte)BitMath.ToInt32Mask(pleft.I56 < pright.I56);
                p.I57 = (sbyte)BitMath.ToInt32Mask(pleft.I57 < pright.I57);
                p.I58 = (sbyte)BitMath.ToInt32Mask(pleft.I58 < pright.I58);
                p.I59 = (sbyte)BitMath.ToInt32Mask(pleft.I59 < pright.I59);
                p.I60 = (sbyte)BitMath.ToInt32Mask(pleft.I60 < pright.I60);
                p.I61 = (sbyte)BitMath.ToInt32Mask(pleft.I61 < pright.I61);
                p.I62 = (sbyte)BitMath.ToInt32Mask(pleft.I62 < pright.I62);
                p.I63 = (sbyte)BitMath.ToInt32Mask(pleft.I63 < pright.I63);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> LessThan_Basic(Vector512<byte> left, Vector512<byte> right) {
                UnsafeUtil.SkipInit(out Vector512<byte> rt);
                ref FixedArray64<sbyte> p = ref Unsafe.As<Vector512<byte>, FixedArray64<sbyte>>(ref rt);
                ref FixedArray64<byte> pleft = ref Unsafe.As<Vector512<byte>, FixedArray64<byte>>(ref left);
                ref FixedArray64<byte> pright = ref Unsafe.As<Vector512<byte>, FixedArray64<byte>>(ref right);
                p.I0 = (sbyte)BitMath.ToInt32Mask(pleft.I0 < pright.I0);
                p.I1 = (sbyte)BitMath.ToInt32Mask(pleft.I1 < pright.I1);
                p.I2 = (sbyte)BitMath.ToInt32Mask(pleft.I2 < pright.I2);
                p.I3 = (sbyte)BitMath.ToInt32Mask(pleft.I3 < pright.I3);
                p.I4 = (sbyte)BitMath.ToInt32Mask(pleft.I4 < pright.I4);
                p.I5 = (sbyte)BitMath.ToInt32Mask(pleft.I5 < pright.I5);
                p.I6 = (sbyte)BitMath.ToInt32Mask(pleft.I6 < pright.I6);
                p.I7 = (sbyte)BitMath.ToInt32Mask(pleft.I7 < pright.I7);
                p.I8 = (sbyte)BitMath.ToInt32Mask(pleft.I8 < pright.I8);
                p.I9 = (sbyte)BitMath.ToInt32Mask(pleft.I9 < pright.I9);
                p.I10 = (sbyte)BitMath.ToInt32Mask(pleft.I10 < pright.I10);
                p.I11 = (sbyte)BitMath.ToInt32Mask(pleft.I11 < pright.I11);
                p.I12 = (sbyte)BitMath.ToInt32Mask(pleft.I12 < pright.I12);
                p.I13 = (sbyte)BitMath.ToInt32Mask(pleft.I13 < pright.I13);
                p.I14 = (sbyte)BitMath.ToInt32Mask(pleft.I14 < pright.I14);
                p.I15 = (sbyte)BitMath.ToInt32Mask(pleft.I15 < pright.I15);
                p.I16 = (sbyte)BitMath.ToInt32Mask(pleft.I16 < pright.I16);
                p.I17 = (sbyte)BitMath.ToInt32Mask(pleft.I17 < pright.I17);
                p.I18 = (sbyte)BitMath.ToInt32Mask(pleft.I18 < pright.I18);
                p.I19 = (sbyte)BitMath.ToInt32Mask(pleft.I19 < pright.I19);
                p.I20 = (sbyte)BitMath.ToInt32Mask(pleft.I20 < pright.I20);
                p.I21 = (sbyte)BitMath.ToInt32Mask(pleft.I21 < pright.I21);
                p.I22 = (sbyte)BitMath.ToInt32Mask(pleft.I22 < pright.I22);
                p.I23 = (sbyte)BitMath.ToInt32Mask(pleft.I23 < pright.I23);
                p.I24 = (sbyte)BitMath.ToInt32Mask(pleft.I24 < pright.I24);
                p.I25 = (sbyte)BitMath.ToInt32Mask(pleft.I25 < pright.I25);
                p.I26 = (sbyte)BitMath.ToInt32Mask(pleft.I26 < pright.I26);
                p.I27 = (sbyte)BitMath.ToInt32Mask(pleft.I27 < pright.I27);
                p.I28 = (sbyte)BitMath.ToInt32Mask(pleft.I28 < pright.I28);
                p.I29 = (sbyte)BitMath.ToInt32Mask(pleft.I29 < pright.I29);
                p.I30 = (sbyte)BitMath.ToInt32Mask(pleft.I30 < pright.I30);
                p.I31 = (sbyte)BitMath.ToInt32Mask(pleft.I31 < pright.I31);
                p.I32 = (sbyte)BitMath.ToInt32Mask(pleft.I32 < pright.I32);
                p.I33 = (sbyte)BitMath.ToInt32Mask(pleft.I33 < pright.I33);
                p.I34 = (sbyte)BitMath.ToInt32Mask(pleft.I34 < pright.I34);
                p.I35 = (sbyte)BitMath.ToInt32Mask(pleft.I35 < pright.I35);
                p.I36 = (sbyte)BitMath.ToInt32Mask(pleft.I36 < pright.I36);
                p.I37 = (sbyte)BitMath.ToInt32Mask(pleft.I37 < pright.I37);
                p.I38 = (sbyte)BitMath.ToInt32Mask(pleft.I38 < pright.I38);
                p.I39 = (sbyte)BitMath.ToInt32Mask(pleft.I39 < pright.I39);
                p.I40 = (sbyte)BitMath.ToInt32Mask(pleft.I40 < pright.I40);
                p.I41 = (sbyte)BitMath.ToInt32Mask(pleft.I41 < pright.I41);
                p.I42 = (sbyte)BitMath.ToInt32Mask(pleft.I42 < pright.I42);
                p.I43 = (sbyte)BitMath.ToInt32Mask(pleft.I43 < pright.I43);
                p.I44 = (sbyte)BitMath.ToInt32Mask(pleft.I44 < pright.I44);
                p.I45 = (sbyte)BitMath.ToInt32Mask(pleft.I45 < pright.I45);
                p.I46 = (sbyte)BitMath.ToInt32Mask(pleft.I46 < pright.I46);
                p.I47 = (sbyte)BitMath.ToInt32Mask(pleft.I47 < pright.I47);
                p.I48 = (sbyte)BitMath.ToInt32Mask(pleft.I48 < pright.I48);
                p.I49 = (sbyte)BitMath.ToInt32Mask(pleft.I49 < pright.I49);
                p.I50 = (sbyte)BitMath.ToInt32Mask(pleft.I50 < pright.I50);
                p.I51 = (sbyte)BitMath.ToInt32Mask(pleft.I51 < pright.I51);
                p.I52 = (sbyte)BitMath.ToInt32Mask(pleft.I52 < pright.I52);
                p.I53 = (sbyte)BitMath.ToInt32Mask(pleft.I53 < pright.I53);
                p.I54 = (sbyte)BitMath.ToInt32Mask(pleft.I54 < pright.I54);
                p.I55 = (sbyte)BitMath.ToInt32Mask(pleft.I55 < pright.I55);
                p.I56 = (sbyte)BitMath.ToInt32Mask(pleft.I56 < pright.I56);
                p.I57 = (sbyte)BitMath.ToInt32Mask(pleft.I57 < pright.I57);
                p.I58 = (sbyte)BitMath.ToInt32Mask(pleft.I58 < pright.I58);
                p.I59 = (sbyte)BitMath.ToInt32Mask(pleft.I59 < pright.I59);
                p.I60 = (sbyte)BitMath.ToInt32Mask(pleft.I60 < pright.I60);
                p.I61 = (sbyte)BitMath.ToInt32Mask(pleft.I61 < pright.I61);
                p.I62 = (sbyte)BitMath.ToInt32Mask(pleft.I62 < pright.I62);
                p.I63 = (sbyte)BitMath.ToInt32Mask(pleft.I63 < pright.I63);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> LessThan_Basic(Vector512<short> left, Vector512<short> right) {
                UnsafeUtil.SkipInit(out Vector512<short> rt);
                ref FixedArray32<short> p = ref Unsafe.As<Vector512<short>, FixedArray32<short>>(ref rt);
                ref FixedArray32<short> pleft = ref Unsafe.As<Vector512<short>, FixedArray32<short>>(ref left);
                ref FixedArray32<short> pright = ref Unsafe.As<Vector512<short>, FixedArray32<short>>(ref right);
                p.I0 = (short)BitMath.ToInt32Mask(pleft.I0 < pright.I0);
                p.I1 = (short)BitMath.ToInt32Mask(pleft.I1 < pright.I1);
                p.I2 = (short)BitMath.ToInt32Mask(pleft.I2 < pright.I2);
                p.I3 = (short)BitMath.ToInt32Mask(pleft.I3 < pright.I3);
                p.I4 = (short)BitMath.ToInt32Mask(pleft.I4 < pright.I4);
                p.I5 = (short)BitMath.ToInt32Mask(pleft.I5 < pright.I5);
                p.I6 = (short)BitMath.ToInt32Mask(pleft.I6 < pright.I6);
                p.I7 = (short)BitMath.ToInt32Mask(pleft.I7 < pright.I7);
                p.I8 = (short)BitMath.ToInt32Mask(pleft.I8 < pright.I8);
                p.I9 = (short)BitMath.ToInt32Mask(pleft.I9 < pright.I9);
                p.I10 = (short)BitMath.ToInt32Mask(pleft.I10 < pright.I10);
                p.I11 = (short)BitMath.ToInt32Mask(pleft.I11 < pright.I11);
                p.I12 = (short)BitMath.ToInt32Mask(pleft.I12 < pright.I12);
                p.I13 = (short)BitMath.ToInt32Mask(pleft.I13 < pright.I13);
                p.I14 = (short)BitMath.ToInt32Mask(pleft.I14 < pright.I14);
                p.I15 = (short)BitMath.ToInt32Mask(pleft.I15 < pright.I15);
                p.I16 = (short)BitMath.ToInt32Mask(pleft.I16 < pright.I16);
                p.I17 = (short)BitMath.ToInt32Mask(pleft.I17 < pright.I17);
                p.I18 = (short)BitMath.ToInt32Mask(pleft.I18 < pright.I18);
                p.I19 = (short)BitMath.ToInt32Mask(pleft.I19 < pright.I19);
                p.I20 = (short)BitMath.ToInt32Mask(pleft.I20 < pright.I20);
                p.I21 = (short)BitMath.ToInt32Mask(pleft.I21 < pright.I21);
                p.I22 = (short)BitMath.ToInt32Mask(pleft.I22 < pright.I22);
                p.I23 = (short)BitMath.ToInt32Mask(pleft.I23 < pright.I23);
                p.I24 = (short)BitMath.ToInt32Mask(pleft.I24 < pright.I24);
                p.I25 = (short)BitMath.ToInt32Mask(pleft.I25 < pright.I25);
                p.I26 = (short)BitMath.ToInt32Mask(pleft.I26 < pright.I26);
                p.I27 = (short)BitMath.ToInt32Mask(pleft.I27 < pright.I27);
                p.I28 = (short)BitMath.ToInt32Mask(pleft.I28 < pright.I28);
                p.I29 = (short)BitMath.ToInt32Mask(pleft.I29 < pright.I29);
                p.I30 = (short)BitMath.ToInt32Mask(pleft.I30 < pright.I30);
                p.I31 = (short)BitMath.ToInt32Mask(pleft.I31 < pright.I31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> LessThan_Basic(Vector512<ushort> left, Vector512<ushort> right) {
                UnsafeUtil.SkipInit(out Vector512<ushort> rt);
                ref FixedArray32<short> p = ref Unsafe.As<Vector512<ushort>, FixedArray32<short>>(ref rt);
                ref FixedArray32<ushort> pleft = ref Unsafe.As<Vector512<ushort>, FixedArray32<ushort>>(ref left);
                ref FixedArray32<ushort> pright = ref Unsafe.As<Vector512<ushort>, FixedArray32<ushort>>(ref right);
                p.I0 = (short)BitMath.ToInt32Mask(pleft.I0 < pright.I0);
                p.I1 = (short)BitMath.ToInt32Mask(pleft.I1 < pright.I1);
                p.I2 = (short)BitMath.ToInt32Mask(pleft.I2 < pright.I2);
                p.I3 = (short)BitMath.ToInt32Mask(pleft.I3 < pright.I3);
                p.I4 = (short)BitMath.ToInt32Mask(pleft.I4 < pright.I4);
                p.I5 = (short)BitMath.ToInt32Mask(pleft.I5 < pright.I5);
                p.I6 = (short)BitMath.ToInt32Mask(pleft.I6 < pright.I6);
                p.I7 = (short)BitMath.ToInt32Mask(pleft.I7 < pright.I7);
                p.I8 = (short)BitMath.ToInt32Mask(pleft.I8 < pright.I8);
                p.I9 = (short)BitMath.ToInt32Mask(pleft.I9 < pright.I9);
                p.I10 = (short)BitMath.ToInt32Mask(pleft.I10 < pright.I10);
                p.I11 = (short)BitMath.ToInt32Mask(pleft.I11 < pright.I11);
                p.I12 = (short)BitMath.ToInt32Mask(pleft.I12 < pright.I12);
                p.I13 = (short)BitMath.ToInt32Mask(pleft.I13 < pright.I13);
                p.I14 = (short)BitMath.ToInt32Mask(pleft.I14 < pright.I14);
                p.I15 = (short)BitMath.ToInt32Mask(pleft.I15 < pright.I15);
                p.I16 = (short)BitMath.ToInt32Mask(pleft.I16 < pright.I16);
                p.I17 = (short)BitMath.ToInt32Mask(pleft.I17 < pright.I17);
                p.I18 = (short)BitMath.ToInt32Mask(pleft.I18 < pright.I18);
                p.I19 = (short)BitMath.ToInt32Mask(pleft.I19 < pright.I19);
                p.I20 = (short)BitMath.ToInt32Mask(pleft.I20 < pright.I20);
                p.I21 = (short)BitMath.ToInt32Mask(pleft.I21 < pright.I21);
                p.I22 = (short)BitMath.ToInt32Mask(pleft.I22 < pright.I22);
                p.I23 = (short)BitMath.ToInt32Mask(pleft.I23 < pright.I23);
                p.I24 = (short)BitMath.ToInt32Mask(pleft.I24 < pright.I24);
                p.I25 = (short)BitMath.ToInt32Mask(pleft.I25 < pright.I25);
                p.I26 = (short)BitMath.ToInt32Mask(pleft.I26 < pright.I26);
                p.I27 = (short)BitMath.ToInt32Mask(pleft.I27 < pright.I27);
                p.I28 = (short)BitMath.ToInt32Mask(pleft.I28 < pright.I28);
                p.I29 = (short)BitMath.ToInt32Mask(pleft.I29 < pright.I29);
                p.I30 = (short)BitMath.ToInt32Mask(pleft.I30 < pright.I30);
                p.I31 = (short)BitMath.ToInt32Mask(pleft.I31 < pright.I31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> LessThan_Basic(Vector512<int> left, Vector512<int> right) {
                UnsafeUtil.SkipInit(out Vector512<int> rt);
                ref FixedArray16<int> p = ref Unsafe.As<Vector512<int>, FixedArray16<int>>(ref rt);
                ref FixedArray16<int> pleft = ref Unsafe.As<Vector512<int>, FixedArray16<int>>(ref left);
                ref FixedArray16<int> pright = ref Unsafe.As<Vector512<int>, FixedArray16<int>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 < pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 < pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 < pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 < pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 < pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 < pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 < pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 < pright.I7);
                p.I8 = BitMath.ToInt32Mask(pleft.I8 < pright.I8);
                p.I9 = BitMath.ToInt32Mask(pleft.I9 < pright.I9);
                p.I10 = BitMath.ToInt32Mask(pleft.I10 < pright.I10);
                p.I11 = BitMath.ToInt32Mask(pleft.I11 < pright.I11);
                p.I12 = BitMath.ToInt32Mask(pleft.I12 < pright.I12);
                p.I13 = BitMath.ToInt32Mask(pleft.I13 < pright.I13);
                p.I14 = BitMath.ToInt32Mask(pleft.I14 < pright.I14);
                p.I15 = BitMath.ToInt32Mask(pleft.I15 < pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> LessThan_Basic(Vector512<uint> left, Vector512<uint> right) {
                UnsafeUtil.SkipInit(out Vector512<uint> rt);
                ref FixedArray16<int> p = ref Unsafe.As<Vector512<uint>, FixedArray16<int>>(ref rt);
                ref FixedArray16<uint> pleft = ref Unsafe.As<Vector512<uint>, FixedArray16<uint>>(ref left);
                ref FixedArray16<uint> pright = ref Unsafe.As<Vector512<uint>, FixedArray16<uint>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 < pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 < pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 < pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 < pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 < pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 < pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 < pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 < pright.I7);
                p.I8 = BitMath.ToInt32Mask(pleft.I8 < pright.I8);
                p.I9 = BitMath.ToInt32Mask(pleft.I9 < pright.I9);
                p.I10 = BitMath.ToInt32Mask(pleft.I10 < pright.I10);
                p.I11 = BitMath.ToInt32Mask(pleft.I11 < pright.I11);
                p.I12 = BitMath.ToInt32Mask(pleft.I12 < pright.I12);
                p.I13 = BitMath.ToInt32Mask(pleft.I13 < pright.I13);
                p.I14 = BitMath.ToInt32Mask(pleft.I14 < pright.I14);
                p.I15 = BitMath.ToInt32Mask(pleft.I15 < pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> LessThan_Basic(Vector512<long> left, Vector512<long> right) {
                UnsafeUtil.SkipInit(out Vector512<long> rt);
                ref FixedArray8<long> p = ref Unsafe.As<Vector512<long>, FixedArray8<long>>(ref rt);
                ref FixedArray8<long> pleft = ref Unsafe.As<Vector512<long>, FixedArray8<long>>(ref left);
                ref FixedArray8<long> pright = ref Unsafe.As<Vector512<long>, FixedArray8<long>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 < pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 < pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 < pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 < pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 < pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 < pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 < pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 < pright.I7);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThan(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> LessThan_Basic(Vector512<ulong> left, Vector512<ulong> right) {
                UnsafeUtil.SkipInit(out Vector512<ulong> rt);
                ref FixedArray8<long> p = ref Unsafe.As<Vector512<ulong>, FixedArray8<long>>(ref rt);
                ref FixedArray8<ulong> pleft = ref Unsafe.As<Vector512<ulong>, FixedArray8<ulong>>(ref left);
                ref FixedArray8<ulong> pright = ref Unsafe.As<Vector512<ulong>, FixedArray8<ulong>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 < pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 < pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 < pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 < pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 < pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 < pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 < pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 < pright.I7);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.LessThanAll_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanAll_AcceleratedTypes {
                get {
                    return LessThan_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector512<float> left, Vector512<float> right) {
                return Vector512.LessThanAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector512<double> left, Vector512<double> right) {
                return Vector512.LessThanAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector512<sbyte> left, Vector512<sbyte> right) {
                return Vector512.LessThanAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector512<byte> left, Vector512<byte> right) {
                return Vector512.LessThanAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector512<short> left, Vector512<short> right) {
                return Vector512.LessThanAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector512<ushort> left, Vector512<ushort> right) {
                return Vector512.LessThanAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector512<int> left, Vector512<int> right) {
                return Vector512.LessThanAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector512<uint> left, Vector512<uint> right) {
                return Vector512.LessThanAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector512<long> left, Vector512<long> right) {
                return Vector512.LessThanAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAll(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector512<ulong> left, Vector512<ulong> right) {
                return Vector512.LessThanAll(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits512.LessThanAny_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanAny_AcceleratedTypes {
                get {
                    return LessThan_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector512<float> left, Vector512<float> right) {
                return Vector512.LessThanAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector512<double> left, Vector512<double> right) {
                return Vector512.LessThanAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector512<sbyte> left, Vector512<sbyte> right) {
                return Vector512.LessThanAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector512<byte> left, Vector512<byte> right) {
                return Vector512.LessThanAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector512<short> left, Vector512<short> right) {
                return Vector512.LessThanAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector512<ushort> left, Vector512<ushort> right) {
                return Vector512.LessThanAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector512<int> left, Vector512<int> right) {
                return Vector512.LessThanAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector512<uint> left, Vector512<uint> right) {
                return Vector512.LessThanAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector512<long> left, Vector512<long> right) {
                return Vector512.LessThanAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanAny(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector512<ulong> left, Vector512<ulong> right) {
                return Vector512.LessThanAny(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanOrEqual_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> LessThanOrEqual(Vector512<float> left, Vector512<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> LessThanOrEqual(Vector512<double> left, Vector512<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> LessThanOrEqual(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> LessThanOrEqual(Vector512<byte> left, Vector512<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> LessThanOrEqual(Vector512<short> left, Vector512<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> LessThanOrEqual(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> LessThanOrEqual(Vector512<int> left, Vector512<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> LessThanOrEqual(Vector512<uint> left, Vector512<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> LessThanOrEqual(Vector512<long> left, Vector512<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> LessThanOrEqual(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.LessThanOrEqual(left, right);
#else
                return LessThanOrEqual_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> LessThanOrEqual_Basic(Vector512<float> left, Vector512<float> right) {
                UnsafeUtil.SkipInit(out Vector512<float> rt);
                ref FixedArray16<int> p = ref Unsafe.As<Vector512<float>, FixedArray16<int>>(ref rt);
                ref FixedArray16<float> pleft = ref Unsafe.As<Vector512<float>, FixedArray16<float>>(ref left);
                ref FixedArray16<float> pright = ref Unsafe.As<Vector512<float>, FixedArray16<float>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 <= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 <= pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 <= pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 <= pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 <= pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 <= pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 <= pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 <= pright.I7);
                p.I8 = BitMath.ToInt32Mask(pleft.I8 <= pright.I8);
                p.I9 = BitMath.ToInt32Mask(pleft.I9 <= pright.I9);
                p.I10 = BitMath.ToInt32Mask(pleft.I10 <= pright.I10);
                p.I11 = BitMath.ToInt32Mask(pleft.I11 <= pright.I11);
                p.I12 = BitMath.ToInt32Mask(pleft.I12 <= pright.I12);
                p.I13 = BitMath.ToInt32Mask(pleft.I13 <= pright.I13);
                p.I14 = BitMath.ToInt32Mask(pleft.I14 <= pright.I14);
                p.I15 = BitMath.ToInt32Mask(pleft.I15 <= pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> LessThanOrEqual_Basic(Vector512<double> left, Vector512<double> right) {
                UnsafeUtil.SkipInit(out Vector512<double> rt);
                ref FixedArray8<long> p = ref Unsafe.As<Vector512<double>, FixedArray8<long>>(ref rt);
                ref FixedArray8<double> pleft = ref Unsafe.As<Vector512<double>, FixedArray8<double>>(ref left);
                ref FixedArray8<double> pright = ref Unsafe.As<Vector512<double>, FixedArray8<double>>(ref right);
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

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> LessThanOrEqual_Basic(Vector512<sbyte> left, Vector512<sbyte> right) {
                UnsafeUtil.SkipInit(out Vector512<sbyte> rt);
                ref FixedArray64<sbyte> p = ref Unsafe.As<Vector512<sbyte>, FixedArray64<sbyte>>(ref rt);
                ref FixedArray64<sbyte> pleft = ref Unsafe.As<Vector512<sbyte>, FixedArray64<sbyte>>(ref left);
                ref FixedArray64<sbyte> pright = ref Unsafe.As<Vector512<sbyte>, FixedArray64<sbyte>>(ref right);
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
                p.I32 = (sbyte)BitMath.ToInt32Mask(pleft.I32 <= pright.I32);
                p.I33 = (sbyte)BitMath.ToInt32Mask(pleft.I33 <= pright.I33);
                p.I34 = (sbyte)BitMath.ToInt32Mask(pleft.I34 <= pright.I34);
                p.I35 = (sbyte)BitMath.ToInt32Mask(pleft.I35 <= pright.I35);
                p.I36 = (sbyte)BitMath.ToInt32Mask(pleft.I36 <= pright.I36);
                p.I37 = (sbyte)BitMath.ToInt32Mask(pleft.I37 <= pright.I37);
                p.I38 = (sbyte)BitMath.ToInt32Mask(pleft.I38 <= pright.I38);
                p.I39 = (sbyte)BitMath.ToInt32Mask(pleft.I39 <= pright.I39);
                p.I40 = (sbyte)BitMath.ToInt32Mask(pleft.I40 <= pright.I40);
                p.I41 = (sbyte)BitMath.ToInt32Mask(pleft.I41 <= pright.I41);
                p.I42 = (sbyte)BitMath.ToInt32Mask(pleft.I42 <= pright.I42);
                p.I43 = (sbyte)BitMath.ToInt32Mask(pleft.I43 <= pright.I43);
                p.I44 = (sbyte)BitMath.ToInt32Mask(pleft.I44 <= pright.I44);
                p.I45 = (sbyte)BitMath.ToInt32Mask(pleft.I45 <= pright.I45);
                p.I46 = (sbyte)BitMath.ToInt32Mask(pleft.I46 <= pright.I46);
                p.I47 = (sbyte)BitMath.ToInt32Mask(pleft.I47 <= pright.I47);
                p.I48 = (sbyte)BitMath.ToInt32Mask(pleft.I48 <= pright.I48);
                p.I49 = (sbyte)BitMath.ToInt32Mask(pleft.I49 <= pright.I49);
                p.I50 = (sbyte)BitMath.ToInt32Mask(pleft.I50 <= pright.I50);
                p.I51 = (sbyte)BitMath.ToInt32Mask(pleft.I51 <= pright.I51);
                p.I52 = (sbyte)BitMath.ToInt32Mask(pleft.I52 <= pright.I52);
                p.I53 = (sbyte)BitMath.ToInt32Mask(pleft.I53 <= pright.I53);
                p.I54 = (sbyte)BitMath.ToInt32Mask(pleft.I54 <= pright.I54);
                p.I55 = (sbyte)BitMath.ToInt32Mask(pleft.I55 <= pright.I55);
                p.I56 = (sbyte)BitMath.ToInt32Mask(pleft.I56 <= pright.I56);
                p.I57 = (sbyte)BitMath.ToInt32Mask(pleft.I57 <= pright.I57);
                p.I58 = (sbyte)BitMath.ToInt32Mask(pleft.I58 <= pright.I58);
                p.I59 = (sbyte)BitMath.ToInt32Mask(pleft.I59 <= pright.I59);
                p.I60 = (sbyte)BitMath.ToInt32Mask(pleft.I60 <= pright.I60);
                p.I61 = (sbyte)BitMath.ToInt32Mask(pleft.I61 <= pright.I61);
                p.I62 = (sbyte)BitMath.ToInt32Mask(pleft.I62 <= pright.I62);
                p.I63 = (sbyte)BitMath.ToInt32Mask(pleft.I63 <= pright.I63);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> LessThanOrEqual_Basic(Vector512<byte> left, Vector512<byte> right) {
                UnsafeUtil.SkipInit(out Vector512<byte> rt);
                ref FixedArray64<sbyte> p = ref Unsafe.As<Vector512<byte>, FixedArray64<sbyte>>(ref rt);
                ref FixedArray64<byte> pleft = ref Unsafe.As<Vector512<byte>, FixedArray64<byte>>(ref left);
                ref FixedArray64<byte> pright = ref Unsafe.As<Vector512<byte>, FixedArray64<byte>>(ref right);
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
                p.I32 = (sbyte)BitMath.ToInt32Mask(pleft.I32 <= pright.I32);
                p.I33 = (sbyte)BitMath.ToInt32Mask(pleft.I33 <= pright.I33);
                p.I34 = (sbyte)BitMath.ToInt32Mask(pleft.I34 <= pright.I34);
                p.I35 = (sbyte)BitMath.ToInt32Mask(pleft.I35 <= pright.I35);
                p.I36 = (sbyte)BitMath.ToInt32Mask(pleft.I36 <= pright.I36);
                p.I37 = (sbyte)BitMath.ToInt32Mask(pleft.I37 <= pright.I37);
                p.I38 = (sbyte)BitMath.ToInt32Mask(pleft.I38 <= pright.I38);
                p.I39 = (sbyte)BitMath.ToInt32Mask(pleft.I39 <= pright.I39);
                p.I40 = (sbyte)BitMath.ToInt32Mask(pleft.I40 <= pright.I40);
                p.I41 = (sbyte)BitMath.ToInt32Mask(pleft.I41 <= pright.I41);
                p.I42 = (sbyte)BitMath.ToInt32Mask(pleft.I42 <= pright.I42);
                p.I43 = (sbyte)BitMath.ToInt32Mask(pleft.I43 <= pright.I43);
                p.I44 = (sbyte)BitMath.ToInt32Mask(pleft.I44 <= pright.I44);
                p.I45 = (sbyte)BitMath.ToInt32Mask(pleft.I45 <= pright.I45);
                p.I46 = (sbyte)BitMath.ToInt32Mask(pleft.I46 <= pright.I46);
                p.I47 = (sbyte)BitMath.ToInt32Mask(pleft.I47 <= pright.I47);
                p.I48 = (sbyte)BitMath.ToInt32Mask(pleft.I48 <= pright.I48);
                p.I49 = (sbyte)BitMath.ToInt32Mask(pleft.I49 <= pright.I49);
                p.I50 = (sbyte)BitMath.ToInt32Mask(pleft.I50 <= pright.I50);
                p.I51 = (sbyte)BitMath.ToInt32Mask(pleft.I51 <= pright.I51);
                p.I52 = (sbyte)BitMath.ToInt32Mask(pleft.I52 <= pright.I52);
                p.I53 = (sbyte)BitMath.ToInt32Mask(pleft.I53 <= pright.I53);
                p.I54 = (sbyte)BitMath.ToInt32Mask(pleft.I54 <= pright.I54);
                p.I55 = (sbyte)BitMath.ToInt32Mask(pleft.I55 <= pright.I55);
                p.I56 = (sbyte)BitMath.ToInt32Mask(pleft.I56 <= pright.I56);
                p.I57 = (sbyte)BitMath.ToInt32Mask(pleft.I57 <= pright.I57);
                p.I58 = (sbyte)BitMath.ToInt32Mask(pleft.I58 <= pright.I58);
                p.I59 = (sbyte)BitMath.ToInt32Mask(pleft.I59 <= pright.I59);
                p.I60 = (sbyte)BitMath.ToInt32Mask(pleft.I60 <= pright.I60);
                p.I61 = (sbyte)BitMath.ToInt32Mask(pleft.I61 <= pright.I61);
                p.I62 = (sbyte)BitMath.ToInt32Mask(pleft.I62 <= pright.I62);
                p.I63 = (sbyte)BitMath.ToInt32Mask(pleft.I63 <= pright.I63);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> LessThanOrEqual_Basic(Vector512<short> left, Vector512<short> right) {
                UnsafeUtil.SkipInit(out Vector512<short> rt);
                ref FixedArray32<short> p = ref Unsafe.As<Vector512<short>, FixedArray32<short>>(ref rt);
                ref FixedArray32<short> pleft = ref Unsafe.As<Vector512<short>, FixedArray32<short>>(ref left);
                ref FixedArray32<short> pright = ref Unsafe.As<Vector512<short>, FixedArray32<short>>(ref right);
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
                p.I16 = (short)BitMath.ToInt32Mask(pleft.I16 <= pright.I16);
                p.I17 = (short)BitMath.ToInt32Mask(pleft.I17 <= pright.I17);
                p.I18 = (short)BitMath.ToInt32Mask(pleft.I18 <= pright.I18);
                p.I19 = (short)BitMath.ToInt32Mask(pleft.I19 <= pright.I19);
                p.I20 = (short)BitMath.ToInt32Mask(pleft.I20 <= pright.I20);
                p.I21 = (short)BitMath.ToInt32Mask(pleft.I21 <= pright.I21);
                p.I22 = (short)BitMath.ToInt32Mask(pleft.I22 <= pright.I22);
                p.I23 = (short)BitMath.ToInt32Mask(pleft.I23 <= pright.I23);
                p.I24 = (short)BitMath.ToInt32Mask(pleft.I24 <= pright.I24);
                p.I25 = (short)BitMath.ToInt32Mask(pleft.I25 <= pright.I25);
                p.I26 = (short)BitMath.ToInt32Mask(pleft.I26 <= pright.I26);
                p.I27 = (short)BitMath.ToInt32Mask(pleft.I27 <= pright.I27);
                p.I28 = (short)BitMath.ToInt32Mask(pleft.I28 <= pright.I28);
                p.I29 = (short)BitMath.ToInt32Mask(pleft.I29 <= pright.I29);
                p.I30 = (short)BitMath.ToInt32Mask(pleft.I30 <= pright.I30);
                p.I31 = (short)BitMath.ToInt32Mask(pleft.I31 <= pright.I31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> LessThanOrEqual_Basic(Vector512<ushort> left, Vector512<ushort> right) {
                UnsafeUtil.SkipInit(out Vector512<ushort> rt);
                ref FixedArray32<short> p = ref Unsafe.As<Vector512<ushort>, FixedArray32<short>>(ref rt);
                ref FixedArray32<ushort> pleft = ref Unsafe.As<Vector512<ushort>, FixedArray32<ushort>>(ref left);
                ref FixedArray32<ushort> pright = ref Unsafe.As<Vector512<ushort>, FixedArray32<ushort>>(ref right);
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
                p.I16 = (short)BitMath.ToInt32Mask(pleft.I16 <= pright.I16);
                p.I17 = (short)BitMath.ToInt32Mask(pleft.I17 <= pright.I17);
                p.I18 = (short)BitMath.ToInt32Mask(pleft.I18 <= pright.I18);
                p.I19 = (short)BitMath.ToInt32Mask(pleft.I19 <= pright.I19);
                p.I20 = (short)BitMath.ToInt32Mask(pleft.I20 <= pright.I20);
                p.I21 = (short)BitMath.ToInt32Mask(pleft.I21 <= pright.I21);
                p.I22 = (short)BitMath.ToInt32Mask(pleft.I22 <= pright.I22);
                p.I23 = (short)BitMath.ToInt32Mask(pleft.I23 <= pright.I23);
                p.I24 = (short)BitMath.ToInt32Mask(pleft.I24 <= pright.I24);
                p.I25 = (short)BitMath.ToInt32Mask(pleft.I25 <= pright.I25);
                p.I26 = (short)BitMath.ToInt32Mask(pleft.I26 <= pright.I26);
                p.I27 = (short)BitMath.ToInt32Mask(pleft.I27 <= pright.I27);
                p.I28 = (short)BitMath.ToInt32Mask(pleft.I28 <= pright.I28);
                p.I29 = (short)BitMath.ToInt32Mask(pleft.I29 <= pright.I29);
                p.I30 = (short)BitMath.ToInt32Mask(pleft.I30 <= pright.I30);
                p.I31 = (short)BitMath.ToInt32Mask(pleft.I31 <= pright.I31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> LessThanOrEqual_Basic(Vector512<int> left, Vector512<int> right) {
                UnsafeUtil.SkipInit(out Vector512<int> rt);
                ref FixedArray16<int> p = ref Unsafe.As<Vector512<int>, FixedArray16<int>>(ref rt);
                ref FixedArray16<int> pleft = ref Unsafe.As<Vector512<int>, FixedArray16<int>>(ref left);
                ref FixedArray16<int> pright = ref Unsafe.As<Vector512<int>, FixedArray16<int>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 <= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 <= pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 <= pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 <= pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 <= pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 <= pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 <= pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 <= pright.I7);
                p.I8 = BitMath.ToInt32Mask(pleft.I8 <= pright.I8);
                p.I9 = BitMath.ToInt32Mask(pleft.I9 <= pright.I9);
                p.I10 = BitMath.ToInt32Mask(pleft.I10 <= pright.I10);
                p.I11 = BitMath.ToInt32Mask(pleft.I11 <= pright.I11);
                p.I12 = BitMath.ToInt32Mask(pleft.I12 <= pright.I12);
                p.I13 = BitMath.ToInt32Mask(pleft.I13 <= pright.I13);
                p.I14 = BitMath.ToInt32Mask(pleft.I14 <= pright.I14);
                p.I15 = BitMath.ToInt32Mask(pleft.I15 <= pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> LessThanOrEqual_Basic(Vector512<uint> left, Vector512<uint> right) {
                UnsafeUtil.SkipInit(out Vector512<uint> rt);
                ref FixedArray16<int> p = ref Unsafe.As<Vector512<uint>, FixedArray16<int>>(ref rt);
                ref FixedArray16<uint> pleft = ref Unsafe.As<Vector512<uint>, FixedArray16<uint>>(ref left);
                ref FixedArray16<uint> pright = ref Unsafe.As<Vector512<uint>, FixedArray16<uint>>(ref right);
                p.I0 = BitMath.ToInt32Mask(pleft.I0 <= pright.I0);
                p.I1 = BitMath.ToInt32Mask(pleft.I1 <= pright.I1);
                p.I2 = BitMath.ToInt32Mask(pleft.I2 <= pright.I2);
                p.I3 = BitMath.ToInt32Mask(pleft.I3 <= pright.I3);
                p.I4 = BitMath.ToInt32Mask(pleft.I4 <= pright.I4);
                p.I5 = BitMath.ToInt32Mask(pleft.I5 <= pright.I5);
                p.I6 = BitMath.ToInt32Mask(pleft.I6 <= pright.I6);
                p.I7 = BitMath.ToInt32Mask(pleft.I7 <= pright.I7);
                p.I8 = BitMath.ToInt32Mask(pleft.I8 <= pright.I8);
                p.I9 = BitMath.ToInt32Mask(pleft.I9 <= pright.I9);
                p.I10 = BitMath.ToInt32Mask(pleft.I10 <= pright.I10);
                p.I11 = BitMath.ToInt32Mask(pleft.I11 <= pright.I11);
                p.I12 = BitMath.ToInt32Mask(pleft.I12 <= pright.I12);
                p.I13 = BitMath.ToInt32Mask(pleft.I13 <= pright.I13);
                p.I14 = BitMath.ToInt32Mask(pleft.I14 <= pright.I14);
                p.I15 = BitMath.ToInt32Mask(pleft.I15 <= pright.I15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> LessThanOrEqual_Basic(Vector512<long> left, Vector512<long> right) {
                UnsafeUtil.SkipInit(out Vector512<long> rt);
                ref FixedArray8<long> p = ref Unsafe.As<Vector512<long>, FixedArray8<long>>(ref rt);
                ref FixedArray8<long> pleft = ref Unsafe.As<Vector512<long>, FixedArray8<long>>(ref left);
                ref FixedArray8<long> pright = ref Unsafe.As<Vector512<long>, FixedArray8<long>>(ref right);
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

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqual(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> LessThanOrEqual_Basic(Vector512<ulong> left, Vector512<ulong> right) {
                UnsafeUtil.SkipInit(out Vector512<ulong> rt);
                ref FixedArray8<long> p = ref Unsafe.As<Vector512<ulong>, FixedArray8<long>>(ref rt);
                ref FixedArray8<ulong> pleft = ref Unsafe.As<Vector512<ulong>, FixedArray8<ulong>>(ref left);
                ref FixedArray8<ulong> pright = ref Unsafe.As<Vector512<ulong>, FixedArray8<ulong>>(ref right);
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


            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanOrEqualAll_AcceleratedTypes {
                get {
                    return LessThanOrEqual_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector512<float> left, Vector512<float> right) {
                return Vector512.LessThanOrEqualAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector512<double> left, Vector512<double> right) {
                return Vector512.LessThanOrEqualAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector512<sbyte> left, Vector512<sbyte> right) {
                return Vector512.LessThanOrEqualAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector512<byte> left, Vector512<byte> right) {
                return Vector512.LessThanOrEqualAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector512<short> left, Vector512<short> right) {
                return Vector512.LessThanOrEqualAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector512<ushort> left, Vector512<ushort> right) {
                return Vector512.LessThanOrEqualAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector512<int> left, Vector512<int> right) {
                return Vector512.LessThanOrEqualAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector512<uint> left, Vector512<uint> right) {
                return Vector512.LessThanOrEqualAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector512<long> left, Vector512<long> right) {
                return Vector512.LessThanOrEqualAll(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAll(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector512<ulong> left, Vector512<ulong> right) {
                return Vector512.LessThanOrEqualAll(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanOrEqualAny_AcceleratedTypes {
                get {
                    return LessThanOrEqual_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector512<float> left, Vector512<float> right) {
                return Vector512.LessThanOrEqualAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector512<double> left, Vector512<double> right) {
                return Vector512.LessThanOrEqualAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector512<sbyte> left, Vector512<sbyte> right) {
                return Vector512.LessThanOrEqualAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector512<byte> left, Vector512<byte> right) {
                return Vector512.LessThanOrEqualAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector512<short> left, Vector512<short> right) {
                return Vector512.LessThanOrEqualAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector512<ushort> left, Vector512<ushort> right) {
                return Vector512.LessThanOrEqualAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector512<int> left, Vector512<int> right) {
                return Vector512.LessThanOrEqualAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector512<uint> left, Vector512<uint> right) {
                return Vector512.LessThanOrEqualAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector512<long> left, Vector512<long> right) {
                return Vector512.LessThanOrEqualAny(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits512.LessThanOrEqualAny(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector512<ulong> left, Vector512<ulong> right) {
                return Vector512.LessThanOrEqualAny(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits512.Max_AcceleratedTypes"/>
            public static TypeCodeFlags Max_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Max(Vector512<float> left, Vector512<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Max(Vector512<double> left, Vector512<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Max(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Max(Vector512<byte> left, Vector512<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Max(Vector512<short> left, Vector512<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Max(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Max(Vector512<int> left, Vector512<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Max(Vector512<uint> left, Vector512<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Max(Vector512<long> left, Vector512<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Max(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Max(left, right);
#else
                return Max_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Max_Conditional(Vector512<float> left, Vector512<float> right) {
                Vector512<float> condition = GreaterThan(left, right);
                Vector512<float> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Max_Conditional(Vector512<double> left, Vector512<double> right) {
                Vector512<double> condition = GreaterThan(left, right);
                Vector512<double> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Max_Conditional(Vector512<sbyte> left, Vector512<sbyte> right) {
                Vector512<sbyte> condition = GreaterThan(left, right);
                Vector512<sbyte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Max_Conditional(Vector512<byte> left, Vector512<byte> right) {
                Vector512<byte> condition = GreaterThan(left, right);
                Vector512<byte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Max_Conditional(Vector512<short> left, Vector512<short> right) {
                Vector512<short> condition = GreaterThan(left, right);
                Vector512<short> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Max_Conditional(Vector512<ushort> left, Vector512<ushort> right) {
                Vector512<ushort> condition = GreaterThan(left, right);
                Vector512<ushort> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Max_Conditional(Vector512<int> left, Vector512<int> right) {
                Vector512<int> condition = GreaterThan(left, right);
                Vector512<int> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Max_Conditional(Vector512<uint> left, Vector512<uint> right) {
                Vector512<uint> condition = GreaterThan(left, right);
                Vector512<uint> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Max_Conditional(Vector512<long> left, Vector512<long> right) {
                Vector512<long> condition = GreaterThan(left, right);
                Vector512<long> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Max(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Max_Conditional(Vector512<ulong> left, Vector512<ulong> right) {
                Vector512<ulong> condition = GreaterThan(left, right);
                Vector512<ulong> rt = ConditionalSelect(condition, left, right);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.Min_AcceleratedTypes"/>
            public static TypeCodeFlags Min_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Min(Vector512<float> left, Vector512<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Min(Vector512<double> left, Vector512<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Min(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Min(Vector512<byte> left, Vector512<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Min(Vector512<short> left, Vector512<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Min(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Min(Vector512<int> left, Vector512<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Min(Vector512<uint> left, Vector512<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Min(Vector512<long> left, Vector512<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Min(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Min(left, right);
#else
                return Min_Conditional(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Min_Conditional(Vector512<float> left, Vector512<float> right) {
                Vector512<float> condition = LessThan(left, right);
                Vector512<float> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Min_Conditional(Vector512<double> left, Vector512<double> right) {
                Vector512<double> condition = LessThan(left, right);
                Vector512<double> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Min_Conditional(Vector512<sbyte> left, Vector512<sbyte> right) {
                Vector512<sbyte> condition = LessThan(left, right);
                Vector512<sbyte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Min_Conditional(Vector512<byte> left, Vector512<byte> right) {
                Vector512<byte> condition = LessThan(left, right);
                Vector512<byte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Min_Conditional(Vector512<short> left, Vector512<short> right) {
                Vector512<short> condition = LessThan(left, right);
                Vector512<short> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Min_Conditional(Vector512<ushort> left, Vector512<ushort> right) {
                Vector512<ushort> condition = LessThan(left, right);
                Vector512<ushort> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Min_Conditional(Vector512<int> left, Vector512<int> right) {
                Vector512<int> condition = LessThan(left, right);
                Vector512<int> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Min_Conditional(Vector512<uint> left, Vector512<uint> right) {
                Vector512<uint> condition = LessThan(left, right);
                Vector512<uint> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Min_Conditional(Vector512<long> left, Vector512<long> right) {
                Vector512<long> condition = LessThan(left, right);
                Vector512<long> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Min(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Min_Conditional(Vector512<ulong> left, Vector512<ulong> right) {
                Vector512<ulong> condition = LessThan(left, right);
                Vector512<ulong> rt = ConditionalSelect(condition, left, right);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.Multiply_AcceleratedTypes"/>
            public static TypeCodeFlags Multiply_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply_FullAcceleratedTypes"/>
            public static TypeCodeFlags Multiply_FullAcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Multiply(Vector512<float> left, Vector512<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Multiply(Vector512<double> left, Vector512<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Multiply(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Multiply(Vector512<byte> left, Vector512<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Multiply(Vector512<short> left, Vector512<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Multiply(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Multiply(Vector512<int> left, Vector512<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Multiply(Vector512<uint> left, Vector512<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Multiply(Vector512<long> left, Vector512<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Multiply(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Multiply(left, right);
#else
                return Multiply_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Multiply_Basic(Vector512<float> left, Vector512<float> right) {
                UnsafeUtil.SkipInit(out Vector512<float> rt);
                ref float prt = ref Unsafe.As<Vector512<float>, float>(ref rt);
                ref float pleft = ref Unsafe.As<Vector512<float>, float>(ref left);
                ref float pright = ref Unsafe.As<Vector512<float>, float>(ref right);
                prt = pleft * pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) * Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) * Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) * Unsafe.Add(ref pright, 3);
                Unsafe.Add(ref prt, 4) = Unsafe.Add(ref pleft, 4) * Unsafe.Add(ref pright, 4);
                Unsafe.Add(ref prt, 5) = Unsafe.Add(ref pleft, 5) * Unsafe.Add(ref pright, 5);
                Unsafe.Add(ref prt, 6) = Unsafe.Add(ref pleft, 6) * Unsafe.Add(ref pright, 6);
                Unsafe.Add(ref prt, 7) = Unsafe.Add(ref pleft, 7) * Unsafe.Add(ref pright, 7);
                Unsafe.Add(ref prt, 8) = Unsafe.Add(ref pleft, 8) * Unsafe.Add(ref pright, 8);
                Unsafe.Add(ref prt, 9) = Unsafe.Add(ref pleft, 9) * Unsafe.Add(ref pright, 9);
                Unsafe.Add(ref prt, 10) = Unsafe.Add(ref pleft, 10) * Unsafe.Add(ref pright, 10);
                Unsafe.Add(ref prt, 11) = Unsafe.Add(ref pleft, 11) * Unsafe.Add(ref pright, 11);
                Unsafe.Add(ref prt, 12) = Unsafe.Add(ref pleft, 12) * Unsafe.Add(ref pright, 12);
                Unsafe.Add(ref prt, 13) = Unsafe.Add(ref pleft, 13) * Unsafe.Add(ref pright, 13);
                Unsafe.Add(ref prt, 14) = Unsafe.Add(ref pleft, 14) * Unsafe.Add(ref pright, 14);
                Unsafe.Add(ref prt, 15) = Unsafe.Add(ref pleft, 15) * Unsafe.Add(ref pright, 15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Multiply_Basic(Vector512<double> left, Vector512<double> right) {
                UnsafeUtil.SkipInit(out Vector512<double> rt);
                ref double prt = ref Unsafe.As<Vector512<double>, double>(ref rt);
                ref double pleft = ref Unsafe.As<Vector512<double>, double>(ref left);
                ref double pright = ref Unsafe.As<Vector512<double>, double>(ref right);
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

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Multiply_Basic(Vector512<sbyte> left, Vector512<sbyte> right) {
                UnsafeUtil.SkipInit(out Vector512<sbyte> rt);
                ref sbyte prt = ref Unsafe.As<Vector512<sbyte>, sbyte>(ref rt);
                ref sbyte pleft = ref Unsafe.As<Vector512<sbyte>, sbyte>(ref left);
                ref sbyte pright = ref Unsafe.As<Vector512<sbyte>, sbyte>(ref right);
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
                Unsafe.Add(ref prt, 32) = (sbyte)(Unsafe.Add(ref pleft, 32) * Unsafe.Add(ref pright, 32));
                Unsafe.Add(ref prt, 33) = (sbyte)(Unsafe.Add(ref pleft, 33) * Unsafe.Add(ref pright, 33));
                Unsafe.Add(ref prt, 34) = (sbyte)(Unsafe.Add(ref pleft, 34) * Unsafe.Add(ref pright, 34));
                Unsafe.Add(ref prt, 35) = (sbyte)(Unsafe.Add(ref pleft, 35) * Unsafe.Add(ref pright, 35));
                Unsafe.Add(ref prt, 36) = (sbyte)(Unsafe.Add(ref pleft, 36) * Unsafe.Add(ref pright, 36));
                Unsafe.Add(ref prt, 37) = (sbyte)(Unsafe.Add(ref pleft, 37) * Unsafe.Add(ref pright, 37));
                Unsafe.Add(ref prt, 38) = (sbyte)(Unsafe.Add(ref pleft, 38) * Unsafe.Add(ref pright, 38));
                Unsafe.Add(ref prt, 39) = (sbyte)(Unsafe.Add(ref pleft, 39) * Unsafe.Add(ref pright, 39));
                Unsafe.Add(ref prt, 40) = (sbyte)(Unsafe.Add(ref pleft, 40) * Unsafe.Add(ref pright, 40));
                Unsafe.Add(ref prt, 41) = (sbyte)(Unsafe.Add(ref pleft, 41) * Unsafe.Add(ref pright, 41));
                Unsafe.Add(ref prt, 42) = (sbyte)(Unsafe.Add(ref pleft, 42) * Unsafe.Add(ref pright, 42));
                Unsafe.Add(ref prt, 43) = (sbyte)(Unsafe.Add(ref pleft, 43) * Unsafe.Add(ref pright, 43));
                Unsafe.Add(ref prt, 44) = (sbyte)(Unsafe.Add(ref pleft, 44) * Unsafe.Add(ref pright, 44));
                Unsafe.Add(ref prt, 45) = (sbyte)(Unsafe.Add(ref pleft, 45) * Unsafe.Add(ref pright, 45));
                Unsafe.Add(ref prt, 46) = (sbyte)(Unsafe.Add(ref pleft, 46) * Unsafe.Add(ref pright, 46));
                Unsafe.Add(ref prt, 47) = (sbyte)(Unsafe.Add(ref pleft, 47) * Unsafe.Add(ref pright, 47));
                Unsafe.Add(ref prt, 48) = (sbyte)(Unsafe.Add(ref pleft, 48) * Unsafe.Add(ref pright, 48));
                Unsafe.Add(ref prt, 49) = (sbyte)(Unsafe.Add(ref pleft, 49) * Unsafe.Add(ref pright, 49));
                Unsafe.Add(ref prt, 50) = (sbyte)(Unsafe.Add(ref pleft, 50) * Unsafe.Add(ref pright, 50));
                Unsafe.Add(ref prt, 51) = (sbyte)(Unsafe.Add(ref pleft, 51) * Unsafe.Add(ref pright, 51));
                Unsafe.Add(ref prt, 52) = (sbyte)(Unsafe.Add(ref pleft, 52) * Unsafe.Add(ref pright, 52));
                Unsafe.Add(ref prt, 53) = (sbyte)(Unsafe.Add(ref pleft, 53) * Unsafe.Add(ref pright, 53));
                Unsafe.Add(ref prt, 54) = (sbyte)(Unsafe.Add(ref pleft, 54) * Unsafe.Add(ref pright, 54));
                Unsafe.Add(ref prt, 55) = (sbyte)(Unsafe.Add(ref pleft, 55) * Unsafe.Add(ref pright, 55));
                Unsafe.Add(ref prt, 56) = (sbyte)(Unsafe.Add(ref pleft, 56) * Unsafe.Add(ref pright, 56));
                Unsafe.Add(ref prt, 57) = (sbyte)(Unsafe.Add(ref pleft, 57) * Unsafe.Add(ref pright, 57));
                Unsafe.Add(ref prt, 58) = (sbyte)(Unsafe.Add(ref pleft, 58) * Unsafe.Add(ref pright, 58));
                Unsafe.Add(ref prt, 59) = (sbyte)(Unsafe.Add(ref pleft, 59) * Unsafe.Add(ref pright, 59));
                Unsafe.Add(ref prt, 60) = (sbyte)(Unsafe.Add(ref pleft, 60) * Unsafe.Add(ref pright, 60));
                Unsafe.Add(ref prt, 61) = (sbyte)(Unsafe.Add(ref pleft, 61) * Unsafe.Add(ref pright, 61));
                Unsafe.Add(ref prt, 62) = (sbyte)(Unsafe.Add(ref pleft, 62) * Unsafe.Add(ref pright, 62));
                Unsafe.Add(ref prt, 63) = (sbyte)(Unsafe.Add(ref pleft, 63) * Unsafe.Add(ref pright, 63));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Multiply_Basic(Vector512<byte> left, Vector512<byte> right) {
                UnsafeUtil.SkipInit(out Vector512<byte> rt);
                ref byte prt = ref Unsafe.As<Vector512<byte>, byte>(ref rt);
                ref byte pleft = ref Unsafe.As<Vector512<byte>, byte>(ref left);
                ref byte pright = ref Unsafe.As<Vector512<byte>, byte>(ref right);
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
                Unsafe.Add(ref prt, 32) = (byte)(Unsafe.Add(ref pleft, 32) * Unsafe.Add(ref pright, 32));
                Unsafe.Add(ref prt, 33) = (byte)(Unsafe.Add(ref pleft, 33) * Unsafe.Add(ref pright, 33));
                Unsafe.Add(ref prt, 34) = (byte)(Unsafe.Add(ref pleft, 34) * Unsafe.Add(ref pright, 34));
                Unsafe.Add(ref prt, 35) = (byte)(Unsafe.Add(ref pleft, 35) * Unsafe.Add(ref pright, 35));
                Unsafe.Add(ref prt, 36) = (byte)(Unsafe.Add(ref pleft, 36) * Unsafe.Add(ref pright, 36));
                Unsafe.Add(ref prt, 37) = (byte)(Unsafe.Add(ref pleft, 37) * Unsafe.Add(ref pright, 37));
                Unsafe.Add(ref prt, 38) = (byte)(Unsafe.Add(ref pleft, 38) * Unsafe.Add(ref pright, 38));
                Unsafe.Add(ref prt, 39) = (byte)(Unsafe.Add(ref pleft, 39) * Unsafe.Add(ref pright, 39));
                Unsafe.Add(ref prt, 40) = (byte)(Unsafe.Add(ref pleft, 40) * Unsafe.Add(ref pright, 40));
                Unsafe.Add(ref prt, 41) = (byte)(Unsafe.Add(ref pleft, 41) * Unsafe.Add(ref pright, 41));
                Unsafe.Add(ref prt, 42) = (byte)(Unsafe.Add(ref pleft, 42) * Unsafe.Add(ref pright, 42));
                Unsafe.Add(ref prt, 43) = (byte)(Unsafe.Add(ref pleft, 43) * Unsafe.Add(ref pright, 43));
                Unsafe.Add(ref prt, 44) = (byte)(Unsafe.Add(ref pleft, 44) * Unsafe.Add(ref pright, 44));
                Unsafe.Add(ref prt, 45) = (byte)(Unsafe.Add(ref pleft, 45) * Unsafe.Add(ref pright, 45));
                Unsafe.Add(ref prt, 46) = (byte)(Unsafe.Add(ref pleft, 46) * Unsafe.Add(ref pright, 46));
                Unsafe.Add(ref prt, 47) = (byte)(Unsafe.Add(ref pleft, 47) * Unsafe.Add(ref pright, 47));
                Unsafe.Add(ref prt, 48) = (byte)(Unsafe.Add(ref pleft, 48) * Unsafe.Add(ref pright, 48));
                Unsafe.Add(ref prt, 49) = (byte)(Unsafe.Add(ref pleft, 49) * Unsafe.Add(ref pright, 49));
                Unsafe.Add(ref prt, 50) = (byte)(Unsafe.Add(ref pleft, 50) * Unsafe.Add(ref pright, 50));
                Unsafe.Add(ref prt, 51) = (byte)(Unsafe.Add(ref pleft, 51) * Unsafe.Add(ref pright, 51));
                Unsafe.Add(ref prt, 52) = (byte)(Unsafe.Add(ref pleft, 52) * Unsafe.Add(ref pright, 52));
                Unsafe.Add(ref prt, 53) = (byte)(Unsafe.Add(ref pleft, 53) * Unsafe.Add(ref pright, 53));
                Unsafe.Add(ref prt, 54) = (byte)(Unsafe.Add(ref pleft, 54) * Unsafe.Add(ref pright, 54));
                Unsafe.Add(ref prt, 55) = (byte)(Unsafe.Add(ref pleft, 55) * Unsafe.Add(ref pright, 55));
                Unsafe.Add(ref prt, 56) = (byte)(Unsafe.Add(ref pleft, 56) * Unsafe.Add(ref pright, 56));
                Unsafe.Add(ref prt, 57) = (byte)(Unsafe.Add(ref pleft, 57) * Unsafe.Add(ref pright, 57));
                Unsafe.Add(ref prt, 58) = (byte)(Unsafe.Add(ref pleft, 58) * Unsafe.Add(ref pright, 58));
                Unsafe.Add(ref prt, 59) = (byte)(Unsafe.Add(ref pleft, 59) * Unsafe.Add(ref pright, 59));
                Unsafe.Add(ref prt, 60) = (byte)(Unsafe.Add(ref pleft, 60) * Unsafe.Add(ref pright, 60));
                Unsafe.Add(ref prt, 61) = (byte)(Unsafe.Add(ref pleft, 61) * Unsafe.Add(ref pright, 61));
                Unsafe.Add(ref prt, 62) = (byte)(Unsafe.Add(ref pleft, 62) * Unsafe.Add(ref pright, 62));
                Unsafe.Add(ref prt, 63) = (byte)(Unsafe.Add(ref pleft, 63) * Unsafe.Add(ref pright, 63));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Multiply_Basic(Vector512<short> left, Vector512<short> right) {
                UnsafeUtil.SkipInit(out Vector512<short> rt);
                ref short prt = ref Unsafe.As<Vector512<short>, short>(ref rt);
                ref short pleft = ref Unsafe.As<Vector512<short>, short>(ref left);
                ref short pright = ref Unsafe.As<Vector512<short>, short>(ref right);
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
                Unsafe.Add(ref prt, 16) = (short)(Unsafe.Add(ref pleft, 16) * Unsafe.Add(ref pright, 16));
                Unsafe.Add(ref prt, 17) = (short)(Unsafe.Add(ref pleft, 17) * Unsafe.Add(ref pright, 17));
                Unsafe.Add(ref prt, 18) = (short)(Unsafe.Add(ref pleft, 18) * Unsafe.Add(ref pright, 18));
                Unsafe.Add(ref prt, 19) = (short)(Unsafe.Add(ref pleft, 19) * Unsafe.Add(ref pright, 19));
                Unsafe.Add(ref prt, 20) = (short)(Unsafe.Add(ref pleft, 20) * Unsafe.Add(ref pright, 20));
                Unsafe.Add(ref prt, 21) = (short)(Unsafe.Add(ref pleft, 21) * Unsafe.Add(ref pright, 21));
                Unsafe.Add(ref prt, 22) = (short)(Unsafe.Add(ref pleft, 22) * Unsafe.Add(ref pright, 22));
                Unsafe.Add(ref prt, 23) = (short)(Unsafe.Add(ref pleft, 23) * Unsafe.Add(ref pright, 23));
                Unsafe.Add(ref prt, 24) = (short)(Unsafe.Add(ref pleft, 24) * Unsafe.Add(ref pright, 24));
                Unsafe.Add(ref prt, 25) = (short)(Unsafe.Add(ref pleft, 25) * Unsafe.Add(ref pright, 25));
                Unsafe.Add(ref prt, 26) = (short)(Unsafe.Add(ref pleft, 26) * Unsafe.Add(ref pright, 26));
                Unsafe.Add(ref prt, 27) = (short)(Unsafe.Add(ref pleft, 27) * Unsafe.Add(ref pright, 27));
                Unsafe.Add(ref prt, 28) = (short)(Unsafe.Add(ref pleft, 28) * Unsafe.Add(ref pright, 28));
                Unsafe.Add(ref prt, 29) = (short)(Unsafe.Add(ref pleft, 29) * Unsafe.Add(ref pright, 29));
                Unsafe.Add(ref prt, 30) = (short)(Unsafe.Add(ref pleft, 30) * Unsafe.Add(ref pright, 30));
                Unsafe.Add(ref prt, 31) = (short)(Unsafe.Add(ref pleft, 31) * Unsafe.Add(ref pright, 31));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Multiply_Basic(Vector512<ushort> left, Vector512<ushort> right) {
                UnsafeUtil.SkipInit(out Vector512<ushort> rt);
                ref ushort prt = ref Unsafe.As<Vector512<ushort>, ushort>(ref rt);
                ref ushort pleft = ref Unsafe.As<Vector512<ushort>, ushort>(ref left);
                ref ushort pright = ref Unsafe.As<Vector512<ushort>, ushort>(ref right);
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
                Unsafe.Add(ref prt, 16) = (ushort)(Unsafe.Add(ref pleft, 16) * Unsafe.Add(ref pright, 16));
                Unsafe.Add(ref prt, 17) = (ushort)(Unsafe.Add(ref pleft, 17) * Unsafe.Add(ref pright, 17));
                Unsafe.Add(ref prt, 18) = (ushort)(Unsafe.Add(ref pleft, 18) * Unsafe.Add(ref pright, 18));
                Unsafe.Add(ref prt, 19) = (ushort)(Unsafe.Add(ref pleft, 19) * Unsafe.Add(ref pright, 19));
                Unsafe.Add(ref prt, 20) = (ushort)(Unsafe.Add(ref pleft, 20) * Unsafe.Add(ref pright, 20));
                Unsafe.Add(ref prt, 21) = (ushort)(Unsafe.Add(ref pleft, 21) * Unsafe.Add(ref pright, 21));
                Unsafe.Add(ref prt, 22) = (ushort)(Unsafe.Add(ref pleft, 22) * Unsafe.Add(ref pright, 22));
                Unsafe.Add(ref prt, 23) = (ushort)(Unsafe.Add(ref pleft, 23) * Unsafe.Add(ref pright, 23));
                Unsafe.Add(ref prt, 24) = (ushort)(Unsafe.Add(ref pleft, 24) * Unsafe.Add(ref pright, 24));
                Unsafe.Add(ref prt, 25) = (ushort)(Unsafe.Add(ref pleft, 25) * Unsafe.Add(ref pright, 25));
                Unsafe.Add(ref prt, 26) = (ushort)(Unsafe.Add(ref pleft, 26) * Unsafe.Add(ref pright, 26));
                Unsafe.Add(ref prt, 27) = (ushort)(Unsafe.Add(ref pleft, 27) * Unsafe.Add(ref pright, 27));
                Unsafe.Add(ref prt, 28) = (ushort)(Unsafe.Add(ref pleft, 28) * Unsafe.Add(ref pright, 28));
                Unsafe.Add(ref prt, 29) = (ushort)(Unsafe.Add(ref pleft, 29) * Unsafe.Add(ref pright, 29));
                Unsafe.Add(ref prt, 30) = (ushort)(Unsafe.Add(ref pleft, 30) * Unsafe.Add(ref pright, 30));
                Unsafe.Add(ref prt, 31) = (ushort)(Unsafe.Add(ref pleft, 31) * Unsafe.Add(ref pright, 31));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Multiply_Basic(Vector512<int> left, Vector512<int> right) {
                UnsafeUtil.SkipInit(out Vector512<int> rt);
                ref int prt = ref Unsafe.As<Vector512<int>, int>(ref rt);
                ref int pleft = ref Unsafe.As<Vector512<int>, int>(ref left);
                ref int pright = ref Unsafe.As<Vector512<int>, int>(ref right);
                prt = pleft * pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) * Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) * Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) * Unsafe.Add(ref pright, 3);
                Unsafe.Add(ref prt, 4) = Unsafe.Add(ref pleft, 4) * Unsafe.Add(ref pright, 4);
                Unsafe.Add(ref prt, 5) = Unsafe.Add(ref pleft, 5) * Unsafe.Add(ref pright, 5);
                Unsafe.Add(ref prt, 6) = Unsafe.Add(ref pleft, 6) * Unsafe.Add(ref pright, 6);
                Unsafe.Add(ref prt, 7) = Unsafe.Add(ref pleft, 7) * Unsafe.Add(ref pright, 7);
                Unsafe.Add(ref prt, 8) = Unsafe.Add(ref pleft, 8) * Unsafe.Add(ref pright, 8);
                Unsafe.Add(ref prt, 9) = Unsafe.Add(ref pleft, 9) * Unsafe.Add(ref pright, 9);
                Unsafe.Add(ref prt, 10) = Unsafe.Add(ref pleft, 10) * Unsafe.Add(ref pright, 10);
                Unsafe.Add(ref prt, 11) = Unsafe.Add(ref pleft, 11) * Unsafe.Add(ref pright, 11);
                Unsafe.Add(ref prt, 12) = Unsafe.Add(ref pleft, 12) * Unsafe.Add(ref pright, 12);
                Unsafe.Add(ref prt, 13) = Unsafe.Add(ref pleft, 13) * Unsafe.Add(ref pright, 13);
                Unsafe.Add(ref prt, 14) = Unsafe.Add(ref pleft, 14) * Unsafe.Add(ref pright, 14);
                Unsafe.Add(ref prt, 15) = Unsafe.Add(ref pleft, 15) * Unsafe.Add(ref pright, 15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Multiply_Basic(Vector512<uint> left, Vector512<uint> right) {
                UnsafeUtil.SkipInit(out Vector512<uint> rt);
                ref uint prt = ref Unsafe.As<Vector512<uint>, uint>(ref rt);
                ref uint pleft = ref Unsafe.As<Vector512<uint>, uint>(ref left);
                ref uint pright = ref Unsafe.As<Vector512<uint>, uint>(ref right);
                prt = pleft * pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) * Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) * Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) * Unsafe.Add(ref pright, 3);
                Unsafe.Add(ref prt, 4) = Unsafe.Add(ref pleft, 4) * Unsafe.Add(ref pright, 4);
                Unsafe.Add(ref prt, 5) = Unsafe.Add(ref pleft, 5) * Unsafe.Add(ref pright, 5);
                Unsafe.Add(ref prt, 6) = Unsafe.Add(ref pleft, 6) * Unsafe.Add(ref pright, 6);
                Unsafe.Add(ref prt, 7) = Unsafe.Add(ref pleft, 7) * Unsafe.Add(ref pright, 7);
                Unsafe.Add(ref prt, 8) = Unsafe.Add(ref pleft, 8) * Unsafe.Add(ref pright, 8);
                Unsafe.Add(ref prt, 9) = Unsafe.Add(ref pleft, 9) * Unsafe.Add(ref pright, 9);
                Unsafe.Add(ref prt, 10) = Unsafe.Add(ref pleft, 10) * Unsafe.Add(ref pright, 10);
                Unsafe.Add(ref prt, 11) = Unsafe.Add(ref pleft, 11) * Unsafe.Add(ref pright, 11);
                Unsafe.Add(ref prt, 12) = Unsafe.Add(ref pleft, 12) * Unsafe.Add(ref pright, 12);
                Unsafe.Add(ref prt, 13) = Unsafe.Add(ref pleft, 13) * Unsafe.Add(ref pright, 13);
                Unsafe.Add(ref prt, 14) = Unsafe.Add(ref pleft, 14) * Unsafe.Add(ref pright, 14);
                Unsafe.Add(ref prt, 15) = Unsafe.Add(ref pleft, 15) * Unsafe.Add(ref pright, 15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Multiply_Basic(Vector512<long> left, Vector512<long> right) {
                UnsafeUtil.SkipInit(out Vector512<long> rt);
                ref long prt = ref Unsafe.As<Vector512<long>, long>(ref rt);
                ref long pleft = ref Unsafe.As<Vector512<long>, long>(ref left);
                ref long pright = ref Unsafe.As<Vector512<long>, long>(ref right);
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

            /// <inheritdoc cref="IWVectorTraits512.Multiply(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Multiply_Basic(Vector512<ulong> left, Vector512<ulong> right) {
                UnsafeUtil.SkipInit(out Vector512<ulong> rt);
                ref ulong prt = ref Unsafe.As<Vector512<ulong>, ulong>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector512<ulong>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector512<ulong>, ulong>(ref right);
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


            /// <inheritdoc cref="IWVectorTraits512.Negate_AcceleratedTypes"/>
            public static TypeCodeFlags Negate_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Negate(Vector512<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Negate(value);
#else
                return Negate_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Negate(Vector512<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Negate(value);
#else
                return Negate_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Negate(Vector512<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Negate(value);
#else
                return Negate_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Negate(Vector512<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Negate(value);
#else
                return Negate_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Negate(Vector512<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Negate(value);
#else
                return Negate_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Negate(Vector512<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Negate(value);
#else
                return Negate_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Negate_Basic(Vector512<float> value) {
                Vector512<float> rt = value;
                ref float p = ref Unsafe.As<Vector512<float>, float>(ref rt);
                p = -p;
                Unsafe.Add(ref p, 1) = -Unsafe.Add(ref p, 1);
                Unsafe.Add(ref p, 2) = -Unsafe.Add(ref p, 2);
                Unsafe.Add(ref p, 3) = -Unsafe.Add(ref p, 3);
                Unsafe.Add(ref p, 4) = -Unsafe.Add(ref p, 4);
                Unsafe.Add(ref p, 5) = -Unsafe.Add(ref p, 5);
                Unsafe.Add(ref p, 6) = -Unsafe.Add(ref p, 6);
                Unsafe.Add(ref p, 7) = -Unsafe.Add(ref p, 7);
                Unsafe.Add(ref p, 8) = -Unsafe.Add(ref p, 8);
                Unsafe.Add(ref p, 9) = -Unsafe.Add(ref p, 9);
                Unsafe.Add(ref p, 10) = -Unsafe.Add(ref p, 10);
                Unsafe.Add(ref p, 11) = -Unsafe.Add(ref p, 11);
                Unsafe.Add(ref p, 12) = -Unsafe.Add(ref p, 12);
                Unsafe.Add(ref p, 13) = -Unsafe.Add(ref p, 13);
                Unsafe.Add(ref p, 14) = -Unsafe.Add(ref p, 14);
                Unsafe.Add(ref p, 15) = -Unsafe.Add(ref p, 15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Negate_Basic(Vector512<double> value) {
                Vector512<double> rt = value;
                ref double p = ref Unsafe.As<Vector512<double>, double>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Negate_Basic(Vector512<sbyte> value) {
                Vector512<sbyte> rt = value;
                ref sbyte p = ref Unsafe.As<Vector512<sbyte>, sbyte>(ref rt);
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
                Unsafe.Add(ref p, 32) = (sbyte)-Unsafe.Add(ref p, 32);
                Unsafe.Add(ref p, 33) = (sbyte)-Unsafe.Add(ref p, 33);
                Unsafe.Add(ref p, 34) = (sbyte)-Unsafe.Add(ref p, 34);
                Unsafe.Add(ref p, 35) = (sbyte)-Unsafe.Add(ref p, 35);
                Unsafe.Add(ref p, 36) = (sbyte)-Unsafe.Add(ref p, 36);
                Unsafe.Add(ref p, 37) = (sbyte)-Unsafe.Add(ref p, 37);
                Unsafe.Add(ref p, 38) = (sbyte)-Unsafe.Add(ref p, 38);
                Unsafe.Add(ref p, 39) = (sbyte)-Unsafe.Add(ref p, 39);
                Unsafe.Add(ref p, 40) = (sbyte)-Unsafe.Add(ref p, 40);
                Unsafe.Add(ref p, 41) = (sbyte)-Unsafe.Add(ref p, 41);
                Unsafe.Add(ref p, 42) = (sbyte)-Unsafe.Add(ref p, 42);
                Unsafe.Add(ref p, 43) = (sbyte)-Unsafe.Add(ref p, 43);
                Unsafe.Add(ref p, 44) = (sbyte)-Unsafe.Add(ref p, 44);
                Unsafe.Add(ref p, 45) = (sbyte)-Unsafe.Add(ref p, 45);
                Unsafe.Add(ref p, 46) = (sbyte)-Unsafe.Add(ref p, 46);
                Unsafe.Add(ref p, 47) = (sbyte)-Unsafe.Add(ref p, 47);
                Unsafe.Add(ref p, 48) = (sbyte)-Unsafe.Add(ref p, 48);
                Unsafe.Add(ref p, 49) = (sbyte)-Unsafe.Add(ref p, 49);
                Unsafe.Add(ref p, 50) = (sbyte)-Unsafe.Add(ref p, 50);
                Unsafe.Add(ref p, 51) = (sbyte)-Unsafe.Add(ref p, 51);
                Unsafe.Add(ref p, 52) = (sbyte)-Unsafe.Add(ref p, 52);
                Unsafe.Add(ref p, 53) = (sbyte)-Unsafe.Add(ref p, 53);
                Unsafe.Add(ref p, 54) = (sbyte)-Unsafe.Add(ref p, 54);
                Unsafe.Add(ref p, 55) = (sbyte)-Unsafe.Add(ref p, 55);
                Unsafe.Add(ref p, 56) = (sbyte)-Unsafe.Add(ref p, 56);
                Unsafe.Add(ref p, 57) = (sbyte)-Unsafe.Add(ref p, 57);
                Unsafe.Add(ref p, 58) = (sbyte)-Unsafe.Add(ref p, 58);
                Unsafe.Add(ref p, 59) = (sbyte)-Unsafe.Add(ref p, 59);
                Unsafe.Add(ref p, 60) = (sbyte)-Unsafe.Add(ref p, 60);
                Unsafe.Add(ref p, 61) = (sbyte)-Unsafe.Add(ref p, 61);
                Unsafe.Add(ref p, 62) = (sbyte)-Unsafe.Add(ref p, 62);
                Unsafe.Add(ref p, 63) = (sbyte)-Unsafe.Add(ref p, 63);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Negate_Basic(Vector512<short> value) {
                Vector512<short> rt = value;
                ref short p = ref Unsafe.As<Vector512<short>, short>(ref rt);
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
                Unsafe.Add(ref p, 16) = (short)-Unsafe.Add(ref p, 16);
                Unsafe.Add(ref p, 17) = (short)-Unsafe.Add(ref p, 17);
                Unsafe.Add(ref p, 18) = (short)-Unsafe.Add(ref p, 18);
                Unsafe.Add(ref p, 19) = (short)-Unsafe.Add(ref p, 19);
                Unsafe.Add(ref p, 20) = (short)-Unsafe.Add(ref p, 20);
                Unsafe.Add(ref p, 21) = (short)-Unsafe.Add(ref p, 21);
                Unsafe.Add(ref p, 22) = (short)-Unsafe.Add(ref p, 22);
                Unsafe.Add(ref p, 23) = (short)-Unsafe.Add(ref p, 23);
                Unsafe.Add(ref p, 24) = (short)-Unsafe.Add(ref p, 24);
                Unsafe.Add(ref p, 25) = (short)-Unsafe.Add(ref p, 25);
                Unsafe.Add(ref p, 26) = (short)-Unsafe.Add(ref p, 26);
                Unsafe.Add(ref p, 27) = (short)-Unsafe.Add(ref p, 27);
                Unsafe.Add(ref p, 28) = (short)-Unsafe.Add(ref p, 28);
                Unsafe.Add(ref p, 29) = (short)-Unsafe.Add(ref p, 29);
                Unsafe.Add(ref p, 30) = (short)-Unsafe.Add(ref p, 30);
                Unsafe.Add(ref p, 31) = (short)-Unsafe.Add(ref p, 31);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Negate_Basic(Vector512<int> value) {
                Vector512<int> rt = value;
                ref int p = ref Unsafe.As<Vector512<int>, int>(ref rt);
                p = -p;
                Unsafe.Add(ref p, 1) = -Unsafe.Add(ref p, 1);
                Unsafe.Add(ref p, 2) = -Unsafe.Add(ref p, 2);
                Unsafe.Add(ref p, 3) = -Unsafe.Add(ref p, 3);
                Unsafe.Add(ref p, 4) = -Unsafe.Add(ref p, 4);
                Unsafe.Add(ref p, 5) = -Unsafe.Add(ref p, 5);
                Unsafe.Add(ref p, 6) = -Unsafe.Add(ref p, 6);
                Unsafe.Add(ref p, 7) = -Unsafe.Add(ref p, 7);
                Unsafe.Add(ref p, 8) = -Unsafe.Add(ref p, 8);
                Unsafe.Add(ref p, 9) = -Unsafe.Add(ref p, 9);
                Unsafe.Add(ref p, 10) = -Unsafe.Add(ref p, 10);
                Unsafe.Add(ref p, 11) = -Unsafe.Add(ref p, 11);
                Unsafe.Add(ref p, 12) = -Unsafe.Add(ref p, 12);
                Unsafe.Add(ref p, 13) = -Unsafe.Add(ref p, 13);
                Unsafe.Add(ref p, 14) = -Unsafe.Add(ref p, 14);
                Unsafe.Add(ref p, 15) = -Unsafe.Add(ref p, 15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Negate(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Negate_Basic(Vector512<long> value) {
                Vector512<long> rt = value;
                ref long p = ref Unsafe.As<Vector512<long>, long>(ref rt);
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


            /// <inheritdoc cref="IWVectorTraits512.OnesComplement_AcceleratedTypes"/>
            public static TypeCodeFlags OnesComplement_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.OnesComplement{T}(Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> OnesComplement<T>(Vector512<T> vector) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.OnesComplement(vector);
                // .NET8 on Avx512: It has hardware-accelerated.
                // -- Single
                //00007FFDAB598611  vpternlogd  zmm0,zmm0,zmmword ptr [rdx],55h  ; 55h: ~c
                //00007FFDAB598618  vmovups     zmmword ptr [rbp-7EB0h],zmm0  
                // -- Double
                //00007FFDAB5986E5  vpternlogq  zmm0,zmm0,zmmword ptr [rdx],55h  
                //00007FFDAB5986EC  vmovups     zmmword ptr [rbp-7F30h],zmm0  
                // -- Byte
                //00007FFDAB5987B9  vpternlogd  zmm0,zmm0,zmm0,0FFh  ; FFh: All 1
                //00007FFDAB5987C0  vpxord      zmm0,zmm0,zmmword ptr [rdx]  
                //00007FFDAB5987C6  vmovups     zmmword ptr [rbp-7FB0h],zmm0  
#else
                return OnesComplement_Basic(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.OnesComplement{T}(Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> OnesComplement_Basic<T>(Vector512<T> vector) where T : struct {
                Vector512<T> rt = vector;
                ref long p = ref Unsafe.As<Vector512<T>, long>(ref rt);
                p = ~p;
                Unsafe.Add(ref p, 1) = ~Unsafe.Add(ref p, 1);
                Unsafe.Add(ref p, 2) = ~Unsafe.Add(ref p, 2);
                Unsafe.Add(ref p, 3) = ~Unsafe.Add(ref p, 3);
                Unsafe.Add(ref p, 4) = ~Unsafe.Add(ref p, 4);
                Unsafe.Add(ref p, 5) = ~Unsafe.Add(ref p, 5);
                Unsafe.Add(ref p, 6) = ~Unsafe.Add(ref p, 6);
                Unsafe.Add(ref p, 7) = ~Unsafe.Add(ref p, 7);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits512.Sqrt_AcceleratedTypes"/>
            public static TypeCodeFlags Sqrt_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single;
#if Sqrt_Float_Used
                        rt |= TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16;
#endif
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Sqrt(Vector512<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Sqrt(value);
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Sqrt(Vector512<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Sqrt(value);
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Sqrt(Vector512<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
#if Sqrt_Float_Used
                    return Sqrt_Float(value);
#else
                    return Vector512.Sqrt(value);
#endif
                } else {
                    return Sqrt_Basic(value);
                }
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Sqrt(Vector512<byte> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
#if Sqrt_Float_Used
                    return Sqrt_Float(value);
#else
                    return Vector512.Sqrt(value);
#endif
                } else {
                    return Sqrt_Basic(value);
                }
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Sqrt(Vector512<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
#if Sqrt_Float_Used
                    return Sqrt_Float(value);
#else
                    return Vector512.Sqrt(value);
#endif
                } else {
                    return Sqrt_Basic(value);
                }
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Sqrt(Vector512<ushort> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
#if Sqrt_Float_Used
                    return Sqrt_Float(value);
#else
                    return Vector512.Sqrt(value);
#endif
                } else {
                    return Sqrt_Basic(value);
                }
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Sqrt(Vector512<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
#if Sqrt_Float_Used
                    return Sqrt_Float(value);
#else
                    return Vector512.Sqrt(value);
#endif
                } else {
                    return Sqrt_Basic(value);
                }
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Sqrt(Vector512<uint> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
#if Sqrt_Float_Used
                    return Sqrt_Float(value);
#else
                    return Vector512.Sqrt(value);
#endif
                } else {
                    return Sqrt_Basic(value);
                }
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Sqrt(Vector512<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
#if Sqrt_Float_Used
                    return Sqrt_Float(value);
#else
                    return Vector512.Sqrt(value);
#endif
                } else {
                    return Sqrt_Basic(value);
                }
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Sqrt(Vector512<ulong> value) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                if (Vector512.IsHardwareAccelerated) {
#if Sqrt_Float_Used
                    return Sqrt_Float(value);
#else
                    return Vector512.Sqrt(value);
#endif
                } else {
                    return Sqrt_Basic(value);
                }
#else
                return Sqrt_Basic(value);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Sqrt_Basic(Vector512<float> value) {
                Vector512<float> rt = value;
                ref FixedArray8<float> p = ref Unsafe.As<Vector512<float>, FixedArray8<float>>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Sqrt_Basic(Vector512<double> value) {
                Vector512<double> rt = value;
                ref FixedArray4<double> p = ref Unsafe.As<Vector512<double>, FixedArray4<double>>(ref rt);
                p.I0 = BitMath.Sqrt(p.I0);
                p.I1 = BitMath.Sqrt(p.I1);
                p.I2 = BitMath.Sqrt(p.I2);
                p.I3 = BitMath.Sqrt(p.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Sqrt_Basic(Vector512<sbyte> value) {
                Vector512<sbyte> rt = value;
                ref FixedArray32<sbyte> p = ref Unsafe.As<Vector512<sbyte>, FixedArray32<sbyte>>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Sqrt_Basic(Vector512<byte> value) {
                Vector512<byte> rt = value;
                ref FixedArray32<byte> p = ref Unsafe.As<Vector512<byte>, FixedArray32<byte>>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Sqrt_Basic(Vector512<short> value) {
                Vector512<short> rt = value;
                ref FixedArray16<short> p = ref Unsafe.As<Vector512<short>, FixedArray16<short>>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Sqrt_Basic(Vector512<ushort> value) {
                Vector512<ushort> rt = value;
                ref FixedArray16<ushort> p = ref Unsafe.As<Vector512<ushort>, FixedArray16<ushort>>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Sqrt_Basic(Vector512<int> value) {
                Vector512<int> rt = value;
                ref FixedArray8<int> p = ref Unsafe.As<Vector512<int>, FixedArray8<int>>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Sqrt_Basic(Vector512<uint> value) {
                Vector512<uint> rt = value;
                ref FixedArray8<uint> p = ref Unsafe.As<Vector512<uint>, FixedArray8<uint>>(ref rt);
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

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Sqrt_Basic(Vector512<long> value) {
                Vector512<long> rt = value;
                ref FixedArray4<long> p = ref Unsafe.As<Vector512<long>, FixedArray4<long>>(ref rt);
                p.I0 = BitMath.Sqrt(p.I0);
                p.I1 = BitMath.Sqrt(p.I1);
                p.I2 = BitMath.Sqrt(p.I2);
                p.I3 = BitMath.Sqrt(p.I3);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Sqrt_Basic(Vector512<ulong> value) {
                Vector512<ulong> rt = value;
                ref FixedArray4<ulong> p = ref Unsafe.As<Vector512<ulong>, FixedArray4<ulong>>(ref rt);
                p.I0 = BitMath.Sqrt(p.I0);
                p.I1 = BitMath.Sqrt(p.I1);
                p.I2 = BitMath.Sqrt(p.I2);
                p.I3 = BitMath.Sqrt(p.I3);
                return rt;
            }

#if VECTOR_HAS_METHOD
            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Sqrt_Float(Vector512<sbyte> value) {
                Vector512<sbyte> mask = GreaterThan(Vector512<sbyte>.Zero, value); // 0>x = x<0.
                Vector512<sbyte> temp = Sqrt_Float(value.AsByte()).AsSByte();
                Vector512<sbyte> rt = AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Sqrt_Float(Vector512<byte> value) {
                // To float
                Widen(value, out Vector512<ushort> t0, out Vector512<ushort> t1);
                Widen(t0, out Vector512<uint> w0, out Vector512<uint> w1);
                Widen(t1, out Vector512<uint> w2, out Vector512<uint> w3);
                Vector512<float> src0 = ConvertToSingle(w0.AsInt32()); // On x86 platforms, Int32 typically has special instructions to speed up, which is faster than UInt32.
                Vector512<float> src1 = ConvertToSingle(w1.AsInt32());
                Vector512<float> src2 = ConvertToSingle(w2.AsInt32());
                Vector512<float> src3 = ConvertToSingle(w3.AsInt32());
                // Body
                Vector512<float> dst0 = Vector512.Sqrt(src0);
                Vector512<float> dst1 = Vector512.Sqrt(src1);
                Vector512<float> dst2 = Vector512.Sqrt(src2);
                Vector512<float> dst3 = Vector512.Sqrt(src3);
                // To int
                w0 = ConvertToInt32(dst0).AsUInt32();
                w1 = ConvertToInt32(dst1).AsUInt32();
                w2 = ConvertToInt32(dst2).AsUInt32();
                w3 = ConvertToInt32(dst3).AsUInt32();
                t0 = Narrow(w0, w1);
                t1 = Narrow(w2, w3);
                Vector512<byte> rt = Narrow(t0, t1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Sqrt_Float(Vector512<short> value) {
                Vector512<short> mask = GreaterThan(Vector512<short>.Zero, value); // 0>x = x<0.
                Vector512<short> temp = Sqrt_Float(value.AsUInt16()).AsInt16();
                Vector512<short> rt = AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Sqrt_Float(Vector512<ushort> value) {
                // To float
                Widen(value, out Vector512<uint> w0, out Vector512<uint> w1);
                Vector512<float> src0 = ConvertToSingle(w0.AsInt32());
                Vector512<float> src1 = ConvertToSingle(w1.AsInt32());
                // Body
                Vector512<float> dst0 = Vector512.Sqrt(src0);
                Vector512<float> dst1 = Vector512.Sqrt(src1);
                // To int
                w0 = ConvertToInt32(dst0).AsUInt32();
                w1 = ConvertToInt32(dst1).AsUInt32();
                Vector512<ushort> rt = Narrow(w0, w1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Sqrt_Float(Vector512<int> value) {
                Vector512<int> mask = GreaterThan(Vector512<int>.Zero, value); // 0>x = x<0.
                Vector512<int> temp = Sqrt_Float(value.AsUInt32()).AsInt32();
                Vector512<int> rt = AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Sqrt_Float(Vector512<uint> value) {
                // To float
                Widen(value, out Vector512<ulong> w0, out Vector512<ulong> w1);
                Vector512<double> src0 = ConvertToDouble_Range52(w0);
                Vector512<double> src1 = ConvertToDouble_Range52(w1);
                // Body
                Vector512<double> dst0 = Vector512.Sqrt(src0);
                Vector512<double> dst1 = Vector512.Sqrt(src1);
                // To int
                w0 = ConvertToUInt64_Range52(dst0);
                w1 = ConvertToUInt64_Range52(dst1);
                Vector512<uint> rt = Narrow(w0, w1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Sqrt_Float(Vector512<long> value) {
                Vector512<long> mask = GreaterThan(Vector512<long>.Zero, value); // 0>x = x<0.
                Vector512<long> temp = Sqrt_Float(value.AsUInt64()).AsInt64();
                Vector512<long> rt = AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Sqrt(Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Sqrt_Float(Vector512<ulong> value) {
                // To float
                Vector512<double> src0 = ConvertToDouble(value);
                // Body
                Vector512<double> dst0 = Vector512.Sqrt(src0);
                // To int
                Vector512<ulong> rt = ConvertToUInt64_Range52(dst0); // `Math.Ceiling(Math.Log2(Math.Sqrt(ulong.MaxValue))) = 32`. It less 52bit.
                return rt;
            }
#endif // VECTOR_HAS_METHOD


            /// <inheritdoc cref="IWVectorTraits512.Subtract_AcceleratedTypes"/>
            public static TypeCodeFlags Subtract_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Subtract(Vector512<float> left, Vector512<float> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Subtract(Vector512<double> left, Vector512<double> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Subtract(Vector512<sbyte> left, Vector512<sbyte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Subtract(Vector512<byte> left, Vector512<byte> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Subtract(Vector512<short> left, Vector512<short> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Subtract(Vector512<ushort> left, Vector512<ushort> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Subtract(Vector512<int> left, Vector512<int> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Subtract(Vector512<uint> left, Vector512<uint> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Subtract(Vector512<long> left, Vector512<long> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Subtract(Vector512<ulong> left, Vector512<ulong> right) {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Subtract(left, right);
#else
                return Subtract_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{float}, Vector512{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<float> Subtract_Basic(Vector512<float> left, Vector512<float> right) {
                UnsafeUtil.SkipInit(out Vector512<float> rt);
                ref float prt = ref Unsafe.As<Vector512<float>, float>(ref rt);
                ref float pleft = ref Unsafe.As<Vector512<float>, float>(ref left);
                ref float pright = ref Unsafe.As<Vector512<float>, float>(ref right);
                prt = pleft - pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) - Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) - Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) - Unsafe.Add(ref pright, 3);
                Unsafe.Add(ref prt, 4) = Unsafe.Add(ref pleft, 4) - Unsafe.Add(ref pright, 4);
                Unsafe.Add(ref prt, 5) = Unsafe.Add(ref pleft, 5) - Unsafe.Add(ref pright, 5);
                Unsafe.Add(ref prt, 6) = Unsafe.Add(ref pleft, 6) - Unsafe.Add(ref pright, 6);
                Unsafe.Add(ref prt, 7) = Unsafe.Add(ref pleft, 7) - Unsafe.Add(ref pright, 7);
                Unsafe.Add(ref prt, 8) = Unsafe.Add(ref pleft, 8) - Unsafe.Add(ref pright, 8);
                Unsafe.Add(ref prt, 9) = Unsafe.Add(ref pleft, 9) - Unsafe.Add(ref pright, 9);
                Unsafe.Add(ref prt, 10) = Unsafe.Add(ref pleft, 10) - Unsafe.Add(ref pright, 10);
                Unsafe.Add(ref prt, 11) = Unsafe.Add(ref pleft, 11) - Unsafe.Add(ref pright, 11);
                Unsafe.Add(ref prt, 12) = Unsafe.Add(ref pleft, 12) - Unsafe.Add(ref pright, 12);
                Unsafe.Add(ref prt, 13) = Unsafe.Add(ref pleft, 13) - Unsafe.Add(ref pright, 13);
                Unsafe.Add(ref prt, 14) = Unsafe.Add(ref pleft, 14) - Unsafe.Add(ref pright, 14);
                Unsafe.Add(ref prt, 15) = Unsafe.Add(ref pleft, 15) - Unsafe.Add(ref pright, 15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{double}, Vector512{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<double> Subtract_Basic(Vector512<double> left, Vector512<double> right) {
                UnsafeUtil.SkipInit(out Vector512<double> rt);
                ref double prt = ref Unsafe.As<Vector512<double>, double>(ref rt);
                ref double pleft = ref Unsafe.As<Vector512<double>, double>(ref left);
                ref double pright = ref Unsafe.As<Vector512<double>, double>(ref right);
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

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{sbyte}, Vector512{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<sbyte> Subtract_Basic(Vector512<sbyte> left, Vector512<sbyte> right) {
                UnsafeUtil.SkipInit(out Vector512<sbyte> rt);
                ref sbyte prt = ref Unsafe.As<Vector512<sbyte>, sbyte>(ref rt);
                ref sbyte pleft = ref Unsafe.As<Vector512<sbyte>, sbyte>(ref left);
                ref sbyte pright = ref Unsafe.As<Vector512<sbyte>, sbyte>(ref right);
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
                Unsafe.Add(ref prt, 32) = (sbyte)(Unsafe.Add(ref pleft, 32) - Unsafe.Add(ref pright, 32));
                Unsafe.Add(ref prt, 33) = (sbyte)(Unsafe.Add(ref pleft, 33) - Unsafe.Add(ref pright, 33));
                Unsafe.Add(ref prt, 34) = (sbyte)(Unsafe.Add(ref pleft, 34) - Unsafe.Add(ref pright, 34));
                Unsafe.Add(ref prt, 35) = (sbyte)(Unsafe.Add(ref pleft, 35) - Unsafe.Add(ref pright, 35));
                Unsafe.Add(ref prt, 36) = (sbyte)(Unsafe.Add(ref pleft, 36) - Unsafe.Add(ref pright, 36));
                Unsafe.Add(ref prt, 37) = (sbyte)(Unsafe.Add(ref pleft, 37) - Unsafe.Add(ref pright, 37));
                Unsafe.Add(ref prt, 38) = (sbyte)(Unsafe.Add(ref pleft, 38) - Unsafe.Add(ref pright, 38));
                Unsafe.Add(ref prt, 39) = (sbyte)(Unsafe.Add(ref pleft, 39) - Unsafe.Add(ref pright, 39));
                Unsafe.Add(ref prt, 40) = (sbyte)(Unsafe.Add(ref pleft, 40) - Unsafe.Add(ref pright, 40));
                Unsafe.Add(ref prt, 41) = (sbyte)(Unsafe.Add(ref pleft, 41) - Unsafe.Add(ref pright, 41));
                Unsafe.Add(ref prt, 42) = (sbyte)(Unsafe.Add(ref pleft, 42) - Unsafe.Add(ref pright, 42));
                Unsafe.Add(ref prt, 43) = (sbyte)(Unsafe.Add(ref pleft, 43) - Unsafe.Add(ref pright, 43));
                Unsafe.Add(ref prt, 44) = (sbyte)(Unsafe.Add(ref pleft, 44) - Unsafe.Add(ref pright, 44));
                Unsafe.Add(ref prt, 45) = (sbyte)(Unsafe.Add(ref pleft, 45) - Unsafe.Add(ref pright, 45));
                Unsafe.Add(ref prt, 46) = (sbyte)(Unsafe.Add(ref pleft, 46) - Unsafe.Add(ref pright, 46));
                Unsafe.Add(ref prt, 47) = (sbyte)(Unsafe.Add(ref pleft, 47) - Unsafe.Add(ref pright, 47));
                Unsafe.Add(ref prt, 48) = (sbyte)(Unsafe.Add(ref pleft, 48) - Unsafe.Add(ref pright, 48));
                Unsafe.Add(ref prt, 49) = (sbyte)(Unsafe.Add(ref pleft, 49) - Unsafe.Add(ref pright, 49));
                Unsafe.Add(ref prt, 50) = (sbyte)(Unsafe.Add(ref pleft, 50) - Unsafe.Add(ref pright, 50));
                Unsafe.Add(ref prt, 51) = (sbyte)(Unsafe.Add(ref pleft, 51) - Unsafe.Add(ref pright, 51));
                Unsafe.Add(ref prt, 52) = (sbyte)(Unsafe.Add(ref pleft, 52) - Unsafe.Add(ref pright, 52));
                Unsafe.Add(ref prt, 53) = (sbyte)(Unsafe.Add(ref pleft, 53) - Unsafe.Add(ref pright, 53));
                Unsafe.Add(ref prt, 54) = (sbyte)(Unsafe.Add(ref pleft, 54) - Unsafe.Add(ref pright, 54));
                Unsafe.Add(ref prt, 55) = (sbyte)(Unsafe.Add(ref pleft, 55) - Unsafe.Add(ref pright, 55));
                Unsafe.Add(ref prt, 56) = (sbyte)(Unsafe.Add(ref pleft, 56) - Unsafe.Add(ref pright, 56));
                Unsafe.Add(ref prt, 57) = (sbyte)(Unsafe.Add(ref pleft, 57) - Unsafe.Add(ref pright, 57));
                Unsafe.Add(ref prt, 58) = (sbyte)(Unsafe.Add(ref pleft, 58) - Unsafe.Add(ref pright, 58));
                Unsafe.Add(ref prt, 59) = (sbyte)(Unsafe.Add(ref pleft, 59) - Unsafe.Add(ref pright, 59));
                Unsafe.Add(ref prt, 60) = (sbyte)(Unsafe.Add(ref pleft, 60) - Unsafe.Add(ref pright, 60));
                Unsafe.Add(ref prt, 61) = (sbyte)(Unsafe.Add(ref pleft, 61) - Unsafe.Add(ref pright, 61));
                Unsafe.Add(ref prt, 62) = (sbyte)(Unsafe.Add(ref pleft, 62) - Unsafe.Add(ref pright, 62));
                Unsafe.Add(ref prt, 63) = (sbyte)(Unsafe.Add(ref pleft, 63) - Unsafe.Add(ref pright, 63));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{byte}, Vector512{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<byte> Subtract_Basic(Vector512<byte> left, Vector512<byte> right) {
                UnsafeUtil.SkipInit(out Vector512<byte> rt);
                ref byte prt = ref Unsafe.As<Vector512<byte>, byte>(ref rt);
                ref byte pleft = ref Unsafe.As<Vector512<byte>, byte>(ref left);
                ref byte pright = ref Unsafe.As<Vector512<byte>, byte>(ref right);
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
                Unsafe.Add(ref prt, 32) = (byte)(Unsafe.Add(ref pleft, 32) - Unsafe.Add(ref pright, 32));
                Unsafe.Add(ref prt, 33) = (byte)(Unsafe.Add(ref pleft, 33) - Unsafe.Add(ref pright, 33));
                Unsafe.Add(ref prt, 34) = (byte)(Unsafe.Add(ref pleft, 34) - Unsafe.Add(ref pright, 34));
                Unsafe.Add(ref prt, 35) = (byte)(Unsafe.Add(ref pleft, 35) - Unsafe.Add(ref pright, 35));
                Unsafe.Add(ref prt, 36) = (byte)(Unsafe.Add(ref pleft, 36) - Unsafe.Add(ref pright, 36));
                Unsafe.Add(ref prt, 37) = (byte)(Unsafe.Add(ref pleft, 37) - Unsafe.Add(ref pright, 37));
                Unsafe.Add(ref prt, 38) = (byte)(Unsafe.Add(ref pleft, 38) - Unsafe.Add(ref pright, 38));
                Unsafe.Add(ref prt, 39) = (byte)(Unsafe.Add(ref pleft, 39) - Unsafe.Add(ref pright, 39));
                Unsafe.Add(ref prt, 40) = (byte)(Unsafe.Add(ref pleft, 40) - Unsafe.Add(ref pright, 40));
                Unsafe.Add(ref prt, 41) = (byte)(Unsafe.Add(ref pleft, 41) - Unsafe.Add(ref pright, 41));
                Unsafe.Add(ref prt, 42) = (byte)(Unsafe.Add(ref pleft, 42) - Unsafe.Add(ref pright, 42));
                Unsafe.Add(ref prt, 43) = (byte)(Unsafe.Add(ref pleft, 43) - Unsafe.Add(ref pright, 43));
                Unsafe.Add(ref prt, 44) = (byte)(Unsafe.Add(ref pleft, 44) - Unsafe.Add(ref pright, 44));
                Unsafe.Add(ref prt, 45) = (byte)(Unsafe.Add(ref pleft, 45) - Unsafe.Add(ref pright, 45));
                Unsafe.Add(ref prt, 46) = (byte)(Unsafe.Add(ref pleft, 46) - Unsafe.Add(ref pright, 46));
                Unsafe.Add(ref prt, 47) = (byte)(Unsafe.Add(ref pleft, 47) - Unsafe.Add(ref pright, 47));
                Unsafe.Add(ref prt, 48) = (byte)(Unsafe.Add(ref pleft, 48) - Unsafe.Add(ref pright, 48));
                Unsafe.Add(ref prt, 49) = (byte)(Unsafe.Add(ref pleft, 49) - Unsafe.Add(ref pright, 49));
                Unsafe.Add(ref prt, 50) = (byte)(Unsafe.Add(ref pleft, 50) - Unsafe.Add(ref pright, 50));
                Unsafe.Add(ref prt, 51) = (byte)(Unsafe.Add(ref pleft, 51) - Unsafe.Add(ref pright, 51));
                Unsafe.Add(ref prt, 52) = (byte)(Unsafe.Add(ref pleft, 52) - Unsafe.Add(ref pright, 52));
                Unsafe.Add(ref prt, 53) = (byte)(Unsafe.Add(ref pleft, 53) - Unsafe.Add(ref pright, 53));
                Unsafe.Add(ref prt, 54) = (byte)(Unsafe.Add(ref pleft, 54) - Unsafe.Add(ref pright, 54));
                Unsafe.Add(ref prt, 55) = (byte)(Unsafe.Add(ref pleft, 55) - Unsafe.Add(ref pright, 55));
                Unsafe.Add(ref prt, 56) = (byte)(Unsafe.Add(ref pleft, 56) - Unsafe.Add(ref pright, 56));
                Unsafe.Add(ref prt, 57) = (byte)(Unsafe.Add(ref pleft, 57) - Unsafe.Add(ref pright, 57));
                Unsafe.Add(ref prt, 58) = (byte)(Unsafe.Add(ref pleft, 58) - Unsafe.Add(ref pright, 58));
                Unsafe.Add(ref prt, 59) = (byte)(Unsafe.Add(ref pleft, 59) - Unsafe.Add(ref pright, 59));
                Unsafe.Add(ref prt, 60) = (byte)(Unsafe.Add(ref pleft, 60) - Unsafe.Add(ref pright, 60));
                Unsafe.Add(ref prt, 61) = (byte)(Unsafe.Add(ref pleft, 61) - Unsafe.Add(ref pright, 61));
                Unsafe.Add(ref prt, 62) = (byte)(Unsafe.Add(ref pleft, 62) - Unsafe.Add(ref pright, 62));
                Unsafe.Add(ref prt, 63) = (byte)(Unsafe.Add(ref pleft, 63) - Unsafe.Add(ref pright, 63));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{short}, Vector512{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<short> Subtract_Basic(Vector512<short> left, Vector512<short> right) {
                UnsafeUtil.SkipInit(out Vector512<short> rt);
                ref short prt = ref Unsafe.As<Vector512<short>, short>(ref rt);
                ref short pleft = ref Unsafe.As<Vector512<short>, short>(ref left);
                ref short pright = ref Unsafe.As<Vector512<short>, short>(ref right);
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
                Unsafe.Add(ref prt, 16) = (short)(Unsafe.Add(ref pleft, 16) - Unsafe.Add(ref pright, 16));
                Unsafe.Add(ref prt, 17) = (short)(Unsafe.Add(ref pleft, 17) - Unsafe.Add(ref pright, 17));
                Unsafe.Add(ref prt, 18) = (short)(Unsafe.Add(ref pleft, 18) - Unsafe.Add(ref pright, 18));
                Unsafe.Add(ref prt, 19) = (short)(Unsafe.Add(ref pleft, 19) - Unsafe.Add(ref pright, 19));
                Unsafe.Add(ref prt, 20) = (short)(Unsafe.Add(ref pleft, 20) - Unsafe.Add(ref pright, 20));
                Unsafe.Add(ref prt, 21) = (short)(Unsafe.Add(ref pleft, 21) - Unsafe.Add(ref pright, 21));
                Unsafe.Add(ref prt, 22) = (short)(Unsafe.Add(ref pleft, 22) - Unsafe.Add(ref pright, 22));
                Unsafe.Add(ref prt, 23) = (short)(Unsafe.Add(ref pleft, 23) - Unsafe.Add(ref pright, 23));
                Unsafe.Add(ref prt, 24) = (short)(Unsafe.Add(ref pleft, 24) - Unsafe.Add(ref pright, 24));
                Unsafe.Add(ref prt, 25) = (short)(Unsafe.Add(ref pleft, 25) - Unsafe.Add(ref pright, 25));
                Unsafe.Add(ref prt, 26) = (short)(Unsafe.Add(ref pleft, 26) - Unsafe.Add(ref pright, 26));
                Unsafe.Add(ref prt, 27) = (short)(Unsafe.Add(ref pleft, 27) - Unsafe.Add(ref pright, 27));
                Unsafe.Add(ref prt, 28) = (short)(Unsafe.Add(ref pleft, 28) - Unsafe.Add(ref pright, 28));
                Unsafe.Add(ref prt, 29) = (short)(Unsafe.Add(ref pleft, 29) - Unsafe.Add(ref pright, 29));
                Unsafe.Add(ref prt, 30) = (short)(Unsafe.Add(ref pleft, 30) - Unsafe.Add(ref pright, 30));
                Unsafe.Add(ref prt, 31) = (short)(Unsafe.Add(ref pleft, 31) - Unsafe.Add(ref pright, 31));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{ushort}, Vector512{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ushort> Subtract_Basic(Vector512<ushort> left, Vector512<ushort> right) {
                UnsafeUtil.SkipInit(out Vector512<ushort> rt);
                ref ushort prt = ref Unsafe.As<Vector512<ushort>, ushort>(ref rt);
                ref ushort pleft = ref Unsafe.As<Vector512<ushort>, ushort>(ref left);
                ref ushort pright = ref Unsafe.As<Vector512<ushort>, ushort>(ref right);
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
                Unsafe.Add(ref prt, 16) = (ushort)(Unsafe.Add(ref pleft, 16) - Unsafe.Add(ref pright, 16));
                Unsafe.Add(ref prt, 17) = (ushort)(Unsafe.Add(ref pleft, 17) - Unsafe.Add(ref pright, 17));
                Unsafe.Add(ref prt, 18) = (ushort)(Unsafe.Add(ref pleft, 18) - Unsafe.Add(ref pright, 18));
                Unsafe.Add(ref prt, 19) = (ushort)(Unsafe.Add(ref pleft, 19) - Unsafe.Add(ref pright, 19));
                Unsafe.Add(ref prt, 20) = (ushort)(Unsafe.Add(ref pleft, 20) - Unsafe.Add(ref pright, 20));
                Unsafe.Add(ref prt, 21) = (ushort)(Unsafe.Add(ref pleft, 21) - Unsafe.Add(ref pright, 21));
                Unsafe.Add(ref prt, 22) = (ushort)(Unsafe.Add(ref pleft, 22) - Unsafe.Add(ref pright, 22));
                Unsafe.Add(ref prt, 23) = (ushort)(Unsafe.Add(ref pleft, 23) - Unsafe.Add(ref pright, 23));
                Unsafe.Add(ref prt, 24) = (ushort)(Unsafe.Add(ref pleft, 24) - Unsafe.Add(ref pright, 24));
                Unsafe.Add(ref prt, 25) = (ushort)(Unsafe.Add(ref pleft, 25) - Unsafe.Add(ref pright, 25));
                Unsafe.Add(ref prt, 26) = (ushort)(Unsafe.Add(ref pleft, 26) - Unsafe.Add(ref pright, 26));
                Unsafe.Add(ref prt, 27) = (ushort)(Unsafe.Add(ref pleft, 27) - Unsafe.Add(ref pright, 27));
                Unsafe.Add(ref prt, 28) = (ushort)(Unsafe.Add(ref pleft, 28) - Unsafe.Add(ref pright, 28));
                Unsafe.Add(ref prt, 29) = (ushort)(Unsafe.Add(ref pleft, 29) - Unsafe.Add(ref pright, 29));
                Unsafe.Add(ref prt, 30) = (ushort)(Unsafe.Add(ref pleft, 30) - Unsafe.Add(ref pright, 30));
                Unsafe.Add(ref prt, 31) = (ushort)(Unsafe.Add(ref pleft, 31) - Unsafe.Add(ref pright, 31));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{int}, Vector512{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<int> Subtract_Basic(Vector512<int> left, Vector512<int> right) {
                UnsafeUtil.SkipInit(out Vector512<int> rt);
                ref int prt = ref Unsafe.As<Vector512<int>, int>(ref rt);
                ref int pleft = ref Unsafe.As<Vector512<int>, int>(ref left);
                ref int pright = ref Unsafe.As<Vector512<int>, int>(ref right);
                prt = pleft - pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) - Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) - Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) - Unsafe.Add(ref pright, 3);
                Unsafe.Add(ref prt, 4) = Unsafe.Add(ref pleft, 4) - Unsafe.Add(ref pright, 4);
                Unsafe.Add(ref prt, 5) = Unsafe.Add(ref pleft, 5) - Unsafe.Add(ref pright, 5);
                Unsafe.Add(ref prt, 6) = Unsafe.Add(ref pleft, 6) - Unsafe.Add(ref pright, 6);
                Unsafe.Add(ref prt, 7) = Unsafe.Add(ref pleft, 7) - Unsafe.Add(ref pright, 7);
                Unsafe.Add(ref prt, 8) = Unsafe.Add(ref pleft, 8) - Unsafe.Add(ref pright, 8);
                Unsafe.Add(ref prt, 9) = Unsafe.Add(ref pleft, 9) - Unsafe.Add(ref pright, 9);
                Unsafe.Add(ref prt, 10) = Unsafe.Add(ref pleft, 10) - Unsafe.Add(ref pright, 10);
                Unsafe.Add(ref prt, 11) = Unsafe.Add(ref pleft, 11) - Unsafe.Add(ref pright, 11);
                Unsafe.Add(ref prt, 12) = Unsafe.Add(ref pleft, 12) - Unsafe.Add(ref pright, 12);
                Unsafe.Add(ref prt, 13) = Unsafe.Add(ref pleft, 13) - Unsafe.Add(ref pright, 13);
                Unsafe.Add(ref prt, 14) = Unsafe.Add(ref pleft, 14) - Unsafe.Add(ref pright, 14);
                Unsafe.Add(ref prt, 15) = Unsafe.Add(ref pleft, 15) - Unsafe.Add(ref pright, 15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{uint}, Vector512{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<uint> Subtract_Basic(Vector512<uint> left, Vector512<uint> right) {
                UnsafeUtil.SkipInit(out Vector512<uint> rt);
                ref uint prt = ref Unsafe.As<Vector512<uint>, uint>(ref rt);
                ref uint pleft = ref Unsafe.As<Vector512<uint>, uint>(ref left);
                ref uint pright = ref Unsafe.As<Vector512<uint>, uint>(ref right);
                prt = pleft - pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) - Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) - Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) - Unsafe.Add(ref pright, 3);
                Unsafe.Add(ref prt, 4) = Unsafe.Add(ref pleft, 4) - Unsafe.Add(ref pright, 4);
                Unsafe.Add(ref prt, 5) = Unsafe.Add(ref pleft, 5) - Unsafe.Add(ref pright, 5);
                Unsafe.Add(ref prt, 6) = Unsafe.Add(ref pleft, 6) - Unsafe.Add(ref pright, 6);
                Unsafe.Add(ref prt, 7) = Unsafe.Add(ref pleft, 7) - Unsafe.Add(ref pright, 7);
                Unsafe.Add(ref prt, 8) = Unsafe.Add(ref pleft, 8) - Unsafe.Add(ref pright, 8);
                Unsafe.Add(ref prt, 9) = Unsafe.Add(ref pleft, 9) - Unsafe.Add(ref pright, 9);
                Unsafe.Add(ref prt, 10) = Unsafe.Add(ref pleft, 10) - Unsafe.Add(ref pright, 10);
                Unsafe.Add(ref prt, 11) = Unsafe.Add(ref pleft, 11) - Unsafe.Add(ref pright, 11);
                Unsafe.Add(ref prt, 12) = Unsafe.Add(ref pleft, 12) - Unsafe.Add(ref pright, 12);
                Unsafe.Add(ref prt, 13) = Unsafe.Add(ref pleft, 13) - Unsafe.Add(ref pright, 13);
                Unsafe.Add(ref prt, 14) = Unsafe.Add(ref pleft, 14) - Unsafe.Add(ref pright, 14);
                Unsafe.Add(ref prt, 15) = Unsafe.Add(ref pleft, 15) - Unsafe.Add(ref pright, 15);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{long}, Vector512{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<long> Subtract_Basic(Vector512<long> left, Vector512<long> right) {
                UnsafeUtil.SkipInit(out Vector512<long> rt);
                ref long prt = ref Unsafe.As<Vector512<long>, long>(ref rt);
                ref long pleft = ref Unsafe.As<Vector512<long>, long>(ref left);
                ref long pright = ref Unsafe.As<Vector512<long>, long>(ref right);
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

            /// <inheritdoc cref="IWVectorTraits512.Subtract(Vector512{ulong}, Vector512{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<ulong> Subtract_Basic(Vector512<ulong> left, Vector512<ulong> right) {
                UnsafeUtil.SkipInit(out Vector512<ulong> rt);
                ref ulong prt = ref Unsafe.As<Vector512<ulong>, ulong>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector512<ulong>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector512<ulong>, ulong>(ref right);
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


            /// <inheritdoc cref="IWVectorTraits512.Xor_AcceleratedTypes"/>
            public static TypeCodeFlags Xor_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    if (Vector512.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits512.Xor{T}(Vector512{T}, Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> Xor<T>(Vector512<T> left, Vector512<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
                return Vector512.Xor(left, right);
#else
                return Xor_Basic(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && VECTOR_HAS_METHOD
            }

            /// <inheritdoc cref="IWVectorTraits512.Xor{T}(Vector512{T}, Vector512{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector512<T> Xor_Basic<T>(Vector512<T> left, Vector512<T> right) where T : struct {
                UnsafeUtil.SkipInit(out Vector512<T> rt);
                ref ulong prt = ref Unsafe.As<Vector512<T>, ulong>(ref rt);
                ref ulong pleft = ref Unsafe.As<Vector512<T>, ulong>(ref left);
                ref ulong pright = ref Unsafe.As<Vector512<T>, ulong>(ref right);
                prt = pleft ^ pright;
                Unsafe.Add(ref prt, 1) = Unsafe.Add(ref pleft, 1) ^ Unsafe.Add(ref pright, 1);
                Unsafe.Add(ref prt, 2) = Unsafe.Add(ref pleft, 2) ^ Unsafe.Add(ref pright, 2);
                Unsafe.Add(ref prt, 3) = Unsafe.Add(ref pleft, 3) ^ Unsafe.Add(ref pright, 3);
                Unsafe.Add(ref prt, 4) = Unsafe.Add(ref pleft, 4) ^ Unsafe.Add(ref pright, 4);
                Unsafe.Add(ref prt, 5) = Unsafe.Add(ref pleft, 5) ^ Unsafe.Add(ref pright, 5);
                Unsafe.Add(ref prt, 6) = Unsafe.Add(ref pleft, 6) ^ Unsafe.Add(ref pright, 6);
                Unsafe.Add(ref prt, 7) = Unsafe.Add(ref pleft, 7) ^ Unsafe.Add(ref pright, 7);
                return rt;
            }


#endif // NET8_0_OR_GREATER
        }
    }
}
