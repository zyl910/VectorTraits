# Benchmark group - Ceiling
([← Back](Ceiling.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### X86 - AMD Ryzen 7 7840H
| Type                         | Method               | .NET Framework | .NET Core 2.1 | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 |  .NET 8.0 |
| :--------------------------- | :------------------- | -------------: | ------------: | ------------: | -------: | -------: | -------: | --------: |
| CeilingBenchmark_Double      | SumScalar            |        499.914 |      1113.331 |      1112.602 | 1118.633 | 1117.838 | 1111.309 |  1087.242 |
| CeilingBenchmark_Double      | SumBcl               |                |               |               | 4489.973 | 4507.971 | 4482.421 |  4464.768 |
| CeilingBenchmark_Double      | SumBase              |       1335.543 |      1294.643 |      1646.570 | 4451.919 | 4510.185 | 4527.851 |  4477.845 |
| CeilingBenchmark_Double      | SumBase_Basic        |        323.938 |       509.561 |       515.332 |  510.645 |  488.486 |  515.456 |   486.994 |
| CeilingBenchmark_Double      | SumBase_ClearBit     |       1435.292 |      1276.338 |      1595.926 | 1663.011 | 1647.235 | 1843.901 |  1908.857 |
| CeilingBenchmark_Double      | SumTraits            |       1399.898 |      1268.101 |      4514.893 | 4510.425 | 4505.830 | 4500.991 |  4478.313 |
| CeilingBenchmark_Double      | Sum128Bcl            |                |               |               |          |          | 2264.167 |  2258.055 |
| CeilingBenchmark_Double      | Sum128Base_Basic     |                |               |       278.628 |  277.578 |  277.246 |  278.771 |   275.136 |
| CeilingBenchmark_Double      | Sum128Base           |                |               |       278.835 |  278.499 |  276.832 | 2269.466 |  2257.050 |
| CeilingBenchmark_Double      | Sum128Traits         |                |               |      2268.862 | 2267.803 | 2267.397 | 2263.691 |  2265.163 |
| CeilingBenchmark_Double      | Sum256Bcl            |                |               |               |          |          | 4463.718 |  4480.847 |
| CeilingBenchmark_Double      | Sum256Base_Basic     |                |               |       514.320 |  513.326 |  488.624 |  513.863 |   486.955 |
| CeilingBenchmark_Double      | Sum256Base           |                |               |       516.172 |  513.822 |  485.187 | 4500.050 |  4480.126 |
| CeilingBenchmark_Double      | Sum256Traits         |                |               |      4486.965 | 4508.094 | 4482.781 | 4506.759 |  4470.396 |
| CeilingBenchmark_Double      | Sum512Bcl            |                |               |               |          |          |          |  7723.433 |
| CeilingBenchmark_Double      | Sum512Base           |                |               |               |          |          |          |  7728.947 |
| CeilingBenchmark_Double      | Sum512Traits         |                |               |               |          |          |          |  7735.234 |
| CeilingBenchmark_Single      | SumScalar            |        519.517 |      1119.627 |      1113.013 | 1113.936 | 1116.356 | 1110.331 |  1087.957 |
| CeilingBenchmark_Single      | SumBcl               |                |               |               | 8719.789 | 8682.272 | 8497.222 |  8731.906 |
| CeilingBenchmark_Single      | SumBase              |       2691.709 |      2580.842 |      2978.817 | 8786.868 | 8777.258 | 8466.601 |  8732.772 |
| CeilingBenchmark_Single      | SumBase_Basic        |        409.263 |       831.844 |       930.352 |  938.453 |  860.462 |  899.519 |   855.852 |
| CeilingBenchmark_Single      | SumBase_ClearBit     |       2676.679 |      2580.249 |      3003.739 | 3004.028 | 2990.124 | 3519.277 |  3729.769 |
| CeilingBenchmark_Single      | SumTraits            |       2772.380 |      2492.476 |      8717.567 | 8619.946 | 8450.954 | 8811.839 |  8704.873 |
| CeilingBenchmark_Single      | Sum128Bcl            |                |               |               |          |          | 4455.047 |  4454.953 |
| CeilingBenchmark_Single      | Sum128Base_Basic     |                |               |       531.597 |  535.185 |  533.215 |  532.763 |   530.896 |
| CeilingBenchmark_Single      | Sum128Base           |                |               |       536.501 |  530.658 |  533.045 | 4379.274 |  4437.036 |
| CeilingBenchmark_Single      | Sum128Traits         |                |               |      4451.829 | 4452.020 | 4452.815 | 4447.495 |  4417.138 |
| CeilingBenchmark_Single      | Sum256Bcl            |                |               |               |          |          | 8775.347 |  8726.615 |
| CeilingBenchmark_Single      | Sum256Base_Basic     |                |               |       938.699 |  933.005 |  844.462 |  900.001 |   885.290 |
| CeilingBenchmark_Single      | Sum256Base           |                |               |       935.975 |  936.633 |  866.649 | 8611.785 |  8695.777 |
| CeilingBenchmark_Single      | Sum256Traits         |                |               |      8764.160 | 8745.291 | 8709.734 | 8534.262 |  8695.769 |
| CeilingBenchmark_Single      | Sum512Bcl            |                |               |               |          |          |          | 14788.692 |
| CeilingBenchmark_Single      | Sum512Base           |                |               |               |          |          |          | 14869.979 |
| CeilingBenchmark_Single      | Sum512Traits         |                |               |               |          |          |          | 14727.036 |
| FloorBenchmark_Double        | SumScalar            |        446.486 |      1115.384 |      1117.590 | 1108.353 | 1109.494 | 1111.129 |  1085.627 |
| FloorBenchmark_Double        | SumBcl               |                |               |               | 4509.222 | 4481.596 | 4512.605 |  4487.354 |
| FloorBenchmark_Double        | SumBase              |       1389.765 |      1296.489 |      1609.374 | 4500.136 | 4490.326 | 4476.309 |  4497.893 |
| FloorBenchmark_Double        | SumBase_Basic        |        325.116 |       505.754 |       516.189 |  508.972 |  515.467 |  507.280 |   484.510 |
| FloorBenchmark_Double        | SumBase_ClearBit     |       1476.421 |      1281.814 |      1656.870 | 1654.392 | 1598.797 | 1791.106 |  2012.084 |
| FloorBenchmark_Double        | SumTraits            |       1405.933 |      1292.472 |      4510.025 | 4502.860 | 4485.571 | 4485.451 |  4491.956 |
| FloorBenchmark_Double        | Sum128Bcl            |                |               |               |          |          | 2268.161 |  2268.322 |
| FloorBenchmark_Double        | Sum128Base_Basic     |                |               |       279.021 |  277.494 |  277.750 |  278.884 |   274.235 |
| FloorBenchmark_Double        | Sum128Base           |                |               |       278.744 |  277.837 |  276.886 | 2261.312 |  2258.839 |
| FloorBenchmark_Double        | Sum128Traits         |                |               |      2267.117 | 2271.539 | 2261.187 | 2266.328 |  2252.709 |
| FloorBenchmark_Double        | Sum256Bcl            |                |               |               |          |          | 4493.280 |  4475.997 |
| FloorBenchmark_Double        | Sum256Base_Basic     |                |               |       514.677 |  503.848 |  516.209 |  504.976 |   487.785 |
| FloorBenchmark_Double        | Sum256Base           |                |               |       515.065 |  511.014 |  514.111 | 4500.569 |  4457.743 |
| FloorBenchmark_Double        | Sum256Traits         |                |               |      4511.975 | 4496.972 | 4514.587 | 4515.254 |  4477.255 |
| FloorBenchmark_Double        | Sum512Bcl            |                |               |               |          |          |          |  7666.281 |
| FloorBenchmark_Double        | Sum512Base           |                |               |               |          |          |          |  7701.966 |
| FloorBenchmark_Double        | Sum512Traits         |                |               |               |          |          |          |  7722.285 |
| FloorBenchmark_Single        | SumScalar            |        539.951 |      1117.490 |      1116.860 | 1117.177 | 1113.074 | 1107.389 |  1085.561 |
| FloorBenchmark_Single        | SumBcl               |                |               |               | 8708.178 | 8796.019 | 8449.483 |  8724.614 |
| FloorBenchmark_Single        | SumBase              |       2674.665 |      2536.059 |      3020.682 | 8788.365 | 8754.409 | 8679.314 |  8750.346 |
| FloorBenchmark_Single        | SumBase_Basic        |        408.900 |       844.635 |       937.341 |  898.456 |  924.841 |  906.481 |   856.086 |
| FloorBenchmark_Single        | SumBase_ClearBit     |       2545.973 |      2533.667 |      2949.590 | 3115.592 | 3152.271 | 3590.516 |  4006.285 |
| FloorBenchmark_Single        | SumTraits            |       2668.103 |      2529.623 |      8776.409 | 8766.582 | 8798.479 | 8763.939 |  8737.765 |
| FloorBenchmark_Single        | Sum128Bcl            |                |               |               |          |          | 4429.010 |  4437.728 |
| FloorBenchmark_Single        | Sum128Base_Basic     |                |               |       532.283 |  530.430 |  533.615 |  534.559 |   528.619 |
| FloorBenchmark_Single        | Sum128Base           |                |               |       532.783 |  533.817 |  532.286 | 4447.329 |  4429.152 |
| FloorBenchmark_Single        | Sum128Traits         |                |               |      4437.047 | 4457.875 | 4469.266 | 4473.682 |  4426.344 |
| FloorBenchmark_Single        | Sum256Bcl            |                |               |               |          |          | 8682.283 |  8725.996 |
| FloorBenchmark_Single        | Sum256Base_Basic     |                |               |       934.300 |  905.612 |  939.909 |  896.923 |   852.377 |
| FloorBenchmark_Single        | Sum256Base           |                |               |       936.696 |  907.241 |  929.404 | 8764.382 |  8742.635 |
| FloorBenchmark_Single        | Sum256Traits         |                |               |      8753.246 | 8777.526 | 8706.537 | 8733.232 |  8643.295 |
| FloorBenchmark_Single        | Sum512Bcl            |                |               |               |          |          |          | 15060.156 |
| FloorBenchmark_Single        | Sum512Base           |                |               |               |          |          |          | 15020.267 |
| FloorBenchmark_Single        | Sum512Traits         |                |               |               |          |          |          | 15139.211 |
| YRoundToEvenBenchmark_Double | SumScalar            |        126.884 |      1115.140 |      1117.158 | 1117.892 | 1118.474 | 1111.091 |  1094.675 |
| YRoundToEvenBenchmark_Double | SumBase              |       2940.523 |      2636.358 |      3527.625 | 3477.632 | 3549.714 | 3596.652 |  3843.009 |
| YRoundToEvenBenchmark_Double | SumBase_Add          |       2959.711 |      2689.910 |      3462.001 | 3579.048 | 3741.319 | 3315.779 |  3766.970 |
| YRoundToEvenBenchmark_Double | SumTraits            |       2924.023 |      2677.199 |      4479.081 | 4505.682 | 4501.004 | 4464.953 |  4519.018 |
| YRoundToEvenBenchmark_Double | Sum128Base_Basic     |                |               |       277.803 |  276.708 |  278.450 |  277.870 |   277.492 |
| YRoundToEvenBenchmark_Double | Sum128Base           |                |               |       278.378 |  276.446 |  278.491 | 1939.283 |  1723.291 |
| YRoundToEvenBenchmark_Double | Sum128Traits         |                |               |      2260.092 | 2264.366 | 2270.445 | 2256.209 |  2269.467 |
| YRoundToEvenBenchmark_Double | Sum256Base_Basic     |                |               |       514.410 |  508.834 |  514.855 |  487.231 |   511.245 |
| YRoundToEvenBenchmark_Double | Sum256Base           |                |               |       513.926 |  509.266 |  516.612 | 3675.536 |  3672.362 |
| YRoundToEvenBenchmark_Double | Sum256Traits         |                |               |      4505.461 | 4491.675 | 4503.320 | 4482.124 |  4544.186 |
| YRoundToEvenBenchmark_Double | Sum512Base           |                |               |               |          |          |          |  4276.062 |
| YRoundToEvenBenchmark_Double | Sum512Traits         |                |               |               |          |          |          |  8144.576 |
| YRoundToEvenBenchmark_Single | SumScalar            |        133.419 |      1114.327 |      1116.987 | 1110.035 | 1117.447 | 1117.337 |  1094.046 |
| YRoundToEvenBenchmark_Single | SumBase              |       5558.990 |      5661.500 |      6989.347 | 7175.487 | 6815.641 | 6788.431 |  7126.659 |
| YRoundToEvenBenchmark_Single | SumBase_Add          |       5597.585 |      5590.835 |      6859.990 | 7090.888 | 7236.071 | 6601.339 |  7073.163 |
| YRoundToEvenBenchmark_Single | SumTraits            |       5531.812 |      5531.160 |      8756.991 | 8790.145 | 8694.942 | 8625.540 |  8938.254 |
| YRoundToEvenBenchmark_Single | Sum128Base_Basic     |                |               |       531.916 |  530.053 |  535.044 |  532.854 |   529.509 |
| YRoundToEvenBenchmark_Single | Sum128Base           |                |               |       533.064 |  531.919 |  533.098 | 3721.782 |  3675.925 |
| YRoundToEvenBenchmark_Single | Sum128Traits         |                |               |      4453.993 | 4427.968 | 4422.343 | 4416.710 |  4539.828 |
| YRoundToEvenBenchmark_Single | Sum256Base_Basic     |                |               |       938.443 |  902.025 |  934.308 |  858.117 |   933.428 |
| YRoundToEvenBenchmark_Single | Sum256Base           |                |               |       934.916 |  900.902 |  935.897 | 7078.442 |  7142.648 |
| YRoundToEvenBenchmark_Single | Sum256Traits         |                |               |      8765.312 | 8926.301 | 8811.958 | 8726.256 |  8991.935 |
| YRoundToEvenBenchmark_Single | Sum512Base           |                |               |               |          |          |          |  8032.437 |
| YRoundToEvenBenchmark_Single | Sum512Traits         |                |               |               |          |          |          | 15581.826 |
| YRoundToZeroBenchmark_Double | SumScalar            |        228.820 |       205.156 |       183.680 |  185.606 |  183.493 | 1115.277 |  1102.091 |
| YRoundToZeroBenchmark_Double | SumBase              |       2144.962 |      2018.238 |      2415.164 | 4110.783 | 4205.346 | 4056.570 |  4371.441 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit     |       2098.362 |      1870.781 |      2302.139 | 2389.750 | 2470.666 | 2739.370 |  2565.897 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit_Not |       2123.982 |      1990.840 |      2183.155 | 2269.258 | 2223.790 | 2211.263 |  2458.784 |
| YRoundToZeroBenchmark_Double | SumTraits            |       2093.857 |      1913.341 |      4493.430 | 4489.716 | 4491.105 | 4466.066 |  4541.196 |
| YRoundToZeroBenchmark_Double | Sum128Base_Basic     |                |               |       173.772 |  172.112 |  175.781 |  277.289 |   277.505 |
| YRoundToZeroBenchmark_Double | Sum128Base           |                |               |       176.379 |  170.615 |  176.156 | 2208.091 |  2213.788 |
| YRoundToZeroBenchmark_Double | Sum128Traits         |                |               |      2263.160 | 2264.337 | 2271.080 | 2258.920 |  2280.565 |
| YRoundToZeroBenchmark_Double | Sum256Base_Basic     |                |               |       206.832 |  200.176 |  216.563 |  487.135 |   508.605 |
| YRoundToZeroBenchmark_Double | Sum256Base           |                |               |       203.547 |  200.404 |  209.261 | 4293.485 |  4371.142 |
| YRoundToZeroBenchmark_Double | Sum256Traits         |                |               |      4495.109 | 4505.136 | 4482.296 | 4468.329 |  4532.483 |
| YRoundToZeroBenchmark_Double | Sum512Base           |                |               |               |          |          |          |  6337.014 |
| YRoundToZeroBenchmark_Double | Sum512Traits         |                |               |               |          |          |          |  8113.934 |
| YRoundToZeroBenchmark_Single | SumScalar            |        127.097 |       217.013 |       228.912 |  218.821 |  213.038 | 1113.113 |  1100.331 |
| YRoundToZeroBenchmark_Single | SumBase              |       4283.817 |      3953.042 |      4480.716 | 8091.964 | 8151.873 | 7758.786 |  8537.261 |
| YRoundToZeroBenchmark_Single | SumBase_ClearBit     |       4021.699 |      3751.477 |      4488.857 | 4548.546 | 4680.523 | 5383.849 |  5095.842 |
| YRoundToZeroBenchmark_Single | SumTraits            |       4129.465 |      3733.133 |      8823.862 | 8742.571 | 8782.919 | 8656.281 |  8957.758 |
| YRoundToZeroBenchmark_Single | Sum128Base_Basic     |                |               |       226.343 |  224.923 |  230.088 |  532.944 |   531.977 |
| YRoundToZeroBenchmark_Single | Sum128Base           |                |               |       230.513 |  222.135 |  217.778 | 4300.798 |  4356.414 |
| YRoundToZeroBenchmark_Single | Sum128Traits         |                |               |      4443.007 | 4482.511 | 4454.165 | 4425.601 |  4526.601 |
| YRoundToZeroBenchmark_Single | Sum256Base_Basic     |                |               |       215.984 |  217.198 |  210.861 |  862.185 |   927.927 |
| YRoundToZeroBenchmark_Single | Sum256Base           |                |               |       218.183 |  209.643 |  219.600 | 8255.089 |  8587.412 |
| YRoundToZeroBenchmark_Single | Sum256Traits         |                |               |      8476.692 | 8628.577 | 8701.146 | 8713.616 |  8987.733 |
| YRoundToZeroBenchmark_Single | Sum512Base           |                |               |               |          |          |          | 12168.669 |
| YRoundToZeroBenchmark_Single | Sum512Traits         |                |               |               |          |          |          | 15331.602 |

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

### Arm - Apple M2
| Type                         | Method               | .NET 6.0 | .NET 7.0 |  .NET 8.0 |
| :--------------------------- | :------------------- | -------: | -------: | --------: |
| CeilingBenchmark_Double      | SumScalar            | 1166.170 | 1133.659 |  1134.063 |
| CeilingBenchmark_Double      | SumBcl               | 2330.068 | 2268.394 |  2268.040 |
| CeilingBenchmark_Double      | SumBase              | 2333.607 | 2267.923 |  2268.002 |
| CeilingBenchmark_Double      | SumBase_Basic        | 1742.204 | 2069.166 |  2067.245 |
| CeilingBenchmark_Double      | SumBase_ClearBit     | 1180.150 | 1674.889 |  1642.247 |
| CeilingBenchmark_Double      | SumTraits            | 2333.082 | 2268.415 |  2268.110 |
| CeilingBenchmark_Double      | Sum128Bcl            |          | 2268.015 |  2268.480 |
| CeilingBenchmark_Double      | Sum128Base_Basic     | 2035.285 | 2146.008 |  2071.165 |
| CeilingBenchmark_Double      | Sum128Base           | 2011.845 | 2267.330 |  2268.279 |
| CeilingBenchmark_Double      | Sum128Traits         | 2298.017 | 2268.265 |  2267.833 |
| CeilingBenchmark_Double      | Sum256Bcl            |          |  413.837 |  4536.986 |
| CeilingBenchmark_Double      | Sum256Base_Basic     |  326.946 |  488.078 |  2326.359 |
| CeilingBenchmark_Double      | Sum256Base           |  322.146 |  453.425 |  4537.079 |
| CeilingBenchmark_Double      | Sum256Traits         |  326.498 |  455.393 |  4536.479 |
| CeilingBenchmark_Double      | Sum512Bcl            |          |          |  9040.096 |
| CeilingBenchmark_Double      | Sum512Base           |          |          |  9044.157 |
| CeilingBenchmark_Double      | Sum512Traits         |          |          |  9040.599 |
| CeilingBenchmark_Single      | SumScalar            | 1160.920 | 1134.114 |  1165.974 |
| CeilingBenchmark_Single      | SumBcl               | 4659.440 | 4537.048 |  4665.305 |
| CeilingBenchmark_Single      | SumBase              | 4669.363 | 4537.653 |  4538.480 |
| CeilingBenchmark_Single      | SumBase_Basic        | 1890.322 | 2150.538 |  2260.758 |
| CeilingBenchmark_Single      | SumBase_ClearBit     | 2364.272 | 3347.888 |  3298.593 |
| CeilingBenchmark_Single      | SumTraits            | 4665.693 | 4537.124 |  4537.433 |
| CeilingBenchmark_Single      | Sum128Bcl            |          | 4537.953 |  4538.086 |
| CeilingBenchmark_Single      | Sum128Base_Basic     | 3026.499 | 3203.063 |  3199.344 |
| CeilingBenchmark_Single      | Sum128Base           | 3021.772 | 4537.629 |  4538.564 |
| CeilingBenchmark_Single      | Sum128Traits         | 4446.558 | 4537.634 |  4537.390 |
| CeilingBenchmark_Single      | Sum256Bcl            |          |  874.165 |  9078.047 |
| CeilingBenchmark_Single      | Sum256Base_Basic     |  692.263 |  804.249 |  3083.561 |
| CeilingBenchmark_Single      | Sum256Base           |  692.560 |  803.041 |  9076.936 |
| CeilingBenchmark_Single      | Sum256Traits         |  692.394 |  802.626 |  9052.529 |
| CeilingBenchmark_Single      | Sum512Bcl            |          |          | 18084.328 |
| CeilingBenchmark_Single      | Sum512Base           |          |          | 18086.188 |
| CeilingBenchmark_Single      | Sum512Traits         |          |          | 18082.379 |
| FloorBenchmark_Double        | SumScalar            | 1133.091 | 1133.915 |  1133.939 |
| FloorBenchmark_Double        | SumBcl               | 2266.963 | 2268.143 |  2267.868 |
| FloorBenchmark_Double        | SumBase              | 2267.596 | 2268.265 |  2267.657 |
| FloorBenchmark_Double        | SumBase_Basic        | 1743.252 | 2070.847 |  2066.363 |
| FloorBenchmark_Double        | SumBase_ClearBit     | 1181.787 | 1675.287 |  1647.634 |
| FloorBenchmark_Double        | SumTraits            | 2267.343 | 2268.410 |  2268.642 |
| FloorBenchmark_Double        | Sum128Bcl            |          | 2267.936 |  2268.194 |
| FloorBenchmark_Double        | Sum128Base_Basic     | 2072.058 | 2144.218 |  2116.924 |
| FloorBenchmark_Double        | Sum128Base           | 2069.043 | 2268.001 |  2268.568 |
| FloorBenchmark_Double        | Sum128Traits         | 2267.170 | 2268.005 |  2268.450 |
| FloorBenchmark_Double        | Sum256Bcl            |          |  413.324 |  4536.793 |
| FloorBenchmark_Double        | Sum256Base_Basic     |  318.107 |  488.006 |  2341.045 |
| FloorBenchmark_Double        | Sum256Base           |  311.834 |  455.456 |  4536.962 |
| FloorBenchmark_Double        | Sum256Traits         |  318.303 |  453.184 |  4536.498 |
| FloorBenchmark_Double        | Sum512Bcl            |          |          |  9038.748 |
| FloorBenchmark_Double        | Sum512Base           |          |          |  9040.194 |
| FloorBenchmark_Double        | Sum512Traits         |          |          |  9040.959 |
| FloorBenchmark_Single        | SumScalar            | 1133.336 | 1165.874 |  1150.617 |
| FloorBenchmark_Single        | SumBcl               | 4535.650 | 4664.594 |  4666.221 |
| FloorBenchmark_Single        | SumBase              | 4534.601 | 4656.980 |  4665.538 |
| FloorBenchmark_Single        | SumBase_Basic        | 1849.329 | 2172.152 |  2261.411 |
| FloorBenchmark_Single        | SumBase_ClearBit     | 2363.468 | 3353.721 |  3296.607 |
| FloorBenchmark_Single        | SumTraits            | 4558.537 | 4538.079 |  4665.273 |
| FloorBenchmark_Single        | Sum128Bcl            |          | 4665.798 |  4665.528 |
| FloorBenchmark_Single        | Sum128Base_Basic     | 3014.110 | 3205.488 |  3194.279 |
| FloorBenchmark_Single        | Sum128Base           | 3019.183 | 4538.254 |  4664.997 |
| FloorBenchmark_Single        | Sum128Traits         | 4589.208 | 4544.123 |  4665.371 |
| FloorBenchmark_Single        | Sum256Bcl            |          |  875.205 |  9076.031 |
| FloorBenchmark_Single        | Sum256Base_Basic     |  691.021 |  805.359 |  3088.855 |
| FloorBenchmark_Single        | Sum256Base           |  690.899 |  803.853 |  9077.234 |
| FloorBenchmark_Single        | Sum256Traits         |  690.829 |  803.642 |  9077.238 |
| FloorBenchmark_Single        | Sum512Bcl            |          |          | 18068.891 |
| FloorBenchmark_Single        | Sum512Base           |          |          | 18069.384 |
| FloorBenchmark_Single        | Sum512Traits         |          |          | 18068.209 |
| YRoundToEvenBenchmark_Double | SumScalar            | 1133.916 | 1165.909 |  1134.030 |
| YRoundToEvenBenchmark_Double | SumBase              | 2266.849 | 2267.098 |  2267.166 |
| YRoundToEvenBenchmark_Double | SumBase_Add          | 2267.202 | 2267.862 |  2267.319 |
| YRoundToEvenBenchmark_Double | SumTraits            | 2267.908 | 2309.058 |  2267.842 |
| YRoundToEvenBenchmark_Double | Sum128Base_Basic     | 2136.812 | 2146.172 |  2116.346 |
| YRoundToEvenBenchmark_Double | Sum128Base           | 2059.372 | 2267.542 |  2267.386 |
| YRoundToEvenBenchmark_Double | Sum128Traits         | 2267.956 | 2292.812 |  2268.713 |
| YRoundToEvenBenchmark_Double | Sum256Base_Basic     |  310.459 |  487.798 |  2329.336 |
| YRoundToEvenBenchmark_Double | Sum256Base           |  318.013 |   94.550 |  3345.017 |
| YRoundToEvenBenchmark_Double | Sum256Traits         |  315.465 |   94.539 |  3350.064 |
| YRoundToEvenBenchmark_Double | Sum512Base           |          |          |   269.767 |
| YRoundToEvenBenchmark_Double | Sum512Traits         |          |          |   269.705 |
| YRoundToEvenBenchmark_Single | SumScalar            | 1134.083 | 1165.822 |  1134.074 |
| YRoundToEvenBenchmark_Single | SumBase              | 4534.375 | 4533.397 |  4534.094 |
| YRoundToEvenBenchmark_Single | SumBase_Add          | 4534.295 | 4533.986 |  4534.464 |
| YRoundToEvenBenchmark_Single | SumTraits            | 4537.466 | 4664.377 |  4539.175 |
| YRoundToEvenBenchmark_Single | Sum128Base_Basic     | 3022.287 | 3208.833 |  3218.367 |
| YRoundToEvenBenchmark_Single | Sum128Base           | 3018.272 | 4533.888 |  4534.349 |
| YRoundToEvenBenchmark_Single | Sum128Traits         | 4538.083 | 4658.421 |  4539.265 |
| YRoundToEvenBenchmark_Single | Sum256Base_Basic     |  691.204 |  804.303 |  3096.753 |
| YRoundToEvenBenchmark_Single | Sum256Base           |  691.516 |  149.442 |  6796.080 |
| YRoundToEvenBenchmark_Single | Sum256Traits         |  689.605 |  149.347 |  6795.666 |
| YRoundToEvenBenchmark_Single | Sum512Base           |          |          |   510.561 |
| YRoundToEvenBenchmark_Single | Sum512Traits         |          |          |   518.504 |
| YRoundToZeroBenchmark_Double | SumScalar            |  345.752 | 1165.857 |  1134.093 |
| YRoundToZeroBenchmark_Double | SumBase              | 2267.127 | 2267.372 |  2267.594 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit     | 1696.589 | 2175.708 |  2229.711 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit_Not | 1511.486 | 1942.622 |  2019.523 |
| YRoundToZeroBenchmark_Double | SumTraits            | 2268.158 | 2331.616 |  2268.254 |
| YRoundToZeroBenchmark_Double | Sum128Base_Basic     |  365.270 | 2145.289 |  2116.198 |
| YRoundToZeroBenchmark_Double | Sum128Base           |  365.233 | 2266.923 |  2267.825 |
| YRoundToZeroBenchmark_Double | Sum128Traits         | 2268.130 | 2332.260 |  2267.986 |
| YRoundToZeroBenchmark_Double | Sum256Base_Basic     |  313.865 |  487.847 |  2328.225 |
| YRoundToZeroBenchmark_Double | Sum256Base           |  319.623 |  153.004 |  4527.832 |
| YRoundToZeroBenchmark_Double | Sum256Traits         |  316.322 |  152.695 |  4529.408 |
| YRoundToZeroBenchmark_Double | Sum512Base           |          |          |  1119.596 |
| YRoundToZeroBenchmark_Double | Sum512Traits         |          |          |  1119.055 |
| YRoundToZeroBenchmark_Single | SumScalar            |  352.952 | 1165.936 |  1133.852 |
| YRoundToZeroBenchmark_Single | SumBase              | 4535.268 | 4535.856 |  4536.503 |
| YRoundToZeroBenchmark_Single | SumBase_ClearBit     | 3400.610 | 4351.378 |  4522.788 |
| YRoundToZeroBenchmark_Single | SumTraits            | 4538.052 | 4538.051 |  4539.069 |
| YRoundToZeroBenchmark_Single | Sum128Base_Basic     |  383.857 | 3209.493 |  3213.131 |
| YRoundToZeroBenchmark_Single | Sum128Base           |  383.750 | 4536.103 |  4536.424 |
| YRoundToZeroBenchmark_Single | Sum128Traits         | 4537.875 | 4537.957 |  4539.423 |
| YRoundToZeroBenchmark_Single | Sum256Base_Basic     |  363.917 |  804.055 |  3086.538 |
| YRoundToZeroBenchmark_Single | Sum256Base           |  368.446 |  323.186 |  9058.806 |
| YRoundToZeroBenchmark_Single | Sum256Traits         |  368.491 |  323.009 |  9065.069 |
| YRoundToZeroBenchmark_Single | Sum512Base           |          |          |  2009.435 |
| YRoundToZeroBenchmark_Single | Sum512Traits         |          |          |  1970.988 |

### Arm - AWS Arm t4g.small
| Type                         | Method               | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 | .NET 8.0 |
| :--------------------------- | :------------------- | ------------: | -------: | -------: | -------: | -------: |
| CeilingBenchmark_Double      | SumScalar            |       900.649 |  828.695 |  901.440 | 1242.698 | 1243.712 |
| CeilingBenchmark_Double      | SumBcl               |               | 1971.016 | 1968.816 | 2475.688 | 2445.025 |
| CeilingBenchmark_Double      | SumBase              |       472.355 | 1971.962 | 2097.476 | 2476.068 | 2446.499 |
| CeilingBenchmark_Double      | SumBase_Basic        |       482.252 |  476.019 |  481.929 |  470.756 |  470.970 |
| CeilingBenchmark_Double      | SumBase_ClearBit     |       290.019 |  321.120 |  343.145 |  391.618 |  395.068 |
| CeilingBenchmark_Double      | SumTraits            |       477.038 | 2101.631 | 2102.980 | 2472.734 | 2432.257 |
| CeilingBenchmark_Double      | Sum128Bcl            |               |          |          | 2478.700 | 2435.450 |
| CeilingBenchmark_Double      | Sum128Base_Basic     |       251.183 |  471.275 |  471.975 |  473.660 |  470.128 |
| CeilingBenchmark_Double      | Sum128Base           |       251.431 |  469.674 |  470.565 | 2474.366 | 2377.245 |
| CeilingBenchmark_Double      | Sum128Traits         |       250.018 | 1967.362 | 1969.581 | 2477.509 | 2433.712 |
| CeilingBenchmark_Double      | Sum256Bcl            |               |          |          |  269.893 | 3346.363 |
| CeilingBenchmark_Double      | Sum256Base_Basic     |       148.818 |  213.404 |  212.497 |  226.142 |  651.883 |
| CeilingBenchmark_Double      | Sum256Base           |       148.630 |  214.305 |  213.700 |  227.509 | 3354.672 |
| CeilingBenchmark_Double      | Sum256Traits         |       148.152 |  214.884 |  214.350 |  227.671 | 3347.693 |
| CeilingBenchmark_Double      | Sum512Bcl            |               |          |          |          | 3388.202 |
| CeilingBenchmark_Double      | Sum512Base           |               |          |          |          | 3378.592 |
| CeilingBenchmark_Double      | Sum512Traits         |               |          |          |          | 3380.679 |
| CeilingBenchmark_Single      | SumScalar            |       828.623 |  902.207 |  901.483 | 1243.849 | 1243.867 |
| CeilingBenchmark_Single      | SumBcl               |               | 4206.888 | 4235.664 | 4828.059 | 4886.205 |
| CeilingBenchmark_Single      | SumBase              |       557.149 | 4214.430 | 3953.993 | 4828.066 | 4885.701 |
| CeilingBenchmark_Single      | SumBase_Basic        |       318.341 |  328.300 |  327.883 |  326.926 |  328.024 |
| CeilingBenchmark_Single      | SumBase_ClearBit     |       559.777 |  656.997 |  713.013 |  743.501 |  844.562 |
| CeilingBenchmark_Single      | SumTraits            |       554.617 | 3931.869 | 4233.135 | 4830.974 | 4883.976 |
| CeilingBenchmark_Single      | Sum128Bcl            |               |          |          | 4827.104 | 4883.449 |
| CeilingBenchmark_Single      | Sum128Base_Basic     |       176.490 |  314.572 |  314.397 |  325.314 |  324.380 |
| CeilingBenchmark_Single      | Sum128Base           |       177.669 |  314.246 |  314.443 | 4826.005 | 4889.265 |
| CeilingBenchmark_Single      | Sum128Traits         |       179.917 | 4228.566 | 4228.190 | 4804.750 | 4857.623 |
| CeilingBenchmark_Single      | Sum256Bcl            |               |          |          |  292.603 | 4778.182 |
| CeilingBenchmark_Single      | Sum256Base_Basic     |       210.261 |  273.556 |  272.045 |  258.881 |  556.610 |
| CeilingBenchmark_Single      | Sum256Base           |       202.782 |  265.048 |  263.820 |  280.023 | 4782.663 |
| CeilingBenchmark_Single      | Sum256Traits         |       204.551 |  264.410 |  265.004 |  280.206 | 4775.646 |
| CeilingBenchmark_Single      | Sum512Bcl            |               |          |          |          | 4679.631 |
| CeilingBenchmark_Single      | Sum512Base           |               |          |          |          | 4668.649 |
| CeilingBenchmark_Single      | Sum512Traits         |               |          |          |          | 4649.159 |
| FloorBenchmark_Double        | SumScalar            |       818.725 |  901.510 |  901.298 | 1243.245 | 1243.769 |
| FloorBenchmark_Double        | SumBcl               |               | 2103.178 | 1966.670 | 2473.674 | 2442.751 |
| FloorBenchmark_Double        | SumBase              |       484.468 | 2100.754 | 2102.663 | 2476.676 | 2443.549 |
| FloorBenchmark_Double        | SumBase_Basic        |       206.054 |  475.250 |  481.174 |  470.733 |  476.530 |
| FloorBenchmark_Double        | SumBase_ClearBit     |       287.471 |  320.528 |  344.167 |  388.289 |  398.756 |
| FloorBenchmark_Double        | SumTraits            |       203.782 | 2103.785 | 1970.933 | 2471.610 | 2426.687 |
| FloorBenchmark_Double        | Sum128Bcl            |               |          |          | 2476.722 | 2426.772 |
| FloorBenchmark_Double        | Sum128Base_Basic     |       246.545 |  469.895 |  471.263 |  474.945 |  470.298 |
| FloorBenchmark_Double        | Sum128Base           |       246.396 |  467.566 |  471.513 | 2474.566 | 2434.145 |
| FloorBenchmark_Double        | Sum128Traits         |       252.151 | 1970.418 | 2101.177 | 2479.240 | 2435.621 |
| FloorBenchmark_Double        | Sum256Bcl            |               |          |          |  269.692 | 3363.920 |
| FloorBenchmark_Double        | Sum256Base_Basic     |       144.443 |  213.779 |  214.497 |  226.019 |  638.903 |
| FloorBenchmark_Double        | Sum256Base           |       146.876 |  214.055 |  213.181 |  227.571 | 3356.684 |
| FloorBenchmark_Double        | Sum256Traits         |       145.637 |  215.430 |  213.962 |  227.829 | 3362.757 |
| FloorBenchmark_Double        | Sum512Bcl            |               |          |          |          | 3382.358 |
| FloorBenchmark_Double        | Sum512Base           |               |          |          |          | 3379.894 |
| FloorBenchmark_Double        | Sum512Traits         |               |          |          |          | 3396.402 |
| FloorBenchmark_Single        | SumScalar            |       895.723 |  828.181 |  828.238 | 1242.733 | 1243.992 |
| FloorBenchmark_Single        | SumBcl               |               | 4214.356 | 3960.468 | 4813.179 | 4887.429 |
| FloorBenchmark_Single        | SumBase              |       552.618 | 4241.078 | 4224.856 | 4819.162 | 4884.052 |
| FloorBenchmark_Single        | SumBase_Basic        |       315.921 |  328.528 |  327.753 |  326.466 |  328.593 |
| FloorBenchmark_Single        | SumBase_ClearBit     |       546.775 |  657.463 |  712.892 |  740.394 |  840.410 |
| FloorBenchmark_Single        | SumTraits            |       549.377 | 3954.980 | 3956.107 | 4804.987 | 4884.986 |
| FloorBenchmark_Single        | Sum128Bcl            |               |          |          | 4813.831 | 4884.996 |
| FloorBenchmark_Single        | Sum128Base_Basic     |       178.326 |  314.462 |  314.290 |  325.319 |  324.717 |
| FloorBenchmark_Single        | Sum128Base           |       178.293 |  313.870 |  314.149 | 4815.457 | 4854.967 |
| FloorBenchmark_Single        | Sum128Traits         |       177.989 | 4212.754 | 4231.867 | 4802.528 | 4882.401 |
| FloorBenchmark_Single        | Sum256Bcl            |               |          |          |  290.759 | 4783.443 |
| FloorBenchmark_Single        | Sum256Base_Basic     |       204.137 |  273.623 |  272.012 |  259.386 |  551.752 |
| FloorBenchmark_Single        | Sum256Base           |       199.697 |  264.301 |  263.967 |  279.957 | 4788.635 |
| FloorBenchmark_Single        | Sum256Traits         |       200.119 |  264.884 |  264.385 |  279.568 | 4779.687 |
| FloorBenchmark_Single        | Sum512Bcl            |               |          |          |          | 4670.053 |
| FloorBenchmark_Single        | Sum512Base           |               |          |          |          | 4677.017 |
| FloorBenchmark_Single        | Sum512Traits         |               |          |          |          | 4674.595 |
| YRoundToEvenBenchmark_Double | SumScalar            |       828.965 |  902.443 |  829.221 | 1242.218 | 1243.132 |
| YRoundToEvenBenchmark_Double | SumBase              |       742.072 |  730.824 |  751.880 |  791.534 |  915.770 |
| YRoundToEvenBenchmark_Double | SumBase_Add          |       740.037 |  731.800 |  751.874 |  790.029 |  916.493 |
| YRoundToEvenBenchmark_Double | SumTraits            |       742.036 | 2101.767 | 2103.964 | 2468.189 | 2429.434 |
| YRoundToEvenBenchmark_Double | Sum128Base_Basic     |       249.149 |  469.700 |  471.311 |  473.875 |  467.864 |
| YRoundToEvenBenchmark_Double | Sum128Base           |       250.356 |  469.588 |  471.227 | 1019.449 |  919.491 |
| YRoundToEvenBenchmark_Double | Sum128Traits         |       251.094 | 1966.244 | 1968.811 | 2466.738 | 2432.368 |
| YRoundToEvenBenchmark_Double | Sum256Base_Basic     |       149.360 |  214.089 |  214.321 |  226.834 |  633.906 |
| YRoundToEvenBenchmark_Double | Sum256Base           |       149.369 |  215.319 |  213.966 |   49.820 | 1044.678 |
| YRoundToEvenBenchmark_Double | Sum256Traits         |       148.926 |  214.896 |  213.882 |   49.558 | 1045.370 |
| YRoundToEvenBenchmark_Double | Sum512Base           |               |          |          |          |  132.852 |
| YRoundToEvenBenchmark_Double | Sum512Traits         |               |          |          |          |  132.846 |
| YRoundToEvenBenchmark_Single | SumScalar            |       902.703 |  827.520 |  829.213 | 1231.907 | 1243.686 |
| YRoundToEvenBenchmark_Single | SumBase              |      1432.968 | 1473.490 | 1533.566 | 1542.954 | 1977.927 |
| YRoundToEvenBenchmark_Single | SumBase_Add          |      1443.292 | 1469.131 | 1534.795 | 1541.802 | 1975.313 |
| YRoundToEvenBenchmark_Single | SumTraits            |      1434.315 | 4213.338 | 3951.605 | 4786.917 | 4865.757 |
| YRoundToEvenBenchmark_Single | Sum128Base_Basic     |       179.261 |  314.415 |  314.430 |  325.158 |  324.180 |
| YRoundToEvenBenchmark_Single | Sum128Base           |       180.686 |  315.066 |  314.194 | 1858.699 | 1980.277 |
| YRoundToEvenBenchmark_Single | Sum128Traits         |       180.617 | 3949.155 | 4239.569 | 4713.578 | 4861.614 |
| YRoundToEvenBenchmark_Single | Sum256Base_Basic     |       208.102 |  271.949 |  272.051 |  258.931 |  556.520 |
| YRoundToEvenBenchmark_Single | Sum256Base           |       204.581 |  264.657 |  264.864 |   65.846 | 2125.645 |
| YRoundToEvenBenchmark_Single | Sum256Traits         |       204.542 |  264.269 |  264.054 |   65.860 | 2131.759 |
| YRoundToEvenBenchmark_Single | Sum512Base           |               |          |          |          |  254.587 |
| YRoundToEvenBenchmark_Single | Sum512Traits         |               |          |          |          |  254.495 |
| YRoundToZeroBenchmark_Double | SumScalar            |       161.970 |  162.370 |  152.293 | 1243.469 | 1243.980 |
| YRoundToZeroBenchmark_Double | SumBase              |       496.413 | 1079.684 | 1092.110 | 1235.079 | 1475.699 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit     |       493.018 |  496.989 |  538.281 |  605.761 |  604.311 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit_Not |       419.435 |  443.044 |  473.640 |  524.969 |  531.119 |
| YRoundToZeroBenchmark_Double | SumTraits            |       491.860 | 2097.093 | 1972.003 | 2472.341 | 2428.648 |
| YRoundToZeroBenchmark_Double | Sum128Base_Basic     |       123.622 |  149.846 |  155.903 |  469.719 |  468.916 |
| YRoundToZeroBenchmark_Double | Sum128Base           |       127.218 |  155.175 |  153.032 | 1608.132 | 1480.799 |
| YRoundToZeroBenchmark_Double | Sum128Traits         |       124.506 | 1971.661 | 2099.284 | 2474.605 | 2432.196 |
| YRoundToZeroBenchmark_Double | Sum256Base_Basic     |        83.406 |  112.712 |  112.776 |  227.324 |  644.278 |
| YRoundToZeroBenchmark_Double | Sum256Base           |        81.347 |  113.960 |  112.348 |   82.880 | 1654.800 |
| YRoundToZeroBenchmark_Double | Sum256Traits         |        81.353 |  114.585 |  111.954 |   82.725 | 1653.318 |
| YRoundToZeroBenchmark_Double | Sum512Base           |               |          |          |          |  508.976 |
| YRoundToZeroBenchmark_Double | Sum512Traits         |               |          |          |          |  508.124 |
| YRoundToZeroBenchmark_Single | SumScalar            |       158.853 |  149.031 |  149.208 | 1243.567 | 1244.256 |
| YRoundToZeroBenchmark_Single | SumBase              |       973.956 | 2185.952 | 2175.778 | 2333.964 | 3015.395 |
| YRoundToZeroBenchmark_Single | SumBase_ClearBit     |       971.280 | 1031.752 | 1125.061 | 1153.694 | 1310.633 |
| YRoundToZeroBenchmark_Single | SumTraits            |       975.765 | 3942.155 | 4195.801 | 4795.365 | 4863.135 |
| YRoundToZeroBenchmark_Single | Sum128Base_Basic     |       107.163 |  149.471 |  155.074 |  324.926 |  320.847 |
| YRoundToZeroBenchmark_Single | Sum128Base           |       107.119 |  155.161 |  150.968 | 2766.401 | 3040.971 |
| YRoundToZeroBenchmark_Single | Sum128Traits         |       107.629 | 4209.593 | 3959.531 | 4791.564 | 4850.245 |
| YRoundToZeroBenchmark_Single | Sum256Base_Basic     |        94.129 |  115.181 |  115.988 |  258.717 |  554.730 |
| YRoundToZeroBenchmark_Single | Sum256Base           |        95.231 |  117.267 |  117.473 |  116.820 | 3091.158 |
| YRoundToZeroBenchmark_Single | Sum256Traits         |        94.548 |  116.902 |  115.428 |  116.813 | 3088.073 |
| YRoundToZeroBenchmark_Single | Sum512Base           |               |          |          |          |  842.505 |
| YRoundToZeroBenchmark_Single | Sum512Traits         |               |          |          |          |  839.610 |

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                         | Method               | .NET 8.0 |
| :--------------------------- | :------------------- | -------: |
| CeilingBenchmark_Double      | SumScalar            |   41.161 |
| CeilingBenchmark_Double      | SumBcl               |   20.547 |
| CeilingBenchmark_Double      | SumBase              |   20.579 |
| CeilingBenchmark_Double      | SumBase_Basic        |   24.978 |
| CeilingBenchmark_Double      | SumBase_ClearBit     |    2.735 |
| CeilingBenchmark_Double      | SumTraits            |  103.680 |
| CeilingBenchmark_Double      | Sum128Bcl            |   28.314 |
| CeilingBenchmark_Double      | Sum128Base_Basic     |   74.257 |
| CeilingBenchmark_Double      | Sum128Base           |   29.534 |
| CeilingBenchmark_Double      | Sum128Traits         |  113.054 |
| CeilingBenchmark_Double      | Sum256Bcl            |    7.997 |
| CeilingBenchmark_Double      | Sum256Base_Basic     |   11.863 |
| CeilingBenchmark_Double      | Sum256Base           |    8.147 |
| CeilingBenchmark_Double      | Sum256Traits         |    3.921 |
| CeilingBenchmark_Double      | Sum512Bcl            |    5.193 |
| CeilingBenchmark_Double      | Sum512Base           |    4.934 |
| CeilingBenchmark_Double      | Sum512Traits         |    4.448 |
| CeilingBenchmark_Single      | SumScalar            |   26.193 |
| CeilingBenchmark_Single      | SumBcl               |   36.655 |
| CeilingBenchmark_Single      | SumBase              |   35.841 |
| CeilingBenchmark_Single      | SumBase_Basic        |   57.371 |
| CeilingBenchmark_Single      | SumBase_ClearBit     |    3.845 |
| CeilingBenchmark_Single      | SumTraits            |  208.521 |
| CeilingBenchmark_Single      | Sum128Bcl            |   39.266 |
| CeilingBenchmark_Single      | Sum128Base_Basic     |  105.794 |
| CeilingBenchmark_Single      | Sum128Base           |   38.035 |
| CeilingBenchmark_Single      | Sum128Traits         |  214.063 |
| CeilingBenchmark_Single      | Sum256Bcl            |   33.678 |
| CeilingBenchmark_Single      | Sum256Base_Basic     |  108.392 |
| CeilingBenchmark_Single      | Sum256Base           |   33.622 |
| CeilingBenchmark_Single      | Sum256Traits         |   33.035 |
| CeilingBenchmark_Single      | Sum512Bcl            |   17.848 |
| CeilingBenchmark_Single      | Sum512Base           |   17.377 |
| CeilingBenchmark_Single      | Sum512Traits         |   18.466 |
| FloorBenchmark_Double        | SumScalar            |   46.423 |
| FloorBenchmark_Double        | SumBcl               |   22.010 |
| FloorBenchmark_Double        | SumBase              |   21.948 |
| FloorBenchmark_Double        | SumBase_Basic        |   28.068 |
| FloorBenchmark_Double        | SumBase_ClearBit     |    2.964 |
| FloorBenchmark_Double        | SumTraits            |  113.105 |
| FloorBenchmark_Double        | Sum128Bcl            |   31.872 |
| FloorBenchmark_Double        | Sum128Base_Basic     |   81.720 |
| FloorBenchmark_Double        | Sum128Base           |   31.532 |
| FloorBenchmark_Double        | Sum128Traits         |  124.429 |
| FloorBenchmark_Double        | Sum256Bcl            |    8.641 |
| FloorBenchmark_Double        | Sum256Base_Basic     |   13.696 |
| FloorBenchmark_Double        | Sum256Base           |    8.396 |
| FloorBenchmark_Double        | Sum256Traits         |    6.275 |
| FloorBenchmark_Double        | Sum512Bcl            |    7.978 |
| FloorBenchmark_Double        | Sum512Base           |    7.958 |
| FloorBenchmark_Double        | Sum512Traits         |    6.951 |
| FloorBenchmark_Single        | SumScalar            |   47.304 |
| FloorBenchmark_Single        | SumBcl               |   62.493 |
| FloorBenchmark_Single        | SumBase              |   61.246 |
| FloorBenchmark_Single        | SumBase_Basic        |   97.476 |
| FloorBenchmark_Single        | SumBase_ClearBit     |    6.498 |
| FloorBenchmark_Single        | SumTraits            |  237.610 |
| FloorBenchmark_Single        | Sum128Bcl            |   41.790 |
| FloorBenchmark_Single        | Sum128Base_Basic     |  109.751 |
| FloorBenchmark_Single        | Sum128Base           |   41.999 |
| FloorBenchmark_Single        | Sum128Traits         |  243.707 |
| FloorBenchmark_Single        | Sum256Bcl            |   33.581 |
| FloorBenchmark_Single        | Sum256Base_Basic     |  111.353 |
| FloorBenchmark_Single        | Sum256Base           |   34.183 |
| FloorBenchmark_Single        | Sum256Traits         |   34.848 |
| FloorBenchmark_Single        | Sum512Bcl            |   19.238 |
| FloorBenchmark_Single        | Sum512Base           |   18.584 |
| FloorBenchmark_Single        | Sum512Traits         |   18.694 |
| YRoundToEvenBenchmark_Double | SumScalar            |   11.297 |
| YRoundToEvenBenchmark_Double | SumBase              |    1.665 |
| YRoundToEvenBenchmark_Double | SumBase_Add          |    1.725 |
| YRoundToEvenBenchmark_Double | SumTraits            |   19.429 |
| YRoundToEvenBenchmark_Double | Sum128Base_Basic     |    8.022 |
| YRoundToEvenBenchmark_Double | Sum128Base           |    1.372 |
| YRoundToEvenBenchmark_Double | Sum128Traits         |   38.319 |
| YRoundToEvenBenchmark_Double | Sum256Base_Basic     |    5.184 |
| YRoundToEvenBenchmark_Double | Sum256Base           |    0.872 |
| YRoundToEvenBenchmark_Double | Sum256Traits         |    0.832 |
| YRoundToEvenBenchmark_Double | Sum512Base           |    0.769 |
| YRoundToEvenBenchmark_Double | Sum512Traits         |    0.784 |
| YRoundToEvenBenchmark_Single | SumScalar            |   13.114 |
| YRoundToEvenBenchmark_Single | SumBase              |    4.670 |
| YRoundToEvenBenchmark_Single | SumBase_Add          |    5.077 |
| YRoundToEvenBenchmark_Single | SumTraits            |   61.711 |
| YRoundToEvenBenchmark_Single | Sum128Base_Basic     |   10.157 |
| YRoundToEvenBenchmark_Single | Sum128Base           |    5.387 |
| YRoundToEvenBenchmark_Single | Sum128Traits         |   79.262 |
| YRoundToEvenBenchmark_Single | Sum256Base_Basic     |    8.894 |
| YRoundToEvenBenchmark_Single | Sum256Base           |    2.549 |
| YRoundToEvenBenchmark_Single | Sum256Traits         |    2.480 |
| YRoundToEvenBenchmark_Single | Sum512Base           |    2.120 |
| YRoundToEvenBenchmark_Single | Sum512Traits         |    2.073 |
| YRoundToZeroBenchmark_Double | SumScalar            |    2.880 |
| YRoundToZeroBenchmark_Double | SumBase              |    4.548 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit     |    1.139 |
| YRoundToZeroBenchmark_Double | SumBase_ClearBit_Not |    1.135 |
| YRoundToZeroBenchmark_Double | SumTraits            |   19.867 |
| YRoundToZeroBenchmark_Double | Sum128Base_Basic     |    2.526 |
| YRoundToZeroBenchmark_Double | Sum128Base           |    5.068 |
| YRoundToZeroBenchmark_Double | Sum128Traits         |   40.473 |
| YRoundToZeroBenchmark_Double | Sum256Base_Basic     |    2.061 |
| YRoundToZeroBenchmark_Double | Sum256Base           |    2.187 |
| YRoundToZeroBenchmark_Double | Sum256Traits         |    2.051 |
| YRoundToZeroBenchmark_Double | Sum512Base           |    1.965 |
| YRoundToZeroBenchmark_Double | Sum512Traits         |    1.813 |
| YRoundToZeroBenchmark_Single | SumScalar            |    2.834 |
| YRoundToZeroBenchmark_Single | SumBase              |   11.462 |
| YRoundToZeroBenchmark_Single | SumBase_ClearBit     |    2.600 |
| YRoundToZeroBenchmark_Single | SumTraits            |   62.234 |
| YRoundToZeroBenchmark_Single | Sum128Base_Basic     |    2.780 |
| YRoundToZeroBenchmark_Single | Sum128Base           |    8.125 |
| YRoundToZeroBenchmark_Single | Sum128Traits         |   81.390 |
| YRoundToZeroBenchmark_Single | Sum256Base_Basic     |    2.572 |
| YRoundToZeroBenchmark_Single | Sum256Base           |    4.017 |
| YRoundToZeroBenchmark_Single | Sum256Traits         |    3.932 |
| YRoundToZeroBenchmark_Single | Sum512Base           |    3.544 |
| YRoundToZeroBenchmark_Single | Sum512Traits         |    3.249 |

