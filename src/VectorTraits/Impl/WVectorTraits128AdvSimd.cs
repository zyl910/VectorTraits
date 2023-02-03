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
    /// <summary>
    /// <see cref="Vector128{T}"/> traits - AdvSimd .
    /// </summary>
    public sealed partial class WVectorTraits128AdvSimd : WVectorTraits128AdvSimdAbstract {
        private static readonly WVectorTraits128AdvSimd _instance = new WVectorTraits128AdvSimd(); // Default instance.

        /// <summary>Default instance. </summary>
        public static WVectorTraits128AdvSimd Instance {
            get { return _instance; }
        }

#if NETCOREAPP3_0_OR_GREATER


#endif // NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// <see cref="Vector128{T}"/> traits.Statics - AdvSimd.
        /// </summary>
        public static partial class Statics {

            /// <inheritdoc cref="IBaseTraits.ByteCount"/>
            public static int ByteCount {
                get { return ByteCountValue; }
            }

            /// <inheritdoc cref="IBaseTraits.IsSupported"/>
            public static bool IsSupported {
                get {
                    return GetIsSupported();
                }
            }

            /// <inheritdoc cref="IBaseTraits.GetIsSupported"/>
            public static bool GetIsSupported(bool noStrict = false) {
                bool rt = false;
#if NET5_0_OR_GREATER
                rt = AdvSimd.IsSupported;
#else
#endif // NET5_0_OR_GREATER
                if (!noStrict) {
                    rt = rt && (sizeof(int) == IntPtr.Size);
                }
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
            public static string GetUnsupportedMessage(bool noStrict = false) {
                string rt = "Requires hardware support AdvSimd!";
#if NETCOREAPP3_0_OR_GREATER
#else
                rt = "Vector128 type is not supported! " + rt;
#endif // NETCOREAPP3_0_OR_GREATER
                if (!noStrict) {
                    if (!(sizeof(int) == IntPtr.Size)) {
                        rt += string.Format("This process({0}bit) is not 32-bit!", IntPtr.Size * 8);
                    }
                }
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
            public static void ThrowForUnsupported(bool noStrict = false) {
                if (GetIsSupported(noStrict)) return;
                throw new NotSupportedException(GetUnsupportedMessage(noStrict));
            }

#if NET5_0_OR_GREATER

            /// <summary>
            /// Debug test.
            /// </summary>
            public static void DebugTest() {
                Vector128<sbyte> src = Vector128<sbyte>.AllBitsSet;
                byte shiftAmount = 0;
                try {
                    Vector128<sbyte> dst = AdvSimd.ShiftLeftLogical(src, shiftAmount);
                    Trace.WriteLine($"ShiftLeftLogical:\tOK. {dst}");
                } catch(Exception ex) {
                    Trace.WriteLine($"ShiftLeftLogical:\tFail!. {ex}");
                }
                try {
                    Vector128<sbyte> dst = AdvSimd.ShiftRightArithmetic(src, shiftAmount);
                    Trace.WriteLine($"ShiftRightArithmetic:\tOK. {dst}");
                } catch (Exception ex) {
                    Trace.WriteLine($"ShiftRightArithmetic:\tFail!. {ex}");
                }
                try {
                    Vector128<sbyte> dst = AdvSimd.ShiftRightLogical(src, shiftAmount);
                    Trace.WriteLine($"ShiftRightLogical:\tOK. {dst}");
                } catch (Exception ex) {
                    Trace.WriteLine($"ShiftRightLogical:\tFail!. {ex}");
                }
                // Output:
                // ShiftLeftLogical:	OK. <-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1>
                // Exception thrown: 'System.ArgumentOutOfRangeException' in System.Private.CoreLib.dll
                // ShiftRightArithmetic:	Fail!. System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                // Exception thrown: 'System.ArgumentOutOfRangeException' in System.Private.CoreLib.dll
                // ShiftRightLogical:	Fail!. System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
            }


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


            /// <inheritdoc cref="IWVectorTraits128.Ceiling_AcceleratedTypes"/>
            public static TypeCodeFlags Ceiling_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Ceiling(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Ceiling(Vector128<float> value) {
                return AdvSimd.Ceiling(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Ceiling(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Ceiling(Vector128<double> value) {
                Vector64<double> lower = AdvSimd.CeilingScalar(Vector128.GetLower(value));
                Vector64<double> upper = AdvSimd.CeilingScalar(Vector128.GetUpper(value));
                Vector128<double> rt = Vector128.Create(lower, upper);
                return rt;
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


            /// <inheritdoc cref="IWVectorTraits128.Floor_AcceleratedTypes"/>
            public static TypeCodeFlags Floor_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Floor(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Floor(Vector128<float> value) {
                return AdvSimd.Floor(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Floor(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Floor(Vector128<double> value) {
                Vector64<double> lower = AdvSimd.FloorScalar(Vector128.GetLower(value));
                Vector64<double> upper = AdvSimd.FloorScalar(Vector128.GetUpper(value));
                Vector128<double> rt = Vector128.Create(lower, upper);
                return rt;
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


            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftLeft_AcceleratedTypes {
                get {
                    return TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftLeft(Vector128<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeftFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftLeft(Vector128<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeftFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeft(Vector128<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeftFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeft(Vector128<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeftFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeft(Vector128<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeftFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeft(Vector128<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeftFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeft(Vector128<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeftFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeft(Vector128<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeftFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftLeftFast(Vector128<sbyte> value, int shiftAmount) {
                return AdvSimd.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftLeftFast(Vector128<byte> value, int shiftAmount) {
                return AdvSimd.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftLeftFast(Vector128<short> value, int shiftAmount) {
                return AdvSimd.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftLeftFast(Vector128<ushort> value, int shiftAmount) {
                return AdvSimd.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftLeftFast(Vector128<int> value, int shiftAmount) {
                return Vector128.AsInt32(AdvSimd.ShiftLeftLogical(Vector128.AsUInt32(value), (byte)shiftAmount));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftLeftFast(Vector128<uint> value, int shiftAmount) {
                return AdvSimd.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftLeftFast(Vector128<long> value, int shiftAmount) {
                return AdvSimd.ShiftLeftLogical(value, (byte)shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftLeftFast(Vector128<ulong> value, int shiftAmount) {
                return AdvSimd.ShiftLeftLogical(value, (byte)shiftAmount);
            }


            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
                get {
                    return TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightArithmetic(Vector128<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                if (0 == shiftAmount) {
                    // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                    return value;
                }
                return ShiftRightArithmeticFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightArithmetic(Vector128<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                if (0 == shiftAmount) {
                    // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                    return value;
                }
                return ShiftRightArithmeticFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmetic(Vector128<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                if (0 == shiftAmount) {
                    // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                    return value;
                }
                return ShiftRightArithmeticFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmetic(Vector128<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                if (0 == shiftAmount) {
                    // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                    return value;
                }
                return ShiftRightArithmeticFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmeticFast(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightArithmeticFast(Vector128<sbyte> value, int shiftAmount) {
                Debug.Assert(1 <= shiftAmount && shiftAmount <= 7, "The shiftAmount parameter must be in the range [1,7]."); // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                return AdvSimd.ShiftArithmetic(value, Vector128.Create((sbyte)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmeticFast(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightArithmeticFast(Vector128<short> value, int shiftAmount) {
                Debug.Assert(1 <= shiftAmount && shiftAmount <= 15, "The shiftAmount parameter must be in the range [1,15]."); // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                return AdvSimd.ShiftArithmetic(value, Vector128.Create((short)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmeticFast(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightArithmeticFast(Vector128<int> value, int shiftAmount) {
                Debug.Assert(1 <= shiftAmount && shiftAmount <= 31, "The shiftAmount parameter must be in the range [1,31]."); // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                return AdvSimd.ShiftArithmetic(value, Vector128.Create((int)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmeticFast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightArithmeticFast(Vector128<long> value, int shiftAmount) {
                Debug.Assert(1 <= shiftAmount && shiftAmount <= 63, "The shiftAmount parameter must be in the range [1,63]."); // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                return AdvSimd.ShiftArithmetic(value, Vector128.Create((long)(-shiftAmount)));
            }


            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
                get {
                    return TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightLogical(Vector128<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                //if (0 == shiftAmount) {
                //    // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                //    return value;
                //}
                return ShiftRightLogicalFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogical(Vector128<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                //if (0 == shiftAmount) {
                //    // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                //    return value;
                //}
                return ShiftRightLogicalFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogical(Vector128<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                //if (0 == shiftAmount) {
                //    // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                //    return value;
                //}
                return ShiftRightLogicalFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogical(Vector128<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                //if (0 == shiftAmount) {
                //    // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                //    return value;
                //}
                return ShiftRightLogicalFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogical(Vector128<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                //if (0 == shiftAmount) {
                //    // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                //    return value;
                //}
                return ShiftRightLogicalFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogical(Vector128<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                //if (0 == shiftAmount) {
                //    // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                //    return value;
                //}
                return ShiftRightLogicalFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogical(Vector128<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                //if (0 == shiftAmount) {
                //    // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                //    return value;
                //}
                return ShiftRightLogicalFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogical(Vector128<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                if (0 == shiftAmount) {
                    // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                    return value;
                }
                return ShiftRightLogicalFast(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> ShiftRightLogicalFast(Vector128<sbyte> value, int shiftAmount) {
                return AdvSimd.ShiftLogical(value, Vector128.Create((sbyte)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> ShiftRightLogicalFast(Vector128<byte> value, int shiftAmount) {
                return AdvSimd.ShiftLogical(value, Vector128.Create((sbyte)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> ShiftRightLogicalFast(Vector128<short> value, int shiftAmount) {
                return AdvSimd.ShiftLogical(value, Vector128.Create((short)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> ShiftRightLogicalFast(Vector128<ushort> value, int shiftAmount) {
                return AdvSimd.ShiftLogical(value, Vector128.Create((short)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> ShiftRightLogicalFast(Vector128<int> value, int shiftAmount) {
                return AdvSimd.ShiftLogical(value, Vector128.Create((int)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> ShiftRightLogicalFast(Vector128<uint> value, int shiftAmount) {
                return AdvSimd.ShiftLogical(value, Vector128.Create((int)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> ShiftRightLogicalFast(Vector128<long> value, int shiftAmount) {
                return AdvSimd.ShiftLogical(value, Vector128.Create((long)(-shiftAmount)));
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogicalFast(Vector128<ulong> value, int shiftAmount) {
                return ShiftRightLogicalFast_HwVar(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogicalFast_HwVar(Vector128<ulong> value, int shiftAmount) {
                Vector128<long> vshift = Vector128.Create((long)(-shiftAmount));
                // NEON intrinsics for shifts by signed variable
                // uint64x2_t vshlq_u64(uint64x2_t a, int64x2_t b);  // VSHL.U64 q0,q0,q0
                return AdvSimd.ShiftLogical(value, vshift);
            }

            /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> ShiftRightLogicalFast_HwImm(Vector128<ulong> value, int shiftAmount) {
                Debug.Assert(1 <= shiftAmount && shiftAmount <= 63, "The shiftAmount parameter must be in the range [1,63]."); // AdvSimd throws an exception when shiftAmount is 0! 	System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values.
                return AdvSimd.ShiftRightLogical(value, (byte)shiftAmount);
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


#endif // NET5_0_OR_GREATER
        }

    }
}
