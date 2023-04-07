using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl.AVector128 {

    partial class WVectorTraits128Base {

        partial class Statics {

#if NETCOREAPP3_0_OR_GREATER

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleInsert_AcceleratedTypes {
                get {
                    return Shuffle_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{float}, Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleInsert(Vector128<float> back, Vector128<float> vector, Vector128<int> indices) {
                return YShuffleInsert(back.AsUInt32(), vector.AsUInt32(), indices.AsUInt32()).AsSingle();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{double}, Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleInsert(Vector128<double> back, Vector128<double> vector, Vector128<long> indices) {
                return YShuffleInsert(back.AsUInt64(), vector.AsUInt64(), indices.AsUInt64()).AsDouble();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{sbyte}, Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleInsert(Vector128<sbyte> back, Vector128<sbyte> vector, Vector128<sbyte> indices) {
                return YShuffleInsert(back.AsByte(), vector.AsByte(), indices.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleInsert(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                Vector128<byte> mask = Vector128.GreaterThan(Vector128.Create((byte)Vector128<byte>.Count), indices);
                Vector128<byte> raw = Vector128.Shuffle(vector, indices);
                Vector128<byte> rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
#else
                return YShuffleInsert_Base(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{short}, Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleInsert(Vector128<short> back, Vector128<short> vector, Vector128<short> indices) {
                return YShuffleInsert(back.AsUInt16(), vector.AsUInt16(), indices.AsUInt16()).AsInt16();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ushort}, Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleInsert(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                Vector128<ushort> mask = Vector128.GreaterThan(Vector128.Create((ushort)Vector128<ushort>.Count), indices);
                Vector128<ushort> raw = Vector128.Shuffle(vector, indices);
                Vector128<ushort> rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
#else
                return YShuffleInsert_Base(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{int}, Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleInsert(Vector128<int> back, Vector128<int> vector, Vector128<int> indices) {
                return YShuffleInsert(back.AsUInt32(), vector.AsUInt32(), indices.AsUInt32()).AsInt32();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleInsert(Vector128<uint> back, Vector128<uint> vector, Vector128<uint> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                Vector128<uint> mask = Vector128.GreaterThan(Vector128.Create((uint)Vector128<uint>.Count), indices);
                Vector128<uint> raw = Vector128.Shuffle(vector, indices);
                Vector128<uint> rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
#else
                return YShuffleInsert_Base(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{long}, Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleInsert(Vector128<long> back, Vector128<long> vector, Vector128<long> indices) {
                return YShuffleInsert(back.AsUInt64(), vector.AsUInt64(), indices.AsUInt64()).AsInt64();
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleInsert(Vector128<ulong> back, Vector128<ulong> vector, Vector128<ulong> indices) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                Vector128<ulong> mask = Vector128.GreaterThan(Vector128.Create((ulong)Vector128<ulong>.Count), indices);
                Vector128<ulong> raw = Vector128.Shuffle(vector, indices);
                Vector128<ulong> rt = Vector128.ConditionalSelect(mask, raw, back);
                return rt;
#else
                return YShuffleInsert_Base(back, vector, indices);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{byte}, Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleInsert_Base(Vector128<byte> back, Vector128<byte> vector, Vector128<byte> indices) {
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
            public static Vector128<ushort> YShuffleInsert_Base(Vector128<ushort> back, Vector128<ushort> vector, Vector128<ushort> indices) {
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

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{uint}, Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleInsert_Base(Vector128<uint> back, Vector128<uint> vector, Vector128<uint> indices) {
                UnsafeEx.SkipInit(out Vector128<uint> rt);
                uint cnt = (uint)Vector128<uint>.Count;
                ref uint q = ref Unsafe.As<Vector128<uint>, uint>(ref rt);
                ref uint p = ref Unsafe.As<Vector128<uint>, uint>(ref vector);
                ref uint pindices = ref Unsafe.As<Vector128<uint>, uint>(ref indices);
                ref uint pback = ref Unsafe.As<Vector128<uint>, uint>(ref back);
                for (nint i = 0; i < Vector128<uint>.Count; ++i) {
                    uint selectedIndex = Unsafe.Add(ref pindices, i);
                    uint selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, (int)selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleInsert(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleInsert_Base(Vector128<ulong> back, Vector128<ulong> vector, Vector128<ulong> indices) {
                UnsafeEx.SkipInit(out Vector128<ulong> rt);
                ulong cnt = (ulong)Vector128<ulong>.Count;
                ref ulong q = ref Unsafe.As<Vector128<ulong>, ulong>(ref rt);
                ref ulong p = ref Unsafe.As<Vector128<ulong>, ulong>(ref vector);
                ref ulong pindices = ref Unsafe.As<Vector128<ulong>, ulong>(ref indices);
                ref ulong pback = ref Unsafe.As<Vector128<ulong>, ulong>(ref back);
                for (nint i = 0; i < Vector128<ulong>.Count; ++i) {
                    ulong selectedIndex = Unsafe.Add(ref pindices, i);
                    ulong selectedValue = Unsafe.Add(ref pback, i);
                    if (selectedIndex < cnt) {
                        selectedValue = Unsafe.Add(ref p, (int)selectedIndex);
                    }
                    Unsafe.Add(ref q, i) = selectedValue;
                }
                return rt;
            }


            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel_AcceleratedTypes"/>
            public static TypeCodeFlags YShuffleKernel_AcceleratedTypes {
                get {
                    return Shuffle_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{float}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<float> YShuffleKernel(Vector128<float> vector, Vector128<int> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{double}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<double> YShuffleKernel(Vector128<double> vector, Vector128<long> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{sbyte}, Vector128{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<sbyte> YShuffleKernel(Vector128<sbyte> vector, Vector128<sbyte> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{byte}, Vector128{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<byte> YShuffleKernel(Vector128<byte> vector, Vector128<byte> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{short}, Vector128{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<short> YShuffleKernel(Vector128<short> vector, Vector128<short> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ushort}, Vector128{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ushort> YShuffleKernel(Vector128<ushort> vector, Vector128<ushort> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{int}, Vector128{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<int> YShuffleKernel(Vector128<int> vector, Vector128<int> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{uint}, Vector128{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<uint> YShuffleKernel(Vector128<uint> vector, Vector128<uint> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{long}, Vector128{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<long> YShuffleKernel(Vector128<long> vector, Vector128<long> indices) {
                return Shuffle(vector, indices);
            }

            /// <inheritdoc cref="IWVectorTraits128.YShuffleKernel(Vector128{ulong}, Vector128{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector128<ulong> YShuffleKernel(Vector128<ulong> vector, Vector128<ulong> indices) {
                return Shuffle(vector, indices);
            }


#endif // NETCOREAPP3_0_OR_GREATER
        }
    }
}
