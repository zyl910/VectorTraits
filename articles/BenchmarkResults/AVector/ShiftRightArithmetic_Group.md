# Benchmark group - ShiftRightArithmetic
([← Back](ShiftRightArithmetic.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### X86 - AMD Ryzen 7 7840H
| Type                                     | Method                    | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :--------------------------------------- | :------------------------ | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAScalar              |       1085.176 |      1043.731 |      1227.822 |  1215.729 |  1209.230 |  1310.645 |  1397.378 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRANetBcl              |                |               |               |           |           | 31888.645 | 35102.079 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRANetBcl_Const        |                |               |               |           |           | 39751.018 | 36630.458 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base_Basic         |       1307.489 |      1448.367 |      1381.192 |  1209.061 |  1411.152 |  1310.703 |  1438.491 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base               |       1830.849 |      1854.774 |      1886.363 |  1801.136 |  1875.459 | 32188.817 | 36216.246 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base_Core          |       1857.705 |      1879.924 |      1880.751 |  1871.746 |  1900.935 | 32301.475 | 38334.086 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_AdvSimd            |                |               |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Avx2               |                |               |     26458.728 | 25406.210 | 26716.495 | 26979.579 | 29283.585 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRATraits              |       1829.405 |      1861.938 |     25643.096 | 26584.675 | 26634.093 | 31578.602 | 37184.123 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRATraits_Core         |       1837.663 |      1874.262 |     33248.481 | 36967.972 | 36890.508 | 37648.798 | 37673.670 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAConstTraits         |       1836.653 |      1880.351 |     28724.613 | 36985.528 | 39429.041 | 32925.588 | 37356.009 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAConstTraits_Core    |       1830.444 |      1879.354 |     33935.625 | 37498.165 | 38127.794 | 33120.549 | 35752.947 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128Bcl              |                |               |               |           |           | 15290.670 | 19798.076 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128Traits           |                |               |     13895.054 | 12946.272 | 13655.680 | 15172.862 | 18581.013 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128Traits_Core      |                |               |     18184.779 | 18346.905 | 18769.553 | 19013.720 | 18487.834 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128ConstTraits      |                |               |     14646.559 | 17707.356 | 19810.496 | 19481.084 | 19506.422 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128ConstTraits_Core |                |               |     18956.104 | 11573.021 | 20194.747 | 21013.970 | 20080.689 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA512Bcl              |                |               |               |           |           |           | 42170.686 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA512Traits           |                |               |               |           |           |           | 44425.480 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFast_AdvSimd        |                |               |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFast_Avx2           |                |               |     28324.744 | 37302.489 | 30763.413 | 32047.925 | 34898.627 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFastTraits          |       1831.163 |      1883.055 |     26762.964 | 37622.502 | 29634.362 | 31775.802 | 36644.749 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAScalar              |       1362.876 |      1321.507 |      1508.831 |  1508.378 |  2226.648 |  2555.622 |  2327.611 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRANetBcl              |                |               |               |           |           | 16806.958 | 15967.982 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRANetBcl_Const        |                |               |               |           |           | 18365.861 | 16092.208 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base_Basic         |        878.964 |       888.932 |       923.860 |   884.939 |   931.285 |   903.434 |   920.310 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base               |        874.854 |       902.735 |       941.800 |   891.514 |   937.361 | 17251.976 | 15935.557 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base_Core          |        923.086 |       938.876 |       933.884 |   970.457 |   945.985 | 17598.842 | 16275.317 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_AdvSimd            |                |               |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Avx2               |                |               |     12590.418 | 13203.383 | 12191.144 | 12965.935 | 13563.944 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRATraits              |        883.925 |       895.137 |     12901.507 | 12508.762 | 11931.480 | 17609.103 | 16282.512 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRATraits_Core         |        919.507 |       931.419 |     15956.786 | 15252.829 | 17412.025 | 18296.493 | 16230.128 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAConstTraits         |        911.750 |       942.523 |     13450.043 | 17314.816 | 14198.095 | 16799.445 | 16393.351 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAConstTraits_Core    |        917.228 |       938.789 |     15344.136 | 15470.629 | 17084.816 | 18274.411 | 16054.229 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128Bcl              |                |               |               |           |           |  9052.085 |  9852.790 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128Traits           |                |               |      7243.292 |  6674.533 |  6771.110 |  9076.860 |  9548.746 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128Traits_Core      |                |               |     10536.832 | 10002.685 |  9972.559 |  9843.782 |  9203.490 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128ConstTraits      |                |               |      7183.865 |  8746.806 | 10049.468 | 10130.878 |  9711.089 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128ConstTraits_Core |                |               |     10083.853 |  9534.407 | 10379.314 |  9910.714 |  9831.192 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA512Bcl              |                |               |               |           |           |           | 18857.829 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA512Traits           |                |               |               |           |           |           | 17399.575 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFast_AdvSimd        |                |               |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFast_Avx2           |                |               |     13491.549 | 17531.887 | 15145.777 | 15119.132 | 15986.324 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFastTraits          |        915.754 |       946.521 |     13266.168 | 15337.171 | 14562.129 | 17003.224 | 16124.004 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAScalar              |       1393.540 |      1331.963 |      1532.719 |  1544.306 |  1513.245 |  1801.859 |  2560.284 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRANetBcl              |                |               |               |           |           |   524.702 |  8652.579 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRANetBcl_Const        |                |               |               |           |           |   557.152 |  8870.207 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Basic         |        478.748 |       491.981 |       527.217 |   508.068 |   529.741 |   513.888 |   494.601 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base               |        479.965 |       492.462 |       518.574 |   499.244 |   527.364 |  2749.760 |  5568.470 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Create        |        455.794 |       468.425 |       474.230 |   461.076 |   483.410 |  5076.663 |  5934.061 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_LoadArray     |        471.308 |       453.826 |       471.966 |   443.598 |   470.467 |  3898.667 |  5466.013 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Core          |        485.190 |       494.099 |       528.659 |   504.275 |   529.423 |  5307.651 |  5925.816 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_AdvSimd            |                |               |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Avx2               |                |               |      4657.784 |  4795.006 |  4861.131 |  4986.076 |  6918.084 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRATraits              |        482.604 |       490.804 |      4949.328 |  4970.328 |  4932.277 |  4902.239 |  7541.726 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRATraits_Core         |        509.432 |       521.769 |      5941.547 |  6050.322 |  6104.433 |  6043.337 |  8537.297 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAConstTraits         |        510.778 |       529.298 |      5526.893 |  5360.460 |  5834.075 |  6217.509 |  7562.071 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAConstTraits_Core    |        509.597 |       531.344 |      5899.752 |  5978.398 |  6049.756 |  6171.211 |  7720.979 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128Bcl              |                |               |               |           |           |   288.633 |  4879.641 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128Traits           |                |               |      2428.206 |  2535.175 |  2394.306 |  2483.545 |  4462.980 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128Traits_Core      |                |               |      3044.874 |  3223.604 |  3089.825 |  3082.909 |  4870.602 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128ConstTraits      |                |               |      2743.132 |  3161.288 |  3083.453 |  3167.907 |  5175.151 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128ConstTraits_Core |                |               |      2971.569 |  3219.111 |  3232.302 |  3254.245 |  5008.581 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA512Bcl              |                |               |               |           |           |           |  9233.596 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA512Traits           |                |               |               |           |           |           |  8205.341 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_AdvSimd        |                |               |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_Avx2           |                |               |      5251.002 |  5667.734 |  5489.498 |  5544.666 |  8567.774 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_Avx2_Negative  |                |               |      4195.656 |  4177.662 |  4214.082 |  4164.737 |  5006.686 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFastTraits          |        511.470 |       522.194 |      5181.733 |  5508.612 |  5584.326 |  5563.034 |  7681.020 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAScalar              |        997.067 |       974.147 |      1278.049 |  1350.082 |  1227.788 |  1328.380 |  1387.993 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRANetBcl              |                |               |               |           |           |  1135.177 |  1113.944 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRANetBcl_Const        |                |               |               |           |           |  1165.780 |  1061.118 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base128_Basic      |                |               |       652.953 |   654.921 |   635.663 |  1695.300 |  1668.513 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base128_Basic_Ref  |                |               |       648.274 |   651.615 |   653.032 |  1695.019 |  1647.898 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base_Basic         |       1808.831 |      1750.576 |      1583.545 |  1537.738 |  1595.144 |  1256.804 |  1741.799 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base               |       3640.252 |      3753.726 |      3708.194 |  3592.541 |  3725.407 | 23814.764 | 24778.021 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base_Core          |       3636.168 |      3759.908 |      3849.300 |  3666.867 |  3828.668 | 35894.626 | 48758.335 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_AdvSimd            |                |               |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Avx2               |                |               |     24251.103 | 23491.234 | 24692.332 | 24571.923 | 43210.970 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRATraits              |       3635.592 |      3696.780 |     24686.302 | 22906.323 | 22437.129 | 24879.962 | 44225.353 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRATraits_Core         |       3652.670 |      3743.427 |     41915.608 | 45147.925 | 45375.300 | 46792.941 | 45642.076 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAConstTraits         |       3651.109 |      3753.761 |     29819.076 | 42019.515 | 43095.169 | 44048.300 | 47091.982 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAConstTraits_Core    |       3662.694 |      3753.270 |     39588.701 | 46397.665 | 47507.648 | 43046.477 | 46878.753 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128Bcl              |                |               |               |           |           |  1043.943 |   766.356 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128Traits           |                |               |     12070.160 | 12072.491 | 12061.983 | 12506.472 | 23761.139 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128Traits_Core      |                |               |     22968.835 | 22500.556 | 22838.586 | 22644.602 | 23295.247 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128ConstTraits      |                |               |     14701.493 | 21452.956 | 22380.417 | 21181.968 | 24014.578 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128ConstTraits_Core |                |               |     23666.644 | 23563.708 | 24068.925 | 21841.167 | 24168.272 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA512Bcl              |                |               |               |           |           |           |   443.286 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA512Traits           |                |               |               |           |           |           | 56521.423 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFast_AdvSimd        |                |               |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFast_Avx2           |                |               |     27946.119 | 38213.836 | 43469.741 | 44051.647 | 47051.119 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFastTraits          |       3648.484 |      3769.918 |     29081.934 | 38244.798 | 43587.765 | 42159.940 | 46807.560 |

### X86 - Intel Core i5-8250U
| Type                                     | Method                    | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :--------------------------------------- | :------------------------ | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAScalar              |        840.149 |       843.238 |      1193.076 |  1199.367 |  1403.341 |  1633.772 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRANetBcl              |                |               |               |           |           | 21116.651 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRANetBcl_Const        |                |               |               |           |           | 22813.874 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base_Basic         |       1041.984 |      1047.181 |       968.008 |   988.818 |   966.420 |  1212.951 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base               |       1579.861 |      1637.991 |      1612.411 |  1601.558 |  1609.517 | 20984.369 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base_Core          |       1721.463 |      1766.398 |      1708.891 |  1711.819 |  1686.769 | 19718.622 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_AdvSimd            |                |               |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Avx2               |                |               |     17911.182 | 18339.131 | 17892.176 | 17795.119 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRATraits              |       1584.078 |      1635.261 |     18042.836 | 18204.327 | 18109.365 | 18681.471 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRATraits_Core         |       1677.911 |      1740.862 |     20725.141 | 20109.157 | 21944.186 | 19586.359 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAConstTraits         |       1696.402 |      1822.398 |     18163.434 | 19374.320 | 21308.042 | 20385.321 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAConstTraits_Core    |       1742.252 |      1863.526 |     21952.651 | 19418.466 | 22027.138 | 20710.309 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128Traits           |                |               |     10343.697 | 10228.038 | 10314.569 | 12001.044 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128Traits_Core      |                |               |     11669.697 | 11690.713 | 11681.519 | 12457.610 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128ConstTraits      |                |               |     10227.651 | 11647.592 | 12181.129 | 13101.970 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128ConstTraits_Core |                |               |     11725.080 | 11647.923 | 12854.584 | 13015.871 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFast_AdvSimd        |                |               |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFast_Avx2           |                |               |     20175.655 | 22053.164 | 20249.540 | 20573.984 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFastTraits          |       1658.668 |      1703.712 |     20083.459 | 20841.444 | 20296.236 | 19834.879 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAScalar              |        837.789 |       838.434 |      1352.958 |  1352.467 |  1655.116 |  1687.610 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRANetBcl              |                |               |               |           |           | 11196.449 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRANetBcl_Const        |                |               |               |           |           | 11782.312 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base_Basic         |        540.547 |       540.201 |       541.195 |   528.241 |   529.246 |   528.573 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base               |        771.030 |       800.133 |       795.454 |   819.018 |   800.784 | 11190.487 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base_Core          |        846.524 |       884.163 |       854.554 |   830.059 |   283.909 | 10750.685 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_AdvSimd            |                |               |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Avx2               |                |               |      9025.787 |  9188.153 |  9288.160 |  9379.651 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRATraits              |        770.647 |       798.196 |      9178.232 |  9236.354 |  8875.456 | 10730.525 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRATraits_Core         |        839.648 |       870.626 |     11755.884 | 11716.871 | 11248.856 | 11053.369 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAConstTraits         |        846.509 |       911.435 |      9318.611 | 11021.465 | 11235.045 | 11376.847 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAConstTraits_Core    |        870.848 |       930.956 |     10597.903 | 11246.438 | 11201.392 | 10432.148 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128Traits           |                |               |      5178.258 |  5137.243 |  5174.259 |  6228.702 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128Traits_Core      |                |               |      6130.943 |  6111.172 |  6501.870 |  6554.065 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128ConstTraits      |                |               |      5179.182 |  5842.198 |  6112.789 |  6453.534 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128ConstTraits_Core |                |               |      6121.559 |  6600.870 |  6120.695 |  6525.161 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFast_AdvSimd        |                |               |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFast_Avx2           |                |               |      9904.295 | 10607.503 |  9632.066 | 10772.310 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFastTraits          |        825.336 |       851.338 |      9545.249 | 10458.977 |  9669.190 | 10755.118 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAScalar              |        836.385 |       835.282 |      1350.369 |  1342.203 |  1351.779 |  1683.693 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRANetBcl              |                |               |               |           |           |   590.279 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRANetBcl_Const        |                |               |               |           |           |   564.839 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Basic         |        452.218 |       449.284 |       488.567 |   468.716 |   473.640 |   490.876 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base               |        435.162 |       471.172 |       488.881 |   458.364 |   472.826 |  2287.847 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Create        |        423.229 |       437.667 |       424.691 |   424.161 |   424.154 |  3108.309 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_LoadArray     |        426.574 |       423.933 |       408.798 |   410.584 |   409.658 |  2957.485 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Core          |        451.569 |       449.479 |       488.578 |   468.363 |   488.039 |  3134.477 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_AdvSimd            |                |               |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Avx2               |                |               |      3219.514 |  3213.113 |  3215.280 |  3195.879 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRATraits              |        434.468 |       471.525 |      3184.687 |  3226.498 |  3218.040 |  3207.783 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRATraits_Core         |        467.624 |       483.857 |      3848.049 |  3855.016 |  3858.747 |  3731.461 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAConstTraits         |        500.897 |       548.966 |      3224.715 |  3235.547 |  3857.005 |  3736.409 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAConstTraits_Core    |        501.624 |       548.592 |      3854.123 |  3854.902 |  3846.748 |  3525.451 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128Traits           |                |               |      1892.076 |  1895.394 |  1893.580 |  1904.689 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128Traits_Core      |                |               |      2261.331 |  2277.126 |  2202.295 |  2225.535 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128ConstTraits      |                |               |      1916.937 |  2186.209 |  2296.869 |  2447.205 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128ConstTraits_Core |                |               |      2254.113 |  2289.301 |  2301.770 |  2461.380 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_AdvSimd        |                |               |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_Avx2           |                |               |      3353.874 |  3332.934 |  3333.292 |  3342.997 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_Avx2_Negative  |                |               |      2616.804 |  2620.282 |  2622.024 |  2621.174 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFastTraits          |        486.690 |       503.650 |      3356.166 |  3351.205 |  3352.930 |  3349.395 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAScalar              |        845.031 |       845.094 |      1119.888 |  1126.648 |  1404.378 |  1624.119 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRANetBcl              |                |               |               |           |           |  1180.012 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRANetBcl_Const        |                |               |               |           |           |  1177.082 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base128_Basic      |                |               |       658.295 |   659.118 |   657.895 |  1562.003 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base128_Basic_Ref  |                |               |       658.694 |   658.447 |   658.824 |  1563.038 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base_Basic         |        924.925 |      1161.971 |      1181.715 |  1116.367 |  1123.595 |  1288.323 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base               |       3156.803 |      3270.693 |      3219.602 |  3177.271 |  3212.566 | 20247.087 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base_Core          |       3429.808 |      3529.103 |      3419.576 |  3429.507 |  3373.462 | 27273.709 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_AdvSimd            |                |               |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Avx2               |                |               |     18504.842 | 18524.654 | 18447.697 | 21268.607 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRATraits              |       3153.252 |      3260.950 |     18386.183 | 18536.103 | 18522.999 | 21210.612 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRATraits_Core         |       3356.234 |      3470.118 |     31296.211 | 31360.721 | 31328.676 | 32838.468 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAConstTraits         |       3385.809 |      3641.392 |     22145.325 | 28425.517 | 30836.577 | 33258.277 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAConstTraits_Core    |       3477.428 |      3724.250 |     31498.676 | 31479.345 | 31447.480 | 34186.649 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128Traits           |                |               |      8968.038 |  8952.113 |  9313.649 | 10769.494 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128Traits_Core      |                |               |     17683.142 | 17720.560 | 17564.807 | 18665.642 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128ConstTraits      |                |               |     12541.420 | 16002.988 | 17443.902 | 17662.646 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128ConstTraits_Core |                |               |     17627.373 | 17592.686 | 17577.020 | 17661.984 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFast_AdvSimd        |                |               |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFast_Avx2           |                |               |     24462.338 | 26765.635 | 30013.622 | 32016.128 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFastTraits          |       3307.606 |      3465.987 |     24286.313 | 26500.990 | 29505.447 | 31784.911 |

### Arm - Apple M2
| Type                                     | Method                    |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :--------------------------------------- | :------------------------ | --------: | --------: | --------: |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAScalar              |  1659.137 |  1689.909 |  1165.817 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRANetBcl              |           | 13615.524 | 13614.299 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRANetBcl_Const        |           | 13614.666 | 13617.127 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base_Basic         |  2267.421 |  2473.252 |  2720.678 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base               |  4535.267 | 13617.769 | 13619.558 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base_Core          |  6038.671 | 13614.098 | 13617.044 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_AdvSimd            | 13580.990 | 13576.059 | 13618.256 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Avx2               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRATraits              | 13582.299 | 13614.972 | 13617.444 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRATraits_Core         | 13612.198 | 13611.891 | 13617.402 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAConstTraits         | 13613.375 | 13613.691 | 13620.016 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAConstTraits_Core    | 13612.120 | 13612.274 | 13614.072 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128Bcl              |           | 13614.631 | 13614.194 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128Traits           | 13581.226 | 13615.019 | 13613.813 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128Traits_Core      | 13610.432 | 13611.941 | 13615.329 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128ConstTraits      | 13610.703 | 13613.382 | 13616.589 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128ConstTraits_Core | 13611.597 | 13615.745 | 13614.638 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA512Bcl              |           |           | 44812.445 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA512Traits           |           |           | 44818.797 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFast_AdvSimd        | 13610.536 | 13588.571 | 13616.004 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFast_Avx2           |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFastTraits          | 13614.024 | 13612.397 | 13614.018 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAScalar              |  1730.990 |  2299.848 |  1744.948 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRANetBcl              |           |  6803.779 |  6804.410 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRANetBcl_Const        |           |  6805.033 |  6805.900 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base_Basic         |  1700.297 |  1943.291 |  2266.651 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base               |  2718.689 |  6804.795 |  6806.261 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base_Core          |  3019.132 |  6804.295 |  6804.530 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_AdvSimd            |  6796.078 |  6795.258 |  6805.488 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Avx2               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRATraits              |  6795.528 |  6805.255 |  6806.184 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRATraits_Core         |  6803.692 |  6805.755 |  6804.233 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAConstTraits         |  6804.269 |  6805.055 |  6805.264 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAConstTraits_Core    |  6804.194 |  6804.617 |  6806.379 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128Bcl              |           |  6804.503 |  6805.979 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128Traits           |  6795.811 |  6804.712 |  6806.505 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128Traits_Core      |  6803.747 |  6803.936 |  6805.613 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128ConstTraits      |  6802.983 |  6804.643 |  6804.685 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128ConstTraits_Core |  6803.748 |  6804.028 |  6806.825 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA512Bcl              |           |           | 22315.025 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA512Traits           |           |           | 22316.239 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFast_AdvSimd        |  6803.691 |  6804.744 |  6805.431 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFast_Avx2           |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFastTraits          |  6803.600 |  6803.336 |  6805.498 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAScalar              |  1720.956 |  2259.968 |  1699.912 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRANetBcl              |           |  3399.593 |  3401.548 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRANetBcl_Const        |           |  3401.234 |  3401.891 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Basic         |  1643.328 |  1699.454 |  2076.742 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base               |  1643.537 |  3401.140 |  3401.617 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Create        |  1510.754 |  3400.571 |  3401.798 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_LoadArray     |  1133.726 |  3400.638 |  3402.171 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Core          |  1642.058 |  3401.287 |  3401.469 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_AdvSimd            |  3398.127 |  3398.780 |  3401.597 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Avx2               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRATraits              |  3399.435 |  3399.631 |  3401.709 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRATraits_Core         |  3401.381 |  3401.425 |  3402.096 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAConstTraits         |  3400.988 |  3402.320 |  3401.676 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAConstTraits_Core    |  3401.544 |  3401.128 |  3401.407 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128Bcl              |           |  3400.723 |  3402.177 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128Traits           |  3399.137 |  3399.297 |  3401.931 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128Traits_Core      |  3401.483 |  3401.274 |  3401.484 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128ConstTraits      |  3401.854 |  3400.799 |  3401.942 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128ConstTraits_Core |  3400.970 |  3401.391 |  3401.434 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA512Bcl              |           |           | 11444.530 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA512Traits           |           |           | 11444.550 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_AdvSimd        |  3401.484 |  3401.781 |  3401.283 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_Avx2           |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_Avx2_Negative  |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFastTraits          |  3401.436 |  3401.803 |  3401.641 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAScalar              |  1688.015 |  1689.821 |  1166.226 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRANetBcl              |           | 27229.708 | 27235.540 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRANetBcl_Const        |           | 27233.426 | 27236.305 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base128_Basic      |  1585.657 |  4320.039 |  4325.723 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base128_Basic_Ref  |  1586.735 |  4320.794 |  4325.268 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base_Basic         |  2871.433 |  2863.264 |  3017.621 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base               |  9063.885 | 19752.906 | 21722.368 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base_Core          | 12064.226 | 27130.494 | 27211.362 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_AdvSimd            | 27095.310 | 27093.700 | 27250.395 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Avx2               |           |           |           |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRATraits              | 27101.525 | 27103.833 | 27250.592 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRATraits_Core         | 27226.168 | 27224.639 | 27245.065 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAConstTraits         | 27222.911 | 27215.844 | 27245.258 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAConstTraits_Core    | 27227.288 | 27237.797 | 27240.233 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128Bcl              |           | 27227.664 | 27249.601 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128Traits           | 27107.088 | 27097.551 | 27242.876 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128Traits_Core      | 27218.950 | 27225.390 | 27236.615 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128ConstTraits      | 27227.452 | 27233.391 | 27244.497 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128ConstTraits_Core | 27227.884 | 27236.661 | 27236.870 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA512Bcl              |           |           | 89603.359 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA512Traits           |           |           | 89635.626 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFast_AdvSimd        | 27229.755 | 27233.782 | 27235.843 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFast_Avx2           |           |           |           |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFastTraits          | 27230.463 | 27230.166 | 27240.443 |

### Arm - AWS Arm t4g.small
| Type                                     | Method                    | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :--------------------------------------- | :------------------------ | ------------: | --------: | --------: | --------: | --------: |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAScalar              |       604.429 |   602.027 |   606.297 |   818.740 |   830.302 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRANetBcl              |               |           |           |  9941.412 |  9837.372 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRANetBcl_Const        |               |           |           |  9931.397 |  9838.530 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base_Basic         |       533.525 |   524.277 |   523.008 |   549.040 |   541.738 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base               |      1648.280 |  1699.319 |  1710.962 |  9933.717 |  9817.663 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base_Core          |      1930.771 |  1917.718 |  1939.126 |  9937.540 |  9838.272 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_AdvSimd            |               |  4894.604 |  5606.209 |  5685.262 |  9727.016 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Avx2               |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRATraits              |      1713.818 |  5611.316 |  4949.502 |  9932.269 |  9837.893 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRATraits_Core         |      1928.197 |  7881.850 |  8435.043 |  9930.918 |  9707.757 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAConstTraits         |      1936.057 |  7776.346 |  8432.064 |  9926.348 |  9834.469 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAConstTraits_Core    |      1895.291 |  7825.036 |  8426.085 |  9923.414 |  9834.395 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128Bcl              |               |           |           |  9935.137 |  9838.923 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128Traits           |       299.263 |  4937.065 |  5636.627 |  9914.529 |  9837.037 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128Traits_Core      |       298.997 |  7858.085 |  8431.198 |  9933.236 |  9707.873 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128ConstTraits      |       290.812 |  6557.489 |  7885.445 |  9933.326 |  9840.065 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128ConstTraits_Core |       289.338 |  7852.609 |  8426.528 |  9933.320 |  9838.351 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA512Bcl              |               |           |           |           | 13404.008 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA512Traits           |               |           |           |           | 13401.551 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFast_AdvSimd        |               |  6613.958 |  8435.237 |  9941.022 |  9836.728 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFast_Avx2           |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFastTraits          |      1924.347 |  7837.752 |  7926.556 |  9942.253 |  9839.610 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAScalar              |       745.287 |   749.467 |   747.486 |  1181.651 |  1244.019 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRANetBcl              |               |           |           |  4929.438 |  4848.848 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRANetBcl_Const        |               |           |           |  4937.824 |  4854.964 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base_Basic         |       329.308 |   331.093 |   329.985 |   338.666 |   328.957 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base               |       894.477 |   912.163 |   916.607 |  4920.628 |  4857.427 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base_Core          |       965.968 |   964.443 |   964.265 |  4936.770 |  4864.883 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_AdvSimd            |               |  2924.942 |  2931.791 |  3298.252 |  4792.779 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Avx2               |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRATraits              |       859.173 |  2815.113 |  2819.116 |  4937.562 |  4813.108 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRATraits_Core         |       945.694 |  3917.314 |  3916.943 |  4933.939 |  4787.843 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAConstTraits         |       967.576 |  3904.750 |  4188.713 |  4901.680 |  4849.051 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAConstTraits_Core    |       947.955 |  3906.471 |  4192.951 |  4908.354 |  4853.184 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128Bcl              |               |           |           |  4923.207 |  4857.072 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128Traits           |       186.486 |  2955.287 |  2812.818 |  4924.175 |  4855.871 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128Traits_Core      |       186.062 |  3904.516 |  4185.602 |  4912.996 |  4788.765 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128ConstTraits      |       185.134 |  3257.396 |  4184.930 |  4910.164 |  4864.386 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128ConstTraits_Core |       186.067 |  3923.326 |  3930.638 |  4903.501 |  4856.939 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA512Bcl              |               |           |           |           |  6594.414 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA512Traits           |               |           |           |           |  6612.354 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFast_AdvSimd        |               |  3907.440 |  4192.300 |  4920.008 |  4826.590 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFast_Avx2           |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFastTraits          |       962.010 |  3905.713 |  3922.750 |  4933.286 |  4857.725 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAScalar              |       738.902 |   734.754 |   741.343 |  1185.217 |  1243.954 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRANetBcl              |               |           |           |  2474.620 |  2433.159 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRANetBcl_Const        |               |           |           |  2478.519 |  2438.677 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Basic         |       488.035 |   475.499 |   476.897 |   485.593 |   472.000 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base               |       479.006 |   208.381 |   476.339 |  2479.619 |  2438.137 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Create        |       188.241 |   477.794 |   482.037 |  1784.358 |  1908.244 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_LoadArray     |       395.595 |   403.796 |   436.109 |  1324.587 |  1630.800 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Core          |       198.848 |   476.691 |   476.218 |  2477.118 |  2423.927 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_AdvSimd            |               |  1386.593 |  1395.666 |  1418.167 |  2424.126 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Avx2               |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRATraits              |       467.838 |  1233.506 |  1233.401 |  1418.970 |  2424.896 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRATraits_Core         |       468.470 |  1952.967 |  1971.453 |  2478.229 |  2424.819 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAConstTraits         |       467.182 |  1939.969 |  1970.321 |  2474.340 |  2413.790 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAConstTraits_Core    |       468.634 |  2095.352 |  2102.958 |  2474.473 |  2432.455 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128Bcl              |               |           |           |  2476.969 |  2432.252 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128Traits           |       269.718 |  1393.287 |  1406.254 |  1421.079 |  2422.886 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128Traits_Core      |       270.903 |  1951.177 |  1970.258 |  2464.070 |  2421.802 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128ConstTraits      |       266.372 |  1936.191 |  2103.984 |  2473.037 |  2436.593 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128ConstTraits_Core |       269.268 |  2079.394 |  2102.662 |  2476.549 |  2432.834 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA512Bcl              |               |           |           |           |  3401.842 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA512Traits           |               |           |           |           |  3409.179 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_AdvSimd        |               |  1922.232 |  2101.308 |  2476.360 |  2434.474 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_Avx2           |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_Avx2_Negative  |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFastTraits          |       466.256 |  1947.109 |  1971.237 |  2477.502 |  2425.048 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAScalar              |       608.671 |   609.771 |   652.251 |   889.935 |   830.400 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRANetBcl              |               |           |           | 19779.972 | 19615.987 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRANetBcl_Const        |               |           |           | 19803.799 | 19613.758 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base128_Basic      |       461.963 |   474.699 |   479.517 |   976.328 |   957.017 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base128_Basic_Ref  |       459.481 |   477.434 |   475.604 |   981.433 |   957.062 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base_Basic         |       732.196 |   704.205 |   710.438 |   760.391 |   748.271 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base               |      3295.628 |  3408.506 |  3410.194 |  7957.665 |  8591.201 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base_Core          |      3883.345 |  3816.472 |  3851.018 | 11338.964 | 14112.821 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_AdvSimd            |               | 11179.766 |  9815.157 | 11342.725 | 19516.555 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Avx2               |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRATraits              |      3482.537 | 11212.340 |  9894.245 | 11352.199 | 19512.654 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRATraits_Core         |      3857.464 | 16756.195 | 15733.712 | 19816.163 | 19419.454 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAConstTraits         |      3905.027 | 15518.199 | 15732.344 | 19791.972 | 19617.529 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAConstTraits_Core    |      3796.018 | 16708.142 | 16787.090 | 19791.891 | 19619.300 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128Bcl              |               |           |           | 19808.239 | 19615.967 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128Traits           |       459.654 | 11081.377 | 11256.845 | 11320.583 | 19298.809 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128Traits_Core      |       457.695 | 15617.279 | 15767.833 | 19809.326 | 19259.375 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128ConstTraits      |       458.626 | 15516.376 | 16821.669 | 19807.724 | 19594.873 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128ConstTraits_Core |       460.036 | 15696.286 | 16802.506 | 19782.592 | 19608.514 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA512Bcl              |               |           |           |           | 27089.953 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA512Traits           |               |           |           |           | 27144.285 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFast_AdvSimd        |               | 13068.034 | 16814.979 | 19831.173 | 19581.084 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFast_Avx2           |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFastTraits          |      3889.986 | 13172.480 | 16823.836 | 19764.481 | 19502.439 |

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                                     | Method                    | .NET 8.0 |
| :--------------------------------------- | :------------------------ | -------: |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAScalar              |   27.008 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRANetBcl              |  169.453 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRANetBcl_Const        |  155.225 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base_Basic         |   19.411 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base               |  168.094 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base_Core          |  169.810 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_AdvSimd            |          |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Avx2               |          |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRATraits              |  126.541 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRATraits_Core         |  129.412 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAConstTraits         |  122.298 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAConstTraits_Core    |  121.677 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128Bcl              |  170.616 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128Traits           |  167.062 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128Traits_Core      |  167.382 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128ConstTraits      |  159.026 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128ConstTraits_Core |  158.226 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA512Bcl              |   32.539 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA512Traits           |   31.505 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFast_AdvSimd        |          |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFast_Avx2           |          |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFastTraits          |  128.201 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAScalar              |   35.079 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRANetBcl              |   82.558 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRANetBcl_Const        |   77.955 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base_Basic         |   17.697 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base               |   83.097 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base_Core          |   87.343 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_AdvSimd            |          |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Avx2               |          |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRATraits              |   64.744 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRATraits_Core         |   63.310 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAConstTraits         |   58.703 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAConstTraits_Core    |   63.655 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128Bcl              |   80.614 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128Traits           |   83.928 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128Traits_Core      |   85.678 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128ConstTraits      |   75.744 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128ConstTraits_Core |   76.266 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA512Bcl              |   16.708 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA512Traits           |   16.693 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFast_AdvSimd        |          |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFast_Avx2           |          |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFastTraits          |   63.302 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAScalar              |   32.491 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRANetBcl              |    6.587 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRANetBcl_Const        |    6.651 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Basic         |    6.204 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base               |    6.531 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Create        |    3.844 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_LoadArray     |    4.465 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Core          |    6.412 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_AdvSimd            |          |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Avx2               |          |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRATraits              |   21.112 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRATraits_Core         |   20.498 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAConstTraits         |   20.646 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAConstTraits_Core    |   20.831 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128Bcl              |    2.915 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128Traits           |   40.301 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128Traits_Core      |   40.748 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128ConstTraits      |   37.071 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128ConstTraits_Core |   38.032 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA512Bcl              |    2.279 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA512Traits           |    3.317 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_AdvSimd        |          |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_Avx2           |          |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_Avx2_Negative  |          |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFastTraits          |    9.817 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAScalar              |   29.396 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRANetBcl              |  331.511 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRANetBcl_Const        |  305.526 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base128_Basic      |   30.735 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base128_Basic_Ref  |   30.092 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base_Basic         |   23.014 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base               |   12.543 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base_Core          |   15.727 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_AdvSimd            |          |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Avx2               |          |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRATraits              |  251.375 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRATraits_Core         |  256.076 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAConstTraits         |  249.414 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAConstTraits_Core    |  243.619 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128Bcl              |  339.105 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128Traits           |  333.295 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128Traits_Core      |  338.592 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128ConstTraits      |  313.056 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128ConstTraits_Core |  309.234 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA512Bcl              |   62.563 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA512Traits           |   60.692 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFast_AdvSimd        |          |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFast_Avx2           |          |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFastTraits          |  261.565 |

