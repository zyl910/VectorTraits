// BenchmarkDotNet.Attributes.GlobalSetupAttribute
using System;
using BenchmarkDotNet.Attributes;
//using JetBrains.Annotations;

namespace BenchmarkDotNet.Attributes {
    [AttributeUsage(AttributeTargets.Method)]
    //[MeansImplicitUse]
    public class GlobalSetupAttribute : TargetedAttribute {
    }
}
