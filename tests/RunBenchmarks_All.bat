@REM Put me to `VectorTraits/tests/`
cd /d "%~dp0"

start /realtime /wait /b VectorTraits.Benchmarks.NetFw/bin/Release/VectorTraits.Benchmarks.NetFw.exe >netFw.txt
start /realtime /wait /b dotnet VectorTraits.Benchmarks.NetCore/bin/Release/netcoreapp2.1/VectorTraits.Benchmarks.NetCore.dll >netcore2.1.txt

RunBenchmarks.bat
