# BenchmarkResults
([← Back](../../README.md))

## Benchmark results (基准测试结果)

- [ABitUtil](ABitUtil/README.md)
- [AVector](AVector/README.md)

## Common command lines (常用的命令行)

### Benchmark (基准测试)

Prepare (准备):
```
mkdir ~/Documents/VectorTraits
mkdir ~/Documents/VectorTraits/benchmarks

cd ~/Documents/VectorTraits/benchmarks
rm -r *
rz
unzip Release.zip

```

Run (运行):
```
cd ~/Documents/VectorTraits/benchmarks
dotnet netcoreapp3.1/VectorTraits.Benchmarks.dll
dotnet net5.0/VectorTraits.Benchmarks.dll
dotnet net6.0/VectorTraits.Benchmarks.dll
dotnet net7.0/VectorTraits.Benchmarks.dll

cd ~/Documents/VectorTraits/benchmarks/net7.0
dotnet VectorTraits.Benchmarks.dll >1.txt
dotnet VectorTraits.Benchmarks.NetCore.dll >1.txt
sz 1.txt

dotnet VectorTraits.Benchmarks.dll 1>1.txt
rm -r BenchmarkDotNet.Artifacts
tar -cvf BenchmarkDotNet.Artifacts.tar BenchmarkDotNet.Artifacts
sz BenchmarkDotNet.Artifacts.tar

set DOTNET_JitDisasm=AloneTest
export DOTNET_JitDisasm=AloneTest
dotnet VectorTraits.Benchmarks.dll 3 >1.txt
set DOTNET_JitDisasm=WidenBenchmark_SByte.*
dotnet VectorTraits.Benchmarks.dll >1.txt

dotnet VectorTraits.Benchmarks.dll -waitdebug
```


### Unit test (单元测试)

Prepare (准备):
```
cd ~/Documents/VectorTraits/tests
rm -r *
rz
unzip Release.zip

```

Run (运行):
```
cd ~/Documents/VectorTraits/tests/netcoreapp3.0
cd ~/Documents/VectorTraits/tests/net5.0
cd ~/Documents/VectorTraits/tests/net6.0
cd ~/Documents/VectorTraits/tests/net7.0

dotnet test VectorTraits.Tests.dll
dotnet test VectorTraits.Tests.dll --logger:"trx;LogFileName=out.trx"
dotnet test VectorTraits.Tests.dll --logger:"trx;LogFileName=out.trx" /Tests:InstancesTest
sz TestResults/out.trx
```


        /// <summary>
        /// Sum shift left logical - Traits static - ConstCore.
        /// </summary>
        /// <param name="src">Source array.</param>
        /// <param name="srcCount">Source count</param>
        /// <param name="shiftAmount">Shift amount.</param>
        /// <returns>Returns the sum.</returns>
        private static TMy StaticSumSLLConstTraits_Core(TMy[] src, int srcCount, int shiftAmount) {
            TMy rt = 0; // Result.
            const int GroupSize = 1;
            int VectorWidth = Vector<TMy>.Count; // Block width.
            int nBlockWidth = VectorWidth; // Block width.
            int cntBlock = srcCount / nBlockWidth; // Block count.
            int cntRem = srcCount % nBlockWidth; // Remainder count.
            Vector<TMy> vrt = Vector<TMy>.Zero; // Vector result.
            int i;
            // Body.
            var args0 = Vectors.ShiftLeft_Args(vrt, shiftAmount, out var args1);
            ref Vector<TMy> p0 = ref Unsafe.As<TMy, Vector<TMy>>(ref src[0]);
            // Vector processs.
            for (i = 0; i < cntBlock; ++i) {
                Vector<TMy> vtemp = Vectors.ShiftLeft_ConstCore(p0, shiftAmount, args0, args1);
                vrt += vtemp; // Add.
                p0 = ref Unsafe.Add(ref p0, GroupSize);
            }
            // Remainder processs.
            ref TMy p = ref Unsafe.As<Vector<TMy>, TMy>(ref p0);
            for (i = 0; i < cntRem; ++i) {
                rt += (TMy)(Unsafe.Add(ref p, i) << shiftAmount);
            }
            // Reduce.
            rt += Vectors.Sum(vrt);
            return rt;
        }

        [Benchmark]
        public void SumSLLConstTraits_Core() {
            if (BenchmarkUtil.IsLastRun) {
                Volatile.Write(ref dstTMy, 0);
                //Debugger.Break();
            }
            dstTMy = StaticSumSLLConstTraits_Core(srcArray, srcArray.Length, shiftAmount);
            CheckResult("SumSLLConstTraits_Core");
        }

