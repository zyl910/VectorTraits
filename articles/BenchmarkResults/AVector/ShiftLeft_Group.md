# Benchmark group - ShiftLeft
([← Back](ShiftLeft.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### X86 - AMD Ryzen 7 7840H
| Type                          | Method                    | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :---------------------------- | :------------------------ | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| ShiftLeftConstBenchmark_Byte  | SumSLLScalar              |       1062.046 |      1025.936 |      1287.865 |  1265.446 |  1445.575 |  1416.712 |  1693.330 |
| ShiftLeftConstBenchmark_Byte  | SumSLLNetBcl              |                |               |               |           |           |  1344.738 |  1109.752 |
| ShiftLeftConstBenchmark_Byte  | SumSLLNetBcl_Const        |                |               |               |           |           |  1281.901 |  1164.382 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Basic              |      11643.212 |     10935.887 |     20802.587 | 19234.592 | 22398.946 | 23804.552 | 22962.091 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Base_Core          |      61659.541 |     53936.655 |     60092.249 | 63482.532 | 60892.242 | 67119.054 | 60623.899 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Multiply           |      11492.106 |     10788.387 |     20636.926 | 18914.019 | 22565.945 | 24149.109 | 24424.065 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_AdvSimd            |                |               |               |           |           |           |           |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Avx2               |                |               |     28882.901 | 27914.288 | 28983.705 | 35680.087 | 61527.194 |
| ShiftLeftConstBenchmark_Byte  | SumSLLTraits              |      11312.499 |     10715.920 |     28897.868 | 28611.234 | 28219.205 | 34068.741 | 57456.802 |
| ShiftLeftConstBenchmark_Byte  | SumSLLTraits_Core         |      55791.675 |     52165.732 |     53563.421 | 68653.359 | 59916.622 | 67868.291 | 74889.177 |
| ShiftLeftConstBenchmark_Byte  | SumSLLConstTraits         |      13408.916 |     12604.412 |     38925.388 | 57842.081 | 57095.294 | 62012.692 | 62729.225 |
| ShiftLeftConstBenchmark_Byte  | SumSLLConstTraits_Core    |      56843.523 |     55673.528 |     53642.484 | 62674.397 | 65797.708 | 50869.840 | 73873.979 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128Bcl              |                |               |               |           |           |  1168.368 |   767.349 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128Traits           |                |               |     14253.557 | 15119.089 | 14260.672 | 17158.675 | 31932.668 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128Traits_Core      |                |               |     33281.936 | 35042.788 | 33953.751 | 36040.111 | 42693.321 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128ConstTraits      |                |               |     16773.704 | 32040.418 | 32204.083 | 33855.214 | 34750.445 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128ConstTraits_Core |                |               |     36556.781 | 33968.628 | 34448.128 | 27702.588 | 39021.286 |
| ShiftLeftConstBenchmark_Byte  | SumSLL512Bcl              |                |               |               |           |           |           |   447.174 |
| ShiftLeftConstBenchmark_Byte  | SumSLL512Traits           |                |               |               |           |           |           | 82740.101 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_Multiply       |      13636.349 |     11389.708 |     36098.264 | 36353.344 | 34446.871 | 46028.776 | 48779.211 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_AdvSimd        |                |               |               |           |           |           |           |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_Avx2           |                |               |     34694.531 | 49925.840 | 65149.040 | 66810.262 | 65701.450 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFastTraits          |      13705.365 |     11290.294 |     34692.453 | 52665.291 | 61758.429 | 65939.422 | 74725.136 |
| ShiftLeftConstBenchmark_Int16 | SumSLLScalar              |       1081.716 |       999.767 |      1261.475 |  1198.111 |  1218.767 |  1365.754 |  1547.294 |
| ShiftLeftConstBenchmark_Int16 | SumSLLNetBcl              |                |               |               |           |           | 32011.646 | 34816.284 |
| ShiftLeftConstBenchmark_Int16 | SumSLLNetBcl_Const        |                |               |               |           |           | 39975.924 | 37368.541 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Basic              |       6765.848 |      6505.171 |     15162.663 | 14783.440 | 20607.926 | 32990.518 | 35549.796 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core          |      36352.213 |     32968.237 |     36389.439 | 33892.853 | 31602.264 | 32634.035 | 36720.450 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core_Element  |       6787.555 |      5563.307 |     13961.345 | 13900.931 | 17106.875 | 20289.773 | 35297.465 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core_Mov      |       6083.717 |      6141.257 |     14614.455 | 13571.102 | 17710.273 | 25471.628 | 27509.884 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Multiply           |       6803.424 |      6090.190 |     15409.469 | 15339.138 | 21684.792 | 20584.670 | 24711.957 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_AdvSimd            |                |               |               |           |           |           |           |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Avx2               |                |               |     26340.325 | 26922.366 | 26522.365 | 26648.440 | 30733.138 |
| ShiftLeftConstBenchmark_Int16 | SumSLLTraits              |       6752.349 |      6185.968 |     25221.856 | 26382.708 | 27125.955 | 32617.944 | 36448.716 |
| ShiftLeftConstBenchmark_Int16 | SumSLLTraits_Core         |      34727.283 |     31457.238 |     31800.310 | 32231.553 | 35687.996 | 37750.305 | 30731.745 |
| ShiftLeftConstBenchmark_Int16 | SumSLLConstTraits         |       6037.367 |      6498.819 |     27783.526 | 37605.559 | 40699.914 | 39598.663 | 36242.630 |
| ShiftLeftConstBenchmark_Int16 | SumSLLConstTraits_Core    |      37678.435 |     34784.616 |     32625.543 | 33694.338 | 40019.325 | 39380.404 | 36914.775 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128Bcl              |                |               |               |           |           | 14755.543 | 20119.281 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128Traits           |                |               |     14409.004 | 13536.894 | 13105.486 | 14933.950 | 20190.435 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128Traits_Core      |                |               |     19173.703 | 19075.001 | 18118.050 | 18789.506 | 16201.324 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128ConstTraits      |                |               |     14215.906 | 19180.081 | 20871.504 | 20833.161 | 19870.013 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128ConstTraits_Core |                |               |     19570.311 | 18227.336 | 21267.812 | 20775.978 | 19894.652 |
| ShiftLeftConstBenchmark_Int16 | SumSLL512Bcl              |                |               |               |           |           |           | 42180.891 |
| ShiftLeftConstBenchmark_Int16 | SumSLL512Traits           |                |               |               |           |           |           | 44709.720 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_Multiply       |       6922.822 |      7453.352 |     23729.619 | 22539.659 | 27011.807 | 27206.311 | 25450.655 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_AdvSimd        |                |               |               |           |           |           |           |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_Avx2           |                |               |     28804.782 | 32919.215 | 31101.834 | 29758.444 | 35474.862 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFastTraits          |       7817.443 |      6570.141 |     26401.350 | 36259.989 | 32159.413 | 32659.908 | 37859.431 |
| ShiftLeftConstBenchmark_Int32 | SumSLLScalar              |       1369.140 |      1315.852 |      1514.690 |  1521.516 |  2284.670 |  2484.407 |  2409.358 |
| ShiftLeftConstBenchmark_Int32 | SumSLLNetBcl              |                |               |               |           |           | 17373.567 | 15954.004 |
| ShiftLeftConstBenchmark_Int32 | SumSLLNetBcl_Const        |                |               |               |           |           | 17967.080 | 15983.409 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Basic              |       3599.302 |      3458.059 |     10492.675 | 10162.788 | 10639.082 | 17891.042 | 16049.281 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Base_Core          |      15722.844 |     14487.864 |     15894.086 | 15332.775 | 15540.933 | 17346.608 | 16141.071 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Multiply           |       3728.371 |      3555.588 |     10645.983 | 10050.149 | 11075.058 | 11291.361 | 15847.461 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_AdvSimd            |                |               |               |           |           |           |           |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Avx2               |                |               |     12772.413 | 12531.146 | 12325.782 | 12733.163 | 12998.146 |
| ShiftLeftConstBenchmark_Int32 | SumSLLTraits              |       3762.374 |      3511.433 |     13343.304 | 12906.293 | 12661.423 | 17279.760 | 15886.410 |
| ShiftLeftConstBenchmark_Int32 | SumSLLTraits_Core         |      17324.275 |     15468.381 |     14587.937 | 17407.823 | 17886.651 | 18052.162 | 14126.571 |
| ShiftLeftConstBenchmark_Int32 | SumSLLConstTraits         |       3910.600 |      3724.412 |     12646.545 | 15290.340 | 17745.992 | 17829.078 | 15991.615 |
| ShiftLeftConstBenchmark_Int32 | SumSLLConstTraits_Core    |      16235.154 |     14216.598 |     15282.565 | 16088.400 | 17940.330 | 15961.166 | 16378.506 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128Bcl              |                |               |               |           |           |  9297.378 |  9670.786 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128Traits           |                |               |      6764.874 |  6783.710 |  6881.927 |  9183.644 |  9218.264 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128Traits_Core      |                |               |      9683.426 | 10398.315 | 10784.975 | 10177.435 |  9948.523 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128ConstTraits      |                |               |      7141.143 |  9172.565 | 10063.971 |  9363.116 |  9536.884 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128ConstTraits_Core |                |               |     10350.937 | 10238.704 |  9760.642 |  9248.793 | 10204.864 |
| ShiftLeftConstBenchmark_Int32 | SumSLL512Bcl              |                |               |               |           |           |           | 18654.603 |
| ShiftLeftConstBenchmark_Int32 | SumSLL512Traits           |                |               |               |           |           |           | 17465.537 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_Multiply       |       3972.527 |      3678.156 |     12863.521 | 12500.225 | 12126.683 | 13553.399 | 15983.924 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_AdvSimd        |                |               |               |           |           |           |           |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_Avx2           |                |               |     13655.177 | 17993.939 | 14186.433 | 13739.683 | 15974.107 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFastTraits          |       3936.720 |      3554.928 |     13048.871 | 15030.407 | 14220.520 | 17573.094 | 15983.099 |
| ShiftLeftConstBenchmark_Int64 | SumSLLScalar              |       1394.719 |      1281.156 |      1517.938 |  1441.160 |  2270.521 |  2508.577 |  2421.558 |
| ShiftLeftConstBenchmark_Int64 | SumSLLNetBcl              |                |               |               |           |           |  7528.184 |  8530.835 |
| ShiftLeftConstBenchmark_Int64 | SumSLLNetBcl_Const        |                |               |               |           |           |  8743.504 |  8471.981 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Base_Bit32_Or      |        222.502 |       271.371 |       221.367 |   282.164 |   233.093 |   241.626 |   197.532 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Basic              |        482.166 |       489.646 |       520.847 |   490.001 |   528.981 |  8152.561 |  8713.895 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Base_Core          |        480.004 |       485.033 |       524.166 |   504.302 |   526.853 |  7986.772 |  9052.444 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_AdvSimd            |                |               |               |           |           |           |           |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Avx2               |                |               |      6644.472 |  6700.057 |  6593.742 |  6545.775 |  7578.221 |
| ShiftLeftConstBenchmark_Int64 | SumSLLTraits              |        483.430 |       494.335 |      6677.544 |  6570.711 |  6635.070 |  6891.705 |  7469.236 |
| ShiftLeftConstBenchmark_Int64 | SumSLLTraits_Core         |        479.761 |       488.827 |      7758.515 |  8525.784 |  8596.290 |  8267.855 |  7879.060 |
| ShiftLeftConstBenchmark_Int64 | SumSLLConstTraits         |        509.585 |       525.195 |      7036.223 |  6787.101 |  8246.601 |  8254.880 |  8526.022 |
| ShiftLeftConstBenchmark_Int64 | SumSLLConstTraits_Core    |        512.652 |       528.381 |      8229.954 |  8747.125 |  8711.523 |  8871.948 |  8647.339 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128Bcl              |                |               |               |           |           |  3739.678 |  5024.195 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128Traits           |                |               |      3704.309 |  3673.118 |  3459.447 |  3533.757 |  4413.242 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128Traits_Core      |                |               |      4823.659 |  5546.637 |  5336.593 |  5501.204 |  5019.317 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128ConstTraits      |                |               |      3874.232 |  3806.896 |  5243.601 |  5539.339 |  5151.891 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128ConstTraits_Core |                |               |      4962.514 |  5475.031 |  4870.745 |  5258.458 |  5159.790 |
| ShiftLeftConstBenchmark_Int64 | SumSLL512Bcl              |                |               |               |           |           |           |  9543.093 |
| ShiftLeftConstBenchmark_Int64 | SumSLL512Traits           |                |               |               |           |           |           |  7988.092 |
| ShiftLeftConstBenchmark_Int64 | SumSLLFast_AdvSimd        |                |               |               |           |           |           |           |
| ShiftLeftConstBenchmark_Int64 | SumSLLFast_Avx2           |                |               |      7654.225 |  7392.454 |  7735.632 |  7296.283 |  8648.740 |
| ShiftLeftConstBenchmark_Int64 | SumSLLFastTraits          |        514.953 |       522.423 |      6742.773 |  7778.500 |  7479.740 |  7345.949 |  8677.244 |

### X86 - Intel Core i5-8250U
| Type                          | Method                    | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :---------------------------- | :------------------------ | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| ShiftLeftConstBenchmark_Byte  | SumSLLScalar              |        859.830 |       859.678 |      1120.378 |  1127.346 |  1359.361 |  1549.840 |
| ShiftLeftConstBenchmark_Byte  | SumSLLNetBcl              |                |               |               |           |           |  1178.786 |
| ShiftLeftConstBenchmark_Byte  | SumSLLNetBcl_Const        |                |               |               |           |           |  1177.339 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Basic              |       8915.278 |      8948.021 |     15906.723 | 15322.318 | 16445.602 | 20032.835 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Base_Core          |      39706.505 |     34547.354 |     45658.298 | 40123.498 | 40044.314 | 39771.177 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Multiply           |       8879.961 |      8862.589 |     15951.707 | 15255.982 | 16459.778 | 20072.958 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_AdvSimd            |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Avx2               |                |               |     22421.910 | 22273.765 | 22329.276 | 25274.859 |
| ShiftLeftConstBenchmark_Byte  | SumSLLTraits              |       8898.294 |      8918.435 |     22496.421 | 19942.064 | 22275.738 | 25662.171 |
| ShiftLeftConstBenchmark_Byte  | SumSLLTraits_Core         |      35443.918 |     39670.570 |     42201.168 | 32582.667 | 38778.852 | 38750.734 |
| ShiftLeftConstBenchmark_Byte  | SumSLLConstTraits         |      11399.508 |     11394.920 |     26732.458 | 30573.583 | 40803.174 | 38665.512 |
| ShiftLeftConstBenchmark_Byte  | SumSLLConstTraits_Core    |      39686.234 |     35187.799 |     42237.347 | 33994.636 | 37957.676 | 41641.236 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128Traits           |                |               |     10716.849 |  9420.328 | 11324.426 | 13322.526 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128Traits_Core      |                |               |     23050.798 | 21066.098 | 23010.720 | 21112.009 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128ConstTraits      |                |               |     13391.678 | 22217.394 | 23430.138 | 21055.801 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128ConstTraits_Core |                |               |     22572.982 | 23027.578 | 23027.809 | 21080.812 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_Multiply       |      11744.320 |     11722.099 |     26791.041 | 26735.628 | 26799.087 | 35535.744 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_AdvSimd        |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_Avx2           |                |               |     26841.018 | 35053.310 | 37805.004 | 37856.876 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFastTraits          |      11612.495 |     11706.056 |     26739.956 | 34949.253 | 37713.378 | 38986.866 |
| ShiftLeftConstBenchmark_Int16 | SumSLLScalar              |        841.494 |       843.096 |      1193.064 |  1190.046 |  1358.824 |  1553.763 |
| ShiftLeftConstBenchmark_Int16 | SumSLLNetBcl              |                |               |               |           |           | 20899.194 |
| ShiftLeftConstBenchmark_Int16 | SumSLLNetBcl_Const        |                |               |               |           |           | 23392.777 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Basic              |       5397.386 |      5632.457 |     12242.743 | 12324.011 | 13996.667 | 19300.915 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core          |      23288.822 |     22603.626 |     21818.346 | 23074.695 | 23534.517 | 19649.150 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core_Element  |       5275.958 |      5157.314 |     11354.740 | 11523.799 | 12690.810 | 16740.485 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core_Mov      |       5139.615 |      5067.630 |     11250.575 | 11060.124 | 12060.375 | 17597.569 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Multiply           |       5577.054 |      5630.545 |     12296.786 |  9862.494 | 13521.671 | 15305.111 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_AdvSimd            |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Avx2               |                |               |     18106.898 | 17519.480 | 17577.641 | 18104.001 |
| ShiftLeftConstBenchmark_Int16 | SumSLLTraits              |       5457.114 |      5642.180 |     18094.357 | 17511.952 | 17413.467 | 18827.412 |
| ShiftLeftConstBenchmark_Int16 | SumSLLTraits_Core         |      21924.622 |     22574.392 |     19955.908 | 15314.070 | 20651.910 | 18450.119 |
| ShiftLeftConstBenchmark_Int16 | SumSLLConstTraits         |       6162.425 |      6370.666 |     18610.286 | 19546.284 | 21780.182 | 20487.319 |
| ShiftLeftConstBenchmark_Int16 | SumSLLConstTraits_Core    |      21686.822 |     21746.218 |     22470.309 | 20086.968 | 22313.920 | 21803.300 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128Traits           |                |               |     10336.762 | 10320.694 | 10299.377 | 11985.678 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128Traits_Core      |                |               |     11657.662 | 11676.835 | 11658.723 | 12435.207 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128ConstTraits      |                |               |     10337.941 | 11656.995 | 12129.890 | 13057.907 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128ConstTraits_Core |                |               |     11703.474 | 11655.909 | 12496.018 | 12959.630 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_Multiply       |       6186.912 |      6421.950 |     16343.287 | 17032.182 | 19837.415 | 19843.004 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_AdvSimd        |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_Avx2           |                |               |     20115.209 | 21976.277 | 20266.778 | 19900.086 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFastTraits          |       6184.293 |      6309.359 |     20019.329 | 20676.579 | 19810.254 | 19366.831 |
| ShiftLeftConstBenchmark_Int32 | SumSLLScalar              |        841.328 |       840.669 |      1351.033 |  1352.504 |  2210.995 |  1682.320 |
| ShiftLeftConstBenchmark_Int32 | SumSLLNetBcl              |                |               |               |           |           | 11099.770 |
| ShiftLeftConstBenchmark_Int32 | SumSLLNetBcl_Const        |                |               |               |           |           | 11446.173 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Basic              |       2802.717 |      2949.499 |      6410.821 |  5993.531 |  6501.187 | 10747.854 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Base_Core          |       9080.301 |      8804.870 |      9779.287 |  8924.169 |  9231.653 | 10730.875 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Multiply           |       2824.083 |      2953.408 |      6506.876 |  6318.309 |  6420.457 |  7552.381 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_AdvSimd            |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Avx2               |                |               |      8867.412 |  8815.073 |  8769.006 |  9277.081 |
| ShiftLeftConstBenchmark_Int32 | SumSLLTraits              |       2818.536 |      2945.223 |      9067.419 |  8441.793 |  8834.515 | 10023.542 |
| ShiftLeftConstBenchmark_Int32 | SumSLLTraits_Core         |       9136.424 |      9683.714 |     11035.304 | 10064.362 | 10604.724 | 11690.595 |
| ShiftLeftConstBenchmark_Int32 | SumSLLConstTraits         |       3109.161 |      3268.712 |      8866.244 | 10270.765 | 11240.672 | 11281.663 |
| ShiftLeftConstBenchmark_Int32 | SumSLLConstTraits_Core    |       9207.823 |      9766.888 |     11309.484 | 11415.397 | 10749.271 | 11540.250 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128Traits           |                |               |      5223.277 |  4641.201 |  5158.228 |  6237.418 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128Traits_Core      |                |               |      6134.347 |  6101.042 |  6347.901 |  6482.377 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128ConstTraits      |                |               |      5185.557 |  5853.219 |  6110.895 |  6542.770 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128ConstTraits_Core |                |               |      6092.871 |  6798.737 |  6115.839 |  6565.355 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_Multiply       |       3123.269 |      3260.600 |      8700.854 |  8723.159 |  8663.119 |  9280.389 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_AdvSimd        |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_Avx2           |                |               |     10031.817 | 10384.981 |  9428.490 | 10272.998 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFastTraits          |       3179.152 |      3303.057 |     10036.247 | 10369.038 |  9458.591 | 10606.724 |
| ShiftLeftConstBenchmark_Int64 | SumSLLScalar              |        832.495 |       829.698 |      1351.115 |  1346.235 |  2161.948 |  2667.438 |
| ShiftLeftConstBenchmark_Int64 | SumSLLNetBcl              |                |               |               |           |           |  4179.660 |
| ShiftLeftConstBenchmark_Int64 | SumSLLNetBcl_Const        |                |               |               |           |           |  5648.203 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Basic              |        451.744 |       450.420 |       488.809 |   471.229 |   473.561 |  4905.683 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Base_Core          |        458.161 |       472.021 |       489.188 |   466.079 |   473.242 |  4900.543 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_AdvSimd            |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Avx2               |                |               |      4497.519 |  4448.556 |  4574.409 |  4363.729 |
| ShiftLeftConstBenchmark_Int64 | SumSLLTraits              |        450.909 |       471.976 |      4542.925 |  4437.420 |  4604.258 |  3709.782 |
| ShiftLeftConstBenchmark_Int64 | SumSLLTraits_Core         |        434.814 |       470.974 |      5996.036 |  5631.227 |  5844.559 |  2816.698 |
| ShiftLeftConstBenchmark_Int64 | SumSLLConstTraits         |        500.901 |       549.041 |      4674.201 |  4359.205 |  5645.399 |  4971.800 |
| ShiftLeftConstBenchmark_Int64 | SumSLLConstTraits_Core    |        501.781 |       548.865 |      5860.712 |  5494.338 |  5589.806 |  5111.673 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128Traits           |                |               |      2588.404 |  2576.063 |  2585.887 |  2654.271 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128Traits_Core      |                |               |      3064.588 |  3060.060 |  3228.360 |  3475.323 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128ConstTraits      |                |               |      2595.091 |  2598.921 |  3132.408 |  3405.429 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128ConstTraits_Core |                |               |      3332.640 |  3061.618 |  3064.909 |  3433.879 |
| ShiftLeftConstBenchmark_Int64 | SumSLLFast_AdvSimd        |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Int64 | SumSLLFast_Avx2           |                |               |      5030.382 |  4821.201 |  5083.835 |  5111.590 |
| ShiftLeftConstBenchmark_Int64 | SumSLLFastTraits          |        486.050 |       503.722 |      5025.083 |  4791.775 |  5136.548 |  4938.225 |

### Arm - Apple M2
| Type                          | Method                    |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :---------------------------- | :------------------------ | --------: | --------: | --------: |
| ShiftLeftConstBenchmark_Byte  | SumSLLScalar              |  1688.231 |  1689.165 |  1166.373 |
| ShiftLeftConstBenchmark_Byte  | SumSLLNetBcl              |           | 27237.699 | 27253.238 |
| ShiftLeftConstBenchmark_Byte  | SumSLLNetBcl_Const        |           | 27243.512 | 27249.895 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Basic              | 18901.178 | 27252.520 | 27259.289 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Base_Core          | 27221.359 | 27237.691 | 27240.305 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Multiply           | 18897.768 | 19749.609 | 21725.341 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_AdvSimd            | 27175.824 | 27198.086 | 27256.068 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Avx2               |           |           |           |
| ShiftLeftConstBenchmark_Byte  | SumSLLTraits              | 27184.587 | 27217.983 | 27252.160 |
| ShiftLeftConstBenchmark_Byte  | SumSLLTraits_Core         | 27240.666 | 27240.347 | 27254.168 |
| ShiftLeftConstBenchmark_Byte  | SumSLLConstTraits         | 27241.149 | 27241.587 | 27245.221 |
| ShiftLeftConstBenchmark_Byte  | SumSLLConstTraits_Core    | 27241.876 | 27240.780 | 27249.910 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128Bcl              |           | 27241.126 | 27247.598 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128Traits           | 27184.170 | 27209.408 | 27247.548 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128Traits_Core      | 27240.864 | 27232.292 | 27247.463 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128ConstTraits      | 27240.422 | 27240.127 | 27252.220 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128ConstTraits_Core | 27240.335 | 27233.101 | 27248.729 |
| ShiftLeftConstBenchmark_Byte  | SumSLL512Bcl              |           |           | 90386.486 |
| ShiftLeftConstBenchmark_Byte  | SumSLL512Traits           |           |           |  4456.934 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_Multiply       | 25702.235 | 24653.160 | 24650.665 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_AdvSimd        | 27247.673 | 27242.911 | 27241.269 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_Avx2           |           |           |           |
| ShiftLeftConstBenchmark_Byte  | SumSLLFastTraits          | 27246.655 | 27247.468 | 27249.451 |
| ShiftLeftConstBenchmark_Int16 | SumSLLScalar              |  1658.809 |  1689.899 |  1165.925 |
| ShiftLeftConstBenchmark_Int16 | SumSLLNetBcl              |           | 13614.663 | 13617.976 |
| ShiftLeftConstBenchmark_Int16 | SumSLLNetBcl_Const        |           | 13613.385 | 13616.897 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Basic              | 12349.530 | 13615.715 | 13619.809 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core          | 13611.179 | 13615.091 | 13617.953 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core_Element  | 12165.333 | 13600.977 | 13615.624 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core_Mov      | 12555.202 | 13603.835 | 13616.692 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Multiply           | 12793.459 | 12558.754 | 10628.608 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_AdvSimd            | 13597.321 | 13607.185 | 13617.101 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Avx2               |           |           |           |
| ShiftLeftConstBenchmark_Int16 | SumSLLTraits              | 13596.599 | 13618.347 | 13617.537 |
| ShiftLeftConstBenchmark_Int16 | SumSLLTraits_Core         | 13613.120 | 13613.621 | 13616.340 |
| ShiftLeftConstBenchmark_Int16 | SumSLLConstTraits         | 13611.591 | 13616.950 | 13618.971 |
| ShiftLeftConstBenchmark_Int16 | SumSLLConstTraits_Core    | 13612.573 | 13616.534 | 13616.619 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128Bcl              |           | 13613.995 | 13615.357 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128Traits           | 13598.921 | 13614.299 | 13617.414 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128Traits_Core      | 13609.691 | 13614.109 | 13614.045 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128ConstTraits      | 13612.036 | 13613.107 | 13619.332 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128ConstTraits_Core | 13611.995 | 13611.681 | 13616.528 |
| ShiftLeftConstBenchmark_Int16 | SumSLL512Bcl              |           |           | 44809.608 |
| ShiftLeftConstBenchmark_Int16 | SumSLL512Traits           |           |           | 44813.444 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_Multiply       | 10689.058 | 10620.588 | 10630.970 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_AdvSimd        | 13613.692 | 13589.167 | 13619.603 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_Avx2           |           |           |           |
| ShiftLeftConstBenchmark_Int16 | SumSLLFastTraits          | 13611.346 | 13613.556 | 13615.887 |
| ShiftLeftConstBenchmark_Int32 | SumSLLScalar              |  1731.062 |  1699.630 |  1747.343 |
| ShiftLeftConstBenchmark_Int32 | SumSLLNetBcl              |           |  6804.164 |  6805.684 |
| ShiftLeftConstBenchmark_Int32 | SumSLLNetBcl_Const        |           |  6805.172 |  6805.794 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Basic              |  6278.852 |  6804.876 |  6804.985 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Base_Core          |  6803.687 |  6804.154 |  6804.953 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Multiply           |  6278.723 |  5369.521 |  6804.036 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_AdvSimd            |  6800.960 |  6802.457 |  6804.606 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Avx2               |           |           |           |
| ShiftLeftConstBenchmark_Int32 | SumSLLTraits              |  6800.779 |  6804.972 |  6805.165 |
| ShiftLeftConstBenchmark_Int32 | SumSLLTraits_Core         |  6804.758 |  6804.165 |  6804.415 |
| ShiftLeftConstBenchmark_Int32 | SumSLLConstTraits         |  6805.519 |  6803.802 |  6806.445 |
| ShiftLeftConstBenchmark_Int32 | SumSLLConstTraits_Core    |  6804.417 |  6804.833 |  6805.442 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128Bcl              |           |  6804.390 |  6805.043 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128Traits           |  6801.872 |  6804.641 |  6805.888 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128Traits_Core      |  6803.333 |  6799.075 |  6802.870 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128ConstTraits      |  6802.219 |  6804.217 |  6806.212 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128ConstTraits_Core |  6805.085 |  6804.062 |  6806.040 |
| ShiftLeftConstBenchmark_Int32 | SumSLL512Bcl              |           |           | 22314.396 |
| ShiftLeftConstBenchmark_Int32 | SumSLL512Traits           |           |           | 22314.578 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_Multiply       |  5346.523 |  5320.840 |  6806.113 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_AdvSimd        |  6804.395 |  6804.243 |  6805.422 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_Avx2           |           |           |           |
| ShiftLeftConstBenchmark_Int32 | SumSLLFastTraits          |  6802.743 |  6804.541 |  6806.607 |
| ShiftLeftConstBenchmark_Int64 | SumSLLScalar              |  1730.925 |  1699.409 |  1747.852 |
| ShiftLeftConstBenchmark_Int64 | SumSLLNetBcl              |           |  3401.673 |  3402.085 |
| ShiftLeftConstBenchmark_Int64 | SumSLLNetBcl_Const        |           |  3402.036 |  3402.074 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Base_Bit32_Or      |   209.063 |   208.743 |   201.385 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Basic              |  1643.546 |  3401.854 |  3402.005 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Base_Core          |  1643.952 |  3401.725 |  3401.178 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_AdvSimd            |  3400.333 |  3400.687 |  3401.900 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Avx2               |           |           |           |
| ShiftLeftConstBenchmark_Int64 | SumSLLTraits              |  3400.057 |  3401.590 |  3402.183 |
| ShiftLeftConstBenchmark_Int64 | SumSLLTraits_Core         |  3401.244 |  3401.727 |  3402.077 |
| ShiftLeftConstBenchmark_Int64 | SumSLLConstTraits         |  3398.249 |  3401.783 |  3402.561 |
| ShiftLeftConstBenchmark_Int64 | SumSLLConstTraits_Core    |  3401.108 |  3402.158 |  3402.367 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128Bcl              |           |  3401.823 |  3401.833 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128Traits           |  3400.836 |  3400.980 |  3402.330 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128Traits_Core      |  3402.006 |  3402.203 |  3402.294 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128ConstTraits      |  3402.099 |  3401.355 |  3402.722 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128ConstTraits_Core |  3400.738 |  3401.922 |  3402.710 |
| ShiftLeftConstBenchmark_Int64 | SumSLL512Bcl              |           |           | 11445.604 |
| ShiftLeftConstBenchmark_Int64 | SumSLL512Traits           |           |           | 11445.085 |
| ShiftLeftConstBenchmark_Int64 | SumSLLFast_AdvSimd        |  3401.517 |  3401.850 |  3401.580 |
| ShiftLeftConstBenchmark_Int64 | SumSLLFast_Avx2           |           |           |           |
| ShiftLeftConstBenchmark_Int64 | SumSLLFastTraits          |  3401.472 |  3402.150 |  3402.240 |

### Arm - AWS Arm t4g.small
| Type                          | Method                    | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :---------------------------- | :------------------------ | ------------: | --------: | --------: | --------: | --------: |
| ShiftLeftConstBenchmark_Byte  | SumSLLScalar              |       606.721 |   607.751 |   674.256 |   890.878 |  1238.814 |
| ShiftLeftConstBenchmark_Byte  | SumSLLNetBcl              |               |           |           | 19585.982 | 19831.927 |
| ShiftLeftConstBenchmark_Byte  | SumSLLNetBcl_Const        |               |           |           | 19564.840 | 19840.232 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Basic              |      5570.622 |  5611.377 |  7018.347 | 19594.158 | 19830.407 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Base_Core          |     14062.887 | 15584.590 | 13202.074 | 19566.417 | 19838.696 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Multiply           |      5593.564 |  5649.748 |  7028.464 |  7363.076 |  8258.815 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_AdvSimd            |               | 13133.580 | 13131.945 | 13192.312 | 19836.238 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Avx2               |               |           |           |           |           |
| ShiftLeftConstBenchmark_Byte  | SumSLLTraits              |      5541.532 | 13075.259 | 13190.705 | 13209.927 | 19844.497 |
| ShiftLeftConstBenchmark_Byte  | SumSLLTraits_Core         |     14048.511 | 16947.485 | 15828.571 | 19589.430 | 19841.525 |
| ShiftLeftConstBenchmark_Byte  | SumSLLConstTraits         |      9734.870 | 15699.315 | 15853.772 | 19511.952 | 19811.385 |
| ShiftLeftConstBenchmark_Byte  | SumSLLConstTraits_Core    |     13007.028 | 16817.247 | 15838.060 | 19422.222 | 19839.627 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128Bcl              |               |           |           | 19574.043 | 19841.249 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128Traits           |       454.778 | 13157.734 | 13197.554 | 13220.412 | 19840.557 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128Traits_Core      |       457.380 | 15822.924 | 16962.586 | 19540.117 | 19837.148 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128ConstTraits      |       456.235 |  2824.766 | 15845.140 | 19404.397 | 19834.953 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128ConstTraits_Core |       456.141 | 15774.847 | 15846.332 | 19386.420 | 19838.220 |
| ShiftLeftConstBenchmark_Byte  | SumSLL512Bcl              |               |           |           |           | 31468.871 |
| ShiftLeftConstBenchmark_Byte  | SumSLL512Traits           |               |           |           |           |  1509.391 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_Multiply       |      9801.615 |  9899.588 | 11080.190 | 11645.587 | 13349.204 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_AdvSimd        |               | 15847.023 | 16952.835 | 19579.305 | 19826.870 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_Avx2           |               |           |           |           |           |
| ShiftLeftConstBenchmark_Byte  | SumSLLFastTraits          |      9728.967 | 15802.753 | 16977.225 | 19578.163 | 19842.620 |
| ShiftLeftConstBenchmark_Int16 | SumSLLScalar              |       606.135 |   603.800 |   605.734 |   820.880 |  1031.035 |
| ShiftLeftConstBenchmark_Int16 | SumSLLNetBcl              |               |           |           |  9943.220 |  9803.495 |
| ShiftLeftConstBenchmark_Int16 | SumSLLNetBcl_Const        |               |           |           |  9937.639 |  9837.136 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Basic              |      4236.284 |  4260.518 |  5633.260 |  9937.324 |  9780.171 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core          |      8372.081 |  7699.910 |  8374.542 |  9923.975 |  9839.122 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core_Element  |      3944.193 |  4220.859 |  4938.791 |  7225.731 |  9840.302 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core_Mov      |      4211.816 |  4203.040 |  4905.882 |  7934.539 |  9727.086 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Multiply           |      4249.780 |  4185.086 |  5630.237 |  6127.369 |  7224.942 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_AdvSimd            |               |  6447.476 |  6531.434 |  6627.195 |  9839.411 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Avx2               |               |           |           |           |           |
| ShiftLeftConstBenchmark_Int16 | SumSLLTraits              |      4215.369 |  6547.514 |  6558.299 |  9923.088 |  9839.256 |
| ShiftLeftConstBenchmark_Int16 | SumSLLTraits_Core         |      7918.688 |  8431.934 |  7892.235 |  9939.469 |  9839.496 |
| ShiftLeftConstBenchmark_Int16 | SumSLLConstTraits         |      6568.606 |  7829.860 |  7887.842 |  9925.988 |  9839.534 |
| ShiftLeftConstBenchmark_Int16 | SumSLLConstTraits_Core    |      8494.550 |  8416.796 |  7902.444 |  9914.384 |  9823.608 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128Bcl              |               |           |           |  9920.339 |  9835.933 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128Traits           |       297.384 |  6557.387 |  6556.492 |  9932.539 |  9836.177 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128Traits_Core      |       297.725 |  7786.080 |  8421.653 |  9921.453 |  9838.227 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128ConstTraits      |       290.543 |  1519.782 |  7887.605 |  9921.070 |  9838.173 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128ConstTraits_Core |       289.078 |  7808.976 |  8422.226 |  9935.154 |  9840.651 |
| ShiftLeftConstBenchmark_Int16 | SumSLL512Bcl              |               |           |           |           | 13384.764 |
| ShiftLeftConstBenchmark_Int16 | SumSLL512Traits           |               |           |           |           | 13367.250 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_Multiply       |      5624.401 |  5528.278 |  6532.043 |  6644.048 |  7239.370 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_AdvSimd        |               |  7670.144 |  8437.625 |  9923.961 |  9794.698 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_Avx2           |               |           |           |           |           |
| ShiftLeftConstBenchmark_Int16 | SumSLLFastTraits          |      4920.261 |  7865.272 |  8435.776 |  9931.347 |  9841.420 |
| ShiftLeftConstBenchmark_Int32 | SumSLLScalar              |       747.656 |   746.013 |   749.108 |  1406.122 |  1410.137 |
| ShiftLeftConstBenchmark_Int32 | SumSLLNetBcl              |               |           |           |  4926.651 |  4826.909 |
| ShiftLeftConstBenchmark_Int32 | SumSLLNetBcl_Const        |               |           |           |  4917.732 |  4840.232 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Basic              |      3281.623 |  3258.960 |  3011.718 |  4916.699 |  4815.201 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Base_Core          |      3958.956 |  3880.564 |  3914.821 |  4916.630 |  4846.376 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Multiply           |      3274.096 |  3218.008 |  3012.705 |  3298.347 |  4827.633 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_AdvSimd            |               |  3517.415 |  3536.378 |  3947.296 |  4852.835 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Avx2               |               |           |           |           |           |
| ShiftLeftConstBenchmark_Int32 | SumSLLTraits              |      3293.943 |  3269.129 |  3278.303 |  4925.488 |  4836.941 |
| ShiftLeftConstBenchmark_Int32 | SumSLLTraits_Core         |      4210.811 |  3930.619 |  3927.408 |  4923.867 |  4844.083 |
| ShiftLeftConstBenchmark_Int32 | SumSLLConstTraits         |      3275.986 |  3249.809 |  3923.176 |  4926.463 |  4846.238 |
| ShiftLeftConstBenchmark_Int32 | SumSLLConstTraits_Core    |      4205.245 |  4199.155 |  4156.634 |  4925.448 |  4844.679 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128Bcl              |               |           |           |  4936.472 |  4849.893 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128Traits           |       187.113 |  3234.651 |  3289.965 |  4929.956 |  4857.887 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128Traits_Core      |       187.174 |  4132.178 |  4189.265 |  4929.916 |  4820.379 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128ConstTraits      |       187.064 |   752.187 |  3927.452 |  4924.095 |  4845.226 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128ConstTraits_Core |       186.637 |  3860.770 |  4180.061 |  4918.693 |  4842.765 |
| ShiftLeftConstBenchmark_Int32 | SumSLL512Bcl              |               |           |           |           |  6592.187 |
| ShiftLeftConstBenchmark_Int32 | SumSLL512Traits           |               |           |           |           |  6600.591 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_Multiply       |      3592.733 |  3261.724 |  3225.201 |  3455.984 |  4816.487 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_AdvSimd        |               |  3240.731 |  4192.794 |  4931.705 |  4796.438 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_Avx2           |               |           |           |           |           |
| ShiftLeftConstBenchmark_Int32 | SumSLLFastTraits          |      3297.770 |  3243.806 |  4185.307 |  4925.466 |  4850.347 |
| ShiftLeftConstBenchmark_Int64 | SumSLLScalar              |       739.137 |   729.158 |   741.673 |  1372.480 |  1296.655 |
| ShiftLeftConstBenchmark_Int64 | SumSLLNetBcl              |               |           |           |  2477.025 |  2264.032 |
| ShiftLeftConstBenchmark_Int64 | SumSLLNetBcl_Const        |               |           |           |  2473.102 |  2251.272 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Base_Bit32_Or      |        65.591 |    61.604 |    68.923 |    70.158 |    53.894 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Basic              |       475.089 |   470.077 |   480.503 |  2463.089 |  2281.435 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Base_Core          |       483.807 |   481.610 |   481.543 |  2455.096 |  2273.635 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_AdvSimd            |               |  1614.477 |  1623.486 |  1986.161 |  2317.512 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Avx2               |               |           |           |           |           |
| ShiftLeftConstBenchmark_Int64 | SumSLLTraits              |       486.734 |  1638.835 |  1636.233 |  1985.596 |  2285.512 |
| ShiftLeftConstBenchmark_Int64 | SumSLLTraits_Core         |       489.554 |  2075.273 |  1967.902 |  2474.105 |  2289.521 |
| ShiftLeftConstBenchmark_Int64 | SumSLLConstTraits         |       467.393 |  1930.821 |  1968.798 |  2471.124 |  2308.745 |
| ShiftLeftConstBenchmark_Int64 | SumSLLConstTraits_Core    |       466.293 |  2074.656 |  1968.834 |  2476.602 |  2281.018 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128Bcl              |               |           |           |  2467.015 |  2269.166 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128Traits           |       266.890 |  1613.521 |  1635.615 |  1984.107 |  2273.440 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128Traits_Core      |       271.309 |  1963.012 |  2101.205 |  2474.609 |  2268.904 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128ConstTraits      |       272.007 |   350.374 |  2102.802 |  2475.859 |  2269.156 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128ConstTraits_Core |       267.578 |  1968.925 |  2097.371 |  2480.319 |  2321.117 |
| ShiftLeftConstBenchmark_Int64 | SumSLL512Bcl              |               |           |           |           |  3152.584 |
| ShiftLeftConstBenchmark_Int64 | SumSLL512Traits           |               |           |           |           |  3196.645 |
| ShiftLeftConstBenchmark_Int64 | SumSLLFast_AdvSimd        |               |  1930.066 |  1971.025 |  2477.170 |  2286.322 |
| ShiftLeftConstBenchmark_Int64 | SumSLLFast_Avx2           |               |           |           |           |           |
| ShiftLeftConstBenchmark_Int64 | SumSLLFastTraits          |       466.943 |  1651.380 |  2100.868 |  2473.770 |  2271.258 |

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                          | Method                    | .NET 8.0 |
| :---------------------------- | :------------------------ | -------: |
| ShiftLeftConstBenchmark_Byte  | SumSLLScalar              |   34.755 |
| ShiftLeftConstBenchmark_Byte  | SumSLLNetBcl              |  331.566 |
| ShiftLeftConstBenchmark_Byte  | SumSLLNetBcl_Const        |  317.876 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Basic              |  325.114 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Base_Core          |  335.237 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Multiply           |   22.042 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_AdvSimd            |          |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Avx2               |          |
| ShiftLeftConstBenchmark_Byte  | SumSLLTraits              |  262.366 |
| ShiftLeftConstBenchmark_Byte  | SumSLLTraits_Core         |  249.475 |
| ShiftLeftConstBenchmark_Byte  | SumSLLConstTraits         |  240.620 |
| ShiftLeftConstBenchmark_Byte  | SumSLLConstTraits_Core    |  254.908 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128Bcl              |  329.611 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128Traits           |  335.265 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128Traits_Core      |  325.140 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128ConstTraits      |  318.756 |
| ShiftLeftConstBenchmark_Byte  | SumSLL128ConstTraits_Core |  312.813 |
| ShiftLeftConstBenchmark_Byte  | SumSLL512Bcl              |   64.835 |
| ShiftLeftConstBenchmark_Byte  | SumSLL512Traits           |   46.129 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_Multiply       |   22.816 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_AdvSimd        |          |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_Avx2           |          |
| ShiftLeftConstBenchmark_Byte  | SumSLLFastTraits          |  254.715 |
| ShiftLeftConstBenchmark_Int16 | SumSLLScalar              |   33.802 |
| ShiftLeftConstBenchmark_Int16 | SumSLLNetBcl              |  168.545 |
| ShiftLeftConstBenchmark_Int16 | SumSLLNetBcl_Const        |  160.612 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Basic              |  163.097 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core          |  171.766 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core_Element  |  108.614 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core_Mov      |  104.618 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Multiply           |   19.028 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_AdvSimd            |          |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Avx2               |          |
| ShiftLeftConstBenchmark_Int16 | SumSLLTraits              |  122.402 |
| ShiftLeftConstBenchmark_Int16 | SumSLLTraits_Core         |  127.116 |
| ShiftLeftConstBenchmark_Int16 | SumSLLConstTraits         |  122.016 |
| ShiftLeftConstBenchmark_Int16 | SumSLLConstTraits_Core    |  121.898 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128Bcl              |  165.933 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128Traits           |  168.545 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128Traits_Core      |  168.615 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128ConstTraits      |  155.453 |
| ShiftLeftConstBenchmark_Int16 | SumSLL128ConstTraits_Core |  156.007 |
| ShiftLeftConstBenchmark_Int16 | SumSLL512Bcl              |   31.426 |
| ShiftLeftConstBenchmark_Int16 | SumSLL512Traits           |   32.854 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_Multiply       |   19.441 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_AdvSimd        |          |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_Avx2           |          |
| ShiftLeftConstBenchmark_Int16 | SumSLLFastTraits          |  126.956 |
| ShiftLeftConstBenchmark_Int32 | SumSLLScalar              |   48.550 |
| ShiftLeftConstBenchmark_Int32 | SumSLLNetBcl              |   83.928 |
| ShiftLeftConstBenchmark_Int32 | SumSLLNetBcl_Const        |   78.742 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Basic              |   89.209 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Base_Core          |   83.241 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Multiply           |   16.217 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_AdvSimd            |          |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Avx2               |          |
| ShiftLeftConstBenchmark_Int32 | SumSLLTraits              |   63.446 |
| ShiftLeftConstBenchmark_Int32 | SumSLLTraits_Core         |   63.776 |
| ShiftLeftConstBenchmark_Int32 | SumSLLConstTraits         |   61.825 |
| ShiftLeftConstBenchmark_Int32 | SumSLLConstTraits_Core    |   62.031 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128Bcl              |   84.019 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128Traits           |   83.865 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128Traits_Core      |   81.667 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128ConstTraits      |   81.449 |
| ShiftLeftConstBenchmark_Int32 | SumSLL128ConstTraits_Core |   79.063 |
| ShiftLeftConstBenchmark_Int32 | SumSLL512Bcl              |   15.910 |
| ShiftLeftConstBenchmark_Int32 | SumSLL512Traits           |   16.831 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_Multiply       |   17.092 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_AdvSimd        |          |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_Avx2           |          |
| ShiftLeftConstBenchmark_Int32 | SumSLLFastTraits          |   69.789 |
| ShiftLeftConstBenchmark_Int64 | SumSLLScalar              |   44.058 |
| ShiftLeftConstBenchmark_Int64 | SumSLLNetBcl              |   10.972 |
| ShiftLeftConstBenchmark_Int64 | SumSLLNetBcl_Const        |   10.506 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Base_Bit32_Or      |    0.221 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Basic              |   10.490 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Base_Core          |   10.387 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_AdvSimd            |          |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Avx2               |          |
| ShiftLeftConstBenchmark_Int64 | SumSLLTraits              |   20.645 |
| ShiftLeftConstBenchmark_Int64 | SumSLLTraits_Core         |   20.784 |
| ShiftLeftConstBenchmark_Int64 | SumSLLConstTraits         |   20.829 |
| ShiftLeftConstBenchmark_Int64 | SumSLLConstTraits_Core    |   19.954 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128Bcl              |    4.801 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128Traits           |   42.363 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128Traits_Core      |   42.723 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128ConstTraits      |   39.288 |
| ShiftLeftConstBenchmark_Int64 | SumSLL128ConstTraits_Core |   38.968 |
| ShiftLeftConstBenchmark_Int64 | SumSLL512Bcl              |    3.338 |
| ShiftLeftConstBenchmark_Int64 | SumSLL512Traits           |    7.056 |
| ShiftLeftConstBenchmark_Int64 | SumSLLFast_AdvSimd        |          |
| ShiftLeftConstBenchmark_Int64 | SumSLLFast_Avx2           |          |
| ShiftLeftConstBenchmark_Int64 | SumSLLFastTraits          |    9.854 |

