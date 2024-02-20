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
| Type                                   | Method                 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :------------------------------------- | :--------------------- | ------------: | --------: | --------: | --------: |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLScalar           |       609.971 |   610.843 |   654.575 |   890.839 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLNetBcl           |               |           |           | 19586.726 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLNetBcl_Const     |               |           |           | 19590.775 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Basic           |      3535.363 |  3580.168 |  3569.164 |  7933.745 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Base_Core       |      3537.350 |  3664.403 |  3616.444 |  7930.950 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_AdvSimd         |               | 11345.178 | 11338.244 | 13165.746 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Avx2            |               |           |           |           |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLTraits           |      3741.637 | 11913.021 | 11355.501 | 13175.619 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLTraits_Core      |      3738.350 | 16982.614 | 15872.815 | 19580.851 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLConstTraits      |      3823.629 | 15882.629 | 15867.157 | 19447.280 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLConstTraits_Core |      3824.594 | 16997.625 | 16974.903 | 19432.662 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFast_AdvSimd     |               | 15868.754 | 17003.082 | 19603.444 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFast_Avx2        |               |           |           |           |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFastTraits       |      3803.316 | 15886.504 | 16996.865 | 19568.992 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLScalar           |       606.641 |   607.225 |   606.715 |   820.618 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLNetBcl           |               |           |           |  9505.360 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLNetBcl_Const     |               |           |           |  9508.811 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Basic           |      1767.420 |  1798.180 |  1778.601 |  9521.524 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Base_Core       |      1765.596 |  1787.371 |  1793.904 |  9503.337 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_AdvSimd         |               |  5673.453 |  5929.012 |  6511.443 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Avx2            |               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLTraits           |      1891.842 |  5681.334 |  5940.648 |  9505.102 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLTraits_Core      |      1893.230 |  8484.151 |  7879.072 |  9509.063 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLConstTraits      |      1919.649 |  1250.372 |  7884.014 |  9442.549 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLConstTraits_Core |      1921.276 |  8473.922 |  7875.343 |  9439.698 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFast_AdvSimd     |               |  7921.829 |  7862.685 |  9522.792 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFast_Avx2        |               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFastTraits       |      1915.946 |  6611.060 |  8390.470 |  9510.709 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLScalar           |       747.766 |   746.570 |   748.934 |  1169.981 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLNetBcl           |               |           |           |  4758.308 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLNetBcl_Const     |               |           |           |  4747.163 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Basic           |       949.905 |   976.257 |   975.748 |  4746.886 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Base_Core       |       385.962 |   978.606 |   975.768 |  4751.345 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_AdvSimd         |               |  3274.991 |  3279.505 |  3280.461 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Avx2            |               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLTraits           |       938.073 |  3276.459 |  3280.786 |  4737.385 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLTraits_Core      |       938.379 |  3901.594 |  4180.485 |  4753.624 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLConstTraits      |       947.631 |  3896.249 |  3916.718 |  4717.740 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLConstTraits_Core |       959.031 |  3902.825 |  3923.265 |  4709.911 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFast_AdvSimd     |               |  3880.117 |  4172.700 |  4736.323 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFast_Avx2        |               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFastTraits       |       962.467 |  3888.059 |  3919.469 |  4749.435 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLScalar           |       740.429 |   741.494 |   742.373 |  1189.752 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLNetBcl           |               |           |           |  2434.417 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLNetBcl_Const     |               |           |           |  2434.110 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Basic           |       485.800 |   484.430 |   487.105 |  2423.514 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Base_Core       |       490.624 |   484.508 |   476.591 |  2352.692 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_AdvSimd         |               |  1419.077 |  1419.860 |  1633.169 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Avx2            |               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLTraits           |       471.315 |  1420.603 |  1420.872 |  1648.802 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLTraits_Core      |       471.172 |  2120.369 |  2122.190 |  2390.895 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLConstTraits      |       470.183 |  1974.648 |  2120.920 |  2410.270 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLConstTraits_Core |       470.207 |  1981.918 |  1982.508 |  2399.429 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFast_AdvSimd     |               |  1977.193 |  1654.524 |  2379.890 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFast_Avx2        |               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFastTraits       |       470.075 |  1980.220 |  1654.040 |  2380.027 |

