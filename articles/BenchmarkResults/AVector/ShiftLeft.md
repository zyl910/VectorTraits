# Benchmark - ShiftLeft
([← Back](README.md))

See [Group](ShiftLeft_Group.md)

- `ShiftLeft[/_Args/_Core/_Const/_ConstCore/_Fast]`: Shifts each element of a vector left by the specified amount (将向量的每个元素左移指定量).
  Mnemonic: `rt[i] := value[i] << shiftAmount`, `shiftAmount &= (T.BitSize-1)`.

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
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9277.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	
Vectors.Instance:	VectorTraits256Base	// 
Vectors.BaseInstance:	VectorTraits256Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	246.829	1062.046
SumSLL_Basic	22.515	11643.212	10.963001
SumSLL_Base_Core	4.251	61659.541	58.057317
SumSLL_Multiply	22.811	11492.106	10.820723
SumSLLTraits	23.173	11312.499	10.651609
SumSLLTraits_Core	4.699	55791.675	52.532258
SumSLLConstTraits	19.550	13408.916	12.625551
SumSLLConstTraits_Core	4.612	56843.523	53.522656
SumSLLFast_Multiply	19.224	13636.349	12.839697
SumSLLFastTraits	19.127	13705.365	12.904681

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	242.341	1081.716
SumSLL_Basic	38.745	6765.848	6.254739
SumSLL_Base_Core	7.211	36352.213	33.606073
SumSLL_Base_Core_Element	38.621	6787.555	6.274805
SumSLL_Base_Core_Mov	43.089	6083.717	5.624137
SumSLL_Multiply	38.531	6803.424	6.289475
SumSLLTraits	38.823	6752.349	6.242259
SumSLLTraits_Core	7.549	34727.283	32.103894
SumSLLConstTraits	43.420	6037.367	5.581289
SumSLLConstTraits_Core	6.957	37678.435	34.832109
SumSLLFast_Multiply	37.867	6922.822	6.399854
SumSLLFastTraits	33.533	7817.443	7.226893

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	191.466	1369.140
SumSLL_Basic	72.832	3599.302	2.628877
SumSLL_Base_Core	16.673	15722.844	11.483734
SumSLL_Multiply	70.311	3728.371	2.723148
SumSLLTraits	69.675	3762.374	2.747983
SumSLLTraits_Core	15.132	17324.275	12.653396
SumSLLConstTraits	67.034	3910.600	2.856245
SumSLLConstTraits_Core	16.147	16235.154	11.857918
SumSLLFast_Multiply	65.989	3972.527	2.901475
SumSLLFastTraits	66.589	3936.720	2.875323

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
Check-SumSLL_Base_Bit32_Or	Check `SumSLL_Base_Bit32_Or` mismatch. 6667559474292588544!=-6625999546565534712
SumSLLScalar	187.955	1394.719
SumSLL_Base_Bit32_Or	1178.167	222.502	0.159532
SumSLL_Basic	543.680	482.166	0.345708
SumSLL_Base_Core	546.129	480.004	0.344158
SumSLLTraits	542.259	483.430	0.346615
SumSLLTraits_Core	546.406	479.761	0.343984
SumSLLConstTraits	514.426	509.585	0.365368
SumSLLConstTraits_Core	511.349	512.652	0.367567
SumSLLFastTraits	509.064	514.953	0.369217

```

#### .NET Core 2.1

```
VectorTraits.Benchmarks.NetCore
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.30\
RuntimeInformation.FrameworkDescription:	.NET Core 4.6.30411.01
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	
Vectors.Instance:	VectorTraits256Base	// 
Vectors.BaseInstance:	VectorTraits256Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	255.517	1025.936
SumSLL_Basic	23.971	10935.887	10.659426
SumSLL_Base_Core	4.860	53936.655	52.573128
SumSLL_Multiply	24.299	10788.387	10.515655
SumSLLTraits	24.463	10715.920	10.445020
SumSLLTraits_Core	5.025	52165.732	50.846974
SumSLLConstTraits	20.798	12604.412	12.285771
SumSLLConstTraits_Core	4.709	55673.528	54.266093
SumSLLFast_Multiply	23.016	11389.708	11.101774
SumSLLFastTraits	23.219	11290.294	11.004873

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	262.205	999.767
SumSLL_Basic	40.298	6505.171	6.506689
SumSLL_Base_Core	7.951	32968.237	32.975931
SumSLL_Base_Core_Element	47.120	5563.307	5.564605
SumSLL_Base_Core_Mov	42.686	6141.257	6.142690
SumSLL_Multiply	43.044	6090.190	6.091611
SumSLLTraits	42.377	6185.968	6.187412
SumSLLTraits_Core	8.333	31457.238	31.464579
SumSLLConstTraits	40.337	6498.819	6.500336
SumSLLConstTraits_Core	7.536	34784.616	34.792734
SumSLLFast_Multiply	35.171	7453.352	7.455091
SumSLLFastTraits	39.899	6570.141	6.571674

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	199.220	1315.852
SumSLL_Basic	75.807	3458.059	2.628000
SumSLL_Base_Core	18.094	14487.864	11.010253
SumSLL_Multiply	73.727	3555.588	2.702118
SumSLLTraits	74.654	3511.433	2.668562
SumSLLTraits_Core	16.947	15468.381	11.755411
SumSLLConstTraits	70.385	3724.412	2.830418
SumSLLConstTraits_Core	18.439	14216.598	10.804101
SumSLLFast_Multiply	71.270	3678.156	2.795266
SumSLLFastTraits	73.741	3554.928	2.701617

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
Check-SumSLL_Base_Bit32_Or	Check `SumSLL_Base_Bit32_Or` mismatch. 6667559474292588544!=-6625999546565534712
SumSLLScalar	204.615	1281.156
SumSLL_Base_Bit32_Or	965.999	271.371	0.211817
SumSLL_Basic	535.375	489.646	0.382191
SumSLL_Base_Core	540.466	485.033	0.378590
SumSLLTraits	530.296	494.335	0.385851
SumSLLTraits_Core	536.272	488.827	0.381551
SumSLLConstTraits	499.137	525.195	0.409938
SumSLLConstTraits_Core	496.127	528.381	0.412425
SumSLLFastTraits	501.785	522.423	0.407774

```

#### .NET Core 3.1

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	3.1.32
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\3.1.32\
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	203.549	1287.865
SumSLL_Basic	12.602	20802.587	16.152769
SumSLL_Base_Core	4.362	60092.249	46.660359
SumSLL_Multiply	12.703	20636.926	16.024136
SumSLL_Avx2	9.076	28882.901	22.426961
SumSLLTraits	9.071	28897.868	22.438583
SumSLLTraits_Core	4.894	53563.421	41.590863
SumSLLConstTraits	6.735	38925.388	30.224740
SumSLLConstTraits_Core	4.887	53642.484	41.652254
SumSLL128Traits	18.391	14253.557	11.067585
SumSLL128Traits_Core	7.876	33281.936	25.842719
SumSLL128ConstTraits	15.628	16773.704	13.024426
SumSLL128ConstTraits_Core	7.171	36556.781	28.385567
SumSLLFast_Multiply	7.262	36098.264	28.029538
SumSLLFast_Avx2	7.556	34694.531	26.939569
SumSLLFastTraits	7.556	34692.453	26.937955

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	207.807	1261.475
SumSLL_Basic	17.289	15162.663	12.019784
SumSLL_Base_Core	7.204	36389.439	28.846728
SumSLL_Base_Core_Element	18.776	13961.345	11.067473
SumSLL_Base_Core_Mov	17.937	14614.455	11.585208
SumSLL_Multiply	17.012	15409.469	12.215433
SumSLL_Avx2	9.952	26340.325	20.880569
SumSLLTraits	10.394	25221.856	19.993934
SumSLLTraits_Core	8.243	31800.310	25.208822
SumSLLConstTraits	9.435	27783.526	22.024627
SumSLLConstTraits_Core	8.035	32625.543	25.863003
SumSLL128Traits	18.193	14409.004	11.422342
SumSLL128Traits_Core	13.672	19173.703	15.199426
SumSLL128ConstTraits	18.440	14215.906	11.269269
SumSLL128ConstTraits_Core	13.395	19570.311	15.513826
SumSLLFast_Multiply	11.047	23729.619	18.811004
SumSLLFast_Avx2	9.101	28804.782	22.834200
SumSLLFastTraits	9.929	26401.350	20.928945

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	173.068	1514.690
SumSLL_Basic	24.984	10492.675	6.927275
SumSLL_Base_Core	16.493	15894.086	10.493293
SumSLL_Multiply	24.624	10645.983	7.028489
SumSLL_Avx2	20.524	12772.413	8.432361
SumSLLTraits	19.646	13343.304	8.809264
SumSLLTraits_Core	17.970	14587.937	9.630972
SumSLLConstTraits	20.729	12646.545	8.349263
SumSLLConstTraits_Core	17.153	15282.565	10.089566
SumSLL128Traits	38.751	6764.874	4.466177
SumSLL128Traits_Core	27.071	9683.426	6.393008
SumSLL128ConstTraits	36.709	7141.143	4.714591
SumSLL128ConstTraits_Core	25.326	10350.937	6.833700
SumSLLFast_Multiply	20.379	12863.521	8.492511
SumSLLFast_Avx2	19.197	13655.177	9.015163
SumSLLFastTraits	20.089	13048.871	8.614879

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
Check-SumSLL_Base_Bit32_Or	Check `SumSLL_Base_Bit32_Or` mismatch. 6667559474292588544!=-6625999546565534712
SumSLLScalar	172.697	1517.938
SumSLL_Base_Bit32_Or	1184.204	221.367	0.145834
SumSLL_Basic	503.303	520.847	0.343128
SumSLL_Base_Core	500.117	524.166	0.345314
SumSLL_Avx2	39.453	6644.472	4.377301
SumSLLTraits	39.258	6677.544	4.399089
SumSLLTraits_Core	33.788	7758.515	5.111219
SumSLLConstTraits	37.256	7036.223	4.635382
SumSLLConstTraits_Core	31.852	8229.954	5.421798
SumSLL128Traits	70.767	3704.309	2.440356
SumSLL128Traits_Core	54.345	4823.659	3.177770
SumSLL128ConstTraits	67.663	3874.232	2.552299
SumSLL128ConstTraits_Core	52.825	4962.514	3.269247
SumSLLFast_Avx2	34.248	7654.225	5.042515
SumSLLFastTraits	38.878	6742.773	4.442061

```

#### .NET 5.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	5.0.17
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\5.0.17\
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	207.155	1265.446
SumSLL_Basic	13.629	19234.592	15.199850
SumSLL_Base_Core	4.129	63482.532	50.166128
SumSLL_Multiply	13.860	18914.019	14.946522
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	9.391	27914.288	22.058852
SumSLLTraits	9.162	28611.234	22.609603
SumSLLTraits_Core	3.818	68653.359	54.252298
SumSLLConstTraits	4.532	57842.081	45.708845
SumSLLConstTraits_Core	4.183	62674.397	49.527512
SumSLL128Traits	17.339	15119.089	11.947636
SumSLL128Traits_Core	7.481	35042.788	27.692043
SumSLL128ConstTraits	8.182	32040.418	25.319465
SumSLL128ConstTraits_Core	7.717	33968.628	26.843204
SumSLLFast_Multiply	7.211	36353.344	28.727690
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	5.251	49925.840	39.453153
SumSLLFastTraits	4.978	52665.291	41.617964

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	218.798	1198.111
SumSLL_Basic	17.732	14783.440	12.338959
SumSLL_Base_Core	7.734	33892.853	28.288579
SumSLL_Base_Core_Element	18.858	13900.931	11.602374
SumSLL_Base_Core_Mov	19.316	13571.102	11.327084
SumSLL_Multiply	17.090	15339.138	12.802770
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	9.737	26922.366	22.470681
SumSLLTraits	9.936	26382.708	22.020257
SumSLLTraits_Core	8.133	32231.553	26.901980
SumSLLConstTraits	6.971	37605.559	31.387379
SumSLLConstTraits_Core	7.780	33694.338	28.122889
SumSLL128Traits	19.365	13536.894	11.298532
SumSLL128Traits_Core	13.743	19075.001	15.920898
SumSLL128ConstTraits	13.668	19180.081	16.008603
SumSLL128ConstTraits_Core	14.382	18227.336	15.213397
SumSLLFast_Multiply	11.630	22539.659	18.812666
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	7.963	32919.215	27.475935
SumSLLFastTraits	7.230	36259.989	30.264303

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	172.291	1521.516
SumSLL_Basic	25.794	10162.788	6.679382
SumSLL_Base_Core	17.097	15332.775	10.077299
SumSLL_Multiply	26.084	10050.149	6.605351
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	20.919	12531.146	8.235960
SumSLLTraits	20.311	12906.293	8.482521
SumSLLTraits_Core	15.059	17407.823	11.441103
SumSLLConstTraits	17.144	15290.340	10.049410
SumSLLConstTraits_Core	16.294	16088.400	10.573926
SumSLL128Traits	38.643	6783.710	4.458519
SumSLL128Traits_Core	25.210	10398.315	6.834180
SumSLL128ConstTraits	28.579	9172.565	6.028569
SumSLL128ConstTraits_Core	25.603	10238.704	6.729277
SumSLLFast_Multiply	20.971	12500.225	8.215637
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	14.568	17993.939	11.826321
SumSLLFastTraits	17.441	15030.407	9.878571

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
Check-SumSLL_Base_Bit32_Or	Check `SumSLL_Base_Bit32_Or` mismatch. 6667559474292588544!=-6625999546565534712
SumSLLScalar	181.898	1441.160
SumSLL_Base_Bit32_Or	929.049	282.164	0.195789
SumSLL_Basic	534.987	490.001	0.340004
SumSLL_Base_Core	519.815	504.302	0.349928
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	39.126	6700.057	4.649073
SumSLLTraits	39.896	6570.711	4.559322
SumSLLTraits_Core	30.747	8525.784	5.915920
SumSLLConstTraits	38.624	6787.101	4.709472
SumSLLConstTraits_Core	29.969	8747.125	6.069505
SumSLL128Traits	71.368	3673.118	2.548724
SumSLL128Traits_Core	47.262	5546.637	3.848732
SumSLL128ConstTraits	68.860	3806.896	2.641550
SumSLL128ConstTraits_Core	47.880	5475.031	3.799046
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	35.461	7392.454	5.129518
SumSLLFastTraits	33.701	7778.500	5.397390

