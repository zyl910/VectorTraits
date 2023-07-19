# Benchmark group - YShuffleG2
([← Back](YShuffleG2.md))

Cell unit: Mega/Second .

### x86 - lntel Core i5-8250U
| Class                     | Name                      | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :------------------------ | :------------------------ | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| YShuffleG2Benchmark_Int16 | SumScalar                 |        601.661 |       610.604 |       609.137 |   610.923 |   600.729 |   750.421 |
| YShuffleG2Benchmark_Int16 | SumBase                   |        610.271 |       610.069 |       608.914 |   603.034 |   604.206 |   742.757 |
| YShuffleG2Benchmark_Int16 | SumTraits                 |        605.154 |       610.264 |     12115.302 | 12132.537 | 14692.144 | 17934.933 |
| YShuffleG2Benchmark_Int16 | Sum128_AdvSimd            |                |               |               |           |           |           |
| YShuffleG2Benchmark_Int16 | Sum128Traits              |                |               |               |           |           |           |
| YShuffleG2Benchmark_Int16 | Sum256Traits              |                |               |     12223.608 | 11908.610 | 16298.808 | 17900.610 |
| YShuffleG2Benchmark_Int16 | Sum_ConstTraits           |        612.229 |       609.153 |     12232.550 | 11716.767 | 15891.814 | 17711.836 |
| YShuffleG2Benchmark_Int16 | Sum_Const128Traits        |                |               |               |           |           |           |
| YShuffleG2Benchmark_Int16 | Sum_Const256Traits        |                |               |     12056.756 | 11715.588 | 15605.467 | 16901.518 |
| YShuffleG2Benchmark_Int32 | SumScalar                 |        487.357 |       495.980 |       497.210 |   497.791 |   494.142 |   556.141 |
| YShuffleG2Benchmark_Int32 | SumBase                   |        495.938 |       496.091 |       496.169 |   487.820 |   483.574 |   565.380 |
| YShuffleG2Benchmark_Int32 | SumTraits                 |        497.567 |       496.546 |      5930.524 |  5829.429 |  7922.891 |  8449.735 |
| YShuffleG2Benchmark_Int32 | Sum128_AdvSimd            |                |               |               |           |           |           |
| YShuffleG2Benchmark_Int32 | Sum128Traits              |                |               |               |           |           |           |
| YShuffleG2Benchmark_Int32 | Sum256_AvxByte            |                |               |      5885.550 |  5646.748 |  7697.192 |  8296.838 |
| YShuffleG2Benchmark_Int32 | Sum256Traits              |                |               |      5890.157 |  5632.720 |  7771.078 |  8570.734 |
| YShuffleG2Benchmark_Int32 | Sum_ConstTraits           |        498.969 |       498.331 |      5881.220 |  4561.814 |  7892.578 |  8380.869 |
| YShuffleG2Benchmark_Int32 | Sum_Const128Traits        |                |               |               |           |           |           |
| YShuffleG2Benchmark_Int32 | Sum_Const256_AvxImm       |                |               |      2316.265 |  2665.846 |  2634.768 |  2707.700 |
| YShuffleG2Benchmark_Int32 | Sum_Const256_AvxImmByte   |                |               |      2704.986 |  2688.603 |  2315.412 |  2586.209 |
| YShuffleG2Benchmark_Int32 | Sum_Const256_AvxImmByteG4 |                |               |     11665.863 | 10420.470 | 10928.142 | 11447.921 |
| YShuffleG2Benchmark_Int32 | Sum_Const256Traits        |                |               |      5786.600 |  5593.286 |  8025.215 |  8376.151 |
| YShuffleG2Benchmark_Int64 | SumScalar                 |        474.930 |       493.509 |       495.797 |   517.366 |   518.450 |   522.452 |
| YShuffleG2Benchmark_Int64 | SumBase                   |        493.663 |       494.574 |       495.096 |   497.159 |   497.791 |   501.479 |
| YShuffleG2Benchmark_Int64 | SumTraits                 |        495.526 |       493.714 |      2966.933 |  2905.467 |  3983.118 |  4502.237 |
| YShuffleG2Benchmark_Int64 | Sum128_AdvSimd            |                |               |               |           |           |           |
| YShuffleG2Benchmark_Int64 | Sum128Traits              |                |               |               |           |           |           |
| YShuffleG2Benchmark_Int64 | Sum256Traits              |                |               |      2930.342 |  2564.635 |  4060.597 |  4419.006 |
| YShuffleG2Benchmark_Int64 | Sum_ConstTraits           |        505.635 |       526.928 |      2889.393 |  2697.113 |  3888.951 |  4404.702 |
| YShuffleG2Benchmark_Int64 | Sum_Const128Traits        |                |               |               |           |           |           |
| YShuffleG2Benchmark_Int64 | Sum_Const256Traits        |                |               |      2702.333 |  2853.727 |  3699.864 |  4093.564 |
| YShuffleG2Benchmark_SByte | SumScalar                 |        680.839 |       684.396 |       689.426 |   686.856 |   679.202 |   853.476 |
| YShuffleG2Benchmark_SByte | SumBase                   |        686.362 |       687.529 |       689.022 |   686.940 |   677.799 |   853.942 |
| YShuffleG2Benchmark_SByte | SumTraits                 |        657.589 |       686.413 |     25969.580 | 25929.590 | 33504.420 | 38013.166 |
| YShuffleG2Benchmark_SByte | Sum128_AdvSimd            |                |               |               |           |           |           |
| YShuffleG2Benchmark_SByte | Sum128Traits              |                |               |               |           |           |           |
| YShuffleG2Benchmark_SByte | Sum256Traits              |                |               |     25928.280 | 25356.755 | 33694.567 | 37748.060 |
| YShuffleG2Benchmark_SByte | Sum_ConstTraits           |        684.398 |       667.831 |     25587.549 | 24567.565 | 34341.574 | 38789.379 |
| YShuffleG2Benchmark_SByte | Sum_Const128Traits        |                |               |               |           |           |           |
| YShuffleG2Benchmark_SByte | Sum_Const256Traits        |                |               |     25440.344 | 24477.325 | 35023.889 | 38432.414 |

