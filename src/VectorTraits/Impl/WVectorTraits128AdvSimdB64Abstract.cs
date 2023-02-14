using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl {
    using Statics = WVectorTraits128AdvSimdB64.Statics;

    /// <summary>
    /// <see cref="Vector128{T}"/> traits - AdvSimd 64bit abstract.
    /// </summary>
    public abstract class WVectorTraits128AdvSimdB64Abstract : WVectorTraits128AdvSimdAbstract {
        /// <inheritdoc cref="IBaseTraits.IsSupported"/>
        public override bool IsSupported {
            get {
                return Statics.IsSupported;
            }
        }

        /// <inheritdoc cref="IBaseTraits.GetIsSupported"/>
        public override bool GetIsSupported(bool noStrict = false) {
            return Statics.GetIsSupported(noStrict);
        }

        /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
        public override string GetUnsupportedMessage(bool noStrict = false) {
            return Statics.GetUnsupportedMessage(noStrict);
        }

        /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
        public override void ThrowForUnsupported(bool noStrict = false) {
            Statics.ThrowForUnsupported(noStrict);
        }

#if NET5_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits128.Abs_AcceleratedTypes"/>
        public override TypeCodeFlags Abs_AcceleratedTypes {
            get {
                return Statics.Abs_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Abs(Vector128<double> value) {
            return Statics.Abs(value);
        }

        /// <inheritdoc cref="IWVectorTraits128.Abs(Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> Abs(Vector128<long> value) {
            return Statics.Abs(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.Add_AcceleratedTypes"/>
        public override TypeCodeFlags Add_AcceleratedTypes {
            get {
                return Statics.Add_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Add(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Add(Vector128<double> left, Vector128<double> right) {
            return Statics.Add(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Ceiling_AcceleratedTypes"/>
        public override TypeCodeFlags Ceiling_AcceleratedTypes {
            get {
                return Statics.Ceiling_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Ceiling(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Ceiling(Vector128<double> value) {
            return Statics.Ceiling(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.Divide_AcceleratedTypes"/>
        public override TypeCodeFlags Divide_AcceleratedTypes {
            get {
                return Statics.Divide_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Divide(Vector128{float}, Vector128{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<float> Divide(Vector128<float> left, Vector128<float> right) {
            return Statics.Divide(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Divide(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Divide(Vector128<double> left, Vector128<double> right) {
            return Statics.Divide(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Floor_AcceleratedTypes"/>
        public override TypeCodeFlags Floor_AcceleratedTypes {
            get {
                return Statics.Floor_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Floor(Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Floor(Vector128<double> value) {
            return Statics.Floor(value);
        }


        /// <inheritdoc cref="IWVectorTraits128.GreaterThan_AcceleratedTypes"/>
        public override TypeCodeFlags GreaterThan_AcceleratedTypes {
            get {
                return Statics.GreaterThan_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> GreaterThan(Vector128<double> left, Vector128<double> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> GreaterThan(Vector128<long> left, Vector128<long> right) {
            return Statics.GreaterThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.GreaterThan(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> GreaterThan(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.GreaterThan(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.LessThan_AcceleratedTypes"/>
        public override TypeCodeFlags LessThan_AcceleratedTypes {
            get {
                return Statics.LessThan_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> LessThan(Vector128<double> left, Vector128<double> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> LessThan(Vector128<long> left, Vector128<long> right) {
            return Statics.LessThan(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.LessThan(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> LessThan(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.LessThan(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Max_AcceleratedTypes"/>
        public override TypeCodeFlags Max_AcceleratedTypes {
            get {
                return Statics.Max_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Max(Vector128<double> left, Vector128<double> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> Max(Vector128<long> left, Vector128<long> right) {
            return Statics.Max(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Max(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> Max(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.Max(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Min_AcceleratedTypes"/>
        public override TypeCodeFlags Min_AcceleratedTypes {
            get {
                return Statics.Min_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Min(Vector128<double> left, Vector128<double> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> Min(Vector128<long> left, Vector128<long> right) {
            return Statics.Min(left, right);
        }

        /// <inheritdoc cref="IWVectorTraits128.Min(Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> Min(Vector128<ulong> left, Vector128<ulong> right) {
            return Statics.Min(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Subtract_AcceleratedTypes"/>
        public override TypeCodeFlags Subtract_AcceleratedTypes {
            get {
                return Statics.Subtract_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Subtract(Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> Subtract(Vector128<double> left, Vector128<double> right) {
            return Statics.Subtract(left, right);
        }


        /// <inheritdoc cref="IWVectorTraits128.Widen_AcceleratedTypes"/>
        public override TypeCodeFlags Widen_AcceleratedTypes {
            get {
                return Statics.Widen_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.Widen(Vector128{float}, out Vector128{double}, out Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override void Widen(Vector128<float> source, out Vector128<double> lower, out Vector128<double> upper) {
            Statics.Widen(source, out lower, out upper);
        }


        /// <inheritdoc cref="IWVectorTraits128.YClamp_AcceleratedTypes"/>
        public override TypeCodeFlags YClamp_AcceleratedTypes {
            get {
                return Statics.YClamp_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{double}, Vector128{double}, Vector128{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<double> YClamp(Vector128<double> value, Vector128<double> amin, Vector128<double> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{long}, Vector128{long}, Vector128{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<long> YClamp(Vector128<long> value, Vector128<long> amin, Vector128<long> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits128.YClamp(Vector128{ulong}, Vector128{ulong}, Vector128{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override Vector128<ulong> YClamp(Vector128<ulong> value, Vector128<ulong> amin, Vector128<ulong> amax) {
            return Statics.YClamp(value, amin, amax);
        }



#endif // NET5_0_OR_GREATER
    }
}

