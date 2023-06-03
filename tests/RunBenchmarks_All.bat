@REM Put me to `VectorTraits/tests/`
cd /d "%~dp0"
@ECHO OFF

:Check_netFw
SET my_path=VectorTraits.Benchmarks.NetFw.exe
IF EXIST "%my_path%" GOTO Run_netFw
SET my_path=Release/VectorTraits.Benchmarks.NetFw.exe
IF EXIST "%my_path%" GOTO Run_netFw
SET my_path=Release/Release/VectorTraits.Benchmarks.NetFw.exe
IF EXIST "%my_path%" GOTO Run_netFw
SET my_path=bin/Release/Release/VectorTraits.Benchmarks.NetFw.exe
IF EXIST "%my_path%" GOTO Run_netFw
SET my_path=VectorTraits.Benchmarks.NetFw/bin/Release/VectorTraits.Benchmarks.NetFw.exe
IF EXIST "%my_path%" GOTO Run_netFw
GOTO Done_netFw
:Run_netFw
@ECHO ON
start /realtime /wait /b %my_path% >netFw.txt
@ECHO OFF
:Done_netFw

:Check_netcore2_1
SET my_path=VectorTraits.Benchmarks.NetCore.dll
IF EXIST "%my_path%" GOTO Run_netcore2_1
SET my_path=netcoreapp2.1/VectorTraits.Benchmarks.NetCore.dll
IF EXIST "%my_path%" GOTO Run_netcore2_1
SET my_path=Release/netcoreapp2.1/VectorTraits.Benchmarks.NetCore.dll
IF EXIST "%my_path%" GOTO Run_netcore2_1
SET my_path=bin/Release/netcoreapp2.1/VectorTraits.Benchmarks.NetCore.dll
IF EXIST "%my_path%" GOTO Run_netcore2_1
SET my_path=VectorTraits.Benchmarks.NetCore/bin/Release/netcoreapp2.1/VectorTraits.Benchmarks.NetCore.dll
IF EXIST "%my_path%" GOTO Run_netcore2_1
GOTO Done_netcore2_1
:Run_netcore2_1
@ECHO ON
start /realtime /wait /b dotnet %my_path% >netcore2.1.txt
@ECHO OFF
:Done_netcore2_1

RunBenchmarks.bat
