# Benchmark group - Ceiling
([← Back](Ceiling.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

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

