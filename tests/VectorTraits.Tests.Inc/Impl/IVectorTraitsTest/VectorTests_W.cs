﻿using NUnit.Framework;
#if !USED_NUNIT3
using NUnit.Framework.Legacy;
#endif
using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IVectorTraitsTest {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    [TestFixture()]
    public class VectorTests_W {

        [TestCase((float)1, (double)1)]
        [TestCase((sbyte)3, (short)1)]
        [TestCase((byte)4, (ushort)1)]
        [TestCase((short)5, (int)1)]
        [TestCase((ushort)6, (uint)1)]
        [TestCase((int)7, (long)1)]
        [TestCase((uint)8, (ulong)1)]
        public void WidenTest<T, TOut>(T src, TOut dst) where T : struct where TOut : struct {
#pragma warning disable CS0618 // Type or member is obsolete
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.Widen_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            // run.
            Vector<T>[] samples = {
                Vectors.Create(src),
                Vectors<T>.Demo,
                Vectors<T>.Serial,
                Vectors<T>.SerialNegative,
                Vectors<T>.InterlacedSign,
                Vectors<T>.XyXMask,
                Vectors<T>.XyzwXMask
            };
            foreach (Vector<T> source in samples) {
                Vector<TOut> expected0, expected1;
#if NETCOREAPP3_0_OR_GREATER
                // CS8133	Cannot deconstruct dynamic objects. (expected0, expected1) = Vector.Widen((dynamic)vector);
                VectorGeneric.Widen(source, out expected0, out expected1);
#else
                // CS1510	A ref or out value must be an assignable variable . Vectors.Widen((dynamic)vector, out (dynamic)expected0, out (dynamic)expected1);
                Vectors.Widen(source, out expected0, out expected1);
#endif // NETCOREAPP3_0_OR_GREATER
                if (Scalars<T>.ExponentBits > 0) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", source));
                    Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}, {1}", expected0, expected1));
                }
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<TOut> dst0, dst1;
                    instance.Widen(source, out dst0, out dst1);
                    if (Scalars<T>.ExponentBits > 0) {
                        // Compatible floating-point NaN.
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}, {2}", instance.GetType().Name, dst0, dst1));
                    } else {
                        ClassicAssert.AreEqual(expected0, dst0, $"{instance.GetType().Name}, source={source}");
                        ClassicAssert.AreEqual(expected1, dst1, $"{instance.GetType().Name}, source={source}");
                    }
                }
            }
#pragma warning restore CS0618 // Type or member is obsolete
        }

        [TestCase((float)1, (double)1)]
        [TestCase((sbyte)3, (short)1)]
        [TestCase((byte)4, (ushort)1)]
        [TestCase((short)5, (int)1)]
        [TestCase((ushort)6, (uint)1)]
        [TestCase((int)7, (long)1)]
        [TestCase((uint)8, (ulong)1)]
        public void WidenLowerTest<T, TOut>(T src, TOut dst) where T : struct where TOut : struct {
#pragma warning disable CS0618 // Type or member is obsolete
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.WidenLower_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<TOut>>>("WidenLower_Basic");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            Console.WriteLine();
            // run.
            bool allowLogItem = Scalars<T>.ExponentBits > 0; // Compatible floating-point NaN.
            Vector<T>[] samples = {
                Vectors.Create(src),
                Vectors<T>.Demo,
                Vectors<T>.Serial,
                Vectors<T>.SerialNegative,
                Vectors<T>.InterlacedSign,
                Vectors<T>.XyXMask,
                Vectors<T>.XyzwXMask
            };
            foreach (Vector<T> source in samples) {
                Vector<TOut> expected = Vectors.WidenLower((dynamic)source);
#if NET8_0_OR_GREATER
                try {
                    expected = Vector.WidenLower((dynamic)source);
                } catch (Exception ex) {
                    Console.WriteLine(VectorTextUtil.Format("Fail by {0}! {1}", source, ex));
                }
#endif // NET8_0_OR_GREATER
                if (Scalars<T>.ExponentBits > 0) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", source));
                    Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                }
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<TOut> dst0 = instance.WidenLower((dynamic)source);
                    if (allowLogItem) {
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst0));
                    } else {
                        ClassicAssert.AreEqual(expected, dst0, $"{instance.GetType().Name}, source={source}");
                    }
                }
                bool runLogItem = true;
