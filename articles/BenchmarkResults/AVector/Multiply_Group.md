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
| MultiplyBenchmark_Double | SumScalar    |       763.424 |   765.126 |   762.525 |  1100.924 |
| MultiplyBenchmark_Double | SumBcl       |      3769.904 |  3253.392 |  3201.917 |  3652.778 |
| MultiplyBenchmark_Double | SumTraits    |      3806.349 |  3227.962 |  3768.831 |  3653.950 |
| MultiplyBenchmark_Double | Sum128Traits |       449.636 |  3230.078 |  3203.410 |  3623.218 |
| MultiplyBenchmark_Double | Sum256Traits |       235.686 |   410.739 |   409.779 |   394.973 |
| MultiplyBenchmark_Int16  | SumScalar    |       650.967 |   650.659 |   646.584 |  1015.690 |
| MultiplyBenchmark_Int16  | SumBcl       |     13395.429 | 12814.704 | 13010.650 | 19214.383 |
| MultiplyBenchmark_Int16  | SumTraits    |     13609.858 | 12886.613 | 12983.912 | 19253.515 |
| MultiplyBenchmark_Int16  | Sum128Traits |       585.626 | 13678.358 | 12340.626 | 19176.694 |
| MultiplyBenchmark_Int16  | Sum256Traits |       589.264 |   851.857 |   845.898 |   591.788 |
| MultiplyBenchmark_Int32  | SumScalar    |       688.391 |   721.714 |   715.545 |  1419.733 |
| MultiplyBenchmark_Int32  | SumBcl       |      6565.727 |  6608.494 |  6037.449 |  8986.036 |
| MultiplyBenchmark_Int32  | SumTraits    |      6364.683 |  6607.748 |  6155.759 |  8978.525 |
| MultiplyBenchmark_Int32  | Sum128Traits |       339.975 |  6112.944 |  6567.627 |  8954.145 |
| MultiplyBenchmark_Int32  | Sum256Traits |       329.987 |   541.961 |   543.579 |   470.232 |
| MultiplyBenchmark_SByte  | SumScalar    |       777.445 |   777.156 |   776.886 |  1187.012 |
| MultiplyBenchmark_SByte  | SumBcl       |     27119.892 | 26651.910 | 26906.960 | 38043.797 |
| MultiplyBenchmark_SByte  | SumBcl_Widen |     11106.958 | 11962.671 | 12210.182 | 12057.679 |
| MultiplyBenchmark_SByte  | SumTraits    |     27203.765 | 26850.495 | 26791.171 | 37941.684 |
| MultiplyBenchmark_SByte  | Sum128Traits |       960.109 | 27075.211 | 26910.153 | 38049.350 |
| MultiplyBenchmark_SByte  | Sum256Traits |       884.172 |  1148.026 |  1142.988 |   670.033 |
| MultiplyBenchmark_Single | SumScalar    |       828.997 |   796.491 |   822.230 |  1240.081 |
| MultiplyBenchmark_Single | SumBcl       |      6703.180 |  6620.271 |  6141.246 |  8710.630 |
| MultiplyBenchmark_Single | SumTraits    |      6691.137 |  6618.630 |  6055.760 |  8734.266 |
| MultiplyBenchmark_Single | Sum128Traits |       350.108 |  6203.850 |  6140.715 |  8738.129 |
| MultiplyBenchmark_Single | Sum256Traits |       348.418 |   533.322 |   536.625 |   525.109 |
| MultiplyBenchmark_UInt32 | SumScalar    |       721.626 |   721.147 |   718.689 |  1416.517 |
| MultiplyBenchmark_UInt32 | SumBcl       |      7593.352 |  7472.558 |  6321.318 |  7003.693 |
| MultiplyBenchmark_UInt32 | SumTraits    |      7547.509 |  7537.725 |  6350.618 |  6978.629 |
| MultiplyBenchmark_UInt32 | Sum128Traits |       365.389 |  6438.068 |  7380.094 |  6992.844 |
| MultiplyBenchmark_UInt32 | Sum256Traits |       350.112 |   544.569 |   549.147 |   475.413 |
| MultiplyBenchmark_UInt64 | SumScalar    |       675.728 |   672.437 |   670.910 |  1104.627 |
| MultiplyBenchmark_UInt64 | SumBcl       |       400.626 |   712.119 |   985.607 |  1112.959 |
| MultiplyBenchmark_UInt64 | SumTraits    |       399.893 |  1134.591 |  1109.327 |  1112.067 |
| MultiplyBenchmark_UInt64 | Sum128Traits |       451.470 |  1134.643 |  1109.502 |  1113.227 |
| MultiplyBenchmark_UInt64 | Sum256Traits |       227.943 |   393.032 |   389.955 |   388.740 |
| MultiplyBenchmark_UInt64 | Sum256Avx    |               |           |           |           |

