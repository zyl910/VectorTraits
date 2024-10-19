# Benchmark group - ConvertToSingle
([← Back](ConvertToSingle.md))

Unit of data: Million operations per second. The larger the number, the better the performance.
### X86 - AMD Ryzen 7 7840H
| Type                            | Method                | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :------------------------------ | :-------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| ConvertToInt32Benchmark_Single  | SumScalar             |       1630.472 |      1602.200 |      1581.630 |  1605.972 |  1597.362 |  1627.517 |  1619.401 |
| ConvertToInt32Benchmark_Single  | SumBcl                |      15912.052 |     17789.973 |     14829.621 | 15713.241 | 15539.150 | 15365.400 | 15823.548 |
| ConvertToInt32Benchmark_Single  | SumTraits             |      15099.891 |     17503.998 |     17248.952 | 17310.808 | 15678.784 | 16459.780 | 15641.107 |
| ConvertToInt32Benchmark_Single  | Sum128Bcl             |                |               |               |           |           |  9475.663 |  9054.950 |
| ConvertToInt32Benchmark_Single  | Sum128Base_Basic      |                |               |       548.682 |   551.191 |   550.848 |   548.157 |   538.590 |
| ConvertToInt32Benchmark_Single  | Sum128Base            |                |               |       551.666 |   550.393 |   552.314 |  9628.160 |  9203.373 |
| ConvertToInt32Benchmark_Single  | Sum128Traits          |                |               |      8863.321 |  9052.920 |  8982.045 |  9239.582 |  9237.710 |
| ConvertToInt32Benchmark_Single  | Sum256Bcl             |                |               |               |           |           | 18101.799 | 15732.990 |
| ConvertToInt32Benchmark_Single  | Sum256Base_Basic      |                |               |       961.369 |   931.225 |   963.545 |   942.958 |   882.748 |
| ConvertToInt32Benchmark_Single  | Sum256Base            |                |               |       957.205 |   924.769 |   970.366 | 15289.747 | 15539.190 |
| ConvertToInt32Benchmark_Single  | Sum256Traits          |                |               |     14959.577 | 17538.951 | 17202.988 | 15471.132 | 16186.125 |
| ConvertToInt32Benchmark_Single  | Sum512Bcl             |                |               |               |           |           |           | 18680.891 |
| ConvertToInt32Benchmark_Single  | Sum512Base            |                |               |               |           |           |           | 18954.994 |
| ConvertToInt32Benchmark_Single  | Sum512Traits          |                |               |               |           |           |           | 18802.445 |
| ConvertToSingleBenchmark_Int32  | SumScalar             |       1137.143 |      1137.861 |      1140.093 |  1135.822 |  1136.259 |  1135.125 |  1135.564 |
| ConvertToSingleBenchmark_Int32  | SumBcl                |       8835.767 |      8707.036 |      8647.600 |  8736.502 |  8642.586 |  8823.151 |  8726.305 |
| ConvertToSingleBenchmark_Int32  | SumTraits             |       8803.823 |      8752.130 |      8539.364 |  8797.362 |  8731.443 |  8553.207 |  8723.860 |
| ConvertToSingleBenchmark_Int32  | Sum128Bcl             |                |               |               |           |           |  4399.491 |  4430.521 |
| ConvertToSingleBenchmark_Int32  | Sum128Base_Basic      |                |               |       530.438 |   531.049 |   529.536 |   531.541 |   524.995 |
| ConvertToSingleBenchmark_Int32  | Sum128Base            |                |               |       527.549 |   531.137 |   530.141 |  4458.803 |  4405.545 |
| ConvertToSingleBenchmark_Int32  | Sum128Traits          |                |               |      4455.630 |  4434.143 |  4428.617 |  4462.123 |  4425.443 |
| ConvertToSingleBenchmark_Int32  | Sum256Bcl             |                |               |               |           |           |  8692.415 |  8701.684 |
| ConvertToSingleBenchmark_Int32  | Sum256Base_Basic      |                |               |       936.127 |   894.893 |   928.508 |   899.507 |   852.248 |
| ConvertToSingleBenchmark_Int32  | Sum256Base            |                |               |       942.135 |   897.976 |   929.302 |  8561.804 |  8684.858 |
| ConvertToSingleBenchmark_Int32  | Sum256Traits          |                |               |      8781.768 |  8790.093 |  8746.321 |  8767.416 |  8692.796 |
| ConvertToSingleBenchmark_Int32  | Sum512Bcl             |                |               |               |           |           |           | 14633.152 |
| ConvertToSingleBenchmark_Int32  | Sum512Base            |                |               |               |           |           |           | 15037.887 |
| ConvertToSingleBenchmark_Int32  | Sum512Traits          |                |               |               |           |           |           | 15142.981 |
| ConvertToSingleBenchmark_UInt32 | SumScalar             |       1072.826 |      1059.538 |      1121.659 |  1110.168 |  1119.513 |  1116.269 |  1120.254 |
| ConvertToSingleBenchmark_UInt32 | SumBcl                |       5654.595 |      5617.080 |      5442.813 |  5505.034 |  5515.747 |  8494.809 |  8268.436 |
| ConvertToSingleBenchmark_UInt32 | SumTraits             |       5683.478 |      5591.721 |      6873.676 |  8400.853 |  8348.390 |  8419.775 |  8682.619 |
| ConvertToSingleBenchmark_UInt32 | Sum128Bcl             |                |               |               |           |           |  4298.461 |  4236.672 |
| ConvertToSingleBenchmark_UInt32 | Sum128Base_Basic      |                |               |       488.456 |   488.032 |   490.576 |   490.012 |   498.822 |
| ConvertToSingleBenchmark_UInt32 | Sum128Base            |                |               |       488.143 |   490.261 |   491.493 |  4270.072 |  4226.030 |
| ConvertToSingleBenchmark_UInt32 | Sum128Traits          |                |               |      3622.898 |  4292.422 |  4272.466 |  4255.018 |  4419.974 |
| ConvertToSingleBenchmark_UInt32 | Sum256Bcl             |                |               |               |           |           |  8370.505 |  8220.850 |
| ConvertToSingleBenchmark_UInt32 | Sum256Base_Basic      |                |               |       841.164 |   827.653 |   835.950 |   889.470 |   843.819 |
| ConvertToSingleBenchmark_UInt32 | Sum256Base            |                |               |       844.933 |   830.873 |   839.426 |  8242.059 |  8245.042 |
| ConvertToSingleBenchmark_UInt32 | Sum256Traits          |                |               |      7138.485 |  8093.432 |  8367.236 |  8379.272 |  8709.060 |
| ConvertToSingleBenchmark_UInt32 | Sum512Bcl             |                |               |               |           |           |           |  1753.486 |
| ConvertToSingleBenchmark_UInt32 | Sum512Base            |                |               |               |           |           |           |  1754.635 |
| ConvertToSingleBenchmark_UInt32 | Sum512Traits          |                |               |               |           |           |           | 15204.850 |
| ConvertToUInt32Benchmark_Single | SumScalar             |       1635.654 |      1586.889 |      1606.708 |  1588.537 |  1587.979 |  1621.181 |  1623.416 |
| ConvertToUInt32Benchmark_Single | SumBcl                |        468.011 |       453.217 |       482.592 |   619.091 |   618.737 |   995.036 |   946.961 |
| ConvertToUInt32Benchmark_Single | SumTraits             |        471.692 |       453.127 |      4736.492 |  6924.970 |  7016.088 |  6876.565 | 15813.891 |
| ConvertToUInt32Benchmark_Single | Sum128Bcl             |                |               |               |           |           |   548.650 |   213.058 |
| ConvertToUInt32Benchmark_Single | Sum128Base_Basic      |                |               |       552.628 |   550.039 |   554.098 |   551.570 |   542.104 |
| ConvertToUInt32Benchmark_Single | Sum128Base            |                |               |       553.203 |   550.492 |   552.243 |   548.869 |   212.609 |
| ConvertToUInt32Benchmark_Single | Sum128Traits          |                |               |      2369.340 |  3306.192 |  3611.609 |  3567.413 |  9023.188 |
| ConvertToUInt32Benchmark_Single | Sum256Bcl             |                |               |               |           |           |   973.505 |   217.012 |
| ConvertToUInt32Benchmark_Single | Sum256Base_Basic      |                |               |       974.599 |   922.578 |   971.046 |   933.236 |   877.147 |
| ConvertToUInt32Benchmark_Single | Sum256Base            |                |               |       971.749 |   927.940 |   971.122 |   973.963 |   216.747 |
| ConvertToUInt32Benchmark_Single | Sum256Avx2_ShiftVar   |                |               |      4745.426 |  6450.934 |  6825.337 |  6980.072 |  6631.958 |
| ConvertToUInt32Benchmark_Single | Sum256Avx2_Mapping    |                |               |       970.226 |  8435.306 |  8754.300 |  8485.960 |  9184.928 |
| ConvertToUInt32Benchmark_Single | Sum256Avx2_MappingFix |                |               |       961.467 |  8567.597 |  8799.043 |  8850.060 |  9104.515 |
| ConvertToUInt32Benchmark_Single | Sum256Avx2_Mod        |                |               |       969.372 |  3522.688 |  3540.463 |  3885.464 |  3518.656 |
| ConvertToUInt32Benchmark_Single | Sum256Traits          |                |               |      4673.476 |  6565.322 |  6916.574 |  6833.298 | 16691.485 |
| ConvertToUInt32Benchmark_Single | Sum512Bcl             |                |               |               |           |           |           |   176.511 |
| ConvertToUInt32Benchmark_Single | Sum512Base            |                |               |               |           |           |           |   177.250 |
| ConvertToUInt32Benchmark_Single | Sum512Traits          |                |               |               |           |           |           | 18993.104 |

