using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Toolchains.InProcess.Emit;
using System;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Zyl.VectorTraits.Benchmarks.AVector.S;

namespace Zyl.VectorTraits.Benchmarks {
    class Program {
        [MethodImpl(MethodImplOptions.NoInlining)]
        static void AloneTest(TextWriter writer) {
            // set DOTNET_JitDisasm=AloneTest
            // export DOTNET_JitDisasm=AloneTest
            // dotnet VectorTraits.Benchmarks.dll 3 >1.txt

            // -- body --
            Vector<long> src = ~Vector<long>.Zero;
            int shiftAmount = 1;
            try {
                var dst = Vectors.ShiftLeft(src, shiftAmount);
                writer.WriteLine($"ShiftLeftLogical:\tOK. {dst}");
            } catch (Exception ex) {
                writer.WriteLine($"ShiftLeftLogical:\tFail!. {ex}");
            }
            try {
                var dst = Vectors.ShiftRightArithmetic(src, shiftAmount);
                writer.WriteLine($"ShiftRightArithmetic:\tOK. {dst}");
            } catch (Exception ex) {
                writer.WriteLine($"ShiftRightArithmetic:\tFail!. {ex}");
            }
            try {
                var dst = Vectors.ShiftRightLogical(src, shiftAmount);
                writer.WriteLine($"ShiftRightLogical:\tOK. {dst}");
            } catch (Exception ex) {
                writer.WriteLine($"ShiftRightLogical:\tFail!. {ex}");
            }
            var o = new IntroDisassemblyDry();
            int n = o.RunVector128();
            writer.WriteLine("RunVector128:\t{0}", n);
        }

        static void Main(string[] args) {
            TextWriter writer = Console.Out;
            writer.WriteLine("VectorTraits.Benchmarks");
            // benchmarkMode
            // 0: Benchmark all with my BenchmarkMain.
            // 1: Benchmark all with BenchmarkDotNet.
            // 2: Benchmark item with BenchmarkDotNet.
            // 3: Running special method (AloneTest).
            int benchmarkMode = 0;
            if (args.Length >= 1) {
                if (!int.TryParse(args[0], out benchmarkMode)) {
                    benchmarkMode = 0;
                }
            }
            writer.WriteLine("benchmarkMode:\t{0}", benchmarkMode);
            if (benchmarkMode == 3) {
                AloneTest(writer);
            } else if (benchmarkMode > 0) {
                Architecture architecture = RuntimeInformation.OSArchitecture;
                var config = DefaultConfig.Instance;
                if (architecture == Architecture.X86 || architecture == Architecture.X64) {
                    config = config.AddDiagnoser(new DisassemblyDiagnoser(new DisassemblyDiagnoserConfig(maxDepth: 3, printSource: true, printInstructionAddresses: true, exportGithubMarkdown: true, exportHtml: true)));
                } else {
                    // Message: Arm64 is not supported (Iced library limitation)
                }
                config = config.AddJob(Job.MediumRun
                    .WithLaunchCount(1)
                    .WithToolchain(InProcessEmitToolchain.Instance)
                    .WithId("InProcess"));
                if (benchmarkMode >= 2) {
                    var summary = BenchmarkRunner.Run<ShiftLeftBenchmark_Int16>(config);
                    writer.WriteLine(summary);
                } else {
                    var summary = BenchmarkRunner.Run(typeof(ShiftLeftBenchmark_Int16).Assembly, config);
                    writer.WriteLine("Length={0}, {1}", summary.Length, summary);
                }
            } else {
                string indent = "";
                writer.WriteLine();
                BenchmarkUtil.OutputEnvironment(writer, indent);
                TraitsOutput.ParseWaitDebugAndReadKey(args);
                writer.WriteLine();
                BenchmarkMain.RunBenchmark(writer, indent);
                writer.WriteLine();
                AloneTest(writer);
            }
            //Console.ReadLine();
        }
    }
}
