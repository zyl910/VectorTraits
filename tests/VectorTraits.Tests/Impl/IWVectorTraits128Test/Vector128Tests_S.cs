using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits128Test {
    [TestFixture()]
    public class Vector128Tests_S {
#if NETCOREAPP3_0_OR_GREATER

        [TestCase((sbyte)3)]
        [TestCase((byte)4)]
        [TestCase((short)5)]
        [TestCase((ushort)6)]
        [TestCase((int)7)]
        [TestCase((uint)8)]
        [TestCase((long)9)]
        [TestCase((ulong)10)]
        public void ShiftLeftTest<T>(T src) where T : struct {
            //Vector128<T> vzero = Vector128<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize + 1;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftLeft_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector128<T>[] samples = {
                Vector128s.Create(src),
                Vector128s<T>.Demo,
                Vector128s<T>.Serial,
            };
            foreach (Vector128<T> vsrc in samples) {
                for (int shiftAmount = -1; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector128<T> vexpected = Vector128s.ShiftLeft((dynamic)vsrc, shiftAmount);
                    foreach (IWVectorTraits128 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector128<T> vdst = instance.ShiftLeft((dynamic)vsrc, shiftAmount);
                        Assert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    }
                }
            }
        }

        [TestCase((sbyte)3)]
        [TestCase((byte)4)]
        [TestCase((short)5)]
        [TestCase((ushort)6)]
        [TestCase((int)7)]
        [TestCase((uint)8)]
        [TestCase((long)9)]
        [TestCase((ulong)10)]
        public void ShiftLeftFastTest<T>(T src) where T : struct {
            //Vector128<T> vzero = Vector128<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize - 1;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftLeft_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector128<T>[] samples = {
                Vector128s.Create(src),
                Vector128s<T>.Demo,
                Vector128s<T>.Serial,
            };
            foreach (Vector128<T> vsrc in samples) {
                for (int shiftAmount = 0; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector128<T> vexpected = Vector128s.ShiftLeftFast((dynamic)vsrc, shiftAmount);
                    foreach (IWVectorTraits128 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector128<T> vdst = instance.ShiftLeftFast((dynamic)vsrc, shiftAmount);
                        Assert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    }
                }
            }
        }


        [TestCase((sbyte)3)]
        [TestCase((short)5)]
        [TestCase((int)7)]
        [TestCase((long)9)]
        public void ShiftRightArithmeticTest<T>(T src) where T : struct {
            //Vector128<T> vzero = Vector128<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize + 1;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftRightArithmetic_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector128<T>[] samples = {
                Vector128s.Create(src),
                Vector128s<T>.Demo,
                Vector128s<T>.Serial,
            };
            foreach (Vector128<T> vsrc in samples) {
                for (int shiftAmount = -1; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector128<T> vexpected = Vector128s.ShiftRightArithmetic((dynamic)vsrc, shiftAmount);
                    foreach (IWVectorTraits128 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector128<T> vdst = instance.ShiftRightArithmetic((dynamic)vsrc, shiftAmount);
                        Assert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    }
                }
            }
        }

        [TestCase((sbyte)3)]
        [TestCase((short)5)]
        [TestCase((int)7)]
        [TestCase((long)9)]
        public void ShiftRightArithmeticFastTest<T>(T src) where T : struct {
            //Vector128<T> vzero = Vector128<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize - 1;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftRightArithmetic_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector128s.GetSupportedMethodList<Func<Vector128<T>, int, Vector128<T>>>("ShiftRightArithmeticFast_Base");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            // run.
            Vector128<T>[] samples = {
                Vector128s.Create(src),
                Vector128s<T>.Demo,
                Vector128s<T>.Serial,
            };
            foreach (Vector128<T> vsrc in samples) {
                for (int shiftAmount = 0; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector128<T> vexpected = Vector128s.ShiftRightArithmeticFast((dynamic)vsrc, shiftAmount);
                    foreach (IWVectorTraits128 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector128<T> vdst = instance.ShiftRightArithmeticFast((dynamic)vsrc, shiftAmount);
                        Assert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    }
                    foreach (var func in funcList) {
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        Vector128<T> vdst = func(vsrc, shiftAmount);
                        Assert.AreEqual(vexpected, vdst, $"{funcName}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    }
                }
            }
        }

        [TestCase((sbyte)3)]
        [TestCase((byte)4)]
        [TestCase((short)5)]
        [TestCase((ushort)6)]
        [TestCase((int)7)]
        [TestCase((uint)8)]
        [TestCase((long)9)]
        [TestCase((ulong)10)]
        public void ShiftRightLogicalTest<T>(T src) where T : struct {
            //Vector128<T> vzero = Vector128<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize + 1;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftRightLogical_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector128<T>[] samples = {
                Vector128s.Create(src),
                Vector128s<T>.Demo,
                Vector128s<T>.Serial,
            };
            foreach (Vector128<T> vsrc in samples) {
                for (int shiftAmount = -1; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector128<T> vexpected = Vector128s.ShiftRightLogical((dynamic)vsrc, shiftAmount);
                    foreach (IWVectorTraits128 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector128<T> vdst = instance.ShiftRightLogical((dynamic)vsrc, shiftAmount);
                        Assert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    }
                }
            }
        }

        [TestCase((sbyte)3)]
        [TestCase((byte)4)]
        [TestCase((short)5)]
        [TestCase((ushort)6)]
        [TestCase((int)7)]
        [TestCase((uint)8)]
        [TestCase((long)9)]
        [TestCase((ulong)10)]
        public void ShiftRightLogicalFastTest<T>(T src) where T : struct {
            //Vector128<T> vzero = Vector128<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize - 1;
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftRightLogical_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector128<T>[] samples = {
                Vector128s.Create(src),
                Vector128s<T>.Demo,
                Vector128s<T>.Serial,
            };
            foreach (Vector128<T> vsrc in samples) {
                for (int shiftAmount = 1; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector128<T> vexpected = Vector128s.ShiftRightLogicalFast((dynamic)vsrc, shiftAmount);
                    foreach (IWVectorTraits128 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector128<T> vdst = instance.ShiftRightLogicalFast((dynamic)vsrc, shiftAmount);
                        Assert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    }
                }
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCase((sbyte)3)]
        [TestCase((byte)4)]
        [TestCase((short)5)]
        [TestCase((ushort)6)]
        [TestCase((int)7)]
        [TestCase((uint)8)]
        [TestCase((long)9)]
        [TestCase((ulong)10)]
        public void SubtractTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.Subtract_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector128<T>[] samples = {
                Vector128s.Create(src),
                Vector128s<T>.Demo,
                Vector128s<T>.Serial,
                Vector128s<T>.SerialNegative
            };
            foreach (Vector128<T> left in samples) {
                foreach (Vector128<T> right in samples) {
#if NET7_0_OR_GREATER
                    Vector128<T> expected = Vector128.Subtract(left, right);
#else
                    Vector128<T> expected = Vector128s.Subtract((dynamic)left, (dynamic)right);
#endif // NET7_0_OR_GREATER
                    foreach (IWVectorTraits128 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector128<T> dst = instance.Subtract((dynamic)left, (dynamic)right);
                        if (Scalars<T>.ExponentBits > 0) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, left={2}, right={3}", instance.GetType().Name, dst, left, right));
                        } else {
                            Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, left={left}, right={right}");
                        }
                    }
                }
            }
        }

        [TestCase((float)1)]
        [TestCase((double)2)]
        [TestCase((sbyte)3)]
        [TestCase((byte)4)]
        [TestCase((short)5)]
        [TestCase((ushort)6)]
        [TestCase((int)7)]
        [TestCase((uint)8)]
        [TestCase((long)9)]
        [TestCase((ulong)10)]
        public void SumTest<T>(T src) where T : struct {
            IReadOnlyList<IWVectorTraits128> instances = Vector128s.TraitsInstances;
            foreach (IWVectorTraits128 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.Sum_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            bool allowLog = Scalars<T>.ExponentBits > 0;
            //bool allowLog = true;
            Vector128<T>[] samples = {
                Vector128s.Create(src),
                Vector128s<T>.Demo,
                Vector128s<T>.Serial,
                Vector128s<T>.SerialNegative,
                Vector128s<T>.InterlacedSign,
            };
            foreach (Vector128<T> vector in samples) {
#if NET7_0_OR_GREATER
                T expected = Vector128.Sum((dynamic)vector);
#else
                T expected = Vector128s.Sum((dynamic)vector);
#endif // NET7_0_OR_GREATER
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", vector));
                    Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                }
                foreach (IWVectorTraits128 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    T dst = instance.Sum((dynamic)vector);
                    if (Scalars<T>.ExponentBits > 0) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, vector={vector}");
                    }
                }
            }
        }


#endif
    }
}
