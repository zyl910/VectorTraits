# BenchmarkResults
([← Back](../../README.md))

## Benchmark results (基准测试结果)

- [ABitUtil](ABitUtil/README.md)
- [AVector](AVector/README.md)

## Common command lines (常用的命令行)

Prepare (准备):
```
cd ~/Documents/VectorTraits
cd ~/Documents/VectorTraits/net7.0

```


Benchmark (基准测试).
```
dotnet VectorTraits.Benchmarks.dll >1.txt
sz 1.txt

set DOTNET_JitDisasm=AloneTest
export DOTNET_JitDisasm=AloneTest
dotnet VectorTraits.Benchmarks.dll 3 >1.txt

dotnet VectorTraits.Benchmarks.dll -waitdebug
```

Unit test (单元测试).
```
dotnet test VectorTraits.Tests.dll /Tests:InstancesTest --logger:"trx;LogFileName=out.trx"
sz TestResults/out.trx
```
