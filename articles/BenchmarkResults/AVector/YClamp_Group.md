# Benchmark group - YClamp
([← Back](YClamp.md))

Unit of data: Million operations per second. The larger the number, the better the performance.
### X86 - AMD Ryzen 7 7840H
| Type                   | Method                          | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :--------------------- | :------------------------------ | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| YClampBenchmark_Double | SumClamp_If                     |        202.705 |       197.319 |       195.424 |   194.562 |   197.616 |   206.016 |   197.919 |
| YClampBenchmark_Double | SumClamp_MinMax                 |        194.617 |       180.427 |       127.957 |   149.657 |   159.059 |  1134.282 |  1132.580 |
| YClampBenchmark_Double | SumClamp_Math                   |                |       194.277 |       193.114 |   193.361 |   193.403 |   203.959 |   202.234 |
| YClampBenchmark_Double | SumClamp_BitMath                |        335.923 |       326.024 |       312.120 |   216.672 |   270.772 |   302.973 |   517.724 |
| YClampBenchmark_Double | SumClampVectorScalar            |       1128.746 |      1135.436 |      1135.577 |  1133.406 |  1134.976 |  1129.145 |  1127.167 |
| YClampBenchmark_Double | SumClampVectorBase              |       4503.828 |      4489.727 |      4494.474 |  4513.376 |  4502.763 |  4504.164 |  4439.795 |
| YClampBenchmark_Double | SumClampVectorTraits            |       2271.512 |      2265.122 |      2268.877 |  2274.214 |  2274.245 |  2261.978 |  2266.109 |
| YClampBenchmark_Double | SumClampVector128_AdvSimd       |                |               |               |           |           |           |           |
| YClampBenchmark_Double | SumClampVector128Bcl            |                |               |               |           |           |  2269.028 |  2253.852 |
| YClampBenchmark_Double | SumClampVector128Base           |                |               |        41.686 |    38.874 |    38.597 |  2267.013 |  2256.121 |
| YClampBenchmark_Double | SumClampVector128Traits         |                |               |      2257.797 |  2265.779 |  2191.398 |  2261.736 |  2261.582 |
| YClampBenchmark_Double | SumClampVector256Traits         |                |               |      4457.659 |  4512.731 |  4508.344 |  4482.762 |  4463.539 |
| YClampBenchmark_Double | SumClampVector512Bcl            |                |               |               |           |           |           |  8296.225 |
| YClampBenchmark_Double | SumClampVector512Traits         |                |               |               |           |           |           |  8270.874 |
| YClampBenchmark_Int16  | SumClamp_If                     |        215.466 |       203.867 |       211.899 |   202.027 |   212.278 |   207.566 |   224.123 |
| YClampBenchmark_Int16  | SumClamp_MinMax                 |        194.928 |       203.273 |       209.450 |   205.878 |   191.925 |   215.544 |   200.707 |
| YClampBenchmark_Int16  | SumClamp_Math                   |                |       205.026 |       201.348 |   217.359 |   207.872 |   210.374 |   236.411 |
| YClampBenchmark_Int16  | SumClamp_BitMath                |        226.882 |       225.891 |       325.500 |   181.124 |   206.039 |   289.548 |   427.007 |
| YClampBenchmark_Int16  | SumClampVectorScalar            |        913.299 |       837.948 |       794.180 |   827.440 |   849.433 |   770.484 |  1226.517 |
| YClampBenchmark_Int16  | SumClampVectorBase              |      34003.589 |     33825.858 |     31464.923 | 34488.939 | 35149.309 | 36636.559 | 37189.723 |
| YClampBenchmark_Int16  | SumClampVectorTraits            |      28764.817 |     27327.585 |     26973.996 | 35001.367 | 34795.193 | 31765.814 | 31727.791 |
| YClampBenchmark_Int16  | SumClampVector128_AdvSimd       |                |               |               |           |           |           |           |
| YClampBenchmark_Int16  | SumClampVector128Bcl            |                |               |               |           |           | 13773.367 | 19933.459 |
| YClampBenchmark_Int16  | SumClampVector128Base           |                |               |       126.685 |   106.366 |   109.646 | 13887.490 | 16723.158 |
| YClampBenchmark_Int16  | SumClampVector128Traits         |                |               |     17616.863 | 18323.806 | 17434.459 | 14282.583 | 20107.497 |
| YClampBenchmark_Int16  | SumClampVector256Traits         |                |               |     32504.630 | 33477.547 | 34717.813 | 23600.182 | 37987.496 |
| YClampBenchmark_Int16  | SumClampVector512Bcl            |                |               |               |           |           |           | 40475.392 |
| YClampBenchmark_Int16  | SumClampVector512Traits         |                |               |               |           |           |           | 40905.765 |
| YClampBenchmark_Int32  | SumClamp_If                     |        226.530 |       228.058 |       226.412 |   217.961 |   219.906 |   203.331 |   231.992 |
| YClampBenchmark_Int32  | SumClamp_MinMax                 |        207.754 |       210.809 |       213.701 |   202.928 |   210.576 |   205.455 |   216.269 |
| YClampBenchmark_Int32  | SumClamp_Math                   |                |       211.639 |       220.892 |   215.882 |   222.527 |   223.751 |   247.452 |
| YClampBenchmark_Int32  | SumClamp_BitMath                |        513.177 |       482.353 |       478.533 |   227.726 |   227.742 |   385.019 |   525.135 |
| YClampBenchmark_Int32  | SumClampVectorScalar            |       1345.361 |      1284.497 |      1274.048 |  1289.125 |  1314.694 |  1376.144 |  1520.352 |
| YClampBenchmark_Int32  | SumClampVectorBase              |      15593.722 |     14658.927 |     14829.074 | 15881.108 | 15700.335 | 17171.860 | 14138.012 |
| YClampBenchmark_Int32  | SumClampVectorTraits            |      14862.737 |     13185.539 |     13831.556 | 14949.978 | 15725.476 | 15083.751 | 13418.049 |
| YClampBenchmark_Int32  | SumClampVector128_AdvSimd       |                |               |               |           |           |           |           |
| YClampBenchmark_Int32  | SumClampVector128Bcl            |                |               |               |           |           |  4221.327 |  9057.856 |
| YClampBenchmark_Int32  | SumClampVector128Base           |                |               |        81.710 |    77.827 |    76.850 |  4231.925 |  8638.000 |
| YClampBenchmark_Int32  | SumClampVector128Traits         |                |               |      6479.275 |  8524.922 |  8891.235 |  7322.451 |  9798.382 |
| YClampBenchmark_Int32  | SumClampVector256Traits         |                |               |     16014.514 | 15353.667 | 14605.358 | 13146.386 | 15664.950 |
| YClampBenchmark_Int32  | SumClampVector512Bcl            |                |               |               |           |           |           | 17437.689 |
| YClampBenchmark_Int32  | SumClampVector512Traits         |                |               |               |           |           |           | 18840.593 |
| YClampBenchmark_Int64  | SumClamp_If                     |        215.094 |       200.919 |       203.253 |   212.641 |   215.044 |   213.139 |   225.014 |
| YClampBenchmark_Int64  | SumClamp_MinMax                 |        202.358 |       201.227 |       202.983 |   198.293 |   210.754 |   211.226 |   210.385 |
| YClampBenchmark_Int64  | SumClamp_Math                   |                |       201.701 |       213.896 |   208.645 |   206.693 |   213.674 |   209.095 |
| YClampBenchmark_Int64  | SumClamp_BitMath                |        472.093 |       442.505 |       430.724 |   211.799 |   212.054 |   339.454 |   500.594 |
| YClampBenchmark_Int64  | SumClampVectorScalar            |        927.733 |       856.166 |       769.884 |   853.037 |   986.640 |  1269.281 |  1532.698 |
| YClampBenchmark_Int64  | SumClampVectorBase              |       4505.962 |      4101.117 |      4059.022 |  4280.986 |  4242.662 |  6221.302 |  7978.284 |
| YClampBenchmark_Int64  | SumClampVectorTraits            |       3592.604 |      3300.309 |      4594.900 |  4883.761 |  4859.989 |  4714.530 |  5259.836 |
| YClampBenchmark_Int64  | SumClampVector128_AdvSimd       |                |               |               |           |           |           |           |
| YClampBenchmark_Int64  | SumClampVector128_Arm64         |                |               |               |           |           |           |           |
| YClampBenchmark_Int64  | SumClampVector128Bcl            |                |               |               |           |           |  2130.986 |  4186.822 |
| YClampBenchmark_Int64  | SumClampVector128Base           |                |               |        43.443 |    40.730 |    39.724 |  2169.477 |  4207.011 |
| YClampBenchmark_Int64  | SumClampVector128Traits         |                |               |      2121.924 |  3249.693 |  3207.283 |  2197.010 |  4279.492 |
| YClampBenchmark_Int64  | SumClampVector256Traits         |                |               |      6092.719 |  6241.974 |  6244.790 |  3954.167 |  8047.015 |
| YClampBenchmark_Int64  | SumClampVector512Bcl            |                |               |               |           |           |           |  9789.734 |
| YClampBenchmark_Int64  | SumClampVector512Traits         |                |               |               |           |           |           |  9686.884 |
| YClampBenchmark_SByte  | SumClamp_If                     |        192.454 |       185.428 |       202.087 |   191.862 |   200.294 |   196.129 |   206.753 |
| YClampBenchmark_SByte  | SumClamp_MinMax                 |        203.958 |       206.009 |       197.554 |   197.168 |   189.043 |   216.082 |   214.441 |
| YClampBenchmark_SByte  | SumClamp_Math                   |                |       196.089 |       195.344 |   197.291 |   196.847 |   212.356 |   214.400 |
| YClampBenchmark_SByte  | SumClamp_BitMath                |        307.226 |       303.758 |       326.319 |   184.800 |   202.464 |   299.595 |   426.549 |
| YClampBenchmark_SByte  | SumClampVectorScalar            |        914.667 |       837.315 |       804.008 |   815.654 |   854.385 |   801.863 |  1191.558 |
| YClampBenchmark_SByte  | SumClampVectorBase              |      71641.753 |     68956.263 |     68832.941 | 67999.561 | 69247.135 | 78262.320 | 65671.095 |
| YClampBenchmark_SByte  | SumClampVectorTraits            |      61717.118 |     56028.755 |     51113.469 | 69327.479 | 71981.626 | 66843.145 | 71816.071 |
| YClampBenchmark_SByte  | SumClampVector128_AdvSimd       |                |               |               |           |           |           |           |
| YClampBenchmark_SByte  | SumClampVector128Bcl            |                |               |               |           |           | 10365.285 | 38460.261 |
| YClampBenchmark_SByte  | SumClampVector128Base           |                |               |       198.711 |   174.141 |   174.535 | 10048.041 | 36721.546 |
| YClampBenchmark_SByte  | SumClampVector128Traits         |                |               |     27402.284 | 37595.755 | 34536.431 | 28559.388 | 39746.202 |
| YClampBenchmark_SByte  | SumClampVector256Traits         |                |               |     66856.394 | 64120.199 | 68332.899 | 54991.642 | 75306.149 |
| YClampBenchmark_SByte  | SumClampVector512Bcl            |                |               |               |           |           |           | 88069.503 |
| YClampBenchmark_SByte  | SumClampVector512Traits         |                |               |               |           |           |           | 88637.514 |
| YClampBenchmark_Single | SumClamp_If                     |        201.786 |       197.815 |       196.489 |   193.383 |   199.270 |   206.782 |   198.741 |
| YClampBenchmark_Single | SumClamp_MinMax                 |        185.698 |       187.830 |       127.608 |   148.873 |   147.795 |  1126.868 |  1135.984 |
| YClampBenchmark_Single | SumClamp_Math                   |                |       196.672 |       193.078 |   193.164 |   198.537 |   205.158 |   201.157 |
| YClampBenchmark_Single | SumClamp_BitMath                |        335.266 |       314.297 |       326.882 |   218.602 |   248.146 |   333.867 |   495.391 |
| YClampBenchmark_Single | SumClampVectorScalar            |       1129.678 |      1133.984 |      1135.803 |  1135.559 |  1137.909 |  1129.127 |  1130.998 |
| YClampBenchmark_Single | SumClampVectorBase              |       8673.371 |      8724.618 |      8730.685 |  8684.232 |  8633.009 |  8710.176 |  8730.698 |
| YClampBenchmark_Single | SumClampVectorTraits            |       8729.298 |      8695.793 |      8722.288 |  8696.538 |  8785.652 |  8651.231 |  8737.662 |
| YClampBenchmark_Single | SumClampVector128_AdvSimd       |                |               |               |           |           |           |           |
| YClampBenchmark_Single | SumClampVector128_Wasm_NoPseudo |                |               |               |           |           |           |           |
| YClampBenchmark_Single | SumClampVector128_Wasm_Pseudo   |                |               |               |           |           |           |           |
| YClampBenchmark_Single | SumClampVector128Bcl            |                |               |               |           |           |  4383.896 |  4441.950 |
| YClampBenchmark_Single | SumClampVector128Base           |                |               |        79.107 |    70.442 |    70.250 |  4405.787 |  4448.867 |
| YClampBenchmark_Single | SumClampVector128Traits         |                |               |      4450.811 |  4453.261 |  4415.646 |  4411.788 |  4407.714 |
| YClampBenchmark_Single | SumClampVector256Traits         |                |               |      8698.360 |  8886.137 |  8671.404 |  8628.455 |  8709.607 |
| YClampBenchmark_Single | SumClampVector512Bcl            |                |               |               |           |           |           | 15929.418 |
| YClampBenchmark_Single | SumClampVector512Traits         |                |               |               |           |           |           | 14868.400 |

