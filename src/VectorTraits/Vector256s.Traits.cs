using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits {
    static partial class Vector256s {
        private static readonly IWVectorTraits256 _instance = WVectorTraits256Abstract.GetBestInstance(); // Best traits instance.
        private static readonly dynamic _instanceDynamic = _instance; // Best traits instance dynamic value.

        private static readonly string[] _traitsNames = {
            "WVectorTraits256Base",
            "WVectorTraits256Avx2"
        };

        private static readonly IWVectorTraits256[] _traitsInstances = {
            WVectorTraits256Base.Instance,
            WVectorTraits256Avx2.Instance
        };

        // Statics types (静态类型集).
        private static readonly Type[] _staticsTypes = {
            typeof(WVectorTraits256Base.Statics),
            typeof(WVectorTraits256Avx2.Statics)
        };

        /// <summary>Best traits instance (最佳特征实例). </summary>
        [CLSCompliant(false)]
        public static IWVectorTraits256 Instance {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return _instance; }
        }

        /// <summary>Best traits instance dynamic value (最佳特征实例动态值). </summary>
        public static dynamic InstanceDynamic {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return _instanceDynamic; }
        }

        /// <summary>Traits name list (特征名称列表). </summary>
        public static IReadOnlyList<string> TraitsNames {
            get { return _traitsNames; }
        }

        /// <summary>Traits instance list (特征实例列表). </summary>
        [CLSCompliant(false)]
        public static IReadOnlyList<IWVectorTraits256> TraitsInstances {
            get { return _traitsInstances; }
        }

        /// <summary>Statics types (静态类型集). </summary>
        public static IReadOnlyList<Type> StaticsTypes {
            get { return _staticsTypes; }
        }

        /// <summary>
        /// Get supported method list and output <paramref name="callback"/> (取得支持的方法列表并输出到  <paramref name="callback"/> ).
        /// </summary>
        /// <typeparam name="T">Delegate type (委托类型).</typeparam>
        /// <param name="callback">Output callback (输出的回调).</param>
        /// <param name="methodNames">Method name list (方法名列表).</param>
        /// <returns>Returns method count (返回方法数量)</returns>
        public static int GetSupportedMethodListCallback<T>(Action<T> callback, params string[] methodNames) where T : Delegate {
            return ReflectionUtil.GetSupportedMethodListCallback(callback, _staticsTypes, methodNames);
        }

        /// <summary>
        /// Get supported method list and fill (取得支持的方法列表并填充).
        /// </summary>
        /// <typeparam name="T">Delegate type (委托类型).</typeparam>
        /// <param name="output">Output target (输出目标).</param>
        /// <param name="methodNames">Method name list (方法名列表).</param>
        /// <returns>Returns method count (返回方法数量)</returns>
        public static int GetSupportedMethodListFill<T>(ICollection<T> output, params string[] methodNames) where T : Delegate {
            return ReflectionUtil.GetSupportedMethodListFill(output, _staticsTypes, methodNames);
        }

        /// <summary>
        /// Get supported method list (取得支持的方法列表).
        /// </summary>
        /// <typeparam name="T">Delegate type (委托类型).</typeparam>
        /// <param name="methodNames">Method name list (方法名列表).</param>
        /// <returns>Returns method list (返回方法列表)</returns>
        public static List<T> GetSupportedMethodList<T>(params string[] methodNames) where T : Delegate {
            return ReflectionUtil.GetSupportedMethodList<T>(_staticsTypes, methodNames);
        }


        /// <inheritdoc cref="IBaseTraits.ByteCount"/>
        public static int ByteCount {
            get { return _instance.ByteCount; }
        }

        /// <inheritdoc cref="IBaseTraits.IsSupported"/>
        public static bool IsSupported {
            get {
                return _instance.IsSupported;
            }
        }

        /// <inheritdoc cref="IBaseTraits.GetIsSupported"/>
        public static bool GetIsSupported(bool noStrict = false) {
            return _instance.GetIsSupported(noStrict);
        }

        /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
        public static string GetUnsupportedMessage(bool noStrict = false) {
            return _instance.GetUnsupportedMessage(noStrict);
        }

        /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
        public static void ThrowForUnsupported(bool noStrict = false) {
            _instance.ThrowForUnsupported(noStrict);
        }

