# Benchmark group - Ceiling
([← Back](Ceiling.md))

Cell unit: Million operations per second.

### x86 - lntel Core i5-8250U
| Class                        | Method           | .NET Framework | .NET Core 2.1 | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 |
| :--------------------------- | :--------------- | -------------: | ------------: | ------------: | -------: | -------: | -------: |
| CeilingBenchmark_Double      | SumScalar        |        417.895 |       278.088 |       280.454 |  280.075 |  280.583 |  279.935 |
| CeilingBenchmark_Double      | SumBcl           |                |               |               | 3266.388 | 3272.593 | 3264.591 |
| CeilingBenchmark_Double      | SumBase          |        834.217 |       816.503 |       896.612 | 3244.511 | 3264.993 | 3286.006 |
| CeilingBenchmark_Double      | SumBase_Basic    |        284.897 |       485.972 |       493.506 |  495.832 |  135.917 |  493.889 |
| CeilingBenchmark_Double      | SumBase_ClearBit |        813.785 |       864.255 |       908.057 |  999.851 |  956.186 | 1003.449 |
| CeilingBenchmark_Double      | SumTraits        |        804.450 |       852.194 |      3091.432 | 3262.566 | 3276.169 | 3089.729 |
| CeilingBenchmark_Double      | Sum128Bcl        |                |               |               |          |          | 1577.645 |
| CeilingBenchmark_Double      | Sum128Base_Basic |                |               |       158.987 |  159.948 |  159.507 |  303.253 |
| CeilingBenchmark_Double      | Sum128Base       |                |               |       159.487 |  160.111 |  159.622 | 1634.648 |
| CeilingBenchmark_Double      | Sum128Traits     |                |               |       159.684 |  160.232 |  159.673 | 1626.430 |
| CeilingBenchmark_Double      | Sum256Bcl        |                |               |               |          |          | 2909.770 |
| CeilingBenchmark_Double      | Sum256Base_Basic |                |               |       535.491 |  536.057 |  138.793 |  506.836 |
| CeilingBenchmark_Double      | Sum256Base       |                |               |       535.947 |  535.674 |  138.789 | 2877.397 |
| CeilingBenchmark_Double      | Sum256Traits     |                |               |      3226.517 | 3290.702 | 3276.113 | 3074.129 |
| CeilingBenchmark_Single      | SumScalar        |        197.921 |       281.093 |       280.276 |  281.469 |  280.893 |  281.188 |
| CeilingBenchmark_Single      | SumBcl           |                |               |               | 6680.740 | 6696.955 | 6611.335 |
| CeilingBenchmark_Single      | SumBase          |       1642.791 |      1569.983 |      1826.638 | 6671.956 | 6686.363 | 6650.190 |
| CeilingBenchmark_Single      | SumBase_Basic    |        231.960 |       458.292 |       790.915 |  790.634 |  253.994 |  762.811 |
| CeilingBenchmark_Single      | SumBase_ClearBit |       1712.651 |      1603.109 |      1833.438 | 1967.098 | 1867.142 | 2082.699 |
| CeilingBenchmark_Single      | SumTraits        |       1711.593 |      1676.296 |      6560.096 | 6682.335 | 6667.881 | 6027.883 |
| CeilingBenchmark_Single      | Sum128Bcl        |                |               |               |          |          | 3311.088 |
| CeilingBenchmark_Single      | Sum128Base_Basic |                |               |       291.504 |  291.392 |  290.645 |  558.483 |
| CeilingBenchmark_Single      | Sum128Base       |                |               |       289.800 |  291.528 |  290.211 | 3349.274 |
| CeilingBenchmark_Single      | Sum128Traits     |                |               |       289.998 |  291.263 |  290.749 | 3355.530 |
| CeilingBenchmark_Single      | Sum256Bcl        |                |               |               |          |          | 6536.163 |
| CeilingBenchmark_Single      | Sum256Base_Basic |                |               |       883.363 |  883.997 |  256.833 |  761.750 |
| CeilingBenchmark_Single      | Sum256Base       |                |               |       883.213 |  880.399 |  256.867 | 6315.026 |
| CeilingBenchmark_Single      | Sum256Traits     |                |               |      6618.632 | 6652.748 | 6683.710 | 6291.113 |
| FloorBenchmark_Double        | SumScalar        |        447.280 |       280.677 |       279.865 |  281.043 |  280.831 |  280.564 |
| FloorBenchmark_Double        | SumBcl           |                |               |               | 3296.341 | 3282.552 | 3227.064 |
| FloorBenchmark_Double        | SumBase          |        804.201 |       816.199 |       978.104 | 3285.578 | 3269.227 | 3239.587 |
| FloorBenchmark_Double        | SumBase_Basic    |        289.592 |       494.064 |       493.114 |  495.753 |  135.820 |  475.284 |
| FloorBenchmark_Double        | SumBase_ClearBit |        834.945 |       847.757 |       932.832 |  977.467 |  988.289 |  973.169 |
| FloorBenchmark_Double        | SumTraits        |        837.418 |       814.547 |      3243.152 | 3254.634 | 3261.104 | 3192.639 |
| FloorBenchmark_Double        | Sum128Bcl        |                |               |               |          |          | 1661.589 |
| FloorBenchmark_Double        | Sum128Base_Basic |                |               |       159.611 |  159.831 |  159.982 |  304.424 |
| FloorBenchmark_Double        | Sum128Base       |                |               |       159.613 |  160.089 |  160.140 | 1659.206 |
| FloorBenchmark_Double        | Sum128Traits     |                |               |       159.888 |  160.315 |  160.218 | 1656.437 |
| FloorBenchmark_Double        | Sum256Bcl        |                |               |               |          |          | 3272.428 |
| FloorBenchmark_Double        | Sum256Base_Basic |                |               |       529.443 |  535.240 |  535.889 |  469.635 |
| FloorBenchmark_Double        | Sum256Base       |                |               |       525.616 |  534.221 |  532.996 | 3242.904 |
| FloorBenchmark_Double        | Sum256Traits     |                |               |      3141.673 | 3283.540 | 3273.834 | 3279.329 |
| FloorBenchmark_Single        | SumScalar        |        196.895 |       281.011 |       278.781 |  280.424 |  279.893 |  280.137 |
| FloorBenchmark_Single        | SumBcl           |                |               |               | 6531.098 | 6668.184 | 6644.415 |
| FloorBenchmark_Single        | SumBase          |       1695.519 |      1669.531 |      1857.212 | 6541.801 | 6663.187 | 6671.589 |
| FloorBenchmark_Single        | SumBase_Basic    |        235.278 |       458.493 |       782.409 |  779.018 |  790.666 |  767.203 |
| FloorBenchmark_Single        | SumBase_ClearBit |       1593.737 |      1674.487 |      1822.954 | 2083.724 | 1912.782 | 2018.639 |
| FloorBenchmark_Single        | SumTraits        |       1703.858 |      1572.495 |      6545.273 | 6556.881 | 6626.923 | 6576.504 |
| FloorBenchmark_Single        | Sum128Bcl        |                |               |               |          |          | 3348.947 |
| FloorBenchmark_Single        | Sum128Base_Basic |                |               |       278.738 |  287.766 |  291.511 |  558.688 |
| FloorBenchmark_Single        | Sum128Base       |                |               |       289.803 |  286.958 |  291.174 | 3353.001 |
| FloorBenchmark_Single        | Sum128Traits     |                |               |       290.105 |  288.146 |  291.282 | 3335.051 |
| FloorBenchmark_Single        | Sum256Bcl        |                |               |               |          |          | 6556.680 |
| FloorBenchmark_Single        | Sum256Base_Basic |                |               |       881.205 |  884.010 |  884.132 |  820.231 |
| FloorBenchmark_Single        | Sum256Base       |                |               |       881.550 |  882.674 |  876.596 | 6586.200 |
| FloorBenchmark_Single        | Sum256Traits     |                |               |      6670.002 | 6650.729 | 6597.250 | 6521.154 |
| YRoundToEvenBenchmark_Double | SumScalar        |        123.152 |       280.259 |       280.015 |  280.675 |  278.072 |  278.606 |
| YRoundToEvenBenchmark_Double | SumBase          |       2105.101 |      2184.177 |      2537.818 | 2548.521 | 2519.403 | 2629.086 |
| YRoundToEvenBenchmark_Double | SumBase_Add      |       2097.017 |      1969.991 |      2561.394 | 2624.556 | 2536.804 | 2453.873 |
| YRoundToEvenBenchmark_Double | SumTraits        |       2111.145 |      2226.096 |      3273.215 | 3283.806 | 3185.973 | 3209.523 |
| YRoundToEvenBenchmark_Double | Sum128Base_Basic |                |               |       160.061 |  160.079 |  159.098 |  304.718 |
| YRoundToEvenBenchmark_Double | Sum128Base       |                |               |       159.780 |  159.302 |  158.713 | 1517.483 |
| YRoundToEvenBenchmark_Double | Sum128Traits     |                |               |       159.982 |  159.425 |  159.320 | 1500.376 |
| YRoundToEvenBenchmark_Double | Sum256Base_Basic |                |               |       533.897 |  532.495 |  533.486 |  465.997 |
| YRoundToEvenBenchmark_Double | Sum256Base       |                |               |       533.512 |  533.874 |  535.215 | 2513.851 |
| YRoundToEvenBenchmark_Double | Sum256Traits     |                |               |      3283.300 | 3209.232 | 3293.164 | 3204.751 |
| YRoundToEvenBenchmark_Single | SumScalar        |        112.375 |       281.147 |       281.121 |  280.539 |  281.142 |  278.452 |
| YRoundToEvenBenchmark_Single | SumBase          |       4521.338 |      4319.431 |      4947.858 | 5521.087 | 5858.236 | 5069.403 |
| YRoundToEvenBenchmark_Single | SumBase_Add      |       4101.949 |      4790.492 |      5312.123 | 5406.321 | 5910.466 | 4979.590 |
| YRoundToEvenBenchmark_Single | SumTraits        |       4410.870 |      4751.639 |      6620.438 | 6647.653 | 6656.310 | 6393.090 |
| YRoundToEvenBenchmark_Single | Sum128Base_Basic |                |               |       289.174 |  291.421 |  291.030 |  559.578 |
| YRoundToEvenBenchmark_Single | Sum128Base       |                |               |       291.553 |  291.613 |  291.319 | 3070.074 |
| YRoundToEvenBenchmark_Single | Sum128Traits     |                |               |       290.891 |  291.350 |  291.322 | 3069.133 |
| YRoundToEvenBenchmark_Single | Sum256Base_Basic |                |               |       885.846 |  885.911 |  884.636 |  823.306 |
| YRoundToEvenBenchmark_Single | Sum256Base       |                |               |       883.533 |  885.963 |  885.752 | 5037.753 |
| YRoundToEvenBenchmark_Single | Sum256Traits     |                |               |      6637.386 | 6676.243 | 6675.423 | 6543.418 |
| YRoundToZeroBenchmark_Double | SumScalar        |        186.784 |       206.973 |       207.138 |  206.757 |  100.677 |  280.890 |
| YRoundToZeroBenchmark_Double | SumBase          |       1133.835 |      1128.572 |      1216.044 | 2769.496 | 2908.619 | 2728.809 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit |       1090.277 |      1132.861 |      1205.178 | 1416.382 | 1291.222 | 1435.897 |
| YRoundToZeroBenchmark_Double | SumTraits        |       1150.882 |      1132.862 |      3267.384 | 3271.842 | 3285.474 | 3275.713 |
| YRoundToZeroBenchmark_Double | Sum128Base_Basic |                |               |       109.517 |  109.611 |  109.518 |  304.874 |
| YRoundToZeroBenchmark_Double | Sum128Base       |                |               |       109.259 |  109.195 |  109.684 | 1558.869 |
| YRoundToZeroBenchmark_Double | Sum128Traits     |                |               |       109.827 |   85.064 |  109.692 | 1522.786 |
| YRoundToZeroBenchmark_Double | Sum256Base_Basic |                |               |       189.648 |  101.142 |  179.537 |  469.047 |
| YRoundToZeroBenchmark_Double | Sum256Base       |                |               |       187.031 |  182.525 |  184.308 | 2965.754 |
| YRoundToZeroBenchmark_Double | Sum256Traits     |                |               |      3273.959 | 3266.719 | 3264.846 | 3265.585 |
| YRoundToZeroBenchmark_Single | SumScalar        |        127.969 |       180.115 |       205.903 |  209.419 |  196.907 |  279.553 |
| YRoundToZeroBenchmark_Single | SumBase          |       2232.755 |      2253.742 |      2190.860 | 6027.605 | 5685.133 | 5878.646 |
| YRoundToZeroBenchmark_Single | SumBase_ClearBit |       2128.099 |      2204.280 |      2345.651 | 2787.153 | 2643.687 | 2646.912 |
| YRoundToZeroBenchmark_Single | SumTraits        |       2117.666 |      2185.623 |      6651.257 | 6672.350 | 6676.272 | 6539.243 |
| YRoundToZeroBenchmark_Single | Sum128Base_Basic |                |               |       156.104 |  158.991 |   92.196 |  560.305 |
| YRoundToZeroBenchmark_Single | Sum128Base       |                |               |       157.946 |  158.741 |  116.579 | 3107.175 |
| YRoundToZeroBenchmark_Single | Sum128Traits     |                |               |       156.399 |  157.535 |  158.642 | 3097.481 |
| YRoundToZeroBenchmark_Single | Sum256Base_Basic |                |               |       185.936 |  198.558 |  100.999 |  822.361 |
| YRoundToZeroBenchmark_Single | Sum256Base       |                |               |       184.723 |  200.735 |  139.114 | 6029.981 |
| YRoundToZeroBenchmark_Single | Sum256Traits     |                |               |      6532.025 | 6678.795 | 6642.262 | 6649.430 |

