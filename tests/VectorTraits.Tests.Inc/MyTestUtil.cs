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
        /// <remarks>
        /// <para>For delegate with an out parameter that runs on the .NET8.0 Wasm architecture will encounter an underlying exception that will cause the program to terminate (对于含有out参数的委托, 在 .NET8.0 Wasm架构上运行时, 会遇到底层异常, 导致程序被终止).</para>
        /// <para>Chrome Browser Logs:</para>
        /// <code>
        /// dotnet.native.8.0.7.37dkch2d2y.js:8 Uncaught RuntimeError: memory access out of bounds
        /// $func8339	@	dotnet.native.wasm:0x1f9a0d
        /// $func238	@	dotnet.native.wasm:0x16596
        /// $func272	@	dotnet.native.wasm:0x1d1bd
        /// $func3185	@	dotnet.native.wasm:0xe8756
        /// $func2505	@	dotnet.native.wasm:0xbe4ac
        /// $func2504	@	dotnet.native.wasm:0xbe43c
        /// $func1874	@	dotnet.native.wasm:0x9a502
        /// $func349	@	dotnet.native.wasm:0x1fb7f
        /// $func245	@	dotnet.native.wasm:0x1bf9f
        /// $func238	@	dotnet.native.wasm:0xf16c
        /// $func306	@	dotnet.native.wasm:0x1e7f1
        /// $func327	@	dotnet.native.wasm:0x1efe7
        /// $func216	@	dotnet.native.wasm:0xcfa8
        /// $mono_wasm_execute_timer	@	dotnet.native.wasm:0x101555
        /// ...
        /// </code>
        /// <para>Firefox Browser Logs:</para>
        /// <code>
        /// Uncaught RuntimeError: index out of bounds
        ///     r cwraps.ts:338
        ///     mono_wasm_schedule_timer_tick scheduling.ts:75
        ///     callUserCallback dotnet.native.8.0.7.37dkch2d2y.js:8
        ///     createDotnetRuntime dotnet.native.8.0.7.37dkch2d2y.js:8
        ///     setTimeout handler*safeSetTimeout dotnet.native.8.0.7.37dkch2d2y.js:8
        ///     Tl scheduling.ts:66
        ///     _mono_wasm_invoke_method_bound dotnet.native.8.0.7.37dkch2d2y.js:8
        ///     kr invoke-cs.ts:273
        ///     U invoke-cs.ts:184
        ///     endInvokeJSFromDotNet blazor.webassembly.js:1
        ///     beginInvokeJSFromDotNet blazor.webassembly.js:1
        ///     promise callback*beginInvokeJSFromDotNet blazor.webassembly.js:1
        /// ...
        /// </code>
        /// </remarks>
        public static bool AllowDelegateOut {
            get {
                if (ProcessIsWasm) {
                    Version ver = Environment.Version;
                    if (ver.Major < 9) {
                        return false;
                    }
                }
                return true;
            }
        }

        /// <summary>
        /// Whether to allow delegates with multiple parameters (是否允许含有多个参数的委托).
        /// </summary>
        /// <remarks>
        /// <para>For delegate with multiple parameters, when running on the .NET8.0 Wasm architecture, sometimes the wrong parameters are passed, resulting in incorrect results (对于含有多个参数的委托, 在 .NET8.0 Wasm架构上运行时, 有时传递错误的参数, 导致运算结果不对).</para>
        /// <para>Logs of YGroup2UnzipEvenTest{Int64}:</para>
        /// <code>
        /// f({0, 1}, {1, 0}): {0, 1}	# (0000000000000000 0000000000000001), (0000000000000001 0000000000000000), (0000000000000000 0000000000000001)
        /// VectorTraitsBase.YGroup2UnzipEven_Basic-0({0, 1}, {1, 0})	# (0000000000000000 0000000000000001), (0000000000000001 0000000000000000)
        /// VectorTraitsBase.YGroup2UnzipEven_Basic({0, 1}, {1, 0}): {0, 1}	# (0000000000000000 0000000000000001), (0000000000000001 0000000000000000), (0000000000000000 0000000000000001)
        /// WVectorTraits128Base.YGroup2UnzipEven_Basic({0, 1}, {1, 0}): {0, 1}	# (0000000000000000 0000000000000001), (0000000000000001 0000000000000000), (0000000000000000 0000000000000001)
        /// VectorTraitsBase+Statics.YGroup2UnzipEven_Basic({0, 1}, {1, 0})-0	# (0000000000000000 0000000000000001), (0000000000000001 0000000000000000)
        /// VectorTraitsBase.YGroup2UnzipEven_Basic-0({43110072, 0}, {1, 1})	# (000000000291CEB8 0000000000000000), (0000000000000001 0000000000000001)
        /// VectorTraitsBase.YGroup2UnzipEven_Basic({43110072, 0}, {1, 1}): {43110072, 1}	# (000000000291CEB8 0000000000000000), (0000000000000001 0000000000000001), (000000000291CEB8 0000000000000001)
        /// VectorTraitsBase+Statics.YGroup2UnzipEven_Basic({0, 1}, {1, 0})-1: {43110072, 1}	# (0000000000000000 0000000000000001), (0000000000000001 0000000000000000), (000000000291CEB8 0000000000000001)
        /// 
        /// 9) Failed : Zyl.VectorTraits.Tests.Impl.IVectorTraitsTest.VectorTests_YG.YGroup2UnzipEvenTest{Int64}(9L)
        ///   {0, 1} != {43110072, 1}. VectorTraitsBase+Statics.YGroup2UnzipEven_Basic: {0, 1}, {1, 0}	# (0000000000000000 0000000000000001), (000000000291CEB8 0000000000000001), (0000000000000000 0000000000000001), (0000000000000001 0000000000000000)
        /// Assert.That(condition, Is.True)
        /// </code>
        /// </remarks>
        public static bool AllowDelegateMultiParam {
            get {
                if (ProcessIsWasm) {
                    Version ver = Environment.Version;
                    if (ver.Major < 9) {
                        return false;
                    }
                }
                return true;
            }
        }

    }

}
