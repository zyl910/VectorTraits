using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public struct FixedArray16<T>
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

    }
}
