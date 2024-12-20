﻿//#define FALLBACK_USE_T

#if NET5_0_OR_GREATER
#define USE_VECTOR_CREATE // .NET5+ has better performance (Without int64/uint64 on 32bit system) .
#endif // NET5_0_OR_GREATER
#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#define USE_VECTOR_CREATE_INT64 // .NET7+ has better performance of int64/uint64 on 32bit system .
#endif // NET7_0_OR_GREATER

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.ExTypes;

namespace Zyl.VectorTraits.Impl {
    partial class Vector256Constants {
#if NETCOREAPP3_0_OR_GREATER

        /// <summary>YGroup1ToGroup3 - Shuffle - Byte - The index of item 0.</summary>
        public static Vector256<byte> YGroup1ToGroup3_Shuffle_Byte_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10);
        }
#else
            get;
        } = Vector256.Create((byte)0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - Byte - The index of item 1.</summary>
        public static Vector256<byte> YGroup1ToGroup3_Shuffle_Byte_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)10, 11, 11, 11, 12, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 15, 16, 16, 16, 17, 17, 17, 18, 18, 18, 19, 19, 19, 20, 20, 20, 21);
        }
#else
            get;
        } = Vector256.Create((byte)10, 11, 11, 11, 12, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 15, 16, 16, 16, 17, 17, 17, 18, 18, 18, 19, 19, 19, 20, 20, 20, 21);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - Byte - The index of item 2.</summary>
        public static Vector256<byte> YGroup1ToGroup3_Shuffle_Byte_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)21, 21, 22, 22, 22, 23, 23, 23, 24, 24, 24, 25, 25, 25, 26, 26, 26, 27, 27, 27, 28, 28, 28, 29, 29, 29, 30, 30, 30, 31, 31, 31);
        }
#else
            get;
        } = Vector256.Create((byte)21, 21, 22, 22, 22, 23, 23, 23, 24, 24, 24, 25, 25, 25, 26, 26, 26, 27, 27, 27, 28, 28, 28, 29, 29, 29, 30, 30, 30, 31, 31, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - Byte - Each 128 bits - The index of item 0.</summary>
        public static Vector256<byte> YGroup1ToGroup3_Shuffle_Byte_Each128_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5);
        }
#else
            get;
        } = Vector256.Create((byte)0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - Byte - Each 128 bits - The index of item 1.</summary>
        public static Vector256<byte> YGroup1ToGroup3_Shuffle_Byte_Each128_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10);
        }
#else
            get;
        } = Vector256.Create((byte)5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - Byte - Each 128 bits - The index of item 2.</summary>
        public static Vector256<byte> YGroup1ToGroup3_Shuffle_Byte_Each128_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)10, 11, 11, 11, 12, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 15, 10, 11, 11, 11, 12, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 15);
        }
#else
            get;
        } = Vector256.Create((byte)10, 11, 11, 11, 12, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 15, 10, 11, 11, 11, 12, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - UInt16 - The index of item 0.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup1ToGroup3_Shuffle_UInt16_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5);
        }
#else
            get;
        } = Vector256.Create((ushort)0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - UInt16 - The index of item 1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup1ToGroup3_Shuffle_UInt16_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10);
        }
#else
            get;
        } = Vector256.Create((ushort)5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - UInt16 - The index of item 2.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup1ToGroup3_Shuffle_UInt16_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)10, 11, 11, 11, 12, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 15);
        }
#else
            get;
        } = Vector256.Create((ushort)10, 11, 11, 11, 12, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - UInt32 - The index of item 0.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup1ToGroup3_Shuffle_UInt32_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)0, 0, 0, 1, 1, 1, 2, 2);
        }
#else
            get;
        } = Vector256.Create((uint)0, 0, 0, 1, 1, 1, 2, 2);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - UInt32 - The index of item 1.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup1ToGroup3_Shuffle_UInt32_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)2, 3, 3, 3, 4, 4, 4, 5);
        }
#else
            get;
        } = Vector256.Create((uint)2, 3, 3, 3, 4, 4, 4, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - UInt32 - The index of item 2.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup1ToGroup3_Shuffle_UInt32_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)5, 5, 6, 6, 6, 7, 7, 7);
        }
#else
            get;
        } = Vector256.Create((uint)5, 5, 6, 6, 6, 7, 7, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - UInt64 - The index of item 0.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup1ToGroup3_Shuffle_UInt64_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)0, 0, 0, 1);
        }
#else
            get;
        } = Vector256.Create((ulong)0, 0, 0, 1);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - UInt64 - The index of item 1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup1ToGroup3_Shuffle_UInt64_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)1, 1, 2, 2);
        }
#else
            get;
        } = Vector256.Create((ulong)1, 1, 2, 2);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - UInt64 - The index of item 2.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup1ToGroup3_Shuffle_UInt64_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)2, 3, 3, 3);
        }
#else
            get;
        } = Vector256.Create((ulong)2, 3, 3, 3);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt16 - The index of item 0.</summary>
        public static Vector256<byte> YGroup1ToGroup3_ShuffleOnByte_UInt16_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 0, 1, 0, 1, 2, 3, 2, 3, 2, 3, 4, 5, 4, 5, 4, 5, 6, 7, 6, 7, 6, 7, 8, 9, 8, 9, 8, 9, 10, 11);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 0, 1, 0, 1, 2, 3, 2, 3, 2, 3, 4, 5, 4, 5, 4, 5, 6, 7, 6, 7, 6, 7, 8, 9, 8, 9, 8, 9, 10, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt16 - The index of item 1.</summary>
        public static Vector256<byte> YGroup1ToGroup3_ShuffleOnByte_UInt16_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)10, 11, 10, 11, 12, 13, 12, 13, 12, 13, 14, 15, 14, 15, 14, 15, 16, 17, 16, 17, 16, 17, 18, 19, 18, 19, 18, 19, 20, 21, 20, 21);
        }
#else
            get;
        } = Vector256.Create((byte)10, 11, 10, 11, 12, 13, 12, 13, 12, 13, 14, 15, 14, 15, 14, 15, 16, 17, 16, 17, 16, 17, 18, 19, 18, 19, 18, 19, 20, 21, 20, 21);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt16 - The index of item 2.</summary>
        public static Vector256<byte> YGroup1ToGroup3_ShuffleOnByte_UInt16_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)20, 21, 22, 23, 22, 23, 22, 23, 24, 25, 24, 25, 24, 25, 26, 27, 26, 27, 26, 27, 28, 29, 28, 29, 28, 29, 30, 31, 30, 31, 30, 31);
        }
#else
            get;
        } = Vector256.Create((byte)20, 21, 22, 23, 22, 23, 22, 23, 24, 25, 24, 25, 24, 25, 26, 27, 26, 27, 26, 27, 28, 29, 28, 29, 28, 29, 30, 31, 30, 31, 30, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt32 - The index of item 0.</summary>
        public static Vector256<byte> YGroup1ToGroup3_ShuffleOnByte_UInt32_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3, 4, 5, 6, 7, 4, 5, 6, 7, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3, 4, 5, 6, 7, 4, 5, 6, 7, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt32 - The index of item 1.</summary>
        public static Vector256<byte> YGroup1ToGroup3_ShuffleOnByte_UInt32_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15, 12, 13, 14, 15, 16, 17, 18, 19, 16, 17, 18, 19, 16, 17, 18, 19, 20, 21, 22, 23);
        }
#else
            get;
        } = Vector256.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15, 12, 13, 14, 15, 16, 17, 18, 19, 16, 17, 18, 19, 16, 17, 18, 19, 20, 21, 22, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt32 - The index of item 2.</summary>
        public static Vector256<byte> YGroup1ToGroup3_ShuffleOnByte_UInt32_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)20, 21, 22, 23, 20, 21, 22, 23, 24, 25, 26, 27, 24, 25, 26, 27, 24, 25, 26, 27, 28, 29, 30, 31, 28, 29, 30, 31, 28, 29, 30, 31);
        }
#else
            get;
        } = Vector256.Create((byte)20, 21, 22, 23, 20, 21, 22, 23, 24, 25, 26, 27, 24, 25, 26, 27, 24, 25, 26, 27, 28, 29, 30, 31, 28, 29, 30, 31, 28, 29, 30, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt64 - The index of item 0.</summary>
        public static Vector256<byte> YGroup1ToGroup3_ShuffleOnByte_UInt64_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt64 - The index of item 1.</summary>
        public static Vector256<byte> YGroup1ToGroup3_ShuffleOnByte_UInt64_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 16, 17, 18, 19, 20, 21, 22, 23);
        }
#else
            get;
        } = Vector256.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 16, 17, 18, 19, 20, 21, 22, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt64 - The index of item 2.</summary>
        public static Vector256<byte> YGroup1ToGroup3_ShuffleOnByte_UInt64_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 24, 25, 26, 27, 28, 29, 30, 31, 24, 25, 26, 27, 28, 29, 30, 31);
        }
#else
            get;
        } = Vector256.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 24, 25, 26, 27, 28, 29, 30, 31, 24, 25, 26, 27, 28, 29, 30, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt16 - Each 128 bits - The index of item 0.</summary>
        public static Vector256<byte> YGroup1ToGroup3_ShuffleOnByte_UInt16_Each128_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 0, 1, 0, 1, 2, 3, 2, 3, 2, 3, 4, 5, 4, 5, 0, 1, 0, 1, 0, 1, 2, 3, 2, 3, 2, 3, 4, 5, 4, 5);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 0, 1, 0, 1, 2, 3, 2, 3, 2, 3, 4, 5, 4, 5, 0, 1, 0, 1, 0, 1, 2, 3, 2, 3, 2, 3, 4, 5, 4, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt16 - Each 128 bits - The index of item 1.</summary>
        public static Vector256<byte> YGroup1ToGroup3_ShuffleOnByte_UInt16_Each128_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)4, 5, 6, 7, 6, 7, 6, 7, 8, 9, 8, 9, 8, 9, 10, 11, 4, 5, 6, 7, 6, 7, 6, 7, 8, 9, 8, 9, 8, 9, 10, 11);
        }
#else
            get;
        } = Vector256.Create((byte)4, 5, 6, 7, 6, 7, 6, 7, 8, 9, 8, 9, 8, 9, 10, 11, 4, 5, 6, 7, 6, 7, 6, 7, 8, 9, 8, 9, 8, 9, 10, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt16 - Each 128 bits - The index of item 2.</summary>
        public static Vector256<byte> YGroup1ToGroup3_ShuffleOnByte_UInt16_Each128_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)10, 11, 10, 11, 12, 13, 12, 13, 12, 13, 14, 15, 14, 15, 14, 15, 10, 11, 10, 11, 12, 13, 12, 13, 12, 13, 14, 15, 14, 15, 14, 15);
        }
#else
            get;
        } = Vector256.Create((byte)10, 11, 10, 11, 12, 13, 12, 13, 12, 13, 14, 15, 14, 15, 14, 15, 10, 11, 10, 11, 12, 13, 12, 13, 12, 13, 14, 15, 14, 15, 14, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt32 - Each 128 bits - The index of item 0.</summary>
        public static Vector256<byte> YGroup1ToGroup3_ShuffleOnByte_UInt32_Each128_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3, 4, 5, 6, 7);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3, 4, 5, 6, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt32 - Each 128 bits - The index of item 1.</summary>
        public static Vector256<byte> YGroup1ToGroup3_ShuffleOnByte_UInt32_Each128_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)4, 5, 6, 7, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11, 4, 5, 6, 7, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11);
        }
#else
            get;
        } = Vector256.Create((byte)4, 5, 6, 7, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11, 4, 5, 6, 7, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt32 - Each 128 bits - The index of item 2.</summary>
        public static Vector256<byte> YGroup1ToGroup3_ShuffleOnByte_UInt32_Each128_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15, 12, 13, 14, 15);
        }
#else
            get;
        } = Vector256.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15, 12, 13, 14, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt64 - Each 128 bits - The index of item 0.</summary>
        public static Vector256<byte> YGroup1ToGroup3_ShuffleOnByte_UInt64_Each128_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt64 - Each 128 bits - The index of item 1.</summary>
        public static Vector256<byte> YGroup1ToGroup3_ShuffleOnByte_UInt64_Each128_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt64 - Each 128 bits - The index of item 2.</summary>
        public static Vector256<byte> YGroup1ToGroup3_ShuffleOnByte_UInt64_Each128_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15);
        }