```

#### .NET 6.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	6.0.33
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.33\
RuntimeInformation.FrameworkDescription:	.NET 6.0.33
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.33/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	181.342	1445.575
SumSLL_Basic	11.703	22398.946	15.494837
SumSLL_Base_Core	4.305	60892.242	42.123204
SumSLL_Multiply	11.617	22565.945	15.610362
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	9.045	28983.705	20.049952
SumSLLTraits	9.290	28219.205	19.521097
SumSLLTraits_Core	4.375	59916.622	41.448303
SumSLLConstTraits	4.591	57095.294	39.496603
SumSLLConstTraits_Core	3.984	65797.708	45.516640
SumSLL128Traits	18.382	14260.672	9.865053
SumSLL128Traits_Core	7.721	33953.751	23.488063
SumSLL128ConstTraits	8.140	32204.083	22.277701
SumSLL128ConstTraits_Core	7.610	34448.128	23.830056
SumSLLFast_Multiply	7.610	34446.871	23.829186
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	4.024	65149.040	45.067914
SumSLLFastTraits	4.245	61758.429	42.722403

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	215.089	1218.767
SumSLL_Basic	12.721	20607.926	16.908830
SumSLL_Base_Core	8.295	31602.264	25.929698
SumSLL_Base_Core_Element	15.324	17106.875	14.036213
SumSLL_Base_Core_Mov	14.802	17710.273	14.531302
SumSLL_Multiply	12.089	21684.792	17.792400
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	9.884	26522.365	21.761634
SumSLLTraits	9.664	27125.955	22.256881
SumSLLTraits_Core	7.345	35687.996	29.282046
SumSLLConstTraits	6.441	40699.914	33.394331
SumSLLConstTraits_Core	6.550	40019.325	32.835907
SumSLL128Traits	20.003	13105.486	10.753068
SumSLL128Traits_Core	14.469	18118.050	14.865883
SumSLL128ConstTraits	12.560	20871.504	17.125096
SumSLL128ConstTraits_Core	12.326	21267.812	17.450267
SumSLLFast_Multiply	9.705	27011.807	22.163222
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	8.429	31101.834	25.519094
SumSLLFastTraits	8.151	32159.413	26.386839

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	114.740	2284.670
SumSLL_Basic	24.640	10639.082	4.656726
SumSLL_Base_Core	16.868	15540.933	6.802265
SumSLL_Multiply	23.670	11075.058	4.847552
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	21.268	12325.782	5.394994
SumSLLTraits	20.704	12661.423	5.541904
SumSLLTraits_Core	14.656	17886.651	7.828986
SumSLLConstTraits	14.772	17745.992	7.767420
SumSLLConstTraits_Core	14.612	17940.330	7.852481
SumSLL128Traits	38.092	6881.927	3.012219
SumSLL128Traits_Core	24.306	10784.975	4.720583
SumSLL128ConstTraits	26.048	10063.971	4.404999
SumSLL128ConstTraits_Core	26.857	9760.642	4.272233
SumSLLFast_Multiply	21.617	12126.683	5.307849
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	18.478	14186.433	6.209401
SumSLLFastTraits	18.434	14220.520	6.224321

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
Check-SumSLL_Base_Bit32_Or	Check `SumSLL_Base_Bit32_Or` mismatch. 6667559474292588544!=-6625999546565534712
SumSLLScalar	115.455	2270.521
SumSLL_Base_Bit32_Or	1124.635	233.093	0.102660
SumSLL_Basic	495.564	528.981	0.232978
SumSLL_Base_Core	497.565	526.853	0.232041
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	39.756	6593.742	2.904065
SumSLLTraits	39.509	6635.070	2.922267
SumSLLTraits_Core	30.495	8596.290	3.786042
SumSLLConstTraits	31.788	8246.601	3.632030
SumSLLConstTraits_Core	30.092	8711.523	3.836794
SumSLL128Traits	75.776	3459.447	1.523636
SumSLL128Traits_Core	49.122	5336.593	2.350382
SumSLL128ConstTraits	49.993	5243.601	2.309426
SumSLL128ConstTraits_Core	53.820	4870.745	2.145210
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	33.888	7735.632	3.406985
SumSLLFastTraits	35.047	7479.740	3.294283

```

#### .NET 7.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	7.0.20
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.20\
RuntimeInformation.FrameworkDescription:	.NET 7.0.20
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	True
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.20/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	185.037	1416.712
SumSLLNetBcl	194.941	1344.738	0.949197
SumSLLNetBcl_Const	204.496	1281.901	0.904842
SumSLL_Basic	11.012	23804.552	16.802680
SumSLL_Base_Core	3.906	67119.054	47.376651
SumSLL_Multiply	10.855	24149.109	17.045888
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	7.347	35680.087	25.185144
SumSLLTraits	7.695	34068.741	24.047760
SumSLLTraits_Core	3.863	67868.291	47.905507
SumSLLConstTraits	4.227	62012.692	43.772275
SumSLLConstTraits_Core	5.153	50869.840	35.906982
SumSLL128Bcl	224.368	1168.368	0.824704
SumSLL128Traits	15.278	17158.675	12.111621
SumSLL128Traits_Core	7.274	36040.111	25.439270
SumSLL128ConstTraits	7.743	33855.214	23.897039
SumSLL128ConstTraits_Core	9.463	27702.588	19.554147
SumSLLFast_Multiply	5.695	46028.776	32.489869
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	3.924	66810.262	47.158687
SumSLLFastTraits	3.976	65939.422	46.543996

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	191.941	1365.754
SumSLLNetBcl	8.189	32011.646	23.438813
SumSLLNetBcl_Const	6.558	39975.924	29.270229
SumSLL_Basic	7.946	32990.518	24.155539
SumSLL_Base_Core	8.033	32634.035	23.894524
SumSLL_Base_Core_Element	12.920	20289.773	14.856100
SumSLL_Base_Core_Mov	10.292	25471.628	18.650235
SumSLL_Multiply	12.735	20584.670	15.072022
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	9.837	26648.440	19.511893
SumSLLTraits	8.037	32617.944	23.882743
SumSLLTraits_Core	6.944	37750.305	27.640638
SumSLLConstTraits	6.620	39598.663	28.993999
SumSLLConstTraits_Core	6.657	39380.404	28.834191
SumSLL128Bcl	17.766	14755.543	10.803956
SumSLL128Traits	17.554	14933.950	10.934585
SumSLL128Traits_Core	13.952	18789.506	13.757609
SumSLL128ConstTraits	12.583	20833.161	15.253966
SumSLL128ConstTraits_Core	12.618	20775.978	15.212097
SumSLLFast_Multiply	9.635	27206.311	19.920364
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	8.809	29758.444	21.789027
SumSLLFastTraits	8.026	32659.908	23.913468

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	105.516	2484.407
SumSLLNetBcl	15.089	17373.567	6.993043
SumSLLNetBcl_Const	14.590	17967.080	7.231938
SumSLL_Basic	14.652	17891.042	7.201332
SumSLL_Base_Core	15.112	17346.608	6.982192
SumSLL_Multiply	23.216	11291.361	4.544891
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	20.587	12733.163	5.125232
SumSLLTraits	15.171	17279.760	6.955284
SumSLLTraits_Core	14.521	18052.162	7.266184
SumSLLConstTraits	14.703	17829.078	7.176391
SumSLLConstTraits_Core	16.424	15961.166	6.424537
SumSLL128Bcl	28.195	9297.378	3.742292
SumSLL128Traits	28.545	9183.644	3.696513
SumSLL128Traits_Core	25.757	10177.435	4.096524
SumSLL128ConstTraits	27.998	9363.116	3.768752
SumSLL128ConstTraits_Core	28.344	9248.793	3.722736
SumSLLFast_Multiply	19.342	13553.399	5.455385
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	19.079	13739.683	5.530366
SumSLLFastTraits	14.917	17573.094	7.073354

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
Check-SumSLL_Base_Bit32_Or	Check `SumSLL_Base_Bit32_Or` mismatch. 6667559474292588544!=-6625999546565534712
SumSLLScalar	104.499	2508.577
SumSLLNetBcl	34.822	7528.184	3.000978
SumSLLNetBcl_Const	29.982	8743.504	3.485444
SumSLL_Base_Bit32_Or	1084.915	241.626	0.096320
SumSLL_Basic	32.155	8152.561	3.249875
SumSLL_Base_Core	32.822	7986.772	3.183786
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	40.048	6545.775	2.609358
SumSLLTraits	38.038	6891.705	2.747257
SumSLLTraits_Core	31.706	8267.855	3.295835
SumSLLConstTraits	31.756	8254.880	3.290663
SumSLLConstTraits_Core	29.548	8871.948	3.536646
SumSLL128Bcl	70.098	3739.678	1.490757
SumSLL128Traits	74.183	3533.757	1.408670
SumSLL128Traits_Core	47.652	5501.204	2.192958
SumSLL128ConstTraits	47.324	5539.339	2.208160
SumSLL128ConstTraits_Core	49.852	5258.458	2.096192
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	35.928	7296.283	2.908535
SumSLLFastTraits	35.686	7345.949	2.928333

