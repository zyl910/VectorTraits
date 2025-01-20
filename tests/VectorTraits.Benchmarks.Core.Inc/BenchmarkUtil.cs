using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Zyl.VectorTraits.Impl;
using static System.Collections.Specialized.BitVector32;

namespace Zyl.VectorTraits.Benchmarks {
#nullable enable

    /// <summary>
    /// Benchmark util.
    /// </summary>
    internal static class BenchmarkUtil {
        /// <summary>Indent next separator (增加缩进的分隔符).</summary>
        public static readonly string IndentNextSeparator = VectorTextUtil.IndentNextSeparator;


        /// <summary>Is last run (最后一次运行).</summary>
        [ThreadStatic]
        private static bool m_IsLastRun;

        /// <summary>Current <see cref="IBenchmarkWriter"/>.</summary>
        public static IBenchmarkWriter CurrentBenchmarkWriter { get; set; }
        /// <summary>Is last run (最后一次运行).</summary>
        public static bool IsLastRun { get => m_IsLastRun; }
        /// <summary>Is use <see cref="FakeBenchmarkAttribute"/> (是否使用<see cref="FakeBenchmarkAttribute"/>).</summary>
        public static bool AllowFakeBenchmark { get; set; } = false;

        static BenchmarkUtil() {
            CurrentBenchmarkWriter = new TabBenchmarkWriter();
        }

        /// <summary>
        /// Output Environment.
        /// </summary>
        /// <param name="writer">Output <see cref="TextWriter"/>.</param>
        /// <param name="indent">The indent.</param>
        public static void OutputEnvironment(TextWriter writer, string? indent = null) {
            TraitsOutput.OutputEnvironment(writer, indent);
            writer.WriteLine(indent + string.Format("Vectors.BaseInstance:\t{0}", Vectors.BaseInstance.GetType().Name));
        }

        /// <summary>
        /// Parse command line args.
        /// </summary>
        /// <param name="args">Command line args.</param>
        public static void ParseCommand(string[] args) {
            const StringComparison comparisonType = StringComparison.OrdinalIgnoreCase;
            if (null == args) return;
            foreach (string arg in args) {
                int dst = VectorTextUtil.SplitKeyValueToInt(arg, out string key, 1);
                bool dstBool = 0 != dst;
                if ("-allowFakeBenchmark".Equals(key, comparisonType)) {
                    AllowFakeBenchmark = dstBool;
                }
                if ("-allowFakeBenchmark0".Equals(key, comparisonType)) {
                    AllowFakeBenchmark = false;
                }
            }
        }

        /// <summary>
        /// Run action test.
        /// </summary>
        /// <param name="writer">Output <see cref="IBenchmarkWriter"/>.</param>
        /// <param name="name">Test name.</param>
        /// <param name="action">Test action</param>
        /// <param name="srcCount">Source count within an <paramref name="action"/>.</param>
        /// <param name="mopsBaseline">Baseline's MOPS</param>
        /// <returns>Returns MOPS(Million operations per second).</returns>
        public static double RunTest(IBenchmarkWriter writer, string name, Action action, int srcCount, double mopsBaseline, ILoopCountGetter? loopCountGetter = null) {
            double us;
            int loopCount = loopCountGetter?.LoopCount ?? 0;
            double rt = RunTestCore(action, srcCount, mopsBaseline, out us, loopCount);
            if (mopsBaseline>0) {
                double scale = rt / mopsBaseline;
                writer.WriteItemBenchmark(name, us, rt, scale);
            } else {
                writer.WriteItemBenchmark(name, us, rt);
            }
            return rt;
        }

