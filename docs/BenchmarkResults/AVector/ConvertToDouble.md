# Benchmark - ConvertToDouble
([← Back](README.md))

## x86

### lntel Core i5-8250U
`lntel(R) Core(TM) i5-8250U CPU @ 1.60GHz`

#### .NET Framework 
``` 
VectorTraits.Benchmarks.NetFw
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 6.2.9200.0
Environment.Version:	4.0.30319.42000
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Windows\Microsoft.NET\Framework64\v4.0.30319\
RuntimeInformation.FrameworkDescription:	.NET Framework 4.8.4644.0
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045 
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	-25396098	# 0xFE7C7C7E
Vector<T>.Assembly.CodeBase:	file:///E:/zylSelf/Code/cs/base/VectorTraits/tests/VectorTraits.Benchmarks.NetFw/bin/Release/System.Numerics.Vectors.DLL
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 1.1
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Framework 4.5
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.259163328783E+21
# SumBcl	-3.25916332878302E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.25916332878302E+21
SumScalar	312.726	838.254
SumBcl	199.435	1314.436	1.568065
SumBase_Range52_Impl	80.353	3262.423	3.891928
SumTraits	199.210	1315.921	1.569836
SumTraits_Range52	200.233	1309.193	1.561810

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.62582413852437E+24
# SumBcl	3.62582413852431E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.62582413852431E+24
SumScalar	712.888	367.721
SumBcl	139.547	1878.541	5.108605
SumBase_Range52_Impl	80.509	3256.065	8.854718
SumTraits	139.858	1874.359	5.097233
SumTraits_Range52	118.117	2219.357	6.035439

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!
[Vectors.Instance: VectorTraits256Base]
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	None	# (00000000)
ConvertToDouble_AcceleratedTypes:	None	# (00000000)
ConvertToInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToInt64_AcceleratedTypes:	None	# (00000000)
ConvertToSingle_AcceleratedTypes:	Int32	# (00000200)
ConvertToUInt32_AcceleratedTypes:	None	# (00000000)
ConvertToUInt64_AcceleratedTypes:	None	# (00000000)
ExtractMostSignificantBits_AcceleratedTypes:	None	# (00000000)
Floor_AcceleratedTypes:	None	# (00000000)
Instance:	Zyl.VectorTraits.Impl.AVector.VectorTraits256Base
IsSupported:	True
Multiply_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Single	# (00002780)
Multiply_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32, Single	# (00002780)
Narrow_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
ShiftLeft_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32	# (000007E0)
ShiftRightArithmetic_AcceleratedTypes:	None	# (00000000)
ShiftRightLogical_AcceleratedTypes:	None	# (00000000)
Shuffle_AcceleratedTypes:	None	# (00000000)
Sum_AcceleratedTypes:	None	# (00000000)
Widen_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32	# (000007E0)
YClamp_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YNarrowSaturate_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturate_FullAcceleratedTypes:	None	# (00000000)
YNarrowSaturateUnsigned_AcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	None	# (00000000)
YShuffleG2_AcceleratedTypes:	None	# (00000000)
YShuffleG4_AcceleratedTypes:	None	# (00000000)
YShuffleG4X2_AcceleratedTypes:	None	# (00000000)
YShuffleInsert_AcceleratedTypes:	None	# (00000000)
YShuffleKernel_AcceleratedTypes:	None	# (00000000)

``` 

#### .NET Core 2.1 
``` 
VectorTraits.Benchmarks.NetCore
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
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
VectorTraitsGlobal.InitCheckSum:	-25396098	# 0xFE7C7C7E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/2.1.30/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Standard 2.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 2.1
Vectors.Instance:	VectorTraits256Base
Vectors.BaseInstance:	VectorTraits256Base


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.259163328783E+21
# SumBcl	-3.25916332878302E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.25916332878302E+21
SumScalar	315.457	830.999
SumBcl	202.678	1293.398	1.556439
SumBase_Range52_Impl	82.072	3194.079	3.843663
SumTraits	202.475	1294.700	1.558005
SumTraits_Range52	203.772	1286.459	1.548087

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.62582413852437E+24
# SumBcl	3.62582413852431E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.62582413852431E+24
SumScalar	716.611	365.811
SumBcl	117.739	2226.478	6.086422
SumBase_Range52_Impl	81.646	3210.748	8.777075
SumTraits	114.786	2283.755	6.242998
SumTraits_Range52	138.514	1892.546	5.173567

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Vector128 type is not supported! Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: Vector256 type is not supported! Requires hardware support Avx, Avx2!
[Vectors.Instance: VectorTraits256Base]
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	None	# (00000000)
ConvertToDouble_AcceleratedTypes:	None	# (00000000)
ConvertToInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToInt64_AcceleratedTypes:	None	# (00000000)
ConvertToSingle_AcceleratedTypes:	Int32	# (00000200)
ConvertToUInt32_AcceleratedTypes:	None	# (00000000)
ConvertToUInt64_AcceleratedTypes:	None	# (00000000)
ExtractMostSignificantBits_AcceleratedTypes:	None	# (00000000)
Floor_AcceleratedTypes:	None	# (00000000)
IsSupported:	True
Multiply_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Single	# (00002780)
Multiply_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32, Single	# (00002780)
Narrow_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
ShiftLeft_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32	# (000007E0)
ShiftRightArithmetic_AcceleratedTypes:	None	# (00000000)
ShiftRightLogical_AcceleratedTypes:	None	# (00000000)
Shuffle_AcceleratedTypes:	None	# (00000000)
Sum_AcceleratedTypes:	None	# (00000000)
Widen_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32	# (000007E0)
YClamp_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YNarrowSaturate_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturate_FullAcceleratedTypes:	None	# (00000000)
YNarrowSaturateUnsigned_AcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	None	# (00000000)
YShuffleG2_AcceleratedTypes:	None	# (00000000)
YShuffleG4_AcceleratedTypes:	None	# (00000000)
YShuffleG4X2_AcceleratedTypes:	None	# (00000000)
YShuffleInsert_AcceleratedTypes:	None	# (00000000)
YShuffleKernel_AcceleratedTypes:	None	# (00000000)

``` 

#### .NET Core 3.1 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
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
VectorTraitsGlobal.InitCheckSum:	7960958	# 0x0079797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/3.1.32/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783021E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
SumScalar	313.929	835.043
SumBcl	199.900	1311.373	1.570426
SumBase_Range52_Impl	82.263	3186.651	3.816151
SumTraits	123.080	2129.859	2.550597
SumTraits_Range52	82.216	3188.483	3.818345
Sum128Base_Basic	1684.831	155.591	0.186326
Sum128Base	1681.353	155.913	0.186712
Sum128Base_Range52_Impl	1678.340	156.192	0.187047
Sum128Traits	1678.805	156.149	0.186995
Sum128Traits_Range52	1675.748	156.434	0.187336
Sum256Base_Basic	508.530	515.494	0.617326
Sum256Base	515.158	508.862	0.609384
Sum256Base_Range52_Impl	507.961	516.071	0.618017
Sum256Avx2_Bcl	121.147	2163.855	2.591309
Sum256Avx2_HwScalar	199.030	1317.109	1.577294
Sum256Avx2_Range52	80.393	3260.786	3.904931
Sum256Traits	121.953	2149.542	2.574168
Sum256Traits_Range52	80.171	3269.802	3.915728

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524307E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base	Check `Sum128Base` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits	Check `Sum128Traits` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=3.625824138524307E+24
SumScalar	713.432	367.441
SumBcl	104.564	2507.009	6.822889
SumBase_Range52_Impl	81.104	3232.187	8.796480
SumTraits	122.160	2145.908	5.840144
SumTraits_Range52	81.402	3220.351	8.764267
Sum128Base_Basic	1731.762	151.374	0.411969
Sum128Base	1727.593	151.739	0.412963
Sum128Base_Range52_Impl	1723.903	152.064	0.413847
Sum128Traits	1722.040	152.229	0.414294
Sum128Traits_Range52	1718.850	152.511	0.415063
Sum256Base_Basic	840.859	311.757	0.848456
Sum256Base	838.891	312.489	0.850447
Sum256Base_Range52_Impl	845.427	310.073	0.843871
Sum256Avx2_Bcl	119.433	2194.900	5.973477
Sum256Avx2_Range52	79.295	3305.933	8.997183
Sum256Traits	122.346	2142.640	5.831250
Sum256Traits_Range52	81.170	3229.566	8.789346

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
[Vectors.Instance: VectorTraits256Avx2]
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	Single, Double	# (00006000)
ConvertToDouble_AcceleratedTypes:	Int64, UInt64	# (00001800)
ConvertToInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToInt64_AcceleratedTypes:	None	# (00000000)
ConvertToSingle_AcceleratedTypes:	Int32, UInt32	# (00000600)
ConvertToUInt32_AcceleratedTypes:	None	# (00000000)
ConvertToUInt64_AcceleratedTypes:	None	# (00000000)
ExtractMostSignificantBits_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Floor_AcceleratedTypes:	Single, Double	# (00006000)
IsSupported:	True
Multiply_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Multiply_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32, Single, Double	# (00006780)
Narrow_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64, Double	# (00005F80)
ShiftLeft_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
ShiftRightArithmetic_AcceleratedTypes:	SByte, Int16, Int32, Int64	# (00000AA0)
ShiftRightLogical_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
Shuffle_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Sum_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Widen_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single	# (000027E0)
YClamp_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YNarrowSaturate_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturate_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32	# (00000780)
YNarrowSaturateUnsigned_AcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	Int16, Int32	# (00000280)
YShuffleG2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4X2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleInsert_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleKernel_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)

