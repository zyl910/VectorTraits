using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
#if NET5_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;
#endif // NET5_0_OR_GREATER

namespace Zyl.VectorTraits.Impl {
    using SuperStatics = WVectorTraits128Base.Statics;

    partial class WVectorTraits128AdvSimd {

        partial class Statics {

#if NET5_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.Abs_AcceleratedTypes"/>
            public static TypeCodeFlags Abs_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Abs(Vector128<float> value) {
                return AdvSimd.Abs(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Abs(Vector128<double> value) {
                return AdvSimd.BitwiseClear(value, Vector128s<double>.SignMask);
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Abs(Vector128<sbyte> value) {
                return AdvSimd.Abs(value).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Abs(Vector128<short> value) {
                return AdvSimd.Abs(value).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Abs(Vector128<int> value) {
                return AdvSimd.Abs(value).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Abs(Vector128<long> value) {
                // If an integer value is positive or zero, no action is required. Otherwise complement and add 1.
                //Vector128<long> mask = AdvSimd.CompareGreaterThan(Vector128<long>.Zero, value); // 0>value => value<0
                long m0 = BitUtil.ToInt32Mask(0 > AdvSimd.Extract(value, 0));
                long m1 = BitUtil.ToInt32Mask(0 > AdvSimd.Extract(value, 1));
                Vector128<long> mask = Vector128.Create(m0, m1);
                Vector128<long> rt = AdvSimd.Subtract(AdvSimd.Xor(value, mask), mask); // -x => (~x)+1 => (~x)-(-1) = (x^mask)-mask .
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Add_AcceleratedTypes"/>
            public static TypeCodeFlags Add_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Add(Vector128<float> left, Vector128<float> right) {
                return AdvSimd.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Add(Vector128<double> left, Vector128<double> right) {
                Vector64<double> lower = AdvSimd.AddScalar(Vector128.GetLower(left), Vector128.GetLower(right));
                Vector64<double> upper = AdvSimd.AddScalar(Vector128.GetUpper(left), Vector128.GetUpper(right));
                Vector128<double> rt = Vector128.Create(lower, upper);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Add(Vector128<sbyte> left, Vector128<sbyte> right) {
                return AdvSimd.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Add(Vector128<byte> left, Vector128<byte> right) {
                return AdvSimd.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Add(Vector128<short> left, Vector128<short> right) {
                return AdvSimd.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Add(Vector128<ushort> left, Vector128<ushort> right) {
                return AdvSimd.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Add(Vector128<int> left, Vector128<int> right) {
                return AdvSimd.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Add(Vector128<uint> left, Vector128<uint> right) {
                return AdvSimd.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Add(Vector128<long> left, Vector128<long> right) {
                return AdvSimd.Add(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Add(Vector128<ulong> left, Vector128<ulong> right) {
                return AdvSimd.Add(left, right);
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
                return AdvSimd.BitwiseClear(left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
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
                return AdvSimd.And(left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
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
                return AdvSimd.Or(left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
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
                return AdvSimd.Or(AdvSimd.And(condition.AsByte(), left.AsByte())
                    , AdvSimd.And(AdvSimd.Not(condition.AsByte()), right.AsByte())
                    ).As<byte, T>();
            }

            /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect{T}(Vector128{T}, Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<T> ConditionalSelect_Hw<T>(Vector128<T> condition, Vector128<T> left, Vector128<T> right) where T : struct {
                return AdvSimd.BitwiseSelect(condition.AsByte(), left.AsByte(), right.AsByte()).As<byte, T>();
            }


            /// <inheritdoc cref="IWVectorTraits128.GreaterThan_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThan_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> GreaterThan(Vector128<float> left, Vector128<float> right) {
                return AdvSimd.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> GreaterThan(Vector128<double> left, Vector128<double> right) {
                //Vector128<long> mask = AdvSimd.CompareGreaterThan(left, right);
                long m0 = BitUtil.ToInt32Mask(AdvSimd.Extract(left, 0) > AdvSimd.Extract(right, 0));
                long m1 = BitUtil.ToInt32Mask(AdvSimd.Extract(left, 1) > AdvSimd.Extract(right, 1));
                Vector128<long> mask = Vector128.Create(m0, m1);
                return mask.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> GreaterThan(Vector128<sbyte> left, Vector128<sbyte> right) {
                return AdvSimd.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> GreaterThan(Vector128<byte> left, Vector128<byte> right) {
                return AdvSimd.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> GreaterThan(Vector128<short> left, Vector128<short> right) {
                return AdvSimd.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> GreaterThan(Vector128<ushort> left, Vector128<ushort> right) {
                return AdvSimd.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> GreaterThan(Vector128<int> left, Vector128<int> right) {
                return AdvSimd.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> GreaterThan(Vector128<uint> left, Vector128<uint> right) {
                return AdvSimd.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> GreaterThan(Vector128<long> left, Vector128<long> right) {
                // Vector128<long> mask = AdvSimd.CompareGreaterThan(left, right);
                long m0 = BitUtil.ToInt32Mask(AdvSimd.Extract(left, 0) > AdvSimd.Extract(right, 0));
                long m1 = BitUtil.ToInt32Mask(AdvSimd.Extract(left, 1) > AdvSimd.Extract(right, 1));
                Vector128<long> mask = Vector128.Create(m0, m1);
                return mask.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> GreaterThan(Vector128<ulong> left, Vector128<ulong> right) {
                //Vector128<long> mask = AdvSimd.CompareGreaterThan(left, right);
                long m0 = BitUtil.ToInt32Mask(AdvSimd.Extract(left, 0) > AdvSimd.Extract(right, 0));
                long m1 = BitUtil.ToInt32Mask(AdvSimd.Extract(left, 1) > AdvSimd.Extract(right, 1));
                Vector128<long> mask = Vector128.Create(m0, m1);
                return mask.AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.LessThan_AcceleratedTypes"/>
            public static TypeCodeFlags LessThan_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Single | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> LessThan(Vector128<float> left, Vector128<float> right) {
                return AdvSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> LessThan(Vector128<double> left, Vector128<double> right) {
                //Vector128<long> mask = AdvSimd.CompareLessThan(left, right);
                long m0 = BitUtil.ToInt32Mask(AdvSimd.Extract(left, 0) < AdvSimd.Extract(right, 0));
                long m1 = BitUtil.ToInt32Mask(AdvSimd.Extract(left, 1) < AdvSimd.Extract(right, 1));
                Vector128<long> mask = Vector128.Create(m0, m1);
                return mask.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> LessThan(Vector128<sbyte> left, Vector128<sbyte> right) {
                return AdvSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> LessThan(Vector128<byte> left, Vector128<byte> right) {
                return AdvSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> LessThan(Vector128<short> left, Vector128<short> right) {
                return AdvSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> LessThan(Vector128<ushort> left, Vector128<ushort> right) {
                return AdvSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> LessThan(Vector128<int> left, Vector128<int> right) {
                return AdvSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> LessThan(Vector128<uint> left, Vector128<uint> right) {
                return AdvSimd.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> LessThan(Vector128<long> left, Vector128<long> right) {
                // Vector128<long> mask = AdvSimd.CompareLessThan(left, right);
                long m0 = BitUtil.ToInt32Mask(AdvSimd.Extract(left, 0) < AdvSimd.Extract(right, 0));
                long m1 = BitUtil.ToInt32Mask(AdvSimd.Extract(left, 1) < AdvSimd.Extract(right, 1));
                Vector128<long> mask = Vector128.Create(m0, m1);
                return mask.AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> LessThan(Vector128<ulong> left, Vector128<ulong> right) {
                //Vector128<long> mask = AdvSimd.CompareLessThan(left, right);
                long m0 = BitUtil.ToInt32Mask(AdvSimd.Extract(left, 0) < AdvSimd.Extract(right, 0));
                long m1 = BitUtil.ToInt32Mask(AdvSimd.Extract(left, 1) < AdvSimd.Extract(right, 1));
                Vector128<long> mask = Vector128.Create(m0, m1);
                return mask.AsUInt64();
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
                return AdvSimd.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Max(Vector128<double> left, Vector128<double> right) {
                //Vector128<long> mask = AdvSimd.CompareGreaterThan(left, right);
                long m0 = BitUtil.ToInt32Mask(AdvSimd.Extract(left, 0) > AdvSimd.Extract(right, 0));
                long m1 = BitUtil.ToInt32Mask(AdvSimd.Extract(left, 1) > AdvSimd.Extract(right, 1));
                Vector128<long> mask = Vector128.Create(m0, m1);
                Vector128<double> rt = AdvSimd.BitwiseSelect(mask.AsDouble(), left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Max(Vector128<sbyte> left, Vector128<sbyte> right) {
                return AdvSimd.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Max(Vector128<byte> left, Vector128<byte> right) {
                return AdvSimd.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Max(Vector128<short> left, Vector128<short> right) {
                return AdvSimd.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Max(Vector128<ushort> left, Vector128<ushort> right) {
                return AdvSimd.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Max(Vector128<int> left, Vector128<int> right) {
                return AdvSimd.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Max(Vector128<uint> left, Vector128<uint> right) {
                return AdvSimd.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Max(Vector128<long> left, Vector128<long> right) {
                // Vector128<long> mask = AdvSimd.CompareGreaterThan(left, right);
                long m0 = BitUtil.ToInt32Mask(AdvSimd.Extract(left, 0) > AdvSimd.Extract(right, 0));
                long m1 = BitUtil.ToInt32Mask(AdvSimd.Extract(left, 1) > AdvSimd.Extract(right, 1));
                Vector128<long> mask = Vector128.Create(m0, m1);
                Vector128<long> rt = AdvSimd.BitwiseSelect(mask, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Max(Vector128<ulong> left, Vector128<ulong> right) {
                //Vector128<long> mask = AdvSimd.CompareGreaterThan(left, right);
                long m0 = BitUtil.ToInt32Mask(AdvSimd.Extract(left, 0) > AdvSimd.Extract(right, 0));
                long m1 = BitUtil.ToInt32Mask(AdvSimd.Extract(left, 1) > AdvSimd.Extract(right, 1));
                Vector128<long> mask = Vector128.Create(m0, m1);
                Vector128<ulong> rt = AdvSimd.BitwiseSelect(mask.AsUInt64(), left, right);
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
                return AdvSimd.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Min(Vector128<double> left, Vector128<double> right) {
                //Vector128<long> mask = AdvSimd.CompareLessThan(left, right);
                long m0 = BitUtil.ToInt32Mask(AdvSimd.Extract(left, 0) < AdvSimd.Extract(right, 0));
                long m1 = BitUtil.ToInt32Mask(AdvSimd.Extract(left, 1) < AdvSimd.Extract(right, 1));
                Vector128<long> mask = Vector128.Create(m0, m1);
                Vector128<double> rt = AdvSimd.BitwiseSelect(mask.AsDouble(), left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Min(Vector128<sbyte> left, Vector128<sbyte> right) {
                return AdvSimd.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Min(Vector128<byte> left, Vector128<byte> right) {
                return AdvSimd.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Min(Vector128<short> left, Vector128<short> right) {
                return AdvSimd.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Min(Vector128<ushort> left, Vector128<ushort> right) {
                return AdvSimd.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Min(Vector128<int> left, Vector128<int> right) {
                return AdvSimd.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Min(Vector128<uint> left, Vector128<uint> right) {
                return AdvSimd.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Min(Vector128<long> left, Vector128<long> right) {
                // Vector128<long> mask = AdvSimd.CompareLessThan(left, right);
                long m0 = BitUtil.ToInt32Mask(AdvSimd.Extract(left, 0) < AdvSimd.Extract(right, 0));
                long m1 = BitUtil.ToInt32Mask(AdvSimd.Extract(left, 1) < AdvSimd.Extract(right, 1));
                Vector128<long> mask = Vector128.Create(m0, m1);
                Vector128<long> rt = AdvSimd.BitwiseSelect(mask, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Min(Vector128<ulong> left, Vector128<ulong> right) {
                //Vector128<long> mask = AdvSimd.CompareLessThan(left, right);
                long m0 = BitUtil.ToInt32Mask(AdvSimd.Extract(left, 0) < AdvSimd.Extract(right, 0));
                long m1 = BitUtil.ToInt32Mask(AdvSimd.Extract(left, 1) < AdvSimd.Extract(right, 1));
                Vector128<long> mask = Vector128.Create(m0, m1);
                Vector128<ulong> rt = AdvSimd.BitwiseSelect(mask.AsUInt64(), left, right);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Multiply_AcceleratedTypes"/>
            public static TypeCodeFlags Multiply_AcceleratedTypes {
                get {
                    return TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Single | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    //  | TypeCodeFlags.Double | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{float}, Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Multiply(Vector128<float> left, Vector128<float> right) {
                return AdvSimd.Multiply(left, right);
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
                return AdvSimd.Multiply(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Multiply(Vector128<byte> left, Vector128<byte> right) {
                return AdvSimd.Multiply(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Multiply(Vector128<short> left, Vector128<short> right) {
                return AdvSimd.Multiply(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Multiply(Vector128<ushort> left, Vector128<ushort> right) {
                return AdvSimd.Multiply(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Multiply(Vector128<int> left, Vector128<int> right) {
                return AdvSimd.Multiply(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Multiply(Vector128<uint> left, Vector128<uint> right) {
                return AdvSimd.Multiply(left, right);
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
                return AdvSimd.Negate(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Negate(Vector128<double> value) {
                Vector64<double> lower = AdvSimd.NegateScalar(Vector128.GetLower(value));
                Vector64<double> upper = AdvSimd.NegateScalar(Vector128.GetUpper(value));
                Vector128<double> rt = Vector128.Create(lower, upper);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Negate(Vector128<sbyte> value) {
                return AdvSimd.Negate(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Negate(Vector128<short> value) {
                return AdvSimd.Negate(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Negate(Vector128<int> value) {
                return AdvSimd.Negate(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Negate(Vector128<long> value) {
                return AdvSimd.Subtract(Vector128<long>.Zero, value);
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
                return AdvSimd.Not(vector.AsUInt64()).As<ulong, T>();
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
                return AdvSimd.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Subtract(Vector128<double> left, Vector128<double> right) {
                Vector64<double> lower = AdvSimd.SubtractScalar(Vector128.GetLower(left), Vector128.GetLower(right));
                Vector64<double> upper = AdvSimd.SubtractScalar(Vector128.GetUpper(left), Vector128.GetUpper(right));
                Vector128<double> rt = Vector128.Create(lower, upper);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Subtract(Vector128<sbyte> left, Vector128<sbyte> right) {
                return AdvSimd.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Subtract(Vector128<byte> left, Vector128<byte> right) {
                return AdvSimd.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Subtract(Vector128<short> left, Vector128<short> right) {
                return AdvSimd.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Subtract(Vector128<ushort> left, Vector128<ushort> right) {
                return AdvSimd.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Subtract(Vector128<int> left, Vector128<int> right) {
                return AdvSimd.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Subtract(Vector128<uint> left, Vector128<uint> right) {
                return AdvSimd.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Subtract(Vector128<long> left, Vector128<long> right) {
                return AdvSimd.Subtract(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Subtract(Vector128<ulong> left, Vector128<ulong> right) {
                return AdvSimd.Subtract(left, right);
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
                return AdvSimd.Xor(left.AsUInt64(), right.AsUInt64()).As<ulong, T>();
            }


#endif // NET5_0_OR_GREATER
        }
    }
}
