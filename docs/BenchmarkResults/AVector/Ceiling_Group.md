# Benchmark group - Ceiling
([← Back](Ceiling.md))

Cell unit: Million operations per second.

### x86 - lntel Core i5-8250U
| Class                        | Method           | .NET Framework | .NET Core 2.1 | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 |
| :--------------------------- | :--------------- | -------------: | ------------: | ------------: | -------: | -------: | -------: |
| CeilingBenchmark_Double      | SumScalar        |        414.692 |       280.555 |       280.831 |  277.753 |  280.509 |  280.037 |
| CeilingBenchmark_Double      | SumBcl           |                |               |               | 3117.382 | 3220.868 | 3187.029 |
| CeilingBenchmark_Double      | SumBase          |        834.411 |       822.207 |       967.544 | 3141.148 | 3136.465 | 3160.596 |
| CeilingBenchmark_Double      | SumBase_Basic    |        290.785 |       494.606 |       492.701 |  488.690 |  488.744 |  490.729 |
| CeilingBenchmark_Double      | SumBase_ClearBit |        840.957 |       814.862 |       980.499 |  924.480 |  954.281 |  985.390 |
| CeilingBenchmark_Double      | SumTraits        |        832.251 |       805.772 |      3256.891 | 3134.369 | 3042.935 | 3071.513 |
| CeilingBenchmark_Double      | Sum128Bcl        |                |               |               |          |          | 1653.729 |
| CeilingBenchmark_Double      | Sum128Base_Basic |                |               |       159.497 |  159.629 |  158.148 |  304.364 |
| CeilingBenchmark_Double      | Sum128Base       |                |               |       159.505 |  159.703 |  158.356 | 1661.578 |
| CeilingBenchmark_Double      | Sum128Traits     |                |               |       159.469 |  159.764 |  159.165 | 1656.789 |
| CeilingBenchmark_Double      | Sum256Bcl        |                |               |               |          |          | 3175.508 |
| CeilingBenchmark_Double      | Sum256Base_Basic |                |               |       535.621 |  530.404 |  529.839 |  534.538 |
| CeilingBenchmark_Double      | Sum256Base       |                |               |       536.141 |  528.637 |  535.928 | 3290.693 |
| CeilingBenchmark_Double      | Sum256Traits     |                |               |      3265.408 | 3089.002 | 3265.338 | 3286.909 |
| CeilingBenchmark_Single      | SumScalar        |        198.061 |       281.303 |       280.470 |  280.251 |  281.128 |  280.676 |
| CeilingBenchmark_Single      | SumBcl           |                |               |               | 6650.782 | 6601.893 | 6674.753 |
| CeilingBenchmark_Single      | SumBase          |       1667.763 |      1672.269 |      1807.195 | 6615.676 | 6533.543 | 6678.004 |
| CeilingBenchmark_Single      | SumBase_Basic    |        231.892 |       460.032 |       784.150 |  741.845 |  791.662 |  790.379 |
| CeilingBenchmark_Single      | SumBase_ClearBit |       1743.695 |      1687.738 |      1897.404 | 1922.220 | 1803.610 | 2112.031 |
| CeilingBenchmark_Single      | SumTraits        |       1703.384 |      1680.734 |      6503.422 | 6413.205 | 6670.659 | 6415.496 |
| CeilingBenchmark_Single      | Sum128Bcl        |                |               |               |          |          | 3345.500 |
| CeilingBenchmark_Single      | Sum128Base_Basic |                |               |       289.141 |  288.584 |  292.313 |  560.236 |
| CeilingBenchmark_Single      | Sum128Base       |                |               |       288.168 |  288.386 |  290.856 | 3345.689 |
| CeilingBenchmark_Single      | Sum128Traits     |                |               |       288.995 |  288.251 |  290.987 | 3346.906 |
| CeilingBenchmark_Single      | Sum256Bcl        |                |               |               |          |          | 6664.850 |
| CeilingBenchmark_Single      | Sum256Base_Basic |                |               |       876.270 |  874.857 |  885.988 |  925.177 |
| CeilingBenchmark_Single      | Sum256Base       |                |               |       877.487 |  877.693 |  885.936 | 6666.065 |
| CeilingBenchmark_Single      | Sum256Traits     |                |               |      6492.313 | 6427.764 | 6450.030 | 6487.916 |
| FloorBenchmark_Double        | SumScalar        |        448.969 |       280.744 |       279.195 |  278.764 |  279.810 |  280.260 |
| FloorBenchmark_Double        | SumBcl           |                |               |               | 3275.285 | 3152.259 | 3192.895 |
| FloorBenchmark_Double        | SumBase          |        834.480 |       816.653 |       976.579 | 3272.761 | 3196.305 | 3177.638 |
| FloorBenchmark_Double        | SumBase_Basic    |        296.443 |       494.535 |       491.993 |  495.579 |  488.309 |  495.667 |
| FloorBenchmark_Double        | SumBase_ClearBit |        835.931 |       862.157 |       979.510 |  992.470 |  953.577 | 1035.397 |
| FloorBenchmark_Double        | SumTraits        |        835.259 |       856.656 |      3268.709 | 3237.363 | 3172.691 | 3216.709 |
| FloorBenchmark_Double        | Sum128Bcl        |                |               |               |          |          | 1657.054 |
| FloorBenchmark_Double        | Sum128Base_Basic |                |               |       157.227 |  160.216 |  158.733 |  303.594 |
| FloorBenchmark_Double        | Sum128Base       |                |               |       159.496 |  160.155 |  159.563 | 1654.592 |
| FloorBenchmark_Double        | Sum128Traits     |                |               |       159.278 |  160.248 |  160.169 | 1655.319 |
| FloorBenchmark_Double        | Sum256Bcl        |                |               |               |          |          | 3223.031 |
| FloorBenchmark_Double        | Sum256Base_Basic |                |               |       534.198 |  536.195 |  536.277 |  533.717 |
| FloorBenchmark_Double        | Sum256Base       |                |               |       533.798 |  536.165 |  535.089 | 3205.900 |
| FloorBenchmark_Double        | Sum256Traits     |                |               |      3242.621 | 3272.271 | 3258.403 | 3178.860 |
| FloorBenchmark_Single        | SumScalar        |        196.550 |       281.437 |       281.246 |  281.182 |  281.488 |  281.232 |
| FloorBenchmark_Single        | SumBcl           |                |               |               | 6650.981 | 6675.017 | 6471.640 |
| FloorBenchmark_Single        | SumBase          |       1679.515 |      1575.332 |      1914.500 | 6546.216 | 6601.888 | 6433.686 |
| FloorBenchmark_Single        | SumBase_Basic    |        221.100 |       455.512 |       791.610 |  789.384 |  790.681 |  789.263 |
| FloorBenchmark_Single        | SumBase_ClearBit |       1372.552 |      1560.924 |      1879.837 | 2098.730 | 1801.810 | 1980.059 |
| FloorBenchmark_Single        | SumTraits        |       1183.849 |      1548.752 |      6503.210 | 6641.418 | 6632.176 | 6656.386 |
| FloorBenchmark_Single        | Sum128Bcl        |                |               |               |          |          | 3343.684 |
| FloorBenchmark_Single        | Sum128Base_Basic |                |               |       291.293 |  291.506 |  291.141 |  558.447 |
| FloorBenchmark_Single        | Sum128Base       |                |               |       291.437 |  291.033 |  291.057 | 3344.712 |
| FloorBenchmark_Single        | Sum128Traits     |                |               |       291.659 |  291.614 |  290.812 | 3343.436 |
| FloorBenchmark_Single        | Sum256Bcl        |                |               |               |          |          | 6458.805 |
| FloorBenchmark_Single        | Sum256Base_Basic |                |               |       885.980 |  884.165 |  883.170 |  924.030 |
| FloorBenchmark_Single        | Sum256Base       |                |               |       885.522 |  884.961 |  883.464 | 6514.009 |
| FloorBenchmark_Single        | Sum256Traits     |                |               |      6669.505 | 6596.996 | 6674.671 | 6671.728 |
| YRoundToEvenBenchmark_Double | SumScalar        |        100.147 |       280.567 |       281.110 |  280.088 |  279.980 |  280.504 |
| YRoundToEvenBenchmark_Double | SumBase          |       1610.072 |      2098.419 |      2445.436 | 2509.018 | 2597.214 | 2684.754 |
| YRoundToEvenBenchmark_Double | SumBase_Add      |       1761.709 |      2114.424 |      2437.314 | 2433.633 | 2502.383 | 2685.829 |
| YRoundToEvenBenchmark_Double | SumTraits        |       1679.275 |      2268.855 |      3240.163 | 3218.852 | 3270.041 | 3277.885 |
| YRoundToEvenBenchmark_Double | Sum128Base_Basic |                |               |       159.183 |  160.385 |  160.182 |  303.928 |
| YRoundToEvenBenchmark_Double | Sum128Base       |                |               |       160.183 |  159.592 |  159.490 | 1629.413 |
| YRoundToEvenBenchmark_Double | Sum128Traits     |                |               |       160.246 |  159.678 |  157.967 | 1637.832 |
| YRoundToEvenBenchmark_Double | Sum256Base_Basic |                |               |       536.096 |  532.710 |  527.854 |  533.435 |
| YRoundToEvenBenchmark_Double | Sum256Base       |                |               |       535.061 |  533.424 |  527.435 | 2402.729 |
| YRoundToEvenBenchmark_Double | Sum256Traits     |                |               |      3021.949 | 3260.332 | 3164.546 | 3174.272 |
| YRoundToEvenBenchmark_Single | SumScalar        |         97.696 |       280.178 |       256.393 |  280.473 |  278.507 |  281.209 |
| YRoundToEvenBenchmark_Single | SumBase          |       3575.034 |      4903.248 |      3340.615 | 6001.979 | 5619.719 | 4706.556 |
| YRoundToEvenBenchmark_Single | SumBase_Add      |       3395.510 |      4626.075 |      3577.963 | 5492.692 | 5767.035 | 4944.285 |
| YRoundToEvenBenchmark_Single | SumTraits        |       3459.458 |      4694.986 |      5016.138 | 6670.229 | 6562.255 | 6578.304 |
| YRoundToEvenBenchmark_Single | Sum128Base_Basic |                |               |       249.989 |  292.237 |  290.980 |  558.589 |
| YRoundToEvenBenchmark_Single | Sum128Base       |                |               |       251.503 |  292.193 |  291.078 | 3260.002 |
| YRoundToEvenBenchmark_Single | Sum128Traits     |                |               |       258.679 |  292.224 |  290.850 | 3275.313 |
| YRoundToEvenBenchmark_Single | Sum256Base_Basic |                |               |       754.655 |  886.529 |  883.891 |  927.219 |
| YRoundToEvenBenchmark_Single | Sum256Base       |                |               |       739.320 |  886.503 |  881.932 | 5541.105 |
| YRoundToEvenBenchmark_Single | Sum256Traits     |                |               |      5534.097 | 6673.066 | 6635.209 | 6685.203 |
| YRoundToZeroBenchmark_Double | SumScalar        |        175.610 |       203.729 |       179.153 |  198.012 |  203.052 |  280.596 |
| YRoundToZeroBenchmark_Double | SumBase          |       1045.910 |      1146.221 |      1078.904 | 2896.409 | 2724.860 | 2927.350 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit |       1097.045 |      1138.236 |      1147.513 | 1426.923 | 1247.482 | 1432.600 |
| YRoundToZeroBenchmark_Double | SumTraits        |       1068.271 |      1142.532 |      3118.403 | 3227.738 | 3128.780 | 3277.488 |
| YRoundToZeroBenchmark_Double | Sum128Base_Basic |                |               |       108.465 |  109.230 |  108.200 |  303.230 |
| YRoundToZeroBenchmark_Double | Sum128Base       |                |               |       109.257 |  109.277 |   86.996 | 1624.883 |
| YRoundToZeroBenchmark_Double | Sum128Traits     |                |               |       108.742 |  109.721 |  108.077 | 1631.813 |
| YRoundToZeroBenchmark_Double | Sum256Base_Basic |                |               |       174.823 |  187.560 |  188.084 |  534.561 |
| YRoundToZeroBenchmark_Double | Sum256Base       |                |               |       188.918 |  188.356 |  190.801 | 2883.971 |
| YRoundToZeroBenchmark_Double | Sum256Traits     |                |               |      3263.052 | 3269.905 | 3254.357 | 3301.851 |
| YRoundToZeroBenchmark_Single | SumScalar        |        124.792 |       184.547 |       175.887 |  195.134 |  114.083 |  281.223 |
| YRoundToZeroBenchmark_Single | SumBase          |       2144.230 |      2121.917 |      2125.035 | 6091.413 | 5777.511 | 5918.672 |
| YRoundToZeroBenchmark_Single | SumBase_ClearBit |       2096.284 |      2308.252 |      2131.651 | 2853.757 | 2639.250 | 2666.170 |
| YRoundToZeroBenchmark_Single | SumTraits        |       2150.368 |      2169.330 |      6385.146 | 6619.175 | 6645.737 | 6680.642 |
| YRoundToZeroBenchmark_Single | Sum128Base_Basic |                |               |       151.888 |  116.174 |  156.022 |  559.897 |
| YRoundToZeroBenchmark_Single | Sum128Base       |                |               |       155.765 |  121.779 |  155.106 | 3109.943 |
| YRoundToZeroBenchmark_Single | Sum128Traits     |                |               |       146.645 |  151.144 |  157.506 | 3107.787 |
| YRoundToZeroBenchmark_Single | Sum256Base_Basic |                |               |       192.674 |  178.909 |  196.682 |  927.971 |
| YRoundToZeroBenchmark_Single | Sum256Base       |                |               |       191.412 |  140.563 |  196.095 | 5723.801 |
| YRoundToZeroBenchmark_Single | Sum256Traits     |                |               |      6508.660 | 6581.566 | 6582.179 | 6406.911 |

