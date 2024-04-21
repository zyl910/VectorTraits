# Benchmark group - Ceiling
([← Back](Ceiling.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### X86 - AMD Ryzen 7 7840H
| Type                         | Method               | .NET Framework | .NET Core 2.1 | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 |  .NET 8.0 |
| :--------------------------- | :------------------- | -------------: | ------------: | ------------: | -------: | -------: | -------: | --------: |
| CeilingBenchmark_Double      | SumScalar            |        549.481 |      1127.470 |      1092.399 | 1124.432 | 1102.614 | 1122.235 |  1109.296 |
| CeilingBenchmark_Double      | SumBcl               |                |               |               | 4548.655 | 4528.132 | 4561.589 |  4536.003 |
| CeilingBenchmark_Double      | SumBase              |       1537.499 |      1616.057 |      1894.059 | 4539.289 | 4527.078 | 4548.923 |  4545.412 |
| CeilingBenchmark_Double      | SumBase_Basic        |        309.245 |       524.000 |       524.109 |  527.698 |  522.354 |  528.197 |   510.370 |
| CeilingBenchmark_Double      | SumBase_ClearBit     |       1533.438 |      1597.584 |      1920.193 | 1909.074 | 1870.234 | 2185.821 |  2219.273 |
| CeilingBenchmark_Double      | SumTraits            |       1588.560 |      1614.423 |      4535.059 | 4557.286 | 4532.775 | 4544.622 |  4540.038 |
| CeilingBenchmark_Double      | Sum128Bcl            |                |               |               |          |          | 2273.938 |  2279.292 |
| CeilingBenchmark_Double      | Sum128Base_Basic     |                |               |       282.427 |  285.558 |  283.071 |  283.247 |   278.783 |
| CeilingBenchmark_Double      | Sum128Base           |                |               |       284.745 |  283.529 |  281.799 | 2274.075 |  2282.416 |
| CeilingBenchmark_Double      | Sum128Traits         |                |               |      2274.812 | 2284.851 | 2269.301 | 2279.640 |  2282.041 |
| CeilingBenchmark_Double      | Sum256Bcl            |                |               |               |          |          | 4532.985 |  4547.338 |
| CeilingBenchmark_Double      | Sum256Base_Basic     |                |               |       519.928 |  526.170 |  527.557 |  526.918 |   523.953 |
| CeilingBenchmark_Double      | Sum256Base           |                |               |       522.958 |  525.411 |  524.119 | 4552.297 |  4539.017 |
| CeilingBenchmark_Double      | Sum256Traits         |                |               |      4546.414 | 4557.132 | 4533.510 | 4532.947 |  4544.841 |
| CeilingBenchmark_Double      | Sum512Bcl            |                |               |               |          |          |          |  8304.459 |
| CeilingBenchmark_Double      | Sum512Base           |                |               |               |          |          |          |  8285.512 |
| CeilingBenchmark_Double      | Sum512Traits         |                |               |               |          |          |          |  8337.220 |
| CeilingBenchmark_Single      | SumScalar            |        568.101 |      1126.627 |      1120.641 | 1117.575 | 1118.693 | 1121.387 |  1131.605 |
| CeilingBenchmark_Single      | SumBcl               |                |               |               | 9101.356 | 9037.121 | 8978.265 |  9086.154 |
| CeilingBenchmark_Single      | SumBase              |       3019.487 |      3099.450 |      3551.870 | 9090.081 | 9026.872 | 8994.253 |  9075.376 |
| CeilingBenchmark_Single      | SumBase_Basic        |        354.395 |       931.439 |       943.050 |  979.380 |  971.809 |  940.211 |   910.799 |
| CeilingBenchmark_Single      | SumBase_ClearBit     |       2362.310 |      3084.885 |      3565.213 | 3620.351 | 3209.938 | 4335.544 |  4942.036 |
| CeilingBenchmark_Single      | SumTraits            |       2589.451 |      3093.159 |      9060.761 | 9060.652 | 9053.813 | 9020.588 |  9112.771 |
| CeilingBenchmark_Single      | Sum128Bcl            |                |               |               |          |          | 4525.813 |  4566.841 |
| CeilingBenchmark_Single      | Sum128Base_Basic     |                |               |       547.035 |  545.120 |  536.657 |  546.638 |   547.940 |
| CeilingBenchmark_Single      | Sum128Base           |                |               |       547.723 |  545.175 |  526.777 | 4531.776 |  4551.618 |
| CeilingBenchmark_Single      | Sum128Traits         |                |               |      4576.617 | 4563.884 | 4540.152 | 4532.696 |  4569.723 |
| CeilingBenchmark_Single      | Sum256Bcl            |                |               |               |          |          | 8996.508 |  9111.745 |
| CeilingBenchmark_Single      | Sum256Base_Basic     |                |               |       934.319 |  973.434 |  907.673 |  941.978 |   908.673 |
| CeilingBenchmark_Single      | Sum256Base           |                |               |       941.819 |  971.258 |  918.318 | 8994.049 |  9074.186 |
| CeilingBenchmark_Single      | Sum256Traits         |                |               |      9109.209 | 9013.888 | 9006.011 | 9008.715 |  9006.947 |
| CeilingBenchmark_Single      | Sum512Bcl            |                |               |               |          |          |          | 16315.358 |
| CeilingBenchmark_Single      | Sum512Base           |                |               |               |          |          |          | 16145.415 |
| CeilingBenchmark_Single      | Sum512Traits         |                |               |               |          |          |          | 15876.425 |
| FloorBenchmark_Double        | SumScalar            |        482.024 |      1072.642 |      1121.733 | 1116.525 | 1103.699 | 1107.525 |  1131.593 |
| FloorBenchmark_Double        | SumBcl               |                |               |               | 4529.003 | 4526.099 | 4529.562 |  4548.496 |
| FloorBenchmark_Double        | SumBase              |       1621.366 |      1603.926 |      1872.387 | 4522.051 | 4507.183 | 4548.732 |  4535.620 |
| FloorBenchmark_Double        | SumBase_Basic        |        325.770 |       526.818 |       526.612 |  499.696 |  497.952 |  523.820 |   526.082 |
| FloorBenchmark_Double        | SumBase_ClearBit     |       1622.208 |      1616.361 |      1889.580 | 1922.532 | 1863.205 | 2198.939 |  2369.041 |
| FloorBenchmark_Double        | SumTraits            |       1636.828 |      1565.100 |      4536.658 | 4531.654 | 4546.235 | 4541.788 |  4505.397 |
| FloorBenchmark_Double        | Sum128Bcl            |                |               |               |          |          | 2282.151 |  2262.448 |
| FloorBenchmark_Double        | Sum128Base_Basic     |                |               |       280.574 |  281.983 |  281.063 |  284.284 |   283.589 |
| FloorBenchmark_Double        | Sum128Base           |                |               |       281.966 |  282.056 |  281.538 | 2263.301 |  2272.989 |
| FloorBenchmark_Double        | Sum128Traits         |                |               |      2276.960 | 2267.054 | 2274.334 | 2273.737 |  2268.936 |
| FloorBenchmark_Double        | Sum256Bcl            |                |               |               |          |          | 4527.914 |  4546.789 |
| FloorBenchmark_Double        | Sum256Base_Basic     |                |               |       522.046 |  502.599 |  499.441 |  525.519 |   523.376 |
| FloorBenchmark_Double        | Sum256Base           |                |               |       520.700 |  497.396 |  496.910 | 4540.965 |  4547.635 |
| FloorBenchmark_Double        | Sum256Traits         |                |               |      4520.881 | 4532.267 | 4515.775 | 4557.232 |  4553.534 |
| FloorBenchmark_Double        | Sum512Bcl            |                |               |               |          |          |          |  7979.895 |
| FloorBenchmark_Double        | Sum512Base           |                |               |               |          |          |          |  8018.227 |
| FloorBenchmark_Double        | Sum512Traits         |                |               |               |          |          |          |  7984.092 |
| FloorBenchmark_Single        | SumScalar            |        500.530 |      1122.837 |      1115.910 | 1053.258 | 1122.757 | 1109.390 |  1129.957 |
| FloorBenchmark_Single        | SumBcl               |                |               |               | 9060.489 | 9075.379 | 9088.603 |  9091.753 |
| FloorBenchmark_Single        | SumBase              |       3084.739 |      3125.691 |      3560.632 | 9065.826 | 9010.049 | 9057.185 |  9048.264 |
| FloorBenchmark_Single        | SumBase_Basic        |        431.387 |       930.041 |       936.280 |  909.327 |  907.588 |  939.186 |   941.872 |
| FloorBenchmark_Single        | SumBase_ClearBit     |       3055.240 |      3089.907 |      3532.735 | 3651.926 | 3581.185 | 4372.585 |  4822.350 |
| FloorBenchmark_Single        | SumTraits            |       3043.084 |      3073.165 |      8998.757 | 9050.841 | 9037.348 | 9042.411 |  9065.725 |
| FloorBenchmark_Single        | Sum128Bcl            |                |               |               |          |          | 4552.634 |  4546.059 |
| FloorBenchmark_Single        | Sum128Base_Basic     |                |               |       547.271 |  545.545 |  544.981 |  545.522 |   544.850 |
| FloorBenchmark_Single        | Sum128Base           |                |               |       544.190 |  545.669 |  543.405 | 4552.501 |  4552.168 |
| FloorBenchmark_Single        | Sum128Traits         |                |               |      4530.685 | 4540.344 | 4541.554 | 4551.585 |  4524.560 |
| FloorBenchmark_Single        | Sum256Bcl            |                |               |               |          |          | 9067.260 |  9067.143 |
| FloorBenchmark_Single        | Sum256Base_Basic     |                |               |       936.254 |  900.997 |  907.001 |  941.292 |   939.129 |
| FloorBenchmark_Single        | Sum256Base           |                |               |       937.408 |  908.556 |  908.848 | 9021.332 |  9071.939 |
| FloorBenchmark_Single        | Sum256Traits         |                |               |      9032.480 | 9051.236 | 9075.226 | 9017.492 |  9011.531 |
| FloorBenchmark_Single        | Sum512Bcl            |                |               |               |          |          |          | 15867.152 |
| FloorBenchmark_Single        | Sum512Base           |                |               |               |          |          |          | 15867.598 |
| FloorBenchmark_Single        | Sum512Traits         |                |               |               |          |          |          | 16001.706 |
| YRoundToEvenBenchmark_Double | SumScalar            |        137.136 |      1086.725 |      1124.342 | 1113.595 | 1113.578 | 1123.031 |  1128.740 |
| YRoundToEvenBenchmark_Double | SumBase              |       3617.250 |      3657.002 |      4294.002 | 3919.030 | 4413.941 | 4375.248 |  4309.611 |
| YRoundToEvenBenchmark_Double | SumBase_Add          |       3592.600 |      3700.431 |      4233.006 | 4307.183 | 4384.467 | 4388.451 |  4286.585 |
| YRoundToEvenBenchmark_Double | SumTraits            |       3565.323 |      3658.977 |      4554.227 | 4504.822 | 4556.273 | 4557.252 |  4511.837 |
| YRoundToEvenBenchmark_Double | Sum128Base_Basic     |                |               |       281.152 |  280.525 |  282.493 |  284.188 |   283.709 |
| YRoundToEvenBenchmark_Double | Sum128Base           |                |               |       281.932 |  278.168 |  281.748 | 2235.358 |  2211.548 |
| YRoundToEvenBenchmark_Double | Sum128Traits         |                |               |      2288.033 | 2263.003 | 2280.533 | 2284.006 |  2278.463 |
| YRoundToEvenBenchmark_Double | Sum256Base_Basic     |                |               |       527.652 |  487.337 |  501.665 |  507.039 |   523.970 |
| YRoundToEvenBenchmark_Double | Sum256Base           |                |               |       522.991 |  497.586 |  500.768 | 4319.713 |  4344.511 |
| YRoundToEvenBenchmark_Double | Sum256Traits         |                |               |      4542.008 | 4521.624 | 4556.398 | 4548.715 |  4534.078 |
| YRoundToEvenBenchmark_Double | Sum512Base           |                |               |               |          |          |          |  4539.149 |
| YRoundToEvenBenchmark_Double | Sum512Traits         |                |               |               |          |          |          |  8290.922 |
| YRoundToEvenBenchmark_Single | SumScalar            |        137.277 |      1123.031 |      1121.941 | 1071.953 | 1099.883 | 1116.682 |  1132.610 |
| YRoundToEvenBenchmark_Single | SumBase              |       6906.579 |      7426.872 |      8594.248 | 8633.230 | 8798.793 | 8725.480 |  8584.997 |
| YRoundToEvenBenchmark_Single | SumBase_Add          |       6952.866 |      7338.376 |      8695.917 | 8523.335 | 8764.051 | 8618.836 |  8678.937 |
| YRoundToEvenBenchmark_Single | SumTraits            |       6941.215 |      7412.166 |      9100.447 | 9032.208 | 9078.546 | 9118.384 |  9099.815 |
| YRoundToEvenBenchmark_Single | Sum128Base_Basic     |                |               |       547.068 |  545.418 |  545.745 |  546.640 |   546.577 |
| YRoundToEvenBenchmark_Single | Sum128Base           |                |               |       548.928 |  545.336 |  547.646 | 4453.220 |  4461.377 |
| YRoundToEvenBenchmark_Single | Sum128Traits         |                |               |      4548.166 | 4536.940 | 4562.526 | 4570.443 |  4549.707 |
| YRoundToEvenBenchmark_Single | Sum256Base_Basic     |                |               |       942.418 |  906.724 |  910.943 |  905.143 |   971.270 |
| YRoundToEvenBenchmark_Single | Sum256Base           |                |               |       938.150 |  912.741 |  910.256 | 8717.290 |  8638.818 |
| YRoundToEvenBenchmark_Single | Sum256Traits         |                |               |      9092.239 | 9064.727 | 9082.861 | 9094.801 |  9091.199 |
| YRoundToEvenBenchmark_Single | Sum512Base           |                |               |               |          |          |          |  9022.483 |
| YRoundToEvenBenchmark_Single | Sum512Traits         |                |               |               |          |          |          | 16359.655 |
| YRoundToZeroBenchmark_Double | SumScalar            |        218.771 |       225.429 |       199.773 |  212.714 |  210.125 | 1080.320 |  1132.529 |
| YRoundToZeroBenchmark_Double | SumBase              |       2484.427 |      2452.903 |      3097.405 | 4469.761 | 4489.447 | 4472.370 |  4517.454 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit     |       2510.442 |      2444.809 |      3108.555 | 3049.924 | 2953.497 | 3613.276 |  2991.254 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit_Not |       2505.658 |      2454.072 |      2721.747 | 2680.540 | 2724.701 | 3013.479 |  2879.590 |
| YRoundToZeroBenchmark_Double | SumTraits            |       2495.632 |      2433.854 |      4557.374 | 4549.931 | 4538.633 | 4518.665 |  4537.231 |
| YRoundToZeroBenchmark_Double | Sum128Base_Basic     |                |               |       188.291 |  186.784 |  190.403 |  284.546 |   283.741 |
| YRoundToZeroBenchmark_Double | Sum128Base           |                |               |       187.741 |  190.277 |  191.351 | 2264.081 |  2270.376 |
| YRoundToZeroBenchmark_Double | Sum128Traits         |                |               |      2277.204 | 2280.101 | 2272.794 | 2277.533 |  2282.991 |
| YRoundToZeroBenchmark_Double | Sum256Base_Basic     |                |               |       237.030 |  239.395 |  238.115 |  505.908 |   527.369 |
| YRoundToZeroBenchmark_Double | Sum256Base           |                |               |       232.560 |  242.332 |  244.393 | 4508.334 |  4496.814 |
| YRoundToZeroBenchmark_Double | Sum256Traits         |                |               |      4552.880 | 4528.293 | 4552.627 | 4552.889 |  4539.575 |
| YRoundToZeroBenchmark_Double | Sum512Base           |                |               |               |          |          |          |  6755.622 |
| YRoundToZeroBenchmark_Double | Sum512Traits         |                |               |               |          |          |          |  8327.462 |
| YRoundToZeroBenchmark_Single | SumScalar            |        130.421 |       267.037 |       253.858 |  255.061 |  245.103 | 1107.682 |  1139.733 |
| YRoundToZeroBenchmark_Single | SumBase              |       4726.957 |      4729.666 |      5539.411 | 8907.324 | 8914.283 | 8940.517 |  8981.666 |
| YRoundToZeroBenchmark_Single | SumBase_ClearBit     |       4721.061 |      4762.280 |      5477.033 | 5719.901 | 5690.653 | 7152.393 |  5906.898 |
| YRoundToZeroBenchmark_Single | SumTraits            |       4740.410 |      4727.789 |      9115.006 | 9046.807 | 9101.294 | 9075.862 |  9069.115 |
| YRoundToZeroBenchmark_Single | Sum128Base_Basic     |                |               |       270.506 |  273.445 |  271.301 |  545.643 |   546.241 |
| YRoundToZeroBenchmark_Single | Sum128Base           |                |               |       266.615 |  269.356 |  273.446 | 4537.569 |  4517.488 |
| YRoundToZeroBenchmark_Single | Sum128Traits         |                |               |      4558.137 | 4534.828 | 4562.710 | 4559.340 |  4564.285 |
| YRoundToZeroBenchmark_Single | Sum256Base_Basic     |                |               |       249.127 |  249.983 |  252.382 |  908.074 |   980.121 |
| YRoundToZeroBenchmark_Single | Sum256Base           |                |               |       249.252 |  251.606 |  252.057 | 9025.011 |  9095.594 |
| YRoundToZeroBenchmark_Single | Sum256Traits         |                |               |      9080.462 | 9059.106 | 9119.587 | 9060.196 |  9100.825 |
| YRoundToZeroBenchmark_Single | Sum512Base           |                |               |               |          |          |          | 13134.648 |
| YRoundToZeroBenchmark_Single | Sum512Traits         |                |               |               |          |          |          | 16440.354 |

### X86 - Intel Core i5-8250U
| Type                         | Method               | .NET Framework | .NET Core 2.1 | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 |
| :--------------------------- | :------------------- | -------------: | ------------: | ------------: | -------: | -------: | -------: |
| CeilingBenchmark_Double      | SumScalar            |        371.737 |       281.620 |       282.137 |  282.055 |  282.140 |  282.076 |
| CeilingBenchmark_Double      | SumBcl               |                |               |               | 3367.948 | 3372.665 | 3363.958 |
| CeilingBenchmark_Double      | SumBase              |        939.994 |      1104.902 |      1340.663 | 3369.820 | 3370.514 | 3374.934 |
| CeilingBenchmark_Double      | SumBase_Basic        |        211.838 |       497.085 |       497.582 |  473.897 |  136.758 |  500.544 |
| CeilingBenchmark_Double      | SumBase_ClearBit     |        831.958 |      1098.234 |      1335.947 | 1342.891 | 1278.012 | 1342.663 |
| CeilingBenchmark_Double      | SumTraits            |        906.118 |      1102.451 |      3373.932 | 3373.611 | 3366.471 | 3371.318 |
| CeilingBenchmark_Double      | Sum128Bcl            |                |               |               |          |          | 1689.760 |
| CeilingBenchmark_Double      | Sum128Base_Basic     |                |               |       307.472 |  307.138 |  307.222 |  306.223 |
| CeilingBenchmark_Double      | Sum128Base           |                |               |       307.176 |  307.181 |  307.278 | 1688.910 |
| CeilingBenchmark_Double      | Sum128Traits         |                |               |      1688.123 | 1686.162 | 1687.723 | 1687.029 |
| CeilingBenchmark_Double      | Sum256Bcl            |                |               |               |          |          | 3374.338 |
| CeilingBenchmark_Double      | Sum256Base_Basic     |                |               |       539.057 |  474.368 |  139.482 |  538.351 |
| CeilingBenchmark_Double      | Sum256Base           |                |               |       539.773 |  474.299 |  139.441 | 3368.927 |
| CeilingBenchmark_Double      | Sum256Traits         |                |               |      3358.594 | 3354.522 | 3363.948 | 3367.215 |
| CeilingBenchmark_Single      | SumScalar            |        148.166 |       281.825 |       281.978 |  282.127 |  282.007 |  281.945 |
| CeilingBenchmark_Single      | SumBcl               |                |               |               | 6741.925 | 6734.217 | 6738.768 |
| CeilingBenchmark_Single      | SumBase              |       1095.133 |      2221.882 |      2569.409 | 6743.225 | 6746.937 | 6737.024 |
| CeilingBenchmark_Single      | SumBase_Basic        |        152.208 |       463.480 |       794.760 |  772.194 |  255.380 |  794.168 |
| CeilingBenchmark_Single      | SumBase_ClearBit     |       1583.780 |      2272.377 |      2568.486 | 2698.716 | 2622.592 | 2684.462 |
| CeilingBenchmark_Single      | SumTraits            |       1065.950 |      2249.785 |      6734.605 | 6736.146 | 6738.297 | 6744.141 |
| CeilingBenchmark_Single      | Sum128Bcl            |                |               |               |          |          | 3377.173 |
| CeilingBenchmark_Single      | Sum128Base_Basic     |                |               |       562.028 |  562.942 |  562.724 |  562.265 |
| CeilingBenchmark_Single      | Sum128Base           |                |               |       561.877 |  562.717 |  562.767 | 3380.882 |
| CeilingBenchmark_Single      | Sum128Traits         |                |               |      3379.182 | 3372.141 | 3377.911 | 3375.749 |
| CeilingBenchmark_Single      | Sum256Bcl            |                |               |               |          |          | 6732.600 |
| CeilingBenchmark_Single      | Sum256Base_Basic     |                |               |       890.273 |  831.179 |  257.395 |  930.868 |
| CeilingBenchmark_Single      | Sum256Base           |                |               |       890.210 |  831.125 |  257.296 | 6736.442 |
| CeilingBenchmark_Single      | Sum256Traits         |                |               |      6731.602 | 6730.672 | 6726.019 | 6735.871 |
| FloorBenchmark_Double        | SumScalar            |        358.416 |       281.657 |       282.045 |  282.121 |  281.901 |  281.698 |
| FloorBenchmark_Double        | SumBcl               |                |               |               | 3359.510 | 3372.893 | 3364.317 |
| FloorBenchmark_Double        | SumBase              |        698.766 |      1104.280 |      1340.645 | 3365.947 | 3368.951 | 3363.893 |
| FloorBenchmark_Double        | SumBase_Basic        |        244.586 |       497.655 |       498.112 |  473.383 |  136.581 |  499.284 |
| FloorBenchmark_Double        | SumBase_ClearBit     |        734.571 |      1098.501 |      1334.278 | 1338.663 | 1279.650 | 1349.079 |
| FloorBenchmark_Double        | SumTraits            |        605.527 |      1107.906 |      3368.315 | 3367.014 | 3370.659 | 3373.400 |
| FloorBenchmark_Double        | Sum128Bcl            |                |               |               |          |          | 1686.986 |
| FloorBenchmark_Double        | Sum128Base_Basic     |                |               |       307.052 |  306.504 |  306.897 |  306.155 |
| FloorBenchmark_Double        | Sum128Base           |                |               |       307.486 |  306.827 |  307.361 | 1688.467 |
| FloorBenchmark_Double        | Sum128Traits         |                |               |      1685.019 | 1684.974 | 1685.069 | 1686.328 |
| FloorBenchmark_Double        | Sum256Bcl            |                |               |               |          |          | 3369.147 |
| FloorBenchmark_Double        | Sum256Base_Basic     |                |               |       539.660 |  474.138 |  139.480 |  538.922 |
| FloorBenchmark_Double        | Sum256Base           |                |               |       539.698 |  474.016 |  139.401 | 3374.108 |
| FloorBenchmark_Double        | Sum256Traits         |                |               |      3367.969 | 3369.784 | 3369.956 | 3364.726 |
| FloorBenchmark_Single        | SumScalar            |        144.228 |       281.941 |       281.840 |  282.089 |  281.935 |  282.086 |
| FloorBenchmark_Single        | SumBcl               |                |               |               | 6739.706 | 6750.329 | 6723.379 |
| FloorBenchmark_Single        | SumBase              |       1548.149 |      2246.156 |      2553.935 | 6734.717 | 6747.700 | 6738.892 |
| FloorBenchmark_Single        | SumBase_Basic        |        163.447 |       461.349 |       794.168 |  771.097 |  255.065 |  795.187 |
| FloorBenchmark_Single        | SumBase_ClearBit     |       1215.447 |      2247.887 |      2555.778 | 2661.656 | 2627.355 | 2673.449 |
| FloorBenchmark_Single        | SumTraits            |       1130.207 |      2252.835 |      6737.850 | 6743.087 | 6716.382 | 6729.163 |
| FloorBenchmark_Single        | Sum128Bcl            |                |               |               |          |          | 3373.271 |
| FloorBenchmark_Single        | Sum128Base_Basic     |                |               |       562.206 |  563.101 |  561.866 |  563.047 |
| FloorBenchmark_Single        | Sum128Base           |                |               |       562.688 |  563.125 |  562.024 | 3374.392 |
| FloorBenchmark_Single        | Sum128Traits         |                |               |      3378.019 | 3372.074 | 3376.758 | 3375.965 |
| FloorBenchmark_Single        | Sum256Bcl            |                |               |               |          |          | 6737.070 |
| FloorBenchmark_Single        | Sum256Base_Basic     |                |               |       891.329 |  831.414 |  257.656 |  927.565 |
| FloorBenchmark_Single        | Sum256Base           |                |               |       891.208 |  830.791 |  257.368 | 6742.392 |
| FloorBenchmark_Single        | Sum256Traits         |                |               |      6736.925 | 6734.557 | 6737.162 | 6736.511 |
| YRoundToEvenBenchmark_Double | SumScalar            |         78.912 |       282.088 |       281.996 |  282.124 |  281.795 |  282.103 |
| YRoundToEvenBenchmark_Double | SumBase              |       1702.530 |      2242.179 |      2612.343 | 2705.523 | 2575.820 | 2622.030 |
| YRoundToEvenBenchmark_Double | SumBase_Add          |       1684.609 |      2190.424 |      2551.329 | 2665.736 | 2569.017 | 2651.675 |
| YRoundToEvenBenchmark_Double | SumTraits            |       1570.471 |      2165.047 |      3367.939 | 3367.058 | 3366.326 | 3369.313 |
| YRoundToEvenBenchmark_Double | Sum128Base_Basic     |                |               |       307.119 |  307.292 |  307.204 |  306.138 |
| YRoundToEvenBenchmark_Double | Sum128Base           |                |               |       307.118 |  307.071 |  307.289 | 1681.823 |
| YRoundToEvenBenchmark_Double | Sum128Traits         |                |               |      1687.654 | 1690.072 | 1688.480 | 1683.988 |
| YRoundToEvenBenchmark_Double | Sum256Base_Basic     |                |               |       539.245 |  474.191 |  139.475 |  539.189 |
| YRoundToEvenBenchmark_Double | Sum256Base           |                |               |       539.219 |  473.538 |  139.514 | 2809.219 |
| YRoundToEvenBenchmark_Double | Sum256Traits         |                |               |      3369.697 | 3371.297 | 3367.504 | 3371.984 |
| YRoundToEvenBenchmark_Single | SumScalar            |         64.624 |       282.074 |       282.127 |  281.853 |  282.052 |  282.096 |
| YRoundToEvenBenchmark_Single | SumBase              |       2117.009 |      4710.667 |      5140.096 | 6103.596 | 5951.808 | 5489.668 |
| YRoundToEvenBenchmark_Single | SumBase_Add          |       2106.134 |      4791.699 |      5190.154 | 6115.292 | 6028.539 | 5559.593 |
| YRoundToEvenBenchmark_Single | SumTraits            |       3167.618 |      4791.293 |      6735.294 | 6735.617 | 6740.122 | 6734.230 |
| YRoundToEvenBenchmark_Single | Sum128Base_Basic     |                |               |       561.859 |  563.162 |  562.585 |  563.143 |
| YRoundToEvenBenchmark_Single | Sum128Base           |                |               |       561.712 |  561.653 |  562.209 | 3324.719 |
| YRoundToEvenBenchmark_Single | Sum128Traits         |                |               |      3376.776 | 3375.345 | 3375.675 | 3370.487 |
| YRoundToEvenBenchmark_Single | Sum256Base_Basic     |                |               |       889.967 |  832.189 |  257.741 |  931.385 |
| YRoundToEvenBenchmark_Single | Sum256Base           |                |               |       890.645 |  832.451 |  257.745 | 5665.301 |
| YRoundToEvenBenchmark_Single | Sum256Traits         |                |               |      6733.353 | 6738.818 | 6736.515 | 6731.561 |
| YRoundToZeroBenchmark_Double | SumScalar            |        155.627 |       228.444 |       227.316 |  214.232 |  215.237 |  281.893 |
| YRoundToZeroBenchmark_Double | SumBase              |        781.218 |      1667.316 |      1975.546 | 3023.088 | 3001.609 | 3010.300 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit     |        737.299 |      1765.902 |      1978.367 | 1993.278 | 1909.557 | 1993.469 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit_Not |        823.704 |      1808.218 |      1817.060 | 1806.966 | 1747.250 | 1811.987 |
| YRoundToZeroBenchmark_Double | SumTraits            |        845.271 |      1603.939 |      3369.194 | 3375.452 | 3367.570 | 3366.053 |
| YRoundToZeroBenchmark_Double | Sum128Base_Basic     |                |               |       163.411 |  163.001 |  163.597 |  306.145 |
| YRoundToZeroBenchmark_Double | Sum128Base           |                |               |       163.180 |  163.499 |  163.019 | 1663.025 |
| YRoundToZeroBenchmark_Double | Sum128Traits         |                |               |      1688.797 | 1687.691 | 1688.928 | 1687.246 |
| YRoundToZeroBenchmark_Double | Sum256Base_Basic     |                |               |       199.374 |  198.568 |  198.759 |  539.233 |
| YRoundToZeroBenchmark_Double | Sum256Base           |                |               |       198.734 |  198.849 |  198.333 | 3077.768 |
| YRoundToZeroBenchmark_Double | Sum256Traits         |                |               |      3371.283 | 3351.001 | 3375.001 | 3369.877 |
| YRoundToZeroBenchmark_Single | SumScalar            |         82.638 |       196.408 |       210.676 |  191.708 |  190.555 |  282.098 |
| YRoundToZeroBenchmark_Single | SumBase              |       1303.039 |      3367.688 |      3848.289 | 6177.637 | 6163.136 | 6052.151 |
| YRoundToZeroBenchmark_Single | SumBase_ClearBit     |       1416.122 |      3373.335 |      3847.083 | 4212.048 | 4169.460 | 3965.241 |
| YRoundToZeroBenchmark_Single | SumTraits            |       1468.666 |      3371.784 |      6727.151 | 6730.234 | 6738.520 | 6737.743 |
| YRoundToZeroBenchmark_Single | Sum128Base_Basic     |                |               |       208.708 |  204.055 |  212.058 |  562.782 |
| YRoundToZeroBenchmark_Single | Sum128Base           |                |               |       209.200 |  206.037 |  212.982 | 3145.404 |
| YRoundToZeroBenchmark_Single | Sum128Traits         |                |               |      3377.788 | 3371.067 | 3372.191 | 3379.266 |
| YRoundToZeroBenchmark_Single | Sum256Base_Basic     |                |               |       204.272 |  202.664 |  202.695 |  932.117 |
| YRoundToZeroBenchmark_Single | Sum256Base           |                |               |       202.705 |  202.128 |  202.779 | 6168.437 |
| YRoundToZeroBenchmark_Single | Sum256Traits         |                |               |      6742.872 | 6726.350 | 6721.680 | 6728.401 |

### Arm - AWS Arm t4g.small
| Type                         | Method               | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 |
| :--------------------------- | :------------------- | ------------: | -------: | -------: | -------: |
| CeilingBenchmark_Double      | SumScalar            |       802.475 |  899.152 |  896.087 | 1244.573 |
| CeilingBenchmark_Double      | SumBcl               |               | 2090.753 | 1951.236 | 2469.722 |
| CeilingBenchmark_Double      | SumBase              |       460.702 | 2090.424 | 2073.086 | 2469.159 |
| CeilingBenchmark_Double      | SumBase_Basic        |       456.961 |  472.059 |  472.168 |  478.828 |
| CeilingBenchmark_Double      | SumBase_ClearBit     |       269.249 |  318.877 |  332.944 |  391.754 |
| CeilingBenchmark_Double      | SumTraits            |       455.761 | 2088.857 | 2073.393 | 2468.633 |
| CeilingBenchmark_Double      | Sum128Bcl            |               |          |          | 2468.907 |
| CeilingBenchmark_Double      | Sum128Base_Basic     |       224.635 |  469.651 |  470.873 |  476.203 |
| CeilingBenchmark_Double      | Sum128Base           |       220.323 |  469.630 |  466.378 | 2470.400 |
| CeilingBenchmark_Double      | Sum128Traits         |       224.237 | 1966.092 | 1944.047 | 2471.567 |
| CeilingBenchmark_Double      | Sum256Bcl            |               |          |          |  270.415 |
| CeilingBenchmark_Double      | Sum256Base_Basic     |       137.976 |  214.240 |  213.089 |  226.914 |
| CeilingBenchmark_Double      | Sum256Base           |       136.625 |  180.627 |  212.837 |  227.779 |
| CeilingBenchmark_Double      | Sum256Traits         |       137.263 |  214.267 |  214.891 |  227.911 |
| CeilingBenchmark_Single      | SumScalar            |       755.264 |  825.076 |  821.620 | 1242.081 |
| CeilingBenchmark_Single      | SumBcl               |               | 3925.614 | 3932.328 | 4725.805 |
| CeilingBenchmark_Single      | SumBase              |       509.536 | 3916.635 | 4172.717 | 4739.567 |
| CeilingBenchmark_Single      | SumBase_Basic        |       302.998 |  325.626 |  325.360 |  327.078 |
| CeilingBenchmark_Single      | SumBase_ClearBit     |       512.643 |  651.857 |  711.023 |  743.757 |
| CeilingBenchmark_Single      | SumTraits            |       509.028 | 4180.633 | 3911.738 | 4737.914 |
| CeilingBenchmark_Single      | Sum128Bcl            |               |          |          | 4742.519 |
| CeilingBenchmark_Single      | Sum128Base_Basic     |       162.731 |  312.634 |  314.295 |  325.212 |
| CeilingBenchmark_Single      | Sum128Base           |       164.262 |  312.173 |  313.150 | 4738.913 |
| CeilingBenchmark_Single      | Sum128Traits         |       164.054 | 3931.319 | 4187.274 | 4736.413 |
| CeilingBenchmark_Single      | Sum256Bcl            |               |          |          |  291.096 |
| CeilingBenchmark_Single      | Sum256Base_Basic     |       183.981 |  270.624 |  272.857 |  259.853 |
| CeilingBenchmark_Single      | Sum256Base           |       181.095 |  263.502 |  263.443 |  279.362 |
| CeilingBenchmark_Single      | Sum256Traits         |       183.287 |  264.484 |  263.800 |  279.281 |
| FloorBenchmark_Double        | SumScalar            |       893.020 |  826.205 |  901.694 | 1242.465 |
| FloorBenchmark_Double        | SumBcl               |               | 1964.571 | 1964.175 | 2458.168 |
| FloorBenchmark_Double        | SumBase              |       478.230 | 2095.930 | 2090.415 | 2463.610 |
| FloorBenchmark_Double        | SumBase_Basic        |       479.917 |  474.898 |  473.946 |  477.483 |
| FloorBenchmark_Double        | SumBase_ClearBit     |       280.536 |  320.654 |  334.493 |  386.872 |
| FloorBenchmark_Double        | SumTraits            |       471.857 | 2088.397 | 1955.724 | 2458.408 |
| FloorBenchmark_Double        | Sum128Bcl            |               |          |          | 2463.456 |
| FloorBenchmark_Double        | Sum128Base_Basic     |       225.615 |  469.258 |  468.512 |  475.925 |
| FloorBenchmark_Double        | Sum128Base           |       225.032 |  468.295 |  468.757 | 2464.333 |
| FloorBenchmark_Double        | Sum128Traits         |       224.880 | 1960.246 | 2073.220 | 2467.197 |
| FloorBenchmark_Double        | Sum256Bcl            |               |          |          |  270.354 |
| FloorBenchmark_Double        | Sum256Base_Basic     |       142.215 |  213.454 |  212.728 |  225.833 |
| FloorBenchmark_Double        | Sum256Base           |       142.525 |  214.082 |  212.717 |  226.649 |
| FloorBenchmark_Double        | Sum256Traits         |       141.989 |  214.775 |  213.016 |  227.294 |
| FloorBenchmark_Single        | SumScalar            |       819.783 |  901.142 |  825.485 | 1239.536 |
| FloorBenchmark_Single        | SumBcl               |               | 3934.178 | 3915.212 | 4724.561 |
| FloorBenchmark_Single        | SumBase              |       557.333 | 3922.912 | 4182.531 | 4727.887 |
| FloorBenchmark_Single        | SumBase_Basic        |       324.783 |  326.200 |  328.710 |  326.868 |
| FloorBenchmark_Single        | SumBase_ClearBit     |       559.858 |  655.076 |  712.563 |  739.310 |
| FloorBenchmark_Single        | SumTraits            |       559.455 | 4200.880 | 3935.907 | 4737.593 |
| FloorBenchmark_Single        | Sum128Bcl            |               |          |          | 4737.922 |
| FloorBenchmark_Single        | Sum128Base_Basic     |       177.992 |  314.032 |  313.997 |  324.639 |
| FloorBenchmark_Single        | Sum128Base           |       177.351 |  314.320 |  314.624 | 4736.704 |
| FloorBenchmark_Single        | Sum128Traits         |       177.564 | 3932.085 | 4197.332 | 4728.512 |
| FloorBenchmark_Single        | Sum256Bcl            |               |          |          |  290.663 |
| FloorBenchmark_Single        | Sum256Base_Basic     |       203.330 |  270.956 |  273.090 |  258.384 |
| FloorBenchmark_Single        | Sum256Base           |       199.964 |  263.244 |  263.868 |  278.878 |
| FloorBenchmark_Single        | Sum256Traits         |       199.398 |  263.281 |  263.253 |  278.941 |
| YRoundToEvenBenchmark_Double | SumScalar            |       830.994 |  902.443 |  829.548 | 1242.953 |
| YRoundToEvenBenchmark_Double | SumBase              |       725.392 |  730.824 |  747.696 |  785.293 |
| YRoundToEvenBenchmark_Double | SumBase_Add          |       711.026 |  731.800 |  748.325 |  785.359 |
| YRoundToEvenBenchmark_Double | SumTraits            |       723.107 | 2101.767 | 2090.865 | 2465.669 |
| YRoundToEvenBenchmark_Double | Sum128Base_Basic     |       228.598 |  469.700 |  472.983 |  475.856 |
| YRoundToEvenBenchmark_Double | Sum128Base           |       229.616 |  469.588 |  469.905 | 1022.284 |
| YRoundToEvenBenchmark_Double | Sum128Traits         |       225.860 | 1966.244 | 1963.770 | 2469.134 |
| YRoundToEvenBenchmark_Double | Sum256Base_Basic     |       144.694 |  214.089 |  214.187 |  227.566 |
| YRoundToEvenBenchmark_Double | Sum256Base           |       144.426 |  215.319 |  213.412 |   49.447 |
| YRoundToEvenBenchmark_Double | Sum256Traits         |       144.440 |  214.896 |  213.986 |   49.422 |
| YRoundToEvenBenchmark_Single | SumScalar            |       828.954 |  827.520 |  826.621 | 1241.168 |
| YRoundToEvenBenchmark_Single | SumBase              |      1493.248 | 1473.490 | 1534.078 | 1527.605 |
| YRoundToEvenBenchmark_Single | SumBase_Add          |      1480.556 | 1469.131 | 1533.654 | 1527.781 |
| YRoundToEvenBenchmark_Single | SumTraits            |      1484.456 | 4213.338 | 3930.969 | 4715.479 |
| YRoundToEvenBenchmark_Single | Sum128Base_Basic     |       179.317 |  314.415 |  314.970 |  326.002 |
| YRoundToEvenBenchmark_Single | Sum128Base           |       179.412 |  315.066 |  314.312 | 1833.935 |
| YRoundToEvenBenchmark_Single | Sum128Traits         |       178.731 | 3949.155 | 4185.752 | 4713.160 |
| YRoundToEvenBenchmark_Single | Sum256Base_Basic     |       203.439 |  271.949 |  273.173 |  259.824 |
| YRoundToEvenBenchmark_Single | Sum256Base           |       199.794 |  264.657 |  264.208 |   64.485 |
| YRoundToEvenBenchmark_Single | Sum256Traits         |       200.047 |  264.269 |  264.977 |   64.468 |
| YRoundToZeroBenchmark_Double | SumScalar            |       162.058 |  162.370 |  161.835 | 1245.080 |
| YRoundToZeroBenchmark_Double | SumBase              |       479.613 | 1079.684 | 1083.150 | 1207.634 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit     |       478.734 |  496.989 |  536.991 |  606.500 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit_Not |       411.633 |  443.044 |  471.955 |  533.553 |
| YRoundToZeroBenchmark_Double | SumTraits            |       478.186 | 2097.093 | 2087.945 | 2464.112 |
| YRoundToZeroBenchmark_Double | Sum128Base_Basic     |       119.096 |  149.846 |  150.187 |  475.787 |
| YRoundToZeroBenchmark_Double | Sum128Base           |       119.109 |  155.175 |  155.611 | 1600.828 |
| YRoundToZeroBenchmark_Double | Sum128Traits         |       119.370 | 1971.661 | 1961.925 | 2466.672 |
| YRoundToZeroBenchmark_Double | Sum256Base_Basic     |        82.222 |  112.712 |  114.385 |  227.109 |
| YRoundToZeroBenchmark_Double | Sum256Base           |        80.003 |  113.960 |  114.698 |   80.149 |
| YRoundToZeroBenchmark_Double | Sum256Traits         |        79.144 |  114.585 |  115.679 |   80.425 |
| YRoundToZeroBenchmark_Single | SumScalar            |       149.072 |  149.031 |  158.317 | 1240.973 |
| YRoundToZeroBenchmark_Single | SumBase              |       999.902 | 2185.952 | 2083.851 | 2279.574 |
| YRoundToZeroBenchmark_Single | SumBase_ClearBit     |       996.570 | 1031.752 | 1123.586 | 1152.359 |
| YRoundToZeroBenchmark_Single | SumTraits            |      1000.899 | 3942.155 | 3925.433 | 4728.263 |
| YRoundToZeroBenchmark_Single | Sum128Base_Basic     |       106.314 |  149.471 |  153.915 |  326.092 |
| YRoundToZeroBenchmark_Single | Sum128Base           |       113.696 |  155.161 |  149.074 | 2779.974 |
| YRoundToZeroBenchmark_Single | Sum128Traits         |       110.992 | 4209.593 | 4189.171 | 4731.875 |
| YRoundToZeroBenchmark_Single | Sum256Base_Basic     |        94.364 |  115.181 |  113.320 |  259.884 |
| YRoundToZeroBenchmark_Single | Sum256Base           |        92.799 |  117.267 |  117.620 |  116.067 |
| YRoundToZeroBenchmark_Single | Sum256Traits         |        94.921 |  116.902 |  116.931 |  116.000 |

