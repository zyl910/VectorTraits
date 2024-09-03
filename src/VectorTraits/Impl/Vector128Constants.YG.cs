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
    partial class Vector128Constants {
#if NETCOREAPP3_0_OR_GREATER

        /// <summary>YGroup2Unzip - ShuffleX2 - Byte - The index of X.</summary>
        public static Vector128<byte> YGroup2Unzip_ShuffleX2_Byte_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30);
        }
#else
            get;
        } = Vector128.Create((byte)0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - Byte - The index of X - Sub part1.</summary>
        public static Vector128<byte> YGroup2Unzip_ShuffleX2_Byte_X_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 2, 4, 6, 8, 10, 12, 14).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 2, 4, 6, 8, 10, 12, 14).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - Byte - The index of Y.</summary>
        public static Vector128<byte> YGroup2Unzip_ShuffleX2_Byte_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31);
        }
#else
            get;
        } = Vector128.Create((byte)1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - Byte - The index of Y - Sub part1.</summary>
        public static Vector128<byte> YGroup2Unzip_ShuffleX2_Byte_Y_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 1, 3, 5, 7, 9, 11, 13, 15).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 1, 3, 5, 7, 9, 11, 13, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt16 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector128<ushort> YGroup2Unzip_ShuffleX2_UInt16_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ushort)0, 2, 4, 6, 8, 10, 12, 14);
        }
#else
            get;
        } = Vector128.Create((ushort)0, 2, 4, 6, 8, 10, 12, 14);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt16 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector128<ushort> YGroup2Unzip_ShuffleX2_UInt16_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ushort)1, 3, 5, 7, 9, 11, 13, 15);
        }
#else
            get;
        } = Vector128.Create((ushort)1, 3, 5, 7, 9, 11, 13, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt32 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector128<uint> YGroup2Unzip_ShuffleX2_UInt32_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((uint)0, 2, 4, 6);
        }
#else
            get;
        } = Vector128.Create((uint)0, 2, 4, 6);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt32 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector128<uint> YGroup2Unzip_ShuffleX2_UInt32_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((uint)1, 3, 5, 7);
        }
#else
            get;
        } = Vector128.Create((uint)1, 3, 5, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt64 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector128<ulong> YGroup2Unzip_ShuffleX2_UInt64_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ulong)0, 2);
        }
#else
            get;
        } = Vector128.Create((ulong)0, 2);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 - UInt64 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector128<ulong> YGroup2Unzip_ShuffleX2_UInt64_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ulong)1, 3);
        }
#else
            get;
        } = Vector128.Create((ulong)1, 3);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 on byte - UInt16 - The index of X.</summary>
        public static Vector128<byte> YGroup2Unzip_ShuffleX2OnByte_UInt16_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 4, 5, 8, 9, 12, 13, 16, 17, 20, 21, 24, 25, 28, 29);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 4, 5, 8, 9, 12, 13, 16, 17, 20, 21, 24, 25, 28, 29);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 on byte - UInt16 - The index of X - Sub part1.</summary>
        public static Vector128<byte> YGroup2Unzip_ShuffleX2OnByte_UInt16_X_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 4, 5, 8, 9, 12, 13).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 4, 5, 8, 9, 12, 13).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 on byte - UInt16 - The index of Y.</summary>
        public static Vector128<byte> YGroup2Unzip_ShuffleX2OnByte_UInt16_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)2, 3, 6, 7, 10, 11, 14, 15, 18, 19, 22, 23, 26, 27, 30, 31);
        }
#else
            get;
        } = Vector128.Create((byte)2, 3, 6, 7, 10, 11, 14, 15, 18, 19, 22, 23, 26, 27, 30, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 on byte - UInt16 - The index of Y - Sub part1.</summary>
        public static Vector128<byte> YGroup2Unzip_ShuffleX2OnByte_UInt16_Y_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 2, 3, 6, 7, 10, 11, 14, 15).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 2, 3, 6, 7, 10, 11, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 on byte - UInt32 - The index of X.</summary>
        public static Vector128<byte> YGroup2Unzip_ShuffleX2OnByte_UInt32_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 2, 3, 8, 9, 10, 11, 16, 17, 18, 19, 24, 25, 26, 27);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 2, 3, 8, 9, 10, 11, 16, 17, 18, 19, 24, 25, 26, 27);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 on byte - UInt32 - The index of X - Sub part1.</summary>
        public static Vector128<byte> YGroup2Unzip_ShuffleX2OnByte_UInt32_X_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 8, 9, 10, 11).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 8, 9, 10, 11).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 on byte - UInt32 - The index of Y.</summary>
        public static Vector128<byte> YGroup2Unzip_ShuffleX2OnByte_UInt32_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)4, 5, 6, 7, 12, 13, 14, 15, 20, 21, 22, 23, 28, 29, 30, 31);
        }
#else
            get;
        } = Vector128.Create((byte)4, 5, 6, 7, 12, 13, 14, 15, 20, 21, 22, 23, 28, 29, 30, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 on byte - UInt32 - The index of Y - Sub part1.</summary>
        public static Vector128<byte> YGroup2Unzip_ShuffleX2OnByte_UInt32_Y_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 on byte - UInt64 - The index of X.</summary>
        public static Vector128<byte> YGroup2Unzip_ShuffleX2OnByte_UInt64_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 16, 17, 18, 19, 20, 21, 22, 23);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 16, 17, 18, 19, 20, 21, 22, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 on byte - UInt64 - The index of X - Sub part1.</summary>
        public static Vector128<byte> YGroup2Unzip_ShuffleX2OnByte_UInt64_X_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 on byte - UInt64 - The index of Y.</summary>
        public static Vector128<byte> YGroup2Unzip_ShuffleX2OnByte_UInt64_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 24, 25, 26, 27, 28, 29, 30, 31);
        }
#else
            get;
        } = Vector128.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 24, 25, 26, 27, 28, 29, 30, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Unzip - ShuffleX2 on byte - UInt64 - The index of Y - Sub part1.</summary>
        public static Vector128<byte> YGroup2Unzip_ShuffleX2OnByte_UInt64_Y_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup2Zip - ShuffleX2 - Byte - The index of data0.</summary>
        public static Vector128<byte> YGroup2Zip_ShuffleX2_Byte_Data0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 16, 1, 17, 2, 18, 3, 19, 4, 20, 5, 21, 6, 22, 7, 23);
        }
#else
            get;
        } = Vector128.Create((byte)0, 16, 1, 17, 2, 18, 3, 19, 4, 20, 5, 21, 6, 22, 7, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - Byte - The index of data0 - Sub part1.</summary>
        public static Vector128<byte> YGroup2Zip_ShuffleX2_Byte_Data0_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, 0, -1, 1, -1, 2, -1, 3, -1, 4, -1, 5, -1, 6, -1, 7).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, 0, -1, 1, -1, 2, -1, 3, -1, 4, -1, 5, -1, 6, -1, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - Byte - The index of data1.</summary>
        public static Vector128<byte> YGroup2Zip_ShuffleX2_Byte_Data1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)8, 24, 9, 25, 10, 26, 11, 27, 12, 28, 13, 29, 14, 30, 15, 31);
        }
#else
            get;
        } = Vector128.Create((byte)8, 24, 9, 25, 10, 26, 11, 27, 12, 28, 13, 29, 14, 30, 15, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - Byte - The index of data1 - Sub part1.</summary>
        public static Vector128<byte> YGroup2Zip_ShuffleX2_Byte_Data1_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, 8, -1, 9, -1, 10, -1, 11, -1, 12, -1, 13, -1, 14, -1, 15).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, 8, -1, 9, -1, 10, -1, 11, -1, 12, -1, 13, -1, 14, -1, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt16 - The index of data0.</summary>
        [CLSCompliant(false)]
        public static Vector128<ushort> YGroup2Zip_ShuffleX2_UInt16_Data0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ushort)0, 8, 1, 9, 2, 10, 3, 11);
        }
#else
            get;
        } = Vector128.Create((ushort)0, 8, 1, 9, 2, 10, 3, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt16 - The index of data1.</summary>
        [CLSCompliant(false)]
        public static Vector128<ushort> YGroup2Zip_ShuffleX2_UInt16_Data1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ushort)4, 12, 5, 13, 6, 14, 7, 15);
        }
