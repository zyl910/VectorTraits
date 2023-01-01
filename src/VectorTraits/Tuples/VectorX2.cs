using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Zyl.VectorTraits.Tuples {
    /// <summary>
    /// Represents a <see cref="Vector"/> tuple with 2 components (表示具有2个组件的向量元组).
    /// </summary>
#if NET20_OR_GREATER || NETSTANDARD2_0_OR_GREATER || NETCOREAPP1_0_OR_GREATER
    [Serializable]
#endif
    [StructLayout(LayoutKind.Auto)]
    public struct VectorX2<T> : IEquatable<VectorX2<T>>, IFormattable, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<VectorX2<T>>
#if NET471_OR_GREATER || NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER
            , ITuple
#endif
            where T : struct {
        /// <summary>Value.</summary>
        public ValueTuple<Vector<T>, Vector<T>> Val;

        /// <summary>
        /// Create VectorX2 .
        /// </summary>
        /// <param name="val">Source value.</param>
        public VectorX2((Vector<T>, Vector<T>) val) {
            Val = val;
        }

#if NET471_OR_GREATER || NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER
        /// <inheritdoc/>
        int ITuple.Length => ((ITuple)Val).Length;

        /// <inheritdoc/>
        object? ITuple.this[int index] => ((ITuple)Val)[index];
#endif

        /// <inheritdoc/>
        public int CompareTo(VectorX2<T> other) {
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
            return obj is VectorX2<T> x &&
                   Val.Equals(x.Val);
        }

        /// <inheritdoc/>
        public bool Equals(VectorX2<T> other) {
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

        /// <inheritdoc/>
        public string ToString(string? format, IFormatProvider? formatProvider) {
            string rt = Val.Item1.ToString(format, formatProvider)
                + ", " + Val.Item2.ToString(format, formatProvider)
            ;
            return "(" + rt + ")";
        }

        /// <summary>
        /// An implicit operator to convert a VectorX2 value to a ValueTuple.
        /// </summary>
        /// <param name="src">Source value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ValueTuple<Vector<T>, Vector<T>>(VectorX2<T> src) {
            return src.Val;
        }

        /// <summary>
        /// An explicit operator to convert a ValueTuple value to a VectorX2.
        /// </summary>
        /// <param name="src">Source value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator VectorX2<T>(ValueTuple<Vector<T>, Vector<T>> src) {
            return new VectorX2<T>(src);
        }

        /// <inheritdoc/>
        public static bool operator ==(VectorX2<T> left, VectorX2<T> right) {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public static bool operator !=(VectorX2<T> left, VectorX2<T> right) {
            return !(left == right);
        }
    }
}
