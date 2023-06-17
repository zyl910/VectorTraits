@REM Put me to `VectorTraits/tests/`
cd /d "%~dp0"
@ECHO OFF

SET my_file=CombineBenchmarks_out.txt
del %my_file%

IF NOT EXIST "netFw.txt" GOTO CombineDone_netFw
ECHO #### .NET Framework >>%my_file%
ECHO ``` >>%my_file%
@ECHO ON
copy "%my_file%"/a+"netFw.txt"/a %my_file%
@ECHO OFF
ECHO ``` >>%my_file%
ECHO+>>%my_file%
:CombineDone_netFw

IF NOT EXIST "netcore2.1.txt" GOTO CombineDone_netcore2_1
ECHO #### .NET Core 2.1 >>%my_file%
ECHO ``` >>%my_file%
@ECHO ON
copy "%my_file%"/a+"netcore2.1.txt"/a %my_file%
@ECHO OFF
ECHO ``` >>%my_file%
ECHO+>>%my_file%
:CombineDone_netcore2_1

IF NOT EXIST "netcore3.1.txt" GOTO CombineDone_netcore3_1
ECHO #### .NET Core 3.1 >>%my_file%
ECHO ``` >>%my_file%
@ECHO ON
copy "%my_file%"/a+"netcore3.1.txt"/a %my_file%
@ECHO OFF
ECHO ``` >>%my_file%
ECHO+>>%my_file%
:CombineDone_netcore3_1

IF NOT EXIST "net5.0.txt" GOTO CombineDone_net5_0
ECHO #### .NET 5 >>%my_file%
ECHO ``` >>%my_file%
@ECHO ON
copy "%my_file%"/a+"net5.0.txt"/a %my_file%
@ECHO OFF
ECHO ``` >>%my_file%
ECHO+>>%my_file%
:CombineDone_net5_0

IF NOT EXIST "net6.0.txt" GOTO CombineDone_net6_0
ECHO #### .NET 6 >>%my_file%
ECHO ``` >>%my_file%
@ECHO ON
copy "%my_file%"/a+"net6.0.txt"/a %my_file%
@ECHO OFF
ECHO ``` >>%my_file%
ECHO+>>%my_file%
:CombineDone_net6_0

IF NOT EXIST "net7.0.txt" GOTO CombineDone_net7_0
ECHO #### .NET 7 >>%my_file%
ECHO ``` >>%my_file%
@ECHO ON
copy "%my_file%"/a+"net7.0.txt"/a %my_file%
@ECHO OFF
ECHO ``` >>%my_file%
ECHO+>>%my_file%
:CombineDone_net7_0

@ECHO ON
timeout /T 60