#else
            get;
        } = Vector256.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15);
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup2Transpose - Shuffle - Byte - The index of item 0.</summary>
        public static Vector256<byte> YGroup2Transpose_Shuffle_Byte_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 32, 2, 34, 4, 36, 6, 38, 8, 40, 10, 42, 12, 44, 14, 46, 16, 48, 18, 50, 20, 52, 22, 54, 24, 56, 26, 58, 28, 60, 30, 62);
        }
#else
            get;
        } = Vector256.Create((byte)0, 32, 2, 34, 4, 36, 6, 38, 8, 40, 10, 42, 12, 44, 14, 46, 16, 48, 18, 50, 20, 52, 22, 54, 24, 56, 26, 58, 28, 60, 30, 62);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle - Byte - The index of item 0 - Sub part0.</summary>
        public static Vector256<byte> YGroup2Transpose_Shuffle_Byte_0A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, -1, 2, -1, 4, -1, 6, -1, 8, -1, 10, -1, 12, -1, 14, -1, 16, -1, 18, -1, 20, -1, 22, -1, 24, -1, 26, -1, 28, -1, 30, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, -1, 2, -1, 4, -1, 6, -1, 8, -1, 10, -1, 12, -1, 14, -1, 16, -1, 18, -1, 20, -1, 22, -1, 24, -1, 26, -1, 28, -1, 30, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle - Byte - The index of item 0 - Sub part1.</summary>
        public static Vector256<byte> YGroup2Transpose_Shuffle_Byte_0B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, 0, -1, 2, -1, 4, -1, 6, -1, 8, -1, 10, -1, 12, -1, 14, -1, 16, -1, 18, -1, 20, -1, 22, -1, 24, -1, 26, -1, 28, -1, 30).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, 0, -1, 2, -1, 4, -1, 6, -1, 8, -1, 10, -1, 12, -1, 14, -1, 16, -1, 18, -1, 20, -1, 22, -1, 24, -1, 26, -1, 28, -1, 30).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle - Byte - The index of item 1.</summary>
        public static Vector256<byte> YGroup2Transpose_Shuffle_Byte_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)1, 33, 3, 35, 5, 37, 7, 39, 9, 41, 11, 43, 13, 45, 15, 47, 17, 49, 19, 51, 21, 53, 23, 55, 25, 57, 27, 59, 29, 61, 31, 63);
        }
#else
            get;
        } = Vector256.Create((byte)1, 33, 3, 35, 5, 37, 7, 39, 9, 41, 11, 43, 13, 45, 15, 47, 17, 49, 19, 51, 21, 53, 23, 55, 25, 57, 27, 59, 29, 61, 31, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle - Byte - The index of item 1 - Sub part0.</summary>
        public static Vector256<byte> YGroup2Transpose_Shuffle_Byte_1A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)1, -1, 3, -1, 5, -1, 7, -1, 9, -1, 11, -1, 13, -1, 15, -1, 17, -1, 19, -1, 21, -1, 23, -1, 25, -1, 27, -1, 29, -1, 31, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)1, -1, 3, -1, 5, -1, 7, -1, 9, -1, 11, -1, 13, -1, 15, -1, 17, -1, 19, -1, 21, -1, 23, -1, 25, -1, 27, -1, 29, -1, 31, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle - Byte - The index of item 1 - Sub part1.</summary>
        public static Vector256<byte> YGroup2Transpose_Shuffle_Byte_1B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, 1, -1, 3, -1, 5, -1, 7, -1, 9, -1, 11, -1, 13, -1, 15, -1, 17, -1, 19, -1, 21, -1, 23, -1, 25, -1, 27, -1, 29, -1, 31).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, 1, -1, 3, -1, 5, -1, 7, -1, 9, -1, 11, -1, 13, -1, 15, -1, 17, -1, 19, -1, 21, -1, 23, -1, 25, -1, 27, -1, 29, -1, 31).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle - UInt16 - The index of item 0.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup2Transpose_Shuffle_UInt16_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)0, 16, 2, 18, 4, 20, 6, 22, 8, 24, 10, 26, 12, 28, 14, 30);
        }
#else
            get;
        } = Vector256.Create((ushort)0, 16, 2, 18, 4, 20, 6, 22, 8, 24, 10, 26, 12, 28, 14, 30);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle - UInt16 - The index of item 1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup2Transpose_Shuffle_UInt16_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)1, 17, 3, 19, 5, 21, 7, 23, 9, 25, 11, 27, 13, 29, 15, 31);
        }
#else
            get;
        } = Vector256.Create((ushort)1, 17, 3, 19, 5, 21, 7, 23, 9, 25, 11, 27, 13, 29, 15, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle - UInt32 - The index of item 0.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup2Transpose_Shuffle_UInt32_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)0, 8, 2, 10, 4, 12, 6, 14);
        }
#else
            get;
        } = Vector256.Create((uint)0, 8, 2, 10, 4, 12, 6, 14);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle - UInt32 - The index of item 1.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup2Transpose_Shuffle_UInt32_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)1, 9, 3, 11, 5, 13, 7, 15);
        }
#else
            get;
        } = Vector256.Create((uint)1, 9, 3, 11, 5, 13, 7, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle - UInt64 - The index of item 0.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup2Transpose_Shuffle_UInt64_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)0, 4, 2, 6);
        }
#else
            get;
        } = Vector256.Create((ulong)0, 4, 2, 6);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle - UInt64 - The index of item 1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup2Transpose_Shuffle_UInt64_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)1, 5, 3, 7);
        }
#else
            get;
        } = Vector256.Create((ulong)1, 5, 3, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle on byte - UInt16 - The index of item 0.</summary>
        public static Vector256<byte> YGroup2Transpose_ShuffleOnByte_UInt16_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 32, 33, 4, 5, 36, 37, 8, 9, 40, 41, 12, 13, 44, 45, 16, 17, 48, 49, 20, 21, 52, 53, 24, 25, 56, 57, 28, 29, 60, 61);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 32, 33, 4, 5, 36, 37, 8, 9, 40, 41, 12, 13, 44, 45, 16, 17, 48, 49, 20, 21, 52, 53, 24, 25, 56, 57, 28, 29, 60, 61);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle on byte - UInt16 - The index of item 0 - Sub part0.</summary>
        public static Vector256<byte> YGroup2Transpose_ShuffleOnByte_UInt16_0A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 1, -1, -1, 4, 5, -1, -1, 8, 9, -1, -1, 12, 13, -1, -1, 16, 17, -1, -1, 20, 21, -1, -1, 24, 25, -1, -1, 28, 29, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 1, -1, -1, 4, 5, -1, -1, 8, 9, -1, -1, 12, 13, -1, -1, 16, 17, -1, -1, 20, 21, -1, -1, 24, 25, -1, -1, 28, 29, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle on byte - UInt16 - The index of item 0 - Sub part1.</summary>
        public static Vector256<byte> YGroup2Transpose_ShuffleOnByte_UInt16_0B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, 0, 1, -1, -1, 4, 5, -1, -1, 8, 9, -1, -1, 12, 13, -1, -1, 16, 17, -1, -1, 20, 21, -1, -1, 24, 25, -1, -1, 28, 29).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, 0, 1, -1, -1, 4, 5, -1, -1, 8, 9, -1, -1, 12, 13, -1, -1, 16, 17, -1, -1, 20, 21, -1, -1, 24, 25, -1, -1, 28, 29).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle on byte - UInt16 - The index of item 1.</summary>
        public static Vector256<byte> YGroup2Transpose_ShuffleOnByte_UInt16_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)2, 3, 34, 35, 6, 7, 38, 39, 10, 11, 42, 43, 14, 15, 46, 47, 18, 19, 50, 51, 22, 23, 54, 55, 26, 27, 58, 59, 30, 31, 62, 63);
        }
#else
            get;
        } = Vector256.Create((byte)2, 3, 34, 35, 6, 7, 38, 39, 10, 11, 42, 43, 14, 15, 46, 47, 18, 19, 50, 51, 22, 23, 54, 55, 26, 27, 58, 59, 30, 31, 62, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle on byte - UInt16 - The index of item 1 - Sub part0.</summary>
        public static Vector256<byte> YGroup2Transpose_ShuffleOnByte_UInt16_1A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)2, 3, -1, -1, 6, 7, -1, -1, 10, 11, -1, -1, 14, 15, -1, -1, 18, 19, -1, -1, 22, 23, -1, -1, 26, 27, -1, -1, 30, 31, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)2, 3, -1, -1, 6, 7, -1, -1, 10, 11, -1, -1, 14, 15, -1, -1, 18, 19, -1, -1, 22, 23, -1, -1, 26, 27, -1, -1, 30, 31, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle on byte - UInt16 - The index of item 1 - Sub part1.</summary>
        public static Vector256<byte> YGroup2Transpose_ShuffleOnByte_UInt16_1B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, 2, 3, -1, -1, 6, 7, -1, -1, 10, 11, -1, -1, 14, 15, -1, -1, 18, 19, -1, -1, 22, 23, -1, -1, 26, 27, -1, -1, 30, 31).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, 2, 3, -1, -1, 6, 7, -1, -1, 10, 11, -1, -1, 14, 15, -1, -1, 18, 19, -1, -1, 22, 23, -1, -1, 26, 27, -1, -1, 30, 31).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle on byte - UInt32 - The index of item 0.</summary>
        public static Vector256<byte> YGroup2Transpose_ShuffleOnByte_UInt32_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 3, 32, 33, 34, 35, 8, 9, 10, 11, 40, 41, 42, 43, 16, 17, 18, 19, 48, 49, 50, 51, 24, 25, 26, 27, 56, 57, 58, 59);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 3, 32, 33, 34, 35, 8, 9, 10, 11, 40, 41, 42, 43, 16, 17, 18, 19, 48, 49, 50, 51, 24, 25, 26, 27, 56, 57, 58, 59);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle on byte - UInt32 - The index of item 0 - Sub part0.</summary>
        public static Vector256<byte> YGroup2Transpose_ShuffleOnByte_UInt32_0A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 1, 2, 3, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, 16, 17, 18, 19, -1, -1, -1, -1, 24, 25, 26, 27, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 1, 2, 3, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, 16, 17, 18, 19, -1, -1, -1, -1, 24, 25, 26, 27, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle on byte - UInt32 - The index of item 0 - Sub part1.</summary>
        public static Vector256<byte> YGroup2Transpose_ShuffleOnByte_UInt32_0B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, 16, 17, 18, 19, -1, -1, -1, -1, 24, 25, 26, 27).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, 16, 17, 18, 19, -1, -1, -1, -1, 24, 25, 26, 27).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle on byte - UInt32 - The index of item 1.</summary>
        public static Vector256<byte> YGroup2Transpose_ShuffleOnByte_UInt32_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)4, 5, 6, 7, 36, 37, 38, 39, 12, 13, 14, 15, 44, 45, 46, 47, 20, 21, 22, 23, 52, 53, 54, 55, 28, 29, 30, 31, 60, 61, 62, 63);
        }
#else
            get;
        } = Vector256.Create((byte)4, 5, 6, 7, 36, 37, 38, 39, 12, 13, 14, 15, 44, 45, 46, 47, 20, 21, 22, 23, 52, 53, 54, 55, 28, 29, 30, 31, 60, 61, 62, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle on byte - UInt32 - The index of item 1 - Sub part0.</summary>
        public static Vector256<byte> YGroup2Transpose_ShuffleOnByte_UInt32_1A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)4, 5, 6, 7, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, 20, 21, 22, 23, -1, -1, -1, -1, 28, 29, 30, 31, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)4, 5, 6, 7, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, 20, 21, 22, 23, -1, -1, -1, -1, 28, 29, 30, 31, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle on byte - UInt32 - The index of item 1 - Sub part1.</summary>
        public static Vector256<byte> YGroup2Transpose_ShuffleOnByte_UInt32_1B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, 20, 21, 22, 23, -1, -1, -1, -1, 28, 29, 30, 31).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, 20, 21, 22, 23, -1, -1, -1, -1, 28, 29, 30, 31).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle on byte - UInt64 - The index of item 0.</summary>
        public static Vector256<byte> YGroup2Transpose_ShuffleOnByte_UInt64_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 32, 33, 34, 35, 36, 37, 38, 39, 16, 17, 18, 19, 20, 21, 22, 23, 48, 49, 50, 51, 52, 53, 54, 55);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 32, 33, 34, 35, 36, 37, 38, 39, 16, 17, 18, 19, 20, 21, 22, 23, 48, 49, 50, 51, 52, 53, 54, 55);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle on byte - UInt64 - The index of item 0 - Sub part0.</summary>
        public static Vector256<byte> YGroup2Transpose_ShuffleOnByte_UInt64_0A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 16, 17, 18, 19, 20, 21, 22, 23, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 16, 17, 18, 19, 20, 21, 22, 23, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle on byte - UInt64 - The index of item 0 - Sub part1.</summary>
        public static Vector256<byte> YGroup2Transpose_ShuffleOnByte_UInt64_0B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 16, 17, 18, 19, 20, 21, 22, 23).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 16, 17, 18, 19, 20, 21, 22, 23).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle on byte - UInt64 - The index of item 1.</summary>
        public static Vector256<byte> YGroup2Transpose_ShuffleOnByte_UInt64_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 40, 41, 42, 43, 44, 45, 46, 47, 24, 25, 26, 27, 28, 29, 30, 31, 56, 57, 58, 59, 60, 61, 62, 63);
        }
