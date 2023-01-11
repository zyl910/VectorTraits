using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Benchmarks {
    /// <summary>
    /// Alone test util .
    /// </summary>
    internal static class AloneTestUtil {
        // set DOTNET_JitDisasm=AloneTest
        // export DOTNET_JitDisasm=AloneTest
        // dotnet VectorTraits.Benchmarks.dll 3 >1.txt

        /// <summary>Indent next separator (增加缩进的分隔符).</summary>
        internal static readonly string IndentNextSeparator = VectorTextUtil.IndentNextSeparator;

        /// <summary>
        /// Alone test.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void AloneTest(TextWriter writer) {
            AloneTestVector(writer);
            AloneTestVector128(writer);
            AloneTestVector256(writer);

            // -- IntroDisassemblyDry --
            var o = new IntroDisassemblyDry();
            int n = o.RunVector128();
            writer.WriteLine("RunVector128:\t{0}", n);
        }

        /// <summary>
        /// Alone test Vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void AloneTestVector(TextWriter writer) {
            string indentNext = IndentNextSeparator;

            // -- TraitsInstances --
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK.");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage(true)}");
                }
            }
            VectorTextUtil.WriteLine(writer, "Vectors<float>.Demo:\t{0}", Vectors<float>.Demo);
            VectorTextUtil.WriteLine(writer, "Vectors<double>.Demo:\t{0}", Vectors<double>.Demo);
            VectorTextUtil.WriteLine(writer, "Vectors<double>.DemoNaN:\t{0}", Vectors<double>.DemoNaN);
            VectorTextUtil.WriteLine(writer, "Vectors<double>.DemoNaN2:\t{0}", Vectors<double>.DemoNaN2);
            writer.WriteLine();

            // -- Ceiling --
            if (true) {
                try {
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Console.WriteLine($"{instance.GetType().Name}: {instance.Ceiling_AcceleratedTypes}");
                        VectorTextUtil.WriteLine(indentNext, writer, "Ceiling<float>(Demo):\t{0}", instance.Ceiling(Vectors<float>.Demo));
                        VectorTextUtil.WriteLine(indentNext, writer, "Ceiling<double>(Demo):\t{0}", instance.Ceiling(Vectors<double>.Demo));
                        VectorTextUtil.WriteLine(indentNext, writer, "Ceiling<double>(DemoNaN):\t{0}", instance.Ceiling(Vectors<double>.DemoNaN));
                    }
                } catch (Exception ex) {
                    writer.WriteLine($"Ceiling:\tFail!. {ex}");
                }
                writer.WriteLine();
            }

            // -- Floor --
            if (true) {
                try {
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Console.WriteLine($"{instance.GetType().Name}: {instance.Floor_AcceleratedTypes}");
                        VectorTextUtil.WriteLine(indentNext, writer, "Floor<float>(Demo):\t{0}", instance.Floor(Vectors<float>.Demo));
                        VectorTextUtil.WriteLine(indentNext, writer, "Floor<double>(Demo):\t{0}", instance.Floor(Vectors<double>.Demo));
                        VectorTextUtil.WriteLine(indentNext, writer, "Floor<double>(DemoNaN):\t{0}", instance.Floor(Vectors<double>.DemoNaN));
                    }
                } catch (Exception ex) {
                    writer.WriteLine($"Floor:\tFail!. {ex}");
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

        }

        /// <summary>
        /// Alone test Vector128.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void AloneTestVector128(TextWriter writer) {
