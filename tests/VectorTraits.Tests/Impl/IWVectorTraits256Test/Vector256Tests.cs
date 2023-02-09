using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.IO;
using System.Reflection;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IWVectorTraits256Test {
    [TestFixture()]
    public class Vector256Tests {

        [Test]
        public void InstancesTest() {
            TextWriter writer = Console.Out;
            //string indent = VectorTextUtil.IndentNextSeparator;
            IReadOnlyList<IWVectorTraits256> instances = Vector256s.TraitsInstances;
            foreach (IWVectorTraits256 instance in instances) {
                Type aType = instance.GetType();
                writer.WriteLine("[{0}]", aType.Name);
                //writer.WriteLine("IsSupported:\t{0}", instance.IsSupported);
                writer.WriteLine("GetIsSupported(false):\t{0}", instance.GetIsSupported(false));
                writer.WriteLine("GetIsSupported(true):\t{0}", instance.GetIsSupported(true));
                writer.WriteLine("GetUnsupportedMessage(false):\t{0}", instance.GetUnsupportedMessage(false));
                writer.WriteLine("GetUnsupportedMessage(true):\t{0}", instance.GetUnsupportedMessage(true));
                // Properties
                var properties = aType.GetRuntimeProperties();
                foreach (PropertyInfo p in properties) {
                    if (!p.CanRead) continue;
                    if (p.GetIndexParameters().Length > 0) continue;
                    string key = p.Name;
                    object? v = null;
                    try {
                        if (p.GetGetMethod()!.IsStatic) continue;
                        v = p.GetValue(instance);
                    } catch(Exception ex) {
                        v = ex.Message;
                    }
                    VectorTextUtil.WriteLine(writer, "{0}:\t{1}", key, v);
                }
                // done.
                writer.WriteLine();
            }
        }

#if NETCOREAPP3_0_OR_GREATER

#endif
    }
}