#else
            get;
        } = Vector256.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 40, 41, 42, 43, 44, 45, 46, 47, 24, 25, 26, 27, 28, 29, 30, 31, 56, 57, 58, 59, 60, 61, 62, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle on byte - UInt64 - The index of item 1 - Sub part0.</summary>
        public static Vector256<byte> YGroup2Transpose_ShuffleOnByte_UInt64_1A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 24, 25, 26, 27, 28, 29, 30, 31, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 24, 25, 26, 27, 28, 29, 30, 31, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Transpose - Shuffle on byte - UInt64 - The index of item 1 - Sub part1.</summary>
        public static Vector256<byte> YGroup2Transpose_ShuffleOnByte_UInt64_1B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 24, 25, 26, 27, 28, 29, 30, 31).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 24, 25, 26, 27, 28, 29, 30, 31).AsByte();
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup2Unzip - ShuffleX2 - Byte - The index of X.</summary>
        public static Vector256<byte> YGroup2Unzip_ShuffleX2_Byte_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58, 60, 62);
        }
#else
            get;
        } = Vector256.Create((byte)0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58, 60, 62);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - Byte - The index of Y.</summary>
        public static Vector256<byte> YGroup2Unzip_ShuffleX2_Byte_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53, 55, 57, 59, 61, 63);
        }
#else
            get;
        } = Vector256.Create((byte)1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53, 55, 57, 59, 61, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt16 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup2Unzip_ShuffleX2_UInt16_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30);
        }
#else
            get;
        } = Vector256.Create((ushort)0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt16 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup2Unzip_ShuffleX2_UInt16_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31);
        }
#else
            get;
        } = Vector256.Create((ushort)1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt32 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup2Unzip_ShuffleX2_UInt32_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)0, 2, 4, 6, 8, 10, 12, 14);
        }
#else
            get;
        } = Vector256.Create((uint)0, 2, 4, 6, 8, 10, 12, 14);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt32 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup2Unzip_ShuffleX2_UInt32_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)1, 3, 5, 7, 9, 11, 13, 15);
        }
#else
            get;
        } = Vector256.Create((uint)1, 3, 5, 7, 9, 11, 13, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt64 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup2Unzip_ShuffleX2_UInt64_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)0, 2, 4, 6);
        }
#else
            get;
        } = Vector256.Create((ulong)0, 2, 4, 6);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt64 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup2Unzip_ShuffleX2_UInt64_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)1, 3, 5, 7);
        }
#else
            get;
        } = Vector256.Create((ulong)1, 3, 5, 7);
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup2Zip - ShuffleX2 - Byte - The index of data0.</summary>
        public static Vector256<byte> YGroup2Zip_ShuffleX2_Byte_Data0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 32, 1, 33, 2, 34, 3, 35, 4, 36, 5, 37, 6, 38, 7, 39, 8, 40, 9, 41, 10, 42, 11, 43, 12, 44, 13, 45, 14, 46, 15, 47);
        }
#else
            get;
        } = Vector256.Create((byte)0, 32, 1, 33, 2, 34, 3, 35, 4, 36, 5, 37, 6, 38, 7, 39, 8, 40, 9, 41, 10, 42, 11, 43, 12, 44, 13, 45, 14, 46, 15, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - Byte - The index of data1.</summary>
        public static Vector256<byte> YGroup2Zip_ShuffleX2_Byte_Data1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)16, 48, 17, 49, 18, 50, 19, 51, 20, 52, 21, 53, 22, 54, 23, 55, 24, 56, 25, 57, 26, 58, 27, 59, 28, 60, 29, 61, 30, 62, 31, 63);
        }
#else
            get;
        } = Vector256.Create((byte)16, 48, 17, 49, 18, 50, 19, 51, 20, 52, 21, 53, 22, 54, 23, 55, 24, 56, 25, 57, 26, 58, 27, 59, 28, 60, 29, 61, 30, 62, 31, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt16 - The index of data0.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup2Zip_ShuffleX2_UInt16_Data0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)0, 16, 1, 17, 2, 18, 3, 19, 4, 20, 5, 21, 6, 22, 7, 23);
        }
#else
            get;
        } = Vector256.Create((ushort)0, 16, 1, 17, 2, 18, 3, 19, 4, 20, 5, 21, 6, 22, 7, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt16 - The index of data1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup2Zip_ShuffleX2_UInt16_Data1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)8, 24, 9, 25, 10, 26, 11, 27, 12, 28, 13, 29, 14, 30, 15, 31);
        }
#else
            get;
        } = Vector256.Create((ushort)8, 24, 9, 25, 10, 26, 11, 27, 12, 28, 13, 29, 14, 30, 15, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt32 - The index of data0.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup2Zip_ShuffleX2_UInt32_Data0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)0, 8, 1, 9, 2, 10, 3, 11);
        }
#else
            get;
        } = Vector256.Create((uint)0, 8, 1, 9, 2, 10, 3, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt32 - The index of data1.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup2Zip_ShuffleX2_UInt32_Data1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)4, 12, 5, 13, 6, 14, 7, 15);
        }
#else
            get;
        } = Vector256.Create((uint)4, 12, 5, 13, 6, 14, 7, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt64 - The index of data0.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup2Zip_ShuffleX2_UInt64_Data0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)0, 4, 1, 5);
        }
#else
            get;
        } = Vector256.Create((ulong)0, 4, 1, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt64 - The index of data1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup2Zip_ShuffleX2_UInt64_Data1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)2, 6, 3, 7);
        }
#else
            get;
        } = Vector256.Create((ulong)2, 6, 3, 7);
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 0.</summary>
        public static Vector256<byte> YGroup3ToGroup4_Shuffle_Byte_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10, 11, 11, 12, 13, 14, 14, 15, 16, 17, 17, 18, 19, 20, 20, 21, 22, 23, 23);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10, 11, 11, 12, 13, 14, 14, 15, 16, 17, 17, 18, 19, 20, 20, 21, 22, 23, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 0 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup3ToGroup4_Shuffle_Byte_0_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10, 11, 11, 0, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10, 11, 11);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10, 11, 11, 0, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10, 11, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 1.</summary>
        public static Vector256<byte> YGroup3ToGroup4_Shuffle_Byte_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)24, 25, 26, 26, 27, 28, 29, 29, 30, 31, 32, 32, 33, 34, 35, 35, 36, 37, 38, 38, 39, 40, 41, 41, 42, 43, 44, 44, 45, 46, 47, 47);
        }
#else
            get;
        } = Vector256.Create((byte)24, 25, 26, 26, 27, 28, 29, 29, 30, 31, 32, 32, 33, 34, 35, 35, 36, 37, 38, 38, 39, 40, 41, 41, 42, 43, 44, 44, 45, 46, 47, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 1 - Sub part0.</summary>
        public static Vector256<byte> YGroup3ToGroup4_Shuffle_Byte_1A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)24, 25, 26, 26, 27, 28, 29, 29, 30, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)24, 25, 26, 26, 27, 28, 29, 29, 30, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 1 - Sub part1.</summary>
        public static Vector256<byte> YGroup3ToGroup4_Shuffle_Byte_1B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 1, 2, 3, 3, 4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15, 15).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 1, 2, 3, 3, 4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 1 - Sub part0 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup3ToGroup4_Shuffle_Byte_1A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)12, 13, 14, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)12, 13, 14, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 1 - Sub part1 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup3ToGroup4_Shuffle_Byte_1B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, 0, 1, 1, 2, 3, 4, 4, 5, 6, 7, 7, -1, -1, -1, -1, -1, 0, 1, 1, 2, 3, 4, 4, 5, 6, 7, 7).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, 0, 1, 1, 2, 3, 4, 4, 5, 6, 7, 7, -1, -1, -1, -1, -1, 0, 1, 1, 2, 3, 4, 4, 5, 6, 7, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 2.</summary>
        public static Vector256<byte> YGroup3ToGroup4_Shuffle_Byte_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)16, 17, 18, 18, 19, 20, 21, 21, 22, 23, 24, 24, 25, 26, 27, 27, 28, 29, 30, 30, 31, 32, 33, 33, 34, 35, 36, 36, 37, 38, 39, 39);
        }
#else
            get;
        } = Vector256.Create((byte)16, 17, 18, 18, 19, 20, 21, 21, 22, 23, 24, 24, 25, 26, 27, 27, 28, 29, 30, 30, 31, 32, 33, 33, 34, 35, 36, 36, 37, 38, 39, 39);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 2 - Sub part0.</summary>
        public static Vector256<byte> YGroup3ToGroup4_Shuffle_Byte_2A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)16, 17, 18, 18, 19, 20, 21, 21, 22, 23, 24, 24, 25, 26, 27, 27, 28, 29, 30, 30, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)16, 17, 18, 18, 19, 20, 21, 21, 22, 23, 24, 24, 25, 26, 27, 27, 28, 29, 30, 30, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 2 - Sub part1.</summary>
        public static Vector256<byte> YGroup3ToGroup4_Shuffle_Byte_2B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 1, 2, 3, 4, 4, 5, 6, 7, 7).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 1, 2, 3, 4, 4, 5, 6, 7, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 2 - Sub part0 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup3ToGroup4_Shuffle_Byte_2A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)8, 9, 10, 10, 11, 12, 13, 13, 14, 15, -1, -1, -1, -1, -1, -1, 8, 9, 10, 10, 11, 12, 13, 13, 14, 15, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)8, 9, 10, 10, 11, 12, 13, 13, 14, 15, -1, -1, -1, -1, -1, -1, 8, 9, 10, 10, 11, 12, 13, 13, 14, 15, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 2 - Sub part1 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup3ToGroup4_Shuffle_Byte_2B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 1, 2, 3, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 1, 2, 3, 3).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 1, 2, 3, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 1, 2, 3, 3).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 3.</summary>
        public static Vector256<byte> YGroup3ToGroup4_Shuffle_Byte_3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)8, 9, 10, 10, 11, 12, 13, 13, 14, 15, 16, 16, 17, 18, 19, 19, 20, 21, 22, 22, 23, 24, 25, 25, 26, 27, 28, 28, 29, 30, 31, 31);
        }
#else
            get;
        } = Vector256.Create((byte)8, 9, 10, 10, 11, 12, 13, 13, 14, 15, 16, 16, 17, 18, 19, 19, 20, 21, 22, 22, 23, 24, 25, 25, 26, 27, 28, 28, 29, 30, 31, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 3 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup3ToGroup4_Shuffle_Byte_3_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15, 15, 4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15, 15);
        }
#else
            get;
        } = Vector256.Create((byte)4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15, 15, 4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt16 - The index of item 0.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup3ToGroup4_Shuffle_UInt16_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)0, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10, 11, 11);
        }
#else
            get;
        } = Vector256.Create((ushort)0, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10, 11, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt16 - The index of item 1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup3ToGroup4_Shuffle_UInt16_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)12, 13, 14, 14, 15, 16, 17, 17, 18, 19, 20, 20, 21, 22, 23, 23);
        }
#else
            get;
        } = Vector256.Create((ushort)12, 13, 14, 14, 15, 16, 17, 17, 18, 19, 20, 20, 21, 22, 23, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt16 - The index of item 2.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup3ToGroup4_Shuffle_UInt16_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)8, 9, 10, 10, 11, 12, 13, 13, 14, 15, 16, 16, 17, 18, 19, 19);
        }