WVectorTraits128Base: OK.
WVectorTraits128AdvSimd: Requires hardware support AdvSimd!
WVectorTraits128AdvSimdB64: Requires hardware support AdvSimd!
[Vector128s.Instance: WVectorTraits128Base]
Abs_AcceleratedTypes:	None	# (00000000)
Add_AcceleratedTypes:	None	# (00000000)
AndNot_AcceleratedTypes:	None	# (00000000)
BitwiseAnd_AcceleratedTypes:	None	# (00000000)
BitwiseOr_AcceleratedTypes:	None	# (00000000)
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	None	# (00000000)
ConditionalSelect_AcceleratedTypes:	None	# (00000000)
ConvertToDouble_AcceleratedTypes:	None	# (00000000)
ConvertToInt32_AcceleratedTypes:	None	# (00000000)
ConvertToInt64_AcceleratedTypes:	None	# (00000000)
ConvertToSingle_AcceleratedTypes:	None	# (00000000)
ConvertToUInt32_AcceleratedTypes:	None	# (00000000)
ConvertToUInt64_AcceleratedTypes:	None	# (00000000)
Divide_AcceleratedTypes:	None	# (00000000)
ExtractMostSignificantBits_AcceleratedTypes:	None	# (00000000)
Floor_AcceleratedTypes:	None	# (00000000)
GreaterThan_AcceleratedTypes:	None	# (00000000)
IsSupported:	True
LessThan_AcceleratedTypes:	None	# (00000000)
Max_AcceleratedTypes:	None	# (00000000)
Min_AcceleratedTypes:	None	# (00000000)
Multiply_AcceleratedTypes:	None	# (00000000)
Multiply_FullAcceleratedTypes:	None	# (00000000)
Narrow_AcceleratedTypes:	None	# (00000000)
Negate_AcceleratedTypes:	None	# (00000000)
OnesComplement_AcceleratedTypes:	None	# (00000000)
ShiftLeft_AcceleratedTypes:	None	# (00000000)
ShiftRightArithmetic_AcceleratedTypes:	None	# (00000000)
ShiftRightLogical_AcceleratedTypes:	None	# (00000000)
Shuffle_AcceleratedTypes:	None	# (00000000)
Subtract_AcceleratedTypes:	None	# (00000000)
Sum_AcceleratedTypes:	None	# (00000000)
Widen_AcceleratedTypes:	None	# (00000000)
Xor_AcceleratedTypes:	None	# (00000000)
YClamp_AcceleratedTypes:	None	# (00000000)
YNarrowSaturate_AcceleratedTypes:	None	# (00000000)
YNarrowSaturate_FullAcceleratedTypes:	None	# (00000000)
YNarrowSaturateUnsigned_AcceleratedTypes:	None	# (00000000)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	None	# (00000000)
YShuffleG2_AcceleratedTypes:	None	# (00000000)
YShuffleG4_AcceleratedTypes:	None	# (00000000)
YShuffleG4X2_AcceleratedTypes:	None	# (00000000)
YShuffleInsert_AcceleratedTypes:	None	# (00000000)
YShuffleKernel_AcceleratedTypes:	None	# (00000000)

WVectorTraits256Base: OK.
WVectorTraits256Avx2: OK.
[Vector256s.Instance: WVectorTraits256Avx2]
Abs_AcceleratedTypes:	SByte, Int16, Int32, Int64, Single, Double	# (00006AA0)
Add_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
AndNot_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
BitwiseAnd_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
BitwiseOr_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	Single, Double	# (00006000)
ConditionalSelect_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ConvertToDouble_AcceleratedTypes:	Int64, UInt64	# (00001800)
ConvertToInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToInt64_AcceleratedTypes:	None	# (00000000)
ConvertToSingle_AcceleratedTypes:	Int32, UInt32	# (00000600)
ConvertToUInt32_AcceleratedTypes:	None	# (00000000)
ConvertToUInt64_AcceleratedTypes:	None	# (00000000)
Divide_AcceleratedTypes:	Single, Double	# (00006000)
ExtractMostSignificantBits_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Floor_AcceleratedTypes:	Single, Double	# (00006000)
GreaterThan_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
IsSupported:	True
LessThan_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Max_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Min_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Multiply_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Multiply_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32, Single, Double	# (00006780)
Narrow_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64, Double	# (00005F80)
Negate_AcceleratedTypes:	SByte, Int16, Int32, Int64, Single, Double	# (00006AA0)
OnesComplement_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ShiftLeft_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
ShiftRightArithmetic_AcceleratedTypes:	SByte, Int16, Int32, Int64	# (00000AA0)
ShiftRightLogical_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
Shuffle_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Subtract_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Sum_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Widen_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single	# (000027E0)
Xor_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YClamp_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YNarrowSaturate_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturate_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32	# (00000780)
YNarrowSaturateUnsigned_AcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	Int16, Int32	# (00000280)
YShuffleG2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4X2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleInsert_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleKernel_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)

``` 

#### .NET 5.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
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
VectorTraitsGlobal.InitCheckSum:	7960958	# 0x0079797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783021E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
SumScalar	315.836	829.999
SumBcl	203.148	1290.411	1.554714
SumBase_Range52_Impl	80.650	3250.393	3.916139
SumTraits	90.608	2893.155	3.485733
SumTraits_Range52	80.116	3272.041	3.942221
Sum128Base_Basic	1637.564	160.082	0.192870
Sum128Base	1637.519	160.086	0.192875
Sum128Base_Range52_Impl	1638.930	159.948	0.192709
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1634.871	160.345	0.193187
Sum128Traits_Range52	1641.808	159.668	0.192371
Sum256Base_Basic	531.755	492.979	0.593951
Sum256Base	531.196	493.497	0.594576
Sum256Base_Range52_Impl	530.370	494.266	0.595502
Sum256Avx2_Bcl	89.273	2936.417	3.537855
Sum256Avx2_HwScalar	199.510	1313.936	1.583057
Sum256Avx2_Range52	79.560	3294.902	3.969766
Sum256Traits	88.890	2949.079	3.553110
Sum256Traits_Range52	80.360	3262.106	3.930252

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524307E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base	Check `Sum128Base` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits	Check `Sum128Traits` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=3.625824138524307E+24
SumScalar	707.026	370.770
SumBcl	115.438	2270.872	6.124746
SumBase_Range52_Impl	79.729	3287.941	8.867873
SumTraits	89.580	2926.359	7.892654
SumTraits_Range52	79.602	3293.186	8.882020
Sum128Base_Basic	1711.671	153.151	0.413062
Sum128Base	1716.190	152.748	0.411974
Sum128Base_Range52_Impl	1713.811	152.960	0.412546
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1731.181	151.425	0.408407
Sum128Traits_Range52	1742.562	150.436	0.405739
Sum256Base_Basic	911.142	287.709	0.775978
Sum256Base	884.163	296.488	0.799656
Sum256Base_Range52_Impl	887.518	295.367	0.796632
Sum256Avx2_Bcl	90.313	2902.628	7.828649
Sum256Avx2_Range52	80.943	3238.619	8.734847
Sum256Traits	91.026	2879.888	7.767318
Sum256Traits_Range52	80.148	3270.749	8.821503

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
[Vectors.Instance: VectorTraits256Avx2]
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	Single, Double	# (00006000)
ConvertToDouble_AcceleratedTypes:	Int64, UInt64	# (00001800)
ConvertToInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToInt64_AcceleratedTypes:	None	# (00000000)
ConvertToSingle_AcceleratedTypes:	Int32, UInt32	# (00000600)
ConvertToUInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToUInt64_AcceleratedTypes:	None	# (00000000)
ExtractMostSignificantBits_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Floor_AcceleratedTypes:	Single, Double	# (00006000)
IsSupported:	True
Multiply_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Multiply_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32, Single, Double	# (00006780)
Narrow_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64, Double	# (00005F80)
ShiftLeft_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
ShiftRightArithmetic_AcceleratedTypes:	SByte, Int16, Int32, Int64	# (00000AA0)
ShiftRightLogical_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
Shuffle_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Sum_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Widen_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single	# (000027E0)
YClamp_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YNarrowSaturate_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturate_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32	# (00000780)
YNarrowSaturateUnsigned_AcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	Int16, Int32	# (00000280)
YShuffleG2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4X2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleInsert_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleKernel_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)

WVectorTraits128Base: OK.
WVectorTraits128AdvSimd: Requires hardware support AdvSimd!
WVectorTraits128AdvSimdB64: Requires hardware support AdvSimd!
[Vector128s.Instance: WVectorTraits128Base]
Abs_AcceleratedTypes:	None	# (00000000)
Add_AcceleratedTypes:	None	# (00000000)
AndNot_AcceleratedTypes:	None	# (00000000)
BitwiseAnd_AcceleratedTypes:	None	# (00000000)
BitwiseOr_AcceleratedTypes:	None	# (00000000)
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	None	# (00000000)
ConditionalSelect_AcceleratedTypes:	None	# (00000000)
ConvertToDouble_AcceleratedTypes:	None	# (00000000)
ConvertToInt32_AcceleratedTypes:	None	# (00000000)
ConvertToInt64_AcceleratedTypes:	None	# (00000000)
ConvertToSingle_AcceleratedTypes:	None	# (00000000)
ConvertToUInt32_AcceleratedTypes:	None	# (00000000)
ConvertToUInt64_AcceleratedTypes:	None	# (00000000)
Divide_AcceleratedTypes:	None	# (00000000)
ExtractMostSignificantBits_AcceleratedTypes:	None	# (00000000)
Floor_AcceleratedTypes:	None	# (00000000)
GreaterThan_AcceleratedTypes:	None	# (00000000)
IsSupported:	True
LessThan_AcceleratedTypes:	None	# (00000000)
Max_AcceleratedTypes:	None	# (00000000)
Min_AcceleratedTypes:	None	# (00000000)
Multiply_AcceleratedTypes:	None	# (00000000)
Multiply_FullAcceleratedTypes:	None	# (00000000)
Narrow_AcceleratedTypes:	None	# (00000000)
Negate_AcceleratedTypes:	None	# (00000000)
OnesComplement_AcceleratedTypes:	None	# (00000000)
ShiftLeft_AcceleratedTypes:	None	# (00000000)
ShiftRightArithmetic_AcceleratedTypes:	None	# (00000000)
ShiftRightLogical_AcceleratedTypes:	None	# (00000000)
Shuffle_AcceleratedTypes:	None	# (00000000)
Subtract_AcceleratedTypes:	None	# (00000000)
Sum_AcceleratedTypes:	None	# (00000000)
Widen_AcceleratedTypes:	None	# (00000000)
Xor_AcceleratedTypes:	None	# (00000000)
YClamp_AcceleratedTypes:	None	# (00000000)
YNarrowSaturate_AcceleratedTypes:	None	# (00000000)
YNarrowSaturate_FullAcceleratedTypes:	None	# (00000000)
YNarrowSaturateUnsigned_AcceleratedTypes:	None	# (00000000)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	None	# (00000000)
YShuffleG2_AcceleratedTypes:	None	# (00000000)
YShuffleG4_AcceleratedTypes:	None	# (00000000)
YShuffleG4X2_AcceleratedTypes:	None	# (00000000)
YShuffleInsert_AcceleratedTypes:	None	# (00000000)
YShuffleKernel_AcceleratedTypes:	None	# (00000000)

WVectorTraits256Base: OK.
WVectorTraits256Avx2: OK.
[Vector256s.Instance: WVectorTraits256Avx2]
Abs_AcceleratedTypes:	SByte, Int16, Int32, Int64, Single, Double	# (00006AA0)
Add_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
AndNot_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
BitwiseAnd_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
BitwiseOr_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	Single, Double	# (00006000)
ConditionalSelect_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ConvertToDouble_AcceleratedTypes:	Int64, UInt64	# (00001800)
ConvertToInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToInt64_AcceleratedTypes:	None	# (00000000)
ConvertToSingle_AcceleratedTypes:	Int32, UInt32	# (00000600)
ConvertToUInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToUInt64_AcceleratedTypes:	None	# (00000000)
Divide_AcceleratedTypes:	Single, Double	# (00006000)
ExtractMostSignificantBits_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Floor_AcceleratedTypes:	Single, Double	# (00006000)
GreaterThan_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
IsSupported:	True
LessThan_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Max_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Min_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Multiply_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Multiply_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32, Single, Double	# (00006780)
Narrow_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64, Double	# (00005F80)
Negate_AcceleratedTypes:	SByte, Int16, Int32, Int64, Single, Double	# (00006AA0)
OnesComplement_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ShiftLeft_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
ShiftRightArithmetic_AcceleratedTypes:	SByte, Int16, Int32, Int64	# (00000AA0)
ShiftRightLogical_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
Shuffle_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Subtract_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Sum_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Widen_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single	# (000027E0)
Xor_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YClamp_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YNarrowSaturate_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturate_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32	# (00000780)
YNarrowSaturateUnsigned_AcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	Int16, Int32	# (00000280)
YShuffleG2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4X2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleInsert_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleKernel_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)

``` 