#else
            get;
        } = Vector128.Create((ushort)4, 12, 5, 13, 6, 14, 7, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt32 - The index of data0.</summary>
        [CLSCompliant(false)]
        public static Vector128<uint> YGroup2Zip_ShuffleX2_UInt32_Data0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((uint)0, 4, 1, 5);
        }
#else
            get;
        } = Vector128.Create((uint)0, 4, 1, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt32 - The index of data1.</summary>
        [CLSCompliant(false)]
        public static Vector128<uint> YGroup2Zip_ShuffleX2_UInt32_Data1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((uint)2, 6, 3, 7);
        }
#else
            get;
        } = Vector128.Create((uint)2, 6, 3, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt64 - The index of data0.</summary>
        [CLSCompliant(false)]
        public static Vector128<ulong> YGroup2Zip_ShuffleX2_UInt64_Data0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ulong)0, 2);
        }
#else
            get;
        } = Vector128.Create((ulong)0, 2);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 - UInt64 - The index of data1.</summary>
        [CLSCompliant(false)]
        public static Vector128<ulong> YGroup2Zip_ShuffleX2_UInt64_Data1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ulong)1, 3);
        }
#else
            get;
        } = Vector128.Create((ulong)1, 3);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 on byte - UInt16 - The index of data0.</summary>
        public static Vector128<byte> YGroup2Zip_ShuffleX2OnByte_UInt16_Data0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 16, 17, 2, 3, 18, 19, 4, 5, 20, 21, 6, 7, 22, 23);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 16, 17, 2, 3, 18, 19, 4, 5, 20, 21, 6, 7, 22, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 on byte - UInt16 - The index of data0 - Sub part1.</summary>
        public static Vector128<byte> YGroup2Zip_ShuffleX2OnByte_UInt16_Data0_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, 0, 1, -1, -1, 2, 3, -1, -1, 4, 5, -1, -1, 6, 7).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, 0, 1, -1, -1, 2, 3, -1, -1, 4, 5, -1, -1, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 on byte - UInt16 - The index of data1.</summary>
        public static Vector128<byte> YGroup2Zip_ShuffleX2OnByte_UInt16_Data1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)8, 9, 24, 25, 10, 11, 26, 27, 12, 13, 28, 29, 14, 15, 30, 31);
        }
#else
            get;
        } = Vector128.Create((byte)8, 9, 24, 25, 10, 11, 26, 27, 12, 13, 28, 29, 14, 15, 30, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 on byte - UInt16 - The index of data1 - Sub part1.</summary>
        public static Vector128<byte> YGroup2Zip_ShuffleX2OnByte_UInt16_Data1_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, 8, 9, -1, -1, 10, 11, -1, -1, 12, 13, -1, -1, 14, 15).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, 8, 9, -1, -1, 10, 11, -1, -1, 12, 13, -1, -1, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 on byte - UInt32 - The index of data0.</summary>
        public static Vector128<byte> YGroup2Zip_ShuffleX2OnByte_UInt32_Data0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 2, 3, 16, 17, 18, 19, 4, 5, 6, 7, 20, 21, 22, 23);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 2, 3, 16, 17, 18, 19, 4, 5, 6, 7, 20, 21, 22, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 on byte - UInt32 - The index of data0 - Sub part1.</summary>
        public static Vector128<byte> YGroup2Zip_ShuffleX2OnByte_UInt32_Data0_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 on byte - UInt32 - The index of data1.</summary>
        public static Vector128<byte> YGroup2Zip_ShuffleX2OnByte_UInt32_Data1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)8, 9, 10, 11, 24, 25, 26, 27, 12, 13, 14, 15, 28, 29, 30, 31);
        }
#else
            get;
        } = Vector128.Create((byte)8, 9, 10, 11, 24, 25, 26, 27, 12, 13, 14, 15, 28, 29, 30, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 on byte - UInt32 - The index of data1 - Sub part1.</summary>
        public static Vector128<byte> YGroup2Zip_ShuffleX2OnByte_UInt32_Data1_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 on byte - UInt64 - The index of data0.</summary>
        public static Vector128<byte> YGroup2Zip_ShuffleX2OnByte_UInt64_Data0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 16, 17, 18, 19, 20, 21, 22, 23);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 16, 17, 18, 19, 20, 21, 22, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 on byte - UInt64 - The index of data0 - Sub part1.</summary>
        public static Vector128<byte> YGroup2Zip_ShuffleX2OnByte_UInt64_Data0_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 on byte - UInt64 - The index of data1.</summary>
        public static Vector128<byte> YGroup2Zip_ShuffleX2OnByte_UInt64_Data1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 24, 25, 26, 27, 28, 29, 30, 31);
        }
#else
            get;
        } = Vector128.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 24, 25, 26, 27, 28, 29, 30, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup2Zip - ShuffleX2 on byte - UInt64 - The index of data1 - Sub part1.</summary>
        public static Vector128<byte> YGroup2Zip_ShuffleX2OnByte_UInt64_Data1_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 0.</summary>
        public static Vector128<byte> YGroup3ToGroup4_Shuffle_Byte_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10, 11, 11);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 2, 2, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10, 11, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 1.</summary>
        public static Vector128<byte> YGroup3ToGroup4_Shuffle_Byte_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)12, 13, 14, 14, 15, 16, 17, 17, 18, 19, 20, 20, 21, 22, 23, 23);
        }
#else
            get;
        } = Vector128.Create((byte)12, 13, 14, 14, 15, 16, 17, 17, 18, 19, 20, 20, 21, 22, 23, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 1 - Sub part0.</summary>
        public static Vector128<byte> YGroup3ToGroup4_Shuffle_Byte_1A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)12, 13, 14, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)12, 13, 14, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 1 - Sub part1.</summary>
        public static Vector128<byte> YGroup3ToGroup4_Shuffle_Byte_1B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, 0, 1, 1, 2, 3, 4, 4, 5, 6, 7, 7).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, 0, 1, 1, 2, 3, 4, 4, 5, 6, 7, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 2.</summary>
        public static Vector128<byte> YGroup3ToGroup4_Shuffle_Byte_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)8, 9, 10, 10, 11, 12, 13, 13, 14, 15, 16, 16, 17, 18, 19, 19);
        }
#else
            get;
        } = Vector128.Create((byte)8, 9, 10, 10, 11, 12, 13, 13, 14, 15, 16, 16, 17, 18, 19, 19);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 2 - Sub part0.</summary>
        public static Vector128<byte> YGroup3ToGroup4_Shuffle_Byte_2A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)8, 9, 10, 10, 11, 12, 13, 13, 14, 15, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)8, 9, 10, 10, 11, 12, 13, 13, 14, 15, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 2 - Sub part1.</summary>
        public static Vector128<byte> YGroup3ToGroup4_Shuffle_Byte_2B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 1, 2, 3, 3).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 0, 1, 2, 3, 3).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - Byte - The index of item 3.</summary>
        public static Vector128<byte> YGroup3ToGroup4_Shuffle_Byte_3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15, 15);
        }
#else
            get;
        } = Vector128.Create((byte)4, 5, 6, 6, 7, 8, 9, 9, 10, 11, 12, 12, 13, 14, 15, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt16 - The index of item 0.</summary>
        [CLSCompliant(false)]
        public static Vector128<ushort> YGroup3ToGroup4_Shuffle_UInt16_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ushort)0, 1, 2, 2, 3, 4, 5, 5);
        }
#else
            get;
        } = Vector128.Create((ushort)0, 1, 2, 2, 3, 4, 5, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt16 - The index of item 1.</summary>
        [CLSCompliant(false)]
        public static Vector128<ushort> YGroup3ToGroup4_Shuffle_UInt16_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ushort)6, 7, 8, 8, 9, 10, 11, 11);
        }
#else
            get;
        } = Vector128.Create((ushort)6, 7, 8, 8, 9, 10, 11, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt16 - The index of item 2.</summary>
        [CLSCompliant(false)]
        public static Vector128<ushort> YGroup3ToGroup4_Shuffle_UInt16_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ushort)4, 5, 6, 6, 7, 8, 9, 9);
        }
#else
            get;
        } = Vector128.Create((ushort)4, 5, 6, 6, 7, 8, 9, 9);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt16 - The index of item 3.</summary>
        [CLSCompliant(false)]
        public static Vector128<ushort> YGroup3ToGroup4_Shuffle_UInt16_3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ushort)2, 3, 4, 4, 5, 6, 7, 7);
        }
