using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdateBenchmarkResults.Common;

namespace UpdateBenchmarkResults.Service {
    /// <summary>
    /// Benchmark results service
    /// </summary>
    internal class BenchmarkResultsService {

        /// <summary>
        /// Text writer.
        /// </summary>
        public TextWriter Writer { get; set; }

        /// <summary>
        /// Source file.
        /// </summary>
        public string SourceFile { get; set; }

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
            ParseCommand(args);
            Run();
        }

        /// <summary>
        /// Run.
        /// </summary>
        public void Run() {
            Writer.WriteLine("SourceFile:\t{0}", SourceFile);
            if (string.IsNullOrEmpty(SourceFile)) {
                Writer.WriteLine("[Error] SourceFile is empty!");
                return;
            }
            Load();
            // Finish.
            Writer.WriteLine("Finish.");
        }

        /// <summary>
        /// Load.
        /// </summary>
        private void Load() {
            int lineNo = 1;
            foreach(string line in File.ReadLines(SourceFile)) {
                if (lineNo <= 30) {
                    Writer.WriteLine("{0}\t{1}", lineNo, line);
                }
                // next.
                ++lineNo;
            }
        }

    }
}
