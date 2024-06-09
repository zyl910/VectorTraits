using System;
using System.Collections.Generic;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.CompilerServices;
#endif
#if NET5_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;
#endif // NET5_0_OR_GREATER

namespace Zyl.VectorTraits.Impl.AVector128 {
    using SuperStatics = WVectorTraits128AdvSimd.Statics;

    partial class WVectorTraits128AdvSimdB64 {

        partial class Statics {

#if NET5_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.Abs_AcceleratedTypes"/>
            public static TypeCodeFlags Abs_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Double | TypeCodeFlags.Int64 | SuperStatics.Add_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Abs(Vector128<double> value) {
                return AdvSimd.Arm64.Abs(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Abs(Vector128<long> value) {
                return AdvSimd.Arm64.Abs(value).AsInt64();
            }


            /// <inheritdoc cref="IWVectorTraits128.Add_AcceleratedTypes"/>
            public static TypeCodeFlags Add_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Double | SuperStatics.Add_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Add(Vector128<double> left, Vector128<double> right) {
                return AdvSimd.Arm64.Add(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect_AcceleratedTypes"/>
            internal static TypeCodeFlags ConditionalSelect_AcceleratedTypes {
                get {
                    return SuperStatics.ConditionalSelect_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect{T}(Vector128{T}, Vector128{T}, Vector128{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static Vector128<T> ConditionalSelect<T>(Vector128<T> condition, Vector128<T> left, Vector128<T> right) where T : struct {
                return SuperStatics.ConditionalSelect(condition, left, right);
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
                return AdvSimd.Arm64.Divide(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Divide(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Divide(Vector128<double> left, Vector128<double> right) {
                return AdvSimd.Arm64.Divide(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits128.Dot_AcceleratedTypes"/>
            public static TypeCodeFlags Dot_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = SuperStatics.Dot_AcceleratedTypes | TypeCodeFlags.Double;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Dot(Vector128<double> left, Vector128<double> right) {
                Vector128<double> temp = AdvSimd.Arm64.Multiply(left, right);
                return Sum(temp);
            }

            ///// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{long}, Vector128{long})"/>
            //[MethodImpl(MethodImplOptions.AggressiveInlining)]
            //public static long Dot(Vector128<long> left, Vector128<long> right) {
            //    return SuperStatics.Dot(left, right);
            //    //Vector128<long> temp = Multiply(left, right);
            //    //return Sum(temp);
            //}

            ///// <inheritdoc cref="IWVectorTraits128.Dot(Vector128{ulong}, Vector128{ulong})"/>
            //[CLSCompliant(false)]
            //[MethodImpl(MethodImplOptions.AggressiveInlining)]
            //public static ulong Dot(Vector128<ulong> left, Vector128<ulong> right) {
            //    return SuperStatics.Dot(left, right);
            //    //Vector128<ulong> temp = Multiply(left, right);
            //    //return Sum(temp);
            //}


            /// <inheritdoc cref="IWVectorTraits128.Equals_AcceleratedTypes"/>
            public static TypeCodeFlags Equals_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Double | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64
                        | SuperStatics.Equals_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Equals(Vector128<double> left, Vector128<double> right) {
                return AdvSimd.Arm64.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Equals(Vector128<long> left, Vector128<long> right) {
                return AdvSimd.Arm64.CompareEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Equals(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Equals(Vector128<ulong> left, Vector128<ulong> right) {
                return AdvSimd.Arm64.CompareEqual(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits128.EqualsAll_AcceleratedTypes"/>
            public static TypeCodeFlags EqualsAll_AcceleratedTypes {
                get {
                    return Equals_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector128<double> left, Vector128<double> right) {
                return SuperStatics.YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector128<long> left, Vector128<long> right) {
                return SuperStatics.YIsAllTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAll(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAll(Vector128<ulong> left, Vector128<ulong> right) {
                return SuperStatics.YIsAllTrue(Equals(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.EqualsAny_AcceleratedTypes"/>
            public static TypeCodeFlags EqualsAny_AcceleratedTypes {
                get {
                    return Equals_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector128<double> left, Vector128<double> right) {
                return SuperStatics.YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector128<long> left, Vector128<long> right) {
                return SuperStatics.YIsAnyTrue(Equals(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.EqualsAny(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool EqualsAny(Vector128<ulong> left, Vector128<ulong> right) {
                return SuperStatics.YIsAnyTrue(Equals(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.GreaterThan_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThan_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Double | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64
                        | SuperStatics.GreaterThan_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> GreaterThan(Vector128<double> left, Vector128<double> right) {
                return AdvSimd.Arm64.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> GreaterThan(Vector128<long> left, Vector128<long> right) {
                return AdvSimd.Arm64.CompareGreaterThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> GreaterThan(Vector128<ulong> left, Vector128<ulong> right) {
                return AdvSimd.Arm64.CompareGreaterThan(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanAll_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Double | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64
                        | SuperStatics.GreaterThanAll_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector128<double> left, Vector128<double> right) {
                return SuperStatics.YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector128<long> left, Vector128<long> right) {
                return SuperStatics.YIsAllTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAll(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAll(Vector128<ulong> left, Vector128<ulong> right) {
                return SuperStatics.YIsAllTrue(GreaterThan(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanAny_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Double | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64
                        | SuperStatics.GreaterThanAny_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector128<double> left, Vector128<double> right) {
                return SuperStatics.YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector128<long> left, Vector128<long> right) {
                return SuperStatics.YIsAnyTrue(GreaterThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanAny(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanAny(Vector128<ulong> left, Vector128<ulong> right) {
                return SuperStatics.YIsAnyTrue(GreaterThan(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanOrEqual_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Double | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64
                        | SuperStatics.GreaterThanOrEqual_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> GreaterThanOrEqual(Vector128<double> left, Vector128<double> right) {
                return AdvSimd.Arm64.CompareGreaterThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> GreaterThanOrEqual(Vector128<long> left, Vector128<long> right) {
                return AdvSimd.Arm64.CompareGreaterThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqual(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> GreaterThanOrEqual(Vector128<ulong> left, Vector128<ulong> right) {
                return AdvSimd.Arm64.CompareGreaterThanOrEqual(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanOrEqualAll_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Double | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64
                        | SuperStatics.GreaterThanOrEqualAll_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector128<double> left, Vector128<double> right) {
                return SuperStatics.YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector128<long> left, Vector128<long> right) {
                return SuperStatics.YIsAllTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAll(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAll(Vector128<ulong> left, Vector128<ulong> right) {
                return SuperStatics.YIsAllTrue(GreaterThanOrEqual(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny_AcceleratedTypes"/>
            public static TypeCodeFlags GreaterThanOrEqualAny_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Double | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64
                        | SuperStatics.GreaterThanOrEqualAny_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector128<double> left, Vector128<double> right) {
                return SuperStatics.YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector128<long> left, Vector128<long> right) {
                return SuperStatics.YIsAnyTrue(GreaterThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.GreaterThanOrEqualAny(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool GreaterThanOrEqualAny(Vector128<ulong> left, Vector128<ulong> right) {
                return SuperStatics.YIsAnyTrue(GreaterThanOrEqual(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.LessThan_AcceleratedTypes"/>
            public static TypeCodeFlags LessThan_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Double | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64
                        | SuperStatics.LessThan_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> LessThan(Vector128<double> left, Vector128<double> right) {
                return AdvSimd.Arm64.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> LessThan(Vector128<long> left, Vector128<long> right) {
                return AdvSimd.Arm64.CompareLessThan(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> LessThan(Vector128<ulong> left, Vector128<ulong> right) {
                return AdvSimd.Arm64.CompareLessThan(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits128.LessThanAll_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanAll_AcceleratedTypes {
                get {
                    return LessThan_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector128<double> left, Vector128<double> right) {
                return SuperStatics.YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector128<long> left, Vector128<long> right) {
                return SuperStatics.YIsAllTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAll(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAll(Vector128<ulong> left, Vector128<ulong> right) {
                return SuperStatics.YIsAllTrue(LessThan(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.LessThanAny_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanAny_AcceleratedTypes {
                get {
                    return LessThan_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector128<double> left, Vector128<double> right) {
                return SuperStatics.YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector128<long> left, Vector128<long> right) {
                return SuperStatics.YIsAnyTrue(LessThan(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanAny(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanAny(Vector128<ulong> left, Vector128<ulong> right) {
                return SuperStatics.YIsAnyTrue(LessThan(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanOrEqual_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Double | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64
                        | SuperStatics.LessThanOrEqual_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> LessThanOrEqual(Vector128<double> left, Vector128<double> right) {
                return AdvSimd.Arm64.CompareLessThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> LessThanOrEqual(Vector128<long> left, Vector128<long> right) {
                return AdvSimd.Arm64.CompareLessThanOrEqual(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqual(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> LessThanOrEqual(Vector128<ulong> left, Vector128<ulong> right) {
                return AdvSimd.Arm64.CompareLessThanOrEqual(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanOrEqualAll_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Double | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64
                        | SuperStatics.LessThanOrEqualAll_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector128<double> left, Vector128<double> right) {
                return SuperStatics.YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector128<long> left, Vector128<long> right) {
                return SuperStatics.YIsAllTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAll(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAll(Vector128<ulong> left, Vector128<ulong> right) {
                return SuperStatics.YIsAllTrue(LessThanOrEqual(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny_AcceleratedTypes"/>
            public static TypeCodeFlags LessThanOrEqualAny_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Double | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64
                        | SuperStatics.LessThanOrEqualAny_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector128<double> left, Vector128<double> right) {
                return SuperStatics.YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector128<long> left, Vector128<long> right) {
                return SuperStatics.YIsAnyTrue(LessThanOrEqual(left, right));
            }

            /// <inheritdoc cref="IWVectorTraits128.LessThanOrEqualAny(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool LessThanOrEqualAny(Vector128<ulong> left, Vector128<ulong> right) {
                return SuperStatics.YIsAnyTrue(LessThanOrEqual(left, right));
            }


            /// <inheritdoc cref="IWVectorTraits128.Max_AcceleratedTypes"/>
            public static TypeCodeFlags Max_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Double | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64
                        | SuperStatics.Max_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Max(Vector128<double> left, Vector128<double> right) {
                return AdvSimd.Arm64.Max(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Max(Vector128<long> left, Vector128<long> right) {
                Vector128<long> mask = AdvSimd.Arm64.CompareGreaterThan(left, right);
                Vector128<long> rt = AdvSimd.BitwiseSelect(mask, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Max(Vector128<ulong> left, Vector128<ulong> right) {
                Vector128<ulong> mask = AdvSimd.Arm64.CompareGreaterThan(left, right);
                Vector128<ulong> rt = AdvSimd.BitwiseSelect(mask, left, right);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Min_AcceleratedTypes"/>
            public static TypeCodeFlags Min_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Double | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64
                        | SuperStatics.Min_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Min(Vector128<double> left, Vector128<double> right) {
                return AdvSimd.Arm64.Min(left, right);
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Min(Vector128<long> left, Vector128<long> right) {
                Vector128<long> mask = AdvSimd.Arm64.CompareLessThan(left, right);
                Vector128<long> rt = AdvSimd.BitwiseSelect(mask, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Min(Vector128<ulong> left, Vector128<ulong> right) {
                Vector128<ulong> mask = AdvSimd.Arm64.CompareLessThan(left, right);
                Vector128<ulong> rt = AdvSimd.BitwiseSelect(mask, left, right);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Multiply_AcceleratedTypes"/>
            public static TypeCodeFlags Multiply_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Double
                        | SuperStatics.Multiply_AcceleratedTypes;
                    //  | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply_FullAcceleratedTypes"/>
            public static TypeCodeFlags Multiply_FullAcceleratedTypes {
                get {
                    return TypeCodeFlags.Double
                        | SuperStatics.Multiply_FullAcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Multiply(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Multiply(Vector128<double> left, Vector128<double> right) {
                return AdvSimd.Arm64.Multiply(left, right);
            }


            /// <inheritdoc cref="IWVectorTraits128.Negate_AcceleratedTypes"/>
            public static TypeCodeFlags Negate_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Double | TypeCodeFlags.Int64
                        | SuperStatics.Negate_AcceleratedTypes;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Negate(Vector128<double> value) {
                return AdvSimd.Arm64.Negate(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Negate(Vector128<long> value) {
                return AdvSimd.Arm64.Negate(value);
            }


            /// <inheritdoc cref="IWVectorTraits128.Sqrt_AcceleratedTypes"/>
            public static TypeCodeFlags Sqrt_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> Sqrt(Vector128<float> value) {
                return AdvSimd.Arm64.Sqrt(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Sqrt(Vector128<double> value) {
                return AdvSimd.Arm64.Sqrt(value);
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> Sqrt(Vector128<sbyte> value) {
                Vector128<sbyte> mask = SuperStatics.GreaterThan(Vector128<sbyte>.Zero, value); // 0>x = x<0.
                Vector128<sbyte> temp = Sqrt(value.AsByte()).AsSByte();
                Vector128<sbyte> rt = SuperStatics.AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> Sqrt(Vector128<byte> value) {
                // To float
                SuperStatics.Widen(value, out Vector128<ushort> t0, out Vector128<ushort> t1);
                SuperStatics.Widen(t0, out Vector128<uint> w0, out Vector128<uint> w1);
                SuperStatics.Widen(t1, out Vector128<uint> w2, out Vector128<uint> w3);
                Vector128<float> src0 = SuperStatics.ConvertToSingle(w0.AsInt32()); // On x86 platforms, Int32 typically has special instructions to speed up, which is faster than UInt32.
                Vector128<float> src1 = SuperStatics.ConvertToSingle(w1.AsInt32());
                Vector128<float> src2 = SuperStatics.ConvertToSingle(w2.AsInt32());
                Vector128<float> src3 = SuperStatics.ConvertToSingle(w3.AsInt32());
                // Body
                Vector128<float> dst0 = AdvSimd.Arm64.Sqrt(src0);
                Vector128<float> dst1 = AdvSimd.Arm64.Sqrt(src1);
                Vector128<float> dst2 = AdvSimd.Arm64.Sqrt(src2);
                Vector128<float> dst3 = AdvSimd.Arm64.Sqrt(src3);
                // To int
                w0 = SuperStatics.ConvertToInt32(dst0).AsUInt32();
                w1 = SuperStatics.ConvertToInt32(dst1).AsUInt32();
                w2 = SuperStatics.ConvertToInt32(dst2).AsUInt32();
                w3 = SuperStatics.ConvertToInt32(dst3).AsUInt32();
                t0 = SuperStatics.Narrow(w0, w1);
                t1 = SuperStatics.Narrow(w2, w3);
                Vector128<byte> rt = SuperStatics.Narrow(t0, t1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> Sqrt(Vector128<short> value) {
                Vector128<short> mask = SuperStatics.GreaterThan(Vector128<short>.Zero, value); // 0>x = x<0.
                Vector128<short> temp = Sqrt(value.AsUInt16()).AsInt16();
                Vector128<short> rt = SuperStatics.AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> Sqrt(Vector128<ushort> value) {
                // To float
                SuperStatics.Widen(value, out Vector128<uint> w0, out Vector128<uint> w1);
                Vector128<float> src0 = SuperStatics.ConvertToSingle(w0.AsInt32());
                Vector128<float> src1 = SuperStatics.ConvertToSingle(w1.AsInt32());
                // Body
                Vector128<float> dst0 = AdvSimd.Arm64.Sqrt(src0);
                Vector128<float> dst1 = AdvSimd.Arm64.Sqrt(src1);
                // To int
                w0 = SuperStatics.ConvertToInt32(dst0).AsUInt32();
                w1 = SuperStatics.ConvertToInt32(dst1).AsUInt32();
                Vector128<ushort> rt = SuperStatics.Narrow(w0, w1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> Sqrt(Vector128<int> value) {
                Vector128<int> mask = SuperStatics.GreaterThan(Vector128<int>.Zero, value); // 0>x = x<0.
                Vector128<int> temp = Sqrt(value.AsUInt32()).AsInt32();
                Vector128<int> rt = SuperStatics.AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> Sqrt(Vector128<uint> value) {
                // To float
                SuperStatics.Widen(value, out Vector128<ulong> w0, out Vector128<ulong> w1);
                Vector128<double> src0 = ConvertToDouble_Range52(w0);
                Vector128<double> src1 = ConvertToDouble_Range52(w1);
                // Body
                Vector128<double> dst0 = AdvSimd.Arm64.Sqrt(src0);
                Vector128<double> dst1 = AdvSimd.Arm64.Sqrt(src1);
                // To int
                w0 = ConvertToUInt64_Range52(dst0);
                w1 = ConvertToUInt64_Range52(dst1);
                Vector128<uint> rt = SuperStatics.Narrow(w0, w1);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> Sqrt(Vector128<long> value) {
                Vector128<long> mask = GreaterThan(Vector128<long>.Zero, value); // 0>x = x<0.
                Vector128<long> temp = Sqrt(value.AsUInt64()).AsInt64();
                Vector128<long> rt = SuperStatics.AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.Sqrt(Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> Sqrt(Vector128<ulong> value) {
                // To float
                Vector128<double> src0 = ConvertToDouble(value);
                // Body
                Vector128<double> dst0 = AdvSimd.Arm64.Sqrt(src0);
                // To int
                Vector128<ulong> rt = ConvertToUInt64_Range52(dst0);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.Subtract_AcceleratedTypes"/>
            public static TypeCodeFlags Subtract_AcceleratedTypes {
                get {
                    return TypeCodeFlags.Double | SuperStatics.Subtract_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{double}, Vector128{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> Subtract(Vector128<double> left, Vector128<double> right) {
                return AdvSimd.Arm64.Subtract(left, right);
            }


#endif // NET5_0_OR_GREATER
        }
    }
}
