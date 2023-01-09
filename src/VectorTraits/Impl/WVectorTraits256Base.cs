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
