# Benchmark group - Narrow
([← Back](Narrow.md))

Unit of data: Million operations per second. The larger the number, the better the performance.
### X86 - AMD Ryzen 7 7840H
| Type                   | Method                     | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :--------------------- | :------------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| NarrowBenchmark_Double | SumNarrowScalar            |       1105.244 |      1095.776 |      1074.597 |  1093.501 |  1094.494 |  1095.603 |  1095.661 |
| NarrowBenchmark_Double | SumNarrowBcl               |       8387.474 |      7875.051 |      7736.667 |  7777.368 |  7819.026 |  8418.170 |  8280.432 |
| NarrowBenchmark_Double | SumNarrowVectorBase        |       8334.221 |      7898.365 |      7734.585 |  7717.462 |  7734.129 |  8399.660 |  8390.016 |
| NarrowBenchmark_Double | SumNarrowVectorTraits      |       8288.466 |      7977.546 |      7910.472 |  7774.895 |  7865.675 |  7755.512 |  8332.526 |
| NarrowBenchmark_Double | SumNarrowVector128Bcl      |                |               |               |           |           |  4485.894 |  4462.684 |
| NarrowBenchmark_Double | SumNarrowVector128_AdvSimd |                |               |               |           |           |           |           |
| NarrowBenchmark_Double | SumNarrowVector128_ArmB64  |                |               |               |           |           |           |           |
| NarrowBenchmark_Double | SumNarrowVector128Traits   |                |               |      4478.952 |  4492.956 |  4485.483 |  4468.028 |  4459.841 |
| NarrowBenchmark_Double | SumNarrowVector256Bcl      |                |               |               |           |           |  8359.645 |  8358.960 |
| NarrowBenchmark_Double | SumNarrowVector256Traits   |                |               |      7889.978 |  7894.808 |  7685.428 |  7794.893 |  8303.373 |
| NarrowBenchmark_Double | SumNarrowVector512Bcl      |                |               |               |           |           |           | 10170.940 |
| NarrowBenchmark_Double | SumNarrowVector512Traits   |                |               |               |           |           |           |  9979.693 |
| NarrowBenchmark_Int16  | SumNarrowScalar            |       1401.712 |      1359.736 |      1366.147 |  1361.054 |  1374.745 |  1609.812 |  1583.045 |
| NarrowBenchmark_Int16  | SumNarrowBcl               |      30538.533 |     28712.006 |     31086.931 | 31383.954 | 29939.307 | 33541.513 | 39678.462 |
| NarrowBenchmark_Int16  | SumNarrowVectorBase        |      31606.128 |     29286.713 |     29079.574 | 29323.164 | 30427.891 | 32450.510 | 40382.364 |
| NarrowBenchmark_Int16  | SumNarrowVectorTraits      |      30600.670 |     30258.043 |     29769.661 | 29440.074 | 30098.540 | 32789.185 | 42305.987 |
| NarrowBenchmark_Int16  | SumNarrowVector128Bcl      |                |               |               |           |           | 21285.403 | 25290.580 |
| NarrowBenchmark_Int16  | SumNarrowVector128_AdvSimd |                |               |               |           |           |           |           |
| NarrowBenchmark_Int16  | SumNarrowVector128Traits   |                |               |     21242.208 | 23218.999 | 24784.093 | 20255.367 | 25910.967 |
| NarrowBenchmark_Int16  | SumNarrowVector256Bcl      |                |               |               |           |           | 31335.617 | 41593.748 |
| NarrowBenchmark_Int16  | SumNarrowVector256Traits   |                |               |     31160.717 | 37343.374 | 38226.301 | 32870.968 | 38977.413 |
| NarrowBenchmark_Int16  | SumNarrowVector512Bcl      |                |               |               |           |           |           | 44438.699 |
| NarrowBenchmark_Int16  | SumNarrowVector512Traits   |                |               |               |           |           |           | 44433.205 |
| NarrowBenchmark_Int64  | SumNarrowScalar            |       2542.873 |      2323.234 |      2434.787 |  2179.535 |  2419.490 |  2455.555 |  2426.488 |
| NarrowBenchmark_Int64  | SumNarrowBcl               |       7013.114 |      6680.120 |      6997.547 |  6813.537 |  6926.224 |  9085.121 |  8864.352 |
| NarrowBenchmark_Int64  | SumNarrowVectorBase        |       7158.687 |      6982.738 |      6818.791 |  6917.456 |  6881.128 |  9016.711 |  9041.492 |
| NarrowBenchmark_Int64  | SumNarrowVectorTraits      |       7163.507 |      6734.692 |      8105.888 |  9087.762 |  8885.566 |  9076.916 |  8808.182 |
| NarrowBenchmark_Int64  | SumNarrowVector128Bcl      |                |               |               |           |           |  6807.863 |  6233.035 |
| NarrowBenchmark_Int64  | SumNarrowVector128_AdvSimd |                |               |               |           |           |           |           |
| NarrowBenchmark_Int64  | SumNarrowVector128Traits   |                |               |      7168.804 |  6669.004 |  6499.242 |  6948.854 |  7546.344 |
| NarrowBenchmark_Int64  | SumNarrowVector256Bcl      |                |               |               |           |           |  8943.942 |  8904.215 |
| NarrowBenchmark_Int64  | SumNarrowVector256Traits   |                |               |      9263.556 |  9128.520 |  9041.270 |  8886.449 |  8923.368 |
| NarrowBenchmark_Int64  | SumNarrowVector512Bcl      |                |               |               |           |           |           |  9395.457 |
| NarrowBenchmark_Int64  | SumNarrowVector512Traits   |                |               |               |           |           |           |  9442.022 |

