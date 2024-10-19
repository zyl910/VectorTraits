# Benchmark group - Multiply
([← Back](Multiply.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### X86 - AMD Ryzen 7 7840H
| Type                     | Method                | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :----------------------- | :-------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| MultiplyBenchmark_Double | SumScalar             |       2084.347 |      1979.706 |      2048.738 |  2064.593 |  2044.493 |  2019.241 |  2113.784 |
| MultiplyBenchmark_Double | SumBcl                |       8790.229 |      8532.216 |      8507.251 |  8571.916 |  8554.056 |  8500.819 |  8622.142 |
| MultiplyBenchmark_Double | SumTraits             |       8738.996 |      8578.450 |      8676.601 |  8560.468 |  8696.698 |  8575.102 |  8652.830 |
| MultiplyBenchmark_Double | Sum128Bcl             |                |               |               |           |           |  4504.125 |  4478.450 |
| MultiplyBenchmark_Double | Sum128Traits          |                |               |      4491.358 |  4508.237 |  4485.126 |  4492.297 |  4497.031 |
| MultiplyBenchmark_Double | Sum256Traits          |                |               |      8475.437 |  8525.957 |  8617.617 |  8728.001 |  8598.977 |
| MultiplyBenchmark_Double | Sum512Bcl             |                |               |               |           |           |           | 10437.396 |
| MultiplyBenchmark_Double | Sum512Traits          |                |               |               |           |           |           | 10467.655 |
| MultiplyBenchmark_Int16  | SumScalar             |       1436.428 |      1414.205 |      1398.959 |  1410.849 |  1363.792 |  1517.240 |  1616.091 |
| MultiplyBenchmark_Int16  | SumBcl                |      49229.000 |     48159.841 |     45276.910 | 48341.775 | 45491.933 | 45238.397 | 48521.566 |
| MultiplyBenchmark_Int16  | SumTraits             |      49886.108 |     45298.164 |     44464.317 | 48472.610 | 45853.115 | 49392.127 | 48535.343 |
| MultiplyBenchmark_Int16  | Sum128Bcl             |                |               |               |           |           | 38432.904 | 31250.133 |
| MultiplyBenchmark_Int16  | Sum128Traits          |                |               |     34956.137 | 30102.963 | 31344.399 | 39242.141 | 31455.471 |
| MultiplyBenchmark_Int16  | Sum256Traits          |                |               |     48385.997 | 45754.232 | 45939.242 | 45836.078 | 48115.272 |
| MultiplyBenchmark_Int16  | Sum512Bcl             |                |               |               |           |           |           | 46942.778 |
| MultiplyBenchmark_Int16  | Sum512Traits          |                |               |               |           |           |           | 46411.700 |
| MultiplyBenchmark_Int32  | SumScalar             |       2052.100 |      2004.955 |      1846.355 |  1918.675 |  1985.841 |  2211.639 |  2249.109 |
| MultiplyBenchmark_Int32  | SumBcl                |      21475.554 |     21228.903 |     21640.942 | 20688.998 | 20489.198 | 22542.242 | 18728.845 |
| MultiplyBenchmark_Int32  | SumTraits             |      21945.765 |     20205.636 |     20845.153 | 21930.934 | 20037.098 | 21044.762 | 19401.954 |
| MultiplyBenchmark_Int32  | Sum128Bcl             |                |               |               |           |           | 16925.466 | 14298.194 |
| MultiplyBenchmark_Int32  | Sum128Traits          |                |               |     14737.449 | 15304.433 | 13799.853 | 16380.811 | 14596.494 |
| MultiplyBenchmark_Int32  | Sum256Traits          |                |               |     22138.039 | 21674.579 | 21281.227 | 22462.552 | 19959.909 |
| MultiplyBenchmark_Int32  | Sum512Bcl             |                |               |               |           |           |           | 19412.502 |
| MultiplyBenchmark_Int32  | Sum512Traits          |                |               |               |           |           |           | 19991.939 |
| MultiplyBenchmark_SByte  | SumScalar             |       1480.396 |      1421.116 |      1429.611 |  1388.293 |  1391.103 |  1524.669 |  1664.571 |
| MultiplyBenchmark_SByte  | SumBcl                |       1099.651 |      1059.634 |      1098.342 |  1679.916 |  1724.975 |  1603.660 |  1558.507 |
| MultiplyBenchmark_SByte  | SumBcl_Widen          |       1014.544 |      1069.619 |      1148.530 |   860.952 | 27694.023 | 40593.897 | 36716.434 |
| MultiplyBenchmark_SByte  | SumTraits             |       1054.817 |      1107.030 |     39081.266 | 38746.961 | 38349.649 | 40561.133 | 37260.247 |
| MultiplyBenchmark_SByte  | Sum128Bcl             |                |               |               |           |           |  1453.550 |  1166.182 |
| MultiplyBenchmark_SByte  | Sum128_Wasm           |                |               |               |           |           |           |           |
| MultiplyBenchmark_SByte  | Sum128_Wasm_SelfWiden |                |               |               |           |           |           |           |
| MultiplyBenchmark_SByte  | Sum128Traits          |                |               |     25758.408 | 28100.060 | 27972.529 | 28055.212 | 26274.548 |
| MultiplyBenchmark_SByte  | Sum256Traits          |                |               |     38318.001 | 37590.236 | 38508.549 | 40899.280 | 36896.208 |
| MultiplyBenchmark_SByte  | Sum512Bcl             |                |               |               |           |           |           |   448.837 |
| MultiplyBenchmark_SByte  | Sum512Traits          |                |               |               |           |           |           | 44039.380 |
| MultiplyBenchmark_Single | SumScalar             |       2022.323 |      1984.592 |      1954.791 |  2099.302 |  2062.948 |  2007.439 |  2130.849 |
| MultiplyBenchmark_Single | SumBcl                |      16945.074 |     16125.793 |     17085.462 | 17431.350 | 16291.449 | 16329.687 | 16741.570 |
| MultiplyBenchmark_Single | SumTraits             |      16548.498 |     16597.890 |     16509.202 | 16557.859 | 16920.387 | 17015.592 | 16126.971 |
| MultiplyBenchmark_Single | Sum128Bcl             |                |               |               |           |           |  8584.507 |  8729.349 |
| MultiplyBenchmark_Single | Sum128Traits          |                |               |      8707.974 |  8733.667 |  8744.379 |  8694.114 |  8714.080 |
| MultiplyBenchmark_Single | Sum256Traits          |                |               |     16934.927 | 16689.443 | 17141.593 | 15963.759 | 16803.748 |
| MultiplyBenchmark_Single | Sum512Bcl             |                |               |               |           |           |           | 19474.237 |
| MultiplyBenchmark_Single | Sum512Traits          |                |               |               |           |           |           | 19804.337 |
| MultiplyBenchmark_UInt32 | SumScalar             |       2012.833 |      1887.269 |      2006.574 |  1915.261 |  1974.200 |  2378.078 |  2271.925 |
| MultiplyBenchmark_UInt32 | SumBcl                |        716.699 |       891.558 |       949.277 |  1178.573 | 20830.128 | 19385.360 | 20400.035 |
| MultiplyBenchmark_UInt32 | SumTraits             |      22492.114 |     20910.897 |     21417.621 | 19705.406 | 19637.329 | 21046.070 | 20392.149 |
| MultiplyBenchmark_UInt32 | Sum128Bcl             |                |               |               |           |           | 13526.887 | 15970.163 |
| MultiplyBenchmark_UInt32 | Sum128Traits          |                |               |     15728.930 | 16313.589 | 15905.376 | 14365.805 | 16188.232 |
| MultiplyBenchmark_UInt32 | Sum256Traits          |                |               |     21505.580 | 20173.943 | 21247.541 | 20081.333 | 20519.506 |
| MultiplyBenchmark_UInt32 | Sum512Bcl             |                |               |               |           |           |           | 21051.391 |
| MultiplyBenchmark_UInt32 | Sum512Traits          |                |               |               |           |           |           | 21283.139 |
| MultiplyBenchmark_UInt64 | SumScalar             |       2011.850 |      1934.621 |      1910.450 |  1872.947 |  1970.863 |  2398.560 |  2193.795 |
| MultiplyBenchmark_UInt64 | SumBcl                |        383.795 |       505.552 |       565.112 |   617.343 |  1004.391 |  1040.773 |  9792.952 |
| MultiplyBenchmark_UInt64 | SumTraits             |        387.752 |       509.550 |      5476.086 |  6533.029 |  6465.510 |  6219.736 |  9672.748 |
| MultiplyBenchmark_UInt64 | Sum128Bcl             |                |               |               |           |           |   576.704 |  9087.381 |
| MultiplyBenchmark_UInt64 | Sum128Traits          |                |               |      3139.554 |  3339.697 |  3464.069 |  3393.569 |  8237.567 |
| MultiplyBenchmark_UInt64 | Sum256Traits          |                |               |      5864.241 |  6497.854 |  6863.592 |  6233.364 |  9795.437 |
| MultiplyBenchmark_UInt64 | Sum256Avx             |                |               |      5868.243 |  6383.361 |  6325.806 |  6141.416 |  9891.858 |
| MultiplyBenchmark_UInt64 | Sum512Bcl             |                |               |               |           |           |           |  9945.883 |
| MultiplyBenchmark_UInt64 | Sum512Traits          |                |               |               |           |           |           |  9809.406 |

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

### Arm - Apple M2
| Type                     | Method                |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :----------------------- | :-------------------- | --------: | --------: | --------: |
| MultiplyBenchmark_Double | SumScalar             |  2091.815 |  2270.645 |  2267.917 |
| MultiplyBenchmark_Double | SumBcl                |  4535.848 |  4544.248 |  4538.488 |
| MultiplyBenchmark_Double | SumTraits             |  4535.921 |  4543.970 |  4537.900 |
| MultiplyBenchmark_Double | Sum128Bcl             |           |  4544.303 |  4538.423 |
| MultiplyBenchmark_Double | Sum128Traits          |  4534.457 |  4544.330 |  4537.106 |
| MultiplyBenchmark_Double | Sum256Traits          |   781.942 |   879.032 |  9062.220 |
| MultiplyBenchmark_Double | Sum512Bcl             |           |           | 11492.508 |
| MultiplyBenchmark_Double | Sum512Traits          |           |           | 11493.102 |
| MultiplyBenchmark_Int16  | SumScalar             |  1870.161 |  3027.961 |  1700.665 |
| MultiplyBenchmark_Int16  | SumBcl                | 27208.103 | 27282.960 | 27249.042 |
| MultiplyBenchmark_Int16  | SumTraits             | 27206.685 | 27284.847 | 27255.887 |
| MultiplyBenchmark_Int16  | Sum128Bcl             |           | 27281.148 | 27252.921 |
| MultiplyBenchmark_Int16  | Sum128Traits          | 27204.478 | 27285.420 | 27251.396 |
| MultiplyBenchmark_Int16  | Sum256Traits          |  2164.705 |  1913.605 | 44763.658 |
| MultiplyBenchmark_Int16  | Sum512Bcl             |           |           | 44555.285 |
| MultiplyBenchmark_Int16  | Sum512Traits          |           |           | 44559.849 |
| MultiplyBenchmark_Int32  | SumScalar             |  2106.851 |  3886.801 |  4029.566 |
| MultiplyBenchmark_Int32  | SumBcl                | 13602.596 | 13618.045 | 13604.064 |
| MultiplyBenchmark_Int32  | SumTraits             | 13603.748 | 13610.844 | 13605.639 |
| MultiplyBenchmark_Int32  | Sum128Bcl             |           | 13618.309 | 13608.690 |
| MultiplyBenchmark_Int32  | Sum128Traits          | 13598.726 | 13613.365 | 13603.895 |
| MultiplyBenchmark_Int32  | Sum256Traits          |  1493.532 |  1600.820 | 22339.501 |
| MultiplyBenchmark_Int32  | Sum512Bcl             |           |           | 22320.873 |
| MultiplyBenchmark_Int32  | Sum512Traits          |           |           | 22319.746 |
| MultiplyBenchmark_SByte  | SumScalar             |  2252.259 |  2918.571 |  1701.743 |
| MultiplyBenchmark_SByte  | SumBcl                | 54281.171 | 54324.372 | 54401.328 |
| MultiplyBenchmark_SByte  | SumBcl_Widen          | 47999.189 | 48080.493 | 48084.920 |
| MultiplyBenchmark_SByte  | SumTraits             | 54229.689 | 54235.529 | 54315.897 |
| MultiplyBenchmark_SByte  | Sum128Bcl             |           | 54316.825 | 54366.940 |
| MultiplyBenchmark_SByte  | Sum128_Wasm           |           |           |           |
| MultiplyBenchmark_SByte  | Sum128_Wasm_SelfWiden |           |           |           |
| MultiplyBenchmark_SByte  | Sum128Traits          | 54256.502 | 54308.731 | 54365.110 |
| MultiplyBenchmark_SByte  | Sum256Traits          |  3169.954 |  2107.408 | 89131.418 |
| MultiplyBenchmark_SByte  | Sum512Bcl             |           |           | 88067.109 |
| MultiplyBenchmark_SByte  | Sum512Traits          |           |           | 88062.441 |
| MultiplyBenchmark_Single | SumScalar             |  2266.805 |  2267.800 |  2267.908 |
| MultiplyBenchmark_Single | SumBcl                |  9072.484 |  9080.029 |  9082.471 |
| MultiplyBenchmark_Single | SumTraits             |  9074.574 |  9079.558 |  9082.585 |
| MultiplyBenchmark_Single | Sum128Bcl             |           |  9081.897 |  9078.989 |
| MultiplyBenchmark_Single | Sum128Traits          |  9074.850 |  9081.187 |  9079.647 |
| MultiplyBenchmark_Single | Sum256Traits          |  1259.708 |  1509.792 | 18059.308 |
| MultiplyBenchmark_Single | Sum512Bcl             |           |           | 22725.225 |
| MultiplyBenchmark_Single | Sum512Traits          |           |           | 22721.753 |
| MultiplyBenchmark_UInt32 | SumScalar             |  2105.960 |  3887.201 |  4030.438 |
| MultiplyBenchmark_UInt32 | SumBcl                | 13600.350 | 13615.947 | 13617.616 |
| MultiplyBenchmark_UInt32 | SumTraits             | 13605.415 | 13616.378 | 13616.517 |
| MultiplyBenchmark_UInt32 | Sum128Bcl             |           | 13612.252 | 13616.688 |
| MultiplyBenchmark_UInt32 | Sum128Traits          | 13602.668 | 13614.338 | 13616.494 |
| MultiplyBenchmark_UInt32 | Sum256Traits          |  1500.863 |  1610.030 | 22931.980 |
| MultiplyBenchmark_UInt32 | Sum512Bcl             |           |           | 22915.646 |
| MultiplyBenchmark_UInt32 | Sum512Traits          |           |           | 22915.859 |
| MultiplyBenchmark_UInt64 | SumScalar             |  2014.187 |  3402.326 |  3626.665 |
| MultiplyBenchmark_UInt64 | SumBcl                |  2860.792 |  3685.022 |  3711.368 |
| MultiplyBenchmark_UInt64 | SumTraits             |  3551.955 |  3688.830 |   760.538 |
| MultiplyBenchmark_UInt64 | Sum128Bcl             |           |  3676.737 |   760.818 |
| MultiplyBenchmark_UInt64 | Sum128Traits          |  3559.260 |  3673.181 |   761.005 |
| MultiplyBenchmark_UInt64 | Sum256Traits          |   986.204 |  1071.959 |   889.642 |
| MultiplyBenchmark_UInt64 | Sum256Avx             |           |           |           |
| MultiplyBenchmark_UInt64 | Sum512Bcl             |           |           |   721.770 |
| MultiplyBenchmark_UInt64 | Sum512Traits          |           |           |   703.081 |

### Arm - AWS Arm t4g.small
| Type                     | Method                | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :----------------------- | :-------------------- | ------------: | --------: | --------: | --------: | --------: |
| MultiplyBenchmark_Double | SumScalar             |       337.005 |   765.158 |   765.182 |  1104.393 |  1105.389 |
| MultiplyBenchmark_Double | SumBcl                |      3399.130 |  3873.427 |  3883.512 |  3712.227 |  4552.630 |
| MultiplyBenchmark_Double | SumTraits             |      3381.067 |  3885.530 |  3287.472 |  3707.190 |  4546.313 |
| MultiplyBenchmark_Double | Sum128Bcl             |               |           |           |  3730.914 |  4534.542 |
| MultiplyBenchmark_Double | Sum128Traits          |       442.337 |  3858.567 |  3871.341 |  3720.143 |  4517.567 |
| MultiplyBenchmark_Double | Sum256Traits          |       232.185 |   411.487 |   409.393 |   395.141 |  4795.404 |
| MultiplyBenchmark_Double | Sum512Bcl             |               |           |           |           |  4797.190 |
| MultiplyBenchmark_Double | Sum512Traits          |               |           |           |           |  4797.669 |
| MultiplyBenchmark_Int16  | SumScalar             |       642.063 |   650.090 |   649.810 |  1017.686 |  1197.147 |
| MultiplyBenchmark_Int16  | SumBcl                |     15406.326 | 13934.387 | 12694.374 | 19348.719 | 14649.842 |
| MultiplyBenchmark_Int16  | SumTraits             |     15400.756 | 13920.383 | 12704.512 | 19366.619 | 14659.607 |
| MultiplyBenchmark_Int16  | Sum128Bcl             |               |           |           | 19310.373 | 14649.238 |
| MultiplyBenchmark_Int16  | Sum128Traits          |       607.055 | 13843.966 | 13683.905 | 19336.966 | 14641.378 |
| MultiplyBenchmark_Int16  | Sum256Traits          |       630.494 |   854.469 |   856.353 |   590.485 | 14739.844 |
| MultiplyBenchmark_Int16  | Sum512Bcl             |               |           |           |           | 14838.300 |
| MultiplyBenchmark_Int16  | Sum512Traits          |               |           |           |           | 14844.525 |
| MultiplyBenchmark_Int32  | SumScalar             |       701.416 |   721.237 |   722.455 |  1416.581 |  1457.904 |
| MultiplyBenchmark_Int32  | SumBcl                |      6382.609 |  6239.205 |  6599.548 |  9223.896 |  7141.657 |
| MultiplyBenchmark_Int32  | SumTraits             |      6366.615 |  6325.248 |  6549.784 |  9288.851 |  7094.265 |
| MultiplyBenchmark_Int32  | Sum128Bcl             |               |           |           |  9170.571 |  7113.515 |
| MultiplyBenchmark_Int32  | Sum128Traits          |       379.183 |  6671.417 |  6115.176 |  9228.576 |  7145.406 |
| MultiplyBenchmark_Int32  | Sum256Traits          |       367.375 |   549.254 |   541.307 |   472.320 |  7259.976 |
| MultiplyBenchmark_Int32  | Sum512Bcl             |               |           |           |           |  7279.466 |
| MultiplyBenchmark_Int32  | Sum512Traits          |               |           |           |           |  7289.348 |
| MultiplyBenchmark_SByte  | SumScalar             |       757.496 |   776.229 |   775.967 |  1184.435 |  1386.130 |
| MultiplyBenchmark_SByte  | SumBcl                |     30504.090 | 26968.952 | 26972.889 | 38055.098 | 28841.714 |
| MultiplyBenchmark_SByte  | SumBcl_Widen          |     11983.202 | 12044.887 | 12257.411 | 12070.742 | 11844.513 |
| MultiplyBenchmark_SByte  | SumTraits             |     30320.547 | 26721.472 | 26806.408 | 37645.745 | 28689.219 |
| MultiplyBenchmark_SByte  | Sum128Bcl             |               |           |           | 38075.235 | 28858.647 |
| MultiplyBenchmark_SByte  | Sum128_Wasm           |               |           |           |           |           |
| MultiplyBenchmark_SByte  | Sum128_Wasm_SelfWiden |               |           |           |           |           |
| MultiplyBenchmark_SByte  | Sum128Traits          |       974.648 | 27352.611 | 27094.429 | 38062.599 | 28888.561 |
| MultiplyBenchmark_SByte  | Sum256Traits          |       903.516 |  1149.070 |  1135.508 |   668.915 | 29121.739 |
| MultiplyBenchmark_SByte  | Sum512Bcl             |               |           |           |           | 28750.208 |
| MultiplyBenchmark_SByte  | Sum512Traits          |               |           |           |           | 28721.428 |
| MultiplyBenchmark_Single | SumScalar             |       792.128 |   827.784 |   827.233 |  1241.571 |  1283.737 |
| MultiplyBenchmark_Single | SumBcl                |      7540.270 |  6372.110 |  6248.930 |  9063.567 |  7142.448 |
| MultiplyBenchmark_Single | SumTraits             |      7535.954 |  6362.535 |  6145.281 |  9009.415 |  7141.715 |
| MultiplyBenchmark_Single | Sum128Bcl             |               |           |           |  9056.348 |  7145.038 |
| MultiplyBenchmark_Single | Sum128Traits          |       360.651 |  6802.313 |  6649.767 |  9093.006 |  7163.629 |
| MultiplyBenchmark_Single | Sum256Traits          |       364.937 |   545.020 |   534.267 |   527.451 |  7237.944 |
| MultiplyBenchmark_Single | Sum512Bcl             |               |           |           |           |  7263.834 |
| MultiplyBenchmark_Single | Sum512Traits          |               |           |           |           |  7252.608 |
| MultiplyBenchmark_UInt32 | SumScalar             |       711.227 |   721.738 |   721.192 |  1420.310 |  1449.314 |
| MultiplyBenchmark_UInt32 | SumBcl                |      6114.045 |  7585.147 |  6417.064 |  7177.777 |  9153.660 |
| MultiplyBenchmark_UInt32 | SumTraits             |      6129.403 |  7572.250 |  6374.262 |  7180.708 |  9127.705 |
| MultiplyBenchmark_UInt32 | Sum128Bcl             |               |           |           |  7192.343 |  9182.463 |
| MultiplyBenchmark_UInt32 | Sum128Traits          |       371.926 |  6485.223 |  7512.146 |  7161.815 |  9156.586 |
| MultiplyBenchmark_UInt32 | Sum256Traits          |       357.795 |   552.760 |   543.902 |   472.801 |  9173.832 |
| MultiplyBenchmark_UInt32 | Sum512Bcl             |               |           |           |           |  9156.175 |
| MultiplyBenchmark_UInt32 | Sum512Traits          |               |           |           |           |  9208.081 |
| MultiplyBenchmark_UInt64 | SumScalar             |       662.591 |   671.974 |   672.540 |  1104.550 |  1105.089 |
| MultiplyBenchmark_UInt64 | SumBcl                |       387.865 |   821.376 |   988.837 |  1115.057 |   929.823 |
| MultiplyBenchmark_UInt64 | SumTraits             |       390.688 |  1146.735 |  1136.482 |  1114.127 |   875.909 |
| MultiplyBenchmark_UInt64 | Sum128Bcl             |               |           |           |  1112.570 |   871.256 |
| MultiplyBenchmark_UInt64 | Sum128Traits          |       464.420 |  1141.525 |  1142.145 |  1114.582 |   857.482 |
| MultiplyBenchmark_UInt64 | Sum256Traits          |       227.533 |   390.710 |   390.271 |   387.809 |   960.416 |
| MultiplyBenchmark_UInt64 | Sum256Avx             |               |           |           |           |           |
| MultiplyBenchmark_UInt64 | Sum512Bcl             |               |           |           |           |   297.887 |
| MultiplyBenchmark_UInt64 | Sum512Traits          |               |           |           |           |   298.582 |

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                     | Method                | .NET 8.0 |
| :----------------------- | :-------------------- | -------: |
| MultiplyBenchmark_Double | SumScalar             |  116.589 |
| MultiplyBenchmark_Double | SumBcl                |   43.843 |
| MultiplyBenchmark_Double | SumTraits             |   76.772 |
| MultiplyBenchmark_Double | Sum128Bcl             |   24.036 |
| MultiplyBenchmark_Double | Sum128Traits          |  220.198 |
| MultiplyBenchmark_Double | Sum256Traits          |   11.290 |
| MultiplyBenchmark_Double | Sum512Bcl             |   13.261 |
| MultiplyBenchmark_Double | Sum512Traits          |   13.744 |
| MultiplyBenchmark_Int16  | SumScalar             |  167.968 |
| MultiplyBenchmark_Int16  | SumBcl                | 1014.240 |
| MultiplyBenchmark_Int16  | SumTraits             |  929.271 |
| MultiplyBenchmark_Int16  | Sum128Bcl             |  880.309 |
| MultiplyBenchmark_Int16  | Sum128Traits          |  946.306 |
| MultiplyBenchmark_Int16  | Sum256Traits          |  537.157 |
| MultiplyBenchmark_Int16  | Sum512Bcl             |  369.440 |
| MultiplyBenchmark_Int16  | Sum512Traits          |  384.835 |
| MultiplyBenchmark_Int32  | SumScalar             |  149.707 |
| MultiplyBenchmark_Int32  | SumBcl                |  441.506 |
| MultiplyBenchmark_Int32  | SumTraits             |  440.202 |
| MultiplyBenchmark_Int32  | Sum128Bcl             |  445.955 |
| MultiplyBenchmark_Int32  | Sum128Traits          |  431.430 |
| MultiplyBenchmark_Int32  | Sum256Traits          |  296.221 |
| MultiplyBenchmark_Int32  | Sum512Bcl             |  176.293 |
| MultiplyBenchmark_Int32  | Sum512Traits          |  201.367 |
| MultiplyBenchmark_SByte  | SumScalar             |  179.820 |
| MultiplyBenchmark_SByte  | SumBcl                |  931.205 |
| MultiplyBenchmark_SByte  | SumBcl_Widen          |   82.885 |
| MultiplyBenchmark_SByte  | SumTraits             |  724.587 |
| MultiplyBenchmark_SByte  | Sum128Bcl             |  905.653 |
| MultiplyBenchmark_SByte  | Sum128_Wasm           |  771.292 |
| MultiplyBenchmark_SByte  | Sum128_Wasm_SelfWiden |  771.810 |
| MultiplyBenchmark_SByte  | Sum128Traits          |  751.008 |
| MultiplyBenchmark_SByte  | Sum256Traits          |  171.400 |
| MultiplyBenchmark_SByte  | Sum512Bcl             |  564.414 |
| MultiplyBenchmark_SByte  | Sum512Traits          |  157.311 |
| MultiplyBenchmark_Single | SumScalar             |  136.743 |
| MultiplyBenchmark_Single | SumBcl                |  450.597 |
| MultiplyBenchmark_Single | SumTraits             |  441.990 |
| MultiplyBenchmark_Single | Sum128Bcl             |  451.810 |
| MultiplyBenchmark_Single | Sum128Traits          |  467.821 |
| MultiplyBenchmark_Single | Sum256Traits          |  248.736 |
| MultiplyBenchmark_Single | Sum512Bcl             |  196.781 |
| MultiplyBenchmark_Single | Sum512Traits          |  192.289 |
| MultiplyBenchmark_UInt32 | SumScalar             |  146.590 |
| MultiplyBenchmark_UInt32 | SumBcl                |  425.143 |
| MultiplyBenchmark_UInt32 | SumTraits             |  429.039 |
| MultiplyBenchmark_UInt32 | Sum128Bcl             |  430.968 |
| MultiplyBenchmark_UInt32 | Sum128Traits          |  466.250 |
| MultiplyBenchmark_UInt32 | Sum256Traits          |   47.672 |
| MultiplyBenchmark_UInt32 | Sum512Bcl             |  194.312 |
| MultiplyBenchmark_UInt32 | Sum512Traits          |   44.267 |
| MultiplyBenchmark_UInt64 | SumScalar             |  115.785 |
| MultiplyBenchmark_UInt64 | SumBcl                |   59.033 |
| MultiplyBenchmark_UInt64 | SumTraits             |  206.129 |
| MultiplyBenchmark_UInt64 | Sum128Bcl             |   28.758 |
| MultiplyBenchmark_UInt64 | Sum128Traits          |  222.068 |
| MultiplyBenchmark_UInt64 | Sum256Traits          |   12.948 |
| MultiplyBenchmark_UInt64 | Sum256Avx             |          |
| MultiplyBenchmark_UInt64 | Sum512Bcl             |   12.903 |
| MultiplyBenchmark_UInt64 | Sum512Traits          |   11.564 |

