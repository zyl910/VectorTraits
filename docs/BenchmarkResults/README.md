# BenchmarkResults
([← Back](../../README.md))

## Benchmark results (基准测试结果)

- [ABitUtil](ABitUtil/README.md)
- [AVector](AVector/README.md)

## Common command lines (常用的命令行)

### Benchmark (基准测试)

Prepare (准备):
```
cd ~/Documents/VectorTraits/benchmarks
rm -r *
rz
unzip Release.zip

```

Run (运行):
```
cd ~/Documents/VectorTraits/benchmarks/net7.0
dotnet VectorTraits.Benchmarks.dll >1.txt
dotnet VectorTraits.Benchmarks.NetCore.dll >1.txt
sz 1.txt

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
cd ~/Documents/VectorTraits/tests/net7.0

dotnet test VectorTraits.Tests.dll
dotnet test VectorTraits.Tests.dll /Tests:InstancesTest --logger:"trx;LogFileName=out.trx"
sz TestResults/out.trx
```
