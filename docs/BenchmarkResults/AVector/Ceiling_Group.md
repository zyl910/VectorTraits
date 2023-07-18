# Benchmark group - Ceiling
([← Back](Ceiling.md))

Cell unit: Mega/Second .

### x86 - lntel Core i5-8250U
| Class                        | Name             | .NET Framework | .NET Core 2.1 | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 |
| :--------------------------- | :--------------- | -------------: | ------------: | ------------: | -------: | -------: | -------: |
| CeilingBenchmark_Double      | SumScalar        |        437.939 |       280.180 |       281.144 |  279.588 |  281.146 |  281.364 |
| CeilingBenchmark_Double      | SumBcl           |                |               |               | 3289.712 | 3301.517 | 3287.800 |
| CeilingBenchmark_Double      | SumBase          |        804.388 |       872.525 |       992.537 | 3276.145 | 3285.490 | 3307.220 |
| CeilingBenchmark_Double      | SumBase_Basic    |        278.139 |       494.053 |       472.256 |  471.133 |  493.012 |  496.503 |
| CeilingBenchmark_Double      | SumBase_ClearBit |        780.829 |       879.979 |       998.340 |  958.203 |  960.230 | 1017.418 |
| CeilingBenchmark_Double      | SumTraits        |        797.715 |       825.893 |      3295.319 | 3207.040 | 3293.961 | 3295.596 |
| CeilingBenchmark_Double      | Sum128Bcl        |                |               |               |          |          | 1671.901 |
| CeilingBenchmark_Double      | Sum128Base_Basic |                |               |       159.756 |  159.090 |  159.843 |  304.743 |
| CeilingBenchmark_Double      | Sum128Base       |                |               |       159.828 |  158.253 |  160.134 | 1665.053 |
| CeilingBenchmark_Double      | Sum128Traits     |                |               |       159.477 |  159.844 |  160.296 | 1664.226 |
| CeilingBenchmark_Double      | Sum256Bcl        |                |               |               |          |          | 3315.633 |
| CeilingBenchmark_Double      | Sum256Base_Basic |                |               |       471.629 |  471.432 |  535.541 |  536.525 |
| CeilingBenchmark_Double      | Sum256Base       |                |               |       470.911 |  470.654 |  535.895 | 3292.627 |
| CeilingBenchmark_Double      | Sum256Traits     |                |               |      3305.209 | 3282.712 | 3294.343 | 3309.726 |
| CeilingBenchmark_Single      | SumScalar        |        197.958 |       280.561 |       281.361 |  281.563 |  281.501 |  281.427 |
| CeilingBenchmark_Single      | SumBcl           |                |               |               | 6691.519 | 6698.463 | 6680.405 |
| CeilingBenchmark_Single      | SumBase          |       1684.154 |      1702.663 |      1909.194 | 6688.844 | 6689.306 | 6699.316 |
| CeilingBenchmark_Single      | SumBase_Basic    |        232.220 |       457.556 |       768.427 |  769.074 |  792.202 |  791.327 |
| CeilingBenchmark_Single      | SumBase_ClearBit |       1751.047 |      1719.629 |      1965.028 | 2112.089 | 1925.987 | 2126.830 |
| CeilingBenchmark_Single      | SumTraits        |       1722.629 |      1700.433 |      6671.193 | 6696.696 | 6687.351 | 6686.259 |
| CeilingBenchmark_Single      | Sum128Bcl        |                |               |               |          |          | 3358.148 |
| CeilingBenchmark_Single      | Sum128Base_Basic |                |               |       290.928 |  291.447 |  291.339 |  559.918 |
| CeilingBenchmark_Single      | Sum128Base       |                |               |       291.023 |  291.682 |  292.301 | 3355.967 |
| CeilingBenchmark_Single      | Sum128Traits     |                |               |       291.350 |  290.721 |  292.045 | 3359.063 |
| CeilingBenchmark_Single      | Sum256Bcl        |                |               |               |          |          | 6679.058 |
| CeilingBenchmark_Single      | Sum256Base_Basic |                |               |       827.536 |  826.861 |  887.241 |  928.048 |
| CeilingBenchmark_Single      | Sum256Base       |                |               |       826.416 |  827.523 |  887.655 | 6697.418 |
| CeilingBenchmark_Single      | Sum256Traits     |                |               |      6637.068 | 6687.254 | 6701.204 | 6680.005 |
| FloorBenchmark_Double        | SumScalar        |        443.138 |       281.139 |       279.290 |  281.405 |  280.530 |  280.623 |
| FloorBenchmark_Double        | SumBcl           |                |               |               | 3291.213 | 3293.192 | 3279.289 |
| FloorBenchmark_Double        | SumBase          |        826.431 |       877.140 |       960.275 | 3287.118 | 3303.933 | 3300.129 |
| FloorBenchmark_Double        | SumBase_Basic    |        287.524 |       495.671 |       466.471 |  470.693 |  495.110 |  497.483 |
| FloorBenchmark_Double        | SumBase_ClearBit |        786.011 |       858.694 |       939.722 |  993.987 |  992.121 | 1027.363 |
| FloorBenchmark_Double        | SumTraits        |        824.201 |       856.841 |      3261.445 | 3293.035 | 3298.291 | 3300.964 |
| FloorBenchmark_Double        | Sum128Bcl        |                |               |               |          |          | 1667.106 |
| FloorBenchmark_Double        | Sum128Base_Basic |                |               |       160.203 |  160.032 |  160.031 |  304.310 |
| FloorBenchmark_Double        | Sum128Base       |                |               |       160.012 |  160.217 |  160.450 | 1665.976 |
| FloorBenchmark_Double        | Sum128Traits     |                |               |       160.218 |  159.999 |  160.411 | 1661.219 |
| FloorBenchmark_Double        | Sum256Bcl        |                |               |               |          |          | 3292.033 |
| FloorBenchmark_Double        | Sum256Base_Basic |                |               |       468.468 |  534.124 |  536.321 |  534.396 |
| FloorBenchmark_Double        | Sum256Base       |                |               |       469.726 |  535.955 |  536.376 | 3290.876 |
| FloorBenchmark_Double        | Sum256Traits     |                |               |      3294.906 | 3285.360 | 2771.722 | 3291.712 |
| FloorBenchmark_Single        | SumScalar        |        196.138 |       281.396 |       279.364 |  281.359 |  280.991 |  280.554 |
| FloorBenchmark_Single        | SumBcl           |                |               |               | 6689.540 | 6660.253 | 6651.523 |
| FloorBenchmark_Single        | SumBase          |       1691.467 |      1621.927 |      1867.738 | 6686.146 | 6683.574 | 6680.844 |
| FloorBenchmark_Single        | SumBase_Basic    |        232.245 |       458.638 |       760.528 |  792.094 |  791.103 |  791.759 |
| FloorBenchmark_Single        | SumBase_ClearBit |       1695.511 |      1698.255 |      1908.725 | 2032.370 | 1911.588 | 2070.119 |
| FloorBenchmark_Single        | SumTraits        |       1696.407 |      1666.442 |      6580.292 | 6679.933 | 6692.609 | 6673.188 |
| FloorBenchmark_Single        | Sum128Bcl        |                |               |               |          |          | 3355.766 |
| FloorBenchmark_Single        | Sum128Base_Basic |                |               |       291.584 |  292.555 |  292.225 |  560.880 |
| FloorBenchmark_Single        | Sum128Base       |                |               |       291.113 |  292.362 |  292.621 | 3351.509 |
| FloorBenchmark_Single        | Sum128Traits     |                |               |       291.036 |  291.942 |  291.861 | 3355.589 |
| FloorBenchmark_Single        | Sum256Bcl        |                |               |               |          |          | 6680.575 |
| FloorBenchmark_Single        | Sum256Base_Basic |                |               |       827.442 |  886.245 |  883.861 |  924.980 |
| FloorBenchmark_Single        | Sum256Base       |                |               |       827.932 |  886.201 |  884.013 | 6650.341 |
| FloorBenchmark_Single        | Sum256Traits     |                |               |      6682.975 | 6696.712 | 6680.481 | 6669.260 |
| YRoundToZeroBenchmark_Double | SumScalar        |        200.777 |       210.743 |       210.840 |  197.851 |  212.388 |  280.374 |
| YRoundToZeroBenchmark_Double | SumBase          |       1111.654 |      1155.338 |      1228.374 | 2841.603 | 2872.700 | 2932.162 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit |       1164.366 |      1147.880 |      1222.171 | 1433.636 | 1296.045 | 1393.118 |
| YRoundToZeroBenchmark_Double | SumTraits        |       1101.971 |      1198.220 |      3294.685 | 3283.265 | 3287.638 | 3297.377 |
| YRoundToZeroBenchmark_Double | Sum128Base_Basic |                |               |       109.634 |  109.904 |  108.930 |  304.205 |
| YRoundToZeroBenchmark_Double | Sum128Base       |                |               |       109.893 |  109.945 |  108.972 | 1632.410 |
| YRoundToZeroBenchmark_Double | Sum128Traits     |                |               |       109.418 |  109.834 |  108.956 | 1604.875 |
| YRoundToZeroBenchmark_Double | Sum256Base_Basic |                |               |       143.992 |  185.812 |  193.847 |  534.146 |
| YRoundToZeroBenchmark_Double | Sum256Base       |                |               |       180.548 |  186.286 |  193.988 | 2977.960 |
| YRoundToZeroBenchmark_Double | Sum256Traits     |                |               |      3288.951 | 3293.474 | 3282.308 | 3290.178 |
| YRoundToZeroBenchmark_Single | SumScalar        |        125.694 |       184.485 |       101.269 |  193.453 |  194.684 |  280.722 |
| YRoundToZeroBenchmark_Single | SumBase          |       2284.089 |      2222.551 |      2211.336 | 5802.904 | 6078.189 | 5711.620 |
| YRoundToZeroBenchmark_Single | SumBase_ClearBit |       2285.460 |      2312.626 |      2333.298 | 2789.575 | 2651.799 | 2755.455 |
| YRoundToZeroBenchmark_Single | SumTraits        |       2248.297 |      2312.180 |      5920.732 | 6681.026 | 6694.338 | 6663.835 |
| YRoundToZeroBenchmark_Single | Sum128Base_Basic |                |               |       133.275 |  159.592 |  156.043 |  559.374 |
| YRoundToZeroBenchmark_Single | Sum128Base       |                |               |       145.830 |  159.524 |  158.008 | 3107.297 |
| YRoundToZeroBenchmark_Single | Sum128Traits     |                |               |       146.489 |  158.672 |  158.282 | 3105.241 |
| YRoundToZeroBenchmark_Single | Sum256Base_Basic |                |               |       145.828 |  191.032 |  196.847 |  924.946 |
| YRoundToZeroBenchmark_Single | Sum256Base       |                |               |       183.500 |  199.015 |  198.513 | 5802.350 |
| YRoundToZeroBenchmark_Single | Sum256Traits     |                |               |      6547.546 | 6689.535 | 6670.954 | 6689.334 |

