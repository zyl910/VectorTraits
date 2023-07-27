# Benchmark group - Ceiling
([← Back](Ceiling.md))

Cell unit: Million operations per second.

### x86 - lntel Core i5-8250U
| Class                        | Method               | .NET Framework | .NET Core 2.1 | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 |
| :--------------------------- | :------------------- | -------------: | ------------: | ------------: | -------: | -------: | -------: |
| CeilingBenchmark_Double      | SumScalar            |        413.971 |       278.457 |       280.284 |  280.601 |  280.964 |  280.777 |
| CeilingBenchmark_Double      | SumBcl               |                |               |               | 3281.622 | 3287.961 | 3240.560 |
| CeilingBenchmark_Double      | SumBase              |       1068.796 |      1021.746 |      1176.384 | 3277.855 | 3273.154 | 3274.040 |
| CeilingBenchmark_Double      | SumBase_Basic        |        290.236 |       485.394 |       470.770 |  493.092 |  494.722 |  496.423 |
| CeilingBenchmark_Double      | SumBase_ClearBit     |       1092.937 |      1028.203 |      1194.381 | 1199.103 | 1144.015 | 1226.679 |
| CeilingBenchmark_Double      | SumTraits            |       1081.972 |      1055.954 |      3263.621 | 3084.991 | 3282.474 | 3286.972 |
| CeilingBenchmark_Double      | Sum128Bcl            |                |               |               |          |          | 1664.454 |
| CeilingBenchmark_Double      | Sum128Base_Basic     |                |               |       159.761 |  159.527 |  159.729 |  304.670 |
| CeilingBenchmark_Double      | Sum128Base           |                |               |       159.938 |  159.608 |  159.961 | 1656.383 |
| CeilingBenchmark_Double      | Sum128Traits         |                |               |       159.428 |  160.157 |  159.946 | 1657.037 |
| CeilingBenchmark_Double      | Sum256Bcl            |                |               |               |          |          | 3283.009 |
| CeilingBenchmark_Double      | Sum256Base_Basic     |                |               |       469.108 |  533.208 |  530.389 |  533.323 |
| CeilingBenchmark_Double      | Sum256Base           |                |               |       469.305 |  533.978 |  535.441 | 3280.381 |
| CeilingBenchmark_Double      | Sum256Traits         |                |               |      3267.449 | 3272.422 | 3277.204 | 3292.624 |
| CeilingBenchmark_Single      | SumScalar            |        197.880 |       280.889 |       280.309 |  280.615 |  281.148 |  280.955 |
| CeilingBenchmark_Single      | SumBcl               |                |               |               | 6640.910 | 6670.602 | 6684.630 |
| CeilingBenchmark_Single      | SumBase              |       2227.562 |      2163.609 |      2333.076 | 6670.143 | 6673.117 | 6635.149 |
| CeilingBenchmark_Single      | SumBase_Basic        |        231.461 |       459.213 |       764.802 |  791.277 |  790.570 |  767.269 |
| CeilingBenchmark_Single      | SumBase_ClearBit     |       2144.997 |      2071.455 |      2346.829 | 2395.691 | 2410.265 | 2446.564 |
| CeilingBenchmark_Single      | SumTraits            |       2125.438 |      2060.763 |      6665.307 | 6646.280 | 6692.145 | 6564.341 |
| CeilingBenchmark_Single      | Sum128Bcl            |                |               |               |          |          | 3313.678 |
| CeilingBenchmark_Single      | Sum128Base_Basic     |                |               |       290.955 |  290.856 |  291.434 |  554.815 |
| CeilingBenchmark_Single      | Sum128Base           |                |               |       290.392 |  291.446 |  290.683 | 3312.472 |
| CeilingBenchmark_Single      | Sum128Traits         |                |               |       290.026 |  290.252 |  291.281 | 3309.900 |
| CeilingBenchmark_Single      | Sum256Bcl            |                |               |               |          |          | 6667.508 |
| CeilingBenchmark_Single      | Sum256Base_Basic     |                |               |       824.779 |  885.020 |  886.387 |  825.813 |
| CeilingBenchmark_Single      | Sum256Base           |                |               |       826.396 |  883.882 |  885.615 | 6657.626 |
| CeilingBenchmark_Single      | Sum256Traits         |                |               |      6627.816 | 6661.724 | 6684.988 | 6659.892 |
| FloorBenchmark_Double        | SumScalar            |        444.951 |       280.954 |       280.673 |  280.389 |  280.139 |  280.791 |
| FloorBenchmark_Double        | SumBcl               |                |               |               | 3275.930 | 3249.855 | 3259.351 |
| FloorBenchmark_Double        | SumBase              |       1084.067 |      1075.671 |      1180.150 | 3265.015 | 3264.749 | 3267.249 |
| FloorBenchmark_Double        | SumBase_Basic        |        295.865 |       492.716 |       470.853 |  495.641 |  493.188 |  474.636 |
| FloorBenchmark_Double        | SumBase_ClearBit     |       1081.946 |      1092.668 |      1158.227 | 1180.281 | 1170.574 | 1207.012 |
| FloorBenchmark_Double        | SumTraits            |       1039.399 |      1078.670 |      3274.998 | 3273.062 | 3278.615 | 3267.643 |
| FloorBenchmark_Double        | Sum128Bcl            |                |               |               |          |          | 1661.483 |
| FloorBenchmark_Double        | Sum128Base_Basic     |                |               |       160.026 |  159.970 |  160.006 |  303.683 |
| FloorBenchmark_Double        | Sum128Base           |                |               |       159.893 |  160.010 |  159.965 | 1661.490 |
| FloorBenchmark_Double        | Sum128Traits         |                |               |       159.857 |  159.941 |  160.292 | 1652.894 |
| FloorBenchmark_Double        | Sum256Bcl            |                |               |               |          |          | 3275.423 |
| FloorBenchmark_Double        | Sum256Base_Basic     |                |               |       470.339 |  534.464 |  471.063 |  470.339 |
| FloorBenchmark_Double        | Sum256Base           |                |               |       470.589 |  534.503 |  470.546 | 3230.319 |
| FloorBenchmark_Double        | Sum256Traits         |                |               |      3289.060 | 3278.468 | 3283.135 | 3271.207 |
| FloorBenchmark_Single        | SumScalar            |        196.628 |       281.044 |       274.750 |  281.076 |  281.369 |  279.943 |
| FloorBenchmark_Single        | SumBcl               |                |               |               | 6682.069 | 6666.441 | 6578.901 |
| FloorBenchmark_Single        | SumBase              |       2235.514 |      2077.525 |      2229.120 | 6680.176 | 6661.500 | 6569.919 |
| FloorBenchmark_Single        | SumBase_Basic        |        234.457 |       459.453 |       764.149 |  789.656 |  767.726 |  756.751 |
| FloorBenchmark_Single        | SumBase_ClearBit     |       2166.219 |      2211.077 |      2284.696 | 2488.120 | 2408.842 | 2391.931 |
| FloorBenchmark_Single        | SumTraits            |       2097.777 |      2191.378 |      6077.675 | 6662.188 | 6662.742 | 6650.649 |
| FloorBenchmark_Single        | Sum128Bcl            |                |               |               |          |          | 3349.219 |
| FloorBenchmark_Single        | Sum128Base_Basic     |                |               |       288.760 |  291.481 |  291.212 |  559.764 |
| FloorBenchmark_Single        | Sum128Base           |                |               |       289.388 |  291.057 |  291.434 | 3351.471 |
| FloorBenchmark_Single        | Sum128Traits         |                |               |       290.538 |  290.360 |  291.349 | 3347.267 |
| FloorBenchmark_Single        | Sum256Bcl            |                |               |               |          |          | 6671.611 |
| FloorBenchmark_Single        | Sum256Base_Basic     |                |               |       826.688 |  885.707 |  827.215 |  827.878 |
| FloorBenchmark_Single        | Sum256Base           |                |               |       826.284 |  877.332 |  826.563 | 6663.161 |
| FloorBenchmark_Single        | Sum256Traits         |                |               |      6636.605 | 6573.129 | 6603.559 | 6667.120 |
| YRoundToEvenBenchmark_Double | SumScalar            |        122.334 |       280.770 |       280.987 |  278.659 |  278.973 |  280.275 |
| YRoundToEvenBenchmark_Double | SumBase              |       2128.025 |      2259.159 |      2647.406 | 2370.208 | 2523.018 | 2547.145 |
| YRoundToEvenBenchmark_Double | SumBase_Add          |       2178.238 |      1972.961 |      2437.753 | 2489.979 | 2489.266 | 2512.668 |
| YRoundToEvenBenchmark_Double | SumTraits            |       2073.669 |      2217.692 |      3287.023 | 3273.420 | 3264.435 | 3280.012 |
| YRoundToEvenBenchmark_Double | Sum128Base_Basic     |                |               |       159.785 |  159.627 |  160.087 |  304.232 |
| YRoundToEvenBenchmark_Double | Sum128Base           |                |               |       159.776 |  159.974 |  160.114 | 1631.964 |
| YRoundToEvenBenchmark_Double | Sum128Traits         |                |               |       159.041 |  159.410 |  160.264 | 1634.573 |
| YRoundToEvenBenchmark_Double | Sum256Base_Basic     |                |               |       467.553 |  534.635 |  471.095 |  470.467 |
| YRoundToEvenBenchmark_Double | Sum256Base           |                |               |       468.662 |  533.483 |  431.453 | 2525.098 |
| YRoundToEvenBenchmark_Double | Sum256Traits         |                |               |      3284.623 | 3272.761 | 2798.269 | 3264.343 |
| YRoundToEvenBenchmark_Single | SumScalar            |        112.755 |       280.985 |       277.969 |  281.062 |  224.887 |  281.261 |
| YRoundToEvenBenchmark_Single | SumBase              |       4430.932 |      4665.501 |      5029.993 | 5493.254 | 3808.650 | 5102.453 |
| YRoundToEvenBenchmark_Single | SumBase_Add          |       4056.907 |      4413.895 |      5004.617 | 5499.456 | 4225.448 | 4752.384 |
| YRoundToEvenBenchmark_Single | SumTraits            |       4314.404 |      4376.953 |      6548.433 | 6671.423 | 5482.529 | 6597.506 |
| YRoundToEvenBenchmark_Single | Sum128Base_Basic     |                |               |       287.666 |  291.082 |  259.418 |  561.324 |
| YRoundToEvenBenchmark_Single | Sum128Base           |                |               |       287.393 |  291.405 |  253.477 | 3138.839 |
| YRoundToEvenBenchmark_Single | Sum128Traits         |                |               |       287.542 |  291.031 |  262.211 | 3203.265 |
| YRoundToEvenBenchmark_Single | Sum256Base_Basic     |                |               |       814.524 |  885.952 |  723.424 |  826.875 |
| YRoundToEvenBenchmark_Single | Sum256Base           |                |               |       818.512 |  886.243 |  823.914 | 5201.888 |
| YRoundToEvenBenchmark_Single | Sum256Traits         |                |               |      6606.884 | 6675.537 | 6568.806 | 6682.193 |
| YRoundToZeroBenchmark_Double | SumScalar            |        181.809 |       101.684 |       215.532 |  211.592 |  215.463 |  280.423 |
| YRoundToZeroBenchmark_Double | SumBase              |       1594.218 |      1634.119 |      1759.115 | 2866.074 | 2701.802 | 2950.425 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit     |       1621.136 |      1527.294 |      1756.159 | 1669.318 | 1585.915 | 1765.514 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit_Not |       1588.665 |      1510.136 |      1882.307 | 1791.734 | 1736.790 | 1904.616 |
| YRoundToZeroBenchmark_Double | SumTraits            |       1601.310 |      1638.197 |      3028.367 | 3288.974 | 3112.789 | 3283.149 |
| YRoundToZeroBenchmark_Double | Sum128Base_Basic     |                |               |       106.892 |  109.727 |   84.572 |  302.597 |
| YRoundToZeroBenchmark_Double | Sum128Base           |                |               |       107.703 |  109.762 |   92.460 | 1536.364 |
| YRoundToZeroBenchmark_Double | Sum128Traits         |                |               |       107.476 |  109.229 |  109.643 | 1537.393 |
| YRoundToZeroBenchmark_Double | Sum256Base_Basic     |                |               |       190.471 |  194.325 |  185.933 |  468.307 |
| YRoundToZeroBenchmark_Double | Sum256Base           |                |               |       184.808 |  185.600 |  185.544 | 2875.587 |
| YRoundToZeroBenchmark_Double | Sum256Traits         |                |               |      3064.195 | 3266.645 | 3246.774 | 3294.249 |
| YRoundToZeroBenchmark_Single | SumScalar            |        124.416 |       179.762 |       228.645 |  198.005 |  207.381 |  280.887 |
| YRoundToZeroBenchmark_Single | SumBase              |       3176.600 |      3211.757 |      3224.626 | 5706.768 | 5878.066 | 5860.498 |
| YRoundToZeroBenchmark_Single | SumBase_ClearBit     |       3165.214 |      3226.662 |      3322.692 | 3462.184 | 3317.487 | 3562.933 |
| YRoundToZeroBenchmark_Single | SumTraits            |       3127.494 |      3225.926 |      6223.961 | 6642.112 | 6062.562 | 6598.576 |
| YRoundToZeroBenchmark_Single | Sum128Base_Basic     |                |               |       155.927 |   92.509 |   93.535 |  557.614 |
| YRoundToZeroBenchmark_Single | Sum128Base           |                |               |       155.167 |   91.812 |  132.293 | 3123.550 |
| YRoundToZeroBenchmark_Single | Sum128Traits         |                |               |       156.474 |  156.581 |  156.889 | 3122.297 |
| YRoundToZeroBenchmark_Single | Sum256Base_Basic     |                |               |       195.035 |  187.558 |  193.889 |  821.090 |
| YRoundToZeroBenchmark_Single | Sum256Base           |                |               |       189.130 |  188.927 |  193.926 | 5985.010 |
| YRoundToZeroBenchmark_Single | Sum256Traits         |                |               |      6645.544 | 6643.102 | 6670.264 | 6591.408 |

