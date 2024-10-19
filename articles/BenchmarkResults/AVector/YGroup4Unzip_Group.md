# Benchmark group - YGroup4Unzip
([← Back](YGroup4Unzip.md))

Unit of data: Million operations per second. The larger the number, the better the performance.
### X86 - AMD Ryzen 7 7840H
| Type                         | Method                    | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :--------------------------- | :------------------------ | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| YGroup4UnzipBenchmark_Byte   | SumBase_Basic             |        190.913 |       366.084 |       393.177 |   384.617 |   462.764 |   415.345 |   508.836 |
| YGroup4UnzipBenchmark_Byte   | SumBase_Narrow            |                |               |               |           |           |  5050.996 |  6424.102 |
| YGroup4UnzipBenchmark_Byte   | SumBase_Unzip             |       1313.504 |      1300.906 |      1319.150 |  1355.779 |  1331.928 |  7605.523 | 11322.199 |
| YGroup4UnzipBenchmark_Byte   | SumBase                   |       1308.828 |      1288.986 |      1317.053 |  1362.915 |  1331.758 |  7694.095 | 11140.844 |
| YGroup4UnzipBenchmark_Byte   | SumTraits                 |       1311.822 |      1301.084 |     11317.635 | 11712.292 | 11633.963 | 11440.257 | 23883.061 |
| YGroup4UnzipBenchmark_Byte   | Sum128Base_Basic          |                |               |       187.509 |   215.623 |   206.146 |   394.714 |   543.268 |
| YGroup4UnzipBenchmark_Byte   | Sum128Base_Narrow         |                |               |               |           |           |  3107.233 |  3217.284 |
| YGroup4UnzipBenchmark_Byte   | Sum128Base_Unzip          |                |               |               |           |           |  4787.751 |  5793.973 |
| YGroup4UnzipBenchmark_Byte   | Sum128Base                |                |               |       191.222 |   204.525 |   207.102 |  4772.638 |  5786.586 |
| YGroup4UnzipBenchmark_Byte   | Sum128AdvSimd_Narrow      |                |               |               |           |           |           |           |
| YGroup4UnzipBenchmark_Byte   | Sum128AdvSimd_ShuffleX    |                |               |               |           |           |           |           |
| YGroup4UnzipBenchmark_Byte   | Sum128AdvSimd_Unzip       |                |               |               |           |           |           |           |
| YGroup4UnzipBenchmark_Byte   | Sum128AdvSimdB64_ShuffleX |                |               |               |           |           |           |           |
| YGroup4UnzipBenchmark_Byte   | Sum128AdvSimdB64_Unzip    |                |               |               |           |           |           |           |
| YGroup4UnzipBenchmark_Byte   | Sum128PackedSimd_Unzip    |                |               |               |           |           |           |           |
| YGroup4UnzipBenchmark_Byte   | Sum128Sse_Permute         |                |               |               |           |           |           | 14728.610 |
| YGroup4UnzipBenchmark_Byte   | Sum128Sse_Narrow          |                |               |      2613.681 |  3202.091 |  3263.961 |  3231.663 |  3947.983 |
| YGroup4UnzipBenchmark_Byte   | Sum128Sse_Unpack          |                |               |      7271.825 |  8083.456 |  8094.591 |  7870.067 |  8004.607 |
| YGroup4UnzipBenchmark_Byte   | Sum128Sse_Unzip           |                |               |      4297.204 |  5022.033 |  5091.896 |  4761.336 | 13216.107 |
| YGroup4UnzipBenchmark_Byte   | Sum128Traits              |                |               |      7258.039 |  8101.005 |  8105.307 |  7906.761 | 15159.452 |
| YGroup4UnzipBenchmark_Byte   | Sum256Base_Basic          |                |               |       214.899 |   213.734 |   234.294 |   430.677 |   528.079 |
| YGroup4UnzipBenchmark_Byte   | Sum256Base_Narrow         |                |               |               |           |           |  4874.950 |  6483.212 |
| YGroup4UnzipBenchmark_Byte   | Sum256Base_Unzip          |                |               |               |           |           |  7558.180 | 11332.542 |
| YGroup4UnzipBenchmark_Byte   | Sum256Base                |                |               |       220.710 |   212.757 |   236.021 |  7639.775 | 11356.249 |
| YGroup4UnzipBenchmark_Byte   | Sum256Avx2_Permute        |                |               |               |           |           |           | 19181.517 |
| YGroup4UnzipBenchmark_Byte   | Sum256Avx2_Narrow         |                |               |      4747.147 |  1817.157 |  5072.741 |  5061.850 |  6462.570 |
| YGroup4UnzipBenchmark_Byte   | Sum256Avx2_Unpack         |                |               |     11761.122 | 11668.034 | 11732.882 | 11650.379 | 12694.266 |
| YGroup4UnzipBenchmark_Byte   | Sum256Avx2_Unzip          |                |               |      7081.978 |  7158.142 |  7402.959 |  7542.780 | 25515.269 |
| YGroup4UnzipBenchmark_Byte   | Sum256Traits              |                |               |     11727.078 | 11644.337 | 11665.941 | 11575.078 | 26321.408 |
| YGroup4UnzipBenchmark_Byte   | Sum512Base_Basic          |                |               |               |           |           |           |   550.258 |
| YGroup4UnzipBenchmark_Byte   | Sum512Base_Narrow         |                |               |               |           |           |           |  6514.335 |
| YGroup4UnzipBenchmark_Byte   | Sum512Base_Unzip          |                |               |               |           |           |           | 13167.362 |
| YGroup4UnzipBenchmark_Byte   | Sum512Base                |                |               |               |           |           |           | 13188.038 |
| YGroup4UnzipBenchmark_Byte   | Sum512Avx512_Permute      |                |               |               |           |           |           | 17482.569 |
| YGroup4UnzipBenchmark_Byte   | Sum512Avx512_Narrow       |                |               |               |           |           |           |  6518.573 |
| YGroup4UnzipBenchmark_Byte   | Sum512Avx512_Unpack       |                |               |               |           |           |           | 11732.034 |
| YGroup4UnzipBenchmark_Byte   | Sum512Avx512_Unzip        |                |               |               |           |           |           | 33462.067 |
| YGroup4UnzipBenchmark_Byte   | Sum512Traits              |                |               |               |           |           |           | 32966.449 |
| YGroup4UnzipBenchmark_Int128 | SumBase_Basic             |         48.481 |        57.072 |        58.459 |    91.215 |    94.168 |    79.364 |    99.681 |
| YGroup4UnzipBenchmark_Int128 | SumBase                   |         47.238 |        56.109 |        55.632 |    89.034 |    94.773 |    80.817 |   100.215 |
| YGroup4UnzipBenchmark_Int128 | SumTraits                 |         44.831 |        53.163 |        44.580 |    28.437 |    29.047 |   130.493 |    94.374 |
| YGroup4UnzipBenchmark_Int128 | SumTraits_Int128          |         60.907 |        71.964 |      4468.862 |  4660.765 |  4666.283 |  4542.025 |  5447.562 |
| YGroup4UnzipBenchmark_Int128 | Sum128Base_Basic          |                |               |        41.121 |    41.403 |    41.174 |    83.296 |    84.334 |
| YGroup4UnzipBenchmark_Int128 | Sum128Base                |                |               |        41.292 |    41.249 |    41.112 |    83.374 |    84.597 |
| YGroup4UnzipBenchmark_Int128 | Sum128Traits              |                |               |        83.080 |    83.521 |    83.567 |    83.034 |    84.357 |
| YGroup4UnzipBenchmark_Int128 | Sum128Traits_Int128       |                |               |      4121.575 |  4082.289 |  3827.590 |  3506.388 |  3723.567 |
| YGroup4UnzipBenchmark_Int128 | Sum256Base_Basic          |                |               |        38.654 |    50.385 |    55.158 |   124.097 |   221.817 |
| YGroup4UnzipBenchmark_Int128 | Sum256Base                |                |               |        37.410 |    45.178 |    49.074 |   436.147 |  4694.933 |
| YGroup4UnzipBenchmark_Int128 | Sum256Avx2                |                |               |        70.617 |    71.092 |    74.552 |   477.783 |  5366.868 |
| YGroup4UnzipBenchmark_Int128 | Sum256Traits              |                |               |        66.020 |    71.559 |    74.870 |   485.889 |  5336.861 |
| YGroup4UnzipBenchmark_Int128 | Sum256Traits_Int128       |                |               |      4215.748 |  4721.944 |  4671.648 |  4537.832 |  5494.496 |
| YGroup4UnzipBenchmark_Int128 | Sum512Base_Basic          |                |               |               |           |           |           |   287.972 |
| YGroup4UnzipBenchmark_Int128 | Sum512Base_Move           |                |               |               |           |           |           |  1886.283 |
| YGroup4UnzipBenchmark_Int128 | Sum512Base_Unzip          |                |               |               |           |           |           |   890.162 |
| YGroup4UnzipBenchmark_Int128 | Sum512Base                |                |               |               |           |           |           |  1883.592 |
| YGroup4UnzipBenchmark_Int128 | Sum512Avx512              |                |               |               |           |           |           |  4364.424 |
| YGroup4UnzipBenchmark_Int128 | Sum512Traits              |                |               |               |           |           |           |  4349.202 |
| YGroup4UnzipBenchmark_Int128 | Sum512Traits_Int128       |                |               |               |           |           |           |  4360.276 |
| YGroup4UnzipBenchmark_Int16  | SumBase_Basic             |        173.483 |       306.636 |       335.081 |   292.904 |   367.653 |   314.329 |   432.544 |
| YGroup4UnzipBenchmark_Int16  | SumBase_Narrow            |                |               |               |           |           |  2419.735 |  3201.869 |
| YGroup4UnzipBenchmark_Int16  | SumBase_Unzip             |        858.395 |       842.063 |       866.206 |   813.299 |   899.047 |  3802.816 |  5618.852 |
| YGroup4UnzipBenchmark_Int16  | SumBase                   |        856.782 |       839.566 |       869.353 |   802.852 |   897.176 |  3708.598 |  5637.351 |
| YGroup4UnzipBenchmark_Int16  | SumTraits                 |        859.478 |       836.200 |      6990.059 |  7281.744 |  7274.943 |  7115.192 | 12090.640 |
| YGroup4UnzipBenchmark_Int16  | Sum128Base_Basic          |                |               |       125.621 |   126.286 |   130.128 |   305.466 |   400.774 |
| YGroup4UnzipBenchmark_Int16  | Sum128Base_Narrow         |                |               |               |           |           |  1519.946 |  1633.242 |
| YGroup4UnzipBenchmark_Int16  | Sum128Base_Unzip          |                |               |               |           |           |  2314.881 |  2887.157 |
| YGroup4UnzipBenchmark_Int16  | Sum128Base                |                |               |       126.080 |   126.874 |   129.772 |  2312.904 |  2924.003 |
| YGroup4UnzipBenchmark_Int16  | Sum128AdvSimd_Narrow      |                |               |               |           |           |           |           |
| YGroup4UnzipBenchmark_Int16  | Sum128AdvSimd_ShuffleX    |                |               |               |           |           |           |           |
| YGroup4UnzipBenchmark_Int16  | Sum128AdvSimd_Unzip       |                |               |               |           |           |           |           |
| YGroup4UnzipBenchmark_Int16  | Sum128AdvSimdB64_ShuffleX |                |               |               |           |           |           |           |
| YGroup4UnzipBenchmark_Int16  | Sum128AdvSimdB64_Unzip    |                |               |               |           |           |           |           |
| YGroup4UnzipBenchmark_Int16  | Sum128PackedSimd_Unzip    |                |               |               |           |           |           |           |
| YGroup4UnzipBenchmark_Int16  | Sum128Sse_Permute         |                |               |               |           |           |           |  7324.511 |
| YGroup4UnzipBenchmark_Int16  | Sum128Sse_Narrow          |                |               |      1360.978 |  1454.320 |  1485.624 |  1496.123 |  2038.283 |
| YGroup4UnzipBenchmark_Int16  | Sum128Sse_Unpack          |                |               |      4745.538 |  5257.057 |  5265.101 |  5218.333 |  5245.593 |
| YGroup4UnzipBenchmark_Int16  | Sum128Sse_Unzip           |                |               |      2494.536 |  2809.804 |  2830.633 |  2752.524 |  6715.743 |
| YGroup4UnzipBenchmark_Int16  | Sum128Traits              |                |               |      4761.592 |  5235.845 |  5163.157 |  5133.435 |  6845.378 |
| YGroup4UnzipBenchmark_Int16  | Sum256Base_Basic          |                |               |       166.470 |   155.381 |   172.907 |   321.189 |   439.783 |
| YGroup4UnzipBenchmark_Int16  | Sum256Base_Narrow         |                |               |               |           |           |  2432.301 |  3260.511 |
| YGroup4UnzipBenchmark_Int16  | Sum256Base_Unzip          |                |               |               |           |           |  3783.991 |  5610.957 |
| YGroup4UnzipBenchmark_Int16  | Sum256Base                |                |               |       165.380 |   150.215 |   172.991 |  3780.878 |  5558.928 |
| YGroup4UnzipBenchmark_Int16  | Sum256Avx2_Permute        |                |               |               |           |           |           |  9438.963 |
| YGroup4UnzipBenchmark_Int16  | Sum256Avx2_Narrow         |                |               |      2229.205 |   804.265 |  2301.797 |  2271.999 |  3200.801 |
| YGroup4UnzipBenchmark_Int16  | Sum256Avx2_Unpack         |                |               |      7204.738 |  7221.397 |  7173.467 |  7106.401 |  7762.908 |
| YGroup4UnzipBenchmark_Int16  | Sum256Avx2_Unzip          |                |               |      3792.411 |  3801.789 |  3787.005 |  3764.902 | 12165.501 |
| YGroup4UnzipBenchmark_Int16  | Sum256Traits              |                |               |      7224.613 |  7275.563 |  7228.484 |  7113.034 | 12942.112 |
| YGroup4UnzipBenchmark_Int16  | Sum512Base_Basic          |                |               |               |           |           |           |   457.129 |
| YGroup4UnzipBenchmark_Int16  | Sum512Base_Narrow         |                |               |               |           |           |           |  3254.052 |
| YGroup4UnzipBenchmark_Int16  | Sum512Base_Unzip          |                |               |               |           |           |           |  6659.382 |
| YGroup4UnzipBenchmark_Int16  | Sum512Base                |                |               |               |           |           |           |  6644.433 |
| YGroup4UnzipBenchmark_Int16  | Sum512Avx512_Permute      |                |               |               |           |           |           |  8407.801 |
| YGroup4UnzipBenchmark_Int16  | Sum512Avx512_Narrow       |                |               |               |           |           |           |  3266.021 |
| YGroup4UnzipBenchmark_Int16  | Sum512Avx512_Unpack       |                |               |               |           |           |           |  6973.292 |
| YGroup4UnzipBenchmark_Int16  | Sum512Avx512_Unzip        |                |               |               |           |           |           | 16570.473 |
| YGroup4UnzipBenchmark_Int16  | Sum512Traits              |                |               |               |           |           |           | 16694.703 |
| YGroup4UnzipBenchmark_Int32  | SumBase_Basic             |        140.922 |       215.524 |       228.238 |   193.109 |   257.931 |   227.867 |   319.245 |
| YGroup4UnzipBenchmark_Int32  | SumBase_Unzip             |        381.290 |       365.787 |       369.360 |   388.591 |   371.455 |  1844.052 |  2802.278 |
| YGroup4UnzipBenchmark_Int32  | SumBase                   |        378.672 |       368.789 |       371.093 |   386.340 |   381.094 |  1833.154 |  2795.132 |
| YGroup4UnzipBenchmark_Int32  | SumTraits                 |        380.403 |       362.874 |      4353.965 |  4531.006 |  4555.739 |  4484.379 |  6249.957 |
| YGroup4UnzipBenchmark_Int32  | Sum128Base_Basic          |                |               |        84.345 |    84.965 |    86.946 |   197.466 |   275.183 |
| YGroup4UnzipBenchmark_Int32  | Sum128Base_Unzip          |                |               |               |           |           |  1141.171 |  1423.265 |
| YGroup4UnzipBenchmark_Int32  | Sum128Base                |                |               |        85.127 |    84.411 |    85.255 |  1148.487 |  1455.643 |
| YGroup4UnzipBenchmark_Int32  | Sum128AdvSimd_ShuffleX    |                |               |               |           |           |           |           |
| YGroup4UnzipBenchmark_Int32  | Sum128AdvSimd_Unzip       |                |               |               |           |           |           |           |
| YGroup4UnzipBenchmark_Int32  | Sum128AdvSimdB64_ShuffleX |                |               |               |           |           |           |           |
| YGroup4UnzipBenchmark_Int32  | Sum128AdvSimdB64_Unzip    |                |               |               |           |           |           |           |
| YGroup4UnzipBenchmark_Int32  | Sum128PackedSimd_Unzip    |                |               |               |           |           |           |           |
| YGroup4UnzipBenchmark_Int32  | Sum128Sse_Permute         |                |               |               |           |           |           |  3569.770 |
| YGroup4UnzipBenchmark_Int32  | Sum128Sse_Unpack          |                |               |      3266.690 |  3669.472 |  3705.316 |  3612.090 |  3665.616 |
| YGroup4UnzipBenchmark_Int32  | Sum128Sse_Unzip           |                |               |      3225.848 |  3186.275 |  3195.266 |  2995.178 |  3632.176 |
| YGroup4UnzipBenchmark_Int32  | Sum128Traits              |                |               |      3198.406 |  3649.089 |  3760.642 |  3422.599 |  3676.406 |
| YGroup4UnzipBenchmark_Int32  | Sum256Base_Basic          |                |               |       111.889 |   100.072 |   123.441 |   230.427 |   317.628 |
| YGroup4UnzipBenchmark_Int32  | Sum256Base_Unzip          |                |               |               |           |           |  1881.378 |  2791.221 |
| YGroup4UnzipBenchmark_Int32  | Sum256Base                |                |               |       120.878 |    98.857 |   124.971 |  1879.245 |  2814.809 |
| YGroup4UnzipBenchmark_Int32  | Sum256Avx2_Permute        |                |               |               |           |           |           |  4804.668 |
| YGroup4UnzipBenchmark_Int32  | Sum256Avx2_Unpack         |                |               |      4605.509 |  4573.300 |  4580.303 |  4515.699 |  4953.402 |
| YGroup4UnzipBenchmark_Int32  | Sum256Avx2_Unzip          |                |               |      3545.363 |  3567.710 |  3587.078 |  3551.816 |  6152.071 |
| YGroup4UnzipBenchmark_Int32  | Sum256Traits              |                |               |      4591.433 |  4555.480 |  4567.923 |  4528.857 |  6436.301 |
| YGroup4UnzipBenchmark_Int32  | Sum512Base_Basic          |                |               |               |           |           |           |   371.477 |
| YGroup4UnzipBenchmark_Int32  | Sum512Base_Unzip          |                |               |               |           |           |           |  3329.459 |
| YGroup4UnzipBenchmark_Int32  | Sum512Base                |                |               |               |           |           |           |  3314.440 |
| YGroup4UnzipBenchmark_Int32  | Sum512Avx512_Permute      |                |               |               |           |           |           |  4197.718 |
| YGroup4UnzipBenchmark_Int32  | Sum512Avx512_Unpack       |                |               |               |           |           |           |  4280.347 |
| YGroup4UnzipBenchmark_Int32  | Sum512Avx512_Unzip        |                |               |               |           |           |           |  8213.812 |
| YGroup4UnzipBenchmark_Int32  | Sum512Traits              |                |               |               |           |           |           |  8254.065 |
| YGroup4UnzipBenchmark_Int64  | SumBase_Basic             |         97.871 |       134.569 |       157.670 |   110.952 |   172.608 |   138.947 |   198.984 |
| YGroup4UnzipBenchmark_Int64  | SumBase                   |        100.824 |       135.586 |       157.197 |   103.670 |   164.861 |   138.472 |   200.886 |
| YGroup4UnzipBenchmark_Int64  | SumTraits                 |        108.201 |       133.918 |      2917.665 |  3070.160 |  3057.537 |  3000.670 |  3743.422 |
| YGroup4UnzipBenchmark_Int64  | Sum128Base_Basic          |                |               |        45.443 |    46.347 |    46.290 |   121.041 |   159.873 |
| YGroup4UnzipBenchmark_Int64  | Sum128Base_Move           |                |               |               |           |           |    45.768 |    99.809 |
| YGroup4UnzipBenchmark_Int64  | Sum128Base_Unzip          |                |               |               |           |           |    78.842 |   249.806 |
| YGroup4UnzipBenchmark_Int64  | Sum128Base                |                |               |        40.316 |    40.241 |    45.259 |    79.105 |   248.213 |
| YGroup4UnzipBenchmark_Int64  | Sum128AdvSimd_ShuffleX    |                |               |               |           |           |           |           |
| YGroup4UnzipBenchmark_Int64  | Sum128AdvSimd_Unzip       |                |               |               |           |           |           |           |
| YGroup4UnzipBenchmark_Int64  | Sum128AdvSimdB64_ShuffleX |                |               |               |           |           |           |           |
| YGroup4UnzipBenchmark_Int64  | Sum128AdvSimdB64_Unzip    |                |               |               |           |           |           |           |
| YGroup4UnzipBenchmark_Int64  | Sum128PackedSimd_Unzip    |                |               |               |           |           |           |           |
| YGroup4UnzipBenchmark_Int64  | Sum128Sse_Permute         |                |               |               |           |           |           |  1791.655 |
| YGroup4UnzipBenchmark_Int64  | Sum128Sse_Unpack          |                |               |      2558.203 |  2719.839 |  2584.873 |  2734.317 |  2629.631 |
| YGroup4UnzipBenchmark_Int64  | Sum128Sse_Unzip           |                |               |      2456.921 |  2829.786 |  2711.829 |  2576.776 |  2642.295 |
| YGroup4UnzipBenchmark_Int64  | Sum128Traits              |                |               |      2563.989 |  2724.012 |  2743.392 |  2614.924 |  2720.074 |
| YGroup4UnzipBenchmark_Int64  | Sum256Base_Basic          |                |               |        62.372 |    56.624 |    71.000 |   140.867 |   199.529 |
| YGroup4UnzipBenchmark_Int64  | Sum256Base                |                |               |        71.082 |    55.921 |    71.854 |   140.147 |   200.616 |
| YGroup4UnzipBenchmark_Int64  | Sum256Avx2_Permute        |                |               |               |           |           |           |  2405.319 |
| YGroup4UnzipBenchmark_Int64  | Sum256Avx2_Unpack         |                |               |      3163.178 |  3111.953 |  2979.182 |  3028.780 |  3524.684 |
| YGroup4UnzipBenchmark_Int64  | Sum256Avx2_Unzip          |                |               |      1909.841 |  2054.701 |  2043.133 |  2022.364 |  3200.331 |
| YGroup4UnzipBenchmark_Int64  | Sum256Traits              |                |               |      3109.256 |  3104.312 |  3017.880 |  2930.615 |  3524.479 |
| YGroup4UnzipBenchmark_Int64  | Sum512Base_Basic          |                |               |               |           |           |           |   251.738 |
| YGroup4UnzipBenchmark_Int64  | Sum512Base                |                |               |               |           |           |           |   248.477 |
| YGroup4UnzipBenchmark_Int64  | Sum512Avx512_Permute      |                |               |               |           |           |           |  2159.698 |
| YGroup4UnzipBenchmark_Int64  | Sum512Avx512_Unpack       |                |               |               |           |           |           |  2902.392 |
| YGroup4UnzipBenchmark_Int64  | Sum512Avx512_Unzip        |                |               |               |           |           |           |  4158.073 |
| YGroup4UnzipBenchmark_Int64  | Sum512Traits              |                |               |               |           |           |           |  4159.506 |
| YGroup4ZipBenchmark_Byte     | SumBase_Basic             |        251.154 |       403.517 |       455.895 |   393.351 |   442.134 |   450.800 |   566.847 |
| YGroup4ZipBenchmark_Byte     | SumBase_Widen             |                |               |               |           |           |  4811.906 |  5314.398 |
| YGroup4ZipBenchmark_Byte     | SumBase_Zip               |       5162.172 |      4901.345 |      4920.933 |  5085.018 |  4974.636 |  7296.301 |  8283.701 |
| YGroup4ZipBenchmark_Byte     | SumBase                   |       5139.426 |      4768.965 |      4970.837 |  5094.209 |  5009.342 |  7288.461 |  8248.253 |
| YGroup4ZipBenchmark_Byte     | SumTraits                 |       5027.778 |      4866.195 |     17570.591 | 20881.719 | 20489.374 | 20302.304 | 24723.567 |
| YGroup4ZipBenchmark_Byte     | Sum128Base_Basic          |                |               |       205.204 |   198.827 |   208.632 |   417.576 |   485.586 |
| YGroup4ZipBenchmark_Byte     | Sum128Base_Widen          |                |               |               |           |           |  2522.568 |  2688.026 |
| YGroup4ZipBenchmark_Byte     | Sum128Base_Zip            |                |               |               |           |           |  3965.990 |  4080.740 |
| YGroup4ZipBenchmark_Byte     | Sum128Base                |                |               |       204.208 |   215.981 |   201.911 |  3864.722 |  4084.862 |
| YGroup4ZipBenchmark_Byte     | Sum128AdvSimd_ShuffleX    |                |               |               |           |           |           |           |
| YGroup4ZipBenchmark_Byte     | Sum128AdvSimd_Widen       |                |               |               |           |           |           |           |
| YGroup4ZipBenchmark_Byte     | Sum128AdvSimd_Zip         |                |               |               |           |           |           |           |
| YGroup4ZipBenchmark_Byte     | Sum128AdvSimdB64_ShuffleX |                |               |               |           |           |           |           |
| YGroup4ZipBenchmark_Byte     | Sum128AdvSimdB64_Zip      |                |               |               |           |           |           |           |
| YGroup4ZipBenchmark_Byte     | Sum128PackedSimd_Zip      |                |               |               |           |           |           |           |
| YGroup4ZipBenchmark_Byte     | Sum128Sse_Permute         |                |               |               |           |           |           | 14276.207 |
| YGroup4ZipBenchmark_Byte     | Sum128Sse_Widen           |                |               |      2143.552 |  3061.943 |  3113.181 |  3032.090 |  3138.661 |
| YGroup4ZipBenchmark_Byte     | Sum128Sse_Zip             |                |               |     12967.776 | 14975.661 | 14778.250 | 14224.181 | 14233.708 |
| YGroup4ZipBenchmark_Byte     | Sum128Traits              |                |               |     12972.106 | 14744.642 | 14819.275 | 14323.282 | 14139.144 |
| YGroup4ZipBenchmark_Byte     | Sum256Base_Basic          |                |               |       237.100 |   214.522 |   232.678 |   474.925 |   574.262 |
| YGroup4ZipBenchmark_Byte     | Sum256Base_Widen          |                |               |               |           |           |  4763.063 |  5275.039 |
| YGroup4ZipBenchmark_Byte     | Sum256Base_Zip            |                |               |               |           |           |  7199.163 |  8056.696 |
| YGroup4ZipBenchmark_Byte     | Sum256Base                |                |               |       227.948 |   221.102 |   234.581 |  7226.623 |  8206.895 |
| YGroup4ZipBenchmark_Byte     | Sum256Avx2_Permute        |                |               |               |           |           |           | 19208.990 |
| YGroup4ZipBenchmark_Byte     | Sum256Avx2_Widen          |                |               |      3997.023 |  4633.461 |  4697.851 |  4519.043 |  5387.699 |
| YGroup4ZipBenchmark_Byte     | Sum256Avx2_Unpack         |                |               |     18979.155 | 21283.751 | 21458.135 | 21314.463 | 20661.159 |
| YGroup4ZipBenchmark_Byte     | Sum256Avx2_Zip            |                |               |     14250.406 | 16690.530 | 16527.551 | 16280.004 | 25005.377 |
| YGroup4ZipBenchmark_Byte     | Sum256Traits              |                |               |     18894.838 | 21428.836 | 20886.951 | 20693.407 | 24553.252 |
| YGroup4ZipBenchmark_Byte     | Sum512Base_Basic          |                |               |               |           |           |           |   560.822 |
| YGroup4ZipBenchmark_Byte     | Sum512Base_Widen          |                |               |               |           |           |           |  6240.905 |
| YGroup4ZipBenchmark_Byte     | Sum512Base_Zip            |                |               |               |           |           |           | 10482.232 |
| YGroup4ZipBenchmark_Byte     | Sum512Base                |                |               |               |           |           |           | 10469.801 |
| YGroup4ZipBenchmark_Byte     | Sum512Avx512_Widen        |                |               |               |           |           |           |  6296.965 |
| YGroup4ZipBenchmark_Byte     | Sum512Avx512_Unpack       |                |               |               |           |           |           | 18882.903 |
| YGroup4ZipBenchmark_Byte     | Sum512Avx512_Zip          |                |               |               |           |           |           | 33258.320 |
| YGroup4ZipBenchmark_Byte     | Sum512Traits              |                |               |               |           |           |           | 33050.939 |
| YGroup4ZipBenchmark_Int128   | SumBase_Basic             |         49.964 |        55.673 |        54.964 |    77.541 |    84.800 |    84.359 |    98.231 |
| YGroup4ZipBenchmark_Int128   | SumBase                   |         49.544 |        53.914 |        52.810 |    76.007 |    85.361 |    84.653 |    98.446 |
| YGroup4ZipBenchmark_Int128   | SumTraits                 |         46.842 |        52.808 |        44.299 |    28.002 |    29.006 |   130.649 |    93.229 |
| YGroup4ZipBenchmark_Int128   | SumTraits_Int128          |         65.869 |        76.437 |      4142.950 |  4536.606 |  4647.233 |  4591.619 |  5235.955 |
| YGroup4ZipBenchmark_Int128   | Sum128Base_Basic          |                |               |        41.302 |    40.919 |    41.349 |    83.166 |    84.521 |
| YGroup4ZipBenchmark_Int128   | Sum128Base                |                |               |        40.917 |    41.134 |    41.303 |    83.432 |    84.471 |
| YGroup4ZipBenchmark_Int128   | Sum128Traits              |                |               |        83.011 |    83.189 |    83.356 |    82.999 |    84.716 |
| YGroup4ZipBenchmark_Int128   | Sum128Traits_Int128       |                |               |      3859.157 |  4009.394 |  3881.983 |  3650.084 |  3647.143 |
| YGroup4ZipBenchmark_Int128   | Sum256Base_Basic          |                |               |        35.316 |    46.945 |    52.451 |   133.687 |   192.012 |
| YGroup4ZipBenchmark_Int128   | Sum256Base                |                |               |        37.634 |    44.705 |    48.573 |   447.769 |  4758.460 |
| YGroup4ZipBenchmark_Int128   | Sum256Avx2                |                |               |        69.688 |    69.820 |    73.890 |   483.140 |  5430.292 |
| YGroup4ZipBenchmark_Int128   | Sum256Traits              |                |               |        65.166 |    69.964 |    73.983 |   485.374 |  5341.405 |
| YGroup4ZipBenchmark_Int128   | Sum256Traits_Int128       |                |               |      4240.108 |  4756.999 |  4729.797 |  4669.404 |  5377.307 |
| YGroup4ZipBenchmark_Int128   | Sum512Base_Basic          |                |               |               |           |           |           |   211.468 |
| YGroup4ZipBenchmark_Int128   | Sum512Base_Move           |                |               |               |           |           |           |  1884.878 |
| YGroup4ZipBenchmark_Int128   | Sum512Base_Zip            |                |               |               |           |           |           |   891.999 |
| YGroup4ZipBenchmark_Int128   | Sum512Base                |                |               |               |           |           |           |  1883.651 |
| YGroup4ZipBenchmark_Int128   | Sum512Avx512              |                |               |               |           |           |           |  4196.687 |
| YGroup4ZipBenchmark_Int128   | Sum512Traits              |                |               |               |           |           |           |  4134.293 |
| YGroup4ZipBenchmark_Int128   | Sum512Traits_Int128       |                |               |               |           |           |           |  4147.294 |
| YGroup4ZipBenchmark_Int16    | SumBase_Basic             |        201.490 |       325.145 |       378.571 |   298.105 |   362.856 |   380.256 |   451.794 |
| YGroup4ZipBenchmark_Int16    | SumBase_Widen             |                |               |               |           |           |  2412.773 |  2656.963 |
| YGroup4ZipBenchmark_Int16    | SumBase_Zip               |       2484.660 |      2424.978 |      2559.626 |  2548.948 |  2512.644 |  3647.958 |  4144.257 |
| YGroup4ZipBenchmark_Int16    | SumBase                   |       2626.164 |      2437.925 |      2483.194 |  2493.152 |  2519.882 |  3626.172 |  4114.475 |
| YGroup4ZipBenchmark_Int16    | SumTraits                 |       2610.113 |      2412.217 |      9083.127 | 10275.728 | 10521.471 | 10238.326 | 12458.323 |
| YGroup4ZipBenchmark_Int16    | Sum128Base_Basic          |                |               |       131.803 |   133.956 |   135.766 |   321.062 |   360.176 |
| YGroup4ZipBenchmark_Int16    | Sum128Base_Widen          |                |               |               |           |           |  1227.512 |  1351.475 |
| YGroup4ZipBenchmark_Int16    | Sum128Base_Zip            |                |               |               |           |           |  1830.105 |  2017.405 |
| YGroup4ZipBenchmark_Int16    | Sum128Base                |                |               |       130.242 |   133.310 |   134.108 |  1830.314 |  1993.364 |
| YGroup4ZipBenchmark_Int16    | Sum128AdvSimd_ShuffleX    |                |               |               |           |           |           |           |
| YGroup4ZipBenchmark_Int16    | Sum128AdvSimd_Widen       |                |               |               |           |           |           |           |
| YGroup4ZipBenchmark_Int16    | Sum128AdvSimd_Zip         |                |               |               |           |           |           |           |
| YGroup4ZipBenchmark_Int16    | Sum128AdvSimdB64_ShuffleX |                |               |               |           |           |           |           |
| YGroup4ZipBenchmark_Int16    | Sum128AdvSimdB64_Zip      |                |               |               |           |           |           |           |
| YGroup4ZipBenchmark_Int16    | Sum128PackedSimd_Zip      |                |               |               |           |           |           |           |
| YGroup4ZipBenchmark_Int16    | Sum128Sse_Permute         |                |               |               |           |           |           |  6888.565 |
| YGroup4ZipBenchmark_Int16    | Sum128Sse_Widen           |                |               |      1092.044 |  1572.432 |  1627.863 |  1525.768 |  1504.251 |
| YGroup4ZipBenchmark_Int16    | Sum128Sse_Zip             |                |               |      6466.347 |  7461.573 |  7061.820 |  7264.182 |  7371.543 |
| YGroup4ZipBenchmark_Int16    | Sum128Traits              |                |               |      6678.739 |  7362.837 |  7544.184 |  7064.437 |  7355.981 |
| YGroup4ZipBenchmark_Int16    | Sum256Base_Basic          |                |               |       177.052 |   162.809 |   184.519 |   376.459 |   446.996 |
| YGroup4ZipBenchmark_Int16    | Sum256Base_Widen          |                |               |               |           |           |  2366.719 |  2678.575 |
| YGroup4ZipBenchmark_Int16    | Sum256Base_Zip            |                |               |               |           |           |  3670.263 |  3929.069 |
| YGroup4ZipBenchmark_Int16    | Sum256Base                |                |               |       176.441 |   156.177 |   184.740 |  3579.184 |  4085.968 |
| YGroup4ZipBenchmark_Int16    | Sum256Avx2_Permute        |                |               |               |           |           |           |  9475.023 |
| YGroup4ZipBenchmark_Int16    | Sum256Avx2_Widen          |                |               |      1864.294 |  2306.579 |  2320.037 |  2254.595 |  2672.070 |
| YGroup4ZipBenchmark_Int16    | Sum256Avx2_Unpack         |                |               |      9495.847 | 10280.934 | 10539.332 | 10051.832 | 10554.011 |
| YGroup4ZipBenchmark_Int16    | Sum256Avx2_Zip            |                |               |      7073.414 |  8062.111 |  7937.913 |  8003.923 | 12560.870 |
| YGroup4ZipBenchmark_Int16    | Sum256Traits              |                |               |      9237.422 | 10529.701 | 10238.148 | 10210.013 | 12754.909 |
| YGroup4ZipBenchmark_Int16    | Sum512Base_Basic          |                |               |               |           |           |           |   425.047 |
| YGroup4ZipBenchmark_Int16    | Sum512Base_Widen          |                |               |               |           |           |           |  3120.806 |
| YGroup4ZipBenchmark_Int16    | Sum512Base_Zip            |                |               |               |           |           |           |  5257.995 |
| YGroup4ZipBenchmark_Int16    | Sum512Base                |                |               |               |           |           |           |  5245.364 |
| YGroup4ZipBenchmark_Int16    | Sum512Avx512_Widen        |                |               |               |           |           |           |  3139.200 |
| YGroup4ZipBenchmark_Int16    | Sum512Avx512_Unpack       |                |               |               |           |           |           |  9353.922 |
| YGroup4ZipBenchmark_Int16    | Sum512Avx512_Zip          |                |               |               |           |           |           | 16601.833 |
| YGroup4ZipBenchmark_Int16    | Sum512Traits              |                |               |               |           |           |           | 16724.948 |
| YGroup4ZipBenchmark_Int32    | SumBase_Basic             |        144.208 |       222.766 |       277.897 |   193.234 |   294.511 |   245.834 |   319.460 |
| YGroup4ZipBenchmark_Int32    | SumBase_Zip               |         60.074 |       103.901 |       119.993 |   113.841 |   125.472 |  1826.713 |  2087.067 |
| YGroup4ZipBenchmark_Int32    | SumBase                   |        145.016 |       212.612 |       275.226 |   190.835 |   295.959 |  1817.586 |  2127.701 |
| YGroup4ZipBenchmark_Int32    | SumTraits                 |        147.378 |       212.054 |      4490.028 |  5191.872 |  5198.124 |  4989.766 |  6792.440 |
| YGroup4ZipBenchmark_Int32    | Sum128Base_Basic          |                |               |        85.710 |    83.205 |    83.821 |   200.529 |   226.084 |
| YGroup4ZipBenchmark_Int32    | Sum128Base_Zip            |                |               |               |           |           |   925.063 |  1027.900 |
| YGroup4ZipBenchmark_Int32    | Sum128Base                |                |               |        84.363 |    81.686 |    83.063 |   930.485 |  1010.871 |
| YGroup4ZipBenchmark_Int32    | Sum128AdvSimd_ShuffleX    |                |               |               |           |           |           |           |
| YGroup4ZipBenchmark_Int32    | Sum128AdvSimd_Zip         |                |               |               |           |           |           |           |
| YGroup4ZipBenchmark_Int32    | Sum128AdvSimdB64_ShuffleX |                |               |               |           |           |           |           |
| YGroup4ZipBenchmark_Int32    | Sum128AdvSimdB64_Zip      |                |               |               |           |           |           |           |
| YGroup4ZipBenchmark_Int32    | Sum128PackedSimd_Zip      |                |               |               |           |           |           |           |
| YGroup4ZipBenchmark_Int32    | Sum128Sse_Permute         |                |               |               |           |           |           |  3607.999 |
| YGroup4ZipBenchmark_Int32    | Sum128Sse_Zip             |                |               |      3259.418 |  3598.240 |  3594.226 |  3477.853 |  3462.840 |
| YGroup4ZipBenchmark_Int32    | Sum128Traits              |                |               |      3275.900 |  3658.618 |  3763.094 |  3479.747 |  3734.821 |
| YGroup4ZipBenchmark_Int32    | Sum256Base_Basic          |                |               |       117.760 |   103.884 |   131.536 |   259.402 |   308.250 |
| YGroup4ZipBenchmark_Int32    | Sum256Base_Zip            |                |               |               |           |           |  1814.790 |  1999.979 |
| YGroup4ZipBenchmark_Int32    | Sum256Base                |                |               |       129.969 |   102.303 |   134.493 |  1813.977 |  2027.180 |
| YGroup4ZipBenchmark_Int32    | Sum256Avx2_Permute        |                |               |               |           |           |           |  4779.061 |
| YGroup4ZipBenchmark_Int32    | Sum256Avx2_Unpack         |                |               |      4665.935 |  5173.782 |  5264.162 |  5051.634 |  5149.223 |
| YGroup4ZipBenchmark_Int32    | Sum256Avx2_Zip            |                |               |      3534.301 |  4100.444 |  4112.304 |  3994.512 |  6362.161 |
| YGroup4ZipBenchmark_Int32    | Sum256Traits              |                |               |      4748.235 |  5091.419 |  5195.031 |  5056.451 |  6340.075 |
| YGroup4ZipBenchmark_Int32    | Sum512Base_Basic          |                |               |               |           |           |           |   293.614 |
| YGroup4ZipBenchmark_Int32    | Sum512Base_Zip            |                |               |               |           |           |           |  2616.734 |
| YGroup4ZipBenchmark_Int32    | Sum512Base                |                |               |               |           |           |           |  2620.974 |
| YGroup4ZipBenchmark_Int32    | Sum512Avx512_Unpack       |                |               |               |           |           |           |  4684.721 |
| YGroup4ZipBenchmark_Int32    | Sum512Avx512_Zip          |                |               |               |           |           |           |  8207.273 |
| YGroup4ZipBenchmark_Int32    | Sum512Traits              |                |               |               |           |           |           |  8219.793 |
| YGroup4ZipBenchmark_Int64    | SumBase_Basic             |         95.092 |       124.161 |       171.044 |   108.010 |   176.327 |   159.046 |   176.905 |
| YGroup4ZipBenchmark_Int64    | SumBase                   |         97.965 |       122.021 |       169.198 |   108.024 |   181.404 |   156.884 |   180.663 |
| YGroup4ZipBenchmark_Int64    | SumTraits                 |         96.776 |       121.400 |      2312.248 |  2673.854 |  2642.175 |  2565.763 |  3200.810 |
| YGroup4ZipBenchmark_Int64    | Sum128Base_Basic          |                |               |        45.092 |    45.972 |    46.200 |   125.082 |   134.244 |
| YGroup4ZipBenchmark_Int64    | Sum128Base_Move           |                |               |               |           |           |    45.742 |    99.793 |
| YGroup4ZipBenchmark_Int64    | Sum128Base_Zip            |                |               |               |           |           |    79.274 |   249.374 |
| YGroup4ZipBenchmark_Int64    | Sum128Base                |                |               |        40.642 |    40.191 |    45.261 |    79.593 |   247.673 |
| YGroup4ZipBenchmark_Int64    | Sum128AdvSimd_ShuffleX    |                |               |               |           |           |           |           |
| YGroup4ZipBenchmark_Int64    | Sum128AdvSimd_Zip         |                |               |               |           |           |           |           |
| YGroup4ZipBenchmark_Int64    | Sum128AdvSimdB64_ShuffleX |                |               |               |           |           |           |           |
| YGroup4ZipBenchmark_Int64    | Sum128AdvSimdB64_Zip      |                |               |               |           |           |           |           |
| YGroup4ZipBenchmark_Int64    | Sum128PackedSimd_Zip      |                |               |               |           |           |           |           |
| YGroup4ZipBenchmark_Int64    | Sum128Sse_Permute         |                |               |               |           |           |           |  1761.508 |
| YGroup4ZipBenchmark_Int64    | Sum128Sse_Zip             |                |               |      2525.382 |  2807.971 |  2693.472 |  2697.866 |  2950.458 |
| YGroup4ZipBenchmark_Int64    | Sum128Traits              |                |               |      2464.488 |  2707.136 |  2732.028 |  2707.043 |  2863.710 |
| YGroup4ZipBenchmark_Int64    | Sum256Base_Basic          |                |               |        66.682 |    57.500 |    75.626 |   158.033 |   178.750 |
| YGroup4ZipBenchmark_Int64    | Sum256Base                |                |               |        77.183 |    56.746 |    75.428 |   154.140 |   181.998 |
| YGroup4ZipBenchmark_Int64    | Sum256Avx2_Permute        |                |               |               |           |           |           |  2404.807 |
| YGroup4ZipBenchmark_Int64    | Sum256Avx2_Unpack         |                |               |      2369.849 |  2676.501 |  2634.659 |  2581.569 |  2664.569 |
| YGroup4ZipBenchmark_Int64    | Sum256Avx2_Zip            |                |               |      1786.667 |  2099.920 |  2063.402 |  2058.522 |  3105.077 |
| YGroup4ZipBenchmark_Int64    | Sum256Traits              |                |               |      2410.066 |  2698.435 |  2646.259 |  2561.453 |  3121.222 |
| YGroup4ZipBenchmark_Int64    | Sum512Base_Basic          |                |               |               |           |           |           |   182.698 |
| YGroup4ZipBenchmark_Int64    | Sum512Base                |                |               |               |           |           |           |   175.888 |
| YGroup4ZipBenchmark_Int64    | Sum512Avx512_Unpack       |                |               |               |           |           |           |  2360.029 |
| YGroup4ZipBenchmark_Int64    | Sum512Avx512_Zip          |                |               |               |           |           |           |  4153.175 |
| YGroup4ZipBenchmark_Int64    | Sum512Traits              |                |               |               |           |           |           |  4192.078 |

