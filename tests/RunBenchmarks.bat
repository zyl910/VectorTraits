@REM Put me to `VectorTraits/tests/`
cd /d "%~dp0"

start /realtime /wait /b VectorTraits.Benchmarks/bin/Release/netcoreapp3.1/VectorTraits.Benchmarks.exe >netcore3.1.txt
start /realtime /wait /b VectorTraits.Benchmarks/bin/Release/net5.0/VectorTraits.Benchmarks.exe >net5.0.txt
start /realtime /wait /b VectorTraits.Benchmarks/bin/Release/net6.0/VectorTraits.Benchmarks.exe >net6.0.txt
start /realtime /wait /b VectorTraits.Benchmarks/bin/Release/net7.0/VectorTraits.Benchmarks.exe >net7.0.txt

timeout /T 60
