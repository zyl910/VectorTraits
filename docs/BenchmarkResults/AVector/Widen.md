# Benchmark - Widen
([← Back](README.md))

## x86

### lntel Core i5-8250U
`lntel(R) Core(TM) i5-8250U CPU @ 1.60GHz`

#### .NET Framework 4.5

```
VectorTraits.Benchmarks.NetFw
benchmarkMode:  0

IsRelease:      True
EnvironmentVariable(PROCESSOR_IDENTIFIER):      Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:     8
Environment.Is64BitProcess:     True
Environment.OSVersion:  Microsoft Windows NT 6.2.9200.0
Environment.Version:    4.0.30319.42000
Stopwatch.Frequency:    10000000
RuntimeEnvironment.GetRuntimeDirectory: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\
RuntimeInformation.FrameworkDescription:        .NET Framework 4.8.4515.0
RuntimeInformation.OSArchitecture:      X64
IntPtr.Size:    8
BitConverter.IsLittleEndian:    True
Vector.IsHardwareAccelerated:   True
Vector<byte>.Count:     32      # 256bit
Vector<float>.Count:    8       # 256bit
Vector<T>.Assembly.CodeBase:    file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(TraitsUtil):      .NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):    .NET Framework 4.5
Vectors.Instance:       VectorTraits256Base
Vectors.BaseInstance:   VectorTraits256Base


[WidenBenchmark_Int32(262144)]
---
NAME    US      MOPS    SCALE
# SumWidenScalar        -829396443174
SumWidenScalar  160.090 1637.477
SumWidenBcl     47.607  5506.402        3.362735
SumWidenVectorBase      321.903 814.357 0.497324
SumWidenVectorTraits    318.108 824.071 0.503257

[WidenBenchmark_SByte(262144)]
---
NAME    US      MOPS    SCALE
# SumWidenScalar        6514
SumWidenScalar  165.561 1583.371
SumWidenBcl     11.080  23659.821       14.942691
SumWidenVectorBase      142.059 1845.312        1.165433
SumWidenVectorTraits    140.788 1861.976        1.175957

[WidenBenchmark_Single(262144)]
---
NAME    US      MOPS    SCALE
# SumWidenScalar        130888.73095194
SumWidenScalar  316.117 829.263
SumWidenBcl     40.773  6429.305        7.753033
SumWidenVectorBase      324.179 808.641 0.975131
SumWidenVectorTraits    324.459 807.941 0.974288

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!
```

#### .NET Core 2.1

```
VectorTraits.Benchmarks.NetCore
benchmarkMode:  0

IsRelease:      True
EnvironmentVariable(PROCESSOR_IDENTIFIER):      Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:     8
Environment.Is64BitProcess:     True
Environment.OSVersion:  Microsoft Windows NT 10.0.19045.0
Environment.Version:    4.0.30319.42000
Stopwatch.Frequency:    10000000
RuntimeEnvironment.GetRuntimeDirectory: C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.30\
RuntimeInformation.FrameworkDescription:        .NET Core 4.6.30411.01
RuntimeInformation.OSArchitecture:      X64
IntPtr.Size:    8
BitConverter.IsLittleEndian:    True
Vector.IsHardwareAccelerated:   True
Vector<byte>.Count:     32      # 256bit
Vector<float>.Count:    8       # 256bit
Vector<T>.Assembly.CodeBase:    file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):      .NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):    .NET Core 2.1
Vectors.Instance:       VectorTraits256Base
Vectors.BaseInstance:   VectorTraits256Base


[WidenBenchmark_Int32(262144)]
---
NAME    US      MOPS    SCALE
# SumWidenScalar        -829396443174
SumWidenScalar  150.164 1745.720
SumWidenBcl     47.498  5519.103        3.161505
SumWidenVectorBase      377.857 693.766 0.397409
SumWidenVectorTraits    376.420 696.414 0.398927

[WidenBenchmark_SByte(262144)]
---
NAME    US      MOPS    SCALE
# SumWidenScalar        6514
SumWidenScalar  167.444 1565.558
SumWidenBcl     11.193  23421.369       14.960397
SumWidenVectorBase      160.138 1636.986        1.045624
SumWidenVectorTraits    160.280 1635.540        1.044701

[WidenBenchmark_Single(262144)]
---
NAME    US      MOPS    SCALE
# SumWidenScalar        130888.73095194
SumWidenScalar  319.200 821.253
SumWidenBcl     44.979  5828.117        7.096619
SumWidenVectorBase      393.460 666.253 0.811265
SumWidenVectorTraits    388.452 674.842 0.821723

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!
```

#### .NET Core 3.1