#### .NET 6.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	6.0.14
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\6.0.14\
RuntimeInformation.FrameworkDescription:	.NET 6.0.14
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	7960958	# 0x0079797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/6.0.14/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783021E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
SumScalar	314.138	834.486
SumBcl	199.079	1316.785	1.577959
SumBase_Range52_Impl	79.795	3285.232	3.936833
SumTraits	82.455	3179.249	3.809829
SumTraits_Range52	79.500	3297.409	3.951426
Sum128Base_Basic	1636.197	160.215	0.191993
Sum128Base	1635.488	160.285	0.192076
Sum128Base_Range52_Impl	1640.482	159.797	0.191491
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1634.440	160.388	0.192199
Sum128Traits_Range52	1641.287	159.719	0.191398
Sum256Base_Basic	508.616	515.407	0.617634
Sum256Base	508.968	515.050	0.617206
Sum256Base_Range52_Impl	509.887	514.122	0.616094
Sum256Avx2_Bcl	82.010	3196.507	3.830509
Sum256Avx2_HwScalar	199.035	1317.077	1.578309
Sum256Avx2_Range52	79.496	3297.567	3.951614
Sum256Traits	81.593	3212.808	3.850044
Sum256Traits_Range52	79.959	3278.500	3.928766

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524307E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base	Check `Sum128Base` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits	Check `Sum128Traits` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=3.625824138524307E+24
SumScalar	707.914	370.305
SumBcl	117.698	2227.251	6.014640
SumBase_Range52_Impl	80.330	3263.328	8.812544
SumTraits	82.075	3193.961	8.625219
SumTraits_Range52	79.577	3294.228	8.895988
Sum128Base_Basic	1708.866	153.402	0.414260
Sum128Base	1709.022	153.388	0.414222
Sum128Base_Range52_Impl	1708.169	153.465	0.414428
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	1710.132	153.289	0.413953
Sum128Traits_Range52	1712.556	153.072	0.413367
Sum256Base_Basic	881.135	297.507	0.803411
Sum256Base	888.661	294.987	0.796607
Sum256Base_Range52_Impl	884.946	296.226	0.799952
Sum256Avx2_Bcl	82.188	3189.548	8.613302
Sum256Avx2_Range52	79.541	3295.698	8.899957
Sum256Traits	81.602	3212.489	8.675254
Sum256Traits_Range52	79.896	3281.055	8.860413

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
[Vectors.Instance: VectorTraits256Avx2]
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	Single, Double	# (00006000)
ConvertToDouble_AcceleratedTypes:	Int64, UInt64	# (00001800)
ConvertToInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToInt64_AcceleratedTypes:	None	# (00000000)
ConvertToSingle_AcceleratedTypes:	Int32, UInt32	# (00000600)
ConvertToUInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToUInt64_AcceleratedTypes:	None	# (00000000)
ExtractMostSignificantBits_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Floor_AcceleratedTypes:	Single, Double	# (00006000)
IsSupported:	True
Multiply_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Multiply_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32, Single, Double	# (00006780)
Narrow_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64, Double	# (00005F80)
ShiftLeft_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
ShiftRightArithmetic_AcceleratedTypes:	SByte, Int16, Int32, Int64	# (00000AA0)
ShiftRightLogical_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
Shuffle_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Sum_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Widen_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single	# (000027E0)
YClamp_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YNarrowSaturate_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturate_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32	# (00000780)
YNarrowSaturateUnsigned_AcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	Int16, Int32	# (00000280)
YShuffleG2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4X2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleInsert_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleKernel_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)

WVectorTraits128Base: OK.
WVectorTraits128AdvSimd: Requires hardware support AdvSimd!
WVectorTraits128AdvSimdB64: Requires hardware support AdvSimd!
[Vector128s.Instance: WVectorTraits128Base]
Abs_AcceleratedTypes:	None	# (00000000)
Add_AcceleratedTypes:	None	# (00000000)
AndNot_AcceleratedTypes:	None	# (00000000)
BitwiseAnd_AcceleratedTypes:	None	# (00000000)
BitwiseOr_AcceleratedTypes:	None	# (00000000)
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	None	# (00000000)
ConditionalSelect_AcceleratedTypes:	None	# (00000000)
ConvertToDouble_AcceleratedTypes:	None	# (00000000)
ConvertToInt32_AcceleratedTypes:	None	# (00000000)
ConvertToInt64_AcceleratedTypes:	None	# (00000000)
ConvertToSingle_AcceleratedTypes:	None	# (00000000)
ConvertToUInt32_AcceleratedTypes:	None	# (00000000)
ConvertToUInt64_AcceleratedTypes:	None	# (00000000)
Divide_AcceleratedTypes:	None	# (00000000)
ExtractMostSignificantBits_AcceleratedTypes:	None	# (00000000)
Floor_AcceleratedTypes:	None	# (00000000)
GreaterThan_AcceleratedTypes:	None	# (00000000)
IsSupported:	True
LessThan_AcceleratedTypes:	None	# (00000000)
Max_AcceleratedTypes:	None	# (00000000)
Min_AcceleratedTypes:	None	# (00000000)
Multiply_AcceleratedTypes:	None	# (00000000)
Multiply_FullAcceleratedTypes:	None	# (00000000)
Narrow_AcceleratedTypes:	None	# (00000000)
Negate_AcceleratedTypes:	None	# (00000000)
OnesComplement_AcceleratedTypes:	None	# (00000000)
ShiftLeft_AcceleratedTypes:	None	# (00000000)
ShiftRightArithmetic_AcceleratedTypes:	None	# (00000000)
ShiftRightLogical_AcceleratedTypes:	None	# (00000000)
Shuffle_AcceleratedTypes:	None	# (00000000)
Subtract_AcceleratedTypes:	None	# (00000000)
Sum_AcceleratedTypes:	None	# (00000000)
Widen_AcceleratedTypes:	None	# (00000000)
Xor_AcceleratedTypes:	None	# (00000000)
YClamp_AcceleratedTypes:	None	# (00000000)
YNarrowSaturate_AcceleratedTypes:	None	# (00000000)
YNarrowSaturate_FullAcceleratedTypes:	None	# (00000000)
YNarrowSaturateUnsigned_AcceleratedTypes:	None	# (00000000)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	None	# (00000000)
YShuffleG2_AcceleratedTypes:	None	# (00000000)
YShuffleG4_AcceleratedTypes:	None	# (00000000)
YShuffleG4X2_AcceleratedTypes:	None	# (00000000)
YShuffleInsert_AcceleratedTypes:	None	# (00000000)
YShuffleKernel_AcceleratedTypes:	None	# (00000000)

