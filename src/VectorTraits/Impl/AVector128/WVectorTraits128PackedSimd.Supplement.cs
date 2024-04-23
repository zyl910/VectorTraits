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

/*
            /// <inheritdoc cref="IWVectorTraits128.Add_AcceleratedTypes"/>
            public static TypeCodeFlags Add_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
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
                Vector64<double> lower = PackedSimd.AddScalar(Vector128.GetLower(left), Vector128.GetLower(right));
                Vector64<double> upper = PackedSimd.AddScalar(Vector128.GetUpper(left), Vector128.GetUpper(right));
                Vector128<double> rt = lower.ToVector128Unsafe().WithUpper(upper); //Vector128.Create(lower, upper);
                return rt;
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
                // Bitwise bit Clear (vector, register). This instruction performs a bitwise AND between the first source SIMD&FP register and the complement of the second source SIMD&FP register, and writes the result to the destination SIMD&FP register.
                // Operation
                // if invert then operand2 = NOT(operand2);
                // case op of
                //     when LogicalOp_AND
                //         result = operand1 AND operand2;
                return PackedSimd.BitwiseClear(left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
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
                return PackedSimd.And(left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
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
                return PackedSimd.Or(left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
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
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector128.ConditionalSelect(condition, left, right);
#else
                return ConditionalSelect_Hw(condition, left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
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
                return SuperStatics.Dot(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Dot(Vector128<sbyte> left, Vector128<sbyte> right) {
                Vector128<sbyte> temp = PackedSimd.Multiply(left, right);
                return Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Dot(Vector128<byte> left, Vector128<byte> right) {
                Vector128<byte> temp = PackedSimd.Multiply(left, right);
                return Sum(temp);
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
                return SuperStatics.Dot(left, right);
                //Vector128<long> temp = Multiply(left, right);
                //return Sum(temp);
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Dot(Vector128<ulong> left, Vector128<ulong> right) {
                return SuperStatics.Dot(left, right);
                //Vector128<ulong> temp = Multiply(left, right);
                //return Sum(temp);
            }


            /// <inheritdoc cref="IWVectorTraits128.Equals_AcceleratedTypes"/>
            public static TypeCodeFlags Equals_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
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
                //Vector128<long> mask = PackedSimd.CompareEquals(left, right);
                long m0 = BitMath.ToInt32Mask(PackedSimd.Extract(left, 0) == PackedSimd.Extract(right, 0));
                long m1 = BitMath.ToInt32Mask(PackedSimd.Extract(left, 1) == PackedSimd.Extract(right, 1));
                Vector128<long> mask = Vector128.Create(m0, m1);
                return mask.AsDouble();
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
                return Equals(left.AsUInt64(), right.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Equals(Vector128<ulong> left, Vector128<ulong> right) {
                return Equals_Half(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Equals_Half(Vector128<ulong> left, Vector128<ulong> right) {
                const byte N = 32; // sizeof(uint);
                // rt = (a == b)
                //    = (a1<<N + a0) == (b1<<N + b1)
                //    = (a1==b1) && (a0==b0)
                Vector128<ulong> rawEqual = PackedSimd.CompareEqual(left.AsUInt32(), right.AsUInt32()).AsUInt64();
                Vector128<ulong> swapEqual = PackedSimd.Or(
                    PackedSimd.ShiftLeftLogical(rawEqual, N),
                    PackedSimd.ShiftRightLogical(rawEqual, N));
                Vector128<ulong> rt = PackedSimd.And(rawEqual, swapEqual);
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
                    return TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> GreaterThan(Vector128<float> left, Vector128<float> right) {
                return PackedSimd.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> GreaterThan(Vector128<double> left, Vector128<double> right) {
                //Vector128<long> mask = PackedSimd.CompareGreaterThan(left, right);
                long m0 = BitMath.ToInt32Mask(PackedSimd.Extract(left, 0) > PackedSimd.Extract(right, 0));
                long m1 = BitMath.ToInt32Mask(PackedSimd.Extract(left, 1) > PackedSimd.Extract(right, 1));
                Vector128<long> mask = Vector128.Create(m0, m1);
                return mask.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> GreaterThan(Vector128<sbyte> left, Vector128<sbyte> right) {
                return PackedSimd.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> GreaterThan(Vector128<byte> left, Vector128<byte> right) {
                return PackedSimd.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> GreaterThan(Vector128<short> left, Vector128<short> right) {
                return PackedSimd.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> GreaterThan(Vector128<ushort> left, Vector128<ushort> right) {
                return PackedSimd.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> GreaterThan(Vector128<int> left, Vector128<int> right) {
                return PackedSimd.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> GreaterThan(Vector128<uint> left, Vector128<uint> right) {
                return PackedSimd.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> GreaterThan(Vector128<long> left, Vector128<long> right) {
                return GreaterThan_Half(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> GreaterThan_Half(Vector128<long> left, Vector128<long> right) {
                const byte N = 32; // sizeof(int);
                // rt = (a > b)
                //    = (a1<<N + a0) > (b1<<N + b1)
                //    = (a1>b1) || ((a1==b1) && (a0>b0))
                Vector128<int> rawGreater = PackedSimd.CompareGreaterThan(left.AsInt32(), right.AsInt32());
                Vector128<int> rawEqual = PackedSimd.CompareEqual(left.AsInt32(), right.AsInt32());
                Vector128<long> lowGreater = PackedSimd.ShiftRightArithmetic(PackedSimd.ShiftLeftLogical(rawGreater.AsInt64(), N), N); // (a0>b0)
                Vector128<long> lowEqual = PackedSimd.ShiftRightArithmetic(rawEqual.AsInt64(), N); // (a1==b1)
                Vector128<long> high = PackedSimd.ShiftRightArithmetic(rawGreater.AsInt64(), N); // (a1>b1)
                Vector128<long> low = PackedSimd.And(lowEqual, lowGreater); // ((a1==b1) && (a0>b0))
                return PackedSimd.Or(low, high);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> GreaterThan_Scalar(Vector128<long> left, Vector128<long> right) {
                // Vector128<long> mask = PackedSimd.CompareGreaterThan(left, right);
                long m0 = BitMath.ToInt32Mask(PackedSimd.Extract(left, 0) > PackedSimd.Extract(right, 0));
                long m1 = BitMath.ToInt32Mask(PackedSimd.Extract(left, 1) > PackedSimd.Extract(right, 1));
                Vector128<long> mask = Vector128.Create(m0, m1);
                return mask.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> GreaterThan(Vector128<ulong> left, Vector128<ulong> right) {
                return GreaterThan_Saturate(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> GreaterThan_Half(Vector128<ulong> left, Vector128<ulong> right) {
                const byte N = 32; // sizeof(uint);
                // rt = (a > b)
                //    = (a1<<N + a0) > (b1<<N + b1)
                //    = (a1>b1) || ((a1==b1) && (a0>b0))
                Vector128<uint> rawGreater = PackedSimd.CompareGreaterThan(left.AsUInt32(), right.AsUInt32());
                Vector128<uint> rawEqual = PackedSimd.CompareEqual(left.AsUInt32(), right.AsUInt32());
                Vector128<ulong> lowGreater = PackedSimd.ShiftRightArithmetic(PackedSimd.ShiftLeftLogical(rawGreater.AsInt64(), N), N).AsUInt64(); // (a0>b0)
                Vector128<ulong> lowEqual = PackedSimd.ShiftRightArithmetic(rawEqual.AsInt64(), N).AsUInt64(); // (a1==b1)
                Vector128<ulong> high = PackedSimd.ShiftRightArithmetic(rawGreater.AsInt64(), N).AsUInt64(); // (a1>b1)
                Vector128<ulong> low = PackedSimd.And(lowEqual, lowGreater); // ((a1==b1) && (a0>b0))
                return PackedSimd.Or(low, high);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> GreaterThan_Saturate(Vector128<ulong> left, Vector128<ulong> right) {
                Vector128<ulong> diff = PackedSimd.SubtractSaturate(left, right); // Elements: Zero is NotGreater, non-zero is Greater .
                // Vector128<ulong> rt = PackedSimd.Not(PackedSimd.CompareEqual(diff, Vector128<ulong>.Zero));
                Vector128<ulong> rt = PackedSimd.ShiftLeftLogicalSaturate(PackedSimd.ShiftLeftLogicalSaturate(diff, 63), 1); // = ShiftLeftLogicalSaturate(diff, 64)
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> GreaterThan_Scalar(Vector128<ulong> left, Vector128<ulong> right) {
                //Vector128<long> mask = PackedSimd.CompareGreaterThan(left, right);
                long m0 = BitMath.ToInt32Mask(PackedSimd.Extract(left, 0) > PackedSimd.Extract(right, 0));
                long m1 = BitMath.ToInt32Mask(PackedSimd.Extract(left, 1) > PackedSimd.Extract(right, 1));
                Vector128<long> mask = Vector128.Create(m0, m1);
                return mask.AsUInt64();
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
                    return TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> GreaterThanOrEqual(Vector128<float> left, Vector128<float> right) {
                return PackedSimd.CompareGreaterThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> GreaterThanOrEqual(Vector128<double> left, Vector128<double> right) {
                long m0 = BitMath.ToInt32Mask(PackedSimd.Extract(left, 0) >= PackedSimd.Extract(right, 0));
                long m1 = BitMath.ToInt32Mask(PackedSimd.Extract(left, 1) >= PackedSimd.Extract(right, 1));
                Vector128<long> mask = Vector128.Create(m0, m1);
                return mask.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> GreaterThanOrEqual(Vector128<sbyte> left, Vector128<sbyte> right) {
                return PackedSimd.CompareGreaterThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> GreaterThanOrEqual(Vector128<byte> left, Vector128<byte> right) {
                return PackedSimd.CompareGreaterThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> GreaterThanOrEqual(Vector128<short> left, Vector128<short> right) {
                return PackedSimd.CompareGreaterThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> GreaterThanOrEqual(Vector128<ushort> left, Vector128<ushort> right) {
                return PackedSimd.CompareGreaterThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> GreaterThanOrEqual(Vector128<int> left, Vector128<int> right) {
                return PackedSimd.CompareGreaterThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> GreaterThanOrEqual(Vector128<uint> left, Vector128<uint> right) {
                return PackedSimd.CompareGreaterThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> GreaterThanOrEqual(Vector128<long> left, Vector128<long> right) {
                return OnesComplement(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> GreaterThanOrEqual(Vector128<ulong> left, Vector128<ulong> right) {
                return OnesComplement(LessThan(left, right));
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
                    return TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> LessThan(Vector128<float> left, Vector128<float> right) {
                return PackedSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> LessThan(Vector128<double> left, Vector128<double> right) {
                //Vector128<long> mask = PackedSimd.CompareLessThan(left, right);
                long m0 = BitMath.ToInt32Mask(PackedSimd.Extract(left, 0) < PackedSimd.Extract(right, 0));
                long m1 = BitMath.ToInt32Mask(PackedSimd.Extract(left, 1) < PackedSimd.Extract(right, 1));
                Vector128<long> mask = Vector128.Create(m0, m1);
                return mask.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> LessThan(Vector128<sbyte> left, Vector128<sbyte> right) {
                return PackedSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> LessThan(Vector128<byte> left, Vector128<byte> right) {
                return PackedSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> LessThan(Vector128<short> left, Vector128<short> right) {
                return PackedSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> LessThan(Vector128<ushort> left, Vector128<ushort> right) {
                return PackedSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> LessThan(Vector128<int> left, Vector128<int> right) {
                return PackedSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> LessThan(Vector128<uint> left, Vector128<uint> right) {
                return PackedSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> LessThan(Vector128<long> left, Vector128<long> right) {
                return GreaterThan(right, left);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> LessThan(Vector128<ulong> left, Vector128<ulong> right) {
                return GreaterThan(right, left);
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
                    return TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> LessThanOrEqual(Vector128<float> left, Vector128<float> right) {
                return PackedSimd.CompareLessThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> LessThanOrEqual(Vector128<double> left, Vector128<double> right) {
                long m0 = BitMath.ToInt32Mask(PackedSimd.Extract(left, 0) <= PackedSimd.Extract(right, 0));
                long m1 = BitMath.ToInt32Mask(PackedSimd.Extract(left, 1) <= PackedSimd.Extract(right, 1));
                Vector128<long> mask = Vector128.Create(m0, m1);
                return mask.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> LessThanOrEqual(Vector128<sbyte> left, Vector128<sbyte> right) {
                return PackedSimd.CompareLessThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> LessThanOrEqual(Vector128<byte> left, Vector128<byte> right) {
                return PackedSimd.CompareLessThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> LessThanOrEqual(Vector128<short> left, Vector128<short> right) {
                return PackedSimd.CompareLessThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> LessThanOrEqual(Vector128<ushort> left, Vector128<ushort> right) {
                return PackedSimd.CompareLessThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> LessThanOrEqual(Vector128<int> left, Vector128<int> right) {
                return PackedSimd.CompareLessThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> LessThanOrEqual(Vector128<uint> left, Vector128<uint> right) {
                return PackedSimd.CompareLessThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> LessThanOrEqual(Vector128<long> left, Vector128<long> right) {
                return OnesComplement(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> LessThanOrEqual(Vector128<ulong> left, Vector128<ulong> right) {
                return OnesComplement(GreaterThan(left, right));
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
                    return TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Max(Vector128<float> left, Vector128<float> right) {
                return PackedSimd.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Max(Vector128<double> left, Vector128<double> right) {
                double m0 = Math.Max(PackedSimd.Extract(left, 0), PackedSimd.Extract(right, 0));
                double m1 = Math.Max(PackedSimd.Extract(left, 1), PackedSimd.Extract(right, 1));
                Vector128<double> rt = Vector128.Create(m0, m1);
                return rt;
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
                long m0 = Math.Max(PackedSimd.Extract(left, 0), PackedSimd.Extract(right, 0));
                long m1 = Math.Max(PackedSimd.Extract(left, 1), PackedSimd.Extract(right, 1));
                Vector128<long> rt = Vector128.Create(m0, m1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Max(Vector128<ulong> left, Vector128<ulong> right) {
                ulong m0 = Math.Max(PackedSimd.Extract(left, 0), PackedSimd.Extract(right, 0));
                ulong m1 = Math.Max(PackedSimd.Extract(left, 1), PackedSimd.Extract(right, 1));
                Vector128<ulong> rt = Vector128.Create(m0, m1);
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
                return PackedSimd.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Min(Vector128<double> left, Vector128<double> right) {
                double m0 = Math.Min(PackedSimd.Extract(left, 0), PackedSimd.Extract(right, 0));
                double m1 = Math.Min(PackedSimd.Extract(left, 1), PackedSimd.Extract(right, 1));
                Vector128<double> rt = Vector128.Create(m0, m1);
                return rt;
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
                long m0 = Math.Min(PackedSimd.Extract(left, 0), PackedSimd.Extract(right, 0));
                long m1 = Math.Min(PackedSimd.Extract(left, 1), PackedSimd.Extract(right, 1));
                Vector128<long> rt = Vector128.Create(m0, m1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Min(Vector128<ulong> left, Vector128<ulong> right) {
                ulong m0 = Math.Min(PackedSimd.Extract(left, 0), PackedSimd.Extract(right, 0));
                ulong m1 = Math.Min(PackedSimd.Extract(left, 1), PackedSimd.Extract(right, 1));
                Vector128<ulong> rt = Vector128.Create(m0, m1);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Multiply_AcceleratedTypes"/>
            public static TypeCodeFlags Multiply_AcceleratedTypes {
                get {
                    return TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Single | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    //  | TypeCodeFlags.Double | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply_FullAcceleratedTypes"/>
            public static TypeCodeFlags Multiply_FullAcceleratedTypes {
                get {
                    return TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Single | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
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
                return SuperStatics.Multiply(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Multiply(Vector128<sbyte> left, Vector128<sbyte> right) {
                return PackedSimd.Multiply(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Multiply(Vector128<byte> left, Vector128<byte> right) {
                return PackedSimd.Multiply(left, right);
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
                return SuperStatics.Multiply(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Multiply(Vector128<ulong> left, Vector128<ulong> right) {
                return SuperStatics.Multiply(left, right);
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
                Vector64<double> lower = PackedSimd.NegateScalar(Vector128.GetLower(value));
                Vector64<double> upper = PackedSimd.NegateScalar(Vector128.GetUpper(value));
                Vector128<double> rt = lower.ToVector128Unsafe().WithUpper(upper); //Vector128.Create(lower, upper);
                return rt;
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
                return PackedSimd.Subtract(Vector128<long>.Zero, value);
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
                return PackedSimd.Not(vector.AsUInt64()).As<ulong, T>();
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
                Vector128<float> a0 = PackedSimd.ShiftRightLogical(PackedSimd.ShiftLeftLogical(value.AsUInt64(), 32), 32).AsSingle(); // 0, 2
                Vector128<float> a1 = PackedSimd.ShiftRightLogical(value.AsUInt64(), 32).AsSingle(); // 1, 3
                Vector64<float> b0 = PackedSimd.SqrtScalar(a0.GetLower());
                Vector64<float> b2 = PackedSimd.SqrtScalar(a0.GetUpper());
                Vector64<float> b1 = PackedSimd.SqrtScalar(a1.GetLower());
                Vector64<float> b3 = PackedSimd.SqrtScalar(a1.GetUpper());
                Vector128<float> c0 = b0.ToVector128Unsafe().WithUpper(b2); //Vector128.Create(b0, b2);
                Vector128<float> c1 = b1.ToVector128Unsafe().WithUpper(b3); //Vector128.Create(b1, b3);
                c1 = PackedSimd.ShiftLeftLogical(c1.AsUInt64(), 32).AsSingle();
                Vector128<float> rt = PackedSimd.Or(c0, c1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Sqrt(Vector128<double> value) {
                Vector64<double> dst0 = PackedSimd.SqrtScalar(value.GetLower());
                Vector64<double> dst1 = PackedSimd.SqrtScalar(value.GetUpper());
                Vector128<double> rt = dst0.ToVector128Unsafe().WithUpper(dst1); //Vector128.Create(dst0, dst1);
                return rt;
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
                Widen(value, out Vector128<ushort> t0, out Vector128<ushort> t1);
                Widen(t0, out Vector128<uint> w0, out Vector128<uint> w1);
                Widen(t1, out Vector128<uint> w2, out Vector128<uint> w3);
                Vector128<float> src0 = ConvertToSingle(w0.AsInt32()); // On x86 platforms, Int32 typically has special instructions to speed up, which is faster than UInt32.
                Vector128<float> src1 = ConvertToSingle(w1.AsInt32());
                Vector128<float> src2 = ConvertToSingle(w2.AsInt32());
                Vector128<float> src3 = ConvertToSingle(w3.AsInt32());
                // Body
                Vector128<float> dst0 = Sqrt(src0);
                Vector128<float> dst1 = Sqrt(src1);
                Vector128<float> dst2 = Sqrt(src2);
                Vector128<float> dst3 = Sqrt(src3);
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
                Widen(value, out Vector128<uint> w0, out Vector128<uint> w1);
                Vector128<float> src0 = ConvertToSingle(w0.AsInt32());
                Vector128<float> src1 = ConvertToSingle(w1.AsInt32());
                // Body
                Vector128<float> dst0 = Sqrt(src0);
                Vector128<float> dst1 = Sqrt(src1);
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
                Widen(value, out Vector128<ulong> w0, out Vector128<ulong> w1);
                Vector128<double> src0 = ConvertToDouble_Range52(w0);
                Vector128<double> src1 = ConvertToDouble_Range52(w1);
                // Body
                Vector128<double> dst0 = Sqrt(src0);
                Vector128<double> dst1 = Sqrt(src1);
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
                Vector128<double> dst0 = Sqrt(src0);
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
                Vector64<double> lower = PackedSimd.SubtractScalar(Vector128.GetLower(left), Vector128.GetLower(right));
                Vector64<double> upper = PackedSimd.SubtractScalar(Vector128.GetUpper(left), Vector128.GetUpper(right));
                Vector128<double> rt = lower.ToVector128Unsafe().WithUpper(upper); //Vector128.Create(lower, upper);
                return rt;
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
                return PackedSimd.Xor(left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
            }
*/

#endif // NET8_0_OR_GREATER
        }
    }
}
