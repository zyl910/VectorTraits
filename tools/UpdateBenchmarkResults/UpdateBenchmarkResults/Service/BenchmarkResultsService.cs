using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdateBenchmarkResults.Common;
using UpdateBenchmarkResults.Model;

namespace UpdateBenchmarkResults.Service {
    /// <summary>
    /// Benchmark results service
    /// </summary>
    internal class BenchmarkResultsService {

        /// <summary>
        /// Text writer.
        /// </summary>
        public TextWriter? Writer { get; set; }

        /// <summary>
        /// Source file.
        /// </summary>
        public string SourceFile { get; set; } = string.Empty;

        /// <summary>
        /// The List.
        /// </summary>
        public List<InputFramework> List { get; } = new List<InputFramework>();

        /// <summary>
        /// Parse command line args.
        /// </summary>
        /// <param name="args">Command line args.</param>
        public void ParseCommand(string[] args) {
            //const StringComparison comparisonType = StringComparison.OrdinalIgnoreCase;
            if (null == args) return;
            //int idx = 0;
            foreach (string arg in args) {
                if (string.IsNullOrEmpty(arg)) continue;
                if (arg.StartsWith('-')) {
                    int dst = VectorTextUtil.SplitKeyValueToInt(arg, out string key, 1);
                    bool dstBool = 0 != dst;
                    //if ("-allowFakeBenchmark".Equals(key, comparisonType)) {
                    //    AllowFakeBenchmark = dstBool;
                    //}
                    //if ("-allowFakeBenchmark0".Equals(key, comparisonType)) {
                    //    AllowFakeBenchmark = false;
                    //}
                } else {
                    if (string.IsNullOrEmpty(SourceFile)) {
                        SourceFile = arg;
                    }
                }
            }
        }

        /// <summary>
        /// Run with command line args.
        /// </summary>
        /// <param name="args">Command line args.</param>
        public void RunWithCommand(string[] args) {
            Clear();
            ParseCommand(args);
            Run();
        }

        /// <summary>
        /// Clear.
        /// </summary>
        private void Clear() {
            List.Clear(); ;
        }

        /// <summary>
        /// Run.
        /// </summary>
        public void Run() {
            if (null == Writer) return;
            Writer.WriteLine("SourceFile:\t{0}", SourceFile);
            if (string.IsNullOrEmpty(SourceFile)) {
                Writer.WriteLine("[Error] SourceFile is empty!");
                return;
            }
            Load();
            // Finish.
            Writer.WriteLine("Finish.");
        }

        internal enum LoadPhase {
            /// <summary>Init. 即“####”之前.</summary>
            Init,
            /// <summary>Framework. 已经遇到了“####”，获得了框架名. 尚未遇到“```”.</summary>
            Framework,
            /// <summary>Case begin. 已经遇到了“```”.</summary>
            CaseBegin,
            /// <summary>Case title ok. 已经获得了标题.</summary>
            CaseTitleOk,
            /// <summary>Case end. 已经再次遇到了“```”, 这表示数据已结束, 将遇到空白数据.</summary>
            CaseEnd
        }

        /// <summary>
        /// Load.
        /// </summary>
        private void Load() {
            string FrameworkPrefix = "####";
            string CaseDelimiter = "```";
            InputFramework? inputFramework = null;
            InputCase? inputCase = null;
            LoadPhase phase = LoadPhase.Init;
            string title;
            int lineNo = 1;
            foreach(string line in File.ReadLines(SourceFile)) {
                if (lineNo <= 30) {
                    //Writer.WriteLine("{0}\t{1}", lineNo, line);
                }
                if (null != line) {
                    bool needAppend = false;
                    if (line.StartsWith(FrameworkPrefix)) {
                        if (phase != LoadPhase.CaseBegin) {
                            // Submit old.
                            if (null != inputFramework) {
                                List.Add(inputFramework);
                                inputFramework = null;
                            }
                            // Make new Framework
                            title = line.Substring(FrameworkPrefix.Length + 1).Trim();
                            inputFramework = new InputFramework();
                            inputFramework.Title = title;
                            phase = LoadPhase.Framework;
                        } else {
                            needAppend = true;
                        }
                    } else if (line.StartsWith(CaseDelimiter)) {
                        if (phase == LoadPhase.Framework || phase == LoadPhase.CaseEnd) {
                            phase = LoadPhase.CaseBegin;
                            inputCase = new InputCase();
                        } else if (phase == LoadPhase.CaseBegin || phase == LoadPhase.CaseTitleOk) {
                            phase = LoadPhase.CaseEnd;
                            if (null != inputFramework && null != inputCase && !string.IsNullOrEmpty(inputCase.Title)) {
                                inputFramework.Cases.Add(inputCase.Title, inputCase);
                                inputCase = null;
                            }
                        } else {
                            // Ignore.
                            Debug.WriteLine(string.Format("Invalid text encountered! [{0}] {1}", lineNo, line));
                        }
                    } else {
                        if (phase == LoadPhase.Framework) {
                            if (null != inputFramework) {
                                inputFramework.Header.Add(line);
                            }
                        } else if (phase == LoadPhase.CaseBegin) {
                            if (!string.IsNullOrEmpty(line) && null != inputCase) {
                                if (line.StartsWith('[')) {
                                    int n = line.IndexOf(']');
                                    if (n > 0) {
                                        inputCase.Title = line.Substring(1, n - 2);
                                        phase = LoadPhase.CaseTitleOk;
                                        needAppend = true;
                                    }
                                }
                            }
                        } else if (phase == LoadPhase.CaseTitleOk) {
                            needAppend = true;
                        } else {
                            // Ignore.
                        }
                    }
                    // needAppend.
                    if (needAppend && null != inputCase) {
                        inputCase.Lines.Add(line);
                    }
                }
                // next.
                ++lineNo;
            }
            if (null != inputFramework) {
                List.Add(inputFramework);
                //inputFramework = null;
            }
        }

    }
}
