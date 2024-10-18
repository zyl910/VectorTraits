using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdateBenchmarkResults.Common;
using UpdateBenchmarkResults.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UpdateBenchmarkResults.Service {
    partial class BenchmarkResultsService {

        /// <summary>
        /// Group - Process folder.
        /// </summary>
        /// <param name="rootPath">Root path.</param>
        /// <param name="directoryInfo">Current directory info.</param>
        private void GroupProcessFolder(string rootPath, DirectoryInfo directoryInfo) {
            string fullpath = "";
            try {
                fullpath = directoryInfo.FullName;
                //Writer?.WriteLine("{0}", directoryInfo.FullName);
                // sub folder.
                foreach (DirectoryInfo di in directoryInfo.GetDirectories()) {

                    GroupProcessFolder(rootPath, di);
                }
                // sub file.
                foreach (FileInfo fileInfo in directoryInfo.GetFiles("*_Group.md")) {
                    GroupProcessFile(rootPath, fileInfo);
                    if (DebugOnly) {
                        throw new OperationCanceledException("[Debug] Only test one file. Will stop.");
                    }
                }
            } catch (OperationCanceledException) {
                throw;
            } catch (Exception ex) {
                Writer?.WriteLine("- {0}: {1}", fullpath, ex.Message);
            }
        }

        /// <summary>
        /// Group - Process file.
        /// </summary>
        /// <param name="rootPath">Root path.</param>
        /// <param name="fileInfo">Current file info.</param>
        private void GroupProcessFile(string rootPath, FileInfo fileInfo) {
            string fileName = fileInfo.Name;
            string fileShortPath = BenchmarkStringUtil.GetSubPath(rootPath, fileInfo.FullName);
            string message = "";
            bool isEnd = false;
            try {
                message = GroupProcessFileBody(rootPath, fileInfo, fileShortPath);
            } catch (Exception ex) {
                Debug.WriteLine(ex);
                if (!isEnd) {
                    message = ex.Message;
                }
            }
            Writer?.WriteLine("- {0}: {1}", fileShortPath, message);
        }

        /// <summary>
        /// Group - Process file body.
        /// </summary>
        /// <param name="rootPath">Root path.</param>
        /// <param name="fileInfo">Current file info.</param>
        /// <param name="fileShortPath">File short path.</param>
        private string GroupProcessFileBody(string rootPath, FileInfo fileInfo, string fileShortPath) {
            string message = string.Empty;
            string filePath = fileInfo.FullName;
            // Check source.
            string filePathSource = filePath.Replace("_Group.md", ".md", comparisonType);
            if (!File.Exists(filePathSource)) {
                return "Source file not found! " + filePathSource;
            }
            // Load.
            string[] lines = ReadAllLines(filePath);
            int srcCount = lines.Length;
            // Parse group.
            string fileTitlePrefix = "# ";
            string patternTitlePrefix = "###";
            string title = "";
            ArraySegment<string>? groupHeader = null;
            int i;
            for (i = 0; i < lines.Length; ++i) {
                string line = lines[i];
                if (null == line) continue;
                if (line.StartsWith(fileTitlePrefix, comparisonType) && string.IsNullOrEmpty(title)) {
                    title = line.Substring(fileTitlePrefix.Length).Trim();
                }
                if (line.StartsWith(patternTitlePrefix, comparisonType)) {
                    groupHeader = new ArraySegment<string>(lines, 0, i);
                    break;
                }
            }
            if (null == title || title.IndexOf("Benchmark group", comparisonType) < 0) {
                return string.Format("It's not a group file! ({0})", title);
            }
            if (null == groupHeader) {
                //return "It's not a group file!";
                groupHeader = new ArraySegment<string>(lines);
            }
            // Parse source.
            lines = ReadAllLines(filePathSource);
            BenchmarkFile? benchmarkFile = ParseBenchmarkFile(lines, ref message, true);
            if (null == benchmarkFile) {
                if (string.IsNullOrEmpty(message)) {
                    message = "Not a benchmark results file! " + filePathSource;
                }
                return message;
            }
            BenchmarkGroupFile benchmarkGroupFile = MakeBenchmarkGroupFile(benchmarkFile);
            int dstCount = 0;
            using (StreamWriter writer = new StreamWriter(filePath, false, encoding)) {
                dstCount = OutputBenchmarkGroupFile(writer, groupHeader, benchmarkGroupFile);
            }
            message = string.Format("{0} lines => {1} lines.", srcCount, dstCount);
            return message;
        }

        /// <summary>
        /// Make <see cref="BenchmarkGroupFile"/>.
        /// </summary>
        /// <param name="benchmarkFile">Source benchmark file (源基准测试文件).</param>
        /// <returns>Return benchmark group file (返回基准测试组文件).</returns>
        private BenchmarkGroupFile MakeBenchmarkGroupFile(BenchmarkFile benchmarkFile) {
            if (null == benchmarkFile) throw new ArgumentNullException(nameof(benchmarkFile), "The benchmarkFile is null!");
            bool fillRaw = false;
            //int i;
            BenchmarkGroupFile rt = new BenchmarkGroupFile();
            rt.Title = benchmarkFile.Title;
            foreach(BenchmarkArchitecture benchmarkArchitecture in benchmarkFile.List) {
                if (null == benchmarkArchitecture) continue;
                foreach (BenchmarkCpu benchmarkCpu in benchmarkArchitecture.List) {
                    if (null == benchmarkCpu) continue;
                    string titlePlatform = string.Format("{0} - {1}", benchmarkArchitecture.Title, benchmarkCpu.Title);
                    BenchmarkGroupPlatform groupPlatform = MakeBenchmarkGroupFile_Platform(benchmarkCpu, fillRaw, titlePlatform);
                    if (null == groupPlatform) continue;
                    rt.List.Add(groupPlatform);
                }
            }
            return rt;
        }

        /// <summary>
        /// Make <see cref="BenchmarkGroupFile"/> - Make Platform.
        /// </summary>
        /// <param name="benchmarkCpu">The <see cref="BenchmarkCpu"/>.</param>
        /// <param name="fillRaw">Is fill raw.</param>
        /// <param name="titlePlatform">The title of platform.</param>
        /// <returns>Return benchmark group platform (返回基准测试组平台).</returns>
        private BenchmarkGroupPlatform MakeBenchmarkGroupFile_Platform(BenchmarkCpu benchmarkCpu, bool fillRaw, string TitlePlatform) {
            if (null == benchmarkCpu) throw new ArgumentNullException(nameof(benchmarkCpu), "The benchmarkCpu is null!");
            int i, j, k;
            BenchmarkFramework? dataDotNet = null;
            BenchmarkCase? dataClass = null;
            BenchmarkGroupCase? dataGroupClass = null;
            BenchmarkCaseRecord? dataRecord = null;
            BenchmarkGroupRow? dataRow = null;
            BenchmarkGroupPlatform dataPlatform = new BenchmarkGroupPlatform();
            dataPlatform.Title = TitlePlatform; // benchmarkCpu.Title;
            if (fillRaw) {
                dataPlatform.Raw = benchmarkCpu;
            }
            // Make fieldNames.
            BenchmarkFramework? dataDotNetLast = null;
            dataPlatform.FieldNames.Clear();
            for (i = 0; i < benchmarkCpu.List.Count; ++i) {
                dataDotNet = benchmarkCpu.List[i];
                if (null == dataDotNet) throw new ApplicationException("Cpu[" + i + "] is null!");
                dataDotNetLast = dataDotNet;
                dataPlatform.FieldNames.Add(dataDotNet.Title);
            }
            // Make cass List.
            if (null == dataDotNetLast) return dataPlatform;
            var fieldNamesCount = dataPlatform.FieldNames.Count;
            foreach (var p in dataDotNetLast.Cases) {
                dataClass = p.Value;
                //if (null == dataClass) throw new ApplicationException("Case[" + i + "] of last Cpu is null!");
                dataGroupClass = new BenchmarkGroupCase();
                dataGroupClass.Title = dataClass.Title;
                dataGroupClass.BaseTitle = dataClass.BaseTitle;
                for (j = 0; j < dataClass.List.Count; ++j) {
                    dataRecord = dataClass.List[j];
                    if (null == dataClass) throw new ApplicationException("`Case[" + i + "].List[" + j + "]` is null!");
                    dataRow = new BenchmarkGroupRow();
                    dataRow.Title = dataRecord.Title;
                    while (dataRow.Values.Count < fieldNamesCount) {
                        dataRow.Values.Add("");
                    }
                    dataGroupClass.List.Add(dataRow);
                }
                dataPlatform.List.Add(dataGroupClass);
            }
            // Fill data.
            for (i = 0; i < benchmarkCpu.List.Count; ++i) {
                dataDotNet = benchmarkCpu.List[i];
                foreach (var p in dataDotNet.Cases) {
                    dataClass = p.Value;
                    dataGroupClass = dataPlatform.FindByTitle(dataClass.Title); //findByTitle(dataPlatform.List, dataClass.Title, null);
                    if (null != dataGroupClass) {
                        for (k = 0; k < dataClass.List.Count; ++k) {
                            dataRecord = dataClass.List[k];
                            dataRow = dataGroupClass.FindByTitle(dataRecord.Title); //findByTitle(dataGroupClass.List, dataRecord.name, null);
                            if (null != dataRow) {
                                var v = dataRecord.mops;
                                dataRow.Values[i] = v;
                            }
                        } // for(k=0; k<dataClass.List.Count; ++k)
                    }
                } // foreach (var p in dataDotNet.Cases)
            } // for(i=0; i<benchmarkCpu.List.Count; ++i)
            return dataPlatform;
        }

        /// <summary>
        /// Output <see cref="BenchmarkGroupFile"/> to stream.
        /// </summary>
        /// <param name="writer">Output writer.</param>
        /// <param name="groupHeader">The header of group file (组文件的标题).</param>
        /// <param name="benchmarkGroupFile">The <see cref="BenchmarkGroupFile"/>.</param>
        /// <returns>Return count of lines.</returns>
        private int OutputBenchmarkGroupFile(StreamWriter writer, IEnumerable<string>? groupHeader, BenchmarkGroupFile benchmarkGroupFile) {
            int dstCount = 0;
            // Header.
            if (null != groupHeader) {
                foreach (string line in groupHeader) {
                    writer.WriteLine(line);
                    ++dstCount;
                }
            }
            // Body.
            List<string> rtList = FormatBenchmarkGroupFile_Makedown(writer, benchmarkGroupFile);
            foreach (string line in rtList) {
                writer.WriteLine(line);
                ++dstCount;
            }
            return dstCount;
        }

        /// <summary>
        /// Format <see cref="BenchmarkGroupFile"/> use Makedown format.
        /// </summary>
        /// <param name="writer">Output writer.</param>
        /// <param name="benchmarkGroupFile">The <see cref="BenchmarkGroupFile"/>.</param>
        /// <returns>Return output lines.</returns>
        private List<string> FormatBenchmarkGroupFile_Makedown(StreamWriter writer, BenchmarkGroupFile benchmarkGroupFile) {
            List<string> rtList = new List<string>();
            string[] itemCommons = { "Type", "Method" };
            int itemCountCommons = itemCommons.Length;
            List<string> itemRow = new List<string>(itemCountCommons);
            BenchmarkGroupPlatform? dataPlatform = null;
            BenchmarkGroupCase? dataClass = null;
            BenchmarkGroupRow? dataRow = null;
            IList<string> fieldNames;
            string fieldName;
            int itemCount; // Class, Name, fieldNames[0]...
            List<int> itemWidths = new List<int>();
            int itemWidth;
            string line, line2;
            int i, j, k, m;
            int n;
            string v;
            itemRow.AddRange(Enumerable.Repeat("", itemCountCommons));
            for (i = 0; i < benchmarkGroupFile.List.Count; ++i) {
                dataPlatform = benchmarkGroupFile.List[i];
                if (dataPlatform.List.Count<=0) {
                    continue;
                }
                fieldNames = dataPlatform.FieldNames;
                rtList.Add("### " + dataPlatform.Title);
                // Fill itemWidths.
                itemCount = itemCountCommons + fieldNames.Count;
                itemWidths = new List<int>(itemCount); //new Array(itemCount);
                itemWidths.AddRange(Enumerable.Repeat(0, itemCount));
                for (j = 0; j < itemCommons.Length; ++j) {
                    fieldName = itemCommons[j];
                    itemWidths[j] = fieldName.Length;
                }
                for (j = 0; j < fieldNames.Count; ++j) {
                    fieldName = fieldNames[j];
                    itemWidths[itemCountCommons + j] = fieldName.Length;
                }
                for (j = 0; j < dataPlatform.List.Count; ++j) {
                    dataClass = dataPlatform.List[j];
                    n = dataClass.BaseTitle.Length;
                    if (itemWidths[0] < n) itemWidths[0] = n;
                    for (k = 0; k < dataClass.List.Count; ++k) {
                        dataRow = dataClass.List[k];
                        n = dataRow.Title.Length;
                        if (itemWidths[1] < n) itemWidths[1] = n;
                        for (m = 0; m < fieldNames.Count; ++m) {
                            v = dataRow.Values[m];
                            if (null == v) v = "";
                            n = v.Length;
                            if (itemWidths[itemCountCommons + m] < n) itemWidths[itemCountCommons + m] = n;
                        }
                    }
                } // for(j=0; j<dataPlatform.List.Count; ++j)
                  // Header.
                line = "|";
                line2 = "|";
                for (j = 0; j < itemCommons.Length; ++j) {
                    fieldName = itemCommons[j];
                    itemWidth = itemWidths[j];
                    line += " " + fieldName + repeatString(" ", itemWidth - fieldName.Length) + " |";
                    line2 += " :" + repeatString("-", itemWidth - 1) + " |";
                }
                for (j = 0; j < fieldNames.Count; ++j) {
                    fieldName = fieldNames[j];
                    itemWidth = itemWidths[itemCountCommons + j];
                    line += " " + repeatString(" ", itemWidth - fieldName.Length) + fieldName + " |";
                    line2 += " " + repeatString("-", itemWidth - 1) + ": |";
                }
                rtList.Add(line);
                rtList.Add(line2);
                // Row.
                for (j = 0; j < dataPlatform.List.Count; ++j) {
                    dataClass = dataPlatform.List[j];
                    //itemRow[0] = dataClass.Title;
                    itemRow[0] = dataClass.BaseTitle;
                    //itemRow[0] = BenchmarkStringUtil.GetCaseBaseTitle(dataClass.Title);
                    for (k = 0; k < dataClass.List.Count; ++k) {
                        dataRow = dataClass.List[k];
                        itemRow[1] = dataRow.Title;
                        line = "|";
                        for (m = 0; m < itemRow.Count; ++m) {
                            v = itemRow[m];
                            if (null == v) v = "";
                            itemWidth = itemWidths[m];
                            line += " " + v + repeatString(" ", itemWidth - v.Length) + " |";
                        }
                        for (m = 0; m < fieldNames.Count; ++m) {
                            v = dataRow.Values[m];
                            if (null == v) v = "";
                            itemWidth = itemWidths[itemCountCommons + m];
                            line += " " + repeatString(" ", itemWidth - v.Length) + v + " |";
                        }
                        rtList.Add(line);
                    }
                } // for(j=0; j<dataPlatform.List.Count; ++j)
                rtList.Add("");
            } // for(i=0; i<benchmarkGroupFile.List.Count; ++i)
            return rtList;
        }

        /// <summary>
        /// Make repeat string.
        /// </summary>
        /// <param name="str">Source string.</param>
        /// <param name="count">The count.</param>
        /// <returns>returns a new string which contains the specified number of copies of the string.</returns>
        private static string repeatString(string str, int count) {
            if (count <= 0) return "";
            return new StringBuilder(str.Length * count).Insert(0, str, count).ToString();
        }
    }
}
