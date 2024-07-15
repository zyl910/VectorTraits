using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;
using Zyl.VectorTraits;
using Zyl.VectorTraits.ExTypes;

namespace Zyl.VectorTraits.Benchmarks {

    // My type.
    using TMy = ExInt128;
    using TAdd = Int64;

    /// <summary>
    /// Abstract shared array benchmark - Int128.
    /// </summary>
    public class AbstractSharedBenchmark_Int128 : AbstractSharedBenchmark {
        // -- TMy ref --
        protected static ref TMy dstTMy => ref dstInt128;
        protected static ref TMy baselineTMy => ref baselineInt128;
        protected static TMy[] srcArray => srcArrayInt128;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected override void CheckResult(string name) {
            CheckResultInt128(name);
        }


        // -- Methods --

        /// <summary>
        /// Fast Add.
        /// </summary>
        /// <inheritdoc cref="Vectors.Add(Vector{long}, Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected static Vector<TMy> Add(Vector<TMy> left, Vector<TMy> right) {
            return Vector.Add(left.ExAs<TMy, TAdd>(), right.ExAs<TMy, TAdd>()).ExAs<TAdd, TMy>();
        }

#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="Add(Vector{TMy}, Vector{TMy})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected static Vector128<TMy> Add(Vector128<TMy> left, Vector128<TMy> right) {
            return Vector128s.Add(left.ExAs<TMy, TAdd>(), right.ExAs<TMy, TAdd>()).ExAs<TAdd, TMy>();
        }

        /// <inheritdoc cref="Add(Vector{TMy}, Vector{TMy})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected static Vector256<TMy> Add(Vector256<TMy> left, Vector256<TMy> right) {
            return Vector256s.Add(left.ExAs<TMy, TAdd>(), right.ExAs<TMy, TAdd>()).ExAs<TAdd, TMy>();
        }

#endif

#if NET8_0_OR_GREATER

        /// <inheritdoc cref="Add(Vector{TMy}, Vector{TMy})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected static Vector512<TMy> Add(Vector512<TMy> left, Vector512<TMy> right) {
            return Vector512.Add(left.ExAs<TMy, TAdd>(), right.ExAs<TMy, TAdd>()).ExAs<TAdd, TMy>();
        }

#endif // NET8_0_OR_GREATER

        /// <summary>
        /// Fast Sum.
        /// </summary>
        /// <inheritdoc cref="Vectors.Sum(Vector{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected static TMy Sum(Vector<TMy> value) {
            return (TMy)Vectors.Sum(value.ExAs<TMy, TAdd>());
        }

#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="Sum(Vector{TMy})"/>
        protected static TMy Sum(Vector128<TMy> value) {
            return (TMy)Vector128s.Sum(value.ExAs<TMy, TAdd>());
        }

        /// <inheritdoc cref="Sum(Vector{TMy})"/>
        protected static TMy Sum(Vector256<TMy> value) {
            return (TMy)Vector256s.Sum(value.ExAs<TMy, TAdd>());
        }

#endif

#if NET8_0_OR_GREATER

        /// <inheritdoc cref="Sum(Vector{TMy})"/>
        protected static TMy Sum(Vector512<TMy> value) {
            return (TMy)Vector512.Sum(value.ExAs<TMy, TAdd>());
        }

#endif // NET8_0_OR_GREATER

        // -- Params --
        public override int ShiftAmountMin {
            get {
                //return 1;
                return -1;
            }
        }
        public override int ShiftAmountMax {
            get {
                //return 1;
                return Scalars<TMy>.BitSize + 1;
            }
        }


    }
}
