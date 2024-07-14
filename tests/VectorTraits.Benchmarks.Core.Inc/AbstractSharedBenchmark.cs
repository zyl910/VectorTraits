using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Zyl.VectorTraits.ExTypes;

namespace Zyl.VectorTraits.Benchmarks {
    /// <summary>
    /// Abstract shared array benchmark.
    /// </summary>
    public abstract class AbstractSharedBenchmark : AbstractBenchmark, ILoopCountGetter {
#pragma warning disable CA2211 // Non-constant fields should not be visible
        protected static float[] srcArraySingle = { };
        protected static float[] srcArraySingle_RangeInt32 = { };
        protected static float[] srcArraySingle_RangeUInt32 = { };
        protected static double[] srcArrayDouble = { };
        protected static double[] srcArrayDouble_RangeInt64 = { };
        protected static double[] srcArrayDouble_RangeUInt64 = { };
        protected static sbyte[] srcArraySByte = { };
        protected static byte[] srcArrayByte = { };
        protected static short[] srcArrayInt16 = { };
        protected static ushort[] srcArrayUInt16 = { };
        protected static int[] srcArrayInt32 = { }, dstArrayInt32 = { }, baselinetArrayInt32 = { };
        protected static uint[] srcArrayUInt32 = { };
        protected static long[] srcArrayInt64 = { };
        protected static ulong[] srcArrayUInt64 = { };
        protected static ExInt128[] srcArrayInt128 = { };
        protected static ExUInt128[] srcArrayUInt128 = { };
        protected static float dstSingle, baselineSingle;
        protected static double dstDouble, baselineDouble;
        protected static sbyte dstSByte, baselineSByte;
        protected static byte dstByte, baselineByte;
        protected static short dstInt16, baselineInt16;
        protected static ushort dstUInt16, baselineUInt16;
        protected static int dstInt32, baselineInt32;
        protected static uint dstUInt32, baselineUInt32;
        protected static long dstInt64, baselineInt64;
        protected static ulong dstUInt64, baselineUInt64;
        protected static ExInt128 dstInt128, baselineInt128;
        protected static ExUInt128 dstUInt128, baselineUInt128;
#pragma warning restore CA2211 // Non-constant fields should not be visible

        /// <inheritdoc cref="ILoopCountGetter.LoopCount" />
        public int LoopCount { get; set; }

        /// <summary>
        /// Array setup - static.
        /// </summary>
        /// <param name="N">The N.</param>
        protected static void ArraySetupStatic(int N) {
            unchecked {
                if (null!= srcArrayInt32) {
                    if (N == srcArrayInt32.Length) return;
                }
                //const long lowbit_mask = 0x0_000FFFFFL;
                double pow2_32 = Math.Pow(2, 32);
                double pow2_64 = Math.Pow(2, 64);
                double pow2_32_low = Math.Pow(2, 23 - 4);
                double pow2_64_low = Math.Pow(2, 52 - 4);
                Random random = new Random(0);
                srcArraySingle = new float[N];
                srcArraySingle_RangeInt32 = new float[N];
                srcArraySingle_RangeUInt32 = new float[N];
                srcArrayDouble = new double[N];
                srcArrayDouble_RangeInt64 = new double[N];
                srcArrayDouble_RangeUInt64 = new double[N];
                srcArraySByte = new sbyte[N];
                srcArrayByte = new byte[N];
                srcArrayInt16 = new short[N];
                srcArrayUInt16 = new ushort[N];
                srcArrayInt32 = new int[N];
                srcArrayUInt32 = new uint[N];
                srcArrayInt64 = new long[N];
                srcArrayUInt64 = new ulong[N];
                srcArrayInt128 = new ExInt128[N];
                srcArrayUInt128 = new ExUInt128[N];
                dstArrayInt32 = new int[N];
                baselinetArrayInt32 = new int[N];
                random.NextBytes(srcArrayByte);
                for (int i = 0; i < N; i++) {
                    //bool lowRangeFlag = true;
                    bool lowRangeFlag = (i & 1) != 0;
                    int a = random.Next(int.MinValue, int.MaxValue);
                    int b = random.Next(int.MinValue, int.MaxValue);
                    long n64 = (((long)a) << 32) | (long)b;
                    long n64hi = i >> 8;
                    ExInt128 n128 = new ExInt128((ulong)n64hi, (ulong)n64);
                    double f = random.NextDouble();
                    //f = BitConverter.Int64BitsToDouble((BitConverter.DoubleToInt64Bits(f)&~lowbit_mask) | (a&lowbit_mask));
                    double fN = f - 0.5;
                    double fUInt32 = f * (lowRangeFlag ? pow2_32_low : pow2_32);
                    double fInt32 = fN * (lowRangeFlag ? pow2_32_low : pow2_32);
                    double fUInt64 = f * (lowRangeFlag ? pow2_64_low : pow2_64);
                    double fInt64 = fN * (lowRangeFlag ? pow2_64_low : pow2_64);
                    srcArraySingle[i] = (float)f;
                    srcArraySingle_RangeInt32[i] = (float)fInt32;
                    srcArraySingle_RangeUInt32[i] = (float)fUInt32;
                    srcArrayDouble[i] = f;
                    srcArrayDouble_RangeInt64[i] = fInt64;
                    srcArrayDouble_RangeUInt64[i] =fUInt64;
                    srcArraySByte[i] = (sbyte)srcArrayByte[i];
                    srcArrayInt16[i] = (short)a;
                    srcArrayUInt16[i] = (ushort)a;
                    srcArrayInt32[i] = a;
                    srcArrayUInt32[i] = (uint)a;
                    srcArrayInt64[i] = n64;
                    srcArrayUInt64[i] = (ulong)n64;
                    srcArrayInt64[i] = n64;
                    srcArrayUInt64[i] = (ulong)n64;
                    srcArrayInt128[i] = n128;
                    srcArrayUInt128[i] = (ExUInt128)n128;
                }
            }
        }