WVectorTraits256Base: OK.
WVectorTraits256Avx2: OK.
[Vector256s.Instance: WVectorTraits256Avx2]
Abs_AcceleratedTypes:	SByte, Int16, Int32, Int64, Single, Double	# (00006AA0)
Add_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
AndNot_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
BitwiseAnd_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
BitwiseOr_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	Single, Double	# (00006000)
ConditionalSelect_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ConvertToDouble_AcceleratedTypes:	Int64, UInt64	# (00001800)
ConvertToInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToInt64_AcceleratedTypes:	None	# (00000000)
ConvertToSingle_AcceleratedTypes:	Int32, UInt32	# (00000600)
ConvertToUInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToUInt64_AcceleratedTypes:	None	# (00000000)
Divide_AcceleratedTypes:	Single, Double	# (00006000)
ExtractMostSignificantBits_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Floor_AcceleratedTypes:	Single, Double	# (00006000)
GreaterThan_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
IsSupported:	True
LessThan_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Max_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Min_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Multiply_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Multiply_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32, Single, Double	# (00006780)
Narrow_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64, Double	# (00005F80)
Negate_AcceleratedTypes:	SByte, Int16, Int32, Int64, Single, Double	# (00006AA0)
OnesComplement_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ShiftLeft_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
ShiftRightArithmetic_AcceleratedTypes:	SByte, Int16, Int32, Int64	# (00000AA0)
ShiftRightLogical_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
Shuffle_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Subtract_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Sum_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Widen_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single	# (000027E0)
Xor_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YClamp_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YNarrowSaturate_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturate_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32	# (00000780)
YNarrowSaturateUnsigned_AcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	Int16, Int32	# (00000280)
YShuffleG2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4X2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleInsert_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleKernel_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)

``` 

#### .NET 7.0 
``` 
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	Intel64 Family 6 Model 142 Stepping 10, GenuineIntel
Environment.ProcessorCount:	8
Environment.Is64BitProcess:	True
Environment.OSVersion:	Microsoft Windows NT 10.0.19045.0
Environment.Version:	7.0.3
Stopwatch.Frequency:	10000000
RuntimeEnvironment.GetRuntimeDirectory:	C:\Program Files\dotnet\shared\Microsoft.NETCore.App\7.0.3\
RuntimeInformation.FrameworkDescription:	.NET 7.0.3
RuntimeInformation.OSArchitecture:	X64
RuntimeInformation.OSDescription:	Microsoft Windows 10.0.19045
RuntimeInformation.RuntimeIdentifier:	win10-x64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	32	# 256bit
Vector<float>.Count:	8	# 256bit
VectorTraitsGlobal.InitCheckSum:	7960958	# 0x0079797E
Vector<T>.Assembly.CodeBase:	file:///C:/Program Files/dotnet/shared/Microsoft.NETCore.App/7.0.3/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits256Avx2
Vectors.BaseInstance:	VectorTraits256Base


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783021E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base	Check `Sum128Base` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-Sum128Traits	Check `Sum128Traits` mismatch. -3.259163328783052E+21!=-3.259163328783021E+21
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=-3.259163328783021E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=-3.259163328783021E+21
SumScalar	313.464	836.280
SumBcl	80.786	3244.933	3.880199
SumBase_Range52_Impl	79.444	3299.744	3.945740
SumTraits	79.887	3281.454	3.923869
SumTraits_Range52	79.697	3289.262	3.933206
Sum128Bcl	157.538	1664.008	1.989773
Sum128Base_Basic	877.964	298.582	0.357035
Sum128Base	160.001	1638.395	1.959146
Sum128Base_Range52_Impl	158.134	1657.729	1.982265
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	158.738	1651.429	1.974732
Sum128Traits_Range52	157.645	1662.872	1.988415
Sum256Bcl	84.352	3107.749	3.716158
Sum256Base_Basic	507.979	516.052	0.617081
Sum256Base	80.672	3249.519	3.885683
Sum256Base_Range52_Impl	79.805	3284.809	3.927881
Sum256Avx2_Bcl	80.706	3248.153	3.884050
Sum256Avx2_HwScalar	197.750	1325.635	1.585156
Sum256Avx2_Range52	80.285	3265.173	3.904401
Sum256Traits	88.348	2967.179	3.548068
Sum256Traits_Range52	81.086	3232.894	3.865803

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524307E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-SumTraits_Range52	Check `SumTraits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum128Bcl	Check `Sum128Bcl` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base_Basic	Check `Sum128Base_Basic` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base	Check `Sum128Base` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-Sum128Traits	Check `Sum128Traits` mismatch. 3.625824138524267E+24!=3.625824138524307E+24
Check-Sum128Traits_Range52	Check `Sum128Traits_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Avx2_Range52	Check `Sum256Avx2_Range52` mismatch. NaN!=3.625824138524307E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. NaN!=3.625824138524307E+24
SumScalar	702.988	372.900
SumBcl	84.114	3116.533	8.357565
SumBase_Range52_Impl	79.845	3283.142	8.804356
SumTraits	83.623	3134.846	8.406673
SumTraits_Range52	79.830	3283.772	8.806047
Sum128Bcl	160.565	1632.637	4.378220
Sum128Base_Basic	939.962	278.888	0.747890
Sum128Base	190.976	1372.656	3.681033
Sum128Base_Range52_Impl	165.732	1581.737	4.241721
Sum128AdvSimd_Range52	Run fail! Requires hardware support AdvSimd!
Sum128AdvSimd_Range52_Impl	Run fail! Requires hardware support AdvSimd!
Sum128Traits	167.090	1568.877	4.207237
Sum128Traits_Range52	160.532	1632.971	4.379116
Sum256Bcl	85.254	3074.846	8.245773
Sum256Base_Basic	879.034	298.218	0.799728
Sum256Base	94.122	2785.144	7.468883
Sum256Base_Range52_Impl	123.110	2129.341	5.710224
Sum256Avx2_Bcl	91.505	2864.811	7.682525
Sum256Avx2_Range52	84.891	3087.993	8.281029
Sum256Traits	84.304	3109.519	8.338755
Sum256Traits_Range52	81.301	3224.350	8.646695

VectorTraitsBase: OK.
VectorTraits128Base: Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimd: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd! Vector byte size mismatch(32!=16) !
VectorTraits256Base: OK.
VectorTraits256Avx2: OK.
[Vectors.Instance: VectorTraits256Avx2]
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	Single, Double	# (00006000)
ConvertToDouble_AcceleratedTypes:	Int64, UInt64	# (00001800)
ConvertToInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToInt64_AcceleratedTypes:	None	# (00000000)
ConvertToSingle_AcceleratedTypes:	Int32, UInt32	# (00000600)
ConvertToUInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToUInt64_AcceleratedTypes:	None	# (00000000)
ExtractMostSignificantBits_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Floor_AcceleratedTypes:	Single, Double	# (00006000)
IsSupported:	True
Multiply_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Multiply_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32, Single, Double	# (00006780)
Narrow_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64, Double	# (00005F80)
ShiftLeft_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
ShiftRightArithmetic_AcceleratedTypes:	SByte, Int16, Int32, Int64	# (00000AA0)
ShiftRightLogical_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
Shuffle_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Sum_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Widen_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single	# (000027E0)
YClamp_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YNarrowSaturate_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturate_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32	# (00000780)
YNarrowSaturateUnsigned_AcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	Int16, Int32	# (00000280)
YShuffleG2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4X2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleInsert_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleKernel_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)

WVectorTraits128Base: OK.
WVectorTraits128AdvSimd: Requires hardware support AdvSimd!
WVectorTraits128AdvSimdB64: Requires hardware support AdvSimd!
[Vector128s.Instance: WVectorTraits128Base]
Abs_AcceleratedTypes:	SByte, Int16, Int32, Int64, Single, Double	# (00006AA0)
Add_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
AndNot_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
BitwiseAnd_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
BitwiseOr_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	Single, Double	# (00006000)
ConditionalSelect_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ConvertToDouble_AcceleratedTypes:	None	# (00000000)
ConvertToInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToInt64_AcceleratedTypes:	None	# (00000000)
ConvertToSingle_AcceleratedTypes:	Int32, UInt32	# (00000600)
ConvertToUInt32_AcceleratedTypes:	None	# (00000000)
ConvertToUInt64_AcceleratedTypes:	None	# (00000000)
Divide_AcceleratedTypes:	None	# (00000000)
ExtractMostSignificantBits_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single	# (000027E0)
Floor_AcceleratedTypes:	Single, Double	# (00006000)
GreaterThan_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
IsSupported:	True
LessThan_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Max_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Min_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Multiply_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Single	# (00002780)
Multiply_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32, Single	# (00002780)
Narrow_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
Negate_AcceleratedTypes:	SByte, Int16, Int32, Int64, Single, Double	# (00006AA0)
OnesComplement_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ShiftLeft_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
ShiftRightArithmetic_AcceleratedTypes:	Int16, Int32	# (00000280)
ShiftRightLogical_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
Shuffle_AcceleratedTypes:	None	# (00000000)
Subtract_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Sum_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Single	# (00002780)
Widen_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32	# (000007E0)
Xor_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YClamp_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YNarrowSaturate_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturate_FullAcceleratedTypes:	None	# (00000000)
YNarrowSaturateUnsigned_AcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	None	# (00000000)
YShuffleG2_AcceleratedTypes:	None	# (00000000)
YShuffleG4_AcceleratedTypes:	None	# (00000000)
YShuffleG4X2_AcceleratedTypes:	None	# (00000000)
YShuffleInsert_AcceleratedTypes:	None	# (00000000)
YShuffleKernel_AcceleratedTypes:	None	# (00000000)

