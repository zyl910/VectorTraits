//#define FALLBACK_USE_T

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
    partial class Vector512Constants {
#if NET8_0_OR_GREATER

        /// <summary>YGroup1ToGroup3 - Shuffle - Byte - The index of item 0.</summary>
        public static Vector512<byte> YGroup1ToGroup3_Shuffle_Byte_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10, 10, 11, 11, 11, 12, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 15, 16, 16, 16, 17, 17, 17, 18, 18, 18, 19, 19, 19, 20, 20, 20, 21);
        }
#else
            get;
        } = Vector512.Create((byte)0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10, 10, 11, 11, 11, 12, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 15, 16, 16, 16, 17, 17, 17, 18, 18, 18, 19, 19, 19, 20, 20, 20, 21);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - Byte - The index of item 1.</summary>
        public static Vector512<byte> YGroup1ToGroup3_Shuffle_Byte_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)21, 21, 22, 22, 22, 23, 23, 23, 24, 24, 24, 25, 25, 25, 26, 26, 26, 27, 27, 27, 28, 28, 28, 29, 29, 29, 30, 30, 30, 31, 31, 31, 32, 32, 32, 33, 33, 33, 34, 34, 34, 35, 35, 35, 36, 36, 36, 37, 37, 37, 38, 38, 38, 39, 39, 39, 40, 40, 40, 41, 41, 41, 42, 42);
        }
#else
            get;
        } = Vector512.Create((byte)21, 21, 22, 22, 22, 23, 23, 23, 24, 24, 24, 25, 25, 25, 26, 26, 26, 27, 27, 27, 28, 28, 28, 29, 29, 29, 30, 30, 30, 31, 31, 31, 32, 32, 32, 33, 33, 33, 34, 34, 34, 35, 35, 35, 36, 36, 36, 37, 37, 37, 38, 38, 38, 39, 39, 39, 40, 40, 40, 41, 41, 41, 42, 42);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - Byte - The index of item 2.</summary>
        public static Vector512<byte> YGroup1ToGroup3_Shuffle_Byte_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)42, 43, 43, 43, 44, 44, 44, 45, 45, 45, 46, 46, 46, 47, 47, 47, 48, 48, 48, 49, 49, 49, 50, 50, 50, 51, 51, 51, 52, 52, 52, 53, 53, 53, 54, 54, 54, 55, 55, 55, 56, 56, 56, 57, 57, 57, 58, 58, 58, 59, 59, 59, 60, 60, 60, 61, 61, 61, 62, 62, 62, 63, 63, 63);
        }
#else
            get;
        } = Vector512.Create((byte)42, 43, 43, 43, 44, 44, 44, 45, 45, 45, 46, 46, 46, 47, 47, 47, 48, 48, 48, 49, 49, 49, 50, 50, 50, 51, 51, 51, 52, 52, 52, 53, 53, 53, 54, 54, 54, 55, 55, 55, 56, 56, 56, 57, 57, 57, 58, 58, 58, 59, 59, 59, 60, 60, 60, 61, 61, 61, 62, 62, 62, 63, 63, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - Byte - Each 128 bits - The index of item 0.</summary>
        public static Vector512<byte> YGroup1ToGroup3_Shuffle_Byte_Each128_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5);
        }
#else
            get;
        } = Vector512.Create((byte)0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - Byte - Each 128 bits - The index of item 1.</summary>
        public static Vector512<byte> YGroup1ToGroup3_Shuffle_Byte_Each128_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10);
        }
#else
            get;
        } = Vector512.Create((byte)5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - Byte - Each 128 bits - The index of item 2.</summary>
        public static Vector512<byte> YGroup1ToGroup3_Shuffle_Byte_Each128_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)10, 11, 11, 11, 12, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 15, 10, 11, 11, 11, 12, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 15, 10, 11, 11, 11, 12, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 15, 10, 11, 11, 11, 12, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 15);
        }
#else
            get;
        } = Vector512.Create((byte)10, 11, 11, 11, 12, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 15, 10, 11, 11, 11, 12, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 15, 10, 11, 11, 11, 12, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 15, 10, 11, 11, 11, 12, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - UInt16 - The index of item 0.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup1ToGroup3_Shuffle_UInt16_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10);
        }
#else
            get;
        } = Vector512.Create((ushort)0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - UInt16 - The index of item 1.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup1ToGroup3_Shuffle_UInt16_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)10, 11, 11, 11, 12, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 15, 16, 16, 16, 17, 17, 17, 18, 18, 18, 19, 19, 19, 20, 20, 20, 21);
        }
#else
            get;
        } = Vector512.Create((ushort)10, 11, 11, 11, 12, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 15, 16, 16, 16, 17, 17, 17, 18, 18, 18, 19, 19, 19, 20, 20, 20, 21);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - UInt16 - The index of item 2.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup1ToGroup3_Shuffle_UInt16_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)21, 21, 22, 22, 22, 23, 23, 23, 24, 24, 24, 25, 25, 25, 26, 26, 26, 27, 27, 27, 28, 28, 28, 29, 29, 29, 30, 30, 30, 31, 31, 31);
        }
#else
            get;
        } = Vector512.Create((ushort)21, 21, 22, 22, 22, 23, 23, 23, 24, 24, 24, 25, 25, 25, 26, 26, 26, 27, 27, 27, 28, 28, 28, 29, 29, 29, 30, 30, 30, 31, 31, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - UInt32 - The index of item 0.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup1ToGroup3_Shuffle_UInt32_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5);
        }
#else
            get;
        } = Vector512.Create((uint)0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - UInt32 - The index of item 1.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup1ToGroup3_Shuffle_UInt32_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10);
        }
#else
            get;
        } = Vector512.Create((uint)5, 5, 6, 6, 6, 7, 7, 7, 8, 8, 8, 9, 9, 9, 10, 10);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - UInt32 - The index of item 2.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup1ToGroup3_Shuffle_UInt32_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)10, 11, 11, 11, 12, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 15);
        }
#else
            get;
        } = Vector512.Create((uint)10, 11, 11, 11, 12, 12, 12, 13, 13, 13, 14, 14, 14, 15, 15, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - UInt64 - The index of item 0.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup1ToGroup3_Shuffle_UInt64_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)0, 0, 0, 1, 1, 1, 2, 2);
        }
#else
            get;
        } = Vector512.Create((ulong)0, 0, 0, 1, 1, 1, 2, 2);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - UInt64 - The index of item 1.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup1ToGroup3_Shuffle_UInt64_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)2, 3, 3, 3, 4, 4, 4, 5);
        }
#else
            get;
        } = Vector512.Create((ulong)2, 3, 3, 3, 4, 4, 4, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle - UInt64 - The index of item 2.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup1ToGroup3_Shuffle_UInt64_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)5, 5, 6, 6, 6, 7, 7, 7);
        }
#else
            get;
        } = Vector512.Create((ulong)5, 5, 6, 6, 6, 7, 7, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt16 - The index of item 0.</summary>
        public static Vector512<byte> YGroup1ToGroup3_ShuffleOnByte_UInt16_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 1, 0, 1, 0, 1, 2, 3, 2, 3, 2, 3, 4, 5, 4, 5, 4, 5, 6, 7, 6, 7, 6, 7, 8, 9, 8, 9, 8, 9, 10, 11, 10, 11, 10, 11, 12, 13, 12, 13, 12, 13, 14, 15, 14, 15, 14, 15, 16, 17, 16, 17, 16, 17, 18, 19, 18, 19, 18, 19, 20, 21, 20, 21);
        }
#else
            get;
        } = Vector512.Create((byte)0, 1, 0, 1, 0, 1, 2, 3, 2, 3, 2, 3, 4, 5, 4, 5, 4, 5, 6, 7, 6, 7, 6, 7, 8, 9, 8, 9, 8, 9, 10, 11, 10, 11, 10, 11, 12, 13, 12, 13, 12, 13, 14, 15, 14, 15, 14, 15, 16, 17, 16, 17, 16, 17, 18, 19, 18, 19, 18, 19, 20, 21, 20, 21);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt16 - The index of item 1.</summary>
        public static Vector512<byte> YGroup1ToGroup3_ShuffleOnByte_UInt16_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)20, 21, 22, 23, 22, 23, 22, 23, 24, 25, 24, 25, 24, 25, 26, 27, 26, 27, 26, 27, 28, 29, 28, 29, 28, 29, 30, 31, 30, 31, 30, 31, 32, 33, 32, 33, 32, 33, 34, 35, 34, 35, 34, 35, 36, 37, 36, 37, 36, 37, 38, 39, 38, 39, 38, 39, 40, 41, 40, 41, 40, 41, 42, 43);
        }
#else
            get;
        } = Vector512.Create((byte)20, 21, 22, 23, 22, 23, 22, 23, 24, 25, 24, 25, 24, 25, 26, 27, 26, 27, 26, 27, 28, 29, 28, 29, 28, 29, 30, 31, 30, 31, 30, 31, 32, 33, 32, 33, 32, 33, 34, 35, 34, 35, 34, 35, 36, 37, 36, 37, 36, 37, 38, 39, 38, 39, 38, 39, 40, 41, 40, 41, 40, 41, 42, 43);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt16 - The index of item 2.</summary>
        public static Vector512<byte> YGroup1ToGroup3_ShuffleOnByte_UInt16_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)42, 43, 42, 43, 44, 45, 44, 45, 44, 45, 46, 47, 46, 47, 46, 47, 48, 49, 48, 49, 48, 49, 50, 51, 50, 51, 50, 51, 52, 53, 52, 53, 52, 53, 54, 55, 54, 55, 54, 55, 56, 57, 56, 57, 56, 57, 58, 59, 58, 59, 58, 59, 60, 61, 60, 61, 60, 61, 62, 63, 62, 63, 62, 63);
        }
#else
            get;
        } = Vector512.Create((byte)42, 43, 42, 43, 44, 45, 44, 45, 44, 45, 46, 47, 46, 47, 46, 47, 48, 49, 48, 49, 48, 49, 50, 51, 50, 51, 50, 51, 52, 53, 52, 53, 52, 53, 54, 55, 54, 55, 54, 55, 56, 57, 56, 57, 56, 57, 58, 59, 58, 59, 58, 59, 60, 61, 60, 61, 60, 61, 62, 63, 62, 63, 62, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt32 - The index of item 0.</summary>
        public static Vector512<byte> YGroup1ToGroup3_ShuffleOnByte_UInt32_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3, 4, 5, 6, 7, 4, 5, 6, 7, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15, 12, 13, 14, 15, 16, 17, 18, 19, 16, 17, 18, 19, 16, 17, 18, 19, 20, 21, 22, 23);
        }
#else
            get;
        } = Vector512.Create((byte)0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3, 4, 5, 6, 7, 4, 5, 6, 7, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15, 12, 13, 14, 15, 16, 17, 18, 19, 16, 17, 18, 19, 16, 17, 18, 19, 20, 21, 22, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt32 - The index of item 1.</summary>
        public static Vector512<byte> YGroup1ToGroup3_ShuffleOnByte_UInt32_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)20, 21, 22, 23, 20, 21, 22, 23, 24, 25, 26, 27, 24, 25, 26, 27, 24, 25, 26, 27, 28, 29, 30, 31, 28, 29, 30, 31, 28, 29, 30, 31, 32, 33, 34, 35, 32, 33, 34, 35, 32, 33, 34, 35, 36, 37, 38, 39, 36, 37, 38, 39, 36, 37, 38, 39, 40, 41, 42, 43, 40, 41, 42, 43);
        }
#else
            get;
        } = Vector512.Create((byte)20, 21, 22, 23, 20, 21, 22, 23, 24, 25, 26, 27, 24, 25, 26, 27, 24, 25, 26, 27, 28, 29, 30, 31, 28, 29, 30, 31, 28, 29, 30, 31, 32, 33, 34, 35, 32, 33, 34, 35, 32, 33, 34, 35, 36, 37, 38, 39, 36, 37, 38, 39, 36, 37, 38, 39, 40, 41, 42, 43, 40, 41, 42, 43);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt32 - The index of item 2.</summary>
        public static Vector512<byte> YGroup1ToGroup3_ShuffleOnByte_UInt32_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)40, 41, 42, 43, 44, 45, 46, 47, 44, 45, 46, 47, 44, 45, 46, 47, 48, 49, 50, 51, 48, 49, 50, 51, 48, 49, 50, 51, 52, 53, 54, 55, 52, 53, 54, 55, 52, 53, 54, 55, 56, 57, 58, 59, 56, 57, 58, 59, 56, 57, 58, 59, 60, 61, 62, 63, 60, 61, 62, 63, 60, 61, 62, 63);
        }
#else
            get;
        } = Vector512.Create((byte)40, 41, 42, 43, 44, 45, 46, 47, 44, 45, 46, 47, 44, 45, 46, 47, 48, 49, 50, 51, 48, 49, 50, 51, 48, 49, 50, 51, 52, 53, 54, 55, 52, 53, 54, 55, 52, 53, 54, 55, 56, 57, 58, 59, 56, 57, 58, 59, 56, 57, 58, 59, 60, 61, 62, 63, 60, 61, 62, 63, 60, 61, 62, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt64 - The index of item 0.</summary>
        public static Vector512<byte> YGroup1ToGroup3_ShuffleOnByte_UInt64_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 16, 17, 18, 19, 20, 21, 22, 23);
        }
#else
            get;
        } = Vector512.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 16, 17, 18, 19, 20, 21, 22, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt64 - The index of item 1.</summary>
        public static Vector512<byte> YGroup1ToGroup3_ShuffleOnByte_UInt64_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 24, 25, 26, 27, 28, 29, 30, 31, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 32, 33, 34, 35, 36, 37, 38, 39, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47);
        }
