﻿#if ALLOW_VECTOR_TUPLES
using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Zyl.VectorTraits.Tuples {
    /// <summary>
    /// Represents a <see cref="Vector"/> tuple with 8 components (表示具有8个组件的向量元组).
    /// </summary>
    /// <typeparam name="T">The vector element type (向量中的元素的类型).</typeparam>
#if NET20_OR_GREATER || NETSTANDARD2_0_OR_GREATER || NETCOREAPP1_0_OR_GREATER
    [Serializable]
#endif
    [StructLayout(LayoutKind.Auto)]
    public struct VectorX8<T> : IEquatable<VectorX8<T>>, IFormattable, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<VectorX8<T>>
#if NET471_OR_GREATER || NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER
            , ITuple
#endif
            where T : struct {
        /// <summary>Value.</summary>
        public (Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>) Val;

        /// <summary>
        /// Create VectorX8 .
        /// </summary>
        /// <param name="val">Source value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VectorX8((Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>) val) {
            Val = val;
        }

#if NET471_OR_GREATER || NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER
        /// <inheritdoc/>
        readonly int ITuple.Length => ((ITuple)Val).Length;

        /// <inheritdoc/>
        readonly object? ITuple.this[int index] => ((ITuple)Val)[index];
#endif

        /// <inheritdoc/>
        public readonly int CompareTo(VectorX8<T> other) {
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
            return obj is VectorX8<T> x &&
                   Val.Equals(x.Val);
        }

        /// <inheritdoc/>
        public readonly bool Equals(VectorX8<T> other) {
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
                + ", " + Val.Rest.Item1.ToString(format, formatProvider)
            ;
            return "(" + rt + ")";
        }

        /// <summary>
        /// An implicit operator to convert a VectorX8 value to a ValueTuple.
        /// </summary>
        /// <param name="src">Source value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator (Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>)(VectorX8<T> src) {
            return src.Val;
        }

        /// <summary>
        /// An explicit operator to convert a ValueTuple value to a VectorX8.
        /// </summary>
        /// <param name="src">Source value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator VectorX8<T>((Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>, Vector<T>) src) {
            return new VectorX8<T>(src);
        }

        /// <inheritdoc/>
        public static bool operator ==(VectorX8<T> left, VectorX8<T> right) {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public static bool operator !=(VectorX8<T> left, VectorX8<T> right) {
            return !(left == right);
        }
    }
}
#endif // ALLOW_VECTOR_TUPLES
