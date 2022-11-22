using System;
using System.IO;

namespace Zyl.VectorTraits.Output {
    class Program {
        static void Main(string[] args) {
            TextWriter writer = Console.Out;
            writer.WriteLine("VectorTraits.Output");
            writer.WriteLine();
            TraitsOutput.OutputEnvironment(writer);
            writer.WriteLine();
        }
    }
}
