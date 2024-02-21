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

