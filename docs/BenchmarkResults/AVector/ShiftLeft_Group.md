# Benchmark group - ShiftLeft
([← Back](ShiftLeft.md))

Cell unit: Million operations per second.

### x86 - lntel Core i5-8250U
| Type                          | Method                   | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :---------------------------- | :----------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| ShiftLeftConstBenchmark_Byte  | SumSLLScalar             |        702.989 |       707.586 |       912.995 |   958.479 |  1178.414 |  1284.920 |
| ShiftLeftConstBenchmark_Byte  | SumSLLNetBcl             |                |               |               |           |           |   986.920 |
| ShiftLeftConstBenchmark_Byte  | SumSLLNetBcl_Const       |                |               |               |           |           |   991.468 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Basic             |       6390.804 |      6624.372 |     12705.510 | 12211.638 | 13013.599 | 16328.607 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Base_Core         |      30865.116 |     30231.303 |     34508.336 | 30559.773 | 31084.857 | 16014.270 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Multiply          |       6930.163 |      7088.927 |     12869.416 | 11982.441 | 13279.775 | 15775.508 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_AdvSimd           |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Avx2              |                |               |     18150.707 | 15988.311 | 17462.775 | 20086.875 |
| ShiftLeftConstBenchmark_Byte  | SumSLLTraits             |       6839.084 |      7025.806 |     16527.720 | 17917.063 | 17849.148 | 20350.851 |
| ShiftLeftConstBenchmark_Byte  | SumSLLTraits_Core        |      27532.274 |     26828.943 |     34009.630 | 31183.779 | 30838.282 | 31044.717 |
| ShiftLeftConstBenchmark_Byte  | SumSLLConstTraits        |       8698.413 |      8942.308 |     20628.738 | 25220.267 | 33518.465 | 30680.398 |
| ShiftLeftConstBenchmark_Byte  | SumSLLConstTraits_Core   |      30479.708 |     29350.310 |     33637.813 | 30264.244 | 29831.199 | 32350.096 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_Multiply      |       9301.726 |      8676.092 |     21185.978 | 20389.800 | 20579.514 | 26821.848 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_AdvSimd       |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_Avx2          |                |               |     21778.525 | 26684.523 | 29464.590 | 31272.106 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFastTraits         |       8972.513 |      8978.044 |     21090.553 | 27143.873 | 28436.339 | 31363.732 |
| ShiftLeftConstBenchmark_Int16 | SumSLLScalar             |        688.762 |       681.884 |       979.166 |   971.341 |  1103.607 |  1293.578 |
| ShiftLeftConstBenchmark_Int16 | SumSLLNetBcl             |                |               |               |           |           | 15603.602 |
| ShiftLeftConstBenchmark_Int16 | SumSLLNetBcl_Const       |                |               |               |           |           | 16713.688 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Basic             |       4336.013 |      4448.691 |      9206.985 |  9364.735 | 10592.035 | 15431.765 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core         |      16046.658 |     16052.598 |     14677.376 | 17285.330 | 17251.387 | 15909.433 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core_Element |       4179.765 |      4054.507 |      8235.392 |  9170.905 | 10011.226 | 13167.032 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core_Mov     |       3926.580 |      3929.746 |      8845.021 |  8624.911 |  9726.792 | 14168.092 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Multiply          |       4288.238 |      4370.965 |      9469.301 |  9515.880 | 10580.946 | 12023.373 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_AdvSimd           |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Avx2              |                |               |     14212.252 | 13795.022 | 13692.307 | 13503.724 |
| ShiftLeftConstBenchmark_Int16 | SumSLLTraits             |       4295.741 |      4429.872 |     13850.121 | 14125.173 | 14591.112 | 12550.094 |
| ShiftLeftConstBenchmark_Int16 | SumSLLTraits_Core        |      15793.797 |     16612.726 |     14115.234 | 16203.782 | 15904.696 | 10580.334 |
| ShiftLeftConstBenchmark_Int16 | SumSLLConstTraits        |       4849.121 |      4866.811 |     14288.791 | 13917.256 | 17727.500 | 14019.203 |
| ShiftLeftConstBenchmark_Int16 | SumSLLConstTraits_Core   |      16917.224 |     15479.262 |     16907.403 | 14960.127 | 17746.234 | 13419.777 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_Multiply      |       4623.241 |      4863.332 |     12334.222 | 12958.415 | 14830.091 | 11163.718 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_AdvSimd       |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_Avx2          |                |               |     14785.540 | 16663.593 | 13930.337 | 11743.655 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFastTraits         |       4758.473 |      4910.179 |     14152.985 | 15292.245 | 14994.523 | 12929.051 |
| ShiftLeftConstBenchmark_Int32 | SumSLLScalar             |        700.389 |       703.471 |      1085.480 |  1124.277 |  1861.695 |  1920.772 |
| ShiftLeftConstBenchmark_Int32 | SumSLLNetBcl             |                |               |               |           |           |  7483.762 |
| ShiftLeftConstBenchmark_Int32 | SumSLLNetBcl_Const       |                |               |               |           |           |  7426.378 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Basic             |       2054.961 |      2098.220 |      5031.961 |  4924.451 |  4968.010 |  7103.115 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Base_Core         |       7147.102 |      7220.161 |      7298.794 |  7433.905 |  7269.351 |  7422.319 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Multiply          |       2197.576 |      2247.924 |      4963.079 |  4965.937 |  5096.160 |  5150.216 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_AdvSimd           |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Avx2              |                |               |      6161.886 |  6998.017 |  7099.849 |  6116.803 |
| ShiftLeftConstBenchmark_Int32 | SumSLLTraits             |       2290.570 |      2191.532 |      7200.099 |  6990.621 |  6966.909 |  6726.526 |
| ShiftLeftConstBenchmark_Int32 | SumSLLTraits_Core        |       6175.384 |      6706.747 |      8240.907 |  8866.891 |  8779.970 |  7840.156 |
| ShiftLeftConstBenchmark_Int32 | SumSLLConstTraits        |       2475.758 |      2573.044 |      7064.383 |  7720.911 |  8331.775 |  8561.389 |
| ShiftLeftConstBenchmark_Int32 | SumSLLConstTraits_Core   |       7337.960 |      7178.159 |      8561.253 |  8768.824 |  8739.208 |  8778.513 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_Multiply      |       2375.530 |      2414.508 |      6621.280 |  6656.762 |  6206.111 |  7011.858 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_AdvSimd       |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_Avx2          |                |               |      7245.150 |  7340.360 |  7233.623 |  7818.042 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFastTraits         |       2291.540 |      2542.243 |      7328.439 |  7760.968 |  7693.780 |  8000.584 |
| ShiftLeftConstBenchmark_Int64 | SumSLLScalar             |        687.118 |       686.477 |      1083.563 |  1090.582 |  1734.873 |  2126.795 |
| ShiftLeftConstBenchmark_Int64 | SumSLLNetBcl             |                |               |               |           |           |  3666.401 |
| ShiftLeftConstBenchmark_Int64 | SumSLLNetBcl_Const       |                |               |               |           |           |  4520.260 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Basic             |        378.735 |       389.241 |       407.745 |   377.109 |   416.882 |  3848.398 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Base_Core         |        375.550 |       356.963 |       410.153 |   381.200 |   408.775 |  3613.605 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_AdvSimd           |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Avx2              |                |               |      3476.589 |  3448.141 |  3278.499 |  3510.332 |
| ShiftLeftConstBenchmark_Int64 | SumSLLTraits             |        378.705 |       395.834 |      3405.878 |  3410.351 |  3430.241 |  3335.470 |
| ShiftLeftConstBenchmark_Int64 | SumSLLTraits_Core        |        358.696 |       391.259 |      4138.440 |  4427.322 |  4380.972 |  4166.878 |
| ShiftLeftConstBenchmark_Int64 | SumSLLConstTraits        |        435.279 |       477.280 |      3458.963 |  3313.622 |  4181.281 |  4454.434 |
| ShiftLeftConstBenchmark_Int64 | SumSLLConstTraits_Core   |        428.363 |       472.980 |      4022.378 |  4350.820 |  4078.089 |  4230.642 |
| ShiftLeftConstBenchmark_Int64 | SumSLLFast_AdvSimd       |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Int64 | SumSLLFast_Avx2          |                |               |      3565.830 |  3766.616 |  3687.528 |  3547.678 |
| ShiftLeftConstBenchmark_Int64 | SumSLLFastTraits         |        409.370 |       297.508 |      3657.788 |  3684.556 |  3790.882 |  3556.618 |

