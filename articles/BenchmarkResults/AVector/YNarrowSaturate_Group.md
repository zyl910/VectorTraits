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
| YNarrowSaturateBenchmark_Int16  | SumNarrow_If                |       154.717 |   163.350 |   157.517 |   181.894 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_IfUnrolling4      |       159.933 |   162.280 |   160.958 |   186.372 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_MinMax            |       160.654 |   161.130 |   108.656 |   184.712 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_MinMaxUnrolling4  |       163.235 |   161.581 |   147.669 |   186.407 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_BitMath           |       211.068 |   165.533 |   166.020 |   204.475 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_BitMathUnrolling4 |       208.441 |   162.643 |   164.432 |   205.605 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVectorBase         |      6124.516 |  5210.880 |  6055.721 |  7165.511 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVectorTraits       |      6125.113 | 13574.329 | 13433.471 | 15507.867 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector128Traits    |       122.967 | 13162.718 | 12717.414 | 15494.383 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector256Traits    |        83.310 |    80.201 |    59.168 |    61.795 |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_If                |       163.905 |   165.250 |   160.416 |   190.897 |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_MinMax            |       155.399 |   155.059 |   159.092 |   195.986 |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_BitMath           |       250.603 |   194.406 |   194.647 |   258.280 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVectorBase         |      2701.810 |  3219.290 |  2766.267 |  3025.432 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVectorTraits       |      2703.709 |  6306.022 |  6210.719 |  8003.142 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector128Traits    |        64.792 |  6162.376 |  6214.182 |  7973.790 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector256Traits    |        43.909 |    51.624 |    51.399 |    57.760 |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_If                |       161.985 |   162.089 |   160.805 |   205.371 |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_MinMax            |       154.244 |   153.980 |   165.349 |   197.005 |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_BitMath           |       248.665 |   192.373 |   192.698 |   246.234 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVectorBase         |       716.880 |  1189.192 |  1156.627 |  1229.301 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVectorTraits       |       716.661 |  3282.455 |  3283.969 |  3921.550 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector128Traits    |        45.208 |  3136.169 |  3288.015 |  4018.683 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector256Traits    |        38.886 |    34.024 |    33.802 |    64.422 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_If                |       525.100 |   530.550 |   525.952 |   608.947 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_IfUnrolling4      |       508.270 |   508.098 |   507.538 |   703.331 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_MinMax            |       528.430 |   527.506 |   539.088 |   609.259 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_MinMaxUnrolling4  |       549.095 |   539.612 |   542.428 |   693.162 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_BitMath           |       328.590 |   259.372 |   259.446 |   333.888 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_BitMathUnrolling4 |       322.257 |   247.711 |   249.740 |   333.118 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVectorBase         |      7945.777 |  8739.615 |  7945.913 |  8916.311 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVectorTraits       |      7943.115 | 14158.586 | 14166.207 | 13814.007 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector128Traits    |       193.788 | 14156.330 | 14150.934 | 14565.067 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector256Traits    |       141.126 |   151.522 |   143.255 |   188.272 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_If                |       544.871 |   540.266 |   538.649 |   621.107 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_MinMax            |       541.719 |   536.718 |   535.769 |   621.414 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_BitMath           |       369.511 |   285.434 |   285.617 |   405.954 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVectorBase         |      4001.590 |  4022.504 |  3954.723 |  4379.473 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVectorTraits       |      4018.815 |  6824.637 |  6400.947 |  6722.416 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector128Traits    |       105.701 |  6815.464 |  6891.766 |  6658.424 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector256Traits    |        74.959 |   110.364 |   100.275 |   161.705 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_If                |       620.408 |   620.900 |   622.076 |   828.917 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_MinMax            |       620.012 |   619.806 |   622.201 |   828.565 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_BitMath           |       389.940 |   294.700 |   297.113 |   418.287 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVectorBase         |      1291.051 |  1863.543 |  1869.904 |  1816.732 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVectorTraits       |      1293.997 |  3233.726 |  3491.369 |  3501.256 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector128Traits    |        79.742 |  3225.596 |  3232.074 |  3485.648 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector256Traits    |        62.781 |    70.463 |    72.222 |   150.085 |

