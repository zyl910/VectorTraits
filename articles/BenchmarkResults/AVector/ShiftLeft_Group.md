# Benchmark group - ShiftLeft
([← Back](ShiftLeft.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### X86 - AMD Ryzen 7 7840H
| Type                          | Method                    | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |   .NET 8.0 |
| :---------------------------- | :------------------------ | -------------: | ------------: | ------------: | --------: | --------: | --------: | ---------: |
| ShiftLeftConstBenchmark_Byte  | SumSLLScalar              |       1158.930 |      1162.537 |      1507.403 |  1529.852 |  1508.479 |  1677.757 |   1714.959 |
| ShiftLeftConstBenchmark_Byte  | SumSLLNetBcl              |                |               |               |           |           |  1587.722 |   1602.705 |
| ShiftLeftConstBenchmark_Byte  | SumSLLNetBcl_Const        |                |               |               |           |           |  1595.398 |   1640.845 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Basic              |      13241.743 |     13207.349 |     25024.842 | 23412.700 | 24663.094 | 29834.283 |  32019.641 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Base_Core          |      67289.841 |     67800.170 |     76530.251 | 76359.137 | 67728.945 | 78097.864 |  80445.723 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Multiply           |      13219.514 |     15056.255 |     25299.812 | 23581.765 | 24854.766 | 30070.786 |  32834.447 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_AdvSimd            |                |               |               |           |           |           |            |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Avx2               |                |               |     35084.309 | 35073.321 | 30331.440 | 41355.116 |  82787.183 |
| ShiftLeftConstBenchmark_Byte  | SumSLLTraits              |      13201.590 |     15054.128 |     34345.556 | 35173.054 | 30753.325 | 41998.816 |  82366.957 |
| ShiftLeftConstBenchmark_Byte  | SumSLLTraits_Core         |      68122.389 |     67170.341 |     85378.339 | 85108.728 | 71706.672 | 85921.206 | 103940.833 |
| ShiftLeftConstBenchmark_Byte  | SumSLLConstTraits         |      14873.913 |     13244.690 |     47270.691 | 69067.059 | 72211.591 | 82376.139 | 103768.539 |
| ShiftLeftConstBenchmark_Byte  | SumSLLConstTraits_Core    |      67352.024 |     67462.939 |     84471.420 | 83904.666 | 77351.525 | 56313.666 | 104218.248 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128Traits           |                |               |     17464.506 | 17610.251 | 15388.614 | 19251.533 |  40937.707 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128Traits_Core      |                |               |     43145.557 | 43454.469 | 41881.908 | 43860.353 |  53136.481 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128ConstTraits      |                |               |     19159.479 | 26535.458 | 35040.946 | 43301.003 |  52498.193 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128ConstTraits_Core |                |               |     43709.593 | 43924.635 | 41056.827 | 31411.520 |  53406.905 |
| ShiftLeftConstBenchmark_Byte  | SumSLL512Bcl              |                |               |               |           |           |           |    501.971 |
| ShiftLeftConstBenchmark_Byte  | SumSLL512Traits           |                |               |               |           |           |           | 102336.376 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_Multiply       |      15152.225 |     15019.257 |     43452.725 | 43807.761 | 36610.511 | 57561.534 |  61251.942 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_AdvSimd        |                |               |               |           |           |           |            |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_Avx2           |                |               |     38696.307 | 60984.258 | 69790.746 | 82595.651 |  81590.400 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFastTraits          |      15045.551 |     15085.911 |     38727.754 | 60138.120 | 70641.558 | 82310.926 |  99379.677 |
| ShiftLeftConstBenchmark_Int16 | SumSLLScalar              |       1179.113 |      1178.102 |      1418.032 |  1411.558 |  1295.705 |  1570.545 |   1705.016 |
| ShiftLeftConstBenchmark_Int16 | SumSLLNetBcl              |                |               |               |           |           | 39374.300 |  44739.814 |
| ShiftLeftConstBenchmark_Int16 | SumSLLNetBcl_Const        |                |               |               |           |           | 50920.501 |  49458.678 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Basic              |       7545.839 |      8714.679 |     17980.227 | 17869.757 | 23775.220 | 39442.007 |  45198.149 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core          |      43319.874 |     42691.061 |     43384.468 | 41490.237 | 38316.864 | 38850.396 |  49734.859 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core_Element  |       7451.170 |      8675.936 |     16143.067 | 16632.670 | 19425.648 | 24236.068 |  45180.696 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core_Mov      |       6527.918 |      6615.670 |     17534.584 | 17675.758 | 21714.821 | 33565.398 |  33678.195 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Multiply           |       7465.650 |      8692.835 |     17787.188 | 17924.490 | 24820.583 | 26437.499 |  32879.805 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_AdvSimd            |                |               |               |           |           |           |            |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Avx2               |                |               |     32585.584 | 33044.268 | 30160.500 | 33030.816 |  35712.430 |
| ShiftLeftConstBenchmark_Int16 | SumSLLTraits              |       7646.653 |      7576.387 |     32493.293 | 32008.890 | 30823.012 | 39634.050 |  49491.506 |
| ShiftLeftConstBenchmark_Int16 | SumSLLTraits_Core         |      42588.160 |     42562.830 |     43199.688 | 41750.420 | 42450.753 | 44715.654 |  42340.461 |
| ShiftLeftConstBenchmark_Int16 | SumSLLConstTraits         |       6654.055 |      7616.741 |     33729.258 | 44707.598 | 46630.658 | 42713.244 |  49829.677 |
| ShiftLeftConstBenchmark_Int16 | SumSLLConstTraits_Core    |      43220.783 |     40623.888 |     41013.383 | 44691.037 | 48501.402 | 42128.494 |  49805.196 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128Traits           |                |               |     17524.340 | 17563.021 | 17223.530 | 17409.903 |  26727.920 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128Traits_Core      |                |               |     22581.624 | 23592.948 | 23732.976 | 23154.652 |  22720.455 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128ConstTraits      |                |               |     17563.474 | 22250.319 | 26568.219 | 26721.196 |  26630.890 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128ConstTraits_Core |                |               |     22001.606 | 22400.069 | 26569.739 | 26555.490 |  26624.517 |
| ShiftLeftConstBenchmark_Int16 | SumSLL512Bcl              |                |               |               |           |           |           |  48909.671 |
| ShiftLeftConstBenchmark_Int16 | SumSLL512Traits           |                |               |               |           |           |           |  49414.521 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_Multiply       |       7544.444 |      7613.470 |     28799.847 | 28527.118 | 32328.200 | 32229.219 |  33024.721 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_AdvSimd        |                |               |               |           |           |           |            |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_Avx2           |                |               |     33939.352 | 44640.885 | 39963.668 | 39108.753 |  44968.382 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFastTraits          |       8691.236 |      7624.219 |     34687.190 | 44978.236 | 39504.105 | 39096.035 |  49453.894 |
| ShiftLeftConstBenchmark_Int32 | SumSLLScalar              |       1463.480 |      1454.936 |      1559.976 |  1684.073 |  2465.377 |  2996.555 |   2993.977 |
| ShiftLeftConstBenchmark_Int32 | SumSLLNetBcl              |                |               |               |           |           | 21548.327 |  19677.030 |
| ShiftLeftConstBenchmark_Int32 | SumSLLNetBcl_Const        |                |               |               |           |           | 22878.867 |  20453.920 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Basic              |       4298.977 |      4331.705 |     13135.292 | 13225.361 | 14005.275 | 21494.027 |  19617.527 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Base_Core          |      18612.821 |     19987.950 |     20604.687 | 19045.372 | 20339.215 | 21361.797 |  20607.885 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Multiply           |       4339.441 |      3800.297 |     13069.043 | 13069.714 | 13865.790 | 14259.261 |  19346.380 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_AdvSimd            |                |               |               |           |           |           |            |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Avx2               |                |               |     15910.132 | 15899.566 | 16300.781 | 16671.905 |  16632.341 |
| ShiftLeftConstBenchmark_Int32 | SumSLLTraits              |       4375.528 |      3804.305 |     16038.922 | 15987.260 | 16014.192 | 21556.913 |  20703.390 |
| ShiftLeftConstBenchmark_Int32 | SumSLLTraits_Core         |      19792.313 |     19994.030 |     22761.253 | 23291.887 | 23985.510 | 22986.994 |  18749.999 |
| ShiftLeftConstBenchmark_Int32 | SumSLLConstTraits         |       4380.457 |      3326.629 |     16002.972 | 19244.608 | 23951.437 | 22869.058 |  20726.908 |
| ShiftLeftConstBenchmark_Int32 | SumSLLConstTraits_Core    |      18293.329 |     19943.893 |     19084.173 | 13214.099 | 23575.133 | 21086.849 |  20585.988 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128Traits           |                |               |      8748.598 |  8683.954 |  8663.424 | 11060.301 |  13096.959 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128Traits_Core      |                |               |     12939.748 | 12980.278 | 13198.866 | 13124.813 |  12526.460 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128ConstTraits      |                |               |      8518.578 | 10898.434 | 12928.864 | 12618.501 |  12825.056 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128ConstTraits_Core |                |               |     12911.830 | 13055.798 | 12930.918 | 12484.024 |  12935.403 |
| ShiftLeftConstBenchmark_Int32 | SumSLL512Bcl              |                |               |               |           |           |           |  20914.791 |
| ShiftLeftConstBenchmark_Int32 | SumSLL512Traits           |                |               |               |           |           |           |  21257.442 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_Multiply       |       4361.613 |      3794.213 |     15430.839 | 15626.693 | 15982.041 | 16130.549 |  19616.557 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_AdvSimd        |                |               |               |           |           |           |            |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_Avx2           |                |               |     16235.154 | 21078.101 | 18307.665 | 16862.446 |  19879.184 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFastTraits          |       4405.177 |      3804.142 |     16373.592 | 19237.741 | 18227.790 | 21447.109 |  20810.343 |
| ShiftLeftConstBenchmark_Int64 | SumSLLScalar              |       1464.290 |      1464.569 |      1687.438 |  1684.814 |  2488.596 |  2717.422 |   2986.043 |
| ShiftLeftConstBenchmark_Int64 | SumSLLNetBcl              |                |               |               |           |           |  9349.849 |  10715.263 |
| ShiftLeftConstBenchmark_Int64 | SumSLLNetBcl_Const        |                |               |               |           |           | 10017.360 |  10393.349 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Basic              |        519.842 |       527.050 |       519.148 |   547.352 |   546.957 |  9266.590 |  10606.342 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Base_Core          |        519.968 |       524.593 |       523.656 |   539.719 |   545.187 |  9210.611 |  10600.385 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_AdvSimd            |                |               |               |           |           |           |            |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Avx2               |                |               |      8214.588 |  8093.035 |  8190.858 |  8249.532 |   8838.482 |
| ShiftLeftConstBenchmark_Int64 | SumSLLTraits              |        521.808 |       524.175 |      8016.616 |  8235.642 |  8085.607 |  8306.128 |   8741.160 |
| ShiftLeftConstBenchmark_Int64 | SumSLLTraits_Core         |        519.484 |       524.490 |     10072.464 | 10127.320 | 10131.979 | 10213.689 |  10071.812 |
| ShiftLeftConstBenchmark_Int64 | SumSLLConstTraits         |        544.565 |       546.734 |      8390.482 |  8262.187 | 10278.989 | 10188.180 |  10840.139 |
| ShiftLeftConstBenchmark_Int64 | SumSLLConstTraits_Core    |        543.190 |       545.943 |     10250.939 | 10249.968 | 10306.207 | 10244.260 |  10732.499 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128Traits           |                |               |      4306.777 |  4341.621 |  4299.816 |  4287.973 |   5322.785 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128Traits_Core      |                |               |      6303.876 |  6485.925 |  6539.145 |  6596.300 |   6689.827 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128ConstTraits      |                |               |      4674.853 |  4572.462 |  6528.608 |  6610.880 |   6664.193 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128ConstTraits_Core |                |               |      6513.238 |  6511.238 |  6546.894 |  6598.881 |   6681.550 |
| ShiftLeftConstBenchmark_Int64 | SumSLL512Bcl              |                |               |               |           |           |           |  10758.816 |
| ShiftLeftConstBenchmark_Int64 | SumSLL512Traits           |                |               |               |           |           |           |   8877.605 |
| ShiftLeftConstBenchmark_Int64 | SumSLLFast_AdvSimd        |                |               |               |           |           |           |            |
| ShiftLeftConstBenchmark_Int64 | SumSLLFast_Avx2           |                |               |      8233.632 |  9210.144 |  9278.765 |  8991.723 |  10723.790 |
| ShiftLeftConstBenchmark_Int64 | SumSLLFastTraits          |        541.011 |       548.171 |      8173.518 |  9312.483 |  9307.613 |  8959.314 |  10517.267 |

### X86 - Intel Core i5-8250U
| Type                          | Method                    | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :---------------------------- | :------------------------ | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| ShiftLeftConstBenchmark_Byte  | SumSLLScalar              |        859.830 |       859.678 |      1120.378 |  1127.346 |  1359.361 |  1549.840 |
| ShiftLeftConstBenchmark_Byte  | SumSLLNetBcl              |                |               |               |           |           |  1178.786 |
| ShiftLeftConstBenchmark_Byte  | SumSLLNetBcl_Const        |                |               |               |           |           |  1177.339 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Basic              |       8915.278 |      8948.021 |     15906.723 | 15322.318 | 16445.602 | 20032.835 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Base_Core          |      39706.505 |     34547.354 |     45658.298 | 40123.498 | 40044.314 | 39771.177 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Multiply           |       8879.961 |      8862.589 |     15951.707 | 15255.982 | 16459.778 | 20072.958 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_AdvSimd            |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Avx2               |                |               |     22421.910 | 22273.765 | 22329.276 | 25274.859 |
| ShiftLeftConstBenchmark_Byte  | SumSLLTraits              |       8898.294 |      8918.435 |     22496.421 | 19942.064 | 22275.738 | 25662.171 |
| ShiftLeftConstBenchmark_Byte  | SumSLLTraits_Core         |      35443.918 |     39670.570 |     42201.168 | 32582.667 | 38778.852 | 38750.734 |
| ShiftLeftConstBenchmark_Byte  | SumSLLConstTraits         |      11399.508 |     11394.920 |     26732.458 | 30573.583 | 40803.174 | 38665.512 |
| ShiftLeftConstBenchmark_Byte  | SumSLLConstTraits_Core    |      39686.234 |     35187.799 |     42237.347 | 33994.636 | 37957.676 | 41641.236 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128Traits           |                |               |     10716.849 |  9420.328 | 11324.426 | 13322.526 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128Traits_Core      |                |               |     23050.798 | 21066.098 | 23010.720 | 21112.009 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128ConstTraits      |                |               |     13391.678 | 22217.394 | 23430.138 | 21055.801 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128ConstTraits_Core |                |               |     22572.982 | 23027.578 | 23027.809 | 21080.812 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_Multiply       |      11744.320 |     11722.099 |     26791.041 | 26735.628 | 26799.087 | 35535.744 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_AdvSimd        |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_Avx2           |                |               |     26841.018 | 35053.310 | 37805.004 | 37856.876 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFastTraits          |      11612.495 |     11706.056 |     26739.956 | 34949.253 | 37713.378 | 38986.866 |
| ShiftLeftConstBenchmark_Int16 | SumSLLScalar              |        841.494 |       843.096 |      1193.064 |  1190.046 |  1358.824 |  1553.763 |
| ShiftLeftConstBenchmark_Int16 | SumSLLNetBcl              |                |               |               |           |           | 20899.194 |
| ShiftLeftConstBenchmark_Int16 | SumSLLNetBcl_Const        |                |               |               |           |           | 23392.777 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Basic              |       5397.386 |      5632.457 |     12242.743 | 12324.011 | 13996.667 | 19300.915 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core          |      23288.822 |     22603.626 |     21818.346 | 23074.695 | 23534.517 | 19649.150 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core_Element  |       5275.958 |      5157.314 |     11354.740 | 11523.799 | 12690.810 | 16740.485 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core_Mov      |       5139.615 |      5067.630 |     11250.575 | 11060.124 | 12060.375 | 17597.569 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Multiply           |       5577.054 |      5630.545 |     12296.786 |  9862.494 | 13521.671 | 15305.111 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_AdvSimd            |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Avx2               |                |               |     18106.898 | 17519.480 | 17577.641 | 18104.001 |
| ShiftLeftConstBenchmark_Int16 | SumSLLTraits              |       5457.114 |      5642.180 |     18094.357 | 17511.952 | 17413.467 | 18827.412 |
| ShiftLeftConstBenchmark_Int16 | SumSLLTraits_Core         |      21924.622 |     22574.392 |     19955.908 | 15314.070 | 20651.910 | 18450.119 |
| ShiftLeftConstBenchmark_Int16 | SumSLLConstTraits         |       6162.425 |      6370.666 |     18610.286 | 19546.284 | 21780.182 | 20487.319 |
| ShiftLeftConstBenchmark_Int16 | SumSLLConstTraits_Core    |      21686.822 |     21746.218 |     22470.309 | 20086.968 | 22313.920 | 21803.300 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128Traits           |                |               |     10336.762 | 10320.694 | 10299.377 | 11985.678 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128Traits_Core      |                |               |     11657.662 | 11676.835 | 11658.723 | 12435.207 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128ConstTraits      |                |               |     10337.941 | 11656.995 | 12129.890 | 13057.907 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128ConstTraits_Core |                |               |     11703.474 | 11655.909 | 12496.018 | 12959.630 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_Multiply       |       6186.912 |      6421.950 |     16343.287 | 17032.182 | 19837.415 | 19843.004 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_AdvSimd        |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_Avx2           |                |               |     20115.209 | 21976.277 | 20266.778 | 19900.086 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFastTraits          |       6184.293 |      6309.359 |     20019.329 | 20676.579 | 19810.254 | 19366.831 |
| ShiftLeftConstBenchmark_Int32 | SumSLLScalar              |        841.328 |       840.669 |      1351.033 |  1352.504 |  2210.995 |  1682.320 |
| ShiftLeftConstBenchmark_Int32 | SumSLLNetBcl              |                |               |               |           |           | 11099.770 |
| ShiftLeftConstBenchmark_Int32 | SumSLLNetBcl_Const        |                |               |               |           |           | 11446.173 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Basic              |       2802.717 |      2949.499 |      6410.821 |  5993.531 |  6501.187 | 10747.854 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Base_Core          |       9080.301 |      8804.870 |      9779.287 |  8924.169 |  9231.653 | 10730.875 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Multiply           |       2824.083 |      2953.408 |      6506.876 |  6318.309 |  6420.457 |  7552.381 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_AdvSimd            |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Avx2               |                |               |      8867.412 |  8815.073 |  8769.006 |  9277.081 |
| ShiftLeftConstBenchmark_Int32 | SumSLLTraits              |       2818.536 |      2945.223 |      9067.419 |  8441.793 |  8834.515 | 10023.542 |
| ShiftLeftConstBenchmark_Int32 | SumSLLTraits_Core         |       9136.424 |      9683.714 |     11035.304 | 10064.362 | 10604.724 | 11690.595 |
| ShiftLeftConstBenchmark_Int32 | SumSLLConstTraits         |       3109.161 |      3268.712 |      8866.244 | 10270.765 | 11240.672 | 11281.663 |
| ShiftLeftConstBenchmark_Int32 | SumSLLConstTraits_Core    |       9207.823 |      9766.888 |     11309.484 | 11415.397 | 10749.271 | 11540.250 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128Traits           |                |               |      5223.277 |  4641.201 |  5158.228 |  6237.418 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128Traits_Core      |                |               |      6134.347 |  6101.042 |  6347.901 |  6482.377 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128ConstTraits      |                |               |      5185.557 |  5853.219 |  6110.895 |  6542.770 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128ConstTraits_Core |                |               |      6092.871 |  6798.737 |  6115.839 |  6565.355 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_Multiply       |       3123.269 |      3260.600 |      8700.854 |  8723.159 |  8663.119 |  9280.389 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_AdvSimd        |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_Avx2           |                |               |     10031.817 | 10384.981 |  9428.490 | 10272.998 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFastTraits          |       3179.152 |      3303.057 |     10036.247 | 10369.038 |  9458.591 | 10606.724 |
| ShiftLeftConstBenchmark_Int64 | SumSLLScalar              |        832.495 |       829.698 |      1351.115 |  1346.235 |  2161.948 |  2667.438 |
| ShiftLeftConstBenchmark_Int64 | SumSLLNetBcl              |                |               |               |           |           |  4179.660 |
| ShiftLeftConstBenchmark_Int64 | SumSLLNetBcl_Const        |                |               |               |           |           |  5648.203 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Basic              |        451.744 |       450.420 |       488.809 |   471.229 |   473.561 |  4905.683 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Base_Core          |        458.161 |       472.021 |       489.188 |   466.079 |   473.242 |  4900.543 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_AdvSimd            |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Avx2               |                |               |      4497.519 |  4448.556 |  4574.409 |  4363.729 |
| ShiftLeftConstBenchmark_Int64 | SumSLLTraits              |        450.909 |       471.976 |      4542.925 |  4437.420 |  4604.258 |  3709.782 |
| ShiftLeftConstBenchmark_Int64 | SumSLLTraits_Core         |        434.814 |       470.974 |      5996.036 |  5631.227 |  5844.559 |  2816.698 |
| ShiftLeftConstBenchmark_Int64 | SumSLLConstTraits         |        500.901 |       549.041 |      4674.201 |  4359.205 |  5645.399 |  4971.800 |
| ShiftLeftConstBenchmark_Int64 | SumSLLConstTraits_Core    |        501.781 |       548.865 |      5860.712 |  5494.338 |  5589.806 |  5111.673 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128Traits           |                |               |      2588.404 |  2576.063 |  2585.887 |  2654.271 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128Traits_Core      |                |               |      3064.588 |  3060.060 |  3228.360 |  3475.323 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128ConstTraits      |                |               |      2595.091 |  2598.921 |  3132.408 |  3405.429 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128ConstTraits_Core |                |               |      3332.640 |  3061.618 |  3064.909 |  3433.879 |
| ShiftLeftConstBenchmark_Int64 | SumSLLFast_AdvSimd        |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Int64 | SumSLLFast_Avx2           |                |               |      5030.382 |  4821.201 |  5083.835 |  5111.590 |
| ShiftLeftConstBenchmark_Int64 | SumSLLFastTraits          |        486.050 |       503.722 |      5025.083 |  4791.775 |  5136.548 |  4938.225 |

### Arm - AWS Arm t4g.small
| Type                          | Method                    | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :---------------------------- | :------------------------ | ------------: | --------: | --------: | --------: |
| ShiftLeftConstBenchmark_Byte  | SumSLLScalar              |       610.825 |   610.499 |   648.707 |   923.726 |
| ShiftLeftConstBenchmark_Byte  | SumSLLNetBcl              |               |           |           | 19511.837 |
| ShiftLeftConstBenchmark_Byte  | SumSLLNetBcl_Const        |               |           |           | 19503.337 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Basic              |      5674.133 |  5673.983 |  6935.391 | 19541.478 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Base_Core          |     13187.618 | 15807.401 | 15583.597 | 19498.215 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Multiply           |      5673.371 |  5678.280 |  6936.219 |  7390.891 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_AdvSimd            |               | 13180.138 | 13060.826 | 13186.220 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Avx2               |               |           |           |           |
| ShiftLeftConstBenchmark_Byte  | SumSLLTraits              |      5660.940 | 13251.373 | 13237.895 | 13201.062 |
| ShiftLeftConstBenchmark_Byte  | SumSLLTraits_Core         |     13186.221 | 17009.027 | 16908.563 | 19508.964 |
| ShiftLeftConstBenchmark_Byte  | SumSLLConstTraits         |     11307.858 | 15890.589 | 16767.307 | 19385.104 |
| ShiftLeftConstBenchmark_Byte  | SumSLLConstTraits_Core    |     14351.930 | 17011.540 | 16720.152 | 19387.799 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128Traits           |       462.538 | 13233.928 | 13092.409 | 13185.281 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128Traits_Core      |       466.121 | 15854.999 | 15672.416 | 19485.455 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128ConstTraits      |       465.097 |  2839.889 | 16830.711 | 19386.371 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128ConstTraits_Core |       465.122 | 15839.694 | 16841.563 | 19412.991 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_Multiply       |      9946.778 |  9947.575 | 11006.560 | 11452.973 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_AdvSimd        |               | 15876.095 | 15793.456 | 19558.086 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_Avx2           |               |           |           |           |
| ShiftLeftConstBenchmark_Byte  | SumSLLFastTraits          |      9939.062 | 15881.148 | 15877.231 | 19511.599 |
| ShiftLeftConstBenchmark_Int16 | SumSLLScalar              |       607.672 |   606.961 |   601.727 |   822.752 |
| ShiftLeftConstBenchmark_Int16 | SumSLLNetBcl              |               |           |           |  9953.959 |
| ShiftLeftConstBenchmark_Int16 | SumSLLNetBcl_Const        |               |           |           |  9935.183 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Basic              |      4320.858 |  4232.180 |  5569.436 |  9955.169 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core          |      8401.035 |  7862.815 |  7704.772 |  9940.394 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core_Element  |      4218.452 |  4273.823 |  5188.869 |  7227.536 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core_Mov      |      4204.219 |  3970.879 |  5033.689 |  7962.445 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Multiply           |      4286.881 |  4217.522 |  5505.454 |  6128.303 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_AdvSimd            |               |  6541.930 |  6444.328 |  6618.822 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Avx2               |               |           |           |           |
| ShiftLeftConstBenchmark_Int16 | SumSLLTraits              |      4206.952 |  6557.701 |  6410.792 |  9944.018 |
| ShiftLeftConstBenchmark_Int16 | SumSLLTraits_Core         |      7873.391 |  7895.671 |  8190.248 |  9933.661 |
| ShiftLeftConstBenchmark_Int16 | SumSLLConstTraits         |      6585.196 |  6632.750 |  8203.292 |  9936.389 |
| ShiftLeftConstBenchmark_Int16 | SumSLLConstTraits_Core    |      8388.233 |  7933.937 |  8134.961 |  9927.762 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128Traits           |       292.782 |  6547.107 |  6370.773 |  9937.150 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128Traits_Core      |       295.568 |  8433.908 |  7731.770 |  9941.176 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128ConstTraits      |       290.898 |  1646.215 |  8176.309 |  9920.388 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128ConstTraits_Core |       291.628 |  8423.713 |  7639.466 |  9918.018 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_Multiply       |      5509.532 |  4976.855 |  6346.490 |  6698.640 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_AdvSimd        |               |  7863.030 |  7671.524 |  9955.697 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_Avx2           |               |           |           |           |
| ShiftLeftConstBenchmark_Int16 | SumSLLFastTraits          |      4975.829 |  7833.233 |  7727.203 |  9944.184 |
| ShiftLeftConstBenchmark_Int32 | SumSLLScalar              |       747.140 |   746.668 |   743.406 |  1406.310 |
| ShiftLeftConstBenchmark_Int32 | SumSLLNetBcl              |               |           |           |  4888.325 |
| ShiftLeftConstBenchmark_Int32 | SumSLLNetBcl_Const        |               |           |           |  4839.851 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Basic              |      3245.731 |  3236.820 |  2974.247 |  4689.261 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Base_Core          |      3901.744 |  3890.273 |  4073.205 |  4791.678 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Multiply           |      3255.281 |  3237.648 |  2970.501 |  3198.745 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_AdvSimd            |               |  3537.330 |  3224.116 |  3790.199 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Avx2               |               |           |           |           |
| ShiftLeftConstBenchmark_Int32 | SumSLLTraits              |      3254.751 |  3284.306 |  3489.056 |  4694.099 |
| ShiftLeftConstBenchmark_Int32 | SumSLLTraits_Core         |      4155.259 |  3912.810 |  4121.064 |  4716.312 |
| ShiftLeftConstBenchmark_Int32 | SumSLLConstTraits         |      3273.657 |  3277.066 |  4079.386 |  4699.840 |
| ShiftLeftConstBenchmark_Int32 | SumSLLConstTraits_Core    |      4159.358 |  4157.647 |  3885.342 |  4674.841 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128Traits           |       181.142 |  3269.013 |  3506.917 |  4768.568 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128Traits_Core      |       180.997 |  4154.680 |  3852.825 |  4741.779 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128ConstTraits      |       181.215 |   760.796 |  4080.006 |  4716.192 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128ConstTraits_Core |       181.195 |  3895.904 |  3852.526 |  4683.749 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_Multiply       |      3507.522 |  3243.502 |  3160.888 |  3250.808 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_AdvSimd        |               |  3271.025 |  3885.380 |  4699.791 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_Avx2           |               |           |           |           |
| ShiftLeftConstBenchmark_Int32 | SumSLLFastTraits          |      3272.378 |  3290.393 |  3862.215 |  4692.153 |
| ShiftLeftConstBenchmark_Int64 | SumSLLScalar              |       741.321 |   742.484 |   729.825 |  1337.715 |
| ShiftLeftConstBenchmark_Int64 | SumSLLNetBcl              |               |           |           |  2386.951 |
| ShiftLeftConstBenchmark_Int64 | SumSLLNetBcl_Const        |               |           |           |  2398.953 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Basic              |       484.553 |   483.485 |   475.470 |  2271.897 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Base_Core          |       481.139 |   482.312 |   474.867 |  2351.655 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_AdvSimd            |               |  1634.509 |  1608.189 |  1970.596 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Avx2               |               |           |           |           |
| ShiftLeftConstBenchmark_Int64 | SumSLLTraits              |       484.317 |  1639.404 |  1607.218 |  1974.441 |
| ShiftLeftConstBenchmark_Int64 | SumSLLTraits_Core         |       484.733 |  2096.877 |  1927.358 |  2457.296 |
| ShiftLeftConstBenchmark_Int64 | SumSLLConstTraits         |       471.451 |  1956.929 |  1954.494 |  2448.615 |
| ShiftLeftConstBenchmark_Int64 | SumSLLConstTraits_Core    |       471.176 |  2101.020 |  1930.194 |  2462.932 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128Traits           |       256.496 |  1632.143 |  1618.958 |  1973.590 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128Traits_Core      |       254.428 |  1965.258 |  2072.185 |  2461.206 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128ConstTraits      |       258.025 |   410.206 |  2065.404 |  2458.894 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128ConstTraits_Core |       258.352 |  1965.643 |  2060.660 |  2461.397 |
| ShiftLeftConstBenchmark_Int64 | SumSLLFast_AdvSimd        |               |  1950.940 |  1948.156 |  2456.179 |
| ShiftLeftConstBenchmark_Int64 | SumSLLFast_Avx2           |               |           |           |           |
| ShiftLeftConstBenchmark_Int64 | SumSLLFastTraits          |       471.330 |  1643.357 |  2078.794 |  2453.622 |

