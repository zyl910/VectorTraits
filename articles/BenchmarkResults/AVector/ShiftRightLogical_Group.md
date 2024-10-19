# Benchmark group - ShiftRightLogical
([← Back](ShiftRightLogical.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### X86 - AMD Ryzen 7 7840H
| Type                                   | Method                    | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :------------------------------------- | :------------------------ | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLScalar              |       1071.450 |      1016.697 |      1273.997 |  1272.279 |  1376.976 |  1504.284 |  1563.454 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLNetBcl              |                |               |               |           |           |  1317.770 |  1191.199 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLNetBcl_Const        |                |               |               |           |           |  1351.804 |  1290.428 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Basic              |       3839.507 |      3672.868 |      4092.590 |  3916.065 |  4089.363 | 27717.606 | 28795.947 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Base_Core          |       3894.138 |      3683.206 |      4094.072 |  3911.362 |  4046.455 | 24606.713 | 61710.711 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_AdvSimd            |                |               |               |           |           |           |           |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Avx2               |                |               |     27459.932 | 26508.358 | 28252.736 | 28458.224 | 62019.636 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLTraits              |       3854.585 |      3662.265 |     27698.459 | 28069.566 | 26773.205 | 27799.744 | 58606.409 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLTraits_Core         |       3854.872 |      3697.576 |     54318.092 | 64315.896 | 69667.070 | 67442.052 | 59215.221 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLConstTraits         |       3923.294 |      4021.272 |     32953.039 | 56872.527 | 63174.538 | 60709.326 | 59045.413 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLConstTraits_Core    |       3928.770 |      4016.501 |     56659.658 | 66593.174 | 70656.395 | 48757.214 | 60558.842 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128Bcl              |                |               |               |           |           |  1139.538 | 31304.820 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128Traits           |                |               |     14089.082 | 14118.663 | 14026.701 | 14461.197 | 33820.788 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128Traits_Core      |                |               |     35778.968 | 36145.991 | 37267.956 | 36792.382 | 32395.655 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128ConstTraits      |                |               |     17242.305 | 31510.477 | 34407.197 | 32576.616 | 35159.169 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128ConstTraits_Core |                |               |     35612.483 | 34420.833 | 34720.105 | 27929.106 | 32469.562 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL512Bcl              |                |               |               |           |           |           | 83375.675 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL512Traits           |                |               |               |           |           |           | 82559.438 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFast_AdvSimd        |                |               |               |           |           |           |           |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFast_Avx2           |                |               |     34064.026 | 51738.033 | 62365.889 | 64115.912 | 58562.286 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFastTraits          |       3966.581 |      4038.706 |     34009.663 | 51167.202 | 61839.933 | 57899.087 | 61081.627 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLScalar              |       1254.596 |      1161.779 |      1452.172 |  1339.479 |  1358.332 |  1470.442 |  1566.632 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLNetBcl              |                |               |               |           |           | 31642.174 | 35464.642 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLNetBcl_Const        |                |               |               |           |           | 36282.651 | 36418.354 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Basic              |       1918.488 |      1835.475 |      2032.977 |  1959.531 |  2053.127 | 32089.512 | 35894.516 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Base_Core          |       1918.802 |      1823.582 |      2034.294 |  1956.428 |  2041.286 | 30763.957 | 37675.350 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_AdvSimd            |                |               |               |           |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Avx2               |                |               |     25781.614 | 26469.444 | 26867.839 | 27077.410 | 29155.023 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLTraits              |       1948.179 |      1843.168 |     25620.862 | 28328.689 | 26938.107 | 30921.940 | 36243.188 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLTraits_Core         |       1923.033 |      1848.126 |     35468.107 | 39089.479 | 37022.833 | 36421.851 | 35020.924 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLConstTraits         |       1948.901 |      2020.348 |     27472.547 | 37360.705 | 37608.314 | 33548.043 | 36989.736 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLConstTraits_Core    |       1963.184 |      2021.805 |     30288.080 | 37956.778 | 42016.713 | 33639.639 | 37736.310 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128Bcl              |                |               |               |           |           | 15385.905 | 19547.373 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128Traits           |                |               |     13773.261 | 13027.141 | 14394.549 | 14601.264 | 19809.393 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128Traits_Core      |                |               |     18514.880 | 19336.784 | 19307.874 | 19143.922 | 18421.237 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128ConstTraits      |                |               |     14482.487 | 18789.528 | 19072.700 | 21678.958 | 20291.893 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128ConstTraits_Core |                |               |     19547.279 | 18625.629 | 20985.247 | 23017.465 | 19951.472 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL512Bcl              |                |               |               |           |           |           | 44264.320 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL512Traits           |                |               |               |           |           |           | 40553.403 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFast_AdvSimd        |                |               |               |           |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFast_Avx2           |                |               |     28280.799 | 40254.330 | 32953.026 | 33599.601 | 35278.477 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFastTraits          |       1964.476 |      2011.653 |     28777.743 | 37820.967 | 32129.782 | 33077.751 | 36876.759 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLScalar              |       1367.956 |      1301.164 |      1501.828 |  1533.168 |  2268.257 |  2674.573 |  2440.487 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLNetBcl              |                |               |               |           |           | 15200.063 | 16324.025 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLNetBcl_Const        |                |               |               |           |           | 19297.750 | 16097.869 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Basic              |        957.543 |       916.812 |      1008.531 |   974.623 |  1013.019 | 16137.919 | 16528.451 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Base_Core          |        960.705 |       917.034 |      1011.560 |   970.955 |  1001.900 | 16927.365 | 17173.835 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_AdvSimd            |                |               |               |           |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Avx2               |                |               |     13060.531 | 13235.603 | 12247.979 | 15141.329 | 15712.209 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLTraits              |        954.057 |       927.557 |     13062.138 | 12523.984 | 12678.623 | 16835.230 | 16488.228 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLTraits_Core         |        960.141 |       910.222 |     14401.145 | 17158.387 | 17508.085 | 21912.344 | 10891.195 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLConstTraits         |        976.460 |      1010.097 |     12976.550 | 16982.393 | 14923.617 | 18972.665 | 16309.545 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLConstTraits_Core    |        981.270 |      1015.983 |     16269.516 | 16909.688 | 17202.062 | 22286.162 | 17007.551 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128Bcl              |                |               |               |           |           |  8692.401 |  9734.959 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128Traits           |                |               |      7211.591 |  6880.901 |  6618.504 |  8798.034 |  9980.375 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128Traits_Core      |                |               |      9192.591 | 10565.325 |  9972.380 | 12604.248 |  8991.265 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128ConstTraits      |                |               |      6880.585 |  9134.580 | 10143.441 | 12552.657 |  9826.581 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128ConstTraits_Core |                |               |     10142.877 |  9357.837 |  9894.639 | 12645.572 |  9831.511 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL512Bcl              |                |               |               |           |           |           | 19035.087 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL512Traits           |                |               |               |           |           |           | 20000.185 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFast_AdvSimd        |                |               |               |           |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFast_Avx2           |                |               |     12907.105 | 14701.111 | 14312.420 | 17467.507 | 16891.141 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFastTraits          |        978.120 |       999.612 |     13492.599 | 16911.852 | 14845.286 | 17338.025 | 16682.732 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLScalar              |       1335.712 |      1320.254 |      1530.239 |  1522.594 |  1555.359 |  2009.797 |  2369.881 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLNetBcl              |                |               |               |           |           |  9270.109 |  8520.374 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLNetBcl_Const        |                |               |               |           |           |  9665.721 |  8426.164 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Basic              |        477.982 |       495.771 |       523.150 |   503.949 |   529.869 |  9234.295 |  8658.088 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Base_Core          |        483.834 |       492.078 |       519.827 |   502.068 |   527.376 |  9161.493 |  8401.351 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_AdvSimd            |                |               |               |           |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Avx2               |                |               |      6680.672 |  6824.523 |  6777.002 |  7881.587 |  7580.151 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLTraits              |        479.804 |       497.525 |      6921.715 |  6896.360 |  6831.651 |  7846.139 |  7797.205 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLTraits_Core         |        480.201 |       490.528 |      7484.619 |  9556.599 |  9620.412 |  9410.686 |  7623.647 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLConstTraits         |        513.766 |       530.503 |      6628.095 |  6945.512 |  8676.926 |  9542.190 |  8709.090 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLConstTraits_Core    |        512.561 |       530.020 |      8026.545 |  9036.565 |  9259.167 |  9574.697 |  8450.977 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128Bcl              |                |               |               |           |           |  4336.025 |  5204.002 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128Traits           |                |               |      3635.775 |  3560.299 |  3427.809 |  4106.045 |  4691.168 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128Traits_Core      |                |               |      5388.843 |  4886.756 |  5023.916 |  5825.882 |  4941.696 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128ConstTraits      |                |               |      3712.366 |  3821.824 |  4998.155 |  5912.267 |  5287.436 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128ConstTraits_Core |                |               |      5018.612 |  5332.192 |  5095.346 |  6004.927 |  4941.188 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL512Bcl              |                |               |               |           |           |           |  9709.909 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL512Traits           |                |               |               |           |           |           |  8056.250 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFast_AdvSimd        |                |               |               |           |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFast_Avx2           |                |               |      7939.279 |  8257.378 |  8252.130 |  7396.176 |  8357.741 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFastTraits          |        514.896 |       527.301 |      7235.105 |  8094.199 |  8283.851 |  8244.283 |  8625.462 |

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

### Arm - Apple M2
| Type                                   | Method                    |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :------------------------------------- | :------------------------ | --------: | --------: | --------: |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLScalar              |  1688.629 |  1690.503 |  1166.296 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLNetBcl              |           | 27232.144 | 27252.985 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLNetBcl_Const        |           | 27239.662 | 27250.616 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Basic              | 10607.474 | 21719.251 | 24137.417 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Base_Core          | 10605.572 | 21702.895 | 27246.144 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_AdvSimd            | 27166.365 | 27186.879 | 27254.525 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Avx2               |           |           |           |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLTraits              | 27178.127 | 27192.221 | 27250.813 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLTraits_Core         | 27242.883 | 27237.843 | 27253.427 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLConstTraits         | 27242.336 | 27240.049 | 27255.594 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLConstTraits_Core    | 27245.052 | 27243.736 | 27256.646 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128Bcl              |           | 27238.161 | 27258.084 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128Traits           | 27171.259 | 27188.409 | 27254.462 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128Traits_Core      | 27239.818 | 27238.587 | 27259.644 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128ConstTraits      | 27237.085 | 27242.811 | 27257.768 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128ConstTraits_Core | 27240.584 | 27238.765 | 27248.360 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL512Bcl              |           |           | 90350.504 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL512Traits           |           |           | 90322.452 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFast_AdvSimd        | 27244.526 | 27248.202 | 27253.449 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFast_Avx2           |           |           |           |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFastTraits          | 27243.732 | 27243.576 | 27253.398 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLScalar              |  1658.483 |  1690.261 |  1165.666 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLNetBcl              |           | 13617.151 | 13617.801 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLNetBcl_Const        |           | 13617.156 | 13614.849 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Basic              |  5306.264 | 13616.291 | 13613.890 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Base_Core          |  5304.910 | 13613.034 | 13618.195 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_AdvSimd            | 13592.374 | 13599.586 | 13617.727 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Avx2               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLTraits              | 13596.215 | 13613.593 | 13616.084 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLTraits_Core         | 13610.939 | 13611.098 | 13614.865 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLConstTraits         | 13615.291 | 13613.296 | 13614.417 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLConstTraits_Core    | 13612.578 | 13612.304 | 13617.158 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128Bcl              |           | 13612.325 | 13614.329 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128Traits           | 13580.995 | 13612.202 | 13616.317 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128Traits_Core      | 13612.101 | 13614.051 | 13614.819 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128ConstTraits      | 13611.184 | 13612.664 | 13616.120 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128ConstTraits_Core | 13614.566 | 13611.217 | 13619.579 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL512Bcl              |           |           | 45750.202 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL512Traits           |           |           | 45750.860 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFast_AdvSimd        | 13610.269 | 13614.752 | 13615.534 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFast_Avx2           |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFastTraits          | 13611.092 | 13612.703 | 13617.139 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLScalar              |  1731.498 |  2299.889 |  1747.304 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLNetBcl              |           |  6805.128 |  6805.915 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLNetBcl_Const        |           |  6804.595 |  6806.831 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Basic              |  2863.675 |  6805.870 |  6805.892 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Base_Core          |  2863.789 |  6805.049 |  6806.686 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_AdvSimd            |  6801.702 |  6803.527 |  6806.153 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Avx2               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLTraits              |  6800.823 |  6804.278 |  6805.359 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLTraits_Core         |  6806.345 |  6804.215 |  6806.141 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLConstTraits         |  6805.334 |  6805.524 |  6805.874 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLConstTraits_Core    |  6804.776 |  6805.142 |  6805.597 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128Bcl              |           |  6804.888 |  6806.950 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128Traits           |  6801.102 |  6805.669 |  6806.608 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128Traits_Core      |  6804.298 |  6805.048 |  6805.854 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128ConstTraits      |  6804.239 |  6804.734 |  6806.359 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128ConstTraits_Core |  6804.456 |  6804.416 |  6806.647 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL512Bcl              |           |           | 22936.419 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL512Traits           |           |           | 22934.782 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFast_AdvSimd        |  6804.706 |  6805.135 |  6806.769 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFast_Avx2           |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFastTraits          |  6804.609 |  6805.422 |  6807.287 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLScalar              |  1720.232 |  2260.330 |  1699.773 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLNetBcl              |           |  3402.464 |  3402.412 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLNetBcl_Const        |           |  3401.641 |  3401.847 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Basic              |  1648.737 |  3401.627 |  3401.379 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Base_Core          |  1648.471 |  3402.325 |  3402.274 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_AdvSimd            |  3399.925 |  3400.747 |  3401.665 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Avx2               |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLTraits              |  3400.360 |  3401.131 |  3402.272 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLTraits_Core         |  3401.510 |  3401.194 |  3402.674 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLConstTraits         |  3401.076 |  3401.789 |  3401.830 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLConstTraits_Core    |  3402.031 |  3401.876 |  3402.213 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128Bcl              |           |  3402.460 |  3402.464 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128Traits           |  3399.868 |  3400.491 |  3401.794 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128Traits_Core      |  3401.143 |  3401.441 |  3402.385 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128ConstTraits      |  3401.473 |  3401.356 |  3401.928 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128ConstTraits_Core |  3400.980 |  3402.016 |  3402.009 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL512Bcl              |           |           | 11503.458 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL512Traits           |           |           | 11504.614 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFast_AdvSimd        |  3401.142 |  3401.942 |  3402.086 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFast_Avx2           |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFastTraits          |  3401.912 |  3401.256 |  3401.252 |

### Arm - AWS Arm t4g.small
| Type                                   | Method                    | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :------------------------------------- | :------------------------ | ------------: | --------: | --------: | --------: | --------: |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLScalar              |       609.670 |   610.175 |   674.831 |   888.349 |   830.410 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLNetBcl              |               |           |           | 19591.854 | 19843.063 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLNetBcl_Const        |               |           |           | 19585.260 | 19839.003 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Basic              |      3362.391 |  1558.260 |  1593.962 |  7931.659 |  9942.338 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Base_Core          |      3361.521 |  3562.451 |  3660.920 |  7910.038 | 16906.827 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_AdvSimd            |               | 11773.904 | 11826.627 | 13144.260 | 19819.532 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Avx2               |               |           |           |           |           |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLTraits              |      3597.117 | 11333.426 | 11345.812 | 13108.813 | 19832.865 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLTraits_Core         |      3580.619 | 15761.636 | 15838.977 | 19546.989 | 19825.349 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLConstTraits         |      3841.700 | 13217.814 | 15859.573 | 19410.088 | 19834.510 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLConstTraits_Core    |      3841.950 | 15820.815 | 16985.660 | 19399.330 | 19829.721 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128Bcl              |               |           |           | 19575.999 | 19836.369 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128Traits           |       457.859 | 11896.746 | 11335.311 | 13155.132 | 19827.874 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128Traits_Core      |       459.243 | 15825.741 | 16972.257 | 19581.770 | 19821.830 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128ConstTraits      |       456.272 | 15839.376 | 15829.417 | 19400.383 | 19838.864 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128ConstTraits_Core |       456.831 | 15841.274 | 15848.712 | 19415.233 | 19791.258 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL512Bcl              |               |           |           |           | 30197.002 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL512Traits           |               |           |           |           | 30162.905 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFast_AdvSimd        |               | 13158.627 | 15864.810 | 19590.685 | 19829.887 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFast_Avx2           |               |           |           |           |           |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFastTraits          |      3843.004 | 13112.678 | 15858.362 | 19589.811 | 19828.833 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLScalar              |       603.865 |   603.069 |   606.017 |   821.233 |   830.273 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLNetBcl              |               |           |           |  9818.720 |  9928.701 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLNetBcl_Const        |               |           |           |  9816.088 |  9928.634 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Basic              |      1690.698 |  1789.688 |   777.186 |  9827.791 |  9928.037 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Base_Core          |      1694.332 |  1781.165 |  1801.808 |  9810.049 |  9930.594 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_AdvSimd            |               |  5630.795 |  5914.675 |  6590.873 |  9929.409 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Avx2               |               |           |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLTraits              |      1792.932 |  5672.668 |  5952.491 |  9817.877 |  9931.876 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLTraits_Core         |      1794.025 |  8513.781 |  7944.583 |  9799.846 |  9926.691 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLConstTraits         |      1889.665 |  1247.111 |  7951.642 |  9754.273 |  9931.359 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLConstTraits_Core    |      1903.697 |  8511.141 |  7942.467 |  9755.341 |  9929.735 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128Bcl              |               |           |           |  9811.873 |  9927.582 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128Traits           |       292.591 |  5651.354 |  5959.758 |  9818.752 |  9931.620 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128Traits_Core      |       292.344 |  7939.185 |  8505.116 |  9821.111 |  9929.405 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128ConstTraits      |       288.492 |  1245.949 |  7941.172 |  9726.565 |  9929.538 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128ConstTraits_Core |       288.696 |  7897.276 |  8502.726 |  9742.650 |  9929.605 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL512Bcl              |               |           |           |           | 15702.931 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL512Traits           |               |           |           |           | 15692.269 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFast_AdvSimd        |               |  6552.259 |  8506.717 |  9802.989 |  9926.063 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFast_Avx2           |               |           |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFastTraits          |      1908.924 |  7946.934 |  7951.346 |  9801.995 |  9933.448 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLScalar              |       747.355 |   749.175 |   746.788 |  1177.437 |  1243.268 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLNetBcl              |               |           |           |  4864.021 |  4867.524 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLNetBcl_Const        |               |           |           |  4848.450 |  4915.467 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Basic              |       907.266 |   978.839 |   977.281 |  4858.017 |  4910.214 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Base_Core          |       905.360 |   959.284 |   976.261 |  4843.458 |  4916.727 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_AdvSimd            |               |  3274.989 |  3276.607 |  3298.839 |  4898.382 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Avx2               |               |           |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLTraits              |       896.091 |  3287.611 |  3304.001 |  4860.197 |  4903.459 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLTraits_Core         |       893.153 |  4204.944 |  4230.659 |  4860.967 |  4891.438 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLConstTraits         |       948.260 |  3293.490 |  3951.262 |  4825.915 |  4915.003 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLConstTraits_Core    |       958.255 |  4206.585 |  3951.556 |  4828.003 |  4914.166 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128Bcl              |               |           |           |  4809.153 |  4918.795 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128Traits           |       184.629 |  3270.360 |  3297.130 |  4861.957 |  4918.562 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128Traits_Core      |       184.595 |  3941.342 |  4231.167 |  4850.766 |  4890.365 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128ConstTraits      |       184.666 |  3299.800 |  4229.725 |  4807.009 |  4918.806 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128ConstTraits_Core |       184.270 |  3951.191 |  3952.438 |  4817.585 |  4910.695 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL512Bcl              |               |           |           |           |  7572.263 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL512Traits           |               |           |           |           |  7557.656 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFast_AdvSimd        |               |  3921.684 |  4231.836 |  4858.301 |  4907.853 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFast_Avx2           |               |           |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFastTraits          |       961.889 |  3943.682 |  3954.499 |  4856.756 |  4908.459 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLScalar              |       741.345 |   738.573 |   741.723 |  1181.795 |  1243.630 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLNetBcl              |               |           |           |  2445.148 |  2474.209 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLNetBcl_Const        |               |           |           |  2388.818 |  2473.276 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Basic              |       483.177 |   483.396 |   485.099 |  2450.081 |  2469.050 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Base_Core          |       206.754 |   477.325 |   485.303 |  2440.437 |  2473.268 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_AdvSimd            |               |  1399.336 |  1475.860 |  1646.726 |  2446.845 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Avx2               |               |           |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLTraits              |       471.548 |  1414.776 |  1488.608 |  1645.802 |  2462.860 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLTraits_Core         |       470.620 |  2126.579 |  1984.837 |  2440.722 |  2464.689 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLConstTraits         |       468.153 |  1985.566 |  1984.014 |  2439.613 |  2468.182 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLConstTraits_Core    |       468.631 |  1983.033 |  2124.977 |  2445.451 |  2470.810 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128Bcl              |               |           |           |  2445.821 |  2472.926 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128Traits           |       258.356 |  1418.901 |  1484.903 |  1650.400 |  2461.742 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128Traits_Core      |       257.422 |  1972.717 |  2114.908 |  2448.262 |  2468.665 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128ConstTraits      |       257.622 |  1979.961 |  1982.723 |  2444.106 |  2472.309 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128ConstTraits_Core |       257.043 |  2120.115 |  1981.827 |  2436.851 |  2473.302 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL512Bcl              |               |           |           |           |  3854.176 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL512Traits           |               |           |           |           |  3858.902 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFast_AdvSimd        |               |  1976.849 |  1653.707 |  2420.647 |  2468.789 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFast_Avx2           |               |           |           |           |           |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFastTraits          |       468.760 |  1985.988 |  1654.599 |  2419.072 |  2465.848 |

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                                   | Method                    | .NET 8.0 |
| :------------------------------------- | :------------------------ | -------: |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLScalar              |   27.221 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLNetBcl              |  331.921 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLNetBcl_Const        |  303.203 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Basic              |   46.011 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Base_Core          |   44.058 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_AdvSimd            |          |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Avx2               |          |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLTraits              |  263.224 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLTraits_Core         |  254.989 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLConstTraits         |  233.693 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLConstTraits_Core    |  241.052 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128Bcl              |  321.582 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128Traits           |  333.239 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128Traits_Core      |  328.107 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128ConstTraits      |  309.329 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128ConstTraits_Core |  300.824 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL512Bcl              |   63.840 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL512Traits           |   58.180 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFast_AdvSimd        |          |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFast_Avx2           |          |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFastTraits          |  246.151 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLScalar              |   27.925 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLNetBcl              |  169.367 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLNetBcl_Const        |  151.738 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Basic              |  165.374 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Base_Core          |  171.123 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_AdvSimd            |          |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Avx2               |          |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLTraits              |  133.135 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLTraits_Core         |  131.397 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLConstTraits         |  118.679 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLConstTraits_Core    |  126.493 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128Bcl              |  161.942 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128Traits           |  166.702 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128Traits_Core      |  169.767 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128ConstTraits      |  157.730 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128ConstTraits_Core |  154.191 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL512Bcl              |   31.831 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL512Traits           |   31.647 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFast_AdvSimd        |          |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFast_Avx2           |          |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFastTraits          |  128.266 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLScalar              |   32.579 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLNetBcl              |   81.940 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLNetBcl_Const        |   76.133 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Basic              |   84.258 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Base_Core          |   81.833 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_AdvSimd            |          |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Avx2               |          |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLTraits              |   64.769 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLTraits_Core         |   63.406 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLConstTraits         |   60.444 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLConstTraits_Core    |   59.635 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128Bcl              |   85.569 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128Traits           |   82.905 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128Traits_Core      |   84.181 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128ConstTraits      |   77.600 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128ConstTraits_Core |   79.595 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL512Bcl              |   16.917 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL512Traits           |   16.054 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFast_AdvSimd        |          |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFast_Avx2           |          |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFastTraits          |   64.702 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLScalar              |   31.453 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLNetBcl              |   10.472 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLNetBcl_Const        |   10.613 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Basic              |   10.832 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Base_Core          |   11.094 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_AdvSimd            |          |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Avx2               |          |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLTraits              |   20.869 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLTraits_Core         |   21.207 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLConstTraits         |   20.181 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLConstTraits_Core    |   19.635 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128Bcl              |    4.618 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128Traits           |   42.467 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128Traits_Core      |   42.175 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128ConstTraits      |   38.229 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128ConstTraits_Core |   37.843 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL512Bcl              |    3.329 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL512Traits           |    6.949 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFast_AdvSimd        |          |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFast_Avx2           |          |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFastTraits          |    9.505 |

