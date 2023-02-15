# Benchmark - Widen
([← Back](README.md))

## x86

### lntel Core i5-8250U
`lntel(R) Core(TM) i5-8250U CPU @ 1.60GHz`

#### .NET Framework 4.5

```
```

#### .NET Core 2.1

```
```

#### .NET Core 3.1

```
```

#### .NET 5

```
```

#### .NET 6

```
```

#### .NET 7

```
VectorTraits.Benchmarks
benchmarkMode:  0

IsRelease:      True
EnvironmentVariable(PROCESSOR_IDENTIFIER):      Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:     8
Environment.Is64BitProcess:     True
Environment.OSVersion:  Microsoft Windows NT 10.0.19045.0
Environment.Version:    7.0.1
Stopwatch.Frequency:    10000000
RuntimeEnvironment.GetRuntimeDirectory: C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.1\
RuntimeInformation.FrameworkDescription:        .NET 7.0.1
RuntimeInformation.OSArchitecture:      X64
IntPtr.Size:    8
BitConverter.IsLittleEndian:    True
Vector.IsHardwareAccelerated:   True
Vector<byte>.Count:     32      # 256bit
Vector<float>.Count:    8       # 256bit
Vector<T>.Assembly.CodeBase:    file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.1/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):      .NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):    .NET 7.0
Vectors.Instance:       VectorTraits256Avx2
Vectors.BaseInstance:   VectorTraits256Base


[WidenBenchmark_SByte(262144)]
---
NAME    US      MOPS    SCALE
# SumWidenScalar        6514
SumWidenScalar  161.721 1620.961
SumWidenBcl     7.634   34338.105       21.183789
SumWidenVectorBase      7.652   34256.867       21.133672
SumWidenVectorTraits    10.189  25727.682       15.871866
SumWidenVector128_Arm   Run fail! Operation is not supported on this platform.
SumWidenVector128Traits 14.956  17528.143       10.813424
SumWidenVector256Traits 10.221  25648.831       15.823221

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
```

## Arm

### AWS Arm t4g.small
`AWS Arm t4g.small`

#### .NET Core 3.1

```
```

#### .NET 5

```
```

#### .NET 6

```
```

#### .NET 7

```
```

