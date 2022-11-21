using System;
using System.IO;

namespace VectorTraits.Benchmarks {
    class Program {
        static void Main(string[] args) {
            TextWriter writer = Console.Out;
            writer.WriteLine("VectorTraits.Benchmarks");
            writer.WriteLine();
            TraitsOutput.OutputEnvironment(writer);
        }
    }
}
