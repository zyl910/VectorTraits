# Benchmark group - YNarrowSaturateUnsigned
([← Back](YNarrowSaturateUnsigned.md))

Unit of data: Million operations per second. The larger the number, the better the performance.
### X86 - AMD Ryzen 7 7840H
| Type                                   | Method                      | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :------------------------------------- | :-------------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_If                |        204.566 |       204.886 |       200.858 |   196.569 |   201.870 |   207.250 |   220.250 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_IfUnrolling4      |        213.971 |       202.584 |       203.911 |   208.503 |   207.701 |   207.281 |   222.739 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_MinMax            |        201.282 |       198.509 |       200.588 |   211.114 |   199.098 |   211.171 |   219.399 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_MinMaxUnrolling4  |        205.630 |       213.004 |       211.031 |   214.353 |   196.464 |   214.714 |   226.543 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_BitMath           |        244.446 |       242.424 |       327.552 |   196.468 |   204.339 |   300.595 |   457.944 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_BitMathUnrolling4 |        380.136 |       371.359 |       395.023 |   205.652 |   225.994 |   300.875 |   476.060 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVectorBase         |      23385.952 |     22375.153 |     21237.894 | 22168.532 | 22533.669 | 21617.735 | 29813.964 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVectorTraits       |      24667.072 |     21727.224 |     46012.334 | 45545.738 | 45563.894 | 42736.043 | 47311.328 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector128Base      |                |               |               |           |           | 14760.317 | 16982.692 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector128Traits    |                |               |     33188.764 | 33036.160 | 32261.256 | 30363.995 | 32905.138 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector256Traits    |                |               |     43806.819 | 44447.391 | 45547.634 | 42928.277 | 46743.004 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector512Base      |                |               |               |           |           |           | 33476.107 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector512Traits    |                |               |               |           |           |           | 45927.865 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector512_Convert  |                |               |               |           |           |           | 44036.810 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrow_If                |        218.537 |       211.750 |       201.762 |   214.410 |   210.781 |   223.858 |   240.143 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrow_MinMax            |        216.384 |       206.831 |       208.196 |   210.916 |   203.361 |   207.394 |   224.646 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrow_BitMath           |        521.132 |       503.318 |       476.479 |   210.668 |   210.251 |   420.980 |   669.702 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVectorBase         |      11097.054 |     10617.703 |     10489.047 | 10916.806 | 10556.129 | 10904.109 | 13207.897 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVectorTraits       |      10605.861 |     10157.029 |     19865.697 | 20603.756 | 19138.145 | 19347.025 | 19440.267 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector128Base      |                |               |               |           |           |  4468.766 |  8658.311 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector128Traits    |                |               |     15003.431 | 15124.086 | 13829.367 | 15205.261 | 15370.970 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector256Traits    |                |               |     19797.669 | 20067.368 | 17929.312 | 19095.417 | 19718.755 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector512Base      |                |               |               |           |           |           | 16781.059 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector512Traits    |                |               |               |           |           |           | 19956.000 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector512_Convert  |                |               |               |           |           |           | 18659.807 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrow_If                |        339.013 |       302.091 |       317.635 |   334.039 |   302.711 |   342.262 |   358.303 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrow_MinMax            |        358.027 |       357.317 |       333.726 |   347.448 |   328.805 |   406.672 |   351.250 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrow_BitMath           |        489.492 |       452.134 |       464.275 |   283.334 |   285.687 |   364.057 |   593.395 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVectorBase         |       3119.099 |      2917.896 |      2975.578 |  3102.540 |  3128.956 |  4315.586 |  6900.410 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVectorTraits       |       3114.160 |      2886.879 |      5172.740 |  5323.134 |  5188.831 |  4426.876 |  9197.232 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector128Base      |                |               |               |           |           |  2389.026 |  3957.278 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector128Traits    |                |               |      1869.335 |  2949.720 |  2987.632 |  2389.584 |  6611.977 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector256Traits    |                |               |      4952.862 |  5379.993 |  5359.762 |  4274.156 |  9016.782 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector512Base      |                |               |               |           |           |           |  8499.564 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector512Traits    |                |               |               |           |           |           |  9785.347 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector512_Clamp    |                |               |               |           |           |           |  8531.044 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector512_Convert  |                |               |               |           |           |           |  9783.303 |

