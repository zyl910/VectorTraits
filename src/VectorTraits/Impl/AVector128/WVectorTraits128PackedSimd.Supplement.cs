using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
#if NET8_0_OR_GREATER
using System.Runtime.Intrinsics.Wasm;
#endif // NET8_0_OR_GREATER

namespace Zyl.VectorTraits.Impl.AVector128 {
    using SuperStatics = WVectorTraits128Base.Statics;

    partial class WVectorTraits128PackedSimd {

        partial class Statics {

#if NET8_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.Abs_AcceleratedTypes"/>
            public static TypeCodeFlags Abs_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Abs(Vector128<float> value) {
                return PackedSimd.Abs(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Abs(Vector128<double> value) {
                return PackedSimd.Abs(value);
                //var mask = Vector128Constants.Double_SignMask;
                //return PackedSimd.AndNot(value, mask);
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Abs(Vector128<sbyte> value) {
                // return PackedSimd.Abs(value); // System.OverflowException : Negating the minimum value of a twos complement number is invalid.
                Vector128<sbyte> mask = PackedSimd.CompareGreaterThan(Vector128<sbyte>.Zero, value); // 0>value => value<0
                Vector128<sbyte> rt = PackedSimd.Subtract(PackedSimd.Xor(value, mask), mask); // -x => (~x)+1 => (~x)-(-1) = (x^mask)-mask .
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Abs(Vector128<short> value) {
                // return PackedSimd.Abs(value); // System.OverflowException : Negating the minimum value of a twos complement number is invalid.
                Vector128<short> mask = PackedSimd.ShiftRightArithmetic(value, 15); // value[i] < 0
                Vector128<short> rt = PackedSimd.Subtract(PackedSimd.Xor(value, mask), mask); // -x => (~x)+1 => (~x)-(-1) = (x^mask)-mask .
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Abs(Vector128<int> value) {
                // return PackedSimd.Abs(value); // System.OverflowException : Negating the minimum value of a twos complement number is invalid.
                Vector128<int> mask = PackedSimd.ShiftRightArithmetic(value, 31); // value[i] < 0
                Vector128<int> rt = PackedSimd.Subtract(PackedSimd.Xor(value, mask), mask); // -x => (~x)+1 => (~x)-(-1) = (x^mask)-mask .
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Abs(Vector128<long> value) {
                // return PackedSimd.Abs(value); // System.OverflowException : Negating the minimum value of a twos complement number is invalid.
                // If an integer value is positive or zero, no action is required. Otherwise complement and add 1.
                //Vector128<long> mask = PackedSimd.CompareGreaterThan(Vector128<long>.Zero, value); // 0>value => value<0
                Vector128<long> mask = PackedSimd.ShiftRightArithmetic(value, 63); // value[i] < 0
                Vector128<long> rt = PackedSimd.Subtract(PackedSimd.Xor(value, mask), mask); // -x => (~x)+1 => (~x)-(-1) = (x^mask)-mask .
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Add_AcceleratedTypes"/>
            public static TypeCodeFlags Add_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Add(Vector128<float> left, Vector128<float> right) {
                return PackedSimd.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Add(Vector128<double> left, Vector128<double> right) {
                return PackedSimd.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Add(Vector128<sbyte> left, Vector128<sbyte> right) {
                return PackedSimd.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Add(Vector128<byte> left, Vector128<byte> right) {
                return PackedSimd.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Add(Vector128<short> left, Vector128<short> right) {
                return PackedSimd.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Add(Vector128<ushort> left, Vector128<ushort> right) {
                return PackedSimd.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Add(Vector128<int> left, Vector128<int> right) {
                return PackedSimd.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Add(Vector128<uint> left, Vector128<uint> right) {
                return PackedSimd.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Add(Vector128<long> left, Vector128<long> right) {
                return PackedSimd.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Add(Vector128<ulong> left, Vector128<ulong> right) {
                return PackedSimd.Add(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits128.AndNot_AcceleratedTypes"/>
            public static TypeCodeFlags AndNot_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.AndNot{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> AndNot<T>(Vector128<T> left, Vector128<T> right) where T : struct {
                return Vector128.AndNot(left, right);
                //return PackedSimd.AndNot(left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
            }


            /// <inheritdoc cref="IWVectorTraits128.BitwiseAnd_AcceleratedTypes"/>
            public static TypeCodeFlags BitwiseAnd_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.BitwiseAnd{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> BitwiseAnd<T>(Vector128<T> left, Vector128<T> right) where T : struct {
                return Vector128.BitwiseAnd(left, right);
                //return PackedSimd.And(left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
            }


            /// <inheritdoc cref="IWVectorTraits128.BitwiseOr_AcceleratedTypes"/>
            public static TypeCodeFlags BitwiseOr_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.BitwiseOr{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> BitwiseOr<T>(Vector128<T> left, Vector128<T> right) where T : struct {
                return Vector128.BitwiseOr(left, right);
                //return PackedSimd.Or(left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
            }


            /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect_AcceleratedTypes"/>
            public static TypeCodeFlags ConditionalSelect_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect{T}(Vector128{T}, Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> ConditionalSelect<T>(Vector128<T> condition, Vector128<T> left, Vector128<T> right) where T : struct {
#if BCL_OVERRIDE_BASE_FIXED && NET8_0_OR_GREATER
                return Vector128.ConditionalSelect(condition, left, right);
#else
                return ConditionalSelect_Hw(condition, left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET8_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect{T}(Vector128{T}, Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> ConditionalSelect_OrAnd<T>(Vector128<T> condition, Vector128<T> left, Vector128<T> right) where T : struct {
                // result = (left & condition) | (right & ~condition);
                return PackedSimd.Or(PackedSimd.And(condition.AsUInt64(), left.AsUInt64())
                    , PackedSimd.And(PackedSimd.Not(condition.AsUInt64()), right.AsUInt64())
                    ).As<ulong, T>();
            }

            /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect{T}(Vector128{T}, Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> ConditionalSelect_Hw<T>(Vector128<T> condition, Vector128<T> left, Vector128<T> right) where T : struct {
                return PackedSimd.BitwiseSelect(condition.AsUInt64(), left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
            }


            /// <inheritdoc cref="IWVectorTraits128.Divide_AcceleratedTypes"/>
            public static TypeCodeFlags Divide_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single | TypeCodeFlags.Double;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Divide(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Divide(Vector128<float> left, Vector128<float> right) {
                return PackedSimd.Divide(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Divide(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Divide(Vector128<double> left, Vector128<double> right) {
                return PackedSimd.Divide(left, right);
            }



            /// <inheritdoc cref="IWVectorTraits128.Dot_AcceleratedTypes"/>
            public static TypeCodeFlags Dot_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Dot(Vector128<float> left, Vector128<float> right) {
                Vector128<float> temp = PackedSimd.Multiply(left, right);
                return Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Dot(Vector128<double> left, Vector128<double> right) {
                //return SuperStatics.Dot(left, right);
                Vector128<double> temp = PackedSimd.Multiply(left, right);
                return Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Dot(Vector128<sbyte> left, Vector128<sbyte> right) {
                Vector128<short> u0, u1, v0, v1;
                (u0, u1) = Vector128.Widen(left);
                (v0, v1) = Vector128.Widen(right);
                Vector128<short> w0 = PackedSimd.Multiply(u0, v0);
                Vector128<short> w1 = PackedSimd.Multiply(u1, v1);
                w0 = PackedSimd.Add(w0, w1);
                return (sbyte)Sum(w0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Dot(Vector128<byte> left, Vector128<byte> right) {
                Vector128<ushort> u0, u1, v0, v1;
                (u0, u1) = Vector128.Widen(left);
                (v0, v1) = Vector128.Widen(right);
                Vector128<ushort> w0 = PackedSimd.Multiply(u0, v0);
                Vector128<ushort> w1 = PackedSimd.Multiply(u1, v1);
                w0 = PackedSimd.Add(w0, w1);
                return (byte)Sum(w0);
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Dot(Vector128<short> left, Vector128<short> right) {
                Vector128<short> temp = PackedSimd.Multiply(left, right);
                return Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Dot(Vector128<ushort> left, Vector128<ushort> right) {
                Vector128<ushort> temp = PackedSimd.Multiply(left, right);
                return Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Dot(Vector128<int> left, Vector128<int> right) {
                Vector128<int> temp = PackedSimd.Multiply(left, right);
                return Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Dot(Vector128<uint> left, Vector128<uint> right) {
                Vector128<uint> temp = PackedSimd.Multiply(left, right);
                return Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Dot(Vector128<long> left, Vector128<long> right) {
                //return SuperStatics.Dot(left, right);
                Vector128<long> temp = Multiply(left, right);
                return Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Dot(Vector128<ulong> left, Vector128<ulong> right) {
                //return SuperStatics.Dot(left, right);
                Vector128<ulong> temp = Multiply(left, right);
                return Sum(temp);
            }


            /// <inheritdoc cref="IWVectorTraits128.Equals_AcceleratedTypes"/>
            public static TypeCodeFlags Equals_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Equals(Vector128<float> left, Vector128<float> right) {
                return PackedSimd.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Equals(Vector128<double> left, Vector128<double> right) {
                return PackedSimd.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Equals(Vector128<sbyte> left, Vector128<sbyte> right) {
                return PackedSimd.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Equals(Vector128<byte> left, Vector128<byte> right) {
                return PackedSimd.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Equals(Vector128<short> left, Vector128<short> right) {
                return PackedSimd.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Equals(Vector128<ushort> left, Vector128<ushort> right) {
                return PackedSimd.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Equals(Vector128<int> left, Vector128<int> right) {
                return PackedSimd.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Equals(Vector128<uint> left, Vector128<uint> right) {
                return PackedSimd.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Equals(Vector128<long> left, Vector128<long> right) {
                return PackedSimd.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Equals(Vector128<ulong> left, Vector128<ulong> right) {
                return PackedSimd.CompareEqual(left, right);
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
                return Vector128.EqualsAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareEqual(left, right).AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector128<double> left, Vector128<double> right) {
                return Vector128.EqualsAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareEqual(left, right).AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector128<sbyte> left, Vector128<sbyte> right) {
                return Vector128.EqualsAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector128<byte> left, Vector128<byte> right) {
                return Vector128.EqualsAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector128<short> left, Vector128<short> right) {
                return Vector128.EqualsAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector128<ushort> left, Vector128<ushort> right) {
                return Vector128.EqualsAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector128<int> left, Vector128<int> right) {
                return Vector128.EqualsAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector128<uint> left, Vector128<uint> right) {
                return Vector128.EqualsAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector128<long> left, Vector128<long> right) {
                return Vector128.EqualsAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector128<ulong> left, Vector128<ulong> right) {
                return Vector128.EqualsAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareEqual(left, right));
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
                //return Vector128.EqualsAny(left, right);
                return PackedSimd.AnyTrue(PackedSimd.CompareEqual(left, right).AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector128<double> left, Vector128<double> right) {
                return Vector128.EqualsAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareEqual(left, right).AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector128<sbyte> left, Vector128<sbyte> right) {
                return Vector128.EqualsAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector128<byte> left, Vector128<byte> right) {
                return Vector128.EqualsAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector128<short> left, Vector128<short> right) {
                return Vector128.EqualsAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector128<ushort> left, Vector128<ushort> right) {
                return Vector128.EqualsAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector128<int> left, Vector128<int> right) {
                return Vector128.EqualsAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector128<uint> left, Vector128<uint> right) {
                return Vector128.EqualsAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector128<long> left, Vector128<long> right) {
                return Vector128.EqualsAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector128<ulong> left, Vector128<ulong> right) {
                return Vector128.EqualsAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareEqual(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.GreaterThan_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThan_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> GreaterThan(Vector128<float> left, Vector128<float> right) {
                return Vector128.GreaterThan(left, right);
                //return PackedSimd.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> GreaterThan(Vector128<double> left, Vector128<double> right) {
                return Vector128.GreaterThan(left, right);
                //return PackedSimd.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> GreaterThan(Vector128<sbyte> left, Vector128<sbyte> right) {
                return Vector128.GreaterThan(left, right);
                //return PackedSimd.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> GreaterThan(Vector128<byte> left, Vector128<byte> right) {
                return Vector128.GreaterThan(left, right);
                //return PackedSimd.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> GreaterThan(Vector128<short> left, Vector128<short> right) {
                return Vector128.GreaterThan(left, right);
                //return PackedSimd.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> GreaterThan(Vector128<ushort> left, Vector128<ushort> right) {
                return Vector128.GreaterThan(left, right);
                //return PackedSimd.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> GreaterThan(Vector128<int> left, Vector128<int> right) {
                return Vector128.GreaterThan(left, right);
                //return PackedSimd.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> GreaterThan(Vector128<uint> left, Vector128<uint> right) {
                return Vector128.GreaterThan(left, right);
                //return PackedSimd.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> GreaterThan(Vector128<long> left, Vector128<long> right) {
                return Vector128.GreaterThan(left, right);
                //return PackedSimd.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> GreaterThan(Vector128<ulong> left, Vector128<ulong> right) {
                return Vector128.GreaterThan(left, right);
                //return PackedSimd.CompareGreaterThan(left, right);
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
                return Vector128.GreaterThanAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.GreaterThan(left, right).AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector128<double> left, Vector128<double> right) {
                return Vector128.GreaterThanAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.GreaterThan(left, right).AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector128<sbyte> left, Vector128<sbyte> right) {
                return Vector128.GreaterThanAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector128<byte> left, Vector128<byte> right) {
                return Vector128.GreaterThanAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector128<short> left, Vector128<short> right) {
                return Vector128.GreaterThanAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector128<ushort> left, Vector128<ushort> right) {
                return Vector128.GreaterThanAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector128<int> left, Vector128<int> right) {
                return Vector128.GreaterThanAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector128<uint> left, Vector128<uint> right) {
                return Vector128.GreaterThanAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector128<long> left, Vector128<long> right) {
                return Vector128.GreaterThanAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector128<ulong> left, Vector128<ulong> right) {
                return Vector128.GreaterThanAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.GreaterThan(left, right));
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
                return Vector128.GreaterThanAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.GreaterThan(left, right).AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector128<double> left, Vector128<double> right) {
                return Vector128.GreaterThanAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.GreaterThan(left, right).AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector128<sbyte> left, Vector128<sbyte> right) {
                return Vector128.GreaterThanAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector128<byte> left, Vector128<byte> right) {
                return Vector128.GreaterThanAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector128<short> left, Vector128<short> right) {
                return Vector128.GreaterThanAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector128<ushort> left, Vector128<ushort> right) {
                return Vector128.GreaterThanAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector128<int> left, Vector128<int> right) {
                return Vector128.GreaterThanAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector128<uint> left, Vector128<uint> right) {
                return Vector128.GreaterThanAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector128<long> left, Vector128<long> right) {
                return Vector128.GreaterThanAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector128<ulong> left, Vector128<ulong> right) {
                return Vector128.GreaterThanAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.GreaterThan(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanOrEqual_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> GreaterThanOrEqual(Vector128<float> left, Vector128<float> right) {
                return Vector128.GreaterThanOrEqual(left, right);
                //return PackedSimd.CompareGreaterThanOrEqual(left, right);
                //dotnet.native.8.0.4.rkw194kvb3.js:8 MONO interpreter: NIY encountered in method GreaterThanOrEqual
                //logging.ts:119 Error: [MONO] * Assertion: should not be reached at /__w/1/s/src/mono/mono/mini/interp/interp.c:3850
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> GreaterThanOrEqual(Vector128<double> left, Vector128<double> right) {
                return Vector128.GreaterThanOrEqual(left, right);
                //return PackedSimd.CompareGreaterThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> GreaterThanOrEqual(Vector128<sbyte> left, Vector128<sbyte> right) {
                return Vector128.GreaterThanOrEqual(left, right);
                //return PackedSimd.CompareGreaterThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> GreaterThanOrEqual(Vector128<byte> left, Vector128<byte> right) {
                return Vector128.GreaterThanOrEqual(left, right);
                //return PackedSimd.CompareGreaterThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> GreaterThanOrEqual(Vector128<short> left, Vector128<short> right) {
                return Vector128.GreaterThanOrEqual(left, right);
                //return PackedSimd.CompareGreaterThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> GreaterThanOrEqual(Vector128<ushort> left, Vector128<ushort> right) {
                return Vector128.GreaterThanOrEqual(left, right);
                //return PackedSimd.CompareGreaterThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> GreaterThanOrEqual(Vector128<int> left, Vector128<int> right) {
                return Vector128.GreaterThanOrEqual(left, right);
                //return PackedSimd.CompareGreaterThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> GreaterThanOrEqual(Vector128<uint> left, Vector128<uint> right) {
                return Vector128.GreaterThanOrEqual(left, right);
                //return PackedSimd.CompareGreaterThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> GreaterThanOrEqual(Vector128<long> left, Vector128<long> right) {
                return Vector128.GreaterThanOrEqual(left, right);
                //return PackedSimd.CompareGreaterThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> GreaterThanOrEqual(Vector128<ulong> left, Vector128<ulong> right) {
                return Vector128.GreaterThanOrEqual(left, right);
                //return PackedSimd.CompareGreaterThanOrEqual(left, right);
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
                return Vector128.GreaterThanOrEqualAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareGreaterThanOrEqual(left, right).AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector128<double> left, Vector128<double> right) {
                return Vector128.GreaterThanOrEqualAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareGreaterThanOrEqual(left, right).AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector128<sbyte> left, Vector128<sbyte> right) {
                return Vector128.GreaterThanOrEqualAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareGreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector128<byte> left, Vector128<byte> right) {
                return Vector128.GreaterThanOrEqualAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareGreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector128<short> left, Vector128<short> right) {
                return Vector128.GreaterThanOrEqualAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareGreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector128<ushort> left, Vector128<ushort> right) {
                return Vector128.GreaterThanOrEqualAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareGreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector128<int> left, Vector128<int> right) {
                return Vector128.GreaterThanOrEqualAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareGreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector128<uint> left, Vector128<uint> right) {
                return Vector128.GreaterThanOrEqualAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareGreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector128<long> left, Vector128<long> right) {
                return Vector128.GreaterThanOrEqualAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareGreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector128<ulong> left, Vector128<ulong> right) {
                return Vector128.GreaterThanOrEqualAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareGreaterThanOrEqual(left, right));
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
                return Vector128.GreaterThanOrEqualAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareGreaterThanOrEqual(left, right).AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector128<double> left, Vector128<double> right) {
                return Vector128.GreaterThanOrEqualAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareGreaterThanOrEqual(left, right).AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector128<sbyte> left, Vector128<sbyte> right) {
                return Vector128.GreaterThanOrEqualAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareGreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector128<byte> left, Vector128<byte> right) {
                return Vector128.GreaterThanOrEqualAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareGreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector128<short> left, Vector128<short> right) {
                return Vector128.GreaterThanOrEqualAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareGreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector128<ushort> left, Vector128<ushort> right) {
                return Vector128.GreaterThanOrEqualAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareGreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector128<int> left, Vector128<int> right) {
                return Vector128.GreaterThanOrEqualAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareGreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector128<uint> left, Vector128<uint> right) {
                return Vector128.GreaterThanOrEqualAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareGreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector128<long> left, Vector128<long> right) {
                return Vector128.GreaterThanOrEqualAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareGreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector128<ulong> left, Vector128<ulong> right) {
                return Vector128.GreaterThanOrEqualAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareGreaterThanOrEqual(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.LessThan_AcceleratedTypes"/>
            public static TypeCodeFlags LessThan_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> LessThan(Vector128<float> left, Vector128<float> right) {
                return Vector128.LessThan(left, right);
                //return PackedSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> LessThan(Vector128<double> left, Vector128<double> right) {
                return Vector128.LessThan(left, right);
                //return PackedSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> LessThan(Vector128<sbyte> left, Vector128<sbyte> right) {
                return Vector128.LessThan(left, right);
                //return PackedSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> LessThan(Vector128<byte> left, Vector128<byte> right) {
                return Vector128.LessThan(left, right);
                //return PackedSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> LessThan(Vector128<short> left, Vector128<short> right) {
                return Vector128.LessThan(left, right);
                //return PackedSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> LessThan(Vector128<ushort> left, Vector128<ushort> right) {
                return Vector128.LessThan(left, right);
                //return PackedSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> LessThan(Vector128<int> left, Vector128<int> right) {
                return Vector128.LessThan(left, right);
                //return PackedSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> LessThan(Vector128<uint> left, Vector128<uint> right) {
                return Vector128.LessThan(left, right);
                //return PackedSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> LessThan(Vector128<long> left, Vector128<long> right) {
                return Vector128.LessThan(left, right);
                //return PackedSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> LessThan_Half(Vector128<long> left, Vector128<long> right) {
                return Vector128.LessThan(left, right);
                //return PackedSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> LessThan_Scalar(Vector128<long> left, Vector128<long> right) {
                return Vector128.LessThan(left, right);
                //return PackedSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> LessThan(Vector128<ulong> left, Vector128<ulong> right) {
                return Vector128.LessThan(left, right);
                //return PackedSimd.CompareLessThan(left, right);
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
                return Vector128.LessThanAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.LessThan(left, right).AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector128<double> left, Vector128<double> right) {
                return Vector128.LessThanAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.LessThan(left, right).AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector128<sbyte> left, Vector128<sbyte> right) {
                return Vector128.LessThanAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector128<byte> left, Vector128<byte> right) {
                return Vector128.LessThanAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector128<short> left, Vector128<short> right) {
                return Vector128.LessThanAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector128<ushort> left, Vector128<ushort> right) {
                return Vector128.LessThanAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector128<int> left, Vector128<int> right) {
                return Vector128.LessThanAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector128<uint> left, Vector128<uint> right) {
                return Vector128.LessThanAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector128<long> left, Vector128<long> right) {
                return Vector128.LessThanAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector128<ulong> left, Vector128<ulong> right) {
                return Vector128.LessThanAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.LessThan(left, right));
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
                return Vector128.LessThanAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.LessThan(left, right).AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector128<double> left, Vector128<double> right) {
                return Vector128.LessThanAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.LessThan(left, right).AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector128<sbyte> left, Vector128<sbyte> right) {
                return Vector128.LessThanAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector128<byte> left, Vector128<byte> right) {
                return Vector128.LessThanAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector128<short> left, Vector128<short> right) {
                return Vector128.LessThanAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector128<ushort> left, Vector128<ushort> right) {
                return Vector128.LessThanAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector128<int> left, Vector128<int> right) {
                return Vector128.LessThanAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector128<uint> left, Vector128<uint> right) {
                return Vector128.LessThanAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector128<long> left, Vector128<long> right) {
                return Vector128.LessThanAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector128<ulong> left, Vector128<ulong> right) {
                return Vector128.LessThanAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.LessThan(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanOrEqual_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> LessThanOrEqual(Vector128<float> left, Vector128<float> right) {
                return Vector128.LessThanOrEqual(left, right);
                //return PackedSimd.CompareLessThanOrEqual(left, right);
                //dotnet.native.8.0.4.rkw194kvb3.js:8 MONO interpreter: NIY encountered in method LessThanOrEqual
                //logging.ts:119 Error: [MONO] * Assertion: should not be reached at /__w/1/s/src/mono/mono/mini/interp/interp.c:3850
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> LessThanOrEqual(Vector128<double> left, Vector128<double> right) {
                return Vector128.LessThanOrEqual(left, right);
                //return PackedSimd.CompareLessThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> LessThanOrEqual(Vector128<sbyte> left, Vector128<sbyte> right) {
                return Vector128.LessThanOrEqual(left, right);
                //return PackedSimd.CompareLessThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> LessThanOrEqual(Vector128<byte> left, Vector128<byte> right) {
                return Vector128.LessThanOrEqual(left, right);
                //return PackedSimd.CompareLessThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> LessThanOrEqual(Vector128<short> left, Vector128<short> right) {
                return Vector128.LessThanOrEqual(left, right);
                //return PackedSimd.CompareLessThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> LessThanOrEqual(Vector128<ushort> left, Vector128<ushort> right) {
                return Vector128.LessThanOrEqual(left, right);
                //return PackedSimd.CompareLessThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> LessThanOrEqual(Vector128<int> left, Vector128<int> right) {
                return Vector128.LessThanOrEqual(left, right);
                //return PackedSimd.CompareLessThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> LessThanOrEqual(Vector128<uint> left, Vector128<uint> right) {
                return Vector128.LessThanOrEqual(left, right);
                //return PackedSimd.CompareLessThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> LessThanOrEqual(Vector128<long> left, Vector128<long> right) {
                return Vector128.LessThanOrEqual(left, right);
                //return PackedSimd.CompareLessThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> LessThanOrEqual(Vector128<ulong> left, Vector128<ulong> right) {
                return Vector128.LessThanOrEqual(left, right);
                //return PackedSimd.CompareLessThanOrEqual(left, right);
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
                return Vector128.LessThanOrEqualAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareLessThanOrEqual(left, right).AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector128<double> left, Vector128<double> right) {
                return Vector128.LessThanOrEqualAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareLessThanOrEqual(left, right).AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector128<sbyte> left, Vector128<sbyte> right) {
                return Vector128.LessThanOrEqualAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareLessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector128<byte> left, Vector128<byte> right) {
                return Vector128.LessThanOrEqualAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareLessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector128<short> left, Vector128<short> right) {
                return Vector128.LessThanOrEqualAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareLessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector128<ushort> left, Vector128<ushort> right) {
                return Vector128.LessThanOrEqualAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareLessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector128<int> left, Vector128<int> right) {
                return Vector128.LessThanOrEqualAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareLessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector128<uint> left, Vector128<uint> right) {
                return Vector128.LessThanOrEqualAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareLessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector128<long> left, Vector128<long> right) {
                return Vector128.LessThanOrEqualAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareLessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector128<ulong> left, Vector128<ulong> right) {
                return Vector128.LessThanOrEqualAll(left, right);
                // return PackedSimd.AllTrue(PackedSimd.CompareLessThanOrEqual(left, right));
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
                return Vector128.LessThanOrEqualAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareLessThanOrEqual(left, right).AsInt32());
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector128<double> left, Vector128<double> right) {
                return Vector128.LessThanOrEqualAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareLessThanOrEqual(left, right).AsInt64());
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector128<sbyte> left, Vector128<sbyte> right) {
                return Vector128.LessThanOrEqualAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareLessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector128<byte> left, Vector128<byte> right) {
                return Vector128.LessThanOrEqualAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareLessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector128<short> left, Vector128<short> right) {
                return Vector128.LessThanOrEqualAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareLessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector128<ushort> left, Vector128<ushort> right) {
                return Vector128.LessThanOrEqualAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareLessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector128<int> left, Vector128<int> right) {
                return Vector128.LessThanOrEqualAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareLessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector128<uint> left, Vector128<uint> right) {
                return Vector128.LessThanOrEqualAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareLessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector128<long> left, Vector128<long> right) {
                return Vector128.LessThanOrEqualAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareLessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector128<ulong> left, Vector128<ulong> right) {
                return Vector128.LessThanOrEqualAny(left, right);
                // return PackedSimd.AnyTrue(PackedSimd.CompareLessThanOrEqual(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.Max_AcceleratedTypes"/>
            public static TypeCodeFlags Max_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Max(Vector128<float> left, Vector128<float> right) {
                //return PackedSimd.Max(left, right);
                return PackedSimd.PseudoMax(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Max(Vector128<double> left, Vector128<double> right) {
                //return PackedSimd.Max(left, right);
                return PackedSimd.PseudoMax(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Max(Vector128<sbyte> left, Vector128<sbyte> right) {
                return PackedSimd.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Max(Vector128<byte> left, Vector128<byte> right) {
                return PackedSimd.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Max(Vector128<short> left, Vector128<short> right) {
                return PackedSimd.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Max(Vector128<ushort> left, Vector128<ushort> right) {
                return PackedSimd.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Max(Vector128<int> left, Vector128<int> right) {
                return PackedSimd.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Max(Vector128<uint> left, Vector128<uint> right) {
                return PackedSimd.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Max(Vector128<long> left, Vector128<long> right) {
                //return PackedSimd.Max(left, right);
                Vector128<long> mask = GreaterThan(left, right);
                Vector128<long> rt = Vector128.ConditionalSelect(mask, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Max(Vector128<ulong> left, Vector128<ulong> right) {
                //return PackedSimd.Max(left, right);
                Vector128<ulong> mask = GreaterThan(left, right);
                Vector128<ulong> rt = Vector128.ConditionalSelect(mask, left, right);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Min_AcceleratedTypes"/>
            public static TypeCodeFlags Min_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Min(Vector128<float> left, Vector128<float> right) {
                //return PackedSimd.Min(left, right);
                return PackedSimd.PseudoMin(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Min(Vector128<double> left, Vector128<double> right) {
                //return PackedSimd.Min(left, right);
                return PackedSimd.PseudoMin(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Min(Vector128<sbyte> left, Vector128<sbyte> right) {
                return PackedSimd.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Min(Vector128<byte> left, Vector128<byte> right) {
                return PackedSimd.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Min(Vector128<short> left, Vector128<short> right) {
                return PackedSimd.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Min(Vector128<ushort> left, Vector128<ushort> right) {
                return PackedSimd.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Min(Vector128<int> left, Vector128<int> right) {
                return PackedSimd.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Min(Vector128<uint> left, Vector128<uint> right) {
                return PackedSimd.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Min(Vector128<long> left, Vector128<long> right) {
                //return PackedSimd.Min(left, right);
                Vector128<long> mask = LessThan(left, right);
                Vector128<long> rt = Vector128.ConditionalSelect(mask, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Min(Vector128<ulong> left, Vector128<ulong> right) {
                //return PackedSimd.Min(left, right);
                Vector128<ulong> mask = LessThan(left, right);
                Vector128<ulong> rt = Vector128.ConditionalSelect(mask, left, right);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Multiply_AcceleratedTypes"/>
            public static TypeCodeFlags Multiply_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply_FullAcceleratedTypes"/>
            public static TypeCodeFlags Multiply_FullAcceleratedTypes {
                get {
                    return TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Multiply(Vector128<float> left, Vector128<float> right) {
                return PackedSimd.Multiply(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Multiply(Vector128<double> left, Vector128<double> right) {
                return PackedSimd.Multiply(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Multiply(Vector128<sbyte> left, Vector128<sbyte> right) {
                return Multiply(left.AsByte(), right.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Multiply_SelfWiden(Vector128<sbyte> left, Vector128<sbyte> right) {
                return Multiply_SelfWiden(left.AsByte(), right.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Multiply(Vector128<byte> left, Vector128<byte> right) {
                //return Vector128.Multiply(left, right);
                Vector128<ushort> u0, u1, v0, v1;
                (u0, u1) = Vector128.Widen(left);
                (v0, v1) = Vector128.Widen(right);
                Vector128<ushort> w0 = PackedSimd.Multiply(u0, v0);
                Vector128<ushort> w1 = PackedSimd.Multiply(u1, v1);
                Vector128<byte> rt = Narrow(w0, w1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Multiply_SelfWiden(Vector128<byte> left, Vector128<byte> right) {
                //return Vector128.Multiply(left, right);
                Widen(left, out Vector128<ushort> u0, out Vector128<ushort> u1);
                Widen(right, out Vector128<ushort> v0, out Vector128<ushort> v1);
                Vector128<ushort> w0 = PackedSimd.Multiply(u0, v0);
                Vector128<ushort> w1 = PackedSimd.Multiply(u1, v1);
                Vector128<byte> rt = Narrow(w0, w1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Multiply(Vector128<short> left, Vector128<short> right) {
                return PackedSimd.Multiply(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Multiply(Vector128<ushort> left, Vector128<ushort> right) {
                return PackedSimd.Multiply(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Multiply(Vector128<int> left, Vector128<int> right) {
                return PackedSimd.Multiply(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Multiply(Vector128<uint> left, Vector128<uint> right) {
                return PackedSimd.Multiply(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Multiply(Vector128<long> left, Vector128<long> right) {
                return PackedSimd.Multiply(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Multiply(Vector128<ulong> left, Vector128<ulong> right) {
                return PackedSimd.Multiply(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits128.Negate_AcceleratedTypes"/>
            public static TypeCodeFlags Negate_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Negate(Vector128<float> value) {
                return PackedSimd.Negate(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Negate(Vector128<double> value) {
                return PackedSimd.Negate(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Negate(Vector128<sbyte> value) {
                return PackedSimd.Negate(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Negate(Vector128<short> value) {
                return PackedSimd.Negate(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Negate(Vector128<int> value) {
                return PackedSimd.Negate(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Negate(Vector128<long> value) {
                return PackedSimd.Negate(value);
            }


            /// <inheritdoc cref="IWVectorTraits128.OnesComplement_AcceleratedTypes"/>
            public static TypeCodeFlags OnesComplement_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.OnesComplement{T}(Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> OnesComplement<T>(Vector128<T> vector) where T : struct {
                return Vector128.OnesComplement(vector);
                //return PackedSimd.Not(vector.AsUInt64()).As<ulong, T>();
            }


            /// <inheritdoc cref="IWVectorTraits128.Sqrt_AcceleratedTypes"/>
            public static TypeCodeFlags Sqrt_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Sqrt(Vector128<float> value) {
                return PackedSimd.Sqrt(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Sqrt(Vector128<double> value) {
                return PackedSimd.Sqrt(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Sqrt(Vector128<sbyte> value) {
                Vector128<sbyte> mask = GreaterThan(Vector128<sbyte>.Zero, value); // 0>x = x<0.
                Vector128<sbyte> temp = Sqrt(value.AsByte()).AsSByte();
                Vector128<sbyte> rt = AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Sqrt(Vector128<byte> value) {
                // To float
                Vector128<ushort> t0, t1;
                Vector128<uint> w0, w1, w2, w3;
                (t0, t1) = Vector128.Widen(value);
                (w0, w1) = Vector128.Widen(t0);
                (w2, w3) = Vector128.Widen(t1);
                Vector128<float> src0 = ConvertToSingle(w0.AsInt32()); // On x86 platforms, Int32 typically has special instructions to speed up, which is faster than UInt32.
                Vector128<float> src1 = ConvertToSingle(w1.AsInt32());
                Vector128<float> src2 = ConvertToSingle(w2.AsInt32());
                Vector128<float> src3 = ConvertToSingle(w3.AsInt32());
                // Body
                Vector128<float> dst0 = PackedSimd.Sqrt(src0);
                Vector128<float> dst1 = PackedSimd.Sqrt(src1);
                Vector128<float> dst2 = PackedSimd.Sqrt(src2);
                Vector128<float> dst3 = PackedSimd.Sqrt(src3);
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
            public static Vector128<short> Sqrt(Vector128<short> value) {
                Vector128<short> mask = GreaterThan(Vector128<short>.Zero, value); // 0>x = x<0.
                Vector128<short> temp = Sqrt(value.AsUInt16()).AsInt16();
                Vector128<short> rt = AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Sqrt(Vector128<ushort> value) {
                // To float
                (Vector128<uint> w0, Vector128<uint> w1) = Vector128.Widen(value);
                Vector128<float> src0 = ConvertToSingle(w0.AsInt32());
                Vector128<float> src1 = ConvertToSingle(w1.AsInt32());
                // Body
                Vector128<float> dst0 = PackedSimd.Sqrt(src0);
                Vector128<float> dst1 = PackedSimd.Sqrt(src1);
                // To int
                w0 = ConvertToInt32(dst0).AsUInt32();
                w1 = ConvertToInt32(dst1).AsUInt32();
                Vector128<ushort> rt = Narrow(w0, w1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Sqrt(Vector128<int> value) {
                Vector128<int> mask = GreaterThan(Vector128<int>.Zero, value); // 0>x = x<0.
                Vector128<int> temp = Sqrt(value.AsUInt32()).AsInt32();
                Vector128<int> rt = AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Sqrt(Vector128<uint> value) {
                // To float
                (Vector128<ulong> w0, Vector128<ulong> w1) = Vector128.Widen(value);
                Vector128<double> src0 = ConvertToDouble_Range52(w0);
                Vector128<double> src1 = ConvertToDouble_Range52(w1);
                // Body
                Vector128<double> dst0 = PackedSimd.Sqrt(src0);
                Vector128<double> dst1 = PackedSimd.Sqrt(src1);
                // To int
                w0 = ConvertToUInt64_Range52(dst0);
                w1 = ConvertToUInt64_Range52(dst1);
                Vector128<uint> rt = Narrow(w0, w1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Sqrt(Vector128<long> value) {
                Vector128<long> mask = GreaterThan(Vector128<long>.Zero, value); // 0>x = x<0.
                Vector128<long> temp = Sqrt(value.AsUInt64()).AsInt64();
                Vector128<long> rt = AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Sqrt(Vector128<ulong> value) {
                // To float
                Vector128<double> src0 = ConvertToDouble(value);
                // Body
                Vector128<double> dst0 = PackedSimd.Sqrt(src0);
                // To int
                Vector128<ulong> rt = ConvertToUInt64_Range52(dst0);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Subtract_AcceleratedTypes"/>
            public static TypeCodeFlags Subtract_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Subtract(Vector128<float> left, Vector128<float> right) {
                return PackedSimd.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Subtract(Vector128<double> left, Vector128<double> right) {
                return PackedSimd.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Subtract(Vector128<sbyte> left, Vector128<sbyte> right) {
                return PackedSimd.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Subtract(Vector128<byte> left, Vector128<byte> right) {
                return PackedSimd.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Subtract(Vector128<short> left, Vector128<short> right) {
                return PackedSimd.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Subtract(Vector128<ushort> left, Vector128<ushort> right) {
                return PackedSimd.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Subtract(Vector128<int> left, Vector128<int> right) {
                return PackedSimd.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Subtract(Vector128<uint> left, Vector128<uint> right) {
                return PackedSimd.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Subtract(Vector128<long> left, Vector128<long> right) {
                return PackedSimd.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Subtract(Vector128<ulong> left, Vector128<ulong> right) {
                return PackedSimd.Subtract(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits128.Xor_AcceleratedTypes"/>
            public static TypeCodeFlags Xor_AcceleratedTypes {
                get {
                    return TypeCodeFlagsUtil.AllTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Xor{T}(Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> Xor<T>(Vector128<T> left, Vector128<T> right) where T : struct {
                return Vector128.Xor(left, right);
                //return PackedSimd.Xor(left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
            }


#endif // NET8_0_OR_GREATER
        }
    }
}