        /// <summary>
        /// Run action test core.
        /// </summary>
        /// <param name="action">The action.</param>
        /// <param name="srcCount">Source count within an <paramref name="action"/>.</param>
        /// <param name="mopsBaseline">Baseline's MOPS</param>
        /// <param name="us">Run time ms.</param>
        /// <returns>Returns MOPS(Million operations per second).</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "<Pending>")]
        public static double RunTestCore(Action action, int srcCount, double mopsBaseline, out double us, int loopCount = 0) {
            double rt;
            const int aMillion = 1000 * 1000;
            const int usPerSecond = 1000 * 1000;
            long tickPerSecond = Stopwatch.Frequency;
            double tickPerUs = tickPerSecond / (double)usPerSecond;
            long tickMax = tickPerSecond / 8;
            const int RepeatCount = 10;
            const int RepeatCountUsed = 6;
            Stopwatch stopwatch = new Stopwatch();
            //int tickBegin;
            long tickUsed;
            int loops = 1;
            int i, j;
            if (loopCount <= 0) loopCount = 1;
            m_IsLastRun = false;
            // Find best loops.
            for (; ; ) {
                stopwatch.Restart();
                for (i = 0; i < loops; ++i) {
                    action();
                }
                stopwatch.Stop();
                tickUsed = stopwatch.ElapsedTicks;
                // Check.
                int loopsNext = loops * 2;
                bool flag = (tickUsed >= tickMax || loopsNext < loops);
                if (flag) {
                    break;
                }
                loops = loopsNext;
            }
            // Repeat.
            long tickSum = 0;
            long[] tickArray = new long[RepeatCount];
            //Span<long> tickArray = stackalloc long[RepeatCount];
            for (j = 0; j < RepeatCount; ++j) {
                stopwatch.Restart();
                bool isLast = ((j + 1) == RepeatCount);
                int loopsCount = loops;
                if (isLast) {
                    --loopsCount;
                }
                for (i = 0; i < loopsCount; ++i) {
                    action();
                }
                if (isLast) {
                    m_IsLastRun = true;
                    action();
                }
                stopwatch.Stop();
                tickUsed = stopwatch.ElapsedTicks;
                tickArray[j] = tickUsed;
            }
            m_IsLastRun = false;
            // done.
            //tickArray.Sort();
            Array.Sort(tickArray);
            int jStart = (RepeatCount - RepeatCountUsed) / 2;
            for (j = 0; j < RepeatCountUsed; ++j) {
                tickSum += tickArray[jStart + j];
            }
            us = tickSum / (tickPerUs * RepeatCountUsed * loops);
            rt = (double)srcCount * loopCount * usPerSecond / us / aMillion;
            return rt;
        }

        /// <summary>
        /// Check method is use on benchmark.
        /// </summary>
        /// <param name="mi">The method info.</param>
        /// <returns>Return true if use on benchmark.</returns>
        public static bool CheckMethodInfoOnBenchmark(MethodInfo mi) {
            if (mi.ContainsGenericParameters) return false;
            if (mi.IsStatic) return false;
            if (mi.IsAbstract) return false;
            if (mi.GetParameters().Length != 0) return false;
            BenchmarkAttribute? attr = mi.GetCustomAttribute<BenchmarkAttribute>();
            bool isAdd = false;
            if (null != attr) isAdd = true;
            if (!isAdd && AllowFakeBenchmark) {
                FakeBenchmarkAttribute? attr2 = mi.GetCustomAttribute<FakeBenchmarkAttribute>();
                if (null != attr2) isAdd = true;
            }
            return isAdd;
        }

        /// <summary>
        /// Fill <see cref="MethodInfo"/> of benchmark .
        /// </summary>
        /// <typeparam name="T">The benchmark class.</typeparam>
        /// <param name="dst">Destination list</param>
        /// <param name="src">Source object.</param>
        public static void FillMethodInfoOfBenchmark<T>(ICollection<MethodInfo> dst, T src) where T : class {
            WrappedType? srcType = WrappedTypePool.Shared.Find(src.GetType());
            if (null == srcType) return;
            foreach (MethodInfo mi in srcType.Type.GetMethods()) {
                bool isAdd = CheckMethodInfoOnBenchmark(mi);
                // ok.
                if (isAdd) {
                    dst.Add(mi);
                }
            }
        }

