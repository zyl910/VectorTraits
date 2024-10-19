# Benchmark group - YGroup2Unzip
([← Back](YGroup2Unzip.md))

Unit of data: Million operations per second. The larger the number, the better the performance.
### X86 - AMD Ryzen 7 7840H
| Type                         | Method                        | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :--------------------------- | :---------------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| YGroup2UnzipBenchmark_Byte   | SumBase_Basic                 |        312.440 |       708.615 |       701.838 |   623.371 |   741.788 |   690.964 |   913.409 |
| YGroup2UnzipBenchmark_Byte   | SumBase_Narrow                |                |               |               |           |           | 27664.994 | 38799.095 |
| YGroup2UnzipBenchmark_Byte   | SumBase_NarrowMul             |       5263.307 |      5212.518 |      5195.285 |  5244.322 |  5174.573 |  8730.559 | 10414.217 |
| YGroup2UnzipBenchmark_Byte   | SumBase                       |       5288.807 |      5213.572 |      5191.998 |  5225.440 |  5140.035 | 26996.800 | 39210.113 |
| YGroup2UnzipBenchmark_Byte   | SumTraits                     |       5256.158 |      5160.486 |     23793.787 | 25428.076 | 28511.141 | 27473.666 | 53874.524 |
| YGroup2UnzipBenchmark_Byte   | Sum128Base_Basic              |                |               |       342.364 |   367.322 |   350.369 |   634.826 |   981.234 |
| YGroup2UnzipBenchmark_Byte   | Sum128Base                    |                |               |       346.944 |   375.783 |   352.595 | 16163.037 | 21168.785 |
| YGroup2UnzipBenchmark_Byte   | Sum128AdvSimd_Narrow          |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum128AdvSimd_Shuffle         |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum128AdvSimd_ShuffleX        |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum128AdvSimdB64              |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum128PackedSimd_Narrow       |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum128PackedSimd_Shuffle      |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum128PackedSimd_TupleNarrow  |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum128PackedSimd_TupleShuffle |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum128Sse_Narrow              |                |               |     14420.100 | 14419.377 | 16039.185 | 15916.915 | 19619.701 |
| YGroup2UnzipBenchmark_Byte   | Sum128Sse_Permute             |                |               |               |           |           |           | 27808.972 |
| YGroup2UnzipBenchmark_Byte   | Sum128Sse_Unpack              |                |               |     13839.276 | 14143.198 | 13745.620 | 13490.022 | 14365.190 |
| YGroup2UnzipBenchmark_Byte   | Sum128Traits                  |                |               |     14745.866 | 15906.414 | 16353.364 | 15342.508 | 27288.403 |
| YGroup2UnzipBenchmark_Byte   | Sum256Base_Basic              |                |               |       407.027 |   382.689 |   419.636 |   694.685 |   921.283 |
| YGroup2UnzipBenchmark_Byte   | Sum256Base                    |                |               |       402.207 |   382.049 |   417.690 | 28000.278 | 36904.926 |
| YGroup2UnzipBenchmark_Byte   | Sum256Avx2_Narrow             |                |               |     23493.768 | 27700.483 | 29022.834 | 27240.744 | 36439.779 |
| YGroup2UnzipBenchmark_Byte   | Sum256Avx2_Permute            |                |               |               |           |           |           | 48267.067 |
| YGroup2UnzipBenchmark_Byte   | Sum256Avx2_Unpack             |                |               |     22451.572 | 22442.671 | 22617.223 | 22241.992 | 22058.773 |
| YGroup2UnzipBenchmark_Byte   | Sum256Traits                  |                |               |     24454.706 | 26308.795 | 29540.267 | 27635.750 | 48613.828 |
| YGroup2UnzipBenchmark_Byte   | Sum512Base_Basic              |                |               |               |           |           |           |   932.576 |
| YGroup2UnzipBenchmark_Byte   | Sum512Base                    |                |               |               |           |           |           | 46801.082 |
| YGroup2UnzipBenchmark_Byte   | Sum512Avx512_Narrow           |                |               |               |           |           |           | 47507.109 |
| YGroup2UnzipBenchmark_Byte   | Sum512Avx512_Permute          |                |               |               |           |           |           | 68629.385 |
| YGroup2UnzipBenchmark_Byte   | Sum512Avx512_Unpack           |                |               |               |           |           |           | 26429.397 |
| YGroup2UnzipBenchmark_Byte   | Sum512Traits                  |                |               |               |           |           |           | 68346.668 |
| YGroup2UnzipBenchmark_Int128 | SumBase_Basic                 |         89.422 |        86.857 |        97.707 |   146.791 |   161.467 |   133.161 |   164.447 |
| YGroup2UnzipBenchmark_Int128 | SumBase                       |         87.991 |        99.064 |       102.611 |   165.200 |   187.202 |   131.396 |   165.110 |
| YGroup2UnzipBenchmark_Int128 | SumTraits                     |         79.916 |        95.446 |        51.301 |    45.241 |    46.397 |    92.476 |   200.561 |
| YGroup2UnzipBenchmark_Int128 | SumTraits_Int128              |        125.496 |       153.785 |      6509.156 |  7108.716 |  6651.417 |  6556.273 |  6744.527 |
| YGroup2UnzipBenchmark_Int128 | Sum128Base_Basic              |                |               |        82.835 |    81.370 |    81.762 |   163.332 |   163.329 |
| YGroup2UnzipBenchmark_Int128 | Sum128Base                    |                |               |        82.437 |    81.624 |    81.201 |   163.033 |   163.132 |
| YGroup2UnzipBenchmark_Int128 | Sum128Traits                  |                |               |       163.585 |   163.755 |   163.446 |   162.963 |   162.787 |
| YGroup2UnzipBenchmark_Int128 | Sum128Traits_Int128           |                |               |      4911.017 |  5686.756 |  5380.761 |  5147.491 |  5080.169 |
| YGroup2UnzipBenchmark_Int128 | Sum256Base_Basic              |                |               |        67.405 |    92.607 |   104.775 |   168.709 |   310.585 |
| YGroup2UnzipBenchmark_Int128 | Sum256Base_Move2              |                |               |        68.862 |    70.724 |    90.024 |   781.567 |  5269.986 |
| YGroup2UnzipBenchmark_Int128 | Sum256Base                    |                |               |        68.305 |    71.091 |    89.030 |   771.058 |  6217.151 |
| YGroup2UnzipBenchmark_Int128 | Sum256Avx2                    |                |               |        70.527 |    91.917 |    94.625 |   748.417 |  6929.795 |
| YGroup2UnzipBenchmark_Int128 | Sum256Traits                  |                |               |        67.162 |    91.968 |    94.430 |   741.749 |  6951.690 |
| YGroup2UnzipBenchmark_Int128 | Sum256Traits_Int128           |                |               |      5496.242 |  7027.320 |  6764.164 |  7031.433 |  6764.362 |
| YGroup2UnzipBenchmark_Int128 | Sum512Base_Basic              |                |               |               |           |           |           |   386.608 |
| YGroup2UnzipBenchmark_Int128 | Sum512Base                    |                |               |               |           |           |           |  3469.086 |
| YGroup2UnzipBenchmark_Int128 | Sum512Avx512                  |                |               |               |           |           |           |  8854.300 |
| YGroup2UnzipBenchmark_Int128 | Sum512Traits                  |                |               |               |           |           |           |  8900.684 |
| YGroup2UnzipBenchmark_Int128 | Sum512Traits_Int128           |                |               |               |           |           |           |  8910.277 |
| YGroup2UnzipBenchmark_Int16  | SumBase_Basic                 |        343.867 |       552.944 |       590.940 |   455.007 |   578.106 |   554.368 |   704.227 |
| YGroup2UnzipBenchmark_Int16  | SumBase_Narrow                |                |               |               |           |           | 13602.150 | 19219.439 |
| YGroup2UnzipBenchmark_Int16  | SumBase_NarrowMul             |       3394.043 |      3311.882 |      3353.238 |  3394.478 |  3297.919 |  5186.878 |  6962.179 |
| YGroup2UnzipBenchmark_Int16  | SumBase_NarrowMulOld          |       2087.448 |      1992.687 |      1319.253 |  2139.564 |  2027.969 |  2921.203 |  3022.595 |
| YGroup2UnzipBenchmark_Int16  | SumBase                       |       3389.868 |      3140.644 |      3327.213 |  3348.805 |  3332.565 | 13328.548 | 19340.304 |
| YGroup2UnzipBenchmark_Int16  | SumTraits                     |       3337.336 |      3205.081 |     12924.474 | 13784.735 | 13762.321 | 13465.799 | 24589.723 |
| YGroup2UnzipBenchmark_Int16  | Sum128Base_Basic              |                |               |       224.034 |   235.668 |   221.971 |   477.089 |   697.837 |
| YGroup2UnzipBenchmark_Int16  | Sum128Base                    |                |               |       227.287 |   233.547 |   220.255 |  7825.875 | 10232.085 |
| YGroup2UnzipBenchmark_Int16  | Sum128AdvSimd_Narrow          |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum128AdvSimd_Shuffle         |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum128AdvSimd_ShuffleX        |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum128AdvSimdB64              |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum128PackedSimd_Narrow       |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum128PackedSimd_Shuffle      |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum128PackedSimd_TupleNarrow  |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum128PackedSimd_TupleShuffle |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum128Sse_Narrow              |                |               |      6147.426 |  7820.839 |  8135.788 |  7938.521 |  9277.071 |
| YGroup2UnzipBenchmark_Int16  | Sum128Sse_Permute             |                |               |               |           |           |           | 13528.472 |
| YGroup2UnzipBenchmark_Int16  | Sum128Sse_ShuffleXImm         |                |               |      9096.740 |  9967.935 | 10152.929 |  9825.838 | 10244.473 |
| YGroup2UnzipBenchmark_Int16  | Sum128Sse_Unpack              |                |               |      8771.697 |  8987.290 |  8779.236 |  8731.122 |  8717.110 |
| YGroup2UnzipBenchmark_Int16  | Sum128Traits                  |                |               |      8964.560 | 10242.922 | 10193.702 |  9746.461 | 13803.716 |
| YGroup2UnzipBenchmark_Int16  | Sum256Base_Basic              |                |               |       286.138 |   256.641 |   297.331 |   551.580 |   716.288 |
| YGroup2UnzipBenchmark_Int16  | Sum256Base                    |                |               |       293.798 |   275.321 |   302.710 | 13619.341 | 19246.849 |
| YGroup2UnzipBenchmark_Int16  | Sum256Avx2_Narrow             |                |               |     11782.755 | 13841.667 | 14120.405 | 13457.282 | 18863.723 |
| YGroup2UnzipBenchmark_Int16  | Sum256Avx2_Permute            |                |               |               |           |           |           | 24848.590 |
| YGroup2UnzipBenchmark_Int16  | Sum256Avx2_ShuffleXImm        |                |               |     13789.369 | 13780.883 | 13487.301 | 13599.570 | 13711.421 |
| YGroup2UnzipBenchmark_Int16  | Sum256Avx2_Unpack             |                |               |     13246.043 | 13597.726 | 13338.789 | 12913.395 | 13093.706 |
| YGroup2UnzipBenchmark_Int16  | Sum256Traits                  |                |               |     13837.439 | 13860.444 | 13478.299 | 13552.638 | 26409.251 |
| YGroup2UnzipBenchmark_Int16  | Sum512Base_Basic              |                |               |               |           |           |           |   843.615 |
| YGroup2UnzipBenchmark_Int16  | Sum512Base                    |                |               |               |           |           |           | 24071.005 |
| YGroup2UnzipBenchmark_Int16  | Sum512Avx512_Narrow           |                |               |               |           |           |           | 23875.971 |
| YGroup2UnzipBenchmark_Int16  | Sum512Avx512_Permute          |                |               |               |           |           |           | 35690.855 |
| YGroup2UnzipBenchmark_Int16  | Sum512Avx512_ShuffleXImm      |                |               |               |           |           |           | 17011.339 |
| YGroup2UnzipBenchmark_Int16  | Sum512Avx512_Unpack           |                |               |               |           |           |           | 16641.785 |
| YGroup2UnzipBenchmark_Int16  | Sum512Traits                  |                |               |               |           |           |           | 35699.058 |
| YGroup2UnzipBenchmark_Int32  | SumBase_Basic                 |        288.660 |       389.483 |       390.376 |   264.310 |   398.874 |   368.941 |   493.837 |
| YGroup2UnzipBenchmark_Int32  | SumBase_Narrow                |                |               |               |           |           |  6164.935 |  9218.884 |
| YGroup2UnzipBenchmark_Int32  | SumBase_NarrowMul             |       1449.058 |      1396.528 |      1428.226 |  1493.629 |  1404.044 |  2302.816 |  3054.721 |
| YGroup2UnzipBenchmark_Int32  | SumBase                       |       1481.280 |      1400.246 |      1422.057 |  1473.995 |  1439.623 |  6171.687 |  9527.998 |
| YGroup2UnzipBenchmark_Int32  | SumTraits                     |       1467.766 |      1401.416 |     10714.833 | 10682.997 | 10218.602 | 10318.189 | 12854.102 |
| YGroup2UnzipBenchmark_Int32  | Sum128Base_Basic              |                |               |       140.033 |   134.123 |   140.674 |   256.752 |   443.598 |
| YGroup2UnzipBenchmark_Int32  | Sum128Base                    |                |               |       133.134 |   133.064 |   141.014 |  3822.769 |  5051.649 |
| YGroup2UnzipBenchmark_Int32  | Sum128AdvSimd_Narrow          |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum128AdvSimd_Shuffle         |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum128AdvSimd_ShuffleX        |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum128AdvSimdB64              |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum128PackedSimd_Narrow       |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum128PackedSimd_Shuffle      |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum128PackedSimd_TupleNarrow  |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum128PackedSimd_TupleShuffle |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum128Sse_Narrow              |                |               |      3653.601 |  3950.752 |  3870.934 |  3777.928 |  4822.234 |
| YGroup2UnzipBenchmark_Int32  | Sum128Sse_Permute             |                |               |               |           |           |           |  6779.906 |
| YGroup2UnzipBenchmark_Int32  | Sum128Sse_ShuffleXImm         |                |               |      7959.877 |  7875.408 |  7182.845 |  7027.736 |  8015.991 |
| YGroup2UnzipBenchmark_Int32  | Sum128Sse_Unpack              |                |               |      5870.951 |  5760.486 |  5590.444 |  5489.564 |  5945.846 |
| YGroup2UnzipBenchmark_Int32  | Sum128Traits                  |                |               |      7780.653 |  7406.999 |  8022.471 |  7635.668 |  7581.891 |
| YGroup2UnzipBenchmark_Int32  | Sum256Base_Basic              |                |               |       207.105 |   164.551 |   210.647 |   372.128 |   491.071 |
| YGroup2UnzipBenchmark_Int32  | Sum256Base                    |                |               |       208.579 |   168.975 |   212.496 |  6099.499 |  9223.473 |
| YGroup2UnzipBenchmark_Int32  | Sum256Avx2_Narrow             |                |               |      5760.345 |  6408.890 |  6151.415 |  6167.812 |  9361.660 |
| YGroup2UnzipBenchmark_Int32  | Sum256Avx2_Permute            |                |               |               |           |           |           | 12563.020 |
| YGroup2UnzipBenchmark_Int32  | Sum256Avx2_ShuffleXImm        |                |               |     11009.485 | 10791.156 | 10579.538 | 10604.505 | 10686.541 |
| YGroup2UnzipBenchmark_Int32  | Sum256Avx2_Unpack             |                |               |      8555.748 |  8542.918 |  7884.926 |  8438.160 |  8532.001 |
| YGroup2UnzipBenchmark_Int32  | Sum256Traits                  |                |               |     11138.013 | 10779.378 | 10273.212 | 10320.229 | 12134.600 |
| YGroup2UnzipBenchmark_Int32  | Sum512Base_Basic              |                |               |               |           |           |           |   640.694 |
| YGroup2UnzipBenchmark_Int32  | Sum512Base                    |                |               |               |           |           |           | 11692.195 |
| YGroup2UnzipBenchmark_Int32  | Sum512Avx512_Narrow           |                |               |               |           |           |           | 11654.414 |
| YGroup2UnzipBenchmark_Int32  | Sum512Avx512_Permute          |                |               |               |           |           |           | 16070.359 |
| YGroup2UnzipBenchmark_Int32  | Sum512Avx512_ShuffleXImm      |                |               |               |           |           |           | 13002.839 |
| YGroup2UnzipBenchmark_Int32  | Sum512Avx512_Unpack           |                |               |               |           |           |           | 10230.478 |
| YGroup2UnzipBenchmark_Int32  | Sum512Traits                  |                |               |               |           |           |           | 16355.958 |
| YGroup2UnzipBenchmark_Int64  | SumBase_Basic                 |        178.096 |       230.839 |       236.674 |   234.141 |   234.254 |   215.062 |   293.877 |
| YGroup2UnzipBenchmark_Int64  | SumBase                       |        178.203 |       232.140 |       243.128 |   234.169 |   238.235 |   214.691 |   291.719 |
| YGroup2UnzipBenchmark_Int64  | SumTraits                     |        180.088 |       232.839 |      5536.173 |  5665.745 |  5672.494 |  5652.144 |  6411.331 |
| YGroup2UnzipBenchmark_Int64  | Sum128Base_Basic              |                |               |        76.602 |    72.956 |    73.881 |   147.008 |   235.497 |
| YGroup2UnzipBenchmark_Int64  | Sum128Base                    |                |               |        80.435 |    80.256 |    80.479 |   153.365 |   278.350 |
| YGroup2UnzipBenchmark_Int64  | Sum128AdvSimd_AlignRight      |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int64  | Sum128AdvSimd_Shuffle         |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int64  | Sum128AdvSimd_ShuffleX        |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int64  | Sum128AdvSimdB64              |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int64  | Sum128PackedSimd_Shuffle      |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int64  | Sum128PackedSimd_TupleShuffle |                |               |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int64  | Sum128Sse_Permute             |                |               |               |           |           |           |  3372.964 |
| YGroup2UnzipBenchmark_Int64  | Sum128Sse_Unpack              |                |               |      4137.520 |  4177.750 |  3866.860 |  4002.206 |  4183.587 |
| YGroup2UnzipBenchmark_Int64  | Sum128Traits                  |                |               |      4053.644 |  4105.403 |  3863.718 |  3748.229 |  3718.750 |
| YGroup2UnzipBenchmark_Int64  | Sum256Base_Basic              |                |               |       120.574 |    89.975 |   118.366 |   216.121 |   295.341 |
| YGroup2UnzipBenchmark_Int64  | Sum256Base                    |                |               |       120.034 |    86.218 |   120.006 |   214.682 |   290.613 |
| YGroup2UnzipBenchmark_Int64  | Sum256Avx2_Permute            |                |               |               |           |           |           |  6875.496 |
| YGroup2UnzipBenchmark_Int64  | Sum256Avx2_Unpack             |                |               |      5801.950 |  5639.294 |  5868.885 |  5483.524 |  5590.221 |
| YGroup2UnzipBenchmark_Int64  | Sum256Traits                  |                |               |      5490.972 |  5705.729 |  5671.182 |  5634.759 |  6121.271 |
| YGroup2UnzipBenchmark_Int64  | Sum512Base_Basic              |                |               |               |           |           |           |   402.947 |
| YGroup2UnzipBenchmark_Int64  | Sum512Base                    |                |               |               |           |           |           |   401.574 |
| YGroup2UnzipBenchmark_Int64  | Sum512Avx512_Permute          |                |               |               |           |           |           |  8632.549 |
| YGroup2UnzipBenchmark_Int64  | Sum512Avx512_Unpack           |                |               |               |           |           |           |  6797.571 |
| YGroup2UnzipBenchmark_Int64  | Sum512Traits                  |                |               |               |           |           |           |  8708.720 |
| YGroup2ZipBenchmark_Byte     | SumBase_Basic                 |        374.647 |       747.722 |       884.034 |   642.427 |   810.488 |   844.404 |   915.578 |
| YGroup2ZipBenchmark_Byte     | SumBase_Widen                 |                |               |               |           |           | 29860.211 | 26054.243 |
| YGroup2ZipBenchmark_Byte     | SumBase_WidenMul              |      19227.974 |     18116.996 |     18156.750 | 18212.820 | 18277.672 | 27912.299 | 28546.869 |
| YGroup2ZipBenchmark_Byte     | SumBase                       |      19034.663 |     18413.837 |     18003.172 | 18267.204 | 17557.912 | 29027.283 | 26763.286 |
| YGroup2ZipBenchmark_Byte     | SumTraits                     |      19208.309 |     17712.936 |     43644.394 | 49986.735 | 50843.740 | 49983.002 | 47863.406 |
| YGroup2ZipBenchmark_Byte     | Sum128Base_Basic              |                |               |       375.364 |   374.653 |   372.171 |   696.315 |   705.036 |
| YGroup2ZipBenchmark_Byte     | Sum128Base                    |                |               |       382.717 |   373.245 |   378.658 | 16541.464 | 15963.084 |
| YGroup2ZipBenchmark_Byte     | Sum128AdvSimd_Shuffle         |                |               |               |           |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum128AdvSimd_ShuffleX        |                |               |               |           |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum128AdvSimd_Widen           |                |               |               |           |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum128AdvSimdB64              |                |               |               |           |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum128PackedSimd_Widen        |                |               |               |           |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum128PackedSimd_Shuffle      |                |               |               |           |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum128Sse_Permute             |                |               |               |           |           |           | 27650.235 |
| YGroup2ZipBenchmark_Byte     | Sum128Sse_Unpack              |                |               |     31938.066 | 31413.814 | 30600.360 | 29423.449 | 29912.986 |
| YGroup2ZipBenchmark_Byte     | Sum128Sse_Widen               |                |               |     14383.702 | 14981.930 | 15045.124 | 13526.299 | 13427.685 |
| YGroup2ZipBenchmark_Byte     | Sum128Traits                  |                |               |     30125.650 | 31926.232 | 31517.040 | 31713.434 | 29731.938 |
| YGroup2ZipBenchmark_Byte     | Sum256Base_Basic              |                |               |       448.766 |   376.757 |   444.958 |   846.190 |   857.353 |
| YGroup2ZipBenchmark_Byte     | Sum256Base                    |                |               |       426.553 |   387.475 |   447.699 | 30299.290 | 28309.743 |
| YGroup2ZipBenchmark_Byte     | Sum256Avx2_Permute            |                |               |               |           |           |           | 50125.580 |
| YGroup2ZipBenchmark_Byte     | Sum256Avx2_Unpack             |                |               |     43841.661 | 50050.529 | 50542.024 | 47926.024 | 48004.686 |
| YGroup2ZipBenchmark_Byte     | Sum256Avx2_Widen              |                |               |     22962.869 | 27948.616 | 28398.083 | 25309.333 | 30286.641 |
| YGroup2ZipBenchmark_Byte     | Sum256Traits                  |                |               |     44799.259 | 50602.987 | 49833.479 | 47262.065 | 48621.120 |
| YGroup2ZipBenchmark_Byte     | Sum512Base_Basic              |                |               |               |           |           |           |   786.921 |
| YGroup2ZipBenchmark_Byte     | Sum512Base                    |                |               |               |           |           |           | 41136.073 |
| YGroup2ZipBenchmark_Byte     | Sum512Avx512_Permute          |                |               |               |           |           |           | 69099.126 |
| YGroup2ZipBenchmark_Byte     | Sum512Avx512_Unpack           |                |               |               |           |           |           | 55871.801 |
| YGroup2ZipBenchmark_Byte     | Sum512Avx512_Widen            |                |               |               |           |           |           | 41864.680 |
| YGroup2ZipBenchmark_Byte     | Sum512Traits                  |                |               |               |           |           |           | 69582.222 |
| YGroup2ZipBenchmark_Int128   | SumBase_Basic                 |         90.198 |       110.274 |       122.970 |   132.589 |   151.238 |   135.538 |   152.790 |
| YGroup2ZipBenchmark_Int128   | SumBase                       |         89.348 |       107.473 |       120.934 |   133.921 |   150.688 |   135.760 |   152.159 |
| YGroup2ZipBenchmark_Int128   | SumTraits                     |         83.535 |        94.721 |        50.754 |    45.165 |    46.342 |    92.820 |   200.543 |
| YGroup2ZipBenchmark_Int128   | SumTraits_Int128              |        113.643 |       140.681 |      6586.565 |  7208.001 |  6691.355 |  6800.003 |  7263.224 |
| YGroup2ZipBenchmark_Int128   | Sum128Base_Basic              |                |               |        83.238 |    81.605 |    81.891 |   163.034 |   163.390 |
| YGroup2ZipBenchmark_Int128   | Sum128Base                    |                |               |        82.632 |    81.155 |    81.461 |   162.862 |   163.562 |
| YGroup2ZipBenchmark_Int128   | Sum128Traits                  |                |               |       163.496 |   163.119 |   163.810 |   163.362 |   162.772 |
| YGroup2ZipBenchmark_Int128   | Sum128Traits_Int128           |                |               |      5465.117 |  5426.199 |  5189.072 |  5186.834 |  4999.649 |
| YGroup2ZipBenchmark_Int128   | Sum256Base_Basic              |                |               |        82.503 |    90.276 |   100.728 |   187.011 |   280.706 |
| YGroup2ZipBenchmark_Int128   | Sum256Base_Move2              |                |               |        68.951 |    70.414 |    90.088 |   773.354 |  4911.082 |
| YGroup2ZipBenchmark_Int128   | Sum256Base                    |                |               |        68.053 |    71.097 |    89.480 |   782.149 |  5781.790 |
| YGroup2ZipBenchmark_Int128   | Sum256Avx2                    |                |               |        70.641 |    92.204 |    94.242 |   739.402 |  6355.561 |
| YGroup2ZipBenchmark_Int128   | Sum256Traits                  |                |               |        67.231 |    92.097 |    95.106 |   723.898 |  6543.910 |
| YGroup2ZipBenchmark_Int128   | Sum256Traits_Int128           |                |               |      6643.367 |  6761.932 |  7328.373 |  6460.112 |  6703.968 |
| YGroup2ZipBenchmark_Int128   | Sum512Base_Basic              |                |               |               |           |           |           |   314.938 |
| YGroup2ZipBenchmark_Int128   | Sum512Base                    |                |               |               |           |           |           |  3420.716 |
| YGroup2ZipBenchmark_Int128   | Sum512Avx512                  |                |               |               |           |           |           |  8638.700 |
| YGroup2ZipBenchmark_Int128   | Sum512Avx512_Imm              |                |               |               |           |           |           |  6603.568 |
| YGroup2ZipBenchmark_Int128   | Sum512Traits                  |                |               |               |           |           |           |  8539.793 |
| YGroup2ZipBenchmark_Int128   | Sum512Traits_Int128           |                |               |               |           |           |           |  8561.489 |
| YGroup2ZipBenchmark_Int16    | SumBase_Basic                 |        343.486 |       575.551 |       680.473 |   442.731 |   667.393 |   641.803 |   644.264 |
| YGroup2ZipBenchmark_Int16    | SumBase_Widen                 |                |               |               |           |           | 14916.760 | 13390.275 |
| YGroup2ZipBenchmark_Int16    | SumBase_WidenMul              |       9467.105 |      8668.102 |      8991.576 |  9185.208 |  9180.201 | 13486.951 | 13824.151 |
| YGroup2ZipBenchmark_Int16    | SumBase                       |       9554.663 |      8515.899 |      9272.883 |  8816.670 |  9218.729 | 14846.064 | 12937.269 |
| YGroup2ZipBenchmark_Int16    | SumTraits                     |       8988.525 |      8718.781 |     21968.086 | 24478.518 | 24489.609 | 22904.792 | 23824.727 |
| YGroup2ZipBenchmark_Int16    | Sum128Base_Basic              |                |               |       248.695 |   247.786 |   246.204 |   470.606 |   502.920 |
| YGroup2ZipBenchmark_Int16    | Sum128Base                    |                |               |       245.108 |   247.954 |   243.193 |  7788.578 |  8011.845 |
| YGroup2ZipBenchmark_Int16    | Sum128AdvSimd_Shuffle         |                |               |               |           |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum128AdvSimd_ShuffleX        |                |               |               |           |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum128AdvSimd_Widen           |                |               |               |           |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum128AdvSimdB64              |                |               |               |           |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum128PackedSimd_Widen        |                |               |               |           |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum128PackedSimd_Shuffle      |                |               |               |           |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum128Sse_Permute             |                |               |               |           |           |           | 12371.148 |
| YGroup2ZipBenchmark_Int16    | Sum128Sse_Unpack              |                |               |     15391.344 | 11360.399 | 16539.302 | 14094.729 | 14993.236 |
| YGroup2ZipBenchmark_Int16    | Sum128Sse_Widen               |                |               |      7440.800 |  7222.859 |  7273.543 |  6452.729 |  6750.856 |
| YGroup2ZipBenchmark_Int16    | Sum128Traits                  |                |               |     15029.828 | 15105.533 | 15661.157 | 14477.327 | 14973.416 |
| YGroup2ZipBenchmark_Int16    | Sum256Base_Basic              |                |               |       343.281 |   260.166 |   334.841 |   632.064 |   654.927 |
| YGroup2ZipBenchmark_Int16    | Sum256Base                    |                |               |       336.264 |   244.239 |   337.718 | 15205.385 | 14598.709 |
| YGroup2ZipBenchmark_Int16    | Sum256Avx2_Permute            |                |               |               |           |           |           | 23707.400 |
| YGroup2ZipBenchmark_Int16    | Sum256Avx2_Unpack             |                |               |     22362.425 | 23832.738 | 23479.905 | 23255.358 | 24289.745 |
| YGroup2ZipBenchmark_Int16    | Sum256Avx2_Widen              |                |               |     11613.146 | 13922.047 | 13835.971 | 12382.326 | 13249.319 |
| YGroup2ZipBenchmark_Int16    | Sum256Traits                  |                |               |     20877.287 | 24660.121 | 24624.725 | 23013.364 | 25084.652 |
| YGroup2ZipBenchmark_Int16    | Sum512Base_Basic              |                |               |               |           |           |           |   658.833 |
| YGroup2ZipBenchmark_Int16    | Sum512Base                    |                |               |               |           |           |           | 20212.267 |
| YGroup2ZipBenchmark_Int16    | Sum512Avx512_Permute          |                |               |               |           |           |           | 34402.753 |
| YGroup2ZipBenchmark_Int16    | Sum512Avx512_Unpack           |                |               |               |           |           |           | 26620.425 |
| YGroup2ZipBenchmark_Int16    | Sum512Avx512_Widen            |                |               |               |           |           |           | 21058.887 |
| YGroup2ZipBenchmark_Int16    | Sum512Traits                  |                |               |               |           |           |           | 35829.759 |
| YGroup2ZipBenchmark_Int32    | SumBase_Basic                 |        243.668 |       373.773 |       461.089 |   268.239 |   461.494 |   423.731 |   447.979 |
| YGroup2ZipBenchmark_Int32    | SumBase_Widen                 |                |               |               |           |           |  7401.505 |  7602.512 |
| YGroup2ZipBenchmark_Int32    | SumBase                       |        248.935 |       356.919 |       447.720 |   258.621 |   459.217 |  7232.717 |  7462.036 |
| YGroup2ZipBenchmark_Int32    | SumTraits                     |        235.820 |       361.537 |     10314.292 | 11161.150 | 11492.854 | 11626.050 | 11738.805 |
| YGroup2ZipBenchmark_Int32    | Sum128Base_Basic              |                |               |       146.803 |   147.089 |   143.759 |   311.669 |   320.539 |
| YGroup2ZipBenchmark_Int32    | Sum128Base                    |                |               |       144.392 |   146.715 |   144.199 |  3886.686 |  4137.601 |
| YGroup2ZipBenchmark_Int32    | Sum128AdvSimd_Shuffle         |                |               |               |           |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum128AdvSimd_ShuffleX        |                |               |               |           |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum128AdvSimd_Widen           |                |               |               |           |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum128AdvSimdB64              |                |               |               |           |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum128PackedSimd_Widen        |                |               |               |           |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum128PackedSimd_Shuffle      |                |               |               |           |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum128Sse_Permute             |                |               |               |           |           |           |  6387.365 |
| YGroup2ZipBenchmark_Int32    | Sum128Sse_Unpack              |                |               |      7643.603 |  7534.736 |  7505.358 |  7449.851 |  7732.334 |
| YGroup2ZipBenchmark_Int32    | Sum128Sse_Widen               |                |               |      3666.853 |  3618.209 |  3573.720 |  3438.761 |  3295.814 |
| YGroup2ZipBenchmark_Int32    | Sum128Traits                  |                |               |      7632.406 |  7552.292 |  7501.640 |  7115.192 |  7775.915 |
| YGroup2ZipBenchmark_Int32    | Sum256Base_Basic              |                |               |       224.131 |   169.974 |   237.507 |   430.330 |   453.120 |
| YGroup2ZipBenchmark_Int32    | Sum256Base                    |                |               |       239.241 |   161.301 |   236.725 |  7526.841 |  7502.829 |
| YGroup2ZipBenchmark_Int32    | Sum256Avx2_Permute            |                |               |               |           |           |           | 12408.010 |
| YGroup2ZipBenchmark_Int32    | Sum256Avx2_Unpack             |                |               |     10375.731 | 11292.569 | 11475.125 | 11330.721 | 11986.333 |
| YGroup2ZipBenchmark_Int32    | Sum256Avx2_Widen              |                |               |      5806.822 |  6870.305 |  6773.249 |  6159.853 |  7874.688 |
| YGroup2ZipBenchmark_Int32    | Sum256Traits                  |                |               |     10755.706 | 12067.730 | 11449.479 | 11110.506 | 11946.741 |
| YGroup2ZipBenchmark_Int32    | Sum512Base_Basic              |                |               |               |           |           |           |   465.748 |
| YGroup2ZipBenchmark_Int32    | Sum512Base                    |                |               |               |           |           |           | 10358.249 |
| YGroup2ZipBenchmark_Int32    | Sum512Avx512_Permute          |                |               |               |           |           |           | 16452.672 |
| YGroup2ZipBenchmark_Int32    | Sum512Avx512_Unpack           |                |               |               |           |           |           | 13430.330 |
| YGroup2ZipBenchmark_Int32    | Sum512Avx512_Widen            |                |               |               |           |           |           | 10269.652 |
| YGroup2ZipBenchmark_Int32    | Sum512Traits                  |                |               |               |           |           |           | 16601.793 |
| YGroup2ZipBenchmark_Int64    | SumBase_Basic                 |        139.864 |       208.949 |       268.424 |   148.661 |   271.482 |   257.350 |   263.809 |
| YGroup2ZipBenchmark_Int64    | SumBase                       |        140.239 |       204.758 |       276.004 |   144.431 |   276.758 |   255.823 |   268.844 |
| YGroup2ZipBenchmark_Int64    | SumTraits                     |        140.072 |       204.321 |      5462.039 |  6221.690 |  6143.165 |  5922.926 |  6812.400 |
| YGroup2ZipBenchmark_Int64    | Sum128Base_Basic              |                |               |        77.068 |    77.765 |    76.878 |   163.285 |   169.151 |
| YGroup2ZipBenchmark_Int64    | Sum128Base                    |                |               |        80.957 |    80.402 |    80.002 |   153.315 |   278.823 |
| YGroup2ZipBenchmark_Int64    | Sum128AdvSimd_AlignRight      |                |               |               |           |           |           |           |
| YGroup2ZipBenchmark_Int64    | Sum128AdvSimd_Shuffle         |                |               |               |           |           |           |           |
| YGroup2ZipBenchmark_Int64    | Sum128AdvSimd_ShuffleX        |                |               |               |           |           |           |           |
| YGroup2ZipBenchmark_Int64    | Sum128AdvSimdB64              |                |               |               |           |           |           |           |
| YGroup2ZipBenchmark_Int64    | Sum128PackedSimd_Shuffle      |                |               |               |           |           |           |           |
| YGroup2ZipBenchmark_Int64    | Sum128Sse_Permute             |                |               |               |           |           |           |  3718.110 |
| YGroup2ZipBenchmark_Int64    | Sum128Sse_Unpack              |                |               |      4140.217 |  4086.167 |  3886.524 |  4118.941 |  3849.535 |
| YGroup2ZipBenchmark_Int64    | Sum128Traits                  |                |               |      4042.554 |  3903.111 |  4047.766 |  3610.529 |  4174.581 |
| YGroup2ZipBenchmark_Int64    | Sum256Base_Basic              |                |               |       127.350 |    93.777 |   133.129 |   256.691 |   266.505 |
| YGroup2ZipBenchmark_Int64    | Sum256Base                    |                |               |       134.669 |    86.874 |   133.626 |   255.984 |   269.747 |
| YGroup2ZipBenchmark_Int64    | Sum256Avx2_Permute            |                |               |               |           |           |           |  6827.779 |
| YGroup2ZipBenchmark_Int64    | Sum256Avx2_Unpack             |                |               |      5613.266 |  6180.063 |  6313.031 |  6187.994 |  6461.752 |
| YGroup2ZipBenchmark_Int64    | Sum256Traits                  |                |               |      5586.725 |  6169.405 |  6022.308 |  5754.257 |  6620.095 |
| YGroup2ZipBenchmark_Int64    | Sum512Base_Basic              |                |               |               |           |           |           |   285.733 |
| YGroup2ZipBenchmark_Int64    | Sum512Base                    |                |               |               |           |           |           |   284.226 |
| YGroup2ZipBenchmark_Int64    | Sum512Avx512_Permute          |                |               |               |           |           |           |  8723.450 |
| YGroup2ZipBenchmark_Int64    | Sum512Avx512_Unpack           |                |               |               |           |           |           |  7041.407 |
| YGroup2ZipBenchmark_Int64    | Sum512Traits                  |                |               |               |           |           |           |  8973.013 |

