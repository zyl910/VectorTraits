# Benchmark group - YGroup3Unzip
([← Back](YGroup3Unzip.md))

Unit of data: Million operations per second. The larger the number, the better the performance.
### X86 - AMD Ryzen 7 7840H
| Type                        | Method                     | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :-------------------------- | :------------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| YGroup3UnzipBenchmark_Byte  | SumBase_Basic              |        255.172 |       496.713 |       501.725 |   499.601 |   566.925 |   505.052 |   670.702 |
| YGroup3UnzipBenchmark_Byte  | SumBase_ByX2Zip            |       1116.121 |      1095.105 |      1099.552 |  1122.726 |  1114.310 |  1451.341 |  1492.857 |
| YGroup3UnzipBenchmark_Byte  | SumBase                    |       1140.616 |      1053.352 |      1089.103 |  1138.235 |  1111.114 |  1478.675 |  1463.708 |
| YGroup3UnzipBenchmark_Byte  | SumTraits                  |       1121.904 |      1086.799 |      7468.216 | 11280.246 | 11541.671 | 12438.171 | 21865.365 |
| YGroup3UnzipBenchmark_Byte  | SumX2Base_Basic            |        241.828 |       511.598 |       507.244 |   510.892 |   574.295 |   485.823 |   652.833 |
| YGroup3UnzipBenchmark_Byte  | SumX2Base_X2               |        606.086 |       647.339 |       659.698 |   776.209 |   912.760 |  1457.164 |  1502.412 |
| YGroup3UnzipBenchmark_Byte  | SumX2Base_Zip              |       2210.311 |      2123.219 |      2162.668 |  2096.243 |  2253.421 |  2807.625 |  2942.197 |
| YGroup3UnzipBenchmark_Byte  | SumX2Base                  |       2169.025 |      2088.353 |      2171.143 |  2111.332 |  2179.099 |  2812.575 |  2973.122 |
| YGroup3UnzipBenchmark_Byte  | SumX2Traits                |       2229.977 |      2160.516 |     10419.951 | 10989.673 | 10985.330 | 11472.251 | 22393.695 |
| YGroup3UnzipBenchmark_Byte  | Sum128Base_Basic           |                |               |       249.954 |   276.095 |   256.531 |   497.347 |   719.561 |
| YGroup3UnzipBenchmark_Byte  | Sum128Base_ByX2Zip         |                |               |               |           |           |  1202.776 |  1250.840 |
| YGroup3UnzipBenchmark_Byte  | Sum128Base                 |                |               |       252.013 |   263.663 |   260.673 |  1211.580 |  1247.833 |
| YGroup3UnzipBenchmark_Byte  | Sum128AdvSimd_ByX2Zip      |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum128AdvSimd_Shuffle      |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum128AdvSimd_ShuffleX     |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum128AdvSimdB64_ByX2Zip   |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum128AdvSimdB64_Shuffle   |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum128AdvSimdB64_ShuffleX  |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum128PackedSimd_ByX2Zip   |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum128PackedSimd_Shuffle   |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum128Sse_ByX2Zip          |                |               |      4513.536 |  5051.260 |  5054.709 |  5009.925 |  5063.589 |
| YGroup3UnzipBenchmark_Byte  | Sum128Sse_Shuffle          |                |               |      4763.302 |  6472.296 |  6778.492 |  7962.298 |  8256.101 |
| YGroup3UnzipBenchmark_Byte  | Sum128Sse_ShuffleX         |                |               |               |           |           |           | 11552.229 |
| YGroup3UnzipBenchmark_Byte  | Sum128Traits               |                |               |      4629.170 |  6486.847 |  7187.572 |  8178.769 | 11497.157 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Base_Basic         |                |               |       190.723 |   253.739 |   259.461 |   527.420 |   668.476 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Base_X2            |                |               |       255.106 |   207.118 |   255.136 |   337.293 |   939.022 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Base_Zip           |                |               |               |           |           |  1981.044 |  2106.623 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Base               |                |               |       207.049 |   205.951 |   261.720 |  1983.016 |  2105.378 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2AdvSimd_X2         |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum128X2AdvSimd_Zip        |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum128X2AdvSimdB64_X2      |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum128X2AdvSimdB64_Zip     |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum128X2PackedSimd_X2      |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum128X2PackedSimd_Zip     |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Sse_X2             |                |               |      3598.881 |  4560.950 |  4570.847 |  7738.129 | 11715.481 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Sse_Zip            |                |               |      7915.771 |  8020.765 |  7756.965 |  7651.703 |  9037.282 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Traits             |                |               |      7807.671 |  7932.466 |  7786.044 |  7489.845 | 11230.363 |
| YGroup3UnzipBenchmark_Byte  | Sum256Base_Basic           |                |               |       275.774 |   267.029 |   303.528 |   531.139 |   632.097 |
| YGroup3UnzipBenchmark_Byte  | Sum256Base_ByShorter       |                |               |               |           |           |  1837.481 |  1879.790 |
| YGroup3UnzipBenchmark_Byte  | Sum256Base_ByX2Zip         |                |               |               |           |           |  1905.547 |  1925.758 |
| YGroup3UnzipBenchmark_Byte  | Sum256Base                 |                |               |       286.837 |   278.816 |   296.579 |  1838.032 |  1875.743 |
| YGroup3UnzipBenchmark_Byte  | Sum256Avx2_ByShorter       |                |               |      7078.529 |  7200.267 |  7204.867 |  7066.288 |  9576.397 |
| YGroup3UnzipBenchmark_Byte  | Sum256Avx2_ByX2Unpack      |                |               |      6474.951 |  6451.710 |  6507.249 |  6410.532 |  8180.676 |
| YGroup3UnzipBenchmark_Byte  | Sum256Avx2_ByX2Zip         |                |               |      3188.225 |  3610.353 |  3621.740 |  3585.854 |  6322.010 |
| YGroup3UnzipBenchmark_Byte  | Sum256Avx2_Shuffle         |                |               |      8387.875 | 11223.659 | 10775.225 | 12756.529 | 14524.757 |
| YGroup3UnzipBenchmark_Byte  | Sum256Avx2_ShuffleX        |                |               |               |           |           |           | 22919.696 |
| YGroup3UnzipBenchmark_Byte  | Sum256Traits               |                |               |      8640.201 | 11375.240 | 11360.549 | 12473.862 | 21868.298 |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Base_Basic         |                |               |       264.555 |   229.762 |   300.162 |   518.294 |   652.183 |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Base_X2            |                |               |       241.909 |   286.871 |   187.378 |   692.793 |  1141.468 |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Base_Zip           |                |               |               |           |           |  3032.309 |  3308.276 |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Base               |                |               |       216.775 |   263.706 |   190.388 |  3039.807 |  3337.624 |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Avx2_Unpack        |                |               |     11015.280 | 10955.832 | 10935.261 | 10876.832 | 13615.024 |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Avx2_X2            |                |               |      6912.534 |  2672.094 |  7401.180 | 11775.534 | 23214.536 |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Avx2_Zip           |                |               |      5935.029 |  5931.680 |  5894.749 |  5889.817 | 11453.027 |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Traits             |                |               |     11055.618 | 10947.957 | 10988.243 | 11704.543 | 22225.162 |
| YGroup3UnzipBenchmark_Byte  | Sum512Base_Basic           |                |               |               |           |           |           |   701.056 |
| YGroup3UnzipBenchmark_Byte  | Sum512Base_ByShorter       |                |               |               |           |           |           |  2915.542 |
| YGroup3UnzipBenchmark_Byte  | Sum512Base_ByX2Zip         |                |               |               |           |           |           |  1776.056 |
| YGroup3UnzipBenchmark_Byte  | Sum512Base                 |                |               |               |           |           |           |  2929.252 |
| YGroup3UnzipBenchmark_Byte  | Sum512Avx512_ByShorter     |                |               |               |           |           |           | 15640.103 |
| YGroup3UnzipBenchmark_Byte  | Sum512Avx512_ByX2Unpack    |                |               |               |           |           |           |  8020.784 |
| YGroup3UnzipBenchmark_Byte  | Sum512Avx512_ByX2Zip       |                |               |               |           |           |           |  6116.089 |
| YGroup3UnzipBenchmark_Byte  | Sum512Avx512_ShuffleX      |                |               |               |           |           |           | 25920.214 |
| YGroup3UnzipBenchmark_Byte  | Sum512Traits               |                |               |               |           |           |           | 25947.696 |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Base_Basic         |                |               |               |           |           |           |   706.452 |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Base_X2            |                |               |               |           |           |           |  1078.709 |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Base_Zip           |                |               |               |           |           |           |  3101.737 |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Base               |                |               |               |           |           |           |  3125.751 |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Avx512_Unpack      |                |               |               |           |           |           | 12705.827 |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Avx512_X2          |                |               |               |           |           |           | 26045.677 |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Avx512_Zip         |                |               |               |           |           |           | 11340.582 |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Traits             |                |               |               |           |           |           | 25845.321 |
| YGroup3UnzipBenchmark_Int16 | SumBase_Basic              |        213.465 |       389.617 |       439.760 |   352.833 |   453.870 |   404.842 |   533.252 |
| YGroup3UnzipBenchmark_Int16 | SumBase_ByX2Zip            |        739.602 |       703.616 |       689.830 |   729.798 |   731.322 |  1003.279 |  1022.203 |
| YGroup3UnzipBenchmark_Int16 | SumBase                    |        738.972 |       723.809 |       686.669 |   739.079 |   728.061 |  1015.709 |  1008.942 |
| YGroup3UnzipBenchmark_Int16 | SumTraits                  |        759.109 |       691.273 |      3767.055 |  5383.595 |  5638.094 |  6270.971 | 10452.168 |
| YGroup3UnzipBenchmark_Int16 | SumX2Base_Basic            |        212.442 |       375.181 |       386.754 |   379.414 |   447.136 |   399.229 |   540.928 |
| YGroup3UnzipBenchmark_Int16 | SumX2Base_X2               |        328.531 |       299.180 |       367.117 |   331.465 |   399.797 |   993.897 |  1024.229 |
| YGroup3UnzipBenchmark_Int16 | SumX2Base_Zip              |       1303.725 |      1224.857 |      1285.624 |  1116.355 |  1302.285 |  1689.073 |  1795.638 |
| YGroup3UnzipBenchmark_Int16 | SumX2Base                  |       1327.217 |      1262.400 |      1260.547 |  1312.866 |  1288.727 |  1723.543 |  1761.102 |
| YGroup3UnzipBenchmark_Int16 | SumX2Traits                |       1320.545 |      1227.530 |      6120.175 |  6190.444 |  6208.993 |  5798.718 | 10909.299 |
| YGroup3UnzipBenchmark_Int16 | Sum128Base_Basic           |                |               |       163.643 |   179.260 |   180.017 |   372.915 |   529.257 |
| YGroup3UnzipBenchmark_Int16 | Sum128Base_ByX2Zip         |                |               |               |           |           |   799.463 |   838.350 |
| YGroup3UnzipBenchmark_Int16 | Sum128Base                 |                |               |       171.268 |   177.420 |   180.130 |   797.845 |   834.939 |
| YGroup3UnzipBenchmark_Int16 | Sum128AdvSimd_ByX2Zip      |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum128AdvSimd_Shuffle      |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum128AdvSimd_ShuffleX     |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum128AdvSimdB64_ByX2Zip   |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum128AdvSimdB64_Shuffle   |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum128AdvSimdB64_ShuffleX  |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum128PackedSimd_ByX2Zip   |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum128PackedSimd_Shuffle   |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum128Sse_ByX2Zip          |                |               |      2850.656 |  3322.534 |  3246.598 |  3239.524 |  3278.958 |
| YGroup3UnzipBenchmark_Int16 | Sum128Sse_Shuffle          |                |               |      2383.760 |  3333.962 |  3299.222 |  4006.572 |  3985.895 |
| YGroup3UnzipBenchmark_Int16 | Sum128Sse_ShuffleX         |                |               |               |           |           |           |  5672.390 |
| YGroup3UnzipBenchmark_Int16 | Sum128Traits               |                |               |      2845.443 |  3443.172 |  3275.723 |  4068.295 |  5628.521 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Base_Basic         |                |               |       166.179 |   172.850 |   171.128 |   374.205 |   534.664 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Base_X2            |                |               |       171.270 |   172.705 |   173.067 |   279.417 |   910.493 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Base_Zip           |                |               |               |           |           |  1233.400 |  1334.632 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Base               |                |               |       166.292 |   174.010 |   171.535 |  1235.510 |  1332.993 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2AdvSimd_X2         |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum128X2AdvSimd_Zip        |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum128X2AdvSimdB64_X2      |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum128X2AdvSimdB64_Zip     |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum128X2PackedSimd_X2      |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum128X2PackedSimd_Zip     |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Sse_X2             |                |               |      2876.225 |  2258.354 |  2259.891 |  4039.173 |  5795.504 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Sse_Zip            |                |               |      4811.361 |  4696.157 |  4778.163 |  4778.519 |  5571.178 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Traits             |                |               |      4779.715 |  4870.768 |  4801.510 |  4695.327 |  5550.486 |
| YGroup3UnzipBenchmark_Int16 | Sum256Base_Basic           |                |               |       203.365 |   198.600 |   216.469 |   406.375 |   553.940 |
| YGroup3UnzipBenchmark_Int16 | Sum256Base_ByShorter       |                |               |               |           |           |  1131.009 |  1134.466 |
| YGroup3UnzipBenchmark_Int16 | Sum256Base_ByX2Zip         |                |               |               |           |           |  1175.021 |  1212.238 |
| YGroup3UnzipBenchmark_Int16 | Sum256Base                 |                |               |       208.578 |   194.424 |   218.653 |  1132.803 |  1139.589 |
| YGroup3UnzipBenchmark_Int16 | Sum256Avx2_ByShorter       |                |               |      4205.251 |  4273.034 |  4265.460 |  4077.272 |  4893.746 |
| YGroup3UnzipBenchmark_Int16 | Sum256Avx2_ByX2Unpack      |                |               |      3740.590 |  3737.858 |  3751.136 |  3720.863 |  4963.754 |
| YGroup3UnzipBenchmark_Int16 | Sum256Avx2_ByX2Zip         |                |               |      1964.798 |  2229.774 |  2240.128 |  2220.115 |  4073.785 |
| YGroup3UnzipBenchmark_Int16 | Sum256Avx2_Shuffle         |                |               |      4402.253 |  5515.752 |  5564.505 |  6237.993 |  7496.953 |
| YGroup3UnzipBenchmark_Int16 | Sum256Avx2_ShuffleX        |                |               |               |           |           |           | 10201.952 |
| YGroup3UnzipBenchmark_Int16 | Sum256Traits               |                |               |      4320.356 |  5536.858 |  5945.449 |  6152.492 | 10485.354 |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Base_Basic         |                |               |       191.178 |   175.330 |   235.278 |   393.385 |   548.823 |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Base_X2            |                |               |       171.945 |   206.026 |   227.484 |   341.254 |   775.972 |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Base_Zip           |                |               |               |           |           |  1818.658 |  2035.685 |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Base               |                |               |       147.234 |   177.586 |   222.995 |  1837.780 |  1997.059 |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Avx2_Unpack        |                |               |      6359.316 |  6171.021 |  6154.767 |  6096.369 |  8560.828 |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Avx2_X2            |                |               |      3483.474 |  1344.060 |  3681.388 |  5769.403 | 10778.854 |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Avx2_Zip           |                |               |      3687.259 |  3704.110 |  3670.356 |  3664.860 |  7214.355 |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Traits             |                |               |      6288.341 |  6212.027 |  6138.802 |  5568.883 | 10753.432 |
| YGroup3UnzipBenchmark_Int16 | Sum512Base_Basic           |                |               |               |           |           |           |   624.956 |
| YGroup3UnzipBenchmark_Int16 | Sum512Base_ByShorter       |                |               |               |           |           |           |  1700.865 |
| YGroup3UnzipBenchmark_Int16 | Sum512Base_ByX2Zip         |                |               |               |           |           |           |  1075.581 |
| YGroup3UnzipBenchmark_Int16 | Sum512Base                 |                |               |               |           |           |           |  1707.693 |
| YGroup3UnzipBenchmark_Int16 | Sum512Avx512_ByShorter     |                |               |               |           |           |           |  7584.870 |
| YGroup3UnzipBenchmark_Int16 | Sum512Avx512_ByX2Unpack    |                |               |               |           |           |           |  4648.601 |
| YGroup3UnzipBenchmark_Int16 | Sum512Avx512_ByX2Zip       |                |               |               |           |           |           |  3694.187 |
| YGroup3UnzipBenchmark_Int16 | Sum512Avx512_ShuffleX      |                |               |               |           |           |           | 11882.103 |
| YGroup3UnzipBenchmark_Int16 | Sum512Traits               |                |               |               |           |           |           | 12014.209 |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Base_Basic         |                |               |               |           |           |           |   611.505 |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Base_X2            |                |               |               |           |           |           |   934.217 |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Base_Zip           |                |               |               |           |           |           |  1839.193 |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Base               |                |               |               |           |           |           |  1833.781 |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Avx512_Unpack      |                |               |               |           |           |           |  7386.441 |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Avx512_X2          |                |               |               |           |           |           | 11976.703 |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Avx512_Zip         |                |               |               |           |           |           |  6683.174 |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Traits             |                |               |               |           |           |           | 11904.808 |
| YGroup3UnzipBenchmark_Int32 | SumBase_Basic              |        186.128 |       276.261 |       295.992 |   219.993 |   323.416 |   280.863 |   391.511 |
| YGroup3UnzipBenchmark_Int32 | SumBase_ByX2Zip            |         20.981 |        39.468 |        43.396 |    35.587 |    43.880 |   551.271 |   554.575 |
| YGroup3UnzipBenchmark_Int32 | SumBase                    |        184.001 |       273.403 |       306.846 |   224.431 |   320.332 |   551.148 |   555.068 |
| YGroup3UnzipBenchmark_Int32 | SumTraits                  |        189.108 |       277.059 |      6262.687 |  6454.641 |  6392.289 |  6488.127 |  6951.683 |
| YGroup3UnzipBenchmark_Int32 | SumX2Base_Basic            |        165.157 |       254.318 |       286.410 |   257.263 |   308.622 |   271.648 |   397.606 |
| YGroup3UnzipBenchmark_Int32 | SumX2Base_X2               |        160.036 |       251.178 |       282.688 |   235.973 |   313.655 |   554.248 |   558.328 |
| YGroup3UnzipBenchmark_Int32 | SumX2Base_Zip              |         41.538 |        75.637 |        84.451 |    76.720 |    85.182 |  1074.657 |  1086.495 |
| YGroup3UnzipBenchmark_Int32 | SumX2Base                  |        155.218 |       257.316 |       284.894 |   247.659 |   318.492 |  1072.598 |  1093.091 |
| YGroup3UnzipBenchmark_Int32 | SumX2Traits                |        160.252 |       253.319 |      5049.720 |  6341.390 |  6285.681 |  6215.097 |  7422.183 |
| YGroup3UnzipBenchmark_Int32 | Sum128Base_Basic           |                |               |       105.586 |   106.643 |   105.117 |   241.562 |   342.368 |
| YGroup3UnzipBenchmark_Int32 | Sum128Base_ByX2Zip         |                |               |               |           |           |   600.144 |   624.660 |
| YGroup3UnzipBenchmark_Int32 | Sum128Base                 |                |               |       105.457 |   104.642 |   106.548 |   600.409 |   629.184 |
| YGroup3UnzipBenchmark_Int32 | Sum128AdvSimd_ByX2Zip      |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum128AdvSimd_Shuffle      |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum128AdvSimd_ShuffleX     |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum128AdvSimdB64_ByX2Zip   |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum128AdvSimdB64_Shuffle   |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum128AdvSimdB64_ShuffleX  |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum128PackedSimd_ByX2Zip   |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum128PackedSimd_Shuffle   |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum128Sse_ByX2Zip          |                |               |      2109.758 |  2647.001 |  2611.266 |  2490.556 |  2639.280 |
| YGroup3UnzipBenchmark_Int32 | Sum128Sse_Shuffle          |                |               |      1176.936 |  1648.515 |  1711.685 |  2025.701 |  2106.215 |
| YGroup3UnzipBenchmark_Int32 | Sum128Sse_ShuffleX         |                |               |               |           |           |           |  2826.239 |
| YGroup3UnzipBenchmark_Int32 | Sum128Sse_ShuffleXImm      |                |               |      4631.363 |  4718.473 |  4828.894 |  4466.959 |  5337.733 |
| YGroup3UnzipBenchmark_Int32 | Sum128Traits               |                |               |      4745.718 |  4605.942 |  4689.915 |  4502.925 |  5209.526 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Base_Basic         |                |               |       104.648 |   110.910 |   109.113 |   234.467 |   350.466 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Base_X2            |                |               |       105.688 |   109.389 |   107.304 |   325.075 |   698.258 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Base_Zip           |                |               |               |           |           |   827.822 |   915.872 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Base               |                |               |       107.606 |   110.626 |   109.102 |   824.371 |   909.424 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2AdvSimd_X2         |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum128X2AdvSimd_Zip        |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum128X2AdvSimdB64_X2      |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum128X2AdvSimdB64_Zip     |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum128X2PackedSimd_X2      |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum128X2PackedSimd_Zip     |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Sse_X2             |                |               |      4894.206 |  5080.211 |  4964.140 |  4678.134 |  5371.966 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Sse_Zip            |                |               |      2818.889 |  2792.641 |  3041.497 |  3068.281 |  3823.660 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Traits             |                |               |      4919.579 |  4908.756 |  4937.537 |  4895.530 |  5494.890 |
| YGroup3UnzipBenchmark_Int32 | Sum256Base_Basic           |                |               |       145.735 |   124.196 |   156.782 |   279.727 |   389.659 |
| YGroup3UnzipBenchmark_Int32 | Sum256Base_ByShorter       |                |               |               |           |           |   739.928 |   741.095 |
| YGroup3UnzipBenchmark_Int32 | Sum256Base_ByX2Zip         |                |               |               |           |           |   785.429 |   819.715 |
| YGroup3UnzipBenchmark_Int32 | Sum256Base                 |                |               |       152.061 |   126.263 |   155.660 |   741.615 |   740.661 |
| YGroup3UnzipBenchmark_Int32 | Sum256Avx2_ByShorter       |                |               |      3485.999 |  4024.178 |  4125.784 |  3594.638 |  4100.731 |
| YGroup3UnzipBenchmark_Int32 | Sum256Avx2_ByX2Unpack      |                |               |      2187.403 |  2174.120 |  2184.033 |  2180.138 |  3342.191 |
| YGroup3UnzipBenchmark_Int32 | Sum256Avx2_ByX2Zip         |                |               |      1274.561 |  1475.546 |  1471.331 |  1469.117 |  2641.572 |
| YGroup3UnzipBenchmark_Int32 | Sum256Avx2_Shuffle         |                |               |      2080.001 |  2731.931 |  2865.671 |  3129.362 |  3638.845 |
| YGroup3UnzipBenchmark_Int32 | Sum256Avx2_ShuffleX        |                |               |               |           |           |           |  5234.086 |
| YGroup3UnzipBenchmark_Int32 | Sum256Avx2_ShuffleXImm     |                |               |      6419.314 |  6428.864 |  6521.061 |  6409.728 |  6868.362 |
| YGroup3UnzipBenchmark_Int32 | Sum256Traits               |                |               |      6004.869 |  6419.062 |  6539.009 |  6392.612 |  6928.314 |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Base_Basic         |                |               |       137.038 |   132.587 |   161.864 |   279.380 |   398.314 |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Base_X2            |                |               |       150.125 |   133.943 |   162.756 |   364.307 |   802.926 |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Base_Zip           |                |               |               |           |           |  1140.173 |  1283.275 |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Base               |                |               |       152.373 |   136.921 |   159.711 |  1137.057 |  1275.678 |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Avx2_Unpack        |                |               |      3621.353 |  3568.237 |  3529.617 |  3557.617 |  5083.183 |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Avx2_X2            |                |               |      6392.326 |  6374.461 |  6443.376 |  6183.778 |  7183.896 |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Avx2_Zip           |                |               |      2399.351 |  2369.640 |  2393.409 |  2385.466 |  4320.654 |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Traits             |                |               |      6413.822 |  6134.518 |  6428.620 |  6310.064 |  7073.414 |
| YGroup3UnzipBenchmark_Int32 | Sum512Base_Basic           |                |               |               |           |           |           |   471.215 |
| YGroup3UnzipBenchmark_Int32 | Sum512Base_ByShorter       |                |               |               |           |           |           |  1041.874 |
| YGroup3UnzipBenchmark_Int32 | Sum512Base_ByX2Zip         |                |               |               |           |           |           |   683.877 |
| YGroup3UnzipBenchmark_Int32 | Sum512Base                 |                |               |               |           |           |           |  1043.567 |
| YGroup3UnzipBenchmark_Int32 | Sum512Avx512_ByShorter     |                |               |               |           |           |           |  4751.835 |
| YGroup3UnzipBenchmark_Int32 | Sum512Avx512_ByX2Unpack    |                |               |               |           |           |           |  2879.436 |
| YGroup3UnzipBenchmark_Int32 | Sum512Avx512_ByX2Zip       |                |               |               |           |           |           |  2316.631 |
| YGroup3UnzipBenchmark_Int32 | Sum512Avx512_ShuffleX      |                |               |               |           |           |           |  5888.938 |
| YGroup3UnzipBenchmark_Int32 | Sum512Avx512_ShuffleXImm   |                |               |               |           |           |           |  6707.153 |
| YGroup3UnzipBenchmark_Int32 | Sum512Traits               |                |               |               |           |           |           |  6672.005 |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Base_Basic         |                |               |               |           |           |           |   459.265 |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Base_X2            |                |               |               |           |           |           |  1027.626 |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Base_Zip           |                |               |               |           |           |           |  1124.839 |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Base               |                |               |               |           |           |           |  1128.204 |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Avx512_Unpack      |                |               |               |           |           |           |  4559.510 |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Avx512_X2          |                |               |               |           |           |           |  6730.724 |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Avx512_Zip         |                |               |               |           |           |           |  4124.833 |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Traits             |                |               |               |           |           |           |  6705.456 |
| YGroup3UnzipBenchmark_Int64 | SumBase_Basic              |        136.976 |       170.057 |       187.362 |   131.130 |   193.633 |   175.953 |   240.232 |
| YGroup3UnzipBenchmark_Int64 | SumBase                    |        135.652 |       170.323 |       187.933 |   125.485 |   192.634 |   168.300 |   238.422 |
| YGroup3UnzipBenchmark_Int64 | SumTraits                  |        135.704 |       167.900 |      4095.410 |  3868.199 |  4015.411 |  4061.920 |  4385.505 |
| YGroup3UnzipBenchmark_Int64 | SumX2Base_Basic            |        106.741 |       149.565 |       173.159 |   148.674 |   191.630 |   162.793 |   244.720 |
| YGroup3UnzipBenchmark_Int64 | SumX2Base_X2               |        112.419 |       150.943 |       178.049 |   141.862 |   185.049 |   167.507 |   243.475 |
| YGroup3UnzipBenchmark_Int64 | SumX2Base                  |        108.319 |       151.252 |       178.444 |   137.145 |   182.990 |   155.501 |   243.663 |
| YGroup3UnzipBenchmark_Int64 | SumX2Traits                |        109.441 |       151.243 |      2684.613 |  3883.237 |  3978.648 |  3893.358 |  4785.675 |
| YGroup3UnzipBenchmark_Int64 | Sum128Base_Basic           |                |               |        57.325 |    56.990 |    56.623 |   136.071 |   197.297 |
| YGroup3UnzipBenchmark_Int64 | Sum128Base_Move            |                |               |        43.205 |    42.879 |    43.013 |    70.406 |   148.868 |
| YGroup3UnzipBenchmark_Int64 | Sum128Base                 |                |               |        57.506 |    56.792 |    58.126 |   137.503 |   197.452 |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimd_AlignRight   |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimd_ByX2Zip      |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimd_Shuffle      |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimd_ShuffleX     |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimdB64_ByX2Zip   |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimdB64_Shuffle   |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimdB64_ShuffleX  |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128PackedSimd_ByX2Zip   |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128PackedSimd_Shuffle   |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128Sse_ByX2Zip          |                |               |      1658.611 |  2086.809 |  2080.708 |  1979.282 |  1993.932 |
| YGroup3UnzipBenchmark_Int64 | Sum128Sse_Shuffle          |                |               |      1131.190 |  1431.726 |  1482.372 |  1515.797 |  1497.726 |
| YGroup3UnzipBenchmark_Int64 | Sum128Sse_ShuffleX         |                |               |               |           |           |           |  2061.123 |
| YGroup3UnzipBenchmark_Int64 | Sum128Sse_ShuffleXImm      |                |               |      3189.230 |  3031.139 |  3173.841 |  3092.943 |  3046.479 |
| YGroup3UnzipBenchmark_Int64 | Sum128Traits               |                |               |      3291.189 |  3125.882 |  3162.539 |  2996.937 |  3111.839 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2Base_Basic         |                |               |        57.005 |    58.962 |    59.410 |   117.028 |   203.099 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2Base_X2            |                |               |        55.553 |    60.887 |    58.640 |   118.287 |   202.452 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2Base               |                |               |        56.014 |    61.007 |    59.397 |   118.862 |   203.146 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2AdvSimd_X2         |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128X2AdvSimd_Zip        |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128X2AdvSimdB64_X2      |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128X2AdvSimdB64_Zip     |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128X2PackedSimd_X2      |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128X2PackedSimd_Zip     |                |               |               |           |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128X2Sse_X2             |                |               |      3383.319 |  3280.057 |  3355.459 |  3242.732 |  4131.315 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2Sse_Zip            |                |               |      1502.012 |  1500.430 |  2198.774 |  2138.492 |  2659.430 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2Traits             |                |               |      3510.351 |  3359.090 |  3539.851 |  3288.272 |  3790.193 |
| YGroup3UnzipBenchmark_Int64 | Sum256Base_Basic           |                |               |        82.410 |    69.400 |    89.674 |   169.416 |   241.816 |
| YGroup3UnzipBenchmark_Int64 | Sum256Base_ByShorter       |                |               |               |           |           |   123.581 |   199.802 |
| YGroup3UnzipBenchmark_Int64 | Sum256Base                 |                |               |        90.187 |    68.227 |    89.262 |   169.854 |   236.317 |
| YGroup3UnzipBenchmark_Int64 | Sum256Avx2_ByShorter       |                |               |      2334.610 |  2818.352 |  2854.823 |  2353.341 |  2724.795 |
| YGroup3UnzipBenchmark_Int64 | Sum256Avx2_ByX2Unpack      |                |               |      1414.372 |  1413.991 |  1425.834 |  1413.555 |  2472.575 |
| YGroup3UnzipBenchmark_Int64 | Sum256Avx2_ByX2Zip         |                |               |       867.538 |  1044.737 |  1042.313 |  1042.122 |  2056.297 |
| YGroup3UnzipBenchmark_Int64 | Sum256Avx2_Shuffle         |                |               |      1947.240 |  2309.344 |  2397.510 |  2218.327 |  2468.659 |
| YGroup3UnzipBenchmark_Int64 | Sum256Avx2_ShuffleX        |                |               |               |           |           |           |  2601.554 |
| YGroup3UnzipBenchmark_Int64 | Sum256Avx2_ShuffleXImm     |                |               |      4156.204 |  4131.657 |  3990.275 |  3905.458 |  4532.797 |
| YGroup3UnzipBenchmark_Int64 | Sum256Traits               |                |               |      4031.321 |  4130.471 |  4087.309 |  3994.982 |  4470.329 |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Base_Basic         |                |               |        75.842 |    74.441 |    91.658 |   161.081 |   246.018 |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Base_X2            |                |               |        87.896 |    73.610 |    94.214 |   167.493 |   245.114 |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Base               |                |               |        88.770 |    73.498 |    92.794 |   158.391 |   243.803 |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Avx2_Unpack        |                |               |      2250.828 |  2228.140 |  2290.923 |  2249.737 |  3410.007 |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Avx2_X2            |                |               |      4139.117 |  3945.155 |  4041.907 |  4046.579 |  4654.469 |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Avx2_Zip           |                |               |      1573.510 |  1595.288 |  1584.669 |  1584.492 |  2884.402 |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Traits             |                |               |      3936.643 |  3873.382 |  4004.345 |  3941.973 |  4543.439 |
| YGroup3UnzipBenchmark_Int64 | Sum512Base_Basic           |                |               |               |           |           |           |   312.264 |
| YGroup3UnzipBenchmark_Int64 | Sum512Base_ByShorter       |                |               |               |           |           |           |   236.542 |
| YGroup3UnzipBenchmark_Int64 | Sum512Base                 |                |               |               |           |           |           |   309.919 |
| YGroup3UnzipBenchmark_Int64 | Sum512Avx512_ByShorter     |                |               |               |           |           |           |  2820.750 |
| YGroup3UnzipBenchmark_Int64 | Sum512Avx512_ByX2Unpack    |                |               |               |           |           |           |  1862.534 |
| YGroup3UnzipBenchmark_Int64 | Sum512Avx512_ByX2Zip       |                |               |               |           |           |           |  1565.685 |
| YGroup3UnzipBenchmark_Int64 | Sum512Avx512_ShuffleX      |                |               |               |           |           |           |  3041.213 |
| YGroup3UnzipBenchmark_Int64 | Sum512Avx512_ShuffleXImm   |                |               |               |           |           |           |  4207.988 |
| YGroup3UnzipBenchmark_Int64 | Sum512Traits               |                |               |               |           |           |           |  4192.943 |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Base_Basic         |                |               |               |           |           |           |   311.548 |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Base_X2            |                |               |               |           |           |           |   314.013 |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Base               |                |               |               |           |           |           |   313.489 |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Avx512_Unpack      |                |               |               |           |           |           |  2985.192 |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Avx512_X2          |                |               |               |           |           |           |  4230.122 |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Avx512_Zip         |                |               |               |           |           |           |  2693.015 |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Traits             |                |               |               |           |           |           |  4231.356 |
| YGroup3ZipBenchmark_Byte    | SumBase_Basic              |        320.545 |       532.958 |       571.109 |   523.083 |   555.271 |   600.353 |   679.783 |
| YGroup3ZipBenchmark_Byte    | SumBase_ByX2Unzip          |        300.387 |       295.537 |       300.998 |   300.493 |   297.640 |  1585.690 |  1711.221 |
| YGroup3ZipBenchmark_Byte    | SumBase                    |        305.180 |       519.605 |       553.415 |   467.029 |   549.762 |  1589.642 |  1708.570 |
| YGroup3ZipBenchmark_Byte    | SumTraits                  |        290.232 |       529.108 |      8108.844 | 12125.735 | 11513.732 | 12224.632 | 21531.572 |
| YGroup3ZipBenchmark_Byte    | SumX2Base_Basic            |        301.626 |       520.249 |       552.428 |   504.787 |   568.661 |   592.696 |   651.705 |
| YGroup3ZipBenchmark_Byte    | SumX2Base_X2               |        300.821 |       531.347 |       556.188 |   584.555 |   576.822 |  1587.586 |  1674.158 |
| YGroup3ZipBenchmark_Byte    | SumX2Base_Unzip            |        604.640 |       597.820 |       599.247 |   580.093 |   592.151 |  3084.266 |  3424.238 |
| YGroup3ZipBenchmark_Byte    | SumX2Base                  |        604.991 |       596.515 |       601.072 |   579.109 |   591.315 |  3092.986 |  3409.277 |
| YGroup3ZipBenchmark_Byte    | SumX2Traits                |        602.261 |       596.798 |      6290.095 |  2711.253 |  8337.479 | 11463.088 | 22736.985 |
| YGroup3ZipBenchmark_Byte    | Sum128Base_Basic           |                |               |       258.901 |   261.687 |   267.164 |   533.891 |   598.484 |
| YGroup3ZipBenchmark_Byte    | Sum128Base_ByX2Unzip       |                |               |               |           |           |  1595.806 |  1497.883 |
| YGroup3ZipBenchmark_Byte    | Sum128Base                 |                |               |       269.807 |   270.410 |   272.393 |  1602.076 |  1497.468 |
| YGroup3ZipBenchmark_Byte    | Sum128AdvSimd_ByX2Unzip    |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum128AdvSimd_Shuffle      |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum128AdvSimd_ShuffleX     |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum128AdvSimdB64_ByX2Unzip |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum128AdvSimdB64_Shuffle   |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum128AdvSimdB64_ShuffleX  |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum128PackedSimd_ByX2Unzip |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum128PackedSimd_Shuffle   |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum128Sse_ByX2Unzip        |                |               |      1443.727 |  1542.612 |  1602.819 |  1579.257 |  3998.143 |
| YGroup3ZipBenchmark_Byte    | Sum128Sse_Shuffle          |                |               |      4741.521 |  6747.812 |  6663.213 |  8054.840 |  8166.821 |
| YGroup3ZipBenchmark_Byte    | Sum128Sse_ShuffleX         |                |               |               |           |           |           | 11762.303 |
| YGroup3ZipBenchmark_Byte    | Sum128Traits               |                |               |      4557.543 |  6708.615 |  6862.931 |  8179.048 | 12001.819 |
| YGroup3ZipBenchmark_Byte    | Sum128X2Base_Basic         |                |               |       270.658 |   267.371 |   270.136 |   549.405 |   637.641 |
| YGroup3ZipBenchmark_Byte    | Sum128X2Base_X2            |                |               |       269.695 |   273.666 |   270.428 |  1612.897 |  1569.619 |
| YGroup3ZipBenchmark_Byte    | Sum128X2Base_Unzip         |                |               |               |           |           |  2434.069 |  2397.535 |
| YGroup3ZipBenchmark_Byte    | Sum128X2Base               |                |               |       267.237 |   274.060 |   265.689 |  2449.608 |  2413.611 |
| YGroup3ZipBenchmark_Byte    | Sum128X2AdvSimd_X2         |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum128X2AdvSimd_Unzip      |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum128X2AdvSimdB64_X2      |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum128X2AdvSimdB64_Unzip   |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum128X2PackedSimd_X2      |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum128X2PackedSimd_Unzip   |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum128X2Sse_X2             |                |               |      3414.517 |  4517.415 |  4603.425 |  7643.675 | 12000.367 |
| YGroup3ZipBenchmark_Byte    | Sum128X2Sse_Unzip          |                |               |      2236.545 |  2366.059 |  2441.264 |  2460.000 |  6682.915 |
| YGroup3ZipBenchmark_Byte    | Sum128X2Traits             |                |               |      3511.017 |  4571.006 |  4599.569 |  7724.295 | 11455.327 |
| YGroup3ZipBenchmark_Byte    | Sum256Base_Basic           |                |               |       301.188 |   297.422 |   303.177 |   601.801 |   713.970 |
| YGroup3ZipBenchmark_Byte    | Sum256Base_ByShorter       |                |               |               |           |           |  2554.710 |  2099.915 |
| YGroup3ZipBenchmark_Byte    | Sum256Base_ByX2Unzip       |                |               |               |           |           |  1942.202 |  2240.503 |
| YGroup3ZipBenchmark_Byte    | Sum256Base                 |                |               |       298.601 |   299.709 |   302.944 |  2570.940 |  2100.705 |
| YGroup3ZipBenchmark_Byte    | Sum256Avx2_ByShorter       |                |               |      3763.762 |  5428.627 |  5552.562 |  7384.694 |  9920.785 |
| YGroup3ZipBenchmark_Byte    | Sum256Avx2_ByX2Unzip       |                |               |      1686.285 |  1805.611 |  1833.782 |  1864.802 |  6235.736 |
| YGroup3ZipBenchmark_Byte    | Sum256Avx2_Shuffle         |                |               |      9038.412 | 12344.821 | 11643.626 | 12114.458 | 13957.492 |
| YGroup3ZipBenchmark_Byte    | Sum256Avx2_ShuffleX        |                |               |               |           |           |           | 21883.450 |
| YGroup3ZipBenchmark_Byte    | Sum256Traits               |                |               |      8835.152 | 12200.515 | 11446.513 | 11992.316 | 21617.547 |
| YGroup3ZipBenchmark_Byte    | Sum256X2Base_Basic         |                |               |       290.527 |   308.411 |   304.086 |   603.827 |   679.258 |
| YGroup3ZipBenchmark_Byte    | Sum256X2Base_X2            |                |               |       292.687 |   294.274 |   294.682 |  1756.584 |  2336.242 |
| YGroup3ZipBenchmark_Byte    | Sum256X2Base_Unzip         |                |               |               |           |           |  3271.758 |  3754.315 |
| YGroup3ZipBenchmark_Byte    | Sum256X2Base               |                |               |       291.313 |   297.219 |   302.286 |  3275.013 |  3756.670 |
| YGroup3ZipBenchmark_Byte    | Sum256X2Avx2_X2            |                |               |      6418.152 |  2699.804 |  8140.396 | 11580.611 | 21837.127 |
| YGroup3ZipBenchmark_Byte    | Sum256X2Avx2_Unzip         |                |               |      2801.755 |  1745.439 |  2917.432 |  2971.004 | 11002.207 |
| YGroup3ZipBenchmark_Byte    | Sum256X2Traits             |                |               |      6413.146 |  2802.577 |  8210.158 | 11603.820 | 21901.427 |
| YGroup3ZipBenchmark_Byte    | Sum512Base_Basic           |                |               |               |           |           |           |   644.550 |
| YGroup3ZipBenchmark_Byte    | Sum512Base_ByShorter       |                |               |               |           |           |           |  3121.646 |
| YGroup3ZipBenchmark_Byte    | Sum512Base_ByX2Unzip       |                |               |               |           |           |           |  2019.100 |
| YGroup3ZipBenchmark_Byte    | Sum512Base                 |                |               |               |           |           |           |  3134.877 |
| YGroup3ZipBenchmark_Byte    | Sum512Avx512_ByShorter     |                |               |               |           |           |           | 15239.149 |
| YGroup3ZipBenchmark_Byte    | Sum512Avx512_ByX2Unzip     |                |               |               |           |           |           |  6135.134 |
| YGroup3ZipBenchmark_Byte    | Sum512Avx512_ShuffleX      |                |               |               |           |           |           | 25842.514 |
| YGroup3ZipBenchmark_Byte    | Sum512Traits               |                |               |               |           |           |           | 25931.299 |
| YGroup3ZipBenchmark_Byte    | Sum512X2Base_Basic         |                |               |               |           |           |           |   632.283 |
| YGroup3ZipBenchmark_Byte    | Sum512X2Base_X2            |                |               |               |           |           |           |  3408.872 |
| YGroup3ZipBenchmark_Byte    | Sum512X2Base_Unzip         |                |               |               |           |           |           |  3473.689 |
| YGroup3ZipBenchmark_Byte    | Sum512X2Base               |                |               |               |           |           |           |  3486.006 |
| YGroup3ZipBenchmark_Byte    | Sum512X2Avx512_X2          |                |               |               |           |           |           | 26226.454 |
| YGroup3ZipBenchmark_Byte    | Sum512X2Avx512_Unzip       |                |               |               |           |           |           | 10768.522 |
| YGroup3ZipBenchmark_Byte    | Sum512X2Traits             |                |               |               |           |           |           | 25685.122 |
| YGroup3ZipBenchmark_Int16   | SumBase_Basic              |        254.953 |       426.213 |       487.379 |   305.837 |   522.485 |   483.501 |   563.462 |
| YGroup3ZipBenchmark_Int16   | SumBase_ByX2Unzip          |        283.706 |       275.573 |       287.380 |   288.461 |   284.750 |  1083.100 |  1145.697 |
| YGroup3ZipBenchmark_Int16   | SumBase                    |        268.055 |       442.283 |       490.271 |   297.784 |   493.898 |  1095.126 |  1146.176 |
| YGroup3ZipBenchmark_Int16   | SumTraits                  |        259.538 |       444.525 |      4016.255 |  5534.713 |  5845.907 |  6165.240 | 10349.838 |
| YGroup3ZipBenchmark_Int16   | SumX2Base_Basic            |        246.364 |       392.013 |       496.100 |   485.488 |   492.620 |   476.127 |   552.873 |
| YGroup3ZipBenchmark_Int16   | SumX2Base_X2               |        240.604 |       400.325 |       483.811 |   438.480 |   492.001 |  1104.380 |  1169.037 |
| YGroup3ZipBenchmark_Int16   | SumX2Base_Unzip            |        478.388 |       457.062 |       469.791 |   448.721 |   467.695 |  1877.608 |  2066.503 |
| YGroup3ZipBenchmark_Int16   | SumX2Base                  |        248.608 |       387.791 |       468.835 |   430.473 |   495.950 |  1897.174 |  2065.269 |
| YGroup3ZipBenchmark_Int16   | SumX2Traits                |        253.817 |       394.047 |      3148.790 |  1355.513 |  4127.791 |  5693.957 | 10673.106 |
| YGroup3ZipBenchmark_Int16   | Sum128Base_Basic           |                |               |       175.583 |   170.824 |   165.263 |   381.273 |   373.172 |
| YGroup3ZipBenchmark_Int16   | Sum128Base_ByX2Unzip       |                |               |               |           |           |  1005.864 |  1038.647 |
| YGroup3ZipBenchmark_Int16   | Sum128Base                 |                |               |       174.352 |   168.039 |   166.056 |  1043.391 |  1037.884 |
| YGroup3ZipBenchmark_Int16   | Sum128AdvSimd_ByX2Unzip    |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum128AdvSimd_Shuffle      |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum128AdvSimd_ShuffleX     |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum128AdvSimdB64_ByX2Unzip |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum128AdvSimdB64_Shuffle   |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum128AdvSimdB64_ShuffleX  |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum128PackedSimd_ByX2Unzip |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum128PackedSimd_Shuffle   |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum128Sse_ByX2Unzip        |                |               |       905.813 |   953.977 |   952.128 |   959.395 |  2714.316 |
| YGroup3ZipBenchmark_Int16   | Sum128Sse_Shuffle          |                |               |      2326.910 |  3401.318 |  3332.964 |  4054.607 |  4022.091 |
| YGroup3ZipBenchmark_Int16   | Sum128Sse_ShuffleX         |                |               |               |           |           |           |  5488.383 |
| YGroup3ZipBenchmark_Int16   | Sum128Traits               |                |               |      2354.836 |  3323.763 |  3286.421 |  3971.470 |  5690.684 |
| YGroup3ZipBenchmark_Int16   | Sum128X2Base_Basic         |                |               |       179.297 |   162.586 |   163.605 |   282.782 |   395.555 |
| YGroup3ZipBenchmark_Int16   | Sum128X2Base_X2            |                |               |       178.533 |   163.560 |   161.982 |  1063.708 |  1098.994 |
| YGroup3ZipBenchmark_Int16   | Sum128X2Base_Unzip         |                |               |               |           |           |  1523.978 |  1539.842 |
| YGroup3ZipBenchmark_Int16   | Sum128X2Base               |                |               |       178.112 |   163.139 |   163.235 |  1561.128 |  1539.309 |
| YGroup3ZipBenchmark_Int16   | Sum128X2AdvSimd_X2         |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum128X2AdvSimd_Unzip      |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum128X2AdvSimdB64_X2      |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum128X2AdvSimdB64_Unzip   |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum128X2PackedSimd_X2      |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum128X2PackedSimd_Unzip   |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum128X2Sse_X2             |                |               |      1795.284 |  2228.677 |  2245.617 |  3839.485 |  5619.666 |
| YGroup3ZipBenchmark_Int16   | Sum128X2Sse_Unzip          |                |               |      1701.931 |  1707.062 |  1716.784 |  1708.523 |  4097.653 |
| YGroup3ZipBenchmark_Int16   | Sum128X2Traits             |                |               |      1763.835 |  2275.149 |  2270.510 |  3944.475 |  5884.038 |
| YGroup3ZipBenchmark_Int16   | Sum256Base_Basic           |                |               |       233.790 |   191.438 |   240.470 |   507.416 |   582.283 |
| YGroup3ZipBenchmark_Int16   | Sum256Base_ByShorter       |                |               |               |           |           |  1562.642 |  1275.999 |
| YGroup3ZipBenchmark_Int16   | Sum256Base_ByX2Unzip       |                |               |               |           |           |  1185.487 |  1377.177 |
| YGroup3ZipBenchmark_Int16   | Sum256Base                 |                |               |       239.586 |   176.938 |   235.395 |  1559.716 |  1276.016 |
| YGroup3ZipBenchmark_Int16   | Sum256Avx2_ByShorter       |                |               |      2012.520 |  2607.625 |  2720.129 |  3712.569 |  4914.845 |
| YGroup3ZipBenchmark_Int16   | Sum256Avx2_ByX2Unzip       |                |               |      1067.078 |  1068.410 |  1061.041 |  1061.424 |  4030.032 |
| YGroup3ZipBenchmark_Int16   | Sum256Avx2_Shuffle         |                |               |      4525.043 |  5754.492 |  5708.400 |  6068.177 |  6852.817 |
| YGroup3ZipBenchmark_Int16   | Sum256Avx2_ShuffleX        |                |               |               |           |           |           | 10534.644 |
| YGroup3ZipBenchmark_Int16   | Sum256Traits               |                |               |      4614.883 |  5861.841 |  5865.302 |  6060.287 |  9771.631 |
| YGroup3ZipBenchmark_Int16   | Sum256X2Base_Basic         |                |               |       227.367 |   208.802 |   230.991 |   460.380 |   540.562 |
| YGroup3ZipBenchmark_Int16   | Sum256X2Base_X2            |                |               |       234.234 |   229.126 |   236.036 |  1732.898 |  1442.843 |
| YGroup3ZipBenchmark_Int16   | Sum256X2Base_Unzip         |                |               |               |           |           |  1780.678 |  2260.480 |
| YGroup3ZipBenchmark_Int16   | Sum256X2Base               |                |               |       232.202 |   236.875 |   239.173 |  1778.823 |  2260.624 |
| YGroup3ZipBenchmark_Int16   | Sum256X2Avx2_X2            |                |               |      3201.376 |  1360.767 |  3430.947 |  5684.912 | 10732.979 |
| YGroup3ZipBenchmark_Int16   | Sum256X2Avx2_Unzip         |                |               |      1984.669 |  1984.712 |  2015.327 |  2003.281 |  6453.217 |
| YGroup3ZipBenchmark_Int16   | Sum256X2Traits             |                |               |      3199.034 |  1408.271 |  4089.343 |  5827.259 | 10657.366 |
| YGroup3ZipBenchmark_Int16   | Sum512Base_Basic           |                |               |               |           |           |           |   523.716 |
| YGroup3ZipBenchmark_Int16   | Sum512Base_ByShorter       |                |               |               |           |           |           |  1800.216 |
| YGroup3ZipBenchmark_Int16   | Sum512Base_ByX2Unzip       |                |               |               |           |           |           |  1187.754 |
| YGroup3ZipBenchmark_Int16   | Sum512Base                 |                |               |               |           |           |           |  1799.529 |
| YGroup3ZipBenchmark_Int16   | Sum512Avx512_ByShorter     |                |               |               |           |           |           |  7371.247 |
| YGroup3ZipBenchmark_Int16   | Sum512Avx512_ByX2Unzip     |                |               |               |           |           |           |  3699.195 |
| YGroup3ZipBenchmark_Int16   | Sum512Avx512_ShuffleX      |                |               |               |           |           |           | 11620.418 |
| YGroup3ZipBenchmark_Int16   | Sum512Traits               |                |               |               |           |           |           | 11912.948 |
| YGroup3ZipBenchmark_Int16   | Sum512X2Base_Basic         |                |               |               |           |           |           |   523.543 |
| YGroup3ZipBenchmark_Int16   | Sum512X2Base_X2            |                |               |               |           |           |           |  1996.031 |
| YGroup3ZipBenchmark_Int16   | Sum512X2Base_Unzip         |                |               |               |           |           |           |  2008.463 |
| YGroup3ZipBenchmark_Int16   | Sum512X2Base               |                |               |               |           |           |           |  2014.343 |
| YGroup3ZipBenchmark_Int16   | Sum512X2Avx512_X2          |                |               |               |           |           |           | 12011.647 |
| YGroup3ZipBenchmark_Int16   | Sum512X2Avx512_Unzip       |                |               |               |           |           |           |  6324.074 |
| YGroup3ZipBenchmark_Int16   | Sum512X2Traits             |                |               |               |           |           |           | 11915.957 |
| YGroup3ZipBenchmark_Int32   | SumBase_Basic              |        187.137 |       275.319 |       365.431 |   178.558 |   362.014 |   332.869 |   376.437 |
| YGroup3ZipBenchmark_Int32   | SumBase_ByX2Unzip          |        107.792 |        96.670 |       112.189 |   102.372 |   111.291 |   564.131 |   644.576 |
| YGroup3ZipBenchmark_Int32   | SumBase                    |        183.103 |       288.307 |       356.854 |   178.660 |   362.193 |   560.215 |   643.577 |
| YGroup3ZipBenchmark_Int32   | SumTraits                  |        184.919 |       307.032 |      5705.539 |  6074.149 |  5954.770 |  5886.480 |  6313.509 |
| YGroup3ZipBenchmark_Int32   | SumX2Base_Basic            |        171.718 |       242.039 |       358.544 |   315.837 |   341.835 |   315.137 |   359.289 |
| YGroup3ZipBenchmark_Int32   | SumX2Base_X2               |        166.756 |       238.313 |       333.863 |   277.547 |   347.516 |   552.357 |   638.540 |
| YGroup3ZipBenchmark_Int32   | SumX2Base_Unzip            |        195.267 |       188.894 |       200.058 |   173.815 |   200.606 |  1111.858 |  1284.918 |
| YGroup3ZipBenchmark_Int32   | SumX2Base                  |        164.949 |       244.899 |       334.504 |   271.947 |   349.692 |  1124.193 |  1286.062 |
| YGroup3ZipBenchmark_Int32   | SumX2Traits                |        165.592 |       245.669 |      4987.932 |  5943.090 |  5998.708 |  5822.141 |  6613.310 |
| YGroup3ZipBenchmark_Int32   | Sum128Base_Basic           |                |               |       101.283 |   109.632 |   103.054 |   217.685 |   217.012 |
| YGroup3ZipBenchmark_Int32   | Sum128Base_ByX2Unzip       |                |               |               |           |           |   702.967 |   825.751 |
| YGroup3ZipBenchmark_Int32   | Sum128Base                 |                |               |       100.872 |   109.066 |   103.830 |   704.515 |   830.109 |
| YGroup3ZipBenchmark_Int32   | Sum128AdvSimd_ByX2Unzip    |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum128AdvSimd_Shuffle      |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum128AdvSimd_ShuffleX     |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum128AdvSimdB64_ByX2Unzip |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum128AdvSimdB64_Shuffle   |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum128AdvSimdB64_ShuffleX  |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum128PackedSimd_ByX2Unzip |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum128PackedSimd_Shuffle   |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum128Sse_ByX2Unzip        |                |               |      2030.279 |  2054.336 |  2062.224 |  2039.191 |  2515.324 |
| YGroup3ZipBenchmark_Int32   | Sum128Sse_Shuffle          |                |               |      1181.883 |  1689.048 |  1699.261 |  2063.776 |  2049.798 |
| YGroup3ZipBenchmark_Int32   | Sum128Sse_ShuffleX         |                |               |               |           |           |           |  2692.596 |
| YGroup3ZipBenchmark_Int32   | Sum128Sse_ShuffleXImm      |                |               |      4104.861 |  4157.462 |  4149.989 |  3973.944 |  4394.699 |
| YGroup3ZipBenchmark_Int32   | Sum128Traits               |                |               |      4168.915 |  4149.212 |  4040.905 |  3949.682 |  4501.424 |
| YGroup3ZipBenchmark_Int32   | Sum128X2Base_Basic         |                |               |       104.024 |   107.224 |   109.522 |   190.227 |   256.334 |
| YGroup3ZipBenchmark_Int32   | Sum128X2Base_X2            |                |               |       101.102 |   106.509 |   107.879 |   720.318 |   919.572 |
| YGroup3ZipBenchmark_Int32   | Sum128X2Base_Unzip         |                |               |               |           |           |   981.471 |  1048.194 |
| YGroup3ZipBenchmark_Int32   | Sum128X2Base               |                |               |       102.715 |   107.861 |   107.000 |   964.226 |  1047.316 |
| YGroup3ZipBenchmark_Int32   | Sum128X2AdvSimd_X2         |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum128X2AdvSimd_Unzip      |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum128X2AdvSimdB64_X2      |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum128X2AdvSimdB64_Unzip   |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum128X2PackedSimd_X2      |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum128X2PackedSimd_Unzip   |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum128X2Sse_X2             |                |               |      4292.981 |  4219.604 |  4132.826 |  4081.624 |  4833.785 |
| YGroup3ZipBenchmark_Int32   | Sum128X2Sse_Unzip          |                |               |      2820.796 |  2799.730 |  2810.238 |  2714.210 |  3400.468 |
| YGroup3ZipBenchmark_Int32   | Sum128X2Traits             |                |               |      4045.680 |  3977.528 |  4129.902 |  4047.165 |  4799.044 |
| YGroup3ZipBenchmark_Int32   | Sum256Base_Basic           |                |               |       153.377 |   113.763 |   168.718 |   328.566 |   371.391 |
| YGroup3ZipBenchmark_Int32   | Sum256Base_ByShorter       |                |               |               |           |           |   863.216 |   843.489 |
| YGroup3ZipBenchmark_Int32   | Sum256Base_ByX2Unzip       |                |               |               |           |           |   758.970 |   961.616 |
| YGroup3ZipBenchmark_Int32   | Sum256Base                 |                |               |       165.340 |   111.069 |   171.084 |   864.224 |   842.907 |
| YGroup3ZipBenchmark_Int32   | Sum256Avx2_ByShorter       |                |               |      3325.145 |  3918.436 |  3834.751 |  3390.365 |  3646.666 |
| YGroup3ZipBenchmark_Int32   | Sum256Avx2_ByX2Unzip       |                |               |      1294.603 |  1296.459 |  1294.282 |  1286.867 |  2694.290 |
| YGroup3ZipBenchmark_Int32   | Sum256Avx2_Shuffle         |                |               |      2264.911 |  2900.709 |  2985.413 |  2964.651 |  3366.230 |
| YGroup3ZipBenchmark_Int32   | Sum256Avx2_ShuffleX        |                |               |               |           |           |           |  5136.703 |
| YGroup3ZipBenchmark_Int32   | Sum256Avx2_ShuffleXImm     |                |               |      5711.050 |  5902.148 |  6171.966 |  5814.163 |  6288.328 |
| YGroup3ZipBenchmark_Int32   | Sum256Traits               |                |               |      6055.653 |  5876.988 |  5935.859 |  5859.163 |  6450.377 |
| YGroup3ZipBenchmark_Int32   | Sum256X2Base_Basic         |                |               |       146.169 |   137.301 |   167.335 |   312.188 |   367.085 |
| YGroup3ZipBenchmark_Int32   | Sum256X2Base_X2            |                |               |       161.559 |   151.210 |   169.256 |   979.786 |   977.380 |
| YGroup3ZipBenchmark_Int32   | Sum256X2Base_Unzip         |                |               |               |           |           |  1168.329 |  1449.824 |
| YGroup3ZipBenchmark_Int32   | Sum256X2Base               |                |               |       160.661 |   155.681 |   166.223 |  1171.904 |  1446.490 |
| YGroup3ZipBenchmark_Int32   | Sum256X2Avx2_X2            |                |               |      5946.376 |  5873.015 |  5890.432 |  5811.831 |  6569.127 |
| YGroup3ZipBenchmark_Int32   | Sum256X2Avx2_Unzip         |                |               |      2392.761 |  2370.980 |  2374.834 |  2370.711 |  4073.254 |
| YGroup3ZipBenchmark_Int32   | Sum256X2Traits             |                |               |      5842.373 |  5773.941 |  5734.486 |  5644.395 |  6659.476 |
| YGroup3ZipBenchmark_Int32   | Sum512Base_Basic           |                |               |               |           |           |           |   385.577 |
| YGroup3ZipBenchmark_Int32   | Sum512Base_ByShorter       |                |               |               |           |           |           |  1096.304 |
| YGroup3ZipBenchmark_Int32   | Sum512Base_ByX2Unzip       |                |               |               |           |           |           |   761.296 |
| YGroup3ZipBenchmark_Int32   | Sum512Base                 |                |               |               |           |           |           |  1098.474 |
| YGroup3ZipBenchmark_Int32   | Sum512Avx512_ByShorter     |                |               |               |           |           |           |  3952.849 |
| YGroup3ZipBenchmark_Int32   | Sum512Avx512_ByX2Unzip     |                |               |               |           |           |           |  2324.108 |
| YGroup3ZipBenchmark_Int32   | Sum512Avx512_ShuffleX      |                |               |               |           |           |           |  5899.928 |
| YGroup3ZipBenchmark_Int32   | Sum512Avx512_ShuffleXImm   |                |               |               |           |           |           |  5985.577 |
| YGroup3ZipBenchmark_Int32   | Sum512Traits               |                |               |               |           |           |           |  6006.968 |
| YGroup3ZipBenchmark_Int32   | Sum512X2Base_Basic         |                |               |               |           |           |           |   359.422 |
| YGroup3ZipBenchmark_Int32   | Sum512X2Base_X2            |                |               |               |           |           |           |  1247.789 |
| YGroup3ZipBenchmark_Int32   | Sum512X2Base_Unzip         |                |               |               |           |           |           |  1223.325 |
| YGroup3ZipBenchmark_Int32   | Sum512X2Base               |                |               |               |           |           |           |  1252.354 |
| YGroup3ZipBenchmark_Int32   | Sum512X2Avx512_X2          |                |               |               |           |           |           |  5960.937 |
| YGroup3ZipBenchmark_Int32   | Sum512X2Avx512_Unzip       |                |               |               |           |           |           |  3836.576 |
| YGroup3ZipBenchmark_Int32   | Sum512X2Traits             |                |               |               |           |           |           |  5986.623 |
| YGroup3ZipBenchmark_Int64   | SumBase_Basic              |        120.917 |       160.615 |       209.369 |    96.724 |   219.178 |   199.561 |   226.295 |
| YGroup3ZipBenchmark_Int64   | SumBase                    |        119.616 |       158.049 |       217.464 |    97.743 |   214.023 |   198.233 |   225.900 |
| YGroup3ZipBenchmark_Int64   | SumTraits                  |        118.939 |       157.722 |      4001.016 |  4190.347 |  4236.178 |  4017.094 |  4583.389 |
| YGroup3ZipBenchmark_Int64   | SumX2Base_Basic            |        106.281 |       135.316 |       199.706 |   186.157 |   205.407 |   183.769 |   211.776 |
| YGroup3ZipBenchmark_Int64   | SumX2Base_X2               |        109.950 |       131.750 |       201.086 |   156.917 |   203.657 |   188.151 |   207.881 |
| YGroup3ZipBenchmark_Int64   | SumX2Base                  |        106.922 |       138.779 |       203.837 |   156.484 |   207.290 |   184.203 |   207.557 |
| YGroup3ZipBenchmark_Int64   | SumX2Traits                |        105.277 |       137.511 |      2688.523 |  4121.396 |  4146.674 |  4052.023 |  4574.568 |
| YGroup3ZipBenchmark_Int64   | Sum128Base_Basic           |                |               |        56.980 |    57.760 |    58.315 |   143.536 |   146.134 |
| YGroup3ZipBenchmark_Int64   | Sum128Base_Move            |                |               |        43.317 |    42.803 |    43.238 |    70.725 |   149.544 |
| YGroup3ZipBenchmark_Int64   | Sum128Base                 |                |               |        58.041 |    57.885 |    57.570 |   141.906 |   146.825 |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimd_AlignRight   |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimd_ByX2Unzip    |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimd_Shuffle      |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimd_ShuffleX     |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimdB64_ByX2Unzip |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimdB64_Shuffle   |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimdB64_ShuffleX  |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128PackedSimd_ByX2Unzip |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128PackedSimd_Shuffle   |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128Sse_ByX2Unzip        |                |               |      1626.305 |  2128.287 |  1967.777 |  2040.616 |  1946.775 |
| YGroup3ZipBenchmark_Int64   | Sum128Sse_Shuffle          |                |               |      1091.019 |  1518.320 |  1443.493 |  1478.706 |  1503.441 |
| YGroup3ZipBenchmark_Int64   | Sum128Sse_ShuffleX         |                |               |               |           |           |           |  2084.716 |
| YGroup3ZipBenchmark_Int64   | Sum128Sse_ShuffleXImm      |                |               |      3152.557 |  3304.785 |  3206.216 |  3051.116 |  3137.428 |
| YGroup3ZipBenchmark_Int64   | Sum128Traits               |                |               |      3132.392 |  3249.257 |  3081.855 |  3041.130 |  3168.371 |
| YGroup3ZipBenchmark_Int64   | Sum128X2Base_Basic         |                |               |        57.687 |    58.739 |    59.799 |   141.406 |   148.428 |
| YGroup3ZipBenchmark_Int64   | Sum128X2Base_X2            |                |               |        57.584 |    58.077 |    60.310 |   141.250 |   149.015 |
| YGroup3ZipBenchmark_Int64   | Sum128X2Base               |                |               |        57.255 |    58.376 |    60.242 |   141.900 |   149.088 |
| YGroup3ZipBenchmark_Int64   | Sum128X2AdvSimd_X2         |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128X2AdvSimd_Unzip      |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128X2AdvSimdB64_X2      |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128X2AdvSimdB64_Unzip   |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128X2PackedSimd_X2      |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128X2PackedSimd_Unzip   |                |               |               |           |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128X2Sse_X2             |                |               |      3318.389 |  3464.817 |  3469.736 |  3349.594 |  3640.803 |
| YGroup3ZipBenchmark_Int64   | Sum128X2Sse_Unzip          |                |               |      1497.639 |  1487.352 |  2190.299 |  2073.246 |  2484.139 |
| YGroup3ZipBenchmark_Int64   | Sum128X2Traits             |                |               |      3390.011 |  3342.186 |  3493.704 |  3401.052 |  3807.024 |
| YGroup3ZipBenchmark_Int64   | Sum256Base_Basic           |                |               |        89.299 |    61.811 |   100.013 |   200.176 |   223.751 |
| YGroup3ZipBenchmark_Int64   | Sum256Base_ByShorter       |                |               |               |           |           |   138.261 |   143.685 |
| YGroup3ZipBenchmark_Int64   | Sum256Base                 |                |               |        97.319 |    60.511 |    99.229 |   195.726 |   227.445 |
| YGroup3ZipBenchmark_Int64   | Sum256Avx2_ByShorter       |                |               |      2386.445 |  2711.574 |  2814.944 |  2445.416 |  2706.013 |
| YGroup3ZipBenchmark_Int64   | Sum256Avx2_ByX2Unzip       |                |               |      1052.382 |  1133.683 |  1119.946 |  1112.579 |  2110.139 |
| YGroup3ZipBenchmark_Int64   | Sum256Avx2_Shuffle         |                |               |      2011.699 |  2317.446 |  2290.538 |  2140.945 |  2406.720 |
| YGroup3ZipBenchmark_Int64   | Sum256Avx2_ShuffleX        |                |               |               |           |           |           |  2613.951 |
| YGroup3ZipBenchmark_Int64   | Sum256Avx2_ShuffleXImm     |                |               |      4188.730 |  4120.870 |  4279.829 |  4204.163 |  4473.729 |
| YGroup3ZipBenchmark_Int64   | Sum256Traits               |                |               |      4159.706 |  4252.392 |  4131.639 |  3964.121 |  4439.048 |
| YGroup3ZipBenchmark_Int64   | Sum256X2Base_Basic         |                |               |        83.047 |    77.695 |    96.935 |   182.155 |   210.219 |
| YGroup3ZipBenchmark_Int64   | Sum256X2Base_X2            |                |               |        92.487 |    83.990 |    96.789 |   183.814 |   212.375 |
| YGroup3ZipBenchmark_Int64   | Sum256X2Base               |                |               |        92.570 |    83.348 |    97.221 |   185.480 |   211.937 |
| YGroup3ZipBenchmark_Int64   | Sum256X2Avx2_X2            |                |               |      4204.600 |  4041.288 |  4197.264 |  4031.334 |  4615.440 |
| YGroup3ZipBenchmark_Int64   | Sum256X2Avx2_Unzip         |                |               |      1625.885 |  1612.407 |  1627.334 |  1600.553 |  2637.167 |
| YGroup3ZipBenchmark_Int64   | Sum256X2Traits             |                |               |      3916.547 |  4053.155 |  4013.313 |  4076.183 |  4645.092 |
| YGroup3ZipBenchmark_Int64   | Sum512Base_Basic           |                |               |               |           |           |           |   224.612 |
| YGroup3ZipBenchmark_Int64   | Sum512Base_ByShorter       |                |               |               |           |           |           |   191.972 |
| YGroup3ZipBenchmark_Int64   | Sum512Base                 |                |               |               |           |           |           |   225.954 |
| YGroup3ZipBenchmark_Int64   | Sum512Avx512_ByShorter     |                |               |               |           |           |           |  2884.058 |
| YGroup3ZipBenchmark_Int64   | Sum512Avx512_ByX2Unzip     |                |               |               |           |           |           |  1559.843 |
| YGroup3ZipBenchmark_Int64   | Sum512Avx512_ShuffleX      |                |               |               |           |           |           |  3015.456 |
| YGroup3ZipBenchmark_Int64   | Sum512Avx512_ShuffleXImm   |                |               |               |           |           |           |  4028.783 |
| YGroup3ZipBenchmark_Int64   | Sum512Traits               |                |               |               |           |           |           |  4048.897 |
| YGroup3ZipBenchmark_Int64   | Sum512X2Base_Basic         |                |               |               |           |           |           |   216.448 |
| YGroup3ZipBenchmark_Int64   | Sum512X2Base_X2            |                |               |               |           |           |           |   215.696 |
| YGroup3ZipBenchmark_Int64   | Sum512X2Base               |                |               |               |           |           |           |   207.311 |
| YGroup3ZipBenchmark_Int64   | Sum512X2Avx512_X2          |                |               |               |           |           |           |  4027.411 |
| YGroup3ZipBenchmark_Int64   | Sum512X2Avx512_Unzip       |                |               |               |           |           |           |  2439.135 |
| YGroup3ZipBenchmark_Int64   | Sum512X2Traits             |                |               |               |           |           |           |  4025.030 |

