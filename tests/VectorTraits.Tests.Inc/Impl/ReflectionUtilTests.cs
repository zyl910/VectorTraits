using NUnit.Framework;
#if !USED_NUNIT3
using NUnit.Framework.Legacy;
#endif
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Zyl.VectorTraits;
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.AVector;
using Zyl.VectorTraits.Impl.AVector128;
using Zyl.VectorTraits.Impl.AVector256;
using Zyl.VectorTraits.Impl.AVector512;

namespace Zyl.VectorTraits.Tests.Impl {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    [TestFixture()]
    public class ReflectionUtilTests {

        [Test()]
        public void CheckBindMethodsTest() {
            TextWriter writer = Console.Out;
            Type? interfaceType = null;
            interfaceType = typeof(IVectorTraits);
            Type[] types = new Type[] {
                typeof(VectorTraitsBase.Statics), typeof(VectorTraitsAbstract),
                typeof(VectorTraits128Base.Statics), typeof(VectorTraits128Abstract),
                typeof(VectorTraits128AdvSimd.Statics), typeof(VectorTraits128AdvSimdAbstract),
                typeof(VectorTraits128AdvSimdB64.Statics), typeof(VectorTraits128AdvSimdB64Abstract),
                typeof(VectorTraits128Avx2.Statics), typeof(VectorTraits128Avx2Abstract),
                typeof(VectorTraits128Sse.Statics), typeof(VectorTraits128SseAbstract),
                typeof(VectorTraits256Base.Statics), typeof(VectorTraits256Abstract),
                typeof(VectorTraits256Avx2.Statics), typeof(VectorTraits256Avx2Abstract),
                typeof(VectorTraits512Base.Statics), typeof(VectorTraits512Abstract),
                typeof(VectorTraits512Avx512.Statics), typeof(VectorTraits512Avx512Abstract),
            };
            int totalMissed = 0;
            for (int i = 0; i < types.Length; i += 2) {
                Type staticType = types[i];
                Type objectType = types[i + 1];
                writer.WriteLine("{0}:", staticType.FullName);
                int n = ReflectionUtil.CheckBindMethods(staticType, objectType, interfaceType, delegate (MethodInfo methodStatic, MethodInfo? methodInterface, object? userdata) {
                    bool isIgnore = (null == methodInterface); // If it is not in the method list of the interface, it is ignored.
                    _ = userdata;
                    if (!isIgnore) {
                        writer.WriteLine("  {0}", methodStatic.ToString());
                    }
                    return isIgnore;
                });
                writer.WriteLine("{0} missed count: {1}", staticType.FullName, n);
                totalMissed += n;
            }
            writer.WriteLine("Total missed: {0}", totalMissed);
            ClassicAssert.Zero(totalMissed);
        }

#if NETCOREAPP3_0_OR_GREATER

        [Test()]
        public void CheckBindMethodsTest_128() {
            TextWriter writer = Console.Out;
            Type? interfaceType = null;
            interfaceType = typeof(IWVectorTraits128);
            Type[] types = new Type[] {
                typeof(WVectorTraits128Base.Statics), typeof(WVectorTraits128Abstract),
                typeof(WVectorTraits128AdvSimd.Statics), typeof(WVectorTraits128AdvSimdAbstract),
                typeof(WVectorTraits128AdvSimdB64.Statics), typeof(WVectorTraits128AdvSimdB64Abstract),
                typeof(WVectorTraits128Avx2.Statics), typeof(WVectorTraits128Avx2Abstract),
                typeof(WVectorTraits128Sse.Statics), typeof(WVectorTraits128SseAbstract),
            };
            int totalMissed = 0;
            for (int i = 0; i < types.Length; i += 2) {
                Type staticType = types[i];
                Type objectType = types[i + 1];
                writer.WriteLine("{0}:", staticType.FullName);
                int n = ReflectionUtil.CheckBindMethods(staticType, objectType, interfaceType, delegate (MethodInfo methodStatic, MethodInfo? methodInterface, object? userdata) {
                    bool isIgnore = (null == methodInterface); // If it is not in the method list of the interface, it is ignored.
                    _ = userdata;
                    if (!isIgnore) {
                        writer.WriteLine("  {0}", methodStatic.ToString());
                    }
                    return isIgnore;
                });
                writer.WriteLine("{0} missed count: {1}", staticType.FullName, n);
                totalMissed += n;
            }
            writer.WriteLine("Total missed: {0}", totalMissed);
            ClassicAssert.Zero(totalMissed);
        }

