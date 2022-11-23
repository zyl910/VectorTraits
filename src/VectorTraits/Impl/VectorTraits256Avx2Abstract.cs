﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace Zyl.VectorTraits.Impl {
    using Statics = VectorTraits256Avx2.Statics;

    /// <summary>
    /// <see cref="Vector{T}"/> traits 256 - Avx2 abstract.
    /// </summary>
    public abstract class VectorTraits256Avx2Abstract : VectorTraits256Abstract {
        
        /// <inheritdoc cref="IBaseTraits.IsSupported"/>
        public override bool IsSupported {
            get {
                return Statics.IsSupported;
            }
        }

        /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
        public override void ThrowForUnsupported() {
            Statics.ThrowForUnsupported();
        }

#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{Int16}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<Int16> ShiftLeft(Vector<Int16> value, int shiftCount) {
            return Statics.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{Int32}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<Int32> ShiftLeft(Vector<Int32> value, int shiftCount) {
            return Statics.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{Int32}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector<Int32> ShiftRightArithmetic(Vector<Int32> value, int shiftCount) {
            return Statics.ShiftRightArithmetic(value, shiftCount);
        }


#endif // NETCOREAPP3_0_OR_GREATER
    }
}