### X86 - Intel Core i5-8250U
| Type                   | Method                     | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |    .NET 5 |  .NET 5.0 |    .NET 6 |  .NET 6.0 |    .NET 7 |  .NET 7.0 |
| :--------------------- | :------------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: | --------: | --------: |
| NarrowBenchmark_Double | SumNarrowScalar            |        619.362 |       844.751 |       844.593 |   747.002 |   845.833 |   822.151 |   846.054 |   820.312 |   845.835 |
| NarrowBenchmark_Double | SumNarrowBcl               |       2690.125 |      5256.909 |      6197.911 |  4458.440 |  5875.040 |  5525.849 |  5877.753 |  5332.672 |  5419.130 |
| NarrowBenchmark_Double | SumNarrowVectorBase        |       3043.400 |      5246.737 |      6126.076 |  4736.787 |  5727.740 |  5525.085 |  5678.753 |  5023.694 |  5405.289 |
| NarrowBenchmark_Double | SumNarrowVectorTraits      |       3367.796 |      5257.627 |      6158.921 |  4991.367 |  5678.924 |  5611.390 |  5840.209 |  5130.718 |  5605.736 |
| NarrowBenchmark_Double | SumNarrowVector128_AdvSimd |                |               |               |           |           |           |           |           |           |
| NarrowBenchmark_Double | SumNarrowVector128_ArmB64  |                |               |               |           |           |           |           |           |           |
| NarrowBenchmark_Double | SumNarrowVector128Traits   |                |               |      3368.512 |   193.746 |  3358.610 |   191.945 |  3345.991 |  3247.950 |  3366.994 |
| NarrowBenchmark_Double | SumNarrowVector256Traits   |                |               |      5533.611 |   999.412 |  5672.803 |  1007.467 |  5487.963 |  5090.033 |  5196.724 |
| NarrowBenchmark_Int16  | SumNarrowScalar            |        876.766 |      1688.206 |      1691.146 |  1672.760 |  1692.158 |  1623.491 |  1690.663 |  1687.493 |  1688.882 |
| NarrowBenchmark_Int16  | SumNarrowBcl               |      12015.939 |     19695.645 |     18113.684 | 17960.142 | 18049.927 | 18733.836 | 18371.895 | 14795.391 | 14792.583 |
| NarrowBenchmark_Int16  | SumNarrowVectorBase        |      13369.100 |     19671.686 |     17927.318 | 18574.971 | 17954.423 | 18364.141 | 18358.078 | 22013.759 | 24816.524 |
| NarrowBenchmark_Int16  | SumNarrowVectorTraits      |      12242.273 |     19567.930 |     17985.114 | 10332.393 | 18131.247 | 10700.904 | 17703.545 | 24032.546 | 23272.226 |
| NarrowBenchmark_Int16  | SumNarrowVector128_AdvSimd |                |               |               |           |           |           |           |           |           |
| NarrowBenchmark_Int16  | SumNarrowVector128Traits   |                |               |     15395.765 |   738.415 | 16432.043 |   735.215 | 17397.164 | 15693.384 | 15319.518 |
| NarrowBenchmark_Int16  | SumNarrowVector256Traits   |                |               |     21732.424 | 19770.730 | 19766.797 | 20092.067 | 24595.464 | 23877.066 | 23284.763 |
| NarrowBenchmark_Int64  | SumNarrowScalar            |       1225.570 |      1599.069 |      1604.579 |  1503.454 |  1605.078 |  1573.460 |  1605.903 |  2489.626 |  2510.925 |
| NarrowBenchmark_Int64  | SumNarrowBcl               |       2480.547 |      3736.462 |      3783.773 |  3438.955 |  3770.889 |  3383.896 |  3795.409 |  5773.532 |  5917.367 |
| NarrowBenchmark_Int64  | SumNarrowVectorBase        |       2539.179 |      3737.855 |      3776.992 |  3379.996 |  3756.023 |  3435.694 |  3795.604 |  5752.873 |  5999.386 |
| NarrowBenchmark_Int64  | SumNarrowVectorTraits      |       3140.458 |      3746.633 |      6013.089 |  5187.229 |  6034.630 |  4527.496 |  6045.465 |  5207.492 |  5555.258 |
| NarrowBenchmark_Int64  | SumNarrowVector128_AdvSimd |                |               |               |           |           |           |           |           |           |
| NarrowBenchmark_Int64  | SumNarrowVector128Traits   |                |               |      4248.409 |   298.988 |  4137.322 |   299.638 |  4205.700 |  4043.678 |  4206.640 |
| NarrowBenchmark_Int64  | SumNarrowVector256Traits   |                |               |      5748.141 |  5455.908 |  6005.803 |  4846.844 |  5934.064 |  4985.410 |  5815.240 |

