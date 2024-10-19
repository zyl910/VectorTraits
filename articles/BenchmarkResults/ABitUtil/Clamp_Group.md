# Benchmark group - Clamp
([← Back](Clamp.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### X86 - AMD Ryzen 7 7840H
| Type                 | Method                     | .NET Framework | .NET Core 2.1 | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 | .NET 8.0 |
| :------------------- | :------------------------- | -------------: | ------------: | ------------: | -------: | -------: | -------: | -------: |
| ClampBenchmark_Int16 | SumClamp_If                |        200.847 |       202.844 |       198.984 |  205.985 |  206.584 |  213.309 |  222.046 |
| ClampBenchmark_Int16 | SumClamp_IfUnrolling4      |        214.243 |       209.654 |       212.499 |  211.963 |  212.971 |  225.778 |  218.262 |
| ClampBenchmark_Int16 | SumClamp_MinMax            |        184.008 |       191.269 |       183.085 |  189.608 |  178.623 |  198.196 |  200.573 |
| ClampBenchmark_Int16 | SumClamp_MinMaxUnrolling4  |        192.841 |       194.966 |       195.972 |  189.895 |  191.306 |  195.521 |  196.657 |
| ClampBenchmark_Int16 | SumClamp_Math              |                |       166.487 |       189.178 |  193.263 |  193.148 |  198.681 |  192.314 |
| ClampBenchmark_Int16 | SumClamp_MathUnrolling4    |                |       171.056 |       199.306 |  198.774 |  197.617 |  213.664 |  213.929 |
| ClampBenchmark_Int16 | SumClamp_BitMath           |        430.688 |       400.141 |       364.850 |  198.787 |  213.214 |  348.203 |  524.161 |
| ClampBenchmark_Int16 | SumClamp_BitMathUnrolling4 |        375.115 |       364.886 |       411.236 |  237.339 |  249.228 |  348.450 |  515.942 |
| ClampBenchmark_Int32 | SumClamp_If                |        220.677 |       215.527 |       215.577 |  207.714 |  198.113 |  224.483 |  234.025 |
| ClampBenchmark_Int32 | SumClamp_IfUnrolling4      |        233.234 |       226.889 |       220.715 |  220.235 |  224.314 |  238.320 |  227.703 |
| ClampBenchmark_Int32 | SumClamp_MinMax            |        204.710 |       201.288 |       194.184 |  191.591 |  188.780 |  210.070 |  187.554 |
| ClampBenchmark_Int32 | SumClamp_MinMaxUnrolling4  |        206.199 |       203.594 |       205.698 |  195.438 |  197.290 |  205.651 |  205.458 |
| ClampBenchmark_Int32 | SumClamp_Math              |                |       172.228 |       202.013 |  203.868 |  199.448 |  203.631 |  219.693 |
| ClampBenchmark_Int32 | SumClamp_MathUnrolling4    |                |       176.982 |       207.908 |  205.344 |  206.729 |  224.442 |  229.489 |
| ClampBenchmark_Int32 | SumClamp_BitMath           |        595.251 |       555.719 |       551.795 |  245.833 |  245.127 |  482.091 |  733.743 |
| ClampBenchmark_Int32 | SumClamp_BitMathUnrolling4 |        602.440 |       545.057 |       586.884 |  282.894 |  285.461 |  487.490 |  752.392 |

### X86 - Intel Core i5-8250U
| Type                 | Method                     | .NET Framework | .NET Core 2.1 | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 |
| :------------------- | :------------------------- | -------------: | ------------: | ------------: | -------: | -------: | -------: |
| ClampBenchmark_Int16 | SumClamp_If                |        207.661 |       209.983 |       204.529 |  206.420 |  210.318 |  219.667 |
| ClampBenchmark_Int16 | SumClamp_IfUnrolling4      |        214.388 |       213.144 |       213.748 |  212.928 |  210.782 |  219.485 |
| ClampBenchmark_Int16 | SumClamp_MinMax            |        190.680 |       197.459 |       200.100 |  185.678 |  187.981 |  192.127 |
| ClampBenchmark_Int16 | SumClamp_MinMaxUnrolling4  |        163.391 |       201.622 |       201.714 |  161.176 |  173.794 |  176.572 |
| ClampBenchmark_Int16 | SumClamp_Math              |                |       137.507 |       195.387 |  196.526 |  199.036 |  201.061 |
| ClampBenchmark_Int16 | SumClamp_MathUnrolling4    |                |       164.421 |       200.507 |  202.631 |  201.953 |  207.936 |
| ClampBenchmark_Int16 | SumClamp_BitMath           |        412.045 |       411.979 |       385.582 |  248.914 |  318.781 |  425.482 |
| ClampBenchmark_Int16 | SumClamp_BitMathUnrolling4 |        393.042 |       393.399 |       430.514 |  330.486 |  333.682 |  406.539 |
| ClampBenchmark_Int32 | SumClamp_If                |        203.568 |       212.413 |       205.811 |  211.220 |  207.522 |  220.450 |
| ClampBenchmark_Int32 | SumClamp_IfUnrolling4      |        212.035 |       215.861 |       212.616 |  216.123 |  213.127 |  222.568 |
| ClampBenchmark_Int32 | SumClamp_MinMax            |        205.230 |       200.922 |       198.984 |  189.019 |  185.556 |  188.499 |
| ClampBenchmark_Int32 | SumClamp_MinMaxUnrolling4  |        204.407 |       203.978 |       202.248 |  191.377 |  160.082 |  186.375 |
| ClampBenchmark_Int32 | SumClamp_Math              |                |       132.457 |       202.923 |  196.542 |  198.223 |  202.489 |
| ClampBenchmark_Int32 | SumClamp_MathUnrolling4    |                |       170.428 |       204.689 |  203.228 |  203.412 |  213.483 |
| ClampBenchmark_Int32 | SumClamp_BitMath           |        580.968 |       577.881 |       582.051 |  361.329 |  360.738 |  574.594 |
| ClampBenchmark_Int32 | SumClamp_BitMathUnrolling4 |        575.007 |       576.199 |       589.749 |  399.872 |  403.908 |  539.810 |

### Arm - Apple M2
| Type                 | Method                     | .NET 6.0 | .NET 7.0 | .NET 8.0 |
| :------------------- | :------------------------- | -------: | -------: | -------: |
| ClampBenchmark_Int16 | SumClamp_If                |  267.070 |  304.813 |  317.670 |
| ClampBenchmark_Int16 | SumClamp_IfUnrolling4      |  277.819 |  313.288 |  310.242 |
| ClampBenchmark_Int16 | SumClamp_MinMax            |  229.342 |  263.948 |  272.808 |
| ClampBenchmark_Int16 | SumClamp_MinMaxUnrolling4  |  242.901 |  267.075 |  269.398 |
| ClampBenchmark_Int16 | SumClamp_Math              |  238.918 |  278.520 |  287.540 |
| ClampBenchmark_Int16 | SumClamp_MathUnrolling4    |  253.948 |  287.304 |  307.118 |
| ClampBenchmark_Int16 | SumClamp_BitMath           |  648.535 |  816.389 |  947.144 |
| ClampBenchmark_Int16 | SumClamp_BitMathUnrolling4 |  650.240 |  838.151 |  959.648 |
| ClampBenchmark_Int32 | SumClamp_If                |  268.064 |  310.393 |  318.593 |
| ClampBenchmark_Int32 | SumClamp_IfUnrolling4      |  281.302 |  312.197 |  316.380 |
| ClampBenchmark_Int32 | SumClamp_MinMax            |  235.078 |  276.004 |  268.195 |
| ClampBenchmark_Int32 | SumClamp_MinMaxUnrolling4  |  246.473 |  278.214 |  279.944 |
| ClampBenchmark_Int32 | SumClamp_Math              |  231.749 |  285.458 |  288.743 |
| ClampBenchmark_Int32 | SumClamp_MathUnrolling4    |  257.353 |  292.524 |  300.289 |
| ClampBenchmark_Int32 | SumClamp_BitMath           |  939.354 | 1270.889 | 1342.275 |
| ClampBenchmark_Int32 | SumClamp_BitMathUnrolling4 |  978.149 | 1239.305 | 1319.929 |

### Arm - AWS Arm t4g.small
| Type                 | Method                     | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 | .NET 8.0 |
| :------------------- | :------------------------- | ------------: | -------: | -------: | -------: | -------: |
| ClampBenchmark_Int16 | SumClamp_If                |       166.943 |  170.294 |  164.048 |  193.411 |  202.495 |
| ClampBenchmark_Int16 | SumClamp_IfUnrolling4      |       173.449 |  164.948 |  169.382 |  196.718 |  195.947 |
| ClampBenchmark_Int16 | SumClamp_MinMax            |       151.711 |  155.465 |  150.520 |  170.725 |  174.250 |
| ClampBenchmark_Int16 | SumClamp_MinMaxUnrolling4  |       154.309 |  137.995 |  136.506 |  176.075 |  172.272 |
| ClampBenchmark_Int16 | SumClamp_Math              |       160.712 |  163.520 |  158.018 |  175.825 |  197.969 |
| ClampBenchmark_Int16 | SumClamp_MathUnrolling4    |       154.931 |  157.682 |  155.929 |  185.220 |  204.668 |
| ClampBenchmark_Int16 | SumClamp_BitMath           |       247.678 |  189.052 |  188.859 |  239.629 |  350.591 |
| ClampBenchmark_Int16 | SumClamp_BitMathUnrolling4 |       249.405 |  182.322 |  183.604 |  234.346 |  348.994 |
| ClampBenchmark_Int32 | SumClamp_If                |       167.141 |  173.174 |  171.433 |  201.420 |  209.478 |
| ClampBenchmark_Int32 | SumClamp_IfUnrolling4      |       168.139 |  172.177 |  171.337 |  211.600 |  210.642 |
| ClampBenchmark_Int32 | SumClamp_MinMax            |       153.641 |  120.603 |  149.170 |  184.150 |  191.440 |
| ClampBenchmark_Int32 | SumClamp_MinMaxUnrolling4  |       155.878 |  118.508 |  149.698 |  181.017 |  185.638 |
| ClampBenchmark_Int32 | SumClamp_Math              |       158.564 |  159.623 |  159.522 |  185.528 |  215.618 |
| ClampBenchmark_Int32 | SumClamp_MathUnrolling4    |       161.374 |  162.415 |  162.083 |  197.462 |  212.031 |
| ClampBenchmark_Int32 | SumClamp_BitMath           |       323.291 |  240.801 |  240.732 |  323.581 |  491.627 |
| ClampBenchmark_Int32 | SumClamp_BitMathUnrolling4 |       320.075 |  228.603 |  228.707 |  326.357 |  502.983 |

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                 | Method                     | .NET 8.0 |
| :------------------- | :------------------------- | -------: |
| ClampBenchmark_Int16 | SumClamp_If                |   39.529 |
| ClampBenchmark_Int16 | SumClamp_IfUnrolling4      |   55.775 |
| ClampBenchmark_Int16 | SumClamp_MinMax            |   36.852 |
| ClampBenchmark_Int16 | SumClamp_MinMaxUnrolling4  |   44.544 |
| ClampBenchmark_Int16 | SumClamp_Math              |   37.166 |
| ClampBenchmark_Int16 | SumClamp_MathUnrolling4    |   46.421 |
| ClampBenchmark_Int16 | SumClamp_BitMath           |   39.669 |
| ClampBenchmark_Int16 | SumClamp_BitMathUnrolling4 |   29.057 |
| ClampBenchmark_Int32 | SumClamp_If                |   41.131 |
| ClampBenchmark_Int32 | SumClamp_IfUnrolling4      |   59.941 |
| ClampBenchmark_Int32 | SumClamp_MinMax            |   37.887 |
| ClampBenchmark_Int32 | SumClamp_MinMaxUnrolling4  |   46.593 |
| ClampBenchmark_Int32 | SumClamp_Math              |   37.534 |
| ClampBenchmark_Int32 | SumClamp_MathUnrolling4    |   49.041 |
| ClampBenchmark_Int32 | SumClamp_BitMath           |   44.083 |
| ClampBenchmark_Int32 | SumClamp_BitMathUnrolling4 |   35.706 |

