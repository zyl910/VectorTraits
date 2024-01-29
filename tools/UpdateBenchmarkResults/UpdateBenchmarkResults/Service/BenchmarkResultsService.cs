using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
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
            /// <summary>Init. 即“####”之前的非代码区域.</summary>
            Init,
            /// <summary>Other code. 即“####”之前的代码区域.</summary>
            OtherCode,
            /// <summary>Framework. 已经遇到了“####”，非代码区域.</summary>
            Framework,
            /// <summary>Framework code. 已经遇到了“####”，尚未遇到case.</summary>
            FrameworkCode,
            /// <summary>Framework Case. 已经遇到了 case, 这表示 header区域结束 .</summary>
            FrameworkCase
        }

        /// <summary>
        /// Load.
        /// </summary>
        private void Load() {
            LoadParse();
            LoadDone();
        }

        /// <summary>
        /// Load parse. parse file.
        /// </summary>
        private void LoadParse() {
            string FrameworkPrefix = "####";
            string CodeDelimiter = "```";
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
                    bool needNewFramework = false;
                    bool needAppend = false;
                    switch(phase) {
                        case LoadPhase.Init:
                            if (line.StartsWith(FrameworkPrefix)) {
                                phase = LoadPhase.Framework;
                                needNewFramework = true;
                            } else if (line.StartsWith(CodeDelimiter)) {
                                phase = LoadPhase.OtherCode;
                            } else {
                                // Ignore.
                            }
                            break;
                        case LoadPhase.OtherCode:
                            if (line.StartsWith(CodeDelimiter)) {
                                phase = LoadPhase.Init;
                            } else {
                                // Ignore.
                            }
                            break;
                        case LoadPhase.Framework:
                            if (line.StartsWith(FrameworkPrefix)) {
                                phase = LoadPhase.Framework;
                                needNewFramework = true;
                            } else if (line.StartsWith(CodeDelimiter)) {
                                phase = LoadPhase.FrameworkCode;
                            } else {
                                // Ignore.
                            }
                            break;
                        default: // FrameworkCode or others.
                            if (line.StartsWith(CodeDelimiter)) {
                                phase = LoadPhase.Framework;
                            } else {
                                if (line.Length > 0) {
                                    if (line.StartsWith('[')) {
                                        int n = line.IndexOf(']');
                                        if (n > 0) {
                                            title = line.Substring(1, n - 1);
                                            phase = LoadPhase.FrameworkCase;
                                            SubmitCase();
                                            inputCase = new InputCase();
                                            inputCase.Title = title;
                                        }
                                    }
                                    if (phase != LoadPhase.FrameworkCode) {
                                        needAppend = true;
                                    }
                                } else {
                                    if (null!= inputCase) {
                                        SubmitCase();
                                    }
                                }
                                if (phase == LoadPhase.FrameworkCode) {
                                    inputFramework?.Header.Add(line);
                                }
                            }
                            break;
                    }
                    if (needNewFramework) {
                        // Submit old.
                        if (null != inputFramework) {
                            SubmitCase();
                            List.Add(inputFramework);
                            inputFramework = null;
                        }
                        // Make new Framework
                        title = line.Substring(FrameworkPrefix.Length + 1).Trim();
                        inputFramework = new InputFramework();
                        inputFramework.Title = title;
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

            void SubmitCase() {
                if (null == inputCase) return;
                if (null == inputFramework) return;
                inputFramework.Cases.Add(inputCase.Title, inputCase);
                inputCase = null;
            }
        }

        /// <summary>
        /// Load done - show info.
        /// </summary>
        private void LoadDone() {
            // Show load info.
            foreach (InputFramework item in List) {
                Writer?.WriteLine("- {0}: {1} items.", item.Title, item.Cases.Count);
            }
        }

    }
}
