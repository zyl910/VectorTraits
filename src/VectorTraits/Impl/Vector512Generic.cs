using System;
using System.Collections.Generic;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;
using static Zyl.VectorTraits.Impl.VectorMessageFormats;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// Generic style methods for <see cref="Vector512"/> (<see cref="Vector512"/> 的泛型风格方法). 
    /// </summary>
    public static class Vector512Generic {

#if NET8_0_OR_GREATER

        /// <inheritdoc cref="Vector512s.Widen{T, TOut}(Vector512{T}, out Vector512{TOut}, out Vector512{TOut})"/>
        [Obsolete("It is only suitable for unit testing because it contains branching statements and has poor performance. In general, it is recommended to use the non-generic version of the methods (因它含有分支语句, 性能较差, 仅适用于单元测试. 一般情况下, 建议使用非泛型版方法).")]
        public static void Widen<T, TOut>(Vector512<T> source, out Vector512<TOut> lower, out Vector512<TOut> upper)
                 where T : struct where TOut : struct {
            if (typeof(float) == typeof(T) && typeof(double) == typeof(TOut)) {
                (Vector512<double> a, Vector512<double> b) = Vector512.Widen(source.As<T, float>());
                lower = a.As<double, TOut>();
                upper = b.As<double, TOut>();
            } else if (typeof(sbyte) == typeof(T) && typeof(short) == typeof(TOut)) {
                (Vector512<short> a, Vector512<short> b) = Vector512.Widen(source.As<T, sbyte>());
                lower = a.As<short, TOut>();
                upper = b.As<short, TOut>();
            } else if (typeof(byte) == typeof(T) && typeof(ushort) == typeof(TOut)) {
                (Vector512<ushort> a, Vector512<ushort> b) = Vector512.Widen(source.As<T, byte>());
                lower = a.As<ushort, TOut>();
                upper = b.As<ushort, TOut>();
            } else if (typeof(short) == typeof(T) && typeof(int) == typeof(TOut)) {
                (Vector512<int> a, Vector512<int> b) = Vector512.Widen(source.As<T, short>());
                lower = a.As<int, TOut>();
                upper = b.As<int, TOut>();
            } else if (typeof(ushort) == typeof(T) && typeof(uint) == typeof(TOut)) {
                (Vector512<uint> a, Vector512<uint> b) = Vector512.Widen(source.As<T, ushort>());
                lower = a.As<uint, TOut>();
                upper = b.As<uint, TOut>();
            } else if (typeof(int) == typeof(T) && typeof(long) == typeof(TOut)) {
                (Vector512<long> a, Vector512<long> b) = Vector512.Widen(source.As<T, int>());
                lower = a.As<long, TOut>();
                upper = b.As<long, TOut>();
            } else if (typeof(uint) == typeof(T) && typeof(ulong) == typeof(TOut)) {
                (Vector512<ulong> a, Vector512<ulong> b) = Vector512.Widen(source.As<T, uint>());
                lower = a.As<ulong, TOut>();
                upper = b.As<ulong, TOut>();
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TOut).Name));
            }
        }

#endif // NET8_0_OR_GREATER
    }
}
