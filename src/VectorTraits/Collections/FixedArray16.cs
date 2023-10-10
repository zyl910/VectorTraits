//#define AllowMe
#if AllowMe
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Zyl.VectorTraits.Collections {
    /// <summary>
    /// An array of fixed capacity 16 (容量固定为16的数组).
    /// </summary>
    /// <typeparam name="T">The array element type (数组中的元素的类型).</typeparam>
    [DebuggerDisplay("Count={Count}, Items=[{I0}, {I1}, {I2}, {I3}, ...]")]
#if NET20_OR_GREATER || NETSTANDARD2_0_OR_GREATER || NETCOREAPP1_0_OR_GREATER
    [Serializable]
#endif
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct FixedArray16<T> : IEquatable<FixedArray16<T>>, IFixedArray<T>, IReadOnlyList<T>
            where T : struct {
        /// <summary>Capacity value.</summary>
        public const int CapacityValue = 16;

        // -- Items --
        /// <summary>Item 0.</summary>
        public T I0;
        public T I1;
        public T I2;
        public T I3;
        public T I4;
        public T I5;
        public T I6;
        public T I7;
        public T I8;
        public T I9;
        public T I10;
        public T I11;
        public T I12;
        public T I13;
        public T I14;
        public T I15;

        /// <inheritdoc/>
        public override readonly bool Equals(object? obj) {
            if (null == obj) return false;
            if (!(obj is FixedArray16<T>)) return false;
            return Equals((FixedArray16<T>)obj);
        }

        /// <inheritdoc/>
        public readonly bool Equals(FixedArray16<T> other) {
            if (!I0.Equals(other.I0)) return false;
            if (!I1.Equals(other.I1)) return false;
            if (!I2.Equals(other.I2)) return false;
            if (!I3.Equals(other.I3)) return false;
            if (!I4.Equals(other.I4)) return false;
            if (!I5.Equals(other.I5)) return false;
            if (!I6.Equals(other.I6)) return false;
            if (!I7.Equals(other.I7)) return false;
            if (!I8.Equals(other.I8)) return false;
            if (!I9.Equals(other.I9)) return false;
            if (!I10.Equals(other.I10)) return false;
            if (!I11.Equals(other.I11)) return false;
            if (!I12.Equals(other.I12)) return false;
            if (!I13.Equals(other.I13)) return false;
            if (!I14.Equals(other.I14)) return false;
            if (!I15.Equals(other.I15)) return false;
            return true;
        }

        /// <inheritdoc/>
        public override readonly int GetHashCode() {
            int rt = I0.GetHashCode();
            rt ^= I1.GetHashCode();
            rt ^= I2.GetHashCode();
            rt ^= I3.GetHashCode();
            rt ^= I4.GetHashCode();
            rt ^= I5.GetHashCode();
            rt ^= I6.GetHashCode();
            rt ^= I7.GetHashCode();
            rt ^= I8.GetHashCode();
            rt ^= I9.GetHashCode();
            rt ^= I10.GetHashCode();
            rt ^= I11.GetHashCode();
            rt ^= I12.GetHashCode();
            rt ^= I13.GetHashCode();
            rt ^= I14.GetHashCode();
            rt ^= I15.GetHashCode();
            return rt;
        }

        /// <inheritdoc/>
        public IEnumerator<T> GetEnumerator() {
            for (int i = 0; i < Count; ++i) {
                yield return this[i];
            }
        }

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        /// <inheritdoc/>
        public int Count {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                return CapacityValue;
            }
        }

        /// <inheritdoc/>
        public T this[int index] {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get {
                return Unsafe.Add(ref I0, index);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set {
                Unsafe.Add(ref I0, index) = value;
            }
        }

        /// <inheritdoc/>
        public static bool operator ==(FixedArray16<T> left, FixedArray16<T> right) {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public static bool operator !=(FixedArray16<T> left, FixedArray16<T> right) {
            return !(left == right);
        }

    }
}
#endif // AllowMe
