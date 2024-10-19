# Benchmark group - ConvertToDouble
([← Back](ConvertToDouble.md))

Unit of data: Million operations per second. The larger the number, the better the performance.
### X86 - AMD Ryzen 7 7840H
| Type                            | Method                          | .NET Framework | .NET Core 2.1 | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 | .NET 8.0 |
| :------------------------------ | :------------------------------ | -------------: | ------------: | ------------: | -------: | -------: | -------: | -------: |
| ConvertToDoubleBenchmark_Int64  | SumScalar                       |       1138.328 |      1137.900 |      1136.919 | 1133.493 | 1138.926 | 1135.301 | 1139.568 |
| ConvertToDoubleBenchmark_Int64  | SumBcl                          |       1783.739 |      1666.708 |      1726.822 | 1725.295 | 1672.452 | 4353.395 | 4314.428 |
| ConvertToDoubleBenchmark_Int64  | SumBase_Range52_Impl            |       4478.307 |      4507.281 |      4498.555 | 4494.114 | 4518.671 | 4497.730 | 4455.272 |
| ConvertToDoubleBenchmark_Int64  | SumTraits                       |       1730.644 |      1628.077 |      3311.139 | 4082.377 | 4380.002 | 4362.887 | 4480.699 |
| ConvertToDoubleBenchmark_Int64  | SumTraits_Range52               |       4477.813 |      4482.558 |      4491.106 | 4512.945 | 4487.376 | 4461.216 | 4466.599 |
| ConvertToDoubleBenchmark_Int64  | Sum128Bcl                       |                |               |               |          |          | 2197.004 | 2173.102 |
| ConvertToDoubleBenchmark_Int64  | Sum128Base_Basic                |                |               |       278.386 |  277.099 |  275.836 |  277.507 |  273.481 |
| ConvertToDoubleBenchmark_Int64  | Sum128Base                      |                |               |       278.944 |  278.289 |  276.740 | 2196.144 | 2185.449 |
| ConvertToDoubleBenchmark_Int64  | Sum128Base_Range52_Impl         |                |               |       278.436 |  277.525 |  277.238 | 2260.615 | 2261.199 |
| ConvertToDoubleBenchmark_Int64  | Sum128AdvSimd_Range52           |                |               |               |          |          |          |          |
| ConvertToDoubleBenchmark_Int64  | Sum128AdvSimd_Range52_Impl      |                |               |               |          |          |          |          |
| ConvertToDoubleBenchmark_Int64  | Sum128Traits                    |                |               |      1720.034 | 2082.181 | 2193.677 | 2193.453 | 2260.038 |
| ConvertToDoubleBenchmark_Int64  | Sum128Traits_Range52            |                |               |      2248.248 | 2263.122 | 2270.771 | 2262.011 | 2262.247 |
| ConvertToDoubleBenchmark_Int64  | Sum256Bcl                       |                |               |               |          |          | 4372.025 | 4277.539 |
| ConvertToDoubleBenchmark_Int64  | Sum256Base_Basic                |                |               |       509.413 |  507.167 |  510.632 |  508.520 |  485.632 |
| ConvertToDoubleBenchmark_Int64  | Sum256Base                      |                |               |       510.183 |  504.168 |  509.734 | 4352.892 | 4298.224 |
| ConvertToDoubleBenchmark_Int64  | Sum256Base_Range52_Impl         |                |               |       509.788 |  497.555 |  509.852 | 4489.240 | 4474.760 |
| ConvertToDoubleBenchmark_Int64  | Sum256Avx2_Bcl                  |                |               |      3326.829 | 4096.189 | 4358.339 | 4360.025 | 4319.021 |
| ConvertToDoubleBenchmark_Int64  | Sum256Avx2_HwScalar             |                |               |      1650.213 | 1626.068 | 1650.168 | 1642.647 | 1578.679 |
| ConvertToDoubleBenchmark_Int64  | Sum256Avx2_Range52              |                |               |      4456.488 | 4502.850 | 4431.773 | 4468.637 | 4473.990 |
| ConvertToDoubleBenchmark_Int64  | Sum256Traits                    |                |               |      3427.010 | 4095.964 | 4351.279 | 4358.358 | 4478.929 |
| ConvertToDoubleBenchmark_Int64  | Sum256Traits_Range52            |                |               |      4496.869 | 4493.781 | 4493.398 | 4475.541 | 4455.008 |
| ConvertToDoubleBenchmark_Int64  | Sum512Bcl                       |                |               |               |          |          |          |  872.324 |
| ConvertToDoubleBenchmark_Int64  | Sum512Base                      |                |               |               |          |          |          |  869.401 |
| ConvertToDoubleBenchmark_Int64  | Sum512Traits                    |                |               |               |          |          |          | 7647.151 |
| ConvertToDoubleBenchmark_UInt64 | SumScalar                       |        341.295 |       331.915 |       356.577 |  367.737 |  368.594 |  384.267 | 1071.323 |
| ConvertToDoubleBenchmark_UInt64 | SumBcl                          |       2306.101 |      2254.436 |      2256.057 | 2265.902 | 2263.979 | 4328.772 | 4304.313 |
| ConvertToDoubleBenchmark_UInt64 | SumBase_Range52_Impl            |       4489.217 |      4514.439 |      4499.029 | 4506.452 | 4469.219 | 4472.157 | 4482.896 |
| ConvertToDoubleBenchmark_UInt64 | SumTraits                       |       2344.096 |      2261.942 |      3339.149 | 4132.420 | 4352.220 | 4384.902 | 4492.807 |
| ConvertToDoubleBenchmark_UInt64 | SumTraits_Range52               |       4478.226 |      4510.294 |      4482.461 | 4491.039 | 4499.255 | 4479.913 | 4477.748 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Bcl                       |                |               |               |          |          | 2202.955 | 2167.744 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Base_Basic                |                |               |       247.759 |  242.334 |  247.768 |  246.510 |  264.096 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Base                      |                |               |       240.335 |  242.055 |  244.653 | 2198.103 | 2173.747 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Base_Range52_Impl         |                |               |       247.264 |  241.971 |  246.630 | 2260.749 | 2259.417 |
| ConvertToDoubleBenchmark_UInt64 | Sum128AdvSimd_Range52           |                |               |               |          |          |          |          |
| ConvertToDoubleBenchmark_UInt64 | Sum128AdvSimd_Range52_Impl      |                |               |               |          |          |          |          |
| ConvertToDoubleBenchmark_UInt64 | Sum128Traits                    |                |               |      1678.198 | 2074.959 | 2187.089 | 2185.758 | 2258.444 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Traits_Range52            |                |               |      2256.730 | 2265.560 | 2259.172 | 2265.459 | 2263.224 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Bcl                       |                |               |               |          |          | 4354.259 | 4255.747 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Base_Basic                |                |               |       280.106 |  281.051 |  282.909 |  276.268 |  477.503 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Base                      |                |               |       276.133 |  278.286 |  282.128 | 4368.641 | 4298.339 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Base_Range52_Impl         |                |               |       280.833 |  282.518 |  283.756 | 4510.324 | 4442.575 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Avx2_Bcl                  |                |               |      3353.687 | 4216.202 | 4352.187 | 4295.434 | 4287.501 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Avx2_Range52              |                |               |      4516.192 | 4502.041 | 4486.005 | 4477.522 | 4491.225 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Traits                    |                |               |      3293.701 | 4151.561 | 4362.896 | 4366.718 | 4477.267 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Traits_Range52            |                |               |      4494.216 | 4484.841 | 4498.954 | 4491.777 | 4467.321 |
| ConvertToDoubleBenchmark_UInt64 | Sum512Bcl                       |                |               |               |          |          |          |  873.102 |
| ConvertToDoubleBenchmark_UInt64 | Sum512Base                      |                |               |               |          |          |          |  867.217 |
| ConvertToDoubleBenchmark_UInt64 | Sum512Traits                    |                |               |               |          |          |          | 7753.940 |
| ConvertToInt64Benchmark_Double  | SumScalar                       |       1638.626 |      1595.892 |      1600.449 | 1598.075 | 1603.518 | 1617.700 | 1623.235 |
| ConvertToInt64Benchmark_Double  | SumBcl                          |       1754.547 |      1633.239 |      1670.933 | 1630.275 | 1688.237 |  516.277 |  517.278 |
| ConvertToInt64Benchmark_Double  | SumBase_Range52_Impl            |       2017.237 |      1762.935 |      2100.918 | 4372.285 | 4267.413 | 4181.004 | 3962.523 |
| ConvertToInt64Benchmark_Double  | SumBase_Range52RoundToEven      |       7657.413 |      7011.856 |      7158.505 | 6815.281 | 6886.875 | 7673.773 | 5518.297 |
| ConvertToInt64Benchmark_Double  | SumTraits                       |       1728.372 |      1635.181 |      1851.438 | 2201.093 | 2453.610 | 2507.194 | 8943.808 |
| ConvertToInt64Benchmark_Double  | SumTraits_Range52               |       1786.787 |      1677.086 |      5944.655 | 6502.462 | 6917.255 | 6094.533 | 8672.266 |
| ConvertToInt64Benchmark_Double  | SumTraits_Range52RoundToEven    |       7713.485 |      6934.704 |      6578.539 | 6794.903 | 7365.267 | 6120.616 | 9009.652 |
| ConvertToInt64Benchmark_Double  | Sum128Bcl                       |                |               |               |          |          |  287.623 |  262.269 |
| ConvertToInt64Benchmark_Double  | Sum128Base_Basic                |                |               |       290.794 |  288.413 |  289.465 |  291.137 |  284.169 |
| ConvertToInt64Benchmark_Double  | Sum128Base                      |                |               |       290.432 |  289.206 |  289.177 |  286.709 |  261.584 |
| ConvertToInt64Benchmark_Double  | Sum128Base_Range52_Impl         |                |               |       291.005 |  288.762 |  287.868 | 2305.564 | 2119.720 |
| ConvertToInt64Benchmark_Double  | Sum128AdvSimd_Range52           |                |               |               |          |          |          |          |
| ConvertToInt64Benchmark_Double  | Sum128AdvSimd_Range52_Impl      |                |               |               |          |          |          |          |
| ConvertToInt64Benchmark_Double  | Sum128Traits                    |                |               |       916.785 | 1110.483 | 1231.606 | 1290.529 | 4763.183 |
| ConvertToInt64Benchmark_Double  | Sum128Traits_Range52            |                |               |      3296.085 | 3419.467 | 3538.835 | 3714.017 | 4780.778 |
| ConvertToInt64Benchmark_Double  | Sum128Traits_Range52RoundToEven |                |               |      3503.241 | 3927.285 | 3836.373 | 3691.546 | 4763.328 |
| ConvertToInt64Benchmark_Double  | Sum256Bcl                       |                |               |               |          |          |  543.910 |  273.433 |
| ConvertToInt64Benchmark_Double  | Sum256Base_Basic                |                |               |       529.174 |  521.848 |  527.797 |  528.550 |  497.872 |
| ConvertToInt64Benchmark_Double  | Sum256Base                      |                |               |       530.507 |  522.398 |  527.404 |  542.758 |  273.868 |
| ConvertToInt64Benchmark_Double  | Sum256Base_Range52_Impl         |                |               |       528.208 |  518.673 |  527.709 | 4166.561 | 3933.894 |
| ConvertToInt64Benchmark_Double  | Sum256Avx2_HwScalar             |                |               |      1582.852 | 1550.655 | 1615.349 | 1588.051 | 1661.119 |
| ConvertToInt64Benchmark_Double  | Sum256Avx2_ShiftVar             |                |               |      2148.678 | 2545.404 | 2873.944 | 2963.079 | 2620.609 |
| ConvertToInt64Benchmark_Double  | Sum256Avx2_ShiftVarFix          |                |               |      1908.552 | 2322.051 | 2405.989 | 2576.074 | 2313.218 |
| ConvertToInt64Benchmark_Double  | Sum256Avx2_Range52              |                |               |      6011.455 | 6422.094 | 6528.405 | 6204.789 | 8894.188 |
| ConvertToInt64Benchmark_Double  | Sum256Traits                    |                |               |      1875.265 | 2126.255 | 2467.732 | 2514.294 | 8875.725 |
| ConvertToInt64Benchmark_Double  | Sum256Traits_Range52            |                |               |      6065.159 | 6471.331 | 6636.340 | 6035.781 | 8866.368 |
| ConvertToInt64Benchmark_Double  | Sum256Traits_Range52RoundToEven |                |               |      6656.631 | 7181.377 | 7512.979 | 6257.690 | 8771.898 |
| ConvertToInt64Benchmark_Double  | Sum512Bcl                       |                |               |               |          |          |          |  177.618 |
| ConvertToInt64Benchmark_Double  | Sum512Base                      |                |               |               |          |          |          |  178.692 |
| ConvertToInt64Benchmark_Double  | Sum512Traits                    |                |               |               |          |          |          | 9713.809 |
| ConvertToUInt64Benchmark_Double | SumScalar                       |        269.005 |       270.116 |       241.378 |  265.687 |  255.508 |  265.267 |  264.980 |
| ConvertToUInt64Benchmark_Double | SumBcl                          |        170.190 |       159.727 |       164.376 |  190.550 |  191.986 |  240.317 |  237.975 |
| ConvertToUInt64Benchmark_Double | SumBase_Range52_Impl            |       1871.772 |      1826.783 |      2113.133 | 4108.526 | 4225.794 | 4211.328 | 3935.655 |
| ConvertToUInt64Benchmark_Double | SumBase_Range52RoundToEven      |       6970.436 |      6822.432 |      6822.259 | 7816.186 | 7639.011 | 7786.992 | 6019.378 |
| ConvertToUInt64Benchmark_Double | SumTraits                       |        167.350 |       167.450 |      2887.840 | 3513.113 | 3493.482 | 3640.510 | 8877.831 |
| ConvertToUInt64Benchmark_Double | SumTraits_Range52               |       1964.761 |      1755.834 |      6025.482 | 6826.889 | 7169.392 | 6166.445 | 8829.251 |
| ConvertToUInt64Benchmark_Double | SumTraits_Range52RoundToEven    |       7735.064 |      7283.890 |      6575.867 | 7715.611 | 7963.862 | 6365.631 | 8985.633 |
| ConvertToUInt64Benchmark_Double | Sum128Bcl                       |                |               |               |          |          |  224.787 |  174.899 |
| ConvertToUInt64Benchmark_Double | Sum128Base_Basic                |                |               |       221.612 |  226.356 |  221.310 |  225.864 |  214.776 |
| ConvertToUInt64Benchmark_Double | Sum128Base                      |                |               |       225.827 |  221.153 |  224.639 |  224.582 |  175.932 |
| ConvertToUInt64Benchmark_Double | Sum128Base_Range52_Impl         |                |               |       221.406 |  223.801 |  219.039 | 2222.792 | 2210.661 |
| ConvertToUInt64Benchmark_Double | Sum128AdvSimd_Range52           |                |               |               |          |          |          |          |
| ConvertToUInt64Benchmark_Double | Sum128AdvSimd_Range52_Impl      |                |               |               |          |          |          |          |
| ConvertToUInt64Benchmark_Double | Sum128Traits                    |                |               |      1499.256 | 1647.829 | 1795.908 | 1881.938 | 4687.445 |
| ConvertToUInt64Benchmark_Double | Sum128Traits_Range52            |                |               |      3170.567 | 3621.163 | 3391.479 | 3387.049 | 4884.330 |
| ConvertToUInt64Benchmark_Double | Sum128Traits_Range52RoundToEven |                |               |      3643.508 | 3912.023 | 3785.339 | 3505.374 | 4857.641 |
| ConvertToUInt64Benchmark_Double | Sum256Bcl                       |                |               |               |          |          |  241.103 |  174.817 |
| ConvertToUInt64Benchmark_Double | Sum256Base_Basic                |                |               |       238.264 |  234.366 |  234.507 |  240.897 |  227.237 |
| ConvertToUInt64Benchmark_Double | Sum256Base                      |                |               |       237.887 |  236.329 |  230.987 |  241.971 |  173.461 |
| ConvertToUInt64Benchmark_Double | Sum256Base_Range52_Impl         |                |               |       236.974 |  235.774 |  229.505 | 4109.712 | 3951.041 |
| ConvertToUInt64Benchmark_Double | Sum256Avx2_ShiftVar             |                |               |      2985.914 | 3513.235 | 3544.814 | 3556.478 | 3342.598 |
| ConvertToUInt64Benchmark_Double | Sum256Avx2_Range52              |                |               |      6035.207 | 6656.904 | 6796.506 | 6003.864 | 8879.996 |
| ConvertToUInt64Benchmark_Double | Sum256Traits                    |                |               |      2868.868 | 3419.469 | 3575.332 | 3643.262 | 8784.506 |
| ConvertToUInt64Benchmark_Double | Sum256Traits_Range52            |                |               |      6077.850 | 6607.416 | 7111.012 | 6250.955 | 8808.130 |
| ConvertToUInt64Benchmark_Double | Sum256Traits_Range52RoundToEven |                |               |      6627.138 | 7684.661 | 7774.516 | 6418.539 | 8805.704 |
| ConvertToUInt64Benchmark_Double | Sum512Bcl                       |                |               |               |          |          |          |  130.167 |
| ConvertToUInt64Benchmark_Double | Sum512Base                      |                |               |               |          |          |          |  129.746 |
| ConvertToUInt64Benchmark_Double | Sum512Traits                    |                |               |               |          |          |          | 9744.563 |

