# Benchmark group - YShuffleX2Kernel
([← Back](YShuffleX2Kernel.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### X86 - AMD Ryzen 7 7840H
| Type                            | Method                   | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :------------------------------ | :----------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| YShuffleX2KernelBenchmark_Byte  | SumBase_Basic            |        437.764 |       932.229 |       754.754 |  1038.699 |   838.356 |   922.290 |  1210.576 |
| YShuffleX2KernelBenchmark_Byte  | SumBase                  |        455.466 |       914.020 |       733.665 |   982.323 |   882.996 |   938.388 |  1156.079 |
| YShuffleX2KernelBenchmark_Byte  | SumTraits                |        445.239 |       893.377 |     14716.765 | 19398.153 | 15483.478 | 22637.671 | 85801.689 |
| YShuffleX2KernelBenchmark_Byte  | SumTraits_Args           |        432.850 |       928.958 |     23409.254 | 31647.408 | 25694.483 | 31562.486 | 85652.816 |
| YShuffleX2KernelBenchmark_Byte  | SumTraits_ArgsT          |        387.075 |       749.471 |     20467.204 | 25815.254 | 17676.259 | 25840.086 | 86561.324 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Base_Basic         |                |               |       422.296 |   493.837 |   407.676 |   792.887 |   967.923 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Base               |                |               |       393.109 |   494.816 |   427.748 |   788.803 |   960.553 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Arm                |                |               |               |           |           |           |           |
| YShuffleX2KernelBenchmark_Byte  | Sum128Arm_Combine        |                |               |               |           |           |           |           |
| YShuffleX2KernelBenchmark_Byte  | Sum128Sse_Combine        |                |               |      3102.921 |  4031.601 |  3033.978 | 28783.712 | 28637.430 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Traits             |                |               |      2956.933 |  4065.216 |  3081.849 | 28644.417 | 44899.345 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Traits_ArgsT       |                |               |     22862.399 | 24783.543 | 24242.842 | 24684.169 | 45278.962 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Base_Basic         |                |               |       515.710 |   654.273 |   634.380 |   978.076 |  1208.427 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Base               |                |               |       496.476 |   664.853 |   654.910 |   935.735 |  1232.710 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Avx2_Combine       |                |               |     15799.427 | 22879.273 | 23474.400 | 29011.467 | 28548.036 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Avx2_Combine2      |                |               |     15417.327 | 24839.617 | 26434.347 | 24755.345 | 24940.775 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Avx2_Combine3      |                |               |     15845.495 | 23650.219 | 23900.675 | 29197.047 | 28391.682 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Traits             |                |               |     16163.131 | 23833.790 | 23810.139 | 29141.518 | 84571.884 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Traits_ArgsT       |                |               |     24250.747 | 26188.554 | 32490.237 | 25915.029 | 86126.900 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Base_Basic         |                |               |               |           |           |           |  1127.781 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Base               |                |               |               |           |           |           |   640.000 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Traits             |                |               |               |           |           |           | 98496.263 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Traits_ArgsT       |                |               |               |           |           |           | 99137.727 |
| YShuffleX2KernelBenchmark_Int16 | SumBase_Basic            |        363.829 |       673.975 |       595.689 |   756.806 |   716.147 |   701.324 |   908.077 |
| YShuffleX2KernelBenchmark_Int16 | SumBase                  |        353.936 |       667.867 |       579.039 |   750.934 |   741.587 |   719.168 |   910.661 |
| YShuffleX2KernelBenchmark_Int16 | SumTraits                |        360.497 |       656.557 |      5624.724 |  7696.747 |  7737.676 |  9499.569 | 44071.653 |
| YShuffleX2KernelBenchmark_Int16 | SumTraits_Args           |        364.461 |       678.705 |     11429.442 | 15758.136 | 15806.872 | 15892.924 | 43764.227 |
| YShuffleX2KernelBenchmark_Int16 | SumTraits_ArgsT          |        297.947 |       487.484 |      8717.033 | 12032.744 | 11340.032 | 12198.972 | 44237.037 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Base_Basic         |                |               |       253.720 |   305.978 |   307.009 |   462.500 |   579.905 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Base               |                |               |       263.072 |   307.581 |   306.852 |   464.547 |   582.399 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Arm                |                |               |               |           |           |           |           |
| YShuffleX2KernelBenchmark_Int16 | Sum128Arm_Combine        |                |               |               |           |           |           |           |
| YShuffleX2KernelBenchmark_Int16 | Sum128Sse_Combine        |                |               |      1510.170 |  2034.690 |  1994.888 | 13245.838 | 13227.341 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Traits             |                |               |      1493.880 |  2033.051 |  2038.445 |  3797.610 | 21184.440 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Traits_ArgsT       |                |               |     11433.724 | 12238.060 | 15441.369 | 12826.403 | 21030.205 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Base_Basic         |                |               |       394.499 |   421.901 |   395.593 |   731.737 |   834.452 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Base               |                |               |       399.027 |   423.460 |   416.206 |   716.052 |   883.655 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Avx2_Combine       |                |               |      7569.761 |  9549.850 |  9708.774 | 13628.918 | 12616.944 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Traits             |                |               |      7752.098 |  9730.901 |  9688.723 | 13621.357 | 43721.347 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Traits_ArgsT       |                |               |     13027.007 | 15282.765 | 13062.334 | 13307.122 | 43260.394 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Base_Basic         |                |               |               |           |           |           |   887.631 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Base               |                |               |               |           |           |           |   642.325 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Traits             |                |               |               |           |           |           | 48887.402 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Traits_ArgsT       |                |               |               |           |           |           | 48359.538 |
| YShuffleX2KernelBenchmark_Int32 | SumBase_Basic            |        250.989 |       408.704 |       438.393 |   437.978 |   454.897 |   421.138 |   528.911 |
| YShuffleX2KernelBenchmark_Int32 | SumBase                  |        248.645 |       410.349 |       418.988 |   426.423 |   457.015 |   427.620 |   531.394 |
| YShuffleX2KernelBenchmark_Int32 | SumTraits                |        246.049 |       409.834 |      8771.406 |  9512.904 |  8468.849 |  8686.811 | 19809.089 |
| YShuffleX2KernelBenchmark_Int32 | SumTraits_Args           |        249.313 |       409.885 |     10152.246 | 12988.574 | 12684.792 | 13843.236 | 20005.683 |
| YShuffleX2KernelBenchmark_Int32 | SumTraits_ArgsT          |        200.650 |       266.298 |      5645.567 |  6403.451 |  5776.688 |  6882.427 | 19993.213 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Base_Basic         |                |               |       172.745 |   178.601 |   177.221 |   269.711 |   330.095 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Base               |                |               |       164.931 |   170.079 |   175.797 |   269.215 |   327.432 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Arm                |                |               |               |           |           |           |           |
| YShuffleX2KernelBenchmark_Int32 | Sum128Arm_Combine        |                |               |               |           |           |           |           |
| YShuffleX2KernelBenchmark_Int32 | Sum128Sse_Combine        |                |               |       822.551 |  1008.873 |  1011.989 |  6609.034 |  6615.926 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Traits             |                |               |      1016.236 |   999.203 |   951.724 |  9844.145 | 10494.491 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Traits_ArgsT       |                |               |      7287.323 |  8544.346 |  6627.096 |  6649.883 | 10492.131 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Base_Basic         |                |               |       258.992 |   287.545 |   288.919 |   423.990 |   509.443 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Base               |                |               |       274.607 |   284.436 |   289.899 |   385.536 |   507.079 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Avx2_Combine       |                |               |      9949.338 | 12813.406 | 13351.664 | 13647.825 | 12155.865 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Traits             |                |               |     10164.929 | 12595.278 | 12982.057 | 13449.146 | 20164.939 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Traits_ArgsT       |                |               |      7704.071 |  7603.464 |  7642.323 |  8366.744 | 20116.161 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Base_Basic         |                |               |               |           |           |           |   533.961 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Base               |                |               |               |           |           |           |   603.405 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Traits             |                |               |               |           |           |           | 21405.561 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Traits_ArgsT       |                |               |               |           |           |           | 22111.354 |
| YShuffleX2KernelBenchmark_Int64 | SumBase_Basic            |        151.157 |       214.992 |       213.412 |   229.445 |   241.118 |   228.174 |   275.012 |
| YShuffleX2KernelBenchmark_Int64 | SumBase                  |        153.141 |       207.048 |       223.400 |   223.244 |   238.463 |   234.716 |   273.483 |
| YShuffleX2KernelBenchmark_Int64 | SumTraits                |        152.653 |       216.600 |      3107.817 |  3957.076 |  3761.273 |  4244.272 | 10595.995 |
| YShuffleX2KernelBenchmark_Int64 | SumTraits_Args           |        149.973 |       220.471 |      5098.152 |  7009.781 |  6440.420 |  7046.298 | 10672.797 |
| YShuffleX2KernelBenchmark_Int64 | SumTraits_ArgsT          |        115.706 |       145.644 |      2824.836 |  3241.780 |  2904.341 |  3189.246 | 10549.249 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Base_Basic         |                |               |        90.319 |    91.923 |    92.307 |   134.416 |   170.031 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Base               |                |               |        86.852 |    91.465 |    93.074 |   134.271 |   169.616 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Arm                |                |               |               |           |           |           |           |
| YShuffleX2KernelBenchmark_Int64 | Sum128Arm_Combine        |                |               |               |           |           |           |           |
| YShuffleX2KernelBenchmark_Int64 | Sum128Sse_Combine        |                |               |       418.783 |   503.180 |   470.103 |  2762.942 |  3270.350 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Traits             |                |               |       499.687 |   466.059 |   503.171 |  3846.191 |  5239.396 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Traits_ArgsT       |                |               |      3798.443 |  4399.439 |  3334.982 |  3340.888 |  5230.885 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Base_Basic         |                |               |       152.533 |   151.900 |   155.347 |   231.196 |   273.487 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Base               |                |               |       154.577 |   151.504 |   158.618 |   239.712 |   272.705 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Avx2_Combine       |                |               |      3597.723 |  4460.416 |  4477.569 |  5409.545 |  6273.596 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Traits             |                |               |      3546.295 |  4518.667 |  4483.932 |  5454.794 | 10612.252 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Traits_ArgsT       |                |               |      3646.659 |  3918.691 |  3878.620 |  3860.173 | 10681.157 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Base_Basic         |                |               |               |           |           |           |   290.205 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Base               |                |               |               |           |           |           |   408.489 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Traits             |                |               |               |           |           |           | 10776.324 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Traits_ArgsT       |                |               |               |           |           |           | 10864.041 |
| YShuffleX3KernelBenchmark_Byte  | SumBase_Basic            |        407.366 |       885.346 |       852.495 |   855.707 |   973.585 |   941.762 |  1169.489 |
| YShuffleX3KernelBenchmark_Byte  | SumBase                  |        374.173 |       895.608 |       850.065 |   945.142 |   985.088 |   937.465 |  1190.803 |
| YShuffleX3KernelBenchmark_Byte  | SumTraits                |        412.810 |       863.578 |      9893.734 | 12240.911 | 11810.300 | 14410.843 | 53241.449 |
| YShuffleX3KernelBenchmark_Byte  | SumTraits_Args           |        413.953 |       892.748 |     10444.691 | 15417.632 | 15280.296 | 18161.259 | 53150.449 |
| YShuffleX3KernelBenchmark_Byte  | SumTraits_ArgsT          |        401.552 |       738.846 |     12890.839 | 13377.535 | 11990.102 | 14967.012 | 53550.693 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Base_Basic         |                |               |       456.097 |   488.235 |   496.369 |   765.237 |   897.569 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Base               |                |               |       471.939 |   393.899 |   494.868 |   748.653 |   937.072 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Arm                |                |               |               |           |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | Sum128Arm_Combine        |                |               |               |           |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | Sum128Sse_Combine        |                |               |      2173.546 |  2308.289 |  2221.610 | 17646.752 | 17016.828 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Sse_Permute        |                |               |               |           |           |           | 27683.729 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Sse_PermuteLonger  |                |               |               |           |           |           | 42240.165 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Traits             |                |               |      2176.800 |  2303.568 |  2214.632 |  7583.704 | 43348.647 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Traits_ArgsT       |                |               |     19431.728 | 21016.728 | 22439.577 | 22316.944 | 42470.241 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Base_Basic         |                |               |       533.530 |   616.198 |   646.598 |   927.508 |  1153.972 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Base               |                |               |       484.408 |   618.101 |   633.887 |   927.649 |  1165.069 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Avx2_Combine       |                |               |      8538.974 | 10725.899 | 15399.055 | 16896.386 | 18145.835 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Avx2_Permute       |                |               |               |           |           |           | 51562.377 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Avx2_PermuteLonger |                |               |               |           |           |           | 52329.585 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Traits             |                |               |      8858.066 | 10793.883 | 15248.536 | 17163.630 | 52935.691 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Traits_ArgsT       |                |               |     11911.216 | 15816.606 | 16676.098 | 18203.501 | 52774.191 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Base_Basic         |                |               |               |           |           |           |  1054.970 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Base               |                |               |               |           |           |           |   391.291 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Traits             |                |               |               |           |           |           | 55727.845 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Traits_ArgsT       |                |               |               |           |           |           | 72050.793 |
| YShuffleX3KernelBenchmark_Int16 | SumBase_Basic            |        190.291 |       619.572 |       538.688 |   680.571 |   677.171 |   680.058 |   884.919 |
| YShuffleX3KernelBenchmark_Int16 | SumBase                  |        206.979 |       615.481 |       533.659 |   671.140 |   682.115 |   693.057 |   878.681 |
| YShuffleX3KernelBenchmark_Int16 | SumTraits                |        346.330 |       615.061 |      3611.046 |  5619.709 |  5488.822 |  6383.018 | 26867.180 |
| YShuffleX3KernelBenchmark_Int16 | SumTraits_Args           |        354.728 |       632.016 |      4585.738 |  7749.762 |  7658.604 |  9132.323 | 26794.113 |
| YShuffleX3KernelBenchmark_Int16 | SumTraits_ArgsT          |        301.956 |       465.695 |      6088.998 |  6938.202 |  6389.111 |  7545.264 | 26597.609 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Base_Basic         |                |               |       265.444 |   299.296 |   299.359 |   461.270 |   572.860 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Base               |                |               |       280.463 |   301.747 |   299.391 |   459.075 |   570.675 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Arm                |                |               |               |           |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | Sum128Arm_Combine        |                |               |               |           |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | Sum128Sse_Combine        |                |               |      1064.277 |  1134.507 |  1064.602 |  3332.601 |  8635.843 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Sse_Permute        |                |               |               |           |           |           | 13411.856 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Sse_PermuteLonger  |                |               |               |           |           |           | 20807.112 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Traits             |                |               |      1134.831 |  1135.805 |  1103.787 |  2030.089 | 21432.634 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Traits_ArgsT       |                |               |      9632.418 | 10433.567 | 11123.284 | 11229.654 | 21511.833 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Base_Basic         |                |               |       391.521 |   400.054 |   412.666 |   683.066 |   883.748 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Base               |                |               |       389.320 |   402.004 |   409.342 |   697.957 |   882.135 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Avx2_Combine       |                |               |      4018.474 |  4874.776 |  6334.176 |  8475.714 |  8391.430 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Avx2_Permute       |                |               |               |           |           |           | 24407.474 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Avx2_PermuteLonger |                |               |               |           |           |           | 26326.994 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Traits             |                |               |      4176.362 |  4862.179 |  6383.030 |  8434.052 | 26416.623 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Traits_ArgsT       |                |               |      6879.985 |  8060.088 |  8284.685 |  9176.130 | 26578.020 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Base_Basic         |                |               |               |           |           |           |   851.054 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Base               |                |               |               |           |           |           |   410.174 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Traits             |                |               |               |           |           |           | 26225.800 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Traits_ArgsT       |                |               |               |           |           |           | 35471.542 |
| YShuffleX3KernelBenchmark_Int32 | SumBase_Basic            |        230.683 |       358.065 |       385.291 |   391.222 |   418.981 |   384.597 |   481.131 |
| YShuffleX3KernelBenchmark_Int32 | SumBase                  |        234.881 |       363.620 |       371.575 |   377.892 |   416.601 |   407.908 |   485.292 |
| YShuffleX3KernelBenchmark_Int32 | SumTraits                |        229.257 |       359.575 |      5905.805 |  5993.031 |  6508.677 |  6113.687 | 13139.245 |
| YShuffleX3KernelBenchmark_Int32 | SumTraits_Args           |        238.607 |       363.875 |      6734.047 |  6461.829 |  8581.262 |  8648.063 | 13023.074 |
| YShuffleX3KernelBenchmark_Int32 | SumTraits_ArgsT          |        185.356 |       258.625 |      4331.591 |  4574.165 |  6105.054 |  5727.476 | 13157.848 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Base_Basic         |                |               |       159.317 |   167.872 |   171.257 |   254.958 |   314.838 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Base               |                |               |       161.892 |   170.092 |   170.640 |   253.805 |   314.827 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Arm                |                |               |               |           |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum128Arm_Combine        |                |               |               |           |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_Combine        |                |               |       543.806 |   572.160 |   550.832 |  1645.112 |  4252.954 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_CombineAvx     |                |               |       842.446 |   873.780 |   877.011 |  5182.403 |  5920.605 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_Permute        |                |               |               |           |           |           |  6370.431 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_PermuteLonger  |                |               |               |           |           |           | 10414.638 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Traits             |                |               |       838.684 |   877.062 |   880.476 |  4328.260 | 10572.574 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Traits_ArgsT       |                |               |      4699.513 |  5265.919 |  5538.220 |  5244.849 | 10439.912 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Base_Basic         |                |               |       263.173 |   262.938 |   274.691 |   381.810 |   488.751 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Base               |                |               |       266.170 |   266.508 |   276.085 |   409.694 |   485.757 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Avx2_Combine       |                |               |      7064.368 |  9376.564 |  9447.017 |  9352.990 |  8119.007 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Avx2_Permute       |                |               |               |           |           |           | 11839.314 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Avx2_PermuteLonger |                |               |               |           |           |           | 13243.740 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Traits             |                |               |      7209.742 |  9315.340 |  9429.956 |  9446.798 | 13179.138 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Traits_ArgsT       |                |               |      6115.803 |  6498.468 |  8252.412 |  8252.131 | 13048.541 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Base_Basic         |                |               |               |           |           |           |   501.014 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Base               |                |               |               |           |           |           |   394.524 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Traits             |                |               |               |           |           |           | 13114.343 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Traits_ArgsT       |                |               |               |           |           |           | 16982.002 |
| YShuffleX3KernelBenchmark_Int64 | SumBase_Basic            |        137.792 |       188.843 |       201.068 |   202.571 |   216.612 |   192.890 |   254.347 |
| YShuffleX3KernelBenchmark_Int64 | SumBase                  |        136.078 |       188.605 |       202.589 |   196.283 |   217.874 |   212.318 |   254.980 |
| YShuffleX3KernelBenchmark_Int64 | SumTraits                |        134.950 |       184.913 |      2350.659 |  2418.841 |  2849.784 |  2947.943 |  6691.506 |
| YShuffleX3KernelBenchmark_Int64 | SumTraits_Args           |        127.145 |       190.576 |      3437.036 |  3264.111 |  4116.587 |  4333.990 |  6639.938 |
| YShuffleX3KernelBenchmark_Int64 | SumTraits_ArgsT          |        108.156 |       137.182 |      2381.594 |  1957.307 |  3045.165 |  3035.012 |  6640.773 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Base_Basic         |                |               |        84.058 |    76.054 |    88.969 |   131.606 |   159.490 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Base               |                |               |        85.552 |    75.990 |    88.885 |   131.367 |   160.367 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Arm                |                |               |               |           |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum128Arm_Combine        |                |               |               |           |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_Combine        |                |               |       273.358 |   225.564 |   276.598 |   826.499 |  2119.532 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_CombineAvx     |                |               |       389.738 |   334.310 |   436.768 |  2408.277 |  2738.300 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_Permute        |                |               |               |           |           |           |  3252.403 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_PermuteLonger  |                |               |               |           |           |           |  5358.797 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Traits             |                |               |       382.615 |   332.697 |   440.233 |   936.608 |  5253.230 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Traits_ArgsT       |                |               |      2260.586 |  2260.003 |  2798.141 |  2789.415 |  5267.329 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Base_Basic         |                |               |       125.229 |   116.649 |   147.517 |   192.494 |   257.388 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Base               |                |               |       127.145 |   121.916 |   148.108 |   215.621 |   257.864 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Avx2_Combine       |                |               |      2495.537 |  2734.892 |  3219.231 |  3746.227 |  4288.361 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Avx2_Permute       |                |               |               |           |           |           |  6082.162 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Avx2_PermuteLonger |                |               |               |           |           |           |  6561.028 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Traits             |                |               |      2776.613 |  2986.087 |  3228.856 |  3258.955 |  6633.518 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Traits_ArgsT       |                |               |      3065.394 |  3191.893 |  4143.877 |  4157.548 |  6621.031 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Base_Basic         |                |               |               |           |           |           |   250.032 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Base               |                |               |               |           |           |           |   271.892 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Traits             |                |               |               |           |           |           |  6920.347 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Traits_ArgsT       |                |               |               |           |           |           |  8744.421 |
| YShuffleX4KernelBenchmark_Byte  | SumBase_Basic            |        362.434 |       840.452 |       818.859 |   798.566 |   872.318 |   835.975 |  1114.486 |
| YShuffleX4KernelBenchmark_Byte  | SumBase                  |        373.222 |       843.480 |       797.009 |   859.790 |   810.449 |   868.034 |  1075.764 |
| YShuffleX4KernelBenchmark_Byte  | SumTraits                |        381.253 |       841.962 |      7487.316 |  9184.786 |  9397.016 | 10475.246 | 52144.394 |
| YShuffleX4KernelBenchmark_Byte  | SumTraits_Args           |        369.768 |       839.675 |      8844.270 | 10418.698 | 10402.608 | 10417.370 | 53020.987 |
| YShuffleX4KernelBenchmark_Byte  | SumTraits_ArgsT          |        355.711 |       706.130 |      9318.054 |  8683.719 |  9312.972 | 10705.403 | 52107.975 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Base_Basic         |                |               |       440.036 |   476.467 |   480.443 |   704.335 |   921.499 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Base               |                |               |       453.435 |   478.434 |   471.199 |   704.265 |   928.152 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Arm                |                |               |               |           |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | Sum128Arm_Combine        |                |               |               |           |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | Sum128Sse_Combine        |                |               |      1904.252 |  2029.735 |  1967.630 |  6614.431 | 13480.784 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Sse_Permute        |                |               |               |           |           |           | 26056.172 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Sse_PermuteLonger  |                |               |               |           |           |           | 41792.373 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Traits             |                |               |      1907.761 |  2030.765 |  1976.945 |  4037.268 | 41170.181 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Traits_ArgsT       |                |               |     14335.157 | 16975.265 | 17113.483 | 16887.537 | 42789.011 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Base_Basic         |                |               |       598.917 |   618.815 |   614.934 |   899.889 |  1131.129 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Base               |                |               |       573.697 |   616.099 |   634.234 |   912.830 |  1146.629 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Avx2_Combine       |                |               |      7388.378 | 10316.889 | 11081.182 | 12309.309 | 12828.651 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Avx2_Permute       |                |               |               |           |           |           | 49740.974 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Avx2_PermuteLonger |                |               |               |           |           |           | 52774.278 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Traits             |                |               |      7050.076 | 10339.960 | 11158.947 | 12181.121 | 51946.824 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Traits_ArgsT       |                |               |     10326.801 | 10491.869 | 10977.235 | 10221.412 | 51687.263 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Base_Basic         |                |               |               |           |           |           |  1043.801 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Base               |                |               |               |           |           |           |   339.780 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Traits             |                |               |               |           |           |           | 52752.002 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Traits_ArgsT       |                |               |               |           |           |           | 65815.184 |
| YShuffleX4KernelBenchmark_Int16 | SumBase_Basic            |        316.616 |       500.178 |       512.570 |   635.675 |   619.130 |   616.299 |   824.854 |
| YShuffleX4KernelBenchmark_Int16 | SumBase                  |        325.030 |       568.614 |       533.458 |   616.793 |   559.383 |   626.845 |   811.918 |
| YShuffleX4KernelBenchmark_Int16 | SumTraits                |        324.308 |       563.634 |      2729.321 |  4202.035 |  3038.610 |  4639.551 | 26355.726 |
| YShuffleX4KernelBenchmark_Int16 | SumTraits_Args           |        323.134 |       566.888 |      3819.708 |  5290.086 |  5208.956 |  5240.213 | 26260.398 |
| YShuffleX4KernelBenchmark_Int16 | SumTraits_ArgsT          |        287.981 |       442.318 |      4103.610 |  4512.739 |  4611.022 |  5356.835 | 26741.524 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Base_Basic         |                |               |       260.853 |   269.807 |   274.186 |   416.576 |   550.230 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Base               |                |               |       229.574 |   271.497 |   271.662 |   418.631 |   557.395 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Arm                |                |               |               |           |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | Sum128Arm_Combine        |                |               |               |           |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | Sum128Sse_Combine        |                |               |       902.722 |  1015.959 |   976.570 |  2045.308 |  6586.319 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Sse_Permute        |                |               |               |           |           |           | 12762.358 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Sse_PermuteLonger  |                |               |               |           |           |           | 21100.057 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Traits             |                |               |       882.688 |  1021.672 |   985.390 |  2047.115 | 21267.663 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Traits_ArgsT       |                |               |      7268.219 |  8456.922 |  8465.371 |  8443.334 | 21622.526 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Base_Basic         |                |               |       376.741 |   380.539 |   391.552 |   640.809 |   803.538 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Base               |                |               |       390.206 |   388.567 |   389.748 |   640.636 |   826.875 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Avx2_Combine       |                |               |      3361.288 |  4061.585 |  4672.767 |  6013.913 |  6331.938 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Avx2_Permute       |                |               |               |           |           |           | 24129.952 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Avx2_PermuteLonger |                |               |               |           |           |           | 26655.111 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Traits             |                |               |      3261.445 |  4053.771 |  4709.471 |  5965.583 | 26276.300 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Traits_ArgsT       |                |               |      5262.650 |  4732.280 |  5553.242 |  5198.018 | 26208.537 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Base_Basic         |                |               |               |           |           |           |   803.922 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Base               |                |               |               |           |           |           |   319.389 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Traits             |                |               |               |           |           |           | 25719.843 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Traits_ArgsT       |                |               |               |           |           |           | 33830.769 |

### Arm - Apple M2
| Type                            | Method                   |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :------------------------------ | :----------------------- | --------: | --------: | --------: |
| YShuffleX2KernelBenchmark_Byte  | SumBase_Basic            |  1016.045 |  1137.722 |  1554.534 |
| YShuffleX2KernelBenchmark_Byte  | SumBase                  |  1010.411 |  1139.702 |  1554.743 |
| YShuffleX2KernelBenchmark_Byte  | SumTraits                | 24102.186 | 27108.536 | 28010.444 |
| YShuffleX2KernelBenchmark_Byte  | SumTraits_Args           | 27076.410 | 27159.331 | 28006.377 |
| YShuffleX2KernelBenchmark_Byte  | SumTraits_ArgsT          | 14389.214 | 27082.986 | 27979.540 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Base_Basic         |   803.167 |  1152.296 |  1553.086 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Base               |   823.340 |  1153.913 |  1552.391 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Arm                | 18601.222 | 19569.599 | 27189.427 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Arm_Combine        |           |           | 21646.983 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Sse_Combine        |           |           |           |
| YShuffleX2KernelBenchmark_Byte  | Sum128Traits             | 27949.433 | 27176.295 | 27227.238 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Traits_ArgsT       | 17353.659 | 27146.071 | 27219.635 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Base_Basic         |   843.823 |   792.560 |  1605.530 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Base               |   825.137 |   792.242 |  1605.997 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Avx2_Combine       |           |           |           |
| YShuffleX2KernelBenchmark_Byte  | Sum256Avx2_Combine2      |           |           |           |
| YShuffleX2KernelBenchmark_Byte  | Sum256Avx2_Combine3      |           |           |           |
| YShuffleX2KernelBenchmark_Byte  | Sum256Traits             |   817.542 |   792.696 |  1606.063 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Traits_ArgsT       |   784.992 |   779.740 |  1605.973 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Base_Basic         |           |           |  1514.468 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Base               |           |           |  1516.784 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Traits             |           |           |  1515.924 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Traits_ArgsT       |           |           |           |
| YShuffleX2KernelBenchmark_Int16 | SumBase_Basic            |   679.331 |   844.144 |  1149.885 |
| YShuffleX2KernelBenchmark_Int16 | SumBase                  |   680.509 |   847.021 |  1175.954 |
| YShuffleX2KernelBenchmark_Int16 | SumTraits                | 10351.092 | 12075.752 | 13611.996 |
| YShuffleX2KernelBenchmark_Int16 | SumTraits_Args           | 13541.706 | 13589.929 | 13612.277 |
| YShuffleX2KernelBenchmark_Int16 | SumTraits_ArgsT          |  7196.310 | 13526.606 | 13613.914 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Base_Basic         |   568.630 |   858.545 |  1154.927 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Base               |   569.500 |   859.011 |  1151.299 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Arm                |  8278.361 |  7939.105 | 13591.940 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Arm_Combine        |           |           |  9181.500 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Sse_Combine        |           |           |           |
| YShuffleX2KernelBenchmark_Int16 | Sum128Traits             | 13592.745 | 13565.518 | 13977.417 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Traits_ArgsT       |  8677.574 | 13588.290 | 13996.218 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Base_Basic         |   555.280 |   641.813 |  1520.439 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Base               |   556.056 |   641.788 |  1521.315 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Avx2_Combine       |           |           |           |
| YShuffleX2KernelBenchmark_Int16 | Sum256Traits             |   554.737 |   641.046 |  1518.930 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Traits_ArgsT       |   510.654 |   611.674 |  1520.511 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Base_Basic         |           |           |  1367.990 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Base               |           |           |  1365.921 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Traits             |           |           |  1367.596 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Traits_ArgsT       |           |           |           |
| YShuffleX2KernelBenchmark_Int32 | SumBase_Basic            |   373.491 |   432.244 |  1221.878 |
| YShuffleX2KernelBenchmark_Int32 | SumBase                  |   372.840 |   431.892 |  1221.991 |
| YShuffleX2KernelBenchmark_Int32 | SumTraits                |  5177.910 |  6041.150 |  6993.893 |
| YShuffleX2KernelBenchmark_Int32 | SumTraits_Args           |  6793.377 |  6797.089 |  6993.277 |
| YShuffleX2KernelBenchmark_Int32 | SumTraits_ArgsT          |  3618.298 |  5619.363 |  6995.503 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Base_Basic         |   295.384 |   430.069 |  1222.199 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Base               |   294.691 |   449.929 |  1222.341 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Arm                |  4140.705 |  3970.990 |  6790.129 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Arm_Combine        |           |           |  4600.405 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Sse_Combine        |           |           |           |
| YShuffleX2KernelBenchmark_Int32 | Sum128Traits             |  6793.644 |  6797.958 |  6877.249 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Traits_ArgsT       |  4346.238 |  6783.959 |  6802.923 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Base_Basic         |   371.001 |   440.025 |  1298.882 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Base               |   370.174 |   441.828 |  1298.008 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Avx2_Combine       |           |           |           |
| YShuffleX2KernelBenchmark_Int32 | Sum256Traits             |   370.415 |   441.772 |  1298.412 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Traits_ArgsT       |   325.494 |   407.108 |  1300.845 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Base_Basic         |           |           |  1142.996 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Base               |           |           |  1139.972 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Traits             |           |           |  1140.768 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Traits_ArgsT       |           |           |           |
| YShuffleX2KernelBenchmark_Int64 | SumBase_Basic            |   194.743 |   222.556 |   787.741 |
| YShuffleX2KernelBenchmark_Int64 | SumBase                  |   194.373 |   222.340 |   787.815 |
| YShuffleX2KernelBenchmark_Int64 | SumTraits                |  2472.321 |  2861.790 |  3401.159 |
| YShuffleX2KernelBenchmark_Int64 | SumTraits_Args           |  3399.029 |  3394.974 |  3401.215 |
| YShuffleX2KernelBenchmark_Int64 | SumTraits_ArgsT          |  1805.187 |  2987.223 |  3401.020 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Base_Basic         |   158.235 |   222.712 |   787.540 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Base               |   158.488 |   230.763 |   787.936 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Arm                |  1996.742 |  1908.541 |  3398.503 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Arm_Combine        |           |           |  2299.873 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Sse_Combine        |           |           |           |
| YShuffleX2KernelBenchmark_Int64 | Sum128Traits             |  3199.319 |  3400.298 |  3400.231 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Traits_ArgsT       |  2174.334 |  3398.868 |  3419.843 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Base_Basic         |   205.948 |   243.841 |  1054.873 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Base               |   204.801 |   249.601 |  1064.634 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Avx2_Combine       |           |           |           |
| YShuffleX2KernelBenchmark_Int64 | Sum256Traits             |   205.043 |   250.392 |  1064.043 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Traits_ArgsT       |   174.680 |   219.687 |  1064.383 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Base_Basic         |           |           |   697.684 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Base               |           |           |   696.985 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Traits             |           |           |   692.959 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Traits_ArgsT       |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | SumBase_Basic            |   940.485 |  1094.343 |  1555.002 |
| YShuffleX3KernelBenchmark_Byte  | SumBase                  |   941.541 |  1079.929 |  1554.459 |
| YShuffleX3KernelBenchmark_Byte  | SumTraits                | 18877.497 | 17247.328 | 27225.634 |
| YShuffleX3KernelBenchmark_Byte  | SumTraits_Args           | 21700.657 | 23499.220 | 27224.774 |
| YShuffleX3KernelBenchmark_Byte  | SumTraits_ArgsT          | 11528.336 | 14102.784 | 27219.890 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Base_Basic         |   762.475 |  1090.973 |  1554.428 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Base               |   760.259 |  1085.572 |  1554.082 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Arm                | 13024.136 | 12667.000 | 27177.887 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Arm_Combine        |           |           | 13502.080 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Sse_Combine        |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | Sum128Sse_Permute        |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | Sum128Sse_PermuteLonger  |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | Sum128Traits             | 27106.044 | 27099.185 | 27204.027 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Traits_ArgsT       | 15501.782 | 27127.265 | 27208.005 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Base_Basic         |   792.983 |   766.402 |  1585.975 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Base               |   770.994 |   766.248 |  1588.179 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Avx2_Combine       |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | Sum256Avx2_Permute       |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | Sum256Avx2_PermuteLonger |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | Sum256Traits             |   766.091 |   766.425 |  1587.459 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Traits_ArgsT       |   722.843 |   755.702 |  1582.296 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Base_Basic         |           |           |  1458.074 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Base               |           |           |  1457.532 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Traits             |           |           |  1457.436 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Traits_ArgsT       |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | SumBase_Basic            |   603.638 |   793.090 |  1234.711 |
| YShuffleX3KernelBenchmark_Int16 | SumBase                  |   612.770 |   788.660 |  1254.094 |
| YShuffleX3KernelBenchmark_Int16 | SumTraits                |  8355.441 |  9056.043 | 13573.871 |
| YShuffleX3KernelBenchmark_Int16 | SumTraits_Args           | 10865.900 | 12048.224 | 13586.103 |
| YShuffleX3KernelBenchmark_Int16 | SumTraits_ArgsT          |  5690.628 |  9071.674 | 13583.752 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Base_Basic         |   527.549 |   794.569 |  1250.494 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Base               |   528.082 |   800.360 |  1263.158 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Arm                |  5355.648 |  5562.154 | 13446.544 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Arm_Combine        |           |           |  6335.478 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Sse_Combine        |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | Sum128Sse_Permute        |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | Sum128Sse_PermuteLonger  |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | Sum128Traits             | 10802.738 | 11860.744 | 13604.796 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Traits_ArgsT       |  7761.131 | 13563.465 | 13599.351 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Base_Basic         |   509.211 |   602.073 |  1490.315 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Base               |   512.813 |   601.154 |  1486.849 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Avx2_Combine       |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | Sum256Avx2_Permute       |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | Sum256Avx2_PermuteLonger |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | Sum256Traits             |   512.319 |   601.375 |  1489.943 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Traits_ArgsT       |   475.496 |   571.444 |  1480.364 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Base_Basic         |           |           |  1275.903 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Base               |           |           |  1274.653 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Traits             |           |           |  1275.759 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Traits_ArgsT       |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | SumBase_Basic            |   376.039 |   439.072 |  1157.298 |
| YShuffleX3KernelBenchmark_Int32 | SumBase                  |   377.546 |   438.923 |  1157.210 |
| YShuffleX3KernelBenchmark_Int32 | SumTraits                |  3835.886 |  4524.676 |  6798.436 |
| YShuffleX3KernelBenchmark_Int32 | SumTraits_Args           |  5435.217 |  6019.204 |  6801.217 |
| YShuffleX3KernelBenchmark_Int32 | SumTraits_ArgsT          |  2853.096 |  4305.650 |  6801.645 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Base_Basic         |   263.725 |   406.214 |  1157.193 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Base               |   264.987 |   460.123 |  1157.135 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Arm                |  2671.603 |  2772.690 |  6470.569 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Arm_Combine        |           |           |  3168.083 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_Combine        |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_CombineAvx     |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_Permute        |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_PermuteLonger  |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum128Traits             |  5406.620 |  5939.197 |  6799.510 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Traits_ArgsT       |  3882.904 |  6770.102 |  6801.869 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Base_Basic         |   328.757 |   400.623 |  1256.797 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Base               |   330.637 |   404.792 |  1256.650 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Avx2_Combine       |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum256Avx2_Permute       |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum256Avx2_PermuteLonger |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum256Traits             |   329.580 |   404.760 |  1256.909 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Traits_ArgsT       |   290.799 |   370.928 |  1224.996 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Base_Basic         |           |           |  1020.446 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Base               |           |           |  1020.604 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Traits             |           |           |  1019.333 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Traits_ArgsT       |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | SumBase_Basic            |   197.309 |   224.407 |   735.058 |
| YShuffleX3KernelBenchmark_Int64 | SumBase                  |   197.598 |   225.620 |   735.110 |
| YShuffleX3KernelBenchmark_Int64 | SumTraits                |  2014.444 |  2175.301 |  3398.732 |
| YShuffleX3KernelBenchmark_Int64 | SumTraits_Args           |  2718.872 |  3020.966 |  3400.187 |
| YShuffleX3KernelBenchmark_Int64 | SumTraits_ArgsT          |  1410.886 |  2101.171 |  3400.199 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Base_Basic         |   142.083 |   216.465 |   735.325 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Base               |   143.572 |   238.601 |   734.949 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Arm                |  1340.463 |  1409.486 |  3282.347 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Arm_Combine        |           |           |  1585.261 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_Combine        |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_CombineAvx     |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_Permute        |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_PermuteLonger  |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum128Traits             |  2707.240 |  2972.428 |  3400.623 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Traits_ArgsT       |  1942.375 |  3399.221 |  3400.736 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Base_Basic         |   177.887 |   217.095 |   911.997 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Base               |   176.941 |   218.309 |   911.706 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Avx2_Combine       |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum256Avx2_Permute       |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum256Avx2_PermuteLonger |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum256Traits             |   177.797 |   220.110 |   923.619 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Traits_ArgsT       |   153.600 |   195.746 |   943.197 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Base_Basic         |           |           |   568.696 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Base               |           |           |   567.421 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Traits             |           |           |   567.126 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Traits_ArgsT       |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | SumBase_Basic            |   876.904 |  1034.575 |  1532.811 |
| YShuffleX4KernelBenchmark_Byte  | SumBase                  |   894.479 |  1047.157 |  1532.302 |
| YShuffleX4KernelBenchmark_Byte  | SumTraits                | 15517.154 | 14885.979 | 27192.497 |
| YShuffleX4KernelBenchmark_Byte  | SumTraits_Args           | 18095.038 | 19712.185 | 27202.917 |
| YShuffleX4KernelBenchmark_Byte  | SumTraits_ArgsT          |  9311.309 | 13412.372 | 27205.125 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Base_Basic         |   725.901 |  1038.443 |  1532.918 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Base               |   724.447 |  1044.708 |  1532.529 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Arm                |  9144.770 |  9377.006 | 25047.236 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Arm_Combine        |           |           |  9802.843 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Sse_Combine        |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | Sum128Sse_Permute        |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | Sum128Sse_PermuteLonger  |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | Sum128Traits             | 19740.603 | 19730.715 | 27195.346 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Traits_ArgsT       | 14008.313 | 25503.518 | 27208.729 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Base_Basic         |   755.425 |   737.027 |  1564.748 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Base               |   724.493 |   736.548 |  1565.229 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Avx2_Combine       |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | Sum256Avx2_Permute       |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | Sum256Avx2_PermuteLonger |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | Sum256Traits             |   715.654 |   736.844 |  1564.432 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Traits_ArgsT       |   672.036 |   726.550 |  1557.043 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Base_Basic         |           |           |  1422.045 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Base               |           |           |  1421.114 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Traits             |           |           |  1421.650 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Traits_ArgsT       |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | SumBase_Basic            |   565.824 |   743.055 |  1322.998 |
| YShuffleX4KernelBenchmark_Int16 | SumBase                  |   567.473 |   743.077 |  1323.410 |
| YShuffleX4KernelBenchmark_Int16 | SumTraits                |  7018.225 |  6884.835 | 13598.131 |
| YShuffleX4KernelBenchmark_Int16 | SumTraits_Args           |  9058.163 |  9872.741 | 13605.175 |
| YShuffleX4KernelBenchmark_Int16 | SumTraits_ArgsT          |  4700.519 |  6804.932 | 13600.445 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Base_Basic         |   496.452 |   745.423 |  1312.341 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Base               |   495.015 |   748.054 |  1311.154 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Arm                |  4113.422 |  4259.317 |  9843.613 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Arm_Combine        |           |           |  4588.981 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Sse_Combine        |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | Sum128Sse_Permute        |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | Sum128Sse_PermuteLonger  |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | Sum128Traits             |  8309.184 |  8772.038 | 13588.192 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Traits_ArgsT       |  7012.143 | 12747.485 | 13601.308 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Base_Basic         |   469.404 |   572.488 |  1450.336 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Base               |   472.757 |   570.255 |  1450.549 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Avx2_Combine       |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | Sum256Avx2_Permute       |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | Sum256Avx2_PermuteLonger |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | Sum256Traits             |   470.400 |   571.795 |  1450.760 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Traits_ArgsT       |   442.669 |   535.147 |  1435.214 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Base_Basic         |           |           |  1220.943 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Base               |           |           |  1220.869 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Traits             |           |           |  1220.642 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Traits_ArgsT       |           |           |           |

### Wasm - Wasm - AMD Ryzen 7 7840H
| Type                            | Method                   | .NET 8.0 |
| :------------------------------ | :----------------------- | -------: |
| YShuffleX2KernelBenchmark_Byte  | SumBase_Basic            |   89.114 |
| YShuffleX2KernelBenchmark_Byte  | SumBase                  |   89.950 |
| YShuffleX2KernelBenchmark_Byte  | SumTraits                | 2610.817 |
| YShuffleX2KernelBenchmark_Byte  | SumTraits_Args           | 1606.436 |
| YShuffleX2KernelBenchmark_Byte  | SumTraits_ArgsT          | 1486.628 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Base_Basic         |   89.790 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Base               | 2988.704 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Arm                |          |
| YShuffleX2KernelBenchmark_Byte  | Sum128Arm_Combine        |          |
| YShuffleX2KernelBenchmark_Byte  | Sum128Sse_Combine        |          |
| YShuffleX2KernelBenchmark_Byte  | Sum128Traits             | 2899.393 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Traits_ArgsT       | 1635.804 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Base_Basic         |   92.411 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Base               |   90.047 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Avx2_Combine       |          |
| YShuffleX2KernelBenchmark_Byte  | Sum256Avx2_Combine2      |          |
| YShuffleX2KernelBenchmark_Byte  | Sum256Avx2_Combine3      |          |
| YShuffleX2KernelBenchmark_Byte  | Sum256Traits             |   83.448 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Traits_ArgsT       |   89.766 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Base_Basic         |   98.266 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Base               |  101.516 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Traits             |   92.666 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Traits_ArgsT       |          |
| YShuffleX2KernelBenchmark_Int16 | SumBase_Basic            |   54.021 |
| YShuffleX2KernelBenchmark_Int16 | SumBase                  |   55.572 |
| YShuffleX2KernelBenchmark_Int16 | SumTraits                |  615.819 |
| YShuffleX2KernelBenchmark_Int16 | SumTraits_Args           |  802.578 |
| YShuffleX2KernelBenchmark_Int16 | SumTraits_ArgsT          |  778.375 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Base_Basic         |   55.646 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Base               |  118.973 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Arm                |          |
| YShuffleX2KernelBenchmark_Int16 | Sum128Arm_Combine        |          |
| YShuffleX2KernelBenchmark_Int16 | Sum128Sse_Combine        |          |
| YShuffleX2KernelBenchmark_Int16 | Sum128Traits             |  617.566 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Traits_ArgsT       |  808.541 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Base_Basic         |   61.538 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Base               |   61.008 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Avx2_Combine       |          |
| YShuffleX2KernelBenchmark_Int16 | Sum256Traits             |   53.402 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Traits_ArgsT       |   58.389 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Base_Basic         |   63.759 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Base               |   63.263 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Traits             |   56.092 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Traits_ArgsT       |          |
| YShuffleX2KernelBenchmark_Int32 | SumBase_Basic            |   30.833 |
| YShuffleX2KernelBenchmark_Int32 | SumBase                  |   31.418 |
| YShuffleX2KernelBenchmark_Int32 | SumTraits                |  298.041 |
| YShuffleX2KernelBenchmark_Int32 | SumTraits_Args           |  269.225 |
| YShuffleX2KernelBenchmark_Int32 | SumTraits_ArgsT          |  253.018 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Base_Basic         |   31.305 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Base               |   64.330 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Arm                |          |
| YShuffleX2KernelBenchmark_Int32 | Sum128Arm_Combine        |          |
| YShuffleX2KernelBenchmark_Int32 | Sum128Sse_Combine        |          |
| YShuffleX2KernelBenchmark_Int32 | Sum128Traits             |   53.419 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Traits_ArgsT       |   52.903 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Base_Basic         |   15.559 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Base               |   15.898 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Avx2_Combine       |          |
| YShuffleX2KernelBenchmark_Int32 | Sum256Traits             |   14.091 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Traits_ArgsT       |   13.631 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Base_Basic         |   18.932 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Base               |   19.241 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Traits             |   17.798 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Traits_ArgsT       |          |
| YShuffleX2KernelBenchmark_Int64 | SumBase_Basic            |    5.911 |
| YShuffleX2KernelBenchmark_Int64 | SumBase                  |    5.703 |
| YShuffleX2KernelBenchmark_Int64 | SumTraits                |   16.671 |
| YShuffleX2KernelBenchmark_Int64 | SumTraits_Args           |   23.612 |
| YShuffleX2KernelBenchmark_Int64 | SumTraits_ArgsT          |   20.660 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Base_Basic         |    4.653 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Base               |    4.730 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Arm                |          |
| YShuffleX2KernelBenchmark_Int64 | Sum128Arm_Combine        |          |
| YShuffleX2KernelBenchmark_Int64 | Sum128Sse_Combine        |          |
| YShuffleX2KernelBenchmark_Int64 | Sum128Traits             |   21.603 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Traits_ArgsT       |   27.707 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Base_Basic         |    5.360 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Base               |    5.192 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Avx2_Combine       |          |
| YShuffleX2KernelBenchmark_Int64 | Sum256Traits             |    4.607 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Traits_ArgsT       |    4.556 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Base_Basic         |    5.726 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Base               |    6.026 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Traits             |    5.481 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Traits_ArgsT       |          |
| YShuffleX3KernelBenchmark_Byte  | SumBase_Basic            |   28.401 |
| YShuffleX3KernelBenchmark_Byte  | SumBase                  |   27.369 |
| YShuffleX3KernelBenchmark_Byte  | SumTraits                |  155.669 |
| YShuffleX3KernelBenchmark_Byte  | SumTraits_Args           |  156.882 |
| YShuffleX3KernelBenchmark_Byte  | SumTraits_ArgsT          |  143.528 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Base_Basic         |   27.655 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Base               |  137.331 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Arm                |          |
| YShuffleX3KernelBenchmark_Byte  | Sum128Arm_Combine        |          |
| YShuffleX3KernelBenchmark_Byte  | Sum128Sse_Combine        |          |
| YShuffleX3KernelBenchmark_Byte  | Sum128Sse_Permute        |          |
| YShuffleX3KernelBenchmark_Byte  | Sum128Sse_PermuteLonger  |          |
| YShuffleX3KernelBenchmark_Byte  | Sum128Traits             |  191.904 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Traits_ArgsT       |  173.977 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Base_Basic         |   31.647 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Base               |   32.285 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Avx2_Combine       |          |
| YShuffleX3KernelBenchmark_Byte  | Sum256Avx2_Permute       |          |
| YShuffleX3KernelBenchmark_Byte  | Sum256Avx2_PermuteLonger |          |
| YShuffleX3KernelBenchmark_Byte  | Sum256Traits             |   29.999 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Traits_ArgsT       |   29.334 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Base_Basic         |   34.750 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Base               |   35.177 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Traits             |   33.416 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Traits_ArgsT       |          |
| YShuffleX3KernelBenchmark_Int16 | SumBase_Basic            |   20.011 |
| YShuffleX3KernelBenchmark_Int16 | SumBase                  |   19.329 |
| YShuffleX3KernelBenchmark_Int16 | SumTraits                |   66.753 |
| YShuffleX3KernelBenchmark_Int16 | SumTraits_Args           |   79.822 |
| YShuffleX3KernelBenchmark_Int16 | SumTraits_ArgsT          |   74.538 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Base_Basic         |   19.589 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Base               |   82.127 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Arm                |          |
| YShuffleX3KernelBenchmark_Int16 | Sum128Arm_Combine        |          |
| YShuffleX3KernelBenchmark_Int16 | Sum128Sse_Combine        |          |
| YShuffleX3KernelBenchmark_Int16 | Sum128Sse_Permute        |          |
| YShuffleX3KernelBenchmark_Int16 | Sum128Sse_PermuteLonger  |          |
| YShuffleX3KernelBenchmark_Int16 | Sum128Traits             |   77.078 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Traits_ArgsT       |   89.510 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Base_Basic         |   23.802 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Base               |   23.993 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Avx2_Combine       |          |
| YShuffleX3KernelBenchmark_Int16 | Sum256Avx2_Permute       |          |
| YShuffleX3KernelBenchmark_Int16 | Sum256Avx2_PermuteLonger |          |
| YShuffleX3KernelBenchmark_Int16 | Sum256Traits             |   21.734 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Traits_ArgsT       |   20.677 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Base_Basic         |   27.048 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Base               |   27.022 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Traits             |   23.533 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Traits_ArgsT       |          |
| YShuffleX3KernelBenchmark_Int32 | SumBase_Basic            |   12.597 |
| YShuffleX3KernelBenchmark_Int32 | SumBase                  |   12.617 |
| YShuffleX3KernelBenchmark_Int32 | SumTraits                |   32.944 |
| YShuffleX3KernelBenchmark_Int32 | SumTraits_Args           |   37.614 |
| YShuffleX3KernelBenchmark_Int32 | SumTraits_ArgsT          |   35.286 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Base_Basic         |   12.212 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Base               |   48.058 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Arm                |          |
| YShuffleX3KernelBenchmark_Int32 | Sum128Arm_Combine        |          |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_Combine        |          |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_CombineAvx     |          |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_Permute        |          |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_PermuteLonger  |          |
| YShuffleX3KernelBenchmark_Int32 | Sum128Traits             |   39.086 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Traits_ArgsT       |   45.319 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Base_Basic         |   16.122 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Base               |   15.861 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Avx2_Combine       |          |
| YShuffleX3KernelBenchmark_Int32 | Sum256Avx2_Permute       |          |
| YShuffleX3KernelBenchmark_Int32 | Sum256Avx2_PermuteLonger |          |
| YShuffleX3KernelBenchmark_Int32 | Sum256Traits             |   13.972 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Traits_ArgsT       |   13.060 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Base_Basic         |   19.171 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Base               |   19.071 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Traits             |   17.386 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Traits_ArgsT       |          |
| YShuffleX3KernelBenchmark_Int64 | SumBase_Basic            |    5.754 |
| YShuffleX3KernelBenchmark_Int64 | SumBase                  |    5.529 |
| YShuffleX3KernelBenchmark_Int64 | SumTraits                |   12.271 |
| YShuffleX3KernelBenchmark_Int64 | SumTraits_Args           |   17.335 |
| YShuffleX3KernelBenchmark_Int64 | SumTraits_ArgsT          |   15.259 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Base_Basic         |    4.551 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Base               |    3.165 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Arm                |          |
| YShuffleX3KernelBenchmark_Int64 | Sum128Arm_Combine        |          |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_Combine        |          |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_CombineAvx     |          |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_Permute        |          |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_PermuteLonger  |          |
| YShuffleX3KernelBenchmark_Int64 | Sum128Traits             |   16.596 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Traits_ArgsT       |   22.816 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Base_Basic         |    5.482 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Base               |    5.387 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Avx2_Combine       |          |
| YShuffleX3KernelBenchmark_Int64 | Sum256Avx2_Permute       |          |
| YShuffleX3KernelBenchmark_Int64 | Sum256Avx2_PermuteLonger |          |
| YShuffleX3KernelBenchmark_Int64 | Sum256Traits             |    4.467 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Traits_ArgsT       |    4.441 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Base_Basic         |    5.934 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Base               |    5.951 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Traits             |    5.425 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Traits_ArgsT       |          |
| YShuffleX4KernelBenchmark_Byte  | SumBase_Basic            |   27.239 |
| YShuffleX4KernelBenchmark_Byte  | SumBase                  |   26.818 |
| YShuffleX4KernelBenchmark_Byte  | SumTraits                |  115.652 |
| YShuffleX4KernelBenchmark_Byte  | SumTraits_Args           |  116.589 |
| YShuffleX4KernelBenchmark_Byte  | SumTraits_ArgsT          |  120.023 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Base_Basic         |   27.177 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Base               |  104.002 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Arm                |          |
| YShuffleX4KernelBenchmark_Byte  | Sum128Arm_Combine        |          |
| YShuffleX4KernelBenchmark_Byte  | Sum128Sse_Combine        |          |
| YShuffleX4KernelBenchmark_Byte  | Sum128Sse_Permute        |          |
| YShuffleX4KernelBenchmark_Byte  | Sum128Sse_PermuteLonger  |          |
| YShuffleX4KernelBenchmark_Byte  | Sum128Traits             |   96.662 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Traits_ArgsT       |  155.357 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Base_Basic         |   30.981 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Base               |   31.819 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Avx2_Combine       |          |
| YShuffleX4KernelBenchmark_Byte  | Sum256Avx2_Permute       |          |
| YShuffleX4KernelBenchmark_Byte  | Sum256Avx2_PermuteLonger |          |
| YShuffleX4KernelBenchmark_Byte  | Sum256Traits             |   28.930 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Traits_ArgsT       |   28.375 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Base_Basic         |   35.900 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Base               |   34.606 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Traits             |   33.341 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Traits_ArgsT       |          |
| YShuffleX4KernelBenchmark_Int16 | SumBase_Basic            |   19.190 |
| YShuffleX4KernelBenchmark_Int16 | SumBase                  |   18.555 |
| YShuffleX4KernelBenchmark_Int16 | SumTraits                |   52.770 |
| YShuffleX4KernelBenchmark_Int16 | SumTraits_Args           |   59.890 |
| YShuffleX4KernelBenchmark_Int16 | SumTraits_ArgsT          |   60.942 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Base_Basic         |   18.983 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Base               |   61.970 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Arm                |          |
| YShuffleX4KernelBenchmark_Int16 | Sum128Arm_Combine        |          |
| YShuffleX4KernelBenchmark_Int16 | Sum128Sse_Combine        |          |
| YShuffleX4KernelBenchmark_Int16 | Sum128Sse_Permute        |          |
| YShuffleX4KernelBenchmark_Int16 | Sum128Sse_PermuteLonger  |          |
| YShuffleX4KernelBenchmark_Int16 | Sum128Traits             |   64.710 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Traits_ArgsT       |   76.813 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Base_Basic         |   23.458 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Base               |   23.248 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Avx2_Combine       |          |
| YShuffleX4KernelBenchmark_Int16 | Sum256Avx2_Permute       |          |
| YShuffleX4KernelBenchmark_Int16 | Sum256Avx2_PermuteLonger |          |
| YShuffleX4KernelBenchmark_Int16 | Sum256Traits             |   20.725 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Traits_ArgsT       |   20.349 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Base_Basic         |   27.295 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Base               |   27.324 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Traits             |   25.181 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Traits_ArgsT       |          |