#else
            get;
        } = Vector512.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 24, 25, 26, 27, 28, 29, 30, 31, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 32, 33, 34, 35, 36, 37, 38, 39, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt64 - The index of item 2.</summary>
        public static Vector512<byte> YGroup1ToGroup3_ShuffleOnByte_UInt64_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)40, 41, 42, 43, 44, 45, 46, 47, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 48, 49, 50, 51, 52, 53, 54, 55, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 56, 57, 58, 59, 60, 61, 62, 63, 56, 57, 58, 59, 60, 61, 62, 63);
        }
#else
            get;
        } = Vector512.Create((byte)40, 41, 42, 43, 44, 45, 46, 47, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 48, 49, 50, 51, 52, 53, 54, 55, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 56, 57, 58, 59, 60, 61, 62, 63, 56, 57, 58, 59, 60, 61, 62, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt16 - Each 128 bits - The index of item 0.</summary>
        public static Vector512<byte> YGroup1ToGroup3_ShuffleOnByte_UInt16_Each128_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 1, 0, 1, 0, 1, 2, 3, 2, 3, 2, 3, 4, 5, 4, 5, 0, 1, 0, 1, 0, 1, 2, 3, 2, 3, 2, 3, 4, 5, 4, 5, 0, 1, 0, 1, 0, 1, 2, 3, 2, 3, 2, 3, 4, 5, 4, 5, 0, 1, 0, 1, 0, 1, 2, 3, 2, 3, 2, 3, 4, 5, 4, 5);
        }
#else
            get;
        } = Vector512.Create((byte)0, 1, 0, 1, 0, 1, 2, 3, 2, 3, 2, 3, 4, 5, 4, 5, 0, 1, 0, 1, 0, 1, 2, 3, 2, 3, 2, 3, 4, 5, 4, 5, 0, 1, 0, 1, 0, 1, 2, 3, 2, 3, 2, 3, 4, 5, 4, 5, 0, 1, 0, 1, 0, 1, 2, 3, 2, 3, 2, 3, 4, 5, 4, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt16 - Each 128 bits - The index of item 1.</summary>
        public static Vector512<byte> YGroup1ToGroup3_ShuffleOnByte_UInt16_Each128_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)4, 5, 6, 7, 6, 7, 6, 7, 8, 9, 8, 9, 8, 9, 10, 11, 4, 5, 6, 7, 6, 7, 6, 7, 8, 9, 8, 9, 8, 9, 10, 11, 4, 5, 6, 7, 6, 7, 6, 7, 8, 9, 8, 9, 8, 9, 10, 11, 4, 5, 6, 7, 6, 7, 6, 7, 8, 9, 8, 9, 8, 9, 10, 11);
        }
#else
            get;
        } = Vector512.Create((byte)4, 5, 6, 7, 6, 7, 6, 7, 8, 9, 8, 9, 8, 9, 10, 11, 4, 5, 6, 7, 6, 7, 6, 7, 8, 9, 8, 9, 8, 9, 10, 11, 4, 5, 6, 7, 6, 7, 6, 7, 8, 9, 8, 9, 8, 9, 10, 11, 4, 5, 6, 7, 6, 7, 6, 7, 8, 9, 8, 9, 8, 9, 10, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt16 - Each 128 bits - The index of item 2.</summary>
        public static Vector512<byte> YGroup1ToGroup3_ShuffleOnByte_UInt16_Each128_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)10, 11, 10, 11, 12, 13, 12, 13, 12, 13, 14, 15, 14, 15, 14, 15, 10, 11, 10, 11, 12, 13, 12, 13, 12, 13, 14, 15, 14, 15, 14, 15, 10, 11, 10, 11, 12, 13, 12, 13, 12, 13, 14, 15, 14, 15, 14, 15, 10, 11, 10, 11, 12, 13, 12, 13, 12, 13, 14, 15, 14, 15, 14, 15);
        }
#else
            get;
        } = Vector512.Create((byte)10, 11, 10, 11, 12, 13, 12, 13, 12, 13, 14, 15, 14, 15, 14, 15, 10, 11, 10, 11, 12, 13, 12, 13, 12, 13, 14, 15, 14, 15, 14, 15, 10, 11, 10, 11, 12, 13, 12, 13, 12, 13, 14, 15, 14, 15, 14, 15, 10, 11, 10, 11, 12, 13, 12, 13, 12, 13, 14, 15, 14, 15, 14, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt32 - Each 128 bits - The index of item 0.</summary>
        public static Vector512<byte> YGroup1ToGroup3_ShuffleOnByte_UInt32_Each128_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3, 4, 5, 6, 7);
        }
#else
            get;
        } = Vector512.Create((byte)0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 0, 1, 2, 3, 0, 1, 2, 3, 4, 5, 6, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt32 - Each 128 bits - The index of item 1.</summary>
        public static Vector512<byte> YGroup1ToGroup3_ShuffleOnByte_UInt32_Each128_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)4, 5, 6, 7, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11, 4, 5, 6, 7, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11, 4, 5, 6, 7, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11, 4, 5, 6, 7, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11);
        }
#else
            get;
        } = Vector512.Create((byte)4, 5, 6, 7, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11, 4, 5, 6, 7, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11, 4, 5, 6, 7, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11, 4, 5, 6, 7, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt32 - Each 128 bits - The index of item 2.</summary>
        public static Vector512<byte> YGroup1ToGroup3_ShuffleOnByte_UInt32_Each128_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15, 12, 13, 14, 15);
        }
#else
            get;
        } = Vector512.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15, 12, 13, 14, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt64 - Each 128 bits - The index of item 0.</summary>
        public static Vector512<byte> YGroup1ToGroup3_ShuffleOnByte_UInt64_Each128_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7);
        }
#else
            get;
        } = Vector512.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt64 - Each 128 bits - The index of item 1.</summary>
        public static Vector512<byte> YGroup1ToGroup3_ShuffleOnByte_UInt64_Each128_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
        }
#else
            get;
        } = Vector512.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup1ToGroup3 - Shuffle on byte - UInt64 - Each 128 bits - The index of item 2.</summary>
        public static Vector512<byte> YGroup1ToGroup3_ShuffleOnByte_UInt64_Each128_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15);
        }
#else
            get;
        } = Vector512.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15);
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup2Unzip - ShuffleX2 - Byte - The index of X.</summary>
        public static Vector512<byte> YGroup2Unzip_ShuffleX2_Byte_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58, 60, 62, 64, 66, 68, 70, 72, 74, 76, 78, 80, 82, 84, 86, 88, 90, 92, 94, 96, 98, 100, 102, 104, 106, 108, 110, 112, 114, 116, 118, 120, 122, 124, 126);
        }
#else
            get;
        } = Vector512.Create((byte)0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58, 60, 62, 64, 66, 68, 70, 72, 74, 76, 78, 80, 82, 84, 86, 88, 90, 92, 94, 96, 98, 100, 102, 104, 106, 108, 110, 112, 114, 116, 118, 120, 122, 124, 126);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - Byte - The index of Y.</summary>
        public static Vector512<byte> YGroup2Unzip_ShuffleX2_Byte_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73, 75, 77, 79, 81, 83, 85, 87, 89, 91, 93, 95, 97, 99, 101, 103, 105, 107, 109, 111, 113, 115, 117, 119, 121, 123, 125, 127);
        }
#else
            get;
        } = Vector512.Create((byte)1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73, 75, 77, 79, 81, 83, 85, 87, 89, 91, 93, 95, 97, 99, 101, 103, 105, 107, 109, 111, 113, 115, 117, 119, 121, 123, 125, 127);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt16 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup2Unzip_ShuffleX2_UInt16_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58, 60, 62);
        }
#else
            get;
        } = Vector512.Create((ushort)0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58, 60, 62);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt16 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup2Unzip_ShuffleX2_UInt16_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53, 55, 57, 59, 61, 63);
        }
#else
            get;
        } = Vector512.Create((ushort)1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53, 55, 57, 59, 61, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt32 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup2Unzip_ShuffleX2_UInt32_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30);
        }
#else
            get;
        } = Vector512.Create((uint)0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt32 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup2Unzip_ShuffleX2_UInt32_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31);
        }
#else
            get;
        } = Vector512.Create((uint)1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt64 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup2Unzip_ShuffleX2_UInt64_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)0, 2, 4, 6, 8, 10, 12, 14);
        }
#else
            get;
        } = Vector512.Create((ulong)0, 2, 4, 6, 8, 10, 12, 14);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt64 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup2Unzip_ShuffleX2_UInt64_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)1, 3, 5, 7, 9, 11, 13, 15);
        }
#else
            get;
        } = Vector512.Create((ulong)1, 3, 5, 7, 9, 11, 13, 15);
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 0.</summary>
        public static Vector512<byte> YGroup3ToGroup4_Shuffle_Byte_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10, 11, 11, 12, 13, 14, 14, 15, 16, 17, 17, 18, 19, 20, 20, 21, 22, 23, 23, 24, 25, 26, 26, 27, 28, 29, 29, 30, 31, 32, 32, 33, 34, 35, 35, 36, 37, 38, 38, 39, 40, 41, 41, 42, 43, 44, 44, 45, 46, 47, 47);
        }
#else
            get;
        } = Vector512.Create((byte)0, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10, 11, 11, 12, 13, 14, 14, 15, 16, 17, 17, 18, 19, 20, 20, 21, 22, 23, 23, 24, 25, 26, 26, 27, 28, 29, 29, 30, 31, 32, 32, 33, 34, 35, 35, 36, 37, 38, 38, 39, 40, 41, 41, 42, 43, 44, 44, 45, 46, 47, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 0 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup3ToGroup4_Shuffle_Byte_0_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10, 11, 11, 0, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10, 11, 11, 0, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10, 11, 11, 0, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10, 11, 11);
        }
#else
            get;
        } = Vector512.Create((byte)0, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10, 11, 11, 0, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10, 11, 11, 0, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10, 11, 11, 0, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10, 11, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 1.</summary>
        public static Vector512<byte> YGroup3ToGroup4_Shuffle_Byte_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)48, 49, 50, 50, 51, 52, 53, 53, 54, 55, 56, 56, 57, 58, 59, 59, 60, 61, 62, 62, 63, 64, 65, 65, 66, 67, 68, 68, 69, 70, 71, 71, 72, 73, 74, 74, 75, 76, 77, 77, 78, 79, 80, 80, 81, 82, 83, 83, 84, 85, 86, 86, 87, 88, 89, 89, 90, 91, 92, 92, 93, 94, 95, 95);
        }
#else
            get;
        } = Vector512.Create((byte)48, 49, 50, 50, 51, 52, 53, 53, 54, 55, 56, 56, 57, 58, 59, 59, 60, 61, 62, 62, 63, 64, 65, 65, 66, 67, 68, 68, 69, 70, 71, 71, 72, 73, 74, 74, 75, 76, 77, 77, 78, 79, 80, 80, 81, 82, 83, 83, 84, 85, 86, 86, 87, 88, 89, 89, 90, 91, 92, 92, 93, 94, 95, 95);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 1 - Sub part0.</summary>
        public static Vector512<byte> YGroup3ToGroup4_Shuffle_Byte_1A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)48, 49, 50, 50, 51, 52, 53, 53, 54, 55, 56, 56, 57, 58, 59, 59, 60, 61, 62, 62, 63, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)48, 49, 50, 50, 51, 52, 53, 53, 54, 55, 56, 56, 57, 58, 59, 59, 60, 61, 62, 62, 63, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 1 - Sub part1.</summary>
        public static Vector512<byte> YGroup3ToGroup4_Shuffle_Byte_1B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 1, 2, 3, 4, 4, 5, 6, 7, 7, 8, 9, 10, 10, 11, 12, 13, 13, 14, 15, 16, 16, 17, 18, 19, 19, 20, 21, 22, 22, 23, 24, 25, 25, 26, 27, 28, 28, 29, 30, 31, 31).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 1, 2, 3, 4, 4, 5, 6, 7, 7, 8, 9, 10, 10, 11, 12, 13, 13, 14, 15, 16, 16, 17, 18, 19, 19, 20, 21, 22, 22, 23, 24, 25, 25, 26, 27, 28, 28, 29, 30, 31, 31).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 1 - Sub part0 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup3ToGroup4_Shuffle_Byte_1A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)12, 13, 14, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)12, 13, 14, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 1 - Sub part1 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup3ToGroup4_Shuffle_Byte_1B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, 0, 1, 1, 2, 3, 4, 4, 5, 6, 7, 7, -1, -1, -1, -1, -1, 0, 1, 1, 2, 3, 4, 4, 5, 6, 7, 7, -1, -1, -1, -1, -1, 0, 1, 1, 2, 3, 4, 4, 5, 6, 7, 7, -1, -1, -1, -1, -1, 0, 1, 1, 2, 3, 4, 4, 5, 6, 7, 7).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, 0, 1, 1, 2, 3, 4, 4, 5, 6, 7, 7, -1, -1, -1, -1, -1, 0, 1, 1, 2, 3, 4, 4, 5, 6, 7, 7, -1, -1, -1, -1, -1, 0, 1, 1, 2, 3, 4, 4, 5, 6, 7, 7, -1, -1, -1, -1, -1, 0, 1, 1, 2, 3, 4, 4, 5, 6, 7, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 2.</summary>
        public static Vector512<byte> YGroup3ToGroup4_Shuffle_Byte_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)32, 33, 34, 34, 35, 36, 37, 37, 38, 39, 40, 40, 41, 42, 43, 43, 44, 45, 46, 46, 47, 48, 49, 49, 50, 51, 52, 52, 53, 54, 55, 55, 56, 57, 58, 58, 59, 60, 61, 61, 62, 63, 64, 64, 65, 66, 67, 67, 68, 69, 70, 70, 71, 72, 73, 73, 74, 75, 76, 76, 77, 78, 79, 79);
        }
