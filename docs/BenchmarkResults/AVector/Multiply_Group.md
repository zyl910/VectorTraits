# Benchmark group - Multiply
([← Back](Multiply.md))

Cell unit: Million operations per second.

### x86 - lntel Core i5-8250U
| Class                    | Method       | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :----------------------- | :----------- | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| MultiplyBenchmark_Double | SumScalar    |       1600.703 |      1632.773 |      1611.595 |  1642.460 |  1249.202 |  1358.019 |
| MultiplyBenchmark_Double | SumBcl       |       6284.448 |      6189.051 |      6102.798 |  6587.568 |  5658.033 |  5055.220 |
| MultiplyBenchmark_Double | SumTraits    |       6506.623 |      6418.409 |      5944.404 |  6428.924 |  5751.874 |  5190.834 |
| MultiplyBenchmark_Double | Sum128Traits |                |               |       303.183 |   312.253 |   273.994 |  2785.739 |
| MultiplyBenchmark_Double | Sum256Traits |                |               |      6393.648 |  6311.429 |  4104.283 |  5219.449 |
| MultiplyBenchmark_Int16  | SumScalar    |       1680.612 |      1658.796 |      1683.030 |  1685.798 |  1190.349 |  1553.884 |
| MultiplyBenchmark_Int16  | SumBcl       |      28756.603 |     27777.105 |     28163.609 | 26379.883 | 22013.923 | 23065.311 |
| MultiplyBenchmark_Int16  | SumTraits    |      28711.354 |     25955.926 |     26610.600 | 26887.192 | 21145.370 | 22954.619 |
| MultiplyBenchmark_Int16  | Sum128Traits |                |               |       924.668 |   945.675 |   802.024 | 17144.676 |
| MultiplyBenchmark_Int16  | Sum256Traits |                |               |     26530.655 | 28363.814 | 17782.887 | 21967.326 |
| MultiplyBenchmark_Int32  | SumScalar    |       2014.740 |      1967.770 |      2005.266 |  1976.627 |  1290.147 |  1907.866 |
| MultiplyBenchmark_Int32  | SumBcl       |      12475.013 |     12445.946 |     10239.998 | 12688.560 | 10083.688 | 11056.881 |
| MultiplyBenchmark_Int32  | SumTraits    |      12495.143 |     12543.215 |     11114.444 | 12563.478 | 10617.979 | 10782.628 |
| MultiplyBenchmark_Int32  | Sum128Traits |                |               |       546.456 |   604.466 |   558.445 |  8168.977 |
| MultiplyBenchmark_Int32  | Sum256Traits |                |               |     13236.167 | 13873.089 | 10588.721 | 10500.568 |
| MultiplyBenchmark_SByte  | SumScalar    |       1680.166 |      1654.827 |      1673.627 |  1534.960 |  1522.136 |  1567.444 |
| MultiplyBenchmark_SByte  | SumBcl       |       1104.475 |      1287.646 |      1250.073 |  1763.937 |  1818.500 |  1716.780 |
| MultiplyBenchmark_SByte  | SumBcl_Widen |        815.634 |       978.797 |       997.840 |  1353.751 | 15397.095 | 24364.160 |
| MultiplyBenchmark_SByte  | SumTraits    |       1100.749 |      1298.894 |     25183.529 | 23727.417 | 20322.526 | 25706.158 |
| MultiplyBenchmark_SByte  | Sum128Traits |                |               |      1391.794 |  1416.877 |  1206.028 |  1685.228 |
| MultiplyBenchmark_SByte  | Sum256Traits |                |               |     24984.055 | 24408.616 | 19330.612 | 25643.622 |
| MultiplyBenchmark_Single | SumScalar    |       1675.948 |      1677.392 |      1669.507 |  1652.659 |  1352.087 |  1681.432 |
| MultiplyBenchmark_Single | SumBcl       |      13204.865 |     13118.285 |     12646.910 | 12720.198 | 10365.531 | 13337.825 |
| MultiplyBenchmark_Single | SumTraits    |      13250.074 |     12086.453 |     12041.076 | 12375.944 | 10273.737 | 13248.124 |
| MultiplyBenchmark_Single | Sum128Traits |                |               |       557.266 |   571.178 |   510.928 |  6709.234 |
| MultiplyBenchmark_Single | Sum256Traits |                |               |     12790.191 | 12742.796 |  9566.985 | 13156.266 |
| MultiplyBenchmark_UInt32 | SumScalar    |       1997.307 |      1995.796 |      2009.839 |  2007.057 |  1452.694 |  2181.241 |
| MultiplyBenchmark_UInt32 | SumBcl       |        584.143 |       768.549 |       819.057 |  1128.172 | 10337.032 | 12342.446 |
| MultiplyBenchmark_UInt32 | SumTraits    |      13909.507 |     12848.825 |     12920.682 | 12450.954 | 10552.328 | 12985.813 |
| MultiplyBenchmark_UInt32 | Sum128Traits |                |               |       546.982 |   609.023 |   552.168 |  9260.718 |
| MultiplyBenchmark_UInt32 | Sum256Traits |                |               |     14159.997 | 12429.423 | 10604.636 | 12952.074 |
| MultiplyBenchmark_UInt64 | SumScalar    |       1830.579 |      1774.180 |      1833.726 |  1826.332 |  1613.602 |  1946.179 |
| MultiplyBenchmark_UInt64 | SumBcl       |        324.010 |       487.569 |       507.394 |   655.983 |   878.917 |  1020.305 |
| MultiplyBenchmark_UInt64 | SumTraits    |        328.584 |       494.795 |      3510.915 |  3676.509 |  3023.884 |  3612.814 |
| MultiplyBenchmark_UInt64 | Sum128Traits |                |               |       324.052 |   333.196 |   309.637 |   646.978 |
| MultiplyBenchmark_UInt64 | Sum256Traits |                |               |      3605.952 |  3723.235 |  2944.808 |  3540.094 |
| MultiplyBenchmark_UInt64 | Sum256Avx    |                |               |      3561.889 |  2686.452 |  2873.353 |  3478.228 |

