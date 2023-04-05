using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;
using Zyl.VectorTraits.Impl.Util;
using Zyl.VectorTraits.Extensions;
using Zyl.VectorTraits.Extensions.SameW;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// Traits method of Vector - Shuffle .
    /// </summary>
    [Obsolete("It is only used for benchmarking results comparison. Please use Vectors.Shuffle (它仅用于基准测试结果对比. 请使用 Vectors.Shuffle) .")]
    public static class Vector_Shuffle {

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> Shuffle(Vector<sbyte> vector, Vector<sbyte> indices) {
            return Shuffle(vector.AsByte(), indices.AsByte()).AsSByte();
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> Shuffle(Vector<byte> vector, Vector<byte> indices) {
#if !BCL_BASE_OVERRIDE_STATIC
            if (Vector<byte>.Count == Vector256<byte>.Count) {
                return Vector256_Shuffle.Shuffle(vector.AsVector256(), indices.AsVector256()).AsVector();
            }
#endif // !BCL_BASE_OVERRIDE_STATIC
            return Shuffle_Base(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> Shuffle_Base(Vector<byte> vector, Vector<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            return Vector.Shuffle(vector, indices);
#else
            return Shuffle_Base_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> Shuffle_Base_Basic(Vector<byte> vector, Vector<byte> indices) {
            UnsafeEx.SkipInit(out Vector<byte> rt);
            byte cnt = (byte)Vector<byte>.Count;
            ref byte q = ref Unsafe.As<Vector<byte>, byte>(ref rt);
            ref byte p = ref Unsafe.As<Vector<byte>, byte>(ref vector);
            ref byte pindices = ref Unsafe.As<Vector<byte>, byte>(ref indices);
            for (nint i = 0; i < Vector<byte>.Count; ++i) {
                byte selectedIndex = Unsafe.Add(ref pindices, i);
                byte selectedValue = default;
                if (selectedIndex < cnt) {
                    selectedValue = Unsafe.Add(ref p, selectedIndex);
                }
                Unsafe.Add(ref q, i) = selectedValue;
            }
            return rt;
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{sbyte}, Vector{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<sbyte> YShuffleKernel(Vector<sbyte> vector, Vector<sbyte> indices) {
            return YShuffleKernel(vector.AsByte(), indices.AsByte()).AsSByte();
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleKernel(Vector<byte> vector, Vector<byte> indices) {
#if !BCL_BASE_OVERRIDE_STATIC && NETCOREAPP3_0_OR_GREATER
            if (Vector<byte>.Count == Vector256<byte>.Count) {
                return Vector256_Shuffle.YShuffleKernel(vector.AsVector256(), indices.AsVector256()).AsVector();
            }
#endif // !BCL_BASE_OVERRIDE_STATIC && NETCOREAPP3_0_OR_GREATER
            return YShuffleKernel_Base(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleKernel_Base(Vector<byte> vector, Vector<byte> indices) {
            return Shuffle_Base(vector, indices);
        }


    }
}