#else
            get;
        } = Vector512.Create((byte)32, 33, 34, 34, 35, 36, 37, 37, 38, 39, 40, 40, 41, 42, 43, 43, 44, 45, 46, 46, 47, 48, 49, 49, 50, 51, 52, 52, 53, 54, 55, 55, 56, 57, 58, 58, 59, 60, 61, 61, 62, 63, 64, 64, 65, 66, 67, 67, 68, 69, 70, 70, 71, 72, 73, 73, 74, 75, 76, 76, 77, 78, 79, 79);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 2 - Sub part0.</summary>
        public static Vector512<byte> YGroup3ToGroup4_Shuffle_Byte_2A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)32, 33, 34, 34, 35, 36, 37, 37, 38, 39, 40, 40, 41, 42, 43, 43, 44, 45, 46, 46, 47, 48, 49, 49, 50, 51, 52, 52, 53, 54, 55, 55, 56, 57, 58, 58, 59, 60, 61, 61, 62, 63, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)32, 33, 34, 34, 35, 36, 37, 37, 38, 39, 40, 40, 41, 42, 43, 43, 44, 45, 46, 46, 47, 48, 49, 49, 50, 51, 52, 52, 53, 54, 55, 55, 56, 57, 58, 58, 59, 60, 61, 61, 62, 63, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 2 - Sub part1.</summary>
        public static Vector512<byte> YGroup3ToGroup4_Shuffle_Byte_2B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 1, 2, 3, 3, 4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15, 15).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 1, 2, 3, 3, 4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 2 - Sub part0 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup3ToGroup4_Shuffle_Byte_2A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)8, 9, 10, 10, 11, 12, 13, 13, 14, 15, -1, -1, -1, -1, -1, -1, 8, 9, 10, 10, 11, 12, 13, 13, 14, 15, -1, -1, -1, -1, -1, -1, 8, 9, 10, 10, 11, 12, 13, 13, 14, 15, -1, -1, -1, -1, -1, -1, 8, 9, 10, 10, 11, 12, 13, 13, 14, 15, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)8, 9, 10, 10, 11, 12, 13, 13, 14, 15, -1, -1, -1, -1, -1, -1, 8, 9, 10, 10, 11, 12, 13, 13, 14, 15, -1, -1, -1, -1, -1, -1, 8, 9, 10, 10, 11, 12, 13, 13, 14, 15, -1, -1, -1, -1, -1, -1, 8, 9, 10, 10, 11, 12, 13, 13, 14, 15, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 2 - Sub part1 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup3ToGroup4_Shuffle_Byte_2B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 1, 2, 3, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 1, 2, 3, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 1, 2, 3, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 1, 2, 3, 3).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 1, 2, 3, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 1, 2, 3, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 1, 2, 3, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 1, 2, 3, 3).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 3.</summary>
        public static Vector512<byte> YGroup3ToGroup4_Shuffle_Byte_3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)16, 17, 18, 18, 19, 20, 21, 21, 22, 23, 24, 24, 25, 26, 27, 27, 28, 29, 30, 30, 31, 32, 33, 33, 34, 35, 36, 36, 37, 38, 39, 39, 40, 41, 42, 42, 43, 44, 45, 45, 46, 47, 48, 48, 49, 50, 51, 51, 52, 53, 54, 54, 55, 56, 57, 57, 58, 59, 60, 60, 61, 62, 63, 63);
        }
#else
            get;
        } = Vector512.Create((byte)16, 17, 18, 18, 19, 20, 21, 21, 22, 23, 24, 24, 25, 26, 27, 27, 28, 29, 30, 30, 31, 32, 33, 33, 34, 35, 36, 36, 37, 38, 39, 39, 40, 41, 42, 42, 43, 44, 45, 45, 46, 47, 48, 48, 49, 50, 51, 51, 52, 53, 54, 54, 55, 56, 57, 57, 58, 59, 60, 60, 61, 62, 63, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 3 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup3ToGroup4_Shuffle_Byte_3_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15, 15, 4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15, 15, 4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15, 15, 4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15, 15);
        }
#else
            get;
        } = Vector512.Create((byte)4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15, 15, 4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15, 15, 4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15, 15, 4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt16 - The index of item 0.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup3ToGroup4_Shuffle_UInt16_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)0, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10, 11, 11, 12, 13, 14, 14, 15, 16, 17, 17, 18, 19, 20, 20, 21, 22, 23, 23);
        }
#else
            get;
        } = Vector512.Create((ushort)0, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10, 11, 11, 12, 13, 14, 14, 15, 16, 17, 17, 18, 19, 20, 20, 21, 22, 23, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt16 - The index of item 1.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup3ToGroup4_Shuffle_UInt16_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)24, 25, 26, 26, 27, 28, 29, 29, 30, 31, 32, 32, 33, 34, 35, 35, 36, 37, 38, 38, 39, 40, 41, 41, 42, 43, 44, 44, 45, 46, 47, 47);
        }
#else
            get;
        } = Vector512.Create((ushort)24, 25, 26, 26, 27, 28, 29, 29, 30, 31, 32, 32, 33, 34, 35, 35, 36, 37, 38, 38, 39, 40, 41, 41, 42, 43, 44, 44, 45, 46, 47, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt16 - The index of item 2.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup3ToGroup4_Shuffle_UInt16_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)16, 17, 18, 18, 19, 20, 21, 21, 22, 23, 24, 24, 25, 26, 27, 27, 28, 29, 30, 30, 31, 32, 33, 33, 34, 35, 36, 36, 37, 38, 39, 39);
        }
#else
            get;
        } = Vector512.Create((ushort)16, 17, 18, 18, 19, 20, 21, 21, 22, 23, 24, 24, 25, 26, 27, 27, 28, 29, 30, 30, 31, 32, 33, 33, 34, 35, 36, 36, 37, 38, 39, 39);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt16 - The index of item 3.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup3ToGroup4_Shuffle_UInt16_3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)8, 9, 10, 10, 11, 12, 13, 13, 14, 15, 16, 16, 17, 18, 19, 19, 20, 21, 22, 22, 23, 24, 25, 25, 26, 27, 28, 28, 29, 30, 31, 31);
        }
#else
            get;
        } = Vector512.Create((ushort)8, 9, 10, 10, 11, 12, 13, 13, 14, 15, 16, 16, 17, 18, 19, 19, 20, 21, 22, 22, 23, 24, 25, 25, 26, 27, 28, 28, 29, 30, 31, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt32 - The index of item 0.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup3ToGroup4_Shuffle_UInt32_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)0, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10, 11, 11);
        }
#else
            get;
        } = Vector512.Create((uint)0, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10, 11, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt32 - The index of item 1.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup3ToGroup4_Shuffle_UInt32_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)12, 13, 14, 14, 15, 16, 17, 17, 18, 19, 20, 20, 21, 22, 23, 23);
        }
#else
            get;
        } = Vector512.Create((uint)12, 13, 14, 14, 15, 16, 17, 17, 18, 19, 20, 20, 21, 22, 23, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt32 - The index of item 2.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup3ToGroup4_Shuffle_UInt32_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)8, 9, 10, 10, 11, 12, 13, 13, 14, 15, 16, 16, 17, 18, 19, 19);
        }
#else
            get;
        } = Vector512.Create((uint)8, 9, 10, 10, 11, 12, 13, 13, 14, 15, 16, 16, 17, 18, 19, 19);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt32 - The index of item 3.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup3ToGroup4_Shuffle_UInt32_3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15, 15);
        }
#else
            get;
        } = Vector512.Create((uint)4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt64 - The index of item 0.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup3ToGroup4_Shuffle_UInt64_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)0, 1, 2, 2, 3, 4, 5, 5);
        }
#else
            get;
        } = Vector512.Create((ulong)0, 1, 2, 2, 3, 4, 5, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt64 - The index of item 1.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup3ToGroup4_Shuffle_UInt64_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)6, 7, 8, 8, 9, 10, 11, 11);
        }
#else
            get;
        } = Vector512.Create((ulong)6, 7, 8, 8, 9, 10, 11, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt64 - The index of item 2.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup3ToGroup4_Shuffle_UInt64_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)4, 5, 6, 6, 7, 8, 9, 9);
        }
#else
            get;
        } = Vector512.Create((ulong)4, 5, 6, 6, 7, 8, 9, 9);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt64 - The index of item 3.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup3ToGroup4_Shuffle_UInt64_3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)2, 3, 4, 4, 5, 6, 7, 7);
        }
#else
            get;
        } = Vector512.Create((ulong2, 3, 4, 4, 5, 6, 7, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 0.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 1, 2, 3, 4, 5, 4, 5, 6, 7, 8, 9, 10, 11, 10, 11, 12, 13, 14, 15, 16, 17, 16, 17, 18, 19, 20, 21, 22, 23, 22, 23, 24, 25, 26, 27, 28, 29, 28, 29, 30, 31, 32, 33, 34, 35, 34, 35, 36, 37, 38, 39, 40, 41, 40, 41, 42, 43, 44, 45, 46, 47, 46, 47);
        }
#else
            get;
        } = Vector512.Create((byte)0, 1, 2, 3, 4, 5, 4, 5, 6, 7, 8, 9, 10, 11, 10, 11, 12, 13, 14, 15, 16, 17, 16, 17, 18, 19, 20, 21, 22, 23, 22, 23, 24, 25, 26, 27, 28, 29, 28, 29, 30, 31, 32, 33, 34, 35, 34, 35, 36, 37, 38, 39, 40, 41, 40, 41, 42, 43, 44, 45, 46, 47, 46, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 0 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_0_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 1, 2, 3, 4, 5, 4, 5, 6, 7, 8, 9, 10, 11, 10, 11, 0, 1, 2, 3, 4, 5, 4, 5, 6, 7, 8, 9, 10, 11, 10, 11, 0, 1, 2, 3, 4, 5, 4, 5, 6, 7, 8, 9, 10, 11, 10, 11, 0, 1, 2, 3, 4, 5, 4, 5, 6, 7, 8, 9, 10, 11, 10, 11);
        }
#else
            get;
        } = Vector512.Create((byte)0, 1, 2, 3, 4, 5, 4, 5, 6, 7, 8, 9, 10, 11, 10, 11, 0, 1, 2, 3, 4, 5, 4, 5, 6, 7, 8, 9, 10, 11, 10, 11, 0, 1, 2, 3, 4, 5, 4, 5, 6, 7, 8, 9, 10, 11, 10, 11, 0, 1, 2, 3, 4, 5, 4, 5, 6, 7, 8, 9, 10, 11, 10, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 1.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)48, 49, 50, 51, 52, 53, 52, 53, 54, 55, 56, 57, 58, 59, 58, 59, 60, 61, 62, 63, 64, 65, 64, 65, 66, 67, 68, 69, 70, 71, 70, 71, 72, 73, 74, 75, 76, 77, 76, 77, 78, 79, 80, 81, 82, 83, 82, 83, 84, 85, 86, 87, 88, 89, 88, 89, 90, 91, 92, 93, 94, 95, 94, 95);
        }
#else
            get;
        } = Vector512.Create((byte)48, 49, 50, 51, 52, 53, 52, 53, 54, 55, 56, 57, 58, 59, 58, 59, 60, 61, 62, 63, 64, 65, 64, 65, 66, 67, 68, 69, 70, 71, 70, 71, 72, 73, 74, 75, 76, 77, 76, 77, 78, 79, 80, 81, 82, 83, 82, 83, 84, 85, 86, 87, 88, 89, 88, 89, 90, 91, 92, 93, 94, 95, 94, 95);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 1 - Sub part0.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_1A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)48, 49, 50, 51, 52, 53, 52, 53, 54, 55, 56, 57, 58, 59, 58, 59, 60, 61, 62, 63, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)48, 49, 50, 51, 52, 53, 52, 53, 54, 55, 56, 57, 58, 59, 58, 59, 60, 61, 62, 63, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 1 - Sub part1.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_1B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 0, 1, 2, 3, 4, 5, 6, 7, 6, 7, 8, 9, 10, 11, 12, 13, 12, 13, 14, 15, 16, 17, 18, 19, 18, 19, 20, 21, 22, 23, 24, 25, 24, 25, 26, 27, 28, 29, 30, 31, 30, 31).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 0, 1, 2, 3, 4, 5, 6, 7, 6, 7, 8, 9, 10, 11, 12, 13, 12, 13, 14, 15, 16, 17, 18, 19, 18, 19, 20, 21, 22, 23, 24, 25, 24, 25, 26, 27, 28, 29, 30, 31, 30, 31).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 1 - Sub part0 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_1A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 1 - Sub part1 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_1B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, 0, 1, 0, 1, 2, 3, 4, 5, 6, 7, 6, 7, -1, -1, -1, -1, 0, 1, 0, 1, 2, 3, 4, 5, 6, 7, 6, 7, -1, -1, -1, -1, 0, 1, 0, 1, 2, 3, 4, 5, 6, 7, 6, 7, -1, -1, -1, -1, 0, 1, 0, 1, 2, 3, 4, 5, 6, 7, 6, 7).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, 0, 1, 0, 1, 2, 3, 4, 5, 6, 7, 6, 7, -1, -1, -1, -1, 0, 1, 0, 1, 2, 3, 4, 5, 6, 7, 6, 7, -1, -1, -1, -1, 0, 1, 0, 1, 2, 3, 4, 5, 6, 7, 6, 7, -1, -1, -1, -1, 0, 1, 0, 1, 2, 3, 4, 5, 6, 7, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 2.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)32, 33, 34, 35, 36, 37, 36, 37, 38, 39, 40, 41, 42, 43, 42, 43, 44, 45, 46, 47, 48, 49, 48, 49, 50, 51, 52, 53, 54, 55, 54, 55, 56, 57, 58, 59, 60, 61, 60, 61, 62, 63, 64, 65, 66, 67, 66, 67, 68, 69, 70, 71, 72, 73, 72, 73, 74, 75, 76, 77, 78, 79, 78, 79);
        }
