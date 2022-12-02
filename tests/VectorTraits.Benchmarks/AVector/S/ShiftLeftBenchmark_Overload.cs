
using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Benchmarks.AVector.S {

    public partial class ShiftLeftBenchmark_Int16 {

        // StaticSLLTraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSLLTraitsOverload(VectorTraitsBase vectorTraits, Int16[] src, int srcCount, int shiftCount) {
            Int16 rt = 0; // Result.
            int VectorWidth = Vector<Int16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int16> vrt = Vector<Int16>.Zero; // Vector result.
            int i;
            // Body.
            fixed (Int16* p0 = &src[0]) {
                Int16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int16> vtemp = vectorTraits.ShiftLeft(*(Vector<Int16>*)p, shiftCount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] << shiftCount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSLLTraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSLLTraitsOverload(VectorTraits128Base vectorTraits, Int16[] src, int srcCount, int shiftCount) {
            Int16 rt = 0; // Result.
            int VectorWidth = Vector<Int16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int16> vrt = Vector<Int16>.Zero; // Vector result.
            int i;
            // Body.
            fixed (Int16* p0 = &src[0]) {
                Int16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int16> vtemp = vectorTraits.ShiftLeft(*(Vector<Int16>*)p, shiftCount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] << shiftCount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSLLTraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSLLTraitsOverload(VectorTraits128AdvSimd vectorTraits, Int16[] src, int srcCount, int shiftCount) {
            Int16 rt = 0; // Result.
            int VectorWidth = Vector<Int16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int16> vrt = Vector<Int16>.Zero; // Vector result.
            int i;
            // Body.
            fixed (Int16* p0 = &src[0]) {
                Int16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int16> vtemp = vectorTraits.ShiftLeft(*(Vector<Int16>*)p, shiftCount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] << shiftCount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSLLTraitsOverload - VectorTraits128AdvSimdA64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSLLTraitsOverload(VectorTraits128AdvSimdA64 vectorTraits, Int16[] src, int srcCount, int shiftCount) {
            Int16 rt = 0; // Result.
            int VectorWidth = Vector<Int16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int16> vrt = Vector<Int16>.Zero; // Vector result.
            int i;
            // Body.
            fixed (Int16* p0 = &src[0]) {
                Int16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int16> vtemp = vectorTraits.ShiftLeft(*(Vector<Int16>*)p, shiftCount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] << shiftCount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSLLTraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSLLTraitsOverload(VectorTraits256Base vectorTraits, Int16[] src, int srcCount, int shiftCount) {
            Int16 rt = 0; // Result.
            int VectorWidth = Vector<Int16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int16> vrt = Vector<Int16>.Zero; // Vector result.
            int i;
            // Body.
            fixed (Int16* p0 = &src[0]) {
                Int16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int16> vtemp = vectorTraits.ShiftLeft(*(Vector<Int16>*)p, shiftCount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] << shiftCount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSLLTraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSLLTraitsOverload(VectorTraits256Avx2 vectorTraits, Int16[] src, int srcCount, int shiftCount) {
            Int16 rt = 0; // Result.
            int VectorWidth = Vector<Int16>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<Int16> vrt = Vector<Int16>.Zero; // Vector result.
            int i;
            // Body.
            fixed (Int16* p0 = &src[0]) {
                Int16* p = p0;
                // Vector processs.
                for (i = 0; i < cntBlock; ++i) {
                    Vector<Int16> vtemp = vectorTraits.ShiftLeft(*(Vector<Int16>*)p, shiftCount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] << shiftCount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }


    } // End: public partial class ShiftLeftBenchmark_Int16

}

