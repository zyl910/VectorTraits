﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zyl.VectorTraits.Tests {
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
#if NET5_0_OR_GREATER
            yield return new TestCaseData((Half)11);
#else
            return _emptyList;
#endif // NET5_0_OR_GREATER
        }

    }
}
