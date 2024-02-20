# Benchmark group - Multiply
([← Back](Multiply.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### X86 - Intel Core i5-8250U
| Type                     | Method       | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :----------------------- | :----------- | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| MultiplyBenchmark_Double | SumScalar    |       1078.333 |      1685.320 |      1686.605 |  1688.531 |  1686.273 |  1689.467 |
| MultiplyBenchmark_Double | SumBcl       |       5496.796 |      6375.782 |      6697.700 |  6709.435 |  6384.581 |  6683.997 |
| MultiplyBenchmark_Double | SumTraits    |       5976.484 |      6377.978 |      6434.893 |  6520.616 |  6088.732 |  6639.184 |
| MultiplyBenchmark_Double | Sum128Traits |                |               |      3372.079 |  3376.718 |  3376.243 |  3370.933 |
| MultiplyBenchmark_Double | Sum256Traits |                |               |      6658.956 |  6431.824 |  6414.044 |  6657.328 |
| MultiplyBenchmark_Int16  | SumScalar    |       1151.932 |      1696.188 |      1696.288 |  1696.311 |  1765.857 |  1794.280 |
| MultiplyBenchmark_Int16  | SumBcl       |      20179.640 |     29000.696 |     29043.061 | 28873.222 | 27398.869 | 29230.877 |
| MultiplyBenchmark_Int16  | SumTraits    |      17818.666 |     28750.917 |     28275.053 | 28439.527 | 25598.285 | 29251.442 |
| MultiplyBenchmark_Int16  | Sum128Traits |                |               |     20740.527 | 20816.183 | 19374.784 | 20615.516 |
| MultiplyBenchmark_Int16  | Sum256Traits |                |               |     26204.716 | 26333.176 | 28700.028 | 26367.850 |
| MultiplyBenchmark_Int32  | SumScalar    |       1007.995 |      2009.544 |      1844.415 |  1845.148 |  1841.810 |  2215.279 |
| MultiplyBenchmark_Int32  | SumBcl       |       7410.928 |     12478.401 |     13806.980 | 14075.634 | 14109.580 | 12734.256 |
| MultiplyBenchmark_Int32  | SumTraits    |      10281.822 |     13691.245 |     13323.108 | 13388.833 | 12934.094 | 12229.157 |
| MultiplyBenchmark_Int32  | Sum128Traits |                |               |      8006.751 |  9427.857 |  9488.132 |  9394.611 |
| MultiplyBenchmark_Int32  | Sum256Traits |                |               |     13038.919 | 11900.870 | 13337.571 | 12174.866 |
| MultiplyBenchmark_SByte  | SumScalar    |       1123.630 |      1696.184 |      1698.106 |  1696.548 |  1765.863 |  1861.121 |
| MultiplyBenchmark_SByte  | SumBcl       |        504.714 |      1305.068 |      1314.342 |  1800.039 |  1671.186 |  2018.456 |
| MultiplyBenchmark_SByte  | SumBcl_Widen |        648.898 |      1014.916 |      1010.340 |  1385.986 | 18458.271 | 26543.644 |
| MultiplyBenchmark_SByte  | SumTraits    |        867.932 |      1292.714 |     26274.061 | 25044.052 | 24981.260 | 26272.164 |
| MultiplyBenchmark_SByte  | Sum128Traits |                |               |     21075.164 | 21157.848 | 21086.235 | 21273.251 |
| MultiplyBenchmark_SByte  | Sum256Traits |                |               |     26188.394 | 25063.402 | 25069.936 | 26405.971 |
| MultiplyBenchmark_Single | SumScalar    |       1293.688 |      1687.790 |      1688.311 |  1690.624 |  1686.976 |  1690.186 |
| MultiplyBenchmark_Single | SumBcl       |       8606.660 |     13387.536 |      7644.792 | 13382.921 | 13416.503 | 13459.634 |
| MultiplyBenchmark_Single | SumTraits    |       8683.924 |     13389.862 |      7874.136 | 13355.481 | 13424.687 | 13451.617 |
| MultiplyBenchmark_Single | Sum128Traits |                |               |      5189.552 |  6724.612 |  6741.740 |  6733.767 |
| MultiplyBenchmark_Single | Sum256Traits |                |               |      9773.110 | 13409.237 | 13419.859 | 13210.186 |
| MultiplyBenchmark_UInt32 | SumScalar    |       1228.460 |      2030.551 |      1800.947 |  2018.039 |  2017.455 |  2205.257 |
| MultiplyBenchmark_UInt32 | SumBcl       |        443.986 |       795.421 |       755.735 |  1111.637 | 14261.002 | 14318.887 |
| MultiplyBenchmark_UInt32 | SumTraits    |       7907.669 |     13086.543 |     11503.740 | 14243.355 | 14269.037 | 13495.639 |
| MultiplyBenchmark_UInt32 | Sum128Traits |                |               |      8440.801 |  9868.703 |  9807.838 |  9386.747 |
| MultiplyBenchmark_UInt32 | Sum256Traits |                |               |     13322.977 | 14182.570 | 13345.427 | 13079.623 |
| MultiplyBenchmark_UInt64 | SumScalar    |       1082.378 |      1890.319 |      1883.817 |  1881.856 |  1880.042 |  1993.501 |
| MultiplyBenchmark_UInt64 | SumBcl       |        242.805 |       510.292 |       541.314 |   674.108 |   458.904 |  1118.978 |
| MultiplyBenchmark_UInt64 | SumTraits    |        248.616 |       519.729 |      3730.869 |  4037.718 |  4036.108 |  3714.492 |
| MultiplyBenchmark_UInt64 | Sum128Traits |                |               |      2575.394 |  2709.792 |  2706.554 |  2521.780 |
| MultiplyBenchmark_UInt64 | Sum256Traits |                |               |      3784.333 |  4070.240 |  4049.053 |  3753.445 |
| MultiplyBenchmark_UInt64 | Sum256Avx    |                |               |      3783.353 |  4068.084 |  4058.145 |  3738.428 |

### Arm - AWS Arm t4g.small
| Type                     | Method       | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
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