#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits256.Abs_AcceleratedTypes"/>
        public static TypeCodeFlags Abs_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.Abs_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> Abs(Vector256<float> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Abs(value);
#else
            return _instance.Abs(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> Abs(Vector256<double> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Abs(value);
#else
            return _instance.Abs(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> Abs(Vector256<sbyte> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Abs(value);
#else
            return _instance.Abs(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> Abs(Vector256<short> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Abs(value);
#else
            return _instance.Abs(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> Abs(Vector256<int> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Abs(value);
#else
            return _instance.Abs(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Abs(Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> Abs(Vector256<long> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Abs(value);
#else
            return _instance.Abs(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits256.Add_AcceleratedTypes"/>
        public static TypeCodeFlags Add_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.Add_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                if (Vector256.IsHardwareAccelerated) {
                    rt |= TypeCodeFlagsUtil.AllTypes;
                }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> Add(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> Add(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> Add(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> Add(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> Add(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> Add(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> Add(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> Add(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> Add(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Add(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> Add(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Add(left, right);
#else
            return _instance.Add(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits256.AndNot_AcceleratedTypes"/>
        public static TypeCodeFlags AndNot_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.AndNot_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.AndNot{T}(Vector256{T}, Vector256{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> AndNot<T>(Vector256<T> left, Vector256<T> right) where T : struct {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.AndNot(left, right);
#else
            return _instance.AndNot(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits256.BitwiseAnd_AcceleratedTypes"/>
        public static TypeCodeFlags BitwiseAnd_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.BitwiseAnd_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.BitwiseAnd{T}(Vector256{T}, Vector256{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> BitwiseAnd<T>(Vector256<T> left, Vector256<T> right) where T : struct {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.BitwiseAnd(left, right);
#else
            return _instance.BitwiseAnd(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits256.BitwiseOr_AcceleratedTypes"/>
        public static TypeCodeFlags BitwiseOr_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.BitwiseOr_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.BitwiseOr{T}(Vector256{T}, Vector256{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> BitwiseOr<T>(Vector256<T> left, Vector256<T> right) where T : struct {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.BitwiseOr(left, right);
#else
            return _instance.BitwiseOr(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits256.Ceiling_AcceleratedTypes"/>
        public static TypeCodeFlags Ceiling_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.Ceiling_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
                    }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Ceiling(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> Ceiling(Vector256<float> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Ceiling(value);
#else
            return _instance.Ceiling(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Ceiling(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> Ceiling(Vector256<double> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Ceiling(value);
#else
            return _instance.Ceiling(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits256.ConditionalSelect_AcceleratedTypes"/>
        public static TypeCodeFlags ConditionalSelect_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.ConditionalSelect_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ConditionalSelect{T}(Vector256{T}, Vector256{T}, Vector256{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> ConditionalSelect<T>(Vector256<T> condition, Vector256<T> left, Vector256<T> right) where T : struct {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ConditionalSelect(condition, left, right);
#else
            return _instance.ConditionalSelect(condition, left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.ConditionalSelect(Vector256{int}, Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> ConditionalSelect(Vector256<int> condition, Vector256<float> left, Vector256<float> right) {
            return _instance.ConditionalSelect(condition, left, right);
        }

        /// <inheritdoc cref="IWVectorTraits256.ConditionalSelect(Vector256{long}, Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> ConditionalSelect(Vector256<long> condition, Vector256<double> left, Vector256<double> right) {
            return _instance.ConditionalSelect(condition, left, right);
        }


        /// <inheritdoc cref="IWVectorTraits256.Divide_AcceleratedTypes"/>
        public static TypeCodeFlags Divide_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.Divide_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                if (Vector256.IsHardwareAccelerated) {
                    rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
                }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Divide(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> Divide(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Divide(left, right);
#else
            return _instance.Divide(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Divide(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> Divide(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Divide(left, right);
#else
            return _instance.Divide(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits256.Floor_AcceleratedTypes"/>
        public static TypeCodeFlags Floor_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.Floor_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
                    }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Floor(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> Floor(Vector256<float> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Floor(value);
#else
            return _instance.Floor(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Floor(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> Floor(Vector256<double> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Floor(value);
#else
            return _instance.Floor(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits256.GreaterThan_AcceleratedTypes"/>
        public static TypeCodeFlags GreaterThan_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.GreaterThan_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> GreaterThan(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.GreaterThan(left, right);
#else
            return _instance.GreaterThan(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> GreaterThan(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.GreaterThan(left, right);
#else
            return _instance.GreaterThan(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> GreaterThan(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.GreaterThan(left, right);
#else
            return _instance.GreaterThan(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> GreaterThan(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.GreaterThan(left, right);
#else
            return _instance.GreaterThan(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> GreaterThan(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.GreaterThan(left, right);
#else
            return _instance.GreaterThan(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> GreaterThan(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.GreaterThan(left, right);
#else
            return _instance.GreaterThan(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> GreaterThan(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.GreaterThan(left, right);
#else
            return _instance.GreaterThan(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> GreaterThan(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.GreaterThan(left, right);
#else
            return _instance.GreaterThan(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> GreaterThan(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.GreaterThan(left, right);
#else
            return _instance.GreaterThan(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.GreaterThan(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> GreaterThan(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.GreaterThan(left, right);
#else
            return _instance.GreaterThan(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits256.LessThan_AcceleratedTypes"/>
        public static TypeCodeFlags LessThan_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.LessThan_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> LessThan(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.LessThan(left, right);
#else
            return _instance.LessThan(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> LessThan(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.LessThan(left, right);
#else
            return _instance.LessThan(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> LessThan(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.LessThan(left, right);
#else
            return _instance.LessThan(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> LessThan(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.LessThan(left, right);
#else
            return _instance.LessThan(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> LessThan(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.LessThan(left, right);
#else
            return _instance.LessThan(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> LessThan(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.LessThan(left, right);
#else
            return _instance.LessThan(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> LessThan(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.LessThan(left, right);
#else
            return _instance.LessThan(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> LessThan(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.LessThan(left, right);
#else
            return _instance.LessThan(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> LessThan(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.LessThan(left, right);
#else
            return _instance.LessThan(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.LessThan(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> LessThan(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.LessThan(left, right);
#else
            return _instance.LessThan(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits256.Max_AcceleratedTypes"/>
        public static TypeCodeFlags Max_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.Max_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> Max(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Max(left, right);
#else
            return _instance.Max(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> Max(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Max(left, right);
#else
            return _instance.Max(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> Max(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Max(left, right);
#else
            return _instance.Max(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> Max(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Max(left, right);
#else
            return _instance.Max(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> Max(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Max(left, right);
#else
            return _instance.Max(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> Max(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Max(left, right);
#else
            return _instance.Max(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> Max(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Max(left, right);
#else
            return _instance.Max(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> Max(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Max(left, right);
#else
            return _instance.Max(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> Max(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Max(left, right);
#else
            return _instance.Max(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Max(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> Max(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Max(left, right);
#else
            return _instance.Max(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits256.Min_AcceleratedTypes"/>
        public static TypeCodeFlags Min_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.Min_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> Min(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> Min(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> Min(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> Min(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> Min(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> Min(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> Min(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> Min(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> Min(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Min(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> Min(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits256.Multiply_AcceleratedTypes"/>
        public static TypeCodeFlags Multiply_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.Multiply_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                if (Vector256.IsHardwareAccelerated) {
                    rt |= TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> Multiply(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> Multiply(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> Multiply(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_STATIC && NET_X_0_OR_GREATER // .NET7 no hardware acceleration! X86(sse, avx)
            return Vector256.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_OVERRIDE_STATIC && NET_X_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> Multiply(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_STATIC && NET_X_0_OR_GREATER // .NET7 no hardware acceleration! X86(sse, avx)
            return Vector256.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_OVERRIDE_STATIC && NET_X_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> Multiply(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> Multiply(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> Multiply(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> Multiply(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> Multiply(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_STATIC && NET_X_0_OR_GREATER // .NET7 no hardware acceleration! X86(sse, avx)
            return Vector256.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_OVERRIDE_STATIC && NET_X_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Multiply(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> Multiply(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_STATIC && NET_X_0_OR_GREATER // .NET7 no hardware acceleration! X86(sse, avx)
            return Vector256.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_OVERRIDE_STATIC && NET_X_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits256.Negate_AcceleratedTypes"/>
        public static TypeCodeFlags Negate_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.Negate_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> Negate(Vector256<float> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Negate(value);
#else
            return _instance.Negate(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> Negate(Vector256<double> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Negate(value);
#else
            return _instance.Negate(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> Negate(Vector256<sbyte> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Negate(value);
#else
            return _instance.Negate(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> Negate(Vector256<short> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Negate(value);
#else
            return _instance.Negate(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> Negate(Vector256<int> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Negate(value);
#else
            return _instance.Negate(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Negate(Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> Negate(Vector256<long> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Negate(value);
#else
            return _instance.Negate(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits256.OnesComplement_AcceleratedTypes"/>
        public static TypeCodeFlags OnesComplement_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.OnesComplement_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.OnesComplement{T}(Vector256{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> OnesComplement<T>(Vector256<T> vector) where T : struct {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.OnesComplement(vector);
#else
            return _instance.OnesComplement(vector);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_AcceleratedTypes"/>
        public static TypeCodeFlags ShiftLeft_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.ShiftLeft_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                if (Vector256.IsHardwareAccelerated) {
                    rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftLeft(Vector256<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector256.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> ShiftLeft(Vector256<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector256.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftLeft(Vector256<short> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> ShiftLeft(Vector256<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftLeft(Vector256<int> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> ShiftLeft(Vector256<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftLeft(Vector256<long> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> ShiftLeft(Vector256<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftLeftFast(Vector256<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector256.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftLeftFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> ShiftLeftFast(Vector256<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector256.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftLeftFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftLeftFast(Vector256<short> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeftFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> ShiftLeftFast(Vector256<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeftFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftLeftFast(Vector256<int> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeftFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> ShiftLeftFast(Vector256<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeftFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftLeftFast(Vector256<long> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeftFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> ShiftLeftFast(Vector256<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeftFast(value, shiftAmount);
#endif
        }


        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_AcceleratedTypes"/>
        public static TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.ShiftRightArithmetic_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                if (Vector256.IsHardwareAccelerated) {
                    rt |= TypeCodeFlags.Int16 | TypeCodeFlags.Int32;
                }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftRightArithmetic(Vector256<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector256.ShiftRightArithmetic(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftRightArithmetic(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftRightArithmetic(Vector256<short> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftRightArithmetic(Vector256<int> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftRightArithmetic(Vector256<long> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftRightArithmeticFast(Vector256<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector256.ShiftRightArithmetic(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftRightArithmeticFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftRightArithmeticFast(Vector256<short> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmeticFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftRightArithmeticFast(Vector256<int> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmeticFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftRightArithmeticFast(Vector256<long> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmeticFast(value, shiftAmount);
#endif
        }


        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_AcceleratedTypes"/>
        public static TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.ShiftRightLogical_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                if (Vector256.IsHardwareAccelerated) {
                    rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftRightLogical(Vector256<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector256.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> ShiftRightLogical(Vector256<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector256.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftRightLogical(Vector256<short> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> ShiftRightLogical(Vector256<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftRightLogical(Vector256<int> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> ShiftRightLogical(Vector256<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftRightLogical(Vector256<long> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> ShiftRightLogical(Vector256<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftRightLogicalFast(Vector256<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector256.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftRightLogicalFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> ShiftRightLogicalFast(Vector256<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector256.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftRightLogicalFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftRightLogicalFast(Vector256<short> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogicalFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> ShiftRightLogicalFast(Vector256<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogicalFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftRightLogicalFast(Vector256<int> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogicalFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> ShiftRightLogicalFast(Vector256<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogicalFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftRightLogicalFast(Vector256<long> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogicalFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogicalFast(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> ShiftRightLogicalFast(Vector256<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogicalFast(value, shiftAmount);
#endif
        }


        /// <inheritdoc cref="IWVectorTraits256.Subtract_AcceleratedTypes"/>
        public static TypeCodeFlags Subtract_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.Subtract_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                if (Vector256.IsHardwareAccelerated) {
                    rt |= TypeCodeFlagsUtil.AllTypes;
                }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> Subtract(Vector256<float> left, Vector256<float> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Subtract(left, right);
#else
            return _instance.Subtract(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> Subtract(Vector256<double> left, Vector256<double> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Subtract(left, right);
#else
            return _instance.Subtract(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> Subtract(Vector256<sbyte> left, Vector256<sbyte> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Subtract(left, right);
#else
            return _instance.Subtract(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> Subtract(Vector256<byte> left, Vector256<byte> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Subtract(left, right);
#else
            return _instance.Subtract(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> Subtract(Vector256<short> left, Vector256<short> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Subtract(left, right);
#else
            return _instance.Subtract(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> Subtract(Vector256<ushort> left, Vector256<ushort> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Subtract(left, right);
#else
            return _instance.Subtract(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> Subtract(Vector256<int> left, Vector256<int> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Subtract(left, right);
#else
            return _instance.Subtract(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> Subtract(Vector256<uint> left, Vector256<uint> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Subtract(left, right);
#else
            return _instance.Subtract(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> Subtract(Vector256<long> left, Vector256<long> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Subtract(left, right);
#else
            return _instance.Subtract(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Subtract(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> Subtract(Vector256<ulong> left, Vector256<ulong> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Subtract(left, right);
#else
            return _instance.Subtract(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits256.Xor_AcceleratedTypes"/>
        public static TypeCodeFlags Xor_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.Xor_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                    if (Vector256.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Xor{T}(Vector256{T}, Vector256{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<T> Xor<T>(Vector256<T> left, Vector256<T> right) where T : struct {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.Xor(left, right);
#else
            return _instance.Xor(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits256.YClamp_AcceleratedTypes"/>
        public static TypeCodeFlags YClamp_AcceleratedTypes {
            get {
                return _instance.YClamp_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{float}, Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> YClamp(Vector256<float> value, Vector256<float> amin, Vector256<float> amax) {
            return _instance.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{double}, Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> YClamp(Vector256<double> value, Vector256<double> amin, Vector256<double> amax) {
            return _instance.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YClamp(Vector256<sbyte> value, Vector256<sbyte> amin, Vector256<sbyte> amax) {
            return _instance.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YClamp(Vector256<byte> value, Vector256<byte> amin, Vector256<byte> amax) {
            return _instance.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YClamp(Vector256<short> value, Vector256<short> amin, Vector256<short> amax) {
            return _instance.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YClamp(Vector256<ushort> value, Vector256<ushort> amin, Vector256<ushort> amax) {
            return _instance.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> YClamp(Vector256<int> value, Vector256<int> amin, Vector256<int> amax) {
            return _instance.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> YClamp(Vector256<uint> value, Vector256<uint> amin, Vector256<uint> amax) {
            return _instance.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> YClamp(Vector256<long> value, Vector256<long> amin, Vector256<long> amax) {
            return _instance.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> YClamp(Vector256<ulong> value, Vector256<ulong> amin, Vector256<ulong> amax) {
            return _instance.YClamp(value, amin, amax);
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
