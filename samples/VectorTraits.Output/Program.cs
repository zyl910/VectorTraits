using System;
using System.IO;

namespace Zyl.VectorTraits.Output {
    class Program {
        static void Main(string[] args) {
            //OutputVectorTraits.ShowFull = true;
            if (args.Length >= 1) {
                if (bool.TryParse(args[0], out var bShowFull)) {
                    OutputVectorTraits.ShowFull = bShowFull;
                } else if (int.TryParse(args[0], out var iShowFull)) {
                    OutputVectorTraits.ShowFull = iShowFull>0;
                }
            }
            // run.
            TextWriter writer = Console.Out;
            string indent = "";
            writer.WriteLine("VectorTraits.Output");
            writer.WriteLine();
            TraitsOutput.OutputEnvironment(writer, indent);
            writer.WriteLine(indent + string.Format("sizeof(bool):\t{0}", sizeof(bool))); // =1. https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/sizeof
            writer.WriteLine();
            OutputVectorTraits.RunBaseInfo(writer, indent);
        }
    }
}
