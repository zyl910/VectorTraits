using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Xml.Linq;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IVectorTraitsTest {
    [TestFixture()]
    public class VectorTests_S {

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
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftLeft_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
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
                    // Static: Args and Core
                    Vector<T> args0, args1;
#pragma warning disable CS0618 // Type or member is obsolete
                    (args0, args1) = Vectors.ShiftLeft_Args<T>(vsrc, shiftAmount);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector<T> vdst = Vectors.ShiftLeft_Core((dynamic)vsrc, shiftAmount, (dynamic)args0, (dynamic)args1);
                    Assert.AreEqual(vexpected, vdst, $"_Core, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        vdst = instance.ShiftLeft((dynamic)vsrc, shiftAmount);
                        Assert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        (args0, args1) = instance.ShiftLeft_Args<T>(vsrc, shiftAmount);
#pragma warning restore CS0618 // Type or member is obsolete
                        vdst = instance.ShiftLeft_Core((dynamic)vsrc, shiftAmount, (dynamic)args0, (dynamic)args1);
                        Assert.AreEqual(vexpected, vdst, $"_Core of {instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
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
        public void ShiftLeft_ConstTest<T>(T src) where T : struct {
            //Vector<T> vzero = Vector<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize - 1;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftLeft_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector<T>[] samples = {
                Vectors.Create(src),
                Vectors<T>.Demo,
                Vectors<T>.Serial,
            };
            foreach (Vector<T> vsrc in samples) {
                for (int shiftAmount = 1; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector<T> vexpected = Vectors.ShiftLeft_Const((dynamic)vsrc, shiftAmount);
                    // Static: Args and Core
                    Vector<T> args0, args1;
#pragma warning disable CS0618 // Type or member is obsolete
                    (args0, args1) = Vectors.ShiftLeft_Args<T>(vsrc, shiftAmount);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector<T> vdst = Vectors.ShiftLeft_ConstCore((dynamic)vsrc, shiftAmount, (dynamic)args0, (dynamic)args1);
                    Assert.AreEqual(vexpected, vdst, $"_Core, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    // Instances
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        vdst = instance.ShiftLeft_Const((dynamic)vsrc, shiftAmount);
                        Assert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        (args0, args1) = instance.ShiftLeft_Args<T>(vsrc, shiftAmount);
#pragma warning restore CS0618 // Type or member is obsolete
                        vdst = instance.ShiftLeft_ConstCore((dynamic)vsrc, shiftAmount, (dynamic)args0, (dynamic)args1);
                        Assert.AreEqual(vexpected, vdst, $"_Core of {instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
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
        public void ShiftLeft_FastTest<T>(T src) where T : struct {
            //Vector<T> vzero = Vector<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize - 1;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftLeft_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, int, Vector<T>>>("ShiftLeft_Fast_Base", "ShiftLeft_Fast_Multiply");
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
                    Vector<T> vexpected = Vectors.ShiftLeft_Fast((dynamic)vsrc, shiftAmount);
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector<T> vdst = instance.ShiftLeft_Fast((dynamic)vsrc, shiftAmount);
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
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftRightArithmetic_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
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
                    // Static: Args and Core
                    Vector<T> args0, args1;
#pragma warning disable CS0618 // Type or member is obsolete
                    (args0, args1) = Vectors.ShiftRightArithmetic_Args<T>(vsrc, shiftAmount);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector<T> vdst = Vectors.ShiftRightArithmetic_Core((dynamic)vsrc, shiftAmount, (dynamic)args0, (dynamic)args1);
                    Assert.AreEqual(vexpected, vdst, $"_Core, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        vdst = instance.ShiftRightArithmetic((dynamic)vsrc, shiftAmount);
                        Assert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                        // Instances: Args and Core
                        try {
#pragma warning disable CS0618 // Type or member is obsolete
                            (args0, args1) = instance.ShiftRightArithmetic_Args<T>(vsrc, shiftAmount);
#pragma warning restore CS0618 // Type or member is obsolete
                            vdst = instance.ShiftRightArithmetic_Core((dynamic)vsrc, shiftAmount, (dynamic)args0, (dynamic)args1);
                            Assert.AreEqual(vexpected, vdst, $"_Core of {instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                        } catch (Exception ex) {
                            Console.WriteLine("Exception at:" + $"_Core of {instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                            throw;
                        }
                    }
                }
            }
        }

        [TestCase((sbyte)3)]
        [TestCase((short)5)]
        [TestCase((int)7)]
        [TestCase((long)9)]
        public void ShiftRightArithmetic_ConstTest<T>(T src) where T : struct {
            //Vector<T> vzero = Vector<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize - 1;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftRightArithmetic_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector<T>[] samples = {
                Vectors.Create(src),
                Vectors<T>.Demo,
                Vectors<T>.Serial,
            };
            foreach (Vector<T> vsrc in samples) {
                for (int shiftAmount = 1; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector<T> vexpected = Vectors.ShiftRightArithmetic_Const((dynamic)vsrc, shiftAmount);
                    // Static: Args and Core
                    Vector<T> args0, args1;
#pragma warning disable CS0618 // Type or member is obsolete
                    (args0, args1) = Vectors.ShiftRightArithmetic_Args<T>(vsrc, shiftAmount);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector<T> vdst = Vectors.ShiftRightArithmetic_ConstCore((dynamic)vsrc, shiftAmount, (dynamic)args0, (dynamic)args1);
                    Assert.AreEqual(vexpected, vdst, $"_Core, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    // Instances
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        vdst = instance.ShiftRightArithmetic_Const((dynamic)vsrc, shiftAmount);
                        Assert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        (args0, args1) = instance.ShiftRightArithmetic_Args<T>(vsrc, shiftAmount);
#pragma warning restore CS0618 // Type or member is obsolete
                        vdst = instance.ShiftRightArithmetic_ConstCore((dynamic)vsrc, shiftAmount, (dynamic)args0, (dynamic)args1);
                        Assert.AreEqual(vexpected, vdst, $"_Core of {instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    }
                }
            }
        }

        [TestCase((sbyte)3)]
        [TestCase((short)5)]
        [TestCase((int)7)]
        [TestCase((long)9)]
        public void ShiftRightArithmetic_FastTest<T>(T src) where T : struct {
            //Vector<T> vzero = Vector<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize - 1;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftRightArithmetic_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, int, Vector<T>>>("ShiftRightArithmetic_Base", "ShiftRightArithmetic_Negative", "ShiftRightArithmetic_Fast_Negative", "ShiftRightArithmetic_Fast_Widen", "ShiftRightArithmetic_Fast_Narrow", "ShiftRightArithmetic_Fast_NarrowIfLess");
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
                    Vector<T> vexpected = Vectors.ShiftRightArithmetic_Fast((dynamic)vsrc, shiftAmount);
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector<T> vdst = instance.ShiftRightArithmetic_Fast((dynamic)vsrc, shiftAmount);
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
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftRightLogical_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
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
                    // Static: Args and Core
                    Vector<T> args0, args1;
#pragma warning disable CS0618 // Type or member is obsolete
                    (args0, args1) = Vectors.ShiftRightLogical_Args<T>(vsrc, shiftAmount);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector<T> vdst = Vectors.ShiftRightLogical_Core((dynamic)vsrc, shiftAmount, (dynamic)args0, (dynamic)args1);
                    Assert.AreEqual(vexpected, vdst, $"_Core, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        vdst = instance.ShiftRightLogical((dynamic)vsrc, shiftAmount);
                        Assert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        (args0, args1) = instance.ShiftRightLogical_Args<T>(vsrc, shiftAmount);
#pragma warning restore CS0618 // Type or member is obsolete
                        vdst = instance.ShiftRightLogical_Core((dynamic)vsrc, shiftAmount, (dynamic)args0, (dynamic)args1);
                        Assert.AreEqual(vexpected, vdst, $"_Core of {instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
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
        public void ShiftRightLogical_ConstTest<T>(T src) where T : struct {
            //Vector<T> vzero = Vector<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize - 1;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftRightLogical_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector<T>[] samples = {
                Vectors.Create(src),
                Vectors<T>.Demo,
                Vectors<T>.Serial,
            };
            foreach (Vector<T> vsrc in samples) {
                for (int shiftAmount = 1; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector<T> vexpected = Vectors.ShiftRightLogical_Const((dynamic)vsrc, shiftAmount);
                    // Static: Args and Core
                    Vector<T> args0, args1;
#pragma warning disable CS0618 // Type or member is obsolete
                    (args0, args1) = Vectors.ShiftRightLogical_Args<T>(vsrc, shiftAmount);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector<T> vdst = Vectors.ShiftRightLogical_ConstCore((dynamic)vsrc, shiftAmount, (dynamic)args0, (dynamic)args1);
                    Assert.AreEqual(vexpected, vdst, $"_Core, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    // Instances
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        vdst = instance.ShiftRightLogical_Const((dynamic)vsrc, shiftAmount);
                        Assert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        (args0, args1) = instance.ShiftRightLogical_Args<T>(vsrc, shiftAmount);
#pragma warning restore CS0618 // Type or member is obsolete
                        vdst = instance.ShiftRightLogical_ConstCore((dynamic)vsrc, shiftAmount, (dynamic)args0, (dynamic)args1);
                        Assert.AreEqual(vexpected, vdst, $"_Core of {instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
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
        public void ShiftRightLogical_FastTest<T>(T src) where T : struct {
            //Vector<T> vzero = Vector<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize - 1;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftRightLogical_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, int, Vector<T>>>("ShiftRightLogical_Fast_Base", "ShiftRightLogical_Fast_Widen");
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
                    Vector<T> vexpected = Vectors.ShiftRightLogical_Fast((dynamic)vsrc, shiftAmount);
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector<T> vdst = instance.ShiftRightLogical_Fast((dynamic)vsrc, shiftAmount);
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

        [TestCase((float)1, (int)7)]
        [TestCase((double)2, (long)9)]
        [TestCase((sbyte)3, (sbyte)3)]
        [TestCase((byte)4, (byte)4)]
        [TestCase((short)5, (short)5)]
        [TestCase((ushort)6, (ushort)6)]
        [TestCase((int)7, (int)7)]
        [TestCase((uint)8, (uint)8)]
        [TestCase((long)9, (long)9)]
        [TestCase((ulong)10, (ulong)10)]
        public void ShuffleTest<T, TIdx>(T src, TIdx srcIndex) where T : struct where TIdx : struct {
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.Shuffle_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            bool allowLog = true;
            //bool allowLogItem = Scalars<T>.ExponentBits > 0;
            bool allowLogItem = false;
            Vector<T>[] samples = {
                //Vectors.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vectors<T>.Demo,
                Vectors<T>.Serial,
                //Vectors<T>.SerialNegative
            };
            Vector<TIdx>[] indicesList = {
                Vectors<TIdx>.Serial,
                Vectors<TIdx>.SerialDesc,
                Vectors.CreateByDoubleLoop<TIdx>(0, 2),
                Vectors.CreateByDoubleLoop<TIdx>(1, 2),
                Vectors.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src), 1),
            };
            foreach (Vector<T> vector in samples) {
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}", vector));
                }
                foreach (Vector<TIdx> indices in indicesList) {
#if NETX_0_OR_GREATER
                    Vector<T> expected = Vector.Shuffle((dynamic)vector, (dynamic)indices);
#else
                    Vector<T> expected = Vectors.Shuffle((dynamic)vector, (dynamic)indices);
#endif // NETX_0_OR_GREATER
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Indices:\t{0}", indices));
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    // Static: Args and Core
                    Vector<TIdx> args0, args1;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vectors.Shuffle_Args<TIdx>(indices, out args0, out args1);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector<T> dst = Vectors.Shuffle_Core((dynamic)vector, (dynamic)args0, (dynamic)args1);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0", dst, vector, indices));
                    } else {
                        Assert.AreEqual(expected, dst, "_Core0, vector={vector}, indices={indices}");
                    }
                    // Static: Args and Core with ValueTuple
                    var args = Vectors.Shuffle_Args((dynamic)indices);
                    dst = Vectors.Shuffle_Core((dynamic)vector, (dynamic)args);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core", dst, vector, indices));
                    } else {
                        Assert.AreEqual(expected, dst, "_Core, vector={vector}, indices={indices}");
                    }
                    // Instances
                    foreach (IVectorTraits instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        dst = instance.Shuffle((dynamic)vector, (dynamic)indices);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", instance.GetType().Name, dst, vector, indices));
                        } else {
                            Assert.AreEqual(expected, dst, $"{instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        instance.Shuffle_Args<TIdx>(indices, out args0, out args1);
#pragma warning restore CS0618 // Type or member is obsolete
                        dst = instance.Shuffle_Core((dynamic)vector, (dynamic)args0, (dynamic)args1);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0 of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            Assert.AreEqual(expected, dst, "_Core0 of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core with ValueTuple
#pragma warning disable CS0618 // Type or member is obsolete
                        var argsI = instance.Shuffle_Args<TIdx>(indices);
                        // dst = instance.Shuffle_Core((dynamic)vector, (dynamic)argsI); // CS1973	'IVectorTraits' has no applicable method named 'Shuffle_Core' but appears to have an extension method by that name. Extension methods cannot be dynamically dispatched. Consider casting the dynamic arguments or calling the extension method without the extension method syntax.
                        dst = instance.Shuffle_Core<T, TIdx>(vector, argsI);
#pragma warning restore CS0618 // Type or member is obsolete
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            Assert.AreEqual(expected, dst, "_Core of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                    }
                    if (allowLog) {
                        Console.WriteLine();
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
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.Sum_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            bool allowLog = Scalars<T>.ExponentBits > 0;
            //bool allowLog = true;
            Vector<T>[] samples = {
                Vectors.Create(src),
                Vectors<T>.Demo,
                Vectors<T>.Serial,
                Vectors<T>.SerialNegative,
                Vectors<T>.InterlacedSign,
            };
            foreach (Vector<T> vector in samples) {
#if NET6_0_OR_GREATER
                T expected = Vector.Sum((dynamic)vector);
#else
                T expected = Vectors.Sum((dynamic)vector);
#endif // NET6_0_OR_GREATER
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", vector));
                    Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                }
                foreach (IVectorTraits instance in instances) {
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


    }
}
