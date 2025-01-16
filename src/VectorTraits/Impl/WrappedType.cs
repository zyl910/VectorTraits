using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// Wrapped type information It supports AOT (已包装的类型信息. 它支持AOT)
    /// </summary>
    public class WrappedType {
        /// <summary>
        /// Type data.
        /// </summary>
#if NET5_0_OR_GREATER
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
#endif // NET5_0_OR_GREATER
        public Type Type { get; }

        /// <summary>
        /// Create WrappedType (创建 WrappedType).
        /// </summary>
        /// <param name="type">The type.</param>
        public WrappedType(
#if NET5_0_OR_GREATER
                [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
#endif // NET5_0_OR_GREATER
                Type type) {
            Type = type;
        }

        /// <summary>
        /// Implicit case to WrappedType (隐式转型为 WrappedType).
        /// </summary>
        /// <param name="type">The type.</param>
        public static implicit operator WrappedType(
#if NET5_0_OR_GREATER
                [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
#endif // NET5_0_OR_GREATER
                Type type) {
            return new WrappedType(type);
        }

        /// <summary>
        /// Explicit case to Type (显式转型为 Type).
        /// </summary>
        /// <param name="type">The type.</param>
        public static explicit operator Type(WrappedType type) {
            return type.Type;
        }
    }
}
