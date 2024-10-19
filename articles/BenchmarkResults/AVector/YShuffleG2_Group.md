# Benchmark group - YShuffleG2
([← Back](YShuffleG2.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### X86 - AMD Ryzen 7 7840H
| Type                      | Method         | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :------------------------ | :------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| YShuffleG2Benchmark_Int16 | SumScalar      |        997.477 |       900.492 |       903.161 |   917.784 |   885.979 |   916.888 |   907.079 |
| YShuffleG2Benchmark_Int16 | SumBase        |        964.510 |       887.012 |       934.702 |   916.061 |   934.040 |   922.617 |   924.771 |
| YShuffleG2Benchmark_Int16 | SumTraits      |        928.926 |       961.453 |     18820.454 | 20704.225 | 22234.522 | 23815.691 | 33369.630 |
| YShuffleG2Benchmark_Int16 | Sum128Base     |                |               |       373.586 |   375.433 |   373.259 |   458.204 |   487.587 |
| YShuffleG2Benchmark_Int16 | Sum128_AdvSimd |                |               |               |           |           |           |           |
| YShuffleG2Benchmark_Int16 | Sum128Traits   |                |               |               |           |           |           |           |
| YShuffleG2Benchmark_Int16 | Sum256Traits   |                |               |     18938.248 | 19791.172 | 21527.099 | 22217.689 | 32939.312 |
| YShuffleG2Benchmark_Int16 | Sum512Base     |                |               |               |           |           |           |   933.860 |
| YShuffleG2Benchmark_Int16 | Sum512Traits   |                |               |               |           |           |           | 29404.134 |
| YShuffleG2Benchmark_Int32 | SumScalar      |        721.765 |       690.659 |       696.761 |   705.694 |   710.039 |   723.349 |   955.325 |
| YShuffleG2Benchmark_Int32 | SumBase        |        687.088 |       688.663 |       694.544 |   703.466 |   723.843 |   702.455 |   956.203 |
| YShuffleG2Benchmark_Int32 | SumTraits      |        708.113 |       706.064 |      9781.664 | 10498.334 | 11986.698 | 11576.907 | 14691.454 |
| YShuffleG2Benchmark_Int32 | Sum128Base     |                |               |       248.330 |   247.596 |   246.718 |   241.827 |   258.474 |
| YShuffleG2Benchmark_Int32 | Sum128_AdvSimd |                |               |               |           |           |           |           |
| YShuffleG2Benchmark_Int32 | Sum128Traits   |                |               |               |           |           |           |           |
| YShuffleG2Benchmark_Int32 | Sum256_AvxByte |                |               |     10554.269 |  9584.945 | 11536.001 | 11403.692 | 14734.008 |
| YShuffleG2Benchmark_Int32 | Sum256Traits   |                |               |     10504.260 |  9913.617 | 11144.732 | 11611.474 | 15723.105 |
| YShuffleG2Benchmark_Int32 | Sum512Base     |                |               |               |           |           |           |   885.816 |
| YShuffleG2Benchmark_Int32 | Sum512Traits   |                |               |               |           |           |           | 14054.436 |
| YShuffleG2Benchmark_Int64 | SumScalar      |        500.835 |       489.356 |       494.293 |   487.212 |   505.420 |   520.775 |   525.307 |
| YShuffleG2Benchmark_Int64 | SumBase        |        496.836 |       499.170 |       499.303 |   498.976 |   505.350 |   508.028 |   524.635 |
| YShuffleG2Benchmark_Int64 | SumTraits      |        494.563 |       495.968 |      5201.218 |  4770.962 |  5849.934 |  5485.791 |  6655.150 |
| YShuffleG2Benchmark_Int64 | Sum128Base     |                |               |       132.259 |   132.311 |   132.783 |   125.807 |   124.718 |
| YShuffleG2Benchmark_Int64 | Sum128_AdvSimd |                |               |               |           |           |           |           |
| YShuffleG2Benchmark_Int64 | Sum128Traits   |                |               |               |           |           |           |           |
| YShuffleG2Benchmark_Int64 | Sum256Traits   |                |               |      5241.739 |  4746.562 |  5739.449 |  5332.925 |  6723.352 |
| YShuffleG2Benchmark_Int64 | Sum512Base     |                |               |               |           |           |           |   824.705 |
| YShuffleG2Benchmark_Int64 | Sum512Traits   |                |               |               |           |           |           |  7348.112 |
| YShuffleG2Benchmark_SByte | SumScalar      |        980.337 |       931.024 |       914.043 |   902.679 |   920.521 |   966.187 |   965.858 |
| YShuffleG2Benchmark_SByte | SumBase        |        982.570 |       938.433 |       924.247 |   870.581 |   937.582 |   985.690 |   988.225 |
| YShuffleG2Benchmark_SByte | SumTraits      |       1008.188 |       931.538 |     40997.792 | 36875.028 | 50046.486 | 47717.759 | 52699.131 |
| YShuffleG2Benchmark_SByte | Sum128Base     |                |               |       480.341 |   468.219 |   464.707 |   995.927 |   997.958 |
| YShuffleG2Benchmark_SByte | Sum128_AdvSimd |                |               |               |           |           |           |           |
| YShuffleG2Benchmark_SByte | Sum128Traits   |                |               |               |           |           |           |           |
| YShuffleG2Benchmark_SByte | Sum256Traits   |                |               |     41781.050 | 37618.460 | 50827.584 | 46589.396 | 53094.337 |
| YShuffleG2Benchmark_SByte | Sum512Base     |                |               |               |           |           |           |  1016.930 |
| YShuffleG2Benchmark_SByte | Sum512Traits   |                |               |               |           |           |           | 70866.125 |

### X86 - Intel Core i5-8250U
| Type                      | Method         | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :------------------------ | :------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| YShuffleG2Benchmark_Int16 | SumScalar      |        613.710 |       615.084 |       614.723 |   612.985 |   613.828 |   755.996 |
| YShuffleG2Benchmark_Int16 | SumBase        |        607.467 |       614.942 |       615.277 |   604.367 |   462.899 |   754.857 |
| YShuffleG2Benchmark_Int16 | SumTraits      |        606.983 |       614.098 |     12062.124 | 12349.700 | 20813.621 | 19174.068 |
| YShuffleG2Benchmark_Int16 | Sum128_AdvSimd |                |               |               |           |           |           |
| YShuffleG2Benchmark_Int16 | Sum128Traits   |                |               |               |           |           |           |
| YShuffleG2Benchmark_Int16 | Sum256Traits   |                |               |     11894.025 | 12327.884 | 19315.244 | 16185.459 |
| YShuffleG2Benchmark_Int32 | SumScalar      |        499.920 |       500.224 |       500.292 |   500.098 |   500.256 |   586.467 |
| YShuffleG2Benchmark_Int32 | SumBase        |        488.861 |       499.188 |       499.948 |   491.558 |   322.327 |   586.425 |
| YShuffleG2Benchmark_Int32 | SumTraits      |        489.571 |       499.740 |      6185.124 |  6016.417 |  9549.107 |  9726.706 |
| YShuffleG2Benchmark_Int32 | Sum128_AdvSimd |                |               |               |           |           |           |
| YShuffleG2Benchmark_Int32 | Sum128Traits   |                |               |               |           |           |           |
| YShuffleG2Benchmark_Int32 | Sum256_AvxByte |                |               |      6170.363 |  6021.792 |  8900.803 |  9965.984 |
| YShuffleG2Benchmark_Int32 | Sum256Traits   |                |               |      6179.582 |  6015.130 |  8595.103 |  9329.745 |
| YShuffleG2Benchmark_Int64 | SumScalar      |        501.788 |       498.944 |       499.621 |   521.783 |   521.100 |   525.338 |
| YShuffleG2Benchmark_Int64 | SumBase        |        479.088 |       498.234 |       501.221 |   502.814 |   237.920 |   525.721 |
| YShuffleG2Benchmark_Int64 | SumTraits      |        477.352 |       498.580 |      3065.379 |  3070.744 |  5200.986 |  5066.715 |
| YShuffleG2Benchmark_Int64 | Sum128_AdvSimd |                |               |               |           |           |           |
| YShuffleG2Benchmark_Int64 | Sum128Traits   |                |               |               |           |           |           |
| YShuffleG2Benchmark_Int64 | Sum256Traits   |                |               |      3059.214 |  3070.792 |  5283.821 |  4939.400 |
| YShuffleG2Benchmark_SByte | SumScalar      |        693.580 |       692.910 |       692.633 |   692.053 |   691.449 |   874.159 |
| YShuffleG2Benchmark_SByte | SumBase        |        685.702 |       691.988 |       693.610 |   686.527 |   584.845 |   837.868 |
| YShuffleG2Benchmark_SByte | SumTraits      |        688.620 |       693.421 |     26356.467 | 26269.727 | 44842.162 | 45567.330 |
| YShuffleG2Benchmark_SByte | Sum128_AdvSimd |                |               |               |           |           |           |
| YShuffleG2Benchmark_SByte | Sum128Traits   |                |               |               |           |           |           |
| YShuffleG2Benchmark_SByte | Sum256Traits   |                |               |     26368.652 | 26309.214 | 40455.310 | 40250.872 |

### Arm - Apple M2
| Type                      | Method         |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :------------------------ | :------------- | --------: | --------: | --------: |
| YShuffleG2Benchmark_Int16 | SumScalar      |  1364.413 |  2265.252 |  2153.446 |
| YShuffleG2Benchmark_Int16 | SumBase        |  1364.586 |  2265.034 |  2111.870 |
| YShuffleG2Benchmark_Int16 | SumTraits      | 13599.349 | 13603.518 | 13616.661 |
| YShuffleG2Benchmark_Int16 | Sum128Base     |  1061.883 |   971.541 |   989.390 |
| YShuffleG2Benchmark_Int16 | Sum128_AdvSimd | 10878.939 | 12086.018 | 13604.993 |
| YShuffleG2Benchmark_Int16 | Sum128Traits   | 13598.112 | 13603.857 | 13617.675 |
| YShuffleG2Benchmark_Int16 | Sum256Traits   |           |           |           |
| YShuffleG2Benchmark_Int16 | Sum512Base     |           |           |  1925.379 |
| YShuffleG2Benchmark_Int16 | Sum512Traits   |           |           |  1925.108 |
| YShuffleG2Benchmark_Int32 | SumScalar      |  2465.120 |  3421.791 |  3447.867 |
| YShuffleG2Benchmark_Int32 | SumBase        |  2464.544 |  3428.865 |  3417.081 |
| YShuffleG2Benchmark_Int32 | SumTraits      |  6799.698 |  6801.967 |  6804.553 |
| YShuffleG2Benchmark_Int32 | Sum128Base     |   754.467 |   485.739 |   494.608 |
| YShuffleG2Benchmark_Int32 | Sum128_AdvSimd |  5439.221 |  6043.286 |  6802.532 |
| YShuffleG2Benchmark_Int32 | Sum128Traits   |  6799.534 |  6802.396 |  6806.498 |
| YShuffleG2Benchmark_Int32 | Sum256_AvxByte |           |           |           |
| YShuffleG2Benchmark_Int32 | Sum256Traits   |           |           |           |
| YShuffleG2Benchmark_Int32 | Sum512Base     |           |           |  2093.242 |
| YShuffleG2Benchmark_Int32 | Sum512Traits   |           |           |  2092.692 |
| YShuffleG2Benchmark_Int64 | SumScalar      |  1935.352 |  2508.806 |  2510.737 |
| YShuffleG2Benchmark_Int64 | SumBase        |  1934.682 |  2506.270 |  2505.037 |
| YShuffleG2Benchmark_Int64 | SumTraits      |  3401.066 |  3400.284 |  3402.031 |
| YShuffleG2Benchmark_Int64 | Sum128Base     |   447.394 |   242.838 |   245.079 |
| YShuffleG2Benchmark_Int64 | Sum128_AdvSimd |  2720.386 |  3022.307 |  3400.670 |
| YShuffleG2Benchmark_Int64 | Sum128Traits   |  3400.730 |  3400.900 |  3402.299 |
| YShuffleG2Benchmark_Int64 | Sum256Traits   |           |           |           |
| YShuffleG2Benchmark_Int64 | Sum512Base     |           |           |  1824.389 |
| YShuffleG2Benchmark_Int64 | Sum512Traits   |           |           |  1824.269 |
| YShuffleG2Benchmark_SByte | SumScalar      |  1522.411 |  2252.669 |  2217.889 |
| YShuffleG2Benchmark_SByte | SumBase        |  1522.284 |  2229.211 |  2215.646 |
| YShuffleG2Benchmark_SByte | SumTraits      | 27172.395 | 27195.180 | 27234.587 |
| YShuffleG2Benchmark_SByte | Sum128Base     |  1188.973 |  1943.203 |  1978.278 |
| YShuffleG2Benchmark_SByte | Sum128_AdvSimd | 21731.459 | 24133.753 | 27183.305 |
| YShuffleG2Benchmark_SByte | Sum128Traits   | 27169.710 | 27195.806 | 27235.077 |
| YShuffleG2Benchmark_SByte | Sum256Traits   |           |           |           |
| YShuffleG2Benchmark_SByte | Sum512Base     |           |           |  1762.767 |
| YShuffleG2Benchmark_SByte | Sum512Traits   |           |           |  1762.212 |

### Arm - AWS Arm t4g.small
| Type                      | Method         | .NET Core 3.1 | .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :------------------------ | :------------- | ------------: | -------: | --------: | --------: | --------: |
| YShuffleG2Benchmark_Int16 | SumScalar      |       413.752 |  415.613 |   414.718 |   566.821 |   541.251 |
| YShuffleG2Benchmark_Int16 | SumBase        |       414.960 |  415.284 |   414.962 |   561.814 |   541.656 |
| YShuffleG2Benchmark_Int16 | SumTraits      |       411.586 | 4194.783 |  5648.879 |  6615.025 |  8435.871 |
| YShuffleG2Benchmark_Int16 | Sum128Base     |       254.503 |          |   253.653 |   314.086 |   316.250 |
| YShuffleG2Benchmark_Int16 | Sum128_AdvSimd |               | 2871.650 |  3939.705 |  4308.160 |  5435.936 |
| YShuffleG2Benchmark_Int16 | Sum128Traits   |       254.240 | 4205.545 |  5646.184 |  6629.048 |  8415.726 |
| YShuffleG2Benchmark_Int16 | Sum256Traits   |               |          |           |           |           |
| YShuffleG2Benchmark_Int16 | Sum512Base     |               |          |           |           |   580.651 |
| YShuffleG2Benchmark_Int16 | Sum512Traits   |               |          |           |           |   580.448 |
| YShuffleG2Benchmark_Int32 | SumScalar      |       388.212 |  384.434 |   384.351 |   376.803 |   375.433 |
| YShuffleG2Benchmark_Int32 | SumBase        |       389.817 |  382.514 |   383.915 |   375.393 |   377.560 |
| YShuffleG2Benchmark_Int32 | SumTraits      |       389.903 | 2214.393 |  2814.272 |  3298.940 |  4148.960 |
| YShuffleG2Benchmark_Int32 | Sum128Base     |       179.814 |          |   195.871 |   157.001 |   158.168 |
| YShuffleG2Benchmark_Int32 | Sum128_AdvSimd |               | 1637.676 |  1962.797 |  2126.675 |  2709.818 |
| YShuffleG2Benchmark_Int32 | Sum128Traits   |       179.650 | 2205.138 |  2812.012 |  3301.383 |  4151.920 |
| YShuffleG2Benchmark_Int32 | Sum256_AvxByte |               |          |           |           |           |
| YShuffleG2Benchmark_Int32 | Sum256Traits   |               |          |           |           |           |
| YShuffleG2Benchmark_Int32 | Sum512Base     |               |          |           |           |   640.209 |
| YShuffleG2Benchmark_Int32 | Sum512Traits   |               |          |           |           |   640.775 |
| YShuffleG2Benchmark_Int64 | SumScalar      |       655.369 |  640.650 |   646.396 |   724.906 |   720.108 |
| YShuffleG2Benchmark_Int64 | SumBase        |       654.809 |  643.549 |   643.760 |   721.909 |   718.718 |
| YShuffleG2Benchmark_Int64 | SumTraits      |       654.119 | 1106.090 |  1239.415 |  1654.472 |  1969.716 |
| YShuffleG2Benchmark_Int64 | Sum128Base     |       216.145 |          |   259.987 |    78.227 |    78.213 |
| YShuffleG2Benchmark_Int64 | Sum128_AdvSimd |               |  847.159 |   982.808 |  1085.056 |  1370.774 |
| YShuffleG2Benchmark_Int64 | Sum128Traits   |       132.211 | 1071.456 |  1407.239 |  1652.016 |  1969.318 |
| YShuffleG2Benchmark_Int64 | Sum256Traits   |               |          |           |           |           |
| YShuffleG2Benchmark_Int64 | Sum512Base     |               |          |           |           |   621.604 |
| YShuffleG2Benchmark_Int64 | Sum512Traits   |               |          |           |           |   621.381 |
| YShuffleG2Benchmark_SByte | SumScalar      |       498.195 |  499.542 |   498.322 |   700.300 |   670.716 |
| YShuffleG2Benchmark_SByte | SumBase        |       498.247 |  499.025 |   498.636 |   699.936 |   670.286 |
| YShuffleG2Benchmark_SByte | SumTraits      |       499.851 | 8610.713 | 11270.671 | 13204.599 | 15228.426 |
| YShuffleG2Benchmark_SByte | Sum128Base     |       326.952 |          |   319.903 |   627.967 |   592.011 |
| YShuffleG2Benchmark_SByte | Sum128_AdvSimd |               | 6584.690 |  7852.213 |  8662.832 |  9058.345 |
| YShuffleG2Benchmark_SByte | Sum128Traits   |       326.737 | 8827.489 |  9913.676 | 13220.734 | 15235.218 |
| YShuffleG2Benchmark_SByte | Sum256Traits   |               |          |           |           |           |
| YShuffleG2Benchmark_SByte | Sum512Base     |               |          |           |           |   710.765 |
| YShuffleG2Benchmark_SByte | Sum512Traits   |               |          |           |           |   711.073 |

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                      | Method         | .NET 8.0 |
| :------------------------ | :------------- | -------: |
| YShuffleG2Benchmark_Int16 | SumScalar      |   13.050 |
| YShuffleG2Benchmark_Int16 | SumBase        |   12.453 |
| YShuffleG2Benchmark_Int16 | SumTraits      |   86.280 |
| YShuffleG2Benchmark_Int16 | Sum128Base     |   71.000 |
| YShuffleG2Benchmark_Int16 | Sum128_AdvSimd |          |
| YShuffleG2Benchmark_Int16 | Sum128Traits   |  105.131 |
| YShuffleG2Benchmark_Int16 | Sum256Traits   |          |
| YShuffleG2Benchmark_Int16 | Sum512Base     |   12.222 |
| YShuffleG2Benchmark_Int16 | Sum512Traits   |   11.016 |
| YShuffleG2Benchmark_Int32 | SumScalar      |   11.115 |
| YShuffleG2Benchmark_Int32 | SumBase        |   11.244 |
| YShuffleG2Benchmark_Int32 | SumTraits      |   40.629 |
| YShuffleG2Benchmark_Int32 | Sum128Base     |   33.523 |
| YShuffleG2Benchmark_Int32 | Sum128_AdvSimd |          |
| YShuffleG2Benchmark_Int32 | Sum128Traits   |   52.897 |
| YShuffleG2Benchmark_Int32 | Sum256_AvxByte |          |
| YShuffleG2Benchmark_Int32 | Sum256Traits   |          |
| YShuffleG2Benchmark_Int32 | Sum512Base     |    9.301 |
| YShuffleG2Benchmark_Int32 | Sum512Traits   |    8.606 |
| YShuffleG2Benchmark_Int64 | SumScalar      |    5.374 |
| YShuffleG2Benchmark_Int64 | SumBase        |    5.278 |
| YShuffleG2Benchmark_Int64 | SumTraits      |    8.296 |
| YShuffleG2Benchmark_Int64 | Sum128Base     |    3.792 |
| YShuffleG2Benchmark_Int64 | Sum128_AdvSimd |          |
| YShuffleG2Benchmark_Int64 | Sum128Traits   |   28.340 |
| YShuffleG2Benchmark_Int64 | Sum256Traits   |          |
| YShuffleG2Benchmark_Int64 | Sum512Base     |    2.847 |
| YShuffleG2Benchmark_Int64 | Sum512Traits   |    5.739 |
| YShuffleG2Benchmark_SByte | SumScalar      |   15.697 |
| YShuffleG2Benchmark_SByte | SumBase        |   15.322 |
| YShuffleG2Benchmark_SByte | SumTraits      |  181.343 |
| YShuffleG2Benchmark_SByte | Sum128Base     |  146.922 |
| YShuffleG2Benchmark_SByte | Sum128_AdvSimd |          |
| YShuffleG2Benchmark_SByte | Sum128Traits   |  215.969 |
| YShuffleG2Benchmark_SByte | Sum256Traits   |          |
| YShuffleG2Benchmark_SByte | Sum512Base     |   14.851 |
| YShuffleG2Benchmark_SByte | Sum512Traits   |   14.748 |

