# Benchmark group - ShiftRightArithmetic
([← Back](ShiftRightArithmetic.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

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