### X86 - Intel Core i5-8250U
| Type                   | Method                    | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :--------------------- | :------------------------ | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| YClampBenchmark_Double | SumClamp_If               |        205.825 |       208.815 |       207.847 |   194.046 |   214.831 |   225.353 |
| YClampBenchmark_Double | SumClamp_MinMax           |        193.500 |       199.463 |       138.801 |   149.246 |   157.977 |   845.571 |
| YClampBenchmark_Double | SumClamp_Math             |                |       213.082 |       202.922 |   214.292 |   205.340 |   223.722 |
| YClampBenchmark_Double | SumClamp_BitMath          |        295.999 |       203.970 |       296.870 |   226.527 |   252.406 |   316.453 |
| YClampBenchmark_Double | SumClampVectorScalar      |        845.285 |       845.245 |       844.327 |   844.684 |   843.462 |   845.594 |
| YClampBenchmark_Double | SumClampVectorBase        |       3374.246 |      3364.716 |      3366.126 |  3368.893 |  3369.998 |  3369.851 |
| YClampBenchmark_Double | SumClampVectorTraits      |       3374.714 |      3364.539 |      3363.727 |  3368.829 |  3370.384 |  3373.745 |
| YClampBenchmark_Double | SumClampVector128_AdvSimd |                |               |               |           |           |           |
| YClampBenchmark_Double | SumClampVector128Traits   |                |               |      1688.951 |  1687.685 |  1687.598 |  1685.305 |
| YClampBenchmark_Double | SumClampVector256Traits   |                |               |      3372.207 |  3372.865 |  3371.251 |  3371.862 |
| YClampBenchmark_Int16  | SumClamp_If               |        215.505 |       215.944 |       213.782 |   222.201 |   217.976 |   224.945 |
| YClampBenchmark_Int16  | SumClamp_MinMax           |        211.481 |       220.728 |       217.970 |   214.758 |   202.562 |   222.428 |
| YClampBenchmark_Int16  | SumClamp_Math             |                |       220.902 |       218.310 |   220.155 |   218.283 |   226.201 |
| YClampBenchmark_Int16  | SumClamp_BitMath          |        225.990 |       226.375 |       346.748 |   231.688 |   288.041 |   377.209 |
| YClampBenchmark_Int16  | SumClampVectorScalar      |        656.569 |       657.876 |       667.144 |   671.484 |   657.058 |   706.250 |
| YClampBenchmark_Int16  | SumClampVectorBase        |      21616.386 |     20317.518 |     20370.312 | 20279.612 | 20244.028 | 19966.751 |
| YClampBenchmark_Int16  | SumClampVectorTraits      |      20824.271 |     19793.967 |     20306.705 | 20117.733 | 19613.893 | 20299.686 |
| YClampBenchmark_Int16  | SumClampVector128_AdvSimd |                |               |               |           |           |           |
| YClampBenchmark_Int16  | SumClampVector128Traits   |                |               |     11440.144 | 11404.378 | 11397.032 | 11907.665 |
| YClampBenchmark_Int16  | SumClampVector256Traits   |                |               |     20237.825 | 20312.038 | 20329.650 | 20261.190 |
| YClampBenchmark_Int32  | SumClamp_If               |        219.845 |       219.677 |       219.329 |   212.990 |   209.857 |   222.020 |
| YClampBenchmark_Int32  | SumClamp_MinMax           |        223.515 |       222.938 |       215.222 |   222.212 |   202.577 |   203.164 |
| YClampBenchmark_Int32  | SumClamp_Math             |                |       223.554 |       220.285 |   223.867 |   224.564 |   227.278 |
| YClampBenchmark_Int32  | SumClamp_BitMath          |        488.841 |       488.479 |       484.913 |   306.004 |   306.671 |   488.117 |
| YClampBenchmark_Int32  | SumClampVectorScalar      |       1120.472 |      1121.187 |      1127.523 |  1127.664 |  1120.558 |  1348.137 |
| YClampBenchmark_Int32  | SumClampVectorBase        |      10130.762 |      9988.734 |     10160.643 | 10166.501 | 10068.411 | 10717.997 |
| YClampBenchmark_Int32  | SumClampVectorTraits      |      10088.042 |     10089.874 |     10149.406 | 10112.996 | 10129.216 | 10754.191 |
| YClampBenchmark_Int32  | SumClampVector128_AdvSimd |                |               |               |           |           |           |
| YClampBenchmark_Int32  | SumClampVector128Traits   |                |               |      4938.305 |  5725.903 |  5718.994 |  5924.448 |
| YClampBenchmark_Int32  | SumClampVector256Traits   |                |               |     10122.132 | 10147.300 | 10124.446 | 10701.682 |
| YClampBenchmark_Int64  | SumClamp_If               |        197.094 |       196.787 |       193.559 |   196.038 |   203.459 |   203.217 |
| YClampBenchmark_Int64  | SumClamp_MinMax           |        193.545 |       193.631 |       197.620 |   194.065 |   198.909 |   202.424 |
| YClampBenchmark_Int64  | SumClamp_Math             |                |       197.306 |       197.833 |   192.968 |   197.270 |   206.166 |
| YClampBenchmark_Int64  | SumClamp_BitMath          |        444.285 |       453.457 |       452.403 |   275.630 |   275.531 |   434.655 |
| YClampBenchmark_Int64  | SumClampVectorScalar      |        618.242 |       624.538 |       615.399 |   620.586 |   617.778 |   796.198 |
| YClampBenchmark_Int64  | SumClampVectorBase        |       2904.650 |      2591.328 |      2586.842 |  2609.587 |  2620.991 |  3063.056 |
| YClampBenchmark_Int64  | SumClampVectorTraits      |       2834.597 |      2513.360 |      3084.178 |  3085.217 |  3092.766 |  3062.579 |
| YClampBenchmark_Int64  | SumClampVector128_AdvSimd |                |               |               |           |           |           |
| YClampBenchmark_Int64  | SumClampVector128_Arm64   |                |               |               |           |           |           |
| YClampBenchmark_Int64  | SumClampVector128Traits   |                |               |      1345.280 |  1937.321 |  1962.211 |  1349.337 |
| YClampBenchmark_Int64  | SumClampVector256Traits   |                |               |      3089.639 |  3087.198 |  3094.869 |  2628.240 |
| YClampBenchmark_SByte  | SumClamp_If               |        193.843 |       172.060 |       187.203 |   186.118 |   190.760 |   199.064 |
| YClampBenchmark_SByte  | SumClamp_MinMax           |        179.697 |       190.831 |       195.849 |   181.425 |   189.622 |   199.104 |
| YClampBenchmark_SByte  | SumClamp_Math             |                |       194.684 |       192.063 |   184.995 |   200.149 |   200.571 |
| YClampBenchmark_SByte  | SumClamp_BitMath          |        318.333 |       317.973 |       340.077 |   232.019 |   289.093 |   380.367 |
| YClampBenchmark_SByte  | SumClampVectorScalar      |        638.811 |       636.129 |       630.588 |   633.648 |   657.779 |   709.871 |
| YClampBenchmark_SByte  | SumClampVectorBase        |      39729.614 |     45375.640 |     45497.961 | 45519.977 | 45463.157 | 49631.375 |
| YClampBenchmark_SByte  | SumClampVectorTraits      |      45198.930 |     44821.813 |     45606.563 | 45565.155 | 45581.443 | 47417.469 |
| YClampBenchmark_SByte  | SumClampVector128_AdvSimd |                |               |               |           |           |           |
| YClampBenchmark_SByte  | SumClampVector128Traits   |                |               |     18606.347 | 23398.557 | 23455.320 | 24376.665 |
| YClampBenchmark_SByte  | SumClampVector256Traits   |                |               |     45664.168 | 45286.542 | 45554.075 | 46972.153 |
| YClampBenchmark_Single | SumClamp_If               |        196.898 |       205.561 |       208.440 |   197.928 |   215.523 |   209.468 |
| YClampBenchmark_Single | SumClamp_MinMax           |        187.660 |       200.712 |       143.267 |   155.536 |   146.009 |   845.042 |
| YClampBenchmark_Single | SumClamp_Math             |                |       200.820 |       217.249 |   216.024 |   205.877 |   229.396 |
| YClampBenchmark_Single | SumClamp_BitMath          |        288.913 |       307.096 |       306.711 |   244.696 |   266.656 |   345.403 |
| YClampBenchmark_Single | SumClampVectorScalar      |        836.185 |       845.947 |       844.895 |   844.592 |   846.056 |   846.052 |
| YClampBenchmark_Single | SumClampVectorBase        |       6443.775 |      6743.423 |      6753.187 |  6726.650 |  6723.729 |  6755.599 |
| YClampBenchmark_Single | SumClampVectorTraits      |       6141.176 |      6733.703 |      6740.842 |  6616.221 |  6742.713 |  6755.329 |
| YClampBenchmark_Single | SumClampVector128_AdvSimd |                |               |               |           |           |           |
| YClampBenchmark_Single | SumClampVector128Traits   |                |               |      3377.724 |  3032.265 |  3378.593 |  3365.415 |
| YClampBenchmark_Single | SumClampVector256Traits   |                |               |      6735.586 |  6734.416 |  6742.660 |  6750.943 |

