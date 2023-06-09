#if !REDUCE_MEMORY_USAGE
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
#if NET5_0_OR_GREATER
using System.Runtime.Intrinsics.Arm;
#endif // NET5_0_OR_GREATER
using System.Text;
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// Traits method of Vector128 - Shuffle .
    /// </summary>
    [Obsolete("It is only used for benchmarking results comparison. Please use Vector128s.Shuffle (它仅用于基准测试结果对比. 请使用 Vector128s.Shuffle) .")]
    public static class Vector128_Shuffle {
#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> Shuffle(Vector128<byte> vector, Vector128<byte> indices) {
#if NET5_0_OR_GREATER
            if (AdvSimd.IsSupported) {
                return Shuffle_AdvSimd(vector, indices);
            }
#endif // NET5_0_OR_GREATER
            return Shuffle_Basic(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> Shuffle(Vector128<ushort> vector, Vector128<ushort> indices) {
#if NET5_0_OR_GREATER
            if (AdvSimd.IsSupported) {
                return Shuffle_AdvSimd(vector, indices);
            }
#endif // NET5_0_OR_GREATER
            return Shuffle_Basic(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> Shuffle_Basic(Vector128<byte> vector, Vector128<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            return Vector128.Shuffle(vector, indices);
#else
            return Shuffle_Base_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> Shuffle_Basic(Vector128<ushort> vector, Vector128<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            return Vector128.Shuffle(vector, indices);
#else
            return Shuffle_Base_Basic(vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> Shuffle_Base_Basic(Vector128<byte> vector, Vector128<byte> indices) {
            UnsafeEx.SkipInit(out Vector128<byte> rt);
            byte cnt = (byte)Vector128<byte>.Count;
            ref byte q = ref Unsafe.As<Vector128<byte>, byte>(ref rt);
            ref byte p = ref Unsafe.As<Vector128<byte>, byte>(ref vector);
            ref byte pindices = ref Unsafe.As<Vector128<byte>, byte>(ref indices);
            for (nint i = 0; i < Vector128<byte>.Count; ++i) {
                byte selectedIndex = Unsafe.Add(ref pindices, i);
                byte selectedValue = default;
                if (selectedIndex < cnt) {
                    selectedValue = Unsafe.Add(ref p, selectedIndex);
                }
                Unsafe.Add(ref q, i) = selectedValue;
            }
            return rt;
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> Shuffle_Base_Basic(Vector128<ushort> vector, Vector128<ushort> indices) {
            UnsafeEx.SkipInit(out Vector128<ushort> rt);
            ushort cnt = (ushort)Vector128<ushort>.Count;
            ref ushort q = ref Unsafe.As<Vector128<ushort>, ushort>(ref rt);
            ref ushort p = ref Unsafe.As<Vector128<ushort>, ushort>(ref vector);
            ref ushort pindices = ref Unsafe.As<Vector128<ushort>, ushort>(ref indices);
            for (nint i = 0; i < Vector128<ushort>.Count; ++i) {
                ushort selectedIndex = Unsafe.Add(ref pindices, i);
                ushort selectedValue = default;
                if (selectedIndex < cnt) {
                    selectedValue = Unsafe.Add(ref p, selectedIndex);
                }
                Unsafe.Add(ref q, i) = selectedValue;
            }
            return rt;
        }

#if NET5_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> Shuffle_AdvSimd(Vector128<byte> vector, Vector128<byte> indices) {
            return YShuffleKernel_AdvSimd(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.Shuffle(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> Shuffle_AdvSimd(Vector128<ushort> vector, Vector128<ushort> indices) {
            Vector128<ushort> mask = AdvSimd.CompareGreaterThan(Vector128.Create((ushort)8), indices); // (0<=i && i<8)
            Vector128<byte> indices2 = AdvSimd.MultiplyAdd(Vector128Constants.Shuffle_UInt16_ByteOffset.AsUInt16(), indices, Vector128Constants.Shuffle_UInt16_Multiplier).AsByte();
            indices2 = AdvSimd.OrNot(indices2, mask.AsByte());
            return Shuffle_AdvSimd(vector.AsByte(), indices2).AsUInt16();
        }

#endif // NET5_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleInsert(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> indices) {
#if NET5_0_OR_GREATER
            if (AdvSimd.IsSupported) {
                return YShuffleInsert_AdvSimd(back, vector, indices);
            }
#endif // NET5_0_OR_GREATER
            return YShuffleInsert_Basic(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleInsert(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> indices) {
#if NET5_0_OR_GREATER
            if (AdvSimd.IsSupported) {
                return YShuffleInsert_AdvSimd(back, vector, indices);
            }
#endif // NET5_0_OR_GREATER
            return YShuffleInsert_Basic(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleInsert_Basic(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            Vector128<byte> mask = Vector128.GreaterThan(Vector128.Create((byte)Vector128<byte>.Count), indices);
            Vector128<byte> raw = Vector128.Shuffle(vector, indices);
            Vector128<byte> rt = Vector128.ConditionalSelect(mask, raw, back);
            return rt;
#else
            return YShuffleInsert_Base_Basic(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleInsert_Basic(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            Vector128<ushort> mask = Vector128.GreaterThan(Vector128.Create((ushort)Vector128<ushort>.Count), indices);
            Vector128<ushort> raw = Vector128.Shuffle(vector, indices);
            Vector128<ushort> rt = Vector128.ConditionalSelect(mask, raw, back);
            return rt;
#else
            return YShuffleInsert_Base_Basic(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleInsert_Base_Basic(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> indices) {
            UnsafeEx.SkipInit(out Vector128<byte> rt);
            byte cnt = (byte)Vector128<byte>.Count;
            ref byte q = ref Unsafe.As<Vector128<byte>, byte>(ref rt);
            ref byte p = ref Unsafe.As<Vector128<byte>, byte>(ref vector);
            ref byte pindices = ref Unsafe.As<Vector128<byte>, byte>(ref indices);
            ref byte pback = ref Unsafe.As<Vector128<byte>, byte>(ref back);
            for (nint i = 0; i < Vector128<byte>.Count; ++i) {
                byte selectedIndex = Unsafe.Add(ref pindices, i);
                byte selectedValue = Unsafe.Add(ref pback, i);
                if (selectedIndex < cnt) {
                    selectedValue = Unsafe.Add(ref p, selectedIndex);
                }
                Unsafe.Add(ref q, i) = selectedValue;
            }
            return rt;
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleInsert_Base_Basic(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> indices) {
            UnsafeEx.SkipInit(out Vector128<ushort> rt);
            ushort cnt = (ushort)Vector128<ushort>.Count;
            ref ushort q = ref Unsafe.As<Vector128<ushort>, ushort>(ref rt);
            ref ushort p = ref Unsafe.As<Vector128<ushort>, ushort>(ref vector);
            ref ushort pindices = ref Unsafe.As<Vector128<ushort>, ushort>(ref indices);
            ref ushort pback = ref Unsafe.As<Vector128<ushort>, ushort>(ref back);
            for (nint i = 0; i < Vector128<ushort>.Count; ++i) {
                ushort selectedIndex = Unsafe.Add(ref pindices, i);
                ushort selectedValue = Unsafe.Add(ref pback, i);
                if (selectedIndex < cnt) {
                    selectedValue = Unsafe.Add(ref p, selectedIndex);
                }
                Unsafe.Add(ref q, i) = selectedValue;
            }
            return rt;
        }

#if NET5_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleInsert_AdvSimd(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> indices) {
            Vector128<byte> rt;
            if (AdvSimd.Arm64.IsSupported) {
                rt = AdvSimd.Arm64.VectorTableLookupExtension(back, vector, indices);
            } else {
                rt = Vector128.Create(
                    AdvSimd.VectorTableLookupExtension(back.GetLower(), vector, indices.GetLower()),
                    AdvSimd.VectorTableLookupExtension(back.GetUpper(), vector, indices.GetUpper())
                );
            }
            return rt;
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleInsert_AdvSimd(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> indices) {
            Vector128<ushort> mask = AdvSimd.CompareGreaterThan(Vector128.Create((ushort)8), indices); // (0<=i && i<8)
            Vector128<byte> indices2 = AdvSimd.MultiplyAdd(Vector128Constants.Shuffle_UInt16_ByteOffset.AsUInt16(), indices, Vector128Constants.Shuffle_UInt16_Multiplier).AsByte();
            indices2 = AdvSimd.OrNot(indices2, mask.AsByte());
            return YShuffleInsert_AdvSimd(back.AsByte(), vector.AsByte(), indices2).AsUInt16();
        }

#endif // NET5_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{sbyte}, Vector128{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<sbyte> YShuffleKernel(Vector128<sbyte> vector, Vector128<sbyte> indices) {
            return YShuffleKernel(vector.AsByte(), indices.AsByte()).AsSByte();
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleKernel(Vector128<byte> vector, Vector128<byte> indices) {
#if NET5_0_OR_GREATER
            if (AdvSimd.IsSupported) {
                return YShuffleKernel_AdvSimd(vector, indices);
            }
#endif // NET5_0_OR_GREATER
            return YShuffleKernel_Basic(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{short}, Vector128{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<short> YShuffleKernel(Vector128<short> vector, Vector128<short> indices) {
            return YShuffleKernel(vector.AsUInt16(), indices.AsUInt16()).AsInt16();
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleKernel(Vector128<ushort> vector, Vector128<ushort> indices) {
#if NET5_0_OR_GREATER
            if (AdvSimd.IsSupported) {
                return YShuffleKernel_AdvSimd(vector, indices);
            }
#endif // NET5_0_OR_GREATER
            return YShuffleKernel_Basic(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleKernel_Basic(Vector128<byte> vector, Vector128<byte> indices) {
            return Shuffle_Basic(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleKernel_Basic(Vector128<ushort> vector, Vector128<ushort> indices) {
            return Shuffle_Basic(vector, indices);
        }

#if NET5_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{byte}, Vector128{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<byte> YShuffleKernel_AdvSimd(Vector128<byte> vector, Vector128<byte> indices) {
            Vector128<byte> rt;
            if (AdvSimd.Arm64.IsSupported) {
                rt = AdvSimd.Arm64.VectorTableLookup(vector, indices);
            } else {
                rt = Vector128.Create(
                    AdvSimd.VectorTableLookup(vector, indices.GetLower()),
                    AdvSimd.VectorTableLookup(vector, indices.GetUpper())
                );
            }
            return rt;
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleKernel_AdvSimd(Vector128<ushort> vector, Vector128<ushort> indices) {
            return YShuffleKernel_AdvSimd_Multiply(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ushort}, Vector128{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector128<ushort> YShuffleKernel_AdvSimd_Multiply(Vector128<ushort> vector, Vector128<ushort> indices) {
            Vector128<byte> indices2 = AdvSimd.MultiplyAdd(Vector128Constants.Shuffle_UInt16_ByteOffset.AsUInt16(), indices, Vector128Constants.Shuffle_UInt16_Multiplier).AsByte();
            return YShuffleKernel_AdvSimd(vector.AsByte(), indices2).AsUInt16();
        }

#endif // NET5_0_OR_GREATER

#endif
    }
}
#endif // !REDUCE_MEMORY_USAGE
