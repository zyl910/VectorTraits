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
using Zyl.VectorTraits.Impl.AVector512;

namespace Zyl.VectorTraits {
    using BaseStatics = WVectorTraits512Base.Statics;

    static partial class Vector512s {
        private static readonly IWVectorTraits512 _instance = WVectorTraits512Abstract.GetBestInstance(); // Best traits instance.
        private static readonly dynamic _instanceDynamic = _instance; // Best traits instance dynamic value.
        private static readonly WVectorTraits512Base _baseInstance = WVectorTraits512Base.Instance; // Best traits instance.

        private static readonly string[] _traitsNames = {
            "WVectorTraits512Base",
            "WVectorTraits512Avx2"
        };

        private static readonly IWVectorTraits512[] _traitsInstances = {
            WVectorTraits512Base.Instance,
            WVectorTraits512Avx512.Instance
        };

        // Statics types (静态类型集).
        private static readonly Type[] _staticsTypes = {
            typeof(WVectorTraits512Base.Statics),
            typeof(WVectorTraits512Avx512.Statics)
        };

        /// <summary>Best traits instance (最佳特征实例). </summary>
        [CLSCompliant(false)]
        public static IWVectorTraits512 Instance {
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
        public static WVectorTraits512Base BaseInstance {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return _baseInstance; }
        }

        /// <summary>Traits name list (特征名称列表). </summary>
        public static IReadOnlyList<string> TraitsNames {
            get { return _traitsNames; }
        }

