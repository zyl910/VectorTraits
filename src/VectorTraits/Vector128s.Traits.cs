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
            "WVectorTraits128AdvSimdA64"
        };

        private static readonly IWVectorTraits128[] _traitsInstances = {
            WVectorTraits128Base.Instance,
            WVectorTraits128AdvSimd.Instance,
            WVectorTraits128AdvSimdA64.Instance
        };

        // Statics types (静态类型集).
        private static readonly Type[] _staticsTypes = {
            typeof(WVectorTraits128Base.Statics),
            typeof(WVectorTraits128AdvSimd.Statics),
            typeof(WVectorTraits128AdvSimdA64.Statics)
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

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast_AcceleratedTypes"/>
        public static TypeCodeFlags ShiftLeftFast_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.ShiftLeftFast_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                if (Vector128.IsHardwareAccelerated) {
                    rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
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


        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> ShiftRightArithmetic(Vector128<int> value, int shiftAmount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector128.ShiftRightArithmetic(value, shiftAmount);
#else
            return _instance.ShiftRightArithmetic(value, shiftAmount);
#endif
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
