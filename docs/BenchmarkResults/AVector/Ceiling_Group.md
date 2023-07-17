# Benchmark group - Ceiling
([← Back](Ceiling.md))

Cell unit: Mega/Second .

### x86 - lntel Core i5-8250U
| Class                        | Name             | .NET Framework | .NET Core 2.1 | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 |
| :--------------------------- | :--------------- | -------------: | ------------: | ------------: | -------: | -------: | -------: |
| CeilingBenchmark_Double      | SumScalar        |        476.434 |       277.456 |       280.439 |  274.524 |  279.649 |  280.593 |
| CeilingBenchmark_Double      | SumBcl           |                |               |               | 2853.271 | 3237.146 | 3212.500 |
| CeilingBenchmark_Double      | SumBase          |        838.455 |       758.808 |       863.685 | 2959.868 | 3034.366 | 3058.741 |
| CeilingBenchmark_Double      | SumBase_Basic    |        286.236 |       486.627 |       493.491 |  481.766 |  471.219 |  495.796 |
| CeilingBenchmark_Double      | SumBase_ClearBit |        837.025 |       797.075 |       959.270 |  876.690 |  883.011 |  910.728 |
| CeilingBenchmark_Double      | SumTraits        |        817.948 |       800.207 |      2984.088 | 3067.503 | 3055.200 | 2984.542 |
| CeilingBenchmark_Double      | Sum128Bcl        |                |               |               |          |          | 1641.901 |
| CeilingBenchmark_Double      | Sum128Base_Basic |                |               |       158.531 |  159.801 |  160.029 |  303.612 |
| CeilingBenchmark_Double      | Sum128Base       |                |               |       158.244 |  160.067 |  160.102 | 1649.622 |
| CeilingBenchmark_Double      | Sum128Traits     |                |               |       158.254 |  160.071 |  160.057 | 1643.344 |
| CeilingBenchmark_Double      | Sum256Bcl        |                |               |               |          |          | 3019.371 |
| CeilingBenchmark_Double      | Sum256Base_Basic |                |               |       525.417 |  533.540 |  469.076 |  531.360 |
| CeilingBenchmark_Double      | Sum256Base       |                |               |       532.141 |  533.944 |  470.123 | 3070.428 |
| CeilingBenchmark_Double      | Sum256Traits     |                |               |      3062.177 | 2863.173 | 3256.144 | 3260.313 |
| CeilingBenchmark_Single      | SumScalar        |        197.916 |       279.401 |       280.900 |  281.068 |  281.420 |  280.988 |
| CeilingBenchmark_Single      | SumBcl           |                |               |               | 6227.678 | 6529.408 | 6652.076 |
| CeilingBenchmark_Single      | SumBase          |       1538.374 |      1487.935 |      1824.604 | 6188.604 | 6420.936 | 6445.141 |
| CeilingBenchmark_Single      | SumBase_Basic    |        230.140 |       456.429 |       759.868 |  789.254 |  761.316 |  751.967 |
| CeilingBenchmark_Single      | SumBase_ClearBit |       1622.598 |      1573.719 |      1713.710 | 2041.774 | 1902.785 | 1868.098 |
| CeilingBenchmark_Single      | SumTraits        |       1617.508 |      1560.917 |      6578.611 | 6130.891 | 6370.155 | 6081.735 |
| CeilingBenchmark_Single      | Sum128Bcl        |                |               |               |          |          | 3312.013 |
| CeilingBenchmark_Single      | Sum128Base_Basic |                |               |       290.783 |  292.190 |  291.519 |  557.825 |
| CeilingBenchmark_Single      | Sum128Base       |                |               |       290.629 |  291.493 |  290.833 | 3320.444 |
| CeilingBenchmark_Single      | Sum128Traits     |                |               |       290.273 |  292.071 |  290.724 | 3318.125 |
| CeilingBenchmark_Single      | Sum256Bcl        |                |               |               |          |          | 6380.540 |
| CeilingBenchmark_Single      | Sum256Base_Basic |                |               |       884.906 |  883.884 |  816.822 |  922.758 |
| CeilingBenchmark_Single      | Sum256Base       |                |               |       885.062 |  884.350 |  822.564 | 6442.341 |
| CeilingBenchmark_Single      | Sum256Traits     |                |               |      6256.296 | 6600.946 | 6679.433 | 6545.213 |
| FloorBenchmark_Double        | SumScalar        |        416.462 |       279.663 |       280.508 |  280.236 |  280.084 |  280.650 |
| FloorBenchmark_Double        | SumBcl           |                |               |               | 3048.394 | 2982.064 | 3231.088 |
| FloorBenchmark_Double        | SumBase          |        819.950 |       854.506 |       967.353 | 3102.425 | 2987.562 | 2977.907 |
| FloorBenchmark_Double        | SumBase_Basic    |        296.901 |       486.047 |       490.176 |  492.960 |  472.537 |  474.858 |
| FloorBenchmark_Double        | SumBase_ClearBit |        746.238 |       758.349 |       910.401 |  881.020 |  873.568 |  902.273 |
| FloorBenchmark_Double        | SumTraits        |        436.867 |       793.438 |      3256.555 | 3222.838 | 3024.379 | 3220.525 |
| FloorBenchmark_Double        | Sum128Bcl        |                |               |               |          |          | 1649.369 |
| FloorBenchmark_Double        | Sum128Base_Basic |                |               |       159.651 |  159.866 |  159.700 |  304.918 |
| FloorBenchmark_Double        | Sum128Base       |                |               |       159.401 |  159.703 |  159.732 | 1646.527 |
| FloorBenchmark_Double        | Sum128Traits     |                |               |       159.446 |  159.864 |  159.344 | 1642.507 |
| FloorBenchmark_Double        | Sum256Bcl        |                |               |               |          |          | 3198.375 |
| FloorBenchmark_Double        | Sum256Base_Basic |                |               |       534.885 |  469.957 |  531.547 |  531.366 |
| FloorBenchmark_Double        | Sum256Base       |                |               |       534.118 |  464.309 |  534.198 | 3257.757 |
| FloorBenchmark_Double        | Sum256Traits     |                |               |      3083.938 | 3061.643 | 3010.659 | 3080.414 |
| FloorBenchmark_Single        | SumScalar        |        177.193 |       279.089 |       280.371 |  281.233 |  278.962 |  281.294 |
| FloorBenchmark_Single        | SumBcl           |                |               |               | 6646.008 | 6535.424 | 6087.570 |
| FloorBenchmark_Single        | SumBase          |       1639.540 |      1459.620 |      1872.519 | 6652.212 | 6529.984 | 6116.870 |
| FloorBenchmark_Single        | SumBase_Basic    |        235.401 |       453.002 |       790.033 |  768.406 |  778.773 |  749.163 |
| FloorBenchmark_Single        | SumBase_ClearBit |       1624.899 |      1558.140 |      1759.534 | 1931.816 | 1723.403 | 2061.702 |
| FloorBenchmark_Single        | SumTraits        |       1542.873 |      1599.425 |      6309.735 | 6635.990 | 6649.416 | 6245.726 |
| FloorBenchmark_Single        | Sum128Bcl        |                |               |               |          |          | 3316.250 |
| FloorBenchmark_Single        | Sum128Base_Basic |                |               |       291.075 |  290.717 |  291.053 |  559.275 |
| FloorBenchmark_Single        | Sum128Base       |                |               |       290.990 |  289.361 |  289.868 | 3337.482 |
| FloorBenchmark_Single        | Sum128Traits     |                |               |       290.579 |  291.279 |  290.688 | 3336.856 |
| FloorBenchmark_Single        | Sum256Bcl        |                |               |               |          |          | 6533.811 |
| FloorBenchmark_Single        | Sum256Base_Basic |                |               |       920.677 |  826.500 |  924.695 |  915.587 |
| FloorBenchmark_Single        | Sum256Base       |                |               |       914.646 |  827.073 |  925.100 | 6633.468 |
| FloorBenchmark_Single        | Sum256Traits     |                |               |      6533.855 | 6669.540 | 6306.196 | 6191.139 |
| YRoundToZeroBenchmark_Double | SumScalar        |        188.372 |       218.280 |       213.518 |  223.392 |  224.310 |  280.248 |
| YRoundToZeroBenchmark_Double | SumBase          |       1094.988 |      1075.113 |      1060.453 | 2566.601 | 2804.695 | 2510.874 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit |       1108.104 |      1110.940 |      1071.885 | 1245.032 | 1279.185 | 1339.814 |
| YRoundToZeroBenchmark_Double | SumTraits        |       1099.706 |      1105.074 |      3012.169 | 3218.102 | 3140.110 | 3151.023 |
| YRoundToZeroBenchmark_Double | Sum128Base_Basic |                |               |       111.269 |  111.463 |  109.290 |  304.891 |
| YRoundToZeroBenchmark_Double | Sum128Base       |                |               |       109.646 |  111.669 |  111.086 | 1443.340 |
| YRoundToZeroBenchmark_Double | Sum128Traits     |                |               |       111.722 |  111.802 |  111.573 | 1516.937 |
| YRoundToZeroBenchmark_Double | Sum256Base_Basic |                |               |       172.572 |  173.749 |  191.076 |  532.803 |
| YRoundToZeroBenchmark_Double | Sum256Base       |                |               |       180.495 |  170.077 |  189.666 | 2733.273 |
| YRoundToZeroBenchmark_Double | Sum256Traits     |                |               |      3195.645 | 3249.998 | 3198.961 | 3214.126 |
| YRoundToZeroBenchmark_Single | SumScalar        |        128.350 |       217.119 |       194.631 |  229.477 |  186.079 |  280.536 |
| YRoundToZeroBenchmark_Single | SumBase          |       2257.002 |      2073.929 |      2075.388 | 5275.657 | 5533.763 | 5173.759 |
| YRoundToZeroBenchmark_Single | SumBase_ClearBit |       2051.839 |      1948.471 |      2266.919 | 2431.621 | 2575.505 | 2393.478 |
| YRoundToZeroBenchmark_Single | SumTraits        |       2225.550 |      1978.356 |      6416.937 | 6184.649 | 6646.997 | 6505.304 |
| YRoundToZeroBenchmark_Single | Sum128Base_Basic |                |               |       151.955 |  157.066 |  157.991 |  559.275 |
| YRoundToZeroBenchmark_Single | Sum128Base       |                |               |       156.838 |  148.711 |  147.798 | 3094.850 |
| YRoundToZeroBenchmark_Single | Sum128Traits     |                |               |       158.449 |  151.060 |  148.330 | 3100.507 |
| YRoundToZeroBenchmark_Single | Sum256Base_Basic |                |               |       183.585 |  187.687 |  196.093 |  917.989 |
| YRoundToZeroBenchmark_Single | Sum256Base       |                |               |       189.242 |  186.303 |  190.757 | 5589.583 |
| YRoundToZeroBenchmark_Single | Sum256Traits     |                |               |      6625.948 | 6639.474 | 6485.038 | 6495.841 |

