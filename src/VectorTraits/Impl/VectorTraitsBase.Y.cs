using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.Numerics;
using Zyl.VectorTraits.Extensions.SameW;

namespace Zyl.VectorTraits.Impl {

    partial class VectorTraitsBase {

        partial class Statics {

            /// <inheritdoc cref="IVectorTraits.YClamp_AcceleratedTypes"/>
            public static TypeCodeFlags YClamp_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    if (Vector.IsHardwareAccelerated) {
                        rt = TypeCodeFlagsUtil.AllTypes;
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{float}, Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> YClamp(Vector<float> value, Vector<float> amin, Vector<float> amax) {
                return Vector.Min(Vector.Max(amin, value), amax);
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{double}, Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> YClamp(Vector<double> value, Vector<double> amin, Vector<double> amax) {
                return Vector.Min(Vector.Max(amin, value), amax);
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{sbyte}, Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> YClamp(Vector<sbyte> value, Vector<sbyte> amin, Vector<sbyte> amax) {
                return Vector.Min(Vector.Max(amin, value), amax);
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{byte}, Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> YClamp(Vector<byte> value, Vector<byte> amin, Vector<byte> amax) {
                return Vector.Min(Vector.Max(amin, value), amax);
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{short}, Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> YClamp(Vector<short> value, Vector<short> amin, Vector<short> amax) {
                return Vector.Min(Vector.Max(amin, value), amax);
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{ushort}, Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> YClamp(Vector<ushort> value, Vector<ushort> amin, Vector<ushort> amax) {
                return Vector.Min(Vector.Max(amin, value), amax);
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{int}, Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> YClamp(Vector<int> value, Vector<int> amin, Vector<int> amax) {
                return Vector.Min(Vector.Max(amin, value), amax);
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{uint}, Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> YClamp(Vector<uint> value, Vector<uint> amin, Vector<uint> amax) {
                return Vector.Min(Vector.Max(amin, value), amax);
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{long}, Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> YClamp(Vector<long> value, Vector<long> amin, Vector<long> amax) {
                return Vector.Min(Vector.Max(amin, value), amax);
            }

            /// <inheritdoc cref="IVectorTraits.YClamp(Vector{ulong}, Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> YClamp(Vector<ulong> value, Vector<ulong> amin, Vector<ulong> amax) {
                return Vector.Min(Vector.Max(amin, value), amax);
            }


        }
    }
}
