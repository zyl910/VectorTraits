# Benchmark group - ShiftRightArithmetic
([← Back](ShiftRightArithmetic.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### x86 - lntel Core i5-8250U
| Type                                     | Method                   | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :--------------------------------------- | :----------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAScalar             |        823.804 |       827.734 |      1180.933 |  1182.307 |  1341.171 |  1592.939 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRANetBcl             |                |               |               |           |           | 18480.038 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRANetBcl_Const       |                |               |               |           |           | 21052.686 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base_Basic        |       1032.916 |      1029.712 |       943.844 |   950.774 |   955.858 |  1183.175 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base              |       1549.041 |      1561.338 |      1538.558 |  1545.158 |  1587.007 | 17824.535 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base_Core         |       1693.516 |      1687.546 |      1631.792 |  1649.343 |  1664.105 | 17097.896 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_AdvSimd           |                |               |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Avx2              |                |               |     17568.571 | 17757.737 | 17359.287 | 16319.782 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRATraits             |       1557.132 |      1559.674 |     17325.184 | 17699.944 | 16372.799 | 17193.661 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRATraits_Core        |       1653.816 |      1653.714 |     18414.632 | 19664.147 | 17938.068 | 18476.248 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAConstTraits        |       1672.258 |      1675.044 |     17658.703 | 20409.889 | 20233.738 | 20835.294 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAConstTraits_Core   |       1714.582 |      1667.090 |     20076.043 | 20212.774 | 20994.717 | 21053.837 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFast_AdvSimd       |                |               |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFast_Avx2          |                |               |     18420.197 | 19889.547 | 18267.126 | 18033.470 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFastTraits         |       1629.345 |      1634.647 |     17560.755 | 19919.721 | 18887.005 | 17526.843 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAScalar             |        825.056 |       829.789 |      1275.799 |  1342.349 |  1621.295 |  1620.315 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRANetBcl             |                |               |               |           |           | 10132.774 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRANetBcl_Const       |                |               |               |           |           | 11033.258 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base_Basic        |        530.022 |       532.584 |       511.736 |   527.883 |   515.849 |   516.710 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base              |        762.004 |       752.609 |       769.652 |   788.607 |   799.443 |  9981.499 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base_Core         |        843.821 |       845.000 |       838.216 |   853.742 |   815.326 |  9729.643 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_AdvSimd           |                |               |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Avx2              |                |               |      8366.383 |  8815.251 |  8276.508 |  8641.937 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRATraits             |        764.013 |       759.588 |      8195.470 |  8298.404 |  8314.921 |  9937.082 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRATraits_Core        |        826.612 |       825.854 |     10576.367 | 10449.535 |  9783.716 | 11108.074 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAConstTraits        |        837.650 |       834.126 |      8484.959 |  9238.089 |  9979.236 | 10053.944 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAConstTraits_Core   |        856.397 |       859.426 |     10201.125 | 10314.334 | 11009.384 | 10772.948 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFast_AdvSimd       |                |               |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFast_Avx2          |                |               |      9768.933 |  9340.696 |  8897.085 |  8807.258 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFastTraits         |        815.447 |       809.559 |      8726.308 |  9811.890 |  9564.517 |  9543.983 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAScalar             |        815.238 |       811.645 |      1300.052 |  1280.982 |  1322.441 |  1602.916 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRANetBcl             |                |               |               |           |           |   578.499 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRANetBcl_Const       |                |               |               |           |           |   553.963 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Basic        |        428.629 |       443.525 |       460.542 |   442.086 |   485.017 |   478.819 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base              |        450.276 |       441.329 |       463.155 |   441.480 |   482.260 |  2008.403 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Create       |        415.598 |       418.665 |       405.779 |   397.313 |   417.257 |  3002.479 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_LoadArray    |        417.366 |       416.912 |       394.886 |   390.550 |   403.724 |  2656.594 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Core         |        441.798 |       429.375 |       462.880 |   442.029 |   463.891 |  2988.949 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_AdvSimd           |                |               |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Avx2              |                |               |      3011.767 |  2922.690 |  2918.762 |  2992.220 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRATraits             |        447.196 |       441.690 |      3032.903 |  2830.935 |  2988.130 |  2922.851 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRATraits_Core        |        459.781 |       458.269 |      3639.092 |  3352.255 |  3336.974 |  3488.018 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAConstTraits        |        491.449 |       491.420 |      3074.926 |  2820.864 |  3365.642 |  3397.660 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAConstTraits_Core   |        496.174 |       491.022 |      3660.380 |  3365.210 |  3398.657 |  3237.150 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_AdvSimd       |                |               |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_Avx2          |                |               |      3034.031 |  2976.801 |  2948.319 |  2944.581 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_Avx2_Negative |                |               |      2432.419 |  2382.229 |  2324.667 |  2372.645 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFastTraits         |        476.803 |       473.515 |      3073.680 |  2991.710 |  2962.468 |  3078.174 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAScalar             |        827.231 |       823.643 |      1101.518 |  1105.244 |  1348.340 |  1619.984 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRANetBcl             |                |               |               |           |           |  1161.428 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRANetBcl_Const       |                |               |               |           |           |  1156.552 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base_Basic        |       1127.196 |      1266.031 |      1147.076 |  1161.380 |  1159.633 |  1269.490 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base              |       3102.320 |      3107.965 |      3063.148 |  3132.968 |  3175.370 | 19026.065 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base_Core         |       3371.189 |      3369.161 |      3266.519 |  3341.562 |  3307.588 | 25340.837 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_AdvSimd           |                |               |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Avx2              |                |               |     17071.054 | 17695.738 | 17844.601 | 20946.140 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRATraits             |       3108.569 |      3100.703 |     17944.555 | 17103.399 | 17926.975 | 20115.939 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRATraits_Core        |       3298.491 |      3288.742 |     30742.095 | 30212.469 | 29604.498 | 33040.654 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAConstTraits        |       3320.813 |      3327.910 |     18297.669 | 25989.446 | 28437.425 | 31118.235 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAConstTraits_Core   |       3423.868 |      3427.681 |     29454.032 | 27559.316 | 30075.338 | 30565.076 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFast_AdvSimd       |                |               |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFast_Avx2          |                |               |     23529.355 | 24322.214 | 27359.201 | 28602.638 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFastTraits         |       3308.286 |      3310.614 |     23929.818 | 24211.858 | 27143.567 | 29227.714 |

### Arm - AWS Arm t4g.small
| Type                                     | Method                   | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :--------------------------------------- | :----------------------- | ------------: | --------: | --------: | --------: |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAScalar             |       587.279 |   541.166 |   607.230 |   822.580 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRANetBcl             |               |           |           |  9941.333 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRANetBcl_Const       |               |           |           |  9938.477 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base_Basic        |       499.978 |   468.984 |   524.454 |   548.575 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base              |      1550.998 |  1505.018 |   700.127 |  9944.813 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base_Core         |      1761.556 |  1708.796 |  1940.752 |  9937.640 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_AdvSimd           |               |  4935.548 |  5644.488 |  5687.558 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Avx2              |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRATraits             |      1559.138 |  4950.480 |  5645.497 |  9938.217 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRATraits_Core        |      1823.509 |  8388.956 |  7904.366 |  9938.584 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAConstTraits        |      1808.965 |  6589.881 |  7892.407 |  9871.343 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAConstTraits_Core   |      1810.527 |  8392.943 |  7896.220 |  9925.543 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFast_AdvSimd       |               |  7839.053 |  7898.538 |  9944.129 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFast_Avx2          |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFastTraits         |      1754.440 |  6587.622 |  8412.310 |  9937.396 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAScalar             |       712.668 |   746.666 |   747.055 |  1188.551 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRANetBcl             |               |           |           |  4861.897 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRANetBcl_Const       |               |           |           |  4859.816 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base_Basic        |       317.991 |   330.418 |   331.432 |   339.296 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base              |       829.461 |   393.008 |   393.199 |  4846.014 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base_Core         |       871.763 |   960.185 |   969.376 |  4848.500 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_AdvSimd           |               |  2808.552 |  2467.260 |  3285.681 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Avx2              |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRATraits             |       779.787 |  2944.169 |  2945.026 |  4868.865 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRATraits_Core        |       914.346 |  4125.748 |  4135.353 |  4862.075 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAConstTraits        |       884.914 |  3266.272 |  3892.016 |  4841.364 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAConstTraits_Core   |       920.389 |  4134.164 |  3893.088 |  4844.364 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFast_AdvSimd       |               |  3831.355 |  4126.674 |  4871.387 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFast_Avx2          |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFastTraits         |       875.693 |  3845.319 |  3901.047 |  4871.318 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAScalar             |       717.640 |   742.361 |   742.337 |  1189.925 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRANetBcl             |               |           |           |  2468.196 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRANetBcl_Const       |               |           |           |  2471.434 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Basic        |       197.017 |   484.230 |   483.481 |   474.944 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base              |       458.672 |   484.408 |   483.189 |  2466.542 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Create       |       442.804 |   480.529 |   484.006 |  1782.609 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_LoadArray    |       361.038 |   403.137 |   435.685 |  1325.673 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Core         |       199.524 |   477.348 |   476.856 |  2468.146 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_AdvSimd           |               |  1408.181 |  1408.528 |  1420.547 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Avx2              |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRATraits             |       451.956 |  1235.429 |  1233.818 |  1420.116 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRATraits_Core        |       435.180 |  1972.734 |  1966.992 |  2465.932 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAConstTraits        |       437.799 |  1962.084 |  1966.946 |  2470.825 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAConstTraits_Core   |       436.419 |  2099.303 |  2097.296 |  2469.149 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_AdvSimd       |               |  1959.429 |  2098.306 |  2467.935 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_Avx2          |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_Avx2_Negative |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFastTraits         |       434.293 |  1959.553 |  1970.332 |  2462.309 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAScalar             |       577.766 |   610.669 |   672.786 |   925.515 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRANetBcl             |               |           |           | 19792.701 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRANetBcl_Const       |               |           |           | 19792.641 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base_Basic        |       666.552 |   712.706 |   711.647 |   761.916 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base              |      3026.992 |  3399.260 |  3443.934 |  7966.148 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base_Core         |      3432.558 |  3913.964 |  1700.917 | 11344.947 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_AdvSimd           |               | 11259.027 | 11205.761 | 11349.802 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Avx2              |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRATraits             |      2991.228 | 11281.229 | 11275.758 | 11356.994 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRATraits_Core        |      3529.326 | 16818.297 | 16827.844 | 19798.924 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAConstTraits        |      3476.138 | 15680.873 | 16829.920 | 19774.470 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAConstTraits_Core   |      3577.927 | 16813.202 | 15762.243 | 19759.552 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFast_AdvSimd       |               | 15651.930 | 15800.184 | 19841.339 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFast_Avx2          |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFastTraits         |      3456.946 | 15691.023 | 15780.403 | 19789.471 |
