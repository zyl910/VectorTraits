using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.AVector;

namespace Zyl.VectorTraits {
    using BaseStatics = VectorTraitsBase.Statics;

    public static partial class Vectors {
        private static readonly IVectorTraits _instance = VectorTraitsAbstract.GetBestInstance(); // Best traits instance.
        private static readonly dynamic _instanceDynamic = _instance; // Best traits instance dynamic value.
        private static readonly IVectorTraits _baseInstance = VectorTraitsAbstract.GetBaseInstance(); // Base traits instance.
        private static readonly dynamic _baseInstanceDynamic = _baseInstance; // Base traits instance dynamic value.

        private static readonly string[] _traitsNames = {
            "VectorTraitsBase",
            "VectorTraits128Base",
            "VectorTraits128AdvSimd",
            "VectorTraits128AdvSimdB64",
            "VectorTraits256Base",
            "VectorTraits256Avx2"
        };

        private static readonly IVectorTraits[] _traitsInstances = {
            VectorTraitsBase.Instance,
            VectorTraits128Base.Instance,
            VectorTraits128AdvSimd.Instance,
            VectorTraits128AdvSimdB64.Instance,
            VectorTraits256Base.Instance,
            VectorTraits256Avx2.Instance
        };

        // Statics types (静态类型集).
        private static readonly Type[] _staticsTypes = {
            typeof(VectorTraitsBase.Statics),
            typeof(VectorTraits128Base.Statics),
            typeof(VectorTraits128AdvSimd.Statics),
            typeof(VectorTraits128AdvSimdB64.Statics),
            typeof(VectorTraits256Base.Statics),
            typeof(VectorTraits256Avx2.Statics)
        };

        /// <summary>Best traits instance (最佳特征实例). </summary>
        [CLSCompliant(false)]
        public static IVectorTraits Instance {
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
        public static IVectorTraits BaseInstance {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return _baseInstance; }
        }

        /// <summary>Base traits instance dynamic value (基本特征实例动态值). </summary>
        public static dynamic BaseInstanceDynamic {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return _baseInstanceDynamic; }
        }

        /// <summary>Traits name list (特征名称列表). </summary>
        public static IReadOnlyList<string> TraitsNames {
            get { return _traitsNames; }
        }

