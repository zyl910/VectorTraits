# Benchmark group - ShiftLeft
([← Back](ShiftLeft.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

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

### Arm - AWS Arm t4g.small
| Type                          | Method                   | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :---------------------------- | :----------------------- | ------------: | --------: | --------: | --------: |
| ShiftLeftConstBenchmark_Byte  | SumSLLScalar             |       610.192 |   610.563 |   653.197 |   891.088 |
| ShiftLeftConstBenchmark_Byte  | SumSLLNetBcl             |               |           |           | 19580.464 |
| ShiftLeftConstBenchmark_Byte  | SumSLLNetBcl_Const       |               |           |           | 19599.073 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Basic             |      5676.064 |  5682.492 |  7048.387 | 19616.914 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Base_Core         |     14349.939 | 15797.770 | 13250.518 | 19565.182 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Multiply          |      5676.185 |  5682.654 |  7060.939 |  7400.391 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_AdvSimd           |               | 13239.258 | 13216.883 | 13231.639 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Avx2              |               |           |           |           |
| ShiftLeftConstBenchmark_Byte  | SumSLLTraits             |      5668.036 | 13252.891 | 13253.575 | 13241.598 |
| ShiftLeftConstBenchmark_Byte  | SumSLLTraits_Core        |     14341.895 | 15888.315 | 15887.520 | 19595.005 |
| ShiftLeftConstBenchmark_Byte  | SumSLLConstTraits        |      9946.663 | 13243.304 | 15895.672 | 19466.408 |
| ShiftLeftConstBenchmark_Byte  | SumSLLConstTraits_Core   |     13201.657 | 15896.748 | 15894.093 | 19447.318 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_Multiply      |      9946.629 |  9954.522 | 11121.366 | 11437.932 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_AdvSimd       |               | 15893.590 | 17022.639 | 19613.913 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_Avx2          |               |           |           |           |
| ShiftLeftConstBenchmark_Byte  | SumSLLFastTraits         |      9937.536 | 15892.019 | 17010.920 | 19595.664 |
| ShiftLeftConstBenchmark_Int16 | SumSLLScalar             |       606.942 |   607.226 |   607.742 |   765.154 |
| ShiftLeftConstBenchmark_Int16 | SumSLLNetBcl             |               |           |           |  9332.186 |
| ShiftLeftConstBenchmark_Int16 | SumSLLNetBcl_Const       |               |           |           |  9240.256 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Basic             |      4225.475 |  4164.512 |  5627.246 |  9350.349 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core         |      7876.033 |  7872.607 |  7876.791 |  9418.617 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core_Element |      3961.926 |  4311.659 |  5271.394 |  6698.495 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core_Mov     |      4236.260 |  3969.535 |  5113.562 |  7452.238 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Multiply          |      4239.837 |  4317.808 |  5640.580 |  5728.366 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_AdvSimd           |               |  6580.871 |  6564.405 |  6136.411 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Avx2              |               |           |           |           |
| ShiftLeftConstBenchmark_Int16 | SumSLLTraits             |      4231.310 |  6553.072 |  6603.431 |  9351.061 |
| ShiftLeftConstBenchmark_Int16 | SumSLLTraits_Core        |      7881.834 |  7897.878 |  8449.502 |  9356.142 |
| ShiftLeftConstBenchmark_Int16 | SumSLLConstTraits        |      6577.829 |  6620.078 |  8444.304 |  9359.246 |
| ShiftLeftConstBenchmark_Int16 | SumSLLConstTraits_Core   |      8383.107 |  7923.119 |  8443.802 |  9317.663 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_Multiply      |      5532.640 |  5535.524 |  6497.237 |  6830.659 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_AdvSimd       |               |  7864.969 |  8450.845 |  9550.069 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_Avx2          |               |           |           |           |
| ShiftLeftConstBenchmark_Int16 | SumSLLFastTraits         |      4975.958 |  7860.008 |  8444.011 |  9413.761 |
| ShiftLeftConstBenchmark_Int32 | SumSLLScalar             |       749.491 |   746.414 |   747.273 |  1403.533 |
| ShiftLeftConstBenchmark_Int32 | SumSLLNetBcl             |               |           |           |  4537.804 |
| ShiftLeftConstBenchmark_Int32 | SumSLLNetBcl_Const       |               |           |           |  4533.257 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Basic             |      3251.006 |  3205.726 |  3003.930 |  4604.189 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Base_Core         |      4149.315 |  4116.747 |  4125.050 |  4579.735 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Multiply          |      3235.925 |  3224.488 |  3007.593 |  3042.178 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_AdvSimd           |               |  3278.702 |  3285.599 |  3662.748 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Avx2              |               |           |           |           |
| ShiftLeftConstBenchmark_Int32 | SumSLLTraits             |      3233.214 |  3531.441 |  3530.389 |  4545.497 |
| ShiftLeftConstBenchmark_Int32 | SumSLLTraits_Core        |      3901.975 |  4140.171 |  4142.377 |  4505.555 |
| ShiftLeftConstBenchmark_Int32 | SumSLLConstTraits        |      3510.471 |  3865.285 |  4134.108 |  4568.054 |
| ShiftLeftConstBenchmark_Int32 | SumSLLConstTraits_Core   |      3905.829 |  3895.898 |  3896.719 |  4547.294 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_Multiply      |      3252.916 |  3240.639 |  3185.249 |  3496.673 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_AdvSimd       |               |  3271.777 |  3901.965 |  4879.927 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_Avx2          |               |           |           |           |
| ShiftLeftConstBenchmark_Int32 | SumSLLFastTraits         |      3507.561 |  3283.848 |  3899.394 |  4901.191 |
| ShiftLeftConstBenchmark_Int64 | SumSLLScalar             |       743.187 |   742.685 |   743.760 |  1372.299 |
| ShiftLeftConstBenchmark_Int64 | SumSLLNetBcl             |               |           |           |  2473.172 |
| ShiftLeftConstBenchmark_Int64 | SumSLLNetBcl_Const       |               |           |           |  2468.456 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Basic             |       481.402 |   477.791 |   484.694 |  2448.377 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Base_Core         |       484.225 |   479.025 |   484.531 |  2458.194 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_AdvSimd           |               |  1639.016 |  1634.294 |  1979.243 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Avx2              |               |           |           |           |
| ShiftLeftConstBenchmark_Int64 | SumSLLTraits             |       482.056 |  1637.232 |  1640.547 |  1981.831 |
| ShiftLeftConstBenchmark_Int64 | SumSLLTraits_Core        |       488.072 |  1970.152 |  2088.793 |  2468.202 |
| ShiftLeftConstBenchmark_Int64 | SumSLLConstTraits        |       467.942 |  1958.432 |  2099.095 |  2460.619 |
| ShiftLeftConstBenchmark_Int64 | SumSLLConstTraits_Core   |       470.112 |  1971.898 |  2097.693 |  2465.419 |
| ShiftLeftConstBenchmark_Int64 | SumSLLFast_AdvSimd       |               |  1959.602 |  1970.355 |  2462.124 |
| ShiftLeftConstBenchmark_Int64 | SumSLLFast_Avx2          |               |           |           |           |
| ShiftLeftConstBenchmark_Int64 | SumSLLFastTraits         |       471.224 |  1646.035 |  2101.135 |  2460.834 |