### X86 - Intel Core i5-8250U
| Type                                   | Method                      | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :------------------------------------- | :-------------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_If                |        210.290 |       203.536 |       201.018 |   208.581 |   201.764 |   220.364 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_IfUnrolling4      |        214.910 |       213.991 |       197.357 |   197.149 |   204.595 |   207.427 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_MinMax            |        207.845 |       215.164 |       214.382 |   215.683 |   204.563 |   220.479 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_MinMaxUnrolling4  |        161.728 |       219.769 |       212.146 |   216.559 |   192.274 |   209.212 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_BitMath           |        241.738 |       240.894 |       358.800 |   249.889 |   306.507 |   401.353 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_BitMathUnrolling4 |        384.811 |       383.947 |       420.677 |   270.581 |   324.288 |   389.424 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVectorBase         |      15493.391 |     14850.977 |     13646.959 | 13506.832 | 13635.746 | 16780.535 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVectorTraits       |      15511.929 |     14906.325 |     28513.211 | 25254.194 | 28430.918 | 28577.130 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector128Traits    |                |               |     21120.153 | 19431.592 | 21083.352 | 21324.347 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector256Traits    |                |               |     28443.815 | 28252.470 | 28438.840 | 28307.930 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrow_If                |        214.710 |       215.827 |       214.714 |   214.704 |   212.597 |   222.998 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrow_MinMax            |        213.806 |       215.302 |       212.810 |   212.243 |   215.678 |   208.034 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrow_BitMath           |        512.320 |       515.439 |       496.836 |   292.818 |   292.923 |   505.108 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVectorBase         |       7545.259 |      6795.446 |      6752.904 |  7290.861 |  7559.980 |  9666.440 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVectorTraits       |       7550.500 |      6767.870 |     14317.622 | 14327.770 | 14323.482 | 14442.278 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector128Traits    |                |               |     10688.056 |  9846.518 | 10599.796 | 10750.941 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector256Traits    |                |               |     13664.211 | 12726.347 | 14318.085 | 14299.886 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrow_If                |        286.648 |       285.998 |       323.281 |   309.060 |   320.234 |   329.309 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrow_MinMax            |        281.334 |       282.479 |       297.773 |   283.607 |   325.860 |   328.753 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrow_BitMath           |        525.654 |       526.609 |       507.524 |   371.817 |   371.479 |   458.205 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVectorBase         |       2272.961 |      1912.266 |      2137.906 |  2145.397 |  2162.083 |  2759.052 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVectorTraits       |       2257.793 |      1912.881 |      2824.818 |  2831.598 |  2844.929 |  2568.578 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector128Traits    |                |               |      1228.817 |  1868.665 |  1863.457 |  1347.991 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector256Traits    |                |               |      2822.149 |  2857.186 |  2837.939 |  2597.132 |

### Arm - AWS Arm t4g.small
| Type                                   | Method                      | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :------------------------------------- | :-------------------------- | ------------: | --------: | --------: | --------: | --------: |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_If                |       160.395 |   152.372 |   152.985 |   183.977 |   194.611 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_IfUnrolling4      |       159.076 |   158.559 |   160.156 |   183.710 |   194.261 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_MinMax            |       165.814 |   160.380 |   143.658 |   185.134 |   198.676 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_MinMaxUnrolling4  |       162.931 |   163.771 |   146.893 |   186.134 |   202.474 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_BitMath           |       240.206 |   182.527 |   181.738 |   224.410 |   313.135 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_BitMathUnrolling4 |       236.899 |   178.602 |   179.596 |   220.100 |   310.556 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVectorBase         |      7397.290 |  7111.218 |  7308.332 |  7869.950 |  8674.643 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVectorTraits       |      7197.689 | 13436.919 | 12729.912 | 15478.838 | 13638.465 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector128Base      |               |           |           |  8738.074 |  8670.476 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector128Traits    |       134.350 | 12707.929 | 12866.862 | 15442.255 | 13666.103 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector256Traits    |        88.282 |    80.710 |    58.449 |    63.326 |  9731.132 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector512Base      |               |           |           |           |  1402.253 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector512Traits    |               |           |           |           |  1401.278 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector512_Convert  |               |           |           |           |           |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrow_If                |       165.681 |   165.976 |   165.883 |   191.520 |   215.511 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrow_MinMax            |       156.756 |   156.921 |   156.783 |   197.034 |   203.185 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrow_BitMath           |       289.549 |   217.986 |   217.905 |   282.977 |   442.955 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVectorBase         |      3684.866 |  3597.270 |  3598.296 |  3927.945 |  4364.862 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVectorTraits       |      3588.548 |  6162.156 |  6263.338 |  7862.189 |  6748.584 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector128Base      |               |           |           |  4161.607 |  4376.919 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector128Traits    |        76.329 |  6106.270 |  6211.578 |  8046.649 |  6720.127 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector256Traits    |        47.621 |    52.119 |    51.901 |    60.568 |  4716.002 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector512Base      |               |           |           |           |   700.227 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector512Traits    |               |           |           |           |   701.340 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector512_Convert  |               |           |           |           |           |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrow_If                |       242.590 |   240.209 |   241.904 |   279.967 |   349.904 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrow_MinMax            |       173.459 |   216.431 |   243.111 |   302.892 |   302.689 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrow_BitMath           |       291.850 |   213.331 |   220.450 |   273.596 |   415.355 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVectorBase         |       848.536 |  1363.876 |  1351.115 |  1483.227 |  1480.964 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVectorTraits       |       848.362 |  3109.211 |  3309.175 |  4072.723 |  3386.608 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector128Base      |               |           |           |  1479.529 |  1452.561 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector128Traits    |        53.565 |  3157.716 |  3318.586 |  4102.271 |  3423.840 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector256Traits    |        37.754 |    31.540 |    30.124 |    73.122 |  1561.386 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector512Base      |               |           |           |           |   315.111 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector512Traits    |               |           |           |           |   313.362 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector512_Clamp    |               |           |           |           |           |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector512_Convert  |               |           |           |           |           |

