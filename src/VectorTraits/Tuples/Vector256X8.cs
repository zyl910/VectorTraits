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
    /// Represents a <see cref="Vector256"/> tuple with 8 components (表示具有8个组件的向量256元组).
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
    public struct Vector256X8<T> : IEquatable<Vector256X8<T>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<Vector256X8<T>>
#if NET471_OR_GREATER || NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER
            , ITuple
#endif
#if NETX_0_OR_GREATER
            , IFormattable
#endif
            where T : struct {
        /// <summary>Value.</summary>
#if NETCOREAPP3_0_OR_GREATER
        public (Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>) Val;

        /// <summary>
        /// Create Vector256X8 .
        /// </summary>
        /// <param name="val">Source value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vector256X8((Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>) val) {
            Val = val;
        }
#else
        public (byte, byte, byte, byte, byte, byte, byte, byte) Val;
#endif // NETCOREAPP3_0_OR_GREATER

#if NET471_OR_GREATER || NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER
        /// <inheritdoc/>
        readonly int ITuple.Length => ((ITuple)Val).Length;

        /// <inheritdoc/>
        readonly object? ITuple.this[int index] => ((ITuple)Val)[index];
#endif

        /// <inheritdoc/>
        public readonly int CompareTo(Vector256X8<T> other) {
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
            return obj is Vector256X8<T> x &&
                   Val.Equals(x.Val);
        }

        /// <inheritdoc/>
        public readonly bool Equals(Vector256X8<T> other) {
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
                + ", " + Val.Item4.ToString(format, formatProvider)
                + ", " + Val.Item5.ToString(format, formatProvider)
                + ", " + Val.Item6.ToString(format, formatProvider)
                + ", " + Val.Item7.ToString(format, formatProvider)
                + ", " + Val.Rest.Item1.ToString(format, formatProvider)
            ;
            return "(" + rt + ")";
        }
#endif

#if NETCOREAPP3_0_OR_GREATER
        /// <summary>
        /// An implicit operator to convert a Vector256X8 value to a ValueTuple.
        /// </summary>
        /// <param name="src">Source value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator (Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>)(Vector256X8<T> src) {
            return src.Val;
        }

        /// <summary>
        /// An explicit operator to convert a ValueTuple value to a Vector256X8.
        /// </summary>
        /// <param name="src">Source value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector256X8<T>((Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>, Vector256<T>) src) {
            return new Vector256X8<T>(src);
        }
#endif // NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc/>
        public static bool operator ==(Vector256X8<T> left, Vector256X8<T> right) {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public static bool operator !=(Vector256X8<T> left, Vector256X8<T> right) {
            return !(left == right);
        }
    }
}
#endif // NETCOREAPP3_0_OR_GREATER
#endif // ALLOW_VECTOR_TUPLES
