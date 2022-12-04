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

        /// <summary>Best traits instance (最佳特征实例). </summary>
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
        public static IReadOnlyList<IWVectorTraits128> TraitsInstances {
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

        /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
        public static void ThrowForUnsupported() {
            _instance.ThrowForUnsupported();
        }

#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> ShiftLeft(Vector128<byte> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector128.ShiftLeft(value, shiftCount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftLeft(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> ShiftLeft(Vector128<short> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && (NET7_0_OR_GREATER)
            return Vector128.ShiftLeft(value, shiftCount);
#else
            return _instance.ShiftLeft(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> ShiftLeft(Vector128<int> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && (NET7_0_OR_GREATER)
            return Vector128.ShiftLeft(value, shiftCount);
#else
            return _instance.ShiftLeft(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeft(Vector128{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> ShiftLeft(Vector128<long> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && (NET7_0_OR_GREATER)
            return Vector128.ShiftLeft(value, shiftCount);
#else
            return _instance.ShiftLeft(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> ShiftLeftFast(Vector128<byte> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector128.ShiftLeft(value, shiftCount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftLeftFast(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> ShiftLeftFast(Vector128<short> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && (NET7_0_OR_GREATER)
            return Vector128.ShiftLeft(value, shiftCount);
#else
            return _instance.ShiftLeftFast(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> ShiftLeftFast(Vector128<int> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && (NET7_0_OR_GREATER)
            return Vector128.ShiftLeft(value, shiftCount);
#else
            return _instance.ShiftLeftFast(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IWVectorTraits128.ShiftLeftFast(Vector128{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<long> ShiftLeftFast(Vector128<long> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && (NET7_0_OR_GREATER)
            return Vector128.ShiftLeft(value, shiftCount);
#else
            return _instance.ShiftLeftFast(value, shiftCount);
#endif
        }


        /// <inheritdoc cref="IWVectorTraits128.ShiftRightArithmetic(Vector128{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<int> ShiftRightArithmetic(Vector128<int> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && (NET7_0_OR_GREATER)
            return Vector128.ShiftRightArithmetic(value, shiftCount);
#else
            return _instance.ShiftRightArithmetic(value, shiftCount);
#endif
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
