#if ALLOW_VECTOR_TUPLES
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;

namespace Zyl.VectorTraits.Tuples {
    /// <summary>
    /// Represents a <see cref="Vector256"/> tuple with 3 components (表示具有3个组件的向量256元组).
    /// </summary>
    /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
#if NETCOREAPP3_0_OR_GREATER
#else
    [Obsolete("Need .NET Core 3.0+ / .NET 5.0+")]
#endif // NETCOREAPP3_0_OR_GREATER
#if NET20_OR_GREATER || NETSTANDARD2_0_OR_GREATER || NETCOREAPP1_0_OR_GREATER
    [Serializable]
#endif
    [StructLayout(LayoutKind.Auto)]
    public struct Vector256X3<T> : IEquatable<Vector256X3<T>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<Vector256X3<T>>
#if NET471_OR_GREATER || NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER
            , ITuple
#endif
#if NETX_0_OR_GREATER
            , IFormattable
#endif
            where T : struct {
        /// <summary>Value.</summary>
#if NETCOREAPP3_0_OR_GREATER
        public ValueTuple<Vector256<T>, Vector256<T>, Vector256<T>> Val;

        /// <summary>
        /// Create Vector256X3 .
        /// </summary>
        /// <param name="val">Source value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector256X3((Vector256<T>, Vector256<T>, Vector256<T>) val) {
            Val = val;
        }
#else
        public ValueTuple<byte, byte, byte> Val;
#endif // NETCOREAPP3_0_OR_GREATER

#if NET471_OR_GREATER || NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER
        /// <inheritdoc/>
        readonly int ITuple.Length => ((ITuple)Val).Length;

        /// <inheritdoc/>
        readonly object? ITuple.this[int index] => ((ITuple)Val)[index];
#endif

        /// <inheritdoc/>
        public readonly int CompareTo(Vector256X3<T> other) {
            return Val.CompareTo(other.Val);
        }

        /// <inheritdoc/>
        readonly int IStructuralComparable.CompareTo(object? other, IComparer comparer) {
            return ((IStructuralComparable)Val).CompareTo(other, comparer);
        }

        /// <inheritdoc/>
        readonly int IComparable.CompareTo(object? obj) {
            return ((IComparable)Val).CompareTo(obj);
        }

        /// <inheritdoc/>
        public override readonly bool Equals(object? obj) {
            return obj is Vector256X3<T> x &&
                   Val.Equals(x.Val);
        }

        /// <inheritdoc/>
        public readonly bool Equals(Vector256X3<T> other) {
            return Val.Equals(other.Val);
        }

        /// <inheritdoc/>
        readonly bool IStructuralEquatable.Equals(object? other, IEqualityComparer comparer) {
            return ((IStructuralEquatable)Val).Equals(other, comparer);
        }

        /// <inheritdoc/>
        public override readonly int GetHashCode() {
            return Val.GetHashCode();
        }

        /// <inheritdoc/>
        readonly int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
            return ((IStructuralEquatable)Val).GetHashCode(comparer);
        }

        /// <inheritdoc/>
        public override readonly string? ToString() {
            return Val.ToString();
        }

#if NETX_0_OR_GREATER
        /// <inheritdoc/>
        public readonly string ToString(string? format, IFormatProvider? formatProvider) {
            string rt = Val.Item1.ToString(format, formatProvider)
                + ", " + Val.Item2.ToString(format, formatProvider)
                + ", " + Val.Item3.ToString(format, formatProvider)
            ;
            return "(" + rt + ")";
        }
#endif

#if NETCOREAPP3_0_OR_GREATER
        /// <summary>
        /// An implicit operator to convert a Vector256X3 value to a ValueTuple.
        /// </summary>
        /// <param name="src">Source value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ValueTuple<Vector256<T>, Vector256<T>, Vector256<T>>(Vector256X3<T> src) {
            return src.Val;
        }

        /// <summary>
        /// An explicit operator to convert a ValueTuple value to a Vector256X3.
        /// </summary>
        /// <param name="src">Source value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector256X3<T>(ValueTuple<Vector256<T>, Vector256<T>, Vector256<T>> src) {
            return new Vector256X3<T>(src);
        }
#endif // NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc/>
        public static bool operator ==(Vector256X3<T> left, Vector256X3<T> right) {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public static bool operator !=(Vector256X3<T> left, Vector256X3<T> right) {
            return !(left == right);
        }
    }
}
#endif // NETCOREAPP3_0_OR_GREATER
#endif // ALLOW_VECTOR_TUPLES
