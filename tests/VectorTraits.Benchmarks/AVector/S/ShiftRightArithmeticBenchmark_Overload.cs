
using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.AVector;

namespace Zyl.VectorTraits.Benchmarks.AVector.S {

    partial class ShiftRightArithmeticBenchmark_SByte {

        // StaticSumSRATraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe SByte StaticSumSRATraitsOverload(VectorTraitsBase vectorTraits, SByte[] src, int srcCount, int shiftAmount) {
            SByte rt = 0; // Result.
            int VectorWidth = Vector<SByte>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<SByte> vrt = Vector<SByte>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<SByte>(shiftAmount);
            fixed (SByte* p0 = &src[0]) {
                SByte* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<SByte> vtemp = vectorTraits.ShiftRightArithmetic(*(Vector<SByte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (SByte)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRAFastTraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe SByte StaticSumSRAFastTraitsOverload(VectorTraitsBase vectorTraits, SByte[] src, int srcCount, int shiftAmount) {
            SByte rt = 0; // Result.
            int VectorWidth = Vector<SByte>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<SByte> vrt = Vector<SByte>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<SByte>(shiftAmount);
            fixed (SByte* p0 = &src[0]) {
                SByte* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<SByte> vtemp = vectorTraits.ShiftRightArithmetic_Fast(*(Vector<SByte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (SByte)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRATraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe SByte StaticSumSRATraitsOverload(VectorTraits128Base vectorTraits, SByte[] src, int srcCount, int shiftAmount) {
            SByte rt = 0; // Result.
            int VectorWidth = Vector<SByte>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<SByte> vrt = Vector<SByte>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<SByte>(shiftAmount);
            fixed (SByte* p0 = &src[0]) {
                SByte* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<SByte> vtemp = vectorTraits.ShiftRightArithmetic(*(Vector<SByte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (SByte)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRAFastTraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe SByte StaticSumSRAFastTraitsOverload(VectorTraits128Base vectorTraits, SByte[] src, int srcCount, int shiftAmount) {
            SByte rt = 0; // Result.
            int VectorWidth = Vector<SByte>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<SByte> vrt = Vector<SByte>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<SByte>(shiftAmount);
            fixed (SByte* p0 = &src[0]) {
                SByte* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<SByte> vtemp = vectorTraits.ShiftRightArithmetic_Fast(*(Vector<SByte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (SByte)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRATraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe SByte StaticSumSRATraitsOverload(VectorTraits128AdvSimd vectorTraits, SByte[] src, int srcCount, int shiftAmount) {
            SByte rt = 0; // Result.
            int VectorWidth = Vector<SByte>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<SByte> vrt = Vector<SByte>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<SByte>(shiftAmount);
            fixed (SByte* p0 = &src[0]) {
                SByte* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<SByte> vtemp = vectorTraits.ShiftRightArithmetic(*(Vector<SByte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (SByte)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRAFastTraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe SByte StaticSumSRAFastTraitsOverload(VectorTraits128AdvSimd vectorTraits, SByte[] src, int srcCount, int shiftAmount) {
            SByte rt = 0; // Result.
            int VectorWidth = Vector<SByte>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<SByte> vrt = Vector<SByte>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<SByte>(shiftAmount);
            fixed (SByte* p0 = &src[0]) {
                SByte* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<SByte> vtemp = vectorTraits.ShiftRightArithmetic_Fast(*(Vector<SByte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (SByte)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRATraitsOverload - VectorTraits128AdvSimdB64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe SByte StaticSumSRATraitsOverload(VectorTraits128AdvSimdB64 vectorTraits, SByte[] src, int srcCount, int shiftAmount) {
            SByte rt = 0; // Result.
            int VectorWidth = Vector<SByte>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<SByte> vrt = Vector<SByte>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<SByte>(shiftAmount);
            fixed (SByte* p0 = &src[0]) {
                SByte* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<SByte> vtemp = vectorTraits.ShiftRightArithmetic(*(Vector<SByte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (SByte)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRAFastTraitsOverload - VectorTraits128AdvSimdB64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe SByte StaticSumSRAFastTraitsOverload(VectorTraits128AdvSimdB64 vectorTraits, SByte[] src, int srcCount, int shiftAmount) {
            SByte rt = 0; // Result.
            int VectorWidth = Vector<SByte>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<SByte> vrt = Vector<SByte>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<SByte>(shiftAmount);
            fixed (SByte* p0 = &src[0]) {
                SByte* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<SByte> vtemp = vectorTraits.ShiftRightArithmetic_Fast(*(Vector<SByte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (SByte)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRATraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe SByte StaticSumSRATraitsOverload(VectorTraits256Base vectorTraits, SByte[] src, int srcCount, int shiftAmount) {
            SByte rt = 0; // Result.
            int VectorWidth = Vector<SByte>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<SByte> vrt = Vector<SByte>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<SByte>(shiftAmount);
            fixed (SByte* p0 = &src[0]) {
                SByte* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<SByte> vtemp = vectorTraits.ShiftRightArithmetic(*(Vector<SByte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (SByte)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRAFastTraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe SByte StaticSumSRAFastTraitsOverload(VectorTraits256Base vectorTraits, SByte[] src, int srcCount, int shiftAmount) {
            SByte rt = 0; // Result.
            int VectorWidth = Vector<SByte>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<SByte> vrt = Vector<SByte>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<SByte>(shiftAmount);
            fixed (SByte* p0 = &src[0]) {
                SByte* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<SByte> vtemp = vectorTraits.ShiftRightArithmetic_Fast(*(Vector<SByte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (SByte)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRATraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe SByte StaticSumSRATraitsOverload(VectorTraits256Avx2 vectorTraits, SByte[] src, int srcCount, int shiftAmount) {
            SByte rt = 0; // Result.
            int VectorWidth = Vector<SByte>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<SByte> vrt = Vector<SByte>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<SByte>(shiftAmount);
            fixed (SByte* p0 = &src[0]) {
                SByte* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<SByte> vtemp = vectorTraits.ShiftRightArithmetic(*(Vector<SByte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (SByte)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRAFastTraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe SByte StaticSumSRAFastTraitsOverload(VectorTraits256Avx2 vectorTraits, SByte[] src, int srcCount, int shiftAmount) {
            SByte rt = 0; // Result.
            int VectorWidth = Vector<SByte>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<SByte> vrt = Vector<SByte>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<SByte>(shiftAmount);
            fixed (SByte* p0 = &src[0]) {
                SByte* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<SByte> vtemp = vectorTraits.ShiftRightArithmetic_Fast(*(Vector<SByte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (SByte)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }


    } // End: partial class ShiftRightArithmeticBenchmark_SByte

    partial class ShiftRightArithmeticBenchmark_Int16 {

        // StaticSumSRATraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSumSRATraitsOverload(VectorTraitsBase vectorTraits, Int16[] src, int srcCount, int shiftAmount) {
            Int16 rt = 0; // Result.
            int VectorWidth = Vector<Int16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int16> vrt = Vector<Int16>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int16>(shiftAmount);
            fixed (Int16* p0 = &src[0]) {
                Int16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int16> vtemp = vectorTraits.ShiftRightArithmetic(*(Vector<Int16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRAFastTraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSumSRAFastTraitsOverload(VectorTraitsBase vectorTraits, Int16[] src, int srcCount, int shiftAmount) {
            Int16 rt = 0; // Result.
            int VectorWidth = Vector<Int16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int16> vrt = Vector<Int16>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int16>(shiftAmount);
            fixed (Int16* p0 = &src[0]) {
                Int16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int16> vtemp = vectorTraits.ShiftRightArithmetic_Fast(*(Vector<Int16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRATraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSumSRATraitsOverload(VectorTraits128Base vectorTraits, Int16[] src, int srcCount, int shiftAmount) {
            Int16 rt = 0; // Result.
            int VectorWidth = Vector<Int16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int16> vrt = Vector<Int16>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int16>(shiftAmount);
            fixed (Int16* p0 = &src[0]) {
                Int16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int16> vtemp = vectorTraits.ShiftRightArithmetic(*(Vector<Int16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRAFastTraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSumSRAFastTraitsOverload(VectorTraits128Base vectorTraits, Int16[] src, int srcCount, int shiftAmount) {
            Int16 rt = 0; // Result.
            int VectorWidth = Vector<Int16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int16> vrt = Vector<Int16>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int16>(shiftAmount);
            fixed (Int16* p0 = &src[0]) {
                Int16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int16> vtemp = vectorTraits.ShiftRightArithmetic_Fast(*(Vector<Int16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRATraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSumSRATraitsOverload(VectorTraits128AdvSimd vectorTraits, Int16[] src, int srcCount, int shiftAmount) {
            Int16 rt = 0; // Result.
            int VectorWidth = Vector<Int16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int16> vrt = Vector<Int16>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int16>(shiftAmount);
            fixed (Int16* p0 = &src[0]) {
                Int16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int16> vtemp = vectorTraits.ShiftRightArithmetic(*(Vector<Int16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRAFastTraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSumSRAFastTraitsOverload(VectorTraits128AdvSimd vectorTraits, Int16[] src, int srcCount, int shiftAmount) {
            Int16 rt = 0; // Result.
            int VectorWidth = Vector<Int16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int16> vrt = Vector<Int16>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int16>(shiftAmount);
            fixed (Int16* p0 = &src[0]) {
                Int16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int16> vtemp = vectorTraits.ShiftRightArithmetic_Fast(*(Vector<Int16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRATraitsOverload - VectorTraits128AdvSimdB64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSumSRATraitsOverload(VectorTraits128AdvSimdB64 vectorTraits, Int16[] src, int srcCount, int shiftAmount) {
            Int16 rt = 0; // Result.
            int VectorWidth = Vector<Int16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int16> vrt = Vector<Int16>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int16>(shiftAmount);
            fixed (Int16* p0 = &src[0]) {
                Int16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int16> vtemp = vectorTraits.ShiftRightArithmetic(*(Vector<Int16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRAFastTraitsOverload - VectorTraits128AdvSimdB64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSumSRAFastTraitsOverload(VectorTraits128AdvSimdB64 vectorTraits, Int16[] src, int srcCount, int shiftAmount) {
            Int16 rt = 0; // Result.
            int VectorWidth = Vector<Int16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int16> vrt = Vector<Int16>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int16>(shiftAmount);
            fixed (Int16* p0 = &src[0]) {
                Int16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int16> vtemp = vectorTraits.ShiftRightArithmetic_Fast(*(Vector<Int16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRATraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSumSRATraitsOverload(VectorTraits256Base vectorTraits, Int16[] src, int srcCount, int shiftAmount) {
            Int16 rt = 0; // Result.
            int VectorWidth = Vector<Int16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int16> vrt = Vector<Int16>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int16>(shiftAmount);
            fixed (Int16* p0 = &src[0]) {
                Int16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int16> vtemp = vectorTraits.ShiftRightArithmetic(*(Vector<Int16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRAFastTraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSumSRAFastTraitsOverload(VectorTraits256Base vectorTraits, Int16[] src, int srcCount, int shiftAmount) {
            Int16 rt = 0; // Result.
            int VectorWidth = Vector<Int16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int16> vrt = Vector<Int16>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int16>(shiftAmount);
            fixed (Int16* p0 = &src[0]) {
                Int16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int16> vtemp = vectorTraits.ShiftRightArithmetic_Fast(*(Vector<Int16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRATraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSumSRATraitsOverload(VectorTraits256Avx2 vectorTraits, Int16[] src, int srcCount, int shiftAmount) {
            Int16 rt = 0; // Result.
            int VectorWidth = Vector<Int16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int16> vrt = Vector<Int16>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int16>(shiftAmount);
            fixed (Int16* p0 = &src[0]) {
                Int16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int16> vtemp = vectorTraits.ShiftRightArithmetic(*(Vector<Int16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRAFastTraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSumSRAFastTraitsOverload(VectorTraits256Avx2 vectorTraits, Int16[] src, int srcCount, int shiftAmount) {
            Int16 rt = 0; // Result.
            int VectorWidth = Vector<Int16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int16> vrt = Vector<Int16>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int16>(shiftAmount);
            fixed (Int16* p0 = &src[0]) {
                Int16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int16> vtemp = vectorTraits.ShiftRightArithmetic_Fast(*(Vector<Int16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }


    } // End: partial class ShiftRightArithmeticBenchmark_Int16

    partial class ShiftRightArithmeticBenchmark_Int32 {

        // StaticSumSRATraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int32 StaticSumSRATraitsOverload(VectorTraitsBase vectorTraits, Int32[] src, int srcCount, int shiftAmount) {
            Int32 rt = 0; // Result.
            int VectorWidth = Vector<Int32>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int32> vrt = Vector<Int32>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int32>(shiftAmount);
            fixed (Int32* p0 = &src[0]) {
                Int32* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int32> vtemp = vectorTraits.ShiftRightArithmetic(*(Vector<Int32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int32)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRAFastTraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int32 StaticSumSRAFastTraitsOverload(VectorTraitsBase vectorTraits, Int32[] src, int srcCount, int shiftAmount) {
            Int32 rt = 0; // Result.
            int VectorWidth = Vector<Int32>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int32> vrt = Vector<Int32>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int32>(shiftAmount);
            fixed (Int32* p0 = &src[0]) {
                Int32* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int32> vtemp = vectorTraits.ShiftRightArithmetic_Fast(*(Vector<Int32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int32)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRATraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int32 StaticSumSRATraitsOverload(VectorTraits128Base vectorTraits, Int32[] src, int srcCount, int shiftAmount) {
            Int32 rt = 0; // Result.
            int VectorWidth = Vector<Int32>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int32> vrt = Vector<Int32>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int32>(shiftAmount);
            fixed (Int32* p0 = &src[0]) {
                Int32* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int32> vtemp = vectorTraits.ShiftRightArithmetic(*(Vector<Int32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int32)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRAFastTraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int32 StaticSumSRAFastTraitsOverload(VectorTraits128Base vectorTraits, Int32[] src, int srcCount, int shiftAmount) {
            Int32 rt = 0; // Result.
            int VectorWidth = Vector<Int32>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int32> vrt = Vector<Int32>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int32>(shiftAmount);
            fixed (Int32* p0 = &src[0]) {
                Int32* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int32> vtemp = vectorTraits.ShiftRightArithmetic_Fast(*(Vector<Int32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int32)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRATraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int32 StaticSumSRATraitsOverload(VectorTraits128AdvSimd vectorTraits, Int32[] src, int srcCount, int shiftAmount) {
            Int32 rt = 0; // Result.
            int VectorWidth = Vector<Int32>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int32> vrt = Vector<Int32>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int32>(shiftAmount);
            fixed (Int32* p0 = &src[0]) {
                Int32* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int32> vtemp = vectorTraits.ShiftRightArithmetic(*(Vector<Int32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int32)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRAFastTraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int32 StaticSumSRAFastTraitsOverload(VectorTraits128AdvSimd vectorTraits, Int32[] src, int srcCount, int shiftAmount) {
            Int32 rt = 0; // Result.
            int VectorWidth = Vector<Int32>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int32> vrt = Vector<Int32>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int32>(shiftAmount);
            fixed (Int32* p0 = &src[0]) {
                Int32* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int32> vtemp = vectorTraits.ShiftRightArithmetic_Fast(*(Vector<Int32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int32)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRATraitsOverload - VectorTraits128AdvSimdB64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int32 StaticSumSRATraitsOverload(VectorTraits128AdvSimdB64 vectorTraits, Int32[] src, int srcCount, int shiftAmount) {
            Int32 rt = 0; // Result.
            int VectorWidth = Vector<Int32>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int32> vrt = Vector<Int32>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int32>(shiftAmount);
            fixed (Int32* p0 = &src[0]) {
                Int32* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int32> vtemp = vectorTraits.ShiftRightArithmetic(*(Vector<Int32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int32)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRAFastTraitsOverload - VectorTraits128AdvSimdB64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int32 StaticSumSRAFastTraitsOverload(VectorTraits128AdvSimdB64 vectorTraits, Int32[] src, int srcCount, int shiftAmount) {
            Int32 rt = 0; // Result.
            int VectorWidth = Vector<Int32>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int32> vrt = Vector<Int32>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int32>(shiftAmount);
            fixed (Int32* p0 = &src[0]) {
                Int32* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int32> vtemp = vectorTraits.ShiftRightArithmetic_Fast(*(Vector<Int32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int32)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRATraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int32 StaticSumSRATraitsOverload(VectorTraits256Base vectorTraits, Int32[] src, int srcCount, int shiftAmount) {
            Int32 rt = 0; // Result.
            int VectorWidth = Vector<Int32>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int32> vrt = Vector<Int32>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int32>(shiftAmount);
            fixed (Int32* p0 = &src[0]) {
                Int32* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int32> vtemp = vectorTraits.ShiftRightArithmetic(*(Vector<Int32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int32)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRAFastTraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int32 StaticSumSRAFastTraitsOverload(VectorTraits256Base vectorTraits, Int32[] src, int srcCount, int shiftAmount) {
            Int32 rt = 0; // Result.
            int VectorWidth = Vector<Int32>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int32> vrt = Vector<Int32>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int32>(shiftAmount);
            fixed (Int32* p0 = &src[0]) {
                Int32* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int32> vtemp = vectorTraits.ShiftRightArithmetic_Fast(*(Vector<Int32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int32)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRATraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int32 StaticSumSRATraitsOverload(VectorTraits256Avx2 vectorTraits, Int32[] src, int srcCount, int shiftAmount) {
            Int32 rt = 0; // Result.
            int VectorWidth = Vector<Int32>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int32> vrt = Vector<Int32>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int32>(shiftAmount);
            fixed (Int32* p0 = &src[0]) {
                Int32* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int32> vtemp = vectorTraits.ShiftRightArithmetic(*(Vector<Int32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int32)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRAFastTraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int32 StaticSumSRAFastTraitsOverload(VectorTraits256Avx2 vectorTraits, Int32[] src, int srcCount, int shiftAmount) {
            Int32 rt = 0; // Result.
            int VectorWidth = Vector<Int32>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int32> vrt = Vector<Int32>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int32>(shiftAmount);
            fixed (Int32* p0 = &src[0]) {
                Int32* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int32> vtemp = vectorTraits.ShiftRightArithmetic_Fast(*(Vector<Int32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int32)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }


    } // End: partial class ShiftRightArithmeticBenchmark_Int32

    partial class ShiftRightArithmeticBenchmark_Int64 {

        // StaticSumSRATraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int64 StaticSumSRATraitsOverload(VectorTraitsBase vectorTraits, Int64[] src, int srcCount, int shiftAmount) {
            Int64 rt = 0; // Result.
            int VectorWidth = Vector<Int64>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int64> vrt = Vector<Int64>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int64>(shiftAmount);
            fixed (Int64* p0 = &src[0]) {
                Int64* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int64> vtemp = vectorTraits.ShiftRightArithmetic(*(Vector<Int64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int64)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRAFastTraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int64 StaticSumSRAFastTraitsOverload(VectorTraitsBase vectorTraits, Int64[] src, int srcCount, int shiftAmount) {
            Int64 rt = 0; // Result.
            int VectorWidth = Vector<Int64>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int64> vrt = Vector<Int64>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int64>(shiftAmount);
            fixed (Int64* p0 = &src[0]) {
                Int64* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int64> vtemp = vectorTraits.ShiftRightArithmetic_Fast(*(Vector<Int64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int64)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRATraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int64 StaticSumSRATraitsOverload(VectorTraits128Base vectorTraits, Int64[] src, int srcCount, int shiftAmount) {
            Int64 rt = 0; // Result.
            int VectorWidth = Vector<Int64>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int64> vrt = Vector<Int64>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int64>(shiftAmount);
            fixed (Int64* p0 = &src[0]) {
                Int64* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int64> vtemp = vectorTraits.ShiftRightArithmetic(*(Vector<Int64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int64)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRAFastTraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int64 StaticSumSRAFastTraitsOverload(VectorTraits128Base vectorTraits, Int64[] src, int srcCount, int shiftAmount) {
            Int64 rt = 0; // Result.
            int VectorWidth = Vector<Int64>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int64> vrt = Vector<Int64>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int64>(shiftAmount);
            fixed (Int64* p0 = &src[0]) {
                Int64* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int64> vtemp = vectorTraits.ShiftRightArithmetic_Fast(*(Vector<Int64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int64)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRATraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int64 StaticSumSRATraitsOverload(VectorTraits128AdvSimd vectorTraits, Int64[] src, int srcCount, int shiftAmount) {
            Int64 rt = 0; // Result.
            int VectorWidth = Vector<Int64>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int64> vrt = Vector<Int64>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int64>(shiftAmount);
            fixed (Int64* p0 = &src[0]) {
                Int64* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int64> vtemp = vectorTraits.ShiftRightArithmetic(*(Vector<Int64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int64)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRAFastTraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int64 StaticSumSRAFastTraitsOverload(VectorTraits128AdvSimd vectorTraits, Int64[] src, int srcCount, int shiftAmount) {
            Int64 rt = 0; // Result.
            int VectorWidth = Vector<Int64>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int64> vrt = Vector<Int64>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int64>(shiftAmount);
            fixed (Int64* p0 = &src[0]) {
                Int64* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int64> vtemp = vectorTraits.ShiftRightArithmetic_Fast(*(Vector<Int64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int64)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRATraitsOverload - VectorTraits128AdvSimdB64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int64 StaticSumSRATraitsOverload(VectorTraits128AdvSimdB64 vectorTraits, Int64[] src, int srcCount, int shiftAmount) {
            Int64 rt = 0; // Result.
            int VectorWidth = Vector<Int64>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int64> vrt = Vector<Int64>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int64>(shiftAmount);
            fixed (Int64* p0 = &src[0]) {
                Int64* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int64> vtemp = vectorTraits.ShiftRightArithmetic(*(Vector<Int64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int64)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRAFastTraitsOverload - VectorTraits128AdvSimdB64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int64 StaticSumSRAFastTraitsOverload(VectorTraits128AdvSimdB64 vectorTraits, Int64[] src, int srcCount, int shiftAmount) {
            Int64 rt = 0; // Result.
            int VectorWidth = Vector<Int64>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int64> vrt = Vector<Int64>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int64>(shiftAmount);
            fixed (Int64* p0 = &src[0]) {
                Int64* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int64> vtemp = vectorTraits.ShiftRightArithmetic_Fast(*(Vector<Int64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int64)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRATraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int64 StaticSumSRATraitsOverload(VectorTraits256Base vectorTraits, Int64[] src, int srcCount, int shiftAmount) {
            Int64 rt = 0; // Result.
            int VectorWidth = Vector<Int64>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int64> vrt = Vector<Int64>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int64>(shiftAmount);
            fixed (Int64* p0 = &src[0]) {
                Int64* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int64> vtemp = vectorTraits.ShiftRightArithmetic(*(Vector<Int64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int64)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRAFastTraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int64 StaticSumSRAFastTraitsOverload(VectorTraits256Base vectorTraits, Int64[] src, int srcCount, int shiftAmount) {
            Int64 rt = 0; // Result.
            int VectorWidth = Vector<Int64>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int64> vrt = Vector<Int64>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int64>(shiftAmount);
            fixed (Int64* p0 = &src[0]) {
                Int64* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int64> vtemp = vectorTraits.ShiftRightArithmetic_Fast(*(Vector<Int64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int64)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRATraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int64 StaticSumSRATraitsOverload(VectorTraits256Avx2 vectorTraits, Int64[] src, int srcCount, int shiftAmount) {
            Int64 rt = 0; // Result.
            int VectorWidth = Vector<Int64>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int64> vrt = Vector<Int64>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int64>(shiftAmount);
            fixed (Int64* p0 = &src[0]) {
                Int64* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int64> vtemp = vectorTraits.ShiftRightArithmetic(*(Vector<Int64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int64)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSRAFastTraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int64 StaticSumSRAFastTraitsOverload(VectorTraits256Avx2 vectorTraits, Int64[] src, int srcCount, int shiftAmount) {
            Int64 rt = 0; // Result.
            int VectorWidth = Vector<Int64>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int64> vrt = Vector<Int64>.Zero; // Vector result.
            int i;
            // Body.
            shiftAmount = Scalars.LimitShiftAmount<Int64>(shiftAmount);
            fixed (Int64* p0 = &src[0]) {
                Int64* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int64> vtemp = vectorTraits.ShiftRightArithmetic_Fast(*(Vector<Int64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int64)(p[i] >> shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }


    } // End: partial class ShiftRightArithmeticBenchmark_Int64


}