#if NET8_0_OR_GREATER
                if (RuntimeInformation.OSArchitecture == Architecture.Wasm) {
                    runLogItem = false; // Bug at .NET8.0 Wasm.
                }
#endif // NET8_0_OR_GREATER
                if (runLogItem) {
                    foreach (var func in funcList) {
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        Vector<TOut> dst0 = func((dynamic)source);
                        if (allowLogItem) {
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", funcName, dst0));
                        } else {
                            ClassicAssert.AreEqual(expected, dst0, $"{funcName}, source={source}");
                        }
                    } // funcList
                }
            }
#pragma warning restore CS0618 // Type or member is obsolete
        }

        [TestCase((float)1, (double)1)]
        [TestCase((sbyte)3, (short)1)]
        [TestCase((byte)4, (ushort)1)]
        [TestCase((short)5, (int)1)]
        [TestCase((ushort)6, (uint)1)]
        [TestCase((int)7, (long)1)]
        [TestCase((uint)8, (ulong)1)]
        public void WidenUpperTest<T, TOut>(T src, TOut dst) where T : struct where TOut : struct {
#pragma warning disable CS0618 // Type or member is obsolete
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                if (instance.GetIsSupported(true)) {
                    Console.WriteLine($"{instance.GetType().Name}: OK. {instance.WidenUpper_AcceleratedTypes}");
                } else {
                    Console.WriteLine($"{instance.GetType().Name}: {instance.GetUnsupportedMessage()}");
                }
            }
            var funcList = Vectors.GetSupportedMethodList<Func<Vector<T>, Vector<TOut>>>("WidenUpper_Basic");
            foreach (var func in funcList) {
                Console.WriteLine("{0}: OK", ReflectionUtil.GetShortNameWithType(func.Method));
            }
            Console.WriteLine();
            // run.
            bool allowLogItem = Scalars<T>.ExponentBits > 0; // Compatible floating-point NaN.
            Vector<T>[] samples = {
                Vectors.Create(src),
                Vectors<T>.Demo,
                Vectors<T>.Serial,
                Vectors<T>.SerialNegative,
                Vectors<T>.InterlacedSign,
                Vectors<T>.XyXMask,
                Vectors<T>.XyzwXMask
            };
            foreach (Vector<T> source in samples) {
                Vector<TOut> expected = Vectors.WidenUpper((dynamic)source);
#if NET8_0_OR_GREATER
                try {
                    expected = Vector.WidenUpper((dynamic)source);
                } catch (Exception ex) {
                    Console.WriteLine(VectorTextUtil.Format("Fail by {0}! {1}", source, ex));
                }
#endif // NET8_0_OR_GREATER
                if (Scalars<T>.ExponentBits > 0) {
                    Console.WriteLine();
                    Console.WriteLine(VectorTextUtil.Format("Sample:\t{0}", source));
                    Console.WriteLine(VectorTextUtil.Format("Expected:\t{0}", expected));
                }
                foreach (IVectorTraits instance in instances) {
                    if (!instance.GetIsSupported(true)) continue;
                    Vector<TOut> dst0 = instance.WidenUpper((dynamic)source);
                    if (allowLogItem) {
                        Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", instance.GetType().Name, dst0));
                    } else {
                        ClassicAssert.AreEqual(expected, dst0, $"{instance.GetType().Name}, source={source}");
                    }
                }
                bool runLogItem = true;
#if NET8_0_OR_GREATER
                if (RuntimeInformation.OSArchitecture == Architecture.Wasm) {
                    runLogItem = false; // Bug at .NET8.0 Wasm.
                }
#endif // NET8_0_OR_GREATER
                if (runLogItem) {
                    foreach (var func in funcList) {
                        string funcName = ReflectionUtil.GetShortNameWithType(func.Method);
                        Vector<TOut> dst0 = func((dynamic)source);
                        if (allowLogItem) {
                            Console.WriteLine(VectorTextUtil.Format("{0}:\t{1}", funcName, dst0));
                        } else {
                            ClassicAssert.AreEqual(expected, dst0, $"{funcName}, source={source}");
                        }
                    } // funcList
                }
            }
#pragma warning restore CS0618 // Type or member is obsolete
        }


    }
}