### Arm - Apple M2
| Type                                   | Method                      |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :------------------------------------- | :-------------------------- | --------: | --------: | --------: |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_If                |   258.480 |   312.042 |   316.153 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_IfUnrolling4      |   259.580 |   315.428 |   319.711 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_MinMax            |   251.529 |   311.895 |   315.140 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_MinMaxUnrolling4  |   246.155 |   310.886 |   329.234 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_BitMath           |   614.103 |   775.375 |   853.779 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_BitMathUnrolling4 |   615.383 |   787.514 |   861.691 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVectorBase         | 20665.236 | 21658.674 | 25288.884 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVectorTraits       | 27170.537 | 27189.169 | 27189.656 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector128Base      |           | 25267.009 | 25296.107 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector128Traits    | 27172.855 | 27176.156 | 27194.075 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector256Traits    |   127.931 |   103.520 | 27096.953 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector512Base      |           |           |  3482.798 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector512Traits    |           |           |  3487.108 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector512_Convert  |           |           |           |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrow_If                |   254.241 |   301.085 |   320.474 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrow_MinMax            |   261.290 |   301.260 |   316.396 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrow_BitMath           |   888.296 |  1102.786 |  1257.640 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVectorBase         | 10354.211 | 10872.741 | 12700.998 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVectorTraits       | 13604.283 | 13604.371 | 13608.357 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector128Base      |           | 12765.783 | 12706.184 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector128Traits    | 13603.049 | 13610.004 | 13607.225 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector256Traits    |   119.394 |   146.003 | 13634.028 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector512Base      |           |           |  1757.373 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector512Traits    |           |           |  1754.852 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector512_Convert  |           |           |           |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrow_If                |   428.847 |   477.710 |   551.944 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrow_MinMax            |   467.216 |   538.776 |   485.301 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrow_BitMath           |   886.647 |  1102.491 |  1180.357 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVectorBase         |  4348.938 |  4185.590 |  4351.105 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVectorTraits       |  6794.318 |  6803.915 |  6803.292 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector128Base      |           |  4183.026 |  4347.833 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector128Traits    |  6792.998 |  6801.883 |  6804.021 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector256Traits    |    66.831 |   171.742 |  4719.562 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector512Base      |           |           |   822.139 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector512Traits    |           |           |   821.161 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector512_Clamp    |           |           |           |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector512_Convert  |           |           |           |

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                                   | Method                      | .NET 8.0 |
| :------------------------------------- | :-------------------------- | -------: |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_If                |   19.869 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_IfUnrolling4      |   18.481 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_MinMax            |   15.184 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_MinMaxUnrolling4  |   15.206 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_BitMath           |    8.579 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrow_BitMathUnrolling4 |    8.896 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVectorBase         |    5.175 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVectorTraits       |  179.403 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector128Base      |    4.587 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector128Traits    |  216.085 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector256Traits    |    3.834 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector512Base      |    3.704 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector512Traits    |    3.686 |
| YNarrowSaturateUnsignedBenchmark_Int16 | SumNarrowVector512_Convert  |          |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrow_If                |   18.832 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrow_MinMax            |   14.058 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrow_BitMath           |   10.047 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVectorBase         |    4.548 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVectorTraits       |   89.678 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector128Base      |    2.676 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector128Traits    |  106.646 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector256Traits    |    2.340 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector512Base      |    2.204 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector512Traits    |    2.161 |
| YNarrowSaturateUnsignedBenchmark_Int32 | SumNarrowVector512_Convert  |          |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrow_If                |   22.396 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrow_MinMax            |   16.463 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrow_BitMath           |   10.067 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVectorBase         |    3.542 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVectorTraits       |    1.880 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector128Base      |    1.754 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector128Traits    |    1.918 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector256Traits    |    1.438 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector512Base      |    1.344 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector512Traits    |    1.341 |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector512_Clamp    |          |
| YNarrowSaturateUnsignedBenchmark_Int64 | SumNarrowVector512_Convert  |          |