#else
            get;
        } = Vector256.Create((ushort)8, 9, 10, 10, 11, 12, 13, 13, 14, 15, 16, 16, 17, 18, 19, 19);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt16 - The index of item 3.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup3ToGroup4_Shuffle_UInt16_3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15, 15);
        }
#else
            get;
        } = Vector256.Create((ushort)4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt32 - The index of item 0.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup3ToGroup4_Shuffle_UInt32_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)0, 1, 2, 2, 3, 4, 5, 5);
        }
#else
            get;
        } = Vector256.Create((uint)0, 1, 2, 2, 3, 4, 5, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt32 - The index of item 1.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup3ToGroup4_Shuffle_UInt32_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)6, 7, 8, 8, 9, 10, 11, 11);
        }
#else
            get;
        } = Vector256.Create((uint)6, 7, 8, 8, 9, 10, 11, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt32 - The index of item 2.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup3ToGroup4_Shuffle_UInt32_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)4, 5, 6, 6, 7, 8, 9, 9);
        }
#else
            get;
        } = Vector256.Create((uint)4, 5, 6, 6, 7, 8, 9, 9);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt32 - The index of item 3.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup3ToGroup4_Shuffle_UInt32_3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)2, 3, 4, 4, 5, 6, 7, 7);
        }
#else
            get;
        } = Vector256.Create((uint)2, 3, 4, 4, 5, 6, 7, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt64 - The index of item 0.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup3ToGroup4_Shuffle_UInt64_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)0, 1, 2, 2);
        }
#else
            get;
        } = Vector256.Create((ulong)0, 1, 2, 2);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt64 - The index of item 1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup3ToGroup4_Shuffle_UInt64_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)3, 4, 5, 5);
        }
#else
            get;
        } = Vector256.Create((ulong)3, 4, 5, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt64 - The index of item 2.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup3ToGroup4_Shuffle_UInt64_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)2, 3, 4, 4);
        }
#else
            get;
        } = Vector256.Create((ulong)2, 3, 4, 4);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt64 - The index of item 3.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup3ToGroup4_Shuffle_UInt64_3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)1, 2, 3, 3);
        }
#else
            get;
        } = Vector256.Create((ulong)1, 2, 3, 3);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 0.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 3, 4, 5, 4, 5, 6, 7, 8, 9, 10, 11, 10, 11, 12, 13, 14, 15, 16, 17, 16, 17, 18, 19, 20, 21, 22, 23, 22, 23);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 3, 4, 5, 4, 5, 6, 7, 8, 9, 10, 11, 10, 11, 12, 13, 14, 15, 16, 17, 16, 17, 18, 19, 20, 21, 22, 23, 22, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 0 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_0_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 3, 4, 5, 4, 5, 6, 7, 8, 9, 10, 11, 10, 11, 0, 1, 2, 3, 4, 5, 4, 5, 6, 7, 8, 9, 10, 11, 10, 11);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 3, 4, 5, 4, 5, 6, 7, 8, 9, 10, 11, 10, 11, 0, 1, 2, 3, 4, 5, 4, 5, 6, 7, 8, 9, 10, 11, 10, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 1.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)24, 25, 26, 27, 28, 29, 28, 29, 30, 31, 32, 33, 34, 35, 34, 35, 36, 37, 38, 39, 40, 41, 40, 41, 42, 43, 44, 45, 46, 47, 46, 47);
        }
#else
            get;
        } = Vector256.Create((byte)24, 25, 26, 27, 28, 29, 28, 29, 30, 31, 32, 33, 34, 35, 34, 35, 36, 37, 38, 39, 40, 41, 40, 41, 42, 43, 44, 45, 46, 47, 46, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 1 - Sub part0.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_1A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)24, 25, 26, 27, 28, 29, 28, 29, 30, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)24, 25, 26, 27, 28, 29, 28, 29, 30, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 1 - Sub part1.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_1B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 2, 3, 4, 5, 6, 7, 8, 9, 8, 9, 10, 11, 12, 13, 14, 15, 14, 15).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 2, 3, 4, 5, 6, 7, 8, 9, 8, 9, 10, 11, 12, 13, 14, 15, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 1 - Sub part0 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_1A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 1 - Sub part1 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_1B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, 0, 1, 0, 1, 2, 3, 4, 5, 6, 7, 6, 7, -1, -1, -1, -1, 0, 1, 0, 1, 2, 3, 4, 5, 6, 7, 6, 7).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, 0, 1, 0, 1, 2, 3, 4, 5, 6, 7, 6, 7, -1, -1, -1, -1, 0, 1, 0, 1, 2, 3, 4, 5, 6, 7, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 2.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)16, 17, 18, 19, 20, 21, 20, 21, 22, 23, 24, 25, 26, 27, 26, 27, 28, 29, 30, 31, 32, 33, 32, 33, 34, 35, 36, 37, 38, 39, 38, 39);
        }
#else
            get;
        } = Vector256.Create((byte)16, 17, 18, 19, 20, 21, 20, 21, 22, 23, 24, 25, 26, 27, 26, 27, 28, 29, 30, 31, 32, 33, 32, 33, 34, 35, 36, 37, 38, 39, 38, 39);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 2 - Sub part0.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_2A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)16, 17, 18, 19, 20, 21, 20, 21, 22, 23, 24, 25, 26, 27, 26, 27, 28, 29, 30, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)16, 17, 18, 19, 20, 21, 20, 21, 22, 23, 24, 25, 26, 27, 26, 27, 28, 29, 30, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 2 - Sub part1.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_2B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 0, 1, 2, 3, 4, 5, 6, 7, 6, 7).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 0, 1, 2, 3, 4, 5, 6, 7, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 2 - Sub part0 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_2A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)8, 9, 10, 11, 12, 13, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)8, 9, 10, 11, 12, 13, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 2 - Sub part1 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_2B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 2, 3).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 2, 3).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 3.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)8, 9, 10, 11, 12, 13, 12, 13, 14, 15, 16, 17, 18, 19, 18, 19, 20, 21, 22, 23, 24, 25, 24, 25, 26, 27, 28, 29, 30, 31, 30, 31);
        }
#else
            get;
        } = Vector256.Create((byte)8, 9, 10, 11, 12, 13, 12, 13, 14, 15, 16, 17, 18, 19, 18, 19, 20, 21, 22, 23, 24, 25, 24, 25, 26, 27, 28, 29, 30, 31, 30, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 3 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_3_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)4, 5, 6, 7, 8, 9, 8, 9, 10, 11, 12, 13, 14, 15, 14, 15, 4, 5, 6, 7, 8, 9, 8, 9, 10, 11, 12, 13, 14, 15, 14, 15);
        }
#else
            get;
        } = Vector256.Create((byte)4, 5, 6, 7, 8, 9, 8, 9, 10, 11, 12, 13, 14, 15, 14, 15, 4, 5, 6, 7, 8, 9, 8, 9, 10, 11, 12, 13, 14, 15, 14, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 0.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 20, 21, 22, 23);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 20, 21, 22, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 0 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_0_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 1.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 44, 45, 46, 47);
        }
#else
            get;
        } = Vector256.Create((byte)24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 44, 45, 46, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 1 - Sub part0.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_1A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)24, 25, 26, 27, 28, 29, 30, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)24, 25, 26, 27, 28, 29, 30, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 1 - Sub part1.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_1B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 1 - Sub part0 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_1A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 1 - Sub part1 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_1B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 4, 5, 6, 7, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 4, 5, 6, 7, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 2.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 36, 37, 38, 39);
        }
#else
            get;
        } = Vector256.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 36, 37, 38, 39);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 2 - Sub part0.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_2A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 24, 25, 26, 27, 28, 29, 30, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 24, 25, 26, 27, 28, 29, 30, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 2 - Sub part1.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_2B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 2 - Sub part0 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_2A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 2 - Sub part1 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_2B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 0, 1, 2, 3).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 0, 1, 2, 3).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 3.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 28, 29, 30, 31);
        }
#else
            get;
        } = Vector256.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 28, 29, 30, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 3 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_3_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15);
        }
#else
            get;
        } = Vector256.Create((byte)4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 0.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 16, 17, 18, 19, 20, 21, 22, 23);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 16, 17, 18, 19, 20, 21, 22, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 0 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_0_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 1.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 40, 41, 42, 43, 44, 45, 46, 47);
        }
#else
            get;
        } = Vector256.Create((byte)24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 40, 41, 42, 43, 44, 45, 46, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 1 - Sub part0.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_1A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)24, 25, 26, 27, 28, 29, 30, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)24, 25, 26, 27, 28, 29, 30, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 1 - Sub part1.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_1B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 1 - Sub part0 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_1A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 1 - Sub part1 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_1B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 2.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 32, 33, 34, 35, 36, 37, 38, 39);
        }
#else
            get;
        } = Vector256.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 32, 33, 34, 35, 36, 37, 38, 39);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 2 - Sub part0.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_2A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 2 - Sub part1.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_2B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 2 - Sub part0 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_2A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 2 - Sub part1 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_2B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 3.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 24, 25, 26, 27, 28, 29, 30, 31);
        }
#else
            get;
        } = Vector256.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 24, 25, 26, 27, 28, 29, 30, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 3 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_3_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15);
        }
#else
            get;
        } = Vector256.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15);
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of X.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45, 48, 51, 54, 57, 60, 63, 66, 69, 72, 75, 78, 81, 84, 87, 90, 93);
        }
#else
            get;
        } = Vector256.Create((byte)0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45, 48, 51, 54, 57, 60, 63, 66, 69, 72, 75, 78, 81, 84, 87, 90, 93);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of X - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_X_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 3, 6, 9, 12, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 3, 6, 9, 12, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 3, 6, 9, 12, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 3, 6, 9, 12, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of X - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_X_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, 2, 5, 8, 11, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 5, 8, 11, 14, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, 2, 5, 8, 11, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 5, 8, 11, 14, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of X - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_X_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 7, 10, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 7, 10, 13).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 7, 10, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 7, 10, 13).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of X - Sub part2 combine 0|1.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 2, 5, 8, 11, 14, 17, 20, 23, 26, 29);
        }
#else
            get;
        } = Vector256.Create((byte)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 2, 5, 8, 11, 14, 17, 20, 23, 26, 29);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Y.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46, 49, 52, 55, 58, 61, 64, 67, 70, 73, 76, 79, 82, 85, 88, 91, 94);
        }
#else
            get;
        } = Vector256.Create((byte)1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46, 49, 52, 55, 58, 61, 64, 67, 70, 73, 76, 79, 82, 85, 88, 91, 94);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Y - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_Y_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)1, 4, 7, 10, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 7, 10, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)1, 4, 7, 10, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 7, 10, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Y - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_Y_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, 0, 3, 6, 9, 12, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 3, 6, 9, 12, 15, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, 0, 3, 6, 9, 12, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 3, 6, 9, 12, 15, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Y - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_Y_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 5, 8, 11, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 5, 8, 11, 14).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 5, 8, 11, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 5, 8, 11, 14).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Y - Sub part2 combine 0|1.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30);
        }
#else
            get;
        } = Vector256.Create((byte)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Z.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38, 41, 44, 47, 50, 53, 56, 59, 62, 65, 68, 71, 74, 77, 80, 83, 86, 89, 92, 95);
        }
#else
            get;
        } = Vector256.Create((byte)2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38, 41, 44, 47, 50, 53, 56, 59, 62, 65, 68, 71, 74, 77, 80, 83, 86, 89, 92, 95);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Z - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_Z_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)2, 5, 8, 11, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 5, 8, 11, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)2, 5, 8, 11, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 5, 8, 11, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Z - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_Z_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, 1, 4, 7, 10, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 7, 10, 13, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, 1, 4, 7, 10, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 7, 10, 13, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Z - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_Z_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 3, 6, 9, 12, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 3, 6, 9, 12, 15).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 3, 6, 9, 12, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 3, 6, 9, 12, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Z - Sub part2 combine 0|1.</summary>
        public static Vector256<byte> YGroup3Unzip_Shuffle_Byte_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31);
        }
#else
            get;
        } = Vector256.Create((byte)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt16 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup3Unzip_Shuffle_UInt16_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45);
        }
