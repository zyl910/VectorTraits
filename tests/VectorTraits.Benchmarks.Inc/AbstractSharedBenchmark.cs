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
    internal abstract class AbstractSharedBenchmark : AbstractBenchmark {
#pragma warning disable CA2211 // Non-constant fields should not be visible
        protected static byte[] srcArrayByte = { };
        protected static short[] srcArrayInt16 = { };
        protected static int[] srcArrayInt32 = { }, dstArrayInt32 = { }, baselinetArrayInt32 = { };
        protected static long[] srcArrayInt64 = { };
        protected static byte dstByte, baselineByte;
        protected static short dstInt16, baselineInt16;
        protected static int dstInt32, baselineInt32;
        protected static long dstInt64, baselineInt64;
#pragma warning restore CA2211 // Non-constant fields should not be visible

        /// <summary>
        /// Array setup - static.
        /// </summary>
        /// <param name="N">The N.</param>
        protected static void ArraySetupStatic(int N) {
            unchecked {
                if (null!= srcArrayInt32) {
                    if (N == srcArrayInt32.Length) return;
                }
                Random random = new Random(0);
                srcArrayByte = new byte[N];
                srcArrayInt16 = new short[N];
                srcArrayInt32 = new int[N];
                srcArrayInt64 = new long[N];
                dstArrayInt32 = new int[N];
                baselinetArrayInt32 = new int[N];
                random.NextBytes(srcArrayByte);
                for (int i = 0; i < N; i++) {
                    int a = random.Next(int.MinValue, int.MaxValue);
                    int b = random.Next(int.MinValue, int.MaxValue);
                    long n64 = (((long)a) << 32) | (long)b;
                    srcArrayInt16[i] = (short)a;
                    srcArrayInt32[i] = a;
                    srcArrayInt64[i] = n64;
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
        protected void CheckBeforeArrayInt32() {
            if (!CheckMode) {
                //return; // [Debug]
            }
            TraitsUtil.Fill(dstArrayInt32, 0);
        }

        /// <summary>
        /// Check result - Int32 array.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected void CheckResultArrayInt32(string name) {
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
        /// Check result - Byte.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected void CheckResultByte(string name) {
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
        protected void CheckResultInt16(string name) {
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
        /// Check result - Int32.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected void CheckResultInt32(string name) {
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
        /// Check result - Int64.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected void CheckResultInt64(string name) {
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
        /// Check result.
        /// </summary>
        /// <param name="name">Method name.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected abstract void CheckResult(string name);


        // -- Params --
        /// <summary>The shiftCount min value.</summary>
        public virtual int ShiftCountMin {
            get {
                return -1;
            }
        }
        /// <summary>The shiftCount max value.</summary>
        public virtual int ShiftCountMax {
            get {
                return 1;
            }
        }

    }
}