### X86 - Intel Core i5-8250U
| Type                            | Method                | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :------------------------------ | :-------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| ConvertToInt32Benchmark_Single  | SumScalar             |       1499.395 |      1669.872 |      1669.428 |  1672.903 |  1671.169 |  1691.240 |
| ConvertToInt32Benchmark_Single  | SumBcl                |      10421.773 |     10268.459 |     10814.535 | 11805.635 | 11552.363 | 11026.326 |
| ConvertToInt32Benchmark_Single  | SumTraits             |       9984.056 |     11663.138 |     10967.617 | 11915.415 | 11760.373 | 10808.847 |
| ConvertToInt32Benchmark_Single  | Sum128Bcl             |                |               |               |           |           |  6121.922 |
| ConvertToInt32Benchmark_Single  | Sum128Base_Basic      |                |               |       579.374 |   608.422 |   603.101 |   602.585 |
| ConvertToInt32Benchmark_Single  | Sum128Base            |                |               |       575.380 |   608.616 |   600.279 |  6214.614 |
| ConvertToInt32Benchmark_Single  | Sum128Traits          |                |               |      6409.819 |  6447.333 |  6430.375 |  6196.387 |
| ConvertToInt32Benchmark_Single  | Sum256Bcl             |                |               |               |           |           | 11442.853 |
| ConvertToInt32Benchmark_Single  | Sum256Base_Basic      |                |               |       947.605 |   923.714 |   474.152 |   994.278 |
| ConvertToInt32Benchmark_Single  | Sum256Base            |                |               |       958.622 |   934.587 |   474.393 | 11404.163 |
| ConvertToInt32Benchmark_Single  | Sum256Traits          |                |               |     11642.519 | 11729.918 | 11612.407 | 11382.767 |
| ConvertToSingleBenchmark_Int32  | SumScalar             |        714.586 |       846.301 |       846.210 |   846.187 |   845.809 |   846.270 |
| ConvertToSingleBenchmark_Int32  | SumBcl                |       5342.687 |      6749.984 |      6748.989 |  6744.484 |  6750.559 |  6759.000 |
| ConvertToSingleBenchmark_Int32  | SumTraits             |       5339.127 |      6744.116 |      6733.875 |  6738.263 |  6718.815 |  6746.860 |
| ConvertToSingleBenchmark_Int32  | Sum128Bcl             |                |               |               |           |           |  3375.873 |
| ConvertToSingleBenchmark_Int32  | Sum128Base_Basic      |                |               |       540.509 |   562.417 |   561.861 |   563.452 |
| ConvertToSingleBenchmark_Int32  | Sum128Base            |                |               |       540.556 |   563.010 |   561.658 |  3377.586 |
| ConvertToSingleBenchmark_Int32  | Sum128Traits          |                |               |      3376.766 |  3367.625 |  3378.899 |  3379.056 |
| ConvertToSingleBenchmark_Int32  | Sum256Bcl             |                |               |               |           |           |  6749.398 |
| ConvertToSingleBenchmark_Int32  | Sum256Base_Basic      |                |               |       885.249 |   862.476 |   457.374 |   932.852 |
| ConvertToSingleBenchmark_Int32  | Sum256Base            |                |               |       887.439 |   862.387 |   457.212 |  6744.415 |
| ConvertToSingleBenchmark_Int32  | Sum256Traits          |                |               |      6735.888 |  6736.699 |  6728.034 |  6752.269 |
| ConvertToSingleBenchmark_UInt32 | SumScalar             |        690.414 |       844.578 |       845.465 |   845.217 |   845.461 |   844.460 |
| ConvertToSingleBenchmark_UInt32 | SumBcl                |       3840.125 |      5511.355 |      6075.856 |  5503.989 |  5520.861 |  6576.911 |
| ConvertToSingleBenchmark_UInt32 | SumTraits             |       3804.634 |      5454.035 |      6351.457 |  6642.531 |  6590.232 |  6582.186 |
| ConvertToSingleBenchmark_UInt32 | Sum128Bcl             |                |               |               |           |           |  3374.187 |
| ConvertToSingleBenchmark_UInt32 | Sum128Base_Basic      |                |               |       482.910 |   483.249 |   483.281 |   485.149 |
| ConvertToSingleBenchmark_UInt32 | Sum128Base            |                |               |       483.071 |   483.202 |   482.868 |  3354.275 |
| ConvertToSingleBenchmark_UInt32 | Sum128Traits          |                |               |      3364.906 |  3372.597 |  3369.685 |  3374.072 |
| ConvertToSingleBenchmark_UInt32 | Sum256Bcl             |                |               |               |           |           |  6593.947 |
| ConvertToSingleBenchmark_UInt32 | Sum256Base_Basic      |                |               |       731.077 |   711.893 |   403.470 |   751.629 |
| ConvertToSingleBenchmark_UInt32 | Sum256Base            |                |               |       731.182 |   711.241 |   403.249 |  6581.442 |
| ConvertToSingleBenchmark_UInt32 | Sum256Traits          |                |               |      6364.881 |  6613.978 |  6617.517 |  6590.715 |
| ConvertToUInt32Benchmark_Single | SumScalar             |       1313.781 |      1672.603 |      1670.039 |  1671.720 |  1653.408 |  1691.514 |
| ConvertToUInt32Benchmark_Single | SumBcl                |        309.649 |       423.879 |       419.684 |   558.764 |   531.356 |  1061.923 |
| ConvertToUInt32Benchmark_Single | SumTraits             |        331.643 |       423.114 |      3994.640 |  4684.569 |  4761.244 |  5180.147 |
| ConvertToUInt32Benchmark_Single | Sum128Bcl             |                |               |               |           |           |   631.641 |
| ConvertToUInt32Benchmark_Single | Sum128Base_Basic      |                |               |       577.132 |   607.269 |   597.760 |   601.531 |
| ConvertToUInt32Benchmark_Single | Sum128Base            |                |               |       579.312 |   608.433 |   608.249 |   631.196 |
| ConvertToUInt32Benchmark_Single | Sum128Traits          |                |               |      2237.059 |  2643.752 |  2664.080 |  2702.577 |
| ConvertToUInt32Benchmark_Single | Sum256Bcl             |                |               |               |           |           |  1061.490 |
| ConvertToUInt32Benchmark_Single | Sum256Base_Basic      |                |               |       954.871 |   932.925 |   472.764 |   988.012 |
| ConvertToUInt32Benchmark_Single | Sum256Base            |                |               |       958.572 |   913.115 |   473.770 |  1059.217 |
| ConvertToUInt32Benchmark_Single | Sum256Avx2_ShiftVar   |                |               |      4020.361 |  4707.837 |  4756.635 |  4746.598 |
| ConvertToUInt32Benchmark_Single | Sum256Avx2_Mapping    |                |               |       954.356 |  5553.033 |  5571.145 |  5887.329 |
| ConvertToUInt32Benchmark_Single | Sum256Avx2_MappingFix |                |               |       959.677 |  4447.789 |  4426.557 |  5050.234 |
| ConvertToUInt32Benchmark_Single | Sum256Avx2_Mod        |                |               |       958.940 |  2345.947 |  2394.794 |  2462.422 |
| ConvertToUInt32Benchmark_Single | Sum256Traits          |                |               |      3989.698 |  4698.052 |  4754.504 |  5145.548 |

