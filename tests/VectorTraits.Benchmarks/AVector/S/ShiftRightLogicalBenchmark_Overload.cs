
using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Benchmarks.AVector.S {

    partial class ShiftRightLogicalBenchmark_Byte {

        // StaticSumSRLTraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Byte StaticSumSRLTraitsOverload(VectorTraitsBase vectorTraits, Byte[] src, int srcCount, int shiftAmount) {
            Byte rt = 0; // Result.
            int VectorWidth = Vector<Byte>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Byte> vrt = Vector<Byte>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Byte>(shiftAmount);
            fixed (Byte* p0 = &src[0]) {
                Byte* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Byte> vtemp = vectorTraits.ShiftRightLogical(*(Vector<Byte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Byte)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLFastTraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Byte StaticSumSRLFastTraitsOverload(VectorTraitsBase vectorTraits, Byte[] src, int srcCount, int shiftAmount) {
            Byte rt = 0; // Result.
            int VectorWidth = Vector<Byte>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Byte> vrt = Vector<Byte>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Byte>(shiftAmount);
            fixed (Byte* p0 = &src[0]) {
                Byte* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Byte> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<Byte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Byte)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLTraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Byte StaticSumSRLTraitsOverload(VectorTraits128Base vectorTraits, Byte[] src, int srcCount, int shiftAmount) {
            Byte rt = 0; // Result.
            int VectorWidth = Vector<Byte>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Byte> vrt = Vector<Byte>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Byte>(shiftAmount);
            fixed (Byte* p0 = &src[0]) {
                Byte* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Byte> vtemp = vectorTraits.ShiftRightLogical(*(Vector<Byte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Byte)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLFastTraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Byte StaticSumSRLFastTraitsOverload(VectorTraits128Base vectorTraits, Byte[] src, int srcCount, int shiftAmount) {
            Byte rt = 0; // Result.
            int VectorWidth = Vector<Byte>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Byte> vrt = Vector<Byte>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Byte>(shiftAmount);
            fixed (Byte* p0 = &src[0]) {
                Byte* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Byte> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<Byte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Byte)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLTraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Byte StaticSumSRLTraitsOverload(VectorTraits128AdvSimd vectorTraits, Byte[] src, int srcCount, int shiftAmount) {
            Byte rt = 0; // Result.
            int VectorWidth = Vector<Byte>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Byte> vrt = Vector<Byte>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Byte>(shiftAmount);
            fixed (Byte* p0 = &src[0]) {
                Byte* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Byte> vtemp = vectorTraits.ShiftRightLogical(*(Vector<Byte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Byte)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLFastTraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Byte StaticSumSRLFastTraitsOverload(VectorTraits128AdvSimd vectorTraits, Byte[] src, int srcCount, int shiftAmount) {
            Byte rt = 0; // Result.
            int VectorWidth = Vector<Byte>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Byte> vrt = Vector<Byte>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Byte>(shiftAmount);
            fixed (Byte* p0 = &src[0]) {
                Byte* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Byte> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<Byte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Byte)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLTraitsOverload - VectorTraits128AdvSimdA64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Byte StaticSumSRLTraitsOverload(VectorTraits128AdvSimdA64 vectorTraits, Byte[] src, int srcCount, int shiftAmount) {
            Byte rt = 0; // Result.
            int VectorWidth = Vector<Byte>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Byte> vrt = Vector<Byte>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Byte>(shiftAmount);
            fixed (Byte* p0 = &src[0]) {
                Byte* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Byte> vtemp = vectorTraits.ShiftRightLogical(*(Vector<Byte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Byte)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLFastTraitsOverload - VectorTraits128AdvSimdA64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Byte StaticSumSRLFastTraitsOverload(VectorTraits128AdvSimdA64 vectorTraits, Byte[] src, int srcCount, int shiftAmount) {
            Byte rt = 0; // Result.
            int VectorWidth = Vector<Byte>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Byte> vrt = Vector<Byte>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Byte>(shiftAmount);
            fixed (Byte* p0 = &src[0]) {
                Byte* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Byte> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<Byte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Byte)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLTraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Byte StaticSumSRLTraitsOverload(VectorTraits256Base vectorTraits, Byte[] src, int srcCount, int shiftAmount) {
            Byte rt = 0; // Result.
            int VectorWidth = Vector<Byte>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Byte> vrt = Vector<Byte>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Byte>(shiftAmount);
            fixed (Byte* p0 = &src[0]) {
                Byte* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Byte> vtemp = vectorTraits.ShiftRightLogical(*(Vector<Byte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Byte)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLFastTraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Byte StaticSumSRLFastTraitsOverload(VectorTraits256Base vectorTraits, Byte[] src, int srcCount, int shiftAmount) {
            Byte rt = 0; // Result.
            int VectorWidth = Vector<Byte>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Byte> vrt = Vector<Byte>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Byte>(shiftAmount);
            fixed (Byte* p0 = &src[0]) {
                Byte* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Byte> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<Byte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Byte)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLTraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Byte StaticSumSRLTraitsOverload(VectorTraits256Avx2 vectorTraits, Byte[] src, int srcCount, int shiftAmount) {
            Byte rt = 0; // Result.
            int VectorWidth = Vector<Byte>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Byte> vrt = Vector<Byte>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Byte>(shiftAmount);
            fixed (Byte* p0 = &src[0]) {
                Byte* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Byte> vtemp = vectorTraits.ShiftRightLogical(*(Vector<Byte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Byte)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLFastTraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Byte StaticSumSRLFastTraitsOverload(VectorTraits256Avx2 vectorTraits, Byte[] src, int srcCount, int shiftAmount) {
            Byte rt = 0; // Result.
            int VectorWidth = Vector<Byte>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Byte> vrt = Vector<Byte>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Byte>(shiftAmount);
            fixed (Byte* p0 = &src[0]) {
                Byte* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Byte> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<Byte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Byte)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }


    } // End: partial class ShiftRightLogicalBenchmark_Byte

    partial class ShiftRightLogicalBenchmark_UInt16 {

        // StaticSumSRLTraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt16 StaticSumSRLTraitsOverload(VectorTraitsBase vectorTraits, UInt16[] src, int srcCount, int shiftAmount) {
            UInt16 rt = 0; // Result.
            int VectorWidth = Vector<UInt16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt16> vrt = Vector<UInt16>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt16>(shiftAmount);
            fixed (UInt16* p0 = &src[0]) {
                UInt16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt16> vtemp = vectorTraits.ShiftRightLogical(*(Vector<UInt16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt16)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLFastTraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt16 StaticSumSRLFastTraitsOverload(VectorTraitsBase vectorTraits, UInt16[] src, int srcCount, int shiftAmount) {
            UInt16 rt = 0; // Result.
            int VectorWidth = Vector<UInt16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt16> vrt = Vector<UInt16>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt16>(shiftAmount);
            fixed (UInt16* p0 = &src[0]) {
                UInt16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt16> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<UInt16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt16)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLTraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt16 StaticSumSRLTraitsOverload(VectorTraits128Base vectorTraits, UInt16[] src, int srcCount, int shiftAmount) {
            UInt16 rt = 0; // Result.
            int VectorWidth = Vector<UInt16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt16> vrt = Vector<UInt16>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt16>(shiftAmount);
            fixed (UInt16* p0 = &src[0]) {
                UInt16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt16> vtemp = vectorTraits.ShiftRightLogical(*(Vector<UInt16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt16)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLFastTraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt16 StaticSumSRLFastTraitsOverload(VectorTraits128Base vectorTraits, UInt16[] src, int srcCount, int shiftAmount) {
            UInt16 rt = 0; // Result.
            int VectorWidth = Vector<UInt16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt16> vrt = Vector<UInt16>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt16>(shiftAmount);
            fixed (UInt16* p0 = &src[0]) {
                UInt16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt16> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<UInt16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt16)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLTraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt16 StaticSumSRLTraitsOverload(VectorTraits128AdvSimd vectorTraits, UInt16[] src, int srcCount, int shiftAmount) {
            UInt16 rt = 0; // Result.
            int VectorWidth = Vector<UInt16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt16> vrt = Vector<UInt16>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt16>(shiftAmount);
            fixed (UInt16* p0 = &src[0]) {
                UInt16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt16> vtemp = vectorTraits.ShiftRightLogical(*(Vector<UInt16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt16)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLFastTraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt16 StaticSumSRLFastTraitsOverload(VectorTraits128AdvSimd vectorTraits, UInt16[] src, int srcCount, int shiftAmount) {
            UInt16 rt = 0; // Result.
            int VectorWidth = Vector<UInt16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt16> vrt = Vector<UInt16>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt16>(shiftAmount);
            fixed (UInt16* p0 = &src[0]) {
                UInt16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt16> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<UInt16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt16)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLTraitsOverload - VectorTraits128AdvSimdA64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt16 StaticSumSRLTraitsOverload(VectorTraits128AdvSimdA64 vectorTraits, UInt16[] src, int srcCount, int shiftAmount) {
            UInt16 rt = 0; // Result.
            int VectorWidth = Vector<UInt16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt16> vrt = Vector<UInt16>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt16>(shiftAmount);
            fixed (UInt16* p0 = &src[0]) {
                UInt16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt16> vtemp = vectorTraits.ShiftRightLogical(*(Vector<UInt16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt16)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLFastTraitsOverload - VectorTraits128AdvSimdA64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt16 StaticSumSRLFastTraitsOverload(VectorTraits128AdvSimdA64 vectorTraits, UInt16[] src, int srcCount, int shiftAmount) {
            UInt16 rt = 0; // Result.
            int VectorWidth = Vector<UInt16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt16> vrt = Vector<UInt16>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt16>(shiftAmount);
            fixed (UInt16* p0 = &src[0]) {
                UInt16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt16> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<UInt16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt16)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLTraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt16 StaticSumSRLTraitsOverload(VectorTraits256Base vectorTraits, UInt16[] src, int srcCount, int shiftAmount) {
            UInt16 rt = 0; // Result.
            int VectorWidth = Vector<UInt16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt16> vrt = Vector<UInt16>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt16>(shiftAmount);
            fixed (UInt16* p0 = &src[0]) {
                UInt16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt16> vtemp = vectorTraits.ShiftRightLogical(*(Vector<UInt16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt16)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLFastTraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt16 StaticSumSRLFastTraitsOverload(VectorTraits256Base vectorTraits, UInt16[] src, int srcCount, int shiftAmount) {
            UInt16 rt = 0; // Result.
            int VectorWidth = Vector<UInt16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt16> vrt = Vector<UInt16>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt16>(shiftAmount);
            fixed (UInt16* p0 = &src[0]) {
                UInt16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt16> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<UInt16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt16)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLTraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt16 StaticSumSRLTraitsOverload(VectorTraits256Avx2 vectorTraits, UInt16[] src, int srcCount, int shiftAmount) {
            UInt16 rt = 0; // Result.
            int VectorWidth = Vector<UInt16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt16> vrt = Vector<UInt16>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt16>(shiftAmount);
            fixed (UInt16* p0 = &src[0]) {
                UInt16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt16> vtemp = vectorTraits.ShiftRightLogical(*(Vector<UInt16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt16)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLFastTraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt16 StaticSumSRLFastTraitsOverload(VectorTraits256Avx2 vectorTraits, UInt16[] src, int srcCount, int shiftAmount) {
            UInt16 rt = 0; // Result.
            int VectorWidth = Vector<UInt16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt16> vrt = Vector<UInt16>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt16>(shiftAmount);
            fixed (UInt16* p0 = &src[0]) {
                UInt16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt16> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<UInt16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt16)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }


    } // End: partial class ShiftRightLogicalBenchmark_UInt16

    partial class ShiftRightLogicalBenchmark_UInt32 {

        // StaticSumSRLTraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt32 StaticSumSRLTraitsOverload(VectorTraitsBase vectorTraits, UInt32[] src, int srcCount, int shiftAmount) {
            UInt32 rt = 0; // Result.
            int VectorWidth = Vector<UInt32>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt32> vrt = Vector<UInt32>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt32>(shiftAmount);
            fixed (UInt32* p0 = &src[0]) {
                UInt32* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt32> vtemp = vectorTraits.ShiftRightLogical(*(Vector<UInt32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt32)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLFastTraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt32 StaticSumSRLFastTraitsOverload(VectorTraitsBase vectorTraits, UInt32[] src, int srcCount, int shiftAmount) {
            UInt32 rt = 0; // Result.
            int VectorWidth = Vector<UInt32>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt32> vrt = Vector<UInt32>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt32>(shiftAmount);
            fixed (UInt32* p0 = &src[0]) {
                UInt32* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt32> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<UInt32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt32)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLTraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt32 StaticSumSRLTraitsOverload(VectorTraits128Base vectorTraits, UInt32[] src, int srcCount, int shiftAmount) {
            UInt32 rt = 0; // Result.
            int VectorWidth = Vector<UInt32>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt32> vrt = Vector<UInt32>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt32>(shiftAmount);
            fixed (UInt32* p0 = &src[0]) {
                UInt32* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt32> vtemp = vectorTraits.ShiftRightLogical(*(Vector<UInt32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt32)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLFastTraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt32 StaticSumSRLFastTraitsOverload(VectorTraits128Base vectorTraits, UInt32[] src, int srcCount, int shiftAmount) {
            UInt32 rt = 0; // Result.
            int VectorWidth = Vector<UInt32>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt32> vrt = Vector<UInt32>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt32>(shiftAmount);
            fixed (UInt32* p0 = &src[0]) {
                UInt32* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt32> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<UInt32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt32)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLTraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt32 StaticSumSRLTraitsOverload(VectorTraits128AdvSimd vectorTraits, UInt32[] src, int srcCount, int shiftAmount) {
            UInt32 rt = 0; // Result.
            int VectorWidth = Vector<UInt32>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt32> vrt = Vector<UInt32>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt32>(shiftAmount);
            fixed (UInt32* p0 = &src[0]) {
                UInt32* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt32> vtemp = vectorTraits.ShiftRightLogical(*(Vector<UInt32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt32)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLFastTraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt32 StaticSumSRLFastTraitsOverload(VectorTraits128AdvSimd vectorTraits, UInt32[] src, int srcCount, int shiftAmount) {
            UInt32 rt = 0; // Result.
            int VectorWidth = Vector<UInt32>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt32> vrt = Vector<UInt32>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt32>(shiftAmount);
            fixed (UInt32* p0 = &src[0]) {
                UInt32* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt32> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<UInt32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt32)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLTraitsOverload - VectorTraits128AdvSimdA64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt32 StaticSumSRLTraitsOverload(VectorTraits128AdvSimdA64 vectorTraits, UInt32[] src, int srcCount, int shiftAmount) {
            UInt32 rt = 0; // Result.
            int VectorWidth = Vector<UInt32>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt32> vrt = Vector<UInt32>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt32>(shiftAmount);
            fixed (UInt32* p0 = &src[0]) {
                UInt32* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt32> vtemp = vectorTraits.ShiftRightLogical(*(Vector<UInt32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt32)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLFastTraitsOverload - VectorTraits128AdvSimdA64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt32 StaticSumSRLFastTraitsOverload(VectorTraits128AdvSimdA64 vectorTraits, UInt32[] src, int srcCount, int shiftAmount) {
            UInt32 rt = 0; // Result.
            int VectorWidth = Vector<UInt32>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt32> vrt = Vector<UInt32>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt32>(shiftAmount);
            fixed (UInt32* p0 = &src[0]) {
                UInt32* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt32> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<UInt32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt32)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLTraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt32 StaticSumSRLTraitsOverload(VectorTraits256Base vectorTraits, UInt32[] src, int srcCount, int shiftAmount) {
            UInt32 rt = 0; // Result.
            int VectorWidth = Vector<UInt32>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt32> vrt = Vector<UInt32>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt32>(shiftAmount);
            fixed (UInt32* p0 = &src[0]) {
                UInt32* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt32> vtemp = vectorTraits.ShiftRightLogical(*(Vector<UInt32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt32)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLFastTraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt32 StaticSumSRLFastTraitsOverload(VectorTraits256Base vectorTraits, UInt32[] src, int srcCount, int shiftAmount) {
            UInt32 rt = 0; // Result.
            int VectorWidth = Vector<UInt32>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt32> vrt = Vector<UInt32>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt32>(shiftAmount);
            fixed (UInt32* p0 = &src[0]) {
                UInt32* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt32> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<UInt32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt32)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLTraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt32 StaticSumSRLTraitsOverload(VectorTraits256Avx2 vectorTraits, UInt32[] src, int srcCount, int shiftAmount) {
            UInt32 rt = 0; // Result.
            int VectorWidth = Vector<UInt32>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt32> vrt = Vector<UInt32>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt32>(shiftAmount);
            fixed (UInt32* p0 = &src[0]) {
                UInt32* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt32> vtemp = vectorTraits.ShiftRightLogical(*(Vector<UInt32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt32)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLFastTraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt32 StaticSumSRLFastTraitsOverload(VectorTraits256Avx2 vectorTraits, UInt32[] src, int srcCount, int shiftAmount) {
            UInt32 rt = 0; // Result.
            int VectorWidth = Vector<UInt32>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt32> vrt = Vector<UInt32>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt32>(shiftAmount);
            fixed (UInt32* p0 = &src[0]) {
                UInt32* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt32> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<UInt32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt32)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }


    } // End: partial class ShiftRightLogicalBenchmark_UInt32

    partial class ShiftRightLogicalBenchmark_UInt64 {

        // StaticSumSRLTraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt64 StaticSumSRLTraitsOverload(VectorTraitsBase vectorTraits, UInt64[] src, int srcCount, int shiftAmount) {
            UInt64 rt = 0; // Result.
            int VectorWidth = Vector<UInt64>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt64> vrt = Vector<UInt64>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt64>(shiftAmount);
            fixed (UInt64* p0 = &src[0]) {
                UInt64* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt64> vtemp = vectorTraits.ShiftRightLogical(*(Vector<UInt64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt64)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLFastTraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt64 StaticSumSRLFastTraitsOverload(VectorTraitsBase vectorTraits, UInt64[] src, int srcCount, int shiftAmount) {
            UInt64 rt = 0; // Result.
            int VectorWidth = Vector<UInt64>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt64> vrt = Vector<UInt64>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt64>(shiftAmount);
            fixed (UInt64* p0 = &src[0]) {
                UInt64* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt64> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<UInt64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt64)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLTraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt64 StaticSumSRLTraitsOverload(VectorTraits128Base vectorTraits, UInt64[] src, int srcCount, int shiftAmount) {
            UInt64 rt = 0; // Result.
            int VectorWidth = Vector<UInt64>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt64> vrt = Vector<UInt64>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt64>(shiftAmount);
            fixed (UInt64* p0 = &src[0]) {
                UInt64* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt64> vtemp = vectorTraits.ShiftRightLogical(*(Vector<UInt64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt64)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLFastTraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt64 StaticSumSRLFastTraitsOverload(VectorTraits128Base vectorTraits, UInt64[] src, int srcCount, int shiftAmount) {
            UInt64 rt = 0; // Result.
            int VectorWidth = Vector<UInt64>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt64> vrt = Vector<UInt64>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt64>(shiftAmount);
            fixed (UInt64* p0 = &src[0]) {
                UInt64* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt64> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<UInt64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt64)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLTraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt64 StaticSumSRLTraitsOverload(VectorTraits128AdvSimd vectorTraits, UInt64[] src, int srcCount, int shiftAmount) {
            UInt64 rt = 0; // Result.
            int VectorWidth = Vector<UInt64>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt64> vrt = Vector<UInt64>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt64>(shiftAmount);
            fixed (UInt64* p0 = &src[0]) {
                UInt64* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt64> vtemp = vectorTraits.ShiftRightLogical(*(Vector<UInt64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt64)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLFastTraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt64 StaticSumSRLFastTraitsOverload(VectorTraits128AdvSimd vectorTraits, UInt64[] src, int srcCount, int shiftAmount) {
            UInt64 rt = 0; // Result.
            int VectorWidth = Vector<UInt64>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt64> vrt = Vector<UInt64>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt64>(shiftAmount);
            fixed (UInt64* p0 = &src[0]) {
                UInt64* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt64> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<UInt64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt64)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLTraitsOverload - VectorTraits128AdvSimdA64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt64 StaticSumSRLTraitsOverload(VectorTraits128AdvSimdA64 vectorTraits, UInt64[] src, int srcCount, int shiftAmount) {
            UInt64 rt = 0; // Result.
            int VectorWidth = Vector<UInt64>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt64> vrt = Vector<UInt64>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt64>(shiftAmount);
            fixed (UInt64* p0 = &src[0]) {
                UInt64* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt64> vtemp = vectorTraits.ShiftRightLogical(*(Vector<UInt64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt64)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLFastTraitsOverload - VectorTraits128AdvSimdA64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt64 StaticSumSRLFastTraitsOverload(VectorTraits128AdvSimdA64 vectorTraits, UInt64[] src, int srcCount, int shiftAmount) {
            UInt64 rt = 0; // Result.
            int VectorWidth = Vector<UInt64>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt64> vrt = Vector<UInt64>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt64>(shiftAmount);
            fixed (UInt64* p0 = &src[0]) {
                UInt64* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt64> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<UInt64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt64)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLTraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt64 StaticSumSRLTraitsOverload(VectorTraits256Base vectorTraits, UInt64[] src, int srcCount, int shiftAmount) {
            UInt64 rt = 0; // Result.
            int VectorWidth = Vector<UInt64>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt64> vrt = Vector<UInt64>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt64>(shiftAmount);
            fixed (UInt64* p0 = &src[0]) {
                UInt64* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt64> vtemp = vectorTraits.ShiftRightLogical(*(Vector<UInt64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt64)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLFastTraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt64 StaticSumSRLFastTraitsOverload(VectorTraits256Base vectorTraits, UInt64[] src, int srcCount, int shiftAmount) {
            UInt64 rt = 0; // Result.
            int VectorWidth = Vector<UInt64>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt64> vrt = Vector<UInt64>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt64>(shiftAmount);
            fixed (UInt64* p0 = &src[0]) {
                UInt64* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt64> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<UInt64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt64)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLTraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt64 StaticSumSRLTraitsOverload(VectorTraits256Avx2 vectorTraits, UInt64[] src, int srcCount, int shiftAmount) {
            UInt64 rt = 0; // Result.
            int VectorWidth = Vector<UInt64>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt64> vrt = Vector<UInt64>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt64>(shiftAmount);
            fixed (UInt64* p0 = &src[0]) {
                UInt64* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt64> vtemp = vectorTraits.ShiftRightLogical(*(Vector<UInt64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt64)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRLFastTraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe UInt64 StaticSumSRLFastTraitsOverload(VectorTraits256Avx2 vectorTraits, UInt64[] src, int srcCount, int shiftAmount) {
            UInt64 rt = 0; // Result.
            int VectorWidth = Vector<UInt64>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<UInt64> vrt = Vector<UInt64>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<UInt64>(shiftAmount);
            fixed (UInt64* p0 = &src[0]) {
                UInt64* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<UInt64> vtemp = vectorTraits.ShiftRightLogicalFast(*(Vector<UInt64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (UInt64)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }


    } // End: partial class ShiftRightLogicalBenchmark_UInt64


}

