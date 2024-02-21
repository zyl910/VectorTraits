# Benchmark group - ShiftRightLogical
([← Back](ShiftRightLogical.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### X86 - Intel Core i5-8250U
| Type                                   | Method                    | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :------------------------------------- | :------------------------ | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLScalar              |        860.708 |       859.184 |      1124.267 |  1124.419 |  1401.674 |  1625.360 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLNetBcl              |                |               |               |           |           |  1178.641 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLNetBcl_Const        |                |               |               |           |           |  1178.088 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Basic              |       3482.636 |      3391.803 |      3503.398 |  3595.065 |  3515.958 | 23441.151 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Base_Core          |       3444.402 |      3482.122 |      3453.035 |  3597.632 |  3513.345 | 23325.467 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_AdvSimd            |                |               |               |           |           |           |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Avx2               |                |               |     22498.329 | 21158.115 | 22363.691 | 25077.580 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLTraits              |       3511.384 |      3459.909 |     21430.778 | 22348.406 | 22347.107 | 25064.421 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLTraits_Core         |       3312.182 |      3512.213 |     42371.740 | 38940.425 | 38922.939 | 38779.830 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLConstTraits         |       3681.307 |      3984.333 |     26732.259 | 32406.520 | 41480.463 | 31554.277 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLConstTraits_Core    |       3679.763 |      3991.424 |     42371.681 | 38927.011 | 38976.774 | 42041.736 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128Traits           |                |               |     11273.585 | 11283.140 | 11326.038 | 13373.965 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128Traits_Core      |                |               |     22707.966 | 23114.473 | 23105.048 | 21149.430 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128ConstTraits      |                |               |     13373.228 | 22537.410 | 24004.174 | 21058.754 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128ConstTraits_Core |                |               |     23085.285 | 23034.984 | 23037.629 | 21076.848 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFast_AdvSimd        |                |               |               |           |           |           |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFast_Avx2           |                |               |     26894.410 | 35221.999 | 37623.123 | 37755.611 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFastTraits          |       3578.692 |      3711.903 |     26816.824 | 35097.841 | 37507.716 | 37615.945 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLScalar              |        842.123 |       842.452 |      1197.405 |  1192.777 |  1405.020 |  1630.456 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLNetBcl              |                |               |               |           |           | 20810.187 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLNetBcl_Const        |                |               |               |           |           | 22950.040 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Basic              |       1742.900 |      1712.144 |      1715.282 |  1778.594 |  1744.197 | 20769.333 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Base_Core          |       1727.160 |      1742.983 |      1731.832 |  1788.865 |  1740.990 | 19536.778 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_AdvSimd            |                |               |               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Avx2               |                |               |     18742.928 | 18828.496 | 19471.763 | 17830.372 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLTraits              |       1758.457 |      1733.595 |     18269.521 | 18657.899 | 19427.799 | 18326.875 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLTraits_Core         |       1683.654 |      1753.028 |     19012.074 | 22551.415 | 22553.645 | 19476.074 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLConstTraits         |       1841.928 |      2002.238 |     18526.821 | 22290.091 | 23567.158 | 22752.658 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLConstTraits_Core    |       1842.261 |      2000.354 |     22406.662 | 21164.821 | 24273.169 | 22760.503 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128Traits           |                |               |     10663.254 | 10678.717 | 10674.785 | 11066.687 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128Traits_Core      |                |               |     12390.775 | 12251.695 | 12416.879 | 11689.107 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128ConstTraits      |                |               |     11074.842 | 12372.903 | 12963.102 | 12277.972 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128ConstTraits_Core |                |               |     12402.444 | 12374.374 | 13689.134 | 12620.601 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFast_AdvSimd        |                |               |               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFast_Avx2           |                |               |     20031.053 | 22244.068 | 19796.466 | 20557.871 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFastTraits          |       1792.157 |      1857.651 |     19515.046 | 21581.651 | 19377.471 | 19347.959 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLScalar              |        840.232 |       841.290 |      1352.612 |  1352.975 |  1646.634 |  2251.479 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLNetBcl              |                |               |               |           |           | 10405.918 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLNetBcl_Const        |                |               |               |           |           | 11777.083 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Basic              |        870.254 |       864.736 |       877.136 |   901.214 |   879.845 |  9604.887 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Base_Core          |        864.336 |       863.905 |       878.099 |   900.454 |   878.228 |  9732.781 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_AdvSimd            |                |               |               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Avx2               |                |               |      9362.615 |  9207.784 |  9201.105 |  8995.293 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLTraits              |        865.963 |       864.663 |      9886.217 |  9078.617 |  9168.072 |  9835.703 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLTraits_Core         |        866.250 |       864.007 |     10763.813 | 11237.730 | 11568.403 | 11234.864 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLConstTraits         |        920.621 |       999.262 |      9896.420 | 10401.660 | 10701.916 | 11279.942 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLConstTraits_Core    |        921.315 |      1000.621 |     11971.914 | 11534.917 | 11257.117 | 11458.321 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128Traits           |                |               |      5352.578 |  5021.805 |  5355.734 |  5652.604 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128Traits_Core      |                |               |      6451.066 |  6552.349 |  6551.525 |  6152.423 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128ConstTraits      |                |               |      5557.668 |  6248.058 |  6555.543 |  6117.871 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128ConstTraits_Core |                |               |      6539.178 |  6698.201 |  6565.484 |  6129.746 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFast_AdvSimd        |                |               |               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFast_Avx2           |                |               |     10514.538 | 11026.398 | 10210.506 | 10030.468 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFastTraits          |        896.177 |       931.659 |     10505.602 | 10335.612 | 10359.040 | 10200.001 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLScalar              |        836.917 |       836.937 |      1303.085 |  1348.224 |  1351.173 |  1683.247 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLNetBcl              |                |               |               |           |           |  5107.877 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLNetBcl_Const        |                |               |               |           |           |  5753.125 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Basic              |        451.286 |       448.975 |       489.150 |   468.214 |   488.011 |  4877.338 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Base_Core          |        438.329 |       472.070 |       488.306 |   467.666 |   490.140 |  4907.489 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_AdvSimd            |                |               |               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Avx2               |                |               |      4633.662 |  4704.132 |  4888.515 |  4129.910 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLTraits              |        451.022 |       472.630 |      4603.809 |  4907.109 |  4927.812 |  4356.584 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLTraits_Core         |        457.530 |       471.891 |      5847.583 |  5788.063 |  5899.802 |  5656.123 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLConstTraits         |        500.601 |       545.241 |      4555.211 |  4711.067 |  5187.960 |  5113.821 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLConstTraits_Core    |        500.682 |       546.563 |      5320.140 |  5639.746 |  5279.033 |  5576.720 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128Traits           |                |               |      2669.587 |  2640.540 |  2664.826 |  2600.020 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128Traits_Core      |                |               |      3522.583 |  3219.510 |  3409.562 |  3338.540 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128ConstTraits      |                |               |      2781.894 |  2787.046 |  3245.938 |  3071.486 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128ConstTraits_Core |                |               |      3254.929 |  3288.192 |  3221.531 |  3135.444 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFast_AdvSimd        |                |               |               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFast_Avx2           |                |               |      5042.779 |  5372.972 |  5365.849 |  5091.406 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFastTraits          |        486.667 |       504.534 |      4852.310 |  4993.147 |  5190.052 |  5004.310 |

### Arm - AWS Arm t4g.small
| Type                                   | Method                    | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :------------------------------------- | :------------------------ | ------------: | --------: | --------: | --------: |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLScalar              |       610.440 |   611.068 |   653.301 |   925.069 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLNetBcl              |               |           |           | 19526.683 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLNetBcl_Const        |               |           |           | 19527.125 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Basic              |      3522.345 |  3576.642 |  1517.947 |  7944.581 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Base_Core          |      3524.622 |  3576.022 |  1489.862 |  7925.434 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_AdvSimd            |               | 11892.353 | 11291.053 | 13135.329 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Avx2               |               |           |           |           |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLTraits              |      3794.990 | 11367.866 | 11854.758 | 13150.471 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLTraits_Core         |      3786.531 | 15887.374 | 16931.012 | 19512.920 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLConstTraits         |      3895.547 | 13254.468 | 16929.335 | 19416.639 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLConstTraits_Core    |      3875.003 | 15889.018 | 15854.083 | 19416.358 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128Traits           |       462.520 | 11908.536 | 11902.879 | 13154.059 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128Traits_Core      |       466.298 | 15835.768 | 15793.090 | 19515.757 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128ConstTraits      |       464.774 | 15844.426 | 16914.199 | 19404.393 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128ConstTraits_Core |       464.907 | 15859.491 | 16898.840 | 19395.451 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFast_AdvSimd        |               | 13207.837 | 16956.112 | 19579.055 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFast_Avx2           |               |           |           |           |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFastTraits          |      3874.840 | 13212.078 | 16956.265 | 19516.840 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLScalar              |       606.922 |   606.062 |   604.075 |   822.934 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLNetBcl              |               |           |           |  9805.972 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLNetBcl_Const        |               |           |           |  9806.457 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Basic              |      1767.201 |  1787.808 |  1771.186 |  9817.130 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Base_Core          |      1769.150 |  1782.443 |   823.786 |  9792.583 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_AdvSimd            |               |  5941.433 |  5892.797 |  6584.266 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Avx2               |               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLTraits              |      1883.644 |  5971.707 |  5901.827 |  9806.873 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLTraits_Core         |      1888.758 |  7952.247 |  7835.431 |  9809.512 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLConstTraits         |      1927.803 |  1249.623 |  7845.444 |  9747.796 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLConstTraits_Core    |      1927.897 |  7957.828 |  7834.350 |  9742.182 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128Traits           |       295.401 |  5679.936 |  5902.850 |  9792.525 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128Traits_Core      |       298.497 |  7938.871 |  8320.033 |  9791.252 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128ConstTraits      |       293.517 |  1248.756 |  7792.567 |  9729.161 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128ConstTraits_Core |       293.774 |  7940.466 |  8306.434 |  9728.222 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFast_AdvSimd        |               |  6609.521 |  8340.868 |  9797.920 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFast_Avx2           |               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFastTraits          |      1911.139 |  7953.825 |  7814.332 |  9820.527 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLScalar              |       749.805 |   747.568 |   741.975 |  1170.115 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLNetBcl              |               |           |           |  4771.051 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLNetBcl_Const        |               |           |           |  4776.363 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Basic              |       952.751 |   976.939 |   967.911 |  4777.290 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Base_Core          |       952.229 |   975.116 |   967.333 |  4759.469 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_AdvSimd            |               |  3283.631 |  3262.002 |  3285.996 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Avx2               |               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLTraits              |       944.328 |  3292.010 |  3272.067 |  4774.267 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLTraits_Core         |       945.949 |  3934.975 |  4175.823 |  4770.997 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLConstTraits         |       952.870 |  3933.740 |  3917.508 |  4733.043 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLConstTraits_Core    |       954.282 |  3935.683 |  3923.493 |  4743.864 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128Traits           |       183.110 |  3282.675 |  3273.167 |  4776.961 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128Traits_Core      |       183.053 |  4190.520 |  4167.244 |  4776.351 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128ConstTraits      |       183.033 |  3925.599 |  4169.417 |  4734.876 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128ConstTraits_Core |       183.041 |  4198.127 |  3913.322 |  4743.023 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFast_AdvSimd        |               |  3932.311 |  4161.691 |  4781.043 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFast_Avx2           |               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFastTraits          |       967.210 |  3923.614 |  3917.982 |  4773.527 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLScalar              |       742.433 |   739.881 |   739.075 |  1192.022 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLNetBcl              |               |           |           |  2437.007 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLNetBcl_Const        |               |           |           |  2438.554 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Basic              |       478.629 |   486.457 |   481.770 |  2436.375 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Base_Core          |       485.350 |   483.676 |   481.629 |  2432.922 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_AdvSimd            |               |  1414.415 |  1479.955 |  1646.618 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Avx2               |               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLTraits              |       468.098 |  1420.642 |  1486.629 |  1649.062 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLTraits_Core         |       470.677 |  2123.873 |  1968.333 |  2435.511 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLConstTraits         |       467.839 |  1983.810 |  1964.318 |  2429.675 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLConstTraits_Core    |       468.965 |  1981.799 |  2110.022 |  2435.217 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128Traits           |       270.583 |  1416.889 |  1478.744 |  1649.302 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128Traits_Core      |       275.935 |  1982.015 |  2093.517 |  2412.091 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128ConstTraits      |       273.560 |  1972.904 |  1972.086 |  2430.599 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128ConstTraits_Core |       276.181 |  2112.151 |  1968.082 |  2435.059 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFast_AdvSimd        |               |  1978.634 |  1647.634 |  2410.698 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFast_Avx2           |               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFastTraits          |       469.657 |  1984.034 |  1648.839 |  2412.110 |