#else
            get;
        } = Vector256.Create((ushort)0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt16 - The index of X - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup3Unzip_Shuffle_UInt16_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 1, 4, 7, 10, 13);
        }
#else
            get;
        } = Vector256.Create((ushort)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 1, 4, 7, 10, 13);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt16 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup3Unzip_Shuffle_UInt16_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46);
        }
#else
            get;
        } = Vector256.Create((ushort)1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt16 - The index of Y - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup3Unzip_Shuffle_UInt16_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 2, 5, 8, 11, 14);
        }
#else
            get;
        } = Vector256.Create((ushort)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 2, 5, 8, 11, 14);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt16 - The index of Z.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup3Unzip_Shuffle_UInt16_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38, 41, 44, 47);
        }
#else
            get;
        } = Vector256.Create((ushort)2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38, 41, 44, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt16 - The index of Z - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup3Unzip_Shuffle_UInt16_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 0, 3, 6, 9, 12, 15);
        }
#else
            get;
        } = Vector256.Create((ushort)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 0, 3, 6, 9, 12, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt32 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup3Unzip_Shuffle_UInt32_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)0, 3, 6, 9, 12, 15, 18, 21);
        }
#else
            get;
        } = Vector256.Create((uint)0, 3, 6, 9, 12, 15, 18, 21);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt32 - The index of X - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup3Unzip_Shuffle_UInt32_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)8, 9, 10, 11, 12, 13, 2, 5);
        }
#else
            get;
        } = Vector256.Create((uint)8, 9, 10, 11, 12, 13, 2, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt32 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup3Unzip_Shuffle_UInt32_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)1, 4, 7, 10, 13, 16, 19, 22);
        }
#else
            get;
        } = Vector256.Create((uint)1, 4, 7, 10, 13, 16, 19, 22);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt32 - The index of Y - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup3Unzip_Shuffle_UInt32_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)8, 9, 10, 11, 12, 0, 3, 6);
        }
#else
            get;
        } = Vector256.Create((uint)8, 9, 10, 11, 12, 0, 3, 6);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt32 - The index of Z.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup3Unzip_Shuffle_UInt32_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)2, 5, 8, 11, 14, 17, 20, 23);
        }
#else
            get;
        } = Vector256.Create((uint)2, 5, 8, 11, 14, 17, 20, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt32 - The index of Z - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup3Unzip_Shuffle_UInt32_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)8, 9, 10, 11, 12, 1, 4, 7);
        }
#else
            get;
        } = Vector256.Create((uint)8, 9, 10, 11, 12, 1, 4, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt64 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup3Unzip_Shuffle_UInt64_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)0, 3, 6, 9);
        }
#else
            get;
        } = Vector256.Create((ulong)0, 3, 6, 9);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt64 - The index of X - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup3Unzip_Shuffle_UInt64_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)4, 5, 6, 1);
        }
#else
            get;
        } = Vector256.Create((ulong)4, 5, 6, 1);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt64 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup3Unzip_Shuffle_UInt64_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)1, 4, 7, 10);
        }
#else
            get;
        } = Vector256.Create((ulong)1, 4, 7, 10);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt64 - The index of Y - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup3Unzip_Shuffle_UInt64_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)4, 5, 6, 2);
        }
#else
            get;
        } = Vector256.Create((ulong)4, 5, 6, 2);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt64 - The index of Z.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup3Unzip_Shuffle_UInt64_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)2, 5, 8, 11);
        }
#else
            get;
        } = Vector256.Create((ulong)2, 5, 8, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt64 - The index of Z - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup3Unzip_Shuffle_UInt64_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)4, 5, 0, 3);
        }
#else
            get;
        } = Vector256.Create((ulong)4, 5, 0, 3);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of X.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt16_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 6, 7, 12, 13, 18, 19, 24, 25, 30, 31, 36, 37, 42, 43, 48, 49, 54, 55, 60, 61, 66, 67, 72, 73, 78, 79, 84, 85, 90, 91);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 6, 7, 12, 13, 18, 19, 24, 25, 30, 31, 36, 37, 42, 43, 48, 49, 54, 55, 60, 61, 66, 67, 72, 73, 78, 79, 84, 85, 90, 91);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of X - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt16_X_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 1, 6, 7, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 6, 7, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 1, 6, 7, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 6, 7, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of X - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt16_X_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, 2, 3, 8, 9, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 3, 8, 9, 14, 15, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, 2, 3, 8, 9, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 3, 8, 9, 14, 15, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of X - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt16_X_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 10, 11).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 10, 11).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of Y.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt16_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)2, 3, 8, 9, 14, 15, 20, 21, 26, 27, 32, 33, 38, 39, 44, 45, 50, 51, 56, 57, 62, 63, 68, 69, 74, 75, 80, 81, 86, 87, 92, 93);
        }
#else
            get;
        } = Vector256.Create((byte)2, 3, 8, 9, 14, 15, 20, 21, 26, 27, 32, 33, 38, 39, 44, 45, 50, 51, 56, 57, 62, 63, 68, 69, 74, 75, 80, 81, 86, 87, 92, 93);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of Y - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt16_Y_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)2, 3, 8, 9, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 3, 8, 9, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)2, 3, 8, 9, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 3, 8, 9, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of Y - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt16_Y_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, 4, 5, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 10, 11, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, 4, 5, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 10, 11, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of Y - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt16_Y_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 6, 7, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 6, 7, 12, 13).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 6, 7, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 6, 7, 12, 13).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of Z.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt16_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)4, 5, 10, 11, 16, 17, 22, 23, 28, 29, 34, 35, 40, 41, 46, 47, 52, 53, 58, 59, 64, 65, 70, 71, 76, 77, 82, 83, 88, 89, 94, 95);
        }
#else
            get;
        } = Vector256.Create((byte)4, 5, 10, 11, 16, 17, 22, 23, 28, 29, 34, 35, 40, 41, 46, 47, 52, 53, 58, 59, 64, 65, 70, 71, 76, 77, 82, 83, 88, 89, 94, 95);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of Z - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt16_Z_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)4, 5, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)4, 5, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of Z - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt16_Z_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, 0, 1, 6, 7, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 6, 7, 12, 13, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, 0, 1, 6, 7, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 6, 7, 12, 13, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of Z - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt16_Z_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 3, 8, 9, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 3, 8, 9, 14, 15).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 3, 8, 9, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 3, 8, 9, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of X.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt32_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 3, 12, 13, 14, 15, 24, 25, 26, 27, 36, 37, 38, 39, 48, 49, 50, 51, 60, 61, 62, 63, 72, 73, 74, 75, 84, 85, 86, 87);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 3, 12, 13, 14, 15, 24, 25, 26, 27, 36, 37, 38, 39, 48, 49, 50, 51, 60, 61, 62, 63, 72, 73, 74, 75, 84, 85, 86, 87);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of X - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt32_X_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 1, 2, 3, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 1, 2, 3, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of X - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt32_X_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of X - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt32_X_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of Y.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt32_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)4, 5, 6, 7, 16, 17, 18, 19, 28, 29, 30, 31, 40, 41, 42, 43, 52, 53, 54, 55, 64, 65, 66, 67, 76, 77, 78, 79, 88, 89, 90, 91);
        }
#else
            get;
        } = Vector256.Create((byte)4, 5, 6, 7, 16, 17, 18, 19, 28, 29, 30, 31, 40, 41, 42, 43, 52, 53, 54, 55, 64, 65, 66, 67, 76, 77, 78, 79, 88, 89, 90, 91);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of Y - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt32_Y_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of Y - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt32_Y_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 12, 13, 14, 15, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 12, 13, 14, 15, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of Y - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt32_Y_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of Z.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt32_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)8, 9, 10, 11, 20, 21, 22, 23, 32, 33, 34, 35, 44, 45, 46, 47, 56, 57, 58, 59, 68, 69, 70, 71, 80, 81, 82, 83, 92, 93, 94, 95);
        }
#else
            get;
        } = Vector256.Create((byte)8, 9, 10, 11, 20, 21, 22, 23, 32, 33, 34, 35, 44, 45, 46, 47, 56, 57, 58, 59, 68, 69, 70, 71, 80, 81, 82, 83, 92, 93, 94, 95);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of Z - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt32_Z_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of Z - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt32_Z_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of Z - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt32_Z_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of X.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt64_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 24, 25, 26, 27, 28, 29, 30, 31, 48, 49, 50, 51, 52, 53, 54, 55, 72, 73, 74, 75, 76, 77, 78, 79);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 24, 25, 26, 27, 28, 29, 30, 31, 48, 49, 50, 51, 52, 53, 54, 55, 72, 73, 74, 75, 76, 77, 78, 79);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of X - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt64_X_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of X - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt64_X_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of X - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt64_X_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Y.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 32, 33, 34, 35, 36, 37, 38, 39, 56, 57, 58, 59, 60, 61, 62, 63, 80, 81, 82, 83, 84, 85, 86, 87);
        }
#else
            get;
        } = Vector256.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 32, 33, 34, 35, 36, 37, 38, 39, 56, 57, 58, 59, 60, 61, 62, 63, 80, 81, 82, 83, 84, 85, 86, 87);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Y - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Y_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Y - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Y_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Y - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Y_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Z.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 40, 41, 42, 43, 44, 45, 46, 47, 64, 65, 66, 67, 68, 69, 70, 71, 88, 89, 90, 91, 92, 93, 94, 95);
        }
#else
            get;
        } = Vector256.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 40, 41, 42, 43, 44, 45, 46, 47, 64, 65, 66, 67, 68, 69, 70, 71, 88, 89, 90, 91, 92, 93, 94, 95);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Z - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Z_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Z - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Z_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Z - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Z_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup3Zip - Shuffle - Byte - The index of X.</summary>
        public static Vector256<byte> YGroup3Zip_Shuffle_Byte_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 32, 64, 1, 33, 65, 2, 34, 66, 3, 35, 67, 4, 36, 68, 5, 37, 69, 6, 38, 70, 7, 39, 71, 8, 40, 72, 9, 41, 73, 10, 42);
        }
#else
            get;
        } = Vector256.Create((byte)0, 32, 64, 1, 33, 65, 2, 34, 66, 3, 35, 67, 4, 36, 68, 5, 37, 69, 6, 38, 70, 7, 39, 71, 8, 40, 72, 9, 41, 73, 10, 42);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of X - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Zip_Shuffle_Byte_X_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, -1, -1, 1, -1, -1, 2, -1, -1, 3, -1, -1, 4, -1, -1, 5, 0, -1, -1, 1, -1, -1, 2, -1, -1, 3, -1, -1, 4, -1, -1, 5).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, -1, -1, 1, -1, -1, 2, -1, -1, 3, -1, -1, 4, -1, -1, 5, 0, -1, -1, 1, -1, -1, 2, -1, -1, 3, -1, -1, 4, -1, -1, 5).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of X - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Zip_Shuffle_Byte_X_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, 0, -1, -1, 1, -1, -1, 2, -1, -1, 3, -1, -1, 4, -1, -1, -1, 0, -1, -1, 1, -1, -1, 2, -1, -1, 3, -1, -1, 4, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, 0, -1, -1, 1, -1, -1, 2, -1, -1, 3, -1, -1, 4, -1, -1, -1, 0, -1, -1, 1, -1, -1, 2, -1, -1, 3, -1, -1, 4, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of X - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Zip_Shuffle_Byte_X_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, 0, -1, -1, 1, -1, -1, 2, -1, -1, 3, -1, -1, 4, -1, -1, -1, 0, -1, -1, 1, -1, -1, 2, -1, -1, 3, -1, -1, 4, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, 0, -1, -1, 1, -1, -1, 2, -1, -1, 3, -1, -1, 4, -1, -1, -1, 0, -1, -1, 1, -1, -1, 2, -1, -1, 3, -1, -1, 4, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of X - Sub part2 combine 0|1.</summary>
        public static Vector256<byte> YGroup3Zip_Shuffle_Byte_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)32, 33, 0, 35, 36, 1, 38, 39, 2, 41, 42, 3, 44, 45, 4, 47, 48, 5, 50, 51, 6, 53, 54, 7, 56, 57, 8, 59, 60, 9, 62, 63);
        }
