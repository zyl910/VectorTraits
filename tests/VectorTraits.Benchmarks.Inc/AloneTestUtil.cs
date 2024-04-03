using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
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

        /// <summary>Show accelerated info. Command is `-accelerated`.</summary>
        internal static bool ShowAccelerated = true;
        /// <summary>Show tests. Command is `-test`.</summary>
        internal static bool ShowTest = false;
        /// <summary>Show fixed width Vector. Command is `-fixedVector`.</summary>
        internal static bool ShowFixedVector = true;
        /// <summary>Show cpu detection result. Command is `-cpuDetection`.</summary>
        internal static bool ShowCpuDetection = true;

        /// <summary>
        /// Alone test by commnad.
        /// </summary>
        /// <param name="args">Command line args.</param>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void AloneTestByCommand(TextWriter writer, string[] args) {
            ParseCommand(args);
            //Debugger.Break();
            AloneTest(writer);
        }

        /// <summary>
        /// Parse command line args.
        /// </summary>
        /// <param name="args">Command line args.</param>
        public static void ParseCommand(string[] args) {
            const StringComparison comparisonType = StringComparison.OrdinalIgnoreCase;
            if (null == args) return;
            foreach (string arg in args) {
                int dst = VectorTextUtil.SplitKeyValueToInt(arg, out string key, 1);
                bool dstBool = 0 != dst;
                if ("-accelerated".Equals(key, comparisonType)) {
                    ShowAccelerated = dstBool;
                }
                if ("-accelerated0".Equals(key, comparisonType)) {
                    ShowAccelerated = false;
                }
                if ("-test".Equals(key, comparisonType)) {
                    ShowTest = dstBool;
                }
                if ("-test0".Equals(key, comparisonType)) {
                    ShowTest = false;
                }
                if ("-fixedVector".Equals(key, comparisonType)) {
                    ShowFixedVector = dstBool;
                }
                if ("-fixedVector0".Equals(key, comparisonType)) {
                    ShowFixedVector = false;
                }
                if ("-cpuDetection".Equals(key, comparisonType)) {
                    ShowCpuDetection = dstBool;
                }
                if ("-cpuDetection0".Equals(key, comparisonType)) {
                    ShowCpuDetection = false;
                }
            }
        }

        /// <summary>
        /// Alone test.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void AloneTest(TextWriter writer) {
            AloneTestVector(writer);
            if (ShowFixedVector) {
                AloneTestVector128(writer);
                AloneTestVector256(writer);
                AloneTestVector512(writer);
            }
            if (ShowCpuDetection) {
                AloneTestCpuDetection(writer);
            }

            // -- IntroDisassemblyDry --
            //var o = new IntroDisassemblyDry();
            //int n = o.RunVector128();
            //writer.WriteLine("RunVector128:\t{0}", n);
        }

        /// <summary>
        /// Alone test CpuDetection.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void AloneTestCpuDetection(TextWriter writer) {
            writer.WriteLine("CpuDetectionException: {0}", VectorEnvironment.CpuDetectionException);
            writer.WriteLine("CpuDetectionCommand: {0}", VectorEnvironment.CpuDetectionCommand);
            VectorTextUtil.WriteLines(writer, VectorEnvironment.CpuDetectionResult);
            writer.WriteLine();
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
                    writer.WriteLine($"{instance.GetType().Name}: OK.");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage(true)}");
                }
            }
            if (ShowAccelerated) {
                IVectorTraits instance = Vectors.Instance;
                writer.WriteLine(string.Format("[Vectors.Instance: {0}]", instance.GetType().Name));
                VectorTextUtil.OutputProperties(writer, instance);
            }
            writer.WriteLine();

            if (ShowTest) {
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
            } // ShowTest

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
                    writer.WriteLine($"{instance.GetType().Name}: OK.");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage(true)}");
                }
            }
            if (ShowAccelerated) {
                IWVectorTraits128 instance = Vector128s.Instance;
                writer.WriteLine(string.Format("[Vector128s.Instance: {0}]", instance.GetType().Name));
                VectorTextUtil.OutputProperties(writer, instance);
            }
            writer.WriteLine();

            if (ShowTest) {
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
            } // ShowTest

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
                    writer.WriteLine($"{instance.GetType().Name}: OK.");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage(true)}");
                }
            }
            if (ShowAccelerated) {
                IWVectorTraits256 instance = Vector256s.Instance;
                writer.WriteLine(string.Format("[Vector256s.Instance: {0}]", instance.GetType().Name));
                VectorTextUtil.OutputProperties(writer, instance);
            }
            writer.WriteLine();

            if (ShowTest) {
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
            } // ShowTest

#endif // NETCOREAPP3_0_OR_GREATER
        }

        /// <summary>
        /// Alone test Vector512.
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void AloneTestVector512(TextWriter writer) {
#if NET8_0_OR_GREATER
            string indentNext = IndentNextSeparator;

            // -- TraitsInstances --
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    writer.WriteLine($"{instance.GetType().Name}: OK.");
                } else {
                    writer.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage(true)}");
                }
            }
            if (ShowAccelerated) {
                IWVectorTraits512 instance = Vector512s.Instance;
                writer.WriteLine(string.Format("[Vector512s.Instance: {0}]", instance.GetType().Name));
                VectorTextUtil.OutputProperties(writer, instance);
            }
            writer.WriteLine();

            if (ShowTest) {
                VectorTextUtil.WriteLine(writer, "Vector512s<float>.Demo:\t{0}", Vector512s<float>.Demo);
                VectorTextUtil.WriteLine(writer, "Vector512s<double>.Demo:\t{0}", Vector512s<double>.Demo);
                VectorTextUtil.WriteLine(writer, "Vector512s<double>.DemoNaN:\t{0}", Vector512s<double>.DemoNaN);
                VectorTextUtil.WriteLine(writer, "Vector512s<double>.DemoNaN2:\t{0}", Vector512s<double>.DemoNaN2);
                writer.WriteLine();

            } // ShowTest

#endif // NET8_0_OR_GREATER
        }

    }
}
