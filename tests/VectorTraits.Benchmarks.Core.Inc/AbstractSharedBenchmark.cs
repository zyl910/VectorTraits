using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

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
                const double minValueInt32 = Int32.MinValue;
                const double minValueInt64 = Int64.MinValue;
                double pow2_32 = Math.Pow(2, 32);
                double pow2_64 = Math.Pow(2, 64);
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
                dstArrayInt32 = new int[N];
                baselinetArrayInt32 = new int[N];
                random.NextBytes(srcArrayByte);
                for (int i = 0; i < N; i++) {
                    int a = random.Next(int.MinValue, int.MaxValue);
                    int b = random.Next(int.MinValue, int.MaxValue);
                    long n64 = (((long)a) << 32) | (long)b;
                    double f = random.NextDouble();
                    double fUInt32 = f * pow2_32;
                    double fInt32 = fUInt32 + minValueInt32;
                    double fUInt64 = f * pow2_64;
                    double fInt64 = fUInt64 + minValueInt64;
                    srcArraySingle[i] = (float)f;
                    srcArraySingle_RangeInt32[i] = (float)fInt32;
                    srcArraySingle_RangeUInt32[i] = (float)fUInt32;
                    srcArrayDouble[i] = f;
                    srcArrayDouble_RangeInt64[i] = (float)fInt64;
                    srcArrayDouble_RangeUInt64[i] = (float)fUInt64;
                    srcArraySByte[i] = (sbyte)srcArrayByte[i];
                    srcArrayInt16[i] = (short)a;
                    srcArrayUInt16[i] = (ushort)a;
                    srcArrayInt32[i] = a;
                    srcArrayUInt32[i] = (uint)a;
                    srcArrayInt64[i] = n64;
                    srcArrayUInt64[i] = (ulong)n64;
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
        /// Check result - Single.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResultSingle(string name) {
            if (!CheckMode) return;
            if (dstSingle != baselineSingle) {
                string msg = string.Format("Check `{0}` mismatch. {1}!={2}", name, dstSingle, baselineSingle);
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
        /// Check result - Double.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResultDouble(string name) {
            if (!CheckMode) return;
            if (dstDouble != baselineDouble) {
                string msg = string.Format("Check `{0}` mismatch. {1}!={2}", name, dstDouble, baselineDouble);
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
        /// Check result - SByte.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResultSByte(string name) {
            if (!CheckMode) return;
            if (dstSByte != baselineSByte) {
                throw new ApplicationException(string.Format("Check `{0}` fail! {1}!={2}", name, dstSByte, baselineSByte));
            } else {
                // Succeed. No output.
                string msg = string.Format("Check `{0}` Succeed.", name);
                //writer.WriteLine(indent + msg);
                Debug.WriteLine(msg);
            }
        }

        /// <summary>
        /// Check result - Byte.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResultByte(string name) {
            if (!CheckMode) return;
            if (dstByte != baselineByte) {
                throw new ApplicationException(string.Format("Check `{0}` fail! {1}!={2}", name, dstByte, baselineByte));
            } else {
                // Succeed. No output.
                string msg = string.Format("Check `{0}` Succeed.", name);
                //writer.WriteLine(indent + msg);
                Debug.WriteLine(msg);
            }
        }

        /// <summary>
        /// Check result - Int16.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResultInt16(string name) {
            if (!CheckMode) return;
            if (dstInt16 != baselineInt16) {
                throw new ApplicationException(string.Format("Check `{0}` fail! {1}!={2}", name, dstInt16, baselineInt16));
            } else {
                // Succeed. No output.
                string msg = string.Format("Check `{0}` Succeed.", name);
                //writer.WriteLine(indent + msg);
                Debug.WriteLine(msg);
            }
        }

        /// <summary>
        /// Check result - UInt16.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResultUInt16(string name) {
            if (!CheckMode) return;
            if (dstUInt16 != baselineUInt16) {
                throw new ApplicationException(string.Format("Check `{0}` fail! {1}!={2}", name, dstUInt16, baselineUInt16));
            } else {
                // Succeed. No output.
                string msg = string.Format("Check `{0}` Succeed.", name);
                //writer.WriteLine(indent + msg);
                Debug.WriteLine(msg);
            }
        }

        /// <summary>
        /// Check result - Int32.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResultInt32(string name) {
            if (!CheckMode) return;
            if (dstInt32 != baselineInt32) {
                throw new ApplicationException(string.Format("Check `{0}` fail! {1}!={2}", name, dstInt32, baselineInt32));
            } else {
                // Succeed. No output.
                string msg = string.Format("Check `{0}` Succeed.", name);
                //writer.WriteLine(indent + msg);
                Debug.WriteLine(msg);
            }
        }

        /// <summary>
        /// Check result - UInt32.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResultUInt32(string name) {
            if (!CheckMode) return;
            if (dstUInt32 != baselineUInt32) {
                throw new ApplicationException(string.Format("Check `{0}` fail! {1}!={2}", name, dstUInt32, baselineUInt32));
            } else {
                // Succeed. No output.
                string msg = string.Format("Check `{0}` Succeed.", name);
                //writer.WriteLine(indent + msg);
                Debug.WriteLine(msg);
            }
        }

        /// <summary>
        /// Check result - Int64.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResultInt64(string name) {
            if (!CheckMode) return;
            if (dstInt64 != baselineInt64) {
                throw new ApplicationException(string.Format("Check `{0}` fail! {1}!={2}", name, dstInt64, baselineInt64));
            } else {
                // Succeed. No output.
                string msg = string.Format("Check `{0}` Succeed.", name);
                //writer.WriteLine(indent + msg);
                Debug.WriteLine(msg);
            }
        }

        /// <summary>
        /// Check result - UInt64.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected virtual void CheckResultUInt64(string name) {
            if (!CheckMode) return;
            if (dstUInt64 != baselineUInt64) {
                throw new ApplicationException(string.Format("Check `{0}` fail! {1}!={2}", name, dstUInt64, baselineUInt64));
            } else {
                // Succeed. No output.
                string msg = string.Format("Check `{0}` Succeed.", name);
                //writer.WriteLine(indent + msg);
                Debug.WriteLine(msg);
            }
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
