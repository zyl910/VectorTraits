# Benchmark group - YGroup1ToGroup3
([← Back](YGroup1ToGroup3.md))

Unit of data: Million operations per second. The larger the number, the better the performance.
### X86 - AMD Ryzen 7 7840H
| Type                           | Method                   | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :----------------------------- | :----------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| YGroup1ToGroup3Benchmark_Byte  | SumBase_Basic            |        201.212 |       569.905 |       559.971 |   565.897 |   577.907 |   481.910 |   657.775 |
| YGroup1ToGroup3Benchmark_Byte  | SumBase_Zip              |        309.448 |       539.563 |       572.491 |   516.651 |   567.679 |  1594.596 |  1694.728 |
| YGroup1ToGroup3Benchmark_Byte  | SumBase                  |        312.110 |       530.879 |       565.638 |   501.590 |   555.634 |  1581.913 |  1697.482 |
| YGroup1ToGroup3Benchmark_Byte  | SumTraits                |        304.782 |       528.698 |     20496.271 | 24942.998 | 26852.829 | 28010.644 | 32791.571 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Base_Basic         |                |               |       271.118 |   267.551 |   264.023 |   471.610 |   590.259 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Base_Shuffle       |                |               |               |           |           |   341.619 |   344.590 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Base_Zip           |                |               |               |           |           |  2047.259 |   687.528 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Base               |                |               |       262.757 |   264.318 |   270.715 |  2088.283 |   710.799 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128AdvSimd_Shuffle    |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Byte  | Sum128AdvSimd_Zip        |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Byte  | Sum128AdvSimdB64_Shuffle |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Byte  | Sum128AdvSimdB64_Zip     |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Byte  | Sum128PackedSimd_Shuffle |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Byte  | Sum128PackedSimd_Zip     |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Sse_Shuffle        |                |               |     13111.956 | 17779.785 | 18619.346 | 19048.937 | 19210.301 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Sse_Zip            |                |               |      4791.792 |  6798.016 |  6872.608 |  8141.345 | 10265.847 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Traits             |                |               |     12543.228 | 18301.469 | 17646.411 | 19505.721 | 18367.247 |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Base_Basic         |                |               |       309.007 |   287.273 |   301.868 |   509.001 |   650.162 |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Base_Shuffle       |                |               |               |           |           |   369.747 |   373.700 |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Base_Zip           |                |               |               |           |           |  3175.860 |  1056.238 |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Base               |                |               |       313.530 |   272.748 |   305.018 |  3147.104 |  1095.968 |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Avx2_Shuffle       |                |               |     20655.074 | 26901.184 | 27122.757 | 28343.458 | 28915.108 |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Avx2_ShuffleX      |                |               |               |           |           |           | 34870.852 |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Avx2_Zip           |                |               |      9294.262 | 11591.582 | 11412.567 | 12095.607 | 20934.398 |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Traits             |                |               |     20912.985 | 27429.126 | 27053.606 | 26436.191 | 34609.174 |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Base_Basic         |                |               |               |           |           |           |   620.867 |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Base_Shuffle       |                |               |               |           |           |           |   363.143 |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Base_Zip           |                |               |               |           |           |           |  1319.164 |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Base               |                |               |               |           |           |           |  1346.947 |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Avx512_ShuffleX    |                |               |               |           |           |           | 43617.870 |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Avx512_Zip         |                |               |               |           |           |           | 25351.085 |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Traits             |                |               |               |           |           |           | 41332.581 |
| YGroup1ToGroup3Benchmark_Int16 | SumBase_Basic            |        156.709 |       427.982 |       446.237 |   470.927 |   480.360 |   423.314 |   576.318 |
| YGroup1ToGroup3Benchmark_Int16 | SumBase_Zip              |        256.464 |       434.690 |       502.766 |   377.265 |   486.560 |  1095.194 |  1133.078 |
| YGroup1ToGroup3Benchmark_Int16 | SumBase                  |        153.991 |       431.691 |       459.796 |   331.793 |   482.868 |   437.044 |   597.767 |
| YGroup1ToGroup3Benchmark_Int16 | SumTraits                |        163.171 |       419.570 |     10570.534 | 13845.445 | 13729.824 | 14023.718 | 16206.470 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Base_Basic         |                |               |       172.891 |   168.035 |   164.962 |   318.339 |   441.036 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Base_Shuffle       |                |               |               |           |           |   165.305 |   162.857 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Base_Zip           |                |               |               |           |           |  1455.200 |   660.635 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Base               |                |               |       170.959 |   168.736 |   165.525 |   341.432 |   444.489 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128AdvSimd_Shuffle    |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Int16 | Sum128AdvSimd_Zip        |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Int16 | Sum128AdvSimdB64_Shuffle |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Int16 | Sum128AdvSimdB64_Zip     |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Int16 | Sum128PackedSimd_Shuffle |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Int16 | Sum128PackedSimd_Zip     |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Sse_Shuffle        |                |               |      6580.527 |  9061.386 |  8975.554 |  9953.193 |  9164.452 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Sse_Zip            |                |               |      2381.624 |  3432.849 |  3434.066 |  4026.535 |  5114.630 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Traits             |                |               |      6635.593 |  9026.123 |  8667.774 |  9952.312 |  9120.436 |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Base_Basic         |                |               |       229.251 |   214.220 |   234.720 |   425.084 |   576.638 |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Base_Shuffle       |                |               |               |           |           |   183.781 |   181.848 |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Base_Zip           |                |               |               |           |           |  2047.525 |   747.146 |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Base               |                |               |       227.860 |   196.976 |   235.446 |   414.182 |   574.870 |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Avx2_Shuffle       |                |               |     10165.003 | 14169.380 | 13471.905 | 13531.276 | 14473.274 |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Avx2_ShuffleX      |                |               |               |           |           |           | 16429.405 |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Avx2_Zip           |                |               |      4449.502 |  6126.488 |  5579.248 |  6042.465 | 10295.021 |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Traits             |                |               |     10125.689 | 13250.631 | 13530.932 | 14018.333 | 16392.557 |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Base_Basic         |                |               |               |           |           |           |   587.391 |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Base_Shuffle       |                |               |               |           |           |           |   175.179 |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Base_Zip           |                |               |               |           |           |           |   854.684 |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Base               |                |               |               |           |           |           |   572.501 |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Avx512_ShuffleX    |                |               |               |           |           |           | 18683.500 |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Avx512_Zip         |                |               |               |           |           |           | 11488.119 |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Traits             |                |               |               |           |           |           | 18840.425 |
| YGroup1ToGroup3Benchmark_Int32 | SumBase_Basic            |        124.388 |       267.065 |       318.241 |   297.864 |   315.939 |   278.856 |   404.297 |
| YGroup1ToGroup3Benchmark_Int32 | SumBase_Zip              |        188.869 |       279.257 |       361.279 |   227.600 |   357.545 |   558.970 |   642.422 |
| YGroup1ToGroup3Benchmark_Int32 | SumBase                  |        126.009 |       274.032 |       307.709 |   196.963 |   323.196 |   281.132 |   402.613 |
| YGroup1ToGroup3Benchmark_Int32 | SumTraits                |        128.763 |       272.099 |      5912.002 |  8023.815 |  8155.602 |  8408.023 |  7940.467 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Base_Basic         |                |               |        99.746 |   100.828 |   100.147 |   197.243 |   278.266 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Base_Shuffle       |                |               |               |           |           |    84.034 |    83.460 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Base_Zip           |                |               |               |           |           |   822.260 |  1103.132 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Base               |                |               |       100.532 |   100.188 |   100.090 |   192.493 |   278.411 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128AdvSimd_Shuffle    |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum128AdvSimd_Zip        |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum128AdvSimdB64_Shuffle |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum128AdvSimdB64_Zip     |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum128PackedSimd_Shuffle |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum128PackedSimd_Zip     |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Sse_Shuffle        |                |               |      3157.854 |  4329.174 |  4418.355 |  4921.525 |  4676.505 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Sse_Zip            |                |               |      4108.937 |  4107.796 |  4124.548 |  4164.632 |  3915.989 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Traits             |                |               |      6328.526 |  5852.964 |  6267.487 |  5772.396 |  5862.637 |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Base_Basic         |                |               |       147.606 |   126.446 |   158.042 |   289.270 |   415.501 |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Base_Shuffle       |                |               |               |           |           |    93.069 |    92.734 |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Base_Zip           |                |               |               |           |           |  1125.801 |   833.784 |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Base               |                |               |       158.412 |   122.837 |   161.363 |   267.038 |   414.701 |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Avx2_Shuffle       |                |               |      5211.255 |  6713.910 |  6326.344 |  6626.700 |  6803.587 |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Avx2_ShuffleX      |                |               |               |           |           |           |  8008.941 |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Avx2_ShuffleXImm   |                |               |      8130.001 |  7925.183 |  7832.520 |  7983.594 |  7712.927 |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Avx2_Zip           |                |               |      5940.092 |  5893.323 |  5954.808 |  5839.314 |  5644.008 |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Traits             |                |               |      6159.607 |  8085.233 |  8352.016 |  8524.874 |  8089.788 |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Base_Basic         |                |               |               |           |           |           |   491.615 |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Base_Shuffle       |                |               |               |           |           |           |    95.497 |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Base_Zip           |                |               |               |           |           |           |   679.497 |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Base               |                |               |               |           |           |           |   491.309 |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Avx512_ShuffleX    |                |               |               |           |           |           |  9123.104 |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Avx512_ShuffleXImm |                |               |               |           |           |           |  6931.441 |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Avx512_Zip         |                |               |               |           |           |           |  5363.607 |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Traits             |                |               |               |           |           |           |  9083.674 |
| YGroup1ToGroup3Benchmark_Int64 | SumBase_Basic            |         88.433 |       150.533 |       177.280 |   169.596 |   175.835 |   155.039 |   247.348 |
| YGroup1ToGroup3Benchmark_Int64 | SumBase                  |         83.954 |       155.543 |       182.279 |   107.572 |   178.867 |   158.242 |   254.239 |
| YGroup1ToGroup3Benchmark_Int64 | SumTraits                |         86.064 |       151.261 |      4538.574 |  4697.509 |  4670.839 |  4533.808 |  4244.514 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Base_Basic         |                |               |        53.568 |    53.507 |    52.872 |   112.238 |   149.184 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Base_Move          |                |               |        63.735 |    64.941 |    65.144 |   152.857 |   279.122 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Base_Shuffle       |                |               |               |           |           |    64.690 |    64.141 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Base               |                |               |        64.212 |    64.840 |    64.795 |   153.852 |   279.088 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128AdvSimd_Shuffle    |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum128AdvSimd_Zip        |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum128AdvSimdB64_Move    |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum128AdvSimdB64_Shuffle |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum128AdvSimdB64_Zip     |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum128PackedSimd_Shuffle |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum128PackedSimd_Zip     |                |               |               |           |           |           |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Sse_Shuffle        |                |               |      2072.393 |  2890.429 |  2888.482 |  3402.042 |  3213.388 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Sse_Zip            |                |               |      3261.265 |  3216.820 |  3165.896 |  3017.366 |  3095.483 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Traits             |                |               |      3591.477 |  3571.370 |  3479.028 |  3465.500 |  3351.049 |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Base_Basic         |                |               |        83.677 |    70.129 |    91.190 |   158.905 |   248.341 |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Base_Shuffle       |                |               |               |           |           |    46.227 |    45.781 |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Base               |                |               |        90.046 |    67.285 |    90.832 |   158.448 |   251.046 |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Avx2_Shuffle       |                |               |      3348.187 |  4209.277 |  4138.127 |  3935.247 |  4288.609 |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Avx2_ShuffleX      |                |               |               |           |           |           |  4082.735 |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Avx2_ShuffleXImm   |                |               |      4590.304 |  4653.342 |  4624.727 |  4529.503 |  4565.062 |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Avx2_Zip           |                |               |      4179.180 |  4127.939 |  4266.810 |  3987.515 |  4093.651 |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Traits             |                |               |      4666.342 |  4742.007 |  4564.062 |  4530.563 |  4239.783 |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Base_Basic         |                |               |               |           |           |           |   315.533 |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Base_Shuffle       |                |               |               |           |           |           |    46.544 |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Base               |                |               |               |           |           |           |   313.328 |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Avx512_ShuffleX    |                |               |               |           |           |           |  4881.449 |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Avx512_ShuffleXImm |                |               |               |           |           |           |  3985.604 |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Avx512_Zip         |                |               |               |           |           |           |  3565.943 |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Traits             |                |               |               |           |           |           |  4905.752 |

