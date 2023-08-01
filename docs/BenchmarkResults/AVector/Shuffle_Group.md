# Benchmark group - Shuffle
([← Back](Shuffle.md))

Cell unit: Million operations per second.

### x86 - lntel Core i5-8250U
| Class                  | Method                          | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :--------------------- | :------------------------------ | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| ShuffleBenchmark_Int16 | SumScalar                       |       1009.132 |      1007.748 |       992.299 |  1004.370 |  1034.912 |   989.043 |
| ShuffleBenchmark_Int16 | SumBase                         |       1013.240 |      1013.121 |      1008.682 |  1033.930 |  1014.877 |  1006.813 |
| ShuffleBenchmark_Int16 | SumTraits                       |       1012.626 |      1008.900 |      6025.629 |  8058.075 |  8017.278 |  9060.106 |
| ShuffleBenchmark_Int16 | SumTraits_Args0                 |       1008.925 |       988.646 |     14845.370 | 14590.246 | 14413.193 | 14209.436 |
| ShuffleBenchmark_Int16 | SumTraits_Args                  |       1008.981 |       991.790 |     14644.219 | 14527.035 | 14198.718 | 14024.591 |
| ShuffleBenchmark_Int16 | Sum128_Bcl                      |                |               |               |           |           |           |
| ShuffleBenchmark_Int16 | Sum128_AdvSimd                  |                |               |               |           |           |           |
| ShuffleBenchmark_Int16 | Sum128Traits                    |                |               |               |           |           |           |
| ShuffleBenchmark_Int16 | Sum256_Bcl                      |                |               |               |           |           |   775.841 |
| ShuffleBenchmark_Int16 | Sum256Traits                    |                |               |      5901.995 |  8377.537 |  8572.468 | 11912.737 |
| ShuffleBenchmark_Int16 | SumKernelTraits                 |       1011.528 |      1009.289 |      7566.266 |  9381.227 |  9585.573 | 10330.592 |
| ShuffleBenchmark_Int16 | SumKernelTraits_Args0           |       1006.331 |       989.488 |     15045.753 | 14575.460 | 14464.147 | 14484.413 |
| ShuffleBenchmark_Int16 | SumKernelTraits_Args            |       1017.264 |       990.161 |     14900.553 | 13672.167 | 14556.627 | 14280.139 |
| ShuffleBenchmark_Int16 | SumKernel128_AdvSimd            |                |               |               |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel128Traits              |                |               |               |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel256_Avx2_Multiply      |                |               |      6691.139 | 10143.220 | 10283.465 | 13511.561 |
| ShuffleBenchmark_Int16 | SumKernel256_Avx2_ShiftLane     |                |               |      7181.794 |  9996.539 |  9984.497 | 10697.449 |
| ShuffleBenchmark_Int16 | SumKernel256Traits              |                |               |      7129.297 | 10172.071 | 10260.544 | 13628.575 |
| ShuffleBenchmark_Int16 | SumKernel256Traits_Args0        |                |               |     14247.517 | 14827.097 | 11449.426 | 14287.774 |
| ShuffleBenchmark_Int16 | SumKernel256Traits_Args         |                |               |     13885.080 | 14364.013 | 13974.440 | 14222.289 |
| ShuffleBenchmark_Int32 | SumScalar                       |        723.019 |       725.013 |       704.809 |   708.372 |   735.378 |   747.651 |
| ShuffleBenchmark_Int32 | SumBase                         |        718.863 |       724.428 |       722.521 |   748.893 |   715.063 |   749.342 |
| ShuffleBenchmark_Int32 | SumTraits                       |        716.509 |       724.369 |      5216.757 |  5813.206 |  7139.337 |  9250.625 |
| ShuffleBenchmark_Int32 | SumTraits_Args0                 |        716.520 |       703.636 |      9278.507 |  9221.310 |  9159.683 |  9728.639 |
| ShuffleBenchmark_Int32 | SumTraits_Args                  |        722.854 |       709.654 |      9010.834 |  9164.854 |  8992.356 |  9828.623 |
| ShuffleBenchmark_Int32 | Sum128_Bcl                      |                |               |               |           |           |           |
| ShuffleBenchmark_Int32 | Sum128_AdvSimd                  |                |               |               |           |           |           |
| ShuffleBenchmark_Int32 | Sum128Traits                    |                |               |               |           |           |           |
| ShuffleBenchmark_Int32 | Sum256_Bcl                      |                |               |               |           |           |   611.393 |
| ShuffleBenchmark_Int32 | Sum256Traits                    |                |               |      5067.112 |  7702.905 |  8561.380 |  9555.813 |
| ShuffleBenchmark_Int32 | SumKernelTraits                 |        722.441 |       725.218 |      9554.766 |  7064.711 |  6932.192 |  9996.960 |
| ShuffleBenchmark_Int32 | SumKernelTraits_Args0           |        724.689 |       706.345 |     11017.874 | 11092.301 | 11134.924 | 11279.116 |
| ShuffleBenchmark_Int32 | SumKernelTraits_Args            |        727.981 |       701.155 |     11030.886 | 10970.116 | 10510.208 | 11324.558 |
| ShuffleBenchmark_Int32 | SumKernel128_AdvSimd            |                |               |               |           |           |           |
| ShuffleBenchmark_Int32 | SumKernel128Traits              |                |               |               |           |           |           |
| ShuffleBenchmark_Int32 | SumKernel256Traits              |                |               |     11174.456 | 11051.656 |  9851.523 | 10475.013 |
| ShuffleBenchmark_Int32 | SumKernel256Traits_Args0        |                |               |     10916.589 |  9948.481 |  9917.648 | 10071.736 |
| ShuffleBenchmark_Int32 | SumKernel256Traits_Args         |                |               |     10020.229 | 10147.550 |  9741.727 | 10102.702 |
| ShuffleBenchmark_Int64 | SumScalar                       |        459.881 |       457.952 |       188.562 |   477.806 |   459.242 |   462.021 |
| ShuffleBenchmark_Int64 | SumBase                         |        460.004 |       458.499 |       458.524 |   478.418 |   459.559 |   445.003 |
| ShuffleBenchmark_Int64 | SumTraits                       |        459.302 |       459.876 |      2143.129 |  2518.325 |  2433.449 |  3524.309 |
| ShuffleBenchmark_Int64 | SumTraits_Args0                 |        465.064 |       441.576 |      4508.754 |  4449.098 |  4406.994 |  4484.512 |
| ShuffleBenchmark_Int64 | SumTraits_Args                  |        459.786 |       408.545 |      4466.028 |  4214.808 |  4293.438 |  4270.565 |
| ShuffleBenchmark_Int64 | Sum128_Bcl                      |                |               |               |           |           |           |
| ShuffleBenchmark_Int64 | Sum128_AdvSimd                  |                |               |               |           |           |           |
| ShuffleBenchmark_Int64 | Sum128Traits                    |                |               |               |           |           |           |
| ShuffleBenchmark_Int64 | Sum256_Bcl                      |                |               |               |           |           |   515.863 |
| ShuffleBenchmark_Int64 | Sum256Traits                    |                |               |      1993.214 |  2584.016 |  1549.809 |  3999.694 |
| ShuffleBenchmark_Int64 | SumKernelTraits                 |        460.058 |       458.858 |      2702.105 |  3195.810 |  1714.735 |  4046.124 |
| ShuffleBenchmark_Int64 | SumKernelTraits_Args0           |        464.705 |       438.224 |      4820.767 |  4705.843 |  4042.262 |  4882.344 |
| ShuffleBenchmark_Int64 | SumKernelTraits_Args            |        463.218 |       411.905 |      4884.277 |  5433.558 |  4140.529 |  4788.233 |
| ShuffleBenchmark_Int64 | SumKernel128_AdvSimd            |                |               |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel128_Arm_Multiply       |                |               |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel128Traits              |                |               |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_AlignRight    |                |               |      3226.481 |  2925.062 |  1652.260 |  3903.387 |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_DuplicateEven |                |               |      3361.318 |  2278.289 |  1846.244 |  4614.976 |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_Multiply      |                |               |      1641.368 |  1530.592 |  1416.268 |  2224.655 |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_ShiftLane     |                |               |      3270.627 |  2261.214 |  2352.816 |  4478.636 |
| ShuffleBenchmark_Int64 | SumKernel256Traits              |                |               |      3342.688 |  2179.618 |  2636.886 |  4359.323 |
| ShuffleBenchmark_Int64 | SumKernel256Traits_Args0        |                |               |      5435.300 |  3113.626 |  4514.884 |  4843.565 |
| ShuffleBenchmark_Int64 | SumKernel256Traits_Args         |                |               |      5460.464 |  4168.885 |  4537.030 |  4884.430 |
| ShuffleBenchmark_SByte | SumScalar                       |       1263.210 |      1262.732 |       844.749 |  1013.924 |  1077.513 |  1261.932 |
| ShuffleBenchmark_SByte | SumBase                         |       1263.090 |      1265.241 |      1261.878 |  1090.308 |  1071.163 |  1250.940 |
| ShuffleBenchmark_SByte | SumTraits                       |       1264.393 |      1264.667 |     13239.408 | 17766.242 | 16140.964 | 24537.440 |
| ShuffleBenchmark_SByte | SumTraits_Args0                 |       1262.368 |      1242.503 |     31793.487 | 31423.344 | 31314.488 | 34322.789 |
| ShuffleBenchmark_SByte | SumTraits_Args                  |       1221.542 |      1248.121 |     31118.400 | 31615.120 | 31980.794 | 33156.240 |
| ShuffleBenchmark_SByte | Sum128_Bcl                      |                |               |               |           |           |           |
| ShuffleBenchmark_SByte | Sum128_AdvSimd                  |                |               |               |           |           |           |
| ShuffleBenchmark_SByte | Sum128Traits                    |                |               |               |           |           |           |
| ShuffleBenchmark_SByte | Sum256_Bcl                      |                |               |               |           |           |   930.329 |
| ShuffleBenchmark_SByte | Sum256_Avx2_Add1                |                |               |     12745.930 | 18735.483 | 20051.159 | 25485.263 |
| ShuffleBenchmark_SByte | Sum256_Avx2_Add2                |                |               |     12731.326 | 17621.875 | 19686.080 | 25385.425 |
| ShuffleBenchmark_SByte | Sum256_Avx2_Cmp2                |                |               |     14398.765 | 19544.513 | 21917.193 | 25522.923 |
| ShuffleBenchmark_SByte | Sum256Traits                    |                |               |     13914.661 | 22158.597 | 21543.760 | 30353.955 |
| ShuffleBenchmark_SByte | SumKernelTraits                 |       1260.097 |      1266.056 |     19996.806 | 23032.250 | 23853.314 | 29612.169 |
| ShuffleBenchmark_SByte | SumKernelTraits_Args0           |       1260.461 |      1245.530 |     31084.955 | 30974.022 | 31913.287 | 33643.052 |
| ShuffleBenchmark_SByte | SumKernelTraits_Args            |       1260.272 |      1249.316 |     30827.152 | 30734.831 | 32311.418 | 32977.071 |
| ShuffleBenchmark_SByte | SumKernel128_AdvSimd            |                |               |               |           |           |           |
| ShuffleBenchmark_SByte | SumKernel128Traits              |                |               |               |           |           |           |
| ShuffleBenchmark_SByte | SumKernel256Traits              |                |               |     19401.960 | 26014.344 | 27007.048 | 33722.566 |
| ShuffleBenchmark_SByte | SumKernel256Traits_Args0        |                |               |     30964.751 | 30993.177 | 32091.019 | 33179.123 |
| ShuffleBenchmark_SByte | SumKernel256Traits_Args         |                |               |     31005.994 | 31250.668 | 32222.099 | 32176.595 |