```

#### .NET 8.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	16
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.22631.0
Environment.Version:	8.0.8
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\8.0.8\
RuntimeInformation.FrameworkDescription:	.NET 8.0.8
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.22631
RuntimeInformation.RuntimeIdentifier:	win-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	True
Vector512.IsHardwareAccelerated:	True
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/8.0.8/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 8.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 8.0
VectorTraitsGlobal.InitCheckSum:	-2122844161	# 0x8177F7FF
VectorEnvironment.CpuModelName:	AMD Ryzen 7 7840H w/ Radeon 780M Graphics
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Avx512BW, Avx512CD, Avx512DQ, Avx512F, Avx512Vbmi, Avx512VL, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2, Avx512VL
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2, Avx512VL
Vector512s.Instance:	WVectorTraits512Avx512	// Avx512BW, Avx512DQ, Avx512F, Avx512Vbmi, Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2, Avx512VL
Vectors.BaseInstance:	VectorTraits256Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	154.810	1693.330
SumSLLNetBcl	236.219	1109.752	0.655367
SumSLLNetBcl_Const	225.136	1164.382	0.687629
SumSLL_Basic	11.416	22962.091	13.560318
SumSLL_Base_Core	4.324	60623.899	35.801588
SumSLL_Multiply	10.733	24424.065	14.423690
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	4.261	61527.194	36.335031
SumSLLTraits	4.562	57456.802	33.931252
SumSLLTraits_Core	3.500	74889.177	44.225982
SumSLLConstTraits	4.179	62729.225	37.044894
SumSLLConstTraits_Core	3.549	73873.979	43.626455
SumSLL128Bcl	341.623	767.349	0.453160
SumSLL128Traits	8.209	31932.668	18.857914
SumSLL128Traits_Core	6.140	42693.321	25.212643
SumSLL128ConstTraits	7.544	34750.445	20.521958
SumSLL128ConstTraits_Core	6.718	39021.286	23.044114
SumSLL512Bcl	586.223	447.174	0.264080
SumSLL512Traits	3.168	82740.101	48.862365
SumSLLFast_Multiply	5.374	48779.211	28.806680
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	3.990	65701.450	38.800148
SumSLLFastTraits	3.508	74725.136	44.129108

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	169.421	1547.294
SumSLLNetBcl	7.529	34816.284	22.501405
SumSLLNetBcl_Const	7.015	37368.541	24.150903
SumSLL_Basic	7.374	35549.796	22.975467
SumSLL_Base_Core	7.139	36720.450	23.732048
SumSLL_Base_Core_Element	7.427	35297.465	22.812388
SumSLL_Base_Core_Mov	9.529	27509.884	17.779354
SumSLL_Multiply	10.608	24711.957	15.971083
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	8.530	30733.138	19.862510
SumSLLTraits	7.192	36448.716	23.556429
SumSLLTraits_Core	8.530	30731.745	19.861610
SumSLLConstTraits	7.233	36242.630	23.423238
SumSLLConstTraits_Core	7.101	36914.775	23.857638
SumSLL128Bcl	13.029	20119.281	13.002884
SumSLL128Traits	12.984	20190.435	13.048870
SumSLL128Traits_Core	16.180	16201.324	10.470749
SumSLL128ConstTraits	13.193	19870.013	12.841785
SumSLL128ConstTraits_Core	13.177	19894.652	12.857709
SumSLL512Bcl	6.215	42180.891	27.261075
SumSLL512Traits	5.863	44709.720	28.895431
SumSLLFast_Multiply	10.300	25450.655	16.448496
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	7.390	35474.862	22.927038
SumSLLFastTraits	6.924	37859.431	24.468160

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	108.802	2409.358
SumSLLNetBcl	16.431	15954.004	6.621681
SumSLLNetBcl_Const	16.401	15983.409	6.633886
SumSLL_Basic	16.334	16049.281	6.661226
SumSLL_Base_Core	16.241	16141.071	6.699323
SumSLL_Multiply	16.542	15847.461	6.577461
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	20.168	12998.146	5.394858
SumSLLTraits	16.501	15886.410	6.593627
SumSLLTraits_Core	18.557	14126.571	5.863209
SumSLLConstTraits	16.393	15991.615	6.637292
SumSLLConstTraits_Core	16.005	16378.506	6.797870
SumSLL128Bcl	27.107	9670.786	4.013843
SumSLL128Traits	28.437	9218.264	3.826025
SumSLL128Traits_Core	26.350	9948.523	4.129117
SumSLL128ConstTraits	27.487	9536.884	3.958267
SumSLL128ConstTraits_Core	25.688	10204.864	4.235511
SumSLL512Bcl	14.053	18654.603	7.742560
SumSLL512Traits	15.009	17465.537	7.249040
SumSLLFast_Multiply	16.400	15983.924	6.634100
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	16.411	15974.107	6.630025
SumSLLFastTraits	16.401	15983.099	6.633757

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
Check-SumSLL_Base_Bit32_Or	Check `SumSLL_Base_Bit32_Or` mismatch. 6667559474292588544!=-6625999546565534712
SumSLLScalar	108.254	2421.558
SumSLLNetBcl	30.729	8530.835	3.522871
SumSLLNetBcl_Const	30.942	8471.981	3.498567
SumSLL_Base_Bit32_Or	1327.097	197.532	0.081572
SumSLL_Basic	30.083	8713.895	3.598467
SumSLL_Base_Core	28.958	9052.444	3.738273
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	34.592	7578.221	3.129482
SumSLLTraits	35.096	7469.236	3.084476
SumSLLTraits_Core	33.271	7879.060	3.253715
SumSLLConstTraits	30.746	8526.022	3.520884
SumSLLConstTraits_Core	30.315	8647.339	3.570982
SumSLL128Bcl	52.176	5024.195	2.074778
SumSLL128Traits	59.399	4413.242	1.822481
SumSLL128Traits_Core	52.227	5019.317	2.072764
SumSLL128ConstTraits	50.883	5151.891	2.127511
SumSLL128ConstTraits_Core	50.805	5159.790	2.130773
SumSLL512Bcl	27.470	9543.093	3.940890
SumSLL512Traits	32.817	7988.092	3.298741
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	30.310	8648.740	3.571561
SumSLLFastTraits	30.211	8677.244	3.583332

```

### Intel Core i5-8250U
`Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz`

#### .NET Framework 
``` 
VectorTraits.Benchmarks.NetFw
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Windows\Microsoft.NET\Framework64\v4.0.30319\
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.9195.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///E:/910Soft/MyCode/VectorTraits_test/RunBenchmarks_All/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	
Vectors.Instance:	VectorTraits256Base	// 
Vectors.BaseInstance:	VectorTraits256Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	304.879	859.830
SumSLL_Basic	29.404	8915.278	10.368654
SumSLL_Base_Core	6.602	39706.505	46.179494
SumSLL_Multiply	29.521	8879.961	10.327579
SumSLLTraits	29.460	8898.294	10.348901
SumSLLTraits_Core	7.396	35443.918	41.222016
SumSLLConstTraits	22.996	11399.508	13.257866
SumSLLConstTraits_Core	6.605	39686.234	46.155918
SumSLLFast_Multiply	22.321	11744.320	13.658890
SumSLLFastTraits	22.574	11612.495	13.505574

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	311.522	841.494
SumSLL_Basic	48.569	5397.386	6.414050
SumSLL_Base_Core	11.256	23288.822	27.675558
SumSLL_Base_Core_Element	49.687	5275.958	6.269749
SumSLL_Base_Core_Mov	51.005	5139.615	6.107725
SumSLL_Multiply	47.004	5577.054	6.627560
SumSLLTraits	48.037	5457.114	6.485028
SumSLLTraits_Core	11.957	21924.622	26.054393
SumSLLConstTraits	42.539	6162.425	7.323193
SumSLLConstTraits_Core	12.088	21686.822	25.771800
SumSLLFast_Multiply	42.371	6186.912	7.352292
SumSLLFastTraits	42.389	6184.293	7.349181

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	311.584	841.328
SumSLL_Basic	93.532	2802.717	3.331302
SumSLL_Base_Core	28.870	9080.301	10.792825
SumSLL_Multiply	92.824	2824.083	3.356698
SumSLLTraits	93.007	2818.536	3.350106
SumSLLTraits_Core	28.692	9136.424	10.859532
SumSLLConstTraits	84.313	3109.161	3.695542
SumSLLConstTraits_Core	28.470	9207.823	10.944397
SumSLLFast_Multiply	83.933	3123.269	3.712311
SumSLLFastTraits	82.457	3179.152	3.778733

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	314.890	832.495
SumSLL_Basic	580.294	451.744	0.542639
SumSLL_Base_Core	572.165	458.161	0.550347
SumSLLTraits	581.367	450.909	0.541636
SumSLLTraits_Core	602.887	434.814	0.522303
SumSLLConstTraits	523.344	500.901	0.601687
SumSLLConstTraits_Core	522.427	501.781	0.602744
SumSLLFastTraits	539.336	486.050	0.583847

``` 

#### .NET Core 2.1 
``` 
VectorTraits.Benchmarks.NetCore
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\2.1.30\
RuntimeInformation.FrameworkDescription:	.NET Core 4.6.30411.01
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
VectorTraitsGlobal.InitCheckSum:	-25396097	# 0xFE7C7C7F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	
Vectors.Instance:	VectorTraits256Base	// 
Vectors.BaseInstance:	VectorTraits256Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	304.933	859.678
SumSLL_Basic	29.296	8948.021	10.408578
SumSLL_Base_Core	7.588	34547.354	40.186410
SumSLL_Multiply	29.579	8862.589	10.309202
SumSLLTraits	29.393	8918.435	10.374163
SumSLLTraits_Core	6.608	39670.570	46.145872
SumSLLConstTraits	23.005	11394.920	13.254877
SumSLLConstTraits_Core	7.450	35187.799	40.931393
SumSLLFast_Multiply	22.363	11722.099	13.635460
SumSLLFastTraits	22.394	11706.056	13.616799

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	310.930	843.096
SumSLL_Basic	46.542	5632.457	6.680683
SumSLL_Base_Core	11.597	22603.626	26.810262
SumSLL_Base_Core_Element	50.830	5157.314	6.117113
SumSLL_Base_Core_Mov	51.729	5067.630	6.010739
SumSLL_Multiply	46.557	5630.545	6.678415
SumSLLTraits	46.461	5642.180	6.692215
SumSLLTraits_Core	11.612	22574.392	26.775588
SumSLLConstTraits	41.149	6370.666	7.556276
SumSLLConstTraits_Core	12.055	21746.218	25.793287
SumSLLFast_Multiply	40.820	6421.950	7.617104
SumSLLFastTraits	41.548	6309.359	7.483560

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	311.828	840.669
SumSLL_Basic	88.877	2949.499	3.508514
SumSLL_Base_Core	29.773	8804.870	10.473647
SumSLL_Multiply	88.760	2953.408	3.513165
SumSLLTraits	89.007	2945.223	3.503428
SumSLLTraits_Core	27.071	9683.714	11.519058
SumSLLConstTraits	80.198	3268.712	3.888227
SumSLLConstTraits_Core	26.840	9766.888	11.617995
SumSLLFast_Multiply	80.397	3260.600	3.878578
SumSLLFastTraits	79.364	3303.057	3.929081

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	315.951	829.698
SumSLL_Basic	581.999	450.420	0.542872
SumSLL_Base_Core	555.365	472.021	0.568907
SumSLLTraits	555.418	471.976	0.568853
SumSLLTraits_Core	556.600	470.974	0.567645
SumSLLConstTraits	477.458	549.041	0.661736
SumSLLConstTraits_Core	477.611	548.865	0.661524
SumSLLFastTraits	520.414	503.722	0.607116

``` 

#### .NET Core 3.1 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	3.1.32
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\3.1.32\
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	233.978	1120.378
SumSLL_Basic	16.480	15906.723	14.197643
SumSLL_Base_Core	5.741	45658.298	40.752595
SumSLL_Multiply	16.434	15951.707	14.237794
SumSLL_Avx2	11.691	22421.910	20.012814
SumSLLTraits	11.653	22496.421	20.079319
SumSLLTraits_Core	6.212	42201.168	37.666912
SumSLLConstTraits	9.806	26732.458	23.860220
SumSLLConstTraits_Core	6.206	42237.347	37.699204
SumSLL128Traits	24.461	10716.849	9.565389
SumSLL128Traits_Core	11.372	23050.798	20.574132
SumSLL128ConstTraits	19.575	13391.678	11.952824
SumSLL128ConstTraits_Core	11.613	22572.982	20.147654
SumSLLFast_Multiply	9.785	26791.041	23.912508
SumSLLFast_Avx2	9.767	26841.018	23.957116
SumSLLFastTraits	9.803	26739.956	23.866912

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	219.723	1193.064
SumSLL_Basic	21.412	12242.743	10.261594
SumSLL_Base_Core	12.015	21818.346	18.287652
SumSLL_Base_Core_Element	23.087	11354.740	9.517290
SumSLL_Base_Core_Mov	23.300	11250.575	9.429981
SumSLL_Multiply	21.318	12296.786	10.306892
SumSLL_Avx2	14.478	18106.898	15.176798
SumSLLTraits	14.488	18094.357	15.166287
SumSLLTraits_Core	13.136	19955.908	16.726597
SumSLLConstTraits	14.086	18610.286	15.598727
SumSLLConstTraits_Core	11.666	22470.309	18.834112
SumSLL128Traits	25.360	10336.762	8.664043
SumSLL128Traits_Core	22.487	11657.662	9.771193
SumSLL128ConstTraits	25.357	10337.941	8.665032
SumSLL128ConstTraits_Core	22.399	11703.474	9.809591
SumSLLFast_Multiply	16.040	16343.287	13.698579
SumSLLFast_Avx2	13.032	20115.209	16.860120
SumSLLFastTraits	13.095	20019.329	16.779756

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	194.032	1351.033
SumSLL_Basic	40.891	6410.821	4.745125
SumSLL_Base_Core	26.806	9779.287	7.238376
SumSLL_Multiply	40.287	6506.876	4.816222
SumSLL_Avx2	29.563	8867.412	6.563430
SumSLLTraits	28.911	9067.419	6.711470
SumSLLTraits_Core	23.755	11035.304	8.168048
SumSLLConstTraits	29.567	8866.244	6.562565
SumSLLConstTraits_Core	23.179	11309.484	8.370988
SumSLL128Traits	50.188	5223.277	3.866135
SumSLL128Traits_Core	42.734	6134.347	4.540485
SumSLL128ConstTraits	50.553	5185.557	3.838215
SumSLL128ConstTraits_Core	43.025	6092.871	4.509786
SumSLLFast_Multiply	30.129	8700.854	6.440148
SumSLLFast_Avx2	26.131	10031.817	7.425292
SumSLLFastTraits	26.120	10036.247	7.428571

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	194.020	1351.115
SumSLL_Basic	536.292	488.809	0.361782
SumSLL_Base_Core	535.876	489.188	0.362062
SumSLL_Avx2	58.286	4497.519	3.328746
SumSLLTraits	57.704	4542.925	3.362352
SumSLLTraits_Core	43.720	5996.036	4.437842
SumSLLConstTraits	56.083	4674.201	3.459513
SumSLLConstTraits_Core	44.729	5860.712	4.337684
SumSLL128Traits	101.276	2588.404	1.915754
SumSLL128Traits_Core	85.540	3064.588	2.268191
SumSLL128ConstTraits	101.015	2595.091	1.920702
SumSLL128ConstTraits_Core	78.660	3332.640	2.466584
SumSLLFast_Avx2	52.112	5030.382	3.723133
SumSLLFastTraits	52.167	5025.083	3.719211

