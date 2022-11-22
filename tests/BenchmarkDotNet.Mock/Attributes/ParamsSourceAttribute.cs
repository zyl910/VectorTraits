// BenchmarkDotNet.Attributes.ParamsSourceAttribute
using System;
using BenchmarkDotNet.Attributes;

namespace BenchmarkDotNet.Attributes {
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class ParamsSourceAttribute : PriorityAttribute {
		public string Name { get; }

		public ParamsSourceAttribute(string name) {
			Name = name;
		}
	}
}
