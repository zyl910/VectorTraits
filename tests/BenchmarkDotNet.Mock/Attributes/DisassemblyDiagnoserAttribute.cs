// BenchmarkDotNet.Attributes.DisassemblyDiagnoserAttribute
using System;

namespace BenchmarkDotNet.Attributes {

	[AttributeUsage(AttributeTargets.Class)]
	public class DisassemblyDiagnoserAttribute : Attribute {
		public DisassemblyDiagnoserAttribute(int maxDepth = 1, bool printSource = false, bool printInstructionAddresses = false, bool exportGithubMarkdown = true, bool exportHtml = false, bool exportCombinedDisassemblyReport = false, bool exportDiff = false, params string[] filters) {
		}

		protected DisassemblyDiagnoserAttribute() {
		}
	}
}
