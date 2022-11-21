using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks {
    /// <summary>
    /// Abstract demo
    /// </summary>
    public abstract class AbstractBenchmark {
        /// <summary>
        /// Is check mode.
        /// </summary>
        public bool CheckMode { get; set; }

        /// <summary>
        /// Values for N.
        /// </summary>
        //public static IEnumerable<int> ValuesForN => new int[] { 64 * 1024 };
        public static IEnumerable<int> ValuesForN => new int[] { 256 * 1024 };
        //public static IEnumerable<int> ValuesForN => new int[] { 64 * 1024, 256 * 1024 };

        [ParamsSource(nameof(ValuesForN))]
        public int N;

        /// <summary>
        /// Global setup
        /// </summary>
        public virtual void GlobalSetup() {
        }

    }
}