#else
            get;
        } = Vector128.Create((ushort)2, 3, 4, 4, 5, 6, 7, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt32 - The index of item 0.</summary>
        [CLSCompliant(false)]
        public static Vector128<uint> YGroup3ToGroup4_Shuffle_UInt32_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((uint)0, 1, 2, 2);
        }
#else
            get;
        } = Vector128.Create((uint)0, 1, 2, 2);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt32 - The index of item 1.</summary>
        [CLSCompliant(false)]
        public static Vector128<uint> YGroup3ToGroup4_Shuffle_UInt32_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((uint)3, 4, 5, 5);
        }
#else
            get;
        } = Vector128.Create((uint)3, 4, 5, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt32 - The index of item 2.</summary>
        [CLSCompliant(false)]
        public static Vector128<uint> YGroup3ToGroup4_Shuffle_UInt32_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((uint)2, 3, 4, 4);
        }
#else
            get;
        } = Vector128.Create((uint)2, 3, 4, 4);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt32 - The index of item 3.</summary>
        [CLSCompliant(false)]
        public static Vector128<uint> YGroup3ToGroup4_Shuffle_UInt32_3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((uint)1, 2, 3, 3);
        }
#else
            get;
        } = Vector128.Create((uint)1, 2, 3, 3);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt64 - The index of item 0.</summary>
        [CLSCompliant(false)]
        public static Vector128<ulong> YGroup3ToGroup4_Shuffle_UInt64_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ulong)0, 1);
        }
#else
            get;
        } = Vector128.Create((ulong)0, 1);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt64 - The index of item 1.</summary>
        [CLSCompliant(false)]
        public static Vector128<ulong> YGroup3ToGroup4_Shuffle_UInt64_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ulong)0, 0);
        }
#else
            get;
        } = Vector128.Create((ulong)0, 0);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt64 - The index of item 2.</summary>
        [CLSCompliant(false)]
        public static Vector128<ulong> YGroup3ToGroup4_Shuffle_UInt64_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ulong)1, 2);
        }
#else
            get;
        } = Vector128.Create((ulong)1, 2);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle - UInt64 - The index of item 3.</summary>
        [CLSCompliant(false)]
        public static Vector128<ulong> YGroup3ToGroup4_Shuffle_UInt64_3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ulong)1, 1);
        }
#else
            get;
        } = Vector128.Create((ulong)1, 1);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 0.</summary>
        public static Vector128<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 2, 3, 4, 5, 4, 5, 6, 7, 8, 9, 10, 11, 10, 11);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 2, 3, 4, 5, 4, 5, 6, 7, 8, 9, 10, 11, 10, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 1.</summary>
        public static Vector128<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)12, 13, 14, 15, 16, 17, 16, 17, 18, 19, 20, 21, 22, 23, 22, 23);
        }
#else
            get;
        } = Vector128.Create((byte)12, 13, 14, 15, 16, 17, 16, 17, 18, 19, 20, 21, 22, 23, 22, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 1 - Sub part0.</summary>
        public static Vector128<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_1A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 1 - Sub part1.</summary>
        public static Vector128<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_1B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, 0, 1, 0, 1, 2, 3, 4, 5, 6, 7, 6, 7).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, 0, 1, 0, 1, 2, 3, 4, 5, 6, 7, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 2.</summary>
        public static Vector128<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)8, 9, 10, 11, 12, 13, 12, 13, 14, 15, 16, 17, 18, 19, 18, 19);
        }
#else
            get;
        } = Vector128.Create((byte)8, 9, 10, 11, 12, 13, 12, 13, 14, 15, 16, 17, 18, 19, 18, 19);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 2 - Sub part0.</summary>
        public static Vector128<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_2A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)8, 9, 10, 11, 12, 13, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)8, 9, 10, 11, 12, 13, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 2 - Sub part1.</summary>
        public static Vector128<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_2B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 2, 3).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 2, 3).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt16 - The index of item 3.</summary>
        public static Vector128<byte> YGroup3ToGroup4_ShuffleOnByte_UInt16_3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)4, 5, 6, 7, 8, 9, 8, 9, 10, 11, 12, 13, 14, 15, 14, 15);
        }
#else
            get;
        } = Vector128.Create((byte)4, 5, 6, 7, 8, 9, 8, 9, 10, 11, 12, 13, 14, 15, 14, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 0.</summary>
        public static Vector128<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 8, 9, 10, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 1.</summary>
        public static Vector128<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 20, 21, 22, 23);
        }
#else
            get;
        } = Vector128.Create((byte)12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 20, 21, 22, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 1 - Sub part0.</summary>
        public static Vector128<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_1A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 1 - Sub part1.</summary>
        public static Vector128<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_1B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 2.</summary>
        public static Vector128<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 16, 17, 18, 19);
        }
#else
            get;
        } = Vector128.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 16, 17, 18, 19);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 2 - Sub part0.</summary>
        public static Vector128<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_2A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 2 - Sub part1.</summary>
        public static Vector128<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_2B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 0, 1, 2, 3).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 0, 1, 2, 3).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt32 - The index of item 3.</summary>
        public static Vector128<byte> YGroup3ToGroup4_ShuffleOnByte_UInt32_3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15);
        }
#else
            get;
        } = Vector128.Create((byte)4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 12, 13, 14, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 0.</summary>
        public static Vector128<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 1.</summary>
        public static Vector128<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 1 - Sub part0.</summary>
        public static Vector128<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_1A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 1 - Sub part1.</summary>
        public static Vector128<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_1B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 2.</summary>
        public static Vector128<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23);
        }
#else
            get;
        } = Vector128.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 2 - Sub part0.</summary>
        public static Vector128<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_2A {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 2 - Sub part1.</summary>
        public static Vector128<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_2B {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3ToGroup4 - Shuffle on byte - UInt64 - The index of item 3.</summary>
        public static Vector128<byte> YGroup3ToGroup4_ShuffleOnByte_UInt64_3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15);
        }
#else
            get;
        } = Vector128.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 8, 9, 10, 11, 12, 13, 14, 15);
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of X.</summary>
        public static Vector128<byte> YGroup3Unzip_Shuffle_Byte_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45);
        }
#else
            get;
        } = Vector128.Create((byte)0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of X - Sub part0.</summary>
        public static Vector128<byte> YGroup3Unzip_Shuffle_Byte_X_Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)0, 3, 6, 9, 12, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)0, 3, 6, 9, 12, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of X - Sub part1.</summary>
        public static Vector128<byte> YGroup3Unzip_Shuffle_Byte_X_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, 2, 5, 8, 11, 14, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, 2, 5, 8, 11, 14, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of X - Sub part2.</summary>
        public static Vector128<byte> YGroup3Unzip_Shuffle_Byte_X_Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 7, 10, 13).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 4, 7, 10, 13).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of X - Sub part2 combine 0|1.</summary>
        public static Vector128<byte> YGroup3Unzip_Shuffle_Byte_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 1, 4, 7, 10, 13);
        }
#else
            get;
        } = Vector128.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 1, 4, 7, 10, 13);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Y.</summary>
        public static Vector128<byte> YGroup3Unzip_Shuffle_Byte_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46);
        }
#else
            get;
        } = Vector128.Create((byte)1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34, 37, 40, 43, 46);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Y - Sub part0.</summary>
        public static Vector128<byte> YGroup3Unzip_Shuffle_Byte_Y_Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)1, 4, 7, 10, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)1, 4, 7, 10, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Y - Sub part1.</summary>
        public static Vector128<byte> YGroup3Unzip_Shuffle_Byte_Y_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, 0, 3, 6, 9, 12, 15, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, 0, 3, 6, 9, 12, 15, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Y - Sub part2.</summary>
        public static Vector128<byte> YGroup3Unzip_Shuffle_Byte_Y_Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 5, 8, 11, 14).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 5, 8, 11, 14).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Y - Sub part2 combine 0|1.</summary>
        public static Vector128<byte> YGroup3Unzip_Shuffle_Byte_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 2, 5, 8, 11, 14);
        }
#else
            get;
        } = Vector128.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 2, 5, 8, 11, 14);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Z.</summary>
        public static Vector128<byte> YGroup3Unzip_Shuffle_Byte_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38, 41, 44, 47);
        }
