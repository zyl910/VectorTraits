using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Zyl.VectorTraits.Impl.Attributes {
    /// <summary>
    /// Fake <see cref="RequiresUnreferencedCodeAttribute"/>. Indicates that the specified method requires dynamic access to code that is not referenced statically, for example, through System.Reflection.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method, Inherited = false)]
    public class FakeRequiresUnreferencedCodeAttribute : Attribute {
        /// <summary>
        /// Initializes a new instance of the System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute class with the specified message.
        /// </summary>
        /// <param name="message">A message that contains information about the usage of unreferenced code.</param>
        public FakeRequiresUnreferencedCodeAttribute(string message) {
            Message = message;
        }

        /// <summary>
        /// Gets a message that contains information about the usage of unreferenced code.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Gets or sets an optional URL that contains more information about the method, why it requires unreferenced code, and what options a consumer has to deal with it.
        /// </summary>
        public string? Url { get; set; }

    }
}
