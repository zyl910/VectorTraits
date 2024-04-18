using NUnit.Framework;
#if !USED_NUNIT3
using NUnit.Framework.Legacy;
#endif
using System;
using System.Collections.Generic;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.IO;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits512Test {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    [TestFixture()]
    public class Vector512Tests_S {
#if NET8_0_OR_GREATER

        [TestCase((sbyte)3)]
        [TestCase((byte)4)]
        [TestCase((short)5)]
        [TestCase((ushort)6)]
        [TestCase((int)7)]
        [TestCase((uint)8)]
        [TestCase((long)9)]
        [TestCase((ulong)10)]
        public void ShiftLeftTest<T>(T src) where T : struct {
            //Vector512<T> vzero = Vector512<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize + 1;
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftLeft_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector512<T>[] samples = {
                Vector512s.Create(src),
                Vector512s<T>.Demo,
                Vector512s<T>.Serial,
            };
            foreach (Vector512<T> vsrc in samples) {
                for (int shiftAmount = -1; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector512<T> vexpected = Vector512s.ShiftLeft((dynamic)vsrc, shiftAmount);
                    // Static: Args and Core
                    Vector512<T> args0, args1;
#pragma warning disable CS0618 // Type or member is obsolete
                    (args0, args1) = Vector512s.ShiftLeft_Args<T>(vsrc, shiftAmount);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector512<T> vdst = Vector512s.ShiftLeft_Core((dynamic)vsrc, shiftAmount, (dynamic)args0, (dynamic)args1);
                    ClassicAssert.AreEqual(vexpected, vdst, $"_Core, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        vdst = instance.ShiftLeft((dynamic)vsrc, shiftAmount);
                        ClassicAssert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        (args0, args1) = instance.ShiftLeft_Args<T>(vsrc, shiftAmount);
#pragma warning restore CS0618 // Type or member is obsolete
                        vdst = instance.ShiftLeft_Core((dynamic)vsrc, shiftAmount, (dynamic)args0, (dynamic)args1);
                        ClassicAssert.AreEqual(vexpected, vdst, $"_Core of {instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
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
            //Vector512<T> vzero = Vector512<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize - 1;
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftLeft_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector512<T>[] samples = {
                Vector512s.Create(src),
                Vector512s<T>.Demo,
                Vector512s<T>.Serial,
            };
            foreach (Vector512<T> vsrc in samples) {
                for (int shiftAmount = 1; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector512<T> vexpected = Vector512s.ShiftLeft_Const((dynamic)vsrc, shiftAmount);
                    // Static: Args and Core
                    Vector512<T> args0, args1;
#pragma warning disable CS0618 // Type or member is obsolete
                    (args0, args1) = Vector512s.ShiftLeft_Args<T>(vsrc, shiftAmount);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector512<T> vdst = Vector512s.ShiftLeft_ConstCore((dynamic)vsrc, shiftAmount, (dynamic)args0, (dynamic)args1);
                    ClassicAssert.AreEqual(vexpected, vdst, $"_Core, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    // Instances
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        vdst = instance.ShiftLeft_Const((dynamic)vsrc, shiftAmount);
                        ClassicAssert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        (args0, args1) = instance.ShiftLeft_Args<T>(vsrc, shiftAmount);
#pragma warning restore CS0618 // Type or member is obsolete
                        vdst = instance.ShiftLeft_ConstCore((dynamic)vsrc, shiftAmount, (dynamic)args0, (dynamic)args1);
                        ClassicAssert.AreEqual(vexpected, vdst, $"_Core of {instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
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
            //Vector512<T> vzero = Vector512<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize - 1;
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftLeft_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector512<T>[] samples = {
                Vector512s.Create(src),
                Vector512s<T>.Demo,
                Vector512s<T>.Serial,
            };
            foreach (Vector512<T> vsrc in samples) {
                for (int shiftAmount = 0; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector512<T> vexpected = Vector512s.ShiftLeft_Fast((dynamic)vsrc, shiftAmount);
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector512<T> vdst = instance.ShiftLeft_Fast((dynamic)vsrc, shiftAmount);
                        ClassicAssert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    }
                }
            }
        }

        [TestCase((sbyte)3)]
        [TestCase((short)5)]
        [TestCase((int)7)]
        [TestCase((long)9)]
        public void ShiftRightArithmeticTest<T>(T src) where T : struct {
            //Vector512<T> vzero = Vector512<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize + 1;
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftRightArithmetic_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector512<T>[] samples = {
                Vector512s.Create(src),
                Vector512s<T>.Demo,
                Vector512s<T>.Serial,
            };
            foreach (Vector512<T> vsrc in samples) {
                for (int shiftAmount = -1; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector512<T> vexpected = Vector512s.ShiftRightArithmetic((dynamic)vsrc, shiftAmount);
                    // Static: Args and Core
                    Vector512<T> args0, args1;
#pragma warning disable CS0618 // Type or member is obsolete
                    (args0, args1) = Vector512s.ShiftRightArithmetic_Args<T>(vsrc, shiftAmount);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector512<T> vdst = Vector512s.ShiftRightArithmetic_Core((dynamic)vsrc, shiftAmount, (dynamic)args0, (dynamic)args1);
                    ClassicAssert.AreEqual(vexpected, vdst, $"_Core, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        vdst = instance.ShiftRightArithmetic((dynamic)vsrc, shiftAmount);
                        ClassicAssert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        (args0, args1) = instance.ShiftRightArithmetic_Args<T>(vsrc, shiftAmount);
#pragma warning restore CS0618 // Type or member is obsolete
                        vdst = instance.ShiftRightArithmetic_Core((dynamic)vsrc, shiftAmount, (dynamic)args0, (dynamic)args1);
                        ClassicAssert.AreEqual(vexpected, vdst, $"_Core of {instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    }
                }
            }
        }

        [TestCase((sbyte)3)]
        [TestCase((short)5)]
        [TestCase((int)7)]
        [TestCase((long)9)]
        public void ShiftRightArithmetic_ConstTest<T>(T src) where T : struct {
            //Vector512<T> vzero = Vector512<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize - 1;
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftRightArithmetic_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector512<T>[] samples = {
                Vector512s.Create(src),
                Vector512s<T>.Demo,
                Vector512s<T>.Serial,
            };
            foreach (Vector512<T> vsrc in samples) {
                for (int shiftAmount = 1; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector512<T> vexpected = Vector512s.ShiftRightArithmetic_Const((dynamic)vsrc, shiftAmount);
                    // Static: Args and Core
                    Vector512<T> args0, args1;
#pragma warning disable CS0618 // Type or member is obsolete
                    (args0, args1) = Vector512s.ShiftRightArithmetic_Args<T>(vsrc, shiftAmount);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector512<T> vdst = Vector512s.ShiftRightArithmetic_ConstCore((dynamic)vsrc, shiftAmount, (dynamic)args0, (dynamic)args1);
                    ClassicAssert.AreEqual(vexpected, vdst, $"_Core, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    // Instances
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        vdst = instance.ShiftRightArithmetic_Const((dynamic)vsrc, shiftAmount);
                        ClassicAssert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        (args0, args1) = instance.ShiftRightArithmetic_Args<T>(vsrc, shiftAmount);
#pragma warning restore CS0618 // Type or member is obsolete
                        vdst = instance.ShiftRightArithmetic_ConstCore((dynamic)vsrc, shiftAmount, (dynamic)args0, (dynamic)args1);
                        ClassicAssert.AreEqual(vexpected, vdst, $"_Core of {instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    }
                }
            }
        }

        [TestCase((sbyte)3)]
        [TestCase((short)5)]
        [TestCase((int)7)]
        [TestCase((long)9)]
        public void ShiftRightArithmetic_FastTest<T>(T src) where T : struct {
            //Vector512<T> vzero = Vector512<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize - 1;
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftRightArithmetic_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vector512s.GetSupportedMethodList<Func<Vector512<T>, int, Vector512<T>>>("ShiftRightArithmetic_Fast_Base", "ShiftRightArithmetic_Fast_Negative", "ShiftRightArithmetic_Fast_Widen", "ShiftRightArithmetic_Fast_Narrow", "ShiftRightArithmetic_Fast_NarrowIfLess");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            // run.
            Vector512<T>[] samples = {
                Vector512s.Create(src),
                Vector512s<T>.Demo,
                Vector512s<T>.Serial,
            };
            foreach (Vector512<T> vsrc in samples) {
                for (int shiftAmount = 0; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector512<T> vexpected = Vector512s.ShiftRightArithmetic_Fast((dynamic)vsrc, shiftAmount);
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector512<T> vdst = instance.ShiftRightArithmetic_Fast((dynamic)vsrc, shiftAmount);
                        ClassicAssert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    }
                    foreach (var func in funcList) {
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        Vector512<T> vdst = func(vsrc, shiftAmount);
                        ClassicAssert.AreEqual(vexpected, vdst, $"{funcName}, shiftAmount={shiftAmount}, vsrc={vsrc}");
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
            //Vector512<T> vzero = Vector512<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize + 1;
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftRightLogical_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector512<T>[] samples = {
                Vector512s.Create(src),
                Vector512s<T>.Demo,
                Vector512s<T>.Serial,
            };
            foreach (Vector512<T> vsrc in samples) {
                for (int shiftAmount = -1; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector512<T> vexpected = Vector512s.ShiftRightLogical((dynamic)vsrc, shiftAmount);
                    // Static: Args and Core
                    Vector512<T> args0, args1;
#pragma warning disable CS0618 // Type or member is obsolete
                    (args0, args1) = Vector512s.ShiftRightLogical_Args<T>(vsrc, shiftAmount);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector512<T> vdst = Vector512s.ShiftRightLogical_Core((dynamic)vsrc, shiftAmount, (dynamic)args0, (dynamic)args1);
                    ClassicAssert.AreEqual(vexpected, vdst, $"_Core, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        vdst = instance.ShiftRightLogical((dynamic)vsrc, shiftAmount);
                        ClassicAssert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        (args0, args1) = instance.ShiftRightLogical_Args<T>(vsrc, shiftAmount);
#pragma warning restore CS0618 // Type or member is obsolete
                        vdst = instance.ShiftRightLogical_Core((dynamic)vsrc, shiftAmount, (dynamic)args0, (dynamic)args1);
                        ClassicAssert.AreEqual(vexpected, vdst, $"_Core of {instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
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
            //Vector512<T> vzero = Vector512<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize - 1;
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftRightLogical_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector512<T>[] samples = {
                Vector512s.Create(src),
                Vector512s<T>.Demo,
                Vector512s<T>.Serial,
            };
            foreach (Vector512<T> vsrc in samples) {
                for (int shiftAmount = 1; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector512<T> vexpected = Vector512s.ShiftRightLogical_Const((dynamic)vsrc, shiftAmount);
                    // Static: Args and Core
                    Vector512<T> args0, args1;
#pragma warning disable CS0618 // Type or member is obsolete
                    (args0, args1) = Vector512s.ShiftRightLogical_Args<T>(vsrc, shiftAmount);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector512<T> vdst = Vector512s.ShiftRightLogical_ConstCore((dynamic)vsrc, shiftAmount, (dynamic)args0, (dynamic)args1);
                    ClassicAssert.AreEqual(vexpected, vdst, $"_Core, shiftAmount={shiftAmount}, vsrc={vsrc}");
                    // Instances
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        vdst = instance.ShiftRightLogical_Const((dynamic)vsrc, shiftAmount);
                        ClassicAssert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
                        // Instances: Args and Core
#pragma warning disable CS0618 // Type or member is obsolete
                        (args0, args1) = instance.ShiftRightLogical_Args<T>(vsrc, shiftAmount);
#pragma warning restore CS0618 // Type or member is obsolete
                        vdst = instance.ShiftRightLogical_ConstCore((dynamic)vsrc, shiftAmount, (dynamic)args0, (dynamic)args1);
                        ClassicAssert.AreEqual(vexpected, vdst, $"_Core of {instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
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
            //Vector512<T> vzero = Vector512<T>.Zero;
            //T zero = default;
            int shiftAmountMax = Scalars<T>.BitSize - 1;
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.ShiftRightLogical_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector512<T>[] samples = {
                Vector512s.Create(src),
                Vector512s<T>.Demo,
                Vector512s<T>.Serial,
            };
            foreach (Vector512<T> vsrc in samples) {
                for (int shiftAmount = 1; shiftAmount <= shiftAmountMax; ++shiftAmount) {
                    Vector512<T> vexpected = Vector512s.ShiftRightLogical_Fast((dynamic)vsrc, shiftAmount);
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector512<T> vdst = instance.ShiftRightLogical_Fast((dynamic)vsrc, shiftAmount);
                        ClassicAssert.AreEqual(vexpected, vdst, $"{instance.GetType().Name}, shiftAmount={shiftAmount}, vsrc={vsrc}");
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
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
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
            Vector512<T>[] samples = {
                //Vector512s.CreateByDoubleLoop<T>(Scalars.GetDoubleFrom(src), 1),
                //Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                //Vector512s<T>.SerialNegative
            };
            Vector512<TIdx>[] indicesList = {
                Vector512s<TIdx>.Serial,
                Vector512s<TIdx>.SerialDesc,
                Vector512s.CreateByDoubleLoop<TIdx>(0, 2),
                Vector512s.CreateByDoubleLoop<TIdx>(1, 2),
                Vector512s.CreateByDoubleLoop<TIdx>(Scalars.GetDoubleFrom(src), 1),
            };
            foreach (Vector512<T> vector in samples) {
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("== Sample:\t{0}", vector));
                }
                foreach (Vector512<TIdx> indices in indicesList) {
#if NET7_0_OR_GREATER
                    Vector512<T> expected = Vector512.Shuffle((dynamic)vector, (dynamic)indices);
#else
                    Vector512<T> expected = Vector512s.Shuffle((dynamic)vector, (dynamic)indices);
#endif // NET7_0_OR_GREATER
                    if (allowLog) {
                        Console.WriteLine(VectorTextUtil.Format("Indices:\t{0}", indices));
                        Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                    }
                    // Static: Args and Core
                    Vector512<TIdx> args0, args1;
#pragma warning disable CS0618 // Type or member is obsolete
                    Vector512s.Shuffle_Args<TIdx>(indices, out args0, out args1);
#pragma warning restore CS0618 // Type or member is obsolete
                    Vector512<T> dst = Vector512s.Shuffle_Core((dynamic)vector, (dynamic)args0, (dynamic)args1);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core0", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, "_Core0, vector={vector}, indices={indices}");
                    }
                    // Static: Args and Core with ValueTuple
                    var args = Vector512s.Shuffle_Args((dynamic)indices);
                    dst = Vector512s.Shuffle_Core((dynamic)vector, (dynamic)args);
                    if (allowLogItem) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core", dst, vector, indices));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, "_Core, vector={vector}, indices={indices}");
                    }
                    // Instances
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        dst = instance.Shuffle((dynamic)vector, (dynamic)indices);
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, vector={vector}, indices={indices}");
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
                            ClassicAssert.AreEqual(expected, dst, "_Core0 of {instance.GetType().Name}, vector={vector}, indices={indices}");
                        }
                        // Instances: Args and Core with ValueTuple
#pragma warning disable CS0618 // Type or member is obsolete
                        var argsI = instance.Shuffle_Args<TIdx>(indices);
                        // dst = instance.Shuffle_Core((dynamic)vector, (dynamic)argsI); // CS1973	'IWVectorTraits512' has no applicable method named 'Shuffle_Core' but appears to have an extension method by that name. Extension methods cannot be dynamically dispatched. Consider casting the dynamic arguments or calling the extension method without the extension method syntax.
                        dst = instance.Shuffle_Core<T, TIdx>(vector, argsI);
#pragma warning restore CS0618 // Type or member is obsolete
                        if (allowLogItem) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}, indices={3}", "_Core of " + instance.GetType().Name, dst, vector, indices));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, "_Core of {instance.GetType().Name}, vector={vector}, indices={indices}");
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
        public void SqrtTest<T>(T src) where T : struct {
            TextWriter writer = Console.Out;
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.Sqrt_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector512<T>[] samples = {
                Vector512s.Create(src),
                Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                Vector512s<T>.SerialNegative,
                Vector512s<T>.InterlacedSign
            };
            bool allowLog = false;
            bool showNotEquals = false;
            foreach (Vector512<T> vector in samples) {
                Vector512<T> expected = Vector512s.Sqrt((dynamic)vector);
                bool usedWrite = false;
                foreach (IWVectorTraits512 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector512<T> dst = instance.Sqrt((dynamic)vector);
                    bool showLog = allowLog;
                    if (!showLog && !expected.AsByte().Equals(dst.AsByte())) {
                        if (showNotEquals) {
                            showLog = true;
                        }
                    }
                    if (showLog) {
                        if (!usedWrite) {
                            usedWrite = true;
                            writer.WriteLine();
                            writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}, vector={2}", "Expected", expected, vector));
                        }
                        writer.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected.AsByte(), dst.AsByte(), $"{instance.GetType().Name}, vector={vector}");
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
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.Subtract_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector512<T>[] samples = {
                Vector512s.Create(src),
                Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                Vector512s<T>.SerialNegative
            };
            foreach (Vector512<T> left in samples) {
                foreach (Vector512<T> right in samples) {
#if NET7_0_OR_GREATER
                    Vector512<T> expected = Vector512.Subtract(left, right);
#else
                    Vector512<T> expected = Vector512s.Subtract((dynamic)left, (dynamic)right);
#endif // NET7_0_OR_GREATER
                    foreach (IWVectorTraits512 instance in instances) {
                        if (!instance.GetIsSupported(true)) continue;
                        Vector512<T> dst = instance.Subtract((dynamic)left, (dynamic)right);
                        if (Scalars<T>.ExponentBits > 0) {
                            // Compatible floating-point NaN.
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, left={2}, right={3}", instance.GetType().Name, dst, left, right));
                        } else {
                            ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, left={left}, right={right}");
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
            IReadOnlyList<IWVectorTraits512> instances = Vector512s.TraitsInstances;
            foreach (IWVectorTraits512 instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine(VectorTextUtil.Format("{0}: OK. Accelerated=({1})", instance.GetType().Name, instance.Sum_AcceleratedTypes));
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            bool allowLog = Scalars<T>.ExponentBits > 0;
            //bool allowLog = true;
            Vector512<T>[] samples = {
                Vector512s.Create(src),
                Vector512s<T>.Demo,
                Vector512s<T>.Serial,
                Vector512s<T>.SerialNegative,
                Vector512s<T>.InterlacedSign,
            };
            foreach (Vector512<T> vector in samples) {
#if NET7_0_OR_GREATER
                T expected = Vector512.Sum((dynamic)vector);
#else
                T expected = Vector512s.Sum((dynamic)vector);
#endif // NET7_0_OR_GREATER
                if (allowLog) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", vector));
                    Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                }
                foreach (IWVectorTraits512 instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    T dst = instance.Sum((dynamic)vector);
                    if (Scalars<T>.ExponentBits > 0) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst));
                    } else {
                        ClassicAssert.AreEqual(expected, dst, $"{instance.GetType().Name}, vector={vector}");
                    }
                }
            }
        }


#endif
    }
}
