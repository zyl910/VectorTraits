using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Running;
using System;
using System.IO;
using System.Runtime.InteropServices;
using Zyl.VectorTraits.Benchmarks.AVector.S;

namespace Zyl.VectorTraits.Benchmarks {
    class Program {
        static void Main(string[] args) {
            TextWriter writer = Console.Out;
            writer.WriteLine("VectorTraits.Benchmarks");
            // benchmarkMode
            int benchmarkMode = 0;
            if (args.Length >= 1) {
                if (!int.TryParse(args[0], out benchmarkMode)) {
                    benchmarkMode = 0;
                }
            }
            writer.WriteLine("benchmarkMode:\t{0}", benchmarkMode);
            if (benchmarkMode == 3) {
                var o = new IntroDisassemblyDry();
                int n = o.RunVector128();
                writer.WriteLine("RunVector128:\t{0}", n);
            } else if (benchmarkMode > 0) {
                Architecture architecture = RuntimeInformation.OSArchitecture;
                var config = DefaultConfig.Instance;
                if (architecture == Architecture.X86 || architecture == Architecture.X64) {
                    config = config.AddDiagnoser(new DisassemblyDiagnoser(new DisassemblyDiagnoserConfig(maxDepth: 3, printSource: true, printInstructionAddresses: true, exportGithubMarkdown: true, exportHtml: true)));
                } else {
                    // Message: Arm64 is not supported (Iced library limitation)
                }
                if (benchmarkMode >= 2) {
                    var summary = BenchmarkRunner.Run<IntroDisassemblyDry>(config);
                    writer.WriteLine(summary);
                } else {
                    var summary = BenchmarkRunner.Run(typeof(ShiftLeftBenchmark_Int16).Assembly, config);
                    writer.WriteLine(summary);
                }
            } else {
                string indent = "";
                writer.WriteLine();
                BenchmarkUtil.OutputEnvironment(writer, indent);
                TraitsOutput.ParseWaitDebugAndReadKey(args);
                writer.WriteLine();
                BenchmarkMain.RunBenchmark(writer, indent);
            }
            //Console.ReadLine();
        }
    }
}
