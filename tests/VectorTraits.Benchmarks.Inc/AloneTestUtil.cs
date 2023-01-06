using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks {
    /// <summary>
    /// Alone test util .
    /// </summary>
    internal static class AloneTestUtil {
        // set DOTNET_JitDisasm=AloneTest
        // export DOTNET_JitDisasm=AloneTest
        // dotnet VectorTraits.Benchmarks.dll 3 >1.txt

        /// <summary>
        /// Alone test.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void AloneTest(TextWriter writer) {
            // -- Ceiling --
            if (true) {
                try {
                    var demo = Vectors<float>.Demo;
                    VectorTextUtil.WriteLine(writer, "demo:\t{0}", demo);
                    VectorTextUtil.WriteLine(writer, "Vectors.Ceiling(demo):\t{0}", Vectors.Ceiling(demo));
                    VectorTextUtil.WriteLine(writer, "Vectors.BaseInstance.Ceiling(demo):\t{0}", Vectors.BaseInstance.Ceiling(demo));
                    VectorTextUtil.WriteLine(writer, "Vectors.Ceiling_AcceleratedTypes:\t{0}", Vectors.Ceiling_AcceleratedTypes);
                    VectorTextUtil.WriteLine(writer, "Vectors.BaseInstance.Ceiling_AcceleratedTypes:\t{0}", Vectors.BaseInstance.Ceiling_AcceleratedTypes);
                } catch (Exception ex) {
                    writer.WriteLine($"Ceiling:\tFail!. {ex}");
                }
                writer.WriteLine();
            }

            // -- Shift --
            //if (false) {
            //    Vector<long> src = ~Vector<long>.Zero;
            //    int shiftAmount = 1;
            //    try {
            //        var dst = Vectors.ShiftLeft(src, shiftAmount);
            //        writer.WriteLine($"ShiftLeftLogical:\tOK. {dst}");
            //    } catch (Exception ex) {
            //        writer.WriteLine($"ShiftLeftLogical:\tFail!. {ex}");
            //    }
            //    try {
            //        var dst = Vectors.ShiftRightArithmetic(src, shiftAmount);
            //        writer.WriteLine($"ShiftRightArithmetic:\tOK. {dst}");
            //    } catch (Exception ex) {
            //        writer.WriteLine($"ShiftRightArithmetic:\tFail!. {ex}");
            //    }
            //    try {
            //        var dst = Vectors.ShiftRightLogical(src, shiftAmount);
            //        writer.WriteLine($"ShiftRightLogical:\tOK. {dst}");
            //    } catch (Exception ex) {
            //        writer.WriteLine($"ShiftRightLogical:\tFail!. {ex}");
            //    }
            //}

            // -- IntroDisassemblyDry --
            var o = new IntroDisassemblyDry();
            int n = o.RunVector128();
            writer.WriteLine("RunVector128:\t{0}", n);
        }
    }
}
