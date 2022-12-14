﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Xml.Linq;
using Zyl.VectorTraits.Impl;


namespace Zyl.VectorTraits.Tests.Impl {
    [TestFixture()]
    public class IVectorTraitsTests {

        [TestCase((sbyte)3)]
        [TestCase((byte)4)]
        [TestCase((short)5)]
        [TestCase((ushort)6)]
        [TestCase((int)7)]
        [TestCase((uint)8)]
        [TestCase((long)9)]
        [TestCase((ulong)10)]
        public void ShiftLeftTest<T>(T src) where T : struct {
            //Vector<T> vzero = Vector<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize + 1;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.IsSupported) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftLeft_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, int, Vector<T>>>("ShiftLeft_Base", "ShiftLeft_Multiply");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            // run.
            Vector<T>[] samples = {
                Vectors.Create(src),
                Vectors<T>.Demo,
                Vectors<T>.Serial,
            };
            foreach (Vector<T> vsrc in samples) {
                for (int shiftAmount = -1; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector<T> vexpected = Vectors.ShiftLeft((dynamic)vsrc, shiftAmount);
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.IsSupported) continue;
                        Vector<T> vdst = instance.ShiftLeft((dynamic)vsrc, shiftAmount);
                        Assert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    }
                    foreach (var func in funcList) {
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        Vector<T> vdst = func(vsrc, shiftAmount);
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
        public void ShiftLeftFastTest<T>(T src) where T : struct {
            //Vector<T> vzero = Vector<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize - 1;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.IsSupported) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftLeft_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, int, Vector<T>>>("ShiftLeftFast_Base", "ShiftLeftFast_Multiply");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            // run.
            Vector<T>[] samples = {
                Vectors.Create(src),
                Vectors<T>.Demo,
                Vectors<T>.Serial,
            };
            foreach (Vector<T> vsrc in samples) {
                for (int shiftAmount = 0; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector<T> vexpected = Vectors.ShiftLeftFast((dynamic)vsrc, shiftAmount);
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.IsSupported) continue;
                        Vector<T> vdst = instance.ShiftLeftFast((dynamic)vsrc, shiftAmount);
                        Assert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    }
                    foreach (var func in funcList) {
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        Vector<T> vdst = func(vsrc, shiftAmount);
                        Assert.AreEqual(vexpected, vdst, $"{funcName}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    }
                }
            }
        }


        [TestCase((sbyte)3)]
        [TestCase((short)5)]
        [TestCase((int)7)]
        [TestCase((long)9)]
        public void ShiftRightArithmeticTest<T>(T src) where T : struct {
            //Vector<T> vzero = Vector<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize + 1;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.IsSupported) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftRightArithmetic_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, int, Vector<T>>>("ShiftRightArithmetic_Base", "ShiftRightArithmetic_Negative");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            // run.
            Vector<T>[] samples = {
                Vectors.Create(src),
                Vectors<T>.Demo,
                Vectors<T>.Serial,
            };
            foreach (Vector<T> vsrc in samples) {
                for (int shiftAmount = -1; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector<T> vexpected = Vectors.ShiftRightArithmetic((dynamic)vsrc, shiftAmount);
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.IsSupported) continue;
                        Vector<T> vdst = instance.ShiftRightArithmetic((dynamic)vsrc, shiftAmount);
                        Assert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    }
                    foreach (var func in funcList) {
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        Vector<T> vdst = func(vsrc, shiftAmount);
                        Assert.AreEqual(vexpected, vdst, $"{funcName}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    }
                }
            }
        }

        [TestCase((sbyte)3)]
        [TestCase((short)5)]
        [TestCase((int)7)]
        [TestCase((long)9)]
        public void ShiftRightArithmeticFastTest<T>(T src) where T : struct {
            //Vector<T> vzero = Vector<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize - 1;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.IsSupported) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftRightArithmetic_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, int, Vector<T>>>("ShiftRightArithmetic_Base", "ShiftRightArithmetic_Negative", "ShiftRightArithmeticFast_Negative", "ShiftRightArithmeticFast_Widen", "ShiftRightArithmeticFast_Narrow", "ShiftRightArithmeticFast_NarrowIfLess");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            // run.
            Vector<T>[] samples = {
                Vectors.Create(src),
                Vectors<T>.Demo,
                Vectors<T>.Serial,
            };
            foreach (Vector<T> vsrc in samples) {
                for (int shiftAmount = 0; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector<T> vexpected = Vectors.ShiftRightArithmeticFast((dynamic)vsrc, shiftAmount);
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.IsSupported) continue;
                        Vector<T> vdst = instance.ShiftRightArithmeticFast((dynamic)vsrc, shiftAmount);
                        Assert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    }
                    foreach (var func in funcList) {
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        Vector<T> vdst = func(vsrc, shiftAmount);
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
            //Vector<T> vzero = Vector<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize + 1;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.IsSupported) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftRightLogical_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, int, Vector<T>>>("ShiftRightLogical_Base", "ShiftRightLogical_Widen");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            // run.
            Vector<T>[] samples = {
                Vectors.Create(src),
                Vectors<T>.Demo,
                Vectors<T>.Serial,
            };
            foreach (Vector<T> vsrc in samples) {
                for (int shiftAmount = -1; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector<T> vexpected = Vectors.ShiftRightLogical((dynamic)vsrc, shiftAmount);
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.IsSupported) continue;
                        Vector<T> vdst = instance.ShiftRightLogical((dynamic)vsrc, shiftAmount);
                        Assert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    }
                    foreach (var func in funcList) {
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        Vector<T> vdst = func(vsrc, shiftAmount);
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
        public void ShiftRightLogicalFastTest<T>(T src) where T : struct {
            //Vector<T> vzero = Vector<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize - 1;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.IsSupported) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftRightLogical_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, int, Vector<T>>>("ShiftRightLogicalFast_Base", "ShiftRightLogicalFast_Widen");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            // run.
            Vector<T>[] samples = {
                Vectors.Create(src),
                Vectors<T>.Demo,
                Vectors<T>.Serial,
            };
            foreach (Vector<T> vsrc in samples) {
                for (int shiftAmount = 1; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector<T> vexpected = Vectors.ShiftRightLogicalFast((dynamic)vsrc, shiftAmount);
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.IsSupported) continue;
                        Vector<T> vdst = instance.ShiftRightLogicalFast((dynamic)vsrc, shiftAmount);
                        Assert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    }
                    foreach (var func in funcList) {
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        Vector<T> vdst = func(vsrc, shiftAmount);
                        Assert.AreEqual(vexpected, vdst, $"{funcName}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    }
                }
            }
        }


    }
}
