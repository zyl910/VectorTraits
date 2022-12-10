using System;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// Base traits interface (基本的特征接口).
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
        /// Gets it is support the run (取得它是否支持运行).
        /// </summary>
        /// <param name="noStrict">No strict check(不严格检查). When it is true, <see cref="IntPtr.Size"/> / <see cref="BitConverter.IsLittleEndian"/> is not checked (当它为true时, 不会检查 IntPtr.Size, IsLittleEndian)</param>
        /// <returns>Returns true if the runtime is supported, false otherwise (当支持运行时返回 true, 否则返回 false).</returns>
        bool GetIsSupported(bool noStrict = false);

        /// <summary>
        /// Get unsupported messages (取得不支持时的消息).
        /// </summary>
        /// <param name="noStrict">No strict check(不严格检查). When it is true, <see cref="IntPtr.Size"/> / <see cref="BitConverter.IsLittleEndian"/> is not checked (当它为true时, 不会检查 IntPtr.Size, IsLittleEndian)</param>
        /// <returns>Returns unsupported messages (取得不支持时的消息).</returns>
        string GetUnsupportedMessage(bool noStrict = false);

        /// <summary>
        /// Throw exception when not supported. (当不支持时抛出异常).
        /// </summary>
        /// <param name="noStrict">No strict check(不严格检查). When it is true, <see cref="IntPtr.Size"/> / <see cref="BitConverter.IsLittleEndian"/> is not checked (当它为true时, 不会检查 IntPtr.Size, IsLittleEndian)</param>
        /// <exception cref="NotSupportedException">If <see cref="GetIsSupported"/> return false.</exception>
        void ThrowForUnsupported(bool noStrict = false);
    }
}