### Arm - Apple M2
| Type                   | Method                     |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :--------------------- | :------------------------- | --------: | --------: | --------: |
| NarrowBenchmark_Double | SumNarrowScalar            |  1133.557 |  1133.548 |  1165.717 |
| NarrowBenchmark_Double | SumNarrowBcl               |  4535.218 |  4537.265 |  4537.531 |
| NarrowBenchmark_Double | SumNarrowVectorBase        |  4534.945 |  4537.645 |  4537.034 |
| NarrowBenchmark_Double | SumNarrowVectorTraits      |  4535.335 |  4537.569 |  4537.527 |
| NarrowBenchmark_Double | SumNarrowVector128Bcl      |           |  4536.988 |  4537.456 |
| NarrowBenchmark_Double | SumNarrowVector128_AdvSimd |  2851.783 |  4537.449 |  4536.882 |
| NarrowBenchmark_Double | SumNarrowVector128_ArmB64  |  4535.928 |  4536.708 |  4537.974 |
| NarrowBenchmark_Double | SumNarrowVector128Traits   |  4535.889 |  4536.908 |  4537.392 |
| NarrowBenchmark_Double | SumNarrowVector256Bcl      |           |   779.833 |  9062.032 |
| NarrowBenchmark_Double | SumNarrowVector256Traits   |   661.057 |   779.952 |  9060.945 |
| NarrowBenchmark_Double | SumNarrowVector512Bcl      |           |           | 11491.609 |
| NarrowBenchmark_Double | SumNarrowVector512Traits   |           |           | 11489.471 |
| NarrowBenchmark_Int16  | SumNarrowScalar            |  1688.479 |  1689.883 |  1689.739 |
| NarrowBenchmark_Int16  | SumNarrowBcl               | 27156.135 | 27174.645 | 27193.896 |
| NarrowBenchmark_Int16  | SumNarrowVectorBase        | 27162.391 | 27177.717 | 27190.007 |
| NarrowBenchmark_Int16  | SumNarrowVectorTraits      | 27146.613 | 27176.279 | 27191.029 |
| NarrowBenchmark_Int16  | SumNarrowVector128Bcl      |           | 27158.192 | 27176.664 |
| NarrowBenchmark_Int16  | SumNarrowVector128_AdvSimd | 27148.426 | 27167.089 | 27179.367 |
| NarrowBenchmark_Int16  | SumNarrowVector128Traits   | 27142.585 | 27161.379 | 27182.120 |
| NarrowBenchmark_Int16  | SumNarrowVector256Bcl      |           |  1208.643 | 44650.023 |
| NarrowBenchmark_Int16  | SumNarrowVector256Traits   |  1758.976 |  1207.993 | 44649.159 |
| NarrowBenchmark_Int16  | SumNarrowVector512Bcl      |           |           | 44320.057 |
| NarrowBenchmark_Int16  | SumNarrowVector512Traits   |           |           | 44349.406 |
| NarrowBenchmark_Int64  | SumNarrowScalar            |  1791.666 |  2159.016 |  2159.277 |
| NarrowBenchmark_Int64  | SumNarrowBcl               |  6792.541 |  6801.338 |  6803.445 |
| NarrowBenchmark_Int64  | SumNarrowVectorBase        |  6787.702 |  6802.068 |  6803.681 |
| NarrowBenchmark_Int64  | SumNarrowVectorTraits      |  6789.476 |  6802.444 |  6802.785 |
| NarrowBenchmark_Int64  | SumNarrowVector128Bcl      |           |  6801.899 |  6802.954 |
| NarrowBenchmark_Int64  | SumNarrowVector128_AdvSimd |  6790.493 |  6801.313 |  6803.422 |
| NarrowBenchmark_Int64  | SumNarrowVector128Traits   |  6789.972 |  6801.407 |  6803.471 |
| NarrowBenchmark_Int64  | SumNarrowVector256Bcl      |           |   958.972 | 11448.407 |
| NarrowBenchmark_Int64  | SumNarrowVector256Traits   |   802.629 |   851.875 | 11446.283 |
| NarrowBenchmark_Int64  | SumNarrowVector512Bcl      |           |           | 11441.243 |
| NarrowBenchmark_Int64  | SumNarrowVector512Traits   |           |           | 11440.707 |