### Arm - Apple M2
| Type                           | Method                   |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :----------------------------- | :----------------------- | --------: | --------: | --------: |
| YGroup1ToGroup3Benchmark_Byte  | SumBase_Basic            |   711.295 |   767.751 |   926.887 |
| YGroup1ToGroup3Benchmark_Byte  | SumBase_Zip              |   829.041 |  2638.149 |  2615.393 |
| YGroup1ToGroup3Benchmark_Byte  | SumBase                  |   829.086 |  2637.875 |  2614.729 |
| YGroup1ToGroup3Benchmark_Byte  | SumTraits                | 27099.355 | 27026.176 | 27063.402 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Base_Basic         |   455.939 |   767.689 |   926.260 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Base_Shuffle       |           |   672.796 |   672.803 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Base_Zip           |           |  3230.266 |  1884.924 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Base               |   455.951 |  3231.140 |  1904.481 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128AdvSimd_Shuffle    | 14022.513 | 14316.149 | 14308.316 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128AdvSimd_Zip        |  4730.770 |  4787.301 |  8700.760 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128AdvSimdB64_Shuffle | 27114.430 | 27022.407 | 27136.482 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128AdvSimdB64_Zip     | 12072.611 | 12070.029 | 16717.159 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128PackedSimd_Shuffle |           |           |           |
| YGroup1ToGroup3Benchmark_Byte  | Sum128PackedSimd_Zip     |           |           |           |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Sse_Shuffle        |           |           |           |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Sse_Zip            |           |           |           |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Traits             | 27110.833 | 27025.958 | 27140.054 |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Base_Basic         |   444.925 |   379.956 |   930.070 |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Base_Shuffle       |           |   258.512 |   339.238 |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Base_Zip           |           |   451.177 |  1733.363 |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Base               |   442.039 |   379.686 |   922.888 |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Avx2_Shuffle       |           |           |           |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Avx2_ShuffleX      |           |           |           |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Avx2_Zip           |           |           |           |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Traits             |   422.768 |   379.368 |   922.780 |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Base_Basic         |           |           |   838.023 |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Base_Shuffle       |           |           |   382.682 |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Base_Zip           |           |           |  1317.458 |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Base               |           |           |   897.385 |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Avx512_ShuffleX    |           |           |           |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Avx512_Zip         |           |           |           |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Traits             |           |           |   897.599 |
| YGroup1ToGroup3Benchmark_Int16 | SumBase_Basic            |   557.411 |   623.502 |   870.597 |
| YGroup1ToGroup3Benchmark_Int16 | SumBase_Zip              |   665.480 |  1428.912 |  1408.964 |
| YGroup1ToGroup3Benchmark_Int16 | SumBase                  |   569.708 |   625.137 |   876.568 |
| YGroup1ToGroup3Benchmark_Int16 | SumTraits                | 13580.473 | 13527.752 | 13539.665 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Base_Basic         |   387.867 |   626.038 |   871.140 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Base_Shuffle       |           |   336.372 |   336.408 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Base_Zip           |           |  2240.782 |  1618.859 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Base               |   383.948 |   625.056 |   876.595 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128AdvSimd_Shuffle    |  7015.349 |  7165.037 |  7156.675 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128AdvSimd_Zip        |  2365.458 |  2394.876 |  4352.483 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128AdvSimdB64_Shuffle | 13576.926 | 13525.622 | 13573.173 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128AdvSimdB64_Zip     |  6040.252 |  6039.878 |  8365.533 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128PackedSimd_Shuffle |           |           |           |
| YGroup1ToGroup3Benchmark_Int16 | Sum128PackedSimd_Zip     |           |           |           |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Sse_Shuffle        |           |           |           |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Sse_Zip            |           |           |           |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Traits             | 13548.803 | 13525.378 | 13576.243 |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Base_Basic         |   366.973 |   331.299 |   876.175 |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Base_Shuffle       |           |   144.623 |   306.563 |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Base_Zip           |           |   288.294 |   801.567 |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Base               |   368.188 |   329.307 |   870.574 |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Avx2_Shuffle       |           |           |           |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Avx2_ShuffleX      |           |           |           |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Avx2_Zip           |           |           |           |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Traits             |   368.512 |   329.009 |   870.484 |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Base_Basic         |           |           |   809.407 |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Base_Shuffle       |           |           |   190.357 |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Base_Zip           |           |           |   617.168 |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Base               |           |           |   811.022 |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Avx512_ShuffleX    |           |           |           |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Avx512_Zip         |           |           |           |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Traits             |           |           |   807.656 |
| YGroup1ToGroup3Benchmark_Int32 | SumBase_Basic            |   396.544 |   435.302 |   725.199 |
| YGroup1ToGroup3Benchmark_Int32 | SumBase_Zip              |   557.862 |  1205.663 |  1185.101 |
| YGroup1ToGroup3Benchmark_Int32 | SumBase                  |   396.004 |   435.126 |   725.191 |
| YGroup1ToGroup3Benchmark_Int32 | SumTraits                |  6794.900 |  6768.263 |  6769.722 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Base_Basic         |   275.874 |   437.049 |   725.133 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Base_Shuffle       |           |   168.171 |   168.191 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Base_Zip           |           |  1812.350 |  1918.821 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Base               |   280.072 |   435.619 |   725.107 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128AdvSimd_Shuffle    |  3509.474 |  3582.178 |  3580.869 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128AdvSimd_Zip        |  1813.200 |  1812.298 |  2176.490 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128AdvSimdB64_Shuffle |  6796.050 |  6769.192 |  6788.508 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128AdvSimdB64_Zip     |  3884.418 |  3885.557 |  4184.695 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128PackedSimd_Shuffle |           |           |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum128PackedSimd_Zip     |           |           |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Sse_Shuffle        |           |           |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Sse_Zip            |           |           |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Traits             |  6794.822 |  6768.202 |  6789.677 |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Base_Basic         |   245.773 |   256.442 |   787.068 |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Base_Shuffle       |           |    78.850 |   153.195 |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Base_Zip           |           |   190.323 |   508.199 |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Base               |   246.167 |   257.048 |   787.167 |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Avx2_Shuffle       |           |           |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Avx2_ShuffleX      |           |           |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Avx2_ShuffleXImm   |           |           |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Avx2_Zip           |           |           |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Traits             |   245.794 |   256.621 |   787.385 |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Base_Basic         |           |           |   689.522 |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Base_Shuffle       |           |           |    97.802 |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Base_Zip           |           |           |   310.130 |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Base               |           |           |   690.830 |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Avx512_ShuffleX    |           |           |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Avx512_ShuffleXImm |           |           |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Avx512_Zip         |           |           |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Traits             |           |           |   688.934 |
| YGroup1ToGroup3Benchmark_Int64 | SumBase_Basic            |   182.403 |   195.330 |   589.856 |
| YGroup1ToGroup3Benchmark_Int64 | SumBase                  |   181.942 |   195.527 |   587.510 |
| YGroup1ToGroup3Benchmark_Int64 | SumTraits                |  3357.413 |  3363.223 |  3362.746 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Base_Basic         |   134.325 |   196.058 |   589.903 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Base_Move          |   445.801 |  3394.989 |  3368.530 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Base_Shuffle       |           |   125.071 |   125.088 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Base               |   445.509 |  3394.429 |  3367.402 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128AdvSimd_Shuffle    |  2266.956 |  2452.523 |  2452.673 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128AdvSimd_Zip        |  3369.214 |  3373.619 |  3386.520 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128AdvSimdB64_Move    |  3356.965 |  3362.679 |  3354.361 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128AdvSimdB64_Shuffle |  3399.278 |  3398.402 |  3399.037 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128AdvSimdB64_Zip     |  3369.780 |  3373.630 |  3387.035 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128PackedSimd_Shuffle |           |           |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum128PackedSimd_Zip     |           |           |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Sse_Shuffle        |           |           |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Sse_Zip            |           |           |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Traits             |  3356.962 |  3362.838 |  3354.745 |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Base_Basic         |   136.599 |   152.801 |   522.411 |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Base_Shuffle       |           |    39.797 |    79.209 |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Base               |   137.437 |   152.543 |   524.141 |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Avx2_Shuffle       |           |           |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Avx2_ShuffleX      |           |           |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Avx2_ShuffleXImm   |           |           |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Avx2_Zip           |           |           |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Traits             |   137.601 |   152.696 |   524.260 |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Base_Basic         |           |           |   513.555 |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Base_Shuffle       |           |           |    47.579 |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Base               |           |           |   513.910 |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Avx512_ShuffleX    |           |           |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Avx512_ShuffleXImm |           |           |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Avx512_Zip         |           |           |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Traits             |           |           |   507.647 |

