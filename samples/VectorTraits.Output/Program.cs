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
            // run.
            TextWriter writer = Console.Out;
            string indent = "";
            writer.WriteLine("VectorTraits.Output");
            writer.WriteLine();
            TraitsOutput.OutputEnvironment(writer, indent);
            writer.WriteLine();
            OutputVectorTraits.RunBaseInfo(writer, indent);
        }
    }
}
