using System;
using System.Collections.Generic;
using System.Text;

namespace Zyl.VectorTraits.Impl {
    /// <summary>
    /// Float round mode (浮点舍入模式).
    /// </summary>
    public enum FloatRoundMode : byte {
        //_MM_FROUND_TO_NEAREST_INT // round to nearest
        //_MM_FROUND_TO_NEG_INF     // round down
        //_MM_FROUND_TO_POS_INF     // round up
        //_MM_FROUND_TO_ZERO        // truncate
        //_MM_FROUND_CUR_DIRECTION  // use MXCSR.RC; see _MM_SET_ROUNDING_MODE


        /// <summary>Round to even (向偶数舍入). It is also known as `rounding half to even`/`round to nearest integer` (它也被称作`四舍六入五成双`/`舍入到最近整数`). See more: <see cref="MidpointRounding.ToEven"/>.</summary>
        ToEven = 0,
        /// <summary>Floor (向下取整). It is also known as round to negative infinity (它也被称作向负无穷舍入). See more: <see cref="MidpointRounding.ToNegativeInfinity"/>.</summary>
        ToNegativeInfinity = 1,
        /// <summary>Ceiling (向上取整). It is also known as round to positive infinity (它也被称作向正无穷舍入). See more: <see cref="MidpointRounding.ToPositiveInfinity"/>.</summary>
        ToPositiveInfinity = 2,
        /// <summary>Round to zero (向零舍入). It is also known as truncate (它也被称作截断取整). See more: <see cref="MidpointRounding.ToZero"/>.</summary>
        ToZero = 3,
        /// <summary>Round to current direction (向当前方向舍入). Use MXCSR.RC; see _MM_SET_ROUNDING_MODE.</summary>
        CurrentDirection = 4,

    }
}
