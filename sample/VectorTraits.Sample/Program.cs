using System;
using System.IO;
using System.Numerics;
using Zyl.VectorTraits;

namespace VectorTraits.Sample {
    class Program {
        static void Main(string[] args) {
            TextWriter writer = Console.Out;
            writer.WriteLine("VectorTraits.Sample");
            writer.WriteLine();

            Vector<Int16> src = Vector<Int16>.One;
            //writer.WriteLine(src);
            TraitsUtil.WriteLine(writer, "src:\t{0}", src);
        }
    }
}
