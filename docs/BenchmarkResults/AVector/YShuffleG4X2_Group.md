# Benchmark group - YShuffleG4X2
([← Back](YShuffleG4X2.md))

Cell unit: Million operations per second.

### x86 - lntel Core i5-8250U
| Type                        | Method                | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :-------------------------- | :-------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| YShuffleG4X2Benchmark_Int16 | SumBase               |        564.083 |       595.466 |       595.448 |   590.724 |   512.864 |   715.001 |
| YShuffleG4X2Benchmark_Int16 | SumX1Traits           |        562.084 |       600.573 |     12720.684 | 12704.739 | 17460.290 | 16932.627 |
| YShuffleG4X2Benchmark_Int16 | SumTraits             |        570.190 |       596.527 |     17173.037 | 17332.131 | 20686.613 | 20633.084 |
| YShuffleG4X2Benchmark_Int16 | SumTraits_Tuple       |        556.791 |       555.372 |     17337.930 | 17008.546 | 20225.145 | 21290.774 |
| YShuffleG4X2Benchmark_Int16 | Sum128_AdvSimd        |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int16 | Sum128Traits          |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int16 | Sum256Traits          |                |               |     17194.137 | 16776.250 | 19903.875 | 21380.298 |
| YShuffleG4X2Benchmark_Int16 | Sum_ConstTraits       |        604.905 |       600.286 |     21062.692 | 20258.276 | 20093.341 | 20945.502 |
| YShuffleG4X2Benchmark_Int16 | Sum_ConstTraits_Tuple |        564.236 |       560.342 |     21022.447 | 20804.018 | 19871.176 | 20815.359 |
| YShuffleG4X2Benchmark_Int16 | Sum_Const128Traits    |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int16 | Sum_Const256Traits    |                |               |     21911.390 | 19839.770 | 20030.044 | 21305.425 |
| YShuffleG4X2Benchmark_Int32 | SumBase               |        500.390 |       499.388 |       495.394 |   496.104 |   399.739 |   594.812 |
| YShuffleG4X2Benchmark_Int32 | SumX1Traits           |        500.488 |       503.535 |      6441.608 |  6502.217 |  8895.077 | 10467.039 |
| YShuffleG4X2Benchmark_Int32 | SumTraits             |        499.696 |       502.566 |      9377.304 |  9197.947 | 11487.858 | 10783.041 |
| YShuffleG4X2Benchmark_Int32 | SumTraits_Tuple       |        446.441 |       451.326 |      9052.144 |  9118.370 | 11518.685 | 10700.909 |
| YShuffleG4X2Benchmark_Int32 | Sum128_AdvSimd        |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum128Traits          |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum256_AvxByte        |                |               |      6446.014 |  6309.680 |  8223.636 | 10443.662 |
| YShuffleG4X2Benchmark_Int32 | Sum256Traits          |                |               |      9026.576 |  8846.974 | 10767.055 | 10216.877 |
| YShuffleG4X2Benchmark_Int32 | Sum_ConstTraits       |        502.921 |       509.164 |     13273.002 | 12482.100 | 10998.920 |  6970.710 |
| YShuffleG4X2Benchmark_Int32 | Sum_ConstTraits_Tuple |        451.398 |       455.307 |     12876.465 | 12675.650 | 11113.422 | 11891.303 |
| YShuffleG4X2Benchmark_Int32 | Sum_Const128Traits    |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum_Const256Traits    |                |               |     11315.261 | 12506.812 | 12147.891 | 11012.402 |
| YShuffleG4X2Benchmark_Int64 | SumBase               |        554.871 |       559.836 |       544.400 |   539.874 |   332.325 |   458.875 |
| YShuffleG4X2Benchmark_Int64 | SumX1Traits           |        556.479 |       564.553 |      3121.799 |  3171.814 |  4172.680 |  3878.064 |
| YShuffleG4X2Benchmark_Int64 | SumTraits             |        555.812 |       560.004 |      4218.118 |  4468.820 |  5037.821 |  5465.986 |
| YShuffleG4X2Benchmark_Int64 | SumTraits_Tuple       |        445.727 |       444.347 |      4180.170 |  4424.294 |  4980.984 |  5084.728 |
| YShuffleG4X2Benchmark_Int64 | Sum128_AdvSimd        |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int64 | Sum128Traits          |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int64 | Sum256Traits          |                |               |      4052.918 |  3006.158 |  4586.584 |  4494.170 |
| YShuffleG4X2Benchmark_Int64 | Sum_ConstTraits       |        602.904 |       604.589 |      5485.269 |  6040.733 |  5978.404 |  5763.214 |
| YShuffleG4X2Benchmark_Int64 | Sum_ConstTraits_Tuple |        469.922 |       461.213 |      5488.996 |  5793.733 |  5934.849 |  5890.342 |
| YShuffleG4X2Benchmark_Int64 | Sum_Const128Traits    |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int64 | Sum_Const256Traits    |                |               |      5208.663 |  6053.216 |  5758.476 |  6030.018 |
| YShuffleG4X2Benchmark_SByte | SumBase               |        664.852 |       658.383 |       643.552 |   664.941 |   669.107 |   815.611 |
| YShuffleG4X2Benchmark_SByte | SumX1Traits           |        663.058 |       659.135 |     26793.985 | 27144.762 | 40233.578 | 49442.499 |
| YShuffleG4X2Benchmark_SByte | SumTraits             |        663.196 |       659.083 |     37380.388 | 40436.361 | 53368.288 | 54060.355 |
| YShuffleG4X2Benchmark_SByte | SumTraits_Tuple       |        640.656 |       634.735 |     37589.282 | 40382.168 | 55119.344 | 54438.547 |
| YShuffleG4X2Benchmark_SByte | Sum128_AdvSimd        |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_SByte | Sum128Traits          |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_SByte | Sum256Traits          |                |               |     37964.204 | 40971.100 | 55280.476 | 54562.553 |
| YShuffleG4X2Benchmark_SByte | Sum_ConstTraits       |        667.045 |       663.083 |     38366.103 | 39237.910 | 55488.741 | 54258.495 |
| YShuffleG4X2Benchmark_SByte | Sum_ConstTraits_Tuple |        643.250 |       640.262 |     36315.579 | 35728.004 | 54438.179 | 53572.552 |
| YShuffleG4X2Benchmark_SByte | Sum_Const128Traits    |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_SByte | Sum_Const256Traits    |                |               |     35820.451 | 37953.955 | 54342.496 | 53443.966 |

