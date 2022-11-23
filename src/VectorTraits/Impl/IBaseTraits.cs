using System;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// Base traits interface.
    /// </summary>
    public interface IBaseTraits {

        /// <summary>
        /// Get byte count (取得字节数量).
        /// </summary>
        int ByteCount { get; }

        /// <summary>
        /// Whether to support the run (是否支持运行).
        /// </summary>
        bool IsSupported { get; }

        /// <summary>
        /// Throw exception when not supported. (当不支持时抛出异常).
        /// </summary>
        /// <exception cref="NotSupportedException">If <see cref="IsSupported"/> return false.</exception>
        void ThrowForUnsupported();
    }
}
