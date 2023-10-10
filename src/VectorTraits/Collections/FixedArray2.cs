using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Zyl.VectorTraits.Collections {
    /// <summary>
    /// An array of fixed capacity 2 (容量固定为2的数组).
    /// </summary>
    /// <typeparam name="T">The array element type (数组中的元素的类型).</typeparam>
    [DebuggerDisplay("Count={Count}, Items=[{I0}, {I1}]")]
#if NET20_OR_GREATER || NETSTANDARD2_0_OR_GREATER || NETCOREAPP1_0_OR_GREATER
    [Serializable]
#endif
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct FixedArray2<T> : IEquatable<FixedArray2<T>>, IFixedArray<T>, IReadOnlyList<T>
            where T : struct {
        /// <summary>Capacity value.</summary>
        public const int CapacityValue = 2;

        // -- Items --
        /// <summary>Item 0.</summary>
        public T I0;
        /// <summary>Item 1.</summary>
        public T I1;

        /// <inheritdoc/>
        public override readonly bool Equals(object? obj) {
            if (null == obj) return false;
            if (!(obj is FixedArray2<T>)) return false;
            return Equals((FixedArray2<T>)obj);
        }

        /// <inheritdoc/>
        public readonly bool Equals(FixedArray2<T> other) {
            if (!I0.Equals(other.I0)) return false;
            if (!I1.Equals(other.I1)) return false;
            return true;
        }

        /// <inheritdoc/>
        public override readonly int GetHashCode() {
            int rt = I0.GetHashCode();
            rt ^= I1.GetHashCode();
            return rt;
        }

        /// <inheritdoc/>
        public readonly IEnumerator<T> GetEnumerator() {
            for (int i = 0; i < Count; ++i) {
                yield return this[i];
            }
        }

        /// <inheritdoc/>
        readonly IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        /// <inheritdoc/>
        public readonly int Count {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                return CapacityValue;
            }
        }

        /// <inheritdoc/>
        public T this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get {
                return Unsafe.Add(ref Unsafe.AsRef(in I0), index);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                Unsafe.Add(ref I0, index) = value;
            }
        }

        /// <inheritdoc/>
        public static bool operator ==(FixedArray2<T> left, FixedArray2<T> right) {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public static bool operator !=(FixedArray2<T> left, FixedArray2<T> right) {
            return !(left == right);
        }

    }
}