#else
            get;
        } = Vector128.Create((byte)2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35, 38, 41, 44, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Z - Sub part0.</summary>
        public static Vector128<byte> YGroup3Unzip_Shuffle_Byte_Z_Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)2, 5, 8, 11, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)2, 5, 8, 11, 14, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Z - Sub part1.</summary>
        public static Vector128<byte> YGroup3Unzip_Shuffle_Byte_Z_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, 1, 4, 7, 10, 13, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, 1, 4, 7, 10, 13, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Z - Sub part2.</summary>
        public static Vector128<byte> YGroup3Unzip_Shuffle_Byte_Z_Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 3, 6, 9, 12, 15).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 3, 6, 9, 12, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - Byte - The index of Z - Sub part2 combine 0|1.</summary>
        public static Vector128<byte> YGroup3Unzip_Shuffle_Byte_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 0, 3, 6, 9, 12, 15);
        }
#else
            get;
        } = Vector128.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 0, 3, 6, 9, 12, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt16 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector128<ushort> YGroup3Unzip_Shuffle_UInt16_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ushort)0, 3, 6, 9, 12, 15, 18, 21);
        }
#else
            get;
        } = Vector128.Create((ushort)0, 3, 6, 9, 12, 15, 18, 21);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt16 - The index of X - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector128<ushort> YGroup3Unzip_Shuffle_UInt16_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ushort)8, 9, 10, 11, 12, 13, 2, 5);
        }
#else
            get;
        } = Vector128.Create((ushort)8, 9, 10, 11, 12, 13, 2, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt16 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector128<ushort> YGroup3Unzip_Shuffle_UInt16_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ushort)1, 4, 7, 10, 13, 16, 19, 22);
        }
#else
            get;
        } = Vector128.Create((ushort)1, 4, 7, 10, 13, 16, 19, 22);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt16 - The index of Y - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector128<ushort> YGroup3Unzip_Shuffle_UInt16_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ushort)8, 9, 10, 11, 12, 0, 3, 6);
        }
#else
            get;
        } = Vector128.Create((ushort)8, 9, 10, 11, 12, 0, 3, 6);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt16 - The index of Z.</summary>
        [CLSCompliant(false)]
        public static Vector128<ushort> YGroup3Unzip_Shuffle_UInt16_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ushort)2, 5, 8, 11, 14, 17, 20, 23);
        }
#else
            get;
        } = Vector128.Create((ushort)2, 5, 8, 11, 14, 17, 20, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt16 - The index of Z - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector128<ushort> YGroup3Unzip_Shuffle_UInt16_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ushort)8, 9, 10, 11, 12, 1, 4, 7);
        }
#else
            get;
        } = Vector128.Create((ushort)8, 9, 10, 11, 12, 1, 4, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt32 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector128<uint> YGroup3Unzip_Shuffle_UInt32_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((uint)0, 3, 6, 9);
        }
#else
            get;
        } = Vector128.Create((uint)0, 3, 6, 9);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt32 - The index of X - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector128<uint> YGroup3Unzip_Shuffle_UInt32_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((uint)4, 5, 6, 1);
        }
#else
            get;
        } = Vector128.Create((uint)4, 5, 6, 1);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt32 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector128<uint> YGroup3Unzip_Shuffle_UInt32_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((uint)1, 4, 7, 10);
        }
#else
            get;
        } = Vector128.Create((uint)1, 4, 7, 10);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt32 - The index of Y - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector128<uint> YGroup3Unzip_Shuffle_UInt32_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((uint)4, 5, 6, 2);
        }
#else
            get;
        } = Vector128.Create((uint)4, 5, 6, 2);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt32 - The index of Z.</summary>
        [CLSCompliant(false)]
        public static Vector128<uint> YGroup3Unzip_Shuffle_UInt32_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((uint)2, 5, 8, 11);
        }
#else
            get;
        } = Vector128.Create((uint)2, 5, 8, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt32 - The index of Z - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector128<uint> YGroup3Unzip_Shuffle_UInt32_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((uint)4, 5, 0, 3);
        }
#else
            get;
        } = Vector128.Create((uint)4, 5, 0, 3);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt64 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector128<ulong> YGroup3Unzip_Shuffle_UInt64_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ulong)0, 3);
        }
#else
            get;
        } = Vector128.Create((ulong)0, 3);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt64 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector128<ulong> YGroup3Unzip_Shuffle_UInt64_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ulong)1, 4);
        }
#else
            get;
        } = Vector128.Create((ulong)1, 4);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt64 - The index of Y - On 0|2.</summary>
        [CLSCompliant(false)]
        public static Vector128<ulong> YGroup3Unzip_Shuffle_UInt64_Y_On02 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ulong)1, 2);
        }
#else
            get;
        } = Vector128.Create((ulong)1, 2);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt64 - The index of Z.</summary>
        [CLSCompliant(false)]
        public static Vector128<ulong> YGroup3Unzip_Shuffle_UInt64_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ulong)2, 5);
        }
#else
            get;
        } = Vector128.Create((ulong)2, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle - UInt64 - The index of Z - On 1|2.</summary>
        [CLSCompliant(false)]
        public static Vector128<ulong> YGroup3Unzip_Shuffle_UInt64_Z_On12 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ulong)0, 3);
        }
#else
            get;
        } = Vector128.Create((ulong)0, 3);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of X.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt16_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 6, 7, 12, 13, 18, 19, 24, 25, 30, 31, 36, 37, 42, 43);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 6, 7, 12, 13, 18, 19, 24, 25, 30, 31, 36, 37, 42, 43);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of X - Sub part0.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt16_X_Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)0, 1, 6, 7, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)0, 1, 6, 7, 12, 13, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of X - Sub part1.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt16_X_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, 2, 3, 8, 9, 14, 15, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, 2, 3, 8, 9, 14, 15, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of X - Sub part2.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt16_X_Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 10, 11).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 10, 11).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of Y.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt16_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)2, 3, 8, 9, 14, 15, 20, 21, 26, 27, 32, 33, 38, 39, 44, 45);
        }
#else
            get;
        } = Vector128.Create((byte)2, 3, 8, 9, 14, 15, 20, 21, 26, 27, 32, 33, 38, 39, 44, 45);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of Y - Sub part0.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt16_Y_Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)2, 3, 8, 9, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)2, 3, 8, 9, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of Y - Sub part1.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt16_Y_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, 4, 5, 10, 11, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, 4, 5, 10, 11, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of Y - Sub part2.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt16_Y_Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 6, 7, 12, 13).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 6, 7, 12, 13).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of Z.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt16_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)4, 5, 10, 11, 16, 17, 22, 23, 28, 29, 34, 35, 40, 41, 46, 47);
        }
#else
            get;
        } = Vector128.Create((byte)4, 5, 10, 11, 16, 17, 22, 23, 28, 29, 34, 35, 40, 41, 46, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of Z - Sub part0.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt16_Z_Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)4, 5, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)4, 5, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of Z - Sub part1.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt16_Z_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, 0, 1, 6, 7, 12, 13, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, 0, 1, 6, 7, 12, 13, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt16 - The index of Z - Sub part2.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt16_Z_Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 3, 8, 9, 14, 15).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 3, 8, 9, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of X.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt32_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 2, 3, 12, 13, 14, 15, 24, 25, 26, 27, 36, 37, 38, 39);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 2, 3, 12, 13, 14, 15, 24, 25, 26, 27, 36, 37, 38, 39);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of X - Sub part0.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt32_X_Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)0, 1, 2, 3, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)0, 1, 2, 3, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of X - Sub part1.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt32_X_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of X - Sub part2.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt32_X_Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of Y.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt32_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)4, 5, 6, 7, 16, 17, 18, 19, 28, 29, 30, 31, 40, 41, 42, 43);
        }
#else
            get;
        } = Vector128.Create((byte)4, 5, 6, 7, 16, 17, 18, 19, 28, 29, 30, 31, 40, 41, 42, 43);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of Y - Sub part0.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt32_Y_Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of Y - Sub part1.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt32_Y_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, 12, 13, 14, 15, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, 12, 13, 14, 15, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of Y - Sub part2.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt32_Y_Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of Z.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt32_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)8, 9, 10, 11, 20, 21, 22, 23, 32, 33, 34, 35, 44, 45, 46, 47);
        }
