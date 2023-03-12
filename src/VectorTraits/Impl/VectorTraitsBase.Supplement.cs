using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.Numerics;
using Zyl.VectorTraits.Extensions.SameW;

namespace Zyl.VectorTraits.Impl {

    partial class VectorTraitsBase {

        partial class Statics {


            /// <inheritdoc cref="IVectorTraits.Multiply_AcceleratedTypes"/>
            public static TypeCodeFlags Multiply_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Multiply_FullAcceleratedTypes"/>
            public static TypeCodeFlags Multiply_FullAcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Multiply(Vector<float> left, Vector<float> right) {
                return Vector.Multiply(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Multiply(Vector<double> left, Vector<double> right) {
                return Vector.Multiply(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> Multiply(Vector<sbyte> left, Vector<sbyte> right) {
                return Vector.Multiply(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> Multiply(Vector<byte> left, Vector<byte> right) {
                return Vector.Multiply(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> Multiply(Vector<short> left, Vector<short> right) {
                return Vector.Multiply(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> Multiply(Vector<ushort> left, Vector<ushort> right) {
                return Vector.Multiply(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> Multiply(Vector<int> left, Vector<int> right) {
                return Vector.Multiply(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> Multiply(Vector<uint> left, Vector<uint> right) {
                return Vector.Multiply(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> Multiply(Vector<long> left, Vector<long> right) {
                return Vector.Multiply(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> Multiply(Vector<ulong> left, Vector<ulong> right) {
                return Vector.Multiply(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> Multiply_Widen(Vector<sbyte> left, Vector<sbyte> right) {
                return Multiply_Widen(left.AsByte(), right.AsByte()).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> Multiply_Widen(Vector<byte> left, Vector<byte> right) {
                Vector.Widen(left, out Vector<ushort> u0, out Vector<ushort> u1);
                Vector.Widen(right, out Vector<ushort> v0, out Vector<ushort> v1);
                Vector<ushort> w0 = Vector.Multiply(u0, v0);
                Vector<ushort> w1 = Vector.Multiply(u1, v1);
                Vector<byte> rt = Vector.Narrow(w0, w1);
                return rt;
            }


        }
    }
}
