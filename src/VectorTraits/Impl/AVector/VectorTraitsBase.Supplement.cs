using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.Numerics;
using Zyl.VectorTraits.Extensions.SameW;

namespace Zyl.VectorTraits.Impl.AVector {

    partial class VectorTraitsBase {

        partial class Statics {


            /// <inheritdoc cref="IVectorTraits.Dot_AcceleratedTypes"/>
            public static TypeCodeFlags Dot_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.Single | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Dot(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Dot(Vector<float> left, Vector<float> right) {
                return Vector.Dot(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Dot(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Dot(Vector<double> left, Vector<double> right) {
                return Vector.Dot(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Dot(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Dot(Vector<sbyte> left, Vector<sbyte> right) {
                return Vector.Dot(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Dot(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Dot(Vector<byte> left, Vector<byte> right) {
                return Vector.Dot(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Dot(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Dot(Vector<short> left, Vector<short> right) {
                return Vector.Dot(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Dot(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Dot(Vector<ushort> left, Vector<ushort> right) {
                return (ushort)Vector.Dot(left.AsInt16(), right.AsInt16());
            }

            /// <inheritdoc cref="IVectorTraits.Dot(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Dot(Vector<int> left, Vector<int> right) {
                return Vector.Dot(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Dot(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Dot(Vector<uint> left, Vector<uint> right) {
                return (uint)Vector.Dot(left.AsInt32(), right.AsInt32());
            }

            /// <inheritdoc cref="IVectorTraits.Dot(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Dot(Vector<long> left, Vector<long> right) {
                return Vector.Dot(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Dot(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Dot(Vector<ulong> left, Vector<ulong> right) {
                return Vector.Dot(left, right);
            }


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
                return Multiply(left.AsInt16(), right.AsInt16()).AsUInt16();
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
                return Multiply(left.AsInt32(), right.AsInt32()).AsUInt32();
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
                // It only outperformed `Vector.Multiply` on net6 (实测发现它在 net6 下的性能才超过 `Vector.Multiply`)
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