WVectorTraits256Base: OK.
WVectorTraits256Avx2: OK.
[Vector256s.Instance: WVectorTraits256Avx2]
Abs_AcceleratedTypes:	SByte, Int16, Int32, Int64, Single, Double	# (00006AA0)
Add_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
AndNot_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
BitwiseAnd_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
BitwiseOr_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	Single, Double	# (00006000)
ConditionalSelect_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ConvertToDouble_AcceleratedTypes:	Int64, UInt64	# (00001800)
ConvertToInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToInt64_AcceleratedTypes:	None	# (00000000)
ConvertToSingle_AcceleratedTypes:	Int32, UInt32	# (00000600)
ConvertToUInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToUInt64_AcceleratedTypes:	None	# (00000000)
Divide_AcceleratedTypes:	Single, Double	# (00006000)
ExtractMostSignificantBits_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Floor_AcceleratedTypes:	Single, Double	# (00006000)
GreaterThan_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
IsSupported:	True
LessThan_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Max_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Min_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Multiply_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Multiply_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32, Single, Double	# (00006780)
Narrow_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64, Double	# (00005F80)
Negate_AcceleratedTypes:	SByte, Int16, Int32, Int64, Single, Double	# (00006AA0)
OnesComplement_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ShiftLeft_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
ShiftRightArithmetic_AcceleratedTypes:	SByte, Int16, Int32, Int64	# (00000AA0)
ShiftRightLogical_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
Shuffle_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Subtract_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Sum_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Widen_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single	# (000027E0)
Xor_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YClamp_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YNarrowSaturate_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturate_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32	# (00000780)
YNarrowSaturateUnsigned_AcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	Int16, Int32	# (00000280)
YShuffleG2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4X2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleInsert_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleKernel_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)

``` 


## Arm

### AWS Arm t4g.small
`AWS Arm t4g.small`

#### .NET Core 3.1
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	3.1.31
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.31/
RuntimeInformation.FrameworkDescription:	.NET Core 3.1.31
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.15.0-1026-aws #30-Ubuntu SMP Wed Nov 23 17:01:09 UTC 2022
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960958	# 0x0079797E
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/3.1.31/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET Core 3.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET Core 3.1
Vectors.Instance:	VectorTraits128Base
Vectors.BaseInstance:	VectorTraits128Base


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783052E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
SumScalar	319.101	821.509
SumBcl	132.965	1971.525	2.399884
SumBase_Range52_Impl	160.763	1630.625	1.984916
SumTraits	125.042	2096.445	2.551945
SumTraits_Range52	4636.382	56.541	0.068825
Sum128Base_Basic	1183.414	221.515	0.269644
Sum128Base	1183.316	221.533	0.269667
Sum128Base_Range52_Impl	1183.350	221.527	0.269659
Sum128Traits	1179.963	222.163	0.270433
Sum128Traits_Range52	1162.033	225.591	0.274606
Sum256Base_Basic	1609.023	162.921	0.198320
Sum256Base	1771.562	147.973	0.180124
Sum256Base_Range52_Impl	1883.005	139.216	0.169464
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2045.604	128.150	0.155993
Sum256Traits_Range52	2042.929	128.318	0.156198

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524267E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base	Check `Sum256Base` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
SumScalar	326.786	802.189
SumBcl	132.334	1980.926	2.469401
SumBase_Range52_Impl	158.616	1652.698	2.060236
SumTraits	123.686	2119.428	2.642057
SumTraits_Range52	4587.682	57.141	0.071231
Sum128Base_Basic	1093.204	239.794	0.298925
Sum128Base	1105.793	237.064	0.295522
Sum128Base_Range52_Impl	1095.866	239.212	0.298199
Sum128Traits	1095.098	239.379	0.298408
Sum128Traits_Range52	1097.012	238.962	0.297887
Sum256Base_Basic	1583.920	165.503	0.206315
Sum256Base	1741.417	150.535	0.187655
Sum256Base_Range52_Impl	1839.688	142.494	0.177631
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2005.119	130.737	0.162976
Sum256Traits_Range52	2003.014	130.875	0.163147

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: Requires hardware support AdvSimd!
VectorTraits128AdvSimdB64: Requires hardware support AdvSimd!
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
[Vectors.Instance: VectorTraits128Base]
ByteCount:	16	# (10)
Ceiling_AcceleratedTypes:	None	# (00000000)
ConvertToDouble_AcceleratedTypes:	None	# (00000000)
ConvertToInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToInt64_AcceleratedTypes:	None	# (00000000)
ConvertToSingle_AcceleratedTypes:	Int32	# (00000200)
ConvertToUInt32_AcceleratedTypes:	None	# (00000000)
ConvertToUInt64_AcceleratedTypes:	None	# (00000000)
ExtractMostSignificantBits_AcceleratedTypes:	None	# (00000000)
Floor_AcceleratedTypes:	None	# (00000000)
IsSupported:	True
Multiply_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Single	# (00002780)
Multiply_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32, Single	# (00002780)
Narrow_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
ShiftLeft_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32	# (000007E0)
ShiftRightArithmetic_AcceleratedTypes:	None	# (00000000)
ShiftRightLogical_AcceleratedTypes:	None	# (00000000)
Shuffle_AcceleratedTypes:	None	# (00000000)
Sum_AcceleratedTypes:	None	# (00000000)
Widen_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32	# (000007E0)
YClamp_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YNarrowSaturate_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturate_FullAcceleratedTypes:	None	# (00000000)
YNarrowSaturateUnsigned_AcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	None	# (00000000)
YShuffleG2_AcceleratedTypes:	None	# (00000000)
YShuffleG4_AcceleratedTypes:	None	# (00000000)
YShuffleG4X2_AcceleratedTypes:	None	# (00000000)
YShuffleInsert_AcceleratedTypes:	None	# (00000000)
YShuffleKernel_AcceleratedTypes:	None	# (00000000)

WVectorTraits128Base: OK.
WVectorTraits128AdvSimd: Requires hardware support AdvSimd!
WVectorTraits128AdvSimdB64: Requires hardware support AdvSimd!
[Vector128s.Instance: WVectorTraits128Base]
Abs_AcceleratedTypes:	None	# (00000000)
Add_AcceleratedTypes:	None	# (00000000)
AndNot_AcceleratedTypes:	None	# (00000000)
BitwiseAnd_AcceleratedTypes:	None	# (00000000)
BitwiseOr_AcceleratedTypes:	None	# (00000000)
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	None	# (00000000)
ConditionalSelect_AcceleratedTypes:	None	# (00000000)
ConvertToDouble_AcceleratedTypes:	None	# (00000000)
ConvertToInt32_AcceleratedTypes:	None	# (00000000)
ConvertToInt64_AcceleratedTypes:	None	# (00000000)
ConvertToSingle_AcceleratedTypes:	None	# (00000000)
ConvertToUInt32_AcceleratedTypes:	None	# (00000000)
ConvertToUInt64_AcceleratedTypes:	None	# (00000000)
Divide_AcceleratedTypes:	None	# (00000000)
ExtractMostSignificantBits_AcceleratedTypes:	None	# (00000000)
Floor_AcceleratedTypes:	None	# (00000000)
GreaterThan_AcceleratedTypes:	None	# (00000000)
IsSupported:	True
LessThan_AcceleratedTypes:	None	# (00000000)
Max_AcceleratedTypes:	None	# (00000000)
Min_AcceleratedTypes:	None	# (00000000)
Multiply_AcceleratedTypes:	None	# (00000000)
Multiply_FullAcceleratedTypes:	None	# (00000000)
Narrow_AcceleratedTypes:	None	# (00000000)
Negate_AcceleratedTypes:	None	# (00000000)
OnesComplement_AcceleratedTypes:	None	# (00000000)
ShiftLeft_AcceleratedTypes:	None	# (00000000)
ShiftRightArithmetic_AcceleratedTypes:	None	# (00000000)
ShiftRightLogical_AcceleratedTypes:	None	# (00000000)
Shuffle_AcceleratedTypes:	None	# (00000000)
Subtract_AcceleratedTypes:	None	# (00000000)
Sum_AcceleratedTypes:	None	# (00000000)
Widen_AcceleratedTypes:	None	# (00000000)
Xor_AcceleratedTypes:	None	# (00000000)
YClamp_AcceleratedTypes:	None	# (00000000)
YNarrowSaturate_AcceleratedTypes:	None	# (00000000)
YNarrowSaturate_FullAcceleratedTypes:	None	# (00000000)
YNarrowSaturateUnsigned_AcceleratedTypes:	None	# (00000000)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	None	# (00000000)
YShuffleG2_AcceleratedTypes:	None	# (00000000)
YShuffleG4_AcceleratedTypes:	None	# (00000000)
YShuffleG4X2_AcceleratedTypes:	None	# (00000000)
YShuffleInsert_AcceleratedTypes:	None	# (00000000)
YShuffleKernel_AcceleratedTypes:	None	# (00000000)

WVectorTraits256Base: OK.
WVectorTraits256Avx2: Requires hardware support Avx, Avx2!
[Vector256s.Instance: WVectorTraits256Base]
Abs_AcceleratedTypes:	None	# (00000000)
Add_AcceleratedTypes:	None	# (00000000)
AndNot_AcceleratedTypes:	None	# (00000000)
BitwiseAnd_AcceleratedTypes:	None	# (00000000)
BitwiseOr_AcceleratedTypes:	None	# (00000000)
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	None	# (00000000)
ConditionalSelect_AcceleratedTypes:	None	# (00000000)
ConvertToDouble_AcceleratedTypes:	None	# (00000000)
ConvertToInt32_AcceleratedTypes:	None	# (00000000)
ConvertToInt64_AcceleratedTypes:	None	# (00000000)
ConvertToSingle_AcceleratedTypes:	None	# (00000000)
ConvertToUInt32_AcceleratedTypes:	None	# (00000000)
ConvertToUInt64_AcceleratedTypes:	None	# (00000000)
Divide_AcceleratedTypes:	None	# (00000000)
ExtractMostSignificantBits_AcceleratedTypes:	None	# (00000000)
Floor_AcceleratedTypes:	None	# (00000000)
GreaterThan_AcceleratedTypes:	None	# (00000000)
IsSupported:	True
LessThan_AcceleratedTypes:	None	# (00000000)
Max_AcceleratedTypes:	None	# (00000000)
Min_AcceleratedTypes:	None	# (00000000)
Multiply_AcceleratedTypes:	None	# (00000000)
Multiply_FullAcceleratedTypes:	None	# (00000000)
Narrow_AcceleratedTypes:	None	# (00000000)
Negate_AcceleratedTypes:	None	# (00000000)
OnesComplement_AcceleratedTypes:	None	# (00000000)
ShiftLeft_AcceleratedTypes:	None	# (00000000)
ShiftRightArithmetic_AcceleratedTypes:	None	# (00000000)
ShiftRightLogical_AcceleratedTypes:	None	# (00000000)
Shuffle_AcceleratedTypes:	None	# (00000000)
Subtract_AcceleratedTypes:	None	# (00000000)
Sum_AcceleratedTypes:	None	# (00000000)
Widen_AcceleratedTypes:	None	# (00000000)
Xor_AcceleratedTypes:	None	# (00000000)
YClamp_AcceleratedTypes:	None	# (00000000)
YNarrowSaturate_AcceleratedTypes:	None	# (00000000)
YNarrowSaturate_FullAcceleratedTypes:	None	# (00000000)
YNarrowSaturateUnsigned_AcceleratedTypes:	None	# (00000000)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	None	# (00000000)
YShuffleG2_AcceleratedTypes:	None	# (00000000)
YShuffleG4_AcceleratedTypes:	None	# (00000000)
YShuffleG4X2_AcceleratedTypes:	None	# (00000000)
YShuffleInsert_AcceleratedTypes:	None	# (00000000)
YShuffleKernel_AcceleratedTypes:	None	# (00000000)

```