### Arm - AWS Arm t4g.small
| Class                  | Method                          | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :--------------------- | :------------------------------ | ------------: | --------: | --------: | --------: |
| ShuffleBenchmark_Int16 | SumScalar                       |       424.835 |   422.286 |   423.070 |   526.071 |
| ShuffleBenchmark_Int16 | SumBase                         |       424.034 |   423.118 |   422.888 |   526.673 |
| ShuffleBenchmark_Int16 | SumTraits                       |       423.942 |  4925.034 |  4938.077 |  5853.245 |
| ShuffleBenchmark_Int16 | SumTraits_Args0                 |       423.872 |  8381.395 |  7862.055 |  9821.786 |
| ShuffleBenchmark_Int16 | SumTraits_Args                  |       400.767 |  2982.755 |  2976.138 |  9769.321 |
| ShuffleBenchmark_Int16 | Sum128_Bcl                      |               |           |           |   482.320 |
| ShuffleBenchmark_Int16 | Sum128_AdvSimd                  |               |  3169.036 |  3115.859 |  3239.207 |
| ShuffleBenchmark_Int16 | Sum128Traits                    |       238.497 |  5258.028 |  4973.134 |  5861.744 |
| ShuffleBenchmark_Int16 | Sum256_Bcl                      |               |           |           |           |
| ShuffleBenchmark_Int16 | Sum256Traits                    |               |           |           |           |
| ShuffleBenchmark_Int16 | SumKernelTraits                 |       424.317 |  5644.808 |  6565.519 |  7904.834 |
| ShuffleBenchmark_Int16 | SumKernelTraits_Args0           |       423.899 |  7881.823 |  7847.868 |  9835.768 |
| ShuffleBenchmark_Int16 | SumKernelTraits_Args            |       399.772 |  2982.013 |  2868.286 |  9778.383 |
| ShuffleBenchmark_Int16 | SumKernel128_AdvSimd            |               |  3459.399 |  3387.257 |  3992.953 |
| ShuffleBenchmark_Int16 | SumKernel128Traits              |       238.496 |  6571.362 |  6547.047 |  7908.342 |
| ShuffleBenchmark_Int16 | SumKernel256_Avx2_Multiply      |               |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel256_Avx2_ShiftLane     |               |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel256Traits              |               |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel256Traits_Args0        |               |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel256Traits_Args         |               |           |           |           |
| ShuffleBenchmark_Int32 | SumScalar                       |       288.211 |   281.081 |   276.668 |   317.268 |
| ShuffleBenchmark_Int32 | SumBase                         |       287.892 |   280.445 |   281.592 |   316.245 |
| ShuffleBenchmark_Int32 | SumTraits                       |       287.942 |  2447.812 |  2561.501 |  2912.918 |
| ShuffleBenchmark_Int32 | SumTraits_Args0                 |       286.646 |  4103.084 |  4110.550 |  4796.704 |
| ShuffleBenchmark_Int32 | SumTraits_Args                  |       268.613 |  1487.180 |  1483.994 |  4775.891 |
| ShuffleBenchmark_Int32 | Sum128_Bcl                      |               |           |           |   303.702 |
| ShuffleBenchmark_Int32 | Sum128_AdvSimd                  |               |  1378.213 |  1561.574 |  1590.734 |
| ShuffleBenchmark_Int32 | Sum128Traits                    |       153.181 |  2470.216 |  2461.214 |  2913.303 |
| ShuffleBenchmark_Int32 | Sum256_Bcl                      |               |           |           |           |
| ShuffleBenchmark_Int32 | Sum256Traits                    |               |           |           |           |
| ShuffleBenchmark_Int32 | SumKernelTraits                 |       287.900 |  2805.355 |  3237.345 |  3909.519 |
| ShuffleBenchmark_Int32 | SumKernelTraits_Args0           |       286.556 |  4112.689 |  4128.402 |  4825.180 |
| ShuffleBenchmark_Int32 | SumKernelTraits_Args            |       268.858 |  1487.021 |  1430.400 |  4755.708 |
| ShuffleBenchmark_Int32 | SumKernel128_AdvSimd            |               |  1709.084 |  1675.348 |  1986.736 |
| ShuffleBenchmark_Int32 | SumKernel128Traits              |       153.238 |  3237.010 |  3144.886 |  3902.403 |
| ShuffleBenchmark_Int32 | SumKernel256Traits              |               |           |           |           |
| ShuffleBenchmark_Int32 | SumKernel256Traits_Args0        |               |           |           |           |
| ShuffleBenchmark_Int32 | SumKernel256Traits_Args         |               |           |           |           |
| ShuffleBenchmark_Int64 | SumScalar                       |       378.628 |   188.199 |   447.044 |   552.523 |
| ShuffleBenchmark_Int64 | SumBase                         |       379.468 |   190.133 |   456.808 |   217.626 |
| ShuffleBenchmark_Int64 | SumTraits                       |       379.643 |  1015.811 |  1089.628 |  1242.552 |
| ShuffleBenchmark_Int64 | SumTraits_Args0                 |       380.133 |  2091.948 |  1967.766 |  2465.800 |
| ShuffleBenchmark_Int64 | SumTraits_Args                  |       326.603 |   743.033 |   744.908 |  2452.967 |
| ShuffleBenchmark_Int64 | Sum128_Bcl                      |               |           |           |   712.025 |
| ShuffleBenchmark_Int64 | Sum128_AdvSimd                  |               |   592.351 |   551.265 |   605.249 |
| ShuffleBenchmark_Int64 | Sum128Traits                    |       207.905 |  1229.996 |  1090.720 |  1261.187 |
| ShuffleBenchmark_Int64 | Sum256_Bcl                      |               |           |           |           |
| ShuffleBenchmark_Int64 | Sum256Traits                    |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernelTraits                 |       379.696 |  1221.923 |  1480.182 |  1756.478 |
| ShuffleBenchmark_Int64 | SumKernelTraits_Args0           |       379.788 |  2096.124 |  2095.536 |  2464.674 |
| ShuffleBenchmark_Int64 | SumKernelTraits_Args            |       170.957 |   715.532 |   717.549 |  2457.398 |
| ShuffleBenchmark_Int64 | SumKernel128_AdvSimd            |               |   930.700 |   897.948 |   917.481 |
| ShuffleBenchmark_Int64 | SumKernel128_Arm_Multiply       |               |   468.695 |   493.091 |   568.990 |
| ShuffleBenchmark_Int64 | SumKernel128Traits              |       207.797 |  1456.022 |  1413.132 |  1752.322 |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_AlignRight    |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_DuplicateEven |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_Multiply      |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_ShiftLane     |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256Traits              |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256Traits_Args0        |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256Traits_Args         |               |           |           |           |
| ShuffleBenchmark_SByte | SumScalar                       |       668.450 |   650.673 |   659.984 |   833.921 |
| ShuffleBenchmark_SByte | SumBase                         |       664.408 |   646.518 |   649.166 |   835.029 |
| ShuffleBenchmark_SByte | SumTraits                       |       667.527 | 13135.356 | 16713.009 | 19730.059 |
| ShuffleBenchmark_SByte | SumTraits_Args0                 |       664.988 | 15734.264 | 15708.758 | 19741.441 |
| ShuffleBenchmark_SByte | SumTraits_Args                  |       625.410 |  5723.523 |  5948.766 | 19692.665 |
| ShuffleBenchmark_SByte | Sum128_Bcl                      |               |           |           |   648.985 |
| ShuffleBenchmark_SByte | Sum128_AdvSimd                  |               | 11758.135 | 11744.858 | 13135.344 |
| ShuffleBenchmark_SByte | Sum128Traits                    |       399.182 | 15745.672 | 16723.857 | 19773.665 |
| ShuffleBenchmark_SByte | Sum256_Bcl                      |               |           |           |           |
| ShuffleBenchmark_SByte | Sum256_Avx2_Add1                |               |           |           |           |
| ShuffleBenchmark_SByte | Sum256_Avx2_Add2                |               |           |           |           |
| ShuffleBenchmark_SByte | Sum256_Avx2_Cmp2                |               |           |           |           |
| ShuffleBenchmark_SByte | Sum256Traits                    |               |           |           |           |
| ShuffleBenchmark_SByte | SumKernelTraits                 |       667.280 | 15584.505 | 15643.225 | 19741.523 |
| ShuffleBenchmark_SByte | SumKernelTraits_Args0           |       664.914 | 16731.942 | 16685.534 | 19726.599 |
| ShuffleBenchmark_SByte | SumKernelTraits_Args            |       625.761 |  5723.910 |  5950.549 | 19685.073 |
| ShuffleBenchmark_SByte | SumKernel128_AdvSimd            |               | 11756.736 | 11237.339 | 13128.541 |
| ShuffleBenchmark_SByte | SumKernel128Traits              |       400.146 | 15748.984 | 15720.302 | 19778.235 |
| ShuffleBenchmark_SByte | SumKernel256Traits              |               |           |           |           |
| ShuffleBenchmark_SByte | SumKernel256Traits_Args0        |               |           |           |           |
| ShuffleBenchmark_SByte | SumKernel256Traits_Args         |               |           |           |           |