#if NETCOREAPP3_0_OR_GREATER
            string indentNext = IndentNextSeparator;

            // -- TraitsInstances --
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK.");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage(true)}");
                }
            }
            VectorTextUtil.WriteLine(writer, "Vector128s<float>.Demo:\t{0}", Vector128s<float>.Demo);
            VectorTextUtil.WriteLine(writer, "Vector128s<double>.Demo:\t{0}", Vector128s<double>.Demo);
            VectorTextUtil.WriteLine(writer, "Vector128s<double>.DemoNaN:\t{0}", Vector128s<double>.DemoNaN);
            VectorTextUtil.WriteLine(writer, "Vector128s<double>.DemoNaN2:\t{0}", Vector128s<double>.DemoNaN2);
            writer.WriteLine();

            // -- Max --
            if (true) {
                try {
                    foreach (IWVectorTraits128 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Console.WriteLine($"{instance.GetType().Name}: {instance.Max_AcceleratedTypes}");
                        VectorTextUtil.WriteLine(indentNext, writer, "Max<float>(Demo, V1):\t{0}", instance.Max(Vector128s<float>.Demo, Vector128s<float>.V1));
                        VectorTextUtil.WriteLine(indentNext, writer, "Max<double>(Demo, V1):\t{0}", instance.Max(Vector128s<double>.Demo, Vector128s<double>.V1));
                        VectorTextUtil.WriteLine(indentNext, writer, "Max<double>(DemoNaN, V1):\t{0}", instance.Max(Vector128s<double>.DemoNaN, Vector128s<double>.V1));
                        VectorTextUtil.WriteLine(indentNext, writer, "Max<double>(DemoNaN2, V1):\t{0}", instance.Max(Vector128s<double>.DemoNaN2, Vector128s<double>.V1));
                        VectorTextUtil.WriteLine(indentNext, writer, "Max<double>(DemoNaN, DemoNaN2):\t{0}", instance.Max(Vector128s<double>.DemoNaN, Vector128s<double>.DemoNaN2));
                        VectorTextUtil.WriteLine(indentNext, writer, "Max<double>(DemoNaN, NaN):\t{0}", instance.Max(Vector128s<double>.DemoNaN, Vector128s<double>.NaN));
                        VectorTextUtil.WriteLine(indentNext, writer, "Max<double>(NaN, DemoNaN):\t{0}", instance.Max(Vector128s<double>.NaN, Vector128s<double>.DemoNaN));
                    }
                } catch (Exception ex) {
                    writer.WriteLine($"Max:\tFail!. {ex}");
                }
                writer.WriteLine();
            }

            // -- Min --
            if (true) {
                try {
                    foreach (IWVectorTraits128 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Console.WriteLine($"{instance.GetType().Name}: {instance.Min_AcceleratedTypes}");
                        VectorTextUtil.WriteLine(indentNext, writer, "Min<float>(Demo, V1):\t{0}", instance.Min(Vector128s<float>.Demo, Vector128s<float>.V1));
                        VectorTextUtil.WriteLine(indentNext, writer, "Min<double>(Demo, V1):\t{0}", instance.Min(Vector128s<double>.Demo, Vector128s<double>.V1));
                        VectorTextUtil.WriteLine(indentNext, writer, "Min<double>(DemoNaN, V1):\t{0}", instance.Min(Vector128s<double>.DemoNaN, Vector128s<double>.V1));
                        VectorTextUtil.WriteLine(indentNext, writer, "Min<double>(DemoNaN2, V1):\t{0}", instance.Min(Vector128s<double>.DemoNaN2, Vector128s<double>.V1));
                        VectorTextUtil.WriteLine(indentNext, writer, "Min<double>(DemoNaN, DemoNaN2):\t{0}", instance.Min(Vector128s<double>.DemoNaN, Vector128s<double>.DemoNaN2));
                        VectorTextUtil.WriteLine(indentNext, writer, "Min<double>(DemoNaN, NaN):\t{0}", instance.Min(Vector128s<double>.DemoNaN, Vector128s<double>.NaN));
                        VectorTextUtil.WriteLine(indentNext, writer, "Min<double>(NaN, DemoNaN):\t{0}", instance.Min(Vector128s<double>.NaN, Vector128s<double>.DemoNaN));
                    }
                } catch (Exception ex) {
                    writer.WriteLine($"Min:\tFail!. {ex}");
                }
                writer.WriteLine();
            }

#endif // NETCOREAPP3_0_OR_GREATER
        }

        /// <summary>
        /// Alone test Vector256.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void AloneTestVector256(TextWriter writer) {
