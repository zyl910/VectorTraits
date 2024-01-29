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
        /// Source file (源文件).
        /// </summary>
        public string SourceFile { get; set; } = string.Empty;

        /// <summary>
        /// Destination folder (目标文件夹).
        /// </summary>
        public string Folder { get; set; } = string.Empty;

        /// <summary>
        /// The List.
        /// </summary>
        public List<InputFramework> List { get; } = new List<InputFramework>();

        /// <summary>
        /// Group counter (组的计数器).
        /// </summary>
        public IDictionary<string, int> GroupCounter { get; set; } = new SortedDictionary<string, int>();

        /// <summary>
        /// Parse command line args.
        /// </summary>
        /// <param name="args">Command line args.</param>
        public void ParseCommand(string[] args) {
            const StringComparison comparisonType = StringComparison.OrdinalIgnoreCase;
            if (null == args) return;
            //int idx = 0;
            foreach (string arg in args) {
                if (string.IsNullOrEmpty(arg)) continue;
                if (arg.StartsWith('-')) {
                    ReadOnlySpan<char> dst = VectorTextUtil.SplitKeyValue(arg, out string key);
                    if ("-folder".Equals(key, comparisonType)) {
                        Folder = dst.ToString();
                    }
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
            List.Clear();
            GroupCounter.Clear();
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
            // Process.
            Process();
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
                                    title = BenchmarkStringUtil.ExtractCaseTitle(line);
                                    if (!string.IsNullOrEmpty(title)) {
                                        phase = LoadPhase.FrameworkCase;
                                        SubmitCase();
                                        inputCase = new InputCase();
                                        inputCase.Title = title;
                                        string baseTitle = BenchmarkStringUtil.GetCaseBaseTitle(title);
                                        inputCase.BaseTitle = baseTitle;
                                        string primaryTitle = BenchmarkStringUtil.GetCasePrimaryTitle(title);
                                        inputCase.PrimaryTitle = primaryTitle;
                                        if (null!= inputFramework) {
                                            int num;
                                            if (!inputFramework.GroupCounter.TryGetValue(primaryTitle, out num)) {
                                                num = 0;
                                            }
                                            inputFramework.GroupCounter[primaryTitle] = num + 1;
                                            // Group.
                                            if (!GroupCounter.TryGetValue(primaryTitle, out num)) {
                                                num = 0;
                                            }
                                            GroupCounter[primaryTitle] = num + 1;
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
                            SubmitFramework();
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

            void SubmitFramework() {
                if (null == inputFramework) return;
                SubmitCase();
                List.Add(inputFramework);
                inputFramework = null;
            }
        }

        /// <summary>
        /// Load done - show info.
        /// </summary>
        private void LoadDone() {
            // Show load info.
            foreach (InputFramework item in List) {
                Writer?.WriteLine("- {0}: {1} items, {2} groups", item.Title, item.Cases.Count, item.GroupCounter.Count);
            }
            Writer?.WriteLine("Total {0} groups ({1})", GroupCounter.Count, GetGroupNames());
            Writer?.WriteLine();
        }

        /// <summary>
        /// Get group names.
        /// </summary>
        /// <returns>Returns group names.</returns>
        public string GetGroupNames() {
            string[] list = GroupCounter.Keys.ToArray();
            string rt = string.Join(", ", list);
            return rt;
        }

        /// <summary>
        /// Process.
        /// </summary>
        private void Process() {
            Writer?.WriteLine("Folder:\t{0}", Folder);
            // folderFullPath
            string rootPath = Folder;
            if (string.IsNullOrEmpty(rootPath)) {
                rootPath = Environment.CurrentDirectory;
            }
            rootPath = Path.GetFullPath(rootPath);
            Writer?.WriteLine("Root path:\t{0}", rootPath);
            // enum.
            DirectoryInfo directoryInfo = new DirectoryInfo(rootPath);
            ProcessFolder(rootPath, directoryInfo);
            Writer?.WriteLine();
        }

        /// <summary>
        /// Process folder.
        /// </summary>
        /// <param name="rootPath">Root path.</param>
        /// <param name="directoryInfo">Current directory info.</param>
        private void ProcessFolder(string rootPath, DirectoryInfo directoryInfo) {
            string fullpath = "";
            try {
                fullpath = directoryInfo.FullName;
                //Writer?.WriteLine("{0}", directoryInfo.FullName);
                // sub folder.
                foreach (DirectoryInfo di in directoryInfo.GetDirectories()) {

                    ProcessFolder(rootPath, di);
                }
                // sub file.
                foreach (FileInfo fileInfo in directoryInfo.GetFiles("*.md")) {
                    ProcessFile(rootPath, fileInfo);
                }
            } catch (Exception ex) {
                Writer?.WriteLine("- {0}: {1}", fullpath, ex);
            }
        }

        /// <summary>
        /// Process file.
        /// </summary>
        /// <param name="rootPath">Root path.</param>
        /// <param name="fileInfo">Current file info.</param>
        private void ProcessFile(string rootPath, FileInfo fileInfo) {
            const StringComparison comparisonType = StringComparison.OrdinalIgnoreCase;
            string fileName = fileInfo.Name;
            string fileShortPath = BenchmarkStringUtil.GetSubPath(rootPath, fileInfo.FullName);
            string message = "";
            bool isEnd = false;
            try {
                if (fileName.IndexOf("_Group", comparisonType) >= 0) return;
                if (fileName.IndexOf("README.md", comparisonType) >= 0) return;
                if (fileName.IndexOf("sample.md", comparisonType) >= 0) return;
                message = ProcessFileBody(rootPath, fileInfo, fileShortPath);
            } catch (Exception ex) {
                if (!isEnd) {
                    message = ex.ToString();
                }
            }
            Writer?.WriteLine("- {0}: {1}", fileShortPath, message);
        }

        /// <summary>
        /// Process file body.
        /// </summary>
        /// <param name="rootPath">Root path.</param>
        /// <param name="fileInfo">Current file info.</param>
        /// <param name="fileShortPath">File short path.</param>
        private string ProcessFileBody(string rootPath, FileInfo fileInfo, string fileShortPath) {
            string message = "";
            return message;
        }

    }
}
