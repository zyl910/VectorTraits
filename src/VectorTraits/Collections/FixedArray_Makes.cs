






using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Zyl.VectorTraits.Collections {

    /// <summary>
    /// An array of fixed capacity 4 (容量固定为4的数组).
    /// </summary>
    /// <typeparam name="T">The array element type (数组中的元素的类型).</typeparam>
    [DebuggerDisplay("Count={Count}, Items=[{I0}, {I1}, {I2}, {I3}]")]
#if NET20_OR_GREATER || NETSTANDARD2_0_OR_GREATER || NETCOREAPP1_0_OR_GREATER
    [Serializable]
#endif
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct FixedArray4<T> : IEquatable<FixedArray4<T>>, IFixedArray<T>, IReadOnlyList<T>
            where T : struct {
        /// <summary>Capacity value.</summary>
        public const int CapacityValue = 4;

        // -- Items --
        /// <summary>Item 0.</summary>
        public T I0;
        /// <summary>Item 1.</summary>
        public T I1;
        /// <summary>Item 2.</summary>
        public T I2;
        /// <summary>Item 3.</summary>
        public T I3;


        /// <inheritdoc/>
        public override readonly bool Equals(object? obj) {
            if (null == obj) return false;
            if (!(obj is FixedArray4<T>)) return false;
            return Equals((FixedArray4<T>)obj);
        }

        /// <inheritdoc/>
        public readonly bool Equals(FixedArray4<T> other) {
            if (!I0.Equals(other.I0)) return false;
            if (!I1.Equals(other.I1)) return false;
            if (!I2.Equals(other.I2)) return false;
            if (!I3.Equals(other.I3)) return false;

            return true;
        }

        /// <inheritdoc/>
        public override readonly int GetHashCode() {
            int rt = I0.GetHashCode();
            rt ^= I1.GetHashCode();
            rt ^= I2.GetHashCode();
            rt ^= I3.GetHashCode();

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
        public static bool operator ==(FixedArray4<T> left, FixedArray4<T> right) {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public static bool operator !=(FixedArray4<T> left, FixedArray4<T> right) {
            return !(left == right);
        }

    } // End: struct FixedArray4

    /// <summary>
    /// An array of fixed capacity 8 (容量固定为8的数组).
    /// </summary>
    /// <typeparam name="T">The array element type (数组中的元素的类型).</typeparam>
    [DebuggerDisplay("Count={Count}, Items=[{I0}, {I1}, {I2}, {I3}, {I4}, {I5}, {I6}, {I7}]")]
#if NET20_OR_GREATER || NETSTANDARD2_0_OR_GREATER || NETCOREAPP1_0_OR_GREATER
    [Serializable]
#endif
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct FixedArray8<T> : IEquatable<FixedArray8<T>>, IFixedArray<T>, IReadOnlyList<T>
            where T : struct {
        /// <summary>Capacity value.</summary>
        public const int CapacityValue = 8;

        // -- Items --
        /// <summary>Item 0.</summary>
        public T I0;
        /// <summary>Item 1.</summary>
        public T I1;
        /// <summary>Item 2.</summary>
        public T I2;
        /// <summary>Item 3.</summary>
        public T I3;
        /// <summary>Item 4.</summary>
        public T I4;
        /// <summary>Item 5.</summary>
        public T I5;
        /// <summary>Item 6.</summary>
        public T I6;
        /// <summary>Item 7.</summary>
        public T I7;


        /// <inheritdoc/>
        public override readonly bool Equals(object? obj) {
            if (null == obj) return false;
            if (!(obj is FixedArray8<T>)) return false;
            return Equals((FixedArray8<T>)obj);
        }

        /// <inheritdoc/>
        public readonly bool Equals(FixedArray8<T> other) {
            if (!I0.Equals(other.I0)) return false;
            if (!I1.Equals(other.I1)) return false;
            if (!I2.Equals(other.I2)) return false;
            if (!I3.Equals(other.I3)) return false;
            if (!I4.Equals(other.I4)) return false;
            if (!I5.Equals(other.I5)) return false;
            if (!I6.Equals(other.I6)) return false;
            if (!I7.Equals(other.I7)) return false;

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
        public static bool operator ==(FixedArray8<T> left, FixedArray8<T> right) {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public static bool operator !=(FixedArray8<T> left, FixedArray8<T> right) {
            return !(left == right);
        }

    } // End: struct FixedArray8

    /// <summary>
    /// An array of fixed capacity 16 (容量固定为16的数组).
    /// </summary>
    /// <typeparam name="T">The array element type (数组中的元素的类型).</typeparam>
    [DebuggerDisplay("Count={Count}, Items=[{I0}, {I1}, {I2}, {I3}, {I4}, {I5}, {I6}, {I7} ...]")]
#if NET20_OR_GREATER || NETSTANDARD2_0_OR_GREATER || NETCOREAPP1_0_OR_GREATER
    [Serializable]
#endif
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct FixedArray16<T> : IEquatable<FixedArray16<T>>, IFixedArray<T>, IReadOnlyList<T>
            where T : struct {
        /// <summary>Capacity value.</summary>
        public const int CapacityValue = 16;

        // -- Items --
        /// <summary>Item 0.</summary>
        public T I0;
        /// <summary>Item 1.</summary>
        public T I1;
        /// <summary>Item 2.</summary>
        public T I2;
        /// <summary>Item 3.</summary>
        public T I3;
        /// <summary>Item 4.</summary>
        public T I4;
        /// <summary>Item 5.</summary>
        public T I5;
        /// <summary>Item 6.</summary>
        public T I6;
        /// <summary>Item 7.</summary>
        public T I7;
        /// <summary>Item 8.</summary>
        public T I8;
        /// <summary>Item 9.</summary>
        public T I9;
        /// <summary>Item 10.</summary>
        public T I10;
        /// <summary>Item 11.</summary>
        public T I11;
        /// <summary>Item 12.</summary>
        public T I12;
        /// <summary>Item 13.</summary>
        public T I13;
        /// <summary>Item 14.</summary>
        public T I14;
        /// <summary>Item 15.</summary>
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
        public static bool operator ==(FixedArray16<T> left, FixedArray16<T> right) {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public static bool operator !=(FixedArray16<T> left, FixedArray16<T> right) {
            return !(left == right);
        }

    } // End: struct FixedArray16

    /// <summary>
    /// An array of fixed capacity 32 (容量固定为32的数组).
    /// </summary>
    /// <typeparam name="T">The array element type (数组中的元素的类型).</typeparam>
    [DebuggerDisplay("Count={Count}, Items=[{I0}, {I1}, {I2}, {I3}, {I4}, {I5}, {I6}, {I7} ...]")]
#if NET20_OR_GREATER || NETSTANDARD2_0_OR_GREATER || NETCOREAPP1_0_OR_GREATER
    [Serializable]
#endif
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct FixedArray32<T> : IEquatable<FixedArray32<T>>, IFixedArray<T>, IReadOnlyList<T>
            where T : struct {
        /// <summary>Capacity value.</summary>
        public const int CapacityValue = 32;

        // -- Items --
        /// <summary>Item 0.</summary>
        public T I0;
        /// <summary>Item 1.</summary>
        public T I1;
        /// <summary>Item 2.</summary>
        public T I2;
        /// <summary>Item 3.</summary>
        public T I3;
        /// <summary>Item 4.</summary>
        public T I4;
        /// <summary>Item 5.</summary>
        public T I5;
        /// <summary>Item 6.</summary>
        public T I6;
        /// <summary>Item 7.</summary>
        public T I7;
        /// <summary>Item 8.</summary>
        public T I8;
        /// <summary>Item 9.</summary>
        public T I9;
        /// <summary>Item 10.</summary>
        public T I10;
        /// <summary>Item 11.</summary>
        public T I11;
        /// <summary>Item 12.</summary>
        public T I12;
        /// <summary>Item 13.</summary>
        public T I13;
        /// <summary>Item 14.</summary>
        public T I14;
        /// <summary>Item 15.</summary>
        public T I15;
        /// <summary>Item 16.</summary>
        public T I16;
        /// <summary>Item 17.</summary>
        public T I17;
        /// <summary>Item 18.</summary>
        public T I18;
        /// <summary>Item 19.</summary>
        public T I19;
        /// <summary>Item 20.</summary>
        public T I20;
        /// <summary>Item 21.</summary>
        public T I21;
        /// <summary>Item 22.</summary>
        public T I22;
        /// <summary>Item 23.</summary>
        public T I23;
        /// <summary>Item 24.</summary>
        public T I24;
        /// <summary>Item 25.</summary>
        public T I25;
        /// <summary>Item 26.</summary>
        public T I26;
        /// <summary>Item 27.</summary>
        public T I27;
        /// <summary>Item 28.</summary>
        public T I28;
        /// <summary>Item 29.</summary>
        public T I29;
        /// <summary>Item 30.</summary>
        public T I30;
        /// <summary>Item 31.</summary>
        public T I31;


        /// <inheritdoc/>
        public override readonly bool Equals(object? obj) {
            if (null == obj) return false;
            if (!(obj is FixedArray32<T>)) return false;
            return Equals((FixedArray32<T>)obj);
        }

        /// <inheritdoc/>
        public readonly bool Equals(FixedArray32<T> other) {
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
            if (!I16.Equals(other.I16)) return false;
            if (!I17.Equals(other.I17)) return false;
            if (!I18.Equals(other.I18)) return false;
            if (!I19.Equals(other.I19)) return false;
            if (!I20.Equals(other.I20)) return false;
            if (!I21.Equals(other.I21)) return false;
            if (!I22.Equals(other.I22)) return false;
            if (!I23.Equals(other.I23)) return false;
            if (!I24.Equals(other.I24)) return false;
            if (!I25.Equals(other.I25)) return false;
            if (!I26.Equals(other.I26)) return false;
            if (!I27.Equals(other.I27)) return false;
            if (!I28.Equals(other.I28)) return false;
            if (!I29.Equals(other.I29)) return false;
            if (!I30.Equals(other.I30)) return false;
            if (!I31.Equals(other.I31)) return false;

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
            rt ^= I16.GetHashCode();
            rt ^= I17.GetHashCode();
            rt ^= I18.GetHashCode();
            rt ^= I19.GetHashCode();
            rt ^= I20.GetHashCode();
            rt ^= I21.GetHashCode();
            rt ^= I22.GetHashCode();
            rt ^= I23.GetHashCode();
            rt ^= I24.GetHashCode();
            rt ^= I25.GetHashCode();
            rt ^= I26.GetHashCode();
            rt ^= I27.GetHashCode();
            rt ^= I28.GetHashCode();
            rt ^= I29.GetHashCode();
            rt ^= I30.GetHashCode();
            rt ^= I31.GetHashCode();

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
        public static bool operator ==(FixedArray32<T> left, FixedArray32<T> right) {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public static bool operator !=(FixedArray32<T> left, FixedArray32<T> right) {
            return !(left == right);
        }

    } // End: struct FixedArray32

    /// <summary>
    /// An array of fixed capacity 64 (容量固定为64的数组).
    /// </summary>
    /// <typeparam name="T">The array element type (数组中的元素的类型).</typeparam>
    [DebuggerDisplay("Count={Count}, Items=[{I0}, {I1}, {I2}, {I3}, {I4}, {I5}, {I6}, {I7} ...]")]
#if NET20_OR_GREATER || NETSTANDARD2_0_OR_GREATER || NETCOREAPP1_0_OR_GREATER
    [Serializable]
#endif
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct FixedArray64<T> : IEquatable<FixedArray64<T>>, IFixedArray<T>, IReadOnlyList<T>
            where T : struct {
        /// <summary>Capacity value.</summary>
        public const int CapacityValue = 64;

        // -- Items --
        /// <summary>Item 0.</summary>
        public T I0;
        /// <summary>Item 1.</summary>
        public T I1;
        /// <summary>Item 2.</summary>
        public T I2;
        /// <summary>Item 3.</summary>
        public T I3;
        /// <summary>Item 4.</summary>
        public T I4;
        /// <summary>Item 5.</summary>
        public T I5;
        /// <summary>Item 6.</summary>
        public T I6;
        /// <summary>Item 7.</summary>
        public T I7;
        /// <summary>Item 8.</summary>
        public T I8;
        /// <summary>Item 9.</summary>
        public T I9;
        /// <summary>Item 10.</summary>
        public T I10;
        /// <summary>Item 11.</summary>
        public T I11;
        /// <summary>Item 12.</summary>
        public T I12;
        /// <summary>Item 13.</summary>
        public T I13;
        /// <summary>Item 14.</summary>
        public T I14;
        /// <summary>Item 15.</summary>
        public T I15;
        /// <summary>Item 16.</summary>
        public T I16;
        /// <summary>Item 17.</summary>
        public T I17;
        /// <summary>Item 18.</summary>
        public T I18;
        /// <summary>Item 19.</summary>
        public T I19;
        /// <summary>Item 20.</summary>
        public T I20;
        /// <summary>Item 21.</summary>
        public T I21;
        /// <summary>Item 22.</summary>
        public T I22;
        /// <summary>Item 23.</summary>
        public T I23;
        /// <summary>Item 24.</summary>
        public T I24;
        /// <summary>Item 25.</summary>
        public T I25;
        /// <summary>Item 26.</summary>
        public T I26;
        /// <summary>Item 27.</summary>
        public T I27;
        /// <summary>Item 28.</summary>
        public T I28;
        /// <summary>Item 29.</summary>
        public T I29;
        /// <summary>Item 30.</summary>
        public T I30;
        /// <summary>Item 31.</summary>
        public T I31;
        /// <summary>Item 32.</summary>
        public T I32;
        /// <summary>Item 33.</summary>
        public T I33;
        /// <summary>Item 34.</summary>
        public T I34;
        /// <summary>Item 35.</summary>
        public T I35;
        /// <summary>Item 36.</summary>
        public T I36;
        /// <summary>Item 37.</summary>
        public T I37;
        /// <summary>Item 38.</summary>
        public T I38;
        /// <summary>Item 39.</summary>
        public T I39;
        /// <summary>Item 40.</summary>
        public T I40;
        /// <summary>Item 41.</summary>
        public T I41;
        /// <summary>Item 42.</summary>
        public T I42;
        /// <summary>Item 43.</summary>
        public T I43;
        /// <summary>Item 44.</summary>
        public T I44;
        /// <summary>Item 45.</summary>
        public T I45;
        /// <summary>Item 46.</summary>
        public T I46;
        /// <summary>Item 47.</summary>
        public T I47;
        /// <summary>Item 48.</summary>
        public T I48;
        /// <summary>Item 49.</summary>
        public T I49;
        /// <summary>Item 50.</summary>
        public T I50;
        /// <summary>Item 51.</summary>
        public T I51;
        /// <summary>Item 52.</summary>
        public T I52;
        /// <summary>Item 53.</summary>
        public T I53;
        /// <summary>Item 54.</summary>
        public T I54;
        /// <summary>Item 55.</summary>
        public T I55;
        /// <summary>Item 56.</summary>
        public T I56;
        /// <summary>Item 57.</summary>
        public T I57;
        /// <summary>Item 58.</summary>
        public T I58;
        /// <summary>Item 59.</summary>
        public T I59;
        /// <summary>Item 60.</summary>
        public T I60;
        /// <summary>Item 61.</summary>
        public T I61;
        /// <summary>Item 62.</summary>
        public T I62;
        /// <summary>Item 63.</summary>
        public T I63;


        /// <inheritdoc/>
        public override readonly bool Equals(object? obj) {
            if (null == obj) return false;
            if (!(obj is FixedArray64<T>)) return false;
            return Equals((FixedArray64<T>)obj);
        }

        /// <inheritdoc/>
        public readonly bool Equals(FixedArray64<T> other) {
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
            if (!I16.Equals(other.I16)) return false;
            if (!I17.Equals(other.I17)) return false;
            if (!I18.Equals(other.I18)) return false;
            if (!I19.Equals(other.I19)) return false;
            if (!I20.Equals(other.I20)) return false;
            if (!I21.Equals(other.I21)) return false;
            if (!I22.Equals(other.I22)) return false;
            if (!I23.Equals(other.I23)) return false;
            if (!I24.Equals(other.I24)) return false;
            if (!I25.Equals(other.I25)) return false;
            if (!I26.Equals(other.I26)) return false;
            if (!I27.Equals(other.I27)) return false;
            if (!I28.Equals(other.I28)) return false;
            if (!I29.Equals(other.I29)) return false;
            if (!I30.Equals(other.I30)) return false;
            if (!I31.Equals(other.I31)) return false;
            if (!I32.Equals(other.I32)) return false;
            if (!I33.Equals(other.I33)) return false;
            if (!I34.Equals(other.I34)) return false;
            if (!I35.Equals(other.I35)) return false;
            if (!I36.Equals(other.I36)) return false;
            if (!I37.Equals(other.I37)) return false;
            if (!I38.Equals(other.I38)) return false;
            if (!I39.Equals(other.I39)) return false;
            if (!I40.Equals(other.I40)) return false;
            if (!I41.Equals(other.I41)) return false;
            if (!I42.Equals(other.I42)) return false;
            if (!I43.Equals(other.I43)) return false;
            if (!I44.Equals(other.I44)) return false;
            if (!I45.Equals(other.I45)) return false;
            if (!I46.Equals(other.I46)) return false;
            if (!I47.Equals(other.I47)) return false;
            if (!I48.Equals(other.I48)) return false;
            if (!I49.Equals(other.I49)) return false;
            if (!I50.Equals(other.I50)) return false;
            if (!I51.Equals(other.I51)) return false;
            if (!I52.Equals(other.I52)) return false;
            if (!I53.Equals(other.I53)) return false;
            if (!I54.Equals(other.I54)) return false;
            if (!I55.Equals(other.I55)) return false;
            if (!I56.Equals(other.I56)) return false;
            if (!I57.Equals(other.I57)) return false;
            if (!I58.Equals(other.I58)) return false;
            if (!I59.Equals(other.I59)) return false;
            if (!I60.Equals(other.I60)) return false;
            if (!I61.Equals(other.I61)) return false;
            if (!I62.Equals(other.I62)) return false;
            if (!I63.Equals(other.I63)) return false;

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
            rt ^= I16.GetHashCode();
            rt ^= I17.GetHashCode();
            rt ^= I18.GetHashCode();
            rt ^= I19.GetHashCode();
            rt ^= I20.GetHashCode();
            rt ^= I21.GetHashCode();
            rt ^= I22.GetHashCode();
            rt ^= I23.GetHashCode();
            rt ^= I24.GetHashCode();
            rt ^= I25.GetHashCode();
            rt ^= I26.GetHashCode();
            rt ^= I27.GetHashCode();
            rt ^= I28.GetHashCode();
            rt ^= I29.GetHashCode();
            rt ^= I30.GetHashCode();
            rt ^= I31.GetHashCode();
            rt ^= I32.GetHashCode();
            rt ^= I33.GetHashCode();
            rt ^= I34.GetHashCode();
            rt ^= I35.GetHashCode();
            rt ^= I36.GetHashCode();
            rt ^= I37.GetHashCode();
            rt ^= I38.GetHashCode();
            rt ^= I39.GetHashCode();
            rt ^= I40.GetHashCode();
            rt ^= I41.GetHashCode();
            rt ^= I42.GetHashCode();
            rt ^= I43.GetHashCode();
            rt ^= I44.GetHashCode();
            rt ^= I45.GetHashCode();
            rt ^= I46.GetHashCode();
            rt ^= I47.GetHashCode();
            rt ^= I48.GetHashCode();
            rt ^= I49.GetHashCode();
            rt ^= I50.GetHashCode();
            rt ^= I51.GetHashCode();
            rt ^= I52.GetHashCode();
            rt ^= I53.GetHashCode();
            rt ^= I54.GetHashCode();
            rt ^= I55.GetHashCode();
            rt ^= I56.GetHashCode();
            rt ^= I57.GetHashCode();
            rt ^= I58.GetHashCode();
            rt ^= I59.GetHashCode();
            rt ^= I60.GetHashCode();
            rt ^= I61.GetHashCode();
            rt ^= I62.GetHashCode();
            rt ^= I63.GetHashCode();

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
        public static bool operator ==(FixedArray64<T> left, FixedArray64<T> right) {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public static bool operator !=(FixedArray64<T> left, FixedArray64<T> right) {
            return !(left == right);
        }

    } // End: struct FixedArray64

} // End: namespace