### Arm - Apple M2
| Type                            | Method                | .NET 6.0 | .NET 7.0 |  .NET 8.0 |
| :------------------------------ | :-------------------- | -------: | -------: | --------: |
| ConvertToInt32Benchmark_Single  | SumScalar             | 1690.973 | 2247.628 |  2247.655 |
| ConvertToInt32Benchmark_Single  | SumBcl                | 6801.280 | 6805.150 |  6805.495 |
| ConvertToInt32Benchmark_Single  | SumTraits             | 6802.257 | 6804.241 |  6805.283 |
| ConvertToInt32Benchmark_Single  | Sum128Bcl             |          | 6804.317 |  6805.507 |
| ConvertToInt32Benchmark_Single  | Sum128Base_Basic      | 3065.254 | 3087.220 |  3073.866 |
| ConvertToInt32Benchmark_Single  | Sum128Base            | 3064.572 | 6803.630 |  6803.913 |
| ConvertToInt32Benchmark_Single  | Sum128Traits          | 6803.938 | 6804.548 |  6805.082 |
| ConvertToInt32Benchmark_Single  | Sum256Bcl             |          |  903.966 | 13605.370 |
| ConvertToInt32Benchmark_Single  | Sum256Base_Basic      |  810.121 |  895.740 |  3347.811 |
| ConvertToInt32Benchmark_Single  | Sum256Base            |  755.591 |  809.101 | 13605.292 |
| ConvertToInt32Benchmark_Single  | Sum256Traits          |  756.232 |  809.229 | 13605.202 |
| ConvertToInt32Benchmark_Single  | Sum512Bcl             |          |          | 22891.207 |
| ConvertToInt32Benchmark_Single  | Sum512Base            |          |          | 22888.487 |
| ConvertToInt32Benchmark_Single  | Sum512Traits          |          |          | 22887.045 |
| ConvertToSingleBenchmark_Int32  | SumScalar             | 1132.160 | 1133.791 |  1134.031 |
| ConvertToSingleBenchmark_Int32  | SumBcl                | 4663.289 | 4537.551 |  4538.086 |
| ConvertToSingleBenchmark_Int32  | SumTraits             | 4663.170 | 4536.268 |  4538.629 |
| ConvertToSingleBenchmark_Int32  | Sum128Bcl             |          | 4537.102 |  4560.307 |
| ConvertToSingleBenchmark_Int32  | Sum128Base_Basic      | 2334.961 | 2352.911 |  2360.302 |
| ConvertToSingleBenchmark_Int32  | Sum128Base            | 2336.167 | 4537.358 |  4538.604 |
| ConvertToSingleBenchmark_Int32  | Sum128Traits          | 4595.711 | 4537.345 |  4658.983 |
| ConvertToSingleBenchmark_Int32  | Sum256Bcl             |          |  702.863 |  9077.718 |
| ConvertToSingleBenchmark_Int32  | Sum256Base_Basic      |  682.021 |  780.699 |  2433.168 |
| ConvertToSingleBenchmark_Int32  | Sum256Base            |  653.755 |  702.801 |  9076.229 |
| ConvertToSingleBenchmark_Int32  | Sum256Traits          |  653.747 |  702.845 |  9076.707 |
| ConvertToSingleBenchmark_Int32  | Sum512Bcl             |          |          | 17917.218 |
| ConvertToSingleBenchmark_Int32  | Sum512Base            |          |          | 17913.784 |
| ConvertToSingleBenchmark_Int32  | Sum512Traits          |          |          | 17915.715 |
| ConvertToSingleBenchmark_UInt32 | SumScalar             | 1133.484 | 1133.997 |  1134.132 |
| ConvertToSingleBenchmark_UInt32 | SumBcl                | 4663.681 | 4537.505 |  4577.987 |
| ConvertToSingleBenchmark_UInt32 | SumTraits             | 4576.861 | 4537.523 |  4666.118 |
| ConvertToSingleBenchmark_UInt32 | Sum128Bcl             |          | 4537.233 |  4664.878 |
| ConvertToSingleBenchmark_UInt32 | Sum128Base_Basic      | 2360.858 | 2383.544 |  2382.817 |
| ConvertToSingleBenchmark_UInt32 | Sum128Base            | 2357.992 | 4537.410 |  4665.556 |
| ConvertToSingleBenchmark_UInt32 | Sum128Traits          | 4535.764 | 4536.979 |  4665.555 |
| ConvertToSingleBenchmark_UInt32 | Sum256Bcl             |          |  704.977 |  9078.470 |
| ConvertToSingleBenchmark_UInt32 | Sum256Base_Basic      |  681.652 |  782.099 |  2430.794 |
| ConvertToSingleBenchmark_UInt32 | Sum256Base            |  657.716 |  705.113 |  9079.887 |
| ConvertToSingleBenchmark_UInt32 | Sum256Traits          |  656.861 |  704.846 |  9078.151 |
| ConvertToSingleBenchmark_UInt32 | Sum512Bcl             |          |          | 18112.773 |
| ConvertToSingleBenchmark_UInt32 | Sum512Base            |          |          | 18116.923 |
| ConvertToSingleBenchmark_UInt32 | Sum512Traits          |          |          | 18115.681 |
| ConvertToUInt32Benchmark_Single | SumScalar             | 1690.286 | 2248.250 |  2247.575 |
| ConvertToUInt32Benchmark_Single | SumBcl                | 1108.650 | 6804.827 |  6804.401 |
| ConvertToUInt32Benchmark_Single | SumTraits             | 6802.555 | 6804.004 |  6804.316 |
| ConvertToUInt32Benchmark_Single | Sum128Bcl             |          | 6805.283 |  6804.048 |
| ConvertToUInt32Benchmark_Single | Sum128Base_Basic      | 2989.871 | 3027.167 |  3003.904 |
| ConvertToUInt32Benchmark_Single | Sum128Base            | 2986.495 | 6802.354 |  6804.732 |
| ConvertToUInt32Benchmark_Single | Sum128Traits          | 6802.912 | 6805.072 |  6804.532 |
| ConvertToUInt32Benchmark_Single | Sum256Bcl             |          |  891.902 | 13599.466 |
| ConvertToUInt32Benchmark_Single | Sum256Base_Basic      |  797.934 |  889.466 |  3334.506 |
| ConvertToUInt32Benchmark_Single | Sum256Base            |  748.955 |  806.503 | 13606.273 |
| ConvertToUInt32Benchmark_Single | Sum256Avx2_ShiftVar   |          |          |           |
| ConvertToUInt32Benchmark_Single | Sum256Avx2_Mapping    |          |          |           |
| ConvertToUInt32Benchmark_Single | Sum256Avx2_MappingFix |          |          |           |
| ConvertToUInt32Benchmark_Single | Sum256Avx2_Mod        |          |          |           |
| ConvertToUInt32Benchmark_Single | Sum256Traits          |  747.448 |  806.510 | 13604.434 |
| ConvertToUInt32Benchmark_Single | Sum512Bcl             |          |          | 22755.552 |
| ConvertToUInt32Benchmark_Single | Sum512Base            |          |          | 22751.913 |
| ConvertToUInt32Benchmark_Single | Sum512Traits          |          |          | 22747.278 |