### Arm - AWS Arm t4g.small
| Type                        | Method                | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :-------------------------- | :-------------------- | ------------: | --------: | --------: | --------: |
| YShuffleG4X2Benchmark_Int16 | SumBase               |       384.581 |   387.692 |   388.405 |   514.902 |
| YShuffleG4X2Benchmark_Int16 | SumX1Traits           |       382.509 |  6564.384 |  8097.043 |  8741.548 |
| YShuffleG4X2Benchmark_Int16 | SumTraits             |       385.849 |  7768.697 |  8658.265 | 10433.609 |
| YShuffleG4X2Benchmark_Int16 | SumTraits_Tuple       |       353.018 |  2323.129 |  2878.457 |  2999.818 |
| YShuffleG4X2Benchmark_Int16 | Sum128_AdvSimd        |               |  4416.346 |  5347.275 |  5746.664 |
| YShuffleG4X2Benchmark_Int16 | Sum128Traits          |       242.338 |  7748.439 |  8741.823 | 10434.019 |
| YShuffleG4X2Benchmark_Int16 | Sum256Traits          |               |           |           |           |
| YShuffleG4X2Benchmark_Int16 | Sum_ConstTraits       |       373.529 |  7765.248 |  8448.968 |  9860.214 |
| YShuffleG4X2Benchmark_Int16 | Sum_ConstTraits_Tuple |       343.080 |  2468.814 |  2878.354 |  3000.560 |
| YShuffleG4X2Benchmark_Int16 | Sum_Const128Traits    |       238.065 |  7747.366 |  8503.488 |  9857.672 |
| YShuffleG4X2Benchmark_Int16 | Sum_Const256Traits    |               |           |           |           |
| YShuffleG4X2Benchmark_Int32 | SumBase               |       372.300 |   380.343 |   378.167 |   395.500 |
| YShuffleG4X2Benchmark_Int32 | SumX1Traits           |       373.991 |  3254.959 |  3849.454 |  4277.648 |
| YShuffleG4X2Benchmark_Int32 | SumTraits             |       371.059 |  3818.691 |  3989.740 |  5120.962 |
| YShuffleG4X2Benchmark_Int32 | SumTraits_Tuple       |       283.093 |  1138.388 |  1437.628 |  1435.697 |
| YShuffleG4X2Benchmark_Int32 | Sum128_AdvSimd        |               |  2219.063 |  2677.315 |  2844.455 |
| YShuffleG4X2Benchmark_Int32 | Sum128Traits          |       178.576 |  3843.423 |  4108.155 |  5108.926 |
| YShuffleG4X2Benchmark_Int32 | Sum256_AvxByte        |               |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum256Traits          |               |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum_ConstTraits       |       384.756 |  3832.587 |  4032.178 |  4862.617 |
| YShuffleG4X2Benchmark_Int32 | Sum_ConstTraits_Tuple |       288.503 |  1136.007 |  1440.057 |  1464.997 |
| YShuffleG4X2Benchmark_Int32 | Sum_Const128Traits    |       178.697 |  3840.331 |  4112.626 |  4856.366 |
| YShuffleG4X2Benchmark_Int32 | Sum_Const256Traits    |               |           |           |           |
| YShuffleG4X2Benchmark_Int64 | SumBase               |       314.591 |   340.055 |   338.274 |   465.557 |
| YShuffleG4X2Benchmark_Int64 | SumX1Traits           |               |           |           |           |
| YShuffleG4X2Benchmark_Int64 | SumTraits             |       313.926 |  1240.795 |  1534.835 |  1637.245 |
| YShuffleG4X2Benchmark_Int64 | SumTraits_Tuple       |       254.937 |   418.773 |   644.609 |   703.869 |
| YShuffleG4X2Benchmark_Int64 | Sum128_AdvSimd        |               |   554.611 |   636.404 |   725.155 |
| YShuffleG4X2Benchmark_Int64 | Sum128Traits          |       204.927 |  1238.041 |  1501.356 |  1636.318 |
| YShuffleG4X2Benchmark_Int64 | Sum256Traits          |               |           |           |           |
| YShuffleG4X2Benchmark_Int64 | Sum_ConstTraits       |       307.990 |  1225.177 |  1496.361 |  1635.564 |
| YShuffleG4X2Benchmark_Int64 | Sum_ConstTraits_Tuple |       249.660 |   427.885 |   637.717 |   714.942 |
| YShuffleG4X2Benchmark_Int64 | Sum_Const128Traits    |       204.887 |  1226.078 |  1497.514 |  1636.674 |
| YShuffleG4X2Benchmark_Int64 | Sum_Const256Traits    |               |           |           |           |
| YShuffleG4X2Benchmark_SByte | SumBase               |       459.984 |   463.370 |   464.030 |   639.422 |
| YShuffleG4X2Benchmark_SByte | SumX1Traits           |       461.883 | 14125.982 | 15684.232 | 17640.121 |
| YShuffleG4X2Benchmark_SByte | SumTraits             |       459.523 | 15604.242 | 17580.562 | 21032.648 |
| YShuffleG4X2Benchmark_SByte | SumTraits_Tuple       |       432.798 |  4811.334 |  5624.091 |  5972.646 |
| YShuffleG4X2Benchmark_SByte | Sum128_AdvSimd        |               |  9075.087 | 10863.503 | 11437.349 |
| YShuffleG4X2Benchmark_SByte | Sum128Traits          |       308.915 | 15580.659 | 17285.738 | 21033.148 |
| YShuffleG4X2Benchmark_SByte | Sum256Traits          |               |           |           |           |
| YShuffleG4X2Benchmark_SByte | Sum_ConstTraits       |       442.770 | 15612.462 | 17802.435 | 19809.813 |
| YShuffleG4X2Benchmark_SByte | Sum_ConstTraits_Tuple |       418.399 |  4960.488 |  5749.413 |  6111.353 |
| YShuffleG4X2Benchmark_SByte | Sum_Const128Traits    |       302.870 | 15596.408 | 17356.546 | 19806.095 |
| YShuffleG4X2Benchmark_SByte | Sum_Const256Traits    |               |           |           |           |
