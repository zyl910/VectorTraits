using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using System.Text;
using Zyl.VectorTraits.Extensions;
using Zyl.VectorTraits.Extensions.SameW;
using Zyl.VectorTraits.Impl.AVector256;

namespace Zyl.VectorTraits.Impl.AVector {
    using WStatics = WVectorTraits256Avx2.Statics;
    using BaseStatics = VectorTraitsBase.Statics;

    partial class VectorTraits256Avx2 {
#if NETCOREAPP3_0_OR_GREATER
        partial class Statics {

            /// <inheritdoc cref="IVectorTraits.Add_AcceleratedTypes"/>
            public static TypeCodeFlags Add_AcceleratedTypes {
                get {
                    return WStatics.Add_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Add(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Add(Vector<float> left, Vector<float> right) {
                return Vector.Add(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Add(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Add(Vector<double> left, Vector<double> right) {
                return Vector.Add(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Add(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> Add(Vector<sbyte> left, Vector<sbyte> right) {
                return Vector.Add(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Add(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> Add(Vector<byte> left, Vector<byte> right) {
                return Vector.Add(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Add(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> Add(Vector<short> left, Vector<short> right) {
                return Vector.Add(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Add(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> Add(Vector<ushort> left, Vector<ushort> right) {
                return Vector.Add(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Add(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> Add(Vector<int> left, Vector<int> right) {
                return Vector.Add(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Add(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> Add(Vector<uint> left, Vector<uint> right) {
                return Vector.Add(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Add(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> Add(Vector<long> left, Vector<long> right) {
                return Vector.Add(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Add(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> Add(Vector<ulong> left, Vector<ulong> right) {
                return Vector.Add(left, right);
            }


            /// <inheritdoc cref="IVectorTraits.Dot_AcceleratedTypes"/>
            public static TypeCodeFlags Dot_AcceleratedTypes {
                get {
                    return WStatics.Dot_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Dot(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static float Dot(Vector<float> left, Vector<float> right) {
                return WStatics.Dot(left.AsVector256(), right.AsVector256());
            }

            /// <inheritdoc cref="IVectorTraits.Dot(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Dot(Vector<double> left, Vector<double> right) {
                return WStatics.Dot(left.AsVector256(), right.AsVector256());
            }

            /// <inheritdoc cref="IVectorTraits.Dot(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static sbyte Dot(Vector<sbyte> left, Vector<sbyte> right) {
                return WStatics.Dot(left.AsVector256(), right.AsVector256());
            }

            /// <inheritdoc cref="IVectorTraits.Dot(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static byte Dot(Vector<byte> left, Vector<byte> right) {
                return WStatics.Dot(left.AsVector256(), right.AsVector256());
            }

            /// <inheritdoc cref="IVectorTraits.Dot(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static short Dot(Vector<short> left, Vector<short> right) {
                return WStatics.Dot(left.AsVector256(), right.AsVector256());
            }

            /// <inheritdoc cref="IVectorTraits.Dot(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ushort Dot(Vector<ushort> left, Vector<ushort> right) {
                return WStatics.Dot(left.AsVector256(), right.AsVector256());
            }

            /// <inheritdoc cref="IVectorTraits.Dot(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static int Dot(Vector<int> left, Vector<int> right) {
                return WStatics.Dot(left.AsVector256(), right.AsVector256());
            }

            /// <inheritdoc cref="IVectorTraits.Dot(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static uint Dot(Vector<uint> left, Vector<uint> right) {
                return WStatics.Dot(left.AsVector256(), right.AsVector256());
            }

            /// <inheritdoc cref="IVectorTraits.Dot(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static long Dot(Vector<long> left, Vector<long> right) {
                return WStatics.Dot(left.AsVector256(), right.AsVector256());
            }

            /// <inheritdoc cref="IVectorTraits.Dot(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static ulong Dot(Vector<ulong> left, Vector<ulong> right) {
                return WStatics.Dot(left.AsVector256(), right.AsVector256());
            }


            /// <inheritdoc cref="IVectorTraits.Multiply_AcceleratedTypes"/>
            public static TypeCodeFlags Multiply_AcceleratedTypes {
                get {
                    return WStatics.Multiply_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Multiply_FullAcceleratedTypes"/>
            public static TypeCodeFlags Multiply_FullAcceleratedTypes {
                get {
                    return WStatics.Multiply_FullAcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{float}, Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Multiply(Vector<float> left, Vector<float> right) {
                return BaseStatics.Multiply(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Multiply(Vector<double> left, Vector<double> right) {
                return BaseStatics.Multiply(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{sbyte}, Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> Multiply(Vector<sbyte> left, Vector<sbyte> right) {
                return WStatics.Multiply(left.AsVector256(), right.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{byte}, Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> Multiply(Vector<byte> left, Vector<byte> right) {
                return WStatics.Multiply(left.AsVector256(), right.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{short}, Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> Multiply(Vector<short> left, Vector<short> right) {
                return BaseStatics.Multiply(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{ushort}, Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> Multiply(Vector<ushort> left, Vector<ushort> right) {
                return BaseStatics.Multiply(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{int}, Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> Multiply(Vector<int> left, Vector<int> right) {
                return BaseStatics.Multiply(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{uint}, Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> Multiply(Vector<uint> left, Vector<uint> right) {
                return BaseStatics.Multiply(left, right);
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{long}, Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> Multiply(Vector<long> left, Vector<long> right) {
                return WStatics.Multiply(left.AsVector256(), right.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{ulong}, Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> Multiply(Vector<ulong> left, Vector<ulong> right) {
                return WStatics.Multiply(left.AsVector256(), right.AsVector256()).AsVector();
            }


            /// <inheritdoc cref="IVectorTraits.Sqrt_AcceleratedTypes"/>
            public static TypeCodeFlags Sqrt_AcceleratedTypes {
                get {
                    return WStatics.Sqrt_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Sqrt(Vector<float> value) {
                return WStatics.Sqrt(value.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Sqrt(Vector<double> value) {
                return WStatics.Sqrt(value.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> Sqrt(Vector<sbyte> value) {
                return WStatics.Sqrt(value.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> Sqrt(Vector<byte> value) {
                return WStatics.Sqrt(value.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> Sqrt(Vector<short> value) {
                return WStatics.Sqrt(value.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> Sqrt(Vector<ushort> value) {
                return WStatics.Sqrt(value.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> Sqrt(Vector<int> value) {
                return WStatics.Sqrt(value.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> Sqrt(Vector<uint> value) {
                return WStatics.Sqrt(value.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> Sqrt(Vector<long> value) {
                return WStatics.Sqrt(value.AsVector256()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> Sqrt(Vector<ulong> value) {
                return WStatics.Sqrt(value.AsVector256()).AsVector();
            }

        }
#endif // NETCOREAPP3_0_OR_GREATER
    }
}
