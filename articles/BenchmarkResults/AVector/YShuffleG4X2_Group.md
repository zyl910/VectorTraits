# Benchmark group - YShuffleG4X2
([← Back](YShuffleG4X2.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### X86 - AMD Ryzen 7 7840H
| Type                        | Method                | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :-------------------------- | :-------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| YShuffleG4X2Benchmark_Int16 | SumBase               |       1047.373 |      1056.396 |      1049.306 |  1063.925 |  1050.791 |  1164.705 |  1087.532 |
| YShuffleG4X2Benchmark_Int16 | SumX1Traits           |       1045.792 |      1064.128 |     23967.494 | 28593.986 | 36532.494 | 36390.041 | 28825.390 |
| YShuffleG4X2Benchmark_Int16 | SumTraits             |       1061.080 |      1073.235 |     34023.693 | 37942.362 | 44152.792 | 43789.761 | 38868.567 |
| YShuffleG4X2Benchmark_Int16 | SumTraits_Tuple       |        866.592 |       879.379 |     33848.802 | 37508.292 | 43794.598 | 43789.378 | 38853.427 |
| YShuffleG4X2Benchmark_Int16 | Sum128_AdvSimd        |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int16 | Sum128Traits          |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int16 | Sum256Traits          |                |               |     33839.255 | 37738.991 | 44124.759 | 43582.881 | 39020.495 |
| YShuffleG4X2Benchmark_Int16 | Sum_ConstTraits       |       1052.794 |      1060.702 |     46472.338 | 46504.710 | 46197.595 | 46296.447 | 44650.569 |
| YShuffleG4X2Benchmark_Int16 | Sum_ConstTraits_Tuple |        857.926 |       888.457 |     46291.083 | 46829.284 | 46480.590 | 47042.929 | 44245.494 |
| YShuffleG4X2Benchmark_Int16 | Sum_Const128Traits    |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int16 | Sum_Const256Traits    |                |               |     46337.488 | 46074.487 | 47310.546 | 46519.053 | 44706.811 |
| YShuffleG4X2Benchmark_Int16 | Sum_Const512Base      |                |               |               |           |           |           |  1091.392 |
| YShuffleG4X2Benchmark_Int16 | Sum_Const512Traits    |                |               |               |           |           |           | 48256.555 |
| YShuffleG4X2Benchmark_Int32 | SumBase               |        750.196 |       759.176 |       760.080 |   768.176 |   775.863 |   802.941 |   796.666 |
| YShuffleG4X2Benchmark_Int32 | SumX1Traits           |        748.085 |       750.617 |     13906.051 | 14895.508 | 17867.823 | 15859.545 | 17608.079 |
| YShuffleG4X2Benchmark_Int32 | SumTraits             |        761.217 |       767.154 |     17568.152 | 17669.775 | 20506.905 | 20813.315 | 19197.900 |
| YShuffleG4X2Benchmark_Int32 | SumTraits_Tuple       |        582.637 |       599.184 |     17688.596 | 17917.574 | 20605.049 | 20828.891 | 19247.415 |
| YShuffleG4X2Benchmark_Int32 | Sum128_AdvSimd        |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum128Traits          |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum256_AvxByte        |                |               |     13973.387 | 15160.324 | 17784.568 | 15885.388 | 17751.616 |
| YShuffleG4X2Benchmark_Int32 | Sum256Traits          |                |               |     17629.254 | 17896.235 | 20285.164 | 20707.604 | 19362.179 |
| YShuffleG4X2Benchmark_Int32 | Sum_ConstTraits       |        763.502 |       755.184 |     23130.500 | 23317.949 | 24538.387 | 23258.395 | 20703.402 |
| YShuffleG4X2Benchmark_Int32 | Sum_ConstTraits_Tuple |        590.877 |       596.525 |     23039.983 | 23769.367 | 24392.649 | 23337.043 | 20605.301 |
| YShuffleG4X2Benchmark_Int32 | Sum_Const128Traits    |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum_Const256Traits    |                |               |     22999.480 | 23670.061 | 24302.508 | 22897.118 | 20679.619 |
| YShuffleG4X2Benchmark_Int32 | Sum_Const512Base      |                |               |               |           |           |           |  1054.703 |
| YShuffleG4X2Benchmark_Int32 | Sum_Const512Traits    |                |               |               |           |           |           | 20953.426 |
| YShuffleG4X2Benchmark_Int64 | SumBase               |        518.676 |       522.653 |       295.674 |   533.413 |   535.343 |   556.930 |   575.813 |
| YShuffleG4X2Benchmark_Int64 | SumX1Traits           |        528.377 |       552.722 |      7469.600 |  7517.121 |  8600.672 |  8788.618 |  7006.118 |
| YShuffleG4X2Benchmark_Int64 | SumTraits             |        518.982 |       523.069 |      8979.894 |  8619.067 | 10480.550 | 10221.253 |  9188.129 |
| YShuffleG4X2Benchmark_Int64 | SumTraits_Tuple       |        371.781 |       390.945 |      8513.181 |  8805.178 | 10486.293 | 10023.004 |  9331.791 |
| YShuffleG4X2Benchmark_Int64 | Sum128_AdvSimd        |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int64 | Sum128Traits          |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int64 | Sum256Traits          |                |               |      8864.634 |  9003.060 | 10306.848 | 10184.230 |  9321.495 |
| YShuffleG4X2Benchmark_Int64 | Sum_ConstTraits       |        533.340 |       549.460 |     10092.153 |  9825.175 | 10259.002 | 10078.795 | 10175.136 |
| YShuffleG4X2Benchmark_Int64 | Sum_ConstTraits_Tuple |        369.756 |       391.739 |     10278.323 |  9934.052 |  9993.286 | 10510.863 |  9963.526 |
| YShuffleG4X2Benchmark_Int64 | Sum_Const128Traits    |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int64 | Sum_Const256Traits    |                |               |     10021.252 |  9876.368 | 10460.066 | 10118.781 | 10043.983 |
| YShuffleG4X2Benchmark_Int64 | Sum_Const512Base      |                |               |               |           |           |           |   755.221 |
| YShuffleG4X2Benchmark_Int64 | Sum_Const512Traits    |                |               |               |           |           |           | 10393.064 |
| YShuffleG4X2Benchmark_SByte | SumBase               |       1076.561 |      1099.930 |      1079.975 |  1087.969 |  1097.182 |  1230.002 |  1081.589 |
| YShuffleG4X2Benchmark_SByte | SumX1Traits           |       1077.905 |      1101.540 |     60997.762 | 47998.517 | 54773.611 | 78647.322 | 76556.340 |
| YShuffleG4X2Benchmark_SByte | SumTraits             |       1066.473 |      1079.003 |     75216.080 | 67235.877 | 73916.051 | 92589.401 | 90227.373 |
| YShuffleG4X2Benchmark_SByte | SumTraits_Tuple       |        997.032 |      1016.332 |     74572.045 | 65326.522 | 74450.965 | 92433.791 | 90186.086 |
| YShuffleG4X2Benchmark_SByte | Sum128_AdvSimd        |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_SByte | Sum128Traits          |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_SByte | Sum256Traits          |                |               |     75069.195 | 66240.552 | 74271.462 | 91799.580 | 89849.692 |
| YShuffleG4X2Benchmark_SByte | Sum_ConstTraits       |       1059.290 |      1077.167 |     73166.908 | 66970.406 | 73145.330 | 95827.934 | 90944.139 |
| YShuffleG4X2Benchmark_SByte | Sum_ConstTraits_Tuple |        985.849 |       990.891 |     74797.209 | 67048.712 | 70513.452 | 94189.842 | 89847.233 |
| YShuffleG4X2Benchmark_SByte | Sum_Const128Traits    |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_SByte | Sum_Const256Traits    |                |               |     74628.523 | 67215.770 | 73054.212 | 95310.098 | 90552.460 |
| YShuffleG4X2Benchmark_SByte | Sum_Const512Base      |                |               |               |           |           |           |  1097.093 |
| YShuffleG4X2Benchmark_SByte | Sum_Const512Traits    |                |               |               |           |           |           | 80780.153 |

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
| YShuffleG4X2Benchmark_Int16 | SumBase               |       385.858 |   387.764 |   387.014 |   517.029 |
| YShuffleG4X2Benchmark_Int16 | SumX1Traits           |       383.028 |  5935.688 |  7893.089 |  8859.966 |
| YShuffleG4X2Benchmark_Int16 | SumTraits             |       385.785 |  7144.903 |  8462.884 | 10554.444 |
| YShuffleG4X2Benchmark_Int16 | SumTraits_Tuple       |       353.229 |  2154.287 |  2894.568 |  2909.155 |
| YShuffleG4X2Benchmark_Int16 | Sum128_AdvSimd        |               |  3681.616 |  5305.467 |  5792.771 |
| YShuffleG4X2Benchmark_Int16 | Sum128Traits          |       242.531 |  7137.978 |  8546.491 | 10561.232 |
| YShuffleG4X2Benchmark_Int16 | Sum256Traits          |               |           |           |           |
| YShuffleG4X2Benchmark_Int16 | Sum_ConstTraits       |       373.978 |  7162.871 |  8402.658 |  9948.207 |
| YShuffleG4X2Benchmark_Int16 | Sum_ConstTraits_Tuple |       343.227 |  2152.246 |  2946.516 |  3000.704 |
| YShuffleG4X2Benchmark_Int16 | Sum_Const128Traits    |       238.526 |  7168.684 |  8526.711 |  9954.407 |
| YShuffleG4X2Benchmark_Int16 | Sum_Const256Traits    |               |           |           |           |
| YShuffleG4X2Benchmark_Int32 | SumBase               |       373.690 |   381.151 |   381.516 |   394.864 |
| YShuffleG4X2Benchmark_Int32 | SumX1Traits           |       376.163 |  3536.042 |  3871.594 |  4210.424 |
| YShuffleG4X2Benchmark_Int32 | SumTraits             |       375.524 |  3879.751 |  4254.200 |  5109.443 |
| YShuffleG4X2Benchmark_Int32 | SumTraits_Tuple       |       281.434 |  1379.956 |  1428.878 |  1468.844 |
| YShuffleG4X2Benchmark_Int32 | Sum128_AdvSimd        |               |  2224.736 |  2669.193 |  2872.439 |
| YShuffleG4X2Benchmark_Int32 | Sum128Traits          |       178.734 |  3875.407 |  4193.269 |  5101.200 |
| YShuffleG4X2Benchmark_Int32 | Sum256_AvxByte        |               |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum256Traits          |               |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum_ConstTraits       |       384.960 |  3879.192 |  4207.505 |  4825.364 |
| YShuffleG4X2Benchmark_Int32 | Sum_ConstTraits_Tuple |       287.371 |  1170.146 |  1428.726 |  1458.906 |
| YShuffleG4X2Benchmark_Int32 | Sum_Const128Traits    |       179.090 |  3878.295 |  4195.113 |  4838.384 |
| YShuffleG4X2Benchmark_Int32 | Sum_Const256Traits    |               |           |           |           |
| YShuffleG4X2Benchmark_Int64 | SumBase               |       314.661 |   338.750 |   340.130 |   464.597 |
| YShuffleG4X2Benchmark_Int64 | SumX1Traits           |               |           |           |           |
| YShuffleG4X2Benchmark_Int64 | SumTraits             |       314.596 |  1209.464 |  1536.557 |  1634.510 |
| YShuffleG4X2Benchmark_Int64 | SumTraits_Tuple       |       255.207 |   429.520 |   676.752 |   710.218 |
| YShuffleG4X2Benchmark_Int64 | Sum128_AdvSimd        |               |   536.945 |   674.696 |   726.143 |
| YShuffleG4X2Benchmark_Int64 | Sum128Traits          |       205.594 |  1209.861 |  1499.145 |  1630.660 |
| YShuffleG4X2Benchmark_Int64 | Sum256Traits          |               |           |           |           |
| YShuffleG4X2Benchmark_Int64 | Sum_ConstTraits       |       311.072 |  1206.914 |  1500.990 |  1633.253 |
| YShuffleG4X2Benchmark_Int64 | Sum_ConstTraits_Tuple |       253.560 |   430.271 |   676.521 |   709.713 |
| YShuffleG4X2Benchmark_Int64 | Sum_Const128Traits    |       203.104 |  1205.197 |  1498.478 |  1632.409 |
| YShuffleG4X2Benchmark_Int64 | Sum_Const256Traits    |               |           |           |           |
| YShuffleG4X2Benchmark_SByte | SumBase               |       459.578 |   463.651 |   463.870 |   638.305 |
| YShuffleG4X2Benchmark_SByte | SumX1Traits           |       462.515 | 14034.527 | 14040.669 | 17806.962 |
| YShuffleG4X2Benchmark_SByte | SumTraits             |       460.261 | 15515.454 | 17124.365 | 21066.988 |
| YShuffleG4X2Benchmark_SByte | SumTraits_Tuple       |       433.209 |  4819.098 |  5684.755 |  5972.603 |
| YShuffleG4X2Benchmark_SByte | Sum128_AdvSimd        |               |  8866.246 |  9048.188 | 11533.557 |
| YShuffleG4X2Benchmark_SByte | Sum128Traits          |       310.085 | 15483.485 | 17202.753 | 21060.724 |
| YShuffleG4X2Benchmark_SByte | Sum256Traits          |               |           |           |           |
| YShuffleG4X2Benchmark_SByte | Sum_ConstTraits       |       442.729 | 15552.141 | 16947.788 | 19811.234 |
| YShuffleG4X2Benchmark_SByte | Sum_ConstTraits_Tuple |       417.837 |  4710.493 |  5782.395 |  5976.286 |
| YShuffleG4X2Benchmark_SByte | Sum_Const128Traits    |       303.322 | 15509.914 | 16702.273 | 19807.954 |
| YShuffleG4X2Benchmark_SByte | Sum_Const256Traits    |               |           |           |           |