#else
            get;
        } = Vector128.Create((byte)8, 9, 10, 11, 20, 21, 22, 23, 32, 33, 34, 35, 44, 45, 46, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of Z - Sub part0.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt32_Z_Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of Z - Sub part1.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt32_Z_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt32 - The index of Z - Sub part2.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt32_Z_Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of X.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt64_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 24, 25, 26, 27, 28, 29, 30, 31);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 24, 25, 26, 27, 28, 29, 30, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of X - Sub part0.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt64_X_Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of X - Sub part1.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt64_X_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of X - Sub part2.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt64_X_Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Y.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 32, 33, 34, 35, 36, 37, 38, 39);
        }
#else
            get;
        } = Vector128.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 32, 33, 34, 35, 36, 37, 38, 39);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Y - Sub part0.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Y_Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Y - Sub part1.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Y_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Y - Sub part2.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Y_Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Y - On 0|2.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Y_On02 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23);
        }
#else
            get;
        } = Vector128.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Z.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 40, 41, 42, 43, 44, 45, 46, 47);
        }
#else
            get;
        } = Vector128.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 40, 41, 42, 43, 44, 45, 46, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Z - Sub part0.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Z_Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Z - Sub part1.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Z_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Unzip - Shuffle on byte - UInt64 - The index of Z - Sub part2.</summary>
        public static Vector128<byte> YGroup3Unzip_ShuffleOnByte_UInt64_Z_Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup3Zip - Shuffle - Byte - The index of X.</summary>
        public static Vector128<byte> YGroup3Zip_Shuffle_Byte_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 16, 32, 1, 17, 33, 2, 18, 34, 3, 19, 35, 4, 20, 36, 5);
        }
#else
            get;
        } = Vector128.Create((byte)0, 16, 32, 1, 17, 33, 2, 18, 34, 3, 19, 35, 4, 20, 36, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of X - Sub part0.</summary>
        public static Vector128<byte> YGroup3Zip_Shuffle_Byte_X_Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)0, -1, -1, 1, -1, -1, 2, -1, -1, 3, -1, -1, 4, -1, -1, 5).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)0, -1, -1, 1, -1, -1, 2, -1, -1, 3, -1, -1, 4, -1, -1, 5).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of X - Sub part1.</summary>
        public static Vector128<byte> YGroup3Zip_Shuffle_Byte_X_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, 0, -1, -1, 1, -1, -1, 2, -1, -1, 3, -1, -1, 4, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, 0, -1, -1, 1, -1, -1, 2, -1, -1, 3, -1, -1, 4, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of X - Sub part2.</summary>
        public static Vector128<byte> YGroup3Zip_Shuffle_Byte_X_Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, 0, -1, -1, 1, -1, -1, 2, -1, -1, 3, -1, -1, 4, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, 0, -1, -1, 1, -1, -1, 2, -1, -1, 3, -1, -1, 4, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of X - Sub part2 combine 0|1.</summary>
        public static Vector128<byte> YGroup3Zip_Shuffle_Byte_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)16, 17, 0, 19, 20, 1, 22, 23, 2, 25, 26, 3, 28, 29, 4, 31);
        }
#else
            get;
        } = Vector128.Create((byte)16, 17, 0, 19, 20, 1, 22, 23, 2, 25, 26, 3, 28, 29, 4, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of Y.</summary>
        public static Vector128<byte> YGroup3Zip_Shuffle_Byte_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)21, 37, 6, 22, 38, 7, 23, 39, 8, 24, 40, 9, 25, 41, 10, 26);
        }
#else
            get;
        } = Vector128.Create((byte)21, 37, 6, 22, 38, 7, 23, 39, 8, 24, 40, 9, 25, 41, 10, 26);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of Y - Sub part0.</summary>
        public static Vector128<byte> YGroup3Zip_Shuffle_Byte_Y_Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, 6, -1, -1, 7, -1, -1, 8, -1, -1, 9, -1, -1, 10, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, 6, -1, -1, 7, -1, -1, 8, -1, -1, 9, -1, -1, 10, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of Y - Sub part1.</summary>
        public static Vector128<byte> YGroup3Zip_Shuffle_Byte_Y_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)5, -1, -1, 6, -1, -1, 7, -1, -1, 8, -1, -1, 9, -1, -1, 10).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)5, -1, -1, 6, -1, -1, 7, -1, -1, 8, -1, -1, 9, -1, -1, 10).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of Y - Sub part2.</summary>
        public static Vector128<byte> YGroup3Zip_Shuffle_Byte_Y_Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, 5, -1, -1, 6, -1, -1, 7, -1, -1, 8, -1, -1, 9, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, 5, -1, -1, 6, -1, -1, 7, -1, -1, 8, -1, -1, 9, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of Y - Sub part2 combine 0|1.</summary>
        public static Vector128<byte> YGroup3Zip_Shuffle_Byte_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)16, 5, 18, 19, 6, 21, 22, 7, 24, 25, 8, 27, 28, 9, 30, 31);
        }
#else
            get;
        } = Vector128.Create((byte)16, 5, 18, 19, 6, 21, 22, 7, 24, 25, 8, 27, 28, 9, 30, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of Z.</summary>
        public static Vector128<byte> YGroup3Zip_Shuffle_Byte_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)42, 11, 27, 43, 12, 28, 44, 13, 29, 45, 14, 30, 46, 15, 31, 47);
        }
#else
            get;
        } = Vector128.Create((byte)42, 11, 27, 43, 12, 28, 44, 13, 29, 45, 14, 30, 46, 15, 31, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of Z - Sub part0.</summary>
        public static Vector128<byte> YGroup3Zip_Shuffle_Byte_Z_Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, 11, -1, -1, 12, -1, -1, 13, -1, -1, 14, -1, -1, 15, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, 11, -1, -1, 12, -1, -1, 13, -1, -1, 14, -1, -1, 15, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of Z - Sub part1.</summary>
        public static Vector128<byte> YGroup3Zip_Shuffle_Byte_Z_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, 11, -1, -1, 12, -1, -1, 13, -1, -1, 14, -1, -1, 15, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, 11, -1, -1, 12, -1, -1, 13, -1, -1, 14, -1, -1, 15, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of Z - Sub part2.</summary>
        public static Vector128<byte> YGroup3Zip_Shuffle_Byte_Z_Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)10, -1, -1, 11, -1, -1, 12, -1, -1, 13, -1, -1, 14, -1, -1, 15).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)10, -1, -1, 11, -1, -1, 12, -1, -1, 13, -1, -1, 14, -1, -1, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - Byte - The index of Z - Sub part2 combine 0|1.</summary>
        public static Vector128<byte> YGroup3Zip_Shuffle_Byte_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)10, 17, 18, 11, 20, 21, 12, 23, 24, 13, 26, 27, 14, 29, 30, 15);
        }
#else
            get;
        } = Vector128.Create((byte)10, 17, 18, 11, 20, 21, 12, 23, 24, 13, 26, 27, 14, 29, 30, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt16 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector128<ushort> YGroup3Zip_Shuffle_UInt16_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ushort)0, 8, 16, 1, 9, 17, 2, 10);
        }
#else
            get;
        } = Vector128.Create((ushort)0, 8, 16, 1, 9, 17, 2, 10);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt16 - The index of X - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector128<ushort> YGroup3Zip_Shuffle_UInt16_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ushort)8, 9, 0, 11, 12, 1, 14, 15);
        }
#else
            get;
        } = Vector128.Create((ushort)8, 9, 0, 11, 12, 1, 14, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt16 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector128<ushort> YGroup3Zip_Shuffle_UInt16_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ushort)18, 3, 11, 19, 4, 12, 20, 5);
        }
#else
            get;
        } = Vector128.Create((ushort)18, 3, 11, 19, 4, 12, 20, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt16 - The index of Y - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector128<ushort> YGroup3Zip_Shuffle_UInt16_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ushort)2, 9, 10, 3, 12, 13, 4, 15);
        }
#else
            get;
        } = Vector128.Create((ushort)2, 9, 10, 3, 12, 13, 4, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt16 - The index of Z.</summary>
        [CLSCompliant(false)]
        public static Vector128<ushort> YGroup3Zip_Shuffle_UInt16_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ushort)13, 21, 6, 14, 22, 7, 15, 23);
        }
#else
            get;
        } = Vector128.Create((ushort)13, 21, 6, 14, 22, 7, 15, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt16 - The index of Z - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector128<ushort> YGroup3Zip_Shuffle_UInt16_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ushort)8, 5, 10, 11, 6, 13, 14, 7);
        }
