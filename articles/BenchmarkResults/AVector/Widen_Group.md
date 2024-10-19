# Benchmark group - Widen
([← Back](Widen.md))

Unit of data: Million operations per second. The larger the number, the better the performance.
### X86 - AMD Ryzen 7 7840H
| Type                  | Method                         | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :-------------------- | :----------------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: | --------: |
| WidenBenchmark_Int32  | SumWidenScalar                 |       2254.532 |      2333.616 |      2341.300 |  2539.831 |  2483.047 |  2181.156 |  2490.283 |
| WidenBenchmark_Int32  | SumWidenBcl                    |       8901.453 |      8495.477 |      8630.642 |  7849.956 |  7868.034 | 11092.317 | 11010.849 |
| WidenBenchmark_Int32  | SumWidenVectorBase             |       9230.734 |      8622.161 |      8132.605 |  8303.912 |  8343.677 | 11603.759 | 11190.965 |
| WidenBenchmark_Int32  | SumWidenVectorBase_NRef        |        832.749 |       830.498 |       830.793 |   909.563 |   831.884 |   797.388 |   779.716 |
| WidenBenchmark_Int32  | SumWidenVectorBase_NRef2       |        826.891 |       821.905 |       828.135 |   907.051 |   832.016 |   786.949 |   793.123 |
| WidenBenchmark_Int32  | SumWidenVectorBase_NRefInc     |        787.091 |       836.429 |       830.023 |   864.312 |   823.433 |   857.018 |   789.599 |
| WidenBenchmark_Int32  | SumWidenVectorBase_NRefInc2    |        801.669 |       832.033 |       834.798 |   902.386 |   834.023 |   901.551 |   791.533 |
| WidenBenchmark_Int32  | SumWidenVectorBase_Ref         |        837.384 |       842.798 |       850.886 |   875.297 |   832.714 |   871.953 |   783.012 |
| WidenBenchmark_Int32  | SumWidenVectorBase_Ref2        |        803.198 |       764.199 |       845.225 |   877.880 |   851.150 |   800.242 |   784.322 |
| WidenBenchmark_Int32  | SumWidenVectorBase_RefInc      |        785.104 |       831.387 |       833.070 |   853.735 |   827.436 |   853.803 |   784.351 |
| WidenBenchmark_Int32  | SumWidenVectorBase128_Ref      |                |               |               |           |           |           |           |
| WidenBenchmark_Int32  | SumWidenVectorBase128_Ref2     |                |               |               |           |           |           |           |
| WidenBenchmark_Int32  | SumWidenVectorBase128_RefI     |                |               |               |           |           |           |           |
| WidenBenchmark_Int32  | SumWidenVectorBase128_RefI2    |                |               |               |           |           |           |           |
| WidenBenchmark_Int32  | SumWidenVectorBase128_RefInc   |                |               |               |           |           |           |           |
| WidenBenchmark_Int32  | SumWidenVectorBase128_RefInc2  |                |               |               |           |           |           |           |
| WidenBenchmark_Int32  | SumWidenVectorBase256_Ref      |        940.833 |       968.398 |       954.283 |   982.957 |   978.591 |   990.262 |   922.974 |
| WidenBenchmark_Int32  | SumWidenVectorBase256_Ref2     |        951.698 |       966.483 |       968.096 |   975.754 |   967.552 |   988.872 |   925.527 |
| WidenBenchmark_Int32  | SumWidenVectorBase256_RefI     |        771.960 |       782.584 |       786.836 |   800.777 |   788.191 |   780.180 |   784.102 |
| WidenBenchmark_Int32  | SumWidenVectorBase256_RefI2    |        781.617 |       796.398 |       798.786 |   800.279 |   794.031 |   785.472 |   789.902 |
| WidenBenchmark_Int32  | SumWidenVectorBase256_RefInc   |        763.544 |       796.305 |       791.618 |   796.520 |   792.729 |   784.849 |   779.901 |
| WidenBenchmark_Int32  | SumWidenVectorBase256_RefInc2  |        794.708 |       821.672 |       823.588 |   842.005 |   809.007 |   837.674 |   779.018 |
| WidenBenchmark_Int32  | SumWidenVectorTraits           |       9014.183 |      8192.115 |     11612.415 | 11955.292 | 11552.556 | 11214.266 | 10877.148 |
| WidenBenchmark_Int32  | SumWidenVectorTraits_Ptr       |       8935.941 |      8377.396 |     11970.531 | 12001.438 | 11684.651 | 11693.881 | 11025.536 |
| WidenBenchmark_Int32  | SumWidenVectorTraits_Tuple     |       3065.080 |      3028.525 |     11492.239 | 11582.847 | 11290.438 | 11643.575 | 10728.196 |
| WidenBenchmark_Int32  | SumWidenVector128Bcl           |                |               |               |           |           |  6277.958 |  6227.012 |
| WidenBenchmark_Int32  | SumWidenVector128_AdvSimd      |                |               |               |           |           |           |           |
| WidenBenchmark_Int32  | SumWidenVector128Traits        |                |               |      6153.964 |  6164.549 |  6110.993 |  6046.995 |  5832.495 |
| WidenBenchmark_Int32  | SumWidenVector128Traits_Tuple  |                |               |      6012.154 |  6140.319 |  6188.656 |  5920.061 |  5863.818 |
| WidenBenchmark_Int32  | SumWidenVector256Traits        |                |               |     12170.002 | 11965.955 | 11470.935 | 11065.353 | 10963.784 |
| WidenBenchmark_Int32  | SumWidenVector256Avx_ConvertTo |                |               |     11644.099 | 11936.744 | 11226.810 | 11682.224 | 10907.020 |
| WidenBenchmark_Int32  | SumWidenVector256Avx_Unpack    |                |               |      8769.076 |  8913.498 |  8940.537 |  8180.578 |  7667.019 |
| WidenBenchmark_Int32  | SumWidenVector512Bcl           |                |               |               |           |           |           | 14043.277 |
| WidenBenchmark_Int32  | SumWidenVector512Traits        |                |               |               |           |           |           | 14324.904 |
| WidenBenchmark_SByte  | SumWidenScalar                 |       1492.863 |      1426.625 |      1434.122 |  1447.139 |  1375.062 |  1563.158 |  1568.560 |
| WidenBenchmark_SByte  | SumWidenBcl                    |      36649.220 |     34597.722 |     35241.148 | 34600.498 | 35492.417 | 46271.101 | 47530.522 |
| WidenBenchmark_SByte  | SumWidenVectorBase             |      36763.036 |     34640.379 |     34431.268 | 34742.227 | 34369.078 | 49842.042 | 46969.276 |
| WidenBenchmark_SByte  | SumWidenVectorTraits           |      36897.153 |     34662.534 |     33918.783 | 34558.728 | 34821.768 | 43161.333 | 48768.485 |
| WidenBenchmark_SByte  | SumWidenVectorTraits_Ptr       |      36267.794 |     34987.598 |     35774.898 | 35476.955 | 34685.544 | 48446.925 | 46052.153 |
| WidenBenchmark_SByte  | SumWidenVectorTraits_Tuple     |      12770.732 |     12224.085 |     34278.713 | 33455.855 | 34353.965 | 50581.458 | 49141.174 |
| WidenBenchmark_SByte  | SumWidenVector128Bcl           |                |               |               |           |           | 26037.456 | 26125.447 |
| WidenBenchmark_SByte  | SumWidenVector128_AdvSimd      |                |               |               |           |           |           |           |
| WidenBenchmark_SByte  | SumWidenVector128Traits        |                |               |     26002.149 | 25942.320 | 25393.202 | 26959.443 | 26410.807 |
| WidenBenchmark_SByte  | SumWidenVector128Traits_Tuple  |                |               |     26270.943 | 25556.874 | 25221.824 | 26563.574 | 26021.520 |
| WidenBenchmark_SByte  | SumWidenVector256Traits        |                |               |     49754.472 | 50828.126 | 49829.990 | 46999.940 | 46249.842 |
| WidenBenchmark_SByte  | SumWidenVector256Avx_ConvertTo |                |               |     49920.569 | 48627.285 | 50193.948 | 47815.329 | 47836.951 |
| WidenBenchmark_SByte  | SumWidenVector256Avx_Unpack    |                |               |     36225.980 | 36124.811 | 36274.033 | 34241.669 | 32412.234 |
| WidenBenchmark_SByte  | SumWidenVector512Bcl           |                |               |               |           |           |           | 63574.604 |
| WidenBenchmark_SByte  | SumWidenVector512Traits        |                |               |               |           |           |           | 64258.185 |
| WidenBenchmark_Single | SumWidenScalar                 |       1101.312 |      1092.188 |      1093.369 |  1100.053 |  1093.376 |  1087.595 |  1086.179 |
| WidenBenchmark_Single | SumWidenBcl                    |       8251.694 |      7913.950 |      8080.949 |  8161.360 |  8026.283 |  7807.261 |  7548.402 |
| WidenBenchmark_Single | SumWidenVectorBase             |       8120.703 |      8000.543 |      8012.472 |  7918.373 |  7862.327 |  7635.939 |  7537.233 |
| WidenBenchmark_Single | SumWidenVectorTraits           |       8490.373 |      8008.741 |      7630.889 |  7747.803 |  7833.755 |  7401.778 |  7655.748 |
| WidenBenchmark_Single | SumWidenVectorTraits_Ptr       |       8408.776 |      7952.727 |      7456.988 |  7797.809 |  7568.426 |  7669.193 |  7566.118 |
| WidenBenchmark_Single | SumWidenVectorTraits_Tuple     |       3125.429 |      3073.498 |      7566.192 |  7800.314 |  7680.428 |  7606.420 |  7653.703 |
| WidenBenchmark_Single | SumWidenVector128Bcl           |                |               |               |           |           |  4403.237 |  4430.082 |
| WidenBenchmark_Single | SumWidenVector128_AdvSimd      |                |               |               |           |           |           |           |
| WidenBenchmark_Single | SumWidenVector128_ArmB64       |                |               |               |           |           |           |           |
| WidenBenchmark_Single | SumWidenVector128Traits        |                |               |      4429.080 |  4351.855 |  4347.376 |  4404.759 |  4418.325 |
| WidenBenchmark_Single | SumWidenVector128Traits_Tuple  |                |               |      4456.605 |  4417.706 |  4430.264 |  4415.913 |  4376.894 |
| WidenBenchmark_Single | SumWidenVector256Traits        |                |               |      7816.010 |  7710.094 |  7735.555 |  7649.611 |  7423.171 |
| WidenBenchmark_Single | SumWidenVector512Bcl           |                |               |               |           |           |           | 10125.983 |
| WidenBenchmark_Single | SumWidenVector512Traits        |                |               |               |           |           |           | 10177.939 |

