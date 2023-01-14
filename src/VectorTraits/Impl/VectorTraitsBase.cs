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


            /// <inheritdoc cref="IVectorTraits.Ceiling_AcceleratedTypes"/>
            public static TypeCodeFlags Ceiling_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    if (Vector.IsHardwareAccelerated) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
#endif // BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Ceiling(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Ceiling(Vector<float> value) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.Ceiling(value);
#else
                return Ceiling_Base(value);
#endif // BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.Ceiling(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Ceiling(Vector<double> value) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.Ceiling(value);
#else
                return Ceiling_Base(value);
#endif // BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.Ceiling(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<float> Ceiling_Base(Vector<float> value) {
                Vector<float> rt = value;
                float* p = (float*)&rt;
                int cnt = Vector<float>.Count;
                for (int i = 0; i < cnt; ++i) {
#if NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    p[i] = MathF.Ceiling(p[i]);
#else
                    p[i] = (float)Math.Ceiling(p[i]);
#endif // NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Ceiling(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<double> Ceiling_Base(Vector<double> value) {
                Vector<double> rt = value;
                double* p = (double*)&rt;
                int cnt = Vector<double>.Count;
                for (int i = 0; i < cnt; ++i) {
                    p[i] = Math.Ceiling(p[i]);
                }
                return rt;
            }


            /// <inheritdoc cref="IVectorTraits.Floor_AcceleratedTypes"/>
            public static TypeCodeFlags Floor_AcceleratedTypes {
                get {
                    TypeCodeFlags rt = TypeCodeFlags.None;
                    if (Vector.IsHardwareAccelerated) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                        rt |= TypeCodeFlags.Single | TypeCodeFlags.Double;
#endif // BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                    }
                    return rt;
                }
            }

            /// <inheritdoc cref="IVectorTraits.Floor(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<float> Floor(Vector<float> value) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.Floor(value);
#else
                return Floor_Base(value);
#endif // BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.Floor(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<double> Floor(Vector<double> value) {
#if BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
                return Vector.Floor(value);
#else
                return Floor_Base(value);
