﻿using System;
using System.Collections.Generic;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;
using static Zyl.VectorTraits.Impl.VectorMessageFormats;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// Generic style methods for <see cref="Vector128"/> (<see cref="Vector128"/> 的泛型风格方法). 
    /// </summary>
    public static class Vector128Generic {

#if NETCOREAPP3_0_OR_GREATER

#if NET7_0_OR_GREATER

        /// <inheritdoc cref="Vector128s.Widen{T, TOut}(Vector128{T}, out Vector128{TOut}, out Vector128{TOut})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void Widen<T, TOut>(Vector128<T> source, out Vector128<TOut> lower, out Vector128<TOut> upper)
                 where T : struct where TOut : struct {
            if (typeof(float) == typeof(T) && typeof(double) == typeof(TOut)) {
                (Vector128<double> a, Vector128<double> b) = Vector128.Widen(source.As<T, float>());
                lower = a.As<double, TOut>();
                upper = b.As<double, TOut>();
            } else if (typeof(sbyte) == typeof(T) && typeof(short) == typeof(TOut)) {
                (Vector128<short> a, Vector128<short> b) = Vector128.Widen(source.As<T, sbyte>());
                lower = a.As<short, TOut>();
                upper = b.As<short, TOut>();
            } else if (typeof(byte) == typeof(T) && typeof(ushort) == typeof(TOut)) {
                (Vector128<ushort> a, Vector128<ushort> b) = Vector128.Widen(source.As<T, byte>());
                lower = a.As<ushort, TOut>();
                upper = b.As<ushort, TOut>();
            } else if (typeof(short) == typeof(T) && typeof(int) == typeof(TOut)) {
                (Vector128<int> a, Vector128<int> b) = Vector128.Widen(source.As<T, short>());
                lower = a.As<int, TOut>();
                upper = b.As<int, TOut>();
            } else if (typeof(ushort) == typeof(T) && typeof(uint) == typeof(TOut)) {
                (Vector128<uint> a, Vector128<uint> b) = Vector128.Widen(source.As<T, ushort>());
                lower = a.As<uint, TOut>();
                upper = b.As<uint, TOut>();
            } else if (typeof(int) == typeof(T) && typeof(long) == typeof(TOut)) {
                (Vector128<long> a, Vector128<long> b) = Vector128.Widen(source.As<T, int>());
                lower = a.As<long, TOut>();
                upper = b.As<long, TOut>();
            } else if (typeof(uint) == typeof(T) && typeof(ulong) == typeof(TOut)) {
                (Vector128<ulong> a, Vector128<ulong> b) = Vector128.Widen(source.As<T, uint>());
                lower = a.As<ulong, TOut>();
                upper = b.As<ulong, TOut>();
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TOut).Name));
            }
        }

#endif // NET7_0_OR_GREATER

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
