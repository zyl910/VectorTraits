# Benchmark group - YGroup2Transpose
([← Back](YGroup2Transpose.md))

Unit of data: Million operations per second. The larger the number, the better the performance.
### X86 - AMD Ryzen 7 7840H
| Type                            | Method                   | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :------------------------------ | :----------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| YGroup2TransposeBenchmark_Byte  | SumBase_Basic            |       1441.302 |      1373.075 |      1417.602 |  1380.282 |  1399.632 |  1330.814 |  1361.794 |
| YGroup2TransposeBenchmark_Byte  | SumBase_Shift            |                |               |               |           |           | 37155.325 | 38262.719 |
| YGroup2TransposeBenchmark_Byte  | SumBase_ShiftByMul       |       8474.611 |      4199.055 |      9493.831 | 11227.262 | 11177.763 | 13642.917 | 14679.149 |
| YGroup2TransposeBenchmark_Byte  | SumBase                  |       8428.903 |      7895.027 |      9693.378 | 11144.113 | 11149.732 | 36901.097 | 39010.284 |
| YGroup2TransposeBenchmark_Byte  | SumTraits                |       8703.029 |      8245.866 |     27394.422 | 38455.627 | 39356.226 | 37378.897 | 48098.762 |
| YGroup2TransposeBenchmark_Byte  | Sum128Base_Basic         |                |               |       467.443 |   467.472 |   469.098 |  1162.633 |  1156.885 |
| YGroup2TransposeBenchmark_Byte  | Sum128Base_Shift         |                |               |               |           |           | 18662.427 | 19372.725 |
| YGroup2TransposeBenchmark_Byte  | Sum128Base_Shuffle       |                |               |               |           |           |   274.877 |   277.819 |
| YGroup2TransposeBenchmark_Byte  | Sum128Base               |                |               |       471.874 |   463.131 |   470.791 | 19625.135 | 18374.476 |
| YGroup2TransposeBenchmark_Byte  | Sum128AdvSimd_Shift      |                |               |               |           |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum128AdvSimd_Shuffle    |                |               |               |           |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum128AdvSimd_ShuffleX   |                |               |               |           |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum128AdvSimdB64         |                |               |               |           |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum128PackedSimd_Shift   |                |               |               |           |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum128PackedSimd_Shuffle |                |               |               |           |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum128Sse_Shift          |                |               |     13970.084 | 20183.828 | 19667.740 | 18863.977 | 18639.392 |
| YGroup2TransposeBenchmark_Byte  | Sum128Sse_Shuffle        |                |               |     10302.426 | 14413.063 | 14131.058 | 16411.431 | 17233.052 |
| YGroup2TransposeBenchmark_Byte  | Sum128Sse_ShuffleX       |                |               |               |           |           |           | 27102.285 |
| YGroup2TransposeBenchmark_Byte  | Sum128Sse_ShuffleXImm    |                |               |     13313.028 | 13407.321 | 13369.118 | 13144.409 | 13171.379 |
| YGroup2TransposeBenchmark_Byte  | Sum128Sse_Unpack         |                |               |     13799.266 | 14537.709 | 13883.004 | 13615.353 | 13774.146 |
| YGroup2TransposeBenchmark_Byte  | Sum128Traits             |                |               |     15221.510 | 20597.994 | 20417.316 | 19054.344 | 26775.661 |
| YGroup2TransposeBenchmark_Byte  | Sum256Base_Basic         |                |               |       594.016 |   490.944 |   591.254 |  1351.502 |  1332.730 |
| YGroup2TransposeBenchmark_Byte  | Sum256Base_Shift         |                |               |               |           |           | 38432.651 | 39684.337 |
| YGroup2TransposeBenchmark_Byte  | Sum256Base_Shuffle       |                |               |               |           |           |   309.553 |   258.138 |
| YGroup2TransposeBenchmark_Byte  | Sum256Base               |                |               |       588.219 |   523.530 |   588.107 | 39193.919 | 38085.830 |
| YGroup2TransposeBenchmark_Byte  | Sum256Avx2_Shift         |                |               |     31721.948 | 38748.703 | 39535.056 | 38526.091 | 38101.763 |
| YGroup2TransposeBenchmark_Byte  | Sum256Avx2_Shuffle       |                |               |     19566.632 | 27149.089 | 26249.757 | 27054.776 | 32517.279 |
| YGroup2TransposeBenchmark_Byte  | Sum256Avx2_ShuffleX      |                |               |               |           |           |           | 50338.633 |
| YGroup2TransposeBenchmark_Byte  | Sum256Avx2_ShuffleXImm   |                |               |     26811.564 | 26889.428 | 26671.605 | 26671.291 | 24661.834 |
| YGroup2TransposeBenchmark_Byte  | Sum256Avx2_Unpack        |                |               |     28146.623 | 28303.023 | 28270.208 | 27520.772 | 25026.818 |
| YGroup2TransposeBenchmark_Byte  | Sum256Traits             |                |               |     31186.379 | 40224.465 | 38880.264 | 38296.407 | 45721.618 |
| YGroup2TransposeBenchmark_Byte  | Sum512Base_Basic         |                |               |               |           |           |           |  1433.632 |
| YGroup2TransposeBenchmark_Byte  | Sum512Base_Shift         |                |               |               |           |           |           | 48515.893 |
| YGroup2TransposeBenchmark_Byte  | Sum512Base_Shuffle       |                |               |               |           |           |           |   268.592 |
| YGroup2TransposeBenchmark_Byte  | Sum512Base               |                |               |               |           |           |           | 50963.073 |
| YGroup2TransposeBenchmark_Byte  | Sum512Avx512_Shift       |                |               |               |           |           |           | 52089.390 |
| YGroup2TransposeBenchmark_Byte  | Sum512Avx512_Shuffle     |                |               |               |           |           |           | 35990.248 |
| YGroup2TransposeBenchmark_Byte  | Sum512Avx512_ShuffleX    |                |               |               |           |           |           | 70120.064 |
| YGroup2TransposeBenchmark_Byte  | Sum512Avx512_ShuffleXImm |                |               |               |           |           |           | 29861.591 |
| YGroup2TransposeBenchmark_Byte  | Sum512Avx512_Unpack      |                |               |               |           |           |           | 28278.590 |
| YGroup2TransposeBenchmark_Byte  | Sum512Traits             |                |               |               |           |           |           | 67996.564 |
| YGroup2TransposeBenchmark_Int16 | SumBase_Basic            |       1067.937 |      1100.250 |      1141.423 |  1079.248 |  1177.530 |  1068.071 |  1084.313 |
| YGroup2TransposeBenchmark_Int16 | SumBase_Shift            |                |               |               |           |           | 18836.299 | 19040.668 |
| YGroup2TransposeBenchmark_Int16 | SumBase_ShiftByMul       |       5270.541 |      2182.759 |      5700.205 |  6137.886 |  5994.017 | 10025.228 | 10728.752 |
| YGroup2TransposeBenchmark_Int16 | SumBase                  |       5414.970 |      5064.974 |      5845.755 |  6067.628 |  6134.151 | 19086.052 | 18714.113 |
| YGroup2TransposeBenchmark_Int16 | SumTraits                |       5287.450 |      5188.689 |     22518.090 | 22699.253 | 23374.006 | 23184.277 | 26941.241 |
| YGroup2TransposeBenchmark_Int16 | Sum128Base_Basic         |                |               |       290.512 |   279.929 |   288.588 |   822.303 |   816.253 |
| YGroup2TransposeBenchmark_Int16 | Sum128Base_Shift         |                |               |               |           |           |  9125.848 | 10025.922 |
| YGroup2TransposeBenchmark_Int16 | Sum128Base_Shuffle       |                |               |               |           |           |   139.673 |   144.115 |
| YGroup2TransposeBenchmark_Int16 | Sum128Base               |                |               |       286.898 |   281.356 |   288.477 |  9522.829 |  9814.710 |
| YGroup2TransposeBenchmark_Int16 | Sum128AdvSimd_Shift      |                |               |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum128AdvSimd_Shuffle    |                |               |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum128AdvSimd_ShuffleX   |                |               |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum128AdvSimdB64         |                |               |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum128PackedSimd_Shift   |                |               |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum128PackedSimd_Shuffle |                |               |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum128Sse_Shift          |                |               |      7282.159 |  9789.487 |  9867.260 |  9292.319 |  9969.224 |
| YGroup2TransposeBenchmark_Int16 | Sum128Sse_Shuffle        |                |               |      4868.215 |  6905.152 |  6781.425 |  8351.413 |  8531.394 |
| YGroup2TransposeBenchmark_Int16 | Sum128Sse_ShuffleX       |                |               |               |           |           |           | 13670.158 |
| YGroup2TransposeBenchmark_Int16 | Sum128Sse_ShuffleXImm    |                |               |     11654.850 | 11620.795 | 11411.385 | 11770.778 | 12085.037 |
| YGroup2TransposeBenchmark_Int16 | Sum128Sse_Unpack         |                |               |      8732.909 |  8923.009 |  8854.057 |  8568.649 |  9067.771 |
| YGroup2TransposeBenchmark_Int16 | Sum128Traits             |                |               |     11158.214 | 12019.639 | 11228.669 | 11474.512 | 14715.764 |
| YGroup2TransposeBenchmark_Int16 | Sum256Base_Basic         |                |               |       402.386 |   299.387 |   406.244 |  1061.470 |  1099.348 |
| YGroup2TransposeBenchmark_Int16 | Sum256Base_Shift         |                |               |               |           |           | 18689.176 | 19110.914 |
| YGroup2TransposeBenchmark_Int16 | Sum256Base_Shuffle       |                |               |               |           |           |   152.755 |   156.685 |
| YGroup2TransposeBenchmark_Int16 | Sum256Base               |                |               |       403.590 |   331.025 |   397.185 | 19078.670 | 19534.603 |
| YGroup2TransposeBenchmark_Int16 | Sum256Avx2_Shift         |                |               |     15714.290 | 19675.733 | 19219.787 | 19588.936 | 18927.024 |
| YGroup2TransposeBenchmark_Int16 | Sum256Avx2_Shuffle       |                |               |      9977.978 | 13412.948 | 13078.338 | 13215.429 | 16037.189 |
| YGroup2TransposeBenchmark_Int16 | Sum256Avx2_ShuffleX      |                |               |               |           |           |           | 25981.645 |
| YGroup2TransposeBenchmark_Int16 | Sum256Avx2_ShuffleXImm   |                |               |     22983.748 | 23657.104 | 23479.687 | 22574.068 | 23329.431 |
| YGroup2TransposeBenchmark_Int16 | Sum256Avx2_Unpack        |                |               |     17248.222 | 17126.294 | 17669.918 | 16830.173 | 17947.498 |
| YGroup2TransposeBenchmark_Int16 | Sum256Traits             |                |               |     23125.151 | 23276.756 | 22957.086 | 22457.159 | 27107.054 |
| YGroup2TransposeBenchmark_Int16 | Sum512Base_Basic         |                |               |               |           |           |           |  1340.036 |
| YGroup2TransposeBenchmark_Int16 | Sum512Base_Shift         |                |               |               |           |           |           | 25404.622 |
| YGroup2TransposeBenchmark_Int16 | Sum512Base_Shuffle       |                |               |               |           |           |           |   133.105 |
| YGroup2TransposeBenchmark_Int16 | Sum512Base               |                |               |               |           |           |           | 25459.478 |
| YGroup2TransposeBenchmark_Int16 | Sum512Avx512_Shift       |                |               |               |           |           |           | 25553.372 |
| YGroup2TransposeBenchmark_Int16 | Sum512Avx512_Shuffle     |                |               |               |           |           |           | 16693.189 |
| YGroup2TransposeBenchmark_Int16 | Sum512Avx512_ShuffleX    |                |               |               |           |           |           | 36099.104 |
| YGroup2TransposeBenchmark_Int16 | Sum512Avx512_ShuffleXImm |                |               |               |           |           |           | 27919.269 |
| YGroup2TransposeBenchmark_Int16 | Sum512Avx512_Unpack      |                |               |               |           |           |           | 19205.735 |
| YGroup2TransposeBenchmark_Int16 | Sum512Traits             |                |               |               |           |           |           | 36236.553 |
| YGroup2TransposeBenchmark_Int32 | SumBase_Basic            |        686.654 |       675.976 |       761.723 |   688.536 |   764.784 |   668.199 |   691.115 |
| YGroup2TransposeBenchmark_Int32 | SumBase_Shift            |                |               |               |           |           |  8874.686 |  9404.298 |
| YGroup2TransposeBenchmark_Int32 | SumBase_ShiftByMul       |        965.156 |       593.976 |       972.161 |   958.500 |   966.360 |   935.189 |   954.510 |
| YGroup2TransposeBenchmark_Int32 | SumBase                  |        692.867 |       679.152 |       770.960 |   672.758 |   762.168 |  9045.898 |  9454.060 |
| YGroup2TransposeBenchmark_Int32 | SumTraits                |        686.941 |       674.592 |     10637.484 | 11209.907 | 11611.570 | 10928.948 | 12866.286 |
| YGroup2TransposeBenchmark_Int32 | Sum128Base_Basic         |                |               |       170.044 |   170.986 |   172.408 |   477.218 |   475.885 |
| YGroup2TransposeBenchmark_Int32 | Sum128Base_Shift         |                |               |               |           |           |  4787.752 |  5119.904 |
| YGroup2TransposeBenchmark_Int32 | Sum128Base_Shuffle       |                |               |               |           |           |    68.557 |    72.530 |
| YGroup2TransposeBenchmark_Int32 | Sum128Base               |                |               |       172.722 |   170.853 |   172.145 |  4703.784 |  5012.278 |
| YGroup2TransposeBenchmark_Int32 | Sum128AdvSimd_Shift      |                |               |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum128AdvSimd_Shuffle    |                |               |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum128AdvSimd_ShuffleX   |                |               |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum128AdvSimdB64         |                |               |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum128PackedSimd_Shift   |                |               |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum128PackedSimd_Shuffle |                |               |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum128Sse_Shift          |                |               |      3639.344 |  5046.597 |  4960.324 |  4729.456 |  5011.418 |
| YGroup2TransposeBenchmark_Int32 | Sum128Sse_Shuffle        |                |               |      2505.720 |  3329.717 |  3337.062 |  3552.559 |  4307.408 |
| YGroup2TransposeBenchmark_Int32 | Sum128Sse_ShuffleX       |                |               |               |           |           |           |  7152.264 |
| YGroup2TransposeBenchmark_Int32 | Sum128Sse_ShuffleXImm    |                |               |      5807.998 |  6038.754 |  5933.314 |  5787.299 |  6045.618 |
| YGroup2TransposeBenchmark_Int32 | Sum128Sse_Unpack         |                |               |      5691.822 |  5720.625 |  5578.087 |  5425.090 |  6070.926 |
| YGroup2TransposeBenchmark_Int32 | Sum128Traits             |                |               |      6238.989 |  6312.395 |  5714.850 |  5708.247 |  6807.102 |
| YGroup2TransposeBenchmark_Int32 | Sum256Base_Basic         |                |               |       265.132 |   185.686 |   286.800 |   666.846 |   691.518 |
| YGroup2TransposeBenchmark_Int32 | Sum256Base_Shift         |                |               |               |           |           |  8754.774 |  9103.098 |
| YGroup2TransposeBenchmark_Int32 | Sum256Base_Shuffle       |                |               |               |           |           |    76.433 |    76.991 |
| YGroup2TransposeBenchmark_Int32 | Sum256Base               |                |               |       287.267 |   203.543 |   287.283 |  8521.597 |  9570.426 |
| YGroup2TransposeBenchmark_Int32 | Sum256Avx2_Shift         |                |               |      7205.144 |  9149.492 |  9562.074 |  8788.961 |  9375.981 |
| YGroup2TransposeBenchmark_Int32 | Sum256Avx2_Shuffle       |                |               |      4486.803 |  6554.810 |  6311.726 |  6757.990 |  7727.964 |
| YGroup2TransposeBenchmark_Int32 | Sum256Avx2_ShuffleX      |                |               |               |           |           |           | 12635.989 |
| YGroup2TransposeBenchmark_Int32 | Sum256Avx2_ShuffleXImm   |                |               |     11152.278 | 11289.191 | 11694.822 | 11072.780 | 11636.384 |
| YGroup2TransposeBenchmark_Int32 | Sum256Avx2_Unpack        |                |               |     11641.980 | 11210.155 | 11164.635 | 10822.715 | 11433.758 |
| YGroup2TransposeBenchmark_Int32 | Sum256Traits             |                |               |     11273.651 | 11457.623 | 11304.557 | 11077.138 | 12659.967 |
| YGroup2TransposeBenchmark_Int32 | Sum512Base_Basic         |                |               |               |           |           |           |   915.180 |
| YGroup2TransposeBenchmark_Int32 | Sum512Base_Shift         |                |               |               |           |           |           | 12430.099 |
| YGroup2TransposeBenchmark_Int32 | Sum512Base_Shuffle       |                |               |               |           |           |           |    72.980 |
| YGroup2TransposeBenchmark_Int32 | Sum512Base               |                |               |               |           |           |           | 12439.970 |
| YGroup2TransposeBenchmark_Int32 | Sum512Avx512_Shift       |                |               |               |           |           |           | 12365.036 |
| YGroup2TransposeBenchmark_Int32 | Sum512Avx512_Shuffle     |                |               |               |           |           |           |  8282.516 |
| YGroup2TransposeBenchmark_Int32 | Sum512Avx512_ShuffleX    |                |               |               |           |           |           | 16475.017 |
| YGroup2TransposeBenchmark_Int32 | Sum512Avx512_ShuffleXImm |                |               |               |           |           |           | 14043.646 |
| YGroup2TransposeBenchmark_Int32 | Sum512Avx512_Unpack      |                |               |               |           |           |           | 13475.853 |
| YGroup2TransposeBenchmark_Int32 | Sum512Traits             |                |               |               |           |           |           | 16748.758 |
| YGroup2TransposeBenchmark_Int64 | SumBase_Basic            |        395.028 |       391.795 |       434.847 |   389.416 |   441.736 |   389.720 |   397.622 |
| YGroup2TransposeBenchmark_Int64 | SumBase                  |        400.265 |       382.802 |       435.463 |   386.788 |   441.080 |   391.912 |   398.827 |
| YGroup2TransposeBenchmark_Int64 | SumTraits                |        400.236 |       388.938 |      7179.881 |  7628.245 |  7770.801 |  7641.226 |  7975.323 |
| YGroup2TransposeBenchmark_Int64 | Sum128Base_Basic         |                |               |        92.749 |    92.871 |    93.025 |   270.133 |   271.640 |
| YGroup2TransposeBenchmark_Int64 | Sum128Base_Move          |                |               |        80.738 |    80.421 |    80.358 |   153.452 |   279.036 |
| YGroup2TransposeBenchmark_Int64 | Sum128Base_Shuffle       |                |               |               |           |           |    31.688 |    35.170 |
| YGroup2TransposeBenchmark_Int64 | Sum128Base               |                |               |        93.413 |    93.489 |    92.955 |   153.901 |   278.392 |
| YGroup2TransposeBenchmark_Int64 | Sum128AdvSimd_AlignRight |                |               |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum128AdvSimd_Shuffle    |                |               |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum128AdvSimd_ShuffleX   |                |               |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum128AdvSimdB64         |                |               |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum128PackedSimd_Shuffle |                |               |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum128Sse_Shuffle        |                |               |      1244.145 |  1729.481 |  1701.800 |  1787.274 |  2098.488 |
| YGroup2TransposeBenchmark_Int64 | Sum128Sse_ShuffleX       |                |               |               |           |           |           |  3554.219 |
| YGroup2TransposeBenchmark_Int64 | Sum128Sse_ShuffleXImm    |                |               |      4119.010 |  3857.377 |  4228.732 |  3969.725 |  4097.879 |
| YGroup2TransposeBenchmark_Int64 | Sum128Sse_Unpack         |                |               |      4094.288 |  3910.977 |  4049.626 |  4071.961 |  4138.089 |
| YGroup2TransposeBenchmark_Int64 | Sum128Traits             |                |               |      4177.127 |  2893.098 |  3969.378 |  3559.901 |  4048.649 |
| YGroup2TransposeBenchmark_Int64 | Sum256Base_Basic         |                |               |       144.794 |    99.887 |   162.239 |   391.639 |   399.791 |
| YGroup2TransposeBenchmark_Int64 | Sum256Base_Shuffle       |                |               |               |           |           |    34.924 |    32.240 |
| YGroup2TransposeBenchmark_Int64 | Sum256Base               |                |               |       163.353 |   109.473 |   163.281 |   395.408 |   395.524 |
| YGroup2TransposeBenchmark_Int64 | Sum256Avx2_Shuffle       |                |               |      2546.429 |  3505.087 |  3386.457 |  3453.686 |  4075.881 |
| YGroup2TransposeBenchmark_Int64 | Sum256Avx2_ShuffleX      |                |               |               |           |           |           |  6810.950 |
| YGroup2TransposeBenchmark_Int64 | Sum256Avx2_ShuffleXImm   |                |               |      7907.564 |  7745.265 |  7449.184 |  6894.503 |  7897.670 |
| YGroup2TransposeBenchmark_Int64 | Sum256Avx2_Unpack        |                |               |      7243.872 |  7367.321 |  7515.070 |  7159.992 |  7856.013 |
| YGroup2TransposeBenchmark_Int64 | Sum256Traits             |                |               |      7534.895 |  7796.693 |  7479.196 |  7140.319 |  7762.624 |
| YGroup2TransposeBenchmark_Int64 | Sum512Base_Basic         |                |               |               |           |           |           |   561.166 |
| YGroup2TransposeBenchmark_Int64 | Sum512Base_Shuffle       |                |               |               |           |           |           |    36.082 |
| YGroup2TransposeBenchmark_Int64 | Sum512Avx512_Shuffle     |                |               |               |           |           |           |  4186.646 |
| YGroup2TransposeBenchmark_Int64 | Sum512Avx512_ShuffleX    |                |               |               |           |           |           |  8829.946 |
| YGroup2TransposeBenchmark_Int64 | Sum512Avx512_ShuffleXImm |                |               |               |           |           |           |  9133.388 |
| YGroup2TransposeBenchmark_Int64 | Sum512Avx512_Unpack      |                |               |               |           |           |           |  9043.362 |
| YGroup2TransposeBenchmark_Int64 | Sum512Traits             |                |               |               |           |           |           |  9302.326 |

