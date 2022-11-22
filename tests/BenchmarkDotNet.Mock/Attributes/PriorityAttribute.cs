// BenchmarkDotNet.Attributes.PriorityAttribute
using System;

namespace BenchmarkDotNet.Attributes {
	public abstract class PriorityAttribute : Attribute {
		public int Priority { get; set; }
	}
}