### Arm - AWS Arm t4g.small
| Class                    | Method       | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :----------------------- | :----------- | ------------: | --------: | --------: | --------: |
| MultiplyBenchmark_Double | SumScalar    |       765.649 |   766.031 |   758.644 |  1014.141 |
| MultiplyBenchmark_Double | SumBcl       |      3833.182 |  3822.467 |  3179.536 |  3657.731 |
| MultiplyBenchmark_Double | SumTraits    |      3809.391 |  3251.397 |  3174.551 |  3663.085 |
| MultiplyBenchmark_Double | Sum128Traits |       442.843 |  3801.900 |  3194.693 |  3648.868 |
| MultiplyBenchmark_Double | Sum256Traits |       235.593 |   411.723 |   402.805 |   394.456 |
| MultiplyBenchmark_Int16  | SumScalar    |       650.489 |   650.396 |   643.146 |  1017.731 |
| MultiplyBenchmark_Int16  | SumBcl       |     12744.213 | 12510.831 | 12356.476 | 19315.192 |
| MultiplyBenchmark_Int16  | SumTraits    |     12752.871 | 12530.809 | 13142.016 | 19287.033 |
| MultiplyBenchmark_Int16  | Sum128Traits |       605.086 | 13377.421 | 12233.185 | 19305.500 |
| MultiplyBenchmark_Int16  | Sum256Traits |       611.338 |   852.735 |   841.979 |   591.718 |
| MultiplyBenchmark_Int32  | SumScalar    |       719.822 |   720.207 |   715.185 |  1417.429 |
| MultiplyBenchmark_Int32  | SumBcl       |      6445.950 |  5984.031 |  6002.410 |  8699.250 |
| MultiplyBenchmark_Int32  | SumTraits    |      6107.703 |  6445.327 |  5897.187 |  8675.644 |
| MultiplyBenchmark_Int32  | Sum128Traits |       353.490 |  6128.571 |  5987.449 |  8704.930 |
| MultiplyBenchmark_Int32  | Sum256Traits |       346.551 |   548.932 |   530.130 |   472.980 |
| MultiplyBenchmark_SByte  | SumScalar    |       777.348 |   777.209 |   771.615 |  1182.606 |
| MultiplyBenchmark_SByte  | SumBcl       |     27273.217 | 27168.474 | 26008.455 | 37928.181 |
| MultiplyBenchmark_SByte  | SumBcl_Widen |     11230.083 | 12040.382 | 12071.902 | 12130.527 |
| MultiplyBenchmark_SByte  | SumTraits    |     27374.533 | 26883.131 | 26265.614 | 37845.492 |
| MultiplyBenchmark_SByte  | Sum128Traits |       943.623 | 26719.062 | 26068.893 | 38012.278 |
| MultiplyBenchmark_SByte  | Sum256Traits |       889.161 |  1152.747 |  1142.377 |   669.613 |
| MultiplyBenchmark_Single | SumScalar    |       826.930 |   795.700 |   816.759 |  1240.768 |
| MultiplyBenchmark_Single | SumBcl       |      6616.223 |  6508.489 |  6365.412 |  8544.382 |
| MultiplyBenchmark_Single | SumTraits    |      6643.543 |  6033.227 |  6395.990 |  8584.911 |
| MultiplyBenchmark_Single | Sum128Traits |       348.765 |  6448.404 |  5954.342 |  8595.274 |
| MultiplyBenchmark_Single | Sum256Traits |       348.854 |   542.797 |   521.687 |   525.989 |
| MultiplyBenchmark_UInt32 | SumScalar    |       720.362 |   721.428 |   714.216 |  1419.062 |
| MultiplyBenchmark_UInt32 | SumBcl       |      7292.554 |  7283.484 |  6303.880 |  6890.616 |
| MultiplyBenchmark_UInt32 | SumTraits    |      6288.001 |  6251.358 |  6233.388 |  6903.825 |
| MultiplyBenchmark_UInt32 | Sum128Traits |       365.371 |  7290.681 |  6294.362 |  6892.109 |
| MultiplyBenchmark_UInt32 | Sum256Traits |       344.363 |   551.620 |   538.317 |   470.323 |
| MultiplyBenchmark_UInt64 | SumScalar    |       328.914 |   673.337 |   669.157 |  1105.758 |
| MultiplyBenchmark_UInt64 | SumBcl       |       383.406 |   715.446 |   978.539 |  1114.218 |
| MultiplyBenchmark_UInt64 | SumTraits    |       383.557 |  1141.141 |  1128.562 |  1112.795 |
| MultiplyBenchmark_UInt64 | Sum128Traits |       444.587 |  1142.475 |  1133.990 |  1110.700 |
| MultiplyBenchmark_UInt64 | Sum256Traits |       228.103 |   391.860 |   387.669 |   388.850 |
| MultiplyBenchmark_UInt64 | Sum256Avx    |               |           |           |           |
