# BenchmarkResults
([← Back](../../README.md))

## Benchmark results (基准测试结果)

- [ABitUtil](ABitUtil/README.md)
- [AVector](AVector/README.md)

## Common command lines (常用的命令行)

### Benchmark (基准测试)

Prepare (准备):
```
mkdir -p ~/Documents/VectorTraits
mkdir -p ~/Documents/VectorTraits/benchmarks

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

RunBenchmarks_Combine.sh
```
cd ~/Documents/VectorTraits/benchmarks
rm RunBenchmarks_Combine.sh
rz
chmod u+x RunBenchmarks_Combine.sh
./RunBenchmarks_Combine.sh
vi CombineBenchmarks_out.txt
sz CombineBenchmarks_out.txt
```


### Unit test (单元测试)

Prepare (准备):
```
mkdir -p ~/Documents/VectorTraits/tests

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


### VectorTraits.Sample (范例)

Prepare (准备):
```
mkdir -p ~/Documents/VectorTraits/samples

cd ~/Documents/VectorTraits/samples
rm -r *
rz
unzip Release.zip

```

Run (运行):
```
cd ~/Documents/VectorTraits/samples
dotnet net7.0/VectorTraits.Sample.dll
```