### Arm - AWS Arm t4g.small
| Type                            | Method                | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 | .NET 8.0 |
| :------------------------------ | :-------------------- | ------------: | -------: | -------: | -------: | -------: |
| ConvertToInt32Benchmark_Single  | SumScalar             |       722.522 |  730.324 |  737.591 | 1137.104 | 1137.747 |
| ConvertToInt32Benchmark_Single  | SumBcl                |      3902.092 | 4205.337 | 3947.421 | 4822.279 | 4881.004 |
| ConvertToInt32Benchmark_Single  | SumTraits             |      4113.561 | 4220.478 | 3955.153 | 4832.863 | 4871.246 |
| ConvertToInt32Benchmark_Single  | Sum128Bcl             |               |          |          | 4827.282 | 4887.528 |
| ConvertToInt32Benchmark_Single  | Sum128Base_Basic      |       184.526 |  355.387 |  359.258 |  363.970 |  364.657 |
| ConvertToInt32Benchmark_Single  | Sum128Base            |       184.312 |  355.546 |  357.873 | 4817.546 | 4883.848 |
| ConvertToInt32Benchmark_Single  | Sum128Traits          |       186.411 | 4227.910 | 4183.219 | 4829.659 | 4885.176 |
| ConvertToInt32Benchmark_Single  | Sum256Bcl             |               |          |          |  269.018 | 4785.064 |
| ConvertToInt32Benchmark_Single  | Sum256Base_Basic      |       215.787 |  295.861 |  294.115 |  284.104 |  650.743 |
| ConvertToInt32Benchmark_Single  | Sum256Base            |       211.556 |  282.544 |  281.548 |  251.327 | 4785.609 |
| ConvertToInt32Benchmark_Single  | Sum256Traits          |       191.858 |  282.182 |  281.415 |  252.140 | 4763.996 |
| ConvertToInt32Benchmark_Single  | Sum512Bcl             |               |          |          |          | 4666.568 |
| ConvertToInt32Benchmark_Single  | Sum512Base            |               |          |          |          | 4674.397 |
| ConvertToInt32Benchmark_Single  | Sum512Traits          |               |          |          |          | 4676.256 |
| ConvertToSingleBenchmark_Int32  | SumScalar             |       809.923 |  824.898 |  822.007 |  930.955 |  931.498 |
| ConvertToSingleBenchmark_Int32  | SumBcl                |      3858.295 | 4138.441 | 3900.247 | 4869.023 | 4822.334 |
| ConvertToSingleBenchmark_Int32  | SumTraits             |      4148.509 | 4165.666 | 3919.405 | 4843.614 | 4802.118 |
| ConvertToSingleBenchmark_Int32  | Sum128Bcl             |               |          |          | 4835.356 | 4825.332 |
| ConvertToSingleBenchmark_Int32  | Sum128Base_Basic      |       184.684 |  346.491 |  349.925 |  356.505 |  355.720 |
| ConvertToSingleBenchmark_Int32  | Sum128Base            |       180.604 |  346.497 |  349.370 | 4849.622 | 4819.486 |
| ConvertToSingleBenchmark_Int32  | Sum128Traits          |       184.348 | 4176.861 | 3829.111 | 4847.614 | 4829.707 |
| ConvertToSingleBenchmark_Int32  | Sum256Bcl             |               |          |          |  255.972 | 4756.208 |
| ConvertToSingleBenchmark_Int32  | Sum256Base_Basic      |       215.757 |  293.297 |  291.321 |  285.745 |  638.223 |
| ConvertToSingleBenchmark_Int32  | Sum256Base            |       211.299 |  279.293 |  278.290 |  255.979 | 4752.557 |
| ConvertToSingleBenchmark_Int32  | Sum256Traits          |       192.263 |  279.370 |  278.461 |  255.891 | 4751.960 |
| ConvertToSingleBenchmark_Int32  | Sum512Bcl             |               |          |          |          | 4634.951 |
| ConvertToSingleBenchmark_Int32  | Sum512Base            |               |          |          |          | 4640.770 |
| ConvertToSingleBenchmark_Int32  | Sum512Traits          |               |          |          |          | 4630.138 |
| ConvertToSingleBenchmark_UInt32 | SumScalar             |       760.595 |  760.009 |  821.357 |  930.976 |  932.427 |
| ConvertToSingleBenchmark_UInt32 | SumBcl                |      4076.928 | 3947.351 | 4234.936 | 4796.374 | 4884.294 |
| ConvertToSingleBenchmark_UInt32 | SumTraits             |      3887.980 | 4221.771 | 4201.342 | 4805.454 | 4879.066 |
| ConvertToSingleBenchmark_UInt32 | Sum128Bcl             |               |          |          | 4812.570 | 4880.474 |
| ConvertToSingleBenchmark_UInt32 | Sum128Base_Basic      |       173.494 |  318.773 |  350.329 |  356.742 |  355.945 |
| ConvertToSingleBenchmark_UInt32 | Sum128Base            |       172.976 |  318.824 |  349.707 | 4793.428 | 4851.230 |
| ConvertToSingleBenchmark_UInt32 | Sum128Traits          |       176.665 | 4226.620 | 4231.115 | 4804.313 | 4875.531 |
| ConvertToSingleBenchmark_UInt32 | Sum256Bcl             |               |          |          |  255.416 | 4780.166 |
| ConvertToSingleBenchmark_UInt32 | Sum256Base_Basic      |       207.291 |  280.236 |  295.242 |  284.241 |  642.620 |
| ConvertToSingleBenchmark_UInt32 | Sum256Base            |       206.743 |  268.799 |  282.117 |  255.465 | 4781.900 |
| ConvertToSingleBenchmark_UInt32 | Sum256Traits          |       186.586 |  267.687 |  282.214 |  255.165 | 4782.957 |
| ConvertToSingleBenchmark_UInt32 | Sum512Bcl             |               |          |          |          | 4659.337 |
| ConvertToSingleBenchmark_UInt32 | Sum512Base            |               |          |          |          | 4667.502 |
| ConvertToSingleBenchmark_UInt32 | Sum512Traits          |               |          |          |          | 4658.975 |
| ConvertToUInt32Benchmark_Single | SumScalar             |       717.726 |  730.633 |  733.949 | 1137.381 | 1137.277 |
| ConvertToUInt32Benchmark_Single | SumBcl                |       215.368 |  323.018 |  178.389 | 4858.839 | 4834.301 |
| ConvertToUInt32Benchmark_Single | SumTraits             |       217.899 | 3925.049 | 4179.172 | 4838.230 | 4829.986 |
| ConvertToUInt32Benchmark_Single | Sum128Bcl             |               |          |          | 4851.875 | 4832.099 |
| ConvertToUInt32Benchmark_Single | Sum128Base_Basic      |       188.799 |  355.954 |  359.086 |  363.074 |  363.991 |
| ConvertToUInt32Benchmark_Single | Sum128Base            |       191.431 |  355.856 |  358.862 | 4837.072 | 4827.522 |
| ConvertToUInt32Benchmark_Single | Sum128Traits          |       187.846 | 3914.757 | 4167.533 | 4839.253 | 4828.628 |
| ConvertToUInt32Benchmark_Single | Sum256Bcl             |               |          |          |  270.140 | 4762.726 |
| ConvertToUInt32Benchmark_Single | Sum256Base_Basic      |       218.762 |  292.844 |  291.046 |  284.346 |  644.913 |
| ConvertToUInt32Benchmark_Single | Sum256Base            |       213.072 |  279.182 |  277.942 |  252.859 | 4753.753 |
| ConvertToUInt32Benchmark_Single | Sum256Avx2_ShiftVar   |               |          |          |          |          |
| ConvertToUInt32Benchmark_Single | Sum256Avx2_Mapping    |               |          |          |          |          |
| ConvertToUInt32Benchmark_Single | Sum256Avx2_MappingFix |               |          |          |          |          |
| ConvertToUInt32Benchmark_Single | Sum256Avx2_Mod        |               |          |          |          |          |
| ConvertToUInt32Benchmark_Single | Sum256Traits          |       195.519 |  279.461 |  279.311 |  252.770 | 4757.745 |
| ConvertToUInt32Benchmark_Single | Sum512Bcl             |               |          |          |          | 4627.514 |
| ConvertToUInt32Benchmark_Single | Sum512Base            |               |          |          |          | 4631.300 |
| ConvertToUInt32Benchmark_Single | Sum512Traits          |               |          |          |          | 4624.488 |

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                            | Method                | .NET 8.0 |
| :------------------------------ | :-------------------- | -------: |
| ConvertToInt32Benchmark_Single  | SumScalar             |   40.421 |
| ConvertToInt32Benchmark_Single  | SumBcl                |   57.952 |
| ConvertToInt32Benchmark_Single  | SumTraits             |  226.210 |
| ConvertToInt32Benchmark_Single  | Sum128Bcl             |   39.901 |
| ConvertToInt32Benchmark_Single  | Sum128Base_Basic      |   98.294 |
| ConvertToInt32Benchmark_Single  | Sum128Base            |   39.713 |
| ConvertToInt32Benchmark_Single  | Sum128Traits          |  213.609 |
| ConvertToInt32Benchmark_Single  | Sum256Bcl             |   34.769 |
| ConvertToInt32Benchmark_Single  | Sum256Base_Basic      |  103.552 |
| ConvertToInt32Benchmark_Single  | Sum256Base            |   34.709 |
| ConvertToInt32Benchmark_Single  | Sum256Traits          |   34.721 |
| ConvertToInt32Benchmark_Single  | Sum512Bcl             |   18.067 |
| ConvertToInt32Benchmark_Single  | Sum512Base            |   18.214 |
| ConvertToInt32Benchmark_Single  | Sum512Traits          |   17.737 |
| ConvertToSingleBenchmark_Int32  | SumScalar             |   46.367 |
| ConvertToSingleBenchmark_Int32  | SumBcl                |   71.367 |
| ConvertToSingleBenchmark_Int32  | SumTraits             |  237.582 |
| ConvertToSingleBenchmark_Int32  | Sum128Bcl             |   47.429 |
| ConvertToSingleBenchmark_Int32  | Sum128Base_Basic      |  121.750 |
| ConvertToSingleBenchmark_Int32  | Sum128Base            |   46.444 |
| ConvertToSingleBenchmark_Int32  | Sum128Traits          |  246.211 |
| ConvertToSingleBenchmark_Int32  | Sum256Bcl             |   36.586 |
| ConvertToSingleBenchmark_Int32  | Sum256Base_Basic      |  129.587 |
| ConvertToSingleBenchmark_Int32  | Sum256Base            |   38.415 |
| ConvertToSingleBenchmark_Int32  | Sum256Traits          |   34.384 |
| ConvertToSingleBenchmark_Int32  | Sum512Bcl             |   23.886 |
| ConvertToSingleBenchmark_Int32  | Sum512Base            |   22.686 |
| ConvertToSingleBenchmark_Int32  | Sum512Traits          |   23.203 |
| ConvertToSingleBenchmark_UInt32 | SumScalar             |   37.513 |
| ConvertToSingleBenchmark_UInt32 | SumBcl                |   28.468 |
| ConvertToSingleBenchmark_UInt32 | SumTraits             |  229.014 |
| ConvertToSingleBenchmark_UInt32 | Sum128Bcl             |   31.422 |
| ConvertToSingleBenchmark_UInt32 | Sum128Base_Basic      |  100.573 |
| ConvertToSingleBenchmark_UInt32 | Sum128Base            |   31.046 |
| ConvertToSingleBenchmark_UInt32 | Sum128Traits          |  247.665 |
| ConvertToSingleBenchmark_UInt32 | Sum256Bcl             |   15.437 |
| ConvertToSingleBenchmark_UInt32 | Sum256Base_Basic      |  109.882 |
| ConvertToSingleBenchmark_UInt32 | Sum256Base            |   15.321 |
| ConvertToSingleBenchmark_UInt32 | Sum256Traits          |   13.396 |
| ConvertToSingleBenchmark_UInt32 | Sum512Bcl             |   11.922 |
| ConvertToSingleBenchmark_UInt32 | Sum512Base            |   11.764 |
| ConvertToSingleBenchmark_UInt32 | Sum512Traits          |   11.441 |
| ConvertToUInt32Benchmark_Single | SumScalar             |   37.236 |
| ConvertToUInt32Benchmark_Single | SumBcl                |   16.192 |
| ConvertToUInt32Benchmark_Single | SumTraits             |  244.893 |
| ConvertToUInt32Benchmark_Single | Sum128Bcl             |   11.352 |
| ConvertToUInt32Benchmark_Single | Sum128Base_Basic      |   28.807 |
| ConvertToUInt32Benchmark_Single | Sum128Base            |   10.602 |
| ConvertToUInt32Benchmark_Single | Sum128Traits          |  253.273 |
| ConvertToUInt32Benchmark_Single | Sum256Bcl             |    8.142 |
| ConvertToUInt32Benchmark_Single | Sum256Base_Basic      |   20.458 |
| ConvertToUInt32Benchmark_Single | Sum256Base            |    8.048 |
| ConvertToUInt32Benchmark_Single | Sum256Avx2_ShiftVar   |          |
| ConvertToUInt32Benchmark_Single | Sum256Avx2_Mapping    |          |
| ConvertToUInt32Benchmark_Single | Sum256Avx2_MappingFix |          |
| ConvertToUInt32Benchmark_Single | Sum256Avx2_Mod        |          |
| ConvertToUInt32Benchmark_Single | Sum256Traits          |    6.888 |
| ConvertToUInt32Benchmark_Single | Sum512Bcl             |    6.837 |
| ConvertToUInt32Benchmark_Single | Sum512Base            |    6.602 |
| ConvertToUInt32Benchmark_Single | Sum512Traits          |    6.314 |

