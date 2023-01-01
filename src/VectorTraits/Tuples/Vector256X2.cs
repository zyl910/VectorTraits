using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;

namespace Zyl.Vector256Traits.Tuples {
    /// <summary>
    /// Represents a <see cref="Vector256"/> tuple with 2 components (表示具有2个组件的向量256元组).
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER
#else
    [Obsolete("Need .NET Core 3.0+ / .NET 5.0+")]
#endif // NETCOREAPP3_0_OR_GREATER
#if NET20_OR_GREATER || NETSTANDARD2_0_OR_GREATER || NETCOREAPP1_0_OR_GREATER
    [Serializable]
#endif
    [StructLayout(LayoutKind.Auto)]
    public struct Vector256X2<T> : IEquatable<Vector256X2<T>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<Vector256X2<T>>
#if NET471_OR_GREATER || NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER
            , ITuple
#endif
#if NETX_0_OR_GREATER
            , IFormattable
#endif
            where T : struct {
        /// <summary>Value.</summary>
#if NETCOREAPP3_0_OR_GREATER
        public ValueTuple<Vector256<T>, Vector256<T>> Val;

        /// <summary>
        /// Create Vector256X2 .
        /// </summary>
        /// <param name="val">Source value.</param>
        public Vector256X2((Vector256<T>, Vector256<T>) val) {
            Val = val;
        }
#else
        public ValueTuple<byte, byte> Val;
#endif // NETCOREAPP3_0_OR_GREATER

#if NET471_OR_GREATER || NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER
        /// <inheritdoc/>
        int ITuple.Length => ((ITuple)Val).Length;

        /// <inheritdoc/>
        object? ITuple.this[int index] => ((ITuple)Val)[index];
#endif

        /// <inheritdoc/>
        public int CompareTo(Vector256X2<T> other) {
            return Val.CompareTo(other.Val);
        }

        /// <inheritdoc/>
        int IStructuralComparable.CompareTo(object? other, IComparer comparer) {
            return ((IStructuralComparable)Val).CompareTo(other, comparer);
        }

        /// <inheritdoc/>
        int IComparable.CompareTo(object? obj) {
            return ((IComparable)Val).CompareTo(obj);
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj) {
            return obj is Vector256X2<T> x &&
                   Val.Equals(x.Val);
        }

        /// <inheritdoc/>
        public bool Equals(Vector256X2<T> other) {
            return Val.Equals(other.Val);
        }

        /// <inheritdoc/>
        bool IStructuralEquatable.Equals(object? other, IEqualityComparer comparer) {
            return ((IStructuralEquatable)Val).Equals(other, comparer);
        }

        /// <inheritdoc/>
        public override int GetHashCode() {
            return Val.GetHashCode();
        }

        /// <inheritdoc/>
        int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) {
            return ((IStructuralEquatable)Val).GetHashCode(comparer);
        }

        /// <inheritdoc/>
        public override string? ToString() {
            return Val.ToString();
        }

#if NETX_0_OR_GREATER
        /// <inheritdoc/>
        public string ToString(string? format, IFormatProvider? formatProvider) {
            string rt = Val.Item1.ToString(format, formatProvider)
                + ", " + Val.Item2.ToString(format, formatProvider)
            ;
            return "(" + rt + ")";
        }
#endif

#if NETCOREAPP3_0_OR_GREATER
        /// <summary>
        /// An implicit operator to convert a Vector256X2 value to a ValueTuple.
        /// </summary>
        /// <param name="src">Source value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ValueTuple<Vector256<T>, Vector256<T>>(Vector256X2<T> src) {
            return src.Val;
        }

        /// <summary>
        /// An explicit operator to convert a ValueTuple value to a Vector256X2.
        /// </summary>
        /// <param name="src">Source value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector256X2<T>(ValueTuple<Vector256<T>, Vector256<T>> src) {
            return new Vector256X2<T>(src);
        }
#endif // NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc/>
        public static bool operator ==(Vector256X2<T> left, Vector256X2<T> right) {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public static bool operator !=(Vector256X2<T> left, Vector256X2<T> right) {
            return !(left == right);
        }
    }
}
#endif // NETCOREAPP3_0_OR_GREATER
