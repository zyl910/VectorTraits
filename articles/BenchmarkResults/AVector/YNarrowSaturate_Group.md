# Benchmark group - YNarrowSaturate
([← Back](YNarrowSaturate.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### X86 - AMD Ryzen 7 7840H
| Type                            | Method                      | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :------------------------------ | :-------------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_If                |        208.893 |       208.738 |       210.552 |   208.863 |   213.409 |   222.719 |   238.273 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_IfUnrolling4      |        217.158 |       216.630 |       218.629 |   221.503 |   223.555 |   228.361 |   235.556 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_MinMax            |        213.784 |       221.481 |       222.725 |   213.446 |   210.084 |   237.383 |   222.997 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_MinMaxUnrolling4  |        211.181 |       228.599 |       229.550 |   226.194 |   208.886 |   238.919 |   236.850 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_BitMath           |        229.875 |       229.498 |       228.851 |   169.940 |   205.351 |   305.005 |   526.992 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_BitMathUnrolling4 |        316.482 |       318.147 |       347.112 |   183.350 |   221.339 |   299.835 |   540.668 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVectorBase         |      25148.748 |     24393.350 |     23728.273 | 24093.755 | 24287.096 | 22984.550 | 28211.297 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVectorTraits       |      25758.138 |     24197.346 |     51719.249 | 51042.196 | 52181.566 | 51971.868 | 51767.160 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector128Traits    |                |               |     38722.607 | 38370.034 | 39811.769 | 43939.067 | 35718.360 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector256Traits    |                |               |     51188.180 | 51498.152 | 51863.824 | 52017.120 | 52301.998 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector512Base      |                |               |               |           |           |           | 27065.764 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector512Traits    |                |               |               |           |           |           | 49044.283 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector512_Convert  |                |               |               |           |           |           | 47750.744 |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_If                |        223.199 |       230.356 |       223.827 |   218.194 |   225.068 |   241.795 |   253.186 |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_MinMax            |        227.390 |       225.655 |       229.949 |   225.008 |   232.123 |   235.125 |   241.790 |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_BitMath           |        501.900 |       508.553 |       364.831 |   199.982 |   200.311 |   415.404 |   692.718 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVectorBase         |      11091.485 |     11686.841 |     12169.744 | 11930.394 | 11974.088 | 11432.451 | 13924.358 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVectorTraits       |      11088.565 |     11563.786 |     23670.278 | 24502.961 | 24837.367 | 23689.904 | 21677.977 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector128Traits    |                |               |     18123.739 | 18671.542 | 19224.280 | 20016.846 | 17077.070 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector256Traits    |                |               |     23472.809 | 24605.776 | 25084.681 | 23843.890 | 21690.533 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector512Base      |                |               |               |           |           |           | 15195.383 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector512Traits    |                |               |               |           |           |           | 21155.123 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector512_Convert  |                |               |               |           |           |           | 20674.293 |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_If                |        227.036 |       214.520 |       220.570 |   222.299 |   223.679 |   230.874 |   238.637 |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_MinMax            |        223.303 |       210.577 |       222.049 |   219.301 |   223.062 |   238.317 |   238.675 |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_BitMath           |        358.706 |       359.058 |       358.400 |   216.791 |   217.130 |   377.258 |   604.860 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVectorBase         |       3293.013 |      3312.063 |      3339.831 |  3326.127 |  3430.894 |  5667.124 |  7113.656 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVectorTraits       |       3353.125 |      3297.276 |      5615.250 |  5794.109 |  5863.833 |  4481.222 | 10055.485 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector128Traits    |                |               |      2378.404 |  3455.114 |  3451.902 |  3312.175 |  9339.261 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector256Traits    |                |               |      5427.186 |  5814.520 |  5907.132 |  4431.031 | 10269.472 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector512Base      |                |               |               |           |           |           |  7824.437 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector512Traits    |                |               |               |           |           |           | 10195.687 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector512_Clamp    |                |               |               |           |           |           |  7733.377 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector512_Convert  |                |               |               |           |           |           | 10169.827 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_If                |       1520.727 |      1353.149 |      1417.767 |  1382.095 |  1347.531 |  1411.599 |  1685.738 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_IfUnrolling4      |       1399.387 |      1368.684 |      1356.830 |  1339.406 |  1421.410 |  1484.609 |  1812.324 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_MinMax            |       1431.974 |      1435.180 |      1414.646 |  1374.594 |  1452.314 |  1095.078 |  1441.681 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_MinMaxUnrolling4  |       1522.170 |      1598.674 |      1513.781 |  1481.718 |  1300.826 |  1287.374 |  1785.229 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_BitMath           |        669.162 |       667.766 |       664.758 |   184.324 |   194.878 |   553.552 |   891.000 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_BitMathUnrolling4 |        488.838 |       488.770 |       490.891 |   214.921 |   216.904 |   582.831 |   879.378 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVectorBase         |      29778.616 |     30727.711 |     30155.728 | 31110.346 | 23465.819 | 27716.652 | 37510.004 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVectorTraits       |      30199.224 |     30039.151 |     40324.075 | 51284.626 | 39436.541 | 38153.013 | 52303.410 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector128Traits    |                |               |     24148.204 | 30630.747 | 24290.683 | 22613.799 | 43753.780 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector256Traits    |                |               |     39812.323 | 50842.782 | 40001.161 | 38420.223 | 51197.369 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector512Base      |                |               |               |           |           |           | 36692.778 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector512Traits    |                |               |               |           |           |           | 48338.964 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector512_Convert  |                |               |               |           |           |           | 48223.648 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector512_Pack     |                |               |               |           |           |           | 36487.277 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_If                |       1651.350 |      1656.474 |      1657.393 |  1665.748 |  1298.902 |  1673.605 |  1684.855 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_MinMax            |       1651.554 |      1639.616 |      1661.525 |  1634.196 |  1648.652 |  1104.436 |  1684.422 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_BitMath           |        569.038 |       569.198 |       487.142 |   229.081 |   230.203 |   653.212 |  1111.454 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVectorBase         |      14254.628 |     13925.895 |     14791.805 | 14431.598 | 14687.760 | 15004.943 | 19154.035 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVectorTraits       |      14370.000 |     13868.776 |     19823.383 | 20468.961 | 21760.055 | 18303.374 | 21518.294 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector128Traits    |                |               |     11809.487 | 14870.154 | 15349.610 | 10991.567 | 18385.223 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector256Traits    |                |               |     20061.105 | 20051.064 | 22027.699 | 18025.863 | 22011.407 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector512Base      |                |               |               |           |           |           | 22173.591 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector512Traits    |                |               |               |           |           |           | 22636.186 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector512_Convert  |                |               |               |           |           |           | 22677.879 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector512_Pack     |                |               |               |           |           |           | 21995.081 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_If                |       1658.814 |      1648.733 |      1664.711 |  1639.963 |  1668.689 |  1649.613 |  2342.503 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_MinMax            |       1107.141 |      1661.253 |      1113.017 |  1628.014 |  1653.652 |  1114.979 |  2349.051 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_BitMath           |        799.115 |       804.042 |       793.151 |   509.697 |   512.657 |   625.198 |  1013.328 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVectorBase         |       3660.947 |      3696.134 |      3749.138 |  4037.009 |  4461.080 |  5748.578 |  9324.829 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVectorTraits       |       3665.085 |      3665.804 |      5566.215 |  6321.435 |  7404.890 |  5385.713 |  9964.018 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector128Traits    |                |               |      2652.182 |  3649.313 |  3948.044 |  3408.569 | 10441.784 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector256Traits    |                |               |      5576.564 |  6404.596 |  7607.278 |  5435.066 |  9980.185 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector512Base      |                |               |               |           |           |           | 10553.714 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector512Traits    |                |               |               |           |           |           | 10494.880 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector512_Clamp    |                |               |               |           |           |           | 10610.265 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector512_Convert  |                |               |               |           |           |           | 10455.842 |

### X86 - Intel Core i5-8250U
| Type                            | Method                      | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :------------------------------ | :-------------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_If                |        212.537 |       215.427 |       210.232 |   202.340 |   215.081 |   218.064 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_IfUnrolling4      |        214.535 |       213.600 |       209.482 |   211.497 |   210.797 |   210.469 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_MinMax            |        206.687 |       213.770 |       214.891 |   215.431 |   205.888 |   220.168 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_MinMaxUnrolling4  |        204.927 |       218.256 |       213.052 |   217.077 |   203.125 |   212.180 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_BitMath           |        216.579 |       217.921 |       219.425 |   217.096 |   279.370 |   360.374 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_BitMathUnrolling4 |        313.575 |       313.974 |       336.443 |   230.875 |   278.317 |   337.929 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVectorBase         |      14846.291 |     14087.110 |     13468.290 | 13111.910 | 13235.857 | 15555.509 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVectorTraits       |      14897.766 |     14160.671 |     28429.208 | 28128.607 | 28360.517 | 28421.514 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector128Traits    |                |               |     21265.910 | 21293.082 | 21167.205 | 21438.466 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector256Traits    |                |               |     28397.933 | 28445.982 | 28427.650 | 28585.371 |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_If                |        215.736 |       215.197 |       215.888 |   212.845 |   212.691 |   222.057 |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_MinMax            |        212.320 |       213.881 |       210.443 |   213.826 |   213.730 |   212.865 |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_BitMath           |        441.252 |       441.620 |       354.523 |   252.687 |   252.590 |   434.359 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVectorBase         |       7386.495 |      6751.995 |      6637.639 |  6774.121 |  7434.739 |  8892.525 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVectorTraits       |       7353.112 |      6762.353 |     13986.307 | 14384.912 | 14327.294 | 14428.024 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector128Traits    |                |               |     10650.155 | 10685.906 | 10693.391 | 10184.370 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector256Traits    |                |               |     14297.940 | 14150.012 | 14351.983 | 13000.954 |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_If                |        195.023 |       192.587 |       202.814 |   197.161 |   196.288 |   203.371 |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_MinMax            |        186.045 |       180.554 |       194.672 |   198.782 |   194.294 |   206.325 |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_BitMath           |        339.286 |       339.179 |       338.746 |   275.615 |   275.642 |   431.388 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVectorBase         |       2211.928 |      1912.031 |      2059.889 |  2157.975 |  2160.685 |  2781.300 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVectorTraits       |       2226.565 |      1911.157 |      2624.759 |  2847.360 |  2846.629 |  2539.630 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector128Traits    |                |               |      1126.444 |  1861.054 |  1861.747 |  1498.731 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector256Traits    |                |               |      2628.627 |  2840.202 |  2846.789 |  2538.271 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_If                |       1179.622 |      1016.416 |      1086.797 |   890.792 |   901.329 |  1085.363 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_IfUnrolling4      |       1087.103 |      1087.338 |      1087.144 |  1096.445 |  1104.548 |  1108.743 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_MinMax            |       1276.156 |       885.888 |       977.852 |   918.826 |   933.039 |   794.177 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_MinMaxUnrolling4  |       1191.541 |      1197.103 |      1186.553 |  1188.095 |   781.670 |   881.130 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_BitMath           |        596.777 |       597.211 |       596.792 |   292.049 |   291.997 |   591.696 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_BitMathUnrolling4 |        476.870 |       477.814 |       491.534 |   292.825 |   292.890 |   600.380 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVectorBase         |      16046.720 |     17912.836 |     15463.393 | 17100.289 | 16955.355 | 20342.540 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVectorTraits       |      15844.787 |     18264.191 |     23247.067 | 26147.027 | 26019.558 | 24943.556 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector128Traits    |                |               |     15729.433 | 17667.422 | 18035.155 | 15652.327 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector256Traits    |                |               |     23065.049 | 26319.795 | 26664.041 | 24883.433 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_If                |       1121.385 |       936.738 |       862.041 |   924.369 |   931.181 |  1124.325 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_MinMax            |       1123.806 |       927.532 |       849.694 |   922.200 |   926.491 |   861.181 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_BitMath           |        520.642 |       532.992 |       445.343 |   259.255 |   258.764 |   679.738 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVectorBase         |       8422.320 |      7603.276 |      8610.053 |  8268.696 |  8251.533 | 10319.090 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVectorTraits       |       8454.984 |      7611.850 |     12416.410 | 10913.129 | 11221.684 | 12440.105 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector128Traits    |                |               |      7865.636 |  8839.065 |  8983.880 |  7819.961 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector256Traits    |                |               |     12236.051 | 11425.101 | 11269.070 | 12612.260 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_If                |       1125.294 |       959.392 |      1125.086 |   855.803 |   858.908 |  1124.154 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_MinMax            |       1000.454 |       886.529 |       997.897 |  1124.778 |   914.250 |   837.526 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_BitMath           |        727.660 |       729.096 |       720.707 |   565.243 |   569.982 |   663.393 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVectorBase         |       2025.081 |      2053.017 |      2045.137 |  2576.865 |  2610.890 |  3405.935 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVectorTraits       |       2005.004 |      2053.259 |      2993.174 |  3476.921 |  3519.585 |  3399.524 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector128Traits    |                |               |      1680.652 |  2200.474 |  1917.330 |  2184.109 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector256Traits    |                |               |      2981.285 |  3481.194 |  3563.263 |  3393.832 |

### Arm - AWS Arm t4g.small
| Type                            | Method                      | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :------------------------------ | :-------------------------- | ------------: | --------: | --------: | --------: |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_If                |       157.417 |   154.692 |   157.258 |   181.941 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_IfUnrolling4      |       159.908 |   158.508 |   162.110 |   186.487 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_MinMax            |       160.956 |   165.733 |   108.545 |   184.609 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_MinMaxUnrolling4  |       162.013 |   163.387 |   146.918 |   186.324 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_BitMath           |       211.079 |   165.500 |   165.700 |   205.499 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_BitMathUnrolling4 |       208.453 |   162.637 |   164.249 |   205.436 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVectorBase         |      6044.523 |  6193.938 |  5979.916 |  6778.968 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVectorTraits       |      6039.229 | 13460.358 | 12053.732 | 15472.104 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector128Traits    |       122.891 | 13429.272 | 12658.154 | 15191.105 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector256Traits    |        82.423 |    81.261 |    48.495 |    61.217 |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_If                |       165.309 |   165.352 |   169.826 |   191.086 |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_MinMax            |       162.009 |   162.019 |   153.413 |   195.939 |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_BitMath           |       250.740 |   194.825 |   194.586 |   259.524 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVectorBase         |      3071.364 |  3268.933 |  3154.830 |  3508.643 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVectorTraits       |      3015.939 |  6121.553 |  6164.284 |  7756.942 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector128Traits    |        64.909 |  6122.989 |  6145.077 |  7666.446 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector256Traits    |        45.046 |    53.596 |    50.734 |    57.739 |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_If                |       162.470 |   160.690 |   160.450 |   205.339 |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_MinMax            |       154.207 |   157.655 |   165.821 |   197.450 |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_BitMath           |       248.694 |   191.750 |   192.290 |   246.062 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVectorBase         |       715.642 |  1157.104 |  1137.600 |  1243.915 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVectorTraits       |       715.027 |  3114.720 |  3114.881 |  3958.193 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector128Traits    |        45.484 |  3084.209 |  3084.659 |  4042.758 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector256Traits    |        38.662 |    32.920 |    33.364 |    64.307 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_If                |       528.192 |   515.076 |   517.816 |   608.849 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_IfUnrolling4      |       508.343 |   508.194 |   506.940 |   702.256 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_MinMax            |       575.986 |   525.410 |   573.922 |   608.538 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_MinMaxUnrolling4  |       549.319 |   544.925 |   542.072 |   692.196 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_BitMath           |       328.582 |   259.389 |   258.893 |   333.571 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_BitMathUnrolling4 |       322.312 |   247.554 |   249.095 |   333.070 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVectorBase         |      8754.855 |  8439.577 |  7850.298 |  8862.558 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVectorTraits       |      8617.492 | 13106.613 | 13478.400 | 14063.862 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector128Traits    |       193.712 | 13100.479 | 13479.084 | 14225.569 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector256Traits    |       143.088 |   148.944 |   147.702 |   188.993 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_If                |       541.002 |   534.718 |   534.109 |   620.704 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_MinMax            |       544.926 |   537.029 |   529.782 |   620.851 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_BitMath           |       369.806 |   285.679 |   285.600 |   405.899 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVectorBase         |      3959.347 |  4021.154 |  4200.870 |  4300.706 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVectorTraits       |      3955.773 |  6340.994 |  6282.575 |  6524.682 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector128Traits    |       106.066 |  6855.859 |  6720.106 |  6505.829 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector256Traits    |        76.781 |   105.898 |   105.046 |   159.990 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_If                |       620.385 |   621.120 |   618.355 |   828.085 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_MinMax            |       620.048 |   620.151 |   617.816 |   827.820 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_BitMath           |       389.972 |   296.914 |   296.283 |   418.417 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVectorBase         |      1287.681 |  1821.232 |  1854.543 |  1811.620 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVectorTraits       |      1286.616 |  3489.303 |  3442.668 |  3491.233 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector128Traits    |        80.834 |  3234.292 |  3203.035 |  3483.151 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector256Traits    |        62.778 |    70.135 |    72.817 |   149.185 |