### Arm - Apple M2
| Type                        | Method                     |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :-------------------------- | :------------------------- | --------: | --------: | --------: |
| YGroup3UnzipBenchmark_Byte  | SumBase_Basic              |   722.423 |   965.473 |  1290.017 |
| YGroup3UnzipBenchmark_Byte  | SumBase_ByX2Zip            |  1700.102 |  1886.222 |  1912.470 |
| YGroup3UnzipBenchmark_Byte  | SumBase                    |  1700.158 |  1886.833 |  1913.147 |
| YGroup3UnzipBenchmark_Byte  | SumTraits                  | 12072.352 | 12069.818 | 20371.835 |
| YGroup3UnzipBenchmark_Byte  | SumX2Base_Basic            |   719.280 |   951.683 |  1299.420 |
| YGroup3UnzipBenchmark_Byte  | SumX2Base_X2               |  1208.996 |  1910.910 |  1912.091 |
| YGroup3UnzipBenchmark_Byte  | SumX2Base_Zip              |  3054.984 |  3375.253 |  3424.851 |
| YGroup3UnzipBenchmark_Byte  | SumX2Base                  |  3057.308 |  3375.158 |  3424.171 |
| YGroup3UnzipBenchmark_Byte  | SumX2Traits                | 13580.447 | 12071.817 | 20476.015 |
| YGroup3UnzipBenchmark_Byte  | Sum128Base_Basic           |   465.719 |   962.874 |  1290.033 |
| YGroup3UnzipBenchmark_Byte  | Sum128Base_ByX2Zip         |           |   254.869 |  2101.192 |
| YGroup3UnzipBenchmark_Byte  | Sum128Base                 |   463.472 |   255.703 |  2101.228 |
| YGroup3UnzipBenchmark_Byte  | Sum128AdvSimd_ByX2Zip      |  2026.016 |  2026.400 |  2145.494 |
| YGroup3UnzipBenchmark_Byte  | Sum128AdvSimd_Shuffle      |  4729.162 |  4794.441 |  4798.178 |
| YGroup3UnzipBenchmark_Byte  | Sum128AdvSimd_ShuffleX     |           |           |  9812.548 |
| YGroup3UnzipBenchmark_Byte  | Sum128AdvSimdB64_ByX2Zip   |  8366.119 |  8362.256 |  8367.958 |
| YGroup3UnzipBenchmark_Byte  | Sum128AdvSimdB64_Shuffle   | 12070.559 | 12069.563 | 12076.917 |
| YGroup3UnzipBenchmark_Byte  | Sum128AdvSimdB64_ShuffleX  |           |           | 20322.034 |
| YGroup3UnzipBenchmark_Byte  | Sum128PackedSimd_ByX2Zip   |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum128PackedSimd_Shuffle   |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum128Sse_ByX2Zip          |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum128Sse_Shuffle          |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum128Sse_ShuffleX         |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum128Traits               | 12071.952 | 12072.973 | 20441.550 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Base_Basic         |   457.571 |   952.899 |  1299.498 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Base_X2            |   457.261 |   188.736 |  1565.780 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Base_Zip           |           |   537.512 |  3605.695 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Base               |   457.574 |   537.536 |  3605.540 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2AdvSimd_X2         |  4728.871 |  4741.370 |  9851.189 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2AdvSimd_Zip        |  3554.042 |  3541.249 |  3605.209 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2AdvSimdB64_X2      | 12071.659 | 14481.596 | 20572.466 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2AdvSimdB64_Zip     | 13585.857 | 13581.618 | 13591.008 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2PackedSimd_X2      |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum128X2PackedSimd_Zip     |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Sse_X2             |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Sse_Zip            |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Traits             | 13583.550 | 12072.522 | 20551.546 |
| YGroup3UnzipBenchmark_Byte  | Sum256Base_Basic           |   454.684 |   425.076 |  1301.937 |
| YGroup3UnzipBenchmark_Byte  | Sum256Base_ByShorter       |           |   244.886 |  3566.962 |
| YGroup3UnzipBenchmark_Byte  | Sum256Base_ByX2Zip         |           |    81.624 |    77.045 |
| YGroup3UnzipBenchmark_Byte  | Sum256Base                 |   455.212 |   243.659 |  3567.267 |
| YGroup3UnzipBenchmark_Byte  | Sum256Avx2_ByShorter       |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum256Avx2_ByX2Unpack      |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum256Avx2_ByX2Zip         |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum256Avx2_Shuffle         |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum256Avx2_ShuffleX        |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum256Traits               |   442.973 |   252.028 |  3567.676 |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Base_Basic         |   267.290 |   421.634 |  1294.359 |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Base_X2            |   267.691 |   124.461 |  1751.799 |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Base_Zip           |           |   144.950 |   153.559 |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Base               |   266.934 |   125.595 |  1755.030 |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Avx2_Unpack        |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Avx2_X2            |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Avx2_Zip           |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Traits             |   253.629 |   122.883 |  1755.677 |
| YGroup3UnzipBenchmark_Byte  | Sum512Base_Basic           |           |           |  1263.426 |
| YGroup3UnzipBenchmark_Byte  | Sum512Base_ByShorter       |           |           |   957.573 |
| YGroup3UnzipBenchmark_Byte  | Sum512Base_ByX2Zip         |           |           |    61.226 |
| YGroup3UnzipBenchmark_Byte  | Sum512Base                 |           |           |   957.213 |
| YGroup3UnzipBenchmark_Byte  | Sum512Avx512_ByShorter     |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum512Avx512_ByX2Unpack    |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum512Avx512_ByX2Zip       |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum512Avx512_ShuffleX      |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum512Traits               |           |           |   959.915 |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Base_Basic         |           |           |  1229.933 |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Base_X2            |           |           |   907.657 |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Base_Zip           |           |           |   123.447 |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Base               |           |           |   907.351 |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Avx512_Unpack      |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Avx512_X2          |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Avx512_Zip         |           |           |           |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Traits             |           |           |   911.509 |
| YGroup3UnzipBenchmark_Int16 | SumBase_Basic              |   511.390 |   724.649 |  1163.592 |
| YGroup3UnzipBenchmark_Int16 | SumBase_ByX2Zip            |   954.404 |  1056.614 |  1071.993 |
| YGroup3UnzipBenchmark_Int16 | SumBase                    |   954.612 |  1056.627 |  1071.814 |
| YGroup3UnzipBenchmark_Int16 | SumTraits                  |  6042.142 |  6038.402 | 10529.245 |
| YGroup3UnzipBenchmark_Int16 | SumX2Base_Basic            |   511.101 |   706.798 |  1132.644 |
| YGroup3UnzipBenchmark_Int16 | SumX2Base_X2               |   529.875 |  1080.662 |  1067.542 |
| YGroup3UnzipBenchmark_Int16 | SumX2Base_Zip              |  1871.882 |  2085.908 |  2120.524 |
| YGroup3UnzipBenchmark_Int16 | SumX2Base                  |  1856.567 |  2063.952 |  2120.328 |
| YGroup3UnzipBenchmark_Int16 | SumX2Traits                |  8362.373 |  8360.858 | 10274.392 |
| YGroup3UnzipBenchmark_Int16 | Sum128Base_Basic           |   359.335 |   728.273 |  1163.698 |
| YGroup3UnzipBenchmark_Int16 | Sum128Base_ByX2Zip         |           |   166.226 |  1371.701 |
| YGroup3UnzipBenchmark_Int16 | Sum128Base                 |   359.200 |   166.375 |  1371.465 |
| YGroup3UnzipBenchmark_Int16 | Sum128AdvSimd_ByX2Zip      |  1308.779 |  1308.787 |  1409.321 |
| YGroup3UnzipBenchmark_Int16 | Sum128AdvSimd_Shuffle      |  2365.134 |  2397.617 |  2400.057 |
| YGroup3UnzipBenchmark_Int16 | Sum128AdvSimd_ShuffleX     |           |           |  4914.485 |
| YGroup3UnzipBenchmark_Int16 | Sum128AdvSimdB64_ByX2Zip   |  5437.850 |  5439.048 |  5440.579 |
| YGroup3UnzipBenchmark_Int16 | Sum128AdvSimdB64_Shuffle   |  6040.626 |  6038.533 |  6041.320 |
| YGroup3UnzipBenchmark_Int16 | Sum128AdvSimdB64_ShuffleX  |           |           | 10521.871 |
| YGroup3UnzipBenchmark_Int16 | Sum128PackedSimd_ByX2Zip   |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum128PackedSimd_Shuffle   |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum128Sse_ByX2Zip          |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum128Sse_Shuffle          |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum128Sse_ShuffleX         |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum128Traits               |  6038.304 |  6042.119 | 10521.204 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Base_Basic         |   351.128 |   709.898 |  1154.625 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Base_X2            |   349.774 |   122.979 |  1409.685 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Base_Zip           |           |   351.937 |  2254.719 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Base               |   349.805 |   354.231 |  2254.864 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2AdvSimd_X2         |  2365.540 |  2371.228 |  4911.703 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2AdvSimd_Zip        |  2215.344 |  2215.513 |  2270.614 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2AdvSimdB64_X2      |  6040.750 |  7247.471 | 10237.511 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2AdvSimdB64_Zip     |  8362.098 |  8361.053 |  8365.007 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2PackedSimd_X2      |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum128X2PackedSimd_Zip     |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Sse_X2             |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Sse_Zip            |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Traits             |  8363.704 |  8360.711 | 10225.936 |
| YGroup3UnzipBenchmark_Int16 | Sum256Base_Basic           |   351.934 |   344.981 |  1192.628 |
| YGroup3UnzipBenchmark_Int16 | Sum256Base_ByShorter       |           |   165.432 |  2219.003 |
| YGroup3UnzipBenchmark_Int16 | Sum256Base_ByX2Zip         |           |    79.999 |    85.277 |
| YGroup3UnzipBenchmark_Int16 | Sum256Base                 |   353.281 |   163.855 |  2218.896 |
| YGroup3UnzipBenchmark_Int16 | Sum256Avx2_ByShorter       |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum256Avx2_ByX2Unpack      |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum256Avx2_ByX2Zip         |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum256Avx2_Shuffle         |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum256Avx2_ShuffleX        |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum256Traits               |   353.670 |   161.386 |  2218.510 |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Base_Basic         |   319.069 |   325.287 |  1179.604 |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Base_X2            |   321.608 |    96.000 |  1080.253 |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Base_Zip           |           |   137.883 |   169.275 |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Base               |   321.541 |    93.630 |  1080.237 |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Avx2_Unpack        |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Avx2_X2            |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Avx2_Zip           |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Traits             |   290.116 |    94.683 |  1079.822 |
| YGroup3UnzipBenchmark_Int16 | Sum512Base_Basic           |           |           |  1129.013 |
| YGroup3UnzipBenchmark_Int16 | Sum512Base_ByShorter       |           |           |   551.557 |
| YGroup3UnzipBenchmark_Int16 | Sum512Base_ByX2Zip         |           |           |    70.691 |
| YGroup3UnzipBenchmark_Int16 | Sum512Base                 |           |           |   549.753 |
| YGroup3UnzipBenchmark_Int16 | Sum512Avx512_ByShorter     |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum512Avx512_ByX2Unpack    |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum512Avx512_ByX2Zip       |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum512Avx512_ShuffleX      |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum512Traits               |           |           |   574.309 |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Base_Basic         |           |           |  1052.507 |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Base_X2            |           |           |   535.679 |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Base_Zip           |           |           |   139.577 |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Base               |           |           |   538.185 |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Avx512_Unpack      |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Avx512_X2          |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Avx512_Zip         |           |           |           |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Traits             |           |           |   538.183 |
| YGroup3UnzipBenchmark_Int32 | SumBase_Basic              |   363.496 |   485.098 |   944.022 |
| YGroup3UnzipBenchmark_Int32 | SumBase_ByX2Zip            |    85.863 |   833.647 |   843.778 |
| YGroup3UnzipBenchmark_Int32 | SumBase                    |   362.409 |   833.849 |   843.467 |
| YGroup3UnzipBenchmark_Int32 | SumTraits                  |  3020.904 |  3022.090 |  5111.822 |
| YGroup3UnzipBenchmark_Int32 | SumX2Base_Basic            |   360.715 |   457.750 |   931.306 |
| YGroup3UnzipBenchmark_Int32 | SumX2Base_X2               |   359.846 |   850.315 |   843.871 |
| YGroup3UnzipBenchmark_Int32 | SumX2Base_Zip              |   169.800 |  1393.962 |  1387.946 |
| YGroup3UnzipBenchmark_Int32 | SumX2Base                  |   361.802 |  1359.042 |  1387.900 |
| YGroup3UnzipBenchmark_Int32 | SumX2Traits                |  5437.308 |  5438.716 |  5438.601 |
| YGroup3UnzipBenchmark_Int32 | Sum128Base_Basic           |   263.780 |   481.909 |   943.991 |
| YGroup3UnzipBenchmark_Int32 | Sum128Base_ByX2Zip         |           |   159.291 |   987.751 |
| YGroup3UnzipBenchmark_Int32 | Sum128Base                 |   262.117 |   160.001 |   987.791 |
| YGroup3UnzipBenchmark_Int32 | Sum128AdvSimd_ByX2Zip      |   922.023 |   922.172 |  1025.766 |
| YGroup3UnzipBenchmark_Int32 | Sum128AdvSimd_Shuffle      |  1182.849 |  1198.961 |  1199.928 |
| YGroup3UnzipBenchmark_Int32 | Sum128AdvSimd_ShuffleX     |           |           |  2436.490 |
| YGroup3UnzipBenchmark_Int32 | Sum128AdvSimdB64_ByX2Zip   |  3884.782 |  3882.562 |  3885.602 |
| YGroup3UnzipBenchmark_Int32 | Sum128AdvSimdB64_Shuffle   |  3021.534 |  3021.061 |  3022.103 |
| YGroup3UnzipBenchmark_Int32 | Sum128AdvSimdB64_ShuffleX  |           |           |  5125.406 |
| YGroup3UnzipBenchmark_Int32 | Sum128PackedSimd_ByX2Zip   |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum128PackedSimd_Shuffle   |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum128Sse_ByX2Zip          |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum128Sse_Shuffle          |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum128Sse_ShuffleX         |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum128Sse_ShuffleXImm      |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum128Traits               |  3020.932 |  3022.039 |  5146.153 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Base_Basic         |   252.068 |   459.358 |   931.330 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Base_X2            |   253.555 |    93.920 |  1025.300 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Base_Zip           |           |   260.583 |  1508.893 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Base               |   252.666 |   260.257 |  1508.791 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2AdvSimd_X2         |  1182.895 |  1185.806 |  2459.532 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2AdvSimd_Zip        |  1470.120 |  1470.084 |  1550.665 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2AdvSimdB64_X2      |  3021.801 |  3626.446 |  5136.023 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2AdvSimdB64_Zip     |  5438.177 |  5439.053 |  5438.226 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2PackedSimd_X2      |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum128X2PackedSimd_Zip     |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Sse_X2             |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Sse_Zip            |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Traits             |  5437.415 |  5438.646 |  5438.830 |
| YGroup3UnzipBenchmark_Int32 | Sum256Base_Basic           |   248.753 |   243.901 |   996.742 |
| YGroup3UnzipBenchmark_Int32 | Sum256Base_ByShorter       |           |   118.626 |  1470.435 |
| YGroup3UnzipBenchmark_Int32 | Sum256Base_ByX2Zip         |           |    68.242 |    88.819 |
| YGroup3UnzipBenchmark_Int32 | Sum256Base                 |   250.007 |   117.115 |  1470.361 |
| YGroup3UnzipBenchmark_Int32 | Sum256Avx2_ByShorter       |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum256Avx2_ByX2Unpack      |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum256Avx2_ByX2Zip         |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum256Avx2_Shuffle         |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum256Avx2_ShuffleX        |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum256Avx2_ShuffleXImm     |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum256Traits               |   250.566 |   116.844 |  1470.572 |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Base_Basic         |   223.402 |   250.648 |   967.899 |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Base_X2            |   226.912 |    67.009 |  1570.643 |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Base_Zip           |           |   117.746 |   172.068 |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Base               |   227.263 |    66.848 |  1570.518 |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Avx2_Unpack        |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Avx2_X2            |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Avx2_Zip           |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Traits             |   205.450 |    68.566 |  1570.592 |
| YGroup3UnzipBenchmark_Int32 | Sum512Base_Basic           |           |           |   873.278 |
| YGroup3UnzipBenchmark_Int32 | Sum512Base_ByShorter       |           |           |   812.467 |
| YGroup3UnzipBenchmark_Int32 | Sum512Base_ByX2Zip         |           |           |    71.911 |
| YGroup3UnzipBenchmark_Int32 | Sum512Base                 |           |           |   812.698 |
| YGroup3UnzipBenchmark_Int32 | Sum512Avx512_ByShorter     |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum512Avx512_ByX2Unpack    |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum512Avx512_ByX2Zip       |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum512Avx512_ShuffleX      |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum512Avx512_ShuffleXImm   |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum512Traits               |           |           |   979.345 |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Base_Basic         |           |           |   748.675 |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Base_X2            |           |           |   456.618 |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Base_Zip           |           |           |   140.795 |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Base               |           |           |   456.803 |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Avx512_Unpack      |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Avx512_X2          |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Avx512_Zip         |           |           |           |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Traits             |           |           |   457.704 |
| YGroup3UnzipBenchmark_Int64 | SumBase_Basic              |   249.622 |   310.242 |   606.023 |
| YGroup3UnzipBenchmark_Int64 | SumBase                    |   247.161 |   311.638 |   606.169 |
| YGroup3UnzipBenchmark_Int64 | SumTraits                  |  3391.780 |  3394.515 |  3387.173 |
| YGroup3UnzipBenchmark_Int64 | SumX2Base_Basic            |   229.029 |   294.602 |   604.657 |
| YGroup3UnzipBenchmark_Int64 | SumX2Base_X2               |   230.347 |   295.320 |   604.699 |
| YGroup3UnzipBenchmark_Int64 | SumX2Base                  |   230.299 |   294.045 |   604.597 |
| YGroup3UnzipBenchmark_Int64 | SumX2Traits                |  3399.847 |  3399.648 |  4184.177 |
| YGroup3UnzipBenchmark_Int64 | Sum128Base_Basic           |   170.786 |   311.517 |   606.162 |
| YGroup3UnzipBenchmark_Int64 | Sum128Base_Move            |   433.015 |  2970.437 |  3368.583 |
| YGroup3UnzipBenchmark_Int64 | Sum128Base                 |   433.708 |  2969.724 |  3368.474 |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimd_AlignRight   |  3392.658 |  3395.396 |  3386.968 |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimd_ByX2Zip      |  1511.769 |  1511.435 |  1700.659 |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimd_Shuffle      |   869.412 |   900.725 |   900.944 |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimd_ShuffleX     |           |           |  1843.487 |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimdB64_ByX2Zip   |  2863.165 |  3199.282 |  3200.331 |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimdB64_Shuffle   |  2266.500 |  2263.353 |  2263.171 |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimdB64_ShuffleX  |           |           |  3200.430 |
| YGroup3UnzipBenchmark_Int64 | Sum128PackedSimd_ByX2Zip   |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128PackedSimd_Shuffle   |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128Sse_ByX2Zip          |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128Sse_Shuffle          |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128Sse_ShuffleX         |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128Sse_ShuffleXImm      |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128Traits               |  3393.987 |  3395.410 |  3386.401 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2Base_Basic         |   162.466 |   290.957 |   604.648 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2Base_X2            |   658.297 |  2924.472 |  4452.921 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2Base               |   658.378 |  2930.679 |  4453.852 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2AdvSimd_X2         |  3397.663 |  3399.961 |  4182.899 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2AdvSimd_Zip        |  2265.388 |  2265.439 |  2473.055 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2AdvSimdB64_X2      |  3398.333 |  3399.300 |  4183.467 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2AdvSimdB64_Zip     |  3882.724 |  3884.121 |  3886.332 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2PackedSimd_X2      |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128X2PackedSimd_Zip     |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128X2Sse_X2             |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128X2Sse_Zip            |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum128X2Traits             |  3399.429 |  3399.974 |  4182.637 |
| YGroup3UnzipBenchmark_Int64 | Sum256Base_Basic           |   140.863 |   141.186 |   593.771 |
| YGroup3UnzipBenchmark_Int64 | Sum256Base_ByShorter       |           |   146.436 |  4893.918 |
| YGroup3UnzipBenchmark_Int64 | Sum256Base                 |   140.880 |   140.711 |   593.762 |
| YGroup3UnzipBenchmark_Int64 | Sum256Avx2_ByShorter       |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum256Avx2_ByX2Unpack      |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum256Avx2_ByX2Zip         |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum256Avx2_Shuffle         |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum256Avx2_ShuffleX        |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum256Avx2_ShuffleXImm     |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum256Traits               |   140.118 |   140.898 |   593.772 |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Base_Basic         |   129.907 |   149.743 |   576.647 |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Base_X2            |   130.913 |   149.281 |   576.610 |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Base               |   130.275 |   148.169 |   576.588 |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Avx2_Unpack        |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Avx2_X2            |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Avx2_Zip           |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Traits             |   131.114 |   150.554 |   576.644 |
| YGroup3UnzipBenchmark_Int64 | Sum512Base_Basic           |           |           |   535.699 |
| YGroup3UnzipBenchmark_Int64 | Sum512Base_ByShorter       |           |           |   576.381 |
| YGroup3UnzipBenchmark_Int64 | Sum512Base                 |           |           |   530.667 |
| YGroup3UnzipBenchmark_Int64 | Sum512Avx512_ByShorter     |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum512Avx512_ByX2Unpack    |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum512Avx512_ByX2Zip       |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum512Avx512_ShuffleX      |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum512Avx512_ShuffleXImm   |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum512Traits               |           |           |   530.486 |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Base_Basic         |           |           |   454.452 |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Base_X2            |           |           |   452.617 |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Base               |           |           |   452.674 |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Avx512_Unpack      |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Avx512_X2          |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Avx512_Zip         |           |           |           |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Traits             |           |           |   452.628 |
| YGroup3ZipBenchmark_Byte    | SumBase_Basic              |   826.236 |  1166.921 |   944.287 |
| YGroup3ZipBenchmark_Byte    | SumBase_ByX2Unzip          |   680.536 |  2592.060 |  2624.203 |
| YGroup3ZipBenchmark_Byte    | SumBase                    |   825.927 |  2592.130 |  2624.512 |
| YGroup3ZipBenchmark_Byte    | SumTraits                  | 12071.652 | 12072.992 | 20224.236 |
| YGroup3ZipBenchmark_Byte    | SumX2Base_Basic            |   827.647 |  1167.091 |   945.247 |
| YGroup3ZipBenchmark_Byte    | SumX2Base_X2               |   827.694 |  2648.862 |  2628.571 |
| YGroup3ZipBenchmark_Byte    | SumX2Base_Unzip            |  1118.608 |  4392.532 |  4364.380 |
| YGroup3ZipBenchmark_Byte    | SumX2Base                  |  1118.431 |  4389.446 |  4364.299 |
| YGroup3ZipBenchmark_Byte    | SumX2Traits                | 12787.321 | 12789.137 | 18003.583 |
| YGroup3ZipBenchmark_Byte    | Sum128Base_Basic           |   499.847 |  1166.698 |   944.437 |
| YGroup3ZipBenchmark_Byte    | Sum128Base_ByX2Unzip       |           |  2969.448 |  3178.779 |
| YGroup3ZipBenchmark_Byte    | Sum128Base                 |   499.885 |  2969.430 |  3178.814 |
| YGroup3ZipBenchmark_Byte    | Sum128AdvSimd_ByX2Unzip    |  2968.993 |  2970.137 |  3178.732 |
| YGroup3ZipBenchmark_Byte    | Sum128AdvSimd_Shuffle      |  4728.918 |  4792.854 |  4797.161 |
| YGroup3ZipBenchmark_Byte    | Sum128AdvSimd_ShuffleX     |           |           |  9813.850 |
| YGroup3ZipBenchmark_Byte    | Sum128AdvSimdB64_ByX2Unzip |  8363.726 |  8363.679 |  8363.699 |
| YGroup3ZipBenchmark_Byte    | Sum128AdvSimdB64_Shuffle   | 12074.551 | 12069.484 | 12076.790 |
| YGroup3ZipBenchmark_Byte    | Sum128AdvSimdB64_ShuffleX  |           |           | 20304.066 |
| YGroup3ZipBenchmark_Byte    | Sum128PackedSimd_ByX2Unzip |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum128PackedSimd_Shuffle   |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum128Sse_ByX2Unzip        |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum128Sse_Shuffle          |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum128Sse_ShuffleX         |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum128Traits               | 12076.569 | 12071.237 | 20288.249 |
| YGroup3ZipBenchmark_Byte    | Sum128X2Base_Basic         |   482.316 |  1166.903 |   945.214 |
| YGroup3ZipBenchmark_Byte    | Sum128X2Base_X2            |   482.158 |  3004.114 |  3272.588 |
| YGroup3ZipBenchmark_Byte    | Sum128X2Base_Unzip         |           |  4803.883 |  4994.817 |
| YGroup3ZipBenchmark_Byte    | Sum128X2Base               |   482.277 |  4803.303 |  4995.110 |
| YGroup3ZipBenchmark_Byte    | Sum128X2AdvSimd_X2         |  4729.988 |  4802.180 |  9049.327 |
| YGroup3ZipBenchmark_Byte    | Sum128X2AdvSimd_Unzip      |  4803.999 |  4803.243 |  4995.321 |
| YGroup3ZipBenchmark_Byte    | Sum128X2AdvSimdB64_X2      | 12071.310 | 12069.901 | 18032.565 |
| YGroup3ZipBenchmark_Byte    | Sum128X2AdvSimdB64_Unzip   | 12786.623 | 12785.402 | 12794.377 |
| YGroup3ZipBenchmark_Byte    | Sum128X2PackedSimd_X2      |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum128X2PackedSimd_Unzip   |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum128X2Sse_X2             |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum128X2Sse_Unzip          |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum128X2Traits             | 12786.572 | 12787.206 | 18044.990 |
| YGroup3ZipBenchmark_Byte    | Sum256Base_Basic           |   466.113 |   449.571 |   981.692 |
| YGroup3ZipBenchmark_Byte    | Sum256Base_ByShorter       |           |   464.977 |  4992.279 |
| YGroup3ZipBenchmark_Byte    | Sum256Base_ByX2Unzip       |           |    71.934 |   106.925 |
| YGroup3ZipBenchmark_Byte    | Sum256Base                 |   454.692 |   456.858 |  4992.449 |
| YGroup3ZipBenchmark_Byte    | Sum256Avx2_ByShorter       |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum256Avx2_ByX2Unzip       |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum256Avx2_Shuffle         |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum256Avx2_ShuffleX        |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum256Traits               |   438.753 |   456.985 |  4992.696 |
| YGroup3ZipBenchmark_Byte    | Sum256X2Base_Basic         |   437.333 |   440.811 |   976.750 |
| YGroup3ZipBenchmark_Byte    | Sum256X2Base_X2            |   432.164 |   161.447 |  5100.969 |
| YGroup3ZipBenchmark_Byte    | Sum256X2Base_Unzip         |           |   104.810 |   213.217 |
| YGroup3ZipBenchmark_Byte    | Sum256X2Base               |   432.681 |   163.130 |  5101.028 |
| YGroup3ZipBenchmark_Byte    | Sum256X2Avx2_X2            |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum256X2Avx2_Unzip         |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum256X2Traits             |   245.411 |   158.707 |  5101.711 |
| YGroup3ZipBenchmark_Byte    | Sum512Base_Basic           |           |           |   968.015 |
| YGroup3ZipBenchmark_Byte    | Sum512Base_ByShorter       |           |           |  4977.121 |
| YGroup3ZipBenchmark_Byte    | Sum512Base_ByX2Unzip       |           |           |    86.111 |
| YGroup3ZipBenchmark_Byte    | Sum512Base                 |           |           |  4976.065 |
| YGroup3ZipBenchmark_Byte    | Sum512Avx512_ByShorter     |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum512Avx512_ByX2Unzip     |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum512Avx512_ShuffleX      |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum512Traits               |           |           |  4976.564 |
| YGroup3ZipBenchmark_Byte    | Sum512X2Base_Basic         |           |           |   958.345 |
| YGroup3ZipBenchmark_Byte    | Sum512X2Base_X2            |           |           |  1801.164 |
| YGroup3ZipBenchmark_Byte    | Sum512X2Base_Unzip         |           |           |   166.579 |
| YGroup3ZipBenchmark_Byte    | Sum512X2Base               |           |           |  1800.261 |
| YGroup3ZipBenchmark_Byte    | Sum512X2Avx512_X2          |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum512X2Avx512_Unzip       |           |           |           |
| YGroup3ZipBenchmark_Byte    | Sum512X2Traits             |           |           |  1803.472 |
| YGroup3ZipBenchmark_Int16   | SumBase_Basic              |   661.574 |   966.501 |   821.187 |
| YGroup3ZipBenchmark_Int16   | SumBase_ByX2Unzip          |   660.439 |  1408.356 |  1415.167 |
| YGroup3ZipBenchmark_Int16   | SumBase                    |   661.572 |  1408.032 |  1415.211 |
| YGroup3ZipBenchmark_Int16   | SumTraits                  |  6041.101 |  6041.231 | 10412.378 |
| YGroup3ZipBenchmark_Int16   | SumX2Base_Basic            |   657.562 |   951.665 |   816.071 |
| YGroup3ZipBenchmark_Int16   | SumX2Base_X2               |   657.472 |  1438.745 |  1425.187 |
| YGroup3ZipBenchmark_Int16   | SumX2Base_Unzip            |  1300.064 |  2753.867 |  2701.960 |
| YGroup3ZipBenchmark_Int16   | SumX2Base                  |   657.049 |  2703.655 |  2701.930 |
| YGroup3ZipBenchmark_Int16   | SumX2Traits                |  7766.751 |  7766.207 |  7766.276 |
| YGroup3ZipBenchmark_Int16   | Sum128Base_Basic           |   433.033 |   949.079 |   821.177 |
| YGroup3ZipBenchmark_Int16   | Sum128Base_ByX2Unzip       |           |  1973.955 |  2166.065 |
| YGroup3ZipBenchmark_Int16   | Sum128Base                 |   432.906 |  1973.918 |  2166.278 |
| YGroup3ZipBenchmark_Int16   | Sum128AdvSimd_ByX2Unzip    |  1973.587 |  1973.763 |  2165.891 |
| YGroup3ZipBenchmark_Int16   | Sum128AdvSimd_Shuffle      |  2364.970 |  2397.815 |  2399.154 |
| YGroup3ZipBenchmark_Int16   | Sum128AdvSimd_ShuffleX     |           |           |  4905.227 |
| YGroup3ZipBenchmark_Int16   | Sum128AdvSimdB64_ByX2Unzip |  5438.586 |  5438.688 |  5439.263 |
| YGroup3ZipBenchmark_Int16   | Sum128AdvSimdB64_Shuffle   |  6041.244 |  6041.112 |  6041.856 |
| YGroup3ZipBenchmark_Int16   | Sum128AdvSimdB64_ShuffleX  |           |           | 10514.324 |
| YGroup3ZipBenchmark_Int16   | Sum128PackedSimd_ByX2Unzip |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum128PackedSimd_Shuffle   |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum128Sse_ByX2Unzip        |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum128Sse_Shuffle          |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum128Sse_ShuffleX         |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum128Traits               |  6040.646 |  6039.947 | 10492.724 |
| YGroup3ZipBenchmark_Int16   | Sum128X2Base_Basic         |   416.452 |   942.519 |   815.918 |
| YGroup3ZipBenchmark_Int16   | Sum128X2Base_X2            |   415.712 |  2009.099 |  2248.934 |
| YGroup3ZipBenchmark_Int16   | Sum128X2Base_Unzip         |           |  3006.686 |  3169.586 |
| YGroup3ZipBenchmark_Int16   | Sum128X2Base               |   416.845 |  3005.833 |  3169.223 |
| YGroup3ZipBenchmark_Int16   | Sum128X2AdvSimd_X2         |  2365.218 |  2401.441 |  4524.073 |
| YGroup3ZipBenchmark_Int16   | Sum128X2AdvSimd_Unzip      |  3006.578 |  3005.865 |  3168.558 |
| YGroup3ZipBenchmark_Int16   | Sum128X2AdvSimdB64_X2      |  6040.894 |  6041.142 |  9015.116 |
| YGroup3ZipBenchmark_Int16   | Sum128X2AdvSimdB64_Unzip   |  7766.465 |  7764.095 |  7767.810 |
| YGroup3ZipBenchmark_Int16   | Sum128X2PackedSimd_X2      |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum128X2PackedSimd_Unzip   |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum128X2Sse_X2             |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum128X2Sse_Unzip          |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum128X2Traits             |  7768.063 |  7766.396 |  7767.988 |
| YGroup3ZipBenchmark_Int16   | Sum256Base_Basic           |   366.913 |   375.269 |   886.255 |
| YGroup3ZipBenchmark_Int16   | Sum256Base_ByShorter       |           |   346.911 |  3270.281 |
| YGroup3ZipBenchmark_Int16   | Sum256Base_ByX2Unzip       |           |    62.466 |   112.923 |
| YGroup3ZipBenchmark_Int16   | Sum256Base                 |   367.247 |   337.777 |  3270.702 |
| YGroup3ZipBenchmark_Int16   | Sum256Avx2_ByShorter       |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum256Avx2_ByX2Unzip       |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum256Avx2_Shuffle         |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum256Avx2_ShuffleX        |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum256Traits               |   348.056 |   337.836 |  3270.826 |
| YGroup3ZipBenchmark_Int16   | Sum256X2Base_Basic         |   333.266 |   326.167 |   858.258 |
| YGroup3ZipBenchmark_Int16   | Sum256X2Base_X2            |   327.036 |   188.732 |  3307.489 |
| YGroup3ZipBenchmark_Int16   | Sum256X2Base_Unzip         |           |   100.567 |   224.639 |
| YGroup3ZipBenchmark_Int16   | Sum256X2Base               |   326.960 |   150.530 |  3307.569 |
| YGroup3ZipBenchmark_Int16   | Sum256X2Avx2_X2            |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum256X2Avx2_Unzip         |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum256X2Traits             |   262.825 |   146.713 |  3308.010 |
| YGroup3ZipBenchmark_Int16   | Sum512Base_Basic           |           |           |   843.205 |
| YGroup3ZipBenchmark_Int16   | Sum512Base_ByShorter       |           |           |  3208.307 |
| YGroup3ZipBenchmark_Int16   | Sum512Base_ByX2Unzip       |           |           |    85.117 |
| YGroup3ZipBenchmark_Int16   | Sum512Base                 |           |           |  3208.536 |
| YGroup3ZipBenchmark_Int16   | Sum512Avx512_ByShorter     |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum512Avx512_ByX2Unzip     |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum512Avx512_ShuffleX      |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum512Traits               |           |           |  3208.715 |
| YGroup3ZipBenchmark_Int16   | Sum512X2Base_Basic         |           |           |   803.179 |
| YGroup3ZipBenchmark_Int16   | Sum512X2Base_X2            |           |           |   912.388 |
| YGroup3ZipBenchmark_Int16   | Sum512X2Base_Unzip         |           |           |   150.389 |
| YGroup3ZipBenchmark_Int16   | Sum512X2Base               |           |           |   911.361 |
| YGroup3ZipBenchmark_Int16   | Sum512X2Avx512_X2          |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum512X2Avx512_Unzip       |           |           |           |
| YGroup3ZipBenchmark_Int16   | Sum512X2Traits             |           |           |   910.695 |
| YGroup3ZipBenchmark_Int32   | SumBase_Basic              |   552.214 |   728.866 |   658.592 |
| YGroup3ZipBenchmark_Int32   | SumBase_ByX2Unzip          |   223.067 |  1167.448 |  1192.594 |
| YGroup3ZipBenchmark_Int32   | SumBase                    |   552.447 |  1167.468 |  1192.580 |
| YGroup3ZipBenchmark_Int32   | SumTraits                  |  3885.942 |  3884.575 |  5088.520 |
| YGroup3ZipBenchmark_Int32   | SumX2Base_Basic            |   546.482 |   705.142 |   652.094 |
| YGroup3ZipBenchmark_Int32   | SumX2Base_X2               |   546.473 |  1206.342 |  1193.672 |
| YGroup3ZipBenchmark_Int32   | SumX2Base_Unzip            |   353.227 |  1779.481 |  1763.075 |
| YGroup3ZipBenchmark_Int32   | SumX2Base                  |   546.405 |  1739.061 |  1762.898 |
| YGroup3ZipBenchmark_Int32   | SumX2Traits                |  4943.916 |  4943.499 |  4944.259 |
| YGroup3ZipBenchmark_Int32   | Sum128Base_Basic           |   339.580 |   728.910 |   658.699 |
| YGroup3ZipBenchmark_Int32   | Sum128Base_ByX2Unzip       |           |  1467.553 |  1693.913 |
| YGroup3ZipBenchmark_Int32   | Sum128Base                 |   339.690 |  1467.706 |  1693.825 |
| YGroup3ZipBenchmark_Int32   | Sum128AdvSimd_ByX2Unzip    |  1467.851 |  1467.673 |  1693.692 |
| YGroup3ZipBenchmark_Int32   | Sum128AdvSimd_Shuffle      |  1182.775 |  1198.994 |  1199.872 |
| YGroup3ZipBenchmark_Int32   | Sum128AdvSimd_ShuffleX     |           |           |  2439.010 |
| YGroup3ZipBenchmark_Int32   | Sum128AdvSimdB64_ByX2Unzip |  3885.661 |  3885.788 |  3885.012 |
| YGroup3ZipBenchmark_Int32   | Sum128AdvSimdB64_Shuffle   |  3021.583 |  3021.554 |  3022.295 |
| YGroup3ZipBenchmark_Int32   | Sum128AdvSimdB64_ShuffleX  |           |           |  5122.031 |
| YGroup3ZipBenchmark_Int32   | Sum128PackedSimd_ByX2Unzip |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum128PackedSimd_Shuffle   |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum128Sse_ByX2Unzip        |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum128Sse_Shuffle          |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum128Sse_ShuffleX         |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum128Sse_ShuffleXImm      |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum128Traits               |  3885.360 |  3885.026 |  5122.091 |
| YGroup3ZipBenchmark_Int32   | Sum128X2Base_Basic         |   334.741 |   706.739 |   652.103 |
| YGroup3ZipBenchmark_Int32   | Sum128X2Base_X2            |   335.093 |  1507.254 |  1811.181 |
| YGroup3ZipBenchmark_Int32   | Sum128X2Base_Unzip         |           |  2006.190 |  2159.996 |
| YGroup3ZipBenchmark_Int32   | Sum128X2Base               |   335.071 |  2006.885 |  2159.740 |
| YGroup3ZipBenchmark_Int32   | Sum128X2AdvSimd_X2         |  1497.175 |  1507.411 |  2261.890 |
| YGroup3ZipBenchmark_Int32   | Sum128X2AdvSimd_Unzip      |  2007.951 |  2007.676 |  2160.596 |
| YGroup3ZipBenchmark_Int32   | Sum128X2AdvSimdB64_X2      |  3885.658 |  3885.100 |  4524.558 |
| YGroup3ZipBenchmark_Int32   | Sum128X2AdvSimdB64_Unzip   |  4943.142 |  4943.649 |  4944.155 |
| YGroup3ZipBenchmark_Int32   | Sum128X2PackedSimd_X2      |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum128X2PackedSimd_Unzip   |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum128X2Sse_X2             |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum128X2Sse_Unzip          |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum128X2Traits             |  4943.922 |  4943.650 |  4945.197 |
| YGroup3ZipBenchmark_Int32   | Sum256Base_Basic           |   253.715 |   265.940 |   746.065 |
| YGroup3ZipBenchmark_Int32   | Sum256Base_ByShorter       |           |   237.243 |  2251.488 |
| YGroup3ZipBenchmark_Int32   | Sum256Base_ByX2Unzip       |           |    52.006 |   110.923 |
| YGroup3ZipBenchmark_Int32   | Sum256Base                 |   254.912 |   229.555 |  2250.908 |
| YGroup3ZipBenchmark_Int32   | Sum256Avx2_ByShorter       |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum256Avx2_ByX2Unzip       |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum256Avx2_Shuffle         |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum256Avx2_ShuffleX        |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum256Avx2_ShuffleXImm     |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum256Traits               |   254.183 |   229.859 |  2251.102 |
| YGroup3ZipBenchmark_Int32   | Sum256X2Base_Basic         |   225.349 |   238.899 |   705.917 |
| YGroup3ZipBenchmark_Int32   | Sum256X2Base_X2            |   226.497 |   244.953 |  2290.021 |
| YGroup3ZipBenchmark_Int32   | Sum256X2Base_Unzip         |           |    92.577 |   221.316 |
| YGroup3ZipBenchmark_Int32   | Sum256X2Base               |   219.676 |   243.696 |  2289.858 |
| YGroup3ZipBenchmark_Int32   | Sum256X2Avx2_X2            |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum256X2Avx2_Unzip         |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum256X2Traits             |   163.993 |   244.951 |  2290.161 |
| YGroup3ZipBenchmark_Int32   | Sum512Base_Basic           |           |           |   677.229 |
| YGroup3ZipBenchmark_Int32   | Sum512Base_ByShorter       |           |           |  2207.185 |
| YGroup3ZipBenchmark_Int32   | Sum512Base_ByX2Unzip       |           |           |    65.112 |
| YGroup3ZipBenchmark_Int32   | Sum512Base                 |           |           |  2207.121 |
| YGroup3ZipBenchmark_Int32   | Sum512Avx512_ByShorter     |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum512Avx512_ByX2Unzip     |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum512Avx512_ShuffleX      |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum512Avx512_ShuffleXImm   |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum512Traits               |           |           |  2206.986 |
| YGroup3ZipBenchmark_Int32   | Sum512X2Base_Basic         |           |           |   623.640 |
| YGroup3ZipBenchmark_Int32   | Sum512X2Base_X2            |           |           |   487.217 |
| YGroup3ZipBenchmark_Int32   | Sum512X2Base_Unzip         |           |           |   163.885 |
| YGroup3ZipBenchmark_Int32   | Sum512X2Base               |           |           |   487.145 |
| YGroup3ZipBenchmark_Int32   | Sum512X2Avx512_X2          |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum512X2Avx512_Unzip       |           |           |           |
| YGroup3ZipBenchmark_Int32   | Sum512X2Traits             |           |           |   486.740 |
| YGroup3ZipBenchmark_Int64   | SumBase_Basic              |   542.991 |   559.361 |   559.150 |
| YGroup3ZipBenchmark_Int64   | SumBase                    |   542.984 |   559.069 |   559.062 |
| YGroup3ZipBenchmark_Int64   | SumTraits                  |  3368.200 |  3376.557 |  3389.829 |
| YGroup3ZipBenchmark_Int64   | SumX2Base_Basic            |   336.539 |   335.202 |   337.937 |
| YGroup3ZipBenchmark_Int64   | SumX2Base_X2               |   336.160 |   335.410 |   338.538 |
| YGroup3ZipBenchmark_Int64   | SumX2Base                  |   336.373 |   335.192 |   338.644 |
| YGroup3ZipBenchmark_Int64   | SumX2Traits                |  3399.234 |  3399.733 |  4186.011 |
| YGroup3ZipBenchmark_Int64   | Sum128Base_Basic           |   253.477 |   558.547 |   558.475 |
| YGroup3ZipBenchmark_Int64   | Sum128Base_Move            |   433.648 |  2862.948 |  3367.047 |
| YGroup3ZipBenchmark_Int64   | Sum128Base                 |   433.815 |  2863.199 |  3367.850 |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimd_AlignRight   |  3368.442 |  3375.937 |  3390.246 |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimd_ByX2Unzip    |  1511.403 |  1511.217 |  1700.799 |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimd_Shuffle      |   899.331 |   900.790 |   900.915 |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimd_ShuffleX     |           |           |  1686.496 |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimdB64_ByX2Unzip |  2863.441 |  3199.303 |  3200.906 |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimdB64_Shuffle   |  2266.506 |  2265.527 |  2264.357 |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimdB64_ShuffleX  |           |           |  3200.672 |
| YGroup3ZipBenchmark_Int64   | Sum128PackedSimd_ByX2Unzip |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128PackedSimd_Shuffle   |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128Sse_ByX2Unzip        |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128Sse_Shuffle          |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128Sse_ShuffleX         |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128Sse_ShuffleXImm      |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128Traits               |  3369.193 |  3375.419 |  3390.257 |
| YGroup3ZipBenchmark_Int64   | Sum128X2Base_Basic         |   266.756 |   336.746 |   337.834 |
| YGroup3ZipBenchmark_Int64   | Sum128X2Base_X2            |   661.048 |  2954.673 |  4417.453 |
| YGroup3ZipBenchmark_Int64   | Sum128X2Base               |   661.079 |  2959.227 |  4417.922 |
| YGroup3ZipBenchmark_Int64   | Sum128X2AdvSimd_X2         |  3398.285 |  3400.098 |  4186.035 |
| YGroup3ZipBenchmark_Int64   | Sum128X2AdvSimd_Unzip      |  2265.330 |  2265.484 |  2365.526 |
| YGroup3ZipBenchmark_Int64   | Sum128X2AdvSimdB64_X2      |  3398.990 |  3399.610 |  4184.568 |
| YGroup3ZipBenchmark_Int64   | Sum128X2AdvSimdB64_Unzip   |  3397.491 |  3399.007 |  3400.065 |
| YGroup3ZipBenchmark_Int64   | Sum128X2PackedSimd_X2      |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128X2PackedSimd_Unzip   |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128X2Sse_X2             |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128X2Sse_Unzip          |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum128X2Traits             |  3399.650 |  3399.222 |  4184.004 |
| YGroup3ZipBenchmark_Int64   | Sum256Base_Basic           |   148.811 |   163.245 |   488.763 |
| YGroup3ZipBenchmark_Int64   | Sum256Base_ByShorter       |           |   161.749 |  4474.149 |
| YGroup3ZipBenchmark_Int64   | Sum256Base                 |   149.266 |   163.203 |   485.277 |
| YGroup3ZipBenchmark_Int64   | Sum256Avx2_ByShorter       |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum256Avx2_ByX2Unzip       |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum256Avx2_Shuffle         |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum256Avx2_ShuffleX        |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum256Avx2_ShuffleXImm     |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum256Traits               |   149.316 |   163.274 |   485.654 |
| YGroup3ZipBenchmark_Int64   | Sum256X2Base_Basic         |   143.976 |   150.250 |   423.218 |
| YGroup3ZipBenchmark_Int64   | Sum256X2Base_X2            |   137.174 |   149.922 |   423.584 |
| YGroup3ZipBenchmark_Int64   | Sum256X2Base               |   132.642 |   147.767 |   422.748 |
| YGroup3ZipBenchmark_Int64   | Sum256X2Avx2_X2            |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum256X2Avx2_Unzip         |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum256X2Traits             |    94.735 |   150.388 |   423.135 |
| YGroup3ZipBenchmark_Int64   | Sum512Base_Basic           |           |           |   417.987 |
| YGroup3ZipBenchmark_Int64   | Sum512Base_ByShorter       |           |           |   423.305 |
| YGroup3ZipBenchmark_Int64   | Sum512Base                 |           |           |   419.185 |
| YGroup3ZipBenchmark_Int64   | Sum512Avx512_ByShorter     |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum512Avx512_ByX2Unzip     |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum512Avx512_ShuffleX      |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum512Avx512_ShuffleXImm   |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum512Traits               |           |           |   417.734 |
| YGroup3ZipBenchmark_Int64   | Sum512X2Base_Basic         |           |           |   375.035 |
| YGroup3ZipBenchmark_Int64   | Sum512X2Base_X2            |           |           |   373.453 |
| YGroup3ZipBenchmark_Int64   | Sum512X2Base               |           |           |   373.442 |
| YGroup3ZipBenchmark_Int64   | Sum512X2Avx512_X2          |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum512X2Avx512_Unzip       |           |           |           |
| YGroup3ZipBenchmark_Int64   | Sum512X2Traits             |           |           |   373.752 |

