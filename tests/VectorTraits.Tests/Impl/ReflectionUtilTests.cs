using NUnit.Framework;
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

namespace Zyl.VectorTraits.Tests.Impl {
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
                typeof(VectorTraits256Base.Statics), typeof(VectorTraits256Abstract),
                typeof(VectorTraits256Avx2.Statics), typeof(VectorTraits256Avx2Abstract),
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
        }

#endif // NETCOREAPP3_0_OR_GREATER

    }
}