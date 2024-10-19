# Benchmark group - YGroup3ToGroup4
([← Back](YGroup3ToGroup4.md))

Unit of data: Million operations per second. The larger the number, the better the performance.
### X86 - AMD Ryzen 7 7840H
| Type                           | Method                      | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :----------------------------- | :-------------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| YGroup3ToGroup4Benchmark_Byte  | SumBase_Basic               |        125.164 |       365.400 |       386.465 |   387.251 |   416.345 |   380.295 |   466.807 |
| YGroup3ToGroup4Benchmark_Byte  | SumBase_Unzip               |        908.947 |       862.805 |       889.683 |   898.776 |   881.910 |  1212.048 |  1234.241 |
| YGroup3ToGroup4Benchmark_Byte  | SumBase                     |        897.949 |       870.428 |       905.125 |   899.567 |   887.787 |  1211.113 |  1234.563 |
| YGroup3ToGroup4Benchmark_Byte  | SumTraits                   |        915.993 |       853.352 |      7988.200 | 11706.262 | 12112.922 | 11963.325 | 19313.026 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Base_Basic            |                |               |       184.930 |   190.060 |   191.762 |   315.110 |   438.858 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Base_Shuffle          |                |               |               |           |           |   173.883 |   174.102 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Base_Unzip            |                |               |               |           |           |   904.486 |   927.583 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Base                  |                |               |       183.860 |   185.478 |   187.219 |   902.561 |   920.739 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128AdvSimd_Shuffle       |                |               |               |           |           |           |           |
| YGroup3ToGroup4Benchmark_Byte  | Sum128AdvSimd_ShuffleX      |                |               |               |           |           |           |           |
| YGroup3ToGroup4Benchmark_Byte  | Sum128AdvSimdB64_Shuffle    |                |               |               |           |           |           |           |
| YGroup3ToGroup4Benchmark_Byte  | Sum128AdvSimdB64_ShuffleX   |                |               |               |           |           |           |           |
| YGroup3ToGroup4Benchmark_Byte  | Sum128PackedSimd_Shuffle    |                |               |               |           |           |           |           |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Sse_Shuffle           |                |               |      5621.952 |  7926.908 |  7538.700 |  7734.572 |  8393.971 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Sse_ShuffleX          |                |               |               |           |           |           |  9563.121 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Traits                |                |               |      5660.564 |  8314.980 |  7460.086 |  8005.313 |  9863.907 |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Base_Basic            |                |               |       222.192 |   195.277 |   208.675 |   357.615 |   454.477 |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Base_Shuffle          |                |               |               |           |           |   179.518 |   186.290 |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Base_Unzip            |                |               |               |           |           |  1448.459 |  1462.231 |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Base                  |                |               |       222.048 |   202.794 |   219.656 |  1440.932 |  1458.579 |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Avx2_Shuffle          |                |               |      9798.345 | 11951.826 | 12263.188 | 12484.445 | 12982.061 |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Avx2_ShuffleX         |                |               |               |           |           |           | 18349.676 |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Traits                |                |               |      9482.387 | 11908.600 | 12097.966 | 12248.054 | 18589.666 |
| YGroup3ToGroup4Benchmark_Byte  | Sum512Base_Basic            |                |               |               |           |           |           |   441.994 |
| YGroup3ToGroup4Benchmark_Byte  | Sum512Base_Shuffle          |                |               |               |           |           |           |   170.822 |
| YGroup3ToGroup4Benchmark_Byte  | Sum512Base_Unzip            |                |               |               |           |           |           |  2072.140 |
| YGroup3ToGroup4Benchmark_Byte  | Sum512Base                  |                |               |               |           |           |           |  2056.815 |
| YGroup3ToGroup4Benchmark_Byte  | Sum512Avx512_ShuffleX       |                |               |               |           |           |           | 20628.960 |
| YGroup3ToGroup4Benchmark_Byte  | Sum512Traits                |                |               |               |           |           |           | 20758.455 |
| YGroup3ToGroup4Benchmark_Int16 | SumBase_Basic               |        110.589 |       292.761 |       311.171 |   254.333 |   332.064 |   272.292 |   400.701 |
| YGroup3ToGroup4Benchmark_Int16 | SumBase_Unzip               |        549.569 |       430.650 |       552.163 |   552.101 |   552.768 |   780.529 |   783.785 |
| YGroup3ToGroup4Benchmark_Int16 | SumBase                     |        110.667 |       298.733 |       312.219 |   231.551 |   327.501 |   291.659 |   384.070 |
| YGroup3ToGroup4Benchmark_Int16 | SumTraits                   |        108.939 |       283.394 |      4220.894 |  6080.553 |  5917.073 |  5977.648 |  8786.461 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Base_Basic            |                |               |       113.737 |   110.061 |   108.118 |   222.450 |   264.012 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Base_Shuffle          |                |               |               |           |           |    83.653 |    89.145 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Base_Unzip            |                |               |               |           |           |   553.507 |   569.435 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Base                  |                |               |       114.227 |   114.557 |   106.046 |   210.021 |   259.880 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128AdvSimd_Shuffle       |                |               |               |           |           |           |           |
| YGroup3ToGroup4Benchmark_Int16 | Sum128AdvSimd_ShuffleX      |                |               |               |           |           |           |           |
| YGroup3ToGroup4Benchmark_Int16 | Sum128AdvSimdB64_Shuffle    |                |               |               |           |           |           |           |
| YGroup3ToGroup4Benchmark_Int16 | Sum128AdvSimdB64_ShuffleX   |                |               |               |           |           |           |           |
| YGroup3ToGroup4Benchmark_Int16 | Sum128PackedSimd_Shuffle    |                |               |               |           |           |           |           |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Sse_Shuffle           |                |               |      2869.271 |  4065.093 |  4087.712 |  3501.772 |  4220.018 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Sse_ShuffleX          |                |               |               |           |           |           |  4851.907 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Traits                |                |               |      2992.079 |  4068.603 |  3821.887 |  3971.342 |  4771.527 |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Base_Basic            |                |               |       162.266 |   144.518 |   164.895 |   293.749 |   418.400 |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Base_Shuffle          |                |               |               |           |           |    92.259 |    93.287 |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Base_Unzip            |                |               |               |           |           |   851.781 |   851.391 |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Base                  |                |               |       160.590 |   143.121 |   167.277 |   278.159 |   421.233 |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Avx2_Shuffle          |                |               |      5147.465 |  5914.088 |  5806.176 |  6066.006 |  6580.987 |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Avx2_ShuffleX         |                |               |               |           |           |           |  8909.358 |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Traits                |                |               |      5190.890 |  5999.823 |  5950.134 |  6062.408 |  8813.589 |
| YGroup3ToGroup4Benchmark_Int16 | Sum512Base_Basic            |                |               |               |           |           |           |   347.221 |
| YGroup3ToGroup4Benchmark_Int16 | Sum512Base_Shuffle          |                |               |               |           |           |           |    91.326 |
| YGroup3ToGroup4Benchmark_Int16 | Sum512Base_Unzip            |                |               |               |           |           |           |  1139.170 |
| YGroup3ToGroup4Benchmark_Int16 | Sum512Base                  |                |               |               |           |           |           |   344.738 |
| YGroup3ToGroup4Benchmark_Int16 | Sum512Avx512_ShuffleX       |                |               |               |           |           |           |  9684.440 |
| YGroup3ToGroup4Benchmark_Int16 | Sum512Traits                |                |               |               |           |           |           |  9765.652 |
| YGroup3ToGroup4Benchmark_Int32 | SumBase_Basic               |         85.807 |       188.315 |       229.188 |   165.484 |   236.611 |   194.104 |   282.637 |
| YGroup3ToGroup4Benchmark_Int32 | SumBase_Unzip               |         77.446 |       124.777 |       147.670 |   138.098 |   147.985 |   420.453 |   425.662 |
| YGroup3ToGroup4Benchmark_Int32 | SumBase                     |         88.935 |       189.851 |       224.762 |   138.448 |   224.734 |   196.888 |   285.881 |
| YGroup3ToGroup4Benchmark_Int32 | SumTraits                   |         88.861 |       192.967 |      3968.382 |  4165.345 |  4307.685 |  4102.026 |  4407.946 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Base_Basic            |                |               |        73.995 |    70.878 |    68.099 |   126.191 |   193.702 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Base_Shuffle          |                |               |               |           |           |    52.190 |    52.933 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Base_Unzip            |                |               |               |           |           |   358.676 |   374.346 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Base                  |                |               |        72.871 |    71.963 |    68.034 |   131.286 |   160.419 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128AdvSimd_AlignRight    |                |               |               |           |           |           |           |
| YGroup3ToGroup4Benchmark_Int32 | Sum128AdvSimd_Shuffle       |                |               |               |           |           |           |           |
| YGroup3ToGroup4Benchmark_Int32 | Sum128AdvSimd_ShuffleX      |                |               |               |           |           |           |           |
| YGroup3ToGroup4Benchmark_Int32 | Sum128AdvSimdB64_Shuffle    |                |               |               |           |           |           |           |
| YGroup3ToGroup4Benchmark_Int32 | Sum128AdvSimdB64_ShuffleX   |                |               |               |           |           |           |           |
| YGroup3ToGroup4Benchmark_Int32 | Sum128PackedSimd_Shuffle    |                |               |               |           |           |           |           |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Sse_Shuffle           |                |               |      1686.876 |  1971.939 |  2004.896 |  2141.098 |  2176.579 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Sse_ShuffleX          |                |               |               |           |           |           |  2833.934 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Sse_ShuffleXImm       |                |               |      2956.419 |  3522.250 |  3730.410 |  3250.072 |  3796.051 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Traits                |                |               |      2993.824 |  3703.946 |  3585.478 |  3433.977 |  3445.600 |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Base_Basic            |                |               |       100.937 |    90.739 |   110.820 |   190.260 |   278.963 |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Base_Shuffle          |                |               |               |           |           |    46.940 |    46.791 |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Base_Unzip            |                |               |               |           |           |   517.138 |   511.940 |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Base                  |                |               |       112.984 |    85.715 |   115.667 |   190.844 |   281.403 |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Avx2_Shuffle          |                |               |      2464.903 |  2887.687 |  2955.207 |  2975.943 |  3270.271 |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Avx2_ShuffleX         |                |               |               |           |           |           |  4483.545 |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Avx2_ShuffleXImm      |                |               |      4134.183 |  4297.116 |  4161.183 |  4199.877 |  4512.614 |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Traits                |                |               |      4160.323 |  4378.437 |  4205.451 |  4129.612 |  4514.653 |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Base_Basic            |                |               |               |           |           |           |   274.032 |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Base_Shuffle          |                |               |               |           |           |           |    45.779 |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Base_Unzip            |                |               |               |           |           |           |   651.987 |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Base                  |                |               |               |           |           |           |   267.736 |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Avx512_ShuffleX       |                |               |               |           |           |           |  4793.739 |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Avx512_ShuffleXImm    |                |               |               |           |           |           |  3375.921 |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Traits                |                |               |               |           |           |           |  4787.147 |
| YGroup3ToGroup4Benchmark_Int64 | SumBase_Basic               |         61.080 |       106.603 |       136.734 |    91.890 |   136.895 |   110.829 |   171.181 |
| YGroup3ToGroup4Benchmark_Int64 | SumBase                     |         62.373 |       103.691 |       126.664 |    76.471 |   132.293 |   107.636 |   169.166 |
| YGroup3ToGroup4Benchmark_Int64 | SumTraits                   |         64.313 |       109.332 |      2618.861 |  2732.671 |  2765.355 |  2576.212 |  2993.431 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Base_Basic            |                |               |        37.689 |    38.367 |    36.011 |    61.306 |   130.151 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Base_Move             |                |               |               |           |           |    77.326 |   147.568 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Base_Shuffle          |                |               |               |           |           |    33.291 |    31.708 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Base                  |                |               |        40.111 |    39.968 |    44.307 |    77.560 |   147.542 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128AdvSimd_AlignRight    |                |               |               |           |           |           |           |
| YGroup3ToGroup4Benchmark_Int64 | Sum128AdvSimd_Shuffle       |                |               |               |           |           |           |           |
| YGroup3ToGroup4Benchmark_Int64 | Sum128AdvSimd_ShuffleX      |                |               |               |           |           |           |           |
| YGroup3ToGroup4Benchmark_Int64 | Sum128AdvSimdB64_Shuffle    |                |               |               |           |           |           |           |
| YGroup3ToGroup4Benchmark_Int64 | Sum128AdvSimdB64_ShuffleX   |                |               |               |           |           |           |           |
| YGroup3ToGroup4Benchmark_Int64 | Sum128PackedSimd_Shuffle    |                |               |               |           |           |           |           |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Sse_Shuffle           |                |               |      1146.972 |  1744.101 |  1696.895 |  1726.233 |  1745.793 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Sse_ShuffleX          |                |               |               |           |           |           |  1997.779 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Sse_ShuffleXImm       |                |               |      2282.041 |  2689.923 |  2618.050 |  2817.104 |  2811.358 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Traits                |                |               |      2324.759 |  2705.412 |  2809.648 |  2771.045 |  2863.836 |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Base_Basic            |                |               |        58.124 |    51.370 |    65.960 |   111.241 |   166.026 |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Base_Shuffle          |                |               |               |           |           |    25.619 |    25.630 |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Base                  |                |               |        63.867 |    46.916 |    66.089 |   114.311 |   165.744 |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Avx2_Shuffle          |                |               |      1953.935 |  2095.666 |  2022.770 |  2151.232 |  2345.081 |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Avx2_ShuffleX         |                |               |               |           |           |           |  2162.840 |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Avx2_ShuffleXImm      |                |               |      2691.732 |  2728.306 |  2714.484 |  2594.626 |  2901.644 |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Traits                |                |               |      2728.279 |  2712.529 |  2755.957 |  2582.220 |  2942.764 |
| YGroup3ToGroup4Benchmark_Int64 | Sum512Base_Basic            |                |               |               |           |           |           |   163.653 |
| YGroup3ToGroup4Benchmark_Int64 | Sum512Base_Shuffle          |                |               |               |           |           |           |    21.290 |
| YGroup3ToGroup4Benchmark_Int64 | Sum512Base                  |                |               |               |           |           |           |   162.162 |
| YGroup3ToGroup4Benchmark_Int64 | Sum512Avx512_ShuffleX       |                |               |               |           |           |           |  2424.607 |
| YGroup3ToGroup4Benchmark_Int64 | Sum512Avx512_ShuffleXImm    |                |               |               |           |           |           |  1950.340 |
| YGroup3ToGroup4Benchmark_Int64 | Sum512Traits                |                |               |               |           |           |           |  2422.416 |
| YGroup4ToGroup3Benchmark_Byte  | SumBase_Basic               |        138.331 |       399.155 |       401.116 |   389.335 |   405.756 |   376.964 |   530.051 |
| YGroup4ToGroup3Benchmark_Byte  | SumBase_Unzip               |        270.803 |       423.754 |       455.803 |   375.689 |   461.707 |  1165.855 |  1417.676 |
| YGroup4ToGroup3Benchmark_Byte  | SumBase                     |        270.076 |       459.943 |       448.298 |   371.420 |   468.507 |  1170.486 |  1414.576 |
| YGroup4ToGroup3Benchmark_Byte  | SumTraits                   |        291.983 |       435.598 |      9506.626 | 13922.197 | 13812.683 | 13999.827 | 32813.417 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Base_Basic            |                |               |       232.131 |   224.627 |   227.974 |   343.383 |   513.467 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Base_Shuffle          |                |               |               |           |           |   174.321 |   185.751 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Base_Unzip            |                |               |               |           |           |  1212.078 |  1077.083 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Base                  |                |               |       233.531 |   230.689 |   223.172 |  1207.990 |  1072.665 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128AdvSimd_Shuffle       |                |               |               |           |           |           |           |
| YGroup4ToGroup3Benchmark_Byte  | Sum128AdvSimd_ShuffleX      |                |               |               |           |           |           |           |
| YGroup4ToGroup3Benchmark_Byte  | Sum128AdvSimdB64_Shuffle    |                |               |               |           |           |           |           |
| YGroup4ToGroup3Benchmark_Byte  | Sum128AdvSimdB64_ShuffleX   |                |               |               |           |           |           |           |
| YGroup4ToGroup3Benchmark_Byte  | Sum128PackedSimd_Shuffle    |                |               |               |           |           |           |           |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Sse_Shuffle           |                |               |      6618.775 | 10417.150 | 10176.811 | 11611.960 | 12101.282 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Sse_ShuffleX          |                |               |               |           |           |           | 17384.406 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Traits                |                |               |      6310.045 |  9913.021 |  9936.256 | 11729.190 | 16905.897 |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Base_Basic            |                |               |       250.198 |   232.037 |   263.942 |   378.304 |   522.922 |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Base_Shuffle          |                |               |               |           |           |   165.184 |   175.422 |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Base_Unzip            |                |               |               |           |           |  1854.459 |  1673.785 |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Base                  |                |               |       249.608 |   221.333 |   256.735 |  1858.256 |  1670.588 |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Avx2_Shuffle          |                |               |     11346.313 | 13843.737 | 13361.974 | 13924.659 | 16909.693 |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Avx2_ShuffleX         |                |               |               |           |           |           | 33626.822 |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Traits                |                |               |     11894.609 | 13384.700 | 13415.116 | 13945.205 | 34014.393 |
| YGroup4ToGroup3Benchmark_Byte  | Sum512Base_Basic            |                |               |               |           |           |           |   466.955 |
| YGroup4ToGroup3Benchmark_Byte  | Sum512Base_Shuffle          |                |               |               |           |           |           |   175.551 |
| YGroup4ToGroup3Benchmark_Byte  | Sum512Base_Unzip            |                |               |               |           |           |           |  2488.632 |
| YGroup4ToGroup3Benchmark_Byte  | Sum512Base                  |                |               |               |           |           |           |  2494.629 |
| YGroup4ToGroup3Benchmark_Byte  | Sum512Avx512_ShuffleX       |                |               |               |           |           |           | 43822.877 |
| YGroup4ToGroup3Benchmark_Byte  | Sum512Traits                |                |               |               |           |           |           | 43909.330 |
| YGroup4ToGroup3Benchmark_Int16 | SumBase_Basic               |        109.796 |       312.866 |       349.346 |   281.129 |   337.851 |   285.288 |   433.208 |
| YGroup4ToGroup3Benchmark_Int16 | SumBase_Unzip               |        243.454 |       334.621 |       379.668 |   287.585 |   378.713 |   779.799 |   925.207 |
| YGroup4ToGroup3Benchmark_Int16 | SumBase                     |        115.584 |       329.252 |       333.841 |   253.844 |   344.817 |   313.009 |   425.001 |
| YGroup4ToGroup3Benchmark_Int16 | SumTraits                   |        118.107 |       312.740 |      4471.914 |  6582.240 |  6712.485 |  6956.168 | 16596.372 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Base_Basic            |                |               |       126.065 |   140.872 |   141.977 |   219.803 |   295.573 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Base_Shuffle          |                |               |               |           |           |    84.066 |    94.073 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Base_Unzip            |                |               |               |           |           |   725.130 |   674.891 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Base                  |                |               |       133.164 |   136.989 |   140.394 |   230.605 |   291.373 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128AdvSimd_Shuffle       |                |               |               |           |           |           |           |
| YGroup4ToGroup3Benchmark_Int16 | Sum128AdvSimd_ShuffleX      |                |               |               |           |           |           |           |
| YGroup4ToGroup3Benchmark_Int16 | Sum128AdvSimdB64_Shuffle    |                |               |               |           |           |           |           |
| YGroup4ToGroup3Benchmark_Int16 | Sum128AdvSimdB64_ShuffleX   |                |               |               |           |           |           |           |
| YGroup4ToGroup3Benchmark_Int16 | Sum128PackedSimd_Shuffle    |                |               |               |           |           |           |           |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Sse_Shuffle           |                |               |      3243.773 |  5077.047 |  4948.538 |  5961.458 |  6006.662 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Sse_ShuffleX          |                |               |               |           |           |           |  8636.595 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Traits                |                |               |      3390.933 |  5022.753 |  4957.969 |  5652.138 |  8331.670 |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Base_Basic            |                |               |       190.034 |   162.751 |   197.003 |   303.363 |   453.735 |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Base_Shuffle          |                |               |               |           |           |    83.583 |    87.585 |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Base_Unzip            |                |               |               |           |           |  1079.032 |   981.236 |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Base                  |                |               |       192.129 |   165.901 |   184.784 |   307.237 |   434.637 |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Avx2_Shuffle          |                |               |      5528.709 |  6558.912 |  6749.942 |  6718.251 |  8475.126 |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Avx2_ShuffleX         |                |               |               |           |           |           | 16555.087 |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Traits                |                |               |      5477.736 |  6638.655 |  6624.726 |  6838.606 | 16512.073 |
| YGroup4ToGroup3Benchmark_Int16 | Sum512Base_Basic            |                |               |               |           |           |           |   366.871 |
| YGroup4ToGroup3Benchmark_Int16 | Sum512Base_Shuffle          |                |               |               |           |           |           |    87.420 |
| YGroup4ToGroup3Benchmark_Int16 | Sum512Base_Unzip            |                |               |               |           |           |           |  1399.810 |
| YGroup4ToGroup3Benchmark_Int16 | Sum512Base                  |                |               |               |           |           |           |   366.630 |
| YGroup4ToGroup3Benchmark_Int16 | Sum512Avx512_ShuffleX       |                |               |               |           |           |           | 19629.932 |
| YGroup4ToGroup3Benchmark_Int16 | Sum512Traits                |                |               |               |           |           |           | 19004.429 |
| YGroup4ToGroup3Benchmark_Int32 | SumBase_Basic               |         91.743 |       189.875 |       226.261 |   165.724 |   250.735 |   202.625 |   288.617 |
| YGroup4ToGroup3Benchmark_Int32 | SumBase_Unzip               |         86.017 |       125.699 |       142.744 |   142.847 |   151.866 |   423.878 |   494.779 |
| YGroup4ToGroup3Benchmark_Int32 | SumBase                     |         91.081 |       193.425 |       232.803 |   138.522 |   238.374 |   187.426 |   287.026 |
| YGroup4ToGroup3Benchmark_Int32 | SumTraits                   |         95.247 |       189.193 |      4595.679 |  4687.863 |  4653.792 |  4567.658 |  8169.275 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Base_Basic            |                |               |        83.334 |    85.122 |    81.569 |   125.067 |   179.005 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Base_Shuffle          |                |               |               |           |           |    45.608 |    43.207 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Base_Unzip            |                |               |               |           |           |   427.245 |   442.364 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Base                  |                |               |        81.638 |    83.012 |    82.912 |   128.081 |   182.039 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128AdvSimd_AlignRight    |                |               |               |           |           |           |           |
| YGroup4ToGroup3Benchmark_Int32 | Sum128AdvSimd_Shuffle       |                |               |               |           |           |           |           |
| YGroup4ToGroup3Benchmark_Int32 | Sum128AdvSimd_ShuffleX      |                |               |               |           |           |           |           |
| YGroup4ToGroup3Benchmark_Int32 | Sum128AdvSimdB64_Shuffle    |                |               |               |           |           |           |           |
| YGroup4ToGroup3Benchmark_Int32 | Sum128AdvSimdB64_ShuffleX   |                |               |               |           |           |           |           |
| YGroup4ToGroup3Benchmark_Int32 | Sum128PackedSimd_Shuffle    |                |               |               |           |           |           |           |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Sse_Shuffle           |                |               |      1556.126 |  2435.226 |  2449.238 |  2955.803 |  3009.506 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Sse_ShuffleX          |                |               |               |           |           |           |  4187.272 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Sse_ShuffleXImm       |                |               |      4753.224 |  4796.366 |  4758.926 |  4505.109 |  5463.721 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Traits                |                |               |      4835.375 |  4911.851 |  4710.994 |  4643.770 |  5431.747 |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Base_Basic            |                |               |       117.769 |   102.963 |   133.273 |   197.039 |   291.876 |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Base_Shuffle          |                |               |               |           |           |    42.646 |    43.055 |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Base_Unzip            |                |               |               |           |           |   580.527 |   604.466 |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Base                  |                |               |       126.410 |    95.174 |   128.931 |   199.210 |   291.456 |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Avx2_Shuffle          |                |               |      2949.299 |  3315.639 |  3387.961 |  3470.369 |  4275.570 |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Avx2_ShuffleX         |                |               |               |           |           |           |  8018.338 |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Avx2_ShuffleXImm      |                |               |      4745.917 |  4616.005 |  4644.251 |  4563.581 |  5291.225 |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Traits                |                |               |      4706.962 |  4680.139 |  4668.680 |  4528.366 |  7725.525 |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Base_Basic            |                |               |               |           |           |           |   280.261 |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Base_Shuffle          |                |               |               |           |           |           |    41.133 |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Base_Unzip            |                |               |               |           |           |           |   823.997 |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Base                  |                |               |               |           |           |           |   278.662 |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Avx512_ShuffleX       |                |               |               |           |           |           |  9440.370 |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Avx512_ShuffleXImm    |                |               |               |           |           |           |  3630.880 |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Traits                |                |               |               |           |           |           |  9517.029 |
| YGroup4ToGroup3Benchmark_Int64 | SumBase_Basic               |         66.878 |       104.802 |       132.286 |    90.049 |   134.478 |   109.509 |   165.869 |
| YGroup4ToGroup3Benchmark_Int64 | SumBase                     |         65.155 |       104.802 |       128.018 |    75.826 |   130.306 |   109.834 |   171.823 |
| YGroup4ToGroup3Benchmark_Int64 | SumTraits                   |         65.840 |       105.502 |      2846.015 |  2988.565 |  2970.747 |  2923.026 |  4116.096 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Base_Basic            |                |               |        42.984 |    44.235 |    42.421 |    67.314 |    93.226 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Base_Move             |                |               |        53.284 |    53.461 |    53.579 |   104.105 |   152.308 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Base_Shuffle          |                |               |               |           |           |    31.562 |    32.229 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Base                  |                |               |        53.066 |    53.308 |    53.146 |   104.159 |   152.137 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128AdvSimd_AlignRight    |                |               |               |           |           |           |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum128AdvSimd_Shuffle       |                |               |               |           |           |           |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum128AdvSimd_ShuffleX      |                |               |               |           |           |           |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum128AdvSimdB64_AlignRight |                |               |               |           |           |           |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum128AdvSimdB64_Shuffle    |                |               |               |           |           |           |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum128AdvSimdB64_ShuffleX   |                |               |               |           |           |           |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum128PackedSimd_Shuffle    |                |               |               |           |           |           |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Sse_Shuffle           |                |               |      1124.904 |  1744.760 |  1701.806 |  2003.406 |  1992.271 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Sse_ShuffleX          |                |               |               |           |           |           |  2394.354 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Sse_ShuffleXImm       |                |               |      3647.826 |  3539.793 |  3662.741 |  3343.100 |  3546.137 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Traits                |                |               |      3528.674 |  3559.500 |  3653.439 |  3395.542 |  3701.295 |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Base_Basic            |                |               |        63.890 |    55.858 |    74.693 |   112.635 |   168.892 |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Base_Shuffle          |                |               |               |           |           |    18.921 |    24.009 |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Base                  |                |               |        72.382 |    50.275 |    73.244 |   110.685 |   169.195 |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Avx2_Shuffle          |                |               |      1783.227 |  2122.555 |  2105.934 |  2123.479 |  2437.678 |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Avx2_ShuffleX         |                |               |               |           |           |           |  4274.302 |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Avx2_ShuffleXImm      |                |               |      2935.932 |  2931.205 |  2983.878 |  2899.660 |  3475.974 |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Traits                |                |               |      2904.987 |  2886.826 |  2984.785 |  2906.198 |  4219.571 |
| YGroup4ToGroup3Benchmark_Int64 | Sum512Base_Basic            |                |               |               |           |           |           |   168.307 |
| YGroup4ToGroup3Benchmark_Int64 | Sum512Base_Shuffle          |                |               |               |           |           |           |    21.282 |
| YGroup4ToGroup3Benchmark_Int64 | Sum512Base                  |                |               |               |           |           |           |   166.711 |
| YGroup4ToGroup3Benchmark_Int64 | Sum512Avx512_ShuffleX       |                |               |               |           |           |           |  4983.476 |
| YGroup4ToGroup3Benchmark_Int64 | Sum512Avx512_ShuffleXImm    |                |               |               |           |           |           |  2138.180 |
| YGroup4ToGroup3Benchmark_Int64 | Sum512Traits                |                |               |               |           |           |           |  4972.455 |

