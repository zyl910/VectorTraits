# Benchmark group - Ceiling
([← Back](Ceiling.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### x86 - lntel Core i5-8250U
| Type                         | Method               | .NET Framework | .NET Core 2.1 | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 |
| :--------------------------- | :------------------- | -------------: | ------------: | ------------: | -------: | -------: | -------: |
| CeilingBenchmark_Double      | SumScalar            |        412.980 |       280.858 |       280.137 |  279.561 |  279.128 |  279.967 |
| CeilingBenchmark_Double      | SumBcl               |                |               |               | 3010.554 | 3242.627 | 3247.624 |
| CeilingBenchmark_Double      | SumBase              |       1062.381 |      1061.929 |      1280.356 | 2968.252 | 3194.279 | 3269.246 |
| CeilingBenchmark_Double      | SumBase_Basic        |        287.440 |       490.767 |       467.050 |  496.050 |  467.434 |  493.473 |
| CeilingBenchmark_Double      | SumBase_ClearBit     |       1072.637 |       993.333 |      1197.805 | 1174.705 | 1239.603 | 1234.445 |
| CeilingBenchmark_Double      | SumTraits            |       1000.619 |       991.899 |      3172.027 | 3104.910 | 3251.552 | 3206.632 |
| CeilingBenchmark_Double      | Sum128Bcl            |                |               |               |          |          | 1655.395 |
| CeilingBenchmark_Double      | Sum128Base_Basic     |                |               |       158.773 |  157.945 |  159.768 |  302.729 |
| CeilingBenchmark_Double      | Sum128Base           |                |               |       159.136 |  159.282 |  159.653 | 1659.188 |
| CeilingBenchmark_Double      | Sum128Traits         |                |               |       158.938 |  158.323 |  159.506 | 1653.792 |
| CeilingBenchmark_Double      | Sum256Bcl            |                |               |               |          |          | 3048.889 |
| CeilingBenchmark_Double      | Sum256Base_Basic     |                |               |       471.118 |  532.589 |  469.511 |  535.830 |
| CeilingBenchmark_Double      | Sum256Base           |                |               |       469.610 |  533.437 |  468.297 | 3089.020 |
| CeilingBenchmark_Double      | Sum256Traits         |                |               |      3271.728 | 3081.069 | 3211.921 | 3095.625 |
| CeilingBenchmark_Single      | SumScalar            |        185.993 |       280.947 |       281.245 |  280.813 |  280.453 |  281.408 |
| CeilingBenchmark_Single      | SumBcl               |                |               |               | 6663.045 | 6666.958 | 6635.887 |
| CeilingBenchmark_Single      | SumBase              |       1042.031 |      1947.968 |      2385.106 | 6647.332 | 6665.210 | 6553.857 |
| CeilingBenchmark_Single      | SumBase_Basic        |        181.479 |       459.524 |       766.965 |  785.447 |  755.807 |  788.257 |
| CeilingBenchmark_Single      | SumBase_ClearBit     |       1975.370 |      1932.821 |      2495.557 | 2528.092 | 2340.143 | 2526.898 |
| CeilingBenchmark_Single      | SumTraits            |       1878.139 |      2075.313 |      6129.016 | 6571.875 | 6446.697 | 6624.018 |
| CeilingBenchmark_Single      | Sum128Bcl            |                |               |               |          |          | 3336.253 |
| CeilingBenchmark_Single      | Sum128Base_Basic     |                |               |       289.793 |  289.216 |  290.158 |  559.436 |
| CeilingBenchmark_Single      | Sum128Base           |                |               |       289.592 |  290.591 |  286.749 | 3334.433 |
| CeilingBenchmark_Single      | Sum128Traits         |                |               |       289.494 |  291.004 |  258.190 | 3348.518 |
| CeilingBenchmark_Single      | Sum256Bcl            |                |               |               |          |          | 6542.927 |
| CeilingBenchmark_Single      | Sum256Base_Basic     |                |               |       822.290 |  885.084 |  816.630 |  923.770 |
| CeilingBenchmark_Single      | Sum256Base           |                |               |       825.477 |  886.191 |  827.980 | 6276.027 |
| CeilingBenchmark_Single      | Sum256Traits         |                |               |      6624.296 | 6329.864 | 6527.725 | 6542.642 |
| FloorBenchmark_Double        | SumScalar            |        434.349 |       280.889 |       279.580 |  280.165 |  280.482 |  279.027 |
| FloorBenchmark_Double        | SumBcl               |                |               |               | 3091.000 | 3189.489 | 3181.729 |
| FloorBenchmark_Double        | SumBase              |        933.307 |      1007.928 |      1278.945 | 3205.871 | 3145.399 | 3087.774 |
| FloorBenchmark_Double        | SumBase_Basic        |        274.699 |       495.287 |       463.589 |  495.710 |  470.792 |  492.169 |
| FloorBenchmark_Double        | SumBase_ClearBit     |        999.334 |      1009.316 |      1147.151 | 1174.578 | 1244.012 | 1313.490 |
| FloorBenchmark_Double        | SumTraits            |        996.211 |      1004.039 |      2994.228 | 3120.590 | 3251.925 | 3253.668 |
| FloorBenchmark_Double        | Sum128Bcl            |                |               |               |          |          | 1646.149 |
| FloorBenchmark_Double        | Sum128Base_Basic     |                |               |       158.989 |  159.972 |  159.543 |  304.595 |
| FloorBenchmark_Double        | Sum128Base           |                |               |       158.536 |  159.026 |  159.916 | 1656.506 |
| FloorBenchmark_Double        | Sum128Traits         |                |               |       158.387 |  158.908 |  159.565 | 1652.297 |
| FloorBenchmark_Double        | Sum256Bcl            |                |               |               |          |          | 3212.858 |
| FloorBenchmark_Double        | Sum256Base_Basic     |                |               |       465.611 |  467.375 |  533.869 |  534.838 |
| FloorBenchmark_Double        | Sum256Base           |                |               |       462.915 |  466.562 |  535.311 | 3247.740 |
| FloorBenchmark_Double        | Sum256Traits         |                |               |      2970.900 | 2953.529 | 3067.252 | 3248.753 |
| FloorBenchmark_Single        | SumScalar            |        197.076 |       281.338 |       281.050 |  279.850 |  280.635 |  281.419 |
| FloorBenchmark_Single        | SumBcl               |                |               |               | 6673.020 | 6335.088 | 6160.084 |
| FloorBenchmark_Single        | SumBase              |       2028.046 |      2016.554 |      2521.991 | 6694.421 | 6457.957 | 6178.017 |
| FloorBenchmark_Single        | SumBase_Basic        |        234.796 |       459.259 |       759.712 |  762.355 |  770.766 |  765.623 |
| FloorBenchmark_Single        | SumBase_ClearBit     |       2149.107 |      1926.093 |      1781.410 | 2328.569 | 2434.517 | 2416.349 |
| FloorBenchmark_Single        | SumTraits            |       2138.401 |      1911.738 |      3279.931 | 6606.767 | 6647.730 | 6208.141 |
| FloorBenchmark_Single        | Sum128Bcl            |                |               |               |          |          | 3338.840 |
| FloorBenchmark_Single        | Sum128Base_Basic     |                |               |       190.366 |  289.794 |  291.102 |  560.421 |
| FloorBenchmark_Single        | Sum128Base           |                |               |       218.153 |  289.064 |  290.244 | 3338.906 |
| FloorBenchmark_Single        | Sum128Traits         |                |               |       231.947 |  288.476 |  291.338 | 3347.296 |
| FloorBenchmark_Single        | Sum256Bcl            |                |               |               |          |          | 6591.146 |
| FloorBenchmark_Single        | Sum256Base_Basic     |                |               |       580.264 |  819.903 |  885.886 |  925.118 |
| FloorBenchmark_Single        | Sum256Base           |                |               |       619.942 |  827.258 |  885.597 | 6658.583 |
| FloorBenchmark_Single        | Sum256Traits         |                |               |      5299.073 | 6686.638 | 6660.299 | 6189.342 |
| YRoundToEvenBenchmark_Double | SumScalar            |        127.742 |       279.942 |       238.148 |  280.935 |  280.907 |  281.073 |
| YRoundToEvenBenchmark_Double | SumBase              |       2228.336 |      2047.918 |      1921.266 | 2330.883 | 2597.889 | 2467.688 |
| YRoundToEvenBenchmark_Double | SumBase_Add          |       2206.904 |      1986.976 |      2200.473 | 2275.420 | 2564.584 | 2584.549 |
| YRoundToEvenBenchmark_Double | SumTraits            |       1936.561 |      1952.964 |      3014.638 | 3178.493 | 3265.075 | 3247.742 |
| YRoundToEvenBenchmark_Double | Sum128Base_Basic     |                |               |       159.218 |  159.143 |  159.894 |  304.689 |
| YRoundToEvenBenchmark_Double | Sum128Base           |                |               |       159.237 |  158.729 |  160.018 | 1505.217 |
| YRoundToEvenBenchmark_Double | Sum128Traits         |                |               |       159.296 |  159.827 |  160.091 | 1506.678 |
| YRoundToEvenBenchmark_Double | Sum256Base_Basic     |                |               |       468.000 |  470.075 |  531.652 |  536.278 |
| YRoundToEvenBenchmark_Double | Sum256Base           |                |               |       467.375 |  469.478 |  535.763 | 2453.877 |
| YRoundToEvenBenchmark_Double | Sum256Traits         |                |               |      3152.866 | 3153.965 | 3067.464 | 3208.535 |
| YRoundToEvenBenchmark_Single | SumScalar            |        106.129 |       281.202 |       280.483 |  281.308 |  280.888 |  281.124 |
| YRoundToEvenBenchmark_Single | SumBase              |       3846.063 |      4354.952 |      4669.012 | 5246.601 | 5814.252 | 4628.288 |
| YRoundToEvenBenchmark_Single | SumBase_Add          |       4049.007 |      4139.158 |      4801.331 | 5098.525 | 5099.222 | 4857.226 |
| YRoundToEvenBenchmark_Single | SumTraits            |       3737.951 |      4553.530 |      6509.488 | 6609.823 | 6485.141 | 6459.225 |
| YRoundToEvenBenchmark_Single | Sum128Base_Basic     |                |               |       291.138 |  289.171 |  290.504 |  555.559 |
| YRoundToEvenBenchmark_Single | Sum128Base           |                |               |       291.557 |  290.458 |  290.617 | 2885.109 |
| YRoundToEvenBenchmark_Single | Sum128Traits         |                |               |       291.480 |  289.428 |  290.611 | 2909.698 |
| YRoundToEvenBenchmark_Single | Sum256Base_Basic     |                |               |       821.989 |  824.871 |  884.982 |  927.905 |
| YRoundToEvenBenchmark_Single | Sum256Base           |                |               |       816.917 |  818.202 |  882.247 | 4705.889 |
| YRoundToEvenBenchmark_Single | Sum256Traits         |                |               |      6514.154 | 6234.231 | 6170.518 | 6201.831 |
| YRoundToZeroBenchmark_Double | SumScalar            |        183.251 |       199.108 |       216.126 |  201.761 |  204.123 |  280.635 |
| YRoundToZeroBenchmark_Double | SumBase              |       1539.579 |      1593.620 |      1815.298 | 2502.016 | 2904.255 | 2621.701 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit     |       1391.329 |      1493.136 |      1813.153 | 1787.973 | 1704.912 | 1708.608 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit_Not |       1627.086 |      1512.067 |      1610.078 | 1705.871 | 1517.497 | 1656.192 |
| YRoundToZeroBenchmark_Double | SumTraits            |       1582.205 |      1489.558 |      3194.236 | 3235.294 | 3188.426 | 3147.820 |
| YRoundToZeroBenchmark_Double | Sum128Base_Basic     |                |               |       109.916 |  108.744 |  108.847 |  301.915 |
| YRoundToZeroBenchmark_Double | Sum128Base           |                |               |       109.424 |  109.798 |  108.687 | 1522.046 |
| YRoundToZeroBenchmark_Double | Sum128Traits         |                |               |       109.797 |  109.957 |  109.476 | 1469.299 |
| YRoundToZeroBenchmark_Double | Sum256Base_Basic     |                |               |       173.227 |  191.831 |  192.517 |  528.007 |
| YRoundToZeroBenchmark_Double | Sum256Base           |                |               |       172.379 |  170.511 |  192.199 | 2660.909 |
| YRoundToZeroBenchmark_Double | Sum256Traits         |                |               |      3164.017 | 3045.328 | 3261.483 | 3020.262 |
| YRoundToZeroBenchmark_Single | SumScalar            |        118.145 |       209.425 |       190.957 |  200.718 |  210.920 |  281.118 |
| YRoundToZeroBenchmark_Single | SumBase              |       2840.766 |      3180.573 |      3441.352 | 5891.495 | 5601.870 | 5293.321 |
| YRoundToZeroBenchmark_Single | SumBase_ClearBit     |       2937.327 |      2986.076 |      3451.416 | 3437.217 | 3309.733 | 3491.647 |
| YRoundToZeroBenchmark_Single | SumTraits            |       2797.146 |      3105.694 |      6555.822 | 6077.277 | 6145.363 | 6165.792 |
| YRoundToZeroBenchmark_Single | Sum128Base_Basic     |                |               |       147.439 |  159.333 |  147.947 |  555.750 |
| YRoundToZeroBenchmark_Single | Sum128Base           |                |               |       121.617 |  144.945 |  151.696 | 2992.939 |
| YRoundToZeroBenchmark_Single | Sum128Traits         |                |               |       107.147 |  145.996 |  159.800 | 3074.751 |
| YRoundToZeroBenchmark_Single | Sum256Base_Basic     |                |               |       133.805 |  176.634 |  198.481 |  927.573 |
| YRoundToZeroBenchmark_Single | Sum256Base           |                |               |       180.315 |  177.831 |  187.927 | 5293.440 |
| YRoundToZeroBenchmark_Single | Sum256Traits         |                |               |      6556.909 | 6328.726 | 6265.317 | 6242.231 |

### Arm - AWS Arm t4g.small
| Type                         | Method               | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 |
| :--------------------------- | :------------------- | ------------: | -------: | -------: | -------: |
| CeilingBenchmark_Double      | SumScalar            |       826.769 |  828.704 |  811.499 | 1242.533 |
| CeilingBenchmark_Double      | SumBcl               |               | 2098.061 | 1934.170 | 2461.046 |
| CeilingBenchmark_Double      | SumBase              |       482.326 | 2092.123 | 2063.120 | 2459.541 |
| CeilingBenchmark_Double      | SumBase_Basic        |       482.444 |  481.381 |  464.481 |  477.996 |
| CeilingBenchmark_Double      | SumBase_ClearBit     |       281.811 |  320.760 |  338.668 |  391.546 |
| CeilingBenchmark_Double      | SumTraits            |       475.521 | 1965.433 | 1967.245 | 2466.490 |
| CeilingBenchmark_Double      | Sum128Bcl            |               |          |          | 2462.722 |
| CeilingBenchmark_Double      | Sum128Base_Basic     |       225.768 |  467.467 |  468.917 |  474.586 |
| CeilingBenchmark_Double      | Sum128Base           |       227.212 |  468.968 |  467.741 | 2465.012 |
| CeilingBenchmark_Double      | Sum128Traits         |       227.626 | 2098.211 | 2094.867 | 2460.736 |
| CeilingBenchmark_Double      | Sum256Bcl            |               |          |          |  269.599 |
| CeilingBenchmark_Double      | Sum256Base_Basic     |       142.927 |  211.999 |  213.697 |  226.279 |
| CeilingBenchmark_Double      | Sum256Base           |       142.232 |  213.558 |  213.821 |  227.731 |
| CeilingBenchmark_Double      | Sum256Traits         |       143.524 |  213.441 |  213.752 |  227.918 |
| CeilingBenchmark_Single      | SumScalar            |       899.023 |  899.250 |  900.867 | 1240.976 |
| CeilingBenchmark_Single      | SumBcl               |               | 4187.114 | 4158.774 | 4727.534 |
| CeilingBenchmark_Single      | SumBase              |       573.981 | 4174.828 | 3913.335 | 4734.605 |
| CeilingBenchmark_Single      | SumBase_Basic        |       327.709 |  328.147 |  328.351 |  327.208 |
| CeilingBenchmark_Single      | SumBase_ClearBit     |       573.727 |  656.898 |  713.008 |  743.186 |
| CeilingBenchmark_Single      | SumTraits            |       575.558 | 3924.946 | 3912.364 | 4757.584 |
| CeilingBenchmark_Single      | Sum128Bcl            |               |          |          | 4760.402 |
| CeilingBenchmark_Single      | Sum128Base_Basic     |       179.133 |  314.511 |  314.434 |  325.645 |
| CeilingBenchmark_Single      | Sum128Base           |       178.993 |  313.952 |  314.920 | 4755.007 |
| CeilingBenchmark_Single      | Sum128Traits         |       178.650 | 4182.635 | 3899.422 | 4748.292 |
| CeilingBenchmark_Single      | Sum256Bcl            |               |          |          |  291.808 |
| CeilingBenchmark_Single      | Sum256Base_Basic     |       202.657 |  273.445 |  273.300 |  258.887 |
| CeilingBenchmark_Single      | Sum256Base           |       198.254 |  264.161 |  265.232 |  279.806 |
| CeilingBenchmark_Single      | Sum256Traits         |       199.308 |  265.303 |  264.965 |  280.114 |
| FloorBenchmark_Double        | SumScalar            |       899.459 |  901.636 |  901.892 | 1245.040 |
| FloorBenchmark_Double        | SumBcl               |               | 2093.372 | 1966.058 | 2468.457 |
| FloorBenchmark_Double        | SumBase              |       475.719 | 2093.570 | 2096.187 | 2470.383 |
| FloorBenchmark_Double        | SumBase_Basic        |       477.275 |  475.666 |  475.755 |  477.873 |
| FloorBenchmark_Double        | SumBase_ClearBit     |       281.648 |  321.760 |  343.393 |  388.015 |
| FloorBenchmark_Double        | SumTraits            |       477.604 | 2095.045 | 1964.730 | 2469.391 |
| FloorBenchmark_Double        | Sum128Bcl            |               |          |          | 2468.847 |
| FloorBenchmark_Double        | Sum128Base_Basic     |       227.791 |  467.644 |  472.156 |  475.489 |
| FloorBenchmark_Double        | Sum128Base           |       224.903 |  470.323 |  470.365 | 2465.497 |
| FloorBenchmark_Double        | Sum128Traits         |       227.307 | 1968.408 | 2098.120 | 2468.472 |
| FloorBenchmark_Double        | Sum256Bcl            |               |          |          |  270.584 |
| FloorBenchmark_Double        | Sum256Base_Basic     |       142.665 |  213.153 |  213.624 |  226.033 |
| FloorBenchmark_Double        | Sum256Base           |       142.850 |  215.121 |  214.980 |  228.010 |
| FloorBenchmark_Double        | Sum256Traits         |       142.635 |  214.618 |  214.122 |  228.020 |
| FloorBenchmark_Single        | SumScalar            |       899.329 |  826.638 |  900.491 | 1242.995 |
| FloorBenchmark_Single        | SumBcl               |               | 4187.530 | 4161.340 | 4694.784 |
| FloorBenchmark_Single        | SumBase              |       573.918 | 4182.983 | 3910.103 | 4757.881 |
| FloorBenchmark_Single        | SumBase_Basic        |       328.991 |  327.725 |  327.485 |  327.246 |
| FloorBenchmark_Single        | SumBase_ClearBit     |       573.619 |  655.558 |  712.237 |  740.561 |
| FloorBenchmark_Single        | SumTraits            |       573.136 | 3927.757 | 4159.649 | 4758.099 |
| FloorBenchmark_Single        | Sum128Bcl            |               |          |          | 4752.548 |
| FloorBenchmark_Single        | Sum128Base_Basic     |       178.778 |  314.695 |  314.250 |  325.368 |
| FloorBenchmark_Single        | Sum128Base           |       178.995 |  314.515 |  314.706 | 4749.327 |
| FloorBenchmark_Single        | Sum128Traits         |       178.987 | 4186.191 | 3902.757 | 4755.230 |
| FloorBenchmark_Single        | Sum256Bcl            |               |          |          |  290.965 |
| FloorBenchmark_Single        | Sum256Base_Basic     |       203.575 |  274.198 |  273.341 |  259.927 |
| FloorBenchmark_Single        | Sum256Base           |       199.336 |  264.415 |  265.378 |  279.988 |
| FloorBenchmark_Single        | Sum256Traits         |       198.725 |  264.167 |  264.618 |  280.012 |
| YRoundToEvenBenchmark_Double | SumScalar            |       827.154 |  828.353 |  830.248 | 1244.672 |
| YRoundToEvenBenchmark_Double | SumBase              |       720.979 |  720.028 |  748.168 |  626.817 |
| YRoundToEvenBenchmark_Double | SumBase_Add          |       716.384 |  719.400 |  749.195 |  626.542 |
| YRoundToEvenBenchmark_Double | SumTraits            |       719.561 | 1963.255 | 2095.018 | 2470.066 |
| YRoundToEvenBenchmark_Double | Sum128Base_Basic     |       229.545 |  469.280 |  468.193 |  475.300 |
| YRoundToEvenBenchmark_Double | Sum128Base           |       227.247 |  470.373 |  470.388 | 1026.807 |
| YRoundToEvenBenchmark_Double | Sum128Traits         |       228.175 | 2077.867 | 1965.800 | 2468.209 |
| YRoundToEvenBenchmark_Double | Sum256Base_Basic     |       143.314 |  214.894 |  213.760 |  227.537 |
| YRoundToEvenBenchmark_Double | Sum256Base           |       142.875 |  214.076 |  214.173 |   50.281 |
| YRoundToEvenBenchmark_Double | Sum256Traits         |       143.300 |  213.184 |  215.620 |   50.275 |
| YRoundToEvenBenchmark_Single | SumScalar            |       825.955 |  826.573 |  827.853 | 1243.083 |
| YRoundToEvenBenchmark_Single | SumBase              |      1474.272 | 1462.693 | 1234.648 | 1531.852 |
| YRoundToEvenBenchmark_Single | SumBase_Add          |      1470.287 | 1483.004 | 1234.978 | 1530.531 |
| YRoundToEvenBenchmark_Single | SumTraits            |      1470.230 | 4186.280 | 3899.819 | 4752.053 |
| YRoundToEvenBenchmark_Single | Sum128Base_Basic     |       178.758 |  313.985 |  314.648 |  325.499 |
| YRoundToEvenBenchmark_Single | Sum128Base           |       179.699 |  314.518 |  314.784 | 1864.673 |
| YRoundToEvenBenchmark_Single | Sum128Traits         |       178.581 | 3930.141 | 4160.155 | 4759.974 |
| YRoundToEvenBenchmark_Single | Sum256Base_Basic     |       202.907 |  273.294 |  273.568 |  259.831 |
| YRoundToEvenBenchmark_Single | Sum256Base           |       198.913 |  264.874 |  264.437 |   66.073 |
| YRoundToEvenBenchmark_Single | Sum256Traits         |       199.124 |  265.291 |  264.563 |   66.018 |
| YRoundToZeroBenchmark_Double | SumScalar            |       116.913 |  137.190 |  152.408 | 1244.416 |
| YRoundToZeroBenchmark_Double | SumBase              |       481.687 | 1065.440 | 1071.656 |  964.792 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit     |       478.316 |  493.856 |  539.242 |  604.790 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit_Not |       410.900 |  443.094 |  473.208 |  531.412 |
| YRoundToZeroBenchmark_Double | SumTraits            |       475.827 | 1963.968 | 1966.935 | 2470.418 |
| YRoundToZeroBenchmark_Double | Sum128Base_Basic     |        79.228 |  129.627 |  155.932 |  475.188 |
| YRoundToZeroBenchmark_Double | Sum128Base           |        78.859 |  127.542 |  152.617 | 1606.804 |
| YRoundToZeroBenchmark_Double | Sum128Traits         |        78.879 | 2095.975 | 2094.000 | 2470.777 |
| YRoundToZeroBenchmark_Double | Sum256Base_Basic     |        63.742 |   98.156 |  112.419 |  227.020 |
| YRoundToZeroBenchmark_Double | Sum256Base           |        64.585 |  101.433 |  118.187 |   81.588 |
| YRoundToZeroBenchmark_Double | Sum256Traits         |        56.832 |   98.754 |  115.448 |   81.405 |
| YRoundToZeroBenchmark_Single | SumScalar            |        98.112 |  132.959 |  158.213 | 1243.358 |
| YRoundToZeroBenchmark_Single | SumBase              |      1000.043 | 2186.171 | 1812.929 | 2293.027 |
| YRoundToZeroBenchmark_Single | SumBase_ClearBit     |       989.959 | 1026.186 | 1118.979 | 1154.554 |
| YRoundToZeroBenchmark_Single | SumTraits            |       993.963 | 4184.152 | 4164.395 | 4759.973 |
| YRoundToZeroBenchmark_Single | Sum128Base_Basic     |        77.618 |  121.491 |  151.273 |  325.485 |
| YRoundToZeroBenchmark_Single | Sum128Base           |        76.860 |  126.208 |  155.560 | 2785.098 |
| YRoundToZeroBenchmark_Single | Sum128Traits         |        76.597 | 3923.172 | 3906.307 | 4758.605 |
| YRoundToZeroBenchmark_Single | Sum256Base_Basic     |        68.793 |  101.088 |  115.132 |  259.781 |
| YRoundToZeroBenchmark_Single | Sum256Base           |        68.960 |  104.218 |  118.361 |  116.531 |
| YRoundToZeroBenchmark_Single | Sum256Traits         |        69.300 |  105.192 |  117.227 |  117.104 |