``` 

#### .NET 5.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	5.0.17
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\5.0.17\
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	232.532	1127.346
SumSLL_Basic	17.109	15322.318	13.591494
SumSLL_Base_Core	6.533	40123.498	35.591109
SumSLL_Multiply	17.183	15255.982	13.532652
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	11.769	22273.765	19.757699
SumSLLTraits	13.145	19942.064	17.689390
SumSLLTraits_Core	8.046	32582.667	28.902098
SumSLLConstTraits	8.574	30573.583	27.119962
SumSLLConstTraits_Core	7.711	33994.636	30.154570
SumSLL128Traits	27.827	9420.328	8.356199
SumSLL128Traits_Core	12.444	21066.098	18.686452
SumSLL128ConstTraits	11.799	22217.394	19.707696
SumSLL128ConstTraits_Core	11.384	23027.578	20.426361
SumSLLFast_Multiply	9.805	26735.628	23.715547
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	7.478	35053.310	31.093655
SumSLLFastTraits	7.501	34949.253	31.001352

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	220.281	1190.046
SumSLL_Basic	21.271	12324.011	10.355911
SumSLL_Base_Core	11.361	23074.695	19.389749
SumSLL_Base_Core_Element	22.748	11523.799	9.683490
SumSLL_Base_Core_Mov	23.702	11060.124	9.293862
SumSLL_Multiply	26.580	9862.494	8.287489
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	14.963	17519.480	14.721681
SumSLLTraits	14.969	17511.952	14.715355
SumSLLTraits_Core	17.118	15314.070	12.868468
SumSLLConstTraits	13.411	19546.284	16.424812
SumSLLConstTraits_Core	13.050	20086.968	16.879150
SumSLL128Traits	25.400	10320.694	8.672515
SumSLL128Traits_Core	22.450	11676.835	9.812086
SumSLL128ConstTraits	22.488	11656.995	9.795414
SumSLL128ConstTraits_Core	22.490	11655.909	9.794501
SumSLLFast_Multiply	15.391	17032.182	14.312203
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	11.928	21976.277	18.466743
SumSLLFastTraits	12.678	20676.579	17.374603

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	193.821	1352.504
SumSLL_Basic	43.738	5993.531	4.431433
SumSLL_Base_Core	29.375	8924.169	6.598257
SumSLL_Multiply	41.490	6318.309	4.671564
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	29.738	8815.073	6.517595
SumSLLTraits	31.053	8441.793	6.241603
SumSLLTraits_Core	26.047	10064.362	7.441281
SumSLLConstTraits	25.523	10270.765	7.593889
SumSLLConstTraits_Core	22.964	11415.397	8.440195
SumSLL128Traits	56.482	4641.201	3.431562
SumSLL128Traits_Core	42.967	6101.042	4.510924
SumSLL128ConstTraits	44.786	5853.219	4.327691
SumSLL128ConstTraits_Core	38.558	6798.737	5.026778
SumSLLFast_Multiply	30.051	8723.159	6.449636
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	25.243	10384.981	7.678337
SumSLLFastTraits	25.281	10369.038	7.666549

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	194.724	1346.235
SumSLL_Basic	556.299	471.229	0.350034
SumSLL_Base_Core	562.446	466.079	0.346209
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	58.928	4448.556	3.304442
SumSLLTraits	59.076	4437.420	3.296170
SumSLLTraits_Core	46.552	5631.227	4.182945
SumSLLConstTraits	60.136	4359.205	3.238071
SumSLLConstTraits_Core	47.712	5494.338	4.081262
SumSLL128Traits	101.761	2576.063	1.913531
SumSLL128Traits_Core	85.666	3060.060	2.273050
SumSLL128ConstTraits	100.866	2598.921	1.930510
SumSLL128ConstTraits_Core	85.623	3061.618	2.274208
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	54.373	4821.201	3.581248
SumSLLFastTraits	54.707	4791.775	3.559389

``` 

#### .NET 6.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	6.0.24
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.24\
RuntimeInformation.FrameworkDescription:	.NET 6.0.24
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.24/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	192.844	1359.361
SumSLL_Basic	15.940	16445.602	12.098041
SumSLL_Base_Core	6.546	40044.314	29.458196
SumSLL_Multiply	15.926	16459.778	12.108470
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	11.740	22329.276	16.426306
SumSLLTraits	11.768	22275.738	16.386922
SumSLLTraits_Core	6.760	38778.852	28.527271
SumSLLConstTraits	6.425	40803.174	30.016443
SumSLLConstTraits_Core	6.906	37957.676	27.923181
SumSLL128Traits	23.149	11324.426	8.330700
SumSLL128Traits_Core	11.392	23010.720	16.927604
SumSLL128ConstTraits	11.188	23430.138	17.236145
SumSLL128ConstTraits_Core	11.384	23027.809	16.940175
SumSLLFast_Multiply	9.782	26799.087	19.714478
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	6.934	37805.004	27.810870
SumSLLFastTraits	6.951	37713.378	27.743466

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	192.920	1358.824
SumSLL_Basic	18.729	13996.667	10.300577
SumSLL_Base_Core	11.139	23534.517	17.319774
SumSLL_Base_Core_Element	20.656	12690.810	9.339557
SumSLL_Base_Core_Mov	21.736	12060.375	8.875601
SumSLL_Multiply	19.387	13521.671	9.951013
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	14.913	17577.641	12.935926
SumSLLTraits	15.054	17413.467	12.815106
SumSLLTraits_Core	12.693	20651.910	15.198375
SumSLLConstTraits	12.036	21780.182	16.028705
SumSLLConstTraits_Core	11.748	22313.920	16.421499
SumSLL128Traits	25.452	10299.377	7.579628
SumSLL128Traits_Core	22.485	11658.723	8.580012
SumSLL128ConstTraits	21.611	12129.890	8.926759
SumSLL128ConstTraits_Core	20.978	12496.018	9.196204
SumSLLFast_Multiply	13.215	19837.415	14.598963
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	12.935	20266.778	14.914944
SumSLLFastTraits	13.233	19810.254	14.578974

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	118.564	2210.995
SumSLL_Basic	40.322	6501.187	2.940390
SumSLL_Base_Core	28.396	9231.653	4.175339
SumSLL_Multiply	40.829	6420.457	2.903877
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	29.894	8769.006	3.966091
SumSLLTraits	29.673	8834.515	3.995720
SumSLLTraits_Core	24.720	10604.724	4.796359
SumSLLConstTraits	23.321	11240.672	5.083989
SumSLLConstTraits_Core	24.387	10749.271	4.861736
SumSLL128Traits	50.821	5158.228	2.332990
SumSLL128Traits_Core	41.296	6347.901	2.871061
SumSLL128ConstTraits	42.898	6110.895	2.763867
SumSLL128ConstTraits_Core	42.863	6115.839	2.766103
SumSLLFast_Multiply	30.260	8663.119	3.918200
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	27.803	9428.490	4.264366
SumSLLFastTraits	27.715	9458.591	4.277980

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	121.254	2161.948
SumSLL_Basic	553.559	473.561	0.219044
SumSLL_Base_Core	553.932	473.242	0.218896
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	57.307	4574.409	2.115874
SumSLLTraits	56.935	4604.258	2.129680
SumSLLTraits_Core	44.853	5844.559	2.703376
SumSLLConstTraits	46.435	5645.399	2.611255
SumSLLConstTraits_Core	46.897	5589.806	2.585541
SumSLL128Traits	101.375	2585.887	1.196091
SumSLL128Traits_Core	81.200	3228.360	1.493264
SumSLL128ConstTraits	83.688	3132.408	1.448882
SumSLL128ConstTraits_Core	85.531	3064.909	1.417661
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	51.564	5083.835	2.351506
SumSLLFastTraits	51.035	5136.548	2.375889

``` 

#### .NET 7.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	7.0.13
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.13\
RuntimeInformation.FrameworkDescription:	.NET 7.0.13
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.13/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960959	# 0x0079797F
VectorEnvironment.CpuModelName:	Intel(R) Core(TM) i5-8250U CPU @ 1.60GHz
VectorEnvironment.SupportedInstructionSets:	Aes, Avx, Avx2, Bmi1, Bmi2, Fma, Lzcnt, Pclmulqdq, Popcnt, Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, X86Base
Vector128s.Instance:	WVectorTraits128Avx2	// Sse, Sse2, Sse3, Ssse3, Sse41, Sse42, Avx, Avx2
Vector256s.Instance:	WVectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.Instance:	VectorTraits256Avx2	// Avx, Avx2, Sse, Sse2
Vectors.BaseInstance:	VectorTraits256Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	169.143	1549.840
SumSLLNetBcl	222.385	1178.786	0.760585
SumSLLNetBcl_Const	222.658	1177.339	0.759651
SumSLL_Basic	13.086	20032.835	12.925740
SumSLL_Base_Core	6.591	39771.177	25.661466
SumSLL_Multiply	13.060	20072.958	12.951629
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	10.372	25274.859	16.308040
SumSLLTraits	10.215	25662.171	16.557945
SumSLLTraits_Core	6.765	38750.734	25.003048
SumSLLConstTraits	6.780	38665.512	24.948060
SumSLLConstTraits_Core	6.295	41641.236	26.868080
SumSLL128Traits	19.677	13322.526	8.596063
SumSLL128Traits_Core	12.417	21112.009	13.622054
SumSLL128ConstTraits	12.450	21055.801	13.585787
SumSLL128ConstTraits_Core	12.435	21080.812	13.601924
SumSLLFast_Multiply	7.377	35535.744	22.928647
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	6.925	37856.876	24.426306
SumSLLFastTraits	6.724	38986.866	25.155407

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	168.716	1553.763
SumSLLNetBcl	12.543	20899.194	13.450699
SumSLLNetBcl_Const	11.206	23392.777	15.055566
SumSLL_Basic	13.582	19300.915	12.422048
SumSLL_Base_Core	13.341	19649.150	12.646172
SumSLL_Base_Core_Element	15.659	16740.485	10.774158
SumSLL_Base_Core_Mov	14.897	17597.569	11.325776
SumSLL_Multiply	17.128	15305.111	9.850353
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	14.480	18104.001	11.651715
SumSLLTraits	13.924	18827.412	12.117302
SumSLLTraits_Core	14.208	18450.119	11.874477
SumSLLConstTraits	12.795	20487.319	13.185616
SumSLLConstTraits_Core	12.023	21803.300	14.032580
SumSLL128Traits	21.871	11985.678	7.713969
SumSLL128Traits_Core	21.081	12435.207	8.003286
SumSLL128ConstTraits	20.075	13057.907	8.404055
SumSLL128ConstTraits_Core	20.228	12959.630	8.340804
SumSLLFast_Multiply	13.211	19843.004	12.770936
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	13.173	19900.086	12.807674
SumSLLFastTraits	13.536	19366.831	12.464471

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	155.823	1682.320
SumSLLNetBcl	23.617	11099.770	6.597894
SumSLLNetBcl_Const	22.902	11446.173	6.803802
SumSLL_Basic	24.390	10747.854	6.388709
SumSLL_Base_Core	24.429	10730.875	6.378617
SumSLL_Multiply	34.710	7552.381	4.489265
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	28.257	9277.081	5.514457
SumSLLTraits	26.153	10023.542	5.958165
SumSLLTraits_Core	22.423	11690.595	6.949091
SumSLLConstTraits	23.236	11281.663	6.706014
SumSLLConstTraits_Core	22.716	11540.250	6.859723
SumSLL128Traits	42.028	6237.418	3.707629
SumSLL128Traits_Core	40.439	6482.377	3.853236
SumSLL128ConstTraits	40.066	6542.770	3.889135
SumSLL128ConstTraits_Core	39.928	6565.355	3.902560
SumSLLFast_Multiply	28.247	9280.389	5.516423
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	25.518	10272.998	6.106447
SumSLLFastTraits	24.715	10606.724	6.304819

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
SumSLLScalar	98.276	2667.438
SumSLLNetBcl	62.719	4179.660	1.566919
SumSLLNetBcl_Const	46.412	5648.203	2.117464
SumSLL_Basic	53.437	4905.683	1.839099
SumSLL_Base_Core	53.493	4900.543	1.837172
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLL_Avx2	60.073	4363.729	1.635925
SumSLLTraits	70.663	3709.782	1.390766
SumSLLTraits_Core	93.068	2816.698	1.055956
SumSLLConstTraits	52.726	4971.800	1.863886
SumSLLConstTraits_Core	51.283	5111.673	1.916323
SumSLL128Traits	98.763	2654.271	0.995064
SumSLL128Traits_Core	75.430	3475.323	1.302869
SumSLL128ConstTraits	76.978	3405.429	1.276666
SumSLL128ConstTraits_Core	76.340	3433.879	1.287332
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
SumSLLFast_Avx2	51.284	5111.590	1.916292
SumSLLFastTraits	53.085	4938.225	1.851299

``` 


