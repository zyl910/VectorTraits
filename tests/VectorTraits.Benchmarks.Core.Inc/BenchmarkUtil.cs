using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Numerics;
using System.Reflection;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Zyl.VectorTraits.Benchmarks {
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
        /// Fill <see cref="MethodInfo"/> of benchmark .
        /// </summary>
        /// <typeparam name="T">The benchmark class.</typeparam>
        /// <param name="dst">Destination list</param>
        /// <param name="src">Source object.</param>
        public static void FillMethodInfoOfBenchmark<T>(ICollection<MethodInfo> dst, T src) where T : class {
            foreach (MethodInfo mi in src.GetType().GetMethods()) {
                if (mi.ContainsGenericParameters) continue;
                if (mi.IsStatic) continue;
                if (mi.IsAbstract) continue;
                if (mi.GetParameters().Length != 0) continue;
                BenchmarkAttribute? attr = mi.GetCustomAttribute<BenchmarkAttribute>();
                bool isAdd = false;
                if (null != attr) isAdd = true;
                if (!isAdd && AllowFakeBenchmark) {
                    FakeBenchmarkAttribute? attr2 = mi.GetCustomAttribute<FakeBenchmarkAttribute>();
                    if (null != attr2) isAdd = true;
                }
                // ok.
                if (isAdd) {
                    dst.Add(mi);
                }
            }
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
        public static void CheckAllBenchmark<T>(T src, Action<MethodInfo, Exception?>? onafter = null) where T : AbstractBenchmark {
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
        public static void RunBenchmarkObject(IBenchmarkWriter writer, Type typ, AbstractBenchmark? obj) {
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
                        break; // [Debug] Only test one.
                    } catch (Exception ex) {
                        writer.WriteItem(name, string.Format("Run fail! {0}", ex.Message));
                    }
                }
            }
        }

        /// <summary>
        /// Comparison on <see cref="Type"/>.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns>Return compare result.</returns>
        private static int ComparisonOnType(Type x, Type y) {
            int rt = string.CompareOrdinal(x?.Name, y?.Name);
            if (0 == rt) rt = string.CompareOrdinal(x?.FullName, y?.FullName);
            return rt;
        }

        /// <summary>
        /// Run benchmark.
        /// </summary>
        /// <param name="writer">Output <see cref="IBenchmarkWriter"/>.</param>
        /// <param name="assembly">The assembly.</param>
        /// <param name="onBefore">The action on before call item. Prototype: <c>(IReadOnlyList&lt;Type&gt; list, int index)</c>.</param>
        public static void RunBenchmark(IBenchmarkWriter writer, Assembly assembly, Action<IReadOnlyList<Type>, int>? onBefore = null) {
            Type baseType = typeof(AbstractBenchmark);
            List<Type> lst = new List<Type>();
            foreach (Type typ in assembly.GetTypes()) {
                if (typ.ContainsGenericParameters) continue;
                if (typ.IsAbstract) continue;
                if (!typ.IsSubclassOf(baseType)) continue;
                lst.Add(typ);
            }
            // Sort and run.
            lst.Sort(ComparisonOnType);
            int i = 0;
            foreach (Type typ in lst) {
                try {
                    onBefore?.Invoke(lst, i);
                    AbstractBenchmark? obj = Activator.CreateInstance(typ) as AbstractBenchmark;
                    RunBenchmarkObject(writer, typ, obj);
                } catch (Exception ex) {
                    writer.WriteLine(string.Format("Run `{0} fail! {1}`", typ.FullName, ex.Message));
                }
                ++i;
            }
        }

        /// <summary>
        /// Run benchmark.
        /// </summary>
        /// <param name="writer">Output <see cref="IBenchmarkWriter"/>.</param>
        /// <param name="assembly">The assembly.</param>
        /// <param name="onBefore">The action on before call item. Prototype: <c>Task onBefore(double percentage, string title)</c>.</param>
        public static async Task RunBenchmarkAsync(IBenchmarkWriter writer, Assembly assembly, Func<double, string, Task>? onBefore = null) {
            Type baseType = typeof(AbstractBenchmark);
            List<Type> lst = new List<Type>();
            foreach (Type typ in assembly.GetTypes()) {
                if (typ.ContainsGenericParameters) continue;
                if (typ.IsAbstract) continue;
                if (!typ.IsSubclassOf(baseType)) continue;
                lst.Add(typ);
            }
            if (lst.Count <= 0) return;
            double total = lst.Count;
            // Sort and run.
            lst.Sort(ComparisonOnType);
            int i = 0;
            foreach (Type typ in lst) {
                try {
                    double percentage = i / total;
                    string title = typ.Name;
                    if (null != onBefore) {
                        await onBefore(percentage, title);
                    }
                    AbstractBenchmark? obj = Activator.CreateInstance(typ) as AbstractBenchmark;
                    RunBenchmarkObject(writer, typ, obj);
                } catch (Exception ex) {
                    writer.WriteLine(string.Format("Run `{0} fail! {1}`", typ.FullName, ex.Message));
                }
                ++i;
            }
        }

    }
}