        /// <summary>
        /// Is exist benchmark method.
        /// </summary>
        /// <param name="typ">The type.</param>
        /// <returns>Return true if exist benchmark method.</returns>
        public static bool ExistBenchmarkMethod(
#if NET5_0_OR_GREATER
                [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)]
#endif // NET5_0_OR_GREATER
                Type typ) {
            foreach (MethodInfo mi in typ.GetMethods()) {
                bool isAdd = CheckMethodInfoOnBenchmark(mi);
                if (isAdd) {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Writes a string to the text stream, followed by a line terminator.
        /// </summary>
        /// <param name="value">The string to write. If value is null, only the line terminator is written.</param>
        public static void WriteLine(string? value) {
            CurrentBenchmarkWriter.WriteLine(value);
        }

        /// <summary>
        /// Write item text to the text stream (将条目文本输出到流).
        /// </summary>
        /// <param name="name">Item name (条目名).</param>
        /// <param name="text">The text (文本).</param>
        public static void WriteItem(string name, string text) {
            CurrentBenchmarkWriter.WriteItem(name, text);
        }

        /// <summary>
        /// CheckAllBenchmark - default onafter.
        /// </summary>
        /// <param name="mi">The MethodInfo.</param>
        /// <param name="ex">The Exception. null is no exception.</param>
        public static void CheckAllBenchmark_Default(MethodInfo mi, Exception? ex) {
            string msg = "";
            string name = mi.Name;
            if (null == ex) {
                // Succeed. No output.
                //msg = "Succeed";
            } else {
                Debug.WriteLine(ex);
                //bool useFull = ex is not NotSupportedException;
                bool useFull = false;
                if (useFull) {
                    msg = string.Format("Fail! {0}", ex.ToString());
                } else {
                    msg = string.Format("Fail! {0}", ex.Message);
                }
                bool ignoreException = ex is NotSupportedException;
                if (ignoreException) return;
            }
            if (string.IsNullOrEmpty(msg)) return;
            if (null == CurrentBenchmarkWriter) return;
            string itemname = string.Format("Check-{0}", name);
            CurrentBenchmarkWriter.WriteItem(itemname, msg);
        }

        /// <summary>
        /// Check all Benchmark.
        /// </summary>
        /// <typeparam name="T">The benchmark class.</typeparam>
        /// <param name="src">Source object.</param>
        public static void CheckAllBenchmark<
#if NET5_0_OR_GREATER
                [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)]
#endif // NET5_0_OR_GREATER
                T>(T src, Action<MethodInfo, Exception?>? onafter = null) where T : AbstractBenchmark {
            if (null == onafter) onafter = CheckAllBenchmark_Default;
            bool oldCheckMode = src.CheckMode;
            src.CheckMode = true;
            try {
                List<MethodInfo> lst = new List<MethodInfo>();
                FillMethodInfoOfBenchmark(lst, src);
                if (lst.Count <= 0) return;
                foreach (MethodInfo mi in lst) {
                    string name = mi.Name;
                    Exception? ex1 = null;
                    try {
                        Action action = (Action)mi.CreateDelegate(typeof(Action), src);
                        //Action action = (Action)Delegate.CreateDelegate(typeof(Action), obj, mi);
                        action();
                    } catch (Exception ex) {
                        //writer.WriteLine(indent + string.Format("{0}:\tRun fail! {1}", name, ex.Message));
                        //Debug.WriteLine(string.Format("{0}:\tRun fail! {1}", name, ex.ToString()));
                        ex1 = ex;
                    }
                    onafter?.Invoke(mi, ex1);
                }
            } finally {
                src.CheckMode = oldCheckMode;
            }
        }


        /// <summary>
        /// Run benchmark object
        /// </summary>
        /// <param name="writer">Output <see cref="IBenchmarkWriter"/>.</param>
        /// <param name="indent">The indent.</param>
        /// <param name="typ">The type.</param>
        /// <param name="obj">The object.</param>
        public static void RunBenchmarkObject(IBenchmarkWriter writer,
#if NET5_0_OR_GREATER
                [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)]
#endif // NET5_0_OR_GREATER
                Type typ, AbstractBenchmark? obj) {
            if (null == obj) return;
            ILoopCountGetter? loopCountGetter = obj as ILoopCountGetter;
            List<MethodInfo> lst = new List<MethodInfo>();
            FillMethodInfoOfBenchmark(lst, obj);
            if (lst.Count <= 0) return;
            foreach (int n in AbstractBenchmark.ValuesForN) {
                double mopsBaseline = 0.0;
                writer.WriteLine();
                writer.WriteTitle(string.Format("{0}({1})", typ.Name, n));
                // GlobalSetup.
                obj.N = n;
                obj.GlobalSetup();
                // Tests.
                foreach (MethodInfo mi in lst) {
                    string name = mi.Name;
                    try {
                        Action action = (Action)mi.CreateDelegate(typeof(Action), obj);
                        //Action action = (Action)Delegate.CreateDelegate(typeof(Action), obj, mi);
                        double mops = BenchmarkUtil.RunTest(writer, name, action, n, mopsBaseline, loopCountGetter);
                        bool isBaseline = false;
                        BenchmarkAttribute? attr = mi.GetCustomAttribute<BenchmarkAttribute>();
                        if (null!= attr) {
                            isBaseline = attr.Baseline;
                        }
                        bool mopsFlag = (0 == mopsBaseline || isBaseline) && mops > 0;
                        if (mopsFlag) {
                            mopsBaseline = mops;
                        }
                        // break; // [Debug] Only test one.
                    } catch (Exception ex) {
                        writer.WriteItem(name, string.Format("Run fail! {0}", ex.Message));
                    }
                }
            }
        }

        /// <summary>
        /// Run benchmark object - Async
        /// </summary>
        /// <param name="writer">Output <see cref="IBenchmarkWriter"/>.</param>
        /// <param name="indent">The indent.</param>
        /// <param name="typ">The type.</param>
        /// <param name="obj">The object.</param>
        /// <param name="onBefore">The action on before call item. Prototype: <c>Task onBefore(double percentage, string title)</c>.</param>
        /// <param name="percentageCurrent">Percentage of current.</param>
        /// <param name="percentageWeight">Percentage weight.</param>
        /// <returns>Returns async task.</returns>
        public static async Task RunBenchmarkObjectAsync(IBenchmarkWriter writer,
#if NET5_0_OR_GREATER
                [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)]
#endif // NET5_0_OR_GREATER
                Type typ, AbstractBenchmark? obj, Func<double, string, Task>? onBefore = null, double percentageCurrent=0.0, double percentageWeight=1.0) {
            if (null == obj) return;
            ILoopCountGetter? loopCountGetter = obj as ILoopCountGetter;
            List<MethodInfo> lst = new List<MethodInfo>();
            FillMethodInfoOfBenchmark(lst, obj);
            if (lst.Count <= 0) return;
            string typeName = typ.Name;
            double total = lst.Count;
            int[] valueList = AbstractBenchmark.ValuesForN.ToArray();
            double percentageWeight2 = percentageWeight * 1.0 / valueList.Length;
            int j = 0;
            foreach (int n in valueList) {
                double percentageCurrent2 = percentageCurrent + percentageWeight * j / valueList.Length;
                double mopsBaseline = 0.0;
                writer.WriteLine();
                writer.WriteTitle(string.Format("{0}({1})", typeName, n));
                // GlobalSetup.
                obj.N = n;
                obj.GlobalSetup();
                // Tests.
                int i = 0;
                foreach (MethodInfo mi in lst) {
                    string name = mi.Name;
                    try {
                        if (null != onBefore) {
                            double percentage = percentageCurrent2 + percentageWeight2 * i / total;
                            string title;
                            if (j <= 0) {
                                title = string.Format("{0}.{1}", typeName, name);
                            } else {
                                title = string.Format("{0}.{1}[{2}]", typeName, name, j);
                            }
                            await onBefore(percentage, title);
                        }
                        Action action = (Action)mi.CreateDelegate(typeof(Action), obj);
                        //Action action = (Action)Delegate.CreateDelegate(typeof(Action), obj, mi);
                        double mops = BenchmarkUtil.RunTest(writer, name, action, n, mopsBaseline, loopCountGetter);
                        bool isBaseline = false;
                        BenchmarkAttribute? attr = mi.GetCustomAttribute<BenchmarkAttribute>();
                        if (null != attr) {
                            isBaseline = attr.Baseline;
                        }
                        bool mopsFlag = (0 == mopsBaseline || isBaseline) && mops > 0;
                        if (mopsFlag) {
                            mopsBaseline = mops;
                        }
                        //break; // [Debug] Only test one.
                    } catch (Exception ex) {
                        writer.WriteItem(name, string.Format("Run fail! {0}", ex.Message));
                    }
                    ++i;
                }
                ++j;
            }
        }

