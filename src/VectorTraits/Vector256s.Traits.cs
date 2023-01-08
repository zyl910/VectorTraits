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

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
