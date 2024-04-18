using NUnit.Framework;
#if !USED_NUNIT3
using NUnit.Framework.Legacy;
#endif
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Zyl.VectorTraits.Impl;

namespace Zyl.VectorTraits.Tests.Impl.IVectorTraitsTest {
#if USED_NUNIT3
    using ClassicAssert = Assert;
#endif

    [TestFixture()]
    public class VectorTests {

        [Test]
        public void InstancesTest() {
            TextWriter writer = Console.Out;
            //string indent = VectorTextUtil.IndentNextSeparator;
            IReadOnlyList<IVectorTraits> instances = Vectors.TraitsInstances;
            foreach (IVectorTraits instance in instances) {
                Type aType = instance.GetType();
                writer.WriteLine("[{0}]", aType.Name);
                writer.WriteLine("IsHardwareAccelerated:\t{0}", instance.IsHardwareAccelerated);
                //writer.WriteLine("IsSupported:\t{0}", instance.IsSupported);
                writer.WriteLine("GetIsSupported(false):\t{0}", instance.GetIsSupported(false));
                writer.WriteLine("GetIsSupported(true):\t{0}", instance.GetIsSupported(true));
                writer.WriteLine("GetUnsupportedMessage(false):\t{0}", instance.GetUnsupportedMessage(false));
                writer.WriteLine("GetUnsupportedMessage(true):\t{0}", instance.GetUnsupportedMessage(true));
                // Properties
                VectorTextUtil.OutputProperties(writer, instance);
                // done.
                writer.WriteLine();
            }
        }

    }
}
