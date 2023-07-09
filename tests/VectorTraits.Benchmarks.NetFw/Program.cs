using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zyl.VectorTraits.Benchmarks.NetFw {
    class Program {
        static void Main(string[] args) {
            TextWriter writer = Console.Out;
            writer.WriteLine("VectorTraits.Benchmarks.NetFw");
            // benchmarkMode
            // 0: Benchmark all with my BenchmarkMain.
            // 3: Running special method (AloneTest).
            int benchmarkMode = 0;
            if (args.Length >= 1) {
                if (!int.TryParse(args[0], out benchmarkMode)) {
                    benchmarkMode = 0;
                }
            }
            writer.WriteLine("benchmarkMode:\t{0}", benchmarkMode);
            if (benchmarkMode == 3) {
                AloneTestUtil.AloneTestByCommand(writer, args);
                //} else if (benchmarkMode > 0) {
                //    Summary summary = BenchmarkRunner.Run<ShiftLeftBenchmark_Int16>();
                //    var summary = BenchmarkRunner.Run(typeof(ShiftLeftBenchmark_Int16).Assembly);
            } else {
                string indent = "";
                writer.WriteLine();
                BenchmarkUtil.OutputEnvironment(writer, indent);
                TraitsOutput.ParseWaitDebugAndReadKey(args);
                writer.WriteLine();
                BenchmarkMain.RunBenchmark(writer, indent);
                writer.WriteLine();
                AloneTestUtil.AloneTestByCommand(writer, args);
            }
            //Console.ReadLine();
        }
    }
}