        /// <summary>
        /// Fill Benchmark Types to list (将基准测试类型填充到列表).
        /// </summary>
        /// <typeparam name="TList">Type of list (列表的类型).</typeparam>
        /// <param name="list">Destination list (目标列表).</param>
        /// <param name="assembly">The assembly. When running in AOT mode, the list will be retrieved from WrappedTypePool instead (程序集. 当AOT方式运行时，会自动改为从 WrappedTypePool 获取列表).</param>
        /// <returns>Return the number of items added (返回已添加的项数).</returns>
#if NET5_0_OR_GREATER
        [UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "Use 'FillBenchmarkTypes_Pool' instead")]
#endif // NET5_0_OR_GREATER
        private static int FillBenchmarkTypes<TList>(TList list, Assembly assembly) where TList: ICollection<WrappedType> {
            return FillBenchmarkTypes_Pool(list, assembly); // In order to make the results of JIT and AOT consistent, it is always used (为了使JIT与AOT的运行结果一致, 故总是使用它).
#if NETCOREAPP3_0_OR_GREATER
            //if (!RuntimeFeature.IsDynamicCodeSupported) {
            //    return FillBenchmarkTypes_Pool(list, assembly);
            //}
#endif // NETCOREAPP3_0_OR_GREATER
            //return FillBenchmarkTypes_Reflection(list, assembly);
        }

        /// <inheritdoc cref="FillBenchmarkTypes"/>
        private static int FillBenchmarkTypes_Pool<TList>(TList list, Assembly assembly) where TList : ICollection<WrappedType> {
            int rt = 0;
            Type baseType = typeof(AbstractBenchmark);
            foreach(KeyValuePair<Type, WrappedType> p in WrappedTypePool.Shared.List) {
                var typ = p.Value.Type;
                if (typ.ContainsGenericParameters) continue;
                if (typ.IsAbstract) continue;
                if (!typ.IsSubclassOf(baseType)) continue;
                if (!assembly.Equals(typ.Assembly)) continue;
                if (!ExistBenchmarkMethod(p.Value.Type)) continue;
                list.Add(p.Value);
                ++rt;
            }
            return rt;
        }

        /// <inheritdoc cref="FillBenchmarkTypes"/>
