# Benchmark - YGroup2Transpose
([← Back](README.md))

See [Group](YGroup2Transpose_Group.md)

- `YGroup2Transpose`: Transpose a 2*2 matrix (对2*2矩阵进行转置).
  Mnemonic: `result0[i] := (0==(i&1))?( x[i&~1] ):( y[i&~1] )`, `result1[i] := (0==(i&1))?( x[(i&~1) + 1] ):( y[(i&~1) + 1] )`.

## X86

### AMD Ryzen 7 7840H
`AMD Ryzen 7 7840H w/ Radeon 780M Graphics`

#### .NET Framework

```
VectorTraits.Benchmarks.NetFw
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Windows\Microsoft.NET\Framework64\v4.0.30319\
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9232.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks/bin/Release/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	
Vectors.Instance:	VectorTraits256Base	// 
Vectors.BaseInstance:	VectorTraits256Base

[YGroup2TransposeBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
SumBase_Basic	181.880	1441.302
SumBase_ShiftByMul	30.933	8474.611	5.879829
SumBase	31.101	8428.903	5.848116
SumTraits	30.121	8703.029	6.038309

[YGroup2TransposeBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
SumBase_Basic	245.468	1067.937
SumBase_ShiftByMul	49.738	5270.541	4.935255
SumBase	48.411	5414.970	5.070496
SumTraits	49.579	5287.450	4.951088

[YGroup2TransposeBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468672550
SumBase_Basic	381.770	686.654
SumBase_ShiftByMul	271.608	965.156	1.405593
SumBase	378.347	692.867	1.009048
SumTraits	381.611	686.941	1.000418

[YGroup2TransposeBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
SumBase_Basic	663.608	395.028
SumBase	654.926	400.265	1.013257
SumTraits	654.973	400.236	1.013184

```