        [Test()]
        public void CheckBindMethodsTest_256() {
            TextWriter writer = Console.Out;
            Type? interfaceType = null;
            interfaceType = typeof(IWVectorTraits256);
            Type[] types = new Type[] {
                typeof(WVectorTraits256Base.Statics), typeof(WVectorTraits256Abstract),
                typeof(WVectorTraits256Avx2.Statics), typeof(WVectorTraits256Avx2Abstract),
            };
            int totalMissed = 0;
            for (int i = 0; i < types.Length; i += 2) {
                Type staticType = types[i];
                Type objectType = types[i + 1];
                writer.WriteLine("{0}:", staticType.FullName);
                int n = ReflectionUtil.CheckBindMethods(staticType, objectType, interfaceType, delegate (MethodInfo methodStatic, MethodInfo? methodInterface, object? userdata) {
                    bool isIgnore = (null == methodInterface); // If it is not in the method list of the interface, it is ignored.
                    _ = userdata;
                    if (!isIgnore) {
                        writer.WriteLine("  {0}", methodStatic.ToString());
                    }
                    return isIgnore;
                });
                writer.WriteLine("{0} missed count: {1}", staticType.FullName, n);
                totalMissed += n;
            }
            writer.WriteLine("Total missed: {0}", totalMissed);
            ClassicAssert.Zero(totalMissed);
        }

#if NET8_0_OR_GREATER
        [Test()]
        public void CheckBindMethodsTest_512() {
            TextWriter writer = Console.Out;
            Type? interfaceType = null;
            interfaceType = typeof(IWVectorTraits512);
            Type[] types = new Type[] {
                typeof(WVectorTraits512Base.Statics), typeof(WVectorTraits512Abstract),
                typeof(WVectorTraits512Avx512.Statics), typeof(WVectorTraits512Avx512Abstract),
            };
            int totalMissed = 0;
            for (int i = 0; i < types.Length; i += 2) {
                Type staticType = types[i];
                Type objectType = types[i + 1];
                writer.WriteLine("{0}:", staticType.FullName);
                int n = ReflectionUtil.CheckBindMethods(staticType, objectType, interfaceType, delegate (MethodInfo methodStatic, MethodInfo? methodInterface, object? userdata) {
                    bool isIgnore = (null == methodInterface); // If it is not in the method list of the interface, it is ignored.
                    _ = userdata;
                    if (!isIgnore) {
                        writer.WriteLine("  {0}", methodStatic.ToString());
                    }
                    return isIgnore;
                });
                writer.WriteLine("{0} missed count: {1}", staticType.FullName, n);
                totalMissed += n;
            }
            writer.WriteLine("Total missed: {0}", totalMissed);
            ClassicAssert.Zero(totalMissed);
        }
#endif // NET8_0_OR_GREATER

        [Test()]
        public void CheckBindMethodsAnyVectorTest() {
            TextWriter writer = Console.Out;
            Type? interfaceType = null;
            interfaceType = typeof(IVectorTraits);
            Type[] types = new Type[] {
                // -- 128 --
                typeof(WVectorTraits128AdvSimd.Statics), typeof(VectorTraits128AdvSimd.Statics),
                typeof(WVectorTraits128AdvSimdB64.Statics), typeof(VectorTraits128AdvSimdB64.Statics),
                typeof(WVectorTraits128Avx2.Statics), typeof(VectorTraits128Avx2.Statics),
                typeof(WVectorTraits128Sse.Statics), typeof(VectorTraits128Sse.Statics),
                // -- 256 --
                typeof(WVectorTraits256Avx2.Statics), typeof(VectorTraits256Avx2.Statics),
                // -- 512 --
                typeof(WVectorTraits512Avx512.Statics), typeof(VectorTraits512Avx512.Statics),
            };
            int totalMissed = 0;
            for (int i = 0; i < types.Length; i += 2) {
                Type staticType = types[i];
                Type objectType = types[i + 1];
                writer.WriteLine("{0}:", staticType.FullName);
                int n = ReflectionUtil.CheckBindMethodsAnyVector(staticType, objectType, interfaceType, delegate (MethodInfo methodStatic, MethodInfo? methodInterface, object? userdata) {
                    bool isIgnore = (null == methodInterface); // If it is not in the method list of the interface, it is ignored.
                    _ = userdata;
                    if (!isIgnore) {
                        writer.WriteLine("  {0}", methodStatic.ToString());
                    }
                    return isIgnore;
                });
                writer.WriteLine("{0} missed count: {1}", staticType.FullName, n);
                totalMissed += n;
            }
            writer.WriteLine("Total missed: {0}", totalMissed);
            ClassicAssert.Zero(totalMissed);
        }

#endif // NETCOREAPP3_0_OR_GREATER

    }
}