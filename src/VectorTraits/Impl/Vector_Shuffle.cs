#if !REDUCE_MEMORY_USAGE
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
            if (Vector<byte>.Count == Vector128<byte>.Count) {
                return Vector128_Shuffle.Shuffle(vector.AsVector128(), indices.AsVector128()).AsVector();
            } else if (Vector<byte>.Count == Vector256<byte>.Count) {
                return Vector256_Shuffle.Shuffle(vector.AsVector256(), indices.AsVector256()).AsVector();
            }
#endif // !BCL_BASE_OVERRIDE_STATIC
            return Shuffle_Basic(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> Shuffle(Vector<short> vector, Vector<short> indices) {
            return Shuffle(vector.AsUInt16(), indices.AsUInt16()).AsInt16();
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> Shuffle(Vector<ushort> vector, Vector<ushort> indices) {
#if !BCL_BASE_OVERRIDE_STATIC
            if (Vector<byte>.Count == Vector128<byte>.Count) {
                return Vector128_Shuffle.Shuffle(vector.AsVector128(), indices.AsVector128()).AsVector();
            } else if (Vector<byte>.Count == Vector256<byte>.Count) {
                return Vector256_Shuffle.Shuffle(vector.AsVector256(), indices.AsVector256()).AsVector();
            }
#endif // !BCL_BASE_OVERRIDE_STATIC
            return Shuffle_Basic(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> Shuffle_Basic(Vector<byte> vector, Vector<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
            return Vector.Shuffle(vector, indices);
#else
            return Shuffle_Base_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NETX_0_OR_GREATER
        }

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> Shuffle_Basic(Vector<ushort> vector, Vector<ushort> indices) {
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

        /// <inheritdoc cref="IVectorTraits.Shuffle(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> Shuffle_Base_Basic(Vector<ushort> vector, Vector<ushort> indices) {
            UnsafeEx.SkipInit(out Vector<ushort> rt);
            ushort cnt = (ushort)Vector<ushort>.Count;
            ref ushort q = ref Unsafe.As<Vector<ushort>, ushort>(ref rt);
            ref ushort p = ref Unsafe.As<Vector<ushort>, ushort>(ref vector);
            ref ushort pindices = ref Unsafe.As<Vector<ushort>, ushort>(ref indices);
            for (nint i = 0; i < Vector<ushort>.Count; ++i) {
                ushort selectedIndex = Unsafe.Add(ref pindices, i);
                ushort selectedValue = default;
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
            if (Vector<byte>.Count == Vector128<byte>.Count) {
                return Vector128_Shuffle.YShuffleKernel(vector.AsVector128(), indices.AsVector128()).AsVector();
            } else if (Vector<byte>.Count == Vector256<byte>.Count) {
                return Vector256_Shuffle.YShuffleKernel(vector.AsVector256(), indices.AsVector256()).AsVector();
            }
#endif // !BCL_BASE_OVERRIDE_STATIC && NETCOREAPP3_0_OR_GREATER
            return YShuffleKernel_Basic(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{short}, Vector{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<short> YShuffleKernel(Vector<short> vector, Vector<short> indices) {
            return YShuffleKernel(vector.AsUInt16(), indices.AsUInt16()).AsInt16();
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleKernel(Vector<ushort> vector, Vector<ushort> indices) {
#if !BCL_BASE_OVERRIDE_STATIC && NETCOREAPP3_0_OR_GREATER
            if (Vector<byte>.Count == Vector128<byte>.Count) {
                return Vector128_Shuffle.YShuffleKernel(vector.AsVector128(), indices.AsVector128()).AsVector();
            } else if (Vector<byte>.Count == Vector256<byte>.Count) {
                return Vector256_Shuffle.YShuffleKernel(vector.AsVector256(), indices.AsVector256()).AsVector();
            }
#endif // !BCL_BASE_OVERRIDE_STATIC && NETCOREAPP3_0_OR_GREATER
            return YShuffleKernel_Basic(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{byte}, Vector{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<byte> YShuffleKernel_Basic(Vector<byte> vector, Vector<byte> indices) {
            return Shuffle_Basic(vector, indices);
        }

        /// <inheritdoc cref="IVectorTraits.YShuffleKernel(Vector{ushort}, Vector{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector<ushort> YShuffleKernel_Basic(Vector<ushort> vector, Vector<ushort> indices) {
            return Shuffle_Basic(vector, indices);
        }


    }
}
#endif // !REDUCE_MEMORY_USAGE
