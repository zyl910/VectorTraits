using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using System.Numerics;
using System.ComponentModel;
using Zyl.VectorTraits.Extensions.SameW;

namespace Zyl.VectorTraits.Impl {

    /// <summary>
    /// <see cref="Vector{T}"/> traits - Variable base.
    /// </summary>
    public sealed class VectorTraitsBase : VectorTraitsAbstract {
        private static readonly VectorTraitsBase _instance = new VectorTraitsBase(); // Default instance.

        /// <summary>Default instance. </summary>
        public static VectorTraitsBase Instance {
            get { return _instance; }
        }

        /// <summary>
        /// <see cref="Vector{T}"/> traits.Statics - Variable base.
        /// </summary>
        public static class Statics {

            /// <inheritdoc cref="IBaseTraits.ByteCount"/>
            public static int ByteCount {
                get { return Vector<byte>.Count; }
            }

            /// <inheritdoc cref="IBaseTraits.IsSupported"/>
            public static bool IsSupported {
                get {
                    return true;
                }
            }

            /// <inheritdoc cref="IBaseTraits.GetIsSupported"/>
            public static bool GetIsSupported(bool noStrict = false) {
                if (!noStrict) {
                }
                return true;
            }

            /// <inheritdoc cref="IBaseTraits.GetUnsupportedMessage"/>
            public static string GetUnsupportedMessage(bool noStrict = false) {
                if (!noStrict) {
                }
                return "Vector type is not supported!";
            }

            /// <inheritdoc cref="IBaseTraits.ThrowForUnsupported"/>
            public static void ThrowForUnsupported(bool noStrict = false) {
                if (GetIsSupported(noStrict)) return;
                throw new NotSupportedException(GetUnsupportedMessage(noStrict));
            }