### Arm - AWS Arm t4g.small
| Class                        | Name             | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 |
| :--------------------------- | :--------------- | ------------: | -------: | -------: | -------: |
| CeilingBenchmark_Double      | SumScalar        |       828.379 |  830.341 |  902.717 | 1243.740 |
| CeilingBenchmark_Double      | SumBcl           |               | 2096.088 | 2089.012 | 2467.827 |
| CeilingBenchmark_Double      | SumBase          |       184.037 | 2096.360 | 1965.897 | 2468.100 |
| CeilingBenchmark_Double      | SumBase_Basic    |       483.534 |  473.668 |  472.385 |  470.802 |
| CeilingBenchmark_Double      | SumBase_ClearBit |       184.293 |  251.102 |  263.933 |  288.807 |
| CeilingBenchmark_Double      | SumTraits        |       183.874 | 1966.494 | 1964.687 | 2464.804 |
| CeilingBenchmark_Double      | Sum128Bcl        |               |          |          | 2469.371 |
| CeilingBenchmark_Double      | Sum128Base_Basic |       231.548 |  467.741 |  467.233 |  475.270 |
| CeilingBenchmark_Double      | Sum128Base       |       230.925 |  470.634 |  469.099 | 2468.644 |
| CeilingBenchmark_Double      | Sum128Traits     |       230.644 | 2095.179 | 2093.912 | 2464.158 |
| CeilingBenchmark_Double      | Sum256Bcl        |               |          |          |  270.614 |
| CeilingBenchmark_Double      | Sum256Base_Basic |       155.998 |  243.336 |  242.937 |  228.061 |
| CeilingBenchmark_Double      | Sum256Base       |       155.501 |  242.708 |  244.145 |  227.532 |
| CeilingBenchmark_Double      | Sum256Traits     |       155.435 |  244.028 |  243.571 |  227.174 |
| CeilingBenchmark_Single      | SumScalar        |       829.358 |  828.557 |  902.389 | 1243.024 |
| CeilingBenchmark_Single      | SumBcl           |               | 4171.970 | 3919.525 | 4722.643 |
| CeilingBenchmark_Single      | SumBase          |       374.015 | 4171.246 | 4179.878 | 4702.413 |
| CeilingBenchmark_Single      | SumBase_Basic    |       328.615 |  327.986 |  328.817 |  327.998 |
| CeilingBenchmark_Single      | SumBase_ClearBit |       374.005 |  509.935 |  524.718 |  567.339 |
| CeilingBenchmark_Single      | SumTraits        |       369.600 | 4164.482 | 4144.539 | 4733.844 |
| CeilingBenchmark_Single      | Sum128Bcl        |               |          |          | 4733.613 |
| CeilingBenchmark_Single      | Sum128Base_Basic |       179.712 |  314.934 |  314.413 |  326.105 |
| CeilingBenchmark_Single      | Sum128Base       |       179.610 |  314.980 |  314.651 | 4734.925 |
| CeilingBenchmark_Single      | Sum128Traits     |       179.564 | 3903.266 | 3921.209 | 4733.889 |
| CeilingBenchmark_Single      | Sum256Bcl        |               |          |          |  290.933 |
| CeilingBenchmark_Single      | Sum256Base_Basic |       214.004 |  296.419 |  296.795 |  259.909 |
| CeilingBenchmark_Single      | Sum256Base       |       211.963 |  286.454 |  286.802 |  279.887 |
| CeilingBenchmark_Single      | Sum256Traits     |       212.938 |  286.128 |  286.797 |  280.026 |
| FloorBenchmark_Double        | SumScalar        |       902.116 |  830.272 |  902.408 | 1244.718 |
| FloorBenchmark_Double        | SumBcl           |               | 1965.719 | 1968.290 | 2470.312 |
| FloorBenchmark_Double        | SumBase          |       184.199 | 1965.931 | 2092.377 | 2466.842 |
| FloorBenchmark_Double        | SumBase_Basic    |       483.945 |  476.062 |  475.602 |  479.052 |
| FloorBenchmark_Double        | SumBase_ClearBit |       184.227 |  250.999 |  265.104 |  286.209 |
| FloorBenchmark_Double        | SumTraits        |       184.337 | 1966.484 | 2095.077 | 2466.062 |
| FloorBenchmark_Double        | Sum128Bcl        |               |          |          | 2470.607 |
| FloorBenchmark_Double        | Sum128Base_Basic |       231.170 |  468.126 |  467.556 |  472.449 |
| FloorBenchmark_Double        | Sum128Base       |       231.621 |  468.686 |  469.735 | 2472.308 |
| FloorBenchmark_Double        | Sum128Traits     |       231.744 | 2091.954 | 1964.927 | 2466.874 |
| FloorBenchmark_Double        | Sum256Bcl        |               |          |          |  270.108 |
| FloorBenchmark_Double        | Sum256Base_Basic |       165.749 |  244.191 |  245.190 |  227.672 |
| FloorBenchmark_Double        | Sum256Base       |       164.463 |  243.936 |  245.036 |  228.297 |
| FloorBenchmark_Double        | Sum256Traits     |       166.071 |  244.386 |  244.704 |  228.095 |
| FloorBenchmark_Single        | SumScalar        |       827.421 |  826.646 |  829.448 | 1243.694 |
| FloorBenchmark_Single        | SumBcl           |               | 4169.412 | 3918.567 | 4738.076 |
| FloorBenchmark_Single        | SumBase          |       373.932 | 4167.221 | 4174.521 | 4737.303 |
| FloorBenchmark_Single        | SumBase_Basic    |       328.336 |  327.690 |  328.022 |  327.519 |
| FloorBenchmark_Single        | SumBase_ClearBit |       373.998 |  509.328 |  524.781 |  562.987 |
| FloorBenchmark_Single        | SumTraits        |       374.085 | 3916.063 | 4185.938 | 4727.082 |
| FloorBenchmark_Single        | Sum128Bcl        |               |          |          | 4738.478 |
| FloorBenchmark_Single        | Sum128Base_Basic |       179.428 |  314.340 |  316.122 |  325.540 |
| FloorBenchmark_Single        | Sum128Base       |       179.310 |  314.296 |  316.033 | 4729.609 |
| FloorBenchmark_Single        | Sum128Traits     |       179.522 | 4164.083 | 3920.117 | 4726.703 |
| FloorBenchmark_Single        | Sum256Bcl        |               |          |          |  292.056 |
| FloorBenchmark_Single        | Sum256Base_Basic |       222.724 |  296.566 |  297.034 |  258.816 |
| FloorBenchmark_Single        | Sum256Base       |       222.865 |  296.758 |  295.938 |  280.112 |
| FloorBenchmark_Single        | Sum256Traits     |       222.840 |  296.859 |  296.898 |  279.956 |
| YRoundToZeroBenchmark_Double | SumScalar        |       134.638 |  137.248 |  131.873 | 1244.567 |
| YRoundToZeroBenchmark_Double | SumBase          |       240.052 | 1060.457 | 1065.764 |  965.890 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit |       239.822 |  336.273 |  350.950 |  379.743 |
| YRoundToZeroBenchmark_Double | SumTraits        |       241.570 | 2094.534 | 2096.927 | 2468.480 |
| YRoundToZeroBenchmark_Double | Sum128Base_Basic |       110.183 |  130.545 |  103.341 |  475.356 |
| YRoundToZeroBenchmark_Double | Sum128Base       |       110.043 |  131.995 |  105.664 | 1608.896 |
| YRoundToZeroBenchmark_Double | Sum128Traits     |       110.127 | 1967.184 | 1967.994 | 2469.364 |
| YRoundToZeroBenchmark_Double | Sum256Base_Basic |        86.987 |  109.046 |  102.971 |  227.815 |
| YRoundToZeroBenchmark_Double | Sum256Base       |        85.645 |  109.042 |  105.245 |   82.127 |
| YRoundToZeroBenchmark_Double | Sum256Traits     |        85.895 |  105.565 |  103.106 |   81.814 |
| YRoundToZeroBenchmark_Single | SumScalar        |       140.035 |  133.017 |  128.002 | 1243.363 |
| YRoundToZeroBenchmark_Single | SumBase          |       484.113 | 2139.081 | 1821.116 | 2290.842 |
| YRoundToZeroBenchmark_Single | SumBase_ClearBit |       483.686 |  674.329 |  691.387 |  750.278 |
| YRoundToZeroBenchmark_Single | SumTraits        |       484.377 | 4157.496 | 4179.175 | 4737.249 |
| YRoundToZeroBenchmark_Single | Sum128Base_Basic |        95.460 |  122.880 |  119.100 |  325.483 |
| YRoundToZeroBenchmark_Single | Sum128Base       |        98.574 |  127.593 |  118.540 | 2738.533 |
| YRoundToZeroBenchmark_Single | Sum128Traits     |        95.866 | 3913.313 | 3919.136 | 4728.307 |
| YRoundToZeroBenchmark_Single | Sum256Base_Basic |       102.374 |  112.070 |  101.580 |  258.860 |
| YRoundToZeroBenchmark_Single | Sum256Base       |       103.932 |  111.095 |  104.429 |  117.168 |
| YRoundToZeroBenchmark_Single | Sum256Traits     |       102.478 |  112.045 |  105.482 |  116.996 |
