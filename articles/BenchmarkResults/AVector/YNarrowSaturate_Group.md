# Benchmark group - YNarrowSaturate
([← Back](YNarrowSaturate.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

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

