using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zyl.VectorTraits.Benchmarks.NetFw {
    class Program {
        static void Main(string[] args) {
            bool useBenchmark = false;
            if (args.Length >= 1) {
                //bool.TryParse(args[0], out useBenchmark);
            }
            // run.
            if (useBenchmark) {
                //Summary summary = BenchmarkRunner.Run<ShiftLeftBenchmark_Int16>();
                //var summary = BenchmarkRunner.Run(typeof(ShiftLeftBenchmark_Int16).Assembly);
            } else {
                string indent = "";
                TextWriter writer = Console.Out;
                writer.WriteLine("VectorTraits.Benchmarks.NetFw");
                writer.WriteLine();
                BenchmarkUtil.OutputEnvironment(writer, indent);
                writer.WriteLine();
                BenchmarkMain.RunBenchmark(writer, indent);
            }
            //Console.ReadLine();
        }
    }
}
