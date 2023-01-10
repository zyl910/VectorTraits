using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.ComponentModel;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// <see cref="Vector256{T}"/> traits - Base.
    /// </summary>
    public sealed class WVectorTraits256Base : WVectorTraits256Abstract {
        private static readonly WVectorTraits256Base _instance = new WVectorTraits256Base(); // Default instance.

        /// <summary>Default instance. </summary>
        public static WVectorTraits256Base Instance {
            get { return _instance; }
        }

#if NETCOREAPP3_0_OR_GREATER


#endif // NETCOREAPP3_0_OR_GREATER

        /// <summary>
        /// <see cref="Vector256{T}"/> traits.Statics - Base.
        /// </summary>
        public static class Statics {

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
#if NETCOREAPP3_0_OR_GREATER
                rt = true;
#else
#endif // NETCOREAPP3_0_OR_GREATER
                if (!noStrict) {
                }
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
            public static string GetUnsupportedMessage(bool noStrict = false) {
                string rt = "Vector256 type is not supported!";
                if (!noStrict) {
                }
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
            public static void ThrowForUnsupported(bool noStrict = false) {
                if (GetIsSupported(noStrict)) return;
                throw new NotSupportedException(GetUnsupportedMessage(noStrict));
            }

#if NETCOREAPP3_0_OR_GREATER

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
                return AndNot_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.AndNot{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<T> AndNot_Base<T>(Vector256<T> left, Vector256<T> right) where T : struct {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<T> rt);
#else
                Vector256<T> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                ulong* q = (ulong*)&rt;
                // rt[i] := left[i] & ~right[i];
                q[0] = pleft[0] & ~pright[0];
                q[1] = pleft[1] & ~pright[1];
                q[2] = pleft[2] & ~pright[2];
                q[3] = pleft[3] & ~pright[3];
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
                return BitwiseAnd_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.BitwiseAnd{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<T> BitwiseAnd_Base<T>(Vector256<T> left, Vector256<T> right) where T : struct {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<T> rt);
#else
                Vector256<T> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                ulong* q = (ulong*)&rt;
                // rt[i] := left[i] & right[i];
                q[0] = pleft[0] & pright[0];
                q[1] = pleft[1] & pright[1];
                q[2] = pleft[2] & pright[2];
                q[3] = pleft[3] & pright[3];
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
                return BitwiseOr_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.BitwiseOr{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<T> BitwiseOr_Base<T>(Vector256<T> left, Vector256<T> right) where T : struct {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<T> rt);
#else
                Vector256<T> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                ulong* q = (ulong*)&rt;
                // rt[i] := left[i] | right[i];
                q[0] = pleft[0] | pright[0];
                q[1] = pleft[1] | pright[1];
                q[2] = pleft[2] | pright[2];
                q[3] = pleft[3] | pright[3];
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Ceiling_AcceleratedTypes"/>
            public static TypeCodeFlags Ceiling_AcceleratedTypes {
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

            /// <inheritdoc cref="IWVectorTraits256.Ceiling(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Ceiling(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Ceiling(value);
#else
                return Ceiling_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Ceiling(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Ceiling(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Ceiling(value);
#else
                return Ceiling_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Ceiling(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<float> Ceiling_Base(Vector256<float> value) {
                Vector256<float> rt = value;
                float* p = (float*)&rt;
                p[0] = MathF.Ceiling(p[0]);
                p[1] = MathF.Ceiling(p[1]);
                p[2] = MathF.Ceiling(p[2]);
                p[3] = MathF.Ceiling(p[3]);
                p[4] = MathF.Ceiling(p[4]);
                p[5] = MathF.Ceiling(p[5]);
                p[6] = MathF.Ceiling(p[6]);
                p[7] = MathF.Ceiling(p[7]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Ceiling(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<double> Ceiling_Base(Vector256<double> value) {
                Vector256<double> rt = value;
                double* p = (double*)&rt;
                p[0] = Math.Ceiling(p[0]);
                p[1] = Math.Ceiling(p[1]);
                p[2] = Math.Ceiling(p[2]);
                p[3] = Math.Ceiling(p[3]);
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
                return ConditionalSelect_Base(condition, left, right);
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
            public static unsafe Vector256<T> ConditionalSelect_Base<T>(Vector256<T> condition, Vector256<T> left, Vector256<T> right) where T : struct {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<T> rt);
#else
                Vector256<T> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* pcondition = (ulong*)&condition;
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                ulong* q = (ulong*)&rt;
                // result = (left & condition) | (right & ~condition);
                q[0] = (pleft[0] & pcondition[0]) | (pright[0] & ~pcondition[0]);
                q[1] = (pleft[1] & pcondition[1]) | (pright[1] & ~pcondition[1]);
                q[2] = (pleft[2] & pcondition[2]) | (pright[2] & ~pcondition[2]);
                q[3] = (pleft[3] & pcondition[3]) | (pright[3] & ~pcondition[3]);
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.Floor_AcceleratedTypes"/>
            public static TypeCodeFlags Floor_AcceleratedTypes {
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

            /// <inheritdoc cref="IWVectorTraits256.Floor(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<float> Floor(Vector256<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Floor(value);
#else
                return Floor_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Floor(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Floor(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Floor(value);
#else
                return Floor_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Floor(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<float> Floor_Base(Vector256<float> value) {
                Vector256<float> rt = value;
                float* p = (float*)&rt;
                p[0] = MathF.Floor(p[0]);
                p[1] = MathF.Floor(p[1]);
                p[2] = MathF.Floor(p[2]);
                p[3] = MathF.Floor(p[3]);
                p[4] = MathF.Floor(p[4]);
                p[5] = MathF.Floor(p[5]);
                p[6] = MathF.Floor(p[6]);
                p[7] = MathF.Floor(p[7]);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Floor(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<double> Floor_Base(Vector256<double> value) {
                Vector256<double> rt = value;
                double* p = (double*)&rt;
                p[0] = Math.Floor(p[0]);
                p[1] = Math.Floor(p[1]);
                p[2] = Math.Floor(p[2]);
                p[3] = Math.Floor(p[3]);
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
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<int> condition);
#else
                Vector256<int> condition = default;
#endif // NET5_0_OR_GREATER
                int* pcondition = (int*)&condition;
                float* pleft = (float*)&left;
                float* pright = (float*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                pcondition[2] = BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                pcondition[3] = BitUtil.ToInt32Mask(pleft[3] > pright[3]);
                pcondition[4] = BitUtil.ToInt32Mask(pleft[4] > pright[4]);
                pcondition[5] = BitUtil.ToInt32Mask(pleft[5] > pright[5]);
                pcondition[6] = BitUtil.ToInt32Mask(pleft[6] > pright[6]);
                pcondition[7] = BitUtil.ToInt32Mask(pleft[7] > pright[7]);
                Vector256<float> rt = ConditionalSelect(condition.AsSingle(), left, right);
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
                long condition0 = BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                long condition1 = BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                long condition2 = BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                long condition3 = BitUtil.ToInt32Mask(pleft[3] > pright[3]);
                // result = (left & condition) | (right & ~condition);
                q[0] = (BitUtil.DoubleToInt64Bits(pleft[0]) & condition0) | (BitUtil.DoubleToInt64Bits(pright[0]) & ~condition0);
                q[1] = (BitUtil.DoubleToInt64Bits(pleft[1]) & condition1) | (BitUtil.DoubleToInt64Bits(pright[1]) & ~condition1);
                q[2] = (BitUtil.DoubleToInt64Bits(pleft[2]) & condition2) | (BitUtil.DoubleToInt64Bits(pright[2]) & ~condition2);
                q[3] = (BitUtil.DoubleToInt64Bits(pleft[3]) & condition3) | (BitUtil.DoubleToInt64Bits(pright[3]) & ~condition3);
                return rt.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> Max_Conditional(Vector256<sbyte> left, Vector256<sbyte> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<sbyte> condition);
#else
                Vector256<sbyte> condition = default;
#endif // NET5_0_OR_GREATER
                sbyte* pcondition = (sbyte*)&condition;
                sbyte* pleft = (sbyte*)&left;
                sbyte* pright = (sbyte*)&right;
                pcondition[0] = (sbyte)BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                pcondition[1] = (sbyte)BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                pcondition[2] = (sbyte)BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                pcondition[3] = (sbyte)BitUtil.ToInt32Mask(pleft[3] > pright[3]);
                pcondition[4] = (sbyte)BitUtil.ToInt32Mask(pleft[4] > pright[4]);
                pcondition[5] = (sbyte)BitUtil.ToInt32Mask(pleft[5] > pright[5]);
                pcondition[6] = (sbyte)BitUtil.ToInt32Mask(pleft[6] > pright[6]);
                pcondition[7] = (sbyte)BitUtil.ToInt32Mask(pleft[7] > pright[7]);
                pcondition[8] = (sbyte)BitUtil.ToInt32Mask(pleft[8] > pright[8]);
                pcondition[9] = (sbyte)BitUtil.ToInt32Mask(pleft[9] > pright[9]);
                pcondition[10] = (sbyte)BitUtil.ToInt32Mask(pleft[10] > pright[10]);
                pcondition[11] = (sbyte)BitUtil.ToInt32Mask(pleft[11] > pright[11]);
                pcondition[12] = (sbyte)BitUtil.ToInt32Mask(pleft[12] > pright[12]);
                pcondition[13] = (sbyte)BitUtil.ToInt32Mask(pleft[13] > pright[13]);
                pcondition[14] = (sbyte)BitUtil.ToInt32Mask(pleft[14] > pright[14]);
                pcondition[15] = (sbyte)BitUtil.ToInt32Mask(pleft[15] > pright[15]);
                pcondition[16] = (sbyte)BitUtil.ToInt32Mask(pleft[16] > pright[16]);
                pcondition[17] = (sbyte)BitUtil.ToInt32Mask(pleft[17] > pright[17]);
                pcondition[18] = (sbyte)BitUtil.ToInt32Mask(pleft[18] > pright[18]);
                pcondition[19] = (sbyte)BitUtil.ToInt32Mask(pleft[19] > pright[19]);
                pcondition[20] = (sbyte)BitUtil.ToInt32Mask(pleft[20] > pright[20]);
                pcondition[21] = (sbyte)BitUtil.ToInt32Mask(pleft[21] > pright[21]);
                pcondition[22] = (sbyte)BitUtil.ToInt32Mask(pleft[22] > pright[22]);
                pcondition[23] = (sbyte)BitUtil.ToInt32Mask(pleft[23] > pright[23]);
                pcondition[24] = (sbyte)BitUtil.ToInt32Mask(pleft[24] > pright[24]);
                pcondition[25] = (sbyte)BitUtil.ToInt32Mask(pleft[25] > pright[25]);
                pcondition[26] = (sbyte)BitUtil.ToInt32Mask(pleft[26] > pright[26]);
                pcondition[27] = (sbyte)BitUtil.ToInt32Mask(pleft[27] > pright[27]);
                pcondition[28] = (sbyte)BitUtil.ToInt32Mask(pleft[28] > pright[28]);
                pcondition[29] = (sbyte)BitUtil.ToInt32Mask(pleft[29] > pright[29]);
                pcondition[30] = (sbyte)BitUtil.ToInt32Mask(pleft[30] > pright[30]);
                pcondition[31] = (sbyte)BitUtil.ToInt32Mask(pleft[31] > pright[31]);
                Vector256<sbyte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<byte> Max_Conditional(Vector256<byte> left, Vector256<byte> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<sbyte> condition);
#else
                Vector256<sbyte> condition = default;
#endif // NET5_0_OR_GREATER
                sbyte* pcondition = (sbyte*)&condition;
                byte* pleft = (byte*)&left;
                byte* pright = (byte*)&right;
                pcondition[0] = (sbyte)BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                pcondition[1] = (sbyte)BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                pcondition[2] = (sbyte)BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                pcondition[3] = (sbyte)BitUtil.ToInt32Mask(pleft[3] > pright[3]);
                pcondition[4] = (sbyte)BitUtil.ToInt32Mask(pleft[4] > pright[4]);
                pcondition[5] = (sbyte)BitUtil.ToInt32Mask(pleft[5] > pright[5]);
                pcondition[6] = (sbyte)BitUtil.ToInt32Mask(pleft[6] > pright[6]);
                pcondition[7] = (sbyte)BitUtil.ToInt32Mask(pleft[7] > pright[7]);
                pcondition[8] = (sbyte)BitUtil.ToInt32Mask(pleft[8] > pright[8]);
                pcondition[9] = (sbyte)BitUtil.ToInt32Mask(pleft[9] > pright[9]);
                pcondition[10] = (sbyte)BitUtil.ToInt32Mask(pleft[10] > pright[10]);
                pcondition[11] = (sbyte)BitUtil.ToInt32Mask(pleft[11] > pright[11]);
                pcondition[12] = (sbyte)BitUtil.ToInt32Mask(pleft[12] > pright[12]);
                pcondition[13] = (sbyte)BitUtil.ToInt32Mask(pleft[13] > pright[13]);
                pcondition[14] = (sbyte)BitUtil.ToInt32Mask(pleft[14] > pright[14]);
                pcondition[15] = (sbyte)BitUtil.ToInt32Mask(pleft[15] > pright[15]);
                pcondition[16] = (sbyte)BitUtil.ToInt32Mask(pleft[16] > pright[16]);
                pcondition[17] = (sbyte)BitUtil.ToInt32Mask(pleft[17] > pright[17]);
                pcondition[18] = (sbyte)BitUtil.ToInt32Mask(pleft[18] > pright[18]);
                pcondition[19] = (sbyte)BitUtil.ToInt32Mask(pleft[19] > pright[19]);
                pcondition[20] = (sbyte)BitUtil.ToInt32Mask(pleft[20] > pright[20]);
                pcondition[21] = (sbyte)BitUtil.ToInt32Mask(pleft[21] > pright[21]);
                pcondition[22] = (sbyte)BitUtil.ToInt32Mask(pleft[22] > pright[22]);
                pcondition[23] = (sbyte)BitUtil.ToInt32Mask(pleft[23] > pright[23]);
                pcondition[24] = (sbyte)BitUtil.ToInt32Mask(pleft[24] > pright[24]);
                pcondition[25] = (sbyte)BitUtil.ToInt32Mask(pleft[25] > pright[25]);
                pcondition[26] = (sbyte)BitUtil.ToInt32Mask(pleft[26] > pright[26]);
                pcondition[27] = (sbyte)BitUtil.ToInt32Mask(pleft[27] > pright[27]);
                pcondition[28] = (sbyte)BitUtil.ToInt32Mask(pleft[28] > pright[28]);
                pcondition[29] = (sbyte)BitUtil.ToInt32Mask(pleft[29] > pright[29]);
                pcondition[30] = (sbyte)BitUtil.ToInt32Mask(pleft[30] > pright[30]);
                pcondition[31] = (sbyte)BitUtil.ToInt32Mask(pleft[31] > pright[31]);
                Vector256<byte> rt = ConditionalSelect(condition.AsByte(), left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> Max_Conditional(Vector256<short> left, Vector256<short> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<short> condition);
#else
                Vector256<short> condition = default;
#endif // NET5_0_OR_GREATER
                short* pcondition = (short*)&condition;
                short* pleft = (short*)&left;
                short* pright = (short*)&right;
                pcondition[0] = (short)BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                pcondition[1] = (short)BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                pcondition[2] = (short)BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                pcondition[3] = (short)BitUtil.ToInt32Mask(pleft[3] > pright[3]);
                pcondition[4] = (short)BitUtil.ToInt32Mask(pleft[4] > pright[4]);
                pcondition[5] = (short)BitUtil.ToInt32Mask(pleft[5] > pright[5]);
                pcondition[6] = (short)BitUtil.ToInt32Mask(pleft[6] > pright[6]);
                pcondition[7] = (short)BitUtil.ToInt32Mask(pleft[7] > pright[7]);
                pcondition[8] = (short)BitUtil.ToInt32Mask(pleft[8] > pright[8]);
                pcondition[9] = (short)BitUtil.ToInt32Mask(pleft[9] > pright[9]);
                pcondition[10] = (short)BitUtil.ToInt32Mask(pleft[10] > pright[10]);
                pcondition[11] = (short)BitUtil.ToInt32Mask(pleft[11] > pright[11]);
                pcondition[12] = (short)BitUtil.ToInt32Mask(pleft[12] > pright[12]);
                pcondition[13] = (short)BitUtil.ToInt32Mask(pleft[13] > pright[13]);
                pcondition[14] = (short)BitUtil.ToInt32Mask(pleft[14] > pright[14]);
                pcondition[15] = (short)BitUtil.ToInt32Mask(pleft[15] > pright[15]);
                Vector256<short> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ushort> Max_Conditional(Vector256<ushort> left, Vector256<ushort> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<short> condition);
#else
                Vector256<short> condition = default;
#endif // NET5_0_OR_GREATER
                short* pcondition = (short*)&condition;
                ushort* pleft = (ushort*)&left;
                ushort* pright = (ushort*)&right;
                pcondition[0] = (short)BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                pcondition[1] = (short)BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                pcondition[2] = (short)BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                pcondition[3] = (short)BitUtil.ToInt32Mask(pleft[3] > pright[3]);
                pcondition[4] = (short)BitUtil.ToInt32Mask(pleft[4] > pright[4]);
                pcondition[5] = (short)BitUtil.ToInt32Mask(pleft[5] > pright[5]);
                pcondition[6] = (short)BitUtil.ToInt32Mask(pleft[6] > pright[6]);
                pcondition[7] = (short)BitUtil.ToInt32Mask(pleft[7] > pright[7]);
                pcondition[8] = (short)BitUtil.ToInt32Mask(pleft[8] > pright[8]);
                pcondition[9] = (short)BitUtil.ToInt32Mask(pleft[9] > pright[9]);
                pcondition[10] = (short)BitUtil.ToInt32Mask(pleft[10] > pright[10]);
                pcondition[11] = (short)BitUtil.ToInt32Mask(pleft[11] > pright[11]);
                pcondition[12] = (short)BitUtil.ToInt32Mask(pleft[12] > pright[12]);
                pcondition[13] = (short)BitUtil.ToInt32Mask(pleft[13] > pright[13]);
                pcondition[14] = (short)BitUtil.ToInt32Mask(pleft[14] > pright[14]);
                pcondition[15] = (short)BitUtil.ToInt32Mask(pleft[15] > pright[15]);
                Vector256<ushort> rt = ConditionalSelect(condition.AsUInt16(), left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> Max_Conditional(Vector256<int> left, Vector256<int> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<int> condition);
#else
                Vector256<int> condition = default;
#endif // NET5_0_OR_GREATER
                int* pcondition = (int*)&condition;
                int* pleft = (int*)&left;
                int* pright = (int*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                pcondition[2] = BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                pcondition[3] = BitUtil.ToInt32Mask(pleft[3] > pright[3]);
                pcondition[4] = BitUtil.ToInt32Mask(pleft[4] > pright[4]);
                pcondition[5] = BitUtil.ToInt32Mask(pleft[5] > pright[5]);
                pcondition[6] = BitUtil.ToInt32Mask(pleft[6] > pright[6]);
                pcondition[7] = BitUtil.ToInt32Mask(pleft[7] > pright[7]);
                Vector256<int> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<uint> Max_Conditional(Vector256<uint> left, Vector256<uint> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<int> condition);
#else
                Vector256<int> condition = default;
#endif // NET5_0_OR_GREATER
                int* pcondition = (int*)&condition;
                uint* pleft = (uint*)&left;
                uint* pright = (uint*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                pcondition[2] = BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                pcondition[3] = BitUtil.ToInt32Mask(pleft[3] > pright[3]);
                pcondition[4] = BitUtil.ToInt32Mask(pleft[4] > pright[4]);
                pcondition[5] = BitUtil.ToInt32Mask(pleft[5] > pright[5]);
                pcondition[6] = BitUtil.ToInt32Mask(pleft[6] > pright[6]);
                pcondition[7] = BitUtil.ToInt32Mask(pleft[7] > pright[7]);
                Vector256<uint> rt = ConditionalSelect(condition.AsUInt32(), left, right);
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
                long condition0 = BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                long condition1 = BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                long condition2 = BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                long condition3 = BitUtil.ToInt32Mask(pleft[3] > pright[3]);
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
                long condition0 = BitUtil.ToInt32Mask(pleft[0] > pright[0]);
                long condition1 = BitUtil.ToInt32Mask(pleft[1] > pright[1]);
                long condition2 = BitUtil.ToInt32Mask(pleft[2] > pright[2]);
                long condition3 = BitUtil.ToInt32Mask(pleft[3] > pright[3]);
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
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<int> condition);
#else
                Vector256<int> condition = default;
#endif // NET5_0_OR_GREATER
                int* pcondition = (int*)&condition;
                float* pleft = (float*)&left;
                float* pright = (float*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                pcondition[2] = BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                pcondition[3] = BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                pcondition[4] = BitUtil.ToInt32Mask(pleft[4] < pright[4]);
                pcondition[5] = BitUtil.ToInt32Mask(pleft[5] < pright[5]);
                pcondition[6] = BitUtil.ToInt32Mask(pleft[6] < pright[6]);
                pcondition[7] = BitUtil.ToInt32Mask(pleft[7] < pright[7]);
                Vector256<float> rt = ConditionalSelect(condition.AsSingle(), left, right);
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
                long condition0 = BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                long condition1 = BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                long condition2 = BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                long condition3 = BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                // result = (left & condition) | (right & ~condition);
                q[0] = (BitUtil.DoubleToInt64Bits(pleft[0]) & condition0) | (BitUtil.DoubleToInt64Bits(pright[0]) & ~condition0);
                q[1] = (BitUtil.DoubleToInt64Bits(pleft[1]) & condition1) | (BitUtil.DoubleToInt64Bits(pright[1]) & ~condition1);
                q[2] = (BitUtil.DoubleToInt64Bits(pleft[2]) & condition2) | (BitUtil.DoubleToInt64Bits(pright[2]) & ~condition2);
                q[3] = (BitUtil.DoubleToInt64Bits(pleft[3]) & condition3) | (BitUtil.DoubleToInt64Bits(pright[3]) & ~condition3);
                return rt.AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{sbyte}, Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> Min_Conditional(Vector256<sbyte> left, Vector256<sbyte> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<sbyte> condition);
#else
                Vector256<sbyte> condition = default;
#endif // NET5_0_OR_GREATER
                sbyte* pcondition = (sbyte*)&condition;
                sbyte* pleft = (sbyte*)&left;
                sbyte* pright = (sbyte*)&right;
                pcondition[0] = (sbyte)BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                pcondition[1] = (sbyte)BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                pcondition[2] = (sbyte)BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                pcondition[3] = (sbyte)BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                pcondition[4] = (sbyte)BitUtil.ToInt32Mask(pleft[4] < pright[4]);
                pcondition[5] = (sbyte)BitUtil.ToInt32Mask(pleft[5] < pright[5]);
                pcondition[6] = (sbyte)BitUtil.ToInt32Mask(pleft[6] < pright[6]);
                pcondition[7] = (sbyte)BitUtil.ToInt32Mask(pleft[7] < pright[7]);
                pcondition[8] = (sbyte)BitUtil.ToInt32Mask(pleft[8] < pright[8]);
                pcondition[9] = (sbyte)BitUtil.ToInt32Mask(pleft[9] < pright[9]);
                pcondition[10] = (sbyte)BitUtil.ToInt32Mask(pleft[10] < pright[10]);
                pcondition[11] = (sbyte)BitUtil.ToInt32Mask(pleft[11] < pright[11]);
                pcondition[12] = (sbyte)BitUtil.ToInt32Mask(pleft[12] < pright[12]);
                pcondition[13] = (sbyte)BitUtil.ToInt32Mask(pleft[13] < pright[13]);
                pcondition[14] = (sbyte)BitUtil.ToInt32Mask(pleft[14] < pright[14]);
                pcondition[15] = (sbyte)BitUtil.ToInt32Mask(pleft[15] < pright[15]);
                pcondition[16] = (sbyte)BitUtil.ToInt32Mask(pleft[16] < pright[16]);
                pcondition[17] = (sbyte)BitUtil.ToInt32Mask(pleft[17] < pright[17]);
                pcondition[18] = (sbyte)BitUtil.ToInt32Mask(pleft[18] < pright[18]);
                pcondition[19] = (sbyte)BitUtil.ToInt32Mask(pleft[19] < pright[19]);
                pcondition[20] = (sbyte)BitUtil.ToInt32Mask(pleft[20] < pright[20]);
                pcondition[21] = (sbyte)BitUtil.ToInt32Mask(pleft[21] < pright[21]);
                pcondition[22] = (sbyte)BitUtil.ToInt32Mask(pleft[22] < pright[22]);
                pcondition[23] = (sbyte)BitUtil.ToInt32Mask(pleft[23] < pright[23]);
                pcondition[24] = (sbyte)BitUtil.ToInt32Mask(pleft[24] < pright[24]);
                pcondition[25] = (sbyte)BitUtil.ToInt32Mask(pleft[25] < pright[25]);
                pcondition[26] = (sbyte)BitUtil.ToInt32Mask(pleft[26] < pright[26]);
                pcondition[27] = (sbyte)BitUtil.ToInt32Mask(pleft[27] < pright[27]);
                pcondition[28] = (sbyte)BitUtil.ToInt32Mask(pleft[28] < pright[28]);
                pcondition[29] = (sbyte)BitUtil.ToInt32Mask(pleft[29] < pright[29]);
                pcondition[30] = (sbyte)BitUtil.ToInt32Mask(pleft[30] < pright[30]);
                pcondition[31] = (sbyte)BitUtil.ToInt32Mask(pleft[31] < pright[31]);
                Vector256<sbyte> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{byte}, Vector256{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<byte> Min_Conditional(Vector256<byte> left, Vector256<byte> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<sbyte> condition);
#else
                Vector256<sbyte> condition = default;
#endif // NET5_0_OR_GREATER
                sbyte* pcondition = (sbyte*)&condition;
                byte* pleft = (byte*)&left;
                byte* pright = (byte*)&right;
                pcondition[0] = (sbyte)BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                pcondition[1] = (sbyte)BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                pcondition[2] = (sbyte)BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                pcondition[3] = (sbyte)BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                pcondition[4] = (sbyte)BitUtil.ToInt32Mask(pleft[4] < pright[4]);
                pcondition[5] = (sbyte)BitUtil.ToInt32Mask(pleft[5] < pright[5]);
                pcondition[6] = (sbyte)BitUtil.ToInt32Mask(pleft[6] < pright[6]);
                pcondition[7] = (sbyte)BitUtil.ToInt32Mask(pleft[7] < pright[7]);
                pcondition[8] = (sbyte)BitUtil.ToInt32Mask(pleft[8] < pright[8]);
                pcondition[9] = (sbyte)BitUtil.ToInt32Mask(pleft[9] < pright[9]);
                pcondition[10] = (sbyte)BitUtil.ToInt32Mask(pleft[10] < pright[10]);
                pcondition[11] = (sbyte)BitUtil.ToInt32Mask(pleft[11] < pright[11]);
                pcondition[12] = (sbyte)BitUtil.ToInt32Mask(pleft[12] < pright[12]);
                pcondition[13] = (sbyte)BitUtil.ToInt32Mask(pleft[13] < pright[13]);
                pcondition[14] = (sbyte)BitUtil.ToInt32Mask(pleft[14] < pright[14]);
                pcondition[15] = (sbyte)BitUtil.ToInt32Mask(pleft[15] < pright[15]);
                pcondition[16] = (sbyte)BitUtil.ToInt32Mask(pleft[16] < pright[16]);
                pcondition[17] = (sbyte)BitUtil.ToInt32Mask(pleft[17] < pright[17]);
                pcondition[18] = (sbyte)BitUtil.ToInt32Mask(pleft[18] < pright[18]);
                pcondition[19] = (sbyte)BitUtil.ToInt32Mask(pleft[19] < pright[19]);
                pcondition[20] = (sbyte)BitUtil.ToInt32Mask(pleft[20] < pright[20]);
                pcondition[21] = (sbyte)BitUtil.ToInt32Mask(pleft[21] < pright[21]);
                pcondition[22] = (sbyte)BitUtil.ToInt32Mask(pleft[22] < pright[22]);
                pcondition[23] = (sbyte)BitUtil.ToInt32Mask(pleft[23] < pright[23]);
                pcondition[24] = (sbyte)BitUtil.ToInt32Mask(pleft[24] < pright[24]);
                pcondition[25] = (sbyte)BitUtil.ToInt32Mask(pleft[25] < pright[25]);
                pcondition[26] = (sbyte)BitUtil.ToInt32Mask(pleft[26] < pright[26]);
                pcondition[27] = (sbyte)BitUtil.ToInt32Mask(pleft[27] < pright[27]);
                pcondition[28] = (sbyte)BitUtil.ToInt32Mask(pleft[28] < pright[28]);
                pcondition[29] = (sbyte)BitUtil.ToInt32Mask(pleft[29] < pright[29]);
                pcondition[30] = (sbyte)BitUtil.ToInt32Mask(pleft[30] < pright[30]);
                pcondition[31] = (sbyte)BitUtil.ToInt32Mask(pleft[31] < pright[31]);
                Vector256<byte> rt = ConditionalSelect(condition.AsByte(), left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{short}, Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> Min_Conditional(Vector256<short> left, Vector256<short> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<short> condition);
#else
                Vector256<short> condition = default;
#endif // NET5_0_OR_GREATER
                short* pcondition = (short*)&condition;
                short* pleft = (short*)&left;
                short* pright = (short*)&right;
                pcondition[0] = (short)BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                pcondition[1] = (short)BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                pcondition[2] = (short)BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                pcondition[3] = (short)BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                pcondition[4] = (short)BitUtil.ToInt32Mask(pleft[4] < pright[4]);
                pcondition[5] = (short)BitUtil.ToInt32Mask(pleft[5] < pright[5]);
                pcondition[6] = (short)BitUtil.ToInt32Mask(pleft[6] < pright[6]);
                pcondition[7] = (short)BitUtil.ToInt32Mask(pleft[7] < pright[7]);
                pcondition[8] = (short)BitUtil.ToInt32Mask(pleft[8] < pright[8]);
                pcondition[9] = (short)BitUtil.ToInt32Mask(pleft[9] < pright[9]);
                pcondition[10] = (short)BitUtil.ToInt32Mask(pleft[10] < pright[10]);
                pcondition[11] = (short)BitUtil.ToInt32Mask(pleft[11] < pright[11]);
                pcondition[12] = (short)BitUtil.ToInt32Mask(pleft[12] < pright[12]);
                pcondition[13] = (short)BitUtil.ToInt32Mask(pleft[13] < pright[13]);
                pcondition[14] = (short)BitUtil.ToInt32Mask(pleft[14] < pright[14]);
                pcondition[15] = (short)BitUtil.ToInt32Mask(pleft[15] < pright[15]);
                Vector256<short> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{ushort}, Vector256{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ushort> Min_Conditional(Vector256<ushort> left, Vector256<ushort> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<short> condition);
#else
                Vector256<short> condition = default;
#endif // NET5_0_OR_GREATER
                short* pcondition = (short*)&condition;
                ushort* pleft = (ushort*)&left;
                ushort* pright = (ushort*)&right;
                pcondition[0] = (short)BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                pcondition[1] = (short)BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                pcondition[2] = (short)BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                pcondition[3] = (short)BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                pcondition[4] = (short)BitUtil.ToInt32Mask(pleft[4] < pright[4]);
                pcondition[5] = (short)BitUtil.ToInt32Mask(pleft[5] < pright[5]);
                pcondition[6] = (short)BitUtil.ToInt32Mask(pleft[6] < pright[6]);
                pcondition[7] = (short)BitUtil.ToInt32Mask(pleft[7] < pright[7]);
                pcondition[8] = (short)BitUtil.ToInt32Mask(pleft[8] < pright[8]);
                pcondition[9] = (short)BitUtil.ToInt32Mask(pleft[9] < pright[9]);
                pcondition[10] = (short)BitUtil.ToInt32Mask(pleft[10] < pright[10]);
                pcondition[11] = (short)BitUtil.ToInt32Mask(pleft[11] < pright[11]);
                pcondition[12] = (short)BitUtil.ToInt32Mask(pleft[12] < pright[12]);
                pcondition[13] = (short)BitUtil.ToInt32Mask(pleft[13] < pright[13]);
                pcondition[14] = (short)BitUtil.ToInt32Mask(pleft[14] < pright[14]);
                pcondition[15] = (short)BitUtil.ToInt32Mask(pleft[15] < pright[15]);
                Vector256<ushort> rt = ConditionalSelect(condition.AsUInt16(), left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{int}, Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> Min_Conditional(Vector256<int> left, Vector256<int> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<int> condition);
#else
                Vector256<int> condition = default;
#endif // NET5_0_OR_GREATER
                int* pcondition = (int*)&condition;
                int* pleft = (int*)&left;
                int* pright = (int*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                pcondition[2] = BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                pcondition[3] = BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                pcondition[4] = BitUtil.ToInt32Mask(pleft[4] < pright[4]);
                pcondition[5] = BitUtil.ToInt32Mask(pleft[5] < pright[5]);
                pcondition[6] = BitUtil.ToInt32Mask(pleft[6] < pright[6]);
                pcondition[7] = BitUtil.ToInt32Mask(pleft[7] < pright[7]);
                Vector256<int> rt = ConditionalSelect(condition, left, right);
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{uint}, Vector256{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<uint> Min_Conditional(Vector256<uint> left, Vector256<uint> right) {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<int> condition);
#else
                Vector256<int> condition = default;
#endif // NET5_0_OR_GREATER
                int* pcondition = (int*)&condition;
                uint* pleft = (uint*)&left;
                uint* pright = (uint*)&right;
                pcondition[0] = BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                pcondition[1] = BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                pcondition[2] = BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                pcondition[3] = BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                pcondition[4] = BitUtil.ToInt32Mask(pleft[4] < pright[4]);
                pcondition[5] = BitUtil.ToInt32Mask(pleft[5] < pright[5]);
                pcondition[6] = BitUtil.ToInt32Mask(pleft[6] < pright[6]);
                pcondition[7] = BitUtil.ToInt32Mask(pleft[7] < pright[7]);
                Vector256<uint> rt = ConditionalSelect(condition.AsUInt32(), left, right);
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
                long condition0 = BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                long condition1 = BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                long condition2 = BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                long condition3 = BitUtil.ToInt32Mask(pleft[3] < pright[3]);
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
                long condition0 = BitUtil.ToInt32Mask(pleft[0] < pright[0]);
                long condition1 = BitUtil.ToInt32Mask(pleft[1] < pright[1]);
                long condition2 = BitUtil.ToInt32Mask(pleft[2] < pright[2]);
                long condition3 = BitUtil.ToInt32Mask(pleft[3] < pright[3]);
                // result = (left & condition) | (right & ~condition);
                q[0] = ((long)(pleft[0]) & condition0) | ((long)(pright[0]) & ~condition0);
                q[1] = ((long)(pleft[1]) & condition1) | ((long)(pright[1]) & ~condition1);
                q[2] = ((long)(pleft[2]) & condition2) | ((long)(pright[2]) & ~condition2);
                q[3] = ((long)(pleft[3]) & condition3) | ((long)(pright[3]) & ~condition3);
                return rt.AsUInt64();
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
                return Negate_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<double> Negate(Vector256<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Negate(value);
#else
                return Negate_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> Negate(Vector256<sbyte> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Negate(value);
#else
                return Negate_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> Negate(Vector256<short> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Negate(value);
#else
                return Negate_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> Negate(Vector256<int> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Negate(value);
#else
                return Negate_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> Negate(Vector256<long> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.Negate(value);
#else
                return Negate_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<float> Negate_Base(Vector256<float> value) {
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
            public static unsafe Vector256<double> Negate_Base(Vector256<double> value) {
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
            public static unsafe Vector256<sbyte> Negate_Base(Vector256<sbyte> value) {
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
            public static unsafe Vector256<short> Negate_Base(Vector256<short> value) {
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
            public static unsafe Vector256<int> Negate_Base(Vector256<int> value) {
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
            public static unsafe Vector256<long> Negate_Base(Vector256<long> value) {
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
                return OnesComplement_Base(vector);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.OnesComplement{T}(Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<T> OnesComplement_Base<T>(Vector256<T> vector) where T : struct {
                Vector256<T> rt = vector;
                ulong* p = (ulong*)&rt;
                p[0] = ~p[0];
                p[1] = ~p[1];
                p[2] = ~p[2];
                p[3] = ~p[3];
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftLeft_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftLeft(Vector256<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftLeft(Vector256<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftLeft(Vector256<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftLeft(Vector256<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftLeft(Vector256<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftLeft(Vector256<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftLeft(Vector256<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftLeft(Vector256<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> ShiftLeft_Base(Vector256<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{byte}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<byte> ShiftLeft_Base(Vector256<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> ShiftLeft_Base(Vector256<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ushort> ShiftLeft_Base(Vector256<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{int}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> ShiftLeft_Base(Vector256<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<uint> ShiftLeft_Base(Vector256<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{long}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> ShiftLeft_Base(Vector256<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ulong> ShiftLeft_Base(Vector256<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftLeftFast(Vector256<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftLeftFast(Vector256<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftLeftFast(Vector256<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftLeftFast(Vector256<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftLeftFast(Vector256<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftLeftFast(Vector256<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftLeftFast(Vector256<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftLeftFast(Vector256<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> ShiftLeftFast_Base(Vector256<sbyte> value, int shiftAmount) {
                return ShiftLeftFast_Base(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{byte}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<byte> ShiftLeftFast_Base(Vector256<byte> value, int shiftAmount) {
                Vector256<byte> rt = value;
                byte* p = (byte*)&rt;
                p[0] <<= shiftAmount;
                p[1] <<= shiftAmount;
                p[2] <<= shiftAmount;
                p[3] <<= shiftAmount;
                p[4] <<= shiftAmount;
                p[5] <<= shiftAmount;
                p[6] <<= shiftAmount;
                p[7] <<= shiftAmount;
                p[8] <<= shiftAmount;
                p[9] <<= shiftAmount;
                p[10] <<= shiftAmount;
                p[11] <<= shiftAmount;
                p[12] <<= shiftAmount;
                p[13] <<= shiftAmount;
                p[14] <<= shiftAmount;
                p[15] <<= shiftAmount;
                p[16] <<= shiftAmount;
                p[17] <<= shiftAmount;
                p[18] <<= shiftAmount;
                p[19] <<= shiftAmount;
                p[20] <<= shiftAmount;
                p[21] <<= shiftAmount;
                p[22] <<= shiftAmount;
                p[23] <<= shiftAmount;
                p[24] <<= shiftAmount;
                p[25] <<= shiftAmount;
                p[26] <<= shiftAmount;
                p[27] <<= shiftAmount;
                p[28] <<= shiftAmount;
                p[29] <<= shiftAmount;
                p[30] <<= shiftAmount;
                p[31] <<= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> ShiftLeftFast_Base(Vector256<short> value, int shiftAmount) {
                Vector256<short> rt = value;
                short* p = (short*)&rt;
                p[0] <<= shiftAmount;
                p[1] <<= shiftAmount;
                p[2] <<= shiftAmount;
                p[3] <<= shiftAmount;
                p[4] <<= shiftAmount;
                p[5] <<= shiftAmount;
                p[6] <<= shiftAmount;
                p[7] <<= shiftAmount;
                p[8] <<= shiftAmount;
                p[9] <<= shiftAmount;
                p[10] <<= shiftAmount;
                p[11] <<= shiftAmount;
                p[12] <<= shiftAmount;
                p[13] <<= shiftAmount;
                p[14] <<= shiftAmount;
                p[15] <<= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ushort> ShiftLeftFast_Base(Vector256<ushort> value, int shiftAmount) {
                return ShiftLeftFast_Base(value.AsInt16(), shiftAmount).AsUInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{int}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> ShiftLeftFast_Base(Vector256<int> value, int shiftAmount) {
                Vector256<int> rt = value;
                int* p = (int*)&rt;
                p[0] <<= shiftAmount;
                p[1] <<= shiftAmount;
                p[2] <<= shiftAmount;
                p[3] <<= shiftAmount;
                p[4] <<= shiftAmount;
                p[5] <<= shiftAmount;
                p[6] <<= shiftAmount;
                p[7] <<= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<uint> ShiftLeftFast_Base(Vector256<uint> value, int shiftAmount) {
                return ShiftLeftFast_Base(value.AsInt32(), shiftAmount).AsUInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{long}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> ShiftLeftFast_Base(Vector256<long> value, int shiftAmount) {
                Vector256<long> rt = value;
                long* p = (long*)&rt;
                p[0] <<= shiftAmount;
                p[1] <<= shiftAmount;
                p[2] <<= shiftAmount;
                p[3] <<= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ulong> ShiftLeftFast_Base(Vector256<ulong> value, int shiftAmount) {
                return ShiftLeftFast_Base(value.AsInt64(), shiftAmount).AsUInt64();
            }


            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.Int32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightArithmetic(Vector256<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftRightArithmetic(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightArithmetic_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightArithmetic(Vector256<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmetic_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightArithmetic(Vector256<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmetic_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmetic(Vector256<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftRightArithmetic(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightArithmetic_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> ShiftRightArithmetic_Base(Vector256<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> ShiftRightArithmetic_Base(Vector256<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{int}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> ShiftRightArithmetic_Base(Vector256<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{long}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> ShiftRightArithmetic_Base(Vector256<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightArithmeticFast(Vector256<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftRightArithmetic(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightArithmeticFast(Vector256<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightArithmeticFast(Vector256<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightArithmeticFast(Vector256<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightArithmetic(value, shiftAmount);
#else
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> ShiftRightArithmeticFast_Base(Vector256<sbyte> value, int shiftAmount) {
                Vector256<sbyte> rt = value;
                sbyte* p = (sbyte*)&rt;
                p[0] >>= shiftAmount;
                p[1] >>= shiftAmount;
                p[2] >>= shiftAmount;
                p[3] >>= shiftAmount;
                p[4] >>= shiftAmount;
                p[5] >>= shiftAmount;
                p[6] >>= shiftAmount;
                p[7] >>= shiftAmount;
                p[8] >>= shiftAmount;
                p[9] >>= shiftAmount;
                p[10] >>= shiftAmount;
                p[11] >>= shiftAmount;
                p[12] >>= shiftAmount;
                p[13] >>= shiftAmount;
                p[14] >>= shiftAmount;
                p[15] >>= shiftAmount;
                p[16] >>= shiftAmount;
                p[17] >>= shiftAmount;
                p[18] >>= shiftAmount;
                p[19] >>= shiftAmount;
                p[20] >>= shiftAmount;
                p[21] >>= shiftAmount;
                p[22] >>= shiftAmount;
                p[23] >>= shiftAmount;
                p[24] >>= shiftAmount;
                p[25] >>= shiftAmount;
                p[26] >>= shiftAmount;
                p[27] >>= shiftAmount;
                p[28] >>= shiftAmount;
                p[29] >>= shiftAmount;
                p[30] >>= shiftAmount;
                p[31] >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> ShiftRightArithmeticFast_Base(Vector256<short> value, int shiftAmount) {
                Vector256<short> rt = value;
                short* p = (short*)&rt;
                p[0] >>= shiftAmount;
                p[1] >>= shiftAmount;
                p[2] >>= shiftAmount;
                p[3] >>= shiftAmount;
                p[4] >>= shiftAmount;
                p[5] >>= shiftAmount;
                p[6] >>= shiftAmount;
                p[7] >>= shiftAmount;
                p[8] >>= shiftAmount;
                p[9] >>= shiftAmount;
                p[10] >>= shiftAmount;
                p[11] >>= shiftAmount;
                p[12] >>= shiftAmount;
                p[13] >>= shiftAmount;
                p[14] >>= shiftAmount;
                p[15] >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{int}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> ShiftRightArithmeticFast_Base(Vector256<int> value, int shiftAmount) {
                Vector256<int> rt = value;
                int* p = (int*)&rt;
                p[0] >>= shiftAmount;
                p[1] >>= shiftAmount;
                p[2] >>= shiftAmount;
                p[3] >>= shiftAmount;
                p[4] >>= shiftAmount;
                p[5] >>= shiftAmount;
                p[6] >>= shiftAmount;
                p[7] >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{long}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> ShiftRightArithmeticFast_Base(Vector256<long> value, int shiftAmount) {
                Vector256<long> rt = value;
                long* p = (long*)&rt;
                p[0] >>= shiftAmount;
                p[1] >>= shiftAmount;
                p[2] >>= shiftAmount;
                p[3] >>= shiftAmount;
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    return rt;
                }
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightLogical(Vector256<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftRightLogical(Vector256<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightLogical(Vector256<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftRightLogical(Vector256<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightLogical(Vector256<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftRightLogical(Vector256<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightLogical(Vector256<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftRightLogical(Vector256<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> ShiftRightLogical_Base(Vector256<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{byte}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<byte> ShiftRightLogical_Base(Vector256<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> ShiftRightLogical_Base(Vector256<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ushort> ShiftRightLogical_Base(Vector256<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{int}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> ShiftRightLogical_Base(Vector256<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<uint> ShiftRightLogical_Base(Vector256<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{long}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> ShiftRightLogical_Base(Vector256<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ulong> ShiftRightLogical_Base(Vector256<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<sbyte> ShiftRightLogicalFast(Vector256<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightLogicalFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<byte> ShiftRightLogicalFast(Vector256<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
                return ShiftRightLogicalFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<short> ShiftRightLogicalFast(Vector256<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogicalFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ushort> ShiftRightLogicalFast(Vector256<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogicalFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<int> ShiftRightLogicalFast(Vector256<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogicalFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<uint> ShiftRightLogicalFast(Vector256<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogicalFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<long> ShiftRightLogicalFast(Vector256<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogicalFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector256<ulong> ShiftRightLogicalFast(Vector256<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector256.ShiftRightLogical(value, shiftAmount);
#else
                return ShiftRightLogicalFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{sbyte}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<sbyte> ShiftRightLogicalFast_Base(Vector256<sbyte> value, int shiftAmount) {
                return ShiftRightLogicalFast_Base(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{byte}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<byte> ShiftRightLogicalFast_Base(Vector256<byte> value, int shiftAmount) {
                Vector256<byte> rt = value;
                byte* p = (byte*)&rt;
                p[0] >>= shiftAmount;
                p[1] >>= shiftAmount;
                p[2] >>= shiftAmount;
                p[3] >>= shiftAmount;
                p[4] >>= shiftAmount;
                p[5] >>= shiftAmount;
                p[6] >>= shiftAmount;
                p[7] >>= shiftAmount;
                p[8] >>= shiftAmount;
                p[9] >>= shiftAmount;
                p[10] >>= shiftAmount;
                p[11] >>= shiftAmount;
                p[12] >>= shiftAmount;
                p[13] >>= shiftAmount;
                p[14] >>= shiftAmount;
                p[15] >>= shiftAmount;
                p[16] >>= shiftAmount;
                p[17] >>= shiftAmount;
                p[18] >>= shiftAmount;
                p[19] >>= shiftAmount;
                p[20] >>= shiftAmount;
                p[21] >>= shiftAmount;
                p[22] >>= shiftAmount;
                p[23] >>= shiftAmount;
                p[24] >>= shiftAmount;
                p[25] >>= shiftAmount;
                p[26] >>= shiftAmount;
                p[27] >>= shiftAmount;
                p[28] >>= shiftAmount;
                p[29] >>= shiftAmount;
                p[30] >>= shiftAmount;
                p[31] >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<short> ShiftRightLogicalFast_Base(Vector256<short> value, int shiftAmount) {
                return ShiftRightLogicalFast_Base(value.AsUInt16(), shiftAmount).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{ushort}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ushort> ShiftRightLogicalFast_Base(Vector256<ushort> value, int shiftAmount) {
                Vector256<ushort> rt = value;
                ushort* p = (ushort*)&rt;
                p[0] >>= shiftAmount;
                p[1] >>= shiftAmount;
                p[2] >>= shiftAmount;
                p[3] >>= shiftAmount;
                p[4] >>= shiftAmount;
                p[5] >>= shiftAmount;
                p[6] >>= shiftAmount;
                p[7] >>= shiftAmount;
                p[8] >>= shiftAmount;
                p[9] >>= shiftAmount;
                p[10] >>= shiftAmount;
                p[11] >>= shiftAmount;
                p[12] >>= shiftAmount;
                p[13] >>= shiftAmount;
                p[14] >>= shiftAmount;
                p[15] >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{int}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<int> ShiftRightLogicalFast_Base(Vector256<int> value, int shiftAmount) {
                return ShiftRightLogicalFast_Base(value.AsUInt32(), shiftAmount).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{uint}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<uint> ShiftRightLogicalFast_Base(Vector256<uint> value, int shiftAmount) {
                Vector256<uint> rt = value;
                uint* p = (uint*)&rt;
                p[0] >>= shiftAmount;
                p[1] >>= shiftAmount;
                p[2] >>= shiftAmount;
                p[3] >>= shiftAmount;
                p[4] >>= shiftAmount;
                p[5] >>= shiftAmount;
                p[6] >>= shiftAmount;
                p[7] >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{long}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<long> ShiftRightLogicalFast_Base(Vector256<long> value, int shiftAmount) {
                return ShiftRightLogicalFast_Base(value.AsUInt64(), shiftAmount).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{ulong}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<ulong> ShiftRightLogicalFast_Base(Vector256<ulong> value, int shiftAmount) {
                Vector256<ulong> rt = value;
                ulong* p = (ulong*)&rt;
                p[0] >>= shiftAmount;
                p[1] >>= shiftAmount;
                p[2] >>= shiftAmount;
                p[3] >>= shiftAmount;
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
                return Xor_Base(left, right);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits256.Xor{T}(Vector256{T}, Vector256{T})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector256<T> Xor_Base<T>(Vector256<T> left, Vector256<T> right) where T : struct {
#if NET5_0_OR_GREATER
                Unsafe.SkipInit(out Vector256<T> rt);
#else
                Vector256<T> rt = default;
#endif // NET5_0_OR_GREATER
                ulong* pleft = (ulong*)&left;
                ulong* pright = (ulong*)&right;
                ulong* q = (ulong*)&rt;
                // rt[i] := left[i] ^ right[i];
                q[0] = pleft[0] ^ pright[0];
                q[1] = pleft[1] ^ pright[1];
                q[2] = pleft[2] ^ pright[2];
                q[3] = pleft[3] ^ pright[3];
                return rt;
            }

#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
