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
        public static Vector256<sbyte> ShiftLeft(Vector256<sbyte> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector256.ShiftLeft(value, shiftCount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftLeft(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> ShiftLeft(Vector256<byte> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector256.ShiftLeft(value, shiftCount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftLeft(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftLeft(Vector256<short> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftLeft(value, shiftCount);
#else
            return _instance.ShiftLeft(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> ShiftLeft(Vector256<ushort> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftLeft(value, shiftCount);
#else
            return _instance.ShiftLeft(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftLeft(Vector256<int> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftLeft(value, shiftCount);
#else
            return _instance.ShiftLeft(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> ShiftLeft(Vector256<uint> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftLeft(value, shiftCount);
#else
            return _instance.ShiftLeft(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftLeft(Vector256<long> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftLeft(value, shiftCount);
#else
            return _instance.ShiftLeft(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> ShiftLeft(Vector256<ulong> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftLeft(value, shiftCount);
#else
            return _instance.ShiftLeft(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast_AcceleratedTypes"/>
        public static TypeCodeFlags ShiftLeftFast_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.ShiftLeftFast_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                if (Vector256.IsHardwareAccelerated) {
                    rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
                }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftLeftFast(Vector256<sbyte> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector256.ShiftLeft(value, shiftCount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftLeftFast(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> ShiftLeftFast(Vector256<byte> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector256.ShiftLeft(value, shiftCount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftLeftFast(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftLeftFast(Vector256<short> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftLeft(value, shiftCount);
#else
            return _instance.ShiftLeftFast(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{ushort}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> ShiftLeftFast(Vector256<ushort> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftLeft(value, shiftCount);
#else
            return _instance.ShiftLeftFast(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftLeftFast(Vector256<int> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftLeft(value, shiftCount);
#else
            return _instance.ShiftLeftFast(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{uint}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<uint> ShiftLeftFast(Vector256<uint> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftLeft(value, shiftCount);
#else
            return _instance.ShiftLeftFast(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftLeftFast(Vector256<long> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftLeft(value, shiftCount);
#else
            return _instance.ShiftLeftFast(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeftFast(Vector256{ulong}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ulong> ShiftLeftFast(Vector256<ulong> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftLeft(value, shiftCount);
#else
            return _instance.ShiftLeftFast(value, shiftCount);
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
        public static Vector256<sbyte> ShiftRightArithmetic(Vector256<sbyte> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector256.ShiftRightArithmetic(value, shiftCount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftRightArithmetic(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftRightArithmetic(Vector256<short> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftRightArithmetic(value, shiftCount);
#else
            return _instance.ShiftRightArithmetic(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftRightArithmetic(Vector256<int> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftRightArithmetic(value, shiftCount);
#else
            return _instance.ShiftRightArithmetic(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftRightArithmetic(Vector256<long> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftRightArithmetic(value, shiftCount);
#else
            return _instance.ShiftRightArithmetic(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast_AcceleratedTypes"/>
        public static TypeCodeFlags ShiftRightArithmeticFast_AcceleratedTypes {
            get {
                TypeCodeFlags rt = _instance.ShiftRightArithmeticFast_AcceleratedTypes;
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                if (Vector256.IsHardwareAccelerated) {
                    rt |= TypeCodeFlags.Int16 | TypeCodeFlags.Int32;
                }
#endif // BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
                return rt;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{sbyte}, int)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> ShiftRightArithmeticFast(Vector256<sbyte> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector256.ShiftRightArithmetic(value, shiftCount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftRightArithmeticFast(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> ShiftRightArithmeticFast(Vector256<short> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftRightArithmetic(value, shiftCount);
#else
            return _instance.ShiftRightArithmeticFast(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<int> ShiftRightArithmeticFast(Vector256<int> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftRightArithmetic(value, shiftCount);
#else
            return _instance.ShiftRightArithmeticFast(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmeticFast(Vector256{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<long> ShiftRightArithmeticFast(Vector256<long> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && NET7_0_OR_GREATER
            return Vector256.ShiftRightArithmetic(value, shiftCount);
#else
            return _instance.ShiftRightArithmeticFast(value, shiftCount);
#endif
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
