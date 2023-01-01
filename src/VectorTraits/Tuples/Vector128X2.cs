using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;

namespace Zyl.Vector128Traits.Tuples {
    /// <summary>
    /// Represents a <see cref="Vector128"/> tuple with 2 components (表示具有2个组件的向量128元组).
    /// </summary>
#if NETCOREAPP3_0_OR_GREATER
#else
    [Obsolete("Need .NET Core 3.0+ / .NET 5.0+")]
#endif // NETCOREAPP3_0_OR_GREATER
#if NET20_OR_GREATER || NETSTANDARD2_0_OR_GREATER || NETCOREAPP1_0_OR_GREATER
    [Serializable]
#endif
    [StructLayout(LayoutKind.Auto)]
    public struct Vector128X2<T> : IEquatable<Vector128X2<T>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<Vector128X2<T>>
#if NET471_OR_GREATER || NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER
            , ITuple
#endif
#if NETX_0_OR_GREATER
            , IFormattable
#endif
            where T : struct {
        /// <summary>Value.</summary>
#if NETCOREAPP3_0_OR_GREATER
        public ValueTuple<Vector128<T>, Vector128<T>> Val;

        /// <summary>
        /// Create Vector128X2 .
        /// </summary>
        /// <param name="val">Source value.</param>
        public Vector128X2((Vector128<T>, Vector128<T>) val) {
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
        public int CompareTo(Vector128X2<T> other) {
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
            return obj is Vector128X2<T> x &&
                   Val.Equals(x.Val);
        }

        /// <inheritdoc/>
        public bool Equals(Vector128X2<T> other) {
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
        /// An implicit operator to convert a Vector128X2 value to a ValueTuple.
        /// </summary>
        /// <param name="src">Source value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ValueTuple<Vector128<T>, Vector128<T>>(Vector128X2<T> src) {
            return src.Val;
        }

        /// <summary>
        /// An explicit operator to convert a ValueTuple value to a Vector128X2.
        /// </summary>
        /// <param name="src">Source value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Vector128X2<T>(ValueTuple<Vector128<T>, Vector128<T>> src) {
            return new Vector128X2<T>(src);
        }
#endif // NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc/>
        public static bool operator ==(Vector128X2<T> left, Vector128X2<T> right) {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public static bool operator !=(Vector128X2<T> left, Vector128X2<T> right) {
            return !(left == right);
        }
    }
}
#endif // NETCOREAPP3_0_OR_GREATER