### X86 - Intel Core i5-8250U
| Type                            | Method                          | .NET Framework | .NET Core 2.1 | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 |
| :------------------------------ | :------------------------------ | -------------: | ------------: | ------------: | -------: | -------: | -------: |
| ConvertToDoubleBenchmark_Int64  | SumScalar                       |        714.217 |       845.692 |       844.201 |  845.977 |  844.954 |  845.009 |
| ConvertToDoubleBenchmark_Int64  | SumBcl                          |       1069.087 |      1343.119 |      1342.139 | 1341.178 | 1343.349 | 3259.472 |
| ConvertToDoubleBenchmark_Int64  | SumBase_Range52_Impl            |       2847.061 |      3364.195 |      3364.185 | 3367.463 | 3367.645 | 3362.752 |
| ConvertToDoubleBenchmark_Int64  | SumTraits                       |       1120.710 |      1341.000 |      2712.295 | 3034.230 | 3289.890 | 3226.141 |
| ConvertToDoubleBenchmark_Int64  | SumTraits_Range52               |       1103.745 |      1332.506 |      3356.046 | 3370.674 | 3372.362 | 3241.084 |
| ConvertToDoubleBenchmark_Int64  | Sum128Bcl                       |                |               |               |          |          | 1687.774 |
| ConvertToDoubleBenchmark_Int64  | Sum128Base_Basic                |                |               |       293.738 |  306.543 |  305.637 |  307.153 |
| ConvertToDoubleBenchmark_Int64  | Sum128Base                      |                |               |       294.116 |  306.563 |  306.154 | 1686.513 |
| ConvertToDoubleBenchmark_Int64  | Sum128Base_Range52_Impl         |                |               |       294.119 |  306.229 |  305.961 | 1684.287 |
| ConvertToDoubleBenchmark_Int64  | Sum128AdvSimd_Range52           |                |               |               |          |          |          |
| ConvertToDoubleBenchmark_Int64  | Sum128AdvSimd_Range52_Impl      |                |               |               |          |          |          |
| ConvertToDoubleBenchmark_Int64  | Sum128Traits                    |                |               |      1570.683 | 1683.303 | 1687.923 | 1683.957 |
| ConvertToDoubleBenchmark_Int64  | Sum128Traits_Range52            |                |               |      1688.289 | 1688.336 | 1689.682 | 1686.228 |
| ConvertToDoubleBenchmark_Int64  | Sum256Bcl                       |                |               |               |          |          | 3252.412 |
| ConvertToDoubleBenchmark_Int64  | Sum256Base_Basic                |                |               |       519.638 |  498.050 |  244.115 |  540.854 |
| ConvertToDoubleBenchmark_Int64  | Sum256Base                      |                |               |       519.536 |  498.267 |  244.945 | 3212.416 |
| ConvertToDoubleBenchmark_Int64  | Sum256Base_Range52_Impl         |                |               |       517.258 |  498.273 |  244.828 | 3365.257 |
| ConvertToDoubleBenchmark_Int64  | Sum256Avx2_Bcl                  |                |               |      2737.511 | 3013.489 | 3285.401 | 3251.798 |
| ConvertToDoubleBenchmark_Int64  | Sum256Avx2_HwScalar             |                |               |      1341.411 | 1342.566 | 1343.861 | 1342.899 |
| ConvertToDoubleBenchmark_Int64  | Sum256Avx2_Range52              |                |               |      3357.796 | 3365.467 | 3371.826 | 2483.589 |
| ConvertToDoubleBenchmark_Int64  | Sum256Traits                    |                |               |      2731.855 | 3032.861 | 3282.494 | 3103.940 |
| ConvertToDoubleBenchmark_Int64  | Sum256Traits_Range52            |                |               |      3329.274 | 3363.078 | 3366.373 | 3109.072 |
| ConvertToDoubleBenchmark_UInt64 | SumScalar                       |        322.727 |       377.235 |       375.934 |  374.606 |  374.114 |  376.168 |
| ConvertToDoubleBenchmark_UInt64 | SumBcl                          |       2036.146 |      2556.260 |      2349.708 | 2538.418 | 2565.161 | 1938.229 |
| ConvertToDoubleBenchmark_UInt64 | SumBase_Range52_Impl            |       2867.041 |      3370.946 |      3374.604 | 3364.609 | 3368.743 | 3244.167 |
| ConvertToDoubleBenchmark_UInt64 | SumTraits                       |       1967.466 |      2544.092 |      2729.668 | 3365.159 | 3367.071 | 3056.233 |
| ConvertToDoubleBenchmark_UInt64 | SumTraits_Range52               |       1607.021 |      1927.839 |      3271.381 | 3365.471 | 3371.469 | 3266.012 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Bcl                       |                |               |               |          |          | 1686.821 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Base_Basic                |                |               |       231.362 |  283.145 |  283.142 |  286.549 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Base                      |                |               |       240.265 |  283.429 |  282.855 | 1679.199 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Base_Range52_Impl         |                |               |       254.189 |  282.990 |  283.017 | 1689.381 |
| ConvertToDoubleBenchmark_UInt64 | Sum128AdvSimd_Range52           |                |               |               |          |          |          |
| ConvertToDoubleBenchmark_UInt64 | Sum128AdvSimd_Range52_Impl      |                |               |               |          |          |          |
| ConvertToDoubleBenchmark_UInt64 | Sum128Traits                    |                |               |      1583.074 | 1686.269 | 1686.936 | 1687.610 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Traits_Range52            |                |               |      1689.269 | 1684.347 | 1689.726 | 1685.814 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Bcl                       |                |               |               |          |          | 3256.912 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Base_Basic                |                |               |       300.193 |  316.367 |  231.238 |  317.184 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Base                      |                |               |       298.250 |  317.538 |  231.201 | 3190.223 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Base_Range52_Impl         |                |               |       300.088 |  318.693 |  230.526 | 3360.745 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Avx2_Bcl                  |                |               |      2712.725 | 3360.144 | 3365.877 | 3229.109 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Avx2_Range52              |                |               |      3361.202 | 3361.765 | 3371.967 | 3336.262 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Traits                    |                |               |      2696.696 | 3354.670 | 3360.322 | 2847.721 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Traits_Range52            |                |               |      3355.055 | 3372.283 | 3369.292 | 3258.582 |
| ConvertToInt64Benchmark_Double  | SumScalar                       |       1054.250 |      1658.661 |      1655.768 | 1657.406 | 1658.672 | 1688.567 |
| ConvertToInt64Benchmark_Double  | SumBcl                          |        974.012 |      1324.984 |      1328.972 | 1328.933 | 1310.982 |  601.633 |
| ConvertToInt64Benchmark_Double  | SumBase_Range52_Impl            |       1032.931 |      1551.359 |      1714.504 | 2660.723 | 2510.361 | 2519.799 |
| ConvertToInt64Benchmark_Double  | SumBase_Range52RoundToEven      |       2995.845 |      3676.266 |      3700.541 | 3673.417 | 4788.926 | 4833.489 |
| ConvertToInt64Benchmark_Double  | SumTraits                       |       1060.334 |      1321.285 |      1449.290 | 1617.708 | 1637.423 | 1677.416 |
| ConvertToInt64Benchmark_Double  | SumTraits_Range52               |       1042.162 |      1322.172 |      3385.336 | 3535.908 | 3662.527 | 3524.158 |
| ConvertToInt64Benchmark_Double  | SumTraits_Range52RoundToEven    |       3320.321 |      3701.596 |      3663.925 | 3703.357 | 4926.614 | 4500.594 |
| ConvertToInt64Benchmark_Double  | Sum128Bcl                       |                |               |               |          |          |  343.013 |
| ConvertToInt64Benchmark_Double  | Sum128Base_Basic                |                |               |       314.260 |  324.763 |  326.141 |  328.030 |
| ConvertToInt64Benchmark_Double  | Sum128Base                      |                |               |       314.640 |  324.752 |  323.862 |  342.343 |
| ConvertToInt64Benchmark_Double  | Sum128Base_Range52_Impl         |                |               |       314.300 |  325.139 |  325.697 | 1878.978 |
| ConvertToInt64Benchmark_Double  | Sum128AdvSimd_Range52           |                |               |               |          |          |          |
| ConvertToInt64Benchmark_Double  | Sum128AdvSimd_Range52_Impl      |                |               |               |          |          |          |
| ConvertToInt64Benchmark_Double  | Sum128Traits                    |                |               |       749.001 |  840.886 |  825.764 |  942.576 |
| ConvertToInt64Benchmark_Double  | Sum128Traits_Range52            |                |               |      2138.218 | 2193.217 | 2206.149 | 2383.121 |
| ConvertToInt64Benchmark_Double  | Sum128Traits_Range52RoundToEven |                |               |      2244.453 | 2695.710 | 2883.229 | 2724.293 |
| ConvertToInt64Benchmark_Double  | Sum256Bcl                       |                |               |               |          |          |  600.151 |
| ConvertToInt64Benchmark_Double  | Sum256Base_Basic                |                |               |       559.664 |  527.109 |  251.346 |  574.576 |
| ConvertToInt64Benchmark_Double  | Sum256Base                      |                |               |       557.984 |  533.109 |  251.276 |  599.821 |
| ConvertToInt64Benchmark_Double  | Sum256Base_Range52_Impl         |                |               |       548.320 |  533.012 |  251.662 | 2708.575 |
| ConvertToInt64Benchmark_Double  | Sum256Avx2_HwScalar             |                |               |      1344.431 | 1335.218 | 1343.364 | 1344.392 |
| ConvertToInt64Benchmark_Double  | Sum256Avx2_ShiftVar             |                |               |      1786.405 | 1839.951 | 1830.518 | 1786.333 |
| ConvertToInt64Benchmark_Double  | Sum256Avx2_ShiftVarFix          |                |               |      1462.548 | 1559.028 | 1624.847 | 1677.217 |
| ConvertToInt64Benchmark_Double  | Sum256Avx2_Range52              |                |               |      3383.125 | 3533.645 | 3661.482 | 3705.817 |
| ConvertToInt64Benchmark_Double  | Sum256Traits                    |                |               |      1460.074 | 1623.511 | 1614.229 | 1714.996 |
| ConvertToInt64Benchmark_Double  | Sum256Traits_Range52            |                |               |      3378.792 | 3541.993 | 3696.190 | 3729.287 |
| ConvertToInt64Benchmark_Double  | Sum256Traits_Range52RoundToEven |                |               |      3692.122 | 3707.898 | 4908.634 | 4749.525 |
| ConvertToUInt64Benchmark_Double | SumScalar                       |        205.407 |       282.048 |       301.216 |  284.554 |  286.658 |  288.546 |
| ConvertToUInt64Benchmark_Double | SumBcl                          |        140.489 |       187.497 |       180.540 |  205.761 |  220.689 |  261.833 |
| ConvertToUInt64Benchmark_Double | SumBase_Range52_Impl            |       1083.559 |      1616.455 |      1720.754 | 2930.959 | 2662.751 | 2473.041 |
| ConvertToUInt64Benchmark_Double | SumBase_Range52RoundToEven      |       2599.294 |      4977.686 |      3758.543 | 5101.545 | 5085.319 | 4822.031 |
| ConvertToUInt64Benchmark_Double | SumTraits                       |        137.657 |       188.202 |      2044.114 | 2605.814 | 2606.017 | 2343.486 |
| ConvertToUInt64Benchmark_Double | SumTraits_Range52               |       1133.001 |      1617.783 |      3383.054 | 3974.415 | 3911.706 | 3554.745 |
| ConvertToUInt64Benchmark_Double | SumTraits_Range52RoundToEven    |       2834.962 |      4607.170 |      3750.896 | 5124.713 | 4877.922 | 4818.579 |
| ConvertToUInt64Benchmark_Double | Sum128Bcl                       |                |               |               |          |          |  238.666 |
| ConvertToUInt64Benchmark_Double | Sum128Base_Basic                |                |               |       249.890 |  236.623 |  242.004 |  241.047 |
| ConvertToUInt64Benchmark_Double | Sum128Base                      |                |               |       247.156 |  246.721 |  251.975 |  242.631 |
| ConvertToUInt64Benchmark_Double | Sum128Base_Range52_Impl         |                |               |       248.197 |  237.764 |  243.027 | 1770.881 |
| ConvertToUInt64Benchmark_Double | Sum128AdvSimd_Range52           |                |               |               |          |          |          |
| ConvertToUInt64Benchmark_Double | Sum128AdvSimd_Range52_Impl      |                |               |               |          |          |          |
| ConvertToUInt64Benchmark_Double | Sum128Traits                    |                |               |      1121.648 | 1348.552 | 1343.466 | 1322.616 |
| ConvertToUInt64Benchmark_Double | Sum128Traits_Range52            |                |               |      2223.242 | 2372.976 | 2380.127 | 2220.273 |
| ConvertToUInt64Benchmark_Double | Sum128Traits_Range52RoundToEven |                |               |      2724.063 | 2951.292 | 3010.790 | 2737.007 |
| ConvertToUInt64Benchmark_Double | Sum256Bcl                       |                |               |               |          |          |  259.494 |
| ConvertToUInt64Benchmark_Double | Sum256Base_Basic                |                |               |       263.071 |  260.760 |  267.444 |  256.998 |
| ConvertToUInt64Benchmark_Double | Sum256Base                      |                |               |       262.911 |  263.428 |  267.572 |  259.239 |
| ConvertToUInt64Benchmark_Double | Sum256Base_Range52_Impl         |                |               |       262.918 |  259.770 |  267.514 | 2746.415 |
| ConvertToUInt64Benchmark_Double | Sum256Avx2_ShiftVar             |                |               |      1991.893 | 2482.375 | 2576.156 | 2242.477 |
| ConvertToUInt64Benchmark_Double | Sum256Avx2_Range52              |                |               |      3180.236 | 3969.420 | 4010.195 | 3271.825 |
| ConvertToUInt64Benchmark_Double | Sum256Traits                    |                |               |      2031.217 | 2603.524 | 2606.011 | 2277.153 |
| ConvertToUInt64Benchmark_Double | Sum256Traits_Range52            |                |               |      3395.744 | 3972.419 | 4024.953 | 3494.704 |
| ConvertToUInt64Benchmark_Double | Sum256Traits_Range52RoundToEven |                |               |      3750.985 | 4759.686 | 5287.314 | 4504.691 |