## Arm

### Apple M2
`Apple M2`

#### .NET 6.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 15.0.1
Environment.Version:	6.0.33
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/usr/local/share/dotnet/shared/Microsoft.NETCore.App/6.0.33/
RuntimeInformation.FrameworkDescription:	.NET 6.0.33
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Darwin 24.0.0 Darwin Kernel Version 24.0.0: Tue Sep 24 23:37:13 PDT 2024; root:xnu-11215.1.12~1/RELEASE_ARM64_T8112
RuntimeInformation.RuntimeIdentifier:	osx.15-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///usr/local/share/dotnet/shared/Microsoft.NETCore.App/6.0.33/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Apple M2
VectorEnvironment.SupportedInstructionSets:	AdvSimd, ArmBase, Crc32
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	155.277	1688.231
SumSLL_Basic	13.869	18901.178	11.195850
SumSLL_Base_Core	9.630	27221.359	16.124194
SumSLL_Multiply	13.872	18897.768	11.193830
SumSLL_AdvSimd	9.646	27175.824	16.097222
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	9.643	27184.587	16.102413
SumSLLTraits_Core	9.623	27240.666	16.135630
SumSLLConstTraits	9.623	27241.149	16.135916
SumSLLConstTraits_Core	9.623	27241.876	16.136347
SumSLL128Traits	9.643	27184.170	16.102166
SumSLL128Traits_Core	9.623	27240.864	16.135747
SumSLL128ConstTraits	9.623	27240.422	16.135486
SumSLL128ConstTraits_Core	9.623	27240.335	16.135434
SumSLLFast_Multiply	10.199	25702.235	15.224362
SumSLLFast_AdvSimd	9.621	27247.673	16.139781
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	9.621	27246.655	16.139178

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	158.031	1658.809
SumSLL_Basic	21.227	12349.530	7.444819
SumSLL_Base_Core	19.259	13611.179	8.205394
SumSLL_Base_Core_Element	21.548	12165.333	7.333777
SumSLL_Base_Core_Mov	20.879	12555.202	7.568806
SumSLL_Multiply	20.490	12793.459	7.712437
SumSLL_AdvSimd	19.279	13597.321	8.197040
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	19.280	13596.599	8.196604
SumSLLTraits_Core	19.257	13613.120	8.206564
SumSLLConstTraits	19.259	13611.591	8.205642
SumSLLConstTraits_Core	19.257	13612.573	8.206234
SumSLL128Traits	19.277	13598.921	8.198004
SumSLL128Traits_Core	19.262	13609.691	8.204497
SumSLL128ConstTraits	19.258	13612.036	8.205911
SumSLL128ConstTraits_Core	19.258	13611.995	8.205886
SumSLLFast_Multiply	24.525	10689.058	6.443816
SumSLLFast_AdvSimd	19.256	13613.692	8.206909
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	19.259	13611.346	8.205495

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	151.435	1731.062
SumSLL_Basic	41.750	6278.852	3.627166
SumSLL_Base_Core	38.530	6803.687	3.930354
SumSLL_Multiply	41.751	6278.723	3.627092
SumSLL_AdvSimd	38.545	6800.960	3.928778
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	38.546	6800.779	3.928673
SumSLLTraits_Core	38.524	6804.758	3.930972
SumSLLConstTraits	38.519	6805.519	3.931412
SumSLLConstTraits_Core	38.526	6804.417	3.930775
SumSLL128Traits	38.540	6801.872	3.929305
SumSLL128Traits_Core	38.532	6803.333	3.930149
SumSLL128ConstTraits	38.538	6802.219	3.929505
SumSLL128ConstTraits_Core	38.522	6805.085	3.931161
SumSLLFast_Multiply	49.031	5346.523	3.088579
SumSLLFast_AdvSimd	38.526	6804.395	3.930762
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	38.535	6802.743	3.929808

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
Check-SumSLL_Base_Bit32_Or	Check `SumSLL_Base_Bit32_Or` mismatch. 6667559474292588544!=-6625999546565534712
SumSLLScalar	151.447	1730.925
SumSLL_Base_Bit32_Or	1253.901	209.063	0.120781
SumSLL_Basic	159.499	1643.546	0.949519
SumSLL_Base_Core	159.460	1643.952	0.949754
SumSLL_AdvSimd	77.094	3400.333	1.964460
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	77.100	3400.057	1.964301
SumSLLTraits_Core	77.073	3401.244	1.964986
SumSLLConstTraits	77.141	3398.249	1.963256
SumSLLConstTraits_Core	77.076	3401.108	1.964908
SumSLL128Traits	77.082	3400.836	1.964751
SumSLL128Traits_Core	77.056	3402.006	1.965427
SumSLL128ConstTraits	77.054	3402.099	1.965481
SumSLL128ConstTraits_Core	77.084	3400.738	1.964694
SumSLLFast_AdvSimd	77.067	3401.517	1.965144
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	77.068	3401.472	1.965118

```

#### .NET 7.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 15.0.1
Environment.Version:	7.0.20
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/usr/local/share/dotnet/shared/Microsoft.NETCore.App/7.0.20/
RuntimeInformation.FrameworkDescription:	.NET 7.0.20
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Darwin 24.0.0 Darwin Kernel Version 24.0.0: Tue Sep 24 23:37:13 PDT 2024; root:xnu-11215.1.12~1/RELEASE_ARM64_T8112
RuntimeInformation.RuntimeIdentifier:	osx.15-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
Vector<T>.Assembly.CodeBase:	file:///usr/local/share/dotnet/shared/Microsoft.NETCore.App/7.0.20/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Apple M2
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Dp, Rdm, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	155.191	1689.165
SumSLLNetBcl	9.624	27237.699	16.124949
SumSLLNetBcl_Const	9.622	27243.512	16.128390
SumSLL_Basic	9.619	27252.520	16.133723
SumSLL_Base_Core	9.624	27237.691	16.124944
SumSLL_Multiply	13.273	19749.609	11.691936
SumSLL_AdvSimd	9.638	27198.086	16.101498
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	9.631	27217.983	16.113277
SumSLLTraits_Core	9.623	27240.347	16.126517
SumSLLConstTraits	9.623	27241.587	16.127251
SumSLLConstTraits_Core	9.623	27240.780	16.126773
SumSLL128Bcl	9.623	27241.126	16.126978
SumSLL128Traits	9.634	27209.408	16.108201
SumSLL128Traits_Core	9.626	27232.292	16.121748
SumSLL128ConstTraits	9.623	27240.127	16.126387
SumSLL128ConstTraits_Core	9.626	27233.101	16.122227
SumSLLFast_Multiply	10.633	24653.160	14.594880
SumSLLFast_AdvSimd	9.622	27242.911	16.128035
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	9.621	27247.468	16.130732

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	155.124	1689.899
SumSLLNetBcl	19.255	13614.663	8.056495
SumSLLNetBcl_Const	19.256	13613.385	8.055738
SumSLL_Basic	19.253	13615.715	8.057117
SumSLL_Base_Core	19.254	13615.091	8.056748
SumSLL_Base_Core_Element	19.274	13600.977	8.048396
SumSLL_Base_Core_Mov	19.270	13603.835	8.050087
SumSLL_Multiply	20.873	12558.754	7.431659
SumSLL_AdvSimd	19.265	13607.185	8.052070
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	19.249	13618.347	8.058675
SumSLLTraits_Core	19.256	13613.621	8.055878
SumSLLConstTraits	19.251	13616.950	8.057848
SumSLLConstTraits_Core	19.252	13616.534	8.057602
SumSLL128Bcl	19.255	13613.995	8.056100
SumSLL128Traits	19.255	13614.299	8.056280
SumSLL128Traits_Core	19.255	13614.109	8.056167
SumSLL128ConstTraits	19.257	13613.107	8.055574
SumSLL128ConstTraits_Core	19.259	13611.681	8.054730
SumSLLFast_Multiply	24.683	10620.588	6.284747
SumSLLFast_AdvSimd	19.291	13589.167	8.041407
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	19.256	13613.556	8.055839

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	154.236	1699.630
SumSLLNetBcl	38.527	6804.164	4.003321
SumSLLNetBcl_Const	38.521	6805.172	4.003914
SumSLL_Basic	38.523	6804.876	4.003740
SumSLL_Base_Core	38.527	6804.154	4.003315
SumSLL_Multiply	48.821	5369.521	3.159230
SumSLL_AdvSimd	38.537	6802.457	4.002316
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	38.522	6804.972	4.003796
SumSLLTraits_Core	38.527	6804.165	4.003322
SumSLLConstTraits	38.529	6803.802	4.003108
SumSLLConstTraits_Core	38.523	6804.833	4.003714
SumSLL128Bcl	38.526	6804.390	4.003454
SumSLL128Traits	38.524	6804.641	4.003601
SumSLL128Traits_Core	38.556	6799.075	4.000327
SumSLL128ConstTraits	38.527	6804.217	4.003352
SumSLL128ConstTraits_Core	38.528	6804.062	4.003261
SumSLLFast_Multiply	49.267	5320.840	3.130587
SumSLLFast_AdvSimd	38.527	6804.243	4.003367
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	38.525	6804.541	4.003542

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
Check-SumSLL_Base_Bit32_Or	Check `SumSLL_Base_Bit32_Or` mismatch. 6667559474292588544!=-6625999546565534712
SumSLLScalar	154.256	1699.409
SumSLLNetBcl	77.063	3401.673	2.001680
SumSLLNetBcl_Const	77.055	3402.036	2.001894
SumSLL_Base_Bit32_Or	1255.819	208.743	0.122833
SumSLL_Basic	77.059	3401.854	2.001787
SumSLL_Base_Core	77.062	3401.725	2.001711
SumSLL_AdvSimd	77.086	3400.687	2.001100
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	77.065	3401.590	2.001631
SumSLLTraits_Core	77.062	3401.727	2.001712
SumSLLConstTraits	77.061	3401.783	2.001745
SumSLLConstTraits_Core	77.052	3402.158	2.001966
SumSLL128Bcl	77.060	3401.823	2.001769
SumSLL128Traits	77.079	3400.980	2.001272
SumSLL128Traits_Core	77.051	3402.203	2.001992
SumSLL128ConstTraits	77.070	3401.355	2.001493
SumSLL128ConstTraits_Core	77.058	3401.922	2.001827
SumSLLFast_AdvSimd	77.059	3401.850	2.001785
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	77.052	3402.150	2.001961

```