### Arm - AWS Arm t4g.small
| Class                        | Name             | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 |
| :--------------------------- | :--------------- | ------------: | -------: | -------: | -------: |
| CeilingBenchmark_Double      | SumScalar        |       828.100 |  830.514 |  903.374 | 1244.705 |
| CeilingBenchmark_Double      | SumBcl           |               | 2096.545 | 2097.457 | 2464.238 |
| CeilingBenchmark_Double      | SumBase          |       184.246 | 2097.721 | 2098.344 | 2465.448 |
| CeilingBenchmark_Double      | SumBase_Basic    |       478.508 |  474.279 |  473.486 |  478.259 |
| CeilingBenchmark_Double      | SumBase_ClearBit |       184.343 |  251.370 |  267.877 |  289.031 |
| CeilingBenchmark_Double      | SumTraits        |       183.984 | 1970.491 | 1969.844 | 2467.795 |
| CeilingBenchmark_Double      | Sum128Bcl        |               |          |          | 2466.476 |
| CeilingBenchmark_Double      | Sum128Base_Basic |       226.453 |  470.165 |  470.308 |  469.231 |
| CeilingBenchmark_Double      | Sum128Base       |       228.857 |  470.212 |  470.072 | 2463.438 |
| CeilingBenchmark_Double      | Sum128Traits     |       228.661 | 2095.889 | 1968.689 | 2468.561 |
| CeilingBenchmark_Double      | Sum256Bcl        |               |          |          |  270.455 |
| CeilingBenchmark_Double      | Sum256Base_Basic |       156.981 |  243.774 |  242.581 |  226.492 |
| CeilingBenchmark_Double      | Sum256Base       |       156.357 |  242.968 |  245.041 |  227.956 |
| CeilingBenchmark_Double      | Sum256Traits     |       156.603 |  243.828 |  243.593 |  228.088 |
| CeilingBenchmark_Single      | SumScalar        |       827.440 |  829.751 |  827.815 | 1240.703 |
| CeilingBenchmark_Single      | SumBcl           |               | 4192.084 | 3926.627 | 4698.575 |
| CeilingBenchmark_Single      | SumBase          |       367.365 | 4195.967 | 3925.402 | 4692.873 |
| CeilingBenchmark_Single      | SumBase_Basic    |       324.878 |  328.655 |  328.631 |  326.954 |
| CeilingBenchmark_Single      | SumBase_ClearBit |       366.619 |  510.246 |  534.763 |  566.344 |
| CeilingBenchmark_Single      | SumTraits        |       369.692 | 4196.249 | 4179.371 | 4684.572 |
| CeilingBenchmark_Single      | Sum128Bcl        |               |          |          | 4678.098 |
| CeilingBenchmark_Single      | Sum128Base_Basic |       179.526 |  314.589 |  314.884 |  325.362 |
| CeilingBenchmark_Single      | Sum128Base       |       179.626 |  315.113 |  315.054 | 4686.424 |
| CeilingBenchmark_Single      | Sum128Traits     |       179.640 | 3938.743 | 4178.057 | 4689.050 |
| CeilingBenchmark_Single      | Sum256Bcl        |               |          |          |  291.221 |
| CeilingBenchmark_Single      | Sum256Base_Basic |       211.527 |  297.121 |  296.826 |  258.819 |
| CeilingBenchmark_Single      | Sum256Base       |       209.696 |  286.579 |  287.592 |  279.373 |
| CeilingBenchmark_Single      | Sum256Traits     |       210.297 |  286.980 |  286.911 |  279.383 |
| FloorBenchmark_Double        | SumScalar        |       902.345 |  829.996 |  829.232 | 1244.614 |
| FloorBenchmark_Double        | SumBcl           |               | 1968.259 | 1970.341 | 2468.407 |
| FloorBenchmark_Double        | SumBase          |       184.102 | 1968.078 | 1968.485 | 2466.719 |
| FloorBenchmark_Double        | SumBase_Basic    |       476.997 |  475.684 |  476.398 |  478.584 |
| FloorBenchmark_Double        | SumBase_ClearBit |       184.344 |  251.221 |  267.566 |  286.184 |
| FloorBenchmark_Double        | SumTraits        |       184.287 | 1966.567 | 2098.074 | 2467.687 |
| FloorBenchmark_Double        | Sum128Bcl        |               |          |          | 2456.614 |
| FloorBenchmark_Double        | Sum128Base_Basic |       228.767 |  469.476 |  469.661 |  469.377 |
| FloorBenchmark_Double        | Sum128Base       |       227.718 |  471.295 |  468.689 | 2468.281 |
| FloorBenchmark_Double        | Sum128Traits     |       228.679 | 2098.923 | 2096.197 | 2467.132 |
| FloorBenchmark_Double        | Sum256Bcl        |               |          |          |  270.721 |
| FloorBenchmark_Double        | Sum256Base_Basic |       156.629 |  244.267 |  244.185 |  227.352 |
| FloorBenchmark_Double        | Sum256Base       |       156.588 |  243.238 |  244.331 |  228.260 |
| FloorBenchmark_Double        | Sum256Traits     |       156.473 |  243.494 |  244.941 |  228.108 |
| FloorBenchmark_Single        | SumScalar        |       826.722 |  903.088 |  829.386 | 1240.114 |
| FloorBenchmark_Single        | SumBcl           |               | 3934.303 | 4181.067 | 4687.638 |
| FloorBenchmark_Single        | SumBase          |       373.940 | 3931.837 | 4178.182 | 4680.215 |
| FloorBenchmark_Single        | SumBase_Basic    |       329.199 |  327.647 |  327.956 |  327.981 |
| FloorBenchmark_Single        | SumBase_ClearBit |       373.892 |  510.688 |  534.654 |  562.098 |
| FloorBenchmark_Single        | SumTraits        |       373.917 | 4195.644 | 3924.917 | 4686.158 |
| FloorBenchmark_Single        | Sum128Bcl        |               |          |          | 4697.283 |
| FloorBenchmark_Single        | Sum128Base_Basic |       179.476 |  315.126 |  314.595 |  326.396 |
| FloorBenchmark_Single        | Sum128Base       |       179.416 |  315.220 |  315.075 | 4693.506 |
| FloorBenchmark_Single        | Sum128Traits     |       179.399 | 3932.098 | 3931.356 | 4688.304 |
| FloorBenchmark_Single        | Sum256Bcl        |               |          |          |  291.466 |
| FloorBenchmark_Single        | Sum256Base_Basic |       214.456 |  296.841 |  297.342 |  259.849 |
| FloorBenchmark_Single        | Sum256Base       |       209.942 |  286.815 |  286.575 |  279.715 |
| FloorBenchmark_Single        | Sum256Traits     |       209.824 |  286.802 |  287.062 |  279.900 |
| YRoundToZeroBenchmark_Double | SumScalar        |       162.003 |  118.237 |  135.040 | 1244.527 |
| YRoundToZeroBenchmark_Double | SumBase          |       241.634 | 1035.983 | 1159.698 | 1205.522 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit |       241.372 |  335.248 |  333.865 |  379.327 |
| YRoundToZeroBenchmark_Double | SumTraits        |       240.155 | 2097.545 | 2094.686 | 2461.167 |
| YRoundToZeroBenchmark_Double | Sum128Base_Basic |       118.852 |  105.734 |  131.318 |  469.868 |
| YRoundToZeroBenchmark_Double | Sum128Base       |       119.171 |  109.518 |  129.811 | 1610.220 |
| YRoundToZeroBenchmark_Double | Sum128Traits     |       118.021 | 1968.228 | 2096.062 | 2467.942 |
| YRoundToZeroBenchmark_Double | Sum256Base_Basic |        83.034 |   90.234 |  105.957 |  228.130 |
| YRoundToZeroBenchmark_Double | Sum256Base       |        83.052 |   89.859 |  106.069 |   80.029 |
| YRoundToZeroBenchmark_Double | Sum256Traits     |        83.212 |   90.674 |  107.827 |   80.010 |
| YRoundToZeroBenchmark_Single | SumScalar        |       149.634 |  119.169 |  139.166 | 1241.188 |
| YRoundToZeroBenchmark_Single | SumBase          |       484.037 | 2198.234 | 1891.261 | 2325.131 |
| YRoundToZeroBenchmark_Single | SumBase_ClearBit |       483.131 |  675.552 |  701.072 |  749.207 |
| YRoundToZeroBenchmark_Single | SumTraits        |       484.590 | 3938.714 | 3920.092 | 4690.482 |
| YRoundToZeroBenchmark_Single | Sum128Base_Basic |       109.620 |  110.646 |  123.588 |  326.298 |
| YRoundToZeroBenchmark_Single | Sum128Base       |       113.002 |  111.079 |  124.975 | 2788.266 |
| YRoundToZeroBenchmark_Single | Sum128Traits     |       110.916 | 4197.405 | 3925.336 | 4696.331 |
| YRoundToZeroBenchmark_Single | Sum256Base_Basic |        96.178 |   94.491 |  105.102 |  259.763 |
| YRoundToZeroBenchmark_Single | Sum256Base       |        97.591 |   95.711 |  106.661 |  116.474 |
| YRoundToZeroBenchmark_Single | Sum256Traits     |        96.659 |   95.745 |  107.040 |  116.479 |
