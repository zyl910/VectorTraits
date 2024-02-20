# Benchmark group - YShuffleG2
([← Back](YShuffleG2.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

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

### Arm - AWS Arm t4g.small
| Type                      | Method                    | .NET Core 3.1 | .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :------------------------ | :------------------------ | ------------: | -------: | --------: | --------: |
| YShuffleG2Benchmark_Int16 | SumScalar                 |       408.867 |  414.314 |   414.875 |   564.690 |
| YShuffleG2Benchmark_Int16 | SumBase                   |       408.089 |  414.527 |   414.641 |   562.215 |
| YShuffleG2Benchmark_Int16 | SumTraits                 |       407.703 | 4292.406 |  5625.606 |  6613.609 |
| YShuffleG2Benchmark_Int16 | Sum128_AdvSimd            |               | 3367.297 |  3930.065 |  4485.065 |
| YShuffleG2Benchmark_Int16 | Sum128Traits              |       253.825 | 4428.609 |  5627.211 |  6626.837 |
| YShuffleG2Benchmark_Int16 | Sum256Traits              |               |          |           |           |
| YShuffleG2Benchmark_Int16 | Sum_ConstTraits           |       395.489 | 4281.729 |  4960.118 |  6623.755 |
| YShuffleG2Benchmark_Int16 | Sum_Const128Traits        |       250.075 | 4429.919 |  5620.166 |  6621.201 |
| YShuffleG2Benchmark_Int16 | Sum_Const256Traits        |               |          |           |           |
| YShuffleG2Benchmark_Int32 | SumScalar                 |       357.057 |  380.972 |   384.504 |   377.051 |
| YShuffleG2Benchmark_Int32 | SumBase                   |       356.061 |  385.334 |   382.980 |   375.558 |
| YShuffleG2Benchmark_Int32 | SumTraits                 |       355.878 | 2128.149 |  2782.839 |  3277.805 |
| YShuffleG2Benchmark_Int32 | Sum128_AdvSimd            |               | 1674.701 |  1947.774 |  2025.177 |
| YShuffleG2Benchmark_Int32 | Sum128Traits              |       176.815 | 2130.689 |  2461.635 |  3283.247 |
| YShuffleG2Benchmark_Int32 | Sum256_AvxByte            |               |          |           |           |
| YShuffleG2Benchmark_Int32 | Sum256Traits              |               |          |           |           |
| YShuffleG2Benchmark_Int32 | Sum_ConstTraits           |       368.195 | 2180.661 |  2784.380 |  3280.066 |
| YShuffleG2Benchmark_Int32 | Sum_Const128Traits        |       176.624 | 2169.232 |  2459.462 |  3282.427 |
| YShuffleG2Benchmark_Int32 | Sum_Const256_AvxImm       |               |          |           |           |
| YShuffleG2Benchmark_Int32 | Sum_Const256_AvxImmByte   |               |          |           |           |
| YShuffleG2Benchmark_Int32 | Sum_Const256_AvxImmByteG4 |               |          |           |           |
| YShuffleG2Benchmark_Int32 | Sum_Const256Traits        |               |          |           |           |
| YShuffleG2Benchmark_Int64 | SumScalar                 |       373.239 |  642.980 |   642.840 |   731.401 |
| YShuffleG2Benchmark_Int64 | SumBase                   |       385.241 |  641.289 |   642.737 |   732.306 |
| YShuffleG2Benchmark_Int64 | SumTraits                 |       388.113 | 1080.341 |  1241.516 |  1633.636 |
| YShuffleG2Benchmark_Int64 | Sum128_AdvSimd            |               |  821.406 |   982.979 |  1048.929 |
| YShuffleG2Benchmark_Int64 | Sum128Traits              |       207.203 | 1074.316 |  1406.823 |  1632.801 |
| YShuffleG2Benchmark_Int64 | Sum256Traits              |               |          |           |           |
| YShuffleG2Benchmark_Int64 | Sum_ConstTraits           |       388.563 | 1071.043 |  1408.820 |  1633.239 |
| YShuffleG2Benchmark_Int64 | Sum_Const128Traits        |       130.114 | 1068.682 |  1407.240 |  1630.490 |
| YShuffleG2Benchmark_Int64 | Sum_Const256Traits        |               |          |           |           |
| YShuffleG2Benchmark_SByte | SumScalar                 |       497.212 |  499.341 |   498.837 |   701.137 |
| YShuffleG2Benchmark_SByte | SumBase                   |       497.477 |  498.662 |   499.426 |   700.510 |
| YShuffleG2Benchmark_SByte | SumTraits                 |       496.767 | 9127.030 | 11275.733 | 13190.553 |
| YShuffleG2Benchmark_SByte | Sum128_AdvSimd            |               | 6716.285 |  7869.652 |  8433.558 |
| YShuffleG2Benchmark_SByte | Sum128Traits              |       329.374 | 8790.495 |  9937.638 | 13218.098 |
| YShuffleG2Benchmark_SByte | Sum256Traits              |               |          |           |           |
| YShuffleG2Benchmark_SByte | Sum_ConstTraits           |       478.371 | 8693.426 |  9945.001 | 13213.780 |
| YShuffleG2Benchmark_SByte | Sum_Const128Traits        |       323.798 | 8529.797 | 11275.200 | 13219.879 |
| YShuffleG2Benchmark_SByte | Sum_Const256Traits        |               |          |           |           |

