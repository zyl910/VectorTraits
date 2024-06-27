using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;

namespace Zyl.VectorTraits.Numerics {
#if NET7_0_OR_GREATER

    /// <summary>
    /// Call <see cref="INumberBase{TSelf}"/> (调用 <see cref="INumberBase{TSelf}"/>).
    /// </summary>
    public static class CallINumberBase {

#if NET9_0_OR_GREATER
        /// <inheritdoc cref="INumberBase{TSelf}.MultiplyAddEstimate(TSelf, TSelf, TSelf)" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TSelf MultiplyAddEstimate<TSelf>(TSelf left, TSelf right, TSelf addend) where TSelf : INumberBase<TSelf> {
            return TSelf.MultiplyAddEstimate(left, right, addend);
        }
#endif // NET9_0_OR_GREATER

#if NET8_0_OR_GREATER
        // Error if no used UnsafeAccessor! CS0122 'INumberBase<TSelf>.TryConvertFromChecked<TOther>(TOther, out TSelf)' is inaccessible due to its protection level
        // /// <inheritdoc cref="INumberBase{TSelf}.TryConvertFromChecked{TOther}(TOther, out TSelf)" />
        // public static bool TryConvertFromChecked<TSelf, TOther>(TOther value, [MaybeNullWhen(false)] out TSelf result) where TSelf : INumberBase<TSelf> where TOther : INumberBase<TOther> {
        //     return TSelf.TryConvertFromChecked(value, out result);
        // }

        /// <inheritdoc cref="INumberBase{TSelf}.TryConvertFromChecked{TOther}(TOther, out TSelf)" />
        [UnsafeAccessor(UnsafeAccessorKind.StaticField, Name = "TryConvertFromChecked")]
        public extern static bool TryConvertFromChecked<TSelf, TOther>(TOther value, [MaybeNullWhen(false)] out TSelf result) where TSelf : INumberBase<TSelf>
#nullable disable
            where TOther : INumberBase<TOther>;
#nullable restore

#endif // NET8_0_OR_GREATER

    }

#endif // NET7_0_OR_GREATER
}
