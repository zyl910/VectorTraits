# Benchmark group - YShuffleX2Kernel
([← Back](YShuffleX2Kernel.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### X86 - AMD Ryzen 7 7840H
| Type                            | Method                   | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :------------------------------ | :----------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| YShuffleX2KernelBenchmark_Byte  | SumBase_Basic            |        323.974 |       734.453 |       745.261 |   769.117 |   808.343 |   694.312 |   917.774 |
| YShuffleX2KernelBenchmark_Byte  | SumBase                  |        317.773 |       740.475 |       710.133 |   772.591 |   786.548 |   686.563 |   945.338 |
| YShuffleX2KernelBenchmark_Byte  | SumTraits                |        315.705 |       728.772 |     14191.125 | 15884.949 | 15029.381 | 17839.090 | 71478.251 |
| YShuffleX2KernelBenchmark_Byte  | SumTraits_Args           |        325.706 |       744.519 |     21591.461 | 26073.822 | 26028.372 | 24511.025 | 71714.983 |
| YShuffleX2KernelBenchmark_Byte  | SumTraits_ArgsT          |        311.284 |       622.356 |     20485.055 | 20918.021 | 17473.814 | 20592.448 | 70119.520 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Base_Basic         |                |               |       412.995 |   413.313 |   414.381 |   566.185 |   801.232 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Base               |                |               |       412.981 |   414.461 |   423.258 |   588.739 |   804.888 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Arm                |                |               |               |           |           |           |           |
| YShuffleX2KernelBenchmark_Byte  | Sum128Arm_Combine        |                |               |               |           |           |           |           |
| YShuffleX2KernelBenchmark_Byte  | Sum128Sse_Combine        |                |               |     17255.779 | 23321.687 | 23536.245 | 21356.629 | 23182.440 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Traits             |                |               |     15115.249 | 22750.631 | 23098.857 | 19985.482 | 37083.467 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Traits_ArgsT       |                |               |     21864.133 | 23981.001 | 21512.873 | 20866.376 | 37526.896 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Base_Basic         |                |               |       522.816 |   524.686 |   552.678 |   668.943 |   950.825 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Base               |                |               |       511.126 |   531.415 |   444.879 |   689.769 |  1007.898 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Avx2_Combine       |                |               |     14935.233 | 18871.907 | 19862.921 | 21732.634 | 23787.035 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Avx2_Combine2      |                |               |     15311.712 | 19393.189 | 21986.058 | 19433.171 | 20713.628 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Avx2_Combine3      |                |               |     15969.205 | 18767.346 | 19375.435 | 22142.920 | 23174.267 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Traits             |                |               |     15929.046 | 19297.803 | 19119.525 | 22348.708 | 70587.427 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Traits_ArgsT       |                |               |     21269.018 | 22235.191 | 26623.054 | 21435.959 | 70666.615 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Base_Basic         |                |               |               |           |           |           |   912.966 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Base               |                |               |               |           |           |           |   496.972 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Traits             |                |               |               |           |           |           | 85135.552 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Traits_ArgsT       |                |               |               |           |           |           | 84883.398 |
| YShuffleX2KernelBenchmark_Int16 | SumBase_Basic            |        262.677 |       558.062 |       564.900 |   599.893 |   584.054 |   502.700 |   779.558 |
| YShuffleX2KernelBenchmark_Int16 | SumBase                  |        248.341 |       540.558 |       556.204 |   605.246 |   593.512 |   501.510 |   775.105 |
| YShuffleX2KernelBenchmark_Int16 | SumTraits                |        239.209 |       558.114 |      5683.816 |  6581.965 |  6700.738 |  7620.087 | 37391.696 |
| YShuffleX2KernelBenchmark_Int16 | SumTraits_Args           |        281.617 |       559.992 |     11638.058 | 13238.999 | 13545.552 | 12500.398 | 36420.577 |
| YShuffleX2KernelBenchmark_Int16 | SumTraits_ArgsT          |        261.851 |       410.867 |     10411.032 |  9997.559 |  9456.905 |  9407.757 | 37826.671 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Base_Basic         |                |               |       259.714 |   255.254 |   266.227 |   368.013 |   529.371 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Base               |                |               |       261.192 |   263.378 |   263.157 |   347.402 |   525.953 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Arm                |                |               |               |           |           |           |           |
| YShuffleX2KernelBenchmark_Int16 | Sum128Arm_Combine        |                |               |               |           |           |           |           |
| YShuffleX2KernelBenchmark_Int16 | Sum128Sse_Combine        |                |               |      5970.014 |  8021.664 |  7906.576 | 10236.330 | 10603.866 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Traits             |                |               |      5454.364 |  8010.160 |  8053.970 | 10199.553 | 18603.729 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Traits_ArgsT       |                |               |     10714.789 | 11471.647 | 10415.313 | 10746.402 | 18289.904 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Base_Basic         |                |               |       337.068 |   355.844 |   349.831 |   522.237 |   763.596 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Base               |                |               |       355.376 |   356.430 |   276.545 |   516.605 |   779.092 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Avx2_Combine       |                |               |      5903.322 |  8354.045 |  7971.378 | 10462.788 | 10295.303 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Traits             |                |               |      5854.687 |  7966.237 |  7619.494 | 10936.609 | 36567.932 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Traits_ArgsT       |                |               |     10822.763 | 10952.858 | 13264.693 | 10673.816 | 37349.128 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Base_Basic         |                |               |               |           |           |           |   724.758 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Base               |                |               |               |           |           |           |   527.331 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Traits             |                |               |               |           |           |           | 45542.736 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Traits_ArgsT       |                |               |               |           |           |           | 45486.067 |
| YShuffleX2KernelBenchmark_Int32 | SumBase_Basic            |        198.312 |       348.275 |       353.172 |   367.747 |   357.773 |   308.903 |   492.810 |
| YShuffleX2KernelBenchmark_Int32 | SumBase                  |        191.235 |       336.581 |       343.131 |   368.362 |   352.331 |   315.974 |   518.975 |
| YShuffleX2KernelBenchmark_Int32 | SumTraits                |        195.942 |       346.714 |      7304.367 |  7885.910 |  6948.860 |  7046.240 | 16615.500 |
| YShuffleX2KernelBenchmark_Int32 | SumTraits_Args           |        208.612 |       353.263 |      8449.771 | 10713.378 | 10380.918 | 10909.322 | 16363.912 |
| YShuffleX2KernelBenchmark_Int32 | SumTraits_ArgsT          |        160.571 |       244.793 |      6886.688 |  6318.448 |  5231.069 |  5865.793 | 15985.566 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Base_Basic         |                |               |       158.529 |   155.145 |   155.677 |   208.112 |   310.154 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Base               |                |               |       154.832 |   153.192 |   157.390 |   211.458 |   313.127 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Arm                |                |               |               |           |           |           |           |
| YShuffleX2KernelBenchmark_Int32 | Sum128Arm_Combine        |                |               |               |           |           |           |           |
| YShuffleX2KernelBenchmark_Int32 | Sum128Sse_Combine        |                |               |      2774.169 |  3965.649 |  3963.651 |  4967.007 |  5261.967 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Traits             |                |               |      6616.236 |  7796.037 |  7043.731 |  7791.102 |  9191.362 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Traits_ArgsT       |                |               |      5882.643 |  6436.470 |  7138.754 |  5771.645 |  9341.585 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Base_Basic         |                |               |       229.539 |   243.130 |   244.977 |   298.625 |   474.308 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Base               |                |               |       230.649 |   242.823 |   159.377 |   320.267 |   500.369 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Avx2_Combine       |                |               |      6926.635 | 10382.409 | 11082.213 | 10079.300 | 10173.456 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Traits             |                |               |      8067.002 | 10584.855 | 10095.332 | 10136.233 | 16154.269 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Traits_ArgsT       |                |               |      8160.522 |  7796.296 |  6935.821 |  7186.470 | 16540.374 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Base_Basic         |                |               |               |           |           |           |   477.194 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Base               |                |               |               |           |           |           |   520.742 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Traits             |                |               |               |           |           |           | 18002.034 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Traits_ArgsT       |                |               |               |           |           |           | 18000.725 |
| YShuffleX2KernelBenchmark_Int64 | SumBase_Basic            |        124.441 |       188.368 |       191.286 |   203.016 |   190.671 |   166.312 |   257.693 |
| YShuffleX2KernelBenchmark_Int64 | SumBase                  |        124.435 |       188.868 |       183.416 |   191.652 |   187.988 |   176.683 |   283.904 |
| YShuffleX2KernelBenchmark_Int64 | SumTraits                |        128.463 |       186.299 |      2806.858 |  3304.073 |  3102.730 |  3224.097 |  8778.706 |
| YShuffleX2KernelBenchmark_Int64 | SumTraits_Args           |        123.925 |       186.085 |      4587.777 |  5516.020 |  5302.754 |  5455.595 |  9174.376 |
| YShuffleX2KernelBenchmark_Int64 | SumTraits_ArgsT          |         97.554 |       132.443 |      3185.618 |  3228.487 |  2710.207 |  2940.019 |  9023.532 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Base_Basic         |                |               |        81.340 |    81.868 |    80.748 |   112.593 |   161.484 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Base               |                |               |        81.304 |    82.301 |    81.371 |   108.567 |   162.228 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Arm                |                |               |               |           |           |           |           |
| YShuffleX2KernelBenchmark_Int64 | Sum128Arm_Combine        |                |               |               |           |           |           |           |
| YShuffleX2KernelBenchmark_Int64 | Sum128Sse_Combine        |                |               |      1411.172 |  1786.849 |  2057.260 |  2200.869 |  2627.131 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Traits             |                |               |      2171.371 |  2858.358 |  3053.688 |  3056.046 |  4718.742 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Traits_ArgsT       |                |               |      3062.205 |  3619.032 |  4087.951 |  2988.627 |  4681.940 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Base_Basic         |                |               |       130.525 |   137.936 |   131.308 |   180.368 |   257.660 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Base               |                |               |       129.529 |   135.400 |    81.945 |   178.826 |   285.961 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Avx2_Combine       |                |               |      3133.104 |  3723.773 |  3775.863 |  4082.992 |  5197.336 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Traits             |                |               |      3208.982 |  3896.466 |  3949.656 |  4235.375 |  9073.060 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Traits_ArgsT       |                |               |      4053.461 |  3908.303 |  3553.676 |  3483.792 |  9036.689 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Base_Basic         |                |               |               |           |           |           |   274.251 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Base               |                |               |               |           |           |           |   399.423 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Traits             |                |               |               |           |           |           | 10127.402 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Traits_ArgsT       |                |               |               |           |           |           | 10249.481 |
| YShuffleX3KernelBenchmark_Byte  | SumBase_Basic            |        357.321 |       706.018 |       695.947 |   743.786 |   529.914 |   645.003 |   963.222 |
| YShuffleX3KernelBenchmark_Byte  | SumBase                  |        358.005 |       687.039 |       712.030 |   714.925 |   728.341 |   634.334 |   925.499 |
| YShuffleX3KernelBenchmark_Byte  | SumTraits                |        367.704 |       673.153 |      8496.008 | 10232.075 | 10219.968 | 10941.137 | 49180.751 |
| YShuffleX3KernelBenchmark_Byte  | SumTraits_Args           |        367.878 |       707.152 |      8686.846 | 12882.002 | 12776.915 | 14416.011 | 49126.457 |
| YShuffleX3KernelBenchmark_Byte  | SumTraits_ArgsT          |        349.789 |       616.933 |     10575.198 | 10446.003 | 11276.418 | 11353.926 | 48809.890 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Base_Basic         |                |               |       391.769 |   397.352 |   398.243 |   543.711 |   784.216 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Base               |                |               |       404.359 |   388.062 |   420.293 |   560.454 |   813.897 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Arm                |                |               |               |           |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | Sum128Arm_Combine        |                |               |               |           |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | Sum128Sse_Combine        |                |               |      9548.154 | 16389.102 | 15577.768 | 13750.518 | 14236.355 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Sse_Permute        |                |               |               |           |           |           | 22166.339 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Sse_PermuteLonger  |                |               |               |           |           |           | 32986.744 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Traits             |                |               |      9813.628 | 15500.432 | 15374.123 | 13490.301 | 33006.004 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Traits_ArgsT       |                |               |     16387.909 | 16976.356 | 18250.228 | 17577.915 | 35682.271 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Base_Basic         |                |               |       486.296 |   501.533 |   440.768 |   649.739 |   939.910 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Base               |                |               |       504.933 |   515.032 |   523.264 |   645.660 |   921.435 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Avx2_Combine       |                |               |      7477.251 |  9737.137 | 12578.758 | 13267.427 | 15267.895 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Avx2_Permute       |                |               |               |           |           |           | 40784.863 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Avx2_PermuteLonger |                |               |               |           |           |           | 48914.865 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Traits             |                |               |      7661.884 |  9764.526 | 11752.379 | 13730.816 | 48933.744 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Traits_ArgsT       |                |               |     11703.982 | 13484.202 | 12969.582 | 13732.954 | 48518.382 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Base_Basic         |                |               |               |           |           |           |   856.658 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Base               |                |               |               |           |           |           |   307.652 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Traits             |                |               |               |           |           |           | 50224.626 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Traits_ArgsT       |                |               |               |           |           |           | 66874.325 |
| YShuffleX3KernelBenchmark_Int16 | SumBase_Basic            |        282.859 |       518.875 |       550.274 |   530.800 |   544.675 |   481.806 |   729.103 |
| YShuffleX3KernelBenchmark_Int16 | SumBase                  |        284.171 |       475.892 |       527.075 |   533.462 |   537.187 |   452.727 |   747.978 |
| YShuffleX3KernelBenchmark_Int16 | SumTraits                |        272.527 |       508.787 |      3407.932 |  4482.350 |  4606.289 |  5104.850 | 24862.192 |
| YShuffleX3KernelBenchmark_Int16 | SumTraits_Args           |        286.930 |       514.512 |      4252.309 |  6431.718 |  6389.786 |  7266.814 | 24817.984 |
| YShuffleX3KernelBenchmark_Int16 | SumTraits_ArgsT          |        244.155 |       406.419 |      5180.313 |  5453.453 |  5373.863 |  5665.398 | 24565.671 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Base_Basic         |                |               |       244.420 |   248.283 |   250.099 |   334.090 |   518.496 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Base               |                |               |       249.948 |   249.317 |   254.234 |   318.327 |   523.472 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Arm                |                |               |               |           |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | Sum128Arm_Combine        |                |               |               |           |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | Sum128Sse_Combine        |                |               |      3756.222 |  5609.641 |  5618.278 |  6672.000 |  6834.621 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Sse_Permute        |                |               |               |           |           |           | 11173.695 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Sse_PermuteLonger  |                |               |               |           |           |           | 17389.771 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Traits             |                |               |      4010.055 |  5723.565 |  5719.990 |  7070.659 | 17256.252 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Traits_ArgsT       |                |               |      7687.726 |  8834.183 |  8941.891 |  8463.181 | 17387.754 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Base_Basic         |                |               |       319.927 |   339.648 |   254.821 |   493.975 |   707.712 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Base               |                |               |       327.045 |   336.253 |   329.489 |   469.239 |   725.942 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Avx2_Combine       |                |               |      3323.978 |  4427.601 |  4877.778 |  6673.769 |  6858.239 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Avx2_Permute       |                |               |               |           |           |           | 20087.774 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Avx2_PermuteLonger |                |               |               |           |           |           | 24664.853 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Traits             |                |               |      3343.343 |  4592.685 |  5142.934 |  6873.163 | 24293.223 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Traits_ArgsT       |                |               |      5700.098 |  6698.350 |  6490.496 |  6865.956 | 24504.767 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Base_Basic         |                |               |               |           |           |           |   683.788 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Base               |                |               |               |           |           |           |   323.717 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Traits             |                |               |               |           |           |           | 23794.633 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Traits_ArgsT       |                |               |               |           |           |           | 33681.144 |
| YShuffleX3KernelBenchmark_Int32 | SumBase_Basic            |        186.590 |       300.194 |       309.256 |   333.037 |   319.638 |   294.051 |   455.893 |
| YShuffleX3KernelBenchmark_Int32 | SumBase                  |        201.164 |       294.376 |       304.556 |   326.314 |   316.147 |   291.388 |   465.810 |
| YShuffleX3KernelBenchmark_Int32 | SumTraits                |        194.466 |       294.589 |      5059.394 |  4936.920 |  4850.118 |  4376.864 | 12245.165 |
| YShuffleX3KernelBenchmark_Int32 | SumTraits_Args           |        185.250 |       298.945 |      5708.252 |  6670.720 |  6551.664 |  6408.569 | 12297.306 |
| YShuffleX3KernelBenchmark_Int32 | SumTraits_ArgsT          |        150.212 |       225.129 |      4995.114 |  4371.074 |  3974.575 |  4148.286 | 12082.445 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Base_Basic         |                |               |       147.153 |   145.586 |   147.043 |   195.480 |   298.098 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Base               |                |               |       147.643 |   147.997 |   149.634 |   196.335 |   298.061 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Arm                |                |               |               |           |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum128Arm_Combine        |                |               |               |           |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_Combine        |                |               |      2015.961 |  2816.010 |  2786.402 |  3430.054 |  3526.722 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_CombineAvx     |                |               |      3627.991 |  4375.245 |  4335.349 |  3380.519 |  4994.314 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_Permute        |                |               |               |           |           |           |  5471.566 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_PermuteLonger  |                |               |               |           |           |           |  8654.647 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Traits             |                |               |      3660.668 |  4317.417 |  4559.281 |  4089.082 |  8694.716 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Traits_ArgsT       |                |               |      4035.831 |  4070.040 |  4410.070 |  4316.543 |  8790.291 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Base_Basic         |                |               |       218.335 |   229.020 |   166.594 |   285.081 |   449.213 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Base               |                |               |       221.635 |   225.707 |   221.301 |   301.604 |   475.206 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Avx2_Combine       |                |               |      5760.987 |  7271.112 |  7629.383 |  6668.731 |  7227.763 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Avx2_Permute       |                |               |               |           |           |           |  9962.650 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Avx2_PermuteLonger |                |               |               |           |           |           | 11964.014 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Traits             |                |               |      6034.450 |  7578.794 |  7798.261 |  6583.865 | 12227.781 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Traits_ArgsT       |                |               |      6658.647 |  6575.630 |  5574.601 |  6256.168 | 12133.006 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Base_Basic         |                |               |               |           |           |           |   428.245 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Base               |                |               |               |           |           |           |   319.193 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Traits             |                |               |               |           |           |           | 11717.801 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Traits_ArgsT       |                |               |               |           |           |           | 16110.556 |
| YShuffleX3KernelBenchmark_Int64 | SumBase_Basic            |        114.677 |       163.580 |       171.337 |   173.615 |    90.433 |   153.370 |   243.649 |
| YShuffleX3KernelBenchmark_Int64 | SumBase                  |        114.194 |       164.245 |       158.874 |   174.744 |   160.160 |   162.273 |   248.391 |
| YShuffleX3KernelBenchmark_Int64 | SumTraits                |        110.642 |       163.324 |      1929.456 |  2232.612 |  2284.001 |  2239.303 |  6200.402 |
| YShuffleX3KernelBenchmark_Int64 | SumTraits_Args           |        116.077 |       166.088 |      2938.772 |  3507.383 |  3471.877 |  3398.971 |  6105.707 |
| YShuffleX3KernelBenchmark_Int64 | SumTraits_ArgsT          |         87.933 |       123.751 |      2507.510 |  2468.148 |  2042.380 |  2415.094 |  6234.605 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Base_Basic         |                |               |        76.524 |    75.927 |    76.833 |   100.808 |   151.103 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Base               |                |               |        76.053 |    77.020 |    75.931 |   101.112 |   154.385 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Arm                |                |               |               |           |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum128Arm_Combine        |                |               |               |           |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_Combine        |                |               |       977.368 |  1298.972 |  1403.548 |  1456.284 |  1630.796 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_CombineAvx     |                |               |      1346.260 |  1696.075 |  1891.126 |  1841.121 |  2195.314 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_Permute        |                |               |               |           |           |           |  2682.787 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_PermuteLonger  |                |               |               |           |           |           |  4264.060 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Traits             |                |               |      1351.897 |  1726.950 |  1861.309 |  1848.442 |  4385.848 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Traits_ArgsT       |                |               |      1958.987 |  2281.661 |  2323.630 |  2281.405 |  4477.911 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Base_Basic         |                |               |       117.866 |   123.292 |    83.410 |   150.447 |   244.384 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Base               |                |               |       118.511 |   124.255 |   119.223 |   162.389 |   250.067 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Avx2_Combine       |                |               |      2312.584 |  2834.084 |  2731.740 |  2988.915 |  3520.286 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Avx2_Permute       |                |               |               |           |           |           |  5222.066 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Avx2_PermuteLonger |                |               |               |           |           |           |  6105.714 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Traits             |                |               |      2330.007 |  2706.021 |  2730.439 |  2726.072 |  6182.639 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Traits_ArgsT       |                |               |      3484.795 |  3347.776 |  2839.833 |  3063.381 |  6183.783 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Base_Basic         |                |               |               |           |           |           |   246.988 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Base               |                |               |               |           |           |           |   264.064 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Traits             |                |               |               |           |           |           |  6379.197 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Traits_ArgsT       |                |               |               |           |           |           |  8416.329 |
| YShuffleX4KernelBenchmark_Byte  | SumBase_Basic            |        344.132 |       652.677 |       659.766 |   722.590 |   526.126 |   621.240 |   891.452 |
| YShuffleX4KernelBenchmark_Byte  | SumBase                  |        334.335 |       666.359 |       697.167 |   699.968 |   490.164 |   606.010 |   927.186 |
| YShuffleX4KernelBenchmark_Byte  | SumTraits                |        359.187 |       667.039 |      6196.546 |  7874.249 |  7873.712 |  8236.069 | 46763.811 |
| YShuffleX4KernelBenchmark_Byte  | SumTraits_Args           |        355.181 |       661.909 |      7118.947 |  8588.362 |  8912.375 |  8646.693 | 47204.861 |
| YShuffleX4KernelBenchmark_Byte  | SumTraits_ArgsT          |        320.126 |       575.959 |      7911.217 |  7864.167 |  7583.659 |  8534.736 | 46887.974 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Base_Basic         |                |               |       388.775 |   387.383 |   377.683 |   497.011 |   815.131 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Base               |                |               |       387.436 |   383.536 |   386.170 |   526.022 |   796.205 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Arm                |                |               |               |           |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | Sum128Arm_Combine        |                |               |               |           |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | Sum128Sse_Combine        |                |               |      7351.856 |  9911.458 | 11491.793 | 10393.215 | 11398.204 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Sse_Permute        |                |               |               |           |           |           | 21815.131 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Sse_PermuteLonger  |                |               |               |           |           |           | 33479.321 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Traits             |                |               |      7595.027 |  9749.889 |  9679.496 | 10506.192 | 34672.521 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Traits_ArgsT       |                |               |     11950.398 | 13985.529 | 13724.254 | 12825.184 | 34693.417 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Base_Basic         |                |               |       468.462 |   494.019 |   428.373 |   607.055 |   860.218 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Base               |                |               |       505.527 |   524.998 |   434.695 |   638.299 |   920.964 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Avx2_Combine       |                |               |      6059.951 |  8764.287 |  9318.013 |  9662.719 | 11182.254 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Avx2_Permute       |                |               |               |           |           |           | 39921.575 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Avx2_PermuteLonger |                |               |               |           |           |           | 46452.648 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Traits             |                |               |      5852.198 |  8592.115 |  9014.806 |  9430.436 | 47305.600 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Traits_ArgsT       |                |               |      8985.430 |  8204.797 |  9231.179 |  8372.617 | 47232.902 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Base_Basic         |                |               |               |           |           |           |   861.981 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Base               |                |               |               |           |           |           |   277.338 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Traits             |                |               |               |           |           |           | 49009.996 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Traits_ArgsT       |                |               |               |           |           |           | 66532.354 |
| YShuffleX4KernelBenchmark_Int16 | SumBase_Basic            |        261.680 |       447.000 |       490.198 |   482.455 |   312.911 |   429.594 |   709.553 |
| YShuffleX4KernelBenchmark_Int16 | SumBase                  |        253.543 |       443.258 |       474.093 |   487.888 |   501.661 |   454.473 |   730.715 |
| YShuffleX4KernelBenchmark_Int16 | SumTraits                |        246.951 |       454.592 |      2656.867 |  3595.484 |  3523.872 |  3938.514 | 24768.336 |
| YShuffleX4KernelBenchmark_Int16 | SumTraits_Args           |        256.745 |       436.124 |      3633.566 |  4266.201 |  4442.298 |  4183.637 | 24109.187 |
| YShuffleX4KernelBenchmark_Int16 | SumTraits_ArgsT          |        230.179 |       361.272 |      3840.816 |  3826.905 |  3774.233 |  4224.561 | 24324.144 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Base_Basic         |                |               |       230.769 |   237.013 |   234.278 |   308.879 |   506.029 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Base               |                |               |       235.007 |   239.396 |   233.201 |   308.320 |   500.514 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Arm                |                |               |               |           |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | Sum128Arm_Combine        |                |               |               |           |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | Sum128Sse_Combine        |                |               |      3084.676 |  4263.349 |  4461.138 |  5528.884 |  5583.220 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Sse_Permute        |                |               |               |           |           |           | 10049.249 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Sse_PermuteLonger  |                |               |               |           |           |           | 15879.008 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Traits             |                |               |      2955.229 |  4463.794 |  4615.919 |  5118.002 | 14965.848 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Traits_ArgsT       |                |               |      5797.976 |  6635.808 |  6678.087 |  6169.876 | 17651.997 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Base_Basic         |                |               |       305.353 |   314.653 |   251.000 |   419.929 |   704.335 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Base               |                |               |       302.779 |   327.180 |   252.273 |   460.632 |   728.908 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Avx2_Combine       |                |               |      2641.254 |  3893.079 |  3995.548 |  4873.980 |  5384.367 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Avx2_Permute       |                |               |               |           |           |           | 20502.277 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Avx2_PermuteLonger |                |               |               |           |           |           | 23851.373 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Traits             |                |               |      2611.056 |  3683.795 |  3757.884 |  4769.892 | 24199.342 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Traits_ArgsT       |                |               |      4230.805 |  4206.049 |  4623.433 |  4230.532 | 24693.193 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Base_Basic         |                |               |               |           |           |           |   634.335 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Base               |                |               |               |           |           |           |   259.857 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Traits             |                |               |               |           |           |           | 23060.200 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Traits_ArgsT       |                |               |               |           |           |           | 33261.853 |
| YShuffleX4KernelBenchmark_Int32 | SumBase_Basic            |        182.863 |       266.173 |       275.120 |   297.860 |   168.530 |   211.541 |   415.676 |
| YShuffleX4KernelBenchmark_Int32 | SumBase                  |        177.910 |       260.138 |       285.636 |   292.991 |   274.567 |   233.198 |   428.932 |
| YShuffleX4KernelBenchmark_Int32 | SumTraits                |        171.081 |       260.201 |      3787.149 |  3871.522 |  3909.662 |  3727.002 | 12122.958 |
| YShuffleX4KernelBenchmark_Int32 | SumTraits_Args           |        177.224 |       259.137 |      4267.843 |  4574.286 |  4823.093 |  3818.965 | 11396.250 |
| YShuffleX4KernelBenchmark_Int32 | SumTraits_ArgsT          |        148.306 |       207.766 |      3916.539 |  3900.428 |  3407.529 |  3300.724 | 11742.099 |
| YShuffleX4KernelBenchmark_Int32 | Sum128Base_Basic         |                |               |       134.972 |   136.520 |   137.928 |   182.359 |   270.611 |
| YShuffleX4KernelBenchmark_Int32 | Sum128Base               |                |               |       133.003 |   137.747 |   138.243 |   170.735 |   280.625 |
| YShuffleX4KernelBenchmark_Int32 | Sum128Arm                |                |               |               |           |           |           |           |
| YShuffleX4KernelBenchmark_Int32 | Sum128Arm_Combine        |                |               |               |           |           |           |           |
| YShuffleX4KernelBenchmark_Int32 | Sum128Sse_Combine        |                |               |      1538.969 |  2229.810 |  2221.028 |  2501.408 |  2745.922 |
| YShuffleX4KernelBenchmark_Int32 | Sum128Sse_CombineAvx     |                |               |      3232.491 |  4076.781 |  4307.285 |  3652.894 |  4770.686 |
| YShuffleX4KernelBenchmark_Int32 | Sum128Sse_Permute        |                |               |               |           |           |           |  4994.935 |
| YShuffleX4KernelBenchmark_Int32 | Sum128Sse_PermuteLonger  |                |               |               |           |           |           |  8192.892 |
| YShuffleX4KernelBenchmark_Int32 | Sum128Traits             |                |               |      3140.510 |  4184.402 |  3566.860 |  3475.437 |  8450.614 |
| YShuffleX4KernelBenchmark_Int32 | Sum128Traits_ArgsT       |                |               |      3125.821 |  3332.730 |  3308.053 |  3225.781 |  8131.090 |
| YShuffleX4KernelBenchmark_Int32 | Sum256Base_Basic         |                |               |       202.907 |   215.081 |   155.357 |   262.217 |   410.461 |
| YShuffleX4KernelBenchmark_Int32 | Sum256Base               |                |               |       202.175 |   210.481 |   148.480 |   268.592 |   439.612 |
| YShuffleX4KernelBenchmark_Int32 | Sum256Avx2_Combine       |                |               |      4477.335 |  5410.081 |  5735.580 |  5028.805 |  5305.054 |
| YShuffleX4KernelBenchmark_Int32 | Sum256Avx2_Permute       |                |               |               |           |           |           |  9669.274 |
| YShuffleX4KernelBenchmark_Int32 | Sum256Avx2_PermuteLonger |                |               |               |           |           |           | 11372.471 |
| YShuffleX4KernelBenchmark_Int32 | Sum256Traits             |                |               |      4578.812 |  5474.792 |  5631.755 |  4986.457 | 12171.250 |
| YShuffleX4KernelBenchmark_Int32 | Sum256Traits_ArgsT       |                |               |      5018.413 |  5143.370 |  5811.082 |  4917.571 | 11549.694 |
| YShuffleX4KernelBenchmark_Int32 | Sum512Base_Basic         |                |               |               |           |           |           |   396.176 |
| YShuffleX4KernelBenchmark_Int32 | Sum512Base               |                |               |               |           |           |           |   297.317 |
| YShuffleX4KernelBenchmark_Int32 | Sum512Traits             |                |               |               |           |           |           | 11595.050 |
| YShuffleX4KernelBenchmark_Int32 | Sum512Traits_ArgsT       |                |               |               |           |           |           | 15781.247 |
| YShuffleX4KernelBenchmark_Int64 | SumBase_Basic            |        101.731 |       138.798 |       143.226 |   156.912 |    83.969 |   141.132 |   221.247 |
| YShuffleX4KernelBenchmark_Int64 | SumBase                  |        102.390 |       137.534 |       146.281 |   153.222 |    84.068 |   145.557 |   231.895 |
| YShuffleX4KernelBenchmark_Int64 | SumTraits                |        109.275 |       138.200 |      1639.499 |  1781.519 |  1825.704 |  1732.857 |  6022.813 |
| YShuffleX4KernelBenchmark_Int64 | SumTraits_Args           |        105.825 |       141.703 |      2136.173 |  2399.962 |  2539.453 |  2154.269 |  6093.442 |
| YShuffleX4KernelBenchmark_Int64 | SumTraits_ArgsT          |         83.091 |       112.625 |      1973.799 |  1936.689 |  1831.449 |  1608.418 |  6270.980 |
| YShuffleX4KernelBenchmark_Int64 | Sum128Base_Basic         |                |               |        69.870 |    71.122 |    74.624 |    93.763 |   145.474 |
| YShuffleX4KernelBenchmark_Int64 | Sum128Base               |                |               |        69.484 |    70.207 |    74.341 |    93.316 |   141.572 |
| YShuffleX4KernelBenchmark_Int64 | Sum128Arm                |                |               |               |           |           |           |           |
| YShuffleX4KernelBenchmark_Int64 | Sum128Arm_Combine        |                |               |               |           |           |           |           |
| YShuffleX4KernelBenchmark_Int64 | Sum128Sse_Combine        |                |               |       755.692 |  1095.690 |   995.263 |  1169.357 |  1358.014 |
| YShuffleX4KernelBenchmark_Int64 | Sum128Sse_CombineAvx     |                |               |      1250.406 |  1582.226 |  1845.488 |  1634.188 |  2306.123 |
| YShuffleX4KernelBenchmark_Int64 | Sum128Sse_Permute        |                |               |               |           |           |           |  2629.088 |
| YShuffleX4KernelBenchmark_Int64 | Sum128Sse_PermuteLonger  |                |               |               |           |           |           |  4328.000 |
| YShuffleX4KernelBenchmark_Int64 | Sum128Traits             |                |               |      1097.445 |  1609.234 |  1811.993 |  1745.081 |  3943.918 |
| YShuffleX4KernelBenchmark_Int64 | Sum128Traits_ArgsT       |                |               |      1490.399 |  1493.907 |  1706.006 |  1666.407 |  4096.481 |
| YShuffleX4KernelBenchmark_Int64 | Sum256Base_Basic         |                |               |       106.162 |   111.559 |    88.101 |   141.599 |   219.212 |
| YShuffleX4KernelBenchmark_Int64 | Sum256Base               |                |               |       105.490 |   111.723 |    84.839 |   144.396 |   232.104 |
| YShuffleX4KernelBenchmark_Int64 | Sum256Avx2_Combine       |                |               |      1905.629 |  2151.468 |  2142.667 |  2166.441 |  2636.071 |
| YShuffleX4KernelBenchmark_Int64 | Sum256Avx2_Permute       |                |               |               |           |           |           |  4979.182 |
| YShuffleX4KernelBenchmark_Int64 | Sum256Avx2_PermuteLonger |                |               |               |           |           |           |  6125.421 |
| YShuffleX4KernelBenchmark_Int64 | Sum256Traits             |                |               |      1882.864 |  2180.477 |  2177.315 |  2145.245 |  5910.534 |
| YShuffleX4KernelBenchmark_Int64 | Sum256Traits_ArgsT       |                |               |      2618.767 |  2560.372 |  2809.271 |  2439.089 |  6145.693 |
| YShuffleX4KernelBenchmark_Int64 | Sum512Base_Basic         |                |               |               |           |           |           |   224.716 |
| YShuffleX4KernelBenchmark_Int64 | Sum512Base               |                |               |               |           |           |           |   218.025 |
| YShuffleX4KernelBenchmark_Int64 | Sum512Traits             |                |               |               |           |           |           |  6173.950 |
| YShuffleX4KernelBenchmark_Int64 | Sum512Traits_ArgsT       |                |               |               |           |           |           |  8278.127 |

### Arm - Apple M2
| Type                            | Method                   |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :------------------------------ | :----------------------- | --------: | --------: | --------: |
| YShuffleX2KernelBenchmark_Byte  | SumBase_Basic            |   996.153 |  1129.995 |  1555.604 |
| YShuffleX2KernelBenchmark_Byte  | SumBase                  |   997.631 |  1135.991 |  1555.414 |
| YShuffleX2KernelBenchmark_Byte  | SumTraits                | 24114.203 | 27113.711 | 27240.132 |
| YShuffleX2KernelBenchmark_Byte  | SumTraits_Args           | 27111.475 | 27168.117 | 27236.197 |
| YShuffleX2KernelBenchmark_Byte  | SumTraits_ArgsT          | 14438.208 | 27077.600 | 27242.476 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Base_Basic         |   803.560 |  1138.978 |  1555.540 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Base               |   805.983 |  1134.421 |  1555.495 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Arm                | 19168.034 | 19577.168 | 27214.191 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Arm_Combine        |           |           | 21673.223 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Sse_Combine        |           |           |           |
| YShuffleX2KernelBenchmark_Byte  | Sum128Traits             | 27191.242 | 27179.159 | 27257.058 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Traits_ArgsT       | 17371.642 | 27168.233 | 27250.741 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Base_Basic         |   847.189 |   793.705 |  1606.266 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Base               |   823.967 |   793.315 |  1606.271 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Avx2_Combine       |           |           |           |
| YShuffleX2KernelBenchmark_Byte  | Sum256Avx2_Combine2      |           |           |           |
| YShuffleX2KernelBenchmark_Byte  | Sum256Avx2_Combine3      |           |           |           |
| YShuffleX2KernelBenchmark_Byte  | Sum256Traits             |   820.682 |   793.452 |  1606.248 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Traits_ArgsT       |   770.910 |   779.363 |  1606.193 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Base_Basic         |           |           |  1514.242 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Base               |           |           |  1515.588 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Traits             |           |           |  1516.447 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Traits_ArgsT       |           |           |           |
| YShuffleX2KernelBenchmark_Int16 | SumBase_Basic            |   665.349 |   833.526 |  1144.003 |
| YShuffleX2KernelBenchmark_Int16 | SumBase                  |   665.517 |   833.381 |  1144.913 |
| YShuffleX2KernelBenchmark_Int16 | SumTraits                | 10348.980 | 12075.050 | 13616.487 |
| YShuffleX2KernelBenchmark_Int16 | SumTraits_Args           | 13573.264 | 13597.671 | 13619.401 |
| YShuffleX2KernelBenchmark_Int16 | SumTraits_ArgsT          |  7231.713 | 13542.515 | 13620.174 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Base_Basic         |   568.944 |   840.811 |  1135.570 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Base               |   570.191 |   844.025 |  1180.408 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Arm                |  8054.294 |  7926.017 | 13594.638 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Arm_Combine        |           |           |  9195.181 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Sse_Combine        |           |           |           |
| YShuffleX2KernelBenchmark_Int16 | Sum128Traits             | 13584.316 | 13592.875 | 13611.881 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Traits_ArgsT       |  8692.589 | 13591.705 | 13617.417 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Base_Basic         |   558.597 |   639.745 |  1521.842 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Base               |   557.528 |   640.791 |  1521.927 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Avx2_Combine       |           |           |           |
| YShuffleX2KernelBenchmark_Int16 | Sum256Traits             |   558.301 |   641.220 |  1521.811 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Traits_ArgsT       |   512.959 |   602.713 |  1521.773 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Base_Basic         |           |           |  1366.357 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Base               |           |           |  1370.370 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Traits             |           |           |  1370.555 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Traits_ArgsT       |           |           |           |
| YShuffleX2KernelBenchmark_Int32 | SumBase_Basic            |   377.307 |   432.913 |  1222.558 |
| YShuffleX2KernelBenchmark_Int32 | SumBase                  |   384.931 |   433.057 |  1222.463 |
| YShuffleX2KernelBenchmark_Int32 | SumTraits                |  5179.177 |  6041.436 |  6804.914 |
| YShuffleX2KernelBenchmark_Int32 | SumTraits_Args           |  6796.217 |  6800.007 |  6804.728 |
| YShuffleX2KernelBenchmark_Int32 | SumTraits_ArgsT          |  3623.730 |  6003.930 |  6804.287 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Base_Basic         |   289.380 |   434.500 |  1222.594 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Base               |   287.664 |   452.502 |  1222.749 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Arm                |  4029.660 |  3965.922 |  6800.644 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Arm_Combine        |           |           |  4599.670 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Sse_Combine        |           |           |           |
| YShuffleX2KernelBenchmark_Int32 | Sum128Traits             |  6797.292 |  6800.305 |  6804.267 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Traits_ArgsT       |  4347.777 |  6799.586 |  6803.995 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Base_Basic         |   372.920 |   441.874 |  1299.411 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Base               |   371.247 |   442.757 |  1299.830 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Avx2_Combine       |           |           |           |
| YShuffleX2KernelBenchmark_Int32 | Sum256Traits             |   373.516 |   441.477 |  1300.153 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Traits_ArgsT       |   332.533 |   404.334 |  1300.412 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Base_Basic         |           |           |  1143.678 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Base               |           |           |  1141.571 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Traits             |           |           |  1142.269 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Traits_ArgsT       |           |           |           |
| YShuffleX2KernelBenchmark_Int64 | SumBase_Basic            |   194.978 |   223.087 |   787.954 |
| YShuffleX2KernelBenchmark_Int64 | SumBase                  |   195.893 |   223.445 |   788.199 |
| YShuffleX2KernelBenchmark_Int64 | SumTraits                |  2470.259 |  2863.275 |  3401.351 |
| YShuffleX2KernelBenchmark_Int64 | SumTraits_Args           |  3399.551 |  3400.749 |  3401.876 |
| YShuffleX2KernelBenchmark_Int64 | SumTraits_ArgsT          |  1811.587 |  3393.367 |  3401.708 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Base_Basic         |   153.144 |   224.791 |   788.050 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Base               |   152.895 |   233.397 |   788.353 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Arm                |  1942.931 |  1909.832 |  3400.651 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Arm_Combine        |           |           |  2300.615 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Sse_Combine        |           |           |           |
| YShuffleX2KernelBenchmark_Int64 | Sum128Traits             |  3199.628 |  3401.063 |  3401.544 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Traits_ArgsT       |  2174.780 |  3400.570 |  3402.005 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Base_Basic         |   205.937 |   245.792 |  1064.911 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Base               |   205.011 |   246.975 |  1064.844 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Avx2_Combine       |           |           |           |
| YShuffleX2KernelBenchmark_Int64 | Sum256Traits             |   206.190 |   247.422 |  1064.598 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Traits_ArgsT       |   177.200 |   221.371 |  1064.382 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Base_Basic         |           |           |   697.884 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Base               |           |           |   697.533 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Traits             |           |           |   697.740 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Traits_ArgsT       |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | SumBase_Basic            |   935.266 |  1111.308 |  1555.405 |
| YShuffleX3KernelBenchmark_Byte  | SumBase                  |   938.877 |  1111.397 |  1554.863 |
| YShuffleX3KernelBenchmark_Byte  | SumTraits                | 18884.082 | 18838.900 | 27212.259 |
| YShuffleX3KernelBenchmark_Byte  | SumTraits_Args           | 21713.042 | 23512.053 | 27215.924 |
| YShuffleX3KernelBenchmark_Byte  | SumTraits_ArgsT          | 12057.989 | 15640.861 | 27219.622 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Base_Basic         |   757.788 |  1089.040 |  1554.618 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Base               |   755.102 |  1090.864 |  1554.686 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Arm                | 12673.084 | 12671.251 | 27182.585 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Arm_Combine        |           |           | 13512.727 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Sse_Combine        |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | Sum128Sse_Permute        |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | Sum128Sse_PermuteLonger  |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | Sum128Traits             | 27112.086 | 27103.436 | 27225.121 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Traits_ArgsT       | 15519.250 | 27117.247 | 27232.872 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Base_Basic         |   797.465 |   766.564 |  1589.009 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Base               |   778.259 |   766.346 |  1589.005 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Avx2_Combine       |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | Sum256Avx2_Permute       |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | Sum256Avx2_PermuteLonger |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | Sum256Traits             |   771.012 |   767.497 |  1588.785 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Traits_ArgsT       |   728.594 |   754.666 |  1583.284 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Base_Basic         |           |           |  1458.449 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Base               |           |           |  1457.326 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Traits             |           |           |  1457.308 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Traits_ArgsT       |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | SumBase_Basic            |   638.648 |   786.732 |  1206.662 |
| YShuffleX3KernelBenchmark_Int16 | SumBase                  |   625.428 |   788.188 |  1214.815 |
| YShuffleX3KernelBenchmark_Int16 | SumTraits                |  8363.687 |  9059.348 | 13610.408 |
| YShuffleX3KernelBenchmark_Int16 | SumTraits_Args           | 10870.986 | 12075.264 | 13606.898 |
| YShuffleX3KernelBenchmark_Int16 | SumTraits_ArgsT          |  5384.030 |  8250.401 | 13610.302 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Base_Basic         |   538.210 |   788.330 |  1256.974 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Base               |   539.268 |   790.207 |  1279.262 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Arm                |  5356.172 |  5559.300 | 12591.950 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Arm_Combine        |           |           |  6169.492 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Sse_Combine        |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | Sum128Sse_Permute        |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | Sum128Sse_PermuteLonger  |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | Sum128Traits             | 10806.436 | 11839.591 | 13608.502 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Traits_ArgsT       |  7764.665 | 13581.638 | 13607.988 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Base_Basic         |   517.836 |   608.407 |  1490.520 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Base               |   515.624 |   605.204 |  1490.862 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Avx2_Combine       |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | Sum256Avx2_Permute       |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | Sum256Avx2_PermuteLonger |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | Sum256Traits             |   513.540 |   609.305 |  1490.904 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Traits_ArgsT       |   480.004 |   566.855 |  1480.434 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Base_Basic         |           |           |  1276.260 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Base               |           |           |  1277.017 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Traits             |           |           |  1274.939 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Traits_ArgsT       |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | SumBase_Basic            |   387.117 |   441.528 |  1157.689 |
| YShuffleX3KernelBenchmark_Int32 | SumBase                  |   387.361 |   445.299 |  1157.689 |
| YShuffleX3KernelBenchmark_Int32 | SumTraits                |  4183.049 |  4532.240 |  6803.467 |
| YShuffleX3KernelBenchmark_Int32 | SumTraits_Args           |  5437.536 |  6042.436 |  6803.307 |
| YShuffleX3KernelBenchmark_Int32 | SumTraits_ArgsT          |  2727.559 |  4073.442 |  6803.532 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Base_Basic         |   268.675 |   409.962 |  1157.424 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Base               |   268.875 |   462.936 |  1157.346 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Arm                |  2681.036 |  2778.671 |  6260.539 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Arm_Combine        |           |           |  3084.751 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_Combine        |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_CombineAvx     |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_Permute        |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_PermuteLonger  |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum128Traits             |  5405.846 |  5927.786 |  6803.525 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Traits_ArgsT       |  3883.709 |  6796.795 |  6803.684 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Base_Basic         |   332.862 |   402.811 |  1257.472 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Base               |   332.280 |   406.663 |  1257.331 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Avx2_Combine       |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum256Avx2_Permute       |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum256Avx2_PermuteLonger |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum256Traits             |   332.063 |   404.282 |  1257.344 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Traits_ArgsT       |   297.939 |   366.645 |  1242.838 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Base_Basic         |           |           |  1020.785 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Base               |           |           |  1021.426 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Traits             |           |           |  1021.555 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Traits_ArgsT       |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | SumBase_Basic            |   203.950 |   224.300 |   735.087 |
| YShuffleX3KernelBenchmark_Int64 | SumBase                  |   204.179 |   224.185 |   735.125 |
| YShuffleX3KernelBenchmark_Int64 | SumTraits                |  2015.285 |  2176.292 |  3401.301 |
| YShuffleX3KernelBenchmark_Int64 | SumTraits_Args           |  2720.419 |  3022.535 |  3401.436 |
| YShuffleX3KernelBenchmark_Int64 | SumTraits_ArgsT          |  1425.678 |  2271.862 |  3401.085 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Base_Basic         |   146.216 |   216.730 |   735.174 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Base               |   146.651 |   237.980 |   735.081 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Arm                |  1340.438 |  1407.293 |  3060.041 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Arm_Combine        |           |           |  1542.768 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_Combine        |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_CombineAvx     |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_Permute        |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_PermuteLonger  |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum128Traits             |  2707.372 |  2967.944 |  3401.254 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Traits_ArgsT       |  1942.662 |  3399.681 |  3401.648 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Base_Basic         |   179.860 |   216.650 |   900.128 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Base               |   179.153 |   220.403 |   922.852 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Avx2_Combine       |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum256Avx2_Permute       |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum256Avx2_PermuteLonger |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum256Traits             |   178.625 |   220.231 |   907.303 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Traits_ArgsT       |   156.207 |   198.183 |   908.927 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Base_Basic         |           |           |   568.131 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Base               |           |           |   568.102 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Traits             |           |           |   568.458 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Traits_ArgsT       |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | SumBase_Basic            |   911.042 |  1045.040 |  1533.053 |
| YShuffleX4KernelBenchmark_Byte  | SumBase                  |   912.186 |  1048.930 |  1532.822 |
| YShuffleX4KernelBenchmark_Byte  | SumTraits                | 15520.669 | 14324.216 | 27207.207 |
| YShuffleX4KernelBenchmark_Byte  | SumTraits_Args           | 18098.081 | 18927.408 | 27208.215 |
| YShuffleX4KernelBenchmark_Byte  | SumTraits_ArgsT          |  9582.669 | 13227.696 | 27208.765 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Base_Basic         |   738.533 |  1041.415 |  1533.198 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Base               |   735.410 |  1033.333 |  1533.009 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Arm                |  8902.800 |  9378.023 | 25030.790 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Arm_Combine        |           |           |  9810.858 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Sse_Combine        |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | Sum128Sse_Permute        |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | Sum128Sse_PermuteLonger  |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | Sum128Traits             | 19744.391 | 19733.279 | 27212.208 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Traits_ArgsT       | 14015.342 | 25503.760 | 27209.634 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Base_Basic         |   765.561 |   738.159 |  1565.760 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Base               |   732.696 |   740.223 |  1566.152 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Avx2_Combine       |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | Sum256Avx2_Permute       |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | Sum256Avx2_PermuteLonger |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | Sum256Traits             |   724.103 |   739.137 |  1565.513 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Traits_ArgsT       |   689.389 |   730.420 |  1557.575 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Base_Basic         |           |           |  1420.034 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Base               |           |           |  1238.464 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Traits             |           |           |  1420.425 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Traits_ArgsT       |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | SumBase_Basic            |   585.672 |   736.901 |  1323.257 |
| YShuffleX4KernelBenchmark_Int16 | SumBase                  |   587.723 |   739.695 |  1322.709 |
| YShuffleX4KernelBenchmark_Int16 | SumTraits                |  7015.291 |  6895.249 | 13605.531 |
| YShuffleX4KernelBenchmark_Int16 | SumTraits_Args           |  9061.464 |  8928.241 | 13605.811 |
| YShuffleX4KernelBenchmark_Int16 | SumTraits_ArgsT          |  4686.885 |  6291.661 | 13595.647 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Base_Basic         |   512.946 |   749.114 |  1308.682 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Base               |   512.341 |   745.159 |  1311.061 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Arm                |  4109.760 |  4254.873 | 10152.615 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Arm_Combine        |           |           |  4693.544 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Sse_Combine        |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | Sum128Sse_Permute        |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | Sum128Sse_PermuteLonger  |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | Sum128Traits             |  8306.109 |  8752.558 | 13601.863 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Traits_ArgsT       |  7014.042 | 12743.893 | 13606.519 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Base_Basic         |   479.553 |   571.291 |  1451.029 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Base               |   475.983 |   568.570 |  1450.834 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Avx2_Combine       |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | Sum256Avx2_Permute       |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | Sum256Avx2_PermuteLonger |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | Sum256Traits             |   479.523 |   569.787 |  1450.875 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Traits_ArgsT       |   447.542 |   535.977 |  1436.049 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Base_Basic         |           |           |  1218.462 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Base               |           |           |  1218.519 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Traits             |           |           |  1218.622 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Traits_ArgsT       |           |           |           |
| YShuffleX4KernelBenchmark_Int32 | SumBase_Basic            |   353.290 |   425.585 |  1121.547 |
| YShuffleX4KernelBenchmark_Int32 | SumBase                  |   353.123 |   430.426 |  1121.526 |
| YShuffleX4KernelBenchmark_Int32 | SumTraits                |  3508.959 |  2900.380 |  6802.400 |
| YShuffleX4KernelBenchmark_Int32 | SumTraits_Args           |  4532.738 |  4380.989 |  6802.439 |
| YShuffleX4KernelBenchmark_Int32 | SumTraits_ArgsT          |  2307.705 |  3186.021 |  6801.862 |
| YShuffleX4KernelBenchmark_Int32 | Sum128Base_Basic         |   252.013 |   394.273 |  1121.439 |
| YShuffleX4KernelBenchmark_Int32 | Sum128Base               |   253.590 |   414.804 |  1121.171 |
| YShuffleX4KernelBenchmark_Int32 | Sum128Arm                |  2055.069 |  2127.226 |  5043.644 |
| YShuffleX4KernelBenchmark_Int32 | Sum128Arm_Combine        |           |           |  2347.646 |
| YShuffleX4KernelBenchmark_Int32 | Sum128Sse_Combine        |           |           |           |
| YShuffleX4KernelBenchmark_Int32 | Sum128Sse_CombineAvx     |           |           |           |
| YShuffleX4KernelBenchmark_Int32 | Sum128Sse_Permute        |           |           |           |
| YShuffleX4KernelBenchmark_Int32 | Sum128Sse_PermuteLonger  |           |           |           |
| YShuffleX4KernelBenchmark_Int32 | Sum128Traits             |  4158.229 |  4381.253 |  6802.530 |
| YShuffleX4KernelBenchmark_Int32 | Sum128Traits_ArgsT       |  3507.228 |  6378.258 |  6802.078 |
| YShuffleX4KernelBenchmark_Int32 | Sum256Base_Basic         |   286.468 |   371.567 |  1192.681 |
| YShuffleX4KernelBenchmark_Int32 | Sum256Base               |   286.030 |   371.567 |  1190.889 |
| YShuffleX4KernelBenchmark_Int32 | Sum256Avx2_Combine       |           |           |           |
| YShuffleX4KernelBenchmark_Int32 | Sum256Avx2_Permute       |           |           |           |
| YShuffleX4KernelBenchmark_Int32 | Sum256Avx2_PermuteLonger |           |           |           |
| YShuffleX4KernelBenchmark_Int32 | Sum256Traits             |   284.807 |   371.419 |  1186.494 |
| YShuffleX4KernelBenchmark_Int32 | Sum256Traits_ArgsT       |   258.980 |   342.381 |  1178.727 |
| YShuffleX4KernelBenchmark_Int32 | Sum512Base_Basic         |           |           |   909.711 |
| YShuffleX4KernelBenchmark_Int32 | Sum512Base               |           |           |   909.661 |
| YShuffleX4KernelBenchmark_Int32 | Sum512Traits             |           |           |   909.603 |
| YShuffleX4KernelBenchmark_Int32 | Sum512Traits_ArgsT       |           |           |           |
| YShuffleX4KernelBenchmark_Int64 | SumBase_Basic            |   187.664 |   232.005 |   702.568 |
| YShuffleX4KernelBenchmark_Int64 | SumBase                  |   187.822 |   231.587 |   702.535 |
| YShuffleX4KernelBenchmark_Int64 | SumTraits                |  1700.424 |  1755.112 |  3401.303 |
| YShuffleX4KernelBenchmark_Int64 | SumTraits_Args           |  2265.564 |  2472.091 |  3401.433 |
| YShuffleX4KernelBenchmark_Int64 | SumTraits_ArgsT          |  1169.047 |  1629.628 |  3401.286 |
| YShuffleX4KernelBenchmark_Int64 | Sum128Base_Basic         |   137.632 |   208.308 |   703.188 |
| YShuffleX4KernelBenchmark_Int64 | Sum128Base               |   137.661 |   219.096 |   703.240 |
| YShuffleX4KernelBenchmark_Int64 | Sum128Arm                |  1030.386 |  1062.039 |  2490.638 |
| YShuffleX4KernelBenchmark_Int64 | Sum128Arm_Combine        |           |           |  1173.810 |
| YShuffleX4KernelBenchmark_Int64 | Sum128Sse_Combine        |           |           |           |
| YShuffleX4KernelBenchmark_Int64 | Sum128Sse_CombineAvx     |           |           |           |
| YShuffleX4KernelBenchmark_Int64 | Sum128Sse_Permute        |           |           |           |
| YShuffleX4KernelBenchmark_Int64 | Sum128Sse_PermuteLonger  |           |           |           |
| YShuffleX4KernelBenchmark_Int64 | Sum128Traits             |  2079.381 |  2189.525 |  3401.045 |
| YShuffleX4KernelBenchmark_Int64 | Sum128Traits_ArgsT       |  1754.940 |  3192.350 |  3401.099 |
| YShuffleX4KernelBenchmark_Int64 | Sum256Base_Basic         |   155.525 |   199.107 |   800.570 |
| YShuffleX4KernelBenchmark_Int64 | Sum256Base               |   155.922 |   200.086 |   800.432 |
| YShuffleX4KernelBenchmark_Int64 | Sum256Avx2_Combine       |           |           |           |
| YShuffleX4KernelBenchmark_Int64 | Sum256Avx2_Permute       |           |           |           |
| YShuffleX4KernelBenchmark_Int64 | Sum256Avx2_PermuteLonger |           |           |           |
| YShuffleX4KernelBenchmark_Int64 | Sum256Traits             |   155.649 |   202.583 |   800.638 |
| YShuffleX4KernelBenchmark_Int64 | Sum256Traits_ArgsT       |   137.738 |   183.228 |   793.844 |
| YShuffleX4KernelBenchmark_Int64 | Sum512Base_Basic         |           |           |   481.321 |
| YShuffleX4KernelBenchmark_Int64 | Sum512Base               |           |           |   481.752 |
| YShuffleX4KernelBenchmark_Int64 | Sum512Traits             |           |           |   480.820 |
| YShuffleX4KernelBenchmark_Int64 | Sum512Traits_ArgsT       |           |           |           |

### Arm - AWS Arm t4g.small
| Type                            | Method                   | .NET Core 3.1 | .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :------------------------------ | :----------------------- | ------------: | -------: | --------: | --------: | --------: |
| YShuffleX2KernelBenchmark_Byte  | SumBase_Basic            |       386.442 |          |   382.735 |   375.880 |   472.929 |
| YShuffleX2KernelBenchmark_Byte  | SumBase                  |       383.493 |          |   381.257 |   373.670 |   473.065 |
| YShuffleX2KernelBenchmark_Byte  | SumTraits                |       384.179 |          |  8557.709 |  9853.451 | 19777.508 |
| YShuffleX2KernelBenchmark_Byte  | SumTraits_Args           |       384.360 |          |  9929.816 | 11028.413 | 19826.109 |
| YShuffleX2KernelBenchmark_Byte  | SumTraits_ArgsT          |       369.320 |          |  4873.877 |  9841.672 | 19825.366 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Base_Basic         |       275.150 |          |   275.421 |   378.202 |   472.853 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Base               |       274.111 |          |   276.088 |   377.623 |   472.944 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Arm                |               |          |  5965.898 |  6162.826 | 12577.890 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Arm_Combine        |               |          |           |           |  7157.759 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Sse_Combine        |               |          |           |           |           |
| YShuffleX2KernelBenchmark_Byte  | Sum128Traits             |       274.019 |          | 11861.620 | 13587.421 | 19813.211 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Traits_ArgsT       |       271.149 |          |  5531.700 | 13077.264 | 19807.383 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Base_Basic         |       297.928 |          |   297.203 |   253.775 |   527.258 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Base               |       286.131 |          |   281.582 |   253.492 |   527.119 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Avx2_Combine       |               |          |           |           |           |
| YShuffleX2KernelBenchmark_Byte  | Sum256Avx2_Combine2      |               |          |           |           |           |
| YShuffleX2KernelBenchmark_Byte  | Sum256Avx2_Combine3      |               |          |           |           |           |
| YShuffleX2KernelBenchmark_Byte  | Sum256Traits             |       261.942 |          |   266.923 |   252.924 |   527.224 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Traits_ArgsT       |       242.121 |          |   250.292 |   247.974 |   527.370 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Base_Basic         |               |          |           |           |   520.132 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Base               |               |          |           |           |   519.842 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Traits             |               |          |           |           |   519.806 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Traits_ArgsT       |               |          |           |           |           |
| YShuffleX2KernelBenchmark_Int16 | SumBase_Basic            |       250.954 |          |   240.990 |   257.083 |   372.974 |
| YShuffleX2KernelBenchmark_Int16 | SumBase                  |       250.149 |          |   239.824 |   258.794 |   371.933 |
| YShuffleX2KernelBenchmark_Int16 | SumTraits                |       250.192 |          |  3210.904 |  4228.682 |  9733.244 |
| YShuffleX2KernelBenchmark_Int16 | SumTraits_Args           |       250.334 |          |  4413.405 |  4972.675 |  9736.750 |
| YShuffleX2KernelBenchmark_Int16 | SumTraits_ArgsT          |       242.408 |          |  2251.130 |  4965.893 |  9734.258 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Base_Basic         |       183.557 |          |   181.142 |   264.536 |   372.965 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Base               |       182.496 |          |   182.110 |   265.564 |   372.338 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Arm                |               |          |  1830.404 |  1757.996 |  4275.993 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Arm_Combine        |               |          |           |           |  2667.662 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Sse_Combine        |               |          |           |           |           |
| YShuffleX2KernelBenchmark_Int16 | Sum128Traits             |       181.436 |          |  3729.980 |  4585.275 |  9751.556 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Traits_ArgsT       |       176.433 |          |  2741.429 |  7176.723 |  9763.374 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Base_Basic         |       160.844 |          |   178.890 |   188.752 |   447.055 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Base               |       155.835 |          |   176.348 |   187.598 |   445.189 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Avx2_Combine       |               |          |           |           |           |
| YShuffleX2KernelBenchmark_Int16 | Sum256Traits             |       139.906 |          |   172.387 |   187.765 |   445.584 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Traits_ArgsT       |       128.093 |          |   162.430 |   184.029 |   447.302 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Base_Basic         |               |          |           |           |   436.986 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Base               |               |          |           |           |   436.825 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Traits             |               |          |           |           |   436.768 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Traits_ArgsT       |               |          |           |           |           |
| YShuffleX2KernelBenchmark_Int32 | SumBase_Basic            |       189.683 |          |   174.949 |   175.262 |   285.014 |
| YShuffleX2KernelBenchmark_Int32 | SumBase                  |       193.693 |          |   171.892 |   175.936 |   284.895 |
| YShuffleX2KernelBenchmark_Int32 | SumTraits                |       193.562 |          |  1796.586 |  2121.620 |  4781.900 |
| YShuffleX2KernelBenchmark_Int32 | SumTraits_Args           |       192.625 |          |  2466.335 |  2477.755 |  4793.132 |
| YShuffleX2KernelBenchmark_Int32 | SumTraits_ArgsT          |       181.194 |          |  1186.055 |  2476.604 |  4801.014 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Base_Basic         |       120.436 |          |   121.958 |   177.538 |   285.060 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Base               |       120.727 |          |   122.193 |   178.710 |   284.935 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Arm                |               |          |   917.296 |   880.547 |  2131.975 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Arm_Combine        |               |          |           |           |  1326.527 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Sse_Combine        |               |          |           |           |           |
| YShuffleX2KernelBenchmark_Int32 | Sum128Traits             |       119.904 |          |  2092.697 |  2292.488 |  4795.014 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Traits_ArgsT       |       114.626 |          |  1365.175 |  3583.108 |  4755.291 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Base_Basic         |        99.208 |          |   113.890 |   141.736 |   387.120 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Base               |        96.135 |          |   112.125 |   140.015 |   386.196 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Avx2_Combine       |               |          |           |           |           |
| YShuffleX2KernelBenchmark_Int32 | Sum256Traits             |        84.253 |          |   111.738 |   139.993 |   386.999 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Traits_ArgsT       |        76.294 |          |    99.832 |   129.913 |   384.298 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Base_Basic         |               |          |           |           |   354.395 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Base               |               |          |           |           |   353.857 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Traits             |               |          |           |           |   353.881 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Traits_ArgsT       |               |          |           |           |           |
| YShuffleX2KernelBenchmark_Int64 | SumBase_Basic            |       118.550 |          |   104.197 |   100.764 |   283.201 |
| YShuffleX2KernelBenchmark_Int64 | SumBase                  |       116.596 |          |   101.670 |   101.495 |   283.035 |
| YShuffleX2KernelBenchmark_Int64 | SumTraits                |       118.071 |          |   887.114 |   986.764 |  2387.789 |
| YShuffleX2KernelBenchmark_Int64 | SumTraits_Args           |       116.024 |          |  1234.155 |  1404.804 |  2423.836 |
| YShuffleX2KernelBenchmark_Int64 | SumTraits_ArgsT          |       108.289 |          |   593.640 |  1239.561 |  2421.120 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Base_Basic         |        92.105 |          |    86.953 |   103.146 |   281.929 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Base               |        93.714 |          |    87.425 |   102.595 |   281.851 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Arm                |               |          |   444.359 |   429.787 |  1067.580 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Arm_Combine        |               |          |           |           |   660.528 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Sse_Combine        |               |          |           |           |           |
| YShuffleX2KernelBenchmark_Int64 | Sum128Traits             |        94.009 |          |   971.263 |  1061.381 |  2425.242 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Traits_ArgsT       |        86.211 |          |   683.826 |  1792.615 |  2425.949 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Base_Basic         |        62.042 |          |    83.419 |    91.326 |   386.092 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Base               |        59.501 |          |    82.658 |    91.225 |   386.889 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Avx2_Combine       |               |          |           |           |           |
| YShuffleX2KernelBenchmark_Int64 | Sum256Traits             |        50.395 |          |    82.329 |    91.288 |   386.905 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Traits_ArgsT       |        44.474 |          |    68.991 |    88.765 |   390.720 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Base_Basic         |               |          |           |           |   257.649 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Base               |               |          |           |           |   257.921 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Traits             |               |          |           |           |   257.751 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Traits_ArgsT       |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | SumBase_Basic            |       366.995 |          |   366.384 |   364.379 |   463.021 |
| YShuffleX3KernelBenchmark_Byte  | SumBase                  |       369.214 |          |   359.877 |   363.047 |   461.535 |
| YShuffleX3KernelBenchmark_Byte  | SumTraits                |       368.144 |          |  6624.361 |  7019.432 | 15729.903 |
| YShuffleX3KernelBenchmark_Byte  | SumTraits_Args           |       365.377 |          |  7923.366 |  8449.775 | 15730.552 |
| YShuffleX3KernelBenchmark_Byte  | SumTraits_ArgsT          |       352.508 |          |  3959.946 |  7348.598 | 15714.119 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Base_Basic         |       270.466 |          |   264.583 |   364.812 |   461.948 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Base               |       269.210 |          |   264.783 |   363.942 |   461.796 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Arm                |               |          |  3790.584 |  3951.851 |  8772.532 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Arm_Combine        |               |          |           |           |  4213.244 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Sse_Combine        |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | Sum128Sse_Permute        |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | Sum128Sse_PermuteLonger  |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | Sum128Traits             |       268.496 |          |  8720.995 |  8757.629 | 15736.174 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Traits_ArgsT       |       262.351 |          |  5193.383 | 10757.624 | 15726.714 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Base_Basic         |       283.400 |          |   282.029 |   241.230 |   523.550 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Base               |       273.684 |          |   263.194 |   240.562 |   523.224 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Avx2_Combine       |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | Sum256Avx2_Permute       |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | Sum256Avx2_PermuteLonger |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Byte  | Sum256Traits             |       245.495 |          |   252.416 |   240.416 |   523.525 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Traits_ArgsT       |       224.372 |          |   242.360 |   235.416 |   520.188 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Base_Basic         |               |          |           |           |   497.678 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Base               |               |          |           |           |   497.649 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Traits             |               |          |           |           |   497.654 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Traits_ArgsT       |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | SumBase_Basic            |       227.740 |          |   228.440 |   242.390 |   354.577 |
| YShuffleX3KernelBenchmark_Int16 | SumBase                  |       231.036 |          |   231.609 |   242.650 |   354.401 |
| YShuffleX3KernelBenchmark_Int16 | SumTraits                |       232.129 |          |  2710.362 |  2985.313 |  7599.716 |
| YShuffleX3KernelBenchmark_Int16 | SumTraits_Args           |       230.537 |          |  3928.863 |  4277.223 |  7576.787 |
| YShuffleX3KernelBenchmark_Int16 | SumTraits_ArgsT          |       227.244 |          |  1934.546 |  3708.104 |  7608.203 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Base_Basic         |       176.214 |          |   177.571 |   241.872 |   354.554 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Base               |       175.816 |          |   175.971 |   241.120 |   354.086 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Arm                |               |          |  1330.437 |  1337.721 |  3413.637 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Arm_Combine        |               |          |           |           |  1736.140 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Sse_Combine        |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | Sum128Sse_Permute        |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | Sum128Sse_PermuteLonger  |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | Sum128Traits             |       176.078 |          |  3036.889 |  3118.418 |  7727.751 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Traits_ArgsT       |       170.014 |          |  2493.940 |  4969.803 |  7737.969 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Base_Basic         |       147.509 |          |   163.614 |   176.076 |   438.203 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Base               |       140.907 |          |   168.025 |   175.445 |   437.669 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Avx2_Combine       |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | Sum256Avx2_Permute       |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | Sum256Avx2_PermuteLonger |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Int16 | Sum256Traits             |       125.316 |          |   168.250 |   175.164 |   437.688 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Traits_ArgsT       |       116.713 |          |   157.260 |   169.299 |   438.256 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Base_Basic         |               |          |           |           |   400.867 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Base               |               |          |           |           |   400.710 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Traits             |               |          |           |           |   400.652 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Traits_ArgsT       |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | SumBase_Basic            |       176.719 |          |   159.648 |   161.518 |   262.331 |
| YShuffleX3KernelBenchmark_Int32 | SumBase                  |       175.852 |          |   156.654 |   162.972 |   262.129 |
| YShuffleX3KernelBenchmark_Int32 | SumTraits                |       174.838 |          |  1264.258 |  1464.187 |  3815.715 |
| YShuffleX3KernelBenchmark_Int32 | SumTraits_Args           |       170.258 |          |  1744.623 |  2126.057 |  3799.010 |
| YShuffleX3KernelBenchmark_Int32 | SumTraits_ArgsT          |       160.216 |          |   904.500 |  1852.061 |  3809.804 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Base_Basic         |       113.893 |          |   113.791 |   162.780 |   262.330 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Base               |       114.625 |          |   114.569 |   162.530 |   262.092 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Arm                |               |          |   610.943 |   668.379 |  1727.097 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Arm_Combine        |               |          |           |           |   856.791 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_Combine        |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_CombineAvx     |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_Permute        |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_PermuteLonger  |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum128Traits             |       115.308 |          |  1318.912 |  1555.300 |  3818.549 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Traits_ArgsT       |       111.846 |          |  1246.575 |  2480.452 |  3822.945 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Base_Basic         |        89.635 |          |   101.530 |   127.369 |   374.037 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Base               |        85.184 |          |   104.740 |   126.275 |   372.425 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Avx2_Combine       |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum256Avx2_Permute       |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum256Avx2_PermuteLonger |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Int32 | Sum256Traits             |        74.415 |          |   104.957 |   126.611 |   373.409 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Traits_ArgsT       |        68.438 |          |    95.346 |   120.210 |   367.629 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Base_Basic         |               |          |           |           |   310.388 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Base               |               |          |           |           |   310.328 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Traits             |               |          |           |           |   310.110 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Traits_ArgsT       |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | SumBase_Basic            |       106.581 |          |    93.187 |    86.329 |   265.930 |
| YShuffleX3KernelBenchmark_Int64 | SumBase                  |       106.971 |          |    91.408 |    86.546 |   265.898 |
| YShuffleX3KernelBenchmark_Int64 | SumTraits                |       105.718 |          |   655.340 |   687.476 |  1895.599 |
| YShuffleX3KernelBenchmark_Int64 | SumTraits_Args           |       105.224 |          |   979.062 |  1049.816 |  1909.419 |
| YShuffleX3KernelBenchmark_Int64 | SumTraits_ArgsT          |        97.829 |          |   482.798 |   925.172 |  1898.203 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Base_Basic         |        88.156 |          |    81.743 |    88.986 |   263.950 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Base               |        88.012 |          |    80.905 |    89.158 |   266.081 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Arm                |               |          |   298.323 |   321.593 |   862.145 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Arm_Combine        |               |          |           |           |   432.572 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_Combine        |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_CombineAvx     |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_Permute        |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_PermuteLonger  |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum128Traits             |        87.828 |          |   722.035 |   728.447 |  1908.051 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Traits_ArgsT       |        82.104 |          |   623.970 |  1408.715 |  1897.934 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Base_Basic         |        53.164 |          |    69.783 |    79.947 |   350.302 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Base               |        50.759 |          |    69.431 |    79.294 |   351.529 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Avx2_Combine       |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum256Avx2_Permute       |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum256Avx2_PermuteLonger |               |          |           |           |           |
| YShuffleX3KernelBenchmark_Int64 | Sum256Traits             |        43.257 |          |    69.527 |    79.445 |   353.820 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Traits_ArgsT       |        39.184 |          |    61.793 |    74.894 |   351.915 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Base_Basic         |               |          |           |           |   209.282 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Base               |               |          |           |           |   209.281 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Traits             |               |          |           |           |   209.272 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Traits_ArgsT       |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | SumBase_Basic            |       351.902 |          |   348.059 |   349.004 |   457.224 |
| YShuffleX4KernelBenchmark_Byte  | SumBase                  |       352.340 |          |   346.394 |   348.280 |   457.095 |
| YShuffleX4KernelBenchmark_Byte  | SumTraits                |       354.132 |          |  5579.822 |  5325.211 | 11334.310 |
| YShuffleX4KernelBenchmark_Byte  | SumTraits_Args           |       349.533 |          |  6395.898 |  6755.285 | 11336.194 |
| YShuffleX4KernelBenchmark_Byte  | SumTraits_ArgsT          |       340.117 |          |  3304.861 |  5607.999 | 11335.291 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Base_Basic         |       259.979 |          |   257.136 |   353.708 |   453.549 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Base               |       257.845 |          |   256.991 |   351.188 |   454.582 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Arm                |               |          |  2704.058 |  2821.190 |  6625.167 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Arm_Combine        |               |          |           |           |  3098.624 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Sse_Combine        |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | Sum128Sse_Permute        |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | Sum128Sse_PermuteLonger  |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | Sum128Traits             |       258.645 |          |  6199.346 |  6440.299 | 11333.914 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Traits_ArgsT       |       255.092 |          |  4656.861 |  8449.667 | 11331.906 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Base_Basic         |       275.447 |          |   263.806 |   233.702 |   547.133 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Base               |       259.817 |          |   241.058 |   232.756 |   547.054 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Avx2_Combine       |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | Sum256Avx2_Permute       |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | Sum256Avx2_PermuteLonger |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Byte  | Sum256Traits             |       231.113 |          |   234.230 |   232.939 |   547.043 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Traits_ArgsT       |       212.113 |          |   225.727 |   228.199 |   532.195 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Base_Basic         |               |          |           |           |   470.999 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Base               |               |          |           |           |   471.176 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Traits             |               |          |           |           |   471.074 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Traits_ArgsT       |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | SumBase_Basic            |       222.574 |          |   223.357 |   228.526 |   348.263 |
| YShuffleX4KernelBenchmark_Int16 | SumBase                  |       225.304 |          |   224.708 |   230.734 |   348.261 |
| YShuffleX4KernelBenchmark_Int16 | SumTraits                |       225.334 |          |  2053.060 |  2236.339 |  5645.131 |
| YShuffleX4KernelBenchmark_Int16 | SumTraits_Args           |       224.983 |          |  3185.819 |  3441.293 |  5643.424 |
| YShuffleX4KernelBenchmark_Int16 | SumTraits_ArgsT          |       213.571 |          |  1615.303 |  2858.918 |  5644.834 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Base_Basic         |       165.534 |          |   166.118 |   233.930 |   347.697 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Base               |       165.151 |          |   164.048 |   234.658 |   347.321 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Arm                |               |          |  1031.880 |   953.661 |  3012.599 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Arm_Combine        |               |          |           |           |  1288.223 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Sse_Combine        |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | Sum128Sse_Permute        |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | Sum128Sse_PermuteLonger  |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | Sum128Traits             |       165.500 |          |  2027.071 |  2339.704 |  5640.886 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Traits_ArgsT       |       161.130 |          |  2253.983 |  4276.815 |  5640.599 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Base_Basic         |       134.736 |          |   151.230 |   165.681 |   461.590 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Base               |       129.068 |          |   151.451 |   165.973 |   461.419 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Avx2_Combine       |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | Sum256Avx2_Permute       |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | Sum256Avx2_PermuteLonger |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Int16 | Sum256Traits             |       114.520 |          |   148.714 |   165.416 |   461.548 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Traits_ArgsT       |       104.215 |          |   142.132 |   159.659 |   450.406 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Base_Basic         |               |          |           |           |   372.064 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Base               |               |          |           |           |   371.965 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Traits             |               |          |           |           |   371.665 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Traits_ArgsT       |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Int32 | SumBase_Basic            |       160.776 |          |   141.131 |   141.177 |   256.295 |
| YShuffleX4KernelBenchmark_Int32 | SumBase                  |       162.337 |          |   140.618 |   144.668 |   256.570 |
| YShuffleX4KernelBenchmark_Int32 | SumTraits                |       165.335 |          |   939.986 |  1111.099 |  2812.365 |
| YShuffleX4KernelBenchmark_Int32 | SumTraits_Args           |       165.097 |          |  1309.331 |  1689.377 |  2814.789 |
| YShuffleX4KernelBenchmark_Int32 | SumTraits_ArgsT          |       154.183 |          |   736.866 |  1419.144 |  2809.911 |
| YShuffleX4KernelBenchmark_Int32 | Sum128Base_Basic         |       106.322 |          |   107.183 |   150.016 |   256.489 |
| YShuffleX4KernelBenchmark_Int32 | Sum128Base               |       107.295 |          |   107.087 |   149.543 |   256.571 |
| YShuffleX4KernelBenchmark_Int32 | Sum128Arm                |               |          |   438.023 |   482.266 |  1476.396 |
| YShuffleX4KernelBenchmark_Int32 | Sum128Arm_Combine        |               |          |           |           |   651.824 |
| YShuffleX4KernelBenchmark_Int32 | Sum128Sse_Combine        |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Int32 | Sum128Sse_CombineAvx     |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Int32 | Sum128Sse_Permute        |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Int32 | Sum128Sse_PermuteLonger  |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Int32 | Sum128Traits             |       106.497 |          |  1012.739 |  1147.402 |  2813.408 |
| YShuffleX4KernelBenchmark_Int32 | Sum128Traits_ArgsT       |        99.223 |          |  1123.800 |  2040.408 |  2812.774 |
| YShuffleX4KernelBenchmark_Int32 | Sum256Base_Basic         |        80.954 |          |    92.240 |   117.378 |   417.042 |
| YShuffleX4KernelBenchmark_Int32 | Sum256Base               |        76.561 |          |    91.193 |   117.276 |   417.296 |
| YShuffleX4KernelBenchmark_Int32 | Sum256Avx2_Combine       |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Int32 | Sum256Avx2_Permute       |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Int32 | Sum256Avx2_PermuteLonger |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Int32 | Sum256Traits             |        66.514 |          |    91.537 |   117.435 |   417.300 |
| YShuffleX4KernelBenchmark_Int32 | Sum256Traits_ArgsT       |        60.220 |          |    84.458 |   107.110 |   392.957 |
| YShuffleX4KernelBenchmark_Int32 | Sum512Base_Basic         |               |          |           |           |   272.115 |
| YShuffleX4KernelBenchmark_Int32 | Sum512Base               |               |          |           |           |   271.927 |
| YShuffleX4KernelBenchmark_Int32 | Sum512Traits             |               |          |           |           |   271.933 |
| YShuffleX4KernelBenchmark_Int32 | Sum512Traits_ArgsT       |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Int64 | SumBase_Basic            |        92.606 |          |    85.804 |    78.782 |   246.954 |
| YShuffleX4KernelBenchmark_Int64 | SumBase                  |        93.063 |          |    86.280 |    78.772 |   247.476 |
| YShuffleX4KernelBenchmark_Int64 | SumTraits                |        92.075 |          |   491.914 |   528.679 |  1409.227 |
| YShuffleX4KernelBenchmark_Int64 | SumTraits_Args           |        91.927 |          |   777.903 |   854.090 |  1409.096 |
| YShuffleX4KernelBenchmark_Int64 | SumTraits_ArgsT          |        85.123 |          |   405.730 |   703.165 |  1408.695 |
| YShuffleX4KernelBenchmark_Int64 | Sum128Base_Basic         |        78.778 |          |    75.648 |    82.232 |   243.818 |
| YShuffleX4KernelBenchmark_Int64 | Sum128Base               |        77.765 |          |    75.532 |    82.126 |   243.950 |
| YShuffleX4KernelBenchmark_Int64 | Sum128Arm                |               |          |   239.164 |   225.796 |   737.740 |
| YShuffleX4KernelBenchmark_Int64 | Sum128Arm_Combine        |               |          |           |           |   322.371 |
| YShuffleX4KernelBenchmark_Int64 | Sum128Sse_Combine        |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Int64 | Sum128Sse_CombineAvx     |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Int64 | Sum128Sse_Permute        |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Int64 | Sum128Sse_PermuteLonger  |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Int64 | Sum128Traits             |        78.408 |          |   557.237 |   566.174 |  1408.116 |
| YShuffleX4KernelBenchmark_Int64 | Sum128Traits_ArgsT       |        75.211 |          |   562.575 |  1067.663 |  1408.456 |
| YShuffleX4KernelBenchmark_Int64 | Sum256Base_Basic         |        47.473 |          |    58.861 |    72.964 |   306.614 |
| YShuffleX4KernelBenchmark_Int64 | Sum256Base               |        44.046 |          |    58.918 |    72.787 |   306.694 |
| YShuffleX4KernelBenchmark_Int64 | Sum256Avx2_Combine       |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Int64 | Sum256Avx2_Permute       |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Int64 | Sum256Avx2_PermuteLonger |               |          |           |           |           |
| YShuffleX4KernelBenchmark_Int64 | Sum256Traits             |        37.871 |          |    59.226 |    72.833 |   306.767 |
| YShuffleX4KernelBenchmark_Int64 | Sum256Traits_ArgsT       |        33.936 |          |    52.929 |    68.172 |   297.281 |
| YShuffleX4KernelBenchmark_Int64 | Sum512Base_Basic         |               |          |           |           |   179.158 |
| YShuffleX4KernelBenchmark_Int64 | Sum512Base               |               |          |           |           |   179.182 |
| YShuffleX4KernelBenchmark_Int64 | Sum512Traits             |               |          |           |           |   178.346 |
| YShuffleX4KernelBenchmark_Int64 | Sum512Traits_ArgsT       |               |          |           |           |           |

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

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                            | Method                   | .NET 8.0 |
| :------------------------------ | :----------------------- | -------: |
| YShuffleX2KernelBenchmark_Byte  | SumBase_Basic            |   12.882 |
| YShuffleX2KernelBenchmark_Byte  | SumBase                  |   12.654 |
| YShuffleX2KernelBenchmark_Byte  | SumTraits                |  121.405 |
| YShuffleX2KernelBenchmark_Byte  | SumTraits_Args           |  107.777 |
| YShuffleX2KernelBenchmark_Byte  | SumTraits_ArgsT          |   77.072 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Base_Basic         |   12.832 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Base               |   92.318 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Arm                |          |
| YShuffleX2KernelBenchmark_Byte  | Sum128Arm_Combine        |          |
| YShuffleX2KernelBenchmark_Byte  | Sum128Sse_Combine        |          |
| YShuffleX2KernelBenchmark_Byte  | Sum128Traits             |  159.745 |
| YShuffleX2KernelBenchmark_Byte  | Sum128Traits_ArgsT       |   96.347 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Base_Basic         |   14.490 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Base               |   14.681 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Avx2_Combine       |          |
| YShuffleX2KernelBenchmark_Byte  | Sum256Avx2_Combine2      |          |
| YShuffleX2KernelBenchmark_Byte  | Sum256Avx2_Combine3      |          |
| YShuffleX2KernelBenchmark_Byte  | Sum256Traits             |   14.048 |
| YShuffleX2KernelBenchmark_Byte  | Sum256Traits_ArgsT       |   13.328 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Base_Basic         |   16.476 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Base               |   16.644 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Traits             |   15.788 |
| YShuffleX2KernelBenchmark_Byte  | Sum512Traits_ArgsT       |          |
| YShuffleX2KernelBenchmark_Int16 | SumBase_Basic            |    9.222 |
| YShuffleX2KernelBenchmark_Int16 | SumBase                  |    5.621 |
| YShuffleX2KernelBenchmark_Int16 | SumTraits                |   30.031 |
| YShuffleX2KernelBenchmark_Int16 | SumTraits_Args           |   34.554 |
| YShuffleX2KernelBenchmark_Int16 | SumTraits_ArgsT          |   26.858 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Base_Basic         |    5.733 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Base               |   34.868 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Arm                |          |
| YShuffleX2KernelBenchmark_Int16 | Sum128Arm_Combine        |          |
| YShuffleX2KernelBenchmark_Int16 | Sum128Sse_Combine        |          |
| YShuffleX2KernelBenchmark_Int16 | Sum128Traits             |   36.396 |
| YShuffleX2KernelBenchmark_Int16 | Sum128Traits_ArgsT       |   29.256 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Base_Basic         |    7.008 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Base               |    6.673 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Avx2_Combine       |          |
| YShuffleX2KernelBenchmark_Int16 | Sum256Traits             |    6.183 |
| YShuffleX2KernelBenchmark_Int16 | Sum256Traits_ArgsT       |    5.913 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Base_Basic         |    7.793 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Base               |    7.765 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Traits             |    7.104 |
| YShuffleX2KernelBenchmark_Int16 | Sum512Traits_ArgsT       |          |
| YShuffleX2KernelBenchmark_Int32 | SumBase_Basic            |    3.820 |
| YShuffleX2KernelBenchmark_Int32 | SumBase                  |    3.710 |
| YShuffleX2KernelBenchmark_Int32 | SumTraits                |   14.372 |
| YShuffleX2KernelBenchmark_Int32 | SumTraits_Args           |   16.665 |
| YShuffleX2KernelBenchmark_Int32 | SumTraits_ArgsT          |   12.755 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Base_Basic         |    3.767 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Base               |   21.600 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Arm                |          |
| YShuffleX2KernelBenchmark_Int32 | Sum128Arm_Combine        |          |
| YShuffleX2KernelBenchmark_Int32 | Sum128Sse_Combine        |          |
| YShuffleX2KernelBenchmark_Int32 | Sum128Traits             |   18.657 |
| YShuffleX2KernelBenchmark_Int32 | Sum128Traits_ArgsT       |   15.643 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Base_Basic         |    4.461 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Base               |    4.554 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Avx2_Combine       |          |
| YShuffleX2KernelBenchmark_Int32 | Sum256Traits             |    4.095 |
| YShuffleX2KernelBenchmark_Int32 | Sum256Traits_ArgsT       |    3.732 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Base_Basic         |    5.509 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Base               |    5.427 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Traits             |    5.099 |
| YShuffleX2KernelBenchmark_Int32 | Sum512Traits_ArgsT       |          |
| YShuffleX2KernelBenchmark_Int64 | SumBase_Basic            |    1.638 |
| YShuffleX2KernelBenchmark_Int64 | SumBase                  |    1.705 |
| YShuffleX2KernelBenchmark_Int64 | SumTraits                |    3.707 |
| YShuffleX2KernelBenchmark_Int64 | SumTraits_Args           |    4.326 |
| YShuffleX2KernelBenchmark_Int64 | SumTraits_ArgsT          |    3.665 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Base_Basic         |    1.305 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Base               |    1.249 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Arm                |          |
| YShuffleX2KernelBenchmark_Int64 | Sum128Arm_Combine        |          |
| YShuffleX2KernelBenchmark_Int64 | Sum128Sse_Combine        |          |
| YShuffleX2KernelBenchmark_Int64 | Sum128Traits             |    7.064 |
| YShuffleX2KernelBenchmark_Int64 | Sum128Traits_ArgsT       |    8.048 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Base_Basic         |    1.518 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Base               |    1.426 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Avx2_Combine       |          |
| YShuffleX2KernelBenchmark_Int64 | Sum256Traits             |    2.048 |
| YShuffleX2KernelBenchmark_Int64 | Sum256Traits_ArgsT       |    1.944 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Base_Basic         |    1.673 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Base               |    1.640 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Traits             |    2.829 |
| YShuffleX2KernelBenchmark_Int64 | Sum512Traits_ArgsT       |          |
| YShuffleX3KernelBenchmark_Byte  | SumBase_Basic            |    7.889 |
| YShuffleX3KernelBenchmark_Byte  | SumBase                  |    7.985 |
| YShuffleX3KernelBenchmark_Byte  | SumTraits                |   55.206 |
| YShuffleX3KernelBenchmark_Byte  | SumTraits_Args           |   48.169 |
| YShuffleX3KernelBenchmark_Byte  | SumTraits_ArgsT          |   42.719 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Base_Basic         |    7.862 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Base               |   42.835 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Arm                |          |
| YShuffleX3KernelBenchmark_Byte  | Sum128Arm_Combine        |          |
| YShuffleX3KernelBenchmark_Byte  | Sum128Sse_Combine        |          |
| YShuffleX3KernelBenchmark_Byte  | Sum128Sse_Permute        |          |
| YShuffleX3KernelBenchmark_Byte  | Sum128Sse_PermuteLonger  |          |
| YShuffleX3KernelBenchmark_Byte  | Sum128Traits             |   78.933 |
| YShuffleX3KernelBenchmark_Byte  | Sum128Traits_ArgsT       |   55.279 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Base_Basic         |    9.312 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Base               |    9.068 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Avx2_Combine       |          |
| YShuffleX3KernelBenchmark_Byte  | Sum256Avx2_Permute       |          |
| YShuffleX3KernelBenchmark_Byte  | Sum256Avx2_PermuteLonger |          |
| YShuffleX3KernelBenchmark_Byte  | Sum256Traits             |    8.757 |
| YShuffleX3KernelBenchmark_Byte  | Sum256Traits_ArgsT       |    8.528 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Base_Basic         |   10.335 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Base               |    9.744 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Traits             |    9.712 |
| YShuffleX3KernelBenchmark_Byte  | Sum512Traits_ArgsT       |          |
| YShuffleX3KernelBenchmark_Int16 | SumBase_Basic            |    5.549 |
| YShuffleX3KernelBenchmark_Int16 | SumBase                  |    5.490 |
| YShuffleX3KernelBenchmark_Int16 | SumTraits                |   21.555 |
| YShuffleX3KernelBenchmark_Int16 | SumTraits_Args           |   23.456 |
| YShuffleX3KernelBenchmark_Int16 | SumTraits_ArgsT          |   21.040 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Base_Basic         |    5.467 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Base               |   26.524 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Arm                |          |
| YShuffleX3KernelBenchmark_Int16 | Sum128Arm_Combine        |          |
| YShuffleX3KernelBenchmark_Int16 | Sum128Sse_Combine        |          |
| YShuffleX3KernelBenchmark_Int16 | Sum128Sse_Permute        |          |
| YShuffleX3KernelBenchmark_Int16 | Sum128Sse_PermuteLonger  |          |
| YShuffleX3KernelBenchmark_Int16 | Sum128Traits             |   29.379 |
| YShuffleX3KernelBenchmark_Int16 | Sum128Traits_ArgsT       |   27.984 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Base_Basic         |    6.718 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Base               |    6.543 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Avx2_Combine       |          |
| YShuffleX3KernelBenchmark_Int16 | Sum256Avx2_Permute       |          |
| YShuffleX3KernelBenchmark_Int16 | Sum256Avx2_PermuteLonger |          |
| YShuffleX3KernelBenchmark_Int16 | Sum256Traits             |    5.966 |
| YShuffleX3KernelBenchmark_Int16 | Sum256Traits_ArgsT       |    5.483 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Base_Basic         |    7.531 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Base               |    7.435 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Traits             |    7.649 |
| YShuffleX3KernelBenchmark_Int16 | Sum512Traits_ArgsT       |          |
| YShuffleX3KernelBenchmark_Int32 | SumBase_Basic            |    3.510 |
| YShuffleX3KernelBenchmark_Int32 | SumBase                  |    3.409 |
| YShuffleX3KernelBenchmark_Int32 | SumTraits                |   11.667 |
| YShuffleX3KernelBenchmark_Int32 | SumTraits_Args           |   11.365 |
| YShuffleX3KernelBenchmark_Int32 | SumTraits_ArgsT          |   10.041 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Base_Basic         |    3.397 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Base               |   14.042 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Arm                |          |
| YShuffleX3KernelBenchmark_Int32 | Sum128Arm_Combine        |          |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_Combine        |          |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_CombineAvx     |          |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_Permute        |          |
| YShuffleX3KernelBenchmark_Int32 | Sum128Sse_PermuteLonger  |          |
| YShuffleX3KernelBenchmark_Int32 | Sum128Traits             |   13.749 |
| YShuffleX3KernelBenchmark_Int32 | Sum128Traits_ArgsT       |   13.998 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Base_Basic         |    4.547 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Base               |    4.279 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Avx2_Combine       |          |
| YShuffleX3KernelBenchmark_Int32 | Sum256Avx2_Permute       |          |
| YShuffleX3KernelBenchmark_Int32 | Sum256Avx2_PermuteLonger |          |
| YShuffleX3KernelBenchmark_Int32 | Sum256Traits             |    3.742 |
| YShuffleX3KernelBenchmark_Int32 | Sum256Traits_ArgsT       |    3.489 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Base_Basic         |    5.265 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Base               |    5.036 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Traits             |    4.843 |
| YShuffleX3KernelBenchmark_Int32 | Sum512Traits_ArgsT       |          |
| YShuffleX3KernelBenchmark_Int64 | SumBase_Basic            |    2.522 |
| YShuffleX3KernelBenchmark_Int64 | SumBase                  |    2.572 |
| YShuffleX3KernelBenchmark_Int64 | SumTraits                |    4.728 |
| YShuffleX3KernelBenchmark_Int64 | SumTraits_Args           |    5.616 |
| YShuffleX3KernelBenchmark_Int64 | SumTraits_ArgsT          |    5.397 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Base_Basic         |    1.948 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Base               |    1.426 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Arm                |          |
| YShuffleX3KernelBenchmark_Int64 | Sum128Arm_Combine        |          |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_Combine        |          |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_CombineAvx     |          |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_Permute        |          |
| YShuffleX3KernelBenchmark_Int64 | Sum128Sse_PermuteLonger  |          |
| YShuffleX3KernelBenchmark_Int64 | Sum128Traits             |   10.136 |
| YShuffleX3KernelBenchmark_Int64 | Sum128Traits_ArgsT       |   11.616 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Base_Basic         |    2.267 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Base               |    2.280 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Avx2_Combine       |          |
| YShuffleX3KernelBenchmark_Int64 | Sum256Avx2_Permute       |          |
| YShuffleX3KernelBenchmark_Int64 | Sum256Avx2_PermuteLonger |          |
| YShuffleX3KernelBenchmark_Int64 | Sum256Traits             |    3.010 |
| YShuffleX3KernelBenchmark_Int64 | Sum256Traits_ArgsT       |    2.750 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Base_Basic         |    2.605 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Base               |    2.575 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Traits             |    4.299 |
| YShuffleX3KernelBenchmark_Int64 | Sum512Traits_ArgsT       |          |
| YShuffleX4KernelBenchmark_Byte  | SumBase_Basic            |   12.222 |
| YShuffleX4KernelBenchmark_Byte  | SumBase                  |   11.956 |
| YShuffleX4KernelBenchmark_Byte  | SumTraits                |   61.802 |
| YShuffleX4KernelBenchmark_Byte  | SumTraits_Args           |   57.892 |
| YShuffleX4KernelBenchmark_Byte  | SumTraits_ArgsT          |   59.061 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Base_Basic         |   11.963 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Base               |   49.325 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Arm                |          |
| YShuffleX4KernelBenchmark_Byte  | Sum128Arm_Combine        |          |
| YShuffleX4KernelBenchmark_Byte  | Sum128Sse_Combine        |          |
| YShuffleX4KernelBenchmark_Byte  | Sum128Sse_Permute        |          |
| YShuffleX4KernelBenchmark_Byte  | Sum128Sse_PermuteLonger  |          |
| YShuffleX4KernelBenchmark_Byte  | Sum128Traits             |   87.785 |
| YShuffleX4KernelBenchmark_Byte  | Sum128Traits_ArgsT       |   79.828 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Base_Basic         |   14.125 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Base               |   13.789 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Avx2_Combine       |          |
| YShuffleX4KernelBenchmark_Byte  | Sum256Avx2_Permute       |          |
| YShuffleX4KernelBenchmark_Byte  | Sum256Avx2_PermuteLonger |          |
| YShuffleX4KernelBenchmark_Byte  | Sum256Traits             |   13.286 |
| YShuffleX4KernelBenchmark_Byte  | Sum256Traits_ArgsT       |   12.057 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Base_Basic         |   15.664 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Base               |   16.324 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Traits             |   16.103 |
| YShuffleX4KernelBenchmark_Byte  | Sum512Traits_ArgsT       |          |
| YShuffleX4KernelBenchmark_Int16 | SumBase_Basic            |    8.600 |
| YShuffleX4KernelBenchmark_Int16 | SumBase                  |    8.317 |
| YShuffleX4KernelBenchmark_Int16 | SumTraits                |   29.807 |
| YShuffleX4KernelBenchmark_Int16 | SumTraits_Args           |   29.856 |
| YShuffleX4KernelBenchmark_Int16 | SumTraits_ArgsT          |   29.510 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Base_Basic         |    8.477 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Base               |   35.008 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Arm                |          |
| YShuffleX4KernelBenchmark_Int16 | Sum128Arm_Combine        |          |
| YShuffleX4KernelBenchmark_Int16 | Sum128Sse_Combine        |          |
| YShuffleX4KernelBenchmark_Int16 | Sum128Sse_Permute        |          |
| YShuffleX4KernelBenchmark_Int16 | Sum128Sse_PermuteLonger  |          |
| YShuffleX4KernelBenchmark_Int16 | Sum128Traits             |   33.235 |
| YShuffleX4KernelBenchmark_Int16 | Sum128Traits_ArgsT       |   39.291 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Base_Basic         |   10.032 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Base               |   10.474 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Avx2_Combine       |          |
| YShuffleX4KernelBenchmark_Int16 | Sum256Avx2_Permute       |          |
| YShuffleX4KernelBenchmark_Int16 | Sum256Avx2_PermuteLonger |          |
| YShuffleX4KernelBenchmark_Int16 | Sum256Traits             |    8.872 |
| YShuffleX4KernelBenchmark_Int16 | Sum256Traits_ArgsT       |    8.503 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Base_Basic         |   12.390 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Base               |   12.552 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Traits             |   11.500 |
| YShuffleX4KernelBenchmark_Int16 | Sum512Traits_ArgsT       |          |
| YShuffleX4KernelBenchmark_Int32 | SumBase_Basic            |    5.436 |
| YShuffleX4KernelBenchmark_Int32 | SumBase                  |    5.260 |
| YShuffleX4KernelBenchmark_Int32 | SumTraits                |   13.677 |
| YShuffleX4KernelBenchmark_Int32 | SumTraits_Args           |   14.790 |
| YShuffleX4KernelBenchmark_Int32 | SumTraits_ArgsT          |   14.660 |
| YShuffleX4KernelBenchmark_Int32 | Sum128Base_Basic         |    5.319 |
| YShuffleX4KernelBenchmark_Int32 | Sum128Base               |   21.065 |
| YShuffleX4KernelBenchmark_Int32 | Sum128Arm                |          |
| YShuffleX4KernelBenchmark_Int32 | Sum128Arm_Combine        |          |
| YShuffleX4KernelBenchmark_Int32 | Sum128Sse_Combine        |          |
| YShuffleX4KernelBenchmark_Int32 | Sum128Sse_CombineAvx     |          |
| YShuffleX4KernelBenchmark_Int32 | Sum128Sse_Permute        |          |
| YShuffleX4KernelBenchmark_Int32 | Sum128Sse_PermuteLonger  |          |
| YShuffleX4KernelBenchmark_Int32 | Sum128Traits             |   16.205 |
| YShuffleX4KernelBenchmark_Int32 | Sum128Traits_ArgsT       |   18.907 |
| YShuffleX4KernelBenchmark_Int32 | Sum256Base_Basic         |    6.849 |
| YShuffleX4KernelBenchmark_Int32 | Sum256Base               |    6.798 |
| YShuffleX4KernelBenchmark_Int32 | Sum256Avx2_Combine       |          |
| YShuffleX4KernelBenchmark_Int32 | Sum256Avx2_Permute       |          |
| YShuffleX4KernelBenchmark_Int32 | Sum256Avx2_PermuteLonger |          |
| YShuffleX4KernelBenchmark_Int32 | Sum256Traits             |    5.609 |
| YShuffleX4KernelBenchmark_Int32 | Sum256Traits_ArgsT       |    5.287 |
| YShuffleX4KernelBenchmark_Int32 | Sum512Base_Basic         |    8.370 |
| YShuffleX4KernelBenchmark_Int32 | Sum512Base               |    8.434 |
| YShuffleX4KernelBenchmark_Int32 | Sum512Traits             |    7.479 |
| YShuffleX4KernelBenchmark_Int32 | Sum512Traits_ArgsT       |          |
| YShuffleX4KernelBenchmark_Int64 | SumBase_Basic            |    2.372 |
| YShuffleX4KernelBenchmark_Int64 | SumBase                  |    2.432 |
| YShuffleX4KernelBenchmark_Int64 | SumTraits                |    4.425 |
| YShuffleX4KernelBenchmark_Int64 | SumTraits_Args           |    4.626 |
| YShuffleX4KernelBenchmark_Int64 | SumTraits_ArgsT          |    4.730 |
| YShuffleX4KernelBenchmark_Int64 | Sum128Base_Basic         |    1.930 |
| YShuffleX4KernelBenchmark_Int64 | Sum128Base               |    1.056 |
| YShuffleX4KernelBenchmark_Int64 | Sum128Arm                |          |
| YShuffleX4KernelBenchmark_Int64 | Sum128Arm_Combine        |          |
| YShuffleX4KernelBenchmark_Int64 | Sum128Sse_Combine        |          |
| YShuffleX4KernelBenchmark_Int64 | Sum128Sse_CombineAvx     |          |
| YShuffleX4KernelBenchmark_Int64 | Sum128Sse_Permute        |          |
| YShuffleX4KernelBenchmark_Int64 | Sum128Sse_PermuteLonger  |          |
| YShuffleX4KernelBenchmark_Int64 | Sum128Traits             |    7.980 |
| YShuffleX4KernelBenchmark_Int64 | Sum128Traits_ArgsT       |    9.916 |
| YShuffleX4KernelBenchmark_Int64 | Sum256Base_Basic         |    2.193 |
| YShuffleX4KernelBenchmark_Int64 | Sum256Base               |    2.163 |
| YShuffleX4KernelBenchmark_Int64 | Sum256Avx2_Combine       |          |
| YShuffleX4KernelBenchmark_Int64 | Sum256Avx2_Permute       |          |
| YShuffleX4KernelBenchmark_Int64 | Sum256Avx2_PermuteLonger |          |
| YShuffleX4KernelBenchmark_Int64 | Sum256Traits             |    2.821 |
| YShuffleX4KernelBenchmark_Int64 | Sum256Traits_ArgsT       |    2.699 |
| YShuffleX4KernelBenchmark_Int64 | Sum512Base_Basic         |    2.510 |
| YShuffleX4KernelBenchmark_Int64 | Sum512Base               |    2.532 |
| YShuffleX4KernelBenchmark_Int64 | Sum512Traits             |    4.211 |
| YShuffleX4KernelBenchmark_Int64 | Sum512Traits_ArgsT       |          |