#else
            get;
        } = Vector512.Create((byte)32, 33, 34, 35, 36, 37, 36, 37, 38, 39, 40, 41, 42, 43, 42, 43, 44, 45, 46, 47, 48, 49, 48, 49, 50, 51, 52, 53, 54, 55, 54, 55, 56, 57, 58, 59, 60, 61, 60, 61, 62, 63, 64, 65, 66, 67, 66, 67, 68, 69, 70, 71, 72, 73, 72, 73, 74, 75, 76, 77, 78, 79, 78, 79);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 2 - Sub part0.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_2A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)32, 33, 34, 35, 36, 37, 36, 37, 38, 39, 40, 41, 42, 43, 42, 43, 44, 45, 46, 47, 48, 49, 48, 49, 50, 51, 52, 53, 54, 55, 54, 55, 56, 57, 58, 59, 60, 61, 60, 61, 62, 63, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)32, 33, 34, 35, 36, 37, 36, 37, 38, 39, 40, 41, 42, 43, 42, 43, 44, 45, 46, 47, 48, 49, 48, 49, 50, 51, 52, 53, 54, 55, 54, 55, 56, 57, 58, 59, 60, 61, 60, 61, 62, 63, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 2 - Sub part1.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_2B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 2, 3, 4, 5, 6, 7, 8, 9, 8, 9, 10, 11, 12, 13, 14, 15, 14, 15).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 2, 3, 4, 5, 6, 7, 8, 9, 8, 9, 10, 11, 12, 13, 14, 15, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 2 - Sub part0 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_2A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)8, 9, 10, 11, 12, 13, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)8, 9, 10, 11, 12, 13, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 2 - Sub part1 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_2B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 2, 3).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 2, 3).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 3.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)16, 17, 18, 19, 20, 21, 20, 21, 22, 23, 24, 25, 26, 27, 26, 27, 28, 29, 30, 31, 32, 33, 32, 33, 34, 35, 36, 37, 38, 39, 38, 39, 40, 41, 42, 43, 44, 45, 44, 45, 46, 47, 48, 49, 50, 51, 50, 51, 52, 53, 54, 55, 56, 57, 56, 57, 58, 59, 60, 61, 62, 63, 62, 63);
        }
#else
            get;
        } = Vector512.Create((byte)16, 17, 18, 19, 20, 21, 20, 21, 22, 23, 24, 25, 26, 27, 26, 27, 28, 29, 30, 31, 32, 33, 32, 33, 34, 35, 36, 37, 38, 39, 38, 39, 40, 41, 42, 43, 44, 45, 44, 45, 46, 47, 48, 49, 50, 51, 50, 51, 52, 53, 54, 55, 56, 57, 56, 57, 58, 59, 60, 61, 62, 63, 62, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 3 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_3_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)4, 5, 6, 7, 8, 9, 8, 9, 10, 11, 12, 13, 14, 15, 14, 15, 4, 5, 6, 7, 8, 9, 8, 9, 10, 11, 12, 13, 14, 15, 14, 15, 4, 5, 6, 7, 8, 9, 8, 9, 10, 11, 12, 13, 14, 15, 14, 15, 4, 5, 6, 7, 8, 9, 8, 9, 10, 11, 12, 13, 14, 15, 14, 15);
        }
#else
            get;
        } = Vector512.Create((byte)4, 5, 6, 7, 8, 9, 8, 9, 10, 11, 12, 13, 14, 15, 14, 15, 4, 5, 6, 7, 8, 9, 8, 9, 10, 11, 12, 13, 14, 15, 14, 15, 4, 5, 6, 7, 8, 9, 8, 9, 10, 11, 12, 13, 14, 15, 14, 15, 4, 5, 6, 7, 8, 9, 8, 9, 10, 11, 12, 13, 14, 15, 14, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 0.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 44, 45, 46, 47);
        }
#else
            get;
        } = Vector512.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 44, 45, 46, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 0 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_0_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11);
        }
#else
            get;
        } = Vector512.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 1.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 92, 93, 94, 95);
        }
#else
            get;
        } = Vector512.Create((byte)48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 92, 93, 94, 95);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 1 - Sub part0.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_1A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 56, 57, 58, 59, 60, 61, 62, 63, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 56, 57, 58, 59, 60, 61, 62, 63, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 1 - Sub part1.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_1B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 28, 29, 30, 31).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 28, 29, 30, 31).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 1 - Sub part0 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_1A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 1 - Sub part1 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_1B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 4, 5, 6, 7, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 4, 5, 6, 7, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 4, 5, 6, 7, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 4, 5, 6, 7, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 4, 5, 6, 7, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 4, 5, 6, 7, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 2.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 76, 77, 78, 79);
        }
#else
            get;
        } = Vector512.Create((byte)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 76, 77, 78, 79);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 2 - Sub part0.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_2A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 2 - Sub part1.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_2B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 2 - Sub part0 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_2A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 2 - Sub part1 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_2B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 0, 1, 2, 3).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 0, 1, 2, 3).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 3.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 60, 61, 62, 63);
        }
#else
            get;
        } = Vector512.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 60, 61, 62, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 3 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_3_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15);
        }
#else
            get;
        } = Vector512.Create((byte)4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 0.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 40, 41, 42, 43, 44, 45, 46, 47);
        }
#else
            get;
        } = Vector512.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 40, 41, 42, 43, 44, 45, 46, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 0 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_0_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
        }
#else
            get;
        } = Vector512.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 1.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 88, 89, 90, 91, 92, 93, 94, 95);
        }
#else
            get;
        } = Vector512.Create((byte)48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 88, 89, 90, 91, 92, 93, 94, 95);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 1 - Sub part0.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_1A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 1 - Sub part1.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_1B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 24, 25, 26, 27, 28, 29, 30, 31).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 24, 25, 26, 27, 28, 29, 30, 31).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 1 - Sub part0 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_1A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 1 - Sub part1 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_1B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 2.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 72, 73, 74, 75, 76, 77, 78, 79);
        }
#else
            get;
        } = Vector512.Create((byte)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 72, 73, 74, 75, 76, 77, 78, 79);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 2 - Sub part0.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_2A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 2 - Sub part1.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_2B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 2 - Sub part0 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_2A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 2 - Sub part1 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_2B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 3.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 56, 57, 58, 59, 60, 61, 62, 63);
        }
#else
            get;
        } = Vector512.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 56, 57, 58, 59, 60, 61, 62, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 3 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_3_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15);
        }
#else
            get;
        } = Vector512.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15);
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of X.</summary>
        public static Vector512<byte> YGroup3Unzip_Shuffle_Byte_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45, 48, 51, 54, 57, 60, 63, 66, 69, 72, 75, 78, 81, 84, 87, 90, 93, 96, 99, 102, 105, 108, 111, 114, 117, 120, 123, 126, 129, 132, 135, 138, 141, 144, 147, 150, 153, 156, 159, 162, 165, 168, 171, 174, 177, 180, 183, 186, 189);
        }
#else
            get;
        } = Vector512.Create((byte)0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45, 48, 51, 54, 57, 60, 63, 66, 69, 72, 75, 78, 81, 84, 87, 90, 93, 96, 99, 102, 105, 108, 111, 114, 117, 120, 123, 126, 129, 132, 135, 138, 141, 144, 147, 150, 153, 156, 159, 162, 165, 168, 171, 174, 177, 180, 183, 186, 189);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of X - Sub part2 combine 0|1.</summary>
        public static Vector512<byte> YGroup3Unzip_Shuffle_Byte_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46, 49, 52, 55, 58, 61);
        }
#else
            get;
        } = Vector512.Create((byte)64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46, 49, 52, 55, 58, 61);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Y.</summary>
        public static Vector512<byte> YGroup3Unzip_Shuffle_Byte_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46, 49, 52, 55, 58, 61, 64, 67, 70, 73, 76, 79, 82, 85, 88, 91, 94, 97, 100, 103, 106, 109, 112, 115, 118, 121, 124, 127, 130, 133, 136, 139, 142, 145, 148, 151, 154, 157, 160, 163, 166, 169, 172, 175, 178, 181, 184, 187, 190);
        }
#else
            get;
        } = Vector512.Create((byte)1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46, 49, 52, 55, 58, 61, 64, 67, 70, 73, 76, 79, 82, 85, 88, 91, 94, 97, 100, 103, 106, 109, 112, 115, 118, 121, 124, 127, 130, 133, 136, 139, 142, 145, 148, 151, 154, 157, 160, 163, 166, 169, 172, 175, 178, 181, 184, 187, 190);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Y - Sub part2 combine 0|1.</summary>
        public static Vector512<byte> YGroup3Unzip_Shuffle_Byte_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38, 41, 44, 47, 50, 53, 56, 59, 62);
        }
#else
            get;
        } = Vector512.Create((byte)64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38, 41, 44, 47, 50, 53, 56, 59, 62);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Z.</summary>
        public static Vector512<byte> YGroup3Unzip_Shuffle_Byte_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38, 41, 44, 47, 50, 53, 56, 59, 62, 65, 68, 71, 74, 77, 80, 83, 86, 89, 92, 95, 98, 101, 104, 107, 110, 113, 116, 119, 122, 125, 128, 131, 134, 137, 140, 143, 146, 149, 152, 155, 158, 161, 164, 167, 170, 173, 176, 179, 182, 185, 188, 191);
        }
#else
            get;
        } = Vector512.Create((byte)2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38, 41, 44, 47, 50, 53, 56, 59, 62, 65, 68, 71, 74, 77, 80, 83, 86, 89, 92, 95, 98, 101, 104, 107, 110, 113, 116, 119, 122, 125, 128, 131, 134, 137, 140, 143, 146, 149, 152, 155, 158, 161, 164, 167, 170, 173, 176, 179, 182, 185, 188, 191);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Z - Sub part2 combine 0|1.</summary>
        public static Vector512<byte> YGroup3Unzip_Shuffle_Byte_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45, 48, 51, 54, 57, 60, 63);
        }
#else
            get;
        } = Vector512.Create((byte)64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45, 48, 51, 54, 57, 60, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt16 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup3Unzip_Shuffle_UInt16_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45, 48, 51, 54, 57, 60, 63, 66, 69, 72, 75, 78, 81, 84, 87, 90, 93);
        }
#else
            get;
        } = Vector512.Create((ushort)0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45, 48, 51, 54, 57, 60, 63, 66, 69, 72, 75, 78, 81, 84, 87, 90, 93);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt16 - The index of X - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup3Unzip_Shuffle_UInt16_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 2, 5, 8, 11, 14, 17, 20, 23, 26, 29);
        }
#else
            get;
        } = Vector512.Create((ushort)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 2, 5, 8, 11, 14, 17, 20, 23, 26, 29);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt16 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup3Unzip_Shuffle_UInt16_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46, 49, 52, 55, 58, 61, 64, 67, 70, 73, 76, 79, 82, 85, 88, 91, 94);
        }
#else
            get;
        } = Vector512.Create((ushort)1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46, 49, 52, 55, 58, 61, 64, 67, 70, 73, 76, 79, 82, 85, 88, 91, 94);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt16 - The index of Y - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup3Unzip_Shuffle_UInt16_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30);
        }
#else
            get;
        } = Vector512.Create((ushort)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt16 - The index of Z.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup3Unzip_Shuffle_UInt16_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38, 41, 44, 47, 50, 53, 56, 59, 62, 65, 68, 71, 74, 77, 80, 83, 86, 89, 92, 95);
        }
#else
            get;
        } = Vector512.Create((ushort)2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38, 41, 44, 47, 50, 53, 56, 59, 62, 65, 68, 71, 74, 77, 80, 83, 86, 89, 92, 95);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt16 - The index of Z - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup3Unzip_Shuffle_UInt16_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31);
        }
#else
            get;
        } = Vector512.Create((ushort)32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt32 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup3Unzip_Shuffle_UInt32_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45);
        }
#else
            get;
        } = Vector512.Create((uint)0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt32 - The index of X - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup3Unzip_Shuffle_UInt32_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 1, 4, 7, 10, 13);
        }
#else
            get;
        } = Vector512.Create((uint)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 1, 4, 7, 10, 13);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt32 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup3Unzip_Shuffle_UInt32_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46);
        }
#else
            get;
        } = Vector512.Create((uint)1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt32 - The index of Y - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup3Unzip_Shuffle_UInt32_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 2, 5, 8, 11, 14);
        }
#else
            get;
        } = Vector512.Create((uint)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 2, 5, 8, 11, 14);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt32 - The index of Z.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup3Unzip_Shuffle_UInt32_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38, 41, 44, 47);
        }
#else
            get;
        } = Vector512.Create((uint)2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38, 41, 44, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt32 - The index of Z - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup3Unzip_Shuffle_UInt32_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 0, 3, 6, 9, 12, 15);
        }
#else
            get;
        } = Vector512.Create((uint)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 0, 3, 6, 9, 12, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt64 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup3Unzip_Shuffle_UInt64_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)0, 3, 6, 9, 12, 15, 18, 21);
        }
#else
            get;
        } = Vector512.Create((ulong)0, 3, 6, 9, 12, 15, 18, 21);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt64 - The index of X - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup3Unzip_Shuffle_UInt64_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)8, 9, 10, 11, 12, 13, 2, 5);
        }
