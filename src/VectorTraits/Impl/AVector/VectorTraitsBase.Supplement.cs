#define Sqrt_Float_Used

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


            /// <inheritdoc cref="IVectorTraits.Sqrt_AcceleratedTypes"/>
            public static TypeCodeFlags Sqrt_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    if (Vector.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.Single;
#if Sqrt_Float_Used
                        rt |= TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16;
#endif
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Sqrt(Vector<float> value) {
                return Vector.SquareRoot(value);
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Sqrt(Vector<double> value) {
                return Vector.SquareRoot(value);
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> Sqrt(Vector<sbyte> value) {
#if Sqrt_Float_Used
                return Sqrt_Float(value);
#else
                return Vector.SquareRoot(value);
#endif
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> Sqrt(Vector<byte> value) {
#if Sqrt_Float_Used
                return Sqrt_Float(value);
#else
                return Vector.SquareRoot(value);
#endif
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> Sqrt(Vector<short> value) {
#if Sqrt_Float_Used
                return Sqrt_Float(value);
#else
                return Vector.SquareRoot(value);
#endif
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> Sqrt(Vector<ushort> value) {
#if Sqrt_Float_Used
                return Sqrt_Float(value);
#else
                return Vector.SquareRoot(value);
#endif
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> Sqrt(Vector<int> value) {
#if Sqrt_Float_Used
                return Sqrt_Float(value);
#else
                return Vector.SquareRoot(value);
#endif
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> Sqrt(Vector<uint> value) {
#if Sqrt_Float_Used
                return Sqrt_Float(value);
#else
                return Vector.SquareRoot(value);
#endif
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> Sqrt(Vector<long> value) {
#if Sqrt_Float_Used
                return Sqrt_Float(value);
#else
                return Vector.SquareRoot(value);
#endif
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> Sqrt(Vector<ulong> value) {
#if Sqrt_Float_Used
                return Sqrt_Float(value);
#else
                return Vector.SquareRoot(value);
#endif
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> Sqrt_Float(Vector<sbyte> value) {
                Vector<sbyte> mask = Vector.GreaterThan(Vector<sbyte>.Zero, value); // 0>x = x<0.
                Vector<sbyte> temp = Sqrt_Float(value.AsByte()).AsSByte();
                Vector<sbyte> rt = Vector.AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> Sqrt_Float(Vector<byte> value) {
                // To float
                Widen(value, out Vector<ushort> t0, out Vector<ushort> t1);
                Widen(t0, out Vector<uint> w0, out Vector<uint> w1);
                Widen(t1, out Vector<uint> w2, out Vector<uint> w3);
                Vector<float> src0 = ConvertToSingle(w0.AsInt32()); // On x86 platforms, Int32 typically has special instructions to speed up, which is faster than UInt32.
                Vector<float> src1 = ConvertToSingle(w1.AsInt32());
                Vector<float> src2 = ConvertToSingle(w2.AsInt32());
                Vector<float> src3 = ConvertToSingle(w3.AsInt32());
                // Body
                Vector<float> dst0 = Vector.SquareRoot(src0);
                Vector<float> dst1 = Vector.SquareRoot(src1);
                Vector<float> dst2 = Vector.SquareRoot(src2);
                Vector<float> dst3 = Vector.SquareRoot(src3);
                // To int
                w0 = ConvertToInt32(dst0).AsUInt32();
                w1 = ConvertToInt32(dst1).AsUInt32();
                w2 = ConvertToInt32(dst2).AsUInt32();
                w3 = ConvertToInt32(dst3).AsUInt32();
                t0 = Narrow(w0, w1);
                t1 = Narrow(w2, w3);
                Vector<byte> rt = Narrow(t0, t1);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> Sqrt_Float(Vector<short> value) {
                Vector<short> mask = Vector.GreaterThan(Vector<short>.Zero, value); // 0>x = x<0.
                Vector<short> temp = Sqrt_Float(value.AsUInt16()).AsInt16();
                Vector<short> rt = Vector.AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> Sqrt_Float(Vector<ushort> value) {
                // To float
                Widen(value, out Vector<uint> w0, out Vector<uint> w1);
                Vector<float> src0 = ConvertToSingle(w0.AsInt32());
                Vector<float> src1 = ConvertToSingle(w1.AsInt32());
                // Body
                Vector<float> dst0 = Vector.SquareRoot(src0);
                Vector<float> dst1 = Vector.SquareRoot(src1);
                // To int
                w0 = ConvertToInt32(dst0).AsUInt32();
                w1 = ConvertToInt32(dst1).AsUInt32();
                Vector<ushort> rt = Narrow(w0, w1);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> Sqrt_Float(Vector<int> value) {
                Vector<int> mask = Vector.GreaterThan(Vector<int>.Zero, value); // 0>x = x<0.
                Vector<int> temp = Sqrt_Float(value.AsUInt32()).AsInt32();
                Vector<int> rt = Vector.AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> Sqrt_Float(Vector<uint> value) {
                // To float
                Widen(value, out Vector<ulong> w0, out Vector<ulong> w1);
                Vector<double> src0 = ConvertToDouble_Range52(w0);
                Vector<double> src1 = ConvertToDouble_Range52(w1);
                // Body
                Vector<double> dst0 = Vector.SquareRoot(src0);
                Vector<double> dst1 = Vector.SquareRoot(src1);
                // To int
                w0 = ConvertToUInt64_Range52(dst0);
                w1 = ConvertToUInt64_Range52(dst1);
                Vector<uint> rt = Narrow(w0, w1);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> Sqrt_Float(Vector<long> value) {
                Vector<long> mask = Vector.GreaterThan(Vector<long>.Zero, value); // 0>x = x<0.
                Vector<long> temp = Sqrt_Float(value.AsUInt64()).AsInt64();
                Vector<long> rt = Vector.AndNot(temp, mask);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> Sqrt_Float(Vector<ulong> value) {
                // To float
                Vector<double> src0 = ConvertToDouble(value);
                // Body
                Vector<double> dst0 = Vector.SquareRoot(src0);
                // To int
                Vector<ulong> rt = ConvertToUInt64_Range52(dst0); // `Math.Ceiling(Math.Log2(Math.Sqrt(ulong.MaxValue))) = 32`. It less 52bit.
                return rt;
            }

        }
    }
}
