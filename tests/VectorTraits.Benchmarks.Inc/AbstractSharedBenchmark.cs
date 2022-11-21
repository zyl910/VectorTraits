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
    public abstract class AbstractSharedBenchmark : AbstractBenchmark {
#pragma warning disable CA2211 // Non-constant fields should not be visible
        protected static Byte[] srcArrayByte = { };
        protected static Int16[] srcArrayInt16 = { };
        protected static Int32[] srcArrayInt32 = { }, dstArrayInt32 = { }, baselinetArrayInt32 = { };
        protected static Int64[] srcArrayInt64 = { };
        protected static Byte dstByte, baselineByte;
        protected static Int16 dstInt16, baselineInt16;
        protected static Int32 dstInt32, baselineInt32;
        protected static Int64 dstInt64, baselineInt64;
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
                srcArrayByte = new Byte[N];
                srcArrayInt16 = new Int16[N];
                srcArrayInt32 = new Int32[N];
                srcArrayInt64 = new Int64[N];
                dstArrayInt32 = new Int32[N];
                baselinetArrayInt32 = new Int32[N];
                random.NextBytes(srcArrayByte);
                for (int i = 0; i < N; i++) {
                    Int32 a = random.Next(Int32.MinValue, Int32.MaxValue);
                    Int32 b = random.Next(Int32.MinValue, Int32.MaxValue);
                    Int64 n64 = (((Int64)a) << 32) | (Int64)b;
                    srcArrayInt16[i] = (Int16)a;
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

    }
}