### Arm - AWS Arm t4g.small
| Type                           | Method                   | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 |  .NET 8.0 |
| :----------------------------- | :----------------------- | ------------: | -------: | -------: | -------: | --------: |
| YGroup1ToGroup3Benchmark_Byte  | SumBase_Basic            |       263.535 |  268.036 |  264.801 |  257.086 |   325.241 |
| YGroup1ToGroup3Benchmark_Byte  | SumBase_Zip              |       278.931 |  280.373 |  281.700 |  796.731 |   804.353 |
| YGroup1ToGroup3Benchmark_Byte  | SumBase                  |       278.875 |  281.212 |  281.434 |  797.058 |   804.406 |
| YGroup1ToGroup3Benchmark_Byte  | SumTraits                |       279.055 | 9835.776 | 9754.413 | 9720.851 | 11196.632 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Base_Basic         |       149.006 |  150.201 |  150.723 |  257.905 |   324.197 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Base_Shuffle       |               |          |          |  216.510 |   217.234 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Base_Zip           |               |          |          | 1064.116 |   560.385 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Base               |       148.404 |  150.156 |  150.497 | 1061.837 |   556.947 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128AdvSimd_Shuffle    |               | 3640.120 | 4011.689 | 4838.366 |  5212.471 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128AdvSimd_Zip        |               | 1434.441 | 1447.421 | 1714.445 |  2037.479 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128AdvSimdB64_Shuffle |               | 9832.696 | 9774.721 | 9784.189 | 11254.906 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128AdvSimdB64_Zip     |               | 3375.409 | 3606.464 | 4073.080 |  4404.951 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128PackedSimd_Shuffle |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Byte  | Sum128PackedSimd_Zip     |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Sse_Shuffle        |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Sse_Zip            |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Traits             |       148.895 | 9731.111 | 9864.138 | 9729.958 | 11255.776 |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Base_Basic         |       152.176 |  158.335 |  158.553 |  125.159 |   331.439 |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Base_Shuffle       |               |          |          |   91.868 |   133.397 |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Base_Zip           |               |          |          |  155.842 |   644.259 |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Base               |       150.921 |  157.536 |  158.120 |  125.542 |   331.520 |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Avx2_Shuffle       |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Avx2_ShuffleX      |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Avx2_Zip           |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Traits             |       131.083 |  152.899 |  153.226 |  125.567 |   332.231 |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Base_Basic         |               |          |          |          |   323.891 |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Base_Shuffle       |               |          |          |          |   135.297 |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Base_Zip           |               |          |          |          |   435.388 |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Base               |               |          |          |          |   323.409 |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Avx512_ShuffleX    |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Avx512_Zip         |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Traits             |               |          |          |          |   323.439 |
| YGroup1ToGroup3Benchmark_Int16 | SumBase_Basic            |       209.051 |  212.969 |  214.030 |  212.179 |   295.788 |
| YGroup1ToGroup3Benchmark_Int16 | SumBase_Zip              |       218.138 |  217.086 |  219.226 |  434.262 |   425.956 |
| YGroup1ToGroup3Benchmark_Int16 | SumBase                  |       207.301 |  211.730 |  211.722 |  212.183 |   296.510 |
| YGroup1ToGroup3Benchmark_Int16 | SumTraits                |       206.522 | 4780.104 | 4741.043 | 4959.038 |  5281.192 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Base_Basic         |       111.238 |  111.782 |  111.076 |  212.366 |   295.792 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Base_Shuffle       |               |          |          |  109.096 |   107.579 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Base_Zip           |               |          |          |  704.632 |   441.871 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Base               |       111.475 |  111.575 |  111.231 |  211.670 |   294.869 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128AdvSimd_Shuffle    |               | 1947.854 | 1909.914 | 2560.228 |  2470.682 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128AdvSimd_Zip        |               |  695.614 |  705.902 |  872.550 |   977.838 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128AdvSimdB64_Shuffle |               | 4738.337 | 4694.937 | 4944.177 |  5309.112 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128AdvSimdB64_Zip     |               | 1676.201 | 1828.396 | 2117.422 |  2023.202 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128PackedSimd_Shuffle |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int16 | Sum128PackedSimd_Zip     |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Sse_Shuffle        |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Sse_Zip            |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Traits             |       111.598 | 4320.930 | 4720.567 | 4944.316 |  5207.055 |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Base_Basic         |       101.067 |  122.495 |  118.670 |  103.414 |   303.213 |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Base_Shuffle       |               |          |          |   50.710 |    99.610 |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Base_Zip           |               |          |          |  102.865 |   299.509 |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Base               |        99.509 |  120.408 |  119.260 |  103.078 |   304.342 |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Avx2_Shuffle       |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Avx2_ShuffleX      |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Avx2_Zip           |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Traits             |        81.741 |  120.109 |  119.575 |  103.019 |   304.320 |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Base_Basic         |               |          |          |          |   281.867 |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Base_Shuffle       |               |          |          |          |    65.877 |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Base_Zip           |               |          |          |          |   221.542 |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Base               |               |          |          |          |   281.836 |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Avx512_ShuffleX    |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Avx512_Zip         |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Traits             |               |          |          |          |   281.451 |
| YGroup1ToGroup3Benchmark_Int32 | SumBase_Basic            |       149.606 |  151.940 |  153.003 |  149.449 |   232.515 |
| YGroup1ToGroup3Benchmark_Int32 | SumBase_Zip              |       183.528 |  177.285 |  179.744 |  353.154 |   343.321 |
| YGroup1ToGroup3Benchmark_Int32 | SumBase                  |       152.049 |  152.388 |  151.784 |  150.119 |   234.027 |
| YGroup1ToGroup3Benchmark_Int32 | SumTraits                |       152.364 | 2320.831 | 2338.269 | 2471.274 |  2623.663 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Base_Basic         |        74.115 |   73.673 |   73.713 |  150.321 |   233.946 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Base_Shuffle       |               |          |          |   54.430 |    53.693 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Base_Zip           |               |          |          |  540.456 |   553.902 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Base               |        73.723 |   73.475 |   73.591 |  150.122 |   232.032 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128AdvSimd_Shuffle    |               | 1033.593 | 1034.034 | 1271.500 |  1231.241 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128AdvSimd_Zip        |               |  506.905 |  508.906 |  539.701 |   494.953 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128AdvSimdB64_Shuffle |               | 2381.454 | 2304.038 | 2471.802 |  2612.431 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128AdvSimdB64_Zip     |               |  972.077 |  965.813 | 1092.202 |  1046.267 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128PackedSimd_Shuffle |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum128PackedSimd_Zip     |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Sse_Shuffle        |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Sse_Zip            |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Traits             |        74.162 | 2408.217 | 2326.887 | 2471.791 |  2610.040 |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Base_Basic         |        59.923 |   78.289 |   77.762 |   82.072 |   268.726 |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Base_Shuffle       |               |          |          |   28.607 |    49.770 |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Base_Zip           |               |          |          |   71.769 |   178.995 |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Base               |        58.801 |   75.642 |   77.612 |   82.119 |   268.343 |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Avx2_Shuffle       |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Avx2_ShuffleX      |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Avx2_ShuffleXImm   |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Avx2_Zip           |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Traits             |        47.745 |   75.790 |   77.694 |   81.952 |   268.280 |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Base_Basic         |               |          |          |          |   232.847 |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Base_Shuffle       |               |          |          |          |    33.016 |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Base_Zip           |               |          |          |          |   120.419 |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Base               |               |          |          |          |   232.267 |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Avx512_ShuffleX    |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Avx512_ShuffleXImm |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Avx512_Zip         |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Traits             |               |          |          |          |   233.267 |
| YGroup1ToGroup3Benchmark_Int64 | SumBase_Basic            |       104.263 |  100.861 |  103.549 |   96.562 |   210.628 |
| YGroup1ToGroup3Benchmark_Int64 | SumBase                  |       104.259 |  101.227 |  103.234 |   96.038 |   212.581 |
| YGroup1ToGroup3Benchmark_Int64 | SumTraits                |       104.155 | 1488.224 | 1475.517 | 1936.954 |  1622.809 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Base_Basic         |        70.083 |   67.745 |   72.264 |   96.248 |   213.132 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Base_Move          |       111.337 |  171.737 |  165.103 | 1090.819 |  1023.602 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Base_Shuffle       |               |          |          |   40.495 |    39.585 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Base               |       112.565 |  173.044 |  166.404 | 1089.591 |  1030.895 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128AdvSimd_Shuffle    |               |  702.378 |  708.572 |  861.187 |   821.687 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128AdvSimd_Zip        |               | 1043.906 | 1028.431 | 1217.006 |  1064.457 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128AdvSimdB64_Move    |               | 1484.275 | 1489.293 | 1938.141 |  1650.699 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128AdvSimdB64_Shuffle |               | 1364.253 | 1334.597 | 1630.523 |  1598.098 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128AdvSimdB64_Zip     |               | 1033.383 | 1018.483 | 1212.726 |  1064.226 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128PackedSimd_Shuffle |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum128PackedSimd_Zip     |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Sse_Shuffle        |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Sse_Zip            |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Traits             |       110.551 | 1472.196 | 1459.702 | 1934.692 |  1653.470 |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Base_Basic         |        38.212 |   55.340 |   53.837 |   63.692 |   221.753 |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Base_Shuffle       |               |          |          |   15.741 |    25.721 |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Base               |        37.000 |   54.034 |   55.276 |   64.069 |   222.780 |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Avx2_Shuffle       |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Avx2_ShuffleX      |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Avx2_ShuffleXImm   |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Avx2_Zip           |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Traits             |        27.131 |   53.676 |   53.539 |   63.806 |   222.741 |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Base_Basic         |               |          |          |          |   172.668 |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Base_Shuffle       |               |          |          |          |    16.385 |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Base               |               |          |          |          |   172.852 |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Avx512_ShuffleX    |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Avx512_ShuffleXImm |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Avx512_Zip         |               |          |          |          |           |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Traits             |               |          |          |          |   172.414 |

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                           | Method                   | .NET 8.0 |
| :----------------------------- | :----------------------- | -------: |
| YGroup1ToGroup3Benchmark_Byte  | SumBase_Basic            |    4.237 |
| YGroup1ToGroup3Benchmark_Byte  | SumBase_Zip              |   10.740 |
| YGroup1ToGroup3Benchmark_Byte  | SumBase                  |    4.275 |
| YGroup1ToGroup3Benchmark_Byte  | SumTraits                |  110.268 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Base_Basic         |    4.181 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Base_Shuffle       |   72.026 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Base_Zip           |   16.666 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Base               |   17.102 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128AdvSimd_Shuffle    |          |
| YGroup1ToGroup3Benchmark_Byte  | Sum128AdvSimd_Zip        |          |
| YGroup1ToGroup3Benchmark_Byte  | Sum128AdvSimdB64_Shuffle |          |
| YGroup1ToGroup3Benchmark_Byte  | Sum128AdvSimdB64_Zip     |          |
| YGroup1ToGroup3Benchmark_Byte  | Sum128PackedSimd_Shuffle |  150.277 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128PackedSimd_Zip     |   51.480 |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Sse_Shuffle        |          |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Sse_Zip            |          |
| YGroup1ToGroup3Benchmark_Byte  | Sum128Traits             |  153.837 |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Base_Basic         |    4.055 |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Base_Shuffle       |    6.405 |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Base_Zip           |   16.308 |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Base               |    4.128 |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Avx2_Shuffle       |          |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Avx2_ShuffleX      |          |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Avx2_Zip           |          |
| YGroup1ToGroup3Benchmark_Byte  | Sum256Traits             |    4.120 |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Base_Basic         |    4.085 |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Base_Shuffle       |    6.101 |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Base_Zip           |    9.206 |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Base               |    3.874 |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Avx512_ShuffleX    |          |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Avx512_Zip         |          |
| YGroup1ToGroup3Benchmark_Byte  | Sum512Traits             |    4.098 |
| YGroup1ToGroup3Benchmark_Int16 | SumBase_Basic            |    3.641 |
| YGroup1ToGroup3Benchmark_Int16 | SumBase_Zip              |    7.828 |
| YGroup1ToGroup3Benchmark_Int16 | SumBase                  |    3.543 |
| YGroup1ToGroup3Benchmark_Int16 | SumTraits                |   53.871 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Base_Basic         |    3.621 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Base_Shuffle       |   36.816 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Base_Zip           |    7.793 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Base               |    3.573 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128AdvSimd_Shuffle    |          |
| YGroup1ToGroup3Benchmark_Int16 | Sum128AdvSimd_Zip        |          |
| YGroup1ToGroup3Benchmark_Int16 | Sum128AdvSimdB64_Shuffle |          |
| YGroup1ToGroup3Benchmark_Int16 | Sum128AdvSimdB64_Zip     |          |
| YGroup1ToGroup3Benchmark_Int16 | Sum128PackedSimd_Shuffle |   75.618 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128PackedSimd_Zip     |   25.277 |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Sse_Shuffle        |          |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Sse_Zip            |          |
| YGroup1ToGroup3Benchmark_Int16 | Sum128Traits             |   76.451 |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Base_Basic         |    3.436 |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Base_Shuffle       |    2.994 |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Base_Zip           |    5.502 |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Base               |    3.510 |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Avx2_Shuffle       |          |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Avx2_ShuffleX      |          |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Avx2_Zip           |          |
| YGroup1ToGroup3Benchmark_Int16 | Sum256Traits             |    3.306 |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Base_Basic         |    3.263 |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Base_Shuffle       |    2.958 |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Base_Zip           |    4.863 |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Base               |    3.517 |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Avx512_ShuffleX    |          |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Avx512_Zip         |          |
| YGroup1ToGroup3Benchmark_Int16 | Sum512Traits             |    3.331 |
| YGroup1ToGroup3Benchmark_Int32 | SumBase_Basic            |    2.927 |
| YGroup1ToGroup3Benchmark_Int32 | SumBase_Zip              |    5.557 |
| YGroup1ToGroup3Benchmark_Int32 | SumBase                  |    2.921 |
| YGroup1ToGroup3Benchmark_Int32 | SumTraits                |   28.650 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Base_Basic         |    2.893 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Base_Shuffle       |   18.306 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Base_Zip           |    5.526 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Base               |    2.828 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128AdvSimd_Shuffle    |          |
| YGroup1ToGroup3Benchmark_Int32 | Sum128AdvSimd_Zip        |          |
| YGroup1ToGroup3Benchmark_Int32 | Sum128AdvSimdB64_Shuffle |          |
| YGroup1ToGroup3Benchmark_Int32 | Sum128AdvSimdB64_Zip     |          |
| YGroup1ToGroup3Benchmark_Int32 | Sum128PackedSimd_Shuffle |   38.965 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128PackedSimd_Zip     |   12.753 |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Sse_Shuffle        |          |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Sse_Zip            |          |
| YGroup1ToGroup3Benchmark_Int32 | Sum128Traits             |   37.895 |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Base_Basic         |    2.819 |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Base_Shuffle       |    1.568 |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Base_Zip           |    3.501 |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Base               |    2.798 |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Avx2_Shuffle       |          |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Avx2_ShuffleX      |          |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Avx2_ShuffleXImm   |          |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Avx2_Zip           |          |
| YGroup1ToGroup3Benchmark_Int32 | Sum256Traits             |    2.609 |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Base_Basic         |    2.819 |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Base_Shuffle       |    1.582 |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Base_Zip           |    2.723 |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Base               |    2.786 |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Avx512_ShuffleX    |          |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Avx512_ShuffleXImm |          |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Avx512_Zip         |          |
| YGroup1ToGroup3Benchmark_Int32 | Sum512Traits             |    2.709 |
| YGroup1ToGroup3Benchmark_Int64 | SumBase_Basic            |    1.429 |
| YGroup1ToGroup3Benchmark_Int64 | SumBase                  |    1.435 |
| YGroup1ToGroup3Benchmark_Int64 | SumTraits                |    3.240 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Base_Basic         |    0.957 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Base_Move          |    1.488 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Base_Shuffle       |    1.533 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Base               |    1.483 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128AdvSimd_Shuffle    |          |
| YGroup1ToGroup3Benchmark_Int64 | Sum128AdvSimd_Zip        |          |
| YGroup1ToGroup3Benchmark_Int64 | Sum128AdvSimdB64_Move    |          |
| YGroup1ToGroup3Benchmark_Int64 | Sum128AdvSimdB64_Shuffle |          |
| YGroup1ToGroup3Benchmark_Int64 | Sum128AdvSimdB64_Zip     |          |
| YGroup1ToGroup3Benchmark_Int64 | Sum128PackedSimd_Shuffle |   22.362 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128PackedSimd_Zip     |   12.065 |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Sse_Shuffle        |          |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Sse_Zip            |          |
| YGroup1ToGroup3Benchmark_Int64 | Sum128Traits             |   22.795 |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Base_Basic         |    0.959 |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Base_Shuffle       |    0.555 |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Base               |    0.963 |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Avx2_Shuffle       |          |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Avx2_ShuffleX      |          |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Avx2_ShuffleXImm   |          |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Avx2_Zip           |          |
| YGroup1ToGroup3Benchmark_Int64 | Sum256Traits             |    1.618 |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Base_Basic         |    0.990 |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Base_Shuffle       |    0.530 |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Base               |    0.951 |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Avx512_ShuffleX    |          |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Avx512_ShuffleXImm |          |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Avx512_Zip         |          |
| YGroup1ToGroup3Benchmark_Int64 | Sum512Traits             |    1.820 |