#### .NET 8.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 15.0.1
Environment.Version:	8.0.4
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/usr/local/share/dotnet/shared/Microsoft.NETCore.App/8.0.4/
RuntimeInformation.FrameworkDescription:	.NET 8.0.4
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Darwin 24.0.0 Darwin Kernel Version 24.0.0: Tue Sep 24 23:37:13 PDT 2024; root:xnu-11215.1.12~1/RELEASE_ARM64_T8112
RuntimeInformation.RuntimeIdentifier:	osx-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
Vector512.IsHardwareAccelerated:	False
Vector<T>.Assembly.CodeBase:	file:///usr/local/share/dotnet/shared/Microsoft.NETCore.App/8.0.4/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 8.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 8.0
VectorTraitsGlobal.InitCheckSum:	-2122844159	# 0x8177F801
VectorEnvironment.CpuModelName:	Apple M2
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Dp, Rdm, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	224.751	1166.373
SumSLLNetBcl	9.619	27253.238	23.365800
SumSLLNetBcl_Const	9.620	27249.895	23.362934
SumSLL_Basic	9.617	27259.289	23.370988
SumSLL_Base_Core	9.623	27240.305	23.354711
SumSLL_Multiply	12.066	21725.341	18.626409
SumSLL_AdvSimd	9.618	27256.068	23.368226
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	9.619	27252.160	23.364876
SumSLLTraits_Core	9.618	27254.168	23.366597
SumSLLConstTraits	9.622	27245.221	23.358926
SumSLLConstTraits_Core	9.620	27249.910	23.362946
SumSLL128Bcl	9.621	27247.598	23.360964
SumSLL128Traits	9.621	27247.548	23.360922
SumSLL128Traits_Core	9.621	27247.463	23.360849
SumSLL128ConstTraits	9.619	27252.220	23.364927
SumSLL128ConstTraits_Core	9.620	27248.729	23.361934
SumSLL512Bcl	2.900	90386.486	77.493637
SumSLL512Traits	58.817	4456.934	3.821191
SumSLLFast_Multiply	10.634	24650.665	21.134461
SumSLLFast_AdvSimd	9.623	27241.269	23.355538
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	9.620	27249.451	23.362553

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	224.838	1165.925
SumSLLNetBcl	19.250	13617.976	11.679973
SumSLLNetBcl_Const	19.251	13616.897	11.679047
SumSLL_Basic	19.247	13619.809	11.681545
SumSLL_Base_Core	19.250	13617.953	11.679953
SumSLL_Base_Core_Element	19.253	13615.624	11.677956
SumSLL_Base_Core_Mov	19.252	13616.692	11.678871
SumSLL_Multiply	24.664	10628.608	9.116028
SumSLL_AdvSimd	19.251	13617.101	11.679222
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	19.250	13617.537	11.679596
SumSLLTraits_Core	19.252	13616.340	11.678570
SumSLLConstTraits	19.248	13618.971	11.680826
SumSLLConstTraits_Core	19.252	13616.619	11.678809
SumSLL128Bcl	19.254	13615.357	11.677727
SumSLL128Traits	19.251	13617.414	11.679491
SumSLL128Traits_Core	19.255	13614.045	11.676601
SumSLL128ConstTraits	19.248	13619.332	11.681136
SumSLL128ConstTraits_Core	19.252	13616.528	11.678730
SumSLL512Bcl	5.850	44809.608	38.432657
SumSLL512Traits	5.850	44813.444	38.435947
SumSLLFast_Multiply	24.659	10630.970	9.118054
SumSLLFast_AdvSimd	19.248	13619.603	11.681369
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	19.253	13615.887	11.678181

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	150.024	1747.343
SumSLLNetBcl	38.518	6805.684	3.894876
SumSLLNetBcl_Const	38.518	6805.794	3.894939
SumSLL_Basic	38.522	6804.985	3.894476
SumSLL_Base_Core	38.523	6804.953	3.894458
SumSLL_Multiply	38.528	6804.036	3.893933
SumSLL_AdvSimd	38.524	6804.606	3.894259
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	38.521	6805.165	3.894579
SumSLLTraits_Core	38.526	6804.415	3.894150
SumSLLConstTraits	38.514	6806.445	3.895311
SumSLLConstTraits_Core	38.520	6805.442	3.894737
SumSLL128Bcl	38.522	6805.043	3.894509
SumSLL128Traits	38.517	6805.888	3.894993
SumSLL128Traits_Core	38.534	6802.870	3.893266
SumSLL128ConstTraits	38.515	6806.212	3.895178
SumSLL128ConstTraits_Core	38.516	6806.040	3.895080
SumSLL512Bcl	11.748	22314.396	12.770474
SumSLL512Traits	11.748	22314.578	12.770578
SumSLLFast_Multiply	38.516	6806.113	3.895122
SumSLLFast_AdvSimd	38.520	6805.422	3.894726
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	38.513	6806.607	3.895404

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
Check-SumSLL_Base_Bit32_Or	Check `SumSLL_Base_Bit32_Or` mismatch. 6667559474292588544!=-6625999546565534712
SumSLLScalar	149.981	1747.852
SumSLLNetBcl	77.054	3402.085	1.946438
SumSLLNetBcl_Const	77.054	3402.074	1.946432
SumSLL_Base_Bit32_Or	1301.708	201.385	0.115218
SumSLL_Basic	77.056	3402.005	1.946392
SumSLL_Base_Core	77.074	3401.178	1.945919
SumSLL_AdvSimd	77.058	3401.900	1.946332
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	77.052	3402.183	1.946494
SumSLLTraits_Core	77.054	3402.077	1.946433
SumSLLConstTraits	77.043	3402.561	1.946710
SumSLLConstTraits_Core	77.048	3402.367	1.946599
SumSLL128Bcl	77.060	3401.833	1.946293
SumSLL128Traits	77.048	3402.330	1.946578
SumSLL128Traits_Core	77.049	3402.294	1.946558
SumSLL128ConstTraits	77.040	3402.722	1.946802
SumSLL128ConstTraits_Core	77.040	3402.710	1.946796
SumSLL512Bcl	22.903	11445.604	6.548383
SumSLL512Traits	22.905	11445.085	6.548086
SumSLLFast_AdvSimd	77.065	3401.580	1.946149
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	77.050	3402.240	1.946526

```

### AWS Arm t4g.small
`AWS Arm t4g.small`

#### .NET Core 3.1
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	3.1.32
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.32
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.8.0-1015-aws #16~22.04.1-Ubuntu SMP Mon Aug 19 20:21:57 UTC 2024
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Neoverse-N1
VectorEnvironment.CpuFlags:	fp asimd evtstrm aes pmull sha1 sha2 crc32 atomics fphp asimdhp cpuid asimdrdm lrcpc dcpop asimddp ssbs
VectorEnvironment.SupportedInstructionSets:	
Vector128s.Instance:	WVectorTraits128Base	// 
Vectors.Instance:	VectorTraits128Base	// 
Vectors.BaseInstance:	VectorTraits128Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	432.067	606.721
SumSLL_Basic	47.058	5570.622	9.181528
SumSLL_Base_Core	18.641	14062.887	23.178524
SumSLL_Multiply	46.865	5593.564	9.219342
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	47.305	5541.532	9.133583
SumSLLTraits_Core	18.660	14048.511	23.154830
SumSLLConstTraits	26.928	9734.870	16.045063
SumSLLConstTraits_Core	20.154	13007.028	21.438252
SumSLL128Traits	576.422	454.778	0.749568
SumSLL128Traits_Core	573.143	457.380	0.753855
SumSLL128ConstTraits	574.582	456.235	0.751968
SumSLL128ConstTraits_Core	574.700	456.141	0.751814
SumSLLFast_Multiply	26.745	9801.615	16.155074
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	26.945	9728.967	16.035335

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	432.485	606.135
SumSLL_Basic	61.881	4236.284	6.989012
SumSLL_Base_Core	31.312	8372.081	13.812241
SumSLL_Base_Core_Element	66.463	3944.193	6.507121
SumSLL_Base_Core_Mov	62.240	4211.816	6.948645
SumSLL_Multiply	61.684	4249.780	7.011278
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	62.188	4215.369	6.954506
SumSLLTraits_Core	33.104	7918.688	13.064234
SumSLLConstTraits	39.909	6568.606	10.836872
SumSLLConstTraits_Core	30.860	8494.550	14.014290
SumSLL128Traits	881.500	297.384	0.490623
SumSLL128Traits_Core	880.491	297.725	0.491185
SumSLL128ConstTraits	902.256	290.543	0.479337
SumSLL128ConstTraits_Core	906.827	289.078	0.476921
SumSLLFast_Multiply	46.608	5624.401	9.279124
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	53.278	4920.261	8.117436

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	350.621	747.656
SumSLL_Basic	79.882	3281.623	4.389217
SumSLL_Base_Core	66.215	3958.956	5.295160
SumSLL_Multiply	80.066	3274.096	4.379149
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	79.584	3293.943	4.405695
SumSLLTraits_Core	62.255	4210.811	5.632019
SumSLLConstTraits	80.020	3275.986	4.381678
SumSLLConstTraits_Core	62.337	4205.245	5.624574
SumSLL128Traits	1400.993	187.113	0.250266
SumSLL128Traits_Core	1400.533	187.174	0.250348
SumSLL128ConstTraits	1401.361	187.064	0.250201
SumSLL128ConstTraits_Core	1404.567	186.637	0.249629
SumSLLFast_Multiply	72.965	3592.733	4.805332
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	79.491	3297.770	4.410814

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
Check-SumSLL_Base_Bit32_Or	Check `SumSLL_Base_Bit32_Or` mismatch. 6667559474292588544!=-6625999546565534712
SumSLLScalar	354.662	739.137
SumSLL_Base_Bit32_Or	3996.660	65.591	0.088740
SumSLL_Basic	551.778	475.089	0.642762
SumSLL_Base_Core	541.835	483.807	0.654557
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	538.577	486.734	0.658516
SumSLLTraits_Core	535.475	489.554	0.662331
SumSLLConstTraits	560.865	467.393	0.632349
SumSLLConstTraits_Core	562.187	466.293	0.630861
SumSLL128Traits	982.218	266.890	0.361083
SumSLL128Traits_Core	966.220	271.309	0.367061
SumSLL128ConstTraits	963.741	272.007	0.368006
SumSLL128ConstTraits_Core	979.692	267.578	0.362014
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	561.405	466.943	0.631740

```

#### .NET 5.0
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	5.0.17
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.8.0-1015-aws #16~22.04.1-Ubuntu SMP Mon Aug 19 20:21:57 UTC 2024
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Neoverse-N1
VectorEnvironment.CpuFlags:	fp asimd evtstrm aes pmull sha1 sha2 crc32 atomics fphp asimdhp cpuid asimdrdm lrcpc dcpop asimddp ssbs
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	431.334	607.751
SumSLL_Basic	46.717	5611.377	9.233012
SumSLL_Base_Core	16.821	15584.590	25.643033
SumSLL_Multiply	46.399	5649.748	9.296150
SumSLL_AdvSimd	19.960	13133.580	21.610118
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	20.049	13075.259	21.514156
SumSLLTraits_Core	15.468	16947.485	27.885552
SumSLLConstTraits	16.698	15699.315	25.831801
SumSLLConstTraits_Core	15.588	16817.247	27.671258
SumSLL128Traits	19.923	13157.734	21.649860
SumSLL128Traits_Core	16.567	15822.924	26.035190
SumSLL128ConstTraits	92.802	2824.766	4.647897
SumSLL128ConstTraits_Core	16.618	15774.847	25.956083
SumSLLFast_Multiply	26.480	9899.588	16.288876
SumSLLFast_AdvSimd	16.542	15847.023	26.074842
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	16.589	15802.753	26.002000

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	434.157	603.800
SumSLL_Basic	61.529	4260.518	7.056177
SumSLL_Base_Core	34.045	7699.910	12.752423
SumSLL_Base_Core_Element	62.107	4220.859	6.990495
SumSLL_Base_Core_Mov	62.370	4203.040	6.960983
SumSLL_Multiply	62.638	4185.086	6.931247
SumSLL_AdvSimd	40.658	6447.476	10.678168
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	40.037	6547.514	10.843850
SumSLLTraits_Core	31.089	8431.934	13.964786
SumSLLConstTraits	33.480	7829.860	12.967644
SumSLLConstTraits_Core	31.145	8416.796	13.939714
SumSLL128Traits	39.977	6557.387	10.860201
SumSLL128Traits_Core	33.668	7786.080	12.895136
SumSLL128ConstTraits	172.488	1519.782	2.517030
SumSLL128ConstTraits_Core	33.570	7808.976	12.933056
SumSLLFast_Multiply	47.419	5528.278	9.155814
SumSLLFast_AdvSimd	34.177	7670.144	12.703126
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	33.329	7865.272	13.026291

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	351.393	746.013
SumSLL_Basic	80.438	3258.960	4.368503
SumSLL_Base_Core	67.553	3880.564	5.201738
SumSLL_Multiply	81.462	3218.008	4.313609
SumSLL_AdvSimd	74.527	3517.415	4.714952
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	80.188	3269.129	4.382135
SumSLLTraits_Core	66.693	3930.619	5.268835
SumSLLConstTraits	80.664	3249.809	4.356238
SumSLLConstTraits_Core	62.428	4199.155	5.628796
SumSLL128Traits	81.042	3234.651	4.335918
SumSLL128Traits_Core	63.440	4132.178	5.539016
SumSLL128ConstTraits	348.509	752.187	1.008276
SumSLL128ConstTraits_Core	67.899	3860.770	5.175206
SumSLLFast_Multiply	80.370	3261.724	4.372209
SumSLLFast_AdvSimd	80.890	3240.731	4.344068
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	80.814	3243.806	4.348190

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
Check-SumSLL_Base_Bit32_Or	Check `SumSLL_Base_Bit32_Or` mismatch. 6667559474292588544!=-6625999546565534712
SumSLLScalar	359.516	729.158
SumSLL_Base_Bit32_Or	4255.328	61.604	0.084486
SumSLL_Basic	557.662	470.077	0.644685
SumSLL_Base_Core	544.308	481.610	0.660501
SumSLL_AdvSimd	162.371	1614.477	2.214167
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	159.958	1638.835	2.247572
SumSLLTraits_Core	126.318	2075.273	2.846124
SumSLLConstTraits	135.768	1930.821	2.648016
SumSLLConstTraits_Core	126.355	2074.656	2.845277
SumSLL128Traits	162.467	1613.521	2.212855
SumSLL128Traits_Core	133.542	1963.012	2.692164
SumSLL128ConstTraits	748.184	350.374	0.480519
SumSLL128ConstTraits_Core	133.141	1968.925	2.700272
SumSLLFast_AdvSimd	135.821	1930.066	2.646980
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	158.742	1651.380	2.264778

