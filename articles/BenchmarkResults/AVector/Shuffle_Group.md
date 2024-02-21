# Benchmark group - Shuffle
([← Back](Shuffle.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### X86 - Intel Core i5-8250U
| Type                   | Method                          | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :--------------------- | :------------------------------ | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| ShuffleBenchmark_Int16 | SumScalar                       |       1016.659 |      1018.646 |       998.544 |  1041.646 |  1042.608 |  1024.998 |
| ShuffleBenchmark_Int16 | SumBase                         |        995.932 |      1017.320 |      1015.827 |  1041.072 |  1041.631 |  1012.302 |
| ShuffleBenchmark_Int16 | SumTraits                       |       1000.426 |      1016.556 |      5386.285 |  8765.158 |  8961.145 | 10128.301 |
| ShuffleBenchmark_Int16 | SumTraits_Args0                 |       1015.537 |      1014.005 |     15024.499 | 14910.111 | 14773.976 | 15053.609 |
| ShuffleBenchmark_Int16 | SumTraits_Args                  |       1017.006 |      1026.157 |     15074.692 | 14553.903 | 15058.475 | 14754.580 |
| ShuffleBenchmark_Int16 | Sum128_Bcl                      |                |               |               |           |           |           |
| ShuffleBenchmark_Int16 | Sum128_AdvSimd                  |                |               |               |           |           |           |
| ShuffleBenchmark_Int16 | Sum128Traits                    |                |               |               |           |           |           |
| ShuffleBenchmark_Int16 | Sum256_Bcl                      |                |               |               |           |           |   750.342 |
| ShuffleBenchmark_Int16 | Sum256Traits                    |                |               |      5981.363 |  8772.257 |  9213.382 | 12697.956 |
| ShuffleBenchmark_Int16 | SumKernelTraits                 |        993.796 |      1014.420 |      7343.188 |  9744.617 | 10582.688 | 12204.288 |
| ShuffleBenchmark_Int16 | SumKernelTraits_Args0           |       1011.454 |      1015.994 |     15180.615 | 14707.338 | 14144.931 | 14516.094 |
| ShuffleBenchmark_Int16 | SumKernelTraits_Args            |       1017.448 |      1026.997 |     15146.407 |  8999.999 | 14525.871 | 14587.111 |
| ShuffleBenchmark_Int16 | SumKernel128_AdvSimd            |                |               |               |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel128Traits              |                |               |               |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel256_Avx2_Multiply      |                |               |      7257.929 |  7347.263 | 10708.385 | 13965.905 |
| ShuffleBenchmark_Int16 | SumKernel256_Avx2_ShiftLane     |                |               |      7685.436 |  8927.062 | 10401.670 | 10979.798 |
| ShuffleBenchmark_Int16 | SumKernel256Traits              |                |               |      7360.572 | 10217.643 | 10707.976 | 14005.395 |
| ShuffleBenchmark_Int16 | SumKernel256Traits_Args0        |                |               |     15144.047 | 14676.348 | 14103.424 | 14455.921 |
| ShuffleBenchmark_Int16 | SumKernel256Traits_Args         |                |               |     15178.488 | 14756.944 | 14535.652 | 14749.937 |
| ShuffleBenchmark_Int32 | SumScalar                       |        727.100 |       728.785 |       708.810 |   753.148 |   739.401 |   734.168 |
| ShuffleBenchmark_Int32 | SumBase                         |        708.582 |       727.808 |       727.359 |   753.841 |   739.840 |   731.849 |
| ShuffleBenchmark_Int32 | SumTraits                       |        707.791 |       727.651 |      5277.491 |  6176.523 |  7397.582 | 10204.153 |
| ShuffleBenchmark_Int32 | SumTraits_Args0                 |        728.000 |       727.785 |      9823.001 |  9921.083 |  9751.553 | 10199.869 |
| ShuffleBenchmark_Int32 | SumTraits_Args                  |        685.328 |       734.136 |      9637.014 |  9497.253 |  9487.379 |  9547.718 |
| ShuffleBenchmark_Int32 | Sum128_Bcl                      |                |               |               |           |           |           |
| ShuffleBenchmark_Int32 | Sum128_AdvSimd                  |                |               |               |           |           |           |
| ShuffleBenchmark_Int32 | Sum128Traits                    |                |               |               |           |           |           |
| ShuffleBenchmark_Int32 | Sum256_Bcl                      |                |               |               |           |           |   603.691 |
| ShuffleBenchmark_Int32 | Sum256Traits                    |                |               |      5285.603 |  7878.696 |  9079.384 | 10125.224 |
| ShuffleBenchmark_Int32 | SumKernelTraits                 |        708.275 |       729.196 |     10843.004 |  7267.239 |  7302.000 | 12034.804 |
| ShuffleBenchmark_Int32 | SumKernelTraits_Args0           |        726.587 |       727.401 |     10639.798 | 11525.694 | 11492.221 | 11702.120 |
| ShuffleBenchmark_Int32 | SumKernelTraits_Args            |        686.010 |       732.514 |     10662.053 | 10264.114 | 11456.597 | 11820.508 |
| ShuffleBenchmark_Int32 | SumKernel128_AdvSimd            |                |               |               |           |           |           |
| ShuffleBenchmark_Int32 | SumKernel128Traits              |                |               |               |           |           |           |
| ShuffleBenchmark_Int32 | SumKernel256Traits              |                |               |     11726.100 | 10284.773 | 10150.383 | 11903.163 |
| ShuffleBenchmark_Int32 | SumKernel256Traits_Args0        |                |               |     11858.779 | 11388.775 | 11372.807 | 11851.050 |
| ShuffleBenchmark_Int32 | SumKernel256Traits_Args         |                |               |     11809.072 | 11416.831 | 11526.468 | 11190.310 |
| ShuffleBenchmark_Int64 | SumScalar                       |        462.272 |       462.677 |       443.289 |   482.761 |   462.278 |   463.280 |
| ShuffleBenchmark_Int64 | SumBase                         |        442.821 |       462.127 |       463.042 |   482.055 |   464.097 |   464.975 |
| ShuffleBenchmark_Int64 | SumTraits                       |        442.724 |       461.966 |      1852.505 |  2824.585 |  2528.873 |  3684.254 |
| ShuffleBenchmark_Int64 | SumTraits_Args0                 |        468.147 |       467.308 |      4814.927 |  4926.681 |  4965.695 |  4943.292 |
| ShuffleBenchmark_Int64 | SumTraits_Args                  |        467.003 |       466.767 |      4819.158 |  4830.929 |  4664.443 |  4758.252 |
| ShuffleBenchmark_Int64 | Sum128_Bcl                      |                |               |               |           |           |           |
| ShuffleBenchmark_Int64 | Sum128_AdvSimd                  |                |               |               |           |           |           |
| ShuffleBenchmark_Int64 | Sum128Traits                    |                |               |               |           |           |           |
| ShuffleBenchmark_Int64 | Sum256_Bcl                      |                |               |               |           |           |   489.653 |
| ShuffleBenchmark_Int64 | Sum256Traits                    |                |               |      2127.309 |  2829.362 |  2457.798 |  4204.358 |
| ShuffleBenchmark_Int64 | SumKernelTraits                 |        443.839 |       463.136 |      2964.199 |  3498.257 |  3598.090 |  4563.892 |
| ShuffleBenchmark_Int64 | SumKernelTraits_Args0           |        468.341 |       468.237 |      6070.414 |  5693.042 |  5760.762 |  5809.334 |
| ShuffleBenchmark_Int64 | SumKernelTraits_Args            |        457.650 |       465.868 |      6010.227 |  5769.979 |  5779.311 |  5600.277 |
| ShuffleBenchmark_Int64 | SumKernel128_Sse_DuplicateEven  |                |               |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel128_AdvSimd            |                |               |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel128_Arm_Multiply       |                |               |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel128Traits              |                |               |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_AlignRight    |                |               |      3486.686 |  3623.613 |  3482.150 |  4073.063 |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_DuplicateEven |                |               |      3703.945 |  3590.006 |  3582.747 |  4946.453 |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_Multiply      |                |               |      1868.790 |  2377.478 |  2439.617 |  2389.271 |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_ShiftLane     |                |               |      3633.297 |  3575.942 |  3640.024 |  4708.888 |
| ShuffleBenchmark_Int64 | SumKernel256Traits              |                |               |      3749.462 |  3602.147 |  3685.930 |  4555.621 |
| ShuffleBenchmark_Int64 | SumKernel256Traits_Args0        |                |               |      5701.767 |  5143.018 |  5656.013 |  5553.266 |
| ShuffleBenchmark_Int64 | SumKernel256Traits_Args         |                |               |      5637.204 |  5746.183 |  5709.806 |  5789.265 |
| ShuffleBenchmark_SByte | SumScalar                       |       1272.437 |      1269.882 |      1252.439 |  1285.935 |  1276.537 |  1277.403 |
| ShuffleBenchmark_SByte | SumBase                         |       1256.592 |      1170.061 |      1273.530 |  1286.850 |  1276.112 |  1248.495 |
| ShuffleBenchmark_SByte | SumTraits                       |       1256.174 |      1230.816 |     13436.835 | 21046.672 | 22516.121 | 25740.061 |
| ShuffleBenchmark_SByte | SumTraits_Args0                 |       1275.660 |       931.862 |     32977.350 | 33030.816 | 33064.959 | 34611.644 |
| ShuffleBenchmark_SByte | SumTraits_Args                  |       1273.766 |       929.256 |     33073.034 | 33132.757 | 32970.692 | 34544.193 |
| ShuffleBenchmark_SByte | Sum128_Bcl                      |                |               |               |           |           |           |
| ShuffleBenchmark_SByte | Sum128_AdvSimd                  |                |               |               |           |           |           |
| ShuffleBenchmark_SByte | Sum128Traits                    |                |               |               |           |           |           |
| ShuffleBenchmark_SByte | Sum256_Bcl                      |                |               |               |           |           |   932.852 |
| ShuffleBenchmark_SByte | Sum256_Avx2_Add1                |                |               |     13424.472 | 19751.865 | 21056.531 | 26452.281 |
| ShuffleBenchmark_SByte | Sum256_Avx2_Add2                |                |               |     13371.121 | 18325.710 | 20415.691 | 26104.468 |
| ShuffleBenchmark_SByte | Sum256_Avx2_Cmp2                |                |               |     15202.412 | 19676.439 | 24199.780 | 26482.193 |
| ShuffleBenchmark_SByte | Sum256_Avx2_EqualAnd            |                |               |     14968.139 | 20359.118 | 20216.444 | 26081.512 |
| ShuffleBenchmark_SByte | Sum256Traits                    |                |               |     15222.366 | 21747.951 | 22919.506 | 31924.788 |
| ShuffleBenchmark_SByte | SumKernelTraits                 |       1238.263 |       991.523 |     21358.336 | 24694.833 | 24980.435 | 30476.824 |
| ShuffleBenchmark_SByte | SumKernelTraits_Args0           |       1272.109 |      1160.091 |     33299.207 | 32640.109 | 32834.769 | 33124.708 |
| ShuffleBenchmark_SByte | SumKernelTraits_Args            |       1270.804 |      1274.366 |     33352.484 | 32291.049 | 32749.519 | 34311.869 |
| ShuffleBenchmark_SByte | SumKernel128_AdvSimd            |                |               |               |           |           |           |
| ShuffleBenchmark_SByte | SumKernel128Traits              |                |               |               |           |           |           |
| ShuffleBenchmark_SByte | SumKernel256Traits              |                |               |     22838.503 | 28432.728 | 28457.570 | 33797.896 |
| ShuffleBenchmark_SByte | SumKernel256Traits_Args0        |                |               |     33167.363 | 33087.204 | 32498.764 | 34571.312 |
| ShuffleBenchmark_SByte | SumKernel256Traits_Args         |                |               |     33202.948 | 31697.628 | 33129.448 | 34014.673 |

### X86 - Intel Core i5-8250U - 128 bit
| Type                   | Method                          | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :--------------------- | :------------------------------ | ------------: | --------: | --------: | --------: |
| ShuffleBenchmark_Int16 | SumScalar                       |       740.249 |   768.515 |   772.758 |   759.095 |
| ShuffleBenchmark_Int16 | SumBase                         |       727.083 |   764.736 |   772.833 |   753.356 |
| ShuffleBenchmark_Int16 | SumTraits                       |      3462.537 |  6255.944 |  7073.393 |  8100.287 |
| ShuffleBenchmark_Int16 | SumTraits_Args0                 |     12306.584 | 13347.670 | 13564.558 | 14556.397 |
| ShuffleBenchmark_Int16 | SumTraits_Args                  |     12281.000 | 13074.901 | 12852.249 | 13919.373 |
| ShuffleBenchmark_Int16 | Sum128_Bcl                      |               |           |           |   622.361 |
| ShuffleBenchmark_Int16 | Sum128_AdvSimd                  |               |           |           |           |
| ShuffleBenchmark_Int16 | Sum128Traits                    |      3786.654 |  7409.713 |  7111.410 |  9835.238 |
| ShuffleBenchmark_Int16 | Sum256_Bcl                      |               |           |           |           |
| ShuffleBenchmark_Int16 | Sum256Traits                    |               |           |           |           |
| ShuffleBenchmark_Int16 | SumKernelTraits                 |      4946.668 |  8078.267 |  8875.736 | 10315.084 |
| ShuffleBenchmark_Int16 | SumKernelTraits_Args0           |     12353.493 | 12492.054 | 13971.670 | 13982.928 |
| ShuffleBenchmark_Int16 | SumKernelTraits_Args            |     12272.866 | 13076.678 | 14035.159 | 13824.059 |
| ShuffleBenchmark_Int16 | SumKernel128_AdvSimd            |               |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel128Traits              |      6355.005 | 10279.712 |  9502.717 | 13077.237 |
| ShuffleBenchmark_Int16 | SumKernel256_Avx2_Multiply      |               |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel256_Avx2_ShiftLane     |               |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel256Traits              |               |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel256Traits_Args0        |               |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel256Traits_Args         |               |           |           |           |
| ShuffleBenchmark_Int32 | SumScalar                       |       439.719 |   498.308 |   480.289 |   475.379 |
| ShuffleBenchmark_Int32 | SumBase                         |       477.662 |   498.258 |   475.826 |   472.526 |
| ShuffleBenchmark_Int32 | SumTraits                       |      1950.031 |  3038.154 |  3097.391 |  3636.507 |
| ShuffleBenchmark_Int32 | SumTraits_Args0                 |      6212.169 |  6763.988 |  6618.650 |  7005.379 |
| ShuffleBenchmark_Int32 | SumTraits_Args                  |      6493.041 |  6235.346 |  6776.833 |  6981.091 |
| ShuffleBenchmark_Int32 | Sum128_Bcl                      |               |           |           |   535.698 |
| ShuffleBenchmark_Int32 | Sum128_AdvSimd                  |               |           |           |           |
| ShuffleBenchmark_Int32 | Sum128Traits                    |      2117.871 |  3505.560 |  3316.811 |  4945.924 |
| ShuffleBenchmark_Int32 | Sum256_Bcl                      |               |           |           |           |
| ShuffleBenchmark_Int32 | Sum256Traits                    |               |           |           |           |
| ShuffleBenchmark_Int32 | SumKernelTraits                 |      2871.354 |  3948.604 |  4315.436 |  5035.680 |
| ShuffleBenchmark_Int32 | SumKernelTraits_Args0           |      6138.326 |  5429.647 |  7003.559 |  6817.644 |
| ShuffleBenchmark_Int32 | SumKernelTraits_Args            |      6208.813 |  6542.452 |  6767.243 |  7016.655 |
| ShuffleBenchmark_Int32 | SumKernel128_AdvSimd            |               |           |           |           |
| ShuffleBenchmark_Int32 | SumKernel128Traits              |      3119.094 |  4298.532 |  4483.136 |  6360.422 |
| ShuffleBenchmark_Int32 | SumKernel256Traits              |               |           |           |           |
| ShuffleBenchmark_Int32 | SumKernel256Traits_Args0        |               |           |           |           |
| ShuffleBenchmark_Int32 | SumKernel256Traits_Args         |               |           |           |           |
| ShuffleBenchmark_Int64 | SumScalar                       |       276.073 |   291.554 |   280.040 |   277.392 |
| ShuffleBenchmark_Int64 | SumBase                         |       276.662 |   291.859 |   280.191 |   277.634 |
| ShuffleBenchmark_Int64 | SumTraits                       |       830.008 |  1388.538 |  1307.429 |  1822.714 |
| ShuffleBenchmark_Int64 | SumTraits_Args0                 |      3255.313 |  3343.512 |  3280.135 |  3334.538 |
| ShuffleBenchmark_Int64 | SumTraits_Args                  |      3111.626 |  3195.081 |  3295.345 |  3354.894 |
| ShuffleBenchmark_Int64 | Sum128_Bcl                      |               |           |           |   301.554 |
| ShuffleBenchmark_Int64 | Sum128_AdvSimd                  |               |           |           |           |
| ShuffleBenchmark_Int64 | Sum128Traits                    |      1054.096 |  1444.028 |  1461.001 |  1856.322 |
| ShuffleBenchmark_Int64 | Sum256_Bcl                      |               |           |           |           |
| ShuffleBenchmark_Int64 | Sum256Traits                    |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernelTraits                 |      1449.179 |  1941.636 |  2152.402 |  2360.493 |
| ShuffleBenchmark_Int64 | SumKernelTraits_Args0           |      2730.876 |  3204.512 |  3287.616 |  3558.987 |
| ShuffleBenchmark_Int64 | SumKernelTraits_Args            |      2912.020 |  3337.283 |  3205.269 |  3563.819 |
| ShuffleBenchmark_Int64 | SumKernel128_Sse_DuplicateEven  |      1230.846 |  1720.917 |  1717.103 |  2163.989 |
| ShuffleBenchmark_Int64 | SumKernel128_AdvSimd            |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel128_Arm_Multiply       |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel128Traits              |      1267.601 |  2290.195 |  2200.748 |  2841.992 |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_AlignRight    |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_DuplicateEven |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_Multiply      |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_ShiftLane     |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256Traits              |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256Traits_Args0        |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256Traits_Args         |               |           |           |           |
| ShuffleBenchmark_SByte | SumScalar                       |       963.320 |  1057.803 |  1028.821 |  1029.944 |
| ShuffleBenchmark_SByte | SumBase                         |      1027.300 |  1051.996 |  1028.922 |  1022.099 |
| ShuffleBenchmark_SByte | SumTraits                       |     10617.759 | 16080.835 | 19793.764 | 19550.985 |
| ShuffleBenchmark_SByte | SumTraits_Args0                 |     26518.244 | 25854.669 | 25418.389 | 28865.877 |
| ShuffleBenchmark_SByte | SumTraits_Args                  |     26180.253 | 26139.450 | 27457.767 | 24388.763 |
| ShuffleBenchmark_SByte | Sum128_Bcl                      |               |           |           |   802.731 |
| ShuffleBenchmark_SByte | Sum128_AdvSimd                  |               |           |           |           |
| ShuffleBenchmark_SByte | Sum128Traits                    |     10591.944 | 18740.745 | 21431.121 | 21536.321 |
| ShuffleBenchmark_SByte | Sum256_Bcl                      |               |           |           |           |
| ShuffleBenchmark_SByte | Sum256_Avx2_Add1                |               |           |           |           |
| ShuffleBenchmark_SByte | Sum256_Avx2_Add2                |               |           |           |           |
| ShuffleBenchmark_SByte | Sum256_Avx2_Cmp2                |               |           |           |           |
| ShuffleBenchmark_SByte | Sum256_Avx2_EqualAnd            |               |           |           |           |
| ShuffleBenchmark_SByte | Sum256Traits                    |               |           |           |           |
| ShuffleBenchmark_SByte | SumKernelTraits                 |     25796.330 | 21659.094 | 21868.788 | 24517.746 |
| ShuffleBenchmark_SByte | SumKernelTraits_Args0           |     26101.227 | 27315.981 | 26659.470 | 27710.286 |
| ShuffleBenchmark_SByte | SumKernelTraits_Args            |     24867.437 | 27889.534 | 27392.049 | 27920.304 |
| ShuffleBenchmark_SByte | SumKernel128_AdvSimd            |               |           |           |           |
| ShuffleBenchmark_SByte | SumKernel128Traits              |     24461.205 | 25201.216 | 26896.689 | 28278.463 |
| ShuffleBenchmark_SByte | SumKernel256Traits              |               |           |           |           |
| ShuffleBenchmark_SByte | SumKernel256Traits_Args0        |               |           |           |           |
| ShuffleBenchmark_SByte | SumKernel256Traits_Args         |               |           |           |           |

### Arm - AWS Arm t4g.small
| Type                   | Method                          | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :--------------------- | :------------------------------ | ------------: | --------: | --------: | --------: |
| ShuffleBenchmark_Int16 | SumScalar                       |       424.999 |   423.218 |   419.101 |   527.300 |
| ShuffleBenchmark_Int16 | SumBase                         |       425.670 |   422.538 |   422.107 |   527.113 |
| ShuffleBenchmark_Int16 | SumTraits                       |       425.313 |  4699.731 |  5530.044 |  5869.854 |
| ShuffleBenchmark_Int16 | SumTraits_Args0                 |       424.768 |  8429.938 |  8257.430 |  9942.485 |
| ShuffleBenchmark_Int16 | SumTraits_Args                  |       400.596 |  2978.896 |  2867.447 |  9921.169 |
| ShuffleBenchmark_Int16 | Sum128_Bcl                      |               |           |           |   481.867 |
| ShuffleBenchmark_Int16 | Sum128_AdvSimd                  |               |  3150.881 |  3102.195 |  3111.658 |
| ShuffleBenchmark_Int16 | Sum128Traits                    |       238.425 |  4981.104 |  5528.097 |  5878.244 |
| ShuffleBenchmark_Int16 | Sum256_Bcl                      |               |           |           |           |
| ShuffleBenchmark_Int16 | Sum256Traits                    |               |           |           |           |
| ShuffleBenchmark_Int16 | SumKernelTraits                 |       425.055 |  5280.154 |  6489.835 |  7965.363 |
| ShuffleBenchmark_Int16 | SumKernelTraits_Args0           |       424.753 |  8432.769 |  7773.929 |  9946.938 |
| ShuffleBenchmark_Int16 | SumKernelTraits_Args            |       400.853 |  2976.102 |  2977.539 |  9918.004 |
| ShuffleBenchmark_Int16 | SumKernel128_AdvSimd            |               |  2963.866 |  3350.936 |  3971.472 |
| ShuffleBenchmark_Int16 | SumKernel128Traits              |       238.843 |  6554.537 |  6472.303 |  7967.252 |
| ShuffleBenchmark_Int16 | SumKernel256_Avx2_Multiply      |               |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel256_Avx2_ShiftLane     |               |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel256Traits              |               |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel256Traits_Args0        |               |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel256Traits_Args         |               |           |           |           |
| ShuffleBenchmark_Int32 | SumScalar                       |       287.973 |   280.924 |   281.376 |   316.554 |
| ShuffleBenchmark_Int32 | SumBase                         |       287.844 |   281.217 |   281.189 |   317.811 |
| ShuffleBenchmark_Int32 | SumTraits                       |       288.127 |  2450.585 |  2447.558 |  2921.792 |
| ShuffleBenchmark_Int32 | SumTraits_Args0                 |       287.246 |  4151.578 |  3868.791 |  4864.057 |
| ShuffleBenchmark_Int32 | SumTraits_Args                  |       268.578 |  1484.278 |  1488.202 |  4826.316 |
| ShuffleBenchmark_Int32 | Sum128_Bcl                      |               |           |           |   302.889 |
| ShuffleBenchmark_Int32 | Sum128_AdvSimd                  |               |  1356.297 |  1554.618 |  1591.645 |
| ShuffleBenchmark_Int32 | Sum128Traits                    |       153.214 |  2622.213 |  2760.609 |  2920.299 |
| ShuffleBenchmark_Int32 | Sum256_Bcl                      |               |           |           |           |
| ShuffleBenchmark_Int32 | Sum256Traits                    |               |           |           |           |
| ShuffleBenchmark_Int32 | SumKernelTraits                 |       287.659 |  2653.535 |  3231.874 |  3916.923 |
| ShuffleBenchmark_Int32 | SumKernelTraits_Args0           |       286.498 |  3910.887 |  3874.060 |  4840.789 |
| ShuffleBenchmark_Int32 | SumKernelTraits_Args            |       268.501 |  1483.173 |  1480.430 |  4819.802 |
| ShuffleBenchmark_Int32 | SumKernel128_AdvSimd            |               |  1442.208 |  1672.496 |  1980.863 |
| ShuffleBenchmark_Int32 | SumKernel128Traits              |       153.157 |  3259.100 |  3231.342 |  3925.725 |
| ShuffleBenchmark_Int32 | SumKernel256Traits              |               |           |           |           |
| ShuffleBenchmark_Int32 | SumKernel256Traits_Args0        |               |           |           |           |
| ShuffleBenchmark_Int32 | SumKernel256Traits_Args         |               |           |           |           |
| ShuffleBenchmark_Int64 | SumScalar                       |       379.969 |   440.479 |   443.096 |   552.245 |
| ShuffleBenchmark_Int64 | SumBase                         |       379.331 |   411.212 |   442.968 |   551.973 |
| ShuffleBenchmark_Int64 | SumTraits                       |       184.441 |  1012.778 |  1070.236 |  1254.759 |
| ShuffleBenchmark_Int64 | SumTraits_Args0                 |       378.846 |  1963.813 |  2069.707 |  2463.769 |
| ShuffleBenchmark_Int64 | SumTraits_Args                  |       335.792 |   717.028 |   742.759 |  2452.291 |
| ShuffleBenchmark_Int64 | Sum128_Bcl                      |               |           |           |   712.337 |
| ShuffleBenchmark_Int64 | Sum128_AdvSimd                  |               |   592.424 |   536.670 |   604.608 |
| ShuffleBenchmark_Int64 | Sum128Traits                    |       207.549 |  1228.061 |  1078.230 |  1266.492 |
| ShuffleBenchmark_Int64 | Sum256_Bcl                      |               |           |           |           |
| ShuffleBenchmark_Int64 | Sum256Traits                    |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernelTraits                 |       182.389 |  1217.434 |  1408.426 |  1767.667 |
| ShuffleBenchmark_Int64 | SumKernelTraits_Args0           |       180.539 |  2100.070 |  1952.918 |  2464.893 |
| ShuffleBenchmark_Int64 | SumKernelTraits_Args            |       335.424 |   741.609 |   743.436 |  2450.730 |
| ShuffleBenchmark_Int64 | SumKernel128_Sse_DuplicateEven  |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel128_AdvSimd            |               |   931.591 |   892.424 |   914.749 |
| ShuffleBenchmark_Int64 | SumKernel128_Arm_Multiply       |               |   468.751 |   489.128 |   569.016 |
| ShuffleBenchmark_Int64 | SumKernel128Traits              |       146.886 |  1457.029 |  1473.008 |  1765.059 |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_AlignRight    |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_DuplicateEven |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_Multiply      |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_ShiftLane     |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256Traits              |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256Traits_Args0        |               |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256Traits_Args         |               |           |           |           |
| ShuffleBenchmark_SByte | SumScalar                       |       667.455 |   660.836 |   658.330 |   833.764 |
| ShuffleBenchmark_SByte | SumBase                         |       648.386 |   646.261 |   660.571 |   835.092 |
| ShuffleBenchmark_SByte | SumTraits                       |       667.668 | 15581.384 | 16720.691 | 19748.119 |
| ShuffleBenchmark_SByte | SumTraits_Args0                 |       665.086 | 16724.814 | 15729.294 | 19742.430 |
| ShuffleBenchmark_SByte | SumTraits_Args                  |       626.181 |  5940.901 |  5954.235 | 19683.036 |
| ShuffleBenchmark_SByte | Sum128_Bcl                      |               |           |           |   649.177 |
| ShuffleBenchmark_SByte | Sum128_AdvSimd                  |               | 11739.301 | 11725.385 | 13143.611 |
| ShuffleBenchmark_SByte | Sum128Traits                    |       399.980 | 15752.275 | 16761.213 | 19779.062 |
| ShuffleBenchmark_SByte | Sum256_Bcl                      |               |           |           |           |
| ShuffleBenchmark_SByte | Sum256_Avx2_Add1                |               |           |           |           |
| ShuffleBenchmark_SByte | Sum256_Avx2_Add2                |               |           |           |           |
| ShuffleBenchmark_SByte | Sum256_Avx2_Cmp2                |               |           |           |           |
| ShuffleBenchmark_SByte | Sum256_Avx2_EqualAnd            |               |           |           |           |
| ShuffleBenchmark_SByte | Sum256Traits                    |               |           |           |           |
| ShuffleBenchmark_SByte | SumKernelTraits                 |       648.453 | 13129.238 | 16691.707 | 19731.858 |
| ShuffleBenchmark_SByte | SumKernelTraits_Args0           |       665.102 | 15734.005 | 15694.804 | 19702.186 |
| ShuffleBenchmark_SByte | SumKernelTraits_Args            |       624.959 |  5728.363 |  5940.288 | 19669.480 |
| ShuffleBenchmark_SByte | SumKernel128_AdvSimd            |               | 11248.646 | 11746.544 | 13134.187 |
| ShuffleBenchmark_SByte | SumKernel128Traits              |       400.112 | 16757.494 | 16751.903 | 19765.379 |
| ShuffleBenchmark_SByte | SumKernel256Traits              |               |           |           |           |
| ShuffleBenchmark_SByte | SumKernel256Traits_Args0        |               |           |           |           |
| ShuffleBenchmark_SByte | SumKernel256Traits_Args         |               |           |           |           |