        /// <summary>
        /// Array setup
        /// </summary>
        protected virtual void ArraySetup() {
            ArraySetupStatic(N);
        }

        /// <inheritdoc/>
        [GlobalSetup]
        public override void GlobalSetup() {
            ArraySetup();
            // Check.
            BenchmarkUtil.CheckAllBenchmark(this);
        }

        /// <summary>
        /// Check before - Int32 array.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckBeforeArrayInt32() {
            if (!CheckMode) {
                //return; // [Debug]
            }
            VectorTextUtil.Fill(dstArrayInt32, 0);
        }

        /// <summary>
        /// Check result - Int32 array.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResultArrayInt32(string name) {
            if (!CheckMode) return;
            int indexFound = -1;
            for (int j = 0; j < baselinetArrayInt32.Length; ++j) {
                if (dstArrayInt32[j] != baselinetArrayInt32[j]) {
                    indexFound = j;
                    break;
                }
            }
            if (indexFound >= 0) {
                throw new ApplicationException(string.Format("Check `{0}` fail! index={1}", name, indexFound));
            } else {
                // Succeed. No output.
                string msg = string.Format("Check `{0}` Succeed.", name);
                //writer.WriteLine(indent + msg);
                Debug.WriteLine(msg);
            }
        }

        /// <summary>
        /// Check result - report.
        /// </summary>
        /// <typeparam name="T">Type of dst.</typeparam>
        /// <param name="name">The name.</param>
        /// <param name="isok">The isok.</param>
        /// <param name="dstT">The dstT.</param>
        /// <param name="baselineT">The baselineT.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResult_Report<T>(string name, bool isok, T dstT, T baselineT) {
            if (!CheckMode) return;
            if (isok) {
                string msg = string.Format("Check `{0}` mismatch. {1}!={2}", name, dstT, baselineT);
                // throw new ApplicationException(msg);
                string itemname = string.Format("Check-{0}", name);
                BenchmarkUtil.WriteItem(itemname, msg);
            } else {
                // Succeed. No output.
                string msg = string.Format("Check `{0}` Succeed.", name);
                //writer.WriteLine(indent + msg);
                Debug.WriteLine(msg);
            }
        }

        /// <summary>
        /// Check result - Single.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResultSingle(string name) {
            CheckResult_Report(name, dstSingle != baselineSingle, dstSingle, baselineSingle);
        }

        /// <summary>
        /// Check result - Double.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResultDouble(string name) {
            CheckResult_Report(name, dstDouble != baselineDouble, dstDouble, baselineDouble);
        }

        /// <summary>
        /// Check result - SByte.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResultSByte(string name) {
            CheckResult_Report(name, dstSByte != baselineSByte, dstSByte, baselineSByte);
        }

        /// <summary>
        /// Check result - Byte.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResultByte(string name) {
            CheckResult_Report(name, dstByte != baselineByte, dstByte, baselineByte);
        }

        /// <summary>
        /// Check result - Int16.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResultInt16(string name) {
            if (!CheckMode) return;
            CheckResult_Report(name, dstInt16 != baselineInt16, dstInt16, baselineInt16);
        }

        /// <summary>
        /// Check result - UInt16.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResultUInt16(string name) {
            CheckResult_Report(name, dstUInt16 != baselineUInt16, dstUInt16, baselineUInt16);
        }

        /// <summary>
        /// Check result - Int32.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResultInt32(string name) {
            CheckResult_Report(name, dstInt32 != baselineInt32, dstInt32, baselineInt32);
        }

        /// <summary>
        /// Check result - UInt32.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResultUInt32(string name) {
            CheckResult_Report(name, dstUInt32 != baselineUInt32, dstUInt32, baselineUInt32);
        }

        /// <summary>
        /// Check result - Int64.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResultInt64(string name) {
            CheckResult_Report(name, dstInt64 != baselineInt64, dstInt64, baselineInt64);
        }

        /// <summary>
        /// Check result - UInt64.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResultUInt64(string name) {
            CheckResult_Report(name, dstUInt64 != baselineUInt64, dstUInt64, baselineUInt64);
        }

        /// <summary>
        /// Check result - Int128.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResultInt128(string name) {
            CheckResult_Report(name, dstInt128 != baselineInt128, dstInt128, baselineInt128);
        }

        /// <summary>
        /// Check result - UInt128.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResultUInt128(string name) {
            CheckResult_Report(name, dstUInt128 != baselineUInt128, dstUInt128, baselineUInt128);
        }

        /// <summary>
        /// Check result.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected abstract void CheckResult(string name);


        // -- Params --
        /// <summary>The shiftAmount min value.</summary>
        public virtual int ShiftAmountMin {
            get {
                return -1;
            }
        }
        /// <summary>The shiftAmount max value.</summary>
        public virtual int ShiftAmountMax {
            get {
                return 1;
            }
        }
    }
}
