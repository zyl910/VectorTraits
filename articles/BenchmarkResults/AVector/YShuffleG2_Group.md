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
| Type                      | Method         | .NET Core 3.1 | .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :------------------------ | :------------- | ------------: | -------: | --------: | --------: |
| YShuffleG2Benchmark_Int16 | SumScalar      |       408.895 |  415.613 |   414.633 |   568.581 |
| YShuffleG2Benchmark_Int16 | SumBase        |       409.439 |  415.284 |   414.253 |   562.382 |
| YShuffleG2Benchmark_Int16 | SumTraits      |       409.557 | 4194.783 |  5612.197 |  6632.605 |
| YShuffleG2Benchmark_Int16 | Sum128_AdvSimd |               | 2871.650 |  3927.137 |  4459.913 |
| YShuffleG2Benchmark_Int16 | Sum128Traits   |       252.184 | 4205.545 |  5598.492 |  6636.736 |
| YShuffleG2Benchmark_Int16 | Sum256Traits   |               |          |           |           |
| YShuffleG2Benchmark_Int32 | SumScalar      |       355.959 |  384.434 |   379.980 |   375.079 |
| YShuffleG2Benchmark_Int32 | SumBase        |       356.313 |  382.514 |   379.398 |   377.318 |
| YShuffleG2Benchmark_Int32 | SumTraits      |       355.763 | 2214.393 |  2801.964 |  3283.621 |
| YShuffleG2Benchmark_Int32 | Sum128_AdvSimd |               | 1637.676 |  1956.504 |  2186.169 |
| YShuffleG2Benchmark_Int32 | Sum128Traits   |       175.662 | 2205.138 |  2464.340 |  3291.444 |
| YShuffleG2Benchmark_Int32 | Sum256_AvxByte |               |          |           |           |
| YShuffleG2Benchmark_Int32 | Sum256Traits   |               |          |           |           |
| YShuffleG2Benchmark_Int64 | SumScalar      |       388.533 |  640.650 |   644.291 |   732.174 |
| YShuffleG2Benchmark_Int64 | SumBase        |       387.869 |  643.549 |   640.622 |   732.591 |
| YShuffleG2Benchmark_Int64 | SumTraits      |       388.218 | 1106.090 |  1401.358 |  1654.739 |
| YShuffleG2Benchmark_Int64 | Sum128_AdvSimd |               |  847.159 |   980.359 |  1088.890 |
| YShuffleG2Benchmark_Int64 | Sum128Traits   |       202.553 | 1071.456 |  1398.616 |  1654.073 |
| YShuffleG2Benchmark_Int64 | Sum256Traits   |               |          |           |           |
| YShuffleG2Benchmark_SByte | SumScalar      |       496.537 |  499.542 |   499.601 |   701.595 |
| YShuffleG2Benchmark_SByte | SumBase        |       496.327 |  499.025 |   498.824 |   701.419 |
| YShuffleG2Benchmark_SByte | SumTraits      |       497.022 | 8610.713 | 11180.317 | 13237.627 |
| YShuffleG2Benchmark_SByte | Sum128_AdvSimd |               | 6584.690 |  7250.345 |  8874.120 |
| YShuffleG2Benchmark_SByte | Sum128Traits   |       325.867 | 8827.489 |  9904.450 | 13248.838 |
| YShuffleG2Benchmark_SByte | Sum256Traits   |               |          |           |           |