### Arm - Apple M2
| Type                         | Method                    |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :--------------------------- | :------------------------ | --------: | --------: | --------: |
| YGroup4UnzipBenchmark_Byte   | SumBase_Basic             |   584.649 |   787.272 |  1018.597 |
| YGroup4UnzipBenchmark_Byte   | SumBase_Narrow            |           |  6201.824 |  7458.657 |
| YGroup4UnzipBenchmark_Byte   | SumBase_Unzip             |  2093.166 |  9418.799 | 10331.239 |
| YGroup4UnzipBenchmark_Byte   | SumBase                   |  2093.072 |  9417.353 | 10330.663 |
| YGroup4UnzipBenchmark_Byte   | SumTraits                 | 21709.057 | 21707.435 | 21726.068 |
| YGroup4UnzipBenchmark_Byte   | Sum128Base_Basic          |   366.819 |   787.710 |  1018.028 |
| YGroup4UnzipBenchmark_Byte   | Sum128Base_Narrow         |           |  6201.104 |  7457.403 |
| YGroup4UnzipBenchmark_Byte   | Sum128Base_Unzip          |           |  9418.460 | 10331.808 |
| YGroup4UnzipBenchmark_Byte   | Sum128Base                |   366.584 |  9417.516 | 10329.227 |
| YGroup4UnzipBenchmark_Byte   | Sum128AdvSimd_Narrow      |  6204.560 |  6200.292 |  7457.396 |
| YGroup4UnzipBenchmark_Byte   | Sum128AdvSimd_ShuffleX    |           |           |  5149.796 |
| YGroup4UnzipBenchmark_Byte   | Sum128AdvSimd_Unzip       |  9418.671 |  9417.584 | 10333.810 |
| YGroup4UnzipBenchmark_Byte   | Sum128AdvSimdB64_ShuffleX |           |           | 12900.863 |
| YGroup4UnzipBenchmark_Byte   | Sum128AdvSimdB64_Unzip    | 21713.503 | 21711.643 | 21729.573 |
| YGroup4UnzipBenchmark_Byte   | Sum128PackedSimd_Unzip    |           |           |           |
| YGroup4UnzipBenchmark_Byte   | Sum128Sse_Permute         |           |           |           |
| YGroup4UnzipBenchmark_Byte   | Sum128Sse_Narrow          |           |           |           |
| YGroup4UnzipBenchmark_Byte   | Sum128Sse_Unpack          |           |           |           |
| YGroup4UnzipBenchmark_Byte   | Sum128Sse_Unzip           |           |           |           |
| YGroup4UnzipBenchmark_Byte   | Sum128Traits              | 21712.500 | 21714.533 | 21731.129 |
| YGroup4UnzipBenchmark_Byte   | Sum256Base_Basic          |   348.855 |   327.750 |  1022.414 |
| YGroup4UnzipBenchmark_Byte   | Sum256Base_Narrow         |           |   146.252 |  7764.056 |
| YGroup4UnzipBenchmark_Byte   | Sum256Base_Unzip          |           |   218.780 |   450.240 |
| YGroup4UnzipBenchmark_Byte   | Sum256Base                |   349.267 |   326.563 |  1021.958 |
| YGroup4UnzipBenchmark_Byte   | Sum256Avx2_Permute        |           |           |           |
| YGroup4UnzipBenchmark_Byte   | Sum256Avx2_Narrow         |           |           |           |
| YGroup4UnzipBenchmark_Byte   | Sum256Avx2_Unpack         |           |           |           |
| YGroup4UnzipBenchmark_Byte   | Sum256Avx2_Unzip          |           |           |           |
| YGroup4UnzipBenchmark_Byte   | Sum256Traits              |   321.423 |   326.941 |  1022.010 |
| YGroup4UnzipBenchmark_Byte   | Sum512Base_Basic          |           |           |   927.004 |
| YGroup4UnzipBenchmark_Byte   | Sum512Base_Narrow         |           |           |  9227.955 |
| YGroup4UnzipBenchmark_Byte   | Sum512Base_Unzip          |           |           |   429.475 |
| YGroup4UnzipBenchmark_Byte   | Sum512Base                |           |           |   928.239 |
| YGroup4UnzipBenchmark_Byte   | Sum512Avx512_Permute      |           |           |           |
| YGroup4UnzipBenchmark_Byte   | Sum512Avx512_Narrow       |           |           |           |
| YGroup4UnzipBenchmark_Byte   | Sum512Avx512_Unpack       |           |           |           |
| YGroup4UnzipBenchmark_Byte   | Sum512Avx512_Unzip        |           |           |           |
| YGroup4UnzipBenchmark_Byte   | Sum512Traits              |           |           |   928.324 |
| YGroup4UnzipBenchmark_Int128 | SumBase_Basic             |   199.027 |   183.417 |   444.415 |
| YGroup4UnzipBenchmark_Int128 | SumBase                   |   197.470 |   184.003 |   444.226 |
| YGroup4UnzipBenchmark_Int128 | SumTraits                 |   198.128 |   173.168 |   417.585 |
| YGroup4UnzipBenchmark_Int128 | SumTraits_Int128          |  1071.479 |  1071.061 |  3236.875 |
| YGroup4UnzipBenchmark_Int128 | Sum128Base_Basic          |   350.532 |  1304.578 |  2947.469 |
| YGroup4UnzipBenchmark_Int128 | Sum128Base                |   350.484 |  1294.058 |  2936.684 |
| YGroup4UnzipBenchmark_Int128 | Sum128Traits              |  1340.951 |  1294.248 |  2935.244 |
| YGroup4UnzipBenchmark_Int128 | Sum128Traits_Int128       |  3232.575 |  3232.651 |  3236.633 |
| YGroup4UnzipBenchmark_Int128 | Sum256Base_Basic          |   111.418 |   128.898 |   402.343 |
| YGroup4UnzipBenchmark_Int128 | Sum256Base                |    66.565 |   112.693 |  6387.344 |
| YGroup4UnzipBenchmark_Int128 | Sum256Avx2                |           |           |           |
| YGroup4UnzipBenchmark_Int128 | Sum256Traits              |    53.377 |   111.467 |  6384.757 |
| YGroup4UnzipBenchmark_Int128 | Sum256Traits_Int128       |   102.407 |   111.298 |  6385.732 |
| YGroup4UnzipBenchmark_Int128 | Sum512Base_Basic          |           |           |   388.467 |
| YGroup4UnzipBenchmark_Int128 | Sum512Base_Move           |           |           | 11486.151 |
| YGroup4UnzipBenchmark_Int128 | Sum512Base_Unzip          |           |           | 11510.561 |
| YGroup4UnzipBenchmark_Int128 | Sum512Base                |           |           | 11510.961 |
| YGroup4UnzipBenchmark_Int128 | Sum512Avx512              |           |           |           |
| YGroup4UnzipBenchmark_Int128 | Sum512Traits              |           |           | 11510.954 |
| YGroup4UnzipBenchmark_Int128 | Sum512Traits_Int128       |           |           | 11510.307 |
| YGroup4UnzipBenchmark_Int16  | SumBase_Basic             |   417.682 |   596.405 |   925.044 |
| YGroup4UnzipBenchmark_Int16  | SumBase_Narrow            |           |  3100.719 |  3729.578 |
| YGroup4UnzipBenchmark_Int16  | SumBase_Unzip             |  2009.488 |  4710.960 |  5166.212 |
| YGroup4UnzipBenchmark_Int16  | SumBase                   |  2009.957 |  4710.982 |  5166.148 |
| YGroup4UnzipBenchmark_Int16  | SumTraits                 | 10871.631 | 10868.672 | 10871.837 |
| YGroup4UnzipBenchmark_Int16  | Sum128Base_Basic          |   282.043 |   599.262 |   925.009 |
| YGroup4UnzipBenchmark_Int16  | Sum128Base_Narrow         |           |  3101.456 |  3729.096 |
| YGroup4UnzipBenchmark_Int16  | Sum128Base_Unzip          |           |  4709.914 |  5166.938 |
| YGroup4UnzipBenchmark_Int16  | Sum128Base                |   279.799 |  4711.067 |  5165.206 |
| YGroup4UnzipBenchmark_Int16  | Sum128AdvSimd_Narrow      |  3103.392 |  3101.124 |  3728.979 |
| YGroup4UnzipBenchmark_Int16  | Sum128AdvSimd_ShuffleX    |           |           |  2557.389 |
| YGroup4UnzipBenchmark_Int16  | Sum128AdvSimd_Unzip       |  4711.975 |  4711.446 |  5162.239 |
| YGroup4UnzipBenchmark_Int16  | Sum128AdvSimdB64_ShuffleX |           |           |  6453.776 |
| YGroup4UnzipBenchmark_Int16  | Sum128AdvSimdB64_Unzip    | 10870.277 | 10869.307 | 10870.871 |
| YGroup4UnzipBenchmark_Int16  | Sum128PackedSimd_Unzip    |           |           |           |
| YGroup4UnzipBenchmark_Int16  | Sum128Sse_Permute         |           |           |           |
| YGroup4UnzipBenchmark_Int16  | Sum128Sse_Narrow          |           |           |           |
| YGroup4UnzipBenchmark_Int16  | Sum128Sse_Unpack          |           |           |           |
| YGroup4UnzipBenchmark_Int16  | Sum128Sse_Unzip           |           |           |           |
| YGroup4UnzipBenchmark_Int16  | Sum128Traits              | 10871.121 | 10871.220 | 10872.351 |
| YGroup4UnzipBenchmark_Int16  | Sum256Base_Basic          |   266.399 |   262.068 |   930.124 |
| YGroup4UnzipBenchmark_Int16  | Sum256Base_Narrow         |           |   101.958 |  3876.531 |
| YGroup4UnzipBenchmark_Int16  | Sum256Base_Unzip          |           |   166.581 |   419.342 |
| YGroup4UnzipBenchmark_Int16  | Sum256Base                |   266.668 |   259.738 |   930.063 |
| YGroup4UnzipBenchmark_Int16  | Sum256Avx2_Permute        |           |           |           |
| YGroup4UnzipBenchmark_Int16  | Sum256Avx2_Narrow         |           |           |           |
| YGroup4UnzipBenchmark_Int16  | Sum256Avx2_Unpack         |           |           |           |
| YGroup4UnzipBenchmark_Int16  | Sum256Avx2_Unzip          |           |           |           |
| YGroup4UnzipBenchmark_Int16  | Sum256Traits              |   245.479 |   260.635 |   930.036 |
| YGroup4UnzipBenchmark_Int16  | Sum512Base_Basic          |           |           |   874.013 |
| YGroup4UnzipBenchmark_Int16  | Sum512Base_Narrow         |           |           |  4495.405 |
| YGroup4UnzipBenchmark_Int16  | Sum512Base_Unzip          |           |           |   384.942 |
| YGroup4UnzipBenchmark_Int16  | Sum512Base                |           |           |   873.856 |
| YGroup4UnzipBenchmark_Int16  | Sum512Avx512_Permute      |           |           |           |
| YGroup4UnzipBenchmark_Int16  | Sum512Avx512_Narrow       |           |           |           |
| YGroup4UnzipBenchmark_Int16  | Sum512Avx512_Unpack       |           |           |           |
| YGroup4UnzipBenchmark_Int16  | Sum512Avx512_Unzip        |           |           |           |
| YGroup4UnzipBenchmark_Int16  | Sum512Traits              |           |           |   873.961 |
| YGroup4UnzipBenchmark_Int32  | SumBase_Basic             |   288.607 |   405.267 |   693.084 |
| YGroup4UnzipBenchmark_Int32  | SumBase_Unzip             |   776.406 |  2355.565 |  2582.983 |
| YGroup4UnzipBenchmark_Int32  | SumBase                   |   776.409 |  2356.312 |  2583.714 |
| YGroup4UnzipBenchmark_Int32  | SumTraits                 |  5438.320 |  5439.144 |  5438.338 |
| YGroup4UnzipBenchmark_Int32  | Sum128Base_Basic          |   208.728 |   406.118 |   693.303 |
| YGroup4UnzipBenchmark_Int32  | Sum128Base_Unzip          |           |  2356.053 |  2583.774 |
| YGroup4UnzipBenchmark_Int32  | Sum128Base                |   208.289 |  2355.914 |  2583.780 |
| YGroup4UnzipBenchmark_Int32  | Sum128AdvSimd_ShuffleX    |           |           |  1265.887 |
| YGroup4UnzipBenchmark_Int32  | Sum128AdvSimd_Unzip       |  2354.294 |  2356.036 |  2583.923 |
| YGroup4UnzipBenchmark_Int32  | Sum128AdvSimdB64_ShuffleX |           |           |  3215.011 |
| YGroup4UnzipBenchmark_Int32  | Sum128AdvSimdB64_Unzip    |  5437.669 |  5438.905 |  5439.044 |
| YGroup4UnzipBenchmark_Int32  | Sum128PackedSimd_Unzip    |           |           |           |
| YGroup4UnzipBenchmark_Int32  | Sum128Sse_Permute         |           |           |           |
| YGroup4UnzipBenchmark_Int32  | Sum128Sse_Unpack          |           |           |           |
| YGroup4UnzipBenchmark_Int32  | Sum128Sse_Unzip           |           |           |           |
| YGroup4UnzipBenchmark_Int32  | Sum128Traits              |  5438.011 |  5438.074 |  5437.131 |
| YGroup4UnzipBenchmark_Int32  | Sum256Base_Basic          |   187.125 |   183.665 |   716.566 |
| YGroup4UnzipBenchmark_Int32  | Sum256Base_Unzip          |           |   120.699 |   333.529 |
| YGroup4UnzipBenchmark_Int32  | Sum256Base                |   186.377 |   182.974 |   716.522 |
| YGroup4UnzipBenchmark_Int32  | Sum256Avx2_Permute        |           |           |           |
| YGroup4UnzipBenchmark_Int32  | Sum256Avx2_Unpack         |           |           |           |
| YGroup4UnzipBenchmark_Int32  | Sum256Avx2_Unzip          |           |           |           |
| YGroup4UnzipBenchmark_Int32  | Sum256Traits              |   181.940 |   182.922 |   716.306 |
| YGroup4UnzipBenchmark_Int32  | Sum512Base_Basic          |           |           |   642.653 |
| YGroup4UnzipBenchmark_Int32  | Sum512Base_Unzip          |           |           |   302.932 |
| YGroup4UnzipBenchmark_Int32  | Sum512Base                |           |           |   643.254 |
| YGroup4UnzipBenchmark_Int32  | Sum512Avx512_Permute      |           |           |           |
| YGroup4UnzipBenchmark_Int32  | Sum512Avx512_Unpack       |           |           |           |
| YGroup4UnzipBenchmark_Int32  | Sum512Avx512_Unzip        |           |           |           |
| YGroup4UnzipBenchmark_Int32  | Sum512Traits              |           |           |   646.053 |
| YGroup4UnzipBenchmark_Int64  | SumBase_Basic             |   194.978 |   255.055 |   453.325 |
| YGroup4UnzipBenchmark_Int64  | SumBase                   |   195.924 |   253.384 |   453.265 |
| YGroup4UnzipBenchmark_Int64  | SumTraits                 |  3323.262 |  3327.620 |  3328.090 |
| YGroup4UnzipBenchmark_Int64  | Sum128Base_Basic          |   136.633 |   253.302 |   453.432 |
| YGroup4UnzipBenchmark_Int64  | Sum128Base_Move           |           |  2205.604 |  3361.398 |
| YGroup4UnzipBenchmark_Int64  | Sum128Base_Unzip          |           |  2579.053 |  3400.003 |
| YGroup4UnzipBenchmark_Int64  | Sum128Base                |   408.176 |  2578.421 |  3399.541 |
| YGroup4UnzipBenchmark_Int64  | Sum128AdvSimd_ShuffleX    |           |           |   619.678 |
| YGroup4UnzipBenchmark_Int64  | Sum128AdvSimd_Unzip       |  2719.493 |  2720.258 |  3022.706 |
| YGroup4UnzipBenchmark_Int64  | Sum128AdvSimdB64_ShuffleX |           |           |  1575.717 |
| YGroup4UnzipBenchmark_Int64  | Sum128AdvSimdB64_Unzip    |  3322.597 |  3328.093 |  3327.803 |
| YGroup4UnzipBenchmark_Int64  | Sum128PackedSimd_Unzip    |           |           |           |
| YGroup4UnzipBenchmark_Int64  | Sum128Sse_Permute         |           |           |           |
| YGroup4UnzipBenchmark_Int64  | Sum128Sse_Unpack          |           |           |           |
| YGroup4UnzipBenchmark_Int64  | Sum128Sse_Unzip           |           |           |           |
| YGroup4UnzipBenchmark_Int64  | Sum128Traits              |  3323.066 |  3327.954 |  3327.990 |
| YGroup4UnzipBenchmark_Int64  | Sum256Base_Basic          |   108.670 |   110.413 |   436.954 |
| YGroup4UnzipBenchmark_Int64  | Sum256Base                |   107.822 |   110.297 |   437.061 |
| YGroup4UnzipBenchmark_Int64  | Sum256Avx2_Permute        |           |           |           |
| YGroup4UnzipBenchmark_Int64  | Sum256Avx2_Unpack         |           |           |           |
| YGroup4UnzipBenchmark_Int64  | Sum256Avx2_Unzip          |           |           |           |
| YGroup4UnzipBenchmark_Int64  | Sum256Traits              |   108.073 |   110.000 |   436.967 |
| YGroup4UnzipBenchmark_Int64  | Sum512Base_Basic          |           |           |   399.882 |
| YGroup4UnzipBenchmark_Int64  | Sum512Base                |           |           |   399.382 |
| YGroup4UnzipBenchmark_Int64  | Sum512Avx512_Permute      |           |           |           |
| YGroup4UnzipBenchmark_Int64  | Sum512Avx512_Unpack       |           |           |           |
| YGroup4UnzipBenchmark_Int64  | Sum512Avx512_Unzip        |           |           |           |
| YGroup4UnzipBenchmark_Int64  | Sum512Traits              |           |           |   399.072 |
| YGroup4ZipBenchmark_Byte     | SumBase_Basic             |   652.700 |   936.075 |   744.217 |
| YGroup4ZipBenchmark_Byte     | SumBase_Widen             |           |  4352.183 |  4352.411 |
| YGroup4ZipBenchmark_Byte     | SumBase_Zip               |  5439.695 |  6540.751 |  7192.371 |
| YGroup4ZipBenchmark_Byte     | SumBase                   |  5438.090 |  6541.766 |  7192.862 |
| YGroup4ZipBenchmark_Byte     | SumTraits                 | 21710.219 | 21706.230 | 21732.073 |
| YGroup4ZipBenchmark_Byte     | Sum128Base_Basic          |   380.508 |   936.179 |   744.203 |
| YGroup4ZipBenchmark_Byte     | Sum128Base_Widen          |           |  1007.256 |  4204.926 |
| YGroup4ZipBenchmark_Byte     | Sum128Base_Zip            |           |  1508.704 |  6595.133 |
| YGroup4ZipBenchmark_Byte     | Sum128Base                |   380.629 |  1508.394 |  6593.195 |
| YGroup4ZipBenchmark_Byte     | Sum128AdvSimd_ShuffleX    |           |           |  5148.608 |
| YGroup4ZipBenchmark_Byte     | Sum128AdvSimd_Widen       |  4439.439 |  4352.228 |  4351.779 |
| YGroup4ZipBenchmark_Byte     | Sum128AdvSimd_Zip         |  6592.849 |  6542.662 |  7190.883 |
| YGroup4ZipBenchmark_Byte     | Sum128AdvSimdB64_ShuffleX |           |           | 12893.303 |
| YGroup4ZipBenchmark_Byte     | Sum128AdvSimdB64_Zip      | 21710.903 | 21713.311 | 21727.385 |
| YGroup4ZipBenchmark_Byte     | Sum128PackedSimd_Zip      |           |           |           |
| YGroup4ZipBenchmark_Byte     | Sum128Sse_Permute         |           |           |           |
| YGroup4ZipBenchmark_Byte     | Sum128Sse_Widen           |           |           |           |
| YGroup4ZipBenchmark_Byte     | Sum128Sse_Zip             |           |           |           |
| YGroup4ZipBenchmark_Byte     | Sum128Traits              | 21717.794 | 21712.826 | 21726.277 |
| YGroup4ZipBenchmark_Byte     | Sum256Base_Basic          |   354.926 |   342.947 |   766.832 |
| YGroup4ZipBenchmark_Byte     | Sum256Base_Widen          |           |    95.707 |  4783.043 |
| YGroup4ZipBenchmark_Byte     | Sum256Base_Zip            |           |   231.318 |   342.774 |
| YGroup4ZipBenchmark_Byte     | Sum256Base                |   346.414 |   341.665 |   766.882 |
| YGroup4ZipBenchmark_Byte     | Sum256Avx2_Permute        |           |           |           |
| YGroup4ZipBenchmark_Byte     | Sum256Avx2_Widen          |           |           |           |
| YGroup4ZipBenchmark_Byte     | Sum256Avx2_Unpack         |           |           |           |
| YGroup4ZipBenchmark_Byte     | Sum256Avx2_Zip            |           |           |           |
| YGroup4ZipBenchmark_Byte     | Sum256Traits              |   323.146 |   341.624 |   766.783 |
| YGroup4ZipBenchmark_Byte     | Sum512Base_Basic          |           |           |   749.756 |
| YGroup4ZipBenchmark_Byte     | Sum512Base_Widen          |           |           |   555.708 |
| YGroup4ZipBenchmark_Byte     | Sum512Base_Zip            |           |           |   329.469 |
| YGroup4ZipBenchmark_Byte     | Sum512Base                |           |           |   749.589 |
| YGroup4ZipBenchmark_Byte     | Sum512Avx512_Widen        |           |           |           |
| YGroup4ZipBenchmark_Byte     | Sum512Avx512_Unpack       |           |           |           |
| YGroup4ZipBenchmark_Byte     | Sum512Avx512_Zip          |           |           |           |
| YGroup4ZipBenchmark_Byte     | Sum512Traits              |           |           |   749.719 |
| YGroup4ZipBenchmark_Int128   | SumBase_Basic             |   327.853 |   247.874 |   222.814 |
| YGroup4ZipBenchmark_Int128   | SumBase                   |   327.789 |   249.112 |   222.340 |
| YGroup4ZipBenchmark_Int128   | SumTraits                 |   327.783 |   177.366 |   417.838 |
| YGroup4ZipBenchmark_Int128   | SumTraits_Int128          |  1071.863 |  1070.887 |  3236.946 |
| YGroup4ZipBenchmark_Int128   | Sum128Base_Basic          |   350.462 |  1304.716 |  2946.745 |
| YGroup4ZipBenchmark_Int128   | Sum128Base                |   350.409 |  1293.228 |  2941.254 |
| YGroup4ZipBenchmark_Int128   | Sum128Traits              |  1345.230 |  1293.461 |  2939.879 |
| YGroup4ZipBenchmark_Int128   | Sum128Traits_Int128       |  3236.502 |  3235.218 |  3237.030 |
| YGroup4ZipBenchmark_Int128   | Sum256Base_Basic          |   116.356 |   135.530 |   331.488 |
| YGroup4ZipBenchmark_Int128   | Sum256Base                |    66.399 |   111.953 |  6391.559 |
| YGroup4ZipBenchmark_Int128   | Sum256Avx2                |           |           |           |
| YGroup4ZipBenchmark_Int128   | Sum256Traits              |    53.168 |   114.897 |  6391.135 |
| YGroup4ZipBenchmark_Int128   | Sum256Traits_Int128       |   102.810 |   114.673 |  6390.599 |
| YGroup4ZipBenchmark_Int128   | Sum512Base_Basic          |           |           |   347.348 |
| YGroup4ZipBenchmark_Int128   | Sum512Base_Move           |           |           | 11454.688 |
| YGroup4ZipBenchmark_Int128   | Sum512Base_Zip            |           |           | 11452.205 |
| YGroup4ZipBenchmark_Int128   | Sum512Base                |           |           | 11452.774 |
| YGroup4ZipBenchmark_Int128   | Sum512Avx512              |           |           |           |
| YGroup4ZipBenchmark_Int128   | Sum512Traits              |           |           | 11452.215 |
| YGroup4ZipBenchmark_Int128   | Sum512Traits_Int128       |           |           | 11450.482 |
| YGroup4ZipBenchmark_Int16    | SumBase_Basic             |   523.235 |   779.550 |   649.632 |
| YGroup4ZipBenchmark_Int16    | SumBase_Widen             |           |  2176.307 |  2176.909 |
| YGroup4ZipBenchmark_Int16    | SumBase_Zip               |  2720.480 |  3271.931 |  3597.236 |
| YGroup4ZipBenchmark_Int16    | SumBase                   |  2720.413 |  3272.469 |  3597.160 |
| YGroup4ZipBenchmark_Int16    | SumTraits                 | 10869.472 | 10870.117 | 10870.869 |
| YGroup4ZipBenchmark_Int16    | Sum128Base_Basic          |   334.043 |   779.497 |   649.683 |
| YGroup4ZipBenchmark_Int16    | Sum128Base_Widen          |           |   502.776 |  2103.236 |
| YGroup4ZipBenchmark_Int16    | Sum128Base_Zip            |           |   752.574 |  3297.168 |
| YGroup4ZipBenchmark_Int16    | Sum128Base                |   333.806 |   751.279 |  3297.263 |
| YGroup4ZipBenchmark_Int16    | Sum128AdvSimd_ShuffleX    |           |           |  2558.932 |
| YGroup4ZipBenchmark_Int16    | Sum128AdvSimd_Widen       |  2220.336 |  2176.237 |  2176.243 |
| YGroup4ZipBenchmark_Int16    | Sum128AdvSimd_Zip         |  3296.733 |  3271.916 |  3596.824 |
| YGroup4ZipBenchmark_Int16    | Sum128AdvSimdB64_ShuffleX |           |           |  6446.506 |
| YGroup4ZipBenchmark_Int16    | Sum128AdvSimdB64_Zip      | 10869.243 | 10867.613 | 10871.911 |
| YGroup4ZipBenchmark_Int16    | Sum128PackedSimd_Zip      |           |           |           |
| YGroup4ZipBenchmark_Int16    | Sum128Sse_Permute         |           |           |           |
| YGroup4ZipBenchmark_Int16    | Sum128Sse_Widen           |           |           |           |
| YGroup4ZipBenchmark_Int16    | Sum128Sse_Zip             |           |           |           |
| YGroup4ZipBenchmark_Int16    | Sum128Traits              | 10869.357 | 10869.847 | 10871.877 |
| YGroup4ZipBenchmark_Int16    | Sum256Base_Basic          |   272.101 |   272.616 |   685.970 |
| YGroup4ZipBenchmark_Int16    | Sum256Base_Widen          |           |    57.611 |  2391.693 |
| YGroup4ZipBenchmark_Int16    | Sum256Base_Zip            |           |   185.580 |   313.743 |
| YGroup4ZipBenchmark_Int16    | Sum256Base                |   267.187 |   276.257 |   686.119 |
| YGroup4ZipBenchmark_Int16    | Sum256Avx2_Permute        |           |           |           |
| YGroup4ZipBenchmark_Int16    | Sum256Avx2_Widen          |           |           |           |
| YGroup4ZipBenchmark_Int16    | Sum256Avx2_Unpack         |           |           |           |
| YGroup4ZipBenchmark_Int16    | Sum256Avx2_Zip            |           |           |           |
| YGroup4ZipBenchmark_Int16    | Sum256Traits              |   248.245 |   276.454 |   686.123 |
| YGroup4ZipBenchmark_Int16    | Sum512Base_Basic          |           |           |   652.715 |
| YGroup4ZipBenchmark_Int16    | Sum512Base_Widen          |           |           |   258.976 |
| YGroup4ZipBenchmark_Int16    | Sum512Base_Zip            |           |           |   306.637 |
| YGroup4ZipBenchmark_Int16    | Sum512Base                |           |           |   652.533 |
| YGroup4ZipBenchmark_Int16    | Sum512Avx512_Widen        |           |           |           |
| YGroup4ZipBenchmark_Int16    | Sum512Avx512_Unpack       |           |           |           |
| YGroup4ZipBenchmark_Int16    | Sum512Avx512_Zip          |           |           |           |
| YGroup4ZipBenchmark_Int16    | Sum512Traits              |           |           |   652.232 |
| YGroup4ZipBenchmark_Int32    | SumBase_Basic             |   438.779 |   593.563 |   519.731 |
| YGroup4ZipBenchmark_Int32    | SumBase_Zip               |   192.934 |  1636.398 |  1798.616 |
| YGroup4ZipBenchmark_Int32    | SumBase                   |   438.743 |  1636.411 |  1799.112 |
| YGroup4ZipBenchmark_Int32    | SumTraits                 |  5438.546 |  5438.384 |  5437.779 |
| YGroup4ZipBenchmark_Int32    | Sum128Base_Basic          |   279.532 |   593.717 |   521.741 |
| YGroup4ZipBenchmark_Int32    | Sum128Base_Zip            |           |   376.030 |  1813.714 |
| YGroup4ZipBenchmark_Int32    | Sum128Base                |   272.649 |   376.294 |  1813.617 |
| YGroup4ZipBenchmark_Int32    | Sum128AdvSimd_ShuffleX    |           |           |  1265.620 |
| YGroup4ZipBenchmark_Int32    | Sum128AdvSimd_Zip         |  1648.886 |  1636.402 |  1798.600 |
| YGroup4ZipBenchmark_Int32    | Sum128AdvSimdB64_ShuffleX |           |           |  3215.429 |
| YGroup4ZipBenchmark_Int32    | Sum128AdvSimdB64_Zip      |  5437.854 |  5438.627 |  5438.066 |
| YGroup4ZipBenchmark_Int32    | Sum128PackedSimd_Zip      |           |           |           |
| YGroup4ZipBenchmark_Int32    | Sum128Sse_Permute         |           |           |           |
| YGroup4ZipBenchmark_Int32    | Sum128Sse_Zip             |           |           |           |
| YGroup4ZipBenchmark_Int32    | Sum128Traits              |  5437.194 |  5439.129 |  5438.142 |
| YGroup4ZipBenchmark_Int32    | Sum256Base_Basic          |   192.851 |   194.148 |   574.673 |
| YGroup4ZipBenchmark_Int32    | Sum256Base_Zip            |           |   129.356 |   264.428 |
| YGroup4ZipBenchmark_Int32    | Sum256Base                |   189.103 |   194.070 |   574.763 |
| YGroup4ZipBenchmark_Int32    | Sum256Avx2_Permute        |           |           |           |
| YGroup4ZipBenchmark_Int32    | Sum256Avx2_Unpack         |           |           |           |
| YGroup4ZipBenchmark_Int32    | Sum256Avx2_Zip            |           |           |           |
| YGroup4ZipBenchmark_Int32    | Sum256Traits              |   158.668 |   194.817 |   574.627 |
| YGroup4ZipBenchmark_Int32    | Sum512Base_Basic          |           |           |   527.651 |
| YGroup4ZipBenchmark_Int32    | Sum512Base_Zip            |           |           |   252.734 |
| YGroup4ZipBenchmark_Int32    | Sum512Base                |           |           |   528.242 |
| YGroup4ZipBenchmark_Int32    | Sum512Avx512_Unpack       |           |           |           |
| YGroup4ZipBenchmark_Int32    | Sum512Avx512_Zip          |           |           |           |
| YGroup4ZipBenchmark_Int32    | Sum512Traits              |           |           |   528.127 |
| YGroup4ZipBenchmark_Int64    | SumBase_Basic             |   407.218 |   402.990 |   402.332 |
| YGroup4ZipBenchmark_Int64    | SumBase                   |   408.183 |   403.306 |   400.718 |
| YGroup4ZipBenchmark_Int64    | SumTraits                 |  3323.062 |  3327.671 |  3328.345 |
| YGroup4ZipBenchmark_Int64    | Sum128Base_Basic          |   212.574 |   403.072 |   406.229 |
| YGroup4ZipBenchmark_Int64    | Sum128Base_Move           |           |  2217.855 |  3361.925 |
| YGroup4ZipBenchmark_Int64    | Sum128Base_Zip            |           |  2579.837 |  3400.758 |
| YGroup4ZipBenchmark_Int64    | Sum128Base                |   410.562 |  2580.797 |  3400.644 |
| YGroup4ZipBenchmark_Int64    | Sum128AdvSimd_ShuffleX    |           |           |   619.517 |
| YGroup4ZipBenchmark_Int64    | Sum128AdvSimd_Zip         |  2719.877 |  2720.231 |  3022.540 |
| YGroup4ZipBenchmark_Int64    | Sum128AdvSimdB64_ShuffleX |           |           |  1578.423 |
| YGroup4ZipBenchmark_Int64    | Sum128AdvSimdB64_Zip      |  3322.445 |  3327.549 |  3327.889 |
| YGroup4ZipBenchmark_Int64    | Sum128PackedSimd_Zip      |           |           |           |
| YGroup4ZipBenchmark_Int64    | Sum128Sse_Permute         |           |           |           |
| YGroup4ZipBenchmark_Int64    | Sum128Sse_Zip             |           |           |           |
| YGroup4ZipBenchmark_Int64    | Sum128Traits              |  3322.864 |  3326.992 |  3328.129 |
| YGroup4ZipBenchmark_Int64    | Sum256Base_Basic          |   113.516 |   122.360 |   352.001 |
| YGroup4ZipBenchmark_Int64    | Sum256Base                |   113.076 |   122.410 |   352.036 |
| YGroup4ZipBenchmark_Int64    | Sum256Avx2_Permute        |           |           |           |
| YGroup4ZipBenchmark_Int64    | Sum256Avx2_Unpack         |           |           |           |
| YGroup4ZipBenchmark_Int64    | Sum256Avx2_Zip            |           |           |           |
| YGroup4ZipBenchmark_Int64    | Sum256Traits              |   113.173 |   121.682 |   351.667 |
| YGroup4ZipBenchmark_Int64    | Sum512Base_Basic          |           |           |   317.391 |
| YGroup4ZipBenchmark_Int64    | Sum512Base                |           |           |   317.394 |
| YGroup4ZipBenchmark_Int64    | Sum512Avx512_Unpack       |           |           |           |
| YGroup4ZipBenchmark_Int64    | Sum512Avx512_Zip          |           |           |           |
| YGroup4ZipBenchmark_Int64    | Sum512Traits              |           |           |   317.588 |

