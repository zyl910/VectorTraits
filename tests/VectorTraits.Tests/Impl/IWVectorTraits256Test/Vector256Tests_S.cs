﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits256Test {
    [TestFixture()]
    public class Vector256Tests_S {
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
            //Vector256<T> vzero = Vector256<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize + 1;
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.IsSupported) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftLeft_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector256<T>[] samples = {
                Vector256s.Create(src),
                Vector256s<T>.Demo,
                Vector256s<T>.Serial,
            };
            foreach (Vector256<T> vsrc in samples) {
                for (int shiftAmount = -1; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector256<T> vexpected = Vector256s.ShiftLeft((dynamic)vsrc, shiftAmount);
                    foreach (IWVectorTraits256 instance in instances) {
                        if (!instance.IsSupported) continue;
                        Vector256<T> vdst = instance.ShiftLeft((dynamic)vsrc, shiftAmount);
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
            //Vector256<T> vzero = Vector256<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize - 1;
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.IsSupported) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftLeft_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector256<T>[] samples = {
                Vector256s.Create(src),
                Vector256s<T>.Demo,
                Vector256s<T>.Serial,
            };
            foreach (Vector256<T> vsrc in samples) {
                for (int shiftAmount = 0; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector256<T> vexpected = Vector256s.ShiftLeftFast((dynamic)vsrc, shiftAmount);
                    foreach (IWVectorTraits256 instance in instances) {
                        if (!instance.IsSupported) continue;
                        Vector256<T> vdst = instance.ShiftLeftFast((dynamic)vsrc, shiftAmount);
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
            //Vector256<T> vzero = Vector256<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize + 1;
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.IsSupported) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftRightArithmetic_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector256<T>[] samples = {
                Vector256s.Create(src),
                Vector256s<T>.Demo,
                Vector256s<T>.Serial,
            };
            foreach (Vector256<T> vsrc in samples) {
                for (int shiftAmount = -1; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector256<T> vexpected = Vector256s.ShiftRightArithmetic((dynamic)vsrc, shiftAmount);
                    foreach (IWVectorTraits256 instance in instances) {
                        if (!instance.IsSupported) continue;
                        Vector256<T> vdst = instance.ShiftRightArithmetic((dynamic)vsrc, shiftAmount);
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
            //Vector256<T> vzero = Vector256<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize - 1;
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.IsSupported) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftRightArithmetic_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector256s.GetSupportedMethodList<Func<Vector256<T>, int, Vector256<T>>>("ShiftRightArithmeticFast_Base", "ShiftRightArithmeticFast_Negative", "ShiftRightArithmeticFast_Widen", "ShiftRightArithmeticFast_Narrow", "ShiftRightArithmeticFast_NarrowIfLess");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            // run.
            Vector256<T>[] samples = {
                Vector256s.Create(src),
                Vector256s<T>.Demo,
                Vector256s<T>.Serial,
            };
            foreach (Vector256<T> vsrc in samples) {
                for (int shiftAmount = 0; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector256<T> vexpected = Vector256s.ShiftRightArithmeticFast((dynamic)vsrc, shiftAmount);
                    foreach (IWVectorTraits256 instance in instances) {
                        if (!instance.IsSupported) continue;
                        Vector256<T> vdst = instance.ShiftRightArithmeticFast((dynamic)vsrc, shiftAmount);
                        Assert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    }
                    foreach (var func in funcList) {
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        Vector256<T> vdst = func(vsrc, shiftAmount);
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
            //Vector256<T> vzero = Vector256<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize + 1;
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.IsSupported) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftRightLogical_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector256<T>[] samples = {
                Vector256s.Create(src),
                Vector256s<T>.Demo,
                Vector256s<T>.Serial,
            };
            foreach (Vector256<T> vsrc in samples) {
                for (int shiftAmount = -1; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector256<T> vexpected = Vector256s.ShiftRightLogical((dynamic)vsrc, shiftAmount);
                    foreach (IWVectorTraits256 instance in instances) {
                        if (!instance.IsSupported) continue;
                        Vector256<T> vdst = instance.ShiftRightLogical((dynamic)vsrc, shiftAmount);
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
            //Vector256<T> vzero = Vector256<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize - 1;
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                if (instance.IsSupported) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftRightLogical_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector256<T>[] samples = {
                Vector256s.Create(src),
                Vector256s<T>.Demo,
                Vector256s<T>.Serial,
            };
            foreach (Vector256<T> vsrc in samples) {
                for (int shiftAmount = 1; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector256<T> vexpected = Vector256s.ShiftRightLogicalFast((dynamic)vsrc, shiftAmount);
                    foreach (IWVectorTraits256 instance in instances) {
                        if (!instance.IsSupported) continue;
                        Vector256<T> vdst = instance.ShiftRightLogicalFast((dynamic)vsrc, shiftAmount);
                        Assert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    }
                }
            }
        }


#endif
    }
}