using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits {
    static partial class Vector128s {
        private static readonly IWVectorTraits128 _instance = WVectorTraits128Abstract.GetBestInstance(); // Best traits instance.
        private static readonly dynamic _instanceDynamic = _instance; // Best traits instance dynamic value.

        private static readonly string[] _traitsNames = {
            "WVectorTraits128Base",
            "WVectorTraits128AdvSimd",
            "WVectorTraits128AdvSimdB64"
        };

        private static readonly IWVectorTraits128[] _traitsInstances = {
            WVectorTraits128Base.Instance,
            WVectorTraits128AdvSimd.Instance,
            WVectorTraits128AdvSimdB64.Instance
        };

        // Statics types (静态类型集).
        private static readonly Type[] _staticsTypes = {
            typeof(WVectorTraits128Base.Statics),
            typeof(WVectorTraits128AdvSimd.Statics),
            typeof(WVectorTraits128AdvSimdB64.Statics)
        };

        /// <summary>Best traits instance (最佳特征实例). </summary>
        [CLSCompliant(false)]
        public static IWVectorTraits128 Instance {
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
        public static IReadOnlyList<IWVectorTraits128> TraitsInstances {
            get { return _traitsInstances; }
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

        /// <inheritdoc cref="IWVectorTraits128.AndNot_AcceleratedTypes"/>
        public static TypeCodeFlags AndNot_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.AndNot_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.AndNot{T}(Vector128{T}, Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> AndNot<T>(Vector128<T> left, Vector128<T> right) where T : struct {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.AndNot(left, right);
#else
            return _instance.AndNot(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits128.BitwiseAnd_AcceleratedTypes"/>
        public static TypeCodeFlags BitwiseAnd_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.BitwiseAnd_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.BitwiseAnd{T}(Vector128{T}, Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> BitwiseAnd<T>(Vector128<T> left, Vector128<T> right) where T : struct {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.BitwiseAnd(left, right);
#else
            return _instance.BitwiseAnd(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits128.BitwiseOr_AcceleratedTypes"/>
        public static TypeCodeFlags BitwiseOr_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.BitwiseOr_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.BitwiseOr{T}(Vector128{T}, Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> BitwiseOr<T>(Vector128<T> left, Vector128<T> right) where T : struct {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.BitwiseOr(left, right);
#else
            return _instance.BitwiseOr(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits128.Ceiling_AcceleratedTypes"/>
        public static TypeCodeFlags Ceiling_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.Ceiling_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
                    }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Ceiling(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> Ceiling(Vector128<float> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.Ceiling(value);
#else
            return _instance.Ceiling(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits128.Ceiling(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> Ceiling(Vector128<double> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.Ceiling(value);
#else
            return _instance.Ceiling(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect_AcceleratedTypes"/>
        public static TypeCodeFlags ConditionalSelect_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.ConditionalSelect_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                if (Vector128.IsHardwareAccelerated) {
                    rt |= TypeCodeFlagsUtil.AllTypes;
                }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect{T}(Vector128{T}, Vector128{T}, Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> ConditionalSelect<T>(Vector128<T> condition, Vector128<T> left, Vector128<T> right) where T : struct {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ConditionalSelect(condition, left, right);
#else
            return _instance.ConditionalSelect(condition, left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect(Vector128{int}, Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> ConditionalSelect(Vector128<int> condition, Vector128<float> left, Vector128<float> right) {
            return _instance.ConditionalSelect(condition, left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.ConditionalSelect(Vector128{long}, Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> ConditionalSelect(Vector128<long> condition, Vector128<double> left, Vector128<double> right) {
            return _instance.ConditionalSelect(condition, left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Floor_AcceleratedTypes"/>
        public static TypeCodeFlags Floor_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.Floor_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
                    }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Floor(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> Floor(Vector128<float> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.Floor(value);
#else
            return _instance.Floor(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits128.Floor(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> Floor(Vector128<double> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.Floor(value);
#else
            return _instance.Floor(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits128.Min_AcceleratedTypes"/>
        public static TypeCodeFlags Min_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.Floor_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> Min(Vector128<float> left, Vector128<float> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> Min(Vector128<double> left, Vector128<double> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> Min(Vector128<sbyte> left, Vector128<sbyte> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> Min(Vector128<byte> left, Vector128<byte> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> Min(Vector128<short> left, Vector128<short> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> Min(Vector128<ushort> left, Vector128<ushort> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{int}, Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> Min(Vector128<int> left, Vector128<int> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{uint}, Vector128{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> Min(Vector128<uint> left, Vector128<uint> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> Min(Vector128<long> left, Vector128<long> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> Min(Vector128<ulong> left, Vector128<ulong> right) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.Min(left, right);
#else
            return _instance.Min(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits128.Negate_AcceleratedTypes"/>
        public static TypeCodeFlags Negate_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.Negate_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double | TypeCodeFlags.SByte | TypeCodeFlags.Int16 | TypeCodeFlags.Int32 | TypeCodeFlags.Int64;
                    }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<float> Negate(Vector128<float> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.Negate(value);
#else
            return _instance.Negate(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<double> Negate(Vector128<double> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.Negate(value);
#else
            return _instance.Negate(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> Negate(Vector128<sbyte> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.Negate(value);
#else
            return _instance.Negate(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> Negate(Vector128<short> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.Negate(value);
#else
            return _instance.Negate(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> Negate(Vector128<int> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.Negate(value);
#else
            return _instance.Negate(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits128.Negate(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> Negate(Vector128<long> value) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.Negate(value);
#else
            return _instance.Negate(value);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits128.OnesComplement_AcceleratedTypes"/>
        public static TypeCodeFlags OnesComplement_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.OnesComplement_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.OnesComplement{T}(Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> OnesComplement<T>(Vector128<T> vector) where T : struct {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.OnesComplement(vector);
#else
            return _instance.OnesComplement(vector);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }


        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft_AcceleratedTypes"/>
        public static TypeCodeFlags ShiftLeft_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.ShiftLeft_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                if (Vector128.IsHardwareAccelerated) {
                    rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> ShiftLeft(Vector128<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector128.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> ShiftLeft(Vector128<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector128.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> ShiftLeft(Vector128<short> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> ShiftLeft(Vector128<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> ShiftLeft(Vector128<int> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> ShiftLeft(Vector128<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> ShiftLeft(Vector128<long> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> ShiftLeft(Vector128<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> ShiftLeftFast(Vector128<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector128.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftLeftFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> ShiftLeftFast(Vector128<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector128.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftLeftFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> ShiftLeftFast(Vector128<short> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeftFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> ShiftLeftFast(Vector128<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeftFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> ShiftLeftFast(Vector128<int> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeftFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> ShiftLeftFast(Vector128<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeftFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> ShiftLeftFast(Vector128<long> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeftFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> ShiftLeftFast(Vector128<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeftFast(value, shiftAmount);
#endif
        }


        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic_AcceleratedTypes"/>
        public static TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.ShiftRightArithmetic_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                if (Vector128.IsHardwareAccelerated) {
                    rt |= TypeCodeFlags.Int16 | TypeCodeFlags.Int32;
                }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> ShiftRightArithmetic(Vector128<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector128.ShiftRightArithmetic(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftRightArithmetic(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> ShiftRightArithmetic(Vector128<short> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> ShiftRightArithmetic(Vector128<int> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> ShiftRightArithmetic(Vector128<long> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmeticFast(Vector128{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> ShiftRightArithmeticFast(Vector128<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector128.ShiftRightArithmetic(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftRightArithmeticFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmeticFast(Vector128{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> ShiftRightArithmeticFast(Vector128<short> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmeticFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmeticFast(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> ShiftRightArithmeticFast(Vector128<int> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmeticFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmeticFast(Vector128{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> ShiftRightArithmeticFast(Vector128<long> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmeticFast(value, shiftAmount);
#endif
        }


        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical_AcceleratedTypes"/>
        public static TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.ShiftRightLogical_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                if (Vector128.IsHardwareAccelerated) {
                    rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> ShiftRightLogical(Vector128<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector128.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> ShiftRightLogical(Vector128<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector128.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> ShiftRightLogical(Vector128<short> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> ShiftRightLogical(Vector128<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> ShiftRightLogical(Vector128<int> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> ShiftRightLogical(Vector128<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> ShiftRightLogical(Vector128<long> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogical(Vector128{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> ShiftRightLogical(Vector128<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> ShiftRightLogicalFast(Vector128<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector128.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftRightLogicalFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> ShiftRightLogicalFast(Vector128<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector128.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftRightLogicalFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> ShiftRightLogicalFast(Vector128<short> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogicalFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> ShiftRightLogicalFast(Vector128<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogicalFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> ShiftRightLogicalFast(Vector128<int> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogicalFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<uint> ShiftRightLogicalFast(Vector128<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogicalFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> ShiftRightLogicalFast(Vector128<long> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogicalFast(value, shiftAmount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftRightLogicalFast(Vector128{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ulong> ShiftRightLogicalFast(Vector128<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogicalFast(value, shiftAmount);
#endif
        }


        /// <inheritdoc cref="IWVectorTraits128.Xor_AcceleratedTypes"/>
        public static TypeCodeFlags Xor_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.Xor_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                    if (Vector128.IsHardwareAccelerated) {
                        rt |= TypeCodeFlagsUtil.AllTypes;
                    }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Xor{T}(Vector128{T}, Vector128{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<T> Xor<T>(Vector128<T> left, Vector128<T> right) where T : struct {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.Xor(left, right);
#else
            return _instance.Xor(left, right);
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
