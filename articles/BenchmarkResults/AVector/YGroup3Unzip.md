# Benchmark - YGroup3Unzip
([← Back](README.md))

See [Group](YGroup3Unzip_Group.md)

- `YGroup3Unzip[/_Bit128]`: De-Interleave 3-element groups into 3 vectors. It converts the 3-element groups AoS to SoA. It can also deinterleave packed RGB pixel data into R,G,B planar data (将3-元素组解交织为3个向量. 它能将3元素组的 数组结构体 转为 结构体数组. 它还能将 已打包的RGB像素数据, 解交织为 R,G,B 平面数据).
  Mnemonic: `x[i] =: element_ref(3*i, data0, data1, data2)`, `y[i] =: element_ref(3*i+1, data0, data1, data2)`, `z[i] =: element_ref(3*i+2, data0, data1, data2)`.
- `YGroup3UnzipX2[/_Bit128]`: De-Interleave 3-element groups into 3 vectors and process 2x data (将3-元素组解交织为3个向量, 且处理2倍数据).
  Mnemonic: `(x, y, z) = YGroup3Unzip(data0, data1, data2)`, `(xB, yB, zB) = YGroup3Unzip(data3, data4, data5)`.
- `YGroup3Zip[/_Bit128]`: Interleave 3 vectors into 3-element groups. It converts the 3-element groups SoA to AoS. It can also interleave R,G,B planar data into packed RGB pixel data (将3-元素组解交织为3个向量. 它能将3元素组的 结构体数组 转为 数组结构体. 它还能将 R,G,B 平面数据, 交织为 已打包的RGB像素数据).
  Mnemonic: `element_ref(i, data0, data1, data2) := (0==(i%3))?( x[i2] ):( (1==(i%3))?( y[i2] ):( z[i2] ) )`, `i2 := i/3`.
- `YGroup3ZipX2[/_Bit128]`: Interleave 3 vectors into 3-element groups and process 2x data (将3-元素组解交织为3个向量, 且处理2倍数据).
  Mnemonic: `(data0, data1, data2) = YGroup3Zip(x, y, z)`, `(data3, data4, data5) = YGroup3Zip(xB, yB, zB)`.

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

[YGroup3UnzipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# SumX2Base_Basic	114
SumBase_Basic	1027.323	255.172
SumBase_ByX2Zip	234.871	1116.121	4.373995
SumBase	229.827	1140.616	4.469989
SumTraits	233.660	1121.904	4.396656
SumX2Base_Basic	1084.009	241.828	0.947707
SumX2Base_X2	432.519	606.086	2.375207
SumX2Base_Zip	118.601	2210.311	8.662042
SumX2Base	120.858	2169.025	8.500247
SumX2Traits	117.555	2229.977	8.739112

[YGroup3UnzipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# SumX2Base_Basic	-24614
SumBase_Basic	1228.045	213.465
SumBase_ByX2Zip	354.439	739.602	3.464754
SumBase	354.741	738.972	3.461803
SumTraits	345.331	759.109	3.556137
SumX2Base_Basic	1233.957	212.442	0.995208
SumX2Base_X2	797.928	328.531	1.539042
SumX2Base_Zip	201.073	1303.725	6.107453
SumX2Base	197.514	1327.217	6.217506
SumX2Traits	198.512	1320.545	6.186250

[YGroup3UnzipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467755046
# SumX2Base_Basic	-467755046
SumBase_Basic	1408.407	186.128
SumBase_ByX2Zip	12494.250	20.981	0.112724
SumBase	1424.691	184.001	0.988570
SumTraits	1386.216	189.108	1.016008
SumX2Base_Basic	1587.243	165.157	0.887329
SumX2Base_X2	1638.027	160.036	0.859819
SumX2Base_Zip	6311.014	41.538	0.223166
SumX2Base	1688.878	155.218	0.833931
SumX2Traits	1635.825	160.252	0.860976

[YGroup3UnzipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572008452
# SumX2Base_Basic	5910372263572008452
SumBase_Basic	1913.799	136.976
SumBase	1932.473	135.652	0.990337
SumTraits	1931.739	135.704	0.990713
SumX2Base_Basic	2455.897	106.741	0.779267
SumX2Base_X2	2331.848	112.419	0.820722
SumX2Base	2420.110	108.319	0.790790
SumX2Traits	2395.296	109.441	0.798982

[YGroup3ZipBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	114
# SumX2Base_Basic	114
SumBase_Basic	817.807	320.545
SumBase_ByX2Unzip	872.687	300.387	0.937113
SumBase	858.983	305.180	0.952064
SumTraits	903.221	290.232	0.905434
SumX2Base_Basic	869.102	301.626	0.940979
SumX2Base_X2	871.427	300.821	0.938468
SumX2Base_Unzip	433.554	604.640	1.886288
SumX2Base	433.302	604.991	1.887382
SumX2Traits	435.266	602.261	1.878866

[YGroup3ZipBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-24614
# SumX2Base_Basic	-24614
SumBase_Basic	1028.204	254.953
SumBase_ByX2Unzip	923.999	283.706	1.112776
SumBase	977.950	268.055	1.051387
SumTraits	1010.039	259.538	1.017984
SumX2Base_Basic	1064.051	246.364	0.966310
SumX2Base_X2	1089.524	240.604	0.943718
SumX2Base_Unzip	547.974	478.388	1.876373
SumX2Base	1054.447	248.608	0.975112
SumX2Traits	1032.806	253.817	0.995544

[YGroup3ZipBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	-467755046
# SumX2Base_Basic	-467755046
SumBase_Basic	1400.814	187.137
SumBase_ByX2Unzip	2431.938	107.792	0.576007
SumBase	1431.673	183.103	0.978446
SumTraits	1417.616	184.919	0.988148
SumX2Base_Basic	1526.593	171.718	0.917608
SumX2Base_X2	1572.022	166.756	0.891091
SumX2Base_Unzip	1342.488	195.267	1.043447
SumX2Base	1589.246	164.949	0.881433
SumX2Traits	1583.069	165.592	0.884872

[YGroup3ZipBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumBase_Basic	5910372263572008452
# SumX2Base_Basic	5910372263572008452
SumBase_Basic	2167.963	120.917
SumBase	2191.539	119.616	0.989242
SumTraits	2204.021	118.939	0.983640
SumX2Base_Basic	2466.507	106.281	0.878961
SumX2Base_X2	2384.211	109.950	0.909300
SumX2Base	2451.738	106.922	0.884255
SumX2Traits	2490.048	105.277	0.870651

```

