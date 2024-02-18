using System;
using System.IO;
using UpdateBenchmarkResults.Service;

namespace UpdateBenchmarkResults {
    class Program {
        static void Main(string[] args) {
            TextWriter writer = Console.Out;
            writer.WriteLine("UpdateBenchmarkResults");
            writer.WriteLine("Syntax: UpdateBenchmarkResults (SourceFile) [-folder=(folder)] [-applyHeader=(0/1)]");
            writer.WriteLine();
            try {
                BenchmarkResultsService service = new BenchmarkResultsService();
                service.Writer = writer;
                service.RunWithCommand(args);
            } catch (Exception ex) {
                writer.WriteLine(ex.Message);
            }
        }
    }
}
