using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Impl;

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


        /// <inheritdoc cref="IVectorTraits.Multiply_AcceleratedTypes"/>
        public static TypeCodeFlags Multiply_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Multiply_AcceleratedTypes;
#else
                return _instance.Multiply_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.Multiply_FullAcceleratedTypes"/>
        public static TypeCodeFlags Multiply_FullAcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.Multiply_FullAcceleratedTypes;
#else
                return _instance.Multiply_FullAcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> Multiply(Vector<float> left, Vector<float> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> Multiply(Vector<double> left, Vector<double> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> Multiply(Vector<sbyte> left, Vector<sbyte> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> Multiply(Vector<byte> left, Vector<byte> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> Multiply(Vector<short> left, Vector<short> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> Multiply(Vector<ushort> left, Vector<ushort> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> Multiply(Vector<int> left, Vector<int> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> Multiply(Vector<uint> left, Vector<uint> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> Multiply(Vector<long> left, Vector<long> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.Multiply(Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> Multiply(Vector<ulong> left, Vector<ulong> right) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.Multiply(left, right);
#else
            return _instance.Multiply(left, right);
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

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> ShiftLeftFast(Vector<sbyte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeftFast(value, shiftAmount);
#else
            return _instance.ShiftLeftFast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> ShiftLeftFast(Vector<byte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeftFast(value, shiftAmount);
#else
            return _instance.ShiftLeftFast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> ShiftLeftFast(Vector<short> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeftFast(value, shiftAmount);
#else
            return _instance.ShiftLeftFast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> ShiftLeftFast(Vector<ushort> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeftFast(value, shiftAmount);
#else
            return _instance.ShiftLeftFast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> ShiftLeftFast(Vector<int> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeftFast(value, shiftAmount);
#else
            return _instance.ShiftLeftFast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> ShiftLeftFast(Vector<uint> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeftFast(value, shiftAmount);
#else
            return _instance.ShiftLeftFast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> ShiftLeftFast(Vector<long> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeftFast(value, shiftAmount);
#else
            return _instance.ShiftLeftFast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> ShiftLeftFast(Vector<ulong> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftLeftFast(value, shiftAmount);
#else
            return _instance.ShiftLeftFast(value, shiftAmount);
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

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> ShiftRightArithmeticFast(Vector<sbyte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmeticFast(value, shiftAmount);
#else
            return _instance.ShiftRightArithmeticFast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> ShiftRightArithmeticFast(Vector<short> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmeticFast(value, shiftAmount);
#else
            return _instance.ShiftRightArithmeticFast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> ShiftRightArithmeticFast(Vector<int> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmeticFast(value, shiftAmount);
#else
            return _instance.ShiftRightArithmeticFast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> ShiftRightArithmeticFast(Vector<long> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightArithmeticFast(value, shiftAmount);
#else
            return _instance.ShiftRightArithmeticFast(value, shiftAmount);
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

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> ShiftRightLogicalFast(Vector<sbyte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogicalFast(value, shiftAmount);
#else
            return _instance.ShiftRightLogicalFast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> ShiftRightLogicalFast(Vector<byte> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogicalFast(value, shiftAmount);
#else
            return _instance.ShiftRightLogicalFast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> ShiftRightLogicalFast(Vector<short> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogicalFast(value, shiftAmount);
#else
            return _instance.ShiftRightLogicalFast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> ShiftRightLogicalFast(Vector<ushort> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogicalFast(value, shiftAmount);
#else
            return _instance.ShiftRightLogicalFast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> ShiftRightLogicalFast(Vector<int> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogicalFast(value, shiftAmount);
#else
            return _instance.ShiftRightLogicalFast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> ShiftRightLogicalFast(Vector<uint> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogicalFast(value, shiftAmount);
#else
            return _instance.ShiftRightLogicalFast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> ShiftRightLogicalFast(Vector<long> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogicalFast(value, shiftAmount);
#else
            return _instance.ShiftRightLogicalFast(value, shiftAmount);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> ShiftRightLogicalFast(Vector<ulong> value, int shiftAmount) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.ShiftRightLogicalFast(value, shiftAmount);
#else
            return _instance.ShiftRightLogicalFast(value, shiftAmount);
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


        /// <inheritdoc cref="IVectorTraits.YClamp_AcceleratedTypes"/>
        public static TypeCodeFlags YClamp_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YClamp_AcceleratedTypes;
#else
                return _instance.YClamp_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{float}, Vector{float}, Vector{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<float> YClamp(Vector<float> value, Vector<float> amin, Vector<float> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{double}, Vector{double}, Vector{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<double> YClamp(Vector<double> value, Vector<double> amin, Vector<double> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YClamp(Vector<sbyte> value, Vector<sbyte> amin, Vector<sbyte> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{byte}, Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YClamp(Vector<byte> value, Vector<byte> amin, Vector<byte> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{short}, Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YClamp(Vector<short> value, Vector<short> amin, Vector<short> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YClamp(Vector<ushort> value, Vector<ushort> amin, Vector<ushort> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{int}, Vector{int}, Vector{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YClamp(Vector<int> value, Vector<int> amin, Vector<int> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{uint}, Vector{uint}, Vector{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YClamp(Vector<uint> value, Vector<uint> amin, Vector<uint> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{long}, Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> YClamp(Vector<long> value, Vector<long> amin, Vector<long> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YClamp(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ulong> YClamp(Vector<ulong> value, Vector<ulong> amin, Vector<ulong> amax) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YClamp(value, amin, amax);
#else
            return _instance.YClamp(value, amin, amax);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate_AcceleratedTypes"/>
        public static TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YNarrowSaturate_AcceleratedTypes;
#else
                return _instance.YNarrowSaturate_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate_FullAcceleratedTypes"/>
        public static TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YNarrowSaturate_FullAcceleratedTypes;
#else
                return _instance.YNarrowSaturate_FullAcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{short}, Vector{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YNarrowSaturate(Vector<short> lower, Vector<short> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{ushort}, Vector{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YNarrowSaturate(Vector<ushort> lower, Vector<ushort> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{int}, Vector{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YNarrowSaturate(Vector<int> lower, Vector<int> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{uint}, Vector{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YNarrowSaturate(Vector<uint> lower, Vector<uint> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{long}, Vector{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> YNarrowSaturate(Vector<long> lower, Vector<long> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturate(Vector{ulong}, Vector{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YNarrowSaturate(Vector<ulong> lower, Vector<ulong> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturate(lower, upper);
#else
            return _instance.YNarrowSaturate(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned_AcceleratedTypes"/>
        public static TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YNarrowSaturateUnsigned_AcceleratedTypes;
#else
                return _instance.YNarrowSaturateUnsigned_AcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
        public static TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
            get {
#if BCL_BASE_OVERRIDE_STATIC
                return BaseStatics.YNarrowSaturateUnsigned_FullAcceleratedTypes;
#else
                return _instance.YNarrowSaturateUnsigned_FullAcceleratedTypes;
#endif // BCL_BASE_OVERRIDE_STATIC
            }
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{short}, Vector{short})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YNarrowSaturateUnsigned(Vector<short> lower, Vector<short> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturateUnsigned(lower, upper);
#else
            return _instance.YNarrowSaturateUnsigned(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{int}, Vector{int})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YNarrowSaturateUnsigned(Vector<int> lower, Vector<int> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturateUnsigned(lower, upper);
#else
            return _instance.YNarrowSaturateUnsigned(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }

        /// <inheritdoc cref="IVectorTraits.YNarrowSaturateUnsigned(Vector{long}, Vector{long})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<uint> YNarrowSaturateUnsigned(Vector<long> lower, Vector<long> upper) {
#if BCL_BASE_OVERRIDE_STATIC
            return BaseStatics.YNarrowSaturateUnsigned(lower, upper);
#else
            return _instance.YNarrowSaturateUnsigned(lower, upper);
#endif // BCL_BASE_OVERRIDE_STATIC
        }


    }
}
