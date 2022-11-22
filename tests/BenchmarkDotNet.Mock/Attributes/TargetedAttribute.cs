// BenchmarkDotNet.Attributes.TargetedAttribute
using System;
using System.Linq;
using System.Reflection;

namespace BenchmarkDotNet.Attributes {
	public abstract class TargetedAttribute : Attribute {
		public string[]? Targets { get; set; }

		public string Target {
			get {
				throw new InvalidOperationException("Please use Targets property");
			}
			set {
				Targets = (string.IsNullOrEmpty(value) ? new string[0] : value.Split(new char[1] { ',' }));
			}
		}

		public bool Match(MethodInfo method) {
			if (Targets != null && Targets.Length != 0) {
				return Targets.Contains(method.Name);
			}
			return true;
		}
	}
}