        /// <summary>Traits instance list (特征实例列表). </summary>
        [CLSCompliant(false)]
        public static IReadOnlyList<IVectorTraits> TraitsInstances {
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


        /// <inheritdoc cref="IVectorTraits.Ceiling_AcceleratedTypes"/>
        public static TypeCodeFlags Ceiling_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Ceiling_AcceleratedTypes;
#else
                return _instance.Ceiling_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.Ceiling(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> Ceiling(Vector<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Ceiling(value);
#else
            return _instance.Ceiling(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Ceiling(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> Ceiling(Vector<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Ceiling(value);
#else
            return _instance.Ceiling(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.ConvertToDouble_AcceleratedTypes"/>
        public static TypeCodeFlags ConvertToDouble_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ConvertToDouble_AcceleratedTypes;
#else
                return _instance.ConvertToDouble_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.ConvertToDouble(Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> ConvertToDouble(Vector<long> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToDouble(value);
#else
            return _instance.ConvertToDouble(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ConvertToDouble(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> ConvertToDouble(Vector<ulong> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToDouble(value);
#else
            return _instance.ConvertToDouble(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.ConvertToInt32_AcceleratedTypes"/>
        public static TypeCodeFlags ConvertToInt32_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ConvertToInt32_AcceleratedTypes;
#else
                return _instance.ConvertToInt32_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.ConvertToInt32(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> ConvertToInt32(Vector<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToInt32(value);
#else
            return _instance.ConvertToInt32(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.ConvertToInt64_AcceleratedTypes"/>
        public static TypeCodeFlags ConvertToInt64_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ConvertToInt64_AcceleratedTypes;
#else
                return _instance.ConvertToInt64_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.ConvertToInt64(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> ConvertToInt64(Vector<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToInt64(value);
#else
            return _instance.ConvertToInt64(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.ConvertToSingle_AcceleratedTypes"/>
        public static TypeCodeFlags ConvertToSingle_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ConvertToSingle_AcceleratedTypes;
#else
                return _instance.ConvertToSingle_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.ConvertToSingle(Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> ConvertToSingle(Vector<int> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToSingle(value);
#else
            return _instance.ConvertToSingle(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ConvertToSingle(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> ConvertToSingle(Vector<uint> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToSingle(value);
#else
            return _instance.ConvertToSingle(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.ConvertToUInt32_AcceleratedTypes"/>
        public static TypeCodeFlags ConvertToUInt32_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ConvertToUInt32_AcceleratedTypes;
#else
                return _instance.ConvertToUInt32_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.ConvertToUInt32(Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> ConvertToUInt32(Vector<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToUInt32(value);
#else
            return _instance.ConvertToUInt32(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.ConvertToUInt64_AcceleratedTypes"/>
        public static TypeCodeFlags ConvertToUInt64_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ConvertToUInt64_AcceleratedTypes;
#else
                return _instance.ConvertToUInt64_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.ConvertToUInt64(Vector{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> ConvertToUInt64(Vector<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ConvertToUInt64(value);
#else
            return _instance.ConvertToUInt64(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits_AcceleratedTypes"/>
        public static TypeCodeFlags ExtractMostSignificantBits_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ExtractMostSignificantBits_AcceleratedTypes;
#else
                return _instance.ExtractMostSignificantBits_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{float})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ExtractMostSignificantBits(Vector<float> vector) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(vector);
#else
            return _instance.ExtractMostSignificantBits(vector);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{double})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ExtractMostSignificantBits(Vector<double> vector) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(vector);
#else
            return _instance.ExtractMostSignificantBits(vector);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ExtractMostSignificantBits(Vector<sbyte> vector) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(vector);
#else
            return _instance.ExtractMostSignificantBits(vector);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{byte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ExtractMostSignificantBits(Vector<byte> vector) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(vector);
#else
            return _instance.ExtractMostSignificantBits(vector);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ExtractMostSignificantBits(Vector<short> vector) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(vector);
#else
            return _instance.ExtractMostSignificantBits(vector);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ExtractMostSignificantBits(Vector<ushort> vector) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(vector);
#else
            return _instance.ExtractMostSignificantBits(vector);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{int})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ExtractMostSignificantBits(Vector<int> vector) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(vector);
#else
            return _instance.ExtractMostSignificantBits(vector);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ExtractMostSignificantBits(Vector<uint> vector) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(vector);
#else
            return _instance.ExtractMostSignificantBits(vector);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{long})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ExtractMostSignificantBits(Vector<long> vector) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(vector);
#else
            return _instance.ExtractMostSignificantBits(vector);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ExtractMostSignificantBits(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ExtractMostSignificantBits(Vector<ulong> vector) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ExtractMostSignificantBits(vector);
#else
            return _instance.ExtractMostSignificantBits(vector);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.Floor_AcceleratedTypes"/>
        public static TypeCodeFlags Floor_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Floor_AcceleratedTypes;
#else
                return _instance.Ceiling_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.Floor(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> Floor(Vector<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Floor(value);
#else
            return _instance.Floor(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Floor(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> Floor(Vector<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Floor(value);
#else
            return _instance.Floor(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.Narrow_AcceleratedTypes"/>
        public static TypeCodeFlags Narrow_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Narrow_AcceleratedTypes;
#else
                return _instance.Narrow_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{double}, Vector{double})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> Narrow(Vector<double> lower, Vector<double> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Narrow(lower, upper);
#else
            return _instance.Narrow(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{short}, Vector{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> Narrow(Vector<short> lower, Vector<short> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Narrow(lower, upper);
#else
            return _instance.Narrow(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{ushort}, Vector{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> Narrow(Vector<ushort> lower, Vector<ushort> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Narrow(lower, upper);
#else
            return _instance.Narrow(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{int}, Vector{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> Narrow(Vector<int> lower, Vector<int> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Narrow(lower, upper);
#else
            return _instance.Narrow(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{uint}, Vector{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> Narrow(Vector<uint> lower, Vector<uint> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Narrow(lower, upper);
#else
            return _instance.Narrow(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{long}, Vector{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> Narrow(Vector<long> lower, Vector<long> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Narrow(lower, upper);
#else
            return _instance.Narrow(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Narrow(Vector{ulong}, Vector{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> Narrow(Vector<ulong> lower, Vector<ulong> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Narrow(lower, upper);
#else
            return _instance.Narrow(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.ShiftLeft_AcceleratedTypes"/>
        public static TypeCodeFlags ShiftLeft_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ShiftLeft_AcceleratedTypes;
#else
                return _instance.ShiftLeft_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> ShiftLeft(Vector<sbyte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> ShiftLeft(Vector<byte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> ShiftLeft(Vector<short> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> ShiftLeft(Vector<ushort> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> ShiftLeft(Vector<int> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> ShiftLeft(Vector<uint> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> ShiftLeft(Vector<long> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> ShiftLeft(Vector<ulong> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft(value, shiftAmount);
#else
            return _instance.ShiftLeft(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{sbyte}, int, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> ShiftLeft_Args(Vector<sbyte> dummy, int shiftAmount, out Vector<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftLeft_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{byte}, int, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> ShiftLeft_Args(Vector<byte> dummy, int shiftAmount, out Vector<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftLeft_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{short}, int, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> ShiftLeft_Args(Vector<short> dummy, int shiftAmount, out Vector<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftLeft_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{ushort}, int, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> ShiftLeft_Args(Vector<ushort> dummy, int shiftAmount, out Vector<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftLeft_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{int}, int, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> ShiftLeft_Args(Vector<int> dummy, int shiftAmount, out Vector<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftLeft_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{uint}, int, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> ShiftLeft_Args(Vector<uint> dummy, int shiftAmount, out Vector<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftLeft_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{long}, int, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> ShiftLeft_Args(Vector<long> dummy, int shiftAmount, out Vector<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftLeft_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Args(Vector{ulong}, int, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> ShiftLeft_Args(Vector<ulong> dummy, int shiftAmount, out Vector<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftLeft_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> ShiftLeft_Core(Vector<sbyte> value, int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> ShiftLeft_Core(Vector<byte> value, int shiftAmount, Vector<byte> args0, Vector<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> ShiftLeft_Core(Vector<short> value, Vector<short> args0, Vector<short> args1) {
#pragma warning disable CS0618 // Type or member is obsolete
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
#pragma warning restore CS0618 // Type or member is obsolete
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{short}, int, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> ShiftLeft_Core(Vector<short> value, int shiftAmount, Vector<short> args0, Vector<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{ushort}, int, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> ShiftLeft_Core(Vector<ushort> value, int shiftAmount, Vector<ushort> args0, Vector<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{int}, int, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> ShiftLeft_Core(Vector<int> value, int shiftAmount, Vector<int> args0, Vector<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{uint}, int, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> ShiftLeft_Core(Vector<uint> value, int shiftAmount, Vector<uint> args0, Vector<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{long}, int, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> ShiftLeft_Core(Vector<long> value, int shiftAmount, Vector<long> args0, Vector<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Core(Vector{ulong}, int, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> ShiftLeft_Core(Vector<ulong> value, int shiftAmount, Vector<ulong> args0, Vector<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> ShiftLeft_Const(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Const(value, shiftAmount);
#else
            return _instance.ShiftLeft_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> ShiftLeft_Const(Vector<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Const(value, shiftAmount);
#else
            return _instance.ShiftLeft_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> ShiftLeft_Const(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Const(value, shiftAmount);
#else
            return _instance.ShiftLeft_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> ShiftLeft_Const(Vector<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Const(value, shiftAmount);
#else
            return _instance.ShiftLeft_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> ShiftLeft_Const(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Const(value, shiftAmount);
#else
            return _instance.ShiftLeft_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> ShiftLeft_Const(Vector<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Const(value, shiftAmount);
#else
            return _instance.ShiftLeft_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> ShiftLeft_Const(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Const(value, shiftAmount);
#else
            return _instance.ShiftLeft_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Const(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> ShiftLeft_Const(Vector<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Const(value, shiftAmount);
#else
            return _instance.ShiftLeft_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> ShiftLeft_ConstCore(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> ShiftLeft_ConstCore(Vector<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<byte> args0, Vector<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{short}, int, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> ShiftLeft_ConstCore(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector<short> args0, Vector<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{ushort}, int, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> ShiftLeft_ConstCore(Vector<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector<ushort> args0, Vector<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{int}, int, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> ShiftLeft_ConstCore(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector<int> args0, Vector<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{uint}, int, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> ShiftLeft_ConstCore(Vector<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector<uint> args0, Vector<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{long}, int, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> ShiftLeft_ConstCore(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector<long> args0, Vector<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_ConstCore(Vector{ulong}, int, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> ShiftLeft_ConstCore(Vector<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector<ulong> args0, Vector<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftLeft_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> ShiftLeft_Fast(Vector<sbyte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Fast(value, shiftAmount);
#else
            return _instance.ShiftLeft_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> ShiftLeft_Fast(Vector<byte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Fast(value, shiftAmount);
#else
            return _instance.ShiftLeft_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> ShiftLeft_Fast(Vector<short> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Fast(value, shiftAmount);
#else
            return _instance.ShiftLeft_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> ShiftLeft_Fast(Vector<ushort> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Fast(value, shiftAmount);
#else
            return _instance.ShiftLeft_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> ShiftLeft_Fast(Vector<int> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Fast(value, shiftAmount);
#else
            return _instance.ShiftLeft_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> ShiftLeft_Fast(Vector<uint> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Fast(value, shiftAmount);
#else
            return _instance.ShiftLeft_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> ShiftLeft_Fast(Vector<long> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Fast(value, shiftAmount);
#else
            return _instance.ShiftLeft_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft_Fast(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> ShiftLeft_Fast(Vector<ulong> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeft_Fast(value, shiftAmount);
#else
            return _instance.ShiftLeft_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_AcceleratedTypes"/>
        public static TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ShiftRightArithmetic_AcceleratedTypes;
#else
                return _instance.ShiftRightArithmetic_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> ShiftRightArithmetic(Vector<sbyte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> ShiftRightArithmetic(Vector<short> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> ShiftRightArithmetic(Vector<int> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> ShiftRightArithmetic(Vector<long> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Const(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> ShiftRightArithmetic_Const(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Const(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Const(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> ShiftRightArithmetic_Const(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Const(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Const(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> ShiftRightArithmetic_Const(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Const(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Const(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> ShiftRightArithmetic_Const(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Const(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> ShiftRightArithmetic_Fast(Vector<sbyte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> ShiftRightArithmetic_Fast(Vector<short> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> ShiftRightArithmetic_Fast(Vector<int> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_Fast(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> ShiftRightArithmetic_Fast(Vector<long> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmetic_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_AcceleratedTypes"/>
        public static TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.ShiftRightLogical_AcceleratedTypes;
#else
                return _instance.ShiftRightLogical_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> ShiftRightLogical(Vector<sbyte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> ShiftRightLogical(Vector<byte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> ShiftRightLogical(Vector<short> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> ShiftRightLogical(Vector<ushort> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> ShiftRightLogical(Vector<int> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> ShiftRightLogical(Vector<uint> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> ShiftRightLogical(Vector<long> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> ShiftRightLogical(Vector<ulong> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical(value, shiftAmount);
#else
            return _instance.ShiftRightLogical(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{sbyte}, int, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> ShiftRightLogical_Args(Vector<sbyte> dummy, int shiftAmount, out Vector<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{byte}, int, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> ShiftRightLogical_Args(Vector<byte> dummy, int shiftAmount, out Vector<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{short}, int, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> ShiftRightLogical_Args(Vector<short> dummy, int shiftAmount, out Vector<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{ushort}, int, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> ShiftRightLogical_Args(Vector<ushort> dummy, int shiftAmount, out Vector<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{int}, int, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> ShiftRightLogical_Args(Vector<int> dummy, int shiftAmount, out Vector<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{uint}, int, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> ShiftRightLogical_Args(Vector<uint> dummy, int shiftAmount, out Vector<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{long}, int, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> ShiftRightLogical_Args(Vector<long> dummy, int shiftAmount, out Vector<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Args(Vector{ulong}, int, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> ShiftRightLogical_Args(Vector<ulong> dummy, int shiftAmount, out Vector<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#else
            return _instance.ShiftRightLogical_Args(dummy, shiftAmount, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> ShiftRightLogical_Core(Vector<sbyte> value, int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> ShiftRightLogical_Core(Vector<byte> value, int shiftAmount, Vector<byte> args0, Vector<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{short}, int, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> ShiftRightLogical_Core(Vector<short> value, int shiftAmount, Vector<short> args0, Vector<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{ushort}, int, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> ShiftRightLogical_Core(Vector<ushort> value, int shiftAmount, Vector<ushort> args0, Vector<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{int}, int, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> ShiftRightLogical_Core(Vector<int> value, int shiftAmount, Vector<int> args0, Vector<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{uint}, int, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> ShiftRightLogical_Core(Vector<uint> value, int shiftAmount, Vector<uint> args0, Vector<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{long}, int, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> ShiftRightLogical_Core(Vector<long> value, int shiftAmount, Vector<long> args0, Vector<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Core(Vector{ulong}, int, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> ShiftRightLogical_Core(Vector<ulong> value, int shiftAmount, Vector<ulong> args0, Vector<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_Core(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> ShiftRightLogical_Const(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Const(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> ShiftRightLogical_Const(Vector<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Const(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> ShiftRightLogical_Const(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Const(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> ShiftRightLogical_Const(Vector<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Const(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> ShiftRightLogical_Const(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Const(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> ShiftRightLogical_Const(Vector<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Const(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> ShiftRightLogical_Const(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Const(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Const(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> ShiftRightLogical_Const(Vector<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Const(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Const(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{sbyte}, int, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> ShiftRightLogical_ConstCore(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<sbyte> args0, Vector<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{byte}, int, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> ShiftRightLogical_ConstCore(Vector<byte> value, [ConstantExpected(Min = 1, Max = 7)] int shiftAmount, Vector<byte> args0, Vector<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{short}, int, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> ShiftRightLogical_ConstCore(Vector<short> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector<short> args0, Vector<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{ushort}, int, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> ShiftRightLogical_ConstCore(Vector<ushort> value, [ConstantExpected(Min = 1, Max = 15)] int shiftAmount, Vector<ushort> args0, Vector<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{int}, int, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> ShiftRightLogical_ConstCore(Vector<int> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector<int> args0, Vector<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{uint}, int, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> ShiftRightLogical_ConstCore(Vector<uint> value, [ConstantExpected(Min = 1, Max = 31)] int shiftAmount, Vector<uint> args0, Vector<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{long}, int, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> ShiftRightLogical_ConstCore(Vector<long> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector<long> args0, Vector<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_ConstCore(Vector{ulong}, int, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> ShiftRightLogical_ConstCore(Vector<ulong> value, [ConstantExpected(Min = 1, Max = 63)] int shiftAmount, Vector<ulong> args0, Vector<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#else
            return _instance.ShiftRightLogical_ConstCore(value, shiftAmount, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> ShiftRightLogical_Fast(Vector<sbyte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> ShiftRightLogical_Fast(Vector<byte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> ShiftRightLogical_Fast(Vector<short> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> ShiftRightLogical_Fast(Vector<ushort> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> ShiftRightLogical_Fast(Vector<int> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> ShiftRightLogical_Fast(Vector<uint> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> ShiftRightLogical_Fast(Vector<long> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_Fast(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> ShiftRightLogical_Fast(Vector<ulong> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogical_Fast(value, shiftAmount);
#else
            return _instance.ShiftRightLogical_Fast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.Shuffle_AcceleratedTypes"/>
        public static TypeCodeFlags Shuffle_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Shuffle_AcceleratedTypes;
#else
                return _instance.Shuffle_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{float}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> Shuffle(Vector<float> vector, Vector<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{double}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> Shuffle(Vector<double> vector, Vector<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> Shuffle(Vector<sbyte> vector, Vector<sbyte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> Shuffle(Vector<byte> vector, Vector<byte> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> Shuffle(Vector<short> vector, Vector<short> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> Shuffle(Vector<ushort> vector, Vector<ushort> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> Shuffle(Vector<int> vector, Vector<int> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> Shuffle(Vector<uint> vector, Vector<uint> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> Shuffle(Vector<long> vector, Vector<long> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> Shuffle(Vector<ulong> vector, Vector<ulong> indices) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle(vector, indices);
#else
            return _instance.Shuffle(vector, indices);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{sbyte}, out Vector{sbyte}, out Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle_Args(Vector<sbyte> indices, out Vector<sbyte> args0, out Vector<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Shuffle_Args(indices, out args0, out args1);
#else
            _instance.Shuffle_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{byte}, out Vector{byte}, out Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle_Args(Vector<byte> indices, out Vector<byte> args0, out Vector<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Shuffle_Args(indices, out args0, out args1);
#else
            _instance.Shuffle_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{short}, out Vector{short}, out Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle_Args(Vector<short> indices, out Vector<short> args0, out Vector<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Shuffle_Args(indices, out args0, out args1);
#else
            _instance.Shuffle_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{ushort}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle_Args(Vector<ushort> indices, out Vector<ushort> args0, out Vector<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Shuffle_Args(indices, out args0, out args1);
#else
            _instance.Shuffle_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{int}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle_Args(Vector<int> indices, out Vector<int> args0, out Vector<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Shuffle_Args(indices, out args0, out args1);
#else
            _instance.Shuffle_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{uint}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle_Args(Vector<uint> indices, out Vector<uint> args0, out Vector<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Shuffle_Args(indices, out args0, out args1);
#else
            _instance.Shuffle_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{long}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle_Args(Vector<long> indices, out Vector<long> args0, out Vector<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Shuffle_Args(indices, out args0, out args1);
#else
            _instance.Shuffle_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Args(Vector{ulong}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Shuffle_Args(Vector<ulong> indices, out Vector<ulong> args0, out Vector<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Shuffle_Args(indices, out args0, out args1);
#else
            _instance.Shuffle_Args(indices, out args0, out args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{float}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> Shuffle_Core(Vector<float> vector, Vector<int> args0, Vector<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{double}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> Shuffle_Core(Vector<double> vector, Vector<long> args0, Vector<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> Shuffle_Core(Vector<sbyte> vector, Vector<sbyte> args0, Vector<sbyte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> Shuffle_Core(Vector<byte> vector, Vector<byte> args0, Vector<byte> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> Shuffle_Core(Vector<short> vector, Vector<short> args0, Vector<short> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> Shuffle_Core(Vector<ushort> vector, Vector<ushort> args0, Vector<ushort> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> Shuffle_Core(Vector<int> vector, Vector<int> args0, Vector<int> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> Shuffle_Core(Vector<uint> vector, Vector<uint> args0, Vector<uint> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> Shuffle_Core(Vector<long> vector, Vector<long> args0, Vector<long> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle_Core(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> Shuffle_Core(Vector<ulong> vector, Vector<ulong> args0, Vector<ulong> args1) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Shuffle_Core(vector, args0, args1);
#else
            return _instance.Shuffle_Core(vector, args0, args1);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.Sum_AcceleratedTypes"/>
        public static TypeCodeFlags Sum_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Sum_AcceleratedTypes;
#else
                return _instance.Sum_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sum(Vector<float> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double Sum(Vector<double> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte Sum(Vector<sbyte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte Sum(Vector<byte> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short Sum(Vector<short> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort Sum(Vector<ushort> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Sum(Vector<int> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Sum(Vector<uint> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Sum(Vector<long> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Sum(Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Sum(Vector<ulong> value) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Sum(value);
#else
            return _instance.Sum(value);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.Widen_AcceleratedTypes"/>
        public static TypeCodeFlags Widen_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Widen_AcceleratedTypes;
#else
                return _instance.Widen_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{float}, out Vector{double}, out Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Widen(Vector<float> source, out Vector<double> lower, out Vector<double> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Widen(source, out lower, out upper);
#else
            _instance.Widen(source, out lower, out upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{sbyte}, out Vector{short}, out Vector{short})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Widen(Vector<sbyte> source, out Vector<short> lower, out Vector<short> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Widen(source, out lower, out upper);
#else
            _instance.Widen(source, out lower, out upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{byte}, out Vector{ushort}, out Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Widen(Vector<byte> source, out Vector<ushort> lower, out Vector<ushort> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Widen(source, out lower, out upper);
#else
            _instance.Widen(source, out lower, out upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{short}, out Vector{int}, out Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Widen(Vector<short> source, out Vector<int> lower, out Vector<int> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Widen(source, out lower, out upper);
#else
            _instance.Widen(source, out lower, out upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{ushort}, out Vector{uint}, out Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Widen(Vector<ushort> source, out Vector<uint> lower, out Vector<uint> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Widen(source, out lower, out upper);
#else
            _instance.Widen(source, out lower, out upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Widen(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Widen(source, out lower, out upper);
#else
            _instance.Widen(source, out lower, out upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Widen(Vector{uint}, out Vector{ulong}, out Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Widen(Vector<uint> source, out Vector<ulong> lower, out Vector<ulong> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            BaseStatics.Widen(source, out lower, out upper);
#else
            _instance.Widen(source, out lower, out upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


    }
}
