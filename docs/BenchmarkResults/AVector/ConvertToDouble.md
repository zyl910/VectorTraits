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
SumScalar	319.775	819.777
SumBcl	133.261	1967.149	2.399614
SumBase_Range52_Impl	160.777	1630.482	1.988934
SumTraits	125.183	2094.080	2.554451
SumTraits_Range52	4666.013	56.182	0.068533
Sum128Base_Basic	1175.526	223.001	0.272027
Sum128Base	1187.019	220.842	0.269393
Sum128Base_Range52_Impl	1178.658	222.409	0.271304
Sum128Traits	1179.268	222.294	0.271164
Sum128Traits_Range52	1176.463	222.824	0.271810
Sum256Base_Basic	1613.070	162.513	0.198240
Sum256Base	1764.450	148.570	0.181232
Sum256Base_Range52_Impl	1872.837	139.972	0.170743
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2037.938	128.632	0.156911
Sum256Traits_Range52	2032.610	128.969	0.157322

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
SumScalar	326.601	802.642
SumBcl	132.448	1979.217	2.465879
SumBase_Range52_Impl	158.583	1653.036	2.059494
SumTraits	124.094	2112.466	2.631891
SumTraits_Range52	4596.063	57.037	0.071061
Sum128Base_Basic	1096.671	239.036	0.297812
Sum128Base	1098.186	238.706	0.297401
Sum128Base_Range52_Impl	1103.220	237.617	0.296044
Sum128Traits	1094.228	239.570	0.298477
Sum128Traits_Range52	1092.843	239.873	0.298855
Sum256Base_Basic	1590.295	164.840	0.205372
Sum256Base	1740.357	150.627	0.187663
Sum256Base_Range52_Impl	1854.057	141.389	0.176155
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	2021.451	129.681	0.161568
Sum256Traits_Range52	2024.155	129.508	0.161352

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
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
SumScalar	327.109	801.395
SumBcl	133.536	1963.091	2.449591
SumBase_Range52_Impl	161.186	1626.346	2.029392
SumTraits	125.235	2093.219	2.611968
SumTraits_Range52	133.377	1965.442	2.452525
Sum128Base_Basic	410.710	638.270	0.796448
Sum128Base	411.996	636.279	0.793963
Sum128Base_Range52_Impl	405.892	645.847	0.805903
Sum128AdvSimd_Range52	410.013	639.355	0.797802
Sum128AdvSimd_Range52_Impl	410.877	638.011	0.796125
Sum128Traits	133.650	1961.421	2.447506
Sum128Traits_Range52	125.332	2091.596	2.609942
Sum256Base_Basic	986.988	265.600	0.331422
Sum256Base	1150.186	227.914	0.284397
Sum256Base_Range52_Impl	1152.372	227.482	0.283857
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1151.107	227.732	0.284170
Sum256Traits_Range52	1150.949	227.763	0.284209

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
SumScalar	321.838	814.522
SumBcl	126.674	2069.441	2.540682
SumBase_Range52_Impl	161.444	1623.741	1.993490
SumTraits	125.725	2085.060	2.559858
SumTraits_Range52	134.628	1947.171	2.390568
Sum128Base_Basic	395.285	663.178	0.814193
Sum128Base	386.086	678.978	0.833590
Sum128Base_Range52_Impl	389.150	673.633	0.827028
Sum128AdvSimd_Range52	388.814	674.214	0.827742
Sum128AdvSimd_Range52_Impl	389.224	673.505	0.826871
Sum128Traits	124.011	2113.870	2.595228
Sum128Traits_Range52	132.451	1979.184	2.429872
Sum256Base_Basic	966.299	271.287	0.333062
Sum256Base	1136.344	230.691	0.283222
Sum256Base_Range52_Impl	1136.390	230.681	0.283211
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1138.378	230.279	0.282716
Sum256Traits_Range52	1135.058	230.952	0.283543

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
Check-Sum256Base_Basic	Check `Sum256Base_Basic` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base	Check `Sum256Base` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Base_Range52_Impl	Check `Sum256Base_Range52_Impl` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits	Check `Sum256Traits` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
Check-Sum256Traits_Range52	Check `Sum256Traits_Range52` mismatch. -3.2591633287830207E+21!=-3.259163328783052E+21
SumScalar	318.961	821.867
SumBcl	133.111	1969.364	2.396206
SumBase_Range52_Impl	161.322	1624.973	1.977171
SumTraits	133.543	1962.988	2.388449
SumTraits_Range52	125.227	2093.350	2.547066
Sum128Base_Basic	407.221	643.739	0.783264
Sum128Base	406.715	644.540	0.784238
Sum128Base_Range52_Impl	405.928	645.790	0.785760
Sum128AdvSimd_Range52	406.920	644.215	0.783844
Sum128AdvSimd_Range52_Impl	403.955	648.943	0.789596
Sum128Traits	133.145	1968.859	2.395593
Sum128Traits_Range52	124.915	2098.581	2.553431
Sum256Base_Basic	978.138	268.003	0.326090
Sum256Base	1151.829	227.589	0.276917
Sum256Base_Range52_Impl	1149.805	227.990	0.277405
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1149.734	228.004	0.277422
Sum256Traits_Range52	1153.052	227.348	0.276624

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
SumScalar	320.129	818.869
SumBcl	123.663	2119.817	2.588715
SumBase_Range52_Impl	158.343	1655.548	2.021750
SumTraits	123.559	2121.610	2.590903
SumTraits_Range52	132.294	1981.520	2.419826
Sum128Base_Basic	387.754	676.058	0.825600
Sum128Base	387.646	676.247	0.825830
Sum128Base_Range52_Impl	390.002	672.160	0.820840
Sum128AdvSimd_Range52	387.987	675.651	0.825103
Sum128AdvSimd_Range52_Impl	389.977	672.204	0.820893
Sum128Traits	123.461	2123.296	2.592963
Sum128Traits_Range52	132.342	1980.812	2.418962
Sum256Base_Basic	963.460	272.086	0.332271
Sum256Base	1131.957	231.585	0.282811
Sum256Base_Range52_Impl	1131.836	231.610	0.282841
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1132.841	231.404	0.282590
Sum256Traits_Range52	1134.862	230.992	0.282087

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
SumScalar	281.949	929.758
SumBcl	106.521	2460.965	2.646886
SumBase_Range52_Impl	132.750	1974.722	2.123909
SumTraits	106.369	2464.481	2.650668
SumTraits_Range52	106.261	2466.976	2.653351
Sum128Bcl	106.271	2466.750	2.653108
Sum128Base_Basic	402.671	651.013	0.700196
Sum128Base	106.410	2463.536	2.649652
Sum128Base_Range52_Impl	133.549	1962.901	2.111194
Sum128AdvSimd_Range52	106.483	2461.835	2.647823
Sum128AdvSimd_Range52_Impl	251.180	1043.649	1.122495
Sum128Traits	106.347	2464.978	2.651202
Sum128Traits_Range52	106.738	2455.962	2.641506
Sum256Bcl	1189.221	220.433	0.237087
Sum256Base_Basic	1015.688	258.095	0.277594
Sum256Base	1189.556	220.371	0.237020
Sum256Base_Range52_Impl	2428.143	107.961	0.116117
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_HwScalar	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1188.733	220.524	0.237184
Sum256Traits_Range52	1365.793	191.935	0.206436

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
SumScalar	281.939	929.791
SumBcl	107.854	2430.553	2.614086
SumBase_Range52_Impl	134.819	1944.421	2.091247
SumTraits	108.281	2420.953	2.603762
SumTraits_Range52	108.157	2423.746	2.606766
Sum128Bcl	108.054	2426.056	2.609249
Sum128Base_Basic	411.713	636.716	0.684795
Sum128Base	108.931	2406.504	2.588221
Sum128Base_Range52_Impl	135.954	1928.177	2.073775
Sum128AdvSimd_Range52	108.163	2423.591	2.606599
Sum128AdvSimd_Range52_Impl	268.402	976.684	1.050435
Sum128Traits	108.360	2419.205	2.601881
Sum128Traits_Range52	108.012	2426.994	2.610258
Sum256Bcl	1186.384	220.960	0.237645
Sum256Base_Basic	1031.223	254.207	0.273402
Sum256Base	1184.793	221.257	0.237965
Sum256Base_Range52_Impl	2138.884	122.561	0.131816
Sum256Avx2_Bcl	Run fail! Requires hardware support Avx, Avx2!
Sum256Avx2_Range52	Run fail! Requires hardware support Avx, Avx2!
Sum256Traits	1183.162	221.562	0.238293
Sum256Traits_Range52	1392.422	188.265	0.202481

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