#else
            get;
        } = Vector256.Create((byte)32, 33, 0, 35, 36, 1, 38, 39, 2, 41, 42, 3, 44, 45, 4, 47, 48, 5, 50, 51, 6, 53, 54, 7, 56, 57, 8, 59, 60, 9, 62, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of Y.</summary>
        public static Vector256<byte> YGroup3Zip_Shuffle_Byte_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)74, 11, 43, 75, 12, 44, 76, 13, 45, 77, 14, 46, 78, 15, 47, 79, 16, 48, 80, 17, 49, 81, 18, 50, 82, 19, 51, 83, 20, 52, 84, 21);
        }
#else
            get;
        } = Vector256.Create((byte)74, 11, 43, 75, 12, 44, 76, 13, 45, 77, 14, 46, 78, 15, 47, 79, 16, 48, 80, 17, 49, 81, 18, 50, 82, 19, 51, 83, 20, 52, 84, 21);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of Y - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Zip_Shuffle_Byte_Y_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, 6, -1, -1, 7, -1, -1, 8, -1, -1, 9, -1, -1, 10, -1, -1, -1, 6, -1, -1, 7, -1, -1, 8, -1, -1, 9, -1, -1, 10, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, 6, -1, -1, 7, -1, -1, 8, -1, -1, 9, -1, -1, 10, -1, -1, -1, 6, -1, -1, 7, -1, -1, 8, -1, -1, 9, -1, -1, 10, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of Y - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Zip_Shuffle_Byte_Y_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)5, -1, -1, 6, -1, -1, 7, -1, -1, 8, -1, -1, 9, -1, -1, 10, 5, -1, -1, 6, -1, -1, 7, -1, -1, 8, -1, -1, 9, -1, -1, 10).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)5, -1, -1, 6, -1, -1, 7, -1, -1, 8, -1, -1, 9, -1, -1, 10, 5, -1, -1, 6, -1, -1, 7, -1, -1, 8, -1, -1, 9, -1, -1, 10).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of Y - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Zip_Shuffle_Byte_Y_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, 5, -1, -1, 6, -1, -1, 7, -1, -1, 8, -1, -1, 9, -1, -1, -1, 5, -1, -1, 6, -1, -1, 7, -1, -1, 8, -1, -1, 9, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, 5, -1, -1, 6, -1, -1, 7, -1, -1, 8, -1, -1, 9, -1, -1, -1, 5, -1, -1, 6, -1, -1, 7, -1, -1, 8, -1, -1, 9, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of Y - Sub part2 combine 0|1.</summary>
        public static Vector256<byte> YGroup3Zip_Shuffle_Byte_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)10, 33, 34, 11, 36, 37, 12, 39, 40, 13, 42, 43, 14, 45, 46, 15, 48, 49, 16, 51, 52, 17, 54, 55, 18, 57, 58, 19, 60, 61, 20, 63);
        }
#else
            get;
        } = Vector256.Create((byte)10, 33, 34, 11, 36, 37, 12, 39, 40, 13, 42, 43, 14, 45, 46, 15, 48, 49, 16, 51, 52, 17, 54, 55, 18, 57, 58, 19, 60, 61, 20, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of Z.</summary>
        public static Vector256<byte> YGroup3Zip_Shuffle_Byte_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)53, 85, 22, 54, 86, 23, 55, 87, 24, 56, 88, 25, 57, 89, 26, 58, 90, 27, 59, 91, 28, 60, 92, 29, 61, 93, 30, 62, 94, 31, 63, 95);
        }
#else
            get;
        } = Vector256.Create((byte)53, 85, 22, 54, 86, 23, 55, 87, 24, 56, 88, 25, 57, 89, 26, 58, 90, 27, 59, 91, 28, 60, 92, 29, 61, 93, 30, 62, 94, 31, 63, 95);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of Z - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Zip_Shuffle_Byte_Z_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, 11, -1, -1, 12, -1, -1, 13, -1, -1, 14, -1, -1, 15, -1, -1, -1, 11, -1, -1, 12, -1, -1, 13, -1, -1, 14, -1, -1, 15, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, 11, -1, -1, 12, -1, -1, 13, -1, -1, 14, -1, -1, 15, -1, -1, -1, 11, -1, -1, 12, -1, -1, 13, -1, -1, 14, -1, -1, 15, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of Z - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Zip_Shuffle_Byte_Z_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, 11, -1, -1, 12, -1, -1, 13, -1, -1, 14, -1, -1, 15, -1, -1, -1, 11, -1, -1, 12, -1, -1, 13, -1, -1, 14, -1, -1, 15, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, 11, -1, -1, 12, -1, -1, 13, -1, -1, 14, -1, -1, 15, -1, -1, -1, 11, -1, -1, 12, -1, -1, 13, -1, -1, 14, -1, -1, 15, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of Z - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Zip_Shuffle_Byte_Z_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)10, -1, -1, 11, -1, -1, 12, -1, -1, 13, -1, -1, 14, -1, -1, 15, 10, -1, -1, 11, -1, -1, 12, -1, -1, 13, -1, -1, 14, -1, -1, 15).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)10, -1, -1, 11, -1, -1, 12, -1, -1, 13, -1, -1, 14, -1, -1, 15, 10, -1, -1, 11, -1, -1, 12, -1, -1, 13, -1, -1, 14, -1, -1, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of Z - Sub part2 combine 0|1.</summary>
        public static Vector256<byte> YGroup3Zip_Shuffle_Byte_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)32, 21, 34, 35, 22, 37, 38, 23, 40, 41, 24, 43, 44, 25, 46, 47, 26, 49, 50, 27, 52, 53, 28, 55, 56, 29, 58, 59, 30, 61, 62, 31);
        }
#else
            get;
        } = Vector256.Create((byte)32, 21, 34, 35, 22, 37, 38, 23, 40, 41, 24, 43, 44, 25, 46, 47, 26, 49, 50, 27, 52, 53, 28, 55, 56, 29, 58, 59, 30, 61, 62, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt16 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup3Zip_Shuffle_UInt16_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)0, 16, 32, 1, 17, 33, 2, 18, 34, 3, 19, 35, 4, 20, 36, 5);
        }
#else
            get;
        } = Vector256.Create((ushort)0, 16, 32, 1, 17, 33, 2, 18, 34, 3, 19, 35, 4, 20, 36, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt16 - The index of X - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup3Zip_Shuffle_UInt16_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)16, 17, 0, 19, 20, 1, 22, 23, 2, 25, 26, 3, 28, 29, 4, 31);
        }
#else
            get;
        } = Vector256.Create((ushort)16, 17, 0, 19, 20, 1, 22, 23, 2, 25, 26, 3, 28, 29, 4, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt16 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup3Zip_Shuffle_UInt16_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)21, 37, 6, 22, 38, 7, 23, 39, 8, 24, 40, 9, 25, 41, 10, 26);
        }
#else
            get;
        } = Vector256.Create((ushort)21, 37, 6, 22, 38, 7, 23, 39, 8, 24, 40, 9, 25, 41, 10, 26);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt16 - The index of Y - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup3Zip_Shuffle_UInt16_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)16, 5, 18, 19, 6, 21, 22, 7, 24, 25, 8, 27, 28, 9, 30, 31);
        }
#else
            get;
        } = Vector256.Create((ushort)16, 5, 18, 19, 6, 21, 22, 7, 24, 25, 8, 27, 28, 9, 30, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt16 - The index of Z.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup3Zip_Shuffle_UInt16_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)42, 11, 27, 43, 12, 28, 44, 13, 29, 45, 14, 30, 46, 15, 31, 47);
        }
#else
            get;
        } = Vector256.Create((ushort)42, 11, 27, 43, 12, 28, 44, 13, 29, 45, 14, 30, 46, 15, 31, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt16 - The index of Z - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup3Zip_Shuffle_UInt16_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)10, 17, 18, 11, 20, 21, 12, 23, 24, 13, 26, 27, 14, 29, 30, 15);
        }
#else
            get;
        } = Vector256.Create((ushort)10, 17, 18, 11, 20, 21, 12, 23, 24, 13, 26, 27, 14, 29, 30, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt32 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup3Zip_Shuffle_UInt32_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)0, 8, 16, 1, 9, 17, 2, 10);
        }
#else
            get;
        } = Vector256.Create((uint)0, 8, 16, 1, 9, 17, 2, 10);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt32 - The index of X - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup3Zip_Shuffle_UInt32_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)8, 9, 0, 11, 12, 1, 14, 15);
        }
#else
            get;
        } = Vector256.Create((uint)8, 9, 0, 11, 12, 1, 14, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt32 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup3Zip_Shuffle_UInt32_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)18, 3, 11, 19, 4, 12, 20, 5);
        }
#else
            get;
        } = Vector256.Create((uint)18, 3, 11, 19, 4, 12, 20, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt32 - The index of Y - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup3Zip_Shuffle_UInt32_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)2, 9, 10, 3, 12, 13, 4, 15);
        }
#else
            get;
        } = Vector256.Create((uint)2, 9, 10, 3, 12, 13, 4, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt32 - The index of Z.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup3Zip_Shuffle_UInt32_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)13, 21, 6, 14, 22, 7, 15, 23);
        }
#else
            get;
        } = Vector256.Create((uint)13, 21, 6, 14, 22, 7, 15, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt32 - The index of Z - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup3Zip_Shuffle_UInt32_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)8, 5, 10, 11, 6, 13, 14, 7);
        }
#else
            get;
        } = Vector256.Create((uint)8, 5, 10, 11, 6, 13, 14, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt64 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup3Zip_Shuffle_UInt64_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)0, 4, 8, 1);
        }
#else
            get;
        } = Vector256.Create((ulong)0, 4, 8, 1);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt64 - The index of X - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup3Zip_Shuffle_UInt64_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)4, 5, 0, 7);
        }
#else
            get;
        } = Vector256.Create((ulong)4, 5, 0, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt64 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup3Zip_Shuffle_UInt64_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)5, 9, 2, 6);
        }
#else
            get;
        } = Vector256.Create((ulong)5, 9, 2, 6);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt64 - The index of Y - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup3Zip_Shuffle_UInt64_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)4, 1, 6, 7);
        }
#else
            get;
        } = Vector256.Create((ulong)4, 1, 6, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt64 - The index of Z.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup3Zip_Shuffle_UInt64_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)10, 3, 7, 11);
        }
#else
            get;
        } = Vector256.Create((ulong)10, 3, 7, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt64 - The index of Z - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup3Zip_Shuffle_UInt64_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)2, 5, 6, 3);
        }
#else
            get;
        } = Vector256.Create((ulong)2, 5, 6, 3);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt16 - The index of X.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt16_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 32, 33, 64, 65, 2, 3, 34, 35, 66, 67, 4, 5, 36, 37, 68, 69, 6, 7, 38, 39, 70, 71, 8, 9, 40, 41, 72, 73, 10, 11);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 32, 33, 64, 65, 2, 3, 34, 35, 66, 67, 4, 5, 36, 37, 68, 69, 6, 7, 38, 39, 70, 71, 8, 9, 40, 41, 72, 73, 10, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt16 - The index of X - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt16_X_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 1, -1, -1, -1, -1, 2, 3, -1, -1, -1, -1, 4, 5, -1, -1, 0, 1, -1, -1, -1, -1, 2, 3, -1, -1, -1, -1, 4, 5, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 1, -1, -1, -1, -1, 2, 3, -1, -1, -1, -1, 4, 5, -1, -1, 0, 1, -1, -1, -1, -1, 2, 3, -1, -1, -1, -1, 4, 5, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt16 - The index of X - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt16_X_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, 0, 1, -1, -1, -1, -1, 2, 3, -1, -1, -1, -1, 4, 5, -1, -1, 0, 1, -1, -1, -1, -1, 2, 3, -1, -1, -1, -1, 4, 5).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, 0, 1, -1, -1, -1, -1, 2, 3, -1, -1, -1, -1, 4, 5, -1, -1, 0, 1, -1, -1, -1, -1, 2, 3, -1, -1, -1, -1, 4, 5).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt16 - The index of X - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt16_X_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, 0, 1, -1, -1, -1, -1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, -1, -1, -1, -1, 2, 3, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, 0, 1, -1, -1, -1, -1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, -1, -1, -1, -1, 2, 3, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt16 - The index of Y.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt16_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)42, 43, 74, 75, 12, 13, 44, 45, 76, 77, 14, 15, 46, 47, 78, 79, 16, 17, 48, 49, 80, 81, 18, 19, 50, 51, 82, 83, 20, 21, 52, 53);
        }
