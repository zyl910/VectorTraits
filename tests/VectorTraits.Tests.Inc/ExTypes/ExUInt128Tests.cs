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
using Zyl.VectorTraits;
using Zyl.VectorTraits.ExTypes;

namespace VectorTraits.Tests.ExTypes {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    [TestFixture()]
    internal class ExUInt128Tests {
        private static readonly ulong[] _samples = new ulong[] {
            0, 1, 2, 3,
            4, 5, 6, 7,
            0x10, 0x100, 0x1000, 0x10000,
            (ulong)(long.MaxValue-3), (ulong)(long.MaxValue-2), (ulong)(long.MaxValue-1), (ulong)(long.MaxValue),
            ulong.MaxValue-3, ulong.MaxValue-2, ulong.MaxValue-1, ulong.MaxValue
        };

        [Test()]
        public void AddTest() {
            // Narrow tests.
            for (int i = 0; i < _samples.Length; ++i) {
                ulong x = _samples[i];
                for (int j = 0; j < _samples.Length; ++j) {
                    ulong y = _samples[j];
                    ulong expected = x + y;
                    ExUInt128 dstWiden = (ExUInt128)x + (ExUInt128)y;
                    ulong dst = (ulong)dstWiden;
                    ClassicAssert.AreEqual(expected, dst, VectorTextUtil.Format("({0} + {1}) != {2}", x, y, expected));
                }
            }
            // Full tests.
#if BCL_TYPE_INT128
            for (int i = 0; i < _samples.Length; ++i) {
                ulong x = _samples[i];
                for (int j = 0; j < _samples.Length; ++j) {
                    ulong y = _samples[j];
                    UInt128 left0 = new UInt128(x, y);
                    ExUInt128 left = new ExUInt128(x, y);
                    for (int k = 0; k < _samples.Length; ++k) {
                        ulong z = _samples[k];
                        for (int l = 0; l < _samples.Length; ++l) {
                            ulong w = _samples[l];
                            UInt128 right0 = new UInt128(z, w);
                            ExUInt128 right = new ExUInt128(z, w);
                            UInt128 expected = left0 + right0;
                            ExUInt128 dst = left + right;
                            ClassicAssert.AreEqual((ExUInt128)expected, dst, VectorTextUtil.Format("({0} + {1}) != {2}", left, right, expected));
                        }
                    }
                }
            }
#endif
        }

        [Test()]
        public void DivTest() {
            // Narrow tests.
            for (int i = 0; i < _samples.Length; ++i) {
                ulong x = _samples[i];
                for (int j = 0; j < _samples.Length; ++j) {
                    ulong y = _samples[j];
                    if (0 == y) continue;
                    ulong expected = x / y;
                    ExUInt128 dstWiden = (ExUInt128)x / (ExUInt128)y;
                    ulong dst = (ulong)dstWiden;
                    ClassicAssert.AreEqual(expected, dst, VectorTextUtil.Format("({0} / {1}) != {2}", x, y, expected));
                }
            }
            // Full tests.
#if BCL_TYPE_INT128
            for (int i = 0; i < _samples.Length; ++i) {
                ulong x = _samples[i];
                for (int j = 0; j < _samples.Length; ++j) {
                    ulong y = _samples[j];
                    UInt128 left0 = new UInt128(x, y);
                    ExUInt128 left = new ExUInt128(x, y);
                    for (int k = 0; k < _samples.Length; ++k) {
                        ulong z = _samples[k];
                        for (int l = 0; l < _samples.Length; ++l) {
                            ulong w = _samples[l];
                            UInt128 right0 = new UInt128(z, w);
                            if (0 == right0) continue;
                            ExUInt128 right = new ExUInt128(z, w);
                            UInt128 expected = left0 / right0;
                            ExUInt128 dst = left / right;
                            ClassicAssert.AreEqual((ExUInt128)expected, dst, VectorTextUtil.Format("({0} / {1}) != {2}", left, right, expected));
                        }
                    }
                }
            }
#endif
        }

        [Test()]
        public void MultiplyTest() {
            // Narrow tests.
            for (int i = 0; i < _samples.Length; ++i) {
                ulong x = _samples[i];
                for (int j = 0; j < _samples.Length; ++j) {
                    ulong y = _samples[j];
                    ulong expected = x * y;
                    ExUInt128 dstWiden = (ExUInt128)x * (ExUInt128)y;
                    ulong dst = (ulong)dstWiden;
                    ClassicAssert.AreEqual(expected, dst, VectorTextUtil.Format("({0} * {1}) != {2}", x, y, expected));
                }
            }
            // Full tests.
#if BCL_TYPE_INT128
            for (int i = 0; i < _samples.Length; ++i) {
                ulong x = _samples[i];
                for (int j = 0; j < _samples.Length; ++j) {
                    ulong y = _samples[j];
                    UInt128 left0 = new UInt128(x, y);
                    ExUInt128 left = new ExUInt128(x, y);
                    for (int k = 0; k < _samples.Length; ++k) {
                        ulong z = _samples[k];
                        for (int l = 0; l < _samples.Length; ++l) {
                            ulong w = _samples[l];
                            UInt128 right0 = new UInt128(z, w);
                            ExUInt128 right = new ExUInt128(z, w);
                            UInt128 expected = left0 * right0;
                            ExUInt128 dst = left * right;
                            ClassicAssert.AreEqual((ExUInt128)expected, dst, VectorTextUtil.Format("({0} * {1}) != {2}", left, right, expected));
                        }
                    }
                }
            }
#endif
        }

        [Test()]
        public void SubtractTest() {
            // Narrow tests.
            for (int i = 0; i < _samples.Length; ++i) {
                ulong x = _samples[i];
                for (int j = 0; j < _samples.Length; ++j) {
                    ulong y = _samples[j];
                    ulong expected = x - y;
                    ExUInt128 dstWiden = (ExUInt128)x - (ExUInt128)y;
                    ulong dst = (ulong)dstWiden;
                    ClassicAssert.AreEqual(expected, dst, VectorTextUtil.Format("({0} - {1}) != {2}", x, y, expected));
                }
            }
            // Full tests.
#if BCL_TYPE_INT128
            for (int i = 0; i < _samples.Length; ++i) {
                ulong x = _samples[i];
                for (int j = 0; j < _samples.Length; ++j) {
                    ulong y = _samples[j];
                    UInt128 left0 = new UInt128(x, y);
                    ExUInt128 left = new ExUInt128(x, y);
                    for (int k = 0; k < _samples.Length; ++k) {
                        ulong z = _samples[k];
                        for (int l = 0; l < _samples.Length; ++l) {
                            ulong w = _samples[l];
                            UInt128 right0 = new UInt128(z, w);
                            ExUInt128 right = new ExUInt128(z, w);
                            UInt128 expected = left0 - right0;
                            ExUInt128 dst = left - right;
                            ClassicAssert.AreEqual((ExUInt128)expected, dst, VectorTextUtil.Format("({0} - {1}) != {2}", left, right, expected));
                        }
                    }
                }
            }
#endif
        }

    }
}
