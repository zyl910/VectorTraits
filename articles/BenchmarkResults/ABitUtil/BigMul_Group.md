# Benchmark group - BigMul
([← Back](BigMul.md))

Unit of data: Million operations per second. The larger the number, the better the performance.

### X86 - AMD Ryzen 7 7840H
| Type                   | Method            | .NET Framework | .NET Core 2.1 | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 | .NET 8.0 |
| :--------------------- | :---------------- | -------------: | ------------: | ------------: | -------: | -------: | -------: | -------: |
| BigMulBenchmark_UInt64 | SumBigMul_BigNum  |         98.096 |       164.004 |       173.642 |  174.014 |  136.906 |  136.612 |  137.591 |
| BigMulBenchmark_UInt64 | SumBigMul_BCL     |                |               |               | 1469.285 | 1509.959 | 1881.872 | 1850.417 |
| BigMulBenchmark_UInt64 | SumBigMul_BitMath |        589.710 |       598.064 |       596.050 | 1486.426 | 1454.321 | 1881.845 | 1869.394 |
| BigMulBenchmark_UInt64 | SumBigMul_Two     |        592.620 |       573.341 |       580.001 |  555.165 |  582.180 |  586.122 |  646.901 |
| BigMulBenchmark_UInt64 | SumBigMul_HighLow |        564.036 |       544.152 |       563.094 |  560.426 |  558.926 |  636.107 |  558.935 |

### X86 - Intel Core i5-8250U
| Type                   | Method            | .NET Framework | .NET Core 2.1 | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 |
| :--------------------- | :---------------- | -------------: | ------------: | ------------: | -------: | -------: | -------: |
| BigMulBenchmark_UInt64 | SumBigMul_BigNum  |         77.993 |       142.167 |       163.763 |  163.607 |  136.364 |  141.144 |
| BigMulBenchmark_UInt64 | SumBigMul_BCL     |                |               |               | 1274.310 | 1271.931 | 1411.787 |
| BigMulBenchmark_UInt64 | SumBigMul_BitMath |        628.149 |       627.425 |       630.325 | 1275.560 | 1272.478 | 1399.433 |
| BigMulBenchmark_UInt64 | SumBigMul_Two     |        626.984 |       629.075 |       623.226 |  621.301 |  619.612 |  656.726 |
| BigMulBenchmark_UInt64 | SumBigMul_HighLow |        605.800 |       606.756 |       601.787 |  596.904 |  595.405 |  628.617 |

### Arm - Apple M2
| Type                   | Method            | .NET 6.0 | .NET 7.0 | .NET 8.0 |
| :--------------------- | :---------------- | -------: | -------: | -------: |
| BigMulBenchmark_UInt64 | SumBigMul_BigNum  |  233.862 |  283.340 |  312.692 |
| BigMulBenchmark_UInt64 | SumBigMul_BCL     | 2255.659 | 3454.319 | 3308.230 |
| BigMulBenchmark_UInt64 | SumBigMul_BitMath | 2256.545 | 3458.445 | 3194.530 |
| BigMulBenchmark_UInt64 | SumBigMul_Two     | 1164.324 | 1609.842 | 1117.510 |
| BigMulBenchmark_UInt64 | SumBigMul_HighLow | 1141.513 | 1500.428 | 1414.967 |

### Arm - AWS Arm t4g.small
| Type                   | Method            | .NET Core 3.1 | .NET 5.0 | .NET 6.0 | .NET 7.0 | .NET 8.0 |
| :--------------------- | :---------------- | ------------: | -------: | -------: | -------: | -------: |
| BigMulBenchmark_UInt64 | SumBigMul_BigNum  |        79.848 |   79.107 |   74.308 |  103.459 |  103.582 |
| BigMulBenchmark_UInt64 | SumBigMul_BCL     |               |  274.263 |  701.860 |  708.687 |  710.373 |
| BigMulBenchmark_UInt64 | SumBigMul_BitMath |       324.965 |  275.150 |  701.601 |  710.639 |  710.412 |
| BigMulBenchmark_UInt64 | SumBigMul_Two     |       322.223 |  325.097 |  324.767 |  413.866 |  382.854 |
| BigMulBenchmark_UInt64 | SumBigMul_HighLow |       312.355 |  310.825 |  310.338 |  397.464 |  412.720 |

### Wasm - Wasm on AMD Ryzen 7 7840H
| Type                   | Method            | .NET 8.0 |
| :--------------------- | :---------------- | -------: |
| BigMulBenchmark_UInt64 | SumBigMul_BigNum  |    4.607 |
| BigMulBenchmark_UInt64 | SumBigMul_BCL     |   20.757 |
| BigMulBenchmark_UInt64 | SumBigMul_BitMath |   20.921 |
| BigMulBenchmark_UInt64 | SumBigMul_Two     |   83.949 |
| BigMulBenchmark_UInt64 | SumBigMul_HighLow |   59.656 |