#if NET5_0_OR_GREATER
        [RequiresUnreferencedCode("Calls System.Reflection.Assembly.GetTypes()")]
#endif // NET5_0_OR_GREATER
        private static int FillBenchmarkTypes_Reflection<TList>(TList list, Assembly assembly) where TList : ICollection<WrappedType> {
            int rt = 0;
            Type baseType = typeof(AbstractBenchmark);
            foreach (Type typ in assembly.GetTypes()) {
                if (typ.ContainsGenericParameters) continue;
                if (typ.IsAbstract) continue;
                if (!typ.IsSubclassOf(baseType)) continue;
                if (!ExistBenchmarkMethod(typ)) continue;
                list.Add(typ);
                ++rt;
            }
            return rt;
        }

        /// <summary>
        /// Comparison on <see cref="Type"/>.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>Return compare result.</returns>
        private static int ComparisonOnType(Type? x, Type? y) {
            int rt = string.CompareOrdinal(x?.Name, y?.Name);
            if (0 == rt) rt = string.CompareOrdinal(x?.FullName, y?.FullName);
            return rt;
        }

        /// <summary>
        /// Comparison on <see cref="Type"/>.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>Return compare result.</returns>
        private static int ComparisonOnType(WrappedType? x, WrappedType? y) {
            if (x==y) return 0;
            return ComparisonOnType(x?.Type, y?.Type);
        }

        private static List<WrappedType> GetBenchmarkTypesAndSort(Assembly assembly) {
            List<WrappedType> lst = new List<WrappedType>();
            FillBenchmarkTypes(lst, assembly);
            // Sort.
            lst.Sort(ComparisonOnType);
            return lst;
        }

        /// <summary>
        /// Run benchmark.
        /// </summary>
        /// <param name="writer">Output <see cref="IBenchmarkWriter"/>.</param>
        /// <param name="assembly">The assembly. When running in AOT mode, the list will be retrieved from WrappedTypePool instead (程序集. 当AOT方式运行时，会自动改为从 WrappedTypePool 获取列表).</param>
        /// <param name="onBefore">The action on before call item. Prototype: <c>void onBefore(double percentage, string title)</c>.</param>
        public static void RunBenchmark(IBenchmarkWriter writer, Assembly assembly, Action<double, string>? onBefore = null) {
            List<WrappedType>  lst = GetBenchmarkTypesAndSort(assembly);
            if (lst.Count <= 0) return;
            double total = lst.Count;
            // Run.
            int i = 0;
            foreach (WrappedType p in lst) {
                Type typ = p.Type;
                try {
                    double percentage = 100.0 * i / total;
                    string title = typ.Name;
                    onBefore?.Invoke(percentage, title);
                    AbstractBenchmark? obj = Activator.CreateInstance(typ) as AbstractBenchmark;
                    RunBenchmarkObject(writer, typ, obj);
                } catch (Exception ex) {
                    writer.WriteLine(string.Format("Run `{0} fail! {1}`", typ.FullName, ex.Message));
                }
                ++i;
            }
        }

        /// <summary>
        /// Run benchmark - Async.
        /// </summary>
        /// <param name="writer">Output <see cref="IBenchmarkWriter"/>.</param>
        /// <param name="assembly">The assembly. When running in AOT mode, the list will be retrieved from WrappedTypePool instead (程序集. 当AOT方式运行时，会自动改为从 WrappedTypePool 获取列表).</param>
        /// <param name="onBefore">The action on before call item. Prototype: <c>Task onBefore(double percentage, string title)</c>.</param>
        public static async Task RunBenchmarkAsync(IBenchmarkWriter writer, Assembly assembly, Func<double, string, Task>? onBefore = null) {
            List<WrappedType> lst = GetBenchmarkTypesAndSort(assembly);
            if (lst.Count <= 0) return;
            double total = lst.Count;
            double percentageWeight = 100.0 * 1 / total;
            // Run.
            int i = 0;
            foreach (WrappedType p in lst) {
                Type typ = p.Type;
                try {
                    double percentage = 100.0 * i / total;
                    string title = typ.Name;
                    if (null != onBefore) {
                        await onBefore(percentage, title);
                    }
                    AbstractBenchmark? obj = Activator.CreateInstance(typ) as AbstractBenchmark;
                    await RunBenchmarkObjectAsync(writer, typ, obj, onBefore, percentage, percentageWeight);
                } catch (Exception ex) {
                    writer.WriteLine(string.Format("Run `{0} fail! {1}`", typ.FullName, ex.Message));
                }
                ++i;
            }
        }

    }

#nullable restore
}