### Arm - AWS Arm t4g.small
| Type                        | Method                     | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 | .NET 8.0 |
| :-------------------------- | :------------------------- | ------------: | -------: | -------: | -------: | -------: |
| YGroup3UnzipBenchmark_Byte  | SumBase_Basic              |       263.957 |          |  265.524 |  327.819 |  381.159 |
| YGroup3UnzipBenchmark_Byte  | SumBase_ByX2Zip            |       378.953 |          |  406.233 |  428.947 |  443.805 |
| YGroup3UnzipBenchmark_Byte  | SumBase                    |       380.369 |          |  406.259 |  430.545 |  443.813 |
| YGroup3UnzipBenchmark_Byte  | SumTraits                  |       378.710 |          | 4381.575 | 4113.304 | 6510.157 |
| YGroup3UnzipBenchmark_Byte  | SumX2Base_Basic            |       252.875 |          |  263.433 |  323.818 |  384.006 |
| YGroup3UnzipBenchmark_Byte  | SumX2Base_X2               |       232.627 |          |  309.615 |  420.801 |  434.708 |
| YGroup3UnzipBenchmark_Byte  | SumX2Base_Zip              |       702.437 |          |  727.523 |  740.625 |  768.555 |
| YGroup3UnzipBenchmark_Byte  | SumX2Base                  |       702.851 |          |  728.691 |  740.690 |  767.491 |
| YGroup3UnzipBenchmark_Byte  | SumX2Traits                |       700.539 |          | 4412.785 | 4273.763 | 5294.112 |
| YGroup3UnzipBenchmark_Byte  | Sum128Base_Basic           |       131.634 |          |  146.785 |  330.670 |  381.332 |
| YGroup3UnzipBenchmark_Byte  | Sum128Base_ByX2Zip         |               |          |          |   79.323 |  501.286 |
| YGroup3UnzipBenchmark_Byte  | Sum128Base                 |       131.695 |          |  146.165 |   79.561 |  501.248 |
| YGroup3UnzipBenchmark_Byte  | Sum128AdvSimd_ByX2Zip      |               |          |  466.160 |  469.870 |  509.146 |
| YGroup3UnzipBenchmark_Byte  | Sum128AdvSimd_Shuffle      |               |          | 1450.961 | 1736.461 | 1733.083 |
| YGroup3UnzipBenchmark_Byte  | Sum128AdvSimd_ShuffleX     |               |          |          |          | 2877.583 |
| YGroup3UnzipBenchmark_Byte  | Sum128AdvSimdB64_ByX2Zip   |               |          | 2644.745 | 2565.711 | 2607.146 |
| YGroup3UnzipBenchmark_Byte  | Sum128AdvSimdB64_Shuffle   |               |          | 4366.836 | 4274.400 | 4400.773 |
| YGroup3UnzipBenchmark_Byte  | Sum128AdvSimdB64_ShuffleX  |               |          |          |          | 6574.254 |
| YGroup3UnzipBenchmark_Byte  | Sum128PackedSimd_ByX2Zip   |               |          |          |          |          |
| YGroup3UnzipBenchmark_Byte  | Sum128PackedSimd_Shuffle   |               |          |          |          |          |
| YGroup3UnzipBenchmark_Byte  | Sum128Sse_ByX2Zip          |               |          |          |          |          |
| YGroup3UnzipBenchmark_Byte  | Sum128Sse_Shuffle          |               |          |          |          |          |
| YGroup3UnzipBenchmark_Byte  | Sum128Sse_ShuffleX         |               |          |          |          |          |
| YGroup3UnzipBenchmark_Byte  | Sum128Traits               |       131.795 |          | 3802.982 | 4198.067 | 6571.798 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Base_Basic         |       121.183 |          |  146.082 |  323.883 |  383.935 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Base_X2            |       119.899 |          |  145.389 |   71.185 |  347.964 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Base_Zip           |               |          |          |  160.195 |  846.745 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Base               |       114.766 |          |  145.803 |  159.139 |  845.281 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2AdvSimd_X2         |               |          | 1436.136 | 1696.752 | 2410.290 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2AdvSimd_Zip        |               |          |  821.086 |  824.813 |  846.723 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2AdvSimdB64_X2      |               |          | 3999.727 | 5021.327 | 5291.005 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2AdvSimdB64_Zip     |               |          | 4411.386 | 4224.854 | 4402.362 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2PackedSimd_X2      |               |          |          |          |          |
| YGroup3UnzipBenchmark_Byte  | Sum128X2PackedSimd_Zip     |               |          |          |          |          |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Sse_X2             |               |          |          |          |          |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Sse_Zip            |               |          |          |          |          |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Traits             |       127.435 |          | 4409.831 | 4286.813 | 5287.301 |
| YGroup3UnzipBenchmark_Byte  | Sum256Base_Basic           |       138.033 |          |  155.568 |  137.500 |  373.469 |
| YGroup3UnzipBenchmark_Byte  | Sum256Base_ByShorter       |               |          |          |   78.979 |  827.832 |
| YGroup3UnzipBenchmark_Byte  | Sum256Base_ByX2Zip         |               |          |          |   26.885 |   27.359 |
| YGroup3UnzipBenchmark_Byte  | Sum256Base                 |       136.217 |          |  155.550 |   78.552 |  827.835 |
| YGroup3UnzipBenchmark_Byte  | Sum256Avx2_ByShorter       |               |          |          |          |          |
| YGroup3UnzipBenchmark_Byte  | Sum256Avx2_ByX2Unpack      |               |          |          |          |          |
| YGroup3UnzipBenchmark_Byte  | Sum256Avx2_ByX2Zip         |               |          |          |          |          |
| YGroup3UnzipBenchmark_Byte  | Sum256Avx2_Shuffle         |               |          |          |          |          |
| YGroup3UnzipBenchmark_Byte  | Sum256Avx2_ShuffleX        |               |          |          |          |          |
| YGroup3UnzipBenchmark_Byte  | Sum256Traits               |       125.246 |          |  151.789 |   80.415 |  827.792 |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Base_Basic         |       127.922 |          |  103.744 |  135.890 |  369.927 |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Base_X2            |       133.050 |          |  102.912 |   41.259 |  540.055 |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Base_Zip           |               |          |          |   47.496 |   54.430 |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Base               |       131.520 |          |  100.468 |   41.652 |  539.465 |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Avx2_Unpack        |               |          |          |          |          |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Avx2_X2            |               |          |          |          |          |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Avx2_Zip           |               |          |          |          |          |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Traits             |       112.880 |          |   96.572 |   41.500 |  539.920 |
| YGroup3UnzipBenchmark_Byte  | Sum512Base_Basic           |               |          |          |          |  426.622 |
| YGroup3UnzipBenchmark_Byte  | Sum512Base_ByShorter       |               |          |          |          |  349.162 |
| YGroup3UnzipBenchmark_Byte  | Sum512Base_ByX2Zip         |               |          |          |          |   23.211 |
| YGroup3UnzipBenchmark_Byte  | Sum512Base                 |               |          |          |          |  350.404 |
| YGroup3UnzipBenchmark_Byte  | Sum512Avx512_ByShorter     |               |          |          |          |          |
| YGroup3UnzipBenchmark_Byte  | Sum512Avx512_ByX2Unpack    |               |          |          |          |          |
| YGroup3UnzipBenchmark_Byte  | Sum512Avx512_ByX2Zip       |               |          |          |          |          |
| YGroup3UnzipBenchmark_Byte  | Sum512Avx512_ShuffleX      |               |          |          |          |          |
| YGroup3UnzipBenchmark_Byte  | Sum512Traits               |               |          |          |          |  349.139 |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Base_Basic         |               |          |          |          |  424.822 |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Base_X2            |               |          |          |          |  334.233 |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Base_Zip           |               |          |          |          |   46.131 |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Base               |               |          |          |          |  332.750 |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Avx512_Unpack      |               |          |          |          |          |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Avx512_X2          |               |          |          |          |          |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Avx512_Zip         |               |          |          |          |          |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Traits             |               |          |          |          |  326.177 |
| YGroup3UnzipBenchmark_Int16 | SumBase_Basic              |       188.885 |          |  189.823 |  222.856 |  279.398 |
| YGroup3UnzipBenchmark_Int16 | SumBase_ByX2Zip            |       218.311 |          |  227.460 |  234.918 |  231.692 |
| YGroup3UnzipBenchmark_Int16 | SumBase                    |       213.360 |          |  228.410 |  235.157 |  242.377 |
| YGroup3UnzipBenchmark_Int16 | SumTraits                  |       213.356 |          | 1926.559 | 2134.925 | 3037.124 |
| YGroup3UnzipBenchmark_Int16 | SumX2Base_Basic            |       161.593 |          |  181.518 |  214.529 |  286.873 |
| YGroup3UnzipBenchmark_Int16 | SumX2Base_X2               |       126.923 |          |  149.964 |  235.483 |  238.187 |
| YGroup3UnzipBenchmark_Int16 | SumX2Base_Zip              |       419.448 |          |  443.616 |  465.816 |  475.439 |
| YGroup3UnzipBenchmark_Int16 | SumX2Base                  |       419.434 |          |  448.638 |  466.043 |  475.565 |
| YGroup3UnzipBenchmark_Int16 | SumX2Traits                |       419.442 |          | 2413.794 | 2650.031 | 2638.161 |
| YGroup3UnzipBenchmark_Int16 | Sum128Base_Basic           |        95.476 |          |  100.564 |  222.966 |  279.380 |
| YGroup3UnzipBenchmark_Int16 | Sum128Base_ByX2Zip         |               |          |          |   50.534 |  331.991 |
| YGroup3UnzipBenchmark_Int16 | Sum128Base                 |        96.052 |          |  100.448 |   50.558 |  332.364 |
| YGroup3UnzipBenchmark_Int16 | Sum128AdvSimd_ByX2Zip      |               |          |  307.836 |  308.507 |  338.176 |
| YGroup3UnzipBenchmark_Int16 | Sum128AdvSimd_Shuffle      |               |          |  713.705 |  876.993 |  857.804 |
| YGroup3UnzipBenchmark_Int16 | Sum128AdvSimd_ShuffleX     |               |          |          |          | 1399.104 |
| YGroup3UnzipBenchmark_Int16 | Sum128AdvSimdB64_ByX2Zip   |               |          | 1605.306 | 1655.024 | 1609.517 |
| YGroup3UnzipBenchmark_Int16 | Sum128AdvSimdB64_Shuffle   |               |          | 1898.455 | 2114.808 | 2105.378 |
| YGroup3UnzipBenchmark_Int16 | Sum128AdvSimdB64_ShuffleX  |               |          |          |          | 3040.514 |
| YGroup3UnzipBenchmark_Int16 | Sum128PackedSimd_ByX2Zip   |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int16 | Sum128PackedSimd_Shuffle   |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int16 | Sum128Sse_ByX2Zip          |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int16 | Sum128Sse_Shuffle          |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int16 | Sum128Sse_ShuffleX         |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int16 | Sum128Traits               |        96.013 |          | 1854.707 | 2143.085 | 3042.605 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Base_Basic         |        89.869 |          |   98.361 |  214.330 |  286.747 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Base_X2            |        89.697 |          |   98.194 |   46.587 |  333.277 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Base_Zip           |               |          |          |  100.694 |  534.276 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Base               |        89.738 |          |   97.585 |  100.895 |  534.270 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2AdvSimd_X2         |               |          |  731.062 |  858.713 | 1203.667 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2AdvSimd_Zip        |               |          |  518.343 |  523.680 |  545.213 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2AdvSimdB64_X2      |               |          | 1990.631 | 2575.042 | 2636.632 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2AdvSimdB64_Zip     |               |          | 2533.407 | 2652.346 | 2622.574 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2PackedSimd_X2      |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int16 | Sum128X2PackedSimd_Zip     |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Sse_X2             |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Sse_Zip            |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Traits             |        90.154 |          | 2388.419 | 2650.338 | 2637.050 |
| YGroup3UnzipBenchmark_Int16 | Sum256Base_Basic           |        89.459 |          |  112.679 |   99.894 |  258.326 |
| YGroup3UnzipBenchmark_Int16 | Sum256Base_ByShorter       |               |          |          |   52.503 |  518.770 |
| YGroup3UnzipBenchmark_Int16 | Sum256Base_ByX2Zip         |               |          |          |   25.466 |   28.071 |
| YGroup3UnzipBenchmark_Int16 | Sum256Base                 |        87.932 |          |  113.862 |   51.688 |  518.788 |
| YGroup3UnzipBenchmark_Int16 | Sum256Avx2_ByShorter       |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int16 | Sum256Avx2_ByX2Unpack      |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int16 | Sum256Avx2_ByX2Zip         |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int16 | Sum256Avx2_Shuffle         |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int16 | Sum256Avx2_ShuffleX        |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int16 | Sum256Traits               |        78.977 |          |  113.670 |   52.395 |  518.864 |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Base_Basic         |        74.860 |          |  102.791 |  101.489 |  254.799 |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Base_X2            |        76.956 |          |  105.079 |   30.853 |  311.112 |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Base_Zip           |               |          |          |   43.005 |   55.998 |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Base               |        74.522 |          |  105.638 |   30.430 |  303.600 |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Avx2_Unpack        |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Avx2_X2            |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Avx2_Zip           |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Traits             |        67.279 |          |   97.223 |   31.091 |  304.101 |
| YGroup3UnzipBenchmark_Int16 | Sum512Base_Basic           |               |          |          |          |  333.501 |
| YGroup3UnzipBenchmark_Int16 | Sum512Base_ByShorter       |               |          |          |          |  194.426 |
| YGroup3UnzipBenchmark_Int16 | Sum512Base_ByX2Zip         |               |          |          |          |   23.617 |
| YGroup3UnzipBenchmark_Int16 | Sum512Base                 |               |          |          |          |  192.855 |
| YGroup3UnzipBenchmark_Int16 | Sum512Avx512_ByShorter     |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int16 | Sum512Avx512_ByX2Unpack    |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int16 | Sum512Avx512_ByX2Zip       |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int16 | Sum512Avx512_ShuffleX      |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int16 | Sum512Traits               |               |          |          |          |  200.558 |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Base_Basic         |               |          |          |          |  317.485 |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Base_X2            |               |          |          |          |  188.159 |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Base_Zip           |               |          |          |          |   46.979 |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Base               |               |          |          |          |  190.555 |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Avx512_Unpack      |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Avx512_X2          |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Avx512_Zip         |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Traits             |               |          |          |          |  185.200 |
| YGroup3UnzipBenchmark_Int32 | SumBase_Basic              |       138.088 |          |  143.089 |  154.241 |  196.818 |
| YGroup3UnzipBenchmark_Int32 | SumBase_ByX2Zip            |        31.443 |          |   27.747 |  186.781 |  198.155 |
| YGroup3UnzipBenchmark_Int32 | SumBase                    |       141.071 |          |  143.390 |  186.784 |  198.177 |
| YGroup3UnzipBenchmark_Int32 | SumTraits                  |       144.696 |          | 1033.899 | 1069.974 | 1494.205 |
| YGroup3UnzipBenchmark_Int32 | SumX2Base_Basic            |       121.363 |          |  136.659 |  143.233 |  202.934 |
| YGroup3UnzipBenchmark_Int32 | SumX2Base_X2               |       120.826 |          |  136.747 |  183.979 |  191.928 |
| YGroup3UnzipBenchmark_Int32 | SumX2Base_Zip              |        57.689 |          |   53.149 |  288.752 |  310.944 |
| YGroup3UnzipBenchmark_Int32 | SumX2Base                  |       121.726 |          |  138.986 |  275.479 |  310.983 |
| YGroup3UnzipBenchmark_Int32 | SumX2Traits                |       119.468 |          | 1598.185 | 1547.795 | 1618.239 |
| YGroup3UnzipBenchmark_Int32 | Sum128Base_Basic           |        68.563 |          |   70.344 |  141.432 |  196.941 |
| YGroup3UnzipBenchmark_Int32 | Sum128Base_ByX2Zip         |               |          |          |   33.933 |  245.573 |
| YGroup3UnzipBenchmark_Int32 | Sum128Base                 |        68.192 |          |   70.565 |   33.024 |  245.598 |
| YGroup3UnzipBenchmark_Int32 | Sum128AdvSimd_ByX2Zip      |               |          |  225.475 |  208.069 |  252.131 |
| YGroup3UnzipBenchmark_Int32 | Sum128AdvSimd_Shuffle      |               |          |  360.794 |  413.520 |  430.231 |
| YGroup3UnzipBenchmark_Int32 | Sum128AdvSimd_ShuffleX     |               |          |          |          |  694.937 |
| YGroup3UnzipBenchmark_Int32 | Sum128AdvSimdB64_ByX2Zip   |               |          | 1065.250 | 1045.542 | 1077.152 |
| YGroup3UnzipBenchmark_Int32 | Sum128AdvSimdB64_Shuffle   |               |          |  951.261 |  977.921 | 1053.081 |
| YGroup3UnzipBenchmark_Int32 | Sum128AdvSimdB64_ShuffleX  |               |          |          |          | 1488.770 |
| YGroup3UnzipBenchmark_Int32 | Sum128PackedSimd_ByX2Zip   |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum128PackedSimd_Shuffle   |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum128Sse_ByX2Zip          |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum128Sse_Shuffle          |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum128Sse_ShuffleX         |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum128Sse_ShuffleXImm      |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum128Traits               |        66.170 |          |  889.607 |  995.229 | 1503.290 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Base_Basic         |        60.686 |          |   66.510 |  138.874 |  202.936 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Base_X2            |        61.119 |          |   65.963 |   29.230 |  251.186 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Base_Zip           |               |          |          |   64.107 |  361.603 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Base               |        61.235 |          |   66.065 |   63.952 |  361.638 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2AdvSimd_X2         |               |          |  358.929 |  406.442 |  602.937 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2AdvSimd_Zip        |               |          |  349.839 |  331.569 |  371.757 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2AdvSimdB64_X2      |               |          |  956.001 | 1194.979 | 1324.637 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2AdvSimdB64_Zip     |               |          | 1594.783 | 1530.957 | 1617.714 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2PackedSimd_X2      |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum128X2PackedSimd_Zip     |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Sse_X2             |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Sse_Zip            |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Traits             |        61.083 |          | 1588.753 | 1563.293 | 1617.993 |
| YGroup3UnzipBenchmark_Int32 | Sum256Base_Basic           |        58.771 |          |   75.211 |   71.748 |  274.635 |
| YGroup3UnzipBenchmark_Int32 | Sum256Base_ByShorter       |               |          |          |   32.518 |  347.713 |
| YGroup3UnzipBenchmark_Int32 | Sum256Base_ByX2Zip         |               |          |          |   22.939 |   27.807 |
| YGroup3UnzipBenchmark_Int32 | Sum256Base                 |        57.173 |          |   75.171 |   31.852 |  347.714 |
| YGroup3UnzipBenchmark_Int32 | Sum256Avx2_ByShorter       |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum256Avx2_ByX2Unpack      |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum256Avx2_ByX2Zip         |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum256Avx2_Shuffle         |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum256Avx2_ShuffleX        |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum256Avx2_ShuffleXImm     |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum256Traits               |        50.266 |          |   75.562 |   31.698 |  347.720 |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Base_Basic         |        54.765 |          |   70.546 |   74.649 |  273.105 |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Base_X2            |        52.420 |          |   70.909 |   21.559 |  364.250 |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Base_Zip           |               |          |          |   36.717 |   55.367 |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Base               |        50.393 |          |   70.723 |   21.264 |  363.822 |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Avx2_Unpack        |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Avx2_X2            |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Avx2_Zip           |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Traits             |        41.045 |          |   65.204 |   21.686 |  364.562 |
| YGroup3UnzipBenchmark_Int32 | Sum512Base_Basic           |               |          |          |          |  293.807 |
| YGroup3UnzipBenchmark_Int32 | Sum512Base_ByShorter       |               |          |          |          |  221.049 |
| YGroup3UnzipBenchmark_Int32 | Sum512Base_ByX2Zip         |               |          |          |          |   23.847 |
| YGroup3UnzipBenchmark_Int32 | Sum512Base                 |               |          |          |          |  220.126 |
| YGroup3UnzipBenchmark_Int32 | Sum512Avx512_ByShorter     |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum512Avx512_ByX2Unpack    |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum512Avx512_ByX2Zip       |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum512Avx512_ShuffleX      |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum512Avx512_ShuffleXImm   |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum512Traits               |               |          |          |          |  250.125 |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Base_Basic         |               |          |          |          |  269.514 |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Base_X2            |               |          |          |          |  134.752 |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Base_Zip           |               |          |          |          |   46.887 |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Base               |               |          |          |          |  135.148 |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Avx512_Unpack      |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Avx512_X2          |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Avx512_Zip         |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Traits             |               |          |          |          |  134.354 |
| YGroup3UnzipBenchmark_Int64 | SumBase_Basic              |       109.766 |          |  100.523 |   84.039 |  189.270 |
| YGroup3UnzipBenchmark_Int64 | SumBase                    |       109.531 |          |  102.084 |   81.358 |  185.056 |
| YGroup3UnzipBenchmark_Int64 | SumTraits                  |       107.335 |          | 1153.333 | 1176.315 | 1191.362 |
| YGroup3UnzipBenchmark_Int64 | SumX2Base_Basic            |        98.801 |          |   96.133 |   77.676 |  205.344 |
| YGroup3UnzipBenchmark_Int64 | SumX2Base_X2               |        98.072 |          |   95.820 |   78.541 |  204.436 |
| YGroup3UnzipBenchmark_Int64 | SumX2Base                  |        97.857 |          |   96.111 |   79.729 |  203.008 |
| YGroup3UnzipBenchmark_Int64 | SumX2Traits                |        98.162 |          | 1216.716 | 1155.302 | 1374.619 |
| YGroup3UnzipBenchmark_Int64 | Sum128Base_Basic           |        69.813 |          |   71.621 |   82.620 |  187.458 |
| YGroup3UnzipBenchmark_Int64 | Sum128Base_Move            |        80.261 |          |  166.038 |  841.657 | 1154.172 |
| YGroup3UnzipBenchmark_Int64 | Sum128Base                 |        69.066 |          |  166.944 |  834.664 | 1155.226 |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimd_AlignRight   |               |          | 1152.365 | 1138.378 | 1191.945 |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimd_ByX2Zip      |               |          |  524.286 |  511.046 |  534.878 |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimd_Shuffle      |               |          |  253.229 |  308.856 |  315.772 |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimd_ShuffleX     |               |          |          |          |  481.027 |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimdB64_ByX2Zip   |               |          |  798.432 |  816.593 |  811.510 |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimdB64_Shuffle   |               |          |  737.702 |  757.700 |  778.877 |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimdB64_ShuffleX  |               |          |          |          | 1004.493 |
| YGroup3UnzipBenchmark_Int64 | Sum128PackedSimd_ByX2Zip   |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum128PackedSimd_Shuffle   |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum128Sse_ByX2Zip          |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum128Sse_Shuffle          |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum128Sse_ShuffleX         |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum128Sse_ShuffleXImm      |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum128Traits               |        67.097 |          | 1153.024 | 1142.184 | 1192.927 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2Base_Basic         |        57.617 |          |   64.031 |   79.994 |  205.325 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2Base_X2            |        57.903 |          |  173.670 |  867.383 | 1232.585 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2Base               |        57.869 |          |  173.267 |  851.346 | 1231.044 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2AdvSimd_X2         |               |          | 1219.580 | 1202.334 | 1374.357 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2AdvSimd_Zip        |               |          |  731.911 |  749.634 |  770.567 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2AdvSimdB64_X2      |               |          | 1218.246 | 1177.631 | 1375.124 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2AdvSimdB64_Zip     |               |          | 1077.632 | 1050.372 | 1098.099 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2PackedSimd_X2      |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum128X2PackedSimd_Zip     |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum128X2Sse_X2             |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum128X2Sse_Zip            |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum128X2Traits             |        57.852 |          | 1218.601 | 1191.777 | 1374.223 |
| YGroup3UnzipBenchmark_Int64 | Sum256Base_Basic           |        38.124 |          |   57.126 |   54.482 |  217.626 |
| YGroup3UnzipBenchmark_Int64 | Sum256Base_ByShorter       |               |          |          |   60.717 | 1310.765 |
| YGroup3UnzipBenchmark_Int64 | Sum256Base                 |        37.066 |          |   57.038 |   54.263 |  206.663 |
| YGroup3UnzipBenchmark_Int64 | Sum256Avx2_ByShorter       |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum256Avx2_ByX2Unpack      |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum256Avx2_ByX2Zip         |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum256Avx2_Shuffle         |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum256Avx2_ShuffleX        |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum256Avx2_ShuffleXImm     |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum256Traits               |        31.180 |          |   56.963 |   53.783 |  220.571 |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Base_Basic         |        34.789 |          |   50.775 |   55.841 |  208.517 |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Base_X2            |        33.230 |          |   49.674 |   55.545 |  206.667 |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Base               |        31.797 |          |   48.631 |   54.340 |  205.329 |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Avx2_Unpack        |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Avx2_X2            |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Avx2_Zip           |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Traits             |        24.519 |          |   49.542 |   56.839 |  211.335 |
| YGroup3UnzipBenchmark_Int64 | Sum512Base_Basic           |               |          |          |          |  208.628 |
| YGroup3UnzipBenchmark_Int64 | Sum512Base_ByShorter       |               |          |          |          |  211.410 |
| YGroup3UnzipBenchmark_Int64 | Sum512Base                 |               |          |          |          |  208.622 |
| YGroup3UnzipBenchmark_Int64 | Sum512Avx512_ByShorter     |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum512Avx512_ByX2Unpack    |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum512Avx512_ByX2Zip       |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum512Avx512_ShuffleX      |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum512Avx512_ShuffleXImm   |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum512Traits               |               |          |          |          |  208.609 |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Base_Basic         |               |          |          |          |  189.150 |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Base_X2            |               |          |          |          |  189.014 |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Base               |               |          |          |          |  189.107 |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Avx512_Unpack      |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Avx512_X2          |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Avx512_Zip         |               |          |          |          |          |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Traits             |               |          |          |          |  189.094 |
| YGroup3ZipBenchmark_Byte    | SumBase_Basic              |       277.096 |          |  281.447 |  408.006 |  334.832 |
| YGroup3ZipBenchmark_Byte    | SumBase_ByX2Unzip          |       150.150 |          |  171.221 |  791.722 |  787.172 |
| YGroup3ZipBenchmark_Byte    | SumBase                    |       277.206 |          |  281.101 |  779.019 |  786.843 |
| YGroup3ZipBenchmark_Byte    | SumTraits                  |       276.877 |          | 3952.702 | 4015.509 | 6498.419 |
| YGroup3ZipBenchmark_Byte    | SumX2Base_Basic            |       272.850 |          |  281.048 |  405.724 |  333.985 |
| YGroup3ZipBenchmark_Byte    | SumX2Base_X2               |       271.176 |          |  280.423 |  788.199 |  803.744 |
| YGroup3ZipBenchmark_Byte    | SumX2Base_Unzip            |       241.724 |          |  275.013 | 1339.994 | 1374.895 |
| YGroup3ZipBenchmark_Byte    | SumX2Base                  |       242.179 |          |  275.444 | 1290.483 | 1375.898 |
| YGroup3ZipBenchmark_Byte    | SumX2Traits                |       241.586 |          | 4410.979 | 4079.757 | 4416.939 |
| YGroup3ZipBenchmark_Byte    | Sum128Base_Basic           |       154.753 |          |  155.391 |  394.512 |  334.831 |
| YGroup3ZipBenchmark_Byte    | Sum128Base_ByX2Unzip       |               |          |          | 1004.958 | 1083.727 |
| YGroup3ZipBenchmark_Byte    | Sum128Base                 |       154.831 |          |  155.403 |  988.985 | 1083.750 |
| YGroup3ZipBenchmark_Byte    | Sum128AdvSimd_ByX2Unzip    |               |          |  976.587 |  988.393 | 1083.835 |
| YGroup3ZipBenchmark_Byte    | Sum128AdvSimd_Shuffle      |               |          | 1435.989 | 1731.581 | 1733.510 |
| YGroup3ZipBenchmark_Byte    | Sum128AdvSimd_ShuffleX     |               |          |          |          | 2871.731 |
| YGroup3ZipBenchmark_Byte    | Sum128AdvSimdB64_ByX2Unzip |               |          | 2646.603 | 2485.167 | 2625.824 |
| YGroup3ZipBenchmark_Byte    | Sum128AdvSimdB64_Shuffle   |               |          | 4377.288 | 4020.240 | 4402.228 |
| YGroup3ZipBenchmark_Byte    | Sum128AdvSimdB64_ShuffleX  |               |          |          |          | 6573.892 |
| YGroup3ZipBenchmark_Byte    | Sum128PackedSimd_ByX2Unzip |               |          |          |          |          |
| YGroup3ZipBenchmark_Byte    | Sum128PackedSimd_Shuffle   |               |          |          |          |          |
| YGroup3ZipBenchmark_Byte    | Sum128Sse_ByX2Unzip        |               |          |          |          |          |
| YGroup3ZipBenchmark_Byte    | Sum128Sse_Shuffle          |               |          |          |          |          |
| YGroup3ZipBenchmark_Byte    | Sum128Sse_ShuffleX         |               |          |          |          |          |
| YGroup3ZipBenchmark_Byte    | Sum128Traits               |       154.753 |          | 3925.210 | 4138.803 | 6563.618 |
| YGroup3ZipBenchmark_Byte    | Sum128X2Base_Basic         |       151.271 |          |  154.417 |  393.153 |  334.070 |
| YGroup3ZipBenchmark_Byte    | Sum128X2Base_X2            |       150.802 |          |  153.209 |  991.997 | 1084.315 |
| YGroup3ZipBenchmark_Byte    | Sum128X2Base_Unzip         |               |          |          | 1590.004 | 1734.981 |
| YGroup3ZipBenchmark_Byte    | Sum128X2Base               |       152.550 |          |  153.194 | 1604.132 | 1731.552 |
| YGroup3ZipBenchmark_Byte    | Sum128X2AdvSimd_X2         |               |          | 1471.730 | 1668.630 | 2042.253 |
| YGroup3ZipBenchmark_Byte    | Sum128X2AdvSimd_Unzip      |               |          | 1640.662 | 1578.035 | 1734.873 |
| YGroup3ZipBenchmark_Byte    | Sum128X2AdvSimdB64_X2      |               |          | 3993.936 | 4095.980 | 4420.146 |
| YGroup3ZipBenchmark_Byte    | Sum128X2AdvSimdB64_Unzip   |               |          | 4402.878 | 4093.741 | 4397.191 |
| YGroup3ZipBenchmark_Byte    | Sum128X2PackedSimd_X2      |               |          |          |          |          |
| YGroup3ZipBenchmark_Byte    | Sum128X2PackedSimd_Unzip   |               |          |          |          |          |
| YGroup3ZipBenchmark_Byte    | Sum128X2Sse_X2             |               |          |          |          |          |
| YGroup3ZipBenchmark_Byte    | Sum128X2Sse_Unzip          |               |          |          |          |          |
| YGroup3ZipBenchmark_Byte    | Sum128X2Traits             |       152.277 |          | 4400.841 | 4078.858 | 4420.281 |
| YGroup3ZipBenchmark_Byte    | Sum256Base_Basic           |       158.315 |          |  155.290 |  141.277 |  355.261 |
| YGroup3ZipBenchmark_Byte    | Sum256Base_ByShorter       |               |          |          |  146.930 | 1683.262 |
| YGroup3ZipBenchmark_Byte    | Sum256Base_ByX2Unzip       |               |          |          |   23.172 |   32.849 |
| YGroup3ZipBenchmark_Byte    | Sum256Base                 |       155.661 |          |  154.987 |  148.889 | 1682.656 |
| YGroup3ZipBenchmark_Byte    | Sum256Avx2_ByShorter       |               |          |          |          |          |
| YGroup3ZipBenchmark_Byte    | Sum256Avx2_ByX2Unzip       |               |          |          |          |          |
| YGroup3ZipBenchmark_Byte    | Sum256Avx2_Shuffle         |               |          |          |          |          |
| YGroup3ZipBenchmark_Byte    | Sum256Avx2_ShuffleX        |               |          |          |          |          |
| YGroup3ZipBenchmark_Byte    | Sum256Traits               |       142.088 |          |  150.202 |  150.707 | 1683.614 |
| YGroup3ZipBenchmark_Byte    | Sum256X2Base_Basic         |       155.913 |          |  149.625 |  146.726 |  348.115 |
| YGroup3ZipBenchmark_Byte    | Sum256X2Base_X2            |       152.363 |          |  147.913 |   44.622 | 1659.987 |
| YGroup3ZipBenchmark_Byte    | Sum256X2Base_Unzip         |               |          |          |   31.583 |   65.661 |
| YGroup3ZipBenchmark_Byte    | Sum256X2Base               |       150.114 |          |  147.899 |   42.721 | 1659.954 |
| YGroup3ZipBenchmark_Byte    | Sum256X2Avx2_X2            |               |          |          |          |          |
| YGroup3ZipBenchmark_Byte    | Sum256X2Avx2_Unzip         |               |          |          |          |          |
| YGroup3ZipBenchmark_Byte    | Sum256X2Traits             |       135.187 |          |   96.350 |   42.483 | 1659.965 |
| YGroup3ZipBenchmark_Byte    | Sum512Base_Basic           |               |          |          |          |  344.377 |
| YGroup3ZipBenchmark_Byte    | Sum512Base_ByShorter       |               |          |          |          | 1638.502 |
| YGroup3ZipBenchmark_Byte    | Sum512Base_ByX2Unzip       |               |          |          |          |   28.971 |
| YGroup3ZipBenchmark_Byte    | Sum512Base                 |               |          |          |          | 1656.369 |
| YGroup3ZipBenchmark_Byte    | Sum512Avx512_ByShorter     |               |          |          |          |          |
| YGroup3ZipBenchmark_Byte    | Sum512Avx512_ByX2Unzip     |               |          |          |          |          |
| YGroup3ZipBenchmark_Byte    | Sum512Avx512_ShuffleX      |               |          |          |          |          |
| YGroup3ZipBenchmark_Byte    | Sum512Traits               |               |          |          |          | 1656.268 |
| YGroup3ZipBenchmark_Byte    | Sum512X2Base_Basic         |               |          |          |          |  338.893 |
| YGroup3ZipBenchmark_Byte    | Sum512X2Base_X2            |               |          |          |          |  623.735 |
| YGroup3ZipBenchmark_Byte    | Sum512X2Base_Unzip         |               |          |          |          |   56.685 |
| YGroup3ZipBenchmark_Byte    | Sum512X2Base               |               |          |          |          |  623.723 |
| YGroup3ZipBenchmark_Byte    | Sum512X2Avx512_X2          |               |          |          |          |          |
| YGroup3ZipBenchmark_Byte    | Sum512X2Avx512_Unzip       |               |          |          |          |          |
| YGroup3ZipBenchmark_Byte    | Sum512X2Traits             |               |          |          |          |  627.577 |
| YGroup3ZipBenchmark_Int16   | SumBase_Basic              |       214.291 |          |  218.814 |  299.398 |  283.789 |
| YGroup3ZipBenchmark_Int16   | SumBase_ByX2Unzip          |       138.618 |          |  158.943 |  429.660 |  432.588 |
| YGroup3ZipBenchmark_Int16   | SumBase                    |       214.247 |          |  217.945 |  422.929 |  432.557 |
| YGroup3ZipBenchmark_Int16   | SumTraits                  |       214.400 |          | 1947.694 | 2124.489 | 3037.442 |
| YGroup3ZipBenchmark_Int16   | SumX2Base_Basic            |       209.586 |          |  213.522 |  286.010 |  278.200 |
| YGroup3ZipBenchmark_Int16   | SumX2Base_X2               |       209.539 |          |  212.921 |  429.681 |  436.647 |
| YGroup3ZipBenchmark_Int16   | SumX2Base_Unzip            |       270.933 |          |  311.020 |  800.845 |  817.376 |
| YGroup3ZipBenchmark_Int16   | SumX2Base                  |       209.544 |          |  212.671 |  807.496 |  817.343 |
| YGroup3ZipBenchmark_Int16   | SumX2Traits                |       209.557 |          | 2537.141 | 2565.981 | 2618.864 |
| YGroup3ZipBenchmark_Int16   | Sum128Base_Basic           |       110.378 |          |  111.527 |  298.642 |  283.771 |
| YGroup3ZipBenchmark_Int16   | Sum128Base_ByX2Unzip       |               |          |          |  630.462 |  723.227 |
| YGroup3ZipBenchmark_Int16   | Sum128Base                 |       110.289 |          |  111.254 |  630.749 |  720.921 |
| YGroup3ZipBenchmark_Int16   | Sum128AdvSimd_ByX2Unzip    |               |          |  650.688 |  670.868 |  724.153 |
| YGroup3ZipBenchmark_Int16   | Sum128AdvSimd_Shuffle      |               |          |  693.356 |  833.076 |  858.212 |
| YGroup3ZipBenchmark_Int16   | Sum128AdvSimd_ShuffleX     |               |          |          |          | 1398.337 |
| YGroup3ZipBenchmark_Int16   | Sum128AdvSimdB64_ByX2Unzip |               |          | 1604.411 | 1580.084 | 1608.908 |
| YGroup3ZipBenchmark_Int16   | Sum128AdvSimdB64_Shuffle   |               |          | 2060.763 | 2063.941 | 2105.704 |
| YGroup3ZipBenchmark_Int16   | Sum128AdvSimdB64_ShuffleX  |               |          |          |          | 3041.751 |
| YGroup3ZipBenchmark_Int16   | Sum128PackedSimd_ByX2Unzip |               |          |          |          |          |
| YGroup3ZipBenchmark_Int16   | Sum128PackedSimd_Shuffle   |               |          |          |          |          |
| YGroup3ZipBenchmark_Int16   | Sum128Sse_ByX2Unzip        |               |          |          |          |          |
| YGroup3ZipBenchmark_Int16   | Sum128Sse_Shuffle          |               |          |          |          |          |
| YGroup3ZipBenchmark_Int16   | Sum128Sse_ShuffleX         |               |          |          |          |          |
| YGroup3ZipBenchmark_Int16   | Sum128Traits               |       110.169 |          | 1796.388 | 2055.199 | 3037.146 |
| YGroup3ZipBenchmark_Int16   | Sum128X2Base_Basic         |        94.458 |          |  107.127 |  293.404 |  278.244 |
| YGroup3ZipBenchmark_Int16   | Sum128X2Base_X2            |        95.048 |          |  108.202 |  603.029 |  746.430 |
| YGroup3ZipBenchmark_Int16   | Sum128X2Base_Unzip         |               |          |          |  975.816 | 1084.929 |
| YGroup3ZipBenchmark_Int16   | Sum128X2Base               |        96.102 |          |  108.210 |  993.336 | 1085.284 |
| YGroup3ZipBenchmark_Int16   | Sum128X2AdvSimd_X2         |               |          |  731.407 |  841.692 | 1019.353 |
| YGroup3ZipBenchmark_Int16   | Sum128X2AdvSimd_Unzip      |               |          | 1021.932 | 1022.228 | 1076.568 |
| YGroup3ZipBenchmark_Int16   | Sum128X2AdvSimdB64_X2      |               |          | 1896.333 | 2128.986 | 2207.158 |
| YGroup3ZipBenchmark_Int16   | Sum128X2AdvSimdB64_Unzip   |               |          | 2537.307 | 2620.201 | 2616.876 |
| YGroup3ZipBenchmark_Int16   | Sum128X2PackedSimd_X2      |               |          |          |          |          |
| YGroup3ZipBenchmark_Int16   | Sum128X2PackedSimd_Unzip   |               |          |          |          |          |
| YGroup3ZipBenchmark_Int16   | Sum128X2Sse_X2             |               |          |          |          |          |
| YGroup3ZipBenchmark_Int16   | Sum128X2Sse_Unzip          |               |          |          |          |          |
| YGroup3ZipBenchmark_Int16   | Sum128X2Traits             |        96.094 |          | 2401.298 | 2521.617 | 2617.651 |
| YGroup3ZipBenchmark_Int16   | Sum256Base_Basic           |       101.223 |          |  113.560 |  109.710 |  303.134 |
| YGroup3ZipBenchmark_Int16   | Sum256Base_ByShorter       |               |          |          |  113.990 | 1128.170 |
| YGroup3ZipBenchmark_Int16   | Sum256Base_ByX2Unzip       |               |          |          |   18.992 |   28.405 |
| YGroup3ZipBenchmark_Int16   | Sum256Base                 |        98.836 |          |  111.822 |  110.983 | 1128.260 |
| YGroup3ZipBenchmark_Int16   | Sum256Avx2_ByShorter       |               |          |          |          |          |
| YGroup3ZipBenchmark_Int16   | Sum256Avx2_ByX2Unzip       |               |          |          |          |          |
| YGroup3ZipBenchmark_Int16   | Sum256Avx2_Shuffle         |               |          |          |          |          |
| YGroup3ZipBenchmark_Int16   | Sum256Avx2_ShuffleX        |               |          |          |          |          |
| YGroup3ZipBenchmark_Int16   | Sum256Traits               |        88.099 |          |  107.386 |  108.210 | 1128.052 |
| YGroup3ZipBenchmark_Int16   | Sum256X2Base_Basic         |        95.366 |          |  107.632 |  106.129 |  252.307 |
| YGroup3ZipBenchmark_Int16   | Sum256X2Base_X2            |        93.266 |          |  104.470 |   59.368 | 1095.470 |
| YGroup3ZipBenchmark_Int16   | Sum256X2Base_Unzip         |               |          |          |   29.919 |   56.149 |
| YGroup3ZipBenchmark_Int16   | Sum256X2Base               |        91.467 |          |  104.477 |   39.888 | 1095.022 |
| YGroup3ZipBenchmark_Int16   | Sum256X2Avx2_X2            |               |          |          |          |          |
| YGroup3ZipBenchmark_Int16   | Sum256X2Avx2_Unzip         |               |          |          |          |          |
| YGroup3ZipBenchmark_Int16   | Sum256X2Traits             |        77.150 |          |   87.745 |   38.801 | 1095.390 |
| YGroup3ZipBenchmark_Int16   | Sum512Base_Basic           |               |          |          |          |  273.188 |
| YGroup3ZipBenchmark_Int16   | Sum512Base_ByShorter       |               |          |          |          | 1064.527 |
| YGroup3ZipBenchmark_Int16   | Sum512Base_ByX2Unzip       |               |          |          |          |   24.634 |
| YGroup3ZipBenchmark_Int16   | Sum512Base                 |               |          |          |          | 1065.381 |
| YGroup3ZipBenchmark_Int16   | Sum512Avx512_ByShorter     |               |          |          |          |          |
| YGroup3ZipBenchmark_Int16   | Sum512Avx512_ByX2Unzip     |               |          |          |          |          |
| YGroup3ZipBenchmark_Int16   | Sum512Avx512_ShuffleX      |               |          |          |          |          |
| YGroup3ZipBenchmark_Int16   | Sum512Traits               |               |          |          |          | 1064.473 |
| YGroup3ZipBenchmark_Int16   | Sum512X2Base_Basic         |               |          |          |          |  273.500 |
| YGroup3ZipBenchmark_Int16   | Sum512X2Base_X2            |               |          |          |          |  306.352 |
| YGroup3ZipBenchmark_Int16   | Sum512X2Base_Unzip         |               |          |          |          |   47.060 |
| YGroup3ZipBenchmark_Int16   | Sum512X2Base               |               |          |          |          |  300.732 |
| YGroup3ZipBenchmark_Int16   | Sum512X2Avx512_X2          |               |          |          |          |          |
| YGroup3ZipBenchmark_Int16   | Sum512X2Avx512_Unzip       |               |          |          |          |          |
| YGroup3ZipBenchmark_Int16   | Sum512X2Traits             |               |          |          |          |  305.583 |
| YGroup3ZipBenchmark_Int32   | SumBase_Basic              |       177.759 |          |  180.043 |  226.880 |  218.206 |
| YGroup3ZipBenchmark_Int32   | SumBase_ByX2Unzip          |        58.599 |          |   73.564 |  342.225 |  359.030 |
| YGroup3ZipBenchmark_Int32   | SumBase                    |       177.694 |          |  178.579 |  343.191 |  358.961 |
| YGroup3ZipBenchmark_Int32   | SumTraits                  |       177.434 |          | 1072.026 | 1053.063 | 1494.637 |
| YGroup3ZipBenchmark_Int32   | SumX2Base_Basic            |       171.889 |          |  172.775 |  207.537 |  206.395 |
| YGroup3ZipBenchmark_Int32   | SumX2Base_X2               |       172.103 |          |  172.253 |  345.286 |  352.257 |
| YGroup3ZipBenchmark_Int32   | SumX2Base_Unzip            |        97.693 |          |  113.147 |  500.068 |  552.655 |
| YGroup3ZipBenchmark_Int32   | SumX2Base                  |       171.969 |          |  172.323 |  504.015 |  552.706 |
| YGroup3ZipBenchmark_Int32   | SumX2Traits                |       171.872 |          | 1592.314 | 1582.689 | 1611.841 |
| YGroup3ZipBenchmark_Int32   | Sum128Base_Basic           |        72.855 |          |   80.912 |  230.612 |  218.095 |
| YGroup3ZipBenchmark_Int32   | Sum128Base_ByX2Unzip       |               |          |          |  458.432 |  536.004 |
| YGroup3ZipBenchmark_Int32   | Sum128Base                 |        73.034 |          |   81.258 |  454.775 |  533.772 |
| YGroup3ZipBenchmark_Int32   | Sum128AdvSimd_ByX2Unzip    |               |          |  466.501 |  456.631 |  534.104 |
| YGroup3ZipBenchmark_Int32   | Sum128AdvSimd_Shuffle      |               |          |  357.898 |  421.367 |  430.014 |
| YGroup3ZipBenchmark_Int32   | Sum128AdvSimd_ShuffleX     |               |          |          |          |  687.778 |
| YGroup3ZipBenchmark_Int32   | Sum128AdvSimdB64_ByX2Unzip |               |          | 1071.316 | 1055.080 | 1081.779 |
| YGroup3ZipBenchmark_Int32   | Sum128AdvSimdB64_Shuffle   |               |          | 1035.719 | 1027.950 | 1037.179 |
| YGroup3ZipBenchmark_Int32   | Sum128AdvSimdB64_ShuffleX  |               |          |          |          | 1498.077 |
| YGroup3ZipBenchmark_Int32   | Sum128PackedSimd_ByX2Unzip |               |          |          |          |          |
| YGroup3ZipBenchmark_Int32   | Sum128PackedSimd_Shuffle   |               |          |          |          |          |
| YGroup3ZipBenchmark_Int32   | Sum128Sse_ByX2Unzip        |               |          |          |          |          |
| YGroup3ZipBenchmark_Int32   | Sum128Sse_Shuffle          |               |          |          |          |          |
| YGroup3ZipBenchmark_Int32   | Sum128Sse_ShuffleX         |               |          |          |          |          |
| YGroup3ZipBenchmark_Int32   | Sum128Sse_ShuffleXImm      |               |          |          |          |          |
| YGroup3ZipBenchmark_Int32   | Sum128Traits               |        73.054 |          | 1070.484 | 1092.464 | 1501.241 |
| YGroup3ZipBenchmark_Int32   | Sum128X2Base_Basic         |        68.412 |          |   71.767 |  206.558 |  206.431 |
| YGroup3ZipBenchmark_Int32   | Sum128X2Base_X2            |        68.338 |          |   71.868 |  462.697 |  581.050 |
| YGroup3ZipBenchmark_Int32   | Sum128X2Base_Unzip         |               |          |          |  639.481 |  711.112 |
| YGroup3ZipBenchmark_Int32   | Sum128X2Base               |        68.166 |          |   71.882 |  642.743 |  711.159 |
| YGroup3ZipBenchmark_Int32   | Sum128X2AdvSimd_X2         |               |          |  472.106 |  469.388 |  510.140 |
| YGroup3ZipBenchmark_Int32   | Sum128X2AdvSimd_Unzip      |               |          |  659.740 |  653.509 |  710.990 |
| YGroup3ZipBenchmark_Int32   | Sum128X2AdvSimdB64_X2      |               |          | 1034.123 | 1021.075 | 1105.266 |
| YGroup3ZipBenchmark_Int32   | Sum128X2AdvSimdB64_Unzip   |               |          | 1600.918 | 1588.805 | 1608.220 |
| YGroup3ZipBenchmark_Int32   | Sum128X2PackedSimd_X2      |               |          |          |          |          |
| YGroup3ZipBenchmark_Int32   | Sum128X2PackedSimd_Unzip   |               |          |          |          |          |
| YGroup3ZipBenchmark_Int32   | Sum128X2Sse_X2             |               |          |          |          |          |
| YGroup3ZipBenchmark_Int32   | Sum128X2Sse_Unzip          |               |          |          |          |          |
| YGroup3ZipBenchmark_Int32   | Sum128X2Traits             |        68.205 |          | 1593.558 | 1557.036 | 1606.068 |
| YGroup3ZipBenchmark_Int32   | Sum256Base_Basic           |        68.682 |          |   77.655 |   89.734 |  248.057 |
| YGroup3ZipBenchmark_Int32   | Sum256Base_ByShorter       |               |          |          |   78.445 |  763.699 |
| YGroup3ZipBenchmark_Int32   | Sum256Base_ByX2Unzip       |               |          |          |   16.254 |   29.623 |
| YGroup3ZipBenchmark_Int32   | Sum256Base                 |        66.541 |          |   76.217 |   75.070 |  763.475 |
| YGroup3ZipBenchmark_Int32   | Sum256Avx2_ByShorter       |               |          |          |          |          |
| YGroup3ZipBenchmark_Int32   | Sum256Avx2_ByX2Unzip       |               |          |          |          |          |
| YGroup3ZipBenchmark_Int32   | Sum256Avx2_Shuffle         |               |          |          |          |          |
| YGroup3ZipBenchmark_Int32   | Sum256Avx2_ShuffleX        |               |          |          |          |          |
| YGroup3ZipBenchmark_Int32   | Sum256Avx2_ShuffleXImm     |               |          |          |          |          |
| YGroup3ZipBenchmark_Int32   | Sum256Traits               |        57.236 |          |   76.269 |   74.590 |  763.563 |
| YGroup3ZipBenchmark_Int32   | Sum256X2Base_Basic         |        63.656 |          |   71.246 |   79.826 |  165.147 |
| YGroup3ZipBenchmark_Int32   | Sum256X2Base_X2            |        62.023 |          |   70.942 |   81.828 |  743.963 |
| YGroup3ZipBenchmark_Int32   | Sum256X2Base_Unzip         |               |          |          |   28.734 |   58.752 |
| YGroup3ZipBenchmark_Int32   | Sum256X2Base               |        60.224 |          |   67.335 |   84.997 |  743.902 |
| YGroup3ZipBenchmark_Int32   | Sum256X2Avx2_X2            |               |          |          |          |          |
| YGroup3ZipBenchmark_Int32   | Sum256X2Avx2_Unzip         |               |          |          |          |          |
| YGroup3ZipBenchmark_Int32   | Sum256X2Traits             |        46.942 |          |   55.805 |   84.754 |  744.016 |
| YGroup3ZipBenchmark_Int32   | Sum512Base_Basic           |               |          |          |          |  216.822 |
| YGroup3ZipBenchmark_Int32   | Sum512Base_ByShorter       |               |          |          |          |  745.629 |
| YGroup3ZipBenchmark_Int32   | Sum512Base_ByX2Unzip       |               |          |          |          |   26.395 |
| YGroup3ZipBenchmark_Int32   | Sum512Base                 |               |          |          |          |  745.584 |
| YGroup3ZipBenchmark_Int32   | Sum512Avx512_ByShorter     |               |          |          |          |          |
| YGroup3ZipBenchmark_Int32   | Sum512Avx512_ByX2Unzip     |               |          |          |          |          |
| YGroup3ZipBenchmark_Int32   | Sum512Avx512_ShuffleX      |               |          |          |          |          |
| YGroup3ZipBenchmark_Int32   | Sum512Avx512_ShuffleXImm   |               |          |          |          |          |
| YGroup3ZipBenchmark_Int32   | Sum512Traits               |               |          |          |          |  745.291 |
| YGroup3ZipBenchmark_Int32   | Sum512X2Base_Basic         |               |          |          |          |  211.834 |
| YGroup3ZipBenchmark_Int32   | Sum512X2Base_X2            |               |          |          |          |  175.139 |
| YGroup3ZipBenchmark_Int32   | Sum512X2Base_Unzip         |               |          |          |          |   52.575 |
| YGroup3ZipBenchmark_Int32   | Sum512X2Base               |               |          |          |          |  169.364 |
| YGroup3ZipBenchmark_Int32   | Sum512X2Avx512_X2          |               |          |          |          |          |
| YGroup3ZipBenchmark_Int32   | Sum512X2Avx512_Unzip       |               |          |          |          |          |
| YGroup3ZipBenchmark_Int32   | Sum512X2Traits             |               |          |          |          |  172.607 |
| YGroup3ZipBenchmark_Int64   | SumBase_Basic              |       167.955 |          |  186.335 |  184.875 |  188.208 |
| YGroup3ZipBenchmark_Int64   | SumBase                    |       168.658 |          |  187.520 |  189.109 |  187.830 |
| YGroup3ZipBenchmark_Int64   | SumTraits                  |       168.315 |          | 1146.498 | 1177.373 | 1182.660 |
| YGroup3ZipBenchmark_Int64   | SumX2Base_Basic            |       163.197 |          |  170.545 |  168.930 |  174.513 |
| YGroup3ZipBenchmark_Int64   | SumX2Base_X2               |       162.587 |          |  169.792 |  164.160 |  174.668 |
| YGroup3ZipBenchmark_Int64   | SumX2Base                  |       162.566 |          |  169.710 |  163.148 |  174.322 |
| YGroup3ZipBenchmark_Int64   | SumX2Traits                |       160.891 |          | 1220.258 | 1237.215 | 1232.484 |
| YGroup3ZipBenchmark_Int64   | Sum128Base_Basic           |        85.877 |          |   94.765 |  198.998 |  188.272 |
| YGroup3ZipBenchmark_Int64   | Sum128Base_Move            |        78.860 |          |  166.132 |  899.710 | 1049.310 |
| YGroup3ZipBenchmark_Int64   | Sum128Base                 |        86.428 |          |  165.860 |  899.198 | 1048.502 |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimd_AlignRight   |               |          | 1150.248 | 1232.227 | 1182.971 |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimd_ByX2Unzip    |               |          |  522.174 |  544.238 |  536.089 |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimd_Shuffle      |               |          |  270.414 |  322.694 |  317.584 |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimd_ShuffleX     |               |          |          |          |  459.989 |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimdB64_ByX2Unzip |               |          |  798.442 |  825.354 |  814.859 |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimdB64_Shuffle   |               |          |  763.758 |  819.615 |  779.159 |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimdB64_ShuffleX  |               |          |          |          | 1010.995 |
| YGroup3ZipBenchmark_Int64   | Sum128PackedSimd_ByX2Unzip |               |          |          |          |          |
| YGroup3ZipBenchmark_Int64   | Sum128PackedSimd_Shuffle   |               |          |          |          |          |
| YGroup3ZipBenchmark_Int64   | Sum128Sse_ByX2Unzip        |               |          |          |          |          |
| YGroup3ZipBenchmark_Int64   | Sum128Sse_Shuffle          |               |          |          |          |          |
| YGroup3ZipBenchmark_Int64   | Sum128Sse_ShuffleX         |               |          |          |          |          |
| YGroup3ZipBenchmark_Int64   | Sum128Sse_ShuffleXImm      |               |          |          |          |          |
| YGroup3ZipBenchmark_Int64   | Sum128Traits               |        86.579 |          | 1157.051 | 1232.798 | 1183.150 |
| YGroup3ZipBenchmark_Int64   | Sum128X2Base_Basic         |        75.826 |          |   81.668 |  174.407 |  175.142 |
| YGroup3ZipBenchmark_Int64   | Sum128X2Base_X2            |        76.685 |          |  173.632 |  863.850 | 1094.423 |
| YGroup3ZipBenchmark_Int64   | Sum128X2Base               |        77.215 |          |  173.192 |  865.009 | 1094.501 |
| YGroup3ZipBenchmark_Int64   | Sum128X2AdvSimd_X2         |               |          | 1221.308 | 1239.809 | 1230.569 |
| YGroup3ZipBenchmark_Int64   | Sum128X2AdvSimd_Unzip      |               |          |  734.566 |  767.772 |  750.308 |
| YGroup3ZipBenchmark_Int64   | Sum128X2AdvSimdB64_X2      |               |          | 1218.905 | 1240.110 | 1232.330 |
| YGroup3ZipBenchmark_Int64   | Sum128X2AdvSimdB64_Unzip   |               |          | 1069.791 | 1100.693 | 1088.358 |
| YGroup3ZipBenchmark_Int64   | Sum128X2PackedSimd_X2      |               |          |          |          |          |
| YGroup3ZipBenchmark_Int64   | Sum128X2PackedSimd_Unzip   |               |          |          |          |          |
| YGroup3ZipBenchmark_Int64   | Sum128X2Sse_X2             |               |          |          |          |          |
| YGroup3ZipBenchmark_Int64   | Sum128X2Sse_Unzip          |               |          |          |          |          |
| YGroup3ZipBenchmark_Int64   | Sum128X2Traits             |        77.176 |          | 1224.242 | 1241.243 | 1232.246 |
| YGroup3ZipBenchmark_Int64   | Sum256Base_Basic           |        46.471 |          |   56.482 |   74.921 |  191.267 |
| YGroup3ZipBenchmark_Int64   | Sum256Base_ByShorter       |               |          |          |   63.456 | 1156.121 |
| YGroup3ZipBenchmark_Int64   | Sum256Base                 |        44.335 |          |   57.097 |   74.996 |  191.274 |
| YGroup3ZipBenchmark_Int64   | Sum256Avx2_ByShorter       |               |          |          |          |          |
| YGroup3ZipBenchmark_Int64   | Sum256Avx2_ByX2Unzip       |               |          |          |          |          |
| YGroup3ZipBenchmark_Int64   | Sum256Avx2_Shuffle         |               |          |          |          |          |
| YGroup3ZipBenchmark_Int64   | Sum256Avx2_ShuffleX        |               |          |          |          |          |
| YGroup3ZipBenchmark_Int64   | Sum256Avx2_ShuffleXImm     |               |          |          |          |          |
| YGroup3ZipBenchmark_Int64   | Sum256Traits               |        36.236 |          |   56.827 |   74.966 |  191.278 |
| YGroup3ZipBenchmark_Int64   | Sum256X2Base_Basic         |        41.669 |          |   52.936 |   70.696 |  153.505 |
| YGroup3ZipBenchmark_Int64   | Sum256X2Base_X2            |        40.354 |          |   48.992 |   71.017 |  153.609 |
| YGroup3ZipBenchmark_Int64   | Sum256X2Base               |        38.955 |          |   46.920 |   69.880 |  153.608 |
| YGroup3ZipBenchmark_Int64   | Sum256X2Avx2_X2            |               |          |          |          |          |
| YGroup3ZipBenchmark_Int64   | Sum256X2Avx2_Unzip         |               |          |          |          |          |
| YGroup3ZipBenchmark_Int64   | Sum256X2Traits             |        28.601 |          |   32.944 |   70.903 |  153.531 |
| YGroup3ZipBenchmark_Int64   | Sum512Base_Basic           |               |          |          |          |  160.181 |
| YGroup3ZipBenchmark_Int64   | Sum512Base_ByShorter       |               |          |          |          |  156.052 |
| YGroup3ZipBenchmark_Int64   | Sum512Base                 |               |          |          |          |  160.198 |
| YGroup3ZipBenchmark_Int64   | Sum512Avx512_ByShorter     |               |          |          |          |          |
| YGroup3ZipBenchmark_Int64   | Sum512Avx512_ByX2Unzip     |               |          |          |          |          |
| YGroup3ZipBenchmark_Int64   | Sum512Avx512_ShuffleX      |               |          |          |          |          |
| YGroup3ZipBenchmark_Int64   | Sum512Avx512_ShuffleXImm   |               |          |          |          |          |
| YGroup3ZipBenchmark_Int64   | Sum512Traits               |               |          |          |          |  160.259 |
| YGroup3ZipBenchmark_Int64   | Sum512X2Base_Basic         |               |          |          |          |  146.951 |
| YGroup3ZipBenchmark_Int64   | Sum512X2Base_X2            |               |          |          |          |  146.941 |
| YGroup3ZipBenchmark_Int64   | Sum512X2Base               |               |          |          |          |  146.954 |
| YGroup3ZipBenchmark_Int64   | Sum512X2Avx512_X2          |               |          |          |          |          |
| YGroup3ZipBenchmark_Int64   | Sum512X2Avx512_Unzip       |               |          |          |          |          |
| YGroup3ZipBenchmark_Int64   | Sum512X2Traits             |               |          |          |          |  146.930 |

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                        | Method                     | .NET 8.0 |
| :-------------------------- | :------------------------- | -------: |
| YGroup3UnzipBenchmark_Byte  | SumBase_Basic              |   11.254 |
| YGroup3UnzipBenchmark_Byte  | SumBase_ByX2Zip            |    1.005 |
| YGroup3UnzipBenchmark_Byte  | SumBase                    |   11.129 |
| YGroup3UnzipBenchmark_Byte  | SumTraits                  |   49.799 |
| YGroup3UnzipBenchmark_Byte  | SumX2Base_Basic            |   10.423 |
| YGroup3UnzipBenchmark_Byte  | SumX2Base_X2               |   10.921 |
| YGroup3UnzipBenchmark_Byte  | SumX2Base_Zip              |    1.965 |
| YGroup3UnzipBenchmark_Byte  | SumX2Base                  |   10.419 |
| YGroup3UnzipBenchmark_Byte  | SumX2Traits                |   49.287 |
| YGroup3UnzipBenchmark_Byte  | Sum128Base_Basic           |   10.495 |
| YGroup3UnzipBenchmark_Byte  | Sum128Base_ByX2Zip         |    3.879 |
| YGroup3UnzipBenchmark_Byte  | Sum128Base                 |   11.414 |
| YGroup3UnzipBenchmark_Byte  | Sum128AdvSimd_ByX2Zip      |          |
| YGroup3UnzipBenchmark_Byte  | Sum128AdvSimd_Shuffle      |          |
| YGroup3UnzipBenchmark_Byte  | Sum128AdvSimd_ShuffleX     |          |
| YGroup3UnzipBenchmark_Byte  | Sum128AdvSimdB64_ByX2Zip   |          |
| YGroup3UnzipBenchmark_Byte  | Sum128AdvSimdB64_Shuffle   |          |
| YGroup3UnzipBenchmark_Byte  | Sum128AdvSimdB64_ShuffleX  |          |
| YGroup3UnzipBenchmark_Byte  | Sum128PackedSimd_ByX2Zip   |   12.289 |
| YGroup3UnzipBenchmark_Byte  | Sum128PackedSimd_Shuffle   |   50.651 |
| YGroup3UnzipBenchmark_Byte  | Sum128Sse_ByX2Zip          |          |
| YGroup3UnzipBenchmark_Byte  | Sum128Sse_Shuffle          |          |
| YGroup3UnzipBenchmark_Byte  | Sum128Sse_ShuffleX         |          |
| YGroup3UnzipBenchmark_Byte  | Sum128Traits               |   49.056 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Base_Basic         |   10.343 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Base_X2            |   10.344 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Base_Zip           |    7.344 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Base               |   10.926 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2AdvSimd_X2         |          |
| YGroup3UnzipBenchmark_Byte  | Sum128X2AdvSimd_Zip        |          |
| YGroup3UnzipBenchmark_Byte  | Sum128X2AdvSimdB64_X2      |          |
| YGroup3UnzipBenchmark_Byte  | Sum128X2AdvSimdB64_Zip     |          |
| YGroup3UnzipBenchmark_Byte  | Sum128X2PackedSimd_X2      |   50.958 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2PackedSimd_Zip     |   22.654 |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Sse_X2             |          |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Sse_Zip            |          |
| YGroup3UnzipBenchmark_Byte  | Sum128X2Traits             |   53.104 |
| YGroup3UnzipBenchmark_Byte  | Sum256Base_Basic           |   10.054 |
| YGroup3UnzipBenchmark_Byte  | Sum256Base_ByShorter       |    7.908 |
| YGroup3UnzipBenchmark_Byte  | Sum256Base_ByX2Zip         |    1.009 |
| YGroup3UnzipBenchmark_Byte  | Sum256Base                 |    7.660 |
| YGroup3UnzipBenchmark_Byte  | Sum256Avx2_ByShorter       |          |
| YGroup3UnzipBenchmark_Byte  | Sum256Avx2_ByX2Unpack      |          |
| YGroup3UnzipBenchmark_Byte  | Sum256Avx2_ByX2Zip         |          |
| YGroup3UnzipBenchmark_Byte  | Sum256Avx2_Shuffle         |          |
| YGroup3UnzipBenchmark_Byte  | Sum256Avx2_ShuffleX        |          |
| YGroup3UnzipBenchmark_Byte  | Sum256Traits               |    7.433 |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Base_Basic         |   10.078 |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Base_X2            |    7.570 |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Base_Zip           |    1.921 |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Base               |    7.527 |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Avx2_Unpack        |          |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Avx2_X2            |          |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Avx2_Zip           |          |
| YGroup3UnzipBenchmark_Byte  | Sum256X2Traits             |    7.211 |
| YGroup3UnzipBenchmark_Byte  | Sum512Base_Basic           |    9.722 |
| YGroup3UnzipBenchmark_Byte  | Sum512Base_ByShorter       |    6.675 |
| YGroup3UnzipBenchmark_Byte  | Sum512Base_ByX2Zip         |    0.918 |
| YGroup3UnzipBenchmark_Byte  | Sum512Base                 |    6.581 |
| YGroup3UnzipBenchmark_Byte  | Sum512Avx512_ByShorter     |          |
| YGroup3UnzipBenchmark_Byte  | Sum512Avx512_ByX2Unpack    |          |
| YGroup3UnzipBenchmark_Byte  | Sum512Avx512_ByX2Zip       |          |
| YGroup3UnzipBenchmark_Byte  | Sum512Avx512_ShuffleX      |          |
| YGroup3UnzipBenchmark_Byte  | Sum512Traits               |    6.227 |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Base_Basic         |   10.581 |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Base_X2            |    6.266 |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Base_Zip           |    1.754 |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Base               |    4.186 |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Avx512_Unpack      |          |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Avx512_X2          |          |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Avx512_Zip         |          |
| YGroup3UnzipBenchmark_Byte  | Sum512X2Traits             |    4.153 |
| YGroup3UnzipBenchmark_Int16 | SumBase_Basic              |    6.973 |
| YGroup3UnzipBenchmark_Int16 | SumBase_ByX2Zip            |    0.867 |
| YGroup3UnzipBenchmark_Int16 | SumBase                    |    7.075 |
| YGroup3UnzipBenchmark_Int16 | SumTraits                  |   24.714 |
| YGroup3UnzipBenchmark_Int16 | SumX2Base_Basic            |    6.560 |
| YGroup3UnzipBenchmark_Int16 | SumX2Base_X2               |    6.908 |
| YGroup3UnzipBenchmark_Int16 | SumX2Base_Zip              |    1.736 |
| YGroup3UnzipBenchmark_Int16 | SumX2Base                  |    6.892 |
| YGroup3UnzipBenchmark_Int16 | SumX2Traits                |    5.542 |
| YGroup3UnzipBenchmark_Int16 | Sum128Base_Basic           |    7.145 |
| YGroup3UnzipBenchmark_Int16 | Sum128Base_ByX2Zip         |    0.435 |
| YGroup3UnzipBenchmark_Int16 | Sum128Base                 |    7.095 |
| YGroup3UnzipBenchmark_Int16 | Sum128AdvSimd_ByX2Zip      |          |
| YGroup3UnzipBenchmark_Int16 | Sum128AdvSimd_Shuffle      |          |
| YGroup3UnzipBenchmark_Int16 | Sum128AdvSimd_ShuffleX     |          |
| YGroup3UnzipBenchmark_Int16 | Sum128AdvSimdB64_ByX2Zip   |          |
| YGroup3UnzipBenchmark_Int16 | Sum128AdvSimdB64_Shuffle   |          |
| YGroup3UnzipBenchmark_Int16 | Sum128AdvSimdB64_ShuffleX  |          |
| YGroup3UnzipBenchmark_Int16 | Sum128PackedSimd_ByX2Zip   |    7.564 |
| YGroup3UnzipBenchmark_Int16 | Sum128PackedSimd_Shuffle   |   23.872 |
| YGroup3UnzipBenchmark_Int16 | Sum128Sse_ByX2Zip          |          |
| YGroup3UnzipBenchmark_Int16 | Sum128Sse_Shuffle          |          |
| YGroup3UnzipBenchmark_Int16 | Sum128Sse_ShuffleX         |          |
| YGroup3UnzipBenchmark_Int16 | Sum128Traits               |   24.890 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Base_Basic         |    6.554 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Base_X2            |    6.735 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Base_Zip           |    0.870 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Base               |    6.750 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2AdvSimd_X2         |          |
| YGroup3UnzipBenchmark_Int16 | Sum128X2AdvSimd_Zip        |          |
| YGroup3UnzipBenchmark_Int16 | Sum128X2AdvSimdB64_X2      |          |
| YGroup3UnzipBenchmark_Int16 | Sum128X2AdvSimdB64_Zip     |          |
| YGroup3UnzipBenchmark_Int16 | Sum128X2PackedSimd_X2      |   25.318 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2PackedSimd_Zip     |   14.379 |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Sse_X2             |          |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Sse_Zip            |          |
| YGroup3UnzipBenchmark_Int16 | Sum128X2Traits             |   26.824 |
| YGroup3UnzipBenchmark_Int16 | Sum256Base_Basic           |    6.761 |
| YGroup3UnzipBenchmark_Int16 | Sum256Base_ByShorter       |    4.566 |
| YGroup3UnzipBenchmark_Int16 | Sum256Base_ByX2Zip         |    0.918 |
| YGroup3UnzipBenchmark_Int16 | Sum256Base                 |    4.541 |
| YGroup3UnzipBenchmark_Int16 | Sum256Avx2_ByShorter       |          |
| YGroup3UnzipBenchmark_Int16 | Sum256Avx2_ByX2Unpack      |          |
| YGroup3UnzipBenchmark_Int16 | Sum256Avx2_ByX2Zip         |          |
| YGroup3UnzipBenchmark_Int16 | Sum256Avx2_Shuffle         |          |
| YGroup3UnzipBenchmark_Int16 | Sum256Avx2_ShuffleX        |          |
| YGroup3UnzipBenchmark_Int16 | Sum256Traits               |    4.368 |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Base_Basic         |    6.319 |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Base_X2            |    4.478 |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Base_Zip           |    1.853 |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Base               |    4.353 |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Avx2_Unpack        |          |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Avx2_X2            |          |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Avx2_Zip           |          |
| YGroup3UnzipBenchmark_Int16 | Sum256X2Traits             |    4.395 |
| YGroup3UnzipBenchmark_Int16 | Sum512Base_Basic           |    6.773 |
| YGroup3UnzipBenchmark_Int16 | Sum512Base_ByShorter       |    3.064 |
| YGroup3UnzipBenchmark_Int16 | Sum512Base_ByX2Zip         |    0.922 |
| YGroup3UnzipBenchmark_Int16 | Sum512Base                 |    3.164 |
| YGroup3UnzipBenchmark_Int16 | Sum512Avx512_ByShorter     |          |
| YGroup3UnzipBenchmark_Int16 | Sum512Avx512_ByX2Unpack    |          |
| YGroup3UnzipBenchmark_Int16 | Sum512Avx512_ByX2Zip       |          |
| YGroup3UnzipBenchmark_Int16 | Sum512Avx512_ShuffleX      |          |
| YGroup3UnzipBenchmark_Int16 | Sum512Traits               |    3.367 |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Base_Basic         |    6.655 |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Base_X2            |    2.689 |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Base_Zip           |    1.662 |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Base               |    3.789 |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Avx512_Unpack      |          |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Avx512_X2          |          |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Avx512_Zip         |          |
| YGroup3UnzipBenchmark_Int16 | Sum512X2Traits             |    3.603 |
| YGroup3UnzipBenchmark_Int32 | SumBase_Basic              |    5.182 |
| YGroup3UnzipBenchmark_Int32 | SumBase_ByX2Zip            |    0.747 |
| YGroup3UnzipBenchmark_Int32 | SumBase                    |    5.026 |
| YGroup3UnzipBenchmark_Int32 | SumTraits                  |   12.226 |
| YGroup3UnzipBenchmark_Int32 | SumX2Base_Basic            |    4.470 |
| YGroup3UnzipBenchmark_Int32 | SumX2Base_X2               |    4.500 |
| YGroup3UnzipBenchmark_Int32 | SumX2Base_Zip              |    1.564 |
| YGroup3UnzipBenchmark_Int32 | SumX2Base                  |    4.606 |
| YGroup3UnzipBenchmark_Int32 | SumX2Traits                |    2.740 |
| YGroup3UnzipBenchmark_Int32 | Sum128Base_Basic           |    5.013 |
| YGroup3UnzipBenchmark_Int32 | Sum128Base_ByX2Zip         |    0.326 |
| YGroup3UnzipBenchmark_Int32 | Sum128Base                 |    4.763 |
| YGroup3UnzipBenchmark_Int32 | Sum128AdvSimd_ByX2Zip      |          |
| YGroup3UnzipBenchmark_Int32 | Sum128AdvSimd_Shuffle      |          |
| YGroup3UnzipBenchmark_Int32 | Sum128AdvSimd_ShuffleX     |          |
| YGroup3UnzipBenchmark_Int32 | Sum128AdvSimdB64_ByX2Zip   |          |
| YGroup3UnzipBenchmark_Int32 | Sum128AdvSimdB64_Shuffle   |          |
| YGroup3UnzipBenchmark_Int32 | Sum128AdvSimdB64_ShuffleX  |          |
| YGroup3UnzipBenchmark_Int32 | Sum128PackedSimd_ByX2Zip   |    5.029 |
| YGroup3UnzipBenchmark_Int32 | Sum128PackedSimd_Shuffle   |   12.727 |
| YGroup3UnzipBenchmark_Int32 | Sum128Sse_ByX2Zip          |          |
| YGroup3UnzipBenchmark_Int32 | Sum128Sse_Shuffle          |          |
| YGroup3UnzipBenchmark_Int32 | Sum128Sse_ShuffleX         |          |
| YGroup3UnzipBenchmark_Int32 | Sum128Sse_ShuffleXImm      |          |
| YGroup3UnzipBenchmark_Int32 | Sum128Traits               |   12.412 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Base_Basic         |    4.485 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Base_X2            |    4.505 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Base_Zip           |    0.652 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Base               |    4.376 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2AdvSimd_X2         |          |
| YGroup3UnzipBenchmark_Int32 | Sum128X2AdvSimd_Zip        |          |
| YGroup3UnzipBenchmark_Int32 | Sum128X2AdvSimdB64_X2      |          |
| YGroup3UnzipBenchmark_Int32 | Sum128X2AdvSimdB64_Zip     |          |
| YGroup3UnzipBenchmark_Int32 | Sum128X2PackedSimd_X2      |   13.087 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2PackedSimd_Zip     |    9.437 |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Sse_X2             |          |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Sse_Zip            |          |
| YGroup3UnzipBenchmark_Int32 | Sum128X2Traits             |   13.030 |
| YGroup3UnzipBenchmark_Int32 | Sum256Base_Basic           |    4.519 |
| YGroup3UnzipBenchmark_Int32 | Sum256Base_ByShorter       |    2.717 |
| YGroup3UnzipBenchmark_Int32 | Sum256Base_ByX2Zip         |    0.860 |
| YGroup3UnzipBenchmark_Int32 | Sum256Base                 |    2.819 |
| YGroup3UnzipBenchmark_Int32 | Sum256Avx2_ByShorter       |          |
| YGroup3UnzipBenchmark_Int32 | Sum256Avx2_ByX2Unpack      |          |
| YGroup3UnzipBenchmark_Int32 | Sum256Avx2_ByX2Zip         |          |
| YGroup3UnzipBenchmark_Int32 | Sum256Avx2_Shuffle         |          |
| YGroup3UnzipBenchmark_Int32 | Sum256Avx2_ShuffleX        |          |
| YGroup3UnzipBenchmark_Int32 | Sum256Avx2_ShuffleXImm     |          |
| YGroup3UnzipBenchmark_Int32 | Sum256Traits               |    2.609 |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Base_Basic         |    4.463 |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Base_X2            |    2.730 |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Base_Zip           |    1.594 |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Base               |    2.658 |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Avx2_Unpack        |          |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Avx2_X2            |          |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Avx2_Zip           |          |
| YGroup3UnzipBenchmark_Int32 | Sum256X2Traits             |    2.675 |
| YGroup3UnzipBenchmark_Int32 | Sum512Base_Basic           |    4.669 |
| YGroup3UnzipBenchmark_Int32 | Sum512Base_ByShorter       |    1.729 |
| YGroup3UnzipBenchmark_Int32 | Sum512Base_ByX2Zip         |    0.869 |
| YGroup3UnzipBenchmark_Int32 | Sum512Base                 |    1.915 |
| YGroup3UnzipBenchmark_Int32 | Sum512Avx512_ByShorter     |          |
| YGroup3UnzipBenchmark_Int32 | Sum512Avx512_ByX2Unpack    |          |
| YGroup3UnzipBenchmark_Int32 | Sum512Avx512_ByX2Zip       |          |
| YGroup3UnzipBenchmark_Int32 | Sum512Avx512_ShuffleX      |          |
| YGroup3UnzipBenchmark_Int32 | Sum512Avx512_ShuffleXImm   |          |
| YGroup3UnzipBenchmark_Int32 | Sum512Traits               |    1.842 |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Base_Basic         |    4.532 |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Base_X2            |    1.536 |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Base_Zip           |    1.659 |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Base               |    2.297 |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Avx512_Unpack      |          |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Avx512_X2          |          |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Avx512_Zip         |          |
| YGroup3UnzipBenchmark_Int32 | Sum512X2Traits             |    2.174 |
| YGroup3UnzipBenchmark_Int64 | SumBase_Basic              |    1.827 |
| YGroup3UnzipBenchmark_Int64 | SumBase                    |    1.900 |
| YGroup3UnzipBenchmark_Int64 | SumTraits                  |    2.866 |
| YGroup3UnzipBenchmark_Int64 | SumX2Base_Basic            |    1.673 |
| YGroup3UnzipBenchmark_Int64 | SumX2Base_X2               |    1.725 |
| YGroup3UnzipBenchmark_Int64 | SumX2Base                  |    1.709 |
| YGroup3UnzipBenchmark_Int64 | SumX2Traits                |    1.492 |
| YGroup3UnzipBenchmark_Int64 | Sum128Base_Basic           |    1.107 |
| YGroup3UnzipBenchmark_Int64 | Sum128Base_Move            |    1.289 |
| YGroup3UnzipBenchmark_Int64 | Sum128Base                 |    1.130 |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimd_AlignRight   |          |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimd_ByX2Zip      |          |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimd_Shuffle      |          |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimd_ShuffleX     |          |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimdB64_ByX2Zip   |          |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimdB64_Shuffle   |          |
| YGroup3UnzipBenchmark_Int64 | Sum128AdvSimdB64_ShuffleX  |          |
| YGroup3UnzipBenchmark_Int64 | Sum128PackedSimd_ByX2Zip   |    3.707 |
| YGroup3UnzipBenchmark_Int64 | Sum128PackedSimd_Shuffle   |   11.701 |
| YGroup3UnzipBenchmark_Int64 | Sum128Sse_ByX2Zip          |          |
| YGroup3UnzipBenchmark_Int64 | Sum128Sse_Shuffle          |          |
| YGroup3UnzipBenchmark_Int64 | Sum128Sse_ShuffleX         |          |
| YGroup3UnzipBenchmark_Int64 | Sum128Sse_ShuffleXImm      |          |
| YGroup3UnzipBenchmark_Int64 | Sum128Traits               |   11.633 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2Base_Basic         |    1.078 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2Base_X2            |    1.060 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2Base               |    1.119 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2AdvSimd_X2         |          |
| YGroup3UnzipBenchmark_Int64 | Sum128X2AdvSimd_Zip        |          |
| YGroup3UnzipBenchmark_Int64 | Sum128X2AdvSimdB64_X2      |          |
| YGroup3UnzipBenchmark_Int64 | Sum128X2AdvSimdB64_Zip     |          |
| YGroup3UnzipBenchmark_Int64 | Sum128X2PackedSimd_X2      |   11.755 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2PackedSimd_Zip     |    7.041 |
| YGroup3UnzipBenchmark_Int64 | Sum128X2Sse_X2             |          |
| YGroup3UnzipBenchmark_Int64 | Sum128X2Sse_Zip            |          |
| YGroup3UnzipBenchmark_Int64 | Sum128X2Traits             |   11.507 |
| YGroup3UnzipBenchmark_Int64 | Sum256Base_Basic           |    1.098 |
| YGroup3UnzipBenchmark_Int64 | Sum256Base_ByShorter       |    0.841 |
| YGroup3UnzipBenchmark_Int64 | Sum256Base                 |    1.080 |
| YGroup3UnzipBenchmark_Int64 | Sum256Avx2_ByShorter       |          |
| YGroup3UnzipBenchmark_Int64 | Sum256Avx2_ByX2Unpack      |          |
| YGroup3UnzipBenchmark_Int64 | Sum256Avx2_ByX2Zip         |          |
| YGroup3UnzipBenchmark_Int64 | Sum256Avx2_Shuffle         |          |
| YGroup3UnzipBenchmark_Int64 | Sum256Avx2_ShuffleX        |          |
| YGroup3UnzipBenchmark_Int64 | Sum256Avx2_ShuffleXImm     |          |
| YGroup3UnzipBenchmark_Int64 | Sum256Traits               |    2.156 |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Base_Basic         |    1.082 |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Base_X2            |    1.084 |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Base               |    1.054 |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Avx2_Unpack        |          |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Avx2_X2            |          |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Avx2_Zip           |          |
| YGroup3UnzipBenchmark_Int64 | Sum256X2Traits             |    2.062 |
| YGroup3UnzipBenchmark_Int64 | Sum512Base_Basic           |    1.143 |
| YGroup3UnzipBenchmark_Int64 | Sum512Base_ByShorter       |    0.961 |
| YGroup3UnzipBenchmark_Int64 | Sum512Base                 |    1.105 |
| YGroup3UnzipBenchmark_Int64 | Sum512Avx512_ByShorter     |          |
| YGroup3UnzipBenchmark_Int64 | Sum512Avx512_ByX2Unpack    |          |
| YGroup3UnzipBenchmark_Int64 | Sum512Avx512_ByX2Zip       |          |
| YGroup3UnzipBenchmark_Int64 | Sum512Avx512_ShuffleX      |          |
| YGroup3UnzipBenchmark_Int64 | Sum512Avx512_ShuffleXImm   |          |
| YGroup3UnzipBenchmark_Int64 | Sum512Traits               |    2.535 |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Base_Basic         |    1.140 |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Base_X2            |    1.135 |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Base               |    1.170 |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Avx512_Unpack      |          |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Avx512_X2          |          |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Avx512_Zip         |          |
| YGroup3UnzipBenchmark_Int64 | Sum512X2Traits             |    2.598 |
| YGroup3ZipBenchmark_Byte    | SumBase_Basic              |   10.811 |
| YGroup3ZipBenchmark_Byte    | SumBase_ByX2Unzip          |    1.120 |
| YGroup3ZipBenchmark_Byte    | SumBase                    |   10.273 |
| YGroup3ZipBenchmark_Byte    | SumTraits                  |   51.910 |
| YGroup3ZipBenchmark_Byte    | SumX2Base_Basic            |   10.863 |
| YGroup3ZipBenchmark_Byte    | SumX2Base_X2               |   10.908 |
| YGroup3ZipBenchmark_Byte    | SumX2Base_Unzip            |    2.129 |
| YGroup3ZipBenchmark_Byte    | SumX2Base                  |   10.619 |
| YGroup3ZipBenchmark_Byte    | SumX2Traits                |   51.343 |
| YGroup3ZipBenchmark_Byte    | Sum128Base_Basic           |   11.054 |
| YGroup3ZipBenchmark_Byte    | Sum128Base_ByX2Unzip       |   16.702 |
| YGroup3ZipBenchmark_Byte    | Sum128Base                 |   16.787 |
| YGroup3ZipBenchmark_Byte    | Sum128AdvSimd_ByX2Unzip    |          |
| YGroup3ZipBenchmark_Byte    | Sum128AdvSimd_Shuffle      |          |
| YGroup3ZipBenchmark_Byte    | Sum128AdvSimd_ShuffleX     |          |
| YGroup3ZipBenchmark_Byte    | Sum128AdvSimdB64_ByX2Unzip |          |
| YGroup3ZipBenchmark_Byte    | Sum128AdvSimdB64_Shuffle   |          |
| YGroup3ZipBenchmark_Byte    | Sum128AdvSimdB64_ShuffleX  |          |
| YGroup3ZipBenchmark_Byte    | Sum128PackedSimd_ByX2Unzip |   12.265 |
| YGroup3ZipBenchmark_Byte    | Sum128PackedSimd_Shuffle   |   51.223 |
| YGroup3ZipBenchmark_Byte    | Sum128Sse_ByX2Unzip        |          |
| YGroup3ZipBenchmark_Byte    | Sum128Sse_Shuffle          |          |
| YGroup3ZipBenchmark_Byte    | Sum128Sse_ShuffleX         |          |
| YGroup3ZipBenchmark_Byte    | Sum128Traits               |   48.317 |
| YGroup3ZipBenchmark_Byte    | Sum128X2Base_Basic         |   10.749 |
| YGroup3ZipBenchmark_Byte    | Sum128X2Base_X2            |   17.547 |
| YGroup3ZipBenchmark_Byte    | Sum128X2Base_Unzip         |   32.334 |
| YGroup3ZipBenchmark_Byte    | Sum128X2Base               |   32.247 |
| YGroup3ZipBenchmark_Byte    | Sum128X2AdvSimd_X2         |          |
| YGroup3ZipBenchmark_Byte    | Sum128X2AdvSimd_Unzip      |          |
| YGroup3ZipBenchmark_Byte    | Sum128X2AdvSimdB64_X2      |          |
| YGroup3ZipBenchmark_Byte    | Sum128X2AdvSimdB64_Unzip   |          |
| YGroup3ZipBenchmark_Byte    | Sum128X2PackedSimd_X2      |   51.894 |
| YGroup3ZipBenchmark_Byte    | Sum128X2PackedSimd_Unzip   |   23.581 |
| YGroup3ZipBenchmark_Byte    | Sum128X2Sse_X2             |          |
| YGroup3ZipBenchmark_Byte    | Sum128X2Sse_Unzip          |          |
| YGroup3ZipBenchmark_Byte    | Sum128X2Traits             |   51.538 |
| YGroup3ZipBenchmark_Byte    | Sum256Base_Basic           |   10.577 |
| YGroup3ZipBenchmark_Byte    | Sum256Base_ByShorter       |   16.507 |
| YGroup3ZipBenchmark_Byte    | Sum256Base_ByX2Unzip       |    1.014 |
| YGroup3ZipBenchmark_Byte    | Sum256Base                 |   16.618 |
| YGroup3ZipBenchmark_Byte    | Sum256Avx2_ByShorter       |          |
| YGroup3ZipBenchmark_Byte    | Sum256Avx2_ByX2Unzip       |          |
| YGroup3ZipBenchmark_Byte    | Sum256Avx2_Shuffle         |          |
| YGroup3ZipBenchmark_Byte    | Sum256Avx2_ShuffleX        |          |
| YGroup3ZipBenchmark_Byte    | Sum256Traits               |   14.838 |
| YGroup3ZipBenchmark_Byte    | Sum256X2Base_Basic         |   10.599 |
| YGroup3ZipBenchmark_Byte    | Sum256X2Base_X2            |   16.418 |
| YGroup3ZipBenchmark_Byte    | Sum256X2Base_Unzip         |    2.039 |
| YGroup3ZipBenchmark_Byte    | Sum256X2Base               |    5.669 |
| YGroup3ZipBenchmark_Byte    | Sum256X2Avx2_X2            |          |
| YGroup3ZipBenchmark_Byte    | Sum256X2Avx2_Unzip         |          |
| YGroup3ZipBenchmark_Byte    | Sum256X2Traits             |    5.256 |
| YGroup3ZipBenchmark_Byte    | Sum512Base_Basic           |   10.082 |
| YGroup3ZipBenchmark_Byte    | Sum512Base_ByShorter       |    9.545 |
| YGroup3ZipBenchmark_Byte    | Sum512Base_ByX2Unzip       |    0.958 |
| YGroup3ZipBenchmark_Byte    | Sum512Base                 |    8.850 |
| YGroup3ZipBenchmark_Byte    | Sum512Avx512_ByShorter     |          |
| YGroup3ZipBenchmark_Byte    | Sum512Avx512_ByX2Unzip     |          |
| YGroup3ZipBenchmark_Byte    | Sum512Avx512_ShuffleX      |          |
| YGroup3ZipBenchmark_Byte    | Sum512Traits               |    8.861 |
| YGroup3ZipBenchmark_Byte    | Sum512X2Base_Basic         |   10.273 |
| YGroup3ZipBenchmark_Byte    | Sum512X2Base_X2            |    9.147 |
| YGroup3ZipBenchmark_Byte    | Sum512X2Base_Unzip         |    1.854 |
| YGroup3ZipBenchmark_Byte    | Sum512X2Base               |    7.889 |
| YGroup3ZipBenchmark_Byte    | Sum512X2Avx512_X2          |          |
| YGroup3ZipBenchmark_Byte    | Sum512X2Avx512_Unzip       |          |
| YGroup3ZipBenchmark_Byte    | Sum512X2Traits             |    7.419 |
| YGroup3ZipBenchmark_Int16   | SumBase_Basic              |    8.331 |
| YGroup3ZipBenchmark_Int16   | SumBase_ByX2Unzip          |    0.887 |
| YGroup3ZipBenchmark_Int16   | SumBase                    |    8.132 |
| YGroup3ZipBenchmark_Int16   | SumTraits                  |   24.983 |
| YGroup3ZipBenchmark_Int16   | SumX2Base_Basic            |    8.114 |
| YGroup3ZipBenchmark_Int16   | SumX2Base_X2               |    8.066 |
| YGroup3ZipBenchmark_Int16   | SumX2Base_Unzip            |    1.749 |
| YGroup3ZipBenchmark_Int16   | SumX2Base                  |    7.758 |
| YGroup3ZipBenchmark_Int16   | SumX2Traits                |    5.422 |
| YGroup3ZipBenchmark_Int16   | Sum128Base_Basic           |    7.842 |
| YGroup3ZipBenchmark_Int16   | Sum128Base_ByX2Unzip       |    0.513 |
| YGroup3ZipBenchmark_Int16   | Sum128Base                 |    7.927 |
| YGroup3ZipBenchmark_Int16   | Sum128AdvSimd_ByX2Unzip    |          |
| YGroup3ZipBenchmark_Int16   | Sum128AdvSimd_Shuffle      |          |
| YGroup3ZipBenchmark_Int16   | Sum128AdvSimd_ShuffleX     |          |
| YGroup3ZipBenchmark_Int16   | Sum128AdvSimdB64_ByX2Unzip |          |
| YGroup3ZipBenchmark_Int16   | Sum128AdvSimdB64_Shuffle   |          |
| YGroup3ZipBenchmark_Int16   | Sum128AdvSimdB64_ShuffleX  |          |
| YGroup3ZipBenchmark_Int16   | Sum128PackedSimd_ByX2Unzip |    7.887 |
| YGroup3ZipBenchmark_Int16   | Sum128PackedSimd_Shuffle   |   25.267 |
| YGroup3ZipBenchmark_Int16   | Sum128Sse_ByX2Unzip        |          |
| YGroup3ZipBenchmark_Int16   | Sum128Sse_Shuffle          |          |
| YGroup3ZipBenchmark_Int16   | Sum128Sse_ShuffleX         |          |
| YGroup3ZipBenchmark_Int16   | Sum128Traits               |   25.242 |
| YGroup3ZipBenchmark_Int16   | Sum128X2Base_Basic         |    8.311 |
| YGroup3ZipBenchmark_Int16   | Sum128X2Base_X2            |    8.197 |
| YGroup3ZipBenchmark_Int16   | Sum128X2Base_Unzip         |    1.035 |
| YGroup3ZipBenchmark_Int16   | Sum128X2Base               |    7.843 |
| YGroup3ZipBenchmark_Int16   | Sum128X2AdvSimd_X2         |          |
| YGroup3ZipBenchmark_Int16   | Sum128X2AdvSimd_Unzip      |          |
| YGroup3ZipBenchmark_Int16   | Sum128X2AdvSimdB64_X2      |          |
| YGroup3ZipBenchmark_Int16   | Sum128X2AdvSimdB64_Unzip   |          |
| YGroup3ZipBenchmark_Int16   | Sum128X2PackedSimd_X2      |   26.014 |
| YGroup3ZipBenchmark_Int16   | Sum128X2PackedSimd_Unzip   |   14.707 |
| YGroup3ZipBenchmark_Int16   | Sum128X2Sse_X2             |          |
| YGroup3ZipBenchmark_Int16   | Sum128X2Sse_Unzip          |          |
| YGroup3ZipBenchmark_Int16   | Sum128X2Traits             |   26.990 |
| YGroup3ZipBenchmark_Int16   | Sum256Base_Basic           |    7.659 |
| YGroup3ZipBenchmark_Int16   | Sum256Base_ByShorter       |    5.481 |
| YGroup3ZipBenchmark_Int16   | Sum256Base_ByX2Unzip       |    0.877 |
| YGroup3ZipBenchmark_Int16   | Sum256Base                 |    5.621 |
| YGroup3ZipBenchmark_Int16   | Sum256Avx2_ByShorter       |          |
| YGroup3ZipBenchmark_Int16   | Sum256Avx2_ByX2Unzip       |          |
| YGroup3ZipBenchmark_Int16   | Sum256Avx2_Shuffle         |          |
| YGroup3ZipBenchmark_Int16   | Sum256Avx2_ShuffleX        |          |
| YGroup3ZipBenchmark_Int16   | Sum256Traits               |    4.950 |
| YGroup3ZipBenchmark_Int16   | Sum256X2Base_Basic         |    7.403 |
| YGroup3ZipBenchmark_Int16   | Sum256X2Base_X2            |    5.601 |
| YGroup3ZipBenchmark_Int16   | Sum256X2Base_Unzip         |    1.732 |
| YGroup3ZipBenchmark_Int16   | Sum256X2Base               |    5.376 |
| YGroup3ZipBenchmark_Int16   | Sum256X2Avx2_X2            |          |
| YGroup3ZipBenchmark_Int16   | Sum256X2Avx2_Unzip         |          |
| YGroup3ZipBenchmark_Int16   | Sum256X2Traits             |    5.236 |
| YGroup3ZipBenchmark_Int16   | Sum512Base_Basic           |    7.385 |
| YGroup3ZipBenchmark_Int16   | Sum512Base_ByShorter       |    3.288 |
| YGroup3ZipBenchmark_Int16   | Sum512Base_ByX2Unzip       |    0.862 |
| YGroup3ZipBenchmark_Int16   | Sum512Base                 |    4.233 |
| YGroup3ZipBenchmark_Int16   | Sum512Avx512_ByShorter     |          |
| YGroup3ZipBenchmark_Int16   | Sum512Avx512_ByX2Unzip     |          |
| YGroup3ZipBenchmark_Int16   | Sum512Avx512_ShuffleX      |          |
| YGroup3ZipBenchmark_Int16   | Sum512Traits               |    4.150 |
| YGroup3ZipBenchmark_Int16   | Sum512X2Base_Basic         |    7.480 |
| YGroup3ZipBenchmark_Int16   | Sum512X2Base_X2            |    4.321 |
| YGroup3ZipBenchmark_Int16   | Sum512X2Base_Unzip         |    1.630 |
| YGroup3ZipBenchmark_Int16   | Sum512X2Base               |    4.184 |
| YGroup3ZipBenchmark_Int16   | Sum512X2Avx512_X2          |          |
| YGroup3ZipBenchmark_Int16   | Sum512X2Avx512_Unzip       |          |
| YGroup3ZipBenchmark_Int16   | Sum512X2Traits             |    4.101 |
| YGroup3ZipBenchmark_Int32   | SumBase_Basic              |    5.667 |
| YGroup3ZipBenchmark_Int32   | SumBase_ByX2Unzip          |    0.832 |
| YGroup3ZipBenchmark_Int32   | SumBase                    |    5.929 |
| YGroup3ZipBenchmark_Int32   | SumTraits                  |   12.898 |
| YGroup3ZipBenchmark_Int32   | SumX2Base_Basic            |    5.685 |
| YGroup3ZipBenchmark_Int32   | SumX2Base_X2               |    5.671 |
| YGroup3ZipBenchmark_Int32   | SumX2Base_Unzip            |    1.625 |
| YGroup3ZipBenchmark_Int32   | SumX2Base                  |    5.492 |
| YGroup3ZipBenchmark_Int32   | SumX2Traits                |    2.732 |
| YGroup3ZipBenchmark_Int32   | Sum128Base_Basic           |    5.761 |
| YGroup3ZipBenchmark_Int32   | Sum128Base_ByX2Unzip       |    0.451 |
| YGroup3ZipBenchmark_Int32   | Sum128Base                 |    5.769 |
| YGroup3ZipBenchmark_Int32   | Sum128AdvSimd_ByX2Unzip    |          |
| YGroup3ZipBenchmark_Int32   | Sum128AdvSimd_Shuffle      |          |
| YGroup3ZipBenchmark_Int32   | Sum128AdvSimd_ShuffleX     |          |
| YGroup3ZipBenchmark_Int32   | Sum128AdvSimdB64_ByX2Unzip |          |
| YGroup3ZipBenchmark_Int32   | Sum128AdvSimdB64_Shuffle   |          |
| YGroup3ZipBenchmark_Int32   | Sum128AdvSimdB64_ShuffleX  |          |
| YGroup3ZipBenchmark_Int32   | Sum128PackedSimd_ByX2Unzip |    5.205 |
| YGroup3ZipBenchmark_Int32   | Sum128PackedSimd_Shuffle   |   12.616 |
| YGroup3ZipBenchmark_Int32   | Sum128Sse_ByX2Unzip        |          |
| YGroup3ZipBenchmark_Int32   | Sum128Sse_Shuffle          |          |
| YGroup3ZipBenchmark_Int32   | Sum128Sse_ShuffleX         |          |
| YGroup3ZipBenchmark_Int32   | Sum128Sse_ShuffleXImm      |          |
| YGroup3ZipBenchmark_Int32   | Sum128Traits               |   12.821 |
| YGroup3ZipBenchmark_Int32   | Sum128X2Base_Basic         |    5.604 |
| YGroup3ZipBenchmark_Int32   | Sum128X2Base_X2            |    5.719 |
| YGroup3ZipBenchmark_Int32   | Sum128X2Base_Unzip         |    0.925 |
| YGroup3ZipBenchmark_Int32   | Sum128X2Base               |    5.700 |
| YGroup3ZipBenchmark_Int32   | Sum128X2AdvSimd_X2         |          |
| YGroup3ZipBenchmark_Int32   | Sum128X2AdvSimd_Unzip      |          |
| YGroup3ZipBenchmark_Int32   | Sum128X2AdvSimdB64_X2      |          |
| YGroup3ZipBenchmark_Int32   | Sum128X2AdvSimdB64_Unzip   |          |
| YGroup3ZipBenchmark_Int32   | Sum128X2PackedSimd_X2      |   13.148 |
| YGroup3ZipBenchmark_Int32   | Sum128X2PackedSimd_Unzip   |    9.241 |
| YGroup3ZipBenchmark_Int32   | Sum128X2Sse_X2             |          |
| YGroup3ZipBenchmark_Int32   | Sum128X2Sse_Unzip          |          |
| YGroup3ZipBenchmark_Int32   | Sum128X2Traits             |   12.965 |
| YGroup3ZipBenchmark_Int32   | Sum256Base_Basic           |    5.167 |
| YGroup3ZipBenchmark_Int32   | Sum256Base_ByShorter       |    3.502 |
| YGroup3ZipBenchmark_Int32   | Sum256Base_ByX2Unzip       |    0.794 |
| YGroup3ZipBenchmark_Int32   | Sum256Base                 |    3.331 |
| YGroup3ZipBenchmark_Int32   | Sum256Avx2_ByShorter       |          |
| YGroup3ZipBenchmark_Int32   | Sum256Avx2_ByX2Unzip       |          |
| YGroup3ZipBenchmark_Int32   | Sum256Avx2_Shuffle         |          |
| YGroup3ZipBenchmark_Int32   | Sum256Avx2_ShuffleX        |          |
| YGroup3ZipBenchmark_Int32   | Sum256Avx2_ShuffleXImm     |          |
| YGroup3ZipBenchmark_Int32   | Sum256Traits               |    3.064 |
| YGroup3ZipBenchmark_Int32   | Sum256X2Base_Basic         |    4.963 |
| YGroup3ZipBenchmark_Int32   | Sum256X2Base_X2            |    3.419 |
| YGroup3ZipBenchmark_Int32   | Sum256X2Base_Unzip         |    1.552 |
| YGroup3ZipBenchmark_Int32   | Sum256X2Base               |    3.395 |
| YGroup3ZipBenchmark_Int32   | Sum256X2Avx2_X2            |          |
| YGroup3ZipBenchmark_Int32   | Sum256X2Avx2_Unzip         |          |
| YGroup3ZipBenchmark_Int32   | Sum256X2Traits             |    3.221 |
| YGroup3ZipBenchmark_Int32   | Sum512Base_Basic           |    4.702 |
| YGroup3ZipBenchmark_Int32   | Sum512Base_ByShorter       |    1.720 |
| YGroup3ZipBenchmark_Int32   | Sum512Base_ByX2Unzip       |    0.806 |
| YGroup3ZipBenchmark_Int32   | Sum512Base                 |    2.421 |
| YGroup3ZipBenchmark_Int32   | Sum512Avx512_ByShorter     |          |
| YGroup3ZipBenchmark_Int32   | Sum512Avx512_ByX2Unzip     |          |
| YGroup3ZipBenchmark_Int32   | Sum512Avx512_ShuffleX      |          |
| YGroup3ZipBenchmark_Int32   | Sum512Avx512_ShuffleXImm   |          |
| YGroup3ZipBenchmark_Int32   | Sum512Traits               |    2.257 |
| YGroup3ZipBenchmark_Int32   | Sum512X2Base_Basic         |    5.022 |
| YGroup3ZipBenchmark_Int32   | Sum512X2Base_X2            |    1.394 |
| YGroup3ZipBenchmark_Int32   | Sum512X2Base_Unzip         |    0.881 |
| YGroup3ZipBenchmark_Int32   | Sum512X2Base               |    1.466 |
| YGroup3ZipBenchmark_Int32   | Sum512X2Avx512_X2          |          |
| YGroup3ZipBenchmark_Int32   | Sum512X2Avx512_Unzip       |          |
| YGroup3ZipBenchmark_Int32   | Sum512X2Traits             |    1.431 |
| YGroup3ZipBenchmark_Int64   | SumBase_Basic              |    0.982 |
| YGroup3ZipBenchmark_Int64   | SumBase                    |    1.035 |
| YGroup3ZipBenchmark_Int64   | SumTraits                  |    1.735 |
| YGroup3ZipBenchmark_Int64   | SumX2Base_Basic            |    1.072 |
| YGroup3ZipBenchmark_Int64   | SumX2Base_X2               |    1.088 |
| YGroup3ZipBenchmark_Int64   | SumX2Base                  |    1.104 |
| YGroup3ZipBenchmark_Int64   | SumX2Traits                |    0.834 |
| YGroup3ZipBenchmark_Int64   | Sum128Base_Basic           |    0.678 |
| YGroup3ZipBenchmark_Int64   | Sum128Base_Move            |    0.767 |
| YGroup3ZipBenchmark_Int64   | Sum128Base                 |    0.668 |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimd_AlignRight   |          |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimd_ByX2Unzip    |          |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimd_Shuffle      |          |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimd_ShuffleX     |          |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimdB64_ByX2Unzip |          |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimdB64_Shuffle   |          |
| YGroup3ZipBenchmark_Int64   | Sum128AdvSimdB64_ShuffleX  |          |
| YGroup3ZipBenchmark_Int64   | Sum128PackedSimd_ByX2Unzip |    2.265 |
| YGroup3ZipBenchmark_Int64   | Sum128PackedSimd_Shuffle   |    7.005 |
| YGroup3ZipBenchmark_Int64   | Sum128Sse_ByX2Unzip        |          |
| YGroup3ZipBenchmark_Int64   | Sum128Sse_Shuffle          |          |
| YGroup3ZipBenchmark_Int64   | Sum128Sse_ShuffleX         |          |
| YGroup3ZipBenchmark_Int64   | Sum128Sse_ShuffleXImm      |          |
| YGroup3ZipBenchmark_Int64   | Sum128Traits               |    7.055 |
| YGroup3ZipBenchmark_Int64   | Sum128X2Base_Basic         |    0.661 |
| YGroup3ZipBenchmark_Int64   | Sum128X2Base_X2            |    0.682 |
| YGroup3ZipBenchmark_Int64   | Sum128X2Base               |    0.688 |
| YGroup3ZipBenchmark_Int64   | Sum128X2AdvSimd_X2         |          |
| YGroup3ZipBenchmark_Int64   | Sum128X2AdvSimd_Unzip      |          |
| YGroup3ZipBenchmark_Int64   | Sum128X2AdvSimdB64_X2      |          |
| YGroup3ZipBenchmark_Int64   | Sum128X2AdvSimdB64_Unzip   |          |
| YGroup3ZipBenchmark_Int64   | Sum128X2PackedSimd_X2      |    7.275 |
| YGroup3ZipBenchmark_Int64   | Sum128X2PackedSimd_Unzip   |    4.001 |
| YGroup3ZipBenchmark_Int64   | Sum128X2Sse_X2             |          |
| YGroup3ZipBenchmark_Int64   | Sum128X2Sse_Unzip          |          |
| YGroup3ZipBenchmark_Int64   | Sum128X2Traits             |    7.124 |
| YGroup3ZipBenchmark_Int64   | Sum256Base_Basic           |    0.677 |
| YGroup3ZipBenchmark_Int64   | Sum256Base_ByShorter       |    0.554 |
| YGroup3ZipBenchmark_Int64   | Sum256Base                 |    0.665 |
| YGroup3ZipBenchmark_Int64   | Sum256Avx2_ByShorter       |          |
| YGroup3ZipBenchmark_Int64   | Sum256Avx2_ByX2Unzip       |          |
| YGroup3ZipBenchmark_Int64   | Sum256Avx2_Shuffle         |          |
| YGroup3ZipBenchmark_Int64   | Sum256Avx2_ShuffleX        |          |
| YGroup3ZipBenchmark_Int64   | Sum256Avx2_ShuffleXImm     |          |
| YGroup3ZipBenchmark_Int64   | Sum256Traits               |    1.308 |
| YGroup3ZipBenchmark_Int64   | Sum256X2Base_Basic         |    0.659 |
| YGroup3ZipBenchmark_Int64   | Sum256X2Base_X2            |    0.666 |
| YGroup3ZipBenchmark_Int64   | Sum256X2Base               |    0.677 |
| YGroup3ZipBenchmark_Int64   | Sum256X2Avx2_X2            |          |
| YGroup3ZipBenchmark_Int64   | Sum256X2Avx2_Unzip         |          |
| YGroup3ZipBenchmark_Int64   | Sum256X2Traits             |    1.367 |
| YGroup3ZipBenchmark_Int64   | Sum512Base_Basic           |    0.665 |
| YGroup3ZipBenchmark_Int64   | Sum512Base_ByShorter       |    0.600 |
| YGroup3ZipBenchmark_Int64   | Sum512Base                 |    0.671 |
| YGroup3ZipBenchmark_Int64   | Sum512Avx512_ByShorter     |          |
| YGroup3ZipBenchmark_Int64   | Sum512Avx512_ByX2Unzip     |          |
| YGroup3ZipBenchmark_Int64   | Sum512Avx512_ShuffleX      |          |
| YGroup3ZipBenchmark_Int64   | Sum512Avx512_ShuffleXImm   |          |
| YGroup3ZipBenchmark_Int64   | Sum512Traits               |    1.551 |
| YGroup3ZipBenchmark_Int64   | Sum512X2Base_Basic         |    0.672 |
| YGroup3ZipBenchmark_Int64   | Sum512X2Base_X2            |    0.674 |
| YGroup3ZipBenchmark_Int64   | Sum512X2Base               |    0.663 |
| YGroup3ZipBenchmark_Int64   | Sum512X2Avx512_X2          |          |
| YGroup3ZipBenchmark_Int64   | Sum512X2Avx512_Unzip       |          |
| YGroup3ZipBenchmark_Int64   | Sum512X2Traits             |    2.488 |

