using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using Zyl.VectorTraits.Impl.Util;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl.AVector256 {
    partial class WVectorTraits256Base {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits256.YClamp_AcceleratedTypes"/>
            public static TypeCodeFlags YClamp_AcceleratedTypes {
                get {
                    return Max_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{float}, Vector256{float}, Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YClamp(Vector256<float> value, Vector256<float> amin, Vector256<float> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{double}, Vector256{double}, Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YClamp(Vector256<double> value, Vector256<double> amin, Vector256<double> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YClamp(Vector256<sbyte> value, Vector256<sbyte> amin, Vector256<sbyte> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YClamp(Vector256<byte> value, Vector256<byte> amin, Vector256<byte> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{short}, Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YClamp(Vector256<short> value, Vector256<short> amin, Vector256<short> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YClamp(Vector256<ushort> value, Vector256<ushort> amin, Vector256<ushort> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{int}, Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YClamp(Vector256<int> value, Vector256<int> amin, Vector256<int> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YClamp(Vector256<uint> value, Vector256<uint> amin, Vector256<uint> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{long}, Vector256{long}, Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> YClamp(Vector256<long> value, Vector256<long> amin, Vector256<long> amax) {
                return Min(Max(amin, value), amax);
            }

            /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> YClamp(Vector256<ulong> value, Vector256<ulong> amin, Vector256<ulong> amax) {
                return Min(Max(amin, value), amax);
            }


            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate_AcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (Narrow_AcceleratedTypes & YClamp_AcceleratedTypes)
                        & (TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate_FullAcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
                get {
                    return TypeCodeFlags.None;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{short}, Vector256{short})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> YNarrowSaturate(Vector256<short> lower, Vector256<short> upper) {
                //Vector256<short> amin = Vector256s<short>.VMinSByte;
                //Vector256<short> amax = Vector256s<short>.VMaxSByte;
                Vector256<short> amin = Vector256.Create((short)sbyte.MinValue); // .NET5+ has better performance .
                Vector256<short> amax = Vector256.Create((short)sbyte.MaxValue);
                Vector256<short> l = YClamp(lower, amin, amax);
                Vector256<short> u = YClamp(upper, amin, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{ushort}, Vector256{ushort})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YNarrowSaturate(Vector256<ushort> lower, Vector256<ushort> upper) {
                // Vector256<ushort> amax = Vector256s<ushort>.VMaxByte;
                Vector256<ushort> amax = Vector256.Create((ushort)byte.MaxValue); // .NET5+ has better performance .
                Vector256<ushort> l = Min(lower, amax);
                Vector256<ushort> u = Min(upper, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{int}, Vector256{int})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> YNarrowSaturate(Vector256<int> lower, Vector256<int> upper) {
                //Vector256<int> amin = Vector256s<int>.VMinInt16;
                //Vector256<int> amax = Vector256s<int>.VMaxInt16;
                Vector256<int> amin = Vector256.Create((int)short.MinValue); // .NET5+ has better performance .
                Vector256<int> amax = Vector256.Create((int)short.MaxValue);
                Vector256<int> l = YClamp(lower, amin, amax);
                Vector256<int> u = YClamp(upper, amin, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{uint}, Vector256{uint})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YNarrowSaturate(Vector256<uint> lower, Vector256<uint> upper) {
                //Vector256<uint> amax = Vector256s<uint>.VMaxUInt16;
                Vector256<uint> amax = Vector256.Create((uint)ushort.MaxValue); // .NET5+ has better performance .
                Vector256<uint> l = Min(lower, amax);
                Vector256<uint> u = Min(upper, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{long}, Vector256{long})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> YNarrowSaturate(Vector256<long> lower, Vector256<long> upper) {
                //Vector256<long> amin = Vector256s<long>.VMinInt32;
                //Vector256<long> amax = Vector256s<long>.VMaxInt32;
                Vector256<long> amin = Vector256Constants.Int64_VMinInt32;
                Vector256<long> amax = Vector256Constants.Int64_VMaxInt32;
                Vector256<long> l = YClamp(lower, amin, amax);
                Vector256<long> u = YClamp(upper, amin, amax);
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{ulong}, Vector256{ulong})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YNarrowSaturate(Vector256<ulong> lower, Vector256<ulong> upper) {
                //Vector256<ulong> amax = Vector256s<ulong>.VMaxUInt32;
                Vector256<ulong> amax = Vector256Constants.Int64_VMaxUInt32.AsUInt64();
                Vector256<ulong> l = Min(lower, amax);
                Vector256<ulong> u = Min(upper, amax);
                return Narrow(l, u);
            }


            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned_AcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = (Narrow_AcceleratedTypes & YClamp_AcceleratedTypes)
                        & (TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64);
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
            public static TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
                get {
                    return TypeCodeFlags.None;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned(Vector256{short}, Vector256{short})" />
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> YNarrowSaturateUnsigned(Vector256<short> lower, Vector256<short> upper) {
                Vector256<short> amin = Vector256<short>.Zero;
                //Vector256<short> amax = Vector256s<short>.VMaxByte;
                Vector256<short> amax = Vector256.Create((short)byte.MaxValue); // .NET5+ has better performance .
                Vector256<ushort> l = YClamp(lower, amin, amax).AsUInt16();
                Vector256<ushort> u = YClamp(upper, amin, amax).AsUInt16();
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned(Vector256{int}, Vector256{int})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> YNarrowSaturateUnsigned(Vector256<int> lower, Vector256<int> upper) {
                Vector256<int> amin = Vector256<int>.Zero;
                //Vector256<int> amax = Vector256s<int>.VMaxUInt16;
                Vector256<int> amax = Vector256.Create((int)ushort.MaxValue); // .NET5+ has better performance .
                Vector256<uint> l = YClamp(lower, amin, amax).AsUInt32();
                Vector256<uint> u = YClamp(upper, amin, amax).AsUInt32();
                return Narrow(l, u);
            }

            /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned(Vector256{long}, Vector256{long})" />
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> YNarrowSaturateUnsigned(Vector256<long> lower, Vector256<long> upper) {
                Vector256<long> amin = Vector256<long>.Zero;
                //Vector256<long> amax = Vector256s<long>.VMaxUInt32;
                Vector256<long> amax = Vector256Constants.Int64_VMaxUInt32;
                Vector256<ulong> l = YClamp(lower, amin, amax).AsUInt64();
                Vector256<ulong> u = YClamp(upper, amin, amax).AsUInt64();
                return Narrow(l, u);
            }


            /// <inheritdoc cref="IWVectorTraits256.YRoundToEven_AcceleratedTypes"/>
            public static TypeCodeFlags YRoundToEven_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YRoundToEven(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YRoundToEven(Vector256<float> value) {
#if NET7_0_OR_GREATER
                return YRoundToEven_Add(value);
#else
                return YRoundToEven_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YRoundToEven(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YRoundToEven(Vector256<double> value) {
#if NET7_0_OR_GREATER
                return YRoundToEven_Add(value);
#else
                return YRoundToEven_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YRoundToEven(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YRoundToEven_Basic(Vector256<float> value) {
                Vector256<float> rt = value;
                ref float p = ref Unsafe.As<Vector256<float>, float>(ref rt);
                p = MathF.Round(p);
                Unsafe.Add(ref p, 1) = MathF.Round(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = MathF.Round(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = MathF.Round(Unsafe.Add(ref p, 3));
                Unsafe.Add(ref p, 4) = MathF.Round(Unsafe.Add(ref p, 4));
                Unsafe.Add(ref p, 5) = MathF.Round(Unsafe.Add(ref p, 5));
                Unsafe.Add(ref p, 6) = MathF.Round(Unsafe.Add(ref p, 6));
                Unsafe.Add(ref p, 7) = MathF.Round(Unsafe.Add(ref p, 7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YRoundToEven(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YRoundToEven_Basic(Vector256<double> value) {
                Vector256<double> rt = value;
                ref double p = ref Unsafe.As<Vector256<double>, double>(ref rt);
                p = Math.Round(p);
                Unsafe.Add(ref p, 1) = Math.Round(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = Math.Round(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = Math.Round(Unsafe.Add(ref p, 3));
                return rt;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YRoundToEven(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YRoundToEven_Add(Vector256<float> value) {
                // if (0<=x && x<pow(2,23)), `round_to_even(x) = x + pow(2,23) - pow(2,23)`. Next generalize this approach to all number ranges.
                Vector256<float> delta = Vector256.Create(ScalarConstants.SingleVal_2Pow23);
                Vector256<float> signMask = Vector256Constants.Single_SignMask;
                Vector256<float> valueAbs = Vector256.AndNot(value, signMask);
                Vector256<float> signData = Vector256.BitwiseAnd(value, signMask);
                Vector256<float> allowMask = Vector256.LessThan(valueAbs, delta); // Allow is `(value[i] < pow(2,23) )`.
                delta = Vector256.BitwiseOr(delta, signData);
                delta = Vector256.BitwiseAnd(delta, allowMask);
                Vector256<float> rt = Vector256.Add(value, delta);
                rt = Vector256.Subtract(rt, delta);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YRoundToEven(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YRoundToEven_Add(Vector256<double> value) {
                // if (0<=x && x<pow(2,52)), `round_to_even(x) = x + pow(2,52) - pow(2,52)`. Next generalize this approach to all number ranges.
                Vector256<double> delta = Vector256.Create(ScalarConstants.DoubleVal_2Pow52);
                Vector256<double> signMask = Vector256Constants.Double_SignMask;
                Vector256<double> valueAbs = Vector256.AndNot(value, signMask);
                Vector256<double> signData = Vector256.BitwiseAnd(value, signMask);
                Vector256<double> allowMask = Vector256.LessThan(valueAbs, delta); // Allow is `(value[i] < pow(2,52) )`.
                delta = Vector256.BitwiseOr(delta, signData);
                delta = Vector256.BitwiseAnd(delta, allowMask);
                Vector256<double> rt = Vector256.Add(value, delta);
                rt = Vector256.Subtract(rt, delta);
                return rt;
            }
#endif // NET7_0_OR_GREATER


            /// <inheritdoc cref="IWVectorTraits256.YRoundToZero_AcceleratedTypes"/>
            public static TypeCodeFlags YRoundToZero_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if NET7_0_OR_GREATER
                    rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
#endif // NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.YRoundToZero(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YRoundToZero(Vector256<float> value) {
#if NET7_0_OR_GREATER
                return YRoundToZero_Floor(value);
#else
                return YRoundToZero_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YRoundToZero(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YRoundToZero(Vector256<double> value) {
#if NET7_0_OR_GREATER
                return YRoundToZero_Floor(value);
#else
                return YRoundToZero_Basic(value);
#endif // NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.YRoundToZero(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YRoundToZero_Basic(Vector256<float> value) {
                Vector256<float> rt = value;
                ref float p = ref Unsafe.As<Vector256<float>, float>(ref rt);
                p = MathF.Truncate(p);
                Unsafe.Add(ref p, 1) = MathF.Truncate(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = MathF.Truncate(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = MathF.Truncate(Unsafe.Add(ref p, 3));
                Unsafe.Add(ref p, 4) = MathF.Truncate(Unsafe.Add(ref p, 4));
                Unsafe.Add(ref p, 5) = MathF.Truncate(Unsafe.Add(ref p, 5));
                Unsafe.Add(ref p, 6) = MathF.Truncate(Unsafe.Add(ref p, 6));
                Unsafe.Add(ref p, 7) = MathF.Truncate(Unsafe.Add(ref p, 7));
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YRoundToZero(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YRoundToZero_Basic(Vector256<double> value) {
                Vector256<double> rt = value;
                ref double p = ref Unsafe.As<Vector256<double>, double>(ref rt);
                p = Math.Truncate(p);
                Unsafe.Add(ref p, 1) = Math.Truncate(Unsafe.Add(ref p, 1));
                Unsafe.Add(ref p, 2) = Math.Truncate(Unsafe.Add(ref p, 2));
                Unsafe.Add(ref p, 3) = Math.Truncate(Unsafe.Add(ref p, 3));
                return rt;
            }

#if NET7_0_OR_GREATER
            /// <inheritdoc cref="IWVectorTraits256.YRoundToZero(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> YRoundToZero_Floor(Vector256<float> value) {
                Vector256<float> signMask = Vector256Constants.Single_SignMask;
                Vector256<float> valueAbs = Vector256.AndNot(value, signMask);
                Vector256<float> signData = Vector256.BitwiseAnd(value, signMask);
                Vector256<float> rt = Vector256.Floor(valueAbs);
                rt = Vector256.BitwiseOr(rt, signData);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.YRoundToZero(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> YRoundToZero_Floor(Vector256<double> value) {
                Vector256<double> signMask = Vector256Constants.Double_SignMask;
                Vector256<double> valueAbs = Vector256.AndNot(value, signMask);
                Vector256<double> signData = Vector256.BitwiseAnd(value, signMask);
                Vector256<double> rt = Vector256.Floor(valueAbs);
                rt = Vector256.BitwiseOr(rt, signData);
                return rt;
            }
#endif // NET7_0_OR_GREATER


#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
