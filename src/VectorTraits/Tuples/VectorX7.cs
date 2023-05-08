#if !OFF_VECTOR_TUPLES
using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Zyl.VectorTraits.Tuples {
    /// <summary>
    /// Represents a <see cref="Vector"/> tuple with 7 components (表示具有7个组件的向量元组).
    /// </summary>
    /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
#if NET20_OR_GREATER || NETSTANDARD2_0_OR_GREATER || NETCOREAPP1_0_OR_GREATER
    [Serializable]
#endif
    [StructLayout(LayoutKind.Auto)]
    public struct VectorX7<T> : IEquatable<VectorX7<T>>, IFormattable, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<VectorX7<T>>
#if NET471_OR_GREATER || NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER
            , ITuple
#endif
            where T : struct {
        /// <summary>Value.</summary>
        public ValueTuple<Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>> Val;

        /// <summary>
        /// Create VectorX7 .
        /// </summary>
        /// <param name="val">Source value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VectorX7((Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>) val) {
            Val = val;
        }

#if NET471_OR_GREATER || NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER
        /// <inheritdoc/>
        readonly int ITuple.Length => ((ITuple)Val).Length;

        /// <inheritdoc/>
        readonly object? ITuple.this[int index] => ((ITuple)Val)[index];
#endif

        /// <inheritdoc/>
        public readonly int CompareTo(VectorX7<T> other) {
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
            return obj is VectorX7<T> x &&
                   Val.Equals(x.Val);
        }

        /// <inheritdoc/>
        public readonly bool Equals(VectorX7<T> other) {
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

        /// <inheritdoc/>
        public readonly string ToString(string? format, IFormatProvider? formatProvider) {
            string rt = Val.Item1.ToString(format, formatProvider)
                + ", " + Val.Item2.ToString(format, formatProvider)
                + ", " + Val.Item3.ToString(format, formatProvider)
                + ", " + Val.Item4.ToString(format, formatProvider)
                + ", " + Val.Item5.ToString(format, formatProvider)
                + ", " + Val.Item6.ToString(format, formatProvider)
                + ", " + Val.Item7.ToString(format, formatProvider)
            ;
            return "(" + rt + ")";
        }

        /// <summary>
        /// An implicit operator to convert a VectorX7 value to a ValueTuple.
        /// </summary>
        /// <param name="src">Source value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator ValueTuple<Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>>(VectorX7<T> src) {
            return src.Val;
        }

        /// <summary>
        /// An explicit operator to convert a ValueTuple value to a VectorX7.
        /// </summary>
        /// <param name="src">Source value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator VectorX7<T>(ValueTuple<Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>> src) {
            return new VectorX7<T>(src);
        }

        /// <inheritdoc/>
        public static bool operator ==(VectorX7<T> left, VectorX7<T> right) {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public static bool operator !=(VectorX7<T> left, VectorX7<T> right) {
            return !(left == right);
        }
    }
}
#endif // !OFF_VECTOR_TUPLES
