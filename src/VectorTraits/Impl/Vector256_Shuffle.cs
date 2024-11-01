#if !REDUCE_MEMORY_USAGE
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
            return Shuffle_Basic(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> Shuffle(Vector256<ushort> vector, Vector256<ushort> indices) {
            if (Avx.IsSupported && Avx2.IsSupported) {
                return Shuffle_Avx2(vector, indices);
            }
            return Shuffle_Basic(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> Shuffle_Basic(Vector256<byte> vector, Vector256<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            return Vector256.Shuffle(vector, indices);
#else
            return Shuffle_Base_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> Shuffle_Basic(Vector256<ushort> vector, Vector256<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            return Vector256.Shuffle(vector, indices);
#else
            return Shuffle_Base_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> Shuffle_Base_Basic(Vector256<byte> vector, Vector256<byte> indices) {
            Unsafe.SkipInit(out Vector256<byte> rt);
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

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> Shuffle_Base_Basic(Vector256<ushort> vector, Vector256<ushort> indices) {
            Unsafe.SkipInit(out Vector256<ushort> rt);
            ushort cnt = (ushort)Vector256<ushort>.Count;
            ref ushort q = ref Unsafe.As<Vector256<ushort>, ushort>(ref rt);
            ref ushort p = ref Unsafe.As<Vector256<ushort>, ushort>(ref vector);
            ref ushort pindices = ref Unsafe.As<Vector256<ushort>, ushort>(ref indices);
            for (nint i = 0; i < Vector256<ushort>.Count; ++i) {
                ushort selectedIndex = Unsafe.Add(ref pindices, i);
                ushort selectedValue = default;
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
            //return YShuffleInsert_Avx2(Vector256<byte>.Zero, vector, indices); // Bind static
            Vector256<byte> mask = Avx2.AndNot(
                Avx2.CompareGreaterThan(Vector256<sbyte>.Zero, indices.AsSByte()),
                Avx2.CompareGreaterThan(Vector256.Create((sbyte)32), indices.AsSByte())
            ).AsByte(); // (0<=i && i<32)
            Vector256<byte> raw = YShuffleKernel_Avx2(vector, indices); // Bind static
            Vector256<byte> rt = Avx2.And(raw, mask);
            return rt;
        }

        /// <inheritdoc cref="IWVectorTraits256.Shuffle(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> Shuffle_Avx2(Vector256<ushort> vector, Vector256<ushort> indices) {
            //return YShuffleInsert(Vector256<ushort>.Zero, vector, indices); // Bind if
            Vector256<ushort> mask = Avx2.AndNot(
                Avx2.CompareGreaterThan(Vector256<short>.Zero, indices.AsInt16()),
                Avx2.CompareGreaterThan(Vector256.Create((short)16), indices.AsInt16())
            ).AsUInt16(); // (0<=i && i<16)
            Vector256<ushort> raw = YShuffleKernel(vector, indices); // Bind if
            Vector256<ushort> rt = Avx2.And(raw, mask);
            return rt;
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleInsert(Vector256<byte> back, Vector256<byte> vector, Vector256<byte> indices) {
            if (Avx.IsSupported && Avx2.IsSupported) {
                return YShuffleInsert_Avx2(back, vector, indices);
            }
            return YShuffleInsert_Basic(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleInsert(Vector256<ushort> back, Vector256<ushort> vector, Vector256<ushort> indices) {
            if (Avx.IsSupported && Avx2.IsSupported) {
                return YShuffleInsert_Avx2(back, vector, indices);
            }
            return YShuffleInsert_Basic(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleInsert_Basic(Vector256<byte> back, Vector256<byte> vector, Vector256<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            Vector256<byte> mask = Vector256.GreaterThan(Vector256.Create((byte)Vector256<byte>.Count), indices);
            Vector256<byte> raw = Vector256.Shuffle(vector, indices);
            Vector256<byte> rt = Vector256.ConditionalSelect(mask, raw, back);
            return rt;
#else
            return YShuffleInsert_Base_Basic(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleInsert_Basic(Vector256<ushort> back, Vector256<ushort> vector, Vector256<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                Vector256<ushort> mask = Vector256.GreaterThan(Vector256.Create((ushort)Vector256<ushort>.Count), indices);
                Vector256<ushort> raw = Vector256.Shuffle(vector, indices);
                Vector256<ushort> rt = Vector256.ConditionalSelect(mask, raw, back);
                return rt;
#else
            return YShuffleInsert_Base_Basic(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleInsert_Base_Basic(Vector256<byte> back, Vector256<byte> vector, Vector256<byte> indices) {
            Unsafe.SkipInit(out Vector256<byte> rt);
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

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleInsert_Base_Basic(Vector256<ushort> back, Vector256<ushort> vector, Vector256<ushort> indices) {
            Unsafe.SkipInit(out Vector256<ushort> rt);
            ushort cnt = (ushort)Vector256<ushort>.Count;
            ref ushort q = ref Unsafe.As<Vector256<ushort>, ushort>(ref rt);
            ref ushort p = ref Unsafe.As<Vector256<ushort>, ushort>(ref vector);
            ref ushort pindices = ref Unsafe.As<Vector256<ushort>, ushort>(ref indices);
            ref ushort pback = ref Unsafe.As<Vector256<ushort>, ushort>(ref back);
            for (nint i = 0; i < Vector256<ushort>.Count; ++i) {
                ushort selectedIndex = Unsafe.Add(ref pindices, i);
                ushort selectedValue = Unsafe.Add(ref pback, i);
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
            Vector256<byte> raw = YShuffleKernel_Avx2(vector, indices); // Bind static
            Vector256<byte> rt = Avx2.BlendVariable(back, raw, mask);
            return rt;
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleInsert_Avx2(Vector256<ushort> back, Vector256<ushort> vector, Vector256<ushort> indices) {
            Vector256<ushort> mask = Avx2.AndNot(
                Avx2.CompareGreaterThan(Vector256<short>.Zero, indices.AsInt16()),
                Avx2.CompareGreaterThan(Vector256.Create((short)16), indices.AsInt16())
            ).AsUInt16(); // (0<=i && i<16)
            Vector256<ushort> raw = YShuffleKernel(vector, indices); // Bind if
            Vector256<ushort> rt = Avx2.BlendVariable(back, raw, mask);
            return rt;
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
            return YShuffleKernel_Basic(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<short> YShuffleKernel(Vector256<short> vector, Vector256<short> indices) {
            return YShuffleKernel(vector.AsUInt16(), indices.AsUInt16()).AsInt16();
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleKernel(Vector256<ushort> vector, Vector256<ushort> indices) {
            if (Avx.IsSupported && Avx2.IsSupported) {
                return YShuffleKernel_Avx2(vector, indices);
            }
            return YShuffleKernel_Basic(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleKernel_Basic(Vector256<byte> vector, Vector256<byte> indices) {
            return Shuffle_Basic(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleKernel_Basic(Vector256<ushort> vector, Vector256<ushort> indices) {
            return Shuffle_Basic(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleKernel_Avx2(Vector256<byte> vector, Vector256<byte> indices) {
            return YShuffleKernel_Avx2_ByteAdd(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<byte> YShuffleKernel_Avx2_ByteAdd(Vector256<byte> vector, Vector256<byte> indices) {
            // Shuffle elements of __m256i vector
            // https://stackoverflow.com/questions/30669556/shuffle-elements-of-m256i-vector
            // ErmIg answered Jun 5, 2015 at 14:54
            return Avx2.Or(
                Avx2.Shuffle(vector, Avx2.Add(indices, Vector256Constants.Shuffle_Byte_LaneAdd_K0)),
                Avx2.Shuffle(Avx2.Permute4x64(vector.AsInt64(), (byte)ShuffleControlG4.ZWXY).AsByte(), Avx2.Add(indices, Vector256Constants.Shuffle_Byte_LaneAdd_K1))
            );
            // Remark: The value of each element must be less than count
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleKernel_Avx2(Vector256<ushort> vector, Vector256<ushort> indices) {
            return YShuffleKernel_Avx2_Multiply(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector256<ushort> YShuffleKernel_Avx2_Multiply(Vector256<ushort> vector, Vector256<ushort> indices) {
            Vector256<byte> indices2 = Avx2.Add(Avx2.MultiplyLow(indices, Vector256Constants.Shuffle_UInt16_Multiplier).AsByte(), Vector256Constants.Shuffle_UInt16_ByteOffset);
            return YShuffleKernel_Avx2(vector.AsByte(), indices2).AsUInt16();
        }

#endif
    }
}
#endif // !REDUCE_MEMORY_USAGE
