@REM Put me to `VectorTraits/tests/`
cd /d "%~dp0"
@REM SET COMPlus_EnableAVX2=0

@ECHO OFF
SET my_args=-accelerated0 -fixedVector0 -test0 -cpuDetection0 -allowFakeBenchmark0

:Check_netcore3_1
SET my_path=netcoreapp3.1/VectorTraits.Benchmarks.exe
IF EXIST "%my_path%" GOTO Run_netcore3_1
SET my_path=Release/netcoreapp3.1/VectorTraits.Benchmarks.exe
IF EXIST "%my_path%" GOTO Run_netcore3_1
SET my_path=bin/Release/netcoreapp3.1/VectorTraits.Benchmarks.exe
IF EXIST "%my_path%" GOTO Run_netcore3_1
SET my_path=VectorTraits.Benchmarks/bin/Release/netcoreapp3.1/VectorTraits.Benchmarks.exe
IF EXIST "%my_path%" GOTO Run_netcore3_1
@ECHO ON
del netcore3.1.txt
@ECHO OFF
GOTO Done_netcore3_1
:Run_netcore3_1
@ECHO ON
start /realtime /wait /b %my_path% %my_args% >netcore3.1.txt
@ECHO OFF
:Done_netcore3_1

:Check_net5_0
SET my_path=net5.0/VectorTraits.Benchmarks.exe
IF EXIST "%my_path%" GOTO Run_net5_0
SET my_path=Release/net5.0/VectorTraits.Benchmarks.exe
IF EXIST "%my_path%" GOTO Run_net5_0
SET my_path=bin/Release/net5.0/VectorTraits.Benchmarks.exe
IF EXIST "%my_path%" GOTO Run_net5_0
SET my_path=VectorTraits.Benchmarks/bin/Release/net5.0/VectorTraits.Benchmarks.exe
IF EXIST "%my_path%" GOTO Run_net5_0
@ECHO ON
del net5.0.txt
@ECHO OFF
GOTO Done_net5_0
:Run_net5_0
@ECHO ON
start /realtime /wait /b %my_path% %my_args% >net5.0.txt
@ECHO OFF
:Done_net5_0

:Check_net6_0
SET my_path=net6.0/VectorTraits.Benchmarks.exe
IF EXIST "%my_path%" GOTO Run_net6_0
SET my_path=Release/net6.0/VectorTraits.Benchmarks.exe
IF EXIST "%my_path%" GOTO Run_net6_0
SET my_path=bin/Release/net6.0/VectorTraits.Benchmarks.exe
IF EXIST "%my_path%" GOTO Run_net6_0
SET my_path=VectorTraits.Benchmarks/bin/Release/net6.0/VectorTraits.Benchmarks.exe
IF EXIST "%my_path%" GOTO Run_net6_0
@ECHO ON
del net6.0.txt
@ECHO OFF
GOTO Done_net6_0
:Run_net6_0
@ECHO ON
start /realtime /wait /b %my_path% %my_args% >net6.0.txt
@ECHO OFF
:Done_net6_0

:Check_net7_0
SET my_path=net7.0/VectorTraits.Benchmarks.exe
IF EXIST "%my_path%" GOTO Run_net7_0
SET my_path=Release/net7.0/VectorTraits.Benchmarks.exe
IF EXIST "%my_path%" GOTO Run_net7_0
SET my_path=bin/Release/net7.0/VectorTraits.Benchmarks.exe
IF EXIST "%my_path%" GOTO Run_net7_0
SET my_path=VectorTraits.Benchmarks/bin/Release/net7.0/VectorTraits.Benchmarks.exe
IF EXIST "%my_path%" GOTO Run_net7_0
@ECHO ON
del net7.0.txt
@ECHO OFF
GOTO Done_net7_0
:Run_net7_0
@ECHO ON
start /realtime /wait /b %my_path% %my_args% >net7.0.txt
@ECHO OFF
:Done_net7_0

:Check_net8_0
SET my_path=net8.0/VectorTraits.Benchmarks.exe
IF EXIST "%my_path%" GOTO Run_net8_0
SET my_path=Release/net8.0/VectorTraits.Benchmarks.exe
IF EXIST "%my_path%" GOTO Run_net8_0
SET my_path=bin/Release/net8.0/VectorTraits.Benchmarks.exe
IF EXIST "%my_path%" GOTO Run_net8_0
SET my_path=VectorTraits.Benchmarks/bin/Release/net8.0/VectorTraits.Benchmarks.exe
IF EXIST "%my_path%" GOTO Run_net8_0
@ECHO ON
del net8.0.txt
@ECHO OFF
GOTO Done_net8_0
:Run_net8_0
@ECHO ON
start /realtime /wait /b %my_path% %my_args% >net8.0.txt
@ECHO OFF
:Done_net8_0

@ECHO ON
timeout /T 60
