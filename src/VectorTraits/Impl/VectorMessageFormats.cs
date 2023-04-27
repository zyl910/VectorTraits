using System;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// Vector message formats (向量消息格式). 
    /// </summary>
    public static class VectorMessageFormats {

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

    }
}
