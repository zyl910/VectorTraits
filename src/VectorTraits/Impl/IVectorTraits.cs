using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// <see cref="Vector{T}"/> traits interface.
    /// </summary>
    public interface IVectorTraits : IBaseTraits {
        /// <summary>
        /// Shifts each element of a vector left by the specified amount.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted.</param>
        /// <param name="shiftCount">The number of bits by which to shift each element.</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftCount"/>.</returns>
        /// <seealso cref="Vector.ShiftLeft(Vector256{Int16}, int)"/> // .NET 7
        Vector<Int16> ShiftLeft(Vector<Int16> value, int shiftCount);

        /// <summary>
        /// Shifts each element of a vector left by the specified amount.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted.</param>
        /// <param name="shiftCount">The number of bits by which to shift each element.</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftCount"/>.</returns>
        /// <seealso cref="Vector.ShiftLeft(Vector256{Int32}, int)"/> // .NET 7
        Vector<Int32> ShiftLeft(Vector<Int32> value, int shiftCount);


        /// <summary>
        /// Shifts (signed) each element of a vector right by the specified amount.
        /// </summary>
        /// <param name="value">The vector whose elements are to be shifted.</param>
        /// <param name="shiftCount">The number of bits by which to shift each element.</param>
        /// <returns>A vector whose elements where shifted right by <paramref name="shiftCount"/>.</returns>
        /// <seealso cref="Vector.ShiftRightArithmetic(Vector256{Int32}, int)"/> // .NET 7
        Vector<Int32> ShiftRightArithmetic(Vector<Int32> value, int shiftCount);

    }
}