#### .NET 5.0
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	5.0.17
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/
RuntimeInformation.FrameworkDescription:	.NET 5.0.17
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.15.0-1026-aws #30-Ubuntu SMP Wed Nov 23 17:01:09 UTC 2022
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960958	# 0x0079797E
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/5.0.17/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 5.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 5.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783052E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum128AdvSimd_Range52	Check `Sum128AdvSimd_Range52` mismatch. NaN!=-3.259163328783052E+21
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
SumScalar	326.641	802.544
SumBcl	133.735	1960.169	2.442443
SumBase_Range52_Impl	160.839	1629.856	2.030861
SumTraits	125.135	2094.887	2.610308
SumTraits_Range52	133.355	1965.763	2.449414
Sum128Base_Basic	409.675	639.883	0.797318
Sum128Base	410.239	639.004	0.796223
Sum128Base_Range52_Impl	408.519	641.693	0.799573
Sum128AdvSimd_Range52	354.909	738.623	0.920352
Sum128AdvSimd_Range52_Impl	315.270	831.489	1.036067
Sum128Traits	133.442	1964.477	2.447812
Sum128Traits_Range52	125.233	2093.253	2.608272
Sum256Base_Basic	984.092	266.382	0.331921
Sum256Base	1158.451	226.288	0.281964
Sum256Base_Range52_Impl	1156.677	226.635	0.282396
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1158.092	226.359	0.282051
Sum256Traits_Range52	1157.153	226.542	0.282280

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524267E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum128AdvSimd_Range52	Check `Sum128AdvSimd_Range52` mismatch. NaN!=3.625824138524267E+24
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base	Check `Sum256Base` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
SumScalar	320.654	817.529
SumBcl	124.098	2112.393	2.583875
SumBase_Range52_Impl	158.593	1652.937	2.021870
SumTraits	124.117	2112.064	2.583473
SumTraits_Range52	132.732	1974.984	2.415797
Sum128Base_Basic	388.952	673.975	0.824405
Sum128Base	389.508	673.013	0.823228
Sum128Base_Range52_Impl	391.373	669.806	0.819306
Sum128AdvSimd_Range52	290.367	902.802	1.104305
Sum128AdvSimd_Range52_Impl	294.765	889.333	1.087831
Sum128Traits	123.964	2114.685	2.586680
Sum128Traits_Range52	132.790	1974.131	2.414754
Sum256Base_Basic	966.741	271.163	0.331686
Sum256Base	1139.204	230.112	0.281472
Sum256Base_Range52_Impl	1137.812	230.393	0.281816
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1141.614	229.626	0.280878
Sum256Traits_Range52	1138.374	230.279	0.281677

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
[Vectors.Instance: VectorTraits128AdvSimdB64]
ByteCount:	16	# (10)
Ceiling_AcceleratedTypes:	Single, Double	# (00006000)
ConvertToDouble_AcceleratedTypes:	Int64, UInt64	# (00001800)
ConvertToInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToInt64_AcceleratedTypes:	Double	# (00004000)
ConvertToSingle_AcceleratedTypes:	Int32, UInt32	# (00000600)
ConvertToUInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToUInt64_AcceleratedTypes:	Double	# (00004000)
ExtractMostSignificantBits_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Floor_AcceleratedTypes:	Single, Double	# (00006000)
IsSupported:	True
Multiply_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single, Double	# (000067E0)
Multiply_FullAcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single, Double	# (000067E0)
Narrow_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64, Double	# (00005F80)
ShiftLeft_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
ShiftRightArithmetic_AcceleratedTypes:	SByte, Int16, Int32, Int64	# (00000AA0)
ShiftRightLogical_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
Shuffle_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Sum_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Widen_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32	# (000007E0)
YClamp_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YNarrowSaturate_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturate_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturateUnsigned_AcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YShuffleG2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single	# (000027E0)
YShuffleG4X2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleInsert_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleKernel_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)

WVectorTraits128Base: OK.
WVectorTraits128AdvSimd: OK.
WVectorTraits128AdvSimdB64: OK.
[Vector128s.Instance: WVectorTraits128AdvSimdB64]
Abs_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Add_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
AndNot_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
BitwiseAnd_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
BitwiseOr_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	Single, Double	# (00006000)
ConditionalSelect_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ConvertToDouble_AcceleratedTypes:	Int64, UInt64	# (00001800)
ConvertToInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToInt64_AcceleratedTypes:	Double	# (00004000)
ConvertToSingle_AcceleratedTypes:	Int32, UInt32	# (00000600)
ConvertToUInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToUInt64_AcceleratedTypes:	Double	# (00004000)
Divide_AcceleratedTypes:	Single, Double	# (00006000)
ExtractMostSignificantBits_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Floor_AcceleratedTypes:	Single, Double	# (00006000)
GreaterThan_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
IsSupported:	True
LessThan_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Max_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Min_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Multiply_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single, Double	# (000067E0)
Multiply_FullAcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single, Double	# (000067E0)
Narrow_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64, Double	# (00005F80)
Negate_AcceleratedTypes:	SByte, Int16, Int32, Int64, Single, Double	# (00006AA0)
OnesComplement_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ShiftLeft_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
ShiftRightArithmetic_AcceleratedTypes:	SByte, Int16, Int32, Int64	# (00000AA0)
ShiftRightLogical_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
Shuffle_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Subtract_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Sum_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Widen_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single	# (000027E0)
Xor_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YClamp_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YNarrowSaturate_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturate_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturateUnsigned_AcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YShuffleG2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single	# (000027E0)
YShuffleG4X2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleInsert_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleKernel_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)

WVectorTraits256Base: OK.
WVectorTraits256Avx2: Requires hardware support Avx, Avx2!
[Vector256s.Instance: WVectorTraits256Base]
Abs_AcceleratedTypes:	None	# (00000000)
Add_AcceleratedTypes:	None	# (00000000)
AndNot_AcceleratedTypes:	None	# (00000000)
BitwiseAnd_AcceleratedTypes:	None	# (00000000)
BitwiseOr_AcceleratedTypes:	None	# (00000000)
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	None	# (00000000)
ConditionalSelect_AcceleratedTypes:	None	# (00000000)
ConvertToDouble_AcceleratedTypes:	None	# (00000000)
ConvertToInt32_AcceleratedTypes:	None	# (00000000)
ConvertToInt64_AcceleratedTypes:	None	# (00000000)
ConvertToSingle_AcceleratedTypes:	None	# (00000000)
ConvertToUInt32_AcceleratedTypes:	None	# (00000000)
ConvertToUInt64_AcceleratedTypes:	None	# (00000000)
Divide_AcceleratedTypes:	None	# (00000000)
ExtractMostSignificantBits_AcceleratedTypes:	None	# (00000000)
Floor_AcceleratedTypes:	None	# (00000000)
GreaterThan_AcceleratedTypes:	None	# (00000000)
IsSupported:	True
LessThan_AcceleratedTypes:	None	# (00000000)
Max_AcceleratedTypes:	None	# (00000000)
Min_AcceleratedTypes:	None	# (00000000)
Multiply_AcceleratedTypes:	None	# (00000000)
Multiply_FullAcceleratedTypes:	None	# (00000000)
Narrow_AcceleratedTypes:	None	# (00000000)
Negate_AcceleratedTypes:	None	# (00000000)
OnesComplement_AcceleratedTypes:	None	# (00000000)
ShiftLeft_AcceleratedTypes:	None	# (00000000)
ShiftRightArithmetic_AcceleratedTypes:	None	# (00000000)
ShiftRightLogical_AcceleratedTypes:	None	# (00000000)
Shuffle_AcceleratedTypes:	None	# (00000000)
Subtract_AcceleratedTypes:	None	# (00000000)
Sum_AcceleratedTypes:	None	# (00000000)
Widen_AcceleratedTypes:	None	# (00000000)
Xor_AcceleratedTypes:	None	# (00000000)
YClamp_AcceleratedTypes:	None	# (00000000)
YNarrowSaturate_AcceleratedTypes:	None	# (00000000)
YNarrowSaturate_FullAcceleratedTypes:	None	# (00000000)
YNarrowSaturateUnsigned_AcceleratedTypes:	None	# (00000000)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	None	# (00000000)
YShuffleG2_AcceleratedTypes:	None	# (00000000)
YShuffleG4_AcceleratedTypes:	None	# (00000000)
YShuffleG4X2_AcceleratedTypes:	None	# (00000000)
YShuffleInsert_AcceleratedTypes:	None	# (00000000)
YShuffleKernel_AcceleratedTypes:	None	# (00000000)