### X86 - Intel Core i5-8250U
| Type                  | Method                         | .NET Framework | .NET Core 2.1 | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |
| :-------------------- | :----------------------------- | -------------: | ------------: | ------------: | --------: | --------: | --------: |
| WidenBenchmark_Int32  | SumWidenScalar                 |       1488.682 |      1914.571 |      1824.120 |  1595.172 |  1909.800 |  1691.289 |
| WidenBenchmark_Int32  | SumWidenBcl                    |       5277.892 |      5690.177 |      5711.283 |  4170.211 |  5683.556 |  8157.616 |
| WidenBenchmark_Int32  | SumWidenVectorBase             |       5303.791 |      5694.722 |      5693.597 |  2781.591 |  5668.000 |  8181.966 |
| WidenBenchmark_Int32  | SumWidenVectorBase_NRef        |        758.378 |       834.543 |       807.800 |   673.187 |   837.096 |   914.744 |
| WidenBenchmark_Int32  | SumWidenVectorBase_NRef2       |        743.722 |       806.525 |       785.839 |   633.759 |   809.733 |   896.702 |
| WidenBenchmark_Int32  | SumWidenVectorBase_NRefInc     |        801.638 |       863.181 |       833.035 |   878.999 |   877.333 |   853.985 |
| WidenBenchmark_Int32  | SumWidenVectorBase_NRefInc2    |        739.365 |       837.199 |       820.346 |   846.194 |   846.171 |   830.746 |
| WidenBenchmark_Int32  | SumWidenVectorBase_Ref         |        605.298 |       765.494 |       750.241 |   774.337 |   772.252 |   846.803 |
| WidenBenchmark_Int32  | SumWidenVectorBase_Ref2        |        581.694 |       786.332 |       769.718 |   801.616 |   796.884 |   893.476 |
| WidenBenchmark_Int32  | SumWidenVectorBase_RefInc      |        628.192 |       862.461 |       833.020 |   877.667 |   875.525 |   855.817 |
| WidenBenchmark_Int32  | SumWidenVectorBase128_Ref      |                |               |               |           |           |           |
| WidenBenchmark_Int32  | SumWidenVectorBase128_Ref2     |                |               |               |           |           |           |
| WidenBenchmark_Int32  | SumWidenVectorBase128_RefI     |                |               |               |           |           |           |
| WidenBenchmark_Int32  | SumWidenVectorBase128_RefI2    |                |               |               |           |           |           |
| WidenBenchmark_Int32  | SumWidenVectorBase128_RefInc   |                |               |               |           |           |           |
| WidenBenchmark_Int32  | SumWidenVectorBase128_RefInc2  |                |               |               |           |           |           |
| WidenBenchmark_Int32  | SumWidenVectorBase256_Ref      |        590.196 |       918.569 |       859.514 |  1005.326 |   999.970 |   955.637 |
| WidenBenchmark_Int32  | SumWidenVectorBase256_Ref2     |        594.956 |       919.197 |       857.095 |   966.818 |   964.429 |   932.827 |
| WidenBenchmark_Int32  | SumWidenVectorBase256_RefI     |        581.864 |       914.435 |       833.154 |   963.666 |   962.075 |   940.102 |
| WidenBenchmark_Int32  | SumWidenVectorBase256_RefI2    |        609.939 |       911.349 |       832.108 |   942.934 |   940.756 |   913.873 |
| WidenBenchmark_Int32  | SumWidenVectorBase256_RefInc   |        657.288 |       907.999 |       830.766 |   924.255 |   927.801 |   910.103 |
| WidenBenchmark_Int32  | SumWidenVectorBase256_RefInc2  |        571.519 |       885.249 |       831.602 |   910.871 |   909.589 |   886.063 |
| WidenBenchmark_Int32  | SumWidenVectorTraits           |       2782.298 |      5601.481 |      7616.240 |  7617.971 |  7579.159 |  8178.935 |
| WidenBenchmark_Int32  | SumWidenVectorTraits_Ptr       |       2796.704 |      5693.582 |      7593.985 |  7614.725 |  7617.416 |  8170.439 |
| WidenBenchmark_Int32  | SumWidenVector128_AdvSimd      |                |               |               |           |           |           |
| WidenBenchmark_Int32  | SumWidenVector128Traits        |                |               |      4700.274 |  4709.869 |  4669.189 |  5126.681 |
| WidenBenchmark_Int32  | SumWidenVector256Traits        |                |               |      7538.434 |  7572.857 |  7541.495 |  8180.761 |
| WidenBenchmark_Int32  | SumWidenVector256Avx_ConvertTo |                |               |      7618.521 |  7610.558 |  7638.327 |  8175.748 |
| WidenBenchmark_Int32  | SumWidenVector256Avx_Unpack    |                |               |      5762.401 |  5744.760 |  5785.389 |  6239.180 |
| WidenBenchmark_SByte  | SumWidenScalar                 |        787.017 |      1602.848 |      1603.028 |  1598.229 |  1691.638 |  1682.945 |
| WidenBenchmark_SByte  | SumWidenBcl                    |      14898.377 |     24245.618 |     24172.155 | 24344.085 | 24391.974 | 35108.612 |
| WidenBenchmark_SByte  | SumWidenVectorBase             |      12652.168 |     24257.284 |     24228.986 | 24296.294 | 24329.711 | 35129.716 |
| WidenBenchmark_SByte  | SumWidenVectorTraits           |      10658.810 |     24512.905 |     24097.252 | 24043.838 | 24367.657 | 35043.588 |
| WidenBenchmark_SByte  | SumWidenVectorTraits_Ptr       |      11729.631 |     24532.131 |     24170.269 | 24208.835 | 24265.151 | 34715.131 |
| WidenBenchmark_SByte  | SumWidenVector128_AdvSimd      |                |               |               |           |           |           |
| WidenBenchmark_SByte  | SumWidenVector128Traits        |                |               |     19602.814 | 19509.404 | 19522.882 | 17908.484 |
| WidenBenchmark_SByte  | SumWidenVector256Traits        |                |               |     34172.219 | 34273.834 | 34299.718 | 35140.634 |
| WidenBenchmark_SByte  | SumWidenVector256Avx_ConvertTo |                |               |     34226.865 | 34202.248 | 34404.021 | 35136.199 |
| WidenBenchmark_SByte  | SumWidenVector256Avx_Unpack    |                |               |     24063.055 | 24661.423 | 24572.602 | 26326.472 |
| WidenBenchmark_Single | SumWidenScalar                 |        634.488 |       840.000 |       843.191 |   839.261 |   841.721 |   840.517 |
| WidenBenchmark_Single | SumWidenBcl                    |       3594.591 |      6098.000 |      6115.246 |  6123.769 |  6115.295 |  6124.735 |
| WidenBenchmark_Single | SumWidenVectorBase             |       3241.637 |      5995.226 |      6095.198 |  6087.328 |  6126.545 |  6082.314 |
| WidenBenchmark_Single | SumWidenVectorTraits           |       3828.368 |      6099.402 |      6194.871 |  6109.801 |  6170.394 |  6084.322 |
| WidenBenchmark_Single | SumWidenVectorTraits_Ptr       |       4591.236 |      6106.502 |      5951.918 |  6028.154 |  6088.241 |  6110.339 |
| WidenBenchmark_Single | SumWidenVector128_AdvSimd      |                |               |               |           |           |           |
| WidenBenchmark_Single | SumWidenVector128_ArmB64       |                |               |               |           |           |           |
| WidenBenchmark_Single | SumWidenVector128Traits        |                |               |      3366.437 |  3375.541 |  3374.769 |  3378.751 |
| WidenBenchmark_Single | SumWidenVector256Traits        |                |               |      5922.261 |  6116.942 |  6019.948 |  6113.611 |

