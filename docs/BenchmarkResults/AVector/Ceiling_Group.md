# Benchmark group - Ceiling
([← Back](Ceiling.md))

Cell unit: Mega/Second .

### x86 - lntel Core i5-8250U
| Class                        | Name             | .NET Framework | .NET Core 2.1 | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 |
| :--------------------------- | :--------------- | -------------: | ------------: | ------------: | -------: | -------: | -------: |
| CeilingBenchmark_Double      | SumScalar        |        482.275 |       280.823 |       280.866 |  280.510 |  280.125 |  280.764 |
| CeilingBenchmark_Double      | SumBcl           |                |               |               | 3266.401 | 3218.731 | 3155.485 |
| CeilingBenchmark_Double      | SumBase          |        837.742 |       861.297 |       988.431 | 3175.265 | 3218.991 | 3166.182 |
| CeilingBenchmark_Double      | SumBase_Basic    |        290.331 |       469.749 |       491.992 |  492.885 |  472.403 |  461.240 |
| CeilingBenchmark_Double      | SumBase_ClearBit |        842.261 |       868.971 |       942.610 | 1006.734 |  915.573 | 1038.853 |
| CeilingBenchmark_Double      | SumTraits        |        782.315 |       777.954 |      3269.782 | 3205.282 | 3222.768 | 3253.642 |
| CeilingBenchmark_Double      | Sum128Bcl        |                |               |               |          |          | 1632.390 |
| CeilingBenchmark_Double      | Sum128Base_Basic |                |               |       159.211 |  158.438 |  160.034 |  305.422 |
| CeilingBenchmark_Double      | Sum128Base       |                |               |       159.340 |  158.496 |  159.949 | 1660.374 |
| CeilingBenchmark_Double      | Sum128Traits     |                |               |       159.227 |  158.084 |  159.399 | 1655.790 |
| CeilingBenchmark_Double      | Sum256Bcl        |                |               |               |          |          | 3208.348 |
| CeilingBenchmark_Double      | Sum256Base_Basic |                |               |       534.649 |  529.816 |  470.031 |  470.914 |
| CeilingBenchmark_Double      | Sum256Base       |                |               |       534.452 |  533.470 |  470.406 | 3192.930 |
| CeilingBenchmark_Double      | Sum256Traits     |                |               |      3233.767 | 3142.532 | 3274.315 | 3088.733 |
| CeilingBenchmark_Single      | SumScalar        |        197.717 |       279.960 |       280.186 |  281.410 |  281.328 |  281.372 |
| CeilingBenchmark_Single      | SumBcl           |                |               |               | 6531.020 | 6657.462 | 6363.590 |
| CeilingBenchmark_Single      | SumBase          |       1573.813 |      1557.696 |      1768.893 | 6658.358 | 6676.796 | 6401.239 |
| CeilingBenchmark_Single      | SumBase_Basic    |        233.763 |       458.137 |       791.766 |  786.686 |  767.354 |  768.782 |
| CeilingBenchmark_Single      | SumBase_ClearBit |       1599.699 |      1541.672 |      1755.417 | 1929.777 | 1926.243 | 2126.333 |
| CeilingBenchmark_Single      | SumTraits        |       1715.142 |      1526.830 |      6482.013 | 6521.122 | 6675.368 | 6687.620 |
| CeilingBenchmark_Single      | Sum128Bcl        |                |               |               |          |          | 3348.945 |
| CeilingBenchmark_Single      | Sum128Base_Basic |                |               |       290.014 |  291.697 |  291.526 |  559.821 |
| CeilingBenchmark_Single      | Sum128Base       |                |               |       291.315 |  291.529 |  291.291 | 3353.196 |
| CeilingBenchmark_Single      | Sum128Traits     |                |               |       290.677 |  290.451 |  291.444 | 3351.432 |
| CeilingBenchmark_Single      | Sum256Bcl        |                |               |               |          |          | 6325.050 |
| CeilingBenchmark_Single      | Sum256Base_Basic |                |               |       922.040 |  923.764 |  827.174 |  924.819 |
| CeilingBenchmark_Single      | Sum256Base       |                |               |       923.596 |  904.348 |  824.923 | 6671.235 |
| CeilingBenchmark_Single      | Sum256Traits     |                |               |      6614.054 | 6647.839 | 6475.313 | 6684.442 |
| FloorBenchmark_Double        | SumScalar        |        509.852 |       280.794 |       280.918 |  280.930 |  280.595 |  280.961 |
| FloorBenchmark_Double        | SumBcl           |                |               |               | 3189.789 | 3276.323 | 3140.427 |
| FloorBenchmark_Double        | SumBase          |        832.444 |       808.390 |       958.854 | 3261.170 | 3228.532 | 3256.175 |
| FloorBenchmark_Double        | SumBase_Basic    |        296.324 |       472.979 |       490.692 |  494.507 |  471.140 |  476.196 |
| FloorBenchmark_Double        | SumBase_ClearBit |        832.620 |       796.053 |       970.125 |  993.759 |  926.306 | 1028.112 |
| FloorBenchmark_Double        | SumTraits        |        839.057 |       791.669 |      3253.632 | 3269.227 | 3236.438 | 3171.064 |
| FloorBenchmark_Double        | Sum128Bcl        |                |               |               |          |          | 1664.275 |
| FloorBenchmark_Double        | Sum128Base_Basic |                |               |       159.491 |  159.540 |  159.890 |  304.993 |
| FloorBenchmark_Double        | Sum128Base       |                |               |       159.116 |  159.525 |  159.944 | 1654.507 |
| FloorBenchmark_Double        | Sum128Traits     |                |               |       159.903 |  160.199 |  159.832 | 1656.712 |
| FloorBenchmark_Double        | Sum256Bcl        |                |               |               |          |          | 3217.347 |
| FloorBenchmark_Double        | Sum256Base_Basic |                |               |       535.002 |  535.923 |  535.039 |  534.661 |
| FloorBenchmark_Double        | Sum256Base       |                |               |       533.803 |  534.772 |  533.216 | 3273.311 |
| FloorBenchmark_Double        | Sum256Traits     |                |               |      3158.848 | 3252.292 | 3180.895 | 3132.149 |
| FloorBenchmark_Single        | SumScalar        |        197.107 |       281.469 |       279.821 |  281.243 |  281.102 |  281.243 |
| FloorBenchmark_Single        | SumBcl           |                |               |               | 6661.786 | 6672.041 | 6373.250 |
| FloorBenchmark_Single        | SumBase          |       1701.395 |      1538.366 |      1748.402 | 6678.264 | 6675.607 | 6296.048 |
| FloorBenchmark_Single        | SumBase_Basic    |        232.816 |       459.697 |       790.398 |  790.088 |  790.935 |  768.413 |
| FloorBenchmark_Single        | SumBase_ClearBit |       1593.406 |      1553.454 |      1748.031 | 1995.694 | 1909.633 | 2128.762 |
| FloorBenchmark_Single        | SumTraits        |       1599.429 |      1547.420 |      6524.271 | 6435.838 | 6614.600 | 6669.643 |
| FloorBenchmark_Single        | Sum128Bcl        |                |               |               |          |          | 3350.284 |
| FloorBenchmark_Single        | Sum128Base_Basic |                |               |       290.069 |  292.093 |  291.712 |  560.670 |
| FloorBenchmark_Single        | Sum128Base       |                |               |       291.086 |  291.940 |  291.402 | 3346.684 |
| FloorBenchmark_Single        | Sum128Traits     |                |               |       291.066 |  291.923 |  291.883 | 3353.125 |
| FloorBenchmark_Single        | Sum256Bcl        |                |               |               |          |          | 6683.729 |
| FloorBenchmark_Single        | Sum256Base_Basic |                |               |       923.402 |  926.375 |  925.696 |  922.635 |
| FloorBenchmark_Single        | Sum256Base       |                |               |       924.758 |  926.764 |  922.060 | 6655.444 |
| FloorBenchmark_Single        | Sum256Traits     |                |               |      6626.080 | 6524.273 | 6466.515 | 6433.018 |
| YRoundToZeroBenchmark_Double | SumScalar        |        199.560 |       209.811 |       208.130 |  208.857 |  221.919 |  279.597 |
| YRoundToZeroBenchmark_Double | SumBase          |       1122.188 |      1089.976 |      1109.248 | 2663.074 | 2831.232 | 2588.000 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit |       1135.259 |      1136.943 |      1121.027 | 1283.005 | 1295.200 | 1402.854 |
| YRoundToZeroBenchmark_Double | SumTraits        |       1102.849 |      1104.581 |      3196.657 | 3189.266 | 3267.531 | 3073.152 |
| YRoundToZeroBenchmark_Double | Sum128Base_Basic |                |               |       111.367 |  111.361 |  111.861 |  305.422 |
| YRoundToZeroBenchmark_Double | Sum128Base       |                |               |       111.353 |  111.458 |  111.918 | 1631.794 |
| YRoundToZeroBenchmark_Double | Sum128Traits     |                |               |       112.028 |  112.147 |  112.019 | 1613.917 |
| YRoundToZeroBenchmark_Double | Sum256Base_Basic |                |               |       192.575 |  177.997 |  190.065 |  534.732 |
| YRoundToZeroBenchmark_Double | Sum256Base       |                |               |       178.627 |  196.928 |  177.482 | 2868.874 |
| YRoundToZeroBenchmark_Double | Sum256Traits     |                |               |      3147.959 | 3259.776 | 3128.296 | 3100.370 |
| YRoundToZeroBenchmark_Single | SumScalar        |        129.401 |       219.705 |       197.099 |  223.981 |  193.830 |  281.383 |
| YRoundToZeroBenchmark_Single | SumBase          |       2298.194 |      2127.599 |      2275.745 | 5573.932 | 5440.569 | 5893.726 |
| YRoundToZeroBenchmark_Single | SumBase_ClearBit |       2057.648 |      2093.915 |      2301.685 | 2678.881 | 2455.694 | 2771.852 |
| YRoundToZeroBenchmark_Single | SumTraits        |       2080.963 |      2112.770 |      6270.162 | 6489.491 | 6678.724 | 6330.733 |
| YRoundToZeroBenchmark_Single | Sum128Base_Basic |                |               |       138.407 |  151.853 |  160.019 |  559.947 |
| YRoundToZeroBenchmark_Single | Sum128Base       |                |               |       148.087 |  149.000 |  153.133 | 3018.283 |
| YRoundToZeroBenchmark_Single | Sum128Traits     |                |               |       149.979 |  150.391 |  155.689 | 3104.572 |
| YRoundToZeroBenchmark_Single | Sum256Base_Basic |                |               |       178.332 |  192.315 |  188.190 |  923.712 |
| YRoundToZeroBenchmark_Single | Sum256Base       |                |               |       183.036 |  196.213 |  188.704 | 6075.636 |
| YRoundToZeroBenchmark_Single | Sum256Traits     |                |               |      6662.604 | 6351.820 | 6457.931 | 6588.136 |

