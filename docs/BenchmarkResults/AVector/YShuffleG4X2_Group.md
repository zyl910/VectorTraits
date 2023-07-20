# Benchmark group - YShuffleG4X2
([← Back](YShuffleG4X2.md))

Cell unit: Million operations per second.

### x86 - lntel Core i5-8250U
| Class                       | Method                | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :-------------------------- | :-------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| YShuffleG4X2Benchmark_Int16 | SumBase               |        598.622 |       600.764 |       599.622 |   603.825 |   590.206 |   725.603 |
| YShuffleG4X2Benchmark_Int16 | SumX1Traits           |        601.118 |       595.294 |     12588.475 | 12805.003 | 17166.723 | 16983.903 |
| YShuffleG4X2Benchmark_Int16 | SumTraits             |        597.787 |       593.902 |     16864.059 | 17980.674 | 20013.165 | 21619.405 |
| YShuffleG4X2Benchmark_Int16 | SumTraits_Tuple       |        563.073 |       553.844 |     16776.692 | 17358.103 | 20144.691 | 22562.252 |
| YShuffleG4X2Benchmark_Int16 | Sum128_AdvSimd        |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int16 | Sum128Traits          |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int16 | Sum256Traits          |                |               |     16784.741 | 17009.850 | 20573.701 | 24249.953 |
| YShuffleG4X2Benchmark_Int16 | Sum_ConstTraits       |        604.323 |       596.436 |     20918.753 | 19822.708 | 19981.068 | 20937.951 |
| YShuffleG4X2Benchmark_Int16 | Sum_ConstTraits_Tuple |        566.567 |       559.738 |     21444.864 | 20965.262 | 20005.779 | 20391.096 |
| YShuffleG4X2Benchmark_Int16 | Sum_Const128Traits    |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int16 | Sum_Const256Traits    |                |               |     21156.872 | 21044.723 | 19832.426 | 16328.016 |
| YShuffleG4X2Benchmark_Int32 | SumBase               |        504.801 |       504.900 |       504.872 |   507.037 |   497.857 |   584.681 |
| YShuffleG4X2Benchmark_Int32 | SumX1Traits           |        504.960 |       495.138 |      6360.544 |  6438.974 |  8502.129 |  9077.804 |
| YShuffleG4X2Benchmark_Int32 | SumTraits             |        504.767 |       495.016 |      9337.349 |  9034.602 | 10443.459 | 10986.285 |
| YShuffleG4X2Benchmark_Int32 | SumTraits_Tuple       |        451.302 |       444.195 |      8839.844 |  8046.743 | 10706.530 | 11395.046 |
| YShuffleG4X2Benchmark_Int32 | Sum128_AdvSimd        |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum128Traits          |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum256_AvxByte        |                |               |      6282.844 |  6259.861 |  8260.669 |  9108.298 |
| YShuffleG4X2Benchmark_Int32 | Sum256Traits          |                |               |      7803.562 |  9008.328 |  9764.434 | 12293.576 |
| YShuffleG4X2Benchmark_Int32 | Sum_ConstTraits       |        506.715 |       498.259 |     11030.670 | 12447.734 | 12566.053 |  8646.701 |
| YShuffleG4X2Benchmark_Int32 | Sum_ConstTraits_Tuple |        455.235 |       448.647 |     11467.016 | 12603.177 | 12620.513 | 12828.163 |
| YShuffleG4X2Benchmark_Int32 | Sum_Const128Traits    |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum_Const256Traits    |                |               |     12506.535 | 10944.443 | 12569.862 | 12269.347 |
| YShuffleG4X2Benchmark_Int64 | SumBase               |        559.908 |       512.187 |       512.581 |   563.594 |   565.039 |   448.076 |
| YShuffleG4X2Benchmark_Int64 | SumX1Traits           |        565.259 |       551.156 |      2963.617 |  3127.037 |  4085.429 |  4096.083 |
| YShuffleG4X2Benchmark_Int64 | SumTraits             |        544.844 |       545.123 |      4059.038 |  4321.786 |  4802.722 |  5266.053 |
| YShuffleG4X2Benchmark_Int64 | SumTraits_Tuple       |        443.695 |       417.216 |      3897.947 |  4346.219 |  4593.745 |  5399.786 |
| YShuffleG4X2Benchmark_Int64 | Sum128_AdvSimd        |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int64 | Sum128Traits          |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int64 | Sum256Traits          |                |               |      3654.396 |  4605.398 |  4169.457 |  5396.537 |
| YShuffleG4X2Benchmark_Int64 | Sum_ConstTraits       |        602.748 |       551.388 |      5210.073 |  5890.333 |  5990.971 |  5896.398 |
| YShuffleG4X2Benchmark_Int64 | Sum_ConstTraits_Tuple |        470.465 |       440.190 |      5991.802 |  5561.813 |  5081.794 |  5186.605 |
| YShuffleG4X2Benchmark_Int64 | Sum_Const128Traits    |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_Int64 | Sum_Const256Traits    |                |               |      5489.517 |  5954.416 |  5882.707 |  5851.555 |
| YShuffleG4X2Benchmark_SByte | SumBase               |        665.636 |       665.187 |       654.546 |   601.172 |   663.618 |   792.719 |
| YShuffleG4X2Benchmark_SByte | SumX1Traits           |        664.770 |       661.314 |     26371.898 | 26636.607 | 38878.061 | 49063.776 |
| YShuffleG4X2Benchmark_SByte | SumTraits             |        623.510 |       662.155 |     36551.741 | 39103.682 | 52453.713 | 57334.593 |
| YShuffleG4X2Benchmark_SByte | SumTraits_Tuple       |        639.516 |       636.774 |     36518.622 | 41296.723 | 53516.263 | 57573.095 |
| YShuffleG4X2Benchmark_SByte | Sum128_AdvSimd        |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_SByte | Sum128Traits          |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_SByte | Sum256Traits          |                |               |     36451.980 | 39584.332 | 52495.306 | 55743.618 |
| YShuffleG4X2Benchmark_SByte | Sum_ConstTraits       |        666.395 |       662.963 |     37782.714 | 39166.800 | 51706.781 | 56283.041 |
| YShuffleG4X2Benchmark_SByte | Sum_ConstTraits_Tuple |        642.796 |       637.600 |     37009.229 | 38813.429 | 52140.221 | 53676.071 |
| YShuffleG4X2Benchmark_SByte | Sum_Const128Traits    |                |               |               |           |           |           |
| YShuffleG4X2Benchmark_SByte | Sum_Const256Traits    |                |               |     35796.960 | 39019.174 | 51744.542 | 55397.453 |

