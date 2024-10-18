# Benchmark - YGroup2Unzip
([← Back](README.md))

See [Group](YGroup2Unzip_Group.md)

- `YGroup2Unzip[/_Bit128]`: De-Interleave 2-element groups into 2 vectors. It converts the 2-element groups AoS to SoA (将2-元素组解交织为2个向量. 它能将2元素组的 数组结构体 转为 结构体数组).
  Mnemonic: `x[i] =: element_ref(2*i, data0, data1)`, `y[i] =: element_ref(2*i+1, data0, data1)`.
- `YGroup2Zip[/_Bit128]`: Interleave 2 vectors into 2-element groups. It converts the 2-element groups SoA to AoS (将2个向量交织为2-元素组. 它能将2元素组的 结构体数组 转为 数组结构体).
  Mnemonic: `element_ref(i, data0, data1) := (0==(i&1))?( x[i2] ):( y[i2] )`, `i2 := i/2`.

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

[YGroup2UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
SumBase_Basic	839.021	312.440
SumBase_NarrowMul	49.806	5263.307	16.845806
SumBase	49.566	5288.807	16.927422
SumTraits	49.874	5256.158	16.822925

[YGroup2UnzipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
SumBase_Basic	2931.527	89.422
SumBase	2979.229	87.991	0.983988
SumTraits	3280.241	79.916	0.893692
SumTraits_Int128	2088.867	125.496	1.403405

[YGroup2UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
SumBase_Basic	762.342	343.867
SumBase_NarrowMul	77.236	3394.043	9.870232
SumBase_NarrowMulOld	125.581	2087.448	6.070515
SumBase	77.332	3389.868	9.858088
SumTraits	78.549	3337.336	9.705320

[YGroup2UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468672550
SumBase_Basic	908.140	288.660
SumBase_NarrowMul	180.907	1449.058	5.019940
SumBase	176.971	1481.280	5.131566
SumTraits	178.601	1467.766	5.084753

[YGroup2UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
SumBase_Basic	1471.928	178.096
SumBase	1471.040	178.203	1.000604
SumTraits	1455.641	180.088	1.011189

[YGroup2ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
SumBase_Basic	699.710	374.647
SumBase_WidenMul	13.633	19227.974	51.322927
SumBase	13.772	19034.663	50.806944
SumTraits	13.647	19208.309	51.270437

[YGroup2ZipBenchmark_Int128(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
SumBase_Basic	2906.307	90.198
SumBase	2933.975	89.348	0.990570
SumTraits	3138.128	83.535	0.926128
SumTraits_Int128	2306.732	113.643	1.259924

[YGroup2ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
SumBase_Basic	763.187	343.486
SumBase_WidenMul	27.690	9467.105	27.561833
SumBase	27.436	9554.663	27.816742
SumTraits	29.164	8988.525	26.168528

[YGroup2ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-468672550
SumBase_Basic	1075.823	243.668
SumBase	1053.060	248.935	1.021616
SumTraits	1111.629	235.820	0.967790

[YGroup2ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263571615236
SumBase_Basic	1874.281	139.864
SumBase	1869.264	140.239	1.002684
SumTraits	1871.494	140.072	1.001489

```

