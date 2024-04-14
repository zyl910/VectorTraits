using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Runtime.CompilerServices;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.AVector256;

namespace Zyl.VectorTraits {
    using BaseStatics = WVectorTraits256Base.Statics;

    static partial class Vector256s {
        private static readonly IWVectorTraits256 _instance = WVectorTraits256Abstract.GetBestInstance(); // Best traits instance.
        private static readonly dynamic _instanceDynamic = _instance; // Best traits instance dynamic value.
        private static readonly WVectorTraits256Base _baseInstance = WVectorTraits256Base.Instance; // Best traits instance.

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

        /// <summary>Base traits instance (基本特征实例). </summary>
        [CLSCompliant(false)]
        public static WVectorTraits256Base BaseInstance {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return _baseInstance; }
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

        /// <inheritdoc cref="IBaseTraits.IsHardwareAccelerated"/>
        public static bool IsHardwareAccelerated {
            get {
                return _instance.IsHardwareAccelerated;
            }
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

        /// <inheritdoc cref="IWVectorTraits256.Ceiling_AcceleratedTypes"/>
        public static TypeCodeFlags Ceiling_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Ceiling_AcceleratedTypes;
#else
                return _instance.Ceiling_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Ceiling(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> Ceiling(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Ceiling(value);
#else
            return _instance.Ceiling(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Ceiling(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> Ceiling(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Ceiling(value);
#else
            return _instance.Ceiling(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble_AcceleratedTypes"/>
        public static TypeCodeFlags ConvertToDouble_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ConvertToDouble_AcceleratedTypes;
#else
                return _instance.ConvertToDouble_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble(Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> ConvertToDouble(Vector256<long> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToDouble(value);
#else
            return _instance.ConvertToDouble(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> ConvertToDouble(Vector256<ulong> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToDouble(value);
#else
            return _instance.ConvertToDouble(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble_Range52(Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> ConvertToDouble_Range52(Vector256<long> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToDouble_Range52(value);
#else
            return _instance.ConvertToDouble_Range52(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToDouble_Range52(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> ConvertToDouble_Range52(Vector256<ulong> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToDouble_Range52(value);
#else
            return _instance.ConvertToDouble_Range52(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.ConvertToInt32_AcceleratedTypes"/>
        public static TypeCodeFlags ConvertToInt32_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ConvertToInt32_AcceleratedTypes;
#else
                return _instance.ConvertToInt32_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToInt32(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ConvertToInt32(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ConvertToInt32(value);
#else
            return _instance.ConvertToInt32(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.ConvertToInt64_AcceleratedTypes"/>
        public static TypeCodeFlags ConvertToInt64_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ConvertToInt64_AcceleratedTypes;
#else
                return _instance.ConvertToInt64_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToInt64(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ConvertToInt64(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToInt64(value);
#else
            return _instance.ConvertToInt64(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToInt64_Range52(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ConvertToInt64_Range52(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToInt64_Range52(value);
#else
            return _instance.ConvertToInt64_Range52(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToInt64_Range52RoundToEven(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ConvertToInt64_Range52RoundToEven(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToInt64_Range52RoundToEven(value);
#else
            return _instance.ConvertToInt64_Range52RoundToEven(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.ConvertToSingle_AcceleratedTypes"/>
        public static TypeCodeFlags ConvertToSingle_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ConvertToSingle_AcceleratedTypes;
#else
                return _instance.ConvertToSingle_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToSingle(Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> ConvertToSingle(Vector256<int> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ConvertToSingle(value);
#else
            return _instance.ConvertToSingle(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToSingle(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> ConvertToSingle(Vector256<uint> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToSingle(value);
#else
            return _instance.ConvertToSingle(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt32_AcceleratedTypes"/>
        public static TypeCodeFlags ConvertToUInt32_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ConvertToUInt32_AcceleratedTypes;
#else
                return _instance.ConvertToUInt32_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt32(Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> ConvertToUInt32(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToUInt32(value);
#else
            return _instance.ConvertToUInt32(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt64_AcceleratedTypes"/>
        public static TypeCodeFlags ConvertToUInt64_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ConvertToUInt64_AcceleratedTypes;
#else
                return _instance.ConvertToUInt64_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt64(Vector256{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> ConvertToUInt64(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToUInt64(value);
#else
            return _instance.ConvertToUInt64(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt64_Range52(Vector256{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> ConvertToUInt64_Range52(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToUInt64_Range52(value);
#else
            return _instance.ConvertToUInt64_Range52(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ConvertToUInt64_Range52RoundToEven(Vector256{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> ConvertToUInt64_Range52RoundToEven(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToUInt64_Range52RoundToEven(value);
#else
            return _instance.ConvertToUInt64_Range52RoundToEven(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits_AcceleratedTypes"/>
        public static TypeCodeFlags ExtractMostSignificantBits_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ExtractMostSignificantBits_AcceleratedTypes;
#else
                return _instance.ExtractMostSignificantBits_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ExtractMostSignificantBits(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(value);
#else
            return _instance.ExtractMostSignificantBits(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ExtractMostSignificantBits(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(value);
#else
            return _instance.ExtractMostSignificantBits(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ExtractMostSignificantBits(Vector256<sbyte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(value);
#else
            return _instance.ExtractMostSignificantBits(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ExtractMostSignificantBits(Vector256<byte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(value);
#else
            return _instance.ExtractMostSignificantBits(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ExtractMostSignificantBits(Vector256<short> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(value);
#else
            return _instance.ExtractMostSignificantBits(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ExtractMostSignificantBits(Vector256<ushort> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(value);
#else
            return _instance.ExtractMostSignificantBits(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ExtractMostSignificantBits(Vector256<int> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(value);
#else
            return _instance.ExtractMostSignificantBits(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ExtractMostSignificantBits(Vector256<uint> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(value);
#else
            return _instance.ExtractMostSignificantBits(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ExtractMostSignificantBits(Vector256<long> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(value);
#else
            return _instance.ExtractMostSignificantBits(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ExtractMostSignificantBits(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ExtractMostSignificantBits(Vector256<ulong> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(value);
#else
            return _instance.ExtractMostSignificantBits(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.Floor_AcceleratedTypes"/>
        public static TypeCodeFlags Floor_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Floor_AcceleratedTypes;
#else
                return _instance.Floor_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Floor(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> Floor(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Floor(value);
#else
            return _instance.Floor(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Floor(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> Floor(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Floor(value);
#else
            return _instance.Floor(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.Narrow_AcceleratedTypes"/>
        public static TypeCodeFlags Narrow_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Narrow_AcceleratedTypes;
#else
                return _instance.Narrow_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{double}, Vector256{double})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> Narrow(Vector256<double> lower, Vector256<double> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Narrow(lower, upper);
#else
            return _instance.Narrow(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{short}, Vector256{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> Narrow(Vector256<short> lower, Vector256<short> upper) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Narrow(lower, upper);
#else
            return _instance.Narrow(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{ushort}, Vector256{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> Narrow(Vector256<ushort> lower, Vector256<ushort> upper) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Narrow(lower, upper);
#else
            return _instance.Narrow(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{int}, Vector256{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> Narrow(Vector256<int> lower, Vector256<int> upper) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Narrow(lower, upper);
#else
            return _instance.Narrow(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{uint}, Vector256{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> Narrow(Vector256<uint> lower, Vector256<uint> upper) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Narrow(lower, upper);
#else
            return _instance.Narrow(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{long}, Vector256{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> Narrow(Vector256<long> lower, Vector256<long> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Narrow(lower, upper);
#else
            return _instance.Narrow(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Narrow(Vector256{ulong}, Vector256{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> Narrow(Vector256<ulong> lower, Vector256<ulong> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Narrow(lower, upper);
#else
            return _instance.Narrow(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_AcceleratedTypes"/>
        public static TypeCodeFlags ShiftLeft_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ShiftLeft_AcceleratedTypes;
#else
                return _instance.ShiftLeft_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftLeft(Vector256<sbyte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> ShiftLeft(Vector256<byte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftLeft(Vector256<short> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> ShiftLeft(Vector256<ushort> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftLeft(Vector256<int> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> ShiftLeft(Vector256<uint> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftLeft(Vector256<long> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> ShiftLeft(Vector256<ulong> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{sbyte}, int, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftLeft_Args(Vector256<sbyte> dummy, int shiftAmount, out Vector256<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftLeft_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{byte}, int, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> ShiftLeft_Args(Vector256<byte> dummy, int shiftAmount, out Vector256<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftLeft_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{short}, int, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftLeft_Args(Vector256<short> dummy, int shiftAmount, out Vector256<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftLeft_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{ushort}, int, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> ShiftLeft_Args(Vector256<ushort> dummy, int shiftAmount, out Vector256<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftLeft_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{int}, int, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftLeft_Args(Vector256<int> dummy, int shiftAmount, out Vector256<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftLeft_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{uint}, int, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> ShiftLeft_Args(Vector256<uint> dummy, int shiftAmount, out Vector256<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftLeft_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{long}, int, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftLeft_Args(Vector256<long> dummy, int shiftAmount, out Vector256<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftLeft_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Args(Vector256{ulong}, int, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> ShiftLeft_Args(Vector256<ulong> dummy, int shiftAmount, out Vector256<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftLeft_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftLeft_Core(Vector256<sbyte> value, int shiftAmount, Vector256<sbyte> args0, Vector256<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{byte}, int, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> ShiftLeft_Core(Vector256<byte> value, int shiftAmount, Vector256<byte> args0, Vector256<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftLeft_Core(Vector256<short> value, int shiftAmount, Vector256<short> args0, Vector256<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{ushort}, int, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> ShiftLeft_Core(Vector256<ushort> value, int shiftAmount, Vector256<ushort> args0, Vector256<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftLeft_Core(Vector256<int> value, int shiftAmount, Vector256<int> args0, Vector256<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{uint}, int, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> ShiftLeft_Core(Vector256<uint> value, int shiftAmount, Vector256<uint> args0, Vector256<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftLeft_Core(Vector256<long> value, int shiftAmount, Vector256<long> args0, Vector256<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Core(Vector256{ulong}, int, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> ShiftLeft_Core(Vector256<ulong> value, int shiftAmount, Vector256<ulong> args0, Vector256<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftLeft_Const(Vector256<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Const(value, shiftAmount);
#else
            return _instance.ShiftLeft_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> ShiftLeft_Const(Vector256<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Const(value, shiftAmount);
#else
            return _instance.ShiftLeft_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftLeft_Const(Vector256<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftLeft_Const(value, shiftAmount);
#else
            return _instance.ShiftLeft_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> ShiftLeft_Const(Vector256<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftLeft_Const(value, shiftAmount);
#else
            return _instance.ShiftLeft_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftLeft_Const(Vector256<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftLeft_Const(value, shiftAmount);
#else
            return _instance.ShiftLeft_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> ShiftLeft_Const(Vector256<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftLeft_Const(value, shiftAmount);
#else
            return _instance.ShiftLeft_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftLeft_Const(Vector256<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Const(value, shiftAmount);
#else
            return _instance.ShiftLeft_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Const(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> ShiftLeft_Const(Vector256<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Const(value, shiftAmount);
#else
            return _instance.ShiftLeft_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftLeft_ConstCore(Vector256<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector256<sbyte> args0, Vector256<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{byte}, int, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> ShiftLeft_ConstCore(Vector256<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector256<byte> args0, Vector256<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftLeft_ConstCore(Vector256<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector256<short> args0, Vector256<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{ushort}, int, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> ShiftLeft_ConstCore(Vector256<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector256<ushort> args0, Vector256<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftLeft_ConstCore(Vector256<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector256<int> args0, Vector256<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{uint}, int, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> ShiftLeft_ConstCore(Vector256<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector256<uint> args0, Vector256<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftLeft_ConstCore(Vector256<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector256<long> args0, Vector256<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_ConstCore(Vector256{ulong}, int, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> ShiftLeft_ConstCore(Vector256<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector256<ulong> args0, Vector256<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftLeft_Fast(Vector256<sbyte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Fast(value, shiftAmount);
#else
            return _instance.ShiftLeft_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> ShiftLeft_Fast(Vector256<byte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Fast(value, shiftAmount);
#else
            return _instance.ShiftLeft_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftLeft_Fast(Vector256<short> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftLeft_Fast(value, shiftAmount);
#else
            return _instance.ShiftLeft_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> ShiftLeft_Fast(Vector256<ushort> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftLeft_Fast(value, shiftAmount);
#else
            return _instance.ShiftLeft_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftLeft_Fast(Vector256<int> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftLeft_Fast(value, shiftAmount);
#else
            return _instance.ShiftLeft_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> ShiftLeft_Fast(Vector256<uint> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftLeft_Fast(value, shiftAmount);
#else
            return _instance.ShiftLeft_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftLeft_Fast(Vector256<long> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Fast(value, shiftAmount);
#else
            return _instance.ShiftLeft_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft_Fast(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> ShiftLeft_Fast(Vector256<ulong> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Fast(value, shiftAmount);
#else
            return _instance.ShiftLeft_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_AcceleratedTypes"/>
        public static TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ShiftRightArithmetic_AcceleratedTypes;
#else
                return _instance.ShiftRightArithmetic_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftRightArithmetic(Vector256<sbyte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftRightArithmetic(Vector256<short> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftRightArithmetic(Vector256<int> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftRightArithmetic(Vector256<long> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Args(Vector256{sbyte}, int, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftRightArithmetic_Args(Vector256<sbyte> dummy, int shiftAmount, out Vector256<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Args(Vector256{short}, int, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftRightArithmetic_Args(Vector256<short> dummy, int shiftAmount, out Vector256<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Args(Vector256{int}, int, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftRightArithmetic_Args(Vector256<int> dummy, int shiftAmount, out Vector256<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Args(Vector256{long}, int, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftRightArithmetic_Args(Vector256<long> dummy, int shiftAmount, out Vector256<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Core(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftRightArithmetic_Core(Vector256<sbyte> value, int shiftAmount, Vector256<sbyte> args0, Vector256<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Core(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftRightArithmetic_Core(Vector256<short> value, int shiftAmount, Vector256<short> args0, Vector256<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Core(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftRightArithmetic_Core(Vector256<int> value, int shiftAmount, Vector256<int> args0, Vector256<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Core(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftRightArithmetic_Core(Vector256<long> value, int shiftAmount, Vector256<long> args0, Vector256<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Const(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftRightArithmetic_Const(Vector256<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Const(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Const(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftRightArithmetic_Const(Vector256<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightArithmetic_Const(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Const(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftRightArithmetic_Const(Vector256<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightArithmetic_Const(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Const(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftRightArithmetic_Const(Vector256<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Const(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_ConstCore(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftRightArithmetic_ConstCore(Vector256<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector256<sbyte> args0, Vector256<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_ConstCore(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftRightArithmetic_ConstCore(Vector256<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector256<short> args0, Vector256<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_ConstCore(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftRightArithmetic_ConstCore(Vector256<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector256<int> args0, Vector256<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_ConstCore(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftRightArithmetic_ConstCore(Vector256<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector256<long> args0, Vector256<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftRightArithmetic_Fast(Vector256<sbyte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftRightArithmetic_Fast(Vector256<short> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightArithmetic_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftRightArithmetic_Fast(Vector256<int> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightArithmetic_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic_Fast(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftRightArithmetic_Fast(Vector256<long> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_AcceleratedTypes"/>
        public static TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ShiftRightLogical_AcceleratedTypes;
#else
                return _instance.ShiftRightLogical_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftRightLogical(Vector256<sbyte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> ShiftRightLogical(Vector256<byte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftRightLogical(Vector256<short> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> ShiftRightLogical(Vector256<ushort> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftRightLogical(Vector256<int> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> ShiftRightLogical(Vector256<uint> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftRightLogical(Vector256<long> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> ShiftRightLogical(Vector256<ulong> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{sbyte}, int, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftRightLogical_Args(Vector256<sbyte> dummy, int shiftAmount, out Vector256<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{byte}, int, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> ShiftRightLogical_Args(Vector256<byte> dummy, int shiftAmount, out Vector256<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{short}, int, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftRightLogical_Args(Vector256<short> dummy, int shiftAmount, out Vector256<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{ushort}, int, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> ShiftRightLogical_Args(Vector256<ushort> dummy, int shiftAmount, out Vector256<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{int}, int, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftRightLogical_Args(Vector256<int> dummy, int shiftAmount, out Vector256<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{uint}, int, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> ShiftRightLogical_Args(Vector256<uint> dummy, int shiftAmount, out Vector256<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{long}, int, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftRightLogical_Args(Vector256<long> dummy, int shiftAmount, out Vector256<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Args(Vector256{ulong}, int, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> ShiftRightLogical_Args(Vector256<ulong> dummy, int shiftAmount, out Vector256<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftRightLogical_Core(Vector256<sbyte> value, int shiftAmount, Vector256<sbyte> args0, Vector256<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{byte}, int, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> ShiftRightLogical_Core(Vector256<byte> value, int shiftAmount, Vector256<byte> args0, Vector256<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftRightLogical_Core(Vector256<short> value, int shiftAmount, Vector256<short> args0, Vector256<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{ushort}, int, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> ShiftRightLogical_Core(Vector256<ushort> value, int shiftAmount, Vector256<ushort> args0, Vector256<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftRightLogical_Core(Vector256<int> value, int shiftAmount, Vector256<int> args0, Vector256<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{uint}, int, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> ShiftRightLogical_Core(Vector256<uint> value, int shiftAmount, Vector256<uint> args0, Vector256<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftRightLogical_Core(Vector256<long> value, int shiftAmount, Vector256<long> args0, Vector256<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Core(Vector256{ulong}, int, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> ShiftRightLogical_Core(Vector256<ulong> value, int shiftAmount, Vector256<ulong> args0, Vector256<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftRightLogical_Const(Vector256<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Const(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> ShiftRightLogical_Const(Vector256<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Const(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftRightLogical_Const(Vector256<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical_Const(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> ShiftRightLogical_Const(Vector256<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical_Const(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftRightLogical_Const(Vector256<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical_Const(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> ShiftRightLogical_Const(Vector256<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical_Const(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftRightLogical_Const(Vector256<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Const(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Const(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> ShiftRightLogical_Const(Vector256<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Const(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{sbyte}, int, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftRightLogical_ConstCore(Vector256<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector256<sbyte> args0, Vector256<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{byte}, int, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> ShiftRightLogical_ConstCore(Vector256<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector256<byte> args0, Vector256<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{short}, int, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftRightLogical_ConstCore(Vector256<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector256<short> args0, Vector256<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{ushort}, int, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> ShiftRightLogical_ConstCore(Vector256<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector256<ushort> args0, Vector256<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{int}, int, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftRightLogical_ConstCore(Vector256<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector256<int> args0, Vector256<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{uint}, int, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> ShiftRightLogical_ConstCore(Vector256<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector256<uint> args0, Vector256<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{long}, int, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftRightLogical_ConstCore(Vector256<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector256<long> args0, Vector256<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_ConstCore(Vector256{ulong}, int, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> ShiftRightLogical_ConstCore(Vector256<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector256<ulong> args0, Vector256<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftRightLogical_Fast(Vector256<sbyte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> ShiftRightLogical_Fast(Vector256<byte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftRightLogical_Fast(Vector256<short> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> ShiftRightLogical_Fast(Vector256<ushort> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftRightLogical_Fast(Vector256<int> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> ShiftRightLogical_Fast(Vector256<uint> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftRightLogical_Fast(Vector256<long> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightLogical_Fast(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> ShiftRightLogical_Fast(Vector256<ulong> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.Shuffle_AcceleratedTypes"/>
        public static TypeCodeFlags Shuffle_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Shuffle_AcceleratedTypes;
#else
                return _instance.Shuffle_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{float}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> Shuffle(Vector256<float> vector, Vector256<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{double}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> Shuffle(Vector256<double> vector, Vector256<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> Shuffle(Vector256<sbyte> vector, Vector256<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> Shuffle(Vector256<byte> vector, Vector256<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> Shuffle(Vector256<short> vector, Vector256<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> Shuffle(Vector256<ushort> vector, Vector256<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> Shuffle(Vector256<int> vector, Vector256<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> Shuffle(Vector256<uint> vector, Vector256<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> Shuffle(Vector256<long> vector, Vector256<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> Shuffle(Vector256<ulong> vector, Vector256<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Shuffle_Args(indices, out args0, out args1);
#else
            _instance.Shuffle_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Shuffle_Args(indices, out args0, out args1);
#else
            _instance.Shuffle_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Shuffle_Args(indices, out args0, out args1);
#else
            _instance.Shuffle_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Shuffle_Args(indices, out args0, out args1);
#else
            _instance.Shuffle_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Shuffle_Args(indices, out args0, out args1);
#else
            _instance.Shuffle_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Shuffle_Args(indices, out args0, out args1);
#else
            _instance.Shuffle_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Shuffle_Args(indices, out args0, out args1);
#else
            _instance.Shuffle_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Shuffle_Args(indices, out args0, out args1);
#else
            _instance.Shuffle_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{float}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<float> Shuffle_Core(Vector256<float> vector, Vector256<int> args0, Vector256<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{double}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<double> Shuffle_Core(Vector256<double> vector, Vector256<long> args0, Vector256<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> Shuffle_Core(Vector256<sbyte> vector, Vector256<sbyte> args0, Vector256<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> Shuffle_Core(Vector256<byte> vector, Vector256<byte> args0, Vector256<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> Shuffle_Core(Vector256<short> vector, Vector256<short> args0, Vector256<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> Shuffle_Core(Vector256<ushort> vector, Vector256<ushort> args0, Vector256<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> Shuffle_Core(Vector256<int> vector, Vector256<int> args0, Vector256<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> Shuffle_Core(Vector256<uint> vector, Vector256<uint> args0, Vector256<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> Shuffle_Core(Vector256<long> vector, Vector256<long> args0, Vector256<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> Shuffle_Core(Vector256<ulong> vector, Vector256<ulong> args0, Vector256<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.Sum_AcceleratedTypes"/>
        public static TypeCodeFlags Sum_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Sum_AcceleratedTypes;
#else
                return _instance.Sum_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sum(Vector256<float> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Sum(Vector256<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Sum(Vector256<sbyte> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Sum(Vector256<byte> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Sum(Vector256<short> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort Sum(Vector256<ushort> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sum(Vector256<int> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Sum(Vector256<uint> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Sum(Vector256<long> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Sum(Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Sum(Vector256<ulong> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits256.Widen_AcceleratedTypes"/>
        public static TypeCodeFlags Widen_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Widen_AcceleratedTypes;
#else
                return _instance.Widen_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{float}, out Vector256{double}, out Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Widen(Vector256<float> source, out Vector256<double> lower, out Vector256<double> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Widen(source, out lower, out upper);
#else
            _instance.Widen(source, out lower, out upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{sbyte}, out Vector256{short}, out Vector256{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Widen(Vector256<sbyte> source, out Vector256<short> lower, out Vector256<short> upper) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            BaseStatics.Widen(source, out lower, out upper);
#else
            _instance.Widen(source, out lower, out upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{byte}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Widen(Vector256<byte> source, out Vector256<ushort> lower, out Vector256<ushort> upper) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            BaseStatics.Widen(source, out lower, out upper);
#else
            _instance.Widen(source, out lower, out upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{short}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Widen(Vector256<short> source, out Vector256<int> lower, out Vector256<int> upper) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            BaseStatics.Widen(source, out lower, out upper);
#else
            _instance.Widen(source, out lower, out upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{ushort}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Widen(Vector256<ushort> source, out Vector256<uint> lower, out Vector256<uint> upper) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            BaseStatics.Widen(source, out lower, out upper);
#else
            _instance.Widen(source, out lower, out upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{int}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Widen(Vector256<int> source, out Vector256<long> lower, out Vector256<long> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Widen(source, out lower, out upper);
#else
            _instance.Widen(source, out lower, out upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits256.Widen(Vector256{uint}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Widen(Vector256<uint> source, out Vector256<ulong> lower, out Vector256<ulong> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Widen(source, out lower, out upper);
#else
            _instance.Widen(source, out lower, out upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