### Arm - Apple M2
| Type                  | Method                         |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :-------------------- | :----------------------------- | --------: | --------: | --------: |
| WidenBenchmark_Int32  | SumWidenScalar                 |  1730.782 |  1747.163 |  1747.574 |
| WidenBenchmark_Int32  | SumWidenBcl                    |  6803.226 |  6803.028 |  6804.250 |
| WidenBenchmark_Int32  | SumWidenVectorBase             |  6801.120 |  6804.076 |  6804.020 |
| WidenBenchmark_Int32  | SumWidenVectorBase_NRef        |  2155.604 |  2567.712 |  2701.874 |
| WidenBenchmark_Int32  | SumWidenVectorBase_NRef2       |  2352.115 |  2833.900 |  2773.761 |
| WidenBenchmark_Int32  | SumWidenVectorBase_NRefInc     |  2358.251 |  2709.955 |  3153.551 |
| WidenBenchmark_Int32  | SumWidenVectorBase_NRefInc2    |  2169.733 |  2581.155 |  2783.450 |
| WidenBenchmark_Int32  | SumWidenVectorBase_Ref         |  2009.639 |  2569.250 |  2706.734 |
| WidenBenchmark_Int32  | SumWidenVectorBase_Ref2        |  2259.802 |  2690.564 |  2610.766 |
| WidenBenchmark_Int32  | SumWidenVectorBase_RefInc      |  2358.161 |  2709.309 |  3151.770 |
| WidenBenchmark_Int32  | SumWidenVectorBase128_Ref      |  3178.062 |  3294.916 |  3395.136 |
| WidenBenchmark_Int32  | SumWidenVectorBase128_Ref2     |  3227.189 |  3293.200 |  3394.358 |
| WidenBenchmark_Int32  | SumWidenVectorBase128_RefI     |  3257.744 |  3314.283 |  3396.126 |
| WidenBenchmark_Int32  | SumWidenVectorBase128_RefI2    |  3233.826 |  3293.809 |  3390.830 |
| WidenBenchmark_Int32  | SumWidenVectorBase128_RefInc   |  3229.408 |  3293.997 |  3377.728 |
| WidenBenchmark_Int32  | SumWidenVectorBase128_RefInc2  |  3058.537 |  3258.196 |  3393.094 |
| WidenBenchmark_Int32  | SumWidenVectorBase256_Ref      |           |           |           |
| WidenBenchmark_Int32  | SumWidenVectorBase256_Ref2     |           |           |           |
| WidenBenchmark_Int32  | SumWidenVectorBase256_RefI     |           |           |           |
| WidenBenchmark_Int32  | SumWidenVectorBase256_RefI2    |           |           |           |
| WidenBenchmark_Int32  | SumWidenVectorBase256_RefInc   |           |           |           |
| WidenBenchmark_Int32  | SumWidenVectorBase256_RefInc2  |           |           |           |
| WidenBenchmark_Int32  | SumWidenVectorTraits           |  6800.379 |  6803.195 |  6803.998 |
| WidenBenchmark_Int32  | SumWidenVectorTraits_Ptr       |  6803.411 |  6803.633 |  6803.699 |
| WidenBenchmark_Int32  | SumWidenVectorTraits_Tuple     |  3359.160 |  3189.992 |  6803.850 |
| WidenBenchmark_Int32  | SumWidenVector128Bcl           |           |  3190.474 |  6804.371 |
| WidenBenchmark_Int32  | SumWidenVector128_AdvSimd      |  6800.430 |  6802.587 |  6803.538 |
| WidenBenchmark_Int32  | SumWidenVector128Traits        |  6800.337 |  6801.833 |  6803.583 |
| WidenBenchmark_Int32  | SumWidenVector128Traits_Tuple  |  3359.087 |  3187.982 |  6803.260 |
| WidenBenchmark_Int32  | SumWidenVector256Traits        |   711.244 |   282.078 | 13507.372 |
| WidenBenchmark_Int32  | SumWidenVector256Avx_ConvertTo |           |           |           |
| WidenBenchmark_Int32  | SumWidenVector256Avx_Unpack    |           |           |           |
| WidenBenchmark_Int32  | SumWidenVector512Bcl           |           |           | 13527.831 |
| WidenBenchmark_Int32  | SumWidenVector512Traits        |           |           | 13527.071 |
| WidenBenchmark_SByte  | SumWidenScalar                 |  1688.465 |  1691.328 |  1692.147 |
| WidenBenchmark_SByte  | SumWidenBcl                    | 27229.541 | 27216.188 | 27229.453 |
| WidenBenchmark_SByte  | SumWidenVectorBase             | 27209.420 | 27221.954 | 27229.410 |
| WidenBenchmark_SByte  | SumWidenVectorTraits           | 27221.867 | 27222.696 | 27231.529 |
| WidenBenchmark_SByte  | SumWidenVectorTraits_Ptr       | 27222.661 | 27225.615 | 27229.186 |
| WidenBenchmark_SByte  | SumWidenVectorTraits_Tuple     | 13420.688 | 12750.485 | 27232.954 |
| WidenBenchmark_SByte  | SumWidenVector128Bcl           |           | 12749.405 | 27229.658 |
| WidenBenchmark_SByte  | SumWidenVector128_AdvSimd      | 27208.961 | 27224.351 | 27228.620 |
| WidenBenchmark_SByte  | SumWidenVector128Traits        | 27239.426 | 12740.490 | 27238.115 |
| WidenBenchmark_SByte  | SumWidenVector128Traits_Tuple  | 13428.271 |  6054.487 | 27236.399 |
| WidenBenchmark_SByte  | SumWidenVector256Traits        |  1523.490 |   646.792 | 54065.309 |
| WidenBenchmark_SByte  | SumWidenVector256Avx_ConvertTo |           |           |           |
| WidenBenchmark_SByte  | SumWidenVector256Avx_Unpack    |           |           |           |
| WidenBenchmark_SByte  | SumWidenVector512Bcl           |           |           | 54230.681 |
| WidenBenchmark_SByte  | SumWidenVector512Traits        |           |           | 54247.210 |
| WidenBenchmark_Single | SumWidenScalar                 |  1133.883 |  1165.922 |  1165.793 |
| WidenBenchmark_Single | SumWidenBcl                    |  4537.542 |  4536.672 |  4536.819 |
| WidenBenchmark_Single | SumWidenVectorBase             |  4535.382 |  4537.063 |  4537.021 |
| WidenBenchmark_Single | SumWidenVectorTraits           |  4536.357 |  4536.623 |  4537.396 |
| WidenBenchmark_Single | SumWidenVectorTraits_Ptr       |  4536.093 |  4537.297 |  4537.599 |
| WidenBenchmark_Single | SumWidenVectorTraits_Tuple     |  3360.726 |  3180.835 |  4536.955 |
| WidenBenchmark_Single | SumWidenVector128Bcl           |           |  4537.007 |  4537.337 |
| WidenBenchmark_Single | SumWidenVector128_AdvSimd      |  1528.218 |  1532.928 |  1928.528 |
| WidenBenchmark_Single | SumWidenVector128_ArmB64       |  4535.853 |  4536.535 |  4537.619 |
| WidenBenchmark_Single | SumWidenVector128Traits        |  4536.361 |  4536.837 |  4537.559 |
| WidenBenchmark_Single | SumWidenVector128Traits_Tuple  |  3499.643 |  3246.749 |  4538.026 |
| WidenBenchmark_Single | SumWidenVector256Traits        |   581.915 |   293.185 |  9028.034 |
| WidenBenchmark_Single | SumWidenVector512Bcl           |           |           | 13579.285 |
| WidenBenchmark_Single | SumWidenVector512Traits        |           |           | 13578.096 |