### Arm - Apple M2
| Type                            | Method                          | .NET 6.0 | .NET 7.0 |  .NET 8.0 |
| :------------------------------ | :------------------------------ | -------: | -------: | --------: |
| ConvertToDoubleBenchmark_Int64  | SumScalar                       | 1135.416 | 1134.064 |  1134.070 |
| ConvertToDoubleBenchmark_Int64  | SumBcl                          | 2331.370 | 2268.603 |  2332.061 |
| ConvertToDoubleBenchmark_Int64  | SumBase_Range52_Impl            | 2266.688 | 2267.970 |  2267.912 |
| ConvertToDoubleBenchmark_Int64  | SumTraits                       | 2267.406 | 2268.344 |  2331.625 |
| ConvertToDoubleBenchmark_Int64  | SumTraits_Range52               | 2266.519 | 2267.670 |  2332.283 |
| ConvertToDoubleBenchmark_Int64  | Sum128Bcl                       |          | 2268.206 |  2332.436 |
| ConvertToDoubleBenchmark_Int64  | Sum128Base_Basic                | 1875.354 | 1899.437 |  1895.197 |
| ConvertToDoubleBenchmark_Int64  | Sum128Base                      | 1868.588 | 2268.238 |  2332.222 |
| ConvertToDoubleBenchmark_Int64  | Sum128Base_Range52_Impl         | 1870.054 | 2267.397 |  2268.528 |
| ConvertToDoubleBenchmark_Int64  | Sum128AdvSimd_Range52           | 2265.654 | 2268.232 |  2332.153 |
| ConvertToDoubleBenchmark_Int64  | Sum128AdvSimd_Range52_Impl      | 2265.626 | 2266.891 |  2267.586 |
| ConvertToDoubleBenchmark_Int64  | Sum128Traits                    | 2302.603 | 2267.896 |  2331.737 |
| ConvertToDoubleBenchmark_Int64  | Sum128Traits_Range52            | 2267.529 | 2267.812 |  2332.124 |
| ConvertToDoubleBenchmark_Int64  | Sum256Bcl                       |          |  481.433 |  4537.012 |
| ConvertToDoubleBenchmark_Int64  | Sum256Base_Basic                |  397.134 |  497.080 |  1986.317 |
| ConvertToDoubleBenchmark_Int64  | Sum256Base                      |  333.280 |  481.451 |  4535.767 |
| ConvertToDoubleBenchmark_Int64  | Sum256Base_Range52_Impl         |  333.247 |  174.206 |  4533.895 |
| ConvertToDoubleBenchmark_Int64  | Sum256Avx2_Bcl                  |          |          |           |
| ConvertToDoubleBenchmark_Int64  | Sum256Avx2_HwScalar             |          |          |           |
| ConvertToDoubleBenchmark_Int64  | Sum256Avx2_Range52              |          |          |           |
| ConvertToDoubleBenchmark_Int64  | Sum256Traits                    |  336.441 |  481.731 |  4537.298 |
| ConvertToDoubleBenchmark_Int64  | Sum256Traits_Range52            |  336.421 |  438.214 |  4536.814 |
| ConvertToDoubleBenchmark_Int64  | Sum512Bcl                       |          |          |  9053.050 |
| ConvertToDoubleBenchmark_Int64  | Sum512Base                      |          |          |  9051.040 |
| ConvertToDoubleBenchmark_Int64  | Sum512Traits                    |          |          |  9050.424 |
| ConvertToDoubleBenchmark_UInt64 | SumScalar                       | 1133.402 | 1133.831 |  1133.875 |
| ConvertToDoubleBenchmark_UInt64 | SumBcl                          | 2267.488 | 2268.293 |  2332.449 |
| ConvertToDoubleBenchmark_UInt64 | SumBase_Range52_Impl            | 2267.088 | 2267.855 |  2267.788 |
| ConvertToDoubleBenchmark_UInt64 | SumTraits                       | 2267.128 | 2268.020 |  2332.397 |
| ConvertToDoubleBenchmark_UInt64 | SumTraits_Range52               | 2267.499 | 2268.165 |  2332.089 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Bcl                       |          | 2268.271 |  2332.289 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Base_Basic                | 1916.083 | 1947.352 |  1945.902 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Base                      | 1915.386 | 2268.454 |  2332.207 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Base_Range52_Impl         | 1916.058 | 2267.856 |  2268.469 |
| ConvertToDoubleBenchmark_UInt64 | Sum128AdvSimd_Range52           | 2266.254 | 2268.315 |  2332.394 |
| ConvertToDoubleBenchmark_UInt64 | Sum128AdvSimd_Range52_Impl      | 2266.146 | 2267.330 |  2267.639 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Traits                    | 2330.481 | 2267.967 |  2331.380 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Traits_Range52            | 2331.357 | 2268.141 |  2331.771 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Bcl                       |          |  481.439 |  4536.388 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Base_Basic                |  398.138 |  499.847 |  1943.895 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Base                      |  336.600 |  481.444 |  4537.003 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Base_Range52_Impl         |  339.053 |  184.522 |  4534.382 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Avx2_Bcl                  |          |          |           |
| ConvertToDoubleBenchmark_UInt64 | Sum256Avx2_Range52              |          |          |           |
| ConvertToDoubleBenchmark_UInt64 | Sum256Traits                    |  336.370 |  481.366 |  4536.775 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Traits_Range52            |  337.896 |  441.125 |  4537.368 |
| ConvertToDoubleBenchmark_UInt64 | Sum512Bcl                       |          |          |  9062.899 |
| ConvertToDoubleBenchmark_UInt64 | Sum512Base                      |          |          |  9065.223 |
| ConvertToDoubleBenchmark_UInt64 | Sum512Traits                    |          |          |  9063.756 |
| ConvertToInt64Benchmark_Double  | SumScalar                       | 1690.882 | 2247.321 |  2247.165 |
| ConvertToInt64Benchmark_Double  | SumBcl                          | 3399.553 | 3402.723 |  3402.060 |
| ConvertToInt64Benchmark_Double  | SumBase_Range52_Impl            | 2718.321 | 3021.979 |  3352.229 |
| ConvertToInt64Benchmark_Double  | SumBase_Range52RoundToEven      | 3399.855 | 3401.786 |  3400.447 |
| ConvertToInt64Benchmark_Double  | SumTraits                       | 3400.578 | 3402.116 |  3402.349 |
| ConvertToInt64Benchmark_Double  | SumTraits_Range52               | 3399.154 | 3401.333 |  3402.544 |
| ConvertToInt64Benchmark_Double  | SumTraits_Range52RoundToEven    | 3400.471 | 3401.792 |  3401.498 |
| ConvertToInt64Benchmark_Double  | Sum128Bcl                       |          | 3401.719 |  3402.088 |
| ConvertToInt64Benchmark_Double  | Sum128Base_Basic                | 2290.195 | 2323.924 |  2314.049 |
| ConvertToInt64Benchmark_Double  | Sum128Base                      | 2295.804 | 3402.478 |  3402.065 |
| ConvertToInt64Benchmark_Double  | Sum128Base_Range52_Impl         | 2289.662 | 3352.455 |  3351.817 |
| ConvertToInt64Benchmark_Double  | Sum128AdvSimd_Range52           | 2717.670 | 3402.392 |  3402.123 |
| ConvertToInt64Benchmark_Double  | Sum128AdvSimd_Range52_Impl      | 2717.438 | 3015.554 |  3347.639 |
| ConvertToInt64Benchmark_Double  | Sum128Traits                    | 3399.905 | 3401.955 |  3401.701 |
| ConvertToInt64Benchmark_Double  | Sum128Traits_Range52            | 3400.408 | 3402.606 |  3401.717 |
| ConvertToInt64Benchmark_Double  | Sum128Traits_Range52RoundToEven | 3400.328 | 3401.596 |  3401.676 |
| ConvertToInt64Benchmark_Double  | Sum256Bcl                       |          |  596.678 |  6802.198 |
| ConvertToInt64Benchmark_Double  | Sum256Base_Basic                |  504.148 |  597.660 |  2573.070 |
| ConvertToInt64Benchmark_Double  | Sum256Base                      |  422.592 |  531.314 |  6801.951 |
| ConvertToInt64Benchmark_Double  | Sum256Base_Range52_Impl         |  422.994 |  101.986 |  3354.102 |
| ConvertToInt64Benchmark_Double  | Sum256Avx2_HwScalar             |          |          |           |
| ConvertToInt64Benchmark_Double  | Sum256Avx2_ShiftVar             |          |          |           |
| ConvertToInt64Benchmark_Double  | Sum256Avx2_ShiftVarFix          |          |          |           |
| ConvertToInt64Benchmark_Double  | Sum256Avx2_Range52              |          |          |           |
| ConvertToInt64Benchmark_Double  | Sum256Traits                    |  423.065 |  530.973 |  6802.634 |
| ConvertToInt64Benchmark_Double  | Sum256Traits_Range52            |  423.003 |  499.363 |  6801.826 |
| ConvertToInt64Benchmark_Double  | Sum256Traits_Range52RoundToEven |  422.934 |  208.240 |  5070.914 |
| ConvertToInt64Benchmark_Double  | Sum512Bcl                       |          |          | 11424.624 |
| ConvertToInt64Benchmark_Double  | Sum512Base                      |          |          | 11427.139 |
| ConvertToInt64Benchmark_Double  | Sum512Traits                    |          |          | 11426.862 |
| ConvertToUInt64Benchmark_Double | SumScalar                       | 1690.404 | 2247.837 |  2248.484 |
| ConvertToUInt64Benchmark_Double | SumBcl                          |  847.969 | 3402.398 |  3402.351 |
| ConvertToUInt64Benchmark_Double | SumBase_Range52_Impl            | 2719.271 | 3022.343 |  3398.654 |
| ConvertToUInt64Benchmark_Double | SumBase_Range52RoundToEven      | 3401.300 | 3401.717 |  3401.586 |
| ConvertToUInt64Benchmark_Double | SumTraits                       | 3400.103 | 3401.652 |  3401.867 |
| ConvertToUInt64Benchmark_Double | SumTraits_Range52               | 3400.541 | 3402.380 |  3402.008 |
| ConvertToUInt64Benchmark_Double | SumTraits_Range52RoundToEven    | 3399.014 | 3401.553 |  3401.877 |
| ConvertToUInt64Benchmark_Double | Sum128Bcl                       |          | 3401.908 |  3401.429 |
| ConvertToUInt64Benchmark_Double | Sum128Base_Basic                | 2342.283 | 2380.812 |  2381.774 |
| ConvertToUInt64Benchmark_Double | Sum128Base                      | 2343.382 | 3401.850 |  3401.296 |
| ConvertToUInt64Benchmark_Double | Sum128Base_Range52_Impl         | 2343.206 | 3399.747 |  3398.545 |
| ConvertToUInt64Benchmark_Double | Sum128AdvSimd_Range52           | 2718.449 | 3401.548 |  3402.009 |
| ConvertToUInt64Benchmark_Double | Sum128AdvSimd_Range52_Impl      | 2719.025 | 3018.788 |  3353.785 |
| ConvertToUInt64Benchmark_Double | Sum128Traits                    | 3393.724 | 3401.601 |  3401.720 |
| ConvertToUInt64Benchmark_Double | Sum128Traits_Range52            | 3400.227 | 3401.873 |  3402.265 |
| ConvertToUInt64Benchmark_Double | Sum128Traits_Range52RoundToEven | 3394.818 | 3401.981 |  3401.629 |
| ConvertToUInt64Benchmark_Double | Sum256Bcl                       |          |  600.111 |  6803.223 |
| ConvertToUInt64Benchmark_Double | Sum256Base_Basic                |  483.048 |  598.797 |  2603.576 |
| ConvertToUInt64Benchmark_Double | Sum256Base                      |  429.004 |  539.319 |  6798.531 |
| ConvertToUInt64Benchmark_Double | Sum256Base_Range52_Impl         |  447.274 |  111.563 |  3459.866 |
| ConvertToUInt64Benchmark_Double | Sum256Avx2_ShiftVar             |          |          |           |
| ConvertToUInt64Benchmark_Double | Sum256Avx2_Range52              |          |          |           |
| ConvertToUInt64Benchmark_Double | Sum256Traits                    |  472.145 |  538.870 |  6801.977 |
| ConvertToUInt64Benchmark_Double | Sum256Traits_Range52            |  452.690 |  533.536 |  6804.504 |
| ConvertToUInt64Benchmark_Double | Sum256Traits_Range52RoundToEven |  457.301 |  262.293 |  5246.035 |
| ConvertToUInt64Benchmark_Double | Sum512Bcl                       |          |          | 11492.489 |
| ConvertToUInt64Benchmark_Double | Sum512Base                      |          |          | 11492.022 |
| ConvertToUInt64Benchmark_Double | Sum512Traits                    |          |          | 11494.183 |

