using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Zyl.VectorTraits.Tests {

    /// <summary>
    /// My test util.
    /// </summary>
    internal static class MyTestUtil {

        /// <inheritdoc cref="Array.Empty"/>
        public static T[] Empty<T>() {
#if NET5_0_OR_GREATER
            return Array.Empty<T>();
#else
            return new T[0];
#endif
        }

        /// <summary>
        /// Gets a value that indicates whether the current process architecture is a Wasm (获取一个值，该值指示当前进程架构是否为 Wasm 的).
        /// </summary>
        public static bool ProcessIsWasm {
            get {
#if NET5_0_OR_GREATER
                return RuntimeInformation.ProcessArchitecture == Architecture.Wasm;
#else
                return false;
#endif
            }
        }

        /// <summary>
        /// Whether to allow delegates with an out parameter (是否允许含有out参数的委托).
        /// </summary>
        public static bool AllowDelegateOut => !ProcessIsWasm;

    }

}
