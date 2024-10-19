# Benchmark group - YNarrowSaturate
([← Back](YNarrowSaturate.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### X86 - AMD Ryzen 7 7840H
| Type                            | Method                      | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :------------------------------ | :-------------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_If                |        208.976 |       197.924 |       195.466 |   200.430 |   197.261 |   205.623 |   221.224 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_IfUnrolling4      |        214.379 |       207.763 |       205.433 |   209.018 |   208.461 |   213.239 |   218.859 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_MinMax            |        200.034 |       201.184 |       197.505 |   208.715 |   199.736 |   222.635 |   208.102 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_MinMaxUnrolling4  |        206.436 |       210.913 |       211.050 |   213.829 |   198.853 |   219.191 |   217.852 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_BitMath           |        230.931 |       231.703 |       231.229 |   166.954 |   189.938 |   267.536 |   433.581 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_BitMathUnrolling4 |        306.714 |       302.037 |       323.461 |   178.821 |   204.515 |   270.226 |   437.336 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVectorBase         |      21160.119 |     19565.035 |     19063.346 | 19960.925 | 19532.398 | 19258.689 | 24197.090 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVectorTraits       |      20477.038 |     18251.731 |     44050.630 | 45196.128 | 43674.654 | 44677.389 | 47325.429 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector128Base      |                |               |               |           |           | 12153.308 | 14300.947 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector128Traits    |                |               |     32817.086 | 30303.181 | 32497.518 | 33274.592 | 32398.086 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector256Traits    |                |               |     43953.618 | 45254.059 | 43728.433 | 44268.684 | 47270.777 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector512Base      |                |               |               |           |           |           | 25480.586 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector512Traits    |                |               |               |           |           |           | 46125.775 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector512_Convert  |                |               |               |           |           |           | 44992.635 |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_If                |        211.070 |       218.235 |       225.479 |   211.761 |   207.353 |   223.740 |   232.860 |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_MinMax            |        221.396 |       206.735 |       214.815 |   214.341 |   211.238 |   210.944 |   223.415 |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_BitMath           |        464.418 |       423.390 |       351.229 |   197.987 |   199.268 |   348.317 |   551.117 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVectorBase         |       9753.258 |      9549.313 |      9743.042 |  9519.188 |  9577.993 | 10513.071 | 12059.829 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVectorTraits       |       9117.869 |      9253.891 |     20503.088 | 20225.447 | 19198.947 | 19012.815 | 19398.087 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector128Base      |                |               |               |           |           |  4414.235 |  7371.361 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector128Traits    |                |               |     16032.722 | 10767.055 | 13522.821 | 15353.537 | 14003.514 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector256Traits    |                |               |     20395.395 | 19843.148 | 18130.482 | 19492.541 | 19341.192 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector512Base      |                |               |               |           |           |           | 13854.230 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector512Traits    |                |               |               |           |           |           | 19896.890 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector512_Convert  |                |               |               |           |           |           | 19090.544 |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_If                |        207.654 |       206.920 |       215.020 |   207.405 |   207.239 |   220.198 |   227.592 |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_MinMax            |        205.724 |       201.036 |       203.815 |   200.292 |   213.422 |   213.819 |   231.741 |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_BitMath           |        349.700 |       344.637 |       345.614 |   211.870 |   213.703 |   340.272 |   483.755 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVectorBase         |       2951.264 |      2720.663 |      2835.882 |  2949.423 |  2915.473 |  4372.612 |  5917.536 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVectorTraits       |       2941.336 |      2696.543 |      4690.391 |  4875.851 |  4917.149 |  3808.744 |  9411.507 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector128Base      |                |               |               |           |           |  2449.433 |  3475.261 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector128Traits    |                |               |      2006.083 |  2955.944 |  2901.395 |  2495.051 |  7940.087 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector256Traits    |                |               |      4963.393 |  5000.887 |  4966.963 |  3683.941 |  9442.143 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector512Base      |                |               |               |           |           |           |  7279.925 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector512Traits    |                |               |               |           |           |           |  9960.331 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector512_Clamp    |                |               |               |           |           |           |  7215.541 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector512_Convert  |                |               |               |           |           |           | 10021.894 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_If                |       1263.960 |      1205.876 |      1247.409 |  1184.537 |  1124.520 |  1175.733 |  1387.128 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_IfUnrolling4      |       1228.848 |      1123.366 |      1160.886 |  1110.098 |  1142.262 |  1134.191 |  1373.796 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_MinMax            |       1363.298 |      1283.027 |      1336.103 |  1178.860 |  1344.978 |   761.908 |  1487.848 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_MinMaxUnrolling4  |       1346.263 |      1300.561 |      1286.975 |  1306.523 |  1083.484 |   937.092 |  1602.582 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_BitMath           |        612.158 |       585.350 |       590.742 |   197.142 |   195.812 |   472.548 |   719.852 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_BitMathUnrolling4 |        480.198 |       474.883 |       476.484 |   218.805 |   216.810 |   508.845 |   736.505 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVectorBase         |      25617.831 |     25358.182 |     25019.795 | 25056.656 | 26527.170 | 25337.769 | 30941.796 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVectorTraits       |      24795.433 |     24950.279 |     33163.801 | 41303.846 | 40678.067 | 29966.481 | 45560.104 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector128Base      |                |               |               |           |           |  8508.828 | 19354.326 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector128Traits    |                |               |     19854.583 | 25215.196 | 24688.707 | 18118.123 | 31370.112 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector256Traits    |                |               |     33716.319 | 40643.683 | 43639.630 | 31733.343 | 43515.935 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector512Base      |                |               |               |           |           |           | 34333.004 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector512Traits    |                |               |               |           |           |           | 45374.589 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector512_Convert  |                |               |               |           |           |           | 45431.950 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector512_Pack     |                |               |               |           |           |           | 34692.637 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_If                |       1446.297 |      1396.148 |      1364.953 |  1339.805 |  1382.470 |  1240.158 |  1507.078 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_MinMax            |       1461.884 |      1346.542 |      1363.853 |  1376.390 |  1373.016 |   960.104 |  1383.498 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_BitMath           |        556.167 |       551.856 |       464.792 |   223.355 |   220.816 |   566.793 |   871.130 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVectorBase         |      12509.780 |     11160.711 |     11971.259 | 11511.978 | 11080.158 | 11897.237 | 15997.508 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVectorTraits       |      12962.030 |     11581.014 |     14895.009 | 16343.372 | 17051.602 | 14727.107 | 19760.603 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector128Base      |                |               |               |           |           |  4598.785 |  9489.508 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector128Traits    |                |               |      9276.632 | 11443.000 | 11488.181 |  8680.100 | 14081.477 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector256Traits    |                |               |     14585.027 | 16733.952 | 16846.341 | 14669.718 | 19625.999 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector512Base      |                |               |               |           |           |           | 20187.199 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector512Traits    |                |               |               |           |           |           | 21255.152 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector512_Convert  |                |               |               |           |           |           | 20989.131 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector512_Pack     |                |               |               |           |           |           | 20295.873 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_If                |       1003.570 |      1326.642 |       913.881 |   912.071 |   878.848 |  1312.352 |  1874.180 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_MinMax            |       1455.402 |      1404.391 |      1392.157 |   891.629 |   902.245 |   937.792 |   895.795 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_BitMath           |        731.295 |       685.363 |       683.996 |   457.240 |   450.840 |   554.814 |   842.500 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVectorBase         |       3340.377 |      3102.954 |      3033.044 |  3449.113 |  3649.422 |  5104.550 |  7693.314 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVectorTraits       |       3306.018 |      3050.492 |      4497.385 |  5401.914 |  5969.621 |  4527.588 |  9530.757 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector128Base      |                |               |               |           |           |  2704.534 |  5068.074 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector128Traits    |                |               |      2136.396 |  3117.646 |  3137.098 |  2654.322 |  9021.456 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector256Traits    |                |               |      4602.012 |  5090.608 |  5878.031 |  4293.952 |  9444.117 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector512Base      |                |               |               |           |           |           |  9873.078 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector512Traits    |                |               |               |           |           |           | 10029.859 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector512_Clamp    |                |               |               |           |           |           |  9808.525 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector512_Convert  |                |               |               |           |           |           | 10018.529 |

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

### Arm - Apple M2
| Type                            | Method                      |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :------------------------------ | :-------------------------- | --------: | --------: | --------: |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_If                |   259.239 |   313.988 |   319.573 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_IfUnrolling4      |   259.525 |   324.588 |   320.551 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_MinMax            |   248.775 |   311.285 |   313.648 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_MinMaxUnrolling4  |   249.219 |   321.865 |   324.788 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_BitMath           |   536.277 |   697.949 |   817.423 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_BitMathUnrolling4 |   538.456 |   716.261 |   825.550 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVectorBase         | 18906.949 | 20485.803 | 20210.073 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVectorTraits       | 27169.213 | 27188.567 | 27190.966 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector128Base      |           | 20206.487 | 20226.822 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector128Traits    | 27168.944 | 27179.389 | 27191.345 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector256Traits    |   131.747 |   101.672 | 20230.254 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector512Base      |           |           |  3415.605 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector512Traits    |           |           |  3206.987 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector512_Convert  |           |           |           |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_If                |   258.653 |   311.787 |   320.704 |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_MinMax            |   261.437 |   300.766 |   311.212 |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_BitMath           |   765.670 |   975.824 |  1088.657 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVectorBase         |  9525.207 | 10337.378 | 10181.084 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVectorTraits       | 13603.507 | 13609.145 | 13610.696 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector128Base      |           | 10197.022 | 10166.101 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector128Traits    | 13607.521 | 13606.380 | 13609.783 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector256Traits    |   124.034 |   143.208 | 10185.664 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector512Base      |           |           |  1604.462 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector512Traits    |           |           |  1611.747 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector512_Convert  |           |           |           |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_If                |   259.683 |   298.367 |   309.217 |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_MinMax            |   257.590 |   312.277 |   314.984 |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_BitMath           |   754.117 |   940.435 |   992.302 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVectorBase         |  4182.131 |  4530.439 |  3367.829 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVectorTraits       |  6793.625 |  6802.217 |  6802.478 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector128Base      |           |  3370.535 |  3365.327 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector128Traits    |  6793.243 |  6801.454 |  6804.882 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector256Traits    |    70.365 |   122.170 |  3375.141 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector512Base      |           |           |   756.510 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector512Traits    |           |           |   758.031 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector512_Clamp    |           |           |           |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector512_Convert  |           |           |           |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_If                |  1492.504 |  1615.631 |  1698.095 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_IfUnrolling4      |  1469.925 |  2032.898 |  2425.154 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_MinMax            |  1597.277 |  1105.847 |  1696.542 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_MinMaxUnrolling4  |  1465.953 |  1466.964 |  2662.381 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_BitMath           |   982.194 |  1256.318 |  1352.346 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_BitMathUnrolling4 |   970.667 |  1269.848 |  1314.044 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVectorBase         | 24125.030 | 27095.117 | 27122.730 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVectorTraits       | 27179.027 | 27193.560 | 27199.244 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector128Base      |           | 27071.325 | 27117.966 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector128Traits    | 27179.284 | 27184.396 | 27205.375 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector256Traits    |   388.163 |   571.107 | 28322.047 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector512Base      |           |           |  6009.319 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector512Traits    |           |           |  9852.199 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector512_Convert  |           |           |           |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector512_Pack     |           |           |           |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_If                |  1560.454 |  1699.903 |  1697.840 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_MinMax            |  1560.625 |  1133.600 |  1697.695 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_BitMath           |  1100.331 |  1487.859 |  1573.698 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVectorBase         | 12078.072 | 13563.557 | 13582.691 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVectorTraits       | 13603.252 | 13611.053 | 13594.922 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector128Base      |           | 13569.482 | 13578.494 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector128Traits    | 13605.140 | 13593.953 | 13610.400 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector256Traits    |   275.573 |   536.458 | 14210.792 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector512Base      |           |           |  3015.294 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector512Traits    |           |           |  4942.898 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector512_Convert  |           |           |           |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector512_Pack     |           |           |           |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_If                |  1699.931 |  1700.165 |  3021.943 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_MinMax            |  1700.235 |  1133.635 |  3021.954 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_BitMath           |  1156.830 |  1620.023 |  1573.272 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVectorBase         |  5439.933 |  5581.440 |  5254.481 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVectorTraits       |  6802.666 |  6805.388 |  6804.533 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector128Base      |           |  6039.991 |  5254.300 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector128Traits    |  6802.282 |  6804.834 |  6804.696 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector256Traits    |   197.705 |   353.693 |  5255.719 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector512Base      |           |           |  1507.046 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector512Traits    |           |           |  2472.189 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector512_Clamp    |           |           |           |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector512_Convert  |           |           |           |

### Arm - AWS Arm t4g.small
| Type                            | Method                      | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :------------------------------ | :-------------------------- | ------------: | --------: | --------: | --------: | --------: |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_If                |       157.270 |   154.692 |   157.383 |   181.610 |   193.265 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_IfUnrolling4      |       158.321 |   158.508 |   160.305 |   186.059 |   193.602 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_MinMax            |       160.909 |   165.733 |   108.425 |   184.240 |   189.973 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_MinMaxUnrolling4  |       162.742 |   163.387 |   147.011 |   186.203 |   195.226 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_BitMath           |       210.673 |   165.500 |   164.757 |   204.094 |   281.533 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_BitMathUnrolling4 |       208.339 |   162.637 |   163.376 |   204.357 |   283.737 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVectorBase         |      6100.275 |  6193.938 |  6308.118 |  7201.735 |  8261.974 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVectorTraits       |      6102.238 | 13460.358 | 13445.824 | 15514.261 | 13674.647 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector128Base      |               |           |           |  8730.227 |  8161.972 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector128Traits    |       126.853 | 13429.272 | 12853.868 | 15568.535 | 13528.084 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector256Traits    |        88.570 |    81.261 |    58.984 |    61.070 |  8487.915 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector512Base      |               |           |           |           |  1428.184 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector512Traits    |               |           |           |           |  1335.247 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector512_Convert  |               |           |           |           |           |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_If                |       163.854 |   165.352 |   165.160 |   190.240 |   213.807 |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_MinMax            |       154.976 |   162.019 |   161.884 |   195.349 |   194.881 |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_BitMath           |       250.349 |   194.825 |   194.448 |   258.791 |   368.568 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVectorBase         |      3047.923 |  3268.933 |  3253.378 |  3532.128 |  4034.752 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVectorTraits       |      3125.498 |  6121.553 |  6162.533 |  7914.641 |  6782.358 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector128Base      |               |           |           |  4208.391 |  4017.123 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector128Traits    |        71.606 |  6122.989 |  6175.605 |  8017.058 |  6843.500 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector256Traits    |        48.696 |    53.596 |    52.385 |    57.525 |  4084.919 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector512Base      |               |           |           |           |   659.577 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector512Traits    |               |           |           |           |   660.305 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector512_Convert  |               |           |           |           |           |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_If                |       161.788 |   160.690 |   161.656 |   203.670 |   190.163 |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_MinMax            |       160.836 |   157.655 |   164.693 |   194.496 |   201.793 |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_BitMath           |       248.519 |   191.750 |   191.679 |   245.585 |   336.215 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVectorBase         |       728.629 |  1157.104 |  1139.372 |  1231.877 |  1326.584 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVectorTraits       |       727.603 |  3114.720 |  3307.205 |  4088.677 |  3409.341 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector128Base      |               |           |           |  1450.789 |  1328.573 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector128Traits    |        52.069 |  3084.209 |  3313.665 |  4100.966 |  3416.920 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector256Traits    |        40.370 |    32.920 |    31.583 |    63.296 |  1338.381 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector512Base      |               |           |           |           |   304.707 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector512Traits    |               |           |           |           |   304.431 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector512_Clamp    |               |           |           |           |           |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector512_Convert  |               |           |           |           |           |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_If                |       527.761 |   515.076 |   531.818 |   608.056 |   832.441 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_IfUnrolling4      |       506.919 |   508.194 |   507.516 |   701.576 |   836.161 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_MinMax            |       573.087 |   525.410 |   576.628 |   608.744 |   893.594 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_MinMaxUnrolling4  |       548.515 |   544.925 |   542.638 |   692.186 |   915.938 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_BitMath           |       327.919 |   259.389 |   258.320 |   332.968 |   449.076 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_BitMathUnrolling4 |       321.641 |   247.554 |   248.727 |   330.572 |   445.716 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVectorBase         |      8361.120 |  8439.577 |  7945.486 |  8853.731 | 11829.808 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVectorTraits       |      8307.680 | 13106.613 | 14179.297 | 13964.213 | 16532.648 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector128Base      |               |           |           | 10758.370 | 11827.230 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector128Traits    |       200.025 | 13100.479 | 13108.836 | 14024.172 | 16514.181 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector256Traits    |       146.955 |   148.944 |   141.223 |   189.958 | 12315.255 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector512Base      |               |           |           |           |  3233.614 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector512Traits    |               |           |           |           |  4273.747 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector512_Convert  |               |           |           |           |           |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector512_Pack     |               |           |           |           |           |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_If                |       537.550 |   534.718 |   539.467 |   620.874 |   989.646 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_MinMax            |       539.997 |   537.029 |   545.333 |   620.923 |   827.472 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_BitMath           |       366.681 |   285.679 |   285.287 |   404.492 |   609.037 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVectorBase         |      4099.703 |  4021.154 |  3963.463 |  4356.804 |  5896.924 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVectorTraits       |      4024.310 |  6340.994 |  6977.151 |  6619.009 |  7993.300 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector128Base      |               |           |           |  5246.643 |  5773.791 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector128Traits    |       116.727 |  6855.859 |  6439.929 |  6563.849 |  8008.986 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector256Traits    |        81.541 |   105.898 |   106.843 |   162.120 |  5962.081 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector512Base      |               |           |           |           |  1610.932 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector512Traits    |               |           |           |           |  2142.688 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector512_Convert  |               |           |           |           |           |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector512_Pack     |               |           |           |           |           |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_If                |       619.788 |   621.120 |   620.256 |   827.649 |   995.113 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_MinMax            |       619.494 |   620.151 |   620.119 |   818.259 |   994.695 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_BitMath           |       389.265 |   296.914 |   296.184 |   416.534 |   604.653 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVectorBase         |      1229.723 |  1821.232 |  1848.632 |  1805.499 |  2169.309 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVectorTraits       |      1228.911 |  3489.303 |  3526.548 |  3480.212 |  4100.727 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector128Base      |               |           |           |  1828.969 |  2122.309 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector128Traits    |        93.850 |  3234.292 |  3267.989 |  3507.478 |  4069.548 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector256Traits    |        64.301 |    70.135 |    73.275 |   149.018 |  2243.867 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector512Base      |               |           |           |           |   716.931 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector512Traits    |               |           |           |           |   910.327 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector512_Clamp    |               |           |           |           |           |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector512_Convert  |               |           |           |           |           |

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                            | Method                      | .NET 8.0 |
| :------------------------------ | :-------------------------- | -------: |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_If                |   20.517 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_IfUnrolling4      |   18.952 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_MinMax            |   14.458 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_MinMaxUnrolling4  |   14.674 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_BitMath           |    8.610 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_BitMathUnrolling4 |    8.766 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVectorBase         |    5.070 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVectorTraits       |  181.703 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector128Base      |    3.875 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector128Traits    |  212.617 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector256Traits    |    3.118 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector512Base      |    3.163 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector512Traits    |    2.979 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector512_Convert  |          |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_If                |   19.107 |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_MinMax            |   14.330 |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_BitMath           |    9.952 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVectorBase         |    4.400 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVectorTraits       |   89.209 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector128Base      |    2.717 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector128Traits    |  109.763 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector256Traits    |    2.204 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector512Base      |    2.156 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector512Traits    |    2.028 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector512_Convert  |          |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_If                |   21.132 |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_MinMax            |   15.456 |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_BitMath           |   10.105 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVectorBase         |    3.416 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVectorTraits       |    1.784 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector128Base      |    1.770 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector128Traits    |    1.836 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector256Traits    |    1.381 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector512Base      |    1.368 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector512Traits    |    1.259 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector512_Clamp    |          |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector512_Convert  |          |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_If                |   23.491 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_IfUnrolling4      |   22.805 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_MinMax            |   20.428 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_MinMaxUnrolling4  |   20.970 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_BitMath           |   14.425 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_BitMathUnrolling4 |   14.865 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVectorBase         |    8.959 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVectorTraits       |  129.263 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector128Base      |    9.738 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector128Traits    |  149.087 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector256Traits    |    7.646 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector512Base      |    7.666 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector512Traits    |    7.069 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector512_Convert  |          |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector512_Pack     |          |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_If                |   21.626 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_MinMax            |   18.469 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_BitMath           |   15.869 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVectorBase         |    7.159 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVectorTraits       |   64.773 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector128Base      |    4.498 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector128Traits    |   73.364 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector256Traits    |    3.573 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector512Base      |    3.419 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector512Traits    |    3.414 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector512_Convert  |          |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector512_Pack     |          |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_If                |   25.690 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_MinMax            |   21.880 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_BitMath           |   17.055 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVectorBase         |    5.777 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVectorTraits       |    3.406 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector128Base      |    2.867 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector128Traits    |    3.650 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector256Traits    |    2.304 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector512Base      |    2.145 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector512Traits    |    2.108 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector512_Clamp    |          |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector512_Convert  |          |

