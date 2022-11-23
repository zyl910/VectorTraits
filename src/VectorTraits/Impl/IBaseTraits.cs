using System;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// Base traits interface.
    /// </summary>
    public interface IBaseTraits {

        /// <summary>
        /// Get byte count. 
        /// </summary>
        int ByteCount { get; }

        /// <summary>
        /// Gets a value that indicates whether vector operations are subject to hardware acceleration through JIT intrinsic support.
        /// </summary>
        bool IsSupported { get; }

        /// <summary>
        /// Throw exception for unsupported.
        /// </summary>
        /// <exception cref="NotSupportedException">If <see cref="IsSupported"/> return false.</exception>
        void ThrowForUnsupported();
    }
}
