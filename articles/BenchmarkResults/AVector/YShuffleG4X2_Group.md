# Benchmark group - YShuffleG4X2
([← Back](YShuffleG4X2.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### X86 - Intel Core i5-8250U
| Type                        | Method                | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :-------------------------- | :-------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| YShuffleG4X2Benchmark_Int16 | SumBase               |        604.368 |       605.019 |       604.772 |   601.192 |   601.183 |   722.814 |
| YShuffleG4X2Benchmark_Int16 | SumX1Traits           |        598.045 |       605.413 |     12930.060 | 12294.010 | 18772.650 | 18621.907 |
| YShuffleG4X2Benchmark_Int16 | SumTraits             |        587.588 |       594.372 |     19257.822 | 16682.197 | 25494.812 | 25367.735 |
| YShuffleG4X2Benchmark_Int16 | SumTraits_Tuple       |        560.975 |       566.371 |     19302.355 | 16299.193 | 24203.469 | 22816.660 |
| YShuffleG4X2Benchmark_Int16 | Sum128_AdvSimd        |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int16 | Sum128Traits          |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int16 | Sum256Traits          |                |               |     18486.745 | 16294.572 | 23868.968 | 20514.835 |
| YShuffleG4X2Benchmark_Int16 | Sum_ConstTraits       |        602.068 |       609.252 |     21505.117 | 22244.778 | 21862.272 | 20926.384 |
| YShuffleG4X2Benchmark_Int16 | Sum_ConstTraits_Tuple |        563.605 |       569.355 |     22064.664 | 22931.536 | 22279.852 | 20859.201 |
| YShuffleG4X2Benchmark_Int16 | Sum_Const128Traits    |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int16 | Sum_Const256Traits    |                |               |     22835.240 | 22811.077 | 21098.262 | 21906.832 |
| YShuffleG4X2Benchmark_Int32 | SumBase               |        506.526 |       506.285 |       506.911 |   500.513 |   501.422 |   601.601 |
| YShuffleG4X2Benchmark_Int32 | SumX1Traits           |        498.014 |       506.926 |      6493.039 |  6575.761 |  9403.820 | 10121.229 |
| YShuffleG4X2Benchmark_Int32 | SumTraits             |        497.178 |       506.727 |      9663.801 |  9821.422 | 11642.613 | 12747.287 |
| YShuffleG4X2Benchmark_Int32 | SumTraits_Tuple       |        447.183 |       454.713 |      9134.729 |  9586.225 | 11466.051 | 12076.112 |
| YShuffleG4X2Benchmark_Int32 | Sum128_AdvSimd        |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum128Traits          |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum256_AvxByte        |                |               |      6448.121 |  6467.938 |  8593.620 |  9385.387 |
| YShuffleG4X2Benchmark_Int32 | Sum256Traits          |                |               |      9593.401 |  9517.575 | 11406.760 | 10597.180 |
| YShuffleG4X2Benchmark_Int32 | Sum_ConstTraits       |        501.899 |       511.712 |     13650.390 | 12974.746 | 13060.254 | 11995.514 |
| YShuffleG4X2Benchmark_Int32 | Sum_ConstTraits_Tuple |        446.961 |       458.302 |     13685.470 | 12975.482 | 13135.072 | 11987.409 |
| YShuffleG4X2Benchmark_Int32 | Sum_Const128Traits    |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum_Const256Traits    |                |               |     13600.812 | 13049.137 | 12457.351 | 12213.343 |
| YShuffleG4X2Benchmark_Int64 | SumBase               |        519.272 |       565.151 |       572.385 |   544.761 |   545.078 |   590.512 |
| YShuffleG4X2Benchmark_Int64 | SumX1Traits           |        560.325 |       568.756 |      3295.475 |  3297.847 |  4735.738 |  4718.277 |
| YShuffleG4X2Benchmark_Int64 | SumTraits             |        555.976 |       563.765 |      4818.673 |  4930.841 |  5826.852 |  5956.913 |
| YShuffleG4X2Benchmark_Int64 | SumTraits_Tuple       |        425.469 |       447.161 |      4914.221 |  4823.261 |  5673.575 |  5890.045 |
| YShuffleG4X2Benchmark_Int64 | Sum128_AdvSimd        |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int64 | Sum128Traits          |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int64 | Sum256Traits          |                |               |      4914.886 |  4548.164 |  5583.076 |  5752.407 |
| YShuffleG4X2Benchmark_Int64 | Sum_ConstTraits       |        555.330 |       610.450 |      6685.522 |  6486.618 |  6195.988 |  6440.999 |
| YShuffleG4X2Benchmark_Int64 | Sum_ConstTraits_Tuple |        442.186 |       472.614 |      6686.245 |  6458.302 |  5707.375 |  6446.679 |
| YShuffleG4X2Benchmark_Int64 | Sum_Const128Traits    |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int64 | Sum_Const256Traits    |                |               |      6727.235 |  6501.550 |  6491.337 |  6535.823 |
| YShuffleG4X2Benchmark_SByte | SumBase               |        669.577 |       670.746 |       669.016 |   669.393 |   668.805 |   828.776 |
| YShuffleG4X2Benchmark_SByte | SumX1Traits           |        665.919 |       669.964 |     27587.913 | 27336.581 | 33891.346 | 44280.087 |
| YShuffleG4X2Benchmark_SByte | SumTraits             |        665.610 |       670.774 |     39753.833 | 42621.456 | 50719.209 | 61080.997 |
| YShuffleG4X2Benchmark_SByte | SumTraits_Tuple       |        640.824 |       645.683 |     39824.855 | 42616.437 | 50652.042 | 57320.647 |
| YShuffleG4X2Benchmark_SByte | Sum128_AdvSimd        |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_SByte | Sum128Traits          |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_SByte | Sum256Traits          |                |               |     39821.505 | 42602.583 | 50758.770 | 61099.128 |
| YShuffleG4X2Benchmark_SByte | Sum_ConstTraits       |        668.384 |       671.130 |     39799.662 | 41117.714 | 50227.260 | 56773.400 |
| YShuffleG4X2Benchmark_SByte | Sum_ConstTraits_Tuple |        642.265 |       647.798 |     39657.481 | 40934.326 | 47794.201 | 56544.720 |
| YShuffleG4X2Benchmark_SByte | Sum_Const128Traits    |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_SByte | Sum_Const256Traits    |                |               |     39580.757 | 41680.650 | 49159.909 | 53815.407 |

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

