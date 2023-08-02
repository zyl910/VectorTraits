# Benchmark group - ShiftRightLogical
([← Back](ShiftRightLogical.md))

Cell unit: Million operations per second.

### x86 - lntel Core i5-8250U
| Class                                  | Method                 | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :------------------------------------- | :--------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLScalar           |        676.636 |       708.130 |       933.951 |   953.066 |  1141.269 |  1317.919 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLNetBcl           |                |               |               |           |           |   614.064 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLNetBcl_Const     |                |               |               |           |           |   979.279 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Basic           |       2712.984 |      2764.181 |      2739.860 |  2969.480 |  2274.348 | 18234.177 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Base_Core       |       2822.861 |      2787.810 |      2832.429 |  2963.524 |  2836.866 | 18203.678 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_AdvSimd         |                |               |               |           |           |           |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Avx2            |                |               |     16927.856 | 17639.587 | 17322.205 | 19503.269 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLTraits           |       2763.121 |      2813.433 |     17089.946 | 17646.018 | 16906.401 | 19523.368 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLTraits_Core      |       2765.412 |      2738.805 |     33131.684 | 31125.478 | 29301.316 | 30049.183 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLConstTraits      |       3290.487 |      3266.420 |     21290.313 | 25728.183 | 32205.636 | 25769.708 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLConstTraits_Core |       3397.125 |      3254.282 |     33122.707 | 30397.182 | 29922.054 | 32908.088 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFast_AdvSimd     |                |               |               |           |           |           |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFast_Avx2        |                |               |     20884.136 | 27106.210 | 29286.890 | 28868.622 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFastTraits       |       3101.489 |      2959.432 |     20825.814 | 27781.507 | 29353.797 | 28745.911 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLScalar           |        686.987 |       672.940 |       949.876 |   954.735 |  1132.513 |  1322.004 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLNetBcl           |                |               |               |           |           | 14809.776 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLNetBcl_Const     |                |               |               |           |           | 18092.546 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Basic           |       1399.415 |      1391.336 |      1370.037 |  1493.871 |  1446.483 | 15609.970 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Base_Core       |       1428.099 |      1404.558 |      1339.424 |  1229.047 |  1453.755 | 14680.034 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_AdvSimd         |                |               |               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Avx2            |                |               |     13456.086 | 11805.536 | 14522.419 | 13758.862 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLTraits           |       1443.467 |      1370.414 |     13835.850 | 14325.129 | 12000.746 | 14574.237 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLTraits_Core      |       1326.763 |      1402.270 |     15607.688 | 13486.406 | 16820.279 | 15497.392 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLConstTraits      |       1707.216 |      1709.098 |     13726.661 | 13055.716 | 17456.865 | 17506.501 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLConstTraits_Core |       1681.437 |      1697.491 |     15845.440 | 13154.944 | 18354.993 | 16350.743 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFast_AdvSimd     |                |               |               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFast_Avx2        |                |               |     14239.876 | 12567.213 | 15310.185 | 14433.111 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFastTraits       |       1550.767 |      1551.263 |     14810.041 | 12223.604 | 15733.755 | 14527.394 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLScalar           |        695.950 |       700.561 |      1090.632 |   646.744 |  1380.535 |  1344.719 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLNetBcl           |                |               |               |           |           |  7313.562 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLNetBcl_Const     |                |               |               |           |           |  8922.247 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Basic           |        710.412 |       711.251 |       667.100 |   552.780 |   737.186 |  7597.169 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Base_Core       |        711.064 |       692.471 |       679.439 |   507.629 |   752.136 |  6669.024 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_AdvSimd         |                |               |               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Avx2            |                |               |      6626.788 |  4311.531 |  6867.337 |  6299.407 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLTraits           |        722.908 |       686.018 |      7295.258 |  3834.455 |  6848.619 |  6713.570 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLTraits_Core      |        731.994 |       690.576 |      7790.768 |  6993.301 |  9056.677 |  8656.923 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLConstTraits      |        851.818 |       847.091 |      7104.290 |  8071.843 |  8729.219 |  7526.184 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLConstTraits_Core |        850.620 |       856.251 |      8340.662 |  9120.339 |  8247.695 |  8775.590 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFast_AdvSimd     |                |               |               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFast_Avx2        |                |               |      7594.773 |  8137.778 |  7156.965 |  7541.490 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFastTraits       |        781.691 |       603.450 |      7320.504 |  5105.923 |  7904.437 |  7353.749 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLScalar           |        677.784 |       678.091 |      1061.761 |  1079.662 |  1070.000 |  1333.139 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLNetBcl           |                |               |               |           |           |  3720.209 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLNetBcl_Const     |                |               |               |           |           |  4333.666 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Basic           |        373.057 |       394.003 |       389.535 |   373.421 |   393.138 |  3764.647 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Base_Core       |        389.792 |       371.337 |       395.483 |   371.796 |   388.349 |  3807.459 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_AdvSimd         |                |               |               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Avx2            |                |               |      3361.730 |  3334.543 |  3481.718 |  3380.790 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLTraits           |        383.544 |       374.939 |      3365.101 |  2915.849 |  3373.438 |  3333.889 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLTraits_Core      |        368.325 |       389.865 |      4367.611 |  4204.078 |  4310.722 |  4063.224 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLConstTraits      |        465.597 |       465.793 |      3466.271 |  3545.798 |  4375.220 |  4353.153 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLConstTraits_Core |        463.295 |       385.057 |      4076.087 |  4094.998 |  4589.524 |  4024.723 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFast_AdvSimd     |                |               |               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFast_Avx2        |                |               |      3682.970 |  3653.751 |  3715.074 |  3765.448 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFastTraits       |        404.966 |       417.011 |      3526.183 |  3922.846 |  4082.896 |  3690.236 |

### Arm - AWS Arm t4g.small
| Class                                  | Method                 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
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