```

#### .NET 6.0
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	6.0.19
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/
RuntimeInformation.FrameworkDescription:	.NET 6.0.19
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.8.0-1015-aws #16~22.04.1-Ubuntu SMP Mon Aug 19 20:21:57 UTC 2024
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.19/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Neoverse-N1
VectorEnvironment.CpuFlags:	fp asimd evtstrm aes pmull sha1 sha2 crc32 atomics fphp asimdhp cpuid asimdrdm lrcpc dcpop asimddp ssbs
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	388.790	674.256
SumSLL_Basic	37.351	7018.347	10.409026
SumSLL_Base_Core	19.856	13202.074	19.580212
SumSLL_Multiply	37.297	7028.464	10.424030
SumSLL_AdvSimd	19.962	13131.945	19.476203
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	19.873	13190.705	19.563350
SumSLLTraits_Core	16.561	15828.571	23.475613
SumSLLConstTraits	16.535	15853.772	23.512989
SumSLLConstTraits_Core	16.552	15838.060	23.489687
SumSLL128Traits	19.863	13197.554	19.573509
SumSLL128Traits_Core	15.454	16962.586	25.157489
SumSLL128ConstTraits	16.544	15845.140	23.500187
SumSLL128ConstTraits_Core	16.543	15846.332	23.501955
SumSLLFast_Multiply	23.659	11080.190	16.433212
SumSLLFast_AdvSimd	15.463	16952.835	25.143027
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	15.441	16977.225	25.179201

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	432.771	605.734
SumSLL_Basic	46.535	5633.260	9.299886
SumSLL_Base_Core	31.302	8374.542	13.825438
SumSLL_Base_Core_Element	53.079	4938.791	8.153394
SumSLL_Base_Core_Mov	53.435	4905.882	8.099066
SumSLL_Multiply	46.560	5630.237	9.294895
SumSLL_AdvSimd	40.136	6531.434	10.782672
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	39.971	6558.299	10.827022
SumSLLTraits_Core	33.215	7892.235	13.029201
SumSLLConstTraits	33.234	7887.842	13.021950
SumSLLConstTraits_Core	33.173	7902.444	13.046056
SumSLL128Traits	39.982	6556.492	10.824040
SumSLL128Traits_Core	31.127	8421.653	13.903213
SumSLL128ConstTraits	33.235	7887.605	13.021558
SumSLL128ConstTraits_Core	31.125	8422.226	13.904158
SumSLLFast_Multiply	40.132	6532.043	10.783677
SumSLLFast_AdvSimd	31.068	8437.625	13.929580
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	31.075	8435.776	13.926528

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	349.941	749.108
SumSLL_Basic	87.041	3011.718	4.020404
SumSLL_Base_Core	66.962	3914.821	5.225975
SumSLL_Multiply	87.013	3012.705	4.021722
SumSLL_AdvSimd	74.128	3536.378	4.720783
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	79.963	3278.303	4.376274
SumSLLTraits_Core	66.747	3927.408	5.242778
SumSLLConstTraits	66.819	3923.176	5.237128
SumSLLConstTraits_Core	63.066	4156.634	5.548776
SumSLL128Traits	79.680	3289.965	4.391842
SumSLL128Traits_Core	62.575	4189.265	5.592335
SumSLL128ConstTraits	66.747	3927.452	5.242836
SumSLL128ConstTraits_Core	62.713	4180.061	5.580049
SumSLLFast_Multiply	81.280	3225.201	4.305387
SumSLLFast_AdvSimd	62.523	4192.794	5.597047
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	62.634	4185.307	5.587052

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
Check-SumSLL_Base_Bit32_Or	Check `SumSLL_Base_Bit32_Or` mismatch. 6667559474292588544!=-6625999546565534712
SumSLLScalar	353.450	741.673
SumSLL_Base_Bit32_Or	3803.414	68.923	0.092930
SumSLL_Basic	545.562	480.503	0.647863
SumSLL_Base_Core	544.384	481.543	0.649266
SumSLL_AdvSimd	161.470	1623.486	2.188952
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	160.212	1636.233	2.206139
SumSLLTraits_Core	133.210	1967.902	2.653329
SumSLLConstTraits	133.149	1968.798	2.654536
SumSLLConstTraits_Core	133.147	1968.834	2.654585
SumSLL128Traits	160.272	1635.615	2.205305
SumSLL128Traits_Core	124.759	2101.205	2.833061
SumSLL128ConstTraits	124.664	2102.802	2.835215
SumSLL128ConstTraits_Core	124.987	2097.371	2.827892
SumSLLFast_AdvSimd	132.999	1971.025	2.657540
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	124.779	2100.868	2.832607

```

#### .NET 7.0
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	7.0.8
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/
RuntimeInformation.FrameworkDescription:	.NET 7.0.8
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 6.8.0-1015-aws #16~22.04.1-Ubuntu SMP Mon Aug 19 20:21:57 UTC 2024
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.8/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
VectorTraitsGlobal.InitCheckSum:	7960961	# 0x00797981
VectorEnvironment.CpuModelName:	Neoverse-N1
VectorEnvironment.CpuFlags:	fp asimd evtstrm aes pmull sha1 sha2 crc32 atomics fphp asimdhp cpuid asimdrdm lrcpc dcpop asimddp ssbs
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	294.254	890.878
SumSLLNetBcl	13.384	19585.982	21.985035
SumSLLNetBcl_Const	13.399	19564.840	21.961303
SumSLL_Basic	13.379	19594.158	21.994212
SumSLL_Base_Core	13.398	19566.417	21.963073
SumSLL_Multiply	35.603	7363.076	8.264967
SumSLL_AdvSimd	19.871	13192.312	14.808215
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	19.844	13209.927	14.827987
SumSLLTraits_Core	13.382	19589.430	21.988906
SumSLLConstTraits	13.435	19511.952	21.901937
SumSLLConstTraits_Core	13.497	19422.222	21.801216
SumSLL128Bcl	13.392	19574.043	21.971634
SumSLL128Traits	19.829	13220.412	14.839757
SumSLL128Traits_Core	13.416	19540.117	21.933551
SumSLL128ConstTraits	13.510	19404.397	21.781208
SumSLL128ConstTraits_Core	13.522	19386.420	21.761029
SumSLLFast_Multiply	22.510	11645.587	13.072034
SumSLLFast_AdvSimd	13.389	19579.305	21.977540
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	13.390	19578.163	21.976258

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	319.345	820.880
SumSLLNetBcl	26.364	9943.220	12.112881
SumSLLNetBcl_Const	26.379	9937.639	12.106082
SumSLL_Basic	26.380	9937.324	12.105699
SumSLL_Base_Core	26.415	9923.975	12.089437
SumSLL_Base_Core_Element	36.279	7225.731	8.802423
SumSLL_Base_Core_Mov	33.038	7934.539	9.665896
SumSLL_Multiply	42.782	6127.369	7.464392
SumSLL_AdvSimd	39.556	6627.195	8.073282
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	26.418	9923.088	12.088356
SumSLLTraits_Core	26.374	9939.469	12.108312
SumSLLConstTraits	26.410	9925.988	12.091890
SumSLLConstTraits_Core	26.441	9914.384	12.077754
SumSLL128Bcl	26.425	9920.339	12.085007
SumSLL128Traits	26.392	9932.539	12.099870
SumSLL128Traits_Core	26.422	9921.453	12.086365
SumSLL128ConstTraits	26.423	9921.070	12.085898
SumSLL128ConstTraits_Core	26.385	9935.154	12.103056
SumSLLFast_Multiply	39.455	6644.048	8.093813
SumSLLFast_AdvSimd	26.415	9923.961	12.089420
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	26.396	9931.347	12.098417

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	186.430	1406.122
SumSLLNetBcl	53.209	4926.651	3.503714
SumSLLNetBcl_Const	53.306	4917.732	3.497371
SumSLL_Basic	53.317	4916.699	3.496637
SumSLL_Base_Core	53.318	4916.630	3.496587
SumSLL_Multiply	79.477	3298.347	2.345704
SumSLL_AdvSimd	66.411	3947.296	2.807221
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	53.222	4925.488	3.502887
SumSLLTraits_Core	53.239	4923.867	3.501734
SumSLLConstTraits	53.211	4926.463	3.503581
SumSLLConstTraits_Core	53.222	4925.448	3.502859
SumSLL128Bcl	53.104	4936.472	3.510699
SumSLL128Traits	53.174	4929.956	3.506064
SumSLL128Traits_Core	53.174	4929.916	3.506036
SumSLL128ConstTraits	53.237	4924.095	3.501896
SumSLL128ConstTraits_Core	53.295	4918.693	3.498054
SumSLLFast_Multiply	75.852	3455.984	2.457811
SumSLLFast_AdvSimd	53.155	4931.705	3.507309
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	53.222	4925.466	3.502871

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
Check-SumSLL_Base_Bit32_Or	Check `SumSLL_Base_Bit32_Or` mismatch. 6667559474292588544!=-6625999546565534712
SumSLLScalar	191.000	1372.480
SumSLLNetBcl	105.830	2477.025	1.804780
SumSLLNetBcl_Const	105.998	2473.102	1.801922
SumSLL_Base_Bit32_Or	3736.478	70.158	0.051118
SumSLL_Basic	106.429	2463.089	1.794626
SumSLL_Base_Core	106.775	2455.096	1.788803
SumSLL_AdvSimd	131.985	1986.161	1.447133
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	132.023	1985.596	1.446721
SumSLLTraits_Core	105.955	2474.105	1.802653
SumSLLConstTraits	106.083	2471.124	1.800481
SumSLLConstTraits_Core	105.848	2476.602	1.804472
SumSLL128Bcl	106.260	2467.015	1.797487
SumSLL128Traits	132.122	1984.107	1.445636
SumSLL128Traits_Core	105.934	2474.609	1.803020
SumSLL128ConstTraits	105.880	2475.859	1.803930
SumSLL128ConstTraits_Core	105.690	2480.319	1.807180
SumSLLFast_AdvSimd	105.824	2477.170	1.804886
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	105.969	2473.770	1.802409