### Arm - AWS Arm t4g.small
| Type                  | Method                         | .NET Core 3.1 |  .NET 5.0 |  .NET 6.0 |  .NET 7.0 |  .NET 8.0 |
| :-------------------- | :----------------------------- | ------------: | --------: | --------: | --------: | --------: |
| WidenBenchmark_Int32  | SumWidenScalar                 |       749.244 |   747.360 |   749.738 |  1241.653 |  1243.836 |
| WidenBenchmark_Int32  | SumWidenBcl                    |      3553.920 |  3192.224 |  3192.094 |  3813.135 |  3206.932 |
| WidenBenchmark_Int32  | SumWidenVectorBase             |      3543.074 |  3142.346 |  3457.053 |  3816.794 |  3196.625 |
| WidenBenchmark_Int32  | SumWidenVectorBase_NRef        |       532.938 |   533.904 |   534.798 |   547.755 |   539.521 |
| WidenBenchmark_Int32  | SumWidenVectorBase_NRef2       |       532.833 |   368.947 |   527.858 |   547.288 |   539.731 |
| WidenBenchmark_Int32  | SumWidenVectorBase_NRefInc     |       526.785 |   508.097 |   512.722 |   543.955 |   549.302 |
| WidenBenchmark_Int32  | SumWidenVectorBase_NRefInc2    |       532.259 |   520.827 |   519.690 |   412.721 |   552.214 |
| WidenBenchmark_Int32  | SumWidenVectorBase_Ref         |       536.899 |   533.218 |   533.031 |   545.583 |   539.944 |
| WidenBenchmark_Int32  | SumWidenVectorBase_Ref2        |       534.587 |   531.701 |   340.391 |   549.645 |   542.143 |
| WidenBenchmark_Int32  | SumWidenVectorBase_RefInc      |       305.822 |   511.621 |   511.485 |   544.878 |   548.963 |
| WidenBenchmark_Int32  | SumWidenVectorBase128_Ref      |       516.063 |   505.397 |   507.320 |   536.108 |   549.244 |
| WidenBenchmark_Int32  | SumWidenVectorBase128_Ref2     |       517.332 |   507.588 |   506.936 |   536.552 |   548.710 |
| WidenBenchmark_Int32  | SumWidenVectorBase128_RefI     |       518.065 |   508.464 |   508.962 |   535.673 |   548.106 |
| WidenBenchmark_Int32  | SumWidenVectorBase128_RefI2    |       520.847 |   511.014 |   511.073 |   535.215 |   547.161 |
| WidenBenchmark_Int32  | SumWidenVectorBase128_RefInc   |       523.538 |   514.092 |   513.827 |   537.479 |   547.948 |
| WidenBenchmark_Int32  | SumWidenVectorBase128_RefInc2  |       532.347 |   520.542 |   520.732 |   538.432 |   546.744 |
| WidenBenchmark_Int32  | SumWidenVectorBase256_Ref      |               |           |           |           |           |
| WidenBenchmark_Int32  | SumWidenVectorBase256_Ref2     |               |           |           |           |           |
| WidenBenchmark_Int32  | SumWidenVectorBase256_RefI     |               |           |           |           |           |
| WidenBenchmark_Int32  | SumWidenVectorBase256_RefI2    |               |           |           |           |           |
| WidenBenchmark_Int32  | SumWidenVectorBase256_RefInc   |               |           |           |           |           |
| WidenBenchmark_Int32  | SumWidenVectorBase256_RefInc2  |               |           |           |           |           |
| WidenBenchmark_Int32  | SumWidenVectorTraits           |      3291.431 |  3480.225 |  3226.132 |  3792.197 |  3270.046 |
| WidenBenchmark_Int32  | SumWidenVectorTraits_Ptr       |      3554.814 |  3461.064 |  3127.243 |  3782.360 |  3273.569 |
| WidenBenchmark_Int32  | SumWidenVectorTraits_Tuple     |       740.407 |   742.823 |   721.010 |   766.501 |  3210.275 |
| WidenBenchmark_Int32  | SumWidenVector128Bcl           |               |           |           |   769.057 |  3209.519 |
| WidenBenchmark_Int32  | SumWidenVector128_AdvSimd      |               |  2981.951 |  2966.613 |  3806.328 |  3182.450 |
| WidenBenchmark_Int32  | SumWidenVector128Traits        |       243.827 |  2998.620 |  2996.682 |  3806.301 |  3211.422 |
| WidenBenchmark_Int32  | SumWidenVector128Traits_Tuple  |       167.510 |   742.083 |   713.744 |   767.994 |  3174.646 |
| WidenBenchmark_Int32  | SumWidenVector256Traits        |       181.773 |   270.374 |   269.044 |   115.035 |  3604.290 |
| WidenBenchmark_Int32  | SumWidenVector256Avx_ConvertTo |               |           |           |           |           |
| WidenBenchmark_Int32  | SumWidenVector256Avx_Unpack    |               |           |           |           |           |
| WidenBenchmark_Int32  | SumWidenVector512Bcl           |               |           |           |           |  3625.745 |
| WidenBenchmark_Int32  | SumWidenVector512Traits        |               |           |           |           |  3627.551 |
| WidenBenchmark_SByte  | SumWidenScalar                 |       763.832 |   745.586 |   844.629 |  1201.863 |  1208.435 |
| WidenBenchmark_SByte  | SumWidenBcl                    |     14270.443 | 12796.934 | 12982.929 | 15281.536 | 12969.867 |
| WidenBenchmark_SByte  | SumWidenVectorBase             |     14300.698 | 12796.786 | 12996.731 | 15289.153 | 12969.157 |
| WidenBenchmark_SByte  | SumWidenVectorTraits           |     13208.029 | 13947.906 | 13626.837 | 15324.971 | 12963.049 |
| WidenBenchmark_SByte  | SumWidenVectorTraits_Ptr       |     13189.526 | 12982.516 | 13712.771 | 15121.821 | 12998.963 |
| WidenBenchmark_SByte  | SumWidenVectorTraits_Tuple     |      3068.204 |  2977.798 |  2758.807 |  2960.328 | 12982.925 |
| WidenBenchmark_SByte  | SumWidenVector128Bcl           |               |           |           |  3083.452 | 12974.279 |
| WidenBenchmark_SByte  | SumWidenVector128_AdvSimd      |               | 11954.541 | 11973.719 | 15356.639 | 12956.539 |
| WidenBenchmark_SByte  | SumWidenVector128Traits        |       445.229 | 11668.198 | 11988.909 |  3083.590 | 12979.281 |
| WidenBenchmark_SByte  | SumWidenVector128Traits_Tuple  |       335.194 |  3047.689 |  2864.418 |  1867.340 | 12983.269 |
| WidenBenchmark_SByte  | SumWidenVector256Traits        |       460.131 |   572.922 |   572.637 |   172.468 | 14461.715 |
| WidenBenchmark_SByte  | SumWidenVector256Avx_ConvertTo |               |           |           |           |           |
| WidenBenchmark_SByte  | SumWidenVector256Avx_Unpack    |               |           |           |           |           |
| WidenBenchmark_SByte  | SumWidenVector512Bcl           |               |           |           |           | 14805.651 |
| WidenBenchmark_SByte  | SumWidenVector512Traits        |               |           |           |           | 14805.076 |
| WidenBenchmark_Single | SumWidenScalar                 |       901.465 |   825.338 |   827.889 |  1243.598 |  1243.899 |
| WidenBenchmark_Single | SumWidenBcl                    |      3281.583 |  3168.093 |  3469.623 |  3618.807 |  3136.182 |
| WidenBenchmark_Single | SumWidenVectorBase             |      3552.245 |  3149.163 |  3199.008 |  3622.533 |  3138.588 |
| WidenBenchmark_Single | SumWidenVectorTraits           |      3548.242 |  3444.203 |  3160.921 |  3622.737 |  3136.279 |
| WidenBenchmark_Single | SumWidenVectorTraits_Ptr       |      3284.196 |  3248.274 |  3462.879 |  3624.135 |  3186.439 |
| WidenBenchmark_Single | SumWidenVectorTraits_Tuple     |       756.511 |   765.812 |   713.384 |   731.596 |  3126.116 |
| WidenBenchmark_Single | SumWidenVector128Bcl           |               |           |           |  3612.349 |  3136.396 |
| WidenBenchmark_Single | SumWidenVector128_AdvSimd      |               |   405.555 |   405.416 |   593.858 |   843.967 |
| WidenBenchmark_Single | SumWidenVector128_ArmB64       |               |  2927.491 |  2951.373 |  3622.139 |  3122.563 |
| WidenBenchmark_Single | SumWidenVector128Traits        |       213.478 |  2912.039 |  2928.986 |  3627.594 |  3133.783 |
| WidenBenchmark_Single | SumWidenVector128Traits_Tuple  |       156.006 |   768.810 |   713.954 |   765.985 |  3138.652 |
| WidenBenchmark_Single | SumWidenVector256Traits        |       181.686 |   259.164 |   257.456 |   110.853 |  3463.491 |
| WidenBenchmark_Single | SumWidenVector512Bcl           |               |           |           |           |  3627.605 |
| WidenBenchmark_Single | SumWidenVector512Traits        |               |           |           |           |  3599.776 |

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                  | Method                         | .NET 8.0 |
| :-------------------- | :----------------------------- | -------: |
| WidenBenchmark_Int32  | SumWidenScalar                 |   46.833 |
| WidenBenchmark_Int32  | SumWidenBcl                    |    6.146 |
| WidenBenchmark_Int32  | SumWidenVectorBase             |    6.178 |
| WidenBenchmark_Int32  | SumWidenVectorBase_NRef        |    8.178 |
| WidenBenchmark_Int32  | SumWidenVectorBase_NRef2       |    7.961 |
| WidenBenchmark_Int32  | SumWidenVectorBase_NRefInc     |    8.141 |
| WidenBenchmark_Int32  | SumWidenVectorBase_NRefInc2    |    7.424 |
| WidenBenchmark_Int32  | SumWidenVectorBase_Ref         |    7.775 |
| WidenBenchmark_Int32  | SumWidenVectorBase_Ref2        |    7.844 |
| WidenBenchmark_Int32  | SumWidenVectorBase_RefInc      |    8.180 |
| WidenBenchmark_Int32  | SumWidenVectorBase128_Ref      |    9.001 |
| WidenBenchmark_Int32  | SumWidenVectorBase128_Ref2     |    9.077 |
| WidenBenchmark_Int32  | SumWidenVectorBase128_RefI     |    9.234 |
| WidenBenchmark_Int32  | SumWidenVectorBase128_RefI2    |    9.090 |
| WidenBenchmark_Int32  | SumWidenVectorBase128_RefInc   |    8.877 |
| WidenBenchmark_Int32  | SumWidenVectorBase128_RefInc2  |    8.916 |
| WidenBenchmark_Int32  | SumWidenVectorBase256_Ref      |          |
| WidenBenchmark_Int32  | SumWidenVectorBase256_Ref2     |          |
| WidenBenchmark_Int32  | SumWidenVectorBase256_RefI     |          |
| WidenBenchmark_Int32  | SumWidenVectorBase256_RefI2    |          |
| WidenBenchmark_Int32  | SumWidenVectorBase256_RefInc   |          |
| WidenBenchmark_Int32  | SumWidenVectorBase256_RefInc2  |          |
| WidenBenchmark_Int32  | SumWidenVectorTraits           |    6.589 |
| WidenBenchmark_Int32  | SumWidenVectorTraits_Ptr       |    6.953 |
| WidenBenchmark_Int32  | SumWidenVectorTraits_Tuple     |    4.046 |
| WidenBenchmark_Int32  | SumWidenVector128Bcl           |    6.438 |
| WidenBenchmark_Int32  | SumWidenVector128_AdvSimd      |          |
| WidenBenchmark_Int32  | SumWidenVector128Traits        |   14.124 |
| WidenBenchmark_Int32  | SumWidenVector128Traits_Tuple  |    6.505 |
| WidenBenchmark_Int32  | SumWidenVector256Traits        |    3.946 |
| WidenBenchmark_Int32  | SumWidenVector256Avx_ConvertTo |          |
| WidenBenchmark_Int32  | SumWidenVector256Avx_Unpack    |          |
| WidenBenchmark_Int32  | SumWidenVector512Bcl           |    2.500 |
| WidenBenchmark_Int32  | SumWidenVector512Traits        |    3.884 |
| WidenBenchmark_SByte  | SumWidenScalar                 |   47.880 |
| WidenBenchmark_SByte  | SumWidenBcl                    |   22.841 |
| WidenBenchmark_SByte  | SumWidenVectorBase             |   22.437 |
| WidenBenchmark_SByte  | SumWidenVectorTraits           |   20.009 |
| WidenBenchmark_SByte  | SumWidenVectorTraits_Ptr       |   19.733 |
| WidenBenchmark_SByte  | SumWidenVectorTraits_Tuple     |   15.138 |
| WidenBenchmark_SByte  | SumWidenVector128Bcl           |   16.885 |
| WidenBenchmark_SByte  | SumWidenVector128_AdvSimd      |          |
| WidenBenchmark_SByte  | SumWidenVector128Traits        |   13.664 |
| WidenBenchmark_SByte  | SumWidenVector128Traits_Tuple  |   16.474 |
| WidenBenchmark_SByte  | SumWidenVector256Traits        |   12.840 |
| WidenBenchmark_SByte  | SumWidenVector256Avx_ConvertTo |          |
| WidenBenchmark_SByte  | SumWidenVector256Avx_Unpack    |          |
| WidenBenchmark_SByte  | SumWidenVector512Bcl           |   12.828 |
| WidenBenchmark_SByte  | SumWidenVector512Traits        |   12.100 |
| WidenBenchmark_Single | SumWidenScalar                 |   46.406 |
| WidenBenchmark_Single | SumWidenBcl                    |    5.276 |
| WidenBenchmark_Single | SumWidenVectorBase             |    5.114 |
| WidenBenchmark_Single | SumWidenVectorTraits           |    1.883 |
| WidenBenchmark_Single | SumWidenVectorTraits_Ptr       |    1.835 |
| WidenBenchmark_Single | SumWidenVectorTraits_Tuple     |    3.454 |
| WidenBenchmark_Single | SumWidenVector128Bcl           |    6.235 |
| WidenBenchmark_Single | SumWidenVector128_AdvSimd      |          |
| WidenBenchmark_Single | SumWidenVector128_ArmB64       |          |
| WidenBenchmark_Single | SumWidenVector128Traits        |    2.619 |
| WidenBenchmark_Single | SumWidenVector128Traits_Tuple  |    5.874 |
| WidenBenchmark_Single | SumWidenVector256Traits        |    3.693 |
| WidenBenchmark_Single | SumWidenVector512Bcl           |    2.343 |
| WidenBenchmark_Single | SumWidenVector512Traits        |    3.979 |