### Arm - Apple M2
| Type                           | Method                      |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :----------------------------- | :-------------------------- | --------: | --------: | --------: |
| YGroup3ToGroup4Benchmark_Byte  | SumBase_Basic               |   520.529 |   538.412 |   641.209 |
| YGroup3ToGroup4Benchmark_Byte  | SumBase_Unzip               |  1307.385 |  1452.826 |  1459.013 |
| YGroup3ToGroup4Benchmark_Byte  | SumBase                     |  1307.512 |  1452.436 |  1458.918 |
| YGroup3ToGroup4Benchmark_Byte  | SumTraits                   | 13579.136 | 13573.332 | 16457.464 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Base_Basic            |   333.129 |   542.136 |   641.135 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Base_Shuffle          |           |   267.135 |   267.470 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Base_Unzip            |           |   193.711 |  1559.648 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Base                  |   332.850 |   194.171 |  1559.436 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128AdvSimd_Shuffle       |  6126.954 |  6357.662 |  6356.244 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128AdvSimd_ShuffleX      |           |           |  8927.413 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128AdvSimdB64_Shuffle    | 13579.777 | 13573.854 | 13580.241 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128AdvSimdB64_ShuffleX   |           |           | 16460.828 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128PackedSimd_Shuffle    |           |           |           |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Sse_Shuffle           |           |           |           |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Sse_ShuffleX          |           |           |           |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Traits                | 13584.712 | 13573.402 | 16454.649 |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Base_Basic            |   315.396 |   272.163 |   639.746 |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Base_Shuffle          |           |   120.881 |   291.071 |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Base_Unzip            |           |   174.417 |   636.420 |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Base                  |   310.641 |   271.284 |   640.031 |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Avx2_Shuffle          |           |           |           |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Avx2_ShuffleX         |           |           |           |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Traits                |   292.307 |   271.876 |   640.040 |
| YGroup3ToGroup4Benchmark_Byte  | Sum512Base_Basic            |           |           |   607.551 |
| YGroup3ToGroup4Benchmark_Byte  | Sum512Base_Shuffle          |           |           |   184.995 |
| YGroup3ToGroup4Benchmark_Byte  | Sum512Base_Unzip            |           |           |   399.862 |
| YGroup3ToGroup4Benchmark_Byte  | Sum512Base                  |           |           |   606.232 |
| YGroup3ToGroup4Benchmark_Byte  | Sum512Avx512_ShuffleX       |           |           |           |
| YGroup3ToGroup4Benchmark_Byte  | Sum512Traits                |           |           |   606.324 |
| YGroup3ToGroup4Benchmark_Int16 | SumBase_Basic               |   416.104 |   446.540 |   595.746 |
| YGroup3ToGroup4Benchmark_Int16 | SumBase_Unzip               |   716.286 |   799.091 |   804.164 |
| YGroup3ToGroup4Benchmark_Int16 | SumBase                     |   417.965 |   445.869 |   595.555 |
| YGroup3ToGroup4Benchmark_Int16 | SumTraits                   |  6794.162 |  6742.763 |  8091.684 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Base_Basic            |   281.732 |   446.085 |   595.726 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Base_Shuffle          |           |   141.284 |   142.489 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Base_Unzip            |           |   117.859 |   952.712 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Base                  |   282.691 |   448.315 |   595.523 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128AdvSimd_Shuffle       |  3064.839 |  3179.980 |  3179.825 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128AdvSimd_ShuffleX      |           |           |  4468.549 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128AdvSimdB64_Shuffle    |  6795.556 |  6742.762 |  6732.619 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128AdvSimdB64_ShuffleX   |           |           |  8092.919 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128PackedSimd_Shuffle    |           |           |           |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Sse_Shuffle           |           |           |           |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Sse_ShuffleX          |           |           |           |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Traits                |  6794.679 |  6736.367 |  8095.871 |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Base_Basic            |   250.412 |   224.888 |   596.946 |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Base_Shuffle          |           |    62.035 |   144.795 |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Base_Unzip            |           |   111.266 |   536.222 |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Base                  |   250.875 |   222.218 |   596.805 |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Avx2_Shuffle          |           |           |           |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Avx2_ShuffleX         |           |           |           |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Traits                |   226.501 |   227.093 |   597.060 |
| YGroup3ToGroup4Benchmark_Int16 | Sum512Base_Basic            |           |           |   529.598 |
| YGroup3ToGroup4Benchmark_Int16 | Sum512Base_Shuffle          |           |           |    96.475 |
| YGroup3ToGroup4Benchmark_Int16 | Sum512Base_Unzip            |           |           |   265.179 |
| YGroup3ToGroup4Benchmark_Int16 | Sum512Base                  |           |           |   529.799 |
| YGroup3ToGroup4Benchmark_Int16 | Sum512Avx512_ShuffleX       |           |           |           |
| YGroup3ToGroup4Benchmark_Int16 | Sum512Traits                |           |           |   529.033 |
| YGroup3ToGroup4Benchmark_Int32 | SumBase_Basic               |   289.211 |   329.921 |   505.684 |
| YGroup3ToGroup4Benchmark_Int32 | SumBase_Unzip               |   201.066 |   549.269 |   551.978 |
| YGroup3ToGroup4Benchmark_Int32 | SumBase                     |   289.653 |   332.810 |   505.906 |
| YGroup3ToGroup4Benchmark_Int32 | SumTraits                   |  4944.271 |  4942.637 |  5434.410 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Base_Basic            |   195.832 |   330.190 |   505.882 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Base_Shuffle          |           |    80.996 |    80.977 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Base_Unzip            |           |    75.003 |   605.050 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Base                  |   193.181 |   326.876 |   505.828 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128AdvSimd_AlignRight    |  4944.118 |  4942.346 |  5437.977 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128AdvSimd_Shuffle       |  1744.386 |  1803.087 |  1802.688 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128AdvSimd_ShuffleX      |           |           |  2675.072 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128AdvSimdB64_Shuffle    |  3625.425 |  3616.831 |  3618.851 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128AdvSimdB64_ShuffleX   |           |           |  4492.558 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128PackedSimd_Shuffle    |           |           |           |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Sse_Shuffle           |           |           |           |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Sse_ShuffleX          |           |           |           |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Sse_ShuffleXImm       |           |           |           |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Traits                |  4944.094 |  4938.763 |  5437.666 |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Base_Basic            |   159.631 |   169.706 |   530.660 |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Base_Shuffle          |           |    34.413 |    72.574 |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Base_Unzip            |           |    77.844 |   426.013 |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Base                  |   159.847 |   169.425 |   530.139 |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Avx2_Shuffle          |           |           |           |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Avx2_ShuffleX         |           |           |           |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Avx2_ShuffleXImm      |           |           |           |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Traits                |   150.162 |   170.184 |   530.094 |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Base_Basic            |           |           |   432.134 |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Base_Shuffle          |           |           |    48.749 |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Base_Unzip            |           |           |   284.899 |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Base                  |           |           |   432.097 |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Avx512_ShuffleX       |           |           |           |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Avx512_ShuffleXImm    |           |           |           |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Traits                |           |           |   433.018 |
| YGroup3ToGroup4Benchmark_Int64 | SumBase_Basic               |   143.206 |   161.001 |   389.022 |
| YGroup3ToGroup4Benchmark_Int64 | SumBase                     |   144.569 |   161.349 |   389.276 |
| YGroup3ToGroup4Benchmark_Int64 | SumTraits                   |  3398.923 |  3365.173 |  3325.810 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Base_Basic            |   113.751 |   159.725 |   389.565 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Base_Move             |           |  2720.113 |  3338.561 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Base_Shuffle          |           |    51.988 |    52.733 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Base                  |   414.521 |  2720.566 |  3338.318 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128AdvSimd_AlignRight    |  3399.868 |  3366.973 |  3326.278 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128AdvSimd_Shuffle       |  1422.660 |  1425.034 |  1591.940 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128AdvSimd_ShuffleX      |           |           |  2206.596 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128AdvSimdB64_Shuffle    |  2590.453 |  2714.717 |  3198.727 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128AdvSimdB64_ShuffleX   |           |           |  3396.853 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128PackedSimd_Shuffle    |           |           |           |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Sse_Shuffle           |           |           |           |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Sse_ShuffleX          |           |           |           |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Sse_ShuffleXImm       |           |           |           |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Traits                |  3400.460 |  3366.244 |  3325.301 |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Base_Basic            |    91.455 |   100.001 |   333.456 |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Base_Shuffle          |           |    20.688 |    42.086 |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Base                  |    91.355 |   100.396 |   332.777 |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Avx2_Shuffle          |           |           |           |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Avx2_ShuffleX         |           |           |           |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Avx2_ShuffleXImm      |           |           |           |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Traits                |    91.322 |    99.997 |   333.699 |
| YGroup3ToGroup4Benchmark_Int64 | Sum512Base_Basic            |           |           |   272.097 |
| YGroup3ToGroup4Benchmark_Int64 | Sum512Base_Shuffle          |           |           |    24.409 |
| YGroup3ToGroup4Benchmark_Int64 | Sum512Base                  |           |           |   271.507 |
| YGroup3ToGroup4Benchmark_Int64 | Sum512Avx512_ShuffleX       |           |           |           |
| YGroup3ToGroup4Benchmark_Int64 | Sum512Avx512_ShuffleXImm    |           |           |           |
| YGroup3ToGroup4Benchmark_Int64 | Sum512Traits                |           |           |   271.817 |
| YGroup4ToGroup3Benchmark_Byte  | SumBase_Basic               |   558.679 |   584.367 |   712.817 |
| YGroup4ToGroup3Benchmark_Byte  | SumBase_Unzip               |   645.896 |  2143.697 |  2183.216 |
| YGroup4ToGroup3Benchmark_Byte  | SumBase                     |   645.960 |  2143.201 |  2183.076 |
| YGroup4ToGroup3Benchmark_Byte  | SumTraits                   | 17370.143 | 18090.243 | 27063.256 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Base_Basic            |   384.294 |   583.745 |   712.949 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Base_Shuffle          |           |   247.400 |   229.192 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Base_Unzip            |           |  2156.787 |  2294.033 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Base                  |   384.784 |  2174.823 |  2294.086 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128AdvSimd_Shuffle       |  6969.571 |  7200.204 |  7204.290 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128AdvSimd_ShuffleX      |           |           | 14002.610 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128AdvSimdB64_Shuffle    | 17369.160 | 18087.791 | 18102.928 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128AdvSimdB64_ShuffleX   |           |           | 27055.608 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128PackedSimd_Shuffle    |           |           |           |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Sse_Shuffle           |           |           |           |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Sse_ShuffleX          |           |           |           |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Traits                | 17371.934 | 18090.702 | 27058.236 |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Base_Basic            |   370.488 |   326.664 |   708.862 |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Base_Shuffle          |           |   128.206 |   266.641 |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Base_Unzip            |           |   293.544 |   854.856 |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Base                  |   363.323 |   326.018 |   708.712 |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Avx2_Shuffle          |           |           |           |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Avx2_ShuffleX         |           |           |           |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Traits                |   353.201 |   325.978 |   708.808 |
| YGroup4ToGroup3Benchmark_Byte  | Sum512Base_Basic            |           |           |   673.337 |
| YGroup4ToGroup3Benchmark_Byte  | Sum512Base_Shuffle          |           |           |   187.624 |
| YGroup4ToGroup3Benchmark_Byte  | Sum512Base_Unzip            |           |           |   828.271 |
| YGroup4ToGroup3Benchmark_Byte  | Sum512Base                  |           |           |   673.534 |
| YGroup4ToGroup3Benchmark_Byte  | Sum512Avx512_ShuffleX       |           |           |           |
| YGroup4ToGroup3Benchmark_Byte  | Sum512Traits                |           |           |   673.193 |
| YGroup4ToGroup3Benchmark_Int16 | SumBase_Basic               |   424.478 |   467.233 |   663.919 |
| YGroup4ToGroup3Benchmark_Int16 | SumBase_Unzip               |   536.059 |  1141.328 |  1160.780 |
| YGroup4ToGroup3Benchmark_Int16 | SumBase                     |   423.529 |   466.184 |   663.919 |
| YGroup4ToGroup3Benchmark_Int16 | SumTraits                   |  8687.038 |  9051.363 | 13542.761 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Base_Basic            |   313.704 |   470.683 |   664.008 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Base_Shuffle          |           |   123.779 |   122.656 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Base_Unzip            |           |  1345.994 |  1440.293 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Base                  |   310.645 |   472.280 |   663.751 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128AdvSimd_Shuffle       |  3486.834 |  3601.586 |  3603.707 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128AdvSimd_ShuffleX      |           |           |  7010.608 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128AdvSimdB64_Shuffle    |  8687.440 |  9042.734 |  9045.482 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128AdvSimdB64_ShuffleX   |           |           | 13539.271 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128PackedSimd_Shuffle    |           |           |           |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Sse_Shuffle           |           |           |           |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Sse_ShuffleX          |           |           |           |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Traits                |  8687.655 |  9043.571 | 13540.015 |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Base_Basic            |   290.923 |   269.359 |   663.034 |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Base_Shuffle          |           |    68.753 |   131.817 |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Base_Unzip            |           |   198.695 |   735.429 |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Base                  |   285.419 |   266.898 |   662.755 |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Avx2_Shuffle          |           |           |           |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Avx2_ShuffleX         |           |           |           |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Traits                |   275.697 |   267.233 |   662.841 |
| YGroup4ToGroup3Benchmark_Int16 | Sum512Base_Basic            |           |           |   594.331 |
| YGroup4ToGroup3Benchmark_Int16 | Sum512Base_Shuffle          |           |           |    93.801 |
| YGroup4ToGroup3Benchmark_Int16 | Sum512Base_Unzip            |           |           |   691.117 |
| YGroup4ToGroup3Benchmark_Int16 | Sum512Base                  |           |           |   589.407 |
| YGroup4ToGroup3Benchmark_Int16 | Sum512Avx512_ShuffleX       |           |           |           |
| YGroup4ToGroup3Benchmark_Int16 | Sum512Traits                |           |           |   589.867 |
| YGroup4ToGroup3Benchmark_Int32 | SumBase_Basic               |   290.815 |   336.882 |   552.449 |
| YGroup4ToGroup3Benchmark_Int32 | SumBase_Unzip               |   202.076 |   879.131 |   899.251 |
| YGroup4ToGroup3Benchmark_Int32 | SumBase                     |   290.884 |   335.589 |   552.416 |
| YGroup4ToGroup3Benchmark_Int32 | SumTraits                   |  6040.415 |  6042.525 |  6772.956 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Base_Basic            |   215.165 |   337.386 |   552.471 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Base_Shuffle          |           |    61.898 |    61.424 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Base_Unzip            |           |   873.486 |   965.180 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Base                  |   213.343 |   336.547 |   552.440 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128AdvSimd_AlignRight    |  6042.281 |  6041.745 |  6784.122 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128AdvSimd_Shuffle       |  1743.352 |  1801.410 |  1802.038 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128AdvSimd_ShuffleX      |           |           |  3502.457 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128AdvSimdB64_Shuffle    |  4347.075 |  4524.701 |  4527.108 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128AdvSimdB64_ShuffleX   |           |           |  6769.615 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128PackedSimd_Shuffle    |           |           |           |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Sse_Shuffle           |           |           |           |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Sse_ShuffleX          |           |           |           |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Sse_ShuffleXImm       |           |           |           |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Traits                |  6042.495 |  6042.575 |  6771.312 |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Base_Basic            |   180.239 |   205.403 |   589.271 |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Base_Shuffle          |           |    35.961 |    66.667 |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Base_Unzip            |           |   131.067 |   594.650 |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Base                  |   179.958 |   204.831 |   589.185 |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Avx2_Shuffle          |           |           |           |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Avx2_ShuffleX         |           |           |           |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Avx2_ShuffleXImm      |           |           |           |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Traits                |   169.142 |   204.642 |   589.471 |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Base_Basic            |           |           |   484.999 |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Base_Shuffle          |           |           |    47.686 |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Base_Unzip            |           |           |   541.922 |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Base                  |           |           |   484.738 |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Avx512_ShuffleX       |           |           |           |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Avx512_ShuffleXImm    |           |           |           |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Traits                |           |           |   485.040 |
| YGroup4ToGroup3Benchmark_Int64 | SumBase_Basic               |   145.285 |   166.187 |   440.418 |
| YGroup4ToGroup3Benchmark_Int64 | SumBase                     |   145.489 |   164.756 |   440.692 |
| YGroup4ToGroup3Benchmark_Int64 | SumTraits                   |  3325.110 |  3324.803 |  3314.022 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Base_Basic            |   111.940 |   165.386 |   440.784 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Base_Move             |   434.752 |  3389.427 |  3315.914 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Base_Shuffle          |           |    40.713 |    40.933 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Base                  |   433.643 |  3389.425 |  3318.875 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128AdvSimd_AlignRight    |  3375.814 |  3375.740 |  3326.072 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128AdvSimd_Shuffle       |  1285.141 |  1287.293 |  1287.181 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128AdvSimd_ShuffleX      |           |           |  2381.057 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128AdvSimdB64_AlignRight |  3325.956 |  3324.902 |  3325.124 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128AdvSimdB64_Shuffle    |  2719.029 |  3021.067 |  3022.203 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128AdvSimdB64_ShuffleX   |           |           |  3399.692 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128PackedSimd_Shuffle    |           |           |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Sse_Shuffle           |           |           |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Sse_ShuffleX          |           |           |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Sse_ShuffleXImm       |           |           |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Traits                |  3325.530 |  3325.705 |  3326.612 |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Base_Basic            |    99.980 |   116.706 |   389.082 |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Base_Shuffle          |           |    18.596 |    33.224 |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Base                  |    99.700 |   117.069 |   389.059 |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Avx2_Shuffle          |           |           |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Avx2_ShuffleX         |           |           |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Avx2_ShuffleXImm      |           |           |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Traits                |   100.036 |   116.772 |   388.807 |
| YGroup4ToGroup3Benchmark_Int64 | Sum512Base_Basic            |           |           |   289.957 |
| YGroup4ToGroup3Benchmark_Int64 | Sum512Base_Shuffle          |           |           |    23.495 |
| YGroup4ToGroup3Benchmark_Int64 | Sum512Base                  |           |           |   290.011 |
| YGroup4ToGroup3Benchmark_Int64 | Sum512Avx512_ShuffleX       |           |           |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum512Avx512_ShuffleXImm    |           |           |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum512Traits                |           |           |   290.008 |

