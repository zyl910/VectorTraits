#stty -echo
#set -x

# == RunBenchmarks ==

my_args="-accelerated0 -fixedVector0 -test0 -cpuDetection0"

exe_file="netcoreapp3.1/VectorTraits.Benchmarks.dll"
log_file="netcore3.1.txt"
if [ ! -f "$exe_file" ];then
  exe_file="Release/netcoreapp3.1/VectorTraits.Benchmarks.dll"
  if [ ! -f "$exe_file" ];then
    exe_file="bin/Release/netcoreapp3.1/VectorTraits.Benchmarks.dll"
    if [ ! -f "$exe_file" ];then
      exe_file="VectorTraits.Benchmarks/bin/Release/netcoreapp3.1/VectorTraits.Benchmarks.dll"
      if [ ! -f "$exe_file" ];then
        exe_file=
      fi
    fi
  fi
fi
if [ -n "$exe_file" ]; then 
  set -x
  dotnet $exe_file $my_args >$log_file
  set +x
else 
  set -x
  rm $log_file
  set +x
fi

exe_file="net5.0/VectorTraits.Benchmarks.dll"
log_file="net5.0.txt"
if [ ! -f "$exe_file" ];then
  exe_file="Release/net5.0/VectorTraits.Benchmarks.dll"
  if [ ! -f "$exe_file" ];then
    exe_file="bin/Release/net5.0/VectorTraits.Benchmarks.dll"
    if [ ! -f "$exe_file" ];then
      exe_file="VectorTraits.Benchmarks/bin/Release/net5.0/VectorTraits.Benchmarks.dll"
      if [ ! -f "$exe_file" ];then
        exe_file=
      fi
    fi
  fi
fi
if [ -n "$exe_file" ]; then 
  set -x
  dotnet $exe_file $my_args >$log_file
  set +x
else 
  set -x
  rm $log_file
  set +x
fi

exe_file="net6.0/VectorTraits.Benchmarks.dll"
log_file="net6.0.txt"
if [ ! -f "$exe_file" ];then
  exe_file="Release/net6.0/VectorTraits.Benchmarks.dll"
  if [ ! -f "$exe_file" ];then
    exe_file="bin/Release/net6.0/VectorTraits.Benchmarks.dll"
    if [ ! -f "$exe_file" ];then
      exe_file="VectorTraits.Benchmarks/bin/Release/net6.0/VectorTraits.Benchmarks.dll"
      if [ ! -f "$exe_file" ];then
        exe_file=
      fi
    fi
  fi
fi
if [ -n "$exe_file" ]; then 
  set -x
  dotnet $exe_file $my_args >$log_file
  set +x
else 
  set -x
  rm $log_file
  set +x
fi

exe_file="net7.0/VectorTraits.Benchmarks.dll"
log_file="net7.0.txt"
if [ ! -f "$exe_file" ];then
  exe_file="Release/net7.0/VectorTraits.Benchmarks.dll"
  if [ ! -f "$exe_file" ];then
    exe_file="bin/Release/net7.0/VectorTraits.Benchmarks.dll"
    if [ ! -f "$exe_file" ];then
      exe_file="VectorTraits.Benchmarks/bin/Release/net7.0/VectorTraits.Benchmarks.dll"
      if [ ! -f "$exe_file" ];then
        exe_file=
      fi
    fi
  fi
fi
if [ -n "$exe_file" ]; then 
  set -x
  dotnet $exe_file $my_args >$log_file
  set +x
else 
  set -x
  rm $log_file
  set +x
fi

# == CombineBenchmarks ==

out_file=CombineBenchmarks_out.txt
set -x
rm $out_file
set +x

log_file="netcore3.1.txt"
if [ -f "$log_file" ];then
  echo "#### .NET Core 3.1" >>$out_file
  echo '```' >>$out_file
  set -x
  cat $log_file >>$out_file
  set +x
  echo '```' >>$out_file
  echo >>$out_file
fi

log_file="net5.0.txt"
if [ -f "$log_file" ];then
  echo "#### .NET 5.0" >>$out_file
  echo '```' >>$out_file
  set -x
  cat $log_file >>$out_file
  set +x
  echo '```' >>$out_file
  echo >>$out_file
fi

log_file="net6.0.txt"
if [ -f "$log_file" ];then
  echo "#### .NET 6.0" >>$out_file
  echo '```' >>$out_file
  set -x
  cat $log_file >>$out_file
  set +x
  echo '```' >>$out_file
  echo >>$out_file
fi

log_file="net7.0.txt"
if [ -f "$log_file" ];then
  echo "#### .NET 7.0" >>$out_file
  echo '```' >>$out_file
  set -x
  cat $log_file >>$out_file
  set +x
  echo '```' >>$out_file
  echo >>$out_file
fi

#set +x