### Arm - AWS Arm t4g.small
| Class                        | Method           | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 |
| :--------------------------- | :--------------- | ------------: | -------: | -------: | -------: |
| CeilingBenchmark_Double      | SumScalar        |       830.483 |  902.454 |  899.267 | 1242.191 |
| CeilingBenchmark_Double      | SumBcl           |               | 1966.868 | 1963.219 | 2470.381 |
| CeilingBenchmark_Double      | SumBase          |       184.274 | 1966.857 | 2087.232 | 2446.300 |
| CeilingBenchmark_Double      | SumBase_Basic    |       478.038 |  469.097 |  473.018 |  478.187 |
| CeilingBenchmark_Double      | SumBase_ClearBit |       184.249 |  233.059 |  263.116 |  288.106 |
| CeilingBenchmark_Double      | SumTraits        |       184.250 | 2058.305 | 1963.663 | 2459.086 |
| CeilingBenchmark_Double      | Sum128Bcl        |               |          |          | 2465.481 |
| CeilingBenchmark_Double      | Sum128Base_Basic |       228.748 |  464.878 |  468.963 |  472.798 |
| CeilingBenchmark_Double      | Sum128Base       |       229.143 |  461.165 |  471.692 | 2466.948 |
| CeilingBenchmark_Double      | Sum128Traits     |       228.670 | 1966.302 | 2092.432 | 2465.501 |
| CeilingBenchmark_Double      | Sum256Bcl        |               |          |          |  270.024 |
| CeilingBenchmark_Double      | Sum256Base_Basic |       156.128 |  240.246 |  241.889 |  227.432 |
| CeilingBenchmark_Double      | Sum256Base       |       155.706 |  241.922 |  244.154 |  227.869 |
| CeilingBenchmark_Double      | Sum256Traits     |       155.934 |  241.124 |  243.982 |  227.952 |
| CeilingBenchmark_Single      | SumScalar        |       828.043 |  816.207 |  826.310 | 1242.842 |
| CeilingBenchmark_Single      | SumBcl           |               | 4122.234 | 4150.914 | 4748.790 |
| CeilingBenchmark_Single      | SumBase          |       374.088 | 4115.931 | 3904.425 | 4755.363 |
| CeilingBenchmark_Single      | SumBase_Basic    |       328.976 |  323.605 |  327.713 |  327.183 |
| CeilingBenchmark_Single      | SumBase_ClearBit |       374.138 |  506.597 |  523.525 |  567.023 |
| CeilingBenchmark_Single      | SumTraits        |       373.977 | 4122.810 | 3908.070 | 4742.703 |
| CeilingBenchmark_Single      | Sum128Bcl        |               |          |          | 4749.266 |
| CeilingBenchmark_Single      | Sum128Base_Basic |       179.459 |  311.248 |  314.068 |  325.439 |
| CeilingBenchmark_Single      | Sum128Base       |       179.521 |  312.438 |  314.755 | 4750.335 |
| CeilingBenchmark_Single      | Sum128Traits     |       179.520 | 3872.441 | 4162.712 | 4748.201 |
| CeilingBenchmark_Single      | Sum256Bcl        |               |          |          |  292.174 |
| CeilingBenchmark_Single      | Sum256Base_Basic |       215.618 |  293.898 |  294.995 |  258.877 |
| CeilingBenchmark_Single      | Sum256Base       |       212.583 |  282.309 |  286.791 |  279.930 |
| CeilingBenchmark_Single      | Sum256Traits     |       212.489 |  281.362 |  286.517 |  279.626 |
| FloorBenchmark_Double        | SumScalar        |       902.707 |  809.794 |  900.887 | 1244.460 |
| FloorBenchmark_Double        | SumBcl           |               | 1945.206 | 1965.948 | 2469.708 |
| FloorBenchmark_Double        | SumBase          |       183.819 | 1938.282 | 2097.391 | 2466.293 |
| FloorBenchmark_Double        | SumBase_Basic    |       476.014 |  465.893 |  475.628 |  478.190 |
| FloorBenchmark_Double        | SumBase_ClearBit |       184.274 |  234.020 |  264.078 |  285.952 |
| FloorBenchmark_Double        | SumTraits        |       183.963 | 1947.045 | 2097.222 | 2465.022 |
| FloorBenchmark_Double        | Sum128Bcl        |               |          |          | 2466.984 |
| FloorBenchmark_Double        | Sum128Base_Basic |       230.414 |  462.699 |  469.979 |  471.829 |
| FloorBenchmark_Double        | Sum128Base       |       228.707 |  464.115 |  468.980 | 2470.412 |
| FloorBenchmark_Double        | Sum128Traits     |       226.377 | 2070.950 | 1966.140 | 2468.927 |
| FloorBenchmark_Double        | Sum256Bcl        |               |          |          |  270.497 |
| FloorBenchmark_Double        | Sum256Base_Basic |       155.603 |  240.882 |  241.974 |  227.838 |
| FloorBenchmark_Double        | Sum256Base       |       155.057 |  239.926 |  245.993 |  228.041 |
| FloorBenchmark_Double        | Sum256Traits     |       154.981 |  239.123 |  244.767 |  227.907 |
| FloorBenchmark_Single        | SumScalar        |       901.596 |  886.392 |  827.284 | 1242.831 |
| FloorBenchmark_Single        | SumBcl           |               | 3840.158 | 3925.353 | 4743.879 |
| FloorBenchmark_Single        | SumBase          |       369.930 | 3861.680 | 4177.225 | 4754.015 |
| FloorBenchmark_Single        | SumBase_Basic    |       328.853 |  323.403 |  328.375 |  327.141 |
| FloorBenchmark_Single        | SumBase_ClearBit |       369.638 |  504.243 |  524.734 |  563.022 |
| FloorBenchmark_Single        | SumTraits        |       373.893 | 4083.758 | 4184.139 | 4752.299 |
| FloorBenchmark_Single        | Sum128Bcl        |               |          |          | 4760.494 |
| FloorBenchmark_Single        | Sum128Base_Basic |       179.564 |  310.484 |  314.328 |  325.323 |
| FloorBenchmark_Single        | Sum128Base       |       179.469 |  309.605 |  314.849 | 4758.814 |
| FloorBenchmark_Single        | Sum128Traits     |       179.466 | 3849.560 | 3920.771 | 4728.010 |
| FloorBenchmark_Single        | Sum256Bcl        |               |          |          |  290.496 |
| FloorBenchmark_Single        | Sum256Base_Basic |       212.114 |  291.749 |  293.417 |  259.691 |
| FloorBenchmark_Single        | Sum256Base       |       210.793 |  282.464 |  285.978 |  280.123 |
| FloorBenchmark_Single        | Sum256Traits     |       210.955 |  282.187 |  285.638 |  279.860 |
| YRoundToEvenBenchmark_Double | SumScalar        |       902.076 |  816.628 |  828.869 | 1244.328 |
| YRoundToEvenBenchmark_Double | SumBase          |       716.501 |  712.022 |  749.285 |  626.675 |
| YRoundToEvenBenchmark_Double | SumBase_Add      |       723.162 |  711.908 |  748.736 |  625.434 |
| YRoundToEvenBenchmark_Double | SumTraits        |       713.569 | 1947.359 | 2094.944 | 2469.649 |
| YRoundToEvenBenchmark_Double | Sum128Base_Basic |       226.094 |  461.883 |  468.516 |  475.047 |
| YRoundToEvenBenchmark_Double | Sum128Base       |       227.658 |  462.583 |  462.345 | 1028.375 |
| YRoundToEvenBenchmark_Double | Sum128Traits     |       226.155 | 2063.281 | 1966.932 | 2468.619 |
| YRoundToEvenBenchmark_Double | Sum256Base_Basic |       154.979 |  238.933 |  244.498 |  227.858 |
| YRoundToEvenBenchmark_Double | Sum256Base       |       152.140 |  240.457 |  245.601 |   46.455 |
| YRoundToEvenBenchmark_Double | Sum256Traits     |       154.995 |  240.753 |  245.626 |   46.459 |
| YRoundToEvenBenchmark_Single | SumScalar        |       829.401 |  812.341 |  828.627 | 1242.864 |
| YRoundToEvenBenchmark_Single | SumBase          |      1476.531 | 1459.116 | 1237.103 | 1531.870 |
| YRoundToEvenBenchmark_Single | SumBase_Add      |      1474.446 | 1449.779 | 1236.719 | 1531.396 |
| YRoundToEvenBenchmark_Single | SumTraits        |      1469.371 | 4109.915 | 3923.378 | 4742.209 |
| YRoundToEvenBenchmark_Single | Sum128Base_Basic |       179.309 |  309.320 |  314.704 |  325.286 |
| YRoundToEvenBenchmark_Single | Sum128Base       |       179.480 |  311.594 |  314.217 | 1855.223 |
| YRoundToEvenBenchmark_Single | Sum128Traits     |       179.417 | 3817.289 | 4182.934 | 4747.328 |
| YRoundToEvenBenchmark_Single | Sum256Base_Basic |       214.840 |  292.970 |  295.453 |  259.679 |
| YRoundToEvenBenchmark_Single | Sum256Base       |       211.680 |  282.248 |  287.233 |   63.951 |
| YRoundToEvenBenchmark_Single | Sum256Traits     |       211.628 |  282.652 |  287.147 |   63.954 |
| YRoundToZeroBenchmark_Double | SumScalar        |       152.452 |  132.345 |  162.000 | 1243.098 |
| YRoundToZeroBenchmark_Double | SumBase          |       241.207 | 1007.658 | 1095.817 |  964.497 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit |       241.374 |  304.793 |  351.688 |  378.250 |
| YRoundToZeroBenchmark_Double | SumTraits        |       241.165 | 2054.172 | 1965.803 | 2461.529 |
| YRoundToZeroBenchmark_Double | Sum128Base_Basic |       117.914 |  125.650 |  156.219 |  469.087 |
| YRoundToZeroBenchmark_Double | Sum128Base       |       119.354 |  126.073 |  153.217 | 1612.878 |
| YRoundToZeroBenchmark_Double | Sum128Traits     |       118.349 | 1927.611 | 2095.441 | 2461.480 |
| YRoundToZeroBenchmark_Double | Sum256Base_Basic |        82.388 |  103.477 |  122.873 |  226.840 |
| YRoundToZeroBenchmark_Double | Sum256Base       |        82.461 |  103.900 |  124.422 |   81.608 |
| YRoundToZeroBenchmark_Double | Sum256Traits     |        81.393 |  104.249 |  122.729 |   81.669 |
| YRoundToZeroBenchmark_Single | SumScalar        |       149.759 |  136.802 |  158.617 | 1242.615 |
| YRoundToZeroBenchmark_Single | SumBase          |       484.775 | 2132.416 | 1817.457 | 2290.790 |
| YRoundToZeroBenchmark_Single | SumBase_ClearBit |       483.265 |  664.670 |  690.569 |  747.479 |
| YRoundToZeroBenchmark_Single | SumTraits        |       484.155 | 3855.517 | 4179.016 | 4759.306 |
| YRoundToZeroBenchmark_Single | Sum128Base_Basic |       111.878 |  122.827 |  150.703 |  325.279 |
| YRoundToZeroBenchmark_Single | Sum128Base       |       113.235 |  123.282 |  154.620 | 2788.983 |
| YRoundToZeroBenchmark_Single | Sum128Traits     |       110.891 | 4076.856 | 3923.523 | 4753.799 |
| YRoundToZeroBenchmark_Single | Sum256Base_Basic |        95.614 |  104.268 |  116.806 |  259.731 |
| YRoundToZeroBenchmark_Single | Sum256Base       |        97.809 |  107.279 |  119.558 |  116.504 |
| YRoundToZeroBenchmark_Single | Sum256Traits     |        97.035 |  106.220 |  120.045 |  116.834 |