### Arm - Apple M2
| Type                            | Method                   |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :------------------------------ | :----------------------- | --------: | --------: | --------: |
| YGroup2TransposeBenchmark_Byte  | SumBase_Basic            |  2461.178 |  2458.904 |  2469.367 |
| YGroup2TransposeBenchmark_Byte  | SumBase_Shift            |           | 27165.424 | 27153.733 |
| YGroup2TransposeBenchmark_Byte  | SumBase_ShiftByMul       | 11001.569 | 11742.220 | 13339.615 |
| YGroup2TransposeBenchmark_Byte  | SumBase                  | 11000.927 | 27161.862 | 27158.974 |
| YGroup2TransposeBenchmark_Byte  | SumTraits                | 27204.165 | 27220.518 | 27170.146 |
| YGroup2TransposeBenchmark_Byte  | Sum128Base_Basic         |   974.803 |  2459.565 |  2469.467 |
| YGroup2TransposeBenchmark_Byte  | Sum128Base_Shift         |           | 27145.381 | 27153.784 |
| YGroup2TransposeBenchmark_Byte  | Sum128Base_Shuffle       |           |   330.392 |   330.489 |
| YGroup2TransposeBenchmark_Byte  | Sum128Base               |   975.545 | 27142.831 | 27153.139 |
| YGroup2TransposeBenchmark_Byte  | Sum128AdvSimd_Shift      | 27104.651 | 27139.730 | 27160.417 |
| YGroup2TransposeBenchmark_Byte  | Sum128AdvSimd_Shuffle    | 10751.218 | 10755.464 | 10757.417 |
| YGroup2TransposeBenchmark_Byte  | Sum128AdvSimd_ShuffleX   |           |           | 18892.350 |
| YGroup2TransposeBenchmark_Byte  | Sum128AdvSimdB64         | 27213.746 | 27221.482 | 27231.946 |
| YGroup2TransposeBenchmark_Byte  | Sum128PackedSimd_Shift   |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum128PackedSimd_Shuffle |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum128Sse_Shift          |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum128Sse_Shuffle        |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum128Sse_ShuffleX       |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum128Sse_ShuffleXImm    |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum128Sse_Unpack         |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum128Traits             | 27215.292 | 27223.667 | 27234.776 |
| YGroup2TransposeBenchmark_Byte  | Sum256Base_Basic         |  1023.397 |   757.911 |  2788.745 |
| YGroup2TransposeBenchmark_Byte  | Sum256Base_Shift         |           |   552.629 | 41998.174 |
| YGroup2TransposeBenchmark_Byte  | Sum256Base_Shuffle       |           |   178.011 |   335.056 |
| YGroup2TransposeBenchmark_Byte  | Sum256Base               |   997.107 |   726.296 |  2780.995 |
| YGroup2TransposeBenchmark_Byte  | Sum256Avx2_Shift         |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum256Avx2_Shuffle       |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum256Avx2_ShuffleX      |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum256Avx2_ShuffleXImm   |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum256Avx2_Unpack        |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum256Traits             |   998.531 |   726.284 |  2780.990 |
| YGroup2TransposeBenchmark_Byte  | Sum512Base_Basic         |           |           |  2862.453 |
| YGroup2TransposeBenchmark_Byte  | Sum512Base_Shift         |           |           | 47986.257 |
| YGroup2TransposeBenchmark_Byte  | Sum512Base_Shuffle       |           |           |   244.685 |
| YGroup2TransposeBenchmark_Byte  | Sum512Base               |           |           |  2861.747 |
| YGroup2TransposeBenchmark_Byte  | Sum512Avx512_Shift       |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum512Avx512_Shuffle     |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum512Avx512_ShuffleX    |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum512Avx512_ShuffleXImm |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum512Avx512_Unpack      |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum512Traits             |           |           |  2861.939 |
| YGroup2TransposeBenchmark_Int16 | SumBase_Basic            |  2226.313 |  2228.193 |  2247.551 |
| YGroup2TransposeBenchmark_Int16 | SumBase_Shift            |           | 13598.427 | 13584.430 |
| YGroup2TransposeBenchmark_Int16 | SumBase_ShiftByMul       |  7749.020 |  9883.169 | 11369.988 |
| YGroup2TransposeBenchmark_Int16 | SumBase                  |  7750.723 | 13598.763 | 13591.099 |
| YGroup2TransposeBenchmark_Int16 | SumTraits                | 13605.242 | 13609.477 | 13614.084 |
| YGroup2TransposeBenchmark_Int16 | Sum128Base_Basic         |   816.329 |  2227.333 |  2246.473 |
| YGroup2TransposeBenchmark_Int16 | Sum128Base_Shift         |           | 13548.513 | 13589.474 |
| YGroup2TransposeBenchmark_Int16 | Sum128Base_Shuffle       |           |   145.303 |   145.624 |
| YGroup2TransposeBenchmark_Int16 | Sum128Base               |   820.157 | 13585.946 | 13589.010 |
| YGroup2TransposeBenchmark_Int16 | Sum128AdvSimd_Shift      | 13580.446 | 13584.619 | 13587.903 |
| YGroup2TransposeBenchmark_Int16 | Sum128AdvSimd_Shuffle    |  5378.852 |  5381.586 |  5380.546 |
| YGroup2TransposeBenchmark_Int16 | Sum128AdvSimd_ShuffleX   |           |           |  9455.404 |
| YGroup2TransposeBenchmark_Int16 | Sum128AdvSimdB64         | 13599.072 | 13605.659 | 13609.829 |
| YGroup2TransposeBenchmark_Int16 | Sum128PackedSimd_Shift   |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum128PackedSimd_Shuffle |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum128Sse_Shift          |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum128Sse_Shuffle        |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum128Sse_ShuffleX       |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum128Sse_ShuffleXImm    |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum128Sse_Unpack         |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum128Traits             | 13604.684 | 13606.980 | 13609.635 |
| YGroup2TransposeBenchmark_Int16 | Sum256Base_Basic         |   768.618 |   569.259 |  2362.116 |
| YGroup2TransposeBenchmark_Int16 | Sum256Base_Shift         |           |   366.274 | 20235.683 |
| YGroup2TransposeBenchmark_Int16 | Sum256Base_Shuffle       |           |    88.657 |   145.687 |
| YGroup2TransposeBenchmark_Int16 | Sum256Base               |   768.430 |   568.853 |  2362.625 |
| YGroup2TransposeBenchmark_Int16 | Sum256Avx2_Shift         |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum256Avx2_Shuffle       |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum256Avx2_ShuffleX      |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum256Avx2_ShuffleXImm   |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum256Avx2_Unpack        |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum256Traits             |   768.651 |   569.240 |  2362.269 |
| YGroup2TransposeBenchmark_Int16 | Sum512Base_Basic         |           |           |  2282.426 |
| YGroup2TransposeBenchmark_Int16 | Sum512Base_Shift         |           |           | 23187.864 |
| YGroup2TransposeBenchmark_Int16 | Sum512Base_Shuffle       |           |           |   114.287 |
| YGroup2TransposeBenchmark_Int16 | Sum512Base               |           |           |  2281.791 |
| YGroup2TransposeBenchmark_Int16 | Sum512Avx512_Shift       |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum512Avx512_Shuffle     |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum512Avx512_ShuffleX    |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum512Avx512_ShuffleXImm |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum512Avx512_Unpack      |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum512Traits             |           |           |  2282.569 |
| YGroup2TransposeBenchmark_Int32 | SumBase_Basic            |  1800.507 |  1803.269 |  1807.714 |
| YGroup2TransposeBenchmark_Int32 | SumBase_Shift            |           |  6800.516 |  6798.027 |
| YGroup2TransposeBenchmark_Int32 | SumBase_ShiftByMul       |  2314.998 |  2530.852 |  2591.105 |
| YGroup2TransposeBenchmark_Int32 | SumBase                  |  1801.026 |  6801.109 |  6797.169 |
| YGroup2TransposeBenchmark_Int32 | SumTraits                |  6802.625 |  6805.713 |  6803.854 |
| YGroup2TransposeBenchmark_Int32 | Sum128Base_Basic         |   644.664 |  1802.007 |  1808.465 |
| YGroup2TransposeBenchmark_Int32 | Sum128Base_Shift         |           |  6797.973 |  6797.316 |
| YGroup2TransposeBenchmark_Int32 | Sum128Base_Shuffle       |           |    75.351 |    75.725 |
| YGroup2TransposeBenchmark_Int32 | Sum128Base               |   645.390 |  6797.431 |  6796.693 |
| YGroup2TransposeBenchmark_Int32 | Sum128AdvSimd_Shift      |  6795.208 |  6797.408 |  6795.905 |
| YGroup2TransposeBenchmark_Int32 | Sum128AdvSimd_Shuffle    |  2689.890 |  2691.355 |  2691.816 |
| YGroup2TransposeBenchmark_Int32 | Sum128AdvSimd_ShuffleX   |           |           |  4729.037 |
| YGroup2TransposeBenchmark_Int32 | Sum128AdvSimdB64         |  6801.708 |  6803.010 |  6803.200 |
| YGroup2TransposeBenchmark_Int32 | Sum128PackedSimd_Shift   |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum128PackedSimd_Shuffle |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum128Sse_Shift          |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum128Sse_Shuffle        |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum128Sse_ShuffleX       |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum128Sse_ShuffleXImm    |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum128Sse_Unpack         |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum128Traits             |  6802.761 |  6802.570 |  6804.319 |
| YGroup2TransposeBenchmark_Int32 | Sum256Base_Basic         |   530.074 |   397.879 |  1865.475 |
| YGroup2TransposeBenchmark_Int32 | Sum256Base_Shift         |           |   223.314 | 10163.700 |
| YGroup2TransposeBenchmark_Int32 | Sum256Base_Shuffle       |           |    44.584 |    73.050 |
| YGroup2TransposeBenchmark_Int32 | Sum256Base               |   531.380 |   394.769 |  1864.833 |
| YGroup2TransposeBenchmark_Int32 | Sum256Avx2_Shift         |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum256Avx2_Shuffle       |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum256Avx2_ShuffleX      |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum256Avx2_ShuffleXImm   |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum256Avx2_Unpack        |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum256Traits             |   529.661 |   394.844 |  1864.114 |
| YGroup2TransposeBenchmark_Int32 | Sum512Base_Basic         |           |           |  1709.050 |
| YGroup2TransposeBenchmark_Int32 | Sum512Base_Shift         |           |           | 11654.494 |
| YGroup2TransposeBenchmark_Int32 | Sum512Base_Shuffle       |           |           |    53.837 |
| YGroup2TransposeBenchmark_Int32 | Sum512Base               |           |           |  1709.251 |
| YGroup2TransposeBenchmark_Int32 | Sum512Avx512_Shift       |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum512Avx512_Shuffle     |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum512Avx512_ShuffleX    |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum512Avx512_ShuffleXImm |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum512Avx512_Unpack      |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum512Traits             |           |           |  1709.468 |
| YGroup2TransposeBenchmark_Int64 | SumBase_Basic            |  1315.112 |  1314.531 |  1328.741 |
| YGroup2TransposeBenchmark_Int64 | SumBase                  |  1313.956 |  1314.559 |  1326.174 |
| YGroup2TransposeBenchmark_Int64 | SumTraits                |  3401.200 |  3401.077 |  3401.236 |
| YGroup2TransposeBenchmark_Int64 | Sum128Base_Basic         |   390.060 |  1315.664 |  1326.224 |
| YGroup2TransposeBenchmark_Int64 | Sum128Base_Move          |   454.558 |  3400.162 |  3401.417 |
| YGroup2TransposeBenchmark_Int64 | Sum128Base_Shuffle       |           |    40.497 |    40.484 |
| YGroup2TransposeBenchmark_Int64 | Sum128Base               |   390.340 |  3400.032 |  3402.059 |
| YGroup2TransposeBenchmark_Int64 | Sum128AdvSimd_AlignRight |  3400.579 |  3400.571 |  3401.812 |
| YGroup2TransposeBenchmark_Int64 | Sum128AdvSimd_Shuffle    |  1344.860 |  1345.902 |  1346.495 |
| YGroup2TransposeBenchmark_Int64 | Sum128AdvSimd_ShuffleX   |           |           |  2365.506 |
| YGroup2TransposeBenchmark_Int64 | Sum128AdvSimdB64         |  3401.672 |  3401.493 |  3402.379 |
| YGroup2TransposeBenchmark_Int64 | Sum128PackedSimd_Shuffle |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum128Sse_Shuffle        |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum128Sse_ShuffleX       |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum128Sse_ShuffleXImm    |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum128Sse_Unpack         |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum128Traits             |  3400.783 |  3400.729 |  3401.381 |
| YGroup2TransposeBenchmark_Int64 | Sum256Base_Basic         |   345.325 |   257.853 |  1364.356 |
| YGroup2TransposeBenchmark_Int64 | Sum256Base_Shuffle       |           |    24.868 |    41.228 |
| YGroup2TransposeBenchmark_Int64 | Sum256Base               |   345.372 |   257.572 |  1364.171 |
| YGroup2TransposeBenchmark_Int64 | Sum256Avx2_Shuffle       |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum256Avx2_ShuffleX      |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum256Avx2_ShuffleXImm   |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum256Avx2_Unpack        |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum256Traits             |   345.435 |   257.606 |  1364.423 |
| YGroup2TransposeBenchmark_Int64 | Sum512Base_Basic         |           |           |  1148.118 |
| YGroup2TransposeBenchmark_Int64 | Sum512Base_Shuffle       |           |           |    30.124 |
| YGroup2TransposeBenchmark_Int64 | Sum512Avx512_Shuffle     |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum512Avx512_ShuffleX    |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum512Avx512_ShuffleXImm |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum512Avx512_Unpack      |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum512Traits             |           |           |  1148.210 |

