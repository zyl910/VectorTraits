using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits {
    static partial class Vector256s {

        private static readonly string FORMAT_TYPE_NOT_SUPPORTED_2 = Vector256Generic.FORMAT_TYPE_NOT_SUPPORTED_2;

#if NETCOREAPP3_0_OR_GREATER


        /// <inheritdoc cref="Vector256Generic.Widen{T, TOut}(Vector256{T}, out Vector256{TOut}, out Vector256{TOut})"/>
        public static void Widen<T, TOut>(Vector256<T> source, out Vector256<TOut> lower, out Vector256<TOut> upper)
                 where T : struct where TOut : struct {
            if (typeof(float) == typeof(T) && typeof(double) == typeof(TOut)) {
                Widen((Vector256<float>)(object)source, out Vector256<double> a, out Vector256<double> b);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(sbyte) == typeof(T) && typeof(short) == typeof(TOut)) {
                Widen((Vector256<sbyte>)(object)source, out Vector256<short> a, out Vector256<short> b);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(byte) == typeof(T) && typeof(ushort) == typeof(TOut)) {
                Widen((Vector256<byte>)(object)source, out Vector256<ushort> a, out Vector256<ushort> b);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(short) == typeof(T) && typeof(int) == typeof(TOut)) {
                Widen((Vector256<short>)(object)source, out Vector256<int> a, out Vector256<int> b);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(ushort) == typeof(T) && typeof(uint) == typeof(TOut)) {
                Widen((Vector256<ushort>)(object)source, out Vector256<uint> a, out Vector256<uint> b);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(int) == typeof(T) && typeof(long) == typeof(TOut)) {
                Widen((Vector256<int>)(object)source, out Vector256<long> a, out Vector256<long> b);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else if (typeof(uint) == typeof(T) && typeof(ulong) == typeof(TOut)) {
                Widen((Vector256<uint>)(object)source, out Vector256<ulong> a, out Vector256<ulong> b);
                lower = (Vector256<TOut>)(object)a;
                upper = (Vector256<TOut>)(object)b;
            } else {
                throw new NotSupportedException(string.Format(FORMAT_TYPE_NOT_SUPPORTED_2, typeof(T).Name, typeof(TOut).Name));
            }
        }

#endif // NETCOREAPP3_0_OR_GREATER
    }
}