### Arm - AWS Arm t4g.small
| Class                        | Method           | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 |
| :--------------------------- | :--------------- | ------------: | -------: | -------: | -------: |
| CeilingBenchmark_Double      | SumScalar        |       829.419 |  829.190 |  829.069 | 1244.301 |
| CeilingBenchmark_Double      | SumBcl           |               | 2093.883 | 1968.120 | 2470.751 |
| CeilingBenchmark_Double      | SumBase          |       484.537 | 2098.081 | 2095.473 | 2467.067 |
| CeilingBenchmark_Double      | SumBase_Basic    |       215.740 |  475.374 |  482.377 |  478.132 |
| CeilingBenchmark_Double      | SumBase_ClearBit |       183.874 |  237.469 |  263.271 |  288.492 |
| CeilingBenchmark_Double      | SumTraits        |       479.263 | 1967.932 | 2096.171 | 2468.473 |
| CeilingBenchmark_Double      | Sum128Bcl        |               |          |          | 2464.693 |
| CeilingBenchmark_Double      | Sum128Base_Basic |       230.169 |  469.973 |  472.581 |  475.081 |
| CeilingBenchmark_Double      | Sum128Base       |       231.225 |  472.354 |  472.425 | 2467.937 |
| CeilingBenchmark_Double      | Sum128Traits     |       230.580 | 2080.660 | 1965.410 | 2467.121 |
| CeilingBenchmark_Double      | Sum256Bcl        |               |          |          |  270.515 |
| CeilingBenchmark_Double      | Sum256Base_Basic |       145.252 |  214.991 |  214.709 |  226.071 |
| CeilingBenchmark_Double      | Sum256Base       |       145.701 |  214.175 |  214.780 |  228.013 |
| CeilingBenchmark_Double      | Sum256Traits     |       146.234 |  214.223 |  214.799 |  228.058 |
| CeilingBenchmark_Single      | SumScalar        |       902.859 |  827.319 |  828.595 | 1240.758 |
| CeilingBenchmark_Single      | SumBcl           |               | 4168.448 | 3911.273 | 4702.110 |
| CeilingBenchmark_Single      | SumBase          |       374.117 | 4171.968 | 4167.304 | 4702.100 |
| CeilingBenchmark_Single      | SumBase_Basic    |       329.309 |  328.119 |  328.478 |  327.022 |
| CeilingBenchmark_Single      | SumBase_ClearBit |       369.737 |  510.076 |  523.583 |  566.766 |
| CeilingBenchmark_Single      | SumTraits        |       374.136 | 4167.573 | 3903.693 | 4700.442 |
| CeilingBenchmark_Single      | Sum128Bcl        |               |          |          | 4709.245 |
| CeilingBenchmark_Single      | Sum128Base_Basic |       179.763 |  314.370 |  314.792 |  325.381 |
| CeilingBenchmark_Single      | Sum128Base       |       179.722 |  314.789 |  314.558 | 4711.882 |
| CeilingBenchmark_Single      | Sum128Traits     |       179.710 | 3915.472 | 4160.695 | 4703.732 |
| CeilingBenchmark_Single      | Sum256Bcl        |               |          |          |  292.082 |
| CeilingBenchmark_Single      | Sum256Base_Basic |       201.150 |  271.497 |  273.671 |  258.502 |
| CeilingBenchmark_Single      | Sum256Base       |       196.273 |  263.981 |  264.104 |  279.797 |
| CeilingBenchmark_Single      | Sum256Traits     |       196.270 |  264.486 |  264.365 |  279.346 |
| FloorBenchmark_Double        | SumScalar        |       902.139 |  902.926 |  829.151 | 1244.283 |
| FloorBenchmark_Double        | SumBcl           |               | 2098.000 | 2091.050 | 2459.743 |
| FloorBenchmark_Double        | SumBase          |       479.406 | 2096.010 | 1966.074 | 2463.389 |
| FloorBenchmark_Double        | SumBase_Basic    |       478.686 |  475.450 |  482.219 |  471.928 |
| FloorBenchmark_Double        | SumBase_ClearBit |       184.364 |  237.770 |  263.697 |  285.959 |
| FloorBenchmark_Double        | SumTraits        |       478.985 | 2094.466 | 1965.831 | 2467.065 |
| FloorBenchmark_Double        | Sum128Bcl        |               |          |          | 2464.638 |
| FloorBenchmark_Double        | Sum128Base_Basic |       229.885 |  470.257 |  472.505 |  469.283 |
| FloorBenchmark_Double        | Sum128Base       |       228.301 |  472.507 |  472.549 | 2465.248 |
| FloorBenchmark_Double        | Sum128Traits     |       230.773 | 1966.409 | 2093.312 | 2465.723 |
| FloorBenchmark_Double        | Sum256Bcl        |               |          |          |  270.628 |
| FloorBenchmark_Double        | Sum256Base_Basic |       143.626 |  213.667 |  214.037 |  227.718 |
| FloorBenchmark_Double        | Sum256Base       |       143.945 |  213.359 |  214.569 |  228.089 |
| FloorBenchmark_Double        | Sum256Traits     |       144.183 |  214.788 |  213.804 |  228.005 |
| FloorBenchmark_Single        | SumScalar        |       828.044 |  901.220 |  827.432 | 1240.039 |
| FloorBenchmark_Single        | SumBcl           |               | 3919.618 | 3911.975 | 4702.729 |
| FloorBenchmark_Single        | SumBase          |       373.895 | 3914.011 | 4166.932 | 4711.522 |
| FloorBenchmark_Single        | SumBase_Basic    |       329.024 |  328.023 |  328.043 |  327.012 |
| FloorBenchmark_Single        | SumBase_ClearBit |       374.155 |  509.379 |  524.319 |  562.198 |
| FloorBenchmark_Single        | SumTraits        |       372.403 | 3895.362 | 4163.633 | 4698.280 |
| FloorBenchmark_Single        | Sum128Bcl        |               |          |          | 4703.472 |
| FloorBenchmark_Single        | Sum128Base_Basic |       179.530 |  314.939 |  314.947 |  325.081 |
| FloorBenchmark_Single        | Sum128Base       |       179.561 |  314.324 |  315.084 | 4690.033 |
| FloorBenchmark_Single        | Sum128Traits     |       177.634 | 4172.969 | 3917.388 | 4692.576 |
| FloorBenchmark_Single        | Sum256Bcl        |               |          |          |  290.863 |
| FloorBenchmark_Single        | Sum256Base_Basic |       201.098 |  271.877 |  273.422 |  259.457 |
| FloorBenchmark_Single        | Sum256Base       |       196.079 |  265.794 |  265.076 |  279.776 |
| FloorBenchmark_Single        | Sum256Traits     |       196.081 |  264.266 |  264.603 |  279.856 |
| YRoundToEvenBenchmark_Double | SumScalar        |       903.004 |  902.715 |  828.180 | 1244.545 |
| YRoundToEvenBenchmark_Double | SumBase          |       717.804 |  719.061 |  751.614 |  626.432 |
| YRoundToEvenBenchmark_Double | SumBase_Add      |       719.631 |  721.682 |  749.870 |  626.471 |
| YRoundToEvenBenchmark_Double | SumTraits        |       714.664 | 2095.209 | 2099.192 | 2460.771 |
| YRoundToEvenBenchmark_Double | Sum128Base_Basic |       229.634 |  471.118 |  472.693 |  470.439 |
| YRoundToEvenBenchmark_Double | Sum128Base       |       229.041 |  469.674 |  472.186 | 1017.172 |
| YRoundToEvenBenchmark_Double | Sum128Traits     |       229.900 | 1968.378 | 1967.909 | 2470.259 |
| YRoundToEvenBenchmark_Double | Sum256Base_Basic |       144.365 |  214.005 |  214.097 |  227.641 |
| YRoundToEvenBenchmark_Double | Sum256Base       |       144.163 |  214.872 |  214.286 |   50.194 |
| YRoundToEvenBenchmark_Double | Sum256Traits     |       144.073 |  214.863 |  214.299 |   50.196 |
| YRoundToEvenBenchmark_Single | SumScalar        |       902.180 |  828.533 |  901.194 | 1238.247 |
| YRoundToEvenBenchmark_Single | SumBase          |      1476.550 | 1465.853 | 1237.371 | 1454.865 |
| YRoundToEvenBenchmark_Single | SumBase_Add      |      1479.040 | 1474.276 | 1236.700 | 1525.939 |
| YRoundToEvenBenchmark_Single | SumTraits        |      1467.071 | 4170.679 | 3917.332 | 4704.973 |
| YRoundToEvenBenchmark_Single | Sum128Base_Basic |       179.743 |  314.886 |  315.002 |  325.190 |
| YRoundToEvenBenchmark_Single | Sum128Base       |       179.645 |  315.043 |  314.466 | 1854.125 |
| YRoundToEvenBenchmark_Single | Sum128Traits     |       179.648 | 3904.895 | 4159.278 | 4700.519 |
| YRoundToEvenBenchmark_Single | Sum256Base_Basic |       200.760 |  272.582 |  273.477 |  259.389 |
| YRoundToEvenBenchmark_Single | Sum256Base       |       196.201 |  263.808 |  265.562 |   65.993 |
| YRoundToEvenBenchmark_Single | Sum256Traits     |       196.032 |  264.461 |  265.223 |   65.977 |
| YRoundToZeroBenchmark_Double | SumScalar        |       162.550 |  140.239 |  140.363 | 1244.686 |
| YRoundToZeroBenchmark_Double | SumBase          |       241.233 | 1078.117 | 1077.514 |  965.249 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit |       241.149 |  311.854 |  350.294 |  379.079 |
| YRoundToZeroBenchmark_Double | SumTraits        |       240.987 | 1963.798 | 2097.308 | 2465.789 |
| YRoundToZeroBenchmark_Double | Sum128Base_Basic |       118.384 |  127.451 |  122.461 |  470.209 |
| YRoundToZeroBenchmark_Double | Sum128Base       |       117.760 |  121.603 |  128.931 | 1605.466 |
| YRoundToZeroBenchmark_Double | Sum128Traits     |       117.945 | 2096.066 | 1969.392 | 2468.178 |
| YRoundToZeroBenchmark_Double | Sum256Base_Basic |        81.037 |  100.517 |   96.642 |  227.639 |
| YRoundToZeroBenchmark_Double | Sum256Base       |        78.583 |   99.367 |  100.507 |   81.346 |
| YRoundToZeroBenchmark_Double | Sum256Traits     |        79.080 |   99.412 |  100.910 |   81.260 |
| YRoundToZeroBenchmark_Single | SumScalar        |       158.569 |  133.028 |  138.739 | 1240.455 |
| YRoundToZeroBenchmark_Single | SumBase          |       484.398 | 2187.951 | 1818.647 | 2284.300 |
| YRoundToZeroBenchmark_Single | SumBase_ClearBit |       483.978 |  672.405 |  690.772 |  747.307 |
| YRoundToZeroBenchmark_Single | SumTraits        |       484.881 | 3903.144 | 4169.740 | 4710.389 |
| YRoundToZeroBenchmark_Single | Sum128Base_Basic |       109.922 |  126.757 |  126.332 |  325.287 |
| YRoundToZeroBenchmark_Single | Sum128Base       |       106.179 |  123.439 |  123.526 | 2741.302 |
| YRoundToZeroBenchmark_Single | Sum128Traits     |       113.965 | 4162.042 | 3912.528 | 4680.994 |
| YRoundToZeroBenchmark_Single | Sum256Base_Basic |        92.301 |  102.162 |  101.803 |  259.334 |
| YRoundToZeroBenchmark_Single | Sum256Base       |        94.786 |  104.624 |  104.353 |  116.971 |
| YRoundToZeroBenchmark_Single | Sum256Traits     |        95.137 |  105.416 |  104.706 |  116.742 |