### Arm - AWS Arm t4g.small
| Class                        | Name             | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 |
| :--------------------------- | :--------------- | ------------: | -------: | -------: | -------: |
| CeilingBenchmark_Double      | SumScalar        |       825.870 |  825.392 |  892.874 | 1237.770 |
| CeilingBenchmark_Double      | SumBcl           |               | 2081.194 | 2076.887 | 2456.693 |
| CeilingBenchmark_Double      | SumBase          |       183.886 | 2089.422 | 1948.247 | 2453.481 |
| CeilingBenchmark_Double      | SumBase_Basic    |       476.015 |  480.482 |  481.784 |  475.767 |
| CeilingBenchmark_Double      | SumBase_ClearBit |       184.082 |  250.247 |  259.975 |  287.390 |
| CeilingBenchmark_Double      | SumTraits        |       183.615 | 1957.083 | 1954.358 | 2456.839 |
| CeilingBenchmark_Double      | Sum128Bcl        |               |          |          | 2447.285 |
| CeilingBenchmark_Double      | Sum128Base_Basic |       229.085 |  466.326 |  464.798 |  472.707 |
| CeilingBenchmark_Double      | Sum128Base       |       229.277 |  468.379 |  463.331 | 2455.489 |
| CeilingBenchmark_Double      | Sum128Traits     |       228.955 | 2078.758 | 2085.235 | 2459.659 |
| CeilingBenchmark_Double      | Sum256Bcl        |               |          |          |  268.811 |
| CeilingBenchmark_Double      | Sum256Base_Basic |       165.961 |  241.951 |  243.529 |  226.201 |
| CeilingBenchmark_Double      | Sum256Base       |       166.449 |  243.323 |  242.903 |  226.656 |
| CeilingBenchmark_Double      | Sum256Traits     |       166.118 |  244.305 |  243.550 |  227.440 |
| CeilingBenchmark_Single      | SumScalar        |       825.935 |  827.696 |  821.989 | 1238.650 |
| CeilingBenchmark_Single      | SumBcl           |               | 4160.499 | 4165.649 | 4671.149 |
| CeilingBenchmark_Single      | SumBase          |       373.206 | 4147.838 | 3893.144 | 4684.200 |
| CeilingBenchmark_Single      | SumBase_Basic    |       326.945 |  326.206 |  325.888 |  325.571 |
| CeilingBenchmark_Single      | SumBase_ClearBit |       372.967 |  510.181 |  524.511 |  563.557 |
| CeilingBenchmark_Single      | SumTraits        |       368.776 | 4167.739 | 3913.935 | 4661.571 |
| CeilingBenchmark_Single      | Sum128Bcl        |               |          |          | 4672.905 |
| CeilingBenchmark_Single      | Sum128Base_Basic |       179.028 |  315.685 |  314.385 |  323.380 |
| CeilingBenchmark_Single      | Sum128Base       |       179.333 |  315.199 |  314.550 | 4691.760 |
| CeilingBenchmark_Single      | Sum128Traits     |       179.285 | 3913.840 | 4192.164 | 4670.982 |
| CeilingBenchmark_Single      | Sum256Bcl        |               |          |          |  288.535 |
| CeilingBenchmark_Single      | Sum256Base_Basic |       222.154 |  295.870 |  297.303 |  258.078 |
| CeilingBenchmark_Single      | Sum256Base       |       221.808 |  295.297 |  297.062 |  277.945 |
| CeilingBenchmark_Single      | Sum256Traits     |       221.756 |  295.592 |  297.030 |  277.530 |
| FloorBenchmark_Double        | SumScalar        |       898.935 |  899.943 |  902.614 | 1240.878 |
| FloorBenchmark_Double        | SumBcl           |               | 2078.686 | 1968.370 | 2450.849 |
| FloorBenchmark_Double        | SumBase          |       183.698 | 2090.952 | 2097.607 | 2444.539 |
| FloorBenchmark_Double        | SumBase_Basic    |       482.904 |  479.934 |  477.617 |  477.570 |
| FloorBenchmark_Double        | SumBase_ClearBit |       183.904 |  249.605 |  264.314 |  285.207 |
| FloorBenchmark_Double        | SumTraits        |       183.766 | 2074.592 | 2098.917 | 2451.949 |
| FloorBenchmark_Double        | Sum128Bcl        |               |          |          | 2457.524 |
| FloorBenchmark_Double        | Sum128Base_Basic |       228.641 |  465.436 |  469.147 |  472.079 |
| FloorBenchmark_Double        | Sum128Base       |       229.065 |  465.508 |  465.464 | 2438.942 |
| FloorBenchmark_Double        | Sum128Traits     |       227.388 | 1950.419 | 1961.848 | 2455.867 |
| FloorBenchmark_Double        | Sum256Bcl        |               |          |          |  268.769 |
| FloorBenchmark_Double        | Sum256Base_Basic |       166.328 |  241.774 |  244.889 |  226.523 |
| FloorBenchmark_Double        | Sum256Base       |       166.374 |  242.529 |  244.816 |  226.784 |
| FloorBenchmark_Double        | Sum256Traits     |       166.444 |  241.773 |  245.014 |  227.057 |
| FloorBenchmark_Single        | SumScalar        |       826.108 |  892.425 |  828.124 | 1237.409 |
| FloorBenchmark_Single        | SumBcl           |               | 3880.862 | 3930.498 | 4678.036 |
| FloorBenchmark_Single        | SumBase          |       372.872 | 3873.416 | 4185.737 | 4668.982 |
| FloorBenchmark_Single        | SumBase_Basic    |       327.732 |  325.555 |  328.480 |  326.175 |
| FloorBenchmark_Single        | SumBase_ClearBit |       373.669 |  507.906 |  525.095 |  558.592 |
| FloorBenchmark_Single        | SumTraits        |       373.348 | 4152.355 | 4185.941 | 4674.870 |
| FloorBenchmark_Single        | Sum128Bcl        |               |          |          | 4677.170 |
| FloorBenchmark_Single        | Sum128Base_Basic |       178.705 |  312.753 |  315.963 |  325.293 |
| FloorBenchmark_Single        | Sum128Base       |       178.720 |  314.320 |  316.055 | 4672.309 |
| FloorBenchmark_Single        | Sum128Traits     |       178.911 | 3870.573 | 3929.329 | 4677.746 |
| FloorBenchmark_Single        | Sum256Bcl        |               |          |          |  290.206 |
| FloorBenchmark_Single        | Sum256Base_Basic |       222.299 |  294.016 |  297.301 |  258.954 |
| FloorBenchmark_Single        | Sum256Base       |       222.455 |  294.546 |  297.061 |  278.611 |
| FloorBenchmark_Single        | Sum256Traits     |       222.701 |  294.483 |  297.423 |  251.582 |
| YRoundToZeroBenchmark_Double | SumScalar        |       136.720 |  161.612 |  152.440 | 1195.113 |
| YRoundToZeroBenchmark_Double | SumBase          |       240.808 | 1007.969 |  910.022 | 1143.836 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit |       240.320 |  329.616 |  350.513 |  378.953 |
| YRoundToZeroBenchmark_Double | SumTraits        |       241.216 | 1943.397 | 2100.189 | 2468.666 |
| YRoundToZeroBenchmark_Double | Sum128Base_Basic |       109.322 |  151.105 |  156.138 |  469.890 |
| YRoundToZeroBenchmark_Double | Sum128Base       |       109.848 |  151.200 |  156.058 | 1605.649 |
| YRoundToZeroBenchmark_Double | Sum128Traits     |       109.351 | 2065.580 | 1970.067 | 2463.240 |
| YRoundToZeroBenchmark_Double | Sum256Base_Basic |        87.603 |  112.082 |  123.428 |  227.586 |
| YRoundToZeroBenchmark_Double | Sum256Base       |        87.469 |  123.772 |  120.822 |   80.114 |
| YRoundToZeroBenchmark_Double | Sum256Traits     |        85.006 |  121.504 |  125.615 |   79.952 |
| YRoundToZeroBenchmark_Single | SumScalar        |       133.003 |  158.095 |  159.123 | 1239.319 |
| YRoundToZeroBenchmark_Single | SumBase          |       482.475 | 2028.216 | 2167.859 | 2325.046 |
| YRoundToZeroBenchmark_Single | SumBase_ClearBit |       482.542 |  670.430 |  689.320 |  748.160 |
| YRoundToZeroBenchmark_Single | SumTraits        |       483.345 | 3896.663 | 4220.541 | 4684.352 |
| YRoundToZeroBenchmark_Single | Sum128Base_Basic |        95.584 |  146.759 |  147.407 |  326.244 |
| YRoundToZeroBenchmark_Single | Sum128Base       |        96.950 |  140.591 |  154.990 | 2776.707 |
| YRoundToZeroBenchmark_Single | Sum128Traits     |        96.771 | 4136.294 | 3952.191 | 4687.576 |
| YRoundToZeroBenchmark_Single | Sum256Base_Basic |       102.031 |  129.746 |  128.606 |  259.670 |
| YRoundToZeroBenchmark_Single | Sum256Base       |       102.382 |  128.088 |  127.227 |  116.493 |
| YRoundToZeroBenchmark_Single | Sum256Traits     |       101.118 |  127.791 |  129.299 |  116.451 |
