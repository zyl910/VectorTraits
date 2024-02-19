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
            // Load.
            string[]? lines = null;
            try {
                lines = File.ReadAllLines(filePath, encoding);
            } catch (Exception ex) {
                Writer?.WriteLine(ex);
            }
            if (null == lines) {
                lines = File.ReadAllLines(filePath);
            }
            if (null == lines) {
                return "Can't read file!";
            }
            // Parse group.
            // Parse source.
            return message;
        }

    }
}