#else
            get;
        } = Vector512.Create((ulong)8, 9, 10, 11, 12, 13, 2, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt64 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup3Unzip_Shuffle_UInt64_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)1, 4, 7, 10, 13, 16, 19, 22);
        }
#else
            get;
        } = Vector512.Create((ulong)1, 4, 7, 10, 13, 16, 19, 22);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt64 - The index of Y - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup3Unzip_Shuffle_UInt64_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)8, 9, 10, 11, 12, 0, 3, 6);
        }
#else
            get;
        } = Vector512.Create((ulong)8, 9, 10, 11, 12, 0, 3, 6);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt64 - The index of Z.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup3Unzip_Shuffle_UInt64_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)2, 5, 8, 11, 14, 17, 20, 23);
        }
#else
            get;
        } = Vector512.Create((ulong)2, 5, 8, 11, 14, 17, 20, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt64 - The index of Z - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup3Unzip_Shuffle_UInt64_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)8, 9, 10, 11, 12, 1, 4, 7);
        }
#else
            get;
        } = Vector512.Create((ulong)8, 9, 10, 11, 12, 1, 4, 7);
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup3Zip - Shuffle - Byte - The index of X.</summary>
        public static Vector512<byte> YGroup3Zip_Shuffle_Byte_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 64, 128, 1, 65, 129, 2, 66, 130, 3, 67, 131, 4, 68, 132, 5, 69, 133, 6, 70, 134, 7, 71, 135, 8, 72, 136, 9, 73, 137, 10, 74, 138, 11, 75, 139, 12, 76, 140, 13, 77, 141, 14, 78, 142, 15, 79, 143, 16, 80, 144, 17, 81, 145, 18, 82, 146, 19, 83, 147, 20, 84, 148, 21);
        }
#else
            get;
        } = Vector512.Create((byte)0, 64, 128, 1, 65, 129, 2, 66, 130, 3, 67, 131, 4, 68, 132, 5, 69, 133, 6, 70, 134, 7, 71, 135, 8, 72, 136, 9, 73, 137, 10, 74, 138, 11, 75, 139, 12, 76, 140, 13, 77, 141, 14, 78, 142, 15, 79, 143, 16, 80, 144, 17, 81, 145, 18, 82, 146, 19, 83, 147, 20, 84, 148, 21);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of X - Sub part2 combine 0|1.</summary>
        public static Vector512<byte> YGroup3Zip_Shuffle_Byte_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)64, 65, 0, 67, 68, 1, 70, 71, 2, 73, 74, 3, 76, 77, 4, 79, 80, 5, 82, 83, 6, 85, 86, 7, 88, 89, 8, 91, 92, 9, 94, 95, 10, 97, 98, 11, 100, 101, 12, 103, 104, 13, 106, 107, 14, 109, 110, 15, 112, 113, 16, 115, 116, 17, 118, 119, 18, 121, 122, 19, 124, 125, 20, 127);
        }
#else
            get;
        } = Vector512.Create((byte)64, 65, 0, 67, 68, 1, 70, 71, 2, 73, 74, 3, 76, 77, 4, 79, 80, 5, 82, 83, 6, 85, 86, 7, 88, 89, 8, 91, 92, 9, 94, 95, 10, 97, 98, 11, 100, 101, 12, 103, 104, 13, 106, 107, 14, 109, 110, 15, 112, 113, 16, 115, 116, 17, 118, 119, 18, 121, 122, 19, 124, 125, 20, 127);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of Y.</summary>
        public static Vector512<byte> YGroup3Zip_Shuffle_Byte_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)85, 149, 22, 86, 150, 23, 87, 151, 24, 88, 152, 25, 89, 153, 26, 90, 154, 27, 91, 155, 28, 92, 156, 29, 93, 157, 30, 94, 158, 31, 95, 159, 32, 96, 160, 33, 97, 161, 34, 98, 162, 35, 99, 163, 36, 100, 164, 37, 101, 165, 38, 102, 166, 39, 103, 167, 40, 104, 168, 41, 105, 169, 42, 106);
        }
#else
            get;
        } = Vector512.Create((byte)85, 149, 22, 86, 150, 23, 87, 151, 24, 88, 152, 25, 89, 153, 26, 90, 154, 27, 91, 155, 28, 92, 156, 29, 93, 157, 30, 94, 158, 31, 95, 159, 32, 96, 160, 33, 97, 161, 34, 98, 162, 35, 99, 163, 36, 100, 164, 37, 101, 165, 38, 102, 166, 39, 103, 167, 40, 104, 168, 41, 105, 169, 42, 106);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of Y - Sub part2 combine 0|1.</summary>
        public static Vector512<byte> YGroup3Zip_Shuffle_Byte_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)64, 21, 66, 67, 22, 69, 70, 23, 72, 73, 24, 75, 76, 25, 78, 79, 26, 81, 82, 27, 84, 85, 28, 87, 88, 29, 90, 91, 30, 93, 94, 31, 96, 97, 32, 99, 100, 33, 102, 103, 34, 105, 106, 35, 108, 109, 36, 111, 112, 37, 114, 115, 38, 117, 118, 39, 120, 121, 40, 123, 124, 41, 126, 127);
        }
#else
            get;
        } = Vector512.Create((byte)64, 21, 66, 67, 22, 69, 70, 23, 72, 73, 24, 75, 76, 25, 78, 79, 26, 81, 82, 27, 84, 85, 28, 87, 88, 29, 90, 91, 30, 93, 94, 31, 96, 97, 32, 99, 100, 33, 102, 103, 34, 105, 106, 35, 108, 109, 36, 111, 112, 37, 114, 115, 38, 117, 118, 39, 120, 121, 40, 123, 124, 41, 126, 127);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of Z.</summary>
        public static Vector512<byte> YGroup3Zip_Shuffle_Byte_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)170, 43, 107, 171, 44, 108, 172, 45, 109, 173, 46, 110, 174, 47, 111, 175, 48, 112, 176, 49, 113, 177, 50, 114, 178, 51, 115, 179, 52, 116, 180, 53, 117, 181, 54, 118, 182, 55, 119, 183, 56, 120, 184, 57, 121, 185, 58, 122, 186, 59, 123, 187, 60, 124, 188, 61, 125, 189, 62, 126, 190, 63, 127, 191);
        }
#else
            get;
        } = Vector512.Create((byte)170, 43, 107, 171, 44, 108, 172, 45, 109, 173, 46, 110, 174, 47, 111, 175, 48, 112, 176, 49, 113, 177, 50, 114, 178, 51, 115, 179, 52, 116, 180, 53, 117, 181, 54, 118, 182, 55, 119, 183, 56, 120, 184, 57, 121, 185, 58, 122, 186, 59, 123, 187, 60, 124, 188, 61, 125, 189, 62, 126, 190, 63, 127, 191);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of Z - Sub part2 combine 0|1.</summary>
        public static Vector512<byte> YGroup3Zip_Shuffle_Byte_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)42, 65, 66, 43, 68, 69, 44, 71, 72, 45, 74, 75, 46, 77, 78, 47, 80, 81, 48, 83, 84, 49, 86, 87, 50, 89, 90, 51, 92, 93, 52, 95, 96, 53, 98, 99, 54, 101, 102, 55, 104, 105, 56, 107, 108, 57, 110, 111, 58, 113, 114, 59, 116, 117, 60, 119, 120, 61, 122, 123, 62, 125, 126, 63);
        }
#else
            get;
        } = Vector512.Create((byte)42, 65, 66, 43, 68, 69, 44, 71, 72, 45, 74, 75, 46, 77, 78, 47, 80, 81, 48, 83, 84, 49, 86, 87, 50, 89, 90, 51, 92, 93, 52, 95, 96, 53, 98, 99, 54, 101, 102, 55, 104, 105, 56, 107, 108, 57, 110, 111, 58, 113, 114, 59, 116, 117, 60, 119, 120, 61, 122, 123, 62, 125, 126, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt16 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup3Zip_Shuffle_UInt16_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)0, 32, 64, 1, 33, 65, 2, 34, 66, 3, 35, 67, 4, 36, 68, 5, 37, 69, 6, 38, 70, 7, 39, 71, 8, 40, 72, 9, 41, 73, 10, 42);
        }
#else
            get;
        } = Vector512.Create((ushort)0, 32, 64, 1, 33, 65, 2, 34, 66, 3, 35, 67, 4, 36, 68, 5, 37, 69, 6, 38, 70, 7, 39, 71, 8, 40, 72, 9, 41, 73, 10, 42);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt16 - The index of X - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup3Zip_Shuffle_UInt16_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)32, 33, 0, 35, 36, 1, 38, 39, 2, 41, 42, 3, 44, 45, 4, 47, 48, 5, 50, 51, 6, 53, 54, 7, 56, 57, 8, 59, 60, 9, 62, 63);
        }
#else
            get;
        } = Vector512.Create((ushort)32, 33, 0, 35, 36, 1, 38, 39, 2, 41, 42, 3, 44, 45, 4, 47, 48, 5, 50, 51, 6, 53, 54, 7, 56, 57, 8, 59, 60, 9, 62, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt16 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup3Zip_Shuffle_UInt16_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)74, 11, 43, 75, 12, 44, 76, 13, 45, 77, 14, 46, 78, 15, 47, 79, 16, 48, 80, 17, 49, 81, 18, 50, 82, 19, 51, 83, 20, 52, 84, 21);
        }
#else
            get;
        } = Vector512.Create((ushort)74, 11, 43, 75, 12, 44, 76, 13, 45, 77, 14, 46, 78, 15, 47, 79, 16, 48, 80, 17, 49, 81, 18, 50, 82, 19, 51, 83, 20, 52, 84, 21);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt16 - The index of Y - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup3Zip_Shuffle_UInt16_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)10, 33, 34, 11, 36, 37, 12, 39, 40, 13, 42, 43, 14, 45, 46, 15, 48, 49, 16, 51, 52, 17, 54, 55, 18, 57, 58, 19, 60, 61, 20, 63);
        }
#else
            get;
        } = Vector512.Create((ushort)10, 33, 34, 11, 36, 37, 12, 39, 40, 13, 42, 43, 14, 45, 46, 15, 48, 49, 16, 51, 52, 17, 54, 55, 18, 57, 58, 19, 60, 61, 20, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt16 - The index of Z.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup3Zip_Shuffle_UInt16_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)53, 85, 22, 54, 86, 23, 55, 87, 24, 56, 88, 25, 57, 89, 26, 58, 90, 27, 59, 91, 28, 60, 92, 29, 61, 93, 30, 62, 94, 31, 63, 95);
        }
#else
            get;
        } = Vector512.Create((ushort)53, 85, 22, 54, 86, 23, 55, 87, 24, 56, 88, 25, 57, 89, 26, 58, 90, 27, 59, 91, 28, 60, 92, 29, 61, 93, 30, 62, 94, 31, 63, 95);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt16 - The index of Z - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup3Zip_Shuffle_UInt16_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)32, 21, 34, 35, 22, 37, 38, 23, 40, 41, 24, 43, 44, 25, 46, 47, 26, 49, 50, 27, 52, 53, 28, 55, 56, 29, 58, 59, 30, 61, 62, 31);
        }
#else
            get;
        } = Vector512.Create((ushort)32, 21, 34, 35, 22, 37, 38, 23, 40, 41, 24, 43, 44, 25, 46, 47, 26, 49, 50, 27, 52, 53, 28, 55, 56, 29, 58, 59, 30, 61, 62, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt32 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup3Zip_Shuffle_UInt32_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)0, 16, 32, 1, 17, 33, 2, 18, 34, 3, 19, 35, 4, 20, 36, 5);
        }
#else
            get;
        } = Vector512.Create((uint)0, 16, 32, 1, 17, 33, 2, 18, 34, 3, 19, 35, 4, 20, 36, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt32 - The index of X - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup3Zip_Shuffle_UInt32_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)16, 17, 0, 19, 20, 1, 22, 23, 2, 25, 26, 3, 28, 29, 4, 31);
        }
#else
            get;
        } = Vector512.Create((uint)16, 17, 0, 19, 20, 1, 22, 23, 2, 25, 26, 3, 28, 29, 4, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt32 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup3Zip_Shuffle_UInt32_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)21, 37, 6, 22, 38, 7, 23, 39, 8, 24, 40, 9, 25, 41, 10, 26);
        }
#else
            get;
        } = Vector512.Create((uint)21, 37, 6, 22, 38, 7, 23, 39, 8, 24, 40, 9, 25, 41, 10, 26);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt32 - The index of Y - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup3Zip_Shuffle_UInt32_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)16, 5, 18, 19, 6, 21, 22, 7, 24, 25, 8, 27, 28, 9, 30, 31);
        }
#else
            get;
        } = Vector512.Create((uint)16, 5, 18, 19, 6, 21, 22, 7, 24, 25, 8, 27, 28, 9, 30, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt32 - The index of Z.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup3Zip_Shuffle_UInt32_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)42, 11, 27, 43, 12, 28, 44, 13, 29, 45, 14, 30, 46, 15, 31, 47);
        }
#else
            get;
        } = Vector512.Create((uint)42, 11, 27, 43, 12, 28, 44, 13, 29, 45, 14, 30, 46, 15, 31, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt32 - The index of Z - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup3Zip_Shuffle_UInt32_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)10, 17, 18, 11, 20, 21, 12, 23, 24, 13, 26, 27, 14, 29, 30, 15);
        }
#else
            get;
        } = Vector512.Create((uint)10, 17, 18, 11, 20, 21, 12, 23, 24, 13, 26, 27, 14, 29, 30, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt64 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup3Zip_Shuffle_UInt64_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)0, 8, 16, 1, 9, 17, 2, 10);
        }
