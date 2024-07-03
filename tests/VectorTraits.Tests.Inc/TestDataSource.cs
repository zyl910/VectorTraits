#if NET5_0_OR_GREATER
#define BCL_TYPE_HALF
#endif // NET5_0_OR_GREATER
#if NET7_0_OR_GREATER
#define BCL_TYPE_INT128
#endif // NET7_0_OR_GREATER

using NUnit.Framework;
#if !USED_NUNIT3
using NUnit.Framework.Legacy;
#endif
using System;
using System.Collections.Generic;
using System.Text;
using Zyl.VectorTraits.ExTypes;

namespace Zyl.VectorTraits.Tests {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    /// <summary>
    /// Test data source.
    /// </summary>
    public static class TestDataSource {
        public static readonly IEnumerable<TestCaseData> _emptyList = new TestCaseData[0];

        /// <summary>
        /// Use <see cref="Half"/> type.
        /// </summary>
        /// <returns>Returns <see cref="TestCaseData"/> of <see cref="Half"/> type.</returns>
        public static IEnumerable<TestCaseData> UseHalf() {
#if BCL_TYPE_HALF
            yield return new TestCaseData((Half)11);
#else
            return _emptyList;
#endif // BCL_TYPE_HALF
        }

        /// <summary>
        /// Use <see cref="ExInt128"/> type.
        /// </summary>
        /// <returns>Returns <see cref="TestCaseData"/> of <see cref="ExInt128"/> type.</returns>
        public static IEnumerable<TestCaseData> UseExInt128() {
            yield return new TestCaseData((ExInt128)13);
        }

        /// <summary>
        /// Use <see cref="ExUInt128"/> type.
        /// </summary>
        /// <returns>Returns <see cref="TestCaseData"/> of <see cref="ExUInt128"/> type.</returns>
        public static IEnumerable<TestCaseData> UseExUInt128() {
            yield return new TestCaseData((ExUInt128)14);
        }

        /// <summary>
        /// Use <see cref="Int128"/> type.
        /// </summary>
        /// <returns>Returns <see cref="TestCaseData"/> of <see cref="Int128"/> type.</returns>
        public static IEnumerable<TestCaseData> UseInt128() {
#if BCL_TYPE_INT128
            yield return new TestCaseData((Int128)13);
#else
            return _emptyList;
#endif // BCL_TYPE_INT128
        }

        /// <summary>
        /// Use <see cref="UInt128"/> type.
        /// </summary>
        /// <returns>Returns <see cref="TestCaseData"/> of <see cref="UInt128"/> type.</returns>
        public static IEnumerable<TestCaseData> UseUInt128() {
#if BCL_TYPE_INT128
            yield return new TestCaseData((UInt128)14);
#else
            return _emptyList;
#endif // BCL_TYPE_INT128
        }

    }
}
