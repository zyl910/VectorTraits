using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Text;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif

namespace Zyl.VectorTraits.Impl.AVector256 {
    using Statics = WVectorTraits256Base.Statics;

    partial class WVectorTraits256Abstract {
#if NETCOREAPP3_0_OR_GREATER

        /// <inheritdoc cref="IWVectorTraits256.YClamp_AcceleratedTypes"/>
        public virtual TypeCodeFlags YClamp_AcceleratedTypes {
            get {
                return Statics.YClamp_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{float}, Vector256{float}, Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YClamp(Vector256<float> value, Vector256<float> amin, Vector256<float> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{double}, Vector256{double}, Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YClamp(Vector256<double> value, Vector256<double> amin, Vector256<double> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YClamp(Vector256<sbyte> value, Vector256<sbyte> amin, Vector256<sbyte> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YClamp(Vector256<byte> value, Vector256<byte> amin, Vector256<byte> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YClamp(Vector256<short> value, Vector256<short> amin, Vector256<short> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YClamp(Vector256<ushort> value, Vector256<ushort> amin, Vector256<ushort> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YClamp(Vector256<int> value, Vector256<int> amin, Vector256<int> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YClamp(Vector256<uint> value, Vector256<uint> amin, Vector256<uint> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YClamp(Vector256<long> value, Vector256<long> amin, Vector256<long> amax) {
            return Statics.YClamp(value, amin, amax);
        }

        /// <inheritdoc cref="IWVectorTraits256.YClamp(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YClamp(Vector256<ulong> value, Vector256<ulong> amin, Vector256<ulong> amax) {
            return Statics.YClamp(value, amin, amax);
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsAllTrue_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsAllTrue_AcceleratedTypes {
            get {
                return Statics.YIsAllTrue_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsAllTrue{T}(Vector256{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual bool YIsAllTrue<T>(Vector256<T> value) where T : struct {
            return Statics.YIsAllTrue(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue_AcceleratedTypes"/>
        public virtual TypeCodeFlags YIsAnyTrue_AcceleratedTypes {
            get {
                return Statics.YIsAnyTrue_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YIsAnyTrue{T}(Vector256{T})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual bool YIsAnyTrue<T>(Vector256<T> value) where T : struct {
            return Statics.YIsAnyTrue(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate_AcceleratedTypes"/>
        public virtual TypeCodeFlags YNarrowSaturate_AcceleratedTypes {
            get {
                return Statics.YNarrowSaturate_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate_FullAcceleratedTypes"/>
        public virtual TypeCodeFlags YNarrowSaturate_FullAcceleratedTypes {
            get {
                return Statics.YNarrowSaturate_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{short}, Vector256{short})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YNarrowSaturate(Vector256<short> lower, Vector256<short> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{ushort}, Vector256{ushort})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YNarrowSaturate(Vector256<ushort> lower, Vector256<ushort> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{int}, Vector256{int})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YNarrowSaturate(Vector256<int> lower, Vector256<int> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{uint}, Vector256{uint})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YNarrowSaturate(Vector256<uint> lower, Vector256<uint> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{long}, Vector256{long})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YNarrowSaturate(Vector256<long> lower, Vector256<long> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturate(Vector256{ulong}, Vector256{ulong})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YNarrowSaturate(Vector256<ulong> lower, Vector256<ulong> upper) {
            return Statics.YNarrowSaturate(lower, upper);
        }


        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned_AcceleratedTypes"/>
        public virtual TypeCodeFlags YNarrowSaturateUnsigned_AcceleratedTypes {
            get {
                return Statics.YNarrowSaturateUnsigned_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned_FullAcceleratedTypes"/>
        public virtual TypeCodeFlags YNarrowSaturateUnsigned_FullAcceleratedTypes {
            get {
                return Statics.YNarrowSaturateUnsigned_FullAcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned(Vector256{short}, Vector256{short})" />
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YNarrowSaturateUnsigned(Vector256<short> lower, Vector256<short> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned(Vector256{int}, Vector256{int})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YNarrowSaturateUnsigned(Vector256<int> lower, Vector256<int> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }

        /// <inheritdoc cref="IWVectorTraits256.YNarrowSaturateUnsigned(Vector256{long}, Vector256{long})" />
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YNarrowSaturateUnsigned(Vector256<long> lower, Vector256<long> upper) {
            return Statics.YNarrowSaturateUnsigned(lower, upper);
        }


        /// <inheritdoc cref="IWVectorTraits256.YRoundToEven_AcceleratedTypes"/>
        public virtual TypeCodeFlags YRoundToEven_AcceleratedTypes {
            get {
                return Statics.YRoundToEven_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YRoundToEven(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YRoundToEven(Vector256<float> value) {
            return Statics.YRoundToEven(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YRoundToEven(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YRoundToEven(Vector256<double> value) {
            return Statics.YRoundToEven(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YRoundToZero_AcceleratedTypes"/>
        public virtual TypeCodeFlags YRoundToZero_AcceleratedTypes {
            get {
                return Statics.YRoundToZero_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YRoundToZero(Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YRoundToZero(Vector256<float> value) {
            return Statics.YRoundToZero(value);
        }

        /// <inheritdoc cref="IWVectorTraits256.YRoundToZero(Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YRoundToZero(Vector256<double> value) {
            return Statics.YRoundToZero(value);
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleG2_AcceleratedTypes {
            get {
                return Statics.YShuffleG2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{float}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleG2(Vector256<float> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{double}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleG2(Vector256<double> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{sbyte}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleG2(Vector256<sbyte> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{byte}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleG2(Vector256<byte> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{short}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleG2(Vector256<short> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{ushort}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleG2(Vector256<ushort> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{int}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleG2(Vector256<int> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{uint}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleG2(Vector256<uint> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{long}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleG2(Vector256<long> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2(Vector256{ulong}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleG2(Vector256<ulong> source, ShuffleControlG2 control) {
            return Statics.YShuffleG2(source, control);
        }

#if !REDUCE_MEMORY_USAGE
        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{float}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleG2_Const(Vector256<float> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{double}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleG2_Const(Vector256<double> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{sbyte}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleG2_Const(Vector256<sbyte> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{byte}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleG2_Const(Vector256<byte> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{short}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleG2_Const(Vector256<short> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{ushort}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleG2_Const(Vector256<ushort> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{int}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleG2_Const(Vector256<int> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{uint}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleG2_Const(Vector256<uint> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{long}, ShuffleControlG2)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleG2_Const(Vector256<long> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG2_Const(Vector256{ulong}, ShuffleControlG2)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleG2_Const(Vector256<ulong> source, [ConstantExpected] ShuffleControlG2 control) {
            return Statics.YShuffleG2_Const(source, control);
        }
#endif // !REDUCE_MEMORY_USAGE


        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleG4_AcceleratedTypes {
            get {
                return Statics.YShuffleG4_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleG4(Vector256<float> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{double}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleG4(Vector256<double> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleG4(Vector256<sbyte> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleG4(Vector256<byte> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleG4(Vector256<short> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleG4(Vector256<ushort> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleG4(Vector256<int> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleG4(Vector256<uint> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{long}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleG4(Vector256<long> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4(Vector256{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleG4(Vector256<ulong> source, ShuffleControlG4 control) {
            return Statics.YShuffleG4(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{float}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleG4_Const(Vector256<float> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{double}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleG4_Const(Vector256<double> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{sbyte}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleG4_Const(Vector256<sbyte> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{byte}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleG4_Const(Vector256<byte> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{short}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleG4_Const(Vector256<short> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{ushort}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleG4_Const(Vector256<ushort> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{int}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleG4_Const(Vector256<int> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{uint}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleG4_Const(Vector256<uint> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{long}, ShuffleControlG4)"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleG4_Const(Vector256<long> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4_Const(Vector256{ulong}, ShuffleControlG4)"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleG4_Const(Vector256<ulong> source, [ConstantExpected] ShuffleControlG4 control) {
            return Statics.YShuffleG4_Const(source, control);
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleG4X2_AcceleratedTypes {
            get {
                return Statics.YShuffleG4X2_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{float}, Vector256{float}, ShuffleControlG4, out Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleG4X2(Vector256<float> source0, Vector256<float> source1, ShuffleControlG4 control, out Vector256<float> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{double}, Vector256{double}, ShuffleControlG4, out Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleG4X2(Vector256<double> source0, Vector256<double> source1, ShuffleControlG4 control, out Vector256<double> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{sbyte}, Vector256{sbyte}, ShuffleControlG4, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleG4X2(Vector256<sbyte> source0, Vector256<sbyte> source1, ShuffleControlG4 control, out Vector256<sbyte> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{byte}, Vector256{byte}, ShuffleControlG4, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleG4X2(Vector256<byte> source0, Vector256<byte> source1, ShuffleControlG4 control, out Vector256<byte> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{short}, Vector256{short}, ShuffleControlG4, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleG4X2(Vector256<short> source0, Vector256<short> source1, ShuffleControlG4 control, out Vector256<short> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{ushort}, Vector256{ushort}, ShuffleControlG4, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleG4X2(Vector256<ushort> source0, Vector256<ushort> source1, ShuffleControlG4 control, out Vector256<ushort> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{int}, Vector256{int}, ShuffleControlG4, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleG4X2(Vector256<int> source0, Vector256<int> source1, ShuffleControlG4 control, out Vector256<int> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{uint}, Vector256{uint}, ShuffleControlG4, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleG4X2(Vector256<uint> source0, Vector256<uint> source1, ShuffleControlG4 control, out Vector256<uint> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{long}, Vector256{long}, ShuffleControlG4, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleG4X2(Vector256<long> source0, Vector256<long> source1, ShuffleControlG4 control, out Vector256<long> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2(Vector256{ulong}, Vector256{ulong}, ShuffleControlG4, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleG4X2(Vector256<ulong> source0, Vector256<ulong> source1, ShuffleControlG4 control, out Vector256<ulong> result1) {
            return Statics.YShuffleG4X2(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{float}, Vector256{float}, ShuffleControlG4, out Vector256{float})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleG4X2_Const(Vector256<float> source0, Vector256<float> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<float> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{double}, Vector256{double}, ShuffleControlG4, out Vector256{double})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleG4X2_Const(Vector256<double> source0, Vector256<double> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<double> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{sbyte}, Vector256{sbyte}, ShuffleControlG4, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleG4X2_Const(Vector256<sbyte> source0, Vector256<sbyte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<sbyte> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{byte}, Vector256{byte}, ShuffleControlG4, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleG4X2_Const(Vector256<byte> source0, Vector256<byte> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<byte> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{short}, Vector256{short}, ShuffleControlG4, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleG4X2_Const(Vector256<short> source0, Vector256<short> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<short> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{ushort}, Vector256{ushort}, ShuffleControlG4, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleG4X2_Const(Vector256<ushort> source0, Vector256<ushort> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<ushort> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{int}, Vector256{int}, ShuffleControlG4, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleG4X2_Const(Vector256<int> source0, Vector256<int> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<int> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{uint}, Vector256{uint}, ShuffleControlG4, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleG4X2_Const(Vector256<uint> source0, Vector256<uint> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<uint> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{long}, Vector256{long}, ShuffleControlG4, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleG4X2_Const(Vector256<long> source0, Vector256<long> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<long> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleG4X2_Const(Vector256{ulong}, Vector256{ulong}, ShuffleControlG4, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleG4X2_Const(Vector256<ulong> source0, Vector256<ulong> source1, [ConstantExpected] ShuffleControlG4 control, out Vector256<ulong> result1) {
            return Statics.YShuffleG4X2_Const(source0, source1, control, out result1);
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleInsert_AcceleratedTypes {
            get {
                return Statics.YShuffleInsert_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{float}, Vector256{float}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleInsert(Vector256<float> back, Vector256<float> vector, Vector256<int> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{double}, Vector256{double}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleInsert(Vector256<double> back, Vector256<double> vector, Vector256<long> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleInsert(Vector256<sbyte> back, Vector256<sbyte> vector, Vector256<sbyte> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleInsert(Vector256<byte> back, Vector256<byte> vector, Vector256<byte> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleInsert(Vector256<short> back, Vector256<short> vector, Vector256<short> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleInsert(Vector256<ushort> back, Vector256<ushort> vector, Vector256<ushort> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleInsert(Vector256<int> back, Vector256<int> vector, Vector256<int> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleInsert(Vector256<uint> back, Vector256<uint> vector, Vector256<uint> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleInsert(Vector256<long> back, Vector256<long> vector, Vector256<long> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleInsert(Vector256<ulong> back, Vector256<ulong> vector, Vector256<ulong> indices) {
            return Statics.YShuffleInsert(back, vector, indices);
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1, out Vector256<sbyte> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1, out Vector256<byte> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{short}, out Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1, out Vector256<short> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1, out Vector256<ushort> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{int}, out Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1, out Vector256<int> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1, out Vector256<uint> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{long}, out Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1, out Vector256<long> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleInsert_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1, out Vector256<ulong> args2) {
            Statics.YShuffleInsert_Args(indices, out args0, out args1, out args2);
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{float}, Vector256{float}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleInsert_Core(Vector256<float> back, Vector256<float> vector, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{double}, Vector256{double}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleInsert_Core(Vector256<double> back, Vector256<double> vector, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleInsert_Core(Vector256<sbyte> back, Vector256<sbyte> vector, Vector256<sbyte> args0, Vector256<sbyte> args1, Vector256<sbyte> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleInsert_Core(Vector256<byte> back, Vector256<byte> vector, Vector256<byte> args0, Vector256<byte> args1, Vector256<byte> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleInsert_Core(Vector256<short> back, Vector256<short> vector, Vector256<short> args0, Vector256<short> args1, Vector256<short> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleInsert_Core(Vector256<ushort> back, Vector256<ushort> vector, Vector256<ushort> args0, Vector256<ushort> args1, Vector256<ushort> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleInsert_Core(Vector256<int> back, Vector256<int> vector, Vector256<int> args0, Vector256<int> args1, Vector256<int> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleInsert_Core(Vector256<uint> back, Vector256<uint> vector, Vector256<uint> args0, Vector256<uint> args1, Vector256<uint> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleInsert_Core(Vector256<long> back, Vector256<long> vector, Vector256<long> args0, Vector256<long> args1, Vector256<long> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleInsert_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleInsert_Core(Vector256<ulong> back, Vector256<ulong> vector, Vector256<ulong> args0, Vector256<ulong> args1, Vector256<ulong> args2) {
            return Statics.YShuffleInsert_Core(back, vector, args0, args1, args2);
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_AcceleratedTypes"/>
        public virtual TypeCodeFlags YShuffleKernel_AcceleratedTypes {
            get {
                return Statics.YShuffleKernel_AcceleratedTypes;
            }
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{float}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleKernel(Vector256<float> vector, Vector256<int> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{double}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleKernel(Vector256<double> vector, Vector256<long> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleKernel(Vector256<sbyte> vector, Vector256<sbyte> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleKernel(Vector256<byte> vector, Vector256<byte> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleKernel(Vector256<short> vector, Vector256<short> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleKernel(Vector256<ushort> vector, Vector256<ushort> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleKernel(Vector256<int> vector, Vector256<int> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleKernel(Vector256<uint> vector, Vector256<uint> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleKernel(Vector256<long> vector, Vector256<long> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel(Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleKernel(Vector256<ulong> vector, Vector256<ulong> indices) {
            return Statics.YShuffleKernel(vector, indices);
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{sbyte}, out Vector256{sbyte}, out Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector256<sbyte> indices, out Vector256<sbyte> args0, out Vector256<sbyte> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{byte}, out Vector256{byte}, out Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector256<byte> indices, out Vector256<byte> args0, out Vector256<byte> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{short}, out Vector256{short}, out Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector256<short> indices, out Vector256<short> args0, out Vector256<short> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{ushort}, out Vector256{ushort}, out Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector256<ushort> indices, out Vector256<ushort> args0, out Vector256<ushort> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{int}, out Vector256{int}, out Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector256<int> indices, out Vector256<int> args0, out Vector256<int> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{uint}, out Vector256{uint}, out Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector256<uint> indices, out Vector256<uint> args0, out Vector256<uint> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{long}, out Vector256{long}, out Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector256<long> indices, out Vector256<long> args0, out Vector256<long> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Args(Vector256{ulong}, out Vector256{ulong}, out Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual void YShuffleKernel_Args(Vector256<ulong> indices, out Vector256<ulong> args0, out Vector256<ulong> args1) {
            Statics.YShuffleKernel_Args(indices, out args0, out args1);
        }


        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{float}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<float> YShuffleKernel_Core(Vector256<float> vector, Vector256<int> args0, Vector256<int> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{double}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<double> YShuffleKernel_Core(Vector256<double> vector, Vector256<long> args0, Vector256<long> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{sbyte}, Vector256{sbyte}, Vector256{sbyte})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<sbyte> YShuffleKernel_Core(Vector256<sbyte> vector, Vector256<sbyte> args0, Vector256<sbyte> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{byte}, Vector256{byte}, Vector256{byte})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<byte> YShuffleKernel_Core(Vector256<byte> vector, Vector256<byte> args0, Vector256<byte> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{short}, Vector256{short}, Vector256{short})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<short> YShuffleKernel_Core(Vector256<short> vector, Vector256<short> args0, Vector256<short> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{ushort}, Vector256{ushort}, Vector256{ushort})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ushort> YShuffleKernel_Core(Vector256<ushort> vector, Vector256<ushort> args0, Vector256<ushort> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{int}, Vector256{int}, Vector256{int})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<int> YShuffleKernel_Core(Vector256<int> vector, Vector256<int> args0, Vector256<int> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{uint}, Vector256{uint}, Vector256{uint})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<uint> YShuffleKernel_Core(Vector256<uint> vector, Vector256<uint> args0, Vector256<uint> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{long}, Vector256{long}, Vector256{long})"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<long> YShuffleKernel_Core(Vector256<long> vector, Vector256<long> args0, Vector256<long> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

        /// <inheritdoc cref="IWVectorTraits256.YShuffleKernel_Core(Vector256{ulong}, Vector256{ulong}, Vector256{ulong})"/>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public virtual Vector256<ulong> YShuffleKernel_Core(Vector256<ulong> vector, Vector256<ulong> args0, Vector256<ulong> args1) {
            return Statics.YShuffleKernel_Core(vector, args0, args1);
        }

#endif
    }
}
