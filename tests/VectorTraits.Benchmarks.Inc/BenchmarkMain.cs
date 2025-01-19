using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Zyl.VectorTraits.Benchmarks.ABitMath;
using Zyl.VectorTraits.Benchmarks.AVector.C;
using Zyl.VectorTraits.Benchmarks.AVector.F;
using Zyl.VectorTraits.Benchmarks.AVector.M;
using Zyl.VectorTraits.Benchmarks.AVector.N;
using Zyl.VectorTraits.Benchmarks.AVector.S;
using Zyl.VectorTraits.Benchmarks.AVector.W;
using Zyl.VectorTraits.Benchmarks.AVector.YC;
using Zyl.VectorTraits.Benchmarks.AVector.YG;
using Zyl.VectorTraits.Benchmarks.AVector.YN;
using Zyl.VectorTraits.Benchmarks.AVector.YR;
using Zyl.VectorTraits.Benchmarks.AVector.YS;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Benchmarks {
#nullable enable

    internal class BenchmarkMain {

        private static bool _inited = false;

        /// <summary>
        /// Run benchmark.
        /// </summary>
        /// <param name="writer">Output <see cref="TextWriter"/>.</param>
        /// <param name="indent">The indent.</param>
        /// <param name="onBefore">The action on before call item. Prototype: <c>void onBefore(double percentage, string title)</c>.</param>
        public static void RunBenchmark(TextWriter writer, string indent, Action<double, string>? onBefore = null) {
            // info.
            //writer.WriteLine(indent + string.Format("VectorTTraits.BaseIInstance.Name:\t{0}", VectorTTraits.BaseIInstance.Name));
            //writer.WriteLine(indent + string.Format("VectorTTraits:\t{0}", VectorTTraits.IInstance));
            //writer.WriteLine(indent + string.Format("VectorTTraits.Name:\t{0}", VectorTTraits.Name));
            //writer.WriteLine(indent + string.Format("VectorTTraits.ByteCount:\t{0}", VectorTTraits.ByteCount));
            //writer.WriteLine(indent + string.Format("VectorTTraits.IsSupported:\t{0}", VectorTTraits.IsSupported));
            //writer.WriteLine(indent + string.Format("AccelerateState-VectorTTraits256Base.ShiftRightArithmetic:\t{0}", AccelerateStateAttribute.GetAttributeValue(typeof(VectorTTraits256Base).GetMethod("ShiftRightArithmetic"))));
            //writer.WriteLine(indent + string.Format("AccelerateState-VectorTTraits256Avx2.ShiftRightArithmetic:\t{0}", AccelerateStateAttribute.GetAttributeValue(typeof(VectorTTraits256Avx2).GetMethod("ShiftRightArithmetic"))));
            // RunBenchmark.
            BenchmarkUtil.CurrentBenchmarkWriter.CurrentTextWriter = writer;
            BenchmarkUtil.RunBenchmark(BenchmarkUtil.CurrentBenchmarkWriter, typeof(BenchmarkMain).Assembly, onBefore);
        }

        /// <summary>
        /// Run benchmark - Async.
        /// </summary>
        /// <param name="writer">Output <see cref="TextWriter"/>.</param>
        /// <param name="indent">The indent.</param>
        /// <param name="onBefore">The action on before call item. Prototype: <c>Task onBefore(double percentage, string title)</c>.</param>
        public static async Task RunBenchmarkAsync(TextWriter writer, string indent, Func<double, string, Task>? onBefore = null) {
            // info.
            //writer.WriteLine(indent + string.Format("VectorTTraits.BaseIInstance.Name:\t{0}", VectorTTraits.BaseIInstance.Name));
            //writer.WriteLine(indent + string.Format("VectorTTraits:\t{0}", VectorTTraits.IInstance));
            //writer.WriteLine(indent + string.Format("VectorTTraits.Name:\t{0}", VectorTTraits.Name));
            //writer.WriteLine(indent + string.Format("VectorTTraits.ByteCount:\t{0}", VectorTTraits.ByteCount));
            //writer.WriteLine(indent + string.Format("VectorTTraits.IsSupported:\t{0}", VectorTTraits.IsSupported));
            //writer.WriteLine(indent + string.Format("AccelerateState-VectorTTraits256Base.ShiftRightArithmetic:\t{0}", AccelerateStateAttribute.GetAttributeValue(typeof(VectorTTraits256Base).GetMethod("ShiftRightArithmetic"))));
            //writer.WriteLine(indent + string.Format("AccelerateState-VectorTTraits256Avx2.ShiftRightArithmetic:\t{0}", AccelerateStateAttribute.GetAttributeValue(typeof(VectorTTraits256Avx2).GetMethod("ShiftRightArithmetic"))));
            // RunBenchmark.
            BenchmarkUtil.CurrentBenchmarkWriter.CurrentTextWriter = writer;
            await BenchmarkUtil.RunBenchmarkAsync(BenchmarkUtil.CurrentBenchmarkWriter, typeof(BenchmarkMain).Assembly, onBefore);
        }

        /// <summary>
        /// Register benchmark types.
        /// </summary>
#if NET5_0_OR_GREATER
        [UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "They are test")]
#endif // NET5_0_OR_GREATER
        private static void RegisterBenchmark() {
            if (_inited) return;
            _inited = true;
            WrappedType[] types = {
                // ABitMath
                typeof(BigMulBenchmark_UInt64),
                typeof(ClampBenchmark_Int16),
                typeof(ClampBenchmark_Int32),
                typeof(ConditionalSelectBenchmark_Int16),
                typeof(ConditionalSelectBenchmark_Int32),

                // AVector
                typeof(CeilingBenchmark_Double),
                typeof(CeilingBenchmark_Single),
                typeof(ConvertToDoubleBenchmark_Int64),
                typeof(ConvertToDoubleBenchmark_UInt64),
                typeof(ConvertToInt32Benchmark_Single),
                typeof(ConvertToInt64Benchmark_Double),
                typeof(ConvertToSingleBenchmark_Int32),
                typeof(ConvertToSingleBenchmark_UInt32),
                typeof(ConvertToUInt32Benchmark_Single),
                typeof(ConvertToUInt64Benchmark_Double),
                typeof(FloorBenchmark_Double),
                typeof(FloorBenchmark_Single),
                typeof(MultiplyBenchmark_Double),
                typeof(MultiplyBenchmark_Int16),
                typeof(MultiplyBenchmark_Int32),
                typeof(MultiplyBenchmark_SByte),
                typeof(MultiplyBenchmark_Single),
                typeof(MultiplyBenchmark_UInt32),
                typeof(MultiplyBenchmark_UInt64),
                typeof(NarrowBenchmark_Double),
                typeof(NarrowBenchmark_Int16),
                typeof(NarrowBenchmark_Int64),
                typeof(ShiftLeftBenchmark_Byte),
                typeof(ShiftLeftBenchmark_Int16),
                typeof(ShiftLeftBenchmark_Int32),
                typeof(ShiftLeftBenchmark_Int64),
                typeof(ShiftLeftBenchmark_SByte),
                typeof(ShiftLeftConstBenchmark_Byte),
                typeof(ShiftLeftConstBenchmark_Int16),
                typeof(ShiftLeftConstBenchmark_Int32),
                typeof(ShiftLeftConstBenchmark_Int64),
                typeof(ShiftRightArithmeticBenchmark_Int16),
                typeof(ShiftRightArithmeticBenchmark_Int32),
                typeof(ShiftRightArithmeticBenchmark_Int64),
                typeof(ShiftRightArithmeticBenchmark_SByte),
                typeof(ShiftRightArithmeticConstBenchmark_Int16),
                typeof(ShiftRightArithmeticConstBenchmark_Int32),
                typeof(ShiftRightArithmeticConstBenchmark_Int64),
                typeof(ShiftRightArithmeticConstBenchmark_SByte),
                typeof(ShiftRightLogicalBenchmark_Byte),
                typeof(ShiftRightLogicalBenchmark_UInt16),
                typeof(ShiftRightLogicalBenchmark_UInt32),
                typeof(ShiftRightLogicalBenchmark_UInt64),
                typeof(ShiftRightLogicalConstBenchmark_Byte),
                typeof(ShiftRightLogicalConstBenchmark_UInt16),
                typeof(ShiftRightLogicalConstBenchmark_UInt32),
                typeof(ShiftRightLogicalConstBenchmark_UInt64),
                typeof(ShuffleBenchmark_Int16),
                typeof(ShuffleBenchmark_Int32),
                typeof(ShuffleBenchmark_Int64),
                typeof(ShuffleBenchmark_SByte),
                typeof(WidenBenchmark_Int32),
                typeof(WidenBenchmark_SByte),
                typeof(WidenBenchmark_Single),
                typeof(YClampBenchmark_Double),
                typeof(YClampBenchmark_Int16),
                typeof(YClampBenchmark_Int32),
                typeof(YClampBenchmark_Int64),
                typeof(YClampBenchmark_SByte),
                typeof(YClampBenchmark_Single),
                typeof(YGroup1ToGroup3Benchmark_Byte),
                typeof(YGroup1ToGroup3Benchmark_Int16),
                typeof(YGroup1ToGroup3Benchmark_Int32),
                typeof(YGroup1ToGroup3Benchmark_Int64),
                typeof(YGroup2TransposeBenchmark_Byte),
                typeof(YGroup2TransposeBenchmark_Int16),
                typeof(YGroup2TransposeBenchmark_Int32),
                typeof(YGroup2TransposeBenchmark_Int64),
                typeof(YGroup2UnzipBenchmark_Byte),
                typeof(YGroup2UnzipBenchmark_Int128),
                typeof(YGroup2UnzipBenchmark_Int128_B),
                typeof(YGroup2UnzipBenchmark_Int16),
                typeof(YGroup2UnzipBenchmark_Int32),
                typeof(YGroup2UnzipBenchmark_Int64),
                typeof(YGroup2ZipBenchmark_Byte),
                typeof(YGroup2ZipBenchmark_Int128),
                typeof(YGroup2ZipBenchmark_Int16),
                typeof(YGroup2ZipBenchmark_Int32),
                typeof(YGroup2ZipBenchmark_Int64),
                typeof(YGroup3ToGroup4Benchmark_Byte),
                typeof(YGroup3ToGroup4Benchmark_Int16),
                typeof(YGroup3ToGroup4Benchmark_Int32),
                typeof(YGroup3ToGroup4Benchmark_Int64),
                typeof(YGroup3UnzipBenchmark_Byte),
                typeof(YGroup3UnzipBenchmark_Int16),
                typeof(YGroup3UnzipBenchmark_Int32),
                typeof(YGroup3UnzipBenchmark_Int64),
                typeof(YGroup3ZipBenchmark_Byte),
                typeof(YGroup3ZipBenchmark_Int16),
                typeof(YGroup3ZipBenchmark_Int32),
                typeof(YGroup3ZipBenchmark_Int64),
                typeof(YGroup4ToGroup3Benchmark_Byte),
                typeof(YGroup4ToGroup3Benchmark_Int16),
                typeof(YGroup4ToGroup3Benchmark_Int32),
                typeof(YGroup4ToGroup3Benchmark_Int64),
                typeof(YGroup4UnzipBenchmark_Byte),
                typeof(YGroup4UnzipBenchmark_Int128),
                typeof(YGroup4UnzipBenchmark_Int16),
                typeof(YGroup4UnzipBenchmark_Int32),
                typeof(YGroup4UnzipBenchmark_Int64),
                typeof(YGroup4ZipBenchmark_Byte),
                typeof(YGroup4ZipBenchmark_Int128),
                typeof(YGroup4ZipBenchmark_Int16),
                typeof(YGroup4ZipBenchmark_Int32),
                typeof(YGroup4ZipBenchmark_Int64),
                typeof(YNarrowSaturateBenchmark_Int16),
                typeof(YNarrowSaturateBenchmark_Int32),
                typeof(YNarrowSaturateBenchmark_Int64),
                typeof(YNarrowSaturateBenchmark_UInt16),
                typeof(YNarrowSaturateBenchmark_UInt32),
                typeof(YNarrowSaturateBenchmark_UInt64),
                typeof(YNarrowSaturateUnsignedBenchmark_Int16),
                typeof(YNarrowSaturateUnsignedBenchmark_Int32),
                typeof(YNarrowSaturateUnsignedBenchmark_Int64),
                typeof(YRoundToEvenBenchmark_Double),
                typeof(YRoundToEvenBenchmark_Single),
                typeof(YRoundToZeroBenchmark_Double),
                typeof(YRoundToZeroBenchmark_Single),
                typeof(YShuffleG2Benchmark_Int16),
                typeof(YShuffleG2Benchmark_Int32),
                typeof(YShuffleG2Benchmark_Int64),
                typeof(YShuffleG2Benchmark_SByte),
                typeof(YShuffleG4X2Benchmark_Int16),
                typeof(YShuffleG4X2Benchmark_Int32),
                typeof(YShuffleG4X2Benchmark_Int64),
                typeof(YShuffleG4X2Benchmark_SByte),
                typeof(YShuffleX2KernelBenchmark_Byte),
                typeof(YShuffleX2KernelBenchmark_Int16),
                typeof(YShuffleX2KernelBenchmark_Int32),
                typeof(YShuffleX2KernelBenchmark_Int64),
                typeof(YShuffleX3KernelBenchmark_Byte),
                typeof(YShuffleX3KernelBenchmark_Int16),
                typeof(YShuffleX3KernelBenchmark_Int32),
                typeof(YShuffleX3KernelBenchmark_Int64),
                typeof(YShuffleX4KernelBenchmark_Byte),
                typeof(YShuffleX4KernelBenchmark_Int16),
                typeof(YShuffleX4KernelBenchmark_Int32),
                typeof(YShuffleX4KernelBenchmark_Int64),
            };
            WrappedTypePool.Shared.RegisterAll(types);
        }

        static BenchmarkMain() {
            RegisterBenchmark();
        }

    }

#nullable restore
}
