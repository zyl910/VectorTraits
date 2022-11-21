using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
//using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Benchmarks {
    public class BenchmarkMain {

        /// <summary>
        /// Run benchmark.
        /// </summary>
        /// <param name="writer">Output <see cref="TextWriter"/>.</param>
        /// <param name="indent">The indent.</param>
        public static void RunBenchmark(TextWriter writer, string indent) {
            // info.
            //writer.WriteLine(indent + string.Format("VectorTTraits.BaseIInstance.Name:\t{0}", VectorTTraits.BaseIInstance.Name));
            //writer.WriteLine(indent + string.Format("VectorTTraits:\t{0}", VectorTTraits.IInstance));
            //writer.WriteLine(indent + string.Format("VectorTTraits.Name:\t{0}", VectorTTraits.Name));
            //writer.WriteLine(indent + string.Format("VectorTTraits.ByteCount:\t{0}", VectorTTraits.ByteCount));
            //writer.WriteLine(indent + string.Format("VectorTTraits.IsSupported:\t{0}", VectorTTraits.IsSupported));
            //writer.WriteLine(indent + string.Format("AccelerateState-VectorTTraits256Base.ShiftRightArithmetic:\t{0}", AccelerateStateAttribute.GetAttributeValue(typeof(VectorTTraits256Base).GetMethod("ShiftRightArithmetic"))));
            //writer.WriteLine(indent + string.Format("AccelerateState-VectorTTraits256Avx2.ShiftRightArithmetic:\t{0}", AccelerateStateAttribute.GetAttributeValue(typeof(VectorTTraits256Avx2).GetMethod("ShiftRightArithmetic"))));
            // RunBenchmark.
            BenchmarkUtil.CurrentTextWriter = writer;
            BenchmarkUtil.RunBenchmark(writer, indent, typeof(BenchmarkMain).Assembly);
        }
    }
}
