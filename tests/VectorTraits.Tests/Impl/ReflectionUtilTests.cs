using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Zyl.VectorTraits;
using Zyl.VectorTraits.Impl;
using Zyl.VectorTraits.Impl.AVector;
using System.Reflection;

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
            }
        }


    }
}