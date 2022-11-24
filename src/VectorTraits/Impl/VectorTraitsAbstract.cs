using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.Numerics;
using System.Diagnostics;

namespace Zyl.VectorTraits.Impl {
    using Statics = VectorTraitsBase.Statics;

    /// <summary>
    /// <see cref="Vector{T}"/> traits - abstract.
    /// </summary>
    public abstract class VectorTraitsAbstract : IVectorTraits {

        /// <summary>
        /// Get best instance.
        /// </summary>
        /// <returns>Returns best instance.</returns>
        public static IVectorTraits GetBestInstance() {
            int byteCount = Vector<byte>.Count;
            if (VectorTraits256Abstract.ByteCountValue == byteCount) {
                return VectorTraits256Abstract.GetBestInstance();
            } else if (VectorTraits128Abstract.ByteCountValue == byteCount) {
                return VectorTraits128Abstract.GetBestInstance();
            }
            // default.
            Debug.WriteLine("VectorTraitsAbstract.GetBestInstance fail! Can not found supported instance. Vector<byte>.Count={0}", byteCount);
            return VectorTraitsBase.Instance;
        }

        /// <summary>
        /// Get base instance.
        /// </summary>
        /// <returns>Returns base instance.</returns>
        public static IVectorTraits GetBaseInstance() {
            int byteCount = Vector<byte>.Count;
            if (VectorTraits256Abstract.ByteCountValue == byteCount) {
                return VectorTraits256Base.Instance;
            } else if (VectorTraits128Abstract.ByteCountValue == byteCount) {
                return VectorTraits128Base.Instance;
            }
            // default.
            Debug.WriteLine("VectorTraitsAbstract.GetBaseInstance fail! Can not found supported instance. Vector<byte>.Count={0}", byteCount);
            return VectorTraitsBase.Instance;
        }

        /// <inheritdoc cref="IBaseTraits.ByteCount"/>
        public virtual int ByteCount {
            get {
                return Statics.ByteCount;
            }
        }

        /// <inheritdoc cref="IBaseTraits.IsSupported"/>
        public virtual bool IsSupported {
            get {
                return Statics.IsSupported;
            }
        }

        /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
        public virtual void ThrowForUnsupported() {
            Statics.ThrowForUnsupported();
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{Int16}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<Int16> ShiftLeft(Vector<Int16> value, int shiftCount) {
            return Statics.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{Int32}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<Int32> ShiftLeft(Vector<Int32> value, int shiftCount) {
            return Statics.ShiftLeft(value, shiftCount);
        }

        /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{Int32}, int)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector<Int32> ShiftRightArithmetic(Vector<Int32> value, int shiftCount) {
            return Statics.ShiftRightArithmetic(value, shiftCount);
        }

    }
}
