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
        public static IWVectorTraits256 Instance {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return _instance; }
        }

        /// <summary>Best traits instance dynamic value (最佳特征实例动态值). </summary>
        public static dynamic InstanceDynamic {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return _instanceDynamic; }
        }

        /// <summary>Traits names array (特征名称数组). </summary>
        public static string[] TraitsNames {
            get { return _traitsNames; }
        }

        /// <summary>Traits instances array (特征实例数组). </summary>
        public static IWVectorTraits256[] TraitsInstances {
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

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{Int16}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<Int16> ShiftLeft(Vector256<Int16> value, int shiftCount) {
            return _instance.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftLeft(Vector256{Int32}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<Int32> ShiftLeft(Vector256<Int32> value, int shiftCount) {
            return _instance.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IWVectorTraits256.ShiftRightArithmetic(Vector256{Int32}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<Int32> ShiftRightArithmetic(Vector256<Int32> value, int shiftCount) {
            return _instance.ShiftLeft(value, shiftCount);
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
