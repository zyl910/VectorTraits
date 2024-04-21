# Benchmark group - ShiftRightLogical
([← Back](ShiftRightLogical.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### X86 - AMD Ryzen 7 7840H
| Type                                   | Method                    | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |   .NET 8.0 |
| :------------------------------------- | :------------------------ | -------------: | ------------: | ------------: | --------: | --------: | --------: | ---------: |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLScalar              |       1158.578 |      1158.743 |      1532.507 |  1527.661 |  1555.117 |  1671.029 |   1705.933 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLNetBcl              |                |               |               |           |           |  1578.064 |   1612.918 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLNetBcl_Const        |                |               |               |           |           |  1580.707 |   1604.825 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Basic              |       3870.018 |      4029.339 |      4023.856 |  4184.542 |  4162.227 | 33785.119 |  38678.894 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Base_Core          |       3864.984 |      4029.958 |      3993.606 |  4179.640 |  4181.910 | 34324.503 |  81331.934 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_AdvSimd            |                |               |               |           |           |           |            |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL_Avx2               |                |               |     33993.896 | 33924.456 | 34326.147 | 35216.124 |  84238.747 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLTraits              |       3856.163 |      4041.378 |     33300.059 | 33764.110 | 33851.094 | 35388.841 |  82814.612 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLTraits_Core         |       3871.816 |      4025.320 |     87203.636 | 82223.438 | 85582.178 | 84753.326 |  88362.464 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLConstTraits         |       4191.714 |      4166.153 |     38428.723 | 68941.012 | 77669.651 | 73971.641 |  86903.904 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLConstTraits_Core    |       4187.750 |      4194.853 |     86971.340 | 82124.723 | 84209.039 | 56211.705 |  87229.752 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128Traits           |                |               |     16977.238 | 16977.738 | 17207.521 | 17764.299 |  40760.459 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128Traits_Core      |                |               |     43598.491 | 43748.870 | 43870.702 | 43720.031 |  44391.735 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128ConstTraits      |                |               |     19236.491 | 39322.158 | 39843.226 | 43626.195 |  44022.182 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL128ConstTraits_Core |                |               |     43428.669 | 42754.672 | 44222.060 | 31439.058 |  44387.789 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL512Bcl              |                |               |               |           |           |           | 101062.166 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRL512Traits           |                |               |               |           |           |           | 102147.598 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFast_AdvSimd        |                |               |               |           |           |           |            |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFast_Avx2           |                |               |     39766.863 | 61558.242 | 76550.223 | 76028.227 |  80584.950 |
| ShiftRightLogicalConstBenchmark_Byte   | SumSRLFastTraits          |       4201.803 |      4195.770 |     39443.446 | 61264.254 | 76444.941 | 78236.059 |  88802.102 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLScalar              |       1349.841 |      1351.816 |      1596.302 |  1590.945 |  1562.904 |  1672.966 |   1700.019 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLNetBcl              |                |               |               |           |           | 39235.751 |  45259.821 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLNetBcl_Const        |                |               |               |           |           | 50907.208 |  49904.347 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Basic              |       1943.593 |      2028.970 |      1992.563 |  2100.816 |  2106.309 | 39039.378 |  45031.100 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Base_Core          |       1931.904 |      2021.878 |      1983.595 |  2098.790 |  2092.119 | 39129.270 |  49431.223 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_AdvSimd            |                |               |               |           |           |           |            |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL_Avx2               |                |               |     33127.144 | 33758.765 | 33918.638 | 32804.453 |  35393.818 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLTraits              |       1928.710 |      2016.815 |     32139.174 | 34068.917 | 34358.483 | 38938.801 |  49482.354 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLTraits_Core         |       1951.348 |      2017.370 |     41100.913 | 49795.505 | 44665.126 | 44417.225 |  45465.523 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLConstTraits         |       2101.412 |      2094.300 |     34713.352 | 44209.299 | 51114.620 | 50756.151 |  49828.699 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLConstTraits_Core    |       2080.404 |      2097.579 |     41272.311 | 44804.532 | 51658.039 | 49832.640 |  50103.355 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128Traits           |                |               |     17472.259 | 17441.826 | 17562.229 | 17699.930 |  26459.258 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128Traits_Core      |                |               |     24234.930 | 23117.627 | 22918.239 | 22989.254 |  22821.582 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128ConstTraits      |                |               |     17462.662 | 22485.253 | 26192.477 | 26168.587 |  26348.358 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL128ConstTraits_Core |                |               |     22157.355 | 22524.016 | 26548.859 | 26339.530 |  26596.626 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL512Bcl              |                |               |               |           |           |           |  49774.307 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRL512Traits           |                |               |               |           |           |           |  49837.155 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFast_AdvSimd        |                |               |               |           |           |           |            |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFast_Avx2           |                |               |     34484.037 | 44432.083 | 40947.800 | 39409.872 |  45060.916 |
| ShiftRightLogicalConstBenchmark_UInt16 | SumSRLFastTraits          |       2082.979 |      2097.091 |     33059.075 | 44362.428 | 41313.185 | 38757.034 |  49289.752 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLScalar              |       1475.011 |      1467.882 |      1680.084 |  1697.887 |  2181.454 |  3050.769 |   3124.964 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLNetBcl              |                |               |               |           |           | 16673.360 |  20204.667 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLNetBcl_Const        |                |               |               |           |           | 21179.064 |  20618.924 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Basic              |        965.163 |      1007.837 |      1001.886 |  1036.573 |  1035.772 | 17092.433 |  20470.511 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Base_Core          |        975.763 |      1006.723 |      1001.329 |  1044.387 |  1029.808 | 17093.785 |  20517.283 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_AdvSimd            |                |               |               |           |           |           |            |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL_Avx2               |                |               |     15377.508 | 15895.761 | 15955.041 | 15940.511 |  19874.105 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLTraits              |        971.705 |      1013.421 |     16385.917 | 16027.945 | 15965.013 | 16794.223 |  20578.438 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLTraits_Core         |        960.232 |      1008.094 |     23710.781 | 23031.915 | 23506.729 | 21059.109 |  20830.925 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLConstTraits         |       1051.247 |      1048.835 |     16604.540 | 19325.185 | 19378.756 | 21378.860 |  21126.468 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLConstTraits_Core    |       1044.583 |      1044.644 |     23057.702 | 19774.603 | 23354.663 | 18587.293 |  20711.347 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128Traits           |                |               |      8494.427 |  8548.984 |  8668.529 |  8775.731 |  13090.617 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128Traits_Core      |                |               |     13034.043 | 12491.308 | 12992.261 | 12839.212 |  12507.243 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128ConstTraits      |                |               |      8550.934 | 11545.698 | 13087.908 | 12129.902 |  13121.637 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL128ConstTraits_Core |                |               |     12598.753 | 12977.014 | 13120.392 | 12378.810 |  13171.334 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL512Bcl              |                |               |               |           |           |           |  22128.562 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRL512Traits           |                |               |               |           |           |           |  22398.557 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFast_AdvSimd        |                |               |               |           |           |           |            |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFast_Avx2           |                |               |     16596.519 | 21246.861 | 17919.377 | 16224.213 |  20587.143 |
| ShiftRightLogicalConstBenchmark_UInt32 | SumSRLFastTraits          |       1044.827 |      1042.291 |     16768.629 | 20960.271 | 17631.665 | 17140.836 |  21098.855 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLScalar              |       1470.373 |      1454.442 |      1577.526 |  1564.304 |  1667.159 |  2028.724 |   3127.264 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLNetBcl              |                |               |               |           |           |  9308.702 |  10839.444 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLNetBcl_Const        |                |               |               |           |           |  9902.153 |  10369.806 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Basic              |        523.349 |       523.983 |       520.909 |   542.397 |   514.287 |  9220.041 |  10813.396 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Base_Core          |        520.936 |       525.614 |       515.639 |   543.317 |   512.093 |  9143.884 |  10489.415 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_AdvSimd            |                |               |               |           |           |           |            |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL_Avx2               |                |               |      8059.993 |  8383.600 |  8397.200 |  8323.190 |   8815.106 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLTraits              |        520.886 |       521.403 |      8258.208 |  8299.260 |  8276.521 |  8257.018 |   8641.352 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLTraits_Core         |        517.853 |       525.214 |     10120.306 | 11327.765 | 11195.322 | 10032.227 |  10111.825 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLConstTraits         |        545.782 |       545.089 |      8305.392 |  6661.429 | 11377.310 | 10141.582 |  10370.711 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLConstTraits_Core    |        545.861 |       546.907 |      9895.630 | 11300.656 | 10885.293 | 10149.187 |  10355.267 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128Traits           |                |               |      4359.472 |  4286.120 |  4338.652 |  4269.218 |   5584.234 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128Traits_Core      |                |               |      6498.474 |  6392.358 |  6559.716 |  6583.810 |   6568.347 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128ConstTraits      |                |               |      4690.797 |  4567.825 |  6535.741 |  6536.820 |   6494.501 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL128ConstTraits_Core |                |               |      6424.692 |  6523.629 |  6445.362 |  6560.813 |   6590.588 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL512Bcl              |                |               |               |           |           |           |  10580.303 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRL512Traits           |                |               |               |           |           |           |   8858.438 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFast_AdvSimd        |                |               |               |           |           |           |            |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFast_Avx2           |                |               |      8472.813 |  9853.786 | 10126.109 |  8916.224 |  10661.067 |
| ShiftRightLogicalConstBenchmark_UInt64 | SumSRLFastTraits          |        545.438 |       542.086 |      8437.472 | 10092.096 | 10182.531 |  8825.070 |  10548.390 |

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