#else
            get;
        } = Vector256.Create((byte)42, 43, 74, 75, 12, 13, 44, 45, 76, 77, 14, 15, 46, 47, 78, 79, 16, 17, 48, 49, 80, 81, 18, 19, 50, 51, 82, 83, 20, 21, 52, 53);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt16 - The index of Y - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt16_Y_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, 6, 7, -1, -1, -1, -1, 8, 9, -1, -1, -1, -1, 10, 11, -1, -1, 6, 7, -1, -1, -1, -1, 8, 9, -1, -1, -1, -1, 10, 11).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, 6, 7, -1, -1, -1, -1, 8, 9, -1, -1, -1, -1, 10, 11, -1, -1, 6, 7, -1, -1, -1, -1, 8, 9, -1, -1, -1, -1, 10, 11).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt16 - The index of Y - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt16_Y_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, 6, 7, -1, -1, -1, -1, 8, 9, -1, -1, -1, -1, -1, -1, -1, -1, 6, 7, -1, -1, -1, -1, 8, 9, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, 6, 7, -1, -1, -1, -1, 8, 9, -1, -1, -1, -1, -1, -1, -1, -1, 6, 7, -1, -1, -1, -1, 8, 9, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt16 - The index of Y - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt16_Y_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)4, 5, -1, -1, -1, -1, 6, 7, -1, -1, -1, -1, 8, 9, -1, -1, 4, 5, -1, -1, -1, -1, 6, 7, -1, -1, -1, -1, 8, 9, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)4, 5, -1, -1, -1, -1, 6, 7, -1, -1, -1, -1, 8, 9, -1, -1, 4, 5, -1, -1, -1, -1, 6, 7, -1, -1, -1, -1, 8, 9, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt16 - The index of Z.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt16_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)84, 85, 22, 23, 54, 55, 86, 87, 24, 25, 56, 57, 88, 89, 26, 27, 58, 59, 90, 91, 28, 29, 60, 61, 92, 93, 30, 31, 62, 63, 94, 95);
        }
#else
            get;
        } = Vector256.Create((byte)84, 85, 22, 23, 54, 55, 86, 87, 24, 25, 56, 57, 88, 89, 26, 27, 58, 59, 90, 91, 28, 29, 60, 61, 92, 93, 30, 31, 62, 63, 94, 95);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt16 - The index of Z - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt16_Z_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, 12, 13, -1, -1, -1, -1, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, -1, -1, -1, -1, 14, 15, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, 12, 13, -1, -1, -1, -1, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, -1, -1, -1, -1, 14, 15, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt16 - The index of Z - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt16_Z_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)10, 11, -1, -1, -1, -1, 12, 13, -1, -1, -1, -1, 14, 15, -1, -1, 10, 11, -1, -1, -1, -1, 12, 13, -1, -1, -1, -1, 14, 15, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)10, 11, -1, -1, -1, -1, 12, 13, -1, -1, -1, -1, 14, 15, -1, -1, 10, 11, -1, -1, -1, -1, 12, 13, -1, -1, -1, -1, 14, 15, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt16 - The index of Z - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt16_Z_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, 10, 11, -1, -1, -1, -1, 12, 13, -1, -1, -1, -1, 14, 15, -1, -1, 10, 11, -1, -1, -1, -1, 12, 13, -1, -1, -1, -1, 14, 15).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, 10, 11, -1, -1, -1, -1, 12, 13, -1, -1, -1, -1, 14, 15, -1, -1, 10, 11, -1, -1, -1, -1, 12, 13, -1, -1, -1, -1, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt32 - The index of X.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt32_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 3, 32, 33, 34, 35, 64, 65, 66, 67, 4, 5, 6, 7, 36, 37, 38, 39, 68, 69, 70, 71, 8, 9, 10, 11, 40, 41, 42, 43);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 3, 32, 33, 34, 35, 64, 65, 66, 67, 4, 5, 6, 7, 36, 37, 38, 39, 68, 69, 70, 71, 8, 9, 10, 11, 40, 41, 42, 43);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt32 - The index of X - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt32_X_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt32 - The index of X - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt32_X_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt32 - The index of X - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt32_X_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt32 - The index of Y.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt32_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)72, 73, 74, 75, 12, 13, 14, 15, 44, 45, 46, 47, 76, 77, 78, 79, 16, 17, 18, 19, 48, 49, 50, 51, 80, 81, 82, 83, 20, 21, 22, 23);
        }
#else
            get;
        } = Vector256.Create((byte)72, 73, 74, 75, 12, 13, 14, 15, 44, 45, 46, 47, 76, 77, 78, 79, 16, 17, 18, 19, 48, 49, 50, 51, 80, 81, 82, 83, 20, 21, 22, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt32 - The index of Y - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt32_Y_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt32 - The index of Y - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt32_Y_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt32 - The index of Y - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt32_Y_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt32 - The index of Z.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt32_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)52, 53, 54, 55, 84, 85, 86, 87, 24, 25, 26, 27, 56, 57, 58, 59, 88, 89, 90, 91, 28, 29, 30, 31, 60, 61, 62, 63, 92, 93, 94, 95);
        }
#else
            get;
        } = Vector256.Create((byte)52, 53, 54, 55, 84, 85, 86, 87, 24, 25, 26, 27, 56, 57, 58, 59, 88, 89, 90, 91, 28, 29, 30, 31, 60, 61, 62, 63, 92, 93, 94, 95);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt32 - The index of Z - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt32_Z_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt32 - The index of Z - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt32_Z_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt32 - The index of Z - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt32_Z_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of X.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt64_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 32, 33, 34, 35, 36, 37, 38, 39, 64, 65, 66, 67, 68, 69, 70, 71, 8, 9, 10, 11, 12, 13, 14, 15);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 32, 33, 34, 35, 36, 37, 38, 39, 64, 65, 66, 67, 68, 69, 70, 71, 8, 9, 10, 11, 12, 13, 14, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of X - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt64_X_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of X - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt64_X_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of X - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt64_X_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of Y.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt64_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)40, 41, 42, 43, 44, 45, 46, 47, 72, 73, 74, 75, 76, 77, 78, 79, 16, 17, 18, 19, 20, 21, 22, 23, 48, 49, 50, 51, 52, 53, 54, 55);
        }
#else
            get;
        } = Vector256.Create((byte)40, 41, 42, 43, 44, 45, 46, 47, 72, 73, 74, 75, 76, 77, 78, 79, 16, 17, 18, 19, 20, 21, 22, 23, 48, 49, 50, 51, 52, 53, 54, 55);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of Y - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt64_Y_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of Y - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt64_Y_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of Y - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt64_Y_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of Z.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt64_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)80, 81, 82, 83, 84, 85, 86, 87, 24, 25, 26, 27, 28, 29, 30, 31, 56, 57, 58, 59, 60, 61, 62, 63, 88, 89, 90, 91, 92, 93, 94, 95);
        }
#else
            get;
        } = Vector256.Create((byte)80, 81, 82, 83, 84, 85, 86, 87, 24, 25, 26, 27, 28, 29, 30, 31, 56, 57, 58, 59, 60, 61, 62, 63, 88, 89, 90, 91, 92, 93, 94, 95);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of Z - Each128 sub part0.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt64_Z_Each128Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of Z - Each128 sub part1.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt64_Z_Each128Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of Z - Each128 sub part2.</summary>
        public static Vector256<byte> YGroup3Zip_ShuffleOnByte_UInt64_Z_Each128Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup4 - Mask of X,Y,Z (clear W) - Byte.</summary>
        public static Vector256<byte> YGroup4_MaskXYZ_Byte {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4 - Mask of X,Y,Z (clear W) - UInt16.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup4_MaskXYZ_UInt16 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((short)-1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0).AsUInt16();
        }
#else
            get;
        } = Vector256.Create((short)-1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0).AsUInt16();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4 - Mask of X,Y,Z (clear W) - UInt32.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup4_MaskXYZ_UInt32 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((int)-1, -1, -1, 0, -1, -1, -1, 0).AsUInt32();
        }
#else
            get;
        } = Vector256.Create((int)-1, -1, -1, 0, -1, -1, -1, 0).AsUInt32();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4 - Mask of X,Y,Z (clear W) - UInt64.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup4_MaskXYZ_UInt64 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((long)-1, -1, -1, 0).AsUInt64();
        }
#else
            get;
        } = Vector256.Create((long)-1, -1, -1, 0).AsUInt64();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4 - Mask of X,Y,Z (clear W) - UInt64 - Part 1 - Each 128 bits.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup4_MaskXYZ_UInt64_1_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((long)-1, 0, -1, 0).AsUInt64();
        }
#else
            get;
        } = Vector256.Create((long)-1, 0, -1, 0).AsUInt64();
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 0.</summary>
        public static Vector256<byte> YGroup4ToGroup3_Shuffle_Byte_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30, 32, 33, 34, 36, 37, 38, 40, 41);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30, 32, 33, 34, 36, 37, 38, 40, 41);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 0 - Sub part0.</summary>
        public static Vector256<byte> YGroup4ToGroup3_Shuffle_Byte_0A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 0 - Sub part1.</summary>
        public static Vector256<byte> YGroup4ToGroup3_Shuffle_Byte_0B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 0 - Sub part0 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup4ToGroup3_Shuffle_Byte_0A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 0 - Sub part1 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup4ToGroup3_Shuffle_Byte_0B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 1.</summary>
        public static Vector256<byte> YGroup4ToGroup3_Shuffle_Byte_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30, 32, 33, 34, 36, 37, 38, 40, 41, 42, 44, 45, 46, 48, 49, 50, 52);
        }
#else
            get;
        } = Vector256.Create((byte)10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30, 32, 33, 34, 36, 37, 38, 40, 41, 42, 44, 45, 46, 48, 49, 50, 52);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 1 - Sub part0.</summary>
        public static Vector256<byte> YGroup4ToGroup3_Shuffle_Byte_1A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 1 - Sub part1.</summary>
        public static Vector256<byte> YGroup4ToGroup3_Shuffle_Byte_1B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 1 - Sub part0 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup4ToGroup3_Shuffle_Byte_1A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, -1, -1, -1, -1, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, -1, -1, -1, -1, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 1 - Sub part1 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup4ToGroup3_Shuffle_Byte_1B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 2.</summary>
        public static Vector256<byte> YGroup4ToGroup3_Shuffle_Byte_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)21, 22, 24, 25, 26, 28, 29, 30, 32, 33, 34, 36, 37, 38, 40, 41, 42, 44, 45, 46, 48, 49, 50, 52, 53, 54, 56, 57, 58, 60, 61, 62);
        }
#else
            get;
        } = Vector256.Create((byte)21, 22, 24, 25, 26, 28, 29, 30, 32, 33, 34, 36, 37, 38, 40, 41, 42, 44, 45, 46, 48, 49, 50, 52, 53, 54, 56, 57, 58, 60, 61, 62);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 2 - Sub part0.</summary>
        public static Vector256<byte> YGroup4ToGroup3_Shuffle_Byte_2A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)21, 22, 24, 25, 26, 28, 29, 30, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)21, 22, 24, 25, 26, 28, 29, 30, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 2 - Sub part1.</summary>
        public static Vector256<byte> YGroup4ToGroup3_Shuffle_Byte_2B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 2 - Sub part0 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup4ToGroup3_Shuffle_Byte_2A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)10, 12, 13, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 10, 12, 13, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)10, 12, 13, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 10, 12, 13, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 2 - Sub part1 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup4ToGroup3_Shuffle_Byte_2B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - UInt16 - The index of item 0.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup4ToGroup3_Shuffle_UInt16_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20);
        }
#else
            get;
        } = Vector256.Create((ushort)0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - UInt16 - The index of item 1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup4ToGroup3_Shuffle_UInt16_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25);
        }
#else
            get;
        } = Vector256.Create((ushort)5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - UInt16 - The index of item 2.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup4ToGroup3_Shuffle_UInt16_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30);
        }
#else
            get;
        } = Vector256.Create((ushort)10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - UInt32 - The index of item 0.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup4ToGroup3_Shuffle_UInt32_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)0, 1, 2, 4, 5, 6, 8, 9);
        }
#else
            get;
        } = Vector256.Create((uint)0, 1, 2, 4, 5, 6, 8, 9);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - UInt32 - The index of item 1.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup4ToGroup3_Shuffle_UInt32_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)2, 4, 5, 6, 8, 9, 10, 12);
        }