#else
            get;
        } = Vector512.Create((ulong)0, 8, 16, 1, 9, 17, 2, 10);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt64 - The index of X - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup3Zip_Shuffle_UInt64_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)8, 9, 0, 11, 12, 1, 14, 15);
        }
#else
            get;
        } = Vector512.Create((ulong)8, 9, 0, 11, 12, 1, 14, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt64 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup3Zip_Shuffle_UInt64_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)18, 3, 11, 19, 4, 12, 20, 5);
        }
#else
            get;
        } = Vector512.Create((ulong)18, 3, 11, 19, 4, 12, 20, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt64 - The index of Y - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup3Zip_Shuffle_UInt64_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)2, 9, 10, 3, 12, 13, 4, 15);
        }
#else
            get;
        } = Vector512.Create((ulong)2, 9, 10, 3, 12, 13, 4, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt64 - The index of Z.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup3Zip_Shuffle_UInt64_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)13, 21, 6, 14, 22, 7, 15, 23);
        }
#else
            get;
        } = Vector512.Create((ulong)13, 21, 6, 14, 22, 7, 15, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt64 - The index of Z - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup3Zip_Shuffle_UInt64_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)8, 5, 10, 11, 6, 13, 14, 7);
        }
#else
            get;
        } = Vector512.Create((ulong)8, 5, 10, 11, 6, 13, 14, 7);
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup4 - Mask of X,Y,Z (clear W) - Byte.</summary>
        public static Vector512<byte> YGroup4_MaskXYZ_Byte {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4 - Mask of X,Y,Z (clear W) - UInt16.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup4_MaskXYZ_UInt16 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((short)-1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0).AsUInt16();
        }
#else
            get;
        } = Vector512.Create((short)-1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0).AsUInt16();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4 - Mask of X,Y,Z (clear W) - UInt32.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup4_MaskXYZ_UInt32 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((int)-1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0).AsUInt32();
        }
#else
            get;
        } = Vector512.Create((int)-1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0).AsUInt32();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4 - Mask of X,Y,Z (clear W) - UInt64.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup4_MaskXYZ_UInt64 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((long)-1, -1, -1, 0, -1, -1, -1, 0).AsUInt64();
        }
#else
            get;
        } = Vector512.Create((long)-1, -1, -1, 0, -1, -1, -1, 0).AsUInt64();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4 - Mask of X,Y,Z (clear W) - UInt64 - Part 1 - Each 128 bits.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup4_MaskXYZ_UInt64_1_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((long)-1, 0, -1, 0, -1, 0, -1, 0).AsUInt64();
        }
#else
            get;
        } = Vector512.Create((long)-1, 0, -1, 0, -1, 0, -1, 0).AsUInt64();
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 0.</summary>
        public static Vector512<byte> YGroup4ToGroup3_Shuffle_Byte_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30, 32, 33, 34, 36, 37, 38, 40, 41, 42, 44, 45, 46, 48, 49, 50, 52, 53, 54, 56, 57, 58, 60, 61, 62, 64, 65, 66, 68, 69, 70, 72, 73, 74, 76, 77, 78, 80, 81, 82, 84);
        }
#else
            get;
        } = Vector512.Create((byte)0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30, 32, 33, 34, 36, 37, 38, 40, 41, 42, 44, 45, 46, 48, 49, 50, 52, 53, 54, 56, 57, 58, 60, 61, 62, 64, 65, 66, 68, 69, 70, 72, 73, 74, 76, 77, 78, 80, 81, 82, 84);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 0 - Sub part0.</summary>
        public static Vector512<byte> YGroup4ToGroup3_Shuffle_Byte_0A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30, 32, 33, 34, 36, 37, 38, 40, 41, 42, 44, 45, 46, 48, 49, 50, 52, 53, 54, 56, 57, 58, 60, 61, 62, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30, 32, 33, 34, 36, 37, 38, 40, 41, 42, 44, 45, 46, 48, 49, 50, 52, 53, 54, 56, 57, 58, 60, 61, 62, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 0 - Sub part1.</summary>
        public static Vector512<byte> YGroup4ToGroup3_Shuffle_Byte_0B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 0 - Sub part0 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup4ToGroup3_Shuffle_Byte_0A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 0 - Sub part1 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup4ToGroup3_Shuffle_Byte_0B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 1.</summary>
        public static Vector512<byte> YGroup4ToGroup3_Shuffle_Byte_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)21, 22, 24, 25, 26, 28, 29, 30, 32, 33, 34, 36, 37, 38, 40, 41, 42, 44, 45, 46, 48, 49, 50, 52, 53, 54, 56, 57, 58, 60, 61, 62, 64, 65, 66, 68, 69, 70, 72, 73, 74, 76, 77, 78, 80, 81, 82, 84, 85, 86, 88, 89, 90, 92, 93, 94, 96, 97, 98, 100, 101, 102, 104, 105);
        }
#else
            get;
        } = Vector512.Create((byte)21, 22, 24, 25, 26, 28, 29, 30, 32, 33, 34, 36, 37, 38, 40, 41, 42, 44, 45, 46, 48, 49, 50, 52, 53, 54, 56, 57, 58, 60, 61, 62, 64, 65, 66, 68, 69, 70, 72, 73, 74, 76, 77, 78, 80, 81, 82, 84, 85, 86, 88, 89, 90, 92, 93, 94, 96, 97, 98, 100, 101, 102, 104, 105);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 1 - Sub part0.</summary>
        public static Vector512<byte> YGroup4ToGroup3_Shuffle_Byte_1A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)21, 22, 24, 25, 26, 28, 29, 30, 32, 33, 34, 36, 37, 38, 40, 41, 42, 44, 45, 46, 48, 49, 50, 52, 53, 54, 56, 57, 58, 60, 61, 62, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)21, 22, 24, 25, 26, 28, 29, 30, 32, 33, 34, 36, 37, 38, 40, 41, 42, 44, 45, 46, 48, 49, 50, 52, 53, 54, 56, 57, 58, 60, 61, 62, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 1 - Sub part1.</summary>
        public static Vector512<byte> YGroup4ToGroup3_Shuffle_Byte_1B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30, 32, 33, 34, 36, 37, 38, 40, 41).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30, 32, 33, 34, 36, 37, 38, 40, 41).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 1 - Sub part0 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup4ToGroup3_Shuffle_Byte_1A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, -1, -1, -1, -1, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, -1, -1, -1, -1, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, -1, -1, -1, -1, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, -1, -1, -1, -1, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, -1, -1, -1, -1, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, -1, -1, -1, -1, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 1 - Sub part1 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup4ToGroup3_Shuffle_Byte_1B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 2.</summary>
        public static Vector512<byte> YGroup4ToGroup3_Shuffle_Byte_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)42, 44, 45, 46, 48, 49, 50, 52, 53, 54, 56, 57, 58, 60, 61, 62, 64, 65, 66, 68, 69, 70, 72, 73, 74, 76, 77, 78, 80, 81, 82, 84, 85, 86, 88, 89, 90, 92, 93, 94, 96, 97, 98, 100, 101, 102, 104, 105, 106, 108, 109, 110, 112, 113, 114, 116, 117, 118, 120, 121, 122, 124, 125, 126);
        }
#else
            get;
        } = Vector512.Create((byte)42, 44, 45, 46, 48, 49, 50, 52, 53, 54, 56, 57, 58, 60, 61, 62, 64, 65, 66, 68, 69, 70, 72, 73, 74, 76, 77, 78, 80, 81, 82, 84, 85, 86, 88, 89, 90, 92, 93, 94, 96, 97, 98, 100, 101, 102, 104, 105, 106, 108, 109, 110, 112, 113, 114, 116, 117, 118, 120, 121, 122, 124, 125, 126);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 2 - Sub part0.</summary>
        public static Vector512<byte> YGroup4ToGroup3_Shuffle_Byte_2A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)42, 44, 45, 46, 48, 49, 50, 52, 53, 54, 56, 57, 58, 60, 61, 62, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)42, 44, 45, 46, 48, 49, 50, 52, 53, 54, 56, 57, 58, 60, 61, 62, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 2 - Sub part1.</summary>
        public static Vector512<byte> YGroup4ToGroup3_Shuffle_Byte_2B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30, 32, 33, 34, 36, 37, 38, 40, 41, 42, 44, 45, 46, 48, 49, 50, 52, 53, 54, 56, 57, 58, 60, 61, 62).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30, 32, 33, 34, 36, 37, 38, 40, 41, 42, 44, 45, 46, 48, 49, 50, 52, 53, 54, 56, 57, 58, 60, 61, 62).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 2 - Sub part0 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup4ToGroup3_Shuffle_Byte_2A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)10, 12, 13, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 10, 12, 13, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 10, 12, 13, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 10, 12, 13, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)10, 12, 13, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 10, 12, 13, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 10, 12, 13, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 10, 12, 13, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - Byte - The index of item 2 - Sub part1 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup4ToGroup3_Shuffle_Byte_2B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, -1, -1, -1, -1, 0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - UInt16 - The index of item 0.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup4ToGroup3_Shuffle_UInt16_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30, 32, 33, 34, 36, 37, 38, 40, 41);
        }
#else
            get;
        } = Vector512.Create((ushort)0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30, 32, 33, 34, 36, 37, 38, 40, 41);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - UInt16 - The index of item 1.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup4ToGroup3_Shuffle_UInt16_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30, 32, 33, 34, 36, 37, 38, 40, 41, 42, 44, 45, 46, 48, 49, 50, 52);
        }
#else
            get;
        } = Vector512.Create((ushort)10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30, 32, 33, 34, 36, 37, 38, 40, 41, 42, 44, 45, 46, 48, 49, 50, 52);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - UInt16 - The index of item 2.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup4ToGroup3_Shuffle_UInt16_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)21, 22, 24, 25, 26, 28, 29, 30, 32, 33, 34, 36, 37, 38, 40, 41, 42, 44, 45, 46, 48, 49, 50, 52, 53, 54, 56, 57, 58, 60, 61, 62);
        }
#else
            get;
        } = Vector512.Create((ushort)21, 22, 24, 25, 26, 28, 29, 30, 32, 33, 34, 36, 37, 38, 40, 41, 42, 44, 45, 46, 48, 49, 50, 52, 53, 54, 56, 57, 58, 60, 61, 62);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - UInt32 - The index of item 0.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup4ToGroup3_Shuffle_UInt32_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20);
        }
#else
            get;
        } = Vector512.Create((uint)0, 1, 2, 4, 5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - UInt32 - The index of item 1.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup4ToGroup3_Shuffle_UInt32_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25);
        }
#else
            get;
        } = Vector512.Create((uint)5, 6, 8, 9, 10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - UInt32 - The index of item 2.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup4ToGroup3_Shuffle_UInt32_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30);
        }
#else
            get;
        } = Vector512.Create((uint)10, 12, 13, 14, 16, 17, 18, 20, 21, 22, 24, 25, 26, 28, 29, 30);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - UInt64 - The index of item 0.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup4ToGroup3_Shuffle_UInt64_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)0, 1, 2, 4, 5, 6, 8, 9);
        }
#else
            get;
        } = Vector512.Create((ulong)0, 1, 2, 4, 5, 6, 8, 9);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - UInt64 - The index of item 1.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup4ToGroup3_Shuffle_UInt64_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)2, 4, 5, 6, 8, 9, 10, 12);
        }
#else
            get;
        } = Vector512.Create((ulong)2, 4, 5, 6, 8, 9, 10, 12);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle - UInt64 - The index of item 2.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup4ToGroup3_Shuffle_UInt64_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)5, 6, 8, 9, 10, 12, 13, 14);
        }
#else
            get;
        } = Vector512.Create((ulong)5, 6, 8, 9, 10, 12, 13, 14);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 0.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, 16, 17, 18, 19, 20, 21, 24, 25, 26, 27, 28, 29, 32, 33, 34, 35, 36, 37, 40, 41, 42, 43, 44, 45, 48, 49, 50, 51, 52, 53, 56, 57, 58, 59, 60, 61, 64, 65, 66, 67, 68, 69, 72, 73, 74, 75, 76, 77, 80, 81, 82, 83);
        }
#else
            get;
        } = Vector512.Create((byte)0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, 16, 17, 18, 19, 20, 21, 24, 25, 26, 27, 28, 29, 32, 33, 34, 35, 36, 37, 40, 41, 42, 43, 44, 45, 48, 49, 50, 51, 52, 53, 56, 57, 58, 59, 60, 61, 64, 65, 66, 67, 68, 69, 72, 73, 74, 75, 76, 77, 80, 81, 82, 83);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 0 - Sub part0.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_0A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, 16, 17, 18, 19, 20, 21, 24, 25, 26, 27, 28, 29, 32, 33, 34, 35, 36, 37, 40, 41, 42, 43, 44, 45, 48, 49, 50, 51, 52, 53, 56, 57, 58, 59, 60, 61, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, 16, 17, 18, 19, 20, 21, 24, 25, 26, 27, 28, 29, 32, 33, 34, 35, 36, 37, 40, 41, 42, 43, 44, 45, 48, 49, 50, 51, 52, 53, 56, 57, 58, 59, 60, 61, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 0 - Sub part1.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_0B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, 16, 17, 18, 19).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, 16, 17, 18, 19).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 0 - Sub part0 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_0A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 0 - Sub part1 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_0B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 1.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)20, 21, 24, 25, 26, 27, 28, 29, 32, 33, 34, 35, 36, 37, 40, 41, 42, 43, 44, 45, 48, 49, 50, 51, 52, 53, 56, 57, 58, 59, 60, 61, 64, 65, 66, 67, 68, 69, 72, 73, 74, 75, 76, 77, 80, 81, 82, 83, 84, 85, 88, 89, 90, 91, 92, 93, 96, 97, 98, 99, 100, 101, 104, 105);
        }