### Arm - AWS Arm t4g.small
| Type                         | Method                    | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 | .NET 8.0 |
| :--------------------------- | :------------------------ | ------------: | -------: | -------: | -------: | -------: |
| YGroup4UnzipBenchmark_Byte   | SumBase_Basic             |       207.935 |          |  211.012 |  255.537 |  271.577 |
| YGroup4UnzipBenchmark_Byte   | SumBase_Narrow            |               |          |          | 1967.675 | 2641.844 |
| YGroup4UnzipBenchmark_Byte   | SumBase_Unzip             |       456.414 |          |  524.261 | 2858.096 | 3308.780 |
| YGroup4UnzipBenchmark_Byte   | SumBase                   |       458.460 |          |  524.245 | 2849.434 | 3308.520 |
| YGroup4UnzipBenchmark_Byte   | SumTraits                 |       455.448 |          | 6535.359 | 6418.487 | 6600.189 |
| YGroup4UnzipBenchmark_Byte   | Sum128Base_Basic          |        99.783 |          |  113.225 |  255.632 |  271.681 |
| YGroup4UnzipBenchmark_Byte   | Sum128Base_Narrow         |               |          |          | 1974.361 | 2642.283 |
| YGroup4UnzipBenchmark_Byte   | Sum128Base_Unzip          |               |          |          | 2857.316 | 3309.106 |
| YGroup4UnzipBenchmark_Byte   | Sum128Base                |        99.522 |          |  112.985 | 2859.716 | 3309.015 |
| YGroup4UnzipBenchmark_Byte   | Sum128AdvSimd_Narrow      |               |          | 1939.874 | 1966.841 | 2643.154 |
| YGroup4UnzipBenchmark_Byte   | Sum128AdvSimd_ShuffleX    |               |          |          |          | 1659.946 |
| YGroup4UnzipBenchmark_Byte   | Sum128AdvSimd_Unzip       |               |          | 2920.055 | 2848.322 | 3309.047 |
| YGroup4UnzipBenchmark_Byte   | Sum128AdvSimdB64_ShuffleX |               |          |          |          | 3969.605 |
| YGroup4UnzipBenchmark_Byte   | Sum128AdvSimdB64_Unzip    |               |          | 6562.346 | 6419.013 | 6598.490 |
| YGroup4UnzipBenchmark_Byte   | Sum128PackedSimd_Unzip    |               |          |          |          |          |
| YGroup4UnzipBenchmark_Byte   | Sum128Sse_Permute         |               |          |          |          |          |
| YGroup4UnzipBenchmark_Byte   | Sum128Sse_Narrow          |               |          |          |          |          |
| YGroup4UnzipBenchmark_Byte   | Sum128Sse_Unpack          |               |          |          |          |          |
| YGroup4UnzipBenchmark_Byte   | Sum128Sse_Unzip           |               |          |          |          |          |
| YGroup4UnzipBenchmark_Byte   | Sum128Traits              |        99.771 |          | 6542.225 | 6386.064 | 6600.112 |
| YGroup4UnzipBenchmark_Byte   | Sum256Base_Basic          |       100.867 |          |  118.060 |  103.234 |  307.362 |
| YGroup4UnzipBenchmark_Byte   | Sum256Base_Narrow         |               |          |          |   47.873 | 2682.591 |
| YGroup4UnzipBenchmark_Byte   | Sum256Base_Unzip          |               |          |          |   72.162 |  136.925 |
| YGroup4UnzipBenchmark_Byte   | Sum256Base                |        98.460 |          |  117.439 |  103.691 |  307.164 |
| YGroup4UnzipBenchmark_Byte   | Sum256Avx2_Permute        |               |          |          |          |          |
| YGroup4UnzipBenchmark_Byte   | Sum256Avx2_Narrow         |               |          |          |          |          |
| YGroup4UnzipBenchmark_Byte   | Sum256Avx2_Unpack         |               |          |          |          |          |
| YGroup4UnzipBenchmark_Byte   | Sum256Avx2_Unzip          |               |          |          |          |          |
| YGroup4UnzipBenchmark_Byte   | Sum256Traits              |        92.125 |          |  110.974 |  103.698 |  307.263 |
| YGroup4UnzipBenchmark_Byte   | Sum512Base_Basic          |               |          |          |          |  333.752 |
| YGroup4UnzipBenchmark_Byte   | Sum512Base_Narrow         |               |          |          |          | 2837.962 |
| YGroup4UnzipBenchmark_Byte   | Sum512Base_Unzip          |               |          |          |          |  141.165 |
| YGroup4UnzipBenchmark_Byte   | Sum512Base                |               |          |          |          |  333.657 |
| YGroup4UnzipBenchmark_Byte   | Sum512Avx512_Permute      |               |          |          |          |          |
| YGroup4UnzipBenchmark_Byte   | Sum512Avx512_Narrow       |               |          |          |          |          |
| YGroup4UnzipBenchmark_Byte   | Sum512Avx512_Unpack       |               |          |          |          |          |
| YGroup4UnzipBenchmark_Byte   | Sum512Avx512_Unzip        |               |          |          |          |          |
| YGroup4UnzipBenchmark_Byte   | Sum512Traits              |               |          |          |          |  333.488 |
| YGroup4UnzipBenchmark_Int128 | SumBase_Basic             |        35.412 |          |   80.065 |   67.542 |  133.985 |
| YGroup4UnzipBenchmark_Int128 | SumBase                   |        33.379 |          |   81.698 |   66.102 |  136.872 |
| YGroup4UnzipBenchmark_Int128 | SumTraits                 |        30.175 |          |   80.915 |   84.438 |  142.988 |
| YGroup4UnzipBenchmark_Int128 | SumTraits_Int128          |       191.718 |          |  443.242 |  432.674 | 2087.561 |
| YGroup4UnzipBenchmark_Int128 | Sum128Base_Basic          |       119.639 |          |  120.944 |  493.774 |  680.145 |
| YGroup4UnzipBenchmark_Int128 | Sum128Base                |       120.403 |          |  117.658 |  494.304 |  678.870 |
| YGroup4UnzipBenchmark_Int128 | Sum128Traits              |       117.953 |          |  495.470 |  494.561 |  679.168 |
| YGroup4UnzipBenchmark_Int128 | Sum128Traits_Int128       |       135.696 |          | 1649.746 | 2115.910 | 2092.196 |
| YGroup4UnzipBenchmark_Int128 | Sum256Base_Basic          |        28.707 |          |   41.413 |   50.357 |  175.799 |
| YGroup4UnzipBenchmark_Int128 | Sum256Base                |        19.354 |          |   22.629 |   50.968 | 3347.706 |
| YGroup4UnzipBenchmark_Int128 | Sum256Avx2                |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int128 | Sum256Traits              |        15.774 |          |   18.161 |   50.971 | 3358.608 |
| YGroup4UnzipBenchmark_Int128 | Sum256Traits_Int128       |        28.054 |          |   36.338 |   51.009 | 3354.869 |
| YGroup4UnzipBenchmark_Int128 | Sum512Base_Basic          |               |          |          |          |  187.952 |
| YGroup4UnzipBenchmark_Int128 | Sum512Base_Move           |               |          |          |          | 3705.827 |
| YGroup4UnzipBenchmark_Int128 | Sum512Base_Unzip          |               |          |          |          | 3677.618 |
| YGroup4UnzipBenchmark_Int128 | Sum512Base                |               |          |          |          | 3684.613 |
| YGroup4UnzipBenchmark_Int128 | Sum512Avx512              |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int128 | Sum512Traits              |               |          |          |          | 3713.386 |
| YGroup4UnzipBenchmark_Int128 | Sum512Traits_Int128       |               |          |          |          | 3707.026 |
| YGroup4UnzipBenchmark_Int16  | SumBase_Basic             |       149.389 |          |  150.329 |  179.346 |  209.965 |
| YGroup4UnzipBenchmark_Int16  | SumBase_Narrow            |               |          |          |  995.330 | 1267.781 |
| YGroup4UnzipBenchmark_Int16  | SumBase_Unzip             |       414.784 |          |  478.940 | 1427.459 | 1604.720 |
| YGroup4UnzipBenchmark_Int16  | SumBase                   |       413.433 |          |  476.675 | 1428.209 | 1605.104 |
| YGroup4UnzipBenchmark_Int16  | SumTraits                 |       414.012 |          | 3130.351 | 3302.669 | 3195.761 |
| YGroup4UnzipBenchmark_Int16  | Sum128Base_Basic          |        71.988 |          |   77.691 |  179.501 |  209.935 |
| YGroup4UnzipBenchmark_Int16  | Sum128Base_Narrow         |               |          |          |  994.906 | 1267.439 |
| YGroup4UnzipBenchmark_Int16  | Sum128Base_Unzip          |               |          |          | 1426.839 | 1599.101 |
| YGroup4UnzipBenchmark_Int16  | Sum128Base                |        71.864 |          |   77.119 | 1421.565 | 1598.762 |
| YGroup4UnzipBenchmark_Int16  | Sum128AdvSimd_Narrow      |               |          |  951.047 |  994.869 | 1261.779 |
| YGroup4UnzipBenchmark_Int16  | Sum128AdvSimd_ShuffleX    |               |          |          |          |  826.125 |
| YGroup4UnzipBenchmark_Int16  | Sum128AdvSimd_Unzip       |               |          | 1401.955 | 1422.973 | 1603.927 |
| YGroup4UnzipBenchmark_Int16  | Sum128AdvSimdB64_ShuffleX |               |          |          |          | 1918.800 |
| YGroup4UnzipBenchmark_Int16  | Sum128AdvSimdB64_Unzip    |               |          | 3146.197 | 3297.866 | 3215.840 |
| YGroup4UnzipBenchmark_Int16  | Sum128PackedSimd_Unzip    |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int16  | Sum128Sse_Permute         |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int16  | Sum128Sse_Narrow          |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int16  | Sum128Sse_Unpack          |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int16  | Sum128Sse_Unzip           |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int16  | Sum128Traits              |        71.588 |          | 3122.580 | 3300.219 | 3211.973 |
| YGroup4UnzipBenchmark_Int16  | Sum256Base_Basic          |        68.120 |          |   85.972 |   74.663 |  234.235 |
| YGroup4UnzipBenchmark_Int16  | Sum256Base_Narrow         |               |          |          |   40.445 | 1327.441 |
| YGroup4UnzipBenchmark_Int16  | Sum256Base_Unzip          |               |          |          |   51.772 |  105.543 |
| YGroup4UnzipBenchmark_Int16  | Sum256Base                |        67.141 |          |   85.633 |   74.349 |  234.023 |
| YGroup4UnzipBenchmark_Int16  | Sum256Avx2_Permute        |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int16  | Sum256Avx2_Narrow         |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int16  | Sum256Avx2_Unpack         |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int16  | Sum256Avx2_Unzip          |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int16  | Sum256Traits              |        59.540 |          |   79.708 |   74.340 |  234.068 |
| YGroup4UnzipBenchmark_Int16  | Sum512Base_Basic          |               |          |          |          |  256.405 |
| YGroup4UnzipBenchmark_Int16  | Sum512Base_Narrow         |               |          |          |          | 1389.843 |
| YGroup4UnzipBenchmark_Int16  | Sum512Base_Unzip          |               |          |          |          |  106.069 |
| YGroup4UnzipBenchmark_Int16  | Sum512Base                |               |          |          |          |  256.126 |
| YGroup4UnzipBenchmark_Int16  | Sum512Avx512_Permute      |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int16  | Sum512Avx512_Narrow       |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int16  | Sum512Avx512_Unpack       |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int16  | Sum512Avx512_Unzip        |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int16  | Sum512Traits              |               |          |          |          |  254.258 |
| YGroup4UnzipBenchmark_Int32  | SumBase_Basic             |       113.315 |          |  116.682 |  123.281 |  150.141 |
| YGroup4UnzipBenchmark_Int32  | SumBase_Unzip             |       195.301 |          |  237.817 |  720.080 |  785.560 |
| YGroup4UnzipBenchmark_Int32  | SumBase                   |       194.948 |          |  237.396 |  720.373 |  789.755 |
| YGroup4UnzipBenchmark_Int32  | SumTraits                 |       195.179 |          | 1581.791 | 1648.131 | 1563.229 |
| YGroup4UnzipBenchmark_Int32  | Sum128Base_Basic          |        49.701 |          |   52.736 |  125.112 |  150.045 |
| YGroup4UnzipBenchmark_Int32  | Sum128Base_Unzip          |               |          |          |  714.360 |  791.941 |
| YGroup4UnzipBenchmark_Int32  | Sum128Base                |        49.909 |          |   53.278 |  713.902 |  791.032 |
| YGroup4UnzipBenchmark_Int32  | Sum128AdvSimd_ShuffleX    |               |          |          |          |  412.848 |
| YGroup4UnzipBenchmark_Int32  | Sum128AdvSimd_Unzip       |               |          |  699.406 |  715.782 |  791.471 |
| YGroup4UnzipBenchmark_Int32  | Sum128AdvSimdB64_ShuffleX |               |          |          |          |  974.935 |
| YGroup4UnzipBenchmark_Int32  | Sum128AdvSimdB64_Unzip    |               |          | 1565.891 | 1647.007 | 1603.566 |
| YGroup4UnzipBenchmark_Int32  | Sum128PackedSimd_Unzip    |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int32  | Sum128Sse_Permute         |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int32  | Sum128Sse_Unpack          |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int32  | Sum128Sse_Unzip           |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int32  | Sum128Traits              |        49.973 |          | 1573.098 | 1646.755 | 1602.045 |
| YGroup4UnzipBenchmark_Int32  | Sum256Base_Basic          |        44.950 |          |   57.514 |   57.619 |  200.076 |
| YGroup4UnzipBenchmark_Int32  | Sum256Base_Unzip          |               |          |          |   39.192 |   88.433 |
| YGroup4UnzipBenchmark_Int32  | Sum256Base                |        43.707 |          |   57.296 |   57.545 |  199.751 |
| YGroup4UnzipBenchmark_Int32  | Sum256Avx2_Permute        |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int32  | Sum256Avx2_Unpack         |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int32  | Sum256Avx2_Unzip          |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int32  | Sum256Traits              |        37.655 |          |   56.925 |   57.602 |  200.008 |
| YGroup4UnzipBenchmark_Int32  | Sum512Base_Basic          |               |          |          |          |  222.241 |
| YGroup4UnzipBenchmark_Int32  | Sum512Base_Unzip          |               |          |          |          |  100.269 |
| YGroup4UnzipBenchmark_Int32  | Sum512Base                |               |          |          |          |  221.692 |
| YGroup4UnzipBenchmark_Int32  | Sum512Avx512_Permute      |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int32  | Sum512Avx512_Unpack       |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int32  | Sum512Avx512_Unzip        |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int32  | Sum512Traits              |               |          |          |          |  222.201 |
| YGroup4UnzipBenchmark_Int64  | SumBase_Basic             |        91.365 |          |   86.635 |   76.035 |  163.815 |
| YGroup4UnzipBenchmark_Int64  | SumBase                   |        91.456 |          |   86.603 |   75.699 |  158.025 |
| YGroup4UnzipBenchmark_Int64  | SumTraits                 |        90.910 |          | 1190.596 | 1232.980 | 1220.719 |
| YGroup4UnzipBenchmark_Int64  | Sum128Base_Basic          |        49.459 |          |   56.053 |   75.797 |  164.218 |
| YGroup4UnzipBenchmark_Int64  | Sum128Base_Move           |               |          |          |  709.405 |  967.651 |
| YGroup4UnzipBenchmark_Int64  | Sum128Base_Unzip          |               |          |          |  708.888 |  885.498 |
| YGroup4UnzipBenchmark_Int64  | Sum128Base                |        67.160 |          |  131.643 |  708.801 |  885.285 |
| YGroup4UnzipBenchmark_Int64  | Sum128AdvSimd_ShuffleX    |               |          |          |          |  206.490 |
| YGroup4UnzipBenchmark_Int64  | Sum128AdvSimd_Unzip       |               |          |  949.763 |  988.262 |  967.705 |
| YGroup4UnzipBenchmark_Int64  | Sum128AdvSimdB64_ShuffleX |               |          |          |          |  484.215 |
| YGroup4UnzipBenchmark_Int64  | Sum128AdvSimdB64_Unzip    |               |          | 1177.820 | 1235.188 | 1220.164 |
| YGroup4UnzipBenchmark_Int64  | Sum128PackedSimd_Unzip    |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int64  | Sum128Sse_Permute         |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int64  | Sum128Sse_Unpack          |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int64  | Sum128Sse_Unzip           |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int64  | Sum128Traits              |        67.314 |          | 1191.313 | 1234.496 | 1219.452 |
| YGroup4UnzipBenchmark_Int64  | Sum256Base_Basic          |        29.415 |          |   42.189 |   44.708 |  173.116 |
| YGroup4UnzipBenchmark_Int64  | Sum256Base                |        28.574 |          |   42.062 |   44.352 |  173.188 |
| YGroup4UnzipBenchmark_Int64  | Sum256Avx2_Permute        |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int64  | Sum256Avx2_Unpack         |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int64  | Sum256Avx2_Unzip          |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int64  | Sum256Traits              |        23.197 |          |   42.379 |   44.479 |  173.207 |
| YGroup4UnzipBenchmark_Int64  | Sum512Base_Basic          |               |          |          |          |  158.332 |
| YGroup4UnzipBenchmark_Int64  | Sum512Base                |               |          |          |          |  158.265 |
| YGroup4UnzipBenchmark_Int64  | Sum512Avx512_Permute      |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int64  | Sum512Avx512_Unpack       |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int64  | Sum512Avx512_Unzip        |               |          |          |          |          |
| YGroup4UnzipBenchmark_Int64  | Sum512Traits              |               |          |          |          |  157.845 |
| YGroup4ZipBenchmark_Byte     | SumBase_Basic             |       219.437 |          |  223.671 |  337.982 |  271.798 |
| YGroup4ZipBenchmark_Byte     | SumBase_Widen             |               |          |          | 1092.107 | 1095.326 |
| YGroup4ZipBenchmark_Byte     | SumBase_Zip               |      1267.779 |          | 1490.353 | 1633.814 | 1694.249 |
| YGroup4ZipBenchmark_Byte     | SumBase                   |      1269.255 |          | 1373.638 | 1619.867 | 1694.025 |
| YGroup4ZipBenchmark_Byte     | SumTraits                 |      1268.518 |          | 6528.782 | 6338.551 | 6531.924 |
| YGroup4ZipBenchmark_Byte     | Sum128Base_Basic          |       118.896 |          |  119.629 |  337.981 |  271.778 |
| YGroup4ZipBenchmark_Byte     | Sum128Base_Widen          |               |          |          |  217.711 | 1048.623 |
| YGroup4ZipBenchmark_Byte     | Sum128Base_Zip            |               |          |          |  462.174 | 1623.505 |
| YGroup4ZipBenchmark_Byte     | Sum128Base                |       118.863 |          |  119.658 |  464.271 | 1620.798 |
| YGroup4ZipBenchmark_Byte     | Sum128AdvSimd_ShuffleX    |               |          |          |          | 1660.076 |
| YGroup4ZipBenchmark_Byte     | Sum128AdvSimd_Widen       |               |          | 1125.025 | 1096.460 | 1106.530 |
| YGroup4ZipBenchmark_Byte     | Sum128AdvSimd_Zip         |               |          | 1606.053 | 1629.574 | 1694.413 |
| YGroup4ZipBenchmark_Byte     | Sum128AdvSimdB64_ShuffleX |               |          |          |          | 3969.956 |
| YGroup4ZipBenchmark_Byte     | Sum128AdvSimdB64_Zip      |               |          | 6544.011 | 6349.519 | 6552.449 |
| YGroup4ZipBenchmark_Byte     | Sum128PackedSimd_Zip      |               |          |          |          |          |
| YGroup4ZipBenchmark_Byte     | Sum128Sse_Permute         |               |          |          |          |          |
| YGroup4ZipBenchmark_Byte     | Sum128Sse_Widen           |               |          |          |          |          |
| YGroup4ZipBenchmark_Byte     | Sum128Sse_Zip             |               |          |          |          |          |
| YGroup4ZipBenchmark_Byte     | Sum128Traits              |       118.868 |          | 6561.612 | 6423.472 | 6551.751 |
| YGroup4ZipBenchmark_Byte     | Sum256Base_Basic          |       121.850 |          |  119.809 |  113.390 |  276.940 |
| YGroup4ZipBenchmark_Byte     | Sum256Base_Widen          |               |          |          |   34.064 | 1122.481 |
| YGroup4ZipBenchmark_Byte     | Sum256Base_Zip            |               |          |          |   74.836 |  121.027 |
| YGroup4ZipBenchmark_Byte     | Sum256Base                |       119.371 |          |  116.637 |  112.884 |  276.719 |
| YGroup4ZipBenchmark_Byte     | Sum256Avx2_Permute        |               |          |          |          |          |
| YGroup4ZipBenchmark_Byte     | Sum256Avx2_Widen          |               |          |          |          |          |
| YGroup4ZipBenchmark_Byte     | Sum256Avx2_Unpack         |               |          |          |          |          |
| YGroup4ZipBenchmark_Byte     | Sum256Avx2_Zip            |               |          |          |          |          |
| YGroup4ZipBenchmark_Byte     | Sum256Traits              |       108.766 |          |  110.148 |  112.931 |  276.736 |
| YGroup4ZipBenchmark_Byte     | Sum512Base_Basic          |               |          |          |          |  268.988 |
| YGroup4ZipBenchmark_Byte     | Sum512Base_Widen          |               |          |          |          |  249.508 |
| YGroup4ZipBenchmark_Byte     | Sum512Base_Zip            |               |          |          |          |  117.889 |
| YGroup4ZipBenchmark_Byte     | Sum512Base                |               |          |          |          |  268.772 |
| YGroup4ZipBenchmark_Byte     | Sum512Avx512_Widen        |               |          |          |          |          |
| YGroup4ZipBenchmark_Byte     | Sum512Avx512_Unpack       |               |          |          |          |          |
| YGroup4ZipBenchmark_Byte     | Sum512Avx512_Zip          |               |          |          |          |          |
| YGroup4ZipBenchmark_Byte     | Sum512Traits              |               |          |          |          |  268.815 |
| YGroup4ZipBenchmark_Int128   | SumBase_Basic             |        48.752 |          |  112.100 |  100.131 |  119.356 |
| YGroup4ZipBenchmark_Int128   | SumBase                   |        46.303 |          |  112.484 |  110.079 |  119.377 |
| YGroup4ZipBenchmark_Int128   | SumTraits                 |        40.680 |          |  112.245 |   84.620 |  143.254 |
| YGroup4ZipBenchmark_Int128   | SumTraits_Int128          |       191.244 |          |  428.122 |  434.721 | 2094.331 |
| YGroup4ZipBenchmark_Int128   | Sum128Base_Basic          |       119.951 |          |  120.418 |  494.904 |  682.652 |
| YGroup4ZipBenchmark_Int128   | Sum128Base                |       117.241 |          |  120.968 |  495.196 |  677.507 |
| YGroup4ZipBenchmark_Int128   | Sum128Traits              |       120.095 |          |  495.383 |  495.204 |  687.637 |
| YGroup4ZipBenchmark_Int128   | Sum128Traits_Int128       |       136.157 |          | 1786.603 | 2120.890 | 2092.521 |
| YGroup4ZipBenchmark_Int128   | Sum256Base_Basic          |        34.129 |          |   37.127 |   58.367 |  137.971 |
| YGroup4ZipBenchmark_Int128   | Sum256Base                |        19.344 |          |   22.840 |   50.743 | 3369.152 |
| YGroup4ZipBenchmark_Int128   | Sum256Avx2                |               |          |          |          |          |
| YGroup4ZipBenchmark_Int128   | Sum256Traits              |        15.709 |          |   18.243 |   50.736 | 3390.667 |
| YGroup4ZipBenchmark_Int128   | Sum256Traits_Int128       |        27.882 |          |   36.692 |   50.761 | 3371.853 |
| YGroup4ZipBenchmark_Int128   | Sum512Base_Basic          |               |          |          |          |  145.487 |
| YGroup4ZipBenchmark_Int128   | Sum512Base_Move           |               |          |          |          | 3704.817 |
| YGroup4ZipBenchmark_Int128   | Sum512Base_Zip            |               |          |          |          | 3711.438 |
| YGroup4ZipBenchmark_Int128   | Sum512Base                |               |          |          |          | 3707.572 |
| YGroup4ZipBenchmark_Int128   | Sum512Avx512              |               |          |          |          |          |
| YGroup4ZipBenchmark_Int128   | Sum512Traits              |               |          |          |          | 3715.637 |
| YGroup4ZipBenchmark_Int128   | Sum512Traits_Int128       |               |          |          |          | 3710.016 |
| YGroup4ZipBenchmark_Int16    | SumBase_Basic             |       168.839 |          |  173.810 |  251.704 |  230.223 |
| YGroup4ZipBenchmark_Int16    | SumBase_Widen             |               |          |          |  548.351 |  550.751 |
| YGroup4ZipBenchmark_Int16    | SumBase_Zip               |       635.235 |          |  710.325 |  804.174 |  845.531 |
| YGroup4ZipBenchmark_Int16    | SumBase                   |       635.411 |          |  706.791 |  802.077 |  845.548 |
| YGroup4ZipBenchmark_Int16    | SumTraits                 |       635.252 |          | 3163.915 | 3262.679 | 3227.316 |
| YGroup4ZipBenchmark_Int16    | Sum128Base_Basic          |        81.008 |          |   85.226 |  251.912 |  230.131 |
| YGroup4ZipBenchmark_Int16    | Sum128Base_Widen          |               |          |          |  109.003 |  524.307 |
| YGroup4ZipBenchmark_Int16    | Sum128Base_Zip            |               |          |          |  231.596 |  806.157 |
| YGroup4ZipBenchmark_Int16    | Sum128Base                |        79.680 |          |   84.143 |  233.119 |  809.271 |
| YGroup4ZipBenchmark_Int16    | Sum128AdvSimd_ShuffleX    |               |          |          |          |  826.119 |
| YGroup4ZipBenchmark_Int16    | Sum128AdvSimd_Widen       |               |          |  499.779 |  548.745 |  550.378 |
| YGroup4ZipBenchmark_Int16    | Sum128AdvSimd_Zip         |               |          |  807.871 |  801.031 |  845.195 |
| YGroup4ZipBenchmark_Int16    | Sum128AdvSimdB64_ShuffleX |               |          |          |          | 1919.435 |
| YGroup4ZipBenchmark_Int16    | Sum128AdvSimdB64_Zip      |               |          | 3182.182 | 3293.917 | 3172.597 |
| YGroup4ZipBenchmark_Int16    | Sum128PackedSimd_Zip      |               |          |          |          |          |
| YGroup4ZipBenchmark_Int16    | Sum128Sse_Permute         |               |          |          |          |          |
| YGroup4ZipBenchmark_Int16    | Sum128Sse_Widen           |               |          |          |          |          |
| YGroup4ZipBenchmark_Int16    | Sum128Sse_Zip             |               |          |          |          |          |
| YGroup4ZipBenchmark_Int16    | Sum128Traits              |        79.766 |          | 3222.778 | 3279.995 | 3187.808 |
| YGroup4ZipBenchmark_Int16    | Sum256Base_Basic          |        76.630 |          |   82.956 |   85.810 |  223.378 |
| YGroup4ZipBenchmark_Int16    | Sum256Base_Widen          |               |          |          |   18.268 |  561.071 |
| YGroup4ZipBenchmark_Int16    | Sum256Base_Zip            |               |          |          |   58.048 |  101.530 |
| YGroup4ZipBenchmark_Int16    | Sum256Base                |        75.174 |          |   81.948 |   85.262 |  222.764 |
| YGroup4ZipBenchmark_Int16    | Sum256Avx2_Permute        |               |          |          |          |          |
| YGroup4ZipBenchmark_Int16    | Sum256Avx2_Widen          |               |          |          |          |          |
| YGroup4ZipBenchmark_Int16    | Sum256Avx2_Unpack         |               |          |          |          |          |
| YGroup4ZipBenchmark_Int16    | Sum256Avx2_Zip            |               |          |          |          |          |
| YGroup4ZipBenchmark_Int16    | Sum256Traits              |        65.898 |          |   76.870 |   85.272 |  223.072 |
| YGroup4ZipBenchmark_Int16    | Sum512Base_Basic          |               |          |          |          |  219.631 |
| YGroup4ZipBenchmark_Int16    | Sum512Base_Widen          |               |          |          |          |  113.913 |
| YGroup4ZipBenchmark_Int16    | Sum512Base_Zip            |               |          |          |          |  100.989 |
| YGroup4ZipBenchmark_Int16    | Sum512Base                |               |          |          |          |  219.062 |
| YGroup4ZipBenchmark_Int16    | Sum512Avx512_Widen        |               |          |          |          |          |
| YGroup4ZipBenchmark_Int16    | Sum512Avx512_Unpack       |               |          |          |          |          |
| YGroup4ZipBenchmark_Int16    | Sum512Avx512_Zip          |               |          |          |          |          |
| YGroup4ZipBenchmark_Int16    | Sum512Traits              |               |          |          |          |  219.986 |
| YGroup4ZipBenchmark_Int32    | SumBase_Basic             |       141.174 |          |  143.979 |  200.954 |  180.321 |
| YGroup4ZipBenchmark_Int32    | SumBase_Zip               |        64.975 |          |   61.430 |  404.768 |  421.951 |
| YGroup4ZipBenchmark_Int32    | SumBase                   |       141.157 |          |  143.660 |  404.099 |  422.036 |
| YGroup4ZipBenchmark_Int32    | SumTraits                 |       141.160 |          | 1598.046 | 1640.506 | 1581.989 |
| YGroup4ZipBenchmark_Int32    | Sum128Base_Basic          |        49.022 |          |   59.872 |  200.904 |  180.076 |
| YGroup4ZipBenchmark_Int32    | Sum128Base_Zip            |               |          |          |  116.427 |  422.092 |
| YGroup4ZipBenchmark_Int32    | Sum128Base                |        49.024 |          |   55.959 |  116.862 |  421.949 |
| YGroup4ZipBenchmark_Int32    | Sum128AdvSimd_ShuffleX    |               |          |          |          |  412.844 |
| YGroup4ZipBenchmark_Int32    | Sum128AdvSimd_Zip         |               |          |  398.287 |  404.091 |  421.949 |
| YGroup4ZipBenchmark_Int32    | Sum128AdvSimdB64_ShuffleX |               |          |          |          |  974.840 |
| YGroup4ZipBenchmark_Int32    | Sum128AdvSimdB64_Zip      |               |          | 1590.752 | 1640.138 | 1586.136 |
| YGroup4ZipBenchmark_Int32    | Sum128PackedSimd_Zip      |               |          |          |          |          |
| YGroup4ZipBenchmark_Int32    | Sum128Sse_Permute         |               |          |          |          |          |
| YGroup4ZipBenchmark_Int32    | Sum128Sse_Zip             |               |          |          |          |          |
| YGroup4ZipBenchmark_Int32    | Sum128Traits              |        49.101 |          | 1594.589 | 1643.313 | 1584.676 |
| YGroup4ZipBenchmark_Int32    | Sum256Base_Basic          |        51.656 |          |   58.022 |   67.448 |  173.476 |
| YGroup4ZipBenchmark_Int32    | Sum256Base_Zip            |               |          |          |   45.830 |   81.510 |
| YGroup4ZipBenchmark_Int32    | Sum256Base                |        50.227 |          |   57.905 |   67.423 |  173.378 |
| YGroup4ZipBenchmark_Int32    | Sum256Avx2_Permute        |               |          |          |          |          |
| YGroup4ZipBenchmark_Int32    | Sum256Avx2_Unpack         |               |          |          |          |          |
| YGroup4ZipBenchmark_Int32    | Sum256Avx2_Zip            |               |          |          |          |          |
| YGroup4ZipBenchmark_Int32    | Sum256Traits              |        42.523 |          |   50.013 |   67.416 |  173.331 |
| YGroup4ZipBenchmark_Int32    | Sum512Base_Basic          |               |          |          |          |  172.865 |
| YGroup4ZipBenchmark_Int32    | Sum512Base_Zip            |               |          |          |          |   82.738 |
| YGroup4ZipBenchmark_Int32    | Sum512Base                |               |          |          |          |  172.744 |
| YGroup4ZipBenchmark_Int32    | Sum512Avx512_Unpack       |               |          |          |          |          |
| YGroup4ZipBenchmark_Int32    | Sum512Avx512_Zip          |               |          |          |          |          |
| YGroup4ZipBenchmark_Int32    | Sum512Traits              |               |          |          |          |  172.712 |
| YGroup4ZipBenchmark_Int64    | SumBase_Basic             |       139.008 |          |  146.574 |  149.865 |  143.363 |
| YGroup4ZipBenchmark_Int64    | SumBase                   |       138.068 |          |  146.098 |  146.875 |  143.699 |
| YGroup4ZipBenchmark_Int64    | SumTraits                 |       138.017 |          | 1181.117 | 1233.472 | 1210.762 |
| YGroup4ZipBenchmark_Int64    | Sum128Base_Basic          |        65.680 |          |   70.733 |  146.834 |  143.805 |
| YGroup4ZipBenchmark_Int64    | Sum128Base_Move           |               |          |          |  708.719 |  968.466 |
| YGroup4ZipBenchmark_Int64    | Sum128Base_Zip            |               |          |          |  708.905 |  884.726 |
| YGroup4ZipBenchmark_Int64    | Sum128Base                |        67.114 |          |  130.148 |  709.093 |  884.080 |
| YGroup4ZipBenchmark_Int64    | Sum128AdvSimd_ShuffleX    |               |          |          |          |  206.460 |
| YGroup4ZipBenchmark_Int64    | Sum128AdvSimd_Zip         |               |          |  950.572 |  987.276 |  968.798 |
| YGroup4ZipBenchmark_Int64    | Sum128AdvSimdB64_ShuffleX |               |          |          |          |  488.149 |
| YGroup4ZipBenchmark_Int64    | Sum128AdvSimdB64_Zip      |               |          | 1182.431 | 1235.540 | 1211.747 |
| YGroup4ZipBenchmark_Int64    | Sum128PackedSimd_Zip      |               |          |          |          |          |
| YGroup4ZipBenchmark_Int64    | Sum128Sse_Permute         |               |          |          |          |          |
| YGroup4ZipBenchmark_Int64    | Sum128Sse_Zip             |               |          |          |          |          |
| YGroup4ZipBenchmark_Int64    | Sum128Traits              |        66.933 |          | 1180.949 | 1233.199 | 1211.497 |
| YGroup4ZipBenchmark_Int64    | Sum256Base_Basic          |        35.212 |          |   38.628 |   57.805 |  140.859 |
| YGroup4ZipBenchmark_Int64    | Sum256Base                |        33.970 |          |   38.808 |   57.742 |  140.799 |
| YGroup4ZipBenchmark_Int64    | Sum256Avx2_Permute        |               |          |          |          |          |
| YGroup4ZipBenchmark_Int64    | Sum256Avx2_Unpack         |               |          |          |          |          |
| YGroup4ZipBenchmark_Int64    | Sum256Avx2_Zip            |               |          |          |          |          |
| YGroup4ZipBenchmark_Int64    | Sum256Traits              |        26.710 |          |   38.759 |   58.146 |  140.827 |
| YGroup4ZipBenchmark_Int64    | Sum512Base_Basic          |               |          |          |          |  121.520 |
| YGroup4ZipBenchmark_Int64    | Sum512Base                |               |          |          |          |  121.489 |
| YGroup4ZipBenchmark_Int64    | Sum512Avx512_Unpack       |               |          |          |          |          |
| YGroup4ZipBenchmark_Int64    | Sum512Avx512_Zip          |               |          |          |          |          |
| YGroup4ZipBenchmark_Int64    | Sum512Traits              |               |          |          |          |  121.523 |

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                         | Method                    | .NET 8.0 |
| :--------------------------- | :------------------------ | -------: |
| YGroup4UnzipBenchmark_Byte   | SumBase_Basic             |    7.992 |
| YGroup4UnzipBenchmark_Byte   | SumBase_Narrow            |    2.712 |
| YGroup4UnzipBenchmark_Byte   | SumBase_Unzip             |    3.574 |
| YGroup4UnzipBenchmark_Byte   | SumBase                   |    8.148 |
| YGroup4UnzipBenchmark_Byte   | SumTraits                 |   32.607 |
| YGroup4UnzipBenchmark_Byte   | Sum128Base_Basic          |    7.934 |
| YGroup4UnzipBenchmark_Byte   | Sum128Base_Narrow         |    3.013 |
| YGroup4UnzipBenchmark_Byte   | Sum128Base_Unzip          |   50.306 |
| YGroup4UnzipBenchmark_Byte   | Sum128Base                |   50.448 |
| YGroup4UnzipBenchmark_Byte   | Sum128AdvSimd_Narrow      |          |
| YGroup4UnzipBenchmark_Byte   | Sum128AdvSimd_ShuffleX    |          |
| YGroup4UnzipBenchmark_Byte   | Sum128AdvSimd_Unzip       |          |
| YGroup4UnzipBenchmark_Byte   | Sum128AdvSimdB64_ShuffleX |          |
| YGroup4UnzipBenchmark_Byte   | Sum128AdvSimdB64_Unzip    |          |
| YGroup4UnzipBenchmark_Byte   | Sum128PackedSimd_Unzip    |   38.243 |
| YGroup4UnzipBenchmark_Byte   | Sum128Sse_Permute         |          |
| YGroup4UnzipBenchmark_Byte   | Sum128Sse_Narrow          |          |
| YGroup4UnzipBenchmark_Byte   | Sum128Sse_Unpack          |          |
| YGroup4UnzipBenchmark_Byte   | Sum128Sse_Unzip           |          |
| YGroup4UnzipBenchmark_Byte   | Sum128Traits              |   37.935 |
| YGroup4UnzipBenchmark_Byte   | Sum256Base_Basic          |    7.511 |
| YGroup4UnzipBenchmark_Byte   | Sum256Base_Narrow         |    2.196 |
| YGroup4UnzipBenchmark_Byte   | Sum256Base_Unzip          |    3.681 |
| YGroup4UnzipBenchmark_Byte   | Sum256Base                |    7.426 |
| YGroup4UnzipBenchmark_Byte   | Sum256Avx2_Permute        |          |
| YGroup4UnzipBenchmark_Byte   | Sum256Avx2_Narrow         |          |
| YGroup4UnzipBenchmark_Byte   | Sum256Avx2_Unpack         |          |
| YGroup4UnzipBenchmark_Byte   | Sum256Avx2_Unzip          |          |
| YGroup4UnzipBenchmark_Byte   | Sum256Traits              |    7.166 |
| YGroup4UnzipBenchmark_Byte   | Sum512Base_Basic          |    7.435 |
| YGroup4UnzipBenchmark_Byte   | Sum512Base_Narrow         |    1.862 |
| YGroup4UnzipBenchmark_Byte   | Sum512Base_Unzip          |    4.063 |
| YGroup4UnzipBenchmark_Byte   | Sum512Base                |    7.526 |
| YGroup4UnzipBenchmark_Byte   | Sum512Avx512_Permute      |          |
| YGroup4UnzipBenchmark_Byte   | Sum512Avx512_Narrow       |          |
| YGroup4UnzipBenchmark_Byte   | Sum512Avx512_Unpack       |          |
| YGroup4UnzipBenchmark_Byte   | Sum512Avx512_Unzip        |          |
| YGroup4UnzipBenchmark_Byte   | Sum512Traits              |    7.311 |
| YGroup4UnzipBenchmark_Int128 | SumBase_Basic             |    1.321 |
| YGroup4UnzipBenchmark_Int128 | SumBase                   |    1.325 |
| YGroup4UnzipBenchmark_Int128 | SumTraits                 |    1.813 |
| YGroup4UnzipBenchmark_Int128 | SumTraits_Int128          |    2.494 |
| YGroup4UnzipBenchmark_Int128 | Sum128Base_Basic          |    1.135 |
| YGroup4UnzipBenchmark_Int128 | Sum128Base                |    1.129 |
| YGroup4UnzipBenchmark_Int128 | Sum128Traits              |   26.869 |
| YGroup4UnzipBenchmark_Int128 | Sum128Traits_Int128       |   28.270 |
| YGroup4UnzipBenchmark_Int128 | Sum256Base_Basic          |    0.777 |
| YGroup4UnzipBenchmark_Int128 | Sum256Base                |    0.833 |
| YGroup4UnzipBenchmark_Int128 | Sum256Avx2                |          |
| YGroup4UnzipBenchmark_Int128 | Sum256Traits              |    1.844 |
| YGroup4UnzipBenchmark_Int128 | Sum256Traits_Int128       |    2.300 |
| YGroup4UnzipBenchmark_Int128 | Sum512Base_Basic          |    0.793 |
| YGroup4UnzipBenchmark_Int128 | Sum512Base_Move           |    0.793 |
| YGroup4UnzipBenchmark_Int128 | Sum512Base_Unzip          |    0.629 |
| YGroup4UnzipBenchmark_Int128 | Sum512Base                |    0.764 |
| YGroup4UnzipBenchmark_Int128 | Sum512Avx512              |          |
| YGroup4UnzipBenchmark_Int128 | Sum512Traits              |    1.701 |
| YGroup4UnzipBenchmark_Int128 | Sum512Traits_Int128       |    1.853 |
| YGroup4UnzipBenchmark_Int16  | SumBase_Basic             |    5.270 |
| YGroup4UnzipBenchmark_Int16  | SumBase_Narrow            |    2.043 |
| YGroup4UnzipBenchmark_Int16  | SumBase_Unzip             |    2.420 |
| YGroup4UnzipBenchmark_Int16  | SumBase                   |    5.190 |
| YGroup4UnzipBenchmark_Int16  | SumTraits                 |    4.249 |
| YGroup4UnzipBenchmark_Int16  | Sum128Base_Basic          |    5.207 |
| YGroup4UnzipBenchmark_Int16  | Sum128Base_Narrow         |    1.255 |
| YGroup4UnzipBenchmark_Int16  | Sum128Base_Unzip          |    1.377 |
| YGroup4UnzipBenchmark_Int16  | Sum128Base                |    1.314 |
| YGroup4UnzipBenchmark_Int16  | Sum128AdvSimd_Narrow      |          |
| YGroup4UnzipBenchmark_Int16  | Sum128AdvSimd_ShuffleX    |          |
| YGroup4UnzipBenchmark_Int16  | Sum128AdvSimd_Unzip       |          |
| YGroup4UnzipBenchmark_Int16  | Sum128AdvSimdB64_ShuffleX |          |
| YGroup4UnzipBenchmark_Int16  | Sum128AdvSimdB64_Unzip    |          |
| YGroup4UnzipBenchmark_Int16  | Sum128PackedSimd_Unzip    |   18.964 |
| YGroup4UnzipBenchmark_Int16  | Sum128Sse_Permute         |          |
| YGroup4UnzipBenchmark_Int16  | Sum128Sse_Narrow          |          |
| YGroup4UnzipBenchmark_Int16  | Sum128Sse_Unpack          |          |
| YGroup4UnzipBenchmark_Int16  | Sum128Sse_Unzip           |          |
| YGroup4UnzipBenchmark_Int16  | Sum128Traits              |   18.730 |
| YGroup4UnzipBenchmark_Int16  | Sum256Base_Basic          |    4.856 |
| YGroup4UnzipBenchmark_Int16  | Sum256Base_Narrow         |    0.984 |
| YGroup4UnzipBenchmark_Int16  | Sum256Base_Unzip          |    2.511 |
| YGroup4UnzipBenchmark_Int16  | Sum256Base                |    4.919 |
| YGroup4UnzipBenchmark_Int16  | Sum256Avx2_Permute        |          |
| YGroup4UnzipBenchmark_Int16  | Sum256Avx2_Narrow         |          |
| YGroup4UnzipBenchmark_Int16  | Sum256Avx2_Unpack         |          |
| YGroup4UnzipBenchmark_Int16  | Sum256Avx2_Unzip          |          |
| YGroup4UnzipBenchmark_Int16  | Sum256Traits              |    4.652 |
| YGroup4UnzipBenchmark_Int16  | Sum512Base_Basic          |    4.733 |
| YGroup4UnzipBenchmark_Int16  | Sum512Base_Narrow         |    0.843 |
| YGroup4UnzipBenchmark_Int16  | Sum512Base_Unzip          |    2.864 |
| YGroup4UnzipBenchmark_Int16  | Sum512Base                |    4.797 |
| YGroup4UnzipBenchmark_Int16  | Sum512Avx512_Permute      |          |
| YGroup4UnzipBenchmark_Int16  | Sum512Avx512_Narrow       |          |
| YGroup4UnzipBenchmark_Int16  | Sum512Avx512_Unpack       |          |
| YGroup4UnzipBenchmark_Int16  | Sum512Avx512_Unzip        |          |
| YGroup4UnzipBenchmark_Int16  | Sum512Traits              |    4.700 |
| YGroup4UnzipBenchmark_Int32  | SumBase_Basic             |    3.588 |
| YGroup4UnzipBenchmark_Int32  | SumBase_Unzip             |    1.635 |
| YGroup4UnzipBenchmark_Int32  | SumBase                   |    3.634 |
| YGroup4UnzipBenchmark_Int32  | SumTraits                 |    2.070 |
| YGroup4UnzipBenchmark_Int32  | Sum128Base_Basic          |    3.766 |
| YGroup4UnzipBenchmark_Int32  | Sum128Base_Unzip          |    0.887 |
| YGroup4UnzipBenchmark_Int32  | Sum128Base                |    0.905 |
| YGroup4UnzipBenchmark_Int32  | Sum128AdvSimd_ShuffleX    |          |
| YGroup4UnzipBenchmark_Int32  | Sum128AdvSimd_Unzip       |          |
| YGroup4UnzipBenchmark_Int32  | Sum128AdvSimdB64_ShuffleX |          |
| YGroup4UnzipBenchmark_Int32  | Sum128AdvSimdB64_Unzip    |          |
| YGroup4UnzipBenchmark_Int32  | Sum128PackedSimd_Unzip    |    9.595 |
| YGroup4UnzipBenchmark_Int32  | Sum128Sse_Permute         |          |
| YGroup4UnzipBenchmark_Int32  | Sum128Sse_Unpack          |          |
| YGroup4UnzipBenchmark_Int32  | Sum128Sse_Unzip           |          |
| YGroup4UnzipBenchmark_Int32  | Sum128Traits              |    9.252 |
| YGroup4UnzipBenchmark_Int32  | Sum256Base_Basic          |    3.383 |
| YGroup4UnzipBenchmark_Int32  | Sum256Base_Unzip          |    1.810 |
| YGroup4UnzipBenchmark_Int32  | Sum256Base                |    3.250 |
| YGroup4UnzipBenchmark_Int32  | Sum256Avx2_Permute        |          |
| YGroup4UnzipBenchmark_Int32  | Sum256Avx2_Unpack         |          |
| YGroup4UnzipBenchmark_Int32  | Sum256Avx2_Unzip          |          |
| YGroup4UnzipBenchmark_Int32  | Sum256Traits              |    2.951 |
| YGroup4UnzipBenchmark_Int32  | Sum512Base_Basic          |    3.476 |
| YGroup4UnzipBenchmark_Int32  | Sum512Base_Unzip          |    2.102 |
| YGroup4UnzipBenchmark_Int32  | Sum512Base                |    3.335 |
| YGroup4UnzipBenchmark_Int32  | Sum512Avx512_Permute      |          |
| YGroup4UnzipBenchmark_Int32  | Sum512Avx512_Unpack       |          |
| YGroup4UnzipBenchmark_Int32  | Sum512Avx512_Unzip        |          |
| YGroup4UnzipBenchmark_Int32  | Sum512Traits              |    3.227 |
| YGroup4UnzipBenchmark_Int64  | SumBase_Basic             |    1.327 |
| YGroup4UnzipBenchmark_Int64  | SumBase                   |    1.321 |
| YGroup4UnzipBenchmark_Int64  | SumTraits                 |    1.059 |
| YGroup4UnzipBenchmark_Int64  | Sum128Base_Basic          |    0.796 |
| YGroup4UnzipBenchmark_Int64  | Sum128Base_Move           |    0.886 |
| YGroup4UnzipBenchmark_Int64  | Sum128Base_Unzip          |    0.962 |
| YGroup4UnzipBenchmark_Int64  | Sum128Base                |    0.947 |
| YGroup4UnzipBenchmark_Int64  | Sum128AdvSimd_ShuffleX    |          |
| YGroup4UnzipBenchmark_Int64  | Sum128AdvSimd_Unzip       |          |
| YGroup4UnzipBenchmark_Int64  | Sum128AdvSimdB64_ShuffleX |          |
| YGroup4UnzipBenchmark_Int64  | Sum128AdvSimdB64_Unzip    |          |
| YGroup4UnzipBenchmark_Int64  | Sum128PackedSimd_Unzip    |    8.319 |
| YGroup4UnzipBenchmark_Int64  | Sum128Sse_Permute         |          |
| YGroup4UnzipBenchmark_Int64  | Sum128Sse_Unpack          |          |
| YGroup4UnzipBenchmark_Int64  | Sum128Sse_Unzip           |          |
| YGroup4UnzipBenchmark_Int64  | Sum128Traits              |    8.032 |
| YGroup4UnzipBenchmark_Int64  | Sum256Base_Basic          |    0.776 |
| YGroup4UnzipBenchmark_Int64  | Sum256Base                |    0.765 |
| YGroup4UnzipBenchmark_Int64  | Sum256Avx2_Permute        |          |
| YGroup4UnzipBenchmark_Int64  | Sum256Avx2_Unpack         |          |
| YGroup4UnzipBenchmark_Int64  | Sum256Avx2_Unzip          |          |
| YGroup4UnzipBenchmark_Int64  | Sum256Traits              |    1.586 |
| YGroup4UnzipBenchmark_Int64  | Sum512Base_Basic          |    0.793 |
| YGroup4UnzipBenchmark_Int64  | Sum512Base                |    0.766 |
| YGroup4UnzipBenchmark_Int64  | Sum512Avx512_Permute      |          |
| YGroup4UnzipBenchmark_Int64  | Sum512Avx512_Unpack       |          |
| YGroup4UnzipBenchmark_Int64  | Sum512Avx512_Unzip        |          |
| YGroup4UnzipBenchmark_Int64  | Sum512Traits              |    1.846 |
| YGroup4ZipBenchmark_Byte     | SumBase_Basic             |    7.760 |
| YGroup4ZipBenchmark_Byte     | SumBase_Widen             |    2.229 |
| YGroup4ZipBenchmark_Byte     | SumBase_Zip               |    3.340 |
| YGroup4ZipBenchmark_Byte     | SumBase                   |    7.951 |
| YGroup4ZipBenchmark_Byte     | SumTraits                 |   33.399 |
| YGroup4ZipBenchmark_Byte     | Sum128Base_Basic          |    7.932 |
| YGroup4ZipBenchmark_Byte     | Sum128Base_Widen          |    2.266 |
| YGroup4ZipBenchmark_Byte     | Sum128Base_Zip            |   12.777 |
| YGroup4ZipBenchmark_Byte     | Sum128Base                |   12.825 |
| YGroup4ZipBenchmark_Byte     | Sum128AdvSimd_ShuffleX    |          |
| YGroup4ZipBenchmark_Byte     | Sum128AdvSimd_Widen       |          |
| YGroup4ZipBenchmark_Byte     | Sum128AdvSimd_Zip         |          |
| YGroup4ZipBenchmark_Byte     | Sum128AdvSimdB64_ShuffleX |          |
| YGroup4ZipBenchmark_Byte     | Sum128AdvSimdB64_Zip      |          |
| YGroup4ZipBenchmark_Byte     | Sum128PackedSimd_Zip      |   38.093 |
| YGroup4ZipBenchmark_Byte     | Sum128Sse_Permute         |          |
| YGroup4ZipBenchmark_Byte     | Sum128Sse_Widen           |          |
| YGroup4ZipBenchmark_Byte     | Sum128Sse_Zip             |          |
| YGroup4ZipBenchmark_Byte     | Sum128Traits              |   37.730 |
| YGroup4ZipBenchmark_Byte     | Sum256Base_Basic          |    7.951 |
| YGroup4ZipBenchmark_Byte     | Sum256Base_Widen          |    1.644 |
| YGroup4ZipBenchmark_Byte     | Sum256Base_Zip            |    3.710 |
| YGroup4ZipBenchmark_Byte     | Sum256Base                |    7.406 |
| YGroup4ZipBenchmark_Byte     | Sum256Avx2_Permute        |          |
| YGroup4ZipBenchmark_Byte     | Sum256Avx2_Widen          |          |
| YGroup4ZipBenchmark_Byte     | Sum256Avx2_Unpack         |          |
| YGroup4ZipBenchmark_Byte     | Sum256Avx2_Zip            |          |
| YGroup4ZipBenchmark_Byte     | Sum256Traits              |    7.058 |
| YGroup4ZipBenchmark_Byte     | Sum512Base_Basic          |    7.305 |
| YGroup4ZipBenchmark_Byte     | Sum512Base_Widen          |    1.498 |
| YGroup4ZipBenchmark_Byte     | Sum512Base_Zip            |    3.894 |
| YGroup4ZipBenchmark_Byte     | Sum512Base                |    7.412 |
| YGroup4ZipBenchmark_Byte     | Sum512Avx512_Widen        |          |
| YGroup4ZipBenchmark_Byte     | Sum512Avx512_Unpack       |          |
| YGroup4ZipBenchmark_Byte     | Sum512Avx512_Zip          |          |
| YGroup4ZipBenchmark_Byte     | Sum512Traits              |    7.518 |
| YGroup4ZipBenchmark_Int128   | SumBase_Basic             |    1.490 |
| YGroup4ZipBenchmark_Int128   | SumBase                   |    1.459 |
| YGroup4ZipBenchmark_Int128   | SumTraits                 |    3.762 |
| YGroup4ZipBenchmark_Int128   | SumTraits_Int128          |    2.460 |
| YGroup4ZipBenchmark_Int128   | Sum128Base_Basic          |    1.210 |
| YGroup4ZipBenchmark_Int128   | Sum128Base                |    1.186 |
| YGroup4ZipBenchmark_Int128   | Sum128Traits              |   28.318 |
| YGroup4ZipBenchmark_Int128   | Sum128Traits_Int128       |   27.869 |
| YGroup4ZipBenchmark_Int128   | Sum256Base_Basic          |    0.823 |
| YGroup4ZipBenchmark_Int128   | Sum256Base                |    0.920 |
| YGroup4ZipBenchmark_Int128   | Sum256Avx2                |          |
| YGroup4ZipBenchmark_Int128   | Sum256Traits              |    1.997 |
| YGroup4ZipBenchmark_Int128   | Sum256Traits_Int128       |    2.404 |
| YGroup4ZipBenchmark_Int128   | Sum512Base_Basic          |    0.841 |
| YGroup4ZipBenchmark_Int128   | Sum512Base_Move           |    0.775 |
| YGroup4ZipBenchmark_Int128   | Sum512Base_Zip            |    0.667 |
| YGroup4ZipBenchmark_Int128   | Sum512Base                |    0.775 |
| YGroup4ZipBenchmark_Int128   | Sum512Avx512              |          |
| YGroup4ZipBenchmark_Int128   | Sum512Traits              |    1.678 |
| YGroup4ZipBenchmark_Int128   | Sum512Traits_Int128       |    1.829 |
| YGroup4ZipBenchmark_Int16    | SumBase_Basic             |    5.961 |
| YGroup4ZipBenchmark_Int16    | SumBase_Widen             |    1.484 |
| YGroup4ZipBenchmark_Int16    | SumBase_Zip               |    2.707 |
| YGroup4ZipBenchmark_Int16    | SumBase                   |    6.501 |
| YGroup4ZipBenchmark_Int16    | SumTraits                 |    4.024 |
| YGroup4ZipBenchmark_Int16    | Sum128Base_Basic          |    6.038 |
| YGroup4ZipBenchmark_Int16    | Sum128Base_Widen          |    0.951 |
| YGroup4ZipBenchmark_Int16    | Sum128Base_Zip            |    1.213 |
| YGroup4ZipBenchmark_Int16    | Sum128Base                |    1.270 |
| YGroup4ZipBenchmark_Int16    | Sum128AdvSimd_ShuffleX    |          |
| YGroup4ZipBenchmark_Int16    | Sum128AdvSimd_Widen       |          |
| YGroup4ZipBenchmark_Int16    | Sum128AdvSimd_Zip         |          |
| YGroup4ZipBenchmark_Int16    | Sum128AdvSimdB64_ShuffleX |          |
| YGroup4ZipBenchmark_Int16    | Sum128AdvSimdB64_Zip      |          |
| YGroup4ZipBenchmark_Int16    | Sum128PackedSimd_Zip      |   19.514 |
| YGroup4ZipBenchmark_Int16    | Sum128Sse_Permute         |          |
| YGroup4ZipBenchmark_Int16    | Sum128Sse_Widen           |          |
| YGroup4ZipBenchmark_Int16    | Sum128Sse_Zip             |          |
| YGroup4ZipBenchmark_Int16    | Sum128Traits              |   19.424 |
| YGroup4ZipBenchmark_Int16    | Sum256Base_Basic          |    5.475 |
| YGroup4ZipBenchmark_Int16    | Sum256Base_Widen          |    0.752 |
| YGroup4ZipBenchmark_Int16    | Sum256Base_Zip            |    3.050 |
| YGroup4ZipBenchmark_Int16    | Sum256Base                |    5.793 |
| YGroup4ZipBenchmark_Int16    | Sum256Avx2_Permute        |          |
| YGroup4ZipBenchmark_Int16    | Sum256Avx2_Widen          |          |
| YGroup4ZipBenchmark_Int16    | Sum256Avx2_Unpack         |          |
| YGroup4ZipBenchmark_Int16    | Sum256Avx2_Zip            |          |
| YGroup4ZipBenchmark_Int16    | Sum256Traits              |    4.984 |
| YGroup4ZipBenchmark_Int16    | Sum512Base_Basic          |    5.668 |
| YGroup4ZipBenchmark_Int16    | Sum512Base_Widen          |    0.640 |
| YGroup4ZipBenchmark_Int16    | Sum512Base_Zip            |    3.213 |
| YGroup4ZipBenchmark_Int16    | Sum512Base                |    5.466 |
| YGroup4ZipBenchmark_Int16    | Sum512Avx512_Widen        |          |
| YGroup4ZipBenchmark_Int16    | Sum512Avx512_Unpack       |          |
| YGroup4ZipBenchmark_Int16    | Sum512Avx512_Zip          |          |
| YGroup4ZipBenchmark_Int16    | Sum512Traits              |    5.080 |
| YGroup4ZipBenchmark_Int32    | SumBase_Basic             |    4.599 |
| YGroup4ZipBenchmark_Int32    | SumBase_Zip               |    1.837 |
| YGroup4ZipBenchmark_Int32    | SumBase                   |    4.314 |
| YGroup4ZipBenchmark_Int32    | SumTraits                 |    2.106 |
| YGroup4ZipBenchmark_Int32    | Sum128Base_Basic          |    4.113 |
| YGroup4ZipBenchmark_Int32    | Sum128Base_Zip            |    0.710 |
| YGroup4ZipBenchmark_Int32    | Sum128Base                |    0.687 |
| YGroup4ZipBenchmark_Int32    | Sum128AdvSimd_ShuffleX    |          |
| YGroup4ZipBenchmark_Int32    | Sum128AdvSimd_Zip         |          |
| YGroup4ZipBenchmark_Int32    | Sum128AdvSimdB64_ShuffleX |          |
| YGroup4ZipBenchmark_Int32    | Sum128AdvSimdB64_Zip      |          |
| YGroup4ZipBenchmark_Int32    | Sum128PackedSimd_Zip      |    9.630 |
| YGroup4ZipBenchmark_Int32    | Sum128Sse_Permute         |          |
| YGroup4ZipBenchmark_Int32    | Sum128Sse_Zip             |          |
| YGroup4ZipBenchmark_Int32    | Sum128Traits              |    9.670 |
| YGroup4ZipBenchmark_Int32    | Sum256Base_Basic          |    3.941 |
| YGroup4ZipBenchmark_Int32    | Sum256Base_Zip            |    1.955 |
| YGroup4ZipBenchmark_Int32    | Sum256Base                |    3.842 |
| YGroup4ZipBenchmark_Int32    | Sum256Avx2_Permute        |          |
| YGroup4ZipBenchmark_Int32    | Sum256Avx2_Unpack         |          |
| YGroup4ZipBenchmark_Int32    | Sum256Avx2_Zip            |          |
| YGroup4ZipBenchmark_Int32    | Sum256Traits              |    3.195 |
| YGroup4ZipBenchmark_Int32    | Sum512Base_Basic          |    3.578 |
| YGroup4ZipBenchmark_Int32    | Sum512Base_Zip            |    2.207 |
| YGroup4ZipBenchmark_Int32    | Sum512Base                |    3.622 |
| YGroup4ZipBenchmark_Int32    | Sum512Avx512_Unpack       |          |
| YGroup4ZipBenchmark_Int32    | Sum512Avx512_Zip          |          |
| YGroup4ZipBenchmark_Int32    | Sum512Traits              |    3.404 |
| YGroup4ZipBenchmark_Int64    | SumBase_Basic             |    1.461 |
| YGroup4ZipBenchmark_Int64    | SumBase                   |    1.452 |
| YGroup4ZipBenchmark_Int64    | SumTraits                 |    1.062 |
| YGroup4ZipBenchmark_Int64    | Sum128Base_Basic          |    0.864 |
| YGroup4ZipBenchmark_Int64    | Sum128Base_Move           |    0.924 |
| YGroup4ZipBenchmark_Int64    | Sum128Base_Zip            |    0.993 |
| YGroup4ZipBenchmark_Int64    | Sum128Base                |    1.006 |
| YGroup4ZipBenchmark_Int64    | Sum128AdvSimd_ShuffleX    |          |
| YGroup4ZipBenchmark_Int64    | Sum128AdvSimd_Zip         |          |
| YGroup4ZipBenchmark_Int64    | Sum128AdvSimdB64_ShuffleX |          |
| YGroup4ZipBenchmark_Int64    | Sum128AdvSimdB64_Zip      |          |
| YGroup4ZipBenchmark_Int64    | Sum128PackedSimd_Zip      |    8.219 |
| YGroup4ZipBenchmark_Int64    | Sum128Sse_Permute         |          |
| YGroup4ZipBenchmark_Int64    | Sum128Sse_Zip             |          |
| YGroup4ZipBenchmark_Int64    | Sum128Traits              |    8.256 |
| YGroup4ZipBenchmark_Int64    | Sum256Base_Basic          |    0.822 |
| YGroup4ZipBenchmark_Int64    | Sum256Base                |    0.825 |
| YGroup4ZipBenchmark_Int64    | Sum256Avx2_Permute        |          |
| YGroup4ZipBenchmark_Int64    | Sum256Avx2_Unpack         |          |
| YGroup4ZipBenchmark_Int64    | Sum256Avx2_Zip            |          |
| YGroup4ZipBenchmark_Int64    | Sum256Traits              |    1.615 |
| YGroup4ZipBenchmark_Int64    | Sum512Base_Basic          |    0.833 |
| YGroup4ZipBenchmark_Int64    | Sum512Base                |    0.815 |
| YGroup4ZipBenchmark_Int64    | Sum512Avx512_Unpack       |          |
| YGroup4ZipBenchmark_Int64    | Sum512Avx512_Zip          |          |
| YGroup4ZipBenchmark_Int64    | Sum512Traits              |    1.928 |