```

#### .NET 6.0
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	6.0.11
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.11/
RuntimeInformation.FrameworkDescription:	.NET 6.0.11
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.15.0-1026-aws #30-Ubuntu SMP Wed Nov 23 17:01:09 UTC 2022
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960958	# 0x0079797E
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/6.0.11/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 6.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 6.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783052E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum128AdvSimd_Range52	Check `Sum128AdvSimd_Range52` mismatch. NaN!=-3.259163328783052E+21
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
SumScalar	318.571	822.875
SumBcl	133.300	1966.575	2.389882
SumBase_Range52_Impl	161.009	1628.131	1.978587
SumTraits	133.384	1965.338	2.388379
SumTraits_Range52	125.118	2095.179	2.546169
Sum128Base_Basic	409.254	640.541	0.778418
Sum128Base	409.398	640.316	0.778145
Sum128Base_Range52_Impl	409.869	639.580	0.777250
Sum128AdvSimd_Range52	321.938	814.268	0.989541
Sum128AdvSimd_Range52_Impl	322.666	812.431	0.987307
Sum128Traits	133.442	1964.479	2.387335
Sum128Traits_Range52	125.115	2095.219	2.546217
Sum256Base_Basic	979.035	267.758	0.325393
Sum256Base	1145.464	228.854	0.278115
Sum256Base_Range52_Impl	1150.015	227.948	0.277014
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1146.849	228.578	0.277779
Sum256Traits_Range52	1146.412	228.665	0.277885

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524267E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum128AdvSimd_Range52	Check `Sum128AdvSimd_Range52` mismatch. NaN!=3.625824138524267E+24
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base	Check `Sum256Base` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
SumScalar	318.193	823.851
SumBcl	132.203	1982.888	2.406852
SumBase_Range52_Impl	158.472	1654.200	2.007886
SumTraits	132.344	1980.775	2.404287
SumTraits_Range52	123.620	2120.570	2.573971
Sum128Base_Basic	388.922	674.027	0.818142
Sum128Base	391.209	670.087	0.813360
Sum128Base_Range52_Impl	391.971	668.784	0.811778
Sum128AdvSimd_Range52	310.236	844.982	1.025649
Sum128AdvSimd_Range52_Impl	310.961	843.013	1.023259
Sum128Traits	132.244	1982.282	2.406116
Sum128Traits_Range52	123.483	2122.907	2.576808
Sum256Base_Basic	964.222	271.871	0.330000
Sum256Base	1133.886	231.191	0.280622
Sum256Base_Range52_Impl	1132.857	231.401	0.280877
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1132.953	231.381	0.280853
Sum256Traits_Range52	1133.087	231.354	0.280820

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
[Vectors.Instance: VectorTraits128AdvSimdB64]
ByteCount:	16	# (10)
Ceiling_AcceleratedTypes:	Single, Double	# (00006000)
ConvertToDouble_AcceleratedTypes:	Int64, UInt64	# (00001800)
ConvertToInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToInt64_AcceleratedTypes:	Double	# (00004000)
ConvertToSingle_AcceleratedTypes:	Int32, UInt32	# (00000600)
ConvertToUInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToUInt64_AcceleratedTypes:	Double	# (00004000)
ExtractMostSignificantBits_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Floor_AcceleratedTypes:	Single, Double	# (00006000)
IsSupported:	True
Multiply_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single, Double	# (000067E0)
Multiply_FullAcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single, Double	# (000067E0)
Narrow_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64, Double	# (00005F80)
ShiftLeft_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
ShiftRightArithmetic_AcceleratedTypes:	SByte, Int16, Int32, Int64	# (00000AA0)
ShiftRightLogical_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
Shuffle_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Sum_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Widen_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32	# (000007E0)
YClamp_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YNarrowSaturate_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturate_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturateUnsigned_AcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YShuffleG2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single	# (000027E0)
YShuffleG4X2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleInsert_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleKernel_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)

WVectorTraits128Base: OK.
WVectorTraits128AdvSimd: OK.
WVectorTraits128AdvSimdB64: OK.
[Vector128s.Instance: WVectorTraits128AdvSimdB64]
Abs_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Add_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
AndNot_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
BitwiseAnd_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
BitwiseOr_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	Single, Double	# (00006000)
ConditionalSelect_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ConvertToDouble_AcceleratedTypes:	Int64, UInt64	# (00001800)
ConvertToInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToInt64_AcceleratedTypes:	Double	# (00004000)
ConvertToSingle_AcceleratedTypes:	Int32, UInt32	# (00000600)
ConvertToUInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToUInt64_AcceleratedTypes:	Double	# (00004000)
Divide_AcceleratedTypes:	Single, Double	# (00006000)
ExtractMostSignificantBits_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Floor_AcceleratedTypes:	Single, Double	# (00006000)
GreaterThan_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
IsSupported:	True
LessThan_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Max_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Min_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Multiply_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single, Double	# (000067E0)
Multiply_FullAcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single, Double	# (000067E0)
Narrow_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64, Double	# (00005F80)
Negate_AcceleratedTypes:	SByte, Int16, Int32, Int64, Single, Double	# (00006AA0)
OnesComplement_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ShiftLeft_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
ShiftRightArithmetic_AcceleratedTypes:	SByte, Int16, Int32, Int64	# (00000AA0)
ShiftRightLogical_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
Shuffle_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Subtract_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Sum_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Widen_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single	# (000027E0)
Xor_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YClamp_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YNarrowSaturate_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturate_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturateUnsigned_AcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YShuffleG2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single	# (000027E0)
YShuffleG4X2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleInsert_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleKernel_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)

WVectorTraits256Base: OK.
WVectorTraits256Avx2: Requires hardware support Avx, Avx2!
[Vector256s.Instance: WVectorTraits256Base]
Abs_AcceleratedTypes:	None	# (00000000)
Add_AcceleratedTypes:	None	# (00000000)
AndNot_AcceleratedTypes:	None	# (00000000)
BitwiseAnd_AcceleratedTypes:	None	# (00000000)
BitwiseOr_AcceleratedTypes:	None	# (00000000)
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	None	# (00000000)
ConditionalSelect_AcceleratedTypes:	None	# (00000000)
ConvertToDouble_AcceleratedTypes:	None	# (00000000)
ConvertToInt32_AcceleratedTypes:	None	# (00000000)
ConvertToInt64_AcceleratedTypes:	None	# (00000000)
ConvertToSingle_AcceleratedTypes:	None	# (00000000)
ConvertToUInt32_AcceleratedTypes:	None	# (00000000)
ConvertToUInt64_AcceleratedTypes:	None	# (00000000)
Divide_AcceleratedTypes:	None	# (00000000)
ExtractMostSignificantBits_AcceleratedTypes:	None	# (00000000)
Floor_AcceleratedTypes:	None	# (00000000)
GreaterThan_AcceleratedTypes:	None	# (00000000)
IsSupported:	True
LessThan_AcceleratedTypes:	None	# (00000000)
Max_AcceleratedTypes:	None	# (00000000)
Min_AcceleratedTypes:	None	# (00000000)
Multiply_AcceleratedTypes:	None	# (00000000)
Multiply_FullAcceleratedTypes:	None	# (00000000)
Narrow_AcceleratedTypes:	None	# (00000000)
Negate_AcceleratedTypes:	None	# (00000000)
OnesComplement_AcceleratedTypes:	None	# (00000000)
ShiftLeft_AcceleratedTypes:	None	# (00000000)
ShiftRightArithmetic_AcceleratedTypes:	None	# (00000000)
ShiftRightLogical_AcceleratedTypes:	None	# (00000000)
Shuffle_AcceleratedTypes:	None	# (00000000)
Subtract_AcceleratedTypes:	None	# (00000000)
Sum_AcceleratedTypes:	None	# (00000000)
Widen_AcceleratedTypes:	None	# (00000000)
Xor_AcceleratedTypes:	None	# (00000000)
YClamp_AcceleratedTypes:	None	# (00000000)
YNarrowSaturate_AcceleratedTypes:	None	# (00000000)
YNarrowSaturate_FullAcceleratedTypes:	None	# (00000000)
YNarrowSaturateUnsigned_AcceleratedTypes:	None	# (00000000)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	None	# (00000000)
YShuffleG2_AcceleratedTypes:	None	# (00000000)
YShuffleG4_AcceleratedTypes:	None	# (00000000)
YShuffleG4X2_AcceleratedTypes:	None	# (00000000)
YShuffleInsert_AcceleratedTypes:	None	# (00000000)
YShuffleKernel_AcceleratedTypes:	None	# (00000000)

```