### Arm - Apple M2
| Type                   | Method                          |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :--------------------- | :------------------------------ | --------: | --------: | --------: |
| YClampBenchmark_Double | SumClamp_If                     |   243.012 |   285.202 |   291.725 |
| YClampBenchmark_Double | SumClamp_MinMax                 |   203.235 |  1165.919 |   227.866 |
| YClampBenchmark_Double | SumClamp_Math                   |   249.240 |   281.928 |   295.458 |
| YClampBenchmark_Double | SumClamp_BitMath                |   499.064 |   995.442 |  1133.217 |
| YClampBenchmark_Double | SumClampVectorScalar            |  1133.840 |  1134.055 |  1165.902 |
| YClampBenchmark_Double | SumClampVectorBase              |  2268.115 |  2267.900 |  2332.009 |
| YClampBenchmark_Double | SumClampVectorTraits            |  1133.982 |  1166.103 |  1166.128 |
| YClampBenchmark_Double | SumClampVector128_AdvSimd       |   201.361 |   987.115 |   220.739 |
| YClampBenchmark_Double | SumClampVector128Bcl            |           |  2267.429 |  2332.187 |
| YClampBenchmark_Double | SumClampVector128Base           |   142.954 |  2267.642 |  2332.102 |
| YClampBenchmark_Double | SumClampVector128Traits         |  2268.162 |  2267.611 |  2331.928 |
| YClampBenchmark_Double | SumClampVector256Traits         |   120.887 |   148.508 |  4535.718 |
| YClampBenchmark_Double | SumClampVector512Bcl            |           |           |  9048.528 |
| YClampBenchmark_Double | SumClampVector512Traits         |           |           |  9047.123 |
| YClampBenchmark_Int16  | SumClamp_If                     |   261.866 |   314.916 |   329.622 |
| YClampBenchmark_Int16  | SumClamp_MinMax                 |   243.848 |   314.576 |   314.115 |
| YClampBenchmark_Int16  | SumClamp_Math                   |   255.028 |   304.322 |   318.109 |
| YClampBenchmark_Int16  | SumClamp_BitMath                |   562.062 |   730.709 |   853.201 |
| YClampBenchmark_Int16  | SumClampVectorScalar            |  1360.349 |  1521.490 |  1565.991 |
| YClampBenchmark_Int16  | SumClampVectorBase              | 13608.109 | 13613.490 | 13616.759 |
| YClampBenchmark_Int16  | SumClampVectorTraits            | 13609.046 | 13614.464 | 13617.738 |
| YClampBenchmark_Int16  | SumClampVector128_AdvSimd       | 13607.945 | 13604.368 | 13611.721 |
| YClampBenchmark_Int16  | SumClampVector128Bcl            |           | 13602.069 | 13614.565 |
| YClampBenchmark_Int16  | SumClampVector128Base           |   348.657 | 13599.684 | 13613.980 |
| YClampBenchmark_Int16  | SumClampVector128Traits         | 13607.567 | 13605.515 | 13613.917 |
| YClampBenchmark_Int16  | SumClampVector256Traits         |   223.700 |   102.747 | 27155.178 |
| YClampBenchmark_Int16  | SumClampVector512Bcl            |           |           | 35790.261 |
| YClampBenchmark_Int16  | SumClampVector512Traits         |           |           | 35792.447 |
| YClampBenchmark_Int32  | SumClamp_If                     |   262.483 |   315.852 |   318.547 |
| YClampBenchmark_Int32  | SumClamp_MinMax                 |   250.353 |   302.834 |   316.902 |
| YClampBenchmark_Int32  | SumClamp_Math                   |   262.431 |   317.238 |   322.528 |
| YClampBenchmark_Int32  | SumClamp_BitMath                |   844.737 |  1098.712 |  1163.249 |
| YClampBenchmark_Int32  | SumClampVectorScalar            |  1700.439 |  2473.395 |  2720.929 |
| YClampBenchmark_Int32  | SumClampVectorBase              |  6802.976 |  6804.790 |  6806.300 |
| YClampBenchmark_Int32  | SumClampVectorTraits            |  6803.371 |  6804.519 |  6805.358 |
| YClampBenchmark_Int32  | SumClampVector128_AdvSimd       |  6801.594 |  6801.772 |  6803.127 |
| YClampBenchmark_Int32  | SumClampVector128Bcl            |           |  6801.281 |  6804.217 |
| YClampBenchmark_Int32  | SumClampVector128Base           |   253.515 |  6799.886 |  6803.015 |
| YClampBenchmark_Int32  | SumClampVector128Traits         |  6803.692 |  6801.987 |  6804.536 |
| YClampBenchmark_Int32  | SumClampVector256Traits         |   182.938 |   171.737 | 13565.560 |
| YClampBenchmark_Int32  | SumClampVector512Bcl            |           |           | 17861.886 |
| YClampBenchmark_Int32  | SumClampVector512Traits         |           |           | 17860.722 |
| YClampBenchmark_Int64  | SumClamp_If                     |   258.296 |   314.651 |   311.841 |
| YClampBenchmark_Int64  | SumClamp_MinMax                 |   257.866 |   310.718 |   311.974 |
| YClampBenchmark_Int64  | SumClamp_Math                   |   258.537 |   313.268 |   319.611 |
| YClampBenchmark_Int64  | SumClamp_BitMath                |   749.550 |   942.408 |   992.510 |
| YClampBenchmark_Int64  | SumClampVectorScalar            |  1511.648 |  1813.596 |  2216.410 |
| YClampBenchmark_Int64  | SumClampVectorBase              |  3401.518 |  3400.420 |  3401.046 |
| YClampBenchmark_Int64  | SumClampVectorTraits            |  1701.025 |  1700.750 |  1700.515 |
| YClampBenchmark_Int64  | SumClampVector128_AdvSimd       |   204.526 |   204.691 |   211.387 |
| YClampBenchmark_Int64  | SumClampVector128_Arm64         |  3401.207 |  3365.816 |  3401.404 |
| YClampBenchmark_Int64  | SumClampVector128Bcl            |           |  3365.182 |  3400.938 |
| YClampBenchmark_Int64  | SumClampVector128Base           |   160.778 |  3359.794 |  3401.326 |
| YClampBenchmark_Int64  | SumClampVector128Traits         |  3400.458 |  3365.796 |  3400.628 |
| YClampBenchmark_Int64  | SumClampVector256Traits         |   132.453 |   152.056 |  5241.594 |
| YClampBenchmark_Int64  | SumClampVector512Bcl            |           |           |  5150.042 |
| YClampBenchmark_Int64  | SumClampVector512Traits         |           |           |  5146.372 |
| YClampBenchmark_SByte  | SumClamp_If                     |   264.800 |   301.231 |   308.603 |
| YClampBenchmark_SByte  | SumClamp_MinMax                 |   255.253 |   293.603 |   307.844 |
| YClampBenchmark_SByte  | SumClamp_Math                   |   269.732 |   296.505 |   307.694 |
| YClampBenchmark_SByte  | SumClamp_BitMath                |   588.665 |   719.502 |   846.236 |
| YClampBenchmark_SByte  | SumClampVectorScalar            |  1431.918 |  1524.314 |  1564.793 |
| YClampBenchmark_SByte  | SumClampVectorBase              | 27136.283 | 27187.582 | 27216.839 |
| YClampBenchmark_SByte  | SumClampVectorTraits            | 27175.139 | 27186.221 | 27228.030 |
| YClampBenchmark_SByte  | SumClampVector128_AdvSimd       | 27167.352 | 27142.180 | 27201.924 |
| YClampBenchmark_SByte  | SumClampVector128Bcl            |           | 27134.579 | 27204.948 |
| YClampBenchmark_SByte  | SumClampVector128Base           |   448.350 | 27129.805 | 27205.170 |
| YClampBenchmark_SByte  | SumClampVector128Traits         | 27168.146 | 27142.497 | 27191.636 |
| YClampBenchmark_SByte  | SumClampVector256Traits         |   446.719 |   166.135 | 54036.025 |
| YClampBenchmark_SByte  | SumClampVector512Bcl            |           |           | 71676.384 |
| YClampBenchmark_SByte  | SumClampVector512Traits         |           |           | 71671.860 |
| YClampBenchmark_Single | SumClamp_If                     |   248.983 |   293.224 |   293.815 |
| YClampBenchmark_Single | SumClamp_MinMax                 |   192.515 |  1165.622 |   228.596 |
| YClampBenchmark_Single | SumClamp_Math                   |   249.200 |   282.381 |   293.637 |
| YClampBenchmark_Single | SumClamp_BitMath                |   527.069 |  1019.395 |  1133.622 |
| YClampBenchmark_Single | SumClampVectorScalar            |  1133.778 |  1155.479 |  1165.928 |
| YClampBenchmark_Single | SumClampVectorBase              |  4536.291 |  4665.190 |  4665.489 |
| YClampBenchmark_Single | SumClampVectorTraits            |  4537.388 |  4665.217 |  4665.699 |
| YClampBenchmark_Single | SumClampVector128_AdvSimd       |  4536.514 |  4535.554 |  4665.971 |
| YClampBenchmark_Single | SumClampVector128_Wasm_NoPseudo |           |           |           |
| YClampBenchmark_Single | SumClampVector128_Wasm_Pseudo   |           |           |           |
| YClampBenchmark_Single | SumClampVector128Bcl            |           |  4535.116 |  4537.921 |
| YClampBenchmark_Single | SumClampVector128Base           |   223.077 |  4534.952 |  4665.691 |
| YClampBenchmark_Single | SumClampVector128Traits         |  4536.572 |  4535.952 |  4595.601 |
| YClampBenchmark_Single | SumClampVector256Traits         |   173.397 |   173.946 |  9070.795 |
| YClampBenchmark_Single | SumClampVector512Bcl            |           |           | 17997.323 |
| YClampBenchmark_Single | SumClampVector512Traits         |           |           | 17994.827 |