### Arm - AWS Arm t4g.small
| Type                          | Method                   | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :---------------------------- | :----------------------- | ------------: | --------: | --------: | --------: |
| ShiftLeftConstBenchmark_Byte  | SumSLLScalar             |       603.706 |   610.516 |   673.546 |   886.963 |
| ShiftLeftConstBenchmark_Byte  | SumSLLNetBcl             |               |           |           | 19586.570 |
| ShiftLeftConstBenchmark_Byte  | SumSLLNetBcl_Const       |               |           |           | 19583.990 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Basic             |      5646.259 |  5672.107 |  7110.113 |  7400.491 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Base_Core         |     13055.629 | 15782.407 | 15777.964 |  7389.258 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Multiply          |      5647.400 |  5671.097 |  7045.315 |  7399.725 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_AdvSimd           |               | 13222.322 | 13226.185 | 13233.450 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Avx2              |               |           |           |           |
| ShiftLeftConstBenchmark_Byte  | SumSLLTraits             |      5607.205 | 13235.621 | 13247.338 | 13227.773 |
| ShiftLeftConstBenchmark_Byte  | SumSLLTraits_Core        |     13118.993 | 15887.664 | 17003.282 | 19588.388 |
| ShiftLeftConstBenchmark_Byte  | SumSLLConstTraits        |     11208.733 | 13241.436 | 16994.514 | 19460.477 |
| ShiftLeftConstBenchmark_Byte  | SumSLLConstTraits_Core   |     14329.362 | 15885.257 | 16991.730 | 19447.305 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_Multiply      |      9832.305 |  9949.954 | 11125.190 | 11429.354 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_AdvSimd       |               | 15885.321 | 15895.407 | 19614.806 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_Avx2          |               |           |           |           |
| ShiftLeftConstBenchmark_Byte  | SumSLLFastTraits         |      9866.766 | 15886.532 | 15887.817 | 19553.951 |
| ShiftLeftConstBenchmark_Int16 | SumSLLScalar             |       603.857 |   607.135 |   607.105 |   821.851 |
| ShiftLeftConstBenchmark_Int16 | SumSLLNetBcl             |               |           |           |  9880.161 |
| ShiftLeftConstBenchmark_Int16 | SumSLLNetBcl_Const       |               |           |           |  9884.262 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Basic             |      3685.026 |  4233.448 |  5621.349 |  9901.496 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core         |      7356.050 |  7867.964 |  8333.205 |  9881.348 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core_Element |      3743.090 |  4286.400 |  4951.286 |  7206.607 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core_Mov     |      3694.994 |  3964.427 |  4920.346 |  7924.840 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Multiply          |      3727.278 |  4272.425 |  5613.295 |  6124.986 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_AdvSimd           |               |  6567.495 |  6548.788 |  6620.389 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Avx2              |               |           |           |           |
| ShiftLeftConstBenchmark_Int16 | SumSLLTraits             |      3824.256 |  6561.644 |  6537.762 |  9885.127 |
| ShiftLeftConstBenchmark_Int16 | SumSLLTraits_Core        |      8328.793 |  7892.546 |  7870.912 |  9881.255 |
| ShiftLeftConstBenchmark_Int16 | SumSLLConstTraits        |      7033.015 |  6635.069 |  7892.477 |  9850.836 |
| ShiftLeftConstBenchmark_Int16 | SumSLLConstTraits_Core   |      7838.663 |  7921.999 |  7886.939 |  9860.506 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_Multiply      |      4967.933 |  5526.437 |  6459.647 |  7061.733 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_AdvSimd       |               |  7861.443 |  7895.085 |  9862.607 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_Avx2          |               |           |           |           |
| ShiftLeftConstBenchmark_Int16 | SumSLLFastTraits         |      5505.719 |  7843.736 |  7866.037 |  9852.284 |
| ShiftLeftConstBenchmark_Int32 | SumSLLScalar             |       746.756 |   746.217 |   748.400 |  1406.943 |
| ShiftLeftConstBenchmark_Int32 | SumSLLNetBcl             |               |           |           |  4872.472 |
| ShiftLeftConstBenchmark_Int32 | SumSLLNetBcl_Const       |               |           |           |  4859.541 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Basic             |      3224.821 |  3205.170 |  2991.012 |  4862.536 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Base_Core         |      3780.691 |  4091.668 |  3852.914 |  4865.826 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Multiply          |      2858.966 |  3211.895 |  2990.129 |  3291.103 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_AdvSimd           |               |  3270.976 |  3504.041 |  3933.287 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Avx2              |               |           |           |           |
| ShiftLeftConstBenchmark_Int32 | SumSLLTraits             |      3222.900 |  3505.532 |  3249.259 |  4870.908 |
| ShiftLeftConstBenchmark_Int32 | SumSLLTraits_Core        |      4100.563 |  4114.834 |  3870.271 |  4825.955 |
| ShiftLeftConstBenchmark_Int32 | SumSLLConstTraits        |      3256.415 |  3846.424 |  3866.282 |  4832.987 |
| ShiftLeftConstBenchmark_Int32 | SumSLLConstTraits_Core   |      4088.318 |  3869.073 |  4105.409 |  4842.866 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_Multiply      |      3475.343 |  3229.223 |  3204.317 |  3393.409 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_AdvSimd       |               |  3264.295 |  4095.751 |  4843.690 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_Avx2          |               |           |           |           |
| ShiftLeftConstBenchmark_Int32 | SumSLLFastTraits         |      3253.603 |  3277.264 |  4105.693 |  4860.993 |
| ShiftLeftConstBenchmark_Int64 | SumSLLScalar             |       740.847 |   742.626 |   740.883 |  1372.433 |
| ShiftLeftConstBenchmark_Int64 | SumSLLNetBcl             |               |           |           |  2447.827 |
| ShiftLeftConstBenchmark_Int64 | SumSLLNetBcl_Const       |               |           |           |  2465.779 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Basic             |       486.110 |   483.299 |   483.891 |  2462.489 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Base_Core         |       477.910 |   478.587 |   483.730 |  2463.136 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_AdvSimd           |               |  1637.381 |  1637.409 |  1980.659 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Avx2              |               |           |           |           |
| ShiftLeftConstBenchmark_Int64 | SumSLLTraits             |       486.412 |  1634.506 |  1636.045 |  1980.563 |
| ShiftLeftConstBenchmark_Int64 | SumSLLTraits_Core        |       483.900 |  1969.717 |  1970.279 |  2467.329 |
| ShiftLeftConstBenchmark_Int64 | SumSLLConstTraits        |       468.705 |  1954.213 |  1969.238 |  2462.272 |
| ShiftLeftConstBenchmark_Int64 | SumSLLConstTraits_Core   |       467.634 |  1970.938 |  1972.121 |  2466.961 |
| ShiftLeftConstBenchmark_Int64 | SumSLLFast_AdvSimd       |               |  1953.192 |  2097.162 |  2465.009 |
| ShiftLeftConstBenchmark_Int64 | SumSLLFast_Avx2          |               |           |           |           |
| ShiftLeftConstBenchmark_Int64 | SumSLLFastTraits         |       467.601 |  1644.716 |  1969.802 |  2461.104 |