### Arm - AWS Arm t4g.small
| Class                     | Name                      | .NET Core 3.1 | .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :------------------------ | :------------------------ | ------------: | -------: | --------: | --------: |
| YShuffleG2Benchmark_Int16 | SumScalar                 |       409.154 |  414.672 |   413.351 |   563.053 |
| YShuffleG2Benchmark_Int16 | SumBase                   |       408.221 |  414.977 |   413.235 |   561.141 |
| YShuffleG2Benchmark_Int16 | SumTraits                 |       408.404 | 4302.595 |  4921.160 |  6602.053 |
| YShuffleG2Benchmark_Int16 | Sum128_AdvSimd            |               | 3262.138 |  3580.481 |  4405.554 |
| YShuffleG2Benchmark_Int16 | Sum128Traits              |       254.220 | 4272.100 |  4931.318 |  6603.788 |
| YShuffleG2Benchmark_Int16 | Sum256Traits              |               |          |           |           |
| YShuffleG2Benchmark_Int16 | Sum_ConstTraits           |       397.036 | 3966.361 |  5253.318 |  6605.427 |
| YShuffleG2Benchmark_Int16 | Sum_Const128Traits        |       250.729 | 3962.327 |  4935.012 |  6602.437 |
| YShuffleG2Benchmark_Int16 | Sum_Const256Traits        |               |          |           |           |
| YShuffleG2Benchmark_Int32 | SumScalar                 |       356.882 |  382.769 |   382.515 |   376.836 |
| YShuffleG2Benchmark_Int32 | SumBase                   |       356.302 |  379.374 |   384.547 |   375.073 |
| YShuffleG2Benchmark_Int32 | SumTraits                 |       356.164 | 2129.258 |  2465.741 |  3297.153 |
| YShuffleG2Benchmark_Int32 | Sum128_AdvSimd            |               | 1616.664 |  1787.049 |  2290.914 |
| YShuffleG2Benchmark_Int32 | Sum128Traits              |       176.633 | 2122.873 |  2608.349 |  3294.304 |
| YShuffleG2Benchmark_Int32 | Sum256_AvxByte            |               |          |           |           |
| YShuffleG2Benchmark_Int32 | Sum256Traits              |               |          |           |           |
| YShuffleG2Benchmark_Int32 | Sum_ConstTraits           |       368.701 | 2119.166 |  2459.813 |  3294.727 |
| YShuffleG2Benchmark_Int32 | Sum_Const128Traits        |       176.802 | 1974.510 |  2615.225 |  3297.170 |
| YShuffleG2Benchmark_Int32 | Sum_Const256_AvxImm       |               |          |           |           |
| YShuffleG2Benchmark_Int32 | Sum_Const256_AvxImmByte   |               |          |           |           |
| YShuffleG2Benchmark_Int32 | Sum_Const256_AvxImmByteG4 |               |          |           |           |
| YShuffleG2Benchmark_Int32 | Sum_Const256Traits        |               |          |           |           |
| YShuffleG2Benchmark_Int64 | SumScalar                 |       387.253 |  643.332 |   642.071 |   732.319 |
| YShuffleG2Benchmark_Int64 | SumBase                   |       388.248 |  645.861 |   642.201 |   730.847 |
| YShuffleG2Benchmark_Int64 | SumTraits                 |       387.369 |  992.606 |  1237.701 |  1631.844 |
| YShuffleG2Benchmark_Int64 | Sum128_AdvSimd            |               |  811.517 |   896.163 |  1042.249 |
| YShuffleG2Benchmark_Int64 | Sum128Traits              |       207.565 | 1054.736 |  1308.638 |  1633.288 |
| YShuffleG2Benchmark_Int64 | Sum256Traits              |               |          |           |           |
| YShuffleG2Benchmark_Int64 | Sum_ConstTraits           |       385.126 | 1065.621 |  1311.234 |  1634.691 |
| YShuffleG2Benchmark_Int64 | Sum_Const128Traits        |       205.368 | 1068.202 |  1309.772 |  1634.150 |
| YShuffleG2Benchmark_Int64 | Sum_Const256Traits        |               |          |           |           |
| YShuffleG2Benchmark_SByte | SumScalar                 |       495.511 |  499.631 |   497.205 |   701.675 |
| YShuffleG2Benchmark_SByte | SumBase                   |       495.111 |  498.902 |   498.222 |   701.665 |
| YShuffleG2Benchmark_SByte | SumTraits                 |       496.051 | 8707.354 | 10515.270 | 13242.276 |
| YShuffleG2Benchmark_SByte | Sum128_AdvSimd            |               | 6436.756 |  7169.175 |  9061.620 |
| YShuffleG2Benchmark_SByte | Sum128Traits              |       328.747 | 8384.063 | 10482.216 | 13240.881 |
| YShuffleG2Benchmark_SByte | Sum256Traits              |               |          |           |           |
| YShuffleG2Benchmark_SByte | Sum_ConstTraits           |       476.216 | 8643.008 | 10512.627 | 13233.426 |
| YShuffleG2Benchmark_SByte | Sum_Const128Traits        |       321.594 | 8661.896 |  9857.265 | 13236.416 |
| YShuffleG2Benchmark_SByte | Sum_Const256Traits        |               |          |           |           |