#if NETCOREAPP3_0_OR_GREATER
            string indentNext = IndentNextSeparator;

            // -- TraitsInstances --
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK.");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage(true)}");
                }
            }
            VectorTextUtil.WriteLine(writer, "Vector256s<float>.Demo:\t{0}", Vector256s<float>.Demo);
            VectorTextUtil.WriteLine(writer, "Vector256s<double>.Demo:\t{0}", Vector256s<double>.Demo);
            VectorTextUtil.WriteLine(writer, "Vector256s<double>.DemoNaN:\t{0}", Vector256s<double>.DemoNaN);
            VectorTextUtil.WriteLine(writer, "Vector256s<double>.DemoNaN2:\t{0}", Vector256s<double>.DemoNaN2);
            writer.WriteLine();

            // -- Max --
            if (true) {
                try {
                    foreach (IWVectorTraits256 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Console.WriteLine($"{instance.GetType().Name}: {instance.Max_AcceleratedTypes}");
                        VectorTextUtil.WriteLine(indentNext, writer, "Max<float>(Demo, V1):\t{0}", instance.Max(Vector256s<float>.Demo, Vector256s<float>.V1));
                        VectorTextUtil.WriteLine(indentNext, writer, "Max<double>(Demo, V1):\t{0}", instance.Max(Vector256s<double>.Demo, Vector256s<double>.V1));
                        VectorTextUtil.WriteLine(indentNext, writer, "Max<double>(DemoNaN, V1):\t{0}", instance.Max(Vector256s<double>.DemoNaN, Vector256s<double>.V1));
                        VectorTextUtil.WriteLine(indentNext, writer, "Max<double>(DemoNaN2, V1):\t{0}", instance.Max(Vector256s<double>.DemoNaN2, Vector256s<double>.V1));
                        VectorTextUtil.WriteLine(indentNext, writer, "Max<double>(DemoNaN, DemoNaN2):\t{0}", instance.Max(Vector256s<double>.DemoNaN, Vector256s<double>.DemoNaN2));
                        VectorTextUtil.WriteLine(indentNext, writer, "Max<double>(DemoNaN, NaN):\t{0}", instance.Max(Vector256s<double>.DemoNaN, Vector256s<double>.NaN));
                        VectorTextUtil.WriteLine(indentNext, writer, "Max<double>(NaN, DemoNaN):\t{0}", instance.Max(Vector256s<double>.NaN, Vector256s<double>.DemoNaN));
                    }
                } catch (Exception ex) {
                    writer.WriteLine($"Max:\tFail!. {ex}");
                }
                writer.WriteLine();
            }

            // -- Min --
            if (true) {
                try {
                    foreach (IWVectorTraits256 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Console.WriteLine($"{instance.GetType().Name}: {instance.Min_AcceleratedTypes}");
                        VectorTextUtil.WriteLine(indentNext, writer, "Min<float>(Demo, V1):\t{0}", instance.Min(Vector256s<float>.Demo, Vector256s<float>.V1));
                        VectorTextUtil.WriteLine(indentNext, writer, "Min<double>(Demo, V1):\t{0}", instance.Min(Vector256s<double>.Demo, Vector256s<double>.V1));
                        VectorTextUtil.WriteLine(indentNext, writer, "Min<double>(DemoNaN, V1):\t{0}", instance.Min(Vector256s<double>.DemoNaN, Vector256s<double>.V1));
                        VectorTextUtil.WriteLine(indentNext, writer, "Min<double>(DemoNaN2, V1):\t{0}", instance.Min(Vector256s<double>.DemoNaN2, Vector256s<double>.V1));
                        VectorTextUtil.WriteLine(indentNext, writer, "Min<double>(DemoNaN, DemoNaN2):\t{0}", instance.Min(Vector256s<double>.DemoNaN, Vector256s<double>.DemoNaN2));
                        VectorTextUtil.WriteLine(indentNext, writer, "Min<double>(DemoNaN, NaN):\t{0}", instance.Min(Vector256s<double>.DemoNaN, Vector256s<double>.NaN));
                        VectorTextUtil.WriteLine(indentNext, writer, "Min<double>(NaN, DemoNaN):\t{0}", instance.Min(Vector256s<double>.NaN, Vector256s<double>.DemoNaN));
                    }
                } catch (Exception ex) {
                    writer.WriteLine($"Min:\tFail!. {ex}");
                }
                writer.WriteLine();
            }

#endif // NETCOREAPP3_0_OR_GREATER
        }

    }
}