```
VectorTraits.Benchmarks
benchmarkMode:  0

IsRelease:      True
EnvironmentVariable(PROCESSOR_IDENTIFIER):      Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:     8
Environment.Is64BitProcess:     True
Environment.OSVersion:  Microsoft Windows NT 6.2.9200.0
Environment.Version:    3.1.32
Stopwatch.Frequency:    10000000
RuntimeEnvironment.GetRuntimeDirectory: C:\Program Files\dotnet\shared\Microsoft.NETCore.App\3.1.32\
RuntimeInformation.FrameworkDescription:        .NET Core 3.1.32
RuntimeInformation.OSArchitecture:      X64
IntPtr.Size:    8
BitConverter.IsLittleEndian:    True
Vector.IsHardwareAccelerated:   True
Vector<byte>.Count:     32      # 256bit
Vector<float>.Count:    8       # 256bit
Vector<T>.Assembly.CodeBase:    file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):      .NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):    .NET Core 3.1
Vectors.Instance:       VectorTraits256Avx2
Vectors.BaseInstance:   VectorTraits256Base


[WidenBenchmark_Int32(262144)]
---
NAME    US      MOPS    SCALE
# SumWidenScalar        -829396443174
SumWidenScalar  139.919 1873.543
SumWidenBcl     47.425  5527.577        2.950334
SumWidenVectorBase      47.659  5500.406        2.935831
SumWidenVectorTraits    35.285  7429.407        3.965432
SumWidenVector128Traits 1178.838        222.375 0.118692
SumWidenVector256Traits 35.446  7395.631        3.947404

[WidenBenchmark_SByte(262144)]
---
NAME    US      MOPS    SCALE
# SumWidenScalar        6514
SumWidenScalar  165.247 1586.380
SumWidenBcl     11.190  23425.970       14.766933
SumWidenVectorBase      11.167  23475.223       14.797981
SumWidenVectorTraits    8.024   32671.456       20.594973
SumWidenVector128Traits 402.867 650.696 0.410177
SumWidenVector256Traits 8.031   32643.210       20.577168

[WidenBenchmark_Single(262144)]
---
NAME    US      MOPS    SCALE
# SumWidenScalar        130888.73095194018
SumWidenScalar  314.862 832.567
SumWidenBcl     40.943  6402.686        7.690298
SumWidenVectorBase      41.322  6343.908        7.619699
SumWidenVectorTraits    41.204  6362.158        7.641619
SumWidenVector128Traits 1234.061        212.424 0.255143
SumWidenVector256Traits 41.480  6319.765        7.590700

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
```

#### .NET 5

```
```

#### .NET 6

```
VectorTraits.Benchmarks
benchmarkMode:  0

IsRelease:      True
EnvironmentVariable(PROCESSOR_IDENTIFIER):      Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:     8
Environment.Is64BitProcess:     True
Environment.OSVersion:  Microsoft Windows NT 10.0.19045.0
Environment.Version:    6.0.12
Stopwatch.Frequency:    10000000
RuntimeEnvironment.GetRuntimeDirectory: C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.12\
RuntimeInformation.FrameworkDescription:        .NET 6.0.12
RuntimeInformation.OSArchitecture:      X64
IntPtr.Size:    8
BitConverter.IsLittleEndian:    True
Vector.IsHardwareAccelerated:   True
Vector<byte>.Count:     32      # 256bit
Vector<float>.Count:    8       # 256bit
Vector<T>.Assembly.CodeBase:    file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.12/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(TraitsUtil):      .NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):    .NET 6.0
Vectors.Instance:       VectorTraits256Avx2
Vectors.BaseInstance:   VectorTraits256Base


[WidenBenchmark_Int32(262144)]
---
NAME    US      MOPS    SCALE
# SumWidenScalar        -829396443174
SumWidenScalar  141.428 1853.549
SumWidenBcl     47.505  5518.225        2.977113
SumWidenVectorBase      47.402  5530.257        2.983603
SumWidenVectorTraits    35.126  7462.941        4.026297
SumWidenVector128_Arm   Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits 1156.944        226.583 0.122243
SumWidenVector256Traits 35.590  7365.602        3.973782

[WidenBenchmark_SByte(262144)]
---
NAME    US      MOPS    SCALE
# SumWidenScalar        6514
SumWidenScalar  156.831 1671.503
SumWidenBcl     11.176  23455.860       14.032795
SumWidenVectorBase      11.232  23338.998       13.962881
SumWidenVectorTraits    7.961   32927.203       19.699158
SumWidenVector128_Arm   Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits 397.495 659.491 0.394550
SumWidenVector256Traits 7.993   32798.316       19.622049

[WidenBenchmark_Single(262144)]
---
NAME    US      MOPS    SCALE
# SumWidenScalar        130888.73095194018
SumWidenScalar  315.427 831.077
SumWidenBcl     44.056  5950.195        7.159616
SumWidenVectorBase      43.905  5970.720        7.184312
SumWidenVectorTraits    48.041  5456.659        6.565764
SumWidenVector128_Arm   Run fail! Requires hardware support AdvSimd!
SumWidenVector128_ArmB64        Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits 1214.610        215.826 0.259694
SumWidenVector256Traits 44.937  5833.584        7.019302

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
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


[WidenBenchmark_Int32(262144)]
---
NAME    US      MOPS    SCALE
# SumWidenScalar        -829396443174
SumWidenScalar  165.935 1579.804
SumWidenBcl     32.865  7976.427        5.048998
SumWidenVectorBase      32.985  7947.467        5.030666
SumWidenVectorTraits    33.067  7927.777        5.018203
SumWidenVector128_Arm   Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits 59.730  4388.814        2.778075
SumWidenVector256Traits 33.109  7917.662        5.011800

[WidenBenchmark_SByte(262144)]
---
NAME    US      MOPS    SCALE
# SumWidenScalar        6514
SumWidenScalar  157.173 1667.865
SumWidenBcl     7.706   34016.516       20.395241
SumWidenVectorBase      7.722   33949.133       20.354840
SumWidenVectorTraits    7.697   34059.126       20.420788
SumWidenVector128_Arm   Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits 15.002  17473.640       10.476649
SumWidenVector256Traits 7.628   34364.123       20.603655

[WidenBenchmark_Single(262144)]
---
NAME    US      MOPS    SCALE
# SumWidenScalar        130888.73095194018
SumWidenScalar  314.842 832.620
SumWidenBcl     44.582  5880.058        7.062119
SumWidenVectorBase      44.488  5892.451        7.077003
SumWidenVectorTraits    44.154  5937.025        7.130538
SumWidenVector128_Arm   Run fail! Requires hardware support AdvSimd!
SumWidenVector128Traits 78.974  3319.378        3.986669
SumWidenVector256Traits 45.695  5736.869        6.890145

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

