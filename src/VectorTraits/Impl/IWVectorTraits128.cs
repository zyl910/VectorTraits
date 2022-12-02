using System;
using System.Collections.Generic;
using System.Text;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// <see cref="Vector128{T}"/> traits interface.
    /// </summary>
    public interface IWVectorTraits128 : IWVectorTraits {
#if NETCOREAPP3_0_OR_GREATER
        /// <summary>
        /// Shifts each element of a vector left by the specified amount.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted.</param>
        /// <param name="shiftCount">The number of bits by which to shift each element.</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftCount"/>.</returns>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{byte}, int)"/> // .NET 7
        Vector128<byte> ShiftLeft(Vector128<byte> value, int shiftCount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted.</param>
        /// <param name="shiftCount">The number of bits by which to shift each element.</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftCount"/>.</returns>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{short}, int)"/> // .NET 7
        Vector128<short> ShiftLeft(Vector128<short> value, int shiftCount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted.</param>
        /// <param name="shiftCount">The number of bits by which to shift each element.</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftCount"/>.</returns>
        /// <seealso cref="Vector128.ShiftLeft(Vector128{int}, int)"/> // .NET 7
        Vector128<int> ShiftLeft(Vector128<int> value, int shiftCount);

        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted.</param>
        /// <param name="shiftCount">The number of bits by which to shift each element.</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftCount"/>.</returns>
        /// <seealso cref="Vector128.ShiftRightArithmetic(Vector128{int}, int)"/> // .NET 7
        Vector128<int> ShiftRightArithmetic(Vector128<int> value, int shiftCount);

#endif
    }
}
