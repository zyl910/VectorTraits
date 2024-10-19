# Benchmark group - YShuffleG4X2
([← Back](YShuffleG4X2.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### X86 - AMD Ryzen 7 7840H
| Type                        | Method                | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :-------------------------- | :-------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| YShuffleG4X2Benchmark_Int16 | SumBase               |        932.849 |       857.083 |       836.889 |   851.184 |   876.439 |   841.274 |   864.052 |
| YShuffleG4X2Benchmark_Int16 | SumX1Traits           |        907.773 |       846.272 |     20988.970 | 24259.678 | 28714.463 | 28411.778 | 26522.605 |
| YShuffleG4X2Benchmark_Int16 | SumTraits             |        937.669 |       863.389 |     29062.897 | 30749.699 | 34800.021 | 33539.357 | 34734.374 |
| YShuffleG4X2Benchmark_Int16 | SumTraits_Tuple       |        788.375 |       728.822 |     28512.432 | 31525.252 | 35639.518 | 35323.473 | 35114.181 |
| YShuffleG4X2Benchmark_Int16 | Sum128Base            |                |               |       432.967 |   434.706 |   432.871 |   492.241 |   525.951 |
| YShuffleG4X2Benchmark_Int16 | Sum128_AdvSimd        |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int16 | Sum128Traits          |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int16 | Sum128Traits_Tuple    |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int16 | Sum256Traits          |                |               |     28233.307 | 31109.392 | 36356.234 | 34364.944 | 35189.646 |
| YShuffleG4X2Benchmark_Int16 | Sum_ConstTraits       |        901.082 |       858.425 |     39070.402 | 39501.008 | 38643.543 | 37657.209 | 38505.508 |
| YShuffleG4X2Benchmark_Int16 | Sum_ConstTraits_Tuple |        747.602 |       720.269 |     38801.858 | 38461.283 | 38203.686 | 38293.013 | 37763.698 |
| YShuffleG4X2Benchmark_Int16 | Sum_Const128Traits    |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int16 | Sum_Const256Traits    |                |               |     38917.102 | 38756.603 | 37700.343 | 37241.789 | 37945.592 |
| YShuffleG4X2Benchmark_Int16 | Sum_Const512Base      |                |               |               |           |           |           |   881.357 |
| YShuffleG4X2Benchmark_Int16 | Sum_Const512Traits    |                |               |               |           |           |           | 45244.389 |
| YShuffleG4X2Benchmark_Int32 | SumBase               |        708.401 |       658.863 |       686.634 |   690.427 |   681.261 |   692.795 |   701.310 |
| YShuffleG4X2Benchmark_Int32 | SumX1Traits           |        682.318 |       665.595 |     13224.210 | 10471.827 | 11661.263 | 12331.832 | 16072.444 |
| YShuffleG4X2Benchmark_Int32 | SumTraits             |        701.631 |       685.846 |     15161.528 | 13921.015 | 14706.853 | 15489.143 | 16990.173 |
| YShuffleG4X2Benchmark_Int32 | SumTraits_Tuple       |        563.486 |       552.068 |     15483.075 | 12897.447 | 15144.164 | 15258.950 | 17129.397 |
| YShuffleG4X2Benchmark_Int32 | Sum128Base            |                |               |       298.850 |   297.491 |   297.649 |   255.042 |   265.971 |
| YShuffleG4X2Benchmark_Int32 | Sum128_AdvSimd        |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum128Traits          |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum128Traits_Tuple    |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum256_AvxByte        |                |               |     13282.211 | 10358.081 | 11663.457 | 12632.545 | 16113.826 |
| YShuffleG4X2Benchmark_Int32 | Sum256Traits          |                |               |     15143.842 | 13773.854 | 15070.801 | 15646.616 | 17023.002 |
| YShuffleG4X2Benchmark_Int32 | Sum_ConstTraits       |        688.537 |       686.595 |     19483.800 | 19595.733 | 18810.468 | 19184.438 | 17996.367 |
| YShuffleG4X2Benchmark_Int32 | Sum_ConstTraits_Tuple |        563.599 |       551.314 |     19346.964 | 18910.901 | 18974.978 | 18464.753 | 18624.287 |
| YShuffleG4X2Benchmark_Int32 | Sum_Const128Traits    |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum_Const256Traits    |                |               |     19430.094 | 18166.371 | 19039.168 | 19111.498 | 18287.944 |
| YShuffleG4X2Benchmark_Int32 | Sum_Const512Base      |                |               |               |           |           |           |   842.825 |
| YShuffleG4X2Benchmark_Int32 | Sum_Const512Traits    |                |               |               |           |           |           | 19554.420 |
| YShuffleG4X2Benchmark_Int64 | SumBase               |        522.949 |       538.362 |       542.829 |   530.794 |   542.965 |   536.505 |   562.778 |
| YShuffleG4X2Benchmark_Int64 | SumX1Traits           |        544.235 |       518.716 |      5437.361 |  5389.533 |  6926.200 |  5972.114 |  6657.890 |
| YShuffleG4X2Benchmark_Int64 | SumTraits             |        546.002 |       519.799 |      6664.104 |  6805.716 |  8071.543 |  7647.959 |  8533.007 |
| YShuffleG4X2Benchmark_Int64 | SumTraits_Tuple       |        379.590 |       371.322 |      6706.533 |  7044.950 |  8229.299 |  7572.252 |  8470.704 |
| YShuffleG4X2Benchmark_Int64 | Sum128Base            |                |               |       176.912 |   169.318 |   170.616 |   445.845 |   489.290 |
| YShuffleG4X2Benchmark_Int64 | Sum128_AdvSimd        |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int64 | Sum128Traits          |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int64 | Sum128Traits_Tuple    |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int64 | Sum256Traits          |                |               |      6275.586 |  6332.355 |  8532.363 |  7530.993 |  8362.667 |
| YShuffleG4X2Benchmark_Int64 | Sum_ConstTraits       |        551.994 |       552.244 |      9224.785 |  9073.656 |  9173.119 |  9101.991 |  9203.110 |
| YShuffleG4X2Benchmark_Int64 | Sum_ConstTraits_Tuple |        389.703 |       374.339 |      9215.734 |  9093.494 |  9487.618 |  9146.258 |  9197.155 |
| YShuffleG4X2Benchmark_Int64 | Sum_Const128Traits    |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int64 | Sum_Const256Traits    |                |               |      8984.493 |  9206.516 |  9240.250 |  9163.501 |  9168.055 |
| YShuffleG4X2Benchmark_Int64 | Sum_Const512Base      |                |               |               |           |           |           |   664.574 |
| YShuffleG4X2Benchmark_Int64 | Sum_Const512Traits    |                |               |               |           |           |           |  9984.934 |
| YShuffleG4X2Benchmark_SByte | SumBase               |        921.770 |       871.936 |       896.449 |   914.022 |   835.593 |   924.133 |   856.264 |
| YShuffleG4X2Benchmark_SByte | SumX1Traits           |        924.459 |       906.186 |     46818.160 | 47147.269 | 59229.988 | 62022.890 | 67615.594 |
| YShuffleG4X2Benchmark_SByte | SumTraits             |        951.955 |       894.447 |     65921.580 | 64169.644 | 70322.789 | 73841.190 | 74944.981 |
| YShuffleG4X2Benchmark_SByte | SumTraits_Tuple       |        866.870 |       788.888 |     62890.216 | 62521.063 | 69877.752 | 71101.981 | 73542.098 |
| YShuffleG4X2Benchmark_SByte | Sum128Base            |                |               |       553.210 |   541.171 |   508.771 |   977.423 |  1054.977 |
| YShuffleG4X2Benchmark_SByte | Sum128_AdvSimd        |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_SByte | Sum128Traits          |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_SByte | Sum128Traits_Tuple    |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_SByte | Sum256Traits          |                |               |     63720.486 | 62994.811 | 71219.755 | 72043.149 | 72898.902 |
| YShuffleG4X2Benchmark_SByte | Sum_ConstTraits       |        956.700 |       837.742 |     64196.544 | 61935.418 | 65116.939 | 71932.872 | 75253.882 |
| YShuffleG4X2Benchmark_SByte | Sum_ConstTraits_Tuple |        852.483 |       798.094 |     65672.111 | 62243.783 | 67444.837 | 73284.557 | 76071.745 |
| YShuffleG4X2Benchmark_SByte | Sum_Const128Traits    |                |               |               |           |           |           |           |
| YShuffleG4X2Benchmark_SByte | Sum_Const256Traits    |                |               |     64128.357 | 63223.678 | 67611.717 | 73528.369 | 76548.870 |
| YShuffleG4X2Benchmark_SByte | Sum_Const512Base      |                |               |               |           |           |           |   876.075 |
| YShuffleG4X2Benchmark_SByte | Sum_Const512Traits    |                |               |               |           |           |           | 83615.534 |

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

### Arm - Apple M2
| Type                        | Method                |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :-------------------------- | :-------------------- | --------: | --------: | --------: |
| YShuffleG4X2Benchmark_Int16 | SumBase               |  1266.145 |  2017.094 |  2033.488 |
| YShuffleG4X2Benchmark_Int16 | SumX1Traits           | 22828.856 | 23518.214 | 26910.156 |
| YShuffleG4X2Benchmark_Int16 | SumTraits             | 25514.693 | 26829.468 | 27164.932 |
| YShuffleG4X2Benchmark_Int16 | SumTraits_Tuple       | 11921.728 | 11375.207 | 27160.534 |
| YShuffleG4X2Benchmark_Int16 | Sum128Base            |  1060.931 |   989.560 |   998.447 |
| YShuffleG4X2Benchmark_Int16 | Sum128_AdvSimd        | 16112.361 | 17400.628 | 23948.554 |
| YShuffleG4X2Benchmark_Int16 | Sum128Traits          | 25507.665 | 26834.360 | 27170.830 |
| YShuffleG4X2Benchmark_Int16 | Sum128Traits_Tuple    | 11900.069 | 11374.801 | 27165.799 |
| YShuffleG4X2Benchmark_Int16 | Sum256Traits          |           |           |           |
| YShuffleG4X2Benchmark_Int16 | Sum_ConstTraits       | 25503.530 | 26823.701 | 27154.820 |
| YShuffleG4X2Benchmark_Int16 | Sum_ConstTraits_Tuple | 11881.957 | 11390.594 | 27165.108 |
| YShuffleG4X2Benchmark_Int16 | Sum_Const128Traits    | 25505.617 | 26833.371 | 27168.774 |
| YShuffleG4X2Benchmark_Int16 | Sum_Const256Traits    |           |           |           |
| YShuffleG4X2Benchmark_Int16 | Sum_Const512Base      |           |           |  1759.388 |
| YShuffleG4X2Benchmark_Int16 | Sum_Const512Traits    |           |           |  1792.255 |
| YShuffleG4X2Benchmark_Int32 | SumBase               |  3272.623 |  3510.706 |  3510.907 |
| YShuffleG4X2Benchmark_Int32 | SumX1Traits           | 11420.907 | 12096.314 | 13514.691 |
| YShuffleG4X2Benchmark_Int32 | SumTraits             | 12765.153 | 13560.104 | 13568.031 |
| YShuffleG4X2Benchmark_Int32 | SumTraits_Tuple       |  5941.773 |  5517.619 | 13545.642 |
| YShuffleG4X2Benchmark_Int32 | Sum128Base            |  1306.510 |   494.591 |   499.155 |
| YShuffleG4X2Benchmark_Int32 | Sum128_AdvSimd        |  8056.450 |  8699.414 | 11978.400 |
| YShuffleG4X2Benchmark_Int32 | Sum128Traits          | 12768.117 | 13562.594 | 13567.261 |
| YShuffleG4X2Benchmark_Int32 | Sum128Traits_Tuple    |  5947.472 |  5518.168 | 13567.360 |
| YShuffleG4X2Benchmark_Int32 | Sum256_AvxByte        |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum256Traits          |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum_ConstTraits       | 12768.205 | 13563.960 | 13568.443 |
| YShuffleG4X2Benchmark_Int32 | Sum_ConstTraits_Tuple |  5928.307 |  5519.171 | 13567.871 |
| YShuffleG4X2Benchmark_Int32 | Sum_Const128Traits    | 12767.220 | 13548.236 | 13567.536 |
| YShuffleG4X2Benchmark_Int32 | Sum_Const256Traits    |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum_Const512Base      |           |           |  1832.706 |
| YShuffleG4X2Benchmark_Int32 | Sum_Const512Traits    |           |           |  1839.055 |
| YShuffleG4X2Benchmark_Int64 | SumBase               |   995.330 |  1426.754 |  2228.386 |
| YShuffleG4X2Benchmark_Int64 | SumX1Traits           |           |           |           |
| YShuffleG4X2Benchmark_Int64 | SumTraits             |  4345.013 |  4370.626 |  5127.943 |
| YShuffleG4X2Benchmark_Int64 | SumTraits_Tuple       |  2342.740 |  2479.855 |  5128.556 |
| YShuffleG4X2Benchmark_Int64 | Sum128Base            |   677.749 |  1425.859 |  2213.691 |
| YShuffleG4X2Benchmark_Int64 | Sum128_AdvSimd        |  2315.011 |  2406.883 |  2630.674 |
| YShuffleG4X2Benchmark_Int64 | Sum128Traits          |  4344.798 |  4370.687 |  5127.537 |
| YShuffleG4X2Benchmark_Int64 | Sum128Traits_Tuple    |  2341.368 |  2470.290 |  5127.707 |
| YShuffleG4X2Benchmark_Int64 | Sum256Traits          |           |           |           |
| YShuffleG4X2Benchmark_Int64 | Sum_ConstTraits       |  4180.220 |  4370.805 |  5127.101 |
| YShuffleG4X2Benchmark_Int64 | Sum_ConstTraits_Tuple |  2341.544 |  2470.290 |  5127.666 |
| YShuffleG4X2Benchmark_Int64 | Sum_Const128Traits    |  4180.824 |  4370.989 |  5128.206 |
| YShuffleG4X2Benchmark_Int64 | Sum_Const256Traits    |           |           |           |
| YShuffleG4X2Benchmark_Int64 | Sum_Const512Base      |           |           |  1526.467 |
| YShuffleG4X2Benchmark_Int64 | Sum_Const512Traits    |           |           |  1551.242 |
| YShuffleG4X2Benchmark_SByte | SumBase               |  1388.692 |  1936.440 |  1950.010 |
| YShuffleG4X2Benchmark_SByte | SumX1Traits           | 45275.217 | 48093.272 | 53824.371 |
| YShuffleG4X2Benchmark_SByte | SumTraits             | 50639.522 | 53953.917 | 54129.662 |
| YShuffleG4X2Benchmark_SByte | SumTraits_Tuple       | 23575.785 | 23469.345 | 54138.762 |
| YShuffleG4X2Benchmark_SByte | Sum128Base            |  1134.480 |  1978.018 |  1996.198 |
| YShuffleG4X2Benchmark_SByte | Sum128_AdvSimd        | 32155.494 | 34725.077 | 47766.135 |
| YShuffleG4X2Benchmark_SByte | Sum128Traits          | 50651.126 | 53935.614 | 54135.497 |
| YShuffleG4X2Benchmark_SByte | Sum128Traits_Tuple    | 23624.743 | 23476.011 | 54142.845 |
| YShuffleG4X2Benchmark_SByte | Sum256Traits          |           |           |           |
| YShuffleG4X2Benchmark_SByte | Sum_ConstTraits       | 50644.832 | 53953.044 | 54127.973 |
| YShuffleG4X2Benchmark_SByte | Sum_ConstTraits_Tuple | 23581.920 | 23478.810 | 54135.303 |
| YShuffleG4X2Benchmark_SByte | Sum_Const128Traits    | 50648.761 | 53952.223 | 54145.715 |
| YShuffleG4X2Benchmark_SByte | Sum_Const256Traits    |           |           |           |
| YShuffleG4X2Benchmark_SByte | Sum_Const512Base      |           |           |  1631.974 |
| YShuffleG4X2Benchmark_SByte | Sum_Const512Traits    |           |           |  1552.746 |

### Arm - AWS Arm t4g.small
| Type                        | Method                | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :-------------------------- | :-------------------- | ------------: | --------: | --------: | --------: | --------: |
| YShuffleG4X2Benchmark_Int16 | SumBase               |       388.572 |   387.764 |   387.454 |   514.192 |   499.889 |
| YShuffleG4X2Benchmark_Int16 | SumX1Traits           |       388.802 |  5935.688 |  8218.359 |  8868.754 | 10959.278 |
| YShuffleG4X2Benchmark_Int16 | SumTraits             |       388.963 |  7144.903 |  8740.520 | 10564.249 | 12289.034 |
| YShuffleG4X2Benchmark_Int16 | SumTraits_Tuple       |       355.816 |  2154.287 |  2954.695 |  2872.239 | 12295.928 |
| YShuffleG4X2Benchmark_Int16 | Sum128Base            |       245.618 |           |   245.204 |   323.392 |   324.487 |
| YShuffleG4X2Benchmark_Int16 | Sum128_AdvSimd        |               |  3681.616 |  5417.959 |  5775.797 |  6926.310 |
| YShuffleG4X2Benchmark_Int16 | Sum128Traits          |       245.409 |  7137.978 |  9020.751 | 10551.366 | 12291.394 |
| YShuffleG4X2Benchmark_Int16 | Sum128Traits_Tuple    |       228.697 |           |  2952.599 |  2855.831 | 12300.414 |
| YShuffleG4X2Benchmark_Int16 | Sum256Traits          |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int16 | Sum_ConstTraits       |       376.898 |  7162.871 |  8751.098 |  9933.533 | 12295.206 |
| YShuffleG4X2Benchmark_Int16 | Sum_ConstTraits_Tuple |       344.906 |  2152.246 |  2842.910 |  2844.992 | 12291.962 |
| YShuffleG4X2Benchmark_Int16 | Sum_Const128Traits    |       238.738 |  7168.684 |  8687.564 |  9935.026 | 12301.023 |
| YShuffleG4X2Benchmark_Int16 | Sum_Const256Traits    |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int16 | Sum_Const512Base      |               |           |           |           |   516.232 |
| YShuffleG4X2Benchmark_Int16 | Sum_Const512Traits    |               |           |           |           |   521.424 |
| YShuffleG4X2Benchmark_Int32 | SumBase               |       385.425 |   381.151 |   382.970 |   395.455 |   408.281 |
| YShuffleG4X2Benchmark_Int32 | SumX1Traits           |       384.757 |  3536.042 |  4006.673 |  4243.097 |  5390.197 |
| YShuffleG4X2Benchmark_Int32 | SumTraits             |       386.245 |  3879.751 |  4325.246 |  5162.812 |  6040.819 |
| YShuffleG4X2Benchmark_Int32 | SumTraits_Tuple       |       302.025 |  1379.956 |  1370.696 |  1440.568 |  6054.474 |
| YShuffleG4X2Benchmark_Int32 | Sum128Base            |       184.142 |           |   189.719 |   161.180 |   161.462 |
| YShuffleG4X2Benchmark_Int32 | Sum128_AdvSimd        |               |  2224.736 |  2700.939 |  2839.176 |  3456.390 |
| YShuffleG4X2Benchmark_Int32 | Sum128Traits          |       183.913 |  3875.407 |  4344.588 |  5178.832 |  6041.822 |
| YShuffleG4X2Benchmark_Int32 | Sum128Traits_Tuple    |       164.708 |           |  1370.193 |  1455.882 |  6043.611 |
| YShuffleG4X2Benchmark_Int32 | Sum256_AvxByte        |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum256Traits          |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum_ConstTraits       |       399.729 |  3879.192 |  4339.523 |  4893.442 |  6059.206 |
| YShuffleG4X2Benchmark_Int32 | Sum_ConstTraits_Tuple |       311.570 |  1170.146 |  1371.375 |  1444.626 |  6063.987 |
| YShuffleG4X2Benchmark_Int32 | Sum_Const128Traits    |       183.625 |  3878.295 |  4357.983 |  4894.059 |  6052.588 |
| YShuffleG4X2Benchmark_Int32 | Sum_Const256Traits    |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum_Const512Base      |               |           |           |           |   549.540 |
| YShuffleG4X2Benchmark_Int32 | Sum_Const512Traits    |               |           |           |           |   571.969 |
| YShuffleG4X2Benchmark_Int64 | SumBase               |       326.921 |   338.750 |   340.240 |   433.911 |   599.349 |
| YShuffleG4X2Benchmark_Int64 | SumX1Traits           |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int64 | SumTraits             |       326.327 |  1209.464 |  1535.823 |  1649.868 |  1891.549 |
| YShuffleG4X2Benchmark_Int64 | SumTraits_Tuple       |       267.943 |   429.520 |   629.843 |   748.853 |  1891.635 |
| YShuffleG4X2Benchmark_Int64 | Sum128Base            |       224.117 |           |   228.689 |   471.974 |   479.340 |
| YShuffleG4X2Benchmark_Int64 | Sum128_AdvSimd        |               |   536.945 |   646.288 |   697.292 |   752.081 |
| YShuffleG4X2Benchmark_Int64 | Sum128Traits          |       224.481 |  1209.861 |  1500.433 |  1649.320 |  1895.580 |
| YShuffleG4X2Benchmark_Int64 | Sum128Traits_Tuple    |       177.525 |           |   629.945 |   733.392 |  1890.259 |
| YShuffleG4X2Benchmark_Int64 | Sum256Traits          |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int64 | Sum_ConstTraits       |       318.860 |  1206.914 |  1493.044 |  1650.172 |  1888.801 |
| YShuffleG4X2Benchmark_Int64 | Sum_ConstTraits_Tuple |       266.385 |   430.271 |   631.521 |   735.695 |  1887.523 |
| YShuffleG4X2Benchmark_Int64 | Sum_Const128Traits    |       223.903 |  1205.197 |  1492.042 |  1649.360 |  1890.652 |
| YShuffleG4X2Benchmark_Int64 | Sum_Const256Traits    |               |           |           |           |           |
| YShuffleG4X2Benchmark_Int64 | Sum_Const512Base      |               |           |           |           |   506.096 |
| YShuffleG4X2Benchmark_Int64 | Sum_Const512Traits    |               |           |           |           |   563.436 |
| YShuffleG4X2Benchmark_SByte | SumBase               |       464.075 |   463.651 |   462.850 |   636.873 |   613.894 |
| YShuffleG4X2Benchmark_SByte | SumX1Traits           |       463.459 | 14034.527 | 16368.976 | 17226.361 | 15410.569 |
| YShuffleG4X2Benchmark_SByte | SumTraits             |       463.894 | 15515.454 | 18019.755 | 21023.719 | 19338.464 |
| YShuffleG4X2Benchmark_SByte | SumTraits_Tuple       |       437.336 |  4819.098 |  5629.911 |  6122.320 | 19323.959 |
| YShuffleG4X2Benchmark_SByte | Sum128Base            |       310.842 |           |   309.723 |   645.069 |   612.553 |
| YShuffleG4X2Benchmark_SByte | Sum128_AdvSimd        |               |  8866.246 | 10805.820 | 11412.385 | 11706.856 |
| YShuffleG4X2Benchmark_SByte | Sum128Traits          |       310.871 | 15483.485 | 18003.254 | 20996.548 | 19329.970 |
| YShuffleG4X2Benchmark_SByte | Sum128Traits_Tuple    |       296.882 |           |  5742.993 |  5996.400 | 19318.673 |
| YShuffleG4X2Benchmark_SByte | Sum256Traits          |               |           |           |           |           |
| YShuffleG4X2Benchmark_SByte | Sum_ConstTraits       |       447.156 | 15552.141 | 17437.562 | 19790.198 | 19332.312 |
| YShuffleG4X2Benchmark_SByte | Sum_ConstTraits_Tuple |       422.221 |  4710.493 |  5486.175 |  6117.678 | 19333.869 |
| YShuffleG4X2Benchmark_SByte | Sum_Const128Traits    |       304.099 | 15509.914 | 17482.560 | 19784.806 | 19341.469 |
| YShuffleG4X2Benchmark_SByte | Sum_Const256Traits    |               |           |           |           |           |
| YShuffleG4X2Benchmark_SByte | Sum_Const512Base      |               |           |           |           |   633.766 |
| YShuffleG4X2Benchmark_SByte | Sum_Const512Traits    |               |           |           |           |   641.145 |

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                        | Method                | .NET 8.0 |
| :-------------------------- | :-------------------- | -------: |
| YShuffleG4X2Benchmark_Int16 | SumBase               |   11.347 |
| YShuffleG4X2Benchmark_Int16 | SumX1Traits           |   95.861 |
| YShuffleG4X2Benchmark_Int16 | SumTraits             |  110.570 |
| YShuffleG4X2Benchmark_Int16 | SumTraits_Tuple       |   64.915 |
| YShuffleG4X2Benchmark_Int16 | Sum128Base            |   74.776 |
| YShuffleG4X2Benchmark_Int16 | Sum128_AdvSimd        |          |
| YShuffleG4X2Benchmark_Int16 | Sum128Traits          |  140.876 |
| YShuffleG4X2Benchmark_Int16 | Sum128Traits_Tuple    |   73.183 |
| YShuffleG4X2Benchmark_Int16 | Sum256Traits          |          |
| YShuffleG4X2Benchmark_Int16 | Sum_ConstTraits       |  107.638 |
| YShuffleG4X2Benchmark_Int16 | Sum_ConstTraits_Tuple |   67.351 |
| YShuffleG4X2Benchmark_Int16 | Sum_Const128Traits    |  130.834 |
| YShuffleG4X2Benchmark_Int16 | Sum_Const256Traits    |          |
| YShuffleG4X2Benchmark_Int16 | Sum_Const512Base      |   11.214 |
| YShuffleG4X2Benchmark_Int16 | Sum_Const512Traits    |   10.701 |
| YShuffleG4X2Benchmark_Int32 | SumBase               |    9.920 |
| YShuffleG4X2Benchmark_Int32 | SumX1Traits           |   48.634 |
| YShuffleG4X2Benchmark_Int32 | SumTraits             |   56.136 |
| YShuffleG4X2Benchmark_Int32 | SumTraits_Tuple       |   32.351 |
| YShuffleG4X2Benchmark_Int32 | Sum128Base            |   37.869 |
| YShuffleG4X2Benchmark_Int32 | Sum128_AdvSimd        |          |
| YShuffleG4X2Benchmark_Int32 | Sum128Traits          |   68.246 |
| YShuffleG4X2Benchmark_Int32 | Sum128Traits_Tuple    |   23.881 |
| YShuffleG4X2Benchmark_Int32 | Sum256_AvxByte        |          |
| YShuffleG4X2Benchmark_Int32 | Sum256Traits          |          |
| YShuffleG4X2Benchmark_Int32 | Sum_ConstTraits       |   51.527 |
| YShuffleG4X2Benchmark_Int32 | Sum_ConstTraits_Tuple |   31.663 |
| YShuffleG4X2Benchmark_Int32 | Sum_Const128Traits    |   62.570 |
| YShuffleG4X2Benchmark_Int32 | Sum_Const256Traits    |          |
| YShuffleG4X2Benchmark_Int32 | Sum_Const512Base      |    7.497 |
| YShuffleG4X2Benchmark_Int32 | Sum_Const512Traits    |    7.589 |
| YShuffleG4X2Benchmark_Int64 | SumBase               |    4.035 |
| YShuffleG4X2Benchmark_Int64 | SumX1Traits           |          |
| YShuffleG4X2Benchmark_Int64 | SumTraits             |    6.481 |
| YShuffleG4X2Benchmark_Int64 | SumTraits_Tuple       |    5.587 |
| YShuffleG4X2Benchmark_Int64 | Sum128Base            |    2.806 |
| YShuffleG4X2Benchmark_Int64 | Sum128_AdvSimd        |          |
| YShuffleG4X2Benchmark_Int64 | Sum128Traits          |   15.447 |
| YShuffleG4X2Benchmark_Int64 | Sum128Traits_Tuple    |    8.687 |
| YShuffleG4X2Benchmark_Int64 | Sum256Traits          |          |
| YShuffleG4X2Benchmark_Int64 | Sum_ConstTraits       |    6.234 |
| YShuffleG4X2Benchmark_Int64 | Sum_ConstTraits_Tuple |    5.835 |
| YShuffleG4X2Benchmark_Int64 | Sum_Const128Traits    |   17.012 |
| YShuffleG4X2Benchmark_Int64 | Sum_Const256Traits    |          |
| YShuffleG4X2Benchmark_Int64 | Sum_Const512Base      |    2.854 |
| YShuffleG4X2Benchmark_Int64 | Sum_Const512Traits    |    5.404 |
| YShuffleG4X2Benchmark_SByte | SumBase               |   13.619 |
| YShuffleG4X2Benchmark_SByte | SumX1Traits           |  186.621 |
| YShuffleG4X2Benchmark_SByte | SumTraits             |  211.478 |
| YShuffleG4X2Benchmark_SByte | SumTraits_Tuple       |  130.325 |
| YShuffleG4X2Benchmark_SByte | Sum128Base            |  144.144 |
| YShuffleG4X2Benchmark_SByte | Sum128_AdvSimd        |          |
| YShuffleG4X2Benchmark_SByte | Sum128Traits          |  260.921 |
| YShuffleG4X2Benchmark_SByte | Sum128Traits_Tuple    |  104.618 |
| YShuffleG4X2Benchmark_SByte | Sum256Traits          |          |
| YShuffleG4X2Benchmark_SByte | Sum_ConstTraits       |  207.468 |
| YShuffleG4X2Benchmark_SByte | Sum_ConstTraits_Tuple |  123.604 |
| YShuffleG4X2Benchmark_SByte | Sum_Const128Traits    |  249.847 |
| YShuffleG4X2Benchmark_SByte | Sum_Const256Traits    |          |
| YShuffleG4X2Benchmark_SByte | Sum_Const512Base      |   13.422 |
| YShuffleG4X2Benchmark_SByte | Sum_Const512Traits    |   13.205 |

