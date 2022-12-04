using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits {
    public static partial class Vectors {
        private static readonly IVectorTraits _instance = VectorTraitsAbstract.GetBestInstance(); // Best traits instance.
        private static readonly dynamic _instanceDynamic = _instance; // Best traits instance dynamic value.
        private static readonly IVectorTraits _baseInstance = VectorTraitsAbstract.GetBaseInstance(); // Base traits instance.
        private static readonly dynamic _baseInstanceDynamic = _baseInstance; // Base traits instance dynamic value.

        private static readonly string[] _traitsNames = {
            "VectorTraitsBase",
            "VectorTraits128Base",
            "VectorTraits128AdvSimd",
            "VectorTraits128AdvSimdA64",
            "VectorTraits256Base",
            "VectorTraits256Avx2"
        };

        private static readonly IVectorTraits[] _traitsInstances = {
            VectorTraitsBase.Instance,
            VectorTraits128Base.Instance,
            VectorTraits128AdvSimd.Instance,
            VectorTraits128AdvSimdA64.Instance,
            VectorTraits256Base.Instance,
            VectorTraits256Avx2.Instance
        };

        /// <summary>Best traits instance (最佳特征实例). </summary>
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
        public static IReadOnlyList<IVectorTraits> TraitsInstances {
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

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> ShiftLeft(Vector<byte> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector.ShiftLeft(value, shiftCount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftLeft(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> ShiftLeft(Vector<short> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && (NET7_0_OR_GREATER)
            return Vector.ShiftLeft(value, shiftCount);
#else
            return _instance.ShiftLeft(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> ShiftLeft(Vector<int> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && (NET7_0_OR_GREATER)
            return Vector.ShiftLeft(value, shiftCount);
#else
            return _instance.ShiftLeft(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> ShiftLeft(Vector<long> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && (NET7_0_OR_GREATER)
            return Vector.ShiftLeft(value, shiftCount);
#else
            return _instance.ShiftLeft(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{byte}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> ShiftLeftFast(Vector<byte> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && (NET_X_0_OR_GREATER)
            return Vector.ShiftLeft(value, shiftCount); // .NET7 no hardware acceleration! X86(sse, avx)
#else
            return _instance.ShiftLeftFast(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{short}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> ShiftLeftFast(Vector<short> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && (NET7_0_OR_GREATER)
            return Vector.ShiftLeft(value, shiftCount);
#else
            return _instance.ShiftLeftFast(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> ShiftLeftFast(Vector<int> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && (NET7_0_OR_GREATER)
            return Vector.ShiftLeft(value, shiftCount);
#else
            return _instance.ShiftLeftFast(value, shiftCount);
#endif
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{long}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<long> ShiftLeftFast(Vector<long> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && (NET7_0_OR_GREATER)
            return Vector.ShiftLeft(value, shiftCount);
#else
            return _instance.ShiftLeftFast(value, shiftCount);
#endif
        }


        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{int}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<int> ShiftRightArithmetic(Vector<int> value, int shiftCount) {
#if BCL_OVERRIDE_STATIC && (NET7_0_OR_GREATER)
            return Vector.ShiftRightArithmetic(value, shiftCount);
#else
            return _instance.ShiftRightArithmetic(value, shiftCount);
#endif
        }


    }
}