#endif // BCL_OVERRIDE_BASE_VAR && NET7_0_OR_GREATER
            }

            /// <inheritdoc cref="IVectorTraits.Floor(Vector{float})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<float> Floor_Base(Vector<float> value) {
                Vector<float> rt = value;
                float* p = (float*)&rt;
                int cnt = Vector<float>.Count;
                for (int i = 0; i < cnt; ++i) {
#if NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    p[i] = MathF.Floor(p[i]);
#else
                    p[i] = (float)Math.Floor(p[i]);
#endif // NETCOREAPP2_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.Floor(Vector{double})"/>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<double> Floor_Base(Vector<double> value) {
                Vector<double> rt = value;
                double* p = (double*)&rt;
                int cnt = Vector<double>.Count;
                for (int i = 0; i < cnt; ++i) {
                    p[i] = Math.Floor(p[i]);
                }
                return rt;
            }


            /// <inheritdoc cref="IVectorTraits.ShiftLeft_AcceleratedTypes"/>
            public static TypeCodeFlags ShiftLeft_AcceleratedTypes {
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
            public static Vector<sbyte> ShiftRightArithmetic_Negative(Vector<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightArithmeticFast_Negative(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightArithmetic_Negative(Vector<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightArithmeticFast_Negative(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{int}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightArithmetic_Negative(Vector<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightArithmeticFast_Negative(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightArithmetic(Vector{long}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
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
            [EditorBrowsable(EditorBrowsableState.Never)]
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
            [EditorBrowsable(EditorBrowsableState.Never)]
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
            [EditorBrowsable(EditorBrowsableState.Never)]
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
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<sbyte> ShiftRightLogical_Base(Vector<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{byte}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<byte> ShiftRightLogical_Base(Vector<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<short> ShiftRightLogical_Base(Vector<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<ushort> ShiftRightLogical_Base(Vector<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{int}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<int> ShiftRightLogical_Base(Vector<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<uint> ShiftRightLogical_Base(Vector<uint> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{long}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<long> ShiftRightLogical_Base(Vector<long> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<ulong> ShiftRightLogical_Base(Vector<ulong> value, int shiftAmount) {
                shiftAmount &= 0x3F;
                return ShiftRightLogicalFast_Base(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<sbyte> ShiftRightLogical_Widen(Vector<sbyte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogicalFast_Widen(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{byte}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<byte> ShiftRightLogical_Widen(Vector<byte> value, int shiftAmount) {
                shiftAmount &= 7;
                return ShiftRightLogicalFast_Widen(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogical_Widen(Vector<short> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogicalFast_Widen(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<ushort> ShiftRightLogical_Widen(Vector<ushort> value, int shiftAmount) {
                shiftAmount &= 0x0F;
                return ShiftRightLogicalFast_Widen(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{int}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogical_Widen(Vector<int> value, int shiftAmount) {
                shiftAmount &= 0x1F;
                return ShiftRightLogicalFast_Widen(value, shiftAmount);
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogical(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
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
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<sbyte> ShiftRightLogicalFast_Base(Vector<sbyte> value, int shiftAmount) {
                return ShiftRightLogicalFast_Base(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{byte}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<byte> ShiftRightLogicalFast_Base(Vector<byte> value, int shiftAmount) {
                Vector<byte> rt = value;
                int cnt = Vector<byte>.Count;
                byte* p = (byte*)&rt;
                for (int i = 0; i < cnt; ++i) {
                    p[i] >>= shiftAmount;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{short}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<short> ShiftRightLogicalFast_Base(Vector<short> value, int shiftAmount) {
                return ShiftRightLogicalFast_Base(value.AsUInt16(), shiftAmount).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<ushort> ShiftRightLogicalFast_Base(Vector<ushort> value, int shiftAmount) {
                Vector<ushort> rt = value;
                int cnt = Vector<ushort>.Count;
                ushort* p = (ushort*)&rt;
                for (int i = 0; i < cnt; ++i) {
                    p[i] >>= shiftAmount;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{int}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<int> ShiftRightLogicalFast_Base(Vector<int> value, int shiftAmount) {
                return ShiftRightLogicalFast_Base(value.AsUInt32(), shiftAmount).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<uint> ShiftRightLogicalFast_Base(Vector<uint> value, int shiftAmount) {
                Vector<uint> rt = value;
                int cnt = Vector<uint>.Count;
                uint* p = (uint*)&rt;
                for (int i = 0; i < cnt; ++i) {
                    p[i] >>= shiftAmount;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{long}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<long> ShiftRightLogicalFast_Base(Vector<long> value, int shiftAmount) {
                return ShiftRightLogicalFast_Base(value.AsUInt64(), shiftAmount).AsInt64();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{ulong}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<ulong> ShiftRightLogicalFast_Base(Vector<ulong> value, int shiftAmount) {
                Vector<ulong> rt = value;
                int cnt = Vector<ulong>.Count;
                ulong* p = (ulong*)&rt;
                for (int i = 0; i < cnt; ++i) {
                    p[i] >>= shiftAmount;
                }
                return rt;
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{sbyte}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static unsafe Vector<sbyte> ShiftRightLogicalFast_Widen(Vector<sbyte> value, int shiftAmount) {
                return ShiftRightLogicalFast_Widen(value.AsByte(), shiftAmount).AsSByte();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{byte}, int)"/>
            [EditorBrowsable(EditorBrowsableState.Never)]
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
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<short> ShiftRightLogicalFast_Widen(Vector<short> value, int shiftAmount) {
                return ShiftRightLogicalFast_Widen(value.AsUInt16(), shiftAmount).AsInt16();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{ushort}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
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
            [EditorBrowsable(EditorBrowsableState.Never)]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static Vector<int> ShiftRightLogicalFast_Widen(Vector<int> value, int shiftAmount) {
                return ShiftRightLogicalFast_Widen(value.AsUInt32(), shiftAmount).AsInt32();
            }

            /// <inheritdoc cref="IVectorTraits.ShiftRightLogicalFast(Vector{uint}, int)"/>
            [CLSCompliant(false)]
            [EditorBrowsable(EditorBrowsableState.Never)]
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


        } // Statics

    }
}