```

#### .NET 8.0

```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 6.8.0.1015
Environment.Version:	8.0.7
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/8.0.7/
RuntimeInformation.FrameworkDescription:	.NET 8.0.7
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Ubuntu 22.04.2 LTS
RuntimeInformation.RuntimeIdentifier:	linux-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
Vector512.IsHardwareAccelerated:	False
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/8.0.7/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 8.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 8.0
VectorTraitsGlobal.InitCheckSum:	-2122844159	# 0x8177F801
VectorEnvironment.CpuModelName:	Neoverse-N1
VectorEnvironment.CpuFlags:	fp asimd evtstrm aes pmull sha1 sha2 crc32 atomics fphp asimdhp cpuid asimdrdm lrcpc dcpop asimddp ssbs
VectorEnvironment.SupportedInstructionSets:	AdvSimd, Aes, ArmBase, Crc32, Dp, Rdm, Sha1, Sha256
Vector128s.Instance:	WVectorTraits128AdvSimdB64	// AdvSimd
Vectors.Instance:	VectorTraits128AdvSimdB64	// AdvSimd
Vectors.BaseInstance:	VectorTraits128Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	211.609	1238.814
SumSLLNetBcl	13.218	19831.927	16.008802
SumSLLNetBcl_Const	13.213	19840.232	16.015507
SumSLL_Basic	13.219	19830.407	16.007575
SumSLL_Base_Core	13.214	19838.696	16.014267
SumSLL_Multiply	31.741	8258.815	6.666711
SumSLL_AdvSimd	13.215	19836.238	16.012283
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	13.210	19844.497	16.018949
SumSLLTraits_Core	13.212	19841.525	16.016550
SumSLLConstTraits	13.232	19811.385	15.992220
SumSLLConstTraits_Core	13.213	19839.627	16.015018
SumSLL128Bcl	13.212	19841.249	16.016327
SumSLL128Traits	13.213	19840.557	16.015768
SumSLL128Traits_Core	13.215	19837.148	16.013017
SumSLL128ConstTraits	13.216	19834.953	16.011245
SumSLL128ConstTraits_Core	13.214	19838.220	16.013883
SumSLL512Bcl	8.330	31468.871	25.402420
SumSLL512Traits	173.675	1509.391	1.218416
SumSLLFast_Multiply	19.637	13349.204	10.775795
SumSLLFast_AdvSimd	13.222	19826.870	16.004720
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	13.211	19842.620	16.017434

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	254.253	1031.035
SumSLLNetBcl	26.740	9803.495	9.508397
SumSLLNetBcl_Const	26.648	9837.136	9.541025
SumSLL_Basic	26.804	9780.171	9.485776
SumSLL_Base_Core	26.643	9839.122	9.542952
SumSLL_Base_Core_Element	26.640	9840.302	9.544097
SumSLL_Base_Core_Mov	26.950	9727.086	9.434288
SumSLL_Multiply	36.283	7224.942	7.007462
SumSLL_AdvSimd	26.642	9839.411	9.543232
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	26.643	9839.256	9.543082
SumSLLTraits_Core	26.642	9839.496	9.543314
SumSLLConstTraits	26.642	9839.534	9.543352
SumSLLConstTraits_Core	26.685	9823.608	9.527905
SumSLL128Bcl	26.652	9835.933	9.539859
SumSLL128Traits	26.651	9836.177	9.540095
SumSLL128Traits_Core	26.645	9838.227	9.542084
SumSLL128ConstTraits	26.646	9838.173	9.542031
SumSLL128ConstTraits_Core	26.639	9840.651	9.544435
SumSLL512Bcl	19.585	13384.764	12.981866
SumSLL512Traits	19.611	13367.250	12.964879
SumSLLFast_Multiply	36.211	7239.370	7.021455
SumSLLFast_AdvSimd	26.764	9794.698	9.499865
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	26.637	9841.420	9.545181

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	185.900	1410.137
SumSLLNetBcl	54.309	4826.909	3.423007
SumSLLNetBcl_Const	54.159	4840.232	3.432455
SumSLL_Basic	54.441	4815.201	3.414704
SumSLL_Base_Core	54.091	4846.376	3.436812
SumSLL_Multiply	54.301	4827.633	3.423520
SumSLL_AdvSimd	54.019	4852.835	3.441392
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	54.196	4836.941	3.430121
SumSLLTraits_Core	54.116	4844.083	3.435186
SumSLLConstTraits	54.092	4846.238	3.436714
SumSLLConstTraits_Core	54.110	4844.679	3.435609
SumSLL128Bcl	54.051	4849.893	3.439306
SumSLL128Traits	53.963	4857.887	3.444975
SumSLL128Traits_Core	54.382	4820.379	3.418376
SumSLL128ConstTraits	54.104	4845.226	3.435996
SumSLL128ConstTraits_Core	54.131	4842.765	3.434251
SumSLL512Bcl	39.766	6592.187	4.674855
SumSLL512Traits	39.715	6600.591	4.680815
SumSLLFast_Multiply	54.426	4816.487	3.415616
SumSLLFast_AdvSimd	54.654	4796.438	3.401398
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	54.046	4850.347	3.439628

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
Check-SumSLL_Base_Bit32_Or	Check `SumSLL_Base_Bit32_Or` mismatch. 6667559474292588544!=-6625999546565534712
SumSLLScalar	202.169	1296.655
SumSLLNetBcl	115.786	2264.032	1.746056
SumSLLNetBcl_Const	116.443	2251.272	1.736215
SumSLL_Base_Bit32_Or	4864.107	53.894	0.041564
SumSLL_Basic	114.903	2281.435	1.759477
SumSLL_Base_Core	115.297	2273.635	1.753462
SumSLL_AdvSimd	113.114	2317.512	1.787300
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	114.698	2285.512	1.762621
SumSLLTraits_Core	114.497	2289.521	1.765713
SumSLLConstTraits	113.544	2308.745	1.780539
SumSLLConstTraits_Core	114.924	2281.018	1.759156
SumSLL128Bcl	115.524	2269.166	1.750015
SumSLL128Traits	115.307	2273.440	1.753311
SumSLL128Traits_Core	115.538	2268.904	1.749813
SumSLL128ConstTraits	115.525	2269.156	1.750008
SumSLL128ConstTraits_Core	112.939	2321.117	1.790081
SumSLL512Bcl	83.152	3152.584	2.431321
SumSLL512Traits	82.006	3196.645	2.465302
SumSLLFast_AdvSimd	114.658	2286.322	1.763246
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	115.418	2271.258	1.751628

```

## Wasm

### Wasm on AMD Ryzen 7 7840H
``

#### .NET 8.0

```
VectorTraits.Benchmarks.Wasm


IsRelease:	True
Environment.ProcessorCount:	1
Environment.Is64BitProcess:	False
Environment.OSVersion:	Other 1.0.0.0
Environment.Version:	8.0.7
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/
RuntimeInformation.FrameworkDescription:	.NET 8.0.7
RuntimeInformation.OSArchitecture:	Wasm
RuntimeInformation.OSDescription:	Browser
RuntimeInformation.RuntimeIdentifier:	browser-wasm
IntPtr.Size:	4
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	False
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
Vector128.IsHardwareAccelerated:	True
Vector256.IsHardwareAccelerated:	False
Vector512.IsHardwareAccelerated:	False
Vector<T>.Assembly.CodeBase:	
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 8.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 8.0
VectorTraitsGlobal.InitCheckSum:	-2122844158	# 0x8177F802
VectorEnvironment.CpuModelName:	
VectorEnvironment.SupportedInstructionSets:	PackedSimd
Vector128s.Instance:	WVectorTraits128PackedSimd	// PackedSimd
Vectors.Instance:	VectorTraits128PackedSimd	// PackedSimd
Vectors.BaseInstance:	VectorTraits128Base


[ShiftLeftConstBenchmark_Byte(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	228
SumSLLScalar	7542.708	34.755
SumSLLNetBcl	790.625	331.566	9.540184
SumSLLNetBcl_Const	824.674	317.876	9.146286
SumSLL_Basic	806.315	325.114	9.354542
SumSLL_Base_Core	781.966	335.237	9.645825
SumSLL_Multiply	11892.708	22.042	0.634230
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	999.154	262.366	7.549098
SumSLLTraits_Core	1050.781	249.475	7.178191
SumSLLConstTraits	1089.453	240.620	6.923389
SumSLLConstTraits_Core	1028.385	254.908	7.334515
SumSLL128Bcl	795.312	329.611	9.483955
SumSLL128Traits	781.901	335.265	9.646628
SumSLL128Traits_Core	806.250	325.140	9.355297
SumSLL128ConstTraits	822.396	318.756	9.171628
SumSLL128ConstTraits_Core	838.021	312.813	9.000622
SumSLL512Bcl	4043.229	64.835	1.865516
SumSLL512Traits	5682.813	46.129	1.327284
SumSLLFast_Multiply	11489.583	22.816	0.656482
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	1029.167	254.715	7.328947

[ShiftLeftConstBenchmark_Int16(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	16308
SumSLLScalar	7755.208	33.802
SumSLLNetBcl	1555.339	168.545	4.986187
SumSLLNetBcl_Const	1632.161	160.612	4.751496
SumSLL_Basic	1607.292	163.097	4.825016
SumSLL_Base_Core	1526.172	171.766	5.081478
SumSLL_Base_Core_Element	2413.542	108.614	3.213207
SumSLL_Base_Core_Mov	2505.729	104.618	3.094991
SumSLL_Multiply	13777.083	19.028	0.562906
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	2141.667	122.402	3.621109
SumSLLTraits_Core	2062.240	127.116	3.760576
SumSLLConstTraits	2148.438	122.016	3.609697
SumSLLConstTraits_Core	2150.521	121.898	3.606200
SumSLL128Bcl	1579.818	165.933	4.908926
SumSLL128Traits	1555.339	168.545	4.986187
SumSLL128Traits_Core	1554.688	168.615	4.988275
SumSLL128ConstTraits	1686.328	155.453	4.598873
SumSLL128ConstTraits_Core	1680.339	156.007	4.615265
SumSLL512Bcl	8341.667	31.426	0.929695
SumSLL512Traits	7979.167	32.854	0.971932
SumSLLFast_Multiply	13484.375	19.441	0.575126
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	2064.844	126.956	3.755833

[ShiftLeftConstBenchmark_Int32(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-935510092
SumSLLScalar	5399.479	48.550
SumSLLNetBcl	3123.438	83.928	1.728698
SumSLLNetBcl_Const	3329.167	78.742	1.621871
SumSLL_Basic	2938.542	89.209	1.837469
SumSLL_Base_Core	3149.219	83.241	1.714546
SumSLL_Multiply	16164.583	16.217	0.334031
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	4131.771	63.446	1.306820
SumSLLTraits_Core	4110.417	63.776	1.313609
SumSLLConstTraits	4240.104	61.825	1.273431
SumSLLConstTraits_Core	4226.042	62.031	1.277668
SumSLL128Bcl	3120.052	84.019	1.730573
SumSLL128Traits	3125.781	83.865	1.727401
SumSLL128Traits_Core	3209.896	81.667	1.682135
SumSLL128ConstTraits	3218.490	81.449	1.677644
SumSLL128ConstTraits_Core	3315.625	79.063	1.628495
SumSLL512Bcl	16477.083	15.910	0.327696
SumSLL512Traits	15575.000	16.831	0.346676
SumSLLFast_Multiply	15337.500	17.092	0.352044
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	3756.250	69.789	1.437465

[ShiftLeftConstBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumSLLScalar	-6625999546565534712
Check-SumSLL_Base_Bit32_Or	Check `SumSLL_Base_Bit32_Or` mismatch. 6667559474292588544!=-6625999546565534712
SumSLLScalar	5950.000	44.058
SumSLLNetBcl	23891.667	10.972	0.249041
SumSLLNetBcl_Const	24952.083	10.506	0.238457
SumSLL_Base_Bit32_Or	1186450.000	0.221	0.005015
SumSLL_Basic	24989.583	10.490	0.238099
SumSLL_Base_Core	25237.500	10.387	0.235760
SumSLL_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumSLL_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLTraits	12697.917	20.645	0.468581
SumSLLTraits_Core	12612.500	20.784	0.471754
SumSLLConstTraits	12585.417	20.829	0.472769
SumSLLConstTraits_Core	13137.500	19.954	0.452902
SumSLL128Bcl	54604.167	4.801	0.108966
SumSLL128Traits	6188.021	42.363	0.961535
SumSLL128Traits_Core	6135.937	42.723	0.969697
SumSLL128ConstTraits	6672.396	39.288	0.891734
SumSLL128ConstTraits_Core	6727.083	38.968	0.884484
SumSLL512Bcl	78533.333	3.338	0.075764
SumSLL512Traits	37154.167	7.056	0.160144
SumSLLFast_AdvSimd	Run fail! Requires hardware support AdvSimd!
SumSLLFast_Avx2	Run fail! Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
SumSLLFastTraits	26602.083	9.854	0.223667

```