#else
            get;
        } = Vector512.Create((byte)20, 21, 24, 25, 26, 27, 28, 29, 32, 33, 34, 35, 36, 37, 40, 41, 42, 43, 44, 45, 48, 49, 50, 51, 52, 53, 56, 57, 58, 59, 60, 61, 64, 65, 66, 67, 68, 69, 72, 73, 74, 75, 76, 77, 80, 81, 82, 83, 84, 85, 88, 89, 90, 91, 92, 93, 96, 97, 98, 99, 100, 101, 104, 105);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 1 - Sub part0.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_1A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)20, 21, 24, 25, 26, 27, 28, 29, 32, 33, 34, 35, 36, 37, 40, 41, 42, 43, 44, 45, 48, 49, 50, 51, 52, 53, 56, 57, 58, 59, 60, 61, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)20, 21, 24, 25, 26, 27, 28, 29, 32, 33, 34, 35, 36, 37, 40, 41, 42, 43, 44, 45, 48, 49, 50, 51, 52, 53, 56, 57, 58, 59, 60, 61, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 1 - Sub part1.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_1B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, 16, 17, 18, 19, 20, 21, 24, 25, 26, 27, 28, 29, 32, 33, 34, 35, 36, 37, 40, 41).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, 16, 17, 18, 19, 20, 21, 24, 25, 26, 27, 28, 29, 32, 33, 34, 35, 36, 37, 40, 41).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 1 - Sub part0 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_1A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 1 - Sub part1 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_1B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 2.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)42, 43, 44, 45, 48, 49, 50, 51, 52, 53, 56, 57, 58, 59, 60, 61, 64, 65, 66, 67, 68, 69, 72, 73, 74, 75, 76, 77, 80, 81, 82, 83, 84, 85, 88, 89, 90, 91, 92, 93, 96, 97, 98, 99, 100, 101, 104, 105, 106, 107, 108, 109, 112, 113, 114, 115, 116, 117, 120, 121, 122, 123, 124, 125);
        }
#else
            get;
        } = Vector512.Create((byte)42, 43, 44, 45, 48, 49, 50, 51, 52, 53, 56, 57, 58, 59, 60, 61, 64, 65, 66, 67, 68, 69, 72, 73, 74, 75, 76, 77, 80, 81, 82, 83, 84, 85, 88, 89, 90, 91, 92, 93, 96, 97, 98, 99, 100, 101, 104, 105, 106, 107, 108, 109, 112, 113, 114, 115, 116, 117, 120, 121, 122, 123, 124, 125);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 2 - Sub part0.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_2A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)42, 43, 44, 45, 48, 49, 50, 51, 52, 53, 56, 57, 58, 59, 60, 61, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)42, 43, 44, 45, 48, 49, 50, 51, 52, 53, 56, 57, 58, 59, 60, 61, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 2 - Sub part1.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_2B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, 16, 17, 18, 19, 20, 21, 24, 25, 26, 27, 28, 29, 32, 33, 34, 35, 36, 37, 40, 41, 42, 43, 44, 45, 48, 49, 50, 51, 52, 53, 56, 57, 58, 59, 60, 61).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, 16, 17, 18, 19, 20, 21, 24, 25, 26, 27, 28, 29, 32, 33, 34, 35, 36, 37, 40, 41, 42, 43, 44, 45, 48, 49, 50, 51, 52, 53, 56, 57, 58, 59, 60, 61).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 2 - Sub part0 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_2A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)10, 11, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 10, 11, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 10, 11, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 10, 11, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)10, 11, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 10, 11, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 10, 11, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 10, 11, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt16 - The index of item 2 - Sub part1 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt16_2B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 8, 9, 10, 11, 12, 13).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 0.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 80, 81, 82, 83);
        }
#else
            get;
        } = Vector512.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 80, 81, 82, 83);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 0 - Sub part0.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_0A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 0 - Sub part1.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_0B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 16, 17, 18, 19).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 16, 17, 18, 19).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 0 - Sub part0 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_0A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 0 - Sub part1 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_0B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 1.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)20, 21, 22, 23, 24, 25, 26, 27, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 96, 97, 98, 99, 100, 101, 102, 103);
        }
#else
            get;
        } = Vector512.Create((byte)20, 21, 22, 23, 24, 25, 26, 27, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 96, 97, 98, 99, 100, 101, 102, 103);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 1 - Sub part0.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_1A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)20, 21, 22, 23, 24, 25, 26, 27, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)20, 21, 22, 23, 24, 25, 26, 27, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 1 - Sub part1.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_1B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 32, 33, 34, 35, 36, 37, 38, 39).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 32, 33, 34, 35, 36, 37, 38, 39).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 1 - Sub part0 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_1A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 1 - Sub part1 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_1B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 2.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)40, 41, 42, 43, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123);
        }
#else
            get;
        } = Vector512.Create((byte)40, 41, 42, 43, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 2 - Sub part0.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_2A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)40, 41, 42, 43, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)40, 41, 42, 43, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 2 - Sub part1.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_2B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 2 - Sub part0 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_2A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt32 - The index of item 2 - Sub part1 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt32_2B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 0.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79);
        }
#else
            get;
        } = Vector512.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 0 - Sub part0.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_0A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 0 - Sub part1.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_0B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 1.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 96, 97, 98, 99, 100, 101, 102, 103);
        }
#else
            get;
        } = Vector512.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 96, 97, 98, 99, 100, 101, 102, 103);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 1 - Sub part0.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_1A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)16, 17, 18, 19, 20, 21, 22, 23, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)16, 17, 18, 19, 20, 21, 22, 23, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 1 - Sub part1.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_1B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 32, 33, 34, 35, 36, 37, 38, 39).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 32, 33, 34, 35, 36, 37, 38, 39).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 1 - Sub part0 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_1A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 1 - Sub part1 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_1B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 2.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119);
        }
#else
            get;
        } = Vector512.Create((byte)40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 2 - Sub part0.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_2A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 2 - Sub part1.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_2B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 2 - Sub part0 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_2A_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4ToGroup3 - Shuffle on byte - UInt64 - The index of item 2 - Sub part1 - Each 128 bits.</summary>
        public static Vector512<byte> YGroup4ToGroup3_ShuffleOnByte_UInt64_2B_Each128 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector512.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup4Unzip - ShuffleX2 - Byte - The index of X.</summary>
        public static Vector512<byte> YGroup4Unzip_ShuffleX2_Byte_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60, 64, 68, 72, 76, 80, 84, 88, 92, 96, 100, 104, 108, 112, 116, 120, 124, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        }
#else
            get;
        } = Vector512.Create((byte)0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60, 64, 68, 72, 76, 80, 84, 88, 92, 96, 100, 104, 108, 112, 116, 120, 124, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 - Byte - The index of Y.</summary>
        public static Vector512<byte> YGroup4Unzip_ShuffleX2_Byte_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57, 61, 65, 69, 73, 77, 81, 85, 89, 93, 97, 101, 105, 109, 113, 117, 121, 125, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        }
#else
            get;
        } = Vector512.Create((byte)1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57, 61, 65, 69, 73, 77, 81, 85, 89, 93, 97, 101, 105, 109, 113, 117, 121, 125, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 - Byte - The index of Z.</summary>
        public static Vector512<byte> YGroup4Unzip_ShuffleX2_Byte_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)2, 6, 10, 14, 18, 22, 26, 30, 34, 38, 42, 46, 50, 54, 58, 62, 66, 70, 74, 78, 82, 86, 90, 94, 98, 102, 106, 110, 114, 118, 122, 126, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        }
#else
            get;
        } = Vector512.Create((byte)2, 6, 10, 14, 18, 22, 26, 30, 34, 38, 42, 46, 50, 54, 58, 62, 66, 70, 74, 78, 82, 86, 90, 94, 98, 102, 106, 110, 114, 118, 122, 126, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 - Byte - The index of W.</summary>
        public static Vector512<byte> YGroup4Unzip_ShuffleX2_Byte_W {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)3, 7, 11, 15, 19, 23, 27, 31, 35, 39, 43, 47, 51, 55, 59, 63, 67, 71, 75, 79, 83, 87, 91, 95, 99, 103, 107, 111, 115, 119, 123, 127, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        }
#else
            get;
        } = Vector512.Create((byte)3, 7, 11, 15, 19, 23, 27, 31, 35, 39, 43, 47, 51, 55, 59, 63, 67, 71, 75, 79, 83, 87, 91, 95, 99, 103, 107, 111, 115, 119, 123, 127, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 - UInt16 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup4Unzip_ShuffleX2_UInt16_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        }
#else
            get;
        } = Vector512.Create((ushort)0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 - UInt16 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup4Unzip_ShuffleX2_UInt16_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        }
#else
            get;
        } = Vector512.Create((ushort)1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57, 61, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 - UInt16 - The index of Z.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup4Unzip_ShuffleX2_UInt16_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)2, 6, 10, 14, 18, 22, 26, 30, 34, 38, 42, 46, 50, 54, 58, 62, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        }
#else
            get;
        } = Vector512.Create((ushort)2, 6, 10, 14, 18, 22, 26, 30, 34, 38, 42, 46, 50, 54, 58, 62, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 - UInt16 - The index of W.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup4Unzip_ShuffleX2_UInt16_W {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)3, 7, 11, 15, 19, 23, 27, 31, 35, 39, 43, 47, 51, 55, 59, 63, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        }
#else
            get;
        } = Vector512.Create((ushort)3, 7, 11, 15, 19, 23, 27, 31, 35, 39, 43, 47, 51, 55, 59, 63, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 - UInt32 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup4Unzip_ShuffleX2_UInt32_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)0, 4, 8, 12, 16, 20, 24, 28, 0, 0, 0, 0, 0, 0, 0, 0);
        }
#else
            get;
        } = Vector512.Create((uint)0, 4, 8, 12, 16, 20, 24, 28, 0, 0, 0, 0, 0, 0, 0, 0);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 - UInt32 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup4Unzip_ShuffleX2_UInt32_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)1, 5, 9, 13, 17, 21, 25, 29, 0, 0, 0, 0, 0, 0, 0, 0);
        }
#else
            get;
        } = Vector512.Create((uint)1, 5, 9, 13, 17, 21, 25, 29, 0, 0, 0, 0, 0, 0, 0, 0);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 - UInt32 - The index of Z.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup4Unzip_ShuffleX2_UInt32_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)2, 6, 10, 14, 18, 22, 26, 30, 0, 0, 0, 0, 0, 0, 0, 0);
        }
#else
            get;
        } = Vector512.Create((uint)2, 6, 10, 14, 18, 22, 26, 30, 0, 0, 0, 0, 0, 0, 0, 0);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 - UInt32 - The index of W.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup4Unzip_ShuffleX2_UInt32_W {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)3, 7, 11, 15, 19, 23, 27, 31, 0, 0, 0, 0, 0, 0, 0, 0);
        }
#else
            get;
        } = Vector512.Create((uint)3, 7, 11, 15, 19, 23, 27, 31, 0, 0, 0, 0, 0, 0, 0, 0);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 - UInt64 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup4Unzip_ShuffleX2_UInt64_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)0, 4, 8, 12, 0, 0, 0, 0);
        }
#else
            get;
        } = Vector512.Create((ulong)0, 4, 8, 12, 0, 0, 0, 0);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 - UInt64 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup4Unzip_ShuffleX2_UInt64_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)1, 5, 9, 13, 0, 0, 0, 0);
        }
#else
            get;
        } = Vector512.Create((ulong)1, 5, 9, 13, 0, 0, 0, 0);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 - UInt64 - The index of Z.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup4Unzip_ShuffleX2_UInt64_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)2, 6, 10, 14, 0, 0, 0, 0);
        }
#else
            get;
        } = Vector512.Create((ulong)2, 6, 10, 14, 0, 0, 0, 0);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 - UInt64 - The index of W.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup4Unzip_ShuffleX2_UInt64_W {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)3, 7, 11, 15, 0, 0, 0, 0);
        }
#else
            get;
        } = Vector512.Create((ulong)3, 7, 11, 15, 0, 0, 0, 0);
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup2Zip - ShuffleX2 - Byte - The index of data0.</summary>
        public static Vector512<byte> YGroup2Zip_ShuffleX2_Byte_Data0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 64, 1, 65, 2, 66, 3, 67, 4, 68, 5, 69, 6, 70, 7, 71, 8, 72, 9, 73, 10, 74, 11, 75, 12, 76, 13, 77, 14, 78, 15, 79, 16, 80, 17, 81, 18, 82, 19, 83, 20, 84, 21, 85, 22, 86, 23, 87, 24, 88, 25, 89, 26, 90, 27, 91, 28, 92, 29, 93, 30, 94, 31, 95);
        }
#else
            get;
        } = Vector512.Create((byte)0, 64, 1, 65, 2, 66, 3, 67, 4, 68, 5, 69, 6, 70, 7, 71, 8, 72, 9, 73, 10, 74, 11, 75, 12, 76, 13, 77, 14, 78, 15, 79, 16, 80, 17, 81, 18, 82, 19, 83, 20, 84, 21, 85, 22, 86, 23, 87, 24, 88, 25, 89, 26, 90, 27, 91, 28, 92, 29, 93, 30, 94, 31, 95);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - Byte - The index of data1.</summary>
        public static Vector512<byte> YGroup2Zip_ShuffleX2_Byte_Data1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)32, 96, 33, 97, 34, 98, 35, 99, 36, 100, 37, 101, 38, 102, 39, 103, 40, 104, 41, 105, 42, 106, 43, 107, 44, 108, 45, 109, 46, 110, 47, 111, 48, 112, 49, 113, 50, 114, 51, 115, 52, 116, 53, 117, 54, 118, 55, 119, 56, 120, 57, 121, 58, 122, 59, 123, 60, 124, 61, 125, 62, 126, 63, 127);
        }
