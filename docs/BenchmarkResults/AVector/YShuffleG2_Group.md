# Benchmark group - YShuffleG2
([← Back](YShuffleG2.md))

Cell unit: Mega/Second .

### x86 - lntel Core i5-8250U
| Class                     | Name                      | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :------------------------ | :------------------------ | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| YShuffleG2Benchmark_Int16 | SumScalar                 |        603.563 |       611.557 |       602.263 |   610.740 |   599.868 |   746.208 |
| YShuffleG2Benchmark_Int16 | SumBase                   |        606.674 |       609.081 |       607.799 |   609.765 |   597.298 |   751.141 |
| YShuffleG2Benchmark_Int16 | SumTraits                 |        597.564 |       609.475 |     12207.818 | 12153.266 | 18531.389 | 20412.731 |
| YShuffleG2Benchmark_Int16 | Sum128_AdvSimd            |                |               |               |           |           |           |
| YShuffleG2Benchmark_Int16 | Sum128Traits              |                |               |               |           |           |           |
| YShuffleG2Benchmark_Int16 | Sum256Traits              |                |               |     12227.133 | 12159.311 | 16744.514 | 17409.773 |
| YShuffleG2Benchmark_Int16 | Sum_ConstTraits           |        608.027 |       610.617 |     12219.112 | 12072.395 | 16694.599 | 17350.418 |
| YShuffleG2Benchmark_Int16 | Sum_Const128Traits        |                |               |               |           |           |           |
| YShuffleG2Benchmark_Int16 | Sum_Const256Traits        |                |               |     11890.565 | 12082.761 | 16656.231 | 17326.438 |
| YShuffleG2Benchmark_Int32 | SumScalar                 |        497.370 |       497.109 |       485.032 |   496.694 |   495.999 |   581.809 |
| YShuffleG2Benchmark_Int32 | SumBase                   |        495.744 |       490.663 |       496.319 |   499.916 |   487.175 |   571.266 |
| YShuffleG2Benchmark_Int32 | SumTraits                 |        496.255 |       491.403 |      5936.641 |  5993.975 |  8699.256 |  9044.568 |
| YShuffleG2Benchmark_Int32 | Sum128_AdvSimd            |                |               |               |           |           |           |
| YShuffleG2Benchmark_Int32 | Sum128Traits              |                |               |               |           |           |           |
| YShuffleG2Benchmark_Int32 | Sum256_AvxByte            |                |               |      5939.308 |  6003.943 |  8580.903 |  7927.193 |
| YShuffleG2Benchmark_Int32 | Sum256Traits              |                |               |      5929.641 |  5935.686 |  8188.328 |  8327.988 |
| YShuffleG2Benchmark_Int32 | Sum_ConstTraits           |        497.851 |       488.532 |      5878.300 |  5935.378 |  8279.822 |  8168.093 |
| YShuffleG2Benchmark_Int32 | Sum_Const128Traits        |                |               |               |           |           |           |
| YShuffleG2Benchmark_Int32 | Sum_Const256_AvxImm       |                |               |      2832.045 |  2247.003 |  2670.028 |  2492.633 |
| YShuffleG2Benchmark_Int32 | Sum_Const256_AvxImmByte   |                |               |      2211.134 |  2473.094 |  2394.198 |  2682.200 |
| YShuffleG2Benchmark_Int32 | Sum_Const256_AvxImmByteG4 |                |               |     11934.933 | 11688.258 | 10808.298 | 11263.914 |
| YShuffleG2Benchmark_Int32 | Sum_Const256Traits        |                |               |      5616.497 |  5642.545 |  8320.925 |  8350.406 |
| YShuffleG2Benchmark_Int64 | SumScalar                 |        493.478 |       488.174 |       472.655 |   510.566 |   517.433 |   524.689 |
| YShuffleG2Benchmark_Int64 | SumBase                   |        495.242 |       486.538 |       495.096 |   511.085 |   497.766 |   523.493 |
| YShuffleG2Benchmark_Int64 | SumTraits                 |        495.560 |       484.543 |      2956.109 |  2821.899 |  4469.086 |  4420.383 |
| YShuffleG2Benchmark_Int64 | Sum128_AdvSimd            |                |               |               |           |           |           |
| YShuffleG2Benchmark_Int64 | Sum128Traits              |                |               |               |           |           |           |
| YShuffleG2Benchmark_Int64 | Sum256Traits              |                |               |      2916.597 |  2696.281 |  4642.996 |  4258.220 |
| YShuffleG2Benchmark_Int64 | Sum_ConstTraits           |        524.849 |       521.083 |      2814.256 |  2765.271 |  4155.818 |  4135.294 |
| YShuffleG2Benchmark_Int64 | Sum_Const128Traits        |                |               |               |           |           |           |
| YShuffleG2Benchmark_Int64 | Sum_Const256Traits        |                |               |      2865.033 |  2744.432 |  4020.205 |  4069.263 |
| YShuffleG2Benchmark_SByte | SumScalar                 |        687.281 |       684.887 |       683.754 |   679.237 |   687.424 |   854.318 |
| YShuffleG2Benchmark_SByte | SumBase                   |        685.415 |       683.982 |       687.714 |   675.446 |   688.516 |   862.064 |
| YShuffleG2Benchmark_SByte | SumTraits                 |        658.184 |       685.187 |     25055.009 | 24092.316 | 40141.594 | 44339.044 |
| YShuffleG2Benchmark_SByte | Sum128_AdvSimd            |                |               |               |           |           |           |
| YShuffleG2Benchmark_SByte | Sum128Traits              |                |               |               |           |           |           |
| YShuffleG2Benchmark_SByte | Sum256Traits              |                |               |     25274.170 | 24336.080 | 38642.844 | 36544.143 |
| YShuffleG2Benchmark_SByte | Sum_ConstTraits           |        688.711 |       668.551 |     24830.939 | 24118.642 | 36462.187 | 37174.087 |
| YShuffleG2Benchmark_SByte | Sum_Const128Traits        |                |               |               |           |           |           |
| YShuffleG2Benchmark_SByte | Sum_Const256Traits        |                |               |     25514.129 | 23525.222 | 37278.811 | 36700.467 |

### Arm - AWS Arm t4g.small
| Class                     | Name                      | .NET Core 3.1 | .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
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
