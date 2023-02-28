using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.Numerics;
using Zyl.VectorTraits.Extensions.SameW;
using Zyl.VectorTraits.Impl.Util;

namespace Zyl.VectorTraits.Impl {
    using BaseStatics = VectorTraitsBase.Statics;

    /// <summary>
    /// <see cref="Vector{T}"/> traits 128 - base.
    /// </summary>
    public sealed partial class VectorTraits128Base : VectorTraits128Abstract {
        private static readonly VectorTraits128Base _instance = new VectorTraits128Base(); // Default instance.

        /// <summary>Default instance. </summary>
        public static VectorTraits128Base Instance {
            get { return _instance; }
        }

        /// <summary>
        /// <see cref="Vector{T}"/> traits.Statics 128 - base.
        /// </summary>
        public static partial class Statics {

            /// <inheritdoc cref="IBaseTraits.ByteCount"/>
            public static int ByteCount {
                get { return ByteCountValue; }
            }

            /// <inheritdoc cref="IBaseTraits.IsSupported"/>
            public static bool IsSupported {
                get {
                    return GetIsSupported();
                }
            }

            /// <inheritdoc cref="IBaseTraits.GetIsSupported"/>
            public static bool GetIsSupported(bool noStrict = false) {
                bool rt = (Vector<byte>.Count == ByteCountValue);
                if (!noStrict) {
                }
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
            public static string GetUnsupportedMessage(bool noStrict = false) {
                string rt = string.Format("Vector byte size mismatch({0}!={1}) !", Vector<byte>.Count, ByteCountValue);
                if (!noStrict) {
                }
                return rt;
            }

            /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
            public static void ThrowForUnsupported(bool noStrict = false) {
                if (GetIsSupported(noStrict)) return;
                throw new NotSupportedException(GetUnsupportedMessage(noStrict));
            }


            /// <inheritdoc cref="IVectorTraits.Ceiling_AcceleratedTypes"/>
            public static TypeCodeFlags Ceiling_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    if (Vector.IsHardwareAccelerated) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Ceiling(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Ceiling(Vector<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector.Ceiling(value);
#else
                return Ceiling_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.Ceiling(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Ceiling(Vector<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector.Ceiling(value);
#else
                return Ceiling_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.Ceiling(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<float> Ceiling_Base(Vector<float> value) {
                Vector<float> rt = value;
                float* p = (float*)&rt;
#if NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                p[0] = MathF.Ceiling(p[0]);
                p[1] = MathF.Ceiling(p[1]);
                p[2] = MathF.Ceiling(p[2]);
                p[3] = MathF.Ceiling(p[3]);
#else
                p[0] = (float)Math.Ceiling(p[0]);
                p[1] = (float)Math.Ceiling(p[1]);
                p[2] = (float)Math.Ceiling(p[2]);
                p[3] = (float)Math.Ceiling(p[3]);
#endif // NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Ceiling(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<double> Ceiling_Base(Vector<double> value) {
                Vector<double> rt = value;
                double* p = (double*)&rt;
                p[0] = Math.Ceiling(p[0]);
                p[1] = Math.Ceiling(p[1]);
                return rt;
            }


            /// <inheritdoc cref="IVectorTraits.Floor_AcceleratedTypes"/>
            public static TypeCodeFlags Floor_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    if (Vector.IsHardwareAccelerated) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Floor(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Floor(Vector<float> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector.Floor(value);
#else
                return Floor_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.Floor(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Floor(Vector<double> value) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector.Floor(value);
#else
                return Floor_Base(value);
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.Floor(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<float> Floor_Base(Vector<float> value) {
                Vector<float> rt = value;
                float* p = (float*)&rt;
#if NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                p[0] = MathF.Floor(p[0]);
                p[1] = MathF.Floor(p[1]);
                p[2] = MathF.Floor(p[2]);
                p[3] = MathF.Floor(p[3]);
#else
                p[0] = (float)Math.Floor(p[0]);
                p[1] = (float)Math.Floor(p[1]);
                p[2] = (float)Math.Floor(p[2]);
                p[3] = (float)Math.Floor(p[3]);
#endif // NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Floor(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<double> Floor_Base(Vector<double> value) {
                Vector<double> rt = value;
                double* p = (double*)&rt;
                p[0] = Math.Floor(p[0]);
                p[1] = Math.Floor(p[1]);
                return rt;
            }


            /// <inheritdoc cref="IVectorTraits.ShiftLeft_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftLeft_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    if (Vector.IsHardwareAccelerated) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
#endif // BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
#if SOFTWARE_OPTIMIZATION
                        rt |= TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
#endif // SOFTWARE_OPTIMIZATION
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeft(Vector<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft(Vector<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft(Vector<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeft(Vector<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft(Vector<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeft(Vector<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftLeft(Vector<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeft(Vector<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeft(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<sbyte> ShiftLeft_Base(Vector<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<byte> ShiftLeft_Base(Vector<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<short> ShiftLeft_Base(Vector<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<ushort> ShiftLeft_Base(Vector<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<int> ShiftLeft_Base(Vector<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<uint> ShiftLeft_Base(Vector<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<long> ShiftLeft_Base(Vector<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<ulong> ShiftLeft_Base(Vector<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeftFast(Vector<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeftFast(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeftFast(Vector<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET_X_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeftFast(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeftFast(Vector<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeftFast(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeftFast(Vector<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeftFast(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeftFast(Vector<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeftFast(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeftFast(Vector<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeftFast(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftLeftFast(Vector<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeftFast(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeftFast(Vector<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_FIXED && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return BaseStatics.ShiftLeftFast(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeftFast_Base(Vector<sbyte> value, int shiftAmount) {
                return ShiftLeftFast_Base(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<byte> ShiftLeftFast_Base(Vector<byte> value, int shiftAmount) {
                Vector<byte> rt = value;
                byte* p = (byte*)&rt;
                p[0] <<= shiftAmount;
                p[1] <<= shiftAmount;
                p[2] <<= shiftAmount;
                p[3] <<= shiftAmount;
                p[4] <<= shiftAmount;
                p[5] <<= shiftAmount;
                p[6] <<= shiftAmount;
                p[7] <<= shiftAmount;
                p[8] <<= shiftAmount;
                p[9] <<= shiftAmount;
                p[10] <<= shiftAmount;
                p[11] <<= shiftAmount;
                p[12] <<= shiftAmount;
                p[13] <<= shiftAmount;
                p[14] <<= shiftAmount;
                p[15] <<= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<short> ShiftLeftFast_Base(Vector<short> value, int shiftAmount) {
                Vector<short> rt = value;
                short* p = (short*)&rt;
                p[0] <<= shiftAmount;
                p[1] <<= shiftAmount;
                p[2] <<= shiftAmount;
                p[3] <<= shiftAmount;
                p[4] <<= shiftAmount;
                p[5] <<= shiftAmount;
                p[6] <<= shiftAmount;
                p[7] <<= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeftFast_Base(Vector<ushort> value, int shiftAmount) {
                return ShiftLeftFast_Base(value.AsInt16(), shiftAmount).AsUInt16();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<int> ShiftLeftFast_Base(Vector<int> value, int shiftAmount) {
                Vector<int> rt = value;
                int* p = (int*)&rt;
                p[0] <<= shiftAmount;
                p[1] <<= shiftAmount;
                p[2] <<= shiftAmount;
                p[3] <<= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeftFast_Base(Vector<uint> value, int shiftAmount) {
                return ShiftLeftFast_Base(value.AsInt32(), shiftAmount).AsUInt32();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<long> ShiftLeftFast_Base(Vector<long> value, int shiftAmount) {
                Vector<long> rt = value;
                long* p = (long*)&rt;
                p[0] <<= shiftAmount;
                p[1] <<= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeftFast_Base(Vector<ulong> value, int shiftAmount) {
                return ShiftLeftFast_Base(value.AsInt64(), shiftAmount).AsUInt64();
            }


            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    if (Vector.IsHardwareAccelerated) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.Int32;
#endif // BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
#if SOFTWARE_OPTIMIZATION && NET7_0_OR_GREATER
                        rt |= TypeCodeFlags.SByte | TypeCodeFlags.Int64; // ShiftRightArithmeticFast_Negative.
#endif // SOFTWARE_OPTIMIZATION
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic(Vector<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET_X_0_OR_GREATER
                return Vector.ShiftRightArithmetic(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightArithmetic_Negative(value, shiftAmount);
#else
                return ShiftRightArithmetic_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmetic(Vector<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightArithmetic(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightArithmetic_Negative(value, shiftAmount);
#else
                return ShiftRightArithmetic_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmetic(Vector<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightArithmetic(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightArithmetic_Negative(value, shiftAmount);
#else
                return ShiftRightArithmetic_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmetic(Vector<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET_X_0_OR_GREATER
                return Vector.ShiftRightArithmetic(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION && NET7_0_OR_GREATER
                return ShiftRightArithmetic_Negative(value, shiftAmount);
#else
                return ShiftRightArithmetic_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<sbyte> ShiftRightArithmetic_Base(Vector<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<short> ShiftRightArithmetic_Base(Vector<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<int> ShiftRightArithmetic_Base(Vector<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<long> ShiftRightArithmetic_Base(Vector<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic_Negative(Vector<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightArithmeticFast_Negative(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmetic_Negative(Vector<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightArithmeticFast_Negative(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmetic_Negative(Vector<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightArithmeticFast_Negative(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmetic_Negative(Vector<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightArithmeticFast_Negative(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmeticFast(Vector<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET_X_0_OR_GREATER
                return Vector.ShiftRightArithmetic(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightArithmeticFast_Negative(value, shiftAmount);
#else
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmeticFast(Vector<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightArithmetic(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightArithmeticFast_Negative(value, shiftAmount);
#else
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmeticFast(Vector<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightArithmetic(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightArithmeticFast_Negative(value, shiftAmount);
#else
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmeticFast(Vector<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET_X_0_OR_GREATER
                return Vector.ShiftRightArithmetic(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION && NET7_0_OR_GREATER
                return ShiftRightArithmeticFast_Negative(value, shiftAmount);
#else
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<sbyte> ShiftRightArithmeticFast_Base(Vector<sbyte> value, int shiftAmount) {
                Vector<sbyte> rt = value;
                sbyte* p = (sbyte*)&rt;
                p[0] >>= shiftAmount;
                p[1] >>= shiftAmount;
                p[2] >>= shiftAmount;
                p[3] >>= shiftAmount;
                p[4] >>= shiftAmount;
                p[5] >>= shiftAmount;
                p[6] >>= shiftAmount;
                p[7] >>= shiftAmount;
                p[8] >>= shiftAmount;
                p[9] >>= shiftAmount;
                p[10] >>= shiftAmount;
                p[11] >>= shiftAmount;
                p[12] >>= shiftAmount;
                p[13] >>= shiftAmount;
                p[14] >>= shiftAmount;
                p[15] >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<short> ShiftRightArithmeticFast_Base(Vector<short> value, int shiftAmount) {
                Vector<short> rt = value;
                short* p = (short*)&rt;
                p[0] >>= shiftAmount;
                p[1] >>= shiftAmount;
                p[2] >>= shiftAmount;
                p[3] >>= shiftAmount;
                p[4] >>= shiftAmount;
                p[5] >>= shiftAmount;
                p[6] >>= shiftAmount;
                p[7] >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<int> ShiftRightArithmeticFast_Base(Vector<int> value, int shiftAmount) {
                Vector<int> rt = value;
                int* p = (int*)&rt;
                p[0] >>= shiftAmount;
                p[1] >>= shiftAmount;
                p[2] >>= shiftAmount;
                p[3] >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<long> ShiftRightArithmeticFast_Base(Vector<long> value, int shiftAmount) {
                Vector<long> rt = value;
                long* p = (long*)&rt;
                p[0] >>= shiftAmount;
                p[1] >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<sbyte> ShiftRightArithmeticFast_Negative(Vector<sbyte> value, int shiftAmount) {
#if NET7_0_OR_GREATER
                Vector<sbyte> shifted = Vector.ShiftRightLogical(value.AsUInt16(), shiftAmount).AsSByte();
#else
                Vector<sbyte> shifted = ShiftRightLogicalFast(value.AsUInt64(), shiftAmount).AsSByte();
#endif // NET7_0_OR_GREATER
                Vector<sbyte> mask = Vectors<sbyte>.GetMaskBits(8 - shiftAmount);
                Vector<sbyte> sign = Vector.GreaterThan(Vector<sbyte>.Zero, value);
                Vector<sbyte> rt = Vector.ConditionalSelect(mask, shifted, sign);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmeticFast_Negative(Vector<short> value, int shiftAmount) {
#if NET7_0_OR_GREATER
                Vector<short> shifted = Vector.ShiftRightLogical(value, shiftAmount);
#else
                Vector<short> shifted = ShiftRightLogicalFast(value.AsUInt64(), shiftAmount).AsInt16();
#endif // NET7_0_OR_GREATER
                Vector<short> mask = Vectors<short>.GetMaskBits(16 - shiftAmount);
                Vector<short> sign = Vector.GreaterThan(Vector<short>.Zero, value);
                Vector<short> rt = Vector.ConditionalSelect(mask, shifted, sign);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmeticFast_Negative(Vector<int> value, int shiftAmount) {
#if NET7_0_OR_GREATER
                Vector<int> shifted = Vector.ShiftRightLogical(value, shiftAmount);
#else
                Vector<int> shifted = ShiftRightLogicalFast(value.AsUInt64(), shiftAmount).AsInt32();
#endif // NET7_0_OR_GREATER
                Vector<int> mask = Vectors<int>.GetMaskBits(32 - shiftAmount);
                Vector<int> sign = Vector.GreaterThan(Vector<int>.Zero, value);
                Vector<int> rt = Vector.ConditionalSelect(mask, shifted, sign);
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmeticFast_Negative(Vector<long> value, int shiftAmount) {
#if NET7_0_OR_GREATER
                Vector<long> shifted = Vector.ShiftRightLogical(value, shiftAmount);
#else
                Vector<long> shifted = ShiftRightLogicalFast(value.AsUInt64(), shiftAmount).AsInt64();
#endif // NET7_0_OR_GREATER
                Vector<long> mask = Vectors<long>.GetMaskBits(64 - shiftAmount);
                Vector<long> sign = Vector.GreaterThan(Vector<long>.Zero, value);
                Vector<long> rt = Vector.ConditionalSelect(mask, shifted, sign);
                return rt;
            }


            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightLogical_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    if (Vector.IsHardwareAccelerated) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
#endif // BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
#if SOFTWARE_OPTIMIZATION && NET7_0_OR_GREATER
                        rt |= TypeCodeFlags.SByte | TypeCodeFlags.Byte; // ShiftRightLogicalFast_Widen
#endif // SOFTWARE_OPTIMIZATION
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightLogical(Vector<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET_X_0_OR_GREATER
                return Vector.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightLogical_Widen(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogical(Vector<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET_X_0_OR_GREATER
                return Vector.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightLogical_Widen(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogical(Vector<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightLogical(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightLogical_Widen(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftRightLogical(Vector<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightLogical(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightLogical_Widen(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogical(Vector<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightLogical(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightLogical_Widen(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftRightLogical(Vector<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightLogical(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightLogical_Widen(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightLogical(Vector<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightLogical(value, shiftAmount);
//#elif SOFTWARE_OPTIMIZATION
//                return ShiftRightLogical_Widen(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftRightLogical(Vector<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightLogical(value, shiftAmount);
//#elif SOFTWARE_OPTIMIZATION
//                return ShiftRightLogical_Widen(value, shiftAmount);
#else
                return ShiftRightLogical_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<sbyte> ShiftRightLogical_Base(Vector<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<byte> ShiftRightLogical_Base(Vector<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<short> ShiftRightLogical_Base(Vector<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<ushort> ShiftRightLogical_Base(Vector<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<int> ShiftRightLogical_Base(Vector<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<uint> ShiftRightLogical_Base(Vector<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<long> ShiftRightLogical_Base(Vector<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<ulong> ShiftRightLogical_Base(Vector<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightLogical_Widen(Vector<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogicalFast_Widen(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogical_Widen(Vector<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogicalFast_Widen(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogical_Widen(Vector<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogicalFast_Widen(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftRightLogical_Widen(Vector<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogicalFast_Widen(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogical_Widen(Vector<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogicalFast_Widen(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftRightLogical_Widen(Vector<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogicalFast_Widen(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightLogicalFast(Vector<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET_X_0_OR_GREATER
                return Vector.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightLogicalFast_Widen(value, shiftAmount);
#else
                return ShiftRightLogicalFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogicalFast(Vector<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET_X_0_OR_GREATER
                return Vector.ShiftRightLogical(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightLogicalFast_Widen(value, shiftAmount);
#else
                return ShiftRightLogicalFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogicalFast(Vector<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightLogical(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightLogicalFast_Widen(value, shiftAmount);
#else
                return ShiftRightLogicalFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftRightLogicalFast(Vector<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightLogical(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightLogicalFast_Widen(value, shiftAmount);
#else
                return ShiftRightLogicalFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogicalFast(Vector<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightLogical(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightLogicalFast_Widen(value, shiftAmount);
#else
                return ShiftRightLogicalFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftRightLogicalFast(Vector<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightLogical(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightLogicalFast_Widen(value, shiftAmount);
#else
                return ShiftRightLogicalFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightLogicalFast(Vector<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightLogical(value, shiftAmount);
//#elif SOFTWARE_OPTIMIZATION
//                return ShiftRightLogicalFast_Widen(value, shiftAmount);
#else
                return ShiftRightLogicalFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftRightLogicalFast(Vector<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightLogical(value, shiftAmount);
//#elif SOFTWARE_OPTIMIZATION
//                return ShiftRightLogicalFast_Widen(value, shiftAmount);
#else
                return ShiftRightLogicalFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<sbyte> ShiftRightLogicalFast_Base(Vector<sbyte> value, int shiftAmount) {
                return ShiftRightLogicalFast_Base(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<byte> ShiftRightLogicalFast_Base(Vector<byte> value, int shiftAmount) {
                Vector<byte> rt = value;
                byte* p = (byte*)&rt;
                p[0] >>= shiftAmount;
                p[1] >>= shiftAmount;
                p[2] >>= shiftAmount;
                p[3] >>= shiftAmount;
                p[4] >>= shiftAmount;
                p[5] >>= shiftAmount;
                p[6] >>= shiftAmount;
                p[7] >>= shiftAmount;
                p[8] >>= shiftAmount;
                p[9] >>= shiftAmount;
                p[10] >>= shiftAmount;
                p[11] >>= shiftAmount;
                p[12] >>= shiftAmount;
                p[13] >>= shiftAmount;
                p[14] >>= shiftAmount;
                p[15] >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<short> ShiftRightLogicalFast_Base(Vector<short> value, int shiftAmount) {
                return ShiftRightLogicalFast_Base(value.AsUInt16(), shiftAmount).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<ushort> ShiftRightLogicalFast_Base(Vector<ushort> value, int shiftAmount) {
                Vector<ushort> rt = value;
                ushort* p = (ushort*)&rt;
                p[0] >>= shiftAmount;
                p[1] >>= shiftAmount;
                p[2] >>= shiftAmount;
                p[3] >>= shiftAmount;
                p[4] >>= shiftAmount;
                p[5] >>= shiftAmount;
                p[6] >>= shiftAmount;
                p[7] >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<int> ShiftRightLogicalFast_Base(Vector<int> value, int shiftAmount) {
                return ShiftRightLogicalFast_Base(value.AsUInt32(), shiftAmount).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<uint> ShiftRightLogicalFast_Base(Vector<uint> value, int shiftAmount) {
                Vector<uint> rt = value;
                uint* p = (uint*)&rt;
                p[0] >>= shiftAmount;
                p[1] >>= shiftAmount;
                p[2] >>= shiftAmount;
                p[3] >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<long> ShiftRightLogicalFast_Base(Vector<long> value, int shiftAmount) {
                return ShiftRightLogicalFast_Base(value.AsUInt64(), shiftAmount).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<ulong> ShiftRightLogicalFast_Base(Vector<ulong> value, int shiftAmount) {
                Vector<ulong> rt = value;
                ulong* p = (ulong*)&rt;
                p[0] >>= shiftAmount;
                p[1] >>= shiftAmount;
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<sbyte> ShiftRightLogicalFast_Widen(Vector<sbyte> value, int shiftAmount) {
                return ShiftRightLogicalFast_Widen(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogicalFast_Widen(Vector<byte> value, int shiftAmount) {
#if NET7_0_OR_GREATER
                Vector<byte> t = Vector.ShiftRightLogical(value.AsUInt64(), shiftAmount).AsByte();
#else
                Vector<byte> t = ShiftRightLogicalFast_Base(value.AsUInt64(), shiftAmount).AsByte();
#endif
                Vector<byte> rt = Vector.BitwiseAnd(t, Vectors<byte>.GetMaskBits(8 - shiftAmount));
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogicalFast_Widen(Vector<short> value, int shiftAmount) {
                return ShiftRightLogicalFast_Widen(value.AsUInt16(), shiftAmount).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<ushort> ShiftRightLogicalFast_Widen(Vector<ushort> value, int shiftAmount) {
#if NET7_0_OR_GREATER
                Vector<ushort> t = Vector.ShiftRightLogical(value.AsUInt64(), shiftAmount).AsUInt16();
#else
                Vector<ushort> t = ShiftRightLogicalFast_Base(value.AsUInt64(), shiftAmount).AsUInt16();
#endif
                Vector<ushort> rt = Vector.BitwiseAnd(t, Vectors<ushort>.GetMaskBits(16 - shiftAmount));
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogicalFast_Widen(Vector<int> value, int shiftAmount) {
                return ShiftRightLogicalFast_Widen(value.AsUInt32(), shiftAmount).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<uint> ShiftRightLogicalFast_Widen(Vector<uint> value, int shiftAmount) {
#if NET7_0_OR_GREATER
                Vector<uint> t = Vector.ShiftRightLogical(value.AsUInt64(), shiftAmount).AsUInt32();
#else
                Vector<uint> t = ShiftRightLogicalFast_Base(value.AsUInt64(), shiftAmount).AsUInt32();
#endif
                Vector<uint> rt = Vector.BitwiseAnd(t, Vectors<uint>.GetMaskBits(32 - shiftAmount));
                return rt;
            }


            /// <inheritdoc cref="IVectorTraits.Widen_AcceleratedTypes"/>
            public static TypeCodeFlags Widen_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
#if BCL_OVERRIDE_BASE_FIXED
                    if (Vector.IsHardwareAccelerated) {
                        rt |= TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
                    }
#endif // BCL_OVERRIDE_BASE_FIXED
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{float}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<float> source, out Vector<double> lower, out Vector<double> upper) {
#if BCL_OVERRIDE_BASE_FIXED
                Vector.Widen(source, out lower, out upper);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{sbyte}, out Vector{short}, out Vector{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<sbyte> source, out Vector<short> lower, out Vector<short> upper) {
#if BCL_OVERRIDE_BASE_FIXED
                Vector.Widen(source, out lower, out upper);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{byte}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<byte> source, out Vector<ushort> lower, out Vector<ushort> upper) {
#if BCL_OVERRIDE_BASE_FIXED
                Vector.Widen(source, out lower, out upper);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{short}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<short> source, out Vector<int> lower, out Vector<int> upper) {
#if BCL_OVERRIDE_BASE_FIXED
                Vector.Widen(source, out lower, out upper);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{ushort}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<ushort> source, out Vector<uint> lower, out Vector<uint> upper) {
#if BCL_OVERRIDE_BASE_FIXED
                Vector.Widen(source, out lower, out upper);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
#if BCL_OVERRIDE_BASE_FIXED
                Vector.Widen(source, out lower, out upper);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{uint}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen(Vector<uint> source, out Vector<ulong> lower, out Vector<ulong> upper) {
#if BCL_OVERRIDE_BASE_FIXED
                Vector.Widen(source, out lower, out upper);
#else
                Widen_Base(source, out lower, out upper);
#endif // BCL_OVERRIDE_BASE_FIXED
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{float}, out Vector{double}, out Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe void Widen_Base(Vector<float> source, out Vector<double> lower, out Vector<double> upper) {
                float* p = (float*)&source;
                fixed (void* plower0 = &lower, pupper0 = &upper) {
                    double* plower = (double*)plower0;
                    double* pupper = (double*)pupper0;
                    plower[0] = p[0];
                    plower[1] = p[1];
                    pupper[0] = p[2];
                    pupper[1] = p[3];
                }
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{sbyte}, out Vector{short}, out Vector{short})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe void Widen_Base(Vector<sbyte> source, out Vector<short> lower, out Vector<short> upper) {
                sbyte* p = (sbyte*)&source;
                fixed (void* plower0 = &lower, pupper0 = &upper) {
                    short* plower = (short*)plower0;
                    short* pupper = (short*)pupper0;
                    plower[0] = p[0];
                    plower[1] = p[1];
                    plower[2] = p[2];
                    plower[3] = p[3];
                    plower[4] = p[4];
                    plower[5] = p[5];
                    plower[6] = p[6];
                    plower[7] = p[7];
                    pupper[0] = p[8];
                    pupper[1] = p[9];
                    pupper[2] = p[10];
                    pupper[3] = p[11];
                    pupper[4] = p[12];
                    pupper[5] = p[13];
                    pupper[6] = p[14];
                    pupper[7] = p[15];
                }
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{byte}, out Vector{ushort}, out Vector{ushort})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe void Widen_Base(Vector<byte> source, out Vector<ushort> lower, out Vector<ushort> upper) {
                byte* p = (byte*)&source;
                fixed (void* plower0 = &lower, pupper0 = &upper) {
                    ushort* plower = (ushort*)plower0;
                    ushort* pupper = (ushort*)pupper0;
                    plower[0] = p[0];
                    plower[1] = p[1];
                    plower[2] = p[2];
                    plower[3] = p[3];
                    plower[4] = p[4];
                    plower[5] = p[5];
                    plower[6] = p[6];
                    plower[7] = p[7];
                    pupper[0] = p[8];
                    pupper[1] = p[9];
                    pupper[2] = p[10];
                    pupper[3] = p[11];
                    pupper[4] = p[12];
                    pupper[5] = p[13];
                    pupper[6] = p[14];
                    pupper[7] = p[15];
                }
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{short}, out Vector{int}, out Vector{int})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe void Widen_Base(Vector<short> source, out Vector<int> lower, out Vector<int> upper) {
                short* p = (short*)&source;
                fixed (void* plower0 = &lower, pupper0 = &upper) {
                    int* plower = (int*)plower0;
                    int* pupper = (int*)pupper0;
                    plower[0] = p[0];
                    plower[1] = p[1];
                    plower[2] = p[2];
                    plower[3] = p[3];
                    pupper[0] = p[4];
                    pupper[1] = p[5];
                    pupper[2] = p[6];
                    pupper[3] = p[7];
                }
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{ushort}, out Vector{uint}, out Vector{uint})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe void Widen_Base(Vector<ushort> source, out Vector<uint> lower, out Vector<uint> upper) {
                ushort* p = (ushort*)&source;
                fixed (void* plower0 = &lower, pupper0 = &upper) {
                    uint* plower = (uint*)plower0;
                    uint* pupper = (uint*)pupper0;
                    plower[0] = p[0];
                    plower[1] = p[1];
                    plower[2] = p[2];
                    plower[3] = p[3];
                    pupper[0] = p[4];
                    pupper[1] = p[5];
                    pupper[2] = p[6];
                    pupper[3] = p[7];
                }
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
#if UNSAFE
                Widen_Base_Ptr(source, out lower, out upper);
#else
                Widen_Base_Ref(source, out lower, out upper);
#endif // UNSAFE
            }

#if UNSAFE
            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe void Widen_Base_Ptr(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
                int* p = (int*)&source;
                fixed (void* plower0 = &lower, pupper0 = &upper) {
                    long* plower = (long*)plower0;
                    long* pupper = (long*)pupper0;
                    plower[0] = p[0];
                    plower[1] = p[1];
                    pupper[0] = p[2];
                    pupper[1] = p[3];
                }
            }
#endif // UNSAFE

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base_Ref(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref int p = ref Unsafe.As<Vector<int>, int>(ref source);
                ref long plower = ref Unsafe.As<Vector<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector<long>, long>(ref upper);
                plower = p;
                Unsafe.Add(ref plower, 1) = Unsafe.Add(ref p, 1);
                p = ref Unsafe.Add(ref p, Vector<long>.Count);
                pupper = p;
                Unsafe.Add(ref pupper, 1) = Unsafe.Add(ref p, 1);
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [Obsolete("This method is for testing purposes only. Please use Widen_Base instead.")]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base_Ref2(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref int p = ref Unsafe.As<Vector<int>, int>(ref source);
                ref int q = ref Unsafe.Add(ref p, 2);
                ref long plower = ref Unsafe.As<Vector<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector<long>, long>(ref upper);
                plower = p;
                Unsafe.Add(ref plower, 1) = Unsafe.Add(ref p, 1);
                pupper = q;
                Unsafe.Add(ref pupper, 1) = Unsafe.Add(ref q, 1);
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [Obsolete("This method is for testing purposes only. Please use Widen_Base instead.")]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base_RefI(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref int p = ref Unsafe.As<Vector<int>, int>(ref source);
                ref long plower = ref Unsafe.As<Vector<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector<long>, long>(ref upper);
                nint i = 0;
                Unsafe.Add(ref plower, i) = Unsafe.Add(ref p, i); Unsafe.Add(ref pupper, i) = Unsafe.Add(ref p, 2 + i); ++i;
                Unsafe.Add(ref plower, i) = Unsafe.Add(ref p, i); Unsafe.Add(ref pupper, i) = Unsafe.Add(ref p, 2 + i);
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [Obsolete("This method is for testing purposes only. Please use Widen_Base instead.")]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base_RefI2(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref int p = ref Unsafe.As<Vector<int>, int>(ref source);
                ref int q = ref Unsafe.Add(ref p, 2);
                ref long plower = ref Unsafe.As<Vector<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector<long>, long>(ref upper);
                plower = p; pupper = q;
                nint i = 1;
                Unsafe.Add(ref plower, i) = Unsafe.Add(ref p, i); Unsafe.Add(ref pupper, i) = Unsafe.Add(ref q, i);
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [Obsolete("This method is for testing purposes only. Please use Widen_Base instead.")]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base_RefInc(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
                nint cntOut = 2; // Vector<long>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref int p = ref Unsafe.As<Vector<int>, int>(ref source);
                ref long plower = ref Unsafe.As<Vector<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector<long>, long>(ref upper);
                plower = p; pupper = Unsafe.Add(ref p, cntOut); plower = ref Unsafe.Add(ref plower, 1); pupper = ref Unsafe.Add(ref pupper, 1); p = ref Unsafe.Add(ref p, 1);
                plower = p; pupper = Unsafe.Add(ref p, cntOut);
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{int}, out Vector{long}, out Vector{long})"/>
            [Obsolete("This method is for testing purposes only. Please use Widen_Base instead.")]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Widen_Base_RefInc2(Vector<int> source, out Vector<long> lower, out Vector<long> upper) {
                nint cntOut = 2; // Vector<long>.Count;
                UnsafeEx.SkipInit(out lower);
                UnsafeEx.SkipInit(out upper);
                ref int p = ref Unsafe.As<Vector<int>, int>(ref source);
                ref int q = ref Unsafe.Add(ref p, cntOut);
                ref long plower = ref Unsafe.As<Vector<long>, long>(ref lower);
                ref long pupper = ref Unsafe.As<Vector<long>, long>(ref upper);
                plower = p; pupper = q; p = ref Unsafe.Add(ref p, 1); q = ref Unsafe.Add(ref q, 1); plower = ref Unsafe.Add(ref plower, 1); pupper = ref Unsafe.Add(ref pupper, 1);
                plower = p; pupper = q;
            }

            /// <inheritdoc cref="IVectorTraits.Widen(Vector{uint}, out Vector{ulong}, out Vector{ulong})"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe void Widen_Base(Vector<uint> source, out Vector<ulong> lower, out Vector<ulong> upper) {
                uint* p = (uint*)&source;
                fixed (void* plower0 = &lower, pupper0 = &upper) {
                    ulong* plower = (ulong*)plower0;
                    ulong* pupper = (ulong*)pupper0;
                    plower[0] = p[0];
                    plower[1] = p[1];
                    pupper[0] = p[2];
                    pupper[1] = p[3];
                }
            }

        } // Statics
    }
}