### Arm - AWS Arm t4g.small
| Class                        | Method               | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 |
| :--------------------------- | :------------------- | ------------: | -------: | -------: | -------: |
| CeilingBenchmark_Double      | SumScalar            |       902.145 |  830.155 |  829.321 | 1244.215 |
| CeilingBenchmark_Double      | SumBcl               |               | 2098.636 | 1967.725 | 2465.070 |
| CeilingBenchmark_Double      | SumBase              |       212.581 | 2099.741 | 2093.522 | 2465.979 |
| CeilingBenchmark_Double      | SumBase_Basic        |       479.081 |  476.044 |  476.381 |  478.169 |
| CeilingBenchmark_Double      | SumBase_ClearBit     |       258.810 |  297.462 |  317.966 |  359.449 |
| CeilingBenchmark_Double      | SumTraits            |       480.587 | 2096.185 | 2095.023 | 2452.616 |
| CeilingBenchmark_Double      | Sum128Bcl            |               |          |          | 2466.755 |
| CeilingBenchmark_Double      | Sum128Base_Basic     |       230.257 |  470.081 |  469.773 |  472.269 |
| CeilingBenchmark_Double      | Sum128Base           |       228.631 |  467.718 |  468.160 | 2463.874 |
| CeilingBenchmark_Double      | Sum128Traits         |       229.376 | 1957.363 | 1966.395 | 2468.621 |
| CeilingBenchmark_Double      | Sum256Bcl            |               |          |          |  270.600 |
| CeilingBenchmark_Double      | Sum256Base_Basic     |       143.329 |  213.688 |  214.412 |  226.814 |
| CeilingBenchmark_Double      | Sum256Base           |       143.587 |  214.062 |  214.703 |  227.967 |
| CeilingBenchmark_Double      | Sum256Traits         |       143.547 |  214.250 |  214.906 |  227.969 |
| CeilingBenchmark_Single      | SumScalar            |       827.413 |  903.463 |  826.685 | 1239.420 |
| CeilingBenchmark_Single      | SumBcl               |               | 4207.301 | 3902.126 | 4719.618 |
| CeilingBenchmark_Single      | SumBase              |       525.322 | 4201.099 | 4161.406 | 4714.777 |
| CeilingBenchmark_Single      | SumBase_Basic        |       328.679 |  329.048 |  328.505 |  327.245 |
| CeilingBenchmark_Single      | SumBase_ClearBit     |       525.837 |  606.811 |  632.898 |  681.125 |
| CeilingBenchmark_Single      | SumTraits            |       525.670 | 3939.507 | 3605.444 | 4721.042 |
| CeilingBenchmark_Single      | Sum128Bcl            |               |          |          | 4715.941 |
| CeilingBenchmark_Single      | Sum128Base_Basic     |       179.459 |  314.887 |  282.113 |  325.284 |
| CeilingBenchmark_Single      | Sum128Base           |       179.430 |  314.641 |  313.643 | 4717.625 |
| CeilingBenchmark_Single      | Sum128Traits         |       179.432 | 4195.048 | 4156.049 | 4716.239 |
| CeilingBenchmark_Single      | Sum256Bcl            |               |          |          |  290.744 |
| CeilingBenchmark_Single      | Sum256Base_Basic     |       203.459 |  273.694 |  273.305 |  259.752 |
| CeilingBenchmark_Single      | Sum256Base           |       199.717 |  264.448 |  263.762 |  279.949 |
| CeilingBenchmark_Single      | Sum256Traits         |       199.313 |  264.636 |  265.443 |  279.989 |
| FloorBenchmark_Double        | SumScalar            |       902.188 |  902.428 |  828.709 | 1244.412 |
| FloorBenchmark_Double        | SumBcl               |               | 2096.432 | 2093.284 | 2464.127 |
| FloorBenchmark_Double        | SumBase              |       479.813 | 2097.258 | 1964.997 | 2463.502 |
| FloorBenchmark_Double        | SumBase_Basic        |       479.351 |  476.513 |  474.809 |  478.253 |
| FloorBenchmark_Double        | SumBase_ClearBit     |       259.030 |  297.746 |  317.729 |  357.054 |
| FloorBenchmark_Double        | SumTraits            |       479.219 | 1969.887 | 1965.508 | 2467.170 |
| FloorBenchmark_Double        | Sum128Bcl            |               |          |          | 2464.247 |
| FloorBenchmark_Double        | Sum128Base_Basic     |       229.962 |  468.038 |  470.514 |  470.577 |
| FloorBenchmark_Double        | Sum128Base           |       228.156 |  469.293 |  469.585 | 2450.914 |
| FloorBenchmark_Double        | Sum128Traits         |       230.727 | 2085.981 | 2092.875 | 2462.675 |
| FloorBenchmark_Double        | Sum256Bcl            |               |          |          |  271.035 |
| FloorBenchmark_Double        | Sum256Base_Basic     |       143.576 |  212.707 |  213.936 |  226.462 |
| FloorBenchmark_Double        | Sum256Base           |       142.930 |  216.436 |  211.977 |  227.872 |
| FloorBenchmark_Double        | Sum256Traits         |       143.162 |  214.389 |  212.229 |  227.993 |
| FloorBenchmark_Single        | SumScalar            |       901.623 |  903.367 |  899.204 | 1240.762 |
| FloorBenchmark_Single        | SumBcl               |               | 3933.202 | 4168.508 | 4717.272 |
| FloorBenchmark_Single        | SumBase              |       525.795 | 3939.988 | 3898.864 | 4717.366 |
| FloorBenchmark_Single        | SumBase_Basic        |       328.460 |  327.691 |  328.059 |  326.865 |
| FloorBenchmark_Single        | SumBase_ClearBit     |       525.441 |  606.678 |  660.771 |  674.934 |
| FloorBenchmark_Single        | SumTraits            |       525.607 | 4197.987 | 4158.603 | 4708.653 |
| FloorBenchmark_Single        | Sum128Bcl            |               |          |          | 4708.891 |
| FloorBenchmark_Single        | Sum128Base_Basic     |       179.587 |  314.654 |  313.789 |  325.276 |
| FloorBenchmark_Single        | Sum128Base           |       179.480 |  315.097 |  314.517 | 4717.386 |
| FloorBenchmark_Single        | Sum128Traits         |       179.525 | 3938.614 | 3906.602 | 4725.838 |
| FloorBenchmark_Single        | Sum256Bcl            |               |          |          |  291.167 |
| FloorBenchmark_Single        | Sum256Base_Basic     |       204.040 |  273.647 |  272.815 |  258.758 |
| FloorBenchmark_Single        | Sum256Base           |       200.287 |  264.965 |  263.813 |  279.211 |
| FloorBenchmark_Single        | Sum256Traits         |       200.123 |  264.795 |  264.449 |  279.503 |
| YRoundToEvenBenchmark_Double | SumScalar            |       829.820 |  902.215 |  829.222 | 1244.318 |
| YRoundToEvenBenchmark_Double | SumBase              |       733.326 |  719.477 |  748.542 |  626.343 |
| YRoundToEvenBenchmark_Double | SumBase_Add          |       743.760 |  722.975 |  750.372 |  626.229 |
| YRoundToEvenBenchmark_Double | SumTraits            |       743.733 | 1968.485 | 2092.953 | 2465.034 |
| YRoundToEvenBenchmark_Double | Sum128Base_Basic     |       230.309 |  471.039 |  469.442 |  471.480 |
| YRoundToEvenBenchmark_Double | Sum128Base           |       227.528 |  471.757 |  466.739 | 1022.644 |
| YRoundToEvenBenchmark_Double | Sum128Traits         |       230.657 | 2097.891 | 1960.680 | 2464.956 |
| YRoundToEvenBenchmark_Double | Sum256Base_Basic     |       143.431 |  213.688 |  213.717 |  227.765 |
| YRoundToEvenBenchmark_Double | Sum256Base           |       143.468 |  215.072 |  214.232 |   49.748 |
| YRoundToEvenBenchmark_Double | Sum256Traits         |       142.207 |  214.412 |  213.144 |   49.748 |
| YRoundToEvenBenchmark_Single | SumScalar            |       901.633 |  903.018 |  827.404 | 1240.429 |
| YRoundToEvenBenchmark_Single | SumBase              |      1536.055 | 1473.166 | 1233.356 | 1527.630 |
| YRoundToEvenBenchmark_Single | SumBase_Add          |      1536.672 | 1459.131 | 1234.412 | 1528.189 |
| YRoundToEvenBenchmark_Single | SumTraits            |      1536.630 | 3938.283 | 3908.499 | 4717.182 |
| YRoundToEvenBenchmark_Single | Sum128Base_Basic     |       179.607 |  315.262 |  314.362 |  325.207 |
| YRoundToEvenBenchmark_Single | Sum128Base           |       179.521 |  314.651 |  313.956 | 1846.475 |
| YRoundToEvenBenchmark_Single | Sum128Traits         |       179.665 | 4196.736 | 4160.178 | 4709.683 |
| YRoundToEvenBenchmark_Single | Sum256Base_Basic     |       203.871 |  273.553 |  273.248 |  258.910 |
| YRoundToEvenBenchmark_Single | Sum256Base           |       200.258 |  264.847 |  264.136 |   65.909 |
| YRoundToEvenBenchmark_Single | Sum256Traits         |       199.526 |  264.864 |  264.390 |   65.960 |
| YRoundToZeroBenchmark_Double | SumScalar            |       162.005 |  162.338 |  134.928 | 1244.374 |
| YRoundToZeroBenchmark_Double | SumBase              |       414.124 | 1086.141 | 1064.551 |  965.665 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit     |       413.705 |  438.380 |  471.448 |  530.067 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit_Not |       479.486 |  492.904 |  539.604 |  605.431 |
| YRoundToZeroBenchmark_Double | SumTraits            |       414.061 | 2098.006 | 1956.730 | 2465.230 |
| YRoundToZeroBenchmark_Double | Sum128Base_Basic     |       118.328 |  151.067 |  127.634 |  472.341 |
| YRoundToZeroBenchmark_Double | Sum128Base           |       118.676 |  156.528 |  125.612 | 1599.179 |
| YRoundToZeroBenchmark_Double | Sum128Traits         |       118.057 | 1969.101 | 2091.834 | 2465.142 |
| YRoundToZeroBenchmark_Double | Sum256Base_Basic     |        80.393 |  111.716 |   98.977 |  227.931 |
| YRoundToZeroBenchmark_Double | Sum256Base           |        81.292 |  117.742 |  103.279 |   82.375 |
| YRoundToZeroBenchmark_Double | Sum256Traits         |        78.918 |  116.085 |  104.466 |   82.345 |
| YRoundToZeroBenchmark_Single | SumScalar            |       149.059 |  149.102 |  139.739 | 1239.554 |
| YRoundToZeroBenchmark_Single | SumBase              |       843.472 | 2149.049 | 1811.947 | 2280.380 |
| YRoundToZeroBenchmark_Single | SumBase_ClearBit     |       842.343 |  908.606 |  982.581 | 1011.245 |
| YRoundToZeroBenchmark_Single | SumTraits            |       844.341 | 3946.291 | 4165.602 | 4710.957 |
| YRoundToZeroBenchmark_Single | Sum128Base_Basic     |       110.635 |  155.228 |  126.123 |  323.858 |
| YRoundToZeroBenchmark_Single | Sum128Base           |       109.276 |  149.154 |  123.291 | 2747.993 |
| YRoundToZeroBenchmark_Single | Sum128Traits         |       109.635 | 4206.755 | 3913.729 | 4715.503 |
| YRoundToZeroBenchmark_Single | Sum256Base_Basic     |        93.891 |  113.643 |  101.349 |  258.865 |
| YRoundToZeroBenchmark_Single | Sum256Base           |        95.960 |  115.319 |  104.365 |  116.804 |
| YRoundToZeroBenchmark_Single | Sum256Traits         |        95.352 |  118.681 |  104.108 |  116.416 |