### Arm - AWS Arm t4g.small
| Class                       | Method                | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :-------------------------- | :-------------------- | ------------: | --------: | --------: | --------: |
| YShuffleG4X2Benchmark_Int16 | SumBase               |       385.376 |   373.934 |   388.414 |   515.068 |
| YShuffleG4X2Benchmark_Int16 | SumX1Traits           |       383.403 |  6186.546 |  7779.923 |  8771.372 |
| YShuffleG4X2Benchmark_Int16 | SumTraits             |       386.124 |  7356.283 |  8527.872 | 10450.586 |
| YShuffleG4X2Benchmark_Int16 | SumTraits_Tuple       |       353.956 |  2148.815 |  2948.397 |  2978.661 |
| YShuffleG4X2Benchmark_Int16 | Sum128_AdvSimd        |               |  4255.694 |  5378.270 |  5753.145 |
| YShuffleG4X2Benchmark_Int16 | Sum128Traits          |       245.595 |  7353.196 |  8405.720 | 10395.658 |
| YShuffleG4X2Benchmark_Int16 | Sum256Traits          |               |           |           |           |
| YShuffleG4X2Benchmark_Int16 | Sum_ConstTraits       |       374.285 |  7250.859 |  8614.552 |  9857.966 |
| YShuffleG4X2Benchmark_Int16 | Sum_ConstTraits_Tuple |       343.385 |  2172.532 |  2867.906 |  2823.285 |
| YShuffleG4X2Benchmark_Int16 | Sum_Const128Traits    |       240.830 |  7308.348 |  8665.824 |  9840.875 |
| YShuffleG4X2Benchmark_Int16 | Sum_Const256Traits    |               |           |           |           |
| YShuffleG4X2Benchmark_Int32 | SumBase               |       373.529 |   372.829 |   382.580 |   395.658 |
| YShuffleG4X2Benchmark_Int32 | SumX1Traits           |       372.733 |  2989.791 |  3868.854 |  3826.650 |
| YShuffleG4X2Benchmark_Int32 | SumTraits             |       370.960 |  3450.650 |  4171.416 |  4925.019 |
| YShuffleG4X2Benchmark_Int32 | SumTraits_Tuple       |       282.903 |   916.722 |  1371.774 |  1441.584 |
| YShuffleG4X2Benchmark_Int32 | Sum128_AdvSimd        |               |  1837.160 |  2703.353 |  2339.920 |
| YShuffleG4X2Benchmark_Int32 | Sum128Traits          |       179.055 |  3460.151 |  4285.667 |  4932.728 |
| YShuffleG4X2Benchmark_Int32 | Sum256_AvxByte        |               |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum256Traits          |               |           |           |           |
| YShuffleG4X2Benchmark_Int32 | Sum_ConstTraits       |       383.264 |  3417.902 |  4287.246 |  4780.630 |
| YShuffleG4X2Benchmark_Int32 | Sum_ConstTraits_Tuple |       289.359 |   939.748 |  1397.755 |  1436.382 |
| YShuffleG4X2Benchmark_Int32 | Sum_Const128Traits    |       179.226 |  3444.252 |  4304.607 |  4789.040 |
| YShuffleG4X2Benchmark_Int32 | Sum_Const256Traits    |               |           |           |           |
| YShuffleG4X2Benchmark_Int64 | SumBase               |       314.556 |   325.387 |   341.365 |   427.220 |
| YShuffleG4X2Benchmark_Int64 | SumX1Traits           |               |           |           |           |
| YShuffleG4X2Benchmark_Int64 | SumTraits             |       314.378 |  1282.010 |  1534.814 |  1632.983 |
| YShuffleG4X2Benchmark_Int64 | SumTraits_Tuple       |       254.477 |   407.981 |   637.898 |   710.049 |
| YShuffleG4X2Benchmark_Int64 | Sum128_AdvSimd        |               |   567.537 |   636.298 |   698.452 |
| YShuffleG4X2Benchmark_Int64 | Sum128Traits          |       203.521 |  1283.091 |  1535.271 |  1628.026 |
| YShuffleG4X2Benchmark_Int64 | Sum256Traits          |               |           |           |           |
| YShuffleG4X2Benchmark_Int64 | Sum_ConstTraits       |       308.033 |  1251.562 |  1495.562 |  1632.008 |
| YShuffleG4X2Benchmark_Int64 | Sum_ConstTraits_Tuple |       251.261 |   424.651 |   630.406 |   712.523 |
| YShuffleG4X2Benchmark_Int64 | Sum_Const128Traits    |       205.591 |  1263.806 |  1494.354 |  1632.956 |
| YShuffleG4X2Benchmark_Int64 | Sum_Const256Traits    |               |           |           |           |
| YShuffleG4X2Benchmark_SByte | SumBase               |       459.674 |   449.035 |   463.775 |   637.579 |
| YShuffleG4X2Benchmark_SByte | SumX1Traits           |       462.776 | 13601.501 | 15681.305 | 17532.266 |
| YShuffleG4X2Benchmark_SByte | SumTraits             |       459.260 | 14920.057 | 17379.516 | 20981.283 |
| YShuffleG4X2Benchmark_SByte | SumTraits_Tuple       |       351.433 |  4635.947 |  5680.080 |  5851.797 |
| YShuffleG4X2Benchmark_SByte | Sum128_AdvSimd        |               |  8641.067 | 10861.045 | 11388.153 |
| YShuffleG4X2Benchmark_SByte | Sum128Traits          |       256.715 | 14839.860 | 17383.487 | 21032.805 |
| YShuffleG4X2Benchmark_SByte | Sum256Traits          |               |           |           |           |
| YShuffleG4X2Benchmark_SByte | Sum_ConstTraits       |       360.042 | 15070.183 | 17023.556 | 19757.971 |
| YShuffleG4X2Benchmark_SByte | Sum_ConstTraits_Tuple |       340.521 |  4588.918 |  5664.273 |  5951.434 |
| YShuffleG4X2Benchmark_SByte | Sum_Const128Traits    |       253.771 | 15047.050 | 17496.875 | 19735.324 |
| YShuffleG4X2Benchmark_SByte | Sum_Const256Traits    |               |           |           |           |
