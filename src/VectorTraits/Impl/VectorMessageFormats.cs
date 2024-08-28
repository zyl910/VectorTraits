using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// Vector message formats (向量消息格式). 
    /// </summary>
    public static class VectorMessageFormats {

        /// <summary>
        /// Text - No hardware acceleration! (文本 - 没有硬件加速).
        /// </summary>
        public static readonly string TEXT_NO_HARDWARE_ACCELERATION = "No hardware acceleration!";


        /// <summary>
        /// Message format of NOT_SUPPORTED in case of 1 types (1个类型时，NOT_SUPPORTED的消息格式).
        /// </summary>
        public static readonly string FORMAT_TYPE_NOT_SUPPORTED_1 = "These element types({0}) are not supported!";

        /// <summary>
        /// Message format of NOT_SUPPORTED in case of 2 types (2个类型时，NOT_SUPPORTED的消息格式).
        /// </summary>
        public static readonly string FORMAT_TYPE_NOT_SUPPORTED_2 = "These element types({0}, {1}) are not supported!";

        /// <summary>
        /// YShuffleG4 - Message format of count must be at least 4 (数量至少为4的消息).
        /// </summary>
        public static readonly string FORMAT_YSHUFFLEG4_MUST4_1 = "The count({0}) of elements in a vector cannot be less than 4! Please use YShuffleG4X2 instead.";


		/// <summary>
		/// Message format of REQUIRES_HARDWARE_SUPPORTED (必须硬件支持的消息格式).
		/// </summary>
		public static readonly string FORMAT_REQUIRES_HARDWARE_SUPPORTED_1 = "Requires hardware support {0}!";

        /// <summary>
        /// Throw exception when hardware unsupported. (当硬件不支持时抛出异常).
        /// </summary>
        /// <param name="isSupported">Is supported (是否支持).</param>
        /// <param name="title">The title (标题).</param>
        /// <exception cref="NotSupportedException">Thrown when isSupported is false (当 isSupported 为false时抛出此异常).</exception>
        [Obsolete("Please use ThrowNewUnsupported instead.")]
        public static void ThrowForUnsupported(bool isSupported, string title) {
            if (isSupported) return;
            ThrowNewUnsupported(title);
        }

        /// <summary>
        /// Throw new <see cref="NotSupportedException"/> exception. (抛出新的 <see cref="NotSupportedException"/> 异常).
        /// </summary>
        /// <param name="title">The title (标题).</param>
        /// <exception cref="NotSupportedException">Alway thrown exception (总是抛出此异常).</exception>
        public static void ThrowNewUnsupported(string title) {
            string msg = string.Format(FORMAT_REQUIRES_HARDWARE_SUPPORTED_1, title);
            throw new NotSupportedException(msg);
        }

	}
}
