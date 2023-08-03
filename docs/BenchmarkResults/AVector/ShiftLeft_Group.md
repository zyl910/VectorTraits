# Benchmark group - ShiftLeft
([← Back](ShiftLeft.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### x86 - lntel Core i5-8250U
| Type                          | Method                   | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :---------------------------- | :----------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| ShiftLeftConstBenchmark_Byte  | SumSLLScalar             |        853.802 |       817.528 |      1104.993 |  1118.381 |  1374.255 |  1480.225 |
| ShiftLeftConstBenchmark_Byte  | SumSLLNetBcl             |                |               |               |           |           |  1128.290 |
| ShiftLeftConstBenchmark_Byte  | SumSLLNetBcl_Const       |                |               |               |           |           |  1137.564 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Basic             |       8069.914 |      7691.254 |     14896.610 | 15086.467 | 15868.727 | 18787.783 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Base_Core         |      38503.998 |     28291.374 |     41134.136 | 39705.639 | 38750.970 | 37216.349 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Multiply          |       8395.966 |      8243.188 |     14512.566 | 15095.835 | 15628.465 | 18834.959 |
| ShiftLeftConstBenchmark_Byte  | SumSLL_AdvSimd           |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Byte  | SumSLL_Avx2              |                |               |     21122.908 | 21189.173 | 21327.063 | 23574.046 |
| ShiftLeftConstBenchmark_Byte  | SumSLLTraits             |       8296.682 |      8114.085 |     21811.573 | 19960.732 | 21044.192 | 23074.627 |
| ShiftLeftConstBenchmark_Byte  | SumSLLTraits_Core        |      33328.333 |     35503.285 |     41644.146 | 35703.816 | 36615.138 | 32872.874 |
| ShiftLeftConstBenchmark_Byte  | SumSLLConstTraits        |      10849.899 |     10168.754 |     25029.290 | 29761.737 | 33785.502 | 32862.094 |
| ShiftLeftConstBenchmark_Byte  | SumSLLConstTraits_Core   |      36537.668 |     31837.586 |     39307.523 | 35698.909 | 35679.744 | 33994.997 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_Multiply      |      11168.370 |     10294.128 |     24095.249 | 25259.278 | 24544.667 | 29608.849 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_AdvSimd       |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Byte  | SumSLLFast_Avx2          |                |               |     25132.166 | 32403.191 | 33882.537 | 33187.674 |
| ShiftLeftConstBenchmark_Byte  | SumSLLFastTraits         |      11154.884 |     10294.789 |     24859.770 | 33783.717 | 33672.008 | 32623.259 |
| ShiftLeftConstBenchmark_Int16 | SumSLLScalar             |        823.668 |       806.395 |      1176.133 |  1183.966 |  1379.498 |  1486.900 |
| ShiftLeftConstBenchmark_Int16 | SumSLLNetBcl             |                |               |               |           |           | 18445.571 |
| ShiftLeftConstBenchmark_Int16 | SumSLLNetBcl_Const       |                |               |               |           |           | 19054.243 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Basic             |       5297.801 |      5109.682 |     11101.944 | 11865.556 | 13695.366 | 16661.204 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core         |      20217.733 |     19235.490 |     19440.526 | 18733.935 | 18994.672 | 16775.685 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core_Element |       4847.459 |      4621.513 |     10448.984 | 10743.950 | 12157.192 | 14806.369 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Base_Core_Mov     |       4881.116 |      4763.353 |     10187.989 | 10466.564 | 11316.808 | 15521.448 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Multiply          |       5144.957 |      5160.423 |     11234.065 | 11303.627 | 12679.057 | 13438.190 |
| ShiftLeftConstBenchmark_Int16 | SumSLL_AdvSimd           |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Int16 | SumSLL_Avx2              |                |               |     16630.499 | 16706.706 | 16366.063 | 16048.877 |
| ShiftLeftConstBenchmark_Int16 | SumSLLTraits             |       5076.036 |      5047.453 |     16986.361 | 16653.329 | 16496.182 | 16114.543 |
| ShiftLeftConstBenchmark_Int16 | SumSLLTraits_Core        |      20318.984 |     18959.033 |     20182.655 | 17683.717 | 18500.302 | 18439.182 |
| ShiftLeftConstBenchmark_Int16 | SumSLLConstTraits        |       5899.256 |      5693.084 |     16944.673 | 19378.434 | 21059.682 | 19572.551 |
| ShiftLeftConstBenchmark_Int16 | SumSLLConstTraits_Core   |      20172.952 |     19339.311 |     18407.673 | 19850.711 | 21232.279 | 18136.492 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_Multiply      |       5615.882 |      5806.351 |     15647.790 | 12971.552 | 17289.218 | 16009.810 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_AdvSimd       |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Int16 | SumSLLFast_Avx2          |                |               |     17363.745 | 10645.162 | 19174.068 | 16722.841 |
| ShiftLeftConstBenchmark_Int16 | SumSLLFastTraits         |       5550.577 |      5704.171 |     17892.967 | 19877.381 | 19025.720 | 16861.299 |
| ShiftLeftConstBenchmark_Int32 | SumSLLScalar             |        803.506 |       820.639 |      1307.614 |  1328.703 |  2199.685 |  1587.071 |
| ShiftLeftConstBenchmark_Int32 | SumSLLNetBcl             |                |               |               |           |           |  9469.894 |
| ShiftLeftConstBenchmark_Int32 | SumSLLNetBcl_Const       |                |               |               |           |           | 10657.900 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Basic             |       2315.510 |      2457.767 |      5959.311 |  5916.353 |  6037.703 |  9562.776 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Base_Core         |       8444.097 |      8525.641 |      8697.140 |  8946.409 |  8576.075 |  8521.214 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Multiply          |       2503.559 |      2648.774 |      5785.642 |  5826.821 |  5918.716 |  6534.076 |
| ShiftLeftConstBenchmark_Int32 | SumSLL_AdvSimd           |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Int32 | SumSLL_Avx2              |                |               |      8125.443 |  7932.724 |  7862.673 |  8021.776 |
| ShiftLeftConstBenchmark_Int32 | SumSLLTraits             |       2571.456 |      2678.866 |      8246.402 |  7799.748 |  8221.382 |  9594.126 |
| ShiftLeftConstBenchmark_Int32 | SumSLLTraits_Core        |       8574.361 |      8465.712 |     10320.833 | 10408.381 | 10626.910 | 10035.217 |
| ShiftLeftConstBenchmark_Int32 | SumSLLConstTraits        |       1493.590 |      2922.103 |      8155.046 |  9293.148 | 10579.400 | 10185.431 |
| ShiftLeftConstBenchmark_Int32 | SumSLLConstTraits_Core   |       8467.974 |      8554.920 |      9784.699 | 10384.732 |  9790.898 | 10329.112 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_Multiply      |       2849.113 |      2869.379 |      7779.964 |  7490.489 |  7724.487 |  7651.018 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_AdvSimd       |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Int32 | SumSLLFast_Avx2          |                |               |      8985.776 |  9893.850 |  8855.262 |  8956.954 |
| ShiftLeftConstBenchmark_Int32 | SumSLLFastTraits         |       2905.785 |      2927.619 |      8477.082 |  9395.637 |  8644.394 |  9599.512 |
| ShiftLeftConstBenchmark_Int64 | SumSLLScalar             |        797.703 |       816.504 |      1295.009 |  1305.611 |  2043.527 |  1535.809 |
| ShiftLeftConstBenchmark_Int64 | SumSLLNetBcl             |                |               |               |           |           |  4143.077 |
| ShiftLeftConstBenchmark_Int64 | SumSLLNetBcl_Const       |                |               |               |           |           |  4903.130 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Basic             |        438.384 |       454.154 |       476.324 |   461.872 |   469.419 |  3932.215 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Base_Core         |        440.306 |       437.988 |       477.841 |   461.887 |   468.624 |  3993.552 |
| ShiftLeftConstBenchmark_Int64 | SumSLL_AdvSimd           |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Int64 | SumSLL_Avx2              |                |               |      3960.310 |  4014.993 |  4212.691 |  3684.303 |
| ShiftLeftConstBenchmark_Int64 | SumSLLTraits             |        426.950 |       458.517 |      3867.136 |  3941.999 |  3964.762 |  3713.754 |
| ShiftLeftConstBenchmark_Int64 | SumSLLTraits_Core        |        441.378 |       463.537 |      4802.911 |  4813.018 |  4776.182 |  4653.104 |
| ShiftLeftConstBenchmark_Int64 | SumSLLConstTraits        |        490.135 |       536.949 |      3929.109 |  4018.072 |  4725.293 |  4712.366 |
| ShiftLeftConstBenchmark_Int64 | SumSLLConstTraits_Core   |        491.263 |       531.946 |      4930.099 |  4737.462 |  4782.430 |  4371.649 |
| ShiftLeftConstBenchmark_Int64 | SumSLLFast_AdvSimd       |                |               |               |           |           |           |
| ShiftLeftConstBenchmark_Int64 | SumSLLFast_Avx2          |                |               |      4410.488 |  4224.984 |  4216.614 |  3838.971 |
| ShiftLeftConstBenchmark_Int64 | SumSLLFastTraits         |        474.472 |       493.349 |      4432.603 |  4250.476 |  4477.111 |  4092.936 |

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
