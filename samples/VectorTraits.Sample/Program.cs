using System;
using System.IO;
using System.Numerics;
using Zyl.VectorTraits;

namespace Zyl.VectorTraits.Sample {
    class Program {
        static void Main(string[] args) {
            TextWriter writer = Console.Out;
            writer.WriteLine("VectorTraits.Sample");
            writer.WriteLine();
            TraitsOutput.OutputEnvironment(writer);
            writer.WriteLine();

            Vector<Int16> src = Vectors.CreateRotate<Int16>(0, 1, 2, 3, 4, 5, 6, 7);
            TraitsUtil.WriteLine(writer, "src:\t{0}", src);
        }
    }
}
