
using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Benchmarks.AVector.S {

    partial class ShiftLeftBenchmark_SByte {

        // StaticSumSLLTraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe SByte StaticSumSLLTraitsOverload(VectorTraitsBase vectorTraits, SByte[] src, int srcCount, int shiftAmount) {
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
                    Vector<SByte> vtemp = vectorTraits.ShiftLeft(*(Vector<SByte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (SByte)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe SByte StaticSumSLLFastTraitsOverload(VectorTraitsBase vectorTraits, SByte[] src, int srcCount, int shiftAmount) {
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
                    Vector<SByte> vtemp = vectorTraits.ShiftLeftFast(*(Vector<SByte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (SByte)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe SByte StaticSumSLLTraitsOverload(VectorTraits128Base vectorTraits, SByte[] src, int srcCount, int shiftAmount) {
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
                    Vector<SByte> vtemp = vectorTraits.ShiftLeft(*(Vector<SByte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (SByte)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe SByte StaticSumSLLFastTraitsOverload(VectorTraits128Base vectorTraits, SByte[] src, int srcCount, int shiftAmount) {
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
                    Vector<SByte> vtemp = vectorTraits.ShiftLeftFast(*(Vector<SByte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (SByte)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe SByte StaticSumSLLTraitsOverload(VectorTraits128AdvSimd vectorTraits, SByte[] src, int srcCount, int shiftAmount) {
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
                    Vector<SByte> vtemp = vectorTraits.ShiftLeft(*(Vector<SByte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (SByte)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe SByte StaticSumSLLFastTraitsOverload(VectorTraits128AdvSimd vectorTraits, SByte[] src, int srcCount, int shiftAmount) {
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
                    Vector<SByte> vtemp = vectorTraits.ShiftLeftFast(*(Vector<SByte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (SByte)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits128AdvSimdB64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe SByte StaticSumSLLTraitsOverload(VectorTraits128AdvSimdB64 vectorTraits, SByte[] src, int srcCount, int shiftAmount) {
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
                    Vector<SByte> vtemp = vectorTraits.ShiftLeft(*(Vector<SByte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (SByte)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits128AdvSimdB64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe SByte StaticSumSLLFastTraitsOverload(VectorTraits128AdvSimdB64 vectorTraits, SByte[] src, int srcCount, int shiftAmount) {
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
                    Vector<SByte> vtemp = vectorTraits.ShiftLeftFast(*(Vector<SByte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (SByte)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe SByte StaticSumSLLTraitsOverload(VectorTraits256Base vectorTraits, SByte[] src, int srcCount, int shiftAmount) {
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
                    Vector<SByte> vtemp = vectorTraits.ShiftLeft(*(Vector<SByte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (SByte)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe SByte StaticSumSLLFastTraitsOverload(VectorTraits256Base vectorTraits, SByte[] src, int srcCount, int shiftAmount) {
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
                    Vector<SByte> vtemp = vectorTraits.ShiftLeftFast(*(Vector<SByte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (SByte)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe SByte StaticSumSLLTraitsOverload(VectorTraits256Avx2 vectorTraits, SByte[] src, int srcCount, int shiftAmount) {
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
                    Vector<SByte> vtemp = vectorTraits.ShiftLeft(*(Vector<SByte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (SByte)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe SByte StaticSumSLLFastTraitsOverload(VectorTraits256Avx2 vectorTraits, SByte[] src, int srcCount, int shiftAmount) {
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
                    Vector<SByte> vtemp = vectorTraits.ShiftLeftFast(*(Vector<SByte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (SByte)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }


    } // End: partial class ShiftLeftBenchmark_SByte

    partial class ShiftLeftBenchmark_Byte {

        // StaticSumSLLTraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Byte StaticSumSLLTraitsOverload(VectorTraitsBase vectorTraits, Byte[] src, int srcCount, int shiftAmount) {
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
                    Vector<Byte> vtemp = vectorTraits.ShiftLeft(*(Vector<Byte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Byte)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Byte StaticSumSLLFastTraitsOverload(VectorTraitsBase vectorTraits, Byte[] src, int srcCount, int shiftAmount) {
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
                    Vector<Byte> vtemp = vectorTraits.ShiftLeftFast(*(Vector<Byte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Byte)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Byte StaticSumSLLTraitsOverload(VectorTraits128Base vectorTraits, Byte[] src, int srcCount, int shiftAmount) {
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
                    Vector<Byte> vtemp = vectorTraits.ShiftLeft(*(Vector<Byte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Byte)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Byte StaticSumSLLFastTraitsOverload(VectorTraits128Base vectorTraits, Byte[] src, int srcCount, int shiftAmount) {
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
                    Vector<Byte> vtemp = vectorTraits.ShiftLeftFast(*(Vector<Byte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Byte)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Byte StaticSumSLLTraitsOverload(VectorTraits128AdvSimd vectorTraits, Byte[] src, int srcCount, int shiftAmount) {
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
                    Vector<Byte> vtemp = vectorTraits.ShiftLeft(*(Vector<Byte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Byte)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Byte StaticSumSLLFastTraitsOverload(VectorTraits128AdvSimd vectorTraits, Byte[] src, int srcCount, int shiftAmount) {
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
                    Vector<Byte> vtemp = vectorTraits.ShiftLeftFast(*(Vector<Byte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Byte)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits128AdvSimdB64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Byte StaticSumSLLTraitsOverload(VectorTraits128AdvSimdB64 vectorTraits, Byte[] src, int srcCount, int shiftAmount) {
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
                    Vector<Byte> vtemp = vectorTraits.ShiftLeft(*(Vector<Byte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Byte)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits128AdvSimdB64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Byte StaticSumSLLFastTraitsOverload(VectorTraits128AdvSimdB64 vectorTraits, Byte[] src, int srcCount, int shiftAmount) {
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
                    Vector<Byte> vtemp = vectorTraits.ShiftLeftFast(*(Vector<Byte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Byte)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Byte StaticSumSLLTraitsOverload(VectorTraits256Base vectorTraits, Byte[] src, int srcCount, int shiftAmount) {
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
                    Vector<Byte> vtemp = vectorTraits.ShiftLeft(*(Vector<Byte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Byte)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Byte StaticSumSLLFastTraitsOverload(VectorTraits256Base vectorTraits, Byte[] src, int srcCount, int shiftAmount) {
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
                    Vector<Byte> vtemp = vectorTraits.ShiftLeftFast(*(Vector<Byte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Byte)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Byte StaticSumSLLTraitsOverload(VectorTraits256Avx2 vectorTraits, Byte[] src, int srcCount, int shiftAmount) {
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
                    Vector<Byte> vtemp = vectorTraits.ShiftLeft(*(Vector<Byte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Byte)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Byte StaticSumSLLFastTraitsOverload(VectorTraits256Avx2 vectorTraits, Byte[] src, int srcCount, int shiftAmount) {
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
                    Vector<Byte> vtemp = vectorTraits.ShiftLeftFast(*(Vector<Byte>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Byte)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }


    } // End: partial class ShiftLeftBenchmark_Byte

    partial class ShiftLeftBenchmark_Int16 {

        // StaticSumSLLTraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSumSLLTraitsOverload(VectorTraitsBase vectorTraits, Int16[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int16> vtemp = vectorTraits.ShiftLeft(*(Vector<Int16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSumSLLFastTraitsOverload(VectorTraitsBase vectorTraits, Int16[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int16> vtemp = vectorTraits.ShiftLeftFast(*(Vector<Int16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSumSLLTraitsOverload(VectorTraits128Base vectorTraits, Int16[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int16> vtemp = vectorTraits.ShiftLeft(*(Vector<Int16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSumSLLFastTraitsOverload(VectorTraits128Base vectorTraits, Int16[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int16> vtemp = vectorTraits.ShiftLeftFast(*(Vector<Int16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSumSLLTraitsOverload(VectorTraits128AdvSimd vectorTraits, Int16[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int16> vtemp = vectorTraits.ShiftLeft(*(Vector<Int16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSumSLLFastTraitsOverload(VectorTraits128AdvSimd vectorTraits, Int16[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int16> vtemp = vectorTraits.ShiftLeftFast(*(Vector<Int16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits128AdvSimdB64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSumSLLTraitsOverload(VectorTraits128AdvSimdB64 vectorTraits, Int16[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int16> vtemp = vectorTraits.ShiftLeft(*(Vector<Int16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits128AdvSimdB64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSumSLLFastTraitsOverload(VectorTraits128AdvSimdB64 vectorTraits, Int16[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int16> vtemp = vectorTraits.ShiftLeftFast(*(Vector<Int16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSumSLLTraitsOverload(VectorTraits256Base vectorTraits, Int16[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int16> vtemp = vectorTraits.ShiftLeft(*(Vector<Int16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSumSLLFastTraitsOverload(VectorTraits256Base vectorTraits, Int16[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int16> vtemp = vectorTraits.ShiftLeftFast(*(Vector<Int16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSumSLLTraitsOverload(VectorTraits256Avx2 vectorTraits, Int16[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int16> vtemp = vectorTraits.ShiftLeft(*(Vector<Int16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int16 StaticSumSLLFastTraitsOverload(VectorTraits256Avx2 vectorTraits, Int16[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int16> vtemp = vectorTraits.ShiftLeftFast(*(Vector<Int16>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int16)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }


    } // End: partial class ShiftLeftBenchmark_Int16

    partial class ShiftLeftBenchmark_Int32 {

        // StaticSumSLLTraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int32 StaticSumSLLTraitsOverload(VectorTraitsBase vectorTraits, Int32[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int32> vtemp = vectorTraits.ShiftLeft(*(Vector<Int32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int32)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int32 StaticSumSLLFastTraitsOverload(VectorTraitsBase vectorTraits, Int32[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int32> vtemp = vectorTraits.ShiftLeftFast(*(Vector<Int32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int32)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int32 StaticSumSLLTraitsOverload(VectorTraits128Base vectorTraits, Int32[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int32> vtemp = vectorTraits.ShiftLeft(*(Vector<Int32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int32)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int32 StaticSumSLLFastTraitsOverload(VectorTraits128Base vectorTraits, Int32[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int32> vtemp = vectorTraits.ShiftLeftFast(*(Vector<Int32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int32)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int32 StaticSumSLLTraitsOverload(VectorTraits128AdvSimd vectorTraits, Int32[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int32> vtemp = vectorTraits.ShiftLeft(*(Vector<Int32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int32)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int32 StaticSumSLLFastTraitsOverload(VectorTraits128AdvSimd vectorTraits, Int32[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int32> vtemp = vectorTraits.ShiftLeftFast(*(Vector<Int32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int32)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits128AdvSimdB64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int32 StaticSumSLLTraitsOverload(VectorTraits128AdvSimdB64 vectorTraits, Int32[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int32> vtemp = vectorTraits.ShiftLeft(*(Vector<Int32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int32)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits128AdvSimdB64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int32 StaticSumSLLFastTraitsOverload(VectorTraits128AdvSimdB64 vectorTraits, Int32[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int32> vtemp = vectorTraits.ShiftLeftFast(*(Vector<Int32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int32)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int32 StaticSumSLLTraitsOverload(VectorTraits256Base vectorTraits, Int32[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int32> vtemp = vectorTraits.ShiftLeft(*(Vector<Int32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int32)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int32 StaticSumSLLFastTraitsOverload(VectorTraits256Base vectorTraits, Int32[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int32> vtemp = vectorTraits.ShiftLeftFast(*(Vector<Int32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int32)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int32 StaticSumSLLTraitsOverload(VectorTraits256Avx2 vectorTraits, Int32[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int32> vtemp = vectorTraits.ShiftLeft(*(Vector<Int32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int32)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int32 StaticSumSLLFastTraitsOverload(VectorTraits256Avx2 vectorTraits, Int32[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int32> vtemp = vectorTraits.ShiftLeftFast(*(Vector<Int32>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int32)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }


    } // End: partial class ShiftLeftBenchmark_Int32

    partial class ShiftLeftBenchmark_Int64 {

        // StaticSumSLLTraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int64 StaticSumSLLTraitsOverload(VectorTraitsBase vectorTraits, Int64[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int64> vtemp = vectorTraits.ShiftLeft(*(Vector<Int64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int64)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraitsBase
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int64 StaticSumSLLFastTraitsOverload(VectorTraitsBase vectorTraits, Int64[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int64> vtemp = vectorTraits.ShiftLeftFast(*(Vector<Int64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int64)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int64 StaticSumSLLTraitsOverload(VectorTraits128Base vectorTraits, Int64[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int64> vtemp = vectorTraits.ShiftLeft(*(Vector<Int64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int64)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits128Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int64 StaticSumSLLFastTraitsOverload(VectorTraits128Base vectorTraits, Int64[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int64> vtemp = vectorTraits.ShiftLeftFast(*(Vector<Int64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int64)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int64 StaticSumSLLTraitsOverload(VectorTraits128AdvSimd vectorTraits, Int64[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int64> vtemp = vectorTraits.ShiftLeft(*(Vector<Int64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int64)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits128AdvSimd
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int64 StaticSumSLLFastTraitsOverload(VectorTraits128AdvSimd vectorTraits, Int64[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int64> vtemp = vectorTraits.ShiftLeftFast(*(Vector<Int64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int64)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits128AdvSimdB64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int64 StaticSumSLLTraitsOverload(VectorTraits128AdvSimdB64 vectorTraits, Int64[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int64> vtemp = vectorTraits.ShiftLeft(*(Vector<Int64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int64)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits128AdvSimdB64
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int64 StaticSumSLLFastTraitsOverload(VectorTraits128AdvSimdB64 vectorTraits, Int64[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int64> vtemp = vectorTraits.ShiftLeftFast(*(Vector<Int64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int64)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int64 StaticSumSLLTraitsOverload(VectorTraits256Base vectorTraits, Int64[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int64> vtemp = vectorTraits.ShiftLeft(*(Vector<Int64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int64)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits256Base
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int64 StaticSumSLLFastTraitsOverload(VectorTraits256Base vectorTraits, Int64[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int64> vtemp = vectorTraits.ShiftLeftFast(*(Vector<Int64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int64)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLTraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int64 StaticSumSLLTraitsOverload(VectorTraits256Avx2 vectorTraits, Int64[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int64> vtemp = vectorTraits.ShiftLeft(*(Vector<Int64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int64)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }

        // StaticSumSLLFastTraitsOverload - VectorTraits256Avx2
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe Int64 StaticSumSLLFastTraitsOverload(VectorTraits256Avx2 vectorTraits, Int64[] src, int srcCount, int shiftAmount) {
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
                    Vector<Int64> vtemp = vectorTraits.ShiftLeftFast(*(Vector<Int64>*)p, shiftAmount);
                    vrt += vtemp; // Add.
                    p += nBlockWidth;
                }
                // Remainder processs.
                for (i = 0; i < cntRem; ++i) {
                    rt += (Int64)(p[i] << shiftAmount);
                }
            }
            // Reduce.
            for (i = 0; i < VectorWidth; ++i) {
                rt += vrt[i];
            }
            return rt;
        }


    } // End: partial class ShiftLeftBenchmark_Int64


}

