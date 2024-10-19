# Benchmark group - Shuffle
([← Back](Shuffle.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### X86 - AMD Ryzen 7 7840H
| Type                   | Method                          | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :--------------------- | :------------------------------ | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| ShuffleBenchmark_Int16 | SumScalar                       |       1236.944 |      1263.908 |      1214.484 |  1278.657 |  1195.188 |  1408.179 |  1235.365 |
| ShuffleBenchmark_Int16 | SumBase                         |       1270.376 |      1208.793 |      1221.340 |  1246.319 |  1212.305 |  1406.729 |  1261.582 |
| ShuffleBenchmark_Int16 | SumTraits                       |       1221.046 |      1255.341 |      8067.493 | 10943.134 | 10421.696 | 14194.280 | 32579.746 |
| ShuffleBenchmark_Int16 | SumTraits_Args0                 |       1278.650 |      1211.361 |     22661.648 | 25363.988 | 24123.555 | 26722.243 | 34671.910 |
| ShuffleBenchmark_Int16 | SumTraits_Args                  |       1255.109 |      1154.801 |     22911.649 | 26138.766 | 24804.170 | 26585.684 | 33172.777 |
| ShuffleBenchmark_Int16 | Sum128_Bcl                      |                |               |               |           |           |           |           |
| ShuffleBenchmark_Int16 | Sum128_AdvSimd                  |                |               |               |           |           |           |           |
| ShuffleBenchmark_Int16 | Sum128Traits                    |                |               |               |           |           |           |           |
| ShuffleBenchmark_Int16 | Sum256_Bcl                      |                |               |               |           |           |  1074.656 |   938.447 |
| ShuffleBenchmark_Int16 | Sum256Traits                    |                |               |      8453.891 | 12415.380 | 12463.128 | 19916.073 | 33098.630 |
| ShuffleBenchmark_Int16 | Sum512_Bcl                      |                |               |               |           |           |           |   918.911 |
| ShuffleBenchmark_Int16 | Sum512Traits                    |                |               |               |           |           |           | 32342.977 |
| ShuffleBenchmark_Int16 | SumKernelTraits                 |       1269.733 |      1192.079 |      8698.117 | 12377.326 | 11972.407 | 17610.477 | 35632.301 |
| ShuffleBenchmark_Int16 | SumKernelTraits_Args0           |       1297.765 |      1199.697 |     23028.564 | 25852.122 | 25176.482 | 24261.582 | 36741.022 |
| ShuffleBenchmark_Int16 | SumKernelTraits_Args            |       1270.852 |      1142.885 |     23265.595 | 25960.405 | 21744.418 | 23156.078 | 37227.607 |
| ShuffleBenchmark_Int16 | SumKernel128_AdvSimd            |                |               |               |           |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel128Traits              |                |               |               |           |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel256_Avx2_Multiply      |                |               |      8575.866 | 13784.163 | 13809.947 | 18935.398 | 36602.662 |
| ShuffleBenchmark_Int16 | SumKernel256_Avx2_ShiftLane     |                |               |     10109.809 | 14360.709 | 13711.196 | 13723.729 | 23133.972 |
| ShuffleBenchmark_Int16 | SumKernel256Traits              |                |               |      8489.587 | 13381.369 | 13280.373 | 18872.614 | 36266.651 |
| ShuffleBenchmark_Int16 | SumKernel256Traits_Args0        |                |               |     25043.819 | 24164.491 | 25218.816 | 23099.332 | 36420.461 |
| ShuffleBenchmark_Int16 | SumKernel256Traits_Args         |                |               |     24582.356 | 25719.170 | 24805.980 | 20517.507 | 36162.413 |
| ShuffleBenchmark_Int32 | SumScalar                       |        850.057 |       829.782 |       816.013 |   859.672 |   817.223 |   853.140 |   837.720 |
| ShuffleBenchmark_Int32 | SumBase                         |        829.011 |       832.311 |       845.489 |   855.995 |   838.020 |   864.152 |   826.740 |
| ShuffleBenchmark_Int32 | SumTraits                       |        821.394 |       844.388 |     10852.534 | 10832.760 | 10943.342 | 12695.692 | 15067.794 |
| ShuffleBenchmark_Int32 | SumTraits_Args0                 |        864.447 |       818.042 |     12704.591 | 15953.127 | 15574.554 | 14391.785 | 15559.766 |
| ShuffleBenchmark_Int32 | SumTraits_Args                  |        810.166 |       762.183 |     12531.310 | 14746.991 | 14125.335 | 13524.193 | 15368.528 |
| ShuffleBenchmark_Int32 | Sum128_Bcl                      |                |               |               |           |           |           |           |
| ShuffleBenchmark_Int32 | Sum128_AdvSimd                  |                |               |               |           |           |           |           |
| ShuffleBenchmark_Int32 | Sum128_Wasm_CompareGreater      |                |               |               |           |           |           |           |
| ShuffleBenchmark_Int32 | Sum128_Wasm_EqualsShift         |                |               |               |           |           |           |           |
| ShuffleBenchmark_Int32 | Sum128Traits                    |                |               |               |           |           |           |           |
| ShuffleBenchmark_Int32 | Sum256_Bcl                      |                |               |               |           |           |   755.314 |   770.558 |
| ShuffleBenchmark_Int32 | Sum256_Avx2_Add1                |                |               |      7141.994 | 10800.960 | 12024.807 | 11699.668 | 15235.520 |
| ShuffleBenchmark_Int32 | Sum256Traits                    |                |               |     11595.912 | 13052.644 | 14283.708 | 13979.190 | 15620.350 |
| ShuffleBenchmark_Int32 | Sum512_Bcl                      |                |               |               |           |           |           |   930.330 |
| ShuffleBenchmark_Int32 | Sum512Traits                    |                |               |               |           |           |           | 14817.994 |
| ShuffleBenchmark_Int32 | SumKernelTraits                 |        825.747 |       841.229 |     14515.308 | 14407.190 | 14545.131 | 16276.648 | 15999.993 |
| ShuffleBenchmark_Int32 | SumKernelTraits_Args0           |        856.015 |       814.055 |     14754.810 | 14880.916 | 17262.390 | 14319.199 | 16261.174 |
| ShuffleBenchmark_Int32 | SumKernelTraits_Args            |        806.479 |       765.218 |     15073.768 | 14604.621 | 16999.007 | 16367.119 | 16422.220 |
| ShuffleBenchmark_Int32 | SumKernel128_AdvSimd            |                |               |               |           |           |           |           |
| ShuffleBenchmark_Int32 | SumKernel128Traits              |                |               |               |           |           |           |           |
| ShuffleBenchmark_Int32 | SumKernel256Traits              |                |               |     16988.322 | 15526.311 | 10548.803 | 14853.425 | 16343.393 |
| ShuffleBenchmark_Int32 | SumKernel256Traits_Args0        |                |               |     16610.754 | 17017.951 | 15952.165 | 15817.259 | 15931.136 |
| ShuffleBenchmark_Int32 | SumKernel256Traits_Args         |                |               |     17216.220 | 11015.375 | 13792.076 | 13552.579 | 15905.211 |
| ShuffleBenchmark_Int64 | SumScalar                       |        425.474 |       430.216 |       457.179 |   497.203 |   465.105 |   432.348 |   425.921 |
| ShuffleBenchmark_Int64 | SumBase                         |        468.461 |       428.475 |       425.688 |   496.350 |   430.476 |   501.038 |   427.753 |
| ShuffleBenchmark_Int64 | SumTraits                       |        474.906 |       431.296 |      3789.327 |  4192.951 |  4280.568 |  4155.819 |  8171.028 |
| ShuffleBenchmark_Int64 | SumTraits_Args0                 |        423.703 |       461.664 |      6979.885 |  7855.241 |  8501.271 |  7846.303 |  8198.449 |
| ShuffleBenchmark_Int64 | SumTraits_Args                  |        446.260 |       420.925 |      6704.874 |  8599.441 |  8317.550 |  7312.362 |  8378.340 |
| ShuffleBenchmark_Int64 | Sum128_Bcl                      |                |               |               |           |           |           |           |
| ShuffleBenchmark_Int64 | Sum128_AdvSimd                  |                |               |               |           |           |           |           |
| ShuffleBenchmark_Int64 | Sum128Traits                    |                |               |               |           |           |           |           |
| ShuffleBenchmark_Int64 | Sum256_Bcl                      |                |               |               |           |           |   506.686 |   515.520 |
| ShuffleBenchmark_Int64 | Sum256Traits                    |                |               |      4025.137 |  5466.388 |  5258.504 |  5355.022 |  8089.992 |
| ShuffleBenchmark_Int64 | Sum512_Bcl                      |                |               |               |           |           |           |   688.892 |
| ShuffleBenchmark_Int64 | Sum512Traits                    |                |               |               |           |           |           |  7733.564 |
| ShuffleBenchmark_Int64 | SumKernelTraits                 |        473.823 |       426.081 |      4854.793 |  5862.440 |  5735.074 |  5938.699 |  8560.856 |
| ShuffleBenchmark_Int64 | SumKernelTraits_Args0           |        424.508 |       458.248 |      7804.575 |  8108.408 |  9181.086 |  8364.106 |  8701.155 |
| ShuffleBenchmark_Int64 | SumKernelTraits_Args            |        446.097 |       428.538 |      8386.279 |  9239.331 |  9198.798 |  8344.952 |  8673.715 |
| ShuffleBenchmark_Int64 | SumKernel128_Sse_DuplicateEven  |                |               |               |           |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel128_AdvSimd            |                |               |               |           |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel128_Arm_Multiply       |                |               |               |           |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel128Traits              |                |               |               |           |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_AlignRight    |                |               |      4880.617 |  5470.127 |  5419.855 |  5415.151 |  8791.891 |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_DuplicateEven |                |               |      5276.504 |  6066.870 |  6154.469 |  6241.420 |  8688.759 |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_Multiply      |                |               |      2267.039 |  2848.082 |  2984.934 |  2710.042 |  8892.630 |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_ShiftLane     |                |               |      4821.492 |  5977.394 |  6254.779 |  6266.401 |  8825.284 |
| ShuffleBenchmark_Int64 | SumKernel256Traits              |                |               |      5471.014 |  6193.223 |  5999.570 |  6335.666 |  8680.147 |
| ShuffleBenchmark_Int64 | SumKernel256Traits_Args0        |                |               |      8963.776 |  8029.324 |  9198.774 |  8191.638 |  8601.527 |
| ShuffleBenchmark_Int64 | SumKernel256Traits_Args         |                |               |      7897.715 |  7810.420 |  8772.684 |  8391.317 |  8724.270 |
| ShuffleBenchmark_SByte | SumScalar                       |       1496.783 |      1403.348 |      1448.660 |  1239.277 |  1468.827 |  1415.139 |  1213.582 |
| ShuffleBenchmark_SByte | SumBase                         |       1537.986 |      1513.440 |      1306.115 |  1500.220 |  1452.622 |  1474.647 |  1441.306 |
| ShuffleBenchmark_SByte | SumTraits                       |       1476.771 |      1494.144 |     17086.314 | 24231.464 | 24097.622 | 30243.434 | 60885.250 |
| ShuffleBenchmark_SByte | SumTraits_Args0                 |       1392.158 |      1331.083 |     45038.802 | 50540.409 | 49090.081 | 46979.783 | 60672.985 |
| ShuffleBenchmark_SByte | SumTraits_Args                  |       1389.074 |      1295.641 |     46794.997 | 51069.265 | 50078.249 | 46518.750 | 65261.554 |
| ShuffleBenchmark_SByte | Sum128_Bcl                      |                |               |               |           |           |           |           |
| ShuffleBenchmark_SByte | Sum128_AdvSimd                  |                |               |               |           |           |           |           |
| ShuffleBenchmark_SByte | Sum128Traits                    |                |               |               |           |           |           |           |
| ShuffleBenchmark_SByte | Sum256_Bcl                      |                |               |               |           |           |   901.114 |  1022.223 |
| ShuffleBenchmark_SByte | Sum256_Avx2_Add1                |                |               |     17680.705 | 27259.330 | 26928.091 | 31652.671 | 54966.710 |
| ShuffleBenchmark_SByte | Sum256_Avx2_Add2                |                |               |     16981.534 | 24595.180 | 25390.338 | 29868.309 | 42493.502 |
| ShuffleBenchmark_SByte | Sum256_Avx2_Cmp2                |                |               |     19108.512 | 25697.522 | 32141.792 | 32237.731 | 58940.683 |
| ShuffleBenchmark_SByte | Sum256_Avx2_EqualAnd            |                |               |     20064.881 | 27827.353 | 27032.611 | 26385.226 | 60458.784 |
| ShuffleBenchmark_SByte | Sum256Traits                    |                |               |     16711.858 | 26366.642 | 28817.941 | 31706.056 | 66988.398 |
| ShuffleBenchmark_SByte | Sum512_Bcl                      |                |               |               |           |           |           |   989.131 |
| ShuffleBenchmark_SByte | Sum512Traits                    |                |               |               |           |           |           | 64432.274 |
| ShuffleBenchmark_SByte | SumKernelTraits                 |       1476.637 |      1242.198 |     27650.933 | 32894.218 | 32711.664 | 39630.939 | 72350.167 |
| ShuffleBenchmark_SByte | SumKernelTraits_Args0           |       1523.543 |      1440.011 |     44451.891 | 49973.813 | 51540.236 | 48754.502 | 72615.251 |
| ShuffleBenchmark_SByte | SumKernelTraits_Args            |       1395.106 |      1274.943 |     41001.996 | 50067.099 | 49654.805 | 45904.504 | 71412.964 |
| ShuffleBenchmark_SByte | SumKernel128_AdvSimd            |                |               |               |           |           |           |           |
| ShuffleBenchmark_SByte | SumKernel128Traits              |                |               |               |           |           |           |           |
| ShuffleBenchmark_SByte | SumKernel256Traits              |                |               |     27602.150 | 38375.073 | 37451.508 | 43518.592 | 71712.144 |
| ShuffleBenchmark_SByte | SumKernel256Traits_Args0        |                |               |     48745.607 | 49345.013 | 50973.728 | 48093.264 | 71875.070 |
| ShuffleBenchmark_SByte | SumKernel256Traits_Args         |                |               |     47232.647 | 47781.949 | 50184.740 | 46542.897 | 73291.774 |

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

### Arm - Apple M2
| Type                   | Method                          |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :--------------------- | :------------------------------ | --------: | --------: | --------: |
| ShuffleBenchmark_Int16 | SumScalar                       |  1813.611 |  2286.981 |  2267.510 |
| ShuffleBenchmark_Int16 | SumBase                         |  1813.720 |  2290.775 |  2267.218 |
| ShuffleBenchmark_Int16 | SumTraits                       | 13593.983 | 13603.414 | 13614.059 |
| ShuffleBenchmark_Int16 | SumTraits_Args0                 | 13611.708 | 13607.433 | 13611.140 |
| ShuffleBenchmark_Int16 | SumTraits_Args                  | 13577.658 | 13608.068 | 13613.104 |
| ShuffleBenchmark_Int16 | Sum128_Bcl                      |           |  1892.287 |  1909.152 |
| ShuffleBenchmark_Int16 | Sum128_AdvSimd                  | 11448.478 | 13116.280 | 13603.377 |
| ShuffleBenchmark_Int16 | Sum128Traits                    | 13602.376 | 13606.053 | 13614.115 |
| ShuffleBenchmark_Int16 | Sum256_Bcl                      |           |           |           |
| ShuffleBenchmark_Int16 | Sum256Traits                    |           |           |           |
| ShuffleBenchmark_Int16 | Sum512_Bcl                      |           |           |  1912.983 |
| ShuffleBenchmark_Int16 | Sum512Traits                    |           |           |  1912.982 |
| ShuffleBenchmark_Int16 | SumKernelTraits                 | 13604.116 | 13611.317 | 13616.924 |
| ShuffleBenchmark_Int16 | SumKernelTraits_Args0           | 13610.012 | 13612.060 | 13613.942 |
| ShuffleBenchmark_Int16 | SumKernelTraits_Args            | 13578.600 | 13609.518 | 13616.825 |
| ShuffleBenchmark_Int16 | SumKernel128_AdvSimd            | 12085.817 | 13593.857 | 13600.748 |
| ShuffleBenchmark_Int16 | SumKernel128Traits              | 13604.367 | 13611.349 | 13613.471 |
| ShuffleBenchmark_Int16 | SumKernel256_Avx2_Multiply      |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel256_Avx2_ShiftLane     |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel256Traits              |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel256Traits_Args0        |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel256Traits_Args         |           |           |           |
| ShuffleBenchmark_Int32 | SumScalar                       |  1600.170 |  1943.129 |  1942.939 |
| ShuffleBenchmark_Int32 | SumBase                         |  1600.118 |  1942.929 |  1700.166 |
| ShuffleBenchmark_Int32 | SumTraits                       |  6798.483 |  6802.443 |  6805.336 |
| ShuffleBenchmark_Int32 | SumTraits_Args0                 |  6802.581 |  6802.236 |  6804.942 |
| ShuffleBenchmark_Int32 | SumTraits_Args                  |  6793.540 |  6802.317 |  6804.719 |
| ShuffleBenchmark_Int32 | Sum128_Bcl                      |           |  2617.002 |  2619.142 |
| ShuffleBenchmark_Int32 | Sum128_AdvSimd                  |  5725.075 |  6562.261 |  6802.300 |
| ShuffleBenchmark_Int32 | Sum128_Wasm_CompareGreater      |           |           |           |
| ShuffleBenchmark_Int32 | Sum128_Wasm_EqualsShift         |           |           |           |
| ShuffleBenchmark_Int32 | Sum128Traits                    |  6800.272 |  6803.618 |  6805.516 |
| ShuffleBenchmark_Int32 | Sum256_Bcl                      |           |           |           |
| ShuffleBenchmark_Int32 | Sum256_Avx2_Add1                |           |           |           |
| ShuffleBenchmark_Int32 | Sum256Traits                    |           |           |           |
| ShuffleBenchmark_Int32 | Sum512_Bcl                      |           |           |  1747.491 |
| ShuffleBenchmark_Int32 | Sum512Traits                    |           |           |  1748.702 |
| ShuffleBenchmark_Int32 | SumKernelTraits                 |  6798.492 |  6804.381 |  6803.818 |
| ShuffleBenchmark_Int32 | SumKernelTraits_Args0           |  6803.152 |  6804.811 |  6805.694 |
| ShuffleBenchmark_Int32 | SumKernelTraits_Args            |  6795.238 |  6804.500 |  6802.751 |
| ShuffleBenchmark_Int32 | SumKernel128_AdvSimd            |  6013.588 |  6799.175 |  6799.723 |
| ShuffleBenchmark_Int32 | SumKernel128Traits              |  6801.578 |  6803.402 |  6803.696 |
| ShuffleBenchmark_Int32 | SumKernel256Traits              |           |           |           |
| ShuffleBenchmark_Int32 | SumKernel256Traits_Args0        |           |           |           |
| ShuffleBenchmark_Int32 | SumKernel256Traits_Args         |           |           |           |
| ShuffleBenchmark_Int64 | SumScalar                       |  1294.758 |  1551.021 |  1505.013 |
| ShuffleBenchmark_Int64 | SumBase                         |  1294.541 |  1550.515 |  1509.312 |
| ShuffleBenchmark_Int64 | SumTraits                       |  3399.181 |  3400.917 |  3402.669 |
| ShuffleBenchmark_Int64 | SumTraits_Args0                 |  3400.768 |  3401.830 |  3401.864 |
| ShuffleBenchmark_Int64 | SumTraits_Args                  |  3398.536 |  3401.340 |  3402.187 |
| ShuffleBenchmark_Int64 | Sum128_Bcl                      |           |  2055.437 |  2059.051 |
| ShuffleBenchmark_Int64 | Sum128_AdvSimd                  |  2365.370 |  2773.480 |  3400.783 |
| ShuffleBenchmark_Int64 | Sum128Traits                    |  3400.241 |  3401.851 |  3402.265 |
| ShuffleBenchmark_Int64 | Sum256_Bcl                      |           |           |           |
| ShuffleBenchmark_Int64 | Sum256Traits                    |           |           |           |
| ShuffleBenchmark_Int64 | Sum512_Bcl                      |           |           |  1512.807 |
| ShuffleBenchmark_Int64 | Sum512Traits                    |           |           |  1510.622 |
| ShuffleBenchmark_Int64 | SumKernelTraits                 |  3400.653 |  3401.744 |  3400.987 |
| ShuffleBenchmark_Int64 | SumKernelTraits_Args0           |  3401.209 |  3401.822 |  3401.855 |
| ShuffleBenchmark_Int64 | SumKernelTraits_Args            |  3398.930 |  3402.198 |  3402.201 |
| ShuffleBenchmark_Int64 | SumKernel128_Sse_DuplicateEven  |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel128_AdvSimd            |  3022.573 |  3400.468 |  3401.420 |
| ShuffleBenchmark_Int64 | SumKernel128_Arm_Multiply       |  1553.900 |  2063.375 |   443.217 |
| ShuffleBenchmark_Int64 | SumKernel128Traits              |  3401.970 |  3401.930 |  3402.144 |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_AlignRight    |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_DuplicateEven |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_Multiply      |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_ShiftLane     |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256Traits              |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256Traits_Args0        |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256Traits_Args         |           |           |           |
| ShuffleBenchmark_SByte | SumScalar                       |  2266.726 |  2736.182 |  2715.459 |
| ShuffleBenchmark_SByte | SumBase                         |  2266.739 |  2735.397 |  2716.850 |
| ShuffleBenchmark_SByte | SumTraits                       | 27175.969 | 27165.670 | 27193.666 |
| ShuffleBenchmark_SByte | SumTraits_Args0                 | 27183.317 | 27163.344 | 27200.994 |
| ShuffleBenchmark_SByte | SumTraits_Args                  | 27066.764 | 27153.973 | 27194.756 |
| ShuffleBenchmark_SByte | Sum128_Bcl                      |           |  1986.725 |  1995.712 |
| ShuffleBenchmark_SByte | Sum128_AdvSimd                  | 27147.801 | 27144.258 | 27178.830 |
| ShuffleBenchmark_SByte | Sum128Traits                    | 27202.974 | 27195.784 | 27201.747 |
| ShuffleBenchmark_SByte | Sum256_Bcl                      |           |           |           |
| ShuffleBenchmark_SByte | Sum256_Avx2_Add1                |           |           |           |
| ShuffleBenchmark_SByte | Sum256_Avx2_Add2                |           |           |           |
| ShuffleBenchmark_SByte | Sum256_Avx2_Cmp2                |           |           |           |
| ShuffleBenchmark_SByte | Sum256_Avx2_EqualAnd            |           |           |           |
| ShuffleBenchmark_SByte | Sum256Traits                    |           |           |           |
| ShuffleBenchmark_SByte | Sum512_Bcl                      |           |           |  1998.195 |
| ShuffleBenchmark_SByte | Sum512Traits                    |           |           |  1998.720 |
| ShuffleBenchmark_SByte | SumKernelTraits                 | 27176.436 | 27166.467 | 27199.577 |
| ShuffleBenchmark_SByte | SumKernelTraits_Args0           | 27181.156 | 27163.831 | 27199.077 |
| ShuffleBenchmark_SByte | SumKernelTraits_Args            | 27065.350 | 27153.156 | 27202.032 |
| ShuffleBenchmark_SByte | SumKernel128_AdvSimd            | 27148.573 | 27135.989 | 27183.552 |
| ShuffleBenchmark_SByte | SumKernel128Traits              | 27197.911 | 27196.443 | 27206.105 |
| ShuffleBenchmark_SByte | SumKernel256Traits              |           |           |           |
| ShuffleBenchmark_SByte | SumKernel256Traits_Args0        |           |           |           |
| ShuffleBenchmark_SByte | SumKernel256Traits_Args         |           |           |           |

### Arm - AWS Arm t4g.small
| Type                   | Method                          | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :--------------------- | :------------------------------ | ------------: | --------: | --------: | --------: | --------: |
| ShuffleBenchmark_Int16 | SumScalar                       |       427.276 |   421.887 |   421.454 |   526.589 |   516.294 |
| ShuffleBenchmark_Int16 | SumBase                         |       425.871 |   421.454 |   423.412 |   526.191 |   518.273 |
| ShuffleBenchmark_Int16 | SumTraits                       |       428.281 |  4922.876 |  5555.655 |  5864.193 |  9711.569 |
| ShuffleBenchmark_Int16 | SumTraits_Args0                 |       428.928 |  7902.420 |  8416.624 |  9925.441 |  9709.555 |
| ShuffleBenchmark_Int16 | SumTraits_Args                  |       405.537 |  2809.483 |  2798.925 |  9880.804 |  9707.490 |
| ShuffleBenchmark_Int16 | Sum128_Bcl                      |               |           |           |   482.907 |   468.383 |
| ShuffleBenchmark_Int16 | Sum128_AdvSimd                  |               |  2730.866 |  3116.533 |  3140.910 |  5334.923 |
| ShuffleBenchmark_Int16 | Sum128Traits                    |       239.485 |  5262.847 |  5567.725 |  5868.675 |  9827.341 |
| ShuffleBenchmark_Int16 | Sum256_Bcl                      |               |           |           |           |           |
| ShuffleBenchmark_Int16 | Sum256Traits                    |               |           |           |           |           |
| ShuffleBenchmark_Int16 | Sum512_Bcl                      |               |           |           |           |   557.399 |
| ShuffleBenchmark_Int16 | Sum512Traits                    |               |           |           |           |   557.424 |
| ShuffleBenchmark_Int16 | SumKernelTraits                 |       427.637 |  5650.913 |  6540.446 |  7957.175 |  9833.813 |
| ShuffleBenchmark_Int16 | SumKernelTraits_Args0           |       427.578 |  7897.224 |  7891.894 |  9929.863 |  9819.774 |
| ShuffleBenchmark_Int16 | SumKernelTraits_Args            |       405.223 |  2811.195 |  2797.170 |  9861.330 |  9829.822 |
| ShuffleBenchmark_Int16 | SumKernel128_AdvSimd            |               |  3477.554 |  3373.104 |  3505.451 |  5352.675 |
| ShuffleBenchmark_Int16 | SumKernel128Traits              |       239.538 |  6543.087 |  6551.098 |  7950.782 |  9753.632 |
| ShuffleBenchmark_Int16 | SumKernel256_Avx2_Multiply      |               |           |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel256_Avx2_ShiftLane     |               |           |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel256Traits              |               |           |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel256Traits_Args0        |               |           |           |           |           |
| ShuffleBenchmark_Int16 | SumKernel256Traits_Args         |               |           |           |           |           |
| ShuffleBenchmark_Int32 | SumScalar                       |       286.900 |   281.167 |   281.838 |   317.876 |   309.427 |
| ShuffleBenchmark_Int32 | SumBase                         |       287.569 |   280.676 |   281.450 |   315.976 |   309.741 |
| ShuffleBenchmark_Int32 | SumTraits                       |       286.596 |  2311.209 |  2472.592 |  2917.343 |  4801.979 |
| ShuffleBenchmark_Int32 | SumTraits_Args0                 |       288.066 |  4185.430 |  3928.604 |  4934.590 |  4821.784 |
| ShuffleBenchmark_Int32 | SumTraits_Args                  |       270.249 |  1396.323 |  1401.742 |  4886.669 |  4806.886 |
| ShuffleBenchmark_Int32 | Sum128_Bcl                      |               |           |           |   304.320 |   301.222 |
| ShuffleBenchmark_Int32 | Sum128_AdvSimd                  |               |  1561.060 |  1556.727 |  1604.657 |  2676.530 |
| ShuffleBenchmark_Int32 | Sum128_Wasm_CompareGreater      |               |           |           |           |           |
| ShuffleBenchmark_Int32 | Sum128_Wasm_EqualsShift         |               |           |           |           |           |
| ShuffleBenchmark_Int32 | Sum128Traits                    |       156.899 |  2475.662 |  2773.273 |  2925.412 |  4850.125 |
| ShuffleBenchmark_Int32 | Sum256_Bcl                      |               |           |           |           |           |
| ShuffleBenchmark_Int32 | Sum256_Avx2_Add1                |               |           |           |           |           |
| ShuffleBenchmark_Int32 | Sum256Traits                    |               |           |           |           |           |
| ShuffleBenchmark_Int32 | Sum512_Bcl                      |               |           |           |           |   515.317 |
| ShuffleBenchmark_Int32 | Sum512Traits                    |               |           |           |           |   515.275 |
| ShuffleBenchmark_Int32 | SumKernelTraits                 |       287.386 |  2677.394 |  3247.692 |  3953.573 |  4846.437 |
| ShuffleBenchmark_Int32 | SumKernelTraits_Args0           |       286.724 |  3919.619 |  4182.617 |  4930.469 |  4852.808 |
| ShuffleBenchmark_Int32 | SumKernelTraits_Args            |       270.724 |  1399.968 |  1395.953 |  4899.359 |  4853.093 |
| ShuffleBenchmark_Int32 | SumKernel128_AdvSimd            |               |  1607.527 |  1680.474 |  1756.488 |  2673.903 |
| ShuffleBenchmark_Int32 | SumKernel128Traits              |       157.325 |  3272.674 |  3250.843 |  3956.969 |  4805.883 |
| ShuffleBenchmark_Int32 | SumKernel256Traits              |               |           |           |           |           |
| ShuffleBenchmark_Int32 | SumKernel256Traits_Args0        |               |           |           |           |           |
| ShuffleBenchmark_Int32 | SumKernel256Traits_Args         |               |           |           |           |           |
| ShuffleBenchmark_Int64 | SumScalar                       |       448.592 |   440.758 |   444.884 |   552.061 |   534.531 |
| ShuffleBenchmark_Int64 | SumBase                         |       425.377 |   421.331 |   445.929 |   551.659 |   494.525 |
| ShuffleBenchmark_Int64 | SumTraits                       |       190.913 |  1005.614 |  1064.650 |  1255.025 |  2448.365 |
| ShuffleBenchmark_Int64 | SumTraits_Args0                 |       426.809 |  2090.887 |  2100.527 |  2479.821 |  2451.574 |
| ShuffleBenchmark_Int64 | SumTraits_Args                  |       179.534 |   698.013 |   699.200 |  2457.898 |  2451.414 |
| ShuffleBenchmark_Int64 | Sum128_Bcl                      |               |           |           |   708.356 |   692.663 |
| ShuffleBenchmark_Int64 | Sum128_AdvSimd                  |               |   503.046 |   550.840 |   604.367 |  1336.768 |
| ShuffleBenchmark_Int64 | Sum128Traits                    |       234.241 |  1224.675 |  1068.241 |  1259.901 |  2444.056 |
| ShuffleBenchmark_Int64 | Sum256_Bcl                      |               |           |           |           |           |
| ShuffleBenchmark_Int64 | Sum256Traits                    |               |           |           |           |           |
| ShuffleBenchmark_Int64 | Sum512_Bcl                      |               |           |           |           |   543.760 |
| ShuffleBenchmark_Int64 | Sum512Traits                    |               |           |           |           |   543.555 |
| ShuffleBenchmark_Int64 | SumKernelTraits                 |       448.065 |  1237.258 |  1412.876 |  1753.457 |  2434.096 |
| ShuffleBenchmark_Int64 | SumKernelTraits_Args0           |       449.857 |  2101.411 |  1967.152 |  2469.054 |  2443.626 |
| ShuffleBenchmark_Int64 | SumKernelTraits_Args            |       345.877 |   701.805 |   698.753 |  2456.761 |  2451.680 |
| ShuffleBenchmark_Int64 | SumKernel128_Sse_DuplicateEven  |               |           |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel128_AdvSimd            |               |   931.986 |   894.636 |   915.626 |  1340.858 |
| ShuffleBenchmark_Int64 | SumKernel128_Arm_Multiply       |               |   461.974 |   491.264 |   525.260 |   425.974 |
| ShuffleBenchmark_Int64 | SumKernel128Traits              |       234.516 |  1477.127 |  1476.100 |  1758.550 |  2438.271 |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_AlignRight    |               |           |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_DuplicateEven |               |           |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_Multiply      |               |           |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_ShiftLane     |               |           |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256Traits              |               |           |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256Traits_Args0        |               |           |           |           |           |
| ShuffleBenchmark_Int64 | SumKernel256Traits_Args         |               |           |           |           |           |
| ShuffleBenchmark_SByte | SumScalar                       |       665.739 |   664.224 |   658.168 |   834.224 |   803.566 |
| ShuffleBenchmark_SByte | SumBase                         |       672.364 |   659.589 |   659.055 |   834.209 |   812.422 |
| ShuffleBenchmark_SByte | SumTraits                       |       680.590 | 13176.730 | 16739.161 | 19723.567 | 19531.685 |
| ShuffleBenchmark_SByte | SumTraits_Args0                 |       660.595 | 15704.393 | 15724.340 | 19723.852 | 19530.241 |
| ShuffleBenchmark_SByte | SumTraits_Args                  |       637.568 |  5597.644 |  5602.803 | 19605.289 | 19527.338 |
| ShuffleBenchmark_SByte | Sum128_Bcl                      |               |           |           |   647.757 |   610.244 |
| ShuffleBenchmark_SByte | Sum128_AdvSimd                  |               | 11242.569 | 11736.112 | 13105.897 | 16282.896 |
| ShuffleBenchmark_SByte | Sum128Traits                    |       400.426 | 16767.896 | 16723.557 | 19729.703 | 19544.244 |
| ShuffleBenchmark_SByte | Sum256_Bcl                      |               |           |           |           |           |
| ShuffleBenchmark_SByte | Sum256_Avx2_Add1                |               |           |           |           |           |
| ShuffleBenchmark_SByte | Sum256_Avx2_Add2                |               |           |           |           |           |
| ShuffleBenchmark_SByte | Sum256_Avx2_Cmp2                |               |           |           |           |           |
| ShuffleBenchmark_SByte | Sum256_Avx2_EqualAnd            |               |           |           |           |           |
| ShuffleBenchmark_SByte | Sum256Traits                    |               |           |           |           |           |
| ShuffleBenchmark_SByte | Sum512_Bcl                      |               |           |           |           |   640.352 |
| ShuffleBenchmark_SByte | Sum512Traits                    |               |           |           |           |   640.432 |
| ShuffleBenchmark_SByte | SumKernelTraits                 |       672.784 | 15604.597 | 16732.629 | 19692.571 | 19533.892 |
| ShuffleBenchmark_SByte | SumKernelTraits_Args0           |       675.236 | 16718.959 | 15715.512 | 19729.144 | 19534.508 |
| ShuffleBenchmark_SByte | SumKernelTraits_Args            |       642.795 |  5573.999 |  5598.168 | 19588.655 | 19538.006 |
| ShuffleBenchmark_SByte | SumKernel128_AdvSimd            |               | 11748.196 | 11737.578 | 13131.709 | 16275.599 |
| ShuffleBenchmark_SByte | SumKernel128Traits              |       400.750 | 15719.108 | 16747.893 | 19744.815 | 19497.899 |
| ShuffleBenchmark_SByte | SumKernel256Traits              |               |           |           |           |           |
| ShuffleBenchmark_SByte | SumKernel256Traits_Args0        |               |           |           |           |           |
| ShuffleBenchmark_SByte | SumKernel256Traits_Args         |               |           |           |           |           |

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                   | Method                          | .NET 8.0 |
| :--------------------- | :------------------------------ | -------: |
| ShuffleBenchmark_Int16 | SumScalar                       |   19.744 |
| ShuffleBenchmark_Int16 | SumBase                         |   20.256 |
| ShuffleBenchmark_Int16 | SumTraits                       |   61.970 |
| ShuffleBenchmark_Int16 | SumTraits_Args0                 |   69.356 |
| ShuffleBenchmark_Int16 | SumTraits_Args                  |   70.149 |
| ShuffleBenchmark_Int16 | Sum128_Bcl                      |  115.599 |
| ShuffleBenchmark_Int16 | Sum128_AdvSimd                  |          |
| ShuffleBenchmark_Int16 | Sum128Traits                    |   67.732 |
| ShuffleBenchmark_Int16 | Sum256_Bcl                      |          |
| ShuffleBenchmark_Int16 | Sum256Traits                    |          |
| ShuffleBenchmark_Int16 | Sum512_Bcl                      |   14.532 |
| ShuffleBenchmark_Int16 | Sum512Traits                    |   13.004 |
| ShuffleBenchmark_Int16 | SumKernelTraits                 |   80.660 |
| ShuffleBenchmark_Int16 | SumKernelTraits_Args0           |   94.466 |
| ShuffleBenchmark_Int16 | SumKernelTraits_Args            |   76.913 |
| ShuffleBenchmark_Int16 | SumKernel128_AdvSimd            |          |
| ShuffleBenchmark_Int16 | SumKernel128Traits              |   95.497 |
| ShuffleBenchmark_Int16 | SumKernel256_Avx2_Multiply      |          |
| ShuffleBenchmark_Int16 | SumKernel256_Avx2_ShiftLane     |          |
| ShuffleBenchmark_Int16 | SumKernel256Traits              |          |
| ShuffleBenchmark_Int16 | SumKernel256Traits_Args0        |          |
| ShuffleBenchmark_Int16 | SumKernel256Traits_Args         |          |
| ShuffleBenchmark_Int32 | SumScalar                       |   14.994 |
| ShuffleBenchmark_Int32 | SumBase                         |   15.204 |
| ShuffleBenchmark_Int32 | SumTraits                       |   54.525 |
| ShuffleBenchmark_Int32 | SumTraits_Args0                 |   43.831 |
| ShuffleBenchmark_Int32 | SumTraits_Args                  |   34.977 |
| ShuffleBenchmark_Int32 | Sum128_Bcl                      |   69.596 |
| ShuffleBenchmark_Int32 | Sum128_AdvSimd                  |          |
| ShuffleBenchmark_Int32 | Sum128_Wasm_CompareGreater      |   32.736 |
| ShuffleBenchmark_Int32 | Sum128_Wasm_EqualsShift         |   30.780 |
| ShuffleBenchmark_Int32 | Sum128Traits                    |   66.975 |
| ShuffleBenchmark_Int32 | Sum256_Bcl                      |          |
| ShuffleBenchmark_Int32 | Sum256_Avx2_Add1                |          |
| ShuffleBenchmark_Int32 | Sum256Traits                    |          |
| ShuffleBenchmark_Int32 | Sum512_Bcl                      |   10.770 |
| ShuffleBenchmark_Int32 | Sum512Traits                    |    9.895 |
| ShuffleBenchmark_Int32 | SumKernelTraits                 |   54.959 |
| ShuffleBenchmark_Int32 | SumKernelTraits_Args0           |   41.181 |
| ShuffleBenchmark_Int32 | SumKernelTraits_Args            |   35.099 |
| ShuffleBenchmark_Int32 | SumKernel128_AdvSimd            |          |
| ShuffleBenchmark_Int32 | SumKernel128Traits              |   67.659 |
| ShuffleBenchmark_Int32 | SumKernel256Traits              |          |
| ShuffleBenchmark_Int32 | SumKernel256Traits_Args0        |          |
| ShuffleBenchmark_Int32 | SumKernel256Traits_Args         |          |
| ShuffleBenchmark_Int64 | SumScalar                       |    6.100 |
| ShuffleBenchmark_Int64 | SumBase                         |    6.105 |
| ShuffleBenchmark_Int64 | SumTraits                       |    6.167 |
| ShuffleBenchmark_Int64 | SumTraits_Args0                 |    8.013 |
| ShuffleBenchmark_Int64 | SumTraits_Args                  |    7.827 |
| ShuffleBenchmark_Int64 | Sum128_Bcl                      |    4.731 |
| ShuffleBenchmark_Int64 | Sum128_AdvSimd                  |          |
| ShuffleBenchmark_Int64 | Sum128Traits                    |   12.715 |
| ShuffleBenchmark_Int64 | Sum256_Bcl                      |          |
| ShuffleBenchmark_Int64 | Sum256Traits                    |          |
| ShuffleBenchmark_Int64 | Sum512_Bcl                      |    3.235 |
| ShuffleBenchmark_Int64 | Sum512Traits                    |    6.421 |
| ShuffleBenchmark_Int64 | SumKernelTraits                 |    7.582 |
| ShuffleBenchmark_Int64 | SumKernelTraits_Args0           |    8.713 |
| ShuffleBenchmark_Int64 | SumKernelTraits_Args            |    8.432 |
| ShuffleBenchmark_Int64 | SumKernel128_Sse_DuplicateEven  |          |
| ShuffleBenchmark_Int64 | SumKernel128_AdvSimd            |          |
| ShuffleBenchmark_Int64 | SumKernel128_Arm_Multiply       |          |
| ShuffleBenchmark_Int64 | SumKernel128Traits              |   18.353 |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_AlignRight    |          |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_DuplicateEven |          |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_Multiply      |          |
| ShuffleBenchmark_Int64 | SumKernel256_Avx2_ShiftLane     |          |
| ShuffleBenchmark_Int64 | SumKernel256Traits              |          |
| ShuffleBenchmark_Int64 | SumKernel256Traits_Args0        |          |
| ShuffleBenchmark_Int64 | SumKernel256Traits_Args         |          |
| ShuffleBenchmark_SByte | SumScalar                       |   25.764 |
| ShuffleBenchmark_SByte | SumBase                         |   26.280 |
| ShuffleBenchmark_SByte | SumTraits                       |  262.417 |
| ShuffleBenchmark_SByte | SumTraits_Args0                 |  198.939 |
| ShuffleBenchmark_SByte | SumTraits_Args                  |  154.569 |
| ShuffleBenchmark_SByte | Sum128_Bcl                      |  200.205 |
| ShuffleBenchmark_SByte | Sum128_AdvSimd                  |          |
| ShuffleBenchmark_SByte | Sum128Traits                    |  338.108 |
| ShuffleBenchmark_SByte | Sum256_Bcl                      |          |
| ShuffleBenchmark_SByte | Sum256_Avx2_Add1                |          |
| ShuffleBenchmark_SByte | Sum256_Avx2_Add2                |          |
| ShuffleBenchmark_SByte | Sum256_Avx2_Cmp2                |          |
| ShuffleBenchmark_SByte | Sum256_Avx2_EqualAnd            |          |
| ShuffleBenchmark_SByte | Sum256Traits                    |          |
| ShuffleBenchmark_SByte | Sum512_Bcl                      |   18.759 |
| ShuffleBenchmark_SByte | Sum512Traits                    |   17.766 |
| ShuffleBenchmark_SByte | SumKernelTraits                 |  255.913 |
| ShuffleBenchmark_SByte | SumKernelTraits_Args0           |  184.754 |
| ShuffleBenchmark_SByte | SumKernelTraits_Args            |  155.117 |
| ShuffleBenchmark_SByte | SumKernel128_AdvSimd            |          |
| ShuffleBenchmark_SByte | SumKernel128Traits              |  325.587 |
| ShuffleBenchmark_SByte | SumKernel256Traits              |          |
| ShuffleBenchmark_SByte | SumKernel256Traits_Args0        |          |
| ShuffleBenchmark_SByte | SumKernel256Traits_Args         |          |