#else
            get;
        } = Vector128.Create((ushort)8, 5, 10, 11, 6, 13, 14, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt32 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector128<uint> YGroup3Zip_Shuffle_UInt32_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((uint)0, 4, 8, 1);
        }
#else
            get;
        } = Vector128.Create((uint)0, 4, 8, 1);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt32 - The index of X - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector128<uint> YGroup3Zip_Shuffle_UInt32_X_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((uint)4, 5, 0, 7);
        }
#else
            get;
        } = Vector128.Create((uint)4, 5, 0, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt32 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector128<uint> YGroup3Zip_Shuffle_UInt32_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((uint)5, 9, 2, 6);
        }
#else
            get;
        } = Vector128.Create((uint)5, 9, 2, 6);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt32 - The index of Y - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector128<uint> YGroup3Zip_Shuffle_UInt32_Y_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((uint)4, 1, 6, 7);
        }
#else
            get;
        } = Vector128.Create((uint)4, 1, 6, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt32 - The index of Z.</summary>
        [CLSCompliant(false)]
        public static Vector128<uint> YGroup3Zip_Shuffle_UInt32_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((uint)10, 3, 7, 11);
        }
#else
            get;
        } = Vector128.Create((uint)10, 3, 7, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt32 - The index of Z - Sub part2 combine 0|1.</summary>
        [CLSCompliant(false)]
        public static Vector128<uint> YGroup3Zip_Shuffle_UInt32_Z_Part2Combine {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((uint)2, 5, 6, 3);
        }
#else
            get;
        } = Vector128.Create((uint)2, 5, 6, 3);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt64 - The index of X.</summary>
        [CLSCompliant(false)]
        public static Vector128<ulong> YGroup3Zip_Shuffle_UInt64_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ulong)0, 2);
        }
#else
            get;
        } = Vector128.Create((ulong)0, 2);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt64 - The index of Y.</summary>
        [CLSCompliant(false)]
        public static Vector128<ulong> YGroup3Zip_Shuffle_UInt64_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ulong)4, 1);
        }
#else
            get;
        } = Vector128.Create((ulong)4, 1);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt64 - The index of Y - On 2|0.</summary>
        [CLSCompliant(false)]
        public static Vector128<ulong> YGroup3Zip_Shuffle_UInt64_Y_On20 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ulong)0, 3);
        }
#else
            get;
        } = Vector128.Create((ulong)0, 3);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt64 - The index of Z.</summary>
        [CLSCompliant(false)]
        public static Vector128<ulong> YGroup3Zip_Shuffle_UInt64_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ulong)3, 5);
        }
#else
            get;
        } = Vector128.Create((ulong)3, 5);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle - UInt64 - The index of Z - On 1|2.</summary>
        [CLSCompliant(false)]
        public static Vector128<ulong> YGroup3Zip_Shuffle_UInt64_Z_On12 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((ulong)1, 3);
        }
#else
            get;
        } = Vector128.Create((ulong)1, 3);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt16 - The index of X.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt16_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 16, 17, 32, 33, 2, 3, 18, 19, 34, 35, 4, 5, 20, 21);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 16, 17, 32, 33, 2, 3, 18, 19, 34, 35, 4, 5, 20, 21);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt16 - The index of X - Sub part0.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt16_X_Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)0, 1, -1, -1, -1, -1, 2, 3, -1, -1, -1, -1, 4, 5, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)0, 1, -1, -1, -1, -1, 2, 3, -1, -1, -1, -1, 4, 5, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt16 - The index of X - Sub part1.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt16_X_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, 0, 1, -1, -1, -1, -1, 2, 3, -1, -1, -1, -1, 4, 5).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, 0, 1, -1, -1, -1, -1, 2, 3, -1, -1, -1, -1, 4, 5).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt16 - The index of X - Sub part2.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt16_X_Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, 0, 1, -1, -1, -1, -1, 2, 3, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, 0, 1, -1, -1, -1, -1, 2, 3, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt16 - The index of Y.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt16_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)36, 37, 6, 7, 22, 23, 38, 39, 8, 9, 24, 25, 40, 41, 10, 11);
        }
#else
            get;
        } = Vector128.Create((byte)36, 37, 6, 7, 22, 23, 38, 39, 8, 9, 24, 25, 40, 41, 10, 11);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt16 - The index of Y - Sub part0.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt16_Y_Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, 6, 7, -1, -1, -1, -1, 8, 9, -1, -1, -1, -1, 10, 11).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, 6, 7, -1, -1, -1, -1, 8, 9, -1, -1, -1, -1, 10, 11).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt16 - The index of Y - Sub part1.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt16_Y_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, 6, 7, -1, -1, -1, -1, 8, 9, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, 6, 7, -1, -1, -1, -1, 8, 9, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt16 - The index of Y - Sub part2.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt16_Y_Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)4, 5, -1, -1, -1, -1, 6, 7, -1, -1, -1, -1, 8, 9, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)4, 5, -1, -1, -1, -1, 6, 7, -1, -1, -1, -1, 8, 9, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt16 - The index of Z.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt16_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)26, 27, 42, 43, 12, 13, 28, 29, 44, 45, 14, 15, 30, 31, 46, 47);
        }
#else
            get;
        } = Vector128.Create((byte)26, 27, 42, 43, 12, 13, 28, 29, 44, 45, 14, 15, 30, 31, 46, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt16 - The index of Z - Sub part0.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt16_Z_Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, 12, 13, -1, -1, -1, -1, 14, 15, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, 12, 13, -1, -1, -1, -1, 14, 15, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt16 - The index of Z - Sub part1.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt16_Z_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)10, 11, -1, -1, -1, -1, 12, 13, -1, -1, -1, -1, 14, 15, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)10, 11, -1, -1, -1, -1, 12, 13, -1, -1, -1, -1, 14, 15, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt16 - The index of Z - Sub part2.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt16_Z_Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, 10, 11, -1, -1, -1, -1, 12, 13, -1, -1, -1, -1, 14, 15).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, 10, 11, -1, -1, -1, -1, 12, 13, -1, -1, -1, -1, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt32 - The index of X.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt32_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 2, 3, 16, 17, 18, 19, 32, 33, 34, 35, 4, 5, 6, 7);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 2, 3, 16, 17, 18, 19, 32, 33, 34, 35, 4, 5, 6, 7);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt32 - The index of X - Sub part0.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt32_X_Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt32 - The index of X - Sub part1.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt32_X_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt32 - The index of X - Sub part2.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt32_X_Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt32 - The index of Y.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt32_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)20, 21, 22, 23, 36, 37, 38, 39, 8, 9, 10, 11, 24, 25, 26, 27);
        }
#else
            get;
        } = Vector128.Create((byte)20, 21, 22, 23, 36, 37, 38, 39, 8, 9, 10, 11, 24, 25, 26, 27);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt32 - The index of Y - Sub part0.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt32_Y_Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt32 - The index of Y - Sub part1.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt32_Y_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt32 - The index of Y - Sub part2.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt32_Y_Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt32 - The index of Z.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt32_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)40, 41, 42, 43, 12, 13, 14, 15, 28, 29, 30, 31, 44, 45, 46, 47);
        }
#else
            get;
        } = Vector128.Create((byte)40, 41, 42, 43, 12, 13, 14, 15, 28, 29, 30, 31, 44, 45, 46, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt32 - The index of Z - Sub part0.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt32_Z_Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt32 - The index of Z - Sub part1.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt32_Z_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt32 - The index of Z - Sub part2.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt32_Z_Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)8, 9, 10, 11, -1, -1, -1, -1, -1, -1, -1, -1, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of X.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt64_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 16, 17, 18, 19, 20, 21, 22, 23);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 16, 17, 18, 19, 20, 21, 22, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of X - Sub part0.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt64_X_Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of X - Sub part1.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt64_X_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 0, 1, 2, 3, 4, 5, 6, 7).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of X - Sub part2.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt64_X_Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of Y.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt64_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)32, 33, 34, 35, 36, 37, 38, 39, 8, 9, 10, 11, 12, 13, 14, 15);
        }