### Arm - AWS Arm t4g.small
| Type                   | Method                     | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :--------------------- | :------------------------- | ------------: | --------: | --------: | --------: | --------: |
| NarrowBenchmark_Double | SumNarrowScalar            |       809.924 |   829.370 |   902.464 |  1242.381 |  1244.061 |
| NarrowBenchmark_Double | SumNarrowBcl               |      3185.195 |  3262.590 |  3502.589 |  3371.276 |  4093.266 |
| NarrowBenchmark_Double | SumNarrowVectorBase        |      3108.652 |  3456.525 |  3240.256 |  3383.833 |  4090.859 |
| NarrowBenchmark_Double | SumNarrowVectorTraits      |      3170.695 |  3220.184 |  3517.930 |  3381.780 |  4081.457 |
| NarrowBenchmark_Double | SumNarrowVector128Bcl      |               |           |           |  3299.834 |  4068.055 |
| NarrowBenchmark_Double | SumNarrowVector128_AdvSimd |               |   467.266 |   466.503 |  3337.377 |  4098.248 |
| NarrowBenchmark_Double | SumNarrowVector128_ArmB64  |               |  3249.574 |  3248.644 |  3363.629 |  4080.506 |
| NarrowBenchmark_Double | SumNarrowVector128Traits   |       196.025 |  3508.928 |  3493.198 |  3358.300 |  4081.467 |
| NarrowBenchmark_Double | SumNarrowVector256Bcl      |               |           |           |   268.180 |  4332.121 |
| NarrowBenchmark_Double | SumNarrowVector256Traits   |       188.342 |   289.215 |   286.042 |   268.256 |  4341.566 |
| NarrowBenchmark_Double | SumNarrowVector512Bcl      |               |           |           |           |  4120.107 |
| NarrowBenchmark_Double | SumNarrowVector512Traits   |               |           |           |           |  4109.874 |
| NarrowBenchmark_Int16  | SumNarrowScalar            |       735.462 |   754.007 |   753.855 |  1031.203 |  1030.957 |
| NarrowBenchmark_Int16  | SumNarrowBcl               |     13889.161 | 12784.493 | 13527.971 | 15633.603 | 13952.787 |
| NarrowBenchmark_Int16  | SumNarrowVectorBase        |     14013.342 | 12834.948 | 13586.305 | 15629.979 | 13958.096 |
| NarrowBenchmark_Int16  | SumNarrowVectorTraits      |     13924.538 | 12842.043 | 13605.273 | 15615.734 | 13941.970 |
| NarrowBenchmark_Int16  | SumNarrowVector128Bcl      |               |           |           | 15602.249 | 14055.366 |
| NarrowBenchmark_Int16  | SumNarrowVector128_AdvSimd |               | 12843.699 | 12825.567 | 15612.417 | 13957.690 |
| NarrowBenchmark_Int16  | SumNarrowVector128Traits   |       534.338 | 12787.111 | 12779.936 | 15623.949 | 14077.420 |
| NarrowBenchmark_Int16  | SumNarrowVector256Bcl      |               |           |           |   382.370 | 14393.636 |
| NarrowBenchmark_Int16  | SumNarrowVector256Traits   |       508.575 |   640.487 |   645.335 |   383.052 | 14395.875 |
| NarrowBenchmark_Int16  | SumNarrowVector512Bcl      |               |           |           |           | 14694.235 |
| NarrowBenchmark_Int16  | SumNarrowVector512Traits   |               |           |           |           | 14682.275 |
| NarrowBenchmark_Int64  | SumNarrowScalar            |       836.930 |   838.020 |   836.548 |  1156.431 |  1155.112 |
| NarrowBenchmark_Int64  | SumNarrowBcl               |      3523.881 |  3182.059 |  3338.604 |  4146.713 |  3521.172 |
| NarrowBenchmark_Int64  | SumNarrowVectorBase        |      3205.560 |  3345.044 |  3184.654 |  4116.240 |  3525.582 |
| NarrowBenchmark_Int64  | SumNarrowVectorTraits      |      3460.327 |  3178.596 |  3340.149 |  4132.506 |  3524.571 |
| NarrowBenchmark_Int64  | SumNarrowVector128Bcl      |               |           |           |  4131.263 |  3510.278 |
| NarrowBenchmark_Int64  | SumNarrowVector128_AdvSimd |               |  3186.948 |  3351.243 |  4120.930 |  3513.308 |
| NarrowBenchmark_Int64  | SumNarrowVector128Traits   |       206.430 |  3345.960 |  3176.474 |  4130.996 |  3531.940 |
| NarrowBenchmark_Int64  | SumNarrowVector256Bcl      |               |           |           |   285.228 |  3672.302 |
| NarrowBenchmark_Int64  | SumNarrowVector256Traits   |       191.771 |   288.734 |   286.480 |   279.600 |  3668.420 |
| NarrowBenchmark_Int64  | SumNarrowVector512Bcl      |               |           |           |           |  3685.497 |
| NarrowBenchmark_Int64  | SumNarrowVector512Traits   |               |           |           |           |  3679.797 |

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                   | Method                     | .NET 8.0 |
| :--------------------- | :------------------------- | -------: |
| NarrowBenchmark_Double | SumNarrowScalar            |   47.908 |
| NarrowBenchmark_Double | SumNarrowBcl               |   53.120 |
| NarrowBenchmark_Double | SumNarrowVectorBase        |   53.900 |
| NarrowBenchmark_Double | SumNarrowVectorTraits      |  148.427 |
| NarrowBenchmark_Double | SumNarrowVector128Bcl      |   37.335 |
| NarrowBenchmark_Double | SumNarrowVector128_AdvSimd |          |
| NarrowBenchmark_Double | SumNarrowVector128_ArmB64  |          |
| NarrowBenchmark_Double | SumNarrowVector128Traits   |  152.705 |
| NarrowBenchmark_Double | SumNarrowVector256Bcl      |   31.422 |
| NarrowBenchmark_Double | SumNarrowVector256Traits   |   14.765 |
| NarrowBenchmark_Double | SumNarrowVector512Bcl      |   24.752 |
| NarrowBenchmark_Double | SumNarrowVector512Traits   |   10.587 |
| NarrowBenchmark_Int16  | SumNarrowScalar            |   41.845 |
| NarrowBenchmark_Int16  | SumNarrowBcl               |  122.626 |
| NarrowBenchmark_Int16  | SumNarrowVectorBase        |  131.775 |
| NarrowBenchmark_Int16  | SumNarrowVectorTraits      |  823.674 |
| NarrowBenchmark_Int16  | SumNarrowVector128Bcl      |   90.216 |
| NarrowBenchmark_Int16  | SumNarrowVector128_AdvSimd |          |
| NarrowBenchmark_Int16  | SumNarrowVector128Traits   |  810.738 |
| NarrowBenchmark_Int16  | SumNarrowVector256Bcl      |   88.023 |
| NarrowBenchmark_Int16  | SumNarrowVector256Traits   |   84.641 |
| NarrowBenchmark_Int16  | SumNarrowVector512Bcl      |   59.926 |
| NarrowBenchmark_Int16  | SumNarrowVector512Traits   |   69.251 |
| NarrowBenchmark_Int64  | SumNarrowScalar            |   54.161 |
| NarrowBenchmark_Int64  | SumNarrowBcl               |   71.754 |
| NarrowBenchmark_Int64  | SumNarrowVectorBase        |   76.202 |
| NarrowBenchmark_Int64  | SumNarrowVectorTraits      |  189.662 |
| NarrowBenchmark_Int64  | SumNarrowVector128Bcl      |   44.863 |
| NarrowBenchmark_Int64  | SumNarrowVector128_AdvSimd |          |
| NarrowBenchmark_Int64  | SumNarrowVector128Traits   |  187.281 |
| NarrowBenchmark_Int64  | SumNarrowVector256Bcl      |   41.828 |
| NarrowBenchmark_Int64  | SumNarrowVector256Traits   |   15.643 |
| NarrowBenchmark_Int64  | SumNarrowVector512Bcl      |   29.410 |
| NarrowBenchmark_Int64  | SumNarrowVector512Traits   |   13.442 |