### Arm - AWS Arm t4g.small
| Type                           | Method                      | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 |  .NET 8.0 |
| :----------------------------- | :-------------------------- | ------------: | -------: | -------: | -------: | --------: |
| YGroup3ToGroup4Benchmark_Byte  | SumBase_Basic               |       190.220 |          |  194.667 |  187.303 |   225.462 |
| YGroup3ToGroup4Benchmark_Byte  | SumBase_Unzip               |       292.881 |          |  312.090 |  331.154 |   343.471 |
| YGroup3ToGroup4Benchmark_Byte  | SumBase                     |       282.831 |          |  312.209 |  331.226 |   343.424 |
| YGroup3ToGroup4Benchmark_Byte  | SumTraits                   |       291.327 |          | 4612.299 | 4559.826 |  5774.140 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Base_Basic            |       110.773 |          |  107.877 |  187.071 |   225.550 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Base_Shuffle          |               |          |          |  113.868 |   115.498 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Base_Unzip            |               |          |          |   62.234 |   377.623 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Base                  |       110.662 |          |  107.891 |   62.239 |   377.544 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128AdvSimd_Shuffle       |               |          | 1879.325 | 2223.526 |  2274.059 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128AdvSimd_ShuffleX      |               |          |          |          |  2954.983 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128AdvSimdB64_Shuffle    |               |          | 4620.092 | 4559.555 |  4736.753 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128AdvSimdB64_ShuffleX   |               |          |          |          |  5828.885 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128PackedSimd_Shuffle    |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Sse_Shuffle           |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Sse_ShuffleX          |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Traits                |       110.804 |          | 4227.170 | 4554.484 |  5824.685 |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Base_Basic            |       114.808 |          |  112.126 |   90.562 |   229.722 |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Base_Shuffle          |               |          |          |   47.965 |   115.623 |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Base_Unzip            |               |          |          |   58.343 |   208.707 |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Base                  |       113.282 |          |  110.512 |   90.372 |   229.480 |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Avx2_Shuffle          |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Avx2_ShuffleX         |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Traits                |       104.518 |          |  103.277 |   90.378 |   229.627 |
| YGroup3ToGroup4Benchmark_Byte  | Sum512Base_Basic            |               |          |          |          |   215.455 |
| YGroup3ToGroup4Benchmark_Byte  | Sum512Base_Shuffle          |               |          |          |          |    66.544 |
| YGroup3ToGroup4Benchmark_Byte  | Sum512Base_Unzip            |               |          |          |          |   146.390 |
| YGroup3ToGroup4Benchmark_Byte  | Sum512Base                  |               |          |          |          |   215.118 |
| YGroup3ToGroup4Benchmark_Byte  | Sum512Avx512_ShuffleX       |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Byte  | Sum512Traits                |               |          |          |          |   215.325 |
| YGroup3ToGroup4Benchmark_Int16 | SumBase_Basic               |       152.451 |          |  155.560 |  150.341 |   205.351 |
| YGroup3ToGroup4Benchmark_Int16 | SumBase_Unzip               |       164.334 |          |  173.781 |  180.785 |   186.082 |
| YGroup3ToGroup4Benchmark_Int16 | SumBase                     |       152.247 |          |  156.445 |  150.257 |   206.028 |
| YGroup3ToGroup4Benchmark_Int16 | SumTraits                   |       153.352 |          | 2062.156 | 2372.310 |  2795.647 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Base_Basic            |        81.771 |          |   80.869 |  150.372 |   205.222 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Base_Shuffle          |               |          |          |   56.299 |    57.491 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Base_Unzip            |               |          |          |   36.746 |   231.309 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Base                  |        81.213 |          |   80.750 |  148.520 |   204.720 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128AdvSimd_Shuffle       |               |          |  888.666 | 1128.305 |  1111.301 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128AdvSimd_ShuffleX      |               |          |          |          |  1441.024 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128AdvSimdB64_Shuffle    |               |          | 2049.794 | 2370.929 |  2263.555 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128AdvSimdB64_ShuffleX   |               |          |          |          |  2794.161 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128PackedSimd_Shuffle    |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Sse_Shuffle           |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Sse_ShuffleX          |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Traits                |        80.329 |          | 2148.699 | 2362.040 |  2790.148 |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Base_Basic            |        76.854 |          |   82.209 |   72.128 |   193.976 |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Base_Shuffle          |               |          |          |   26.952 |    57.698 |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Base_Unzip            |               |          |          |   37.046 |   167.893 |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Base                  |        74.853 |          |   81.447 |   71.324 |   193.067 |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Avx2_Shuffle          |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Avx2_ShuffleX         |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Traits                |        67.350 |          |   74.237 |   71.305 |   193.380 |
| YGroup3ToGroup4Benchmark_Int16 | Sum512Base_Basic            |               |          |          |          |   182.283 |
| YGroup3ToGroup4Benchmark_Int16 | Sum512Base_Shuffle          |               |          |          |          |    34.053 |
| YGroup3ToGroup4Benchmark_Int16 | Sum512Base_Unzip            |               |          |          |          |    95.411 |
| YGroup3ToGroup4Benchmark_Int16 | Sum512Base                  |               |          |          |          |   181.913 |
| YGroup3ToGroup4Benchmark_Int16 | Sum512Avx512_ShuffleX       |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Int16 | Sum512Traits                |               |          |          |          |   181.933 |
| YGroup3ToGroup4Benchmark_Int32 | SumBase_Basic               |       113.648 |          |  112.510 |  110.227 |   172.128 |
| YGroup3ToGroup4Benchmark_Int32 | SumBase_Unzip               |        70.234 |          |   70.859 |  125.601 |   129.419 |
| YGroup3ToGroup4Benchmark_Int32 | SumBase                     |       112.452 |          |  114.359 |  110.499 |   172.105 |
| YGroup3ToGroup4Benchmark_Int32 | SumTraits                   |       112.176 |          | 1766.756 | 1797.230 |  1770.725 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Base_Basic            |        54.470 |          |   52.627 |  110.265 |   172.134 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Base_Shuffle          |               |          |          |   34.599 |    34.974 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Base_Unzip            |               |          |          |   22.645 |   149.679 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Base                  |        54.212 |          |   52.512 |  109.994 |   172.032 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128AdvSimd_AlignRight    |               |          | 1770.049 | 1797.022 |  1772.119 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128AdvSimd_Shuffle       |               |          |  513.958 |  638.677 |   625.598 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128AdvSimd_ShuffleX      |               |          |          |          |   845.228 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128AdvSimdB64_Shuffle    |               |          | 1156.059 | 1269.481 |  1206.371 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128AdvSimdB64_ShuffleX   |               |          |          |          |  1496.134 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128PackedSimd_Shuffle    |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Sse_Shuffle           |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Sse_ShuffleX          |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Sse_ShuffleXImm       |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Traits                |        54.562 |          | 1768.223 | 1797.193 |  1773.341 |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Base_Basic            |        49.392 |          |   52.979 |   54.452 |   160.321 |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Base_Shuffle          |               |          |          |   14.756 |    28.798 |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Base_Unzip            |               |          |          |   25.255 |   130.577 |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Base                  |        48.412 |          |   53.172 |   54.407 |   160.355 |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Avx2_Shuffle          |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Avx2_ShuffleX         |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Avx2_ShuffleXImm      |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Traits                |        42.360 |          |   50.415 |   54.628 |   160.311 |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Base_Basic            |               |          |          |          |   143.314 |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Base_Shuffle          |               |          |          |          |    17.575 |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Base_Unzip            |               |          |          |          |    91.707 |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Base                  |               |          |          |          |   143.068 |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Avx512_ShuffleX       |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Avx512_ShuffleXImm    |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Traits                |               |          |          |          |   141.821 |
| YGroup3ToGroup4Benchmark_Int64 | SumBase_Basic               |        77.143 |          |   77.472 |   72.097 |   144.477 |
| YGroup3ToGroup4Benchmark_Int64 | SumBase                     |        76.298 |          |   77.279 |   71.869 |   137.129 |
| YGroup3ToGroup4Benchmark_Int64 | SumTraits                   |        76.497 |          | 1232.871 | 1416.166 |  1792.285 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Base_Basic            |        50.530 |          |   50.464 |   71.612 |   137.643 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Base_Move             |               |          |          |  994.248 |  1413.043 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Base_Shuffle          |               |          |          |   20.604 |    21.046 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Base                  |        65.598 |          |  133.385 |  994.008 |  1412.414 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128AdvSimd_AlignRight    |               |          | 1234.007 | 1418.043 |  1792.176 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128AdvSimd_Shuffle       |               |          |  427.768 |  520.323 |   558.101 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128AdvSimd_ShuffleX      |               |          |          |          |   774.568 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128AdvSimdB64_Shuffle    |               |          |  834.883 |  983.692 |  1086.841 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128AdvSimdB64_ShuffleX   |               |          |          |          |  1399.410 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128PackedSimd_Shuffle    |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Sse_Shuffle           |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Sse_ShuffleX          |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Sse_ShuffleXImm       |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Traits                |        65.479 |          | 1233.679 | 1417.484 |  1792.192 |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Base_Basic            |        32.392 |          |   34.964 |   44.308 |   123.051 |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Base_Shuffle          |               |          |          |    9.288 |    17.420 |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Base                  |        31.629 |          |   34.206 |   43.981 |   123.130 |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Avx2_Shuffle          |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Avx2_ShuffleX         |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Avx2_ShuffleXImm      |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Traits                |        26.472 |          |   34.044 |   44.423 |   123.159 |
| YGroup3ToGroup4Benchmark_Int64 | Sum512Base_Basic            |               |          |          |          |   101.053 |
| YGroup3ToGroup4Benchmark_Int64 | Sum512Base_Shuffle          |               |          |          |          |     8.667 |
| YGroup3ToGroup4Benchmark_Int64 | Sum512Base                  |               |          |          |          |   100.228 |
| YGroup3ToGroup4Benchmark_Int64 | Sum512Avx512_ShuffleX       |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Int64 | Sum512Avx512_ShuffleXImm    |               |          |          |          |           |
| YGroup3ToGroup4Benchmark_Int64 | Sum512Traits                |               |          |          |          |   100.748 |
| YGroup4ToGroup3Benchmark_Byte  | SumBase_Basic               |       203.397 |          |  210.723 |  200.568 |   246.028 |
| YGroup4ToGroup3Benchmark_Byte  | SumBase_Unzip               |       190.476 |          |  208.283 |  681.106 |   686.581 |
| YGroup4ToGroup3Benchmark_Byte  | SumBase                     |       190.781 |          |  208.664 |  681.519 |   686.524 |
| YGroup4ToGroup3Benchmark_Byte  | SumTraits                   |       190.602 |          | 5528.545 | 6353.013 | 10512.407 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Base_Basic            |       127.821 |          |  130.783 |  202.229 |   245.719 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Base_Shuffle          |               |          |          |  117.737 |   113.507 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Base_Unzip            |               |          |          |  703.925 |   812.508 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Base                  |       128.378 |          |  129.951 |  683.959 |   812.508 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128AdvSimd_Shuffle       |               |          | 2090.938 | 2548.951 |  2593.483 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128AdvSimd_ShuffleX      |               |          |          |          |  4632.828 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128AdvSimdB64_Shuffle    |               |          | 5811.236 | 6382.854 |  6596.832 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128AdvSimdB64_ShuffleX   |               |          |          |          | 10527.088 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128PackedSimd_Shuffle    |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Sse_Shuffle           |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Sse_ShuffleX          |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Traits                |       128.475 |          | 5815.625 | 6390.652 | 10528.249 |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Base_Basic            |       133.433 |          |  131.834 |  108.068 |   254.801 |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Base_Shuffle          |               |          |          |   54.872 |   123.653 |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Base_Unzip            |               |          |          |   98.078 |   270.657 |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Base                  |       131.648 |          |  128.041 |  107.477 |   254.399 |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Avx2_Shuffle          |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Avx2_ShuffleX         |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Traits                |       120.821 |          |  123.656 |  107.377 |   254.544 |
| YGroup4ToGroup3Benchmark_Byte  | Sum512Base_Basic            |               |          |          |          |   237.878 |
| YGroup4ToGroup3Benchmark_Byte  | Sum512Base_Shuffle          |               |          |          |          |    68.460 |
| YGroup4ToGroup3Benchmark_Byte  | Sum512Base_Unzip            |               |          |          |          |   288.719 |
| YGroup4ToGroup3Benchmark_Byte  | Sum512Base                  |               |          |          |          |   236.426 |
| YGroup4ToGroup3Benchmark_Byte  | Sum512Avx512_ShuffleX       |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Byte  | Sum512Traits                |               |          |          |          |   237.842 |
| YGroup4ToGroup3Benchmark_Int16 | SumBase_Basic               |       162.341 |          |  168.175 |  159.096 |   219.276 |
| YGroup4ToGroup3Benchmark_Int16 | SumBase_Unzip               |       155.486 |          |  163.811 |  362.151 |   358.843 |
| YGroup4ToGroup3Benchmark_Int16 | SumBase                     |       163.062 |          |  168.141 |  159.082 |   219.365 |
| YGroup4ToGroup3Benchmark_Int16 | SumTraits                   |       163.966 |          | 2733.614 | 3293.200 |  4992.210 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Base_Basic            |        95.191 |          |   95.636 |  159.177 |   219.596 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Base_Shuffle          |               |          |          |   59.110 |    56.200 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Base_Unzip            |               |          |          |  418.721 |   492.246 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Base                  |        94.545 |          |   94.806 |  157.917 |   219.343 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128AdvSimd_Shuffle       |               |          | 1011.366 | 1298.852 |  1276.333 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128AdvSimd_ShuffleX      |               |          |          |          |  2235.461 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128AdvSimdB64_Shuffle    |               |          | 2851.884 | 3289.533 |  3134.060 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128AdvSimdB64_ShuffleX   |               |          |          |          |  4986.348 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128PackedSimd_Shuffle    |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Sse_Shuffle           |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Sse_ShuffleX          |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Traits                |        93.855 |          | 2867.543 | 3289.300 |  4986.882 |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Base_Basic            |        86.403 |          |   92.525 |   84.129 |   229.910 |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Base_Shuffle          |               |          |          |   31.126 |    61.811 |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Base_Unzip            |               |          |          |   66.896 |   210.057 |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Base                  |        84.200 |          |   90.139 |   84.225 |   230.033 |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Avx2_Shuffle          |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Avx2_ShuffleX         |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Traits                |        75.481 |          |   87.064 |   84.268 |   229.935 |
| YGroup4ToGroup3Benchmark_Int16 | Sum512Base_Basic            |               |          |          |          |   197.327 |
| YGroup4ToGroup3Benchmark_Int16 | Sum512Base_Shuffle          |               |          |          |          |    34.442 |
| YGroup4ToGroup3Benchmark_Int16 | Sum512Base_Unzip            |               |          |          |          |   213.605 |
| YGroup4ToGroup3Benchmark_Int16 | Sum512Base                  |               |          |          |          |   197.013 |
| YGroup4ToGroup3Benchmark_Int16 | Sum512Avx512_ShuffleX       |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Int16 | Sum512Traits                |               |          |          |          |   197.185 |
| YGroup4ToGroup3Benchmark_Int32 | SumBase_Basic               |       114.200 |          |  116.700 |  115.321 |   186.818 |
| YGroup4ToGroup3Benchmark_Int32 | SumBase_Unzip               |        69.217 |          |   70.130 |  270.406 |   263.090 |
| YGroup4ToGroup3Benchmark_Int32 | SumBase                     |       113.339 |          |  119.247 |  115.257 |   186.871 |
| YGroup4ToGroup3Benchmark_Int32 | SumTraits                   |       113.481 |          | 2148.971 | 2197.232 |  2485.518 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Base_Basic            |        64.187 |          |   64.112 |  115.489 |   185.996 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Base_Shuffle          |               |          |          |   29.477 |    28.032 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Base_Unzip            |               |          |          |  278.132 |   314.787 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Base                  |        64.081 |          |   63.438 |  114.519 |   186.827 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128AdvSimd_AlignRight    |               |          | 2146.980 | 2196.269 |  2148.376 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128AdvSimd_Shuffle       |               |          |  501.763 |  646.646 |   631.739 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128AdvSimd_ShuffleX      |               |          |          |          |  1119.447 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128AdvSimdB64_Shuffle    |               |          | 1424.604 | 1637.695 |  1576.439 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128AdvSimdB64_ShuffleX   |               |          |          |          |  2486.061 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128PackedSimd_Shuffle    |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Sse_Shuffle           |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Sse_ShuffleX          |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Sse_ShuffleXImm       |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Traits                |        64.227 |          | 2149.451 | 2197.550 |  2481.875 |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Base_Basic            |        55.083 |          |   60.531 |   61.564 |   196.663 |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Base_Shuffle          |               |          |          |   16.671 |    30.887 |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Base_Unzip            |               |          |          |   46.627 |   169.553 |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Base                  |        54.037 |          |   60.733 |   62.404 |   196.694 |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Avx2_Shuffle          |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Avx2_ShuffleX         |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Avx2_ShuffleXImm      |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Traits                |        46.736 |          |   57.664 |   62.638 |   195.767 |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Base_Basic            |               |          |          |          |   159.743 |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Base_Shuffle          |               |          |          |          |    17.158 |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Base_Unzip            |               |          |          |          |   179.725 |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Base                  |               |          |          |          |   159.300 |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Avx512_ShuffleX       |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Avx512_ShuffleXImm    |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Traits                |               |          |          |          |   159.179 |
| YGroup4ToGroup3Benchmark_Int64 | SumBase_Basic               |        77.616 |          |   78.715 |   72.409 |   147.971 |
| YGroup4ToGroup3Benchmark_Int64 | SumBase                     |        77.118 |          |   78.399 |   72.448 |   149.575 |
| YGroup4ToGroup3Benchmark_Int64 | SumTraits                   |        76.984 |          | 1639.839 | 1978.375 |  1957.456 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Base_Basic            |        54.819 |          |   58.641 |   72.615 |   147.990 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Base_Move             |        98.461 |          |  168.114 | 1236.496 |  1959.573 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Base_Shuffle          |               |          |          |   21.724 |    21.753 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Base                  |        99.236 |          |  167.616 | 1238.788 |  1961.529 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128AdvSimd_AlignRight    |               |          | 1413.380 | 1651.576 |  1635.593 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128AdvSimd_Shuffle       |               |          |  360.033 |  462.192 |   457.652 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128AdvSimd_ShuffleX      |               |          |          |          |   869.695 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128AdvSimdB64_AlignRight |               |          | 1640.871 | 1982.228 |  1955.846 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128AdvSimdB64_Shuffle    |               |          |  977.009 |  992.895 |  1033.660 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128AdvSimdB64_ShuffleX   |               |          |          |          |  1636.246 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128PackedSimd_Shuffle    |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Sse_Shuffle           |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Sse_ShuffleX          |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Sse_ShuffleXImm       |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Traits                |        99.343 |          | 1642.666 | 1980.444 |  1959.709 |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Base_Basic            |        34.523 |          |   40.349 |   47.186 |   155.866 |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Base_Shuffle          |               |          |          |    8.452 |    15.002 |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Base                  |        34.003 |          |   40.344 |   47.194 |   155.862 |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Avx2_Shuffle          |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Avx2_ShuffleX         |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Avx2_ShuffleXImm      |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Traits                |        28.514 |          |   40.273 |   47.280 |   155.807 |
| YGroup4ToGroup3Benchmark_Int64 | Sum512Base_Basic            |               |          |          |          |   113.666 |
| YGroup4ToGroup3Benchmark_Int64 | Sum512Base_Shuffle          |               |          |          |          |     8.288 |
| YGroup4ToGroup3Benchmark_Int64 | Sum512Base                  |               |          |          |          |   114.228 |
| YGroup4ToGroup3Benchmark_Int64 | Sum512Avx512_ShuffleX       |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum512Avx512_ShuffleXImm    |               |          |          |          |           |
| YGroup4ToGroup3Benchmark_Int64 | Sum512Traits                |               |          |          |          |   114.255 |

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                           | Method                      | .NET 8.0 |
| :----------------------------- | :-------------------------- | -------: |
| YGroup3ToGroup4Benchmark_Byte  | SumBase_Basic               |    3.260 |
| YGroup3ToGroup4Benchmark_Byte  | SumBase_Unzip               |    4.836 |
| YGroup3ToGroup4Benchmark_Byte  | SumBase                     |    3.458 |
| YGroup3ToGroup4Benchmark_Byte  | SumTraits                   |   47.358 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Base_Basic            |    3.369 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Base_Shuffle          |   36.525 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Base_Unzip            |    5.599 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Base                  |    5.824 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128AdvSimd_Shuffle       |          |
| YGroup3ToGroup4Benchmark_Byte  | Sum128AdvSimd_ShuffleX      |          |
| YGroup3ToGroup4Benchmark_Byte  | Sum128AdvSimdB64_Shuffle    |          |
| YGroup3ToGroup4Benchmark_Byte  | Sum128AdvSimdB64_ShuffleX   |          |
| YGroup3ToGroup4Benchmark_Byte  | Sum128PackedSimd_Shuffle    |   56.622 |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Sse_Shuffle           |          |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Sse_ShuffleX          |          |
| YGroup3ToGroup4Benchmark_Byte  | Sum128Traits                |   57.195 |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Base_Basic            |    3.284 |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Base_Shuffle          |    3.101 |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Base_Unzip            |    4.134 |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Base                  |    3.222 |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Avx2_Shuffle          |          |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Avx2_ShuffleX         |          |
| YGroup3ToGroup4Benchmark_Byte  | Sum256Traits                |    3.144 |
| YGroup3ToGroup4Benchmark_Byte  | Sum512Base_Basic            |    3.314 |
| YGroup3ToGroup4Benchmark_Byte  | Sum512Base_Shuffle          |    2.733 |
| YGroup3ToGroup4Benchmark_Byte  | Sum512Base_Unzip            |    3.756 |
| YGroup3ToGroup4Benchmark_Byte  | Sum512Base                  |    3.303 |
| YGroup3ToGroup4Benchmark_Byte  | Sum512Avx512_ShuffleX       |          |
| YGroup3ToGroup4Benchmark_Byte  | Sum512Traits                |    3.331 |
| YGroup3ToGroup4Benchmark_Int16 | SumBase_Basic               |    2.667 |
| YGroup3ToGroup4Benchmark_Int16 | SumBase_Unzip               |    3.208 |
| YGroup3ToGroup4Benchmark_Int16 | SumBase                     |    2.784 |
| YGroup3ToGroup4Benchmark_Int16 | SumTraits                   |   24.254 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Base_Basic            |    2.764 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Base_Shuffle          |   18.552 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Base_Unzip            |    0.674 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Base                  |    2.644 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128AdvSimd_Shuffle       |          |
| YGroup3ToGroup4Benchmark_Int16 | Sum128AdvSimd_ShuffleX      |          |
| YGroup3ToGroup4Benchmark_Int16 | Sum128AdvSimdB64_Shuffle    |          |
| YGroup3ToGroup4Benchmark_Int16 | Sum128AdvSimdB64_ShuffleX   |          |
| YGroup3ToGroup4Benchmark_Int16 | Sum128PackedSimd_Shuffle    |   29.382 |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Sse_Shuffle           |          |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Sse_ShuffleX          |          |
| YGroup3ToGroup4Benchmark_Int16 | Sum128Traits                |   29.174 |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Base_Basic            |    2.817 |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Base_Shuffle          |    1.422 |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Base_Unzip            |    2.756 |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Base                  |    2.690 |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Avx2_Shuffle          |          |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Avx2_ShuffleX         |          |
| YGroup3ToGroup4Benchmark_Int16 | Sum256Traits                |    2.500 |
| YGroup3ToGroup4Benchmark_Int16 | Sum512Base_Basic            |    2.796 |
| YGroup3ToGroup4Benchmark_Int16 | Sum512Base_Shuffle          |    1.327 |
| YGroup3ToGroup4Benchmark_Int16 | Sum512Base_Unzip            |    2.087 |
| YGroup3ToGroup4Benchmark_Int16 | Sum512Base                  |    2.690 |
| YGroup3ToGroup4Benchmark_Int16 | Sum512Avx512_ShuffleX       |          |
| YGroup3ToGroup4Benchmark_Int16 | Sum512Traits                |    2.706 |
| YGroup3ToGroup4Benchmark_Int32 | SumBase_Basic               |    2.245 |
| YGroup3ToGroup4Benchmark_Int32 | SumBase_Unzip               |    2.350 |
| YGroup3ToGroup4Benchmark_Int32 | SumBase                     |    2.271 |
| YGroup3ToGroup4Benchmark_Int32 | SumTraits                   |   12.468 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Base_Basic            |    2.312 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Base_Shuffle          |   10.402 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Base_Unzip            |    0.392 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Base                  |    2.297 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128AdvSimd_AlignRight    |          |
| YGroup3ToGroup4Benchmark_Int32 | Sum128AdvSimd_Shuffle       |          |
| YGroup3ToGroup4Benchmark_Int32 | Sum128AdvSimd_ShuffleX      |          |
| YGroup3ToGroup4Benchmark_Int32 | Sum128AdvSimdB64_Shuffle    |          |
| YGroup3ToGroup4Benchmark_Int32 | Sum128AdvSimdB64_ShuffleX   |          |
| YGroup3ToGroup4Benchmark_Int32 | Sum128PackedSimd_Shuffle    |   16.972 |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Sse_Shuffle           |          |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Sse_ShuffleX          |          |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Sse_ShuffleXImm       |          |
| YGroup3ToGroup4Benchmark_Int32 | Sum128Traits                |   16.933 |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Base_Basic            |    2.166 |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Base_Shuffle          |    0.727 |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Base_Unzip            |    1.819 |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Base                  |    2.256 |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Avx2_Shuffle          |          |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Avx2_ShuffleX         |          |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Avx2_ShuffleXImm      |          |
| YGroup3ToGroup4Benchmark_Int32 | Sum256Traits                |    2.019 |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Base_Basic            |    2.154 |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Base_Shuffle          |    0.690 |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Base_Unzip            |    1.366 |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Base                  |    2.185 |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Avx512_ShuffleX       |          |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Avx512_ShuffleXImm    |          |
| YGroup3ToGroup4Benchmark_Int32 | Sum512Traits                |    2.112 |
| YGroup3ToGroup4Benchmark_Int64 | SumBase_Basic               |    1.049 |
| YGroup3ToGroup4Benchmark_Int64 | SumBase                     |    1.064 |
| YGroup3ToGroup4Benchmark_Int64 | SumTraits                   |    1.928 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Base_Basic            |    0.752 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Base_Move             |    1.056 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Base_Shuffle          |    1.053 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Base                  |    1.002 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128AdvSimd_AlignRight    |          |
| YGroup3ToGroup4Benchmark_Int64 | Sum128AdvSimd_Shuffle       |          |
| YGroup3ToGroup4Benchmark_Int64 | Sum128AdvSimd_ShuffleX      |          |
| YGroup3ToGroup4Benchmark_Int64 | Sum128AdvSimdB64_Shuffle    |          |
| YGroup3ToGroup4Benchmark_Int64 | Sum128AdvSimdB64_ShuffleX   |          |
| YGroup3ToGroup4Benchmark_Int64 | Sum128PackedSimd_Shuffle    |   13.911 |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Sse_Shuffle           |          |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Sse_ShuffleX          |          |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Sse_ShuffleXImm       |          |
| YGroup3ToGroup4Benchmark_Int64 | Sum128Traits                |    5.153 |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Base_Basic            |    0.705 |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Base_Shuffle          |    0.326 |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Base                  |    0.733 |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Avx2_Shuffle          |          |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Avx2_ShuffleX         |          |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Avx2_ShuffleXImm      |          |
| YGroup3ToGroup4Benchmark_Int64 | Sum256Traits                |    1.276 |
| YGroup3ToGroup4Benchmark_Int64 | Sum512Base_Basic            |    0.728 |
| YGroup3ToGroup4Benchmark_Int64 | Sum512Base_Shuffle          |    0.275 |
| YGroup3ToGroup4Benchmark_Int64 | Sum512Base                  |    0.715 |
| YGroup3ToGroup4Benchmark_Int64 | Sum512Avx512_ShuffleX       |          |
| YGroup3ToGroup4Benchmark_Int64 | Sum512Avx512_ShuffleXImm    |          |
| YGroup3ToGroup4Benchmark_Int64 | Sum512Traits                |    1.393 |
| YGroup4ToGroup3Benchmark_Byte  | SumBase_Basic               |    3.227 |
| YGroup4ToGroup3Benchmark_Byte  | SumBase_Unzip               |    4.647 |
| YGroup4ToGroup3Benchmark_Byte  | SumBase                     |    3.286 |
| YGroup4ToGroup3Benchmark_Byte  | SumTraits                   |   61.470 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Base_Basic            |    3.399 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Base_Shuffle          |   38.551 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Base_Unzip            |   12.866 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Base                  |   13.540 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128AdvSimd_Shuffle       |          |
| YGroup4ToGroup3Benchmark_Byte  | Sum128AdvSimd_ShuffleX      |          |
| YGroup4ToGroup3Benchmark_Byte  | Sum128AdvSimdB64_Shuffle    |          |
| YGroup4ToGroup3Benchmark_Byte  | Sum128AdvSimdB64_ShuffleX   |          |
| YGroup4ToGroup3Benchmark_Byte  | Sum128PackedSimd_Shuffle    |   82.275 |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Sse_Shuffle           |          |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Sse_ShuffleX          |          |
| YGroup4ToGroup3Benchmark_Byte  | Sum128Traits                |   82.707 |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Base_Basic            |    3.278 |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Base_Shuffle          |    3.181 |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Base_Unzip            |    5.965 |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Base                  |    3.376 |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Avx2_Shuffle          |          |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Avx2_ShuffleX         |          |
| YGroup4ToGroup3Benchmark_Byte  | Sum256Traits                |    3.396 |
| YGroup4ToGroup3Benchmark_Byte  | Sum512Base_Basic            |    3.392 |
| YGroup4ToGroup3Benchmark_Byte  | Sum512Base_Shuffle          |    3.116 |
| YGroup4ToGroup3Benchmark_Byte  | Sum512Base_Unzip            |    4.803 |
| YGroup4ToGroup3Benchmark_Byte  | Sum512Base                  |    3.404 |
| YGroup4ToGroup3Benchmark_Byte  | Sum512Avx512_ShuffleX       |          |
| YGroup4ToGroup3Benchmark_Byte  | Sum512Traits                |    3.426 |
| YGroup4ToGroup3Benchmark_Int16 | SumBase_Basic               |    2.814 |
| YGroup4ToGroup3Benchmark_Int16 | SumBase_Unzip               |    3.242 |
| YGroup4ToGroup3Benchmark_Int16 | SumBase                     |    2.823 |
| YGroup4ToGroup3Benchmark_Int16 | SumTraits                   |   33.712 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Base_Basic            |    2.824 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Base_Shuffle          |   19.621 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Base_Unzip            |    1.268 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Base                  |    2.764 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128AdvSimd_Shuffle       |          |
| YGroup4ToGroup3Benchmark_Int16 | Sum128AdvSimd_ShuffleX      |          |
| YGroup4ToGroup3Benchmark_Int16 | Sum128AdvSimdB64_Shuffle    |          |
| YGroup4ToGroup3Benchmark_Int16 | Sum128AdvSimdB64_ShuffleX   |          |
| YGroup4ToGroup3Benchmark_Int16 | Sum128PackedSimd_Shuffle    |   41.579 |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Sse_Shuffle           |          |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Sse_ShuffleX          |          |
| YGroup4ToGroup3Benchmark_Int16 | Sum128Traits                |   41.887 |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Base_Basic            |    2.976 |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Base_Shuffle          |    1.552 |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Base_Unzip            |    2.753 |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Base                  |    2.879 |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Avx2_Shuffle          |          |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Avx2_ShuffleX         |          |
| YGroup4ToGroup3Benchmark_Int16 | Sum256Traits                |    2.681 |
| YGroup4ToGroup3Benchmark_Int16 | Sum512Base_Basic            |    2.904 |
| YGroup4ToGroup3Benchmark_Int16 | Sum512Base_Shuffle          |    1.529 |
| YGroup4ToGroup3Benchmark_Int16 | Sum512Base_Unzip            |    2.882 |
| YGroup4ToGroup3Benchmark_Int16 | Sum512Base                  |    2.904 |
| YGroup4ToGroup3Benchmark_Int16 | Sum512Avx512_ShuffleX       |          |
| YGroup4ToGroup3Benchmark_Int16 | Sum512Traits                |    2.889 |
| YGroup4ToGroup3Benchmark_Int32 | SumBase_Basic               |    2.221 |
| YGroup4ToGroup3Benchmark_Int32 | SumBase_Unzip               |    2.132 |
| YGroup4ToGroup3Benchmark_Int32 | SumBase                     |    2.245 |
| YGroup4ToGroup3Benchmark_Int32 | SumTraits                   |   15.964 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Base_Basic            |    2.247 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Base_Shuffle          |    9.467 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Base_Unzip            |    0.788 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Base                  |    2.298 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128AdvSimd_AlignRight    |          |
| YGroup4ToGroup3Benchmark_Int32 | Sum128AdvSimd_Shuffle       |          |
| YGroup4ToGroup3Benchmark_Int32 | Sum128AdvSimd_ShuffleX      |          |
| YGroup4ToGroup3Benchmark_Int32 | Sum128AdvSimdB64_Shuffle    |          |
| YGroup4ToGroup3Benchmark_Int32 | Sum128AdvSimdB64_ShuffleX   |          |
| YGroup4ToGroup3Benchmark_Int32 | Sum128PackedSimd_Shuffle    |   20.483 |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Sse_Shuffle           |          |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Sse_ShuffleX          |          |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Sse_ShuffleXImm       |          |
| YGroup4ToGroup3Benchmark_Int32 | Sum128Traits                |   21.311 |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Base_Basic            |    2.285 |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Base_Shuffle          |    0.782 |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Base_Unzip            |    1.871 |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Base                  |    2.226 |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Avx2_Shuffle          |          |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Avx2_ShuffleX         |          |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Avx2_ShuffleXImm      |          |
| YGroup4ToGroup3Benchmark_Int32 | Sum256Traits                |    2.056 |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Base_Basic            |    2.366 |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Base_Shuffle          |    0.753 |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Base_Unzip            |    1.857 |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Base                  |    2.327 |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Avx512_ShuffleX       |          |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Avx512_ShuffleXImm    |          |
| YGroup4ToGroup3Benchmark_Int32 | Sum512Traits                |    2.330 |
| YGroup4ToGroup3Benchmark_Int64 | SumBase_Basic               |    1.150 |
| YGroup4ToGroup3Benchmark_Int64 | SumBase                     |    1.180 |
| YGroup4ToGroup3Benchmark_Int64 | SumTraits                   |    2.919 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Base_Basic            |    0.794 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Base_Move             |    1.303 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Base_Shuffle          |    1.378 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Base                  |    1.295 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128AdvSimd_AlignRight    |          |
| YGroup4ToGroup3Benchmark_Int64 | Sum128AdvSimd_Shuffle       |          |
| YGroup4ToGroup3Benchmark_Int64 | Sum128AdvSimd_ShuffleX      |          |
| YGroup4ToGroup3Benchmark_Int64 | Sum128AdvSimdB64_AlignRight |          |
| YGroup4ToGroup3Benchmark_Int64 | Sum128AdvSimdB64_Shuffle    |          |
| YGroup4ToGroup3Benchmark_Int64 | Sum128AdvSimdB64_ShuffleX   |          |
| YGroup4ToGroup3Benchmark_Int64 | Sum128PackedSimd_Shuffle    |   13.622 |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Sse_Shuffle           |          |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Sse_ShuffleX          |          |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Sse_ShuffleXImm       |          |
| YGroup4ToGroup3Benchmark_Int64 | Sum128Traits                |   13.332 |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Base_Basic            |    0.773 |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Base_Shuffle          |    0.322 |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Base                  |    0.810 |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Avx2_Shuffle          |          |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Avx2_ShuffleX         |          |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Avx2_ShuffleXImm      |          |
| YGroup4ToGroup3Benchmark_Int64 | Sum256Traits                |    1.291 |
| YGroup4ToGroup3Benchmark_Int64 | Sum512Base_Basic            |    0.848 |
| YGroup4ToGroup3Benchmark_Int64 | Sum512Base_Shuffle          |    0.308 |
| YGroup4ToGroup3Benchmark_Int64 | Sum512Base                  |    0.855 |
| YGroup4ToGroup3Benchmark_Int64 | Sum512Avx512_ShuffleX       |          |
| YGroup4ToGroup3Benchmark_Int64 | Sum512Avx512_ShuffleXImm    |          |
| YGroup4ToGroup3Benchmark_Int64 | Sum512Traits                |    1.497 |

