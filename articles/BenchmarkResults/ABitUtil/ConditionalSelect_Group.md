# Benchmark group - ConditionalSelect
([← Back](ConditionalSelect.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### X86 - AMD Ryzen 7 7840H
| Type                             | Method                           | .NET Framework | .NET Core 2.1 | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 | .NET 8.0 |
| :------------------------------- | :------------------------------- | -------------: | ------------: | ------------: | -------: | -------: | -------: | -------: |
| ConditionalSelectBenchmark_Int16 | SumConditionalSelect_If          |        248.375 |       265.678 |       254.998 |  268.225 |  238.324 |  250.418 |  274.599 |
| ConditionalSelectBenchmark_Int16 | SumConditionalSelect_Min         |        266.157 |       264.734 |       267.393 |  267.610 |  263.789 |  267.778 |  249.648 |
| ConditionalSelectBenchmark_Int16 | SumConditionalSelect_Min_BitMath |        612.177 |       586.454 |       595.906 |  224.989 |  224.358 |  523.123 |  845.041 |
| ConditionalSelectBenchmark_Int16 | SumConditionalSelect_BitMath     |        635.831 |       589.919 |       588.455 |  224.643 |  223.172 |  527.387 |  832.783 |
| ConditionalSelectBenchmark_Int32 | SumConditionalSelect_If          |        286.486 |       247.281 |       252.101 |  263.400 |  252.650 |  271.650 |  271.325 |
| ConditionalSelectBenchmark_Int32 | SumConditionalSelect_Min         |        285.266 |       278.508 |       252.637 |  281.243 |  281.350 |  279.236 |  286.129 |
| ConditionalSelectBenchmark_Int32 | SumConditionalSelect_Min_BitMath |        656.447 |       641.490 |       644.163 |  259.486 |  257.134 |  734.006 |  995.294 |
| ConditionalSelectBenchmark_Int32 | SumConditionalSelect_BitMath     |        653.392 |       645.750 |       639.818 |  257.656 |  258.375 |  720.890 |  983.366 |

### X86 - Intel Core i5-8250U
| Type                             | Method                           | .NET Framework | .NET Core 2.1 | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 |
| :------------------------------- | :------------------------------- | -------------: | ------------: | ------------: | -------: | -------: | -------: |
| ConditionalSelectBenchmark_Int16 | SumConditionalSelect_If          |        263.246 |       260.432 |       262.881 |  264.835 |  260.428 |  265.583 |
| ConditionalSelectBenchmark_Int16 | SumConditionalSelect_Min         |        259.818 |       258.723 |       264.886 |  258.053 |  263.702 |  275.521 |
| ConditionalSelectBenchmark_Int16 | SumConditionalSelect_Min_BitMath |        639.426 |       640.044 |       644.014 |  293.147 |  294.908 |  642.865 |
| ConditionalSelectBenchmark_Int16 | SumConditionalSelect_BitMath     |        641.049 |       644.608 |       664.438 |  293.112 |  293.813 |  643.402 |
| ConditionalSelectBenchmark_Int32 | SumConditionalSelect_If          |        270.898 |       261.092 |       251.691 |  262.473 |  263.535 |  275.987 |
| ConditionalSelectBenchmark_Int32 | SumConditionalSelect_Min         |        269.116 |       264.939 |       252.458 |  258.770 |  261.950 |  279.368 |
| ConditionalSelectBenchmark_Int32 | SumConditionalSelect_Min_BitMath |        567.211 |       568.681 |       568.145 |  321.976 |  321.661 |  823.804 |
| ConditionalSelectBenchmark_Int32 | SumConditionalSelect_BitMath     |        568.896 |       568.289 |       568.745 |  321.944 |  321.671 |  820.385 |

### Arm - Apple M2
| Type                             | Method                           | .NET 6.0 | .NET 7.0 | .NET 8.0 |
| :------------------------------- | :------------------------------- | -------: | -------: | -------: |
| ConditionalSelectBenchmark_Int16 | SumConditionalSelect_If          |  322.610 |  374.282 |  378.087 |
| ConditionalSelectBenchmark_Int16 | SumConditionalSelect_Min         |  330.368 |  377.937 |  377.411 |
| ConditionalSelectBenchmark_Int16 | SumConditionalSelect_Min_BitMath |  909.113 | 1189.876 | 1416.073 |
| ConditionalSelectBenchmark_Int16 | SumConditionalSelect_BitMath     |  908.751 | 1190.112 | 1416.267 |
| ConditionalSelectBenchmark_Int32 | SumConditionalSelect_If          |  325.934 |  379.365 |  383.156 |
| ConditionalSelectBenchmark_Int32 | SumConditionalSelect_Min         |  324.900 |  385.891 |  380.136 |
| ConditionalSelectBenchmark_Int32 | SumConditionalSelect_Min_BitMath | 1275.294 | 1594.486 | 1648.205 |
| ConditionalSelectBenchmark_Int32 | SumConditionalSelect_BitMath     | 1275.641 | 1595.740 | 1648.203 |

### Arm - AWS Arm t4g.small
| Type                             | Method                           | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 | .NET 8.0 |
| :------------------------------- | :------------------------------- | ------------: | -------: | -------: | -------: | -------: |
| ConditionalSelectBenchmark_Int16 | SumConditionalSelect_If          |       189.066 |  203.350 |  198.357 |  240.197 |  229.961 |
| ConditionalSelectBenchmark_Int16 | SumConditionalSelect_Min         |       197.687 |  196.932 |  195.789 |  239.216 |  234.449 |
| ConditionalSelectBenchmark_Int16 | SumConditionalSelect_Min_BitMath |       341.051 |  271.614 |  271.640 |  363.397 |  526.199 |
| ConditionalSelectBenchmark_Int16 | SumConditionalSelect_BitMath     |       340.847 |  271.752 |  271.642 |  363.283 |  525.977 |
| ConditionalSelectBenchmark_Int32 | SumConditionalSelect_If          |       195.950 |  203.823 |  206.090 |  253.399 |  258.629 |
| ConditionalSelectBenchmark_Int32 | SumConditionalSelect_Min         |       202.614 |  201.241 |  201.451 |  251.272 |  246.550 |
| ConditionalSelectBenchmark_Int32 | SumConditionalSelect_Min_BitMath |       431.288 |  320.498 |  320.060 |  482.265 |  684.860 |
| ConditionalSelectBenchmark_Int32 | SumConditionalSelect_BitMath     |       431.424 |  320.497 |  320.653 |  482.510 |  685.026 |

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                             | Method                           | .NET 8.0 |
| :------------------------------- | :------------------------------- | -------: |
| ConditionalSelectBenchmark_Int16 | SumConditionalSelect_If          |   42.403 |
| ConditionalSelectBenchmark_Int16 | SumConditionalSelect_Min         |   42.318 |
| ConditionalSelectBenchmark_Int16 | SumConditionalSelect_Min_BitMath |   50.430 |
| ConditionalSelectBenchmark_Int16 | SumConditionalSelect_BitMath     |   48.513 |
| ConditionalSelectBenchmark_Int32 | SumConditionalSelect_If          |   43.613 |
| ConditionalSelectBenchmark_Int32 | SumConditionalSelect_Min         |   41.879 |
| ConditionalSelectBenchmark_Int32 | SumConditionalSelect_Min_BitMath |   50.349 |
| ConditionalSelectBenchmark_Int32 | SumConditionalSelect_BitMath     |   51.996 |