#### .NET 7.0
```
VectorTraits.Benchmarks
benchmarkMode:	0

IsRelease:	True
EnvironmentVariable(PROCESSOR_IDENTIFIER):	
Environment.ProcessorCount:	2
Environment.Is64BitProcess:	True
Environment.OSVersion:	Unix 5.15.0.1026
Environment.Version:	7.0.1
Stopwatch.Frequency:	1000000000
RuntimeEnvironment.GetRuntimeDirectory:	/home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.1/
RuntimeInformation.FrameworkDescription:	.NET 7.0.1
RuntimeInformation.OSArchitecture:	Arm64
RuntimeInformation.OSDescription:	Linux 5.15.0-1026-aws #30-Ubuntu SMP Wed Nov 23 17:01:09 UTC 2022
RuntimeInformation.RuntimeIdentifier:	ubuntu.22.04-arm64
IntPtr.Size:	8
BitConverter.IsLittleEndian:	True
Vector.IsHardwareAccelerated:	True
Vector<byte>.Count:	16	# 128bit
Vector<float>.Count:	4	# 128bit
VectorTraitsGlobal.InitCheckSum:	7960958	# 0x0079797E
Vector<T>.Assembly.CodeBase:	file:///home/ubuntu/.dotnet/shared/Microsoft.NETCore.App/7.0.1/System.Private.CoreLib.dll
GetTargetFrameworkDisplayName(VectorTextUtil):	.NET 7.0
GetTargetFrameworkDisplayName(TraitsOutput):	.NET 7.0
Vectors.Instance:	VectorTraits128AdvSimdB64
Vectors.BaseInstance:	VectorTraits128Base


[ConvertToDoubleBenchmark_Int64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	-3.2591633287830034E+21
# SumBcl	-3.259163328783052E+21
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. NaN!=-3.259163328783052E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
SumScalar	281.974	929.675
SumBcl	106.380	2464.232	2.650638
SumBase_Range52_Impl	132.537	1977.897	2.127514
SumTraits	106.454	2462.507	2.648782
SumTraits_Range52	106.250	2467.240	2.653874
Sum128Bcl	106.385	2464.104	2.650501
Sum128Base_Basic	398.784	657.359	0.707084
Sum128Base	106.532	2460.704	2.646843
Sum128Base_Range52_Impl	133.753	1959.905	2.108162
Sum128AdvSimd_Range52	107.115	2447.307	2.632432
Sum128AdvSimd_Range52_Impl	252.917	1036.483	1.114887
Sum128Traits	106.550	2460.299	2.646407
Sum128Traits_Range52	106.503	2461.386	2.647576
Sum256Bcl	1190.997	220.105	0.236754
Sum256Base_Basic	1016.069	257.998	0.277514
Sum256Base	1191.294	220.050	0.236695
Sum256Base_Range52_Impl	2533.016	103.491	0.111319
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1191.676	219.979	0.236619
Sum256Traits_Range52	1365.472	191.981	0.206503

[ConvertToDoubleBenchmark_UInt64(262144)]
---
NAME	US	MOPS	SCALE
# SumScalar	3.6258241385243714E+24
# SumBcl	3.625824138524267E+24
Check-SumBase_Range52_Impl	Check `SumBase_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum128Base_Range52_Impl	Check `Sum128Base_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum128AdvSimd_Range52_Impl	Check `Sum128AdvSimd_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum256Bcl	Check `Sum256Bcl` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base	Check `Sum256Base` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. NaN!=3.625824138524267E+24
Check-Sum256Traits	Check `Sum256Traits` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. 3.625824138524307E+24!=3.625824138524267E+24
SumScalar	282.004	929.575
SumBcl	107.787	2432.056	2.616308
SumBase_Range52_Impl	135.104	1940.306	2.087303
SumTraits	107.944	2428.521	2.612505
SumTraits_Range52	108.171	2423.416	2.607013
Sum128Bcl	107.836	2430.961	2.615130
Sum128Base_Basic	416.374	629.588	0.677285
Sum128Base	108.023	2426.736	2.610586
Sum128Base_Range52_Impl	136.270	1923.709	2.069449
Sum128AdvSimd_Range52	107.910	2429.273	2.613314
Sum128AdvSimd_Range52_Impl	267.954	978.319	1.052436
Sum128Traits	108.330	2419.864	2.603193
Sum128Traits_Range52	107.803	2431.700	2.615926
Sum256Bcl	1190.716	220.157	0.236836
Sum256Base_Basic	1032.370	253.925	0.273162
Sum256Base	1189.110	220.454	0.237156
Sum256Base_Range52_Impl	2136.351	122.706	0.132003
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1200.046	218.445	0.234994
Sum256Traits_Range52	1412.850	185.543	0.199599

VectorTraitsBase: OK.
VectorTraits128Base: OK.
VectorTraits128AdvSimd: OK.
VectorTraits128AdvSimdB64: OK.
VectorTraits256Base: Vector byte size mismatch(16!=32) !
VectorTraits256Avx2: Requires hardware support Avx, Avx2! Vector byte size mismatch(16!=32) !
[Vectors.Instance: VectorTraits128AdvSimdB64]
ByteCount:	16	# (10)
Ceiling_AcceleratedTypes:	Single, Double	# (00006000)
ConvertToDouble_AcceleratedTypes:	Int64, UInt64	# (00001800)
ConvertToInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToInt64_AcceleratedTypes:	Double	# (00004000)
ConvertToSingle_AcceleratedTypes:	Int32, UInt32	# (00000600)
ConvertToUInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToUInt64_AcceleratedTypes:	Double	# (00004000)
ExtractMostSignificantBits_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Floor_AcceleratedTypes:	Single, Double	# (00006000)
IsSupported:	True
Multiply_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single, Double	# (000067E0)
Multiply_FullAcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single, Double	# (000067E0)
Narrow_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64, Double	# (00005F80)
ShiftLeft_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
ShiftRightArithmetic_AcceleratedTypes:	SByte, Int16, Int32, Int64	# (00000AA0)
ShiftRightLogical_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
Shuffle_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Sum_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Widen_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single	# (000027E0)
YClamp_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YNarrowSaturate_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturate_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturateUnsigned_AcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YShuffleG2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single	# (000027E0)
YShuffleG4X2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleInsert_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleKernel_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)

WVectorTraits128Base: OK.
WVectorTraits128AdvSimd: OK.
WVectorTraits128AdvSimdB64: OK.
[Vector128s.Instance: WVectorTraits128AdvSimdB64]
Abs_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Add_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
AndNot_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
BitwiseAnd_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
BitwiseOr_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	Single, Double	# (00006000)
ConditionalSelect_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ConvertToDouble_AcceleratedTypes:	Int64, UInt64	# (00001800)
ConvertToInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToInt64_AcceleratedTypes:	Double	# (00004000)
ConvertToSingle_AcceleratedTypes:	Int32, UInt32	# (00000600)
ConvertToUInt32_AcceleratedTypes:	Single	# (00002000)
ConvertToUInt64_AcceleratedTypes:	Double	# (00004000)
Divide_AcceleratedTypes:	Single, Double	# (00006000)
ExtractMostSignificantBits_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Floor_AcceleratedTypes:	Single, Double	# (00006000)
GreaterThan_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
IsSupported:	True
LessThan_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Max_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Min_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Multiply_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single, Double	# (000067E0)
Multiply_FullAcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single, Double	# (000067E0)
Narrow_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64, Double	# (00005F80)
Negate_AcceleratedTypes:	SByte, Int16, Int32, Int64, Single, Double	# (00006AA0)
OnesComplement_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
ShiftLeft_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
ShiftRightArithmetic_AcceleratedTypes:	SByte, Int16, Int32, Int64	# (00000AA0)
ShiftRightLogical_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001FE0)
Shuffle_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Subtract_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Sum_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
Widen_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single	# (000027E0)
Xor_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YClamp_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YNarrowSaturate_AcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturate_FullAcceleratedTypes:	Int16, UInt16, Int32, UInt32, Int64, UInt64	# (00001F80)
YNarrowSaturateUnsigned_AcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	Int16, Int32, Int64	# (00000A80)
YShuffleG2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleG4_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Single	# (000027E0)
YShuffleG4X2_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleInsert_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)
YShuffleKernel_AcceleratedTypes:	SByte, Byte, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double	# (00007FE0)

WVectorTraits256Base: OK.
WVectorTraits256Avx2: Requires hardware support Avx, Avx2!
[Vector256s.Instance: WVectorTraits256Base]
Abs_AcceleratedTypes:	None	# (00000000)
Add_AcceleratedTypes:	None	# (00000000)
AndNot_AcceleratedTypes:	None	# (00000000)
BitwiseAnd_AcceleratedTypes:	None	# (00000000)
BitwiseOr_AcceleratedTypes:	None	# (00000000)
ByteCount:	32	# (20)
Ceiling_AcceleratedTypes:	None	# (00000000)
ConditionalSelect_AcceleratedTypes:	None	# (00000000)
ConvertToDouble_AcceleratedTypes:	None	# (00000000)
ConvertToInt32_AcceleratedTypes:	None	# (00000000)
ConvertToInt64_AcceleratedTypes:	None	# (00000000)
ConvertToSingle_AcceleratedTypes:	None	# (00000000)
ConvertToUInt32_AcceleratedTypes:	None	# (00000000)
ConvertToUInt64_AcceleratedTypes:	None	# (00000000)
Divide_AcceleratedTypes:	None	# (00000000)
ExtractMostSignificantBits_AcceleratedTypes:	None	# (00000000)
Floor_AcceleratedTypes:	None	# (00000000)
GreaterThan_AcceleratedTypes:	None	# (00000000)
IsSupported:	True
LessThan_AcceleratedTypes:	None	# (00000000)
Max_AcceleratedTypes:	None	# (00000000)
Min_AcceleratedTypes:	None	# (00000000)
Multiply_AcceleratedTypes:	None	# (00000000)
Multiply_FullAcceleratedTypes:	None	# (00000000)
Narrow_AcceleratedTypes:	None	# (00000000)
Negate_AcceleratedTypes:	None	# (00000000)
OnesComplement_AcceleratedTypes:	None	# (00000000)
ShiftLeft_AcceleratedTypes:	None	# (00000000)
ShiftRightArithmetic_AcceleratedTypes:	None	# (00000000)
ShiftRightLogical_AcceleratedTypes:	None	# (00000000)
Shuffle_AcceleratedTypes:	None	# (00000000)
Subtract_AcceleratedTypes:	None	# (00000000)
Sum_AcceleratedTypes:	None	# (00000000)
Widen_AcceleratedTypes:	None	# (00000000)
Xor_AcceleratedTypes:	None	# (00000000)
YClamp_AcceleratedTypes:	None	# (00000000)
YNarrowSaturate_AcceleratedTypes:	None	# (00000000)
YNarrowSaturate_FullAcceleratedTypes:	None	# (00000000)
YNarrowSaturateUnsigned_AcceleratedTypes:	None	# (00000000)
YNarrowSaturateUnsigned_FullAcceleratedTypes:	None	# (00000000)
YShuffleG2_AcceleratedTypes:	None	# (00000000)
YShuffleG4_AcceleratedTypes:	None	# (00000000)
YShuffleG4X2_AcceleratedTypes:	None	# (00000000)
YShuffleInsert_AcceleratedTypes:	None	# (00000000)
YShuffleKernel_AcceleratedTypes:	None	# (00000000)

```

