using System;
using System.Diagnostics.CodeAnalysis;
#if !NET7_0_OR_GREATER
using Zyl.VectorTraits.Fake.Diagnostics.CodeAnalysis;
#endif // !NET7_0_OR_GREATER
using System.Numerics;
using System.Runtime.CompilerServices;
#if NETCOREAPP3_0_OR_GREATER
using System.Runtime.Intrinsics;
#endif
using Zyl.VectorTraits.Impl.AVector128;

namespace Zyl.VectorTraits.Impl.AVector {
    using WStatics = WVectorTraits128AdvSimdB64.Statics;
    using BaseStatics = VectorTraits128Base.Statics;

    partial class VectorTraits128AdvSimdB64 {
#if NET5_0_OR_GREATER
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

            /// <inheritdoc cref="IVectorTraits.Dot(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static double Dot(Vector<double> left, Vector<double> right) {
                return WStatics.Dot(left.AsVector128(), right.AsVector128());
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

            /// <inheritdoc cref="IVectorTraits.Multiply(Vector{double}, Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Multiply(Vector<double> left, Vector<double> right) {
                return WStatics.Multiply(left.AsVector128(), right.AsVector128()).AsVector();
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
                return WStatics.Sqrt(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Sqrt(Vector<double> value) {
                return WStatics.Sqrt(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{sbyte})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> Sqrt(Vector<sbyte> value) {
                return WStatics.Sqrt(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{byte})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> Sqrt(Vector<byte> value) {
                return WStatics.Sqrt(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{short})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> Sqrt(Vector<short> value) {
                return WStatics.Sqrt(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> Sqrt(Vector<ushort> value) {
                return WStatics.Sqrt(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> Sqrt(Vector<int> value) {
                return WStatics.Sqrt(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> Sqrt(Vector<uint> value) {
                return WStatics.Sqrt(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> Sqrt(Vector<long> value) {
                return WStatics.Sqrt(value.AsVector128()).AsVector();
            }

            /// <inheritdoc cref="IVectorTraits.Sqrt(Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> Sqrt(Vector<ulong> value) {
                return WStatics.Sqrt(value.AsVector128()).AsVector();
            }

        }
#endif // NET5_0_OR_GREATER
    }
}