### Arm - AWS Arm t4g.small
| Type                   | Method                          | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :--------------------- | :------------------------------ | ------------: | --------: | --------: | --------: | --------: |
| YClampBenchmark_Double | SumClamp_If                     |       177.872 |   171.158 |   172.128 |   210.721 |   224.801 |
| YClampBenchmark_Double | SumClamp_MinMax                 |       122.243 |   131.514 |   137.582 |  1236.406 |   147.094 |
| YClampBenchmark_Double | SumClamp_Math                   |       173.258 |   171.522 |   180.771 |   215.209 |   225.878 |
| YClampBenchmark_Double | SumClamp_BitMath                |       163.892 |   115.090 |   113.163 |   259.291 |   389.472 |
| YClampBenchmark_Double | SumClampVectorScalar            |       619.760 |   675.615 |   654.862 |   845.926 |  1097.784 |
| YClampBenchmark_Double | SumClampVectorBase              |      1643.899 |  1970.459 |  1979.492 |  2343.170 |  2437.285 |
| YClampBenchmark_Double | SumClampVectorTraits            |      1240.001 |  1243.642 |  1242.753 |  1240.796 |  1242.787 |
| YClampBenchmark_Double | SumClampVector128_AdvSimd       |               |   143.479 |   141.033 |   348.336 |   150.488 |
| YClampBenchmark_Double | SumClampVector128Bcl            |               |           |           |  1935.349 |  2441.002 |
| YClampBenchmark_Double | SumClampVector128Base           |        64.030 |    48.804 |    49.555 |  1940.234 |  2441.278 |
| YClampBenchmark_Double | SumClampVector128Traits         |        59.718 |  1980.561 |  1654.593 |  1933.877 |  2442.729 |
| YClampBenchmark_Double | SumClampVector256Traits         |        31.418 |    57.461 |    58.447 |    86.478 |  2995.611 |
| YClampBenchmark_Double | SumClampVector512Bcl            |               |           |           |           |  3184.094 |
| YClampBenchmark_Double | SumClampVector512Traits         |               |           |           |           |  3195.519 |
| YClampBenchmark_Int16  | SumClamp_If                     |       172.617 |   167.431 |   167.615 |   198.228 |   197.181 |
| YClampBenchmark_Int16  | SumClamp_MinMax                 |       167.418 |   166.366 |   153.017 |   189.247 |   190.182 |
| YClampBenchmark_Int16  | SumClamp_Math                   |       168.082 |   169.403 |   169.254 |   195.452 |   203.372 |
| YClampBenchmark_Int16  | SumClamp_BitMath                |       220.175 |   169.642 |   170.152 |   212.931 |   299.549 |
| YClampBenchmark_Int16  | SumClampVectorScalar            |       426.974 |   430.892 |   427.703 |   553.151 |   836.674 |
| YClampBenchmark_Int16  | SumClampVectorBase              |      6635.492 |  6598.702 |  7812.440 |  9814.435 |  9610.311 |
| YClampBenchmark_Int16  | SumClampVectorTraits            |      6625.248 |  7792.358 |  7810.993 |  9819.164 |  9607.779 |
| YClampBenchmark_Int16  | SumClampVector128_AdvSimd       |               |  7778.730 |  7813.157 |  7905.218 |  9567.060 |
| YClampBenchmark_Int16  | SumClampVector128Bcl            |               |           |           |  7839.706 |  9591.590 |
| YClampBenchmark_Int16  | SumClampVector128Base           |       149.372 |   108.917 |   108.938 |  7880.709 |  9589.323 |
| YClampBenchmark_Int16  | SumClampVector128Traits         |       149.181 |  7786.995 |  7799.330 |  7888.087 |  9512.823 |
| YClampBenchmark_Int16  | SumClampVector256Traits         |       100.991 |    98.703 |    91.053 |    62.963 | 11042.571 |
| YClampBenchmark_Int16  | SumClampVector512Bcl            |               |           |           |           | 11619.540 |
| YClampBenchmark_Int16  | SumClampVector512Traits         |               |           |           |           | 11614.050 |
| YClampBenchmark_Int32  | SumClamp_If                     |       177.245 |   172.084 |   172.151 |   201.629 |   217.668 |
| YClampBenchmark_Int32  | SumClamp_MinMax                 |       162.000 |   166.787 |   167.164 |   193.994 |   199.081 |
| YClampBenchmark_Int32  | SumClamp_Math                   |       170.242 |   162.993 |   166.722 |   209.330 |   224.231 |
| YClampBenchmark_Int32  | SumClamp_BitMath                |       276.158 |   210.805 |   211.589 |   278.307 |   388.288 |
| YClampBenchmark_Int32  | SumClampVectorScalar            |       659.722 |   658.860 |   618.203 |   990.234 |  1054.795 |
| YClampBenchmark_Int32  | SumClampVectorBase              |      3936.514 |  3281.355 |  3851.721 |  4791.270 |  4702.639 |
| YClampBenchmark_Int32  | SumClampVectorTraits            |      3936.545 |  3291.395 |  3876.027 |  4789.949 |  4673.562 |
| YClampBenchmark_Int32  | SumClampVector128_AdvSimd       |               |  3871.415 |  3893.951 |  3908.929 |  4678.842 |
| YClampBenchmark_Int32  | SumClampVector128Bcl            |               |           |           |  3911.099 |  4682.599 |
| YClampBenchmark_Int32  | SumClampVector128Base           |        86.315 |    71.038 |    71.353 |  3910.848 |  4669.202 |
| YClampBenchmark_Int32  | SumClampVector128Traits         |        86.772 |  3886.249 |  3886.188 |  3912.493 |  4680.058 |
| YClampBenchmark_Int32  | SumClampVector256Traits         |        55.432 |    74.522 |    68.652 |    74.006 |  5433.573 |
| YClampBenchmark_Int32  | SumClampVector512Bcl            |               |           |           |           |  5746.482 |
| YClampBenchmark_Int32  | SumClampVector512Traits         |               |           |           |           |  5737.426 |
| YClampBenchmark_Int64  | SumClamp_If                     |       155.905 |   161.343 |   167.976 |   199.420 |   190.104 |
| YClampBenchmark_Int64  | SumClamp_MinMax                 |       153.264 |   160.688 |   164.968 |   199.483 |   201.826 |
| YClampBenchmark_Int64  | SumClamp_Math                   |       164.425 |   167.733 |   167.322 |   190.386 |   184.647 |
| YClampBenchmark_Int64  | SumClamp_BitMath                |       246.296 |   191.407 |   191.476 |   245.307 |   336.027 |
| YClampBenchmark_Int64  | SumClampVectorScalar            |       365.929 |   558.932 |   543.122 |   514.889 |   728.638 |
| YClampBenchmark_Int64  | SumClampVectorBase              |       922.230 |  1414.997 |  1439.011 |  1698.887 |  1527.601 |
| YClampBenchmark_Int64  | SumClampVectorTraits            |       802.399 |  1159.274 |  1155.283 |  1232.783 |  1184.569 |
| YClampBenchmark_Int64  | SumClampVector128_AdvSimd       |               |   147.452 |   145.047 |   147.395 |   150.707 |
| YClampBenchmark_Int64  | SumClampVector128_Arm64         |               |  1429.676 |  1436.864 |  1401.730 |  1522.410 |
| YClampBenchmark_Int64  | SumClampVector128Bcl            |               |           |           |  1398.875 |  1525.076 |
| YClampBenchmark_Int64  | SumClampVector128Base           |        65.616 |    48.713 |    48.746 |  1399.256 |  1524.067 |
| YClampBenchmark_Int64  | SumClampVector128Traits         |        66.100 |  1426.764 |  1434.984 |  1399.559 |  1526.688 |
| YClampBenchmark_Int64  | SumClampVector256Traits         |        31.613 |    57.332 |    56.662 |    86.472 |  1681.013 |
| YClampBenchmark_Int64  | SumClampVector512Bcl            |               |           |           |           |  1719.035 |
| YClampBenchmark_Int64  | SumClampVector512Traits         |               |           |           |           |  1716.239 |
| YClampBenchmark_SByte  | SumClamp_If                     |       162.275 |   162.882 |   167.077 |   198.488 |   197.202 |
| YClampBenchmark_SByte  | SumClamp_MinMax                 |       163.500 |   159.816 |   156.154 |   202.845 |   199.937 |
| YClampBenchmark_SByte  | SumClamp_Math                   |       162.936 |   164.885 |   168.853 |   202.094 |   196.319 |
| YClampBenchmark_SByte  | SumClamp_BitMath                |       225.682 |   174.540 |   178.070 |   230.894 |   321.808 |
| YClampBenchmark_SByte  | SumClampVectorScalar            |       438.992 |   440.056 |   460.582 |   610.733 |   927.106 |
| YClampBenchmark_SByte  | SumClampVectorBase              |     15809.204 | 13161.023 | 15565.576 | 19483.520 | 19091.196 |
| YClampBenchmark_SByte  | SumClampVectorTraits            |     15812.858 | 13105.808 | 15553.648 | 19475.604 | 19104.693 |
| YClampBenchmark_SByte  | SumClampVector128_AdvSimd       |               | 15467.001 | 15538.005 | 15724.011 | 19094.676 |
| YClampBenchmark_SByte  | SumClampVector128Bcl            |               |           |           | 15641.000 | 19070.673 |
| YClampBenchmark_SByte  | SumClampVector128Base           |       228.468 |   165.398 |   165.725 | 15592.102 | 19048.761 |
| YClampBenchmark_SByte  | SumClampVector128Traits         |       228.590 | 15554.875 | 15545.707 | 15728.368 | 19104.087 |
| YClampBenchmark_SByte  | SumClampVector256Traits         |       192.966 |   175.196 |   175.487 |    85.466 | 21945.467 |
| YClampBenchmark_SByte  | SumClampVector512Bcl            |               |           |           |           | 23647.038 |
| YClampBenchmark_SByte  | SumClampVector512Traits         |               |           |           |           | 23647.760 |
| YClampBenchmark_Single | SumClamp_If                     |       167.018 |   179.759 |   178.037 |   212.110 |   225.242 |
| YClampBenchmark_Single | SumClamp_MinMax                 |       121.993 |   133.025 |   122.190 |  1241.166 |   147.444 |
| YClampBenchmark_Single | SumClamp_Math                   |       173.737 |   171.227 |   180.743 |   214.512 |   226.615 |
| YClampBenchmark_Single | SumClamp_BitMath                |       171.694 |   127.420 |   126.281 |   279.575 |   448.550 |
| YClampBenchmark_Single | SumClampVectorScalar            |       620.953 |   685.472 |   620.639 |   846.823 |  1112.555 |
| YClampBenchmark_Single | SumClampVectorBase              |      3946.140 |  3874.249 |  3894.369 |  4821.109 |  4653.687 |
| YClampBenchmark_Single | SumClampVectorTraits            |      3944.212 |  3300.060 |  3853.405 |  4821.586 |  4639.709 |
| YClampBenchmark_Single | SumClampVector128_AdvSimd       |               |  3295.164 |  3883.408 |  3917.471 |  4657.250 |
| YClampBenchmark_Single | SumClampVector128_Wasm_NoPseudo |               |           |           |           |           |
| YClampBenchmark_Single | SumClampVector128_Wasm_Pseudo   |               |           |           |           |           |
| YClampBenchmark_Single | SumClampVector128Bcl            |               |           |           |  3924.753 |  4645.216 |
| YClampBenchmark_Single | SumClampVector128Base           |        85.189 |    69.534 |    69.715 |  3921.758 |  4660.110 |
| YClampBenchmark_Single | SumClampVector128Traits         |        85.377 |  3871.644 |  3883.198 |  3923.308 |  4684.554 |
| YClampBenchmark_Single | SumClampVector256Traits         |        56.759 |    75.407 |    72.560 |    89.812 |  5393.865 |
| YClampBenchmark_Single | SumClampVector512Bcl            |               |           |           |           |  5713.782 |
| YClampBenchmark_Single | SumClampVector512Traits         |               |           |           |           |  5707.295 |

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                   | Method                          | .NET 8.0 |
| :--------------------- | :------------------------------ | -------: |
| YClampBenchmark_Double | SumClamp_If                     |   24.478 |
| YClampBenchmark_Double | SumClamp_MinMax                 |   25.687 |
| YClampBenchmark_Double | SumClamp_Math                   |   17.092 |
| YClampBenchmark_Double | SumClamp_BitMath                |   11.944 |
| YClampBenchmark_Double | SumClampVectorScalar            |    1.603 |
| YClampBenchmark_Double | SumClampVectorBase              |    2.722 |
| YClampBenchmark_Double | SumClampVectorTraits            |    6.461 |
| YClampBenchmark_Double | SumClampVector128_AdvSimd       |          |
| YClampBenchmark_Double | SumClampVector128Bcl            |    1.488 |
| YClampBenchmark_Double | SumClampVector128Base           |    1.490 |
| YClampBenchmark_Double | SumClampVector128Traits         |   32.430 |
| YClampBenchmark_Double | SumClampVector256Traits         |    1.404 |
| YClampBenchmark_Double | SumClampVector512Bcl            |    1.469 |
| YClampBenchmark_Double | SumClampVector512Traits         |    1.501 |
| YClampBenchmark_Int16  | SumClamp_If                     |   23.384 |
| YClampBenchmark_Int16  | SumClamp_MinMax                 |   17.282 |
| YClampBenchmark_Int16  | SumClamp_Math                   |   17.565 |
| YClampBenchmark_Int16  | SumClamp_BitMath                |   11.270 |
| YClampBenchmark_Int16  | SumClampVectorScalar            |    0.789 |
| YClampBenchmark_Int16  | SumClampVectorBase              |    6.385 |
| YClampBenchmark_Int16  | SumClampVectorTraits            |   65.281 |
| YClampBenchmark_Int16  | SumClampVector128_AdvSimd       |          |
| YClampBenchmark_Int16  | SumClampVector128Bcl            |    4.787 |
| YClampBenchmark_Int16  | SumClampVector128Base           |    4.885 |
| YClampBenchmark_Int16  | SumClampVector128Traits         |  132.959 |
| YClampBenchmark_Int16  | SumClampVector256Traits         |    4.162 |
| YClampBenchmark_Int16  | SumClampVector512Bcl            |    3.981 |
| YClampBenchmark_Int16  | SumClampVector512Traits         |    3.975 |
| YClampBenchmark_Int32  | SumClamp_If                     |   24.221 |
| YClampBenchmark_Int32  | SumClamp_MinMax                 |   18.124 |
| YClampBenchmark_Int32  | SumClamp_Math                   |   19.012 |
| YClampBenchmark_Int32  | SumClamp_BitMath                |   14.160 |
| YClampBenchmark_Int32  | SumClampVectorScalar            |    1.304 |
| YClampBenchmark_Int32  | SumClampVectorBase              |    6.082 |
| YClampBenchmark_Int32  | SumClampVectorTraits            |   33.352 |
| YClampBenchmark_Int32  | SumClampVector128_AdvSimd       |          |
| YClampBenchmark_Int32  | SumClampVector128Bcl            |    3.626 |
| YClampBenchmark_Int32  | SumClampVector128Base           |    3.668 |
| YClampBenchmark_Int32  | SumClampVector128Traits         |   64.035 |
| YClampBenchmark_Int32  | SumClampVector256Traits         |    2.703 |
| YClampBenchmark_Int32  | SumClampVector512Bcl            |    2.663 |
| YClampBenchmark_Int32  | SumClampVector512Traits         |    2.670 |
| YClampBenchmark_Int64  | SumClamp_If                     |   25.183 |
| YClampBenchmark_Int64  | SumClamp_MinMax                 |   19.126 |
| YClampBenchmark_Int64  | SumClamp_Math                   |   18.596 |
| YClampBenchmark_Int64  | SumClamp_BitMath                |   12.819 |
| YClampBenchmark_Int64  | SumClampVectorScalar            |    2.004 |
| YClampBenchmark_Int64  | SumClampVectorBase              |    3.318 |
| YClampBenchmark_Int64  | SumClampVectorTraits            |    1.749 |
| YClampBenchmark_Int64  | SumClampVector128_AdvSimd       |          |
| YClampBenchmark_Int64  | SumClampVector128_Arm64         |          |
| YClampBenchmark_Int64  | SumClampVector128Bcl            |    1.666 |
| YClampBenchmark_Int64  | SumClampVector128Base           |    1.638 |
| YClampBenchmark_Int64  | SumClampVector128Traits         |    2.148 |
| YClampBenchmark_Int64  | SumClampVector256Traits         |    1.637 |
| YClampBenchmark_Int64  | SumClampVector512Bcl            |    1.573 |
| YClampBenchmark_Int64  | SumClampVector512Traits         |    1.651 |
| YClampBenchmark_SByte  | SumClamp_If                     |   23.637 |
| YClampBenchmark_SByte  | SumClamp_MinMax                 |   17.306 |
| YClampBenchmark_SByte  | SumClamp_Math                   |   17.929 |
| YClampBenchmark_SByte  | SumClamp_BitMath                |   11.722 |
| YClampBenchmark_SByte  | SumClampVectorScalar            |    0.500 |
| YClampBenchmark_SByte  | SumClampVectorBase              |    8.521 |
| YClampBenchmark_SByte  | SumClampVectorTraits            |  134.541 |
| YClampBenchmark_SByte  | SumClampVector128_AdvSimd       |          |
| YClampBenchmark_SByte  | SumClampVector128Bcl            |    7.182 |
| YClampBenchmark_SByte  | SumClampVector128Base           |    6.969 |
| YClampBenchmark_SByte  | SumClampVector128Traits         |  288.723 |
| YClampBenchmark_SByte  | SumClampVector256Traits         |    6.202 |
| YClampBenchmark_SByte  | SumClampVector512Bcl            |    5.764 |
| YClampBenchmark_SByte  | SumClampVector512Traits         |    5.833 |
| YClampBenchmark_Single | SumClamp_If                     |   25.053 |
| YClampBenchmark_Single | SumClamp_MinMax                 |   12.246 |
| YClampBenchmark_Single | SumClamp_Math                   |   18.131 |
| YClampBenchmark_Single | SumClamp_BitMath                |   14.091 |
| YClampBenchmark_Single | SumClampVectorScalar            |    1.006 |
| YClampBenchmark_Single | SumClampVectorBase              |    4.477 |
| YClampBenchmark_Single | SumClampVectorTraits            |   33.698 |
| YClampBenchmark_Single | SumClampVector128_AdvSimd       |          |
| YClampBenchmark_Single | SumClampVector128_Wasm_NoPseudo |   65.459 |
| YClampBenchmark_Single | SumClampVector128_Wasm_Pseudo   |   65.545 |
| YClampBenchmark_Single | SumClampVector128Bcl            |    3.053 |
| YClampBenchmark_Single | SumClampVector128Base           |    3.017 |
| YClampBenchmark_Single | SumClampVector128Traits         |   64.011 |
| YClampBenchmark_Single | SumClampVector256Traits         |    2.489 |
| YClampBenchmark_Single | SumClampVector512Bcl            |    2.429 |
| YClampBenchmark_Single | SumClampVector512Traits         |    2.374 |