            /// <inheritdoc cref="IVectorTraits.ShiftLeft_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftLeft_AcceleratedTypes {
                get {
                    return ShiftLeftFast_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeft(Vector<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET_X_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return ShiftLeft_Multiply(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft(Vector<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET_X_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return ShiftLeft_Multiply(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft(Vector<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftLeft_Multiply(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeft(Vector<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftLeft_Multiply(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft(Vector<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftLeft_Multiply(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeft(Vector<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftLeft_Multiply(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftLeft(Vector<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
//#elif SOFTWARE_OPTIMIZATION
//                return ShiftLeft_Multiply(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeft(Vector<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
//#elif SOFTWARE_OPTIMIZATION
//                return ShiftLeft_Multiply(value, shiftAmount);
#else
                return ShiftLeft_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<sbyte> ShiftLeft_Base(Vector<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{byte}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<byte> ShiftLeft_Base(Vector<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<short> ShiftLeft_Base(Vector<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<ushort> ShiftLeft_Base(Vector<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<int> ShiftLeft_Base(Vector<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<uint> ShiftLeft_Base(Vector<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{long}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<long> ShiftLeft_Base(Vector<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<ulong> ShiftLeft_Base(Vector<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftLeftFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeft_Multiply(Vector<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeftFast_Multiply(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{byte}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeft_Multiply(Vector<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftLeftFast_Multiply(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeft_Multiply(Vector<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeftFast_Multiply(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeft_Multiply(Vector<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftLeftFast_Multiply(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{int}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeft_Multiply(Vector<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeftFast_Multiply(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeft_Multiply(Vector<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftLeftFast_Multiply(value, shiftAmount);
            }

            // No hardware acceleration!
            ///// <inheritdoc cref="IVectorTraits.ShiftLeft(Vector{long}, int)"/>
            //[EditorBrowsable(EditorBrowsableState.Never)]
            //[MethodImpl(MethodImplOptions.AggressiveInlining)]
            //public static Vector<long> ShiftLeft_Multiply(Vector<long> value, int shiftAmount) {
            //    shiftAmount &= 0x3F;
            //    return ShiftLeftFast_Multiply(value, shiftAmount);
            //}

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftLeftFast_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    if (Vector.IsHardwareAccelerated) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32 | TypeCodeFlags.Int64 | TypeCodeFlags.UInt64;
#endif // BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
#if SOFTWARE_OPTIMIZATION
                        rt |= TypeCodeFlags.SByte | TypeCodeFlags.Byte | TypeCodeFlags.Int16 | TypeCodeFlags.UInt16 | TypeCodeFlags.Int32 | TypeCodeFlags.UInt32;
#endif // SOFTWARE_OPTIMIZATION
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftLeftFast(Vector<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET_X_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return ShiftLeftFast_Multiply(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{byte}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeftFast(Vector<byte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET_X_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return ShiftLeftFast_Multiply(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{short}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeftFast(Vector<short> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftLeftFast_Multiply(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftLeftFast(Vector<ushort> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftLeftFast_Multiply(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{int}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeftFast(Vector<int> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftLeftFast_Multiply(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<uint> ShiftLeftFast(Vector<uint> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
#elif SOFTWARE_OPTIMIZATION
                return ShiftLeftFast_Multiply(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftLeftFast(Vector<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
//#elif SOFTWARE_OPTIMIZATION
//                return ShiftLeftFast_Multiply(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ulong> ShiftLeftFast(Vector<ulong> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftLeft(value, shiftAmount);
//#elif SOFTWARE_OPTIMIZATION
//                return ShiftLeftFast_Multiply(value, shiftAmount);
#else
                return ShiftLeftFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<sbyte> ShiftLeftFast_Base(Vector<sbyte> value, int shiftAmount) {
                return ShiftLeftFast_Base(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{byte}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<byte> ShiftLeftFast_Base(Vector<byte> value, int shiftAmount) {
                Vector<byte> rt = value;
                int cnt = Vector<byte>.Count;
                byte* p = (byte*)&rt;
                for (int i = 0; i < cnt; ++i) {
                    p[i] <<= shiftAmount;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<short> ShiftLeftFast_Base(Vector<short> value, int shiftAmount) {
                Vector<short> rt = value;
                int cnt = Vector<short>.Count;
                short* p = (short*)&rt;
                for (int i = 0; i < cnt; ++i) {
                    p[i] <<= shiftAmount;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<ushort> ShiftLeftFast_Base(Vector<ushort> value, int shiftAmount) {
                return ShiftLeftFast_Base(value.AsInt16(), shiftAmount).AsUInt16();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{int}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<int> ShiftLeftFast_Base(Vector<int> value, int shiftAmount) {
                Vector<int> rt = value;
                int cnt = Vector<int>.Count;
                int* p = (int*)&rt;
                for (int i = 0; i < cnt; ++i) {
                    p[i] <<= shiftAmount;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<uint> ShiftLeftFast_Base(Vector<uint> value, int shiftAmount) {
                return ShiftLeftFast_Base(value.AsInt32(), shiftAmount).AsUInt32();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{long}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<long> ShiftLeftFast_Base(Vector<long> value, int shiftAmount) {
                Vector<long> rt = value;
                int cnt = Vector<long>.Count;
                long* p = (long*)&rt;
                for (int i = 0; i < cnt; ++i) {
                    p[i] <<= shiftAmount;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<ulong> ShiftLeftFast_Base(Vector<ulong> value, int shiftAmount) {
                return ShiftLeftFast_Base(value.AsInt64(), shiftAmount).AsUInt64();
            }
            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<sbyte> ShiftLeftFast_Multiply(Vector<sbyte> value, int shiftAmount) {
                return ShiftLeftFast_Multiply(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{byte}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftLeftFast_Multiply(Vector<byte> value, int shiftAmount) {
                Vector<byte> t = Vector.BitwiseAnd(value, Vectors<byte>.GetMaskBits(8 - shiftAmount));
                int m = 1 << shiftAmount;
                return Vector.AsVectorByte(Vector.Multiply(Vector.AsVectorInt32(t), m));
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftLeftFast_Multiply(Vector<short> value, int shiftAmount) {
                short m = (short)(1 << shiftAmount);
                return Vector.Multiply(value, m);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<ushort> ShiftLeftFast_Multiply(Vector<ushort> value, int shiftAmount) {
                return ShiftLeftFast_Multiply(value.AsInt16(), shiftAmount).AsUInt16();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{int}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftLeftFast_Multiply(Vector<int> value, int shiftAmount) {
                int m = 1 << shiftAmount;
                return Vector.Multiply(value, m);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<uint> ShiftLeftFast_Multiply(Vector<uint> value, int shiftAmount) {
                return ShiftLeftFast_Multiply(value.AsInt32(), shiftAmount).AsUInt32();
            }

            // No hardware acceleration!
            ///// <inheritdoc cref="IVectorTraits.ShiftLeftFast(Vector{long}, int)"/>
            //[EditorBrowsable(EditorBrowsableState.Never)]
            //[MethodImpl(MethodImplOptions.AggressiveInlining)]
            //public static Vector<long> ShiftLeftFast_Multiply(Vector<long> value, int shiftAmount) {
            //    int m = 1 << shiftAmount;
            //    return Vector.Multiply(value, m);
            //}


            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightArithmetic_AcceleratedTypes {
                get {
                    return ShiftRightArithmeticFast_AcceleratedTypes;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic(Vector<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET_X_0_OR_GREATER
                return Vector.ShiftRightArithmetic(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightArithmetic_Bit64(value, shiftAmount);
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
                return ShiftRightArithmetic_Bit64(value, shiftAmount);
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
                return ShiftRightArithmetic_Bit64(value, shiftAmount);
#else
                return ShiftRightArithmetic_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmetic(Vector<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightArithmetic(value, shiftAmount);
//#elif SOFTWARE_OPTIMIZATION
//                return ShiftRightArithmetic_Bit64(value, shiftAmount);
#else
                return ShiftRightArithmetic_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<sbyte> ShiftRightArithmetic_Base(Vector<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<short> ShiftRightArithmetic_Base(Vector<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{int}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<int> ShiftRightArithmetic_Base(Vector<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{long}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<long> ShiftRightArithmetic_Base(Vector<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmetic_Bit64(Vector<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightArithmeticFast_Bit64(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmetic_Bit64(Vector<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightArithmeticFast_Bit64(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{int}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmetic_Bit64(Vector<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightArithmeticFast_Bit64(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftRightArithmeticFast_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    if (Vector.IsHardwareAccelerated) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                        rt |= TypeCodeFlags.Int16 | TypeCodeFlags.Int32;
#endif // BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
#if SOFTWARE_OPTIMIZATION
#endif // SOFTWARE_OPTIMIZATION
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightArithmeticFast(Vector<sbyte> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET_X_0_OR_GREATER
                return Vector.ShiftRightArithmetic(value, shiftAmount); // .NET7 no hardware acceleration! X86(sse, avx)
#elif SOFTWARE_OPTIMIZATION
                return ShiftRightArithmeticFast_Bit64(value, shiftAmount);
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
                return ShiftRightArithmeticFast_Bit64(value, shiftAmount);
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
                return ShiftRightArithmeticFast_Bit64(value, shiftAmount);
#else
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{long}, int)"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<long> ShiftRightArithmeticFast(Vector<long> value, int shiftAmount) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.ShiftRightArithmetic(value, shiftAmount);
//#elif SOFTWARE_OPTIMIZATION
//                return ShiftRightArithmeticFast_Bit64(value, shiftAmount);
#else
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
#endif // BCL_OVERRIDE_BASE_VAR
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<sbyte> ShiftRightArithmeticFast_Base(Vector<sbyte> value, int shiftAmount) {
                Vector<sbyte> rt = value;
                int cnt = Vector<sbyte>.Count;
                sbyte* p = (sbyte*)&rt;
                for (int i = 0; i < cnt; ++i) {
                    p[i] >>= shiftAmount;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<short> ShiftRightArithmeticFast_Base(Vector<short> value, int shiftAmount) {
                Vector<short> rt = value;
                int cnt = Vector<short>.Count;
                short* p = (short*)&rt;
                for (int i = 0; i < cnt; ++i) {
                    p[i] >>= shiftAmount;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{int}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<int> ShiftRightArithmeticFast_Base(Vector<int> value, int shiftAmount) {
                Vector<int> rt = value;
                int cnt = Vector<int>.Count;
                int* p = (int*)&rt;
                for (int i = 0; i < cnt; ++i) {
                    p[i] >>= shiftAmount;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{long}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<long> ShiftRightArithmeticFast_Base(Vector<long> value, int shiftAmount) {
                Vector<long> rt = value;
                int cnt = Vector<long>.Count;
                long* p = (long*)&rt;
                for (int i = 0; i < cnt; ++i) {
                    p[i] >>= shiftAmount;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<sbyte> ShiftRightArithmeticFast_Bit64(Vector<sbyte> value, int shiftAmount) {
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
                //Vector<byte> t = Vector.BitwiseAnd(value, Vectors<byte>.GetMaskBits(8 - shiftAmount));
                //int m = 1 >> shiftAmount;
                //return Vector.AsVectorByte(Vector.Multiply(Vector.AsVectorInt32(t), m));
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmeticFast_Bit64(Vector<short> value, int shiftAmount) {
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
                //short m = (short)(1 >> shiftAmount);
                //return Vector.Multiply(value, m);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmeticFast(Vector{int}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmeticFast_Bit64(Vector<int> value, int shiftAmount) {
                return ShiftRightArithmeticFast_Base(value, shiftAmount);
                //int m = 1 >> shiftAmount;
                //return Vector.Multiply(value, m);
            }


        } // Statics

    }
}