#else
            get;
        } = Vector512.Create((byte)32, 96, 33, 97, 34, 98, 35, 99, 36, 100, 37, 101, 38, 102, 39, 103, 40, 104, 41, 105, 42, 106, 43, 107, 44, 108, 45, 109, 46, 110, 47, 111, 48, 112, 49, 113, 50, 114, 51, 115, 52, 116, 53, 117, 54, 118, 55, 119, 56, 120, 57, 121, 58, 122, 59, 123, 60, 124, 61, 125, 62, 126, 63, 127);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt16 - The index of data0.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup2Zip_ShuffleX2_UInt16_Data0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)0, 32, 1, 33, 2, 34, 3, 35, 4, 36, 5, 37, 6, 38, 7, 39, 8, 40, 9, 41, 10, 42, 11, 43, 12, 44, 13, 45, 14, 46, 15, 47);
        }
#else
            get;
        } = Vector512.Create((ushort)0, 32, 1, 33, 2, 34, 3, 35, 4, 36, 5, 37, 6, 38, 7, 39, 8, 40, 9, 41, 10, 42, 11, 43, 12, 44, 13, 45, 14, 46, 15, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt16 - The index of data1.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup2Zip_ShuffleX2_UInt16_Data1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)16, 48, 17, 49, 18, 50, 19, 51, 20, 52, 21, 53, 22, 54, 23, 55, 24, 56, 25, 57, 26, 58, 27, 59, 28, 60, 29, 61, 30, 62, 31, 63);
        }
#else
            get;
        } = Vector512.Create((ushort)16, 48, 17, 49, 18, 50, 19, 51, 20, 52, 21, 53, 22, 54, 23, 55, 24, 56, 25, 57, 26, 58, 27, 59, 28, 60, 29, 61, 30, 62, 31, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt32 - The index of data0.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup2Zip_ShuffleX2_UInt32_Data0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)0, 16, 1, 17, 2, 18, 3, 19, 4, 20, 5, 21, 6, 22, 7, 23);
        }
#else
            get;
        } = Vector512.Create((uint)0, 16, 1, 17, 2, 18, 3, 19, 4, 20, 5, 21, 6, 22, 7, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt32 - The index of data1.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup2Zip_ShuffleX2_UInt32_Data1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)8, 24, 9, 25, 10, 26, 11, 27, 12, 28, 13, 29, 14, 30, 15, 31);
        }
#else
            get;
        } = Vector512.Create((uint)8, 24, 9, 25, 10, 26, 11, 27, 12, 28, 13, 29, 14, 30, 15, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt64 - The index of data0.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup2Zip_ShuffleX2_UInt64_Data0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)0, 8, 1, 9, 2, 10, 3, 11);
        }
#else
            get;
        } = Vector512.Create((ulong)0, 8, 1, 9, 2, 10, 3, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt64 - The index of data1.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup2Zip_ShuffleX2_UInt64_Data1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)4, 12, 5, 13, 6, 14, 7, 15);
        }
#else
            get;
        } = Vector512.Create((ulong)4, 12, 5, 13, 6, 14, 7, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt128 on 64bit - The index of data0.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup2Zip_ShuffleX2_UInt128_On64_Data0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)0, 1, 8, 9, 2, 3, 10, 11);
        }
#else
            get;
        } = Vector512.Create((ulong)0, 1, 8, 9, 2, 3, 10, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt128 on 64bit - The index of data1.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup2Zip_ShuffleX2_UInt128_On64_Data1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)4, 5, 12, 13, 6, 7, 14, 15);
        }
#else
            get;
        } = Vector512.Create((ulong)4, 5, 12, 13, 6, 7, 14, 15);
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup4Unzip - ShuffleX2 Longer - Byte - The index of X/Y.</summary>
        public static Vector512<byte> YGroup4Unzip_ShuffleX2Longer_Byte_XY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60, 64, 68, 72, 76, 80, 84, 88, 92, 96, 100, 104, 108, 112, 116, 120, 124, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57, 61, 65, 69, 73, 77, 81, 85, 89, 93, 97, 101, 105, 109, 113, 117, 121, 125);
        }
#else
            get;
        } = Vector512.Create((byte)0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60, 64, 68, 72, 76, 80, 84, 88, 92, 96, 100, 104, 108, 112, 116, 120, 124, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57, 61, 65, 69, 73, 77, 81, 85, 89, 93, 97, 101, 105, 109, 113, 117, 121, 125);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 Longer - Byte - The index of Z/W.</summary>
        public static Vector512<byte> YGroup4Unzip_ShuffleX2Longer_Byte_ZW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)2, 6, 10, 14, 18, 22, 26, 30, 34, 38, 42, 46, 50, 54, 58, 62, 66, 70, 74, 78, 82, 86, 90, 94, 98, 102, 106, 110, 114, 118, 122, 126, 3, 7, 11, 15, 19, 23, 27, 31, 35, 39, 43, 47, 51, 55, 59, 63, 67, 71, 75, 79, 83, 87, 91, 95, 99, 103, 107, 111, 115, 119, 123, 127);
        }
#else
            get;
        } = Vector512.Create((byte)2, 6, 10, 14, 18, 22, 26, 30, 34, 38, 42, 46, 50, 54, 58, 62, 66, 70, 74, 78, 82, 86, 90, 94, 98, 102, 106, 110, 114, 118, 122, 126, 3, 7, 11, 15, 19, 23, 27, 31, 35, 39, 43, 47, 51, 55, 59, 63, 67, 71, 75, 79, 83, 87, 91, 95, 99, 103, 107, 111, 115, 119, 123, 127);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 Longer - UInt16 - The index of X/Y.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup4Unzip_ShuffleX2Longer_UInt16_XY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57, 61);
        }
#else
            get;
        } = Vector512.Create((ushort)0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60, 1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57, 61);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 Longer - UInt16 - The index of Z/W.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup4Unzip_ShuffleX2Longer_UInt16_ZW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)2, 6, 10, 14, 18, 22, 26, 30, 34, 38, 42, 46, 50, 54, 58, 62, 3, 7, 11, 15, 19, 23, 27, 31, 35, 39, 43, 47, 51, 55, 59, 63);
        }
#else
            get;
        } = Vector512.Create((ushort)2, 6, 10, 14, 18, 22, 26, 30, 34, 38, 42, 46, 50, 54, 58, 62, 3, 7, 11, 15, 19, 23, 27, 31, 35, 39, 43, 47, 51, 55, 59, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 Longer - UInt32 - The index of X/Y.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup4Unzip_ShuffleX2Longer_UInt32_XY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)0, 4, 8, 12, 16, 20, 24, 28, 1, 5, 9, 13, 17, 21, 25, 29);
        }
#else
            get;
        } = Vector512.Create((uint)0, 4, 8, 12, 16, 20, 24, 28, 1, 5, 9, 13, 17, 21, 25, 29);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 Longer - UInt32 - The index of Z/W.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup4Unzip_ShuffleX2Longer_UInt32_ZW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)2, 6, 10, 14, 18, 22, 26, 30, 3, 7, 11, 15, 19, 23, 27, 31);
        }
#else
            get;
        } = Vector512.Create((uint)2, 6, 10, 14, 18, 22, 26, 30, 3, 7, 11, 15, 19, 23, 27, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 Longer - UInt64 - The index of X/Y.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup4Unzip_ShuffleX2Longer_UInt64_XY {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)0, 4, 8, 12, 1, 5, 9, 13);
        }
#else
            get;
        } = Vector512.Create((ulong)0, 4, 8, 12, 1, 5, 9, 13);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX2 Longer - UInt64 - The index of Z/W.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup4Unzip_ShuffleX2Longer_UInt64_ZW {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)2, 6, 10, 14, 3, 7, 11, 15);
        }
#else
            get;
        } = Vector512.Create((ulong)2, 6, 10, 14, 3, 7, 11, 15);
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup4Zip - ShuffleX2 Longer - Byte - The index of data0/data1.</summary>
        [CLSCompliant(false)]
        public static Vector512<byte> YGroup4Zip_ShuffleX2Longer_Byte_Data01 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)0, 32, 64, 96, 1, 33, 65, 97, 2, 34, 66, 98, 3, 35, 67, 99, 4, 36, 68, 100, 5, 37, 69, 101, 6, 38, 70, 102, 7, 39, 71, 103, 8, 40, 72, 104, 9, 41, 73, 105, 10, 42, 74, 106, 11, 43, 75, 107, 12, 44, 76, 108, 13, 45, 77, 109, 14, 46, 78, 110, 15, 47, 79, 111);
        }
#else
            get;
        } = Vector512.Create((byte)0, 32, 64, 96, 1, 33, 65, 97, 2, 34, 66, 98, 3, 35, 67, 99, 4, 36, 68, 100, 5, 37, 69, 101, 6, 38, 70, 102, 7, 39, 71, 103, 8, 40, 72, 104, 9, 41, 73, 105, 10, 42, 74, 106, 11, 43, 75, 107, 12, 44, 76, 108, 13, 45, 77, 109, 14, 46, 78, 110, 15, 47, 79, 111);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX2 Longer - Byte - The index of data2/data3.</summary>
        [CLSCompliant(false)]
        public static Vector512<byte> YGroup4Zip_ShuffleX2Longer_Byte_Data23 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((byte)16, 48, 80, 112, 17, 49, 81, 113, 18, 50, 82, 114, 19, 51, 83, 115, 20, 52, 84, 116, 21, 53, 85, 117, 22, 54, 86, 118, 23, 55, 87, 119, 24, 56, 88, 120, 25, 57, 89, 121, 26, 58, 90, 122, 27, 59, 91, 123, 28, 60, 92, 124, 29, 61, 93, 125, 30, 62, 94, 126, 31, 63, 95, 127);
        }
#else
            get;
        } = Vector512.Create((byte)16, 48, 80, 112, 17, 49, 81, 113, 18, 50, 82, 114, 19, 51, 83, 115, 20, 52, 84, 116, 21, 53, 85, 117, 22, 54, 86, 118, 23, 55, 87, 119, 24, 56, 88, 120, 25, 57, 89, 121, 26, 58, 90, 122, 27, 59, 91, 123, 28, 60, 92, 124, 29, 61, 93, 125, 30, 62, 94, 126, 31, 63, 95, 127);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX2 Longer - UInt16 - The index of data0/data1.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup4Zip_ShuffleX2Longer_UInt16_Data01 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)0, 16, 32, 48, 1, 17, 33, 49, 2, 18, 34, 50, 3, 19, 35, 51, 4, 20, 36, 52, 5, 21, 37, 53, 6, 22, 38, 54, 7, 23, 39, 55);
        }
#else
            get;
        } = Vector512.Create((ushort)0, 16, 32, 48, 1, 17, 33, 49, 2, 18, 34, 50, 3, 19, 35, 51, 4, 20, 36, 52, 5, 21, 37, 53, 6, 22, 38, 54, 7, 23, 39, 55);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX2 Longer - UInt16 - The index of data2/data3.</summary>
        [CLSCompliant(false)]
        public static Vector512<ushort> YGroup4Zip_ShuffleX2Longer_UInt16_Data23 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ushort)8, 24, 40, 56, 9, 25, 41, 57, 10, 26, 42, 58, 11, 27, 43, 59, 12, 28, 44, 60, 13, 29, 45, 61, 14, 30, 46, 62, 15, 31, 47, 63);
        }
#else
            get;
        } = Vector512.Create((ushort)8, 24, 40, 56, 9, 25, 41, 57, 10, 26, 42, 58, 11, 27, 43, 59, 12, 28, 44, 60, 13, 29, 45, 61, 14, 30, 46, 62, 15, 31, 47, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX2 Longer - UInt32 - The index of data0/data1.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup4Zip_ShuffleX2Longer_UInt32_Data01 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)0, 8, 16, 24, 1, 9, 17, 25, 2, 10, 18, 26, 3, 11, 19, 27);
        }
#else
            get;
        } = Vector512.Create((uint)0, 8, 16, 24, 1, 9, 17, 25, 2, 10, 18, 26, 3, 11, 19, 27);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX2 Longer - UInt32 - The index of data2/data3.</summary>
        [CLSCompliant(false)]
        public static Vector512<uint> YGroup4Zip_ShuffleX2Longer_UInt32_Data23 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((uint)4, 12, 20, 28, 5, 13, 21, 29, 6, 14, 22, 30, 7, 15, 23, 31);
        }
#else
            get;
        } = Vector512.Create((uint)4, 12, 20, 28, 5, 13, 21, 29, 6, 14, 22, 30, 7, 15, 23, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX2 Longer - UInt64 - The index of data0/data1.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup4Zip_ShuffleX2Longer_UInt64_Data01 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)0, 4, 8, 12, 1, 5, 9, 13);
        }
#else
            get;
        } = Vector512.Create((ulong)0, 4, 8, 12, 1, 5, 9, 13);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX2 Longer - UInt64 - The index of data2/data3.</summary>
        [CLSCompliant(false)]
        public static Vector512<ulong> YGroup4Zip_ShuffleX2Longer_UInt64_Data23 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector512.Create((ulong)2, 6, 10, 14, 3, 7, 11, 15);
        }
#else
            get;
        } = Vector512.Create((ulong)2, 6, 10, 14, 3, 7, 11, 15);

#endif // USE_VECTOR_CREATE

#endif // NET8_0_OR_GREATER
    }
}