### Arm - AWS Arm t4g.small
| Type                            | Method                          | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 | .NET 8.0 |
| :------------------------------ | :------------------------------ | ------------: | -------: | -------: | -------: | -------: |
| ConvertToDoubleBenchmark_Int64  | SumScalar                       |       803.088 |  823.140 |  823.536 |  929.164 |  928.650 |
| ConvertToDoubleBenchmark_Int64  | SumBcl                          |      1983.059 | 1970.505 | 1964.017 | 2474.455 | 2430.213 |
| ConvertToDoubleBenchmark_Int64  | SumBase_Range52_Impl            |      1419.599 | 1619.608 | 1635.968 | 1976.516 | 1916.919 |
| ConvertToDoubleBenchmark_Int64  | SumTraits                       |      2125.336 | 1970.736 | 2101.750 | 2476.539 | 2430.008 |
| ConvertToDoubleBenchmark_Int64  | SumTraits_Range52               |      2125.090 | 2099.204 | 1971.227 | 2476.164 | 2432.635 |
| ConvertToDoubleBenchmark_Int64  | Sum128Bcl                       |               |          |          | 2471.941 | 2433.292 |
| ConvertToDoubleBenchmark_Int64  | Sum128Base_Basic                |       248.785 |  645.273 |  639.294 |  648.895 |  646.964 |
| ConvertToDoubleBenchmark_Int64  | Sum128Base                      |       247.894 |  644.772 |  634.464 | 2477.441 | 2429.587 |
| ConvertToDoubleBenchmark_Int64  | Sum128Base_Range52_Impl         |       246.752 |  647.550 |  634.777 | 1964.186 | 1919.070 |
| ConvertToDoubleBenchmark_Int64  | Sum128AdvSimd_Range52           |               |  808.461 |  813.233 | 2478.187 | 2433.021 |
| ConvertToDoubleBenchmark_Int64  | Sum128AdvSimd_Range52_Impl      |               |  699.634 |  810.728 | 1014.160 |  988.711 |
| ConvertToDoubleBenchmark_Int64  | Sum128Traits                    |       248.726 | 2104.629 | 1966.672 | 2477.574 | 2433.779 |
| ConvertToDoubleBenchmark_Int64  | Sum128Traits_Range52            |       248.032 | 1972.364 | 2097.259 | 2477.604 | 2433.642 |
| ConvertToDoubleBenchmark_Int64  | Sum256Bcl                       |               |          |          |  220.323 | 3360.087 |
| ConvertToDoubleBenchmark_Int64  | Sum256Base_Basic                |       155.051 |  227.355 |  226.258 |  258.481 |  643.212 |
| ConvertToDoubleBenchmark_Int64  | Sum256Base                      |       142.065 |  201.891 |  201.544 |  220.275 | 3355.438 |
| ConvertToDoubleBenchmark_Int64  | Sum256Base_Range52_Impl         |       134.796 |  201.758 |  201.625 |   96.582 | 2131.072 |
| ConvertToDoubleBenchmark_Int64  | Sum256Avx2_Bcl                  |               |          |          |          |          |
| ConvertToDoubleBenchmark_Int64  | Sum256Avx2_HwScalar             |               |          |          |          |          |
| ConvertToDoubleBenchmark_Int64  | Sum256Avx2_Range52              |               |          |          |          |          |
| ConvertToDoubleBenchmark_Int64  | Sum256Traits                    |       123.684 |  201.896 |  201.291 |  220.394 | 3353.365 |
| ConvertToDoubleBenchmark_Int64  | Sum256Traits_Range52            |       123.650 |  201.946 |  201.594 |  189.809 | 3361.564 |
| ConvertToDoubleBenchmark_Int64  | Sum512Bcl                       |               |          |          |          | 3397.917 |
| ConvertToDoubleBenchmark_Int64  | Sum512Base                      |               |          |          |          | 3386.558 |
| ConvertToDoubleBenchmark_Int64  | Sum512Traits                    |               |          |          |          | 3373.171 |
| ConvertToDoubleBenchmark_UInt64 | SumScalar                       |       822.580 |  822.854 |  821.698 |  929.269 |  929.381 |
| ConvertToDoubleBenchmark_UInt64 | SumBcl                          |      2092.470 | 2125.892 | 1984.585 | 2444.958 | 2481.167 |
| ConvertToDoubleBenchmark_UInt64 | SumBase_Range52_Impl            |      1457.436 | 1651.605 | 1652.599 | 1954.375 | 1965.794 |
| ConvertToDoubleBenchmark_UInt64 | SumTraits                       |      1972.154 | 2124.522 | 2123.248 | 2437.301 | 2472.410 |
| ConvertToDoubleBenchmark_UInt64 | SumTraits_Range52               |      1971.364 | 1985.782 | 1985.624 | 2428.823 | 2475.657 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Bcl                       |               |          |          | 2441.717 | 2475.390 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Base_Basic                |       223.732 |  671.938 |  678.677 |  631.633 |  650.931 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Base                      |       224.177 |  670.521 |  673.479 | 2448.406 | 2471.611 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Base_Range52_Impl         |       223.730 |  675.576 |  673.407 | 1931.942 | 1966.954 |
| ConvertToDoubleBenchmark_UInt64 | Sum128AdvSimd_Range52           |               |  891.078 |  842.760 | 2446.379 | 2470.735 |
| ConvertToDoubleBenchmark_UInt64 | Sum128AdvSimd_Range52_Impl      |               |  699.336 |  840.903 |  974.014 | 1091.910 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Traits                    |       224.207 | 2105.191 | 2125.258 | 2447.988 | 2471.237 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Traits_Range52            |       223.060 | 1974.663 | 1984.017 | 2443.880 | 2468.289 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Bcl                       |               |          |          |  221.729 | 3939.407 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Base_Basic                |       150.819 |  229.703 |  229.630 |  255.227 |  666.310 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Base                      |       139.822 |  202.330 |  201.942 |  221.794 | 3936.665 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Base_Range52_Impl         |       130.571 |  202.277 |  202.039 |  107.622 | 2284.839 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Avx2_Bcl                  |               |          |          |          |          |
| ConvertToDoubleBenchmark_UInt64 | Sum256Avx2_Range52              |               |          |          |          |          |
| ConvertToDoubleBenchmark_UInt64 | Sum256Traits                    |       118.755 |  202.384 |  201.904 |  219.179 | 3949.787 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Traits_Range52            |       120.560 |  202.221 |  202.074 |  190.500 | 3948.189 |
| ConvertToDoubleBenchmark_UInt64 | Sum512Bcl                       |               |          |          |          | 3775.580 |
| ConvertToDoubleBenchmark_UInt64 | Sum512Base                      |               |          |          |          | 3781.553 |
| ConvertToDoubleBenchmark_UInt64 | Sum512Traits                    |               |          |          |          | 3795.193 |
| ConvertToInt64Benchmark_Double  | SumScalar                       |       721.978 |  728.604 |  725.987 | 1138.664 | 1140.359 |
| ConvertToInt64Benchmark_Double  | SumBcl                          |      2125.322 | 2101.559 | 1970.241 | 2478.246 | 2442.694 |
| ConvertToInt64Benchmark_Double  | SumBase_Range52_Impl            |       397.263 |  769.632 |  797.162 |  858.902 |  996.661 |
| ConvertToInt64Benchmark_Double  | SumBase_Range52RoundToEven      |      1625.790 | 1629.327 | 1772.770 | 1976.347 | 1916.926 |
| ConvertToInt64Benchmark_Double  | SumTraits                       |      2083.430 | 2105.549 | 1971.068 | 2478.113 | 2434.718 |
| ConvertToInt64Benchmark_Double  | SumTraits_Range52               |      2070.814 | 2103.203 | 1969.692 | 2478.920 | 2434.657 |
| ConvertToInt64Benchmark_Double  | SumTraits_Range52RoundToEven    |      1606.876 | 2103.089 | 1967.876 | 2469.312 | 2434.697 |
| ConvertToInt64Benchmark_Double  | Sum128Bcl                       |               |          |          | 2476.826 | 2433.753 |
| ConvertToInt64Benchmark_Double  | Sum128Base_Basic                |       254.742 |  651.343 |  637.036 |  658.409 |  638.889 |
| ConvertToInt64Benchmark_Double  | Sum128Base                      |       252.064 |  647.361 |  636.899 | 2476.758 | 2431.186 |
| ConvertToInt64Benchmark_Double  | Sum128Base_Range52_Impl         |       249.270 |  652.023 |  637.189 | 1102.667 | 1001.485 |
| ConvertToInt64Benchmark_Double  | Sum128AdvSimd_Range52           |               |  690.677 |  698.669 | 2481.384 | 2431.848 |
| ConvertToInt64Benchmark_Double  | Sum128AdvSimd_Range52_Impl      |               |  687.247 |  694.498 |  830.249 |  857.791 |
| ConvertToInt64Benchmark_Double  | Sum128Traits                    |       253.779 | 1974.253 | 2097.498 | 2479.130 | 2435.131 |
| ConvertToInt64Benchmark_Double  | Sum128Traits_Range52            |       252.263 | 1972.642 | 2100.457 | 2477.099 | 2432.061 |
| ConvertToInt64Benchmark_Double  | Sum128Traits_Range52RoundToEven |       251.048 | 1946.735 | 2102.340 | 2474.462 | 2435.906 |
| ConvertToInt64Benchmark_Double  | Sum256Bcl                       |               |          |          |  274.035 | 3352.972 |
| ConvertToInt64Benchmark_Double  | Sum256Base_Basic                |       156.824 |  250.287 |  249.968 |  259.074 |  645.398 |
| ConvertToInt64Benchmark_Double  | Sum256Base                      |       144.297 |  218.587 |  218.279 |  233.156 | 3349.217 |
| ConvertToInt64Benchmark_Double  | Sum256Base_Range52_Impl         |       143.702 |  218.637 |  218.202 |   48.950 | 1101.062 |
| ConvertToInt64Benchmark_Double  | Sum256Avx2_HwScalar             |               |          |          |          |          |
| ConvertToInt64Benchmark_Double  | Sum256Avx2_ShiftVar             |               |          |          |          |          |
| ConvertToInt64Benchmark_Double  | Sum256Avx2_ShiftVarFix          |               |          |          |          |          |
| ConvertToInt64Benchmark_Double  | Sum256Avx2_Range52              |               |          |          |          |          |
| ConvertToInt64Benchmark_Double  | Sum256Traits                    |       124.653 |  218.393 |  218.222 |  232.200 | 3179.954 |
| ConvertToInt64Benchmark_Double  | Sum256Traits_Range52            |       126.220 |  218.485 |  218.143 |  195.693 | 3318.784 |
| ConvertToInt64Benchmark_Double  | Sum256Traits_Range52RoundToEven |       125.134 |  218.414 |  218.306 |  104.302 | 2126.039 |
| ConvertToInt64Benchmark_Double  | Sum512Bcl                       |               |          |          |          | 3378.058 |
| ConvertToInt64Benchmark_Double  | Sum512Base                      |               |          |          |          | 3372.974 |
| ConvertToInt64Benchmark_Double  | Sum512Traits                    |               |          |          |          | 3375.953 |
| ConvertToUInt64Benchmark_Double | SumScalar                       |       729.403 |  726.411 |  727.146 | 1140.096 | 1139.760 |
| ConvertToUInt64Benchmark_Double | SumBcl                          |       201.039 |  260.913 |  326.070 | 2441.726 | 2476.672 |
| ConvertToUInt64Benchmark_Double | SumBase_Range52_Impl            |       365.337 |  795.560 |  812.664 |  840.547 | 1093.957 |
| ConvertToUInt64Benchmark_Double | SumBase_Range52RoundToEven      |      1409.023 | 1647.945 | 1648.076 | 1948.516 | 1968.423 |
| ConvertToUInt64Benchmark_Double | SumTraits                       |       204.188 | 1985.050 | 2100.218 | 2443.790 | 2473.393 |
| ConvertToUInt64Benchmark_Double | SumTraits_Range52               |       372.517 | 1984.815 | 2087.182 | 2443.184 | 2461.760 |
| ConvertToUInt64Benchmark_Double | SumTraits_Range52RoundToEven    |      1456.974 | 1985.529 | 2117.388 | 2447.064 | 2468.781 |
| ConvertToUInt64Benchmark_Double | Sum128Bcl                       |               |          |          | 2436.402 | 2472.723 |
| ConvertToUInt64Benchmark_Double | Sum128Base_Basic                |       239.558 |  675.535 |  656.784 |  641.221 |  662.527 |
| ConvertToUInt64Benchmark_Double | Sum128Base                      |       242.772 |  675.500 |  670.621 | 2443.997 | 2474.604 |
| ConvertToUInt64Benchmark_Double | Sum128Base_Range52_Impl         |       235.642 |  675.657 |  668.004 |  993.160 | 1094.770 |
| ConvertToUInt64Benchmark_Double | Sum128AdvSimd_Range52           |               |  744.302 |  752.353 | 2443.414 | 2471.321 |
| ConvertToUInt64Benchmark_Double | Sum128AdvSimd_Range52_Impl      |               |  750.527 |  751.758 |  748.164 |  954.850 |
| ConvertToUInt64Benchmark_Double | Sum128Traits                    |       238.933 | 2126.551 | 1980.894 | 2438.747 | 2471.647 |
| ConvertToUInt64Benchmark_Double | Sum128Traits_Range52            |       241.094 | 2126.259 | 1984.041 | 2441.300 | 2470.676 |
| ConvertToUInt64Benchmark_Double | Sum128Traits_Range52RoundToEven |       238.221 | 2123.621 | 1982.111 | 2438.515 | 2473.339 |
| ConvertToUInt64Benchmark_Double | Sum256Bcl                       |               |          |          |  271.040 | 3927.520 |
| ConvertToUInt64Benchmark_Double | Sum256Base_Basic                |       154.413 |  254.081 |  255.399 |  257.588 |  651.238 |
| ConvertToUInt64Benchmark_Double | Sum256Base                      |       141.386 |  220.549 |  220.414 |  229.338 | 3911.748 |
| ConvertToUInt64Benchmark_Double | Sum256Base_Range52_Impl         |       144.068 |  220.734 |  220.382 |   51.492 | 1116.385 |
| ConvertToUInt64Benchmark_Double | Sum256Avx2_ShiftVar             |               |          |          |          |          |
| ConvertToUInt64Benchmark_Double | Sum256Avx2_Range52              |               |          |          |          |          |
| ConvertToUInt64Benchmark_Double | Sum256Traits                    |       124.103 |  220.697 |  220.382 |  230.015 | 3930.058 |
| ConvertToUInt64Benchmark_Double | Sum256Traits_Range52            |       123.669 |  220.602 |  219.796 |  229.512 | 3796.007 |
| ConvertToUInt64Benchmark_Double | Sum256Traits_Range52RoundToEven |       123.421 |  220.605 |  220.250 |  117.127 | 2341.065 |
| ConvertToUInt64Benchmark_Double | Sum512Bcl                       |               |          |          |          | 3808.571 |
| ConvertToUInt64Benchmark_Double | Sum512Base                      |               |          |          |          | 3801.655 |
| ConvertToUInt64Benchmark_Double | Sum512Traits                    |               |          |          |          | 3728.360 |

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                            | Method                          | .NET 8.0 |
| :------------------------------ | :------------------------------ | -------: |
| ConvertToDoubleBenchmark_Int64  | SumScalar                       |   40.937 |
| ConvertToDoubleBenchmark_Int64  | SumBcl                          |   18.228 |
| ConvertToDoubleBenchmark_Int64  | SumBase_Range52_Impl            |   12.528 |
| ConvertToDoubleBenchmark_Int64  | SumTraits                       |   35.202 |
| ConvertToDoubleBenchmark_Int64  | SumTraits_Range52               |   89.154 |
| ConvertToDoubleBenchmark_Int64  | Sum128Bcl                       |   29.015 |
| ConvertToDoubleBenchmark_Int64  | Sum128Base_Basic                |   71.150 |
| ConvertToDoubleBenchmark_Int64  | Sum128Base                      |   30.713 |
| ConvertToDoubleBenchmark_Int64  | Sum128Base_Range52_Impl         |   12.844 |
| ConvertToDoubleBenchmark_Int64  | Sum128AdvSimd_Range52           |          |
| ConvertToDoubleBenchmark_Int64  | Sum128AdvSimd_Range52_Impl      |          |
| ConvertToDoubleBenchmark_Int64  | Sum128Traits                    |   30.739 |
| ConvertToDoubleBenchmark_Int64  | Sum128Traits_Range52            |  102.404 |
| ConvertToDoubleBenchmark_Int64  | Sum256Bcl                       |    8.346 |
| ConvertToDoubleBenchmark_Int64  | Sum256Base_Basic                |   12.310 |
| ConvertToDoubleBenchmark_Int64  | Sum256Base                      |    8.214 |
| ConvertToDoubleBenchmark_Int64  | Sum256Base_Range52_Impl         |    4.071 |
| ConvertToDoubleBenchmark_Int64  | Sum256Avx2_Bcl                  |          |
| ConvertToDoubleBenchmark_Int64  | Sum256Avx2_HwScalar             |          |
| ConvertToDoubleBenchmark_Int64  | Sum256Avx2_Range52              |          |
| ConvertToDoubleBenchmark_Int64  | Sum256Traits                    |    6.283 |
| ConvertToDoubleBenchmark_Int64  | Sum256Traits_Range52            |    6.175 |
| ConvertToDoubleBenchmark_Int64  | Sum512Bcl                       |    7.922 |
| ConvertToDoubleBenchmark_Int64  | Sum512Base                      |    7.974 |
| ConvertToDoubleBenchmark_Int64  | Sum512Traits                    |    7.050 |
| ConvertToDoubleBenchmark_UInt64 | SumScalar                       |   34.107 |
| ConvertToDoubleBenchmark_UInt64 | SumBcl                          |   16.598 |
| ConvertToDoubleBenchmark_UInt64 | SumBase_Range52_Impl            |   16.142 |
| ConvertToDoubleBenchmark_UInt64 | SumTraits                       |   26.667 |
| ConvertToDoubleBenchmark_UInt64 | SumTraits_Range52               |   90.999 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Bcl                       |   24.331 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Base_Basic                |   44.108 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Base                      |   24.022 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Base_Range52_Impl         |   22.163 |
| ConvertToDoubleBenchmark_UInt64 | Sum128AdvSimd_Range52           |          |
| ConvertToDoubleBenchmark_UInt64 | Sum128AdvSimd_Range52_Impl      |          |
| ConvertToDoubleBenchmark_UInt64 | Sum128Traits                    |   25.196 |
| ConvertToDoubleBenchmark_UInt64 | Sum128Traits_Range52            |  102.508 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Bcl                       |    7.799 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Base_Basic                |   11.146 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Base                      |    7.735 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Base_Range52_Impl         |    6.468 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Avx2_Bcl                  |          |
| ConvertToDoubleBenchmark_UInt64 | Sum256Avx2_Range52              |          |
| ConvertToDoubleBenchmark_UInt64 | Sum256Traits                    |    5.901 |
| ConvertToDoubleBenchmark_UInt64 | Sum256Traits_Range52            |    5.639 |
| ConvertToDoubleBenchmark_UInt64 | Sum512Bcl                       |    7.776 |
| ConvertToDoubleBenchmark_UInt64 | Sum512Base                      |    7.596 |
| ConvertToDoubleBenchmark_UInt64 | Sum512Traits                    |    6.510 |
| ConvertToInt64Benchmark_Double  | SumScalar                       |   38.690 |
| ConvertToInt64Benchmark_Double  | SumBcl                          |   27.405 |
| ConvertToInt64Benchmark_Double  | SumBase_Range52_Impl            |   11.314 |
| ConvertToInt64Benchmark_Double  | SumBase_Range52RoundToEven      |   13.829 |
| ConvertToInt64Benchmark_Double  | SumTraits                       |   31.274 |
| ConvertToInt64Benchmark_Double  | SumTraits_Range52               |   87.617 |
| ConvertToInt64Benchmark_Double  | SumTraits_Range52RoundToEven    |   42.715 |
| ConvertToInt64Benchmark_Double  | Sum128Bcl                       |   28.093 |
| ConvertToInt64Benchmark_Double  | Sum128Base_Basic                |   66.348 |
| ConvertToInt64Benchmark_Double  | Sum128Base                      |   30.298 |
| ConvertToInt64Benchmark_Double  | Sum128Base_Range52_Impl         |    8.846 |
| ConvertToInt64Benchmark_Double  | Sum128AdvSimd_Range52           |          |
| ConvertToInt64Benchmark_Double  | Sum128AdvSimd_Range52_Impl      |          |
| ConvertToInt64Benchmark_Double  | Sum128Traits                    |   29.324 |
| ConvertToInt64Benchmark_Double  | Sum128Traits_Range52            |   93.164 |
| ConvertToInt64Benchmark_Double  | Sum128Traits_Range52RoundToEven |  104.034 |
| ConvertToInt64Benchmark_Double  | Sum256Bcl                       |    9.888 |
| ConvertToInt64Benchmark_Double  | Sum256Base_Basic                |   14.026 |
| ConvertToInt64Benchmark_Double  | Sum256Base                      |    9.482 |
| ConvertToInt64Benchmark_Double  | Sum256Base_Range52_Impl         |    3.017 |
| ConvertToInt64Benchmark_Double  | Sum256Avx2_HwScalar             |          |
| ConvertToInt64Benchmark_Double  | Sum256Avx2_ShiftVar             |          |
| ConvertToInt64Benchmark_Double  | Sum256Avx2_ShiftVarFix          |          |
| ConvertToInt64Benchmark_Double  | Sum256Avx2_Range52              |          |
| ConvertToInt64Benchmark_Double  | Sum256Traits                    |    6.734 |
| ConvertToInt64Benchmark_Double  | Sum256Traits_Range52            |    6.808 |
| ConvertToInt64Benchmark_Double  | Sum256Traits_Range52RoundToEven |    3.909 |
| ConvertToInt64Benchmark_Double  | Sum512Bcl                       |    7.842 |
| ConvertToInt64Benchmark_Double  | Sum512Base                      |    7.547 |
| ConvertToInt64Benchmark_Double  | Sum512Traits                    |    6.948 |
| ConvertToUInt64Benchmark_Double | SumScalar                       |   32.120 |
| ConvertToUInt64Benchmark_Double | SumBcl                          |    9.490 |
| ConvertToUInt64Benchmark_Double | SumBase_Range52_Impl            |   12.621 |
| ConvertToUInt64Benchmark_Double | SumBase_Range52RoundToEven      |   17.835 |
| ConvertToUInt64Benchmark_Double | SumTraits                       |    6.604 |
| ConvertToUInt64Benchmark_Double | SumTraits_Range52               |   98.670 |
| ConvertToUInt64Benchmark_Double | SumTraits_Range52RoundToEven    |   47.826 |
| ConvertToUInt64Benchmark_Double | Sum128Bcl                       |    7.370 |
| ConvertToUInt64Benchmark_Double | Sum128Base_Basic                |   20.218 |
| ConvertToUInt64Benchmark_Double | Sum128Base                      |    6.770 |
| ConvertToUInt64Benchmark_Double | Sum128Base_Range52_Impl         |   12.292 |
| ConvertToUInt64Benchmark_Double | Sum128AdvSimd_Range52           |          |
| ConvertToUInt64Benchmark_Double | Sum128AdvSimd_Range52_Impl      |          |
| ConvertToUInt64Benchmark_Double | Sum128Traits                    |    7.150 |
| ConvertToUInt64Benchmark_Double | Sum128Traits_Range52            |  104.650 |
| ConvertToUInt64Benchmark_Double | Sum128Traits_Range52RoundToEven |  112.940 |
| ConvertToUInt64Benchmark_Double | Sum256Bcl                       |    4.270 |
| ConvertToUInt64Benchmark_Double | Sum256Base_Basic                |    9.071 |
| ConvertToUInt64Benchmark_Double | Sum256Base                      |    4.290 |
| ConvertToUInt64Benchmark_Double | Sum256Base_Range52_Impl         |    3.623 |
| ConvertToUInt64Benchmark_Double | Sum256Avx2_ShiftVar             |          |
| ConvertToUInt64Benchmark_Double | Sum256Avx2_Range52              |          |
| ConvertToUInt64Benchmark_Double | Sum256Traits                    |    3.797 |
| ConvertToUInt64Benchmark_Double | Sum256Traits_Range52            |    3.850 |
| ConvertToUInt64Benchmark_Double | Sum256Traits_Range52RoundToEven |    5.816 |
| ConvertToUInt64Benchmark_Double | Sum512Bcl                       |    3.918 |
| ConvertToUInt64Benchmark_Double | Sum512Base                      |    3.738 |
| ConvertToUInt64Benchmark_Double | Sum512Traits                    |    3.552 |

