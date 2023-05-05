using System;
using System.Collections.Generic;
using System.Diagnostics;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;
using Zyl.VectorTraits.Extensions.SameW;
using Zyl.VectorTraits.Impl;

[assembly: CLSCompliant(true)]

namespace Zyl.VectorTraits {

    /// <summary>
    /// VectorTraits global initializer (全局初始化器). It is used to initialize data ahead of time to improve performance (它用于提前初始化数据, 提高运行性能).
    /// </summary>
    public static class VectorTraitsGlobal {
        private static bool m_Inited = false;
        private static readonly int m_InitCheckSum;

        /// <summary>
        /// Get init check sum.
        /// </summary>
        public static int InitCheckSum { get => m_InitCheckSum; }

        /// <summary>
        /// Do initialize (进行初始化).
        /// </summary>
        public static void Init() {
            if (!m_Inited) return;
            m_Inited = true;
            // Initialize on static constructor.
            // done.
#if (NETSTANDARD1_1)
            Debug.WriteLine("VectorTraitsGlobal initialize done.");
#else
            Trace.WriteLine("VectorTraitsGlobal initialize done.");
#endif
        }

        static VectorTraitsGlobal() {
            m_InitCheckSum = 0;

            // Vector
            m_InitCheckSum += Vectors<sbyte>.Demo.AsInt32()[0];
            m_InitCheckSum += Vectors<byte>.Demo.AsInt32()[0];
            m_InitCheckSum += Vectors<short>.Demo.AsInt32()[0];
            m_InitCheckSum += Vectors<ushort>.Demo.AsInt32()[0];
            m_InitCheckSum += Vectors<int>.Demo.AsInt32()[0];
            m_InitCheckSum += Vectors<uint>.Demo.AsInt32()[0];
            m_InitCheckSum += Vectors<long>.Demo.AsInt32()[0];
            m_InitCheckSum += Vectors<ulong>.Demo.AsInt32()[0];
            m_InitCheckSum += Vectors<float>.Demo.AsInt32()[0];
            m_InitCheckSum += Vectors<double>.Demo.AsInt32()[0];

#if NETCOREAPP3_0_OR_GREATER
            // Vector128
            m_InitCheckSum += Vector128s<sbyte>.Demo.AsInt32().GetElement(0);
            m_InitCheckSum += Vector128s<byte>.Demo.AsInt32().GetElement(0);
            m_InitCheckSum += Vector128s<short>.Demo.AsInt32().GetElement(0);
            m_InitCheckSum += Vector128s<ushort>.Demo.AsInt32().GetElement(0);
            m_InitCheckSum += Vector128s<int>.Demo.AsInt32().GetElement(0);
            m_InitCheckSum += Vector128s<uint>.Demo.AsInt32().GetElement(0);
            m_InitCheckSum += Vector128s<long>.Demo.AsInt32().GetElement(0);
            m_InitCheckSum += Vector128s<ulong>.Demo.AsInt32().GetElement(0);
            m_InitCheckSum += Vector128s<float>.Demo.AsInt32().GetElement(0);
            m_InitCheckSum += Vector128s<double>.Demo.AsInt32().GetElement(0);
            m_InitCheckSum += Vector128Constants.Shuffle_UInt16_Multiplier.AsInt32().GetElement(0);

            // Vector256
            m_InitCheckSum += Vector256s<sbyte>.Demo.AsInt32().GetElement(0);
            m_InitCheckSum += Vector256s<byte>.Demo.AsInt32().GetElement(0);
            m_InitCheckSum += Vector256s<short>.Demo.AsInt32().GetElement(0);
            m_InitCheckSum += Vector256s<ushort>.Demo.AsInt32().GetElement(0);
            m_InitCheckSum += Vector256s<int>.Demo.AsInt32().GetElement(0);
            m_InitCheckSum += Vector256s<uint>.Demo.AsInt32().GetElement(0);
            m_InitCheckSum += Vector256s<long>.Demo.AsInt32().GetElement(0);
            m_InitCheckSum += Vector256s<ulong>.Demo.AsInt32().GetElement(0);
            m_InitCheckSum += Vector256s<float>.Demo.AsInt32().GetElement(0);
            m_InitCheckSum += Vector256s<double>.Demo.AsInt32().GetElement(0);
            m_InitCheckSum += Vector256Constants.Shuffle_UInt16_Multiplier.AsInt32().GetElement(0);

#endif // NETCOREAPP3_0_OR_GREATER

        }
    }

}