#else
            get;
        } = Vector128.Create((byte)32, 33, 34, 35, 36, 37, 38, 39, 8, 9, 10, 11, 12, 13, 14, 15);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of Y - Sub part0.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt64_Y_Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of Y - Sub part1.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt64_Y_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of Y - Sub part2.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt64_Y_Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)0, 1, 2, 3, 4, 5, 6, 7, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of Y - On 2|0.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt64_Y_On20 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 24, 25, 26, 27, 28, 29, 30, 31);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 24, 25, 26, 27, 28, 29, 30, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of Z.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt64_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)24, 25, 26, 27, 28, 29, 30, 31, 40, 41, 42, 43, 44, 45, 46, 47);
        }
#else
            get;
        } = Vector128.Create((byte)24, 25, 26, 27, 28, 29, 30, 31, 40, 41, 42, 43, 44, 45, 46, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of Z - Sub part0.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt64_Z_Part0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of Z - Sub part1.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt64_Z_Part1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)8, 9, 10, 11, 12, 13, 14, 15, -1, -1, -1, -1, -1, -1, -1, -1).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of Z - Sub part2.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt64_Z_Part2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, -1, -1, -1, -1, -1, 8, 9, 10, 11, 12, 13, 14, 15).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup3Zip - Shuffle on byte - UInt64 - The index of Z - On 1|2.</summary>
        public static Vector128<byte> YGroup3Zip_ShuffleOnByte_UInt64_Z_On12 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 24, 25, 26, 27, 28, 29, 30, 31);
        }
#else
            get;
        } = Vector128.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 24, 25, 26, 27, 28, 29, 30, 31);
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup4 - Mask of X,Y,Z (clear W) - Byte.</summary>
        public static Vector128<byte> YGroup4_MaskXYZ_Byte {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((sbyte)-1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0).AsByte();
        }
#else
            get;
        } = Vector128.Create((sbyte)-1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0, -1, -1, -1, 0).AsByte();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4 - Mask of X,Y,Z (clear W) - UInt16.</summary>
        [CLSCompliant(false)]
        public static Vector128<ushort> YGroup4_MaskXYZ_UInt16 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((short)-1, -1, -1, 0, -1, -1, -1, 0).AsUInt16();
        }
#else
            get;
        } = Vector128.Create((short)-1, -1, -1, 0, -1, -1, -1, 0).AsUInt16();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4 - Mask of X,Y,Z (clear W) - UInt32.</summary>
        [CLSCompliant(false)]
        public static Vector128<uint> YGroup4_MaskXYZ_UInt32 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((int)-1, -1, -1, 0).AsUInt32();
        }
#else
            get;
        } = Vector128.Create((int)-1, -1, -1, 0).AsUInt32();
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4 - Mask of X,Y,Z (clear W) - UInt64 - Part 1.</summary>
        [CLSCompliant(false)]
        public static Vector128<ulong> YGroup4_MaskXYZ_UInt64_1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((long)-1, 0).AsUInt64();
        }
#else
            get;
        } = Vector128.Create((long)-1, 0).AsUInt64();
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup4Unzip - ShuffleX4 - Byte - The index of X.</summary>
        public static Vector128<byte> YGroup4Unzip_ShuffleX4_Byte_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60);
        }
#else
            get;
        } = Vector128.Create((byte)0, 4, 8, 12, 16, 20, 24, 28, 32, 36, 40, 44, 48, 52, 56, 60);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX4 - Byte - The index of Y.</summary>
        public static Vector128<byte> YGroup4Unzip_ShuffleX4_Byte_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57, 61);
        }
#else
            get;
        } = Vector128.Create((byte)1, 5, 9, 13, 17, 21, 25, 29, 33, 37, 41, 45, 49, 53, 57, 61);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX4 - Byte - The index of Z.</summary>
        public static Vector128<byte> YGroup4Unzip_ShuffleX4_Byte_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)2, 6, 10, 14, 18, 22, 26, 30, 34, 38, 42, 46, 50, 54, 58, 62);
        }
#else
            get;
        } = Vector128.Create((byte)2, 6, 10, 14, 18, 22, 26, 30, 34, 38, 42, 46, 50, 54, 58, 62);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX4 - Byte - The index of W.</summary>
        public static Vector128<byte> YGroup4Unzip_ShuffleX4_Byte_W {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)3, 7, 11, 15, 19, 23, 27, 31, 35, 39, 43, 47, 51, 55, 59, 63);
        }
#else
            get;
        } = Vector128.Create((byte)3, 7, 11, 15, 19, 23, 27, 31, 35, 39, 43, 47, 51, 55, 59, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX4 on byte - UInt16 - The index of X.</summary>
        public static Vector128<byte> YGroup4Unzip_ShuffleX4OnByte_UInt16_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 8, 9, 16, 17, 24, 25, 32, 33, 40, 41, 48, 49, 56, 57);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 8, 9, 16, 17, 24, 25, 32, 33, 40, 41, 48, 49, 56, 57);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX4 on byte - UInt16 - The index of Y.</summary>
        public static Vector128<byte> YGroup4Unzip_ShuffleX4OnByte_UInt16_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)2, 3, 10, 11, 18, 19, 26, 27, 34, 35, 42, 43, 50, 51, 58, 59);
        }
#else
            get;
        } = Vector128.Create((byte)2, 3, 10, 11, 18, 19, 26, 27, 34, 35, 42, 43, 50, 51, 58, 59);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX4 on byte - UInt16 - The index of Z.</summary>
        public static Vector128<byte> YGroup4Unzip_ShuffleX4OnByte_UInt16_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)4, 5, 12, 13, 20, 21, 28, 29, 36, 37, 44, 45, 52, 53, 60, 61);
        }
#else
            get;
        } = Vector128.Create((byte)4, 5, 12, 13, 20, 21, 28, 29, 36, 37, 44, 45, 52, 53, 60, 61);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX4 on byte - UInt16 - The index of W.</summary>
        public static Vector128<byte> YGroup4Unzip_ShuffleX4OnByte_UInt16_W {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)6, 7, 14, 15, 22, 23, 30, 31, 38, 39, 46, 47, 54, 55, 62, 63);
        }
#else
            get;
        } = Vector128.Create((byte)6, 7, 14, 15, 22, 23, 30, 31, 38, 39, 46, 47, 54, 55, 62, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX4 on byte - UInt32 - The index of X.</summary>
        public static Vector128<byte> YGroup4Unzip_ShuffleX4OnByte_UInt32_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 2, 3, 16, 17, 18, 19, 32, 33, 34, 35, 48, 49, 50, 51);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 2, 3, 16, 17, 18, 19, 32, 33, 34, 35, 48, 49, 50, 51);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX4 on byte - UInt32 - The index of Y.</summary>
        public static Vector128<byte> YGroup4Unzip_ShuffleX4OnByte_UInt32_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)4, 5, 6, 7, 20, 21, 22, 23, 36, 37, 38, 39, 52, 53, 54, 55);
        }
#else
            get;
        } = Vector128.Create((byte)4, 5, 6, 7, 20, 21, 22, 23, 36, 37, 38, 39, 52, 53, 54, 55);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX4 on byte - UInt32 - The index of Z.</summary>
        public static Vector128<byte> YGroup4Unzip_ShuffleX4OnByte_UInt32_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)8, 9, 10, 11, 24, 25, 26, 27, 40, 41, 42, 43, 56, 57, 58, 59);
        }
#else
            get;
        } = Vector128.Create((byte)8, 9, 10, 11, 24, 25, 26, 27, 40, 41, 42, 43, 56, 57, 58, 59);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX4 on byte - UInt32 - The index of W.</summary>
        public static Vector128<byte> YGroup4Unzip_ShuffleX4OnByte_UInt32_W {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)12, 13, 14, 15, 28, 29, 30, 31, 44, 45, 46, 47, 60, 61, 62, 63);
        }
#else
            get;
        } = Vector128.Create((byte)12, 13, 14, 15, 28, 29, 30, 31, 44, 45, 46, 47, 60, 61, 62, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX4 on byte - UInt64 - The index of X.</summary>
        public static Vector128<byte> YGroup4Unzip_ShuffleX4OnByte_UInt64_X {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 32, 33, 34, 35, 36, 37, 38, 39);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 32, 33, 34, 35, 36, 37, 38, 39);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX4 on byte - UInt64 - The index of Y.</summary>
        public static Vector128<byte> YGroup4Unzip_ShuffleX4OnByte_UInt64_Y {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 40, 41, 42, 43, 44, 45, 46, 47);
        }
