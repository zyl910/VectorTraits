using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
#endif
using System.Text;
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// Traits method of Vector256 - Shuffle .
    /// </summary>
    [Obsolete("It is only used for benchmarking results comparison. Please use Vector256s.Shuffle (它仅用于基准测试结果对比. 请使用 Vector256s.Shuffle) .")]
    public static class Vector256_Shuffle {
#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> Shuffle(Vector256<byte> vector, Vector256<byte> indices) {
            if (Avx.IsSupported && Avx2.IsSupported) {
                return Shuffle_Avx2(vector, indices);
            }
            return Shuffle_Base(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> Shuffle_Base(Vector256<byte> vector, Vector256<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            return Vector256.Shuffle(vector, indices);
#else
            return Shuffle_Base_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> Shuffle_Base_Basic(Vector256<byte> vector, Vector256<byte> indices) {
            UnsafeEx.SkipInit(out Vector256<byte> rt);
            byte cnt = (byte)Vector256<byte>.Count;
            ref byte q = ref Unsafe.As<Vector256<byte>, byte>(ref rt);
            ref byte p = ref Unsafe.As<Vector256<byte>, byte>(ref vector);
            ref byte pindices = ref Unsafe.As<Vector256<byte>, byte>(ref indices);
            for (nint i = 0; i < Vector256<byte>.Count; ++i) {
                byte selectedIndex = Unsafe.Add(ref pindices, i);
                byte selectedValue = default;
                if (selectedIndex < cnt) {
                    selectedValue = Unsafe.Add(ref p, selectedIndex);
                }
                Unsafe.Add(ref q, i) = selectedValue;
            }
            return rt;
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> Shuffle_Avx2(Vector256<byte> vector, Vector256<byte> indices) {
            return YShuffleInsert_Avx2(Vector256<byte>.Zero, vector, indices);
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<sbyte> YShuffleKernel(Vector256<sbyte> vector, Vector256<sbyte> indices) {
            return YShuffleKernel(vector.AsByte(), indices.AsByte()).AsSByte();
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleKernel(Vector256<byte> vector, Vector256<byte> indices) {
            if (Avx.IsSupported && Avx2.IsSupported) {
                return YShuffleKernel_Avx2(vector, indices);
            }
            return YShuffleKernel_Base(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleKernel_Base(Vector256<byte> vector, Vector256<byte> indices) {
            return Shuffle_Base(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleKernel_Avx2(Vector256<byte> vector, Vector256<byte> indices) {
            return YShuffleKernel_Avx2_ByteAdd(vector, indices);
        }

        private static readonly Vector256<byte> Shuffle_ByteAdd_K0 = Vector256.Create(0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0);
        private static readonly Vector256<byte> Shuffle_ByteAdd_K1 = Vector256.Create(0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70, 0x70);

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleKernel_Avx2_ByteAdd(Vector256<byte> vector, Vector256<byte> indices) {
            // Shuffle elements of __m256i vector
            // https://stackoverflow.com/questions/30669556/shuffle-elements-of-m256i-vector
            // ErmIg answered Jun 5, 2015 at 14:54
            return Avx2.Or(
                Avx2.Shuffle(vector, Avx2.Add(indices, Shuffle_ByteAdd_K0)),
                Avx2.Shuffle(Avx2.Permute4x64(vector.AsInt64(), ShuffleControlG4.ZWXY).AsByte(), Avx2.Add(indices, Shuffle_ByteAdd_K1))
            );
            // Remark: The value of each element must be less than count
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleInsert(Vector256<byte> back, Vector256<byte> vector, Vector256<byte> indices) {
            if (Avx.IsSupported && Avx2.IsSupported) {
                return YShuffleInsert_Avx2(back, vector, indices);
            }
            return YShuffleInsert_Base(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleInsert_Base(Vector256<byte> back, Vector256<byte> vector, Vector256<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            Vector256<byte> mask = Vector256.GreaterThan(Vector256.Create((byte)Vector256<byte>.Count), indices);
            Vector256<byte> raw = Vector256.Shuffle(vector, indices);
            Vector256<byte> rt = Vector256.ConditionalSelect(mask, raw, back);
            return rt;
#else
                return YShuffleInsert_Base_Basic(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleInsert_Base_Basic(Vector256<byte> back, Vector256<byte> vector, Vector256<byte> indices) {
            UnsafeEx.SkipInit(out Vector256<byte> rt);
            byte cnt = (byte)Vector256<byte>.Count;
            ref byte q = ref Unsafe.As<Vector256<byte>, byte>(ref rt);
            ref byte p = ref Unsafe.As<Vector256<byte>, byte>(ref vector);
            ref byte pindices = ref Unsafe.As<Vector256<byte>, byte>(ref indices);
            ref byte pback = ref Unsafe.As<Vector256<byte>, byte>(ref back);
            for (nint i = 0; i < Vector256<byte>.Count; ++i) {
                byte selectedIndex = Unsafe.Add(ref pindices, i);
                byte selectedValue = Unsafe.Add(ref pback, i);
                if (selectedIndex < cnt) {
                    selectedValue = Unsafe.Add(ref p, selectedIndex);
                }
                Unsafe.Add(ref q, i) = selectedValue;
            }
            return rt;
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleInsert_Avx2(Vector256<byte> back, Vector256<byte> vector, Vector256<byte> indices) {
            Vector256<byte> mask = Avx2.AndNot(
                Avx2.CompareGreaterThan(Vector256<sbyte>.Zero, indices.AsSByte()),
                Avx2.CompareGreaterThan(Vector256.Create((sbyte)32), indices.AsSByte())
            ).AsByte(); // (0<=i && i<32)
            Vector256<byte> raw = YShuffleKernel_Avx2(vector, indices);
            Vector256<byte> rt = Avx2.BlendVariable(back, raw, mask);
            return rt;
        }

#endif
    }
}