### Arm - AWS Arm t4g.small
| Type                            | Method                   | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :------------------------------ | :----------------------- | ------------: | --------: | --------: | --------: | --------: |
| YGroup2TransposeBenchmark_Byte  | SumBase_Basic            |       765.971 |   783.590 |   786.147 |   862.815 |   875.250 |
| YGroup2TransposeBenchmark_Byte  | SumBase_Shift            |               |           |           |  8613.444 | 11226.945 |
| YGroup2TransposeBenchmark_Byte  | SumBase_ShiftByMul       |      2263.365 |  2599.811 |  2657.141 |  2561.626 |  2896.796 |
| YGroup2TransposeBenchmark_Byte  | SumBase                  |      2262.062 |  2675.793 |  2657.184 |  8598.616 | 11210.388 |
| YGroup2TransposeBenchmark_Byte  | SumTraits                |      2261.075 | 13143.803 | 14313.830 | 15459.072 | 15789.241 |
| YGroup2TransposeBenchmark_Byte  | Sum128Base_Basic         |       308.890 |   309.140 |   308.341 |   862.941 |   875.485 |
| YGroup2TransposeBenchmark_Byte  | Sum128Base_Shift         |               |           |           |  9233.887 | 11215.464 |
| YGroup2TransposeBenchmark_Byte  | Sum128Base_Shuffle       |               |           |           |   144.342 |   153.157 |
| YGroup2TransposeBenchmark_Byte  | Sum128Base               |       306.598 |   307.314 |   308.026 |  9160.895 | 11210.609 |
| YGroup2TransposeBenchmark_Byte  | Sum128AdvSimd_Shift      |               |  8727.499 |  8752.732 |  9073.843 | 11226.761 |
| YGroup2TransposeBenchmark_Byte  | Sum128AdvSimd_Shuffle    |               |  3172.917 |  3071.592 |  3753.951 |  3838.192 |
| YGroup2TransposeBenchmark_Byte  | Sum128AdvSimd_ShuffleX   |               |           |           |           |  5638.952 |
| YGroup2TransposeBenchmark_Byte  | Sum128AdvSimdB64         |               | 13209.795 | 14311.042 | 15423.396 | 15786.867 |
| YGroup2TransposeBenchmark_Byte  | Sum128PackedSimd_Shift   |               |           |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum128PackedSimd_Shuffle |               |           |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum128Sse_Shift          |               |           |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum128Sse_Shuffle        |               |           |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum128Sse_ShuffleX       |               |           |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum128Sse_ShuffleXImm    |               |           |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum128Sse_Unpack         |               |           |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum128Traits             |       306.687 | 13214.100 | 14343.457 | 15453.771 | 15790.296 |
| YGroup2TransposeBenchmark_Byte  | Sum256Base_Basic         |       325.045 |   347.093 |   347.124 |   251.465 |   994.681 |
| YGroup2TransposeBenchmark_Byte  | Sum256Base_Shift         |               |           |           |   164.769 | 14395.012 |
| YGroup2TransposeBenchmark_Byte  | Sum256Base_Shuffle       |               |           |           |    74.269 |   148.068 |
| YGroup2TransposeBenchmark_Byte  | Sum256Base               |       317.994 |   339.067 |   342.573 |   249.773 |   995.868 |
| YGroup2TransposeBenchmark_Byte  | Sum256Avx2_Shift         |               |           |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum256Avx2_Shuffle       |               |           |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum256Avx2_ShuffleX      |               |           |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum256Avx2_ShuffleXImm   |               |           |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum256Avx2_Unpack        |               |           |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum256Traits             |       278.952 |   339.017 |   342.542 |   249.398 |   995.918 |
| YGroup2TransposeBenchmark_Byte  | Sum512Base_Basic         |               |           |           |           |   987.949 |
| YGroup2TransposeBenchmark_Byte  | Sum512Base_Shift         |               |           |           |           | 17093.738 |
| YGroup2TransposeBenchmark_Byte  | Sum512Base_Shuffle       |               |           |           |           |    89.867 |
| YGroup2TransposeBenchmark_Byte  | Sum512Base               |               |           |           |           |   988.975 |
| YGroup2TransposeBenchmark_Byte  | Sum512Avx512_Shift       |               |           |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum512Avx512_Shuffle     |               |           |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum512Avx512_ShuffleX    |               |           |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum512Avx512_ShuffleXImm |               |           |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum512Avx512_Unpack      |               |           |           |           |           |
| YGroup2TransposeBenchmark_Byte  | Sum512Traits             |               |           |           |           |   988.528 |
| YGroup2TransposeBenchmark_Int16 | SumBase_Basic            |       589.769 |   571.110 |   570.867 |   607.885 |   597.921 |
| YGroup2TransposeBenchmark_Int16 | SumBase_Shift            |               |           |           |  4403.506 |  5276.586 |
| YGroup2TransposeBenchmark_Int16 | SumBase_ShiftByMul       |      1904.680 |  2260.738 |  2286.127 |  2270.565 |  2977.261 |
| YGroup2TransposeBenchmark_Int16 | SumBase                  |      1905.657 |  2263.118 |  2283.680 |  4396.289 |  5238.511 |
| YGroup2TransposeBenchmark_Int16 | SumTraits                |      1904.554 |  7011.678 |  6544.259 |  7907.458 |  7738.568 |
| YGroup2TransposeBenchmark_Int16 | Sum128Base_Basic         |       202.286 |   207.019 |   210.066 |   607.681 |   597.919 |
| YGroup2TransposeBenchmark_Int16 | Sum128Base_Shift         |               |           |           |  4883.821 |  5279.656 |
| YGroup2TransposeBenchmark_Int16 | Sum128Base_Shuffle       |               |           |           |    86.577 |    86.818 |
| YGroup2TransposeBenchmark_Int16 | Sum128Base               |       202.218 |   208.268 |   208.771 |  4879.563 |  5156.775 |
| YGroup2TransposeBenchmark_Int16 | Sum128AdvSimd_Shift      |               |  4212.182 |  4262.090 |  4855.094 |  5239.406 |
| YGroup2TransposeBenchmark_Int16 | Sum128AdvSimd_Shuffle    |               |  1572.034 |  1562.449 |  1914.612 |  1888.091 |
| YGroup2TransposeBenchmark_Int16 | Sum128AdvSimd_ShuffleX   |               |           |           |           |  2649.799 |
| YGroup2TransposeBenchmark_Int16 | Sum128AdvSimdB64         |               |  7019.852 |  7006.907 |  7886.405 |  7716.261 |
| YGroup2TransposeBenchmark_Int16 | Sum128PackedSimd_Shift   |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum128PackedSimd_Shuffle |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum128Sse_Shift          |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum128Sse_Shuffle        |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum128Sse_ShuffleX       |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum128Sse_ShuffleXImm    |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum128Sse_Unpack         |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum128Traits             |       202.575 |  6999.152 |  6999.869 |  7901.401 |  7718.848 |
| YGroup2TransposeBenchmark_Int16 | Sum256Base_Basic         |       194.212 |   264.881 |   269.885 |   193.370 |   844.677 |
| YGroup2TransposeBenchmark_Int16 | Sum256Base_Shift         |               |           |           |   116.615 |  7071.845 |
| YGroup2TransposeBenchmark_Int16 | Sum256Base_Shuffle       |               |           |           |    45.443 |    86.290 |
| YGroup2TransposeBenchmark_Int16 | Sum256Base               |       189.328 |   265.277 |   268.980 |   194.815 |   842.874 |
| YGroup2TransposeBenchmark_Int16 | Sum256Avx2_Shift         |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum256Avx2_Shuffle       |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum256Avx2_ShuffleX      |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum256Avx2_ShuffleXImm   |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum256Avx2_Unpack        |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum256Traits             |       162.462 |   265.651 |   269.450 |   194.618 |   842.382 |
| YGroup2TransposeBenchmark_Int16 | Sum512Base_Basic         |               |           |           |           |   800.926 |
| YGroup2TransposeBenchmark_Int16 | Sum512Base_Shift         |               |           |           |           |  8164.370 |
| YGroup2TransposeBenchmark_Int16 | Sum512Base_Shuffle       |               |           |           |           |    49.308 |
| YGroup2TransposeBenchmark_Int16 | Sum512Base               |               |           |           |           |   800.564 |
| YGroup2TransposeBenchmark_Int16 | Sum512Avx512_Shift       |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum512Avx512_Shuffle     |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum512Avx512_ShuffleX    |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum512Avx512_ShuffleXImm |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum512Avx512_Unpack      |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int16 | Sum512Traits             |               |           |           |           |   800.509 |
| YGroup2TransposeBenchmark_Int32 | SumBase_Basic            |       361.090 |   353.887 |   350.896 |   363.118 |   370.691 |
| YGroup2TransposeBenchmark_Int32 | SumBase_Shift            |               |           |           |  2192.905 |  2610.484 |
| YGroup2TransposeBenchmark_Int32 | SumBase_ShiftByMul       |       762.455 |   815.549 |   856.125 |   917.540 |   894.741 |
| YGroup2TransposeBenchmark_Int32 | SumBase                  |       358.455 |   351.127 |   352.396 |  2196.948 |  2607.987 |
| YGroup2TransposeBenchmark_Int32 | SumTraits                |       357.918 |  3489.579 |  3494.116 |  3935.018 |  3828.336 |
| YGroup2TransposeBenchmark_Int32 | Sum128Base_Basic         |       121.734 |   121.228 |   122.596 |   363.746 |   370.527 |
| YGroup2TransposeBenchmark_Int32 | Sum128Base_Shift         |               |           |           |  2447.425 |  2607.325 |
| YGroup2TransposeBenchmark_Int32 | Sum128Base_Shuffle       |               |           |           |    43.372 |    43.816 |
| YGroup2TransposeBenchmark_Int32 | Sum128Base               |       117.853 |   122.228 |   122.205 |  2442.812 |  2606.337 |
| YGroup2TransposeBenchmark_Int32 | Sum128AdvSimd_Shift      |               |  2113.498 |  2112.835 |  2444.736 |  2607.062 |
| YGroup2TransposeBenchmark_Int32 | Sum128AdvSimd_Shuffle    |               |   779.963 |   766.075 |   954.362 |   932.805 |
| YGroup2TransposeBenchmark_Int32 | Sum128AdvSimd_ShuffleX   |               |           |           |           |  1307.495 |
| YGroup2TransposeBenchmark_Int32 | Sum128AdvSimdB64         |               |  3502.993 |  3500.749 |  3942.317 |  3832.846 |
| YGroup2TransposeBenchmark_Int32 | Sum128PackedSimd_Shift   |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum128PackedSimd_Shuffle |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum128Sse_Shift          |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum128Sse_Shuffle        |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum128Sse_ShuffleX       |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum128Sse_ShuffleXImm    |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum128Sse_Unpack         |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum128Traits             |       121.102 |  3478.128 |  3488.660 |  3941.958 |  3822.432 |
| YGroup2TransposeBenchmark_Int32 | Sum256Base_Basic         |       119.120 |   175.473 |   179.034 |   148.313 |   531.346 |
| YGroup2TransposeBenchmark_Int32 | Sum256Base_Shift         |               |           |           |    88.557 |  3517.207 |
| YGroup2TransposeBenchmark_Int32 | Sum256Base_Shuffle       |               |           |           |    24.063 |    44.388 |
| YGroup2TransposeBenchmark_Int32 | Sum256Base               |       115.130 |   175.230 |   177.852 |   148.231 |   532.904 |
| YGroup2TransposeBenchmark_Int32 | Sum256Avx2_Shift         |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum256Avx2_Shuffle       |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum256Avx2_ShuffleX      |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum256Avx2_ShuffleXImm   |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum256Avx2_Unpack        |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum256Traits             |        96.499 |   175.487 |   178.348 |   148.287 |   531.218 |
| YGroup2TransposeBenchmark_Int32 | Sum512Base_Basic         |               |           |           |           |   619.908 |
| YGroup2TransposeBenchmark_Int32 | Sum512Base_Shift         |               |           |           |           |  4062.257 |
| YGroup2TransposeBenchmark_Int32 | Sum512Base_Shuffle       |               |           |           |           |    25.965 |
| YGroup2TransposeBenchmark_Int32 | Sum512Base               |               |           |           |           |   618.760 |
| YGroup2TransposeBenchmark_Int32 | Sum512Avx512_Shift       |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum512Avx512_Shuffle     |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum512Avx512_ShuffleX    |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum512Avx512_ShuffleXImm |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum512Avx512_Unpack      |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int32 | Sum512Traits             |               |           |           |           |   618.868 |
| YGroup2TransposeBenchmark_Int64 | SumBase_Basic            |       371.379 |   376.891 |   382.218 |   385.780 |   386.122 |
| YGroup2TransposeBenchmark_Int64 | SumBase                  |       379.934 |   376.775 |   376.695 |   380.203 |   385.831 |
| YGroup2TransposeBenchmark_Int64 | SumTraits                |       380.248 |  1630.443 |  1751.755 |  1967.158 |  2034.799 |
| YGroup2TransposeBenchmark_Int64 | Sum128Base_Basic         |       172.535 |   162.637 |   164.587 |   380.507 |   382.675 |
| YGroup2TransposeBenchmark_Int64 | Sum128Base_Move          |       142.511 |   258.569 |   244.889 |  1399.903 |  1293.562 |
| YGroup2TransposeBenchmark_Int64 | Sum128Base_Shuffle       |               |           |           |    21.697 |    21.713 |
| YGroup2TransposeBenchmark_Int64 | Sum128Base               |       173.672 |   161.330 |   165.150 |  1400.001 |  1292.560 |
| YGroup2TransposeBenchmark_Int64 | Sum128AdvSimd_AlignRight |               |  1471.262 |  1490.869 |  1635.254 |  1642.530 |
| YGroup2TransposeBenchmark_Int64 | Sum128AdvSimd_Shuffle    |               |   386.875 |   383.661 |   477.816 |   468.729 |
| YGroup2TransposeBenchmark_Int64 | Sum128AdvSimd_ShuffleX   |               |           |           |           |   657.624 |
| YGroup2TransposeBenchmark_Int64 | Sum128AdvSimdB64         |               |  1625.103 |  1752.669 |  1971.497 |  2038.941 |
| YGroup2TransposeBenchmark_Int64 | Sum128PackedSimd_Shuffle |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum128Sse_Shuffle        |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum128Sse_ShuffleX       |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum128Sse_ShuffleXImm    |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum128Sse_Unpack         |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum128Traits             |       173.347 |  1624.481 |  1757.701 |  1964.536 |  2038.923 |
| YGroup2TransposeBenchmark_Int64 | Sum256Base_Basic         |        77.443 |   138.789 |   142.669 |   122.338 |   494.839 |
| YGroup2TransposeBenchmark_Int64 | Sum256Base_Shuffle       |               |           |           |    12.692 |    22.321 |
| YGroup2TransposeBenchmark_Int64 | Sum256Base               |        74.155 |   136.037 |   142.205 |   121.053 |   494.810 |
| YGroup2TransposeBenchmark_Int64 | Sum256Avx2_Shuffle       |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum256Avx2_ShuffleX      |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum256Avx2_ShuffleXImm   |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum256Avx2_Unpack        |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum256Traits             |        58.936 |   136.445 |   142.356 |   120.771 |   494.958 |
| YGroup2TransposeBenchmark_Int64 | Sum512Base_Basic         |               |           |           |           |   436.363 |
| YGroup2TransposeBenchmark_Int64 | Sum512Base_Shuffle       |               |           |           |           |    12.833 |
| YGroup2TransposeBenchmark_Int64 | Sum512Avx512_Shuffle     |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum512Avx512_ShuffleX    |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum512Avx512_ShuffleXImm |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum512Avx512_Unpack      |               |           |           |           |           |
| YGroup2TransposeBenchmark_Int64 | Sum512Traits             |               |           |           |           |   436.245 |

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                            | Method                   | .NET 8.0 |
| :------------------------------ | :----------------------- | -------: |
| YGroup2TransposeBenchmark_Byte  | SumBase_Basic            |   22.157 |
| YGroup2TransposeBenchmark_Byte  | SumBase_Shift            |   38.032 |
| YGroup2TransposeBenchmark_Byte  | SumBase_ShiftByMul       |    6.151 |
| YGroup2TransposeBenchmark_Byte  | SumBase                  |   22.668 |
| YGroup2TransposeBenchmark_Byte  | SumTraits                |  102.363 |
| YGroup2TransposeBenchmark_Byte  | Sum128Base_Basic         |   21.870 |
| YGroup2TransposeBenchmark_Byte  | Sum128Base_Shift         |  124.000 |
| YGroup2TransposeBenchmark_Byte  | Sum128Base_Shuffle       |   55.794 |
| YGroup2TransposeBenchmark_Byte  | Sum128Base               |  124.460 |
| YGroup2TransposeBenchmark_Byte  | Sum128AdvSimd_Shift      |          |
| YGroup2TransposeBenchmark_Byte  | Sum128AdvSimd_Shuffle    |          |
| YGroup2TransposeBenchmark_Byte  | Sum128AdvSimd_ShuffleX   |          |
| YGroup2TransposeBenchmark_Byte  | Sum128AdvSimdB64         |          |
| YGroup2TransposeBenchmark_Byte  | Sum128PackedSimd_Shift   |  121.223 |
| YGroup2TransposeBenchmark_Byte  | Sum128PackedSimd_Shuffle |  122.895 |
| YGroup2TransposeBenchmark_Byte  | Sum128Sse_Shift          |          |
| YGroup2TransposeBenchmark_Byte  | Sum128Sse_Shuffle        |          |
| YGroup2TransposeBenchmark_Byte  | Sum128Sse_ShuffleX       |          |
| YGroup2TransposeBenchmark_Byte  | Sum128Sse_ShuffleXImm    |          |
| YGroup2TransposeBenchmark_Byte  | Sum128Sse_Unpack         |          |
| YGroup2TransposeBenchmark_Byte  | Sum128Traits             |  126.700 |
| YGroup2TransposeBenchmark_Byte  | Sum256Base_Basic         |   20.445 |
| YGroup2TransposeBenchmark_Byte  | Sum256Base_Shift         |   18.314 |
| YGroup2TransposeBenchmark_Byte  | Sum256Base_Shuffle       |    4.983 |
| YGroup2TransposeBenchmark_Byte  | Sum256Base               |   19.839 |
| YGroup2TransposeBenchmark_Byte  | Sum256Avx2_Shift         |          |
| YGroup2TransposeBenchmark_Byte  | Sum256Avx2_Shuffle       |          |
| YGroup2TransposeBenchmark_Byte  | Sum256Avx2_ShuffleX      |          |
| YGroup2TransposeBenchmark_Byte  | Sum256Avx2_ShuffleXImm   |          |
| YGroup2TransposeBenchmark_Byte  | Sum256Avx2_Unpack        |          |
| YGroup2TransposeBenchmark_Byte  | Sum256Traits             |   19.382 |
| YGroup2TransposeBenchmark_Byte  | Sum512Base_Basic         |   19.735 |
| YGroup2TransposeBenchmark_Byte  | Sum512Base_Shift         |   13.262 |
| YGroup2TransposeBenchmark_Byte  | Sum512Base_Shuffle       |    4.975 |
| YGroup2TransposeBenchmark_Byte  | Sum512Base               |   18.487 |
| YGroup2TransposeBenchmark_Byte  | Sum512Avx512_Shift       |          |
| YGroup2TransposeBenchmark_Byte  | Sum512Avx512_Shuffle     |          |
| YGroup2TransposeBenchmark_Byte  | Sum512Avx512_ShuffleX    |          |
| YGroup2TransposeBenchmark_Byte  | Sum512Avx512_ShuffleXImm |          |
| YGroup2TransposeBenchmark_Byte  | Sum512Avx512_Unpack      |          |
| YGroup2TransposeBenchmark_Byte  | Sum512Traits             |   18.194 |
| YGroup2TransposeBenchmark_Int16 | SumBase_Basic            |   15.494 |
| YGroup2TransposeBenchmark_Int16 | SumBase_Shift            |   20.928 |
| YGroup2TransposeBenchmark_Int16 | SumBase_ShiftByMul       |    7.745 |
| YGroup2TransposeBenchmark_Int16 | SumBase                  |   16.029 |
| YGroup2TransposeBenchmark_Int16 | SumTraits                |   50.412 |
| YGroup2TransposeBenchmark_Int16 | Sum128Base_Basic         |   16.346 |
| YGroup2TransposeBenchmark_Int16 | Sum128Base_Shift         |   61.970 |
| YGroup2TransposeBenchmark_Int16 | Sum128Base_Shuffle       |   27.459 |
| YGroup2TransposeBenchmark_Int16 | Sum128Base               |   62.836 |
| YGroup2TransposeBenchmark_Int16 | Sum128AdvSimd_Shift      |          |
| YGroup2TransposeBenchmark_Int16 | Sum128AdvSimd_Shuffle    |          |
| YGroup2TransposeBenchmark_Int16 | Sum128AdvSimd_ShuffleX   |          |
| YGroup2TransposeBenchmark_Int16 | Sum128AdvSimdB64         |          |
| YGroup2TransposeBenchmark_Int16 | Sum128PackedSimd_Shift   |   62.625 |
| YGroup2TransposeBenchmark_Int16 | Sum128PackedSimd_Shuffle |   60.451 |
| YGroup2TransposeBenchmark_Int16 | Sum128Sse_Shift          |          |
| YGroup2TransposeBenchmark_Int16 | Sum128Sse_Shuffle        |          |
| YGroup2TransposeBenchmark_Int16 | Sum128Sse_ShuffleX       |          |
| YGroup2TransposeBenchmark_Int16 | Sum128Sse_ShuffleXImm    |          |
| YGroup2TransposeBenchmark_Int16 | Sum128Sse_Unpack         |          |
| YGroup2TransposeBenchmark_Int16 | Sum128Traits             |   61.466 |
| YGroup2TransposeBenchmark_Int16 | Sum256Base_Basic         |   13.824 |
| YGroup2TransposeBenchmark_Int16 | Sum256Base_Shift         |    9.610 |
| YGroup2TransposeBenchmark_Int16 | Sum256Base_Shuffle       |    2.515 |
| YGroup2TransposeBenchmark_Int16 | Sum256Base               |   14.029 |
| YGroup2TransposeBenchmark_Int16 | Sum256Avx2_Shift         |          |
| YGroup2TransposeBenchmark_Int16 | Sum256Avx2_Shuffle       |          |
| YGroup2TransposeBenchmark_Int16 | Sum256Avx2_ShuffleX      |          |
| YGroup2TransposeBenchmark_Int16 | Sum256Avx2_ShuffleXImm   |          |
| YGroup2TransposeBenchmark_Int16 | Sum256Avx2_Unpack        |          |
| YGroup2TransposeBenchmark_Int16 | Sum256Traits             |   12.557 |
| YGroup2TransposeBenchmark_Int16 | Sum512Base_Basic         |   12.880 |
| YGroup2TransposeBenchmark_Int16 | Sum512Base_Shift         |    6.639 |
| YGroup2TransposeBenchmark_Int16 | Sum512Base_Shuffle       |    2.485 |
| YGroup2TransposeBenchmark_Int16 | Sum512Base               |   13.045 |
| YGroup2TransposeBenchmark_Int16 | Sum512Avx512_Shift       |          |
| YGroup2TransposeBenchmark_Int16 | Sum512Avx512_Shuffle     |          |
| YGroup2TransposeBenchmark_Int16 | Sum512Avx512_ShuffleX    |          |
| YGroup2TransposeBenchmark_Int16 | Sum512Avx512_ShuffleXImm |          |
| YGroup2TransposeBenchmark_Int16 | Sum512Avx512_Unpack      |          |
| YGroup2TransposeBenchmark_Int16 | Sum512Traits             |   12.173 |
| YGroup2TransposeBenchmark_Int32 | SumBase_Basic            |   10.723 |
| YGroup2TransposeBenchmark_Int32 | SumBase_Shift            |   11.975 |
| YGroup2TransposeBenchmark_Int32 | SumBase_ShiftByMul       |    2.512 |
| YGroup2TransposeBenchmark_Int32 | SumBase                  |   10.735 |
| YGroup2TransposeBenchmark_Int32 | SumTraits                |   24.919 |
| YGroup2TransposeBenchmark_Int32 | Sum128Base_Basic         |   11.605 |
| YGroup2TransposeBenchmark_Int32 | Sum128Base_Shift         |   30.346 |
| YGroup2TransposeBenchmark_Int32 | Sum128Base_Shuffle       |   13.965 |
| YGroup2TransposeBenchmark_Int32 | Sum128Base               |   30.545 |
| YGroup2TransposeBenchmark_Int32 | Sum128AdvSimd_Shift      |          |
| YGroup2TransposeBenchmark_Int32 | Sum128AdvSimd_Shuffle    |          |
| YGroup2TransposeBenchmark_Int32 | Sum128AdvSimd_ShuffleX   |          |
| YGroup2TransposeBenchmark_Int32 | Sum128AdvSimdB64         |          |
| YGroup2TransposeBenchmark_Int32 | Sum128PackedSimd_Shift   |   31.524 |
| YGroup2TransposeBenchmark_Int32 | Sum128PackedSimd_Shuffle |   29.949 |
| YGroup2TransposeBenchmark_Int32 | Sum128Sse_Shift          |          |
| YGroup2TransposeBenchmark_Int32 | Sum128Sse_Shuffle        |          |
| YGroup2TransposeBenchmark_Int32 | Sum128Sse_ShuffleX       |          |
| YGroup2TransposeBenchmark_Int32 | Sum128Sse_ShuffleXImm    |          |
| YGroup2TransposeBenchmark_Int32 | Sum128Sse_Unpack         |          |
| YGroup2TransposeBenchmark_Int32 | Sum128Traits             |   31.426 |
| YGroup2TransposeBenchmark_Int32 | Sum256Base_Basic         |    9.174 |
| YGroup2TransposeBenchmark_Int32 | Sum256Base_Shift         |    4.774 |
| YGroup2TransposeBenchmark_Int32 | Sum256Base_Shuffle       |    1.277 |
| YGroup2TransposeBenchmark_Int32 | Sum256Base               |    9.098 |
| YGroup2TransposeBenchmark_Int32 | Sum256Avx2_Shift         |          |
| YGroup2TransposeBenchmark_Int32 | Sum256Avx2_Shuffle       |          |
| YGroup2TransposeBenchmark_Int32 | Sum256Avx2_ShuffleX      |          |
| YGroup2TransposeBenchmark_Int32 | Sum256Avx2_ShuffleXImm   |          |
| YGroup2TransposeBenchmark_Int32 | Sum256Avx2_Unpack        |          |
| YGroup2TransposeBenchmark_Int32 | Sum256Traits             |    7.955 |
| YGroup2TransposeBenchmark_Int32 | Sum512Base_Basic         |    8.411 |
| YGroup2TransposeBenchmark_Int32 | Sum512Base_Shift         |    3.413 |
| YGroup2TransposeBenchmark_Int32 | Sum512Base_Shuffle       |    1.214 |
| YGroup2TransposeBenchmark_Int32 | Sum512Base               |    8.534 |
| YGroup2TransposeBenchmark_Int32 | Sum512Avx512_Shift       |          |
| YGroup2TransposeBenchmark_Int32 | Sum512Avx512_Shuffle     |          |
| YGroup2TransposeBenchmark_Int32 | Sum512Avx512_ShuffleX    |          |
| YGroup2TransposeBenchmark_Int32 | Sum512Avx512_ShuffleXImm |          |
| YGroup2TransposeBenchmark_Int32 | Sum512Avx512_Unpack      |          |
| YGroup2TransposeBenchmark_Int32 | Sum512Traits             |    8.265 |
| YGroup2TransposeBenchmark_Int64 | SumBase_Basic            |    3.612 |
| YGroup2TransposeBenchmark_Int64 | SumBase                  |    3.607 |
| YGroup2TransposeBenchmark_Int64 | SumTraits                |    4.275 |
| YGroup2TransposeBenchmark_Int64 | Sum128Base_Basic         |    1.971 |
| YGroup2TransposeBenchmark_Int64 | Sum128Base_Move          |    2.043 |
| YGroup2TransposeBenchmark_Int64 | Sum128Base_Shuffle       |    1.865 |
| YGroup2TransposeBenchmark_Int64 | Sum128Base               |    2.217 |
| YGroup2TransposeBenchmark_Int64 | Sum128AdvSimd_AlignRight |          |
| YGroup2TransposeBenchmark_Int64 | Sum128AdvSimd_Shuffle    |          |
| YGroup2TransposeBenchmark_Int64 | Sum128AdvSimd_ShuffleX   |          |
| YGroup2TransposeBenchmark_Int64 | Sum128AdvSimdB64         |          |
| YGroup2TransposeBenchmark_Int64 | Sum128PackedSimd_Shuffle |   15.695 |
| YGroup2TransposeBenchmark_Int64 | Sum128Sse_Shuffle        |          |
| YGroup2TransposeBenchmark_Int64 | Sum128Sse_ShuffleX       |          |
| YGroup2TransposeBenchmark_Int64 | Sum128Sse_ShuffleXImm    |          |
| YGroup2TransposeBenchmark_Int64 | Sum128Sse_Unpack         |          |
| YGroup2TransposeBenchmark_Int64 | Sum128Traits             |   15.369 |
| YGroup2TransposeBenchmark_Int64 | Sum256Base_Basic         |    1.725 |
| YGroup2TransposeBenchmark_Int64 | Sum256Base_Shuffle       |    0.505 |
| YGroup2TransposeBenchmark_Int64 | Sum256Base               |    1.787 |
| YGroup2TransposeBenchmark_Int64 | Sum256Avx2_Shuffle       |          |
| YGroup2TransposeBenchmark_Int64 | Sum256Avx2_ShuffleX      |          |
| YGroup2TransposeBenchmark_Int64 | Sum256Avx2_ShuffleXImm   |          |
| YGroup2TransposeBenchmark_Int64 | Sum256Avx2_Unpack        |          |
| YGroup2TransposeBenchmark_Int64 | Sum256Traits             |    3.994 |
| YGroup2TransposeBenchmark_Int64 | Sum512Base_Basic         |    1.814 |
| YGroup2TransposeBenchmark_Int64 | Sum512Base_Shuffle       |    0.499 |
| YGroup2TransposeBenchmark_Int64 | Sum512Avx512_Shuffle     |          |
| YGroup2TransposeBenchmark_Int64 | Sum512Avx512_ShuffleX    |          |
| YGroup2TransposeBenchmark_Int64 | Sum512Avx512_ShuffleXImm |          |
| YGroup2TransposeBenchmark_Int64 | Sum512Avx512_Unpack      |          |
| YGroup2TransposeBenchmark_Int64 | Sum512Traits             |    4.527 |