#else
            get;
        } = Vector128.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 40, 41, 42, 43, 44, 45, 46, 47);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX4 on byte - UInt64 - The index of Z.</summary>
        public static Vector128<byte> YGroup4Unzip_ShuffleX4OnByte_UInt64_Z {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 48, 49, 50, 51, 52, 53, 54, 55);
        }
#else
            get;
        } = Vector128.Create((byte)16, 17, 18, 19, 20, 21, 22, 23, 48, 49, 50, 51, 52, 53, 54, 55);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Unzip - ShuffleX4 on byte - UInt64 - The index of W.</summary>
        public static Vector128<byte> YGroup4Unzip_ShuffleX4OnByte_UInt64_W {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)24, 25, 26, 27, 28, 29, 30, 31, 56, 57, 58, 59, 60, 61, 62, 63);
        }
#else
            get;
        } = Vector128.Create((byte)24, 25, 26, 27, 28, 29, 30, 31, 56, 57, 58, 59, 60, 61, 62, 63);
#endif // USE_VECTOR_CREATE


        /// <summary>YGroup4Zip - ShuffleX4 - Byte - The index of data0.</summary>
        public static Vector128<byte> YGroup4Zip_ShuffleX4_Byte_Data0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 16, 32, 48, 1, 17, 33, 49, 2, 18, 34, 50, 3, 19, 35, 51);
        }
#else
            get;
        } = Vector128.Create((byte)0, 16, 32, 48, 1, 17, 33, 49, 2, 18, 34, 50, 3, 19, 35, 51);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX4 - Byte - The index of data1.</summary>
        public static Vector128<byte> YGroup4Zip_ShuffleX4_Byte_Data1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)4, 20, 36, 52, 5, 21, 37, 53, 6, 22, 38, 54, 7, 23, 39, 55);
        }
#else
            get;
        } = Vector128.Create((byte)4, 20, 36, 52, 5, 21, 37, 53, 6, 22, 38, 54, 7, 23, 39, 55);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX4 - Byte - The index of data2.</summary>
        public static Vector128<byte> YGroup4Zip_ShuffleX4_Byte_Data2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)8, 24, 40, 56, 9, 25, 41, 57, 10, 26, 42, 58, 11, 27, 43, 59);
        }
#else
            get;
        } = Vector128.Create((byte)8, 24, 40, 56, 9, 25, 41, 57, 10, 26, 42, 58, 11, 27, 43, 59);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX4 - Byte - The index of data3.</summary>
        public static Vector128<byte> YGroup4Zip_ShuffleX4_Byte_Data3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)12, 28, 44, 60, 13, 29, 45, 61, 14, 30, 46, 62, 15, 31, 47, 63);
        }
#else
            get;
        } = Vector128.Create((byte)12, 28, 44, 60, 13, 29, 45, 61, 14, 30, 46, 62, 15, 31, 47, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX4 on byte - UInt16 - The index of data0.</summary>
        public static Vector128<byte> YGroup4Zip_ShuffleX4OnByte_UInt16_Data0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 16, 17, 32, 33, 48, 49, 2, 3, 18, 19, 34, 35, 50, 51);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 16, 17, 32, 33, 48, 49, 2, 3, 18, 19, 34, 35, 50, 51);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX4 on byte - UInt16 - The index of data1.</summary>
        public static Vector128<byte> YGroup4Zip_ShuffleX4OnByte_UInt16_Data1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)4, 5, 20, 21, 36, 37, 52, 53, 6, 7, 22, 23, 38, 39, 54, 55);
        }
#else
            get;
        } = Vector128.Create((byte)4, 5, 20, 21, 36, 37, 52, 53, 6, 7, 22, 23, 38, 39, 54, 55);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX4 on byte - UInt16 - The index of data2.</summary>
        public static Vector128<byte> YGroup4Zip_ShuffleX4OnByte_UInt16_Data2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)8, 9, 24, 25, 40, 41, 56, 57, 10, 11, 26, 27, 42, 43, 58, 59);
        }
#else
            get;
        } = Vector128.Create((byte)8, 9, 24, 25, 40, 41, 56, 57, 10, 11, 26, 27, 42, 43, 58, 59);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX4 on byte - UInt16 - The index of data3.</summary>
        public static Vector128<byte> YGroup4Zip_ShuffleX4OnByte_UInt16_Data3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)12, 13, 28, 29, 44, 45, 60, 61, 14, 15, 30, 31, 46, 47, 62, 63);
        }
#else
            get;
        } = Vector128.Create((byte)12, 13, 28, 29, 44, 45, 60, 61, 14, 15, 30, 31, 46, 47, 62, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX4 on byte - UInt32 - The index of data0.</summary>
        public static Vector128<byte> YGroup4Zip_ShuffleX4OnByte_UInt32_Data0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 2, 3, 16, 17, 18, 19, 32, 33, 34, 35, 48, 49, 50, 51);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 2, 3, 16, 17, 18, 19, 32, 33, 34, 35, 48, 49, 50, 51);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX4 on byte - UInt32 - The index of data1.</summary>
        public static Vector128<byte> YGroup4Zip_ShuffleX4OnByte_UInt32_Data1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)4, 5, 6, 7, 20, 21, 22, 23, 36, 37, 38, 39, 52, 53, 54, 55);
        }
#else
            get;
        } = Vector128.Create((byte)4, 5, 6, 7, 20, 21, 22, 23, 36, 37, 38, 39, 52, 53, 54, 55);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX4 on byte - UInt32 - The index of data2.</summary>
        public static Vector128<byte> YGroup4Zip_ShuffleX4OnByte_UInt32_Data2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)8, 9, 10, 11, 24, 25, 26, 27, 40, 41, 42, 43, 56, 57, 58, 59);
        }
#else
            get;
        } = Vector128.Create((byte)8, 9, 10, 11, 24, 25, 26, 27, 40, 41, 42, 43, 56, 57, 58, 59);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX4 on byte - UInt32 - The index of data3.</summary>
        public static Vector128<byte> YGroup4Zip_ShuffleX4OnByte_UInt32_Data3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)12, 13, 14, 15, 28, 29, 30, 31, 44, 45, 46, 47, 60, 61, 62, 63);
        }
#else
            get;
        } = Vector128.Create((byte)12, 13, 14, 15, 28, 29, 30, 31, 44, 45, 46, 47, 60, 61, 62, 63);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX4 on byte - UInt64 - The index of data0.</summary>
        public static Vector128<byte> YGroup4Zip_ShuffleX4OnByte_UInt64_Data0 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 16, 17, 18, 19, 20, 21, 22, 23);
        }
#else
            get;
        } = Vector128.Create((byte)0, 1, 2, 3, 4, 5, 6, 7, 16, 17, 18, 19, 20, 21, 22, 23);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX4 on byte - UInt64 - The index of data1.</summary>
        public static Vector128<byte> YGroup4Zip_ShuffleX4OnByte_UInt64_Data1 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)32, 33, 34, 35, 36, 37, 38, 39, 48, 49, 50, 51, 52, 53, 54, 55);
        }
#else
            get;
        } = Vector128.Create((byte)32, 33, 34, 35, 36, 37, 38, 39, 48, 49, 50, 51, 52, 53, 54, 55);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX4 on byte - UInt64 - The index of data2.</summary>
        public static Vector128<byte> YGroup4Zip_ShuffleX4OnByte_UInt64_Data2 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 24, 25, 26, 27, 28, 29, 30, 31);
        }
#else
            get;
        } = Vector128.Create((byte)8, 9, 10, 11, 12, 13, 14, 15, 24, 25, 26, 27, 28, 29, 30, 31);
#endif // USE_VECTOR_CREATE

        /// <summary>YGroup4Zip - ShuffleX4 on byte - UInt64 - The index of data3.</summary>
        public static Vector128<byte> YGroup4Zip_ShuffleX4OnByte_UInt64_Data3 {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if USE_VECTOR_CREATE
            get => Vector128.Create((byte)40, 41, 42, 43, 44, 45, 46, 47, 56, 57, 58, 59, 60, 61, 62, 63);
        }
#else
            get;
        } = Vector128.Create((byte)40, 41, 42, 43, 44, 45, 46, 47, 56, 57, 58, 59, 60, 61, 62, 63);
#endif // USE_VECTOR_CREATE

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