### Arm - Apple M2
| Type                         | Method                        |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :--------------------------- | :---------------------------- | --------: | --------: | --------: |
| YGroup2UnzipBenchmark_Byte   | SumBase_Basic                 |   948.546 |  1236.377 |  1748.526 |
| YGroup2UnzipBenchmark_Byte   | SumBase_Narrow                |           | 27112.984 | 27187.294 |
| YGroup2UnzipBenchmark_Byte   | SumBase_NarrowMul             |  8055.991 |  9059.240 |  9878.565 |
| YGroup2UnzipBenchmark_Byte   | SumBase                       |  8055.920 | 27168.382 | 27192.274 |
| YGroup2UnzipBenchmark_Byte   | SumTraits                     | 27216.212 | 27225.638 | 27230.020 |
| YGroup2UnzipBenchmark_Byte   | Sum128Base_Basic              |   623.366 |  1240.649 |  1748.683 |
| YGroup2UnzipBenchmark_Byte   | Sum128Base                    |   625.853 | 27183.562 | 27197.478 |
| YGroup2UnzipBenchmark_Byte   | Sum128AdvSimd_Narrow          | 27157.758 | 27172.977 | 27196.364 |
| YGroup2UnzipBenchmark_Byte   | Sum128AdvSimd_Shuffle         | 25512.989 | 27000.346 | 27054.744 |
| YGroup2UnzipBenchmark_Byte   | Sum128AdvSimd_ShuffleX        |           |           | 18888.399 |
| YGroup2UnzipBenchmark_Byte   | Sum128AdvSimdB64              | 27214.652 | 27225.977 | 27237.363 |
| YGroup2UnzipBenchmark_Byte   | Sum128PackedSimd_Narrow       |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum128PackedSimd_Shuffle      |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum128PackedSimd_TupleNarrow  |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum128PackedSimd_TupleShuffle |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum128Sse_Narrow              |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum128Sse_Permute             |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum128Sse_Unpack              |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum128Traits                  | 27216.494 | 27216.934 | 27231.839 |
| YGroup2UnzipBenchmark_Byte   | Sum256Base_Basic              |   660.356 |   620.374 |  1787.678 |
| YGroup2UnzipBenchmark_Byte   | Sum256Base                    |   659.419 |   619.489 |  1787.762 |
| YGroup2UnzipBenchmark_Byte   | Sum256Avx2_Narrow             |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum256Avx2_Permute            |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum256Avx2_Unpack             |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum256Traits                  |   660.165 |   620.753 |  1787.829 |
| YGroup2UnzipBenchmark_Byte   | Sum512Base_Basic              |           |           |  1729.632 |
| YGroup2UnzipBenchmark_Byte   | Sum512Base                    |           |           |  1729.086 |
| YGroup2UnzipBenchmark_Byte   | Sum512Avx512_Narrow           |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum512Avx512_Permute          |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum512Avx512_Unpack           |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum512Traits                  |           |           |  1729.020 |
| YGroup2UnzipBenchmark_Int128 | SumBase_Basic                 |   280.543 |   297.240 |   840.742 |
| YGroup2UnzipBenchmark_Int128 | SumBase                       |   307.258 |   298.177 |   818.075 |
| YGroup2UnzipBenchmark_Int128 | SumTraits                     |   307.131 |   177.509 |   741.880 |
| YGroup2UnzipBenchmark_Int128 | SumTraits_Int128              |  1125.894 |  1132.628 |  3402.169 |
| YGroup2UnzipBenchmark_Int128 | Sum128Base_Basic              |   426.120 |  2521.924 |  3400.711 |
| YGroup2UnzipBenchmark_Int128 | Sum128Base                    |   424.830 |  2522.019 |  3401.117 |
| YGroup2UnzipBenchmark_Int128 | Sum128Traits                  |  2523.511 |  2522.192 |  3401.047 |
| YGroup2UnzipBenchmark_Int128 | Sum128Traits_Int128           |  3401.545 |  3401.209 |  3401.308 |
| YGroup2UnzipBenchmark_Int128 | Sum256Base_Basic              |   198.986 |   224.082 |   924.416 |
| YGroup2UnzipBenchmark_Int128 | Sum256Base_Move2              |   215.799 |   199.778 |  6624.754 |
| YGroup2UnzipBenchmark_Int128 | Sum256Base                    |   431.077 |   354.411 |  6623.976 |
| YGroup2UnzipBenchmark_Int128 | Sum256Avx2                    |           |           |           |
| YGroup2UnzipBenchmark_Int128 | Sum256Traits                  |   431.119 |   356.907 |  6625.078 |
| YGroup2UnzipBenchmark_Int128 | Sum256Traits_Int128           |   430.987 |   356.878 |  6624.444 |
| YGroup2UnzipBenchmark_Int128 | Sum512Base_Basic              |           |           |   752.686 |
| YGroup2UnzipBenchmark_Int128 | Sum512Base                    |           |           | 11448.000 |
| YGroup2UnzipBenchmark_Int128 | Sum512Avx512                  |           |           |           |
| YGroup2UnzipBenchmark_Int128 | Sum512Traits                  |           |           | 11450.213 |
| YGroup2UnzipBenchmark_Int128 | Sum512Traits_Int128           |           |           | 11448.456 |
| YGroup2UnzipBenchmark_Int16  | SumBase_Basic                 |   655.942 |   923.041 |  1584.459 |
| YGroup2UnzipBenchmark_Int16  | SumBase_Narrow                |           | 13599.794 | 13604.046 |
| YGroup2UnzipBenchmark_Int16  | SumBase_NarrowMul             |  7247.117 |  7760.100 |  8349.315 |
| YGroup2UnzipBenchmark_Int16  | SumBase_NarrowMulOld          |  2880.252 |  3311.524 |  3483.830 |
| YGroup2UnzipBenchmark_Int16  | SumBase                       |  7248.461 | 13598.173 | 13605.269 |
| YGroup2UnzipBenchmark_Int16  | SumTraits                     | 13607.304 | 13610.787 | 13611.175 |
| YGroup2UnzipBenchmark_Int16  | Sum128Base_Basic              |   486.849 |   918.413 |  1583.825 |
| YGroup2UnzipBenchmark_Int16  | Sum128Base                    |   488.560 | 13595.757 | 13604.651 |
| YGroup2UnzipBenchmark_Int16  | Sum128AdvSimd_Narrow          | 13587.433 | 13598.340 | 13604.507 |
| YGroup2UnzipBenchmark_Int16  | Sum128AdvSimd_Shuffle         | 12781.464 | 13378.806 | 13407.121 |
| YGroup2UnzipBenchmark_Int16  | Sum128AdvSimd_ShuffleX        |           |           |  9455.831 |
| YGroup2UnzipBenchmark_Int16  | Sum128AdvSimdB64              | 13599.345 | 13606.431 | 13606.912 |
| YGroup2UnzipBenchmark_Int16  | Sum128PackedSimd_Narrow       |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum128PackedSimd_Shuffle      |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum128PackedSimd_TupleNarrow  |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum128PackedSimd_TupleShuffle |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum128Sse_Narrow              |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum128Sse_Permute             |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum128Sse_ShuffleXImm         |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum128Sse_Unpack              |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum128Traits                  | 13600.267 | 13609.488 | 13611.168 |
| YGroup2UnzipBenchmark_Int16  | Sum256Base_Basic              |   486.572 |   487.407 |  1652.838 |
| YGroup2UnzipBenchmark_Int16  | Sum256Base                    |   487.820 |   484.218 |  1652.459 |
| YGroup2UnzipBenchmark_Int16  | Sum256Avx2_Narrow             |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum256Avx2_Permute            |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum256Avx2_ShuffleXImm        |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum256Avx2_Unpack             |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum256Traits                  |   486.581 |   483.691 |  1652.588 |
| YGroup2UnzipBenchmark_Int16  | Sum512Base_Basic              |           |           |  1555.799 |
| YGroup2UnzipBenchmark_Int16  | Sum512Base                    |           |           |  1555.660 |
| YGroup2UnzipBenchmark_Int16  | Sum512Avx512_Narrow           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum512Avx512_Permute          |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum512Avx512_ShuffleXImm      |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum512Avx512_Unpack           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum512Traits                  |           |           |  1555.760 |
| YGroup2UnzipBenchmark_Int32  | SumBase_Basic                 |   585.122 |   673.648 |  1369.777 |
| YGroup2UnzipBenchmark_Int32  | SumBase_Narrow                |           |  6800.356 |  6801.702 |
| YGroup2UnzipBenchmark_Int32  | SumBase_NarrowMul             |  2862.346 |  3390.759 |  3608.292 |
| YGroup2UnzipBenchmark_Int32  | SumBase                       |  2862.651 |  6799.326 |  6801.895 |
| YGroup2UnzipBenchmark_Int32  | SumTraits                     |  6802.900 |  6803.697 |  6804.044 |
| YGroup2UnzipBenchmark_Int32  | Sum128Base_Basic              |   362.805 |   667.981 |  1369.803 |
| YGroup2UnzipBenchmark_Int32  | Sum128Base                    |   364.304 |  6801.216 |  6801.439 |
| YGroup2UnzipBenchmark_Int32  | Sum128AdvSimd_Narrow          |  6794.164 |  6800.890 |  6801.303 |
| YGroup2UnzipBenchmark_Int32  | Sum128AdvSimd_Shuffle         |  6395.088 |  6698.474 |  6708.523 |
| YGroup2UnzipBenchmark_Int32  | Sum128AdvSimd_ShuffleX        |           |           |  4729.263 |
| YGroup2UnzipBenchmark_Int32  | Sum128AdvSimdB64              |  6801.150 |  6802.758 |  6803.936 |
| YGroup2UnzipBenchmark_Int32  | Sum128PackedSimd_Narrow       |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum128PackedSimd_Shuffle      |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum128PackedSimd_TupleNarrow  |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum128PackedSimd_TupleShuffle |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum128Sse_Narrow              |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum128Sse_Permute             |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum128Sse_ShuffleXImm         |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum128Sse_Unpack              |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum128Traits                  |  6803.283 |  6803.039 |  6804.115 |
| YGroup2UnzipBenchmark_Int32  | Sum256Base_Basic              |   353.287 |   336.489 |  1404.830 |
| YGroup2UnzipBenchmark_Int32  | Sum256Base                    |   355.099 |   336.120 |  1404.999 |
| YGroup2UnzipBenchmark_Int32  | Sum256Avx2_Narrow             |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum256Avx2_Permute            |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum256Avx2_ShuffleXImm        |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum256Avx2_Unpack             |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum256Traits                  |   353.404 |   337.812 |  1404.771 |
| YGroup2UnzipBenchmark_Int32  | Sum512Base_Basic              |           |           |  1266.684 |
| YGroup2UnzipBenchmark_Int32  | Sum512Base                    |           |           |  1267.261 |
| YGroup2UnzipBenchmark_Int32  | Sum512Avx512_Narrow           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum512Avx512_Permute          |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum512Avx512_ShuffleXImm      |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum512Avx512_Unpack           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum512Traits                  |           |           |  1266.870 |
| YGroup2UnzipBenchmark_Int64  | SumBase_Basic                 |   319.251 |   379.511 |   889.691 |
| YGroup2UnzipBenchmark_Int64  | SumBase                       |   345.196 |   381.484 |   889.643 |
| YGroup2UnzipBenchmark_Int64  | SumTraits                     |  3401.203 |  3401.804 |  3401.819 |
| YGroup2UnzipBenchmark_Int64  | Sum128Base_Basic              |   212.771 |   382.723 |   889.508 |
| YGroup2UnzipBenchmark_Int64  | Sum128Base                    |   454.289 |  3400.947 |  3401.540 |
| YGroup2UnzipBenchmark_Int64  | Sum128AdvSimd_AlignRight      |  3400.637 |  3401.239 |  3401.468 |
| YGroup2UnzipBenchmark_Int64  | Sum128AdvSimd_Shuffle         |  3198.080 |  3360.153 |  3362.437 |
| YGroup2UnzipBenchmark_Int64  | Sum128AdvSimd_ShuffleX        |           |           |  2365.289 |
| YGroup2UnzipBenchmark_Int64  | Sum128AdvSimdB64              |  3401.216 |  3401.369 |  3401.213 |
| YGroup2UnzipBenchmark_Int64  | Sum128PackedSimd_Shuffle      |           |           |           |
| YGroup2UnzipBenchmark_Int64  | Sum128PackedSimd_TupleShuffle |           |           |           |
| YGroup2UnzipBenchmark_Int64  | Sum128Sse_Permute             |           |           |           |
| YGroup2UnzipBenchmark_Int64  | Sum128Sse_Unpack              |           |           |           |
| YGroup2UnzipBenchmark_Int64  | Sum128Traits                  |  3401.377 |  3401.488 |  3401.436 |
| YGroup2UnzipBenchmark_Int64  | Sum256Base_Basic              |   204.437 |   193.662 |   940.403 |
| YGroup2UnzipBenchmark_Int64  | Sum256Base                    |   205.079 |   194.447 |   940.803 |
| YGroup2UnzipBenchmark_Int64  | Sum256Avx2_Permute            |           |           |           |
| YGroup2UnzipBenchmark_Int64  | Sum256Avx2_Unpack             |           |           |           |
| YGroup2UnzipBenchmark_Int64  | Sum256Traits                  |   203.752 |   192.699 |   940.511 |
| YGroup2UnzipBenchmark_Int64  | Sum512Base_Basic              |           |           |   758.953 |
| YGroup2UnzipBenchmark_Int64  | Sum512Base                    |           |           |   758.374 |
| YGroup2UnzipBenchmark_Int64  | Sum512Avx512_Permute          |           |           |           |
| YGroup2UnzipBenchmark_Int64  | Sum512Avx512_Unpack           |           |           |           |
| YGroup2UnzipBenchmark_Int64  | Sum512Traits                  |           |           |   758.669 |
| YGroup2ZipBenchmark_Byte     | SumBase_Basic                 |  1121.702 |  1543.253 |  1287.904 |
| YGroup2ZipBenchmark_Byte     | SumBase_Widen                 |           | 27109.222 | 27131.156 |
| YGroup2ZipBenchmark_Byte     | SumBase_WidenMul              | 19735.898 | 25514.269 | 24120.321 |
| YGroup2ZipBenchmark_Byte     | SumBase                       | 19738.304 | 27113.370 | 27128.047 |
| YGroup2ZipBenchmark_Byte     | SumTraits                     | 27208.897 | 27219.139 | 27236.156 |
| YGroup2ZipBenchmark_Byte     | Sum128Base_Basic              |   720.451 |  1543.367 |  1287.897 |
| YGroup2ZipBenchmark_Byte     | Sum128Base                    |   722.013 |  6583.559 | 27141.429 |
| YGroup2ZipBenchmark_Byte     | Sum128AdvSimd_Shuffle         | 10602.375 |  9059.995 |  9062.508 |
| YGroup2ZipBenchmark_Byte     | Sum128AdvSimd_ShuffleX        |           |           | 17143.654 |
| YGroup2ZipBenchmark_Byte     | Sum128AdvSimd_Widen           | 24113.131 | 27113.828 | 27127.240 |
| YGroup2ZipBenchmark_Byte     | Sum128AdvSimdB64              | 27204.146 | 27232.113 | 27235.786 |
| YGroup2ZipBenchmark_Byte     | Sum128PackedSimd_Widen        |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum128PackedSimd_Shuffle      |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum128Sse_Permute             |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum128Sse_Unpack              |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum128Sse_Widen               |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum128Traits                  | 27201.822 | 27228.560 | 27229.664 |
| YGroup2ZipBenchmark_Byte     | Sum256Base_Basic              |   685.865 |   646.220 |  1358.219 |
| YGroup2ZipBenchmark_Byte     | Sum256Base                    |   666.452 |   645.861 |  1358.339 |
| YGroup2ZipBenchmark_Byte     | Sum256Avx2_Permute            |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum256Avx2_Unpack             |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum256Avx2_Widen              |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum256Traits                  |   668.493 |   645.922 |  1358.307 |
| YGroup2ZipBenchmark_Byte     | Sum512Base_Basic              |           |           |  1357.760 |
| YGroup2ZipBenchmark_Byte     | Sum512Base                    |           |           |  1356.758 |
| YGroup2ZipBenchmark_Byte     | Sum512Avx512_Permute          |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum512Avx512_Unpack           |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum512Avx512_Widen            |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum512Traits                  |           |           |  1357.628 |
| YGroup2ZipBenchmark_Int128   | SumBase_Basic                 |   612.563 |   318.807 |   286.229 |
| YGroup2ZipBenchmark_Int128   | SumBase                       |   606.832 |   322.852 |   284.750 |
| YGroup2ZipBenchmark_Int128   | SumTraits                     |   606.860 |   153.972 |   741.938 |
| YGroup2ZipBenchmark_Int128   | SumTraits_Int128              |  1125.858 |  1132.459 |  3401.442 |
| YGroup2ZipBenchmark_Int128   | Sum128Base_Basic              |   425.274 |  2522.336 |  3400.855 |
| YGroup2ZipBenchmark_Int128   | Sum128Base                    |   421.698 |  2496.349 |  3400.717 |
| YGroup2ZipBenchmark_Int128   | Sum128Traits                  |  2523.555 |  2496.518 |  3400.717 |
| YGroup2ZipBenchmark_Int128   | Sum128Traits_Int128           |  3401.307 |  3401.096 |  3401.389 |
| YGroup2ZipBenchmark_Int128   | Sum256Base_Basic              |   228.535 |   271.255 |   688.399 |
| YGroup2ZipBenchmark_Int128   | Sum256Base_Move2              |   215.799 |   199.767 |  6622.375 |
| YGroup2ZipBenchmark_Int128   | Sum256Base                    |   430.897 |   354.430 |  6623.064 |
| YGroup2ZipBenchmark_Int128   | Sum256Avx2                    |           |           |           |
| YGroup2ZipBenchmark_Int128   | Sum256Traits                  |   431.013 |   357.199 |  6620.656 |
| YGroup2ZipBenchmark_Int128   | Sum256Traits_Int128           |   431.001 |   357.059 |  6622.403 |
| YGroup2ZipBenchmark_Int128   | Sum512Base_Basic              |           |           |   675.505 |
| YGroup2ZipBenchmark_Int128   | Sum512Base                    |           |           | 11444.364 |
| YGroup2ZipBenchmark_Int128   | Sum512Avx512                  |           |           |           |
| YGroup2ZipBenchmark_Int128   | Sum512Avx512_Imm              |           |           |           |
| YGroup2ZipBenchmark_Int128   | Sum512Traits                  |           |           | 11446.472 |
| YGroup2ZipBenchmark_Int128   | Sum512Traits_Int128           |           |           | 11449.772 |
| YGroup2ZipBenchmark_Int16    | SumBase_Basic                 |   888.167 |  1265.140 |  1106.338 |
| YGroup2ZipBenchmark_Int16    | SumBase_Widen                 |           | 13578.901 | 13584.325 |
| YGroup2ZipBenchmark_Int16    | SumBase_WidenMul              |  9881.644 | 12784.629 | 12081.156 |
| YGroup2ZipBenchmark_Int16    | SumBase                       |  9882.532 | 13580.188 | 13587.563 |
| YGroup2ZipBenchmark_Int16    | SumTraits                     | 13600.489 | 13606.474 | 13614.762 |
| YGroup2ZipBenchmark_Int16    | Sum128Base_Basic              |   621.228 |  1264.943 |  1106.475 |
| YGroup2ZipBenchmark_Int16    | Sum128Base                    |   620.015 |  3279.651 | 13587.827 |
| YGroup2ZipBenchmark_Int16    | Sum128AdvSimd_Shuffle         |  5304.443 |  4532.203 |  4534.170 |
| YGroup2ZipBenchmark_Int16    | Sum128AdvSimd_ShuffleX        |           |           |  8536.831 |
| YGroup2ZipBenchmark_Int16    | Sum128AdvSimd_Widen           | 12074.034 | 13580.561 | 13585.499 |
| YGroup2ZipBenchmark_Int16    | Sum128AdvSimdB64              | 13596.118 | 13603.788 | 13607.363 |
| YGroup2ZipBenchmark_Int16    | Sum128PackedSimd_Widen        |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum128PackedSimd_Shuffle      |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum128Sse_Permute             |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum128Sse_Unpack              |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum128Sse_Widen               |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum128Traits                  | 13599.582 | 13603.560 | 13609.137 |
| YGroup2ZipBenchmark_Int16    | Sum256Base_Basic              |   540.506 |   556.347 |  1226.441 |
| YGroup2ZipBenchmark_Int16    | Sum256Base                    |   541.037 |   553.587 |  1226.412 |
| YGroup2ZipBenchmark_Int16    | Sum256Avx2_Permute            |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum256Avx2_Unpack             |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum256Avx2_Widen              |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum256Traits                  |   541.202 |   553.510 |  1226.342 |
| YGroup2ZipBenchmark_Int16    | Sum512Base_Basic              |           |           |  1185.633 |
| YGroup2ZipBenchmark_Int16    | Sum512Base                    |           |           |  1185.650 |
| YGroup2ZipBenchmark_Int16    | Sum512Avx512_Permute          |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum512Avx512_Unpack           |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum512Avx512_Widen            |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum512Traits                  |           |           |  1185.631 |
| YGroup2ZipBenchmark_Int32    | SumBase_Basic                 |   730.301 |  1206.318 |  1219.745 |
| YGroup2ZipBenchmark_Int32    | SumBase_Widen                 |           |  6797.140 |  6794.697 |
| YGroup2ZipBenchmark_Int32    | SumBase                       |   730.289 |  6796.200 |  6796.244 |
| YGroup2ZipBenchmark_Int32    | SumTraits                     |  6803.525 |  6803.240 |  6802.782 |
| YGroup2ZipBenchmark_Int32    | Sum128Base_Basic              |   512.378 |  1206.010 |  1219.878 |
| YGroup2ZipBenchmark_Int32    | Sum128Base                    |   512.413 |  1639.939 |  6795.693 |
| YGroup2ZipBenchmark_Int32    | Sum128AdvSimd_Shuffle         |  2653.502 |  2266.772 |  2267.534 |
| YGroup2ZipBenchmark_Int32    | Sum128AdvSimd_ShuffleX        |           |           |  4245.319 |
| YGroup2ZipBenchmark_Int32    | Sum128AdvSimd_Widen           |  6040.927 |  6796.707 |  6797.458 |
| YGroup2ZipBenchmark_Int32    | Sum128AdvSimdB64              |  6802.342 |  6804.787 |  6805.139 |
| YGroup2ZipBenchmark_Int32    | Sum128PackedSimd_Widen        |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum128PackedSimd_Shuffle      |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum128Sse_Permute             |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum128Sse_Unpack              |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum128Sse_Widen               |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum128Traits                  |  6803.460 |  6803.010 |  6803.670 |
| YGroup2ZipBenchmark_Int32    | Sum256Base_Basic              |   381.202 |   401.786 |  1020.960 |
| YGroup2ZipBenchmark_Int32    | Sum256Base                    |   382.671 |   402.298 |  1019.403 |
| YGroup2ZipBenchmark_Int32    | Sum256Avx2_Permute            |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum256Avx2_Unpack             |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum256Avx2_Widen              |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum256Traits                  |   382.715 |   403.942 |  1016.452 |
| YGroup2ZipBenchmark_Int32    | Sum512Base_Basic              |           |           |   973.158 |
| YGroup2ZipBenchmark_Int32    | Sum512Base                    |           |           |   973.209 |
| YGroup2ZipBenchmark_Int32    | Sum512Avx512_Permute          |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum512Avx512_Unpack           |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum512Avx512_Widen            |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum512Traits                  |           |           |   972.998 |
| YGroup2ZipBenchmark_Int64    | SumBase_Basic                 |   724.382 |   733.905 |   786.087 |
| YGroup2ZipBenchmark_Int64    | SumBase                       |   724.472 |   734.006 |   786.090 |
| YGroup2ZipBenchmark_Int64    | SumTraits                     |  3401.132 |  3401.917 |  3401.456 |
| YGroup2ZipBenchmark_Int64    | Sum128Base_Basic              |   283.655 |   733.912 |   786.092 |
| YGroup2ZipBenchmark_Int64    | Sum128Base                    |   454.511 |  3400.374 |  3400.940 |
| YGroup2ZipBenchmark_Int64    | Sum128AdvSimd_AlignRight      |  3400.754 |  3400.448 |  3400.811 |
| YGroup2ZipBenchmark_Int64    | Sum128AdvSimd_Shuffle         |  1326.952 |  1133.603 |  1133.602 |
| YGroup2ZipBenchmark_Int64    | Sum128AdvSimd_ShuffleX        |           |           |  2112.837 |
| YGroup2ZipBenchmark_Int64    | Sum128AdvSimdB64              |  3401.017 |  3400.125 |  3401.982 |
| YGroup2ZipBenchmark_Int64    | Sum128PackedSimd_Shuffle      |           |           |           |
| YGroup2ZipBenchmark_Int64    | Sum128Sse_Permute             |           |           |           |
| YGroup2ZipBenchmark_Int64    | Sum128Sse_Unpack              |           |           |           |
| YGroup2ZipBenchmark_Int64    | Sum128Traits                  |  3401.527 |  3401.368 |  3401.445 |
| YGroup2ZipBenchmark_Int64    | Sum256Base_Basic              |   220.094 |   234.283 |   917.870 |
| YGroup2ZipBenchmark_Int64    | Sum256Base                    |   220.356 |   233.760 |   909.844 |
| YGroup2ZipBenchmark_Int64    | Sum256Avx2_Permute            |           |           |           |
| YGroup2ZipBenchmark_Int64    | Sum256Avx2_Unpack             |           |           |           |
| YGroup2ZipBenchmark_Int64    | Sum256Traits                  |   219.948 |   234.140 |   913.326 |
| YGroup2ZipBenchmark_Int64    | Sum512Base_Basic              |           |           |   610.684 |
| YGroup2ZipBenchmark_Int64    | Sum512Base                    |           |           |   607.372 |
| YGroup2ZipBenchmark_Int64    | Sum512Avx512_Permute          |           |           |           |
| YGroup2ZipBenchmark_Int64    | Sum512Avx512_Unpack           |           |           |           |
| YGroup2ZipBenchmark_Int64    | Sum512Traits                  |           |           |   609.863 |