#else
            get;
        } = Vector256.Create((uint)2, 4, 5, 6, 8, 9, 10, 12);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - UInt32 - The index of item 2.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup4ToGroup3_Shuffle_UInt32_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)5, 6, 8, 9, 10, 12, 13, 14);
        }
#else
            get;
        } = Vector256.Create((uint)5, 6, 8, 9, 10, 12, 13, 14);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - UInt64 - The index of item 0.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup4ToGroup3_Shuffle_UInt64_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)0, 1, 2, 4);
        }
#else
            get;
        } = Vector256.Create((ulong)0, 1, 2, 4);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - UInt64 - The index of item 1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup4ToGroup3_Shuffle_UInt64_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)1, 2, 4, 5);
        }
#else
            get;
        } = Vector256.Create((ulong)1, 2, 4, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - UInt64 - The index of item 2.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup4ToGroup3_Shuffle_UInt64_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)2, 4, 5, 6);
        }
#else
            get;
        } = Vector256.Create((ulong)2, 4, 5, 6);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 0.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, 16, 17, 18, 19, 20, 21, 24, 25, 26, 27, 28, 29, 32, 33, 34, 35, 36, 37, 40, 41);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, 16, 17, 18, 19, 20, 21, 24, 25, 26, 27, 28, 29, 32, 33, 34, 35, 36, 37, 40, 41);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 0 - Sub part0.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_0A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, 16, 17, 18, 19, 20, 21, 24, 25, 26, 27, 28, 29, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, 16, 17, 18, 19, 20, 21, 24, 25, 26, 27, 28, 29, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 0 - Sub part1.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_0B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 0 - Sub part0 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_0A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 0 - Sub part1 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_0B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 1.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)10, 11, 12, 13, 16, 17, 18, 19, 20, 21, 24, 25, 26, 27, 28, 29, 32, 33, 34, 35, 36, 37, 40, 41, 42, 43, 44, 45, 48, 49, 50, 51);
        }
#else
            get;
        } = Vector256.Create((byte)10, 11, 12, 13, 16, 17, 18, 19, 20, 21, 24, 25, 26, 27, 28, 29, 32, 33, 34, 35, 36, 37, 40, 41, 42, 43, 44, 45, 48, 49, 50, 51);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 1 - Sub part0.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_1A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)10, 11, 12, 13, 16, 17, 18, 19, 20, 21, 24, 25, 26, 27, 28, 29, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)10, 11, 12, 13, 16, 17, 18, 19, 20, 21, 24, 25, 26, 27, 28, 29, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 1 - Sub part1.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_1B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, 16, 17, 18, 19).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, 16, 17, 18, 19).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 1 - Sub part0 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_1A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 1 - Sub part1 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_1B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 2.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)20, 21, 24, 25, 26, 27, 28, 29, 32, 33, 34, 35, 36, 37, 40, 41, 42, 43, 44, 45, 48, 49, 50, 51, 52, 53, 56, 57, 58, 59, 60, 61);
        }
#else
            get;
        } = Vector256.Create((byte)20, 21, 24, 25, 26, 27, 28, 29, 32, 33, 34, 35, 36, 37, 40, 41, 42, 43, 44, 45, 48, 49, 50, 51, 52, 53, 56, 57, 58, 59, 60, 61);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 2 - Sub part0.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_2A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)20, 21, 24, 25, 26, 27, 28, 29, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)20, 21, 24, 25, 26, 27, 28, 29, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 2 - Sub part1.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_2B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, 16, 17, 18, 19, 20, 21, 24, 25, 26, 27, 28, 29).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, 16, 17, 18, 19, 20, 21, 24, 25, 26, 27, 28, 29).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 2 - Sub part0 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_2A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)10, 11, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 10, 11, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)10, 11, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 10, 11, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 2 - Sub part1 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_2B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 0.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 32, 33, 34, 35, 36, 37, 38, 39);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 32, 33, 34, 35, 36, 37, 38, 39);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 0 - Sub part0.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_0A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 0 - Sub part1.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_0B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 0 - Sub part0 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_0A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 0 - Sub part1 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_0B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 1.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)8, 9, 10, 11, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 48, 49, 50, 51);
        }
#else
            get;
        } = Vector256.Create((byte)8, 9, 10, 11, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 48, 49, 50, 51);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 1 - Sub part0.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_1A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)8, 9, 10, 11, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)8, 9, 10, 11, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 1 - Sub part1.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_1B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 16, 17, 18, 19).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 16, 17, 18, 19).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 1 - Sub part0 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_1A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 1 - Sub part1 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_1B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 2.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)20, 21, 22, 23, 24, 25, 26, 27, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59);
        }
#else
            get;
        } = Vector256.Create((byte)20, 21, 22, 23, 24, 25, 26, 27, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 2 - Sub part0.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_2A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)20, 21, 22, 23, 24, 25, 26, 27, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)20, 21, 22, 23, 24, 25, 26, 27, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 2 - Sub part1.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_2B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 2 - Sub part0 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_2A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 2 - Sub part1 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_2B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 0.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 32, 33, 34, 35, 36, 37, 38, 39);
        }
#else
            get;
        } = Vector256.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 32, 33, 34, 35, 36, 37, 38, 39);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 0 - Sub part0.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_0A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 0 - Sub part1.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_0B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 1.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47);
        }
#else
            get;
        } = Vector256.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 1 - Sub part0.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_1A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 1 - Sub part1.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_1B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 1 - Sub part0 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_1A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 1 - Sub part1 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_1B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 2.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55);
        }
#else
            get;
        } = Vector256.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 2 - Sub part0.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_2A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)16, 17, 18, 19, 20, 21, 22, 23, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)16, 17, 18, 19, 20, 21, 22, 23, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 2 - Sub part1.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_2B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 2 - Sub part0 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_2A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 2 - Sub part1 - Each 128 bits.</summary>
        public static Vector256<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_2B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector256.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup4Unzip - ShuffleX2 Longer - Byte - The index of X/Y.</summary>
        public static Vector256<byte> YGroup4Unzip_ShuffleX2Longer_Byte_XY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57, 61);
        }
#else
            get;
        } = Vector256.Create((byte)0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57, 61);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 Longer - Byte - The index of Z/W.</summary>
        public static Vector256<byte> YGroup4Unzip_ShuffleX2Longer_Byte_ZW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)2, 6, 10, 14, 18, 22, 26, 30, 34, 38, 42, 46, 50, 54, 58, 62, 3, 7, 11, 15, 19, 23, 27, 31, 35, 39, 43, 47, 51, 55, 59, 63);
        }
#else
            get;
        } = Vector256.Create((byte)2, 6, 10, 14, 18, 22, 26, 30, 34, 38, 42, 46, 50, 54, 58, 62, 3, 7, 11, 15, 19, 23, 27, 31, 35, 39, 43, 47, 51, 55, 59, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 Longer - UInt16 - The index of X/Y.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup4Unzip_ShuffleX2Longer_UInt16_XY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)0, 4, 8, 12, 16, 20, 24, 28, 1, 5, 9, 13, 17, 21, 25, 29);
        }
#else
            get;
        } = Vector256.Create((ushort)0, 4, 8, 12, 16, 20, 24, 28, 1, 5, 9, 13, 17, 21, 25, 29);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 Longer - UInt16 - The index of Z/W.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup4Unzip_ShuffleX2Longer_UInt16_ZW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)2, 6, 10, 14, 18, 22, 26, 30, 3, 7, 11, 15, 19, 23, 27, 31);
        }
#else
            get;
        } = Vector256.Create((ushort)2, 6, 10, 14, 18, 22, 26, 30, 3, 7, 11, 15, 19, 23, 27, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 Longer - UInt32 - The index of X/Y.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup4Unzip_ShuffleX2Longer_UInt32_XY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)0, 4, 8, 12, 1, 5, 9, 13);
        }
#else
            get;
        } = Vector256.Create((uint)0, 4, 8, 12, 1, 5, 9, 13);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 Longer - UInt32 - The index of Z/W.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup4Unzip_ShuffleX2Longer_UInt32_ZW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)2, 6, 10, 14, 3, 7, 11, 15);
        }
#else
            get;
        } = Vector256.Create((uint)2, 6, 10, 14, 3, 7, 11, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 Longer - UInt64 - The index of X/Y.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup4Unzip_ShuffleX2Longer_UInt64_XY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)0, 4, 1, 5);
        }
#else
            get;
        } = Vector256.Create((ulong)0, 4, 1, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 Longer - UInt64 - The index of Z/W.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup4Unzip_ShuffleX2Longer_UInt64_ZW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)2, 6, 3, 7);
        }
#else
            get;
        } = Vector256.Create((ulong)2, 6, 3, 7);
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup4Zip - ShuffleX2 Longer - Byte - The index of data0/data1.</summary>
        [CLSCompliant(false)]
        public static Vector256<byte> YGroup4Zip_ShuffleX2Longer_Byte_Data01 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)0, 16, 32, 48, 1, 17, 33, 49, 2, 18, 34, 50, 3, 19, 35, 51, 4, 20, 36, 52, 5, 21, 37, 53, 6, 22, 38, 54, 7, 23, 39, 55);
        }
#else
            get;
        } = Vector256.Create((byte)0, 16, 32, 48, 1, 17, 33, 49, 2, 18, 34, 50, 3, 19, 35, 51, 4, 20, 36, 52, 5, 21, 37, 53, 6, 22, 38, 54, 7, 23, 39, 55);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX2 Longer - Byte - The index of data2/data3.</summary>
        [CLSCompliant(false)]
        public static Vector256<byte> YGroup4Zip_ShuffleX2Longer_Byte_Data23 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((byte)8, 24, 40, 56, 9, 25, 41, 57, 10, 26, 42, 58, 11, 27, 43, 59, 12, 28, 44, 60, 13, 29, 45, 61, 14, 30, 46, 62, 15, 31, 47, 63);
        }
#else
            get;
        } = Vector256.Create((byte)8, 24, 40, 56, 9, 25, 41, 57, 10, 26, 42, 58, 11, 27, 43, 59, 12, 28, 44, 60, 13, 29, 45, 61, 14, 30, 46, 62, 15, 31, 47, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX2 Longer - UInt16 - The index of data0/data1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup4Zip_ShuffleX2Longer_UInt16_Data01 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)0, 8, 16, 24, 1, 9, 17, 25, 2, 10, 18, 26, 3, 11, 19, 27);
        }
#else
            get;
        } = Vector256.Create((ushort)0, 8, 16, 24, 1, 9, 17, 25, 2, 10, 18, 26, 3, 11, 19, 27);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX2 Longer - UInt16 - The index of data2/data3.</summary>
        [CLSCompliant(false)]
        public static Vector256<ushort> YGroup4Zip_ShuffleX2Longer_UInt16_Data23 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ushort)4, 12, 20, 28, 5, 13, 21, 29, 6, 14, 22, 30, 7, 15, 23, 31);
        }
#else
            get;
        } = Vector256.Create((ushort)4, 12, 20, 28, 5, 13, 21, 29, 6, 14, 22, 30, 7, 15, 23, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX2 Longer - UInt32 - The index of data0/data1.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup4Zip_ShuffleX2Longer_UInt32_Data01 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)0, 4, 8, 12, 1, 5, 9, 13);
        }
#else
            get;
        } = Vector256.Create((uint)0, 4, 8, 12, 1, 5, 9, 13);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX2 Longer - UInt32 - The index of data2/data3.</summary>
        [CLSCompliant(false)]
        public static Vector256<uint> YGroup4Zip_ShuffleX2Longer_UInt32_Data23 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((uint)2, 6, 10, 14, 3, 7, 11, 15);
        }
#else
            get;
        } = Vector256.Create((uint)2, 6, 10, 14, 3, 7, 11, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX2 Longer - UInt64 - The index of data0/data1.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup4Zip_ShuffleX2Longer_UInt64_Data01 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)0, 2, 4, 6);
        }
#else
            get;
        } = Vector256.Create((ulong)0, 4, 1, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX2 Longer - UInt64 - The index of data2/data3.</summary>
        [CLSCompliant(false)]
        public static Vector256<ulong> YGroup4Zip_ShuffleX2Longer_UInt64_Data23 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector256.Create((ulong)1, 3, 5, 7);
        }
#else
            get;
        } = Vector256.Create((ulong)2, 6, 3, 7);
#endif // USE_VECTOR_CREATE

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
