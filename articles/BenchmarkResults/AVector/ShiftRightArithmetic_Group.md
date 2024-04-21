# Benchmark group - ShiftRightArithmetic
([← Back](ShiftRightArithmetic.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### X86 - AMD Ryzen 7 7840H
| Type                                     | Method                    | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :--------------------------------------- | :------------------------ | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAScalar              |       1171.399 |      1166.041 |      1419.611 |  1415.467 |  1390.466 |  1582.887 |  1692.560 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRANetBcl              |                |               |               |           |           | 38990.211 | 45480.708 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRANetBcl_Const        |                |               |               |           |           | 51085.883 | 49811.815 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base_Basic         |       1590.621 |      1611.562 |      1488.214 |  1476.930 |  1504.945 |  1666.601 |  1618.503 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base               |       1922.147 |      1953.305 |      1846.490 |  1893.883 |  1898.200 | 39591.374 | 45473.189 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base_Core          |       1961.224 |      1945.339 |      1884.877 |  2021.035 |  1974.559 | 38930.269 | 49962.608 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_AdvSimd            |                |               |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Avx2               |                |               |     32725.115 | 32473.655 | 33366.433 | 32682.764 | 35690.353 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRATraits              |       1933.799 |      1952.008 |     32420.647 | 33084.184 | 32828.436 | 39253.313 | 50056.396 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRATraits_Core         |       1917.312 |      1959.130 |     43382.862 | 44840.297 | 44950.322 | 44797.366 | 45448.335 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAConstTraits         |       1909.825 |      1954.068 |     32684.978 | 44530.875 | 50718.535 | 50617.180 | 49720.815 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAConstTraits_Core    |       1928.549 |      1958.795 |     43171.777 | 44455.457 | 51038.405 | 51180.952 | 49852.919 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128Traits           |                |               |     17392.658 | 17240.063 | 17366.137 | 17479.882 | 26706.118 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128Traits_Core      |                |               |     22545.143 | 22923.099 | 23742.533 | 23392.030 | 21353.490 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128ConstTraits      |                |               |     17108.197 | 22572.140 | 26644.285 | 26219.577 | 26627.219 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128ConstTraits_Core |                |               |     22067.636 | 22318.709 | 26685.114 | 26514.269 | 26776.935 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA512Bcl              |                |               |               |           |           |           | 49726.778 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA512Traits           |                |               |               |           |           |           | 49712.336 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFast_AdvSimd        |                |               |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFast_Avx2           |                |               |     33317.556 | 44243.162 | 39995.471 | 39625.110 | 44814.026 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFastTraits          |       1926.959 |      1949.727 |     34707.695 | 44696.095 | 39733.406 | 39517.096 | 49812.826 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAScalar              |       1458.693 |      1462.908 |      1575.854 |  1584.234 |  2864.744 |  3174.914 |  3168.167 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRANetBcl              |                |               |               |           |           | 21447.389 | 19836.499 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRANetBcl_Const        |                |               |               |           |           | 22607.586 | 20497.688 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base_Basic         |        934.980 |       973.119 |       912.638 |   971.072 |   975.615 |   947.040 |   977.624 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base               |        920.090 |       959.804 |       936.030 |   959.674 |   971.975 | 21551.082 | 19725.837 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base_Core          |        980.484 |       986.026 |       977.887 |   946.929 |   944.734 | 21380.896 | 20851.055 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_AdvSimd            |                |               |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Avx2               |                |               |     16094.575 | 16074.176 | 16187.903 | 16587.529 | 17390.386 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRATraits              |        954.635 |       962.797 |     15761.197 | 15936.050 | 16176.071 | 21443.963 | 20658.167 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRATraits_Core         |        966.451 |       977.410 |     22516.825 | 23373.253 | 23304.194 | 22481.135 | 18886.492 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAConstTraits         |        960.465 |       978.713 |     16328.673 | 21212.596 | 13299.587 | 22870.142 | 20824.286 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAConstTraits_Core    |        969.862 |       973.550 |     22645.903 | 23443.513 | 23775.141 | 21346.188 | 20608.459 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128Traits           |                |               |      8545.948 |  8612.988 |  8657.604 | 10956.943 | 13068.369 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128Traits_Core      |                |               |     13071.966 | 12962.481 | 13090.368 | 13023.422 | 13107.812 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128ConstTraits      |                |               |      8406.100 | 10887.755 | 13192.491 | 12502.208 | 13093.670 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128ConstTraits_Core |                |               |     12235.400 | 12936.786 | 13166.031 | 12482.674 | 13125.608 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA512Bcl              |                |               |               |           |           |           | 20985.960 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA512Traits           |                |               |               |           |           |           | 20713.851 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFast_AdvSimd        |                |               |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFast_Avx2           |                |               |     16185.477 | 21381.102 | 18041.730 | 17165.242 | 20004.089 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFastTraits          |        961.432 |       970.796 |     16517.599 | 21230.649 | 17937.382 | 21300.184 | 20468.399 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAScalar              |       1472.038 |      1455.150 |      1705.865 |  1693.052 |  1709.106 |  2025.909 |  3119.944 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRANetBcl              |                |               |               |           |           |   537.586 | 10890.092 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRANetBcl_Const        |                |               |               |           |           |   566.630 | 10107.206 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Basic         |        517.500 |       526.905 |       525.020 |   547.261 |   544.797 |   535.672 |   546.175 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base               |        515.654 |       526.276 |       520.725 |   538.545 |   545.826 |  3353.664 |  7073.438 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Create        |        485.269 |       484.498 |       469.470 |   491.179 |   505.160 |  6079.612 |  6670.713 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_LoadArray     |        465.711 |       486.512 |       466.034 |   473.980 |   485.104 |  4913.547 |  7098.344 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Core          |        518.465 |       525.088 |       519.312 |   544.687 |   544.023 |  6473.303 |  7629.063 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_AdvSimd            |                |               |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Avx2               |                |               |      5993.131 |  6108.272 |  6066.710 |  5981.920 |  8829.775 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRATraits              |        518.658 |       525.394 |      5974.104 |  6041.064 |  6047.414 |  6064.753 |  8857.532 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRATraits_Core         |        546.090 |       546.667 |      7510.838 |  7553.755 |  7587.176 |  7410.538 | 10158.073 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAConstTraits         |        543.545 |       546.760 |      6489.149 |  6575.149 |  7552.906 |  7439.295 | 10190.974 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAConstTraits_Core    |        543.977 |       546.112 |      7497.869 |  7547.555 |  7612.583 |  7598.535 | 10684.150 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128Traits           |                |               |      3022.467 |  3045.744 |  3061.796 |  3024.116 |  5372.762 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128Traits_Core      |                |               |      3575.415 |  3724.513 |  3865.838 |  3909.786 |  6582.417 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128ConstTraits      |                |               |      3293.671 |  3844.280 |  3899.565 |  3895.479 |  6599.390 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128ConstTraits_Core |                |               |      3333.819 |  3843.451 |  3865.816 |  3840.621 |  6598.573 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA512Bcl              |                |               |               |           |           |           | 10657.570 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA512Traits           |                |               |               |           |           |           |  8950.917 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_AdvSimd        |                |               |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_Avx2           |                |               |      6512.126 |  6740.909 |  6786.223 |  6746.194 | 10805.081 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_Avx2_Negative  |                |               |      5200.320 |  5226.502 |  5241.382 |  5212.670 |  6513.693 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFastTraits          |        543.920 |       547.986 |      6442.557 |  6776.645 |  6772.848 |  6846.256 | 10191.593 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAScalar              |       1095.479 |      1105.136 |      1629.709 |  1659.794 |  1369.240 |  1525.190 |  1586.676 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRANetBcl              |                |               |               |           |           |  1354.521 |  1364.070 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRANetBcl_Const        |                |               |               |           |           |  1349.030 |  1379.015 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base128_Basic      |                |               |       704.270 |   713.797 |   724.894 |  1795.966 |  1813.976 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base128_Basic_Ref  |                |               |       710.524 |   716.240 |   714.684 |  1804.524 |  1827.361 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base_Basic         |       1902.343 |      1960.038 |      1671.255 |  1616.544 |  1677.088 |  1960.341 |  2103.191 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base               |       3859.903 |      3905.026 |      3689.283 |  3760.506 |  3792.543 | 29890.024 | 33885.007 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base_Core          |       3876.342 |      3923.078 |      3758.786 |  4055.376 |  3951.688 | 44058.022 | 60653.542 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_AdvSimd            |                |               |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Avx2               |                |               |     28841.037 | 29607.287 | 29211.188 | 30840.622 | 55241.797 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRATraits              |       3883.197 |      3920.857 |     28511.694 | 28854.697 | 29697.144 | 31116.322 | 55613.988 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRATraits_Core         |       3887.064 |      3888.188 |     56774.363 | 56878.490 | 57618.877 | 57217.526 | 62361.830 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAConstTraits         |       3893.712 |      3906.667 |     34871.565 | 52370.752 | 53219.953 | 52347.268 | 60593.016 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAConstTraits_Core    |       3875.812 |      3908.952 |     56781.118 | 57368.576 | 57836.888 | 52437.244 | 62094.753 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128Traits           |                |               |     14840.956 | 14376.426 | 15081.583 | 15168.298 | 30784.243 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128Traits_Core      |                |               |     28855.615 | 28802.226 | 28549.035 | 28561.929 | 30837.909 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128ConstTraits      |                |               |     17552.058 | 26720.736 | 26677.083 | 26288.261 | 31401.848 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128ConstTraits_Core |                |               |     28597.527 | 28727.908 | 28927.881 | 26469.254 | 31244.859 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA512Bcl              |                |               |               |           |           |           |   502.206 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA512Traits           |                |               |               |           |           |           | 61876.950 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFast_AdvSimd        |                |               |               |           |           |           |           |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFast_Avx2           |                |               |     35070.162 | 46486.783 | 53437.455 | 53082.799 | 61977.088 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFastTraits          |       3856.509 |      3890.058 |     34922.808 | 47164.557 | 53465.455 | 53138.415 | 60609.099 |

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

### Arm - AWS Arm t4g.small
| Type                                     | Method                    | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :--------------------------------------- | :------------------------ | ------------: | --------: | --------: | --------: |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAScalar              |       607.828 |   607.345 |   598.402 |   823.024 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRANetBcl              |               |           |           |  9954.129 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRANetBcl_Const        |               |           |           |  9951.495 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base_Basic         |       523.001 |   523.252 |   516.371 |   549.437 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base               |      1606.660 |  1696.802 |   746.642 |  9960.099 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Base_Core          |      1854.449 |  1956.042 |  1909.820 |  9939.727 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_AdvSimd            |               |  5629.659 |  5528.339 |  5687.521 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA_Avx2               |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRATraits              |      1621.081 |  4958.905 |  4890.378 |  9948.477 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRATraits_Core         |      1909.445 |  8432.141 |  8265.428 |  9952.180 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAConstTraits         |      1891.182 |  6630.722 |  8197.125 |  9934.293 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAConstTraits_Core    |      1906.767 |  8427.578 |  8288.203 |  9937.380 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128Traits           |       292.698 |  5643.810 |  5566.951 |  9943.661 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128Traits_Core      |       295.222 |  8424.151 |  8180.479 |  9941.077 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128ConstTraits      |       291.052 |  7855.149 |  7722.716 |  9927.420 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRA128ConstTraits_Core |       292.359 |  8421.416 |  8180.930 |  9929.214 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFast_AdvSimd        |               |  7848.911 |  8194.233 |  9959.014 |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFast_Avx2           |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int16 | SumSRAFastTraits          |      1838.148 |  6605.093 |  7720.844 |  9950.795 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAScalar              |       750.637 |   748.119 |   740.289 |  1176.531 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRANetBcl              |               |           |           |  4866.387 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRANetBcl_Const        |               |           |           |  4870.302 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base_Basic         |       328.017 |   330.819 |   327.806 |   338.639 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base               |       865.885 |   906.274 |   895.934 |  4869.642 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Base_Core          |       923.515 |   964.718 |   960.968 |  4856.067 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_AdvSimd            |               |  2939.852 |  2903.020 |  3286.766 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA_Avx2               |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRATraits              |       813.933 |  2470.893 |  2444.451 |  4870.535 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRATraits_Core         |       963.525 |  3914.050 |  3858.082 |  4869.283 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAConstTraits         |       940.151 |  3885.333 |  4084.852 |  4843.771 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAConstTraits_Core    |       949.954 |  3916.259 |  4087.165 |  4852.290 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128Traits           |       181.273 |  2942.021 |  2448.542 |  4866.181 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128Traits_Core      |       181.112 |  3904.869 |  4093.903 |  4846.512 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128ConstTraits      |       181.118 |  3272.652 |  4119.499 |  4838.237 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRA128ConstTraits_Core |       181.302 |  3917.178 |  3865.873 |  4840.303 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFast_AdvSimd        |               |  3862.874 |  4098.781 |  4864.979 |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFast_Avx2           |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int32 | SumSRAFastTraits          |       919.492 |  3864.866 |  3885.305 |  4867.942 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAScalar              |       743.062 |   741.969 |   740.910 |  1182.604 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRANetBcl              |               |           |           |  2461.702 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRANetBcl_Const        |               |           |           |  2462.585 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Basic         |       478.699 |   474.881 |   473.504 |   485.090 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base               |       209.684 |   475.496 |   481.564 |  2455.917 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Create        |       206.328 |   479.217 |   472.752 |  1777.550 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_LoadArray     |       388.839 |   410.226 |   429.817 |  1321.231 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Base_Core          |       480.603 |   481.203 |   478.819 |  2462.884 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_AdvSimd            |               |  1230.920 |  1397.176 |  1416.348 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA_Avx2               |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRATraits              |       471.088 |  1409.135 |  1224.179 |  1415.718 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRATraits_Core         |       471.510 |  2100.695 |  1951.205 |  2459.283 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAConstTraits         |       471.437 |  1961.367 |  1948.020 |  2459.839 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAConstTraits_Core    |       470.318 |  1968.264 |  2072.287 |  2458.221 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128Traits           |       256.281 |  1229.928 |  1392.079 |  1416.358 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128Traits_Core      |       258.127 |  2091.913 |  1951.087 |  2457.825 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128ConstTraits      |       257.629 |  1954.913 |  2071.421 |  2459.579 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRA128ConstTraits_Core |       254.479 |  1965.847 |  2053.870 |  2456.472 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_AdvSimd        |               |  1957.254 |  2073.874 |  2466.410 |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_Avx2           |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFast_Avx2_Negative  |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_Int64 | SumSRAFastTraits          |       471.194 |  1956.370 |  1933.926 |  2458.773 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAScalar              |       610.356 |   610.073 |   656.649 |   925.837 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRANetBcl              |               |           |           | 19802.147 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRANetBcl_Const        |               |           |           | 19805.305 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base128_Basic      |       460.408 |   475.368 |   477.269 |   976.242 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base128_Basic_Ref  |       464.422 |   479.087 |   470.968 |   976.148 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base_Basic         |       717.935 |   711.793 |   706.193 |   761.188 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base               |      3227.227 |  3434.471 |  3370.373 |  7961.707 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Base_Core          |      3730.648 |  3867.873 |  3869.859 | 11326.963 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_AdvSimd            |               | 11256.112 |  9783.594 | 11336.728 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA_Avx2               |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRATraits              |      3243.691 | 11280.956 |  9822.260 | 11360.525 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRATraits_Core         |      3863.241 | 16817.227 | 15701.835 | 19808.274 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAConstTraits         |      3790.213 | 15628.914 | 15781.410 | 19773.174 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAConstTraits_Core    |      3810.742 | 16816.889 | 16703.652 | 19785.247 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128Traits           |       465.010 | 11269.353 | 11287.905 | 11349.048 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128Traits_Core      |       462.964 | 15745.013 | 15723.169 | 19810.270 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128ConstTraits      |       463.467 | 15681.627 | 16637.017 | 19775.467 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRA128ConstTraits_Core |       464.558 | 15769.839 | 16671.725 | 19781.344 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFast_AdvSimd        |               | 13172.874 | 16758.243 | 19838.051 |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFast_Avx2           |               |           |           |           |
| ShiftRightArithmeticConstBenchmark_SByte | SumSRAFastTraits          |      3712.494 | 13167.475 | 16732.268 | 19810.999 |

