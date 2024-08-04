using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Benchmarks {

    /// <summary>
    /// Disable <see cref="BenchmarkDotNet.Attributes.BenchmarkAttribute"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    //[MeansImplicitUse]
    internal class DisableBenchmarkAttribute : Attribute {
        public string Description { get; set; }

        public bool Baseline { get; set; }

        public int OperationsPerInvoke { get; set; } = 1;


        public int SourceCodeLineNumber { get; }

        public string SourceCodeFile { get; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public DisableBenchmarkAttribute([CallerLineNumber] int sourceCodeLineNumber = 0, [CallerFilePath] string sourceCodeFile = "") {
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
            SourceCodeLineNumber = sourceCodeLineNumber;
            SourceCodeFile = sourceCodeFile;
        }
    }
}