        /// <summary>Traits instance list (特征实例列表). </summary>
        [CLSCompliant(false)]
        public static IReadOnlyList<IWVectorTraits512> TraitsInstances {
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

#if NET8_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits512.Ceiling_AcceleratedTypes"/>
        public static TypeCodeFlags Ceiling_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Ceiling_AcceleratedTypes;
#else
                return _instance.Ceiling_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Ceiling(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> Ceiling(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Ceiling(value);
#else
            return _instance.Ceiling(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Ceiling(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> Ceiling(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Ceiling(value);
#else
            return _instance.Ceiling(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble_AcceleratedTypes"/>
        public static TypeCodeFlags ConvertToDouble_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ConvertToDouble_AcceleratedTypes;
#else
                return _instance.ConvertToDouble_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble(Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> ConvertToDouble(Vector512<long> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToDouble(value);
#else
            return _instance.ConvertToDouble(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> ConvertToDouble(Vector512<ulong> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToDouble(value);
#else
            return _instance.ConvertToDouble(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble_Range52(Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> ConvertToDouble_Range52(Vector512<long> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToDouble_Range52(value);
#else
            return _instance.ConvertToDouble_Range52(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToDouble_Range52(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> ConvertToDouble_Range52(Vector512<ulong> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToDouble_Range52(value);
#else
            return _instance.ConvertToDouble_Range52(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.ConvertToInt32_AcceleratedTypes"/>
        public static TypeCodeFlags ConvertToInt32_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ConvertToInt32_AcceleratedTypes;
#else
                return _instance.ConvertToInt32_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToInt32(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> ConvertToInt32(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ConvertToInt32(value);
#else
            return _instance.ConvertToInt32(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64_AcceleratedTypes"/>
        public static TypeCodeFlags ConvertToInt64_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ConvertToInt64_AcceleratedTypes;
#else
                return _instance.ConvertToInt64_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> ConvertToInt64(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToInt64(value);
#else
            return _instance.ConvertToInt64(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64_Range52(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> ConvertToInt64_Range52(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToInt64_Range52(value);
#else
            return _instance.ConvertToInt64_Range52(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToInt64_Range52RoundToEven(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> ConvertToInt64_Range52RoundToEven(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToInt64_Range52RoundToEven(value);
#else
            return _instance.ConvertToInt64_Range52RoundToEven(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.ConvertToSingle_AcceleratedTypes"/>
        public static TypeCodeFlags ConvertToSingle_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ConvertToSingle_AcceleratedTypes;
#else
                return _instance.ConvertToSingle_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToSingle(Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> ConvertToSingle(Vector512<int> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ConvertToSingle(value);
#else
            return _instance.ConvertToSingle(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToSingle(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> ConvertToSingle(Vector512<uint> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToSingle(value);
#else
            return _instance.ConvertToSingle(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt32_AcceleratedTypes"/>
        public static TypeCodeFlags ConvertToUInt32_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ConvertToUInt32_AcceleratedTypes;
#else
                return _instance.ConvertToUInt32_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt32(Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> ConvertToUInt32(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToUInt32(value);
#else
            return _instance.ConvertToUInt32(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt64_AcceleratedTypes"/>
        public static TypeCodeFlags ConvertToUInt64_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ConvertToUInt64_AcceleratedTypes;
#else
                return _instance.ConvertToUInt64_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt64(Vector512{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> ConvertToUInt64(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToUInt64(value);
#else
            return _instance.ConvertToUInt64(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt64_Range52(Vector512{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> ConvertToUInt64_Range52(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToUInt64_Range52(value);
#else
            return _instance.ConvertToUInt64_Range52(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ConvertToUInt64_Range52RoundToEven(Vector512{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> ConvertToUInt64_Range52RoundToEven(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToUInt64_Range52RoundToEven(value);
#else
            return _instance.ConvertToUInt64_Range52RoundToEven(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits_AcceleratedTypes"/>
        public static TypeCodeFlags ExtractMostSignificantBits_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ExtractMostSignificantBits_AcceleratedTypes;
#else
                return _instance.ExtractMostSignificantBits_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ExtractMostSignificantBits(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(value);
#else
            return _instance.ExtractMostSignificantBits(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ExtractMostSignificantBits(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(value);
#else
            return _instance.ExtractMostSignificantBits(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ExtractMostSignificantBits(Vector512<sbyte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(value);
#else
            return _instance.ExtractMostSignificantBits(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ExtractMostSignificantBits(Vector512<byte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(value);
#else
            return _instance.ExtractMostSignificantBits(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ExtractMostSignificantBits(Vector512<short> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(value);
#else
            return _instance.ExtractMostSignificantBits(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ExtractMostSignificantBits(Vector512<ushort> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(value);
#else
            return _instance.ExtractMostSignificantBits(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ExtractMostSignificantBits(Vector512<int> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(value);
#else
            return _instance.ExtractMostSignificantBits(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ExtractMostSignificantBits(Vector512<uint> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(value);
#else
            return _instance.ExtractMostSignificantBits(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ExtractMostSignificantBits(Vector512<long> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(value);
#else
            return _instance.ExtractMostSignificantBits(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ExtractMostSignificantBits(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ExtractMostSignificantBits(Vector512<ulong> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(value);
#else
            return _instance.ExtractMostSignificantBits(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.Floor_AcceleratedTypes"/>
        public static TypeCodeFlags Floor_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Floor_AcceleratedTypes;
#else
                return _instance.Floor_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Floor(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> Floor(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Floor(value);
#else
            return _instance.Floor(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Floor(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> Floor(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Floor(value);
#else
            return _instance.Floor(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.Narrow_AcceleratedTypes"/>
        public static TypeCodeFlags Narrow_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Narrow_AcceleratedTypes;
#else
                return _instance.Narrow_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{double}, Vector512{double})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> Narrow(Vector512<double> lower, Vector512<double> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Narrow(lower, upper);
#else
            return _instance.Narrow(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{short}, Vector512{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> Narrow(Vector512<short> lower, Vector512<short> upper) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Narrow(lower, upper);
#else
            return _instance.Narrow(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{ushort}, Vector512{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> Narrow(Vector512<ushort> lower, Vector512<ushort> upper) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Narrow(lower, upper);
#else
            return _instance.Narrow(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{int}, Vector512{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> Narrow(Vector512<int> lower, Vector512<int> upper) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Narrow(lower, upper);
#else
            return _instance.Narrow(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{uint}, Vector512{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> Narrow(Vector512<uint> lower, Vector512<uint> upper) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Narrow(lower, upper);
#else
            return _instance.Narrow(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{long}, Vector512{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> Narrow(Vector512<long> lower, Vector512<long> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Narrow(lower, upper);
#else
            return _instance.Narrow(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Narrow(Vector512{ulong}, Vector512{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> Narrow(Vector512<ulong> lower, Vector512<ulong> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Narrow(lower, upper);
#else
            return _instance.Narrow(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_AcceleratedTypes"/>
        public static TypeCodeFlags ShiftLeft_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ShiftLeft_AcceleratedTypes;
#else
                return _instance.ShiftLeft_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> ShiftLeft(Vector512<sbyte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> ShiftLeft(Vector512<byte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> ShiftLeft(Vector512<short> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> ShiftLeft(Vector512<ushort> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> ShiftLeft(Vector512<int> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> ShiftLeft(Vector512<uint> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> ShiftLeft(Vector512<long> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft(Vector512{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> ShiftLeft(Vector512<ulong> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{sbyte}, int, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> ShiftLeft_Args(Vector512<sbyte> dummy, int shiftAmount, out Vector512<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftLeft_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{byte}, int, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> ShiftLeft_Args(Vector512<byte> dummy, int shiftAmount, out Vector512<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftLeft_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{short}, int, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> ShiftLeft_Args(Vector512<short> dummy, int shiftAmount, out Vector512<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftLeft_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{ushort}, int, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> ShiftLeft_Args(Vector512<ushort> dummy, int shiftAmount, out Vector512<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftLeft_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{int}, int, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> ShiftLeft_Args(Vector512<int> dummy, int shiftAmount, out Vector512<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftLeft_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{uint}, int, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> ShiftLeft_Args(Vector512<uint> dummy, int shiftAmount, out Vector512<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftLeft_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{long}, int, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> ShiftLeft_Args(Vector512<long> dummy, int shiftAmount, out Vector512<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftLeft_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Args(Vector512{ulong}, int, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> ShiftLeft_Args(Vector512<ulong> dummy, int shiftAmount, out Vector512<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftLeft_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> ShiftLeft_Core(Vector512<sbyte> value, int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> ShiftLeft_Core(Vector512<byte> value, int shiftAmount, Vector512<byte> args0, Vector512<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> ShiftLeft_Core(Vector512<short> value, int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{ushort}, int, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> ShiftLeft_Core(Vector512<ushort> value, int shiftAmount, Vector512<ushort> args0, Vector512<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> ShiftLeft_Core(Vector512<int> value, int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{uint}, int, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> ShiftLeft_Core(Vector512<uint> value, int shiftAmount, Vector512<uint> args0, Vector512<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> ShiftLeft_Core(Vector512<long> value, int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Core(Vector512{ulong}, int, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> ShiftLeft_Core(Vector512<ulong> value, int shiftAmount, Vector512<ulong> args0, Vector512<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> ShiftLeft_Const(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Const(value, shiftAmount);
#else
            return _instance.ShiftLeft_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> ShiftLeft_Const(Vector512<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Const(value, shiftAmount);
#else
            return _instance.ShiftLeft_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> ShiftLeft_Const(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftLeft_Const(value, shiftAmount);
#else
            return _instance.ShiftLeft_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> ShiftLeft_Const(Vector512<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftLeft_Const(value, shiftAmount);
#else
            return _instance.ShiftLeft_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> ShiftLeft_Const(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftLeft_Const(value, shiftAmount);
#else
            return _instance.ShiftLeft_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> ShiftLeft_Const(Vector512<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftLeft_Const(value, shiftAmount);
#else
            return _instance.ShiftLeft_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> ShiftLeft_Const(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Const(value, shiftAmount);
#else
            return _instance.ShiftLeft_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Const(Vector512{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> ShiftLeft_Const(Vector512<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Const(value, shiftAmount);
#else
            return _instance.ShiftLeft_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> ShiftLeft_ConstCore(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> ShiftLeft_ConstCore(Vector512<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector512<byte> args0, Vector512<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> ShiftLeft_ConstCore(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{ushort}, int, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> ShiftLeft_ConstCore(Vector512<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<ushort> args0, Vector512<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> ShiftLeft_ConstCore(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{uint}, int, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> ShiftLeft_ConstCore(Vector512<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<uint> args0, Vector512<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> ShiftLeft_ConstCore(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_ConstCore(Vector512{ulong}, int, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> ShiftLeft_ConstCore(Vector512<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<ulong> args0, Vector512<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> ShiftLeft_Fast(Vector512<sbyte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Fast(value, shiftAmount);
#else
            return _instance.ShiftLeft_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> ShiftLeft_Fast(Vector512<byte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Fast(value, shiftAmount);
#else
            return _instance.ShiftLeft_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> ShiftLeft_Fast(Vector512<short> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftLeft_Fast(value, shiftAmount);
#else
            return _instance.ShiftLeft_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> ShiftLeft_Fast(Vector512<ushort> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftLeft_Fast(value, shiftAmount);
#else
            return _instance.ShiftLeft_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> ShiftLeft_Fast(Vector512<int> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftLeft_Fast(value, shiftAmount);
#else
            return _instance.ShiftLeft_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> ShiftLeft_Fast(Vector512<uint> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftLeft_Fast(value, shiftAmount);
#else
            return _instance.ShiftLeft_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> ShiftLeft_Fast(Vector512<long> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Fast(value, shiftAmount);
#else
            return _instance.ShiftLeft_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftLeft_Fast(Vector512{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> ShiftLeft_Fast(Vector512<ulong> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Fast(value, shiftAmount);
#else
            return _instance.ShiftLeft_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_AcceleratedTypes"/>
        public static TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ShiftRightArithmetic_AcceleratedTypes;
#else
                return _instance.ShiftRightArithmetic_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> ShiftRightArithmetic(Vector512<sbyte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> ShiftRightArithmetic(Vector512<short> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> ShiftRightArithmetic(Vector512<int> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic(Vector512{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> ShiftRightArithmetic(Vector512<long> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Args(Vector512{sbyte}, int, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> ShiftRightArithmetic_Args(Vector512<sbyte> dummy, int shiftAmount, out Vector512<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Args(Vector512{short}, int, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> ShiftRightArithmetic_Args(Vector512<short> dummy, int shiftAmount, out Vector512<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Args(Vector512{int}, int, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> ShiftRightArithmetic_Args(Vector512<int> dummy, int shiftAmount, out Vector512<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Args(Vector512{long}, int, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> ShiftRightArithmetic_Args(Vector512<long> dummy, int shiftAmount, out Vector512<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightArithmetic_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> ShiftRightArithmetic_Core(Vector512<sbyte> value, int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> ShiftRightArithmetic_Core(Vector512<short> value, int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> ShiftRightArithmetic_Core(Vector512<int> value, int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Core(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> ShiftRightArithmetic_Core(Vector512<long> value, int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightArithmetic_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Const(Vector512{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> ShiftRightArithmetic_Const(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Const(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Const(Vector512{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> ShiftRightArithmetic_Const(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightArithmetic_Const(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Const(Vector512{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> ShiftRightArithmetic_Const(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightArithmetic_Const(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Const(Vector512{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> ShiftRightArithmetic_Const(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Const(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_ConstCore(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> ShiftRightArithmetic_ConstCore(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_ConstCore(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> ShiftRightArithmetic_ConstCore(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_ConstCore(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> ShiftRightArithmetic_ConstCore(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_ConstCore(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> ShiftRightArithmetic_ConstCore(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightArithmetic_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> ShiftRightArithmetic_Fast(Vector512<sbyte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> ShiftRightArithmetic_Fast(Vector512<short> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightArithmetic_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> ShiftRightArithmetic_Fast(Vector512<int> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightArithmetic_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightArithmetic_Fast(Vector512{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> ShiftRightArithmetic_Fast(Vector512<long> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_AcceleratedTypes"/>
        public static TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ShiftRightLogical_AcceleratedTypes;
#else
                return _instance.ShiftRightLogical_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> ShiftRightLogical(Vector512<sbyte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> ShiftRightLogical(Vector512<byte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> ShiftRightLogical(Vector512<short> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> ShiftRightLogical(Vector512<ushort> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> ShiftRightLogical(Vector512<int> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> ShiftRightLogical(Vector512<uint> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> ShiftRightLogical(Vector512<long> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical(Vector512{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> ShiftRightLogical(Vector512<ulong> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{sbyte}, int, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> ShiftRightLogical_Args(Vector512<sbyte> dummy, int shiftAmount, out Vector512<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{byte}, int, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> ShiftRightLogical_Args(Vector512<byte> dummy, int shiftAmount, out Vector512<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{short}, int, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> ShiftRightLogical_Args(Vector512<short> dummy, int shiftAmount, out Vector512<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{ushort}, int, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> ShiftRightLogical_Args(Vector512<ushort> dummy, int shiftAmount, out Vector512<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{int}, int, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> ShiftRightLogical_Args(Vector512<int> dummy, int shiftAmount, out Vector512<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{uint}, int, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> ShiftRightLogical_Args(Vector512<uint> dummy, int shiftAmount, out Vector512<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{long}, int, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> ShiftRightLogical_Args(Vector512<long> dummy, int shiftAmount, out Vector512<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Args(Vector512{ulong}, int, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> ShiftRightLogical_Args(Vector512<ulong> dummy, int shiftAmount, out Vector512<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> ShiftRightLogical_Core(Vector512<sbyte> value, int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> ShiftRightLogical_Core(Vector512<byte> value, int shiftAmount, Vector512<byte> args0, Vector512<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> ShiftRightLogical_Core(Vector512<short> value, int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{ushort}, int, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> ShiftRightLogical_Core(Vector512<ushort> value, int shiftAmount, Vector512<ushort> args0, Vector512<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> ShiftRightLogical_Core(Vector512<int> value, int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{uint}, int, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> ShiftRightLogical_Core(Vector512<uint> value, int shiftAmount, Vector512<uint> args0, Vector512<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> ShiftRightLogical_Core(Vector512<long> value, int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Core(Vector512{ulong}, int, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> ShiftRightLogical_Core(Vector512<ulong> value, int shiftAmount, Vector512<ulong> args0, Vector512<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> ShiftRightLogical_Const(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Const(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> ShiftRightLogical_Const(Vector512<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Const(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> ShiftRightLogical_Const(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical_Const(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> ShiftRightLogical_Const(Vector512<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical_Const(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> ShiftRightLogical_Const(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical_Const(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> ShiftRightLogical_Const(Vector512<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical_Const(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> ShiftRightLogical_Const(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Const(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Const(Vector512{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> ShiftRightLogical_Const(Vector512<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Const(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{sbyte}, int, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> ShiftRightLogical_ConstCore(Vector512<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector512<sbyte> args0, Vector512<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{byte}, int, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> ShiftRightLogical_ConstCore(Vector512<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector512<byte> args0, Vector512<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{short}, int, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> ShiftRightLogical_ConstCore(Vector512<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<short> args0, Vector512<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{ushort}, int, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> ShiftRightLogical_ConstCore(Vector512<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector512<ushort> args0, Vector512<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{int}, int, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> ShiftRightLogical_ConstCore(Vector512<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<int> args0, Vector512<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{uint}, int, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> ShiftRightLogical_ConstCore(Vector512<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector512<uint> args0, Vector512<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{long}, int, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> ShiftRightLogical_ConstCore(Vector512<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<long> args0, Vector512<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_ConstCore(Vector512{ulong}, int, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> ShiftRightLogical_ConstCore(Vector512<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector512<ulong> args0, Vector512<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> ShiftRightLogical_Fast(Vector512<sbyte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> ShiftRightLogical_Fast(Vector512<byte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> ShiftRightLogical_Fast(Vector512<short> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> ShiftRightLogical_Fast(Vector512<ushort> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> ShiftRightLogical_Fast(Vector512<int> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> ShiftRightLogical_Fast(Vector512<uint> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.ShiftRightLogical_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> ShiftRightLogical_Fast(Vector512<long> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.ShiftRightLogical_Fast(Vector512{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> ShiftRightLogical_Fast(Vector512<ulong> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.Shuffle_AcceleratedTypes"/>
        public static TypeCodeFlags Shuffle_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Shuffle_AcceleratedTypes;
#else
                return _instance.Shuffle_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{float}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> Shuffle(Vector512<float> vector, Vector512<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{double}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> Shuffle(Vector512<double> vector, Vector512<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> Shuffle(Vector512<sbyte> vector, Vector512<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> Shuffle(Vector512<byte> vector, Vector512<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> Shuffle(Vector512<short> vector, Vector512<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> Shuffle(Vector512<ushort> vector, Vector512<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> Shuffle(Vector512<int> vector, Vector512<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> Shuffle(Vector512<uint> vector, Vector512<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> Shuffle(Vector512<long> vector, Vector512<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle(Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> Shuffle(Vector512<ulong> vector, Vector512<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{sbyte}, out Vector512{sbyte}, out Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle_Args(Vector512<sbyte> indices, out Vector512<sbyte> args0, out Vector512<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Shuffle_Args(indices, out args0, out args1);
#else
            _instance.Shuffle_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{byte}, out Vector512{byte}, out Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle_Args(Vector512<byte> indices, out Vector512<byte> args0, out Vector512<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Shuffle_Args(indices, out args0, out args1);
#else
            _instance.Shuffle_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{short}, out Vector512{short}, out Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle_Args(Vector512<short> indices, out Vector512<short> args0, out Vector512<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Shuffle_Args(indices, out args0, out args1);
#else
            _instance.Shuffle_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{ushort}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle_Args(Vector512<ushort> indices, out Vector512<ushort> args0, out Vector512<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Shuffle_Args(indices, out args0, out args1);
#else
            _instance.Shuffle_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{int}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle_Args(Vector512<int> indices, out Vector512<int> args0, out Vector512<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Shuffle_Args(indices, out args0, out args1);
#else
            _instance.Shuffle_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{uint}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle_Args(Vector512<uint> indices, out Vector512<uint> args0, out Vector512<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Shuffle_Args(indices, out args0, out args1);
#else
            _instance.Shuffle_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{long}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle_Args(Vector512<long> indices, out Vector512<long> args0, out Vector512<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Shuffle_Args(indices, out args0, out args1);
#else
            _instance.Shuffle_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Args(Vector512{ulong}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle_Args(Vector512<ulong> indices, out Vector512<ulong> args0, out Vector512<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Shuffle_Args(indices, out args0, out args1);
#else
            _instance.Shuffle_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{float}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<float> Shuffle_Core(Vector512<float> vector, Vector512<int> args0, Vector512<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{double}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> Shuffle_Core(Vector512<double> vector, Vector512<long> args0, Vector512<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{sbyte}, Vector512{sbyte}, Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<sbyte> Shuffle_Core(Vector512<sbyte> vector, Vector512<sbyte> args0, Vector512<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{byte}, Vector512{byte}, Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<byte> Shuffle_Core(Vector512<byte> vector, Vector512<byte> args0, Vector512<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{short}, Vector512{short}, Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> Shuffle_Core(Vector512<short> vector, Vector512<short> args0, Vector512<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{ushort}, Vector512{ushort}, Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> Shuffle_Core(Vector512<ushort> vector, Vector512<ushort> args0, Vector512<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{int}, Vector512{int}, Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> Shuffle_Core(Vector512<int> vector, Vector512<int> args0, Vector512<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{uint}, Vector512{uint}, Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> Shuffle_Core(Vector512<uint> vector, Vector512<uint> args0, Vector512<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{long}, Vector512{long}, Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> Shuffle_Core(Vector512<long> vector, Vector512<long> args0, Vector512<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Shuffle_Core(Vector512{ulong}, Vector512{ulong}, Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> Shuffle_Core(Vector512<ulong> vector, Vector512<ulong> args0, Vector512<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.Sum_AcceleratedTypes"/>
        public static TypeCodeFlags Sum_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Sum_AcceleratedTypes;
#else
                return _instance.Sum_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sum(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Sum(Vector512<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Sum(Vector512<sbyte> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Sum(Vector512<byte> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Sum(Vector512<short> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort Sum(Vector512<ushort> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sum(Vector512<int> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Sum(Vector512<uint> value) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Sum(Vector512<long> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Sum(Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Sum(Vector512<ulong> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.Widen_AcceleratedTypes"/>
        public static TypeCodeFlags Widen_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Widen_AcceleratedTypes;
#else
                return _instance.Widen_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{float}, out Vector512{double}, out Vector512{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Widen(Vector512<float> source, out Vector512<double> lower, out Vector512<double> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Widen(source, out lower, out upper);
#else
            _instance.Widen(source, out lower, out upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{sbyte}, out Vector512{short}, out Vector512{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Widen(Vector512<sbyte> source, out Vector512<short> lower, out Vector512<short> upper) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            BaseStatics.Widen(source, out lower, out upper);
#else
            _instance.Widen(source, out lower, out upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{byte}, out Vector512{ushort}, out Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Widen(Vector512<byte> source, out Vector512<ushort> lower, out Vector512<ushort> upper) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            BaseStatics.Widen(source, out lower, out upper);
#else
            _instance.Widen(source, out lower, out upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{short}, out Vector512{int}, out Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Widen(Vector512<short> source, out Vector512<int> lower, out Vector512<int> upper) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            BaseStatics.Widen(source, out lower, out upper);
#else
            _instance.Widen(source, out lower, out upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{ushort}, out Vector512{uint}, out Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Widen(Vector512<ushort> source, out Vector512<uint> lower, out Vector512<uint> upper) {
#if BCL_BASE_OVERRIDE_STATIC || (BCL_VER_OVERRIDE_STATIC && NET7_0_OR_GREATER)
            BaseStatics.Widen(source, out lower, out upper);
#else
            _instance.Widen(source, out lower, out upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{int}, out Vector512{long}, out Vector512{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Widen(Vector512<int> source, out Vector512<long> lower, out Vector512<long> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Widen(source, out lower, out upper);
#else
            _instance.Widen(source, out lower, out upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.Widen(Vector512{uint}, out Vector512{ulong}, out Vector512{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Widen(Vector512<uint> source, out Vector512<ulong> lower, out Vector512<ulong> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Widen(source, out lower, out upper);
#else
            _instance.Widen(source, out lower, out upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IWVectorTraits512.WidenLower_AcceleratedTypes"/>
        public static TypeCodeFlags WidenLower_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.WidenLower_AcceleratedTypes;
#else
                return _instance.WidenLower_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IWVectorTraits512.WidenLower(Vector512{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<double> WidenLower(Vector512<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.WidenLower(value);
#else
            return _instance.WidenLower(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.WidenLower(Vector512{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<short> WidenLower(Vector512<sbyte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.WidenLower(value);
#else
            return _instance.WidenLower(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.WidenLower(Vector512{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ushort> WidenLower(Vector512<byte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.WidenLower(value);
#else
            return _instance.WidenLower(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.WidenLower(Vector512{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<int> WidenLower(Vector512<short> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.WidenLower(value);
#else
            return _instance.WidenLower(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.WidenLower(Vector512{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<uint> WidenLower(Vector512<ushort> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.WidenLower(value);
#else
            return _instance.WidenLower(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.WidenLower(Vector512{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<long> WidenLower(Vector512<int> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.WidenLower(value);
#else
            return _instance.WidenLower(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IWVectorTraits512.WidenLower(Vector512{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector512<ulong> WidenLower(Vector512<uint> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.WidenLower(value);
#else
            return _instance.WidenLower(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

#endif // NET8_0_OR_GREATER
    }
}
