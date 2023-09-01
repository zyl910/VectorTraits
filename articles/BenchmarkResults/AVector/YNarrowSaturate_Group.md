# Benchmark group - YNarrowSaturate
([← Back](YNarrowSaturate.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### x86 - lntel Core i5-8250U
| Type                            | Method                      | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :------------------------------ | :-------------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_If                |        209.442 |       209.620 |       210.928 |   199.480 |   211.138 |   215.694 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_IfUnrolling4      |        211.791 |       214.639 |       204.348 |   207.900 |   208.157 |   207.050 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_MinMax            |        202.714 |       215.451 |       212.224 |   214.893 |   175.099 |   219.752 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_MinMaxUnrolling4  |        202.295 |       217.398 |       214.670 |   215.935 |   198.295 |   211.019 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_BitMath           |        218.053 |       218.622 |       219.532 |   215.891 |   278.037 |   357.095 |
| YNarrowSaturateBenchmark_Int16  | SumNarrow_BitMathUnrolling4 |        310.590 |       311.343 |       335.008 |   229.978 |   278.162 |   333.642 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVectorBase         |      13095.098 |     13774.472 |     13161.165 | 13013.472 | 13168.239 | 15964.293 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVectorTraits       |      13024.364 |     13662.396 |     28118.834 | 25049.004 | 28198.282 | 27819.176 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector128Traits    |                |               |       162.114 |   157.705 |   157.180 | 10867.358 |
| YNarrowSaturateBenchmark_Int16  | SumNarrowVector256Traits    |                |               |     28311.621 | 28142.430 | 24854.897 | 25229.736 |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_If                |        210.834 |       212.404 |       213.735 |   214.810 |   208.985 |   222.597 |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_MinMax            |        212.099 |       211.786 |       210.670 |   205.029 |   210.333 |   208.573 |
| YNarrowSaturateBenchmark_Int32  | SumNarrow_BitMath           |        435.572 |       436.287 |       351.562 |   252.840 |   249.544 |   432.349 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVectorBase         |       6933.036 |      6441.062 |      6584.000 |  7382.254 |  6728.319 |  7703.530 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVectorTraits       |       6856.456 |      6398.525 |     12533.505 | 14263.835 | 12888.771 | 13992.887 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector128Traits    |                |               |        95.191 |    94.005 |    93.253 |  2934.273 |
| YNarrowSaturateBenchmark_Int32  | SumNarrowVector256Traits    |                |               |     12535.974 | 11323.214 | 13852.952 | 14259.430 |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_If                |        195.128 |       186.841 |       195.864 |   199.460 |   193.475 |   204.264 |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_MinMax            |        189.209 |       178.971 |       196.065 |   191.231 |   191.600 |   203.201 |
| YNarrowSaturateBenchmark_Int64  | SumNarrow_BitMath           |        336.713 |       337.350 |       338.055 |   274.323 |   272.471 |   431.140 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVectorBase         |       1959.806 |      1878.724 |      2000.976 |  2118.858 |  1976.264 |  2658.885 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVectorTraits       |       1956.908 |      1872.465 |      2587.636 |  2763.282 |  2689.931 |  2418.496 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector128Traits    |                |               |        51.357 |    52.497 |    52.046 |  1445.545 |
| YNarrowSaturateBenchmark_Int64  | SumNarrowVector256Traits    |                |               |      2601.186 |  2783.439 |  2686.148 |  2408.717 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_If                |       1066.840 |       902.516 |      1078.540 |   974.749 |  1067.768 |  1083.124 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_IfUnrolling4      |       1075.915 |      1094.100 |      1077.851 |  1089.810 |  1087.498 |  1081.280 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_MinMax            |       1066.895 |       903.120 |       901.484 |   959.577 |   900.228 |   823.878 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_MinMaxUnrolling4  |       1179.758 |      1193.562 |      1189.887 |  1173.972 |   765.848 |   798.253 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_BitMath           |        593.881 |       592.270 |       590.122 |   290.599 |   290.472 |   589.448 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrow_BitMathUnrolling4 |        475.848 |       476.352 |       487.407 |   291.817 |   275.111 |   596.794 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVectorBase         |      16884.658 |     17052.914 |     15147.602 | 17094.243 | 17200.043 | 19717.119 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVectorTraits       |      16862.587 |     16975.925 |     21142.034 | 26121.170 | 26440.908 | 24575.123 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector128Traits    |                |               |       275.908 |   276.214 |   276.281 |  9010.950 |
| YNarrowSaturateBenchmark_UInt16 | SumNarrowVector256Traits    |                |               |     23034.836 | 24778.069 | 25097.226 | 23255.032 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_If                |       1116.417 |       961.764 |       856.272 |   901.272 |   872.811 |  1111.046 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_MinMax            |       1115.502 |       902.014 |       900.357 |   877.358 |   839.361 |   854.364 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrow_BitMath           |        512.514 |       510.146 |       442.323 |   258.755 |   257.379 |   647.860 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVectorBase         |       7824.674 |      7015.984 |      8617.594 |  8176.926 |  8059.923 |  8801.283 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVectorTraits       |       7879.556 |      7024.438 |     12181.180 | 10713.260 | 11063.765 | 11314.953 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector128Traits    |                |               |       164.801 |   167.374 |   168.032 |  3513.006 |
| YNarrowSaturateBenchmark_UInt32 | SumNarrowVector256Traits    |                |               |     10663.709 | 10248.304 | 11165.307 | 11405.584 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_If                |        997.327 |       847.431 |       871.820 |   875.547 |   858.060 |  1109.023 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_MinMax            |        865.420 |      1083.437 |      1107.671 |  1095.561 |   886.387 |   735.609 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrow_BitMath           |        713.699 |       711.252 |       721.666 |   566.196 |   564.157 |   655.883 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVectorBase         |       2015.328 |      1971.981 |      1833.610 |  2446.346 |  2636.137 |  3336.732 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVectorTraits       |       2020.405 |      1979.078 |      2918.828 |  3258.796 |  3341.184 |  3108.173 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector128Traits    |                |               |        91.871 |    96.253 |    96.348 |  2238.816 |
| YNarrowSaturateBenchmark_UInt64 | SumNarrowVector256Traits    |                |               |      2959.039 |  3290.313 |  3360.081 |  3231.091 |

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
