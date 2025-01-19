using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// Type information for <see cref="DynamicallyAccessedMembersAttribute"/> has been wrapped. It is used to solve the problem of reflection at AOT (已包装了 DynamicallyAccessedMembersAttribute 的类型信息. 它用于解决反射在AOT时的问题).
    /// </summary>
    /// <remarks>
    /// <para>See also</para>
    /// <para>Introduction to AOT warnings: https://learn.microsoft.com/en-us/dotnet/core/deploying/native-aot/fixing-warnings</para>
    /// <para>Introduction to trim warnings: https://learn.microsoft.com/en-us/dotnet/core/deploying/trimming/fixing-warnings</para>
    /// <para>How to make libraries compatible with native AOT: https://devblogs.microsoft.com/dotnet/creating-aot-compatible-libraries/</para>
    /// </remarks>
    /// <seealso cref="DynamicallyAccessedMembersAttribute"/>
    public class WrappedType : IEquatable<WrappedType?> {
        /// <summary>
        /// Type of void.
        /// </summary>
        public static WrappedType Void { get; } = new WrappedType(typeof(void));

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

        /// <inheritdoc/>
        public static bool operator ==(WrappedType? left, WrappedType? right) {
            if (left == right) return true;
            if (left == null) return false;
            return left.Type.Equals(right?.Type);
        }

        /// <inheritdoc/>
        public static bool operator !=(WrappedType? left, WrappedType? right) {
            return !(left == right);
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj) {
            return Equals(obj as WrappedType);
        }

        /// <inheritdoc/>
        public bool Equals(WrappedType? other) {
            return other is not null && Type.Equals(other.Type);
        }

        /// <inheritdoc/>
        public override int GetHashCode() {
            return Type.GetHashCode();
        }

        /// <inheritdoc/>
        public override string? ToString() {
            return Type.ToString();
        }
    }
}