### Arm - AWS Arm t4g.small
| Type                         | Method                        | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :--------------------------- | :---------------------------- | ------------: | --------: | --------: | --------: | --------: |
| YGroup2UnzipBenchmark_Byte   | SumBase_Basic                 |       352.186 |   349.696 |   350.145 |   417.446 |   511.599 |
| YGroup2UnzipBenchmark_Byte   | SumBase_Narrow                |               |           |           |  9124.239 | 10958.598 |
| YGroup2UnzipBenchmark_Byte   | SumBase_NarrowMul             |      1792.734 |  2157.173 |  2161.706 |  1951.887 |  2540.004 |
| YGroup2UnzipBenchmark_Byte   | SumBase                       |      1796.479 |  2146.987 |  2162.039 |  9149.776 | 10999.133 |
| YGroup2UnzipBenchmark_Byte   | SumTraits                     |      1784.551 | 14317.845 | 14312.472 | 15426.049 | 15792.797 |
| YGroup2UnzipBenchmark_Byte   | Sum128Base_Basic              |       198.069 |   199.951 |   201.988 |   419.401 |   512.095 |
| YGroup2UnzipBenchmark_Byte   | Sum128Base                    |       189.871 |   201.171 |   199.817 |  9013.528 | 11005.041 |
| YGroup2UnzipBenchmark_Byte   | Sum128AdvSimd_Narrow          |               |  9722.612 |  9676.080 |  8994.923 | 10964.085 |
| YGroup2UnzipBenchmark_Byte   | Sum128AdvSimd_Shuffle         |               |  8777.794 |  8873.821 |  8667.225 |  9593.057 |
| YGroup2UnzipBenchmark_Byte   | Sum128AdvSimd_ShuffleX        |               |           |           |           |  5614.445 |
| YGroup2UnzipBenchmark_Byte   | Sum128AdvSimdB64              |               | 13196.828 | 13179.033 | 15435.179 | 15788.919 |
| YGroup2UnzipBenchmark_Byte   | Sum128PackedSimd_Narrow       |               |           |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum128PackedSimd_Shuffle      |               |           |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum128PackedSimd_TupleNarrow  |               |           |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum128PackedSimd_TupleShuffle |               |           |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum128Sse_Narrow              |               |           |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum128Sse_Permute             |               |           |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum128Sse_Unpack              |               |           |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum128Traits                  |       189.979 | 13211.635 | 13207.521 | 15456.177 | 15794.165 |
| YGroup2UnzipBenchmark_Byte   | Sum256Base_Basic              |       200.063 |   220.414 |   224.463 |   202.224 |   558.695 |
| YGroup2UnzipBenchmark_Byte   | Sum256Base                    |       195.924 |   219.825 |   221.813 |   202.334 |   559.293 |
| YGroup2UnzipBenchmark_Byte   | Sum256Avx2_Narrow             |               |           |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum256Avx2_Permute            |               |           |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum256Avx2_Unpack             |               |           |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum256Traits                  |       181.636 |   218.120 |   221.852 |   202.441 |   559.295 |
| YGroup2UnzipBenchmark_Byte   | Sum512Base_Basic              |               |           |           |           |   594.679 |
| YGroup2UnzipBenchmark_Byte   | Sum512Base                    |               |           |           |           |   594.510 |
| YGroup2UnzipBenchmark_Byte   | Sum512Avx512_Narrow           |               |           |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum512Avx512_Permute          |               |           |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum512Avx512_Unpack           |               |           |           |           |           |
| YGroup2UnzipBenchmark_Byte   | Sum512Traits                  |               |           |           |           |   594.687 |
| YGroup2UnzipBenchmark_Int128 | SumBase_Basic                 |        49.993 |           |   106.229 |   102.215 |   223.200 |
| YGroup2UnzipBenchmark_Int128 | SumBase                       |        46.971 |           |   113.171 |   101.408 |   218.673 |
| YGroup2UnzipBenchmark_Int128 | SumTraits                     |        41.858 |           |   113.104 |   131.904 |   221.721 |
| YGroup2UnzipBenchmark_Int128 | SumTraits_Int128              |       411.571 |           |   679.502 |   706.533 |  2461.223 |
| YGroup2UnzipBenchmark_Int128 | Sum128Base_Basic              |       236.397 |           |   238.416 |   769.070 |   712.920 |
| YGroup2UnzipBenchmark_Int128 | Sum128Base                    |       239.711 |           |   239.012 |   776.767 |   708.350 |
| YGroup2UnzipBenchmark_Int128 | Sum128Traits                  |       241.185 |           |   776.068 |   781.998 |   708.388 |
| YGroup2UnzipBenchmark_Int128 | Sum128Traits_Int128           |       252.728 |           |  2103.017 |  2475.148 |  2463.030 |
| YGroup2UnzipBenchmark_Int128 | Sum256Base_Basic              |        48.690 |           |    87.496 |    89.646 |   319.869 |
| YGroup2UnzipBenchmark_Int128 | Sum256Base_Move2              |        37.601 |           |    89.044 |    88.330 |  3644.502 |
| YGroup2UnzipBenchmark_Int128 | Sum256Base                    |        45.343 |           |   159.007 |   146.326 |  3658.334 |
| YGroup2UnzipBenchmark_Int128 | Sum256Avx2                    |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int128 | Sum256Traits                  |        39.245 |           |   157.040 |   150.557 |  3659.600 |
| YGroup2UnzipBenchmark_Int128 | Sum256Traits_Int128           |        70.498 |           |   157.067 |   150.544 |  3651.340 |
| YGroup2UnzipBenchmark_Int128 | Sum512Base_Basic              |               |           |           |           |   379.616 |
| YGroup2UnzipBenchmark_Int128 | Sum512Base                    |               |           |           |           |  3729.378 |
| YGroup2UnzipBenchmark_Int128 | Sum512Avx512                  |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int128 | Sum512Traits                  |               |           |           |           |  3731.021 |
| YGroup2UnzipBenchmark_Int128 | Sum512Traits_Int128           |               |           |           |           |  3672.483 |
| YGroup2UnzipBenchmark_Int16  | SumBase_Basic                 |       247.372 |           |   251.127 |   283.178 |   361.087 |
| YGroup2UnzipBenchmark_Int16  | SumBase_Narrow                |               |           |           |  4912.155 |  4622.297 |
| YGroup2UnzipBenchmark_Int16  | SumBase_NarrowMul             |      1604.007 |           |  1719.777 |  1808.506 |  1997.059 |
| YGroup2UnzipBenchmark_Int16  | SumBase_NarrowMulOld          |       730.857 |           |   829.924 |   827.592 |   990.278 |
| YGroup2UnzipBenchmark_Int16  | SumBase                       |      1604.491 |           |  1718.645 |  4911.557 |  4660.692 |
| YGroup2UnzipBenchmark_Int16  | SumTraits                     |      1600.161 |           |  6546.330 |  7908.844 |  7738.322 |
| YGroup2UnzipBenchmark_Int16  | Sum128Base_Basic              |       142.689 |           |   143.644 |   282.928 |   362.220 |
| YGroup2UnzipBenchmark_Int16  | Sum128Base                    |       142.446 |           |   142.129 |  4903.024 |  4634.583 |
| YGroup2UnzipBenchmark_Int16  | Sum128AdvSimd_Narrow          |               |           |  4371.329 |  4917.511 |  4691.210 |
| YGroup2UnzipBenchmark_Int16  | Sum128AdvSimd_Shuffle         |               |           |  4192.131 |  4856.715 |  4470.337 |
| YGroup2UnzipBenchmark_Int16  | Sum128AdvSimd_ShuffleX        |               |           |           |           |  2623.243 |
| YGroup2UnzipBenchmark_Int16  | Sum128AdvSimdB64              |               |           |  6988.773 |  7912.926 |  7720.611 |
| YGroup2UnzipBenchmark_Int16  | Sum128PackedSimd_Narrow       |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum128PackedSimd_Shuffle      |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum128PackedSimd_TupleNarrow  |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum128PackedSimd_TupleShuffle |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum128Sse_Narrow              |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum128Sse_Permute             |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum128Sse_ShuffleXImm         |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum128Sse_Unpack              |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum128Traits                  |       142.125 |           |  6507.695 |  7894.178 |  7719.003 |
| YGroup2UnzipBenchmark_Int16  | Sum256Base_Basic              |       122.343 |           |   161.122 |   144.799 |   426.586 |
| YGroup2UnzipBenchmark_Int16  | Sum256Base                    |       120.358 |           |   160.012 |   142.047 |   425.650 |
| YGroup2UnzipBenchmark_Int16  | Sum256Avx2_Narrow             |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum256Avx2_Permute            |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum256Avx2_ShuffleXImm        |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum256Avx2_Unpack             |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum256Traits                  |       108.126 |           |   160.404 |   142.265 |   419.164 |
| YGroup2UnzipBenchmark_Int16  | Sum512Base_Basic              |               |           |           |           |   390.409 |
| YGroup2UnzipBenchmark_Int16  | Sum512Base                    |               |           |           |           |   394.562 |
| YGroup2UnzipBenchmark_Int16  | Sum512Avx512_Narrow           |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum512Avx512_Permute          |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum512Avx512_ShuffleXImm      |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum512Avx512_Unpack           |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int16  | Sum512Traits                  |               |           |           |           |   398.845 |
| YGroup2UnzipBenchmark_Int32  | SumBase_Basic                 |       215.513 |           |   207.479 |   193.830 |   226.133 |
| YGroup2UnzipBenchmark_Int32  | SumBase_Narrow                |               |           |           |  2449.943 |  2341.259 |
| YGroup2UnzipBenchmark_Int32  | SumBase_NarrowMul             |       707.813 |           |   801.319 |   834.735 |  1005.461 |
| YGroup2UnzipBenchmark_Int32  | SumBase                       |       711.491 |           |   801.392 |  2451.481 |  2335.918 |
| YGroup2UnzipBenchmark_Int32  | SumTraits                     |       710.183 |           |  3251.162 |  3936.106 |  3832.155 |
| YGroup2UnzipBenchmark_Int32  | Sum128Base_Basic              |        98.035 |           |    98.009 |   194.888 |   232.817 |
| YGroup2UnzipBenchmark_Int32  | Sum128Base                    |        97.817 |           |    98.131 |  2452.245 |  2328.414 |
| YGroup2UnzipBenchmark_Int32  | Sum128AdvSimd_Narrow          |               |           |  2208.068 |  2449.484 |  2337.967 |
| YGroup2UnzipBenchmark_Int32  | Sum128AdvSimd_Shuffle         |               |           |  2074.507 |  2382.296 |  2175.620 |
| YGroup2UnzipBenchmark_Int32  | Sum128AdvSimd_ShuffleX        |               |           |           |           |  1320.009 |
| YGroup2UnzipBenchmark_Int32  | Sum128AdvSimdB64              |               |           |  3255.483 |  3933.544 |  3825.216 |
| YGroup2UnzipBenchmark_Int32  | Sum128PackedSimd_Narrow       |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum128PackedSimd_Shuffle      |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum128PackedSimd_TupleNarrow  |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum128PackedSimd_TupleShuffle |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum128Sse_Narrow              |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum128Sse_Permute             |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum128Sse_ShuffleXImm         |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum128Sse_Unpack              |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum128Traits                  |        97.989 |           |  3455.241 |  3935.176 |  3825.070 |
| YGroup2UnzipBenchmark_Int32  | Sum256Base_Basic              |        80.997 |           |   109.518 |   107.915 |   356.309 |
| YGroup2UnzipBenchmark_Int32  | Sum256Base                    |        78.438 |           |   107.614 |   107.775 |   356.183 |
| YGroup2UnzipBenchmark_Int32  | Sum256Avx2_Narrow             |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum256Avx2_Permute            |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum256Avx2_ShuffleXImm        |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum256Avx2_Unpack             |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum256Traits                  |        69.169 |           |   107.545 |   107.834 |   356.241 |
| YGroup2UnzipBenchmark_Int32  | Sum512Base_Basic              |               |           |           |           |   398.580 |
| YGroup2UnzipBenchmark_Int32  | Sum512Base                    |               |           |           |           |   399.378 |
| YGroup2UnzipBenchmark_Int32  | Sum512Avx512_Narrow           |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum512Avx512_Permute          |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum512Avx512_ShuffleXImm      |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum512Avx512_Unpack           |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int32  | Sum512Traits                  |               |           |           |           |   399.707 |
| YGroup2UnzipBenchmark_Int64  | SumBase_Basic                 |       143.649 |           |   135.996 |   123.099 |   217.269 |
| YGroup2UnzipBenchmark_Int64  | SumBase                       |       144.940 |           |   135.666 |   122.758 |   217.076 |
| YGroup2UnzipBenchmark_Int64  | SumTraits                     |       144.962 |           |  1629.354 |  1967.163 |  2039.335 |
| YGroup2UnzipBenchmark_Int64  | Sum128Base_Basic              |        95.890 |           |    92.288 |   124.230 |   218.512 |
| YGroup2UnzipBenchmark_Int64  | Sum128Base                    |       142.678 |           |   247.745 |  1399.690 |  1302.042 |
| YGroup2UnzipBenchmark_Int64  | Sum128AdvSimd_AlignRight      |               |           |  1471.969 |  1638.410 |  1646.121 |
| YGroup2UnzipBenchmark_Int64  | Sum128AdvSimd_Shuffle         |               |           |  1038.324 |  1188.528 |  1083.446 |
| YGroup2UnzipBenchmark_Int64  | Sum128AdvSimd_ShuffleX        |               |           |           |           |   664.462 |
| YGroup2UnzipBenchmark_Int64  | Sum128AdvSimdB64              |               |           |  1748.315 |  1970.058 |  2038.573 |
| YGroup2UnzipBenchmark_Int64  | Sum128PackedSimd_Shuffle      |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int64  | Sum128PackedSimd_TupleShuffle |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int64  | Sum128Sse_Permute             |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int64  | Sum128Sse_Unpack              |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int64  | Sum128Traits                  |       140.214 |           |  1752.798 |  1967.563 |  2038.541 |
| YGroup2UnzipBenchmark_Int64  | Sum256Base_Basic              |        52.526 |           |    79.660 |    78.242 |   320.812 |
| YGroup2UnzipBenchmark_Int64  | Sum256Base                    |        51.376 |           |    80.620 |    78.510 |   324.909 |
| YGroup2UnzipBenchmark_Int64  | Sum256Avx2_Permute            |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int64  | Sum256Avx2_Unpack             |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int64  | Sum256Traits                  |        43.376 |           |    79.736 |    78.398 |   319.952 |
| YGroup2UnzipBenchmark_Int64  | Sum512Base_Basic              |               |           |           |           |   307.005 |
| YGroup2UnzipBenchmark_Int64  | Sum512Base                    |               |           |           |           |   306.441 |
| YGroup2UnzipBenchmark_Int64  | Sum512Avx512_Permute          |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int64  | Sum512Avx512_Unpack           |               |           |           |           |           |
| YGroup2UnzipBenchmark_Int64  | Sum512Traits                  |               |           |           |           |   307.039 |
| YGroup2ZipBenchmark_Byte     | SumBase_Basic                 |       373.460 |           |   376.611 |   530.784 |   440.321 |
| YGroup2ZipBenchmark_Byte     | SumBase_Widen                 |               |           |           |  6261.387 |  7183.963 |
| YGroup2ZipBenchmark_Byte     | SumBase_WidenMul              |      5061.669 |           |  5621.488 |  5969.741 |  6595.281 |
| YGroup2ZipBenchmark_Byte     | SumBase                       |      5064.680 |           |  5617.840 |  6259.288 |  7176.134 |
| YGroup2ZipBenchmark_Byte     | SumTraits                     |      5058.821 |           | 14322.424 | 15381.737 | 15794.681 |
| YGroup2ZipBenchmark_Byte     | Sum128Base_Basic              |       219.163 |           |   219.361 |   531.183 |   442.525 |
| YGroup2ZipBenchmark_Byte     | Sum128Base                    |       219.117 |           |   219.361 |  1835.321 |  6628.918 |
| YGroup2ZipBenchmark_Byte     | Sum128AdvSimd_Shuffle         |               |           |  3515.619 |  3293.795 |  3319.072 |
| YGroup2ZipBenchmark_Byte     | Sum128AdvSimd_ShuffleX        |               |           |           |           |  4976.204 |
| YGroup2ZipBenchmark_Byte     | Sum128AdvSimd_Widen           |               |           |  7164.315 |  6518.091 |  6624.209 |
| YGroup2ZipBenchmark_Byte     | Sum128AdvSimdB64              |               |           | 13204.449 | 15427.259 | 15789.340 |
| YGroup2ZipBenchmark_Byte     | Sum128PackedSimd_Widen        |               |           |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum128PackedSimd_Shuffle      |               |           |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum128Sse_Permute             |               |           |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum128Sse_Unpack              |               |           |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum128Sse_Widen               |               |           |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum128Traits                  |       219.102 |           | 13211.278 | 15429.306 | 15795.076 |
| YGroup2ZipBenchmark_Byte     | Sum256Base_Basic              |       227.549 |           |   231.519 |   210.104 |   494.819 |
| YGroup2ZipBenchmark_Byte     | Sum256Base                    |       223.521 |           |   226.590 |   211.659 |   482.329 |
| YGroup2ZipBenchmark_Byte     | Sum256Avx2_Permute            |               |           |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum256Avx2_Unpack             |               |           |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum256Avx2_Widen              |               |           |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum256Traits                  |       203.696 |           |   223.929 |   211.540 |   491.964 |
| YGroup2ZipBenchmark_Byte     | Sum512Base_Basic              |               |           |           |           |   478.471 |
| YGroup2ZipBenchmark_Byte     | Sum512Base                    |               |           |           |           |   478.727 |
| YGroup2ZipBenchmark_Byte     | Sum512Avx512_Permute          |               |           |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum512Avx512_Unpack           |               |           |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum512Avx512_Widen            |               |           |           |           |           |
| YGroup2ZipBenchmark_Byte     | Sum512Traits                  |               |           |           |           |   477.994 |
| YGroup2ZipBenchmark_Int128   | SumBase_Basic                 |        71.792 |           |   176.224 |   210.831 |   226.327 |
| YGroup2ZipBenchmark_Int128   | SumBase                       |        68.499 |           |   168.623 |   209.541 |   223.200 |
| YGroup2ZipBenchmark_Int128   | SumTraits                     |        60.459 |           |   169.025 |   130.363 |   221.904 |
| YGroup2ZipBenchmark_Int128   | SumTraits_Int128              |       411.885 |           |   679.400 |   493.989 |  2459.241 |
| YGroup2ZipBenchmark_Int128   | Sum128Base_Basic              |       240.042 |           |   239.137 |   758.244 |   707.855 |
| YGroup2ZipBenchmark_Int128   | Sum128Base                    |       234.820 |           |   238.438 |   775.426 |   707.634 |
| YGroup2ZipBenchmark_Int128   | Sum128Traits                  |       237.563 |           |   779.110 |   796.993 |   713.031 |
| YGroup2ZipBenchmark_Int128   | Sum128Traits_Int128           |       254.734 |           |  2104.020 |  2463.460 |  2458.112 |
| YGroup2ZipBenchmark_Int128   | Sum256Base_Basic              |        65.011 |           |    84.676 |   121.972 |   239.216 |
| YGroup2ZipBenchmark_Int128   | Sum256Base_Move2              |        37.622 |           |    88.928 |    88.028 |  3655.190 |
| YGroup2ZipBenchmark_Int128   | Sum256Base                    |        45.363 |           |   157.002 |   147.168 |  3648.767 |
| YGroup2ZipBenchmark_Int128   | Sum256Avx2                    |               |           |           |           |           |
| YGroup2ZipBenchmark_Int128   | Sum256Traits                  |        38.957 |           |   159.013 |   150.721 |  3643.074 |
| YGroup2ZipBenchmark_Int128   | Sum256Traits_Int128           |        70.642 |           |   157.259 |   150.199 |  3643.086 |
| YGroup2ZipBenchmark_Int128   | Sum512Base_Basic              |               |           |           |           |   328.579 |
| YGroup2ZipBenchmark_Int128   | Sum512Base                    |               |           |           |           |  3729.549 |
| YGroup2ZipBenchmark_Int128   | Sum512Avx512                  |               |           |           |           |           |
| YGroup2ZipBenchmark_Int128   | Sum512Avx512_Imm              |               |           |           |           |           |
| YGroup2ZipBenchmark_Int128   | Sum512Traits                  |               |           |           |           |  3602.522 |
| YGroup2ZipBenchmark_Int128   | Sum512Traits_Int128           |               |           |           |           |  3556.751 |
| YGroup2ZipBenchmark_Int16    | SumBase_Basic                 |       288.652 |           |   287.748 |   393.083 |   368.001 |
| YGroup2ZipBenchmark_Int16    | SumBase_Widen                 |               |           |           |  3586.023 |  3098.139 |
| YGroup2ZipBenchmark_Int16    | SumBase_WidenMul              |      2529.726 |           |  2809.261 |  3035.410 |  3224.324 |
| YGroup2ZipBenchmark_Int16    | SumBase                       |      2530.327 |           |  2820.679 |  3585.032 |  3096.970 |
| YGroup2ZipBenchmark_Int16    | SumTraits                     |      2529.287 |           |  6546.508 |  7907.114 |  7739.642 |
| YGroup2ZipBenchmark_Int16    | Sum128Base_Basic              |       157.822 |           |   156.628 |   393.150 |   367.855 |
| YGroup2ZipBenchmark_Int16    | Sum128Base                    |       157.748 |           |   156.593 |   945.230 |  3484.235 |
| YGroup2ZipBenchmark_Int16    | Sum128AdvSimd_Shuffle         |               |           |  1908.404 |  1658.058 |  1650.880 |
| YGroup2ZipBenchmark_Int16    | Sum128AdvSimd_ShuffleX        |               |           |           |           |  2447.788 |
| YGroup2ZipBenchmark_Int16    | Sum128AdvSimd_Widen           |               |           |  3352.884 |  3329.484 |  3138.530 |
| YGroup2ZipBenchmark_Int16    | Sum128AdvSimdB64              |               |           |  7013.915 |  7917.256 |  7715.407 |
| YGroup2ZipBenchmark_Int16    | Sum128PackedSimd_Widen        |               |           |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum128PackedSimd_Shuffle      |               |           |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum128Sse_Permute             |               |           |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum128Sse_Unpack              |               |           |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum128Sse_Widen               |               |           |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum128Traits                  |       157.731 |           |  7000.348 |  7896.674 |  7716.376 |
| YGroup2ZipBenchmark_Int16    | Sum256Base_Basic              |       144.908 |           |   161.702 |   164.566 |   421.897 |
| YGroup2ZipBenchmark_Int16    | Sum256Base                    |       142.252 |           |   162.633 |   164.158 |   422.191 |
| YGroup2ZipBenchmark_Int16    | Sum256Avx2_Permute            |               |           |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum256Avx2_Unpack             |               |           |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum256Avx2_Widen              |               |           |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum256Traits                  |       125.869 |           |   162.514 |   164.344 |   422.057 |
| YGroup2ZipBenchmark_Int16    | Sum512Base_Basic              |               |           |           |           |   393.786 |
| YGroup2ZipBenchmark_Int16    | Sum512Base                    |               |           |           |           |   393.911 |
| YGroup2ZipBenchmark_Int16    | Sum512Avx512_Permute          |               |           |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum512Avx512_Unpack           |               |           |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum512Avx512_Widen            |               |           |           |           |           |
| YGroup2ZipBenchmark_Int16    | Sum512Traits                  |               |           |           |           |   391.688 |
| YGroup2ZipBenchmark_Int32    | SumBase_Basic                 |       244.951 |           |   234.289 |   257.412 |   254.144 |
| YGroup2ZipBenchmark_Int32    | SumBase_Widen                 |               |           |           |  1723.674 |  1634.399 |
| YGroup2ZipBenchmark_Int32    | SumBase                       |       247.256 |           |   234.782 |  1730.584 |  1593.436 |
| YGroup2ZipBenchmark_Int32    | SumTraits                     |       247.826 |           |  3246.151 |  3931.981 |  3819.619 |
| YGroup2ZipBenchmark_Int32    | Sum128Base_Basic              |       109.405 |           |   108.990 |   254.298 |   254.237 |
| YGroup2ZipBenchmark_Int32    | Sum128Base                    |       109.356 |           |   109.194 |   471.057 |  1573.206 |
| YGroup2ZipBenchmark_Int32    | Sum128AdvSimd_Shuffle         |               |           |   864.245 |   828.047 |   824.580 |
| YGroup2ZipBenchmark_Int32    | Sum128AdvSimd_ShuffleX        |               |           |           |           |  1224.295 |
| YGroup2ZipBenchmark_Int32    | Sum128AdvSimd_Widen           |               |           |  1699.860 |  1733.200 |  1562.006 |
| YGroup2ZipBenchmark_Int32    | Sum128AdvSimdB64              |               |           |  3500.172 |  3879.146 |  3816.963 |
| YGroup2ZipBenchmark_Int32    | Sum128PackedSimd_Widen        |               |           |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum128PackedSimd_Shuffle      |               |           |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum128Sse_Permute             |               |           |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum128Sse_Unpack              |               |           |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum128Sse_Widen               |               |           |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum128Traits                  |       109.289 |           |  3486.531 |  3858.478 |  3811.471 |
| YGroup2ZipBenchmark_Int32    | Sum256Base_Basic              |        98.960 |           |   113.512 |   135.104 |   353.632 |
| YGroup2ZipBenchmark_Int32    | Sum256Base                    |        95.633 |           |   112.519 |   135.461 |   351.803 |
| YGroup2ZipBenchmark_Int32    | Sum256Avx2_Permute            |               |           |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum256Avx2_Unpack             |               |           |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum256Avx2_Widen              |               |           |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum256Traits                  |        82.204 |           |   112.489 |   135.368 |   353.730 |
| YGroup2ZipBenchmark_Int32    | Sum512Base_Basic              |               |           |           |           |   316.943 |
| YGroup2ZipBenchmark_Int32    | Sum512Base                    |               |           |           |           |   316.732 |
| YGroup2ZipBenchmark_Int32    | Sum512Avx512_Permute          |               |           |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum512Avx512_Unpack           |               |           |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum512Avx512_Widen            |               |           |           |           |           |
| YGroup2ZipBenchmark_Int32    | Sum512Traits                  |               |           |           |           |   314.792 |
| YGroup2ZipBenchmark_Int64    | SumBase_Basic                 |       225.732 |           |   227.494 |   249.464 |   234.175 |
| YGroup2ZipBenchmark_Int64    | SumBase                       |       225.202 |           |   227.355 |   225.055 |   243.533 |
| YGroup2ZipBenchmark_Int64    | SumTraits                     |       226.062 |           |  1628.810 |  1966.311 |  2034.175 |
| YGroup2ZipBenchmark_Int64    | Sum128Base_Basic              |       124.056 |           |   136.684 |   227.686 |   246.748 |
| YGroup2ZipBenchmark_Int64    | Sum128Base                    |       142.081 |           |   248.722 |  1397.479 |  1303.570 |
| YGroup2ZipBenchmark_Int64    | Sum128AdvSimd_AlignRight      |               |           |  1487.703 |  1639.030 |  1640.959 |
| YGroup2ZipBenchmark_Int64    | Sum128AdvSimd_Shuffle         |               |           |   427.089 |   413.838 |   412.276 |
| YGroup2ZipBenchmark_Int64    | Sum128AdvSimd_ShuffleX        |               |           |           |           |   612.441 |
| YGroup2ZipBenchmark_Int64    | Sum128AdvSimdB64              |               |           |  1742.618 |  1970.512 |  2037.653 |
| YGroup2ZipBenchmark_Int64    | Sum128PackedSimd_Shuffle      |               |           |           |           |           |
| YGroup2ZipBenchmark_Int64    | Sum128Sse_Permute             |               |           |           |           |           |
| YGroup2ZipBenchmark_Int64    | Sum128Sse_Unpack              |               |           |           |           |           |
| YGroup2ZipBenchmark_Int64    | Sum128Traits                  |       143.302 |           |  1755.295 |  1969.621 |  2036.250 |
| YGroup2ZipBenchmark_Int64    | Sum256Base_Basic              |        67.987 |           |    89.272 |   108.628 |   318.733 |
| YGroup2ZipBenchmark_Int64    | Sum256Base                    |        64.224 |           |    90.860 |   108.131 |   318.619 |
| YGroup2ZipBenchmark_Int64    | Sum256Avx2_Permute            |               |           |           |           |           |
| YGroup2ZipBenchmark_Int64    | Sum256Avx2_Unpack             |               |           |           |           |           |
| YGroup2ZipBenchmark_Int64    | Sum256Traits                  |        52.418 |           |    90.799 |   108.434 |   318.711 |
| YGroup2ZipBenchmark_Int64    | Sum512Base_Basic              |               |           |           |           |   234.343 |
| YGroup2ZipBenchmark_Int64    | Sum512Base                    |               |           |           |           |   234.335 |
| YGroup2ZipBenchmark_Int64    | Sum512Avx512_Permute          |               |           |           |           |           |
| YGroup2ZipBenchmark_Int64    | Sum512Avx512_Unpack           |               |           |           |           |           |
| YGroup2ZipBenchmark_Int64    | Sum512Traits                  |               |           |           |           |   234.202 |

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                         | Method                        | .NET 8.0 |
| :--------------------------- | :---------------------------- | -------: |
| YGroup2UnzipBenchmark_Byte   | SumBase_Basic                 |   15.612 |
| YGroup2UnzipBenchmark_Byte   | SumBase_Narrow                |   13.422 |
| YGroup2UnzipBenchmark_Byte   | SumBase_NarrowMul             |    3.224 |
| YGroup2UnzipBenchmark_Byte   | SumBase                       |   15.118 |
| YGroup2UnzipBenchmark_Byte   | SumTraits                     |   98.651 |
| YGroup2UnzipBenchmark_Byte   | Sum128Base_Basic              |   15.682 |
| YGroup2UnzipBenchmark_Byte   | Sum128Base                    |  165.225 |
| YGroup2UnzipBenchmark_Byte   | Sum128AdvSimd_Narrow          |          |
| YGroup2UnzipBenchmark_Byte   | Sum128AdvSimd_Shuffle         |          |
| YGroup2UnzipBenchmark_Byte   | Sum128AdvSimd_ShuffleX        |          |
| YGroup2UnzipBenchmark_Byte   | Sum128AdvSimdB64              |          |
| YGroup2UnzipBenchmark_Byte   | Sum128PackedSimd_Narrow       |  158.487 |
| YGroup2UnzipBenchmark_Byte   | Sum128PackedSimd_Shuffle      |  126.446 |
| YGroup2UnzipBenchmark_Byte   | Sum128PackedSimd_TupleNarrow  |   78.570 |
| YGroup2UnzipBenchmark_Byte   | Sum128PackedSimd_TupleShuffle |   72.839 |
| YGroup2UnzipBenchmark_Byte   | Sum128Sse_Narrow              |          |
| YGroup2UnzipBenchmark_Byte   | Sum128Sse_Permute             |          |
| YGroup2UnzipBenchmark_Byte   | Sum128Sse_Unpack              |          |
| YGroup2UnzipBenchmark_Byte   | Sum128Traits                  |  120.080 |
| YGroup2UnzipBenchmark_Byte   | Sum256Base_Basic              |   15.228 |
| YGroup2UnzipBenchmark_Byte   | Sum256Base                    |   13.898 |
| YGroup2UnzipBenchmark_Byte   | Sum256Avx2_Narrow             |          |
| YGroup2UnzipBenchmark_Byte   | Sum256Avx2_Permute            |          |
| YGroup2UnzipBenchmark_Byte   | Sum256Avx2_Unpack             |          |
| YGroup2UnzipBenchmark_Byte   | Sum256Traits                  |   14.371 |
| YGroup2UnzipBenchmark_Byte   | Sum512Base_Basic              |   14.413 |
| YGroup2UnzipBenchmark_Byte   | Sum512Base                    |   15.353 |
| YGroup2UnzipBenchmark_Byte   | Sum512Avx512_Narrow           |          |
| YGroup2UnzipBenchmark_Byte   | Sum512Avx512_Permute          |          |
| YGroup2UnzipBenchmark_Byte   | Sum512Avx512_Unpack           |          |
| YGroup2UnzipBenchmark_Byte   | Sum512Traits                  |   14.376 |
| YGroup2UnzipBenchmark_Int128 | SumBase_Basic                 |    2.878 |
| YGroup2UnzipBenchmark_Int128 | SumBase                       |    2.750 |
| YGroup2UnzipBenchmark_Int128 | SumTraits                     |    3.943 |
| YGroup2UnzipBenchmark_Int128 | SumTraits_Int128              |    5.457 |
| YGroup2UnzipBenchmark_Int128 | Sum128Base_Basic              |    2.473 |
| YGroup2UnzipBenchmark_Int128 | Sum128Base                    |    2.461 |
| YGroup2UnzipBenchmark_Int128 | Sum128Traits                  |   40.963 |
| YGroup2UnzipBenchmark_Int128 | Sum128Traits_Int128           |   41.228 |
| YGroup2UnzipBenchmark_Int128 | Sum256Base_Basic              |    1.655 |
| YGroup2UnzipBenchmark_Int128 | Sum256Base_Move2              |    1.828 |
| YGroup2UnzipBenchmark_Int128 | Sum256Base                    |    1.960 |
| YGroup2UnzipBenchmark_Int128 | Sum256Avx2                    |          |
| YGroup2UnzipBenchmark_Int128 | Sum256Traits                  |    4.506 |
| YGroup2UnzipBenchmark_Int128 | Sum256Traits_Int128           |    5.315 |
| YGroup2UnzipBenchmark_Int128 | Sum512Base_Basic              |    1.696 |
| YGroup2UnzipBenchmark_Int128 | Sum512Base                    |    1.569 |
| YGroup2UnzipBenchmark_Int128 | Sum512Avx512                  |          |
| YGroup2UnzipBenchmark_Int128 | Sum512Traits                  |    3.445 |
| YGroup2UnzipBenchmark_Int128 | Sum512Traits_Int128           |    3.666 |
| YGroup2UnzipBenchmark_Int16  | SumBase_Basic                 |   10.281 |
| YGroup2UnzipBenchmark_Int16  | SumBase_Narrow                |    9.369 |
| YGroup2UnzipBenchmark_Int16  | SumBase_NarrowMul             |    4.152 |
| YGroup2UnzipBenchmark_Int16  | SumBase_NarrowMulOld          |    1.400 |
| YGroup2UnzipBenchmark_Int16  | SumBase                       |    9.898 |
| YGroup2UnzipBenchmark_Int16  | SumTraits                     |   51.119 |
| YGroup2UnzipBenchmark_Int16  | Sum128Base_Basic              |   10.073 |
| YGroup2UnzipBenchmark_Int16  | Sum128Base                    |    6.174 |
| YGroup2UnzipBenchmark_Int16  | Sum128AdvSimd_Narrow          |          |
| YGroup2UnzipBenchmark_Int16  | Sum128AdvSimd_Shuffle         |          |
| YGroup2UnzipBenchmark_Int16  | Sum128AdvSimd_ShuffleX        |          |
| YGroup2UnzipBenchmark_Int16  | Sum128AdvSimdB64              |          |
| YGroup2UnzipBenchmark_Int16  | Sum128PackedSimd_Narrow       |    6.327 |
| YGroup2UnzipBenchmark_Int16  | Sum128PackedSimd_Shuffle      |   61.067 |
| YGroup2UnzipBenchmark_Int16  | Sum128PackedSimd_TupleNarrow  |    5.535 |
| YGroup2UnzipBenchmark_Int16  | Sum128PackedSimd_TupleShuffle |   24.598 |
| YGroup2UnzipBenchmark_Int16  | Sum128Sse_Narrow              |          |
| YGroup2UnzipBenchmark_Int16  | Sum128Sse_Permute             |          |
| YGroup2UnzipBenchmark_Int16  | Sum128Sse_ShuffleXImm         |          |
| YGroup2UnzipBenchmark_Int16  | Sum128Sse_Unpack              |          |
| YGroup2UnzipBenchmark_Int16  | Sum128Traits                  |   59.578 |
| YGroup2UnzipBenchmark_Int16  | Sum256Base_Basic              |    9.867 |
| YGroup2UnzipBenchmark_Int16  | Sum256Base                    |    9.623 |
| YGroup2UnzipBenchmark_Int16  | Sum256Avx2_Narrow             |          |
| YGroup2UnzipBenchmark_Int16  | Sum256Avx2_Permute            |          |
| YGroup2UnzipBenchmark_Int16  | Sum256Avx2_ShuffleXImm        |          |
| YGroup2UnzipBenchmark_Int16  | Sum256Avx2_Unpack             |          |
| YGroup2UnzipBenchmark_Int16  | Sum256Traits                  |    8.703 |
| YGroup2UnzipBenchmark_Int16  | Sum512Base_Basic              |    9.737 |
| YGroup2UnzipBenchmark_Int16  | Sum512Base                    |   10.055 |
| YGroup2UnzipBenchmark_Int16  | Sum512Avx512_Narrow           |          |
| YGroup2UnzipBenchmark_Int16  | Sum512Avx512_Permute          |          |
| YGroup2UnzipBenchmark_Int16  | Sum512Avx512_ShuffleXImm      |          |
| YGroup2UnzipBenchmark_Int16  | Sum512Avx512_Unpack           |          |
| YGroup2UnzipBenchmark_Int16  | Sum512Traits                  |    9.175 |
| YGroup2UnzipBenchmark_Int32  | SumBase_Basic                 |    7.284 |
| YGroup2UnzipBenchmark_Int32  | SumBase_Narrow                |    7.249 |
| YGroup2UnzipBenchmark_Int32  | SumBase_NarrowMul             |    1.655 |
| YGroup2UnzipBenchmark_Int32  | SumBase                       |    7.141 |
| YGroup2UnzipBenchmark_Int32  | SumTraits                     |   24.823 |
| YGroup2UnzipBenchmark_Int32  | Sum128Base_Basic              |    6.960 |
| YGroup2UnzipBenchmark_Int32  | Sum128Base                    |    3.928 |
| YGroup2UnzipBenchmark_Int32  | Sum128AdvSimd_Narrow          |          |
| YGroup2UnzipBenchmark_Int32  | Sum128AdvSimd_Shuffle         |          |
| YGroup2UnzipBenchmark_Int32  | Sum128AdvSimd_ShuffleX        |          |
| YGroup2UnzipBenchmark_Int32  | Sum128AdvSimdB64              |          |
| YGroup2UnzipBenchmark_Int32  | Sum128PackedSimd_Narrow       |    3.912 |
| YGroup2UnzipBenchmark_Int32  | Sum128PackedSimd_Shuffle      |   31.667 |
| YGroup2UnzipBenchmark_Int32  | Sum128PackedSimd_TupleNarrow  |    3.584 |
| YGroup2UnzipBenchmark_Int32  | Sum128PackedSimd_TupleShuffle |   12.490 |
| YGroup2UnzipBenchmark_Int32  | Sum128Sse_Narrow              |          |
| YGroup2UnzipBenchmark_Int32  | Sum128Sse_Permute             |          |
| YGroup2UnzipBenchmark_Int32  | Sum128Sse_ShuffleXImm         |          |
| YGroup2UnzipBenchmark_Int32  | Sum128Sse_Unpack              |          |
| YGroup2UnzipBenchmark_Int32  | Sum128Traits                  |   30.822 |
| YGroup2UnzipBenchmark_Int32  | Sum256Base_Basic              |    6.805 |
| YGroup2UnzipBenchmark_Int32  | Sum256Base                    |    6.602 |
| YGroup2UnzipBenchmark_Int32  | Sum256Avx2_Narrow             |          |
| YGroup2UnzipBenchmark_Int32  | Sum256Avx2_Permute            |          |
| YGroup2UnzipBenchmark_Int32  | Sum256Avx2_ShuffleXImm        |          |
| YGroup2UnzipBenchmark_Int32  | Sum256Avx2_Unpack             |          |
| YGroup2UnzipBenchmark_Int32  | Sum256Traits                  |    5.837 |
| YGroup2UnzipBenchmark_Int32  | Sum512Base_Basic              |    6.474 |
| YGroup2UnzipBenchmark_Int32  | Sum512Base                    |    6.930 |
| YGroup2UnzipBenchmark_Int32  | Sum512Avx512_Narrow           |          |
| YGroup2UnzipBenchmark_Int32  | Sum512Avx512_Permute          |          |
| YGroup2UnzipBenchmark_Int32  | Sum512Avx512_ShuffleXImm      |          |
| YGroup2UnzipBenchmark_Int32  | Sum512Avx512_Unpack           |          |
| YGroup2UnzipBenchmark_Int32  | Sum512Traits                  |    6.523 |
| YGroup2UnzipBenchmark_Int64  | SumBase_Basic                 |    2.750 |
| YGroup2UnzipBenchmark_Int64  | SumBase                       |    2.768 |
| YGroup2UnzipBenchmark_Int64  | SumTraits                     |    4.316 |
| YGroup2UnzipBenchmark_Int64  | Sum128Base_Basic              |    1.667 |
| YGroup2UnzipBenchmark_Int64  | Sum128Base                    |    2.046 |
| YGroup2UnzipBenchmark_Int64  | Sum128AdvSimd_AlignRight      |          |
| YGroup2UnzipBenchmark_Int64  | Sum128AdvSimd_Shuffle         |          |
| YGroup2UnzipBenchmark_Int64  | Sum128AdvSimd_ShuffleX        |          |
| YGroup2UnzipBenchmark_Int64  | Sum128AdvSimdB64              |          |
| YGroup2UnzipBenchmark_Int64  | Sum128PackedSimd_Shuffle      |   15.137 |
| YGroup2UnzipBenchmark_Int64  | Sum128PackedSimd_TupleShuffle |    6.295 |
| YGroup2UnzipBenchmark_Int64  | Sum128Sse_Permute             |          |
| YGroup2UnzipBenchmark_Int64  | Sum128Sse_Unpack              |          |
| YGroup2UnzipBenchmark_Int64  | Sum128Traits                  |   15.768 |
| YGroup2UnzipBenchmark_Int64  | Sum256Base_Basic              |    1.636 |
| YGroup2UnzipBenchmark_Int64  | Sum256Base                    |    1.612 |
| YGroup2UnzipBenchmark_Int64  | Sum256Avx2_Permute            |          |
| YGroup2UnzipBenchmark_Int64  | Sum256Avx2_Unpack             |          |
| YGroup2UnzipBenchmark_Int64  | Sum256Traits                  |    3.177 |
| YGroup2UnzipBenchmark_Int64  | Sum512Base_Basic              |    1.618 |
| YGroup2UnzipBenchmark_Int64  | Sum512Base                    |    1.666 |
| YGroup2UnzipBenchmark_Int64  | Sum512Avx512_Permute          |          |
| YGroup2UnzipBenchmark_Int64  | Sum512Avx512_Unpack           |          |
| YGroup2UnzipBenchmark_Int64  | Sum512Traits                  |    3.715 |
| YGroup2ZipBenchmark_Byte     | SumBase_Basic                 |   14.845 |
| YGroup2ZipBenchmark_Byte     | SumBase_Widen                 |    9.924 |
| YGroup2ZipBenchmark_Byte     | SumBase_WidenMul              |    8.389 |
| YGroup2ZipBenchmark_Byte     | SumBase                       |   15.118 |
| YGroup2ZipBenchmark_Byte     | SumTraits                     |   99.548 |
| YGroup2ZipBenchmark_Byte     | Sum128Base_Basic              |   14.004 |
| YGroup2ZipBenchmark_Byte     | Sum128Base                    |   48.809 |
| YGroup2ZipBenchmark_Byte     | Sum128AdvSimd_Shuffle         |          |
| YGroup2ZipBenchmark_Byte     | Sum128AdvSimd_ShuffleX        |          |
| YGroup2ZipBenchmark_Byte     | Sum128AdvSimd_Widen           |          |
| YGroup2ZipBenchmark_Byte     | Sum128AdvSimdB64              |          |
| YGroup2ZipBenchmark_Byte     | Sum128PackedSimd_Widen        |  122.253 |
| YGroup2ZipBenchmark_Byte     | Sum128PackedSimd_Shuffle      |  119.170 |
| YGroup2ZipBenchmark_Byte     | Sum128Sse_Permute             |          |
| YGroup2ZipBenchmark_Byte     | Sum128Sse_Unpack              |          |
| YGroup2ZipBenchmark_Byte     | Sum128Sse_Widen               |          |
| YGroup2ZipBenchmark_Byte     | Sum128Traits                  |  118.833 |
| YGroup2ZipBenchmark_Byte     | Sum256Base_Basic              |   14.356 |
| YGroup2ZipBenchmark_Byte     | Sum256Base                    |   14.029 |
| YGroup2ZipBenchmark_Byte     | Sum256Avx2_Permute            |          |
| YGroup2ZipBenchmark_Byte     | Sum256Avx2_Unpack             |          |
| YGroup2ZipBenchmark_Byte     | Sum256Avx2_Widen              |          |
| YGroup2ZipBenchmark_Byte     | Sum256Traits                  |   13.547 |
| YGroup2ZipBenchmark_Byte     | Sum512Base_Basic              |   14.738 |
| YGroup2ZipBenchmark_Byte     | Sum512Base                    |   13.887 |
| YGroup2ZipBenchmark_Byte     | Sum512Avx512_Permute          |          |
| YGroup2ZipBenchmark_Byte     | Sum512Avx512_Unpack           |          |
| YGroup2ZipBenchmark_Byte     | Sum512Avx512_Widen            |          |
| YGroup2ZipBenchmark_Byte     | Sum512Traits                  |   14.204 |
| YGroup2ZipBenchmark_Int128   | SumBase_Basic                 |    2.672 |
| YGroup2ZipBenchmark_Int128   | SumBase                       |    2.724 |
| YGroup2ZipBenchmark_Int128   | SumTraits                     |    3.848 |
| YGroup2ZipBenchmark_Int128   | SumTraits_Int128              |    5.168 |
| YGroup2ZipBenchmark_Int128   | Sum128Base_Basic              |    2.583 |
| YGroup2ZipBenchmark_Int128   | Sum128Base                    |    2.442 |
| YGroup2ZipBenchmark_Int128   | Sum128Traits                  |   42.578 |
| YGroup2ZipBenchmark_Int128   | Sum128Traits_Int128           |   39.977 |
| YGroup2ZipBenchmark_Int128   | Sum256Base_Basic              |    1.671 |
| YGroup2ZipBenchmark_Int128   | Sum256Base_Move2              |    1.853 |
| YGroup2ZipBenchmark_Int128   | Sum256Base                    |    1.838 |
| YGroup2ZipBenchmark_Int128   | Sum256Avx2                    |          |
| YGroup2ZipBenchmark_Int128   | Sum256Traits                  |    4.378 |
| YGroup2ZipBenchmark_Int128   | Sum256Traits_Int128           |    5.299 |
| YGroup2ZipBenchmark_Int128   | Sum512Base_Basic              |    1.628 |
| YGroup2ZipBenchmark_Int128   | Sum512Base                    |    1.672 |
| YGroup2ZipBenchmark_Int128   | Sum512Avx512                  |          |
| YGroup2ZipBenchmark_Int128   | Sum512Avx512_Imm              |          |
| YGroup2ZipBenchmark_Int128   | Sum512Traits                  |    3.466 |
| YGroup2ZipBenchmark_Int128   | Sum512Traits_Int128           |    3.580 |
| YGroup2ZipBenchmark_Int16    | SumBase_Basic                 |   10.520 |
| YGroup2ZipBenchmark_Int16    | SumBase_Widen                 |    6.280 |
| YGroup2ZipBenchmark_Int16    | SumBase_WidenMul              |    5.769 |
| YGroup2ZipBenchmark_Int16    | SumBase                       |   10.416 |
| YGroup2ZipBenchmark_Int16    | SumTraits                     |   49.972 |
| YGroup2ZipBenchmark_Int16    | Sum128Base_Basic              |   10.419 |
| YGroup2ZipBenchmark_Int16    | Sum128Base                    |    5.282 |
| YGroup2ZipBenchmark_Int16    | Sum128AdvSimd_Shuffle         |          |
| YGroup2ZipBenchmark_Int16    | Sum128AdvSimd_ShuffleX        |          |
| YGroup2ZipBenchmark_Int16    | Sum128AdvSimd_Widen           |          |
| YGroup2ZipBenchmark_Int16    | Sum128AdvSimdB64              |          |
| YGroup2ZipBenchmark_Int16    | Sum128PackedSimd_Widen        |   59.019 |
| YGroup2ZipBenchmark_Int16    | Sum128PackedSimd_Shuffle      |   60.809 |
| YGroup2ZipBenchmark_Int16    | Sum128Sse_Permute             |          |
| YGroup2ZipBenchmark_Int16    | Sum128Sse_Unpack              |          |
| YGroup2ZipBenchmark_Int16    | Sum128Sse_Widen               |          |
| YGroup2ZipBenchmark_Int16    | Sum128Traits                  |   57.986 |
| YGroup2ZipBenchmark_Int16    | Sum256Base_Basic              |   10.736 |
| YGroup2ZipBenchmark_Int16    | Sum256Base                    |   10.293 |
| YGroup2ZipBenchmark_Int16    | Sum256Avx2_Permute            |          |
| YGroup2ZipBenchmark_Int16    | Sum256Avx2_Unpack             |          |
| YGroup2ZipBenchmark_Int16    | Sum256Avx2_Widen              |          |
| YGroup2ZipBenchmark_Int16    | Sum256Traits                  |    9.424 |
| YGroup2ZipBenchmark_Int16    | Sum512Base_Basic              |   10.471 |
| YGroup2ZipBenchmark_Int16    | Sum512Base                    |   10.450 |
| YGroup2ZipBenchmark_Int16    | Sum512Avx512_Permute          |          |
| YGroup2ZipBenchmark_Int16    | Sum512Avx512_Unpack           |          |
| YGroup2ZipBenchmark_Int16    | Sum512Avx512_Widen            |          |
| YGroup2ZipBenchmark_Int16    | Sum512Traits                  |    9.738 |
| YGroup2ZipBenchmark_Int32    | SumBase_Basic                 |    7.298 |
| YGroup2ZipBenchmark_Int32    | SumBase_Widen                 |    7.048 |
| YGroup2ZipBenchmark_Int32    | SumBase                       |    7.183 |
| YGroup2ZipBenchmark_Int32    | SumTraits                     |   24.511 |
| YGroup2ZipBenchmark_Int32    | Sum128Base_Basic              |    7.166 |
| YGroup2ZipBenchmark_Int32    | Sum128Base                    |    2.909 |
| YGroup2ZipBenchmark_Int32    | Sum128AdvSimd_Shuffle         |          |
| YGroup2ZipBenchmark_Int32    | Sum128AdvSimd_ShuffleX        |          |
| YGroup2ZipBenchmark_Int32    | Sum128AdvSimd_Widen           |          |
| YGroup2ZipBenchmark_Int32    | Sum128AdvSimdB64              |          |
| YGroup2ZipBenchmark_Int32    | Sum128PackedSimd_Widen        |   30.215 |
| YGroup2ZipBenchmark_Int32    | Sum128PackedSimd_Shuffle      |   30.200 |
| YGroup2ZipBenchmark_Int32    | Sum128Sse_Permute             |          |
| YGroup2ZipBenchmark_Int32    | Sum128Sse_Unpack              |          |
| YGroup2ZipBenchmark_Int32    | Sum128Sse_Widen               |          |
| YGroup2ZipBenchmark_Int32    | Sum128Traits                  |   31.532 |
| YGroup2ZipBenchmark_Int32    | Sum256Base_Basic              |    6.986 |
| YGroup2ZipBenchmark_Int32    | Sum256Base                    |    7.089 |
| YGroup2ZipBenchmark_Int32    | Sum256Avx2_Permute            |          |
| YGroup2ZipBenchmark_Int32    | Sum256Avx2_Unpack             |          |
| YGroup2ZipBenchmark_Int32    | Sum256Avx2_Widen              |          |
| YGroup2ZipBenchmark_Int32    | Sum256Traits                  |    5.856 |
| YGroup2ZipBenchmark_Int32    | Sum512Base_Basic              |    6.750 |
| YGroup2ZipBenchmark_Int32    | Sum512Base                    |    6.841 |
| YGroup2ZipBenchmark_Int32    | Sum512Avx512_Permute          |          |
| YGroup2ZipBenchmark_Int32    | Sum512Avx512_Unpack           |          |
| YGroup2ZipBenchmark_Int32    | Sum512Avx512_Widen            |          |
| YGroup2ZipBenchmark_Int32    | Sum512Traits                  |    6.553 |
| YGroup2ZipBenchmark_Int64    | SumBase_Basic                 |    2.536 |
| YGroup2ZipBenchmark_Int64    | SumBase                       |    2.550 |
| YGroup2ZipBenchmark_Int64    | SumTraits                     |    4.276 |
| YGroup2ZipBenchmark_Int64    | Sum128Base_Basic              |    1.602 |
| YGroup2ZipBenchmark_Int64    | Sum128Base                    |    2.133 |
| YGroup2ZipBenchmark_Int64    | Sum128AdvSimd_AlignRight      |          |
| YGroup2ZipBenchmark_Int64    | Sum128AdvSimd_Shuffle         |          |
| YGroup2ZipBenchmark_Int64    | Sum128AdvSimd_ShuffleX        |          |
| YGroup2ZipBenchmark_Int64    | Sum128AdvSimdB64              |          |
| YGroup2ZipBenchmark_Int64    | Sum128PackedSimd_Shuffle      |   15.167 |
| YGroup2ZipBenchmark_Int64    | Sum128Sse_Permute             |          |
| YGroup2ZipBenchmark_Int64    | Sum128Sse_Unpack              |          |
| YGroup2ZipBenchmark_Int64    | Sum128Traits                  |   14.849 |
| YGroup2ZipBenchmark_Int64    | Sum256Base_Basic              |    1.662 |
| YGroup2ZipBenchmark_Int64    | Sum256Base                    |    1.649 |
| YGroup2ZipBenchmark_Int64    | Sum256Avx2_Permute            |          |
| YGroup2ZipBenchmark_Int64    | Sum256Avx2_Unpack             |          |
| YGroup2ZipBenchmark_Int64    | Sum256Traits                  |    2.931 |
| YGroup2ZipBenchmark_Int64    | Sum512Base_Basic              |    1.633 |
| YGroup2ZipBenchmark_Int64    | Sum512Base                    |    1.577 |
| YGroup2ZipBenchmark_Int64    | Sum512Avx512_Permute          |          |
| YGroup2ZipBenchmark_Int64    | Sum512Avx512_Unpack           |          |
| YGroup2ZipBenchmark_Int64    | Sum512Traits                  |    3.630 |

